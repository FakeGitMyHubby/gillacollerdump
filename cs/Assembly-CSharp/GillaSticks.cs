using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public static class GillaSticks
{
	private static readonly List<UnityEngine.XR.InputDevice> devices;

	public const float TouchGrace = default(float);

	public const float PushedAt = default(float);

	public const float MiddleUnder = default(float);

	public const float PushTime = default(float);

	private static readonly bool[] doubted;

	private static readonly float[] middleAt;

	public static Func<int, (Vector2, bool, bool, float)> TestRaw;

	private static readonly bool[] touchWorks;

	private static readonly float[] touchedAt;

	private static readonly float[] toldAt;

	private const float RestMost = default(float);

	private const float RestMostGripped = default(float);

	private const float RestSettle = default(float);

	private static readonly Vector2[] rest;

	private static readonly float[] restAt;

	private const float GripOn = default(float);

	private const float GripOff = default(float);

	private static readonly bool[] gripped;

	public const float HoldOn = default(float);

	public const float HoldOff = default(float);

	public const float PushFar = default(float);

	public const float PushLeast = default(float);

	public const float PushQuick = default(float);

	public const float NearBase = default(float);

	public const float BackNear = default(float);

	private const float Creep = default(float);

	private const float NoThumb = default(float);

	private const float AfterHold = default(float);

	public const float PushSmall = default(float);

	public const float SmallNear = default(float);

	public const float SmallQuick = default(float);

	public const float GripSettle = default(float);

	public const float Resqueeze = default(float);

	private static readonly bool[] holding;

	private static readonly bool[] pushing;

	private static readonly Vector2[] holdBase;

	private static readonly float[] nearAt;

	private static readonly float[] squeezedAt;

	private static readonly float[] letGoAt;

	private static readonly float[] settledFrom;

	private static readonly float[] smallNearAt;

	private static readonly float[] gripLow;

	private static readonly float[] pushEnd;

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ForgetTouch();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
		object obj5 = (nint)0 + (nint)24;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public static void ForgetTouch()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0818: Expected Obj, but got I
		//IL_0821: Expected Obj, but got I4
		//IL_086d: Expected Obj, but got I4
		//IL_0905: Expected Obj, but got I
		//IL_0915: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0353: Expected Obj, but got I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0386: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0455: Expected Obj, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_04da: Expected Obj, but got I
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0514: Expected Obj, but got I
		//IL_0524: Expected Obj, but got I
		//IL_056a: Expected Obj, but got I4
		//IL_0588: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_05fd: Expected Obj, but got I4
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0668: Expected Obj, but got I4
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_06c4: Expected Obj, but got I4
		//IL_08e7: Expected Obj, but got I4
		//IL_088b: Expected Obj, but got I
		//IL_089b: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I4
		//IL_0759: Expected Obj, but got I
		//IL_0769: Expected Obj, but got I
		//IL_078f: Expected Obj, but got I4
		//IL_07b5: Expected Obj, but got I
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		object obj3 = 0;
		object obj4 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v12+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+20]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+20]");
			if ((nint)0 != 0)
			{
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v2+18]");
				bool flag2 = (nint)obj8 < 0;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+28]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+20]");
				object obj11 = 0 + obj4;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+28]");
				if ((nint)0 != 0)
				{
					object obj12 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v5+18]");
					bool flag3 = (nint)obj12 < 0;
					object obj13 = !flag3;
					if (obj13 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+28]");
					object obj14 = 0 + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+30]");
					object obj15 = 0;
					_ = 4286578687L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+30]");
					if ((nint)0 != 0)
					{
						object obj16 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X9_v7+18]");
						bool flag4 = (nint)obj16 < 0;
						object obj17 = !flag4;
						if (obj17 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+30]");
						object obj18 = 0 + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+40]");
						object obj19 = 0;
						_ = 4286578687L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+40]");
						if ((nint)0 != 0)
						{
							object obj20 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v8+18]");
							bool flag5 = (nint)obj20 < 0;
							object obj21 = !flag5;
							if (obj21 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+40]");
							object obj22 = 0 + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+48]");
							object obj23 = 0;
							_ = 4286578687L;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+48]");
							if ((nint)0 != 0)
							{
								object obj24 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X10_v10+18]");
								bool flag6 = (nint)obj24 < 0;
								object obj25 = !flag6;
								if (obj25 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+8]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+48]");
								object obj27 = 0 + obj4;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+8]");
								if ((nint)0 != 0)
								{
									object obj28 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X9_v11+18]");
									bool flag7 = (nint)obj28 < 0;
									object obj29 = !flag7;
									if (obj29 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+10]");
									object obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+8]");
									object obj31 = 0 + obj4;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+10]");
									if ((nint)0 != 0)
									{
										object obj32 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X10_v13+18]");
										bool flag8 = (nint)obj32 < 0;
										object obj33 = !flag8;
										if (obj33 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+10]");
										object obj34 = 0 + obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+58]");
										object obj35 = 0;
										_ = 4286578687L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+58]");
										if ((nint)0 != 0)
										{
											object obj36 = obj4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X10_v14+18]");
											bool flag9 = (nint)obj36 < 0;
											object obj37 = !flag9;
											if (obj37 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+50]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+58]");
											object obj39 = 0 + obj4;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+50]");
											if ((nint)0 != 0)
											{
												object obj40 = obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v16+18]");
												bool flag10 = (nint)obj40 < 0;
												object obj41 = !flag10;
												if (obj41 != null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+50]");
												object obj42 = 0 + obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+60]");
												object obj43 = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+60]");
												if ((nint)0 != 0)
												{
													object obj44 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X25_v4+18]");
													bool flag11 = (nint)obj44 < 0;
													object obj45 = !flag11;
													if (obj45 != null)
													{
														break;
													}
													object obj46 = obj3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v9+A0]");
													object obj47 = 0;
													object obj48 = obj47;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v5+60]");
													object obj49 = 0 + obj4;
													obj2 = obj;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v12+A0]");
													object obj50 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12+78]");
													object obj51 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12+78]");
													if ((nint)0 != 0)
													{
														object obj52 = obj4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X10_v17+18]");
														bool flag12 = (nint)obj52 < 0;
														object obj53 = !flag12;
														if (obj53 != null)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12+68]");
														object obj54 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v13+70]");
														object obj55 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12+78]");
														object obj56 = 0 + obj4;
														_ = 4286578687L;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v13+70]");
														if ((nint)0 != 0)
														{
															object obj57 = obj4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v20+18]");
															bool flag13 = (nint)obj57 < 0;
															object obj58 = !flag13;
															if (obj58 != null)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v13+70]");
															object obj59 = 0 + obj4;
															_ = 4286578687L;
															if (obj54 != null)
															{
																object obj60 = obj4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v13+18]");
																bool flag14 = (nint)obj60 < 0;
																object obj61 = !flag14;
																if (obj61 != null)
																{
																	break;
																}
																object obj62 = obj54 + obj4;
																obj4++;
																_ = 4286578687L;
																if ((nint)obj4 != 2)
																{
																	continue;
																}
																object obj63 = 0;
																while (true)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v12+E4]");
																	bool flag15 = (nint)0 == 0;
																	object obj64 = !flag15;
																	if (obj64 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																		obj2 = obj;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v12+A0]");
																	object obj65 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v17+38]");
																	object obj66 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v17+38]");
																	if ((nint)0 == 0)
																	{
																		break;
																	}
																	object obj67 = obj63;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X24_v7+18]");
																	if ((nint)obj67 < 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v12+E4]");
																		bool flag16 = (nint)0 == 0;
																		object obj68 = !flag16;
																		if (obj68 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			object obj69 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v26+A0]");
																			object obj70 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v27+38]");
																			obj66 = 0;
																		}
																		if (obj66 == null)
																		{
																			break;
																		}
																		object obj71 = obj63;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X24_v7+18]");
																		bool flag17 = (nint)obj71 < 0;
																		object obj72 = !flag17;
																		if (obj72 != null)
																		{
																			goto end_IL_084b;
																		}
																		object obj73 = obj3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v23+A0]");
																		object obj74 = 0;
																		obj48 = obj74;
																		object obj75 = obj66 + obj63;
																		obj63++;
																		obj2 = obj;
																		continue;
																	}
																	return;
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
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			continue;
			end_IL_084b:
			break;
		}
		throw new IndexOutOfRangeException();
	}

	public unsafe static Vector2 Read(XRNode hand, float deadzone = default(float), bool trustPushes = default(bool))
	{
		//IL_0bfe: Expected Obj, but got I
		//IL_1024: Expected Obj, but got I
		//IL_1044: Expected Obj, but got I
		//IL_104c: Expected F4, but got Obj
		//IL_105c: Expected F4, but got I
		//IL_107e: Expected Obj, but got I4
		//IL_0c23: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		//IL_0ca7: Expected VT, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_0ad5: Expected F4, but got I4
		//IL_0ae7: Expected VT, but got I4
		//IL_0af0: Expected VT, but got I4
		//IL_0af9: Expected F4, but got I4
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected F4, but got I4
		//IL_00c3: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected I4, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected VT, but got Unknown
		//IL_01b1: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_009f: Expected VT, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_0261: Expected I, but got Obj
		//IL_04f8: Expected Obj, but got I4
		//IL_0da2: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I4
		//IL_0d11: Expected Obj, but got I
		//IL_0d2f: Expected I, but got Obj
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got I
		//IL_0545: Expected F4, but got I4
		//IL_0557: Expected VT, but got I4
		//IL_055f: Expected VT, but got F4
		//IL_0568: Expected VT, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got I4
		//IL_0583: Expected Obj, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_0312: Expected I4, but got VT
		//IL_0317: Expected I, but got Obj
		//IL_071b: Expected F4, but got VT
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got I4
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected Obj, but got I4
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected F4, but got Unknown
		//IL_0760: Expected Obj, but got I4
		//IL_0fcb: Expected Obj, but got I
		//IL_0fd3: Expected I4, but got Obj
		//IL_0ff6: Expected Obj, but got I4
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Expected F4, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected VT, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got I4
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Expected Obj, but got I
		//IL_0d76: Expected I4, but got VT
		//IL_0d7b: Expected I, but got Obj
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Invalid comparison between Unknown and I4
		//IL_077f: Expected Obj, but got I4
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected Obj, but got Ref
		//IL_05fc: Expected Obj, but got I4
		//IL_0dfa: Expected Obj, but got I
		//IL_0e13: Expected VT, but got I
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Expected VT, but got Unknown
		//IL_038d: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_03a5: Expected I4, but got Obj
		//IL_03bb: Expected Obj, but got I
		//IL_03e0: Expected I4, but got VT
		//IL_03e5: Expected I, but got Obj
		//IL_0e66: Expected Obj, but got I4
		//IL_109c: Expected Obj, but got I
		//IL_10b5: Expected VT, but got I
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Expected Obj, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected Obj, but got Unknown
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e9: Expected Obj, but got Unknown
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected Obj, but got Unknown
		//IL_1121: Expected Obj, but got I4
		//IL_113b: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got VT
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got I4
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got I4
		//IL_07dc: Expected VT, but got Ref
		//IL_0e8e: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I
		//IL_049f: Expected Obj, but got I
		//IL_04af: Expected Obj, but got I
		//IL_04c4: Expected I4, but got VT
		//IL_04c9: Expected I, but got Obj
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected Obj, but got I4
		//IL_1162: Expected Obj, but got I
		//IL_117b: Expected VT, but got I
		//IL_1183: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Expected Obj, but got Unknown
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b7: Expected Obj, but got Unknown
		//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Expected Obj, but got Unknown
		//IL_11f9: Expected Obj, but got I4
		//IL_1201: Unknown result type (might be due to invalid IL or missing references)
		//IL_1206: Expected Obj, but got Unknown
		//IL_120e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1213: Expected Obj, but got Unknown
		//IL_122d: Expected Obj, but got I4
		//IL_1236: Expected I4, but got Obj
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected F4, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got I
		//IL_0475: Expected I4, but got VT
		//IL_047a: Expected I, but got Obj
		//IL_0eec: Expected Obj, but got I4
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Expected VT, but got Unknown
		//IL_0ead: Expected Obj, but got I4
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected Obj, but got I4
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected VT, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected I4, but got Unknown
		//IL_0853: Expected Obj, but got I
		//IL_0863: Expected Obj, but got I
		//IL_0887: Expected Obj, but got I4
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0a: Expected Obj, but got I
		//IL_0f1a: Expected Obj, but got I
		//IL_08a5: Expected Obj, but got I
		//IL_0f51: Expected Obj, but got I
		//IL_0f61: Expected Obj, but got I
		//IL_0f69: Expected I4, but got Obj
		//IL_0f71: Expected I, but got Obj
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected F4, but got Unknown
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected Obj, but got Unknown
		//IL_098b: Expected Obj, but got I4
		//IL_09a0: Expected Obj, but got I
		//IL_09a8: Expected I4, but got Obj
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Invalid comparison between F4 and I4
		//IL_09dc: Invalid comparison between F4 and I4
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected Obj, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected Obj, but got Unknown
		//IL_0a31: Expected Obj, but got I4
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+A0]");
		object obj5 = 0;
		float num = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v8+4]");
		float num2 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+A0]");
		InputDeviceCharacteristics inputDeviceCharacteristics = (InputDeviceCharacteristics)0u;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+E4]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X9_v17 (UnityEngine.XR.InputDeviceCharacteristics)+18]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X9_v17 (UnityEngine.XR.InputDeviceCharacteristics)+18]");
		bool feels;
		Vector2 best;
		float deadzone2;
		bool touched;
		float grip;
		bool left;
		UnityEngine.XR.InputDevice inputDevice;
		bool flag4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v73+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v74+18]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v74+18]");
				bool flag3 = (nint)0 == 0;
				inputDevice = (UnityEngine.XR.InputDevice)0;
				flag4 = trustPushes;
				if (flag3)
				{
					goto IL_0acc;
				}
			}
			object obj12 = hand - 4;
			bool flag5 = obj12 == null;
			object obj13 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v114 @ X8_v71+18] (should have been resolved before IL gen)");
			float num4 = default;
			float num3 = num4 >> 32;
			object obj14 = obj13 >> 8;
			feels = (byte)(obj14 & 1) != 0;
			best = (Vector2)(obj13 & 1);
			deadzone2 = num3;
			touched = trustPushes;
			grip = num4;
			left = flag5;
			goto IL_0c58;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+A0]");
			inputDeviceCharacteristics = (InputDeviceCharacteristics)0u;
		}
		flag4 = (byte)((InputDeviceCharacteristics*)(int)inputDeviceCharacteristics)->value__ != 0;
		bool flag7 = (byte)(~((InputDeviceCharacteristics*)(int)inputDeviceCharacteristics)->value__) != 0;
		inputDevice = (UnityEngine.XR.InputDevice)0;
		nint num5;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X1_v3 (System.Boolean)+1C]");
			object obj16 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v52+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			List<UnityEngine.XR.InputDevice> inputDevices = (List<UnityEngine.XR.InputDevice>)((InputDeviceCharacteristics*)(int)inputDeviceCharacteristics)->value__;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v69+A0]");
				object obj19 = 0;
				inputDevices = (List<UnityEngine.XR.InputDevice>)obj19;
			}
			InputDeviceCharacteristics desiredCharacteristics = ((hand != (XRNode)4) ? ((InputDeviceCharacteristics)576u) : ((InputDeviceCharacteristics)320u));
			InputDevices.GetDevicesWithCharacteristics(desiredCharacteristics, inputDevices);
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(hand);
			bool isValid = inputDevice.isValid;
			bool flag9 = !isValid;
			flag4 = false;
			num5 = unchecked((nint)null);
			inputDeviceCharacteristics = (InputDeviceCharacteristics)320u;
			if (flag9)
			{
				goto IL_04ce;
			}
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v89+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v89+A0]");
			object obj22 = 0;
			bool flag11 = obj22 == null;
			flag4 = false;
			num5 = unchecked((nint)null);
			inputDeviceCharacteristics = (InputDeviceCharacteristics)320u;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F00]");
				object obj23 = 0;
				object obj24 = obj23;
				bool flag12 = ((List<UnityEngine.XR.InputDevice>)obj22).Contains(inputDevice);
				bool flag13 = !flag12;
				object obj25 = !flag13;
				flag4 = (byte)(int)inputDevice != 0;
				num5 = unchecked((nint)null);
				inputDeviceCharacteristics = (InputDeviceCharacteristics)320u;
				if (obj25 != null)
				{
					goto IL_04ce;
				}
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v93+E4]");
				bool flag14 = (nint)0 == 0;
				object obj27 = !flag14;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj26 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X0_v93+A0]");
				object obj28 = 0;
				List<UnityEngine.XR.InputDevice> list = (List<UnityEngine.XR.InputDevice>)obj28;
				bool flag15 = obj28 == null;
				flag4 = (byte)(int)inputDevice != 0;
				num5 = unchecked((nint)null);
				inputDeviceCharacteristics = (InputDeviceCharacteristics)320u;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EF0]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+10]");
					object obj30 = 0;
					inputDeviceCharacteristics = (InputDeviceCharacteristics)(int)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+1C]");
					obj7 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+10]");
					bool flag16 = (nint)0 == 0;
					flag4 = (byte)(int)inputDevice != 0;
					num5 = unchecked((nint)null);
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+18]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v65+18]");
						bool flag17 = num6 < 0;
						object obj31 = !flag17;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+10]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+18]");
							object obj32 = num7 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v94 (System.Collections.Generic.List`1<UnityEngine.XR.InputDevice>)+18]");
							inputDeviceCharacteristics = (InputDeviceCharacteristics)((nuint)0u + (nuint)1u);
							_ = 0;
							flag4 = (byte)(int)inputDevice != 0;
							num5 = unchecked((nint)null);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X9_v17 (UnityEngine.XR.InputDeviceCharacteristics)+20]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v66+A8]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v67+70]");
							obj24 = 0;
							((List<UnityEngine.XR.InputDevice>)obj28).AddWithResize(inputDevice);
							flag4 = (byte)(int)inputDevice != 0;
							num5 = unchecked((nint)null);
						}
						goto IL_04ce;
					}
				}
			}
		}
		goto IL_0acc;
		IL_0efa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F10]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EE0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
		ButtonControl buttonControl = default;
		object obj37;
		object obj38;
		if (buttonControl != null)
		{
			bool isPressed = buttonControl.isPressed;
			obj37 |= isPressed;
			obj38 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F18]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8ED8]");
		object obj40 = 0;
		flag4 = (byte)(int)obj39 != 0;
		num5 = (nint)obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
		InputControl<float> inputControl = default;
		Enumerator<, > val;
		float num8;
		if (inputControl != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8ED0]");
			object obj41 = 0;
			flag4 = (byte)(int)obj41 != 0;
			num8 = inputControl.ReadValue();
			float num9 = (float)val - num8;
			bool flag18 = num9 < 0f;
			bool flag19 = num9 == 0f;
			object obj42 = val ^ num8;
			object obj43 = val ^ num9;
			object obj44 = obj42 & obj43;
			bool flag20 = (nint)obj44 < 0;
			bool flag21 = flag18 == flag20;
			object obj45 = !flag19;
			object obj46 = flag21 & obj45;
			object obj47 = ~obj46;
			if (obj47 != null)
			{
			}
		}
		goto IL_0ec2;
		IL_0c58:
		bool trustPushes2 = default;
		Vector2 result = Kept(left, best, feels, touched, grip, deadzone2, trustPushes2);
		goto IL_0ac7;
		IL_0ec2:
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X0_v9+E4]");
		bool flag22 = (nint)0 == 0;
		object obj49 = !flag22;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = hand - 4;
		bool flag23 = obj50 == null;
		best = (Vector2)(obj38 & 1);
		feels = (byte)(obj37 & 1) != 0;
		deadzone2 = num2;
		touched = trustPushes;
		grip = num;
		left = flag23;
		goto IL_0c58;
		IL_0acc:
		float value = 0f;
		bool flag24 = false;
		Vector2 vector = (Vector2)0;
		UnityEngine.XR.InputDevice inputDevice2 = (UnityEngine.XR.InputDevice)0;
		float num10 = 0f;
		Enumerator<, > val2 = (Enumerator<, >)0;
		num8 = 0f;
		throw new NullReferenceException();
		IL_04ce:
		object obj51 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v61+E4]");
		bool flag25 = (nint)0 == 0;
		object obj52 = !flag25;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj51 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v61+A0]");
		object obj53 = 0;
		if (obj53 == null)
		{
			goto IL_0acc;
		}
		Enumerator<, > enumerator = ((List<UnityEngine.XR.InputDevice>)obj53).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
		object obj54 = 0;
		value = 0f;
		flag24 = false;
		vector = (Vector2)0;
		Vector2 vector2 = (Vector2)num;
		inputDevice2 = (UnityEngine.XR.InputDevice)0;
		val = (Enumerator<, >)0;
		obj37 = 0;
		obj38 = 0;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		Enumerator<, > val6 = default;
		Enumerator<, > val5 = val6;
		Enumerator<, > val7 = default;
		float num11;
		float num12;
		float num14;
		float num13;
		while (val2.MoveNext())
		{
			bool isValid2 = inputDevice2.isValid;
			bool flag26 = !isValid2;
			inputDevice2 = (UnityEngine.XR.InputDevice)val4;
			val5 = val4;
			if (flag26)
			{
				continue;
			}
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v70+E4]");
			bool flag27 = (nint)0 == 0;
			object obj56 = !flag27;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj55 = obj54;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X0_v70+A0]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v51+88]");
			bool flag28 = inputDevice2.TryGetFeatureValue((InputFeatureUsage<Vector2>)0, out vector);
			bool flag29 = !flag28;
			Vector2 vector3 = (Vector2)val4;
			if (!flag29)
			{
				num11 = (float)vector2 * (float)vector2;
				num12 = num2 * num2;
				object obj58 = vector * vector;
				object obj59 = val7 * val7;
				num13 = (float)obj58 + (float)obj59;
				num14 = num11 + num12;
				bool flag30 = !(num13 > num14);
				val3 = val7;
				vector3 = vector;
				if (!flag30)
				{
					num2 = (float)val7;
					vector2 = vector;
					val3 = val7;
					vector3 = vector;
				}
			}
			object obj60 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v74+E4]");
			bool flag31 = (nint)0 == 0;
			object obj61 = !flag31;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj60 = obj54;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v74+A0]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X8_v53+48]");
			bool flag32 = inputDevice2.TryGetFeatureValue((InputFeatureUsage<bool>)0, out flag24);
			object obj63 = obj37 & 1;
			object obj64 = obj54;
			obj38 = flag32 | obj38;
			object obj65 = flag24 | obj63;
			object obj66 = obj65 & 0xFF;
			bool flag33 = obj66 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v55+E4]");
			inputDeviceCharacteristics = (InputDeviceCharacteristics)0u;
			object obj67 = !flag33;
			bool flag34 = !flag32;
			object obj68 = !flag34;
			object obj69 = ~obj68;
			if (obj69 == null)
			{
				obj37 = obj67;
			}
			bool flag35 = inputDeviceCharacteristics == 0;
			object obj70 = !flag35;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj64 = obj54;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v55+A0]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X8_v56+80]");
			bool flag36 = inputDevice2.TryGetFeatureValue((InputFeatureUsage<float>)0, out value);
			object obj72 = value - val;
			bool flag37 = (nint)obj72 < 0;
			bool flag38 = obj72 == null;
			object obj73 = value ^ val;
			object obj74 = value ^ obj72;
			object obj75 = obj73 & obj74;
			bool flag39 = (nint)obj75 < 0;
			bool flag40 = flag37 == flag39;
			object obj76 = !flag38;
			object obj77 = flag40 & obj76;
			object obj78 = flag36 & obj77;
			bool flag41 = obj78 == null;
			object obj79 = !flag41;
			if ((int)(~obj79) == 0)
			{
				val = (Enumerator<, >)value;
			}
			inputDevice2 = (UnityEngine.XR.InputDevice)val4;
			object obj24 = 0;
			val5 = (Enumerator<, >)value;
			num5 = (nint)(&value);
		}
		num = (float)vector2;
		Enumerator<, > val8 = (Enumerator<, >)0;
		object obj80 = 0;
		Enumerator<, > val9 = val4;
		val2 = val6;
		object obj81 = 10;
		Enumerator<, > val10 = (Enumerator<, >)(ref val2);
		num8 = (float)val5;
		object obj82 = 0;
		object obj86 = default;
		Vector2 result2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB8]");
			object obj83 = 0;
			flag4 = (byte)(int)obj83 != 0;
			val2.Dispose();
			bool flag42 = obj82 == null;
			object obj84 = !flag42;
			val4 = val8;
			num10 = (float)val9;
			if (obj84 == null)
			{
				bool flag43 = (int)val8 == 0;
				object obj85 = !flag43;
				val4 = val8;
				OutOfMemoryException ex = (OutOfMemoryException)(&val2);
				if (obj85 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				val9 = (Enumerator<, >)num10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch (flag4)
			{
			case true:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				val4 = (Enumerator<, >)1;
				obj82 = obj80;
				break;
			case true:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj82 = obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj80 = obj86;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EC00");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
			val8 = val4;
			obj81 = 0;
		}
		if ((nint)obj81 != 10)
		{
			bool flag44 = obj81 == null;
			object obj87 = !flag44;
			result = (Vector2)(&val2);
			if (obj87 != null)
			{
				goto IL_0ac7;
			}
		}
		XRController xRController = ((hand != (XRNode)4) ? XRController.rightHand : XRController.leftHand);
		if (xRController == null)
		{
			goto IL_0ec2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F20]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EE8]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
		InputControl<Vector2> inputControl2 = default;
		bool flag45 = inputControl2 == null;
		object obj90 = !flag45;
		if (obj90 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F28]");
			object obj91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3661280");
			if (inputControl2 == null)
			{
				goto IL_0efa;
			}
		}
		Vector2 vector4 = inputControl2.ReadValue();
		float num15 = num * num;
		float num16 = num8 * num8;
		num11 = (float)val3 * (float)val3;
		num12 = num2 * num2;
		num14 = num16 + num11;
		num13 = num15 + num12;
		if (num14 > num13)
		{
			num2 = (float)val3;
			num = num8;
		}
		goto IL_0efa;
		IL_0ac7:
		return result;
	}

	private unsafe static Vector2 Kept(bool left, Vector2 best, bool feels, bool touched, float grip, float deadzone, bool trustPushes)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d56: Expected Obj, but got I4
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected I4, but got Unknown
		//IL_0d97: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected VT, but got Unknown
		//IL_0db5: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I
		//IL_0e30: Invalid comparison between F4 and I
		//IL_009d: Invalid comparison between F4 and I
		//IL_00bc: Expected VT, but got Obj
		//IL_00de: Expected Obj, but got I4
		//IL_0e57: Expected Obj, but got I
		//IL_0e67: Expected Obj, but got I
		//IL_0d4b: Expected VT, but got Obj
		//IL_00fe: Expected VT, but got Obj
		//IL_0124: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		//IL_0e9c: Expected Obj, but got I
		//IL_01ec: Expected VT, but got Obj
		//IL_01fc: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_0ed1: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I8
		//IL_03e6: Expected Obj, but got I
		//IL_03f1: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected Obj, but got Unknown
		//IL_0f38: Expected Obj, but got I4
		//IL_0f4e: Expected Obj, but got I
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected Obj, but got Unknown
		//IL_0432: Expected Obj, but got I
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0462: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I8
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04f1: Expected Obj, but got I4
		//IL_0507: Expected Obj, but got I
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_054a: Expected Obj, but got I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0587: Expected Ref, but got F4
		//IL_05b2: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		//IL_063d: Expected Obj, but got I4
		//IL_0653: Expected Obj, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_0696: Expected Obj, but got I
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06e0: Expected Obj, but got I4
		//IL_0f91: Expected Obj, but got I
		//IL_0fa1: Expected Obj, but got I
		//IL_0726: Expected Obj, but got I4
		//IL_0748: Expected Obj, but got I8
		//IL_077a: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Expected Obj, but got Unknown
		//IL_1008: Expected Obj, but got I4
		//IL_101e: Expected Obj, but got I
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1043: Expected Obj, but got Unknown
		//IL_07b2: Expected Obj, but got I
		//IL_07dc: Expected Obj, but got I
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected Obj, but got Unknown
		//IL_0826: Expected Obj, but got I4
		//IL_1061: Expected Obj, but got I
		//IL_1071: Expected Obj, but got I
		//IL_086c: Expected Obj, but got I4
		//IL_088a: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I
		//IL_08de: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got I4
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected Obj, but got Unknown
		//IL_10cc: Expected Obj, but got I4
		//IL_08fe: Expected Obj, but got I4
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_0943: Expected Ref, but got F4
		//IL_0963: Expected Obj, but got I4
		//IL_0973: Expected Obj, but got I4
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected Obj, but got Unknown
		//IL_09e8: Expected Obj, but got I4
		//IL_09fe: Expected Obj, but got I
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a69: Expected Obj, but got I
		//IL_0a79: Expected Obj, but got I
		//IL_0abf: Expected Obj, but got I4
		//IL_0add: Expected Obj, but got I
		//IL_0b17: Expected Obj, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0b4d: Expected Obj, but got I4
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected Obj, but got Unknown
		//IL_0b8d: Expected Ref, but got F4
		//IL_0bad: Expected Obj, but got I4
		//IL_0bbd: Expected Obj, but got I4
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got Unknown
		//IL_0c32: Expected Obj, but got I4
		//IL_0c48: Expected Obj, but got I
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected Obj, but got Unknown
		//IL_0c8b: Expected Obj, but got I
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected Obj, but got Unknown
		//IL_0ccd: Expected Obj, but got I
		//IL_0cf7: Expected Obj, but got I4
		//IL_0d25: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = !left;
		int num = 1 & obj2;
		float unscaledTime = Time.unscaledTime;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 stick = (Vector2)(best & 1);
		float deadzone2 = default;
		Vector2 result = Taken(num, stick, feels, touched, grip, deadzone, deadzone2, trustPushes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+A0]");
		object obj7 = 0;
		float num2 = deadzone;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v10+4]");
		float num3 = num2 - 0f;
		float num4 = grip - (float)obj7;
		float num5 = num4 * num4;
		float num6 = num3 * num3;
		float num7 = num5 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (num7 < 0f)
		{
			float num8 = grip * grip;
			float num9 = deadzone * deadzone;
			float num10 = num8 + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			if (num10 > 0f)
			{
				result = (Vector2)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15 (UnityEngine.Vector2)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					result = (Vector2)obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15 (UnityEngine.Vector2)+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+30]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+30]");
				if ((nint)0 == 0)
				{
					goto IL_0d3d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v2+18]");
				bool flag3 = (nint)num < (nint)0;
				object obj11 = !flag3;
				if (obj11 != null)
				{
					goto IL_0d2f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+30]");
				object obj12 = (nint)0 + (nint)num;
				float num11 = unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X9_v5+20]");
				float num12 = num11 - 0f;
				if ((double)num12 > 10.0)
				{
					bool flag4 = !feels;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15 (UnityEngine.Vector2)+E4]");
						bool flag5 = (nint)0 == 0;
						object obj14 = !flag5;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							result = (Vector2)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15 (UnityEngine.Vector2)+A0]");
							obj9 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+20]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v7+18]");
							bool flag6 = (nint)num < (nint)0;
							object obj16 = !flag6;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+20]");
								object obj17 = (nint)0 + (nint)num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X9_v8+20]");
								if ((nint)0 == 0)
								{
									goto IL_0d2a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15 (UnityEngine.Vector2)+E4]");
								bool flag7 = (nint)0 == 0;
								object obj18 = !flag7;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj19 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v68+A0]");
									obj9 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+30]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+30]");
								if ((nint)0 == 0)
								{
									goto IL_0d3d;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v20+18]");
								bool flag8 = (nint)num < (nint)0;
								object obj21 = !flag8;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v19+30]");
									object obj22 = (nint)0 + (nint)num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									string[] array = default;
									if (array == null)
									{
										goto IL_0d3d;
									}
									if (array.Length != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F60]");
										object obj24 = 0;
										object obj25 = array + 32;
										obj25 = obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X22_v8-8]");
										object obj26 = 0 & 0xFFFFFFFEL;
										if (obj26 != null)
										{
											bool flag9 = !left;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F58]");
											object obj27 = 0;
											object obj28 = !flag9;
											object obj29 = ~obj28;
											if (obj29 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F70]");
												obj27 = 0;
											}
											object obj30 = array + 40;
											obj30 = obj27;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X22_v10-10]");
											bool flag10 = (nint)0 < (nint)2;
											object obj31 = !flag10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X22_v10-10]");
											object obj32 = -2;
											bool flag11 = obj32 == null;
											object obj33 = ~obj31;
											object obj34 = obj33 | flag11;
											if (obj34 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F40]");
												object obj35 = 0;
												object obj36 = array + 48;
												obj36 = obj35;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F50]");
												object obj37 = 0;
												float num13 = default;
												string text = num13.ToString((string)obj37);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X22_v12-18]");
												object obj38 = 0 & 0xFFFFFFFCL;
												if (obj38 != null)
												{
													object obj39 = array + 56;
													obj39 = text;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X22_v14-20]");
													bool flag12 = (nint)0 < (nint)4;
													object obj40 = !flag12;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X22_v14-20]");
													object obj41 = -4;
													bool flag13 = obj41 == null;
													object obj42 = ~obj40;
													object obj43 = obj42 | flag13;
													if (obj43 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
														object obj44 = 0;
														object obj45 = array + 64;
														obj45 = obj44;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														float num14 = (float)(ref num13) + 4f;
														string text2 = ((float*)num14)->ToString((string)obj37);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X22_v16-28]");
														bool flag14 = (nint)0 < (nint)5;
														object obj46 = !flag14;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X22_v16-28]");
														object obj47 = -5;
														bool flag15 = obj47 == null;
														object obj48 = ~obj46;
														object obj49 = obj48 | flag15;
														if (obj49 == null)
														{
															object obj50 = array + 72;
															obj50 = text2;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X22_v18-30]");
															bool flag16 = (nint)0 < (nint)6;
															object obj51 = !flag16;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X22_v18-30]");
															object obj52 = -6;
															bool flag17 = obj52 == null;
															object obj53 = ~obj51;
															object obj54 = obj53 | flag17;
															if (obj54 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F78]");
																object obj55 = 0;
																object obj56 = array + 80;
																obj56 = obj55;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj57 = obj;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v39+E4]");
																bool flag18 = (nint)0 == 0;
																object obj58 = !flag18;
																if (obj58 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	obj57 = obj;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v39+A0]");
																object obj59 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v39+48]");
																object obj60 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v39+48]");
																if ((nint)0 == 0)
																{
																	goto IL_0d3d;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v40+18]");
																bool flag19 = (nint)num < (nint)0;
																object obj61 = !flag19;
																if (obj61 == null)
																{
																	object obj62 = array.Length & 0xFFFFFFF8L;
																	if (obj62 != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v39+48]");
																		object obj63 = (nint)0 + (nint)num;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v41+20]");
																		object obj64;
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																			obj64 = 0;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F68]");
																			obj64 = 0;
																		}
																		object obj65 = array + 88;
																		obj65 = obj64;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X22_v20-40]");
																		bool flag20 = (nint)0 < (nint)8;
																		object obj66 = !flag20;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X22_v20-40]");
																		object obj67 = -8;
																		bool flag21 = obj67 == null;
																		object obj68 = ~obj66;
																		object obj69 = obj68 | flag21;
																		if (obj69 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F38]");
																			object obj70 = 0;
																			object obj71 = array + 96;
																			obj71 = obj70;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			object obj72 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v46+E4]");
																			bool flag22 = (nint)0 == 0;
																			object obj73 = !flag22;
																			if (obj73 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				obj72 = obj;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v46+A0]");
																			object obj74 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+48]");
																			object obj75 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+48]");
																			if ((nint)0 == 0)
																			{
																				goto IL_0d3d;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X9_v20+18]");
																			bool flag23 = (nint)num < (nint)0;
																			object obj76 = !flag23;
																			if (obj76 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+38]");
																				object obj77 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+38]");
																				if ((nint)0 == 0)
																				{
																					goto IL_0d3d;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+48]");
																				object obj78 = (nint)0 + (nint)num;
																				bool flag24 = !left;
																				object obj79 = !flag24;
																				object obj80 = ~obj79;
																				object obj81 = ((obj80 != null) ? ((object)2) : ((object)0));
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X9_v21+20]");
																				object obj82 = obj81 | 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v49+18]");
																				bool flag25 = (nint)obj82 < 0;
																				object obj83 = !flag25;
																				if (obj83 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v48+38]");
																					object obj84 = 0 + obj82;
																					float num15 = (float)obj84 + 32f;
																					string text3 = ((float*)num15)->ToString((string)obj37);
																					bool flag26 = array.Length < 9;
																					object obj85 = !flag26;
																					object obj86 = array.Length - 9;
																					bool flag27 = obj86 == null;
																					object obj87 = ~obj85;
																					object obj88 = obj87 | flag27;
																					if (obj88 == null)
																					{
																						object obj89 = array + 104;
																						obj89 = text3;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X19_v7-50]");
																						bool flag28 = (nint)0 < (nint)10;
																						object obj90 = !flag28;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X19_v7-50]");
																						object obj91 = -10;
																						bool flag29 = obj91 == null;
																						object obj92 = ~obj90;
																						object obj93 = obj92 | flag29;
																						if (obj93 == null)
																						{
																							object obj94 = array + 112;
																							obj94 = obj44;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							object obj95 = obj;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v53+A0]");
																							object obj96 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v54+48]");
																							object obj97 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v54+48]");
																							if ((nint)0 == 0)
																							{
																								goto IL_0d3d;
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X9_v24+18]");
																							bool flag30 = (nint)num < (nint)0;
																							object obj98 = !flag30;
																							if (obj98 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v54+38]");
																								object obj99 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v54+38]");
																								if ((nint)0 == 0)
																								{
																									goto IL_0d3d;
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v54+48]");
																								object obj100 = (nint)0 + (nint)num;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X9_v25+20]");
																								object obj101 = obj81 | 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v55+18]");
																								bool flag31 = (nint)obj101 < 0;
																								object obj102 = !flag31;
																								if (obj102 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v54+38]");
																									object obj103 = 0 + obj101;
																									float num16 = (float)obj103 + 36f;
																									string text4 = ((float*)num16)->ToString((string)obj37);
																									bool flag32 = array.Length < 11;
																									object obj104 = !flag32;
																									object obj105 = array.Length - 11;
																									bool flag33 = obj105 == null;
																									object obj106 = ~obj104;
																									object obj107 = obj106 | flag33;
																									if (obj107 == null)
																									{
																										object obj108 = array + 120;
																										obj108 = text4;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X19_v9-60]");
																										bool flag34 = (nint)0 < (nint)12;
																										object obj109 = !flag34;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X19_v9-60]");
																										object obj110 = -12;
																										bool flag35 = obj110 == null;
																										object obj111 = ~obj109;
																										object obj112 = obj111 | flag35;
																										if (obj112 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F30]");
																											object obj113 = 0;
																											object obj114 = array + 128;
																											obj114 = obj113;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											string text5 = string.Concat(array);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
																											object obj115 = 0;
																											object obj116 = obj115;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v63+E4]");
																											bool flag36 = (nint)0 == 0;
																											object obj117 = !flag36;
																											if (obj117 == null)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																											}
																											Debug.Log(text5);
																											result = (Vector2)text5;
																											goto IL_0d2a;
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
														}
													}
												}
											}
										}
									}
								}
							}
							goto IL_0d2f;
						}
						goto IL_0d3d;
					}
				}
			}
		}
		goto IL_0d2a;
		IL_0d3d:
		NullReferenceException ex = new NullReferenceException();
		return (Vector2)ex;
		IL_0d2f:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0d3d;
		IL_0d2a:
		return result;
	}

	public static Vector2 Taken(int hand, Vector2 stick, bool feels, bool touched, bool gripped, float now, float deadzone, bool trustPushes = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected VT, but got Unknown
		//IL_004c: Expected Obj, but got I4
		//IL_007e: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = !touched;
		Vector2 stick2 = (Vector2)(stick & 1);
		object obj4 = !flag2;
		object obj5 = ~obj4;
		float deadzone2 = ((obj5 != null) ? 0f : 1f);
		return Taken(hand, stick2, feels, gripped, now, deadzone, deadzone2, gripped);
	}

	public static Vector2 Taken(int hand, Vector2 stick, bool feels, bool touched, float grip, float now, float deadzone, bool trustPushes = default(bool))
	{
		//IL_094c: Expected Obj, but got I
		//IL_095c: Expected Obj, but got I
		//IL_096c: Invalid comparison between F4 and I
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Invalid comparison between F4 and I
		//IL_0a01: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected VT, but got Unknown
		//IL_021e: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0993: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I
		//IL_0a1f: Expected Obj, but got I
		//IL_0a2f: Expected Obj, but got I
		//IL_093c: Expected VT, but got Obj
		//IL_0274: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_0a94: Expected Obj, but got I
		//IL_039b: Expected Obj, but got I
		//IL_0a76: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected VT, but got Unknown
		//IL_04ca: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_041e: Expected Obj, but got I
		//IL_042e: Expected F4, but got I
		//IL_0465: Invalid comparison between F4 and I4
		//IL_0520: Expected Obj, but got I4
		//IL_0535: Expected Obj, but got I
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got I
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected VT, but got Unknown
		//IL_05d0: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I4
		//IL_063b: Expected Obj, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0683: Expected Obj, but got I
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected VT, but got Unknown
		//IL_0ac9: Expected Obj, but got I
		//IL_0ae1: Expected Obj, but got I
		//IL_0b44: Expected F4, but got I
		//IL_0b54: Invalid comparison between F4 and I
		//IL_06fd: Expected Obj, but got I4
		//IL_0bc5: Expected VT, but got Obj
		//IL_0be7: Expected Obj, but got I4
		//IL_072f: Expected VT, but got I4
		//IL_0755: Expected VT, but got Obj
		//IL_0777: Expected Obj, but got I4
		//IL_0b88: Expected Obj, but got I
		//IL_0b98: Expected Obj, but got I
		//IL_0797: Expected VT, but got Obj
		//IL_07bd: Expected Obj, but got I4
		//IL_07d2: Expected Obj, but got I
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_0815: Expected Obj, but got I
		//IL_084f: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I
		//IL_08b8: Expected F4, but got I
		//IL_08c8: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
		object obj6;
		if (deadzone > 0f)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v44+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v43+48]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v43+48]");
			if ((nint)0 == 0)
			{
				goto IL_0920;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v34+18]");
			bool flag2 = (nint)0 < (nint)hand;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v34+18]");
			object obj8 = -hand;
			bool flag3 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag3;
			if (obj10 != null)
			{
				goto IL_092e;
			}
			object obj11 = 1;
		}
		else
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			if (!(deadzone < 0f))
			{
				goto IL_09df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v44+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v44+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v40+48]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v40+48]");
			if ((nint)0 == 0)
			{
				goto IL_0920;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v34+18]");
			bool flag5 = (nint)0 < (nint)hand;
			object obj14 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v34+18]");
			object obj15 = -hand;
			bool flag6 = obj15 == null;
			object obj16 = ~obj14;
			object obj17 = obj16 | flag6;
			if (obj17 != null)
			{
				goto IL_092e;
			}
			object obj11 = 0;
		}
		object obj18 = obj6 + hand;
		goto IL_09df;
		IL_0920:
		NullReferenceException ex = new NullReferenceException();
		goto IL_092e;
		IL_09df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v44+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 stick2 = (Vector2)(stick & 1);
		float num = default;
		float num2 = default;
		bool flag8 = Hold(hand, stick2, feels, touched, num, num2);
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v32+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v13+48]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v13+48]");
		if ((nint)0 == 0)
		{
			goto IL_0920;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v1+18]");
		bool flag9 = (nint)0 < (nint)hand;
		object obj23 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X10_v1+18]");
		object obj24 = -hand;
		bool flag10 = obj24 == null;
		object obj25 = ~obj23;
		object obj26 = obj25 | flag10;
		float deadzone2;
		float num16;
		float num15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v13+48]");
			object obj27 = (nint)0 + (nint)hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X10_v2+20]");
			bool flag11 = (nint)0 == 0;
			object obj28 = !flag11;
			object obj29 = flag8 | obj28;
			object obj30 = obj29 & 1;
			bool touched2;
			float num6 = default;
			if (obj30 != null)
			{
				touched2 = true;
				float num3 = num2;
				float num4 = num;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v32+E4]");
				bool flag12 = (nint)0 == 0;
				object obj31 = !flag12;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj20 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v32+A0]");
					obj21 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v13+78]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v13+78]");
				if ((nint)0 == 0)
				{
					goto IL_0920;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v14+18]");
				bool flag13 = (nint)0 < (nint)hand;
				object obj33 = !flag13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v14+18]");
				object obj34 = -hand;
				bool flag14 = obj34 == null;
				object obj35 = ~obj33;
				object obj36 = obj35 | flag14;
				if (obj36 != null)
				{
					goto IL_092e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v13+78]");
				object obj37 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float num3 = 0f;
				float num5 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v15+20]");
				float num4 = num5 - 0f;
				float num7 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float num8 = num7 - 0f;
				bool flag15 = num8 < 0f;
				touched2 = flag15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v32+E4]");
			bool flag16 = (nint)0 == 0;
			object obj38 = !flag16;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 stick3 = (Vector2)(stick & 1);
			Doubt(hand, stick3, feels, touched2, trustPushes, num);
			object obj39 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v8+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v9+48]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v9+48]");
			if ((nint)0 == 0)
			{
				goto IL_0920;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v10+18]");
			bool flag17 = (nint)0 < (nint)hand;
			object obj42 = !flag17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v10+18]");
			object obj43 = -hand;
			bool flag18 = obj43 == null;
			object obj44 = ~obj42;
			object obj45 = obj44 | flag18;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v9+48]");
				object obj46 = (nint)0 + (nint)hand;
				Vector2 stick4 = (Vector2)(stick & 1);
				bool feels2 = feels;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v11+20]");
				IntPtr intPtr = default;
				Vector2 vector = Gate(hand, stick4, feels2, touched: false, num, touched, (byte)(nint)intPtr != 0);
				object obj47 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v12+A0]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v13+48]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v13+48]");
				if ((nint)0 == 0)
				{
					goto IL_0920;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v14+18]");
				bool flag19 = (nint)0 < (nint)hand;
				object obj50 = !flag19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v14+18]");
				object obj51 = -hand;
				bool flag20 = obj51 == null;
				object obj52 = ~obj50;
				object obj53 = obj52 | flag20;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v13+48]");
					object obj54 = (nint)0 + (nint)hand;
					Vector2 vector2 = (Vector2)(stick & 1);
					bool feels3 = feels;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v15+20]");
					Rest(hand, vector2, feels3, touched: false, touched, num);
					float num9;
					if (flag8)
					{
						object obj55 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v27+E4]");
						bool flag21 = (nint)0 == 0;
						object obj56 = !flag21;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector2 vector3 = Squeezed(hand, vector2, (Vector2)feels, num);
						num6 = num2;
						num9 = num;
						goto IL_08de;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
					object obj57 = 0;
					object obj58 = obj57;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v23+A0]");
					object obj59 = 0;
					float num10 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v24+4]");
					float num11 = num10 - 0f;
					float num12 = num - (float)obj59;
					float num13 = num12 * num12;
					float num14 = num11 * num11;
					num15 = num13 + num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					num16 = 0f;
					float num17 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					bool flag22 = num17 < 0f;
					num9 = num6;
					deadzone2 = num;
					if (flag22)
					{
						goto IL_0bbd;
					}
					Vector2 stick5 = (Vector2)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v20 (UnityEngine.Vector2)+E4]");
					bool flag23 = (nint)0 == 0;
					object obj60 = !flag23;
					if (obj60 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						stick5 = (Vector2)obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v20 (UnityEngine.Vector2)+A0]");
					object obj61 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+48]");
					object obj62 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+48]");
					if ((nint)0 == 0)
					{
						goto IL_0920;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v9+18]");
					bool flag24 = (nint)0 < (nint)hand;
					object obj63 = !flag24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v9+18]");
					object obj64 = -hand;
					bool flag25 = obj64 == null;
					object obj65 = ~obj63;
					object obj66 = obj65 | flag25;
					if (obj66 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+38]");
						object obj67 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+38]");
						if ((nint)0 == 0)
						{
							goto IL_0920;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+48]");
						object obj68 = (nint)0 + (nint)hand;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X9_v10+20]");
						int num18 = (int)((nint)0 | (nint)hand);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v28+18]");
						bool flag26 = (nint)num18 < (nint)0;
						object obj69 = !flag26;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v27+38]");
							object obj70 = (nint)0 + (nint)num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v29+20]");
							num9 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v29+24]");
							num6 = 0f;
							Vector2 vector4 = Off(stick5, vector2);
							goto IL_08de;
						}
					}
				}
			}
		}
		goto IL_092e;
		IL_092e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector2)ex2;
		IL_08de:
		num16 = num2;
		num15 = num;
		deadzone2 = num;
		goto IL_0bbd;
		IL_0bbd:
		Vector2 stick6 = (Vector2)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v14 (UnityEngine.Vector2)+E4]");
		bool flag27 = (nint)0 == 0;
		object obj71 = !flag27;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Dead(stick6, deadzone2);
	}

	private static bool Hold(int hand, Vector2 stick, bool feels, bool touched, float grip, float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_163e: Expected Obj, but got I4
		//IL_1982: Expected Obj, but got I
		//IL_1992: Expected Obj, but got I
		//IL_1614: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_01e9: Expected F8, but got I
		//IL_01f9: Invalid comparison between F4 and I
		//IL_1685: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_19c7: Expected Obj, but got I
		//IL_19d7: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_1654: Unknown result type (might be due to invalid IL or missing references)
		//IL_1659: Expected Obj, but got Unknown
		//IL_03b0: Expected Obj, but got I4
		//IL_06e8: Expected Obj, but got I4
		//IL_076e: Expected Obj, but got I4
		//IL_0783: Expected Obj, but got I
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I
		//IL_0718: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0426: Expected Obj, but got I4
		//IL_09da: Expected Obj, but got I4
		//IL_16b5: Expected Obj, but got I4
		//IL_0a60: Expected Obj, but got I4
		//IL_0a75: Expected Obj, but got I
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_080a: Expected Obj, but got I4
		//IL_1a0c: Expected Obj, but got I
		//IL_1a1c: Expected Obj, but got I
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2a: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_0a0a: Expected Obj, but got I
		//IL_0a1a: Expected Obj, but got I
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected Obj, but got Unknown
		//IL_083a: Expected Obj, but got I4
		//IL_183c: Expected Obj, but got I
		//IL_1866: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I4
		//IL_1784: Expected Obj, but got I4
		//IL_173d: Expected Obj, but got I
		//IL_0cf5: Expected F4, but got I
		//IL_0d1f: Invalid comparison between F4 and I4
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected Obj, but got Unknown
		//IL_0d47: Expected Obj, but got F4
		//IL_16d3: Expected Obj, but got I
		//IL_1a57: Expected Obj, but got I
		//IL_1a67: Expected Obj, but got I
		//IL_0b04: Expected Obj, but got I4
		//IL_086a: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I
		//IL_17a2: Expected Obj, but got I
		//IL_0890: Expected Obj, but got I4
		//IL_08a5: Expected Obj, but got I
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_0d9f: Expected Obj, but got I4
		//IL_0db4: Expected Obj, but got I
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Expected Obj, but got Unknown
		//IL_04e5: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_1448: Expected Obj, but got I4
		//IL_145d: Expected Obj, but got I
		//IL_147d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Expected Obj, but got Unknown
		//IL_0b34: Expected Obj, but got I
		//IL_0b5a: Expected Obj, but got I4
		//IL_0b6f: Expected Obj, but got I
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected Obj, but got Unknown
		//IL_08e8: Expected Obj, but got I
		//IL_08fd: Expected Obj, but got I
		//IL_0e04: Expected Obj, but got I
		//IL_0e2b: Expected Obj, but got I4
		//IL_0542: Expected Obj, but got I
		//IL_14a5: Expected Obj, but got I
		//IL_1884: Expected Obj, but got I
		//IL_1894: Expected Obj, but got I
		//IL_0c72: Expected Obj, but got I4
		//IL_0bb7: Expected Obj, but got I
		//IL_0bc7: Expected F4, but got I
		//IL_0949: Expected Obj, but got I4
		//IL_095e: Expected Obj, but got I
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_0589: Expected Obj, but got I4
		//IL_14d4: Expected Obj, but got I4
		//IL_0e71: Expected Obj, but got I4
		//IL_0e86: Expected Obj, but got I
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected Obj, but got Unknown
		//IL_1708: Expected Obj, but got I
		//IL_155a: Expected Obj, but got I4
		//IL_156f: Expected Obj, but got I
		//IL_158f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Expected Obj, but got Unknown
		//IL_0c27: Expected Obj, but got I4
		//IL_09a6: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I
		//IL_1504: Expected Obj, but got I
		//IL_1514: Expected Obj, but got I
		//IL_17d7: Expected Obj, but got I
		//IL_17f9: Expected Obj, but got I4
		//IL_0ece: Expected Obj, but got I
		//IL_0ede: Expected Obj, but got I
		//IL_05df: Expected Obj, but got I4
		//IL_05f4: Expected Obj, but got I
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_15aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Expected Obj, but got Unknown
		//IL_15bf: Expected F4, but got I
		//IL_15cf: Invalid comparison between I and F4
		//IL_12f9: Expected Obj, but got I4
		//IL_130e: Expected Obj, but got I
		//IL_132e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1333: Expected Obj, but got Unknown
		//IL_0c57: Expected Obj, but got I
		//IL_0f2a: Expected Obj, but got I4
		//IL_0f3f: Expected Obj, but got I
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Expected Obj, but got Unknown
		//IL_063c: Expected Obj, but got I
		//IL_0671: Expected Obj, but got I4
		//IL_068e: Invalid comparison between F8 and I4
		//IL_069f: Expected Obj, but got I4
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected Obj, but got Unknown
		//IL_135e: Expected Obj, but got I
		//IL_0f87: Expected Obj, but got I
		//IL_0f97: Expected Obj, but got I
		//IL_13a9: Expected Obj, but got I4
		//IL_13be: Expected Obj, but got I
		//IL_13de: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Expected Obj, but got Unknown
		//IL_1406: Expected Obj, but got I
		//IL_0ff2: Expected Obj, but got I4
		//IL_1007: Expected Obj, but got I
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Expected Obj, but got Unknown
		//IL_18ee: Expected Obj, but got I
		//IL_1906: Expected Obj, but got I
		//IL_190e: Expected F4, but got Obj
		//IL_191e: Expected F4, but got I
		//IL_104f: Expected Obj, but got I
		//IL_1083: Expected Obj, but got I4
		//IL_1933: Expected Obj, but got I
		//IL_1943: Expected Obj, but got I
		//IL_10c9: Expected Obj, but got I4
		//IL_10de: Expected Obj, but got I
		//IL_10fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Expected Obj, but got Unknown
		//IL_1126: Expected Obj, but got I
		//IL_1136: Expected Obj, but got I
		//IL_1146: Expected Obj, but got I
		//IL_1156: Expected Obj, but got I
		//IL_11a1: Expected Obj, but got I4
		//IL_11b6: Expected Obj, but got I
		//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected Obj, but got Unknown
		//IL_11fe: Expected Obj, but got I
		//IL_1249: Expected Obj, but got I4
		//IL_125e: Expected Obj, but got I
		//IL_127e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1283: Expected Obj, but got Unknown
		//IL_12a6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+50]");
		if ((nint)0 == 0)
		{
			goto IL_1606;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v67+18]");
		bool flag2 = (nint)0 < (nint)hand;
		object obj6 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v67+18]");
		object obj7 = -hand;
		bool flag3 = obj7 == null;
		object obj8 = ~obj6;
		object obj9 = obj8 | flag3;
		if (obj9 != null)
		{
			goto IL_15f8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+50]");
		object obj10 = (nint)0 + (nint)hand;
		float num = default;
		double num2;
		if ((double)num > 0.25)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v73+50]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v73+50]");
				if ((nint)0 == 0)
				{
					goto IL_1606;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v67+18]");
			bool flag5 = (nint)0 < (nint)hand;
			object obj13 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v67+18]");
			object obj14 = -hand;
			bool flag6 = obj14 == null;
			object obj15 = ~obj13;
			object obj16 = obj15 | flag6;
			if (obj16 != null)
			{
				goto IL_15f8;
			}
			num2 = 0.25;
			object obj17 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			if (!(num < 0f))
			{
				goto IL_1663;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v70+50]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v70+50]");
				if ((nint)0 == 0)
				{
					goto IL_1606;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v67+18]");
			bool flag8 = (nint)0 < (nint)hand;
			object obj20 = !flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v67+18]");
			object obj21 = -hand;
			bool flag9 = obj21 == null;
			object obj22 = ~obj20;
			object obj23 = obj22 | flag9;
			if (obj23 != null)
			{
				goto IL_15f8;
			}
			object obj17 = 0;
		}
		object obj24 = obj5 + hand;
		goto IL_1663;
		IL_1762:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v13+50]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v13+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v14+18]");
			bool flag11 = (nint)0 < (nint)hand;
			object obj28 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v14+18]");
			object obj29 = -hand;
			bool flag12 = obj29 == null;
			object obj30 = ~obj28;
			object obj31 = obj30 | flag12;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v13+50]");
				object obj32 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v15+20]");
				return false;
			}
			goto IL_15f8;
		}
		goto IL_1606;
		IL_12d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X9_v9+18]");
		bool flag13 = (nint)0 < (nint)hand;
		object obj33 = !flag13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X9_v9+18]");
		object obj34 = -hand;
		bool flag14 = obj34 == null;
		object obj35 = ~obj33;
		object obj36 = obj35 | flag14;
		object obj38;
		if (obj36 == null)
		{
			object obj37 = obj38 + hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+90]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+90]");
			if ((nint)0 == 0)
			{
				goto IL_1606;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v17+18]");
			bool flag15 = (nint)0 < (nint)hand;
			object obj40 = !flag15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v17+18]");
			object obj41 = -hand;
			bool flag16 = obj41 == null;
			object obj42 = ~obj40;
			object obj43 = obj42 | flag16;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+90]");
				object obj44 = (nint)0 + (nint)hand;
				goto IL_1762;
			}
		}
		goto IL_15f8;
		IL_1606:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_15f8:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_1606;
		IL_1663:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
		bool flag17 = (nint)0 == 0;
		object obj45 = !flag17;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X9_v13+18]");
			bool flag18 = (nint)0 < (nint)hand;
			object obj48 = !flag18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X9_v13+18]");
			object obj49 = -hand;
			bool flag19 = obj49 == null;
			object obj50 = ~obj48;
			object obj51 = obj50 | flag19;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X9_v4+20]");
				bool flag20 = (nint)0 == 0;
				object obj52 = !flag20;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
					object obj53 = (nint)0 + (nint)hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X10_v16+20]");
					if ((nint)0 != 0)
					{
						object obj54 = stick & 1;
						bool flag21 = obj54 == null;
						float num4 = default;
						float num3 = num4;
						object obj55 = 0;
						if (!flag21)
						{
							bool flag22 = !feels;
							object obj56 = !flag22;
							num3 = num4;
							obj55 = 0;
							if (obj56 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
								bool flag23 = (nint)0 == 0;
								object obj57 = !flag23;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj2 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
									obj46 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+20]");
								object obj58 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+20]");
								if ((nint)0 == 0)
								{
									goto IL_1606;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X9_v36+18]");
								bool flag24 = (nint)0 < (nint)hand;
								object obj59 = !flag24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X9_v36+18]");
								object obj60 = -hand;
								bool flag25 = obj60 == null;
								object obj61 = ~obj59;
								object obj62 = obj61 | flag25;
								if (obj62 != null)
								{
									goto IL_15f8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+20]");
								object obj63 = (nint)0 + (nint)hand;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X9_v37+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
									bool flag26 = (nint)0 == 0;
									object obj64 = !flag26;
									if (obj64 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj2 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
										obj46 = 0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+28]");
									object obj65 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+28]");
									if ((nint)0 == 0)
									{
										goto IL_1606;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v63+18]");
									bool flag27 = (nint)0 < (nint)hand;
									object obj66 = !flag27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v63+18]");
									object obj67 = -hand;
									bool flag28 = obj67 == null;
									object obj68 = ~obj66;
									object obj69 = obj68 | flag28;
									if (obj69 != null)
									{
										goto IL_15f8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+28]");
									object obj70 = (nint)0 + (nint)hand;
									object obj71 = default;
									double num5 = (double)obj71;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v64+20]");
									num2 = num5 - 0.0;
									bool flag29 = num2 < 0.25;
									object obj72 = !flag29;
									double num6 = num2 - 0.25;
									bool flag30 = num6 == 0.0;
									object obj73 = !flag30;
									object obj74 = obj72 & obj73;
									num3 = 0.25f;
									obj55 = obj74;
								}
								else
								{
									num3 = num4;
									obj55 = 0;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
						bool flag31 = (nint)0 == 0;
						object obj75 = !flag31;
						if (obj75 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj2 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
						object obj76 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v37+58]");
						object obj77 = 0;
						object obj78 = obj55 & 1;
						if (obj78 != null)
						{
							float num7 = (float)num2;
							bool flag32 = false;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
							object obj79 = 0;
							object obj80 = obj79;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v51+E4]");
							bool flag33 = (nint)0 == 0;
							object obj81 = !flag33;
							if (obj81 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num8 = grip * grip;
							float num9 = num4 * num4;
							float num7 = num8 + num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
							num3 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							float num10 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
							float num11 = num10 - 0f;
							bool flag34 = num11 < 0f;
							float num12 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
							object obj82 = num12 ^ 0;
							object obj83 = num7 ^ num11;
							object obj84 = obj82 & obj83;
							bool flag35 = (nint)obj84 < 0;
							bool flag36 = flag34 == flag35;
							bool flag32 = flag36;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v37+58]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X20_v7+18]");
							bool flag37 = (nint)0 < (nint)hand;
							object obj85 = !flag37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X20_v7+18]");
							object obj86 = -hand;
							bool flag38 = obj86 == null;
							object obj87 = ~obj85;
							object obj88 = obj87 | flag38;
							if (obj88 != null)
							{
								goto IL_15f8;
							}
							object obj89 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v37+58]");
							object obj90 = (nint)0 + (nint)hand;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v38+E4]");
							bool flag39 = (nint)0 == 0;
							object obj91 = !flag39;
							if (obj91 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj89 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v38+A0]");
							object obj92 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+98]");
							object obj93 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+98]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v29+18]");
								bool flag40 = (nint)0 < (nint)hand;
								object obj94 = !flag40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v29+18]");
								object obj95 = -hand;
								bool flag41 = obj95 == null;
								object obj96 = ~obj94;
								object obj97 = obj96 | flag41;
								if (obj97 != null)
								{
									goto IL_15f8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+98]");
								object obj98 = (nint)0 + (nint)hand;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+58]");
								object obj99 = 0;
								_ = 1048576000;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+58]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X9_v30+18]");
									bool flag42 = (nint)0 < (nint)hand;
									object obj100 = !flag42;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X9_v30+18]");
									object obj101 = -hand;
									bool flag43 = obj101 == null;
									object obj102 = ~obj100;
									object obj103 = obj102 | flag43;
									if (obj103 != null)
									{
										goto IL_15f8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+58]");
									object obj104 = (nint)0 + (nint)hand;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+60]");
									object obj105 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X9_v31+20]");
									bool flag44 = (nint)0 == 0;
									float num13 = grip;
									float num14 = num4;
									if (!flag44)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
										object obj106 = 0;
										object obj107 = obj106;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v49+A0]");
										object obj108 = 0;
										num13 = (float)obj108;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X8_v50+4]");
										num14 = 0f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+60]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X20_v8+18]");
										bool flag45 = (nint)0 < (nint)hand;
										object obj109 = !flag45;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X20_v8+18]");
										object obj110 = -hand;
										bool flag46 = obj110 == null;
										object obj111 = ~obj109;
										object obj112 = obj111 | flag46;
										if (obj112 != null)
										{
											goto IL_15f8;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v39+60]");
										object obj113 = (nint)0 + (nint)hand;
										obj2 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
										bool flag47 = (nint)0 == 0;
										object obj114 = !flag47;
										if (obj114 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj2 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
										obj46 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+80]");
										object obj115 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+80]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v33+18]");
											bool flag48 = (nint)0 < (nint)hand;
											object obj116 = !flag48;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v33+18]");
											object obj117 = -hand;
											bool flag49 = obj117 == null;
											object obj118 = ~obj116;
											object obj119 = obj118 | flag49;
											if (obj119 != null)
											{
												goto IL_15f8;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+80]");
											object obj120 = (nint)0 + (nint)hand;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+68]");
											obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+70]");
											object obj121 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+88]");
											object obj122 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+70]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X11_v10+18]");
												bool flag50 = (nint)0 < (nint)hand;
												object obj123 = !flag50;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X11_v10+18]");
												object obj124 = -hand;
												bool flag51 = obj124 == null;
												object obj125 = ~obj123;
												object obj126 = obj125 | flag51;
												if (obj126 != null)
												{
													goto IL_15f8;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+70]");
												object obj127 = (nint)0 + (nint)hand;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+88]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v24+18]");
													bool flag52 = (nint)0 < (nint)hand;
													object obj128 = !flag52;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v24+18]");
													object obj129 = -hand;
													bool flag53 = obj129 == null;
													object obj130 = ~obj128;
													object obj131 = obj130 | flag53;
													if (obj131 != null)
													{
														goto IL_15f8;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+88]");
													object obj132 = (nint)0 + (nint)hand;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+68]");
													bool flag54 = (nint)0 == 0;
													num4 = num3;
													if (!flag54)
													{
														goto IL_12d8;
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_1606;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
				bool flag55 = (nint)0 == 0;
				object obj133 = !flag55;
				if (obj133 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
					obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
					obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
					if ((nint)0 == 0)
					{
						goto IL_1606;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X9_v13+18]");
				bool flag56 = (nint)0 < (nint)hand;
				object obj134 = !flag56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X9_v13+18]");
				object obj135 = -hand;
				bool flag57 = obj135 == null;
				object obj136 = ~obj134;
				object obj137 = obj136 | flag57;
				if (obj137 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X9_v4+20]");
					if ((nint)0 != 0)
					{
						object obj138 = obj47 + hand;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X11_v7+20]");
						bool flag58 = (nint)0 == 0;
						object obj139 = !flag58;
						if (obj139 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
							bool flag59 = (nint)0 == 0;
							object obj140 = !flag59;
							if (obj140 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj2 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
								obj46 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+58]");
							object obj141 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+58]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X9_v22+18]");
								bool flag60 = (nint)0 < (nint)hand;
								object obj142 = !flag60;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X9_v22+18]");
								object obj143 = -hand;
								bool flag61 = obj143 == null;
								object obj144 = ~obj142;
								object obj145 = obj144 | flag61;
								if (obj145 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+78]");
									object obj146 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+58]");
									object obj147 = (nint)0 + (nint)hand;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+78]");
									if ((nint)0 == 0)
									{
										goto IL_1606;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v31+18]");
									bool flag62 = (nint)0 < (nint)hand;
									object obj148 = !flag62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v31+18]");
									object obj149 = -hand;
									bool flag63 = obj149 == null;
									object obj150 = ~obj148;
									object obj151 = obj150 | flag63;
									if (obj151 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+78]");
										object obj152 = (nint)0 + (nint)hand;
										float num7 = (float)num2;
										goto IL_1762;
									}
								}
								goto IL_15f8;
							}
							goto IL_1606;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
					bool flag64 = (nint)0 == 0;
					object obj153 = !flag64;
					if (obj153 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
						obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
						obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+50]");
						if ((nint)0 == 0)
						{
							goto IL_1606;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X9_v13+18]");
					bool flag65 = (nint)0 < (nint)hand;
					object obj154 = !flag65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X9_v13+18]");
					object obj155 = -hand;
					bool flag66 = obj155 == null;
					object obj156 = ~obj154;
					object obj157 = obj156 | flag66;
					if (obj157 == null)
					{
						object obj158 = obj47 + hand;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X9_v14+20]");
						bool flag67 = (nint)0 == 0;
						float num7 = (float)num2;
						if (flag67)
						{
							goto IL_1762;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
						bool flag68 = (nint)0 == 0;
						object obj159 = !flag68;
						if (obj159 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
							obj46 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+90]");
						object obj160 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+90]");
						if ((nint)0 == 0)
						{
							goto IL_1606;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X9_v18+18]");
						bool flag69 = (nint)0 < (nint)hand;
						object obj161 = !flag69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X9_v18+18]");
						object obj162 = -hand;
						bool flag70 = obj162 == null;
						object obj163 = ~obj161;
						object obj164 = obj163 | flag70;
						if (obj164 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+90]");
							object obj165 = (nint)0 + (nint)hand;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
							float num4 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X10_v13+20]");
							float num15 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
							num7 = num15 + 0f;
							if (num7 < num)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
								bool flag71 = (nint)0 == 0;
								object obj166 = !flag71;
								if (obj166 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj2 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
									obj46 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+80]");
								obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v16+80]");
								bool flag72 = (nint)0 == 0;
								object obj167 = !flag72;
								if (obj167 != null)
								{
									goto IL_12d8;
								}
								goto IL_1606;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+E4]");
							bool flag73 = (nint)0 == 0;
							object obj168 = !flag73;
							if (obj168 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj2 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v15+A0]");
								object obj169 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v25+90]");
								obj160 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v25+90]");
								if ((nint)0 == 0)
								{
									goto IL_1606;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X9_v18+18]");
							bool flag74 = (nint)0 < (nint)hand;
							object obj170 = !flag74;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X9_v18+18]");
							object obj171 = -hand;
							bool flag75 = obj171 == null;
							object obj172 = ~obj170;
							object obj173 = obj172 | flag75;
							if (obj173 == null)
							{
								object obj174 = obj160 + hand;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v24+20]");
								num7 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v24+20]");
								if (!(0f < num))
								{
									num7 = num;
								}
								goto IL_1762;
							}
						}
					}
				}
			}
			goto IL_15f8;
		}
		goto IL_1606;
	}

	private static Vector2 Squeezed(int hand, Vector2 stick, Vector2 gated, float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1507: Expected Obj, but got I4
		//IL_1a98: Expected Obj, but got I
		//IL_1aa8: Expected Obj, but got I
		//IL_14dd: Expected VT, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_1525: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_1562: Expected Obj, but got I
		//IL_156a: Expected VT, but got Obj
		//IL_1582: Expected Obj, but got I
		//IL_158a: Expected F4, but got Obj
		//IL_159a: Expected F8, but got I
		//IL_15fd: Invalid comparison between F4 and I
		//IL_0672: Expected Obj, but got I4
		//IL_0215: Invalid comparison between F4 and I
		//IL_16ed: Expected Obj, but got I
		//IL_0b7c: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I4
		//IL_1744: Expected Obj, but got I4
		//IL_162c: Expected Obj, but got I
		//IL_163c: Expected Obj, but got I
		//IL_06cc: Expected VT, but got Obj
		//IL_06dc: Expected Obj, but got I
		//IL_06ec: Expected Obj, but got I
		//IL_027b: Expected VT, but got Obj
		//IL_02a1: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_0732: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I
		//IL_07ad: Expected Obj, but got I
		//IL_0bca: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I4
		//IL_0c47: Expected Obj, but got I4
		//IL_080d: Expected Obj, but got I4
		//IL_1671: Expected Obj, but got I
		//IL_180a: Expected Obj, but got I
		//IL_0bfe: Expected Obj, but got I
		//IL_1762: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I
		//IL_0c67: Expected VT, but got Obj
		//IL_0c77: Expected Obj, but got I
		//IL_17d6: Expected F8, but got I
		//IL_082d: Expected VT, but got Obj
		//IL_083d: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0c9d: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected Obj, but got Unknown
		//IL_0d6d: Expected Obj, but got I4
		//IL_0863: Expected Obj, but got I4
		//IL_0878: Expected Obj, but got I
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected Obj, but got Unknown
		//IL_1874: Expected Obj, but got I
		//IL_1884: Expected Obj, but got I
		//IL_0d14: Expected F8, but got I
		//IL_0d3d: Expected F8, but got I
		//IL_042b: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_047d: Invalid comparison between F8 and I4
		//IL_0cfa: Expected Obj, but got I
		//IL_0d8d: Expected VT, but got Obj
		//IL_184e: Expected Obj, but got I4
		//IL_08c0: Expected Obj, but got I
		//IL_0db3: Expected Obj, but got I4
		//IL_0dc8: Expected Obj, but got I
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Expected Obj, but got Unknown
		//IL_18c8: Expected Obj, but got I4
		//IL_0e32: Expected F8, but got I
		//IL_0e51: Expected Obj, but got I4
		//IL_0909: Expected Obj, but got I4
		//IL_04d1: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_0e10: Expected Obj, but got I
		//IL_139f: Expected Obj, but got I4
		//IL_0fca: Invalid comparison between Obj and F8
		//IL_0fe6: Expected Obj, but got I4
		//IL_179c: Expected Obj, but got I
		//IL_1a04: Expected Obj, but got I
		//IL_1a14: Expected Obj, but got I
		//IL_1a4f: Invalid comparison between F8 and I4
		//IL_116c: Expected Obj, but got I4
		//IL_0e89: Expected Obj, but got I4
		//IL_0939: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I
		//IL_13bf: Expected VT, but got Obj
		//IL_199a: Expected Obj, but got I
		//IL_19aa: Expected Obj, but got I
		//IL_1016: Expected Obj, but got I4
		//IL_18e6: Expected Obj, but got I
		//IL_18f6: Expected Obj, but got I
		//IL_095f: Expected Obj, but got I4
		//IL_0974: Expected Obj, but got I
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected Obj, but got Unknown
		//IL_118c: Expected VT, but got Obj
		//IL_1955: Expected Obj, but got I
		//IL_1965: Expected Obj, but got I
		//IL_0ea9: Expected VT, but got Obj
		//IL_05de: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_1404: Expected Obj, but got I4
		//IL_1419: Expected Obj, but got I
		//IL_1439: Unknown result type (might be due to invalid IL or missing references)
		//IL_143e: Expected Obj, but got Unknown
		//IL_11b2: Expected Obj, but got I4
		//IL_11c7: Expected Obj, but got I
		//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Expected Obj, but got Unknown
		//IL_1036: Expected VT, but got Obj
		//IL_0ecf: Expected Obj, but got I4
		//IL_0ee4: Expected Obj, but got I
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Expected Obj, but got Unknown
		//IL_09b7: Expected Obj, but got I
		//IL_09cc: Expected Obj, but got I
		//IL_105c: Expected Obj, but got I4
		//IL_1071: Expected Obj, but got I
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected Obj, but got Unknown
		//IL_0636: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_1470: Expected Obj, but got I
		//IL_14ae: Expected Obj, but got I4
		//IL_120a: Expected Obj, but got I
		//IL_121f: Expected Obj, but got I
		//IL_1256: Invalid comparison between F8 and I4
		//IL_1265: Invalid comparison between F8 and I4
		//IL_127d: Expected Obj, but got F8
		//IL_128a: Expected Obj, but got F8
		//IL_12bf: Expected Obj, but got I4
		//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Expected Obj, but got Unknown
		//IL_0f2c: Expected Obj, but got I
		//IL_0f3c: Expected F4, but got I
		//IL_0f63: Invalid comparison between F8 and I
		//IL_0f74: Expected Obj, but got I4
		//IL_0f94: Invalid comparison between F4 and I4
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected Obj, but got Unknown
		//IL_0a18: Expected Obj, but got I4
		//IL_0a2d: Expected Obj, but got I
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected Obj, but got Unknown
		//IL_10b9: Expected Obj, but got I
		//IL_10c9: Expected F4, but got I
		//IL_10f0: Invalid comparison between F8 and I
		//IL_1101: Expected Obj, but got I4
		//IL_1121: Invalid comparison between F8 and I4
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected Obj, but got Unknown
		//IL_0a70: Expected Obj, but got I
		//IL_0a85: Expected Obj, but got I
		//IL_0aab: Expected Obj, but got I4
		//IL_0ac0: Expected Obj, but got I
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		//IL_0b45: Expected VT, but got I
		//IL_1316: Expected Obj, but got I4
		//IL_132b: Expected Obj, but got I
		//IL_134b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1350: Expected Obj, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected Obj, but got Unknown
		//IL_0b27: Expected Obj, but got I4
		//IL_1373: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+70]");
		if ((nint)0 == 0)
		{
			goto IL_14c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v1+18]");
		bool flag2 = (nint)0 < (nint)hand;
		object obj6 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X9_v1+18]");
		object obj7 = -hand;
		bool flag3 = obj7 == null;
		object obj8 = ~obj6;
		object obj9 = obj8 | flag3;
		object obj13 = default;
		object obj14;
		Vector2 stick2;
		object obj27 = default;
		object obj52 = default;
		object obj60;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+70]");
			object obj10 = (nint)0 + (nint)hand;
			object obj11 = obj10 + 32;
			object obj12 = obj13 - obj11;
			bool flag4 = (nint)obj12 < 0;
			obj14 = 0;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				bool flag5 = (nint)obj12 <= 0;
				obj14 = obj12;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					obj14 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+60]");
			object obj15 = 0;
			obj11 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+60]");
			if ((nint)0 == 0)
			{
				goto IL_14c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v7+18]");
			bool flag6 = (nint)0 < (nint)hand;
			object obj16 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v7+18]");
			object obj17 = -hand;
			bool flag7 = obj17 == null;
			object obj18 = ~obj16;
			object obj19 = obj18 | flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+60]");
				object obj20 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
				object obj21 = 0;
				stick2 = (Vector2)obj;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v10+A0]");
				object obj23 = 0;
				float num = (float)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v11+4]");
				double num2 = 0.0;
				object obj24 = default;
				double num3 = (double)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v11+4]");
				double num4 = num3 - 0.0;
				object obj25 = default;
				float num5 = (float)obj25 - (float)obj23;
				float num6 = num5 * num5;
				double num7 = num4 * num4;
				float num8 = num6 + (float)num7;
				float num9 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				bool flag8 = !(num9 < 0f);
				object obj26 = obj13;
				if (!flag8)
				{
					double num10 = (double)obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v11+4]");
					double num11 = num10 - 0.0;
					float num12 = now - (float)obj23;
					float num13 = num12 * num12;
					num2 = num11 * num11;
					num = num13 + (float)num2;
					float num14 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					bool flag9 = num14 < 0f;
					num8 = now;
					obj26 = obj27;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v65 (UnityEngine.Vector2)+E4]");
						bool flag10 = (nint)0 == 0;
						object obj28 = !flag10;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							stick2 = (Vector2)obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v65 (UnityEngine.Vector2)+A0]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+80]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+80]");
						if ((nint)0 == 0)
						{
							goto IL_14c1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X9_v41+18]");
						bool flag11 = (nint)0 < (nint)hand;
						object obj31 = !flag11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X9_v41+18]");
						object obj32 = -hand;
						bool flag12 = obj32 == null;
						object obj33 = ~obj31;
						object obj34 = obj33 | flag12;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+80]");
							object obj35 = (nint)0 + (nint)hand;
							float num15 = (float)obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X9_v42+20]");
							num = num15 - 0f;
							bool flag13 = !((double)num < 0.5);
							num8 = now;
							obj26 = obj27;
							num2 = 0.5;
							if (flag13)
							{
								goto IL_0650;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v65 (UnityEngine.Vector2)+E4]");
							bool flag14 = (nint)0 == 0;
							object obj36 = !flag14;
							if (obj36 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj37 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v83+A0]");
								obj29 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+58]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+58]");
							if ((nint)0 == 0)
							{
								goto IL_14c1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X9_v44+18]");
							bool flag15 = (nint)0 < (nint)hand;
							object obj39 = !flag15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X9_v44+18]");
							object obj40 = -hand;
							bool flag16 = obj40 == null;
							object obj41 = ~obj39;
							object obj42 = obj41 | flag16;
							if (obj42 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+58]");
								object obj43 = (nint)0 + (nint)hand;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+60]");
								object obj44 = 0;
								_ = 0;
								object obj45 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
								object obj46 = obj45 / 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
								double num16 = 1.0 - (double)obj46;
								if (num16 < 0.0 || !(num16 > 1.0))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+60]");
									if ((nint)0 == 0)
									{
										goto IL_14c1;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X24_v10+18]");
								bool flag17 = (nint)0 < (nint)hand;
								object obj47 = !flag17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X24_v10+18]");
								object obj48 = -hand;
								bool flag18 = obj48 == null;
								object obj49 = ~obj47;
								object obj50 = obj49 | flag18;
								if (obj50 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v77+60]");
									object obj51 = (nint)0 + (nint)hand;
									float num17 = now;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v8+20]");
									float num18 = num17 - 0f;
									float num19 = num18 * (float)obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v8+20]");
									float num20 = 0f + num19;
									object obj53 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v80+A0]");
									object obj54 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v81+88]");
									object obj55 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v81+88]");
									if ((nint)0 == 0)
									{
										goto IL_14c1;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v46+18]");
									bool flag19 = (nint)0 < (nint)hand;
									object obj56 = !flag19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v46+18]");
									object obj57 = -hand;
									bool flag20 = obj57 == null;
									object obj58 = ~obj56;
									object obj59 = obj58 | flag20;
									if (obj59 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v81+68]");
										obj60 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v81+88]");
										object obj61 = (nint)0 + (nint)hand;
										goto IL_16bb;
									}
								}
							}
						}
						goto IL_14cf;
					}
				}
				goto IL_0650;
			}
		}
		goto IL_14cf;
		IL_14cf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (Vector2)ex;
		IL_1787:
		Vector2 result = default;
		return result;
		IL_14c1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_14cf;
		IL_16bb:
		if (obj60 == null)
		{
			goto IL_14c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v17+18]");
		bool flag21 = (nint)0 < (nint)hand;
		object obj62 = !flag21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v17+18]");
		object obj63 = -hand;
		bool flag22 = obj63 == null;
		object obj64 = ~obj62;
		object obj65 = obj64 | flag22;
		if (obj65 != null)
		{
			goto IL_14cf;
		}
		object obj66 = obj60 + hand;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC15]");
		bool flag23 = (nint)0 == 0;
		object obj67 = !flag23;
		if (obj67 == null)
		{
			goto IL_0b35;
		}
		goto IL_1787;
		IL_17c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		double num21 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		object obj68 = default;
		object obj69 = default;
		double num22;
		if ((nint)obj68 >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			num21 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			bool flag24 = (nint)obj69 >= 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			num22 = 0.0;
			if (flag24)
			{
				goto IL_182f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
		bool flag25 = (nint)0 == 0;
		object obj70 = !flag25;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			result = (Vector2)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X8_v56+88]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X8_v56+88]");
		if ((nint)0 == 0)
		{
			goto IL_14c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v57+18]");
		bool flag26 = (nint)0 < (nint)hand;
		object obj73 = !flag26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v57+18]");
		object obj74 = -hand;
		bool flag27 = obj74 == null;
		object obj75 = ~obj73;
		object obj76 = obj75 | flag27;
		if (obj76 != null)
		{
			goto IL_14cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X8_v56+88]");
		object obj77 = (nint)0 + (nint)hand;
		num22 = num21;
		goto IL_182f;
		IL_182f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		bool flag28 = (nint)obj68 < 0;
		object obj78 = 0;
		float num23 = now;
		if (!flag28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			num22 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
			bool flag29 = (nint)obj69 < 0;
			obj78 = 0;
			num23 = now;
			if (!flag29)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
				bool flag30 = (nint)0 == 0;
				object obj79 = !flag30;
				if (obj79 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					result = (Vector2)obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
				object obj80 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X8_v50+68]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X8_v50+68]");
				if ((nint)0 == 0)
				{
					goto IL_14c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v51+18]");
				bool flag31 = (nint)0 < (nint)hand;
				object obj82 = !flag31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v51+18]");
				object obj83 = -hand;
				bool flag32 = obj83 == null;
				object obj84 = ~obj82;
				object obj85 = obj84 | flag32;
				if (obj85 != null)
				{
					goto IL_14cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X8_v50+68]");
				object obj86 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				num23 = 0f;
				double num24 = (double)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v52+20]");
				num22 = num24 - 0.0;
				double num25 = num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				bool flag33 = num25 < 0.0;
				object obj87 = !flag33;
				float num26 = (float)num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				float num27 = num26 - 0f;
				bool flag34 = num27 == 0f;
				object obj88 = ~obj87;
				object obj89 = obj88 | flag34;
				obj78 = obj89;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
		bool flag35 = (nint)obj68 < 0;
		object obj90 = 0;
		if (!flag35)
		{
			bool flag36 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25);
			num22 = 0.25;
			obj90 = 0;
			if (!flag36)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
				bool flag37 = (nint)0 == 0;
				object obj91 = !flag37;
				if (obj91 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					result = (Vector2)obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
				object obj92 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X8_v44+88]");
				object obj93 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X8_v44+88]");
				if ((nint)0 == 0)
				{
					goto IL_14c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v45+18]");
				bool flag38 = (nint)0 < (nint)hand;
				object obj94 = !flag38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v45+18]");
				object obj95 = -hand;
				bool flag39 = obj95 == null;
				object obj96 = ~obj94;
				object obj97 = obj96 | flag39;
				if (obj97 != null)
				{
					goto IL_14cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X8_v44+88]");
				object obj98 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				num23 = 0f;
				double num28 = (double)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v46+20]");
				num22 = num28 - 0.0;
				double num29 = num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				bool flag40 = num29 < 0.0;
				object obj99 = !flag40;
				double num30 = num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				double num31 = num30 - 0.0;
				bool flag41 = num31 == 0.0;
				object obj100 = ~obj99;
				object obj101 = obj100 | flag41;
				obj90 = obj101;
			}
		}
		object obj102 = obj90 | obj78;
		float num37;
		if (obj102 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
			bool flag42 = (nint)0 == 0;
			object obj103 = !flag42;
			if (obj103 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Vector2)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
			object obj104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+58]");
			object obj105 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+58]");
			if ((nint)0 == 0)
			{
				goto IL_14c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v25+18]");
			bool flag43 = (nint)0 < (nint)hand;
			object obj106 = !flag43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v25+18]");
			object obj107 = -hand;
			bool flag44 = obj107 == null;
			object obj108 = ~obj106;
			object obj109 = obj108 | flag44;
			if (obj109 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+98]");
				object obj110 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+58]");
				object obj111 = (nint)0 + (nint)hand;
				_ = 1;
				double num32 = (double)obj69 * 0.5;
				double num33 = num32 - 0.25;
				bool flag45 = num33 < 0.0;
				bool flag46 = num33 == 0.0;
				object obj112 = num32 ^ 0.25;
				object obj113 = num32 ^ num33;
				object obj114 = obj112 & obj113;
				bool flag47 = (nint)obj114 < 0;
				bool flag48 = flag45 == flag47;
				object obj115 = !flag46;
				object obj116 = flag48 & obj115;
				object obj117 = ~obj116;
				if (obj117 == null)
				{
					num32 = 0.25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+98]");
				if ((nint)0 == 0)
				{
					goto IL_14c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v41+18]");
				bool flag49 = (nint)0 < (nint)hand;
				object obj118 = !flag49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v41+18]");
				object obj119 = -hand;
				bool flag50 = obj119 == null;
				object obj120 = ~obj118;
				object obj121 = obj120 | flag50;
				if (obj121 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v40+98]");
					object obj122 = (nint)0 + (nint)hand;
					goto IL_1787;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
			bool flag51 = (nint)0 == 0;
			object obj123 = !flag51;
			if (obj123 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result = (Vector2)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
			object obj124 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v37+60]");
			object obj125 = 0;
			double num34 = (double)obj14 * -2.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num35 = 1.0 - num34;
			if (num35 < 0.0 || !(num35 > 1.0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v37+60]");
				if ((nint)0 == 0)
				{
					goto IL_14c1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X23_v9+18]");
			bool flag52 = (nint)0 < (nint)hand;
			object obj126 = !flag52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X23_v9+18]");
			object obj127 = -hand;
			bool flag53 = obj127 == null;
			object obj128 = ~obj126;
			object obj129 = obj128 | flag53;
			if (obj129 == null)
			{
				float num36 = num37 * (float)obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v37+60]");
				object obj130 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v8+20]");
				float num38 = 0f + num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDC15]");
				bool flag54 = (nint)0 == 0;
				object obj131 = !flag54;
				if (obj131 == null)
				{
					goto IL_0b35;
				}
				goto IL_1787;
			}
		}
		goto IL_14cf;
		IL_0b35:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
		result = (Vector2)0;
		_ = 1;
		goto IL_1787;
		IL_0650:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v65 (UnityEngine.Vector2)+E4]");
		bool flag55 = (nint)0 == 0;
		object obj132 = !flag55;
		if (obj132 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 vector = Off(stick2, stick);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj133 = 0;
		object obj134 = obj133;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v21+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA3B]");
			bool flag56 = (nint)0 == 0;
			object obj135 = !flag56;
			if (obj135 == null)
			{
				_ = 1;
			}
		}
		object obj136 = obj133;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v23+E4]");
		bool flag57 = (nint)0 == 0;
		object obj137 = !flag57;
		if (obj137 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		result = (Vector2)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
		object obj138 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+58]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+58]");
		if ((nint)0 == 0)
		{
			goto IL_14c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v15+18]");
		bool flag58 = (nint)0 < (nint)hand;
		object obj140 = !flag58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X9_v15+18]");
		object obj141 = -hand;
		bool flag59 = obj141 == null;
		object obj142 = ~obj140;
		object obj143 = obj142 | flag59;
		if (obj143 == null)
		{
			float num39 = now * now;
			float num40 = (float)obj27 * (float)obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+58]");
			object obj144 = (nint)0 + (nint)hand;
			float num41 = num39 + num40;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X9_v16+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
				bool flag60 = (nint)0 == 0;
				object obj145 = !flag60;
				if (obj145 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					result = (Vector2)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
					obj138 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+98]");
				object obj146 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+98]");
				if ((nint)0 == 0)
				{
					goto IL_14c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v34+18]");
				bool flag61 = (nint)0 < (nint)hand;
				object obj147 = !flag61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v34+18]");
				object obj148 = -hand;
				bool flag62 = obj148 == null;
				object obj149 = ~obj147;
				object obj150 = obj149 | flag62;
				if (obj150 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+98]");
					object obj151 = (nint)0 + (nint)hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X9_v35+20]");
					if ((nint)obj69 >= 0)
					{
						goto IL_1787;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
					bool flag63 = (nint)0 == 0;
					object obj152 = !flag63;
					if (obj152 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj153 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v67+A0]");
						obj138 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+58]");
					object obj154 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+58]");
					if ((nint)0 == 0)
					{
						goto IL_14c1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v37+18]");
					bool flag64 = (nint)0 < (nint)hand;
					object obj155 = !flag64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v37+18]");
					object obj156 = -hand;
					bool flag65 = obj156 == null;
					object obj157 = ~obj155;
					object obj158 = obj157 | flag65;
					if (obj158 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+88]");
						object obj159 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+58]");
						object obj160 = (nint)0 + (nint)hand;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+88]");
						if ((nint)0 == 0)
						{
							goto IL_14c1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X10_v15+18]");
						bool flag66 = (nint)0 < (nint)hand;
						object obj161 = !flag66;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X10_v15+18]");
						object obj162 = -hand;
						bool flag67 = obj162 == null;
						object obj163 = ~obj161;
						object obj164 = obj163 | flag67;
						if (obj164 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+68]");
							obj60 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+88]");
							object obj61 = (nint)0 + (nint)hand;
							goto IL_16bb;
						}
					}
				}
			}
			else
			{
				float num42 = now;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v8+20]");
				num37 = num42 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				object obj165 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				if ((nint)obj68 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					obj165 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					if ((nint)obj69 >= 0)
					{
						goto IL_17c6;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+E4]");
				bool flag68 = (nint)0 == 0;
				object obj166 = !flag68;
				if (obj166 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					result = (Vector2)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v30 (UnityEngine.Vector2)+A0]");
					obj138 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+68]");
				object obj167 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+68]");
				if ((nint)0 == 0)
				{
					goto IL_14c1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v61+18]");
				bool flag69 = (nint)0 < (nint)hand;
				object obj168 = !flag69;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v61+18]");
				object obj169 = -hand;
				bool flag70 = obj169 == null;
				object obj170 = ~obj168;
				object obj171 = obj170 | flag70;
				if (obj171 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v65+68]");
					object obj172 = (nint)0 + (nint)hand;
					goto IL_17c6;
				}
			}
		}
		goto IL_14cf;
	}

	public static (Vector2, bool, bool) HoldOf(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_026c: Expected VT, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01e6: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I
		//IL_022d: Expected VT, but got I4
		//IL_024a: Expected I4, but got Obj
		//IL_0250: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+60]");
		if ((nint)0 == 0)
		{
			goto IL_0250;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+18]");
		bool flag2 = (nint)0 < (nint)hand;
		object obj6 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+18]");
		object obj7 = -hand;
		bool flag3 = obj7 == null;
		object obj8 = ~obj6;
		object obj9 = obj8 | flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+58]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+58]");
			if ((nint)0 == 0)
			{
				goto IL_0250;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v4+18]");
			bool flag4 = (nint)0 < (nint)hand;
			object obj11 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v4+18]");
			object obj12 = -hand;
			bool flag5 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+50]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+50]");
				if ((nint)0 == 0)
				{
					goto IL_0250;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v4+18]");
				bool flag6 = (nint)0 < (nint)hand;
				object obj16 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X10_v4+18]");
				object obj17 = -hand;
				bool flag7 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+58]");
					object obj20 = (nint)0 + (nint)hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X10_v1+50]");
					object obj21 = (nint)0 + (nint)hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F90]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v5+20]");
					bool flag8 = (nint)0 == 0;
					Vector2 item = (Vector2)(!flag8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X10_v5+20]");
					(Vector2, bool, bool) tuple = (item, false, (byte)(int)obj22 != 0);
					return ((Vector2, bool, bool))0;
				}
			}
		}
		goto IL_025e;
		IL_025e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return ((Vector2, bool, bool))ex;
		IL_0250:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_025e;
	}

	public static Vector2 Taken(int hand, Vector2 stick, bool feels, bool touched, float now, float deadzone)
	{
		//IL_0010: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 stick2 = (Vector2)(stick & 1);
		bool trustPushes = default;
		return Taken(hand, stick2, feels, touched: false, gripped: false, now, deadzone, trustPushes);
	}

	private static Vector2 Off(Vector2 stick, Vector2 at)
	{
		//IL_0172: Expected Obj, but got I
		//IL_017a: Expected VT, but got Obj
		//IL_019c: Expected Obj, but got I4
		//IL_0146: Invalid comparison between F8 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		Vector2 result = (Vector2)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v3 (UnityEngine.Vector2)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default;
		object obj3 = obj4 * obj4;
		object obj6 = default;
		object obj5 = obj6 * obj6;
		object obj7 = obj3 + obj5;
		object obj9 = default;
		object obj8 = obj9 - obj4;
		object obj11 = default;
		object obj10 = obj11 - obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj7 >= 0)
		{
			object obj12 = obj8 * obj8;
			object obj13 = obj10 * obj10;
			object obj14 = obj12 + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj14 >= 0)
			{
				object obj15 = obj8 / obj14;
				object obj16 = obj10 / obj14;
				object obj17 = obj4 * obj15;
				object obj18 = obj6 * obj16;
				object obj19 = obj17 + obj18;
				object obj20 = obj19 * obj19;
				object obj21 = obj20 - obj7;
				double num = (double)obj21 + 1.0;
				if (num < 0.0)
				{
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			}
		}
		return result;
	}

	public static Vector2 Dead(Vector2 stick, float deadzone)
	{
		//IL_00d1: Expected Obj, but got I
		//IL_00d9: Expected VT, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0082: Expected VT, but got I
		//IL_00a4: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		Vector2 result = (Vector2)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector2)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = deadzone * deadzone;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		float num2 = num + (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj5 = default;
		object obj6 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) && (double)num2 > 1.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD000]");
			result = (Vector2)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector2)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		return result;
	}

	private static void Rest(int hand, Vector2 stick, bool feels, bool touched, bool gripped, float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_0629: Expected Obj, but got I4
		//IL_0659: Expected Obj, but got I4
		//IL_0803: Expected Obj, but got I
		//IL_0813: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I
		//IL_0687: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03b2: Invalid comparison between F8 and I4
		//IL_03c1: Expected F8, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_03df: Expected F8, but got I
		//IL_03ef: Invalid comparison between F8 and I
		//IL_011b: Expected Obj, but got I
		//IL_0716: Expected Obj, but got I
		//IL_0740: Expected Obj, but got I4
		//IL_041e: Expected F8, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0760: Invalid comparison between F4 and Obj
		//IL_06bc: Expected Obj, but got I
		//IL_04b5: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0784: Expected Obj, but got I
		//IL_0794: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0249: Invalid comparison between F4 and I4
		//IL_0258: Invalid comparison between F4 and I4
		//IL_0270: Expected Obj, but got F8
		//IL_027d: Expected Obj, but got F4
		//IL_02b2: Expected Obj, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_05a3: Invalid comparison between F8 and I4
		//IL_07ee: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = stick & 1;
		bool flag = obj3 == null;
		float num = now;
		double num3 = default;
		double num2 = num3;
		object obj4 = 0;
		object obj21 = default;
		if (!flag)
		{
			bool flag2 = !feels;
			object obj5 = !flag2;
			num = now;
			num2 = num3;
			obj4 = 0;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v25+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v25+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v24+20]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v24+20]");
				if ((nint)0 == 0)
				{
					goto IL_05d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v11+18]");
				bool flag4 = (nint)0 < (nint)hand;
				object obj9 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v11+18]");
				object obj10 = -hand;
				bool flag5 = obj10 == null;
				object obj11 = ~obj9;
				object obj12 = obj11 | flag5;
				if (obj12 != null)
				{
					goto IL_05e4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v24+20]");
				object obj13 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X9_v12+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v25+E4]");
					bool flag6 = (nint)0 == 0;
					object obj14 = !flag6;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v25+A0]");
						obj7 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v24+28]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v24+28]");
					if ((nint)0 == 0)
					{
						goto IL_05d6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v25+18]");
					bool flag7 = (nint)0 < (nint)hand;
					object obj16 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v25+18]");
					object obj17 = -hand;
					bool flag8 = obj17 == null;
					object obj18 = ~obj16;
					object obj19 = obj18 | flag8;
					if (obj19 != null)
					{
						goto IL_05e4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v24+28]");
					object obj20 = (nint)0 + (nint)hand;
					float num4 = (float)obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v26+20]");
					num = num4 - 0f;
					float num5 = num - 0.25f;
					bool flag9 = num5 < 0f;
					bool flag10 = num5 == 0f;
					object obj22 = (double)num ^ 0.25;
					object obj23 = num ^ num5;
					object obj24 = obj22 & obj23;
					bool flag11 = (nint)obj24 < 0;
					bool flag12 = flag9 == flag11;
					object obj25 = !flag10;
					object obj26 = flag12 & obj25;
					num2 = 0.25;
					obj4 = obj26;
				}
				else
				{
					num = now;
					num2 = num3;
					obj4 = 0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v25+E4]");
		bool flag13 = (nint)0 == 0;
		object obj27 = !flag13;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v25+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v5+40]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v5+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v6+18]");
			bool flag14 = (nint)0 < (nint)hand;
			object obj30 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v6+18]");
			object obj31 = -hand;
			bool flag15 = obj31 == null;
			object obj32 = ~obj30;
			object obj33 = obj32 | flag15;
			if (obj33 != null)
			{
				goto IL_05e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v5+40]");
			object obj34 = (nint)0 + (nint)hand;
			object obj35 = obj34 + 32;
			double num6 = (double)obj21 - (double)obj35;
			bool flag16 = num6 < 0.0;
			double num7 = 0.0;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				num2 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
				bool flag17 = !(num6 > 0.0);
				num7 = num6;
				if (!flag17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					num7 = 0.0;
				}
			}
			obj35 = obj21;
			if (obj4 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj36 = 0;
			object obj37 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v7+E4]");
			bool flag18 = (nint)0 == 0;
			object obj38 = !flag18;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = !touched;
			float num8 = now * now;
			double num9 = num3 * num3;
			float num10 = num8 + (float)num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj39 = 0;
			object obj40 = !flag19;
			object obj41 = ~obj40;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				obj39 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39))
			{
				return;
			}
			object obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+E4]");
			bool flag20 = (nint)0 == 0;
			object obj43 = !flag20;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj42 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+A0]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v17+38]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v17+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
				bool flag21 = touched;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v18+18]");
				bool flag22 = (nint)(flag21 ? 1 : 0) < (nint)0;
				object obj46 = !flag22;
				if (obj46 != null)
				{
					goto IL_05e4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v17+38]");
				object obj47 = (nint)0 + (nint)(touched ? 1 : 0);
				object obj48 = obj47 + 32;
				double num11 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8E0]");
				double num12 = num11 / 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
				double num13 = 1.0 - num12;
				if (num13 < 0.0 || !(num13 > 1.0))
				{
					float num14 = now - (float)obj48;
					object obj49 = default;
					float num15 = num14 * (float)obj49;
					float num16 = (float)obj48 + num15;
					obj48 = num16;
					return;
				}
			}
		}
		goto IL_05d6;
		IL_05e4:
		throw new IndexOutOfRangeException();
		IL_05d6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05e4;
	}

	public static Vector2 RestOf(int hand, bool gripped = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_008e: Expected VT, but got Obj
		//IL_00b0: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_0027: Expected VT, but got Obj
		//IL_0086: Expected VT, but got Obj
		//IL_0057: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj = 0;
		Vector2 result = (Vector2)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v3 (UnityEngine.Vector2)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			result = (Vector2)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v3 (UnityEngine.Vector2)+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
			bool flag2 = gripped;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+18]");
			bool flag3 = (nint)(flag2 ? 1 : 0) < (nint)0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				return result;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector2)ex2;
	}

	public static bool Believed(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I
		//IL_00d3: Expected I4, but got Obj
		//IL_004d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
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
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+20]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			bool flag2 = (nint)0 < (nint)hand;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v5+18]");
			object obj7 = -hand;
			bool flag3 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+20]");
				object obj10 = (nint)0 + (nint)hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+20]");
				return false;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static void Doubt(int hand, Vector2 stick, bool feels, bool touched, bool gripped, float now)
	{
		//IL_0db1: Expected Obj, but got I
		//IL_0dc9: Expected Obj, but got I
		//IL_0deb: Expected Obj, but got I4
		//IL_0c0b: Expected Obj, but got I4
		//IL_0e09: Expected Obj, but got I
		//IL_0e19: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0c29: Expected Obj, but got I
		//IL_0c39: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		//IL_0c4b: Expected Obj, but got I4
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected Obj, but got Unknown
		//IL_0c80: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I4
		//IL_0cb3: Expected Obj, but got I
		//IL_0cc3: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_0c9e: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_0404: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected Obj, but got Unknown
		//IL_0428: Invalid comparison between Obj and F8
		//IL_0439: Expected Obj, but got I4
		//IL_0456: Invalid comparison between F8 and I4
		//IL_049a: Expected Obj, but got I4
		//IL_0cfc: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_04ca: Expected Obj, but got I
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0567: Invalid comparison between Obj and F8
		//IL_059d: Expected Obj, but got I4
		//IL_0d11: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I4
		//IL_0608: Expected Obj, but got I
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_05cd: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0684: Expected Obj, but got I4
		//IL_0699: Expected Obj, but got I
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected Obj, but got Unknown
		//IL_06e9: Expected Obj, but got I
		//IL_0731: Expected Obj, but got I4
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected Obj, but got Unknown
		//IL_075c: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I
		//IL_07a7: Expected Obj, but got I4
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07d2: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_085c: Expected Obj, but got I8
		//IL_0889: Expected Obj, but got I
		//IL_08be: Expected Obj, but got I
		//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected Obj, but got Unknown
		//IL_0d58: Expected Obj, but got I4
		//IL_0d6e: Expected Obj, but got I
		//IL_0d8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d93: Expected Obj, but got Unknown
		//IL_08d3: Expected Obj, but got I
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_0903: Expected Obj, but got I
		//IL_0933: Expected Obj, but got I8
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_0992: Expected Obj, but got I4
		//IL_09a8: Expected Obj, but got I
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_09eb: Expected Obj, but got I
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected Obj, but got Unknown
		//IL_0a28: Expected Ref, but got F4
		//IL_0a53: Expected Obj, but got I4
		//IL_0a69: Expected Obj, but got I
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected Obj, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected Obj, but got Unknown
		//IL_0ade: Expected Obj, but got I4
		//IL_0af4: Expected Obj, but got I
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected Obj, but got Unknown
		//IL_0b37: Expected Obj, but got I
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0b79: Expected Obj, but got I
		//IL_0ba3: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = default;
		object obj5 = obj6 * obj6;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		if ((nint)obj6 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v60+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v61+18]");
			bool flag3 = (nint)0 < (nint)hand;
			object obj11 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v61+18]");
			object obj12 = -hand;
			bool flag4 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag4;
			if (obj14 != null)
			{
				goto IL_0bcf;
			}
			object obj15 = obj10 + hand;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v52+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X9_v2+18]");
		bool flag6 = (nint)0 < (nint)hand;
		object obj19 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X9_v2+18]");
		object obj20 = -hand;
		bool flag7 = obj20 == null;
		object obj21 = ~obj19;
		object obj22 = obj21 | flag7;
		if (obj22 == null)
		{
			object obj23 = obj18 + hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X9_v3+20]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			object obj25 = 1;
			if (obj24 == null)
			{
				object obj26 = stick & 1;
				bool flag9 = obj26 == null;
				obj25 = 1;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
					bool flag10 = (nint)0 == 0;
					object obj27 = !flag10;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj7 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+A0]");
						obj17 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v52+20]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v53+18]");
					bool flag11 = (nint)0 < (nint)hand;
					object obj29 = !flag11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v53+18]");
					object obj30 = -hand;
					bool flag12 = obj30 == null;
					object obj31 = ~obj29;
					object obj32 = obj31 | flag12;
					if (obj32 != null)
					{
						goto IL_0bcf;
					}
					object obj33 = obj28 + hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v54+20]");
					obj25 = (nint)0 ^ (nint)1;
				}
			}
			object obj34 = touched | feels;
			object obj35 = obj34 & 1;
			object obj36 = obj25 | obj35;
			bool flag13 = obj36 == null;
			object obj37 = !flag13;
			if (obj37 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
			bool flag14 = (nint)0 == 0;
			object obj38 = !flag14;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+A0]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v20+28]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X9_v7+18]");
			bool flag15 = (nint)0 < (nint)hand;
			object obj41 = !flag15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X9_v7+18]");
			object obj42 = -hand;
			bool flag16 = obj42 == null;
			object obj43 = ~obj41;
			object obj44 = obj43 | flag16;
			if (obj44 == null)
			{
				object obj45 = obj40 + hand;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X9_v8+20]");
				object obj47 = default;
				object obj46 = obj47 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
				object obj48 = obj6 - 0;
				bool flag17 = (nint)obj48 < 0;
				object obj49 = !flag17;
				object obj50 = ~obj49;
				object obj51;
				bool flag19;
				if (obj50 == null)
				{
					bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25);
					obj51 = !flag18;
					double num = (double)obj46 - 0.25;
					flag19 = num == 0.0;
				}
				else
				{
					flag19 = false;
					obj51 = 0;
				}
				object obj52 = ~obj51;
				object obj53 = obj52 | flag19;
				if (obj53 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
				bool flag20 = (nint)0 == 0;
				object obj54 = !flag20;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+A0]");
					obj39 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v20+10]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X9_v11+18]");
				bool flag21 = (nint)0 < (nint)hand;
				object obj56 = !flag21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X9_v11+18]");
				object obj57 = -hand;
				bool flag22 = obj57 == null;
				object obj58 = ~obj56;
				object obj59 = obj58 | flag22;
				if (obj59 == null)
				{
					object obj60 = obj55 + hand;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X9_v12+20]");
					object obj61 = obj47 - 0;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.5))
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v11+E4]");
					bool flag23 = (nint)0 == 0;
					object obj62 = !flag23;
					if (obj62 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj63 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v49+A0]");
						obj39 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v20+8]");
					object obj64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X9_v14+18]");
					bool flag24 = (nint)0 < (nint)hand;
					object obj65 = !flag24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X9_v14+18]");
					object obj66 = -hand;
					bool flag25 = obj66 == null;
					object obj67 = ~obj65;
					object obj68 = obj67 | flag25;
					if (obj68 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v20+20]");
						object obj69 = 0;
						object obj70 = obj64 + hand;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v7+18]");
						bool flag26 = (nint)0 < (nint)hand;
						object obj71 = !flag26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v7+18]");
						object obj72 = -hand;
						bool flag27 = obj72 == null;
						object obj73 = ~obj71;
						object obj74 = obj73 | flag27;
						if (obj74 == null)
						{
							object obj75 = obj69 + hand;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v20+38]");
							object obj76 = 0;
							_ = 0;
							int num2 = hand << 1;
							int num3 = num2 | 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X20_v4+18]");
							bool flag28 = (nint)num3 < (nint)0;
							object obj77 = !flag28;
							if (obj77 == null)
							{
								object obj78 = obj76 + num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
								object obj79 = 0;
								object obj80 = obj79;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X10_v11+A0]");
								object obj81 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v12+4]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X20_v4+18]");
								bool flag29 = (nint)num2 < (nint)0;
								object obj82 = !flag29;
								if (obj82 == null)
								{
									object obj83 = obj76 + num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
									object obj84 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v12+4]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									string[] array = default;
									if (array.Length != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F60]");
										object obj85 = 0;
										object obj86 = array + 32;
										obj86 = obj85;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X21_v6-8]");
										object obj87 = 0 & 0xFFFFFFFEL;
										if (obj87 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F58]");
											object obj88 = 0;
											if (hand != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F70]");
												obj88 = 0;
											}
											object obj89 = array + 40;
											obj89 = obj88;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X19_v5-10]");
											bool flag30 = (nint)0 < (nint)2;
											object obj90 = !flag30;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X19_v5-10]");
											object obj91 = -2;
											bool flag31 = obj91 == null;
											object obj92 = ~obj90;
											object obj93 = obj92 | flag31;
											if (obj93 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F80]");
												object obj94 = 0;
												object obj95 = array + 48;
												obj95 = obj94;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F50]");
												object obj96 = 0;
												float num4 = default;
												string text = num4.ToString((string)obj96);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X19_v7-18]");
												object obj97 = 0 & 0xFFFFFFFCL;
												if (obj97 != null)
												{
													object obj98 = array + 56;
													obj98 = text;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X19_v9-20]");
													bool flag32 = (nint)0 < (nint)4;
													object obj99 = !flag32;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X19_v9-20]");
													object obj100 = -4;
													bool flag33 = obj100 == null;
													object obj101 = ~obj99;
													object obj102 = obj101 | flag33;
													if (obj102 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
														object obj103 = 0;
														object obj104 = array + 64;
														obj104 = obj103;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														float num5 = (float)(ref num4) + 4f;
														string text2 = ((float*)num5)->ToString((string)obj96);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X19_v11-28]");
														bool flag34 = (nint)0 < (nint)5;
														object obj105 = !flag34;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X19_v11-28]");
														object obj106 = -5;
														bool flag35 = obj106 == null;
														object obj107 = ~obj105;
														object obj108 = obj107 | flag35;
														if (obj108 == null)
														{
															object obj109 = array + 72;
															obj109 = text2;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X19_v13-30]");
															bool flag36 = (nint)0 < (nint)6;
															object obj110 = !flag36;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X19_v13-30]");
															object obj111 = -6;
															bool flag37 = obj111 == null;
															object obj112 = ~obj110;
															object obj113 = obj112 | flag37;
															if (obj113 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F88]");
																object obj114 = 0;
																object obj115 = array + 80;
																obj115 = obj114;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																string message = string.Concat(array);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
																object obj116 = 0;
																object obj117 = obj116;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v45+E4]");
																bool flag38 = (nint)0 == 0;
																object obj118 = !flag38;
																if (obj118 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																Debug.Log(message);
																return;
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
			}
		}
		goto IL_0bcf;
		IL_0bcf:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static Vector2 Gate(int hand, Vector2 stick, bool feels, bool touched, float now, bool gripped = default(bool), bool trustPushes = default(bool))
	{
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_03b7: Expected Obj, but got I4
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected Obj, but got Unknown
		//IL_0775: Expected Obj, but got I4
		//IL_077d: Expected VT, but got I4
		//IL_02c6: Expected Obj, but got I
		//IL_02ce: Expected I4, but got Obj
		//IL_02f0: Expected Obj, but got I4
		//IL_0719: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0042: Expected I4, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I
		//IL_03d4: Expected VT, but got Obj
		//IL_03f6: Expected Obj, but got I4
		//IL_0310: Expected I4, but got Obj
		//IL_066f: Expected Obj, but got I
		//IL_067f: Expected Obj, but got I
		//IL_079b: Expected Obj, but got I
		//IL_07ab: Expected Obj, but got I
		//IL_0601: Expected VT, but got Obj
		//IL_0336: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0084: Expected I4, but got Obj
		//IL_0416: Expected VT, but got Obj
		//IL_00aa: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_043c: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_0499: Expected Obj, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04bb: Invalid comparison between Obj and F8
		//IL_04cc: Expected Obj, but got I4
		//IL_04e9: Invalid comparison between F8 and I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_06c6: Expected Obj, but got I4
		//IL_083a: Expected Obj, but got I
		//IL_084a: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0229: Expected I4, but got Obj
		//IL_06e4: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0179: Expected I4, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I
		//IL_07e5: Expected Obj, but got I
		//IL_07ed: Expected VT, but got Obj
		//IL_080f: Expected Obj, but got I4
		//IL_05c1: Invalid comparison between F4 and I
		object obj = stick & 1;
		bool flag = obj == null;
		int num2 = default;
		int num = num2;
		if (!flag)
		{
			bool flag2 = !feels;
			num = num2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
				object obj2 = 0;
				num = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num = (int)obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+A0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+8]");
				if ((nint)0 == 0)
				{
					goto IL_05e5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v9+18]");
				bool flag4 = (nint)0 < (nint)num2;
				object obj6 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v9+18]");
				object obj7 = -num2;
				bool flag5 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+8]");
					object obj10 = (nint)0 + (nint)num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X9_v10+20]");
					bool flag6 = (nint)0 == 0;
					object obj11 = !flag6;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+E4]");
						bool flag7 = (nint)0 == 0;
						object obj12 = !flag7;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							num = (int)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+A0]");
							obj4 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+20]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+20]");
						if ((nint)0 == 0)
						{
							goto IL_05e5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v43+18]");
						bool flag8 = (nint)0 < (nint)num2;
						object obj14 = !flag8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v43+18]");
						object obj15 = -num2;
						bool flag9 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag9;
						if (obj17 != null)
						{
							goto IL_05f3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v42+20]");
						object obj18 = (nint)0 + (nint)num2;
						_ = 1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+E4]");
					bool flag10 = (nint)0 == 0;
					object obj19 = !flag10;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num = (int)obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+A0]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v39+28]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v39+28]");
					if ((nint)0 == 0)
					{
						goto IL_05e5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v40+18]");
					bool flag11 = (nint)0 < (nint)num2;
					object obj22 = !flag11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v40+18]");
					object obj23 = -num2;
					bool flag12 = obj23 == null;
					object obj24 = ~obj22;
					object obj25 = obj24 | flag12;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v39+28]");
						object obj26 = (nint)0 + (nint)num2;
						goto IL_0634;
					}
				}
				goto IL_05f3;
			}
		}
		goto IL_0634;
		IL_07d0:
		Vector2 vector;
		return vector;
		IL_05f3:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (Vector2)ex;
		IL_0634:
		object obj27 = stick & 1;
		object obj37;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
			object obj28 = 0;
			num = (int)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num = (int)obj28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v3 (System.Int32)+A0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v28+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v28+20]");
			if ((nint)0 == 0)
			{
				goto IL_05e5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v29+18]");
			bool flag14 = (nint)0 < (nint)num2;
			object obj32 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v29+18]");
			object obj33 = -num2;
			bool flag15 = obj33 == null;
			object obj34 = ~obj32;
			object obj35 = obj34 | flag15;
			if (obj35 != null)
			{
				goto IL_05f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v28+20]");
			object obj36 = (nint)0 + (nint)num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v30+20]");
			obj37 = (nint)0 ^ (nint)1;
		}
		else
		{
			obj37 = 1;
		}
		object obj38 = obj37 | feels;
		bool flag16 = obj38 == null;
		object obj39 = !flag16;
		vector = (Vector2)num;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
			object obj40 = 0;
			vector = (Vector2)obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector2)+E4]");
			bool flag17 = (nint)0 == 0;
			object obj41 = !flag17;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				vector = (Vector2)obj40;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (UnityEngine.Vector2)+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v8+28]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v8+28]");
			if ((nint)0 == 0)
			{
				goto IL_05e5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+18]");
			bool flag18 = (nint)0 < (nint)num2;
			object obj44 = !flag18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+18]");
			object obj45 = -num2;
			bool flag19 = obj45 == null;
			object obj46 = ~obj44;
			object obj47 = obj46 | flag19;
			if (obj47 != null)
			{
				goto IL_05f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v8+28]");
			object obj48 = (nint)0 + (nint)num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v10+20]");
			object obj50 = default;
			object obj49 = obj50 - 0;
			bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.25);
			object obj51 = !flag20;
			double num3 = (double)obj49 - 0.25;
			bool flag21 = num3 == 0.0;
			object obj52 = ~obj51;
			object obj53 = obj52 | flag21;
			if (obj53 == null)
			{
				bool flag22 = !gripped;
				Vector2 vector2 = vector;
				if (!flag22)
				{
					bool flag23 = !touched;
					object obj54 = !flag23;
					vector2 = vector;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj55 = 0;
						vector2 = (Vector2)obj55;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v8 (UnityEngine.Vector2)+E4]");
						bool flag24 = (nint)0 == 0;
						object obj56 = !flag24;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float num4 = now * now;
						object obj58 = default;
						object obj57 = obj58 * obj58;
						float num5 = num4 + (float)obj57;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
						bool flag25 = !(num5 < 0f);
						vector = vector2;
						if (flag25)
						{
							goto IL_07d0;
						}
					}
				}
				vector = vector2;
			}
		}
		goto IL_07d0;
		IL_05e5:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05f3;
	}

	static GillaSticks()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_08a9: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_0432: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I
		//IL_050e: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I
		//IL_0648: Expected Obj, but got I
		//IL_06e5: Expected Obj, but got I
		//IL_0782: Expected Obj, but got I
		//IL_07c1: Expected Obj, but got I
		//IL_0856: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F98]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<UnityEngine.XR.InputDevice> list = default;
		list._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = list;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		object obj9 = (nint)0 + (nint)8;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v11+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v11+18]");
			bool flag = (nint)0 == 1;
			_ = 4286578687L;
			if (!flag)
			{
				object obj11 = obj2;
				_ = 4286578687L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v4+A0]");
				object obj12 = (nint)0 + (nint)16;
				object obj13 = default;
				obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj14 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v12+A0]");
				object obj15 = (nint)0 + (nint)32;
				object obj16 = default;
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v24+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v24+18]");
					bool flag2 = (nint)0 == 1;
					_ = 4286578687L;
					if (!flag2)
					{
						object obj17 = obj2;
						_ = 4286578687L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X9_v6+A0]");
						object obj18 = (nint)0 + (nint)40;
						object obj19 = default;
						obj18 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v29+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v29+18]");
							bool flag3 = (nint)0 == 1;
							_ = 4286578687L;
							if (!flag3)
							{
								object obj20 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
								object obj21 = 0;
								_ = 4286578687L;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X9_v8+A0]");
								object obj22 = (nint)0 + (nint)48;
								object obj23 = default;
								obj22 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								object obj24 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v17+A0]");
								object obj25 = (nint)0 + (nint)56;
								object obj26 = default;
								obj25 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v38+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v38+18]");
									bool flag4 = (nint)0 == 1;
									_ = 4286578687L;
									if (!flag4)
									{
										object obj27 = obj2;
										_ = 4286578687L;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v10+A0]");
										object obj28 = (nint)0 + (nint)64;
										object obj29 = default;
										obj28 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj30 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v21+A0]");
										object obj31 = (nint)0 + (nint)72;
										object obj32 = default;
										obj31 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj33 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v24+A0]");
										object obj34 = (nint)0 + (nint)80;
										object obj35 = default;
										obj34 = obj35;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj36 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v27+A0]");
										object obj37 = (nint)0 + (nint)88;
										object obj38 = default;
										obj37 = obj38;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj39 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v30+A0]");
										object obj40 = (nint)0 + (nint)96;
										object obj41 = default;
										obj40 = obj41;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v59+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v59+18]");
											bool flag5 = (nint)0 == 1;
											_ = 4286578687L;
											if (!flag5)
											{
												object obj42 = obj2;
												_ = 4286578687L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v12+A0]");
												object obj43 = (nint)0 + (nint)104;
												object obj44 = default;
												obj43 = obj44;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v64+18]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v64+18]");
													bool flag6 = (nint)0 == 1;
													_ = 4286578687L;
													if (!flag6)
													{
														object obj45 = obj2;
														_ = 4286578687L;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X9_v14+A0]");
														object obj46 = (nint)0 + (nint)112;
														object obj47 = default;
														obj46 = obj47;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v69+18]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v69+18]");
															bool flag7 = (nint)0 == 1;
															_ = 4286578687L;
															if (!flag7)
															{
																object obj48 = obj2;
																_ = 4286578687L;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X9_v16+A0]");
																object obj49 = (nint)0 + (nint)120;
																object obj50 = default;
																obj49 = obj50;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v74+18]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v74+18]");
																	bool flag8 = (nint)0 == 1;
																	_ = 4286578687L;
																	if (!flag8)
																	{
																		object obj51 = obj2;
																		_ = 4286578687L;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X9_v18+A0]");
																		object obj52 = (nint)0 + (nint)128;
																		object obj53 = default;
																		obj52 = obj53;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v79+18]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v79+18]");
																			bool flag9 = (nint)0 == 1;
																			_ = 4286578687L;
																			if (!flag9)
																			{
																				object obj54 = obj2;
																				_ = 4286578687L;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v20+A0]");
																				object obj55 = (nint)0 + (nint)136;
																				object obj56 = default;
																				obj55 = obj56;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																				object obj57 = obj2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v38+A0]");
																				object obj58 = (nint)0 + (nint)144;
																				object obj59 = default;
																				obj58 = obj59;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v88+18]");
																				if ((nint)0 != 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v88+18]");
																					bool flag10 = (nint)0 == 1;
																					_ = 1048576000;
																					if (!flag10)
																					{
																						object obj60 = obj2;
																						_ = 1048576000;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X9_v22+A0]");
																						object obj61 = (nint)0 + (nint)152;
																						object obj62 = default;
																						obj61 = obj62;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						return;
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
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
