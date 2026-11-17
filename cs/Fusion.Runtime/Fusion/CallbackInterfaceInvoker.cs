using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

internal static class CallbackInterfaceInvoker
{
	public unsafe static void IBeforeCopyPreviousState(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5890]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5898]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}

	public unsafe static void IBeforeClientPredictionReset(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I
		//IL_0642: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_0742: Expected Obj, but got I
		//IL_074a: Expected VT, but got Obj
		//IL_076c: Expected Obj, but got I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I4
		//IL_051c: Expected Obj, but got Ref
		//IL_0486: Expected VT, but got Ref
		//IL_048e: Expected Obj, but got Ref
		//IL_0180: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I
		//IL_055a: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_0220: Expected VT, but got Obj
		//IL_0441: Expected VT, but got Ref
		//IL_0451: Expected Obj, but got Ref
		//IL_0459: Expected Obj, but got VT
		//IL_024f: Expected VT, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_06f3: Invalid comparison between I and VT
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_0493;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		object obj5 = callbackCount - 1;
		bool flag3 = obj5 == null;
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58C0]");
		object obj6 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag5 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		object obj16 = default;
		object obj15 = obj16;
		int num3 = num;
		type = typeFromHandle2;
		if (flag5)
		{
			goto IL_03a0;
		}
		object obj21 = default;
		object obj22 = default;
		while (true)
		{
			object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x40;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				object obj19 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				flag3 = obj19 == null;
				bool flag7 = !flag3;
				if (!flag7)
				{
					object obj20 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj20 != null)
					{
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj21 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj22 == null)
						{
							break;
						}
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+12E]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0350;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+98]");
						object obj24 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v12-8]");
							obj5 = 0 - handle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+12E]");
							obj14 = -1;
							obj5 = obj14 - 1;
							flag3 = obj5 == null;
							obj12 = obj24 + 16;
							flag7 = (nint)obj14 != 1;
							obj24 = obj12;
							flag8 = flag7;
							if (flag7)
							{
								continue;
							}
							goto IL_0350;
						}
						obj14 = obj24;
						object obj25 = obj23 + obj24;
						object obj26 = obj25 + 312;
						obj12 = obj24;
						flag7 = flag8;
						goto IL_070b;
					}
				}
			}
			goto IL_0651;
			IL_070b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v57+8]");
			type2 = (Type)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v565 @ X0_v57] (should have been resolved before IL gen)");
			obj16 = obj22;
			goto IL_0651;
			IL_0651:
			bool flag9 = (object)simulationBehaviour.Next == null;
			object obj27 = !flag9;
			simulationBehaviour = simulationBehaviour.Next;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj14;
			obj15 = obj16;
			num3 = num2;
			type = type2;
			if (obj27 != null)
			{
				continue;
			}
			goto IL_03a0;
			IL_0350:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num2 = 0;
			goto IL_070b;
		}
		InvalidCastException ex = new InvalidCastException();
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		SimulationBehaviourListScope simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		num3 = num2;
		object obj28 = (object)(&head);
		type = (Type)handle;
		NullReferenceException ex2 = (NullReferenceException)(object)ex;
		goto IL_04a6;
		IL_04a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag10 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj30 = default;
			object obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj32 = default;
			object obj31 = obj32 & 1;
			if (obj31 != null)
			{
				object obj33 = 0;
				object obj35 = default;
				object obj34 = (object)(&obj35);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v27+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v11+20]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v502 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj39 = obj30;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_03a0:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj28 = (object)(&head);
		goto IL_0493;
		IL_0493:
		ex2 = new NullReferenceException();
		goto IL_04a6;
	}

	public unsafe static void IAfterClientPredictionReset(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I
		//IL_0642: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_0742: Expected Obj, but got I
		//IL_074a: Expected VT, but got Obj
		//IL_076c: Expected Obj, but got I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I4
		//IL_051c: Expected Obj, but got Ref
		//IL_0486: Expected VT, but got Ref
		//IL_048e: Expected Obj, but got Ref
		//IL_0180: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I
		//IL_055a: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_0220: Expected VT, but got Obj
		//IL_0441: Expected VT, but got Ref
		//IL_0451: Expected Obj, but got Ref
		//IL_0459: Expected Obj, but got VT
		//IL_024f: Expected VT, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_071b: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_06f3: Invalid comparison between I and VT
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_0493;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		object obj5 = callbackCount - 1;
		bool flag3 = obj5 == null;
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58D0]");
		object obj6 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag5 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		object obj16 = default;
		object obj15 = obj16;
		int num3 = num;
		type = typeFromHandle2;
		if (flag5)
		{
			goto IL_03a0;
		}
		object obj21 = default;
		object obj22 = default;
		while (true)
		{
			object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x40;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				object obj19 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				flag3 = obj19 == null;
				bool flag7 = !flag3;
				if (!flag7)
				{
					object obj20 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj20 != null)
					{
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj21 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj22 == null)
						{
							break;
						}
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+12E]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0350;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+98]");
						object obj24 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v12-8]");
							obj5 = 0 - handle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v24+12E]");
							obj14 = -1;
							obj5 = obj14 - 1;
							flag3 = obj5 == null;
							obj12 = obj24 + 16;
							flag7 = (nint)obj14 != 1;
							obj24 = obj12;
							flag8 = flag7;
							if (flag7)
							{
								continue;
							}
							goto IL_0350;
						}
						obj14 = obj24;
						object obj25 = obj23 + obj24;
						object obj26 = obj25 + 312;
						obj12 = obj24;
						flag7 = flag8;
						goto IL_070b;
					}
				}
			}
			goto IL_0651;
			IL_070b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v57+8]");
			type2 = (Type)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v565 @ X0_v57] (should have been resolved before IL gen)");
			obj16 = obj22;
			goto IL_0651;
			IL_0651:
			bool flag9 = (object)simulationBehaviour.Next == null;
			object obj27 = !flag9;
			simulationBehaviour = simulationBehaviour.Next;
			obj9 = obj10;
			obj11 = obj12;
			obj13 = obj14;
			obj15 = obj16;
			num3 = num2;
			type = type2;
			if (obj27 != null)
			{
				continue;
			}
			goto IL_03a0;
			IL_0350:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num2 = 0;
			goto IL_070b;
		}
		InvalidCastException ex = new InvalidCastException();
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		SimulationBehaviourListScope simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		num3 = num2;
		object obj28 = (object)(&head);
		type = (Type)handle;
		NullReferenceException ex2 = (NullReferenceException)(object)ex;
		goto IL_04a6;
		IL_04a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag10 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj30 = default;
			object obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj32 = default;
			object obj31 = obj32 & 1;
			if (obj31 != null)
			{
				object obj33 = 0;
				object obj35 = default;
				object obj34 = (object)(&obj35);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v27+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v11+20]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v502 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj39 = obj30;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_03a0:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj28 = (object)(&head);
		goto IL_0493;
		IL_0493:
		ex2 = new NullReferenceException();
		goto IL_04a6;
	}

	public unsafe static void IBeforeUpdateRemotePrefabs(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58E0]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}

	public unsafe static void IAfterUpdateRemotePrefabs(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58F0]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}

	public unsafe static void IBeforeTick(SimulationBehaviourUpdater updater, bool resimulation)
	{
		//IL_0606: Expected Obj, but got I
		//IL_0616: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_0648: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I
		//IL_0750: Expected Obj, but got I
		//IL_0758: Expected VT, but got Obj
		//IL_077a: Expected Obj, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_05b1: Expected Obj, but got I4
		//IL_05cf: Expected I, but got Obj
		//IL_050e: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got Ref
		//IL_0544: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I
		//IL_0480: Expected VT, but got Ref
		//IL_0488: Expected Obj, but got Ref
		//IL_01c0: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0225: Expected VT, but got Obj
		//IL_043b: Expected VT, but got Ref
		//IL_044b: Expected Obj, but got Ref
		//IL_0453: Expected Obj, but got VT
		//IL_0254: Expected VT, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0364: Expected I, but got Obj
		//IL_0719: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_06f1: Invalid comparison between I and VT
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_048d;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		object obj5 = callbackCount - 1;
		bool flag3 = obj5 == null;
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5900]");
		object obj6 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58F8]");
		object obj8 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag5 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj27;
		if (!flag5)
		{
			object obj20 = default;
			object obj21 = default;
			while (true)
			{
				if (resimulation)
				{
					object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x40;
					bool flag6 = obj16 == null;
					object obj17 = !flag6;
					if (obj17 != null)
					{
						goto IL_0657;
					}
				}
				object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				flag3 = obj18 == null;
				bool flag7 = !flag3;
				if (!flag7)
				{
					object obj19 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj19 != null)
					{
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj21 == null)
						{
							break;
						}
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+12E]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0355;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+98]");
						object obj23 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v12-8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v12-8]");
							obj5 = 0 - handle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+12E]");
							obj8 = -1;
							obj5 = obj8 - 1;
							flag3 = obj5 == null;
							obj13 = obj23 + 16;
							flag7 = (nint)obj8 != 1;
							obj23 = obj13;
							flag8 = flag7;
							if (flag7)
							{
								continue;
							}
							goto IL_0355;
						}
						obj8 = obj23;
						object obj24 = obj22 + obj23;
						object obj25 = obj24 + 312;
						obj13 = obj23;
						flag7 = flag8;
						goto IL_0709;
					}
				}
				goto IL_0657;
				IL_0709:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v584 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj21;
				goto IL_0657;
				IL_0355:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = unchecked((nint)null);
				goto IL_0709;
				IL_0657:
				bool flag9 = (object)simulationBehaviour.Next == null;
				object obj26 = !flag9;
				simulationBehaviour = simulationBehaviour.Next;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj26 != null)
				{
					continue;
				}
				goto IL_0788;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj27 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_04a0;
		}
		goto IL_0788;
		IL_04a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag10 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj29 = default;
			object obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj31 = default;
			object obj30 = obj31 & 1;
			if (obj30 != null)
			{
				object obj32 = 0;
				object obj34 = default;
				object obj33 = (object)(&obj34);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v27+A0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v11+20]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v521 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj38 = obj29;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0788:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj27 = (object)(&head);
		goto IL_048d;
		IL_048d:
		ex2 = new NullReferenceException();
		goto IL_04a0;
	}

	public unsafe static void IAfterTick(SimulationBehaviourUpdater updater, bool resimulation)
	{
		//IL_0606: Expected Obj, but got I
		//IL_0616: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_0648: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I
		//IL_0750: Expected Obj, but got I
		//IL_0758: Expected VT, but got Obj
		//IL_077a: Expected Obj, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_05b1: Expected Obj, but got I4
		//IL_05cf: Expected I, but got Obj
		//IL_050e: Expected Obj, but got I4
		//IL_0516: Expected Obj, but got Ref
		//IL_0544: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I
		//IL_0480: Expected VT, but got Ref
		//IL_0488: Expected Obj, but got Ref
		//IL_01c0: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0225: Expected VT, but got Obj
		//IL_043b: Expected VT, but got Ref
		//IL_044b: Expected Obj, but got Ref
		//IL_0453: Expected Obj, but got VT
		//IL_0254: Expected VT, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0364: Expected I, but got Obj
		//IL_0719: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_06f1: Invalid comparison between I and VT
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5908]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_048d;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		object obj5 = callbackCount - 1;
		bool flag3 = obj5 == null;
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5910]");
		object obj6 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5908]");
		object obj8 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag5 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj27;
		if (!flag5)
		{
			object obj20 = default;
			object obj21 = default;
			while (true)
			{
				if (resimulation)
				{
					object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x40;
					bool flag6 = obj16 == null;
					object obj17 = !flag6;
					if (obj17 != null)
					{
						goto IL_0657;
					}
				}
				object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				flag3 = obj18 == null;
				bool flag7 = !flag3;
				if (!flag7)
				{
					object obj19 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj19 != null)
					{
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj21 == null)
						{
							break;
						}
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+12E]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0355;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+98]");
						object obj23 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v12-8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v12-8]");
							obj5 = 0 - handle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v24+12E]");
							obj8 = -1;
							obj5 = obj8 - 1;
							flag3 = obj5 == null;
							obj13 = obj23 + 16;
							flag7 = (nint)obj8 != 1;
							obj23 = obj13;
							flag8 = flag7;
							if (flag7)
							{
								continue;
							}
							goto IL_0355;
						}
						obj8 = obj23;
						object obj24 = obj22 + obj23;
						object obj25 = obj24 + 312;
						obj13 = obj23;
						flag7 = flag8;
						goto IL_0709;
					}
				}
				goto IL_0657;
				IL_0709:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v584 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj21;
				goto IL_0657;
				IL_0355:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = unchecked((nint)null);
				goto IL_0709;
				IL_0657:
				bool flag9 = (object)simulationBehaviour.Next == null;
				object obj26 = !flag9;
				simulationBehaviour = simulationBehaviour.Next;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj26 != null)
				{
					continue;
				}
				goto IL_0788;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj27 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_04a0;
		}
		goto IL_0788;
		IL_04a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag10 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj29 = default;
			object obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj31 = default;
			object obj30 = obj31 & 1;
			if (obj30 != null)
			{
				object obj32 = 0;
				object obj34 = default;
				object obj33 = (object)(&obj34);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v27+A0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v11+20]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v521 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj38 = obj29;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0788:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj27 = (object)(&head);
		goto IL_048d;
		IL_048d:
		ex2 = new NullReferenceException();
		goto IL_04a0;
	}

	public unsafe static void IBeforeAllTicks(SimulationBehaviourUpdater updater, bool resimulation, int tickCount)
	{
		//IL_0615: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I
		//IL_0787: Expected Obj, but got I
		//IL_078f: Expected VT, but got Obj
		//IL_07b1: Expected Obj, but got I4
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_05bc: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got Ref
		//IL_054f: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I
		//IL_048b: Expected VT, but got Ref
		//IL_01d8: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_023d: Expected VT, but got Obj
		//IL_0446: Expected VT, but got Ref
		//IL_045e: Expected Obj, but got VT
		//IL_026c: Expected VT, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I
		//IL_06e0: Expected Obj, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0708: Invalid comparison between I and VT
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5918]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_0498;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		object obj5 = callbackCount - 1;
		bool flag3 = obj5 == null;
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5920]");
		object obj6 = 0;
		int num2 = default;
		int num = num2;
		int num3 = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v19+E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5918]");
		object obj9 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num3, out var head);
		bool flag5 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num4 = num3;
		nint num5 = (nint)(&head);
		Type type2 = typeFromHandle2;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		object obj16 = default;
		object obj15 = obj16;
		num = num3;
		nint num6 = (nint)(&head);
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		if (!flag5)
		{
			object obj21 = default;
			object obj22 = default;
			while (true)
			{
				if (resimulation)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x40;
					bool flag6 = obj17 == null;
					object obj18 = !flag6;
					if (obj18 != null)
					{
						goto IL_0666;
					}
				}
				object obj19 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				flag3 = obj19 == null;
				bool flag7 = !flag3;
				if (!flag7)
				{
					object obj20 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj20 != null)
					{
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj21 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj22 == null)
						{
							break;
						}
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+12E]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+12E]");
						if ((nint)0 == 0)
						{
							goto IL_036d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+98]");
						object obj24 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v12-8]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v12-8]");
							obj5 = 0 - handle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+12E]");
							obj9 = -1;
							obj5 = obj9 - 1;
							flag3 = obj5 == null;
							obj14 = obj24 + 16;
							flag7 = (nint)obj9 != 1;
							obj24 = obj14;
							flag8 = flag7;
							if (flag7)
							{
								continue;
							}
							goto IL_036d;
						}
						obj9 = obj24;
						object obj25 = obj23 + obj24;
						object obj26 = obj25 + 312;
						obj14 = obj24;
						flag7 = flag8;
						goto IL_0720;
					}
				}
				goto IL_0666;
				IL_0720:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v57+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v592 @ X0_v57] (should have been resolved before IL gen)");
				obj16 = obj22;
				num4 = num2;
				type2 = (Type)resimulation;
				goto IL_0666;
				IL_036d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0720;
				IL_0666:
				bool flag9 = (object)simulationBehaviour.Next == null;
				object obj27 = !flag9;
				simulationBehaviour = simulationBehaviour.Next;
				obj11 = obj12;
				obj13 = obj14;
				obj15 = obj16;
				num = num4;
				num6 = num5;
				type = type2;
				if (obj27 != null)
				{
					continue;
				}
				goto IL_07bf;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num2 = num4;
			num6 = num5;
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_04ab;
		}
		goto IL_07bf;
		IL_04ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag10 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj29 = default;
			object obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj31 = default;
			object obj30 = obj31 & 1;
			if (obj30 != null)
			{
				object obj32 = 0;
				object obj34 = default;
				object obj33 = (object)(&obj34);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v27+A0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v13+20]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v13+20]");
				if ((nint)0 != 0)
				{
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v528 @ X8_v15+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj38 = obj29;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num2 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_07bf:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		num2 = num;
		goto IL_0498;
		IL_0498:
		ex2 = new NullReferenceException();
		goto IL_04ab;
	}

	public unsafe static void IAfterAllTicks(SimulationBehaviourUpdater updater, bool resimulation, int tickCount)
	{
		//IL_0615: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I
		//IL_0787: Expected Obj, but got I
		//IL_078f: Expected VT, but got Obj
		//IL_07b1: Expected Obj, but got I4
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_05bc: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got Ref
		//IL_054f: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I
		//IL_048b: Expected VT, but got Ref
		//IL_01d8: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_023d: Expected VT, but got Obj
		//IL_0446: Expected VT, but got Ref
		//IL_045e: Expected Obj, but got VT
		//IL_026c: Expected VT, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I
		//IL_06e0: Expected Obj, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0708: Invalid comparison between I and VT
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5928]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_0498;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		object obj5 = callbackCount - 1;
		bool flag3 = obj5 == null;
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5930]");
		object obj6 = 0;
		int num2 = default;
		int num = num2;
		int num3 = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v19+E8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5928]");
		object obj9 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num3, out var head);
		bool flag5 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num4 = num3;
		nint num5 = (nint)(&head);
		Type type2 = typeFromHandle2;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		object obj16 = default;
		object obj15 = obj16;
		num = num3;
		nint num6 = (nint)(&head);
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		if (!flag5)
		{
			object obj21 = default;
			object obj22 = default;
			while (true)
			{
				if (resimulation)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x40;
					bool flag6 = obj17 == null;
					object obj18 = !flag6;
					if (obj18 != null)
					{
						goto IL_0666;
					}
				}
				object obj19 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				flag3 = obj19 == null;
				bool flag7 = !flag3;
				if (!flag7)
				{
					object obj20 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj20 != null)
					{
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj21 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj22 == null)
						{
							break;
						}
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+12E]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+12E]");
						if ((nint)0 == 0)
						{
							goto IL_036d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+98]");
						object obj24 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v12-8]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v12-8]");
							obj5 = 0 - handle;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v28+12E]");
							obj9 = -1;
							obj5 = obj9 - 1;
							flag3 = obj5 == null;
							obj14 = obj24 + 16;
							flag7 = (nint)obj9 != 1;
							obj24 = obj14;
							flag8 = flag7;
							if (flag7)
							{
								continue;
							}
							goto IL_036d;
						}
						obj9 = obj24;
						object obj25 = obj23 + obj24;
						object obj26 = obj25 + 312;
						obj14 = obj24;
						flag7 = flag8;
						goto IL_0720;
					}
				}
				goto IL_0666;
				IL_0720:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v57+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v592 @ X0_v57] (should have been resolved before IL gen)");
				obj16 = obj22;
				num4 = num2;
				type2 = (Type)resimulation;
				goto IL_0666;
				IL_036d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0720;
				IL_0666:
				bool flag9 = (object)simulationBehaviour.Next == null;
				object obj27 = !flag9;
				simulationBehaviour = simulationBehaviour.Next;
				obj11 = obj12;
				obj13 = obj14;
				obj15 = obj16;
				num = num4;
				num6 = num5;
				type = type2;
				if (obj27 != null)
				{
					continue;
				}
				goto IL_07bf;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num2 = num4;
			num6 = num5;
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_04ab;
		}
		goto IL_07bf;
		IL_04ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag10 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj29 = default;
			object obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj31 = default;
			object obj30 = obj31 & 1;
			if (obj30 != null)
			{
				object obj32 = 0;
				object obj34 = default;
				object obj33 = (object)(&obj34);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v27+A0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v13+20]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v13+20]");
				if ((nint)0 != 0)
				{
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v528 @ X8_v15+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj38 = obj29;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num2 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_07bf:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		num2 = num;
		goto IL_0498;
		IL_0498:
		ex2 = new NullReferenceException();
		goto IL_04ab;
	}

	public unsafe static void IBeforeSimulation(SimulationBehaviourUpdater updater, int forwardTickCount)
	{
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I
		//IL_066d: Expected VT, but got Obj
		//IL_068f: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_03a5: Expected VT, but got Ref
		//IL_03ad: Expected Obj, but got Ref
		//IL_059b: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_01a8: Expected VT, but got Obj
		//IL_0360: Expected VT, but got Ref
		//IL_0370: Expected Obj, but got Ref
		//IL_0378: Expected Obj, but got VT
		//IL_01d7: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I
		//IL_05ff: Invalid comparison between I and VT
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5938]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03b2;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5940]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5938]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj25;
		if (!flag4)
		{
			object obj18 = default;
			object obj19 = default;
			while (true)
			{
				object obj15 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj17 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj18 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+98]");
						object obj21 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
							obj7 = -1;
							obj12 = obj21 + 16;
							bool flag6 = (nint)obj7 != 1;
							obj21 = obj12;
							if (flag6)
							{
								continue;
							}
							goto IL_02a6;
						}
						obj7 = obj21;
						object obj22 = obj20 + obj21;
						object obj23 = obj22 + 312;
						obj12 = obj21;
						goto IL_0616;
					}
				}
				goto IL_057c;
				IL_057c:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj24 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj9 = obj10;
				obj11 = obj12;
				obj13 = obj14;
				num3 = num2;
				type = type2;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_069d;
				IL_02a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0616;
				IL_0616:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v57+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v57] (should have been resolved before IL gen)");
				obj14 = obj19;
				type2 = (Type)forwardTickCount;
				goto IL_057c;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj25 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03c5;
		}
		goto IL_069d;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj29 = default;
			object obj28 = obj29 & 1;
			if (obj28 != null)
			{
				object obj30 = 0;
				object obj32 = default;
				object obj31 = (object)(&obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v27+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj36 = obj27;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_069d:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj25 = (object)(&head);
		goto IL_03b2;
		IL_03b2:
		ex2 = new NullReferenceException();
		goto IL_03c5;
	}

	public unsafe static void IPlayerJoined(SimulationBehaviourUpdater updater, PlayerRef player)
	{
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I
		//IL_0677: Expected VT, but got Obj
		//IL_0699: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_03a5: Expected VT, but got Ref
		//IL_03ad: Expected Obj, but got Ref
		//IL_059b: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_01a8: Expected VT, but got Obj
		//IL_0360: Expected VT, but got Ref
		//IL_0370: Expected Obj, but got Ref
		//IL_0378: Expected Obj, but got VT
		//IL_01d7: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I
		//IL_05ff: Invalid comparison between I and VT
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5948]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03b2;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5950]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5948]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj25;
		if (!flag4)
		{
			object obj18 = default;
			object obj19 = default;
			while (true)
			{
				object obj15 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj17 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj18 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+98]");
						object obj21 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
							obj7 = -1;
							obj12 = obj21 + 16;
							bool flag6 = (nint)obj7 != 1;
							obj21 = obj12;
							if (flag6)
							{
								continue;
							}
							goto IL_02a6;
						}
						obj7 = obj21;
						object obj22 = obj20 + obj21;
						object obj23 = obj22 + 312;
						obj12 = obj21;
						goto IL_0616;
					}
				}
				goto IL_057c;
				IL_057c:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj24 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj9 = obj10;
				obj11 = obj12;
				obj13 = obj14;
				num3 = num2;
				type = type2;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_06a7;
				IL_02a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0616;
				IL_0616:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v57+8]");
				num2 = 0;
				type2 = (Type)(player & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v57] (should have been resolved before IL gen)");
				obj14 = obj19;
				goto IL_057c;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj25 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03c5;
		}
		goto IL_06a7;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj29 = default;
			object obj28 = obj29 & 1;
			if (obj28 != null)
			{
				object obj30 = 0;
				object obj32 = default;
				object obj31 = (object)(&obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v27+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj36 = obj27;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06a7:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj25 = (object)(&head);
		goto IL_03b2;
		IL_03b2:
		ex2 = new NullReferenceException();
		goto IL_03c5;
	}

	public unsafe static void IPlayerLeft(SimulationBehaviourUpdater updater, PlayerRef player)
	{
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I
		//IL_0677: Expected VT, but got Obj
		//IL_0699: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_03a5: Expected VT, but got Ref
		//IL_03ad: Expected Obj, but got Ref
		//IL_059b: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_01a8: Expected VT, but got Obj
		//IL_0360: Expected VT, but got Ref
		//IL_0370: Expected Obj, but got Ref
		//IL_0378: Expected Obj, but got VT
		//IL_01d7: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I
		//IL_05ff: Invalid comparison between I and VT
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5958]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03b2;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5960]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5958]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj25;
		if (!flag4)
		{
			object obj18 = default;
			object obj19 = default;
			while (true)
			{
				object obj15 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj17 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj18 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+98]");
						object obj21 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
							obj7 = -1;
							obj12 = obj21 + 16;
							bool flag6 = (nint)obj7 != 1;
							obj21 = obj12;
							if (flag6)
							{
								continue;
							}
							goto IL_02a6;
						}
						obj7 = obj21;
						object obj22 = obj20 + obj21;
						object obj23 = obj22 + 312;
						obj12 = obj21;
						goto IL_0616;
					}
				}
				goto IL_057c;
				IL_057c:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj24 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj9 = obj10;
				obj11 = obj12;
				obj13 = obj14;
				num3 = num2;
				type = type2;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_06a7;
				IL_02a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0616;
				IL_0616:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v57+8]");
				num2 = 0;
				type2 = (Type)(player & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v57] (should have been resolved before IL gen)");
				obj14 = obj19;
				goto IL_057c;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj25 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03c5;
		}
		goto IL_06a7;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj29 = default;
			object obj28 = obj29 & 1;
			if (obj28 != null)
			{
				object obj30 = 0;
				object obj32 = default;
				object obj31 = (object)(&obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v27+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj36 = obj27;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06a7:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj25 = (object)(&head);
		goto IL_03b2;
		IL_03b2:
		ex2 = new NullReferenceException();
		goto IL_03c5;
	}

	public unsafe static void IBeforeHitboxRegistration(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5968]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5970]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}

	public unsafe static void IAfterUpdate(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5978]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5980]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}

	public unsafe static void IBeforeUpdate(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5988]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5990]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}

	public unsafe static void IAfterRender(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0530: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I
		//IL_0562: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I
		//IL_0652: Expected VT, but got Obj
		//IL_0674: Expected Obj, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_04d7: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I
		//IL_039e: Expected VT, but got Ref
		//IL_03ae: Expected Obj, but got Ref
		//IL_0590: Expected Obj, but got I4
		//IL_0190: Expected VT, but got Obj
		//IL_0361: Expected VT, but got Ref
		//IL_0369: Expected Obj, but got Ref
		//IL_0371: Expected Obj, but got VT
		//IL_01bf: Expected VT, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I
		//IL_05fc: Invalid comparison between I and VT
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5998]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03b3;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59A0]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj25;
		if (!flag4)
		{
			object obj18 = default;
			object obj19 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 != null)
				{
					goto IL_0571;
				}
				handle = (RuntimeTypeHandle)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (obj18 == null)
				{
					break;
				}
				handle = (RuntimeTypeHandle)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				if (obj19 == null)
				{
					break;
				}
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v23+12E]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_028e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v23+98]");
				object obj21 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X10_v12-8]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X10_v12-8]");
					if ((object)0 == (object)handle)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v23+12E]");
					obj13 = -1;
					obj11 = obj21 + 16;
					bool flag6 = (nint)obj13 != 1;
					obj21 = obj11;
					if (flag6)
					{
						continue;
					}
					goto IL_028e;
				}
				obj13 = obj21;
				object obj22 = obj20 + obj21;
				object obj23 = obj22 + 312;
				obj11 = obj21;
				goto IL_0613;
				IL_028e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_0613;
				IL_0613:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v573 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj19;
				goto IL_0571;
				IL_0571:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj24 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_0682;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			obj25 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03c6;
		}
		goto IL_0682;
		IL_03c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj29 = default;
			object obj28 = obj29 & 1;
			if (obj28 != null)
			{
				object obj30 = 0;
				object obj32 = default;
				object obj31 = (object)(&obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v27+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v11+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj36 = obj27;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num2 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0682:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		num2 = num3;
		obj25 = (object)(&head);
		goto IL_03b3;
		IL_03b3:
		ex2 = new NullReferenceException();
		goto IL_03c6;
	}

	public unsafe static void ISceneLoadDone(SimulationBehaviourUpdater updater, [In] ref SceneLoadDoneArgs sceneLoadDoneArgs)
	{
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I
		//IL_066d: Expected VT, but got Obj
		//IL_068f: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_03a5: Expected VT, but got Ref
		//IL_03ad: Expected Obj, but got Ref
		//IL_059b: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_01a8: Expected VT, but got Obj
		//IL_0360: Expected VT, but got Ref
		//IL_0370: Expected Obj, but got Ref
		//IL_0378: Expected Obj, but got VT
		//IL_01d7: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0640: Expected Obj, but got Ref
		//IL_0251: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I
		//IL_05ff: Invalid comparison between I and VT
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03b2;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59B0]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59A8]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj25;
		if (!flag4)
		{
			object obj18 = default;
			object obj19 = default;
			while (true)
			{
				object obj15 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj17 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj18 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+98]");
						object obj21 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
							obj7 = -1;
							obj12 = obj21 + 16;
							bool flag6 = (nint)obj7 != 1;
							obj21 = obj12;
							if (flag6)
							{
								continue;
							}
							goto IL_02a6;
						}
						obj7 = obj21;
						object obj22 = obj20 + obj21;
						object obj23 = obj22 + 312;
						obj12 = obj21;
						goto IL_0616;
					}
				}
				goto IL_057c;
				IL_057c:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj24 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj9 = obj10;
				obj11 = obj12;
				obj13 = obj14;
				num3 = num2;
				type = type2;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_069d;
				IL_02a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0616;
				IL_0616:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v57+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v57] (should have been resolved before IL gen)");
				obj14 = obj19;
				type2 = (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref sceneLoadDoneArgs);
				goto IL_057c;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj25 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03c5;
		}
		goto IL_069d;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj29 = default;
			object obj28 = obj29 & 1;
			if (obj28 != null)
			{
				object obj30 = 0;
				object obj32 = default;
				object obj31 = (object)(&obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v27+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj36 = obj27;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_069d:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj25 = (object)(&head);
		goto IL_03b2;
		IL_03b2:
		ex2 = new NullReferenceException();
		goto IL_03c5;
	}

	public unsafe static void ISceneLoadStart(SimulationBehaviourUpdater updater, SceneRef sceneRef)
	{
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_054b: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_001d: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I
		//IL_0677: Expected VT, but got Obj
		//IL_0699: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_0148: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_03a5: Expected VT, but got Ref
		//IL_03ad: Expected Obj, but got Ref
		//IL_059b: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_01a8: Expected VT, but got Obj
		//IL_0360: Expected VT, but got Ref
		//IL_0370: Expected Obj, but got Ref
		//IL_0378: Expected Obj, but got VT
		//IL_01d7: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_05ee: Expected Obj, but got I
		//IL_05ff: Invalid comparison between I and VT
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_026c: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03b2;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59C0]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X27_v2+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59B8]");
		object obj7 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		nint num2 = num;
		Type type2 = typeFromHandle2;
		object obj10 = default;
		object obj9 = obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		nint num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj25;
		if (!flag4)
		{
			object obj18 = default;
			object obj19 = default;
			while (true)
			{
				object obj15 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					object obj17 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj17 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj18 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+98]");
						object obj21 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v24+12E]");
							obj7 = -1;
							obj12 = obj21 + 16;
							bool flag6 = (nint)obj7 != 1;
							obj21 = obj12;
							if (flag6)
							{
								continue;
							}
							goto IL_02a6;
						}
						obj7 = obj21;
						object obj22 = obj20 + obj21;
						object obj23 = obj22 + 312;
						obj12 = obj21;
						goto IL_0616;
					}
				}
				goto IL_057c;
				IL_057c:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj24 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj9 = obj10;
				obj11 = obj12;
				obj13 = obj14;
				num3 = num2;
				type = type2;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_06a7;
				IL_02a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0616;
				IL_0616:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v57+8]");
				num2 = 0;
				type2 = (Type)(sceneRef & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v57] (should have been resolved before IL gen)");
				obj14 = obj19;
				goto IL_057c;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj25 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03c5;
		}
		goto IL_06a7;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj27 = default;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj29 = default;
			object obj28 = obj29 & 1;
			if (obj28 != null)
			{
				object obj30 = 0;
				object obj32 = default;
				object obj31 = (object)(&obj32);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v27+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj36 = obj27;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = unchecked((nint)null);
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06a7:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj25 = (object)(&head);
		goto IL_03b2;
		IL_03b2:
		ex2 = new NullReferenceException();
		goto IL_03c5;
	}

	public unsafe static void IAfterHostMigration(SimulationBehaviourUpdater updater)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0672: Expected Obj, but got I
		//IL_067a: Expected VT, but got Obj
		//IL_069c: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_03ce: Expected VT, but got Ref
		//IL_03d6: Expected Obj, but got Ref
		//IL_05b8: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01c0: Expected VT, but got Obj
		//IL_0389: Expected VT, but got Ref
		//IL_0399: Expected Obj, but got Ref
		//IL_03a1: Expected Obj, but got VT
		//IL_01ef: Expected VT, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0613: Expected Obj, but got I
		//IL_0624: Invalid comparison between I and VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		bool flag2 = updater == null;
		Type type = typeFromHandle;
		if (flag2)
		{
			goto IL_03db;
		}
		int callbackCount = updater.GetCallbackCount(typeFromHandle);
		if (callbackCount < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59D0]");
		object obj5 = 0;
		int num = 0;
		type = typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v2+E8]");
		object obj6 = 0;
		RuntimeTypeHandle handle = (RuntimeTypeHandle)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
		SimulationBehaviourListScope callbackHead = updater.GetCallbackHead(typeFromHandle2, num, out var head);
		bool flag4 = (object)head == null;
		SimulationBehaviour simulationBehaviour = head;
		int num2 = num;
		Type type2 = typeFromHandle2;
		object obj9 = default;
		object obj8 = obj9;
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		int num3 = num;
		type = typeFromHandle2;
		SimulationBehaviourListScope simulationBehaviourListScope2 = default;
		NullReferenceException ex2;
		SimulationBehaviourListScope simulationBehaviourListScope;
		object obj26;
		if (!flag4)
		{
			object obj19 = default;
			object obj20 = default;
			while (true)
			{
				object obj16 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					object obj18 = simulationBehaviour.Flags & (SimulationBehaviourRuntimeFlags)3;
					if (obj18 != null)
					{
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj19 == null)
						{
							break;
						}
						handle = (RuntimeTypeHandle)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						if (obj20 == null)
						{
							break;
						}
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02be;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+98]");
						object obj22 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v12-8]");
							if ((object)0 == (object)handle)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v24+12E]");
							obj13 = -1;
							obj11 = obj22 + 16;
							bool flag6 = (nint)obj13 != 1;
							obj22 = obj11;
							if (flag6)
							{
								continue;
							}
							goto IL_02be;
						}
						obj13 = obj22;
						object obj23 = obj21 + obj22;
						object obj24 = obj23 + 312;
						obj11 = obj22;
						goto IL_063b;
					}
				}
				goto IL_0599;
				IL_0599:
				bool flag7 = (object)simulationBehaviour.Next == null;
				object obj25 = !flag7;
				simulationBehaviour = simulationBehaviour.Next;
				obj8 = obj9;
				obj10 = obj11;
				obj12 = obj13;
				obj14 = obj15;
				num3 = num2;
				type = type2;
				if (obj25 != null)
				{
					continue;
				}
				goto IL_06aa;
				IL_02be:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				num2 = 0;
				goto IL_063b;
				IL_063b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v57+8]");
				type2 = (Type)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v57] (should have been resolved before IL gen)");
				obj15 = obj20;
				goto IL_0599;
			}
			InvalidCastException ex = new InvalidCastException();
			simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
			num3 = num2;
			obj26 = (object)(&head);
			type = (Type)handle;
			ex2 = (NullReferenceException)(object)ex;
			goto IL_03ee;
		}
		goto IL_06aa;
		IL_03ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3A84");
		bool flag8 = (nint)type != 1;
		NullReferenceException ex3 = ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj28 = default;
			object obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj30 = default;
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				object obj31 = 0;
				object obj33 = default;
				object obj32 = (object)(&obj33);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v27+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X8_v13+1D8] (should have been resolved before IL gen)");
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj37 = obj28;
			type = (Type)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num3 = 0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_06aa:
		simulationBehaviourListScope2.Dispose();
		OutOfMemoryException ex5 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		simulationBehaviourListScope = (SimulationBehaviourListScope)(&simulationBehaviourListScope2);
		obj26 = (object)(&head);
		goto IL_03db;
		IL_03db:
		ex2 = new NullReferenceException();
		goto IL_03ee;
	}
}
