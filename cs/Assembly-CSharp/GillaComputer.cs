using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaComputer : MonoBehaviour
{
	public Renderer screen;

	public ApeColor[] targets;

	public PressKey[] keys;

	public TextAsset titleFont;

	public TextAsset textFont;

	public const int CodePage = default(int);

	public const int ColorPage = default(int);

	public const int SettingsPage = default(int);

	public const int TurnRow = default(int);

	public const int AmountRow = default(int);

	public const int PunchRow = default(int);

	public const int VoiceRow = default(int);

	private const int SettingRows = default(int);

	private static readonly string[] PageNames;

	private const int W = default(int);

	private const int H = default(int);

	private const int MaxCode = default(int);

	private const string SaveKey = null;

	private static readonly int BaseMap;

	private static int page;

	private static readonly int[] rgb;

	private static int channel;

	private static int setting;

	private static string typed;

	private static bool loaded;

	private static Action m_Changed;

	private string shown;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private float nextRefresh;

	private ScreenFont title;

	private ScreenFont text;

	private static readonly Color32[] Silver;

	private static readonly Color32[] Heading;

	private static readonly Color32[] Milk;

	private static readonly Color32[] Orange;

	private static readonly Color32[] Lime;

	private static readonly Color32[] Grey;

	private static readonly Color32[] Dim;

	private static readonly Color32 Shadow;

	private static readonly Color32 Divider;

	private static readonly Color32 Cursor;

	private static readonly Color32 Bar;

	private static readonly Color32[][] Channels;

	public static readonly Bounds Corner;

	private static float nextCornerLook;

	private static int disguise;

	private unsafe bool InCorner
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0155: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_008b: Expected Obj, but got I4
			//IL_012b: Expected I4, but got Obj
			//IL_00f4: Expected VT, but got I
			//IL_0101: Expected Ref, but got VT
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
			if (screen != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((object)screen != null)
				{
					Bounds bounds = screen.bounds;
					object obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+A0]");
					Bounds bounds2 = (Bounds)((nint)0 + (nint)136);
					Vector3 point = default;
					return ((Bounds*)bounds2)->Internal_Contains(ref point);
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	private static bool InRoom
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0252: Expected Obj, but got I4
			//IL_0278: Expected Obj, but got I
			//IL_029a: Expected Obj, but got I4
			//IL_02c5: Expected Obj, but got I
			//IL_02d5: Expected Obj, but got I
			//IL_02f7: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_0228: Expected I4, but got Obj
			//IL_00c9: Expected Obj, but got I4
			//IL_0101: Expected Obj, but got I4
			//IL_0130: Expected Obj, but got I
			//IL_0187: Expected Obj, but got I
			//IL_01b8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
			UnityEngine.Object obj9 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
				if ((nint)0 == 0)
				{
					goto IL_021a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+A4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					object obj12 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v15+E4]");
					bool flag5 = (nint)0 == 0;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
					if ((UnityEngine.Object)0 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
							if (!((NetworkRunner)0).IsRunning)
							{
								goto IL_020c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X19_v3 (UnityEngine.Object)+B0]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+2F8]");
								bool flag6 = (nint)0 == 0;
								return !flag6;
							}
						}
						goto IL_021a;
					}
				}
			}
			goto IL_020c;
			IL_021a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_020c:
			return false;
		}
	}

	public static int SavedCode
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0027: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE20]");
			object key = 0;
			return PlayerPrefs.GetInt((string)key, -1);
		}
	}

	public int Code
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_017a: Expected Obj, but got I4
			//IL_0198: Expected Obj, but got I
			//IL_01a8: Expected Obj, but got I
			//IL_0150: Expected I4, but got Obj
			//IL_0098: Expected Obj, but got I4
			//IL_00ae: Expected Obj, but got I
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
						bool flag2 = (nint)0 < (nint)2;
						object obj6 = !flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
						object obj7 = -2;
						bool flag3 = obj7 == null;
						object obj8 = ~obj6;
						object obj9 = obj8 | flag3;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+20]");
							object obj10 = (nint)0 * (nint)100;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+24]");
							object obj11 = (nint)0 * (nint)10;
							object obj12 = obj10 + obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+28]");
							return obj12 + 0;
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (int)ex2;
		}
	}

	public int Channel
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			return 0;
		}
	}

	public int Setting
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+1C]");
			return 0;
		}
	}

	public int Page
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+C]");
			return 0;
		}
	}

	public string Typed
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
			return (string)0;
		}
	}

	public static int CodeNow
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_017a: Expected Obj, but got I4
			//IL_0198: Expected Obj, but got I
			//IL_01a8: Expected Obj, but got I
			//IL_0150: Expected I4, but got Obj
			//IL_0098: Expected Obj, but got I4
			//IL_00ae: Expected Obj, but got I
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
						bool flag2 = (nint)0 < (nint)2;
						object obj6 = !flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
						object obj7 = -2;
						bool flag3 = obj7 == null;
						object obj8 = ~obj6;
						object obj9 = obj8 | flag3;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+20]");
							object obj10 = (nint)0 * (nint)100;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+24]");
							object obj11 = (nint)0 * (nint)10;
							object obj12 = obj10 + obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+28]");
							return obj12 + 0;
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (int)ex2;
		}
	}

	private static string Build
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_02bd: Expected Obj, but got I4
			//IL_0059: Expected Obj, but got I4
			//IL_0280: Expected Obj, but got I
			//IL_0091: Expected Obj, but got I4
			//IL_014f: Expected Obj, but got I4
			//IL_01d0: Expected Obj, but got I4
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Expected I4, but got Unknown
			//IL_0239: Expected Obj, but got I4
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
			string buildGUID = Application.buildGUID;
			bool flag2 = string.IsNullOrEmpty(buildGUID);
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string buildGUID2 = Application.buildGUID;
				if (buildGUID2 != null)
				{
					string text = buildGUID2.Trim('0');
					if (text != null)
					{
						if (text._stringLength == 0)
						{
							goto IL_0270;
						}
						object obj7 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v16+E4]");
						bool flag5 = (nint)0 == 0;
						object obj8 = !flag5;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string buildGUID3 = Application.buildGUID;
						string buildGUID4 = Application.buildGUID;
						if (buildGUID4 != null && buildGUID3 != null)
						{
							object obj9 = buildGUID4._stringLength - 6;
							bool flag6 = (nint)obj9 < 0;
							int num = buildGUID4._stringLength ^ 6;
							int num2 = buildGUID4._stringLength ^ obj9;
							int num3 = num & num2;
							bool flag7 = num3 < 0;
							bool flag8 = flag6 == flag7;
							object obj10 = !flag8;
							object obj11 = ~obj10;
							int length = ((obj11 != null) ? 6 : buildGUID4._stringLength);
							return buildGUID3.Substring(0, length);
						}
					}
				}
				return (string)(object)new NullReferenceException();
			}
			goto IL_0270;
			IL_0270:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEED8]");
			return (string)0;
		}
	}

	private static event Action Changed
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+30]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_016f: Expected Obj, but got I
			//IL_017f: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I4
			//IL_00f8: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+30]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj5;
					if (obj7 != obj5)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+A0]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj12 != obj6;
				obj6 = obj12;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	private static Color32 G(byte v)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected VT, but got Unknown
		int num = v & 0xFF;
		object obj = num * 65793;
		return (Color32)(obj | 0xFF000000L);
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0634: Expected I, but got Obj
		//IL_0656: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_066c: Expected I, but got Obj
		//IL_068e: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_06ac: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I4
		//IL_0599: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I
		//IL_05c1: Expected I, but got Obj
		//IL_039e: Expected Obj, but got I4
		//IL_05f0: Expected Obj, but got I4
		//IL_074e: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00da: Expected I, but got Obj
		//IL_03fb: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I8
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0458: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0772: Expected Obj, but got I4
		//IL_06ec: Expected Obj, but got I
		//IL_06fc: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_054d: Expected Obj, but got I4
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_050a: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I
		//IL_052d: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I4
		//IL_053e: Expected I4, but got Obj
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_033a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		Action<System.__Canon> action = (Action<System.__Canon>)0;
		nint num = (nint)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2 (Il2CppClass<System.Action`1<System.__Canon>>)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj2 = 0;
		if (Application.isPlaying)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v40+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v21+28]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE20]");
				object key = 0;
				bool flag4 = PlayerPrefs.HasKey((string)key);
				bool flag5 = !flag4;
				nint num2 = unchecked((nint)null);
				if (!flag5)
				{
					int num3 = PlayerPrefs.GetInt((string)key);
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v24+E4]");
					bool flag6 = (nint)0 == 0;
					object obj8 = !flag6;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj7 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v24+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v25+10]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v26+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v26+18]");
						bool flag7 = (nint)0 == 1;
						object obj11 = num3 * 1374389535;
						object obj12 = obj11 >> 32;
						object obj13 = obj11 >> 63;
						object obj14 = obj13 + obj12;
						object obj15 = obj14 * 1717986919;
						object obj16 = obj15 >> 32;
						object obj17 = obj15 >> 63;
						object obj18 = obj17 + obj16;
						object obj19 = obj18 * 10;
						object obj20 = obj14 - obj19;
						if (!flag7)
						{
							object obj21 = num3 * 1717986919;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v26+18]");
							bool flag8 = (nint)0 < (nint)2;
							object obj22 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v26+18]");
							object obj23 = -2;
							bool flag9 = obj23 == null;
							object obj24 = obj21 >> 63;
							object obj25 = obj21 >> 34;
							object obj26 = obj25 + obj24;
							object obj27 = obj26 * 1717986919;
							object obj28 = obj27 >> 63;
							object obj29 = obj27 >> 34;
							object obj30 = obj29 + obj28;
							object obj31 = obj30 * 10;
							object obj32 = obj26 - obj31;
							object obj33 = ~obj22;
							object obj34 = obj33 | flag9;
							if (obj34 == null)
							{
								object obj35 = obj26 * 10;
								object obj36 = num3 - obj35;
								num2 = unchecked((nint)null);
								goto IL_0664;
							}
						}
					}
					goto IL_0617;
				}
			}
		}
		goto IL_0664;
		IL_0664:
		nint num4 = (nint)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v7 (Il2CppClass<System.Action`1<System.__Canon>>)+E4]");
		bool flag10 = (nint)0 == 0;
		object obj37 = !flag10;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			object obj38 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v31+E4]");
			bool flag11 = (nint)0 == 0;
			object obj39 = !flag11;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj38 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v31+A0]");
			object obj40 = 0;
			_ = 1;
		}
		Redraw(force: true);
		PressKey[] array = keys;
		bool flag12 = keys == null;
		bool flag13 = true;
		if (!flag12)
		{
			bool flag14 = array.Length < 1;
			flag13 = true;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE18]");
				object obj43 = 0;
				object obj44 = array.Length & 0xFFFFFFFFL;
				object obj45 = keys + 32;
				object obj47 = default;
				object obj46 = obj47;
				object obj49 = default;
				object obj48 = obj49;
				object obj50 = 0;
				bool flag15 = true;
				Action<System.__Canon> action2 = default;
				while (true)
				{
					bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44);
					object obj51 = !flag16;
					if (obj51 != null)
					{
						break;
					}
					object obj52 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v21+E4]");
					bool flag17 = (nint)0 == 0;
					object obj53 = !flag17;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X28_v3+v277 @ X24_v4*8]");
					bool flag18 = (UnityEngine.Object)0 != null;
					bool flag19 = !flag18;
					obj49 = 0;
					flag13 = false;
					if (!flag19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action2._002Ector((object)this, (IntPtr)obj43);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X28_v3+v277 @ X24_v4*8]");
						((PressKey)0).Pressed += (Action<PressKey>)action2;
						obj46 = 0;
						obj49 = 0;
						flag13 = (byte)(int)action2 != 0;
					}
					obj44 = array.Length;
					obj50++;
					bool flag20 = (nint)obj50 < array.Length;
					obj48 = obj49;
					flag15 = flag13;
					if (flag20)
					{
						continue;
					}
					goto IL_0589;
				}
				goto IL_0617;
			}
		}
		goto IL_0589;
		IL_0589:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE10]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj55);
		object obj56 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v16+E4]");
		bool flag21 = (nint)0 == 0;
		object obj57 = !flag21;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Changed += action3;
		return;
		IL_0617:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnDisable()
	{
		//IL_01cd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I8
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_0118: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_013e: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_0172: Expected I, but got Obj
		PressKey[] array = keys;
		if (keys != null && array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE18]");
			object obj3 = 0;
			object obj4 = array.Length & 0xFFFFFFFFL;
			object obj5 = keys + 32;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			nint num = default;
			IntPtr intPtr = num;
			object obj10 = 0;
			Action<System.__Canon> action = default;
			bool flag5;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj11 = !flag;
				if (obj11 == null)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v13+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X27_v3+v146 @ X23_v4*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					obj9 = 0;
					num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action._002Ector((object)this, (IntPtr)obj3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X27_v3+v146 @ X23_v4*8]");
						((PressKey)0).Pressed -= (Action<PressKey>)action;
						obj6 = 0;
						obj9 = 0;
						num = (nint)action;
					}
					obj4 = array.Length;
					obj10++;
					flag5 = (nint)obj10 < array.Length;
					obj8 = obj9;
					intPtr = num;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE10]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(this, (IntPtr)obj15);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Changed -= action2;
	}

	private void OnChanged()
	{
		Redraw(force: false);
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj5 = (nint)0 + (nint)32;
		obj5 = obj3;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE20]");
			object key = 0;
			if (PlayerPrefs.HasKey((string)key))
			{
				Paint();
			}
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			LookAtCorner();
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			float time = Time.time;
			if (!(time < nextRefresh))
			{
				float time2 = Time.time;
				float num = time2 + 1f;
				nextRefresh = num;
				Redraw(force: false);
			}
		}
	}

	private unsafe void LookAtCorner()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0433: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
		//IL_0461: Invalid comparison between F4 and I
		//IL_0086: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I
		//IL_04d8: Expected Obj, but got I4
		//IL_0510: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I
		//IL_0633: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I4
		//IL_052e: Expected Obj, but got I
		//IL_0544: Expected VT, but got I
		//IL_0551: Expected Ref, but got VT
		//IL_056f: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_03da: Expected Obj, but got I4
		//IL_058d: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_05cb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		float unscaledTime = Time.unscaledTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+A0]");
		if (unscaledTime < 0f || !InCorner)
		{
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v10+A0]");
		object obj8 = 0;
		float num = unscaledTime2 + 0.5f;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v14+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+8]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		Camera main = Camera.main;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+8]");
		bool flag6 = (UnityEngine.Object)0 == null;
		bool flag7 = !flag6;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			return;
		}
		object obj19 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = main == null;
		bool flag10 = !flag9;
		object obj21 = !flag10;
		if (obj21 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X19_v6 (UnityEngine.Object)+A4]");
		bool flag11 = (nint)0 == 0;
		object obj22 = !flag11;
		if (obj22 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+8]");
		bool rejoining = ((NetworkBootstrap)0).Rejoining;
		bool flag12 = !rejoining;
		object obj23 = !flag12;
		if (obj23 != null)
		{
			return;
		}
		object obj24 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v28+E4]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X19_v6 (UnityEngine.Object)+B0]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X19_v6 (UnityEngine.Object)+B0]");
			bool isRunning = ((NetworkRunner)0).IsRunning;
			bool flag14 = !isRunning;
			object obj26 = !flag14;
			if (obj26 != null)
			{
				return;
			}
		}
		Transform transform = main.transform;
		Vector3 position = transform.position;
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v37+E4]");
		bool flag15 = (nint)0 == 0;
		object obj28 = !flag15;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v37+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v37+A0]");
		Bounds bounds = (Bounds)((nint)0 + (nint)136);
		Vector3 point = default;
		bool flag16 = ((Bounds*)bounds)->Internal_Contains(ref point);
		bool flag17 = !flag16;
		object obj30 = !flag17;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj31 = 0;
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v40+E4]");
			bool flag18 = (nint)0 == 0;
			object obj33 = !flag18;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE68]");
			object message = 0;
			Debug.Log(message);
			float unscaledTime3 = Time.unscaledTime;
			object obj34 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v45+E4]");
			bool flag19 = (nint)0 == 0;
			object obj35 = !flag19;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj34 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object code = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v45+A0]");
			object obj36 = 0;
			float num2 = unscaledTime3 + 10f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v11+8]");
			((NetworkBootstrap)0).JoinRoom((string)code);
		}
	}

	private void OnKey(PressKey key)
	{
		//IL_0027: Expected Obj, but got I
		//IL_0599: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_068f: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I4
		//IL_05df: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I4
		//IL_062d: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I4
		//IL_0707: Expected I4, but got Obj
		//IL_031e: Expected Obj, but got I4
		//IL_0532: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I
		//IL_0427: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I
		//IL_065a: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		//IL_056d: Expected Obj, but got I4
		//IL_044e: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		int code = Code;
		string id = key.id;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE78]");
		object obj = 0;
		bool flag3;
		if (id._stringLength == 1)
		{
			char c = id.get_Chars(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v31+90]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = char.IsDigit(c);
			flag3 = flag2;
		}
		else
		{
			flag3 = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj5 = 0;
		string text = (string)obj;
		object obj9;
		object obj11;
		GillaComputer gillaComputer;
		if (id == (string)obj)
		{
			gillaComputer = (GillaComputer)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				gillaComputer = (GillaComputer)obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+A0]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v11+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v11+18]");
			object obj10 = num + 0;
			obj11 = obj10 - 1;
			object obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE70]");
			object obj13 = 0;
			text = (string)obj13;
			bool flag5 = id == (string)obj13;
			gillaComputer = (GillaComputer)obj5;
			object obj12;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					gillaComputer = (GillaComputer)obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v21+C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v21+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+E4]");
					bool flag7 = (nint)0 == 0;
					object obj17 = !flag7;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						gillaComputer = (GillaComputer)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+A0]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v25+C]");
						obj16 = 0;
					}
					if ((nint)obj16 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+E4]");
						bool flag8 = (nint)0 == 0;
						object obj19 = !flag8;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						ColourKey(id, flag3);
						obj12 = 0;
						text = (string)flag3;
						gillaComputer = (GillaComputer)(object)id;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+E4]");
						bool flag9 = (nint)0 == 0;
						object obj20 = !flag9;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						SettingsKey(id, flag3);
						obj12 = 0;
						text = (string)flag3;
						gillaComputer = (GillaComputer)(object)id;
					}
				}
				else
				{
					bool inCorner = InCorner;
					object obj21 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v31+E4]");
					bool flag10 = (nint)0 == 0;
					object obj22 = !flag10;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CodeKey(id, cornered: false);
					obj12 = 0;
					text = null;
					gillaComputer = (GillaComputer)(object)id;
				}
				goto IL_06e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+E4]");
			bool flag11 = (nint)0 == 0;
			object obj23 = !flag11;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				gillaComputer = (GillaComputer)obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v35 (GillaComputer)+A0]");
			object obj7 = 0;
			object obj24 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X9_v9+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+C]");
			obj11 = (nint)0 + (nint)1;
			obj12 = 0;
		}
		object obj25 = obj11 / obj9;
		object obj26 = obj25 * obj9;
		object obj27 = obj11 - obj26;
		goto IL_06e4;
		IL_06e4:
		int code2 = gillaComputer.Code;
		bool flag12 = code2 == code;
		int num2 = (int)text;
		if (!flag12)
		{
			Paint();
			int code3 = Code;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE20]");
			object key2 = 0;
			PlayerPrefs.SetInt((string)key2, code3);
			PlayerPrefs.Save();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v20+E4]");
			bool flag13 = (nint)0 == 0;
			object obj30 = !flag13;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCloud.ProfileChanged();
			object obj12 = 0;
			num2 = code3;
		}
		object obj31 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v12+E4]");
		bool flag14 = (nint)0 == 0;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v12+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v9+30]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v9+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+40]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+28]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+18]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v141 @ X2_v6 (should have been resolved before IL gen)");
		}
	}

	private static void CodeKey(string id, bool cornered)
	{
		//IL_0010: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_07aa: Expected Obj, but got I
		//IL_07ba: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I4
		//IL_07da: Expected Obj, but got I
		//IL_07ea: Expected Obj, but got I
		//IL_0607: Expected Obj, but got I
		//IL_0617: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I4
		//IL_059b: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_08ef: Expected Obj, but got I
		//IL_090d: Expected Obj, but got I
		//IL_04ea: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I4
		//IL_06aa: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I4
		//IL_07ff: Expected Obj, but got I
		//IL_0829: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I
		//IL_093a: Expected Obj, but got I
		//IL_08d1: Expected Obj, but got I4
		//IL_096e: Expected Obj, but got I
		//IL_097e: Expected Obj, but got I
		//IL_09a8: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0a0e: Expected Obj, but got I
		//IL_032a: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I
		//IL_0383: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I
		//IL_0757: Expected Obj, but got I
		//IL_0899: Expected Obj, but got I4
		//IL_09ce: Expected Obj, but got I
		//IL_09f0: Expected Obj, but got I4
		//IL_03e3: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA9F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj2 = 0;
		string text2;
		if (id == (string)obj)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v96+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v96+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v64+20]");
			string text = (string)0;
			if (text._stringLength >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v96+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v67+A0]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v68+20]");
					text = (string)0;
				}
				int length = text._stringLength - 1;
				text2 = text.Substring(0, length);
				goto IL_011b;
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE80]");
		object obj9 = 0;
		string text3 = (string)obj9;
		if (id == (string)obj9)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v52+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v52+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v33+20]");
			string text4 = (string)0;
			if (text4._stringLength >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v52+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj14 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v57+A0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v58+20]");
					text4 = (string)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F80]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v86+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaBotReport.LobbyCodeTyped(text4);
				text3 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v54+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v58+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj19;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v58+A0]");
			object obj25 = 0;
			object obj26 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v42+E4]");
			bool flag8 = (nint)0 == 0;
			object obj27 = !flag8;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v8+8]");
			bool flag9 = (UnityEngine.Object)0 != null;
			bool flag10 = !flag9;
			int length = 0;
			UnityEngine.Object obj28 = null;
			if (!flag10)
			{
				object obj29 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v62+E4]");
				bool flag11 = (nint)0 == 0;
				object obj30 = !flag11;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj31 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v66+E4]");
				bool flag12 = (nint)0 == 0;
				object obj32 = !flag12;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj31 = obj19;
				}
				object obj33 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v66+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v47+E4]");
				bool flag13 = (nint)0 == 0;
				object obj35 = !flag13;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v48+A0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X9_v9+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v49+20]");
				((NetworkBootstrap)num).JoinRoom((string)0);
				length = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v49+20]");
				obj28 = (UnityEngine.Object)0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE88]");
			object obj38 = 0;
			int length;
			if (!(id == (string)obj38))
			{
				if (id._stringLength == 1)
				{
					char c = id.get_Chars(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v16+90]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+E4]");
					bool flag14 = (nint)0 == 0;
					object obj41 = !flag14;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (char.IsLetterOrDigit(c))
					{
						object obj42 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+E4]");
						bool flag15 = (nint)0 == 0;
						object obj43 = !flag15;
						if (obj43 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj42 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+A0]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v19+20]");
						string text5 = (string)0;
						if (text5._stringLength > 7)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+E4]");
						bool flag16 = (nint)0 == 0;
						object obj45 = !flag16;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj46 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v22+A0]");
							object obj47 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v23+20]");
							text5 = (string)0;
						}
						text2 = text5 + id;
						length = 0;
						goto IL_011b;
					}
					return;
				}
				return;
			}
			object obj48 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v36+E4]");
			bool flag17 = (nint)0 == 0;
			object obj49 = !flag17;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool inRoom = InRoom;
			bool flag18 = !inRoom;
			length = 0;
			UnityEngine.Object obj28 = (UnityEngine.Object)obj38;
			if (!flag18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
				object obj50 = 0;
				object obj51 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v38+E4]");
				bool flag19 = (nint)0 == 0;
				object obj52 = !flag19;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj53 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v42+E4]");
				bool flag20 = (nint)0 == 0;
				object obj54 = !flag20;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj53 = obj50;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v42+A0]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v30+8]");
				((NetworkBootstrap)0).Disconnect();
				length = 0;
				obj28 = null;
			}
		}
		object obj56 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v13+E4]");
		bool flag21 = (nint)0 == 0;
		object obj57 = !flag21;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj56 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj58 = 0;
		string text6 = (string)obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v13+A0]");
		object obj59 = (nint)0 + (nint)32;
		obj59 = obj58;
		goto IL_07bf;
		IL_011b:
		object obj60 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v60+A0]");
		object obj61 = (nint)0 + (nint)32;
		obj61 = text2;
		text6 = text2;
		obj59 = obj61;
		goto IL_07bf;
		IL_07bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private static void ColourKey(string id, bool digit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05bc: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_0633: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_0651: Expected Obj, but got I
		//IL_0667: Expected Obj, but got I
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_06cd: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I
		//IL_072c: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I4
		//IL_03d3: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj2 = 0;
		if (id == (string)obj)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v48+A0]");
			object obj5 = 0;
			_ = 0;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEA8]");
		object obj6 = 0;
		if (id == (string)obj6)
		{
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v44+A0]");
			object obj9 = 0;
			object obj10 = 1;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE98]");
		object obj11 = 0;
		if (id == (string)obj11)
		{
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v40+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v40+A0]");
			object obj9 = 0;
			object obj10 = 2;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE80]");
		object obj14 = 0;
		if (id == (string)obj14)
		{
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v36+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v36+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v6+18]");
			object obj17 = (nint)0 + (nint)1;
			object obj18 = obj17 * 1431655766;
			object obj19 = obj18 >> 63;
			object obj20 = obj18 >> 32;
			object obj21 = obj20 + obj19;
			object obj22 = obj21 + obj21;
			object obj10 = obj17 - obj22;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE90]");
		object obj23 = 0;
		if (id == (string)obj23)
		{
			object obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj25 = !flag5;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v32+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X9_v12+10]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X9_v12+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X9_v12+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v27+18]");
				bool flag6 = num < 0;
				object obj28 = !flag6;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X9_v12+10]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X9_v12+18]");
					object obj29 = num2 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v13+20]");
					object obj30 = -1;
					object obj31 = ~obj30;
					object obj32 = obj30 & obj31;
					return;
				}
				goto IL_05a5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEA0]");
			object obj33 = 0;
			if (id == (string)obj33)
			{
				object obj34 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v28+E4]");
				bool flag7 = (nint)0 == 0;
				object obj35 = !flag7;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj34 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v28+A0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X9_v7+10]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X9_v7+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X9_v7+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v24+18]");
					bool flag8 = num3 < 0;
					object obj38 = !flag8;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X9_v7+10]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X9_v7+18]");
						object obj29 = num4 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v13+20]");
						object obj39 = (nint)0 + (nint)1;
						object obj32;
						if ((nint)obj39 >= 9)
						{
							obj32 = 9;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v13+20]");
						obj32 = (nint)0 + (nint)1;
						return;
					}
					goto IL_05a5;
				}
			}
			else
			{
				if (!digit)
				{
					return;
				}
				object obj40 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v22+E4]");
				bool flag9 = (nint)0 == 0;
				object obj41 = !flag9;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj40 = obj2;
				}
				if (id != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v22+A0]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v19+10]");
					object obj43 = 0;
					char c = id.get_Chars(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v19+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v19+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v6+18]");
						bool flag10 = num5 < 0;
						object obj44 = !flag10;
						if (obj44 == null)
						{
							int num6 = c & 0xFFFF;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v19+10]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v19+18]");
							object obj45 = num7 + 0;
							object obj46 = num6 - 48;
							return;
						}
						goto IL_05a5;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_05a5;
		IL_05a5:
		throw new IndexOutOfRangeException();
	}

	private static void SettingsKey(string id, bool digit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0765: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_0804: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I8
		//IL_07a3: Expected Obj, but got I
		//IL_07d0: Expected Obj, but got I
		//IL_085d: Expected Obj, but got I
		//IL_04e7: Expected Obj, but got I
		//IL_0511: Expected Obj, but got I4
		//IL_0542: Expected Obj, but got I4
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected I4, but got Unknown
		//IL_03ef: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_04ab: Expected I4, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected I4, but got Unknown
		//IL_0589: Expected Obj, but got I4
		//IL_0690: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0628: Expected Obj, but got I4
		//IL_0835: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I4
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj2 = 0;
		if (id == (string)obj)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v66+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v66+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v38+1C]");
			int num = NextSetting(0);
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v39+A0]");
			object obj7 = 0;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE90]");
		object obj8 = 0;
		string text = (string)obj8;
		object obj10;
		if (id == (string)obj8)
		{
			object obj9 = 0;
			obj10 = 4294967295L;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEA0]");
			object obj11 = 0;
			text = (string)obj11;
			bool flag2 = id == (string)obj11;
			object obj9 = 0;
			obj10 = flag2;
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v9+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+1C]");
		if ((nint)0 <= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+1C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+1C]");
				if ((nint)0 != 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
				object obj15 = 0;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v28+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int mode = GillaTurn.Mode;
				bool flag5 = mode == 0;
				object obj18 = !flag5;
				if (obj18 == null && obj10 != null)
				{
					object obj19 = obj15;
					bool flag6 = (nint)obj10 < 0;
					bool flag7 = obj10 == null;
					object obj20 = obj10 ^ obj10;
					object obj21 = obj10 & obj20;
					bool flag8 = (nint)obj21 < 0;
					bool flag9 = flag6 == flag8;
					object obj22 = !flag7;
					object obj23 = flag9 & obj22;
					object obj24 = ~obj23;
					int snapAngle = ((obj24 != null) ? 45 : 90);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v56+E4]");
					bool flag10 = (nint)0 == 0;
					object obj25 = !flag10;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaTurn.SnapAngle = snapAngle;
					return;
				}
				object obj26 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v32+E4]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int mode2 = GillaTurn.Mode;
				int smoothSpeed;
				if (mode2 == 1 && digit)
				{
					char c = id.get_Chars(0);
					object obj28 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v32+E4]");
					bool flag12 = (nint)0 == 0;
					object obj29 = !flag12;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num2 = c & 0xFFFF;
					smoothSpeed = num2 - 48;
				}
				else
				{
					object obj30 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v37+E4]");
					bool flag13 = (nint)0 == 0;
					object obj31 = !flag13;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int mode3 = GillaTurn.Mode;
					if (mode3 != 1 || obj10 == null)
					{
						return;
					}
					object obj32 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v41+E4]");
					bool flag14 = (nint)0 == 0;
					object obj33 = !flag14;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int smoothSpeed2 = GillaTurn.SmoothSpeed;
					smoothSpeed = smoothSpeed2 + obj10;
				}
				GillaTurn.SmoothSpeed = smoothSpeed;
			}
			else if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
				object obj34 = 0;
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v22+E4]");
				bool flag15 = (nint)0 == 0;
				object obj36 = !flag15;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int mode4 = GillaTurn.Mode;
				object obj37 = obj10 + mode4;
				object obj38 = obj37 + 3;
				object obj39 = obj38 * 1431655766;
				object obj40 = obj39 >> 63;
				object obj41 = obj39 >> 32;
				object obj42 = obj41 + obj40;
				object obj43 = obj42 + obj42;
				int mode5 = obj38 - obj43;
				GillaTurn.Mode = mode5;
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+1C]");
		if ((nint)0 != 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v8+1C]");
			if ((nint)0 == 3 && obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
				object obj44 = 0;
				object obj45 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v16+E4]");
				bool flag16 = (nint)0 == 0;
				object obj46 = !flag16;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int percent = GillaVoiceVolume.Percent;
				object obj47 = obj10 * 10;
				int percent2 = percent + obj47;
				GillaVoiceVolume.Percent = percent2;
			}
		}
		else if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F10]");
			object obj48 = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v10+E4]");
			bool flag17 = (nint)0 == 0;
			object obj50 = !flag17;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag18 = GillaPlayerPunching.On;
			object obj51 = !flag18;
			bool flag19 = (byte)(1 & obj51) != 0;
			GillaPlayerPunching.On = flag19;
		}
	}

	private static int NextSetting(int from)
	{
		//IL_00d0: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected I4, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0016: Unsupported input type for neg.
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_0030: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		object obj = from + 1;
		object obj2 = 0 - obj;
		int num = obj & 3;
		object obj3 = obj2 & 3;
		int num2 = ((0 >= (nint)obj) ? (0 - obj3) : num);
		if (num2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int mode = GillaTurn.Mode;
			num2 = ((mode != 2) ? 1 : (1 + 1));
		}
		return num2;
	}

	public static void Adopt(int code)
	{
		//IL_0414: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I4
		//IL_043c: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I4
		//IL_0495: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I
		//IL_03ca: Expected Obj, but got I
		//IL_03da: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		bool flag = code < 999;
		object obj = !flag;
		object obj2 = code - 999;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v4+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v5+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v2+18]");
		if ((nint)0 != 0)
		{
			int num = code >> 2;
			int num2 = num & 0x3FFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v2+18]");
			bool flag4 = (nint)0 == 1;
			object obj10 = num2 * 5243;
			object obj11 = obj10 >> 17;
			if (!flag4)
			{
				int num3 = code & 0xFFFF;
				object obj12 = num3 * 52429;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v2+18]");
				bool flag5 = (nint)0 < (nint)2;
				object obj13 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v2+18]");
				object obj14 = -2;
				bool flag6 = obj14 == null;
				object obj15 = obj12 >> 19;
				object obj16 = obj15 & 0xFF;
				object obj17 = obj12 >> 19;
				object obj18 = obj16 * 205;
				object obj19 = obj18 >> 11;
				object obj20 = obj19 * 10;
				object obj21 = obj17 - obj20;
				object obj22 = obj21 & 0xFF;
				object obj23 = ~obj13;
				object obj24 = obj23 | flag6;
				if (obj24 == null)
				{
					object obj25 = obj17 * 10;
					object obj26 = code - obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE20]");
					object key = 0;
					_ = 1;
					object obj27 = obj26 & 0xFFFF;
					PlayerPrefs.SetInt((string)key, code);
					PlayerPrefs.Save();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v11+E4]");
					bool flag7 = (nint)0 == 0;
					object obj30 = !flag7;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEB0]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD798");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v14+18]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v14+18]");
					if ((nint)0 < (nint)1)
					{
						goto IL_035b;
					}
					object obj34 = default;
					object obj33 = obj34 + 32;
					object obj35 = 0;
					while (true)
					{
						bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
						object obj36 = !flag8;
						if (obj36 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X22_v7+v182 @ X21_v8*8]");
						((GillaComputer)0).Paint();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v14+18]");
						obj32 = 0;
						obj35++;
						object obj37 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v14+18]");
						if ((nint)obj37 < 0)
						{
							continue;
						}
						goto IL_035b;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_035b:
		object obj38 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v17+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v16+30]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v16+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v17+40]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v17+28]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v17+18]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v132 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	public void Refresh()
	{
		Redraw(force: true);
	}

	private void Paint()
	{
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I8
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		//IL_0454: Expected Obj, but got I4
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I8
		//IL_0513: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected I4, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d9: Expected I4, but got Obj
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f4: Expected I4, but got Obj
		//IL_053e: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		ApeColor[] array = targets;
		if (targets == null || array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj2 = 0;
		object obj3 = array.Length & 0xFFFFFFFFL;
		object obj4 = targets + 32;
		object obj5 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X23_v3+v180 @ X21_v4*8]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			int num = 0;
			nint num2 = unchecked((nint)null);
			if (obj9 == null)
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v14+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v15+A4]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v15+A4]");
				object obj14 = 0 & 0x80000000L;
				bool flag6 = obj14 == null;
				object obj15 = !flag6;
				int b;
				int num3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v14+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj17 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v19+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v20+A4]");
					object obj19 = (nint)0 * (nint)1374389535;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v20+A4]");
					object obj20 = (nint)0 * (nint)1717986919;
					object obj21 = obj20 >> 63;
					object obj22 = obj20 >> 34;
					object obj23 = obj19 >> 63;
					object obj24 = obj19 >> 37;
					obj13 = obj22 + obj21;
					object obj25 = obj24 + obj23;
					object obj26 = obj13 * 1717986919;
					object obj27 = obj25 * 1717986919;
					object obj28 = obj13 * 10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v20+A4]");
					b = 0 - obj28;
					object obj29 = obj26 >> 63;
					object obj30 = obj26 >> 34;
					object obj31 = obj27 >> 63;
					object obj32 = obj27 >> 34;
					object obj33 = obj30 + obj29;
					object obj34 = obj32 + obj31;
					object obj35 = obj33 * 10;
					num = obj13 - obj35;
					object obj36 = obj34 * 10;
					num3 = obj25 - obj36;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v14+E4]");
					bool flag8 = (nint)0 == 0;
					object obj37 = !flag8;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj38 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v17+A0]");
						obj12 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v15+10]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+18]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+18]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+18]");
					if ((nint)0 == 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+18]");
					bool flag9 = (nint)0 < (nint)2;
					object obj40 = !flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+18]");
					object obj41 = -2;
					bool flag10 = obj41 == null;
					object obj42 = ~obj40;
					object obj43 = obj42 | flag10;
					if (obj43 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+20]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+24]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v16+28]");
					b = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X23_v3+v180 @ X21_v4*8]");
				((ApeColor)0).SetColorCode(num3, num, b);
				num2 = num3;
			}
			obj3 = array.Length;
			obj5++;
			if ((nint)obj5 >= array.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public static void Disguise(int code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		object obj2 = obj;
		bool flag = code < 1000;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			int num = code;
		}
		else
		{
			int num = -1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEB0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD798");
		object obj12 = default;
		if (obj12 == null)
		{
			goto IL_0147;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj14 = obj12 + 32;
		object obj15 = 0;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
			object obj16 = !flag4;
			if (obj16 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X21_v8+v120 @ X20_v10*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X21_v8+v120 @ X20_v10*8]");
				((GillaComputer)0).Paint();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
				obj13 = 0;
				obj15++;
				object obj17 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+18]");
				if ((nint)obj17 >= 0)
				{
					return;
				}
				continue;
			}
			goto IL_0147;
		}
		goto IL_0155;
		IL_0155:
		throw new IndexOutOfRangeException();
		IL_0147:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0155;
	}

	private static void ForgetDisguise()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
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
		_ = 4294967295L;
	}

	private unsafe void Redraw(bool force)
	{
		//IL_0010: Expected Obj, but got I
		//IL_2c98: Expected Obj, but got I4
		//IL_2cbe: Expected Obj, but got I
		//IL_2ce0: Expected Obj, but got I4
		//IL_348b: Expected I, but got Obj
		//IL_349b: Expected Obj, but got I
		//IL_34ab: Expected Obj, but got I
		//IL_34bb: Expected Obj, but got I
		//IL_34dd: Expected Obj, but got I4
		//IL_2cfe: Expected Obj, but got I
		//IL_2d28: Expected Obj, but got I4
		//IL_0113: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I
		//IL_2d3e: Expected I, but got Obj
		//IL_2d60: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I
		//IL_34f3: Expected I, but got Obj
		//IL_3515: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_2d94: Expected Obj, but got I
		//IL_2df2: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I
		//IL_2d7f: Expected Obj, but got I
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0452: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_04ac: Expected Obj, but got I4
		//IL_2e3f: Expected Obj, but got I4
		//IL_2e4f: Expected Obj, but got I4
		//IL_2e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e74: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_0599: Expected Obj, but got I
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05b7: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I4
		//IL_05f9: Expected Obj, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected I4, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_0671: Expected Obj, but got I
		//IL_0711: Expected Obj, but got I4
		//IL_0721: Expected Obj, but got I4
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected I4, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected Obj, but got Unknown
		//IL_0791: Expected Obj, but got I
		//IL_0831: Expected Obj, but got I8
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_087e: Expected Obj, but got I
		//IL_088e: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I4
		//IL_0923: Expected Obj, but got I4
		//IL_0939: Expected Obj, but got I
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected Obj, but got Unknown
		//IL_09ab: Expected Obj, but got I4
		//IL_09bb: Expected Obj, but got I4
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected Obj, but got Unknown
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected Obj, but got Unknown
		//IL_0a60: Expected Obj, but got I4
		//IL_0a76: Expected Obj, but got I
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected Obj, but got Unknown
		//IL_0aeb: Expected Obj, but got I4
		//IL_0b01: Expected Obj, but got I
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected Obj, but got Unknown
		//IL_0b44: Expected Obj, but got I
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected Obj, but got Unknown
		//IL_0b8e: Expected Obj, but got I4
		//IL_0bd0: Expected Obj, but got I4
		//IL_0be0: Expected Obj, but got I4
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Expected Obj, but got Unknown
		//IL_0c23: Expected Obj, but got I
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected Obj, but got Unknown
		//IL_0c6d: Expected Obj, but got I4
		//IL_0ca3: Expected Obj, but got I
		//IL_0cb3: Expected Obj, but got I
		//IL_0cd5: Expected Obj, but got I4
		//IL_0d1b: Expected Obj, but got I4
		//IL_0d2b: Expected Obj, but got I4
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected Obj, but got Unknown
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6c: Expected Obj, but got Unknown
		//IL_0dd0: Expected Obj, but got I4
		//IL_0de6: Expected Obj, but got I
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Expected Obj, but got Unknown
		//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Expected Obj, but got Unknown
		//IL_0e5b: Expected Obj, but got I4
		//IL_0e71: Expected Obj, but got I
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e96: Expected Obj, but got Unknown
		//IL_0eb4: Expected Obj, but got I
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected Obj, but got Unknown
		//IL_0efe: Expected Obj, but got I4
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected Obj, but got Unknown
		//IL_0f78: Expected Obj, but got I4
		//IL_0f8e: Expected Obj, but got I
		//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb3: Expected Obj, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected Obj, but got Unknown
		//IL_1015: Expected Obj, but got I4
		//IL_102b: Expected Obj, but got I
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected Obj, but got Unknown
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected Obj, but got Unknown
		//IL_10a0: Expected Obj, but got I4
		//IL_10b6: Expected Obj, but got I
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Expected Obj, but got Unknown
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected Obj, but got Unknown
		//IL_113d: Expected Obj, but got I4
		//IL_1153: Expected Obj, but got I
		//IL_1173: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected Obj, but got Unknown
		//IL_118f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Expected Obj, but got Unknown
		//IL_11d0: Expected Obj, but got I4
		//IL_1212: Expected Obj, but got I4
		//IL_1222: Expected Obj, but got I4
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Expected Obj, but got Unknown
		//IL_125e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Expected Obj, but got Unknown
		//IL_1297: Expected Obj, but got I4
		//IL_12ad: Expected Obj, but got I
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d2: Expected Obj, but got Unknown
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Expected Obj, but got Unknown
		//IL_1322: Expected Obj, but got I4
		//IL_1338: Expected Obj, but got I
		//IL_1358: Unknown result type (might be due to invalid IL or missing references)
		//IL_135d: Expected Obj, but got Unknown
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Expected Obj, but got Unknown
		//IL_13ad: Expected Obj, but got I4
		//IL_13c3: Expected Obj, but got I
		//IL_13e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ed: Expected I4, but got Unknown
		//IL_1404: Unknown result type (might be due to invalid IL or missing references)
		//IL_1409: Expected Obj, but got Unknown
		//IL_1423: Expected I, but got Obj
		//IL_1445: Expected Obj, but got I4
		//IL_1504: Expected Obj, but got I
		//IL_2e9e: Expected Obj, but got I4
		//IL_2eae: Expected Obj, but got I4
		//IL_2ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed8: Expected I4, but got Unknown
		//IL_1512: Unknown result type (might be due to invalid IL or missing references)
		//IL_1517: Expected Obj, but got Unknown
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Expected Obj, but got Unknown
		//IL_1555: Expected Obj, but got I4
		//IL_1633: Unknown result type (might be due to invalid IL or missing references)
		//IL_1638: Expected Obj, but got Unknown
		//IL_1652: Expected I, but got Obj
		//IL_1658: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Expected Obj, but got Unknown
		//IL_167f: Expected Obj, but got I4
		//IL_16ac: Expected Obj, but got I
		//IL_16f5: Expected Obj, but got I
		//IL_15ad: Expected I, but got Obj
		//IL_15cf: Expected Obj, but got I4
		//IL_18b8: Expected Obj, but got I
		//IL_18c1: Expected Obj, but got I4
		//IL_1752: Expected VT, but got I4
		//IL_1786: Expected Obj, but got I4
		//IL_1616: Expected Obj, but got I4
		//IL_2f01: Expected Obj, but got I4
		//IL_2f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f10: Expected Obj, but got Unknown
		//IL_2f6d: Expected Obj, but got I8
		//IL_19ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bf: Expected Obj, but got Unknown
		//IL_19d9: Expected Obj, but got I4
		//IL_1a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a67: Expected Obj, but got Unknown
		//IL_1a81: Expected Obj, but got I4
		//IL_18e1: Expected Obj, but got I4
		//IL_18eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f0: Expected Obj, but got Unknown
		//IL_1b3e: Expected Obj, but got I4
		//IL_1a11: Expected Obj, but got I4
		//IL_17f9: Expected Obj, but got I
		//IL_2f93: Expected Obj, but got I
		//IL_2fa1: Expected Obj, but got Ref
		//IL_2fcc: Expected VT, but got Ref
		//IL_2fe6: Expected Obj, but got Ref
		//IL_2ff6: Expected Obj, but got I
		//IL_1acb: Expected Obj, but got I4
		//IL_1928: Unknown result type (might be due to invalid IL or missing references)
		//IL_192d: Expected Obj, but got Unknown
		//IL_195d: Expected Obj, but got I4
		//IL_198b: Expected Obj, but got I8
		//IL_180e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1813: Expected Obj, but got Unknown
		//IL_182e: Expected VT, but got I4
		//IL_1b6c: Expected Obj, but got I4
		//IL_1b7c: Expected Obj, but got I
		//IL_1b8e: Expected Obj, but got I4
		//IL_1b97: Expected Obj, but got I4
		//IL_1b9f: Expected VT, but got Ref
		//IL_1ba7: Expected I4, but got Obj
		//IL_1bb9: Expected Obj, but got I4
		//IL_1be3: Expected Obj, but got I
		//IL_31f7: Expected Obj, but got I4
		//IL_3015: Expected Obj, but got I
		//IL_303c: Expected Obj, but got Ref
		//IL_1c20: Expected Obj, but got I4
		//IL_1c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c35: Expected Obj, but got Unknown
		//IL_1ea8: Expected Obj, but got I4
		//IL_322b: Expected VT, but got I
		//IL_3241: Expected Obj, but got Ref
		//IL_3251: Expected Obj, but got I
		//IL_3273: Expected Obj, but got I
		//IL_3283: Expected Obj, but got I
		//IL_1c92: Expected Obj, but got I4
		//IL_1f8e: Expected Obj, but got I
		//IL_1ed8: Expected Obj, but got I
		//IL_306b: Expected Obj, but got I4
		//IL_307b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3080: Expected Obj, but got Unknown
		//IL_1fcf: Expected Obj, but got I
		//IL_200a: Expected Obj, but got I4
		//IL_1eff: Expected Obj, but got I4
		//IL_354d: Expected Obj, but got I4
		//IL_1cc2: Expected Obj, but got I
		//IL_3314: Expected Obj, but got I
		//IL_3322: Expected Obj, but got Ref
		//IL_334d: Expected VT, but got Ref
		//IL_3361: Expected Obj, but got I
		//IL_338b: Expected Obj, but got I4
		//IL_32c2: Expected Obj, but got I4
		//IL_32cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d0: Expected Obj, but got Unknown
		//IL_30cb: Expected Obj, but got I
		//IL_30f2: Expected Obj, but got Ref
		//IL_1ce9: Expected VT, but got Ref
		//IL_1d0d: Expected Obj, but got I
		//IL_1d26: Expected VT, but got Ref
		//IL_1d2e: Expected I4, but got Obj
		//IL_205c: Expected Obj, but got I
		//IL_1f9d: Expected VT, but got Ref
		//IL_1faa: Expected Obj, but got I8
		//IL_1fba: Expected Obj, but got I
		//IL_1f2f: Expected Obj, but got I
		//IL_1f3f: Expected Obj, but got I
		//IL_21a7: Expected Obj, but got I
		//IL_1f4e: Expected VT, but got Ref
		//IL_1f5b: Expected Obj, but got I8
		//IL_1f6b: Expected Obj, but got I
		//IL_1d86: Expected Obj, but got I4
		//IL_33e0: Expected Obj, but got I4
		//IL_2099: Expected Obj, but got I4
		//IL_20b2: Expected Obj, but got I
		//IL_20c4: Expected Obj, but got I4
		//IL_20cc: Expected VT, but got Ref
		//IL_20d4: Expected I4, but got Obj
		//IL_20e5: Expected Obj, but got Ref
		//IL_340d: Expected Obj, but got I
		//IL_1db1: Expected Obj, but got I
		//IL_1dd2: Expected Obj, but got I4
		//IL_1de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de7: Expected Obj, but got Unknown
		//IL_3475: Expected Obj, but got I4
		//IL_2111: Expected Obj, but got I
		//IL_2133: Expected Obj, but got I4
		//IL_1e51: Expected Obj, but got I4
		//IL_356b: Expected Obj, but got I
		//IL_3579: Expected Obj, but got Ref
		//IL_35a4: Expected VT, but got Ref
		//IL_21db: Expected Obj, but got I4
		//IL_21f4: Expected Obj, but got I
		//IL_2206: Expected Obj, but got I4
		//IL_220e: Expected VT, but got Ref
		//IL_2216: Expected I4, but got Obj
		//IL_2227: Expected Obj, but got Ref
		//IL_222f: Expected I4, but got Obj
		//IL_31ad: Expected Obj, but got Ref
		//IL_31c0: Expected Obj, but got I4
		//IL_31c8: Expected Obj, but got Ref
		//IL_1e2a: Expected Obj, but got Ref
		//IL_2479: Expected Obj, but got I
		//IL_24a0: Expected Obj, but got Ref
		//IL_24b0: Expected Obj, but got I
		//IL_3118: Expected Obj, but got I
		//IL_3138: Expected VT, but got Ref
		//IL_3145: Unknown result type (might be due to invalid IL or missing references)
		//IL_314a: Expected Obj, but got Unknown
		//IL_3171: Expected VT, but got Ref
		//IL_3179: Expected I4, but got Obj
		//IL_1e81: Expected Obj, but got I
		//IL_24e2: Expected VT, but got Ref
		//IL_226c: Expected Obj, but got I4
		//IL_227f: Expected Obj, but got I4
		//IL_33f8: Expected Obj, but got I4
		//IL_2508: Expected Obj, but got I
		//IL_252f: Expected Obj, but got Ref
		//IL_253f: Expected Obj, but got I
		//IL_2192: Expected Obj, but got I
		//IL_2571: Expected VT, but got Ref
		//IL_2585: Expected Obj, but got I
		//IL_25af: Expected Obj, but got I4
		//IL_22e6: Expected Obj, but got I
		//IL_2313: Expected Obj, but got I4
		//IL_232c: Expected Obj, but got I
		//IL_233e: Expected Obj, but got I4
		//IL_2346: Expected VT, but got Ref
		//IL_234e: Expected I4, but got Obj
		//IL_235f: Expected Obj, but got Ref
		//IL_2367: Expected I4, but got Obj
		//IL_25eb: Expected Obj, but got Ref
		//IL_25fb: Expected Obj, but got I
		//IL_262d: Expected VT, but got Ref
		//IL_23b5: Expected Obj, but got I4
		//IL_23c3: Expected Obj, but got I4
		//IL_23f9: Expected Obj, but got I4
		//IL_2666: Expected Obj, but got I
		//IL_2676: Expected Obj, but got I
		//IL_26aa: Expected Obj, but got Ref
		//IL_26ba: Expected Obj, but got I
		//IL_26e7: Expected VT, but got Ref
		//IL_270a: Expected Obj, but got I4
		//IL_2713: Expected Obj, but got I4
		//IL_271c: Expected Obj, but got I4
		//IL_2725: Expected Obj, but got I4
		//IL_272e: Expected Obj, but got I4
		//IL_2737: Expected Obj, but got I4
		//IL_2750: Expected Obj, but got I
		//IL_2762: Expected Obj, but got I4
		//IL_276a: Expected VT, but got Ref
		//IL_2772: Expected I4, but got Obj
		//IL_278c: Expected Obj, but got Ref
		//IL_27ce: Expected Obj, but got I
		//IL_27e8: Expected Obj, but got I4
		//IL_27f1: Expected Obj, but got I4
		//IL_27fa: Expected Obj, but got I4
		//IL_2803: Expected Obj, but got I4
		//IL_280c: Expected Obj, but got I4
		//IL_2815: Expected Obj, but got I4
		//IL_282e: Expected Obj, but got I
		//IL_2840: Expected Obj, but got I4
		//IL_2848: Expected VT, but got Ref
		//IL_2850: Expected I4, but got Obj
		//IL_286a: Expected Obj, but got Ref
		//IL_28a3: Expected I, but got Obj
		//IL_28c5: Expected Obj, but got I4
		//IL_290c: Expected Obj, but got I4
		//IL_2920: Unknown result type (might be due to invalid IL or missing references)
		//IL_2925: Expected Obj, but got Unknown
		//IL_293f: Expected Obj, but got I4
		//IL_29b3: Expected Obj, but got I4
		//IL_29bc: Expected Obj, but got I4
		//IL_29c5: Expected Obj, but got I4
		//IL_29ce: Expected Obj, but got I4
		//IL_29d7: Expected Obj, but got I4
		//IL_29e0: Expected Obj, but got I4
		//IL_29f9: Expected Obj, but got I
		//IL_2a0b: Expected Obj, but got I4
		//IL_2a13: Expected VT, but got Ref
		//IL_2a1b: Expected I4, but got Obj
		//IL_2a35: Expected Obj, but got Ref
		//IL_2962: Expected Obj, but got I
		//IL_2a85: Expected Obj, but got I4
		//IL_2aba: Expected Obj, but got I4
		//IL_2ac3: Expected Obj, but got I4
		//IL_2acc: Expected Obj, but got I4
		//IL_2ad5: Expected Obj, but got I4
		//IL_2ade: Expected Obj, but got I4
		//IL_2ae7: Expected Obj, but got I4
		//IL_2b00: Expected Obj, but got I
		//IL_2b12: Expected Obj, but got I4
		//IL_2b1a: Expected VT, but got Ref
		//IL_2b22: Expected I4, but got Obj
		//IL_2b3c: Expected Obj, but got Ref
		//IL_2b73: Expected Obj, but got I
		//IL_2ba8: Expected Obj, but got I4
		//IL_2bb1: Expected Obj, but got I4
		//IL_2bba: Expected Obj, but got I4
		//IL_2bc3: Expected Obj, but got I4
		//IL_2bcc: Expected Obj, but got I4
		//IL_2bd5: Expected Obj, but got I4
		//IL_2bee: Expected Obj, but got I
		//IL_2c00: Expected Obj, but got I4
		//IL_2c08: Expected VT, but got Ref
		//IL_2c10: Expected I4, but got Obj
		//IL_2c2a: Expected Obj, but got Ref
		//IL_2c34: Expected I4, but got Obj
		//IL_2c44: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		nint num = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7 (Il2CppClass<System.String>)+E4]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v1+8]");
		UnityEngine.Object obj8 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7 (Il2CppClass<System.String>)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5;
		bool flag5;
		int num3;
		UnityEngine.Object obj10;
		int num2;
		int num4;
		UnityEngine.Object obj11;
		if (obj8 != null)
		{
			bool flag4 = (object)obj8 == null;
			obj10 = null;
			num2 = 0;
			flag5 = false;
			num3 = 0;
			num4 = 0;
			obj11 = null;
			if (flag4)
			{
				goto IL_19a1;
			}
			num5 = ((NetworkBootstrap)obj8).PlayerCount;
			UnityEngine.Object obj12 = null;
		}
		else
		{
			UnityEngine.Object obj12 = null;
			num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE28]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int total = GillaOnline.Total;
		nint num6 = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v11 (Il2CppClass<System.String>)+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2;
		int num7;
		if (obj8 != null)
		{
			bool flag8 = (object)obj8 == null;
			num7 = num5;
			obj10 = null;
			num2 = 0;
			flag5 = false;
			num3 = total;
			num4 = 0;
			obj11 = null;
			if (flag8)
			{
				goto IL_19a1;
			}
			string kindLabel = ((NetworkBootstrap)obj8).KindLabel;
			text2 = kindLabel;
			UnityEngine.Object obj17 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF60]");
			object obj18 = 0;
			text2 = (string)obj18;
			UnityEngine.Object obj17 = null;
		}
		nint num8 = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v18 (Il2CppClass<System.String>)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj21;
		if (obj8 != null)
		{
			bool flag10 = (object)obj8 == null;
			num7 = num5;
			obj10 = null;
			num2 = 0;
			flag5 = false;
			num3 = total;
			num4 = 0;
			obj11 = null;
			if (flag10)
			{
				goto IL_19a1;
			}
			obj7 = obj8 + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v7 (UnityEngine.Object)+A4]");
			bool flag11 = (nint)0 < (nint)0;
			object obj20 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v7 (UnityEngine.Object)+A4]");
			bool flag12 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v7 (UnityEngine.Object)+A4]");
			if ((nint)0 == 0)
			{
				obj21 = obj7;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
				obj21 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v7 (UnityEngine.Object)+A4]");
			object obj22 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
			obj21 = 0;
		}
		nint num9 = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X0_v22 (Il2CppClass<System.String>)+E4]");
		bool flag13 = (nint)0 == 0;
		object obj23 = !flag13;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text4 = default;
		string text3;
		if (obj8 != null)
		{
			bool flag14 = (object)obj8 == null;
			text3 = (string)obj21;
			num7 = num5;
			obj10 = null;
			num2 = 0;
			flag5 = false;
			num3 = total;
			num4 = 0;
			obj11 = null;
			if (flag14)
			{
				goto IL_19a1;
			}
			string offlineWhy = ((NetworkBootstrap)obj8).OfflineWhy;
			text4 = offlineWhy;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj24 = 0;
			text4 = (string)obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		bool flag15 = array == null;
		text3 = (string)obj21;
		num7 = num5;
		obj10 = null;
		num2 = 0;
		flag5 = false;
		num3 = total;
		num4 = 0;
		obj11 = (UnityEngine.Object)25;
		if (flag15)
		{
			goto IL_19a1;
		}
		object obj26 = array + 32;
		obj26 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
		string text5 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj27 = 0;
		object obj28 = array + 40;
		obj28 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj29 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1630 @ X0_v35+E4]");
		bool flag16 = (nint)0 == 0;
		object obj30 = !flag16;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1630 @ X0_v35+A0]");
		int num10 = (int)((nint)0 + (nint)12);
		string text6 = ((int*)num10)->ToString();
		bool flag17 = array.Length < 2;
		object obj31 = !flag17;
		object obj32 = array.Length - 2;
		bool flag18 = obj32 == null;
		object obj33 = ~obj31;
		object obj34 = obj33 | flag18;
		string text18;
		if (obj34 == null)
		{
			object obj35 = array + 48;
			obj35 = text6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj36 = array + 56;
			obj36 = text5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ X26_v6-20]");
			bool flag19 = (nint)0 < (nint)4;
			object obj37 = !flag19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ X26_v6-20]");
			object obj38 = -4;
			bool flag20 = obj38 == null;
			object obj39 = ~obj37;
			object obj40 = obj39 | flag20;
			if (obj40 == null)
			{
				object obj41 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1684 @ X8_v26+A0]");
				object obj42 = 0;
				ScreenFont screenFont = (ScreenFont)(array + 64);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ X8_v27+20]");
				screenFont = (ScreenFont)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X26_v34 (ScreenFont)-28]");
				bool flag21 = (nint)0 < (nint)5;
				object obj20 = !flag21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X26_v34 (ScreenFont)-28]");
				object obj22 = -5;
				bool flag12 = obj22 == null;
				object obj43 = ~obj20;
				if (((obj43 | flag12) ? 1 : 0) == 0)
				{
					obj11 = (UnityEngine.Object)(object)text5;
					object obj44 = array + 72;
					obj44 = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj45 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1754 @ X8_v29+A0]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ X8_v30+10]");
					bool flag22 = (nint)0 == 0;
					text3 = (string)obj21;
					num7 = num5;
					obj10 = null;
					num2 = 0;
					flag5 = false;
					num3 = total;
					num4 = 0;
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ X8_v30+10]");
						int num11 = (int)((nint)0 + (nint)32);
						string text7 = ((int*)num11)->ToString();
						bool flag23 = array.Length < 6;
						obj20 = !flag23;
						obj22 = array.Length - 6;
						flag12 = obj22 == null;
						object obj47 = ~obj20;
						if (((obj47 | flag12) ? 1 : 0) != 0)
						{
							goto IL_2c67;
						}
						object obj48 = array + 80;
						obj48 = text7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj49 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1801 @ X8_v33+A0]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v34+10]");
						bool flag24 = (nint)0 == 0;
						text3 = (string)obj21;
						num7 = num5;
						obj10 = null;
						num2 = 0;
						flag5 = false;
						num3 = total;
						num4 = 0;
						obj11 = (UnityEngine.Object)(object)text7;
						if (!flag24)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v34+10]");
							int num12 = (int)((nint)0 + (nint)36);
							string text8 = ((int*)num12)->ToString();
							object obj51 = array.Length & 0xFFFFFFF8L;
							flag12 = obj51 == null;
							object obj52 = array + 88;
							obj52 = text8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj53 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1845 @ X8_v37+A0]");
							object obj54 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X8_v38+10]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X8_v38+10]");
							bool flag25 = (nint)0 == 0;
							text3 = (string)obj21;
							num7 = num5;
							obj10 = null;
							num2 = 0;
							flag5 = false;
							obj20 = 0;
							num3 = total;
							num4 = 0;
							obj11 = (UnityEngine.Object)(object)text8;
							if (!flag25)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v39+18]");
								bool flag26 = (nint)0 < (nint)2;
								object obj56 = !flag26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v39+18]");
								object obj57 = -2;
								bool flag27 = obj57 == null;
								object obj58 = ~obj56;
								object obj59 = obj58 | flag27;
								if (obj59 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X8_v38+10]");
									int num13 = (int)((nint)0 + (nint)40);
									string text9 = ((int*)num13)->ToString();
									bool flag28 = array.Length < 8;
									object obj60 = !flag28;
									object obj61 = array.Length - 8;
									bool flag29 = obj61 == null;
									object obj62 = ~obj60;
									object obj63 = obj62 | flag29;
									if (obj63 == null)
									{
										object obj64 = array + 96;
										obj64 = text9;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj65 = obj27;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1893 @ X8_v41+A0]");
										int num14 = (int)((nint)0 + (nint)24);
										string text10 = ((int*)num14)->ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X26_v10-48]");
										bool flag30 = (nint)0 < (nint)9;
										object obj66 = !flag30;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X26_v10-48]");
										object obj67 = -9;
										bool flag31 = obj67 == null;
										object obj68 = ~obj66;
										object obj69 = obj68 | flag31;
										if (obj69 == null)
										{
											object obj70 = array + 104;
											obj70 = text10;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ X26_v12-50]");
											bool flag32 = (nint)0 < (nint)10;
											object obj71 = !flag32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ X26_v12-50]");
											object obj72 = -10;
											bool flag33 = obj72 == null;
											object obj73 = ~obj71;
											object obj74 = obj73 | flag33;
											if (obj74 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
												object obj75 = 0;
												object obj76 = array + 112;
												obj76 = text5;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj77 = obj75;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1916 @ X0_v68+E4]");
												bool flag34 = (nint)0 == 0;
												object obj78 = !flag34;
												if (obj78 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												string text11 = GillaTurn.Describe();
												bool flag35 = array.Length < 11;
												object obj79 = !flag35;
												object obj80 = array.Length - 11;
												bool flag36 = obj80 == null;
												object obj81 = ~obj79;
												object obj82 = obj81 | flag36;
												if (obj82 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F10]");
													object obj83 = 0;
													object obj84 = array + 120;
													obj84 = text11;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													object obj85 = obj83;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ X0_v75+E4]");
													bool flag37 = (nint)0 == 0;
													object obj86 = !flag37;
													if (obj86 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													bool flag38 = GillaPlayerPunching.On;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj87 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1985 @ X9_v10+30]");
													object obj88 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v79+E4]");
													bool flag39 = (nint)0 == 0;
													object obj89 = !flag39;
													if (obj89 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													string text12 = flag5.ToString();
													bool flag40 = array.Length < 12;
													object obj90 = !flag40;
													object obj91 = array.Length - 12;
													bool flag41 = obj91 == null;
													object obj92 = ~obj90;
													object obj93 = obj92 | flag41;
													if (obj93 == null)
													{
														object obj94 = array + 128;
														obj94 = text12;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														object obj95 = obj27;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ X8_v51+A0]");
														int num15 = (int)((nint)0 + (nint)28);
														string text13 = ((int*)num15)->ToString();
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X26_v14-68]");
														bool flag42 = (nint)0 < (nint)13;
														object obj96 = !flag42;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X26_v14-68]");
														object obj97 = -13;
														bool flag43 = obj97 == null;
														object obj98 = ~obj96;
														object obj99 = obj98 | flag43;
														if (obj99 == null)
														{
															object obj100 = array + 136;
															obj100 = text13;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X26_v16-70]");
															bool flag44 = (nint)0 < (nint)14;
															object obj101 = !flag44;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X26_v16-70]");
															object obj102 = -14;
															bool flag45 = obj102 == null;
															object obj103 = ~obj101;
															object obj104 = obj103 | flag45;
															if (obj104 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
																object obj105 = 0;
																object obj106 = array + 144;
																obj106 = text5;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																object obj107 = obj105;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2020 @ X0_v92+E4]");
																bool flag46 = (nint)0 == 0;
																object obj108 = !flag46;
																if (obj108 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																int percent = GillaVoiceVolume.Percent;
																string text14 = num2.ToString();
																object obj109 = array + 152;
																obj109 = text14;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v18-80]");
																bool flag47 = (nint)0 < (nint)16;
																object obj110 = !flag47;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ X26_v18-80]");
																object obj111 = -16;
																bool flag48 = obj111 == null;
																object obj112 = ~obj110;
																object obj113 = obj112 | flag48;
																if (obj113 == null)
																{
																	object obj114 = array + 160;
																	obj114 = text5;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	string text15 = num7.ToString();
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X26_v20-88]");
																	bool flag49 = (nint)0 < (nint)17;
																	object obj115 = !flag49;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X26_v20-88]");
																	object obj116 = -17;
																	bool flag50 = obj116 == null;
																	object obj117 = ~obj115;
																	object obj118 = obj117 | flag50;
																	if (obj118 == null)
																	{
																		object obj119 = array + 168;
																		obj119 = text15;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X26_v22-90]");
																		bool flag51 = (nint)0 < (nint)18;
																		object obj120 = !flag51;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X26_v22-90]");
																		object obj121 = -18;
																		bool flag52 = obj121 == null;
																		object obj122 = ~obj120;
																		object obj123 = obj122 | flag52;
																		if (obj123 == null)
																		{
																			object obj124 = array + 176;
																			obj124 = text5;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			string text16 = num3.ToString();
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X26_v24-98]");
																			bool flag53 = (nint)0 < (nint)19;
																			object obj125 = !flag53;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X26_v24-98]");
																			object obj126 = -19;
																			bool flag54 = obj126 == null;
																			object obj127 = ~obj125;
																			object obj128 = obj127 | flag54;
																			if (obj128 == null)
																			{
																				object obj129 = array + 184;
																				obj129 = text16;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				object obj130 = obj;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X0_v113+E4]");
																				bool flag55 = (nint)0 == 0;
																				object obj131 = !flag55;
																				if (obj131 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				}
																				string playerId = NetworkBootstrap.PlayerId;
																				bool flag56 = array.Length < 20;
																				object obj132 = !flag56;
																				object obj133 = array.Length - 20;
																				bool flag57 = obj133 == null;
																				object obj134 = ~obj132;
																				object obj135 = obj134 | flag57;
																				if (obj135 == null)
																				{
																					object obj136 = array + 192;
																					obj136 = playerId;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ X26_v26-A8]");
																					bool flag58 = (nint)0 < (nint)21;
																					object obj137 = !flag58;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1109 @ X26_v26-A8]");
																					object obj138 = -21;
																					bool flag59 = obj138 == null;
																					object obj139 = ~obj137;
																					object obj140 = obj139 | flag59;
																					if (obj140 == null)
																					{
																						object obj141 = array + 200;
																						obj141 = text2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X26_v28-B0]");
																						bool flag60 = (nint)0 < (nint)22;
																						object obj142 = !flag60;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1110 @ X26_v28-B0]");
																						object obj143 = -22;
																						bool flag61 = obj143 == null;
																						object obj144 = ~obj142;
																						object obj145 = obj144 | flag61;
																						if (obj145 == null)
																						{
																							screenFont = (ScreenFont)(array + 208);
																							screenFont = (ScreenFont)obj21;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X26_v34 (ScreenFont)-B8]");
																							bool flag62 = (nint)0 < (nint)23;
																							obj20 = !flag62;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X26_v34 (ScreenFont)-B8]");
																							obj22 = -23;
																							flag12 = obj22 == null;
																							object obj146 = ~obj20;
																							if (((obj146 | flag12) ? 1 : 0) == 0)
																							{
																								object obj147 = array + 216;
																								obj147 = text5;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								nint num16 = (nint)text;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2078 @ X0_v126 (Il2CppClass<System.String>)+E4]");
																								bool flag63 = (nint)0 == 0;
																								object obj148 = !flag63;
																								if (obj148 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								}
																								object obj149;
																								if (obj8 != null)
																								{
																									bool flag64 = (object)obj8 == null;
																									text3 = (string)obj21;
																									num7 = num5;
																									obj10 = null;
																									num2 = percent;
																									num3 = total;
																									num4 = 0;
																									obj11 = null;
																									if (flag64)
																									{
																										goto IL_19a1;
																									}
																									obj149 = obj8 + 152;
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																									obj149 = 0;
																								}
																								bool flag65 = array.Length < 24;
																								obj20 = !flag65;
																								obj22 = array.Length - 24;
																								flag12 = obj22 == null;
																								object obj150 = ~obj20;
																								if (((obj150 | flag12) ? 1 : 0) == 0)
																								{
																									object obj151 = array + 224;
																									obj151 = obj149;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									string text17 = string.Concat(array);
																									bool flag66 = !force;
																									object obj152 = !flag66;
																									int num17 = 0;
																									if (obj152 == null)
																									{
																										bool flag67 = text17 == shown;
																										bool flag68 = !flag67;
																										num17 = 0;
																										if (!flag68)
																										{
																											nint num18 = (nint)text;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2123 @ X0_v160 (Il2CppClass<System.String>)+E4]");
																											bool flag69 = (nint)0 == 0;
																											object obj153 = !flag69;
																											if (obj153 == null)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																											}
																											bool flag70 = tex != null;
																											bool flag71 = !flag70;
																											object obj154 = !flag71;
																											num17 = 0;
																											if (obj154 != null)
																											{
																												return;
																											}
																										}
																									}
																									object obj155 = this + 72;
																									obj155 = text17;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									nint num19 = (nint)text;
																									object obj156 = this + 80;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2117 @ X0_v139 (Il2CppClass<System.String>)+E4]");
																									bool flag72 = (nint)0 == 0;
																									object obj157 = !flag72;
																									if (obj157 == null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE50]");
																									text5 = (string)0;
																									bool flag73 = (UnityEngine.Object)obj156 == null;
																									bool flag74 = !flag73;
																									num4 = 0;
																									obj11 = null;
																									if (!flag74)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
																										object obj158 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																										Texture2D texture2D = default;
																										texture2D._002Ector(320, 240, (TextureFormat)4, mipChain: true);
																										bool flag75 = (object)texture2D == null;
																										text3 = (string)obj21;
																										num7 = num5;
																										obj10 = null;
																										ShiftAuth.Style style = (ShiftAuth.Style)0;
																										bool flag76 = true;
																										TextureFormat textureFormat = (TextureFormat)4;
																										num2 = percent;
																										num3 = total;
																										num4 = 240;
																										obj11 = (UnityEngine.Object)320;
																										if (flag75)
																										{
																											goto IL_19a1;
																										}
																										texture2D.filterMode = (FilterMode)0;
																										texture2D.wrapMode = (TextureWrapMode)1;
																										texture2D.hideFlags = (HideFlags)52;
																										texture2D.name = text5;
																										tex = texture2D;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
																										object obj159 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																										object obj160 = this + 88;
																										UnityEngine.Object obj161 = default;
																										obj160 = obj161;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										style = (ShiftAuth.Style)0;
																										flag76 = true;
																										textureFormat = (TextureFormat)4;
																										num4 = 0;
																										obj11 = obj161;
																									}
																									Color32[] array2 = px;
																									bool flag77 = px == null;
																									text3 = (string)obj21;
																									num7 = num5;
																									obj10 = null;
																									num2 = percent;
																									num3 = total;
																									if (flag77)
																									{
																										goto IL_19a1;
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D10]");
																									text = (string)0;
																									object obj162 = 0;
																									UnityEngine.Object obj177 = default;
																									object obj178 = default;
																									UnityEngine.Object obj196 = default;
																									UnityEngine.Object obj210 = default;
																									UnityEngine.Object obj222 = default;
																									UnityEngine.Object obj224 = default;
																									UnityEngine.Object obj230 = default;
																									object obj245 = default;
																									object obj250 = default;
																									object obj255 = default;
																									UnityEngine.Object obj262 = default;
																									UnityEngine.Object obj268 = default;
																									MaterialPropertyBlock materialPropertyBlock = default;
																									while (true)
																									{
																										bool flag78 = (nint)obj162 < array2.Length;
																										obj20 = !flag78;
																										obj22 = obj162 - array2.Length;
																										flag12 = obj22 == null;
																										bool flag79 = (nint)obj162 >= array2.Length;
																										text3 = (string)obj21;
																										num7 = num5;
																										obj10 = null;
																										num2 = percent;
																										text18 = text4;
																										obj7 = 4278452738L;
																										num3 = total;
																										if (!flag79)
																										{
																											bool flag80 = (nint)obj162 < array2.Length;
																											obj20 = !flag80;
																											obj22 = obj162 - array2.Length;
																											flag12 = obj22 == null;
																											if (obj20 != null)
																											{
																												break;
																											}
																											object obj163 = (object)array2 + obj162;
																											obj162++;
																											_ = 4278452738L;
																											array2 = px;
																											bool flag81 = px == null;
																											object obj164 = !flag81;
																											text3 = (string)obj21;
																											num7 = num5;
																											obj10 = null;
																											num2 = percent;
																											obj7 = 4278452738L;
																											num3 = total;
																											if (obj164 != null)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											object obj165 = this + 112;
																											bool flag82 = obj165 == null;
																											object obj166 = !flag82;
																											if (obj166 == null)
																											{
																												object obj167 = obj27;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v330+E4]");
																												bool flag83 = (nint)0 == 0;
																												object obj168 = !flag83;
																												if (obj168 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												}
																												ScreenFont screenFont2 = Load(titleFont);
																												obj165 = screenFont2;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												obj11 = (UnityEngine.Object)(object)screenFont2;
																											}
																											object obj169 = this + 120;
																											bool flag84 = obj169 == null;
																											object obj170 = !flag84;
																											TextAsset textAsset = (TextAsset)(object)screenFont;
																											if (obj170 == null)
																											{
																												object obj171 = obj27;
																												textAsset = textFont;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v323+E4]");
																												bool flag85 = (nint)0 == 0;
																												object obj172 = !flag85;
																												if (obj172 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												}
																												ScreenFont screenFont3 = Load(textAsset);
																												obj169 = screenFont3;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												obj11 = (UnityEngine.Object)(object)screenFont3;
																											}
																											object obj173 = obj27;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v190+E4]");
																											bool flag86 = (nint)0 == 0;
																											object obj174 = !flag86;
																											if (obj174 == null)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												obj173 = obj27;
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v190+A0]");
																											object obj175 = 0;
																											object obj176 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											int num20 = Line((ScreenFont)obj165, 160, 14, text5, (ShiftAuth.Style)(&obj178), centred: true);
																											object obj179 = obj27;
																											object obj180 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v105+A0]");
																											object obj181 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											UnityEngine.Object obj182 = (UnityEngine.Object)1;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v106+48]");
																											UnityEngine.Object obj183 = (UnityEngine.Object)0;
																											bool flag87 = true;
																											obj177 = (UnityEngine.Object)1;
																											obj10 = (UnityEngine.Object)1;
																											ShiftAuth.Style style = (ShiftAuth.Style)(&obj178);
																											bool flag76 = (byte)(int)text5 != 0;
																											TextureFormat textureFormat = (TextureFormat)14;
																											object obj184 = 0;
																											screenFont = (ScreenFont)(object)textAsset;
																											int num21 = 46;
																											num4 = 160;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v106+48]");
																											obj11 = (UnityEngine.Object)0;
																											while (true)
																											{
																												object obj185 = obj27;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+E4]");
																												bool flag88 = (nint)0 == 0;
																												object obj186 = !flag88;
																												if (obj186 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													obj185 = obj27;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+A0]");
																												object obj187 = 0;
																												object obj188 = obj187;
																												bool flag89 = obj187 == null;
																												obj178 = obj177;
																												text4 = (string)(&obj177);
																												if (flag89)
																												{
																													break;
																												}
																												object obj189 = obj184;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v25+18]");
																												bool flag90 = (nint)obj189 < 0;
																												obj20 = !flag90;
																												object obj190 = obj184;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v25+18]");
																												obj22 = obj190 - 0;
																												flag12 = obj22 == null;
																												object obj191 = obj184;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v25+18]");
																												if ((nint)obj191 < 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+E4]");
																													bool flag91 = (nint)0 == 0;
																													object obj192 = !flag91;
																													if (obj192 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														obj185 = obj27;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+A0]");
																														obj187 = 0;
																													}
																													object obj193 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v110+C]");
																													bool flag92 = (nint)obj193 < 0;
																													obj20 = !flag92;
																													object obj194 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v110+C]");
																													obj22 = obj194 - 0;
																													flag12 = obj22 == null;
																													object obj195 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v110+C]");
																													if (obj195 == null)
																													{
																														int num22 = Line(this.text, 8, num21, text, (ShiftAuth.Style)(&obj196), centred: false);
																														obj185 = obj27;
																														obj196 = obj182;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v106+48]");
																														obj183 = (UnityEngine.Object)0;
																														flag87 = false;
																														obj10 = obj182;
																														style = (ShiftAuth.Style)(&obj196);
																														flag76 = (byte)(int)text != 0;
																														textureFormat = (TextureFormat)num21;
																														num4 = 8;
																														obj11 = (UnityEngine.Object)(object)this.text;
																													}
																													screenFont = (ScreenFont)obj169;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+E4]");
																													bool flag93 = (nint)0 == 0;
																													object obj197 = !flag93;
																													if (obj197 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														obj185 = obj27;
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+A0]");
																													object obj198 = 0;
																													object obj199 = obj198;
																													bool flag94 = obj198 == null;
																													obj178 = obj177;
																													text4 = (string)(&obj177);
																													if (flag94)
																													{
																														break;
																													}
																													object obj200 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X9_v38+18]");
																													bool flag95 = (nint)obj200 < 0;
																													object obj201 = !flag95;
																													if (obj201 != null)
																													{
																														goto end_IL_2ee6;
																													}
																													object obj202 = obj198 + obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X9_v39+20]");
																													text5 = (string)0;
																													object obj203 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v178+C]");
																													bool flag96 = (nint)obj203 < 0;
																													obj20 = !flag96;
																													object obj204 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v178+C]");
																													obj22 = obj204 - 0;
																													flag12 = obj22 == null;
																													object obj205 = obj184;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v178+C]");
																													object obj206;
																													if (obj205 == null)
																													{
																														obj206 = (object)(&obj182);
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+E4]");
																														bool flag97 = (nint)0 == 0;
																														object obj207 = !flag97;
																														if (obj207 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																															object obj208 = obj27;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1602 @ X8_v180+A0]");
																															obj198 = 0;
																														}
																														object obj209 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														obj177 = (UnityEngine.Object)1;
																														obj206 = (object)(&obj177);
																													}
																													obj10 = (UnityEngine.Object)obj206;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v177+10]");
																													obj183 = (UnityEngine.Object)0;
																													int num23 = Line(screenFont, 16, num21, text5, (ShiftAuth.Style)(&obj210), centred: false);
																													obj184++;
																													int num24 = num21 + 14;
																													obj210 = (UnityEngine.Object)obj206;
																													flag87 = false;
																													style = (ShiftAuth.Style)(&obj210);
																													flag76 = (byte)(int)text5 != 0;
																													textureFormat = (TextureFormat)num21;
																													num21 = num24;
																													num4 = 16;
																													obj11 = (UnityEngine.Object)(object)screenFont;
																													continue;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v304+E4]");
																												bool flag98 = (nint)0 == 0;
																												object obj211 = !flag98;
																												if (obj211 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													object obj212 = obj27;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X8_v171+A0]");
																													obj187 = 0;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v110+74]");
																												Fill(76, 40, 1, 104, (Color32)0);
																												object obj213 = obj27;
																												object obj214 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v111+A0]");
																												object obj215 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												object obj216 = obj27;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v204+A0]");
																												object obj217 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v113+C]");
																												object obj218 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v113+C]");
																												if ((nint)0 != 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v204+E4]");
																													bool flag99 = (nint)0 == 0;
																													object obj219 = !flag99;
																													if (obj219 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																														object obj220 = obj27;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v168+A0]");
																														object obj221 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ X8_v169+C]");
																														obj218 = 0;
																													}
																													bool flag100 = (nint)obj218 < 1;
																													obj20 = !flag100;
																													obj22 = obj218 - 1;
																													flag12 = obj22 == null;
																													if ((nint)obj218 == 1)
																													{
																														DrawColour((ShiftAuth.Style)(&obj222));
																														obj222 = (UnityEngine.Object)4510805388492275713L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X8_v112+50]");
																														UnityEngine.Object obj223 = (UnityEngine.Object)0;
																													}
																													else
																													{
																														DrawSettings((ShiftAuth.Style)(&obj224));
																														obj224 = (UnityEngine.Object)4510805388492275713L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X8_v112+50]");
																														UnityEngine.Object obj223 = (UnityEngine.Object)0;
																													}
																												}
																												else
																												{
																													DrawCode(text3, text18);
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X8_v112+50]");
																													UnityEngine.Object obj223 = (UnityEngine.Object)0;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE40]");
																												object obj225 = 0;
																												string text19 = (string)obj225 + text2;
																												object obj226 = obj27;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X0_v209+E4]");
																												bool flag101 = (nint)0 == 0;
																												object obj227 = !flag101;
																												if (obj227 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													obj226 = obj27;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ X0_v209+A0]");
																												object obj228 = 0;
																												object obj229 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num25 = Line((ScreenFont)obj169, 160, 151, text19, (ShiftAuth.Style)(&obj230), centred: true);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																												object obj231 = 0;
																												object obj232 = obj231;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X0_v214+E4]");
																												bool flag102 = (nint)0 == 0;
																												object obj233 = !flag102;
																												if (obj233 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												}
																												bool flag103 = obj8 != null;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE30]");
																												object obj234 = 0;
																												text = (string)obj234;
																												object obj235;
																												if (flag103)
																												{
																													bool flag104 = (object)obj8 == null;
																													obj230 = (UnityEngine.Object)1;
																													obj178 = obj177;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ X8_v119+58]");
																													obj183 = (UnityEngine.Object)0;
																													flag87 = true;
																													obj10 = (UnityEngine.Object)1;
																													style = (ShiftAuth.Style)(&obj230);
																													flag76 = (byte)(int)text19 != 0;
																													textureFormat = (TextureFormat)151;
																													text4 = (string)(&obj177);
																													num4 = 0;
																													obj11 = null;
																													if (flag104)
																													{
																														break;
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																													obj235 = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X20_v7 (UnityEngine.Object)+A4]");
																													bool flag105 = (nint)0 == 0;
																													object obj236 = !flag105;
																													if (obj236 == null)
																													{
																														if (((NetworkBootstrap)obj8).IsPublicRoom)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE48]");
																															obj235 = 0;
																														}
																														obj20 = 0;
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
																													obj235 = 0;
																												}
																												string text20 = (string)obj235;
																												string text21 = text + text3 + (string)obj235;
																												object obj237 = obj27;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1680 @ X8_v127+E4]");
																												bool flag106 = (nint)0 == 0;
																												object obj238 = !flag106;
																												if (obj238 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													obj237 = obj27;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1680 @ X8_v127+A0]");
																												object obj239 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ X8_v128+C]");
																												bool flag107 = (nint)0 == 0;
																												TextureFormat textureFormat2 = (TextureFormat)0;
																												string text22 = text3;
																												UnityEngine.Object line = (UnityEngine.Object)(object)text21;
																												if (!flag107)
																												{
																													bool flag108 = text18 == null;
																													obj230 = (UnityEngine.Object)1;
																													obj178 = obj177;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ X8_v119+58]");
																													obj183 = (UnityEngine.Object)0;
																													flag87 = true;
																													obj10 = (UnityEngine.Object)1;
																													style = (ShiftAuth.Style)(&obj230);
																													flag76 = (byte)(int)text19 != 0;
																													textureFormat = (TextureFormat)0;
																													text4 = (string)(&obj177);
																													num4 = (int)text18;
																													obj11 = (UnityEngine.Object)(object)text3;
																													obj8 = (UnityEngine.Object)(object)text21;
																													if (flag108)
																													{
																														break;
																													}
																													bool flag109 = text18._stringLength < 1;
																													obj20 = !flag109;
																													obj22 = text18._stringLength - 1;
																													flag12 = obj22 == null;
																													flag79 = text18._stringLength < 1;
																													textureFormat2 = (TextureFormat)0;
																													text20 = text18;
																													text22 = text3;
																													line = (UnityEngine.Object)(object)text21;
																													if (!flag79)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7B8]");
																														object obj240 = 0;
																														string text23 = text21 + (string)obj240 + text18;
																														bool flag110 = obj169 == null;
																														obj230 = (UnityEngine.Object)1;
																														obj178 = obj177;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ X8_v119+58]");
																														obj183 = (UnityEngine.Object)0;
																														flag87 = true;
																														obj10 = (UnityEngine.Object)1;
																														style = (ShiftAuth.Style)(&obj230);
																														flag76 = (byte)(int)text19 != 0;
																														textureFormat = (TextureFormat)0;
																														text4 = (string)(&obj177);
																														num4 = (int)text18;
																														obj11 = (UnityEngine.Object)obj240;
																														obj8 = (UnityEngine.Object)(object)text21;
																														if (flag110)
																														{
																															break;
																														}
																														int num26 = ((ScreenFont)obj169).Measure(text23, 1);
																														bool flag111 = num26 < 308;
																														obj20 = !flag111;
																														obj22 = num26 - 308;
																														flag12 = obj22 == null;
																														flag79 = num26 > 308;
																														textureFormat2 = (TextureFormat)0;
																														text20 = (string)1;
																														text22 = text23;
																														line = (UnityEngine.Object)(object)text21;
																														if (!flag79)
																														{
																															text22 = (string)obj240;
																															string text24 = text21 + (string)obj240 + text18;
																															textureFormat2 = (TextureFormat)0;
																															text20 = text18;
																															line = (UnityEngine.Object)(object)text24;
																														}
																													}
																												}
																												object obj241 = obj27;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1733 @ X0_v224+E4]");
																												bool flag112 = (nint)0 == 0;
																												object obj242 = !flag112;
																												if (obj242 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													obj241 = obj27;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1733 @ X0_v224+A0]");
																												object obj243 = 0;
																												object obj244 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num27 = Line((ScreenFont)obj169, 160, 162, (string)(object)line, (ShiftAuth.Style)(&obj245), centred: true);
																												string text25 = num7.ToString();
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE60]");
																												object obj246 = 0;
																												string line2 = (string)obj246 + text25;
																												object obj247 = obj27;
																												object obj248 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1771 @ X8_v136+A0]");
																												object obj249 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num28 = Line(this.text, 160, 199, line2, (ShiftAuth.Style)(&obj250), centred: true);
																												string text26 = num3.ToString();
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE58]");
																												object obj251 = 0;
																												string line3 = (string)obj251 + text26;
																												object obj252 = obj27;
																												object obj253 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1810 @ X8_v141+A0]");
																												object obj254 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num29 = Line(this.text, 160, 208, line3, (ShiftAuth.Style)(&obj255), centred: true);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
																												object obj256 = 0;
																												object obj257 = obj256;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ X0_v245+E4]");
																												bool flag113 = (nint)0 == 0;
																												object obj258 = !flag113;
																												if (obj258 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												}
																												string playerId2 = NetworkBootstrap.PlayerId;
																												object obj259 = obj27;
																												object obj260 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1847 @ X8_v146+A0]");
																												object obj261 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num30 = Line(this.text, 160, 220, playerId2, (ShiftAuth.Style)(&obj262), centred: true);
																												obj8 = (UnityEngine.Object)(object)this.text;
																												string text27 = num2.ToString();
																												string build = Build;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E0]");
																												object obj263 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFE38]");
																												object obj264 = 0;
																												string text28 = (string)obj263 + text27 + (string)obj264 + build;
																												object obj265 = obj27;
																												object obj266 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj177, 16));
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1896 @ X8_v152+A0]");
																												object obj267 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num31 = Line(this.text, 160, 230, text28, (ShiftAuth.Style)(&obj268), centred: true);
																												bool flag114 = (object)tex == null;
																												obj268 = (UnityEngine.Object)1;
																												obj262 = (UnityEngine.Object)1;
																												obj255 = 1;
																												obj250 = 1;
																												obj245 = 1;
																												obj230 = (UnityEngine.Object)1;
																												obj178 = obj177;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v153+60]");
																												obj183 = (UnityEngine.Object)0;
																												flag87 = true;
																												obj10 = (UnityEngine.Object)1;
																												style = (ShiftAuth.Style)(&obj268);
																												flag76 = (byte)(int)text28 != 0;
																												textureFormat = (TextureFormat)230;
																												num2 = 54;
																												text4 = (string)(&obj177);
																												num4 = 160;
																												obj11 = (UnityEngine.Object)(object)this.text;
																												if (flag114)
																												{
																													break;
																												}
																												tex.SetPixels32(px);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																												obj8 = (UnityEngine.Object)0;
																												bool flag115 = (object)tex == null;
																												obj268 = (UnityEngine.Object)1;
																												obj262 = (UnityEngine.Object)1;
																												obj255 = 1;
																												obj250 = 1;
																												obj245 = 1;
																												obj230 = (UnityEngine.Object)1;
																												obj178 = obj177;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v153+60]");
																												obj183 = (UnityEngine.Object)0;
																												flag87 = true;
																												obj10 = (UnityEngine.Object)1;
																												style = (ShiftAuth.Style)(&obj268);
																												flag76 = (byte)(int)text28 != 0;
																												textureFormat = (TextureFormat)230;
																												num2 = 54;
																												text4 = (string)(&obj177);
																												num4 = 0;
																												obj11 = (UnityEngine.Object)(object)px;
																												if (flag115)
																												{
																													break;
																												}
																												tex.Apply(updateMipmaps: true);
																												nint num32 = (nint)obj8;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1924 @ X0_v264 (Il2CppClass<UnityEngine.Object>)+E4]");
																												bool flag116 = (nint)0 == 0;
																												object obj269 = !flag116;
																												if (obj269 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																												}
																												bool flag117 = screen == null;
																												bool flag118 = !flag117;
																												object obj270 = !flag118;
																												if (obj270 == null)
																												{
																													obj8 = (UnityEngine.Object)(this + 96);
																													bool flag119 = (object)obj8 == null;
																													object obj271 = !flag119;
																													obj11 = null;
																													if (obj271 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
																														object obj272 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																														materialPropertyBlock._002Ector();
																														obj8 = (UnityEngine.Object)(object)materialPropertyBlock;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														obj11 = (UnityEngine.Object)(object)materialPropertyBlock;
																													}
																													bool flag120 = (object)screen == null;
																													obj268 = (UnityEngine.Object)1;
																													obj262 = (UnityEngine.Object)1;
																													obj255 = 1;
																													obj250 = 1;
																													obj245 = 1;
																													obj230 = (UnityEngine.Object)1;
																													obj178 = obj177;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v153+60]");
																													obj183 = (UnityEngine.Object)0;
																													flag87 = true;
																													obj10 = (UnityEngine.Object)1;
																													style = (ShiftAuth.Style)(&obj268);
																													flag76 = (byte)(int)text28 != 0;
																													textureFormat = (TextureFormat)230;
																													num2 = 54;
																													text4 = (string)(&obj177);
																													num4 = 0;
																													if (flag120)
																													{
																														break;
																													}
																													screen.GetPropertyBlock((MaterialPropertyBlock)(object)obj8);
																													object obj273 = obj27;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1994 @ X0_v270+E4]");
																													bool flag121 = (nint)0 == 0;
																													object obj274 = !flag121;
																													if (obj274 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													bool flag122 = (object)obj8 == null;
																													obj268 = (UnityEngine.Object)1;
																													obj262 = (UnityEngine.Object)1;
																													obj255 = 1;
																													obj250 = 1;
																													obj245 = 1;
																													obj230 = (UnityEngine.Object)1;
																													obj178 = obj177;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v153+60]");
																													obj183 = (UnityEngine.Object)0;
																													flag87 = true;
																													obj10 = (UnityEngine.Object)1;
																													style = (ShiftAuth.Style)(&obj268);
																													flag76 = (byte)(int)text28 != 0;
																													textureFormat = (TextureFormat)230;
																													num2 = 54;
																													text4 = (string)(&obj177);
																													num4 = 0;
																													obj11 = obj8;
																													if (flag122)
																													{
																														break;
																													}
																													object obj275 = obj27;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2004 @ X8_v158+A0]");
																													object obj276 = 0;
																													UnityEngine.Object obj277 = obj8;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v159+8]");
																													((MaterialPropertyBlock)(object)obj277).SetTexture(0, (Texture)tex);
																													bool flag123 = (object)screen == null;
																													obj268 = (UnityEngine.Object)1;
																													obj262 = (UnityEngine.Object)1;
																													obj255 = 1;
																													obj250 = 1;
																													obj245 = 1;
																													obj230 = (UnityEngine.Object)1;
																													obj178 = obj177;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v153+60]");
																													obj183 = (UnityEngine.Object)0;
																													flag87 = true;
																													obj10 = (UnityEngine.Object)1;
																													style = (ShiftAuth.Style)(&obj268);
																													flag76 = (byte)(int)text28 != 0;
																													textureFormat = (TextureFormat)0;
																													num2 = 54;
																													text4 = (string)(&obj177);
																													num4 = (int)tex;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v159+8]");
																													obj11 = (UnityEngine.Object)0;
																													if (flag123)
																													{
																														break;
																													}
																													screen.SetPropertyBlock((MaterialPropertyBlock)(object)obj8);
																												}
																												return;
																											}
																										}
																										goto IL_19a1;
																										continue;
																										end_IL_2ee6:
																										break;
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
								goto IL_2c67;
							}
						}
					}
					goto IL_19a1;
				}
			}
		}
		goto IL_2c67;
		IL_2c67:
		throw new IndexOutOfRangeException();
		IL_19a1:
		text18 = text4;
		throw new NullReferenceException();
	}

	private unsafe void DrawCode(string room, string why)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0712: Expected Obj, but got I
		//IL_072a: Expected Obj, but got I
		//IL_074c: Expected Obj, but got I4
		//IL_0b66: Expected Obj, but got I
		//IL_0b74: Expected Obj, but got Ref
		//IL_0ba1: Expected VT, but got Ref
		//IL_0bbb: Expected Obj, but got Ref
		//IL_0bcb: Expected Obj, but got I
		//IL_003a: Expected Obj, but got Ref
		//IL_0052: Expected Obj, but got I
		//IL_007f: Expected VT, but got Ref
		//IL_00ab: Expected VT, but got Ref
		//IL_00c4: Expected Obj, but got I
		//IL_0175: Expected VT, but got Ref
		//IL_01a3: Expected Obj, but got I4
		//IL_07be: Expected Obj, but got I
		//IL_07ce: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I4
		//IL_076a: Expected Obj, but got I
		//IL_0778: Expected Obj, but got Ref
		//IL_07a5: Expected VT, but got Ref
		//IL_027c: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_028d: Expected VT, but got Ref
		//IL_0877: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_0bea: Expected Obj, but got I
		//IL_0bfa: Expected Obj, but got I
		//IL_07f6: Expected VT, but got Ref
		//IL_082d: Expected Obj, but got I
		//IL_0836: Expected Obj, but got I4
		//IL_0848: Expected VT, but got Ref
		//IL_02c2: Expected Obj, but got I
		//IL_02e1: Expected I4, but got Obj
		//IL_02f1: Expected I4, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I4
		//IL_096e: Expected Obj, but got I
		//IL_0990: Expected Obj, but got I4
		//IL_08cd: Expected VT, but got I
		//IL_08e6: Expected Obj, but got I4
		//IL_0c17: Expected Obj, but got I
		//IL_0c27: Expected Obj, but got I
		//IL_0c49: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got I
		//IL_05de: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I4
		//IL_0ad7: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I4
		//IL_0c67: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got Ref
		//IL_0ca1: Expected VT, but got Ref
		//IL_0cbb: Expected Obj, but got Ref
		//IL_0ccb: Expected Obj, but got I
		//IL_09ae: Expected Obj, but got I
		//IL_09bc: Expected Obj, but got Ref
		//IL_0683: Expected VT, but got Ref
		//IL_056a: Expected Obj, but got I
		//IL_0a0e: Expected VT, but got Ref
		//IL_0a22: Expected Obj, but got I
		//IL_0a37: Expected Obj, but got I
		//IL_0a5e: Expected VT, but got Ref
		//IL_0a8d: Expected Obj, but got I
		//IL_0a96: Expected Obj, but got I4
		//IL_0aa8: Expected VT, but got Ref
		//IL_04f5: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I
		//IL_06dc: Expected Obj, but got I4
		//IL_0af5: Expected Obj, but got I
		//IL_0b03: Expected Obj, but got Ref
		//IL_0b2b: Expected Obj, but got I
		//IL_0b4d: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEB8]");
		object line = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEC8]");
		object line2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+A0]");
		object obj4 = 0;
		object obj6 = default;
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = default;
		int num = Line(this.text, 198, 40, (string)line, (ShiftAuth.Style)(&obj7), centred: true);
		object obj8 = obj;
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v5+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = default;
		int num2 = Line(this.text, 198, 66, (string)line2, (ShiftAuth.Style)(&obj14), centred: true);
		object obj15 = default;
		int num3 = Line(this.text, 198, 78, room, (ShiftAuth.Style)(&obj15), centred: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEE8]");
		object line3 = 0;
		if (why._stringLength >= 1)
		{
			string line4 = Fit(why, 236);
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v104+E4]");
			bool flag2 = (nint)0 == 0;
			object obj17 = !flag2;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v104+A0]");
			object obj18 = 0;
			object obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj20 = default;
			int num4 = Line(this.text, 198, 95, line4, (ShiftAuth.Style)(&obj20), centred: true);
		}
		ScreenFont screenFont = this.text;
		object obj21 = default;
		int num5 = Line(this.text, 198, 106, (string)line3, (ShiftAuth.Style)(&obj21), centred: true);
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v4+20]");
		string text = (string)0;
		ShiftAuth.Style style;
		int num9;
		if (text._stringLength >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj25 = !flag4;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v55+A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v56+20]");
				text = (string)0;
			}
			object obj28 = default;
			int num6 = Line(this.text, 198, 118, text, (ShiftAuth.Style)(&obj28), centred: true);
			obj22 = obj;
			bool flag5 = true;
			int num7 = 118;
			int num8 = 198;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+48]");
			object obj29 = 0;
			object obj30 = 2;
			screenFont = this.text;
			style = (ShiftAuth.Style)(&obj28);
			num9 = num6;
		}
		else
		{
			bool flag5 = true;
			int num7 = 106;
			int num8 = 198;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6+50]");
			object obj29 = 0;
			object obj30 = 1;
			style = (ShiftAuth.Style)(&obj21);
			num9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj31 = !flag6;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X9_v16+20]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X10_v2+10]");
		bool flag7 = (nint)0 > (nint)7;
		int num10 = (int)screenFont;
		Color32 color = (Color32)style;
		int num11 = (int)text;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj35 = !flag8;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj36 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v51+A0]");
				obj32 = 0;
			}
			bool flag9 = num9 < 0;
			int num12 = num9 ^ num9;
			int num13 = num9 & num12;
			bool flag10 = num13 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X9_v16+78]");
			color = (Color32)0;
			bool flag11 = flag9 == flag10;
			object obj37 = !flag11;
			object obj38 = ~obj37;
			int num14 = ((obj38 != null) ? num9 : (num9 + 1));
			int num15 = num14 >> 1;
			num10 = num15 + 200;
			Fill(num10, 118, 8, 14, color);
			int num7 = 8;
			int num8 = 118;
			num11 = 14;
		}
		object obj39 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X0_v25+E4]");
		bool flag12 = (nint)0 == 0;
		object obj40 = !flag12;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj41 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v29+E4]");
		bool flag13 = (nint)0 == 0;
		object obj43 = !flag13;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj41 = obj34;
		}
		object obj44 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v29+A0]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v10+8]");
		UnityEngine.Object obj46 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v21+E4]");
		bool flag14 = (nint)0 == 0;
		object obj47 = !flag14;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v10+8]");
		bool flag15 = (UnityEngine.Object)0 != null;
		bool flag16 = !flag15;
		int num16 = 0;
		ScreenFont screenFont2 = null;
		ShiftAuth.Style style2 = (ShiftAuth.Style)color;
		string text2 = (string)num11;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X20_v8 (UnityEngine.Object)+98]");
			bool flag17 = (nint)0 == 0;
			num16 = 0;
			screenFont2 = null;
			style2 = (ShiftAuth.Style)color;
			text2 = (string)num11;
			if (!flag17)
			{
				object obj48 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v61+E4]");
				bool flag18 = (nint)0 == 0;
				object obj49 = !flag18;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj48 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v61+A0]");
				object obj50 = 0;
				object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X20_v8 (UnityEngine.Object)+A0]");
				string line5;
				if ((nint)0 != 0)
				{
					object obj52 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v71+E4]");
					bool flag19 = (nint)0 == 0;
					object obj53 = !flag19;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X20_v8 (UnityEngine.Object)+A0]");
					string text3 = NetworkBootstrap.LabelOf((NetworkBootstrap.Lobby)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEF8]");
					object obj54 = 0;
					string text4 = (string)obj54 + text3;
					line5 = text4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFED0]");
					object obj55 = 0;
					line5 = (string)obj55;
				}
				object obj56 = default;
				int num17 = Line(this.text, 198, 133, line5, (ShiftAuth.Style)(&obj56), centred: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFED8]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X20_v8 (UnityEngine.Object)+98]");
				string text5 = (string)obj57 + (string)0;
				object obj58 = default;
				int num18 = Line(this.text, 198, 141, text5, (ShiftAuth.Style)(&obj58), centred: true);
				bool flag5 = true;
				int num7 = 141;
				num16 = 198;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v35+50]");
				object obj29 = 0;
				object obj30 = 1;
				screenFont2 = this.text;
				style2 = (ShiftAuth.Style)(&obj58);
				text2 = text5;
			}
		}
		object obj59 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X0_v35+E4]");
		bool flag20 = (nint)0 == 0;
		object obj60 = !flag20;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEC0]");
		object line6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEF0]");
		object line7 = 0;
		bool inRoom = InRoom;
		object obj61 = obj;
		bool flag21 = !inRoom;
		object obj62 = !flag21;
		object obj63 = ~obj62;
		int num19 = ((obj63 != null) ? 178 : 172);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v38+E4]");
		bool flag22 = (nint)0 == 0;
		object obj64 = !flag22;
		if (obj64 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj61 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v38+A0]");
		object obj65 = 0;
		object obj66 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj67 = default;
		int num20 = Line(this.text, 160, num19, (string)line6, (ShiftAuth.Style)(&obj67), centred: true);
		object obj68 = obj;
		object obj69 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v26+A0]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int y = num19 + 9;
		object obj71 = default;
		int num21 = Line(this.text, 160, y, (string)line7, (ShiftAuth.Style)(&obj71), centred: true);
		if (InRoom)
		{
			object obj72 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v50+E4]");
			bool flag23 = (nint)0 == 0;
			object obj73 = !flag23;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj72 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v50+A0]");
			object obj74 = 0;
			object obj75 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int y2 = num19 + 18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEE0]");
			object line8 = 0;
			object obj76 = default;
			int num22 = Line(this.text, 160, y2, (string)line8, (ShiftAuth.Style)(&obj76), centred: true);
		}
	}

	private string Fit(string line, int most)
	{
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_0213: Expected I4, but got Obj
		string text;
		if (this.text != null)
		{
			int num = this.text.Measure(line, 1);
			bool flag = num <= most;
			text = line;
			if (flag)
			{
				goto IL_01a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7220]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF88]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
			object obj3 = 0;
			text = line;
			char[] array = default;
			while (text != null)
			{
				if (text._stringLength > 1)
				{
					int startIndex = text._stringLength - 2;
					int num2 = text.LastIndexOf(' ', startIndex);
					bool flag2 = num2 >= 1;
					int length = num2;
					if (!flag2)
					{
						length = text._stringLength - 1;
					}
					string text2 = text.Substring(0, length);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj4 = obj2;
					array[0] = (char)(int)obj4;
					if (text2 == null)
					{
						break;
					}
					string text3 = text2.TrimEnd(array);
					string text4 = text3 + (string)obj3;
					if (this.text == null)
					{
						break;
					}
					int num3 = this.text.Measure(text4, 1);
					bool flag3 = num3 > most;
					text = text3;
					if (!flag3)
					{
						return text3 + (string)obj3;
					}
					continue;
				}
				goto IL_01a7;
			}
		}
		return (string)(object)new NullReferenceException();
		IL_01a7:
		return text;
	}

	private unsafe void DrawColour(ShiftAuth.Style hint)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_066e: Expected Obj, but got I
		//IL_0690: Expected Obj, but got I4
		//IL_0750: Expected Obj, but got I
		//IL_075e: Expected Obj, but got Ref
		//IL_0793: Expected VT, but got Ref
		//IL_0061: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I8
		//IL_00c8: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got Ref
		//IL_01a9: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_021f: Expected VT, but got Ref
		//IL_0732: Expected Obj, but got I4
		//IL_06ae: Expected Obj, but got I
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I
		//IL_027f: Expected VT, but got Ref
		//IL_028c: Expected Obj, but got I4
		//IL_02b6: Expected Obj, but got I
		//IL_02be: Expected VT, but got Ref
		//IL_031c: Expected Obj, but got I4
		//IL_06f3: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got Ref
		//IL_03b2: Expected VT, but got Ref
		//IL_03b2: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I4
		//IL_0425: Expected Obj, but got Ref
		//IL_043f: Expected Obj, but got I
		//IL_0461: Expected VT, but got Ref
		//IL_0482: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_04b8: Expected Obj, but got I4
		//IL_04d3: Expected I4, but got Obj
		//IL_0502: Expected VT, but got Ref
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0550: Expected Obj, but got I4
		//IL_0559: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_058c: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I4
		//IL_05a7: Expected VT, but got Ref
		//IL_05cd: Expected Obj, but got I
		//IL_05f0: Expected VT, but got Ref
		//IL_0604: Expected Obj, but got I
		//IL_0627: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF08]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+A0]");
		object obj6 = 0;
		object obj8 = default;
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		string text = (string)obj2;
		object obj9 = default;
		int num = Line(this.text, 198, 40, (string)obj2, (ShiftAuth.Style)(&obj9), centred: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C8]");
			object obj10 = 0;
			object obj12 = default;
			object obj11 = obj12 + 32;
			obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X22_v6-8]");
			object obj13 = 0 & 0xFFFFFFFEL;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF10]");
				object obj14 = 0;
				object obj15 = obj12 + 40;
				obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X22_v8-10]");
				bool flag2 = (nint)0 < (nint)2;
				object obj16 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X22_v8-10]");
				object obj17 = -2;
				bool flag3 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag3;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF20]");
					object obj20 = 0;
					object obj21 = obj12 + 48;
					obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj22 = obj;
					object obj23 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v17+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj25 = 32;
					object obj26 = 4;
					int num2 = 66;
					bool flag4 = true;
					int num3 = 40;
					int num4 = 198;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+48]");
					ScreenFont screenFont = (ScreenFont)0;
					object obj27 = 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+48]");
					ScreenFont screenFont2 = (ScreenFont)0;
					ShiftAuth.Style style = (ShiftAuth.Style)(&obj9);
					object obj33 = default;
					object obj41 = default;
					object obj47 = default;
					object obj52 = default;
					object obj53 = default;
					object obj54 = default;
					while (true)
					{
						object obj28 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v25+E4]");
						bool flag5 = (nint)0 == 0;
						object obj29 = !flag5;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj28 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v25+A0]");
						object obj30 = 0;
						object obj31 = obj26 - 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v21+18]");
						if (obj31 == null)
						{
							screenFont2 = this.text;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D10]");
							object obj32 = 0;
							text = (string)obj32;
							int num5 = Line(this.text, 110, num2, (string)obj32, (ShiftAuth.Style)(&obj33), centred: false);
							obj33 = 2;
							flag4 = false;
							num3 = num2;
							num4 = 110;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+48]");
							screenFont = (ScreenFont)0;
							style = (ShiftAuth.Style)(&obj33);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+18]");
						bool flag6 = (nint)obj31 < 0;
						object obj34 = !flag6;
						if (obj34 != null)
						{
							break;
						}
						object obj35 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v28+E4]");
						bool flag7 = (nint)0 == 0;
						object obj36 = !flag7;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj35 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v28+A0]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v26+80]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v27+18]");
						bool flag8 = (nint)obj31 < 0;
						object obj39 = !flag8;
						if (obj39 != null)
						{
							break;
						}
						object obj40 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						ScreenFont font = this.text;
						int y = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+v169 @ X29_v4*8]");
						int num6 = Line(font, 132, y, (string)0, (ShiftAuth.Style)(&obj41), centred: false);
						object obj42 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v28+A0]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v29+80]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v30+18]");
						bool flag9 = (nint)obj31 < 0;
						object obj45 = !flag9;
						if (obj45 != null)
						{
							break;
						}
						object obj46 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
						object line = 0;
						int num7 = Line(this.text, 144, num2, (string)line, (ShiftAuth.Style)(&obj47), centred: false);
						object obj48 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v33+A0]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v34+10]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v35+18]");
						bool flag10 = (nint)obj31 < 0;
						object obj51 = !flag10;
						if (obj51 != null)
						{
							break;
						}
						int num8 = (int)(obj50 + obj25);
						string text2 = ((int*)num8)->ToString();
						int num9 = Line(this.text, 180, num2, text2, (ShiftAuth.Style)(&obj52), centred: false);
						obj26++;
						obj25 += 4;
						num2 += 21;
						bool flag11 = (nint)obj26 != 7;
						obj52 = 2;
						obj47 = 2;
						obj41 = 2;
						flag4 = false;
						num3 = num2;
						num4 = 180;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v18+48]");
						screenFont = (ScreenFont)0;
						obj27 = 2;
						screenFont2 = this.text;
						style = (ShiftAuth.Style)(&obj52);
						text = text2;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF18]");
							object line2 = 0;
							int num10 = Line(this.text, 160, 178, (string)line2, (ShiftAuth.Style)(&obj53), centred: true);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF00]");
							object line3 = 0;
							int num11 = Line(this.text, 160, 187, (string)line3, (ShiftAuth.Style)(&obj54), centred: true);
							return;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void DrawSettings(ShiftAuth.Style hint)
	{
		//IL_0010: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got Ref
		//IL_04f7: Expected VT, but got Ref
		//IL_0525: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I
		//IL_03f2: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_0319: Expected VT, but got Ref
		//IL_0335: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF40]");
		object line = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA160]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF60]");
		object obj6 = 0;
		object obj8 = default;
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = default;
		int num = Line(this.text, 198, 40, (string)line, (ShiftAuth.Style)(&obj9), centred: true);
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int mode = GillaTurn.Mode;
		object value;
		if (mode != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF70]");
			value = 0;
			if (mode != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA190]");
				value = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF68]");
			value = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F10]");
		object obj12 = 0;
		Row(0, (string)obj6, (string)value, live: true);
		object obj13;
		if (mode == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF48]");
			obj13 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF58]");
			obj13 = 0;
		}
		string value2;
		if (mode != 0)
		{
			if (mode != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
				object obj14 = 0;
				value2 = (string)obj14;
				goto IL_03b5;
			}
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v41+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int smoothSpeed = GillaTurn.SmoothSpeed;
		}
		else
		{
			object obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v36+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int smoothSpeed = GillaTurn.SnapAngle;
		}
		int num2 = default;
		string text = num2.ToString();
		value2 = text;
		goto IL_03b5;
		IL_03b5:
		object obj19 = mode - 2;
		bool flag5 = obj19 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF38]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F8]");
		object obj21 = 0;
		bool live = !flag5;
		Row(1, (string)obj13, value2, live);
		object obj22 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92E8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF78]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF28]");
		object line2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF30]");
		object words = 0;
		bool flag7 = GillaPlayerPunching.On;
		bool flag8 = !flag7;
		object obj26 = !flag8;
		object obj27 = ~obj26;
		object value3;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF80]");
			value3 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF50]");
			value3 = 0;
		}
		Row(2, (string)obj20, (string)value3, live: true);
		object obj28 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int percent = GillaVoiceVolume.Percent;
		string text2 = num2.ToString();
		string value4 = text2 + (string)obj24;
		Row(3, (string)obj25, value4, live: true);
		object obj30 = default;
		int num3 = Line(this.text, 160, 175, (string)line2, (ShiftAuth.Style)(&obj30), centred: true);
		object obj31 = default;
		ArrowsLine(160, 185, (string)words, (ShiftAuth.Style)(&obj31));
	}

	private unsafe void Row(int row, string name, string value, bool live)
	{
		//IL_0010: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I
		//IL_063e: Expected I4, but got Obj
		//IL_0646: Expected Obj, but got I4
		//IL_064e: Expected VT, but got I
		//IL_0656: Expected Obj, but got I4
		//IL_065e: Expected I4, but got Obj
		//IL_0667: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_059f: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected I4, but got Unknown
		//IL_048d: Expected Obj, but got I
		//IL_04b2: Expected VT, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_0683: Expected Obj, but got Ref
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected I4, but got Unknown
		//IL_06bd: Expected VT, but got Ref
		//IL_0584: Expected Obj, but got I
		//IL_04fa: Expected Obj, but got I
		//IL_0508: Expected Obj, but got Ref
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected I4, but got Unknown
		//IL_054a: Expected VT, but got Ref
		//IL_0569: Expected VT, but got Ref
		//IL_007e: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_06f4: Expected Obj, but got Ref
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected I4, but got Unknown
		//IL_072e: Expected VT, but got Ref
		//IL_05ba: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected I4, but got Unknown
		//IL_0306: Expected Obj, but got I
		//IL_0340: Expected VT, but got I
		//IL_0340: Expected VT, but got I
		//IL_0358: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected I4, but got Unknown
		//IL_03d5: Expected Obj, but got I
		//IL_040f: Expected VT, but got I
		//IL_040f: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = row + row;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+A0]");
		object obj5 = 0;
		object obj6 = obj3 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v30+1C]");
		bool flag2 = (nint)0 != row;
		int num = (int)name;
		ScreenFont screenFont = (ScreenFont)row;
		IntPtr intPtr = default;
		ShiftAuth.Style style = (ShiftAuth.Style)(nint)intPtr;
		string text = (string)live;
		int num2 = (int)value;
		object obj7 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v34+A0]");
				obj5 = 0;
			}
			int y = obj6 + 58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v30+7C]");
			Fill(82, y, 234, 15, (Color32)0);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v47+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v47+A0]");
			object obj13 = 0;
			object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = obj6 + 62;
			text = (string)obj10;
			object obj15 = default;
			int num3 = Line(this.text, 86, num2, (string)obj10, (ShiftAuth.Style)(&obj15), centred: false);
			num = 86;
			screenFont = this.text;
			style = (ShiftAuth.Style)(&obj15);
		}
		object obj16 = obj;
		if (live)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v38+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v38+A0]");
			object obj18 = (nint)0 + (nint)80;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v38+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v38+A0]");
			object obj18 = (nint)0 + (nint)104;
		}
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int y2 = obj6 + 62;
		object obj21 = default;
		int num4 = Line(this.text, 96, y2, name, (ShiftAuth.Style)(&obj21), centred: false);
		object obj22 = obj;
		if (live)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v32+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v32+A0]");
			object obj24 = (nint)0 + (nint)72;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v32+E4]");
			bool flag8 = (nint)0 == 0;
			object obj25 = !flag8;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v32+A0]");
			object obj24 = (nint)0 + (nint)104;
		}
		object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int y3 = obj6 + 62;
		object obj27 = default;
		int num5 = Line(this.text, 284, y3, value, (ShiftAuth.Style)(&obj27), centred: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v30+1C]");
		if ((nint)0 != row || !live)
		{
			return;
		}
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v19+E4]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v19+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v12+48]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+18]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
				object obj32 = 0;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v24+E4]");
				bool flag10 = (nint)0 == 0;
				object obj34 = !flag10;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int y4 = obj6 + 62;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
				object obj35 = 0;
				Color32[] array = px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+20]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+24]");
				PixelFont.Draw(array, 320, 240, 254, y4, (string)obj35, (Color32)num6, (Color32)0);
				object obj36 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v18+A0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v19+48]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v20+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v20+18]");
					if ((nint)0 != 0)
					{
						int y5 = obj6 + 62;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
						object obj39 = 0;
						Color32[] array2 = px;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v20+20]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v20+24]");
						PixelFont.Draw(array2, 320, 240, 309, y5, (string)obj39, (Color32)num7, (Color32)0);
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private unsafe void ArrowsLine(int cx, int y, string words, ShiftAuth.Style style)
	{
		//IL_0320: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0033: Expected I4, but got Obj
		//IL_00be: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I8
		//IL_017f: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got I4
		//IL_01e1: Expected I4, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_0222: Expected VT, but got I
		//IL_0222: Expected VT, but got Obj
		//IL_022f: Expected I4, but got Obj
		//IL_0260: Expected VT, but got I
		//IL_0260: Expected VT, but got Obj
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_02b9: Expected Obj, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected I4, but got Unknown
		//IL_02f6: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		int num;
		if (this.text != null)
		{
			num = this.text.Measure(words, 1);
			string text = null;
			int num2 = 1;
			int num3 = (int)words;
		}
		else
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = PixelFont.Measure(words, 1);
			string text = words;
			int num2 = 0;
			int num3 = 1;
		}
		object obj4 = num + 18;
		ShiftAuth.Style style2 = default;
		Color32[] colours = style2.colours;
		object obj5 = num + 19;
		bool flag2 = (nint)obj4 < 0;
		object obj6 = obj4 ^ obj4;
		object obj7 = obj4 & obj6;
		bool flag3 = (nint)obj7 < 0;
		bool flag4 = flag2 == flag3;
		object obj8 = !flag4;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			obj4 = obj5;
		}
		if (style2.colours != null)
		{
			object obj10 = cx - obj4;
			object obj11 = -4294967296L + colours.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
			object obj12 = 0;
			object obj13 = style2.colours + 32;
			object obj14 = obj10 + 10;
			object obj15 = obj11 >> 30;
			object obj16 = 1;
			object obj17 = 0;
			object obj22;
			do
			{
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v8+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int x = (int)(obj17 + obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
				object obj20 = 0;
				Color32[] array = px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v5+v119 @ X10_v5]");
				PixelFont.Draw(array, 320, 240, x, y, (string)obj20, (Color32)obj13, (Color32)0);
				int num4 = (int)(obj14 + obj17);
				Color32[] array2 = px;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v5+v119 @ X10_v5]");
				PixelFont.Draw(array2, 320, 240, num4, y, (string)obj12, (Color32)obj13, (Color32)0);
				object obj21 = obj16 & 1;
				bool flag6 = obj21 == null;
				obj22 = !flag6;
				string text = (string)num4;
				int num2 = 240;
				int num3 = 320;
				obj16 = 0;
				obj17 = 1;
			}
			while (obj22 != null);
			int x2 = obj10 + 18;
			object obj23 = default;
			int num5 = Line(this.text, x2, y, words, (ShiftAuth.Style)(&obj23), centred: false);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private static ScreenFont Load(TextAsset baked)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I
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
		bool flag2 = baked != null;
		bool flag3 = !flag2;
		ScreenFont result = null;
		if (!flag3)
		{
			if ((object)baked == null)
			{
				return (ScreenFont)(object)new NullReferenceException();
			}
			string baked2 = baked.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont = default;
			screenFont._002Ector(baked2);
			result = screenFont;
		}
		return result;
	}

	private unsafe int Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style, bool centred = default(bool))
	{
		//IL_0064: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I4
		//IL_02cf: Expected Ref, but got VT
		//IL_004b: Expected Ref, but got VT
		//IL_01d1: Expected Obj, but got I4
		//IL_02f9: Expected I4, but got Obj
		//IL_0251: Expected Obj, but got I4
		//IL_02a1: Expected VT, but got Ref
		int num4;
		if (font == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = style.scale - 1;
			bool flag = (nint)obj3 < 0;
			bool flag2 = obj3 == null;
			int num = style.scale ^ 1;
			int num2 = style.scale ^ obj3;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			int scale = ((obj6 != null) ? 1 : style.scale);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num4 = PixelFont.Measure(line, scale);
			bool flag6 = !centred;
			int x2 = x;
			if (!flag6)
			{
				bool flag7 = num4 < 0;
				int num5 = num4 ^ num4;
				int num6 = num4 & num5;
				bool flag8 = num6 < 0;
				bool flag9 = flag7 == flag8;
				object obj8 = !flag9;
				object obj9 = ~obj8;
				int num7 = ((obj9 != null) ? num4 : (num4 + 1));
				x2 = x - num7;
			}
			Color32[] colours = style.colours;
			if (style.colours != null)
			{
				if (colours.Length != 0)
				{
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v10+E4]");
					bool flag10 = (nint)0 == 0;
					object obj11 = !flag10;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PixelFont.Draw(px, 320, 240, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
					goto IL_02d8;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
		num4 = ((!centred) ? font.Draw(px, 320, 240, x, y, line, ref *(ShiftAuth.Style*)style) : font.DrawCentred(px, 320, 240, x, y, line, ref *(ShiftAuth.Style*)style));
		goto IL_02d8;
		IL_02d8:
		return num4;
	}

	private void Fill(int x, int y, int w, int h, Color32 colour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Color32 colour2 = (Color32)(colour & 0xFFFFFFFFL);
		PixelFont.Fill(px, 320, 240, x, y, w, h, colour2);
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
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
		if (!(tex != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		object obj7 = obj;
		if (isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(tex);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.DestroyImmediate(tex);
		}
	}

	static GillaComputer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04fc: Expected Obj, but got I
		//IL_0599: Expected Obj, but got I
		//IL_0636: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_0770: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I
		//IL_081d: Expected Obj, but got I
		//IL_0847: Expected Obj, but got I
		//IL_0861: Expected Obj, but got I
		//IL_087b: Expected Obj, but got I
		//IL_0895: Expected Obj, but got I
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_09ec: Expected Obj, but got I8
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected Obj, but got Unknown
		//IL_0ab8: Expected Obj, but got I4
		//IL_0ace: Expected Obj, but got I
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected Obj, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected Obj, but got Unknown
		//IL_0b3f: Expected Obj, but got I
		//IL_0b6e: Expected Obj, but got I
		//IL_0b98: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFEB8]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X20_v6-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF08]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X20_v8-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF40]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F88]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFA0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
					object obj18 = 0;
					object obj19 = obj4 + 48;
					obj19 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj20 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v14+A0]");
					object obj21 = 0;
					obj21 = obj4;
					object obj22 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num = Shader.PropertyToID((string)obj14);
					object obj23 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v17+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object obj25 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v19+8]");
					_ = 0;
					object obj26 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v21+A0]");
					object obj27 = (nint)0 + (nint)16;
					object obj28 = default;
					obj27 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj29 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v22+A0]");
					object obj30 = (nint)0 + (nint)32;
					obj30 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v28+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v28+18]");
						bool flag3 = (nint)0 == 1;
						_ = 4294967295L;
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v28+18]");
							bool flag4 = (nint)0 < (nint)2;
							object obj31 = !flag4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v28+18]");
							object obj32 = -2;
							bool flag5 = obj32 == null;
							_ = 4291348680L;
							object obj33 = ~obj31;
							object obj34 = obj33 | flag5;
							if (obj34 == null)
							{
								_ = 4287401100L;
								object obj35 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v26+A0]");
								object obj36 = (nint)0 + (nint)56;
								object obj37 = default;
								obj36 = obj37;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v33+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v33+18]");
									bool flag6 = (nint)0 == 1;
									_ = 4289374890L;
									if (!flag6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v33+18]");
										bool flag7 = (nint)0 < (nint)2;
										object obj38 = !flag7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v33+18]");
										object obj39 = -2;
										bool flag8 = obj39 == null;
										_ = 4291677645L;
										object obj40 = ~obj38;
										object obj41 = obj40 | flag8;
										if (obj41 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v33+18]");
											bool flag9 = (nint)0 == 3;
											_ = 4293454056L;
											if (!flag9)
											{
												_ = 4294769916L;
												object obj42 = obj13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v30+A0]");
												object obj43 = (nint)0 + (nint)64;
												object obj44 = default;
												obj43 = obj44;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v38+18]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v38+18]");
													bool flag10 = (nint)0 == 1;
													_ = 4294967295L;
													if (!flag10)
													{
														_ = 4291677645L;
														object obj45 = obj13;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v32+A0]");
														object obj46 = (nint)0 + (nint)72;
														object obj47 = default;
														obj46 = obj47;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v43+18]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v43+18]");
															bool flag11 = (nint)0 == 1;
															_ = 4285120255L;
															if (!flag11)
															{
																_ = 4279859440L;
																object obj48 = obj13;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v36+A0]");
																object obj49 = (nint)0 + (nint)80;
																object obj50 = default;
																obj49 = obj50;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v48+18]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v48+18]");
																	bool flag12 = (nint)0 == 1;
																	_ = 4285464460L;
																	if (!flag12)
																	{
																		_ = 4280866600L;
																		object obj51 = obj13;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v40+A0]");
																		object obj52 = (nint)0 + (nint)88;
																		object obj53 = default;
																		obj52 = obj53;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v53+18]");
																		if ((nint)0 != 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v53+18]");
																			bool flag13 = (nint)0 == 1;
																			_ = 4293059298L;
																			if (!flag13)
																			{
																				_ = 4291085508L;
																				object obj54 = obj13;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v44+A0]");
																				object obj55 = (nint)0 + (nint)96;
																				object obj56 = default;
																				obj55 = obj56;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v58+18]");
																				if ((nint)0 != 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v58+18]");
																					bool flag14 = (nint)0 == 1;
																					_ = 4286348412L;
																					if (!flag14)
																					{
																						_ = 4284374622L;
																						object obj57 = obj13;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8420]");
																						object obj58 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v48+A0]");
																						object obj59 = (nint)0 + (nint)104;
																						object obj60 = default;
																						obj59 = obj60;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						object obj61 = obj13;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v49+A0]");
																						object obj62 = 0;
																						_ = 4281348144L;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v49+A0]");
																						object obj63 = 0;
																						_ = 4281874488L;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v49+A0]");
																						object obj64 = 0;
																						_ = 4285822068L;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v49+A0]");
																						object obj65 = 0;
																						_ = 4280821800L;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v65+18]");
																						if ((nint)0 != 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v65+18]");
																							bool flag15 = (nint)0 == 1;
																							_ = 4282808575L;
																							if (!flag15)
																							{
																								_ = 4279516415L;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v63+18]");
																								if ((nint)0 != 0)
																								{
																									object obj67 = default;
																									object obj66 = obj67 + 32;
																									object obj68 = default;
																									obj66 = obj68;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v70+18]");
																									if ((nint)0 != 0)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v70+18]");
																										bool flag16 = (nint)0 == 1;
																										_ = 4284809080L;
																										if (!flag16)
																										{
																											_ = 4280213800L;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v63+18]");
																											object obj69 = 0 & 0xFFFFFFFEL;
																											if (obj69 != null)
																											{
																												object obj70 = obj67 + 40;
																												object obj71 = default;
																												obj70 = obj71;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v75+18]");
																												if ((nint)0 != 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v75+18]");
																													bool flag17 = (nint)0 == 1;
																													_ = 4294924890L;
																													if (!flag17)
																													{
																														_ = 4294256680L;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v63+18]");
																														bool flag18 = (nint)0 < (nint)2;
																														object obj72 = !flag18;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v63+18]");
																														object obj73 = -2;
																														bool flag19 = obj73 == null;
																														object obj74 = ~obj72;
																														object obj75 = obj74 | flag19;
																														if (obj75 == null)
																														{
																															object obj76 = obj67 + 48;
																															object obj77 = default;
																															obj76 = obj77;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																															object obj78 = obj13;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v64+A0]");
																															object obj79 = (nint)0 + (nint)128;
																															obj79 = obj67;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																															object obj80 = obj13;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v65+A0]");
																															object obj81 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CB70]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B060]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v65+A0]");
																															object obj82 = 0;
																															_ = 4294967295L;
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
