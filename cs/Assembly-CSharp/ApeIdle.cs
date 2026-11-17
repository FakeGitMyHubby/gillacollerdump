using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class ApeIdle : MonoBehaviour
{
	public float amount = 0f;

	public float speed;

	private Transform spine;

	private Transform neck;

	private Transform head;

	private Transform armL;

	private Transform armR;

	private Transform foreL;

	private Transform foreR;

	private Quaternion spineRest;

	private Quaternion neckRest;

	private Quaternion headRest;

	private Quaternion armLRest;

	private Quaternion armRRest;

	private Quaternion foreLRest;

	private Quaternion foreRRest;

	private Vector3 rest;

	private float phase;

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_05d8: Expected Obj, but got I
		//IL_0602: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_0b08: Expected Obj, but got I4
		//IL_0b77: Expected Obj, but got I
		//IL_0b8f: Expected Obj, but got I
		//IL_0b97: Expected VT, but got Obj
		//IL_0ba7: Expected Obj, but got I
		//IL_0bb7: Expected Obj, but got I
		//IL_0bc7: Expected Obj, but got I
		//IL_0b59: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I
		//IL_0c32: Expected Obj, but got I
		//IL_0c4a: Expected Obj, but got I
		//IL_0c52: Expected VT, but got Obj
		//IL_0c62: Expected Obj, but got I
		//IL_0c72: Expected Obj, but got I
		//IL_0c82: Expected Obj, but got I
		//IL_058e: Expected Obj, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_0c14: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_0ced: Expected Obj, but got I
		//IL_0d05: Expected Obj, but got I
		//IL_0d0d: Expected VT, but got Obj
		//IL_0d1d: Expected Obj, but got I
		//IL_0d2d: Expected Obj, but got I
		//IL_0d3d: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_0ccf: Expected Obj, but got I4
		//IL_0487: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		//IL_0397: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_02df: Expected I4, but got Obj
		//IL_04da: Expected Obj, but got I4
		//IL_04e2: Expected I4, but got Obj
		//IL_0da8: Expected Obj, but got I
		//IL_0dc0: Expected Obj, but got I
		//IL_0dc8: Expected VT, but got Obj
		//IL_0dd8: Expected Obj, but got I
		//IL_0de8: Expected Obj, but got I
		//IL_0df8: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I4
		//IL_0531: Expected Obj, but got I4
		//IL_0539: Expected I4, but got Obj
		//IL_0d8a: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I4
		//IL_0418: Expected I4, but got Obj
		//IL_024f: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_0e63: Expected Obj, but got I
		//IL_0e7b: Expected Obj, but got I
		//IL_0e83: Expected VT, but got Obj
		//IL_0e93: Expected Obj, but got I
		//IL_0ea3: Expected Obj, but got I
		//IL_0eb3: Expected Obj, but got I
		//IL_0e45: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_027f: Expected I4, but got Obj
		//IL_0f1e: Expected Obj, but got I
		//IL_0f36: Expected Obj, but got I
		//IL_0f3e: Expected VT, but got Obj
		//IL_0f4e: Expected Obj, but got I
		//IL_0f5e: Expected Obj, but got I
		//IL_0f6e: Expected Obj, but got I
		//IL_0f00: Expected Obj, but got I4
		//IL_0fc8: Expected Obj, but got I
		//IL_0fe0: Expected Obj, but got I
		//IL_0fe8: Expected VT, but got Obj
		//IL_0ff8: Expected Obj, but got I
		//IL_1008: Expected Obj, but got I
		//IL_1018: Expected Obj, but got I
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected Obj, but got Unknown
		//IL_0a50: Invalid comparison between F8 and I4
		//IL_0a5f: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj3 = default;
		if (obj3 == null)
		{
			goto IL_0aab;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
		object obj4 = 0;
		object obj5 = this + 72;
		object obj6 = this + 88;
		object obj7 = this + 64;
		object obj8 = this + 80;
		object obj9 = this + 40;
		object obj10 = this + 48;
		object obj11 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
		bool flag = (nint)0 < (nint)1;
		int num = 1;
		if (flag)
		{
			goto IL_05c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7720]");
		object obj13 = 0;
		object obj14 = obj;
		object obj15 = 0;
		while (true)
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
			object obj16 = !flag2;
			if (obj16 != null)
			{
				break;
			}
			object obj17 = obj3 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v75+20]");
			object obj20;
			object obj21;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v75+20]");
				string text = ((UnityEngine.Object)0).name;
				bool flag3 = text == null;
				num = 0;
				if (!flag3)
				{
					if (text._stringLength == 10)
					{
						char c = text.get_Chars(0);
						int num2 = c & 0xFFFF;
						if (num2 != 108)
						{
							bool flag4 = num2 != 117;
							obj14 = 0;
							num = 0;
							if (flag4)
							{
								goto IL_057e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7728]");
							object obj18 = 0;
							bool flag5 = text == (string)obj18;
							bool flag6 = !flag5;
							object obj19 = !flag6;
							obj20 = 0;
							obj21 = obj7;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7740]");
								object obj22 = 0;
								bool flag7 = text == (string)obj22;
								bool flag8 = !flag7;
								object obj23 = !flag8;
								obj20 = 0;
								obj21 = obj5;
								if (obj23 == null)
								{
									obj14 = 0;
									num = (int)obj22;
									goto IL_057e;
								}
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7730]");
							object obj24 = 0;
							bool flag9 = text == (string)obj24;
							bool flag10 = !flag9;
							object obj25 = !flag10;
							obj20 = 0;
							obj21 = obj8;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7738]");
								object obj26 = 0;
								bool flag11 = text == (string)obj26;
								bool flag12 = !flag11;
								object obj27 = !flag12;
								obj20 = 0;
								obj21 = obj6;
								if (obj27 == null)
								{
									obj14 = 0;
									num = (int)obj26;
									goto IL_057e;
								}
							}
						}
						goto IL_0547;
					}
					if (text._stringLength != 5)
					{
						bool flag13 = text._stringLength != 4;
						num = 0;
						if (!flag13)
						{
							char c2 = text.get_Chars(0);
							int num3 = c2 & 0xFFFF;
							if (num3 != 104)
							{
								bool flag14 = num3 != 110;
								obj14 = 0;
								num = 0;
								if (!flag14)
								{
									bool flag15 = text == (string)obj13;
									bool flag16 = !flag15;
									object obj28 = !flag16;
									obj20 = 0;
									obj21 = obj10;
									if (obj28 != null)
									{
										goto IL_0547;
									}
									obj14 = 0;
									num = (int)obj13;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
								object obj29 = 0;
								bool flag17 = text == (string)obj29;
								bool flag18 = !flag17;
								obj20 = 0;
								obj21 = obj11;
								obj14 = 0;
								num = (int)obj29;
								if (!flag18)
								{
									goto IL_0547;
								}
							}
						}
					}
					else
					{
						bool flag19 = text == (string)obj12;
						bool flag20 = !flag19;
						object obj30 = !flag20;
						obj20 = 0;
						obj21 = obj9;
						if (obj30 != null)
						{
							goto IL_0547;
						}
						obj14 = 0;
						num = (int)obj12;
					}
				}
				goto IL_057e;
			}
			goto IL_0aab;
			IL_0547:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v75+20]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj14 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v75+20]");
			num = 0;
			goto IL_057e;
			IL_057e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
			obj4 = 0;
			obj15++;
			object obj31 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+18]");
			bool flag21 = (nint)obj31 < 0;
			obj2 = obj14;
			if (flag21)
			{
				continue;
			}
			goto IL_05c8;
		}
		goto IL_0ab9;
		IL_05c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj32 = 0;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v9+E4]");
		bool flag22 = (nint)0 == 0;
		object obj34 = !flag22;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Quaternion quaternion = default;
		object obj40 = default;
		if ((UnityEngine.Object)obj9 != null)
		{
			if (obj9 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation = ((Transform)obj9).localRotation;
			UnityEngine.Object obj35 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj36 = 0;
			object obj37 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v71+A0]");
			object obj38 = 0;
			quaternion = (Quaternion)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v72+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v72+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v72+C]");
			object obj41 = 0;
			UnityEngine.Object obj35 = null;
		}
		object obj42 = obj32;
		spineRest = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v14+E4]");
		bool flag23 = (nint)0 == 0;
		object obj43 = !flag23;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (neck != null)
		{
			if (obj10 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation2 = ((Transform)obj10).localRotation;
			UnityEngine.Object obj44 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj45 = 0;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v64+A0]");
			object obj47 = 0;
			quaternion = (Quaternion)obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v65+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v65+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v65+C]");
			object obj41 = 0;
			UnityEngine.Object obj44 = null;
		}
		object obj48 = obj32;
		neckRest = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v19+E4]");
		bool flag24 = (nint)0 == 0;
		object obj49 = !flag24;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (head != null)
		{
			if (obj11 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation3 = ((Transform)obj11).localRotation;
			UnityEngine.Object obj50 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj51 = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v57+A0]");
			object obj53 = 0;
			quaternion = (Quaternion)obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v58+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v58+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v58+C]");
			object obj41 = 0;
			UnityEngine.Object obj50 = null;
		}
		object obj54 = obj32;
		headRest = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v24+E4]");
		bool flag25 = (nint)0 == 0;
		object obj55 = !flag25;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (armL != null)
		{
			if (obj7 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation4 = ((Transform)obj7).localRotation;
			UnityEngine.Object obj56 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj57 = 0;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v50+A0]");
			object obj59 = 0;
			quaternion = (Quaternion)obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v51+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v51+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v51+C]");
			object obj41 = 0;
			UnityEngine.Object obj56 = null;
		}
		object obj60 = obj32;
		armLRest = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v29+E4]");
		bool flag26 = (nint)0 == 0;
		object obj61 = !flag26;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (armR != null)
		{
			if (obj5 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation5 = ((Transform)obj5).localRotation;
			UnityEngine.Object obj62 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj63 = 0;
			object obj64 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v42+A0]");
			object obj65 = 0;
			quaternion = (Quaternion)obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v43+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v43+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v43+C]");
			object obj41 = 0;
			UnityEngine.Object obj62 = null;
		}
		object obj66 = obj32;
		armRRest = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v34+E4]");
		bool flag27 = (nint)0 == 0;
		object obj67 = !flag27;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (foreL != null)
		{
			if (obj8 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation6 = ((Transform)obj8).localRotation;
			UnityEngine.Object obj68 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj69 = 0;
			object obj70 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v34+A0]");
			object obj71 = 0;
			quaternion = (Quaternion)obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v35+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v35+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v35+C]");
			object obj41 = 0;
			UnityEngine.Object obj68 = null;
		}
		object obj72 = obj32;
		foreLRest = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v39+E4]");
		bool flag28 = (nint)0 == 0;
		object obj73 = !flag28;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (foreR != null)
		{
			if (obj6 == null)
			{
				goto IL_0aab;
			}
			Quaternion localRotation7 = ((Transform)obj6).localRotation;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
			object obj74 = 0;
			object obj75 = obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v26+A0]");
			object obj76 = 0;
			quaternion = (Quaternion)obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v27+4]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v27+8]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v27+C]");
			object obj41 = 0;
		}
		foreRRest = quaternion;
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 localPosition = transform.localPosition;
			rest = (Vector3)quaternion;
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Vector3 position = transform2.position;
				Transform transform3 = base.transform;
				if ((object)transform3 != null)
				{
					Vector3 position2 = transform3.position;
					Quaternion quaternion2 = quaternion;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
					object obj77 = quaternion2 * 0;
					object obj78 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A89C]");
					object obj79 = obj78 * 0;
					object obj80 = obj77 + obj79;
					double num4 = (double)obj80 / 20.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					double num5 = num4 * 20.0;
					double num6 = (double)obj80 - num5;
					bool flag29 = num6 < 0.0;
					double num7 = 0.0;
					if (!flag29)
					{
						bool flag30 = !(num6 > 20.0);
						num7 = num6;
						if (!flag30)
						{
							num7 = 20.0;
						}
					}
					phase = (float)num7;
					return;
				}
			}
		}
		goto IL_0aab;
		IL_0ab9:
		throw new IndexOutOfRangeException();
		IL_0aab:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ab9;
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1870: Expected Obj, but got I4
		//IL_005d: Expected VT, but got I4
		//IL_03d2: Expected Obj, but got I4
		//IL_0417: Expected VT, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0701: Expected Obj, but got I4
		//IL_012d: Expected VT, but got Obj
		//IL_076e: Expected VT, but got I4
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got VT
		//IL_019b: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02e5: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_038a: Expected VT, but got I4
		//IL_03a3: Expected VT, but got I4
		//IL_0af2: Expected Obj, but got I4
		//IL_04a1: Expected VT, but got Obj
		//IL_0b37: Expected VT, but got I4
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Obj, but got Unknown
		//IL_04d9: Expected Obj, but got VT
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_06b9: Expected VT, but got I4
		//IL_06d2: Expected VT, but got I4
		//IL_0e92: Expected Obj, but got I4
		//IL_084d: Expected VT, but got Obj
		//IL_0ed7: Expected VT, but got I4
		//IL_089e: Expected Obj, but got VT
		//IL_08bb: Expected Obj, but got I
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected Obj, but got Unknown
		//IL_0a05: Expected Obj, but got I
		//IL_0a22: Expected Obj, but got I
		//IL_0aaa: Expected VT, but got I4
		//IL_0ac3: Expected VT, but got I4
		//IL_1260: Expected Obj, but got I4
		//IL_12a5: Expected VT, but got I4
		//IL_0c5d: Expected Obj, but got I
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected Obj, but got Unknown
		//IL_0dad: Expected Obj, but got I
		//IL_0dca: Expected Obj, but got I
		//IL_0e52: Expected VT, but got I4
		//IL_0e5a: Expected VT, but got F8
		//IL_0e63: Expected VT, but got I4
		//IL_15b7: Expected Obj, but got I4
		//IL_102b: Expected Obj, but got I
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Expected Obj, but got Unknown
		//IL_117b: Expected Obj, but got I
		//IL_1198: Expected Obj, but got I
		//IL_1220: Expected VT, but got I4
		//IL_1228: Expected VT, but got F8
		//IL_1231: Expected VT, but got I4
		//IL_13ae: Expected Obj, but got I
		//IL_1419: Expected Obj, but got I
		//IL_1471: Expected Obj, but got I
		//IL_1577: Expected VT, but got I4
		//IL_157f: Expected VT, but got F8
		//IL_1588: Expected VT, but got I4
		//IL_16a4: Expected Obj, but got I
		//IL_179a: Expected VT, but got I4
		//IL_181c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		float time = Time.time;
		float num = speed;
		object obj2 = obj;
		float num2 = time * speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num3 = num2 + phase;
		bool flag2 = spine != null;
		bool flag3 = !flag2;
		Quaternion quaternion = (Quaternion)0;
		float num4 = num3;
		float num5 = amount;
		object obj7 = default;
		object obj9 = default;
		Vector3 euler = default;
		float num22 = default;
		float num29 = default;
		float num30 = default;
		float num31 = default;
		float num32 = default;
		object obj18 = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B1D0]");
			object obj5 = default;
			object obj4 = 0 * obj5;
			float num6 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE40]");
			float num7 = num6 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num8 = amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
			float num9 = num8 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4D8]");
			object obj6 = 0 * obj7;
			float num10 = num9 * num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj8 = obj6 * obj4;
			Vector3 vector = (Vector3)(obj8 * obj9);
			float num11 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			float num12 = num11 * 0f;
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+6C]");
			float num13 = 0f * amount;
			object obj10 = spineRest * vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+6C]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj11 = num14 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+68]");
			float num15 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+6C]");
			float num16 = 0f * num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+64]");
			float num17 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+6C]");
			object obj12 = 0 * vector;
			float num18 = (float)spineRest * amount;
			float num19 = num13 - (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+64]");
			float num20 = 0f * num12;
			Quaternion quaternion3 = spineRest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj13 = quaternion3 * 0;
			float num21 = (float)obj11 + num15;
			num22 = (float)spineRest * num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+68]");
			float num23 = 0f * num12;
			float num24 = num16 + num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+68]");
			object obj14 = 0 * vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+64]");
			object obj15 = 0 * vector;
			float num25 = (float)obj12 + num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+64]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj16 = num26 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+68]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj17 = num27 * 0;
			float num28 = num19 - num20;
			num29 = num22 + num21;
			num30 = (float)obj14 + num24;
			num31 = (float)obj16 + num25;
			num32 = num28 - (float)obj17;
			num5 = num29 - (float)obj15;
			num = num30 - (float)obj13;
			num4 = num31 - num23;
			spine.localRotation = (Quaternion)0;
			euler = vector;
			obj9 = obj18;
			quaternion = (Quaternion)0;
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = neck != null;
		bool flag6 = !flag5;
		Quaternion quaternion4 = (Quaternion)0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BB48]");
			object obj21 = 0 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B370]");
			object obj22 = obj21 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B290]");
			object obj23 = 0 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj24 = obj23 * obj22;
			object obj25 = default;
			Vector3 vector2 = (Vector3)(obj24 * obj25);
			Quaternion quaternion5 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+7C]");
			float num33 = 0f * num32;
			object obj26 = neckRest * vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+7C]");
			object obj27 = 0 * obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+78]");
			float num34 = 0f * num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+7C]");
			object obj28 = 0 * obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+74]");
			float num35 = 0f * num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+7C]");
			object obj29 = 0 * vector2;
			float num36 = (float)neckRest * num32;
			float num37 = num33 - (float)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+74]");
			object obj30 = 0 * obj25;
			object obj31 = neckRest * obj22;
			float num38 = (float)obj27 + num34;
			num22 = (float)neckRest * (float)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+78]");
			object obj32 = 0 * obj25;
			float num39 = (float)obj28 + num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+78]");
			object obj33 = 0 * vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+74]");
			object obj34 = 0 * vector2;
			float num40 = (float)obj29 + num36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+74]");
			object obj35 = 0 * obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+78]");
			object obj36 = 0 * obj22;
			float num41 = num37 - (float)obj30;
			num29 = num22 + num38;
			num30 = (float)obj33 + num39;
			num31 = (float)obj35 + num40;
			num32 = num41 - (float)obj36;
			num5 = num29 - (float)obj34;
			num = num30 - (float)obj31;
			num4 = num31 - (float)obj32;
			neck.localRotation = (Quaternion)0;
			euler = vector2;
			obj9 = obj18;
			quaternion4 = (Quaternion)0;
		}
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj38 = !flag7;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = head != null;
		bool flag9 = !flag8;
		double num42 = num22;
		double num43 = num31;
		double num44 = num30;
		double num45 = num29;
		double num46 = num32;
		Quaternion quaternion6 = (Quaternion)0;
		double num47 = num;
		double num48 = num5;
		if (!flag9)
		{
			float num49 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A854]");
			float num50 = num49 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C358]");
			object obj39 = 0 * obj7;
			float num51 = num50 + 2f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			double num52 = (double)amount * 2.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C290]");
			object obj40 = 0 * obj7;
			double num53 = num52 * (double)num51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj41 = obj40 * obj39;
			Vector3 vector3 = (Vector3)(obj41 * obj9);
			double num54 = num53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num55 = num54 * 0.0;
			Quaternion quaternion7 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+8C]");
			float num56 = 0f * amount;
			object obj42 = headRest * vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+8C]");
			nint num57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj43 = num57 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+88]");
			float num58 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+8C]");
			double num59 = 0.0 * num55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+84]");
			float num60 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+8C]");
			object obj44 = 0 * vector3;
			float num61 = (float)headRest * amount;
			float num62 = num56 - (float)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+84]");
			double num63 = 0.0 * num55;
			Quaternion quaternion8 = headRest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj45 = quaternion8 * 0;
			float num64 = (float)obj43 + num58;
			num42 = (double)headRest * num55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+88]");
			double num65 = 0.0 * num55;
			double num66 = num59 + (double)num60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+88]");
			object obj46 = 0 * vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+84]");
			object obj47 = 0 * vector3;
			float num67 = (float)obj44 + num61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+84]");
			nint num68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj48 = num68 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+88]");
			nint num69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj49 = num69 * 0;
			double num70 = (double)num62 - num63;
			num45 = num42 + (double)num64;
			num44 = (double)obj46 + num66;
			float num71 = (float)obj48 + num67;
			num46 = num70 - (double)obj49;
			num48 = num45 - (double)obj47;
			num47 = num44 - (double)obj45;
			num4 = num71 - (float)num65;
			head.localRotation = (Quaternion)0;
			num43 = num71;
			euler = vector3;
			quaternion6 = (Quaternion)0;
		}
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj51 = !flag10;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = armL != null;
		bool flag12 = !flag11;
		Quaternion quaternion9 = (Quaternion)0;
		if (!flag12)
		{
			float num72 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			float num73 = num72 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num74 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC04]");
			float num75 = num74 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			double num76 = (double)amount * 3.5;
			double num77 = (double)amount * 2.5;
			double num78 = num76 * (double)num73;
			double num79 = num77 * (double)num75;
			double num80 = num78;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num81 = num80 * 0.0;
			double num82 = num79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num83 = num82 * 0.0;
			Quaternion quaternion10 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+9C]");
			float num84 = 0f * amount;
			double num85 = (double)armLRest * num83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+9C]");
			nint num86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj52 = num86 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+98]");
			float num87 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+9C]");
			double num88 = 0.0 * num81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+94]");
			float num89 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+9C]");
			double num90 = 0.0 * num83;
			float num91 = (float)armLRest * amount;
			double num92 = (double)num84 - num85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+94]");
			double num93 = 0.0 * num81;
			Quaternion quaternion11 = armLRest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj53 = quaternion11 * 0;
			float num94 = (float)obj52 + num87;
			num42 = (double)armLRest * num81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+98]");
			double num95 = 0.0 * num81;
			double num96 = num88 + (double)num89;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+98]");
			double num97 = 0.0 * num83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+94]");
			double num98 = 0.0 * num83;
			double num99 = num90 + (double)num91;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+94]");
			nint num100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj54 = num100 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+98]");
			nint num101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj55 = num101 * 0;
			double num102 = num92 - num93;
			num45 = num42 + (double)num94;
			num44 = num97 + num96;
			num43 = (double)obj54 + num99;
			num46 = num102 - (double)obj55;
			num48 = num45 - num98;
			num47 = num44 - (double)obj53;
			num4 = (float)num43 - (float)num95;
			armL.localRotation = (Quaternion)0;
			euler = (Vector3)num81;
			quaternion9 = (Quaternion)0;
		}
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v25+E4]");
		bool flag13 = (nint)0 == 0;
		object obj57 = !flag13;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = armR != null;
		bool flag15 = !flag14;
		Quaternion quaternion12 = (Quaternion)0;
		if (!flag15)
		{
			float num103 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			float num104 = num103 * 0f;
			float num105 = num104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
			float num106 = num105 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num107 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC04]");
			float num108 = num107 * 0f;
			float num109 = num108;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			float num110 = num109 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			double num111 = (double)amount * 3.5;
			double num112 = (double)amount * 2.5;
			double num113 = num111 * (double)num106;
			double num114 = num112 * (double)num110;
			double num115 = num113;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num116 = num115 * 0.0;
			double num117 = num114;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num118 = num117 * 0.0;
			Quaternion quaternion13 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+AC]");
			float num119 = 0f * amount;
			double num120 = (double)armRRest * num118;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+AC]");
			nint num121 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj58 = num121 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A8]");
			float num122 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+AC]");
			double num123 = 0.0 * num116;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A4]");
			float num124 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+AC]");
			double num125 = 0.0 * num118;
			float num126 = (float)armRRest * amount;
			double num127 = (double)num119 - num120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A4]");
			double num128 = 0.0 * num116;
			Quaternion quaternion14 = armRRest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj59 = quaternion14 * 0;
			float num129 = (float)obj58 + num122;
			num42 = (double)armRRest * num116;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A8]");
			double num130 = 0.0 * num116;
			double num131 = num123 + (double)num124;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A8]");
			double num132 = 0.0 * num118;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A4]");
			double num133 = 0.0 * num118;
			double num134 = num125 + (double)num126;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A4]");
			nint num135 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj60 = num135 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+A8]");
			nint num136 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj61 = num136 * 0;
			double num137 = num127 - num128;
			num45 = num42 + (double)num129;
			num44 = num132 + num131;
			num43 = (double)obj60 + num134;
			num46 = num137 - (double)obj61;
			num48 = num45 - num133;
			num47 = num44 - (double)obj59;
			num4 = (float)num43 - (float)num130;
			armR.localRotation = (Quaternion)0;
			euler = (Vector3)num116;
			quaternion12 = (Quaternion)0;
		}
		object obj62 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v30+E4]");
		bool flag16 = (nint)0 == 0;
		object obj63 = !flag16;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = foreL != null;
		bool flag18 = !flag17;
		Quaternion quaternion15 = (Quaternion)0;
		if (!flag18)
		{
			float num138 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
			float num139 = num138 * 0f;
			float num140 = num139;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num141 = num140 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			double num142 = (double)amount * 4.0;
			double num143 = num142 * (double)num141;
			double num144 = num143;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num145 = num144 * 0.0;
			Quaternion quaternion16 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+BC]");
			double num146 = 0.0 * num46;
			double num147 = (double)foreLRest * num145;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+BC]");
			float num148 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B8]");
			double num149 = 0.0 * num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+BC]");
			nint num150 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj64 = num150 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B4]");
			double num151 = 0.0 * num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+BC]");
			double num152 = 0.0 * num145;
			double num153 = (double)foreLRest * num46;
			double num154 = num146 - num147;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B4]");
			nint num155 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj65 = num155 * 0;
			float num156 = (float)foreLRest * amount;
			float num157 = num148 + (float)num149;
			double num158 = (double)foreLRest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			num42 = num158 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B8]");
			nint num159 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj66 = num159 * 0;
			double num160 = (double)obj64 + num151;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B8]");
			double num161 = 0.0 * num145;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B4]");
			double num162 = 0.0 * num145;
			double num163 = num152 + num153;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B4]");
			float num164 = 0f * amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+B8]");
			float num165 = 0f * amount;
			double num166 = num154 - (double)obj65;
			num45 = num42 + (double)num157;
			num44 = num161 + num160;
			num43 = (double)num164 + num163;
			num46 = num166 - (double)num165;
			num48 = num45 - num162;
			num47 = num44 - (double)num156;
			num4 = (float)num43 - (float)obj66;
			foreL.localRotation = (Quaternion)0;
			euler = (Vector3)num145;
			quaternion15 = (Quaternion)0;
		}
		object obj67 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v35+E4]");
		bool flag19 = (nint)0 == 0;
		object obj68 = !flag19;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (foreR != null)
		{
			float num167 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB8]");
			float num168 = num167 * 0f;
			float num169 = num168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE44]");
			float num170 = num169 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			double num171 = (double)amount * 4.0;
			double num172 = num171 * (double)num170;
			double num173 = num172;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num174 = num173 * 0.0;
			Quaternion quaternion17 = Quaternion.Internal_FromEulerRad(ref euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+CC]");
			nint num175 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj69 = num175 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+C4]");
			double num176 = 0.0 * num46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+CC]");
			double num177 = 0.0 * num174;
			double num178 = (double)foreRRest * num46;
			float num179 = (float)foreRRest * amount;
			double num180 = (double)foreRRest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			num42 = num180 * 0.0;
			double num181 = (double)obj69 + num176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+C8]");
			double num182 = 0.0 * num174;
			double num183 = num177 + num178;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApeIdle)+C4]");
			float num184 = 0f * amount;
			num44 = num182 + num181;
			num43 = (double)num184 + num183;
			num47 = num44 - (double)num179;
			foreR.localRotation = (Quaternion)0;
		}
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 localScale = transform2.localScale;
		float num185 = num3 * 1.5f;
		float num186 = amount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC40]");
		float num187 = num186 * 0f;
		float num188 = num185;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float num189 = num188 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		transform.localPosition = (Vector3)0;
	}
}
