using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public class NetworkProjectConfigAsset : FusionGlobalScriptableObject<NetworkProjectConfigAsset>
{
	public enum InvokeRenderModes
	{
		// error: enumerator has no value
		NotInBatchMode,
		// error: enumerator has no value
		Always,
		// error: enumerator has no value
		NotInEditorAsServer,
		// error: enumerator has no value
		NotInBatchModeAndEditorAsServer
	}

	public NetworkProjectConfig Config;

	public List<INetworkPrefabSource> Prefabs;

	public NetworkPrefabTableOptions PrefabOptions;

	public NetworkRunnerCallbackArgs.Awaiter.SerializableSimulationBehaviourMeta[] BehaviourMeta;

	public static NetworkProjectConfigAsset Global
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9910]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DBA128");
			NetworkProjectConfigAsset result = default;
			return result;
		}
	}

	public static bool IsGlobalLoaded
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99C0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DBA2C8");
			bool result = default;
			return result;
		}
	}

	public static bool TryGetGlobal(out NetworkProjectConfigAsset global)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DBA348");
		bool result = default;
		return result;
	}

	public static void UnloadGlobal()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9918]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DBA4F0");
	}

	private unsafe void OnEnable()
	{
		//IL_0a60: Expected I4, but got Obj
		//IL_0a7f: Expected I4, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_0ac4: Expected I4, but got Obj
		//IL_0089: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_0b09: Expected I4, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected I, but got Obj
		//IL_0bdd: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I4
		//IL_0da4: Expected Obj, but got I
		//IL_0dac: Expected I, but got Obj
		//IL_0dc5: Expected Obj, but got I
		//IL_0ddf: Expected Obj, but got I4
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got I4
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_0505: Expected I4, but got Obj
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Ref
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I4
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Ref
		//IL_0296: Expected Obj, but got I4
		//IL_02a6: Expected I, but got Obj
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected I, but got Obj
		//IL_02cc: Expected Obj, but got I
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I8
		//IL_06b4: Expected Obj, but got I
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got I4
		//IL_06ed: Expected I, but got Obj
		//IL_0c48: Expected I, but got Obj
		//IL_0c58: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		//IL_0d25: Expected Obj, but got I4
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected Obj, but got I4
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0d07: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_0714: Expected Obj, but got I
		//IL_0736: Expected Obj, but got I4
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected I, but got Obj
		//IL_0889: Expected Obj, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0796: Expected Obj, but got I
		//IL_07a6: Expected Obj, but got I
		//IL_07cb: Expected I, but got Obj
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected I, but got Obj
		//IL_093e: Expected Obj, but got I4
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected Obj, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_07f3: Expected Obj, but got I
		//IL_08f4: Expected Obj, but got I
		//IL_0912: Expected I4, but got Obj
		//IL_091a: Expected I4, but got Obj
		//IL_0922: Expected I, but got Obj
		//IL_092f: Expected I4, but got Obj
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected I, but got Obj
		NetworkProjectConfig config = Config;
		bool flag = (object)Config == null;
		NetworkPrefabTable networkPrefabTable = (NetworkPrefabTable)(object)this;
		NetworkProjectConfig config3;
		object obj3;
		NetworkPrefabTable prefabTable;
		Enumerator<, > val = default;
		object obj7;
		int num2 = default;
		nint num;
		object obj9 = default;
		bool flag6;
		if (!flag)
		{
			networkPrefabTable = config.PrefabTable;
			if (config.PrefabTable != null)
			{
				config.PrefabTable.Clear();
				NetworkProjectConfig config2 = Config;
				bool flag2 = (object)Config == null;
				num = unchecked((nint)null);
				if (!flag2)
				{
					bool flag3 = (object)config2.ExecutionOrderOverrides == null;
					num = unchecked((nint)null);
					networkPrefabTable = (NetworkPrefabTable)(object)config2.ExecutionOrderOverrides;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99D0]");
						object obj = 0;
						num = (nint)obj;
						((Dictionary<System.__Canon, int>)(object)config2.ExecutionOrderOverrides).Clear();
						config3 = Config;
						bool flag4 = (object)Config == null;
						networkPrefabTable = (NetworkPrefabTable)(object)config2.ExecutionOrderOverrides;
						if (!flag4)
						{
							bool flag5 = Prefabs == null;
							networkPrefabTable = (NetworkPrefabTable)(object)Prefabs;
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99E0]");
								object obj2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8878]");
								object obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D81E0]");
								object obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A08]");
								object format = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99F8]");
								object obj6 = 0;
								prefabTable = config3.PrefabTable;
								Enumerator<, > enumerator = ((List<System.__Canon>)(object)Prefabs).GetEnumerator();
								INetworkPrefabSource networkPrefabSource = default;
								bool flag12 = default;
								object arg = default;
								object arg2 = default;
								while (true)
								{
									num = (nint)obj2;
									flag6 = val.MoveNext();
									bool flag7 = !flag6;
									obj7 = 0;
									if (flag7)
									{
										break;
									}
									if (config3.PrefabTable == null)
									{
										goto IL_04bd;
									}
									flag6 = config3.PrefabTable.TryAddSource(networkPrefabSource, out var id);
									bool flag8 = !flag6;
									object obj8 = !flag8;
									obj9 = 0;
									num2 = (int)(&id);
									if (obj8 != null)
									{
										continue;
									}
									object obj10 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v59+A0]");
									object obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v60+18]");
									object obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v60+18]");
									bool flag9 = (nint)0 == 0;
									obj9 = 0;
									num2 = (int)(&id);
									if (flag9)
									{
										continue;
									}
									bool flag10 = networkPrefabSource == null;
									obj9 = 0;
									num2 = (int)(&id);
									num = (nint)networkPrefabSource;
									if (flag10)
									{
										goto IL_050a;
									}
									nint num3 = (nint)networkPrefabSource;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v61 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
									object obj13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v61 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0384;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v61 (Il2CppClass<Fusion.INetworkPrefabSource>)+98]");
									object obj14 = (nint)0 + (nint)8;
									bool flag11 = flag12;
									object obj16;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X10_v18-8]");
										object obj15 = 0 - obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X10_v18-8]");
										if (0 == (nint)obj4)
										{
											break;
										}
										obj13--;
										obj15 = obj13 - 1;
										bool flag13 = obj15 == null;
										obj16 = obj14 + 16;
										flag12 = (nint)obj13 != 1;
										flag11 = flag12;
										obj14 = obj16;
										if (flag12)
										{
											continue;
										}
										goto IL_0384;
									}
									object obj17 = num3 + obj14;
									object obj18 = obj17 + 312;
									flag12 = flag11;
									obj16 = obj14;
									int num4 = (int)(&id);
									goto IL_0c2c;
									IL_0384:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
									num4 = 0;
									goto IL_0c2c;
									IL_0c2c:
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v871 @ X0_v57] (should have been resolved before IL gen)");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									nint num5 = (nint)networkPrefabSource;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v65 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v65 (Il2CppClass<Fusion.INetworkPrefabSource>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0467;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v65 (Il2CppClass<Fusion.INetworkPrefabSource>)+98]");
									object obj20 = (nint)0 + (nint)8;
									bool flag14 = flag12;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X10_v13-8]");
										object obj15 = 0 - obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X10_v13-8]");
										if (0 == (nint)obj4)
										{
											break;
										}
										obj19--;
										obj15 = obj19 - 1;
										bool flag13 = obj15 == null;
										obj16 = obj20 + 16;
										flag12 = (nint)obj19 != 1;
										flag14 = flag12;
										obj20 = obj16;
										if (flag12)
										{
											continue;
										}
										goto IL_0467;
									}
									object obj21 = obj20 + 1;
									object obj22 = num5 + obj21;
									object obj23 = obj22 + 312;
									flag12 = flag14;
									obj16 = obj20;
									goto IL_0cbd;
									IL_0cbd:
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v962 @ X0_v62] (should have been resolved before IL gen)");
									string text = string.Format((string)format, arg, arg2);
									object obj24 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v68+1A0]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v646 @ X8_v68+198] (should have been resolved before IL gen)");
									obj9 = 0;
									continue;
									IL_0467:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
									num4 = 1;
									goto IL_0cbd;
								}
								goto IL_0591;
							}
						}
					}
				}
			}
		}
		goto IL_0a37;
		IL_0b68:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0998:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag15 = num6 != 0;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		if (!flag15)
		{
			return;
		}
		goto IL_0b68;
		IL_050a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag16 = num7 != 0;
		val2 = val3;
		if (flag16)
		{
			goto IL_0b68;
		}
		NullReferenceException ex = new NullReferenceException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj7 = 1;
			goto IL_0591;
		}
		bool flag17 = num != 1;
		NullReferenceException ex2 = ex;
		val2 = val3;
		Enumerator<, > val4 = (Enumerator<, >)(ref val);
		if (flag17)
		{
			goto IL_0d5b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
		object obj26 = default;
		object obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		obj7 = 0;
		goto IL_0d94;
		IL_0d94:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99D8]");
		object obj27 = 0;
		num = (nint)obj27;
		val.Dispose();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A00]");
		object obj28 = 0;
		bool flag18 = obj25 == null;
		object obj29 = !flag18;
		val2 = val3;
		val4 = (Enumerator<, >)(ref val);
		flag6 = (byte)(&val) != 0;
		if (obj29 != null)
		{
			goto IL_0ac9;
		}
		bool flag19 = obj7 == null;
		object obj30 = !flag19;
		val2 = val3;
		val4 = (Enumerator<, >)(ref val);
		flag6 = (byte)(&val) != 0;
		if (obj30 == null)
		{
			bool flag20 = config3.PrefabTable == null;
			val2 = val3;
			val4 = (Enumerator<, >)(ref val);
			networkPrefabTable = (NetworkPrefabTable)(&val);
			if (!flag20)
			{
				prefabTable.Options = PrefabOptions;
				NetworkRunnerCallbackArgs.Awaiter.SerializableSimulationBehaviourMeta[] behaviourMeta = BehaviourMeta;
				bool flag21 = BehaviourMeta == null;
				val2 = val3;
				val4 = (Enumerator<, >)(ref val);
				networkPrefabTable = (NetworkPrefabTable)(&val);
				if (!flag21)
				{
					bool flag22 = behaviourMeta.Length < 1;
					flag6 = (byte)(&val) != 0;
					if (flag22)
					{
						goto IL_0998;
					}
					object obj31 = behaviourMeta.Length & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj32 = 0;
					object obj33 = BehaviourMeta + 40;
					object obj34 = obj9;
					int num8 = num2;
					val4 = (Enumerator<, >)(ref val);
					object obj35 = 0;
					nint num9 = (nint)obj27;
					bool flag23 = (byte)(&val) != 0;
					Type type = default;
					object arg3 = default;
					while (true)
					{
						bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
						object obj36 = !flag24;
						obj9 = obj34;
						num2 = num8;
						val2 = val3;
						num = num9;
						flag6 = flag23;
						if (obj36 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4342A74");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X27_v12+E8]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v40+E4]");
						bool flag25 = (nint)0 == 0;
						object obj38 = !flag25;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						flag6 = type == null;
						if (flag6)
						{
							object obj39 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v46+A0]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v47+18]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v47+18]");
							bool flag26 = (nint)0 == 0;
							num2 = 0;
							num = unchecked((nint)null);
							if (!flag26)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A10]");
								object format2 = 0;
								string text2 = string.Format((string)format2, arg3);
								object obj42 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v51+1A0]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v992 @ X8_v51+198] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X28_v12-8]");
								val4 = (Enumerator<, >)0;
								num = (nint)text2;
							}
							goto IL_0934;
						}
						NetworkProjectConfig config4 = Config;
						bool flag27 = (object)Config == null;
						obj9 = obj34;
						num2 = 0;
						val2 = val3;
						num = unchecked((nint)null);
						networkPrefabTable = (NetworkPrefabTable)flag6;
						if (!flag27)
						{
							bool flag28 = (object)config4.ExecutionOrderOverrides == null;
							obj9 = obj34;
							num2 = 0;
							val2 = val3;
							num = unchecked((nint)null);
							networkPrefabTable = (NetworkPrefabTable)(object)config4.ExecutionOrderOverrides;
							if (!flag28)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D99C8]");
								object obj43 = 0;
								obj34 = obj43;
								((Dictionary<System.__Canon, int>)(object)config4.ExecutionOrderOverrides).Add((System.__Canon)(object)type, (int)obj33);
								num2 = (int)obj33;
								num = (nint)type;
								flag6 = (byte)(int)config4.ExecutionOrderOverrides != 0;
								goto IL_0934;
							}
						}
						goto IL_0a37;
						IL_0934:
						obj31 = behaviourMeta.Length;
						obj35++;
						obj33 += 16;
						bool flag29 = (nint)obj35 < behaviourMeta.Length;
						obj9 = obj34;
						num8 = num2;
						num9 = num;
						flag23 = flag6;
						if (flag29)
						{
							continue;
						}
						goto IL_0998;
					}
					goto IL_0a84;
				}
			}
			goto IL_0a37;
		}
		goto IL_0b0e;
		IL_0ac9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num10 == 0)
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
			flag6 = (byte)(int)ex3 != 0;
			goto IL_0b0e;
		}
		goto IL_0b68;
		IL_0a84:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num11 == 0)
		{
			IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
			flag6 = (byte)(int)ex4 != 0;
			goto IL_0ac9;
		}
		goto IL_0b68;
		IL_0d5b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28ACD68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num12 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		}
		goto IL_0b68;
		IL_0b0e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num13 != 0)
		{
			goto IL_0b68;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex5 = default;
		ex2 = ex5;
		goto IL_0d5b;
		IL_04bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag30 = num14 != 0;
		val2 = val3;
		if (!flag30)
		{
			NullReferenceException ex6 = new NullReferenceException();
			flag6 = (byte)(int)ex6 != 0;
			goto IL_050a;
		}
		goto IL_0b68;
		IL_0591:
		obj25 = 0;
		goto IL_0d94;
		IL_0a37:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag31 = num15 != 0;
		flag6 = (byte)(int)networkPrefabTable != 0;
		if (!flag31)
		{
			NullReferenceException ex7 = new NullReferenceException();
			flag6 = (byte)(int)ex7 != 0;
			goto IL_0a84;
		}
		goto IL_0b68;
	}

	protected override void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DB9EE0");
		NetworkProjectConfig config = Config;
		if (config.PrefabTable != null)
		{
			config.PrefabTable.Clear();
			config = Config;
		}
		((Dictionary<System.__Canon, int>)(object)config.ExecutionOrderOverrides).Clear();
	}

	private static string GenerateDefaultContents()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9930]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkProjectConfig networkProjectConfig = default;
		networkProjectConfig._002Ector();
		return JsonUtility.ToJson(networkProjectConfig, prettyPrint: true);
	}

	public NetworkProjectConfigAsset()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I
		//IL_016f: Expected VT, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9930]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D89A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8970]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A20]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkProjectConfig networkProjectConfig = default;
		networkProjectConfig._002Ector();
		object obj5 = this + 32;
		obj5 = networkProjectConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj6 = this + 40;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v13+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v13+A0]");
		object obj8 = 0;
		object obj9 = obj4;
		PrefabOptions = (NetworkPrefabTableOptions)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v5+38]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v5+38]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v5+38]");
			obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+10]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9A28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v5+38]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+10]");
			obj12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v16+A0]");
		object obj16 = 0;
		object obj17 = this + 56;
		obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DBBA94");
	}
}
