using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.XR;

public class GillaKeycardReader : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public GillaItemDirector _003C_003E4__this;

		public bool online;

		internal bool _003CLying_003Eb__0(GillaItem i)
		{
			//IL_02ec: Expected I4, but got Obj
			//IL_006d: Expected Obj, but got I4
			//IL_0094: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I
			//IL_00dc: Expected Obj, but got I4
			//IL_0125: Expected Obj, but got I4
			//IL_0143: Expected Obj, but got I
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected Obj, but got Unknown
			//IL_0175: Expected Obj, but got I4
			//IL_01ac: Expected Obj, but got I
			//IL_01d6: Expected Obj, but got I4
			if ((object)i != null)
			{
				if (~(i.recycles ? 1u : 0u) == 0)
				{
					if ((object)_003C_003E4__this == null)
					{
						goto IL_02de;
					}
					bool flag = _003C_003E4__this.Stays(i);
					bool flag2 = !flag;
					object obj = !flag2;
					if (obj == null)
					{
						bool flag3 = (byte)(~(i.Gone__BackingField ? 1u : 0u)) != 0;
						object obj2 = !flag3;
						if (obj2 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8D28]");
							object obj3 = 0;
							object obj4 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+E4]");
							bool flag4 = (nint)0 == 0;
							object obj5 = !flag4;
							if (obj5 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag5 = GillaBoltShop.Sells(i.label);
							bool flag6 = !flag5;
							object obj6 = !flag6;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1140]");
								object obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj9 = default;
								object obj8 = obj9 & 1;
								bool flag7 = obj8 == null;
								object obj10 = !flag7;
								if (obj10 == null)
								{
									if (~(online ? 1u : 0u) == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
										object obj11 = 0;
										object obj12 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v20+E4]");
										bool flag8 = (nint)0 == 0;
										object obj13 = !flag8;
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (!((UnityEngine.Object)i.Net__BackingField != (UnityEngine.Object)null))
										{
											goto IL_025c;
										}
										if ((object)i.Net__BackingField != null)
										{
											return i.Net__BackingField.Live;
										}
									}
									else
									{
										GillaItemDirector gillaItemDirector = _003C_003E4__this;
										if ((object)_003C_003E4__this != null)
										{
											GameObject gameObject = i.gameObject;
											if ((object)gillaItemDirector.local != null)
											{
												return ((List<System.__Canon>)(object)gillaItemDirector.local).Contains((System.__Canon)(object)gameObject);
											}
										}
									}
									goto IL_02de;
								}
							}
						}
					}
				}
				goto IL_025c;
			}
			goto IL_02de;
			IL_025c:
			return false;
			IL_02de:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public GillaDoor door;

	public Renderer strip;

	public float reach;

	public float handReach;

	public float stayOpen = 12f;

	public AudioClip acceptSound;

	public AudioClip denySound;

	public Color lockedColour;

	public Color openColour;

	private static readonly int BaseColorId;

	private const float Again = default(float);

	private MaterialPropertyBlock block;

	private int shown = -1;

	private bool touching;

	private float nextTry;

	private float openSince;

	public bool ShowsOpen
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = shown - 1;
			return obj == null;
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0660: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_0698: Expected Obj, but got I4
		//IL_07ee: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0374: Expected Obj, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected I4, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_042d: Invalid comparison between F4 and I4
		//IL_0203: Expected Obj, but got I4
		//IL_06c9: Expected Obj, but got I
		//IL_06f3: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_02aa: Expected F4, but got I
		//IL_072b: Expected Obj, but got I4
		//IL_02eb: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I4
		//IL_0848: Expected Obj, but got I
		//IL_086a: Expected Obj, but got I4
		//IL_026e: Expected F4, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_028c: Expected Obj, but got I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0362: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_077e: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I4
		//IL_05cb: Expected Obj, but got I4
		//IL_05d4: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I4
		//IL_0888: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I
		//IL_0559: Expected Obj, but got I
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_0631: Expected Obj, but got I4
		//IL_0598: Unsupported input type for neg.
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
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
		if (door == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v10+A0]");
		object obj9 = 0;
		bool flag4 = CardHere();
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7;
		if ((UnityEngine.Object)obj9 != null)
		{
			bool flag6 = HandHere((Player)obj9);
			flag7 = flag6;
		}
		else
		{
			flag7 = false;
		}
		bool isOpen = door.IsOpen;
		bool flag8 = !isOpen;
		object obj12 = !flag8;
		object obj13 = 0;
		object clip;
		float buzz;
		if (obj12 == null)
		{
			float time = Time.time;
			float num = nextTry;
			bool flag9 = time < nextTry;
			obj13 = 0;
			if (!flag9)
			{
				if (flag4 && !door.Busy)
				{
					float time2 = Time.time;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num = 0f;
					float num2 = time2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					float num3 = num2 + 0f;
					nextTry = num3;
					door.Press();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60A8]");
					object obj14 = 0;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v76+E4]");
					bool flag10 = (nint)0 == 0;
					object obj16 = !flag10;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaQuests.Report((GillaQuests.Stat)4, 1);
					clip = this + 64;
					buzz = 0.5f;
					obj13 = 0;
					goto IL_06a6;
				}
				bool flag11 = !flag7;
				obj13 = 0;
				if (!flag11)
				{
					bool flag12 = (byte)(~(touching ? 1u : 0u)) != 0;
					object obj17 = !flag12;
					obj13 = 0;
					if (obj17 == null)
					{
						float time3 = Time.time;
						float num4 = time3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
						num = num4 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
						buzz = 0f;
						clip = this + 72;
						nextTry = num;
						obj13 = 0;
						goto IL_06a6;
					}
				}
			}
		}
		goto IL_0367;
		IL_06a6:
		Beep((AudioClip)clip, buzz);
		goto IL_0367;
		IL_0367:
		object obj18 = flag4 | flag7;
		bool flag13 = (byte)(obj18 & 1) != 0;
		touching = flag13;
		if (!door.IsOpen || door.IsMoving)
		{
			openSince = -1f;
		}
		else
		{
			float num5 = openSince;
			if (openSince < 0f)
			{
				num5 = Time.time;
				openSince = num5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v32+E4]");
			bool flag14 = (nint)0 == 0;
			object obj21 = !flag14;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v36+E4]");
			bool flag15 = (nint)0 == 0;
			object obj23 = !flag15;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj19;
			}
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v36+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+E4]");
			bool flag16 = (nint)0 == 0;
			object obj26 = !flag16;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag17 = (UnityEngine.Object)obj25 != null;
			bool flag18 = !flag17;
			object obj27 = 0;
			if (!flag18)
			{
				object obj28 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v47+E4]");
				bool flag19 = (nint)0 == 0;
				object obj29 = !flag19;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj30 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v51+E4]");
				bool flag20 = (nint)0 == 0;
				object obj31 = !flag20;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj30 = obj19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v51+A0]");
				object obj32 = 0;
				object obj33 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v28+6CC]");
				object obj34 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v28+6CC]");
				object obj35 = (nint)0 & (nint)3;
				object obj36 = obj34 & 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v28+6CC]");
				if ((nint)0 >= (nint)0)
				{
					obj35 = 0 - obj36;
				}
				object obj37 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				obj27 = obj37 * 0;
			}
			float time4 = Time.time;
			float num6 = time4 - openSince;
			float num7 = (float)obj27 + stayOpen;
			bool flag21 = !(num6 > num7);
			obj13 = 0;
			if (!flag21)
			{
				bool busy = door.Busy;
				bool flag22 = !busy;
				object obj38 = !flag22;
				obj13 = 0;
				if (obj38 == null)
				{
					bool flag23 = SomeoneInDoorway();
					bool flag24 = !flag23;
					object obj39 = !flag24;
					obj13 = 0;
					if (obj39 == null)
					{
						door.Press();
						obj13 = 0;
					}
				}
			}
		}
		bool isOpen2 = door.IsOpen;
		Show(isOpen2);
	}

	private unsafe bool CardHere()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I4
		//IL_06ef: Expected Obj, but got I
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got I4
		//IL_067e: Expected I, but got Obj
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Ref, but got Unknown
		//IL_06a1: Expected Obj, but got I4
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0458: Expected Obj, but got I4
		//IL_0473: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I4
		//IL_0520: Expected Obj, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got I8
		//IL_0186: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected I, but got Obj
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Invalid comparison between Unknown and F4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5278]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		bool flag2 = (object)obj4 == null;
		UnityEngine.Object obj6 = default;
		UnityEngine.Object obj5 = obj6;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5268]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1780]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5260]");
			object obj10 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj4).GetEnumerator();
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			object obj18 = default;
			float num2 = default;
			float num4 = default;
			float num6 = default;
			float num8 = default;
			Enumerator<, > val5 = default;
			object obj12 = default;
			object obj27 = default;
			bool result2 = default;
			object obj23;
			Enumerator<, > val6;
			Enumerator<, > val7;
			while (true)
			{
				bool flag3 = val.MoveNext();
				bool flag4 = !flag3;
				float num = num2;
				float num3 = num4;
				float num5 = num6;
				float num7 = num8;
				Enumerator<, > val4 = val5;
				object obj11 = obj12;
				val6 = val2;
				if (!flag4)
				{
					object obj13 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v32+E4]");
					bool flag5 = (nint)0 == 0;
					object obj14 = !flag5;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj6 != null;
					bool flag7 = !flag6;
					obj12 = 0;
					if (flag7)
					{
						continue;
					}
					UnityEngine.Object obj20;
					nint num9;
					if ((object)obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+38]");
						bool flag8 = (nint)0 == 0;
						obj12 = 0;
						if (flag8)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ stack_-88 (UnityEngine.Object)+3C]");
						object obj15 = 0 & 0x80000000L;
						bool flag9 = obj15 == null;
						object obj16 = !flag9;
						obj12 = 0;
						if (obj16 != null)
						{
							continue;
						}
						bool mine = ((GillaItem)obj6).Mine;
						bool flag10 = !mine;
						obj12 = 0;
						if (flag10)
						{
							continue;
						}
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
						object obj17 = obj18 & 1;
						bool flag11 = obj17 == null;
						object obj19 = !flag11;
						if (obj19 != null)
						{
							continue;
						}
						Transform transform = ((Component)obj6).transform;
						bool flag12 = (object)transform == null;
						obj20 = null;
						if (!flag12)
						{
							Vector3 position = transform.position;
							Transform transform2 = base.transform;
							bool flag13 = (object)transform2 == null;
							num6 = num2;
							num8 = num4;
							val5 = val2;
							num9 = unchecked((nint)null);
							if (flag13)
							{
								break;
							}
							Vector3 position2 = transform2.position;
							object obj21 = val2 - val2;
							float num10 = num4 - num4;
							float num11 = num2 - num2;
							object obj22 = obj21 * obj21;
							float num12 = num10 * num10;
							float num13 = (float)obj22 + num12;
							float num14 = num11 * num11;
							num = reach;
							val6 = (Enumerator<, >)(num14 + num13);
							num3 = reach * reach;
							bool flag14 = !((float)val6 < num3);
							num5 = num2;
							num7 = num4;
							val4 = val2;
							obj11 = obj9;
							num2 = reach;
							num4 = num3;
							num6 = reach;
							num8 = num3;
							val5 = val2;
							val2 = val6;
							if (flag14)
							{
								continue;
							}
							goto IL_03ac;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
						obj12 = 0;
						obj20 = null;
					}
					NullReferenceException ex2 = new NullReferenceException();
					num9 = (nint)obj20;
					break;
				}
				goto IL_03ac;
				IL_03ac:
				obj5 = null;
				val = val3;
				obj23 = 0;
				val7 = (Enumerator<, >)(ref val);
				object obj24 = 0;
				bool result = flag3;
				while (true)
				{
					nint num9 = (nint)obj10;
					((Enumerator<, >*)val7)->Dispose();
					bool flag15 = obj24 == null;
					object obj25 = !flag15;
					num2 = num;
					num4 = num3;
					num6 = num5;
					num8 = num7;
					val5 = val4;
					obj12 = obj11;
					if (obj25 == null)
					{
						bool flag16 = (object)obj5 == null;
						object obj26 = !flag16;
						num2 = num;
						num4 = num3;
						num6 = num5;
						num8 = num7;
						val5 = val4;
						obj12 = obj11;
						OutOfMemoryException ex3 = (OutOfMemoryException)val7;
						if (obj26 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num9)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj5 = (UnityEngine.Object)1;
						obj4 = (UnityEngine.Object)1;
						obj24 = obj23;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj24 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj23 = obj27;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D3D4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					num = num2;
					num3 = num4;
					num5 = num6;
					num7 = num8;
					val4 = val5;
					obj11 = obj12;
					result = false;
				}
				return result;
			}
			NullReferenceException ex4 = new NullReferenceException();
			obj5 = null;
			val = val3;
			obj23 = 0;
			val6 = val2;
			val7 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private bool HandHere(Player gt)
	{
		//IL_0486: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I4
		//IL_0457: Invalid comparison between F4 and I4
		object obj;
		float num2 = default;
		float num4 = default;
		if ((object)gt != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = gt.leftHandFollower != null;
			bool flag3 = !flag2;
			UnityEngine.Object obj4 = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v28+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag5 = GillaOneArm.Resting(0);
				bool flag6 = !flag5;
				object obj8 = !flag6;
				obj4 = null;
				if (obj8 == null)
				{
					if ((object)gt.leftHandFollower != null)
					{
						Vector3 position = gt.leftHandFollower.position;
						Transform transform = base.transform;
						if ((object)transform != null)
						{
							Vector3 position2 = transform.position;
							float num = num2 - num2;
							float num3 = num4 - num4;
							float num6 = default;
							float num5 = num6 - num6;
							float num7 = num * num;
							float num8 = num3 * num3;
							float num9 = num7 + num8;
							float num10 = num5 * num5;
							num2 = num10 + num9;
							num4 = handReach * handReach;
							bool flag7 = num2 < num4;
							obj4 = null;
							if (!flag7)
							{
								goto IL_023c;
							}
							return true;
						}
					}
					goto IL_0478;
				}
			}
			goto IL_023c;
		}
		goto IL_0478;
		IL_023c:
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj10 = !flag8;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gt.rightHandFollower != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+E4]");
			bool flag9 = (nint)0 == 0;
			object obj13 = !flag9;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!GillaOneArm.Resting(1))
			{
				if ((object)gt.rightHandFollower != null)
				{
					Vector3 position3 = gt.rightHandFollower.position;
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Vector3 position4 = transform2.position;
						float num11 = num2 - num2;
						float num12 = num4 - num4;
						float num13 = handReach - handReach;
						float num14 = num11 * num11;
						float num15 = num12 * num12;
						float num16 = num14 + num15;
						float num17 = num13 * num13;
						float num18 = num17 + num16;
						float num19 = handReach * handReach;
						float num20 = num18 - num19;
						return num20 < 0f;
					}
				}
				goto IL_0478;
			}
		}
		return false;
		IL_0478:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe bool SomeoneInDoorway()
	{
		//IL_0761: Expected Obj, but got Ref
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Ref
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got I4
		//IL_037f: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I4
		//IL_083f: Expected Obj, but got I
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got VT
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got I4
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected Ref, but got Unknown
		//IL_0900: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_0270: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got I4
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_02d8: Invalid comparison between VT and I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got VT
		//IL_032e: Expected VT, but got Ref
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got I4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got Ref
		//IL_06e1: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I
		//IL_056e: Expected VT, but got Ref
		Enumerator<, > val = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = (object)door == null;
		UnityEngine.Object obj2 = default;
		GillaDoor gillaDoor = (GillaDoor)obj2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		Enumerator<, > val3 = (Enumerator<, >)0;
		val = (Enumerator<, >)0;
		GillaKeycardReader gillaKeycardReader = this;
		GillaDoor gillaDoor2 = (GillaDoor)(&val);
		object obj11;
		bool result;
		ref GillaLeaderboard._003C_003Ec__DisplayClass21_0 reference;
		if (!flag)
		{
			Vector3 foot = door.Foot;
			gillaDoor2 = door;
			bool flag2 = (object)door == null;
			gillaDoor = (GillaDoor)obj2;
			val2 = (Enumerator<, >)0;
			obj3 = obj4;
			obj5 = obj6;
			val3 = (Enumerator<, >)0;
			val = (Enumerator<, >)0;
			gillaKeycardReader = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v8+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				UnityEngine.Object obj10 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				nint num = (nint)obj10;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v9+1C]");
				object obj13 = 0 * obj4;
				Vector3 vector = gillaDoor2.Through__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v9+1C]");
				obj5 = vector * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v15 (Il2CppClass<UnityEngine.Object>)+A0]");
				object obj14 = 0;
				object obj16 = default;
				object obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+148]");
				obj16 = obj15 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v9+18]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+148]");
				object obj17 = num2 * 0;
				obj3 = obj13 - obj16;
				val3 = (Enumerator<, >)(obj17 - obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj18 = !flag3;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = (UnityEngine.Object)obj14 != null;
				bool flag5 = !flag4;
				reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
				gillaKeycardReader = null;
				if (flag5)
				{
					goto IL_036f;
				}
				nint num3 = (nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v29 (Il2CppClass<UnityEngine.Object>)+A0]");
				object obj19 = 0;
				gillaDoor2 = (GillaDoor)obj19;
				bool flag6 = obj19 == null;
				gillaDoor = (GillaDoor)obj2;
				val2 = (Enumerator<, >)0;
				reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
				val = (Enumerator<, >)0;
				gillaKeycardReader = null;
				if (!flag6)
				{
					object obj20 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v62+E4]");
					bool flag7 = (nint)0 == 0;
					object obj21 = !flag7;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = (UnityEngine.Object)gillaDoor2.shutTurn != null;
					bool flag9 = !flag8;
					reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
					gillaKeycardReader = null;
					if (flag9)
					{
						goto IL_036f;
					}
					nint num4 = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v32 (Il2CppClass<UnityEngine.Object>)+A0]");
					object obj22 = 0;
					gillaDoor2 = (GillaDoor)obj22;
					bool flag10 = obj22 == null;
					gillaDoor = (GillaDoor)obj2;
					val2 = (Enumerator<, >)0;
					reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
					val = (Enumerator<, >)0;
					gillaKeycardReader = null;
					if (!flag10)
					{
						bool flag11 = gillaDoor2.shutTurn == (Quaternion)(object)0;
						gillaDoor = (GillaDoor)obj2;
						val2 = (Enumerator<, >)0;
						reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
						val = (Enumerator<, >)0;
						gillaKeycardReader = null;
						if (!flag11)
						{
							Vector3 position = ((Transform)gillaDoor2.shutTurn).position;
							bool flag12 = _003CSomeoneInDoorway_003Eg__In_007C21_0((Vector3)(&val), ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null);
							bool flag13 = !flag12;
							reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
							gillaKeycardReader = (GillaKeycardReader)(&val);
							if (flag13)
							{
								goto IL_036f;
							}
							result = true;
							goto IL_061c;
						}
					}
				}
			}
		}
		goto IL_0677;
		IL_036f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v36+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v36+A0]");
		gillaDoor2 = (GillaDoor)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+8]");
		bool flag15 = (nint)0 == 0;
		gillaDoor = (GillaDoor)obj2;
		val2 = (Enumerator<, >)0;
		val = (Enumerator<, >)0;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4 (GillaDoor)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			bool flag16;
			ref GillaLeaderboard._003C_003Ec__DisplayClass21_0 reference2;
			Enumerator<, > val4 = default;
			object obj32;
			Enumerator<, > val5;
			while (true)
			{
				flag16 = val2.MoveNext();
				bool flag17 = !flag16;
				reference2 = ref reference;
				if (flag17)
				{
					break;
				}
				object obj28 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v43+E4]");
				bool flag18 = (nint)0 == 0;
				object obj29 = !flag18;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag19 = obj2 != null;
				bool flag20 = !flag19;
				reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
				if (flag20)
				{
					continue;
				}
				if ((object)obj2 != null)
				{
					object obj30 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v50+E4]");
					bool flag21 = (nint)0 == 0;
					object obj31 = !flag21;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ stack_-98 (UnityEngine.Object)+68]");
					bool flag22 = (UnityEngine.Object)0 != null;
					bool flag23 = !flag22;
					reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
					if (flag23)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ stack_-98 (UnityEngine.Object)+68]");
					bool flag24 = (nint)0 == 0;
					reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
					gillaKeycardReader = null;
					if (!flag24)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ stack_-98 (UnityEngine.Object)+68]");
						Vector3 position2 = ((Transform)0).position;
						bool flag25 = _003CSomeoneInDoorway_003Eg__In_007C21_0((Vector3)(&val), ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null);
						bool flag26 = !flag25;
						reference2 = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
						reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
						if (!flag26)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					reference = ref *(GillaLeaderboard._003C_003Ec__DisplayClass21_0*)null;
					gillaKeycardReader = null;
				}
				NullReferenceException ex2 = new NullReferenceException();
				gillaDoor = null;
				val2 = val4;
				obj32 = 0;
				val5 = (Enumerator<, >)(ref val2);
				val3 = val4;
				val = (Enumerator<, >)0;
				goto IL_0677;
			}
			gillaDoor = null;
			val2 = val4;
			obj32 = 0;
			val5 = (Enumerator<, >)(ref val2);
			reference = ref reference2;
			val3 = val4;
			val = (Enumerator<, >)0;
			object obj33 = 0;
			result = flag16;
			bool result2 = default;
			object obj36 = default;
			while (true)
			{
				gillaKeycardReader = (GillaKeycardReader)obj27;
				((Enumerator<, >*)val5)->Dispose();
				bool flag27 = obj33 == null;
				object obj34 = !flag27;
				if (obj34 == null)
				{
					bool flag28 = (object)gillaDoor == null;
					object obj35 = !flag28;
					OutOfMemoryException ex3 = (OutOfMemoryException)val5;
					if (obj35 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)gillaKeycardReader == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					gillaDoor = (GillaDoor)1;
					gillaDoor2 = (GillaDoor)1;
					obj33 = obj32;
				}
				else
				{
					if ((nint)gillaKeycardReader != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj33 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj32 = obj36;
				}
				result = false;
			}
			goto IL_061c;
		}
		goto IL_0677;
		IL_061c:
		return result;
		IL_0677:
		throw new NullReferenceException();
	}

	private void Beep(AudioClip clip, float buzz)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I4
		//IL_0181: Expected F4, but got I
		//IL_01b6: Expected F4, but got I
		//IL_005f: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_0150: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (clip != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj5 = array + 32;
				obj5 = clip;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v27+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMin = default;
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, buzz, pitchMin, pitchMax);
					goto IL_0155;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
		goto IL_0155;
		IL_0155:
		InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode((XRNode)5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		InputDevice inputDevice = default;
		bool flag3 = inputDevice.SendHapticImpulse(0u, buzz, 0f);
		InputDevice deviceAtXRNode2 = InputDevices.GetDeviceAtXRNode((XRNode)4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		bool flag4 = inputDevice.SendHapticImpulse(0u, buzz, 0f);
	}

	private void Show(bool open)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01e8: Expected VT, but got I4
		//IL_01e8: Expected I4, but got Obj
		if (shown == (open ? 1 : 0))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (strip == null)
		{
			return;
		}
		object obj4 = this + 112;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			obj4 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		strip.GetPropertyBlock((MaterialPropertyBlock)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1788]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v12+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag3 = !open;
			obj9 = obj8;
			if (flag3)
			{
				goto IL_01b9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			bool flag4 = !open;
			object obj10 = !flag4;
			obj9 = obj7;
			if (obj10 == null)
			{
				goto IL_01b9;
			}
		}
		goto IL_01c6;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v12+A0]");
		object obj11 = 0;
		((MaterialPropertyBlock)obj4).SetColor((int)obj11, (Color)0);
		strip.SetPropertyBlock((MaterialPropertyBlock)obj4);
		return;
		IL_01b9:
		obj8 = obj9;
		goto IL_01c6;
	}

	public GillaKeycardReader()
	{
		//IL_001a: Expected I4, but got I8
		//IL_002c: Expected F4, but got I
		//IL_0049: Expected VT, but got I
		//IL_005b: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B2A8]");
		reach = 0f;
		openSince = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D150]");
		lockedColour = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E510]");
		openColour = (Color)0;
		base._002Ector();
	}

	static GillaKeycardReader()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1788]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}

	private bool _003CSomeoneInDoorway_003Eg__In_007C21_0(Vector3 p, ref GillaLeaderboard._003C_003Ec__DisplayClass21_0 P_1)
	{
		//IL_0220: Expected I4, but got Obj
		//IL_0201: Invalid comparison between F4 and I4
		GillaDoor gillaDoor = door;
		if ((object)door != null)
		{
			object obj = default;
			float num = (float)obj - p.x;
			object obj2 = default;
			float num2 = (float)obj2 - p.y;
			object obj3 = default;
			float num3 = (float)obj3 - p.z;
			float num4 = num * (float)gillaDoor.Through__BackingField;
			float num5 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (GillaDoor)+148]");
			float num6 = num5 * 0f;
			float num7 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (GillaDoor)+14C]");
			float num8 = num7 * 0f;
			float num9 = num4 + num6;
			float num10 = num8 + num9;
			double num11 = (double)gillaDoor.Thickness__BackingField * 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			double num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			double num13 = num12 + 0.0;
			if ((double)num10 < num13)
			{
				float num14 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+18]");
				float num15 = num14 * 0f;
				float num16 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+1C]");
				float num17 = num16 * 0f;
				float num18 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (UnityEngine.Vector3)+20]");
				float num19 = num18 * 0f;
				float num20 = num15 + num17;
				double num21 = (double)gillaDoor.Width__BackingField * 0.5;
				float num22 = num19 + num20;
				double num23 = num21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				double num24 = num23 + 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				if ((double)num22 < num24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					float num25 = num2 - 3f;
					return num25 < 0f;
				}
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
