using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public static class GillaSkin
{
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public GillaSawHits _003C_003E4__this;

		public Vector3 back;

		public Vector3 tip;

		public float half;

		public Vector3 normal;

		public float bestIn;

		public GillaSawHits.Cut best;

		public Vector3 bestAt;

		public Vector3 bestBar;

		internal unsafe void _003CLateUpdate_003Eg__Try_007C0(NetworkApe ape, GillaDummy dummy, GillaCorpse body, GillaWounds w)
		{
			//IL_0010: Expected Obj, but got I
			//IL_19eb: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got I4
			//IL_0084: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I4
			//IL_00e8: Expected Obj, but got I4
			//IL_1a1d: Expected F4, but got I4
			//IL_1a26: Expected F4, but got I4
			//IL_184e: Expected F4, but got I4
			//IL_1857: Expected F4, but got I4
			//IL_1866: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected Obj, but got I4
			//IL_01df: Expected F4, but got I4
			//IL_01e8: Expected F4, but got I4
			//IL_0165: Expected Obj, but got I4
			//IL_020e: Expected Obj, but got I
			//IL_0240: Expected F4, but got I4
			//IL_03ac: Expected Obj, but got I4
			//IL_03ef: Expected F4, but got I4
			//IL_0282: Expected F4, but got I4
			//IL_028b: Expected F4, but got I4
			//IL_042f: Expected F4, but got I4
			//IL_02be: Expected F4, but got I4
			//IL_02c7: Expected F4, but got I4
			//IL_0468: Expected F4, but got I4
			//IL_02ed: Expected Obj, but got I
			//IL_0327: Expected F4, but got I4
			//IL_0494: Expected Obj, but got I
			//IL_04c6: Expected F4, but got I4
			//IL_0501: Expected F4, but got I4
			//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_070c: Expected Obj, but got I
			//IL_071c: Expected Obj, but got I
			//IL_072c: Expected Obj, but got I
			//IL_073c: Expected Obj, but got I
			//IL_0755: Expected F4, but got I4
			//IL_075e: Expected F4, but got I4
			//IL_077f: Expected F4, but got I
			//IL_0787: Expected VT, but got Obj
			//IL_0790: Expected VT, but got I4
			//IL_0530: Expected F4, but got I4
			//IL_17c2: Expected Obj, but got Ref
			//IL_17cb: Expected F4, but got I4
			//IL_17d4: Expected Obj, but got I4
			//IL_17d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ed: Expected Obj, but got VT
			//IL_17f5: Expected I4, but got VT
			//IL_17fe: Expected Obj, but got I4
			//IL_0564: Expected F4, but got I4
			//IL_1b6f: Expected Obj, but got I
			//IL_1b77: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b80: Expected Ref, but got Unknown
			//IL_1b9a: Expected Obj, but got I4
			//IL_07a9: Expected F4, but got VT
			//IL_07cb: Expected Obj, but got I4
			//IL_0806: Expected VT, but got I4
			//IL_0806: Expected VT, but got Ref
			//IL_0806: Expected VT, but got Ref
			//IL_058b: Expected Obj, but got I
			//IL_05d6: Expected Obj, but got I4
			//IL_180c: Invalid comparison between F4 and I4
			//IL_181d: Expected Obj, but got I4
			//IL_181d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1825: Expected Obj, but got Unknown
			//IL_0bdc: Invalid comparison between F4 and I4
			//IL_0bed: Expected Obj, but got VT
			//IL_0bfe: Expected Obj, but got Ref
			//IL_0fc5: Invalid comparison between F4 and I4
			//IL_0fd6: Expected Obj, but got I4
			//IL_0fdf: Invalid comparison between F4 and I4
			//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffb: Expected Obj, but got Unknown
			//IL_0863: Invalid comparison between F4 and I4
			//IL_087c: Expected VT, but got I
			//IL_088c: Expected Obj, but got I
			//IL_08a5: Expected VT, but got I4
			//IL_0605: Invalid comparison between F4 and I4
			//IL_0630: Expected Obj, but got I4
			//IL_15c5: Invalid comparison between F4 and I
			//IL_15de: Expected VT, but got I
			//IL_15ee: Expected Obj, but got I
			//IL_160e: Expected F4, but got I
			//IL_1616: Expected VT, but got Obj
			//IL_161e: Expected VT, but got I4
			//IL_0c37: Expected Obj, but got Ref
			//IL_0c47: Expected VT, but got I
			//IL_0c57: Expected Obj, but got I
			//IL_0c68: Expected F4, but got I4
			//IL_0c71: Expected Obj, but got I4
			//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c92: Expected Obj, but got VT
			//IL_0ca3: Expected Obj, but got Ref
			//IL_102e: Expected Obj, but got I4
			//IL_1048: Invalid comparison between F4 and I4
			//IL_105f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1064: Expected Obj, but got Unknown
			//IL_1074: Expected VT, but got I
			//IL_1084: Expected Obj, but got I
			//IL_109c: Expected VT, but got Obj
			//IL_10a4: Expected VT, but got I4
			//IL_08de: Expected Obj, but got Ref
			//IL_08ee: Expected VT, but got I
			//IL_08fe: Expected Obj, but got I
			//IL_090f: Expected F4, but got I4
			//IL_0918: Expected Obj, but got I4
			//IL_0919: Unknown result type (might be due to invalid IL or missing references)
			//IL_091d: Unknown result type (might be due to invalid IL or missing references)
			//IL_092d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0939: Expected Obj, but got VT
			//IL_094a: Expected Obj, but got Ref
			//IL_164d: Expected Obj, but got Ref
			//IL_165d: Expected VT, but got I
			//IL_166d: Expected Obj, but got I
			//IL_167e: Expected F4, but got I4
			//IL_1687: Expected Obj, but got I4
			//IL_1688: Unknown result type (might be due to invalid IL or missing references)
			//IL_168c: Unknown result type (might be due to invalid IL or missing references)
			//IL_169c: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b0: Expected F4, but got I
			//IL_0ce2: Expected Obj, but got Ref
			//IL_0cf3: Expected VT, but got I
			//IL_0d03: Expected Obj, but got I
			//IL_0d14: Expected F4, but got I4
			//IL_0d1d: Expected Obj, but got I4
			//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3e: Expected Obj, but got VT
			//IL_0d4f: Expected Obj, but got Ref
			//IL_1965: Expected F4, but got I4
			//IL_10d3: Expected Obj, but got Ref
			//IL_10e3: Expected VT, but got I
			//IL_10f3: Expected Obj, but got I
			//IL_1104: Expected F4, but got I4
			//IL_110d: Expected Obj, but got I4
			//IL_110e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1112: Unknown result type (might be due to invalid IL or missing references)
			//IL_1122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0972: Expected I4, but got F4
			//IL_0996: Expected Obj, but got Ref
			//IL_09a7: Expected VT, but got I
			//IL_09b7: Expected Obj, but got I
			//IL_09c8: Expected F4, but got I4
			//IL_09d1: Expected Obj, but got I4
			//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f2: Expected I4, but got F4
			//IL_16de: Expected VT, but got I
			//IL_1719: Expected VT, but got Ref
			//IL_1719: Expected VT, but got I4
			//IL_1719: Expected I4, but got F4
			//IL_172f: Expected VT, but got I4
			//IL_1748: Expected F4, but got I4
			//IL_1760: Expected VT, but got F4
			//IL_1768: Expected VT, but got Obj
			//IL_0d7d: Expected Obj, but got VT
			//IL_0d8e: Expected Obj, but got Ref
			//IL_114f: Expected I4, but got F4
			//IL_116d: Expected Obj, but got I4
			//IL_11a2: Expected Ref, but got F4
			//IL_11b4: Expected VT, but got I
			//IL_11c4: Expected Obj, but got I
			//IL_11ee: Expected VT, but got Obj
			//IL_11f6: Expected VT, but got Obj
			//IL_0a51: Expected Obj, but got Ref
			//IL_0a62: Expected VT, but got I
			//IL_0a72: Expected Obj, but got I
			//IL_0a83: Expected F4, but got I4
			//IL_0a8c: Expected Obj, but got I4
			//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab6: Expected Obj, but got VT
			//IL_1443: Expected Obj, but got I4
			//IL_0dad: Expected I4, but got F4
			//IL_0dbd: Expected Obj, but got I
			//IL_1222: Expected I, but got Obj
			//IL_122a: Expected Obj, but got F4
			//IL_123a: Expected VT, but got I
			//IL_124a: Expected Obj, but got I
			//IL_125b: Expected F4, but got I4
			//IL_1264: Expected Obj, but got I4
			//IL_1265: Unknown result type (might be due to invalid IL or missing references)
			//IL_1269: Unknown result type (might be due to invalid IL or missing references)
			//IL_1279: Unknown result type (might be due to invalid IL or missing references)
			//IL_128d: Expected I4, but got Obj
			//IL_0e02: Expected Obj, but got VT
			//IL_0ade: Expected I4, but got F4
			//IL_0b02: Expected Obj, but got Ref
			//IL_0b14: Expected VT, but got I
			//IL_0b24: Expected Obj, but got I
			//IL_0b35: Expected F4, but got I4
			//IL_0b3e: Expected Obj, but got I4
			//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5f: Expected I4, but got F4
			//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_14de: Expected Obj, but got Unknown
			//IL_12c3: Expected VT, but got I
			//IL_1310: Expected VT, but got I
			//IL_1310: Expected VT, but got I4
			//IL_1310: Expected I4, but got F4
			//IL_132c: Expected VT, but got I4
			//IL_133c: Expected Ref, but got F4
			//IL_134f: Expected VT, but got I4
			//IL_1368: Expected F4, but got I4
			//IL_1380: Expected VT, but got Obj
			//IL_1388: Expected VT, but got Obj
			//IL_1399: Expected VT, but got I4
			//IL_13b1: Expected VT, but got I
			//IL_13c9: Expected Ref, but got F4
			//IL_13da: Expected VT, but got I4
			//IL_13f3: Expected F4, but got I4
			//IL_140b: Expected VT, but got Obj
			//IL_1413: Expected VT, but got Obj
			//IL_0e3b: Expected Obj, but got Ref
			//IL_0e4d: Expected VT, but got I
			//IL_0e5d: Expected Obj, but got I
			//IL_0e6e: Expected F4, but got I4
			//IL_0e77: Expected Obj, but got I4
			//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea1: Expected Obj, but got VT
			//IL_0b7d: Expected VT, but got Obj
			//IL_0ba5: Expected VT, but got I
			//IL_0bb5: Expected Obj, but got I
			//IL_0bce: Expected VT, but got I4
			//IL_1bdb: Expected Obj, but got I
			//IL_1c05: Expected Obj, but got I4
			//IL_1568: Invalid comparison between F4 and I
			//IL_0ec9: Expected I4, but got F4
			//IL_0eed: Expected Obj, but got Ref
			//IL_0efe: Expected VT, but got I
			//IL_0f0e: Expected Obj, but got I
			//IL_0f1f: Expected F4, but got I4
			//IL_0f28: Expected Obj, but got I4
			//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f49: Expected I4, but got F4
			//IL_177d: Expected Obj, but got I
			//IL_1795: Expected Obj, but got I
			//IL_179d: Expected F4, but got Obj
			//IL_17ad: Expected F4, but got I
			//IL_1abc: Expected VT, but got F4
			//IL_1adb: Expected VT, but got F4
			//IL_1b38: Expected F4, but got I
			//IL_0f67: Expected VT, but got Obj
			//IL_0f8e: Expected VT, but got I
			//IL_0f9e: Expected Obj, but got I
			//IL_0fb7: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = w == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)ape != (UnityEngine.Object)null;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			NetworkApe networkApe = ape;
			Unity.IL2CPP.Metadata.__Il2CppByteEnum _Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
			UnityEngine.Object obj8 = null;
			GillaDummy gillaDummy = (GillaDummy)109891584;
			if (obj7 == null)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v114+E4]");
				bool flag7 = (nint)0 == 0;
				object obj10 = !flag7;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = (UnityEngine.Object)dummy != (UnityEngine.Object)null;
				bool flag9 = !flag8;
				object obj11 = !flag9;
				object obj12 = ~obj11;
				if (obj12 == null)
				{
					networkApe = (NetworkApe)(object)dummy;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
					obj8 = null;
					gillaDummy = dummy;
				}
				else
				{
					networkApe = (NetworkApe)(object)body;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
					obj8 = null;
					gillaDummy = dummy;
				}
			}
			GillaSawHits gillaSawHits = _003C_003E4__this;
			bool flag10 = (object)_003C_003E4__this == null;
			float value = 0f;
			float num = 0f;
			GillaCorpse gillaCorpse = body;
			if (!flag10)
			{
				bool flag11 = (object)gillaSawHits.killed == null;
				value = 0f;
				num = 0f;
				gillaCorpse = body;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DE8]");
					object obj13 = 0;
					obj8 = (UnityEngine.Object)obj13;
					int count = ((Dictionary<System.__Canon, float>)(object)gillaSawHits.killed).Count;
					bool flag12 = count < 1;
					num = 0f;
					gillaCorpse = body;
					System.__Canon _Canon = (System.__Canon)obj13;
					if (flag12)
					{
						goto IL_0382;
					}
					GillaSawHits gillaSawHits2 = _003C_003E4__this;
					bool flag13 = (object)_003C_003E4__this == null;
					value = 0f;
					num = 0f;
					gillaCorpse = body;
					if (!flag13)
					{
						bool flag14 = (object)gillaSawHits2.killed == null;
						value = 0f;
						num = 0f;
						gillaCorpse = body;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7170]");
							object obj14 = 0;
							gillaCorpse = (GillaCorpse)obj14;
							bool flag15 = ((Dictionary<System.__Canon, float>)(object)gillaSawHits2.killed).TryGetValue((System.__Canon)(object)networkApe, out float value2);
							bool flag16 = !flag15;
							num = 0f;
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(byte)(&value2);
							_Canon = (System.__Canon)(object)networkApe;
							if (!flag16)
							{
								num = Time.time;
								bool flag17 = num < value2;
								float num2 = value2;
								_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(byte)(&value2);
								_Canon = (System.__Canon)(object)networkApe;
								if (flag17)
								{
									return;
								}
							}
							goto IL_0382;
						}
					}
				}
			}
			goto IL_1834;
			IL_1a3c:
			GillaSawHits gillaSawHits3 = _003C_003E4__this;
			float num4;
			float num5;
			float num8 = default;
			Enumerator<, > val = default;
			bool flag21;
			GillaWounds gillaWounds;
			float num15;
			if ((object)_003C_003E4__this != null && (object)w != null)
			{
				w.Shapes(gillaSawHits3.shapes);
				GillaSawHits gillaSawHits4 = _003C_003E4__this;
				bool flag18 = (object)_003C_003E4__this == null;
				_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
				obj8 = (UnityEngine.Object)(object)gillaSawHits3.shapes;
				if (!flag18)
				{
					bool flag19 = gillaSawHits4.shapes == null;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
					obj8 = (UnityEngine.Object)(object)gillaSawHits3.shapes;
					if (!flag19)
					{
						Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3, Vector3, float)>)(object)gillaSawHits4.shapes).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7180]");
						GillaCorpse gillaCorpse2 = (GillaCorpse)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7070]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F48]");
						gillaDummy = (GillaDummy)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F40]");
						obj = 0;
						nint num3 = default;
						ref Vector3 reference = ref *(Vector3*)num3;
						ref Vector3 reference2 = ref *(Vector3*)w;
						num4 = 0f;
						num5 = 0f;
						float num7 = default;
						float num6 = num7;
						float num2 = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
						num = 0f;
						Vector3 vector = (Vector3)gillaCorpse;
						Vector3 vector2 = (Vector3)0;
						float num12 = default;
						Enumerator<, > val2 = default;
						Vector3 vector5 = default;
						float num18 = default;
						Vector3 vector7 = default;
						float num20 = default;
						float num22 = default;
						float num27 = default;
						float num28 = default;
						Vector3 vector11 = default;
						Vector3 vector13 = default;
						object obj30 = default;
						float num29 = default;
						object obj39 = default;
						object obj44 = default;
						while (true)
						{
							object obj19;
							Enumerator<, > val3;
							if (val.MoveNext())
							{
								object obj16 = obj15;
								float num9 = (float)tip;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2037 @ X0_v68+E4]");
								bool flag20 = (nint)0 == 0;
								object obj17 = !flag20;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								num = GillaSawHits.Closest((Vector3)(&num5), (Vector3)(&num4), (Vector3)0, vector, out reference2, out reference);
								float num10 = half;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
								float num11 = num10 * 0f;
								num2 = num12 + num11;
								float num13 = num2 - num;
								Vector3 vector3;
								object obj18;
								float num14;
								if (flag21)
								{
									bool flag22 = !(num13 > 0f);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num6 = num12;
									vector2 = (Vector3)0;
									if (flag22)
									{
										continue;
									}
									GillaSawHits gillaSawHits5 = _003C_003E4__this;
									bool flag23 = (object)_003C_003E4__this == null;
									num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num15 = 0f;
									obj19 = 0;
									val = val2;
									num6 = num12;
									val3 = (Enumerator<, >)(ref val);
									gillaCorpse = (GillaCorpse)vector;
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
									obj8 = (UnityEngine.Object)(&num4);
									if (flag23)
									{
										break;
									}
									gillaCorpse = (GillaCorpse)(object)gillaDummy;
									(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple = ((System.__Canon)(object)networkApe, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8);
									bool flag24 = gillaSawHits5.outFirst == null;
									num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num15 = 0f;
									obj19 = 0;
									val = val2;
									num6 = num12;
									val3 = (Enumerator<, >)(ref val);
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8;
									obj8 = networkApe;
									if (flag24)
									{
										goto IL_187d;
									}
									gillaCorpse = (GillaCorpse)obj;
									bool flag25 = ((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)gillaSawHits5.outFirst).Add(tuple);
									GillaSawHits gillaSawHits6 = _003C_003E4__this;
									bool flag26 = (object)_003C_003E4__this == null;
									num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num15 = 0f;
									obj19 = 0;
									val = val2;
									num6 = num12;
									val3 = (Enumerator<, >)(ref val);
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
									obj8 = (UnityEngine.Object)tuple;
									if (!flag26)
									{
										gillaCorpse = (GillaCorpse)(object)gillaDummy;
										(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) item = ((System.__Canon)(object)networkApe, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8);
										bool flag27 = gillaSawHits6.inPart == null;
										num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
										gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
										vector3 = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
										obj18 = 0;
										num14 = num9;
										num15 = 0f;
										obj19 = 0;
										val = val2;
										num6 = num12;
										val3 = (Enumerator<, >)(ref val);
										_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8;
										obj8 = networkApe;
										if (!flag27)
										{
											vector = (Vector3)obj;
											bool flag28 = ((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)gillaSawHits6.inPart).Add(item);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
											vector3 = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
											obj18 = 0;
											num14 = num9;
											num6 = num12;
											vector2 = (Vector3)0;
											continue;
										}
										goto IL_186f;
									}
									goto IL_188b;
								}
								bool flag29 = !(num13 > 0f);
								gillaCorpse = (GillaCorpse)vector;
								_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
								obj8 = (UnityEngine.Object)(&num4);
								if (!flag29)
								{
									GillaSawHits gillaSawHits7 = _003C_003E4__this;
									bool flag30 = (object)_003C_003E4__this == null;
									num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num15 = 0f;
									obj19 = 0;
									val = val2;
									num6 = num12;
									val3 = (Enumerator<, >)(ref val);
									gillaCorpse = (GillaCorpse)vector;
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
									obj8 = (UnityEngine.Object)(&num4);
									if (flag30)
									{
										goto IL_18a7;
									}
									HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)> outFirst = (HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)gillaSawHits7.outFirst;
									bool flag31 = gillaSawHits7.outFirst == null;
									num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num15 = 0f;
									obj19 = 0;
									val = val2;
									num6 = num12;
									val3 = (Enumerator<, >)(ref val);
									gillaCorpse = (GillaCorpse)vector;
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
									obj8 = (UnityEngine.Object)(&num4);
									if (flag31)
									{
										goto IL_18b5;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X28_v19 (System.Collections.Generic.HashSet`1<System.ValueTuple`2<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum>>)+20]");
									bool flag32 = (nint)0 < (nint)1;
									gillaCorpse = (GillaCorpse)vector;
									_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
									obj8 = (UnityEngine.Object)(&num4);
									if (!flag32)
									{
										(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum) tuple = ((System.__Canon)(object)networkApe, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7190]");
										object obj20 = 0;
										gillaCorpse = (GillaCorpse)obj20;
										bool flag33 = ((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)gillaSawHits7.outFirst).Contains(tuple);
										bool flag34 = !flag33;
										_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
										obj8 = (UnityEngine.Object)tuple;
										if (!flag34)
										{
											GillaSawHits gillaSawHits8 = _003C_003E4__this;
											bool flag35 = (object)_003C_003E4__this == null;
											num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
											gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
											vector3 = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
											obj18 = 0;
											num14 = num9;
											num15 = 0f;
											obj19 = 0;
											val = val2;
											num6 = num12;
											val3 = (Enumerator<, >)(ref val);
											_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
											obj8 = (UnityEngine.Object)tuple;
											if (!flag35)
											{
												gillaCorpse = (GillaCorpse)(object)gillaDummy;
												tuple = ((System.__Canon)(object)networkApe, (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8);
												bool flag36 = gillaSawHits8.inPart == null;
												num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
												gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
												vector3 = (Vector3)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
												obj18 = 0;
												num14 = num9;
												num15 = 0f;
												obj19 = 0;
												val = val2;
												num6 = num12;
												val3 = (Enumerator<, >)(ref val);
												_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num8;
												obj8 = networkApe;
												if (!flag36)
												{
													vector = (Vector3)obj;
													bool flag37 = ((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)gillaSawHits8.inPart).Add(tuple);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
													vector3 = (Vector3)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
													obj18 = 0;
													num14 = num9;
													num6 = num12;
													vector2 = (Vector3)0;
													continue;
												}
												goto IL_18df;
											}
											goto IL_18ed;
										}
									}
								}
								bool flag38 = num13 < 0f;
								object obj21 = !flag38;
								bool flag39 = num13 == 0f;
								object obj22 = ~obj21;
								object obj23 = obj22 | flag39;
								if (obj23 == null)
								{
									num = bestIn;
									bool flag40 = num13 < bestIn;
									object obj24 = !flag40;
									float num16 = num13 - bestIn;
									bool flag41 = num16 == 0f;
									object obj25 = ~obj24;
									object obj26 = obj25 | flag41;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num6 = num12;
									vector = (Vector3)gillaCorpse;
									vector2 = (Vector3)_Il2CppByteEnum;
									if (obj26 != null)
									{
										continue;
									}
									bool flag42 = (object)_003C_003E4__this == null;
									num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
									vector3 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
									obj18 = 0;
									num14 = num9;
									num15 = 0f;
									obj19 = 0;
									val = val2;
									num6 = num12;
									val3 = (Enumerator<, >)(ref val);
									if (!flag42)
									{
										GillaSawHits.Cut cut = _003C_003E4__this.Find(ape, dummy, body, (GoreSection)(int)num8);
										bool flag43 = cut == null;
										object obj27 = !flag43;
										Vector3 vector4 = vector5;
										float num17 = num18;
										Vector3 vector6 = vector7;
										float num19 = num20;
										float num21 = num22;
										ref Vector3 reference3 = ref *(Vector3*)null;
										ref Vector3 reference4 = ref *(Vector3*)num8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
										Vector3 vector8 = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
										object obj28 = 0;
										float num23 = num9;
										float num24 = num12;
										float num25 = num2;
										float num26 = bestIn;
										Vector3 vector9 = (Vector3)body;
										Vector3 vector10 = (Vector3)dummy;
										UnityEngine.Object obj29 = (UnityEngine.Object)(object)cut;
										if (obj27 == null)
										{
											bool flag44 = (object)_003C_003E4__this == null;
											num3 = unchecked((nint)null);
											gillaWounds = (GillaWounds)num8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
											vector3 = (Vector3)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
											obj18 = 0;
											num14 = num9;
											num15 = 0f;
											obj19 = 0;
											val = val2;
											num6 = num12;
											val3 = (Enumerator<, >)(ref val);
											gillaCorpse = body;
											_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)dummy;
											obj8 = (UnityEngine.Object)(object)cut;
											if (flag44)
											{
												goto IL_1915;
											}
											num19 = num27 - num28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+3C]");
											vector6 = (Vector3)0;
											num17 = num7 - (float)vector11;
											GillaSawHits gillaSawHits9 = _003C_003E4__this;
											float radius = num5;
											Vector3 vector12 = normal;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+3C]");
											GillaSawHits.Cut cut2 = gillaSawHits9.Begin(ape, dummy, body, w, (GoreSection)(int)num8, (Vector3)0, vector13, radius, vector12, (Vector3)0);
											bool flag45 = cut2 == null;
											vector4 = (Vector3)0;
											num21 = num12;
											reference3 = ref *(Vector3*)num8;
											reference4 = ref *(Vector3*)w;
											vector8 = (Vector3)0;
											obj28 = obj30;
											num23 = num4;
											num24 = 0f;
											num25 = num29;
											num26 = num5;
											vector9 = (Vector3)body;
											vector10 = (Vector3)dummy;
											obj29 = (UnityEngine.Object)(object)cut2;
											vector5 = (Vector3)0;
											num18 = num17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+3C]");
											vector7 = (Vector3)0;
											num20 = num19;
											num22 = num12;
											reference = ref *(Vector3*)num8;
											reference2 = ref *(Vector3*)w;
											vector3 = (Vector3)0;
											obj18 = obj30;
											num14 = num4;
											num6 = 0f;
											num2 = num29;
											num = num5;
											vector = (Vector3)body;
											vector2 = (Vector3)dummy;
											if (flag45)
											{
												continue;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1998 @ X1_v34 (UnityEngine.Object)+94]");
										bool flag46 = (nint)0 == 0;
										object obj31 = !flag46;
										vector5 = vector4;
										num18 = num17;
										vector7 = vector6;
										num20 = num19;
										num22 = num21;
										reference = ref reference3;
										reference2 = ref reference4;
										vector3 = vector8;
										obj18 = obj28;
										num14 = num23;
										num6 = num24;
										num2 = num25;
										num = num26;
										vector = vector9;
										vector2 = vector10;
										if (obj31 == null)
										{
											best = (GillaSawHits.Cut)(object)obj29;
											object obj32 = this + 72;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bestIn = num13;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
											object obj33 = 0;
											object obj34 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X0_v80+E4]");
											bool flag47 = (nint)0 == 0;
											object obj35 = !flag47;
											if (obj35 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											float num30 = num5 - num4;
											float num31 = num30 * num30;
											float num32 = 0f * 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
											float num33 = num31 + num32;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
											float num34;
											float num36;
											if (num33 > 0f)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
												num34 = 0f / num33;
												float num35 = num30;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
												num36 = num35 / 0f;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
												object obj36 = 0;
												object obj37 = obj36;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2193 @ X8_v59+A0]");
												object obj38 = 0;
												num36 = (float)obj38;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2194 @ X8_v60+8]");
												num34 = 0f;
											}
											float num37 = num36 * (float)obj39;
											num2 = num12 * num34;
											bestBar = (Vector3)num5;
											_ = 0;
											num = num4 + num37;
											bestAt = (Vector3)num;
											vector5 = vector4;
											num18 = num17;
											vector7 = vector6;
											num20 = num19;
											num22 = num21;
											reference = ref reference3;
											reference2 = ref reference4;
											vector3 = vector8;
											obj18 = obj28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
											num14 = 0f;
											num9 = num5;
											num6 = num12;
											vector = vector9;
											vector2 = vector10;
										}
										continue;
									}
									goto IL_18c3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
								bool flag48 = !(num13 > 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
								vector3 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
								obj18 = 0;
								num14 = num9;
								num6 = num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
								num = 0f;
								vector = (Vector3)gillaCorpse;
								vector2 = (Vector3)_Il2CppByteEnum;
								if (flag48)
								{
									continue;
								}
								bool flag49 = (object)_003C_003E4__this == null;
								num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
								gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+2C]");
								vector3 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+28]");
								obj18 = 0;
								num14 = num9;
								num15 = 0f;
								obj19 = 0;
								val = val2;
								num6 = num12;
								val3 = (Enumerator<, >)(ref val);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
								num = 0f;
								if (!flag49)
								{
									num20 = num27 - num28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSkin+<>c__DisplayClass61_0)+3C]");
									vector7 = (Vector3)0;
									num18 = num7 - (float)vector11;
									_003C_003E4__this.Foresee((UnityEngine.Object)networkApe, w, (GoreSection)(int)num8, (Vector3)0, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), num5, vector5, vector13);
									num22 = num12;
									reference2 = ref *(Vector3*)null;
									vector3 = (Vector3)0;
									obj18 = obj30;
									num14 = num4;
									num6 = 0f;
									num2 = num29;
									num = num5;
									vector = (Vector3)num8;
									vector2 = (Vector3)w;
									continue;
								}
								goto IL_18d1;
							}
							num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							gillaWounds = (GillaWounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							num15 = 0f;
							obj19 = 0;
							val = val2;
							val3 = (Enumerator<, >)(ref val);
							gillaCorpse = (GillaCorpse)vector;
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)vector2;
							object obj40 = 0;
							goto IL_1b5f;
							IL_1b5f:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7178]");
							object obj41 = 0;
							obj8 = (UnityEngine.Object)obj41;
							((Enumerator<, >*)val3)->Dispose();
							bool flag50 = obj40 == null;
							object obj42 = !flag50;
							if (obj42 == null)
							{
								bool flag51 = num15 == 0f;
								object obj43 = !flag51;
								OutOfMemoryException ex = (OutOfMemoryException)val3;
								if (obj43 == null)
								{
									return;
								}
							}
							else
							{
								OutOfMemoryException ex = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							goto IL_1915;
							IL_1915:
							NullReferenceException ex2 = new NullReferenceException();
							if ((nint)obj8 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								num15 = 1f;
								obj40 = obj19;
							}
							else
							{
								if ((nint)obj8 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DF04");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj40 = obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj19 = obj44;
							}
							goto IL_1b5f;
						}
						goto IL_1899;
					}
				}
			}
			goto IL_1834;
			IL_187d:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_188b;
			IL_186f:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_187d;
			IL_18a7:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_18b5;
			IL_0382:
			object obj45 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v57+E4]");
			bool flag52 = (nint)0 == 0;
			object obj46 = !flag52;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag53 = body != null;
			bool flag54 = !flag53;
			value = 0f;
			_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
			obj8 = null;
			if (flag54)
			{
				goto IL_0635;
			}
			GillaSawHits gillaSawHits10 = _003C_003E4__this;
			bool flag55 = (object)_003C_003E4__this == null;
			value = 0f;
			_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
			obj8 = null;
			if (!flag55)
			{
				bool flag56 = gillaSawHits10.killedOwners == null;
				value = 0f;
				_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
				obj8 = null;
				if (!flag56)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DE0]");
					object obj47 = 0;
					obj8 = (UnityEngine.Object)obj47;
					int count2 = gillaSawHits10.killedOwners.Count;
					bool flag57 = count2 < 1;
					value = 0f;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
					if (flag57)
					{
						goto IL_0635;
					}
					GillaSawHits gillaSawHits11 = _003C_003E4__this;
					bool flag58 = (object)_003C_003E4__this == null;
					value = 0f;
					_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
					if (!flag58)
					{
						bool flag59 = (object)body == null;
						value = 0f;
						_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
						if (!flag59)
						{
							bool flag60 = gillaSawHits11.killedOwners == null;
							value = 0f;
							_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
							if (!flag60)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7168]");
								object obj48 = 0;
								gillaCorpse = (GillaCorpse)obj48;
								bool flag61 = gillaSawHits11.killedOwners.TryGetValue(body.Owner__BackingField, out value);
								bool flag62 = !flag61;
								_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(byte)(&value);
								obj8 = (UnityEngine.Object)body.Owner__BackingField;
								if (flag62)
								{
									goto IL_0635;
								}
								num = Time.time;
								float num38 = num - value;
								bool flag63 = num38 < 0f;
								flag21 = flag63;
								float num2 = value;
								_Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)(byte)(&value);
								obj8 = (UnityEngine.Object)body.Owner__BackingField;
								goto IL_1a3c;
							}
						}
					}
				}
			}
			goto IL_1834;
			IL_1834:
			NullReferenceException ex6 = new NullReferenceException();
			gillaWounds = w;
			num4 = 0f;
			num5 = 0f;
			num15 = num8;
			val = (Enumerator<, >)0;
			goto IL_186f;
			IL_18d1:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_18df;
			IL_18b5:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_18c3;
			IL_188b:
			NullReferenceException ex9 = new NullReferenceException();
			goto IL_1899;
			IL_18c3:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_18d1;
			IL_1899:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_18a7;
			IL_18ed:
			throw new NullReferenceException();
			IL_18df:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_18ed;
			IL_0635:
			flag21 = false;
			goto IL_1a3c;
		}

		internal bool _003CLateUpdate_003Eb__1((UnityEngine.Object, GoreSection) k)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0109: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got VT
			//IL_00df: Expected I4, but got Obj
			//IL_0058: Expected Obj, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected I4, but got Unknown
			//IL_00cc: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4;
			if (k == null)
			{
				obj4 = 1;
			}
			else
			{
				GillaSawHits gillaSawHits = _003C_003E4__this;
				if ((object)_003C_003E4__this == null || gillaSawHits.inPart == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				bool flag2 = ((HashSet<(System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum)>)(object)gillaSawHits.inPart).Contains(((System.__Canon, Unity.IL2CPP.Metadata.__Il2CppByteEnum))k);
				obj4 = (flag2 ? 1 : 0) ^ 1;
			}
			return (byte)(obj4 & 1) != 0;
		}
	}

	private static float[] shapeOn;

	private const int Ways = default(int);

	private static readonly Dictionary<Mesh, GillaSlice.Points> made;

	private static readonly List<Mesh> gone;

	private const int Most = default(int);

	private static readonly List<SkinnedMeshRenderer> found;

	private static Matrix4x4[] boneTo;

	private static bool[] boneHas;

	private static float[] nearD;

	private static Vector3[] nearP;

	private static Vector3[] nearN;

	public unsafe static float Nearest(Component body, List<Vector3> at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_3e03: Expected I, but got Obj
		//IL_3e25: Expected Obj, but got I4
		//IL_004a: Expected F4, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_007b: Expected F4, but got I4
		//IL_39d0: Expected F4, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_3e48: Expected Obj, but got I
		//IL_3e58: Expected Obj, but got I
		//IL_3e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e82: Expected F4, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I4
		//IL_3ff5: Expected Obj, but got I
		//IL_4005: Expected Obj, but got I
		//IL_4021: Unknown result type (might be due to invalid IL or missing references)
		//IL_402f: Expected F4, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_3edd: Expected Obj, but got I
		//IL_3eff: Expected Obj, but got I
		//IL_3f2c: Expected Obj, but got I
		//IL_3fd7: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_3f53: Expected Obj, but got I
		//IL_3f63: Expected Obj, but got I
		//IL_3f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f96: Expected F4, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected F4, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_040c: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected F4, but got I4
		//IL_046f: Expected Obj, but got I
		//IL_047f: Expected Obj, but got I
		//IL_0497: Expected I, but got Obj
		//IL_04be: Expected Obj, but got I
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected F4, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I
		//IL_0519: Expected Obj, but got I
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got I4
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected F4, but got I4
		//IL_4056: Expected I4, but got Obj
		//IL_35b0: Expected Obj, but got I4
		//IL_35b9: Expected Obj, but got I4
		//IL_35bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ca: Expected Obj, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Invalid comparison between Unknown and I4
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_058c: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I4
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d38: Expected Obj, but got I
		//IL_4d40: Expected I4, but got Obj
		//IL_4d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d49: Expected Ref, but got Unknown
		//IL_4d63: Expected Obj, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_35e9: Expected Obj, but got I4
		//IL_35e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f1: Expected Obj, but got Unknown
		//IL_3d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d47: Expected F4, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_060c: Expected Obj, but got I4
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected Obj, but got Unknown
		//IL_364d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3652: Expected Obj, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0637: Expected I, but got Obj
		//IL_0659: Expected Obj, but got I4
		//IL_3636: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I4
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06da: Expected Obj, but got I
		//IL_3d81: Expected Obj, but got I4
		//IL_3d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d92: Expected Obj, but got I4
		//IL_36aa: Expected F4, but got I4
		//IL_36bc: Expected Obj, but got I4
		//IL_070a: Expected Obj, but got I4
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_3de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df1: Expected Obj, but got I4
		//IL_5057: Expected Obj, but got I4
		//IL_4c48: Expected Obj, but got I
		//IL_4c58: Expected Obj, but got I
		//IL_0739: Expected Obj, but got I
		//IL_074b: Expected I, but got Obj
		//IL_076d: Expected Obj, but got I4
		//IL_07b2: Expected Obj, but got I4
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_36ed: Expected Obj, but got I
		//IL_370e: Expected Obj, but got I4
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_3731: Expected Obj, but got I
		//IL_3739: Expected I4, but got Obj
		//IL_3745: Unknown result type (might be due to invalid IL or missing references)
		//IL_3777: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I4
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_37c8: Expected Obj, but got I
		//IL_37e9: Expected Obj, but got I4
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected Obj, but got Unknown
		//IL_384a: Expected Obj, but got I4
		//IL_3865: Expected Obj, but got I4
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_38ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_38cf: Expected Obj, but got Unknown
		//IL_38cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_38df: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e4: Expected Obj, but got Unknown
		//IL_38f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3904: Unknown result type (might be due to invalid IL or missing references)
		//IL_3909: Expected Obj, but got Unknown
		//IL_3919: Expected VT, but got I
		//IL_3929: Unknown result type (might be due to invalid IL or missing references)
		//IL_392e: Expected Obj, but got Unknown
		//IL_393e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3943: Expected Obj, but got Unknown
		//IL_395d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3961: Unsupported input type for neg.
		//IL_3961: Unknown result type (might be due to invalid IL or missing references)
		//IL_3962: Unknown result type (might be due to invalid IL or missing references)
		//IL_3993: Unknown result type (might be due to invalid IL or missing references)
		//IL_3997: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c85: Invalid comparison between Unknown and F4
		//IL_3986: Unknown result type (might be due to invalid IL or missing references)
		//IL_398a: Unknown result type (might be due to invalid IL or missing references)
		//IL_40af: Expected Obj, but got I4
		//IL_39b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d81: Expected Obj, but got I
		//IL_4da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4db0: Expected Obj, but got Unknown
		//IL_4db9: Expected Obj, but got I4
		//IL_4dc2: Expected Obj, but got I4
		//IL_4dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ddb: Expected Obj, but got I4
		//IL_4cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cba: Expected F4, but got Unknown
		//IL_39a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_39c2: Expected F4, but got Unknown
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected F4, but got Unknown
		//IL_0d21: Expected Obj, but got I4
		//IL_09ab: Expected Obj, but got I
		//IL_4215: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I4
		//IL_0a0c: Expected Obj, but got I
		//IL_0a1e: Expected I4, but got Obj
		//IL_4e0b: Expected Obj, but got I
		//IL_4e1b: Expected Obj, but got I
		//IL_4e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e42: Expected Obj, but got Unknown
		//IL_4e4b: Expected Obj, but got I4
		//IL_4e54: Expected Obj, but got I4
		//IL_4e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e6d: Expected Obj, but got I4
		//IL_41d5: Expected Obj, but got I4
		//IL_40ea: Expected Obj, but got I
		//IL_40f2: Expected Obj, but got I4
		//IL_410c: Expected I4, but got Obj
		//IL_09f7: Expected Obj, but got I
		//IL_4129: Expected Obj, but got I
		//IL_4131: Unknown result type (might be due to invalid IL or missing references)
		//IL_413e: Expected Obj, but got Unknown
		//IL_4159: Unknown result type (might be due to invalid IL or missing references)
		//IL_4161: Expected Obj, but got Unknown
		//IL_416a: Expected Obj, but got I4
		//IL_4173: Expected Obj, but got I4
		//IL_4177: Unknown result type (might be due to invalid IL or missing references)
		//IL_417b: Unknown result type (might be due to invalid IL or missing references)
		//IL_417f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4187: Unknown result type (might be due to invalid IL or missing references)
		//IL_4194: Expected Obj, but got I4
		//IL_0a5d: Expected Obj, but got I
		//IL_0a65: Expected I4, but got Obj
		//IL_0e27: Expected I4, but got I8
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Expected Obj, but got Unknown
		//IL_0a85: Expected Obj, but got I4
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected Obj, but got Unknown
		//IL_0a9e: Expected Obj, but got I4
		//IL_0aa7: Expected Obj, but got I4
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected Obj, but got I4
		//IL_42b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Expected Obj, but got I
		//IL_0dbe: Expected Obj, but got I4
		//IL_15f1: Expected Obj, but got I
		//IL_1601: Expected Obj, but got I
		//IL_4239: Expected Obj, but got I
		//IL_425b: Expected Obj, but got I
		//IL_4288: Expected Obj, but got I
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected Obj, but got Unknown
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected Obj, but got I
		//IL_0b1f: Expected I4, but got Obj
		//IL_0b2f: Expected Obj, but got I
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected Obj, but got Unknown
		//IL_0b68: Expected Obj, but got I4
		//IL_0b71: Expected Obj, but got I4
		//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected Obj, but got I4
		//IL_0e44: Expected Obj, but got I
		//IL_0e4c: Expected I4, but got Obj
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected Obj, but got Unknown
		//IL_0e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected Obj, but got I4
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Expected I4, but got I8
		//IL_1693: Expected Obj, but got I4
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Expected Obj, but got Unknown
		//IL_4e8b: Expected Obj, but got I
		//IL_4ead: Expected Obj, but got I4
		//IL_0bb9: Expected Obj, but got I
		//IL_0bda: Expected Obj, but got I4
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0bfc: Expected Obj, but got I4
		//IL_0c05: Expected Obj, but got I4
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected Obj, but got I4
		//IL_42e5: Expected Obj, but got I4
		//IL_42e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_42fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4301: Unknown result type (might be due to invalid IL or missing references)
		//IL_4305: Unknown result type (might be due to invalid IL or missing references)
		//IL_4309: Unknown result type (might be due to invalid IL or missing references)
		//IL_4315: Unknown result type (might be due to invalid IL or missing references)
		//IL_4319: Unknown result type (might be due to invalid IL or missing references)
		//IL_433e: Expected Obj, but got I4
		//IL_4347: Expected Obj, but got I4
		//IL_434b: Unknown result type (might be due to invalid IL or missing references)
		//IL_434f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4353: Unknown result type (might be due to invalid IL or missing references)
		//IL_4357: Unknown result type (might be due to invalid IL or missing references)
		//IL_435b: Unknown result type (might be due to invalid IL or missing references)
		//IL_435f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Expected Obj, but got I
		//IL_0efb: Expected I4, but got Obj
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected Obj, but got Unknown
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got I4
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_47b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_47b5: Expected Obj, but got Unknown
		//IL_47be: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c3: Expected Obj, but got Unknown
		//IL_47cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d1: Expected Obj, but got Unknown
		//IL_47e1: Expected Obj, but got I
		//IL_0f12: Expected I, but got Obj
		//IL_0f22: Expected Obj, but got I
		//IL_0f32: Expected Obj, but got I
		//IL_0f42: Expected Obj, but got I
		//IL_0f76: Expected Obj, but got I4
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e8: Expected Obj, but got Unknown
		//IL_1706: Expected Obj, but got I
		//IL_1713: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Expected Obj, but got Unknown
		//IL_173c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1741: Expected Obj, but got Unknown
		//IL_1752: Unknown result type (might be due to invalid IL or missing references)
		//IL_1757: Expected Obj, but got Unknown
		//IL_1765: Expected I4, but got Obj
		//IL_1775: Expected Obj, but got I
		//IL_1785: Expected F4, but got I
		//IL_1789: Unknown result type (might be due to invalid IL or missing references)
		//IL_1792: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Expected Obj, but got I4
		//IL_0ffa: Expected Obj, but got I4
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected F4, but got I
		//IL_4eed: Expected Obj, but got I4
		//IL_1055: Expected Obj, but got I4
		//IL_1055: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected Obj, but got I4
		//IL_109f: Expected Obj, but got I4
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b6: Expected Obj, but got I4
		//IL_17d1: Expected Obj, but got I4
		//IL_17e2: Expected Obj, but got I4
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Expected Obj, but got Unknown
		//IL_1101: Expected Obj, but got I
		//IL_1109: Expected I4, but got Obj
		//IL_1119: Expected Obj, but got I
		//IL_1129: Expected Obj, but got I
		//IL_1140: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_1154: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1160: Unknown result type (might be due to invalid IL or missing references)
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1181: Expected Obj, but got I4
		//IL_118a: Expected Obj, but got I4
		//IL_118e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119a: Unknown result type (might be due to invalid IL or missing references)
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Expected Obj, but got I4
		//IL_11d4: Expected Obj, but got I4
		//IL_11ef: Expected Obj, but got I4
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1203: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1213: Unknown result type (might be due to invalid IL or missing references)
		//IL_1217: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1230: Expected Obj, but got I4
		//IL_1239: Expected Obj, but got I4
		//IL_123d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_185a: Expected Obj, but got I4
		//IL_1875: Expected Obj, but got I4
		//IL_1886: Expected Obj, but got I4
		//IL_128e: Expected Obj, but got I
		//IL_129e: Expected Obj, but got I
		//IL_18d8: Expected Obj, but got I4
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_1905: Expected Obj, but got Unknown
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_4394: Unknown result type (might be due to invalid IL or missing references)
		//IL_4399: Expected Obj, but got Unknown
		//IL_43b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_43b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_43bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_43bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_43c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_43c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_43cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_43cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_43db: Unknown result type (might be due to invalid IL or missing references)
		//IL_43df: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_43eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_4526: Unknown result type (might be due to invalid IL or missing references)
		//IL_452b: Expected Obj, but got Unknown
		//IL_12ee: Expected Obj, but got I4
		//IL_3b06: Expected Obj, but got I4
		//IL_3b0f: Expected Obj, but got I4
		//IL_3b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_196c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4445: Expected Obj, but got I4
		//IL_4460: Expected Obj, but got I4
		//IL_4460: Unknown result type (might be due to invalid IL or missing references)
		//IL_4464: Unknown result type (might be due to invalid IL or missing references)
		//IL_4468: Unknown result type (might be due to invalid IL or missing references)
		//IL_446c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4470: Unknown result type (might be due to invalid IL or missing references)
		//IL_4474: Unknown result type (might be due to invalid IL or missing references)
		//IL_4478: Unknown result type (might be due to invalid IL or missing references)
		//IL_447c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4480: Unknown result type (might be due to invalid IL or missing references)
		//IL_4484: Unknown result type (might be due to invalid IL or missing references)
		//IL_4488: Unknown result type (might be due to invalid IL or missing references)
		//IL_448c: Unknown result type (might be due to invalid IL or missing references)
		//IL_44a1: Expected Obj, but got I4
		//IL_44aa: Expected Obj, but got I4
		//IL_44ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_44ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_44be: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e5: Expected Obj, but got I
		//IL_23f5: Expected Obj, but got I
		//IL_23f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fe: Invalid comparison between Unknown and I4
		//IL_240f: Expected Obj, but got I4
		//IL_240f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2418: Invalid comparison between Unknown and I4
		//IL_242f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2434: Expected Obj, but got Unknown
		//IL_243c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected Obj, but got I
		//IL_132e: Expected Obj, but got I
		//IL_19ad: Expected Obj, but got I4
		//IL_134a: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_135e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Unknown result type (might be due to invalid IL or missing references)
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_138b: Expected Obj, but got I4
		//IL_1394: Expected Obj, but got I4
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4557: Expected Obj, but got I
		//IL_4567: Expected Obj, but got I
		//IL_458f: Expected Obj, but got I4
		//IL_4598: Expected Obj, but got I4
		//IL_45a1: Expected Obj, but got I4
		//IL_45a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_45a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_45bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_357c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3580: Unknown result type (might be due to invalid IL or missing references)
		//IL_358d: Expected Obj, but got I4
		//IL_13e4: Expected Obj, but got I
		//IL_13f5: Expected Obj, but got I
		//IL_1410: Unknown result type (might be due to invalid IL or missing references)
		//IL_1414: Unknown result type (might be due to invalid IL or missing references)
		//IL_1418: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_1434: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Unknown result type (might be due to invalid IL or missing references)
		//IL_143c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1451: Expected Obj, but got I4
		//IL_145a: Expected Obj, but got I4
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1462: Unknown result type (might be due to invalid IL or missing references)
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Unknown result type (might be due to invalid IL or missing references)
		//IL_146e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_248e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2498: Unknown result type (might be due to invalid IL or missing references)
		//IL_249c: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24cf: Expected Obj, but got I4
		//IL_24cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e7: Expected Obj, but got I
		//IL_1a08: Expected Obj, but got I4
		//IL_1a19: Expected Obj, but got I4
		//IL_1a22: Expected Obj, but got I4
		//IL_1a2b: Expected Obj, but got I4
		//IL_1a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f48: Expected I4, but got Obj
		//IL_4f88: Expected Obj, but got I4
		//IL_14b5: Expected Obj, but got I4
		//IL_14b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected Obj, but got I4
		//IL_14ff: Expected Obj, but got I4
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_150b: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4812: Expected Obj, but got I
		//IL_4822: Expected Obj, but got I
		//IL_4839: Unknown result type (might be due to invalid IL or missing references)
		//IL_483d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4841: Unknown result type (might be due to invalid IL or missing references)
		//IL_4845: Unknown result type (might be due to invalid IL or missing references)
		//IL_4849: Unknown result type (might be due to invalid IL or missing references)
		//IL_484d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4851: Unknown result type (might be due to invalid IL or missing references)
		//IL_4855: Unknown result type (might be due to invalid IL or missing references)
		//IL_4859: Unknown result type (might be due to invalid IL or missing references)
		//IL_485d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4872: Expected Obj, but got I4
		//IL_487b: Expected Obj, but got I4
		//IL_487f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4883: Unknown result type (might be due to invalid IL or missing references)
		//IL_4887: Unknown result type (might be due to invalid IL or missing references)
		//IL_4893: Unknown result type (might be due to invalid IL or missing references)
		//IL_489b: Expected F4, but got Unknown
		//IL_1a8e: Expected Obj, but got I
		//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1554: Expected Obj, but got Unknown
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_155c: Expected Obj, but got Unknown
		//IL_155c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_157b: Expected Obj, but got I
		//IL_1583: Expected I4, but got Obj
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Unknown result type (might be due to invalid IL or missing references)
		//IL_158b: Unknown result type (might be due to invalid IL or missing references)
		//IL_158f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1593: Unknown result type (might be due to invalid IL or missing references)
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_159f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_250a: Expected Obj, but got I4
		//IL_2525: Expected Obj, but got I4
		//IL_2525: Unknown result type (might be due to invalid IL or missing references)
		//IL_2529: Unknown result type (might be due to invalid IL or missing references)
		//IL_252d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2531: Unknown result type (might be due to invalid IL or missing references)
		//IL_2535: Unknown result type (might be due to invalid IL or missing references)
		//IL_2539: Unknown result type (might be due to invalid IL or missing references)
		//IL_253d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2541: Unknown result type (might be due to invalid IL or missing references)
		//IL_2545: Unknown result type (might be due to invalid IL or missing references)
		//IL_2549: Unknown result type (might be due to invalid IL or missing references)
		//IL_255e: Expected Obj, but got I4
		//IL_2567: Expected Obj, but got I4
		//IL_256b: Unknown result type (might be due to invalid IL or missing references)
		//IL_256f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2573: Unknown result type (might be due to invalid IL or missing references)
		//IL_257f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2587: Expected F4, but got Unknown
		//IL_1af5: Expected Obj, but got I4
		//IL_1afe: Expected Obj, but got I4
		//IL_1b07: Expected Obj, but got I4
		//IL_1b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b2: Expected Obj, but got Unknown
		//IL_25b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d6: Expected Obj, but got I
		//IL_25d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25da: Unknown result type (might be due to invalid IL or missing references)
		//IL_25de: Unknown result type (might be due to invalid IL or missing references)
		//IL_25e3: Expected Obj, but got Unknown
		//IL_2613: Unknown result type (might be due to invalid IL or missing references)
		//IL_2617: Unknown result type (might be due to invalid IL or missing references)
		//IL_2632: Unknown result type (might be due to invalid IL or missing references)
		//IL_2646: Invalid comparison between F4 and I
		//IL_264f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2653: Unknown result type (might be due to invalid IL or missing references)
		//IL_265b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5f: Expected Obj, but got I4
		//IL_1b7a: Expected Obj, but got I4
		//IL_1b8b: Expected Obj, but got I4
		//IL_1b94: Expected Obj, but got I4
		//IL_1b9d: Expected Obj, but got I4
		//IL_1ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_48dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_48e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_48e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_48e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_267d: Expected Obj, but got I
		//IL_269f: Expected Obj, but got I4
		//IL_26af: Expected Obj, but got I
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf9: Expected Obj, but got Unknown
		//IL_1c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_3546: Expected Obj, but got I
		//IL_3546: Unknown result type (might be due to invalid IL or missing references)
		//IL_354a: Unknown result type (might be due to invalid IL or missing references)
		//IL_354e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3552: Unknown result type (might be due to invalid IL or missing references)
		//IL_3567: Expected Obj, but got I4
		//IL_2795: Expected Obj, but got I4
		//IL_27b0: Expected Obj, but got I4
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e1: Expected Obj, but got I4
		//IL_27ea: Expected Obj, but got I4
		//IL_27ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e4: Expected Obj, but got I
		//IL_26f4: Expected Obj, but got I
		//IL_270b: Unknown result type (might be due to invalid IL or missing references)
		//IL_270f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2713: Unknown result type (might be due to invalid IL or missing references)
		//IL_2717: Unknown result type (might be due to invalid IL or missing references)
		//IL_271b: Unknown result type (might be due to invalid IL or missing references)
		//IL_271f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2727: Unknown result type (might be due to invalid IL or missing references)
		//IL_273c: Expected Obj, but got I4
		//IL_2745: Expected Obj, but got I4
		//IL_2749: Unknown result type (might be due to invalid IL or missing references)
		//IL_274d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2751: Unknown result type (might be due to invalid IL or missing references)
		//IL_276d: Expected Obj, but got I
		//IL_1c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb2: Expected Obj, but got I4
		//IL_2830: Unknown result type (might be due to invalid IL or missing references)
		//IL_2835: Expected Obj, but got Unknown
		//IL_2847: Expected Obj, but got F4
		//IL_2857: Expected Obj, but got I
		//IL_286e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2872: Unknown result type (might be due to invalid IL or missing references)
		//IL_2876: Unknown result type (might be due to invalid IL or missing references)
		//IL_287a: Unknown result type (might be due to invalid IL or missing references)
		//IL_287e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2882: Unknown result type (might be due to invalid IL or missing references)
		//IL_288a: Unknown result type (might be due to invalid IL or missing references)
		//IL_289f: Expected Obj, but got I4
		//IL_28a8: Expected Obj, but got I4
		//IL_28ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_471f: Expected Obj, but got I
		//IL_472f: Expected Obj, but got I
		//IL_4757: Expected Obj, but got I4
		//IL_4760: Expected Obj, but got I4
		//IL_4769: Expected Obj, but got I4
		//IL_476d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4771: Unknown result type (might be due to invalid IL or missing references)
		//IL_4775: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f2d: Expected Obj, but got I4
		//IL_45ff: Expected Obj, but got I
		//IL_28ee: Expected Obj, but got I
		//IL_290f: Expected Obj, but got I4
		//IL_290f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2913: Unknown result type (might be due to invalid IL or missing references)
		//IL_2917: Unknown result type (might be due to invalid IL or missing references)
		//IL_291b: Unknown result type (might be due to invalid IL or missing references)
		//IL_291f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2923: Unknown result type (might be due to invalid IL or missing references)
		//IL_292b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2940: Expected Obj, but got I4
		//IL_2949: Expected Obj, but got I4
		//IL_294d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2951: Unknown result type (might be due to invalid IL or missing references)
		//IL_2955: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ca: Expected Obj, but got I
		//IL_21eb: Expected Obj, but got I4
		//IL_21fc: Expected Obj, but got I4
		//IL_2205: Expected Obj, but got I4
		//IL_220e: Expected Obj, but got I4
		//IL_2212: Unknown result type (might be due to invalid IL or missing references)
		//IL_2216: Unknown result type (might be due to invalid IL or missing references)
		//IL_221a: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f5: Expected Obj, but got I4
		//IL_1ce2: Expected Obj, but got I
		//IL_1cea: Expected I4, but got Obj
		//IL_1cff: Expected Obj, but got I
		//IL_1d20: Expected Obj, but got I4
		//IL_298d: Expected Obj, but got I4
		//IL_299d: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a2: Expected Obj, but got Unknown
		//IL_29a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2261: Expected Obj, but got I
		//IL_226a: Unknown result type (might be due to invalid IL or missing references)
		//IL_226f: Expected Obj, but got Unknown
		//IL_227f: Expected VT, but got I
		//IL_2299: Unknown result type (might be due to invalid IL or missing references)
		//IL_229e: Expected Obj, but got Unknown
		//IL_22ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b3: Expected Obj, but got Unknown
		//IL_22b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c8: Expected Obj, but got Unknown
		//IL_22c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dd: Expected Obj, but got Unknown
		//IL_22fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ff: Expected Obj, but got Unknown
		//IL_232f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2343: Unknown result type (might be due to invalid IL or missing references)
		//IL_2348: Expected Obj, but got Unknown
		//IL_2358: Unknown result type (might be due to invalid IL or missing references)
		//IL_235d: Expected Obj, but got Unknown
		//IL_2366: Unknown result type (might be due to invalid IL or missing references)
		//IL_237a: Unknown result type (might be due to invalid IL or missing references)
		//IL_237f: Expected Obj, but got Unknown
		//IL_237f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2383: Unknown result type (might be due to invalid IL or missing references)
		//IL_2387: Unknown result type (might be due to invalid IL or missing references)
		//IL_2388: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_490b: Expected Obj, but got I
		//IL_4923: Expected Obj, but got I
		//IL_4927: Unknown result type (might be due to invalid IL or missing references)
		//IL_493b: Expected F4, but got I
		//IL_494e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4952: Unknown result type (might be due to invalid IL or missing references)
		//IL_4956: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3b: Expected Obj, but got Unknown
		//IL_1d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_464b: Unknown result type (might be due to invalid IL or missing references)
		//IL_464f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4653: Unknown result type (might be due to invalid IL or missing references)
		//IL_4657: Unknown result type (might be due to invalid IL or missing references)
		//IL_465b: Unknown result type (might be due to invalid IL or missing references)
		//IL_465f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4663: Unknown result type (might be due to invalid IL or missing references)
		//IL_4667: Unknown result type (might be due to invalid IL or missing references)
		//IL_466b: Unknown result type (might be due to invalid IL or missing references)
		//IL_466f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4683: Unknown result type (might be due to invalid IL or missing references)
		//IL_4687: Unknown result type (might be due to invalid IL or missing references)
		//IL_3426: Expected Obj, but got I
		//IL_29c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_29cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f3: Expected Obj, but got I4
		//IL_29f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a30: Expected F4, but got I
		//IL_1d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd2: Expected Obj, but got I4
		//IL_1de2: Expected Obj, but got I
		//IL_4ba1: Expected Obj, but got I
		//IL_4bb1: Expected Obj, but got I
		//IL_4bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bf1: Expected Obj, but got I4
		//IL_4bfa: Expected Obj, but got I4
		//IL_4bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3409: Expected Obj, but got I
		//IL_4fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0a: Expected Obj, but got I4
		//IL_1e25: Expected Obj, but got I4
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e66: Expected Obj, but got I4
		//IL_345a: Expected Obj, but got I
		//IL_347b: Expected Obj, but got I4
		//IL_347b: Unknown result type (might be due to invalid IL or missing references)
		//IL_347f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3483: Unknown result type (might be due to invalid IL or missing references)
		//IL_3487: Unknown result type (might be due to invalid IL or missing references)
		//IL_348b: Unknown result type (might be due to invalid IL or missing references)
		//IL_348f: Unknown result type (might be due to invalid IL or missing references)
		//IL_34a4: Expected Obj, but got I4
		//IL_34ad: Expected Obj, but got I4
		//IL_34b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3f: Expected Obj, but got I4
		//IL_2a67: Expected Obj, but got I4
		//IL_2a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e96: Expected Obj, but got Unknown
		//IL_1ea6: Expected Obj, but got I
		//IL_1ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efe: Expected Obj, but got I4
		//IL_34f9: Expected Obj, but got I4
		//IL_3509: Unknown result type (might be due to invalid IL or missing references)
		//IL_350e: Expected Obj, but got Unknown
		//IL_350e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3518: Unknown result type (might be due to invalid IL or missing references)
		//IL_351c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3529: Expected Obj, but got I4
		//IL_2b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2c: Expected Obj, but got I
		//IL_1f4d: Expected Obj, but got I4
		//IL_1f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8e: Expected Obj, but got I4
		//IL_2b8e: Expected Obj, but got I4
		//IL_2ba9: Expected Obj, but got I4
		//IL_2bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Expected Obj, but got Unknown
		//IL_1fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcf: Expected Obj, but got Unknown
		//IL_1fdf: Expected Obj, but got I
		//IL_1feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fff: Expected F4, but got I
		//IL_2021: Expected Obj, but got I4
		//IL_2c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_46a9: Expected Obj, but got I
		//IL_46c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_46c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_46cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_46d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_46dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f1: Expected Obj, but got I4
		//IL_4979: Unknown result type (might be due to invalid IL or missing references)
		//IL_497e: Expected Obj, but got Unknown
		//IL_49b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_49bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_49bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_49c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_49cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_49d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_49db: Unknown result type (might be due to invalid IL or missing references)
		//IL_49df: Unknown result type (might be due to invalid IL or missing references)
		//IL_49e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2049: Expected Obj, but got I
		//IL_2051: Expected I4, but got Obj
		//IL_2c8b: Expected Obj, but got I
		//IL_2066: Expected Obj, but got I
		//IL_2087: Expected Obj, but got I4
		//IL_2087: Unknown result type (might be due to invalid IL or missing references)
		//IL_208b: Unknown result type (might be due to invalid IL or missing references)
		//IL_208f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2093: Unknown result type (might be due to invalid IL or missing references)
		//IL_209f: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b8: Expected Obj, but got I4
		//IL_2cc4: Expected Obj, but got I
		//IL_2ccc: Expected I4, but got Obj
		//IL_2cee: Expected Obj, but got I4
		//IL_20de: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e3: Expected Obj, but got Unknown
		//IL_20e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f0: Expected Obj, but got Unknown
		//IL_2100: Unknown result type (might be due to invalid IL or missing references)
		//IL_2101: Unknown result type (might be due to invalid IL or missing references)
		//IL_2105: Unknown result type (might be due to invalid IL or missing references)
		//IL_210d: Unknown result type (might be due to invalid IL or missing references)
		//IL_210e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2112: Unknown result type (might be due to invalid IL or missing references)
		//IL_2116: Unknown result type (might be due to invalid IL or missing references)
		//IL_211a: Unknown result type (might be due to invalid IL or missing references)
		//IL_211b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2127: Unknown result type (might be due to invalid IL or missing references)
		//IL_212b: Unknown result type (might be due to invalid IL or missing references)
		//IL_212f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2133: Unknown result type (might be due to invalid IL or missing references)
		//IL_2137: Unknown result type (might be due to invalid IL or missing references)
		//IL_213b: Unknown result type (might be due to invalid IL or missing references)
		//IL_214f: Expected Obj, but got I
		//IL_4a2d: Expected Obj, but got I
		//IL_4a3d: Expected Obj, but got I
		//IL_4a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d16: Expected Obj, but got I
		//IL_2d1e: Expected I4, but got Obj
		//IL_2d2d: Expected Obj, but got I4
		//IL_2d48: Expected Obj, but got I4
		//IL_2d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd3: Expected Obj, but got Unknown
		//IL_2de3: Expected Obj, but got I
		//IL_2e2a: Expected Obj, but got I4
		//IL_4ada: Expected Obj, but got I
		//IL_4b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b52: Expected Obj, but got I4
		//IL_4b5b: Expected Obj, but got I4
		//IL_4b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e52: Expected Obj, but got I
		//IL_2e6a: Expected Obj, but got I
		//IL_2ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef1: Expected Obj, but got I4
		//IL_2efa: Expected Obj, but got I4
		//IL_2efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4b: Expected Obj, but got I4
		//IL_2f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fac: Expected Obj, but got I4
		//IL_2fb5: Expected Obj, but got I4
		//IL_2fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3006: Expected Obj, but got I4
		//IL_3016: Unknown result type (might be due to invalid IL or missing references)
		//IL_301a: Unknown result type (might be due to invalid IL or missing references)
		//IL_301e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3022: Unknown result type (might be due to invalid IL or missing references)
		//IL_3026: Unknown result type (might be due to invalid IL or missing references)
		//IL_302a: Unknown result type (might be due to invalid IL or missing references)
		//IL_302e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3032: Unknown result type (might be due to invalid IL or missing references)
		//IL_303e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3042: Unknown result type (might be due to invalid IL or missing references)
		//IL_3046: Unknown result type (might be due to invalid IL or missing references)
		//IL_304a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3067: Expected Obj, but got I4
		//IL_3070: Expected Obj, but got I4
		//IL_3074: Unknown result type (might be due to invalid IL or missing references)
		//IL_3078: Unknown result type (might be due to invalid IL or missing references)
		//IL_307c: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_30db: Unknown result type (might be due to invalid IL or missing references)
		//IL_30df: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_30eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3103: Unknown result type (might be due to invalid IL or missing references)
		//IL_3107: Unknown result type (might be due to invalid IL or missing references)
		//IL_310b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3128: Expected Obj, but got I4
		//IL_3131: Expected Obj, but got I4
		//IL_3135: Unknown result type (might be due to invalid IL or missing references)
		//IL_3139: Unknown result type (might be due to invalid IL or missing references)
		//IL_313d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3171: Expected Obj, but got I4
		//IL_318c: Expected Obj, but got I4
		//IL_319c: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e5: Expected Obj, but got I4
		//IL_31ee: Expected Obj, but got I4
		//IL_31f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_322c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3231: Expected Obj, but got Unknown
		//IL_32aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_32af: Expected Obj, but got Unknown
		//IL_32c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ce: Expected Obj, but got Unknown
		//IL_32de: Expected VT, but got I
		//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3329: Unknown result type (might be due to invalid IL or missing references)
		//IL_332e: Expected Obj, but got Unknown
		//IL_3332: Unknown result type (might be due to invalid IL or missing references)
		//IL_3336: Unknown result type (might be due to invalid IL or missing references)
		//IL_333b: Expected Obj, but got Unknown
		//IL_3354: Unknown result type (might be due to invalid IL or missing references)
		//IL_3361: Unknown result type (might be due to invalid IL or missing references)
		//IL_3375: Unknown result type (might be due to invalid IL or missing references)
		//IL_3376: Unknown result type (might be due to invalid IL or missing references)
		//IL_337a: Unknown result type (might be due to invalid IL or missing references)
		//IL_337e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3382: Unknown result type (might be due to invalid IL or missing references)
		//IL_3383: Unknown result type (might be due to invalid IL or missing references)
		//IL_338c: Unknown result type (might be due to invalid IL or missing references)
		//IL_33a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		Transform[] array = (Transform[])0;
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2 (Il2CppClass<UnityEngine.Transform[]>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body == null;
		bool flag3 = at == null;
		float num2 = 2.139095E+09f;
		Enumerator<, > val;
		List<Vector3> list;
		int num3;
		int num4;
		if (!flag3)
		{
			bool flag4 = !flag2;
			object obj2 = !flag4;
			num2 = 2.139095E+09f;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				if ((nint)0 == 0)
				{
					goto IL_39c7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
				num3 = 0;
				int value = ((int*)num3)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v115 (System.Int32)+E4]");
				bool flag5 = (nint)0 == 0;
				object obj3 = !flag5;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value = ((int*)num3)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v115 (System.Int32)+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v10+30]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v10+30]");
				bool flag6 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				num2 = 2.139095E+09f;
				num4 = 0;
				int num5 = 0;
				list = at;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v11+18]");
					Transform[] array2 = default;
					if (num6 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						int value2 = ((int*)num3)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v289 (System.Int32)+E4]");
						array2 = (Transform[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v289 (System.Int32)+E4]");
						bool flag7 = (nint)0 == 0;
						object obj7 = !flag7;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							value2 = ((int*)num3)->m_value;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v289 (System.Int32)+A0]");
						object obj8 = (nint)0 + (nint)48;
						GillaSlice.Points points = default;
						obj8 = points;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						int value3 = ((int*)num3)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v290 (System.Int32)+A0]");
						object obj10 = (nint)0 + (nint)56;
						object obj11 = default;
						obj10 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						int value4 = ((int*)num3)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v293 (System.Int32)+A0]");
						object obj12 = (nint)0 + (nint)64;
						object obj13 = default;
						obj12 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						num5 = 0;
						value = ((int*)num3)->m_value;
					}
					if (num5 < 1)
					{
						goto IL_0343;
					}
					Transform[] array3 = array2;
					int num7 = value;
					object obj14 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X0_v302 (System.Int32)+E4]");
						bool flag8 = (nint)0 == 0;
						object obj15 = !flag8;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num7 = ((int*)num3)->m_value;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X0_v302 (System.Int32)+A0]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v282+30]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v282+30]");
						bool flag9 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						array2 = array3;
						num2 = 2.139095E+09f;
						num4 = 0;
						list = at;
						if (flag9)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v283+18]");
						array2 = (Transform[])0;
						object obj18 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v283+18]");
						bool flag10 = (nint)obj18 < 0;
						object obj19 = !flag10;
						val = (Enumerator<, >)0;
						num2 = 2.139095E+09f;
						num4 = 0;
						list = at;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v282+30]");
							object obj20 = 0 + obj14;
							obj14++;
							_ = 2139095039;
							object obj21 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							bool flag11 = (nint)obj21 < 0;
							value = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v283+18]");
							array3 = (Transform[])0;
							if (flag11)
							{
								continue;
							}
							goto IL_0343;
						}
						goto IL_3b32;
					}
				}
				goto IL_3b24;
			}
		}
		goto IL_3e33;
		IL_3b40:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_3b4e;
		IL_3c12:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_3c20;
		IL_3c20:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_3c2e;
		IL_3c4a:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_3c58;
		IL_3b32:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_3b40;
		IL_3b24:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_3b32;
		IL_3c58:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_3c66;
		IL_3b94:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_3ba2;
		IL_3be8:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_3bf6;
		IL_3d00:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_3d0e;
		IL_3cf2:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_3d00;
		IL_3b4e:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		goto IL_3b5c;
		IL_3cd6:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_3ce4;
		IL_3d0e:
		throw new NullReferenceException();
		IL_3cba:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_3cc8;
		IL_35ff:
		object obj22;
		if ((nint)obj22 != 34)
		{
			bool flag12 = obj22 == null;
			object obj23 = !flag12;
			if (obj23 != null)
			{
				goto IL_3e33;
			}
		}
		object obj25;
		object obj24 = obj25 & 1;
		object obj42 = default;
		Enumerator<, > val9;
		Enumerator<, > val8 = default;
		Material[] array4;
		Enumerator<, > val7 = default;
		Enumerator<, > val4;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5674 @ X26_v71 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)0 >= (nint)1)
			{
				int value5 = ((int*)num3)->m_value;
				num2 = 2.139095E+09f;
				int num8 = 0;
				object obj26 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v14 (System.Int32)+E4]");
					bool flag13 = (nint)0 == 0;
					object obj27 = !flag13;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						value5 = ((int*)num3)->m_value;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v14 (System.Int32)+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3228 @ X8_v21+30]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3228 @ X8_v21+30]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v22+18]");
					Transform[] array2 = (Transform[])0;
					int num9 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v22+18]");
					bool flag14 = (nint)num9 < (nint)0;
					object obj30 = !flag14;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3228 @ X8_v21+30]");
						object obj31 = (nint)0 + (nint)num8;
						num4 = (int)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3404 @ X8_v23+20]");
						Enumerator<, > val2 = (Enumerator<, >)0;
						Vector3 vector = list.get_Item(num8);
						value5 = ((int*)num3)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v14 (System.Int32)+A0]");
						array2 = (Transform[])0;
						Transform transform = array2[3];
						bool flag15 = (object)array2[3] == null;
						int num5 = num8;
						if (flag15)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v24 (UnityEngine.Transform)+18]");
						Vector3[] array5 = (Vector3[])0;
						int num10 = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v24 (UnityEngine.Transform)+18]");
						bool flag16 = (nint)num10 < (nint)0;
						object obj32 = !flag16;
						num5 = num8;
						if (obj32 == null)
						{
							array2 = (Transform[])(object)array2[4];
							bool flag17 = (object)array2[4] == null;
							num5 = num8;
							if (flag17)
							{
								break;
							}
							array5 = (Vector3[])array2.Length;
							bool flag18 = num8 < array2.Length;
							object obj33 = !flag18;
							num5 = num8;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								object obj34 = (object)array2[3] + obj26;
								object obj35 = (object)array2[4] + obj26;
								int num11 = num8 + 1;
								obj26 += 12;
								Enumerator<, > val3 = val4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3822 @ X8_v25+20]");
								object obj36 = val3 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3825 @ X8_v26+20]");
								Enumerator<, > val5 = (Enumerator<, >)0;
								Enumerator<, > val6 = val7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3822 @ X8_v25+24]");
								object obj37 = val6 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3825 @ X8_v26+24]");
								Vector3 vector2 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3825 @ X8_v26+20]");
								object obj38 = obj36 * 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3825 @ X8_v26+24]");
								object obj39 = obj37 * 0;
								object obj40 = obj38 + obj39;
								object obj41 = obj42 + obj40;
								val7 = (Enumerator<, >)(0 - val8);
								val4 = (((nint)obj41 >= 0) ? val8 : val7);
								val9 = ((!((float)val4 < num2)) ? ((Enumerator<, >)num2) : val4);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5674 @ X26_v71 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								bool flag19 = (nint)num11 < (nint)0;
								num2 = (float)val9;
								num5 = num8;
								num8 = num11;
								if (flag19)
								{
									continue;
								}
								goto IL_39ba;
							}
						}
					}
					goto IL_3b32;
				}
				goto IL_3b24;
			}
		}
		goto IL_39c7;
		IL_3bbe:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_3bcc;
		IL_39ba:
		num2 = (float)val9;
		goto IL_3e33;
		IL_0343:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v115 (System.Int32)+E4]");
		bool flag20 = (nint)0 == 0;
		object obj43 = !flag20;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int value = ((int*)num3)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v115 (System.Int32)+A0]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X8_v74+18]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X8_v74+18]");
		bool flag21 = (nint)0 == 0;
		val = (Enumerator<, >)0;
		num2 = 2.139095E+09f;
		num4 = 0;
		list = at;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v75+18]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v75+1C]");
			Transform[] array2 = (Transform[])((nint)0 + (nint)1);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v75+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v75+10]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v75+18]");
				Array.Clear((Array)num12, 0, 0);
				nint num13 = unchecked((nint)null);
				int num5 = 0;
			}
			bool flag22 = (object)body == null;
			val = (Enumerator<, >)0;
			num2 = 2.139095E+09f;
			list = at;
			if (!flag22)
			{
				int value6 = ((int*)num3)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1309 @ X8_v76 (System.Int32)+A0]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7338]");
				array2 = (Transform[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ X8_v77+18]");
				num4 = 0;
				nint num13 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FAAC");
				int value7 = ((int*)num3)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1390 @ X8_v78 (System.Int32)+A0]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v79+18]");
				bool flag23 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				num2 = 2.139095E+09f;
				int num5 = 0;
				list = at;
				if (!flag23)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v79+18]");
					Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D78]");
					Material[] array6 = (Material[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
					array4 = (Material[])0;
					Enumerator<, > val10 = default;
					val4 = val10;
					obj25 = 0;
					Enumerator<, > val11 = val10;
					num2 = 2.139095E+09f;
					list = at;
					Enumerator<, > val12 = default;
					UnityEngine.Object obj57 = default;
					int num18 = default;
					float num28 = default;
					Enumerator<, > val16 = default;
					object obj122 = default;
					object obj128 = default;
					object obj130 = default;
					object obj135 = default;
					object obj148 = default;
					Transform transform3 = default;
					Vector3 vector2 = default;
					Enumerator<, > val27 = default;
					object obj179 = default;
					object obj184 = default;
					Enumerator<, > val18 = default;
					object obj196 = default;
					Renderer renderer2 = default;
					object obj208 = default;
					Vector3[] array5 = default;
					Enumerator<, > val46 = default;
					Enumerator<, > val47 = default;
					Enumerator<, > val48 = default;
					Enumerator<, > val35 = default;
					Enumerator<, > val37 = default;
					Enumerator<, > val5 = default;
					Enumerator<, > val40 = default;
					Enumerator<, > val42 = default;
					while (true)
					{
						num5 = (int)array6;
						GillaSlice.Points points2;
						Transform[] bones;
						int num16;
						object obj67;
						float num21;
						Renderer renderer;
						Material[] array7;
						int num17;
						object obj48;
						object obj49;
						Enumerator<, > val13;
						if (val.MoveNext())
						{
							bool flag24 = (int)val12 == 0;
							renderer = (Renderer)val12;
							obj48 = 0;
							obj49 = 0;
							val13 = (Enumerator<, >)(ref val);
							val = val10;
							if (flag24)
							{
								break;
							}
							bool enabled = ((Renderer)val12).enabled;
							bool flag25 = !enabled;
							renderer = (Renderer)val12;
							if (flag25)
							{
								continue;
							}
							bool forceRenderingOff = ((Renderer)val12).forceRenderingOff;
							bool flag26 = !forceRenderingOff;
							object obj50 = !flag26;
							renderer = (Renderer)val12;
							if (obj50 != null)
							{
								continue;
							}
							Mesh sharedMesh = ((SkinnedMeshRenderer)val12).sharedMesh;
							nint num14 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2779 @ X0_v129 (Il2CppClass<UnityEngine.Transform[]>)+E4]");
							bool flag27 = (nint)0 == 0;
							object obj51 = !flag27;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag28 = sharedMesh == null;
							bool flag29 = !flag28;
							object obj52 = !flag29;
							renderer = (Renderer)val12;
							num4 = 0;
							if (obj52 != null)
							{
								continue;
							}
							string name = ((UnityEngine.Object)val12).name;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4278]");
							object obj53 = 0;
							bool flag30 = name == (string)obj53;
							bool flag31 = !flag30;
							object obj54 = !flag31;
							renderer = (Renderer)val12;
							num4 = 0;
							if (obj54 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7330]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
							nint num15 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3483 @ X0_v138 (Il2CppClass<UnityEngine.Transform[]>)+E4]");
							bool flag32 = (nint)0 == 0;
							object obj56 = !flag32;
							if (obj56 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag33 = obj57 != null;
							bool flag34 = !flag33;
							object obj58 = !flag34;
							renderer = (Renderer)val12;
							num4 = 0;
							if (obj58 != null)
							{
								continue;
							}
							Mesh sharedMesh2 = ((SkinnedMeshRenderer)val12).sharedMesh;
							Material[] sharedMaterials = ((Renderer)val12).sharedMaterials;
							int value8 = ((int*)num3)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3919 @ X0_v146 (System.Int32)+E4]");
							bool flag35 = (nint)0 == 0;
							object obj59 = !flag35;
							if (obj59 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							points2 = Of(sharedMesh2, sharedMaterials);
							bones = ((SkinnedMeshRenderer)val12).bones;
							bool flag36 = points2 == null;
							array7 = sharedMaterials;
							renderer = (Renderer)val12;
							num4 = 0;
							if (flag36)
							{
								continue;
							}
							bool flag37 = bones == null;
							array7 = sharedMaterials;
							renderer = (Renderer)val12;
							num4 = 0;
							if (flag37)
							{
								continue;
							}
							bool flag38 = bones.Length == 0;
							array7 = sharedMaterials;
							renderer = (Renderer)val12;
							num4 = 0;
							if (flag38)
							{
								continue;
							}
							Vector3[][] shape = points2.shape;
							num16 = ((points2.shape != null) ? shape.Length : 0);
							int value9 = ((int*)num3)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
							bool flag39 = (nint)0 == 0;
							object obj60 = !flag39;
							if (obj60 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								value9 = ((int*)num3)->m_value;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
							object obj61 = 0;
							object obj62 = obj61;
							bool flag40 = obj61 == null;
							num17 = num16;
							array7 = sharedMaterials;
							renderer = (Renderer)val12;
							obj48 = 0;
							obj49 = 0;
							val13 = (Enumerator<, >)(ref val);
							val = val10;
							array6 = (Material[])1120403456;
							num4 = 0;
							num5 = 0;
							if (flag40)
							{
								goto IL_3d36;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2851 @ X8_v99+18]");
							bool flag41 = (nint)num16 <= (nint)0;
							num5 = 0;
							if (!flag41)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
								object obj63 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								int value10 = ((int*)num3)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4432 @ X0_v287 (System.Int32)+E4]");
								object obj64;
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
									obj64 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
									obj64 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									value10 = (int)obj64;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4432 @ X0_v287 (System.Int32)+A0]");
								object obj65 = 0;
								obj65 = num18;
								object obj66 = obj64;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								value9 = (int)obj64;
								num5 = num18;
							}
							if (num16 >= 1)
							{
								num3 = 0;
								int num19 = 0;
								obj67 = 0;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
									bool flag42 = (nint)0 == 0;
									object obj68 = !flag42;
									if (obj68 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
										object obj69 = 0;
										value9 = (int)obj69;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
									object obj70 = 0;
									array7 = (Material[])obj70;
									float blendShapeWeight = ((SkinnedMeshRenderer)val12).GetBlendShapeWeight(num3);
									bool flag43 = obj70 == null;
									num17 = num16;
									renderer = (Renderer)val12;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									val4 = (Enumerator<, >)blendShapeWeight;
									array6 = (Material[])1120403456;
									num4 = 0;
									num5 = num3;
									if (flag43)
									{
										break;
									}
									bool flag44 = num3 < array7.Length;
									object obj71 = !flag44;
									num17 = num16;
									renderer = (Renderer)val12;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									val4 = (Enumerator<, >)blendShapeWeight;
									array6 = (Material[])1120403456;
									num4 = 0;
									num5 = num3;
									if (obj71 != null)
									{
										goto IL_3c58;
									}
									object obj72 = obj70 + num3;
									val4 = (Enumerator<, >)(blendShapeWeight / 1120403456);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
									object obj73 = 0;
									value9 = (int)obj73;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
									object obj74 = 0;
									object obj75 = obj74;
									bool flag45 = obj74 == null;
									val7 = (Enumerator<, >)1120403456;
									num17 = num16;
									renderer = (Renderer)val12;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									array6 = (Material[])1120403456;
									num4 = 0;
									num5 = num3;
									if (flag45)
									{
										goto IL_3c74;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3478 @ X8_v270+18]");
									array2 = (Transform[])0;
									int num20 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3478 @ X8_v270+18]");
									bool flag46 = (nint)num20 < (nint)0;
									object obj76 = !flag46;
									val7 = (Enumerator<, >)1120403456;
									num17 = num16;
									renderer = (Renderer)val12;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									array6 = (Material[])1120403456;
									num4 = 0;
									num5 = num3;
									if (obj76 == null)
									{
										object obj77 = obj74 + num3;
										num3++;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4550 @ X8_v271+20]");
										val4 = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4550 @ X8_v271+20]");
										bool flag47 = (nint)0 == 0;
										object obj78 = !flag47;
										obj67 |= obj78;
										bool flag48 = num16 != num3;
										val7 = (Enumerator<, >)1120403456;
										num19 = 0;
										num5 = num3;
										if (flag48)
										{
											continue;
										}
										goto IL_0cd0;
									}
									goto IL_3c82;
								}
								goto IL_3c66;
							}
							array7 = sharedMaterials;
							num21 = (float)val4;
							num4 = 0;
							obj67 = 0;
							goto IL_41e3;
						}
						obj48 = 0;
						obj49 = 0;
						val13 = (Enumerator<, >)(ref val);
						obj22 = 34;
						goto IL_4cf8;
						IL_15d1:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
						array4 = (Material[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D78]");
						array6 = (Material[])0;
						bool flag49 = points2.count < 1;
						num17 = num16;
						list = at;
						if (flag49)
						{
							continue;
						}
						bool flag50 = num16 < 0;
						bool flag51 = num16 == 0;
						int num22 = num16 ^ num16;
						int num23 = num16 & num22;
						bool flag52 = num23 < 0;
						bool flag53 = flag50 == flag52;
						object obj79 = !flag51;
						object obj80 = flag53 & obj79;
						List<Vector3> list2 = (List<Vector3>)(obj67 & obj80);
						num17 = num16;
						Material[] array8 = null;
						renderer = null;
						array2 = null;
						list = at;
						Transform[] array9 = null;
						int num25;
						while (true)
						{
							Transform[] array10 = (Transform[])((object)array9 << 2);
							bool flag54 = (nint)array10 == 2147483644;
							Transform[] array11 = array10;
							Transform[] array12;
							object obj87;
							int num24;
							Enumerator<, > val14;
							Enumerator<, > val21;
							Enumerator<, > val22;
							Enumerator<, > val23;
							Transform[] array13;
							Enumerator<, > val2;
							Enumerator<, > val15;
							if (!flag54)
							{
								object obj81 = array8 & 0xFFFFFFFFL;
								object obj82 = obj81 << 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj83 = 0;
								object obj84 = array8 & 0xFFFFFFFFL;
								array5 = (Vector3[])(obj84 << 2);
								object obj85 = obj82 + (object)array8;
								array12 = (Transform[])(array10 + 4);
								object obj86 = obj83;
								obj87 = array5 + 32;
								num24 = obj85 << 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4688 @ X9_v65+A0]");
								array2 = (Transform[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4724 @ X9_v85 (UnityEngine.Transform[])+8]");
								num2 = 0f;
								val2 = (Enumerator<, >)array2;
								val14 = (Enumerator<, >)0;
								array4 = array8;
								val4 = (Enumerator<, >)0;
								while (true)
								{
									float[] weight = points2.weight;
									bool flag55 = points2.weight == null;
									array11 = array12;
									array7 = (Material[])12;
									list = list2;
									array = array12;
									if (flag55)
									{
										break;
									}
									array2 = (Transform[])weight.Length;
									bool flag56 = (nint)array4 < weight.Length;
									object obj88 = !flag56;
									array11 = array12;
									array7 = (Material[])12;
									list = list2;
									array = array12;
									if (obj88 != null)
									{
										goto IL_3a5a;
									}
									array2 = (Transform[])(object)points2.bone;
									bool flag57 = points2.bone == null;
									array11 = array12;
									array7 = (Material[])12;
									list = list2;
									array = array12;
									if (flag57)
									{
										goto IL_3a84;
									}
									array5 = (Vector3[])array2.Length;
									bool flag58 = (nint)array4 < array2.Length;
									object obj89 = !flag58;
									array11 = array12;
									array7 = (Material[])12;
									list = list2;
									array = array12;
									if (obj89 != null)
									{
										goto IL_3a68;
									}
									object obj90 = (object)points2.weight + (object)array4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
									bool flag59 = (nint)0 < (nint)0;
									object obj91 = !flag59;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
									bool flag60 = (nint)0 == 0;
									object obj92 = ~obj91;
									object obj93 = obj92 | flag60;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
									val4 = (Enumerator<, >)0;
									if (obj93 == null)
									{
										object obj94 = (object)points2.bone + (object)array4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5180 @ X8_v191+20]");
										num17 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5180 @ X8_v191+20]");
										bool flag61 = (nint)0 >= (nint)bones.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
										val4 = (Enumerator<, >)0;
										if (!flag61)
										{
											int value9 = ((int*)num3)->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
											bool flag62 = (nint)0 == 0;
											object obj95 = !flag62;
											if (obj95 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value9 = ((int*)num3)->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
											object obj96 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5313 @ X8_v195+28]");
											object obj97 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5313 @ X8_v195+28]");
											bool flag63 = (nint)0 == 0;
											array11 = array12;
											array7 = (Material[])12;
											obj48 = 0;
											obj49 = 0;
											val13 = (Enumerator<, >)(ref val);
											val = val10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
											val4 = (Enumerator<, >)0;
											array6 = array8;
											num5 = num25;
											list = list2;
											array = array12;
											if (flag63)
											{
												goto end_IL_44ea;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1989 @ X8_v196+18]");
											array2 = (Transform[])0;
											int num26 = num17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1989 @ X8_v196+18]");
											bool flag64 = (nint)num26 < (nint)0;
											object obj98 = !flag64;
											array11 = array12;
											array7 = (Material[])12;
											obj48 = 0;
											obj49 = 0;
											val13 = (Enumerator<, >)(ref val);
											val = val10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
											val4 = (Enumerator<, >)0;
											array6 = array8;
											num5 = num25;
											list = list2;
											array = array12;
											if (obj98 != null)
											{
												goto IL_3bbe;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5313 @ X8_v195+28]");
											object obj99 = (nint)0 + (nint)num17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5424 @ X8_v197+20]");
											bool flag65 = (nint)0 == 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
											val4 = (Enumerator<, >)0;
											if (!flag65)
											{
												Vector3[] at2 = points2.at;
												bool flag66 = points2.at == null;
												array11 = array12;
												array7 = (Material[])12;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
												val4 = (Enumerator<, >)0;
												array6 = array8;
												num5 = num25;
												list = list2;
												array = array12;
												if (!flag66)
												{
													array2 = (Transform[])at2.Length;
													bool flag67 = (nint)array4 < at2.Length;
													object obj100 = !flag67;
													array11 = array12;
													array7 = (Material[])12;
													obj48 = 0;
													obj49 = 0;
													val13 = (Enumerator<, >)(ref val);
													val = val10;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
													val4 = (Enumerator<, >)0;
													array6 = array8;
													num5 = num25;
													list = list2;
													array = array12;
													if (obj100 == null)
													{
														object obj101 = array4 * 12;
														object obj102 = (object)points2.at + obj101;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5503 @ X8_v200+28]");
														val4 = (Enumerator<, >)0;
														bool flag68 = list2 == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5503 @ X8_v200+28]");
														val15 = (Enumerator<, >)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5503 @ X8_v200+20]");
														val16 = (Enumerator<, >)0;
														if (flag68)
														{
															goto IL_2154;
														}
														float num27 = num28;
														Enumerator<, > val17 = val18;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5503 @ X8_v200+28]");
														Enumerator<, > val19 = (Enumerator<, >)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5503 @ X8_v200+20]");
														Enumerator<, > val20 = (Enumerator<, >)0;
														val21 = val5;
														val22 = val7;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5503 @ X8_v200+28]");
														val23 = (Enumerator<, >)0;
														array13 = (Transform[])at2.Length;
														num3 = 0;
														int num29 = value9;
														while (true)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5246 @ X0_v235 (System.Int32)+E4]");
															bool flag69 = (nint)0 == 0;
															object obj103 = !flag69;
															if (obj103 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
																object obj104 = 0;
																num29 = (int)obj104;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5246 @ X0_v235 (System.Int32)+A0]");
															object obj105 = 0;
															object obj106 = obj105;
															if (obj105 != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5589 @ X8_v210+18]");
																array13 = (Transform[])0;
																int num30 = num3;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5589 @ X8_v210+18]");
																bool flag70 = (nint)num30 < (nint)0;
																object obj107 = !flag70;
																if (obj107 == null)
																{
																	object obj108 = obj105 + num3;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5619 @ X8_v211+20]");
																	val4 = (Enumerator<, >)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5619 @ X8_v211+20]");
																	if ((nint)0 != 0)
																	{
																		Vector3[][] shape2 = points2.shape;
																		bool flag71 = points2.shape == null;
																		num28 = num27;
																		val18 = val17;
																		val15 = val19;
																		val16 = val20;
																		array11 = array12;
																		val5 = val21;
																		val7 = val22;
																		array7 = (Material[])12;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5589 @ X8_v210+18]");
																		array2 = (Transform[])0;
																		list = list2;
																		array = array12;
																		if (flag71)
																		{
																			break;
																		}
																		array2 = (Transform[])shape2.Length;
																		bool flag72 = num3 < shape2.Length;
																		object obj109 = !flag72;
																		num28 = num27;
																		val18 = val17;
																		val15 = val19;
																		val16 = val20;
																		array11 = array12;
																		val5 = val21;
																		val7 = val22;
																		array7 = (Material[])12;
																		list = list2;
																		array = array12;
																		if (obj109 != null)
																		{
																			goto IL_3abc;
																		}
																		object obj110 = points2.shape + num3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5844 @ X8_v214+20]");
																		object obj111 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5844 @ X8_v214+20]");
																		bool flag73 = (nint)0 == 0;
																		num28 = num27;
																		val18 = val17;
																		val15 = val19;
																		val16 = val20;
																		array11 = array12;
																		val5 = val21;
																		val7 = val22;
																		array7 = (Material[])12;
																		list = list2;
																		array = array12;
																		if (flag73)
																		{
																			goto IL_3a92;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5093 @ X8_v215+18]");
																		array2 = (Transform[])0;
																		Material[] array14 = array4;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5093 @ X8_v215+18]");
																		bool flag74 = (nint)array14 < 0;
																		object obj112 = !flag74;
																		num28 = num27;
																		val18 = val17;
																		val15 = val19;
																		val16 = val20;
																		array11 = array12;
																		val5 = val21;
																		val7 = val22;
																		array7 = (Material[])12;
																		list = list2;
																		array = array12;
																		if (obj112 != null)
																		{
																			goto IL_3aa0;
																		}
																		object obj113 = array4 * 12;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5844 @ X8_v214+20]");
																		object obj114 = 0 + obj113;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5246 @ X0_v235 (System.Int32)+E4]");
																		array2 = (Transform[])0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5897 @ X8_v216+20]");
																		val18 = (Enumerator<, >)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5897 @ X8_v216+28]");
																		num28 = 0f;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5246 @ X0_v235 (System.Int32)+E4]");
																		bool flag75 = (nint)0 == 0;
																		object obj115 = !flag75;
																		if (obj115 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
																			object obj116 = 0;
																			num29 = (int)obj116;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5246 @ X0_v235 (System.Int32)+A0]");
																		object obj117 = 0;
																		object obj118 = obj117;
																		bool flag76 = obj117 == null;
																		val15 = val19;
																		val16 = val20;
																		array11 = array12;
																		val5 = val21;
																		val7 = val22;
																		array7 = (Material[])12;
																		list = list2;
																		array = array12;
																		if (flag76)
																		{
																			goto IL_3aae;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5250 @ X8_v219+18]");
																		array2 = (Transform[])0;
																		int num31 = num3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5250 @ X8_v219+18]");
																		bool flag77 = (nint)num31 < (nint)0;
																		object obj119 = !flag77;
																		val15 = val19;
																		val16 = val20;
																		array11 = array12;
																		val5 = val21;
																		val7 = val22;
																		array7 = (Material[])12;
																		list = list2;
																		array = array12;
																		if (obj119 != null)
																		{
																			goto IL_3ad8;
																		}
																		object obj120 = obj117 + num3;
																		object obj121 = val18 * obj122;
																		float num32 = num28;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5712 @ X8_v220+20]");
																		val4 = (Enumerator<, >)(num32 * 0);
																		val21 = (Enumerator<, >)(val20 + obj121);
																		val22 = (Enumerator<, >)(val19 + val4);
																		num27 = num28;
																		val17 = val18;
																		val19 = val22;
																		val20 = val21;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5250 @ X8_v219+18]");
																		array13 = (Transform[])0;
																	}
																	num3++;
																	bool flag78 = num16 != num3;
																	num28 = num27;
																	val18 = val17;
																	val15 = val19;
																	val16 = val20;
																	val5 = val21;
																	val7 = val22;
																	array2 = array13;
																	value9 = num29;
																	val23 = val4;
																	if (flag78)
																	{
																		continue;
																	}
																	goto IL_2154;
																}
																IndexOutOfRangeException ex16 = new IndexOutOfRangeException();
															}
															NullReferenceException ex17 = new NullReferenceException();
															array7 = (Material[])12;
															list = list2;
															goto IL_3a02;
														}
														goto IL_3aca;
													}
													goto IL_3bda;
												}
												goto IL_3c04;
											}
										}
									}
									goto IL_451d;
									IL_2154:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
										num3 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										int value9 = ((int*)num3)->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
									object obj123 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5592 @ X8_v203+20]");
									object obj124 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5592 @ X8_v203+20]");
									bool flag79 = (nint)0 == 0;
									array11 = array12;
									array7 = (Material[])12;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									array6 = array8;
									num5 = num25;
									list = list2;
									array = array12;
									if (flag79)
									{
										goto IL_3bf6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2334 @ X8_v204+18]");
									array2 = (Transform[])0;
									int num33 = num17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2334 @ X8_v204+18]");
									bool flag80 = (nint)num33 < (nint)0;
									object obj125 = !flag80;
									array11 = array12;
									array7 = (Material[])12;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									array6 = array8;
									num5 = num25;
									list = list2;
									array = array12;
									if (obj125 != null)
									{
										goto IL_3be8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5592 @ X8_v203+20]");
									object obj126 = (nint)0 + (nint)num17;
									array2 = (Transform[])(obj126 + 56);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+40]");
									vector2 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+20]");
									object obj127 = 0 * obj128;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+30]");
									object obj129 = 0 * obj130;
									Enumerator<, > val24 = val16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+28]");
									object obj131 = val24 * 0;
									Enumerator<, > val25 = val15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+48]");
									object obj132 = val25 * 0;
									object obj133 = obj127 + obj129;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+40]");
									object obj134 = 0 * obj135;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									object obj136 = obj133 + obj134;
									object obj137 = obj131 + obj132;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+50]");
									val8 = (Enumerator<, >)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+50]");
									object obj138 = 0 + obj136;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5204 @ X8_v205+58]");
									object obj139 = 0 + obj137;
									val7 = (Enumerator<, >)(obj138 * obj42);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
									object obj140 = 0 * obj139;
									val2 += val7;
									num2 += (float)obj140;
									Enumerator<, > val26 = val14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
									val4 = (Enumerator<, >)(val26 + 0);
									val27 = val15;
									val14 = val4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5100 @ X8_v136+20]");
									val5 = (Enumerator<, >)0;
									goto IL_451d;
									IL_451d:
									array4 = (Material[])(array4 + 1);
									if (System.Runtime.CompilerServices.Unsafe.As<Material[], UIntPtr>(ref array4) < System.Runtime.CompilerServices.Unsafe.As<Transform[], UIntPtr>(ref array12))
									{
										continue;
									}
									goto IL_23d5;
								}
								goto IL_3a76;
							}
							goto IL_47a7;
							IL_3abc:
							IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
							goto IL_3aca;
							IL_3aca:
							NullReferenceException ex19 = new NullReferenceException();
							goto IL_3ad8;
							IL_23d5:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
							array4 = (Material[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							array = (Transform[])0;
							bool flag81 = (int)val14 < 0;
							object obj141 = !flag81;
							bool flag82 = (int)val14 == 0;
							object obj142 = ~obj141;
							object obj143 = obj142 | flag82;
							array11 = array12;
							val4 = val14;
							list = at;
							Enumerator<, > val28;
							int num34;
							if (obj143 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [at @ X1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								if ((nint)0 >= (nint)1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									num28 = num2 / (float)val14;
									val28 = (Enumerator<, >)(val2 / val14);
									array11 = array12;
									Enumerator<, > val29 = val5;
									Enumerator<, > val30 = val14;
									num34 = 0;
									array7 = (Material[])12;
									val4 = val28;
									list = at;
									while (true)
									{
										num4 = (int)array4;
										Vector3 vector3 = list.get_Item(num34);
										int value9 = ((int*)num3)->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
										bool flag83 = (nint)0 == 0;
										object obj144 = !flag83;
										if (obj144 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value9 = ((int*)num3)->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
										object obj145 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
										array2 = (Transform[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
										bool flag84 = (nint)0 == 0;
										val18 = val29;
										val15 = val28;
										val2 = val30;
										val5 = val29;
										val7 = val30;
										num17 = num34;
										obj48 = 0;
										obj49 = 0;
										val13 = (Enumerator<, >)(ref val);
										val = val10;
										array6 = array8;
										num2 = (float)val4;
										num5 = num34;
										array = array12;
										if (flag84)
										{
											break;
										}
										array5 = (Vector3[])array2.Length;
										bool flag85 = num34 < array2.Length;
										object obj146 = !flag85;
										val18 = val29;
										val15 = val28;
										val2 = val30;
										val5 = val29;
										val7 = val30;
										num17 = num34;
										obj48 = 0;
										obj49 = 0;
										val13 = (Enumerator<, >)(ref val);
										val = val10;
										array6 = array8;
										num2 = (float)val4;
										num5 = num34;
										array = array12;
										if (obj146 != null)
										{
											goto IL_3bb0;
										}
										object obj147 = obj148 - val30;
										float num35 = num28 - (float)val29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
										array5 = (Vector3[])((nint)0 + (nint)num34);
										object obj149 = val28 - val4;
										object obj150 = obj147 * obj147;
										object obj151 = obj149 * obj149;
										object obj152 = obj151 + obj150;
										val7 = (Enumerator<, >)(num35 * num35);
										num2 = (float)val7 + (float)obj152;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5856 @ X10_v76 (UnityEngine.Vector3[])+20]");
										val4 = (Enumerator<, >)0;
										float num36 = num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5856 @ X10_v76 (UnityEngine.Vector3[])+20]");
										bool flag86 = !(num36 < 0f);
										val2 = val30;
										val5 = (Enumerator<, >)num35;
										Enumerator<, > val31;
										float num38;
										if (!flag86)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
											array5 = (Vector3[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
											bool flag87 = (nint)0 == 0;
											object obj153 = !flag87;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
											Transform[] array15 = (Transform[])0;
											if (obj153 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												int value11 = ((int*)num3)->m_value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5618 @ X8_v185 (System.Int32)+A0]");
												obj145 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
												array15 = (Transform[])0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
												bool flag88 = (nint)0 == 0;
												val18 = val29;
												val15 = val28;
												val2 = val30;
												val5 = (Enumerator<, >)num35;
												num17 = num34;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												array6 = array8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+30]");
												array2 = (Transform[])0;
												num5 = num34;
												array = array12;
												if (flag88)
												{
													goto IL_3cd6;
												}
											}
											array5 = (Vector3[])array15.Length;
											bool flag89 = num34 < array15.Length;
											object obj154 = !flag89;
											val18 = val29;
											val15 = val28;
											val2 = val30;
											val5 = (Enumerator<, >)num35;
											num17 = num34;
											obj48 = 0;
											obj49 = 0;
											val13 = (Enumerator<, >)(ref val);
											val = val10;
											array6 = array8;
											array2 = array15;
											num5 = num34;
											array = array12;
											if (obj154 != null)
											{
												goto IL_3c12;
											}
											array2 = (Transform[])(array15 + num34);
											array2[0] = (Transform)num2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+38]");
											object obj155 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+38]");
											bool flag90 = (nint)0 == 0;
											val18 = val29;
											val15 = val28;
											val2 = val30;
											val5 = (Enumerator<, >)num35;
											num17 = num34;
											obj48 = 0;
											obj49 = 0;
											val13 = (Enumerator<, >)(ref val);
											val = val10;
											array6 = array8;
											num5 = num34;
											array = array12;
											if (!flag90)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2929 @ X8_v148+18]");
												array2 = (Transform[])0;
												int num37 = num34;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2929 @ X8_v148+18]");
												bool flag91 = (nint)num37 < (nint)0;
												object obj156 = !flag91;
												val18 = val29;
												val15 = val28;
												val2 = val30;
												val5 = (Enumerator<, >)num35;
												num17 = num34;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												array6 = array8;
												num5 = num34;
												array = array12;
												if (obj156 == null)
												{
													object obj157 = num34 * 12;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ X8_v147+38]");
													object obj158 = 0 + obj157;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
													object obj159 = 0;
													object obj160 = obj159;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5830 @ X8_v153+A0]");
													object obj161 = 0;
													val31 = (Enumerator<, >)obj161;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5831 @ X8_v154+8]");
													num38 = 0f;
													bool flag92 = (nint)array10 == 2147483644;
													val5 = (Enumerator<, >)num35;
													val4 = val28;
													array2 = array10;
													if (flag92)
													{
														goto IL_33b7;
													}
													Transform transform2 = transform3;
													Vector3 vector4 = vector2;
													Enumerator<, > val32 = val27;
													Enumerator<, > val33 = val8;
													val2 = (Enumerator<, >)obj161;
													Transform[] array16 = array11;
													val21 = (Enumerator<, >)num35;
													Vector3[] array17 = (Vector3[])array15.Length;
													val22 = val7;
													Material[] array18 = array7;
													array4 = null;
													val23 = val28;
													array13 = array10;
													num3 = num24;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5831 @ X8_v154+8]");
													num2 = 0f;
													while (true)
													{
														int[] bone = points2.bone;
														bool flag93 = points2.bone == null;
														transform3 = transform2;
														vector2 = vector4;
														val27 = val32;
														val8 = val33;
														float num27 = num28;
														Enumerator<, > val17 = val29;
														Enumerator<, > val19 = val28;
														Enumerator<, > val20 = val16;
														array11 = array16;
														array5 = array17;
														num17 = num34;
														array7 = array18;
														num25 = num34;
														array = array12;
														if (flag93)
														{
															break;
														}
														array13 = (Transform[])bone.Length;
														list = (List<Vector3>)(object)((object)renderer + (object)array4);
														bool flag94 = (nint)list < bone.Length;
														object obj162 = !flag94;
														transform3 = transform2;
														vector2 = vector4;
														val27 = val32;
														val8 = val33;
														num27 = num28;
														val17 = val29;
														val19 = val28;
														val20 = val16;
														array11 = array16;
														array5 = array17;
														num17 = num34;
														array7 = array18;
														num25 = num34;
														array = array12;
														if (obj162 == null)
														{
															array13 = (Transform[])(object)points2.weight;
															bool flag95 = points2.weight == null;
															transform3 = transform2;
															vector2 = vector4;
															val27 = val32;
															val8 = val33;
															num27 = num28;
															val17 = val29;
															val19 = val28;
															val20 = val16;
															array11 = array16;
															array5 = array17;
															num17 = num34;
															array7 = array18;
															num25 = num34;
															array = array12;
															if (flag95)
															{
																goto IL_3a10;
															}
															array5 = (Vector3[])array13.Length;
															bool flag96 = (nint)list < array13.Length;
															object obj163 = !flag96;
															transform3 = transform2;
															vector2 = vector4;
															val27 = val32;
															val8 = val33;
															num27 = num28;
															val17 = val29;
															val19 = val28;
															val20 = val16;
															array11 = array16;
															num17 = num34;
															array7 = array18;
															num25 = num34;
															array = array12;
															if (obj163 == null)
															{
																array2 = (Transform[])(object)((object)points2.weight + obj87);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4724 @ X9_v85 (UnityEngine.Transform[])+v4943 @ X28_v82 (UnityEngine.Material[])*4]");
																val4 = (Enumerator<, >)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4724 @ X9_v85 (UnityEngine.Transform[])+v4943 @ X28_v82 (UnityEngine.Material[])*4]");
																if ((nint)0 > (nint)0)
																{
																	object obj164 = (object)points2.bone + obj87;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5930 @ X8_v165+v4943 @ X28_v82 (UnityEngine.Material[])*4]");
																	array18 = (Material[])0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5930 @ X8_v165+v4943 @ X28_v82 (UnityEngine.Material[])*4]");
																	if ((nint)0 < (nint)bones.Length)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
																		object obj165 = 0;
																		value9 = (int)obj165;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
																		bool flag97 = (nint)0 == 0;
																		object obj166 = !flag97;
																		if (obj166 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
																			object obj167 = 0;
																			value9 = (int)obj167;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
																		object obj168 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v173+28]");
																		array2 = (Transform[])0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v173+28]");
																		bool flag98 = (nint)0 == 0;
																		transform3 = transform2;
																		vector2 = vector4;
																		val27 = val32;
																		val8 = val33;
																		val18 = val29;
																		val15 = val28;
																		array11 = array16;
																		val5 = val21;
																		val7 = val22;
																		num17 = num34;
																		array7 = array18;
																		num25 = num34;
																		array = array12;
																		if (flag98)
																		{
																			goto IL_3ae6;
																		}
																		array5 = (Vector3[])array2.Length;
																		bool flag99 = (nint)array18 < array2.Length;
																		object obj169 = !flag99;
																		transform3 = transform2;
																		vector2 = vector4;
																		val27 = val32;
																		val8 = val33;
																		val18 = val29;
																		val15 = val28;
																		array11 = array16;
																		val5 = val21;
																		val7 = val22;
																		num17 = num34;
																		array7 = array18;
																		num25 = num34;
																		array = array12;
																		if (obj169 != null)
																		{
																			goto IL_3af4;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v173+28]");
																		object obj170 = 0 + array18;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5972 @ X9_v103+20]");
																		array2 = (Transform[])0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5972 @ X9_v103+20]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
																			bool flag100 = (nint)0 == 0;
																			object obj171 = !flag100;
																			if (obj171 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
																				object obj172 = 0;
																				object obj173 = obj172;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5980 @ X8_v180+A0]");
																				obj168 = 0;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v173+20]");
																			array2 = (Transform[])0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v173+20]");
																			bool flag101 = (nint)0 == 0;
																			transform3 = transform2;
																			vector2 = vector4;
																			val27 = val32;
																			val8 = val33;
																			val18 = val29;
																			val15 = val28;
																			array11 = array16;
																			val5 = val21;
																			val7 = val22;
																			num17 = num34;
																			array7 = array18;
																			obj48 = 0;
																			obj49 = 0;
																			val13 = (Enumerator<, >)(ref val);
																			val = val10;
																			array6 = array8;
																			num5 = num34;
																			array = array12;
																			if (flag101)
																			{
																				goto IL_3b78;
																			}
																			array5 = points2.way;
																			bool flag102 = points2.way == null;
																			transform3 = transform2;
																			vector2 = vector4;
																			val27 = val32;
																			val8 = val33;
																			val18 = val29;
																			val15 = val28;
																			array11 = array16;
																			val5 = val21;
																			val7 = val22;
																			num17 = num34;
																			array7 = array18;
																			obj48 = 0;
																			obj49 = 0;
																			val13 = (Enumerator<, >)(ref val);
																			val = val10;
																			array6 = array8;
																			num5 = num34;
																			array = array12;
																			if (flag102)
																			{
																				goto IL_3b5c;
																			}
																			bool flag103 = (nint)list < array5.Length;
																			object obj174 = !flag103;
																			transform3 = transform2;
																			vector2 = vector4;
																			val27 = val32;
																			val8 = val33;
																			val18 = val29;
																			val15 = val28;
																			array11 = array16;
																			val5 = val21;
																			val7 = val22;
																			num17 = num34;
																			array7 = array18;
																			obj48 = 0;
																			obj49 = 0;
																			val13 = (Enumerator<, >)(ref val);
																			val = val10;
																			array6 = array8;
																			num5 = num34;
																			array = array12;
																			if (obj174 != null)
																			{
																				goto IL_3b40;
																			}
																			bool flag104 = (nint)array18 < array2.Length;
																			object obj175 = !flag104;
																			transform3 = transform2;
																			vector2 = vector4;
																			val27 = val32;
																			val8 = val33;
																			val18 = val29;
																			val15 = val28;
																			array11 = array16;
																			val5 = val21;
																			val7 = val22;
																			num17 = num34;
																			array7 = array18;
																			obj48 = 0;
																			obj49 = 0;
																			val13 = (Enumerator<, >)(ref val);
																			val = val10;
																			array6 = array8;
																			num5 = num34;
																			array = array12;
																			if (obj175 != null)
																			{
																				goto IL_3b4e;
																			}
																			float[] weight2 = points2.weight;
																			bool flag105 = points2.weight == null;
																			transform3 = transform2;
																			vector2 = vector4;
																			val27 = val32;
																			val8 = val33;
																			val18 = val29;
																			val15 = val28;
																			array11 = array16;
																			val5 = val21;
																			val7 = val22;
																			num17 = num34;
																			array7 = array18;
																			obj48 = 0;
																			obj49 = 0;
																			val13 = (Enumerator<, >)(ref val);
																			val = val10;
																			array6 = array8;
																			num5 = num34;
																			array = array12;
																			if (flag105)
																			{
																				goto IL_3b6a;
																			}
																			array11 = (Transform[])weight2.Length;
																			bool flag106 = (nint)list < weight2.Length;
																			object obj176 = !flag106;
																			transform3 = transform2;
																			vector2 = vector4;
																			val27 = val32;
																			val8 = val33;
																			val18 = val29;
																			val15 = val28;
																			val5 = val21;
																			val7 = val22;
																			num17 = num34;
																			array7 = array18;
																			obj48 = 0;
																			obj49 = 0;
																			val13 = (Enumerator<, >)(ref val);
																			val = val10;
																			array6 = array8;
																			num5 = num34;
																			array = array12;
																			if (obj176 != null)
																			{
																				goto IL_3b86;
																			}
																			array5 = (Vector3[])(array5 + num3);
																			array2 = (Transform[])(object)((object)array2 + (object)array18);
																			object obj177 = (object)points2.weight + obj87;
																			transform2 = array2[5];
																			object obj178 = (object)array2[0] * obj179;
																			object obj180 = (object)array2[2] * obj122;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5856 @ X10_v76 (UnityEngine.Vector3[])+20]");
																			object obj181 = 0 * array2[1];
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5856 @ X10_v76 (UnityEngine.Vector3[])+24]");
																			object obj182 = 0 * array2[3];
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5856 @ X10_v76 (UnityEngine.Vector3[])+28]");
																			vector4 = (Vector3)0;
																			object obj183 = obj178 + obj180;
																			val33 = (Enumerator<, >)((object)array2[4] * obj184);
																			object obj185 = obj181 + obj182;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5856 @ X10_v76 (UnityEngine.Vector3[])+28]");
																			object obj186 = 0 * array2[5];
																			object obj187 = obj183 + val33;
																			object obj188 = obj185 + obj186;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5957 @ X8_v177+v4943 @ X28_v82 (UnityEngine.Material[])*4]");
																			val22 = (Enumerator<, >)0;
																			val21 = (Enumerator<, >)(obj187 * obj179);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5957 @ X8_v177+v4943 @ X28_v82 (UnityEngine.Material[])*4]");
																			val4 = (Enumerator<, >)(obj188 * 0);
																			val2 += val21;
																			num2 += (float)val4;
																			val32 = (Enumerator<, >)array2[4];
																			array16 = (Transform[])weight2.Length;
																		}
																	}
																}
																array4 = (Material[])(array4 + 1);
																num3 += 12;
																object obj189 = (object)array8 + (object)array4;
																bool flag107 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj189) < System.Runtime.CompilerServices.Unsafe.As<Transform[], UIntPtr>(ref array12);
																transform3 = transform2;
																vector2 = vector4;
																val27 = val32;
																val8 = val33;
																val31 = val2;
																array11 = array16;
																val5 = val21;
																val7 = val22;
																array7 = array18;
																num38 = num2;
																array17 = array5;
																val23 = val4;
																array13 = array2;
																if (flag107)
																{
																	continue;
																}
																goto IL_33b7;
															}
															goto IL_3a1e;
														}
														goto IL_3a2c;
													}
													goto IL_3a02;
												}
												goto IL_3c20;
											}
											goto IL_3c2e;
										}
										goto IL_48b9;
										IL_33b7:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
										num3 = 0;
										value9 = ((int*)num3)->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
											array4 = (Material[])0;
											list = at;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
											array4 = (Material[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value9 = ((int*)num3)->m_value;
											list = at;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
										object obj190 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5902 @ X8_v158+40]");
										object obj191 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5902 @ X8_v158+40]");
										bool flag108 = (nint)0 == 0;
										val18 = val29;
										val15 = val28;
										val2 = val31;
										num17 = num34;
										obj48 = 0;
										obj49 = 0;
										val13 = (Enumerator<, >)(ref val);
										val = val10;
										array6 = array8;
										num2 = num38;
										num5 = num34;
										array = array12;
										if (flag108)
										{
											goto IL_3c4a;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3134 @ X8_v159+18]");
										array2 = (Transform[])0;
										int num39 = num34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3134 @ X8_v159+18]");
										bool flag109 = (nint)num39 < (nint)0;
										object obj192 = !flag109;
										val18 = val29;
										val15 = val28;
										val2 = val31;
										num17 = num34;
										obj48 = 0;
										obj49 = 0;
										val13 = (Enumerator<, >)(ref val);
										val = val10;
										array6 = array8;
										num2 = num38;
										num5 = num34;
										array = array12;
										if (obj192 != null)
										{
											goto IL_3c3c;
										}
										object obj193 = num34 * 12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5902 @ X8_v158+40]");
										object obj194 = 0 + obj193;
										val2 = val31;
										array2 = (Transform[])12;
										num2 = num38;
										goto IL_48b9;
										IL_48b9:
										num34++;
										int num40 = num34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5674 @ X26_v71 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										bool flag110 = (nint)num40 < (nint)0;
										val29 = val5;
										val30 = val7;
										if (flag110)
										{
											continue;
										}
										goto IL_3536;
									}
									goto IL_3ba2;
								}
								array11 = array12;
								val4 = val14;
								obj25 = 1;
								list = at;
							}
							goto IL_47a7;
							IL_3ad8:
							IndexOutOfRangeException ex20 = new IndexOutOfRangeException();
							goto IL_3ae6;
							IL_3ae6:
							NullReferenceException ex21 = new NullReferenceException();
							goto IL_3af4;
							IL_47a7:
							array8 = (Material[])(array8 + 4);
							renderer = (Renderer)(renderer + 4);
							array9 = (Transform[])(array9 + 1);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D78]");
							array6 = (Material[])0;
							if ((nint)array9 >= points2.count)
							{
								goto IL_359a;
							}
							continue;
							IL_3a02:
							NullReferenceException ex22 = new NullReferenceException();
							goto IL_3a10;
							IL_3a10:
							NullReferenceException ex23 = new NullReferenceException();
							goto IL_3a1e;
							IL_3a1e:
							IndexOutOfRangeException ex24 = new IndexOutOfRangeException();
							goto IL_3a2c;
							IL_3a2c:
							IndexOutOfRangeException ex25 = new IndexOutOfRangeException();
							val5 = val21;
							val7 = val22;
							val4 = val23;
							array2 = array13;
							goto IL_3a5a;
							IL_3536:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							array = (Transform[])0;
							val18 = val5;
							val15 = val28;
							num17 = num34;
							obj25 = 1;
							num25 = num34;
							goto IL_47a7;
							IL_3af4:
							IndexOutOfRangeException ex26 = new IndexOutOfRangeException();
							obj48 = 0;
							obj49 = 0;
							val13 = (Enumerator<, >)(ref val);
							num5 = num25;
							goto IL_3b24;
							IL_3a5a:
							IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
							goto IL_3a68;
							IL_3a68:
							IndexOutOfRangeException ex28 = new IndexOutOfRangeException();
							goto IL_3a76;
							IL_3a76:
							NullReferenceException ex29 = new NullReferenceException();
							goto IL_3a84;
							IL_3a84:
							NullReferenceException ex30 = new NullReferenceException();
							goto IL_3a92;
							IL_3a92:
							NullReferenceException ex31 = new NullReferenceException();
							goto IL_3aa0;
							IL_3aa0:
							IndexOutOfRangeException ex32 = new IndexOutOfRangeException();
							goto IL_3aae;
							IL_3aae:
							NullReferenceException ex33 = new NullReferenceException();
							goto IL_3abc;
							continue;
							end_IL_44ea:
							break;
						}
						goto IL_3bcc;
						IL_0cd0:
						val7 = (Enumerator<, >)1120403456;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4550 @ X8_v271+20]");
						num21 = 0f;
						num4 = 0;
						num5 = num3;
						goto IL_41e3;
						IL_359a:
						array7 = array8;
						continue;
						IL_3d4c:
						NullReferenceException ex34 = new NullReferenceException();
						if (num5 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj48 = 1;
							val4 = (Enumerator<, >)num21;
							obj22 = 0;
							goto IL_4cf8;
						}
						object obj195;
						if (num5 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj195 = obj196;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj49 = obj196;
							val4 = (Enumerator<, >)num21;
							obj22 = 0;
							goto IL_4d28;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D22C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return num21;
						IL_4d28:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D70]");
						object obj197 = 0;
						num5 = (int)obj197;
						((Enumerator<, >*)val13)->Dispose();
						bool flag111 = obj195 == null;
						object obj198 = !flag111;
						if (obj198 == null)
						{
							bool flag112 = obj48 == null;
							object obj199 = !flag112;
							OutOfMemoryException ex35 = (OutOfMemoryException)val13;
							if (obj199 == null)
							{
								goto IL_35ff;
							}
						}
						else
						{
							OutOfMemoryException ex35 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						goto IL_3d36;
						IL_4cf8:
						obj195 = obj49;
						goto IL_4d28;
						IL_3d36:
						NullReferenceException ex36 = new NullReferenceException();
						num21 = (float)val4;
						goto IL_3d4c;
						IL_41e3:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
						bool flag113 = (nint)0 == 0;
						object obj200 = !flag113;
						if (obj200 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							int value9 = ((int*)num3)->m_value;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
						object obj201 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4444 @ X8_v104+20]");
						object obj202 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4444 @ X8_v104+20]");
						bool flag114 = (nint)0 == 0;
						num17 = num16;
						renderer = (Renderer)val12;
						obj48 = 0;
						obj49 = 0;
						val13 = (Enumerator<, >)(ref val);
						val = val10;
						array6 = (Material[])1120403456;
						if (!flag114)
						{
							num25 = bones.Length;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2968 @ X8_v105+18]");
							int num41;
							if ((nint)0 < (nint)bones.Length)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
								object obj203 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								int value12 = ((int*)num3)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4495 @ X0_v265 (System.Int32)+E4]");
								bool flag115 = (nint)0 == 0;
								object obj204 = !flag115;
								if (obj204 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									value12 = ((int*)num3)->m_value;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4495 @ X0_v265 (System.Int32)+A0]");
								object obj205 = (nint)0 + (nint)32;
								obj205 = renderer2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
								object obj206 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								int value13 = ((int*)num3)->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4599 @ X8_v258 (System.Int32)+A0]");
								object obj207 = (nint)0 + (nint)40;
								obj207 = obj208;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num25 = bones.Length;
								num41 = (int)(bones.Length & 0xFFFFFFFFL);
								renderer = renderer2;
							}
							else
							{
								num41 = (int)(bones.Length & 0xFFFFFFFFL);
								renderer = (Renderer)val12;
							}
							bool flag116 = num25 < 1;
							val4 = (Enumerator<, >)num21;
							array2 = bones;
							if (flag116)
							{
								goto IL_15d1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
							object obj209 = 0;
							int num42 = (int)obj209;
							array6 = (Material[])(bones + 32);
							Enumerator<, > val34 = val35;
							Enumerator<, > val36 = val37;
							Enumerator<, > val38 = val5;
							Enumerator<, > val39 = val40;
							Enumerator<, > val41 = val42;
							Vector3[] array19 = array5;
							Enumerator<, > val43 = val7;
							Material[] array20 = array7;
							Renderer renderer3 = renderer;
							array4 = (Material[])32;
							Enumerator<, > val44 = (Enumerator<, >)num21;
							Enumerator<, > val45 = val11;
							num3 = 0;
							int num43 = num4;
							num5 = num25;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3990 @ X0_v247 (System.Int32)+E4]");
								array2 = (Transform[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3990 @ X0_v247 (System.Int32)+E4]");
								bool flag117 = (nint)0 == 0;
								object obj210 = !flag117;
								if (obj210 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
									object obj211 = 0;
									num42 = (int)obj211;
									num41 = bones.Length;
								}
								bool flag118 = num3 < num41;
								object obj212 = !flag118;
								val35 = val34;
								val37 = val36;
								val5 = val38;
								val40 = val39;
								val42 = val41;
								array5 = array19;
								val7 = val43;
								num17 = num16;
								array7 = array20;
								renderer = renderer3;
								obj48 = 0;
								obj49 = 0;
								val13 = (Enumerator<, >)(ref val);
								val = val10;
								val4 = val44;
								val11 = val45;
								num4 = num43;
								if (obj212 != null)
								{
									break;
								}
								nint num44 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3990 @ X0_v247 (System.Int32)+A0]");
								array2 = (Transform[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2503 @ X27_v10 (UnityEngine.Material[])+v4967 @ X25_v80 (System.Int32)*8]");
								renderer = (Renderer)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3914 @ X8_v228 (Il2CppClass<UnityEngine.Transform[]>)+E4]");
								array5 = (Vector3[])0;
								array7 = (Material[])(object)array2[1];
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3914 @ X8_v228 (Il2CppClass<UnityEngine.Transform[]>)+E4]");
								bool flag119 = (nint)0 == 0;
								object obj213 = !flag119;
								if (obj213 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag120 = renderer != null;
								bool flag121 = array7 == null;
								val35 = val34;
								val37 = val36;
								val5 = val38;
								val40 = val39;
								val42 = val41;
								val7 = val43;
								num17 = num16;
								obj48 = 0;
								obj49 = 0;
								val13 = (Enumerator<, >)(ref val);
								val = val10;
								val4 = val44;
								val11 = val45;
								num4 = 0;
								num5 = 0;
								if (!flag121)
								{
									bool flag122 = num3 < array7.Length;
									object obj214 = !flag122;
									val35 = val34;
									val37 = val36;
									val5 = val38;
									val40 = val39;
									val42 = val41;
									val7 = val43;
									num17 = num16;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									val4 = val44;
									val11 = val45;
									num4 = 0;
									num5 = 0;
									if (obj214 != null)
									{
										goto IL_3c90;
									}
									object obj215 = array7 + num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
									object obj216 = 0;
									int value9 = (int)obj216;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+A0]");
									object obj217 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4329 @ X8_v237+28]");
									array2 = (Transform[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4329 @ X8_v237+28]");
									bool flag123 = (nint)0 == 0;
									val35 = val34;
									val37 = val36;
									val5 = val38;
									val40 = val39;
									val42 = val41;
									val7 = val43;
									num17 = num16;
									obj48 = 0;
									obj49 = 0;
									val13 = (Enumerator<, >)(ref val);
									val = val10;
									val4 = val44;
									val11 = val45;
									num4 = 0;
									num5 = 0;
									if (!flag123)
									{
										array5 = (Vector3[])array2.Length;
										bool flag124 = num3 < array2.Length;
										object obj218 = !flag124;
										val35 = val34;
										val37 = val36;
										val5 = val38;
										val40 = val39;
										val42 = val41;
										val7 = val43;
										num17 = num16;
										obj48 = 0;
										obj49 = 0;
										val13 = (Enumerator<, >)(ref val);
										val = val10;
										val4 = val44;
										val11 = val45;
										num4 = 0;
										num5 = 0;
										if (obj218 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4329 @ X8_v237+28]");
											object obj219 = (nint)0 + (nint)num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5097 @ X9_v136+20]");
											array2 = (Transform[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5097 @ X9_v136+20]");
											bool flag125 = (nint)0 == 0;
											num25 = 0;
											if (!flag125)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X0_v205 (System.Int32)+E4]");
												bool flag126 = (nint)0 == 0;
												object obj220 = !flag126;
												if (obj220 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
													object obj221 = 0;
													object obj222 = obj221;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5310 @ X8_v245+A0]");
													obj217 = 0;
												}
												array2 = (Transform[])bones.Length;
												bool flag127 = num3 < bones.Length;
												object obj223 = !flag127;
												val35 = val34;
												val37 = val36;
												val5 = val38;
												val40 = val39;
												val42 = val41;
												val7 = val43;
												num17 = num16;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												val4 = val44;
												val11 = val45;
												num4 = 0;
												num5 = 0;
												if (obj223 != null)
												{
													goto IL_3d00;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2503 @ X27_v10 (UnityEngine.Material[])+v4967 @ X25_v80 (System.Int32)*8]");
												bool flag128 = (nint)0 == 0;
												val35 = val34;
												val37 = val36;
												val5 = val38;
												val40 = val39;
												val42 = val41;
												val7 = val43;
												num17 = num16;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												val4 = val44;
												val11 = val45;
												num4 = 0;
												num5 = 0;
												if (flag128)
												{
													goto IL_3d0e;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4329 @ X8_v237+20]");
												array7 = (Material[])0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2503 @ X27_v10 (UnityEngine.Material[])+v4967 @ X25_v80 (System.Int32)*8]");
												Matrix4x4 localToWorldMatrix = ((Transform)0).localToWorldMatrix;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4329 @ X8_v237+20]");
												bool flag129 = (nint)0 == 0;
												val35 = val46;
												val37 = val47;
												val5 = val46;
												val40 = val12;
												val42 = val48;
												val7 = val12;
												num17 = num16;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												val4 = val47;
												val11 = val48;
												num4 = 0;
												num5 = 0;
												if (flag129)
												{
													goto IL_3ce4;
												}
												bool flag130 = num3 < array7.Length;
												object obj224 = !flag130;
												val35 = val46;
												val37 = val47;
												val5 = val46;
												val40 = val12;
												val42 = val48;
												val7 = val12;
												num17 = num16;
												obj48 = 0;
												obj49 = 0;
												val13 = (Enumerator<, >)(ref val);
												val = val10;
												val4 = val47;
												val11 = val48;
												num4 = 0;
												num5 = 0;
												if (obj224 != null)
												{
													goto IL_3cf2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4329 @ X8_v237+20]");
												object obj225 = 0 + array4;
												obj225 = val48;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
												object obj226 = 0;
												value9 = (int)obj226;
												val34 = val46;
												val36 = val47;
												val38 = val46;
												val39 = val12;
												val41 = val48;
												val43 = val12;
												val44 = val47;
												val45 = val48;
												num25 = 0;
											}
											num3++;
											array4 = (Material[])(array4 + 64);
											num41 = bones.Length;
											bool flag131 = num3 < bones.Length;
											val35 = val34;
											val37 = val36;
											val5 = val38;
											val40 = val39;
											val42 = val41;
											val7 = val43;
											val4 = val44;
											val11 = val45;
											num4 = 0;
											array19 = array5;
											array20 = array7;
											renderer3 = renderer;
											num43 = 0;
											num5 = num25;
											num42 = value9;
											if (flag131)
											{
												continue;
											}
											goto IL_15d1;
										}
										goto IL_3c9e;
									}
									goto IL_3cac;
								}
								goto IL_3cba;
							}
							goto IL_3cc8;
						}
						goto IL_3d4c;
					}
					goto IL_3b94;
				}
			}
		}
		goto IL_3b24;
		IL_3ce4:
		NullReferenceException ex37 = new NullReferenceException();
		goto IL_3cf2;
		IL_3c9e:
		IndexOutOfRangeException ex38 = new IndexOutOfRangeException();
		goto IL_3cac;
		IL_3e33:
		return num2;
		IL_3c3c:
		IndexOutOfRangeException ex39 = new IndexOutOfRangeException();
		goto IL_3c4a;
		IL_3b6a:
		NullReferenceException ex40 = new NullReferenceException();
		goto IL_3b78;
		IL_3bf6:
		NullReferenceException ex41 = new NullReferenceException();
		goto IL_3c04;
		IL_3c66:
		NullReferenceException ex42 = new NullReferenceException();
		goto IL_3c74;
		IL_3bcc:
		NullReferenceException ex43 = new NullReferenceException();
		goto IL_3bda;
		IL_39c7:
		num2 = 2.139095E+09f;
		goto IL_3e33;
		IL_3cc8:
		IndexOutOfRangeException ex44 = new IndexOutOfRangeException();
		goto IL_3cd6;
		IL_3cac:
		NullReferenceException ex45 = new NullReferenceException();
		goto IL_3cba;
		IL_3c2e:
		NullReferenceException ex46 = new NullReferenceException();
		goto IL_3c3c;
		IL_3c04:
		NullReferenceException ex47 = new NullReferenceException();
		goto IL_3c12;
		IL_3b78:
		NullReferenceException ex48 = new NullReferenceException();
		goto IL_3b86;
		IL_3ba2:
		NullReferenceException ex49 = new NullReferenceException();
		goto IL_3bb0;
		IL_3bb0:
		IndexOutOfRangeException ex50 = new IndexOutOfRangeException();
		goto IL_3bbe;
		IL_3c74:
		NullReferenceException ex51 = new NullReferenceException();
		goto IL_3c82;
		IL_3bda:
		IndexOutOfRangeException ex52 = new IndexOutOfRangeException();
		goto IL_3be8;
		IL_3c82:
		IndexOutOfRangeException ex53 = new IndexOutOfRangeException();
		goto IL_3c90;
		IL_3c90:
		IndexOutOfRangeException ex54 = new IndexOutOfRangeException();
		goto IL_3c9e;
		IL_3b86:
		IndexOutOfRangeException ex55 = new IndexOutOfRangeException();
		goto IL_3b94;
		IL_3b5c:
		NullReferenceException ex56 = new NullReferenceException();
		goto IL_3b6a;
	}

	private unsafe static GillaSlice.Points Of(Mesh m, Material[] mats)
	{
		//IL_0010: Expected Obj, but got I
		//IL_3ec9: Expected I, but got Obj
		//IL_3eeb: Expected Obj, but got I4
		//IL_487b: Expected Obj, but got I
		//IL_4898: Unknown result type (might be due to invalid IL or missing references)
		//IL_48a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_0091: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_3f11: Expected Obj, but got I
		//IL_3f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_36eb: Expected I, but got Obj
		//IL_370d: Expected Obj, but got I4
		//IL_4561: Expected Obj, but got I
		//IL_4571: Expected Obj, but got I
		//IL_458e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4598: Unknown result type (might be due to invalid IL or missing references)
		//IL_3735: Expected I, but got Obj
		//IL_45df: Unknown result type (might be due to invalid IL or missing references)
		//IL_45e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3668: Expected Obj, but got I
		//IL_3692: Expected Obj, but got I4
		//IL_37aa: Expected Obj, but got I
		//IL_37b2: Expected I, but got Obj
		//IL_37c2: Expected Obj, but got I
		//IL_4524: Expected Obj, but got I
		//IL_37e1: Expected Obj, but got I
		//IL_37fa: Expected Obj, but got I
		//IL_3813: Unknown result type (might be due to invalid IL or missing references)
		//IL_381d: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d1: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_384c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3851: Unknown result type (might be due to invalid IL or missing references)
		//IL_3865: Expected Obj, but got I
		//IL_3875: Expected Obj, but got I
		//IL_3885: Expected Obj, but got I
		//IL_388d: Expected Obj, but got Ref
		//IL_3b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1b: Expected Obj, but got I4
		//IL_3b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3c: Expected Obj, but got I4
		//IL_3b5d: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		//IL_482a: Expected Obj, but got I
		//IL_4832: Unknown result type (might be due to invalid IL or missing references)
		//IL_483b: Expected Ref, but got Unknown
		//IL_4855: Expected Obj, but got I4
		//IL_389a: Expected I, but got Obj
		//IL_38bc: Expected Obj, but got I4
		//IL_3b7c: Expected Obj, but got I4
		//IL_3b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b8c: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I4
		//IL_3915: Expected I, but got Obj
		//IL_3937: Expected Obj, but got I4
		//IL_464d: Expected Obj, but got I
		//IL_465d: Expected Obj, but got I
		//IL_467a: Unknown result type (might be due to invalid IL or missing references)
		//IL_468c: Expected Obj, but got I4
		//IL_4690: Unknown result type (might be due to invalid IL or missing references)
		//IL_4698: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ae: Expected I, but got Obj
		//IL_02fa: Expected I, but got Obj
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got I4
		//IL_3bef: Expected I, but got Obj
		//IL_3c11: Expected Obj, but got I4
		//IL_395f: Expected I, but got Obj
		//IL_3e50: Expected Obj, but got I4
		//IL_46e1: Expected Obj, but got I
		//IL_3bd1: Expected Obj, but got I4
		//IL_3bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd9: Expected Obj, but got Unknown
		//IL_39b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39c5: Expected Obj, but got I4
		//IL_39c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e7: Expected I, but got Obj
		//IL_3eb7: Expected Obj, but got I4
		//IL_3c39: Expected I, but got Obj
		//IL_3f93: Expected I, but got Obj
		//IL_03a2: Expected Obj, but got I4
		//IL_03b9: Expected I, but got Obj
		//IL_3c50: Expected Obj, but got I
		//IL_3c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c64: Expected Obj, but got I
		//IL_3c74: Expected Obj, but got I
		//IL_3a1c: Expected Obj, but got I4
		//IL_3a3c: Expected Obj, but got I4
		//IL_07e4: Expected Obj, but got I4
		//IL_3ac9: Expected VT, but got Ref
		//IL_3ad9: Expected Obj, but got I
		//IL_3afe: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I4
		//IL_045c: Expected I, but got Obj
		//IL_03ed: Expected I, but got Obj
		//IL_47b3: Expected Obj, but got I
		//IL_47c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_47da: Expected Obj, but got I4
		//IL_47de: Unknown result type (might be due to invalid IL or missing references)
		//IL_47f2: Expected Obj, but got Ref
		//IL_3a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a61: Expected Obj, but got Unknown
		//IL_3a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8f: Expected Obj, but got Unknown
		//IL_3aa9: Expected Obj, but got I4
		//IL_3c81: Expected I, but got Obj
		//IL_3ca3: Expected Obj, but got I4
		//IL_0495: Expected Obj, but got I4
		//IL_049a: Expected I, but got Obj
		//IL_471e: Expected Obj, but got I
		//IL_4739: Unknown result type (might be due to invalid IL or missing references)
		//IL_474b: Expected Obj, but got I4
		//IL_474f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4763: Expected Obj, but got Ref
		//IL_3ccb: Expected I, but got Obj
		//IL_04b8: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I4
		//IL_04e8: Expected I, but got Obj
		//IL_3cd8: Expected I, but got Obj
		//IL_3ced: Expected Obj, but got I
		//IL_08a1: Expected Obj, but got I
		//IL_08bb: Expected Obj, but got I
		//IL_08c3: Expected I, but got Obj
		//IL_052e: Expected Obj, but got I4
		//IL_0538: Expected I, but got Obj
		//IL_092f: Expected Obj, but got I
		//IL_0948: Expected F4, but got I
		//IL_0564: Expected I, but got Obj
		//IL_4027: Expected Obj, but got I
		//IL_4051: Expected Obj, but got I4
		//IL_097f: Invalid comparison between F4 and I4
		//IL_098e: Invalid comparison between F4 and I4
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_09af: Expected Obj, but got F4
		//IL_09e4: Expected Obj, but got I4
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected Obj, but got Unknown
		//IL_09fa: Expected I4, but got Obj
		//IL_0586: Expected Obj, but got I8
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I4
		//IL_05a6: Expected I, but got Obj
		//IL_0a1e: Expected F4, but got I4
		//IL_3fba: Expected Obj, but got I4
		//IL_4079: Expected Obj, but got I
		//IL_4092: Expected Obj, but got I
		//IL_0a33: Expected Obj, but got I
		//IL_0a4c: Expected Obj, but got I
		//IL_0a6b: Expected Obj, but got I
		//IL_05e5: Expected I, but got Obj
		//IL_0608: Expected Obj, but got I4
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_0646: Expected Obj, but got I
		//IL_064e: Expected I, but got Obj
		//IL_0ab4: Expected Obj, but got I
		//IL_0ad3: Expected Obj, but got I
		//IL_0afe: Expected Obj, but got I4
		//IL_0b37: Expected Obj, but got I4
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected Obj, but got Unknown
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected Obj, but got Unknown
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b74: Expected Obj, but got Unknown
		//IL_0b82: Expected Obj, but got I4
		//IL_4943: Expected Obj, but got I
		//IL_494b: Expected I, but got Obj
		//IL_4977: Expected Obj, but got I4
		//IL_49a8: Expected Obj, but got I4
		//IL_0bf0: Expected Obj, but got I4
		//IL_0c53: Expected Obj, but got I4
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected Obj, but got Unknown
		//IL_0ca2: Expected Obj, but got I
		//IL_0cb2: Expected F4, but got I
		//IL_0cc2: Expected F4, but got I
		//IL_0cd2: Expected F4, but got I
		//IL_0ce2: Expected Obj, but got I
		//IL_0cf2: Expected Obj, but got I
		//IL_0d12: Expected Obj, but got I
		//IL_0d50: Expected Obj, but got I4
		//IL_0d58: Expected Obj, but got I4
		//IL_0d95: Expected Obj, but got I4
		//IL_0dab: Expected Obj, but got I
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Expected Obj, but got Unknown
		//IL_0e0e: Expected Obj, but got I4
		//IL_0e16: Expected Obj, but got I4
		//IL_0e86: Expected Obj, but got I4
		//IL_0e8e: Expected Obj, but got I4
		//IL_0ef6: Expected Obj, but got I4
		//IL_0efe: Expected Obj, but got I4
		//IL_0f65: Expected Obj, but got I4
		//IL_0f6d: Expected Obj, but got I4
		//IL_0fb3: Expected Obj, but got I
		//IL_0fe4: Expected Obj, but got I4
		//IL_0fec: Expected Obj, but got I4
		//IL_1023: Expected Obj, but got I4
		//IL_1033: Expected Obj, but got I4
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected Obj, but got Unknown
		//IL_1096: Expected Obj, but got I4
		//IL_109e: Expected Obj, but got I4
		//IL_10e4: Expected Obj, but got I
		//IL_1115: Expected Obj, but got I4
		//IL_111d: Expected Obj, but got I4
		//IL_1152: Expected Obj, but got I8
		//IL_1164: Expected I4, but got I8
		//IL_4910: Expected Obj, but got I4
		//IL_4918: Expected Obj, but got I4
		//IL_1190: Expected F4, but got I
		//IL_1304: Expected Obj, but got I4
		//IL_40aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_40af: Expected Obj, but got Unknown
		//IL_40b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40bd: Expected Obj, but got Unknown
		//IL_40e4: Expected Obj, but got I4
		//IL_11d1: Expected Obj, but got I4
		//IL_1202: Expected Obj, but got I4
		//IL_120a: Expected Obj, but got I4
		//IL_123f: Expected Obj, but got I8
		//IL_4156: Unknown result type (might be due to invalid IL or missing references)
		//IL_415b: Expected Obj, but got Unknown
		//IL_4179: Expected Obj, but got F4
		//IL_4181: Expected I4, but got Obj
		//IL_136e: Expected Obj, but got I4
		//IL_1376: Expected Obj, but got I4
		//IL_127e: Expected Obj, but got I
		//IL_12a4: Expected Obj, but got I
		//IL_12b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b9: Expected Obj, but got Unknown
		//IL_12ee: Expected Obj, but got I4
		//IL_2587: Expected Obj, but got F4
		//IL_13ac: Expected Obj, but got I4
		//IL_25da: Expected Obj, but got I
		//IL_419f: Expected Obj, but got I
		//IL_41bd: Expected Obj, but got I
		//IL_41d3: Expected Obj, but got I
		//IL_41f2: Expected Obj, but got I4
		//IL_13df: Expected Obj, but got I4
		//IL_140f: Expected Obj, but got I4
		//IL_1417: Expected Obj, but got I4
		//IL_260b: Expected Obj, but got F4
		//IL_4114: Unknown result type (might be due to invalid IL or missing references)
		//IL_4119: Expected Obj, but got Unknown
		//IL_412f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4134: Expected Obj, but got Unknown
		//IL_413c: Expected F4, but got Obj
		//IL_4149: Expected Obj, but got I4
		//IL_43e5: Expected Obj, but got I4
		//IL_1440: Expected Obj, but got I4
		//IL_1456: Unknown result type (might be due to invalid IL or missing references)
		//IL_145b: Expected Obj, but got Unknown
		//IL_1464: Unknown result type (might be due to invalid IL or missing references)
		//IL_1469: Expected Obj, but got Unknown
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Expected I4, but got Unknown
		//IL_1480: Expected Obj, but got I4
		//IL_2679: Expected Obj, but got F4
		//IL_14af: Expected F4, but got I
		//IL_26e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e5: Expected Obj, but got Unknown
		//IL_1660: Expected Obj, but got I4
		//IL_2715: Expected Obj, but got F4
		//IL_4a04: Expected Obj, but got I4
		//IL_14f8: Expected Obj, but got I4
		//IL_277f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2784: Expected Obj, but got Unknown
		//IL_1675: Expected Obj, but got I
		//IL_1685: Expected Obj, but got I
		//IL_16f1: Expected Obj, but got I4
		//IL_1557: Expected I4, but got I8
		//IL_1571: Expected Obj, but got I4
		//IL_27b4: Expected Obj, but got F4
		//IL_172c: Expected Obj, but got I
		//IL_1755: Expected Obj, but got I4
		//IL_1589: Expected Obj, but got I4
		//IL_15a0: Expected Obj, but got I
		//IL_15d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15db: Expected I4, but got Unknown
		//IL_2817: Expected Obj, but got I
		//IL_282d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Expected Obj, but got Unknown
		//IL_17b7: Expected VT, but got Ref
		//IL_17c7: Expected Obj, but got I
		//IL_2862: Expected Obj, but got F4
		//IL_17f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f7: Expected Obj, but got Unknown
		//IL_1811: Expected Obj, but got I4
		//IL_181a: Expected F4, but got I4
		//IL_1780: Expected Obj, but got I
		//IL_1796: Expected Obj, but got I
		//IL_41ff: Expected Obj, but got I4
		//IL_4245: Expected Obj, but got I4
		//IL_28c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c8: Expected Obj, but got Unknown
		//IL_1843: Expected Obj, but got I4
		//IL_1856: Expected F4, but got I4
		//IL_187e: Expected Obj, but got I4
		//IL_2905: Expected Obj, but got F4
		//IL_18be: Expected Obj, but got I
		//IL_18ce: Expected Obj, but got I
		//IL_193a: Expected Obj, but got I4
		//IL_18a9: Expected F4, but got I
		//IL_2965: Expected Obj, but got I
		//IL_1975: Expected Obj, but got I
		//IL_199e: Expected Obj, but got I4
		//IL_298d: Expected Obj, but got F4
		//IL_29bd: Expected Obj, but got I4
		//IL_1ccf: Expected VT, but got Ref
		//IL_1cdf: Expected Obj, but got I
		//IL_1cef: Expected Obj, but got I
		//IL_1d23: Expected Obj, but got I
		//IL_1a4a: Expected Obj, but got I4
		//IL_19c9: Expected Obj, but got I
		//IL_19df: Expected Obj, but got I
		//IL_1a03: Expected Obj, but got I4
		//IL_1a0b: Expected Obj, but got I4
		//IL_1a1b: Expected Obj, but got I4
		//IL_29e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e9: Expected Obj, but got Unknown
		//IL_2a0b: Expected Obj, but got I
		//IL_1aaa: Expected Obj, but got I4
		//IL_1abc: Expected Obj, but got I4
		//IL_42d4: Expected Obj, but got I
		//IL_42ec: Expected Obj, but got I
		//IL_42f4: Expected F4, but got Obj
		//IL_4304: Expected F4, but got I
		//IL_2a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a97: Expected Obj, but got Unknown
		//IL_1b01: Expected Obj, but got I4
		//IL_1b24: Expected Obj, but got I4
		//IL_44cc: Expected I4, but got Obj
		//IL_44f5: Expected I4, but got Obj
		//IL_4505: Expected Obj, but got I
		//IL_1d46: Expected Obj, but got I
		//IL_1d56: Expected Obj, but got I
		//IL_2aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aef: Expected Obj, but got Unknown
		//IL_1b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7e: Expected Obj, but got Unknown
		//IL_1b8e: Expected VT, but got I
		//IL_1bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb0: Expected Obj, but got Unknown
		//IL_1bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc5: Expected Obj, but got Unknown
		//IL_1be2: Expected Obj, but got I
		//IL_1bf2: Expected Obj, but got I
		//IL_1c02: Expected Obj, but got I
		//IL_1c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c24: Expected Obj, but got Unknown
		//IL_1c4e: Expected Obj, but got I
		//IL_1c6b: Expected Obj, but got I
		//IL_4485: Unknown result type (might be due to invalid IL or missing references)
		//IL_448a: Expected Obj, but got Unknown
		//IL_44a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_44a5: Expected Obj, but got Unknown
		//IL_44ad: Expected I4, but got Obj
		//IL_1dfd: Expected Obj, but got I
		//IL_1e26: Expected Obj, but got I4
		//IL_4a38: Expected Obj, but got I4
		//IL_4a84: Expected Obj, but got I4
		//IL_4aa4: Expected Obj, but got I4
		//IL_20bf: Expected VT, but got Ref
		//IL_20cf: Expected Obj, but got I
		//IL_20df: Expected VT, but got I
		//IL_20f4: Expected VT, but got I
		//IL_211b: Expected Obj, but got I
		//IL_1ee5: Expected Obj, but got I4
		//IL_1e4a: Expected Obj, but got I
		//IL_1e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5f: Expected Obj, but got Unknown
		//IL_1e75: Expected Obj, but got I
		//IL_1e9e: Expected Obj, but got I4
		//IL_1eb6: Expected VT, but got Obj
		//IL_2b2a: Expected Obj, but got I
		//IL_2b4b: Expected Obj, but got I4
		//IL_2b97: Expected Obj, but got I4
		//IL_2bb7: Expected Obj, but got I4
		//IL_1f3c: Expected Obj, but got I4
		//IL_1f5f: Expected Obj, but got I4
		//IL_4385: Expected Obj, but got I
		//IL_439d: Expected Obj, but got I
		//IL_43a5: Expected F4, but got Obj
		//IL_43b5: Expected F4, but got I
		//IL_43bd: Expected Obj, but got VT
		//IL_2bf7: Expected Obj, but got I4
		//IL_2c01: Expected Obj, but got I4
		//IL_2c4d: Expected Obj, but got I4
		//IL_2c6d: Expected Obj, but got I4
		//IL_1fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc1: Expected Obj, but got Unknown
		//IL_1fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe3: Expected Obj, but got Unknown
		//IL_200a: Unknown result type (might be due to invalid IL or missing references)
		//IL_200f: Expected Obj, but got Unknown
		//IL_201f: Expected Obj, but got I
		//IL_202f: Expected Obj, but got I
		//IL_205b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2060: Expected Obj, but got Unknown
		//IL_207a: Expected Obj, but got I
		//IL_2c98: Expected F4, but got I
		//IL_214e: Expected Obj, but got I
		//IL_215e: Expected Obj, but got I
		//IL_4433: Unknown result type (might be due to invalid IL or missing references)
		//IL_4438: Expected Obj, but got Unknown
		//IL_4441: Unknown result type (might be due to invalid IL or missing references)
		//IL_4446: Expected Obj, but got Unknown
		//IL_2cd0: Expected Obj, but got I
		//IL_2cf1: Expected Obj, but got I4
		//IL_2d35: Expected Obj, but got I4
		//IL_2d55: Expected Obj, but got I4
		//IL_220d: Expected Obj, but got I
		//IL_2236: Expected Obj, but got I4
		//IL_3354: Expected Obj, but got I4
		//IL_335d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3362: Expected Obj, but got Unknown
		//IL_338b: Expected I4, but got Obj
		//IL_22ab: Expected VT, but got Ref
		//IL_22bb: Expected Obj, but got I
		//IL_22d0: Expected VT, but got I
		//IL_22e8: Expected Obj, but got I
		//IL_2d73: Expected Obj, but got I
		//IL_2d94: Expected Obj, but got I4
		//IL_2d9e: Expected Obj, but got I4
		//IL_2de2: Expected Obj, but got I4
		//IL_2e02: Expected Obj, but got I4
		//IL_22f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fb: Expected Obj, but got Unknown
		//IL_225a: Expected Obj, but got I
		//IL_226a: Unknown result type (might be due to invalid IL or missing references)
		//IL_226f: Expected Obj, but got Unknown
		//IL_2285: Expected Obj, but got I
		//IL_33b2: Expected Obj, but got I4
		//IL_33f6: Expected Obj, but got I4
		//IL_2e29: Expected Obj, but got I4
		//IL_2e6d: Expected Obj, but got I4
		//IL_2e8d: Expected Obj, but got I4
		//IL_342c: Expected Obj, but got I
		//IL_344d: Expected Obj, but got I4
		//IL_3491: Expected Obj, but got I4
		//IL_2eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb0: Expected Obj, but got Unknown
		//IL_2ec0: Expected Obj, but got I
		//IL_2ed0: Expected Obj, but got I
		//IL_2ed8: Expected I, but got Obj
		//IL_2f02: Expected Obj, but got I4
		//IL_2f46: Expected Obj, but got I4
		//IL_2f56: Expected Obj, but got I4
		//IL_2f6e: Expected Obj, but got I4
		//IL_239f: Expected Obj, but got I
		//IL_23af: Expected Obj, but got I
		//IL_34cf: Expected Obj, but got I
		//IL_34f0: Expected Obj, but got I4
		//IL_34fa: Expected Obj, but got I4
		//IL_353e: Expected Obj, but got I4
		//IL_2f97: Expected Obj, but got I4
		//IL_2fa1: Expected Obj, but got I4
		//IL_2fe5: Expected Obj, but got I4
		//IL_2ff5: Expected Obj, but got I4
		//IL_300d: Expected Obj, but got I4
		//IL_246e: Expected Obj, but got I
		//IL_2497: Expected Obj, but got I4
		//IL_357c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3581: Expected Obj, but got Unknown
		//IL_358a: Unknown result type (might be due to invalid IL or missing references)
		//IL_358f: Expected Obj, but got Unknown
		//IL_35aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_35af: Expected Obj, but got Unknown
		//IL_24f9: Expected VT, but got Ref
		//IL_2509: Expected Obj, but got I
		//IL_35d9: Expected Obj, but got I4
		//IL_361d: Expected Obj, but got I4
		//IL_303e: Expected Obj, but got I4
		//IL_3048: Expected Obj, but got I4
		//IL_3094: Expected Obj, but got I4
		//IL_30a4: Expected Obj, but got I4
		//IL_30bc: Expected Obj, but got I4
		//IL_2534: Unknown result type (might be due to invalid IL or missing references)
		//IL_2539: Expected Obj, but got Unknown
		//IL_24bb: Expected Obj, but got I
		//IL_24d8: Expected Obj, but got I
		//IL_30e3: Expected Obj, but got I4
		//IL_312f: Expected Obj, but got I4
		//IL_313f: Expected Obj, but got I4
		//IL_3157: Expected Obj, but got I4
		//IL_3186: Expected Obj, but got I4
		//IL_3190: Expected Obj, but got I4
		//IL_31dc: Expected Obj, but got I4
		//IL_31ec: Expected Obj, but got I4
		//IL_3204: Expected Obj, but got I4
		//IL_3220: Expected Obj, but got I4
		//IL_323d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3242: Expected Obj, but got Unknown
		//IL_3252: Expected VT, but got I
		//IL_326f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3274: Expected Obj, but got Unknown
		//IL_3291: Expected Obj, but got I
		//IL_32a8: Expected Obj, but got I
		//IL_32b8: Expected Obj, but got I
		//IL_32c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cd: Expected Obj, but got Unknown
		//IL_32f7: Expected Obj, but got I
		//IL_3331: Expected Obj, but got F4
		//IL_3341: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
		Material[] array = (Material[])0;
		nint num = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2 (Il2CppClass<UnityEngine.Material[]>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		nint num2 = num;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (nint)array;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3 (Il2CppClass<UnityEngine.Material[]>)+A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<> val2 = (Enumerator<>)0;
		Material[] array2 = mats;
		System.__Canon value = null;
		Mesh mesh = m;
		Material[] array3 = mats;
		Matrix4x4[] bindposes;
		float num12;
		List<int> list9 = default;
		List<float> list10 = default;
		List<Vector3> list11 = default;
		List<Vector3> list12 = default;
		List<int> list13 = default;
		Material[] array7 = default;
		UnityEngine.Object obj38;
		object obj89 = default;
		object obj97 = default;
		UnityEngine.Object obj149 = default;
		GillaSlice.Points result;
		UnityEngine.Object obj152;
		List<Vector3> list2;
		UnityEngine.Object obj11;
		List<float> list3;
		List<Vector3> list7 = default;
		float num10;
		Material[] array9;
		Vector3[] array5;
		Vector3 vector6 = default;
		object obj94 = default;
		object obj93 = default;
		float num16;
		float num15;
		object obj42;
		List<int> list5 = default;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7360]");
			object obj3 = 0;
			Vector3[] array4 = (Vector3[])obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4+8]");
			bool flag3 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)m, out value);
			bool flag4 = !flag3;
			object obj4 = !flag4;
			if (obj4 != null)
			{
				goto IL_36d6;
			}
			nint num3 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v202 (Il2CppClass<UnityEngine.Material[]>)+E4]");
			bool flag5 = (nint)0 == 0;
			object obj5 = !flag5;
			nint num4 = num3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num4 = (nint)array;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1446 @ X0_v203 (Il2CppClass<UnityEngine.Material[]>)+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v204+8]");
			bool flag6 = (nint)0 == 0;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<>)0;
			array2 = (Material[])(object)m;
			nint num5 = (nint)(&value);
			mesh = m;
			array3 = mats;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7368]");
				object obj7 = 0;
				array2 = (Material[])obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v204+8]");
				int count = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
				bool flag7 = count >= 48;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<>)0;
				num5 = (nint)(&value);
				array3 = mats;
				if (!flag7)
				{
					bool flag8 = (object)m == null;
					value = null;
					mesh = m;
					if (!flag8)
					{
						bool isReadable = m.isReadable;
						bool flag9 = array3 == null;
						array2 = null;
						value = null;
						if (!flag9)
						{
							bool flag10 = !isReadable;
							array2 = null;
							value = null;
							if (!flag10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
								object obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								HashSet<int> hashSet = default;
								hashSet._002Ector();
								int subMeshCount = m.subMeshCount;
								if (subMeshCount >= 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									List<int> list = (List<int>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4280]");
									mesh = (Mesh)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DC0]");
									array = (Material[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C20]");
									list2 = (List<Vector3>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									list3 = (List<float>)0;
									List<int> list4 = list5;
									List<Vector3> list6 = list7;
									int num6 = 0;
									array2 = null;
									nint num7 = num5;
									bool flag29;
									do
									{
										bool flag11 = num6 >= array3.Length;
										list5 = list4;
										list7 = list6;
										num5 = num7;
										if (flag11)
										{
											break;
										}
										bool flag12 = num6 < array3.Length;
										object obj9 = !flag12;
										list5 = list4;
										list7 = list6;
										value = null;
										num5 = num7;
										string text;
										if (obj9 == null)
										{
											nint num8 = (nint)list;
											object obj10 = array3 + num6;
											list7 = (List<Vector3>)(obj10 + 32);
											obj11 = (UnityEngine.Object)(object)list7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2188 @ X0_v179 (Il2CppClass<System.Collections.Generic.List`1<System.Int32>>)+E4]");
											bool flag13 = (nint)0 == 0;
											object obj12 = !flag13;
											if (obj12 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											if (obj11 != null)
											{
												bool flag14 = num6 < array3.Length;
												object obj13 = !flag14;
												list5 = list4;
												array2 = null;
												value = null;
												num5 = unchecked((nint)null);
												if (obj13 != null)
												{
													goto IL_3dc2;
												}
												bool flag15 = list7 == null;
												list5 = list4;
												array2 = null;
												value = null;
												num5 = unchecked((nint)null);
												if (flag15)
												{
													goto IL_3db4;
												}
												string name = ((UnityEngine.Object)(object)list7).name;
												text = name;
												array2 = null;
											}
											else
											{
												text = (string)(object)list3;
												array2 = null;
											}
											bool flag16 = text == null;
											list5 = list4;
											obj11 = (UnityEngine.Object)(object)text;
											value = null;
											num5 = unchecked((nint)null);
											if (!flag16)
											{
												bool flag17 = text.Contains((string)(object)mesh);
												bool flag18 = !flag17;
												object obj14 = !flag18;
												num5 = unchecked((nint)null);
												if (obj14 == null)
												{
													bool flag19 = text.Contains((string)(object)array);
													bool flag20 = !flag19;
													object obj15 = !flag20;
													num5 = unchecked((nint)null);
													if (obj15 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73F8]");
														object value2 = 0;
														bool flag21 = text.Contains((string)value2);
														bool flag22 = !flag21;
														object obj16 = !flag22;
														num5 = unchecked((nint)null);
														if (obj16 == null)
														{
															int[] triangles = m.GetTriangles(num6);
															bool flag23 = triangles == null;
															list5 = list4;
															obj11 = (UnityEngine.Object)(object)text;
															array2 = (Material[])num6;
															value = null;
															num5 = unchecked((nint)null);
															if (flag23)
															{
																goto IL_3db4;
															}
															bool flag24 = triangles.Length < 1;
															text = (string)(object)triangles;
															num5 = unchecked((nint)null);
															if (!flag24)
															{
																object obj17 = triangles.Length & 0xFFFFFFFFL;
																list7 = (List<Vector3>)(triangles + 32);
																list5 = null;
																array2 = (Material[])num6;
																nint num9 = unchecked((nint)null);
																while (true)
																{
																	bool flag25 = System.Runtime.CompilerServices.Unsafe.As<List<int>, UIntPtr>(ref list5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
																	object obj18 = !flag25;
																	obj11 = (UnityEngine.Object)(object)triangles;
																	value = null;
																	num5 = num9;
																	if (obj18 != null)
																	{
																		break;
																	}
																	bool flag26 = hashSet == null;
																	obj11 = (UnityEngine.Object)(object)triangles;
																	value = null;
																	num5 = num9;
																	if (!flag26)
																	{
																		num5 = (nint)list2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+v429 @ X29_v1 (System.Collections.Generic.List`1<System.Int32>)*4]");
																		bool flag27 = hashSet.Add(0);
																		obj17 = triangles.Length;
																		list4 = (List<int>)(list5 + 1);
																		bool flag28 = (nint)list4 < triangles.Length;
																		text = (string)(object)triangles;
																		list5 = list4;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+v2090 @ X29_v17 (System.Collections.Generic.List`1<System.Int32>)*4]");
																		array2 = (Material[])0;
																		num9 = (nint)list2;
																		if (flag28)
																		{
																			continue;
																		}
																		goto IL_065c;
																	}
																	goto IL_3db4;
																}
																goto IL_3dc2;
															}
														}
													}
												}
												goto IL_065c;
											}
											goto IL_3db4;
										}
										goto IL_3dc2;
										IL_065c:
										num6++;
										int subMeshCount2 = m.subMeshCount;
										flag29 = num6 < subMeshCount2;
										list5 = list4;
										obj11 = (UnityEngine.Object)(object)text;
										list6 = list7;
										array2 = null;
										num7 = num5;
									}
									while (flag29);
								}
								Vector3[] vertices = m.vertices;
								Vector3[] normals = m.normals;
								BoneWeight[] boneWeights = m.boneWeights;
								bindposes = m.bindposes;
								bool flag30 = hashSet == null;
								obj11 = (UnityEngine.Object)(object)normals;
								array2 = null;
								value = null;
								mesh = m;
								if (!flag30)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2003 @ X0_v61 (System.Collections.Generic.HashSet`1<System.Int32>)+20]");
									bool flag31 = (nint)0 < (nint)1;
									obj11 = (UnityEngine.Object)(object)normals;
									array2 = null;
									value = null;
									if (flag31)
									{
										goto IL_3658;
									}
									bool flag32 = boneWeights == null;
									obj11 = (UnityEngine.Object)(object)normals;
									array2 = null;
									value = null;
									mesh = m;
									if (!flag32)
									{
										bool flag33 = vertices == null;
										array5 = vertices;
										obj11 = (UnityEngine.Object)(object)normals;
										array2 = null;
										value = null;
										mesh = m;
										if (!flag33)
										{
											array5 = (Vector3[])vertices.Length;
											bool flag34 = boneWeights.Length != vertices.Length;
											obj11 = (UnityEngine.Object)(object)normals;
											array2 = null;
											value = null;
											if (!flag34)
											{
												bool flag35 = bindposes == null;
												obj11 = (UnityEngine.Object)(object)normals;
												array2 = null;
												value = null;
												mesh = m;
												array3 = (Material[])(object)bindposes;
												if (flag35)
												{
													goto IL_3db4;
												}
												bool flag36 = bindposes.Length == 0;
												obj11 = (UnityEngine.Object)(object)normals;
												array2 = null;
												value = null;
												array3 = (Material[])(object)bindposes;
												if (!flag36)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
													object obj19 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BD8]");
													object obj20 = 0;
													num5 = (nint)obj20;
													List<int> list8 = default;
													list8._002Ector((IEnumerable<int>)hashSet);
													bool flag37 = list8 == null;
													obj11 = (UnityEngine.Object)(object)normals;
													List<int> list = list8;
													array2 = (Material[])(object)hashSet;
													value = null;
													mesh = m;
													array3 = (Material[])(object)bindposes;
													if (flag37)
													{
														goto IL_3db4;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73C0]");
													object obj21 = 0;
													list8.Sort();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v74 (System.Collections.Generic.List`1<System.Int32>)+18]");
													num10 = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
													object obj22 = 0;
													object obj23 = obj22;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2382 @ X0_v77+E4]");
													bool flag38 = (nint)0 == 0;
													object obj24 = !flag38;
													if (obj24 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
													float num11 = num10 - 1f;
													bool flag39 = num11 < 0f;
													bool flag40 = num11 == 0f;
													object obj25 = num10 ^ 1;
													object obj26 = num10 ^ num11;
													object obj27 = obj25 & obj26;
													bool flag41 = (nint)obj27 < 0;
													bool flag42 = flag39 == flag41;
													object obj28 = !flag40;
													object obj29 = flag42 & obj28;
													num12 = (((int)(~obj29) != 0) ? 1f : num10);
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
													object obj30 = 0;
													list9._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
													object obj31 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73D8]");
													object obj32 = 0;
													list10._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
													array3 = (Material[])0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
													object obj33 = 0;
													list11._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													list12._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
													list13._002Ector();
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
													object obj34 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
													object obj35 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v74 (System.Collections.Generic.List`1<System.Int32>)+18]");
													bool flag43 = (nint)0 < (nint)1;
													array5 = (Vector3[])1145569280;
													list5 = list9;
													obj11 = (UnityEngine.Object)(object)normals;
													list7 = list12;
													list3 = list10;
													list2 = list11;
													list = list8;
													array2 = (Material[])4;
													value = null;
													if (!flag43)
													{
														Vector3[] array6 = (Vector3[])(bindposes + 32);
														object obj36 = default;
														mesh = (Mesh)(obj36 + 32);
														object obj37 = array7 + 32;
														obj38 = null;
														array5 = (Vector3[])1145569280;
														Vector3[] array8 = normals;
														array9 = (Material[])(object)bindposes;
														list = list8;
														int num13 = 0;
														array = array7;
														float num25 = default;
														object obj91 = default;
														object obj127 = default;
														object obj129 = default;
														while (true)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
															object obj39 = 0;
															num5 = (nint)obj39;
															int num14 = list.get_Item(num13);
															bool flag44 = num14 < boneWeights.Length;
															object obj40 = !flag44;
															list5 = list9;
															obj11 = (UnityEngine.Object)(object)array8;
															list7 = list12;
															list3 = list10;
															list2 = list11;
															array2 = (Material[])num13;
															value = null;
															array3 = array7;
															if (obj40 != null)
															{
																break;
															}
															bool flag45 = obj36 == null;
															list5 = list9;
															obj11 = (UnityEngine.Object)(object)array8;
															list7 = list12;
															list3 = list10;
															list2 = list11;
															array2 = (Material[])num13;
															value = null;
															array3 = array7;
															List<int> list15;
															List<int> list14;
															Vector3[] array10;
															if (!flag45)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																bool flag46 = (nint)0 == 0;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)array8;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																array2 = (Material[])num13;
																value = null;
																array3 = array7;
																if (flag46)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																bool flag47 = (nint)0 == 1;
																object obj41 = boneWeights + num14;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+20]");
																obj42 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+24]");
																num15 = 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+28]");
																num16 = 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+2C]");
																num10 = 0f;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+30]");
																array10 = (Vector3[])0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+34]");
																list14 = (List<int>)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+38]");
																int num17 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+3C]");
																array5 = (Vector3[])0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+30]");
																_ = 0;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)array8;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																list = (List<int>)num14;
																array2 = (Material[])num13;
																value = null;
																array3 = array7;
																if (flag47)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																bool flag48 = (nint)0 < (nint)2;
																object obj43 = !flag48;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																object obj44 = -2;
																bool flag49 = obj44 == null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+34]");
																_ = 0;
																object obj45 = ~obj43;
																object obj46 = obj45 | flag49;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)array8;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																list = (List<int>)num14;
																array2 = (Material[])num13;
																value = null;
																array3 = array7;
																if (obj46 != null)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																bool flag50 = (nint)0 == 3;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+38]");
																_ = 0;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)array8;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																list = (List<int>)num14;
																array2 = (Material[])num13;
																value = null;
																array3 = array7;
																if (flag50)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+3C]");
																_ = 0;
																bool flag51 = array == null;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)array8;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																list = (List<int>)num14;
																array2 = (Material[])num13;
																value = null;
																array3 = array7;
																if (!flag51)
																{
																	num17 = array.Length;
																	bool flag52 = array.Length == 0;
																	list5 = list9;
																	obj11 = (UnityEngine.Object)(object)array8;
																	list7 = list12;
																	list3 = list10;
																	list2 = list11;
																	list = (List<int>)num14;
																	array2 = (Material[])num13;
																	value = null;
																	array3 = array7;
																	if (flag52)
																	{
																		break;
																	}
																	bool flag53 = array.Length == 1;
																	Material[] array11 = array;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+20]");
																	array11[0] = (Material)0;
																	list5 = list9;
																	obj11 = (UnityEngine.Object)(object)array8;
																	list7 = list12;
																	list3 = list10;
																	list2 = list11;
																	list = (List<int>)num14;
																	array2 = (Material[])num13;
																	value = null;
																	array3 = array7;
																	if (flag53)
																	{
																		break;
																	}
																	bool flag54 = array.Length < 2;
																	object obj47 = !flag54;
																	object obj48 = array.Length - 2;
																	bool flag55 = obj48 == null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+24]");
																	_ = 0;
																	object obj49 = ~obj47;
																	object obj50 = obj49 | flag55;
																	list5 = list9;
																	obj11 = (UnityEngine.Object)(object)array8;
																	list7 = list12;
																	list3 = list10;
																	list2 = list11;
																	list = (List<int>)num14;
																	array2 = (Material[])num13;
																	value = null;
																	array3 = array7;
																	if (obj50 != null)
																	{
																		break;
																	}
																	bool flag56 = array.Length == 3;
																	Material[] array12 = array;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+28]");
																	array12[1] = (Material)0;
																	list5 = list9;
																	obj11 = (UnityEngine.Object)(object)array8;
																	list7 = list12;
																	list3 = list10;
																	list2 = list11;
																	list = (List<int>)num14;
																	array2 = (Material[])num13;
																	value = null;
																	array3 = array7;
																	if (flag56)
																	{
																		break;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																	object obj51 = 0 & 0xFFFFFFFFL;
																	num17 = (int)(num17 & 0xFFFFFFFFL);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X9_v19+2C]");
																	_ = 0;
																	list14 = null;
																	array5 = null;
																	while (true)
																	{
																		bool flag57 = num17 == (nint)array5;
																		list5 = list9;
																		obj11 = (UnityEngine.Object)(object)array8;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		list = (List<int>)num14;
																		array2 = (Material[])num13;
																		value = null;
																		array3 = array7;
																		if (flag57)
																		{
																			break;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X19_v28+v394 @ X9_v57 (UnityEngine.Vector3[])*4]");
																		num10 = 0f;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X19_v28+v394 @ X9_v57 (UnityEngine.Vector3[])*4]");
																		object obj59;
																		if ((nint)0 > (nint)0)
																		{
																			bool flag58 = System.Runtime.CompilerServices.Unsafe.As<Vector3[], UIntPtr>(ref array5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51);
																			object obj52 = !flag58;
																			list5 = list9;
																			obj11 = (UnityEngine.Object)(object)array8;
																			list7 = list12;
																			list3 = list10;
																			list2 = list11;
																			list = (List<int>)num14;
																			array2 = (Material[])num13;
																			value = null;
																			array3 = array7;
																			if (obj52 != null)
																			{
																				break;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v394 @ X9_v57 (UnityEngine.Vector3[])*4]");
																			object obj53 = 0 & 0x80000000L;
																			if (obj53 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v394 @ X9_v57 (UnityEngine.Vector3[])*4]");
																				object obj54 = -array9.Length;
																				bool flag59 = (nint)obj54 < 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v394 @ X9_v57 (UnityEngine.Vector3[])*4]");
																				object obj55 = (nint)0 ^ (nint)array9.Length;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v394 @ X9_v57 (UnityEngine.Vector3[])*4]");
																				object obj56 = 0 ^ obj54;
																				object obj57 = obj55 & obj56;
																				bool flag60 = (nint)obj57 < 0;
																				bool flag61 = flag59 == flag60;
																				object obj58 = !flag61;
																				obj59 = obj58;
																				goto IL_40a1;
																			}
																		}
																		obj59 = 0;
																		goto IL_40a1;
																		IL_40a1:
																		object obj60 = list14 & 1;
																		array5 = (Vector3[])(array5 + 1);
																		array10 = (Vector3[])(obj59 | obj60);
																		bool flag62 = array10 == null;
																		list15 = (List<int>)(!flag62);
																		bool flag63 = (nint)array5 != 4;
																		list14 = list15;
																		if (flag63)
																		{
																			continue;
																		}
																		goto IL_1309;
																	}
																	break;
																}
															}
															goto IL_3db4;
															IL_1309:
															Material[] array14;
															float num24;
															if (array10 != null)
															{
																bool flag64 = array8 == null;
																list14 = list15;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)array8;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																list = (List<int>)num14;
																array2 = (Material[])num13;
																value = null;
																array3 = array7;
																if (!flag64)
																{
																	bool flag65 = num14 < array8.Length;
																	object obj61 = !flag65;
																	object obj64;
																	object obj65;
																	if (num14 < array8.Length)
																	{
																		list14 = list15;
																		array5 = (Vector3[])num14;
																		list5 = list9;
																		obj11 = (UnityEngine.Object)(object)array8;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		list = (List<int>)num14;
																		array2 = (Material[])num13;
																		value = null;
																		array3 = array7;
																		if (obj61 != null)
																		{
																			break;
																		}
																		object obj62 = num14 * 12;
																		object obj63 = (object)array8 + obj62;
																		obj64 = obj63 + 32;
																		array5 = (Vector3[])(obj63 + 36);
																		int num17 = obj63 + 40;
																		obj65 = 12;
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																		object obj66 = 0;
																		object obj67 = obj66;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2663 @ X8_v181+A0]");
																		obj64 = (nint)0 + (nint)24;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2663 @ X8_v181+A0]");
																		array5 = (Vector3[])((nint)0 + (nint)28);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2663 @ X8_v181+A0]");
																		int num17 = (int)((nint)0 + (nint)32);
																		obj65 = 12;
																	}
																	object obj68 = num14 * obj65;
																	list14 = (List<int>)(object)((object)vertices + obj68);
																	list = (List<int>)(list14 + 32);
																	num10 = (float)obj64;
																	obj11 = null;
																	array2 = (Material[])num13;
																	while (true)
																	{
																		bool flag66 = (nint)obj11 < array.Length;
																		object obj69 = !flag66;
																		array10 = vertices;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		value = null;
																		array3 = array7;
																		if (obj69 != null)
																		{
																			break;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X19_v28+v444 @ X22_v1 (UnityEngine.Object)*4]");
																		num10 = 0f;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X19_v28+v444 @ X22_v1 (UnityEngine.Object)*4]");
																		int num22;
																		if ((nint)0 > (nint)0)
																		{
																			UnityEngine.Object obj70 = obj11;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																			bool flag67 = (nint)obj70 < 0;
																			object obj71 = !flag67;
																			array10 = vertices;
																			list5 = list9;
																			list7 = list12;
																			list3 = list10;
																			list2 = list11;
																			value = null;
																			array3 = array7;
																			if (obj71 != null)
																			{
																				break;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																			int num18 = 0;
																			bool flag68 = num18 == 0;
																			object obj72 = !flag68;
																			if (obj72 == null)
																			{
																				array5 = (Vector3[])bindposes.Length;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																				object obj73 = -bindposes.Length;
																				bool flag69 = (nint)obj73 < 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																				int num19 = (int)((nint)0 ^ (nint)bindposes.Length);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																				int num20 = 0 ^ obj73;
																				int num21 = num19 & num20;
																				bool flag70 = num21 < 0;
																				bool flag71 = flag69 == flag70;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																				if ((nint)0 >= (nint)bindposes.Length)
																				{
																					num22 = 0;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																					num22 = 0;
																				}
																				array = (Material[])flag71;
																				goto IL_49c3;
																			}
																		}
																		num22 = 0;
																		array = (Material[])1;
																		goto IL_49c3;
																		IL_4260:
																		bool flag72 = list11 == null;
																		array10 = vertices;
																		Vector3[] array13;
																		array5 = array13;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		array2 = array14;
																		value = null;
																		array3 = array7;
																		Vector3[] array15;
																		int num17;
																		if (!flag72)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																			object obj74 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
																			object obj75 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																			num17 = (int)((nint)0 + (nint)1);
																			array5 = (Vector3[])obj75;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																			bool flag73 = (nint)0 == 0;
																			array10 = vertices;
																			list5 = list9;
																			list7 = list12;
																			list3 = list10;
																			list2 = list11;
																			array2 = array14;
																			value = null;
																			array3 = array7;
																			if (!flag73)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																				num17 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v121+18]");
																				list14 = (List<int>)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																				nint num23 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v121+18]");
																				bool flag74 = num23 < 0;
																				object obj76 = !flag74;
																				Vector3 vector;
																				if (obj76 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																					object obj77 = (nint)0 * (nint)12;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																					object obj78 = 0 + obj77;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ X0_v84 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																					array5 = (Vector3[])((nint)0 + (nint)1);
																					bool flag75 = array == null;
																					object obj79 = !flag75;
																					num24 = num16;
																					array15 = array5;
																					vector = (Vector3)array14;
																					if (obj79 == null)
																					{
																						goto IL_1ec4;
																					}
																				}
																				else
																				{
																					Vector3 vector2 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2894 @ X8_v144 (UnityEngine.Vector3)+A8]");
																					object obj80 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2898 @ X8_v145+70]");
																					vector = (Vector3)0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2898 @ X8_v145+70]");
																					list11.AddWithResize((Vector3)0);
																					bool flag76 = array == null;
																					num16 = num25;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2898 @ X8_v145+70]");
																					array14 = (Material[])0;
																					num24 = num25;
																					array15 = (Vector3[])obj75;
																					if (flag76)
																					{
																						goto IL_1ec4;
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																				object obj81 = 0;
																				object obj82 = obj81;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2930 @ X8_v141+A0]");
																				object obj83 = 0;
																				num10 = (float)obj83;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2931 @ X8_v142+8]");
																				num15 = 0f;
																				array14 = (Material[])vector;
																				array = array7;
																				goto IL_4309;
																			}
																		}
																		goto IL_3db4;
																		IL_1ec4:
																		UnityEngine.Object obj84 = obj11;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																		bool flag77 = (nint)obj84 < 0;
																		object obj85 = !flag77;
																		array10 = vertices;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		array2 = array14;
																		value = null;
																		array3 = array7;
																		if (obj85 != null)
																		{
																			break;
																		}
																		array5 = (Vector3[])bindposes.Length;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																		bool flag78 = (nint)0 < (nint)bindposes.Length;
																		object obj86 = !flag78;
																		array10 = vertices;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		array2 = array14;
																		value = null;
																		array3 = array7;
																		if (obj86 != null)
																		{
																			break;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																		object obj87 = array6 + 0;
																		object obj88 = obj87 * obj89;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+10]");
																		object obj90 = 0 * obj91;
																		float num26 = (float)obj64;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+8]");
																		float num27 = num26 * 0f;
																		Vector3[] array16 = array5;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+18]");
																		object obj92 = array16 * 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+20]");
																		obj93 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+28]");
																		obj94 = 0;
																		object obj95 = obj88 + obj90;
																		num24 = num27 + (float)obj92;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+20]");
																		object obj96 = 0 * obj97;
																		int value3 = ((int*)num17)->m_value;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2942 @ X8_v149+28]");
																		obj42 = (nint)value3 * (nint)0;
																		num10 = (float)obj95 + (float)obj96;
																		num15 = num24 + (float)obj42;
																		array15 = array6;
																		array = array7;
																		goto IL_4309;
																		IL_49c3:
																		bool flag79 = list9 == null;
																		array10 = vertices;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		array2 = (Material[])num22;
																		value = null;
																		array3 = array7;
																		if (!flag79)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+10]");
																			object obj98 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																			object obj99 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																			num17 = (int)((nint)0 + (nint)1);
																			array5 = (Vector3[])obj99;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+10]");
																			bool flag80 = (nint)0 == 0;
																			array10 = vertices;
																			list5 = list9;
																			list7 = list12;
																			list3 = list10;
																			list2 = list11;
																			array2 = (Material[])num22;
																			value = null;
																			array3 = array7;
																			if (!flag80)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+18]");
																				num17 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v116+18]");
																				list14 = (List<int>)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+18]");
																				nint num28 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v116+18]");
																				bool flag81 = num28 < 0;
																				object obj100 = !flag81;
																				if (obj100 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+10]");
																					nint num29 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+18]");
																					object obj101 = num29 + 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2423 @ X0_v80 (System.Collections.Generic.List`1<System.Int32>)+18]");
																					array5 = (Vector3[])((nint)0 + (nint)1);
																				}
																				else
																				{
																					Vector3 vector3 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2764 @ X8_v170 (UnityEngine.Vector3)+A8]");
																					object obj102 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2766 @ X8_v171+70]");
																					num5 = 0;
																					list9.AddWithResize(num22);
																				}
																				object obj103 = array & 1;
																				bool flag82 = obj103 == null;
																				object obj104 = !flag82;
																				num10 = 0f;
																				if (obj104 == null)
																				{
																					bool flag83 = (nint)obj11 < array7.Length;
																					object obj105 = !flag83;
																					array10 = vertices;
																					num10 = 0f;
																					list5 = list9;
																					list7 = list12;
																					list3 = list10;
																					list2 = list11;
																					array2 = (Material[])num22;
																					value = null;
																					array3 = array7;
																					if (obj105 != null)
																					{
																						break;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X19_v28+v444 @ X22_v1 (UnityEngine.Object)*4]");
																					num10 = 0f;
																				}
																				bool flag84 = list10 == null;
																				array10 = vertices;
																				list5 = list9;
																				list7 = list12;
																				list3 = list10;
																				list2 = list11;
																				array2 = (Material[])num22;
																				value = null;
																				array3 = array7;
																				if (!flag84)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+10]");
																					object obj106 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73B0]");
																					object obj107 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+1C]");
																					num17 = (int)((nint)0 + (nint)1);
																					array5 = (Vector3[])obj107;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+10]");
																					bool flag85 = (nint)0 == 0;
																					array10 = vertices;
																					list5 = list9;
																					list7 = list12;
																					list3 = list10;
																					list2 = list11;
																					array2 = (Material[])num22;
																					value = null;
																					array3 = array7;
																					if (!flag85)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+18]");
																						num17 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v119+18]");
																						list14 = (List<int>)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+18]");
																						nint num30 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v119+18]");
																						bool flag86 = num30 < 0;
																						object obj108 = !flag86;
																						if (obj108 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+10]");
																							nint num31 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+18]");
																							object obj109 = num31 + 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X0_v82 (System.Collections.Generic.List`1<System.Single>)+18]");
																							array5 = (Vector3[])((nint)0 + (nint)1);
																							bool flag87 = array == null;
																							object obj110 = !flag87;
																							array2 = (Material[])num22;
																							array13 = array5;
																							array14 = (Material[])num22;
																							if (obj110 == null)
																							{
																								goto IL_1a29;
																							}
																						}
																						else
																						{
																							Vector3 vector4 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2797 @ X8_v160 (UnityEngine.Vector3)+A8]");
																							object obj111 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2799 @ X8_v161+70]");
																							array2 = (Material[])0;
																							list10.AddWithResize(num10);
																							bool flag88 = array == null;
																							array13 = (Vector3[])obj107;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2799 @ X8_v161+70]");
																							array14 = (Material[])0;
																							if (flag88)
																							{
																								goto IL_1a29;
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																						object obj112 = 0;
																						object obj113 = obj112;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2832 @ X8_v157+A0]");
																						object obj114 = 0;
																						num10 = (float)obj114;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2833 @ X8_v158+8]");
																						num15 = 0f;
																						goto IL_4260;
																					}
																				}
																			}
																		}
																		goto IL_3db4;
																		IL_4309:
																		bool flag89 = list12 == null;
																		array10 = vertices;
																		num16 = num24;
																		array5 = array15;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		array2 = array14;
																		value = null;
																		array3 = array7;
																		if (!flag89)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																			object obj115 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
																			object obj116 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																			num17 = (int)((nint)0 + (nint)1);
																			array5 = (Vector3[])obj116;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																			bool flag90 = (nint)0 == 0;
																			array10 = vertices;
																			num16 = num24;
																			list5 = list9;
																			list7 = list12;
																			list3 = list10;
																			list2 = list11;
																			array2 = array14;
																			value = null;
																			array3 = array7;
																			if (!flag90)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																				num17 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v123+18]");
																				list14 = (List<int>)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																				nint num32 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v123+18]");
																				bool flag91 = num32 < 0;
																				object obj117 = !flag91;
																				if (obj117 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																					object obj118 = (nint)0 * (nint)12;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																					object obj119 = 0 + obj118;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2462 @ X0_v86 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																					array5 = (Vector3[])((nint)0 + (nint)1);
																				}
																				else
																				{
																					Vector3 vector5 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2985 @ X8_v132 (UnityEngine.Vector3)+A8]");
																					object obj120 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2988 @ X8_v133+70]");
																					list12.AddWithResize((Vector3)0);
																					num24 = num25;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2988 @ X8_v133+70]");
																					array14 = (Material[])0;
																				}
																				obj11 = (UnityEngine.Object)(obj11 + 1);
																				bool flag92 = (nint)obj11 != 4;
																				num16 = num24;
																				array2 = array14;
																				if (flag92)
																				{
																					continue;
																				}
																				goto IL_232b;
																			}
																		}
																		goto IL_3db4;
																		IL_1a29:
																		UnityEngine.Object obj121 = obj11;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X0_v90+18]");
																		bool flag93 = (nint)obj121 < 0;
																		object obj122 = !flag93;
																		array10 = vertices;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		value = null;
																		array3 = array7;
																		if (obj122 != null)
																		{
																			break;
																		}
																		bool flag94 = num14 < vertices.Length;
																		object obj123 = !flag94;
																		array10 = vertices;
																		array5 = (Vector3[])num14;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		value = null;
																		array3 = array7;
																		if (obj123 != null)
																		{
																			break;
																		}
																		array5 = (Vector3[])bindposes.Length;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																		bool flag95 = (nint)0 < (nint)bindposes.Length;
																		object obj124 = !flag95;
																		array10 = vertices;
																		list5 = list9;
																		list7 = list12;
																		list3 = list10;
																		list2 = list11;
																		value = null;
																		array3 = array7;
																		if (obj124 != null)
																		{
																			break;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X24_v2 (UnityEngine.Mesh)+v444 @ X22_v1 (UnityEngine.Object)*4]");
																		object obj125 = array6 + 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+28]");
																		vector6 = (Vector3)0;
																		object obj126 = obj125 * obj127;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+10]");
																		object obj128 = 0 * obj129;
																		List<int> list16 = list;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+8]");
																		object obj130 = list16 * 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X23_v1 (System.Collections.Generic.List`1<System.Int32>)+4]");
																		nint num33 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+18]");
																		object obj131 = num33 * 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X23_v1 (System.Collections.Generic.List`1<System.Int32>)+8]");
																		obj93 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+20]");
																		obj94 = 0;
																		object obj132 = obj126 + obj128;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+20]");
																		object obj133 = 0 * obj91;
																		object obj134 = obj130 + obj131;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X23_v1 (System.Collections.Generic.List`1<System.Int32>)+8]");
																		nint num34 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+28]");
																		object obj135 = num34 * 0;
																		object obj136 = obj132 + obj133;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+38]");
																		obj42 = 0;
																		num16 = (float)obj134 + (float)obj135;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+30]");
																		num10 = 0f + (float)obj136;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2848 @ X8_v167+38]");
																		num15 = 0f + num16;
																		array13 = array6;
																		array14 = array2;
																		goto IL_4260;
																	}
																	break;
																}
																goto IL_3db4;
															}
															list14 = list15;
															list = list8;
															goto IL_414e;
															IL_414e:
															array2 = (Material[])(num13 + num12);
															Material[] array17 = array2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X23_v1 (System.Collections.Generic.List`1<System.Int32>)+18]");
															bool flag96 = (nint)array17 < 0;
															array5 = (Vector3[])num12;
															num13 = (int)array2;
															if (flag96)
															{
																continue;
															}
															goto IL_256e;
															IL_232b:
															bool flag97 = list13 == null;
															array10 = vertices;
															num16 = num24;
															list5 = list9;
															list7 = list12;
															list3 = list10;
															list2 = list11;
															array2 = array14;
															value = null;
															array3 = array7;
															if (!flag97)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+10]");
																object obj137 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
																object obj138 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+1C]");
																int num17 = (int)((nint)0 + (nint)1);
																array5 = (Vector3[])obj138;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+10]");
																bool flag98 = (nint)0 == 0;
																array10 = vertices;
																num16 = num24;
																list5 = list9;
																obj11 = (UnityEngine.Object)(object)normals;
																list7 = list12;
																list3 = list10;
																list2 = list11;
																list = list8;
																array2 = array14;
																value = null;
																array3 = array7;
																if (!flag98)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	num17 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v125+18]");
																	list14 = (List<int>)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+18]");
																	nint num35 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v125+18]");
																	bool flag99 = num35 < 0;
																	object obj139 = !flag99;
																	if (obj139 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+18]");
																		object obj140 = (nint)0 + (nint)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+10]");
																		nint num36 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ X0_v88 (System.Collections.Generic.List`1<System.Int32>)+18]");
																		object obj141 = num36 + 0;
																	}
																	else
																	{
																		Vector3 vector7 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3090 @ X8_v129 (UnityEngine.Vector3)+A8]");
																		object obj142 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3092 @ X8_v130+70]");
																		num5 = 0;
																		list13.AddWithResize(num14);
																	}
																	UnityEngine.Object obj143 = (UnityEngine.Object)(obj38 + 1);
																	array10 = vertices;
																	num16 = num24;
																	obj38 = obj143;
																	array8 = normals;
																	array9 = (Material[])(object)bindposes;
																	list = list8;
																	goto IL_414e;
																}
															}
															goto IL_3db4;
														}
														goto IL_3dc2;
													}
												}
											}
											goto IL_3658;
										}
									}
								}
								goto IL_3db4;
							}
						}
						goto IL_3658;
					}
				}
				else
				{
					nint num37 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1884 @ X0_v206 (Il2CppClass<UnityEngine.Material[]>)+E4]");
					bool flag100 = (nint)0 == 0;
					object obj144 = !flag100;
					nint num38 = num37;
					if (obj144 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num38 = (nint)array;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v207 (Il2CppClass<UnityEngine.Material[]>)+A0]");
					object obj145 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v209+10]");
					array5 = (Vector3[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v209+10]");
					bool flag101 = (nint)0 == 0;
					val = (Enumerator<, >)0;
					val2 = (Enumerator<>)0;
					num5 = (nint)(&value);
					mesh = m;
					array3 = mats;
					if (!flag101)
					{
						int num39 = array5.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+1C]");
						int num17 = (int)((nint)0 + (nint)1);
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Store into unknown operand: v394.Length");
						if (array5.Length >= 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+10]");
							Array.Clear((Array)0, 0, array5.Length);
							nint num40 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2007 @ X8_v225 (Il2CppClass<UnityEngine.Material[]>)+A0]");
							obj145 = 0;
							array4 = null;
							array2 = null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v209+8]");
						bool flag102 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						val2 = (Enumerator<>)0;
						num5 = num39;
						mesh = m;
						array3 = mats;
						if (!flag102)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7370]");
							object obj146 = 0;
							array2 = (Material[])obj146;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v209+8]");
							Dictionary<System.__Canon, System.__Canon>.KeyCollection keys = ((Dictionary<System.__Canon, System.__Canon>)0).Keys;
							bool flag103 = keys == null;
							val = (Enumerator<, >)0;
							val2 = (Enumerator<>)0;
							num5 = num39;
							mesh = m;
							array3 = mats;
							if (!flag103)
							{
								Enumerator<> enumerator = keys.GetEnumerator();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7388]");
								object obj147 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								obj11 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
								List<int> list = (List<int>)0;
								array5 = (Vector3[])(&val2);
								float num44 = default;
								object obj153;
								Enumerator<> val3;
								while (val2.MoveNext())
								{
									nint num41 = (nint)obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ X0_v215 (Il2CppClass<UnityEngine.Object>)+E4]");
									bool flag104 = (nint)0 == 0;
									object obj148 = !flag104;
									if (obj148 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag105 = obj149 == null;
									bool flag106 = !flag105;
									num39 = 0;
									if (flag106)
									{
										continue;
									}
									nint num42 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ X0_v219 (Il2CppClass<UnityEngine.Material[]>)+E4]");
									bool flag107 = (nint)0 == 0;
									object obj150 = !flag107;
									nint num43 = num42;
									if (obj150 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										num43 = (nint)array;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2232 @ X0_v220 (Il2CppClass<UnityEngine.Material[]>)+A0]");
									object obj151 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ X8_v219+10]");
									List<System.__Canon> list17 = (List<System.__Canon>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ X8_v219+10]");
									bool flag108 = (nint)0 == 0;
									val = (Enumerator<, >)0;
									obj152 = null;
									obj153 = 0;
									val2 = (Enumerator<>)num44;
									val3 = (Enumerator<>)(ref val2);
									num10 = num44;
									array2 = null;
									num5 = unchecked((nint)null);
									mesh = m;
									array3 = mats;
									if (!flag108)
									{
										System.__Canon[] items = list17._items;
										array5 = (Vector3[])(object)list;
										num17 = list17._version + 1;
										list17._version = num17;
										bool flag109 = list17._items == null;
										val = (Enumerator<, >)0;
										obj152 = null;
										obj153 = 0;
										val2 = (Enumerator<>)num44;
										val3 = (Enumerator<>)(ref val2);
										num10 = num44;
										array2 = null;
										num5 = unchecked((nint)null);
										mesh = m;
										array3 = mats;
										if (!flag109)
										{
											num17 = list17._size;
											List<int> list14 = (List<int>)items.Length;
											bool flag110 = list17._size < items.Length;
											object obj154 = !flag110;
											if (obj154 == null)
											{
												object obj155 = list17._items + list17._size;
												int num45 = ++list17._size;
												object obj156 = obj155 + 32;
												obj156 = obj149;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												array5 = (Vector3[])num45;
												num39 = 0;
											}
											else
											{
												Vector3 vector8 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array5[0]);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2276 @ X8_v221 (UnityEngine.Vector3)+A8]");
												object obj157 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ X8_v222+70]");
												num39 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ X8_v219+10]");
												((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)obj149);
											}
											continue;
										}
									}
									goto IL_3dd8;
								}
								val = (Enumerator<, >)0;
								System.__Canon _Canon = null;
								obj153 = 0;
								val2 = (Enumerator<>)num44;
								val3 = (Enumerator<>)(ref val2);
								num10 = num44;
								object obj158 = 6;
								num5 = num39;
								mesh = m;
								array3 = mats;
								object obj159 = 0;
								float num50 = default;
								GillaSlice.Points result2 = default;
								object obj170 = default;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7380]");
									object obj160 = 0;
									array2 = (Material[])obj160;
									((Enumerator<>*)val3)->Dispose();
									bool flag111 = obj159 == null;
									object obj161 = !flag111;
									obj152 = (UnityEngine.Object)(object)_Canon;
									OutOfMemoryException ex;
									if (obj161 == null)
									{
										bool flag112 = _Canon == null;
										object obj162 = !flag112;
										obj152 = (UnityEngine.Object)(object)_Canon;
										ex = (OutOfMemoryException)val3;
										if (obj162 != null)
										{
											goto IL_3dff;
										}
										if ((nint)obj158 != 6)
										{
											bool flag113 = obj158 == null;
											object obj163 = !flag113;
											result = (GillaSlice.Points)val3;
											if (obj163 != null)
											{
												break;
											}
										}
										nint num46 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2181 @ X0_v7 (Il2CppClass<UnityEngine.Material[]>)+E4]");
										bool flag114 = (nint)0 == 0;
										object obj164 = !flag114;
										nint num47 = num46;
										if (obj164 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											num47 = (nint)array;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ X0_v8 (Il2CppClass<UnityEngine.Material[]>)+A0]");
										object obj165 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X8_v10+10]");
										bool flag115 = (nint)0 == 0;
										obj149 = (UnityEngine.Object)(object)_Canon;
										if (flag115)
										{
											goto IL_3db4;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X8_v10+10]");
										Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
										object obj166 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7358]");
										obj11 = (UnityEngine.Object)0;
										while (true)
										{
											array2 = (Material[])obj166;
											if (!val.MoveNext())
											{
												break;
											}
											nint num48 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2264 @ X0_v15 (Il2CppClass<UnityEngine.Material[]>)+E4]");
											bool flag116 = (nint)0 == 0;
											object obj167 = !flag116;
											nint num49 = num48;
											if (obj167 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												num49 = (nint)array;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2278 @ X0_v16 (Il2CppClass<UnityEngine.Material[]>)+A0]");
											object obj168 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ X8_v20+8]");
											bool flag117 = (nint)0 == 0;
											val = (Enumerator<, >)num50;
											obj152 = null;
											obj153 = 0;
											val3 = (Enumerator<>)(ref val);
											num10 = num50;
											array5 = (Vector3[])(&val);
											if (!flag117)
											{
												num5 = (nint)obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ X8_v20+8]");
												bool flag118 = ((Dictionary<System.__Canon, System.__Canon>)0).Remove(_Canon);
												continue;
											}
											goto IL_3de6;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
										object obj169 = 0;
										array2 = (Material[])obj169;
										val.Dispose();
										val = (Enumerator<, >)num50;
										obj152 = null;
										obj153 = 0;
										val3 = (Enumerator<>)(ref val);
										num10 = num50;
										array5 = (Vector3[])(&val);
									}
									ex = new OutOfMemoryException();
									goto IL_3dff;
									IL_3dff:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
									if ((nint)array2 == 2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj152 = (UnityEngine.Object)1;
										obj159 = obj153;
									}
									else
									{
										if ((nint)array2 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DFF0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
											return result2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										obj159 = obj170;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj153 = obj170;
									}
									_Canon = (System.__Canon)(object)obj152;
									obj158 = 0;
								}
								goto IL_46cc;
							}
						}
					}
				}
			}
		}
		goto IL_3db4;
		IL_3dc2:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		obj152 = obj149;
		goto IL_3dd8;
		IL_256e:
		bool flag119 = (nint)obj38 < 1;
		array5 = (Vector3[])num12;
		list5 = list9;
		obj11 = obj38;
		list7 = list12;
		list3 = list10;
		list2 = list11;
		value = null;
		array3 = array7;
		if (flag119)
		{
			goto IL_3658;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E8]");
		object obj171 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj172 = default;
		obj172._002Ector();
		bool flag120 = obj172 == null;
		array5 = (Vector3[])num12;
		list5 = list9;
		obj11 = obj38;
		list7 = list12;
		list3 = list10;
		list2 = list11;
		array2 = null;
		value = null;
		mesh = m;
		array3 = array7;
		if (!flag120)
		{
			bool flag121 = list9 == null;
			array5 = (Vector3[])num12;
			list5 = list9;
			obj11 = obj38;
			list7 = list12;
			list3 = list10;
			list2 = list11;
			array2 = null;
			value = null;
			mesh = m;
			array3 = array7;
			if (!flag121)
			{
				int[] array18 = list9.ToArray();
				object obj173 = obj172 + 24;
				obj173 = array18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag122 = list10 == null;
				array5 = (Vector3[])num12;
				list5 = list9;
				obj11 = obj38;
				list7 = list12;
				list3 = list10;
				list2 = list11;
				array2 = (Material[])(object)array18;
				value = null;
				mesh = m;
				array3 = array7;
				if (!flag122)
				{
					float[] array19 = list10.ToArray();
					object obj174 = obj172 + 32;
					obj174 = array19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag123 = list11 == null;
					array5 = (Vector3[])num12;
					list5 = list9;
					obj11 = obj38;
					list7 = list12;
					list3 = list10;
					list2 = list11;
					array2 = (Material[])(object)array19;
					value = null;
					mesh = m;
					array3 = array7;
					if (!flag123)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43D0]");
						array3 = (Material[])0;
						Vector3[] array20 = list11.ToArray();
						object obj175 = obj172 + 40;
						obj175 = array20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag124 = list12 == null;
						array5 = (Vector3[])num12;
						list5 = list9;
						obj11 = obj38;
						list7 = list12;
						list3 = list10;
						list2 = list11;
						array2 = (Material[])(object)array20;
						value = null;
						mesh = m;
						if (!flag124)
						{
							Vector3[] array21 = list12.ToArray();
							object obj176 = obj172 + 48;
							obj176 = array21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int blendShapeCount = m.blendShapeCount;
							bool flag125 = blendShapeCount < 1;
							array5 = (Vector3[])num12;
							list5 = list9;
							obj11 = obj38;
							list7 = list12;
							list3 = list10;
							list2 = list11;
							array2 = null;
							value = (System.__Canon)obj172;
							if (flag125)
							{
								goto IL_3658;
							}
							int blendShapeCount2 = m.blendShapeCount;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73F0]");
							object obj177 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							bool flag126 = obj172 == null;
							array5 = (Vector3[])num12;
							list5 = list9;
							obj11 = obj38;
							list7 = list12;
							list3 = list10;
							list2 = list11;
							array2 = (Material[])blendShapeCount2;
							value = (System.__Canon)obj172;
							mesh = m;
							if (!flag126)
							{
								object obj178 = obj172 + 56;
								object obj179 = default;
								obj178 = obj179;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
								array5 = (Vector3[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								int blendShapeCount3 = m.blendShapeCount;
								bool flag127 = blendShapeCount3 < 1;
								list5 = list9;
								obj11 = obj38;
								list7 = list12;
								list3 = list10;
								list2 = list11;
								array2 = null;
								value = (System.__Canon)obj172;
								if (flag127)
								{
									goto IL_3658;
								}
								Material[] array22 = (Material[])((object)obj38 << 2);
								list2 = (List<Vector3>)(array9 + 32);
								Vector3 vector9 = vector6;
								object obj180 = obj94;
								object obj181 = obj93;
								float num51 = num16;
								float num52 = num15;
								object obj182 = obj42;
								float num53 = num10;
								Mesh mesh2 = m;
								Material[] array23 = null;
								Vector3[] array24 = default;
								Mesh mesh3 = default;
								object obj198 = default;
								while (true)
								{
									int blendShapeFrameCount = mesh2.GetBlendShapeFrameCount((int)array23);
									int num54 = blendShapeFrameCount - 1;
									mesh2.GetBlendShapeFrameVertices((int)array23, num54, array24, null, null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
									object obj183 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Vector3[] array25 = (Vector3[])(mesh3 + 40);
									List<int> list14 = list13;
									obj11 = null;
									array2 = array22;
									array3 = array23;
									int num55 = 0;
									object obj185;
									Vector3[] array26;
									Vector3[] array27;
									Vector3[] array4;
									while (true)
									{
										array5 = (Vector3[])((object)obj11 << 2);
										object obj184 = obj11 * 12;
										list3 = (List<float>)(object)((object)array25 + obj184);
										List<int> list = (List<int>)(array5 + 32);
										int num17 = (int)array25;
										list7 = null;
										nint num5 = num54;
										while (true)
										{
											bool flag128 = obj172 == null;
											obj185 = 0;
											array26 = null;
											array27 = null;
											vector6 = vector9;
											obj94 = obj180;
											obj93 = obj181;
											num16 = num51;
											num15 = num52;
											obj42 = obj182;
											num10 = num53;
											list5 = (List<int>)12;
											array4 = array24;
											value = (System.__Canon)obj172;
											mesh = mesh3;
											array = (Material[])num55;
											if (flag128)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+20]");
											array5 = (Vector3[])0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+20]");
											bool flag129 = (nint)0 == 0;
											obj185 = 0;
											array26 = null;
											array27 = null;
											vector6 = vector9;
											obj94 = obj180;
											obj93 = obj181;
											num16 = num51;
											num15 = num52;
											obj42 = obj182;
											num10 = num53;
											list5 = (List<int>)12;
											array4 = array24;
											value = (System.__Canon)obj172;
											mesh = mesh3;
											array = (Material[])num55;
											if (flag129)
											{
												break;
											}
											num17 = array5.Length;
											array3 = (Material[])(object)((object)obj11 + (object)list7);
											bool flag130 = (nint)array3 < array5.Length;
											object obj186 = !flag130;
											obj185 = 0;
											array26 = null;
											array27 = null;
											vector6 = vector9;
											obj94 = obj180;
											obj93 = obj181;
											num16 = num51;
											num15 = num52;
											obj42 = obj182;
											num10 = num53;
											list5 = (List<int>)12;
											array4 = array24;
											value = (System.__Canon)obj172;
											mesh = mesh3;
											array = (Material[])num55;
											if (obj186 == null)
											{
												array5 = (Vector3[])(object)((object)array5 + (object)list);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)*4]");
												num10 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)*4]");
												if ((nint)0 <= (nint)0)
												{
													goto IL_442a;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+18]");
												object obj187 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+18]");
												bool flag131 = (nint)0 == 0;
												obj185 = 0;
												array26 = null;
												array27 = null;
												vector6 = vector9;
												obj94 = obj180;
												obj93 = obj181;
												num16 = num51;
												num15 = num52;
												obj42 = obj182;
												list5 = (List<int>)12;
												array4 = array24;
												value = (System.__Canon)obj172;
												mesh = mesh3;
												array = (Material[])num55;
												if (flag131)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v102+18]");
												array5 = (Vector3[])0;
												Material[] array28 = array3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v102+18]");
												bool flag132 = (nint)array28 < 0;
												object obj188 = !flag132;
												obj185 = 0;
												array26 = null;
												array27 = null;
												vector6 = vector9;
												obj94 = obj180;
												obj93 = obj181;
												num16 = num51;
												num15 = num52;
												obj42 = obj182;
												list5 = (List<int>)12;
												array4 = array24;
												value = (System.__Canon)obj172;
												mesh = mesh3;
												array = (Material[])num55;
												if (obj188 == null)
												{
													bool flag133 = list14 == null;
													obj185 = 0;
													array26 = null;
													array27 = null;
													vector6 = vector9;
													obj94 = obj180;
													obj93 = obj181;
													num16 = num51;
													num15 = num52;
													obj42 = obj182;
													list5 = (List<int>)12;
													array4 = array24;
													value = (System.__Canon)obj172;
													mesh = mesh3;
													array = (Material[])num55;
													if (flag133)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+18]");
													object obj189 = 0 + list;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3134 @ X8_v103+v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)*4]");
													array9 = (Material[])0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5638]");
													object obj190 = 0;
													num5 = (nint)obj190;
													int num56 = list14.get_Item(num55);
													bool flag134 = array24 == null;
													obj185 = 0;
													array26 = null;
													array27 = null;
													vector6 = vector9;
													obj94 = obj180;
													obj93 = obj181;
													num16 = num51;
													num15 = num52;
													obj42 = obj182;
													list5 = (List<int>)12;
													array4 = array24;
													array2 = (Material[])num55;
													value = (System.__Canon)obj172;
													mesh = mesh3;
													array = (Material[])num55;
													if (flag134)
													{
														break;
													}
													bool flag135 = num56 < array24.Length;
													object obj191 = !flag135;
													obj185 = 0;
													array26 = null;
													array27 = null;
													vector6 = vector9;
													obj94 = obj180;
													obj93 = obj181;
													num16 = num51;
													num15 = num52;
													obj42 = obj182;
													list5 = (List<int>)12;
													array4 = array24;
													array2 = (Material[])num55;
													value = (System.__Canon)obj172;
													mesh = mesh3;
													array = (Material[])num55;
													if (obj191 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3134 @ X8_v103+v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)*4]");
														bool flag136 = (nint)0 < (nint)bindposes.Length;
														object obj192 = !flag136;
														obj185 = 0;
														array26 = null;
														array27 = null;
														vector6 = vector9;
														obj94 = obj180;
														obj93 = obj181;
														list14 = list13;
														num16 = num51;
														num15 = num52;
														obj42 = obj182;
														list5 = (List<int>)12;
														array4 = array24;
														array2 = (Material[])num55;
														value = (System.__Canon)obj172;
														mesh = mesh3;
														array = (Material[])num55;
														if (obj192 == null)
														{
															bool flag137 = (object)mesh3 == null;
															obj185 = 0;
															array26 = null;
															array27 = null;
															vector6 = vector9;
															obj94 = obj180;
															obj93 = obj181;
															list14 = list13;
															num16 = num51;
															num15 = num52;
															obj42 = obj182;
															list5 = (List<int>)12;
															array4 = array24;
															array2 = (Material[])num55;
															value = (System.__Canon)obj172;
															mesh = mesh3;
															array = (Material[])num55;
															if (flag137)
															{
																break;
															}
															Material[] array29 = array3;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3041 @ X0_v136 (UnityEngine.Mesh)+18]");
															bool flag138 = (nint)array29 < 0;
															object obj193 = !flag138;
															obj185 = 0;
															array26 = null;
															array27 = null;
															vector6 = vector9;
															obj94 = obj180;
															obj93 = obj181;
															list14 = list13;
															num16 = num51;
															num15 = num52;
															obj42 = obj182;
															list5 = (List<int>)12;
															array4 = array24;
															array2 = (Material[])num55;
															value = (System.__Canon)obj172;
															mesh = mesh3;
															array = (Material[])num55;
															if (obj193 == null)
															{
																object obj194 = num56 * 12;
																object obj195 = (object)array24 + obj194;
																List<Vector3> list18 = list2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3134 @ X8_v103+v2093 @ X26_v23 (System.Collections.Generic.List`1<UnityEngine.Vector3>)*4]");
																array5 = (Vector3[])(list18 + 0);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+28]");
																vector9 = (Vector3)0;
																object obj196 = (object)array5 * obj97;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+10]");
																object obj197 = 0 * obj198;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3130 @ X8_v110+20]");
																nint num57 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+8]");
																obj182 = num57 * 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3130 @ X8_v110+24]");
																object obj199 = (nint)0 * (nint)array5.Length;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3130 @ X8_v110+28]");
																obj180 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+20]");
																obj181 = 0 * obj89;
																object obj200 = obj196 + obj197;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3130 @ X8_v110+28]");
																nint num58 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v57 (UnityEngine.Vector3[])+28]");
																object obj201 = num58 * 0;
																num52 = (float)obj182 + (float)obj199;
																num10 = (float)obj200 + (float)obj181;
																num51 = num52 + (float)obj201;
																list3 = (List<float>)num51;
																list14 = list13;
																array2 = (Material[])num55;
																goto IL_442a;
															}
														}
													}
												}
											}
											goto IL_3dc2;
											IL_442a:
											list7 = (List<Vector3>)(list7 + 1);
											list3 = (List<float>)(list3 + 12);
											bool flag139 = (nint)list7 != 4;
											num53 = num10;
											if (flag139)
											{
												continue;
											}
											goto IL_3346;
										}
										break;
										IL_3346:
										array = (Material[])(num55 + 1);
										obj11 = (UnityEngine.Object)(obj11 + 4);
										bool flag140 = (object)array != obj38;
										num53 = num10;
										num54 = (int)num5;
										num55 = (int)array;
										if (flag140)
										{
											continue;
										}
										goto IL_3399;
									}
									break;
									IL_3399:
									bool flag141 = obj172 == null;
									obj185 = 0;
									array26 = null;
									array27 = null;
									vector6 = vector9;
									obj94 = obj180;
									obj93 = obj181;
									num16 = num51;
									num15 = num52;
									obj42 = obj182;
									list5 = (List<int>)12;
									array4 = array24;
									value = (System.__Canon)obj172;
									mesh = mesh3;
									if (flag141)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+38]");
									object obj202 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+38]");
									bool flag142 = (nint)0 == 0;
									obj185 = 0;
									array26 = null;
									array27 = null;
									vector6 = vector9;
									obj94 = obj180;
									obj93 = obj181;
									num16 = num51;
									num15 = num52;
									obj42 = obj182;
									list5 = (List<int>)12;
									array4 = array24;
									value = (System.__Canon)obj172;
									mesh = mesh3;
									array3 = array23;
									if (flag142)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v101+18]");
									array5 = (Vector3[])0;
									Material[] array30 = array23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v101+18]");
									bool flag143 = (nint)array30 < 0;
									object obj203 = !flag143;
									obj185 = 0;
									array26 = null;
									array27 = null;
									vector6 = vector9;
									obj94 = obj180;
									obj93 = obj181;
									num16 = num51;
									num15 = num52;
									obj42 = obj182;
									list5 = (List<int>)12;
									array4 = array24;
									value = (System.__Canon)obj172;
									mesh = mesh3;
									array3 = array23;
									if (obj203 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v98 (System.Object)+38]");
										object obj204 = 0 + array23;
										object obj205 = obj204 + 32;
										obj205 = mesh3;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										array3 = (Material[])(array23 + 1);
										int blendShapeCount4 = m.blendShapeCount;
										bool flag144 = (nint)array3 < blendShapeCount4;
										obj185 = 0;
										array26 = null;
										array27 = null;
										vector6 = vector9;
										obj94 = obj180;
										obj93 = obj181;
										num16 = num51;
										num15 = num52;
										obj42 = obj182;
										list5 = (List<int>)12;
										array4 = array24;
										array2 = null;
										value = (System.__Canon)obj172;
										num53 = num10;
										mesh2 = m;
										array23 = array3;
										if (flag144)
										{
											continue;
										}
										goto IL_3658;
									}
									goto IL_3dc2;
								}
							}
						}
					}
				}
			}
		}
		goto IL_3db4;
		IL_46cc:
		return result;
		IL_36d6:
		result = (GillaSlice.Points)(object)value;
		goto IL_46cc;
		IL_3de6:
		throw new NullReferenceException();
		IL_3dd8:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_3de6;
		IL_3658:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
		object obj206 = 0;
		object obj207 = obj206;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2005 @ X0_v56+E4]");
		bool flag145 = (nint)0 == 0;
		object obj208 = !flag145;
		if (obj208 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj207 = obj206;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2005 @ X0_v56+A0]");
		object obj209 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v34+8]");
		bool flag146 = (nint)0 == 0;
		mesh = m;
		if (!flag146)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v34+8]");
			((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)m, value);
			goto IL_36d6;
		}
		goto IL_3db4;
		IL_3db4:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_3dc2;
	}

	static GillaSkin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7340]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7400]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7410]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+A0]");
		object obj9 = 0;
		object obj10 = default;
		obj9 = obj10;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+A0]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+A0]");
		object obj15 = (nint)0 + (nint)16;
		obj15 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+A0]");
		object obj17 = (nint)0 + (nint)24;
		obj17 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v9+A0]");
		object obj19 = (nint)0 + (nint)32;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v14+A0]");
		object obj23 = (nint)0 + (nint)40;
		object obj24 = default;
		obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v17+A0]");
		object obj26 = (nint)0 + (nint)48;
		object obj27 = default;
		obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v20+A0]");
		object obj29 = (nint)0 + (nint)56;
		object obj30 = default;
		obj29 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v23+A0]");
		object obj32 = (nint)0 + (nint)64;
		object obj33 = default;
		obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
