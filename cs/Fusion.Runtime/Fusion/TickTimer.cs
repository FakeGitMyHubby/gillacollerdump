using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 4)]
public struct TickTimer : _0021_00210
{
	[FieldOffset(0)]
	private int _target;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF__TARGET = default(int);

	internal const int BYTE_COUNT_OF__TARGET = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static TickTimer None
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (TickTimer)0;
		}
	}

	public bool IsRunning
	{
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = _target < 0;
			bool flag2 = _target == 0;
			int num = _target ^ _target;
			int num2 = _target & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public int? TargetTick
	{
		get
		{
			//IL_0033: Expected VT, but got I4
			int num = ~_target;
			int value = _target & num;
			int? num2 = value;
			return (int?)(object)0;
		}
	}

	public bool Expired(NetworkRunner runner)
	{
		//IL_01a3: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I4
		//IL_0193: Expected I4, but got Obj
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected I4, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected I4, but got Unknown
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
		if ((bool)runner)
		{
			if ((object)runner != null)
			{
				if (!runner.IsRunning || _target < 1)
				{
					goto IL_0177;
				}
				Simulation simulation = runner._simulation;
				if ((object)runner._simulation != null)
				{
					object obj4 = _target - simulation._tick;
					bool flag2 = (nint)obj4 < 0;
					bool flag3 = obj4 == null;
					int num = _target ^ simulation._tick;
					int num2 = _target ^ obj4;
					int num3 = num & num2;
					bool flag4 = num3 < 0;
					bool flag5 = flag2 == flag4;
					object obj5 = !flag5;
					return (byte)((obj5 | flag3) ? 1 : 0) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0177;
		IL_0177:
		return false;
	}

	public bool ExpiredOrNotRunning(NetworkRunner runner)
	{
		//IL_008d: Expected I4, but got Obj
		if (_target != 0)
		{
			if ((object)runner == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (runner.IsRunning)
			{
				return Expired(runner);
			}
		}
		return true;
	}

	public int? RemainingTicks(NetworkRunner runner)
	{
		//IL_01b9: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_0039: Expected VT, but got I4
		//IL_019f: Expected VT, but got Obj
		//IL_0089: Expected VT, but got I4
		//IL_018c: Expected VT, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected I4, but got Unknown
		//IL_017e: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = runner;
		bool flag3 = !flag2;
		int? result = (int?)(object)0;
		if (!flag3)
		{
			if ((object)runner == null)
			{
				goto IL_0191;
			}
			bool isRunning = runner.IsRunning;
			bool flag4 = !isRunning;
			result = (int?)(object)0;
			if (!flag4)
			{
				if (_target >= 1)
				{
					Simulation simulation = runner._simulation;
					if ((object)runner._simulation == null)
					{
						goto IL_0191;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v15+E4]");
					bool flag5 = (nint)0 == 0;
					object obj6 = !flag5;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int val = _target - simulation._tick;
					int value = Math.Max(0, val);
					int? num = value;
					result = (int?)(object)0;
				}
				else
				{
					result = (int?)(object)0;
				}
			}
		}
		return result;
		IL_0191:
		NullReferenceException ex = new NullReferenceException();
		return (int?)(object)ex;
	}

	public float? RemainingTime(NetworkRunner runner)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0076: Expected VT, but got I4
		//IL_0089: Expected VT, but got Obj
		//IL_0068: Expected VT, but got I4
		int? num = RemainingTicks(runner);
		object obj = (_003F?)num & 0xFF;
		if (obj != null)
		{
			int? num2 = default;
			int value = num2.Value;
			if ((object)runner != null)
			{
				float deltaTime = runner.DeltaTime;
				float value2 = deltaTime * (float)value;
				float? num3 = value2;
				return (float?)(object)0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (float?)(object)ex;
		}
		return (float?)(object)0;
	}

	public static TickTimer CreateFromSeconds(NetworkRunner runner, float delayInSeconds)
	{
		//IL_016f: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_0142: Expected VT, but got I4
		//IL_0155: Expected VT, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected VT, but got Unknown
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
		if ((bool)runner)
		{
			if ((object)runner != null)
			{
				if (!runner.IsRunning)
				{
					goto IL_0139;
				}
				Simulation simulation = runner._simulation;
				if ((object)runner._simulation != null)
				{
					float deltaTime = runner.DeltaTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj4 = 0;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					return (TickTimer)(deltaTime + simulation._tick);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (TickTimer)ex;
		}
		goto IL_0139;
		IL_0139:
		return (TickTimer)0;
	}

	public static TickTimer CreateFromTicks(NetworkRunner runner, int ticks)
	{
		//IL_00f7: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I4
		//IL_00d4: Expected VT, but got I4
		//IL_00e7: Expected VT, but got Obj
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
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
		if ((bool)runner)
		{
			if ((object)runner != null)
			{
				if (!runner.IsRunning)
				{
					goto IL_00cb;
				}
				Simulation simulation = runner._simulation;
				if ((object)runner._simulation != null)
				{
					return (TickTimer)(simulation._tick + ticks);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (TickTimer)ex;
		}
		goto IL_00cb;
		IL_00cb:
		return (TickTimer)0;
	}

	public override string ToString()
	{
		return ((int)this).ToString();
	}
}
