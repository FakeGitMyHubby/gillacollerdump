using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using UnityEngine;

public class GillaOfflineReport : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public float now;

		internal bool _003CNoteDrop_003Eb__0(float t)
		{
			//IL_002a: Invalid comparison between F4 and I4
			//IL_0039: Invalid comparison between F4 and I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_005a: Expected Obj, but got F4
			//IL_008f: Expected Obj, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected I4, but got Unknown
			float num = now - t;
			float num2 = num - 1.1422925E+09f;
			bool flag = num2 < 0f;
			bool flag2 = num2 == 0f;
			object obj = num ^ 0x44160000;
			object obj2 = num ^ num2;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			return (byte)((flag4 & obj4) ? 1 : 0) != 0;
		}
	}

	[Serializable]
	private class Body
	{
		public string offline;

		public string step;

		public string build;

		public int secs;

		public bool back;

		public string detail;
	}

	public class Report
	{
		public string Offline;

		public string Step;

		public int Secs;

		public bool Back;
	}

	public class Decider
	{
		public const float Look = default(float);

		public const float FailAfter = default(float);

		public const float WaitAfter = default(float);

		public const float BlankAfter = default(float);

		public const float PutAway = default(float);

		public const int MostOut = default(int);

		public const int MostBack = default(int);

		public const string NoReason = null;

		private float outSince;

		private float lastLook;

		private string why;

		private string whyStep;

		private string told;

		private string toldStep;

		private int outSent;

		private int backSent;

		private readonly HashSet<string> sent;

		public Report Step(bool inRoom, string shown, string step, bool skip, float now)
		{
			//IL_0765: Invalid comparison between F4 and I4
			//IL_010c: Invalid comparison between F4 and I4
			//IL_07b3: Expected Obj, but got I4
			//IL_021c: Expected Obj, but got I4
			//IL_0617: Expected Obj, but got I
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected Obj, but got Unknown
			//IL_023a: Expected Obj, but got I
			//IL_031d: Expected Obj, but got I4
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Expected Obj, but got Unknown
			//IL_065f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0664: Expected Obj, but got Unknown
			//IL_0681: Unknown result type (might be due to invalid IL or missing references)
			//IL_0686: Expected Obj, but got Unknown
			//IL_0356: Expected Obj, but got I
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d1: Expected Obj, but got Unknown
			//IL_06d3: Invalid comparison between F4 and I4
			//IL_06e4: Expected Obj, but got I4
			//IL_06ed: Invalid comparison between F4 and I4
			//IL_06fe: Expected Obj, but got I4
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected Obj, but got Unknown
			//IL_0738: Expected F4, but got I4
			//IL_03c2: Expected F8, but got I4
			//IL_0382: Expected Obj, but got I4
			//IL_03a2: Expected F8, but got I4
			//IL_0433: Expected Obj, but got I4
			//IL_0470: Expected Obj, but got I
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Expected Obj, but got Unknown
			//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Expected Obj, but got Unknown
			//IL_04ee: Expected Obj, but got I
			//IL_052c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Expected Obj, but got Unknown
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected Obj, but got Unknown
			//IL_0573: Invalid comparison between F4 and I4
			//IL_0584: Expected Obj, but got I4
			//IL_058d: Invalid comparison between F4 and I4
			//IL_05b8: Expected Obj, but got I4
			//IL_05f2: Expected F4, but got I4
			float num = lastLook;
			if (!(lastLook < 0f))
			{
				num = now - num;
				bool flag = !((double)num > 10.0);
				double num2 = 10.0;
				if (!flag)
				{
					Restart();
					num2 = 10.0;
				}
			}
			lastLook = now;
			if (skip)
			{
				Restart();
				goto IL_008f;
			}
			bool flag2 = default;
			if (flag2)
			{
				object result;
				if (told == null || backSent > 4)
				{
					result = null;
				}
				else
				{
					int num3 = backSent + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F50]");
					object obj = 0;
					backSent = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj2 = default;
					obj2._002Ector();
					if (obj2 == null)
					{
						goto IL_0742;
					}
					object obj3 = obj2 + 16;
					obj3 = told;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj4 = obj2 + 24;
					obj4 = toldStep;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 1;
					float num4 = now - outSince;
					float num5 = num4 + 0.5f;
					bool flag3 = num4 < 0f;
					object obj5 = !flag3;
					bool flag4 = num4 == 0f;
					object obj6 = !flag4;
					object obj7 = obj5 & obj6;
					object obj8 = ~obj7;
					if (obj8 == null)
					{
						float num6 = num5;
					}
					else
					{
						float num6 = 0f;
					}
					result = obj2;
				}
				Restart();
				return (Report)result;
			}
			if (outSince < 0f)
			{
				outSince = now;
			}
			bool flag5 = string.IsNullOrEmpty(shown);
			bool flag6 = !flag5;
			object obj9 = !flag6;
			string text = null;
			if (obj9 != null)
			{
				goto IL_01d4;
			}
			if (shown != null)
			{
				string text2 = shown.Trim();
				if (text2 != null)
				{
					bool flag7 = text2._stringLength < 1;
					text = null;
					if (flag7)
					{
						goto IL_01d4;
					}
					string text3 = shown.Trim();
					object obj10 = this + 24;
					obj10 = text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_022a;
				}
			}
			goto IL_0742;
			IL_022a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj11 = 0;
			text = (string)((step != null) ? step : obj11);
			object obj12 = this + 32;
			obj12 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_0274;
			IL_008f:
			return null;
			IL_01d4:
			string text4 = why;
			if (why != null)
			{
				bool flag8 = text4._stringLength == 0;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					goto IL_022a;
				}
				goto IL_0274;
			}
			goto IL_0742;
			IL_0274:
			object obj14 = this + 24;
			string text5 = (string)obj14;
			if (obj14 != null)
			{
				bool flag9 = text5._stringLength < 0;
				bool flag10 = text5._stringLength == 0;
				int num7 = text5._stringLength ^ text5._stringLength;
				int num8 = text5._stringLength & num7;
				bool flag11 = num8 < 0;
				bool flag12 = flag9 == flag11;
				object obj15 = !flag10;
				object obj16 = flag12 & obj15;
				object obj17 = ~obj16;
				if (obj17 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F58]");
					obj14 = 0;
				}
				double num9;
				if (text5._stringLength != 0)
				{
					bool flag13 = Waiting((string)obj14);
					bool flag14 = !flag13;
					object obj18 = !flag14;
					object obj19 = ~obj18;
					num9 = ((obj19 != null) ? 20.0 : 1114636288.0);
				}
				else
				{
					num9 = 1119092736.0;
				}
				float num10 = now - outSince;
				if ((double)num10 < num9 || outSent > 4)
				{
					goto IL_008f;
				}
				if (sent != null)
				{
					bool flag15 = ((HashSet<System.__Canon>)(object)sent).Contains((System.__Canon)obj14);
					bool flag16 = !flag15;
					object obj20 = !flag16;
					if (obj20 != null)
					{
						goto IL_008f;
					}
					if (sent != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
						object obj21 = 0;
						bool flag17 = ((HashSet<System.__Canon>)(object)sent).Add((System.__Canon)obj14);
						object obj22 = this + 40;
						obj22 = obj14;
						int num11 = outSent + 1;
						outSent = num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj23 = this + 48;
						obj23 = whyStep;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F50]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						object obj25 = default;
						obj25._002Ector();
						if (obj25 != null)
						{
							object obj26 = obj25 + 16;
							obj26 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj27 = obj25 + 24;
							obj27 = whyStep;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag18 = num10 < 0f;
							object obj28 = !flag18;
							bool flag19 = num10 == 0f;
							_ = 0;
							float num12 = num10 + 0.5f;
							object obj29 = !flag19;
							object obj30 = obj28 & obj29;
							object obj31 = ~obj30;
							if (obj31 == null)
							{
								float num13 = num12;
							}
							else
							{
								float num13 = 0f;
							}
							return (Report)obj25;
						}
					}
				}
			}
			goto IL_0742;
			IL_0742:
			return (Report)(object)new NullReferenceException();
		}

		public static bool Waiting(string reason)
		{
			//IL_0039: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			if (reason != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
				object value = 0;
				return reason.EndsWith((string)value);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		private void Restart()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			//IL_008d: Expected Obj, but got I4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			//IL_0029: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			outSince = -1f;
			object obj2 = this + 24;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = this + 32;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = this + 40;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = this + 48;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		private static int Mathf0(float secs)
		{
			//IL_0009: Invalid comparison between F4 and I4
			//IL_001a: Expected Obj, but got I4
			//IL_0023: Invalid comparison between F4 and I4
			//IL_0048: Expected Obj, but got I4
			//IL_0074: Expected I4, but got F4
			bool flag = secs < 0f;
			object obj = !flag;
			bool flag2 = secs == 0f;
			float num = secs + 0.5f;
			object obj2 = !flag2;
			object obj3 = obj & obj2;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				return (int)num;
			}
			return 0;
		}

		public Decider()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected Obj, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
			object obj2 = 0;
			object obj3 = this + 24;
			obj3 = obj;
			outSince = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = this + 32;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			HashSet<System.__Canon> hashSet = default;
			hashSet._002Ector();
			object obj5 = this + 64;
			obj5 = hashSet;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MatchEvaluator _003C_003E9__15_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F78]");
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

		internal string _003CScrub_003Eb__15_0(Match m)
		{
			//IL_0064: Expected Obj, but got I
			if (m != null)
			{
				string value = m.Value;
				if (value != null)
				{
					if (value._stringLength > 7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4208]");
						return (string)0;
					}
					return m.Value;
				}
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public const string Url = null;

	public static string TestUrl;

	private static string LastSent__BackingField;

	private readonly Decider decider;

	private float nextLook;

	public static string LastSent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
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
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
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

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj5 = 0;
		obj5 = 0;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v8+A0]");
		object obj9 = (nint)0 + (nint)8;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isEditor = Application.isEditor;
		bool flag2 = !isEditor;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Debug.isDebugBuild)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaOfflineReport gillaOfflineReport = Make();
		}
	}

	public static GillaOfflineReport Make()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
		UnityEngine.Object obj5 = default;
		if (obj5 != null)
		{
			return (GillaOfflineReport)obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj7);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F08]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			GillaOfflineReport result = default;
			return result;
		}
		return (GillaOfflineReport)(object)new NullReferenceException();
	}

	private void Update()
	{
		//IL_0015: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I4
		//IL_044a: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I4
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (realtimeSinceStartup < nextLook)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		float num = realtimeSinceStartup + 1f;
		nextLook = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v8+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Decider decider;
		bool inRoom;
		bool skip;
		string step;
		string shown;
		if (GillaTerms.Accepted)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v28+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v32+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v32+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v22+11]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFA0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X20_v6 (UnityEngine.Object)+78]");
				bool flag9 = (string)0 == (string)obj21;
				decider = this.decider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2+8]");
				bool settled = ((NetworkBootstrap)0).Settled;
				bool flag10 = !flag9;
				object obj22 = !flag10;
				inRoom = settled;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2+8]");
					string offlineWhy = ((NetworkBootstrap)0).OfflineWhy;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v28+E4]");
					bool flag11 = (nint)0 == 0;
					object obj25 = !flag11;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2+8]");
					string text = StepNow((NetworkBootstrap)0);
					bool flag12 = decider == null;
					object obj26 = !flag12;
					skip = false;
					step = text;
					shown = offlineWhy;
					inRoom = settled;
					if (obj26 == null)
					{
						throw new NullReferenceException();
					}
					goto IL_01ff;
				}
				goto IL_0458;
			}
		}
		decider = this.decider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2+8]");
		bool settled2 = ((NetworkBootstrap)0).Settled;
		inRoom = settled2;
		goto IL_0458;
		IL_0458:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj27 = 0;
		shown = (string)obj27;
		skip = true;
		step = (string)obj27;
		goto IL_01ff;
		IL_01ff:
		Report report = decider.Step(inRoom, shown, step, skip, realtimeSinceStartup);
		if (report != null)
		{
			IEnumerator routine = ((GillaOfflineReport)(object)report).Send(report);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private static string StepNow(NetworkBootstrap boot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_04b7: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I4
		//IL_0540: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I4
		//IL_0593: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I
		//IL_0503: Expected Obj, but got I4
		//IL_03da: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0429: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7;
		object result;
		if (GillaIntegrity.Cleared)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (NetworkBootstrap.ShiftAuthNeeded)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
				obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v18+A0]");
				object obj10 = 0;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v18+E4]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (ShiftAuth.HasDevKey)
					{
						goto IL_0220;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDFC8]");
					object obj12 = 0;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v22+E4]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj15 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v26+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v26+A0]");
					object obj17 = 0;
					object obj18 = obj17;
					if (obj17 == null)
					{
						goto IL_0461;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v26+10]");
					if ((nint)0 <= (nint)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v26+E4]");
						bool flag7 = (nint)0 == 0;
						object obj19 = !flag7;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3057B98");
						object obj21 = default;
						object obj20 = obj21 & 1;
						bool flag8 = obj20 == null;
						object obj22 = !flag8;
						if (obj22 != null)
						{
							goto IL_0220;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F28]");
					result = 0;
					goto IL_0511;
				}
			}
			if ((object)boot == null)
			{
				goto IL_0461;
			}
			bool rejoining = boot.Rejoining;
			bool flag9 = !rejoining;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F20]");
			result = 0;
			object obj23 = !flag9;
			object obj24 = ~obj23;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F40]");
				result = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F48]");
			result = 0;
		}
		goto IL_0511;
		IL_0220:
		object obj25 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v39+E4]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool hasDevKey = ShiftAuth.HasDevKey;
		bool flag11 = !hasDevKey;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v44+E4]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj31 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v48+E4]");
			bool flag13 = (nint)0 == 0;
			object obj32 = !flag13;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj31 = obj28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v48+A0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v42+10]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F38]");
				result = 0;
				goto IL_0511;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F30]");
		result = 0;
		goto IL_0511;
		IL_0511:
		return (string)result;
		IL_0461:
		return (string)(object)new NullReferenceException();
	}

	private static string DetailNow(Report r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01da: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0532: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_031e: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I4
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
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		if (r == null)
		{
			goto IL_03c0;
		}
		if (~(r.Back ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			return (string)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F30]");
		object obj7 = 0;
		string text = (string)obj7;
		object s;
		if (r.Step == (string)obj7)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v41+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v45+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v45+A0]");
			s = (nint)0 + (nint)40;
			object obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F20]");
			object obj13 = 0;
			string text2 = (string)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE018]");
			bool flag5 = (string)0 == (string)obj13;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			object obj15 = 0;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F40]");
				object obj16 = 0;
				text2 = (string)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE018]");
				bool flag7 = (string)0 == (string)obj16;
				bool flag8 = !flag7;
				obj15 = 0;
				if (flag8)
				{
					goto IL_02c0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v34+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v9+8]");
			if (!((UnityEngine.Object)0 != null))
			{
				goto IL_02c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v9+8]");
			if ((nint)0 == 0)
			{
				goto IL_03c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v9+8]");
			s = (nint)0 + (nint)128;
			text = null;
			object obj12 = 0;
		}
		goto IL_0476;
		IL_0476:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Scrub((string)s);
		IL_03c0:
		return (string)(object)new NullReferenceException();
		IL_02c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F38]");
		object obj23 = 0;
		text = (string)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE018]");
		if ((string)0 == (string)obj23)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj24 = 0;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v22+E4]");
			bool flag11 = (nint)0 == 0;
			object obj26 = !flag11;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj27 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v26+E4]");
			bool flag12 = (nint)0 == 0;
			object obj28 = !flag12;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj27 = obj24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v26+A0]");
			s = (nint)0 + (nint)48;
			object obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			s = 0;
			object obj12 = 0;
		}
		goto IL_0476;
	}

	public static string Scrub(string s)
	{
		//IL_0032: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I
		//IL_027c: Expected I, but got Obj
		//IL_029a: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		string text;
		if (string.IsNullOrEmpty(s))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			text = (string)obj;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F78]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F80]");
			object pattern = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v9+8]");
			MatchEvaluator evaluator = (MatchEvaluator)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2C70]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v9+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			MatchEvaluator matchEvaluator = null;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v13+A0]");
					obj5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F68]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F70]");
				object obj11 = 0;
				MatchEvaluator matchEvaluator2 = default;
				matchEvaluator2._002Ector(obj5, (IntPtr)obj11);
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v12+A0]");
				object obj13 = (nint)0 + (nint)8;
				obj13 = matchEvaluator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				evaluator = matchEvaluator2;
				matchEvaluator = matchEvaluator2;
			}
			object obj14 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text = Regex.Replace(s, (string)pattern, evaluator);
			if (text == null)
			{
				return (string)(object)new NullReferenceException();
			}
			if (text._stringLength >= 81)
			{
				return text.Substring(0, 80);
			}
		}
		return text;
	}

	private IEnumerator Send(Report r)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = r;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	public GillaOfflineReport()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Decider decider = default;
		decider._002Ector();
		object obj2 = this + 32;
		obj2 = decider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaOfflineReport()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2F00]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
