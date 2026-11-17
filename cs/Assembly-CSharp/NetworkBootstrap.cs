using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Fusion;
using Fusion.Photon.Realtime;
using Photon.Realtime;
using Photon.Voice;
using Photon.Voice.Unity;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class NetworkBootstrap : MonoBehaviour
{
	private sealed class _003CVerifyProof_003Ed__547 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string player;

		public string session;

		public string sig;

		public NetworkApe _003C_003E4__this;

		public string account;

		private NetworkApe._003C_003Ec__DisplayClass547_0 _003C_003E8__1;

		public string nick;

		public string room;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CVerifyProof_003Ed__547(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_07ea: Expected I4, but got I8
			//IL_01da: Expected I4, but got I8
			//IL_0040: Expected Obj, but got I4
			//IL_0209: Expected Obj, but got I
			//IL_12c1: Expected I4, but got Obj
			//IL_005e: Expected Obj, but got I
			//IL_006d: Expected I4, but got I8
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00c1: Expected I, but got Obj
			//IL_0279: Expected I, but got Obj
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected Obj, but got Unknown
			//IL_02b5: Expected Obj, but got I8
			//IL_00df: Expected Obj, but got I
			//IL_00ff: Expected Obj, but got I
			//IL_0110: Expected I, but got Obj
			//IL_0125: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_02e2: Expected Obj, but got I
			//IL_02ea: Expected I, but got Obj
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Expected Obj, but got Unknown
			//IL_032c: Expected Obj, but got I4
			//IL_0342: Expected Obj, but got I
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Expected Obj, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected Obj, but got Unknown
			//IL_037f: Expected I, but got Obj
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Expected Obj, but got Unknown
			//IL_03bb: Expected Obj, but got I8
			//IL_03e0: Expected I, but got Obj
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Expected Obj, but got Unknown
			//IL_0422: Expected Obj, but got I4
			//IL_0438: Expected Obj, but got I
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Expected Obj, but got Unknown
			//IL_0475: Expected I, but got Obj
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Expected Obj, but got Unknown
			//IL_04b9: Expected Obj, but got I4
			//IL_04cf: Expected Obj, but got I
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f4: Expected Obj, but got Unknown
			//IL_050a: Expected I, but got Obj
			//IL_0513: Unknown result type (might be due to invalid IL or missing references)
			//IL_0518: Expected Obj, but got Unknown
			//IL_054c: Expected Obj, but got I4
			//IL_0562: Expected Obj, but got I
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Expected Obj, but got Unknown
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Expected Obj, but got Unknown
			//IL_05f9: Expected Obj, but got I4
			//IL_062e: Expected Obj, but got I4
			//IL_0633: Expected I, but got Obj
			//IL_1309: Expected Obj, but got I4
			//IL_130e: Expected I, but got Obj
			//IL_0831: Expected Obj, but got I
			//IL_087c: Expected Obj, but got I4
			//IL_1372: Expected Obj, but got I
			//IL_139f: Expected Obj, but got I4
			//IL_13a4: Expected I, but got Obj
			//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a6: Expected Obj, but got Unknown
			//IL_06cd: Expected Obj, but got I
			//IL_0713: Expected Obj, but got I4
			//IL_132c: Expected Obj, but got I
			//IL_134c: Expected Obj, but got I4
			//IL_1354: Expected I, but got Obj
			//IL_08b1: Expected Obj, but got I
			//IL_08ce: Expected Obj, but got I
			//IL_08ec: Expected Obj, but got I4
			//IL_098f: Expected Obj, but got I
			//IL_0748: Expected Obj, but got I
			//IL_0765: Expected Obj, but got I
			//IL_0781: Expected Obj, but got I
			//IL_07a0: Expected I, but got Obj
			//IL_0924: Expected Obj, but got I4
			//IL_13c2: Expected Obj, but got I
			//IL_13ee: Expected I, but got Obj
			//IL_07c4: Expected Obj, but got I
			//IL_09fc: Expected I, but got Obj
			//IL_0959: Expected Obj, but got I
			//IL_0976: Expected Obj, but got I
			//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a92: Expected Obj, but got Unknown
			//IL_0ab6: Expected Obj, but got I
			//IL_0b5a: Expected Obj, but got I8
			//IL_0af2: Expected I, but got Obj
			//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9a: Expected Obj, but got Unknown
			//IL_0ba2: Expected Obj, but got I
			//IL_0bd6: Expected Obj, but got I4
			//IL_140c: Expected Obj, but got I
			//IL_0ca2: Expected Obj, but got I4
			//IL_0cb2: Expected Obj, but got I4
			//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd7: Expected Obj, but got Unknown
			//IL_0c32: Expected I, but got Obj
			//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d08: Expected Obj, but got Unknown
			//IL_0d10: Expected Obj, but got I
			//IL_0d32: Expected Obj, but got I
			//IL_0e0b: Expected Obj, but got I8
			//IL_0da3: Expected I, but got Obj
			//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4b: Expected Obj, but got Unknown
			//IL_0e53: Expected Obj, but got I
			//IL_0e7b: Expected Obj, but got I
			//IL_0e9a: Expected Obj, but got I
			//IL_0ea5: Expected Obj, but got I4
			//IL_0ed1: Expected Obj, but got I
			//IL_0f4e: Expected Obj, but got I4
			//IL_0f5e: Expected Obj, but got I4
			//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f83: Expected Obj, but got Unknown
			//IL_0ede: Expected I, but got Obj
			//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb4: Expected Obj, but got Unknown
			//IL_0fec: Expected Obj, but got I
			//IL_1016: Expected Obj, but got I4
			//IL_1126: Expected Obj, but got I4
			//IL_108d: Expected Obj, but got I4
			//IL_11a2: Expected Obj, but got I4
			//IL_1155: Expected Obj, but got I4
			//IL_1186: Expected Obj, but got I4
			//IL_118f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1194: Expected Obj, but got Unknown
			//IL_1107: Expected Obj, but got I4
			//IL_11b7: Expected Obj, but got I
			//IL_11da: Expected Obj, but got I
			//IL_1204: Expected Obj, but got I4
			//IL_1231: Expected Obj, but got I
			//IL_1258: Unknown result type (might be due to invalid IL or missing references)
			//IL_125d: Expected Obj, but got Unknown
			NetworkApe networkApe;
			string photonUser;
			object obj50;
			object obj93;
			NullReferenceException ex = default;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_07cd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF20]");
					object obj2 = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj3 = default;
					obj3._002Ector();
					object obj4 = this + 72;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj5 = obj4;
					bool flag2 = obj4 == null;
					nint num = (nint)obj3;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAB78]");
						object obj6 = 0;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF18]");
						object obj7 = 0;
						Action<bool> action = default;
						action._002Ector(obj4, (IntPtr)obj7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						object obj8 = 0;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v138+E4]");
						bool flag3 = (nint)0 == 0;
						object obj10 = !flag3;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						IEnumerator enumerator = ShiftAuth.VerifyPeer(player, session, sig, action);
						object obj11 = this + 24;
						obj11 = enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						return true;
					}
				}
				else
				{
					networkApe = _003C_003E4__this;
					_003C_003E1__state = -1;
					if ((object)_003C_003E4__this != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
						object obj12 = 0;
						networkApe.checkingProof = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						string[] array = default;
						bool flag4 = array == null;
						nint num = 7;
						if (!flag4)
						{
							bool flag5 = array.Length == 0;
							num = 7;
							if (!flag5)
							{
								num = (nint)player;
								object obj13 = array + 32;
								obj13 = player;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X22_v8-8]");
								object obj14 = 0 & 0xFFFFFFFEL;
								if (obj14 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
									object obj15 = 0;
									num = (nint)obj15;
									object obj16 = array + 40;
									obj16 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X22_v10-10]");
									bool flag6 = (nint)0 < (nint)2;
									object obj17 = !flag6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X22_v10-10]");
									object obj18 = -2;
									bool flag7 = obj18 == null;
									object obj19 = ~obj17;
									object obj20 = obj19 | flag7;
									if (obj20 == null)
									{
										num = (nint)session;
										object obj21 = array + 48;
										obj21 = session;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X22_v12-18]");
										object obj22 = 0 & 0xFFFFFFFCL;
										if (obj22 != null)
										{
											num = (nint)obj15;
											object obj23 = array + 56;
											obj23 = obj15;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X22_v14-20]");
											bool flag8 = (nint)0 < (nint)4;
											object obj24 = !flag8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X22_v14-20]");
											object obj25 = -4;
											bool flag9 = obj25 == null;
											object obj26 = ~obj24;
											object obj27 = obj26 | flag9;
											if (obj27 == null)
											{
												num = (nint)sig;
												object obj28 = array + 64;
												obj28 = sig;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X22_v16-28]");
												bool flag10 = (nint)0 < (nint)5;
												object obj29 = !flag10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X22_v16-28]");
												object obj30 = -5;
												bool flag11 = obj30 == null;
												object obj31 = ~obj29;
												object obj32 = obj31 | flag11;
												if (obj32 == null)
												{
													num = (nint)obj15;
													object obj33 = array + 72;
													obj33 = obj15;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X22_v18-30]");
													bool flag12 = (nint)0 < (nint)6;
													object obj34 = !flag12;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X22_v18-30]");
													object obj35 = -6;
													bool flag13 = obj35 == null;
													object obj36 = ~obj34;
													object obj37 = obj36 | flag13;
													if (obj37 == null)
													{
														object obj38 = array + 80;
														obj38 = account;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														string text = string.Concat(array);
														bool flag14 = text != networkApe.lastProof;
														bool flag15 = !flag14;
														object obj39 = !flag15;
														if (obj39 != null)
														{
															goto IL_07cd;
														}
														photonUser = _003C_003E4__this.PhotonUser;
														bool flag16 = photonUser == null;
														object obj40 = 0;
														num = unchecked((nint)null);
														if (!flag16)
														{
															bool flag17 = photonUser._stringLength > 0;
															string text2 = photonUser;
															if (!flag17)
															{
																text2 = player;
															}
															NetworkApe._003C_003Ec__DisplayClass547_0 obj41 = _003C_003E8__1;
															bool flag18 = _003C_003E8__1 == null;
															obj40 = 0;
															num = unchecked((nint)null);
															if (!flag18)
															{
																if (~(obj41.valid ? 1u : 0u) == 0)
																{
																	object obj42 = _003C_003E4__this + 1728;
																	networkApe.provenProof = text;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
																	object obj43 = 0;
																	networkApe.proofProven = true;
																	networkApe.refusals = 0;
																	object obj44 = obj43;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v125+E4]");
																	bool flag19 = (nint)0 == 0;
																	object obj45 = !flag19;
																	if (obj45 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		obj44 = obj43;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v125+A0]");
																	object obj46 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v87+48]");
																	bool flag20 = (nint)0 == 0;
																	obj40 = 0;
																	num = (nint)text;
																	if (!flag20)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
																		object obj47 = 0;
																		obj40 = obj47;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v87+48]");
																		bool flag21 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)text2);
																		object obj48 = obj43;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v90+A0]");
																		object obj49 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v91+50]");
																		bool flag22 = (nint)0 == 0;
																		num = (nint)text2;
																		if (!flag22)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v91+50]");
																			bool flag23 = ((HashSet<System.__Canon>)0).Remove((System.__Canon)(object)text2);
																			goto IL_07cd;
																		}
																	}
																}
																else
																{
																	int refusals = networkApe.refusals + 1;
																	networkApe.refusals = refusals;
																	float unscaledTime = Time.unscaledTime;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
																	obj50 = 0;
																	float askAgainAt = unscaledTime + 30f;
																	object obj51 = obj50;
																	networkApe.askAgainAt = askAgainAt;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X0_v36+E4]");
																	bool flag24 = (nint)0 == 0;
																	object obj52 = !flag24;
																	if (obj52 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		obj51 = obj50;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X0_v36+A0]");
																	object obj53 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v26+48]");
																	bool flag25 = (nint)0 == 0;
																	double num2 = 30.0;
																	obj40 = 0;
																	num = unchecked((nint)null);
																	if (!flag25)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
																		object obj54 = 0;
																		obj40 = obj54;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v26+48]");
																		bool flag26 = ((HashSet<System.__Canon>)0).Contains((System.__Canon)(object)text2);
																		bool flag27 = !flag26;
																		object obj55 = !flag27;
																		if (obj55 == null)
																		{
																			object obj56 = obj50;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v115+E4]");
																			bool flag28 = (nint)0 == 0;
																			object obj57 = !flag28;
																			if (obj57 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				obj56 = obj50;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X0_v115+A0]");
																			object obj58 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v83+50]");
																			bool flag29 = (nint)0 == 0;
																			num2 = 30.0;
																			num = (nint)text2;
																			if (flag29)
																			{
																				goto IL_1296;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
																			object obj59 = 0;
																			obj40 = obj59;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v83+50]");
																			bool flag30 = ((HashSet<System.__Canon>)0).Add((System.__Canon)(object)text2);
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
																		object obj60 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																		object[] array2 = default;
																		bool flag31 = array2 == null;
																		num2 = 30.0;
																		num = 5;
																		if (!flag31)
																		{
																			bool flag32 = nick == null;
																			nint num3 = 5;
																			if (!flag32)
																			{
																				nint num4 = (nint)array2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
																				num3 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																				bool flag33 = ex == null;
																				num2 = 30.0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
																				num = 0;
																				if (flag33)
																				{
																					goto IL_12a4;
																				}
																			}
																			bool flag34 = array2.Length == 0;
																			num2 = 30.0;
																			num = num3;
																			if (!flag34)
																			{
																				object obj61 = array2 + 32;
																				obj61 = nick;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
																				object obj62 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																				IntPtr intPtr = default;
																				bool flag35 = intPtr == (IntPtr)0;
																				object obj63 = default;
																				nint num5 = (nint)(&obj63);
																				if (!flag35)
																				{
																					nint num6 = (nint)array2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
																					num5 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																					bool flag36 = ex == null;
																					num2 = 30.0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
																					num = 0;
																					if (flag36)
																					{
																						goto IL_12a4;
																					}
																				}
																				object obj64 = array2.Length & 0xFFFFFFFEL;
																				bool flag37 = obj64 == null;
																				num2 = 30.0;
																				num = num5;
																				if (!flag37)
																				{
																					object obj65 = array2 + 40;
																					obj65 = (nint)intPtr;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					object obj66 = obj50;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v53+E4]");
																					bool flag38 = (nint)0 == 0;
																					object obj67 = !flag38;
																					if (obj67 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																						obj66 = obj50;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v53+A0]");
																					object obj68 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v38+50]");
																					bool flag39 = (nint)0 == 0;
																					num2 = 30.0;
																					num = intPtr;
																					if (flag39)
																					{
																						goto IL_1296;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																					IntPtr intPtr2 = default;
																					bool flag40 = intPtr2 == (IntPtr)0;
																					object obj69 = default;
																					nint num7 = (nint)(&obj69);
																					if (!flag40)
																					{
																						nint num8 = (nint)array2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v79 (Il2CppClass<System.Object[]>)+40]");
																						num7 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																						bool flag41 = ex == null;
																						num2 = 30.0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v79 (Il2CppClass<System.Object[]>)+40]");
																						num = 0;
																						if (flag41)
																						{
																							goto IL_12a4;
																						}
																					}
																					bool flag42 = array2.Length < 2;
																					object obj70 = !flag42;
																					object obj71 = array2.Length - 2;
																					bool flag43 = obj71 == null;
																					object obj72 = ~obj70;
																					object obj73 = obj72 | flag43;
																					num2 = 30.0;
																					num = num7;
																					if (obj73 == null)
																					{
																						object obj74 = array2 + 48;
																						obj74 = (nint)intPtr2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						object obj75 = obj50;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v43+A0]");
																						object obj76 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v44+48]");
																						bool flag44 = (nint)0 == 0;
																						num2 = 30.0;
																						num = intPtr2;
																						if (flag44)
																						{
																							goto IL_1296;
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																						IntPtr intPtr3 = default;
																						bool flag45 = intPtr3 == (IntPtr)0;
																						object obj77 = default;
																						nint num9 = (nint)(&obj77);
																						if (!flag45)
																						{
																							nint num10 = (nint)array2;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v78 (Il2CppClass<System.Object[]>)+40]");
																							num9 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																							bool flag46 = ex == null;
																							num2 = 30.0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v78 (Il2CppClass<System.Object[]>)+40]");
																							num = 0;
																							if (flag46)
																							{
																								goto IL_12a4;
																							}
																						}
																						object obj78 = array2.Length & 0xFFFFFFFCL;
																						bool flag47 = obj78 == null;
																						num2 = 30.0;
																						num = num9;
																						if (!flag47)
																						{
																							object obj79 = array2 + 56;
																							obj79 = (nint)intPtr3;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							bool proofsLookBroken = NetworkApe.ProofsLookBroken;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF30]");
																							object obj80 = 0;
																							bool flag48 = !proofsLookBroken;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF40]");
																							object format = 0;
																							object obj81 = !flag48;
																							object obj82 = ~obj81;
																							if (obj82 != null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																								obj80 = 0;
																							}
																							bool flag49 = obj80 == null;
																							nint num11 = intPtr3;
																							if (!flag49)
																							{
																								nint num12 = (nint)array2;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v75 (Il2CppClass<System.Object[]>)+40]");
																								num11 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																								bool flag50 = ex == null;
																								num2 = 30.0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v75 (Il2CppClass<System.Object[]>)+40]");
																								num = 0;
																								if (flag50)
																								{
																									goto IL_12a4;
																								}
																							}
																							bool flag51 = array2.Length < 4;
																							object obj83 = !flag51;
																							object obj84 = array2.Length - 4;
																							bool flag52 = obj84 == null;
																							object obj85 = ~obj83;
																							object obj86 = obj85 | flag52;
																							num2 = 30.0;
																							num = num11;
																							if (obj86 == null)
																							{
																								object obj87 = array2 + 64;
																								obj87 = obj80;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								string message = string.Format((string)format, array2);
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
																								object obj88 = 0;
																								object obj89 = obj88;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v56+E4]");
																								bool flag53 = (nint)0 == 0;
																								object obj90 = !flag53;
																								if (obj90 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								}
																								Debug.LogWarning(message);
																								bool flag54 = photonUser._stringLength < 1;
																								string text3 = null;
																								StringComparison stringComparison;
																								if (!flag54)
																								{
																									object obj91 = obj50;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X0_v93+E4]");
																									bool flag55 = (nint)0 == 0;
																									object obj92 = !flag55;
																									if (obj92 == null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																									}
																									bool flag56 = NetworkApe.ProofsBound(((SimulationBehaviour)networkApe)._runner);
																									bool flag57 = !flag56;
																									text3 = null;
																									if (!flag57)
																									{
																										bool flag58 = string.Equals(player, photonUser, (StringComparison)5);
																										stringComparison = (StringComparison)5;
																										obj93 = flag58;
																										text3 = photonUser;
																										goto IL_146b;
																									}
																								}
																								stringComparison = (StringComparison)0;
																								obj93 = 0;
																								goto IL_146b;
																							}
																						}
																					}
																				}
																			}
																			goto IL_1288;
																		}
																	}
																}
															}
														}
														goto IL_1296;
													}
												}
											}
										}
									}
								}
							}
							goto IL_1288;
						}
					}
				}
				goto IL_1296;
			}
			_003C_003E1__state = -1;
			return false;
			IL_1288:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_1296;
			IL_146b:
			object obj97;
			if (networkApe.refusals == 2)
			{
				object obj94 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X0_v87+E4]");
				bool flag59 = (nint)0 == 0;
				object obj95 = !flag59;
				if (obj95 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool proofsLookBroken2 = NetworkApe.ProofsLookBroken;
				object obj96 = !proofsLookBroken2;
				obj97 = 1 & obj96;
			}
			else
			{
				obj97 = 0;
			}
			object obj98 = obj97 & obj93;
			if (obj98 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF38]");
				object obj99 = 0;
				string details = (string)obj99 + session;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj100 = 0;
				object obj101 = obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v65+E4]");
				bool flag60 = (nint)0 == 0;
				object obj102 = !flag60;
				if (obj102 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF28]");
				object reason = 0;
				IEnumerator enumerator2 = ShiftAuth.ReportKick(photonUser, nick, (string)reason, details, room);
				object obj103 = this + 24;
				obj103 = enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 2;
				return true;
			}
			goto IL_07cd;
			IL_1296:
			ex = new NullReferenceException();
			goto IL_12a4;
			IL_07cd:
			return false;
			IL_12a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex3 = new ArgumentNullException();
			return (byte)(int)ex3 != 0;
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

	public enum Lobby
	{
		// error: enumerator has no value
		Regular,
		// error: enumerator has no value
		Monster,
		// error: enumerator has no value
		Splash
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Dismemberment.Part> _003C_003E9__142_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE218]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal bool _003CStart_003Eb__142_0(Dismemberment.Part p)
		{
			//IL_00aa: Expected I4, but got Obj
			//IL_003d: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			if (p != null)
			{
				if (p.id != 0)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return p.renderer != null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass148_0
	{
		public TaskCompletionSource<string> ticket;

		internal void _003CFetchTicket_003Eb__0(bool ok, string fresh)
		{
			//IL_0093: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00b9: Expected Obj, but got I
			//IL_00c9: Expected Obj, but got I
			bool flag = !ok;
			object obj = !flag;
			string result = fresh;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v8+28]");
				result = (string)0;
			}
			bool flag3 = ((TaskCompletionSource<System.__Canon>)(object)ticket).TrySetResult((System.__Canon)(object)result);
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public string prefix;

		internal string _003CJoinCore_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0074: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = NewPublicCode();
			return prefix + text;
		}
	}

	private sealed class _003CCloseWhenMaster_003Ed__140 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkBootstrap _003C_003E4__this;

		public string room;

		private float _003Cuntil_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CCloseWhenMaster_003Ed__140(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a6: Expected I4, but got I8
			//IL_0021: Expected Obj, but got I4
			//IL_0399: Expected Obj, but got I
			//IL_03b3: Expected Obj, but got I
			//IL_03df: Expected Obj, but got I
			//IL_0409: Expected Obj, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_0482: Expected I4, but got Obj
			//IL_00da: Expected Obj, but got I
			//IL_0104: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got I4
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Expected Obj, but got Unknown
			//IL_0456: Expected Obj, but got I4
			//IL_02ea: Expected Obj, but got I
			//IL_02fa: Expected Obj, but got I
			//IL_0334: Expected Obj, but got I
			//IL_035e: Expected Obj, but got I4
			NetworkBootstrap networkBootstrap = _003C_003E4__this;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0434;
				}
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this == null)
				{
					goto IL_0474;
				}
				networkBootstrap.RoomClosedForTest__BackingField = false;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float num = realtimeSinceStartup + 20f;
				_003Cuntil_003E5__2 = num;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			if (realtimeSinceStartup2 < _003Cuntil_003E5__2)
			{
				if ((object)_003C_003E4__this == null)
				{
					goto IL_0474;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = (UnityEngine.Object)networkBootstrap.runner == (UnityEngine.Object)null;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					if ((object)networkBootstrap.runner == null)
					{
						goto IL_0474;
					}
					if (networkBootstrap.runner.IsRunning)
					{
						string roomName = _003C_003E4__this.RoomName;
						bool flag5 = roomName != room;
						bool flag6 = !flag5;
						object obj6 = !flag6;
						if (obj6 == null)
						{
							if ((object)networkBootstrap.runner != null)
							{
								if (networkBootstrap.runner.IsSharedModeMasterClient)
								{
									NetworkRunner runner = networkBootstrap.runner;
									if ((object)networkBootstrap.runner == null)
									{
										goto IL_0474;
									}
									SessionInfo sessionInfo = runner.SessionInfo__BackingField;
									if (runner.SessionInfo__BackingField != null && ~(sessionInfo._isValid ? 1u : 0u) == 0)
									{
										runner.SessionInfo__BackingField.IsOpen = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE328]");
										object obj7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE338]");
										object obj8 = 0;
										networkBootstrap.RoomClosedForTest__BackingField = true;
										string message = (string)obj7 + room + (string)obj8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj9 = 0;
										object obj10 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v24+E4]");
										bool flag7 = (nint)0 == 0;
										object obj11 = !flag7;
										if (obj11 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.Log(message);
										goto IL_0434;
									}
								}
								object obj12 = this + 24;
								obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_ = 1;
								return true;
							}
							goto IL_0474;
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE330]");
				object format = 0;
				object arg = default;
				string message2 = string.Format((string)format, room, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message2);
			}
			goto IL_0434;
			IL_0474:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0434:
			return false;
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

	[StructLayout((LayoutKind)3)]
	private struct _003CDisconnect_003Ed__182 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkBootstrap _003C_003E4__this;

		private int _003Cmine_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_033c: Expected VT, but got I4
			//IL_034b: Expected I4, but got I8
			//IL_085f: Expected Obj, but got I
			//IL_0889: Expected Obj, but got I4
			//IL_0393: Expected Obj, but got I4
			//IL_0684: Expected I4, but got I8
			//IL_068f: Expected VT, but got Ref
			//IL_0698: Expected Ref, but got VT
			//IL_0046: Expected Obj, but got I4
			//IL_03bb: Expected Obj, but got I4
			//IL_03c0: Expected I, but got Obj
			//IL_0064: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I
			//IL_00db: Expected Obj, but got I4
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Expected Obj, but got Unknown
			//IL_0109: Expected Obj, but got I4
			//IL_010e: Expected I, but got Obj
			//IL_0477: Expected Obj, but got I
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Expected Obj, but got Unknown
			//IL_04c3: Expected Obj, but got I4
			//IL_04f2: Expected Obj, but got I
			//IL_050e: Expected Obj, but got I4
			//IL_0433: Expected Obj, but got I4
			//IL_0740: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Expected Obj, but got Unknown
			//IL_012d: Expected Obj, but got I
			//IL_0610: Expected Obj, but got I
			//IL_063a: Expected Obj, but got I4
			//IL_0667: Expected Obj, but got I
			//IL_054b: Expected Obj, but got I4
			//IL_07f6: Expected Obj, but got I4
			//IL_076b: Expected Obj, but got I4
			//IL_0773: Expected Obj, but got Ref
			//IL_0791: Expected I4, but got I8
			//IL_079c: Expected VT, but got Ref
			//IL_07a9: Expected Ref, but got VT
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected Obj, but got Unknown
			//IL_0176: Expected Obj, but got I4
			//IL_057a: Expected Obj, but got I
			//IL_0596: Expected Obj, but got I4
			//IL_01bf: Expected Obj, but got I
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected Obj, but got Unknown
			//IL_01f1: Expected Obj, but got I
			//IL_0221: Expected Obj, but got I4
			//IL_024e: Expected Obj, but got I
			//IL_0263: Expected Obj, but got I
			//IL_027f: Expected Obj, but got I4
			//IL_0287: Expected I, but got Obj
			//IL_05c9: Expected Obj, but got I4
			//IL_05ce: Expected I, but got Obj
			//IL_05ed: Expected Obj, but got I
			//IL_05f6: Expected Obj, but got I4
			//IL_02ce: Expected Obj, but got I4
			//IL_02d7: Expected Obj, but got I4
			//IL_02fb: Expected Obj, but got Ref
			//IL_0303: Expected Obj, but got VT
			//IL_0319: Expected VT, but got Ref
			//IL_0327: Expected Ref, but got VT
			UnityEngine.Object obj = _003C_003E4__this;
			TaskAwaiter awaiter2 = default;
			nint num = default;
			if (_003C_003E1__state != 0)
			{
				if ((object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+A4]");
					bool flag = (nint)0 == 0;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj3 = 0;
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v60+E4]");
						bool flag2 = (nint)0 == 0;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag3 = (UnityEngine.Object)0 == null;
						bool flag4 = !flag3;
						object obj6 = !flag4;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+B0]");
							bool flag5 = (nint)0 == 0;
							object obj7 = 0;
							num = unchecked((nint)null);
							if (flag5)
							{
								goto IL_06ba;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+B0]");
							if (((NetworkRunner)0).IsRunning)
							{
								_ = 1;
								float unscaledTime = Time.unscaledTime;
								object obj8 = _003C_003E4__this + 152;
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v68+90]");
								int num2 = (int)((nint)0 + (nint)1);
								_003Cmine_003E5__2 = num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								object obj9 = 0;
								object obj10 = _003C_003E4__this + 216;
								obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
								object obj11 = 0;
								_ = 0;
								object obj12 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v73+E4]");
								bool flag6 = (nint)0 == 0;
								object obj13 = !flag6;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE350]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+B0]");
								Task task = Leave((NetworkRunner)0, (string)obj14);
								bool flag7 = task == null;
								obj7 = 0;
								num = (nint)obj14;
								if (flag7)
								{
									goto IL_06c8;
								}
								TaskAwaiter awaiter = task.GetAwaiter();
								bool isCompleted = awaiter2.IsCompleted;
								bool flag8 = !isCompleted;
								object obj15 = !flag8;
								obj7 = 0;
								if (obj15 == null)
								{
									_003C_003E1__state = 0;
									object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
									obj16 = awaiter2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, _003CDisconnect_003Ed__182>(ref awaiter2, ref this);
									return;
								}
								goto IL_0846;
							}
						}
					}
					goto IL_0675;
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_06ac;
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			awaiter2 = _003C_003Eu__1;
			goto IL_0846;
			IL_0846:
			awaiter2.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v4+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = _003C_003E4__this == null;
			bool flag11 = !flag10;
			object obj20 = !flag11;
			if (obj20 == null)
			{
				bool flag12 = (object)_003C_003E4__this == null;
				object obj7 = 0;
				num = unchecked((nint)null);
				if (flag12)
				{
					goto IL_06ac;
				}
				int num3 = _003Cmine_003E5__2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+128]");
				if ((nint)num3 == 0)
				{
					object obj21 = _003C_003E4__this + 192;
					_ = 0;
					if (obj21 != null)
					{
						obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						NetworkBootstrap networkBootstrap = _003C_003E4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+C8]");
						networkBootstrap.Join((Lobby)0, (string)obj21, probe: false);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2C0]");
						object obj22 = 0;
						object obj23 = _003C_003E4__this + 120;
						obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj24 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v13+E4]");
						bool flag13 = (nint)0 == 0;
						object obj25 = !flag13;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+50]");
						bool flag14 = (UnityEngine.Object)0 != null;
						bool flag15 = !flag14;
						object obj26 = 0;
						UnityEngine.Object obj27 = null;
						if (!flag15)
						{
							object obj28 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v22+E4]");
							bool flag16 = (nint)0 == 0;
							object obj29 = !flag16;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+70]");
							bool flag17 = (UnityEngine.Object)0 != null;
							bool flag18 = !flag17;
							obj26 = 0;
							obj27 = null;
							if (!flag18)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+50]");
								bool flag19 = (nint)0 == 0;
								obj7 = 0;
								num = unchecked((nint)null);
								if (flag19)
								{
									goto IL_06d6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (UnityEngine.Object)+50]");
								((MicLevel)0).Restart();
								obj26 = 0;
								obj27 = null;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj30 = 0;
						object obj31 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v18+E4]");
						bool flag20 = (nint)0 == 0;
						object obj32 = !flag20;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE358]");
						object message = 0;
						Debug.Log(message);
					}
				}
			}
			goto IL_0675;
			IL_06d6:
			NullReferenceException ex2 = new NullReferenceException();
			bool flag21 = num != 1;
			NullReferenceException ex3 = ex2;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj34 = default;
				object obj33 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj36 = default;
				object obj35 = obj36 & 1;
				if (obj35 != null)
				{
					object obj37 = 0;
					object obj39 = default;
					object obj38 = (object)(&obj39);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetException((Exception)obj34);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj40 = obj34;
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj7 = 0;
				NullReferenceException ex4 = default;
				ex3 = ex4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_0675:
			_003C_003E1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder3 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder3)->SetResult();
			return;
			IL_06c8:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_06d6;
			IL_06ac:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_06ba;
			IL_06ba:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_06c8;
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected VT, but got Ref
			//IL_0018: Expected Ref, but got VT
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}
	}

	private sealed class _003CFetchTicket_003Ed__148 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TaskCompletionSource<string> ticket;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CFetchTicket_003Ed__148(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0049: Expected Obj, but got I
			//IL_0058: Expected I4, but got I8
			//IL_0191: Expected I4, but got Obj
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_00bf: Expected Obj, but got I
			//IL_0034: Expected I4, but got I8
			//IL_00de: Expected Obj, but got I
			//IL_00ef: Expected I, but got Obj
			//IL_00ff: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01b0;
				}
				num = -1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE368]");
				object obj = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj2 = default;
				obj2._002Ector();
				if (obj2 == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				object obj3 = obj2 + 16;
				obj3 = ticket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE360]");
				object obj5 = 0;
				Action<bool, System.__Canon> action = default;
				action._002Ector(obj2, (IntPtr)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerator enumerator = ShiftAuth.RefreshPhotonTicket((Action<bool, string>)action);
				object obj9 = this + 24;
				obj9 = enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_01b0;
			IL_01b0:
			return _003C_003E1__state == 0;
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

	[StructLayout((LayoutKind)3)]
	private struct _003CJoin_003Ed__184 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string code;

		public NetworkBootstrap _003C_003E4__this;

		public Lobby kind;

		public bool probe;

		private int _003CturnBefore_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_018f: Expected VT, but got I4
			//IL_019e: Expected I4, but got I8
			//IL_0010: Expected Obj, but got Ref
			//IL_002a: Expected Obj, but got I4
			//IL_01bc: Expected I4, but got I8
			//IL_01c7: Expected VT, but got Ref
			//IL_01d0: Expected Ref, but got VT
			//IL_0048: Expected Obj, but got I
			//IL_0050: Expected I, but got Obj
			//IL_020d: Expected Obj, but got I4
			//IL_012a: Expected Obj, but got I4
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected Obj, but got Unknown
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Expected Obj, but got Unknown
			//IL_014e: Expected Obj, but got Ref
			//IL_0156: Expected Obj, but got VT
			//IL_016c: Expected VT, but got Ref
			//IL_017a: Expected Ref, but got VT
			//IL_0292: Expected Obj, but got I4
			//IL_029a: Expected Obj, but got Ref
			//IL_075d: Expected Obj, but got Ref
			//IL_077b: Expected I4, but got I8
			//IL_0786: Expected VT, but got Ref
			//IL_0793: Expected Ref, but got VT
			//IL_06ce: Expected I, but got Obj
			//IL_06ea: Expected Obj, but got I4
			//IL_089b: Expected Obj, but got I4
			//IL_03bf: Expected Obj, but got I4
			//IL_0406: Expected Obj, but got I4
			//IL_08d5: Expected Obj, but got I4
			//IL_0472: Expected Obj, but got I4
			//IL_058c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0591: Expected Obj, but got Unknown
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Expected Obj, but got Unknown
			//IL_0534: Expected I, but got Obj
			//IL_062e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0633: Expected Obj, but got Unknown
			//IL_05b7: Expected Obj, but got I4
			//IL_056e: Expected Obj, but got I4
			NetworkBootstrap networkBootstrap = _003C_003E4__this;
			TaskAwaiter awaiter2 = default;
			nint num2;
			UnityEngine.Object obj9;
			object obj14 = default;
			nint num = default;
			object obj6;
			NullReferenceException ex3;
			if (_003C_003E1__state != 0)
			{
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj3 = 0;
					num = (nint)obj3;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				if ((object)_003C_003E4__this != null)
				{
					string text = code;
					bool flag2 = probe;
					_003CturnBefore_003E5__2 = networkBootstrap.joinTurn;
					Task task = _003C_003E4__this.JoinCore(kind, code, probe);
					bool flag3 = task == null;
					num = (nint)kind;
					if (!flag3)
					{
						TaskAwaiter awaiter = task.GetAwaiter();
						bool isCompleted = awaiter2.IsCompleted;
						bool flag4 = !isCompleted;
						object obj4 = !flag4;
						if (obj4 == null)
						{
							_003C_003E1__state = 0;
							object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
							obj5 = awaiter2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
							((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter, _003CJoin_003Ed__184>(ref awaiter2, ref this);
							return;
						}
						goto IL_082c;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				NullReferenceException ex2 = new NullReferenceException();
				bool flag5 = num != 1;
				obj6 = 0;
				num2 = num;
				ex3 = ex2;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj8 = default;
					object obj7 = obj8;
					obj9 = (UnityEngine.Object)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj11 = default;
					object obj10 = obj11 & 1;
					string text;
					if (obj10 != null)
					{
						object obj12 = 0;
						object obj13 = (object)(&obj14);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						string text2 = code;
						if (code != null)
						{
							string format;
							object arg;
							if (text2._stringLength >= 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								string text4 = default;
								string text5 = default;
								string text3 = text4 + code + text5;
								string text6 = default;
								format = text6;
								arg = text3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								string text7 = default;
								format = text7;
								object obj15 = default;
								arg = obj15;
							}
							string message = string.Format(format, arg, obj8);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v50+E4]");
							bool flag6 = (nint)0 == 0;
							object obj16 = !flag6;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogWarning(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v55+E4]");
							bool flag7 = (nint)0 == 0;
							object obj17 = !flag7;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = _003C_003E4__this == null;
							bool flag9 = !flag8;
							object obj18 = !flag9;
							if (obj18 == null)
							{
								bool flag10 = (object)_003C_003E4__this == null;
								bool flag2 = false;
								text = null;
								obj9 = null;
								if (flag10)
								{
									goto IL_06bd;
								}
								if (~(networkBootstrap.Joining__BackingField ? 1u : 0u) == 0)
								{
									object obj19 = _003CturnBefore_003E5__2 + 1;
									if (networkBootstrap.joinTurn != (nint)obj19)
									{
										goto IL_01ad;
									}
									int joinTurn = networkBootstrap.joinTurn + 1;
									networkBootstrap.Joining__BackingField = false;
									networkBootstrap.joinTurn = joinTurn;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v62+E4]");
								bool flag11 = (nint)0 == 0;
								object obj20 = !flag11;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag12 = (UnityEngine.Object)networkBootstrap.runner != (UnityEngine.Object)null;
								bool flag13 = !flag12;
								UnityEngine.Object obj21 = null;
								if (!flag13)
								{
									bool flag14 = (object)networkBootstrap.runner == null;
									flag2 = false;
									text = null;
									num = unchecked((nint)null);
									if (flag14)
									{
										goto IL_06d3;
									}
									bool isRunning = networkBootstrap.runner.IsRunning;
									bool flag15 = !isRunning;
									object obj22 = !flag15;
									obj21 = null;
									if (obj22 != null)
									{
										goto IL_01ad;
									}
								}
								object obj23 = _003C_003E4__this + 192;
								if (obj23 != null)
								{
									obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_003C_003E4__this.Join(networkBootstrap.queuedKind, (string)obj23, probe: false);
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									object obj24 = _003C_003E4__this + 120;
									object obj25 = default;
									obj24 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									object obj26 = _003C_003E4__this + 136;
									object obj27 = default;
									obj26 = obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_003C_003E4__this.RetryLater(kind, code);
								}
							}
							goto IL_01ad;
						}
						NullReferenceException ex4 = new NullReferenceException();
						goto IL_06bd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj28 = obj8;
					num = 101790920;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					text = null;
					goto IL_07d2;
				}
				goto IL_083a;
			}
			_003C_003Eu__1 = (TaskAwaiter)0;
			_003C_003E1__state = -1;
			awaiter2 = _003C_003Eu__1;
			goto IL_082c;
			IL_07e9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_082c:
			awaiter2.GetResult();
			goto IL_01ad;
			IL_06bd:
			NullReferenceException ex5 = new NullReferenceException();
			num = (nint)obj9;
			goto IL_06d3;
			IL_083a:
			if (num2 == 1)
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
					object obj33 = (object)(&obj14);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetException((Exception)obj30);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj34 = obj30;
				num = 101790920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				string text = null;
				goto IL_07d2;
			}
			goto IL_07e9;
			IL_01ad:
			_003C_003E1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder3 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder3)->SetResult();
			return;
			IL_07d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			NullReferenceException ex6 = default;
			ex3 = ex6;
			goto IL_07e9;
			IL_06d3:
			NullReferenceException ex7 = new NullReferenceException();
			obj6 = 1;
			num2 = num;
			ex3 = ex7;
			goto IL_083a;
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected VT, but got Ref
			//IL_0018: Expected Ref, but got VT
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}
	}

	private sealed class _003CJoinAfterAuth_003Ed__144 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkBootstrap _003C_003E4__this;

		private float _003CnextLogin_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CJoinAfterAuth_003Ed__144(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0079: Expected I4, but got I8
			//IL_0266: Expected Obj, but got I
			//IL_0290: Expected Obj, but got I4
			//IL_0021: Expected Obj, but got I4
			//IL_02b3: Expected Obj, but got I
			//IL_003e: Expected I4, but got I8
			//IL_01cd: Expected Obj, but got I
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected Obj, but got Unknown
			//IL_0141: Expected Obj, but got I
			//IL_0189: Expected Obj, but got I4
			//IL_022d: Expected I4, but got Obj
			NetworkBootstrap networkBootstrap = _003C_003E4__this;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_00e9;
				}
				_003C_003E1__state = -1;
				float unscaledTime = Time.unscaledTime;
				float num = unscaledTime + 5f;
				_003CnextLogin_003E5__2 = num;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+A0]");
			object obj5 = 0;
			if (obj5 != null)
			{
				if ((object)_003C_003E4__this != null)
				{
					networkBootstrap.waitingOnAuth = false;
					_003C_003E4__this.Join(networkBootstrap.Kind__BackingField, networkBootstrap.pendingCode, probe: false);
					goto IL_00e9;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			float unscaledTime2 = Time.unscaledTime;
			double num2 = _003CnextLogin_003E5__2;
			if (!(unscaledTime2 < _003CnextLogin_003E5__2))
			{
				float unscaledTime3 = Time.unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj6 = 0;
				unscaledTime2 = unscaledTime3 + 20f;
				object obj7 = obj6;
				_003CnextLogin_003E5__2 = unscaledTime2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v15+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Relogin();
				num2 = 20.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE390]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			WaitForSecondsRealtime waitForSecondsRealtime = default;
			waitForSecondsRealtime._002Ector(0.5f);
			object obj10 = this + 24;
			obj10 = waitForSecondsRealtime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 1;
			return true;
			IL_00e9:
			return false;
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

	[StructLayout((LayoutKind)3)]
	private struct _003CJoinCore_003Ed__185 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NetworkBootstrap _003C_003E4__this;

		public string code;

		public Lobby kind;

		public bool probe;

		private _003C_003Ec__DisplayClass185_0 _003C_003E8__1;

		private bool _003CownRoom_003E5__2;

		private int _003Cmine_003E5__3;

		private string _003CcameFrom_003E5__4;

		private bool _003CgoingPublic_003E5__5;

		private string _003CkindCode_003E5__6;

		private Dictionary<string, SessionProperty> _003Cproperties_003E5__7;

		private bool _003Cvoiced_003E5__8;

		private StartGameResult _003Cresult_003E5__9;

		private string _003Cfailure_003E5__10;

		private NetworkRunner _003CmineRunner_003E5__11;

		private int _003CstartWait_003E5__12;

		private TaskAwaiter _003C_003Eu__1;

		private TaskCompletionSource<string> _003Cticket_003E5__13;

		private TaskAwaiter<Task> _003C_003Eu__2;

		private Task<StartGameResult> _003Cstarting_003E5__14;

		private unsafe void MoveNext()
		{
			//IL_7902: Expected Obj, but got I
			//IL_03c9: Expected VT, but got I4
			//IL_03d8: Expected I4, but got I8
			//IL_03e9: Expected Obj, but got I4
			//IL_0400: Expected I4, but got I8
			//IL_0013: Expected Obj, but got I4
			//IL_002d: Expected Obj, but got I4
			//IL_7fee: Expected Obj, but got I
			//IL_8018: Expected Obj, but got I4
			//IL_043e: Expected Obj, but got I4
			//IL_0229: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I4
			//IL_5784: Expected I4, but got I8
			//IL_578f: Expected Obj, but got Ref
			//IL_5798: Expected Obj, but got I4
			//IL_57ad: Expected Obj, but got Ref
			//IL_57b6: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got Ref
			//IL_026e: Expected Obj, but got I
			//IL_0298: Expected Obj, but got I4
			//IL_0110: Expected VT, but got I4
			//IL_011f: Expected I4, but got I8
			//IL_0128: Expected Obj, but got I4
			//IL_013f: Expected I4, but got I8
			//IL_01f2: Expected VT, but got I4
			//IL_0201: Expected I4, but got I8
			//IL_020a: Expected Obj, but got I4
			//IL_57d0: Expected Obj, but got Ref
			//IL_57d9: Expected Obj, but got I4
			//IL_57ee: Expected Obj, but got Ref
			//IL_57f7: Expected Obj, but got I4
			//IL_047c: Expected Obj, but got I4
			//IL_79f7: Expected Obj, but got I
			//IL_7a17: Expected Obj, but got Ref
			//IL_0e89: Expected VT, but got I4
			//IL_0e98: Expected I4, but got I8
			//IL_5811: Expected Obj, but got Ref
			//IL_581a: Expected Obj, but got I4
			//IL_582f: Expected Obj, but got Ref
			//IL_5838: Expected Obj, but got I4
			//IL_7991: Expected Obj, but got I4
			//IL_1c33: Expected Obj, but got I
			//IL_5852: Expected Obj, but got Ref
			//IL_585b: Expected Obj, but got I4
			//IL_5876: Unknown result type (might be due to invalid IL or missing references)
			//IL_587b: Expected VT, but got Unknown
			//IL_589d: Expected Obj, but got I4
			//IL_82c0: Expected Obj, but got I
			//IL_0afb: Expected VT, but got I4
			//IL_0b0a: Expected I4, but got I8
			//IL_58c3: Expected Ref, but got VT
			//IL_58d8: Expected Obj, but got VT
			//IL_1370: Expected Obj, but got I
			//IL_139a: Expected Obj, but got I4
			//IL_7c6a: Expected Obj, but got I
			//IL_7c94: Expected Obj, but got I4
			//IL_04ea: Expected Obj, but got I
			//IL_0514: Expected Obj, but got I4
			//IL_02e1: Expected Obj, but got I
			//IL_030b: Expected Obj, but got I4
			//IL_0178: Expected Obj, but got I
			//IL_01a2: Expected Obj, but got I4
			//IL_2066: Expected Obj, but got Ref
			//IL_2740: Expected Obj, but got I
			//IL_276a: Expected Obj, but got I4
			//IL_0338: Expected Obj, but got I
			//IL_035b: Expected Obj, but got I4
			//IL_10c5: Expected Obj, but got I
			//IL_7952: Expected Obj, but got I
			//IL_7962: Expected Obj, but got I
			//IL_2090: Expected Obj, but got Ref
			//IL_2099: Expected Obj, but got I4
			//IL_20b3: Expected Obj, but got I
			//IL_20dd: Expected Obj, but got I4
			//IL_1ca7: Expected Obj, but got I
			//IL_1cd3: Expected Obj, but got I
			//IL_0b33: Expected Obj, but got I4
			//IL_00a8: Expected VT, but got I4
			//IL_00b7: Expected I4, but got I8
			//IL_2de7: Expected Obj, but got I4
			//IL_1407: Expected Obj, but got I4
			//IL_2124: Expected Obj, but got I4
			//IL_1d08: Expected Obj, but got I
			//IL_1d32: Expected Obj, but got I4
			//IL_0dee: Expected Obj, but got I
			//IL_0567: Expected Obj, but got I
			//IL_0591: Expected Obj, but got I4
			//IL_3201: Expected Obj, but got I4
			//IL_0386: Expected Obj, but got I
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Expected Obj, but got Unknown
			//IL_03b9: Expected Obj, but got I4
			//IL_1d68: Expected Obj, but got I
			//IL_1d73: Expected Obj, but got Ref
			//IL_0b51: Expected I, but got Obj
			//IL_0b61: Expected Obj, but got I
			//IL_0b92: Expected Obj, but got I
			//IL_1539: Expected Obj, but got I4
			//IL_27b8: Expected Obj, but got Ref
			//IL_27d8: Expected Obj, but got I4
			//IL_27e8: Expected Obj, but got I4
			//IL_7ad8: Expected Obj, but got I4
			//IL_2162: Expected Obj, but got I4
			//IL_1d9a: Expected Obj, but got I
			//IL_1dc4: Expected Obj, but got I4
			//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be3: Expected Obj, but got Unknown
			//IL_0c07: Expected Obj, but got I
			//IL_0c31: Expected Obj, but got I4
			//IL_2dfc: Expected Obj, but got I
			//IL_2e28: Expected Obj, but got I
			//IL_0658: Expected Obj, but got I
			//IL_7e1a: Expected Obj, but got I4
			//IL_82f5: Expected Obj, but got I
			//IL_8330: Expected Obj, but got I
			//IL_8340: Expected Obj, but got I
			//IL_11ca: Expected Obj, but got I
			//IL_11f4: Expected Obj, but got I4
			//IL_1e0b: Expected Obj, but got I4
			//IL_1e14: Expected VT, but got I4
			//IL_1e1d: Expected Obj, but got I4
			//IL_157f: Expected Obj, but got I4
			//IL_067c: Expected Obj, but got Ref
			//IL_05fe: Expected Obj, but got I4
			//IL_8373: Expected Obj, but got I
			//IL_1450: Expected Obj, but got I
			//IL_147a: Expected Obj, but got I4
			//IL_123b: Expected Obj, but got I4
			//IL_111b: Expected Obj, but got I
			//IL_1135: Expected Obj, but got I
			//IL_0cff: Expected Obj, but got I8
			//IL_7a4a: Expected Obj, but got Ref
			//IL_0f3e: Expected Obj, but got I4
			//IL_0e62: Expected Obj, but got Ref
			//IL_06c7: Expected Obj, but got I
			//IL_79b7: Expected Obj, but got I
			//IL_79d9: Expected Obj, but got I4
			//IL_7e52: Expected Obj, but got I4
			//IL_3350: Expected Obj, but got I4
			//IL_3360: Expected Obj, but got I4
			//IL_115b: Expected Obj, but got I
			//IL_1185: Expected Obj, but got I4
			//IL_224b: Expected Obj, but got I4
			//IL_1e48: Expected Obj, but got I
			//IL_1e72: Expected Obj, but got I4
			//IL_0c8e: Expected I, but got Obj
			//IL_0c9e: Expected Obj, but got I
			//IL_0ccf: Expected Obj, but got I
			//IL_0703: Expected Obj, but got I4
			//IL_0643: Expected Obj, but got I
			//IL_8393: Expected Obj, but got I
			//IL_83a3: Expected Obj, but got I
			//IL_83bc: Expected Obj, but got I
			//IL_83d0: Expected Obj, but got I
			//IL_83fa: Expected Obj, but got I4
			//IL_2828: Expected Obj, but got I
			//IL_2852: Expected Obj, but got I4
			//IL_1279: Expected Obj, but got I4
			//IL_21a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_21a9: Expected Obj, but got Unknown
			//IL_1e9f: Expected Obj, but got I
			//IL_1ed2: Expected VT, but got I4
			//IL_1edb: Expected Obj, but got I4
			//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d42: Expected Obj, but got Unknown
			//IL_1619: Expected Obj, but got Ref
			//IL_0f61: Expected Obj, but got I
			//IL_0f8b: Expected Obj, but got I4
			//IL_327e: Expected Obj, but got I
			//IL_337e: Expected Obj, but got I
			//IL_3391: Unknown result type (might be due to invalid IL or missing references)
			//IL_3396: Expected Obj, but got Unknown
			//IL_2885: Unknown result type (might be due to invalid IL or missing references)
			//IL_288a: Expected Obj, but got Unknown
			//IL_28a4: Expected Obj, but got I4
			//IL_14e1: Expected Obj, but got I
			//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f1: Expected Obj, but got Unknown
			//IL_2269: Expected Obj, but got I
			//IL_2279: Expected Obj, but got I
			//IL_22b1: Expected Obj, but got I
			//IL_22db: Expected Obj, but got I4
			//IL_15c4: Expected Obj, but got I
			//IL_15de: Expected Obj, but got I
			//IL_15f1: Expected I, but got Obj
			//IL_072e: Expected Obj, but got I4
			//IL_33bd: Expected Obj, but got I
			//IL_33e7: Expected Obj, but got I4
			//IL_7ce2: Expected Obj, but got I4
			//IL_232b: Expected Obj, but got I4
			//IL_317e: Expected Obj, but got I
			//IL_3189: Expected Obj, but got Ref
			//IL_21d5: Expected Obj, but got I4
			//IL_2f05: Expected Obj, but got I
			//IL_292c: Expected Obj, but got I4
			//IL_28cc: Expected Obj, but got I4
			//IL_28dc: Expected Obj, but got VT
			//IL_2370: Expected VT, but got I4
			//IL_1f37: Expected Obj, but got I4
			//IL_1f40: Expected VT, but got I4
			//IL_1f49: Expected Obj, but got I4
			//IL_2f1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f24: Expected Obj, but got Unknown
			//IL_2f46: Expected Obj, but got I
			//IL_075c: Expected Obj, but got I4
			//IL_12cd: Expected Obj, but got I
			//IL_12f7: Expected Obj, but got I4
			//IL_40b2: Expected Obj, but got I4
			//IL_31c0: Expected Obj, but got I4
			//IL_2f65: Expected Obj, but got I
			//IL_2f9a: Expected Obj, but got I4
			//IL_3548: Expected Obj, but got I4
			//IL_343a: Expected Obj, but got I
			//IL_3464: Expected Obj, but got I4
			//IL_2955: Unknown result type (might be due to invalid IL or missing references)
			//IL_295a: Expected Obj, but got Unknown
			//IL_132a: Expected Obj, but got I4
			//IL_23b5: Expected Obj, but got I4
			//IL_7da7: Expected Obj, but got I
			//IL_7de2: Expected Obj, but got I4
			//IL_32c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_32c9: Expected Obj, but got Unknown
			//IL_32dc: Expected Obj, but got I4
			//IL_32fe: Expected Obj, but got I4
			//IL_3318: Expected Obj, but got I4
			//IL_1f7a: Expected Obj, but got Ref
			//IL_1f82: Expected Obj, but got VT
			//IL_1fb6: Expected Obj, but got I4
			//IL_0ff4: Expected Obj, but got Ref
			//IL_0ffc: Expected Obj, but got VT
			//IL_1030: Expected Obj, but got I4
			//IL_16f4: Expected Obj, but got I
			//IL_2fc9: Expected Obj, but got I
			//IL_077a: Expected I, but got Obj
			//IL_078a: Expected Obj, but got I
			//IL_07c0: Expected Obj, but got I
			//IL_34cb: Expected Obj, but got I
			//IL_7e70: Expected Obj, but got I
			//IL_23e9: Expected Obj, but got I
			//IL_2405: Expected VT, but got I4
			//IL_1fe3: Expected Obj, but got I
			//IL_1ff6: Expected VT, but got Ref
			//IL_2004: Expected Ref, but got VT
			//IL_200d: Expected VT, but got I4
			//IL_2016: Expected Obj, but got I4
			//IL_201b: Expected Obj, but got Ref
			//IL_2023: Expected Obj, but got Ref
			//IL_202b: Expected Obj, but got VT
			//IL_105d: Expected Obj, but got I
			//IL_1070: Expected VT, but got Ref
			//IL_107e: Expected Ref, but got VT
			//IL_1083: Expected Obj, but got Ref
			//IL_108b: Expected Obj, but got Ref
			//IL_1093: Expected Obj, but got VT
			//IL_7af6: Expected Obj, but got I
			//IL_7b1e: Expected Obj, but got Ref
			//IL_7b36: Expected Obj, but got Ref
			//IL_16c4: Expected Obj, but got I
			//IL_7cfb: Expected Obj, but got Ref
			//IL_7d04: Expected Obj, but got I4
			//IL_7d1e: Expected Obj, but got I
			//IL_7d29: Expected Obj, but got Ref
			//IL_7d4e: Expected Obj, but got Ref
			//IL_0811: Unknown result type (might be due to invalid IL or missing references)
			//IL_0816: Expected Obj, but got Unknown
			//IL_0826: Expected Obj, but got I
			//IL_0840: Expected Obj, but got I
			//IL_086a: Expected Obj, but got I4
			//IL_357b: Expected Obj, but got I4
			//IL_4ddd: Unknown result type (might be due to invalid IL or missing references)
			//IL_4de2: Expected Obj, but got Unknown
			//IL_4e1f: Expected Obj, but got I4
			//IL_4e30: Expected Obj, but got I4
			//IL_40ee: Expected Obj, but got I4
			//IL_2a18: Expected Obj, but got I4
			//IL_1720: Expected Obj, but got I
			//IL_2fff: Expected Obj, but got I
			//IL_7e98: Unknown result type (might be due to invalid IL or missing references)
			//IL_7e9d: Expected Obj, but got Unknown
			//IL_243a: Expected VT, but got I4
			//IL_244f: Expected Obj, but got I
			//IL_591d: Expected Obj, but got I
			//IL_594c: Expected Obj, but got I4
			//IL_497e: Expected Obj, but got I4
			//IL_174c: Expected Obj, but got I
			//IL_1776: Expected Obj, but got I4
			//IL_093d: Expected Obj, but got I8
			//IL_7f5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_7f60: Expected Obj, but got Unknown
			//IL_7fae: Expected Obj, but got I
			//IL_7fb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_7fbe: Expected Obj, but got Unknown
			//IL_35b3: Expected Obj, but got I4
			//IL_4e4e: Expected Obj, but got I
			//IL_4e7e: Expected Obj, but got I4
			//IL_4f16: Expected Obj, but got I
			//IL_4c51: Expected Obj, but got I
			//IL_4c5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4c61: Expected Obj, but got Unknown
			//IL_2a36: Expected Obj, but got I
			//IL_2a62: Expected Obj, but got I4
			//IL_7b55: Expected Obj, but got I
			//IL_7b5d: Expected I4, but got Obj
			//IL_3049: Unknown result type (might be due to invalid IL or missing references)
			//IL_304e: Expected Obj, but got Unknown
			//IL_305e: Expected Obj, but got I
			//IL_3092: Expected Obj, but got I4
			//IL_08c7: Expected I, but got Obj
			//IL_08d7: Expected Obj, but got I
			//IL_0900: Expected Obj, but got I
			//IL_7ed8: Expected Obj, but got I
			//IL_7ee8: Expected Obj, but got I
			//IL_7ef8: Expected Obj, but got I
			//IL_7f1a: Expected Obj, but got I4
			//IL_7f23: Expected Obj, but got I4
			//IL_351e: Expected Obj, but got I4
			//IL_4eab: Expected Obj, but got I
			//IL_248e: Expected VT, but got I4
			//IL_4120: Expected Obj, but got Ref
			//IL_596a: Expected Obj, but got I
			//IL_72c3: Expected Obj, but got I4
			//IL_48bc: Expected Obj, but got I
			//IL_48e8: Expected Obj, but got I4
			//IL_4ca0: Unknown result type (might be due to invalid IL or missing references)
			//IL_4ca5: Expected Obj, but got Unknown
			//IL_4cc5: Expected Obj, but got I4
			//IL_49a1: Expected Obj, but got I
			//IL_49cb: Expected Obj, but got I4
			//IL_7229: Expected Obj, but got I4
			//IL_7bb5: Expected Obj, but got Ref
			//IL_7be9: Expected Obj, but got I4
			//IL_30c1: Expected Obj, but got I
			//IL_0970: Unknown result type (might be due to invalid IL or missing references)
			//IL_0975: Expected Obj, but got Unknown
			//IL_4149: Expected Obj, but got I
			//IL_5993: Expected Obj, but got I
			//IL_59ad: Expected Obj, but got I
			//IL_59d7: Expected Obj, but got I4
			//IL_4f63: Expected Obj, but got I
			//IL_4f7d: Expected Obj, but got I
			//IL_4fa7: Expected Obj, but got I4
			//IL_73f7: Expected Obj, but got I4
			//IL_81ee: Expected Obj, but got I
			//IL_81ac: Expected Obj, but got I
			//IL_2a80: Expected Obj, but got I
			//IL_2aac: Expected Obj, but got I4
			//IL_7c07: Expected Obj, but got I
			//IL_7c17: Expected Obj, but got I
			//IL_7c25: Expected Obj, but got Ref
			//IL_17bd: Expected Obj, but got I4
			//IL_8230: Expected Obj, but got Ref
			//IL_3a2e: Expected Obj, but got I
			//IL_3a58: Expected Obj, but got I4
			//IL_360c: Expected Obj, but got I4
			//IL_24b9: Expected Obj, but got I
			//IL_24e3: Expected Obj, but got I4
			//IL_4906: Expected Obj, but got I
			//IL_4932: Expected Obj, but got I4
			//IL_4ce3: Expected Obj, but got I
			//IL_4d0d: Expected Obj, but got I4
			//IL_7142: Expected Obj, but got I4
			//IL_7276: Expected Obj, but got I4
			//IL_7b8d: Expected Obj, but got I
			//IL_30f2: Expected Obj, but got I
			//IL_3128: Expected Obj, but got I4
			//IL_3a87: Expected Obj, but got I
			//IL_2510: Expected Obj, but got I
			//IL_2543: Expected VT, but got I4
			//IL_4195: Expected Obj, but got I
			//IL_5a20: Expected Obj, but got I
			//IL_7310: Expected Obj, but got I4
			//IL_4ff2: Expected Obj, but got I
			//IL_7444: Expected Obj, but got I4
			//IL_5194: Expected Obj, but got I
			//IL_4d44: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d49: Expected Obj, but got Unknown
			//IL_4a00: Expected Obj, but got I
			//IL_2aca: Expected Obj, but got I
			//IL_2af4: Expected Obj, but got I4
			//IL_1821: Expected Obj, but got I
			//IL_1839: Expected Obj, but got Ref
			//IL_17ed: Expected Obj, but got I
			//IL_17f5: Expected I4, but got Obj
			//IL_3b75: Expected Obj, but got I
			//IL_3b85: Expected Obj, but got I
			//IL_3651: Expected Obj, but got I
			//IL_41bb: Expected Obj, but got I
			//IL_41e5: Expected Obj, but got I4
			//IL_5a58: Expected Obj, but got I
			//IL_502a: Expected Obj, but got I
			//IL_4d78: Unknown result type (might be due to invalid IL or missing references)
			//IL_4d7d: Expected Obj, but got Unknown
			//IL_718f: Expected Obj, but got I4
			//IL_2b22: Expected Obj, but got I
			//IL_2b40: Expected Obj, but got I4
			//IL_1858: Expected Obj, but got I
			//IL_1870: Expected Obj, but got Ref
			//IL_0a03: Expected Obj, but got I4
			//IL_3c0c: Expected Obj, but got I4
			//IL_3ae2: Expected Obj, but got I
			//IL_3687: Expected Obj, but got I
			//IL_4213: Unknown result type (might be due to invalid IL or missing references)
			//IL_4218: Expected Obj, but got Unknown
			//IL_5a84: Expected Obj, but got I
			//IL_5aae: Expected Obj, but got I4
			//IL_51e0: Expected Obj, but got I
			//IL_520a: Expected Obj, but got I4
			//IL_5177: Expected Obj, but got I4
			//IL_4a42: Expected Obj, but got I
			//IL_4a52: Expected Obj, but got I
			//IL_3c43: Expected Obj, but got Ref
			//IL_70bf: Expected I4, but got Obj
			//IL_2597: Expected Obj, but got I4
			//IL_25a0: Expected VT, but got I4
			//IL_4298: Expected Obj, but got I
			//IL_42a9: Expected Obj, but got I4
			//IL_766f: Unknown result type (might be due to invalid IL or missing references)
			//IL_7674: Expected Obj, but got Unknown
			//IL_5adf: Unknown result type (might be due to invalid IL or missing references)
			//IL_5ae4: Expected Obj, but got Unknown
			//IL_735d: Expected Obj, but got I4
			//IL_506d: Expected Obj, but got I
			//IL_7491: Expected Obj, but got I4
			//IL_523f: Unknown result type (might be due to invalid IL or missing references)
			//IL_5244: Expected Obj, but got Unknown
			//IL_4dc5: Expected Obj, but got I
			//IL_4dcd: Expected Obj, but got I4
			//IL_71dc: Expected Obj, but got I4
			//IL_2b5e: Expected Obj, but got I
			//IL_2b8a: Expected Obj, but got I4
			//IL_0a44: Expected Obj, but got Ref
			//IL_0a4c: Expected Obj, but got VT
			//IL_0a80: Expected Obj, but got I4
			//IL_3b01: Expected Obj, but got I
			//IL_70f5: Expected Obj, but got I4
			//IL_42d5: Expected Obj, but got I
			//IL_5099: Expected Obj, but got I
			//IL_50c3: Expected Obj, but got I4
			//IL_5275: Expected Obj, but got I
			//IL_5282: Expected VT, but got Obj
			//IL_4aa4: Expected Obj, but got I
			//IL_4ab7: Unknown result type (might be due to invalid IL or missing references)
			//IL_4abc: Expected Obj, but got Unknown
			//IL_18d0: Expected VT, but got Ref
			//IL_18d0: Expected Obj, but got I
			//IL_0aad: Expected Obj, but got I
			//IL_0ac0: Expected VT, but got Ref
			//IL_0ace: Expected Ref, but got VT
			//IL_0adb: Expected Obj, but got Ref
			//IL_0ae3: Expected Obj, but got Ref
			//IL_0aeb: Expected Obj, but got VT
			//IL_25c9: Expected Obj, but got Ref
			//IL_25d1: Expected Obj, but got VT
			//IL_2605: Expected Obj, but got I4
			//IL_8031: Unknown result type (might be due to invalid IL or missing references)
			//IL_8036: Expected Obj, but got Unknown
			//IL_8058: Expected Obj, but got I
			//IL_769a: Expected Obj, but got I4
			//IL_76a2: Expected Obj, but got Ref
			//IL_76c0: Expected I4, but got I8
			//IL_76cb: Expected Obj, but got Ref
			//IL_76d4: Expected Obj, but got I4
			//IL_52a1: Expected Obj, but got I
			//IL_52ae: Expected VT, but got Obj
			//IL_2ba8: Expected Obj, but got I
			//IL_2bd4: Expected Obj, but got I4
			//IL_18e4: Expected Obj, but got Ref
			//IL_1906: Expected Obj, but got I
			//IL_3c9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ca4: Expected Obj, but got Unknown
			//IL_3cc6: Expected Obj, but got I
			//IL_36ff: Expected Obj, but got I
			//IL_3712: Unknown result type (might be due to invalid IL or missing references)
			//IL_3717: Expected Obj, but got Unknown
			//IL_2632: Expected Obj, but got I
			//IL_2645: Expected VT, but got Ref
			//IL_2653: Expected Ref, but got VT
			//IL_265c: Expected VT, but got I4
			//IL_2661: Expected Obj, but got Ref
			//IL_2669: Expected Obj, but got Ref
			//IL_2671: Expected Obj, but got VT
			//IL_4307: Expected Obj, but got I
			//IL_4331: Expected Obj, but got I4
			//IL_7874: Expected Obj, but got I4
			//IL_76ee: Expected Obj, but got Ref
			//IL_76f7: Expected Obj, but got I4
			//IL_770c: Expected Obj, but got Ref
			//IL_7715: Expected Obj, but got I4
			//IL_5b5e: Expected Obj, but got I4
			//IL_73aa: Expected Obj, but got I4
			//IL_5108: Unknown result type (might be due to invalid IL or missing references)
			//IL_510d: Expected Obj, but got Unknown
			//IL_512f: Expected Obj, but got I
			//IL_515e: Expected Obj, but got I
			//IL_74de: Expected Obj, but got I4
			//IL_52ea: Expected Obj, but got I
			//IL_4ae9: Expected Obj, but got I
			//IL_1937: Expected Obj, but got I4
			//IL_42ea: Expected Obj, but got I
			//IL_47e5: Expected Obj, but got I
			//IL_47fa: Expected Obj, but got I
			//IL_772f: Expected Obj, but got Ref
			//IL_7738: Expected Obj, but got I4
			//IL_774d: Expected Obj, but got Ref
			//IL_7756: Expected Obj, but got I4
			//IL_2bf2: Expected Obj, but got I
			//IL_2c02: Expected Obj, but got I
			//IL_2c23: Expected Obj, but got I
			//IL_2c37: Expected Obj, but got I
			//IL_2c61: Expected Obj, but got I4
			//IL_374c: Expected Obj, but got I
			//IL_375c: Expected Obj, but got I
			//IL_3781: Expected Obj, but got I
			//IL_37ab: Expected Obj, but got I4
			//IL_8080: Unknown result type (might be due to invalid IL or missing references)
			//IL_8085: Expected Obj, but got Unknown
			//IL_8140: Expected Obj, but got I
			//IL_7770: Expected Obj, but got Ref
			//IL_7779: Expected Obj, but got I4
			//IL_778e: Expected Obj, but got Ref
			//IL_7797: Expected Obj, but got I4
			//IL_5309: Expected Obj, but got I
			//IL_531d: Expected Obj, but got I
			//IL_4b26: Expected Obj, but got I
			//IL_2c97: Expected Obj, but got I
			//IL_1965: Expected Obj, but got I4
			//IL_37fb: Expected Obj, but got I4
			//IL_43a1: Expected Obj, but got Ref
			//IL_43b5: Expected Obj, but got I
			//IL_4823: Expected Obj, but got I
			//IL_484d: Expected Obj, but got I4
			//IL_77af: Unknown result type (might be due to invalid IL or missing references)
			//IL_77b4: Expected VT, but got Unknown
			//IL_77e0: Expected Obj, but got I4
			//IL_752b: Expected Obj, but got I4
			//IL_535e: Expected Obj, but got VT
			//IL_5366: Expected Obj, but got Ref
			//IL_3d2d: Expected Obj, but got I
			//IL_3d3d: Expected Obj, but got I
			//IL_3d61: Expected Obj, but got Ref
			//IL_382d: Expected Obj, but got I
			//IL_3857: Expected Obj, but got I4
			//IL_437c: Expected Obj, but got I
			//IL_817c: Expected Obj, but got I
			//IL_8192: Expected Obj, but got I
			//IL_780a: Expected Ref, but got VT
			//IL_781f: Expected Obj, but got VT
			//IL_4b63: Expected Obj, but got I
			//IL_4b73: Expected Obj, but got I
			//IL_4b8c: Expected Obj, but got I
			//IL_4ba0: Expected Obj, but got I
			//IL_4bca: Expected Obj, but got I4
			//IL_2ce2: Expected Obj, but got I
			//IL_1983: Expected I, but got Obj
			//IL_1993: Expected Obj, but got I
			//IL_19ce: Expected Obj, but got I
			//IL_3d8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d93: Expected Obj, but got Unknown
			//IL_3886: Expected Obj, but got I
			//IL_80bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_80c4: Expected Obj, but got Unknown
			//IL_8100: Expected Obj, but got I4
			//IL_53a7: Expected Obj, but got VT
			//IL_53a7: Expected VT, but got Ref
			//IL_53a7: Expected VT, but got I4
			//IL_53a7: Expected Obj, but got I
			//IL_53a7: Expected Obj, but got I
			//IL_53bb: Expected Obj, but got I
			//IL_53db: Expected Obj, but got I4
			//IL_53ec: Expected Obj, but got VT
			//IL_53f4: Expected VT, but got Ref
			//IL_53fc: Expected F4, but got VT
			//IL_5409: Expected Obj, but got VT
			//IL_5419: Expected Obj, but got I
			//IL_5429: Expected Obj, but got I
			//IL_4c00: Expected Obj, but got I
			//IL_7578: Expected Obj, but got I4
			//IL_1a1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a21: Expected Obj, but got Unknown
			//IL_1a43: Expected Obj, but got I
			//IL_1a6d: Expected Obj, but got I4
			//IL_3e65: Expected Obj, but got I
			//IL_3e8f: Expected Obj, but got I4
			//IL_3946: Expected Obj, but got I
			//IL_4451: Expected Obj, but got I
			//IL_4471: Expected Obj, but got I4
			//IL_4479: Unknown result type (might be due to invalid IL or missing references)
			//IL_447e: Expected Obj, but got Unknown
			//IL_4487: Unknown result type (might be due to invalid IL or missing references)
			//IL_448c: Expected Obj, but got Unknown
			//IL_2d2d: Expected Obj, but got I
			//IL_2d57: Expected Obj, but got I4
			//IL_3ebe: Expected Obj, but got I
			//IL_38e1: Expected Obj, but got I
			//IL_4518: Expected Obj, but got I
			//IL_4542: Expected Obj, but got I4
			//IL_5461: Expected Obj, but got I4
			//IL_5472: Expected Obj, but got VT
			//IL_547a: Expected VT, but got Ref
			//IL_5482: Expected F4, but got VT
			//IL_548f: Expected Obj, but got VT
			//IL_549f: Expected Obj, but got I
			//IL_54af: Expected Obj, but got I
			//IL_2d8a: Expected Obj, but got I
			//IL_2d9a: Expected Obj, but got I
			//IL_1b3e: Expected Obj, but got I8
			//IL_75c5: Expected Obj, but got I4
			//IL_4576: Expected Obj, but got I4
			//IL_4590: Expected Obj, but got I4
			//IL_45a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_45a6: Expected Obj, but got Unknown
			//IL_45af: Unknown result type (might be due to invalid IL or missing references)
			//IL_45b4: Expected Obj, but got Unknown
			//IL_44df: Expected Obj, but got I
			//IL_2dd0: Expected F4, but got I4
			//IL_1acb: Expected I, but got Obj
			//IL_1adb: Expected Obj, but got I
			//IL_1b16: Expected Obj, but got I
			//IL_3f23: Expected Obj, but got I4
			//IL_3e17: Expected Obj, but got I
			//IL_3e27: Expected Obj, but got I
			//IL_3900: Expected Obj, but got I
			//IL_391e: Expected Obj, but got I4
			//IL_54ce: Expected Obj, but got I
			//IL_54e2: Expected Obj, but got I
			//IL_550c: Expected Obj, but got I4
			//IL_1b76: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b7b: Expected Obj, but got Unknown
			//IL_3f50: Expected Obj, but got I
			//IL_3f65: Expected Obj, but got I
			//IL_3f85: Expected I4, but got Obj
			//IL_75e4: Expected Obj, but got I4
			//IL_479b: Expected Obj, but got I
			//IL_47a6: Expected Obj, but got I4
			//IL_45f1: Expected Obj, but got Ref
			//IL_4605: Expected Obj, but got I
			//IL_4615: Expected Obj, but got I
			//IL_44fe: Expected Obj, but got I
			//IL_5546: Expected Obj, but got I
			//IL_46ec: Expected Obj, but got I4
			//IL_4647: Expected Obj, but got I
			//IL_4671: Expected Obj, but got I4
			//IL_5565: Expected Obj, but got I
			//IL_5587: Expected Obj, but got I
			//IL_559b: Expected Obj, but got I
			//IL_55bb: Expected Obj, but got I4
			//IL_55cc: Expected Obj, but got VT
			//IL_55d5: Expected VT, but got I4
			//IL_55dd: Expected F4, but got VT
			//IL_5602: Expected Obj, but got I
			//IL_4721: Unknown result type (might be due to invalid IL or missing references)
			//IL_4726: Expected Obj, but got Unknown
			//IL_3fd4: Expected Obj, but got I4
			//IL_474d: Expected Obj, but got I
			//IL_4777: Expected Obj, but got I
			//IL_5639: Expected Obj, but got I4
			//IL_564a: Expected Obj, but got VT
			//IL_5653: Expected VT, but got I4
			//IL_565b: Expected F4, but got VT
			//IL_5680: Expected Obj, but got I
			//IL_268c: Expected Obj, but got Ref
			//IL_2694: Expected Obj, but got VT
			//IL_26c8: Expected Obj, but got I4
			//IL_4005: Expected Obj, but got Ref
			//IL_400d: Expected Obj, but got VT
			//IL_4041: Expected Obj, but got I4
			//IL_56b1: Expected Obj, but got I
			//IL_26f5: Expected Obj, but got I
			//IL_2708: Expected VT, but got Ref
			//IL_2716: Expected Ref, but got VT
			//IL_271b: Expected Obj, but got Ref
			//IL_2723: Expected Obj, but got Ref
			//IL_272b: Expected Obj, but got VT
			//IL_406e: Expected Obj, but got I
			//IL_4081: Expected VT, but got Ref
			//IL_408f: Expected Ref, but got VT
			//IL_4094: Expected Obj, but got Ref
			//IL_409c: Expected Obj, but got Ref
			//IL_40a4: Expected Obj, but got VT
			//IL_56e8: Expected Obj, but got I
			//IL_5712: Expected Obj, but got I4
			//IL_5741: Expected Obj, but got I4
			//IL_5752: Expected Obj, but got VT
			//IL_575b: Expected VT, but got I4
			//IL_5763: Expected F4, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			int num = _003C_003E1__state;
			UnityEngine.Object obj2 = _003C_003E4__this;
			object obj5;
			GameObject gameObject;
			TaskAwaiter awaiter = default;
			AuthenticationValues authenticationValues;
			TaskAwaiter<System.__Canon> taskAwaiter;
			string text3;
			string text = default;
			string text2;
			Exception ex;
			if (_003C_003E1__state > 1)
			{
				object obj3 = num - 2;
				bool flag = (nint)obj3 < 3;
				object obj4 = !flag;
				if (obj4 == null)
				{
					obj5 = text;
					text2 = (string)472;
					ex = null;
					authenticationValues = null;
					gameObject = null;
					goto IL_7d7a;
				}
				if (num == 5)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					text2 = (string)472;
					awaiter = _003C_003Eu__1;
					goto IL_7ca2;
				}
			}
			else
			{
				if (_003C_003E1__state == 0)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					obj5 = text;
					text3 = (string)472;
					awaiter = _003C_003Eu__1;
					num = -1;
					goto IL_7fd5;
				}
				if (num == 1)
				{
					_003C_003Eu__2 = (TaskAwaiter<Task>)0;
					_003C_003E1__state = -1;
					text2 = (string)472;
					taskAwaiter = (TaskAwaiter<System.__Canon>)_003C_003Eu__2;
					num = -1;
					goto IL_79e7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE460]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj7 = default;
			obj7._002Ector();
			object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v868+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5883 @ X0_v872+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5883 @ X0_v872+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5885 @ X8_v590+11]");
			UnityEngine.Object obj19;
			object obj40;
			object obj41;
			object obj47;
			string text8;
			object obj53;
			object obj66;
			Lobby lobby3;
			string text12;
			float num3 = default;
			System.__Canon _Canon = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6010 @ X0_v1094+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE498]");
				object obj18 = 0;
				Debug.LogWarning(obj18);
				bool flag5 = (object)_003C_003E4__this == null;
				text2 = (string)472;
				obj19 = null;
				_Canon = (System.__Canon)obj18;
				if (flag5)
				{
					goto IL_6109;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0D8]");
				object obj20 = 0;
				object obj21 = _003C_003E4__this + 120;
				obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj5 = text;
				text2 = (string)472;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
				object obj22 = 0;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6015 @ X0_v873+E4]");
				bool flag6 = (nint)0 == 0;
				object obj24 = !flag6;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (GillaModeration.Kicked)
				{
					object obj25 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6422 @ X0_v1070+E4]");
					bool flag7 = (nint)0 == 0;
					object obj26 = !flag7;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj27 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6747 @ X0_v1074+E4]");
					bool flag8 = (nint)0 == 0;
					object obj28 = !flag8;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj27 = obj22;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6747 @ X0_v1074+A0]");
					object obj29 = 0;
					long serverNowMs = GillaModeration.ServerNowMs;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6749 @ X8_v698+30]");
					long ms = -serverNowMs;
					string text4 = GillaModeration.Left(ms);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE488]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4D8]");
					object obj31 = 0;
					text2 = (string)obj31;
					string text5 = (string)obj30 + text4 + (string)obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj32 = 0;
					object obj33 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7013 @ X0_v1081+E4]");
					bool flag9 = (nint)0 == 0;
					object obj34 = !flag9;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(text5);
					bool flag10 = (object)_003C_003E4__this == null;
					text = null;
					ex = null;
					_Canon = (System.__Canon)(object)text5;
					if (flag10)
					{
						goto IL_65d7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFA0]");
					object obj35 = 0;
					object obj36 = _003C_003E4__this + 120;
					obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj5 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj37 = 0;
					object obj38 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6427 @ X0_v877+E4]");
					bool flag11 = (nint)0 == 0;
					object obj39 = !flag11;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool cleared = GillaIntegrity.Cleared;
					if (cleared)
					{
						obj40 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
						string text6 = (string)obj40;
						bool flag12 = obj40 == null;
						text2 = (string)472;
						obj41 = obj7;
						_Canon = (System.__Canon)cleared;
						if (flag12)
						{
							goto IL_6921;
						}
						if (text6._stringLength != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
							object obj42 = 0;
							object obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6940 @ X0_v1056+E4]");
							bool flag13 = (nint)0 == 0;
							object obj44 = !flag13;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Lobby? lobby = CarriedKind((string)obj40);
							object obj45 = (_003F?)lobby & 0xFF;
							bool flag14 = obj45 == null;
							object obj46 = !flag14;
							if (obj46 == null)
							{
								bool flag15 = (object)_003C_003E4__this == null;
								text2 = (string)472;
								obj47 = obj7;
								_Canon = (System.__Canon)lobby;
								if (flag15)
								{
									goto IL_6f43;
								}
								_ = kind;
							}
							object obj48 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7241 @ X0_v1060+E4]");
							bool flag16 = (nint)0 == 0;
							object obj49 = !flag16;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text7 = Shown((string)obj40);
							bool flag17 = (object)_003C_003E4__this == null;
							text2 = (string)472;
							text8 = text7;
							_Canon = (System.__Canon)(object)text7;
							if (flag17)
							{
								goto IL_6a0e;
							}
							object obj50 = _003C_003E4__this + 216;
							obj50 = text7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj47 = text7;
						}
						else
						{
							bool flag18 = (object)_003C_003E4__this == null;
							text2 = (string)472;
							obj47 = obj7;
							_Canon = (System.__Canon)cleared;
							if (flag18)
							{
								goto IL_6b4a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj51 = 0;
							obj47 = obj51;
							object obj52 = _003C_003E4__this + 216;
							obj52 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
						obj53 = 0;
						object obj54 = obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7245 @ X0_v910+E4]");
						bool flag19 = (nint)0 == 0;
						object obj55 = !flag19;
						if (obj55 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (ShiftAuthNeeded)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj56 = 0;
							object obj57 = obj56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7517 @ X0_v1038+E4]");
							bool flag20 = (nint)0 == 0;
							object obj58 = !flag20;
							if (obj58 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj57 = obj56;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7517 @ X0_v1038+A0]");
							object obj59 = 0;
							if (obj59 == null)
							{
								object obj60 = _003C_003E4__this + 208;
								obj60 = code;
								_ = kind;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+CC]");
								bool flag21 = (nint)0 == 0;
								object obj61 = !flag21;
								obj5 = text;
								text2 = (string)472;
								if (obj61 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj62 = 0;
									_ = 1;
									object obj63 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8095 @ X0_v1042+E4]");
									bool flag22 = (nint)0 == 0;
									object obj64 = !flag22;
									if (obj64 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE490]");
									object message = 0;
									Debug.Log(message);
									IEnumerator routine = _003C_003E4__this.JoinAfterAuth();
									Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
									obj5 = text;
									text2 = null;
								}
								goto IL_5775;
							}
						}
						string text9 = (string)obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+A4]");
						if ((nint)0 != 0)
						{
							object obj65 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B8]");
							if ((string)obj65 == (string)0)
							{
								Lobby lobby2 = kind;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+90]");
								if ((nint)lobby2 == 0)
								{
									obj66 = 0;
									goto IL_7e8d;
								}
							}
							obj66 = obj40;
							goto IL_7e8d;
						}
						bool flag23 = obj40 == null;
						text2 = (string)472;
						_Canon = (System.__Canon)obj40;
						if (flag23)
						{
							goto IL_6b97;
						}
						bool flag24 = text9._stringLength < 1;
						text2 = (string)472;
						if (!flag24)
						{
							object obj67 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8103 @ X0_v986+E4]");
							bool flag25 = (nint)0 == 0;
							object obj68 = !flag25;
							if (obj68 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj67 = obj22;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8103 @ X0_v986+A0]");
							object obj69 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
							object obj70 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7650 @ X8_v655+58]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							bool flag26 = _Canon == null;
							text2 = (string)472;
							obj47 = 6;
							if (flag26)
							{
								goto IL_6f90;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							object obj72 = obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8563 @ X0_v992+E4]");
							bool flag27 = (nint)0 == 0;
							object obj73 = !flag27;
							if (obj73 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string roomTag = RoomTag;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF78]");
							object obj74 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							int num2 = default;
							string text10 = num2.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
							object obj75 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							text2 = (string)obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
							string text11 = string.Concat((string[])(object)_Canon);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7650 @ X8_v655+58]");
							bool flag28 = (nint)0 == 0;
							obj47 = text11;
							_Canon = (System.__Canon)(object)text11;
							if (flag28)
							{
								goto IL_6fdd;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7633 @ X27_v114+28]");
							text2 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7633 @ X27_v114+18] (should have been resolved before IL gen)");
							object obj76 = text9 & 1;
							bool flag29 = obj76 == null;
							obj47 = text11;
							if (!flag29)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4C8]");
								object obj77 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE538]");
								object obj78 = 0;
								string message2 = (string)obj77 + (string)obj40 + (string)obj78;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
								object obj79 = 0;
								object obj80 = obj79;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9210 @ X0_v1012+E4]");
								bool flag30 = (nint)0 == 0;
								object obj81 = !flag30;
								if (obj81 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Debug.LogWarning(message2);
								object obj82 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9263 @ X0_v1015+E4]");
								bool flag31 = (nint)0 == 0;
								object obj83 = !flag31;
								if (obj83 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaModeration.SayKeptOut();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj84 = 0;
								object obj85 = obj84;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9308 @ X0_v1018+E4]");
								bool flag32 = (nint)0 == 0;
								object obj86 = !flag32;
								if (obj86 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								if ((UnityEngine.Object)0 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									bool flag33 = (nint)0 == 0;
									text = null;
									text2 = null;
									lobby3 = (Lobby)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									_Canon = (System.__Canon)0;
									if (flag33)
									{
										goto IL_759c;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									bool isRunning = ((NetworkRunner)0).IsRunning;
									bool flag34 = !isRunning;
									object obj87 = !flag34;
									obj5 = null;
									text2 = null;
									if (obj87 != null)
									{
										goto IL_5775;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								object obj88 = 0;
								obj47 = obj88;
								obj40 = obj88;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								text = null;
								text2 = null;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+F4]");
						bool flag35 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+F4]");
						if ((int)(~(nint)0) == 0)
						{
							object obj89 = obj40;
							bool flag36 = obj40 == null;
							_Canon = (System.__Canon)(object)text9;
							if (flag36)
							{
								goto IL_702a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8107 @ X8_v651+10]");
							bool flag37 = (nint)0 == 0;
							flag35 = flag37;
						}
						_003CownRoom_003E5__2 = flag35;
						_ = 0;
						_ = 1;
						num3 = Time.unscaledTime;
						object obj90 = _003C_003E4__this + 184;
						obj90 = code;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8245 @ X0_v917+70]");
						int num4 = (int)((nint)0 + (nint)1);
						_003Cmine_003E5__3 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj91 = 0;
						object obj92 = _003C_003E4__this + 136;
						obj92 = obj91;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						Lobby lobby4 = kind;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+90]");
						if ((nint)lobby4 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj93 = 0;
							object obj94 = obj93;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8567 @ X0_v974+E4]");
							bool flag38 = (nint)0 == 0;
							object obj95 = !flag38;
							if (obj95 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
							bool flag39 = (UnityEngine.Object)0 != null;
							bool flag40 = !flag39;
							text2 = null;
							if (!flag40)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								bool flag41 = (nint)0 == 0;
								text2 = null;
								lobby3 = (Lobby)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								_Canon = (System.__Canon)0;
								if (flag41)
								{
									goto IL_72e7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								bool isRunning2 = ((NetworkRunner)0).IsRunning;
								bool flag42 = !isRunning2;
								text2 = null;
								if (!flag42)
								{
									bool isPublicRoom = _003C_003E4__this.IsPublicRoom;
									bool flag43 = !isPublicRoom;
									text2 = null;
									if (flag43)
									{
										string roomCode = _003C_003E4__this.RoomCode;
										text2 = null;
										text12 = roomCode;
										goto IL_8225;
									}
								}
							}
						}
						text12 = (string)obj91;
						goto IL_8225;
					}
					object obj96 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6756 @ X0_v881+E4]");
					bool flag44 = (nint)0 == 0;
					object obj97 = !flag44;
					if (obj97 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj98 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7057 @ X0_v885+E4]");
					bool flag45 = (nint)0 == 0;
					object obj99 = !flag45;
					if (obj99 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj98 = obj37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE468]");
					object obj100 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj101 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7398 @ X0_v890+E4]");
					bool flag46 = (nint)0 == 0;
					object obj102 = !flag46;
					if (obj102 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj101 = obj37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7398 @ X0_v890+A0]");
					object obj103 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE500]");
					object format = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7401 @ X8_v603+28]");
					object arg = default;
					string message3 = string.Format((string)format, arg, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj104 = 0;
					object obj105 = obj104;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7543 @ X0_v893+E4]");
					bool flag47 = (nint)0 == 0;
					object obj106 = !flag47;
					if (obj106 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message3);
					obj5 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7401 @ X8_v603+28]");
					text2 = (string)0;
				}
			}
			goto IL_5775;
			IL_04da:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj107 = 0;
			object obj108 = obj107;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6122 @ X0_v810+E4]");
			bool flag48 = (nint)0 == 0;
			object obj109 = !flag48;
			if (obj109 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool shiftAuthNeeded = ShiftAuthNeeded;
			float num5;
			object obj122;
			System.__Canon _Canon2;
			System.__Canon _Canon3;
			object obj130;
			if (shiftAuthNeeded)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				object obj110 = 0;
				object obj111 = obj110;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6439 @ X0_v813+E4]");
				bool flag49 = (nint)0 == 0;
				object obj112 = !flag49;
				if (obj112 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (ShiftAuth.HasDevKey)
				{
					object obj113 = obj110;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6780 @ X0_v855+E4]");
					bool flag50 = (nint)0 == 0;
					object obj114 = !flag50;
					if (obj114 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj113 = obj110;
					}
					object obj115 = obj107;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6780 @ X0_v855+A0]");
					object obj116 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6696 @ X8_v582+E4]");
					bool flag51 = (nint)0 == 0;
					object obj117 = !flag51;
					if (obj117 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6688 @ X9_v258+8]");
					SetPlayerId((string)0);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE430]");
				object obj118 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				TaskCompletionSource<System.__Canon> taskCompletionSource = default;
				taskCompletionSource._002Ector();
				object obj119 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 152));
				obj119 = taskCompletionSource;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				NetworkBootstrap networkBootstrap = default;
				IEnumerator routine2 = networkBootstrap.FetchTicket((TaskCompletionSource<string>)obj119);
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine(routine2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE438]");
				object obj120 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj121 = obj119;
				bool flag52 = obj119 == null;
				num3 = num5;
				text2 = null;
				ex = (Exception)2;
				if (flag52)
				{
					goto IL_661c;
				}
				bool flag53 = _Canon == null;
				text2 = null;
				obj122 = 2;
				if (flag53)
				{
					goto IL_6671;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6732 @ X8_v563+10]");
				bool flag54 = (nint)0 == 0;
				obj122 = 2;
				NullReferenceException ex2 = (NullReferenceException)(object)_Canon;
				if (!flag54)
				{
					nint num6 = (nint)_Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7055 @ X8_v580 (Il2CppClass<System.__Canon>)+40]");
					obj122 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag55 = ex2 == null;
					num3 = num5;
					text2 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7055 @ X8_v580 (Il2CppClass<System.__Canon>)+40]");
					obj41 = 0;
					NullReferenceException ex3 = ex2;
					if (flag55)
					{
						goto IL_6966;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5444 @ X0_v620 (System.__Canon)+18]");
				bool flag56 = (nint)0 == 0;
				text2 = null;
				_Canon2 = (System.__Canon)(object)ex2;
				if (flag56)
				{
					goto IL_66c6;
				}
				object obj123 = _Canon + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6732 @ X8_v563+10]");
				obj123 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
				object obj124 = 0;
				object obj125 = obj124;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7951 @ X0_v829+E4]");
				bool flag57 = (nint)0 == 0;
				object obj126 = !flag57;
				if (obj126 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Task task = Task.Delay(40000);
				bool flag58 = task == null;
				obj122 = null;
				ArgumentNullException ex4 = (ArgumentNullException)(object)task;
				if (!flag58)
				{
					nint num7 = (nint)_Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7396 @ X8_v579 (Il2CppClass<System.__Canon>)+40]");
					ex = (Exception)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag59 = ex4 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7396 @ X8_v579 (Il2CppClass<System.__Canon>)+40]");
					obj122 = 0;
					num3 = num5;
					text2 = null;
					ArgumentNullException ex5 = ex4;
					if (flag59)
					{
						goto IL_69ba;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5444 @ X0_v620 (System.__Canon)+18]");
				object obj127 = 0 & 0xFFFFFFFEL;
				bool flag60 = obj127 == null;
				text2 = null;
				_Canon3 = (System.__Canon)(object)ex4;
				if (flag60)
				{
					goto IL_6723;
				}
				object obj128 = _Canon + 40;
				obj128 = task;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Task<Task> task2 = Task.WhenAny((Task[])(object)_Canon);
				bool flag61 = task2 == null;
				text2 = null;
				obj122 = null;
				_Canon = (System.__Canon)(object)task2;
				if (flag61)
				{
					goto IL_6780;
				}
				TaskAwaiter<System.__Canon> awaiter2 = ((Task<System.__Canon>)(object)task2).GetAwaiter();
				TaskAwaiter<System.__Canon> awaiter3 = default;
				bool isCompleted = awaiter3.IsCompleted;
				bool flag62 = !isCompleted;
				object obj129 = !flag62;
				obj = obj130;
				num3 = num5;
				text2 = null;
				taskAwaiter = awaiter3;
				if (obj129 == null)
				{
					_003C_003E1__state = 1;
					object obj131 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 160));
					obj131 = awaiter3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj132 = obj130;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9041 @ X0_v845+E4]");
					bool flag63 = (nint)0 == 0;
					object obj133 = !flag63;
					if (obj133 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3A0]");
					object obj134 = 0;
					text = (string)obj134;
					AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, _003CJoinCore_003Ed__185>(ref awaiter3, ref this);
					num3 = num5;
					text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
					ex = (Exception)(&awaiter3);
					_Canon = (System.__Canon)asyncTaskMethodBuilder;
					goto IL_58dd;
				}
				goto IL_79e7;
			}
			authenticationValues = null;
			_Canon = (System.__Canon)shiftAuthNeeded;
			goto IL_7a6d;
			IL_73ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag64 = num8 != 0;
			ex = (Exception)lobby3;
			if (!flag64)
			{
				NullReferenceException ex6 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex6;
				goto IL_741b;
			}
			goto IL_78d8;
			IL_724d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag65 = num9 != 0;
			ex = (Exception)lobby3;
			if (!flag65)
			{
				NullReferenceException ex7 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex7;
				goto IL_729a;
			}
			goto IL_78d8;
			IL_62dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag66 = num10 != 0;
			UnityEngine.Object obj135;
			ex = (Exception)(object)obj135;
			if (!flag66)
			{
				NullReferenceException ex8 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex8;
				goto IL_632a;
			}
			goto IL_78d8;
			IL_68d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag67 = num11 != 0;
			ex = (Exception)obj41;
			if (!flag67)
			{
				NullReferenceException ex9 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex9;
				goto IL_6921;
			}
			goto IL_78d8;
			IL_6f90:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag68 = num12 != 0;
			ex = (Exception)obj47;
			if (!flag68)
			{
				NullReferenceException ex10 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex10;
				goto IL_6fdd;
			}
			goto IL_78d8;
			IL_6243:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag69 = num13 != 0;
			ex = (Exception)(object)obj135;
			if (!flag69)
			{
				NullReferenceException ex11 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex11;
				goto IL_6290;
			}
			goto IL_78d8;
			IL_74b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag70 = num14 != 0;
			ex = (Exception)lobby3;
			if (!flag70)
			{
				NullReferenceException ex12 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex12;
				goto IL_7502;
			}
			goto IL_78d8;
			IL_7334:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag71 = num15 != 0;
			ex = (Exception)lobby3;
			if (!flag71)
			{
				NullReferenceException ex13 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex13;
				goto IL_7381;
			}
			goto IL_78d8;
			IL_63cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag72 = num16 != 0;
			string text13;
			ex = (Exception)(object)text13;
			if (!flag72)
			{
				NullReferenceException ex14 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex14;
				goto IL_6419;
			}
			goto IL_78d8;
			IL_637f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num17 == 0)
			{
				NullReferenceException ex15 = new NullReferenceException();
				text13 = (string)(object)ex;
				_Canon = (System.__Canon)(object)ex15;
				goto IL_63cc;
			}
			goto IL_78d8;
			IL_632a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag73 = num18 != 0;
			ex = (Exception)(object)obj135;
			if (!flag73)
			{
				NullReferenceException ex16 = new NullReferenceException();
				ex = (Exception)(object)obj135;
				_Canon = (System.__Canon)(object)ex16;
				goto IL_637f;
			}
			goto IL_78d8;
			IL_72e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag74 = num19 != 0;
			ex = (Exception)lobby3;
			if (!flag74)
			{
				NullReferenceException ex17 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex17;
				goto IL_7334;
			}
			goto IL_78d8;
			IL_6419:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag75 = num20 != 0;
			ex = (Exception)(object)text13;
			if (!flag75)
			{
				NullReferenceException ex18 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex18;
				goto IL_6466;
			}
			goto IL_78d8;
			IL_6671:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag76 = num21 != 0;
			num3 = num5;
			ex = (Exception)obj122;
			if (!flag76)
			{
				NullReferenceException ex19 = new NullReferenceException();
				_Canon2 = (System.__Canon)(object)ex19;
				goto IL_66c6;
			}
			goto IL_78d8;
			IL_71b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag77 = num22 != 0;
			ex = (Exception)lobby3;
			if (!flag77)
			{
				NullReferenceException ex20 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex20;
				goto IL_7200;
			}
			goto IL_78d8;
			IL_65d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num23 == 0)
			{
				NullReferenceException ex21 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex21;
				goto IL_661c;
			}
			goto IL_78d8;
			IL_6d18:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag78 = num24 != 0;
			ex = (Exception)obj47;
			if (!flag78)
			{
				NullReferenceException ex22 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex22;
				goto IL_6d65;
			}
			goto IL_78d8;
			IL_6109:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag79 = num25 != 0;
			ex = (Exception)(object)obj19;
			if (!flag79)
			{
				NullReferenceException ex23 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex23;
				goto IL_6156;
			}
			goto IL_78d8;
			IL_6ea1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag80 = num26 != 0;
			ex = (Exception)(object)text12;
			if (!flag80)
			{
				NullReferenceException ex24 = new NullReferenceException();
				obj47 = text12;
				_Canon = (System.__Canon)(object)ex24;
				goto IL_6ef6;
			}
			goto IL_78d8;
			IL_60b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num27 == 0)
			{
				ArgumentNullException ex25 = new ArgumentNullException();
				obj19 = null;
				_Canon = (System.__Canon)(object)ex25;
				goto IL_6109;
			}
			goto IL_78d8;
			IL_67e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			UnityEngine.Object obj136;
			if (num28 == 0)
			{
				NullReferenceException ex26 = new NullReferenceException();
				obj136 = (UnityEngine.Object)(object)ex;
				_Canon = (System.__Canon)(object)ex26;
				goto IL_6832;
			}
			goto IL_78d8;
			IL_6ef6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag81 = num29 != 0;
			ex = (Exception)obj47;
			if (!flag81)
			{
				NullReferenceException ex27 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex27;
				goto IL_6f43;
			}
			goto IL_78d8;
			IL_6156:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag82 = num30 != 0;
			ex = (Exception)(object)obj19;
			if (!flag82)
			{
				NullReferenceException ex28 = new NullReferenceException();
				goto IL_619b;
			}
			goto IL_78d8;
			IL_61ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num31 == 0)
			{
				ArgumentNullException ex29 = new ArgumentNullException();
				obj135 = null;
				_Canon = (System.__Canon)(object)ex29;
				goto IL_6243;
			}
			goto IL_78d8;
			IL_619b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag83 = num32 != 0;
			ex = (Exception)(object)obj19;
			if (!flag83)
			{
				ArgumentNullException ex30 = new ArgumentNullException();
				ex = null;
				goto IL_61ef;
			}
			goto IL_78d8;
			IL_5c63:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag84 = num33 != 0;
			System.__Canon _Canon4;
			_Canon = _Canon4;
			UnityEngine.Object obj137;
			System.__Canon _Canon5;
			if (!flag84)
			{
				IndexOutOfRangeException ex31 = new IndexOutOfRangeException();
				obj137 = (UnityEngine.Object)(object)ex;
				_Canon5 = (System.__Canon)(object)ex31;
				goto IL_5cb8;
			}
			goto IL_78d8;
			IL_66c6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag85 = num34 != 0;
			num3 = num5;
			ex = (Exception)obj122;
			_Canon = _Canon2;
			if (!flag85)
			{
				IndexOutOfRangeException ex32 = new IndexOutOfRangeException();
				_Canon3 = (System.__Canon)(object)ex32;
				goto IL_6723;
			}
			goto IL_78d8;
			IL_6592:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num35 == 0)
			{
				NullReferenceException ex33 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex33;
				goto IL_65d7;
			}
			goto IL_78d8;
			IL_58dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num36 == 0)
			{
				return;
			}
			goto IL_78d8;
			IL_5c1e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num37 == 0)
			{
				NullReferenceException ex34 = new NullReferenceException();
				_Canon4 = (System.__Canon)(object)ex34;
				goto IL_5c63;
			}
			goto IL_78d8;
			IL_741b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag86 = num38 != 0;
			ex = (Exception)lobby3;
			if (!flag86)
			{
				NullReferenceException ex35 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex35;
				goto IL_7468;
			}
			goto IL_78d8;
			IL_6921:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag87 = num39 != 0;
			ex = (Exception)obj41;
			if (!flag87)
			{
				NullReferenceException ex3 = new NullReferenceException();
				goto IL_6966;
			}
			goto IL_78d8;
			IL_6b4a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag88 = num40 != 0;
			ex = (Exception)obj47;
			if (!flag88)
			{
				NullReferenceException ex36 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex36;
				goto IL_6b97;
			}
			goto IL_78d8;
			IL_7200:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag89 = num41 != 0;
			ex = (Exception)lobby3;
			if (!flag89)
			{
				NullReferenceException ex37 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex37;
				goto IL_724d;
			}
			goto IL_78d8;
			IL_6780:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag90 = num42 != 0;
			num3 = num5;
			ex = (Exception)obj122;
			if (!flag90)
			{
				NullReferenceException ex38 = new NullReferenceException();
				num3 = num5;
				ex = (Exception)obj122;
				_Canon = (System.__Canon)(object)ex38;
				goto IL_67e5;
			}
			goto IL_78d8;
			IL_5cb8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag91 = num43 != 0;
			ex = (Exception)(object)obj137;
			_Canon = _Canon5;
			if (!flag91)
			{
				IndexOutOfRangeException ex39 = new IndexOutOfRangeException();
				_Canon = (System.__Canon)(object)ex39;
				goto IL_5d0d;
			}
			goto IL_78d8;
			IL_6723:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag92 = num44 != 0;
			num3 = num5;
			ex = (Exception)obj122;
			_Canon = _Canon3;
			if (!flag92)
			{
				IndexOutOfRangeException ex40 = new IndexOutOfRangeException();
				_Canon = (System.__Canon)(object)ex40;
				goto IL_6780;
			}
			goto IL_78d8;
			IL_687f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag93 = num45 != 0;
			ex = (Exception)(object)obj136;
			if (!flag93)
			{
				NullReferenceException ex41 = new NullReferenceException();
				obj41 = obj136;
				_Canon = (System.__Canon)(object)ex41;
				goto IL_68d4;
			}
			goto IL_78d8;
			IL_7ca2:
			awaiter.GetResult();
			obj5 = text;
			goto IL_5775;
			IL_5d0d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag94 = num46 != 0;
			ex = (Exception)(object)obj137;
			if (!flag94)
			{
				NullReferenceException ex42 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex42;
				goto IL_5d5a;
			}
			goto IL_78d8;
			IL_6ccb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag95 = num47 != 0;
			ex = (Exception)obj47;
			if (!flag95)
			{
				NullReferenceException ex43 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex43;
				goto IL_6d18;
			}
			goto IL_78d8;
			IL_6d65:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag96 = num48 != 0;
			ex = (Exception)obj47;
			if (!flag96)
			{
				NullReferenceException ex44 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex44;
				goto IL_6db2;
			}
			goto IL_78d8;
			IL_6be4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag97 = num49 != 0;
			ex = (Exception)obj47;
			if (!flag97)
			{
				NullReferenceException ex45 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex45;
				goto IL_6c31;
			}
			goto IL_78d8;
			IL_7a6d:
			_003C_003Ec__DisplayClass185_0 obj138 = _003C_003E8__1;
			bool flag98 = _003C_003E8__1 == null;
			num3 = num5;
			string text14;
			text2 = text14;
			UnityEngine.Object obj139;
			text13 = (string)(object)obj139;
			if (flag98)
			{
				goto IL_63cc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE530]");
			object obj140 = 0;
			string text15 = (string)obj140 + obj138.prefix + code;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj141 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject2 = default;
			gameObject2._002Ector(text15);
			bool flag99 = (object)gameObject2 == null;
			num3 = num5;
			text = null;
			text2 = null;
			text13 = text15;
			_Canon = (System.__Canon)(object)gameObject2;
			if (flag99)
			{
				goto IL_6419;
			}
			Transform transform = gameObject2.transform;
			Transform transform2 = _003C_003E4__this.transform;
			bool flag100 = (object)transform == null;
			num3 = num5;
			text = null;
			text2 = null;
			text13 = (string)(object)transform2;
			_Canon = (System.__Canon)(object)transform2;
			if (flag100)
			{
				goto IL_6466;
			}
			transform.SetParent(transform2, worldPositionStays: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F0]");
			object obj142 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj143 = _003C_003E4__this + 176;
			object obj144 = default;
			obj143 = obj144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3D0]");
			object obj145 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj146 = 0;
			_003Cvoiced_003E5__8 = false;
			object obj147 = obj146;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7818 @ X0_v503+E4]");
			bool flag101 = (nint)0 == 0;
			object obj148 = !flag101;
			if (obj148 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+70]");
			bool flag102 = (UnityEngine.Object)0 != null;
			bool flag103 = !flag102;
			text2 = null;
			if (!flag103)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3E0]");
				object obj149 = 0;
				ex = (Exception)obj149;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				bool flag104 = _Canon == null;
				num3 = num5;
				text = null;
				text2 = null;
				if (flag104)
				{
					goto IL_6592;
				}
				object obj150 = _Canon + 152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+70]");
				obj150 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj151 = obj146;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8604 @ X0_v521+E4]");
				bool flag105 = (nint)0 == 0;
				object obj152 = !flag105;
				if (obj152 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
				bool flag106 = (UnityEngine.Object)0 != null;
				if (flag106)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
					object obj153 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
					bool flag107 = (nint)0 == 0;
					num3 = num5;
					text = null;
					text2 = null;
					obj41 = null;
					_Canon = (System.__Canon)flag106;
					if (flag107)
					{
						goto IL_68d4;
					}
					_ = 1;
				}
				_003Cvoiced_003E5__8 = true;
				text2 = null;
			}
			object obj154 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
			obj154 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj155 = 0;
			object obj156 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 120));
			obj156 = obj155;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ex = (Exception)obj143;
			object obj157 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 128));
			obj157 = obj143;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_003CstartWait_003E5__12 = 45000;
			obj = obj130;
			num3 = num5;
			obj5 = null;
			gameObject = gameObject2;
			goto IL_7d7a;
			IL_7166:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag108 = num50 != 0;
			ex = (Exception)lobby3;
			if (!flag108)
			{
				NullReferenceException ex46 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex46;
				goto IL_71b3;
			}
			goto IL_78d8;
			IL_7502:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag109 = num51 != 0;
			ex = (Exception)lobby3;
			if (!flag109)
			{
				NullReferenceException ex47 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex47;
				goto IL_754f;
			}
			goto IL_78d8;
			IL_661c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num52 == 0)
			{
				NullReferenceException ex48 = new NullReferenceException();
				num5 = num3;
				obj122 = ex;
				_Canon = (System.__Canon)(object)ex48;
				goto IL_6671;
			}
			goto IL_78d8;
			IL_5e39:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num53 == 0)
			{
				NullReferenceException ex49 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex49;
				goto IL_5e7e;
			}
			goto IL_78d8;
			IL_6aa8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag110 = num54 != 0;
			ex = (Exception)(object)text8;
			if (!flag110)
			{
				NullReferenceException ex50 = new NullReferenceException();
				obj47 = text8;
				_Canon = (System.__Canon)(object)ex50;
				goto IL_6afd;
			}
			goto IL_78d8;
			IL_6c31:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag111 = num55 != 0;
			ex = (Exception)obj47;
			if (!flag111)
			{
				NullReferenceException ex51 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex51;
				goto IL_6c7e;
			}
			goto IL_78d8;
			IL_5d5a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag112 = num56 != 0;
			ex = (Exception)(object)obj137;
			if (!flag112)
			{
				NullReferenceException ex52 = new NullReferenceException();
				ex = (Exception)(object)obj137;
				_Canon = (System.__Canon)(object)ex52;
				goto IL_5daf;
			}
			goto IL_78d8;
			IL_0dde:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE410]");
			object obj158 = 0;
			obj135 = (UnityEngine.Object)obj158;
			_Canon = taskAwaiter.GetResult();
			if ((object)_Canon == _003Cstarting_003E5__14)
			{
				bool flag113 = _Canon == null;
				text = (string)obj5;
				if (flag113)
				{
					goto IL_6243;
				}
				System.__Canon result = ((Task<System.__Canon>)(object)_Canon).Result;
				object obj159 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
				obj159 = result;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			goto IL_2085;
			IL_6832:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag114 = num57 != 0;
			ex = (Exception)(object)obj136;
			if (!flag114)
			{
				NullReferenceException ex53 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex53;
				goto IL_687f;
			}
			goto IL_78d8;
			IL_754f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag115 = num58 != 0;
			ex = (Exception)lobby3;
			if (!flag115)
			{
				NullReferenceException ex54 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex54;
				goto IL_759c;
			}
			goto IL_78d8;
			IL_7119:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag116 = num59 != 0;
			ex = (Exception)lobby3;
			if (!flag116)
			{
				NullReferenceException ex55 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex55;
				goto IL_7166;
			}
			goto IL_78d8;
			IL_6061:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag117 = num60 != 0;
			Exception ex56;
			ex = ex56;
			if (!flag117)
			{
				ArgumentNullException ex57 = new ArgumentNullException();
				ex = null;
				goto IL_60b5;
			}
			goto IL_78d8;
			IL_6e54:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag118 = num61 != 0;
			ex = (Exception)(object)text12;
			if (!flag118)
			{
				NullReferenceException ex58 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex58;
				goto IL_6ea1;
			}
			goto IL_78d8;
			IL_5fd7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num62 == 0)
			{
				NullReferenceException ex59 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex59;
				goto IL_601c;
			}
			goto IL_78d8;
			IL_75f1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num63 == 0)
			{
				NullReferenceException ex60 = new NullReferenceException();
				bool flag119 = (nint)ex != 1;
				NullReferenceException ex61 = ex60;
				_Canon = (System.__Canon)(object)ex60;
				if (!flag119)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj161 = default;
					object obj160 = obj161;
					ex = (Exception)obj160;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj163 = default;
					object obj162 = obj163 & 1;
					if (obj162 != null)
					{
						object obj164 = 0;
						object obj166 = default;
						object obj165 = (object)(&obj166);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						_003C_003E1__state = -2;
						object obj167 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
						obj167 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj168 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
						obj168 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj169 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 88));
						obj169 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj170 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 96));
						obj170 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj171 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
						obj171 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj172 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 120));
						obj172 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj173 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 128));
						obj173 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)(obj173 - 120);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9201 @ X0_v602+E4]");
						bool flag120 = (nint)0 == 0;
						object obj174 = !flag120;
						if (obj174 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetException((Exception)obj161);
						text2 = null;
						ex = (Exception)obj161;
						_Canon = (System.__Canon)asyncTaskMethodBuilder2;
						goto IL_58dd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					_Canon = (System.__Canon)obj161;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
					nint num64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
					if (num64 != 0)
					{
						goto IL_78d8;
					}
					ex = (Exception)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					text2 = null;
					NullReferenceException ex62 = default;
					ex61 = ex62;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				if (num65 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
			}
			goto IL_78d8;
			IL_6afd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag121 = num66 != 0;
			ex = (Exception)obj47;
			if (!flag121)
			{
				NullReferenceException ex63 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex63;
				goto IL_6b4a;
			}
			goto IL_78d8;
			IL_2085:
			object obj175 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 168));
			obj175 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj176 = 0;
			object obj177 = obj176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5936 @ X0_v49+E4]");
			bool flag122 = (nint)0 == 0;
			object obj178 = !flag122;
			if (obj178 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag123 = _003C_003E4__this == null;
			bool flag124 = !flag123;
			object obj179 = !flag124;
			text2 = null;
			if (obj179 == null)
			{
				bool flag125 = (object)_003C_003E4__this == null;
				text = (string)obj5;
				text2 = null;
				obj137 = null;
				_Canon = (System.__Canon)flag123;
				if (flag125)
				{
					goto IL_5d5a;
				}
				int num67 = _003Cmine_003E5__3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+128]");
				if ((nint)num67 == 0)
				{
					object obj180 = _003C_003E4__this + 192;
					_ = 0;
					if (obj180 != null)
					{
						obj180 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						NetworkBootstrap networkBootstrap2 = _003C_003E4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+C8]");
						networkBootstrap2.Join((Lobby)0, (string)obj180, probe: false);
						obj5 = null;
						text2 = (string)obj180;
					}
					else if (_003Cresult_003E5__9 != null && _003Cresult_003E5__9.Ok)
					{
						_ = 0;
						lobby3 = kind;
						Lobby lobby5 = _003C_003E4__this.RoomKind(kind);
						if (~(_003CgoingPublic_003E5__5 ? 1u : 0u) == 0)
						{
							bool flag126 = (byte)(~(_003CownRoom_003E5__2 ? 1u : 0u)) != 0;
							object obj181 = !flag126;
							if (obj181 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								object obj182 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								bool flag127 = (nint)0 == 0;
								text = (string)obj5;
								text2 = null;
								_Canon = (System.__Canon)lobby5;
								if (flag127)
								{
									goto IL_7200;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7279 @ X8_v204+2F8]");
								object obj183 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7279 @ X8_v204+2F8]");
								bool flag128 = (nint)0 == 0;
								text = (string)obj5;
								text2 = null;
								_Canon = (System.__Canon)lobby5;
								if (flag128)
								{
									goto IL_724d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
								object obj184 = 0;
								object obj185 = obj184;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7555 @ X0_v331+E4]");
								bool flag129 = (nint)0 == 0;
								object obj186 = !flag129;
								if (obj186 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7302 @ X8_v205+10]");
								bool flag130 = IsGamesPublicRoom((string)0);
								bool flag131 = !flag130;
								object obj187 = !flag131;
								if (obj187 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									object obj188 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									bool flag132 = (nint)0 == 0;
									text = (string)obj5;
									text2 = null;
									_Canon = (System.__Canon)flag130;
									if (flag132)
									{
										goto IL_7468;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7963 @ X8_v206+2F8]");
									object obj189 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7963 @ X8_v206+2F8]");
									bool flag133 = (nint)0 == 0;
									text = (string)obj5;
									text2 = null;
									_Canon = (System.__Canon)flag130;
									if (flag133)
									{
										goto IL_74b5;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE328]");
									object obj190 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE528]");
									object obj191 = 0;
									text2 = (string)obj191;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8159 @ X8_v207+10]");
									string text16 = (string)obj190 + (string)0 + (string)obj191;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj192 = 0;
									object obj193 = obj192;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8375 @ X0_v337+E4]");
									bool flag134 = (nint)0 == 0;
									object obj194 = !flag134;
									if (obj194 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.LogWarning(text16);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									object obj195 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
									bool flag135 = (nint)0 == 0;
									text = null;
									lobby3 = (Lobby)0;
									_Canon = (System.__Canon)(object)text16;
									if (flag135)
									{
										goto IL_7502;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8525 @ X8_v211+2F8]");
									object obj196 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8525 @ X8_v211+2F8]");
									bool flag136 = (nint)0 == 0;
									text = null;
									lobby3 = (Lobby)0;
									_Canon = (System.__Canon)(object)text16;
									if (!flag136)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
										object obj197 = 0;
										object obj198 = obj197;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8758 @ X0_v340+E4]");
										bool flag137 = (nint)0 == 0;
										object obj199 = !flag137;
										if (obj199 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8687 @ X8_v212+10]");
										GillaModeration.Avoid((string)0, 3600f);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj200 = 0;
										_ = 1;
										text2 = (string)obj200;
										_003C_003E4__this.Join(kind, (string)obj200, probe: false);
										num3 = 1.1639849E+09f;
										obj5 = null;
										goto IL_5775;
									}
									goto IL_754f;
								}
							}
						}
						else
						{
							if (lobby5 != kind)
							{
								if (~(probe ? 1u : 0u) == 0)
								{
									goto IL_4f06;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
								object obj201 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								bool flag138 = _Canon == null;
								text = (string)obj5;
								text2 = null;
								ex = (Exception)7;
								if (!flag138)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE328]");
									object obj202 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4E8]");
									object obj203 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
									object obj204 = 0;
									object obj205 = obj204;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8175 @ X0_v300+E4]");
									bool flag139 = (nint)0 == 0;
									object obj206 = !flag139;
									if (obj206 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string text17 = LabelOf(lobby5);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4B8]");
									object obj207 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									string text18 = LabelOf(kind);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE540]");
									object obj208 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									string message4 = string.Concat((string[])(object)_Canon);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj209 = 0;
									object obj210 = obj209;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8926 @ X0_v316+E4]");
									bool flag140 = (nint)0 == 0;
									object obj211 = !flag140;
									if (obj211 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.Log(message4);
									object obj212 = _003C_003E4__this + 232;
									obj212 = _003CcameFrom_003E5__4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text19 = Shown(code);
									string text20 = Carried(kind);
									string text21 = text19 + text20;
									_003C_003E4__this.Join(kind, text21, probe: true);
									obj5 = 1;
									text2 = text21;
									goto IL_5775;
								}
								goto IL_75f1;
							}
							if (~(probe ? 1u : 0u) == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								object obj213 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								bool flag141 = (nint)0 == 0;
								text = (string)obj5;
								text2 = null;
								_Canon = (System.__Canon)lobby5;
								if (flag141)
								{
									goto IL_73ce;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7448 @ X8_v200+2F8]");
								object obj214 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7448 @ X8_v200+2F8]");
								bool flag142 = (nint)0 == 0;
								text = (string)obj5;
								text2 = null;
								_Canon = (System.__Canon)lobby5;
								if (flag142)
								{
									goto IL_741b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7582 @ X8_v201+28]");
								if ((nint)0 <= (nint)1)
								{
									goto IL_4f06;
								}
							}
						}
						bool flag143 = (byte)(~(_003CownRoom_003E5__2 ? 1u : 0u)) != 0;
						object obj215 = !flag143;
						text2 = null;
						if (obj215 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
							object obj216 = 0;
							_Canon = (System.__Canon)obj216;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5444 @ X0_v620 (System.__Canon)+E4]");
							bool flag144 = (nint)0 == 0;
							object obj217 = !flag144;
							if (obj217 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								_Canon = (System.__Canon)obj216;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
							object obj218 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
							bool flag145 = (nint)0 == 0;
							text = (string)obj5;
							text2 = null;
							if (flag145)
							{
								goto IL_7119;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7574 @ X8_v156+2F8]");
							object obj219 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7574 @ X8_v156+2F8]");
							bool flag146 = (nint)0 == 0;
							text = (string)obj5;
							text2 = null;
							if (flag146)
							{
								goto IL_7166;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5444 @ X0_v620 (System.__Canon)+A0]");
							object obj220 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7827 @ X9_v27+58]");
							object obj221 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7827 @ X9_v27+58]");
							bool flag147 = (nint)0 == 0;
							text = (string)obj5;
							text2 = null;
							if (flag147)
							{
								goto IL_71b3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7691 @ X8_v157+10]");
							lobby3 = (Lobby)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7438 @ X9_v28+28]");
							text2 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7438 @ X9_v28+18] (should have been resolved before IL gen)");
							object obj222 = _Canon & 1;
							if (obj222 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								object obj223 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
								bool flag148 = (nint)0 == 0;
								text = (string)obj5;
								if (flag148)
								{
									goto IL_7334;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8161 @ X8_v159+2F8]");
								object obj224 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8161 @ X8_v159+2F8]");
								bool flag149 = (nint)0 == 0;
								text = (string)obj5;
								if (!flag149)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE328]");
									object obj225 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4A8]");
									object obj226 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8286 @ X8_v160+10]");
									string message5 = (string)obj225 + (string)0 + (string)obj226;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
									object obj227 = 0;
									object obj228 = obj227;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8529 @ X0_v248+E4]");
									bool flag150 = (nint)0 == 0;
									object obj229 = !flag150;
									if (obj229 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.LogWarning(message5);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
									object obj230 = 0;
									_ = _003CgoingPublic_003E5__5;
									text2 = (string)obj230;
									_003C_003E4__this.Join(kind, (string)obj230, probe: false);
									obj5 = null;
									goto IL_5775;
								}
								goto IL_7381;
							}
						}
						num3 = Time.unscaledTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj231 = 0;
						object obj232 = _003C_003E4__this + 128;
						obj232 = obj231;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = kind;
						obj47 = code;
						_ = code;
						object obj233 = _003C_003E4__this + 264;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag151 = (byte)(~(_003CgoingPublic_003E5__5 ? 1u : 0u)) != 0;
						object obj234 = !flag151;
						if (obj234 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
							object obj235 = 0;
							object obj236 = obj235;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7983 @ X0_v228+E4]");
							bool flag152 = (nint)0 == 0;
							object obj237 = !flag152;
							if (obj237 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text22 = Shown(code);
							object obj238 = _003C_003E4__this + 216;
							obj238 = text22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Lobby? lobby6 = CarriedKind(code);
							object obj239 = (_003F?)lobby6 & 0xFF;
							if (obj239 != null)
							{
								NetworkBootstrap networkBootstrap3 = _003C_003E4__this;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E0]");
								Lobby lobby7 = networkBootstrap3.HomeOf((Lobby)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E0]");
								obj47 = 0;
								_Canon = (System.__Canon)lobby7;
							}
							else
							{
								_Canon = (System.__Canon)kind;
								obj47 = text22;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						object obj240 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag153 = (nint)0 == 0;
						text = (string)obj5;
						if (flag153)
						{
							goto IL_6be4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7538 @ X8_v125+2F8]");
						object obj241 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7538 @ X8_v125+2F8]");
						bool flag154 = (nint)0 == 0;
						text = (string)obj5;
						if (flag154)
						{
							goto IL_6c31;
						}
						string roomCode2 = _003C_003E4__this.RoomCode;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
						object obj242 = 0;
						object obj243 = obj242;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8406 @ X0_v188+E4]");
						bool flag155 = (nint)0 == 0;
						object obj244 = !flag155;
						if (obj244 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text23 = Shown(roomCode2);
						object obj245 = _003C_003E4__this + 120;
						obj245 = text23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
						object obj246 = 0;
						Vector3? vector = (Vector3)obj246;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA97E8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
						object obj247 = 0;
						Quaternion? quaternion = (Quaternion)obj247;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag156 = (nint)0 == 0;
						text = (string)obj5;
						obj47 = obj247;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						_Canon = (System.__Canon)0;
						if (flag156)
						{
							goto IL_6c7e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						PlayerRef localPlayer = ((NetworkRunner)0).LocalPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE408]");
						object obj248 = 0;
						text2 = (string)obj248;
						PlayerRef? playerRef = localPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag157 = (nint)0 == 0;
						text = (string)obj5;
						obj47 = localPlayer;
						_Canon = (System.__Canon)(&playerRef);
						if (flag157)
						{
							goto IL_6ccb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						nint num68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+20]");
						float num69 = default;
						NetworkObject networkObject = ((NetworkRunner)num68).Spawn((NetworkObject)0, vector, (Quaternion?)(object)0, (PlayerRef?)(object)(&num69), (NetworkRunner.OnBeforeSpawned)playerRef, (NetworkSpawnFlags)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						NetworkRunner networkRunner = (NetworkRunner)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag158 = (nint)0 == 0;
						object obj249 = 0;
						NetworkSpawnFlags networkSpawnFlags = (NetworkSpawnFlags)0;
						NetworkRunner.OnBeforeSpawned onBeforeSpawned = (NetworkRunner.OnBeforeSpawned)playerRef;
						PlayerRef? playerRef2 = (PlayerRef?)(object)(&num69);
						num3 = (float)quaternion;
						text = null;
						text2 = (string)vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+20]");
						obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						_Canon = (System.__Canon)0;
						if (flag158)
						{
							goto IL_6d18;
						}
						SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
						bool flag159 = networkRunner.SessionInfo__BackingField == null;
						obj249 = 0;
						networkSpawnFlags = (NetworkSpawnFlags)0;
						onBeforeSpawned = (NetworkRunner.OnBeforeSpawned)playerRef;
						playerRef2 = (PlayerRef?)(object)(&num69);
						num3 = (float)quaternion;
						text = null;
						text2 = (string)vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+20]");
						obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						_Canon = (System.__Canon)0;
						if (flag159)
						{
							goto IL_6d65;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						PlayerRef localPlayer2 = ((NetworkRunner)0).LocalPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj250 = 0;
						object obj251 = obj250;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9272 @ X8_v140+E4]");
						bool flag160 = (nint)0 == 0;
						object obj252 = !flag160;
						if (obj252 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PlayerRef playerRef3 = default;
						int playerId = playerRef3.PlayerId;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj253 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE518]");
						object format2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7811 @ X8_v126+10]");
						object obj254 = default;
						string text24 = string.Format((string)format2, 0, sessionInfo.Region__BackingField, obj254);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						object obj255 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag161 = (nint)0 == 0;
						obj249 = 0;
						networkSpawnFlags = (NetworkSpawnFlags)0;
						onBeforeSpawned = (NetworkRunner.OnBeforeSpawned)playerRef;
						playerRef2 = (PlayerRef?)(object)0;
						num3 = (float)quaternion;
						text = (string)obj254;
						text2 = sessionInfo.Region__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7811 @ X8_v126+10]");
						obj47 = 0;
						_Canon = (System.__Canon)(object)text24;
						if (flag161)
						{
							goto IL_6db2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8909 @ X8_v144+2F8]");
						bool flag162 = (nint)0 == 0;
						obj249 = 0;
						networkSpawnFlags = (NetworkSpawnFlags)0;
						onBeforeSpawned = (NetworkRunner.OnBeforeSpawned)playerRef;
						playerRef2 = (PlayerRef?)(object)0;
						num3 = (float)quaternion;
						text = (string)obj254;
						text2 = sessionInfo.Region__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7811 @ X8_v126+10]");
						obj47 = 0;
						_Canon = (System.__Canon)(object)text24;
						if (flag162)
						{
							goto IL_6dff;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE508]");
						object format3 = 0;
						object arg2 = default;
						string text25 = string.Format((string)format3, arg2);
						string message6 = text24 + text25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj256 = 0;
						object obj257 = obj256;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9493 @ X0_v221+E4]");
						bool flag163 = (nint)0 == 0;
						object obj258 = !flag163;
						if (obj258 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.Log(message6);
						obj249 = 0;
						networkSpawnFlags = (NetworkSpawnFlags)0;
						onBeforeSpawned = (NetworkRunner.OnBeforeSpawned)playerRef;
						playerRef2 = (PlayerRef?)(object)0;
						num3 = (float)quaternion;
						obj5 = obj254;
						text2 = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE180]");
						object obj259 = 0;
						object obj260 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 120));
						object obj261;
						bool flag164;
						ShutdownReason shutdownReason;
						if ((string)obj260 == (string)obj259)
						{
							obj261 = 0;
							flag164 = false;
							shutdownReason = (ShutdownReason)20;
						}
						else
						{
							StartGameResult startGameResult = _003Cresult_003E5__9;
							if (_003Cresult_003E5__9 != null)
							{
								shutdownReason = startGameResult.ShutdownReason__BackingField;
								obj260 = _003Cresult_003E5__9 + 24;
								object obj262 = startGameResult.ShutdownReason__BackingField - 10;
								bool flag165 = obj262 == null;
								object obj263 = startGameResult.ShutdownReason__BackingField - 5;
								bool flag166 = (nint)obj263 < 2;
								object obj264 = !flag166;
								object obj265 = ~obj264;
								obj261 = obj265;
								flag164 = flag165;
							}
							else
							{
								obj261 = 0;
								flag164 = false;
								shutdownReason = (ShutdownReason)1;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
						object obj266 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						_003C_003Ec__DisplayClass185_0 obj267 = _003C_003E8__1;
						bool flag167 = _003C_003E8__1 == null;
						text = (string)obj5;
						text2 = null;
						ex = (Exception)4;
						if (flag167)
						{
							goto IL_67e5;
						}
						bool flag168 = _Canon == null;
						text = (string)obj5;
						text2 = null;
						obj136 = (UnityEngine.Object)4;
						if (flag168)
						{
							goto IL_6832;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						object obj268 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 40));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
						object obj269 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE520]");
						object format4 = 0;
						string message7 = string.Format((string)format4, (object[])(object)_Canon);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj270 = 0;
						object obj271 = obj270;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8713 @ X0_v114+E4]");
						bool flag169 = (nint)0 == 0;
						object obj272 = !flag169;
						if (obj272 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogWarning(message7);
						object obj273 = obj261 | flag164;
						if ((nint)obj273 == 1 && ~(_003CgoingPublic_003E5__5 ? 1u : 0u) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+F0]");
							if ((nint)0 <= (nint)4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+F0]");
								object obj274 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
								obj = 0;
								if (flag164)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
									object obj275 = 0;
									object obj276 = obj275;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9101 @ X0_v170+E4]");
									bool flag170 = (nint)0 == 0;
									object obj277 = !flag170;
									if (obj277 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj276 = obj275;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9101 @ X0_v170+A0]");
									object obj278 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9103 @ X8_v114+4]");
									object obj279 = (nint)0 + (nint)1;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
								object obj280 = 0;
								text2 = (string)obj280;
								_003C_003E4__this.Join(kind, (string)obj280, probe: false);
								obj5 = null;
								goto IL_5775;
							}
						}
						bool flag171 = !flag164;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4D0]");
						object obj281 = 0;
						_ = 0;
						object obj282 = !flag171;
						object obj283 = ~obj282;
						if (obj283 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
							obj281 = 0;
						}
						object obj284 = _003C_003E4__this + 120;
						obj284 = obj281;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
						obj = 0;
						string text26;
						if (flag164)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj285 = 0;
							text26 = (string)obj285;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
							object obj286 = 0;
							object obj287 = obj286;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9149 @ X0_v162+E4]");
							bool flag172 = (nint)0 == 0;
							object obj288 = !flag172;
							if (obj288 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text27 = JoinWhy(shutdownReason, (string)obj260);
							text26 = text27;
						}
						object obj289 = _003C_003E4__this + 136;
						obj289 = text26;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						string text28;
						float num70 = default;
						if (flag164)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj290 = 0;
							text28 = (string)obj290;
							text = (string)obj5;
							string text29 = null;
						}
						else
						{
							string text30 = ((Enum)(&num70)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
							object obj291 = 0;
							text8 = (string)obj291;
							string text31 = text30 + (string)obj291 + (string)obj260;
							bool flag173 = text31 == null;
							text = null;
							text2 = (string)obj260;
							_Canon = (System.__Canon)(object)text31;
							if (flag173)
							{
								goto IL_6aa8;
							}
							string text32 = text31.Trim();
							text = null;
							string text29 = (string)obj260;
							text28 = text32;
						}
						object obj292 = _003C_003E4__this + 128;
						obj292 = text28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj293 = obj176;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9275 @ X0_v128+E4]");
						bool flag174 = (nint)0 == 0;
						object obj294 = !flag174;
						if (obj294 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
						bool flag175 = (UnityEngine.Object)0 != null;
						bool flag176 = !_003Cvoiced_003E5__8;
						object obj295 = !flag176;
						object obj296 = flag175 & obj295;
						object obj297 = obj296 & 1;
						bool flag177 = obj297 == null;
						UnityEngine.Object obj298 = null;
						if (!flag177)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
							bool flag178 = (nint)0 == 0;
							text2 = null;
							obj47 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
							_Canon = (System.__Canon)0;
							if (flag178)
							{
								goto IL_6afd;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+50]");
							((MicLevel)0).Restart();
							obj298 = null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
						object obj299 = 0;
						object obj300 = obj299;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9363 @ X0_v134+E4]");
						bool flag179 = (nint)0 == 0;
						object obj301 = !flag179;
						if (obj301 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool shiftAuthNeeded2 = ShiftAuthNeeded;
						object obj302 = shutdownReason - 11;
						bool flag180 = (nint)obj302 < 3;
						object obj303 = !flag180;
						object obj304 = ~obj303;
						object obj305 = shiftAuthNeeded2 & obj304;
						object obj306 = obj305 & 1;
						bool flag181 = obj306 == null;
						obj5 = text;
						string text33 = null;
						string text34 = (string)(object)obj298;
						if (!flag181)
						{
							string text35 = ((Enum)(&num70)).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4B0]");
							object obj307 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
							object obj308 = 0;
							text33 = (string)obj308;
							string why = (string)obj307 + text35 + (string)obj308;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
							object obj309 = 0;
							object obj310 = obj309;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9475 @ X0_v151+E4]");
							bool flag182 = (nint)0 == 0;
							object obj311 = !flag182;
							if (obj311 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							ShiftAuth.TicketRefused(why);
							obj5 = null;
							text34 = text35;
						}
						if (~(probe ? 1u : 0u) == 0)
						{
							object obj312 = obj299;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9454 @ X0_v138+E4]");
							bool flag183 = (nint)0 == 0;
							object obj313 = !flag183;
							if (obj313 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text36 = Shown((string)obj268);
							object obj314 = _003C_003E4__this + 152;
							obj314 = text36;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E8]");
							text2 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E0]");
							_ = 0;
							NetworkBootstrap networkBootstrap4 = _003C_003E4__this;
							Lobby lobby8 = kind;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E8]");
							networkBootstrap4.RetryLater(lobby8, (string)0);
						}
						else
						{
							bool flag184 = !flag164;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj315 = 0;
							object obj316 = !flag184;
							object obj317 = ~obj316;
							if (obj317 != null)
							{
								obj315 = obj268;
							}
							text2 = (string)obj315;
							_003C_003E4__this.RetryLater(kind, (string)obj315);
						}
					}
				}
				else
				{
					_003C_003Ec__DisplayClass185_0 obj318 = _003C_003E8__1;
					bool flag185 = _003C_003E8__1 == null;
					text = (string)obj5;
					text2 = null;
					obj135 = null;
					_Canon = (System.__Canon)flag123;
					if (flag185)
					{
						goto IL_632a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4F8]");
					object obj319 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4E0]");
					object obj320 = 0;
					text = (string)obj320;
					string message8 = (string)obj319 + obj318.prefix + code + (string)obj320;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj321 = 0;
					object obj322 = obj321;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6806 @ X0_v55+E4]");
					bool flag186 = (nint)0 == 0;
					object obj323 = !flag186;
					if (obj323 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message8);
					object obj324 = obj176;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6973 @ X0_v58+E4]");
					bool flag187 = (nint)0 == 0;
					object obj325 = !flag187;
					if (obj325 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag188 = (UnityEngine.Object)_003CmineRunner_003E5__11 != (UnityEngine.Object)null;
					bool flag189 = !flag188;
					PlayerRef? playerRef2 = (PlayerRef?)(object)0;
					obj5 = text;
					text2 = null;
					if (!flag189)
					{
						object obj326 = obj176;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7322 @ X0_v62+E4]");
						bool flag190 = (nint)0 == 0;
						object obj327 = !flag190;
						if (obj327 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NetworkRunner networkRunner2 = _003CmineRunner_003E5__11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
						bool flag191 = networkRunner2 != (UnityEngine.Object)0;
						bool flag192 = !flag191;
						playerRef2 = (PlayerRef?)(object)0;
						obj5 = text;
						text2 = null;
						if (!flag192)
						{
							bool flag193 = (object)_003CmineRunner_003E5__11 == null;
							playerRef2 = (PlayerRef?)(object)0;
							text2 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
							obj136 = (UnityEngine.Object)0;
							_Canon = (System.__Canon)(object)_003CmineRunner_003E5__11;
							if (flag193)
							{
								goto IL_687f;
							}
							bool isRunning3 = _003CmineRunner_003E5__11.IsRunning;
							bool flag194 = !isRunning3;
							playerRef2 = (PlayerRef?)(object)0;
							obj5 = text;
							text2 = null;
							if (!flag194)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
								object obj328 = 0;
								object obj329 = obj328;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8184 @ X0_v68+E4]");
								bool flag195 = (nint)0 == 0;
								object obj330 = !flag195;
								if (obj330 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE480]");
								object obj331 = 0;
								text8 = (string)obj331;
								Task task3 = Leave(_003CmineRunner_003E5__11, (string)obj331);
								bool flag196 = task3 == null;
								playerRef2 = (PlayerRef?)(object)0;
								text2 = null;
								_Canon = (System.__Canon)(object)task3;
								if (flag196)
								{
									goto IL_6a5b;
								}
								TaskAwaiter awaiter4 = task3.GetAwaiter();
								bool isCompleted2 = awaiter.IsCompleted;
								bool flag197 = !isCompleted2;
								object obj332 = !flag197;
								playerRef2 = (PlayerRef?)(object)0;
								text2 = null;
								if (obj332 == null)
								{
									_003C_003E1__state = 5;
									object obj333 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 144));
									obj333 = awaiter;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj334 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8863 @ X0_v78+E4]");
									bool flag198 = (nint)0 == 0;
									object obj335 = !flag198;
									if (obj335 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3A8]");
									object obj336 = 0;
									text = (string)obj336;
									AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->AwaitUnsafeOnCompleted<TaskAwaiter, _003CJoinCore_003Ed__185>(ref awaiter, ref this);
									playerRef2 = (PlayerRef?)(object)0;
									text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
									ex = (Exception)(&awaiter);
									_Canon = (System.__Canon)asyncTaskMethodBuilder3;
									goto IL_58dd;
								}
								goto IL_7ca2;
							}
						}
					}
				}
			}
			goto IL_5775;
			IL_7e8d:
			object obj337 = _003C_003E4__this + 192;
			obj337 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = kind;
			obj5 = text;
			text2 = null;
			goto IL_5775;
			IL_6a0e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag199 = num71 != 0;
			ex = (Exception)(object)text8;
			if (!flag199)
			{
				NullReferenceException ex64 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex64;
				goto IL_6a5b;
			}
			goto IL_78d8;
			IL_64b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag200 = num72 != 0;
			ex = (Exception)(object)text13;
			if (!flag200)
			{
				NullReferenceException ex65 = new NullReferenceException();
				ex = (Exception)(object)text13;
				_Canon = (System.__Canon)(object)ex65;
				goto IL_6508;
			}
			goto IL_78d8;
			IL_6466:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag201 = num73 != 0;
			ex = (Exception)(object)text13;
			if (!flag201)
			{
				NullReferenceException ex66 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex66;
				goto IL_64b3;
			}
			goto IL_78d8;
			IL_654d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num74 == 0)
			{
				NullReferenceException ex67 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex67;
				goto IL_6592;
			}
			goto IL_78d8;
			IL_70cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag202 = num75 != 0;
			ex = (Exception)lobby3;
			if (!flag202)
			{
				NullReferenceException ex68 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex68;
				goto IL_7119;
			}
			goto IL_78d8;
			IL_6508:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num76 == 0)
			{
				NullReferenceException ex69 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex69;
				goto IL_654d;
			}
			goto IL_78d8;
			IL_5775:
			_003C_003E1__state = -2;
			object obj338 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
			obj338 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj339 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
			obj339 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj340 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 88));
			obj340 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj341 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 96));
			obj341 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj342 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
			obj342 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj343 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 120));
			obj343 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj344 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 128));
			obj344 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj345 = obj;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder4 = (AsyncTaskMethodBuilder)(obj344 - 120);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6401 @ X0_v804+E4]");
			bool flag203 = (nint)0 == 0;
			object obj346 = !flag203;
			if (obj346 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder4)->SetResult();
			text = (string)obj5;
			ex = null;
			_Canon = (System.__Canon)asyncTaskMethodBuilder4;
			goto IL_58dd;
			IL_79e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE410]");
			object obj347 = 0;
			ex = (Exception)obj347;
			_Canon = taskAwaiter.GetResult();
			object obj348 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 152));
			object obj349 = obj348;
			System.__Canon _Canon7;
			if (obj348 != null)
			{
				System.__Canon _Canon6 = _Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v339+10]");
				System.__Canon ticket;
				if (_Canon6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj350 = 0;
					_Canon7 = (System.__Canon)obj350;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5367 @ X0_v530 (System.__Canon)+E4]");
					bool flag204 = (nint)0 == 0;
					object obj351 = !flag204;
					if (obj351 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						_Canon7 = (System.__Canon)obj350;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5367 @ X0_v530 (System.__Canon)+A0]");
					object obj352 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5759 @ X8_v365+28]");
					ticket = (System.__Canon)0;
				}
				else
				{
					if (_Canon == null)
					{
						goto IL_637f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE450]");
					object obj353 = 0;
					ex = (Exception)obj353;
					_Canon7 = ((Task<System.__Canon>)(object)_Canon).Result;
					ticket = _Canon7;
				}
				object obj354 = obj348;
				if (obj348 != null)
				{
					System.__Canon _Canon8 = _Canon;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5793 @ X8_v345+10]");
					if (_Canon8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj355 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4C0]");
						object format5 = 0;
						object arg3 = default;
						string message9 = string.Format((string)format5, arg3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj356 = 0;
						object obj357 = obj356;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6433 @ X0_v551+E4]");
						bool flag205 = (nint)0 == 0;
						object obj358 = !flag205;
						if (obj358 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogWarning(message9);
						text2 = null;
						ex = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj359 = 0;
					object obj360 = obj359;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6234 @ X0_v535+E4]");
					bool flag206 = (nint)0 == 0;
					object obj361 = !flag206;
					if (obj361 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag207 = _003C_003E4__this == null;
					bool flag208 = !flag207;
					object obj362 = !flag208;
					obj5 = text;
					text2 = null;
					if (obj362 == null)
					{
						bool flag209 = (object)_003C_003E4__this == null;
						text2 = null;
						obj19 = null;
						_Canon = (System.__Canon)flag207;
						if (flag209)
						{
							goto IL_6156;
						}
						int num77 = _003Cmine_003E5__3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+128]");
						bool flag210 = (nint)num77 != 0;
						obj5 = text;
						text2 = null;
						if (!flag210)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
							object obj363 = 0;
							object obj364 = obj363;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6762 @ X0_v539+E4]");
							bool flag211 = (nint)0 == 0;
							object obj365 = !flag211;
							if (obj365 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							AuthenticationValues authenticationValues2 = TicketAuth((string)(object)ticket);
							obj348 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj130 = obj;
							num5 = num3;
							text14 = null;
							obj139 = null;
							authenticationValues = authenticationValues2;
							goto IL_7a6d;
						}
					}
					goto IL_5775;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				nint num78 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
				if (num78 != 0)
				{
					goto IL_78d8;
				}
				NullReferenceException ex70 = new NullReferenceException();
				_Canon7 = (System.__Canon)(object)ex70;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag212 = num79 != 0;
			_Canon = _Canon7;
			if (!flag212)
			{
				NullReferenceException ex71 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex71;
				goto IL_5c1e;
			}
			goto IL_78d8;
			IL_7381:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num80 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag213 = num80 != 0;
			ex = (Exception)lobby3;
			if (!flag213)
			{
				NullReferenceException ex72 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex72;
				goto IL_73ce;
			}
			goto IL_78d8;
			IL_7c51:
			awaiter.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE438]");
			object obj366 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag214 = _Canon == null;
			text = (string)obj5;
			ex = (Exception)2;
			if (flag214)
			{
				goto IL_5c1e;
			}
			bool flag215 = _003Cstarting_003E5__14 == null;
			ex = (Exception)2;
			_Canon4 = _Canon;
			if (!flag215)
			{
				nint num81 = (nint)_Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5960 @ X8_v29 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
				ex = (Exception)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag216 = _Canon4 == null;
				text = (string)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5960 @ X8_v29 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
				ex56 = (Exception)0;
				NullReferenceException ex73 = (NullReferenceException)(object)_Canon4;
				if (flag216)
				{
					goto IL_6061;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5444 @ X0_v620 (System.__Canon)+18]");
			bool flag217 = (nint)0 == 0;
			text = (string)obj5;
			if (flag217)
			{
				goto IL_5c63;
			}
			object obj367 = _Canon + 32;
			obj367 = _003Cstarting_003E5__14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
			object obj368 = 0;
			object obj369 = obj368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6273 @ X0_v20+E4]");
			bool flag218 = (nint)0 == 0;
			object obj370 = !flag218;
			if (obj370 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Task task4 = Task.Delay(10000);
			bool flag219 = task4 == null;
			Exception ex74 = null;
			ArgumentNullException ex75 = (ArgumentNullException)(object)task4;
			if (!flag219)
			{
				nint num82 = (nint)_Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6400 @ X8_v28 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
				ex74 = (Exception)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag220 = ex75 == null;
				text = (string)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6400 @ X8_v28 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
				ex = (Exception)0;
				ArgumentNullException ex57 = ex75;
				if (flag220)
				{
					goto IL_60b5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5444 @ X0_v620 (System.__Canon)+18]");
			object obj371 = 0 & 0xFFFFFFFEL;
			bool flag221 = obj371 == null;
			text = (string)obj5;
			obj137 = (UnityEngine.Object)(object)ex74;
			_Canon5 = (System.__Canon)(object)ex75;
			if (flag221)
			{
				goto IL_5cb8;
			}
			object obj372 = _Canon + 40;
			obj372 = task4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Task<Task> task5 = Task.WhenAny((Task[])(object)_Canon);
			bool flag222 = task5 == null;
			text = (string)obj5;
			obj137 = null;
			_Canon = (System.__Canon)(object)task5;
			if (!flag222)
			{
				TaskAwaiter<System.__Canon> awaiter5 = ((Task<System.__Canon>)(object)task5).GetAwaiter();
				TaskAwaiter<System.__Canon> awaiter6 = default;
				bool isCompleted3 = awaiter6.IsCompleted;
				bool flag223 = !isCompleted3;
				taskAwaiter = awaiter6;
				if (!flag223)
				{
					goto IL_0dde;
				}
				_003C_003E1__state = 4;
				object obj373 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 160));
				obj373 = awaiter6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj374 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7504 @ X0_v36+E4]");
				bool flag224 = (nint)0 == 0;
				object obj375 = !flag224;
				if (obj375 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3A0]");
				object obj376 = 0;
				text = (string)obj376;
				AsyncTaskMethodBuilder asyncTaskMethodBuilder5 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder5)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, _003CJoinCore_003Ed__185>(ref awaiter6, ref this);
				text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				ex = (Exception)(&awaiter6);
				_Canon = (System.__Canon)asyncTaskMethodBuilder5;
				goto IL_58dd;
			}
			goto IL_5d0d;
			IL_7077:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag225 = num83 != 0;
			ex = (Exception)obj47;
			if (!flag225)
			{
				NullReferenceException ex76 = new NullReferenceException();
				lobby3 = (Lobby)obj47;
				_Canon = (System.__Canon)(object)ex76;
				goto IL_70cc;
			}
			goto IL_78d8;
			IL_729a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag226 = num84 != 0;
			ex = (Exception)lobby3;
			if (!flag226)
			{
				NullReferenceException ex77 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex77;
				goto IL_72e7;
			}
			goto IL_78d8;
			IL_78d8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_6fdd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag227 = num85 != 0;
			ex = (Exception)obj47;
			if (!flag227)
			{
				NullReferenceException ex78 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex78;
				goto IL_702a;
			}
			goto IL_78d8;
			IL_6290:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag228 = num86 != 0;
			ex = (Exception)(object)obj135;
			if (!flag228)
			{
				NullReferenceException ex79 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex79;
				goto IL_62dd;
			}
			goto IL_78d8;
			IL_7d7a:
			if (num != 2)
			{
				if (num == 3)
				{
					_003C_003Eu__1 = (TaskAwaiter)0;
					_003C_003E1__state = -1;
					awaiter = _003C_003Eu__1;
					goto IL_7c51;
				}
				if (num == 4)
				{
					_003C_003Eu__2 = (TaskAwaiter<Task>)0;
					_003C_003E1__state = -1;
					taskAwaiter = (TaskAwaiter<System.__Canon>)_003C_003Eu__2;
					goto IL_0dde;
				}
				bool flag229 = (object)_003C_003E4__this == null;
				text = (string)obj5;
				if (flag229)
				{
					goto IL_5daf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
				if (~(_003CgoingPublic_003E5__5 ? 1u : 0u) == 0)
				{
					if (~(_003CownRoom_003E5__2 ? 1u : 0u) == 0)
					{
						_003C_003Ec__DisplayClass185_0 obj377 = _003C_003E8__1;
						bool flag230 = _003C_003E8__1 == null;
						text = (string)obj5;
						text2 = (string)472;
						ex = null;
						if (flag230)
						{
							goto IL_6508;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
						object obj378 = 0;
						object obj379 = obj378;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6246 @ X0_v480+E4]");
						bool flag231 = (nint)0 == 0;
						object obj380 = !flag231;
						if (obj380 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text37 = NewPublicCode();
						string text38 = obj377.prefix + text37;
						text2 = null;
						string text39 = text38;
					}
					else
					{
						text2 = (string)472;
						string text39 = null;
					}
				}
				else
				{
					_003C_003Ec__DisplayClass185_0 obj381 = _003C_003E8__1;
					bool flag232 = _003C_003E8__1 == null;
					text = (string)obj5;
					text2 = (string)472;
					ex = null;
					if (flag232)
					{
						goto IL_654d;
					}
					string text40 = obj381.prefix + code;
					text2 = null;
					string text39 = text40;
				}
				object obj383 = default;
				object obj382 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 8));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Func<System.__Canon> func;
				if (~(_003CgoingPublic_003E5__5 ? 1u : 0u) != 0 || ~(_003CownRoom_003E5__2 ? 1u : 0u) == 0)
				{
					func = null;
					text = (string)obj5;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA850]");
					object obj384 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE458]");
					object obj385 = 0;
					Func<System.__Canon> func2 = default;
					func2._002Ector((object)_003C_003E8__1, (IntPtr)obj385);
					func = func2;
					text = null;
					text2 = (string)obj385;
				}
				object obj386 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_003C_003Ec__DisplayClass185_0 obj387 = _003C_003E8__1;
				bool flag233 = _003C_003E8__1 == null;
				ex = (Exception)(object)func;
				if (flag233)
				{
					goto IL_5df4;
				}
				string text41 = _003CkindCode_003E5__6;
				bool flag234 = _003CkindCode_003E5__6 == null;
				ex = (Exception)(object)func;
				_Canon = (System.__Canon)(object)_003CkindCode_003E5__6;
				if (flag234)
				{
					goto IL_5e39;
				}
				string text43;
				if (text41._stringLength > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
					object obj388 = 0;
					string text42 = _003CkindCode_003E5__6 + (string)obj388;
					text43 = text42;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj389 = 0;
					text43 = (string)obj389;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBED0]");
				object obj390 = 0;
				string text44 = obj387.prefix + text43 + (string)obj390;
				object obj391 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 392));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj392 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 376));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Unity.IL2CPP.Metadata.__Il2CppByteEnum? _Il2CppByteEnum = (Unity.IL2CPP.Metadata.__Il2CppByteEnum)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5970]");
				object obj393 = 0;
				text2 = (string)obj393;
				bool? flag235 = _003CgoingPublic_003E5__5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj394 = 0;
				object obj395 = obj394;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7783 @ X0_v414+E4]");
				bool flag236 = (nint)0 == 0;
				object obj396 = !flag236;
				if (obj396 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj395 = obj394;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7783 @ X0_v414+A0]");
				object obj397 = 0;
				int value = (int)obj397;
				if ((nint)obj397 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7783 @ X0_v414+E4]");
					bool flag237 = (nint)0 == 0;
					object obj398 = !flag237;
					if (obj398 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj399 = obj394;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8188 @ X8_v300+A0]");
						object obj400 = 0;
						value = (int)obj400;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
					object obj401 = 0;
					text2 = (string)obj401;
					int? num87 = value;
				}
				object obj402 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 408));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj403 = obj394;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8326 @ X0_v419+E4]");
				bool flag238 = (nint)0 == 0;
				object obj404 = !flag238;
				if (obj404 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj403 = obj394;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8326 @ X0_v419+A0]");
				object obj405 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8328 @ X8_v267+30]");
				ex = (Exception)0;
				object obj406 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 416));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag239 = (object)gameObject == null;
				text = null;
				if (flag239)
				{
					goto IL_5e7e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3D8]");
				object obj407 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				object obj408 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 96));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3E8]");
				object obj409 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				object obj410 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj383, 88));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
				bool flag240 = (nint)0 == 0;
				text = null;
				Exception ex80 = default;
				ex = ex80;
				if (flag240)
				{
					goto IL_5ec3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
				object obj411 = default;
				Task<StartGameResult> task6 = ((NetworkRunner)0).StartGame((StartGameArgs)(&obj411));
				object obj412 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 168));
				obj412 = task6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE438]");
				object obj413 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				System.__Canon _Canon9 = default;
				bool flag241 = _Canon9 == null;
				text = null;
				text2 = null;
				ex = (Exception)2;
				_Canon = _Canon9;
				if (flag241)
				{
					goto IL_5f08;
				}
				bool flag242 = obj412 == null;
				UnityEngine.Object obj414 = (UnityEngine.Object)2;
				_Canon = _Canon9;
				if (!flag242)
				{
					nint num88 = (nint)_Canon9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6863 @ X8_v293 (Il2CppClass<System.__Canon>)+40]");
					obj414 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					NullReferenceException ex28 = default;
					bool flag243 = ex28 == null;
					_Canon = (System.__Canon)(object)ex28;
					text = null;
					text2 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6863 @ X8_v293 (Il2CppClass<System.__Canon>)+40]");
					obj19 = (UnityEngine.Object)0;
					if (flag243)
					{
						goto IL_619b;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6837 @ X0_v437 (System.__Canon)+18]");
				bool flag244 = (nint)0 == 0;
				text = null;
				text2 = null;
				ex = (Exception)(object)obj414;
				if (flag244)
				{
					goto IL_5f4d;
				}
				object obj415 = _Canon9 + 32;
				obj415 = obj412;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
				object obj416 = 0;
				object obj417 = obj416;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9259 @ X0_v442+E4]");
				bool flag245 = (nint)0 == 0;
				object obj418 = !flag245;
				if (obj418 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Task task7 = Task.Delay(_003CstartWait_003E5__12);
				bool flag246 = task7 == null;
				Exception ex81 = null;
				_Canon = (System.__Canon)(object)task7;
				if (!flag246)
				{
					nint num89 = (nint)_Canon9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7167 @ X8_v292 (Il2CppClass<System.__Canon>)+40]");
					ex81 = (Exception)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					ArgumentNullException ex30 = default;
					bool flag247 = ex30 == null;
					_Canon = (System.__Canon)(object)ex30;
					text = null;
					text2 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7167 @ X8_v292 (Il2CppClass<System.__Canon>)+40]");
					ex = (Exception)0;
					if (flag247)
					{
						goto IL_61ef;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6837 @ X0_v437 (System.__Canon)+18]");
				object obj419 = 0 & 0xFFFFFFFEL;
				bool flag248 = obj419 == null;
				text = null;
				text2 = null;
				ex = ex81;
				if (flag248)
				{
					goto IL_5f92;
				}
				object obj420 = _Canon9 + 40;
				obj420 = task7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Task<Task> task8 = Task.WhenAny((Task[])(object)_Canon9);
				bool flag249 = task8 == null;
				text = null;
				text2 = null;
				ex = null;
				_Canon = (System.__Canon)(object)task8;
				if (flag249)
				{
					goto IL_5fd7;
				}
				TaskAwaiter<System.__Canon> awaiter7 = ((Task<System.__Canon>)(object)task8).GetAwaiter();
				TaskAwaiter<System.__Canon> awaiter8 = default;
				bool isCompleted4 = awaiter8.IsCompleted;
				bool flag250 = !isCompleted4;
				text = null;
				text2 = null;
				taskAwaiter = awaiter8;
				if (flag250)
				{
					_003C_003E1__state = 2;
					object obj421 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 160));
					obj421 = awaiter8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj422 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9511 @ X0_v458+E4]");
					bool flag251 = (nint)0 == 0;
					object obj423 = !flag251;
					if (obj423 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3A0]");
					object obj424 = 0;
					text = (string)obj424;
					AsyncTaskMethodBuilder asyncTaskMethodBuilder6 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder6)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, _003CJoinCore_003Ed__185>(ref awaiter8, ref this);
					text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
					ex = (Exception)(&awaiter8);
					_Canon = (System.__Canon)asyncTaskMethodBuilder6;
					goto IL_58dd;
				}
			}
			else
			{
				_003C_003Eu__2 = (TaskAwaiter<Task>)0;
				_003C_003E1__state = -1;
				text = (string)obj5;
				taskAwaiter = (TaskAwaiter<System.__Canon>)_003C_003Eu__2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE410]");
			object obj425 = 0;
			obj135 = (UnityEngine.Object)obj425;
			_Canon = taskAwaiter.GetResult();
			if ((object)_Canon != _003Cstarting_003E5__14)
			{
				_003C_003Ec__DisplayClass185_0 obj426 = _003C_003E8__1;
				bool flag252 = _003C_003E8__1 == null;
				ex = (Exception)obj425;
				if (flag252)
				{
					goto IL_601c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj427 = 0;
				num3 = (float)_003CstartWait_003E5__12 / 1.1488461E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4F0]");
				object format6 = 0;
				object obj428 = default;
				string message10 = string.Format((string)format6, obj426.prefix, code, obj428);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj429 = 0;
				object obj430 = obj429;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5974 @ X0_v361+E4]");
				bool flag253 = (nint)0 == 0;
				object obj431 = !flag253;
				if (obj431 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE180]");
				object obj432 = 0;
				object obj433 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 120));
				obj433 = obj432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj434 = 0;
				object obj435 = obj434;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6382 @ X0_v367+E4]");
				bool flag254 = (nint)0 == 0;
				object obj436 = !flag254;
				if (obj436 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag255 = _003C_003E4__this == null;
				bool flag256 = !flag255;
				object obj437 = !flag256;
				PlayerRef? playerRef2 = (PlayerRef?)(object)0;
				object obj438 = 1148846080;
				obj5 = obj428;
				text2 = null;
				if (obj437 != null)
				{
					goto IL_5775;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj439 = 0;
				object obj440 = obj439;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6741 @ X0_v371+E4]");
				bool flag257 = (nint)0 == 0;
				object obj441 = !flag257;
				if (obj441 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE470]");
				object obj442 = 0;
				text13 = (string)obj442;
				Task task9 = Leave(_003CmineRunner_003E5__11, (string)obj442);
				bool flag258 = task9 == null;
				playerRef2 = (PlayerRef?)(object)0;
				obj438 = 1148846080;
				text = (string)obj428;
				text2 = null;
				_Canon = (System.__Canon)(object)task9;
				if (flag258)
				{
					goto IL_64b3;
				}
				TaskAwaiter awaiter9 = task9.GetAwaiter();
				bool isCompleted5 = awaiter.IsCompleted;
				bool flag259 = !isCompleted5;
				object obj443 = !flag259;
				playerRef2 = (PlayerRef?)(object)0;
				obj438 = 1148846080;
				obj5 = obj428;
				text2 = null;
				if (obj443 == null)
				{
					_003C_003E1__state = 3;
					object obj444 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 144));
					obj444 = awaiter;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj445 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7507 @ X0_v381+E4]");
					bool flag260 = (nint)0 == 0;
					object obj446 = !flag260;
					if (obj446 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3A8]");
					object obj447 = 0;
					text = (string)obj447;
					AsyncTaskMethodBuilder asyncTaskMethodBuilder7 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder7)->AwaitUnsafeOnCompleted<TaskAwaiter, _003CJoinCore_003Ed__185>(ref awaiter, ref this);
					playerRef2 = (PlayerRef?)(object)0;
					obj438 = 1148846080;
					text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
					ex = (Exception)(&awaiter);
					_Canon = (System.__Canon)asyncTaskMethodBuilder7;
					goto IL_58dd;
				}
				goto IL_7c51;
			}
			if (_Canon != null)
			{
				System.__Canon result2 = ((Task<System.__Canon>)(object)_Canon).Result;
				object obj448 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 112));
				obj448 = result2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj5 = text;
				goto IL_2085;
			}
			goto IL_62dd;
			IL_6b97:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num90 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag261 = num90 != 0;
			ex = (Exception)obj47;
			if (!flag261)
			{
				NullReferenceException ex82 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex82;
				goto IL_6be4;
			}
			goto IL_78d8;
			IL_702a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag262 = num91 != 0;
			ex = (Exception)obj47;
			if (!flag262)
			{
				NullReferenceException ex83 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex83;
				goto IL_7077;
			}
			goto IL_78d8;
			IL_8225:
			object obj449 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
			obj449 = text12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (~(probe ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E8]");
				text12 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E8]");
				obj449 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			_ = kind;
			string text45 = code;
			if (code == null)
			{
				goto IL_6e54;
			}
			object obj450 = obj53;
			bool flag263 = text45._stringLength == 0;
			_003CgoingPublic_003E5__5 = flag263;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8871 @ X0_v926+E4]");
			bool flag264 = (nint)0 == 0;
			object obj451 = !flag264;
			if (obj451 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text46 = KindCode(kind);
			object obj452 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 88));
			obj452 = text46;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string prefix = _003C_003E4__this.Prefix;
			bool flag265 = obj8 == null;
			text12 = prefix;
			_Canon = (System.__Canon)(object)prefix;
			if (flag265)
			{
				goto IL_6ea1;
			}
			object obj453 = obj8 + 16;
			obj453 = prefix;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3C8]");
			object obj454 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			SessionProperty sessionProperty = (int)kind;
			bool flag266 = dictionary == null;
			obj47 = null;
			_Canon = (System.__Canon)(object)sessionProperty;
			if (flag266)
			{
				goto IL_6ef6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBED8]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3B0]");
			object obj455 = 0;
			text = (string)obj455;
			dictionary.Add((System.__Canon)key, (System.__Canon)(object)sessionProperty);
			object obj456 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 96));
			obj456 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Lobby? lobby9 = CarriedKind((string)obj40);
			object obj457 = (_003F?)lobby9 & 0xFF;
			bool flag267 = obj457 == null;
			System.__Canon _Canon10 = (System.__Canon)(object)sessionProperty;
			System.__Canon _Canon11 = dictionary;
			if (!flag267)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E0]");
				SessionProperty sessionProperty2 = 0;
				bool flag268 = obj456 == null;
				text2 = sessionProperty;
				obj47 = null;
				_Canon = (System.__Canon)(object)sessionProperty2;
				if (flag268)
				{
					goto IL_7077;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1A0]");
				object obj458 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3C0]");
				object obj459 = 0;
				_Canon11 = (System.__Canon)obj458;
				text = (string)obj459;
				((Dictionary<System.__Canon, System.__Canon>)obj456).set_Item((System.__Canon)obj458, (System.__Canon)(object)sessionProperty2);
				_Canon10 = (System.__Canon)(object)sessionProperty2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj460 = 0;
			object obj461 = obj460;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9385 @ X0_v947+E4]");
			bool flag269 = (nint)0 == 0;
			object obj462 = !flag269;
			if (obj462 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
			bool flag270 = (UnityEngine.Object)0 != null;
			bool flag271 = !flag270;
			obj130 = obj;
			num5 = num3;
			text14 = null;
			obj139 = null;
			if (flag271)
			{
				goto IL_04da;
			}
			object obj463 = obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9463 @ X0_v951+E4]");
			bool flag272 = (nint)0 == 0;
			object obj464 = !flag272;
			if (obj464 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE548]");
			object obj465 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+B0]");
			Task task10 = Leave((NetworkRunner)0, (string)obj465);
			bool flag273 = task10 == null;
			text2 = null;
			lobby3 = (Lobby)obj465;
			_Canon = (System.__Canon)(object)task10;
			if (flag273)
			{
				goto IL_70cc;
			}
			TaskAwaiter awaiter10 = task10.GetAwaiter();
			bool isCompleted6 = awaiter.IsCompleted;
			bool flag274 = !isCompleted6;
			object obj466 = !flag274;
			obj5 = text;
			text3 = null;
			if (obj466 == null)
			{
				_003C_003E1__state = 0;
				object obj467 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 144));
				obj467 = awaiter;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj468 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9540 @ X0_v961+E4]");
				bool flag275 = (nint)0 == 0;
				object obj469 = !flag275;
				if (obj469 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3A8]");
				object obj470 = 0;
				text = (string)obj470;
				AsyncTaskMethodBuilder asyncTaskMethodBuilder8 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder8)->AwaitUnsafeOnCompleted<TaskAwaiter, _003CJoinCore_003Ed__185>(ref awaiter, ref this);
				text2 = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				ex = (Exception)(&awaiter);
				_Canon = (System.__Canon)asyncTaskMethodBuilder8;
				goto IL_58dd;
			}
			goto IL_7fd5;
			IL_6c7e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num92 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag276 = num92 != 0;
			ex = (Exception)obj47;
			if (!flag276)
			{
				NullReferenceException ex84 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex84;
				goto IL_6ccb;
			}
			goto IL_78d8;
			IL_5daf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num93 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num93 == 0)
			{
				NullReferenceException ex85 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex85;
				goto IL_5df4;
			}
			goto IL_78d8;
			IL_5df4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num94 == 0)
			{
				NullReferenceException ex86 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex86;
				goto IL_5e39;
			}
			goto IL_78d8;
			IL_5e7e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num95 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num95 == 0)
			{
				NullReferenceException ex87 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex87;
				goto IL_5ec3;
			}
			goto IL_78d8;
			IL_6a5b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag277 = num96 != 0;
			ex = (Exception)(object)text8;
			if (!flag277)
			{
				NullReferenceException ex88 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex88;
				goto IL_6aa8;
			}
			goto IL_78d8;
			IL_4f06:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj471 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag278 = _Canon == null;
			text = (string)obj5;
			text2 = null;
			lobby3 = (Lobby)7;
			if (!flag278)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE510]");
				object obj472 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj473 = 0;
				object obj474 = obj473;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7848 @ X0_v259+E4]");
				bool flag279 = (nint)0 == 0;
				object obj475 = !flag279;
				if (obj475 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text47 = Shown(code);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE550]");
				object obj476 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				string text48 = LabelOf(kind);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE478]");
				object obj477 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E0]");
				string text49 = LabelOf((Lobby)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE4A0]");
				object obj478 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				string message11 = string.Concat((string[])(object)_Canon);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj479 = 0;
				object obj480 = obj479;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8984 @ X0_v281+E4]");
				bool flag280 = (nint)0 == 0;
				object obj481 = !flag280;
				if (obj481 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message11);
				string text50 = Shown(code);
				object obj482 = _003C_003E4__this + 152;
				obj482 = text50;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E8]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E0]");
				_ = 0;
				NetworkBootstrap networkBootstrap5 = _003C_003E4__this;
				Lobby lobby10 = kind;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+E8]");
				networkBootstrap5.Join(lobby10, (string)0, probe: false);
				obj5 = null;
				goto IL_5775;
			}
			goto IL_729a;
			IL_6966:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num97 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag281 = num97 != 0;
			ex = (Exception)obj41;
			if (!flag281)
			{
				ArgumentNullException ex5 = new ArgumentNullException();
				ex = null;
				goto IL_69ba;
			}
			goto IL_78d8;
			IL_69ba:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num98 == 0)
			{
				ArgumentNullException ex89 = new ArgumentNullException();
				text8 = null;
				_Canon = (System.__Canon)(object)ex89;
				goto IL_6a0e;
			}
			goto IL_78d8;
			IL_5f08:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num99 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num99 == 0)
			{
				NullReferenceException ex90 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex90;
				goto IL_5f4d;
			}
			goto IL_78d8;
			IL_5ec3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num100 == 0)
			{
				NullReferenceException ex91 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex91;
				goto IL_5f08;
			}
			goto IL_78d8;
			IL_5f92:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num101 == 0)
			{
				IndexOutOfRangeException ex92 = new IndexOutOfRangeException();
				_Canon = (System.__Canon)(object)ex92;
				goto IL_5fd7;
			}
			goto IL_78d8;
			IL_5f4d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num102 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num102 == 0)
			{
				IndexOutOfRangeException ex93 = new IndexOutOfRangeException();
				_Canon = (System.__Canon)(object)ex93;
				goto IL_5f92;
			}
			goto IL_78d8;
			IL_6dff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num103 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag282 = num103 != 0;
			ex = (Exception)obj47;
			if (!flag282)
			{
				NullReferenceException ex94 = new NullReferenceException();
				text12 = (string)obj47;
				_Canon = (System.__Canon)(object)ex94;
				goto IL_6e54;
			}
			goto IL_78d8;
			IL_601c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			if (num104 == 0)
			{
				NullReferenceException ex73 = new NullReferenceException();
				ex56 = ex;
				goto IL_6061;
			}
			goto IL_78d8;
			IL_6db2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num105 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag283 = num105 != 0;
			ex = (Exception)obj47;
			if (!flag283)
			{
				NullReferenceException ex95 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex95;
				goto IL_6dff;
			}
			goto IL_78d8;
			IL_759c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num106 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag284 = num106 != 0;
			ex = (Exception)lobby3;
			if (!flag284)
			{
				NullReferenceException ex96 = new NullReferenceException();
				ex = (Exception)lobby3;
				_Canon = (System.__Canon)(object)ex96;
				goto IL_75f1;
			}
			goto IL_78d8;
			IL_7fd5:
			awaiter.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj483 = 0;
			object obj484 = obj483;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v6+E4]");
			bool flag285 = (nint)0 == 0;
			object obj485 = !flag285;
			if (obj485 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag286 = _003C_003E4__this == null;
			bool flag287 = !flag286;
			object obj486 = !flag287;
			text2 = null;
			if (obj486 == null)
			{
				bool flag288 = (object)_003C_003E4__this == null;
				text = (string)obj5;
				text2 = null;
				obj135 = null;
				_Canon = (System.__Canon)flag286;
				if (flag288)
				{
					goto IL_6290;
				}
				int num107 = _003Cmine_003E5__3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v2 (UnityEngine.Object)+128]");
				bool flag289 = (nint)num107 != 0;
				obj130 = obj;
				num5 = num3;
				text = (string)obj5;
				text14 = null;
				obj139 = null;
				text2 = null;
				if (!flag289)
				{
					goto IL_04da;
				}
			}
			goto IL_5775;
			IL_7468:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num108 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag290 = num108 != 0;
			ex = (Exception)lobby3;
			if (!flag290)
			{
				NullReferenceException ex97 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex97;
				goto IL_74b5;
			}
			goto IL_78d8;
			IL_6f43:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			nint num109 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
			bool flag291 = num109 != 0;
			ex = (Exception)obj47;
			if (!flag291)
			{
				NullReferenceException ex98 = new NullReferenceException();
				_Canon = (System.__Canon)(object)ex98;
				goto IL_6f90;
			}
			goto IL_78d8;
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			//IL_002f: Expected VT, but got Ref
			//IL_003c: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}
	}

	private sealed class _003CJoinOnceCleared_003Ed__143 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkBootstrap _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CJoinOnceCleared_003Ed__143(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0106: Expected Obj, but got I
			//IL_0115: Expected I4, but got I8
			//IL_013f: Expected Obj, but got I4
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected Obj, but got Unknown
			//IL_0037: Expected Obj, but got I
			//IL_0046: Expected I4, but got I8
			//IL_0070: Expected Obj, but got I4
			//IL_01a0: Expected I4, but got Obj
			//IL_00e2: Expected Obj, but got I
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj = 0;
					_003C_003E1__state = -1;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v11+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (GillaIntegrity.Cleared)
					{
						if ((object)_003C_003E4__this == null)
						{
							NullReferenceException ex = new NullReferenceException();
							return (byte)(int)ex != 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object code = 0;
						_003C_003E4__this.JoinRoom((string)code);
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
				object obj4 = 0;
				_003C_003E1__state = -1;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				IEnumerator enumerator = GillaIntegrity.WaitForVerdict();
				object obj7 = this + 24;
				obj7 = enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 1;
			}
			return _003C_003E1__state == 0;
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

	public NetworkObject apePrefab;

	public string roomName;

	public const int NetVersion = default(int);

	public const int PublicCodeLength = default(int);

	private const float StrangeRoomFor = default(float);

	public const string CodeChars = null;

	public static int TestRoomSize;

	public static int FullRoomsMet;

	public const string PlayTestRooms = null;

	public Transform head;

	public Transform leftHand;

	public Transform rightHand;

	public ApeColor localColor;

	public MicLevel mic;

	public HandPoser fingersL;

	public HandPoser fingersR;

	public DismemberGroup tearing;

	public Recorder voice;

	private static NetworkBootstrap Instance__BackingField;

	private string RoomLabel__BackingField;

	private static string signInSaid;

	private static string signInWhy;

	private static string loginWhy;

	private static string LoginDetail__BackingField;

	private string JoinDetail__BackingField;

	private string joinWhy;

	public static FusionAppSettings TestAppSettings;

	private Lobby Kind__BackingField;

	private string WaitingCode__BackingField;

	private Lobby WaitingKind__BackingField;

	private const string KindProperty = null;

	private const string HomeProperty = null;

	private bool Joining__BackingField;

	public const float SettleSeconds = default(float);

	private float joinedAt;

	private const string PlayerIdKey = null;

	private static string playerId;

	private NetworkRunner runner;

	private string joining;

	private string queued;

	private Lobby queuedKind;

	private bool waitingOnAuth;

	private string pendingCode;

	private string carrying;

	private Lobby carryingHome;

	private string probeBack;

	private int fullTries;

	private bool freshPublic;

	private const int MostFullTries = default(int);

	private static readonly System.Random pick;

	private bool micAllowed;

	private float micLookAt;

	private const float CloseWaits = default(float);

	private bool RoomClosedForTest__BackingField;

	private const float ReloginFirst = default(float);

	private const float ReloginEvery = default(float);

	private bool wasIn;

	private bool rejoining;

	private Lobby rejoinKind;

	private string rejoinCode;

	private float rejoinAt;

	private float rejoinWait;

	private bool quitting;

	private const float RejoinFirst = default(float);

	private const float RejoinMost = default(float);

	private const int ShutdownWait = default(int);

	private const int TicketWait = default(int);

	private const int StartWait = default(int);

	public static int TestStartWait;

	public static bool TestJoinThrows;

	private const float IdleRetry = default(float);

	private const float JoiningMost = default(float);

	private float idleSince;

	private float joiningSince;

	private bool authWas;

	private int joinTurn;

	public static bool ShiftAuthNeeded
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00f5: Expected Obj, but got I4
			//IL_0068: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I4
			//IL_00c6: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I4
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4;
			if (ShiftAuth.HasDevKey)
			{
				obj4 = 1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool isDebugBuild = Debug.isDebugBuild;
				obj4 = (isDebugBuild ? 1 : 0) ^ 1;
			}
			return (byte)(obj4 & 1) != 0;
		}
	}

	public static string RoomTag
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (string)result;
		}
	}

	private static bool InPlayTest => false;

	public static NetworkBootstrap Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return (NetworkBootstrap)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string RoomLabel
	{
		get
		{
			return RoomLabel__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string OfflineWhy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0696: Expected Obj, but got I4
			//IL_06ce: Expected Obj, but got I4
			//IL_072b: Expected Obj, but got I
			//IL_073b: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I
			//IL_01b7: Expected Obj, but got I
			//IL_01e4: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I4
			//IL_021b: Expected Obj, but got I
			//IL_00e5: Expected Obj, but got I
			//IL_010f: Expected Obj, but got I4
			//IL_0230: Expected Obj, but got I
			//IL_025a: Expected Obj, but got I4
			//IL_017c: Expected Obj, but got I4
			//IL_0314: Expected Obj, but got I
			//IL_033e: Expected Obj, but got I4
			//IL_05c8: Expected Obj, but got I
			//IL_03ab: Expected Obj, but got I4
			//IL_02f1: Expected Obj, but got I4
			//IL_03fe: Expected Obj, but got I
			//IL_0428: Expected Obj, but got I4
			//IL_06ec: Expected Obj, but got I
			//IL_0633: Expected Obj, but got I4
			//IL_04cf: Expected Obj, but got I
			//IL_04f9: Expected Obj, but got I4
			//IL_0604: Expected Obj, but got I
			//IL_058c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7+11]");
			if ((nint)0 != 0)
			{
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v70+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return BanSaid();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFA0]");
			object obj10 = 0;
			if (RoomLabel__BackingField == (string)obj10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v60+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (GillaModeration.Kicked)
				{
					object obj14 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v65+E4]");
					bool flag5 = (nint)0 == 0;
					object obj15 = !flag5;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return KickSaid();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
			object obj16 = 0;
			bool flag6 = RoomLabel__BackingField != (string)obj16;
			bool flag7 = !flag6;
			object obj17 = !flag7;
			if (obj17 != null || ~(Joining__BackingField ? 1u : 0u) == 0)
			{
				goto IL_020b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj20 = !flag8;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
			bool flag10 = !flag9;
			UnityEngine.Object obj21 = null;
			if (!flag10)
			{
				if ((object)runner == null)
				{
					goto IL_065e;
				}
				bool isRunning = runner.IsRunning;
				bool flag11 = !isRunning;
				object obj22 = !flag11;
				obj21 = null;
				if (obj22 != null)
				{
					goto IL_020b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v23+E4]");
			bool flag12 = (nint)0 == 0;
			object obj25 = !flag12;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text;
			object obj40;
			if (GillaIntegrity.Cleared)
			{
				object obj26 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v28+E4]");
				bool flag13 = (nint)0 == 0;
				object obj27 = !flag13;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (ShiftAuthNeeded)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v48+E4]");
					bool flag14 = (nint)0 == 0;
					object obj30 = !flag14;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj29 = obj28;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v48+A0]");
					object obj31 = 0;
					if (obj31 == null)
					{
						object obj32 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v50+E4]");
						bool flag15 = (nint)0 == 0;
						object obj33 = !flag15;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						return SigningInWhy();
					}
				}
				text = joinWhy;
				if (joinWhy == null)
				{
					goto IL_065e;
				}
				if (text._stringLength > 0)
				{
					goto IL_0709;
				}
				if (Rejoining)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
					object obj34 = 0;
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v37+E4]");
					bool flag16 = (nint)0 == 0;
					object obj36 = !flag16;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F5D1D4");
					object obj37 = default;
					if (obj37 == null)
					{
						goto IL_065e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v40+10]");
					if ((nint)0 >= (nint)1)
					{
						object obj38 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v41+E4]");
						bool flag17 = (nint)0 == 0;
						object obj39 = !flag17;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F5D1D4");
						string result = default;
						return result;
					}
				}
				if (!Rejoining)
				{
					goto IL_020b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF90]");
				obj40 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF98]");
				obj40 = 0;
			}
			goto IL_070e;
			IL_065e:
			return (string)(object)new NullReferenceException();
			IL_070e:
			text = (string)obj40;
			goto IL_0709;
			IL_020b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			obj40 = 0;
			goto IL_070e;
			IL_0709:
			return text;
		}
	}

	public static string LoginDetail
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+28]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = (nint)0 + (nint)40;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string JoinDetail
	{
		get
		{
			return JoinDetail__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 128;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool IsPublicRoom
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I4
			//IL_013c: Expected I4, but got Obj
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
			if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
			{
				if ((object)runner == null)
				{
					goto IL_012e;
				}
				if (runner.IsRunning)
				{
					NetworkRunner networkRunner = runner;
					if ((object)runner == null)
					{
						goto IL_012e;
					}
					SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
					if (networkRunner.SessionInfo__BackingField != null)
					{
						bool flag2 = !sessionInfo._isVisible;
						return !flag2;
					}
				}
			}
			return false;
			IL_012e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public string RoomName
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0183: Expected Obj, but got I4
			//IL_013e: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I4
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
			string result;
			if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
			{
				if ((object)runner == null)
				{
					goto IL_014b;
				}
				if (runner.IsRunning)
				{
					NetworkRunner networkRunner = runner;
					if ((object)runner == null)
					{
						goto IL_014b;
					}
					SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
					if (networkRunner.SessionInfo__BackingField != null)
					{
						result = sessionInfo.Name__BackingField;
						bool flag2 = sessionInfo.Name__BackingField == null;
						object obj4 = !flag2;
						if (obj4 != null)
						{
							goto IL_0191;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj5 = 0;
			result = (string)obj5;
			goto IL_0191;
			IL_0191:
			return result;
			IL_014b:
			return (string)(object)new NullReferenceException();
		}
	}

	public Lobby Kind
	{
		get
		{
			return Kind__BackingField;
		}
		private set
		{
			Kind__BackingField = value;
		}
	}

	public string KindLabel
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0062: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return LabelOf(Kind__BackingField);
		}
	}

	public Lobby Going
	{
		get
		{
			//IL_0039: Expected Obj, but got I4
			//IL_002b: Expected Obj, but got I4
			if (queued == null)
			{
				object obj = 144;
			}
			else
			{
				object obj = 200;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NetworkBootstrap)+v16 @ X8_v2]");
			return (Lobby)0;
		}
	}

	public string WaitingCode
	{
		get
		{
			return WaitingCode__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public Lobby WaitingKind
	{
		get
		{
			return WaitingKind__BackingField;
		}
		private set
		{
			WaitingKind__BackingField = value;
		}
	}

	public string RoomCode
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0243: Expected Obj, but got I4
			//IL_0133: Expected Obj, but got I
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
			string result;
			if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
			{
				if ((object)runner != null)
				{
					if (!runner.IsRunning)
					{
						goto IL_0123;
					}
					NetworkRunner networkRunner = runner;
					if ((object)runner != null)
					{
						SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
						if (networkRunner.SessionInfo__BackingField == null || string.IsNullOrEmpty(sessionInfo.Name__BackingField))
						{
							goto IL_0123;
						}
						string prefix = Prefix;
						if (sessionInfo.Name__BackingField != null)
						{
							bool flag2 = sessionInfo.Name__BackingField.StartsWith(prefix);
							result = sessionInfo.Name__BackingField;
							if (!flag2)
							{
								goto IL_0251;
							}
							if (prefix != null && sessionInfo.Name__BackingField != null)
							{
								return sessionInfo.Name__BackingField.Substring(prefix._stringLength);
							}
						}
					}
				}
				return (string)(object)new NullReferenceException();
			}
			goto IL_0123;
			IL_0251:
			return result;
			IL_0123:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj4 = 0;
			result = (string)obj4;
			goto IL_0251;
		}
	}

	private string Prefix
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0044: Expected Obj, but got I
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected Obj, but got Unknown
			//IL_0090: Expected Obj, but got I4
			//IL_00ca: Expected Obj, but got I8
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I4
			//IL_013f: Expected Obj, but got I
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Expected Obj, but got Unknown
			//IL_0182: Expected Obj, but got I
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected Obj, but got Unknown
			//IL_01ce: Expected Obj, but got I8
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected Obj, but got Unknown
			//IL_022d: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got I
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Expected Obj, but got Unknown
			//IL_0286: Expected Obj, but got I
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] array = default;
			if (array != null)
			{
				if (array.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
					object obj2 = 0;
					object obj3 = array + 32;
					obj3 = roomName;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v12+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string roomTag = RoomTag;
					object obj6 = array.Length & 0xFFFFFFFEL;
					if (obj6 != null)
					{
						object obj7 = array + 40;
						obj7 = roomTag;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X20_v7-10]");
						bool flag2 = (nint)0 < (nint)2;
						object obj8 = !flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X20_v7-10]");
						object obj9 = -2;
						bool flag3 = obj9 == null;
						object obj10 = ~obj8;
						object obj11 = obj10 | flag3;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF78]");
							object obj12 = 0;
							object obj13 = array + 48;
							obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							int num = default;
							string text = num.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X20_v9-18]");
							object obj14 = 0 & 0xFFFFFFFCL;
							if (obj14 != null)
							{
								object obj15 = array + 56;
								obj15 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X20_v11-20]");
								bool flag4 = (nint)0 < (nint)4;
								object obj16 = !flag4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X20_v11-20]");
								object obj17 = -4;
								bool flag5 = obj17 == null;
								object obj18 = ~obj16;
								object obj19 = obj18 | flag5;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
									object obj20 = 0;
									object obj21 = array + 64;
									obj21 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									return string.Concat(array);
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public bool Joining
	{
		get
		{
			return Joining__BackingField;
		}
		private set
		{
			Joining__BackingField = value;
		}
	}

	public NetworkRunner Runner => runner;

	public int PlayerCount
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_014c: Expected Obj, but got I4
			//IL_0122: Expected I4, but got Obj
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
			if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
			{
				if ((object)runner == null)
				{
					goto IL_0114;
				}
				if (runner.IsRunning)
				{
					NetworkRunner networkRunner = runner;
					if ((object)runner == null)
					{
						goto IL_0114;
					}
					SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
					if (networkRunner.SessionInfo__BackingField != null)
					{
						return sessionInfo.PlayerCount__BackingField;
					}
				}
			}
			return 0;
			IL_0114:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public bool Settled
	{
		get
		{
			//IL_0199: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0183: Expected I4, but got Obj
			//IL_010b: Invalid comparison between F4 and I4
			//IL_0123: Expected Obj, but got F8
			//IL_0130: Expected Obj, but got F4
			bool flag = (byte)(~(Joining__BackingField ? 1u : 0u)) != 0;
			object obj = !flag;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)runner != (UnityEngine.Object)null)
				{
					if ((object)runner == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (runner.IsRunning)
					{
						float unscaledTime = Time.unscaledTime;
						float num = unscaledTime - joinedAt;
						float num2 = num - 5f;
						bool flag3 = num2 < 0f;
						object obj5 = (double)num ^ 5.0;
						object obj6 = num ^ num2;
						object obj7 = obj5 & obj6;
						bool flag4 = (nint)obj7 < 0;
						return flag3 == flag4;
					}
				}
			}
			return false;
		}
	}

	public static string PlayerId
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_02d3: Expected Obj, but got I4
			//IL_038a: Expected Obj, but got I
			//IL_039a: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I
			//IL_0111: Expected Obj, but got I
			//IL_013b: Expected Obj, but got I4
			//IL_004e: Expected Obj, but got I4
			//IL_00dc: Expected Obj, but got I4
			//IL_028e: Expected Obj, but got I
			//IL_02fc: Expected Obj, but got I
			//IL_0269: Expected Obj, but got I
			//IL_0279: Expected Obj, but got I
			//IL_01dd: Expected Obj, but got I
			//IL_01ed: Expected Obj, but got I
			//IL_022c: Expected Obj, but got I4
			//IL_0331: Expected Obj, but got I
			//IL_035b: Expected Obj, but got I
			//IL_0370: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+38]");
			string result = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					goto IL_0251;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1A8]");
				object key = 0;
				if (PlayerPrefs.HasKey((string)key))
				{
					string text = PlayerPrefs.GetString((string)key);
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v22+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v22+A0]");
					object obj8 = (nint)0 + (nint)56;
					obj8 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = text;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v9+E4]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (Application.isPlaying)
					{
						Guid guid = Guid.NewGuid();
						Guid guid2 = default;
						byte[] array = guid2.ToByteArray();
						string text2 = BitConverter.ToString(array, 0, 8);
						if (text2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
							object oldValue = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object newValue = 0;
							string text3 = text2.Replace((string)oldValue, (string)newValue);
							object obj12 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17+E4]");
							bool flag5 = (nint)0 == 0;
							object obj13 = !flag5;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj12 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17+A0]");
							object obj14 = (nint)0 + (nint)56;
							obj14 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj15 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v18+A0]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v19+38]");
							PlayerPrefs.SetString((string)key, (string)0);
							PlayerPrefs.Save();
							goto IL_0251;
						}
						return (string)(object)new NullReferenceException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1B0]");
					object obj17 = 0;
					result = (string)obj17;
				}
			}
			goto IL_02e1;
			IL_02e1:
			return result;
			IL_0251:
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+38]");
			result = (string)0;
			goto IL_02e1;
		}
	}

	public bool RoomClosedForTest
	{
		get
		{
			return RoomClosedForTest__BackingField;
		}
		private set
		{
			RoomClosedForTest__BackingField = value;
		}
	}

	public bool Rejoining
	{
		get
		{
			//IL_006d: Expected Obj, but got I
			//IL_0097: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_013b: Expected I4, but got Obj
			bool result;
			if (~(rejoining ? 1u : 0u) != 0)
			{
				result = wasIn;
				if (~(wasIn ? 1u : 0u) == 0)
				{
					if (~(Joining__BackingField ? 1u : 0u) == 0)
					{
						result = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj = 0;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v4+E4]");
						bool flag = (nint)0 == 0;
						object obj3 = !flag;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag2 = (UnityEngine.Object)runner == (UnityEngine.Object)null;
						bool flag3 = !flag2;
						object obj4 = !flag3;
						if (obj4 != null)
						{
							goto IL_0005;
						}
						if ((object)runner == null)
						{
							NullReferenceException ex = new NullReferenceException();
							return (byte)(int)ex != 0;
						}
						bool isRunning = runner.IsRunning;
						result = (byte)((isRunning ? 1u : 0u) ^ 1u) != 0;
					}
				}
				goto IL_0154;
			}
			goto IL_0005;
			IL_0154:
			return result;
			IL_0005:
			result = true;
			goto IL_0154;
		}
	}

	public bool RejoinsByCode
	{
		get
		{
			//IL_00c2: Expected I4, but got Obj
			//IL_00a2: Expected Obj, but got I4
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected I4, but got Unknown
			string text = rejoinCode;
			if (rejoinCode != null)
			{
				bool flag = text._stringLength < 0;
				bool flag2 = text._stringLength == 0;
				int num = text._stringLength ^ text._stringLength;
				int num2 = text._stringLength & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static string KindCode(Lobby kind)
	{
		//IL_002a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		object result;
		if (kind == (Lobby)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F00]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			result = 0;
		}
		if (kind == (Lobby)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EF8]");
			result = 0;
		}
		return (string)result;
	}

	private static string Carried(Lobby kind)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
		object obj = 0;
		string text2;
		if (kind != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = KindCode(kind);
			text2 = text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF60]");
			object obj5 = 0;
			text2 = (string)obj5;
		}
		return (string)obj + text2;
	}

	private unsafe static Lobby? CarriedKind(string code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0806: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I
		//IL_0838: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got Ref
		//IL_0116: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_0924: Expected I, but got Obj
		//IL_0934: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I4
		//IL_0794: Expected Obj, but got I4
		//IL_087b: Expected Obj, but got I
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected Obj, but got Unknown
		//IL_016a: Expected Obj, but got I
		//IL_07e3: Expected VT, but got I4
		//IL_07ec: Expected Obj, but got I4
		//IL_04c5: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got Ref
		//IL_04da: Expected Obj, but got Ref
		//IL_04e3: Expected VT, but got I4
		//IL_04ec: Expected Obj, but got I4
		//IL_0969: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_09ba: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_055a: Expected I, but got Obj
		//IL_056a: Expected Obj, but got I
		//IL_0230: Expected I, but got Obj
		//IL_0240: Expected Obj, but got I
		//IL_0658: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I4
		//IL_070d: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got Ref
		//IL_0722: Expected Obj, but got Ref
		//IL_02df: Expected Obj, but got I4
		//IL_09fc: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_06c4: Expected VT, but got I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got I4
		//IL_05c0: Expected Obj, but got I
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_03fe: Expected I4, but got Obj
		//IL_0452: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I
		//IL_0516: Expected I4, but got Obj
		//IL_0527: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got Ref
		//IL_053c: Expected Obj, but got Ref
		//IL_054d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v3+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Array values = Enum.GetValues(typeFromHandle);
		bool flag3 = values == null;
		IEnumerator enumerator = null;
		string text = null;
		Type type = typeFromHandle;
		if (flag3)
		{
			goto IL_0727;
		}
		IEnumerator enumerator2 = values.GetEnumerator();
		bool flag4 = enumerator2 == null;
		object obj8 = default;
		obj6 = (object)(&obj8);
		type = typeFromHandle;
		if (flag4)
		{
			goto IL_04b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEB0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj11 = 0;
		object obj13 = default;
		object obj12 = obj13;
		object obj15 = default;
		object obj14 = obj15;
		IEnumerator enumerator3 = enumerator2;
		object obj19 = default;
		OutOfMemoryException ex3 = default;
		object obj23 = default;
		object obj27 = default;
		object obj21;
		object obj20;
		while (true)
		{
			nint num = (nint)enumerator3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v24 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v24 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v24 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj16 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X10_v28-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v24 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj6 = -1;
				obj14 = obj16 + 16;
				bool flag5 = (nint)obj6 != 1;
				obj16 = obj14;
				if (flag5)
				{
					continue;
				}
				goto IL_01bb;
			}
			obj6 = obj16;
			object obj17 = num + obj16;
			object obj18 = obj17 + 312;
			obj13 = obj12;
			obj14 = obj16;
			goto IL_086b;
			IL_06e5:
			InvalidCastException ex = new InvalidCastException();
			goto IL_06f3;
			IL_06f3:
			NullReferenceException ex2 = new NullReferenceException();
			obj15 = obj14;
			obj19 = 0;
			ex3 = null;
			obj20 = (object)(&obj8);
			obj21 = (object)(&enumerator);
			goto IL_0727;
			IL_06d7:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_06e5;
			IL_01bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj13 = 0;
			goto IL_086b;
			IL_086b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v44+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ X0_v44] (should have been resolved before IL gen)");
			object obj22 = obj23 & 1;
			bool flag6 = obj22 == null;
			obj15 = obj14;
			type = (Type)enumerator3;
			if (flag6)
			{
				break;
			}
			if (enumerator2 == null)
			{
				goto IL_06d7;
			}
			nint num2 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02cc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj24 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X10_v23-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj6 = -1;
				obj14 = obj24 + 16;
				bool flag7 = (nint)obj6 != 1;
				obj24 = obj14;
				if (flag7)
				{
					continue;
				}
				goto IL_02cc;
			}
			obj6 = obj24 + 1;
			object obj25 = num2 + obj6;
			object obj26 = obj25 + 312;
			obj14 = obj24;
			goto IL_08e5;
			IL_02cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj13 = 1;
			goto IL_08e5;
			IL_08e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v53+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v53] (should have been resolved before IL gen)");
			if (obj27 != null)
			{
				text = (string)obj10;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X1_v8 (System.String)+40]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v33+40]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X1_v8 (System.String)+40]");
				if (num3 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v55+10]");
					type = (Type)0;
					bool flag8 = string.IsNullOrEmpty(code);
					bool flag9 = !flag8;
					object obj29 = !flag9;
					if (obj29 == null)
					{
						object obj30 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v60+E4]");
						bool flag10 = (nint)0 == 0;
						object obj31 = !flag10;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text2 = Carried((Lobby)type);
						bool flag11 = code == null;
						text = text2;
						if (flag11)
						{
							goto IL_06f3;
						}
						bool flag12 = code.EndsWith(text2);
						bool flag13 = !flag12;
						object obj32 = !flag13;
						obj13 = 0;
						if (obj32 != null)
						{
							goto IL_04f1;
						}
					}
					bool flag14 = enumerator2 == null;
					object obj33 = !flag14;
					obj15 = obj14;
					type = (Type)enumerator2;
					obj12 = obj13;
					enumerator3 = enumerator2;
					if (obj33 != null)
					{
						continue;
					}
					goto IL_04b1;
				}
				goto IL_06e5;
			}
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_06d7;
		}
		obj19 = 0;
		ex3 = null;
		obj20 = (object)(&obj8);
		obj21 = (object)(&enumerator);
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
		object obj34 = 5;
		goto IL_0959;
		IL_04b1:
		throw new NullReferenceException();
		IL_0a0b:
		Lobby? result;
		return result;
		IL_0743:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)text == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj19 = 1;
		}
		else
		{
			if ((nint)text != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				Lobby? result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj35 = default;
			ex3 = (OutOfMemoryException)obj35;
		}
		_Il2CppInt32Enum = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum?)(object)0;
		obj34 = 0;
		goto IL_0959;
		IL_04f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4E0]");
		object obj36 = 0;
		obj13 = obj36;
		Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum2 = (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)type;
		obj15 = obj14;
		obj19 = 0;
		ex3 = null;
		obj20 = (object)(&obj8);
		obj21 = (object)(&enumerator);
		_Il2CppInt32Enum = _Il2CppInt32Enum2;
		obj34 = 4;
		goto IL_0959;
		IL_09a0:
		bool flag15 = ex3 == null;
		object obj37 = !flag15;
		if (obj37 != null)
		{
			goto IL_0735;
		}
		bool flag16 = obj19 == null;
		object obj38 = !flag16;
		OutOfMemoryException ex6 = ex3;
		if (obj38 != null)
		{
			goto IL_0743;
		}
		if ((nint)obj34 != 5)
		{
			bool flag17 = obj34 == null;
			object obj39 = !flag17;
			result = (Lobby?)_Il2CppInt32Enum;
			if (obj39 != null)
			{
				goto IL_0a0b;
			}
		}
		result = (Lobby?)(object)0;
		goto IL_0a0b;
		IL_0959:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj40 = 0;
		text = (string)obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		Type type2 = default;
		obj20 = type2;
		if ((object)type2 == null)
		{
			goto IL_09a0;
		}
		nint num4 = (nint)type2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10 (Il2CppClass<System.Type>)+12E]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10 (Il2CppClass<System.Type>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05f6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10 (Il2CppClass<System.Type>)+98]");
		object obj41 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X10_v7-8]");
			if (0 == (nint)obj40)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10 (Il2CppClass<System.Type>)+12E]");
			obj6 = -1;
			obj15 = obj41 + 16;
			bool flag18 = (nint)obj6 != 1;
			obj41 = obj15;
			if (flag18)
			{
				continue;
			}
			goto IL_05f6;
		}
		obj6 = obj41;
		object obj42 = num4 + obj41;
		object obj43 = obj42 + 312;
		obj15 = obj41;
		goto IL_09ec;
		IL_0735:
		ex6 = new OutOfMemoryException();
		goto IL_0743;
		IL_09ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v15+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v672 @ X0_v15] (should have been resolved before IL gen)");
		goto IL_09a0;
		IL_0727:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0735;
		IL_05f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj13 = 0;
		goto IL_09ec;
	}

	public static string Shown(string code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = default;
		Lobby? lobby = CarriedKind(text);
		object obj4 = (_003F?)lobby & 0xFF;
		if (obj4 != null)
		{
			if (text != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB4F0]");
				object obj5 = 0;
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum? _Il2CppInt32Enum = default;
				Unity.IL2CPP.Metadata.__Il2CppInt32Enum value = _Il2CppInt32Enum.Value;
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text2 = Carried((Lobby)value);
				if (text2 != null)
				{
					int length = text._stringLength - text2._stringLength;
					return text.Substring(0, length);
				}
			}
			return (string)(object)new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object result = 0;
		if (text == null)
		{
			return (string)result;
		}
		return text;
	}

	public static Lobby KindOf(string code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EF8]");
		object obj = 0;
		if (code == (string)obj)
		{
			return (Lobby)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F00]");
		object obj2 = 0;
		bool flag = code == (string)obj2;
		bool flag2 = !flag;
		object obj3 = !flag2;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			return (Lobby)2;
		}
		return (Lobby)0;
	}

	public static string NewPublicCode()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		char[] array = default;
		if (array != null)
		{
			if (array.Length < 1)
			{
				goto IL_0177;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF70]");
			object obj3 = 0;
			object obj4 = array + 32;
			int num = 5;
			object obj5 = 0;
			int num2 = default;
			while (true)
			{
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj2;
				}
				object obj8 = obj3;
				if (obj3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v5+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v5+40]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ X9_v6+1A8] (should have been resolved before IL gen)");
				if (obj3 == null)
				{
					break;
				}
				char c = ((string)obj3).get_Chars(num2);
				bool flag2 = (nint)obj5 < array.Length;
				object obj12 = !flag2;
				if (obj12 == null)
				{
					obj5++;
					bool flag3 = (nint)obj5 < array.Length;
					num = num2;
					if (flag3)
					{
						continue;
					}
					goto IL_0177;
				}
				goto IL_0198;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0198;
		IL_0177:
		return ((string)null).CreateString(array);
		IL_0198:
		return (string)(object)new IndexOutOfRangeException();
	}

	public static bool IsGamesPublicRoom(string session)
	{
		//IL_0010: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_0427: Expected Obj, but got I
		//IL_02e4: Expected I4, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_025e: Expected I4, but got I8
		//IL_0278: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		bool result;
		if (obj10 == null)
		{
			bool flag6 = string.IsNullOrEmpty(session);
			bool flag7 = !flag6;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v15+E4]");
				bool flag8 = (nint)0 == 0;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v19+E4]");
				bool flag9 = (nint)0 == 0;
				object obj15 = !flag9;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj14 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v19+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v14+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v14+8]");
					string prefix = ((NetworkBootstrap)0).Prefix;
					if (session != null)
					{
						if (!session.StartsWith(prefix))
						{
							goto IL_02ba;
						}
						if (prefix != null)
						{
							int num = prefix._stringLength;
							object obj17 = prefix._stringLength + 5;
							if (session._stringLength != (nint)obj17)
							{
								goto IL_02ba;
							}
							if (prefix._stringLength >= session._stringLength)
							{
								result = true;
								goto IL_039c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF70]");
							object obj18 = 0;
							while (true)
							{
								char value = session.get_Chars(num);
								if (obj18 == null)
								{
									break;
								}
								int num2 = ((string)obj18).IndexOf(value);
								int num3 = ~num2;
								result = (byte)(num3 >> 31) != 0;
								int num4 = (int)(num2 & 0x80000000L);
								bool flag10 = num4 == 0;
								object obj19 = !flag10;
								if (obj19 == null)
								{
									num++;
									if (num < session._stringLength)
									{
										continue;
									}
								}
								goto IL_039c;
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		goto IL_02ba;
		IL_02ba:
		result = false;
		goto IL_039c;
		IL_039c:
		return result;
	}

	private static string SigningInWhy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I4
		//IL_06b8: Expected Obj, but got I
		//IL_06da: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I4
		//IL_05e3: Expected Obj, but got I4
		//IL_06f8: Expected Obj, but got I
		//IL_0708: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I
		//IL_03b0: Expected Obj, but got I4
		//IL_061b: Expected Obj, but got I4
		//IL_0745: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj4 = 0;
		if (ShiftAuth.HasDevKey)
		{
			goto IL_005a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+A0]");
		object obj10 = 0;
		object obj11 = obj10;
		if (obj10 == null)
		{
			goto IL_043c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v12+10]");
		object obj15;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v64+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v64+A0]");
			obj15 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v18+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v18+A0]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v17+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj20 = 0;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v19+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj23 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v23+E4]");
				bool flag9 = (nint)0 == 0;
				object obj24 = !flag9;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v23+A0]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v25+10]");
				bool flag10 = (nint)0 == 0;
				object obj26 = !flag10;
				if (obj26 != null)
				{
					goto IL_005a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v23+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj28 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v27+E4]");
				bool flag12 = (nint)0 == 0;
				object obj29 = !flag12;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj20;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v27+A0]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v31+30]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v31+30]");
				if ((nint)0 == 0)
				{
					goto IL_043c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v32+10]");
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v27+E4]");
					bool flag13 = (nint)0 == 0;
					object obj32 = !flag13;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj33 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v31+E4]");
					bool flag14 = (nint)0 == 0;
					object obj34 = !flag14;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj33 = obj20;
					}
					object obj35 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v31+A0]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v40+E4]");
					bool flag15 = (nint)0 == 0;
					object obj37 = !flag15;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X9_v5+30]");
					return SignInWhy((string)0);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFE0]");
				obj15 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFD0]");
				obj15 = 0;
			}
		}
		goto IL_053c;
		IL_053c:
		string text = (string)obj15;
		goto IL_04c7;
		IL_04c7:
		return text;
		IL_005a:
		object obj38 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v53+E4]");
		bool flag16 = (nint)0 == 0;
		object obj39 = !flag16;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v53+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v8+20]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v8+20]");
		if ((nint)0 == 0)
		{
			goto IL_043c;
		}
		if (text._stringLength > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v53+E4]");
			bool flag17 = (nint)0 == 0;
			object obj41 = !flag17;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj42 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v56+A0]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v57+20]");
				text = (string)0;
			}
			goto IL_04c7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFD8]");
		obj15 = 0;
		goto IL_053c;
		IL_043c:
		return (string)(object)new NullReferenceException();
	}

	public static string BanSaid()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I4
		//IL_0438: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+20]");
		object obj7;
		string text3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFB8]");
			obj7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v9+18]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v36+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v36+A0]");
				object obj15 = 0;
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v27+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				long serverNowMs = GillaModeration.ServerNowMs;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X9_v14+18]");
				long ms = -serverNowMs;
				string text = GillaModeration.Left(ms);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFA8]");
				object obj18 = 0;
				string text2 = (string)obj18 + text;
				obj4 = obj;
				text3 = text2;
				goto IL_02d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFB0]");
			obj7 = 0;
		}
		text3 = (string)obj7;
		goto IL_02d6;
		IL_02d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v11+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v11+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v13+28]");
		if (string.IsNullOrWhiteSpace((string)0))
		{
			return text3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v13+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v13+28]");
			string text4 = ((string)0).Trim();
			if (text4 != null)
			{
				string text5 = text4.ToUpperInvariant();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				object obj23 = 0;
				return text3 + (string)obj23 + text5;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private static string KickSaid()
	{
		//IL_0010: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+A0]");
		object obj7 = 0;
		long serverNowMs = GillaModeration.ServerNowMs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+30]");
		long ms = -serverNowMs;
		string text = GillaModeration.Left(ms);
		string text2 = (string)obj5 + text;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v15+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v12+38]");
		if (string.IsNullOrWhiteSpace((string)0))
		{
			return text2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v12+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v12+38]");
			string text3 = ((string)0).Trim();
			if (text3 != null)
			{
				string text4 = text3.ToUpperInvariant();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				object obj11 = 0;
				return text2 + (string)obj11 + text4;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public static string SignInWhy(string problem)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I4
		//IL_0774: Expected Obj, but got I
		//IL_0789: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_0668: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_06c7: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I4
		//IL_0741: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_0385: Expected I4, but got I8
		//IL_039f: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_07c8: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_03ce: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		//IL_07f9: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I
		//IL_0607: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I4
		//IL_057b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+10]");
		bool flag2 = problem == (string)0;
		object obj5 = obj;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			goto IL_0258;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v9+A0]");
		object obj9 = (nint)0 + (nint)16;
		obj9 = problem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text = (string)((problem != null) ? problem : obj7);
		int num;
		string text2;
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE008]");
			object value = 0;
			num = text.IndexOf((string)value, (StringComparison)4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFF8]");
			object obj10 = 0;
			bool flag5 = text.StartsWith((string)obj10);
			bool flag6 = !flag5;
			text2 = null;
			if (flag6)
			{
				goto IL_06b7;
			}
			object obj11 = obj10;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v57+10]");
				string text3 = text.Substring(0);
				if (text3 != null)
				{
					string text4 = text3.Trim();
					text2 = text4;
					goto IL_06b7;
				}
			}
		}
		return (string)(object)new NullReferenceException();
		IL_06b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE028]");
		object obj12 = 0;
		string text5 = (string)obj12;
		object obj13;
		string text6;
		string text9;
		object obj14;
		if (text == (string)obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE020]");
			obj13 = 0;
			obj14 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE030]");
			object obj15 = 0;
			text5 = (string)obj15;
			if (text == (string)obj15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE058]");
				obj13 = 0;
				obj14 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE000]");
				object obj16 = 0;
				text5 = (string)obj16;
				if (text.StartsWith((string)obj16))
				{
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v62+E4]");
					bool flag7 = (nint)0 == 0;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					text6 = ReachWhy(text);
					obj14 = 0;
					goto IL_04c6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE010]");
				object value2 = 0;
				if (text.StartsWith((string)value2))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE048]");
					object obj19 = 0;
					int num2 = (int)(num & 0x80000000L);
					bool flag8 = num2 == 0;
					object obj20 = !flag8;
					if (obj20 == null)
					{
						string text7 = text.Substring(num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
						object obj21 = 0;
						string text8 = (string)obj21 + text7;
						text5 = text8;
					}
					else
					{
						text5 = (string)obj7;
					}
					text9 = (string)obj19;
					goto IL_07df;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE040]");
				object obj22 = 0;
				text5 = (string)obj22;
				if (text == (string)obj22)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFF0]");
					obj13 = 0;
					obj14 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE038]");
					object obj23 = 0;
					text5 = (string)obj23;
					if (!(text == (string)obj23))
					{
						string text10;
						object obj26;
						if (text2 != null)
						{
							if (text2._stringLength == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE060]");
								obj13 = 0;
								obj14 = 0;
								goto IL_06fd;
							}
							object obj24 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v51+E4]");
							bool flag9 = (nint)0 == 0;
							object obj25 = !flag9;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							text10 = Words(text2, 20);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE018]");
							obj26 = 0;
						}
						else
						{
							object obj27 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v46+E4]");
							bool flag10 = (nint)0 == 0;
							object obj28 = !flag10;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							text10 = Words(text, 20);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFE8]");
							obj26 = 0;
						}
						text5 = text10;
						text9 = (string)obj26;
						goto IL_07df;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE050]");
					obj13 = 0;
					obj14 = 0;
				}
			}
		}
		goto IL_06fd;
		IL_0717:
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v24+E4]");
		bool flag11 = (nint)0 == 0;
		object obj30 = !flag11;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v24+A0]");
		object obj31 = (nint)0 + (nint)24;
		string text11;
		obj31 = text11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0258;
		IL_07df:
		text6 = text9 + text5;
		obj14 = 0;
		goto IL_04c6;
		IL_04c6:
		text11 = text6;
		goto IL_0717;
		IL_0258:
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v8+18]");
		return (string)0;
		IL_06fd:
		text11 = (string)obj13;
		goto IL_0717;
	}

	private static string ReachWhy(string p)
	{
		//IL_0040: Expected I4, but got I8
		//IL_005a: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		if (p != null)
		{
			int num = p.IndexOf('(');
			int num2 = p.LastIndexOf(')');
			int num3 = (int)(num & 0x80000000L);
			bool flag = num3 == 0;
			object obj = !flag;
			string text3;
			if (obj == null && num2 > num)
			{
				int num4 = ~num;
				int startIndex = num + 1;
				int length = num2 + num4;
				string text = p.Substring(startIndex, length);
				if (text == null)
				{
					goto IL_03ca;
				}
				string text2 = text.Trim();
				char c = '\0';
				text3 = text2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj2 = 0;
				text3 = (string)obj2;
				int length = 0;
				char c = ')';
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2D0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text4 = GillaCloud.ReachKind(text3);
			if (text4 == (string)obj5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE098]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC290]");
			object obj7 = 0;
			if (text4 == (string)obj7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE080]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2B0]");
			object obj8 = 0;
			if (text4 == (string)obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE078]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC280]");
			object obj9 = 0;
			if (text4 == (string)obj9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE088]");
				return (string)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2C0]");
			object obj10 = 0;
			if (text4 == (string)obj10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE090]");
				return (string)0;
			}
			if (text3 != null)
			{
				if (text3._stringLength > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v24+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text5 = Words(text3, 18);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0A0]");
					object obj14 = 0;
					return (string)obj14 + text5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE070]");
				return (string)0;
			}
		}
		goto IL_03ca;
		IL_03ca:
		return (string)(object)new NullReferenceException();
	}

	private static void ForgetWhy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj5 = (nint)0 + (nint)32;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v9+A0]");
		object obj8 = (nint)0 + (nint)40;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7+A0]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+A0]");
		object obj12 = (nint)0 + (nint)24;
		obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+A0]");
		object obj14 = (nint)0 + (nint)48;
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static void NoteLogin(ShiftAuth.Outcome outcome)
	{
		//IL_0242: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I
		//IL_01ec: Expected I8, but got I
		//IL_020e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		bool flag = !outcome.Success;
		object obj2 = !flag;
		string text;
		if (obj2 == null)
		{
			text = outcome.Error;
			bool flag2 = string.IsNullOrEmpty(outcome.Error);
			bool flag3 = !flag2;
			object obj3 = !flag3;
			if (obj3 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0A8]");
			object obj4 = 0;
			bool flag4 = outcome.Error == (string)obj4;
			bool flag5 = !flag4;
			object obj5 = !flag5;
			if (obj5 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE040]");
			object obj6 = 0;
			if (outcome.Error == (string)obj6)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v29+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v29+A0]");
			object obj10 = 0;
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ShiftAuth.FailKind kind = outcome.Kind;
			string error = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v2+60]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v2+68]");
			string text2 = LoginWhy(kind, error, num, (string)0);
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v17+A0]");
			object obj14 = (nint)0 + (nint)32;
			obj14 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			string text3 = text2;
		}
		else
		{
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj;
			}
			string text3 = (string)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v15+A0]");
			object obj18 = (nint)0 + (nint)32;
			obj18 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			text = (string)obj16;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v5+A0]");
		object obj21 = (nint)0 + (nint)40;
		obj21 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static string LoginWhy(ShiftAuth.FailKind kind, string error, long httpCode = default(long), string httpError = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_0231: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		string text = (string)((error != null) ? error : obj);
		switch (kind)
		{
		case (ShiftAuth.FailKind)4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0D8]");
			return (string)0;
		case (ShiftAuth.FailKind)5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0E8]");
			return (string)0;
		default:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0C8]");
			object obj2 = 0;
			if (text == (string)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0B8]");
				return (string)0;
			}
			if (text != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0B0]");
				object obj3 = 0;
				string text2 = (string)obj3;
				bool flag = text.Contains((string)obj3);
				bool flag2 = !flag;
				object obj4 = !flag2;
				object obj5 = 0;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0D0]");
					object obj6 = 0;
					text2 = (string)obj6;
					bool flag3 = text.Contains((string)obj6);
					bool flag4 = !flag3;
					object obj7 = !flag4;
					obj5 = 0;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2B0]");
						object obj8 = 0;
						text2 = (string)obj8;
						bool flag5 = text.Contains((string)obj8);
						bool flag6 = !flag5;
						obj5 = 0;
						if (flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
							object obj9 = 0;
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v19+E4]");
							bool flag7 = (nint)0 == 0;
							object obj11 = !flag7;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text3 = Words(text, 21);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0C0]");
							object obj12 = 0;
							return (string)obj12 + text3;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v10+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return LoginReachWhy(httpCode, httpError);
			}
			return (string)(object)new NullReferenceException();
		}
		case (ShiftAuth.FailKind)2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0F0]");
			return (string)0;
		case (ShiftAuth.FailKind)6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0E0]");
			return (string)0;
		}
	}

	private static string LoginReachWhy(long code, string error)
	{
		//IL_007f: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		object result;
		if (code == 429)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE130]");
			result = 0;
		}
		else
		{
			if (code >= 1)
			{
				long num = default;
				string text = num.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE120]");
				object obj = 0;
				return (string)obj + text;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = GillaCloud.ReachKind(error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2D0]");
			object obj5 = 0;
			if (text2 == (string)obj5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE108]");
				result = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC290]");
				object obj6 = 0;
				if (text2 == (string)obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE118]");
					result = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2B0]");
					object obj7 = 0;
					if (text2 == (string)obj7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE128]");
						result = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC280]");
						object obj8 = 0;
						if (text2 == (string)obj8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE100]");
							result = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2C0]");
							object obj9 = 0;
							if (text2 == (string)obj9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE090]");
								result = 0;
							}
							else
							{
								if (!string.IsNullOrEmpty(error))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
									object obj10 = 0;
									object obj11 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v20+E4]");
									bool flag2 = (nint)0 == 0;
									object obj12 = !flag2;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string text3 = Words(error, 18);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0F8]");
									object obj13 = 0;
									return (string)obj13 + text3;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE110]");
								result = 0;
							}
						}
					}
				}
			}
		}
		return (string)result;
	}

	private static string Words(string said, int most)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I4
		//IL_03aa: Expected Obj, but got I4
		//IL_0504: Expected Obj, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected I4, but got Unknown
		//IL_0571: Expected Obj, but got I4
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		string text = (string)((said != null) ? said : obj2);
		if (text != null)
		{
			if (text._stringLength < 1)
			{
				goto IL_025c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj3 = 0;
			int num = 0;
			while (true)
			{
				char c = text.get_Chars(num);
				int num2 = c & 0xFFFF;
				bool flag = num2 == 45;
				char c2 = ' ';
				char value;
				if (!flag)
				{
					bool flag2 = num2 == 95;
					c2 = ' ';
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v6+90]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v24+E4]");
						bool flag3 = (nint)0 == 0;
						object obj5 = !flag3;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag4 = char.IsUpper(c);
						if (num != 0 && flag4)
						{
							int index = num - 1;
							char c3 = text.get_Chars(index);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v6+90]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v23+E4]");
							bool flag5 = (nint)0 == 0;
							object obj7 = !flag5;
							if (obj7 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (char.IsLower(c3))
							{
								if (stringBuilder == null)
								{
									break;
								}
								StringBuilder stringBuilder2 = stringBuilder.Append(' ');
								value = c;
								goto IL_021c;
							}
						}
						c2 = c;
					}
				}
				bool flag6 = stringBuilder == null;
				value = c2;
				if (flag6)
				{
					break;
				}
				goto IL_021c;
				IL_021c:
				StringBuilder stringBuilder3 = stringBuilder.Append(value);
				num++;
				if (num < text._stringLength)
				{
					continue;
				}
				goto IL_025c;
			}
		}
		goto IL_042a;
		IL_025c:
		if (stringBuilder != null)
		{
			((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
			string text2 = default;
			if (text2 != null)
			{
				string text3 = text2.Trim();
				if (text3 != null)
				{
					string text4 = text3.ToUpperInvariant();
					if (text4 != null)
					{
						string result;
						if (text4._stringLength != 0)
						{
							bool flag7 = text4._stringLength <= most;
							result = text4;
							if (!flag7)
							{
								int num3 = text4.LastIndexOf(' ', most);
								bool flag8 = most < 0;
								int num4 = most ^ most;
								int num5 = most & num4;
								bool flag9 = num5 < 0;
								bool flag10 = flag8 == flag9;
								object obj8 = !flag10;
								object obj9 = ~obj8;
								int num6 = ((obj9 != null) ? most : (most + 1));
								object obj10 = num3 - num6;
								bool flag11 = (nint)obj10 < 0;
								bool flag12 = obj10 == null;
								int num7 = num3 ^ num6;
								int num8 = num3 ^ obj10;
								int num9 = num7 & num8;
								bool flag13 = num9 < 0;
								bool flag14 = flag11 == flag13;
								object obj11 = !flag12;
								object obj12 = flag14 & obj11;
								object obj13 = ~obj12;
								int length = ((obj13 != null) ? most : num3);
								string text5 = text4.Substring(0, length);
								if (text5 != null)
								{
									return text5.TrimEnd();
								}
								goto IL_042a;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE068]");
							object obj14 = 0;
							result = (string)obj14;
						}
						return result;
					}
				}
			}
		}
		goto IL_042a;
		IL_042a:
		return (string)(object)new NullReferenceException();
	}

	public unsafe static string JoinWhy(ShutdownReason reason, string message)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05d9: Expected Obj, but got I4
		//IL_05e7: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_02f2: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got Ref
		//IL_050d: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0132: Expected I4, but got I8
		//IL_014c: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I
		//IL_043d: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_04a2: Expected Obj, but got I
		//IL_04cd: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I
		//IL_04eb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		string text = (string)((message != null) ? message : obj);
		bool flag = reason < (ShutdownReason)20;
		object obj2 = !flag;
		object obj3 = reason - 20;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 1 << (int)reason;
			object obj7 = obj6 & 0x1C4000;
			if (obj7 != null)
			{
				goto IL_0068;
			}
			object obj8 = obj6 & 0x2800;
			if (obj8 != null)
			{
				goto IL_00a8;
			}
			if (reason == (ShutdownReason)12)
			{
				if (text != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE148]");
					object obj9 = 0;
					int num = text.IndexOf((string)obj9, (StringComparison)5);
					int num2 = (int)(num & 0x80000000L);
					bool flag3 = num2 == 0;
					object obj10 = !flag3;
					if (obj10 != null)
					{
						goto IL_00a8;
					}
					object obj11 = obj9;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v42+10]");
						int startIndex = (int)((nint)0 + (nint)num);
						string said = text.Substring(startIndex);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
						object obj12 = 0;
						object obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v46+E4]");
						bool flag4 = (nint)0 == 0;
						object obj14 = !flag4;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text2 = Words(said, 11);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE158]");
						object obj15 = 0;
						return (string)obj15 + text2;
					}
				}
				return (string)(object)new NullReferenceException();
			}
		}
		object result;
		if (reason != (ShutdownReason)1)
		{
			if (reason != (ShutdownReason)7)
			{
				object obj16 = default;
				string said2 = ((Enum)(&obj16)).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v29+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text3 = Words(said2, 24);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE160]");
				object obj20 = 0;
				return (string)obj20 + text3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE178]");
			object word = 0;
			bool flag7 = Has(text, (string)word);
			bool flag8 = !flag7;
			object obj24 = !flag8;
			if (obj24 != null)
			{
				goto IL_00a8;
			}
			object obj25 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj26 = !flag9;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE188]");
			object word2 = 0;
			bool flag10 = Has(text, (string)word2);
			bool flag11 = !flag10;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				object obj28 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v13+E4]");
				bool flag12 = (nint)0 == 0;
				object obj29 = !flag12;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE140]");
				object word3 = 0;
				bool flag13 = Has(text, (string)word3);
				bool flag14 = !flag13;
				object obj30 = !flag14;
				if (obj30 == null)
				{
					object obj31 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v17+E4]");
					bool flag15 = (nint)0 == 0;
					object obj32 = !flag15;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE180]");
					object word4 = 0;
					bool flag16 = Has(text, (string)word4);
					bool flag17 = !flag16;
					object obj33 = !flag17;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE170]");
						result = 0;
						goto IL_061c;
					}
				}
				goto IL_0068;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE168]");
		result = 0;
		goto IL_061c;
		IL_00a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE150]");
		result = 0;
		goto IL_061c;
		IL_0068:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE190]");
		result = 0;
		goto IL_061c;
		IL_061c:
		return (string)result;
	}

	private static bool Has(string text, string word)
	{
		//IL_005d: Expected I4, but got Obj
		if (text != null)
		{
			int num = text.IndexOf(word, (StringComparison)5);
			int num2 = ~num;
			return (byte)(num2 >> 31) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static string LabelOf(Lobby kind)
	{
		//IL_002a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		object result;
		if (kind == (Lobby)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8310]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF60]");
			result = 0;
		}
		if (kind == (Lobby)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC518]");
			result = 0;
		}
		return (string)result;
	}

	public string CarriedTo(Lobby kind)
	{
		//IL_00d4: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		string text = carrying;
		if (carrying != null)
		{
			if (text._stringLength != 0)
			{
				if (carryingHome != kind)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text2 = Carried(kind);
					return text + text2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj4 = 0;
				text = (string)obj4;
			}
			return text;
		}
		return (string)(object)new NullReferenceException();
	}

	public string TakeWaiting(Lobby kind)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		object obj = this + 152;
		string result = (string)obj;
		if (obj != null && WaitingKind__BackingField == kind)
		{
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj2 = 0;
			result = (string)obj2;
		}
		return result;
	}

	private Lobby RoomKind(Lobby otherwise)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I4
		//IL_01b7: Expected I4, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		Lobby result = otherwise;
		if (!flag3)
		{
			NetworkRunner networkRunner = runner;
			if ((object)runner == null)
			{
				goto IL_01a9;
			}
			SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
			bool flag4 = networkRunner.SessionInfo__BackingField == null;
			result = otherwise;
			if (!flag4)
			{
				bool flag5 = (object)sessionInfo.Properties__BackingField == null;
				result = otherwise;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBED8]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE198]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4283DDC");
					object obj7 = default;
					object obj6 = obj7 & 1;
					bool flag6 = obj6 == null;
					result = otherwise;
					if (!flag6)
					{
						SessionProperty sessionProperty = default;
						if (sessionProperty == null)
						{
							goto IL_01a9;
						}
						bool isInt = sessionProperty.IsInt;
						bool flag7 = !isInt;
						result = otherwise;
						if (!flag7)
						{
							int num = sessionProperty;
							result = (Lobby)num;
						}
					}
				}
			}
		}
		return result;
		IL_01a9:
		NullReferenceException ex = new NullReferenceException();
		return (Lobby)ex;
	}

	private Lobby HomeOf(Lobby otherwise)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I4
		//IL_01b7: Expected I4, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		Lobby result = otherwise;
		if (!flag3)
		{
			NetworkRunner networkRunner = runner;
			if ((object)runner == null)
			{
				goto IL_01a9;
			}
			SessionInfo sessionInfo = networkRunner.SessionInfo__BackingField;
			bool flag4 = networkRunner.SessionInfo__BackingField == null;
			result = otherwise;
			if (!flag4)
			{
				bool flag5 = (object)sessionInfo.Properties__BackingField == null;
				result = otherwise;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1A0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE198]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4283DDC");
					object obj7 = default;
					object obj6 = obj7 & 1;
					bool flag6 = obj6 == null;
					result = otherwise;
					if (!flag6)
					{
						SessionProperty sessionProperty = default;
						if (sessionProperty == null)
						{
							goto IL_01a9;
						}
						bool isInt = sessionProperty.IsInt;
						bool flag7 = !isInt;
						result = otherwise;
						if (!flag7)
						{
							int num = sessionProperty;
							result = (Lobby)num;
						}
					}
				}
			}
		}
		return result;
		IL_01a9:
		NullReferenceException ex = new NullReferenceException();
		return (Lobby)ex;
	}

	public static void SetPlayerId(string id)
	{
		//IL_00dc: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(id);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+38]");
		if (!(id == (string)0))
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v10+A0]");
			object obj8 = (nint)0 + (nint)56;
			obj8 = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1A8]");
			object key = 0;
			PlayerPrefs.SetString((string)key, id);
			PlayerPrefs.Save();
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I
		//IL_0433: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I
		//IL_0470: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1D8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+A0]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj6);
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ShiftAuth.OnSessionLost += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj16 = default;
		bool flag5 = obj16 == null;
		bool flag6 = !flag5;
		UnityEngine.Object obj17 = null;
		if (!flag6)
		{
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1C8]");
			object obj18 = 0;
			obj17 = (UnityEngine.Object)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		}
		object obj19 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v23+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = voice != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj21 = null;
		object obj22 = 0;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1C0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj24 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v16+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj26 = default;
			bool flag11 = obj26 == null;
			bool flag12 = !flag11;
			obj21 = null;
			obj22 = 0;
			if (!flag12)
			{
				GameObject gameObject2 = voice.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1D0]");
				object obj27 = 0;
				obj21 = (UnityEngine.Object)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				obj22 = 0;
			}
		}
		object obj28 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v28+E4]");
		bool flag13 = (nint)0 == 0;
		object obj29 = !flag13;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (voice != null && voice.MicrophoneType != 0)
		{
			voice.RecordingEnabled = false;
			voice.MicrophoneType = (Recorder.MicType)0;
		}
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_017e: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action = default;
		action._002Ector(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ShiftAuth.OnSessionLost -= action;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj4;
		}
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v11+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v1+8]");
		if ((UnityEngine.Object)0 == this)
		{
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v19+A0]");
			object obj19 = (nint)0 + (nint)8;
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void OnAuthLost()
	{
		//IL_0010: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1E0]");
		object message = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		object obj6 = this + 120;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X20_v6+38]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 != null || !runner.IsRunning)
		{
			return;
		}
		Task task = runner.Shutdown(destroyGameObject: true, (ShutdownReason)0, forceShutdownProcedure: false);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (voice != null)
		{
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (mic != null)
			{
				mic.Restart();
			}
		}
	}

	public void Kick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1E8]");
		object message = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFA0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		object obj6 = this + 120;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj4;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X20_v6+38]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 != null || !runner.IsRunning)
		{
			return;
		}
		Task task = runner.Shutdown(destroyGameObject: true, (ShutdownReason)0, forceShutdownProcedure: false);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (voice != null)
		{
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (mic != null)
			{
				mic.Restart();
			}
		}
	}

	public void CloseRoom(string room)
	{
		if (!string.IsNullOrEmpty(room))
		{
			IEnumerator routine = CloseWhenMaster(room);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator CloseWhenMaster(string room)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2 + 40;
		obj4 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	public void KickFromRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE1F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object code = 0;
		string text = RoomName;
		string message = (string)obj + text + (string)obj2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		rejoining = false;
		Join(Kind__BackingField, (string)code, probe: false);
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05d9: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I
		//IL_0513: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_046b: Expected Obj, but got I
		//IL_0473: Expected I, but got Obj
		//IL_0481: Expected I, but got Obj
		//IL_04b0: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I8
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_070e: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		//IL_05f1: Expected Obj, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_0645: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I4
		//IL_072c: Expected Obj, but got I
		//IL_0734: Expected I, but got Obj
		//IL_0749: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I4
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_0774: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_0695: Expected Obj, but got I
		//IL_06af: Expected Obj, but got I
		//IL_06c0: Expected I, but got Obj
		//IL_06de: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		MicLevel.AskOnce();
		VoiceToMic();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = tearing != null;
		bool flag3 = !flag2;
		nint num = 0;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			DismemberGroup dismemberGroup = tearing;
			Dismemberment[] copies = dismemberGroup.copies;
			bool flag4 = dismemberGroup.copies == null;
			num = 0;
			obj4 = null;
			if (!flag4)
			{
				bool flag5 = copies.Length < 1;
				num = 0;
				obj4 = null;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8828]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD640]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE218]");
					object obj7 = 0;
					object obj8 = copies.Length & 0xFFFFFFFFL;
					object obj9 = dismemberGroup.copies + 32;
					object obj11 = default;
					object obj10 = obj11;
					object obj12 = 1;
					object obj13 = 0;
					nint num2 = 0;
					UnityEngine.Object obj14 = null;
					UnityEngine.Object obj21 = default;
					Predicate<System.__Canon> predicate2 = default;
					bool flag18;
					do
					{
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
						object obj15 = !flag6;
						if (obj15 == null)
						{
							object obj16 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X28_v5+v179 @ X26_v6*8]");
							UnityEngine.Object obj17 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v34+E4]");
							bool flag7 = (nint)0 == 0;
							object obj18 = !flag7;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X28_v5+v179 @ X26_v6*8]");
							bool flag8 = (UnityEngine.Object)0 != null;
							bool flag9 = !flag8;
							num = 0;
							obj4 = null;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X21_v8 (UnityEngine.Object)+20]");
								bool flag10 = (nint)0 == 0;
								num = 0;
								obj4 = null;
								if (!flag10)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
									object obj19 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v24+E4]");
									bool flag11 = (nint)0 == 0;
									object obj20 = !flag11;
									if (obj20 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag12 = obj21 == null;
									bool flag13 = !flag12;
									num = 0;
									obj4 = null;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X28_v5+v179 @ X26_v6*8]");
										GameObject gameObject = ((Component)0).gameObject;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
										object obj22 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v48+E4]");
										bool flag14 = (nint)0 == 0;
										object obj23 = !flag14;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj22 = obj7;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v48+A0]");
										object obj24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v31+8]");
										Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v31+8]");
										bool flag15 = (nint)0 == 0;
										object obj25 = !flag15;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v48+E4]");
											bool flag16 = (nint)0 == 0;
											object obj26 = !flag16;
											if (obj26 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												object obj27 = obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v37+A0]");
												obj24 = 0;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA8]");
											object obj28 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE210]");
											object obj29 = 0;
											predicate2._002Ector(obj24, (IntPtr)obj29);
											object obj30 = obj7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v36+A0]");
											object obj31 = (nint)0 + (nint)8;
											obj31 = predicate2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8828]");
											obj5 = 0;
											obj10 = 0;
											predicate = predicate2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D68]");
										object obj32 = 0;
										num = (nint)obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X21_v8 (UnityEngine.Object)+20]");
										bool flag17 = Array.Exists((System.__Canon[])0, predicate);
										object obj33 = !flag17;
										object obj34 = 1 & obj33;
										obj12 = 1;
										obj4 = (UnityEngine.Object)(object)predicate;
									}
								}
							}
							obj8 = copies.Length;
							obj13++;
							flag18 = (nint)obj13 < copies.Length;
							obj11 = obj10;
							num2 = num;
							obj14 = obj4;
							continue;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						throw new NullReferenceException();
					}
					while (flag18);
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj35 = 0;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v10+E4]");
		bool flag19 = (nint)0 == 0;
		object obj37 = !flag19;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj38 = 0;
		bool hasDevKey = ShiftAuth.HasDevKey;
		bool flag20 = !hasDevKey;
		object obj39 = obj4;
		if (!flag20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC098]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE208]");
			object obj41 = 0;
			num = (nint)obj41;
			Action<ShiftAuth.Outcome> action = default;
			action._002Ector((object)null, (IntPtr)obj41);
			object obj42 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v25+E4]");
			bool flag21 = (nint)0 == 0;
			object obj43 = !flag21;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ShiftAuth.Begin(action);
			object obj11 = 0;
			obj39 = null;
		}
		object obj44 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v13+E4]");
		bool flag22 = (nint)0 == 0;
		object obj45 = !flag22;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (GillaIntegrity.Cleared)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object code = 0;
			JoinRoom((string)code);
		}
		else
		{
			IEnumerator routine = JoinOnceCleared();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator JoinOnceCleared()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE228]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private IEnumerator JoinAfterAuth()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE230]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private static void Relogin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A0]");
		object obj4 = 0;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE238]");
		object message = 0;
		Debug.Log(message);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (ShiftAuth.HasDevKey)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC098]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE208]");
			object obj11 = 0;
			Action<ShiftAuth.Outcome> action = default;
			action._002Ector((object)null, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ShiftAuth.Begin(action);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCloud.RetryShiftAuth();
		}
	}

	private IEnumerator FetchTicket(TaskCompletionSource<string> ticket)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE240]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = ticket;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	public static AuthenticationValues TicketAuth(string ticket)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE248]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		AuthenticationValues authenticationValues = default;
		authenticationValues._002Ector();
		if (authenticationValues != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE250]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE260]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
			object obj4 = 0;
			authenticationValues.authType = (CustomAuthenticationType)0;
			if (ticket == null)
			{
			}
			string text = ((GUIContent)(object)authenticationValues).ToString();
			nint num = (nint)authenticationValues;
			string text2 = ((GUIContent)(object)authenticationValues).ToString();
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v10+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v8+20]");
			if ((nint)0 == 0)
			{
			}
			string text3 = ((GUIContent)(object)authenticationValues).ToString();
			return authenticationValues;
		}
		return (AuthenticationValues)(object)new NullReferenceException();
	}

	private void VoiceToMic()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I
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
		if (voice == null)
		{
			micAllowed = true;
			return;
		}
		bool allowed = MicLevel.Allowed;
		Recorder recorder = voice;
		micAllowed = allowed;
		recorder.recordWhenJoined = allowed;
		bool recordingEnabled;
		if (allowed)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
			bool flag4 = !flag3;
			UnityEngine.Object obj6 = null;
			UnityEngine.Object obj7 = null;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE220]");
				object obj8 = 0;
				obj6 = (UnityEngine.Object)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				UnityEngine.Object obj9 = default;
				obj7 = obj9;
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(obj7 != null))
			{
				return;
			}
			ClientState clientState = ((VoiceConnection)obj7).ClientState;
			if (clientState != (ClientState)9)
			{
				return;
			}
			recorder = voice;
			recordingEnabled = true;
		}
		else
		{
			recordingEnabled = false;
		}
		recorder.RecordingEnabled = recordingEnabled;
	}

	private void Update()
	{
		//IL_046e: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got I4
		//IL_0350: Expected F4, but got I4
		//IL_039f: Expected F8, but got I4
		//IL_0281: Expected I, but got Obj
		//IL_0291: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I4
		//IL_0406: Invalid comparison between F4 and I4
		//IL_0415: Expected F8, but got I4
		//IL_04cd: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		WatchForDrop();
		bool flag = (byte)(~(micAllowed ? 1u : 0u)) != 0;
		object obj2 = !flag;
		float num = default;
		if (obj2 == null)
		{
			num = Time.unscaledTime;
			double num2 = micLookAt;
			if (!(num < micLookAt))
			{
				float unscaledTime = Time.unscaledTime;
				num = (micLookAt = unscaledTime + 1f);
				VoiceToMic();
				bool flag2 = (byte)(~(micAllowed ? 1u : 0u)) != 0;
				num2 = 1.0;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v33+E4]");
					bool flag3 = (nint)0 == 0;
					object obj5 = !flag3;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE278]");
					object message = 0;
					Debug.Log(message);
					num2 = 1.0;
				}
			}
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = voice == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = mic == null;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		if (obj11 != null)
		{
			return;
		}
		MicLevel micLevel = mic;
		if (~(micLevel.externalOnly ? 1u : 0u) != 0)
		{
			return;
		}
		AudioUtil.ILevelMeter levelMeter = voice.LevelMeter;
		object obj17;
		if (levelMeter != null)
		{
			AudioUtil.ILevelMeter levelMeter2 = voice.LevelMeter;
			nint num3 = (nint)levelMeter2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE270]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v14 (Il2CppClass<Photon.Voice.AudioUtil+ILevelMeter>)+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v14 (Il2CppClass<Photon.Voice.AudioUtil+ILevelMeter>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_031d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v14 (Il2CppClass<Photon.Voice.AudioUtil+ILevelMeter>)+98]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v10-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj13--;
				obj14 += 16;
				if ((nint)obj13 != 1)
				{
					continue;
				}
				goto IL_031d;
			}
			object obj15 = num3 + obj14;
			object obj16 = obj15 + 312;
			obj17 = 0;
			goto IL_04bd;
		}
		obj17 = 0;
		object obj18 = 0;
		num = 0f;
		goto IL_04dc;
		IL_04bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v21+8]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v386 @ X0_v21] (should have been resolved before IL gen)");
		goto IL_04dc;
		IL_031d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj17 = 0;
		goto IL_04bd;
		IL_04dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D120");
		MicLevel micLevel2 = mic;
		bool flag10 = micLevel2.minDb == micLevel2.maxDb;
		double num4 = 0.0;
		if (!flag10)
		{
			float num5 = num * 20f;
			float num6 = num5 - micLevel2.minDb;
			float num7 = micLevel2.maxDb - micLevel2.minDb;
			float num8 = num6 / num7;
			bool flag11 = num8 < 0f;
			num4 = 0.0;
			if (!flag11)
			{
				bool flag12 = (double)num8 > 1.0;
				num4 = 1.0;
				if (!flag12)
				{
					num4 = num8;
				}
			}
		}
		micLevel2.ExternalLevel = (float)num4;
	}

	private void RetryLater(Lobby kind, string code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0273: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7+11]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = this + 264;
		rejoinKind = kind;
		rejoinCode = code;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag4 = (byte)(~(rejoining ? 1u : 0u)) != 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			rejoining = true;
			rejoinWait = 2f;
			float unscaledTime = Time.unscaledTime;
			float num = unscaledTime + 2f;
			rejoinAt = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2D8]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj11 = 0;
			bool flag5 = code._stringLength < 0;
			bool flag6 = code._stringLength == 0;
			int num2 = code._stringLength ^ code._stringLength;
			int num3 = code._stringLength & num2;
			bool flag7 = num3 < 0;
			bool flag8 = flag5 == flag7;
			object obj12 = !flag6;
			object obj13 = flag8 & obj12;
			object obj14 = ~obj13;
			string arg = (string)((obj14 != null) ? obj10 : code);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg2 = default;
			string message = string.Format((string)format, arg, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v16+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
		}
	}

	public void RejoinPublicInstead()
	{
		//IL_0037: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		string text = rejoinCode;
		if (text._stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj4 = 0;
			string message = (string)obj + text + (string)obj2;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			object obj7 = this + 264;
			rejoinCode = (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void OnApplicationQuit()
	{
		quitting = true;
	}

	private void WatchForDrop()
	{
		//IL_0010: Expected Obj, but got I
		//IL_10aa: Expected Obj, but got I4
		//IL_10e2: Expected Obj, but got I4
		//IL_1377: Expected Obj, but got I
		//IL_1387: Expected Obj, but got I
		//IL_1397: Expected Obj, but got I
		//IL_13a7: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_1192: Expected Obj, but got I
		//IL_119b: Expected I4, but got Obj
		//IL_0084: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_0161: Expected I4, but got Obj
		//IL_0580: Expected Obj, but got I4
		//IL_114a: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_0192: Expected I4, but got Obj
		//IL_13dc: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I4
		//IL_01c3: Invalid comparison between F4 and I4
		//IL_01da: Expected F4, but got I4
		//IL_01e2: Expected I4, but got Obj
		//IL_0277: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I4
		//IL_11b9: Expected Obj, but got I
		//IL_11e8: Expected Obj, but got I
		//IL_1212: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_0673: Expected Obj, but got I
		//IL_069d: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I4
		//IL_04ad: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I4
		//IL_04fb: Expected F4, but got I4
		//IL_0bba: Expected Obj, but got I
		//IL_0be7: Expected Obj, but got I4
		//IL_0786: Expected Obj, but got I4
		//IL_1237: Expected Obj, but got I4
		//IL_1240: Expected F4, but got I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_0c1f: Expected Obj, but got I4
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected Obj, but got Unknown
		//IL_0c6e: Expected Obj, but got I4
		//IL_0875: Expected Obj, but got I4
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected Obj, but got Unknown
		//IL_0901: Expected Obj, but got I
		//IL_0911: Expected Obj, but got I
		//IL_098a: Expected Obj, but got I4
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_09c3: Expected Obj, but got I
		//IL_0c8c: Expected Obj, but got I
		//IL_0cb6: Expected Obj, but got I4
		//IL_1266: Expected Obj, but got I
		//IL_1276: Expected Obj, but got I
		//IL_0d9d: Expected Obj, but got I
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da8: Expected Obj, but got Unknown
		//IL_0e18: Expected Obj, but got I
		//IL_0e31: Expected Obj, but got I4
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected Obj, but got Unknown
		//IL_09d8: Expected Obj, but got I
		//IL_0a02: Expected Obj, but got I4
		//IL_0e6a: Expected Obj, but got I
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected Obj, but got Unknown
		//IL_0d0d: Invalid comparison between F4 and I4
		//IL_12e4: Expected Obj, but got I
		//IL_130e: Expected Obj, but got I4
		//IL_0a5c: Expected Obj, but got I
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected Obj, but got Unknown
		//IL_0ad6: Expected Obj, but got I4
		//IL_0b05: Expected Obj, but got I
		//IL_0eea: Expected Obj, but got I
		//IL_0f14: Expected Obj, but got I
		//IL_0b50: Expected Obj, but got I4
		//IL_0f3d: Expected Obj, but got I
		//IL_0fa5: Expected Obj, but got I
		//IL_0fcd: Expected Obj, but got I4
		//IL_1336: Expected Obj, but got I
		//IL_0f88: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I
		//IL_100c: Expected Obj, but got I4
		//IL_1042: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE0D8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+11]");
		string text = (string)(((nint)0 == 0) ? obj9 : obj7);
		if (RoomLabel__BackingField == text)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v152+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v156+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v156+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v113+11]");
			object obj15 = (((nint)0 != 0) ? obj9 : obj7);
			text = (string)obj15;
			object obj16 = this + 120;
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+A0]");
		object obj19 = 0;
		if ((int)(~obj19) == 0 && ~(authWas ? 1u : 0u) != 0 && ~(rejoining ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v141+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (ShiftAuthNeeded)
			{
				float unscaledTime = Time.unscaledTime;
				float num = rejoinAt;
				if (unscaledTime < rejoinAt)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X0_v144+E4]");
					bool flag7 = (nint)0 == 0;
					object obj25 = !flag7;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE298]");
					object message = 0;
					Debug.Log(message);
					unscaledTime = Time.unscaledTime;
					rejoinAt = unscaledTime;
					text = null;
				}
			}
		}
		authWas = (byte)(int)obj19 != 0;
		bool flag8 = (byte)(~(Joining__BackingField ? 1u : 0u)) != 0;
		string text2 = null;
		Lobby lobby = (Lobby)text;
		if (!flag8)
		{
			bool flag9 = (byte)(~(quitting ? 1u : 0u)) != 0;
			object obj26 = !flag9;
			text2 = null;
			lobby = (Lobby)text;
			if (obj26 == null)
			{
				float unscaledTime2 = Time.unscaledTime;
				float unscaledTime = unscaledTime2 - joiningSince;
				bool flag10 = !(unscaledTime > 1.1274813E+09f);
				text2 = null;
				float num = 1.1274813E+09f;
				lobby = (Lobby)text;
				if (!flag10)
				{
					bool flag11 = string.IsNullOrEmpty(joining);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE290]");
					object format = 0;
					string arg;
					object obj29;
					if (flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2A8]");
						object obj27 = 0;
						arg = (string)obj27;
						string text3 = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72D8]");
						object obj28 = 0;
						string text4 = (string)obj28 + joining + (string)obj28;
						string text3 = (string)obj28;
						obj29 = 0;
						arg = text4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object arg2 = default;
					string message2 = string.Format((string)format, arg, arg2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj31 = 0;
					object obj32 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v86+E4]");
					bool flag12 = (nint)0 == 0;
					object obj33 = !flag12;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj34 = 0;
					Joining__BackingField = false;
					object obj35 = obj34;
					int num2 = joinTurn + 1;
					joinTurn = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v126+E4]");
					bool flag13 = (nint)0 == 0;
					object obj36 = !flag13;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = (UnityEngine.Object)runner == (UnityEngine.Object)null;
					bool flag15 = !flag14;
					object obj37 = !flag15;
					if (obj37 == null)
					{
						bool isRunning = runner.IsRunning;
						bool flag16 = !isRunning;
						object obj38 = !flag16;
						text2 = null;
						obj29 = 0;
						num = 1.1274813E+09f;
						lobby = (Lobby)0;
						if (obj38 != null)
						{
							goto IL_056a;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj39 = 0;
					lobby = Kind__BackingField;
					text2 = (string)((joining != null) ? joining : obj39);
					RetryLater(lobby, text2);
					obj29 = 0;
					num = 1.1274813E+09f;
				}
			}
		}
		goto IL_056a;
		IL_056a:
		bool flag17 = (byte)(~(quitting ? 1u : 0u)) != 0;
		object obj40 = !flag17;
		if (obj40 == null)
		{
			bool flag18 = (byte)(~(Joining__BackingField ? 1u : 0u)) != 0;
			object obj41 = !flag18;
			if (obj41 == null)
			{
				bool flag19 = (byte)(~(waitingOnAuth ? 1u : 0u)) != 0;
				object obj42 = !flag19;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
					object obj43 = 0;
					object obj44 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v18+E4]");
					bool flag20 = (nint)0 == 0;
					object obj45 = !flag20;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (GillaModeration.Kicked)
					{
						wasIn = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj46 = 0;
						object obj47 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v22+E4]");
						bool flag21 = (nint)0 == 0;
						object obj48 = !flag21;
						if (obj48 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag22 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
						bool flag23 = !flag22;
						UnityEngine.Object obj49 = null;
						if (!flag23)
						{
							bool isRunning2 = runner.IsRunning;
							bool flag24 = !isRunning2;
							obj49 = null;
							if (!flag24)
							{
								wasIn = true;
								idleSince = -1f;
								return;
							}
						}
						if (~(wasIn ? 1u : 0u) == 0)
						{
							object obj50 = obj;
							wasIn = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v79+E4]");
							bool flag25 = (nint)0 == 0;
							object obj51 = !flag25;
							if (obj51 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F5D184");
							object obj53 = default;
							object obj52 = obj53 & 1;
							if (obj52 != null)
							{
								object obj54 = this + 120;
								obj54 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_ = 0;
								return;
							}
							string text5 = rejoinCode;
							object arg3 = this + 264;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2B8]");
							object format2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2B0]");
							object obj55 = 0;
							bool flag26 = text5._stringLength < 0;
							bool flag27 = text5._stringLength == 0;
							int num3 = text5._stringLength ^ text5._stringLength;
							int num4 = text5._stringLength & num3;
							bool flag28 = num4 < 0;
							bool flag29 = flag26 == flag28;
							object obj56 = !flag27;
							object obj57 = flag29 & obj56;
							object obj58 = ~obj57;
							if (obj58 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2A8]");
								arg3 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2A0]");
							object obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj60 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object arg4 = default;
							string text6 = string.Format((string)format2, arg3, arg4);
							string message3 = (string)obj59 + RoomLabel__BackingField + (string)obj55 + text6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj61 = 0;
							object obj62 = obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v70+E4]");
							bool flag30 = (nint)0 == 0;
							object obj63 = !flag30;
							if (obj63 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogWarning(message3);
							object obj64 = this + 120;
							RoomLabel__BackingField = (string)obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
							object obj65 = 0;
							object obj66 = this + 136;
							obj66 = obj65;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 1073741824;
							_ = 1;
							float unscaledTime3 = Time.unscaledTime;
							object obj67 = obj46;
							float num5 = unscaledTime3 + 2f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X0_v96+E4]");
							bool flag31 = (nint)0 == 0;
							object obj68 = !flag31;
							if (obj68 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X21_v9-18]");
							if ((UnityEngine.Object)0 != null)
							{
								object obj69 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X0_v100+E4]");
								bool flag32 = (nint)0 == 0;
								object obj70 = !flag32;
								if (obj70 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (mic != null)
								{
									mic.Restart();
								}
							}
							return;
						}
						if (~(rejoining ? 1u : 0u) == 0)
						{
							idleSince = -1f;
							float unscaledTime4 = Time.unscaledTime;
							if (unscaledTime4 < rejoinAt)
							{
								return;
							}
							object obj71 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v64+E4]");
							bool flag33 = (nint)0 == 0;
							object obj72 = !flag33;
							if (obj72 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F5D184");
							object obj74 = default;
							object obj73 = obj74 & 1;
							if (obj73 != null)
							{
								rejoining = false;
								return;
							}
							float num6 = rejoinWait + rejoinWait;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
							rejoinWait = num6;
							float unscaledTime5 = Time.unscaledTime;
							string text7 = rejoinCode;
							float num7 = unscaledTime5 + rejoinWait;
							rejoinAt = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2D0]");
							object format3 = 0;
							object arg5 = this + 264;
							bool flag34 = text7._stringLength < 0;
							bool flag35 = text7._stringLength == 0;
							int num8 = text7._stringLength ^ text7._stringLength;
							int num9 = text7._stringLength & num8;
							bool flag36 = num9 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj75 = 0;
							bool flag37 = flag34 == flag36;
							object obj76 = !flag35;
							object obj77 = flag37 & obj76;
							object obj78 = ~obj77;
							if (obj78 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2A8]");
								arg5 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object arg6 = default;
							string message4 = string.Format((string)format3, arg5, arg6);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj79 = 0;
							object obj80 = obj79;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v62+E4]");
							bool flag38 = (nint)0 == 0;
							object obj81 = !flag38;
							if (obj81 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.Log(message4);
							Join(rejoinKind, rejoinCode, probe: false);
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2C0]");
						object obj82 = 0;
						bool flag39 = RoomLabel__BackingField == (string)obj82;
						bool flag40 = !flag39;
						object obj83 = !flag40;
						if (obj83 == null)
						{
							object obj84 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v29+E4]");
							bool flag41 = (nint)0 == 0;
							object obj85 = !flag41;
							if (obj85 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F5D184");
							object obj87 = default;
							object obj86 = obj87 & 1;
							bool flag42 = obj86 == null;
							object obj88 = !flag42;
							if (obj88 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
								object obj89 = 0;
								object obj90 = obj89;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X0_v33+E4]");
								bool flag43 = (nint)0 == 0;
								object obj91 = !flag43;
								if (obj91 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (GillaIntegrity.Cleared)
								{
									float unscaledTime6 = Time.unscaledTime;
									if (idleSince < 0f)
									{
										idleSince = unscaledTime6;
										return;
									}
									float num10 = unscaledTime6 - idleSince;
									if (!((double)num10 < 15.0))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
										object obj92 = 0;
										idleSince = -1f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE280]");
										object obj93 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2C8]");
										object obj94 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										if (string.IsNullOrEmpty(joining))
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2A8]");
											object obj95 = 0;
											string text8 = (string)obj95;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72D8]");
											object obj96 = 0;
											string text9 = (string)obj96 + joining + (string)obj96;
											string text8 = text9;
											object obj29 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE288]");
										object obj97 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
										string[] array = default;
										string message5 = string.Concat(array);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj98 = 0;
										object obj99 = obj98;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v45+E4]");
										bool flag44 = (nint)0 == 0;
										object obj100 = !flag44;
										if (obj100 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.LogWarning(message5);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										object obj101 = 0;
										RetryLater(code: (string)((joining != null) ? joining : obj101), kind: Kind__BackingField);
									}
									return;
								}
							}
						}
					}
				}
			}
		}
		idleSince = -1f;
	}

	private unsafe static Task Leave(NetworkRunner r, string what)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I
		//IL_0058: Expected Obj, but got Ref
		//IL_0070: Expected Obj, but got Ref
		//IL_008d: Expected VT, but got I
		//IL_009a: Expected Ref, but got VT
		//IL_00a8: Expected VT, but got I
		//IL_00b1: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		RipButton._003CLeave_003Ed__180 stateMachine = default;
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start<RipButton._003CLeave_003Ed__180>(ref stateMachine);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
	}

	public void JoinRoom(string code)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		object obj = this + 152;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		rejoining = false;
		if (queued == null)
		{
			object obj2 = 144;
		}
		else
		{
			object obj2 = 200;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NetworkBootstrap)+v45 @ X8_v3]");
		Join((Lobby)0, code, probe: false);
	}

	public unsafe void Disconnect()
	{
		//IL_0039: Expected Obj, but got I
		//IL_0051: Expected Obj, but got Ref
		//IL_0014: Expected VT, but got I
		//IL_0021: Expected Ref, but got VT
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		_003CDisconnect_003Ed__182 stateMachine = default;
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start<_003CDisconnect_003Ed__182>(ref stateMachine);
	}

	public void JoinLobby(Lobby kind, string code)
	{
		rejoining = false;
		Join(kind, code, probe: false);
	}

	private unsafe void Join(Lobby kind, string code, bool probe = default(bool))
	{
		//IL_0056: Expected Obj, but got I
		//IL_006e: Expected Obj, but got Ref
		//IL_0014: Expected Obj, but got Ref
		//IL_002c: Expected VT, but got I
		//IL_0039: Expected Ref, but got VT
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		_003CJoin_003Ed__184 stateMachine = default;
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start<_003CJoin_003Ed__184>(ref stateMachine);
	}

	private unsafe Task JoinCore(Lobby kind, string code, bool probe)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got Ref
		//IL_0058: Expected Obj, but got Ref
		//IL_0070: Expected Obj, but got Ref
		//IL_008d: Expected VT, but got Ref
		//IL_009a: Expected Ref, but got VT
		//IL_00a8: Expected VT, but got Ref
		//IL_00b1: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		_003CJoinCore_003Ed__185 stateMachine = default;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 8));
		((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start<_003CJoinCore_003Ed__185>(ref stateMachine);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 8));
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
	}

	public NetworkBootstrap()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE318]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		object obj4 = this + 40;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = this + 120;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = this + 128;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = this + 136;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = this + 216;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = this + 232;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = this + 264;
		rejoinCode = (string)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		idleSince = -1f;
		base._002Ector();
	}

	static NetworkBootstrap()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
		object obj3 = 0;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj5 = (nint)0 + (nint)24;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+A0]");
		object obj7 = (nint)0 + (nint)32;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v5+A0]");
		object obj9 = (nint)0 + (nint)40;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.Random random = default;
		random._002Ector();
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+A0]");
		object obj11 = (nint)0 + (nint)64;
		obj11 = random;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
