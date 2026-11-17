using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion;

public sealed class NetworkMecanimAnimator : NetworkBehaviour, Action<InputUpdateType>, _0021_00210
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct DictionaryInitializer<K, V>
	{
		public static implicit operator NetworkDictionary<K, V>(DictionaryInitializer<K, V> arr)
		{
			//IL_0043: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NotImplementedException ex = default;
			string message = default;
			ex._002Ector(message);
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkDictionary<K, V>)ex2;
		}
	}

	public Animator Animator;

	public RenderSource ApplyTiming;

	internal AnimatorSyncSettings SyncSettings;

	internal int[] StateHashes;

	internal int[] TriggerHashes;

	internal int TotalWords;

	private readonly HashSet<int> _pendingTriggers;

	private NetworkTypesMeta.AnimatorData _animatorData;

	private bool _isInitialized;

	private const int BITS_PER_BOOL = default(int);

	private int _lastAppliedTick;

	public override int? DynamicWordCount
	{
		get
		{
			//IL_0021: Expected VT, but got I4
			EnsureInitialized();
			int? num = TotalWords;
			return (int?)(object)0;
		}
	}

	public override void Spawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		EnsureInitialized();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Animator == null)
		{
			enabled = false;
		}
	}

	private void Fusion_002EIAfterAllTicks_002EAfterAllTicks(bool resimulation, int tickCount)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		EnsureInitialized();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj2 = default;
		object obj = obj2 & 1;
		if (obj != null)
		{
			CaptureAnimatorData();
		}
	}

	public unsafe override void Render()
	{
		//IL_018c: Expected Obj, but got Ref
		//IL_019a: Expected Obj, but got Ref
		//IL_0228: Expected I4, but got Obj
		//IL_00be: Invalid comparison between VT and I4
		//IL_0205: Expected Obj, but got Ref
		//IL_026b: Expected VT, but got Obj
		//IL_01f8: Expected Obj, but got Ref
		//IL_012b: Expected I4, but got Obj
		//IL_0146: Expected I4, but got VT
		EnsureInitialized();
		if (!((SimulationBehaviour)this)._object.IsProxy)
		{
			return;
		}
		if (ApplyTiming == (RenderSource)3)
		{
			NetworkRunner runner = ((SimulationBehaviour)this)._runner;
			Simulation simulation = runner._simulation;
			if ((object)runner._simulation != null)
			{
				int num = ~_lastAppliedTick;
				int num2 = _lastAppliedTick & num;
				if (simulation._tick > (object)num2)
				{
					NetworkBehaviourBuffer stateBuffer = StateBuffer;
					ApplyAnimatorData(stateBuffer);
					NetworkRunner runner2 = ((SimulationBehaviour)this)._runner;
					Simulation simulation2 = runner2._simulation;
					bool flag = (object)runner2._simulation == null;
					int lastAppliedTick = (int)runner2._simulation;
					if (!flag)
					{
						lastAppliedTick = (int)simulation2._tick;
					}
					_lastAppliedTick = lastAppliedTick;
					return;
				}
			}
		}
		if (TryGetSnapshotsBuffers(out var from, out var to, out var _))
		{
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref to, 8));
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref from, 8));
			if (ApplyTiming != (RenderSource)2)
			{
				obj = obj2;
			}
			int num3 = obj >> 32;
			int num4 = ~_lastAppliedTick;
			int num5 = _lastAppliedTick & num4;
			if (num5 < num3)
			{
				object obj3 = ((ApplyTiming != (RenderSource)2) ? ((object)(&from)) : ((object)(&to)));
				ApplyAnimatorData((NetworkBehaviourBuffer)obj3);
				_lastAppliedTick = num3;
			}
		}
	}

	public void SetTrigger(int triggerHash, bool passThroughOnInputAuthority = default(bool))
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		EnsureInitialized();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj2 = default;
		object obj = obj2 & 1;
		if (obj != null)
		{
			bool flag = _pendingTriggers.Add(triggerHash);
		}
		else if (passThroughOnInputAuthority && ((SimulationBehaviour)this)._object.HasInputAuthority)
		{
			Animator.SetTrigger(triggerHash);
		}
	}

	public void SetTrigger(string trigger, bool passThroughOnInputAuthority = default(bool))
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		EnsureInitialized();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		object obj2 = default;
		object obj = obj2 & 1;
		if (obj != null)
		{
			int item = Animator.StringToHash(trigger);
			bool flag = _pendingTriggers.Add(item);
		}
		else if (passThroughOnInputAuthority && ((SimulationBehaviour)this)._object.HasInputAuthority)
		{
			Animator.SetTrigger(trigger);
		}
	}

	private void CaptureAnimatorData()
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I4
		int wordOffset = default;
		CaptureParameters(ref wordOffset);
		AnimatorSyncSettings syncSettings = SyncSettings;
		object obj = SyncSettings & (AnimatorSyncSettings)0x10;
		if (obj != null)
		{
			CaptureStates(ref wordOffset);
			syncSettings = SyncSettings;
		}
		object obj2 = syncSettings & (AnimatorSyncSettings)0x40;
		if (obj2 != null)
		{
			CaptureLayerWeights(ref wordOffset);
		}
	}

	private unsafe void ApplyAnimatorData(NetworkBehaviourBuffer buffer)
	{
		//IL_0028: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		IntPtr intPtr = default;
		ApplyParameters(buffer, ref *(int*)intPtr);
		AnimatorSyncSettings syncSettings = SyncSettings;
		object obj = SyncSettings & (AnimatorSyncSettings)0x10;
		if (obj != null)
		{
			ApplyStates(buffer, ref *(int*)intPtr);
			syncSettings = SyncSettings;
		}
		object obj2 = syncSettings & (AnimatorSyncSettings)0x40;
		if (obj2 != null)
		{
			ApplyLayerWeights(buffer, ref *(int*)intPtr);
		}
	}

	private unsafe void CaptureStates(ref int wordOffset)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0126: Expected I4, but got I8
		//IL_0087: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+BC]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj3 = 0;
		int layerIndex = 0;
		ref int reference;
		if (Animator.IsInTransition(layerIndex))
		{
			object obj4 = wordOffset + 1;
			reference = ref *(int*)obj4;
			throw new ArgumentNullException();
		}
		AnimatorStateInfo currentAnimatorStateInfo = Animator.GetCurrentAnimatorStateInfo(layerIndex);
		int num2 = default;
		int num = Array.IndexOf(StateHashes, num2);
		int num3 = (int)(num & 0x80000000L);
		bool flag = num3 == 0;
		int num4 = num;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v22+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v23+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v23+10]");
			if ((nint)0 != 0)
			{
				string text = name;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X8_v24+1B8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D40]");
				object obj12 = 0;
				string text3 = default;
				string text2 = text + (string)obj11 + text3 + (string)obj12;
				object obj13 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ X8_v29+198] (should have been resolved before IL gen)");
				num4 = num2;
			}
			else
			{
				num4 = num2;
			}
		}
		object obj14 = wordOffset + 1;
		reference = ref *(int*)obj14;
		throw new ArgumentNullException();
	}

	private void ApplyStates(NetworkBehaviourBuffer buffer, ref int wordOffset)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_0322: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I
		//IL_0351: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027e: Expected F4, but got Obj
		//IL_02be: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+BC]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D48]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj2 = 0;
		nint num2 = default;
		nint num = num2;
		int num3 = 0;
		NetworkBehaviourBuffer networkBehaviourBuffer = default;
		object obj12 = default;
		string text5 = default;
		object obj20 = default;
		while (true)
		{
			object obj3 = num2 + 1;
			num2 = (nint)obj3;
			int num4 = networkBehaviourBuffer.ReinterpretState<int>((int)num2);
			string text = (string)num2;
			object obj4 = num2 + 1;
			num2 = (nint)obj4;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D554C");
			if (num4 == 0)
			{
				return;
			}
			int stateNameHash;
			string text2;
			if (num4 >= 1)
			{
				int[] stateHashes = StateHashes;
				if (StateHashes == null)
				{
					goto IL_02cd;
				}
				bool flag = num4 < stateHashes.Length;
				object obj6 = !flag;
				if (num4 < stateHashes.Length)
				{
					if (obj6 != null)
					{
						break;
					}
					object obj7 = StateHashes + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v31+20]");
					stateNameHash = 0;
					text2 = (string)num;
					goto IL_0380;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v22+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23+10]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23+10]");
			bool flag2 = (nint)0 == 0;
			text2 = (string)num;
			stateNameHash = num4;
			if (!flag2)
			{
				string text3 = name;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
				if (obj12 == null)
				{
					goto IL_02cd;
				}
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X8_v24+1B8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D40]");
				object obj15 = 0;
				text2 = (string)obj15;
				string text4 = text3 + (string)obj14 + text5 + (string)obj15;
				object obj16 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v29+1A0]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v329 @ X8_v29+198] (should have been resolved before IL gen)");
				stateNameHash = num4;
				text = text4;
			}
			goto IL_0380;
			IL_0380:
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)Animator != null)
			{
				object obj19 = obj20 & 1;
				object obj21 = 0 - obj19;
				float normalizedTime = obj21 ^ obj20;
				Animator.Play(stateNameHash, num3, normalizedTime);
				num3++;
				int num5 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+BC]");
				bool flag4 = (nint)num5 < (nint)0;
				num = unchecked((nint)null);
				if (!flag4)
				{
					return;
				}
				continue;
			}
			goto IL_02cd;
			IL_02cd:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void CaptureParameters(ref int wordOffset)
	{
		//IL_0afa: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0b45: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_05e8: Expected Obj, but got I4
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_047d: Expected Obj, but got I4
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_066f: Expected Obj, but got I4
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_06c0: Expected Obj, but got I4
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_06d9: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I4
		//IL_04fd: Expected F4, but got I4
		//IL_06fe: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I4
		//IL_09db: Expected Obj, but got I4
		//IL_09f3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_0a88: Expected I, but got Obj
		//IL_0a12: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I4
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected Obj, but got Unknown
		//IL_0769: Expected Obj, but got I
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_0575: Expected Obj, but got F4
		//IL_05b6: Expected Obj, but got F8
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_0845: Expected Obj, but got I4
		//IL_084e: Expected Obj, but got I4
		//IL_071e: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_096d: Expected Obj, but got I4
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected Obj, but got Unknown
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected Obj, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_0aae: Expected Obj, but got I
		//IL_07a4: Expected Obj, but got I4
		//IL_07ad: Expected Obj, but got I4
		//IL_07b5: Expected I, but got Obj
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Expected Obj, but got Unknown
		//IL_03cc: Expected I, but got Obj
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_07db: Expected Obj, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0432: Expected I, but got Obj
		//IL_043a: Expected Obj, but got I4
		//IL_0864: Expected Obj, but got I4
		//IL_0875: Expected Obj, but got I4
		//IL_0458: Expected Obj, but got I4
		//IL_0816: Expected Obj, but got I4
		//IL_0827: Expected Obj, but got I4
		//IL_082f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A8]");
		bool flag = (nint)0 < (nint)1;
		NetworkMecanimAnimator networkMecanimAnimator = this;
		object obj28 = default;
		ref int reference;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+B0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+B0]");
			if ((nint)0 == 0)
			{
				goto IL_08c2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+B0]");
			object obj2 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
			object obj3 = (nint)0 + (nint)32;
			object obj4 = 1;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
			object obj6 = 0;
			object obj7 = 0;
			object obj8 = 0;
			nint num = unchecked((nint)null);
			NetworkMecanimAnimator networkMecanimAnimator2 = this;
			networkMecanimAnimator = this;
			while (true)
			{
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X25_v5+18]");
				bool flag2 = (nint)obj9 < 0;
				object obj10 = !flag2;
				if (obj10 != null)
				{
					break;
				}
				nint num7;
				object obj39;
				if (obj6 != null)
				{
					object obj11 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X20_v9+18]");
					bool flag3 = (nint)obj11 < 0;
					object obj12 = !flag3;
					if (obj12 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v10+v297 @ X27_v6*8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v10+v297 @ X27_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v16+18]");
						if ((nint)0 <= (nint)3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v16+18]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v16+18]");
								if ((nint)0 == 3)
								{
									object obj14 = SyncSettings & (AnimatorSyncSettings)1;
									if (obj14 != null)
									{
										object obj15 = wordOffset + 1;
										reference = ref *(int*)obj15;
										ArgumentNullException ex = new ArgumentNullException();
										if ((object)networkMecanimAnimator.Animator == null)
										{
											goto IL_08c2;
										}
										Animator animator = networkMecanimAnimator.Animator;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v9+v297 @ X27_v6*4]");
										int integer = animator.GetInteger(0);
										ex = (ArgumentNullException)integer;
										networkMecanimAnimator2 = (NetworkMecanimAnimator)integer;
										goto IL_0936;
									}
								}
							}
							else
							{
								object obj16 = SyncSettings & (AnimatorSyncSettings)2;
								if (obj16 != null)
								{
									if ((object)networkMecanimAnimator.Animator == null)
									{
										goto IL_08c2;
									}
									Animator animator2 = networkMecanimAnimator.Animator;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v9+v297 @ X27_v6*4]");
									bool flag4 = animator2.IsParameterControlledByCurve(0);
									bool flag5 = !flag4;
									object obj17 = !flag5;
									float num2 = 0f;
									float num3;
									if (obj17 == null)
									{
										if ((object)networkMecanimAnimator.Animator == null)
										{
											goto IL_08c2;
										}
										Animator animator3 = networkMecanimAnimator.Animator;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v9+v297 @ X27_v6*4]");
										num3 = animator3.GetFloat(0);
										num2 = num3;
									}
									object obj18 = wordOffset + 1;
									reference = ref *(int*)obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D30]");
									object obj19 = 0;
									ArgumentNullException ex2 = new ArgumentNullException();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
									object obj20 = 0;
									networkMecanimAnimator2 = (NetworkMecanimAnimator)obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v10 (Fusion.NetworkMecanimAnimator)+E4]");
									bool flag6 = (nint)0 == 0;
									object obj21 = !flag6;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj22 = num2 >> 31;
									float num4 = num2 * 1.1492393E+09f;
									double num5 = 0.5 - (double)obj22;
									double num6 = (double)num4 + num5;
									object obj23 = num6 >> 31;
									object obj24 = obj23 ^ num6;
									ex2 = (ArgumentNullException)obj24;
									num3 = (float)num6;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v16+18]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v16+18]");
								if ((nint)0 == 9)
								{
									if (networkMecanimAnimator._pendingTriggers == null)
									{
										goto IL_08c2;
									}
									HashSet<int> pendingTriggers = networkMecanimAnimator._pendingTriggers;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v9+v297 @ X27_v6*4]");
									bool flag7 = pendingTriggers.Contains(0);
									bool flag8 = !flag7;
									Animator animator4 = (Animator)flag7;
									if (!flag8)
									{
										animator4 = networkMecanimAnimator.Animator;
										if ((object)networkMecanimAnimator.Animator == null)
										{
											goto IL_08c2;
										}
										Animator animator5 = networkMecanimAnimator.Animator;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v9+v297 @ X27_v6*4]");
										animator5.SetTrigger(0);
									}
									object obj25 = SyncSettings & (AnimatorSyncSettings)8;
									bool flag9 = obj25 == null;
									networkMecanimAnimator2 = (NetworkMecanimAnimator)(object)animator4;
									if (flag9)
									{
										goto IL_0936;
									}
									object obj26 = obj4 & 1;
									bool flag10 = obj26 == null;
									networkMecanimAnimator2 = (NetworkMecanimAnimator)(object)animator4;
									if (!flag10)
									{
										ArgumentNullException ex3 = new ArgumentNullException();
										num = (nint)ex3;
										networkMecanimAnimator2 = (NetworkMecanimAnimator)(object)ex3;
									}
									object obj27 = obj28 & 7;
									object obj29 = obj27 << 2;
									object obj23 = 15 << (int)obj29;
									object obj30 = num & obj23;
									object obj31 = obj30 >> (int)obj29;
									object obj32 = obj31 | flag7;
									object obj33 = obj32 & 1;
									bool flag11 = obj33 == null;
									num7 = num;
									if (!flag11)
									{
										object obj34 = obj31 + 2;
										object obj35 = ~obj23;
										obj23 = num & obj35;
										object obj36 = obj34 & 0xE;
										obj31 = obj36 | flag7;
										object obj37 = obj31 << (int)obj29;
										nint num8 = obj37 | obj23;
										obj32 = flag7;
										num7 = num8;
									}
									object obj38 = obj28 + 1;
									if ((nint)obj38 == 8)
									{
										obj39 = obj8 + 1;
										ArgumentNullException ex4 = new ArgumentNullException();
										ex4 = (ArgumentNullException)num7;
										object obj40 = obj39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X28_v9 (Fusion.NetworkMecanimAnimator)+C0]");
										if ((nint)obj40 < 0)
										{
											ArgumentNullException ex5 = new ArgumentNullException();
											obj28 = 0;
											obj23 = obj8;
											obj4 = 0;
											num7 = (nint)ex5;
											networkMecanimAnimator2 = (NetworkMecanimAnimator)(object)ex5;
										}
										else
										{
											obj28 = 0;
											obj23 = obj8;
											obj4 = 0;
											networkMecanimAnimator2 = (NetworkMecanimAnimator)(object)ex4;
										}
										goto IL_0ac3;
									}
									obj28 = obj38;
									obj4 = 0;
									obj5 = obj2;
									num = num7;
								}
							}
							else
							{
								object obj41 = SyncSettings & (AnimatorSyncSettings)4;
								if (obj41 != null)
								{
									object obj42 = obj4 & 1;
									if (obj42 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X28_v9 (Fusion.NetworkMecanimAnimator)+C4]");
										num = 0;
									}
									if ((object)networkMecanimAnimator.Animator == null)
									{
										goto IL_08c2;
									}
									object obj43 = obj28 & 7;
									object obj44 = obj43 << 2;
									object obj45 = 15 << (int)obj44;
									object obj46 = ~obj45;
									object obj47 = num & obj46;
									Animator animator6 = networkMecanimAnimator.Animator;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X23_v9+v297 @ X27_v6*4]");
									bool flag12 = animator6.GetBool(0);
									bool flag13 = !flag12;
									object obj48 = 1 << (int)obj44;
									object obj49 = obj28 + 1;
									object obj50 = !flag13;
									object obj51 = ~obj50;
									if (obj51 != null)
									{
										obj48 = 0;
									}
									bool flag14 = (nint)obj49 == 8;
									nint num9 = obj48 | obj47;
									object obj23;
									if (!flag14)
									{
										obj28 = obj49;
										obj23 = obj47;
										obj4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
										obj6 = 0;
										num = num9;
										networkMecanimAnimator2 = (NetworkMecanimAnimator)flag12;
										goto IL_0936;
									}
									obj39 = obj8 + 1;
									ArgumentNullException ex6 = new ArgumentNullException();
									ex6 = (ArgumentNullException)num9;
									object obj52 = obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X28_v9 (Fusion.NetworkMecanimAnimator)+C0]");
									nint num10;
									if ((nint)obj52 < 0)
									{
										ex6 = new ArgumentNullException();
										obj28 = 0;
										obj4 = 0;
										num10 = (nint)ex6;
									}
									else
									{
										obj28 = 0;
										obj4 = 0;
										num10 = num9;
									}
									obj23 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
									obj6 = 0;
									num7 = num10;
									networkMecanimAnimator2 = (NetworkMecanimAnimator)(object)ex6;
									goto IL_0ac3;
								}
							}
						}
						goto IL_0901;
					}
				}
				goto IL_08c2;
				IL_0936:
				obj5 = obj2;
				goto IL_0901;
				IL_0901:
				obj7++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A8]");
				if (0 != (nint)obj7)
				{
					continue;
				}
				goto IL_0882;
				IL_0ac3:
				obj5 = obj2;
				obj8 = obj39;
				num = num7;
				goto IL_0901;
			}
			goto IL_08d0;
		}
		goto IL_0ae0;
		IL_0ae0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X28_v9 (Fusion.NetworkMecanimAnimator)+C0]");
		object obj53 = (nint)0 + (nint)wordOffset;
		reference = ref *(int*)obj53;
		if (networkMecanimAnimator._pendingTriggers != null)
		{
			networkMecanimAnimator._pendingTriggers.Clear();
			return;
		}
		goto IL_08c2;
		IL_08d0:
		throw new IndexOutOfRangeException();
		IL_08c2:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_08d0;
		IL_0882:
		if ((nint)obj28 >= 1)
		{
			throw new ArgumentNullException();
		}
		goto IL_0ae0;
	}

	private unsafe void ApplyParameters(NetworkBehaviourBuffer buffer, ref int wordOffset)
	{
		//IL_0b98: Expected Obj, but got I
		//IL_0ba0: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0bc2: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_0636: Expected Obj, but got I4
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected Obj, but got Unknown
		//IL_04b1: Expected Obj, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_02de: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_095b: Expected Obj, but got I
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_0741: Expected I, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0320: Expected I4, but got VT
		//IL_0328: Expected I4, but got Obj
		//IL_0510: Expected VT, but got I
		//IL_051e: Expected Obj, but got I
		//IL_0526: Expected I, but got Obj
		//IL_0540: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I4
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected Obj, but got Unknown
		//IL_0786: Expected VT, but got I4
		//IL_06e5: Expected Obj, but got I
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Obj, but got Unknown
		//IL_0a86: Expected Obj, but got I4
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected I4, but got Unknown
		//IL_0ad8: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_09a1: Expected Obj, but got I4
		//IL_0b60: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I
		//IL_0573: Expected Obj, but got I
		//IL_07ac: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I4
		//IL_0af6: Expected Obj, but got I
		//IL_0b20: Expected Obj, but got I4
		//IL_0254: Expected I, but got Obj
		//IL_026c: Expected VT, but got I
		//IL_09c4: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_07f2: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I4
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_05d9: Expected F4, but got Obj
		//IL_0609: Expected VT, but got I
		//IL_0815: Expected Obj, but got I
		//IL_0838: Expected Obj, but got I
		//IL_0869: Expected VT, but got I4
		//IL_0b7e: Expected Obj, but got I4
		//IL_08a0: Expected Obj, but got I4
		//IL_08c3: Expected Obj, but got I
		//IL_08d3: Expected Obj, but got I
		//IL_0911: Expected VT, but got I4
		//IL_0921: Expected Obj, but got I
		//IL_0929: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A8]");
		bool flag = (nint)0 < (nint)1;
		IntPtr intPtr = default;
		nint num = intPtr;
		int num3;
		object obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+B0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+B0]");
			if ((nint)0 == 0)
			{
				goto IL_09ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+B0]");
			object obj3 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
			object obj4 = (nint)0 + (nint)32;
			nint num2 = intPtr;
			num3 = 0;
			object obj5 = 0;
			object obj6 = 1;
			obj7 = 0;
			object obj8 = 0;
			AnimatorSyncSettings syncSettings = SyncSettings;
			NetworkMecanimAnimator networkMecanimAnimator = this;
			num = intPtr;
			NetworkBehaviourBuffer networkBehaviourBuffer = default;
			ref int reference = default;
			NetworkBehaviourBuffer networkBehaviourBuffer2 = default;
			object obj25 = default;
			int num7 = default;
			while (true)
			{
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X27_v3+18]");
				bool flag2 = (nint)obj9 < 0;
				object obj10 = !flag2;
				if (obj10 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A0]");
				object obj16;
				int num5;
				bool flag9;
				Animator animator4;
				if ((nint)0 != 0)
				{
					object obj11 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X29_v5+18]");
					bool flag3 = (nint)obj11 < 0;
					object obj12 = !flag3;
					if (obj12 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v5+v320 @ X28_v6*8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v5+v320 @ X28_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v11+18]");
						if ((nint)0 <= (nint)3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v11+18]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v11+18]");
								if ((nint)0 == 3)
								{
									object obj14 = syncSettings & (AnimatorSyncSettings)1;
									if (obj14 != null)
									{
										object obj15 = num + 1;
										num = (nint)obj15;
										int num4 = networkBehaviourBuffer.ReinterpretState<int>((int)num);
										if ((object)Animator == null)
										{
											goto IL_09ce;
										}
										Animator animator = Animator;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
										animator.SetInteger(0, num4);
										num2 = unchecked((nint)null);
										reference = ref *(int*)num4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
										networkBehaviourBuffer2 = (NetworkBehaviourBuffer)0;
										obj16 = obj6;
										networkMecanimAnimator = (NetworkMecanimAnimator)(object)Animator;
										goto IL_0a45;
									}
								}
							}
							else
							{
								object obj17 = syncSettings & (AnimatorSyncSettings)2;
								if (obj17 != null)
								{
									if ((object)Animator == null)
									{
										goto IL_09ce;
									}
									Animator animator2 = Animator;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
									bool flag4 = animator2.IsParameterControlledByCurve(0);
									networkBehaviourBuffer2 = (NetworkBehaviourBuffer)num;
									object obj18 = num + 1;
									num = (nint)obj18;
									bool flag5 = !flag4;
									object obj19 = !flag5;
									reference = ref *(int*)null;
									obj16 = obj6;
									networkMecanimAnimator = (NetworkMecanimAnimator)flag4;
									if (obj19 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D48]");
										object obj20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D554C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
										object obj21 = 0;
										object obj22 = obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v28+E4]");
										bool flag6 = (nint)0 == 0;
										object obj23 = !flag6;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if ((object)Animator == null)
										{
											goto IL_09ce;
										}
										object obj24 = obj25 & 1;
										object obj26 = 0 - obj24;
										float value = obj26 ^ obj25;
										Animator animator3 = Animator;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
										animator3.SetFloat(0, value);
										reference = ref *(int*)null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
										networkBehaviourBuffer2 = (NetworkBehaviourBuffer)0;
										obj16 = obj6;
										networkMecanimAnimator = (NetworkMecanimAnimator)(object)Animator;
										num = intPtr;
									}
									goto IL_0a45;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v11+18]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v11+18]");
								if ((nint)0 == 9)
								{
									object obj27 = syncSettings & (AnimatorSyncSettings)8;
									if (obj27 != null)
									{
										object obj28 = obj6 & 1;
										bool flag7 = obj28 == null;
										num5 = (int)networkBehaviourBuffer2;
										int num6 = (int)networkMecanimAnimator;
										if (!flag7)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
											if ((nint)0 == 0)
											{
												goto IL_09ce;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C4]");
											num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D50]");
											object obj30 = 0;
											reference = ref *(int*)obj30;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C4]");
											num6 = networkBehaviourBuffer.ReinterpretState<int>(0);
											num7 = num6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v34+20]");
											obj5 = 0;
										}
										object obj31 = obj7 & 7;
										object obj32 = obj31 << 2;
										object obj33 = 15 << (int)obj32;
										object obj34 = obj5 & obj33;
										int num8 = num7 & obj33;
										object obj35 = obj34 >> (int)obj32;
										int num9 = num8 >> (int)obj32;
										bool flag8 = (nint)obj35 == num9;
										flag9 = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0;
										animator4 = (Animator)num6;
										if (!flag8)
										{
											int num10 = num9 & 1;
											bool flag10 = num10 == 0;
											object obj36 = !flag10;
											if (obj36 == null)
											{
												object obj37 = obj35 & 1;
												bool flag11 = obj37 == null;
												object obj38 = !flag11;
												flag9 = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0;
												animator4 = (Animator)num6;
												if (obj38 != null)
												{
													goto IL_0756;
												}
											}
											animator4 = Animator;
											if ((object)Animator == null)
											{
												goto IL_09ce;
											}
											Animator animator5 = Animator;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
											animator5.SetTrigger(0);
											flag9 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
											num5 = 0;
										}
										goto IL_0756;
									}
								}
							}
							else
							{
								object obj39 = syncSettings & (AnimatorSyncSettings)4;
								if (obj39 != null)
								{
									object obj40 = obj6 & 1;
									if (obj40 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
										object obj41 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
										if ((nint)0 == 0)
										{
											goto IL_09ce;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C4]");
										int num11 = networkBehaviourBuffer.ReinterpretState<int>(0);
										num7 = num11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v26+20]");
										obj5 = 0;
									}
									animator4 = Animator;
									if ((object)Animator != null)
									{
										object obj42 = obj7 & 7;
										object obj43 = obj42 << 2;
										int num12 = num7 >> (int)obj43;
										flag9 = (byte)(num12 & 1) != 0;
										Animator animator6 = Animator;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
										animator6.SetBool(0, flag9);
										num2 = unchecked((nint)null);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X19_v6+v320 @ X28_v6*4]");
										num5 = 0;
										goto IL_0756;
									}
									goto IL_09ce;
								}
							}
						}
						goto IL_0a10;
					}
				}
				goto IL_09ce;
				IL_0756:
				obj7++;
				bool flag12 = (nint)obj7 != 8;
				reference = ref *(flag9 ? ((int*)1) : ((int*)null));
				networkBehaviourBuffer2 = (NetworkBehaviourBuffer)num5;
				networkMecanimAnimator = (NetworkMecanimAnimator)(object)animator4;
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
					if ((nint)0 == 0)
					{
						goto IL_09ce;
					}
					int num13 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v18+18]");
					bool flag13 = (nint)num13 < (nint)0;
					object obj45 = !flag13;
					if (obj45 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
					object obj46 = (nint)0 + (nint)num3;
					int num8 = num3 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C0]");
					object obj34 = 0;
					int num14 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C0]");
					bool flag14 = (nint)num14 >= (nint)0;
					int num15 = num7;
					reference = ref *(flag9 ? ((int*)1) : ((int*)null));
					networkBehaviourBuffer2 = (NetworkBehaviourBuffer)num5;
					networkMecanimAnimator = (NetworkMecanimAnimator)(object)animator4;
					if (!flag14)
					{
						int num16 = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v18+18]");
						bool flag15 = (nint)num16 < (nint)0;
						object obj47 = !flag15;
						if (obj47 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
						object obj48 = (nint)0 + (nint)num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D50]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C4]");
						int num17 = (int)((nint)0 + (nint)num8);
						reference = ref *(int*)obj49;
						int num18 = networkBehaviourBuffer.ReinterpretState<int>(num17);
						num15 = num18;
						networkBehaviourBuffer2 = (NetworkBehaviourBuffer)num17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v20+20]");
						obj5 = 0;
						networkMecanimAnimator = (NetworkMecanimAnimator)num18;
					}
					num7 = num15;
					num3 = num8;
					obj7 = 0;
				}
				obj6 = 0;
				goto IL_0a10;
				IL_0a45:
				obj6 = obj16;
				syncSettings = SyncSettings;
				goto IL_0a10;
				IL_0a10:
				obj8++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+A8]");
				if (0 != (nint)obj8)
				{
					continue;
				}
				goto IL_092e;
			}
			goto IL_09dc;
		}
		goto IL_0b83;
		IL_092e:
		if ((nint)obj7 >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
			if ((nint)0 == 0)
			{
				goto IL_09ce;
			}
			int num19 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v14+18]");
			bool flag16 = (nint)num19 < (nint)0;
			object obj51 = !flag16;
			if (obj51 != null)
			{
				goto IL_09dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+D0]");
			object obj52 = (nint)0 + (nint)num3;
		}
		goto IL_0b83;
		IL_09dc:
		throw new IndexOutOfRangeException();
		IL_09ce:
		NullReferenceException ex = new NullReferenceException();
		goto IL_09dc;
		IL_0b83:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1 (Fusion.NetworkMecanimAnimator)+C0]");
		object obj53 = 0 + num;
		num = (nint)obj53;
	}

	private unsafe void CaptureLayerWeights(ref int wordOffset)
	{
		//IL_0015: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got F4
		//IL_00a7: Expected Obj, but got F4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+B8]");
		if ((nint)0 < (nint)2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		int num = 1;
		do
		{
			ArgumentNullException ex = new ArgumentNullException();
			float layerWeight = Animator.GetLayerWeight(num);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num++;
			object obj4 = layerWeight >> 31;
			float num2 = layerWeight * 1.1492393E+09f;
			double num3 = 0.5 - (double)obj4;
			float num4 = num2 + (float)num3;
			object obj5 = num4 >> 31;
			object obj6 = obj5 ^ num4;
			ex = (ArgumentNullException)obj6;
			object obj7 = wordOffset + 1;
			ref int reference = ref *(int*)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+B8]");
		}
		while ((nint)0 != num);
	}

	private void ApplyLayerWeights(NetworkBehaviourBuffer buffer, ref int wordOffset)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0073: Expected F4, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+B8]");
		if ((nint)0 < (nint)2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D48]");
		object obj = 0;
		nint num = default;
		object obj2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj3 = 0;
		int num2 = 1;
		object obj7 = default;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D554C");
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = obj7 & 1;
			object obj8 = 0 - obj6;
			float weight = obj8 ^ obj7;
			Animator.SetLayerWeight(num2, weight);
			num2++;
			obj2 = num + 1;
			num = (nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+B8]");
		}
		while ((nint)0 != num2);
	}

	private void EnsureInitialized()
	{
		//IL_02c2: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I
		//IL_02a7: Expected VT, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b4: Expected VT, but got I4
		//IL_0216: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		bool flag = (byte)(~(_isInitialized ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = this + 104;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj3;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		Animator animator = null;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD68]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			Animator animator2 = default;
			Animator = animator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			animator = animator2;
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)(UnityEngine.Object)obj3)
		{
			GameObject gameObject = ((Component)obj3).gameObject;
			if (gameObject.activeSelf)
			{
				NetworkTypesMeta.AnimatorData animatorData = new NetworkTypesMeta.AnimatorData(Animator, SyncSettings);
				object obj10 = this + 160;
				_animatorData = (NetworkTypesMeta.AnimatorData)0;
				_ = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_isInitialized = true;
				int totalWords = TotalWords;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkMecanimAnimator)+C8]");
				if ((nint)totalWords != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11+A0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v12+10]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v12+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D20]");
						object obj15 = 0;
						object obj16 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ X9_v3+198] (should have been resolved before IL gen)");
					}
				}
				return;
			}
		}
		_ = 0;
		_ = 0;
		_ = 0;
		_animatorData = (NetworkTypesMeta.AnimatorData)0;
	}

	public NetworkMecanimAnimator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BE80]");
		ApplyTiming = (RenderSource)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		object obj2 = this + 144;
		obj2 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		DefaultReplicated = true;
		Flags = (SimulationBehaviourRuntimeFlags)16;
		((Behaviour)this)._002Ector();
	}
}
