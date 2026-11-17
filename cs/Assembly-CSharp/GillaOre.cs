using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using Fusion.Matchmaking;
using Fusion.Photon.Realtime;
using Photon.Client;
using Photon.Realtime;
using PlayFab.Public;
using UnityEngine;

public class GillaOre : MonoBehaviour
{
	private sealed class _003CLook_003Ed__25 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GillaOnline _003C_003E4__this;

		private GillaOnline._003C_003Ec__DisplayClass25_1 _003C_003E8__1;

		private GillaOnline._003C_003Ec__DisplayClass25_0 _003C_003E8__2;

		public NetworkRunner runner;

		private float _003Cbegan_003E5__2;

		private float _003Cuntil_003E5__3;

		private float _003ConMaster_003E5__4;

		private bool _003Casked_003E5__5;

		private DisconnectCause _003Ccause_003E5__6;

		private float _003Cbye_003E5__7;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CLook_003Ed__25(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0407: Expected I4, but got I8
			//IL_0162: Expected Obj, but got I
			//IL_0171: Expected I4, but got I8
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_01bf: Expected I, but got Obj
			//IL_09c3: Expected I4, but got I8
			//IL_014d: Expected I4, but got I8
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_25ed: Expected I4, but got Obj
			//IL_020f: Expected Obj, but got I
			//IL_0243: Expected Obj, but got I4
			//IL_0285: Expected I, but got Obj
			//IL_009a: Expected Obj, but got I
			//IL_0428: Expected I, but got Obj
			//IL_0f38: Expected I, but got Obj
			//IL_02a3: Expected Obj, but got I
			//IL_00d1: Expected I, but got Obj
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Expected Obj, but got Unknown
			//IL_02ef: Expected I, but got Obj
			//IL_0446: Expected Obj, but got I
			//IL_0470: Expected Obj, but got I4
			//IL_049e: Expected Obj, but got I
			//IL_04ab: Expected Obj, but got I4
			//IL_04c2: Expected I, but got Obj
			//IL_00ef: Expected Obj, but got I
			//IL_1135: Expected Obj, but got I
			//IL_115f: Expected Obj, but got I4
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected Obj, but got Unknown
			//IL_0314: Expected Obj, but got I4
			//IL_032e: Expected Obj, but got I
			//IL_11a3: Expected I, but got Obj
			//IL_0549: Expected I, but got Obj
			//IL_034d: Expected Obj, but got I
			//IL_035e: Expected I, but got Obj
			//IL_036e: Expected Obj, but got I
			//IL_0398: Expected Obj, but got I4
			//IL_0b1e: Expected Obj, but got I4
			//IL_0b23: Expected I, but got Obj
			//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Expected Obj, but got Unknown
			//IL_11ea: Expected I, but got Obj
			//IL_0562: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Expected Obj, but got Unknown
			//IL_0592: Expected I, but got Obj
			//IL_0b47: Expected I, but got Obj
			//IL_12e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e5: Expected Obj, but got Unknown
			//IL_12ee: Expected Obj, but got I4
			//IL_1331: Expected I, but got Obj
			//IL_1237: Expected I, but got Obj
			//IL_108a: Unknown result type (might be due to invalid IL or missing references)
			//IL_108f: Expected Obj, but got Unknown
			//IL_1098: Expected Obj, but got I4
			//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Expected Obj, but got Unknown
			//IL_05e5: Expected I, but got Obj
			//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dfa: Expected Obj, but got Unknown
			//IL_0e03: Expected Obj, but got I4
			//IL_0e16: Expected Obj, but got I4
			//IL_0b7b: Expected I, but got Obj
			//IL_1363: Expected I4, but got I8
			//IL_10b0: Expected Obj, but got I4
			//IL_0dd2: Expected I4, but got I8
			//IL_13e9: Expected Obj, but got I
			//IL_1413: Expected Obj, but got I4
			//IL_1277: Expected I, but got Obj
			//IL_060f: Expected I, but got Obj
			//IL_0bcf: Expected I, but got Obj
			//IL_274e: Expected Obj, but got I
			//IL_2774: Expected Obj, but got I
			//IL_13a4: Expected I4, but got I8
			//IL_13be: Expected Obj, but got I4
			//IL_26fd: Expected Obj, but got I
			//IL_2728: Expected Obj, but got I
			//IL_1298: Expected I, but got Obj
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Expected Obj, but got Unknown
			//IL_065b: Expected I, but got Obj
			//IL_0c2b: Expected I, but got Obj
			//IL_144d: Invalid comparison between F4 and I4
			//IL_14a3: Expected Obj, but got I
			//IL_0674: Unknown result type (might be due to invalid IL or missing references)
			//IL_0679: Expected Obj, but got Unknown
			//IL_0682: Expected Obj, but got I4
			//IL_06c8: Expected F4, but got I8
			//IL_06cd: Expected I, but got Obj
			//IL_0c5f: Expected I, but got Obj
			//IL_1474: Expected Obj, but got I
			//IL_27a9: Expected I4, but got I8
			//IL_27c3: Expected Obj, but got I4
			//IL_06eb: Expected Obj, but got I
			//IL_0705: Expected Obj, but got I
			//IL_070d: Expected I, but got Obj
			//IL_0720: Expected I, but got Obj
			//IL_0c7d: Expected Obj, but got I
			//IL_1b69: Expected Obj, but got I
			//IL_074e: Expected F4, but got I8
			//IL_0758: Expected I, but got Obj
			//IL_0cb2: Expected Obj, but got I
			//IL_0cdc: Expected Obj, but got I4
			//IL_14fa: Expected Obj, but got I4
			//IL_0d12: Expected I, but got Obj
			//IL_077b: Expected Obj, but got I
			//IL_07b1: Expected F4, but got I8
			//IL_07b9: Expected I, but got Obj
			//IL_1906: Expected Obj, but got I
			//IL_0d30: Expected I, but got Obj
			//IL_0d40: Expected Obj, but got I
			//IL_0d50: Expected Obj, but got I
			//IL_0d6b: Expected Obj, but got I4
			//IL_0d8b: Expected I, but got Obj
			//IL_1be3: Expected Obj, but got I
			//IL_1beb: Expected I, but got Obj
			//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf9: Expected Obj, but got Unknown
			//IL_27e1: Expected Obj, but got I
			//IL_156c: Expected I, but got Obj
			//IL_07d7: Expected Obj, but got I
			//IL_07f1: Expected Obj, but got I
			//IL_07f9: Expected I, but got Obj
			//IL_080c: Expected I, but got Obj
			//IL_083a: Expected F4, but got I8
			//IL_0844: Expected I, but got Obj
			//IL_2273: Expected Obj, but got I
			//IL_227b: Expected I, but got Obj
			//IL_0867: Expected Obj, but got I
			//IL_089d: Expected F4, but got I8
			//IL_08a5: Expected I, but got Obj
			//IL_282e: Expected Obj, but got I8
			//IL_1c6f: Expected Obj, but got I
			//IL_1c7f: Expected Obj, but got I
			//IL_1ca1: Expected I, but got Obj
			//IL_1cae: Expected I, but got Obj
			//IL_1938: Expected I, but got Obj
			//IL_15ce: Expected I, but got Obj
			//IL_19af: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b4: Expected Obj, but got Unknown
			//IL_19bc: Expected Obj, but got I
			//IL_08ef: Expected F4, but got I8
			//IL_08f7: Expected I, but got Obj
			//IL_2292: Unknown result type (might be due to invalid IL or missing references)
			//IL_2297: Expected Obj, but got Unknown
			//IL_229f: Expected Obj, but got I
			//IL_22e8: Expected Obj, but got Ref
			//IL_22fc: Expected Obj, but got I
			//IL_1a07: Expected Obj, but got I
			//IL_1a12: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a17: Expected I4, but got Unknown
			//IL_1a2e: Expected I4, but got I8
			//IL_1a48: Expected Obj, but got I4
			//IL_090d: Expected I, but got Obj
			//IL_2323: Expected I, but got Obj
			//IL_22d2: Expected Obj, but got I
			//IL_22da: Expected I, but got Obj
			//IL_1cc3: Expected Obj, but got I
			//IL_163a: Expected I, but got Obj
			//IL_0e3f: Expected Obj, but got I
			//IL_28ac: Expected Obj, but got I4
			//IL_28bc: Expected Obj, but got I4
			//IL_28dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_28e1: Expected Obj, but got Unknown
			//IL_1a79: Expected I, but got Obj
			//IL_09a7: Expected I, but got Obj
			//IL_2331: Unknown result type (might be due to invalid IL or missing references)
			//IL_2336: Expected Obj, but got Unknown
			//IL_233e: Expected Obj, but got I
			//IL_2362: Expected Obj, but got I8
			//IL_1d8a: Expected Obj, but got I8
			//IL_1a92: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a97: Expected I4, but got Unknown
			//IL_1ab4: Expected Obj, but got I
			//IL_1ac4: Expected Obj, but got I
			//IL_1d0f: Expected I, but got Obj
			//IL_1b04: Expected Obj, but got I4
			//IL_1b0d: Expected Obj, but got I4
			//IL_1b1d: Expected I, but got Obj
			//IL_1683: Expected Obj, but got I
			//IL_16ad: Expected Obj, but got I4
			//IL_238f: Expected Obj, but got I
			//IL_2397: Expected I, but got Obj
			//IL_23a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a5: Expected Obj, but got Unknown
			//IL_23d9: Expected Obj, but got I4
			//IL_23ef: Expected Obj, but got I
			//IL_240f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2414: Expected Obj, but got Unknown
			//IL_1dd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dd5: Expected Obj, but got Unknown
			//IL_1e18: Expected I, but got Obj
			//IL_16fe: Expected Obj, but got I4
			//IL_1b34: Expected Obj, but got I4
			//IL_1b44: Expected I, but got Obj
			//IL_1b54: Expected I, but got Obj
			//IL_242b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2430: Expected Obj, but got Unknown
			//IL_2464: Expected Obj, but got I4
			//IL_247a: Expected Obj, but got I
			//IL_249a: Unknown result type (might be due to invalid IL or missing references)
			//IL_249f: Expected Obj, but got Unknown
			//IL_24a7: Expected I, but got Obj
			//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e36: Expected I4, but got Unknown
			//IL_1e4d: Expected I4, but got I8
			//IL_1e67: Expected Obj, but got I4
			//IL_1ed4: Expected Obj, but got I
			//IL_1ef3: Expected I, but got Obj
			//IL_1779: Expected Obj, but got I4
			//IL_24c5: Expected Obj, but got I
			//IL_24ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_24d3: Expected Obj, but got Unknown
			//IL_1f94: Expected Obj, but got I4
			//IL_1fa4: Expected Obj, but got I4
			//IL_1fc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fc9: Expected Obj, but got Unknown
			//IL_1e9c: Expected Obj, but got I4
			//IL_17bd: Expected I, but got Obj
			//IL_1f11: Expected I, but got Obj
			//IL_2000: Unknown result type (might be due to invalid IL or missing references)
			//IL_2005: Expected Obj, but got Unknown
			//IL_202e: Expected I, but got Obj
			//IL_1eb7: Expected I, but got Obj
			//IL_17f5: Expected Obj, but got I4
			//IL_20b7: Expected Obj, but got I8
			//IL_1829: Expected Obj, but got I
			//IL_2044: Expected I, but got Obj
			//IL_20fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_2102: Expected Obj, but got Unknown
			//IL_212b: Expected I, but got Obj
			//IL_1863: Expected Obj, but got I
			//IL_188d: Expected Obj, but got I4
			//IL_21bc: Expected Obj, but got I4
			//IL_21cc: Expected Obj, but got I4
			//IL_21ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f1: Expected Obj, but got Unknown
			//IL_2141: Expected I, but got Obj
			//IL_252e: Expected Obj, but got I4
			//IL_2228: Unknown result type (might be due to invalid IL or missing references)
			//IL_222d: Expected Obj, but got Unknown
			//IL_257d: Expected Obj, but got I
			//IL_2588: Expected Obj, but got I4
			//IL_18e8: Expected Obj, but got I
			//IL_25af: Expected Obj, but got I
			GillaOnline gillaOnline = _003C_003E4__this;
			bool result;
			object obj3;
			AuthenticationValues authenticationValues2;
			float realtimeSinceStartup = default;
			nint num = default;
			if (_003C_003E1__state <= 1)
			{
				if (_003C_003E1__state != 0)
				{
					bool flag = _003C_003E1__state != 1;
					result = false;
					if (flag)
					{
						goto IL_2616;
					}
					object obj = this + 40;
					object obj2 = obj;
					_ = 4294967295L;
					if (obj != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v161+10]");
						if (string.IsNullOrEmpty((string)0))
						{
							bool flag2 = (object)_003C_003E4__this == null;
							num = unchecked((nint)null);
							if (!flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30F0]");
								obj3 = 0;
								goto IL_261b;
							}
						}
						else
						{
							object obj4 = obj;
							bool flag3 = obj == null;
							num = unchecked((nint)null);
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
								object obj5 = 0;
								object obj6 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ X0_v244+E4]");
								bool flag4 = (nint)0 == 0;
								object obj7 = !flag4;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v162+10]");
								AuthenticationValues authenticationValues = NetworkBootstrap.TicketAuth((string)0);
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								authenticationValues2 = authenticationValues;
								num = unchecked((nint)null);
								goto IL_04c7;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3078]");
					object obj8 = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj9 = default;
					obj9._002Ector();
					object obj10 = this + 48;
					obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag5 = (object)_003C_003E4__this == null;
					num = (nint)obj9;
					if (!flag5)
					{
						gillaOnline.looking = true;
						float unscaledTime = Time.unscaledTime;
						gillaOnline.lastLook = unscaledTime;
						realtimeSinceStartup = Time.realtimeSinceStartup;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
						object obj11 = 0;
						_003Cbegan_003E5__2 = realtimeSinceStartup;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X0_v220+E4]");
						bool flag6 = (nint)0 == 0;
						object obj13 = !flag6;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool shiftAuthNeeded = NetworkBootstrap.ShiftAuthNeeded;
						bool flag7 = !shiftAuthNeeded;
						authenticationValues2 = null;
						num = (nint)obj9;
						if (flag7)
						{
							goto IL_04c7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3088]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj15 = default;
						obj15._002Ector();
						object obj16 = this + 40;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag8 = obj16 == null;
						num = (nint)obj15;
						if (!flag8)
						{
							object obj17 = obj16 + 16;
							obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3080]");
							object obj19 = 0;
							Action<bool, System.__Canon> action = default;
							action._002Ector(obj16, (IntPtr)obj19);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj20 = 0;
							object obj21 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X0_v233+E4]");
							bool flag9 = (nint)0 == 0;
							object obj22 = !flag9;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							IEnumerator enumerator = ShiftAuth.RefreshPhotonTicket((Action<bool, string>)action);
							object obj23 = this + 24;
							obj23 = enumerator;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 1;
							result = true;
							goto IL_2616;
						}
					}
				}
				goto IL_25b4;
			}
			if (_003C_003E1__state != 2)
			{
				bool flag10 = _003C_003E1__state != 3;
				result = false;
				if (flag10)
				{
					goto IL_2616;
				}
				_003C_003E1__state = -1;
				goto IL_2628;
			}
			_003C_003E1__state = -1;
			goto IL_2651;
			IL_10e6:
			GillaOnline._003C_003Ec__DisplayClass25_0 obj24;
			RealtimeClient c = obj24.c;
			bool flag11 = obj24.c == null;
			double num3;
			double num2 = num3;
			float num4;
			realtimeSinceStartup = num4;
			object obj25;
			nint num5 = default;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj25 = 0;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v28+E4]");
				bool flag12 = (nint)0 == 0;
				object obj27 = !flag12;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag13 = c.Handler__BackingField != null;
				bool flag14 = !flag13;
				num = unchecked((nint)null);
				if (flag14)
				{
					goto IL_129d;
				}
				GillaOnline._003C_003Ec__DisplayClass25_0 obj28 = _003C_003E8__2;
				bool flag15 = _003C_003E8__2 == null;
				num2 = num3;
				num5 = 0;
				realtimeSinceStartup = num4;
				num = unchecked((nint)null);
				if (!flag15)
				{
					RealtimeClient c2 = obj28.c;
					bool flag16 = obj28.c == null;
					num2 = num3;
					num5 = 0;
					realtimeSinceStartup = num4;
					num = unchecked((nint)null);
					if (!flag16)
					{
						bool flag17 = (object)c2.Handler__BackingField == null;
						num2 = num3;
						num5 = 0;
						realtimeSinceStartup = num4;
						num = unchecked((nint)null);
						if (!flag17)
						{
							c2.Handler__BackingField.RemoveInstance();
							num = unchecked((nint)null);
							goto IL_129d;
						}
					}
				}
			}
			goto IL_25b4;
			IL_261b:
			string what = (string)obj3;
			goto IL_28fd;
			IL_0e95:
			GillaOnline._003C_003Ec__DisplayClass25_0 obj29;
			RealtimeClient c3 = obj29.c;
			bool flag18 = obj29.c == null;
			object obj31;
			object obj30 = obj31;
			double num6;
			num2 = num6;
			IntPtr intPtr;
			num5 = intPtr;
			string text2;
			string text = text2;
			float num7;
			realtimeSinceStartup = num7;
			nint num8;
			num = num8;
			if (flag18)
			{
				goto IL_25b4;
			}
			_003Ccause_003E5__6 = c3.DisconnectedCause__BackingField;
			if (c3.state != (ClientState)14)
			{
				obj29.c.Disconnect();
				num8 = unchecked((nint)null);
			}
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			realtimeSinceStartup = (_003Cbye_003E5__7 = realtimeSinceStartup2 + 3f);
			obj30 = obj31;
			num2 = 3.0;
			num5 = intPtr;
			text = text2;
			num = num8;
			goto IL_2628;
			IL_2616:
			return result;
			IL_1d76:
			object[] array = default;
			object obj32 = array.Length & 0xFFFFFFFEL;
			bool flag19 = obj32 == null;
			object obj33;
			obj30 = obj33;
			nint num9;
			num5 = num9;
			string text3;
			text = text3;
			nint num10;
			num = num10;
			string text4;
			string text6;
			nint num13;
			string text7;
			if (!flag19)
			{
				object obj34 = array + 40;
				obj34 = text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag20 = _003C_003E8__2 == null;
				obj30 = obj33;
				num5 = num9;
				text = text3;
				num = (nint)text4;
				if (!flag20)
				{
					int num11 = _003C_003E8__2 + 32;
					int num12 = (int)(((int*)num11)->m_value & 0x80000000L);
					bool flag21 = num12 == 0;
					object obj35 = !flag21;
					if (obj35 == null)
					{
						string text5 = ((int*)num11)->ToString();
						bool flag22 = text5 == null;
						object obj36 = !flag22;
						text6 = text5;
						if (obj36 != null)
						{
							goto IL_1f09;
						}
						num13 = unchecked((nint)null);
						text7 = text5;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30D8]");
						object obj37 = 0;
						text6 = (string)obj37;
						bool flag23 = obj37 == null;
						num13 = (nint)text4;
						text7 = (string)obj37;
						if (!flag23)
						{
							goto IL_1f09;
						}
					}
					goto IL_1f78;
				}
				goto IL_25b4;
			}
			goto IL_25c2;
			IL_129d:
			bool flag24 = (object)_003C_003E4__this == null;
			num2 = num3;
			num5 = 0;
			realtimeSinceStartup = num4;
			int num16;
			if (!flag24)
			{
				object obj38 = _003C_003E4__this + 56;
				obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				GillaOnline._003C_003Ec__DisplayClass25_0 obj39 = _003C_003E8__2;
				bool flag25 = _003C_003E8__2 == null;
				num2 = num3;
				num5 = 0;
				realtimeSinceStartup = num4;
				num = unchecked((nint)null);
				if (!flag25)
				{
					int num14 = obj39.lobbies;
					if ((int)(obj39.lobbies & 0x80000000L) != 0)
					{
						num14 = obj39.appStats;
						int num15 = (int)(obj39.appStats & 0x80000000L);
						bool flag26 = num15 == 0;
						object obj40 = !flag26;
						num16 = obj39.appStats;
						if (obj40 != null)
						{
							goto IL_26da;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
					object obj41 = 0;
					object obj42 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v167+E4]");
					bool flag27 = (nint)0 == 0;
					object obj43 = !flag27;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj42 = obj41;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v167+A0]");
					object obj44 = 0;
					float unscaledTime2 = Time.unscaledTime;
					object obj45 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1199 @ X8_v117+A0]");
					object obj46 = 0;
					num16 = num14;
					goto IL_26da;
				}
			}
			goto IL_25b4;
			IL_28fd:
			_003C_003E4__this.Finish(what);
			result = false;
			goto IL_2616;
			IL_2651:
			obj29 = _003C_003E8__2;
			if (_003C_003E8__2 != null)
			{
				int num17 = (int)(obj29.lobbies & 0x80000000L);
				bool flag28 = num17 == 0;
				obj31 = obj30;
				num6 = num2;
				intPtr = num5;
				text2 = text;
				num7 = realtimeSinceStartup;
				num8 = num;
				if (flag28)
				{
					goto IL_0e95;
				}
				realtimeSinceStartup = Time.realtimeSinceStartup;
				num2 = _003Cuntil_003E5__3;
				obj29 = _003C_003E8__2;
				if (realtimeSinceStartup < _003Cuntil_003E5__3)
				{
					if (_003C_003E8__2 != null)
					{
						RealtimeClient c4 = obj29.c;
						if (obj29.c != null)
						{
							bool flag29 = c4.state == (ClientState)14;
							obj31 = obj30;
							num6 = _003Cuntil_003E5__3;
							intPtr = num5;
							text2 = text;
							num7 = realtimeSinceStartup;
							num8 = num;
							if (flag29)
							{
								goto IL_0e95;
							}
							obj29.c.Service();
							obj29 = _003C_003E8__2;
							bool flag30 = (byte)(~(_003Casked_003E5__5 ? 1u : 0u)) != 0;
							object obj47 = !flag30;
							num8 = unchecked((nint)null);
							if (obj47 != null)
							{
								goto IL_267a;
							}
							bool flag31 = _003C_003E8__2 == null;
							num = unchecked((nint)null);
							if (!flag31)
							{
								RealtimeClient c5 = obj29.c;
								bool flag32 = obj29.c == null;
								num = unchecked((nint)null);
								if (!flag32)
								{
									bool flag33 = c5.state != (ClientState)15;
									obj31 = obj30;
									num6 = _003Cuntil_003E5__3;
									intPtr = num5;
									text2 = text;
									num7 = realtimeSinceStartup;
									num8 = unchecked((nint)null);
									if (flag33)
									{
										goto IL_0d99;
									}
									float realtimeSinceStartup3 = Time.realtimeSinceStartup;
									num2 = _003Cbegan_003E5__2;
									GillaOnline._003C_003Ec__DisplayClass25_0 obj48 = _003C_003E8__2;
									realtimeSinceStartup = (_003ConMaster_003E5__4 = realtimeSinceStartup3 - _003Cbegan_003E5__2);
									bool flag34 = _003C_003E8__2 == null;
									num = unchecked((nint)null);
									if (!flag34)
									{
										RealtimeClient c6 = obj48.c;
										bool flag35 = obj48.c == null;
										num = unchecked((nint)null);
										if (!flag35)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3058]");
											object obj49 = 0;
											PhotonPeer realtimePeer = c6.RealtimePeer;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											ParameterDictionary parameterDictionary = default;
											parameterDictionary._002Ector();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3060]");
											object obj50 = 0;
											object obj51 = obj50;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X0_v21+E4]");
											bool flag36 = (nint)0 == 0;
											object obj52 = !flag36;
											if (obj52 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag37 = c6.RealtimePeer == null;
											num = unchecked((nint)null);
											if (!flag37)
											{
												object obj53 = obj50;
												nint num18 = (nint)realtimePeer;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v19+A0]");
												object obj54 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X9_v17 (Il2CppClass<Photon.Client.PhotonPeer>)+230]");
												obj30 = 0;
												text = (string)obj54;
												bool flag38 = ((ValueType)(object)c6.RealtimePeer).Equals((object)221);
												obj29 = _003C_003E8__2;
												_003Casked_003E5__5 = flag38;
												num5 = (nint)parameterDictionary;
												num8 = 221;
												goto IL_267a;
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag39 = _003C_003E8__2 == null;
					obj31 = obj30;
					num6 = _003Cuntil_003E5__3;
					intPtr = num5;
					text2 = text;
					num7 = realtimeSinceStartup;
					num8 = num;
					if (!flag39)
					{
						goto IL_0e95;
					}
				}
			}
			goto IL_25b4;
			IL_0d99:
			if (obj29.refused != null && (int)(obj29.appStats & 0x80000000L) == 0)
			{
				goto IL_0e95;
			}
			object obj55 = this + 24;
			obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj56 = 2;
			goto IL_26c7;
			IL_1f78:
			bool flag40 = array.Length < 2;
			object obj57 = !flag40;
			object obj58 = array.Length - 2;
			bool flag41 = obj58 == null;
			object obj59 = ~obj57;
			object obj60 = obj59 | flag41;
			obj30 = obj33;
			num5 = num9;
			text = text3;
			num = num13;
			string text8;
			object obj64;
			string text9;
			object format;
			IndexOutOfRangeException ex = default;
			if (obj60 == null)
			{
				object obj61 = array + 48;
				obj61 = text7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag42 = text8 == null;
				nint num19 = (nint)text7;
				if (!flag42)
				{
					nint num20 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
					num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag43 = ex == null;
					obj30 = obj33;
					num5 = num9;
					text = text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag43)
					{
						goto IL_25d0;
					}
				}
				object obj62 = array.Length & 0xFFFFFFFCL;
				bool flag44 = obj62 == null;
				obj30 = obj33;
				num5 = num9;
				text = text3;
				num = num19;
				if (!flag44)
				{
					object obj63 = array + 56;
					obj63 = text8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag45 = obj64 == null;
					nint num21 = (nint)text8;
					if (!flag45)
					{
						nint num22 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v79 (Il2CppClass<System.Object[]>)+40]");
						num21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag46 = ex == null;
						obj30 = obj33;
						num5 = num9;
						text = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v79 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag46)
						{
							goto IL_25d0;
						}
					}
					bool flag47 = array.Length < 4;
					object obj65 = !flag47;
					object obj66 = array.Length - 4;
					bool flag48 = obj66 == null;
					object obj67 = ~obj65;
					object obj68 = obj67 | flag48;
					obj30 = obj33;
					num5 = num9;
					text = text3;
					num = num21;
					if (obj68 == null)
					{
						object obj69 = array + 64;
						obj69 = obj64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						text9 = string.Format((string)format, array);
						num5 = 0;
						goto IL_24f7;
					}
				}
			}
			goto IL_25c2;
			IL_2628:
			obj24 = _003C_003E8__2;
			if (_003C_003E8__2 != null)
			{
				RealtimeClient c7 = obj24.c;
				if (obj24.c != null)
				{
					bool flag49 = c7.state == (ClientState)14;
					num3 = num2;
					num4 = realtimeSinceStartup;
					if (flag49)
					{
						goto IL_10e6;
					}
					realtimeSinceStartup = Time.realtimeSinceStartup;
					num2 = _003Cbye_003E5__7;
					obj24 = _003C_003E8__2;
					if (realtimeSinceStartup < _003Cbye_003E5__7)
					{
						if (_003C_003E8__2 != null && obj24.c != null)
						{
							obj24.c.Service();
							obj55 = this + 24;
							obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj56 = 3;
							goto IL_26c7;
						}
					}
					else
					{
						bool flag50 = _003C_003E8__2 == null;
						num3 = _003Cbye_003E5__7;
						num4 = realtimeSinceStartup;
						if (!flag50)
						{
							goto IL_10e6;
						}
					}
				}
			}
			goto IL_25b4;
			IL_26da:
			float realtimeSinceStartup4 = Time.realtimeSinceStartup;
			num2 = _003Cbegan_003E5__2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj70 = 0;
			float num23 = realtimeSinceStartup4 - _003Cbegan_003E5__2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30E0]");
			object format2 = 0;
			object arg = default;
			string text10 = string.Format((string)format2, arg);
			realtimeSinceStartup = _003ConMaster_003E5__4;
			string text11;
			float num24;
			if (_003ConMaster_003E5__4 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj71 = 0;
				text11 = (string)obj71;
				num24 = num23;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3098]");
				object format3 = 0;
				object arg2 = default;
				string text12 = string.Format((string)format3, arg2);
				num24 = _003ConMaster_003E5__4;
				text11 = text12;
			}
			text8 = text10 + text11;
			int num25 = (int)(num16 & 0x80000000L);
			bool flag51 = num25 == 0;
			object obj72 = !flag51;
			if (obj72 == null)
			{
				object obj73 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X0_v73+E4]");
				bool flag52 = (nint)0 == 0;
				object obj74 = !flag52;
				if (obj74 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag53 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
				bool flag54 = !flag53;
				num5 = 0;
				if (!flag54)
				{
					bool flag55 = (object)runner == null;
					num5 = 0;
					num = unchecked((nint)null);
					if (flag55)
					{
						goto IL_25b4;
					}
					bool isRunning = runner.IsRunning;
					bool flag56 = !isRunning;
					num5 = 0;
					if (!flag56)
					{
						bool flag57 = (object)runner == null;
						num5 = 0;
						num = unchecked((nint)null);
						if (flag57)
						{
							goto IL_25b4;
						}
						bool isSharedModeMasterClient = runner.IsSharedModeMasterClient;
						bool flag58 = !isSharedModeMasterClient;
						num5 = 0;
						if (!flag58)
						{
							NetworkRunner networkRunner = runner;
							bool flag59 = (object)runner == null;
							num5 = 0;
							num = unchecked((nint)null);
							if (flag59)
							{
								goto IL_25b4;
							}
							bool flag60 = networkRunner.SessionInfo__BackingField == null;
							num5 = 0;
							if (!flag60)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
								object obj75 = 0;
								object obj76 = obj75;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ X0_v131+E4]");
								bool flag61 = (nint)0 == 0;
								object obj77 = !flag61;
								if (obj77 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC04B8");
								object obj78 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X8_v98+E4]");
								bool flag62 = (nint)0 == 0;
								object obj79 = !flag62;
								if (obj79 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object obj80 = default;
								bool flag63 = obj80 != null;
								bool flag64 = !flag63;
								num5 = 0;
								if (!flag64)
								{
									object obj81 = obj75;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1534 @ X0_v138+E4]");
									bool flag65 = (nint)0 == 0;
									object obj82 = !flag65;
									if (obj82 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC04B8");
									object obj83 = default;
									bool flag66 = obj83 == null;
									num5 = 0;
									num = unchecked((nint)null);
									if (flag66)
									{
										goto IL_25b4;
									}
									object obj84 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ X8_v100+E4]");
									bool flag67 = (nint)0 == 0;
									object obj85 = !flag67;
									if (obj85 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v141+B0]");
									bool flag68 = (UnityEngine.Object)0 == runner;
									bool flag69 = !flag68;
									num5 = 0;
									if (!flag69)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
										object obj86 = 0;
										object obj87 = obj86;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ X0_v145+E4]");
										bool flag70 = (nint)0 == 0;
										object obj88 = !flag70;
										if (obj88 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										int num26 = GillaOnline.Told(runner);
										if (num26 == num16)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30C8]");
											obj64 = 0;
											num5 = 0;
										}
										else
										{
											object obj89 = obj86;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1611 @ X0_v149+E4]");
											bool flag71 = (nint)0 == 0;
											object obj90 = !flag71;
											if (obj90 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag72 = GillaOnline.Tell(runner, num16);
											bool flag73 = !flag72;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30A8]");
											obj64 = 0;
											object obj91 = !flag73;
											object obj92 = ~obj91;
											if (obj92 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
												obj64 = 0;
											}
											num5 = 0;
										}
										goto IL_27d1;
									}
								}
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30B0]");
				obj64 = 0;
				goto IL_27d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] array2 = default;
			bool flag74 = array2 == null;
			num5 = 0;
			num = 6;
			if (flag74)
			{
				goto IL_25b4;
			}
			bool flag75 = array2.Length == 0;
			num5 = 0;
			num = 6;
			if (!flag75)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30E8]");
				object obj94 = 0;
				num = (nint)obj94;
				object obj95 = array2 + 32;
				obj95 = obj94;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				GillaOnline._003C_003Ec__DisplayClass25_0 obj96 = _003C_003E8__2;
				bool flag76 = _003C_003E8__2 == null;
				num5 = 0;
				if (flag76)
				{
					goto IL_25b4;
				}
				if (obj96.refused != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30A0]");
					object obj97 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
					object obj98 = 0;
					string text13 = (string)obj97 + obj96.refused + (string)obj98;
					num5 = (nint)obj98;
					text = null;
					num = (nint)text13;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj99 = 0;
					num = (nint)obj99;
					num5 = 0;
				}
				object obj100 = array2.Length & 0xFFFFFFFEL;
				if (obj100 != null)
				{
					object obj101 = array2 + 40;
					obj101 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (~(_003Casked_003E5__5 ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0B90]");
						object obj102 = 0;
						num = (nint)obj102;
					}
					else
					{
						string text14 = ((Enum)(&num24)).ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30F8]");
						object obj103 = 0;
						string text15 = (string)obj103 + text14;
						num5 = 0;
						num = (nint)text15;
					}
					bool flag77 = array2.Length < 2;
					object obj104 = !flag77;
					object obj105 = array2.Length - 2;
					bool flag78 = obj105 == null;
					object obj106 = ~obj104;
					object obj107 = obj106 | flag78;
					if (obj107 == null)
					{
						object obj108 = array2 + 48;
						obj108 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X19_v7-18]");
						object obj109 = 0 & 0xFFFFFFFCL;
						if (obj109 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
							object obj110 = 0;
							num = (nint)obj110;
							object obj111 = array2 + 56;
							obj111 = obj110;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X19_v9-20]");
							bool flag79 = (nint)0 < (nint)4;
							object obj112 = !flag79;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X19_v9-20]");
							object obj113 = -4;
							bool flag80 = obj113 == null;
							object obj114 = ~obj112;
							object obj115 = obj114 | flag80;
							if (obj115 == null)
							{
								object obj116 = array2 + 64;
								obj116 = text8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X19_v11-28]");
								bool flag81 = (nint)0 < (nint)5;
								object obj117 = !flag81;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X19_v11-28]");
								object obj118 = -5;
								bool flag82 = obj118 == null;
								object obj119 = ~obj117;
								object obj120 = obj119 | flag82;
								num = (nint)text8;
								if (obj120 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
									object obj121 = 0;
									object obj122 = array2 + 72;
									obj122 = obj121;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									text9 = string.Concat(array2);
									goto IL_24f7;
								}
							}
						}
					}
				}
			}
			goto IL_25c2;
			IL_1d07:
			nint num27 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
			num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag83 = ex == null;
			obj33 = obj30;
			string text16;
			text4 = text16;
			num9 = num5;
			text3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (!flag83)
			{
				goto IL_1d76;
			}
			goto IL_25d0;
			IL_24f7:
			what = text9;
			goto IL_28fd;
			IL_26c7:
			result = true;
			goto IL_2616;
			IL_1f09:
			nint num28 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
			num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag84 = ex == null;
			text7 = text6;
			obj30 = obj33;
			num5 = num9;
			text = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (!flag84)
			{
				goto IL_1f78;
			}
			goto IL_25d0;
			IL_25d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (byte)(int)ex2 != 0;
			IL_25c2:
			ex = new IndexOutOfRangeException();
			goto IL_25d0;
			IL_267a:
			bool flag85 = obj29 == null;
			obj31 = obj30;
			num6 = num2;
			intPtr = num5;
			text2 = text;
			num7 = realtimeSinceStartup;
			num = num8;
			if (!flag85)
			{
				goto IL_0d99;
			}
			goto IL_25b4;
			IL_25b4:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_25c2;
			IL_04c7:
			PhotonAppSettings global = PhotonAppSettings.Global;
			if (global != null && global.AppSettings != null)
			{
				FusionAppSettings copy = global.AppSettings.GetCopy();
				RealtimeClient realtimeClient = MatchmakingArgumentsExtensions.BuildRealtimeClient(copy);
				bool flag86 = (object)_003C_003E4__this == null;
				num = unchecked((nint)null);
				if (!flag86)
				{
					object obj123 = _003C_003E4__this + 56;
					obj123 = realtimeClient;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag87 = _003C_003E8__2 == null;
					num = (nint)realtimeClient;
					if (!flag87)
					{
						object obj124 = _003C_003E8__2 + 40;
						obj124 = realtimeClient;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						GillaOnline._003C_003Ec__DisplayClass25_0 obj125 = _003C_003E8__2;
						bool flag88 = _003C_003E8__2 == null;
						num = (nint)realtimeClient;
						if (!flag88)
						{
							bool flag89 = obj125.c == null;
							num = (nint)realtimeClient;
							if (!flag89)
							{
								object obj126 = obj125.c + 64;
								obj126 = authenticationValues2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag90 = _003C_003E8__2 == null;
								num = (nint)authenticationValues2;
								if (!flag90)
								{
									object obj127 = _003C_003E8__2 + 16;
									obj127 = 0;
									_ = 4294967295L;
									_ = 4294967295L;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj128 = _003C_003E8__2;
									bool flag91 = _003C_003E8__2 == null;
									realtimeSinceStartup = 4.2949673E+09f;
									num = unchecked((nint)null);
									if (!flag91)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FE0]");
										object obj129 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3068]");
										object obj130 = 0;
										num5 = (nint)obj130;
										Action<System.__Canon> action2 = default;
										action2._002Ector((object)_003C_003E8__2, (IntPtr)obj130);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X24_v22 (System.Object)+28]");
										bool flag92 = (nint)0 == 0;
										text = null;
										realtimeSinceStartup = 4.2949673E+09f;
										num = (nint)_003C_003E8__2;
										if (!flag92)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X24_v22 (System.Object)+28]");
											((RealtimeClient)0).OpResponseReceived += (Action<OperationResponse>)action2;
											object obj131 = _003C_003E8__2;
											bool flag93 = _003C_003E8__2 == null;
											num5 = 0;
											text = null;
											realtimeSinceStartup = 4.2949673E+09f;
											num = (nint)action2;
											if (!flag93)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3048]");
												object obj132 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3070]");
												object obj133 = 0;
												num5 = (nint)obj133;
												Action<System.__Canon> action3 = default;
												action3._002Ector((object)_003C_003E8__2, (IntPtr)obj133);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X24_v23 (System.Object)+28]");
												bool flag94 = (nint)0 == 0;
												text = null;
												realtimeSinceStartup = 4.2949673E+09f;
												num = (nint)_003C_003E8__2;
												if (!flag94)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X24_v23 (System.Object)+28]");
													((RealtimeClient)0).EventReceived += (Action<EventData>)action3;
													GillaOnline._003C_003Ec__DisplayClass25_0 obj134 = _003C_003E8__2;
													bool flag95 = _003C_003E8__2 == null;
													num5 = 0;
													text = null;
													realtimeSinceStartup = 4.2949673E+09f;
													num = (nint)action3;
													if (!flag95)
													{
														RealtimeClient c8 = obj134.c;
														bool flag96 = obj134.c == null;
														num5 = 0;
														text = null;
														realtimeSinceStartup = 4.2949673E+09f;
														num = (nint)action3;
														if (!flag96)
														{
															nint num29 = (nint)c8;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1484 @ X8_v142 (Il2CppClass<Photon.Realtime.RealtimeClient>)+1E0]");
															num5 = 0;
															if (((Attribute)(object)obj134.c).Match((object)copy))
															{
																float realtimeSinceStartup5 = Time.realtimeSinceStartup;
																_003Casked_003E5__5 = false;
																_003ConMaster_003E5__4 = -1f;
																realtimeSinceStartup = (_003Cuntil_003E5__3 = realtimeSinceStartup5 + 15f);
																num2 = 15.0;
																text = null;
																num = (nint)copy;
																goto IL_2651;
															}
															gillaOnline.client = null;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30B8]");
															obj3 = 0;
															goto IL_261b;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_25b4;
			IL_27d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj135 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			bool flag97 = array == null;
			num = (nint)(&num24);
			if (!flag97)
			{
				IntPtr intPtr2 = default;
				bool flag98 = intPtr2 == (IntPtr)0;
				nint num30 = (nint)(&num24);
				if (!flag98)
				{
					nint num31 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v91 (Il2CppClass<System.Object[]>)+40]");
					num30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag99 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X8_v91 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag99)
					{
						goto IL_25d0;
					}
				}
				bool flag100 = array.Length == 0;
				num = num30;
				if (flag100)
				{
					goto IL_25c2;
				}
				object obj136 = array + 32;
				obj136 = (nint)intPtr2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				GillaOnline._003C_003Ec__DisplayClass25_0 obj137 = _003C_003E8__2;
				bool flag101 = _003C_003E8__2 == null;
				num = intPtr2;
				if (!flag101)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30C0]");
					format = 0;
					int num32 = _003C_003E8__2 + 24;
					int num33 = (int)(((int*)num32)->m_value & 0x80000000L);
					bool flag102 = num33 == 0;
					object obj138 = !flag102;
					if (obj138 == null)
					{
						string text17 = ((int*)num32)->ToString();
						bool flag103 = _003C_003E8__2 == null;
						num = unchecked((nint)null);
						if (flag103)
						{
							goto IL_25b4;
						}
						int num34 = _003C_003E8__2 + 28;
						string text18 = ((int*)num34)->ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D30D0]");
						object obj139 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3090]");
						object obj140 = 0;
						text = (string)obj140;
						string text19 = text17 + (string)obj139 + text18 + (string)obj140;
						bool flag104 = text19 == null;
						object obj141 = !flag104;
						obj30 = 0;
						text16 = text19;
						num5 = (nint)text18;
						if (obj141 != null)
						{
							goto IL_1d07;
						}
						obj33 = 0;
						text4 = text19;
						num9 = (nint)text18;
						text3 = (string)obj140;
						num10 = (nint)obj139;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4698]");
						object obj142 = 0;
						text16 = (string)((obj137.refused != null) ? obj137.refused : obj142);
						bool flag105 = text16 == null;
						obj33 = obj30;
						text4 = text16;
						num9 = num5;
						text3 = text;
						num10 = intPtr2;
						if (!flag105)
						{
							goto IL_1d07;
						}
					}
					goto IL_1d76;
				}
			}
			goto IL_25b4;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	public enum Kind : byte
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		Copper,
		// error: enumerator has no value
		Silver,
		// error: enumerator has no value
		Gold,
		// error: enumerator has no value
		Amethyst
	}

	public static readonly GillaOreVeins.Look[] Kinds;

	public static readonly string[] Sizes;

	public static readonly float[] SizeChance;

	public int node;

	public MeshRenderer mineralView;

	public MeshRenderer crystalView;

	private Kind Shown__BackingField;

	private bool BrokeHere__BackingField;

	private int HitsTaken__BackingField;

	private const float Apart = default(float);

	private const float FlashFor = default(float);

	private const float GrowFor = default(float);

	private static readonly int HealthId;

	private static readonly int FlashId;

	private GillaOreVeins veins;

	private Collider solid;

	private MaterialPropertyBlock block;

	private Vector3 size;

	private float lastHit;

	private float flash;

	private float grow;

	private float kick;

	private float kickSpeed;

	private float brokeAt;

	private float health;

	private float painted;

	private int hereDamage;

	public Kind Shown
	{
		get
		{
			return Shown__BackingField;
		}
		private set
		{
			Shown__BackingField = value;
		}
	}

	public bool BrokeHere
	{
		get
		{
			return BrokeHere__BackingField;
		}
		private set
		{
			BrokeHere__BackingField = value;
		}
	}

	public int HitsTaken
	{
		get
		{
			return HitsTaken__BackingField;
		}
		private set
		{
			HitsTaken__BackingField = value;
		}
	}

	private static Color Hex(int rgb)
	{
		//IL_002d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		return (Color)rgb;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3108]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BA8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
		object obj3 = this + 64;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj5 = this + 72;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
		object obj7 = 0;
		Vector3 localScale = transform.localScale;
		Vector3 vector = default;
		size = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		MaterialPropertyBlock materialPropertyBlock = default;
		materialPropertyBlock._002Ector();
		object obj8 = this + 80;
		obj8 = materialPropertyBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Hide();
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		UnityEngine.Object obj3 = (UnityEngine.Object)(this + 72);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj3 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFA80]");
			object obj8 = 0;
			obj6 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
			object obj10 = default;
			object obj9 = obj10 & 1;
			bool flag4 = obj9 == null;
			obj7 = obj3;
			if (flag4)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+8]");
		bool flag6 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)obj3);
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (solid != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+8]");
			bool flag3 = ((HashSet<System.__Canon>)0).Remove((System.__Canon)(object)solid);
		}
	}

	public void Show(Kind kind, int damage, bool fresh)
	{
		//IL_0100: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_055f: Expected Obj, but got I4
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected I4, but got Unknown
		//IL_05c3: Expected Obj, but got I
		//IL_05dc: Expected Obj, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_062a: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02e0: Expected Obj, but got I4
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I4
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected I4, but got Unknown
		//IL_065d: Expected F8, but got I4
		//IL_0324: Invalid comparison between I4 and F8
		//IL_0335: Expected F8, but got I4
		//IL_0507: Expected VT, but got I
		//IL_0507: Expected VT, but got I4
		Kind kind2 = default;
		if (~(BrokeHere__BackingField ? 1u : 0u) == 0)
		{
			object obj = kind2 & (Kind)0xFF;
			if (obj != null)
			{
				float time = Time.time;
				float num = time - brokeAt;
				if ((double)num > 2.0)
				{
					Appear(kind2, fresh: false);
				}
			}
			else
			{
				Shown__BackingField = (Kind)0;
			}
			return;
		}
		if (Shown__BackingField == kind2)
		{
			object obj2 = kind2 & (Kind)0xFF;
			bool flag = obj2 == null;
			object obj3 = !flag;
			bool flag2 = (byte)damage != 0;
			if (obj3 == null)
			{
				return;
			}
		}
		else
		{
			object obj4 = kind2 & (Kind)0xFF;
			if (obj4 == null)
			{
				if (fresh)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v14+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (veins != null)
					{
						GillaOreVeins gillaOreVeins = veins;
						if ((object)veins != null)
						{
							Transform transform = base.transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								Transform transform2 = base.transform;
								if ((object)transform2 != null)
								{
									Vector3 up = transform2.up;
									Transform transform3 = base.transform;
									if ((object)transform3 != null)
									{
										Vector3 up2 = transform3.up;
										if (gillaOreVeins.FX__BackingField != null)
										{
											IntPtr intPtr = default;
											gillaOreVeins.FX__BackingField.Break(this, Shown__BackingField, (Vector3)0, (Vector3)(nint)intPtr);
											goto IL_050d;
										}
									}
								}
							}
						}
						goto IL_0523;
					}
				}
				goto IL_050d;
			}
			Appear(kind2, fresh);
			bool flag2 = fresh;
		}
		int num2 = hereDamage;
		if (hereDamage <= damage)
		{
			hereDamage = 0;
			num2 = 0;
		}
		object obj8 = damage - num2;
		bool flag4 = (nint)obj8 < 0;
		bool flag5 = obj8 == null;
		int num3 = damage ^ num2;
		int num4 = damage ^ obj8;
		int num5 = num3 & num4;
		bool flag6 = num5 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj9 = 0;
		bool flag7 = flag4 == flag6;
		object obj10 = !flag5;
		object obj11 = flag7 & obj10;
		object obj12 = ~obj11;
		int num6 = ((obj12 != null) ? num2 : damage);
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+A0]");
		object obj15 = 0;
		object obj16 = obj15;
		if (obj15 == null)
		{
			goto IL_0523;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v11+18]");
		bool flag9 = (nint)0 < (nint)(int)kind2;
		object obj17 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v11+18]");
		object obj18 = -(int)kind2;
		bool flag10 = obj18 == null;
		object obj19 = ~obj17;
		object obj20 = obj19 | flag10;
		if (obj20 == null)
		{
			object obj21 = kind2 & (Kind)0xFF;
			object obj22 = obj21 * 72;
			object obj23 = obj15 + obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v12+50]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v12+50]");
			object obj25 = -1;
			bool flag11 = (nint)obj25 < 0;
			bool flag12 = obj25 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v12+50]");
			object obj26 = (nint)0 ^ (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v12+50]");
			object obj27 = 0 ^ obj25;
			object obj28 = obj26 & obj27;
			bool flag13 = (nint)obj28 < 0;
			bool flag14 = flag11 == flag13;
			object obj29 = !flag12;
			object obj30 = flag14 & obj29;
			object obj31 = ~obj30;
			if (obj31 != null)
			{
				obj24 = 1;
			}
			int num7 = num6 / obj24;
			bool flag15 = num7 < 0;
			double num8 = 0.0;
			if (!flag15)
			{
				bool flag16 = !((double)num7 > 1.0);
				num8 = num7;
				if (!flag16)
				{
					num8 = 1.0;
				}
			}
			double num9 = 1.0 - num8;
			health = (float)num9;
			return;
		}
		goto IL_0531;
		IL_0523:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0531;
		IL_0531:
		throw new IndexOutOfRangeException();
		IL_050d:
		Hide();
		Shown__BackingField = (Kind)0;
	}

	private void Appear(Kind kind, bool fresh)
	{
		//IL_0010: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I4
		//IL_0604: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I4
		//IL_0288: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_050e: Expected F8, but got I4
		//IL_0407: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj = 0;
		object obj2 = obj;
		Shown__BackingField = kind;
		BrokeHere__BackingField = false;
		hereDamage = 0;
		health = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		if (obj4 == null)
		{
			goto IL_0525;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+18]");
		bool flag2 = (nint)0 < (nint)(int)kind;
		object obj6 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+18]");
		object obj7 = -(int)kind;
		bool flag3 = obj7 == null;
		object obj8 = ~obj6;
		object obj9 = obj8 | flag3;
		object obj11;
		if (obj9 == null)
		{
			object obj10 = kind & (Kind)0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj11 = 0;
			object obj12 = obj10 * 72;
			object obj13 = obj4 + obj12;
			object obj14 = this + 40;
			object obj15 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)obj14 != null;
			bool flag6 = !flag5;
			object obj17 = 0;
			bool flag7 = false;
			if (!flag6)
			{
				if (obj14 == null)
				{
					goto IL_0525;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+54]");
				object obj18 = (nint)0 & (nint)1;
				bool flag8 = (((Renderer)obj14).enabled = obj18 == null);
				obj17 = 0;
				flag7 = flag8;
			}
			object obj19 = obj11;
			object obj20 = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v13+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11;
			if ((UnityEngine.Object)obj20 != null)
			{
				if (obj20 == null)
				{
					goto IL_0525;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+54]");
				flag11 = (byte)((nuint)0u & (nuint)1u) != 0;
				((Renderer)obj20).enabled = flag11;
				object obj22 = 0;
				UnityEngine.Object obj23 = (UnityEngine.Object)flag11;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+54]");
				flag11 = (byte)((nuint)0u & (nuint)1u) != 0;
				object obj22 = 0;
				UnityEngine.Object obj23 = null;
			}
			object obj24 = obj11;
			object obj25 = (flag11 ? obj20 : obj14);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v18+E4]");
			bool flag12 = (nint)0 == 0;
			object obj26 = !flag12;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = (UnityEngine.Object)obj25 != null;
			bool flag14 = !flag13;
			object obj27 = 0;
			Material material = null;
			if (!flag14)
			{
				object obj28 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v31+E4]");
				bool flag15 = (nint)0 == 0;
				object obj29 = !flag15;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag16 = veins != null;
				bool flag17 = !flag16;
				obj27 = 0;
				material = null;
				if (!flag17)
				{
					if ((object)veins != null)
					{
						Material material2 = veins.MaterialOf(kind);
						if (obj25 != null)
						{
							((Renderer)obj25).sharedMaterial = material2;
							obj27 = 0;
							material = material2;
							goto IL_0414;
						}
					}
					goto IL_0525;
				}
			}
			goto IL_0414;
		}
		goto IL_0533;
		IL_0525:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0533;
		IL_0414:
		object obj30 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v23+E4]");
		bool flag18 = (nint)0 == 0;
		object obj31 = !flag18;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (solid != null)
		{
			if ((object)solid == null)
			{
				goto IL_0525;
			}
			solid.enabled = true;
		}
		bool flag19 = !fresh;
		kick = 0f;
		flash = 0f;
		object obj32 = !flag19;
		object obj33 = ~obj32;
		double num = ((obj33 != null) ? 1.0 : 0.0);
		grow = (float)num;
		Paint();
		return;
		IL_0533:
		throw new IndexOutOfRangeException();
	}

	private void Hide()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
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
		bool flag2 = mineralView != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		bool flag4 = false;
		if (!flag3)
		{
			mineralView.enabled = false;
			obj4 = 0;
			flag4 = false;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = crystalView != null;
		bool flag7 = !flag6;
		object obj7 = 0;
		bool flag8 = false;
		if (!flag7)
		{
			crystalView.enabled = false;
			obj7 = 0;
			flag8 = false;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj9 = !flag9;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (solid != null)
		{
			solid.enabled = false;
		}
		hereDamage = 0;
	}

	public void Struck(Vector3 at, Vector3 normal, int damage)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00e2: Invalid comparison between F4 and I
		//IL_010f: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_048a: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I4
		//IL_0224: Invalid comparison between F8 and I4
		//IL_055b: Invalid comparison between F8 and I4
		//IL_056a: Invalid comparison between F8 and I4
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected I4, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected I4, but got Unknown
		//IL_05c3: Expected Obj, but got I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_052e: Expected Obj, but got I4
		//IL_0600: Expected I4, but got F8
		//IL_0610: Invalid comparison between F8 and I
		//IL_031a: Expected F8, but got I4
		//IL_0371: Expected VT, but got I4
		//IL_0371: Expected VT, but got I4
		//IL_03fd: Expected VT, but got I
		//IL_03fd: Expected VT, but got I4
		//IL_0445: Expected VT, but got I
		//IL_0445: Expected VT, but got I4
		//IL_0445: Expected I4, but got VT
		if (Shown__BackingField == 0)
		{
			return;
		}
		bool flag = (byte)(~(BrokeHere__BackingField ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = veins == null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		float time = Time.time;
		float num = time - lastHit;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		if (num < 0f)
		{
			return;
		}
		float time2 = Time.time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj6 = 0;
		lastHit = time2;
		object obj7 = obj6;
		int num2 = HitsTaken__BackingField + 1;
		HitsTaken__BackingField = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v10+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v10+A0]");
		object obj9 = 0;
		object obj10 = obj9;
		if (obj9 == null)
		{
			goto IL_0446;
		}
		Kind kind = Shown__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v13+18]");
		bool flag6 = (nint)(int)kind < (nint)0;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_0454;
		}
		object obj12 = (int)Shown__BackingField * 72;
		object obj13 = obj9 + obj12;
		double num3 = 1.0 - (double)health;
		double num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v16+50]");
		double num5 = num4 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num6;
		double num7;
		double num8 = default;
		if (num5 < 0.0)
		{
			if (num5 == -0.5)
			{
				num6 = -1.0;
				num7 = num8;
				goto IL_04f7;
			}
			num7 = num5 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num5 == 0.5)
			{
				num6 = 1.0;
				num7 = num8;
				goto IL_04f7;
			}
			num7 = num5 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0541;
		IL_04f7:
		double num9 = num7 + num6;
		object obj17 = num7 & 1;
		bool flag8 = obj17 == null;
		object obj18 = !flag8;
		if (obj18 != null)
		{
			num7 = num9;
		}
		goto IL_0541;
		IL_0446:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0454;
		IL_0454:
		throw new IndexOutOfRangeException();
		IL_0541:
		double num10 = (double)hereDamage - num7;
		bool flag9 = num10 < 0.0;
		bool flag10 = num10 == 0.0;
		int num11 = hereDamage ^ num7;
		int num12 = hereDamage ^ num10;
		int num13 = num11 & num12;
		bool flag11 = num13 < 0;
		bool flag12 = flag9 == flag11;
		object obj19 = !flag10;
		object obj20 = flag12 & obj19;
		object obj21 = ~obj20;
		double num14 = ((obj21 != null) ? num7 : ((double)hereDamage));
		double num15 = num14 + (double)at;
		hereDamage = (int)num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v16+50]");
		IntPtr intPtr = default;
		if (num15 < 0.0)
		{
			double num16 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v16+50]");
			double num17 = num16 / 0.0;
			double num18 = 1.0 - num17;
			health = (float)num18;
			Knocked((Vector3)0, (Vector3)0);
		}
		else
		{
			BrokeHere__BackingField = true;
			float time3 = Time.time;
			GillaOreVeins gillaOreVeins = veins;
			brokeAt = time3;
			if ((object)veins == null || gillaOreVeins.FX__BackingField == null)
			{
				goto IL_0446;
			}
			gillaOreVeins.FX__BackingField.Break(this, Shown__BackingField, (Vector3)0, (Vector3)(nint)intPtr);
			Hide();
		}
		if ((object)veins != null)
		{
			veins.Hit(node, (int)at, (Vector3)0, (Vector3)(nint)intPtr);
			return;
		}
		goto IL_0446;
	}

	public void Knocked(Vector3 at, Vector3 normal)
	{
		//IL_0094: Expected VT, but got I4
		if (Shown__BackingField != 0 && ~(BrokeHere__BackingField ? 1u : 0u) != 0)
		{
			GillaOreVeins gillaOreVeins = veins;
			flash = 1f;
			float num = kickSpeed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD70]");
			float num2 = num + 0f;
			kickSpeed = num2;
			Vector3 normal2 = default;
			gillaOreVeins.FX__BackingField.Hit(this, Shown__BackingField, (Vector3)0, normal2);
		}
	}

	private void Update()
	{
		//IL_0161: Invalid comparison between F4 and I4
		//IL_00ad: Invalid comparison between F4 and I4
		//IL_00bc: Invalid comparison between F4 and I4
		//IL_00d4: Expected Obj, but got F8
		//IL_00e1: Expected Obj, but got F4
		//IL_0116: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_03ab: Invalid comparison between F4 and I4
		//IL_0180: Invalid comparison between F4 and I4
		//IL_03f5: Invalid comparison between F4 and I4
		//IL_01fb: Invalid comparison between F4 and I4
		//IL_01a2: Invalid comparison between F4 and I4
		//IL_02ff: Invalid comparison between F4 and I
		//IL_022b: Invalid comparison between F4 and I4
		//IL_021b: Expected F4, but got I4
		//IL_0332: Invalid comparison between F4 and I
		if (Shown__BackingField == 0 || ~(BrokeHere__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		float num5;
		bool flag5;
		if ((double)grow < 1.0)
		{
			float deltaTime = Time.deltaTime;
			float num = deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num2 = num / 0f;
			float num3 = grow + num2;
			float num4 = num3 - 1f;
			bool flag = num4 < 0f;
			bool flag2 = num4 == 0f;
			object obj = (double)num3 ^ 1.0;
			object obj2 = num3 ^ num4;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				num3 = 1f;
			}
			num5 = flash;
			grow = num3;
			flag5 = false;
		}
		else
		{
			num5 = flash;
			if (!(flash > 0f) && kick == 0f)
			{
				bool flag6 = kickSpeed == 0f;
				flag5 = flag6;
			}
			else
			{
				flag5 = false;
			}
		}
		if (num5 > 0f)
		{
			float deltaTime2 = Time.deltaTime;
			float num6 = deltaTime2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEE8]");
			float num7 = num6 / 0f;
			float num8 = num5 + num7;
			if (num8 < 0f)
			{
				num8 = 0f;
			}
			flash = num8;
		}
		if (kick != 0f || kickSpeed != 0f)
		{
			float deltaTime3 = Time.deltaTime;
			float num9 = kick * 3.2946913E+09f;
			float num10 = kickSpeed * 3.2553042E+09f;
			float num11 = num9 + num10;
			float num12 = deltaTime3 * num11;
			float num13 = (kickSpeed += num12);
			float deltaTime4 = Time.deltaTime;
			float num14 = num13 * deltaTime4;
			float num15 = kick + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			kick = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA9C]");
			if (num11 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				float num16 = kickSpeed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				if (num16 < 0f)
				{
					kick = 0f;
				}
			}
		}
		if (!flag5 || painted != health)
		{
			Paint();
		}
	}

	private void Paint()
	{
		//IL_0119: Expected Obj, but got I
		//IL_0168: Expected VT, but got I4
		//IL_04d2: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_0263: Expected Obj, but got I4
		//IL_0495: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		bool flag = !((double)grow < 1.0);
		double num = 1.0;
		if (!flag)
		{
			double num2 = (double)grow + -1.0;
			double num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			double num4 = num3 * 0.0;
			double num5 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			double num6 = num5 * 0.0;
			double num7 = num2 * num4;
			double num8 = num2 * num7;
			double num9 = num2 * num6;
			double num10 = num8 + 1.0;
			num = num9 + num10;
		}
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			double num11 = (double)kick * -0.5;
			double num12 = num * (double)size;
			double num13 = (double)kick + 1.0;
			double num14 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaOre)+60]");
			double num15 = num14 * 0.0;
			double num16 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaOre)+5C]");
			double num17 = num16 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
			object obj = 0;
			double num18 = num11 + 1.0;
			double num19 = num13 * num17;
			double num20 = num15 * num18;
			double num21 = num18 * num12;
			transform.localScale = (Vector3)0;
			UnityEngine.Object obj10;
			if (Shown__BackingField != 0)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v23+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v23+A0]");
				object obj4 = 0;
				object obj5 = obj4;
				if (obj4 == null)
				{
					goto IL_0408;
				}
				Kind kind = Shown__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v19+18]");
				bool flag3 = (nint)(int)kind < (nint)0;
				object obj6 = !flag3;
				if (obj6 != null)
				{
					goto IL_0416;
				}
				object obj7 = (int)Shown__BackingField * 72;
				object obj8 = obj4 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v20+54]");
				if ((nint)0 == 0)
				{
					object obj9 = 40;
				}
				else
				{
					object obj9 = 48;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaOre)+v219 @ X8_v23]");
				obj10 = (UnityEngine.Object)0;
			}
			else
			{
				obj10 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = obj10 == null;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			if (obj14 != null)
			{
				return;
			}
			if ((object)obj10 != null)
			{
				((Renderer)obj10).GetPropertyBlock(block);
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v15+E4]");
				bool flag7 = (nint)0 == 0;
				object obj16 = !flag7;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (block != null)
				{
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v13+A0]");
					object obj18 = 0;
					MaterialPropertyBlock materialPropertyBlock = block;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+18]");
					materialPropertyBlock.SetFloat(0, health);
					if (block != null)
					{
						object obj19 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v15+A0]");
						object obj20 = 0;
						float value = flash * flash;
						MaterialPropertyBlock materialPropertyBlock2 = block;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v16+1C]");
						materialPropertyBlock2.SetFloat(0, value);
						((Renderer)obj10).SetPropertyBlock(block);
						painted = health;
						return;
					}
				}
			}
		}
		goto IL_0408;
		IL_0416:
		throw new IndexOutOfRangeException();
		IL_0408:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0416;
	}

	public GillaOre()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004a: Expected VT, but got I
		//IL_0074: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v5+A0]");
		object obj2 = 0;
		lastHit = -10f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v6+C]");
		size = (Vector3)0;
		grow = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v6+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C0A0]");
		health = 0f;
		base._002Ector();
	}

	unsafe static GillaOre()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I
		//IL_09b3: Expected Obj, but got I
		//IL_008d: Expected Obj, but got Ref
		//IL_00ce: Expected Obj, but got Ref
		//IL_0117: Expected Obj, but got I8
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected Obj, but got Unknown
		//IL_092e: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_015a: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got Ref
		//IL_0233: Expected Obj, but got Ref
		//IL_025f: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02a3: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_038f: Expected Obj, but got Ref
		//IL_03d0: Expected Obj, but got Ref
		//IL_03f4: Expected Obj, but got I8
		//IL_040c: Expected Obj, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_0440: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0489: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I
		//IL_04bb: Expected Obj, but got I4
		//IL_04d1: Expected Obj, but got I
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I4
		//IL_05f2: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got I8
		//IL_0673: Expected Obj, but got I4
		//IL_0691: Expected Obj, but got I
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06db: Expected Obj, but got I4
		//IL_06f1: Expected Obj, but got I
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_071f: Expected Obj, but got I4
		//IL_073d: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I
		//IL_075d: Expected Obj, but got I
		//IL_076d: Expected Obj, but got I
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_07ab: Expected Obj, but got I
		//IL_0804: Expected Obj, but got I
		//IL_0840: Expected Obj, but got I
		//IL_086f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3120]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3128]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3130]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F2D0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D450]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BC18]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+8]");
		_ = 0;
		object obj12 = default;
		object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v8+8]");
		_ = 0;
		object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 64));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = default;
		bool flag = obj15 == null;
		object obj17 = default;
		object obj16 = obj17;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+18]");
			object obj18 = 0 & 0xFFFFFFFEL;
			bool flag2 = obj18 == null;
			obj16 = obj17;
			if (!flag2)
			{
				object obj19 = obj15 + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3160]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3158]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
				object obj22 = obj15 + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F770]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BF10]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj23 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v27+8]");
				_ = 0;
				object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 56));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj25 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v29+8]");
				_ = 0;
				object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 64));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+18]");
				bool flag3 = (nint)0 < (nint)2;
				object obj27 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+18]");
				object obj28 = -2;
				bool flag4 = obj28 == null;
				object obj29 = ~obj27;
				object obj30 = obj29 | flag4;
				object obj31 = 72;
				object obj32 = default;
				obj16 = obj32;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3180]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3150]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3148]");
					object obj35 = 0;
					object obj36 = obj15 + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
					object obj37 = obj15 + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CFE0]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107DBD0]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1F0]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj38 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v35+8]");
					_ = 0;
					object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 56));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj40 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v37+8]");
					_ = 0;
					object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 64));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+18]");
					object obj42 = 0 & 0xFFFFFFFCL;
					bool flag5 = obj42 == null;
					obj31 = 72;
					object obj43 = default;
					obj16 = obj43;
					if (!flag5)
					{
						object obj44 = obj15 + 248;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3188]");
						object obj45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj46 = obj15 + 248;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj16 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D190]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCE8]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+18]");
						bool flag6 = (nint)0 < (nint)4;
						object obj47 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+18]");
						object obj48 = -4;
						bool flag7 = obj48 == null;
						object obj49 = ~obj47;
						object obj50 = obj49 | flag7;
						obj31 = 72;
						if (obj50 == null)
						{
							object obj51 = obj15 + 320;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
							object obj52 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
							object obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
							object obj54 = obj15 + 320;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj55 = obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v42+A0]");
							object obj56 = 0;
							obj56 = obj15;
							object obj57 = obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							object obj58 = default;
							bool flag8 = obj58 == null;
							obj31 = 72;
							obj16 = 3;
							if (flag8)
							{
								goto IL_0883;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v81+18]");
							bool flag9 = (nint)0 == 0;
							obj31 = 72;
							obj16 = 3;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3170]");
								object obj59 = 0;
								obj16 = obj59;
								object obj60 = obj58 + 32;
								obj60 = obj59;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X20_v13-8]");
								object obj61 = 0 & 0xFFFFFFFEL;
								bool flag10 = obj61 == null;
								obj31 = 72;
								if (!flag10)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1A28]");
									object obj62 = 0;
									obj16 = obj62;
									object obj63 = obj58 + 40;
									obj63 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X20_v15-10]");
									bool flag11 = (nint)0 < (nint)2;
									object obj64 = !flag11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X20_v15-10]");
									object obj65 = -2;
									bool flag12 = obj65 == null;
									object obj66 = ~obj64;
									object obj67 = obj66 | flag12;
									obj31 = 72;
									if (obj67 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5D0]");
										object obj68 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3140]");
										object obj69 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3168]");
										object obj70 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3178]");
										object obj71 = 0;
										object obj72 = obj58 + 48;
										obj72 = obj68;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj73 = obj52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v54+A0]");
										object obj74 = (nint)0 + (nint)8;
										obj74 = obj58;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj75 = obj69;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v55+8]");
										_ = 0;
										object obj76 = obj52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v57+A0]");
										object obj77 = (nint)0 + (nint)16;
										object obj78 = default;
										obj77 = obj78;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										int num = Shader.PropertyToID((string)obj70);
										object obj79 = obj52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v58+A0]");
										object obj80 = 0;
										int num2 = Shader.PropertyToID((string)obj71);
										object obj81 = obj52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v60+A0]");
										object obj82 = 0;
										return;
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_0883;
		IL_0883:
		NullReferenceException ex2 = new NullReferenceException();
		IDictionary data = ((Exception)ex2)._data;
		if (((Exception)ex2)._data != null)
		{
			string helpURL = ((Exception)ex2)._helpURL;
			if (((Exception)ex2)._helpURL != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X9_v5 (System.String)+58]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
					return;
				}
			}
			throw new NullReferenceException();
		}
		object obj83 = typeof(PlayFabLoggerBase) + 168;
		object obj84 = obj83;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v17+E4]");
		bool flag13 = (nint)0 == 0;
		object obj85 = !flag13;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
	}
}
