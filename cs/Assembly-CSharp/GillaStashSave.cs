using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public static class GillaStashSave
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass144_0
	{
		public GameObject root;

		public Transform top;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GetUserDataResult> _003C_003E9__33_0;

		public static Action<PlayFabError> _003C_003E9__33_1;

		public static Action<PlayFabError> _003C_003E9__34_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E30]");
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

		internal unsafe void _003CRead_003Eb__33_0(GetUserDataResult result)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0a24: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I
			//IL_0a44: Expected Obj, but got I
			//IL_0047: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_005f: Expected VT, but got Obj
			//IL_05f9: Expected Obj, but got I
			//IL_062b: Expected Obj, but got I
			//IL_0851: Expected Obj, but got I4
			//IL_0870: Expected Obj, but got I
			//IL_00d8: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected Obj, but got Unknown
			//IL_0959: Expected Obj, but got I
			//IL_099c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a1: Expected I4, but got Unknown
			//IL_09d6: Expected Obj, but got I4
			//IL_09de: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e3: Expected Obj, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got I
			//IL_0145: Expected Obj, but got I
			//IL_0155: Expected Obj, but got I
			//IL_0165: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I
			//IL_0186: Expected VT, but got I4
			//IL_0653: Expected Obj, but got I4
			//IL_065c: Expected Obj, but got I4
			//IL_0665: Expected Obj, but got I4
			//IL_066e: Expected Obj, but got I4
			//IL_0ae4: Expected Obj, but got I
			//IL_0aec: Expected I4, but got Obj
			//IL_0b0f: Expected Obj, but got I4
			//IL_068d: Expected Obj, but got I4
			//IL_069d: Expected Obj, but got Ref
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected I4, but got Unknown
			//IL_0205: Expected Obj, but got I
			//IL_06c3: Expected Obj, but got Ref
			//IL_0225: Expected I, but got Obj
			//IL_023d: Expected VT, but got I4
			//IL_024d: Expected VT, but got Obj
			//IL_08d5: Expected Obj, but got I
			//IL_07df: Expected Obj, but got I4
			//IL_06eb: Expected Obj, but got I4
			//IL_0764: Expected Obj, but got I4
			//IL_076d: Expected Obj, but got I4
			//IL_0775: Expected I4, but got Obj
			//IL_0263: Expected VT, but got Obj
			//IL_028c: Expected Obj, but got I
			//IL_02a6: Expected I4, but got I8
			//IL_02c0: Expected Obj, but got I4
			//IL_083e: Expected Obj, but got I4
			//IL_0416: Expected Obj, but got I
			//IL_041e: Expected VT, but got Obj
			//IL_0434: Expected Obj, but got I4
			//IL_0451: Expected Obj, but got I4
			//IL_0459: Expected VT, but got I4
			//IL_0711: Expected Obj, but got I
			//IL_02e6: Expected VT, but got I4
			//IL_0477: Expected Obj, but got I
			//IL_0487: Expected Obj, but got I
			//IL_049d: Expected Obj, but got I
			//IL_04a5: Expected I4, but got Obj
			//IL_04ca: Expected Obj, but got VT
			//IL_04d3: Expected VT, but got I4
			//IL_030c: Expected Obj, but got I
			//IL_0314: Expected VT, but got Obj
			//IL_033f: Expected VT, but got I4
			//IL_04f1: Expected Obj, but got I
			//IL_051a: Expected Obj, but got I4
			//IL_05a5: Expected Obj, but got I
			//IL_05b5: Expected Obj, but got I
			//IL_05c5: Expected VT, but got I
			//IL_05dc: Expected VT, but got I4
			//IL_0365: Expected Obj, but got I
			//IL_037d: Expected Obj, but got I
			//IL_0385: Expected VT, but got Obj
			//IL_039b: Expected Obj, but got I4
			//IL_03b8: Expected Obj, but got I4
			//IL_03c0: Expected VT, but got I4
			//IL_0545: Expected Obj, but got I
			//IL_0569: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Expected Obj, but got Unknown
			//IL_0576: Expected Obj, but got VT
			//IL_0590: Expected VT, but got I4
			//IL_03de: Expected Obj, but got I
			//IL_03f9: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+A0]");
			object obj3 = 0;
			_ = 256;
			Load();
			object s;
			if ((object)result.Data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E38]");
				object key = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E80]");
				object obj4 = 0;
				(System.__Canon, int) tuple = ((System.__Canon, int))obj4;
				if (((Dictionary<System.__Canon, System.__Canon>)(object)result.Data).TryGetValue((System.__Canon)key, out System.__Canon value))
				{
					s = value + 32;
					goto IL_0a34;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			s = 0;
			goto IL_0a34;
			IL_0843:
			int num;
			object obj5 = num - 1;
			bool unsaved = obj5 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D90]");
			object key2 = 0;
			int num2;
			PlayerPrefs.SetInt((string)key2, num2);
			Changed_(unsaved);
			return;
			IL_0934:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v19+8]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v19+8]");
			int number;
			object obj6 = -number;
			bool flag = (nint)obj6 < 0;
			bool flag2 = obj6 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v19+8]");
			int num4 = (int)((nint)0 ^ (nint)number);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v19+8]");
			int num5 = 0 ^ obj6;
			int num6 = num4 & num5;
			bool flag3 = num6 < 0;
			bool flag4 = flag == flag3;
			object obj7 = !flag2;
			object obj8 = flag4 & obj7;
			object obj9 = ~obj8;
			if (obj9 != null)
			{
				num3 = number;
			}
			num2 = number;
			goto IL_0843;
			IL_08b4:
			int count = Count;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v30+A0]");
			object obj11 = 0;
			bool flag5 = count < 41;
			int num7;
			num = num7;
			List<(System.__Canon, int)> list;
			if (!flag5)
			{
				list = (List<(System.__Canon, int)>)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
				bool flag6 = (nint)0 > (nint)0;
				num = num7;
				if (flag6)
				{
					goto IL_088c;
				}
			}
			goto IL_0934;
			IL_0a34:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DF8]");
			object key3 = 0;
			List<(string, int)> list2 = Parse((string)s, out number);
			num7 = PlayerPrefs.GetInt((string)key3, 0);
			if (num7 == 1)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v17+A0]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v19+C]");
				object obj13 = 0;
				int num8 = number;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v19+C]");
				bool flag7 = (nint)num8 <= (nint)0;
				num = num7;
				if (!flag7)
				{
					Enumerator<, > enumerator = ((List<(System.__Canon, int)>)(object)list2).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DA0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E90]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DE8]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E88]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DC8]");
					object obj18 = 0;
					num = num7;
					(System.__Canon, int) tuple2 = ((System.__Canon, int))0;
					int num9 = number;
					Enumerator<, > val = default;
					object obj19 = default;
					int value2 = default;
					Predicate<(System.__Canon, int)> predicate = default;
					int num12 = default;
					object obj40;
					object obj41;
					while (val.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj19._002Ector();
						object obj22;
						if (obj19 != null)
						{
							num = obj19 + 16;
							((int*)num)->m_value = value2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v44+A0]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							predicate._002Ector(obj19, (IntPtr)obj17);
							bool flag8 = obj21 == null;
							(System.__Canon, int) tuple = ((System.__Canon, int))0;
							obj22 = obj19;
							tuple2 = ((System.__Canon, int))obj17;
							if (!flag8)
							{
								tuple2 = ((System.__Canon, int))obj18;
								int num10 = ((List<(System.__Canon, int)>)obj21).FindIndex(predicate);
								object obj23 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v46+A0]");
								object obj24 = 0;
								object obj25 = obj24;
								int num11 = (int)(num10 & 0x80000000L);
								bool flag9 = num11 == 0;
								object obj26 = !flag9;
								(System.__Canon, int) tuple4;
								if (obj26 == null)
								{
									bool flag10 = obj24 == null;
									tuple = ((System.__Canon, int))0;
									obj22 = predicate;
									if (flag10)
									{
										goto IL_074d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DD8]");
									object obj27 = 0;
									tuple2 = ((System.__Canon, int))obj27;
									(System.__Canon, int) tuple3 = ((List<(System.__Canon, int)>)obj24).get_Item(num10);
									bool flag11 = num10 >= num12;
									tuple = ((System.__Canon, int))0;
									if (flag11)
									{
										continue;
									}
									object obj28 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v55+A0]");
									object obj29 = 0;
									obj25 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63E0]");
									object obj30 = 0;
									tuple = ((System.__Canon, int))obj30;
									tuple4 = ((System.__Canon)((int*)num)->m_value, num12);
									bool flag12 = obj29 == null;
									obj22 = ((int*)num)->m_value;
									tuple2 = ((System.__Canon, int))num12;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DE0]");
										object obj31 = 0;
										((List<(System.__Canon, int)>)obj29).set_Item(num10, tuple4);
										tuple = ((System.__Canon, int))0;
										tuple2 = tuple4;
										continue;
									}
									goto IL_075b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63E0]");
								object obj32 = 0;
								tuple = ((System.__Canon, int))obj32;
								tuple4 = ((System.__Canon)((int*)num)->m_value, num12);
								bool flag13 = obj24 == null;
								obj22 = ((int*)num)->m_value;
								tuple2 = ((System.__Canon, int))num12;
								if (!flag13)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+10]");
									object obj33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DC0]");
									object obj34 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+1C]");
									obj13 = (nint)0 + (nint)1;
									num9 = (int)obj34;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+10]");
									bool flag14 = (nint)0 == 0;
									obj22 = tuple4;
									tuple2 = ((System.__Canon, int))0;
									if (!flag14)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+18]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+18]");
										nint num13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v50+18]");
										bool flag15 = num13 < 0;
										object obj35 = !flag15;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+10]");
											nint num14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+18]");
											object obj36 = num14 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X22_v8 (System.Object)+18]");
											num9 = (int)((nint)0 + (nint)1);
											object obj37 = obj36 + 32;
											obj37 = tuple4;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											tuple2 = ((System.__Canon, int))0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X9_v19 (System.Int32)+20]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X8_v51+A8]");
											object obj39 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v52+70]");
											tuple = ((System.__Canon, int))0;
											((List<(System.__Canon, int)>)obj24).AddWithResize(tuple4);
											tuple2 = ((System.__Canon, int))0;
										}
										continue;
									}
								}
								goto IL_073f;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
							obj22 = null;
						}
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_073f;
						IL_074d:
						NullReferenceException ex3 = new NullReferenceException();
						goto IL_075b;
						IL_075b:
						obj40 = 0;
						obj41 = 0;
						num2 = (int)obj22;
						throw new NullReferenceException();
						IL_073f:
						NullReferenceException ex4 = new NullReferenceException();
						goto IL_074d;
					}
					obj40 = 0;
					obj41 = 0;
					object obj42 = 10;
					object obj43 = 0;
					object obj47 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D98]");
						object obj44 = 0;
						num2 = (int)obj44;
						val.Dispose();
						bool flag16 = obj43 == null;
						object obj45 = !flag16;
						num = num7;
						if (obj45 == null)
						{
							bool flag17 = obj40 == null;
							object obj46 = !flag17;
							num = num7;
							OutOfMemoryException ex5 = (OutOfMemoryException)(&val);
							if (obj46 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex5 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if (num2 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj40 = 1;
							obj43 = obj41;
							goto IL_0835;
						}
						if (num2 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj43 = obj47;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj41 = obj47;
							goto IL_0835;
						}
						goto IL_0ab1;
						IL_0835:
						obj42 = 0;
					}
					bool flag18 = (nint)obj42 == 10;
					list = (List<(System.__Canon, int)>)(&val);
					if (!flag18)
					{
						bool flag19 = obj42 == null;
						object obj48 = !flag19;
						if (obj48 == null)
						{
							object obj49 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v34+A0]");
							object obj50 = 0;
							list = (List<(System.__Canon, int)>)obj50;
							goto IL_088c;
						}
						return;
					}
					goto IL_08b4;
				}
				goto IL_0934;
			}
			object obj51 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v12+A0]");
			object obj52 = 0;
			obj52 = list2;
			object obj53 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj54 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v15+A0]");
			object obj55 = 0;
			num = num7;
			num2 = number;
			goto IL_0843;
			IL_088c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
			int index = (int)(-1);
			list.RemoveAt(index);
			goto IL_08b4;
			IL_0ab1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EB68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			goto IL_0843;
		}

		internal void _003CRead_003Eb__33_1(PlayFabError error)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I
			//IL_00e8: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj3 = 0;
			_ = 0;
			float unscaledTime = Time.unscaledTime;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5+A0]");
			object obj5 = 0;
			float num = unscaledTime + 20f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E98]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj7 = 0;
			string text = error.GenerateErrorReport();
			string message = (string)obj6 + text;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}

		internal void _003CSave_003Eb__34_1(PlayFabError error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0072: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EA0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj2 = 0;
			string text = error.GenerateErrorReport();
			string message = (string)obj + text;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public string label;

		internal bool _003CAdd_003Eb__0((string, int) i)
		{
			//IL_000f: Expected Obj, but got VT
			return i == label;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string label;

		internal bool _003CTake_003Eb__0((string, int) i)
		{
			//IL_000f: Expected Obj, but got VT
			return i == label;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public string label;

		internal bool _003CRead_003Eb__2((string, int) i)
		{
			//IL_000f: Expected Obj, but got VT
			return i == label;
		}
	}

	public const int Holds = default(int);

	private const string Key = null;

	private const string UnsavedKey = null;

	private const string BaseKey = null;

	private const string DataKey = null;

	private const float SaveAfter = default(float);

	private const float SaveRetry = default(float);

	private const int MostKinds = default(int);

	private static List<(string, int)> items;

	private static int rev;

	private static int baseRev;

	private static bool reading;

	private static bool read;

	private static bool testing;

	private static float nextTry;

	private static float changedAt;

	private static Action m_Changed;

	public static IReadOnlyList<(string, int)> Items
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj = 0;
			Load();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			return (IReadOnlyList<(string, int)>)0;
		}
	}

	public unsafe static int Count
	{
		get
		{
			//IL_01b8: Expected Obj, but got I
			//IL_0027: Expected Obj, but got I
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got I4
			//IL_0067: Expected Obj, but got I4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got I4
			//IL_0212: Expected Obj, but got I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected I4, but got Unknown
			//IL_0098: Expected Obj, but got I4
			//IL_00a0: Expected Obj, but got Ref
			//IL_0135: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			int num = 0;
			Load();
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (System.Int32)+A0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D98]");
			object obj2 = 0;
			Enumerator<, > enumerator = ((List<(System.__Canon, int)>)obj).GetEnumerator();
			int num2 = 0;
			Enumerator<, > val = default;
			object obj3 = default;
			while (val.MoveNext())
			{
				num2 += obj3;
			}
			object obj4 = 0;
			object obj5 = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			object obj6 = 0;
			object obj10 = default;
			object obj11 = default;
			object obj12 = default;
			object obj13 = default;
			object obj14 = default;
			while (true)
			{
				object obj7 = obj2;
				val.Dispose();
				bool flag = obj6 == null;
				object obj8 = !flag;
				if (obj8 == null)
				{
					bool flag2 = obj4 == null;
					object obj9 = !flag2;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					if (obj9 == null)
					{
						return num2;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					obj4 = obj10;
					obj5 = obj11;
					obj7 = obj12;
					obj2 = obj13;
					num2 = num;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj7 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj4 = 1;
					obj6 = obj5;
					continue;
				}
				if ((nint)obj7 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj6 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj5 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EB68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			int result = default;
			return result;
		}
	}

	public static event Action Changed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_00c3: Expected Obj, but got I
			//IL_0052: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			Delegate obj9 = default;
			while (true)
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 != null && obj6 != obj4)
				{
					break;
				}
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v3+A0]");
				object obj8 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj9 != obj5;
				obj5 = obj9;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+A0]");
		object obj6 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
	}

	public unsafe static int CountOf(string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_024a: Expected I, but got Obj
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Ref, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj = 0;
		Load();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D98]");
		object obj4 = 0;
		Enumerator<, > enumerator = ((List<(System.__Canon, int)>)obj3).GetEnumerator();
		object obj6 = default;
		object obj5 = obj6;
		Enumerator<, > val = default;
		string text = default;
		int num = default;
		object obj12 = default;
		object obj13 = default;
		IntPtr intPtr = default;
		object obj14 = default;
		while (true)
		{
			object obj7;
			object obj8;
			Enumerator<, > val2;
			object obj9;
			int result;
			if (val.MoveNext())
			{
				bool flag = null == text;
				bool flag2 = !flag;
				obj5 = 0;
				if (flag2)
				{
					continue;
				}
				obj5 = 0;
				obj7 = 0;
				obj8 = 0;
				val2 = (Enumerator<, >)(ref val);
				obj9 = 0;
				result = num;
				goto IL_0242;
			}
			obj7 = 0;
			obj8 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj9 = 0;
			goto IL_027b;
			IL_027b:
			result = 0;
			goto IL_0242;
			IL_0242:
			nint num2 = (nint)obj4;
			((Enumerator<, >*)val2)->Dispose();
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				bool flag4 = obj7 == null;
				object obj11 = !flag4;
				OutOfMemoryException ex = (OutOfMemoryException)val2;
				if (obj11 == null)
				{
					return result;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj5 = obj6;
				obj7 = obj12;
				obj8 = obj13;
				num2 = intPtr;
				obj4 = 109891584;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if (num2 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj7 = 1;
				obj9 = obj8;
			}
			else
			{
				if (num2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj9 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj8 = obj14;
			}
			goto IL_027b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EB68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		int result2 = default;
		return result2;
	}

	public static bool Fits(int more)
	{
		//IL_0016: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		int count = Count;
		object obj = count + more;
		object obj2 = obj - 41;
		bool flag = (nint)obj2 < 0;
		object obj3 = obj ^ 0x29;
		object obj4 = obj ^ obj2;
		object obj5 = obj3 & obj4;
		bool flag2 = (nint)obj5 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	public static bool Add(string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_036a: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_00b0: Expected I4, but got I8
		//IL_010e: Expected I4, but got I8
		//IL_0142: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I
		//IL_01cc: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_022d: Expected I4, but got I8
		//IL_0247: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I
		//IL_02bb: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DB8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = label;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag = string.IsNullOrEmpty((string)obj3);
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				if (obj3 == null)
				{
					goto IL_035c;
				}
				int num = ((string)obj3).IndexOf('|');
				if ((int)(num & 0x80000000L) != 0)
				{
					if (obj3 == null)
					{
						goto IL_035c;
					}
					int num2 = ((string)obj3).IndexOf('=');
					if ((int)(num2 & 0x80000000L) != 0)
					{
						int count = Count;
						object obj5 = count + 1;
						if ((nint)obj5 <= 40)
						{
							Load();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
							object obj6 = 0;
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v7+A0]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DE8]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DF0]");
							object obj10 = 0;
							Predicate<(System.__Canon, int)> predicate = default;
							predicate._002Ector(obj2, (IntPtr)obj10);
							if (obj8 != null)
							{
								int num3 = ((List<(System.__Canon, int)>)obj8).FindIndex(predicate);
								object obj11 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v13+A0]");
								object obj12 = 0;
								List<(System.__Canon, int)> list = (List<(System.__Canon, int)>)obj12;
								int num4 = (int)(num3 & 0x80000000L);
								bool flag3 = num4 == 0;
								object obj13 = !flag3;
								if (obj13 == null)
								{
									if (obj12 != null)
									{
										(System.__Canon, int) tuple = ((List<(System.__Canon, int)>)obj12).get_Item(num3);
										int item = num3 + 1;
										(System.__Canon, int) tuple2 = ((System.__Canon)obj3, item);
										((List<(System.__Canon, int)>)obj12).set_Item(num3, ((System.__Canon, int))0);
										goto IL_0336;
									}
								}
								else if (obj12 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v8 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
									if ((nint)0 <= (nint)63)
									{
										(System.__Canon, int) tuple2 = ((System.__Canon)obj3, 1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DC0]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EBA4");
										goto IL_0336;
									}
									goto IL_034e;
								}
							}
							goto IL_035c;
						}
					}
				}
			}
			goto IL_034e;
		}
		goto IL_035c;
		IL_035c:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_034e:
		return false;
		IL_0336:
		Changed_(unsaved: true);
		return true;
	}

	public static bool Take(string label)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0264: Expected I4, but got Obj
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_00e8: Expected I4, but got I8
		//IL_0102: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0225: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		int num;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DE8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E10]");
			object obj5 = 0;
			object obj6 = obj2 + 16;
			obj6 = label;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Load();
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v4+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Predicate<(System.__Canon, int)> predicate = default;
			predicate._002Ector(obj2, (IntPtr)obj5);
			if (obj8 != null)
			{
				num = ((List<(System.__Canon, int)>)obj8).FindIndex(predicate);
				int num2 = (int)(num & 0x80000000L);
				bool flag = num2 == 0;
				object obj9 = !flag;
				if (obj9 != null)
				{
					goto IL_023a;
				}
				object obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v10+A0]");
				object obj11 = 0;
				if (obj11 != null)
				{
					(System.__Canon, int) tuple = ((List<(System.__Canon, int)>)obj11).get_Item(num);
					object obj12 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v12+A0]");
					object obj13 = 0;
					if (num < 2)
					{
						if (obj13 != null)
						{
							((List<(System.__Canon, int)>)obj13).RemoveAt(num);
							goto IL_022b;
						}
					}
					else if (obj13 != null)
					{
						(System.__Canon, int) tuple2 = ((List<(System.__Canon, int)>)obj13).get_Item(num);
						int item = num - 1;
						(System.__Canon, int) tuple3 = ((System.__Canon)obj6, item);
						((List<(System.__Canon, int)>)obj13).set_Item(num, ((System.__Canon, int))0);
						goto IL_022b;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_023a:
		int num3 = ~num;
		return (byte)(num3 >> 31) != 0;
		IL_022b:
		Changed_(unsaved: true);
		goto IL_023a;
	}

	public static void Tick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_030f: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Invalid comparison between F4 and I
		//IL_01fe: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v4+12]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v7+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v11+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E18]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v10+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v17+10]");
			bool flag5 = ((PlayFabAuthenticationContext)0).IsClientLoggedIn();
			object obj15 = obj;
			if (flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v19+11]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DF8]");
					object key = 0;
					int num = PlayerPrefs.GetInt((string)key, 0);
					if (num != 1)
					{
						return;
					}
					float unscaledTime = Time.unscaledTime;
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v23+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v24+14]");
					if (!(unscaledTime < 0f))
					{
						float unscaledTime2 = Time.unscaledTime;
						object obj19 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v25+A0]");
						object obj20 = 0;
						float num2 = unscaledTime2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v26+18]");
						float num3 = num2 - 0f;
						if (!((double)num3 < 2.0))
						{
							Save();
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v19+10]");
					bool flag6 = (nint)0 == 0;
					object obj21 = !flag6;
					if (obj21 == null)
					{
						Read();
					}
				}
				return;
			}
		}
		else
		{
			object obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v13+A0]");
		object obj22 = 0;
		_ = 0;
	}

	private unsafe static void Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3+A0]");
		object obj3 = 0;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D88]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object defaultValue = 0;
			string s = PlayerPrefs.GetString((string)key, (string)defaultValue);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v9+A0]");
			List<(string, int)> list = Parse(s, out *(int*)((nint)0 + (nint)8));
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v11+A0]");
			object obj7 = 0;
			obj7 = list;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D90]");
			object key2 = 0;
			int num = PlayerPrefs.GetInt((string)key2, 0);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v16+A0]");
			object obj10 = 0;
		}
	}

	private static void Changed_(bool unsaved)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D88]");
		object key = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object list = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+8]");
		string value = Write((List<(string, int)>)list, 0);
		PlayerPrefs.SetString((string)key, value);
		if (unsaved)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DF8]");
			object key2 = 0;
			PlayerPrefs.SetInt((string)key2, 1);
			float unscaledTime = Time.unscaledTime;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v12+A0]");
			object obj4 = 0;
		}
		PlayerPrefs.Save();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+20]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v9+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v9+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v9+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v84 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private unsafe static string Write(List<(string, int)> list, int number)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected I, but got Obj
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got I4
		//IL_03cb: Expected I4, but got Obj
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Ref, but got Unknown
		//IL_03ee: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_00e1: Expected I, but got Obj
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_020c: Expected I, but got Obj
		//IL_0178: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		bool flag = stringBuilder == null;
		Enumerator<, > val = (Enumerator<, >)0;
		int num2 = default;
		int num = num2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		int num3 = 0;
		object obj2 = 109891584;
		if (!flag)
		{
			StringBuilder stringBuilder2 = stringBuilder.Append(number);
			bool flag2 = (object)list == null;
			val = (Enumerator<, >)0;
			num = num2;
			val2 = (Enumerator<, >)0;
			nint num4 = unchecked((nint)null);
			num3 = number;
			obj2 = 109891584;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D98]");
				obj2 = 0;
				Enumerator<, > enumerator = ((List<(System.__Canon, int)>)(object)list).GetEnumerator();
				num4 = unchecked((nint)null);
				int num5 = default;
				Enumerator<, > val3 = default;
				object obj7 = default;
				string result = default;
				string result2 = default;
				object obj3;
				int num6;
				Enumerator<, > val4;
				while (true)
				{
					if (val.MoveNext())
					{
						if (num5 < 1)
						{
							continue;
						}
						StringBuilder stringBuilder3 = stringBuilder.Append('|');
						bool flag3 = stringBuilder3 == null;
						num4 = unchecked((nint)null);
						char c = '|';
						if (!flag3)
						{
							StringBuilder stringBuilder4 = stringBuilder3.Append((string)num2);
							bool flag4 = stringBuilder4 == null;
							num4 = unchecked((nint)null);
							num3 = num2;
							if (flag4)
							{
								break;
							}
							StringBuilder stringBuilder5 = stringBuilder4.Append('=');
							if (stringBuilder5 != null)
							{
								StringBuilder stringBuilder6 = stringBuilder5.Append(num5);
								num4 = unchecked((nint)null);
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							num4 = unchecked((nint)null);
							c = '=';
						}
						NullReferenceException ex2 = new NullReferenceException();
						num3 = c;
						break;
					}
					val = val3;
					num = 0;
					obj3 = 0;
					num6 = num2;
					val2 = val3;
					val4 = (Enumerator<, >)(ref val);
					object obj4 = 0;
					while (true)
					{
						num3 = (int)obj2;
						((Enumerator<, >*)val4)->Dispose();
						bool flag5 = obj4 == null;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							bool flag6 = num == 0;
							object obj6 = !flag6;
							OutOfMemoryException ex3 = (OutOfMemoryException)val4;
							if (obj6 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex3 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch (num3)
						{
						case 2:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							num = 1;
							obj4 = obj3;
							break;
						case 1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj4 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj3 = obj7;
							break;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EB68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
					}
					((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
					return result2;
				}
				NullReferenceException ex4 = new NullReferenceException();
				val = val3;
				num = 0;
				obj3 = 0;
				num6 = num2;
				val2 = val3;
				val4 = (Enumerator<, >)(ref val);
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static List<(string, int)> Parse(string s, out int number)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I4
		//IL_025a: Expected Obj, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected I4, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected I4, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_0373: Expected Obj, but got I4
		//IL_03c0: Expected Obj, but got I
		//IL_03f2: Expected Obj, but got I
		//IL_0410: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I4
		//IL_04e5: Expected Obj, but got I
		//IL_04f5: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I
		//IL_0513: Expected VT, but got I4
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_052f: Expected VT, but got I4
		//IL_048e: Expected Obj, but got I
		//IL_04a4: Expected Obj, but got I
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E70]");
		object obj = 0;
		ref int reference = ref *(int*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, int)> list = default;
		list._002Ector();
		bool flag = string.IsNullOrEmpty(s);
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 != null)
		{
			goto IL_053c;
		}
		if (s != null)
		{
			string[] array = s.Split('|', (StringSplitOptions)0);
			if (array != null)
			{
				if (array.Length != 0)
				{
					bool flag3 = int.TryParse(array[0], out number);
					object obj3 = array.Length;
					if (array.Length >= 2)
					{
						if (list == null)
						{
							goto IL_0541;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C63E0]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8DC0]");
						object obj5 = 0;
						int result = 0;
						object obj6 = 5;
						object obj7 = 0;
						object obj8 = 0;
						object obj25;
						do
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
							if ((nint)0 >= (nint)64)
							{
								break;
							}
							object obj9 = obj6 - 4;
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
							object obj10 = !flag4;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13 (System.String[])+v120 @ X25_v6*8]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13 (System.String[])+v120 @ X25_v6*8]");
									int num = ((string)0).LastIndexOf('=');
									if (num < 1)
									{
										goto IL_058b;
									}
									bool flag5 = (nint)obj9 < array.Length;
									object obj11 = !flag5;
									if (obj11 != null)
									{
										goto IL_054f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13 (System.String[])+v120 @ X25_v6*8]");
									if ((nint)0 != 0)
									{
										int startIndex = num + 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13 (System.String[])+v120 @ X25_v6*8]");
										string s2 = ((string)0).Substring(startIndex);
										if (!int.TryParse(s2, out result) || result < 1)
										{
											goto IL_058b;
										}
										int num2 = 40 - obj8;
										object obj12 = result - num2;
										bool flag6 = (nint)obj12 < 0;
										int num3 = result ^ num2;
										int num4 = result ^ obj12;
										int num5 = num3 & num4;
										bool flag7 = num5 < 0;
										bool flag8 = flag6 == flag7;
										object obj13 = !flag8;
										object obj14 = ~obj13;
										int num6 = ((obj14 != null) ? num2 : result);
										if (num2 < 1)
										{
											break;
										}
										bool flag9 = (nint)obj9 < array.Length;
										object obj15 = !flag9;
										if (obj15 != null)
										{
											goto IL_054f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13 (System.String[])+v120 @ X25_v6*8]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v13 (System.String[])+v120 @ X25_v6*8]");
											string item = ((string)0).Substring(0, num);
											obj7 = obj4;
											(System.__Canon, int) tuple = ((System.__Canon)(object)item, num6);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+10]");
											object obj16 = 0;
											object obj17 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+1C]");
											object obj18 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+10]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
												nint num7 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v14+18]");
												bool flag10 = num7 < 0;
												object obj19 = !flag10;
												if (obj19 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+10]");
													nint num8 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
													object obj20 = num8 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Int32>>)+18]");
													object obj21 = (nint)0 + (nint)1;
													object obj22 = obj20 + 32;
													obj22 = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+20]");
													object obj23 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v16+A8]");
													object obj24 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v17+70]");
													obj7 = 0;
													list.AddWithResize(((System.__Canon, int))0);
												}
												obj8 = num6 + obj8;
												tuple = ((System.__Canon, int))0;
												result = num6;
												goto IL_058b;
											}
										}
									}
								}
								goto IL_0541;
							}
							goto IL_054f;
							IL_058b:
							obj3 = array.Length;
							obj6++;
							obj25 = obj6 - 4;
						}
						while ((nint)obj25 < array.Length);
					}
					goto IL_053c;
				}
				goto IL_054f;
			}
		}
		goto IL_0541;
		IL_0541:
		NullReferenceException ex = new NullReferenceException();
		goto IL_054f;
		IL_053c:
		return (List<(string, int)>)(object)list;
		IL_054f:
		return (List<(string, int)>)(object)new IndexOutOfRangeException();
	}

	private static void Read()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_037a: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I4
		//IL_03d2: Expected Obj, but got I
		//IL_03ec: Expected Obj, but got I
		//IL_03f4: Expected I, but got Obj
		//IL_0405: Expected I, but got Obj
		//IL_0423: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I
		//IL_04c4: Expected Obj, but got I
		//IL_04cc: Expected I, but got Obj
		//IL_04dd: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj3 = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GetUserDataRequest getUserDataRequest = default;
		getUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		object obj7 = 0;
		System.__Canon[] array = list._items;
		object obj8 = obj7;
		int version = list._version + 1;
		list._version = version;
		bool flag = list._size < array.Length;
		object obj9 = !flag;
		if (obj9 == null)
		{
			object obj10 = array + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj11 = obj10 + 32;
			obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v5+20]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v27+A8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v28+70]");
			nint num = 0;
			list.AddWithResize((System.__Canon)obj6);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E30]");
		object obj14 = 0;
		object obj15 = getUserDataRequest + 32;
		obj15 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v21+8]");
		Action<GetUserDataResult> resultCallback = (Action<GetUserDataResult>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v21+8]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		List<System.__Canon> list2 = list;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v25+A0]");
				obj18 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E20]");
			object obj23 = 0;
			nint num = (nint)obj23;
			Action<System.__Canon> action = default;
			action._002Ector(obj18, (IntPtr)obj23);
			object obj24 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v24+A0]");
			object obj25 = (nint)0 + (nint)8;
			obj25 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj16 = obj14;
			object obj26 = 0;
			list2 = (List<System.__Canon>)(object)action;
			resultCallback = (Action<GetUserDataResult>)action;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj27 = !flag5;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+10]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+10]");
		bool flag6 = (nint)0 == 0;
		object obj30 = !flag6;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj31 = !flag7;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v19+A0]");
				obj28 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E28]");
			object obj34 = 0;
			nint num = (nint)obj34;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj28, (IntPtr)obj34);
			object obj35 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v18+A0]");
			object obj36 = (nint)0 + (nint)16;
			obj36 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj26 = 0;
			list2 = (List<System.__Canon>)(object)action2;
			errorCallback = (Action<PlayFabError>)action2;
		}
		object obj37 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		object obj38 = !flag8;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.GetUserData(getUserDataRequest, resultCallback, errorCallback);
	}

	private static void Save()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01bb: Expected I, but got Obj
		//IL_01cc: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I4
		//IL_02fa: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_038d: Expected I, but got Obj
		//IL_039e: Expected I, but got Obj
		//IL_03bc: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Load();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D80]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+A0]");
		object list = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E68]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+8]");
		int number = (int)((nint)0 + (nint)1);
		string text = Write((List<(string, int)>)list, number);
		object obj7 = obj2 + 24;
		obj7 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+A0]");
		object obj9 = 0;
		float num = unscaledTime + 20f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UpdateUserDataRequest updateUserDataRequest = default;
		updateUserDataRequest._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E38]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E50]");
		object obj10 = 0;
		dictionary.Add((System.__Canon)key, (System.__Canon)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E48]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E30]");
		object obj13 = 0;
		object obj14 = updateUserDataRequest + 32;
		obj14 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num2 = (nint)obj12;
		Action<System.__Canon> action = default;
		action._002Ector(obj2, (IntPtr)obj12);
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v22+E4]");
		bool flag = (nint)0 == 0;
		object obj16 = !flag;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v22+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+18]");
		Action<PlayFabError> errorCallback = (Action<PlayFabError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v14+18]");
		bool flag2 = (nint)0 == 0;
		object obj19 = !flag2;
		object obj20 = 0;
		object obj21 = obj2;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj22 = !flag3;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v18+A0]");
				obj17 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5998]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E58]");
			object obj25 = 0;
			num2 = (nint)obj25;
			Action<System.__Canon> action2 = default;
			action2._002Ector(obj17, (IntPtr)obj25);
			object obj26 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17+A0]");
			object obj27 = (nint)0 + (nint)24;
			obj27 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj20 = 0;
			obj21 = action2;
			errorCallback = (Action<PlayFabError>)action2;
		}
		object obj28 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj29 = !flag4;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayFabClientAPI.UpdateUserData(updateUserDataRequest, (Action<UpdateUserDataResult>)action, errorCallback);
	}
}
