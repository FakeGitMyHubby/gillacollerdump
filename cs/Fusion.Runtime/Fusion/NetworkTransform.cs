using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PlayFab.InsightsModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;

namespace Fusion;

public sealed class NetworkTransform : NetworkTRSP, Action<InsightsGetDetailsResponse>, _0021_00210, Action<int>, _0021_00210, Action<int>, _0021_00210, Action<int>, _0021_00210
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Type, bool> _003C_003E9__9_0;

		public static Comparison<SimulationBehaviourUpdater.BehaviourList> _003C_003E9__9_1;

		public static Func<KeyValuePair<Type, SimulationBehaviourUpdater.BehaviourList>, string> _003C_003E9__20_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61F8]");
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

		internal bool _003CBuildTypeOrder_003Eb__9_0(Type x)
		{
			//IL_003d: Expected I4, but got Obj
			if ((object)x != null)
			{
				return x.IsInterface;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal unsafe int _003CBuildTypeOrder_003Eb__9_1(SimulationBehaviourUpdater.BehaviourList a, SimulationBehaviourUpdater.BehaviourList b)
		{
			//IL_0071: Expected I4, but got Obj
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected I4, but got Unknown
			if (a != null && b != null)
			{
				int num = a + 24;
				return ((int*)num)->CompareTo(b.ExecutionOrder);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal string _003CFindList_003Eb__20_0(KeyValuePair<Type, SimulationBehaviourUpdater.BehaviourList> x)
		{
			//IL_004e: Invalid comparison between VT and I4
			//IL_000d: Expected Obj, but got VT
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			if (x != (KeyValuePair<Type, SimulationBehaviourUpdater.BehaviourList>)(object)0)
			{
				object obj = x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+168]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+170]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v39 @ X2_v1 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public enum NetworkTransformFlags
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		DisableSharedModeInterpolation
	}

	internal enum ForecastDisabledKinematicAction
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		Force,
		// error: enumerator has no value
		Restore
	}

	public delegate void CustomForecastDelegate(NetworkTransform networkTransform, float physicsDt, AbstractPhysicsBody physicsBody, float ticksToExtrapolate, ref KinematicSnapshot localSnapshot, ref KinematicSnapshot remoteSnapshot, out KinematicSnapshot extrapolatedSnapshot);

	public delegate void ApplyCorrectionDelegate(NetworkTransform networkTransform, float physicsDt, float physicsFps, AbstractPhysicsBody physicsBody, float timeSinceLastOnCollisionEnter, ref KinematicSnapshot localSnapshot, ref KinematicSnapshot remoteSnapshot, ref KinematicSnapshot extrapolatedSnapshot);

	public bool SyncScale = false;

	public bool SyncParent;

	private Tick _initial;

	private Transform _transform;

	private bool _simulation;

	private bool _aoiEnabled;

	private bool _aoiAutoUpdateOriginal;

	private bool _autoAOIOverride;

	public NetworkTransformFlags ConfigFlags;

	private bool _render;

	private Vector3 _renderPosition;

	private Vector3 _renderScale;

	private Quaternion _renderRotation;

	private Transform _renderParent;

	public CustomForecastDelegate CustomForecast;

	public ApplyCorrectionDelegate CustomApplyCorrection;

	public AbstractPhysicsBody.CustomErrorDetectionDelegate CustomErrorDetection;

	private AbstractPhysicsBody _physicsBody;

	private bool _forecastDisabledKinematicForced;

	private bool _kinematicBeforeForecastDisabledForce;

	private int _previousTeleportKey;

	public PhysicsSettings PhysicsSettings;

	private NetworkTRSPData _remoteTRSPData;

	private NetworkPhysicsData _remotePhysicsData;

	private NetworkTransformHelpers.BodyInterpolation _previousInterpolation;

	[NonSerialized]
	private Vector3 _physicsBodyLinearVelocity;

	[NonSerialized]
	private Vector3 _remotePosition;

	[NonSerialized]
	private Quaternion _remoteRotation;

	[NonSerialized]
	private Quaternion _extrapolatedRotation;

	private bool _hasRemoteData;

	private Vector3 _extrapolatedPosition;

	private Vector3 _previousExtrapolatedPosition;

	private Vector3 _position;

	private Vector3 _previousPosition;

	private float _timeSinceLastImpactfulCollision;

	private Vector3 PositionError__BackingField;

	private Vector3 PreviousPositionError__BackingField;

	private float _accruedErrorTime;

	private float _accruedRemoteSleepIgnoreTime;

	private bool _isColliding;

	private bool _sleepNextUpdate;

	private bool _firstExecution;

	private float _physicsFps;

	[NonSerialized]
	public NetworkTransformTrace CurrentTrace;

	public bool AutoUpdateAreaOfInterestOverride
	{
		get
		{
			return _autoAOIOverride;
		}
		set
		{
			_aoiAutoUpdateOriginal = value;
			_autoAOIOverride = value;
		}
	}

	public unsafe NetworkPhysicsData PhysicsData
	{
		get
		{
			//IL_007d: Expected VT, but got I4
			//IL_0078: Expected native int or pointer, but got VT
			//IL_008c: Expected native int or pointer, but got VT
			//IL_004b: Expected VT, but got I4
			//IL_0046: Expected native int or pointer, but got VT
			//IL_005a: Expected native int or pointer, but got VT
			//IL_006a: Expected VT, but got Obj
			//IL_001b: Expected VT, but got Obj
			//IL_0016: Expected native int or pointer, but got VT
			//IL_0030: Expected VT, but got I
			//IL_002b: Expected native int or pointer, but got VT
			//IL_0038: Expected VT, but got Obj
			NetworkPhysicsData networkPhysicsData = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkPhysicsData*)(nint)networkPhysicsData)->LinearVelocity, (Vector3Compressed)0);
			_ = 0;
			((NetworkPhysicsData*)(nint)networkPhysicsData)->_flagsEncoded = 0;
			_ = 0;
			if (Ptr != null)
			{
				ArgumentNullException ex = new ArgumentNullException();
				System.Runtime.CompilerServices.Unsafe.Write(&((NetworkPhysicsData*)(nint)networkPhysicsData)->LinearVelocity, (Vector3Compressed)ex);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4 (System.ArgumentNullException)+C]");
				System.Runtime.CompilerServices.Unsafe.Write(&((NetworkPhysicsData*)(nint)networkPhysicsData)->AngularVelocity, (Vector3Compressed)0);
				return (NetworkPhysicsData)ex;
			}
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkPhysicsData*)(nint)networkPhysicsData)->LinearVelocity, (Vector3Compressed)0);
			_ = 0;
			((NetworkPhysicsData*)(nint)networkPhysicsData)->_flagsEncoded = 0;
			_ = 0;
			return (NetworkPhysicsData)this;
		}
	}

	private unsafe ref NetworkPhysicsData PhysicsState
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			ArgumentNullException ex = new ArgumentNullException();
			return ref *(NetworkPhysicsData*)ex;
		}
	}

	private unsafe ref NetworkPhysicsData RemotePhysicsData
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003f: Expected Obj, but got I
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected Ref, but got Unknown
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Fusion.NetworkObject)+5A]");
				object obj = (nint)0 & (nint)1;
				if (obj != null && ~(_hasRemoteData ? 1u : 0u) == 0)
				{
					return ref *(NetworkPhysicsData*)(this + 416);
				}
				ArgumentNullException ex = new ArgumentNullException();
				return ref *(NetworkPhysicsData*)ex;
			}
			NullReferenceException ex2 = new NullReferenceException();
			return ref *(NetworkPhysicsData*)ex2;
		}
	}

	private unsafe ref NetworkTRSPData RemoteTRSPData
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003f: Expected Obj, but got I
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected Ref, but got Unknown
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			if ((object)((SimulationBehaviour)this)._object != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Fusion.NetworkObject)+5A]");
				object obj = (nint)0 & (nint)1;
				if (obj != null && ~(_hasRemoteData ? 1u : 0u) == 0)
				{
					return ref *(NetworkTRSPData*)(this + 360);
				}
				ArgumentNullException ex = new ArgumentNullException();
				return ref *(NetworkTRSPData*)ex;
			}
			NullReferenceException ex2 = new NullReferenceException();
			return ref *(NetworkTRSPData*)ex2;
		}
	}

	public bool HasForecastEnabled
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_000b: Invalid comparison between VT and I4
			//IL_00af: Expected I4, but got Obj
			if (PhysicsSettings != (PhysicsSettings)(object)0)
			{
				NetworkRunner runner = ((SimulationBehaviour)this)._runner;
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					NetworkProjectConfig config = runner._config;
					if ((object)runner._config != null)
					{
						bool flag = !config.PhysicsForecast;
						return !flag;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			return false;
		}
	}

	public Vector3 PositionError
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		[MethodImpl((MethodImplOptions)256)]
		private set
		{
			Vector3 vector = default;
			PositionError__BackingField = vector;
		}
	}

	public Vector3 PreviousPositionError
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		[MethodImpl((MethodImplOptions)256)]
		private set
		{
			Vector3 vector = default;
			PreviousPositionError__BackingField = vector;
		}
	}

	public unsafe bool HasPhysicsBody
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_000a: Expected I4, but got Obj
			//IL_0015: Expected I4, but got Obj
			//IL_0041: Expected I4, but got Obj
			bool flag = (byte)(int)_physicsBody != 0;
			if ((int)(~_physicsBody) == 0)
			{
				bool value = ((bool*)(flag ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v3 @ X8_v1 (System.Boolean)+338] (should have been resolved before IL gen)");
			}
			return (byte)(int)_physicsBody != 0;
		}
	}

	public AbstractPhysicsBody PhysicsBody
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			AbstractPhysicsBody result = _physicsBody;
			if (_physicsBody != null)
			{
				int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
				result = (((hashCode & 1) == 0) ? null : _physicsBody);
			}
			return result;
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63C0]");
		object obj = 0;
		object obj2 = this + 160;
		_aoiAutoUpdateOriginal = _autoAOIOverride;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		PhysicsInit();
	}

	private void CopyToEngine(bool allowUpdateTransform)
	{
		//IL_00a0: Expected Obj, but got I4
		//IL_00e0: Expected VT, but got I4
		//IL_00f5: Expected VT, but got I4
		if (~(SyncParent ? 1u : 0u) != 0 || !IsMainTRSP)
		{
			if (~(SyncScale ? 1u : 0u) != 0)
			{
				bool flag = PhysicsOverrideCopyToEngine();
				bool flag2 = !flag;
				object obj = !flag2;
				if (obj == null && allowUpdateTransform)
				{
					ArgumentNullException ex = new ArgumentNullException();
					_transform.localPosition = (Vector3)0;
					_transform.localRotation = (Quaternion)0;
				}
				return;
			}
			throw new ArgumentNullException();
		}
		throw new ArgumentNullException();
	}

	private void CopyToBuffer(bool onSpawn)
	{
		//IL_02cc: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_0315: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_032b: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got VT
		//IL_0372: Expected Obj, but got I4
		//IL_0253: Expected VT, but got I4
		bool flag = PhysicsOverrideCopyToBuffer(onSpawn);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63E0]");
		object obj = 0;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			nint num = (nint)obj;
			ArgumentNullException ex = new ArgumentNullException();
			Vector3 localPosition = _transform.localPosition;
			string className = default;
			((Exception)ex)._className = className;
			Quaternion localRotation = _transform.localRotation;
			string message = default;
			((Exception)ex)._message = message;
			IDictionary dictionary = default;
			((Exception)ex)._data = dictionary;
		}
		if (~(SyncScale ? 1u : 0u) == 0)
		{
			nint num = (nint)obj;
			ArgumentNullException ex2 = new ArgumentNullException();
			Vector3 localScale = _transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACEC0");
			_ = 0;
		}
		if (!IsMainTRSP)
		{
			return;
		}
		Transform parent = _transform.parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = parent;
		if (~(_aoiEnabled ? 1u : 0u) == 0 && ~(_autoAOIOverride ? 1u : 0u) == 0)
		{
			if (flag4)
			{
				NetworkTRSP.ResolveAOIOverride(this, parent);
				bool flag5 = (byte)(~(SyncParent ? 1u : 0u)) != 0;
				object obj6 = !flag5;
				if (obj6 == null)
				{
					return;
				}
				goto IL_01cb;
			}
			bool flag6 = ((object)this).Equals((object)null);
			if (~(SyncParent ? 1u : 0u) != 0)
			{
				return;
			}
		}
		else
		{
			if (~(SyncParent ? 1u : 0u) != 0)
			{
				return;
			}
			if (flag4)
			{
				goto IL_01cb;
			}
		}
		throw new ArgumentNullException();
		IL_01cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63F0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj9 = default;
		object obj8 = obj9 & 1;
		NetworkBehaviourId networkBehaviourId;
		if (obj8 != null)
		{
			ArgumentNullException ex3 = new ArgumentNullException();
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v37+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkBehaviour networkBehaviour = default;
			bool flag8 = ((SimulationBehaviour)networkBehaviour)._runner;
			bool flag9 = !flag8;
			networkBehaviourId = (NetworkBehaviourId)0;
			if (!flag9)
			{
				networkBehaviourId = NetworkBehaviour.NetworkWrap(networkBehaviour);
			}
		}
		else
		{
			ArgumentNullException ex4 = new ArgumentNullException();
			networkBehaviourId = NetworkTRSPData.NonNetworkedParent;
		}
		ArgumentNullException ex5 = (ArgumentNullException)networkBehaviourId;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static bool CanInterpolateCheckModeAndDisabled(SimulationModes simulationMode, bool disableSharedModeInterpolation, Topologies topology, bool hasStateAuthority, GameMode gameMode)
	{
		//IL_003e: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00b7: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I4
		bool flag = simulationMode == (SimulationModes)1;
		bool flag2 = !flag;
		bool result = flag2;
		if (!flag)
		{
			object obj = topology - 2;
			bool flag3 = obj == null;
			object obj2 = (hasStateAuthority ? 1 : 0) ^ 1;
			object obj3 = !flag3;
			object obj4 = gameMode - 1;
			bool flag4 = obj4 == null;
			object obj5 = !flag4;
			object obj6 = obj3 | obj2;
			bool flag5 = !disableSharedModeInterpolation;
			bool flag6 = (byte)(obj5 & obj6) != 0;
			object obj7 = !flag5;
			result = ((obj7 != null) ? flag6 : flag2);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static bool CanInterpolateCheckForecastAndBody(bool hasForecastEnabled, bool hasPhysicsBody, bool isKinematic, bool hasStateAuthority)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
		object obj = hasForecastEnabled | hasStateAuthority;
		object obj2 = obj & hasPhysicsBody;
		object obj3 = ~obj2;
		object obj4 = isKinematic | obj3;
		return (byte)(obj4 & 1) != 0;
	}

	private bool CanInterpolate()
	{
		//IL_046e: Expected I4, but got Obj
		//IL_00d8: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		//IL_01eb: Invalid comparison between VT and I4
		//IL_0135: Expected Obj, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected I4, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected I4, but got Unknown
		//IL_0273: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I4
		//IL_04ba: Expected Obj, but got I
		SimulationModes mode;
		Topologies topology;
		object obj3 = default;
		if ((object)((SimulationBehaviour)this)._runner != null)
		{
			mode = ((SimulationBehaviour)this)._runner.Mode;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				topology = ((SimulationBehaviour)this)._runner.Topology;
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						goto IL_046e;
					}
				}
				obj3 = 0;
				goto IL_046e;
			}
		}
		goto IL_0460;
		IL_0460:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_04e4:
		NetworkObject networkObject2 = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj4 = networkObject2.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			}
			else
			{
				networkObject2 = null;
			}
		}
		int num2;
		int num = num2 | networkObject2;
		int num4;
		int num3 = num4 & num;
		int num5 = num3 ^ 1;
		object obj6;
		int num6 = obj6 | num5;
		goto IL_0497;
		IL_0497:
		return (byte)(num6 & 1) != 0;
		IL_04aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63E8]");
		object obj7 = 0;
		throw new ArgumentNullException();
		IL_0305:
		object obj8 = this + 256;
		AbstractPhysicsBody physicsBody;
		int hashCode = ((UnityEngine.Object)(object)physicsBody).GetHashCode();
		int num8;
		int num7 = num8 & 1;
		bool flag3 = num7 == 0;
		num4 = hashCode;
		if (!flag3)
		{
			goto IL_04aa;
		}
		if ((hashCode & 1) != 0)
		{
			object obj9 = obj8;
			if (obj8 == null)
			{
				goto IL_0460;
			}
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v22+298] (should have been resolved before IL gen)");
			object obj11 = default;
			obj6 = obj11;
			num2 = 0;
			num4 = 1;
		}
		else
		{
			obj6 = 1;
			num2 = 0;
			num4 = 0;
		}
		goto IL_04e4;
		IL_046e:
		NetworkRunner runner = ((SimulationBehaviour)this)._runner;
		if ((object)((SimulationBehaviour)this)._runner == null)
		{
			goto IL_0460;
		}
		if (mode != (SimulationModes)1)
		{
			object obj12 = ConfigFlags & (NetworkTransformFlags)1;
			if (obj12 != null)
			{
				object obj13 = topology - 2;
				bool flag4 = obj13 == null;
				object obj14 = flag4 & obj3;
				object obj15 = obj14 & 1;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				num6 = 0;
				if (obj16 == null)
				{
					if (runner.GameMode__BackingField != (GameMode)1)
					{
						goto IL_01e0;
					}
					num6 = 0;
				}
				goto IL_0497;
			}
		}
		if (mode != (SimulationModes)1)
		{
			goto IL_01e0;
		}
		num6 = 0;
		goto IL_0497;
		IL_01e0:
		if (PhysicsSettings != (PhysicsSettings)(object)0)
		{
			NetworkProjectConfig config = runner._config;
			if ((object)runner._config == null)
			{
				goto IL_0460;
			}
			physicsBody = _physicsBody;
			bool flag6 = !config.PhysicsForecast;
			int num9 = ((!flag6) ? 1 : 0);
			bool flag7 = _physicsBody == null;
			object obj17 = !flag7;
			num8 = num9;
			if (obj17 != null)
			{
				goto IL_0305;
			}
			bool flag8 = (byte)(~(config.PhysicsForecast ? 1u : 0u)) != 0;
			num2 = 0;
			if (!flag8)
			{
				num4 = 0;
				goto IL_04aa;
			}
		}
		else
		{
			physicsBody = _physicsBody;
			bool flag9 = _physicsBody == null;
			num8 = 0;
			num2 = 0;
			if (!flag9)
			{
				goto IL_0305;
			}
		}
		obj6 = 1;
		num4 = num2;
		goto IL_04e4;
	}

	private void Fusion_002EIBeforeAllTicks_002EBeforeAllTicks(bool resimulation, int tickCount)
	{
		//IL_0126: Expected VT, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0147: Expected VT, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_01f3: Expected VT, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_044a: Expected VT, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_045f: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_048c: Expected VT, but got I4
		object obj8;
		string text;
		object obj13;
		bool condition;
		if (CanInterpolate())
		{
			if (resimulation)
			{
				CopyToEngine(allowUpdateTransform: true);
				return;
			}
			if (~(_render ? 1u : 0u) == 0 && ~(_simulation ? 1u : 0u) == 0)
			{
				bool isMainTRSP = IsMainTRSP;
				bool flag = !isMainTRSP;
				int num = default;
				NetworkBehaviourId networkBehaviourId = (NetworkBehaviourId)num;
				if (!flag)
				{
					bool flag2 = (byte)(~(SyncParent ? 1u : 0u)) != 0;
					networkBehaviourId = (NetworkBehaviourId)num;
					if (!flag2)
					{
						Transform transform = base.transform;
						Transform parent = transform.parent;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj = 0;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v46+E4]");
						bool flag3 = (nint)0 == 0;
						object obj3 = !flag3;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag4 = parent == _renderParent;
						bool flag5 = !flag4;
						networkBehaviourId = (NetworkBehaviourId)0;
						if (!flag5)
						{
							throw new ArgumentNullException();
						}
					}
				}
				Vector3 localPosition = _transform.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+B8]");
				object obj5 = default;
				object obj4 = obj5 - 0;
				object obj7 = default;
				object obj6 = obj7 - _renderPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+BC]");
				object obj9 = default;
				obj8 = obj9 - 0;
				object obj10 = obj6 * obj6;
				object obj11 = obj4 * obj4;
				object obj12 = obj10 + obj11;
				text = (string)(obj8 * obj8);
				obj13 = text + obj12;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				if ((nint)obj14 < 0)
				{
					Quaternion localRotation = _transform.localRotation;
					object obj15 = obj13 * _renderRotation;
					string text2 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+D0]");
					object obj16 = text2 * 0;
					object obj17 = obj15 + obj16;
					object obj18 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+D4]");
					object obj19 = obj18 * 0;
					object obj20 = obj19 + obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+BC]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+D8]");
					object obj21 = num2 * 0;
					obj13 = obj21 + obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
					text = (string)0;
					object obj22 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
					if ((nint)obj22 > 0)
					{
						if (_physicsBody != null)
						{
							int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
							if ((hashCode & 1) != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACFFC");
								object obj24 = default;
								object obj23 = obj24 & 1;
								if (obj23 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD034");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v57+18]");
									condition = (byte)((nuint)0u & (nuint)1u) != 0;
									goto IL_063e;
								}
							}
						}
						condition = true;
						goto IL_063e;
					}
				}
				goto IL_0491;
			}
			goto IL_0574;
		}
		if (resimulation && _physicsBody != null)
		{
			int hashCode2 = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
			if ((hashCode2 & 1) != 0)
			{
				int hashCode3 = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
				long num3 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToInt64((IFormatProvider)0);
				throw new ArgumentNullException();
			}
		}
		return;
		IL_0491:
		if (~(SyncScale ? 1u : 0u) == 0)
		{
			Vector3 localScale = _transform.localScale;
			string text3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+C4]");
			object obj25 = text3 - 0;
			object obj26 = obj13 - _renderScale;
			object obj27 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+C8]");
			object obj28 = obj27 - 0;
			object obj29 = obj26 * obj26;
			object obj30 = obj25 * obj25;
			object obj31 = obj29 + obj30;
			object obj32 = obj28 * obj28;
			object obj33 = obj32 + obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
			if ((nint)obj33 < 0)
			{
				throw new ArgumentNullException();
			}
		}
		goto IL_0574;
		IL_0574:
		_render = false;
		_simulation = false;
		return;
		IL_063e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6408]");
		object error = 0;
		Assert.Check(condition, (string)error);
		ArgumentNullException ex = new ArgumentNullException();
		_transform.localPosition = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v45 (System.ArgumentNullException)+1C]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v45 (System.ArgumentNullException)+14]");
		obj13 = 0;
		text = ((Exception)ex)._message;
		_transform.localRotation = (Quaternion)0;
		goto IL_0491;
	}

	private void Fusion_002EIAfterAllTicks_002EAfterAllTicks(bool resimulation, int tickCount)
	{
		CopyToBuffer(onSpawn: false);
		_simulation = true;
	}

	private void Fusion_002EIBeforeCopyPreviousState_002EBeforeCopyPreviousState()
	{
		CopyToBuffer(onSpawn: false);
	}

	public void Teleport(Vector3? position = null, Quaternion? rotation = null)
	{
		//IL_002c: Expected Obj, but got I4
		bool flag = PhysicsOverrideTeleport(position, rotation);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			NetworkTRSP.Teleport(this, _transform, position, rotation);
		}
	}

	public override void SetAreaOfInterestOverride(NetworkObject obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		base.SetAreaOfInterestOverride(obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool autoAOIOverride = !obj && _aoiAutoUpdateOriginal;
		_autoAOIOverride = autoAOIOverride;
	}

	protected internal unsafe override void OnEnable()
	{
		//IL_0061: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		base.OnEnable();
		if (Ptr == null)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj4 = default;
			object obj3 = obj4 & 1;
			if (obj3 != null)
			{
				CopyToBuffer(onSpawn: true);
			}
		}
	}

	public override void Spawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_00a4: Expected VT, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
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
		bool flag2 = _transform;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Awake();
		}
		NetworkRunner runner = ((SimulationBehaviour)this)._runner;
		NetworkProjectConfig config = runner._config;
		bool areaOfInterestEnabled = config.Simulation.AreaOfInterestEnabled;
		_initial = (Tick)0;
		_aoiEnabled = areaOfInterestEnabled;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj6 = default;
		object obj5 = obj6 & 1;
		if (obj5 != null)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			NetworkObjectMeta meta = networkObject.Meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v12 (Fusion.NetworkObjectMeta)+50]");
			if ((nint)0 == 0)
			{
				CopyToBuffer(onSpawn: true);
				goto IL_013f;
			}
		}
		CopyToEngine(allowUpdateTransform: true);
		goto IL_013f;
		IL_013f:
		PhysicsSpawned();
	}

	public unsafe override void Render()
	{
		//IL_00e5: Invalid comparison between VT and I4
		//IL_0063: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected I4, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Ref, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		if (!CanInterpolate())
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					goto IL_00da;
				}
			}
		}
		bool flag3 = PhysicsOverrideCopyToEngine();
		goto IL_00da;
		IL_0273:
		bool flag4 = !SyncParent;
		AbstractPhysicsBody abstractPhysicsBody;
		bool checkForecastKinematic = (byte)(abstractPhysicsBody & 1) != 0;
		ref Tick initial = ref *(Tick*)(this + 154);
		bool syncParent = !flag4;
		bool flag5 = !SyncScale;
		bool syncScale = !flag5;
		if (NetworkTRSP.Render(this, _transform, syncScale, syncParent, local: true, checkForecastKinematic, ref initial))
		{
			_render = true;
			Vector3 localPosition = _transform.localPosition;
			Vector3 vector = default;
			_renderPosition = vector;
			Quaternion localRotation = _transform.localRotation;
			_renderRotation = (Quaternion)vector;
			if (~(SyncScale ? 1u : 0u) == 0)
			{
				Vector3 localScale = _transform.localScale;
				_renderScale = vector;
			}
			Transform parent = _transform.parent;
			object obj6 = this + 224;
			obj6 = parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		return;
		IL_00da:
		if (PhysicsSettings != (PhysicsSettings)(object)0)
		{
			NetworkRunner runner = ((SimulationBehaviour)this)._runner;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				NetworkProjectConfig config = runner._config;
				if (~(config.PhysicsForecast ? 1u : 0u) == 0)
				{
					abstractPhysicsBody = _physicsBody;
					if (_physicsBody != null)
					{
						int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
						abstractPhysicsBody = (AbstractPhysicsBody)hashCode;
					}
					goto IL_0273;
				}
			}
		}
		abstractPhysicsBody = null;
		goto IL_0273;
	}

	private void OnDrawGizmos()
	{
		PhysicsDrawGizmos();
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static ForecastDisabledKinematicAction GetForecastDisabledKinematicAction(bool isInSimulation, bool kinematicHasBeenForced, bool hasForecastEnabled, bool setForecastDisabledProxyRigidbodiesToKinematic)
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected I4, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		object obj = !kinematicHasBeenForced;
		object obj2 = setForecastDisabledProxyRigidbodiesToKinematic & obj;
		bool flag = !kinematicHasBeenForced;
		ForecastDisabledKinematicAction result = (ForecastDisabledKinematicAction)(obj2 & 1);
		object obj3 = !flag;
		object obj4 = ~obj3;
		ForecastDisabledKinematicAction forecastDisabledKinematicAction = ((obj4 == null) ? ((ForecastDisabledKinematicAction)2) : ((ForecastDisabledKinematicAction)0));
		bool flag2 = !isInSimulation;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			result = forecastDisabledKinematicAction;
		}
		bool flag3 = !hasForecastEnabled;
		object obj6 = !flag3;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			return (ForecastDisabledKinematicAction)0;
		}
		return result;
	}

	public bool TriggerLocalOverridesExtrapolated(bool force = default(bool))
	{
		//IL_00be: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_00de: Invalid comparison between F4 and I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					goto IL_010b;
				}
			}
		}
		bool flag3 = !force;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			float timeSinceLastImpactfulCollision = _timeSinceLastImpactfulCollision;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+164]");
			if (timeSinceLastImpactfulCollision < 0f)
			{
				goto IL_010b;
			}
		}
		_timeSinceLastImpactfulCollision = 0f;
		return true;
		IL_010b:
		return false;
	}

	public void PhysicsInit()
	{
		//IL_005a: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		if (_physicsBody != null)
		{
			int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
			int num = hashCode & 1;
			bool flag = num == 0;
			object obj = !flag;
			if (obj != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj4 = default;
		object obj3 = obj4 & 1;
		PhysicsBody3D physicsBody;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63D8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			PhysicsBody3D physicsBody3D = default;
			Rigidbody rb = default;
			physicsBody3D._002Ector(rb);
			object obj6 = 0;
			physicsBody = physicsBody3D;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63C8]");
			object obj7 = 0;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj9 = default;
			object obj8 = obj9 & 1;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63D0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				PhysicsBody2D physicsBody2D = default;
				Rigidbody2D rb2 = default;
				physicsBody2D._002Ector(rb2);
				obj6 = 0;
				physicsBody = (PhysicsBody3D)(object)physicsBody2D;
			}
			else
			{
				physicsBody = null;
			}
		}
		object obj11 = this + 256;
		_physicsBody = physicsBody;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void UpdateForecastDisabledKinematicOverride()
	{
		//IL_007f: Invalid comparison between VT and I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I4
		//IL_00b8: Expected VT, but got Obj
		//IL_0298: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I4
		//IL_00f7: Expected VT, but got I4
		//IL_01f8: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_021c: Expected I4, but got I8
		//IL_023b: Expected Obj, but got I4
		//IL_0330: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		if (_physicsBody == null)
		{
			return;
		}
		int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
		if ((hashCode & 1) == 0)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		PhysicsSettings physicsSettings = PhysicsSettings;
		if (PhysicsSettings != (PhysicsSettings)(object)0)
		{
			NetworkRunner runner = ((SimulationBehaviour)this)._runner;
			bool flag = (object)((SimulationBehaviour)this)._runner == null;
			physicsSettings = (PhysicsSettings)((SimulationBehaviour)this)._runner;
			if (!flag)
			{
				NetworkProjectConfig config = runner._config;
				bool flag2 = !config.PhysicsForecast;
				PhysicsSettings physicsSettings2 = (PhysicsSettings)(!flag2);
				physicsSettings = physicsSettings2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+111]");
		bool flag6;
		if ((nint)0 != 0)
		{
			NetworkRunner runner2 = ((SimulationBehaviour)this)._runner;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				NetworkProjectConfig config2 = runner2._config;
				bool flag3 = !config2.DoNotSetForecastDisabledProxyRigidbodiesToKinematic;
				object obj = physicsSettings & 1;
				bool flag4 = obj == null;
				object obj2 = !flag4;
				if (obj2 == null)
				{
					object obj3 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)0x10000;
					bool flag5 = obj3 == null;
					object obj4 = !flag5;
					flag6 = flag3;
					if (obj4 == null)
					{
						goto IL_01cc;
					}
					goto IL_02be;
				}
				return;
			}
		}
		object obj5 = physicsSettings & 1;
		bool flag7 = obj5 == null;
		object obj6 = !flag7;
		if (obj6 == null)
		{
			object obj7 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)0x10000;
			bool flag8 = obj7 == null;
			flag6 = false;
			if (flag8)
			{
				goto IL_01cc;
			}
			goto IL_02be;
		}
		return;
		IL_01cc:
		object obj8 = (flag6 ? 1 : 0) ^ 1;
		if (_forecastDisabledKinematicForced)
		{
			obj8 = 1;
		}
		object obj9 = obj8 & 1;
		bool flag9 = obj9 == null;
		object obj10 = !flag9;
		if (obj10 == null)
		{
			long num = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToInt64((IFormatProvider)0);
			bool kinematicBeforeForecastDisabledForce = (byte)(num & 1) != 0;
			_kinematicBeforeForecastDisabledForce = kinematicBeforeForecastDisabledForce;
			ulong num2 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToUInt64((IFormatProvider)1);
			_forecastDisabledKinematicForced = true;
			goto IL_02e2;
		}
		return;
		IL_02e2:
		Vector3 position = _transform.position;
		int hashCode2 = ((Enum)(object)_physicsBody).GetHashCode();
		AbstractPhysicsBody physicsBody = _physicsBody;
		Quaternion rotation = _transform.rotation;
		nint num3 = (nint)physicsBody;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8 (Il2CppClass<Fusion.AbstractPhysicsBody>)+1E8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8 (Il2CppClass<Fusion.AbstractPhysicsBody>)+1F0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X2_v3 (should have been resolved before IL gen)");
		return;
		IL_02be:
		if (~(_forecastDisabledKinematicForced ? 1u : 0u) == 0)
		{
			UndoForecastDisabledKinematicOverride();
			goto IL_02e2;
		}
	}

	private void UndoForecastDisabledKinematicOverride()
	{
		//IL_0094: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		if (~(_forecastDisabledKinematicForced ? 1u : 0u) != 0)
		{
			return;
		}
		_forecastDisabledKinematicForced = false;
		if (_physicsBody != null)
		{
			int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
			if ((hashCode & 1) != 0)
			{
				AbstractPhysicsBody physicsBody = _physicsBody;
				nint num = (nint)physicsBody;
				bool kinematicBeforeForecastDisabledForce = _kinematicBeforeForecastDisabledForce;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Fusion.AbstractPhysicsBody>)+2B0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Fusion.AbstractPhysicsBody>)+2A8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
		UndoForecastDisabledKinematicOverride();
	}

	private void PhysicsSpawned()
	{
		//IL_0066: Invalid comparison between VT and I4
		//IL_021a: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		if (_physicsBody == null)
		{
			return;
		}
		int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
		if ((hashCode & 1) == 0)
		{
			return;
		}
		if (PhysicsSettings != (PhysicsSettings)(object)0)
		{
			NetworkRunner runner = ((SimulationBehaviour)this)._runner;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				NetworkProjectConfig config = runner._config;
				if (~(config.PhysicsForecast ? 1u : 0u) == 0)
				{
					float fixedDeltaTime = Time.fixedDeltaTime;
					_firstExecution = true;
					double num = 1.0 / (double)fixedDeltaTime;
					_physicsFps = (float)num;
					UndoForecastDisabledKinematicOverride();
					goto IL_0244;
				}
			}
		}
		UpdateForecastDisabledKinematicOverride();
		Vector3 position = _transform.position;
		int hashCode2 = ((Enum)(object)_physicsBody).GetHashCode();
		AbstractPhysicsBody physicsBody = _physicsBody;
		Quaternion rotation = _transform.rotation;
		nint num2 = (nint)physicsBody;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7 (Il2CppClass<Fusion.AbstractPhysicsBody>)+1E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7 (Il2CppClass<Fusion.AbstractPhysicsBody>)+1F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_0244;
		IL_0244:
		throw new ArgumentNullException();
	}

	private unsafe bool PhysicsOverrideCopyToBuffer(bool onSpawn)
	{
		//IL_05a2: Expected I4, but got Obj
		//IL_05ad: Expected I4, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0052: Invalid comparison between VT and I4
		//IL_0598: Expected I4, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I
		//IL_02ec: Expected VT, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_035b: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_0203: Expected I4, but got Obj
		//IL_02a3: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I4
		//IL_03b6: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		bool flag = (byte)(int)_physicsBody != 0;
		Unity.IL2CPP.Metadata.__Il2CppByteEnum _Il2CppByteEnum;
		ArgumentNullException ex;
		if ((int)(~_physicsBody) == 0)
		{
			bool value = ((bool*)(flag ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ X8_v4 (System.Boolean)+338] (should have been resolved before IL gen)");
			object obj2 = default;
			object obj = obj2 & 1;
			if (obj != null && PhysicsSettings != (PhysicsSettings)(object)0)
			{
				NetworkRunner runner = ((SimulationBehaviour)this)._runner;
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					NetworkProjectConfig config = runner._config;
					if ((object)runner._config != null)
					{
						if (~(config.PhysicsForecast ? 1u : 0u) != 0)
						{
							goto IL_031c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6400]");
						object error = 0;
						bool condition = !_forecastDisabledKinematicForced;
						Assert.Check(condition, (string)error);
						ex = new ArgumentNullException();
						if (_physicsBody != null)
						{
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)((Enum)(object)_physicsBody).System_002EIConvertible_002EToUInt32((IFormatProvider)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+112]");
							if ((nint)0 != 0)
							{
								object obj3 = _Il2CppByteEnum ^ ((Exception)ex)._message;
								object obj4 = obj3 & 1;
								bool flag2 = obj4 == null;
								object obj5 = !flag2;
								if (obj5 != null || onSpawn)
								{
									object obj6 = _Il2CppByteEnum & (Unity.IL2CPP.Metadata.__Il2CppByteEnum)1;
									if (obj6 != null)
									{
										if (_physicsBody != null)
										{
											NetworkTransformHelpers.BodyInterpolation previousInterpolation = (NetworkTransformHelpers.BodyInterpolation)((Enum)(object)_physicsBody).ToString((IFormatProvider)0);
											_previousInterpolation = previousInterpolation;
											if (_physicsBody != null)
											{
												object obj7 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToType((Type)null, (IFormatProvider)0);
												goto IL_05e5;
											}
										}
										goto IL_058a;
									}
									bool flag3 = !onSpawn;
									object obj8 = !flag3;
									if (obj8 == null)
									{
										if (_physicsBody == null)
										{
											goto IL_058a;
										}
										object obj9 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToType((Type)_previousInterpolation, (IFormatProvider)0);
									}
								}
							}
							goto IL_05e5;
						}
					}
					goto IL_058a;
				}
			}
			goto IL_031c;
		}
		goto IL_062b;
		IL_05e5:
		if (_physicsBody != null)
		{
			int item = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63F8]");
			object obj10 = 0;
			(Unity.IL2CPP.Metadata.__Il2CppByteEnum, int) tuple = (_Il2CppByteEnum, item);
			((NetworkPhysicsData*)ex)->FlagsAndConstraints = ((NetworkRigidbodyFlags, int))0;
			object obj11 = _Il2CppByteEnum & (Unity.IL2CPP.Metadata.__Il2CppByteEnum)1;
			if (obj11 != null)
			{
				goto IL_031c;
			}
			AbstractPhysicsBody physicsBody = _physicsBody;
			if (_physicsBody != null)
			{
				nint num = (nint)physicsBody;
				((object)_physicsBody).Finalize();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACEC0");
				object obj12 = default;
				ex = (ArgumentNullException)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v22 (Il2CppClass<Fusion.AbstractPhysicsBody>)+180]");
				_ = 0;
				AbstractPhysicsBody physicsBody2 = _physicsBody;
				if (_physicsBody != null)
				{
					nint num2 = (nint)physicsBody2;
					string text = _physicsBody.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACEC0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v23 (Il2CppClass<Fusion.AbstractPhysicsBody>)+1A0]");
					_ = 0;
					ArgumentNullException ex2 = new ArgumentNullException();
					string className = default;
					string message = default;
					IDictionary dictionary = default;
					if (onSpawn)
					{
						if ((object)_transform != null)
						{
							Vector3 position = _transform.position;
							((Exception)ex2)._className = className;
							if ((object)_transform != null)
							{
								Quaternion rotation = _transform.rotation;
								((Exception)ex2)._message = message;
								((Exception)ex2)._data = dictionary;
								if (_physicsBody != null)
								{
									int hashCode = ((Enum)(object)_physicsBody).GetHashCode();
									if (_physicsBody != null)
									{
										int num3 = ((Enum)(object)_physicsBody).CompareTo((object)0);
										flag = true;
										goto IL_062b;
									}
								}
							}
						}
					}
					else if (_physicsBody != null)
					{
						((object)_physicsBody).Finalize();
						((Exception)ex2)._className = className;
						if (_physicsBody != null)
						{
							string text2 = ((Enum)(object)_physicsBody).ToString();
							((Exception)ex2)._message = message;
							((Exception)ex2)._data = dictionary;
							flag = true;
							goto IL_062b;
						}
					}
				}
			}
		}
		goto IL_058a;
		IL_031c:
		flag = false;
		goto IL_062b;
		IL_062b:
		return flag;
		IL_058a:
		NullReferenceException ex3 = new NullReferenceException();
		return (byte)(int)ex3 != 0;
	}

	private unsafe bool PhysicsOverrideCopyToEngine()
	{
		//IL_001b: Expected I4, but got Obj
		//IL_006e: Invalid comparison between VT and I4
		//IL_02de: Expected I4, but got Obj
		//IL_010a: Expected Obj, but got VT
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I
		//IL_0247: Expected I4, but got Obj
		//IL_027e: Expected Obj, but got I
		bool flag = _physicsBody == null;
		bool result = (byte)(int)_physicsBody != 0;
		(NetworkRigidbodyFlags, int) flagsAndConstraints;
		if (!flag)
		{
			int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
			if ((hashCode & 1) != 0 && PhysicsSettings != (PhysicsSettings)(object)0)
			{
				NetworkRunner runner = ((SimulationBehaviour)this)._runner;
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					NetworkProjectConfig config = runner._config;
					if ((object)runner._config != null)
					{
						if (~(config.PhysicsForecast ? 1u : 0u) != 0)
						{
							goto IL_0287;
						}
						ArgumentNullException ex = new ArgumentNullException();
						flagsAndConstraints = ((NetworkPhysicsData*)ex)->FlagsAndConstraints;
						if (_physicsBody != null)
						{
							IFormatProvider provider = (IFormatProvider)(flagsAndConstraints >> 32);
							int num = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToInt32(provider);
							if (_physicsBody != null)
							{
								object obj = flagsAndConstraints & 1;
								long num2 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToInt64((IFormatProvider)0);
								long num3 = num2 & 1;
								if ((long)obj == num3)
								{
									goto IL_0319;
								}
								if (_physicsBody != null)
								{
									IFormatProvider provider2 = (IFormatProvider)(flagsAndConstraints & 1);
									ulong num4 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToUInt64(provider2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+112]");
									if ((nint)0 == 0)
									{
										goto IL_0319;
									}
									object obj2 = flagsAndConstraints & 1;
									if (obj2 != null)
									{
										if (_physicsBody != null)
										{
											NetworkTransformHelpers.BodyInterpolation previousInterpolation = (NetworkTransformHelpers.BodyInterpolation)((Enum)(object)_physicsBody).ToString((IFormatProvider)0);
											_previousInterpolation = previousInterpolation;
											if (_physicsBody != null)
											{
												object obj3 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToType((Type)null, (IFormatProvider)0);
												goto IL_0319;
											}
										}
									}
									else if (_physicsBody != null)
									{
										object obj4 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToType((Type)_previousInterpolation, (IFormatProvider)0);
										goto IL_0319;
									}
								}
							}
						}
					}
					NullReferenceException ex2 = new NullReferenceException();
					return (byte)(int)ex2 != 0;
				}
			}
			goto IL_0287;
		}
		goto IL_02de;
		IL_02de:
		return result;
		IL_0319:
		object obj5 = flagsAndConstraints & 1;
		bool flag2 = obj5 == null;
		result = flag2;
		goto IL_02de;
		IL_0287:
		result = false;
		goto IL_02de;
	}

	private unsafe bool PhysicsOverrideTeleport(Vector3? position = null, Quaternion? rotation = null)
	{
		//IL_02a7: Expected I4, but got Obj
		//IL_02b2: Expected I4, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0052: Invalid comparison between VT and I4
		//IL_029d: Expected I4, but got Obj
		bool flag = (byte)(int)_physicsBody != 0;
		if ((int)(~_physicsBody) == 0)
		{
			bool value = ((bool*)(flag ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ X8_v4 (System.Boolean)+338] (should have been resolved before IL gen)");
			object obj2 = default;
			object obj = obj2 & 1;
			if (obj != null && PhysicsSettings != (PhysicsSettings)(object)0)
			{
				NetworkRunner runner = ((SimulationBehaviour)this)._runner;
				if ((object)((SimulationBehaviour)this)._runner != null)
				{
					NetworkProjectConfig config = runner._config;
					if ((object)runner._config == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (~(config.PhysicsForecast ? 1u : 0u) == 0)
					{
						throw new ArgumentNullException();
					}
				}
			}
			flag = false;
		}
		return flag;
	}

	internal unsafe (bool, bool) DetectError(float physicsDt, ref KinematicSnapshot localSnapshot, ref KinematicSnapshot extrapolatedSnapshot)
	{
		//IL_055e: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0298: Expected VT, but got Ref
		//IL_0298: Expected VT, but got Ref
		//IL_0234: Expected VT, but got I4
		//IL_0170: Expected VT, but got I4
		//IL_02f7: Invalid comparison between F4 and I
		//IL_04e3: Expected VT, but got Obj
		//IL_0335: Expected VT, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0549: Expected VT, but got I4
		//IL_0420: Expected Obj, but got I
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_048a: Invalid comparison between F4 and I
		//IL_04d0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localSnapshot @ X1 (Fusion.KinematicSnapshot&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [extrapolatedSnapshot @ X2 (Fusion.KinematicSnapshot&)+8]");
		object obj4 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localSnapshot @ X1 (Fusion.KinematicSnapshot&)+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [extrapolatedSnapshot @ X2 (Fusion.KinematicSnapshot&)+C]");
		object obj5 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj6 = obj5 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localSnapshot @ X1 (Fusion.KinematicSnapshot&)+14]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [extrapolatedSnapshot @ X2 (Fusion.KinematicSnapshot&)+14]");
		object obj7 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj8 = obj7 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj9 = obj7 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
		bool flag2 = (nint)obj9 > 0;
		object obj10 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
			object obj11 = obj9 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			obj10 = obj11 * 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localSnapshot @ X1 (Fusion.KinematicSnapshot&)+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+11C]");
		if (num4 < 0)
		{
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+120]");
			if ((nint)obj12 < 0)
			{
				_accruedErrorTime = 0f;
				(bool, bool) tuple = (true, false);
				return ((bool, bool))0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+128]");
		if ((nint)0 > (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localSnapshot @ X1 (Fusion.KinematicSnapshot&)+8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+128]");
			if (num5 > 0)
			{
				goto IL_0218;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+12C]");
		if ((nint)0 > (nint)0)
		{
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+12C]");
			if ((nint)obj13 > 0)
			{
				goto IL_0218;
			}
		}
		AbstractPhysicsBody.CustomErrorDetectionDelegate customErrorDetection = CustomErrorDetection;
		float num6;
		if (CustomErrorDetection != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v248.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			num6 = physicsDt;
		}
		else
		{
			ref KinematicSnapshot extrapolatedSnapshot2 = default;
			num6 = NetworkTransformHelpers.DefaultStalledErrorCorrectionDetection(this, physicsDt, _physicsBody, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref localSnapshot), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref extrapolatedSnapshot), ref *(KinematicSnapshot*)null, ref extrapolatedSnapshot2);
		}
		float num7 = num6 * physicsDt;
		float num8 = _accruedErrorTime + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		_accruedErrorTime = num8;
		RecordStallScoreAndProgress(num6, num8);
		float accruedErrorTime = _accruedErrorTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+138]");
		if (accruedErrorTime > 0f)
		{
			_accruedErrorTime = 0f;
			(bool, bool) tuple2 = (false, true);
			return ((bool, bool))0;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			goto IL_04d5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v12 (Fusion.NetworkObject)+5A]");
		object obj14 = (nint)0 & (nint)1;
		ArgumentNullException ex = ((obj14 == null || ~(_hasRemoteData ? 1u : 0u) != 0) ? new ArgumentNullException() : ((ArgumentNullException)(this + 416)));
		object obj15 = ((Exception)ex)._message & 2;
		if (obj15 != null)
		{
			if (_physicsBody == null)
			{
				goto IL_04d5;
			}
			float num9 = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToSingle((IFormatProvider)0);
			object obj16 = num9 & 1;
			if (obj16 == null)
			{
				float num10 = (_accruedRemoteSleepIgnoreTime += physicsDt);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+13C]");
				if (!(num10 < 0f))
				{
					_accruedRemoteSleepIgnoreTime = 0f;
					_sleepNextUpdate = true;
					(bool, bool) tuple3 = (false, true);
					return ((bool, bool))0;
				}
				goto IL_052d;
			}
		}
		_accruedRemoteSleepIgnoreTime = 0f;
		goto IL_052d;
		IL_04d5:
		NullReferenceException ex2 = new NullReferenceException();
		return ((bool, bool))ex2;
		IL_052d:
		(bool, bool) tuple4 = (false, false);
		return ((bool, bool))0;
		IL_0218:
		(bool, bool) tuple5 = (false, true);
		return ((bool, bool))0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe float ComputeTicksToExtrapolate()
	{
		//IL_0613: Expected Obj, but got I
		//IL_004f: Expected VT, but got I4
		//IL_063a: Expected Obj, but got I
		//IL_0070: Expected Obj, but got VT
		//IL_067e: Invalid comparison between F4 and I4
		//IL_068d: Expected F4, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_013c: Expected Obj, but got Ref
		//IL_0161: Expected Obj, but got Ref
		//IL_0177: Expected I, but got Obj
		//IL_0187: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_06ab: Expected Obj, but got I
		//IL_06cc: Expected Obj, but got Ref
		//IL_022a: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I8
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_0326: Expected Obj, but got Ref
		//IL_039f: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_033c: Expected I, but got Obj
		//IL_034c: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_043f: Expected Obj, but got Ref
		//IL_04b0: Expected Obj, but got I8
		//IL_0455: Expected I, but got Obj
		//IL_0465: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_0505: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I
		NetworkRunner runner = ((SimulationBehaviour)this)._runner;
		bool flag = (object)((SimulationBehaviour)this)._runner == null;
		IntPtr intPtr = default;
		object[] array = (object[])(nint)intPtr;
		object obj;
		object[] array2 = default;
		object[] array4 = default;
		object[] array5;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			Simulation simulation = runner._simulation;
			Tick tick = (((object)runner._simulation == null) ? ((Tick)0) : simulation._tick);
			bool flag2 = (object)((SimulationBehaviour)this)._object == null;
			array = (object[])(nint)intPtr;
			if (!flag2)
			{
				Tick lastReceiveTick = ((SimulationBehaviour)this)._object.LastReceiveTick;
				obj = tick - lastReceiveTick;
				if (tick < lastReceiveTick)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v11+A0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+C0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+C0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						bool flag3 = array2 == null;
						object obj8 = default;
						array = (object[])(&obj8);
						if (flag3)
						{
							goto IL_05ba;
						}
						object obj9 = default;
						bool flag4 = obj9 == null;
						object[] array3 = (object[])(&obj8);
						if (!flag4)
						{
							nint num = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
							array3 = (object[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag5 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
							array = (object[])0;
							if (flag5)
							{
								goto IL_05d6;
							}
						}
						bool flag6 = array2.Length == 0;
						array = array3;
						if (flag6)
						{
							goto IL_05c8;
						}
						object obj10 = array2 + 32;
						obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if ((object)runner._simulation == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							bool flag7 = array4 == null;
							object obj12 = default;
							array5 = (object[])(&obj12);
							if (flag7)
							{
								goto IL_0271;
							}
						}
						nint num2 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
						array5 = (object[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
						array = (object[])0;
						if (!flag8)
						{
							goto IL_0271;
						}
						goto IL_05d6;
					}
				}
				goto IL_0648;
			}
		}
		goto IL_05ba;
		IL_05d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_05ba:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05c8;
		IL_0648:
		float localAlpha = ((SimulationBehaviour)this)._runner.LocalAlpha;
		float num3 = localAlpha + (float)obj;
		float deltaTime = ((SimulationBehaviour)this)._runner.DeltaTime;
		bool flag9 = num3 < 0f;
		float result = 0f;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+118]");
			float num4 = 0f / deltaTime;
			bool flag10 = !(num3 > num4);
			result = num3;
			if (!flag10)
			{
				result = num4;
			}
		}
		return result;
		IL_05c8:
		ex = new IndexOutOfRangeException();
		goto IL_05d6;
		IL_0271:
		object obj13 = array2.Length & 0xFFFFFFFEL;
		bool flag11 = obj13 == null;
		array = array5;
		if (!flag11)
		{
			object obj14 = array2 + 40;
			obj14 = array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag12 = (object)((SimulationBehaviour)this)._object == null;
			array = array4;
			if (flag12)
			{
				goto IL_05ba;
			}
			Tick lastReceiveTick2 = ((SimulationBehaviour)this)._object.LastReceiveTick;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj15 = default;
			bool flag13 = obj15 == null;
			Tick tick2 = default;
			object[] array6 = (object[])(&tick2);
			if (!flag13)
			{
				nint num5 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
				array6 = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag14 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
				array = (object[])0;
				if (flag14)
				{
					goto IL_05d6;
				}
			}
			bool flag15 = array2.Length < 2;
			object obj16 = !flag15;
			object obj17 = array2.Length - 2;
			bool flag16 = obj17 == null;
			object obj18 = ~obj16;
			object obj19 = obj18 | flag16;
			array = array6;
			if (obj19 == null)
			{
				object obj20 = array2 + 48;
				obj20 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Tick latestServerTick = ((SimulationBehaviour)this)._runner.LatestServerTick;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj21 = default;
				bool flag17 = obj21 == null;
				Tick tick3 = default;
				object[] array7 = (object[])(&tick3);
				if (!flag17)
				{
					nint num6 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
					array7 = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag18 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
					array = (object[])0;
					if (flag18)
					{
						goto IL_05d6;
					}
				}
				object obj22 = array2.Length & 0xFFFFFFFCL;
				bool flag19 = obj22 == null;
				array = array7;
				if (!flag19)
				{
					object obj23 = array2 + 56;
					obj23 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6438]");
					object format = 0;
					string text = string.Format((string)format, array2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X23_v6+10]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X23_v6+10]");
					bool flag20 = (nint)0 == 0;
					array = array2;
					if (flag20)
					{
						goto IL_05ba;
					}
					object obj25 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v250 @ X9_v2+188] (should have been resolved before IL gen)");
					goto IL_0648;
				}
			}
		}
		goto IL_05c8;
	}

	private unsafe void FixedUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b8e: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I4
		//IL_00ed: Invalid comparison between VT and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_018a: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I
		//IL_0bad: Expected Obj, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02ff: Expected Obj, but got I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_0363: Expected VT, but got Obj
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_0380: Expected Obj, but got VT
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03ba: Expected Obj, but got VT
		//IL_0443: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got Ref
		//IL_0453: Expected Obj, but got Ref
		//IL_0460: Expected Obj, but got VT
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0404: Expected Obj, but got Ref
		//IL_040c: Expected Obj, but got Ref
		//IL_0414: Expected Obj, but got Ref
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got I4
		//IL_0527: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_04b1: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I
		//IL_0682: Invalid comparison between F4 and I4
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected Obj, but got Unknown
		//IL_0afe: Expected Obj, but got VT
		//IL_0700: Invalid comparison between F8 and I4
		//IL_070f: Expected F8, but got I4
		//IL_0718: Expected F8, but got I4
		//IL_05b3: Expected Obj, but got I
		//IL_0796: Invalid comparison between F8 and I4
		//IL_07a5: Expected F8, but got I4
		//IL_06cd: Invalid comparison between F4 and I4
		//IL_08ec: Invalid comparison between F8 and I
		//IL_05f1: Expected Obj, but got I
		//IL_0a31: Invalid comparison between F8 and I
		//IL_0a52: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float fixedDeltaTime = Time.fixedDeltaTime;
		object obj2 = obj;
		float timeSinceLastImpactfulCollision = fixedDeltaTime + _timeSinceLastImpactfulCollision;
		_timeSinceLastImpactfulCollision = timeSinceLastImpactfulCollision;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((SimulationBehaviour)this)._object)
		{
			return;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((SimulationBehaviour)this)._runner || Ptr == null || PhysicsSettings == (PhysicsSettings)(object)0)
		{
			return;
		}
		NetworkRunner runner = ((SimulationBehaviour)this)._runner;
		if ((object)((SimulationBehaviour)this)._runner == null)
		{
			return;
		}
		NetworkProjectConfig config = runner._config;
		if (~(config.PhysicsForecast ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj7 = default;
		object obj6 = obj7 & 1;
		bool flag3 = obj6 == null;
		object obj8 = !flag3;
		if (obj8 != null || _physicsBody == null)
		{
			return;
		}
		int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
		if ((hashCode & 1) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD034");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v19+18]");
		object obj9 = (nint)0 & (nint)1;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			return;
		}
		if (~(_firstExecution ? 1u : 0u) == 0)
		{
			_firstExecution = false;
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v15 (Fusion.NetworkObject)+5A]");
		object obj11 = (nint)0 & (nint)1;
		ArgumentNullException ex;
		if (obj11 != null && ~(_hasRemoteData ? 1u : 0u) == 0)
		{
			ex = (ArgumentNullException)(this + 416);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63E8]");
			object obj12 = 0;
			ex = new ArgumentNullException();
		}
		object obj13 = ((Exception)ex)._message & 1;
		bool flag5 = obj13 == null;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			return;
		}
		CopyToEngine(allowUpdateTransform: false);
		AbstractPhysicsBody physicsBody = _physicsBody;
		object obj15 = this + 508;
		physicsBody.WasColliding = _isColliding;
		_isColliding = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+204]");
		_ = 0;
		_previousExtrapolatedPosition = (Vector3)obj15;
		CopyToRemoteSnapshot(out var remoteSnapshot);
		object obj16 = this + 460;
		obj16 = remoteSnapshot;
		object obj17 = this + 472;
		object obj18 = default;
		obj17 = obj18;
		CopyToLocalSnapshot(out var localSnapshot);
		object obj19 = this + 532;
		obj19 = localSnapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD0F8");
		CustomForecastDelegate customForecast = CustomForecast;
		KinematicSnapshot extrapolatedSnapshot = default;
		if (CustomForecast != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v665.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj20 = (object)(&extrapolatedSnapshot);
			object obj21 = (object)(&remoteSnapshot);
			object obj22 = (object)(&localSnapshot);
		}
		else
		{
			NetworkTransformHelpers.ComputeExtrapolatedSnapshot(this, fixedDeltaTime, _physicsBody, 0f, ref localSnapshot, ref remoteSnapshot, out extrapolatedSnapshot);
			object obj20 = 0;
			object obj21 = (object)(&extrapolatedSnapshot);
			object obj22 = (object)(&remoteSnapshot);
		}
		obj15 = extrapolatedSnapshot;
		object obj23 = this + 488;
		obj23 = obj18;
		if (~(_sleepNextUpdate ? 1u : 0u) == 0)
		{
			_sleepNextUpdate = false;
			double num = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToDouble((IFormatProvider)1);
			return;
		}
		(bool, bool) tuple = DetectError(fixedDeltaTime, ref localSnapshot, ref extrapolatedSnapshot);
		object obj24 = tuple & 1;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD3CC");
			int previousTeleportKey = _previousTeleportKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v43+30]");
			object obj26 = (nint)previousTeleportKey - (nint)0;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = obj27 | tuple;
			object obj29 = obj28 & 1;
			if (obj29 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD3CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD080");
				int hashCode2 = ((Enum)(object)_physicsBody).GetHashCode();
				int num2 = ((Enum)(object)_physicsBody).CompareTo((object)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
				int hashCode3 = _physicsBody.GetHashCode();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
				bool flag8 = ((Enum)(object)_physicsBody).Equals((object)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v43+30]");
				_previousTeleportKey = 0;
			}
			else
			{
				ApplyCorrectionDelegate customApplyCorrection = CustomApplyCorrection;
				Vector3 vector = (Vector3)(extrapolatedSnapshot - localSnapshot);
				object obj31 = default;
				object obj32 = default;
				object obj30 = obj31 - obj32;
				PositionError__BackingField = vector;
				if (CustomApplyCorrection != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v529.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				else
				{
					NetworkTransformHelpers.ApplyCorrection(this, fixedDeltaTime, _physicsFps, _physicsBody, _timeSinceLastImpactfulCollision, ref localSnapshot, ref remoteSnapshot, ref extrapolatedSnapshot);
				}
				object obj33 = this + 572;
				obj33 = PositionError__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+238]");
				_ = 0;
				((object)_physicsBody).Finalize();
				_physicsBodyLinearVelocity = PositionError__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+238]");
				_ = 0;
				_ = _timeSinceLastImpactfulCollision;
			}
			_previousPosition = (Vector3)localSnapshot;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+124]");
		if ((nint)0 != 1)
		{
			return;
		}
		float num3 = _timeSinceLastImpactfulCollision;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+160]");
		float num4 = num3 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+164]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+160]");
		object obj34 = num5 - 0;
		float num6 = num4 / (float)obj34;
		if (num6 < 0f)
		{
			return;
		}
		bool flag9 = (double)num6 > 1.0;
		double num7 = 1.0;
		if (!flag9)
		{
			bool flag10 = !(num6 > 0f);
			num7 = num6;
			if (flag10)
			{
				return;
			}
		}
		((object)_physicsBody).Finalize();
		bool flag11 = num7 < 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		if (!flag11)
		{
			bool flag12 = !(num7 > 1.0);
			num8 = 1.0;
			num9 = num7;
			if (!flag12)
			{
				num8 = 1.0;
				num9 = 1.0;
			}
		}
		string text = _physicsBody.ToString();
		bool flag13 = num7 < 0.0;
		double num10 = 0.0;
		if (!flag13)
		{
			bool flag14 = !(num7 > 1.0);
			num10 = num7;
			if (!flag14)
			{
				num10 = 1.0;
			}
		}
		object obj36 = default;
		object obj37 = default;
		object obj35 = obj36 - obj37;
		float num11 = 0f - (float)obj36;
		double num12 = (double)obj35 * num9;
		object obj38 = default;
		double num13 = (double)obj38 * num9;
		double num14 = (double)num11 * num9;
		double num15 = (double)obj37 + num12;
		double num16 = (double)obj36 + num14;
		((object)_physicsBody).Finalize();
		double num17 = num14 - num16;
		double num18 = num13 - num13;
		double num19 = num12 - num15;
		double num20 = num18 * num18;
		double num21 = num17 * num17;
		double num22 = num20 + num21;
		double num23 = num19 * num19;
		double num24 = num23 + num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (!(num24 < 0.0))
		{
			int hashCode4 = _physicsBody.GetHashCode();
		}
		double num25 = (double)obj37 - num8;
		object obj40 = default;
		object obj39 = obj40 - obj36;
		double num26 = 0.0 - (double)obj37;
		double num27 = num25 * num10;
		double num28 = (double)obj39 * num10;
		double num29 = num26 * num10;
		double num30 = num8 + num27;
		double num31 = (double)obj36 + num28;
		double num32 = (double)obj37 + num29;
		string text2 = _physicsBody.ToString();
		double num33 = num28 - num31;
		double num34 = num27 - num30;
		double num35 = num29 - num32;
		double num36 = num34 * num34;
		double num37 = num33 * num33;
		double num38 = num36 + num37;
		double num39 = num35 * num35;
		double num40 = num39 + num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (!(num40 < 0.0))
		{
			bool flag15 = ((Enum)(object)_physicsBody).Equals((object)0);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01ee: Expected VT, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_00ec: Expected VT, but got I4
		//IL_02a2: Expected VT, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_026a: Expected VT, but got I4
		//IL_0273: Expected Obj, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		int contactCount = other.contactCount;
		Vector3 collisionNormal;
		if (contactCount == 1)
		{
			ContactPoint contact = other.GetContact(0);
			collisionNormal = (Vector3)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v7+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8+8]");
			object obj10 = 0;
			int contactCount2 = other.contactCount;
			bool flag3 = contactCount2 < 1;
			IntPtr intPtr = default;
			collisionNormal = (Vector3)(nint)intPtr;
			object obj11 = 0;
			if (!flag3)
			{
				int num = 0;
				object obj12 = default;
				object obj13 = default;
				bool flag4;
				do
				{
					ContactPoint contact2 = other.GetContact(num);
					num++;
					obj9 = obj8 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8+8]");
					obj10 = 0 + obj13;
					int contactCount3 = other.contactCount;
					flag4 = num < contactCount3;
					collisionNormal = (Vector3)0;
					obj11 = 0;
				}
				while (flag4);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj9 * obj9;
			object obj18 = obj10 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			object obj19 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj19 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
		}
		Vector3 relativeVelocity = other.relativeVelocity;
		CheckIfImpactfulAndSwitchToLocalPhysics((Vector3)0, collisionNormal);
	}

	private void OnCollisionStay(Collision other)
	{
		_isColliding = true;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_0164: Expected VT, but got Obj
		//IL_0180: Expected VT, but got I
		//IL_0188: Expected VT, but got Obj
		//IL_00e4: Expected VT, but got I4
		//IL_00ed: Expected VT, but got I4
		//IL_011b: Expected VT, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected VT, but got Unknown
		//IL_01de: Expected VT, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		Vector3 collisionNormal;
		Vector3 relativeVelocity;
		if (other.m_ContactCount == 1)
		{
			ContactPoint2D contact = other.GetContact(0);
			collisionNormal = (Vector3)0;
			relativeVelocity = (Vector3)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X9_v7+A0]");
			object obj8 = 0;
			Vector2 vector = (Vector2)obj8;
			bool flag3 = other.m_ContactCount < 1;
			IntPtr intPtr = default;
			collisionNormal = (Vector3)(nint)intPtr;
			Vector2 value = (Vector2)obj8;
			if (!flag3)
			{
				int num = 0;
				object obj9 = default;
				bool flag4;
				do
				{
					ContactPoint2D contact2 = other.GetContact(num);
					num++;
					vector += obj9;
					flag4 = num < other.m_ContactCount;
					collisionNormal = (Vector3)0;
					value = vector;
				}
				while (flag4);
			}
			Vector2 vector2 = Vector2.Normalize(ref value);
			relativeVelocity = (Vector3)0;
		}
		CheckIfImpactfulAndSwitchToLocalPhysics(relativeVelocity, collisionNormal);
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		_isColliding = true;
	}

	private void CheckIfImpactfulAndSwitchToLocalPhysics(Vector3 relativeVelocity, Vector3 collisionNormal)
	{
		//IL_0244: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_002e: Invalid comparison between F4 and I
		//IL_0087: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00a7: Expected F4, but got Obj
		//IL_00b7: Expected F4, but got I
		//IL_00c7: Expected F4, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I4
		//IL_011c: Invalid comparison between F4 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num = default;
		float num2;
		float num3;
		float num4;
		if (num > 0f)
		{
			object obj4 = default;
			num2 = (float)obj4 / num;
			object obj5 = default;
			num3 = (float)obj5 / num;
			object obj6 = default;
			num4 = (float)obj6 / num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v17+A0]");
			object obj9 = 0;
			num2 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v18+4]");
			num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v18+8]");
			num4 = 0f;
		}
		object obj10 = default;
		float num5 = (float)obj10 * num2;
		object obj11 = default;
		float num6 = (float)obj11 * num3;
		object obj12 = obj;
		object obj13 = default;
		float num7 = (float)obj13 * num4;
		float num8 = num5 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num9 = num7 + num8;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RecordCollisionEnter(num, num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+15C]");
		if (!(num9 < 0f))
		{
			_timeSinceLastImpactfulCollision = 0f;
		}
	}

	private unsafe void CopyToRemoteSnapshot(out KinematicSnapshot remoteSnapshot)
	{
		//IL_0025: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v3 (Fusion.NetworkObject)+5A]");
		object obj = (nint)0 & (nint)1;
		ArgumentNullException ex;
		if (obj != null && ~(_hasRemoteData ? 1u : 0u) == 0)
		{
			ex = (ArgumentNullException)(this + 360);
		}
		else
		{
			ArgumentNullException ex2 = new ArgumentNullException();
			networkObject = ((SimulationBehaviour)this)._object;
			ex = ex2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v3 (Fusion.NetworkObject)+5A]");
		object obj2 = (nint)0 & (nint)1;
		ArgumentNullException ex3;
		if (obj2 != null && ~(_hasRemoteData ? 1u : 0u) == 0)
		{
			ex3 = (ArgumentNullException)(this + 416);
		}
		else
		{
			ArgumentNullException ex4 = new ArgumentNullException();
			ex3 = ex4;
		}
		_ = ((Exception)ex)._className;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v2 (System.ArgumentNullException)+8]");
		ref KinematicSnapshot reference = ref *(KinematicSnapshot*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v2 (System.ArgumentNullException)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v2 (System.ArgumentNullException)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X21_v2 (System.ArgumentNullException)+14]");
		_ = 0;
		object obj3 = (object)((Exception)ex3)._message >> 1;
		object obj4 = obj3 & 1;
	}

	private unsafe void CopyToLocalSnapshot(out KinematicSnapshot localSnapshot)
	{
		//IL_0099: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		((object)_physicsBody).Finalize();
		object obj = default;
		ref KinematicSnapshot reference = ref *(KinematicSnapshot*)obj;
		string text = ((Enum)(object)_physicsBody).ToString();
		((object)_physicsBody).Finalize();
		string text2 = _physicsBody.ToString();
		float num = ((Enum)(object)_physicsBody).System_002EIConvertible_002EToSingle((IFormatProvider)0);
		object obj2 = num & 1;
	}

	private void Fusion_002EIAfterClientPredictionReset_002EAfterClientPredictionReset()
	{
		//IL_0025: Expected VT, but got Obj
		//IL_003b: Expected I, but got Obj
		//IL_005a: Expected VT, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00ea: Expected I, but got Obj
		AbstractPhysicsBody physicsBody = _physicsBody;
		bool flag = _physicsBody == null;
		NetworkPhysicsData networkPhysicsData = (NetworkPhysicsData)_physicsBody;
		if (!flag)
		{
			nint num = (nint)physicsBody;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v4 (Il2CppClass<Fusion.AbstractPhysicsBody>)+340]");
			nint num2 = 0;
			networkPhysicsData = (NetworkPhysicsData)((UnityEngine.Object)(object)_physicsBody).GetHashCode();
			object obj = networkPhysicsData & 1;
			if (obj != null)
			{
				NetworkTRSPData networkTRSPData = Data;
				object obj2 = this + 360;
				object obj3 = default;
				obj2 = obj3;
				networkPhysicsData = PhysicsData;
				object obj4 = this + 416;
				NetworkPhysicsData remotePhysicsData = default;
				_remotePhysicsData = remotePhysicsData;
				_hasRemoteData = true;
				num2 = unchecked((nint)null);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		if (num3 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	private void Fusion_002EISimulationEnter_002ESimulationEnter()
	{
		UpdateForecastDisabledKinematicOverride();
	}

	private void Fusion_002EISimulationExit_002ESimulationExit()
	{
		UpdateForecastDisabledKinematicOverride();
	}

	private void PhysicsDrawGizmos()
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00ec: Invalid comparison between VT and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkTransform)+113]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!((SimulationBehaviour)this)._object || _physicsBody == null)
		{
			return;
		}
		int hashCode = ((UnityEngine.Object)(object)_physicsBody).GetHashCode();
		if ((hashCode & 1) == 0 || PhysicsSettings == (PhysicsSettings)(object)0)
		{
			return;
		}
		NetworkRunner runner = ((SimulationBehaviour)this)._runner;
		if ((object)((SimulationBehaviour)this)._runner == null)
		{
			return;
		}
		NetworkProjectConfig config = runner._config;
		if (~(config.PhysicsForecast ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj5 = default;
			object obj4 = obj5 & 1;
			bool flag2 = obj4 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				throw new ArgumentNullException();
			}
		}
	}

	public bool IsTraceEnabled()
	{
		bool flag = CurrentTrace == null;
		return !flag;
	}

	public void SetTraceEnabled(bool enabled)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		NetworkTransformTrace networkTransformTrace2;
		if (enabled)
		{
			bool flag = CurrentTrace == null;
			object obj = !flag;
			if (obj != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6448]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NetworkTransformTrace networkTransformTrace = default;
			networkTransformTrace._002Ector();
			networkTransformTrace2 = networkTransformTrace;
		}
		else
		{
			if (CurrentTrace == null)
			{
				return;
			}
			networkTransformTrace2 = null;
		}
		object obj3 = this + 600;
		obj3 = networkTransformTrace2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe void RecordForecastData(Vector3 previousVelocity, Vector3 newVelocity, Vector3 desiredVelocity, float lerpAlpha)
	{
		//IL_0018: Expected VT, but got Ref
		NetworkTransformTrace currentTrace = CurrentTrace;
		if (CurrentTrace != null)
		{
			float num = default;
			currentTrace.ForecastBuffer.Write((NetworkTransformTrace.ForecastData)(&num));
		}
	}

	internal void RecordStallHeuristicData(float errorSimilarity, float correctionProgress)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected VT, but got Obj
		NetworkTransformTrace currentTrace = CurrentTrace;
		if (CurrentTrace != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6458]");
			object obj = 0;
			currentTrace.StallHeuristicBuffer.Write((NetworkTransformTrace.StallHeuristicData)obj);
		}
	}

	internal void RecordStallScoreAndProgress(float stallScore, float stallProgress)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected VT, but got Obj
		NetworkTransformTrace currentTrace = CurrentTrace;
		if (CurrentTrace != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6428]");
			object obj = 0;
			currentTrace.StallBuffer.Write((NetworkTransformTrace.StallData)obj);
		}
	}

	internal void RecordCollisionEnter(float relativeVelocity, float impactAlignment)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected VT, but got Obj
		NetworkTransformTrace currentTrace = CurrentTrace;
		if (CurrentTrace != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6440]");
			object obj = 0;
			currentTrace.CollisionEnterBuffer.Write((NestedComponentUtilities.CollisionEnterData)obj);
		}
	}

	public NetworkTransform()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		object obj = this + 472;
		_autoAOIOverride = true;
		ConfigFlags = (NetworkTransformFlags)0;
		PhysicsSettings physicsSettings = new PhysicsSettings();
		object obj2 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj3 = this + 600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A0]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A0]");
		object obj5 = 0;
		_hasRemoteData = false;
		_isColliding = false;
		_firstExecution = true;
		CurrentTrace = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
