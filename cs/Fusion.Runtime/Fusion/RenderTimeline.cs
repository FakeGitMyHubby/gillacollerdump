using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

[StructLayout((LayoutKind)0, Size = 1)]
public struct RenderTimeline
{
	public unsafe static void GetRenderBuffers(NetworkBehaviour behaviour, out NetworkBehaviourBuffer from, out NetworkBehaviourBuffer to, out float alpha)
	{
		//IL_007c: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I4
		//IL_07db: Expected Obj, but got I
		//IL_07e3: Expected I, but got Obj
		//IL_0814: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_076e: Expected I, but got Obj
		//IL_0797: Expected Obj, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0392: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_021e: Expected VT, but got I
		//IL_0425: Expected Ref, but got F4
		//IL_02e1: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I8
		//IL_030d: Expected Obj, but got I
		//IL_0265: Expected VT, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_0457: Expected Ref, but got VT
		//IL_0460: Expected F8, but got I4
		//IL_04d8: Expected I, but got Obj
		//IL_04e8: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I4
		//IL_082a: Expected Ref, but got F8
		//IL_0646: Expected Ref, but got VT
		//IL_0889: Invalid comparison between Obj and F8
		//IL_0533: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06af: Expected VT, but got I
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_06ee: Expected VT, but got I
		NetworkObject networkObject = ((SimulationBehaviour)behaviour)._object;
		NetworkRunner runner = networkObject._runner;
		NetworkObjectMeta meta = networkObject.Meta;
		Simulation simulation = runner._simulation;
		RenderTimeframe renderTimeframe = meta.Instance.RenderTimeframe;
		NetworkObject instance = meta.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
		object obj = 0;
		bool flag = (object)runner._simulation == null;
		ref NetworkBehaviourBuffer reference = ref to;
		if (!flag)
		{
			object obj2 = obj;
			nint num = (nint)simulation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X9_v30 (Il2CppClass<Fusion.Simulation>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v41+130]");
			bool flag2 = num2 < 0;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			reference = ref to;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X9_v30 (Il2CppClass<Fusion.Simulation>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v41+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v32-8]");
				bool flag3 = 0 != (nint)obj2;
				reference = ref to;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313AF88");
					reference = ref *(NetworkBehaviourBuffer*)null;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
		object obj6 = 0;
		NetworkObjectHeaderSnapshot snapshot = null;
		ref float reference2 = ref alpha;
		NetworkObjectHeaderSnapshot snapshot2 = null;
		RenderTimeframe renderTimeframe2 = renderTimeframe;
		object obj13 = default;
		object obj14 = default;
		object obj28 = default;
		object obj30 = default;
		object obj31 = default;
		object obj32 = default;
		while (true)
		{
			object obj11;
			ref NetworkBehaviourBuffer reference4;
			ref NetworkBehaviourBuffer reference3;
			if (renderTimeframe2 != 0)
			{
				object obj7 = obj6;
				nint num4 = (nint)simulation;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X9_v25 (Il2CppClass<Fusion.Simulation>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v36+130]");
				bool flag4 = num5 < 0;
				object obj8 = !flag4;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X9_v25 (Il2CppClass<Fusion.Simulation>)+B0]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v36+130]");
					object obj10 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v28-8]");
					if (0 == (nint)obj7)
					{
						goto IL_07cb;
					}
				}
				if (instance._renderSource != (RenderSource)3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+98]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+90]");
					bool flag5 = meta.TryFindSnapshot((Tick)0, out snapshot2);
					bool flag6 = !flag5;
					reference2 = ref *(float*)null;
					reference = ref *(NetworkBehaviourBuffer*)(&snapshot2);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+94]");
						bool flag7 = meta.TryFindSnapshot((Tick)0, out snapshot);
						bool flag8 = !flag7;
						object obj12 = !flag8;
						reference2 = ref *(float*)null;
						reference = ref *(NetworkBehaviourBuffer*)(&snapshot);
						if (obj12 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+90]");
							_ = 0;
							reference3 = ref *(NetworkBehaviourBuffer*)obj13;
							_ = behaviour.WordCount;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+94]");
							_ = 0;
							goto IL_08a1;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+50]");
				bool flag9 = (nint)0 == 0;
				renderTimeframe2 = (RenderTimeframe)0;
				if (flag9)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+50]");
				NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef = new NetworkObjectHeaderSnapshotRef((NetworkObjectHeaderSnapshot)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
				reference4 = ref *(NetworkBehaviourBuffer*)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+50]");
				networkObjectHeaderSnapshotRef = new NetworkObjectHeaderSnapshotRef((NetworkObjectHeaderSnapshot)0);
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v37+20]");
				_ = 0;
				_ = behaviour.WordCount;
				goto IL_0639;
			}
			goto IL_07cb;
			IL_07cb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
			object obj16 = 0;
			nint num7 = (nint)simulation;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X9_v13 (Il2CppClass<Fusion.Simulation>)+130]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v19+130]");
			bool flag10 = num8 < 0;
			object obj18 = !flag10;
			if (obj18 != null && instance._renderSource != (RenderSource)3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X9_v13 (Il2CppClass<Fusion.Simulation>)+B0]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v19+130]");
				object obj19 = num9 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v15-8]");
				if (0 == (nint)obj17)
				{
					ITimeProvider time = simulation._time;
					nint num10 = (nint)time;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7508]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v22 (Il2CppClass<Fusion.ITimeProvider>)+12E]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v22 (Il2CppClass<Fusion.ITimeProvider>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0574;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v22 (Il2CppClass<Fusion.ITimeProvider>)+98]");
					object obj22 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v17-8]");
						if (0 == (nint)obj20)
						{
							break;
						}
						obj21--;
						obj22 += 16;
						if ((nint)obj21 != 1)
						{
							continue;
						}
						goto IL_0574;
					}
					object obj23 = obj22 + 9;
					object obj24 = num10 + obj23;
					object obj25 = obj24 + 312;
					goto IL_0865;
				}
			}
			goto IL_0341;
			IL_0341:
			reference4 = ref *(NetworkBehaviourBuffer*)behaviour.Ptr;
			_ = simulation._tick;
			_ = behaviour.WordCount;
			object obj26 = meta + 48;
			NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = (NetworkObjectHeaderSnapshot)obj26;
			bool flag11 = obj26 == null;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot2 = (meta._previous = meta.GetSnapshot(true));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				networkObjectHeaderSnapshot = networkObjectHeaderSnapshot2;
			}
			NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef2 = networkObjectHeaderSnapshot;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
			reference3 = ref *(NetworkBehaviourBuffer*)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313B1F8");
			_ = behaviour.WordCount;
			ref float reference5 = ref *(float*)simulation._localAlpha;
			if (instance._renderSource == (RenderSource)1)
			{
				goto IL_044a;
			}
			object obj29 = (long)instance._renderSource & 0xFFFFFFFEL;
			if ((nint)obj29 == 2)
			{
				goto IL_0639;
			}
			break;
			IL_0865:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v779 @ X0_v16] (should have been resolved before IL gen)");
			double latestServerTime = runner._simulation.LatestServerTime;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)latestServerTime))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+80]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+78]");
				bool flag12 = meta.TryFindSnapshot((Tick)0, out var _);
				bool flag13 = !flag12;
				reference2 = ref *(float*)null;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+7C]");
					bool flag14 = meta.TryFindSnapshot((Tick)0, out var _);
					bool flag15 = !flag14;
					reference2 = ref *(float*)null;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+78]");
						_ = 0;
						reference3 = ref *(NetworkBehaviourBuffer*)obj31;
						_ = behaviour.WordCount;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X24_v2 (Fusion.NetworkObjectMeta)+7C]");
						_ = 0;
						goto IL_08a1;
					}
				}
			}
			goto IL_0341;
			IL_044a:
			reference4 = ref *(NetworkBehaviourBuffer*)from;
			double num11 = 0.0;
			goto IL_0822;
			IL_08a1:
			bool flag16 = instance._renderSource == (RenderSource)2;
			reference4 = ref *(NetworkBehaviourBuffer*)obj32;
			_ = behaviour.WordCount;
			ref float reference6 = ref *(float*)obj11;
			if (!flag16)
			{
				if (instance._renderSource != (RenderSource)1)
				{
					break;
				}
				goto IL_044a;
			}
			goto IL_0639;
			IL_0822:
			reference6 = ref *(float*)num11;
			break;
			IL_0639:
			reference3 = ref *(NetworkBehaviourBuffer*)to;
			num11 = 1.0;
			goto IL_0822;
			IL_0574:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			reference = ref *(NetworkBehaviourBuffer*)9;
			goto IL_0865;
		}
	}
}
