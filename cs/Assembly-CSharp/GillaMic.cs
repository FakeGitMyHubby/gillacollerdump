using System;
using System.Collections;
using Cpp2ILInjected;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;
using UnityEngine.Android;

public static class GillaMic
{
	private sealed class _003CStart_003Ed__15 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private GillaMeta._003C_003Ec__DisplayClass15_1 _003C_003E8__1;

		private GillaMeta._003C_003Ec__DisplayClass15_2 _003C_003E8__2;

		private float _003Cwait_003E5__2;

		private GillaMeta.Answer _003Cstarting_003E5__3;

		private float _003CstartedAt_003E5__4;

		private string _003Cproblem_003E5__5;

		private string _003Csaid_003E5__6;

		private GillaMeta.Answer _003Cuser_003E5__7;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a78: Expected Obj, but got Unknown
			//IL_0a81: Expected Obj, but got I4
			//IL_174c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1751: Expected Obj, but got Unknown
			//IL_175a: Expected Obj, but got I4
			//IL_176a: Unknown result type (might be due to invalid IL or missing references)
			//IL_176f: Expected Obj, but got Unknown
			//IL_1778: Expected Obj, but got I4
			//IL_1792: Expected Obj, but got I
			//IL_17bc: Expected Obj, but got I4
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected Obj, but got Unknown
			//IL_1994: Expected Obj, but got I4
			//IL_016b: Expected Obj, but got I
			//IL_017a: Expected I4, but got I8
			//IL_01a4: Expected Obj, but got I4
			//IL_02fd: Expected Obj, but got I
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_0718: Expected Obj, but got Unknown
			//IL_1be5: Expected Obj, but got I
			//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8a: Expected Obj, but got Unknown
			//IL_17f4: Expected Obj, but got I4
			//IL_0344: Expected Obj, but got I4
			//IL_0757: Expected Obj, but got I
			//IL_0f48: Expected Obj, but got I
			//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adc: Expected Obj, but got Unknown
			//IL_0ae5: Expected Obj, but got I4
			//IL_0aff: Expected Obj, but got I
			//IL_0b1f: Expected Obj, but got I4
			//IL_1b49: Expected Obj, but got I
			//IL_1b63: Expected Obj, but got I4
			//IL_048b: Expected Obj, but got I4
			//IL_0494: Expected Obj, but got I4
			//IL_0090: Expected I4, but got I8
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_00a4: Expected Obj, but got I4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00d6: Expected Obj, but got I4
			//IL_0f70: Expected Obj, but got I
			//IL_0ed1: Expected Obj, but got I4
			//IL_0c6e: Expected Obj, but got I
			//IL_0b3d: Expected Obj, but got I
			//IL_0b67: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got I
			//IL_036a: Expected I, but got Obj
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Expected Obj, but got Unknown
			//IL_0397: Expected Obj, but got I
			//IL_079e: Expected Obj, but got I4
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_00f9: Expected Obj, but got I4
			//IL_010c: Expected Obj, but got I4
			//IL_0fb1: Expected I, but got Obj
			//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c91: Expected Obj, but got Unknown
			//IL_0cb3: Expected Obj, but got I
			//IL_01ed: Expected Obj, but got I
			//IL_01f5: Expected I, but got Obj
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected Obj, but got Unknown
			//IL_0222: Expected Obj, but got I
			//IL_0242: Expected Obj, but got I4
			//IL_04b2: Expected Obj, but got I
			//IL_08e5: Expected Obj, but got I4
			//IL_08ee: Expected Obj, but got I4
			//IL_0f02: Invalid comparison between F4 and I4
			//IL_0f14: Expected Obj, but got I4
			//IL_0f22: Expected Obj, but got I4
			//IL_0cea: Expected I, but got Obj
			//IL_19cc: Expected Obj, but got I4
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Expected Obj, but got Unknown
			//IL_04f7: Expected Obj, but got I
			//IL_03cc: Expected Obj, but got I
			//IL_07bc: Expected Obj, but got I
			//IL_07c4: Expected I, but got Obj
			//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cf: Expected Obj, but got Unknown
			//IL_07f1: Expected Obj, but got I
			//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fcd: Expected Obj, but got Unknown
			//IL_1131: Expected Obj, but got I
			//IL_115b: Expected Obj, but got I4
			//IL_0260: Expected Obj, but got I
			//IL_0276: Expected Obj, but got I
			//IL_1c12: Expected Obj, but got I
			//IL_1c3c: Expected Obj, but got I
			//IL_1c56: Expected Obj, but got I
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected Obj, but got Unknown
			//IL_090c: Expected Obj, but got I
			//IL_0936: Expected Obj, but got I4
			//IL_1021: Expected Obj, but got I4
			//IL_118b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1190: Expected Obj, but got Unknown
			//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d06: Expected Obj, but got Unknown
			//IL_1819: Unknown result type (might be due to invalid IL or missing references)
			//IL_181e: Expected Obj, but got Unknown
			//IL_0bb0: Expected Obj, but got I
			//IL_0bda: Expected Obj, but got I4
			//IL_0550: Expected I, but got Obj
			//IL_0401: Expected Obj, but got I
			//IL_0417: Expected Obj, but got I
			//IL_0963: Expected Obj, but got I
			//IL_0826: Expected Obj, but got I
			//IL_104e: Expected Obj, but got I
			//IL_106c: Expected Obj, but got I
			//IL_0d36: Expected Obj, but got I
			//IL_0d50: Expected Obj, but got I
			//IL_0d58: Expected I, but got Obj
			//IL_0d69: Expected I, but got Obj
			//IL_02ae: Expected Obj, but got I
			//IL_0c10: Expected Obj, but got I
			//IL_1855: Unknown result type (might be due to invalid IL or missing references)
			//IL_185a: Expected Obj, but got Unknown
			//IL_18f3: Expected Obj, but got I4
			//IL_108b: Expected Obj, but got I
			//IL_1093: Expected I, but got Obj
			//IL_10a4: Expected I, but got Obj
			//IL_10bc: Expected Obj, but got I4
			//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c39: Expected Obj, but got Unknown
			//IL_0567: Unknown result type (might be due to invalid IL or missing references)
			//IL_056c: Expected Obj, but got Unknown
			//IL_044f: Expected Obj, but got I
			//IL_1b81: Expected Obj, but got I
			//IL_1bbf: Expected Obj, but got I4
			//IL_1bc7: Expected I, but got Obj
			//IL_085b: Expected Obj, but got I
			//IL_0871: Expected Obj, but got I
			//IL_14d3: Expected Obj, but got I4
			//IL_0c59: Expected Obj, but got I4
			//IL_059c: Expected Obj, but got I
			//IL_05b6: Expected Obj, but got I
			//IL_05be: Expected I, but got Obj
			//IL_05cf: Expected I, but got Obj
			//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a9: Expected Obj, but got Unknown
			//IL_10e2: Expected Obj, but got I
			//IL_10ea: Expected I, but got Obj
			//IL_1104: Expected Obj, but got I4
			//IL_0dbc: Expected Obj, but got I4
			//IL_0dd5: Expected I, but got Obj
			//IL_05ec: Expected Obj, but got I4
			//IL_09a9: Expected Obj, but got I4
			//IL_09b1: Expected I, but got Obj
			//IL_08a9: Expected Obj, but got I
			//IL_0df3: Expected Obj, but got I
			//IL_0e1d: Expected Obj, but got I4
			//IL_061a: Expected Obj, but got I
			//IL_0622: Expected I, but got Obj
			//IL_0653: Expected Obj, but got I4
			//IL_0663: Expected I, but got Obj
			//IL_0e4b: Expected Obj, but got I
			//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5a: Expected Obj, but got Unknown
			//IL_11d5: Expected Obj, but got I4
			//IL_11da: Expected I, but got Obj
			//IL_1555: Expected I, but got Obj
			//IL_1568: Unknown result type (might be due to invalid IL or missing references)
			//IL_156d: Expected Obj, but got Unknown
			//IL_0e7a: Expected Obj, but got I4
			//IL_0681: Expected Obj, but got I
			//IL_06ab: Expected Obj, but got I4
			//IL_0a12: Expected Obj, but got I4
			//IL_0a17: Expected I, but got Obj
			//IL_1689: Expected Obj, but got I4
			//IL_06d9: Expected Obj, but got I
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e8: Expected Obj, but got Unknown
			//IL_1205: Expected Obj, but got I4
			//IL_120a: Expected I, but got Obj
			//IL_0708: Expected Obj, but got I4
			//IL_0a42: Expected Obj, but got I4
			//IL_0a47: Expected I, but got Obj
			//IL_1226: Unknown result type (might be due to invalid IL or missing references)
			//IL_122b: Expected Obj, but got Unknown
			//IL_1911: Expected Obj, but got I
			//IL_1932: Expected Obj, but got I
			//IL_195c: Expected Obj, but got I4
			//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a68: Expected Obj, but got Unknown
			//IL_1258: Expected Obj, but got I
			//IL_1282: Expected Obj, but got I4
			//IL_1601: Unknown result type (might be due to invalid IL or missing references)
			//IL_1606: Expected Obj, but got Unknown
			//IL_160e: Expected Obj, but got I
			//IL_1620: Expected I, but got Obj
			//IL_1a04: Expected Obj, but got I4
			//IL_1653: Expected Obj, but got I
			//IL_1c88: Expected Obj, but got I
			//IL_1cc4: Expected Obj, but got I4
			//IL_1a3c: Expected Obj, but got I4
			//IL_1ce2: Expected Obj, but got I
			//IL_1d15: Expected Obj, but got I4
			//IL_1d1d: Expected I, but got Obj
			//IL_130c: Expected Obj, but got I4
			//IL_1314: Expected I, but got Obj
			//IL_133f: Expected Obj, but got I
			//IL_1369: Expected Obj, but got I4
			//IL_1a5a: Expected Obj, but got I
			//IL_1a6a: Expected Obj, but got I
			//IL_1a8c: Expected Obj, but got I4
			//IL_13f5: Expected Obj, but got I
			//IL_141f: Expected Obj, but got I4
			//IL_13b0: Expected Obj, but got I4
			//IL_1467: Expected Obj, but got I
			//IL_1491: Expected Obj, but got I4
			//IL_1ab8: Expected Obj, but got I
			//IL_1ad2: Expected Obj, but got I
			//IL_1ada: Expected I, but got Obj
			//IL_1aeb: Expected I, but got Obj
			//IL_1b09: Expected Obj, but got I
			//IL_1b24: Expected Obj, but got I4
			//IL_13e0: Expected Obj, but got I
			bool result;
			object obj4 = default;
			float num = default;
			nint num3;
			Request<User> request;
			nint num2;
			if (_003C_003E1__state > 1)
			{
				if (_003C_003E1__state != 2)
				{
					if (_003C_003E1__state != 3)
					{
						bool flag = _003C_003E1__state != 4;
						result = false;
						if (flag)
						{
							goto IL_1741;
						}
						num = _003Cwait_003E5__2 + _003Cwait_003E5__2;
						_003C_003E1__state = -1;
						object obj = this + 72;
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
						_003Cwait_003E5__2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj2 = this + 80;
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj3 = this + 88;
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj4 = 1114636288;
						goto IL_1746;
					}
					object obj5 = this + 40;
					object obj6 = obj5;
					_ = 4294967295L;
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v115+10]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v115+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v116+11]");
							bool flag2 = (nint)0 == 0;
							object obj8 = !flag2;
							if (obj8 != null)
							{
								goto IL_08ae;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25B0]");
							object obj9 = 0;
							num2 = (nint)obj9;
							request = (Request<User>)(this + 72);
							request = (Request<User>)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v8 (Oculus.Platform.Request`1<Oculus.Platform.Models.User>)-20]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v8 (Oculus.Platform.Request`1<Oculus.Platform.Models.User>)-20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v170+10]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v170+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2588]");
									object obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v170+10]");
									object obj13 = (nint)0 + (nint)24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v171+10]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
										obj13 = 0;
									}
									string text = (string)obj12 + (string)obj13;
									object obj14 = this + 80;
									obj14 = text;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num3 = 0;
									goto IL_08ae;
								}
							}
						}
					}
				}
				else
				{
					object obj15 = this + 32;
					object obj16 = obj15;
					_ = 4294967295L;
					if (obj15 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v91+10]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v91+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v92+11]");
							bool flag3 = (nint)0 == 0;
							object obj18 = !flag3;
							if (obj18 != null)
							{
								goto IL_0454;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25A0]");
							object obj19 = 0;
							num2 = (nint)obj19;
							request = (Request<User>)(this + 72);
							request = (Request<User>)obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v8 (Oculus.Platform.Request`1<Oculus.Platform.Models.User>)-28]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v8 (Oculus.Platform.Request`1<Oculus.Platform.Models.User>)-28]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v109+10]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v109+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2580]");
									object obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v109+10]");
									object obj23 = (nint)0 + (nint)24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v110+10]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
										obj23 = 0;
									}
									string text2 = (string)obj22 + (string)obj23;
									object obj24 = this + 80;
									obj24 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num3 = 0;
									goto IL_0454;
								}
							}
						}
					}
				}
				goto IL_16a6;
			}
			if (_003C_003E1__state != 0)
			{
				bool flag4 = _003C_003E1__state != 1;
				result = false;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
					object obj25 = 0;
					_003C_003E1__state = -1;
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v135+E4]");
					bool flag5 = (nint)0 == 0;
					object obj27 = !flag5;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj28 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v139+E4]");
					bool flag6 = (nint)0 == 0;
					object obj29 = !flag6;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj28 = obj25;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v139+A0]");
					object obj30 = 0;
					bool flag7 = obj30 == null;
					object obj31 = !flag7;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2590]");
						object obj32 = 0;
						num2 = (nint)obj32;
						object obj33 = this + 72;
						obj33 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v32-10]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v32-10]");
						bool flag8 = (nint)0 == 0;
						request = (Request<User>)109895680;
						if (flag8)
						{
							goto IL_16a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2598]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v32-10]");
						object obj36 = (nint)0 + (nint)24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v85+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFA0]");
							obj36 = 0;
						}
						string text3 = (string)obj35 + (string)obj36;
						object obj37 = this + 80;
						obj37 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						num3 = 0;
					}
					goto IL_0ad1;
				}
				goto IL_1741;
			}
			object obj38 = this + 56;
			obj38 = 0;
			_ = 4294967295L;
			_ = 1077936128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 0;
			goto IL_1746;
			IL_0454:
			_003C_003E8__1 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text4 = _003Cproblem_003E5__5;
			bool flag9 = _003Cproblem_003E5__5 == null;
			object obj39 = !flag9;
			object obj40 = 0;
			if (obj39 != null)
			{
				goto IL_0b2d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2570]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj42 = default;
			obj42._002Ector();
			object obj43 = this + 40;
			obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2530]");
			object obj44 = 0;
			request = (Request<User>)obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GillaMeta.Answer answer = default;
			answer._002Ector();
			object obj45 = this + 88;
			obj45 = answer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag10 = obj43 == null;
			num2 = (nint)answer;
			object obj50;
			object obj56;
			object obj57;
			if (!flag10)
			{
				object obj46 = obj43 + 16;
				obj46 = answer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Request<User> loggedInUser = Users.GetLoggedInUser();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDD0]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2568]");
				object obj48 = 0;
				num3 = (nint)obj48;
				Callback val = default;
				val._002Ector(obj43, (IntPtr)obj48);
				bool flag11 = loggedInUser == null;
				object obj49 = 0;
				request = loggedInUser;
				obj50 = obj43;
				if (flag11)
				{
					goto IL_14f6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEDD8]");
				object obj51 = 0;
				num3 = (nint)obj51;
				Request<System.__Canon> request2 = ((Request<System.__Canon>)(object)loggedInUser).OnComplete(val);
				object obj52 = obj43;
				bool flag12 = obj43 == null;
				obj49 = 0;
				request = loggedInUser;
				num2 = (nint)val;
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
					object obj53 = 0;
					object obj54 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ X0_v173+E4]");
					bool flag13 = (nint)0 == 0;
					object obj55 = !flag13;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v105+10]");
					IEnumerator enumerator = GillaMeta.Await((GillaMeta.Answer)0);
					obj56 = this + 24;
					obj56 = enumerator;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj57 = 3;
					goto IL_187a;
				}
			}
			goto IL_16a6;
			IL_1901:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25A8]");
			object obj58 = 0;
			object obj59;
			string message = (string)obj58 + (string)obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj60 = 0;
			object obj61 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v132+E4]");
			bool flag14 = (nint)0 == 0;
			object obj62 = !flag14;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
			object obj63 = 0;
			object obj64 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X0_v203+E4]");
			bool flag15 = (nint)0 == 0;
			object obj65 = !flag15;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj66 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X0_v207+E4]");
			bool flag16 = (nint)0 == 0;
			object obj67 = !flag16;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj66 = obj63;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X0_v207+A0]");
			object obj68 = (nint)0 + (nint)8;
			obj68 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj70;
			object obj69 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X0_v211+E4]");
			bool flag17 = (nint)0 == 0;
			object obj71 = !flag17;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj72 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v215+E4]");
			bool flag18 = (nint)0 == 0;
			object obj73 = !flag18;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj72 = obj70;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v215+A0]");
			object obj74 = 0;
			GillaMeta.Answer answer2 = _003Cuser_003E5__7;
			_ = 1;
			bool flag19 = _003Cuser_003E5__7 == null;
			num3 = 0;
			request = (Request<User>)109895680;
			num2 = (nint)obj59;
			if (!flag19)
			{
				bool flag20 = answer2.user == null;
				num3 = 0;
				request = (Request<User>)109895680;
				num2 = (nint)obj59;
				if (!flag20)
				{
					ulong num4 = default;
					string id = num4.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24F0]");
					object obj75 = 0;
					object obj76 = obj75;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X8_v145+E4]");
					bool flag21 = (nint)0 == 0;
					object obj77 = !flag21;
					if (obj77 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj76 = obj75;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X8_v145+A0]");
					object obj78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X9_v37+8]");
					Action<Action<string>> proof = (Action<Action<string>>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X9_v37+8]");
					bool flag22 = (nint)0 == 0;
					object obj79 = !flag22;
					nint num5 = 0;
					Action<System.__Canon> action = null;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ X8_v145+E4]");
						bool flag23 = (nint)0 == 0;
						object obj80 = !flag23;
						if (obj80 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj81 = obj75;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1364 @ X8_v159+A0]");
							obj78 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2528]");
						object obj82 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2540]");
						object obj83 = 0;
						num5 = (nint)obj83;
						Action<System.__Canon> action2 = default;
						action2._002Ector(obj78, (IntPtr)obj83);
						object obj84 = obj75;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X8_v158+A0]");
						object obj85 = (nint)0 + (nint)8;
						obj85 = action2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj49 = 0;
						proof = (Action<Action<string>>)action2;
						action = action2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
					object obj86 = 0;
					object obj87 = obj86;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X0_v220+E4]");
					bool flag24 = (nint)0 == 0;
					object obj88 = !flag24;
					if (obj88 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaCloud.MetaUser(id, proof);
					GillaName.SetMeta((string)obj59);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA900]");
					object obj89 = 0;
					object obj90 = obj89;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1381 @ X0_v224+E4]");
					bool flag25 = (nint)0 == 0;
					object obj91 = !flag25;
					if (obj91 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					ModMenu.AttachIfOwner();
					result = false;
					goto IL_1741;
				}
			}
			goto IL_16a6;
			IL_08ae:
			_003C_003E8__2 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			text4 = _003Cproblem_003E5__5;
			bool flag26 = _003Cproblem_003E5__5 == null;
			object obj92 = !flag26;
			obj40 = 0;
			if (obj92 != null)
			{
				goto IL_0b2d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
			obj70 = 0;
			object obj93 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X0_v190+E4]");
			bool flag27 = (nint)0 == 0;
			object obj94 = !flag27;
			if (obj94 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj95 = 0;
			object obj96 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X0_v194+E4]");
			bool flag28 = (nint)0 == 0;
			object obj97 = !flag28;
			if (obj97 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj96 = obj70;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X0_v194+A0]");
			object obj98 = 0;
			obj98 = obj95;
			object obj99 = obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			GillaMeta.Answer answer3 = _003Cuser_003E5__7;
			bool flag29 = _003Cuser_003E5__7 == null;
			request = (Request<User>)109895680;
			num2 = (nint)obj95;
			if (!flag29)
			{
				User user = answer3.user;
				bool flag30 = answer3.user == null;
				request = (Request<User>)109895680;
				num2 = (nint)obj95;
				if (!flag30)
				{
					bool flag31 = string.IsNullOrEmpty(user.OculusID__BackingField);
					GillaMeta.Answer answer4 = _003Cuser_003E5__7;
					if (flag31)
					{
						bool flag32 = _003Cuser_003E5__7 == null;
						request = (Request<User>)109895680;
						num2 = unchecked((nint)null);
						if (!flag32)
						{
							bool flag33 = answer4.user == null;
							request = (Request<User>)109895680;
							num2 = unchecked((nint)null);
							if (!flag33)
							{
								obj59 = answer4.user + 16;
								goto IL_1901;
							}
						}
					}
					else
					{
						bool flag34 = _003Cuser_003E5__7 == null;
						request = (Request<User>)109895680;
						num2 = unchecked((nint)null);
						if (!flag34)
						{
							bool flag35 = answer4.user == null;
							request = (Request<User>)109895680;
							num2 = unchecked((nint)null);
							if (!flag35)
							{
								obj59 = answer4.user + 48;
								goto IL_1901;
							}
						}
					}
				}
			}
			goto IL_16a6;
			IL_1746:
			object obj100 = this + 72;
			obj100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj101 = this + 80;
			obj101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
			object obj102 = 0;
			object obj103 = obj102;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v12+E4]");
			bool flag36 = (nint)0 == 0;
			object obj104 = !flag36;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj105 = obj102;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v16+E4]");
			bool flag37 = (nint)0 == 0;
			object obj106 = !flag37;
			if (obj106 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj105 = obj102;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v16+A0]");
			object obj107 = 0;
			if (obj107 == null)
			{
				obj43 = this + 56;
				object obj108 = obj43;
				if (obj43 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v12+10]");
					bool flag38 = (nint)0 == 0;
					object obj109 = !flag38;
					if (obj109 == null)
					{
						float realtimeSinceStartup = Time.realtimeSinceStartup;
						num = realtimeSinceStartup - _003CstartedAt_003E5__4;
						bool flag39 = !(num > 1.1190927E+09f);
						obj4 = 1119092736;
						Callback val2 = null;
						object obj110 = 1119092736;
						float num6 = num;
						if (flag39)
						{
							goto IL_1121;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2550]");
				object obj111 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj112 = default;
				obj112._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2530]");
				object obj113 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GillaMeta.Answer answer5 = default;
				answer5._002Ector();
				obj43 = answer5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag40 = obj112 == null;
				num2 = (nint)answer5;
				if (!flag40)
				{
					request = (Request<User>)(obj112 + 16);
					request = (Request<User>)(object)answer5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num = Time.realtimeSinceStartup;
					object obj114 = obj102;
					_003CstartedAt_003E5__4 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X0_v27+E4]");
					bool flag41 = (nint)0 == 0;
					object obj115 = !flag41;
					if (obj115 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24D0]");
					object appId = 0;
					Request<PlatformInitialize> request3 = Core.AsyncInitialize((string)appId);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC0]");
					object obj116 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2548]");
					object obj117 = 0;
					num3 = (nint)obj117;
					Callback val3 = default;
					val3._002Ector(obj112, (IntPtr)obj117);
					bool flag42 = request3 == null;
					object obj49 = 0;
					obj50 = obj112;
					if (!flag42)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFD0]");
						object obj118 = 0;
						num3 = (nint)obj118;
						Request<System.__Canon> request4 = ((Request<System.__Canon>)(object)request3).OnComplete(val3);
						obj49 = 0;
						Callback val2 = val3;
						object obj110 = obj4;
						float num6 = num;
						goto IL_1121;
					}
					goto IL_14e8;
				}
				goto IL_16a6;
			}
			goto IL_0ad1;
			IL_14e8:
			NullReferenceException ex = new NullReferenceException();
			goto IL_14f6;
			IL_16a6:
			throw new NullReferenceException();
			IL_14f6:
			NullReferenceException ex2 = new NullReferenceException();
			bool flag43 = (nint)obj50 != 1;
			NullReferenceException ex3 = ex2;
			if (!flag43)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj120 = default;
				object obj119 = obj120;
				num2 = (nint)obj119;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj122 = default;
				object obj121 = obj122 & 1;
				if (obj121 != null)
				{
					object obj123 = obj120;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					if (obj120 != null)
					{
						object obj124 = obj123;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v39+190]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v337 @ X8_v39+188] (should have been resolved before IL gen)");
						if (request != null)
						{
							object obj125 = request + 24;
							IntPtr intPtr = default;
							obj125 = (nint)intPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							nint num7 = (nint)request;
							bool flag44 = request == null;
							num2 = intPtr;
							if (!flag44)
							{
								_ = 1;
								Callback val2 = (Callback)(object)(nint)intPtr;
								object obj110 = obj4;
								float num6 = num;
								goto IL_1121;
							}
						}
					}
					goto IL_16a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj126 = obj120;
				obj50 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				NullReferenceException ex4 = default;
				ex3 = ex4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result2 = default;
			return result2;
			IL_1741:
			return result;
			IL_0ad1:
			object obj127 = this + 88;
			obj127 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X20_v22-10]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X20_v22-10]");
			bool flag45 = (nint)0 == 0;
			obj40 = 0;
			if (!flag45)
			{
				goto IL_0b2d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2560]");
			object obj128 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj129 = default;
			obj129._002Ector();
			obj43 = this + 32;
			obj43 = obj129;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2530]");
			object obj130 = 0;
			request = (Request<User>)obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GillaMeta.Answer answer6 = default;
			answer6._002Ector();
			bool flag46 = obj43 == null;
			num2 = (nint)obj129;
			if (!flag46)
			{
				object obj131 = obj43 + 16;
				obj131 = answer6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Request request5 = Entitlements.IsUserEntitledToApplication();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2538]");
				object obj132 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2558]");
				object obj133 = 0;
				num3 = (nint)obj133;
				AssetFile.Callback callback = default;
				callback._002Ector(obj43, (IntPtr)obj133);
				object obj49;
				if (request5 == null)
				{
					NullReferenceException ex5 = new NullReferenceException();
					obj49 = 0;
					request = (Request<User>)request5;
					obj50 = obj43;
					goto IL_14e8;
				}
				Request request6 = request5.OnComplete(callback);
				object obj134 = obj43;
				bool flag47 = obj43 == null;
				obj49 = 0;
				num3 = 0;
				request = (Request<User>)request5;
				num2 = (nint)callback;
				if (!flag47)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
					object obj135 = 0;
					object obj136 = obj135;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X0_v126+E4]");
					bool flag48 = (nint)0 == 0;
					object obj137 = !flag48;
					if (obj137 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v74+10]");
					IEnumerator enumerator2 = GillaMeta.Await((GillaMeta.Answer)0);
					obj56 = this + 24;
					obj56 = enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj57 = 2;
					goto IL_187a;
				}
			}
			goto IL_16a6;
			IL_187a:
			result = true;
			goto IL_1741;
			IL_0b2d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
			object obj138 = 0;
			object obj139 = obj138;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X0_v83+E4]");
			bool flag49 = (nint)0 == 0;
			object obj140 = !flag49;
			if (obj140 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj141 = obj138;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X0_v87+E4]");
			bool flag50 = (nint)0 == 0;
			object obj142 = !flag50;
			if (obj142 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj141 = obj138;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X0_v87+A0]");
			object obj143 = 0;
			obj143 = text4;
			object obj144 = obj138;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj145 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2578]");
			object format = 0;
			object arg = default;
			string message2 = string.Format((string)format, _003Csaid_003E5__6, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj146 = 0;
			object obj147 = obj146;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v60+E4]");
			bool flag51 = (nint)0 == 0;
			object obj148 = !flag51;
			if (obj148 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE390]");
			object obj149 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			WaitForSecondsRealtime waitForSecondsRealtime = default;
			waitForSecondsRealtime._002Ector(_003Cwait_003E5__2);
			obj56 = this + 24;
			obj56 = waitForSecondsRealtime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj57 = 4;
			goto IL_187a;
			IL_1121:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
			object obj150 = 0;
			object obj151 = obj150;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v74+E4]");
			bool flag52 = (nint)0 == 0;
			object obj152 = !flag52;
			if (obj152 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerator enumerator3 = GillaMeta.Await((GillaMeta.Answer)obj43);
			object obj153 = this + 24;
			obj153 = enumerator3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 1;
			result = true;
			goto IL_1741;
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

	private const string NeverAskKey = null;

	private static bool asked;

	public static bool Allowed
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC520]");
			object permission = 0;
			return Permission.HasUserAuthorizedPermission((string)permission);
		}
	}

	public static void AskOnce()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I
		//IL_044f: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e9: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I4
		//IL_0510: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I
		//IL_04ba: Expected I, but got Obj
		//IL_04d8: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I
		//IL_058b: Expected I, but got Obj
		//IL_05a9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25C8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj3 = 0;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 != null)
		{
			return;
		}
		bool allowed = Allowed;
		bool flag2 = !allowed;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25F8]");
		object key = 0;
		int num = PlayerPrefs.GetInt((string)key, 0);
		if (num == 1)
		{
			return;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25D0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v9+A0]");
		object obj8 = 0;
		obj8 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		PermissionCallbacks permissionCallbacks = default;
		permissionCallbacks._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25F0]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v34+8]");
		Action<string> value = (Action<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v34+8]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v38+A0]");
				obj12 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25D8]");
			object obj17 = 0;
			Action<System.__Canon> action = default;
			action._002Ector(obj12, (IntPtr)obj17);
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v37+A0]");
			object obj19 = (nint)0 + (nint)8;
			obj19 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj20 = 0;
			value = (Action<string>)action;
		}
		permissionCallbacks.PermissionGranted += value;
		object obj21 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v28+10]");
		Action<string> value2 = (Action<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v28+10]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v32+A0]");
				obj23 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25E0]");
			object obj28 = 0;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj23, (IntPtr)obj28);
			object obj29 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v31+A0]");
			object obj30 = (nint)0 + (nint)16;
			obj30 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj20 = 0;
			value2 = (Action<string>)action2;
		}
		permissionCallbacks.PermissionDenied += value2;
		object obj31 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v18+E4]");
		bool flag9 = (nint)0 == 0;
		object obj32 = !flag9;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v18+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v22+18]");
		Action<string> value3 = (Action<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v22+18]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v18+E4]");
			bool flag11 = (nint)0 == 0;
			object obj35 = !flag11;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj36 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v26+A0]");
				obj33 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25E8]");
			object obj38 = 0;
			Action<System.__Canon> action3 = default;
			action3._002Ector(obj33, (IntPtr)obj38);
			object obj39 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v25+A0]");
			object obj40 = (nint)0 + (nint)24;
			obj40 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			value3 = (Action<string>)action3;
		}
		permissionCallbacks.PermissionDeniedAndDontAskAgain += value3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC520]");
		object permission = 0;
		Permission.RequestUserPermission((string)permission, permissionCallbacks);
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D25C8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
	}
}
