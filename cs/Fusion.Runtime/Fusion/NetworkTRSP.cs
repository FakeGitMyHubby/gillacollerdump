using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public abstract class NetworkTRSP : NetworkBehaviour
{
	private PlayerRef _previousRenderStateAuth;

	private Vector3? _stateAuthorityChangePositionError;

	private Quaternion? _stateAuthorityChangeRotationError;

	private float _stateAuthorityChangeErrorCorrectionDelta = 0f;

	protected Tick reenabledTick;

	public bool IsMainTRSP
	{
		get
		{
			if (ObjectIndex == 0)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v2 (Fusion.NetworkObject)+55]");
					return (byte)((nuint)0u & (nuint)1u) != 0;
				}
			}
			return false;
		}
	}

	public unsafe NetworkTRSPData Data
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0028: Expected VT, but got I4
			//IL_0023: Expected native int or pointer, but got VT
			//IL_0055: Expected native int or pointer, but got VT
			//IL_0074: Expected VT, but got I4
			//IL_006f: Expected native int or pointer, but got VT
			//IL_0079: Expected VT, but got Obj
			//IL_009e: Expected VT, but got Obj
			//IL_0099: Expected native int or pointer, but got VT
			//IL_00ba: Expected I4, but got Obj
			//IL_00b5: Expected native int or pointer, but got VT
			//IL_00c2: Expected VT, but got Obj
			NetworkTRSPData networkTRSPData = default;
			((NetworkTRSPData*)(nint)networkTRSPData)->TeleportKey = 0;
			_ = 0;
			_ = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkTRSPData*)(nint)networkTRSPData)->Parent, (NetworkBehaviourId)0);
			if (Ptr == null)
			{
				((NetworkTRSPData*)(nint)networkTRSPData)->TeleportKey = 0;
				_ = 0;
				_ = 0;
				System.Runtime.CompilerServices.Unsafe.Write(&((NetworkTRSPData*)(nint)networkTRSPData)->Parent, (NetworkBehaviourId)0);
				return (NetworkTRSPData)this;
			}
			ArgumentNullException ex = new ArgumentNullException();
			_ = ((Exception)ex)._data;
			System.Runtime.CompilerServices.Unsafe.Write(&((NetworkTRSPData*)(nint)networkTRSPData)->Parent, (NetworkBehaviourId)ex);
			_ = ((Exception)ex)._className;
			((NetworkTRSPData*)(nint)networkTRSPData)->TeleportKey = (int)((Exception)ex)._helpURL;
			return (NetworkTRSPData)ex;
		}
	}

	protected unsafe ref NetworkTRSPData State
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			ArgumentNullException ex = new ArgumentNullException();
			return ref *(NetworkTRSPData*)ex;
		}
	}

	public virtual void SetAreaOfInterestOverride(NetworkObject obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)obj)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67E0]");
			object error = 0;
			object obj5 = (int)obj.Flags >> 8;
			bool condition = (byte)(obj5 & 1) != 0;
			Assert.Always(condition, (string)error);
		}
		ArgumentNullException ex = new ArgumentNullException();
		NetworkId networkId = obj;
	}

	protected unsafe static void Teleport(NetworkTRSP behaviour, Transform transform, Vector3? position = null, Quaternion? rotation = null)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_002b: Expected VT, but got I4
		//IL_007a: Expected VT, but got I4
		ArgumentNullException ex = new ArgumentNullException();
		object obj = (_003F?)position & 0xFF;
		if (obj != null)
		{
			Vector3? vector = default;
			Vector3 value = vector.Value;
			transform.position = (Vector3)0;
			Vector3 localPosition = transform.localPosition;
			string className = default;
			((Exception)ex)._className = className;
		}
		IntPtr intPtr = default;
		if (intPtr != (IntPtr)0)
		{
			Quaternion value2 = ((Quaternion?*)intPtr)->Value;
			transform.rotation = (Quaternion)0;
			Quaternion localRotation = transform.localRotation;
			string message = default;
			((Exception)ex)._message = message;
			IDictionary dictionary = default;
			((Exception)ex)._data = dictionary;
		}
		string helpURL = ((Exception)ex)._helpURL + 1;
		((Exception)ex)._helpURL = helpURL;
	}

	protected static void SetParentTransform(NetworkTRSP behaviour, Transform transform, NetworkBehaviourId parentId)
	{
		//IL_00ab: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		NetworkBehaviourId behaviourId = default;
		Transform parent2;
		if (behaviourId.IsValid)
		{
			if (!((SimulationBehaviour)behaviour)._runner.TryFindBehaviour(behaviourId, out var behaviour2))
			{
				return;
			}
			Transform parent = transform.parent;
			Transform transform2 = behaviour2.transform;
			if ((object)parent == transform2)
			{
				return;
			}
			Transform transform3 = behaviour2.transform;
			parent2 = transform3;
		}
		else
		{
			object obj = default;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 != null)
			{
				return;
			}
			Transform parent3 = transform.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = parent3;
			bool flag4 = !flag3;
			parent2 = null;
			if (flag4)
			{
				return;
			}
		}
		transform.parent = parent2;
	}

	protected static void ResolveAOIOverride(NetworkTRSP behaviour, Transform parent)
	{
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_004f: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I
		//IL_0228: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67E8]");
		object obj2 = 0;
		Transform transform2 = default;
		Transform transform = transform2;
		object obj7 = default;
		NetworkObject networkObject = default;
		while (true)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = transform;
			bool flag3 = !flag2;
			object obj5 = 0;
			if (flag3)
			{
				break;
			}
			nint num = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj6 = obj7 & 1;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ stack_-28_v5 (Fusion.NetworkObject)+55]");
				object obj8 = (nint)0 & (nint)1;
				bool flag4 = obj8 == null;
				object obj9 = !flag4;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67F0]");
					object error = 0;
					object obj10 = (object)networkObject - (object)((SimulationBehaviour)behaviour)._object;
					bool flag5 = obj10 == null;
					bool condition = !flag5;
					Assert.Always(condition, (string)error);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63E0]");
					object obj11 = 0;
					num = (nint)obj11;
					ArgumentNullException ex = new ArgumentNullException();
					NetworkId networkId = networkObject;
					obj5 = 0;
					break;
				}
			}
			Transform parent2 = transform.parent;
			transform = parent2;
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = transform;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			return;
		}
		throw new ArgumentNullException();
	}

	protected internal virtual void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_013c: Expected I4, but got I8
		//IL_0076: Expected Obj, but got I
		//IL_00d0: Expected VT, but got Obj
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
		if ((UnityEngine.Object)((SimulationBehaviour)this)._object != (UnityEngine.Object)null)
		{
			NetworkObject networkObject = ((SimulationBehaviour)this)._object;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v7 (Fusion.NetworkObject)+5A]");
			object obj4 = (nint)0 & (nint)0x80;
			if (obj4 != null)
			{
				NetworkRunner runner = ((SimulationBehaviour)this)._runner;
				Simulation simulation = runner._simulation;
				bool flag2 = (object)runner._simulation == null;
				Tick tick = (Tick)runner._simulation;
				if (!flag2)
				{
					tick = simulation._tick;
				}
				reenabledTick = tick;
			}
		}
		SimulationBehaviourRuntimeFlags flags = (SimulationBehaviourRuntimeFlags)((long)Flags & 0xFFFFFFEFL);
		Flags = flags;
	}

	protected static void Render(NetworkTRSP behaviour, Transform transform, bool syncScale, bool syncParent, bool local, ref Tick initial)
	{
		bool flag = Render(behaviour, transform, syncScale, syncParent, local, checkForecastKinematic: false, ref initial);
	}

	internal unsafe static bool Render(NetworkTRSP behaviour, Transform transform, bool syncScale, bool syncParent, bool local, bool checkForecastKinematic, ref Tick initial)
	{
		//IL_139d: Expected VT, but got I4
		//IL_13a5: Expected I4, but got Obj
		//IL_13ad: Expected VT, but got Obj
		//IL_134b: Expected Obj, but got VT
		//IL_003d: Expected VT, but got Ref
		//IL_004d: Expected VT, but got I4
		//IL_007b: Expected Obj, but got I
		//IL_0095: Expected VT, but got Obj
		//IL_12d8: Expected VT, but got I
		//IL_1479: Expected Obj, but got I4
		//IL_0179: Invalid comparison between VT and I4
		//IL_13cc: Expected F4, but got I4
		//IL_019a: Invalid comparison between VT and Obj
		//IL_01bb: Invalid comparison between VT and Obj
		//IL_01f1: Expected Obj, but got I
		//IL_020b: Expected VT, but got Obj
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_05c3: Invalid comparison between F4 and I4
		//IL_05d2: Expected F8, but got I4
		//IL_1303: Expected VT, but got Obj
		//IL_1672: Expected Obj, but got I
		//IL_167a: Expected VT, but got Obj
		//IL_169c: Expected Obj, but got I4
		//IL_14d2: Expected Obj, but got I
		//IL_14fc: Expected Obj, but got I4
		//IL_14ad: Expected F4, but got I4
		//IL_034c: Expected F4, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_02d3: Expected VT, but got Obj
		//IL_066f: Invalid comparison between I and VT
		//IL_069d: Expected VT, but got F4
		//IL_06a5: Expected VT, but got Ref
		//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b8: Expected VT, but got Unknown
		//IL_16c1: Invalid comparison between VT and I4
		//IL_0540: Invalid comparison between F4 and I4
		//IL_054f: Expected F8, but got I4
		//IL_0461: Expected VT, but got I4
		//IL_0469: Expected I4, but got VT
		//IL_0471: Expected VT, but got I4
		//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f3: Expected VT, but got Unknown
		//IL_16fc: Invalid comparison between VT and I4
		//IL_172b: Expected VT, but got I4
		//IL_1733: Expected I4, but got VT
		//IL_15d7: Expected VT, but got I4
		//IL_0a26: Invalid comparison between F4 and I4
		//IL_078c: Expected VT, but got I4
		//IL_0ca6: Invalid comparison between F4 and I4
		//IL_0cd8: Expected VT, but got I4
		//IL_0ce0: Expected I4, but got VT
		//IL_0711: Expected VT, but got I4
		//IL_04ce: Expected Obj, but got I4
		//IL_0a5d: Expected Obj, but got I
		//IL_0a66: Expected Ref, but got VT
		//IL_1598: Expected VT, but got I4
		//IL_157d: Expected F4, but got I4
		//IL_03f3: Expected F4, but got I4
		//IL_11f0: Expected VT, but got I4
		//IL_1239: Expected VT, but got Obj
		//IL_0d06: Expected Obj, but got I
		//IL_0d0f: Expected Ref, but got VT
		//IL_1759: Expected Obj, but got I
		//IL_1771: Expected Obj, but got I
		//IL_1779: Expected F4, but got Obj
		//IL_1789: Expected F4, but got I
		//IL_1799: Expected F4, but got I
		//IL_0804: Expected Obj, but got I
		//IL_0988: Expected VT, but got Obj
		//IL_1157: Expected VT, but got I4
		//IL_1165: Expected VT, but got I4
		//IL_18b5: Expected Obj, but got I
		//IL_191d: Expected Obj, but got I
		//IL_1925: Expected VT, but got Obj
		//IL_1935: Expected F4, but got I
		//IL_1945: Expected F4, but got I
		//IL_19fe: Invalid comparison between F4 and I
		//IL_1a0d: Expected VT, but got I4
		//IL_1c40: Invalid comparison between F4 and I4
		//IL_099d: Expected Obj, but got I
		//IL_09ab: Expected VT, but got I4
		//IL_09b3: Expected VT, but got Obj
		//IL_09c0: Expected VT, but got Obj
		//IL_09ce: Expected VT, but got I4
		//IL_09f5: Expected F4, but got I4
		//IL_09fe: Expected VT, but got I4
		//IL_0a06: Expected VT, but got Ref
		//IL_119b: Expected VT, but got Obj
		//IL_1aa3: Expected Obj, but got I
		//IL_1ab0: Expected VT, but got Obj
		//IL_1ab9: Expected VT, but got I4
		//IL_17ae: Expected Obj, but got I
		//IL_17b6: Expected VT, but got Obj
		//IL_17c3: Expected VT, but got Obj
		//IL_17cc: Expected VT, but got I4
		//IL_17d4: Expected VT, but got Ref
		//IL_1b36: Expected Obj, but got I
		//IL_1b6b: Expected F4, but got Obj
		//IL_1b78: Expected F4, but got Obj
		//IL_1b9c: Expected VT, but got I4
		//IL_0de3: Invalid comparison between F4 and I4
		//IL_0e02: Expected VT, but got I4
		//IL_1800: Expected Obj, but got I
		//IL_1808: Expected F4, but got Obj
		//IL_182e: Invalid comparison between F4 and Obj
		//IL_0a7d: Invalid comparison between F4 and I4
		//IL_10e6: Expected F4, but got VT
		//IL_0b15: Expected Obj, but got I
		//IL_0b3f: Expected Obj, but got I4
		//IL_0eee: Expected F4, but got I
		//IL_0f03: Expected F4, but got I
		//IL_0f03: Expected Ref, but got F4
		//IL_0f26: Expected F4, but got I
		//IL_0f37: Expected VT, but got I4
		//IL_0e41: Invalid comparison between F4 and I4
		//IL_0e50: Invalid comparison between F4 and I4
		//IL_0e68: Expected Obj, but got F8
		//IL_0e75: Expected Obj, but got F4
		//IL_0eaa: Expected Obj, but got I4
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Expected Obj, but got Unknown
		//IL_0c19: Expected F4, but got I
		//IL_0c29: Invalid comparison between F4 and I
		//IL_0ac3: Expected Obj, but got I4
		//IL_0adb: Invalid comparison between F4 and I4
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_1ae9: Expected VT, but got F4
		//IL_1b0a: Expected VT, but got I4
		//IL_0f6a: Expected F4, but got I
		//IL_0f6a: Expected Ref, but got F4
		//IL_0f8d: Expected F4, but got I
		//IL_0f9e: Expected VT, but got I4
		//IL_0c50: Expected F4, but got I
		//IL_0c60: Invalid comparison between F4 and I
		//IL_0fd1: Expected F4, but got I
		//IL_0fd1: Expected Ref, but got F4
		//IL_0ffc: Expected F4, but got VT
		//IL_1034: Expected F4, but got I
		//IL_1045: Expected VT, but got I4
		//IL_0c80: Expected VT, but got I4
		//IL_105c: Expected VT, but got I4
		//IL_1080: Expected F4, but got VT
		//IL_10b8: Expected F4, but got I
		//IL_10c9: Expected VT, but got I4
		NetworkTRSP networkTRSP = default;
		bool flag = (object)networkTRSP == null;
		bool flag2 = local;
		bool flag3 = syncParent;
		Quaternion quaternion = (Quaternion)syncScale;
		int num = (int)transform;
		NetworkTRSPData networkTRSPData = (NetworkTRSPData)networkTRSP;
		object obj2 = default;
		object obj = obj2;
		NetworkBehaviourBuffer from;
		NetworkBehaviourBuffer to;
		float alpha;
		NetworkTRSP networkTRSP2;
		float num3 = default;
		float num2;
		if (!flag)
		{
			bool flag4 = networkTRSP.TryGetSnapshotsBuffers(out from, out to, out alpha);
			bool flag5 = !flag4;
			flag3 = (byte)(&alpha) != 0;
			quaternion = (Quaternion)(&to);
			num = (int)(&from);
			networkTRSPData = (NetworkTRSPData)flag4;
			networkTRSP2 = networkTRSP;
			obj = obj2;
			if (flag5)
			{
				goto IL_1246;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6800]");
			object obj3 = 0;
			NetworkTRSPData networkTRSPData2 = from.ReinterpretState<NetworkTRSPData>(0);
			quaternion = (Quaternion)obj3;
			networkTRSPData = to.ReinterpretState<NetworkTRSPData>(0);
			NetworkObject networkObject = ((SimulationBehaviour)networkTRSP)._object;
			bool flag6 = (object)((SimulationBehaviour)networkTRSP)._object == null;
			num2 = num3;
			flag2 = false;
			flag3 = (byte)(&alpha) != 0;
			num = 0;
			obj = obj2;
			if (!flag6)
			{
				NetworkObjectMeta meta = networkObject.Meta;
				bool flag7 = networkObject.Meta == null;
				num2 = num3;
				flag2 = false;
				flag3 = (byte)(&alpha) != 0;
				num = 0;
				obj = obj2;
				if (!flag7)
				{
					int* ptr = meta._ptr;
					object obj4 = default;
					if (initial != (Tick)(object)0)
					{
						if (initial != (Tick)obj4 && networkTRSP.reenabledTick != (Tick)obj4)
						{
							goto IL_13d1;
						}
					}
					else
					{
						ref Tick reference = ref *(Tick*)obj4;
					}
					alpha = 1.0653532E+09f;
					goto IL_13d1;
				}
			}
		}
		goto IL_1322;
		IL_02fb:
		object obj5;
		object obj6 = default;
		bool flag8 = obj5 == obj6;
		num2 = num3;
		float num4;
		float num5;
		if (!flag8)
		{
			num2 = ((!((double)alpha < 0.5)) ? 1f : 0f);
			num4 = 0f;
			num5 = alpha;
			alpha = num2;
		}
		bool flag9;
		NetworkBehaviourId networkBehaviourId;
		Vector3Compressed vector3Compressed;
		if (flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X0_v102+E4]");
			bool flag10 = (nint)0 == 0;
			object obj9 = !flag10;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (networkBehaviourId == (NetworkBehaviourId)vector3Compressed)
			{
				SetParentTransform(networkTRSP2, transform, networkBehaviourId);
			}
			else
			{
				NetworkBehaviourId parentId = ((!((double)alpha < 0.5)) ? ((NetworkBehaviourId)vector3Compressed) : networkBehaviourId);
				SetParentTransform(networkTRSP2, transform, parentId);
				num2 = ((!((double)alpha < 0.5)) ? 1f : 0f);
				num5 = 0f;
				alpha = num2;
			}
		}
		bool flag12;
		bool flag11 = !flag12;
		object obj11 = default;
		object obj10 = obj11;
		Vector3Compressed vector3Compressed2 = default;
		Quaternion a = (Quaternion)vector3Compressed2;
		flag3 = (byte)(&alpha) != 0;
		Vector3Compressed vector3Compressed3 = default;
		int num6 = default;
		object obj12;
		int num10;
		Quaternion quaternion2;
		float num8;
		float num9;
		if (!flag11)
		{
			bool flag13 = vector3Compressed2.Equals(vector3Compressed3);
			if (flag13)
			{
				bool flag14 = (object)transform == null;
				flag2 = false;
				flag3 = false;
				quaternion = (Quaternion)num6;
				num = (int)vector3Compressed3;
				networkTRSPData = (NetworkTRSPData)flag13;
				obj = obj12;
				if (flag14)
				{
					goto IL_1322;
				}
				Vector3 localScale = transform.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACEC0");
				Vector3Compressed vector3Compressed4 = default;
				bool flag15 = vector3Compressed4.Equals(vector3Compressed3);
				bool flag16 = !flag15;
				object obj13 = !flag16;
				obj10 = obj11;
				Vector3Compressed vector3Compressed5 = default;
				a = (Quaternion)vector3Compressed5;
				flag3 = false;
				if (obj13 != null)
				{
					goto IL_05ba;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
				obj10 = obj11;
				a = (Quaternion)vector3Compressed5;
				flag3 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30ACDD8");
				bool flag17 = alpha < 0f;
				double num7 = 0.0;
				if (!flag17)
				{
					bool flag18 = !((double)alpha > 1.0);
					num7 = alpha;
					if (!flag18)
					{
						num7 = 1.0;
					}
				}
				bool flag19 = (object)transform == null;
				num8 = (float)num7;
				num9 = alpha;
				flag2 = false;
				flag3 = false;
				quaternion = (Quaternion)0;
				num = num10;
				obj = obj12;
				if (flag19)
				{
					goto IL_1322;
				}
				obj10 = obj11;
				a = quaternion2;
				flag3 = false;
			}
			transform.localScale = (Vector3)0;
		}
		goto IL_05ba;
		IL_186a:
		float num11;
		float num12;
		float num13;
		float num14;
		float num15;
		double num18;
		double num19;
		double num20;
		float num16;
		float num17;
		if (local)
		{
			bool flag20 = (object)transform == null;
			num8 = num11;
			flag2 = false;
			obj = obj12;
			if (!flag20)
			{
				transform.localPosition = (Vector3)0;
				transform.localRotation = (Quaternion)0;
				num8 = num12;
				num4 = num13;
				num5 = num14;
				num2 = num15;
				num = 0;
				networkTRSPData = (NetworkTRSPData)transform;
				obj = obj12;
				goto IL_1246;
			}
		}
		else
		{
			bool flag21 = (object)transform == null;
			num8 = num15;
			flag2 = false;
			obj = obj12;
			if (!flag21)
			{
				transform.SetPositionAndRotation((Vector3)0, quaternion);
				num16 = num12;
				num17 = num13;
				num8 = num15;
				num9 = num14;
				num4 = (float)num18;
				num5 = (float)num19;
				num2 = (float)num20;
				num = 0;
				networkTRSPData = (NetworkTRSPData)transform;
				obj = obj12;
				goto IL_1246;
			}
		}
		goto IL_1322;
		IL_1367:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
		IL_179e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj14 = 0;
		Vector3 vector = (Vector3)obj14;
		Vector3? vector2 = (Vector3)obj14;
		Vector3? vector3 = (Vector3?)(object)0;
		Quaternion? quaternion3 = (Quaternion?)(object)(&vector2);
		object obj16;
		object obj15 = obj16;
		double num21 = num20 + (double)num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1866 @ X8_v62+A0]");
		object obj17 = 0;
		float num22 = (float)obj17;
		num19 += (double)num5;
		float num23;
		num18 += (double)num23;
		float num24;
		float num26;
		float num28;
		if ((object)num24 == obj17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X8_v63+4]");
			num22 = 0f;
			float num25 = num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X8_v63+4]");
			if (num25 == 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X8_v63+8]");
				num22 = 0f;
				float num27 = num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X8_v63+8]");
				if (num27 == 0f)
				{
					vector3 = (Vector3?)(object)0;
					_ = 0;
				}
			}
		}
		num4 = num2;
		num5 = num23;
		num2 = num22;
		num20 = num21;
		goto IL_16e5;
		IL_1322:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X24_v4+28]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag22 = num29 != 0;
		NullReferenceException ex = (NullReferenceException)networkTRSPData;
		if (!flag22)
		{
			ex = new NullReferenceException();
		}
		goto IL_1367;
		IL_1447:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X24_v4+28]");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ SYSREG+28]");
		bool flag23 = num30 != 0;
		flag2 = false;
		bool flag24;
		ex = (NullReferenceException)flag24;
		if (!flag23)
		{
			return flag24;
		}
		goto IL_1367;
		IL_1246:
		NetworkObject networkObject2 = ((SimulationBehaviour)networkTRSP2)._object;
		bool flag25 = (object)((SimulationBehaviour)networkTRSP2)._object == null;
		flag2 = false;
		if (!flag25)
		{
			NetworkObjectMeta meta2 = networkObject2.Meta;
			bool flag26 = networkObject2.Meta == null;
			flag2 = false;
			if (!flag26)
			{
				int* ptr2 = meta2._ptr;
				NetworkTRSP networkTRSP3 = networkTRSP2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v12 (System.Int32*)+20]");
				networkTRSP3._previousRenderStateAuth = (PlayerRef)0;
				flag24 = true;
				goto IL_1447;
			}
		}
		goto IL_1322;
		IL_07c9:
		Quaternion rotation = default;
		Quaternion quaternion4 = Quaternion.Internal_Inverse(ref rotation);
		float num31 = num8 * alpha;
		float num32 = alpha * num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj18 = 0;
		float num33 = num8 * num3;
		float num34 = num3 * num8;
		float num35 = num8 * num3;
		float num36 = num3 * num8;
		float num37 = num8 * num8;
		float num38 = alpha * alpha;
		float num39 = num31 + num32;
		float num40 = num3 * num3;
		float num41 = num33 + num34;
		float num42 = num3 * alpha;
		float num43 = num35 + num36;
		float num44 = alpha * num3;
		float num45 = num37 - num38;
		float num46 = num3 * num3;
		num9 = num40 + num39;
		num17 = num42 + num41;
		num16 = num3 * num3;
		float num47 = num44 + num43;
		float num48 = alpha * num3;
		float num49 = num3 * num3;
		float num50 = num45 - num46;
		float num51 = num3 * alpha;
		float num52 = num17 - num48;
		float num53 = num50 - num49;
		float num54 = num47 - num51;
		Vector3? vector4 = (Vector3)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
		object obj19 = 0;
		networkTRSP2._stateAuthorityChangePositionError = (Vector3?)(object)0;
		Quaternion quaternion5 = (Quaternion)obj19;
		Quaternion? quaternion6 = (Quaternion)obj19;
		networkTRSP2._stateAuthorityChangeRotationError = (Quaternion?)(object)0;
		_ = 0;
		num11 = num53;
		num23 = num54;
		num5 = num52;
		num2 = 0f;
		vector2 = (Vector3?)(object)0;
		quaternion3 = (Quaternion?)(object)(&quaternion6);
		goto IL_16aa;
		IL_13d1:
		bool flag27 = !checkForecastKinematic;
		NetworkBehaviourId networkBehaviourId2 = default;
		networkBehaviourId = networkBehaviourId2;
		Quaternion quaternion7 = quaternion;
		int num55 = 0;
		networkTRSP2 = networkTRSP;
		quaternion2 = (Quaternion)vector3Compressed3;
		flag12 = syncScale;
		flag9 = syncParent;
		vector3Compressed = vector3Compressed2;
		num10 = num6;
		obj5 = obj6;
		obj12 = obj2;
		if (flag27)
		{
			goto IL_02fb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D67F8]");
		object obj20 = 0;
		NetworkPhysicsData networkPhysicsData = from.ReinterpretState<NetworkPhysicsData>(14);
		quaternion7 = (Quaternion)obj20;
		NetworkPhysicsData networkPhysicsData2 = to.ReinterpretState<NetworkPhysicsData>(14);
		object obj22 = default;
		object obj21 = obj22 & 1;
		if (obj21 != null)
		{
			object obj23 = obj22 & 1;
			bool flag28 = obj23 == null;
			networkBehaviourId = networkBehaviourId2;
			num55 = 14;
			networkTRSP2 = networkTRSP;
			quaternion2 = (Quaternion)vector3Compressed3;
			flag12 = syncScale;
			flag9 = syncParent;
			vector3Compressed = vector3Compressed2;
			num10 = num6;
			obj5 = obj6;
			obj12 = obj2;
			num2 = num3;
			flag3 = (byte)(&alpha) != 0;
			quaternion = (Quaternion)obj20;
			num = 14;
			flag24 = false;
			obj = obj2;
			if (!flag28)
			{
				goto IL_02fb;
			}
		}
		else
		{
			num2 = num3;
			flag3 = (byte)(&alpha) != 0;
			quaternion = (Quaternion)obj20;
			num = 14;
			flag24 = false;
			obj = obj2;
		}
		goto IL_1447;
		IL_05ba:
		bool flag29 = alpha < 0f;
		double num56 = 0.0;
		if (!flag29)
		{
			bool flag30 = !((double)alpha > 1.0);
			num56 = alpha;
			if (!flag30)
			{
				num56 = 1.0;
			}
		}
		object obj25 = default;
		object obj24 = obj25 - obj25;
		object obj26 = default;
		num8 = (float)obj26 - (float)obj26;
		num9 = (float)obj10 - (float)obj11;
		double num57 = (double)obj24 * num56;
		double num58 = (double)num8 * num56;
		double num59 = (double)num9 * num56;
		Quaternion b = default;
		Quaternion quaternion8 = Quaternion.Internal_Slerp(ref a, ref b, alpha);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj27 = 0;
		networkTRSPData = (NetworkTRSPData)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v4 (Fusion.NetworkTRSPData)+E4]");
		bool flag31 = (nint)0 == 0;
		object obj28 = !flag31;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		num20 = (double)obj25 + num57;
		num19 = (double)obj26 + num58;
		num18 = (double)obj11 + num59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v19 (System.Int32*)+20]");
		bool flag32 = (object)0 == (object)networkTRSP2._previousRenderStateAuth;
		num11 = num8;
		num23 = num3;
		num5 = num3;
		num2 = alpha;
		vector2 = (Vector3?)(object)num3;
		quaternion5 = (Quaternion)(&b);
		quaternion3 = (Quaternion?)networkTRSPData;
		if (!flag32)
		{
			if (local)
			{
				bool flag33 = (object)transform == null;
				num4 = num3;
				num5 = num3;
				num2 = alpha;
				flag2 = false;
				quaternion = (Quaternion)0;
				num = (int)(&b);
				obj = obj12;
				if (!flag33)
				{
					Vector3 localPosition = transform.localPosition;
					Quaternion localRotation = transform.localRotation;
					goto IL_07c9;
				}
			}
			else
			{
				bool flag34 = (object)transform == null;
				num4 = num3;
				num5 = num3;
				num2 = alpha;
				flag2 = false;
				quaternion = (Quaternion)0;
				num = (int)(&b);
				obj = obj12;
				if (!flag34)
				{
					Vector3 position = transform.position;
					Quaternion rotation2 = transform.rotation;
					goto IL_07c9;
				}
			}
			goto IL_1322;
		}
		goto IL_16aa;
		IL_16aa:
		vector3 = (Vector3?)(object)(networkTRSP2 + 108);
		bool flag35 = (Vector3)vector3 == (Vector3)(object)0;
		num4 = num23;
		vector = (Vector3)quaternion5;
		if (!flag35)
		{
			num2 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
			bool flag36 = !(networkTRSP2._stateAuthorityChangeErrorCorrectionDelta > 0f);
			num4 = num23;
			vector = (Vector3)quaternion5;
			if (!flag36)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C08]");
				object obj29 = 0;
				Vector3 value = ((Vector3?*)vector3)->Value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				obj16 = 0;
				object obj30 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X8_v54+A0]");
				object obj31 = 0;
				num24 = (float)obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v55+4]");
				num26 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v55+8]");
				num28 = 0f;
				float num60 = (float)obj31 - networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v55+4]");
				float num61 = 0f - num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v55+8]");
				float num62 = 0f - num23;
				float num63 = num60 * num60;
				float num64 = num61 * num61;
				float num65 = num63 + num64;
				float num66 = num62 * num62;
				float num67 = num66 + num65;
				if (num67 != 0f)
				{
					if (!(networkTRSP2._stateAuthorityChangeErrorCorrectionDelta < 0f))
					{
						num65 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta * networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
						bool flag37 = num67 < num65;
						object obj32 = !flag37;
						float num68 = num67 - num65;
						bool flag38 = num68 == 0f;
						object obj33 = ~obj32;
						object obj34 = obj33 | flag38;
						if (obj34 != null)
						{
							goto IL_179e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj35 = 0;
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1843 @ X0_v62+E4]");
					bool flag39 = (nint)0 == 0;
					object obj37 = !flag39;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					float num69 = num60 / num65;
					float num70 = num61 / num65;
					float num71 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta * num69;
					num24 = num2 + num71;
					float num72 = num62 / num65;
					float num73 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta * num70;
					num26 = num5 + num73;
					float num74 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta * num72;
					num28 = num23 + num74;
					num11 = num2;
				}
				goto IL_179e;
			}
		}
		goto IL_16e5;
		IL_16e5:
		Quaternion? quaternion9 = (Quaternion?)(object)(networkTRSP2 + 124);
		bool flag40 = (Quaternion)quaternion9 == (Quaternion)(object)0;
		num14 = num3;
		num13 = num3;
		num15 = alpha;
		num12 = num8;
		quaternion = (Quaternion)0;
		num = (int)vector;
		networkTRSPData = (NetworkTRSPData)quaternion3;
		if (!flag40)
		{
			num2 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
			bool flag41 = !(networkTRSP2._stateAuthorityChangeErrorCorrectionDelta > 0f);
			num14 = num3;
			num13 = num3;
			num15 = alpha;
			num12 = num8;
			quaternion = (Quaternion)0;
			num = (int)vector;
			networkTRSPData = (NetworkTRSPData)quaternion3;
			if (!flag41)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6418]");
				object obj38 = 0;
				Quaternion value2 = ((Quaternion?*)quaternion9)->Value;
				float num75 = num8 * num4;
				float num76 = num8 * num5;
				float num77 = alpha * num11;
				float num78 = num8 * networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
				float num79 = num3 * num11;
				float num80 = num3 * num11;
				float num81 = num8 * num11;
				float num82 = alpha * networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
				float num83 = num3;
				float num84 = num3;
				num16 = num78 + num77;
				float num85 = num3 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
				object obj39 = 0;
				num47 = num76 + num80;
				float num86 = num3 * networkTRSP2._stateAuthorityChangeErrorCorrectionDelta;
				num17 = num75 + num79;
				float num87 = alpha * num5;
				float num88 = num81 - num82;
				object obj40 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ X8_v37+A0]");
				object obj41 = 0;
				Quaternion quaternion10 = (Quaternion)obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v38+8]");
				float num89 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v38+C]");
				float num90 = 0f;
				float num91 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta * (float)obj41;
				float num92 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v38+4]");
				float num93 = num92 * 0f;
				float num94 = num91 + num93;
				float num95 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v38+8]");
				float num96 = num95 * 0f;
				float num97 = num96 + num94;
				float num98 = num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X8_v38+C]");
				float num99 = num98 * 0f;
				float num100 = num3 * num5;
				float num101 = num99 + num97;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
				bool flag42 = num101 > 0f;
				quaternion = (Quaternion)0;
				Quaternion? a2 = default;
				if (!flag42)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
					float num102 = num101 + num101;
					float num103 = num102;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
					float num104 = num103 * 0f;
					bool flag43 = num104 == 0f;
					num83 = num3;
					num84 = num3;
					quaternion = (Quaternion)0;
					if (!flag43)
					{
						float num105 = networkTRSP2._stateAuthorityChangeErrorCorrectionDelta / num104;
						float num106 = num105 - 1f;
						bool flag44 = num106 < 0f;
						bool flag45 = num106 == 0f;
						object obj42 = (double)num105 ^ 1.0;
						object obj43 = num105 ^ num106;
						object obj44 = obj42 & obj43;
						bool flag46 = (nint)obj44 < 0;
						bool flag47 = flag44 == flag46;
						object obj45 = !flag45;
						object obj46 = flag47 & obj45;
						object obj47 = ~obj46;
						if (obj47 == null)
						{
							num105 = 1f;
						}
						Quaternion quaternion11 = Quaternion.Internal_SlerpUnclamped(ref *(Quaternion*)(&a2), ref b, num105);
						num83 = num3;
						quaternion10 = (Quaternion)num105;
						num84 = num3;
						num90 = num3;
						num89 = num3;
						quaternion = (Quaternion)0;
					}
				}
				float num107 = num85 + num16;
				float num108 = num83 * num2;
				float num109 = num88 - num100;
				float num110 = num84 * num5;
				float num111 = num87 + num17;
				float num112 = num86 + num47;
				float num113 = alpha * num4;
				float num114 = num84 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
				object obj48 = 0;
				a2 = (Quaternion)obj48;
				quaternion9 = (Quaternion?)(object)0;
				_ = 0;
				object obj49 = obj39;
				float num115 = num107 - num110;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1896 @ X8_v45+A0]");
				object obj50 = 0;
				float num116 = num112 - num113;
				float num117 = num111 - num108;
				float num118 = num109 - num114;
				num2 = (float)obj50;
				float num119 = default;
				bool flag48 = num119.Equals((float)obj50);
				bool flag49 = !flag48;
				num = 0;
				networkTRSPData = (NetworkTRSPData)flag48;
				if (!flag49)
				{
					float num120 = (nint)(&num119) | (nint)4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+4]");
					bool flag50 = ((float*)num120)->Equals(0f);
					bool flag51 = !flag50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+4]");
					num2 = 0f;
					num = 0;
					networkTRSPData = (NetworkTRSPData)flag50;
					if (!flag51)
					{
						float num121 = (float)(ref num119) + 8f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+8]");
						bool flag52 = ((float*)num121)->Equals(0f);
						bool flag53 = !flag52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+8]");
						num2 = 0f;
						num = 0;
						networkTRSPData = (NetworkTRSPData)flag52;
						if (!flag53)
						{
							float num122 = (float)(ref num119) + 12f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+C]");
							bool flag54 = ((float*)num122)->Equals(0f);
							bool flag55 = !flag54;
							num14 = num116;
							num11 = num90;
							num9 = (float)quaternion10;
							num4 = num89;
							num5 = num113;
							num13 = num117;
							num15 = num115;
							num12 = num118;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+C]");
							num2 = 0f;
							num = 0;
							networkTRSPData = (NetworkTRSPData)flag54;
							if (!flag55)
							{
								quaternion9 = (Quaternion?)(object)0;
								_ = 0;
								_ = 0;
								num14 = num116;
								num11 = num90;
								num9 = (float)quaternion10;
								num4 = num89;
								num5 = num113;
								num13 = num117;
								num15 = num115;
								num12 = num118;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ X8_v46+C]");
								num2 = 0f;
								num = 0;
								networkTRSPData = (NetworkTRSPData)flag54;
							}
							goto IL_186a;
						}
					}
				}
				num14 = num116;
				num11 = num90;
				num9 = (float)quaternion10;
				num4 = num89;
				num5 = num113;
				num13 = num117;
				num15 = num115;
				num12 = num118;
			}
		}
		goto IL_186a;
	}
}
