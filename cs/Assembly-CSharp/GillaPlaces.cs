using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaPlaces : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass190_0
	{
		public Vector3 hole;

		public Dismemberment keepOff;

		internal void _003CBled_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
			//IL_0036: Expected F4, but got VT
			//IL_0036: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplatter.Around((Vector3)keepOff, (float)hole);
		}
	}

	public GillaProximityDoor.Place[] places;

	private static GillaPlaces instance;

	private int current;

	public static int Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_00f1: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I4
			//IL_00be: Expected I4, but got I8
			//IL_0077: Expected Obj, but got I
			//IL_00d1: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EC8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj5 != null)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v6+A0]");
				object obj8 = 0;
				object obj9 = obj8;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8+28]");
					return 0;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return -1;
		}
	}

	public static string CurrentName
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_01e6: Expected Obj, but got I
			//IL_0208: Expected Obj, but got I4
			//IL_007c: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I8
			//IL_00d5: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got I
			//IL_0164: Expected Obj, but got I
			//IL_0174: Expected Obj, but got I
			//IL_01a9: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EC8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = (UnityEngine.Object)obj5 != null;
			bool flag3 = !flag2;
			string result = null;
			if (!flag3)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7+A0]");
				object obj8 = 0;
				object obj9 = obj8;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v3+28]");
					object obj10 = 0 & 0x80000000L;
					bool flag4 = obj10 == null;
					object obj11 = !flag4;
					if (obj11 != null)
					{
						goto IL_01ae;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v3+20]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v3+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v3+28]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v6+18]");
						if (num >= 0)
						{
							goto IL_01ae;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v3+20]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v3+28]");
						object obj13 = num2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11+20]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v12+10]");
							result = (string)0;
							goto IL_0216;
						}
					}
				}
				return (string)(object)new NullReferenceException();
			}
			goto IL_0216;
			IL_01ae:
			result = null;
			goto IL_0216;
			IL_0216:
			return result;
		}
	}

	public unsafe static bool AreaNamed(string name, out Bounds area)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0242: Expected I4, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		ref Bounds reference = ref *(Bounds*)null;
		_ = 0;
		_ = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_01ed;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v7+A0]");
		object obj9 = 0;
		object obj10 = obj9;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v9+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v9+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X21_v9+18]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X21_v9+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_01ed;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v9+20]");
				object obj13 = (nint)0 + (nint)32;
				object obj14 = 0;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
					object obj15 = !flag4;
					if (obj15 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v7+v158 @ X22_v9*8]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X23_v7+v158 @ X22_v9*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v7+10]");
						bool flag5 = (string)0 == name;
						bool flag6 = !flag5;
						object obj17 = !flag6;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X21_v9+18]");
							obj12 = 0;
							obj14++;
							object obj18 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X21_v9+18]");
							if ((nint)obj18 < 0)
							{
								continue;
							}
							goto IL_01ed;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v7+28]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X24_v7+18]");
						reference = ref *(Bounds*)null;
						return true;
					}
					goto IL_0226;
				}
				goto IL_0234;
			}
		}
		goto IL_0226;
		IL_01ed:
		return false;
		IL_0234:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0226:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0234;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = this;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == this)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+A0]");
			object obj8 = 0;
			obj8 = 0;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void Start()
	{
		//IL_0013: Expected VT, but got I
		//IL_002e: Expected I4, but got I8
		//IL_0048: Expected Obj, but got I4
		Vector3 vector = Eyes();
		IntPtr intPtr = default;
		int num = Find((Vector3)(nint)intPtr);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Apply(num);
		}
	}

	private void LateUpdate()
	{
		//IL_0013: Expected VT, but got I
		//IL_002e: Expected I4, but got I8
		//IL_0048: Expected Obj, but got I4
		Vector3 vector = Eyes();
		IntPtr intPtr = default;
		int num = Find((Vector3)(nint)intPtr);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj = !flag;
		if (obj == null && num != current)
		{
			Apply(num);
		}
		KeepOut();
	}

	private unsafe void KeepOut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I
		//IL_03da: Expected Obj, but got I
		//IL_03fc: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_041a: Expected Obj, but got I
		//IL_0432: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_025b: Expected VT, but got Ref
		//IL_0292: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_033a: Expected VT, but got I4
		//IL_034e: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj8 = obj5;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v1+A0]");
		object obj11 = 0;
		UnityEngine.Object obj12 = (UnityEngine.Object)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			return;
		}
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = (UnityEngine.Object)obj11 == null;
		bool flag8 = !flag7;
		object obj17 = !flag8;
		if (obj17 != null)
		{
			return;
		}
		object obj18 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v5 (UnityEngine.Object)+20]");
		bool flag10 = (UnityEngine.Object)0 == null;
		bool flag11 = !flag10;
		object obj20 = !flag11;
		if (obj20 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v5 (UnityEngine.Object)+A9]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v17+A0]");
		object obj24 = 0;
		bool flag13 = obj24 == null;
		object obj25 = !flag13;
		if (obj25 != null)
		{
			return;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v22+E4]");
		bool flag14 = (nint)0 == 0;
		object obj27 = !flag14;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string roomTag = NetworkBootstrap.RoomTag;
		if (roomTag._stringLength > 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v5 (UnityEngine.Object)+20]");
		Vector3 position = ((Transform)0).position;
		object obj28 = default;
		if (!InMode((Vector3)(&obj28), out *(NetworkBootstrap.Lobby*)null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v1+8]");
		NetworkBootstrap.Lobby going = ((NetworkBootstrap)0).Going;
		if ((nint)obj28 != (nint)going)
		{
			((KillCam)obj11).SendHome();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v5 (UnityEngine.Object)+20]");
			Vector3 position2 = ((Transform)0).position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C57A0]");
			object obj29 = 0;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v35+E4]");
			bool flag15 = (nint)0 == 0;
			object obj31 = !flag15;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int hand = GillaToast.NearerHand((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EE8]");
			object title = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EF0]");
			object line = 0;
			GillaToast.Show(hand, (string)title, (string)line, error: true);
		}
	}

	public unsafe bool InMode(Vector3 at, out NetworkBootstrap.Lobby mode)
	{
		//IL_025a: Expected native int or pointer, but got VT
		//IL_0251: Expected I4, but got Obj
		//IL_000f: Expected Obj, but got I4
		//IL_01fb: Invalid comparison between F4 and I4
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I
		//IL_00b6: Expected VT, but got I
		//IL_00c3: Expected Ref, but got VT
		//IL_0292: Expected Obj, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0222: Expected native int or pointer, but got VT
		//IL_01b2: Expected Obj, but got I4
		//IL_01e8: Expected F4, but got I4
		//IL_02ce: Expected native int or pointer, but got VT
		((Vector3*)(nint)at)->x = 0f;
		GillaProximityDoor.Place[] array = places;
		if (places == null)
		{
			goto IL_0235;
		}
		object obj = array.Length;
		if (array.Length < 1)
		{
			goto IL_01ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F00]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EF8]");
		object value2 = 0;
		object obj2 = 0;
		Vector3 point = default;
		Vector3 vector = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj3 = !flag;
			if (obj3 != null)
			{
				break;
			}
			object obj4 = (object)places + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v10+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v10+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v10+20]");
				Bounds bounds = (Bounds)((nint)0 + (nint)24);
				if (!((Bounds*)bounds)->Internal_Contains(ref point))
				{
					goto IL_0288;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8+10]");
					bool flag2 = ((string)0).Contains((string)value);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X20_v8+10]");
						bool flag3 = ((string)0).Contains((string)value2);
						object obj6 = flag2 | flag3;
						object obj7 = obj6 & 1;
						if (obj7 != null)
						{
							bool flag4 = !flag2;
							object obj8 = !flag4;
							object obj9 = ~obj8;
							float x = ((obj9 != null) ? 1f : (1f + 1f));
							((Vector3*)(nint)at)->x = x;
							goto IL_0288;
						}
						((Vector3*)(nint)at)->x = 0f;
						return false;
					}
				}
			}
			goto IL_0235;
			IL_0288:
			obj = array.Length;
			obj2++;
			bool flag5 = (nint)obj2 < array.Length;
			point = vector;
			if (flag5)
			{
				continue;
			}
			goto IL_01ed;
		}
		goto IL_0243;
		IL_01ed:
		bool flag6 = at.x == 0f;
		return !flag6;
		IL_0235:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0243;
		IL_0243:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public static void Prepare(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0095: Expected VT, but got I4
		//IL_00ab: Expected I4, but got I8
		//IL_00c5: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6+A0]");
		object obj9 = 0;
		int num = ((GillaPlaces)obj9).Find((Vector3)0);
		int num2 = (int)(num & 0x80000000L);
		bool flag4 = num2 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+A0]");
			object obj12 = 0;
			GillaPlaces gillaPlaces = (GillaPlaces)obj12;
			if (num != gillaPlaces.current)
			{
				gillaPlaces.Apply(num);
			}
		}
	}

	private static Vector3 Eyes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_02e2: Expected VT, but got Obj
		//IL_0187: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		NullReferenceException ex;
		if (main != null)
		{
			if ((object)main != null)
			{
				component = main;
				goto IL_02b0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj4;
			}
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v22+A0]");
			object obj10 = 0;
			UnityEngine.Object obj11 = (UnityEngine.Object)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)obj10 != null;
			bool flag6 = !flag5;
			ex = (NullReferenceException)flag5;
			if (flag6)
			{
				goto IL_02da;
			}
			if (obj10 != null)
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v26+E4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X19_v11 (UnityEngine.Object)+20]");
				bool flag8 = (UnityEngine.Object)0 != null;
				bool flag9 = !flag8;
				ex = (NullReferenceException)flag8;
				if (flag9)
				{
					goto IL_02da;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X19_v11 (UnityEngine.Object)+20]");
				component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X19_v11 (UnityEngine.Object)+20]");
				bool flag10 = (nint)0 == 0;
				object obj15 = !flag10;
				if (obj15 != null)
				{
					goto IL_02b0;
				}
			}
		}
		goto IL_021f;
		IL_02b0:
		Transform transform = component.transform;
		if ((object)transform != null)
		{
			return transform.position;
		}
		goto IL_021f;
		IL_021f:
		ex = new NullReferenceException();
		goto IL_02da;
		IL_02da:
		return (Vector3)ex;
	}

	private unsafe int Find(Vector3 at)
	{
		//IL_0109: Expected I4, but got I8
		//IL_0038: Expected Obj, but got I4
		//IL_011c: Expected I4, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_006e: Expected VT, but got I
		//IL_007b: Expected Ref, but got VT
		//IL_0099: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		GillaProximityDoor.Place[] array = places;
		int num = 0;
		Vector3 point = default;
		Vector3 vector = default;
		while (true)
		{
			if (num < array.Length)
			{
				bool flag = num < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = array + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+20]");
					Bounds bounds = (Bounds)((nint)0 + (nint)24);
					bool flag2 = ((Bounds*)bounds)->Internal_Contains(ref point);
					bool flag3 = !flag2;
					object obj3 = !flag3;
					if (obj3 != null)
					{
						break;
					}
					array = places;
					num++;
					bool flag4 = places == null;
					object obj4 = !flag4;
					point = vector;
					if (obj4 == null)
					{
						throw new NullReferenceException();
					}
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (int)ex;
			}
			num = -1;
			break;
		}
		return num;
	}

	private void Apply(int p)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_05ef: Expected Obj, but got I4
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_0436: Expected Obj, but got I
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I8
		//IL_047f: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_052e: Expected Obj, but got I
		//IL_0604: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I4
		//IL_04b0: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_04e3: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_050d: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I8
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I4
		//IL_05b7: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		//IL_02a3: Expected I, but got Obj
		//IL_0330: Expected Obj, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I
		//IL_02e2: Expected I, but got Obj
		//IL_030e: Expected Obj, but got I
		//IL_0313: Expected I, but got Obj
		GillaProximityDoor.Place[] array = places;
		current = p;
		bool flag = array.Length < p;
		object obj = !flag;
		object obj2 = array.Length - p;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			object obj5 = array + p;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X9_v5+20]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X9_v5+20]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj7 = 0;
			int num = p;
			object obj8 = 0;
			object obj9 = 109891584;
			nint num2 = default;
			while (true)
			{
				object obj10 = 0;
				while ((nint)obj10 < array.Length)
				{
					object obj11 = obj8 - 1;
					bool flag4 = obj11 == null;
					object obj12 = !flag4;
					object obj13 = obj10 - p;
					bool flag5 = obj13 == null;
					object obj14 = !flag5;
					object obj15 = ~obj14;
					bool flag6;
					if (obj15 == null)
					{
						object obj16 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v6+38]");
						object obj17 = obj16 - 0;
						flag6 = obj17 == null;
					}
					else
					{
						flag6 = true;
					}
					if ((nint)obj12 != (flag6 ? 1 : 0))
					{
						bool flag7 = (nint)obj10 < array.Length;
						object obj18 = !flag7;
						if (obj18 != null)
						{
							goto end_IL_05e6;
						}
						object obj19 = (object)array + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v19+20]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v20+30]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X28_v6+18]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X28_v6+18]");
							object obj22 = 0 & 0xFFFFFFFFL;
							obj9 = obj21 + 32;
							IntPtr intPtr = num2;
							int num3 = num;
							object obj23 = 0;
							while (true)
							{
								bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
								object obj24 = !flag8;
								if (obj24 != null)
								{
									break;
								}
								object obj25 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v20+E4]");
								bool flag9 = (nint)0 == 0;
								object obj26 = !flag9;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X19_v10+v93 @ X27_v9*8]");
								bool flag10 = (UnityEngine.Object)0 != null;
								bool flag11 = !flag10;
								num2 = unchecked((nint)null);
								num = 0;
								if (!flag11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X19_v10+v93 @ X27_v9*8]");
									bool activeSelf = ((GameObject)0).activeSelf;
									bool flag12 = flag6 == activeSelf;
									num2 = unchecked((nint)null);
									num = 0;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X19_v10+v93 @ X27_v9*8]");
										((GameObject)0).SetActive(flag6);
										num2 = unchecked((nint)null);
										num = (flag6 ? 1 : 0);
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X28_v6+18]");
								obj22 = 0;
								object obj27 = obj23 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X28_v6+18]");
								bool flag13 = (nint)obj27 < 0;
								intPtr = num2;
								num3 = num;
								obj23 = obj27;
								if (flag13)
								{
									continue;
								}
								goto IL_037a;
							}
							goto end_IL_05e6;
						}
						goto IL_037a;
					}
					goto IL_066d;
					IL_066d:
					obj10++;
					if (array != null)
					{
						continue;
					}
					goto IL_0562;
					IL_037a:
					array = places;
					goto IL_066d;
				}
				obj8++;
				if ((nint)obj8 != 2)
				{
					continue;
				}
				bool flag14 = array.Length < p;
				object obj28 = !flag14;
				object obj29 = array.Length - p;
				bool flag15 = obj29 == null;
				object obj30 = ~obj28;
				object obj31 = obj30 | flag15;
				if (obj31 != null)
				{
					break;
				}
				object obj32 = array + p;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X10_v7+20]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5ED8]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v6+38]");
				object obj35 = 0 & 0x80000000L;
				bool flag16 = obj35 == null;
				object obj36 = !flag16;
				string text2;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v6+38]");
					bool flag17 = (nint)0 < (nint)array.Length;
					object obj37 = !flag17;
					if (obj37 != null)
					{
						break;
					}
					GillaProximityDoor.Place[] array2 = array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v6+38]");
					object obj38 = array2 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v14+20]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5ED0]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v15+10]");
					string text = (string)obj40 + (string)0;
					text2 = text;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					object obj41 = 0;
					text2 = (string)obj41;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5EE0]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v8+10]");
				string message = (string)obj34 + (string)0 + text2 + (string)obj43;
				object obj44 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v11+E4]");
				bool flag18 = (nint)0 == 0;
				object obj45 = !flag18;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message);
				return;
				continue;
				end_IL_05e6:
				break;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0562;
		IL_0562:
		throw new NullReferenceException();
	}

	public GillaPlaces()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_004c: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 32;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		current = -1;
		base._002Ector();
	}
}
