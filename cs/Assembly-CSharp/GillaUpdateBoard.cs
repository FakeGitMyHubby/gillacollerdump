using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaUpdateBoard : MonoBehaviour
{
	public Renderer screen;

	public TextAsset notes;

	public PressKey upKey;

	public PressKey downKey;

	public TextAsset titleFont;

	public TextAsset textFont;

	private const int W = default(int);

	private const int H = default(int);

	private const int Top = default(int);

	private const int Step = default(int);

	private const int Wrap = default(int);

	private const int Rows = default(int);

	private static readonly int BaseMap;

	private Texture2D tex;

	private Color32[] px;

	private MaterialPropertyBlock block;

	private ScreenFont title;

	private ScreenFont text;

	private string heading;

	private readonly List<(string, bool)> lines;

	private int page;

	private int read;

	private int Pages
	{
		get
		{
			//IL_011b: Expected I4, but got Obj
			//IL_001b: Expected Obj, but got I
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0052: Expected I4, but got Obj
			//IL_0060: Expected Obj, but got I4
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected I4, but got Unknown
			//IL_00ce: Expected Obj, but got I4
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			List<(string, bool)> list = lines;
			if ((object)lines != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v3 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+18]");
				object obj = (nint)0 + (nint)17;
				object obj2 = obj * 954437177;
				object obj3 = obj2 >> 63;
				object obj4 = obj2 >> 34;
				int num = (int)(obj4 + obj3);
				object obj5 = num - 1;
				bool flag = (nint)obj5 < 0;
				bool flag2 = obj5 == null;
				int num2 = num ^ 1;
				int num3 = num ^ obj5;
				int num4 = num2 & num3;
				bool flag3 = num4 < 0;
				bool flag4 = flag == flag3;
				object obj6 = !flag2;
				object obj7 = flag4 & obj6;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					return num;
				}
				return 1;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0097: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1A0]");
		object obj5 = 0;
		bool flag2 = upKey != null;
		bool flag3 = !flag2;
		object obj6 = 0;
		Action<PressKey> action = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj5);
			upKey.Pressed += (Action<PressKey>)action2;
			obj6 = 0;
			action = (Action<PressKey>)action2;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (downKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action3 = default;
			action3._002Ector((object)this, (IntPtr)obj5);
			downKey.Pressed += (Action<PressKey>)action3;
		}
		Redraw();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I4
		//IL_0097: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1A0]");
		object obj5 = 0;
		bool flag2 = upKey != null;
		bool flag3 = !flag2;
		object obj6 = 0;
		Action<PressKey> action = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj5);
			upKey.Pressed -= (Action<PressKey>)action2;
			obj6 = 0;
			action = (Action<PressKey>)action2;
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (downKey != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action3 = default;
			action3._002Ector((object)this, (IntPtr)obj5);
			downKey.Pressed -= (Action<PressKey>)action3;
		}
	}

	private void OnKey(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected I4, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = key == downKey;
		int pages = Pages;
		int num = page - 1;
		bool flag3 = !flag2;
		int num2 = pages - 1;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			num = page + 1;
		}
		object obj5 = num - num2;
		bool flag4 = (nint)obj5 < 0;
		int num3 = num ^ num2;
		int num4 = num ^ obj5;
		int num5 = num3 & num4;
		bool flag5 = num5 < 0;
		bool flag6 = flag4 == flag5;
		object obj6 = !flag6;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			num2 = num;
		}
		bool flag7 = num < 0;
		int num6 = num ^ num;
		int num7 = num & num6;
		bool flag8 = num7 < 0;
		bool flag9 = flag7 == flag8;
		object obj8 = !flag9;
		object obj9 = ~obj8;
		int num8 = ((obj9 != null) ? num2 : 0);
		page = num8;
		Redraw();
	}

	public void Refresh()
	{
		//IL_000f: Expected I4, but got I8
		read = -1;
		Redraw();
	}

	private void Read()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c8f: Expected Obj, but got I4
		//IL_0102: Expected I4, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_02d9: Expected I4, but got Obj
		//IL_039f: Expected I4, but got Obj
		//IL_0cc4: Expected Obj, but got I4
		//IL_0cd8: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I4
		//IL_0392: Expected I4, but got Obj
		//IL_0d8a: Expected Obj, but got I4
		//IL_0bc8: Expected Obj, but got I4
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected I4, but got Unknown
		//IL_0c2a: Expected Obj, but got I4
		//IL_0e2c: Expected Obj, but got I4
		//IL_0ad0: Invalid comparison between VT and I4
		//IL_0425: Expected Obj, but got I
		//IL_0b06: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_0b88: Expected Obj, but got I4
		//IL_0d07: Expected I4, but got Obj
		//IL_04d1: Expected I4, but got Obj
		//IL_05fb: Expected Obj, but got I
		//IL_060b: Expected Obj, but got I
		//IL_061c: Expected Obj, but got I4
		//IL_04ef: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I4
		//IL_0535: Expected VT, but got I4
		//IL_053e: Expected Obj, but got I4
		//IL_0547: Expected VT, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected I4, but got Unknown
		//IL_09bd: Expected Obj, but got I4
		//IL_0a43: Expected I4, but got VT
		//IL_0902: Expected I4, but got Obj
		//IL_0a52: Expected Obj, but got I4
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected Obj, but got Unknown
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected Obj, but got Unknown
		//IL_09f6: Expected Obj, but got I
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected Obj, but got Unknown
		//IL_0a11: Expected Obj, but got VT
		//IL_0920: Expected Obj, but got I
		//IL_0936: Expected Obj, but got I
		//IL_094b: Expected Obj, but got I
		//IL_096b: Expected VT, but got I4
		//IL_0974: Expected Obj, but got I4
		//IL_097d: Expected VT, but got I4
		//IL_06fd: Expected I4, but got Obj
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected I4, but got Unknown
		//IL_071b: Expected Obj, but got I
		//IL_0731: Expected Obj, but got I
		//IL_078d: Expected Obj, but got I4
		//IL_080f: Expected VT, but got I4
		//IL_07b8: Expected Obj, but got I
		//IL_07ce: Expected Obj, but got I
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_07ea: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I4
		//IL_0882: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4;
		int num;
		if (notes != null)
		{
			bool flag2 = (object)notes == null;
			num = 0;
			if (!flag2)
			{
				string text = notes.text;
				bool flag3 = text == null;
				num = 0;
				if (!flag3)
				{
					nint num2 = (nint)text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v51 (Il2CppClass<System.String>)+160]");
					num = 0;
					obj4 = ((Enum)(object)text).System_002EIConvertible_002EToType((Type)0, (IFormatProvider)null);
					goto IL_0c9d;
				}
			}
			goto IL_0b96;
		}
		num = 0;
		obj4 = null;
		goto IL_0c9d;
		IL_0b96:
		throw new NullReferenceException();
		IL_0a86:
		List<(System.__Canon, bool)> list = (List<(System.__Canon, bool)>)(object)lines;
		if ((object)lines != null)
		{
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
				num = (int)(-1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
				if ((nint)0 >= (nint)1)
				{
					(System.__Canon, bool) tuple = list.get_Item(num);
					if (tuple == ((System.__Canon, bool))(object)0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v25 (System.ValueTuple`2<System.__Canon, System.Boolean>)+10]");
					bool flag4 = (nint)0 == 0;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						List<(System.__Canon, bool)> list2 = (List<(System.__Canon, bool)>)(object)lines;
						if ((object)lines == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v26 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
						num = (int)(-1);
						((List<(System.__Canon, bool)>)(object)lines).RemoveAt(num);
						list = (List<(System.__Canon, bool)>)(object)lines;
						bool flag5 = (object)lines == null;
						object obj6 = !flag5;
						if (obj6 == null)
						{
							break;
						}
						continue;
					}
				}
				int pages = Pages;
				int num3 = pages - 1;
				object obj7 = page - num3;
				bool flag6 = (nint)obj7 < 0;
				int num4 = page ^ num3;
				int num5 = page ^ obj7;
				int num6 = num4 & num5;
				bool flag7 = num6 < 0;
				bool flag8 = flag6 == flag7;
				object obj8 = !flag8;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					num3 = page;
				}
				bool flag9 = page < 0;
				int num7 = page ^ page;
				int num8 = page & num7;
				bool flag10 = num8 < 0;
				bool flag11 = flag9 == flag10;
				object obj10 = !flag11;
				object obj11 = ~obj10;
				if (obj11 == null)
				{
					num3 = 0;
				}
				page = num3;
				return;
			}
		}
		goto IL_0b96;
		IL_0c9d:
		if ((nint)obj4 == read)
		{
			return;
		}
		List<(string, bool)> list3 = lines;
		read = (int)obj4;
		if ((object)lines != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+1C]");
			object obj12 = (nint)0 + (nint)1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+10]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+18]");
				Array.Clear((Array)num9, 0, 0);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj13 = 0;
			object obj14 = this + 120;
			obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v11+E4]");
			bool flag12 = (nint)0 == 0;
			object obj16 = !flag12;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v4-50]");
			bool flag13 = (UnityEngine.Object)0 == null;
			bool flag14 = !flag13;
			object obj17 = !flag14;
			if (obj17 != null)
			{
				return;
			}
			bool flag15 = (object)notes == null;
			num = 0;
			if (!flag15)
			{
				string text2 = notes.text;
				bool flag16 = text2 == null;
				num = 0;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA218]");
					object obj18 = 0;
					string text3 = text2.Replace((string)obj18, (string)obj13);
					bool flag17 = text3 == null;
					num = (int)obj18;
					if (!flag17)
					{
						string[] array = text3.Split('\n', (StringSplitOptions)0);
						bool flag18 = array == null;
						num = 10;
						if (!flag18)
						{
							if (array.Length != 0)
							{
								bool flag19 = array[0] == null;
								num = 10;
								if (flag19)
								{
									goto IL_0b96;
								}
								string text4 = array[0].Trim();
								num = (int)text4;
							}
							else
							{
								num = (int)obj13;
							}
							obj14 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj19 = array.Length;
							if (array.Length < 2)
							{
								goto IL_0a86;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9210]");
							object value = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA200]");
							object obj20 = 0;
							object obj21 = 1;
							int num10 = num;
							while (true)
							{
								bool flag20 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
								object obj22 = !flag20;
								object obj25;
								(System.__Canon, bool) tuple3;
								List<(System.__Canon, bool)> list5;
								string text9;
								string text10;
								object obj24;
								(System.__Canon, bool) tuple2;
								object obj28;
								if (obj22 == null)
								{
									object obj23 = (object)array + obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v19+20]");
									bool flag21 = (nint)0 == 0;
									num = num10;
									if (flag21)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v19+20]");
									string text5 = ((string)0).TrimEnd();
									bool flag22 = text5 == null;
									num = 0;
									if (flag22)
									{
										break;
									}
									if (text5.StartsWith((string)value))
									{
										List<(string, bool)> list4 = lines;
										string text6 = text5.Substring(2);
										obj24 = obj20;
										tuple2 = ((System.__Canon)(object)text6, true);
										bool flag23 = (object)lines == null;
										num = (int)text6;
										if (flag23)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X22_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+10]");
										obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X22_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+1C]");
										object obj26 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X22_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Boolean>>)+10]");
										bool flag24 = (nint)0 == 0;
										object obj27 = !flag24;
										tuple2 = ((System.__Canon, bool))0;
										obj28 = 0;
										tuple3 = ((System.__Canon, bool))0;
										list5 = (List<(System.__Canon, bool)>)(object)lines;
										if (obj27 == null)
										{
											num = 0;
											break;
										}
										goto IL_0994;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9218]");
									object obj29 = 0;
									string text7 = (string)obj29;
									object obj30;
									object obj31;
									if (text5.StartsWith((string)obj29))
									{
										string text8 = text5.Substring(2);
										bool flag25 = text8 == null;
										num = 2;
										if (flag25)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA210]");
										obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA208]");
										obj31 = 0;
										text9 = text8;
										text7 = (string)2;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										obj31 = 0;
										text9 = text5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										obj30 = 0;
									}
									text10 = (string)obj31;
									num = (int)text7;
									while (text10 != null)
									{
										int num11 = typeof(_0021_00210) - text10._stringLength;
										if (text9._stringLength > num11)
										{
											int num12 = text9.LastIndexOf(' ', num11);
											bool flag26 = num12 > 0;
											int num13 = num12;
											if (!flag26)
											{
												num13 = typeof(_0021_00210) - text10._stringLength;
											}
											List<(System.__Canon, bool)> list6 = (List<(System.__Canon, bool)>)(object)lines;
											string text11 = text9.Substring(0, num13);
											string text12 = text10 + text11;
											tuple2 = ((System.__Canon)(object)text12, false);
											bool flag27 = (object)lines == null;
											num = (int)text12;
											if (flag27)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+10]");
											object obj32 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+1C]");
											object obj33 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+10]");
											bool flag28 = (nint)0 == 0;
											num = 0;
											if (flag28)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
											nint num14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v32+18]");
											bool flag29 = num14 < 0;
											object obj34 = !flag29;
											if (obj34 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+10]");
												nint num15 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
												object obj35 = num15 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X23_v13 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
												object obj36 = (nint)0 + (nint)1;
												object obj37 = obj35 + 32;
												obj37 = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											else
											{
												((List<(System.__Canon, bool)>)(object)lines).AddWithResize(((System.__Canon, bool))0);
											}
											string text13 = text9.Substring(num13);
											bool flag30 = text13 == null;
											num = num13;
											if (flag30)
											{
												break;
											}
											string text14 = text13.TrimStart();
											bool flag31 = text14 == null;
											object obj38 = !flag31;
											text10 = (string)obj30;
											tuple2 = ((System.__Canon, bool))0;
											text9 = text14;
											num = 0;
											if (obj38 == null)
											{
												num = 0;
												break;
											}
											continue;
										}
										goto IL_08af;
									}
									break;
								}
								throw new IndexOutOfRangeException();
								IL_08af:
								list5 = (List<(System.__Canon, bool)>)(object)lines;
								string text15 = text10 + text9;
								obj24 = obj20;
								tuple2 = ((System.__Canon)(object)text15, false);
								bool flag32 = (object)lines == null;
								num = (int)text15;
								if (flag32)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X22_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+10]");
								obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X22_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+1C]");
								object obj39 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9210]");
								value = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X22_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+10]");
								bool flag33 = (nint)0 == 0;
								tuple2 = ((System.__Canon, bool))0;
								obj28 = 0;
								tuple3 = ((System.__Canon, bool))0;
								num = 0;
								if (flag33)
								{
									break;
								}
								goto IL_0994;
								IL_0994:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X22_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v20+18]");
								bool flag34 = num16 < 0;
								object obj40 = !flag34;
								if (obj40 == null)
								{
									object obj41 = obj25;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X22_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
									object obj42 = obj41 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X22_v7 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
									object obj43 = (nint)0 + (nint)1;
									object obj44 = obj42 + 32;
									obj44 = tuple3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num = 0;
								}
								else
								{
									list5.AddWithResize(tuple3);
									num = (int)tuple3;
								}
								obj19 = array.Length;
								obj21++;
								bool flag35 = (nint)obj21 < array.Length;
								num10 = num;
								if (flag35)
								{
									continue;
								}
								goto IL_0a86;
							}
						}
					}
				}
			}
		}
		goto IL_0b96;
	}

	private unsafe void Redraw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got Unknown
		//IL_0c3c: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I4
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I4
		//IL_04b2: Expected Obj, but got I
		//IL_04d4: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0c5a: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got Ref
		//IL_0c78: Expected Obj, but got I
		//IL_0ca3: Expected VT, but got Ref
		//IL_0cb9: Expected Obj, but got Ref
		//IL_0cc9: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_051e: Expected VT, but got Ref
		//IL_033b: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_0560: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_0596: Expected Obj, but got I4
		//IL_0483: Expected Obj, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I4
		//IL_05b8: Expected I4, but got Obj
		//IL_05f1: Expected VT, but got I4
		//IL_05f9: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I
		//IL_032e: Expected I4, but got Obj
		//IL_046d: Expected I4, but got Obj
		//IL_065b: Expected Obj, but got I4
		//IL_072e: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I4
		//IL_09cb: Expected Obj, but got I
		//IL_0d03: Expected Obj, but got I
		//IL_068b: Expected Obj, but got I4
		//IL_0765: Expected Obj, but got I
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got Unknown
		//IL_0dc8: Expected Obj, but got Ref
		//IL_0df3: Expected VT, but got Ref
		//IL_0df3: Expected Obj, but got VT
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected Obj, but got Unknown
		//IL_0e3c: Expected Obj, but got I4
		//IL_0e44: Expected VT, but got Ref
		//IL_0e4c: Expected Obj, but got VT
		//IL_0e68: Expected Obj, but got I4
		//IL_0e82: Expected Obj, but got I4
		//IL_0e92: Expected I4, but got VT
		//IL_0cee: Expected Obj, but got I
		//IL_0a24: Expected Obj, but got I4
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected Obj, but got Unknown
		//IL_07d9: Expected Obj, but got I4
		//IL_07ef: Expected Obj, but got I
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected Obj, but got Unknown
		//IL_0a6b: Expected Obj, but got I4
		//IL_0832: Expected Obj, but got I
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected Obj, but got Unknown
		//IL_0a9e: Expected Obj, but got I4
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected Obj, but got Unknown
		//IL_08b5: Expected Obj, but got I4
		//IL_08cb: Expected Obj, but got I
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected Obj, but got Unknown
		//IL_0abc: Expected Obj, but got I
		//IL_0b29: Expected Obj, but got I
		//IL_0b53: Expected Obj, but got I4
		//IL_090e: Expected Obj, but got I
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected Obj, but got Unknown
		//IL_096a: Expected Obj, but got I4
		//IL_0d41: Expected Obj, but got I
		//IL_0d4f: Expected Obj, but got Ref
		//IL_0d7a: Expected VT, but got Ref
		//IL_0d93: Expected Obj, but got I
		//IL_0d9c: Expected Obj, but got I4
		//IL_0da4: Expected VT, but got Ref
		//IL_0ba5: Expected Obj, but got I
		//IL_0bb8: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Read();
		object obj2 = obj;
		object obj3 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(320, 240, (TextureFormat)4, mipChain: true);
			if ((object)texture2D == null)
			{
				goto IL_0bec;
			}
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.hideFlags = (HideFlags)52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1D8]");
			object obj8 = 0;
			texture2D.name = (string)obj8;
			tex = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj10 = this + 88;
			UnityEngine.Object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = 0;
			obj6 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBoardLook.Clear(px, 320, 240);
		GillaBoardLook.Frame(px, 320, 240, 3);
		object obj15 = this + 104;
		bool flag5 = obj15 == null;
		object obj16 = !flag5;
		int num = 240;
		int num2 = 320;
		if (obj16 == null)
		{
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v106+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = titleFont != null;
			bool flag8 = !flag7;
			num = 0;
			int num3 = 0;
			if (!flag8)
			{
				if ((object)titleFont == null)
				{
					goto IL_0bec;
				}
				string baked = titleFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont = default;
				screenFont._002Ector(baked);
				num = 0;
				num3 = (int)screenFont;
			}
			obj15 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = num3;
		}
		object obj20 = this + 112;
		bool flag9 = obj20 == null;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v94+E4]");
			bool flag10 = (nint)0 == 0;
			object obj23 = !flag10;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag11 = textFont != null;
			bool flag12 = !flag11;
			int num4 = 0;
			num = 0;
			if (!flag12)
			{
				if ((object)textFont == null)
				{
					goto IL_0bec;
				}
				string baked2 = textFont.text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ScreenFont screenFont2 = default;
				screenFont2._002Ector(baked2);
				num4 = (int)screenFont2;
				num = 0;
			}
			obj20 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = num4;
		}
		object obj25 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1C0]");
		object line = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v19+E4]");
		bool flag13 = (nint)0 == 0;
		object obj26 = !flag13;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v19+A0]");
		object obj27 = 0;
		object obj29 = default;
		object obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj29, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj31 = default;
		Line((ScreenFont)obj15, 12, 7, (string)line, (ShiftAuth.Style)(&obj31), centred: false);
		object obj32 = obj12;
		object obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj29, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v14+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj35 = default;
		Line(this.text, 12, 25, heading, (ShiftAuth.Style)(&obj35), centred: false);
		GillaBoardLook.Rule(px, 320, 240, 10, 309, 36);
		bool flag14 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v15+10]");
		object obj36 = 0;
		object obj37 = 1;
		int num5 = 36;
		int num6 = 309;
		int num7 = 10;
		int num8 = 240;
		object obj38 = 0;
		object obj48 = default;
		while (true)
		{
			List<(System.__Canon, bool)> list = (List<(System.__Canon, bool)>)(object)lines;
			if ((object)lines == null)
			{
				break;
			}
			object obj39 = page * 18;
			int num9 = (int)(obj38 + obj39);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v28 (System.Collections.Generic.List`1<System.ValueTuple`2<System.__Canon, System.Boolean>>)+18]");
			bool flag15 = (nint)num9 >= (nint)0;
			bool flag16 = flag14;
			object obj40 = obj36;
			object obj41 = obj37;
			ShiftAuth.Style style = (ShiftAuth.Style)num5;
			string text = (string)num6;
			int num10 = num7;
			int num11 = num8;
			if (!flag15)
			{
				(System.__Canon, bool) tuple = ((List<(System.__Canon, bool)>)(object)lines).get_Item(num9);
				object obj42 = obj12;
				int num12 = num9 & 1;
				bool flag17 = num12 == 0;
				object obj43 = !flag17;
				object obj45;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v86+E4]");
					bool flag18 = (nint)0 == 0;
					object obj44 = !flag18;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj42 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v86+A0]");
					obj45 = (nint)0 + (nint)8;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v86+E4]");
					bool flag19 = (nint)0 == 0;
					object obj46 = !flag19;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj42 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v86+A0]");
					obj45 = 0;
				}
				object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj29, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Line((ScreenFont)obj20, 10, 42, (string)tuple, (ShiftAuth.Style)(&obj48), centred: false);
				obj38++;
				int num13 = 42 + 10;
				bool flag20 = (nint)obj38 != 18;
				flag16 = false;
				obj40 = obj45;
				obj41 = 1;
				style = (ShiftAuth.Style)(&obj48);
				text = (string)tuple;
				num10 = 42;
				num11 = 10;
				obj48 = 1;
				flag14 = false;
				obj36 = obj45;
				obj37 = 1;
				num5 = (int)(&obj48);
				num6 = (int)tuple;
				num7 = num13;
				num8 = 10;
				if (flag20)
				{
					continue;
				}
			}
			goto IL_06f7;
		}
		goto IL_0bec;
		IL_06f7:
		int pages = Pages;
		if (pages < 2)
		{
			goto IL_098f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if (array == null)
		{
			goto IL_0bec;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1C8]");
		object obj50 = 0;
		object obj51 = array + 32;
		obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num14 = default;
		string text2 = num14.ToString();
		object obj52 = array + 40;
		obj52 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X23_v13-10]");
		bool flag21 = (nint)0 < (nint)2;
		object obj53 = !flag21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X23_v13-10]");
		object obj54 = -2;
		bool flag22 = obj54 == null;
		object obj55 = ~obj53;
		object obj56 = obj55 | flag22;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1D0]");
			object obj57 = 0;
			object obj58 = array + 48;
			obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int pages2 = Pages;
			string text3 = num14.ToString();
			object obj59 = array + 56;
			obj59 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X23_v17-20]");
			bool flag23 = (nint)0 < (nint)4;
			object obj60 = !flag23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X23_v17-20]");
			object obj61 = -4;
			bool flag24 = obj61 == null;
			object obj62 = ~obj60;
			object obj63 = obj62 | flag24;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1E0]");
				object obj64 = 0;
				object obj65 = array + 64;
				obj65 = obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				string text4 = string.Concat(array);
				object obj66 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v74+E4]");
				bool flag25 = (nint)0 == 0;
				object obj67 = !flag25;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj66 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v74+A0]");
				object obj68 = 0;
				object obj69 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj29, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj70 = default;
				Line((ScreenFont)obj20, 160, 226, text4, (ShiftAuth.Style)(&obj70), centred: true);
				bool flag16 = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v47+10]");
				object obj40 = 0;
				object obj41 = 1;
				ShiftAuth.Style style = (ShiftAuth.Style)(&obj70);
				string text = text4;
				int num10 = 226;
				goto IL_098f;
			}
		}
		goto IL_0bfa;
		IL_098f:
		if (obj3 != null)
		{
			((Texture2D)obj3).SetPixels32(px);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj71 = 0;
			if ((object)tex != null)
			{
				tex.Apply(updateMipmaps: true);
				object obj72 = obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v35+E4]");
				bool flag26 = (nint)0 == 0;
				object obj73 = !flag26;
				if (obj73 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag27 = screen == null;
				bool flag28 = !flag27;
				object obj74 = !flag28;
				if (obj74 != null)
				{
					return;
				}
				object obj75 = this + 96;
				bool flag29 = obj75 == null;
				object obj76 = !flag29;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					obj75 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				if ((object)screen != null)
				{
					screen.GetPropertyBlock((MaterialPropertyBlock)obj75);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1A8]");
					object obj78 = 0;
					object obj79 = obj78;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v42+E4]");
					bool flag30 = (nint)0 == 0;
					object obj80 = !flag30;
					if (obj80 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj75 != null)
					{
						object obj81 = obj78;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v27+A0]");
						object obj82 = 0;
						((MaterialPropertyBlock)obj75).SetTexture((int)obj82, (Texture)tex);
						if ((object)screen != null)
						{
							screen.SetPropertyBlock((MaterialPropertyBlock)obj75);
							return;
						}
					}
				}
			}
		}
		goto IL_0bec;
		IL_0bec:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bfa;
		IL_0bfa:
		throw new IndexOutOfRangeException();
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style, bool centred = default(bool))
	{
		//IL_0067: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected I4, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_031e: Expected I4, but got Obj
		//IL_02cb: Expected Ref, but got VT
		//IL_004b: Expected Ref, but got VT
		//IL_0133: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_029d: Expected VT, but got Ref
		int num2 = default;
		if (font != null)
		{
			if (centred)
			{
				int num = font.DrawCentred(px, 320, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			else
			{
				int num3 = font.Draw(px, 320, 240, num2, y, line, ref *(ShiftAuth.Style*)style);
			}
			return;
		}
		object obj = style.scale - 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num4 = style.scale ^ 1;
		int num5 = style.scale ^ obj;
		int num6 = num4 & num5;
		bool flag3 = num6 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		object obj3 = flag4 & obj2;
		object obj4 = ~obj3;
		int num7 = ((obj4 != null) ? 1 : style.scale);
		bool flag5 = !centred;
		int num8 = (int)font;
		int x2 = num2;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num9 = PixelFont.Measure(line, num7);
			bool flag7 = num9 < 0;
			int num10 = num9 ^ num9;
			int num11 = num9 & num10;
			bool flag8 = num11 < 0;
			bool flag9 = flag7 == flag8;
			object obj8 = !flag9;
			object obj9 = ~obj8;
			int num12 = ((obj9 != null) ? num9 : (num9 + 1));
			x2 = num2 - num12;
			num8 = num7;
		}
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v7+E4]");
			bool flag10 = (nint)0 == 0;
			object obj12 = !flag10;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PixelFont.Draw(px, 320, 240, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), num7);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
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

	public GillaUpdateBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0052: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA220]");
		object obj2 = 0;
		object obj3 = this + 120;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, bool)> list = default;
		list._002Ector();
		object obj4 = this + 128;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		read = -1;
		base._002Ector();
	}

	static GillaUpdateBoard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1A8]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
