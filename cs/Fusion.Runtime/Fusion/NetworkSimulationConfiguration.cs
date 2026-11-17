using System;
using Cpp2ILInjected;
using Fusion.Sockets;

namespace Fusion;

[Serializable]
public class NetworkSimulationConfiguration : Action<GillaPurchases.Result>
{
	public bool Enabled;

	public NetConnection.WaveShape DelayShape = (NetConnection.WaveShape)0;

	public double DelayMin;

	public double DelayMax;

	public double DelayPeriod = 0.0;

	public double DelayThreshold = 0.0;

	public double AdditionalJitter;

	public NetConnection.WaveShape LossChanceShape;

	public double LossChanceMin;

	public double LossChanceMax;

	public double LossChanceThreshold;

	public double LossChancePeriod;

	public double AdditionalLoss;

	public new NetworkSimulationConfiguration Clone()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		NetworkSimulationConfiguration networkSimulationConfiguration = (NetworkSimulationConfiguration)MemberwiseClone();
		if ((object)networkSimulationConfiguration != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9988]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)networkSimulationConfiguration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6 (Il2CppClass<Fusion.NetworkSimulationConfiguration>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6 (Il2CppClass<Fusion.NetworkSimulationConfiguration>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9-8]");
				if (0 == (nint)obj2)
				{
					goto IL_00a9;
				}
			}
			return (NetworkSimulationConfiguration)(object)new InvalidCastException();
		}
		goto IL_00a9;
		IL_00a9:
		return networkSimulationConfiguration;
	}

	public unsafe NetConfigSimulation Create()
	{
		//IL_05c8: Expected native int or pointer, but got VT
		//IL_05e4: Expected native int or pointer, but got VT
		//IL_05fb: Expected native int or pointer, but got VT
		//IL_0621: Expected native int or pointer, but got VT
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0018: Expected F8, but got Obj
		//IL_008f: Invalid comparison between F8 and I4
		//IL_009e: Invalid comparison between F8 and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got F8
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0058: Expected F8, but got I4
		//IL_0061: Expected F8, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_0152: Expected F8, but got I
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_046d: Expected VT, but got I
		//IL_047d: Expected Obj, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02f7: Expected Obj, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_04fc: Expected Obj, but got I4
		//IL_022a: Expected F8, but got I4
		//IL_0233: Expected F8, but got I4
		//IL_023c: Expected F8, but got I4
		//IL_01b6: Expected F8, but got I
		//IL_01e3: Expected F8, but got I
		//IL_056c: Expected Obj, but got I4
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I
		//IL_054e: Expected VT, but got I4
		//IL_0205: Expected VT, but got I4
		//IL_05b2: Expected Obj, but got I4
		//IL_038f: Expected F8, but got I
		//IL_03bc: Expected F8, but got I
		//IL_03d6: Expected VT, but got I4
		NetConfigSimulation result = NetConfigSimulation.Defaults;
		double num2;
		double num3;
		if (~(Enabled ? 1u : 0u) == 0)
		{
			object obj = this + 24;
			double num = (double)obj;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+8]");
				bool flag = (nint)0 == 0;
				num2 = 0.0;
				num3 = 0.0;
				if (flag)
				{
					goto IL_0452;
				}
			}
			double num4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+8]");
			double num5 = num4 - 0.0;
			bool flag2 = num5 < 0.0;
			bool flag3 = num5 == 0.0;
			double num6 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+8]");
			object obj2 = num6 ^ 0;
			object obj3 = num ^ num5;
			object obj4 = obj2 & obj3;
			bool flag4 = (nint)obj4 < 0;
			object obj5 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			object obj7 = obj6;
			bool flag5 = flag2 == flag4;
			object obj8 = !flag3;
			object obj9 = flag5 & obj8;
			object obj10 = ~obj9;
			double num7;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+8]");
				num7 = 0.0;
			}
			else
			{
				num7 = num;
			}
			bool flag6 = flag2 == flag4;
			object obj11 = !flag3;
			object obj12 = flag6 & obj11;
			object obj13 = ~obj12;
			object obj14 = ((obj13 != null) ? obj5 : obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double val = num7 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C130]");
			double num8 = Math.Max(0.0, val);
			double val2 = (double)obj14 * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C130]");
			num = Math.Max(0.0, val2);
			num2 = num;
			num3 = num8;
			result = (NetConfigSimulation)0;
			goto IL_0452;
		}
		double num10 = default;
		double num9 = num10;
		double num12 = default;
		double num11 = num12;
		object obj17 = default;
		object obj16 = obj17;
		double num14 = default;
		double num13 = num14;
		NetConfigSimulationOscillator netConfigSimulationOscillator = default;
		NetConfigSimulationOscillator delayOscillator = netConfigSimulationOscillator;
		double num15 = default;
		num2 = num15;
		double num16 = default;
		num3 = num16;
		double num18 = default;
		double num17 = num18;
		double num20 = default;
		double num19 = num20;
		NetConfigSimulationOscillator netConfigSimulationOscillator2 = default;
		NetConfigSimulationOscillator lossOscillator = netConfigSimulationOscillator2;
		goto IL_05c0;
		IL_05c0:
		NetConfigSimulation netConfigSimulation = default;
		((NetConfigSimulation*)(nint)netConfigSimulation)->DelayOscillator = delayOscillator;
		short* lossNotifySequences = default;
		((NetConfigSimulation*)(nint)netConfigSimulation)->LossNotifySequences = lossNotifySequences;
		((NetConfigSimulation*)(nint)netConfigSimulation)->LossOscillator = lossOscillator;
		double duplicateChance = default;
		((NetConfigSimulation*)(nint)netConfigSimulation)->DuplicateChance = duplicateChance;
		return result;
		IL_050a:
		num11 = LossChanceThreshold;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9-10]");
		num17 = 0.0 * 0.5;
		num9 = AdditionalLoss;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		lossOscillator = (NetConfigSimulationOscillator)LossChanceShape;
		goto IL_05c0;
		IL_0452:
		object obj18 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9-34]");
		delayOscillator = (NetConfigSimulationOscillator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9-20]");
		obj16 = 0;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9+8]");
			bool flag8 = (nint)0 == 0;
			double num = 0.0;
			num13 = 0.0;
			num19 = 0.0;
			if (flag8)
			{
				goto IL_050a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9+8]");
		object obj19 = obj18 - 0;
		bool flag9 = (nint)obj19 < 0;
		bool flag10 = obj19 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9+8]");
		object obj20 = obj18 ^ 0;
		object obj21 = obj18 ^ obj19;
		object obj22 = obj20 & obj21;
		bool flag11 = (nint)obj22 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj23 = 0;
		object obj24 = this + 80;
		object obj25 = obj23;
		bool flag12 = flag9 == flag11;
		object obj26 = !flag10;
		object obj27 = flag12 & obj26;
		object obj28 = ~obj27;
		object obj29;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v9+8]");
			obj29 = 0;
		}
		else
		{
			obj29 = obj18;
		}
		bool flag13 = flag9 == flag11;
		object obj30 = !flag10;
		object obj31 = flag13 & obj30;
		object obj32 = ~obj31;
		object obj33 = ((obj32 != null) ? obj24 : obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v7+E4]");
		bool flag14 = (nint)0 == 0;
		object obj34 = !flag14;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double val3 = (double)obj29 * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C130]");
		double num21 = Math.Max(0.0, val3);
		double val4 = (double)obj33 * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C130]");
		num19 = Math.Max(0.0, val4);
		num13 = num21;
		result = (NetConfigSimulation)0;
		goto IL_050a;
	}

	public void SanityCheck()
	{
	}

	public NetworkSimulationConfiguration()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		LossChanceShape = (NetConnection.WaveShape)0;
		LossChancePeriod = 0.0;
		AdditionalLoss = 0.0;
		LossChanceThreshold = 0.0;
		double num = default;
		DelayMin = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		AdditionalJitter = -0.10000000000000002;
		LossChanceMin = num;
		base._002Ector();
	}
}
