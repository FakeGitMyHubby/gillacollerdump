using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public abstract class SimulationBehaviour : Behaviour
{
	[NonSerialized]
	internal SimulationBehaviour Prev;

	[NonSerialized]
	internal SimulationBehaviour Next;

	[NonSerialized]
	internal SimulationBehaviourRuntimeFlags Flags = (SimulationBehaviourRuntimeFlags)16;

	private NetworkRunner _runner;

	private NetworkObject _object;

	public bool CanReceiveRenderCallback
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = Flags & (SimulationBehaviourRuntimeFlags)0x1C;
			return obj == null;
		}
	}

	public bool CanReceiveSimulationCallback
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			object obj = Flags & (SimulationBehaviourRuntimeFlags)0x1C;
			bool result = obj == null;
			object obj2 = Flags & (SimulationBehaviourRuntimeFlags)3;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				return false;
			}
			return result;
		}
	}

	public bool IsResimulationSkipped
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)Flags >> 6;
			return (byte)(obj & 1) != 0;
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

	public NetworkObject Object
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _object;
		}
	}

	public bool IsValid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0101: Expected I4, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)_object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = _object;
				if ((object)_object != null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!networkObject._runner)
					{
						goto IL_00ed;
					}
					if ((object)networkObject._runner != null)
					{
						ArgumentNullException ex = new ArgumentNullException();
						return (byte)(int)ex != 0;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_00ed;
			IL_00ed:
			return false;
		}
	}

	public virtual void FixedUpdateNetwork()
	{
	}

	internal virtual void PreRender()
	{
	}

	public virtual void Render()
	{
	}

	private void OnDestroy()
	{
		SimulationBehaviourRuntimeFlags flags = Flags | (SimulationBehaviourRuntimeFlags)8;
		Flags = flags;
	}

	private void OnEnable()
	{
		//IL_0014: Expected I4, but got I8
		SimulationBehaviourRuntimeFlags flags = (SimulationBehaviourRuntimeFlags)((long)Flags & 0xFFFFFFEFL);
		Flags = flags;
	}

	private void OnDisable()
	{
		SimulationBehaviourRuntimeFlags flags = Flags | (SimulationBehaviourRuntimeFlags)0x10;
		Flags = flags;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void MakeOwned(NetworkRunner runner, NetworkObject obj)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		object obj2 = this + 56;
		obj2 = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = this + 64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void MakeUnowned()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		object obj = this + 56;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 64;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal void DebugNotifySpawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D60C8]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+188]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+190]");
			object obj9 = 0;
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	internal void DebugNotifyDespawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D60D0]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+188]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v1+190]");
			object obj9 = 0;
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X4_v1 (should have been resolved before IL gen)");
		}
	}

	protected internal unsafe override void GetDumpString(StringBuilder builder)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I8
		//IL_0218: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj = 0;
		StringBuilder stringBuilder = builder.Append((string)value);
		string debugNameThreadSafe = DebugNameThreadSafe;
		StringBuilder stringBuilder2 = builder.Append(debugNameThreadSafe);
		bool flag = (object)this == null;
		object obj2 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D60D8]");
			object obj3 = 0;
			nint num = (nint)this;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v3 (Il2CppClass<Fusion.SimulationBehaviour>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12+130]");
			bool flag2 = num2 < 0;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			obj2 = 0;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X9_v3 (Il2CppClass<Fusion.SimulationBehaviour>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12+130]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v5-8]");
				bool flag3 = 0 != (nint)obj4;
				obj2 = 0;
				if (!flag3)
				{
					NetworkObject networkObject = _object;
					Span<int> span = default;
					if ((object)_object != null)
					{
						int* ptr = networkObject.Ptr;
						if (networkObject.Ptr != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X23_v12 (System.Int32*)+4]");
							object obj8 = 0 & -9223372036854775808L;
							if (obj8 != null)
							{
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
							}
						}
						if (!span.IsEmpty)
						{
						}
					}
					NetworkBehaviourId networkBehaviourId = default;
					bool isValid = networkBehaviourId.IsValid;
					bool flag4 = !isValid;
					obj2 = 0;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
						object value2 = 0;
						StringBuilder stringBuilder3 = builder.Append((string)value2);
						NetworkObject networkObject2 = _object;
						if ((object)_object != null)
						{
							int* ptr2 = networkObject2.Ptr;
							if (networkObject2.Ptr != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X23_v8 (System.Int32*)+4]");
								object obj9 = 0 & -9223372036854775808L;
								if (obj9 != null)
								{
									System.ThrowHelper.ThrowArgumentOutOfRangeException();
								}
							}
							if (!span.IsEmpty)
							{
							}
						}
						string value3 = networkBehaviourId.ToString();
						StringBuilder stringBuilder4 = builder.Append(value3);
						obj2 = 0;
					}
				}
			}
		}
		int length = builder.Length;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
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
