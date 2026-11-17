using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine.InputSystem;

namespace Fusion;

internal class SimulationMessage : Action<InputActionAsset.CallbackContext>
{
	public SimulationMessageHeader Header;

	public int RefCount;

	private Fusion.PooledList<byte> _payload;

	public Span<byte> Payload
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0013: Expected VT, but got Obj
			ArgumentNullException ex = new ArgumentNullException();
			return (Span<byte>)ex;
		}
	}

	public void Dump(StringBuilder builder)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9348]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA868]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj3 = default;
		object obj4 = default;
		string text = string.Format((string)format, obj3, obj4);
		if (builder != null)
		{
			StringBuilder stringBuilder = builder.Append(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag = num != 0;
			object obj5 = null;
			object obj6 = text;
			NullReferenceException ex = (NullReferenceException)(object)stringBuilder;
			if (!flag)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
			bool flag2 = num2 != 0;
			object obj5 = obj4;
			object obj6 = obj3;
			NullReferenceException ex = (NullReferenceException)(object)text;
			if (!flag2)
			{
				ex = new NullReferenceException();
				obj5 = obj4;
				obj6 = obj3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	internal void PoolInit(Simulation simulation, [In] ref SimulationMessageHeader header)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I
		RefCount = 1;
		Header = header;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.SimulationMessageHeader&)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA870]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.SimulationMessageHeader&)+4]");
		Fusion.PooledList<byte> pooledList = simulation.AcquireByteList(0);
		object obj2 = this + 56;
		Fusion.PooledList<byte> payload = default;
		_payload = payload;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v2+20]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v2+20]");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v9+A8]");
		object obj8 = 0;
		object obj9 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4099358");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.SimulationMessageHeader&)+4]");
		object obj11 = default;
		object obj10 = obj11 - 0;
		bool flag2 = (nint)obj10 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.SimulationMessageHeader&)+4]");
		object obj12 = obj11 ^ 0;
		object obj13 = obj11 ^ obj10;
		object obj14 = obj12 & obj13;
		bool flag3 = (nint)obj14 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA878]");
		object error = 0;
		bool condition = flag2 == flag3;
		Assert.Always(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.SimulationMessageHeader&)+4]");
		_ = 0;
	}

	public unsafe void PoolReset(Simulation simulation)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Ref, but got Unknown
		//IL_0044: Expected VT, but got I4
		//IL_004f: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA880]");
		object error = 0;
		bool condition = RefCount == 0;
		Assert.Always(condition, (string)error);
		simulation.Release(ref *(Fusion.PooledList<byte>*)(this + 56));
		_ = 0;
		_ = 0;
		_payload = (Fusion.PooledList<byte>)0;
		Header = (SimulationMessageHeader)0;
		_ = 0;
	}
}
