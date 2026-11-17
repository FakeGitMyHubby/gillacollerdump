using System;
using Cpp2ILInjected;
using Photon.Realtime;

namespace Fusion;

public class StartGameResult
{
	private ShutdownReason ShutdownReason__BackingField;

	private string ErrorMessage__BackingField;

	private string StackTrace__BackingField;

	public bool Ok => ShutdownReason__BackingField == 0;

	public ShutdownReason ShutdownReason
	{
		get
		{
			return ShutdownReason__BackingField;
		}
		private set
		{
			ShutdownReason__BackingField = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return ErrorMessage__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string StackTrace
	{
		get
		{
			return StackTrace__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	internal unsafe StartGameResult(ShutdownReason reason = default(ShutdownReason), string message = null, string stackTrace = null)
	{
		//IL_0049: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got Ref
		ShutdownReason__BackingField = reason;
		bool flag = message == null;
		object obj = !flag;
		string text = message;
		if (obj == null)
		{
			object obj2 = default;
			text = ((Enum)(&obj2)).ToString();
		}
		object obj3 = this + 24;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = this + 32;
		obj4 = stackTrace;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I4
		//IL_0053: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I8
		//IL_0116: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got Ref
		//IL_025d: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_01fa: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I8
		//IL_02fd: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got Ref
		//IL_0444: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I4
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_03e1: Expected I, but got Obj
		//IL_03f1: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I
		//IL_0497: Expected Obj, but got I
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_0547: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I4
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_04e4: Expected I, but got Obj
		//IL_04f4: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_063c: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got I4
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_05d9: Expected I, but got Obj
		//IL_05e9: Expected Obj, but got I
		//IL_0612: Expected Obj, but got I
		//IL_068f: Expected Obj, but got I
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected Obj, but got Unknown
		//IL_073b: Expected Obj, but got I8
		//IL_06e0: Expected I, but got Obj
		//IL_06f0: Expected Obj, but got I
		//IL_0719: Expected Obj, but got I
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_080a: Expected Obj, but got I4
		//IL_081a: Expected Obj, but got I4
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_07a7: Expected I, but got Obj
		//IL_07b7: Expected Obj, but got I
		//IL_07e0: Expected Obj, but got I
		//IL_085d: Expected Obj, but got I
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DF8]");
			object obj2 = 0;
			bool flag = obj2 == null;
			string text = (string)9;
			IndexOutOfRangeException ex = default;
			string text2;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag2)
				{
					goto IL_08b0;
				}
			}
			if (array.Length != 0)
			{
				text = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DE8]");
				object obj3 = 0;
				object obj4 = array + 32;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (obj3 != null)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag3 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag3)
					{
						goto IL_08b0;
					}
				}
				object obj5 = array.Length & 0xFFFFFFFEL;
				if (obj5 != null)
				{
					object obj6 = array + 40;
					obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					string text3 = default;
					bool flag4 = text3 == null;
					object obj8 = default;
					text = (string)(&obj8);
					if (!flag4)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag5)
						{
							goto IL_08b0;
						}
					}
					bool flag6 = array.Length < 2;
					object obj9 = !flag6;
					object obj10 = array.Length - 2;
					bool flag7 = obj10 == null;
					object obj11 = ~obj9;
					object obj12 = obj11 | flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DC8]");
						object obj13 = 0;
						object obj14 = array + 48;
						obj14 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag8 = obj13 == null;
						text = text3;
						if (!flag8)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag9 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
							text2 = (string)0;
							if (flag9)
							{
								goto IL_08b0;
							}
						}
						object obj15 = array.Length & 0xFFFFFFFCL;
						if (obj15 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
							object obj16 = 0;
							object obj17 = array + 56;
							obj17 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							string text4 = default;
							bool flag10 = text4 == null;
							object obj18 = default;
							text = (string)(&obj18);
							if (!flag10)
							{
								nint num5 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag11 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
								text2 = (string)0;
								if (flag11)
								{
									goto IL_08b0;
								}
							}
							bool flag12 = array.Length < 4;
							object obj19 = !flag12;
							object obj20 = array.Length - 4;
							bool flag13 = obj20 == null;
							object obj21 = ~obj19;
							object obj22 = obj21 | flag13;
							if (obj22 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E00]");
								object obj23 = 0;
								object obj24 = array + 64;
								obj24 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag14 = obj23 == null;
								text = text4;
								if (!flag14)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag15 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
									text2 = (string)0;
									if (flag15)
									{
										goto IL_08b0;
									}
								}
								bool flag16 = array.Length < 5;
								object obj25 = !flag16;
								object obj26 = array.Length - 5;
								bool flag17 = obj26 == null;
								object obj27 = ~obj25;
								object obj28 = obj27 | flag17;
								if (obj28 == null)
								{
									text = (string)obj23;
									object obj29 = array + 72;
									obj29 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (ErrorMessage__BackingField != null)
									{
										nint num7 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
										text = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag18 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
										text2 = (string)0;
										if (flag18)
										{
											goto IL_08b0;
										}
									}
									bool flag19 = array.Length < 6;
									object obj30 = !flag19;
									object obj31 = array.Length - 6;
									bool flag20 = obj31 == null;
									object obj32 = ~obj30;
									object obj33 = obj32 | flag20;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9DF0]");
										object obj34 = 0;
										object obj35 = array + 80;
										obj35 = ErrorMessage__BackingField;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool flag21 = obj34 == null;
										text = ErrorMessage__BackingField;
										if (!flag21)
										{
											nint num8 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
											text = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag22 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
											text2 = (string)0;
											if (flag22)
											{
												goto IL_08b0;
											}
										}
										object obj36 = array.Length & 0xFFFFFFF8L;
										if (obj36 != null)
										{
											text = (string)obj34;
											object obj37 = array + 88;
											obj37 = obj34;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											if (StackTrace__BackingField != null)
											{
												nint num9 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
												text = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag23 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
												text2 = (string)0;
												if (flag23)
												{
													goto IL_08b0;
												}
											}
											bool flag24 = array.Length < 8;
											object obj38 = !flag24;
											object obj39 = array.Length - 8;
											bool flag25 = obj39 == null;
											object obj40 = ~obj38;
											object obj41 = obj40 | flag25;
											if (obj41 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E08]");
												object format = 0;
												object obj42 = array + 96;
												obj42 = StackTrace__BackingField;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												return string.Format((string)format, array);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_08b0;
		}
		goto IL_08c8;
		IL_08c8:
		return (string)(object)new NullReferenceException();
		IL_08b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_08c8;
	}

	internal static StartGameResult BuildGameResultFromException(Exception e)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		//IL_05bd: Expected I, but got Obj
		//IL_05c8: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got F8
		//IL_05eb: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I
		//IL_0511: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		ShutdownReason reason;
		ShutdownReason shutdownReason;
		if (e != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F58]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)e;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8300]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X10_v1+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X10_v1+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X11_v32-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X0 (System.Exception)+8C]");
					reason = (ShutdownReason)0;
					goto IL_05a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E18]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v5+130]");
			bool flag2 = num4 < 0;
			object obj9 = !flag2;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v5+130]");
				object obj11 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X11_v30-8]");
				if (0 == (nint)obj8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X0 (System.Exception)+8C]");
					shutdownReason = DisconnectCauseExt.ConvertToShutdownReason((DisconnectCause)0);
					goto IL_056e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E10]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v9+130]");
			bool flag3 = num6 < 0;
			object obj14 = !flag3;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v9+130]");
				object obj16 = num7 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X11_v28-8]");
				if (0 == (nint)obj13)
				{
					reason = (ShutdownReason)12;
					goto IL_05a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E20]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v12+130]");
			bool flag4 = num8 < 0;
			object obj19 = !flag4;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v12+130]");
				object obj21 = num9 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X11_v26-8]");
				if (0 == (nint)obj18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ X0 (System.Exception)+8C]");
					shutdownReason = ErrorCodeExt.ConvertToShutdownReason(0);
					goto IL_056e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E28]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X10_v15+130]");
			bool flag5 = num10 < 0;
			object obj24 = !flag5;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X10_v15+130]");
				object obj26 = num11 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X11_v24-8]");
				if (0 == (nint)obj23)
				{
					goto IL_049b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E30]");
			object obj27 = 0;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X10_v19+130]");
			bool flag6 = num12 < 0;
			object obj29 = !flag6;
			object obj30 = ~obj29;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X10_v19+130]");
				object obj31 = num13 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X11_v22-8]");
				if (0 == (nint)obj28)
				{
					goto IL_04e6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9E38]");
			object obj32 = 0;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X10_v23+130]");
			bool flag7 = num14 < 0;
			object obj34 = !flag7;
			object obj35 = ~obj34;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X10_v23+130]");
				object obj36 = num15 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X11_v20-8]");
				if (0 == (nint)obj33)
				{
					goto IL_04e6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D44D8]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+130]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X10_v26+130]");
			bool flag8 = num16 < 0;
			object obj39 = !flag8;
			if (obj39 == null)
			{
				goto IL_049b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<System.Exception>)+B0]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X10_v26+130]");
			object obj40 = num17 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v11-8]");
			reason = ((0 != (nint)obj38) ? ((ShutdownReason)1) : ((ShutdownReason)21));
			goto IL_05a6;
		}
		return (StartGameResult)(object)new NullReferenceException();
		IL_049b:
		reason = (ShutdownReason)1;
		goto IL_05a6;
		IL_04e6:
		reason = (ShutdownReason)20;
		goto IL_05a6;
		IL_05a6:
		uint num18 = ((Enum)(object)e).System_002EIConvertible_002EToUInt32((IFormatProvider)0);
		nint num19 = (nint)e;
		double num20 = ((Enum)(object)e).System_002EIConvertible_002EToDouble((IFormatProvider)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StartGameResult startGameResult = default;
		startGameResult._002Ector(reason, (string)num18, (string)num20);
		return startGameResult;
		IL_056e:
		reason = shutdownReason;
		goto IL_05a6;
	}
}
