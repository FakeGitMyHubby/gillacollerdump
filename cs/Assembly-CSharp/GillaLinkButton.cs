using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class GillaLinkButton : MonoBehaviour
{
	public string url;

	public float hold;

	public Transform fill;

	public AudioClip openSound;

	public bool store;

	private Action m_Opened;

	public static Action<GillaLinkButton> OpenInstead;

	private const float Again = default(float);

	private const float Drain = default(float);

	private PressKey key;

	private Collider box;

	private float next;

	private float held;

	private bool spent;

	public float Held
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_001d: Expected F4, but got I4
			//IL_0047: Invalid comparison between F4 and I4
			//IL_0056: Expected F4, but got I4
			bool flag = !(hold > 0f);
			float result = 0f;
			if (!flag)
			{
				float num = held / hold;
				bool flag2 = num < 0f;
				result = 0f;
				if (!flag2)
				{
					bool flag3 = !((double)num > 1.0);
					result = num;
					if (!flag3)
					{
						result = 1f;
					}
				}
			}
			return result;
		}
	}

	public event Action Opened
	{
		add
		{
			//IL_006d: Expected Obj, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj = 0;
			object obj2 = this + 72;
			Delegate obj3 = (Delegate)obj2;
			Delegate obj5 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 != null && obj4 != obj)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj5 != obj3;
				obj3 = obj5;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_006d: Expected Obj, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj = 0;
			object obj2 = this + 72;
			Delegate obj3 = (Delegate)obj2;
			Delegate obj5 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 != null && obj4 != obj)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag = (object)obj5 != obj3;
				obj3 = obj5;
				if (!flag)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1530]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BA8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BB0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj5 = this + 80;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj7 = this + 88;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj4);
		((PressKey)obj5).Pressed += (Action<PressKey>)action;
		Show();
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
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
		if (key != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BB0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action<System.__Canon> action = default;
			action._002Ector((object)this, (IntPtr)obj5);
			key.Pressed -= (Action<PressKey>)action;
		}
	}

	private void Update()
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_001c: Expected Obj, but got I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_0170: Invalid comparison between F4 and I4
		//IL_010c: Expected F4, but got I4
		bool flag = hold < 0f;
		object obj = !flag;
		bool flag2 = hold == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		bool isDown = key.IsDown;
		bool flag3 = !isDown;
		object obj4 = !flag3;
		float num;
		if (obj4 != null || MouseOn())
		{
			bool flag4 = (byte)(~(spent ? 1u : 0u)) != 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				num = held + unscaledDeltaTime;
				goto IL_0187;
			}
		}
		else
		{
			spent = false;
		}
		float unscaledDeltaTime2 = Time.unscaledDeltaTime;
		float num2 = unscaledDeltaTime2 * -3f;
		num = held + num2;
		if (num < 0f)
		{
			num = 0f;
		}
		goto IL_0187;
		IL_0187:
		held = num;
		if (!(num < hold))
		{
			held = 0f;
			spent = true;
			Open();
		}
		Show();
	}

	private void Pressed(PressKey _)
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_001c: Expected Obj, but got I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		bool flag = hold < 0f;
		object obj = !flag;
		bool flag2 = hold == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			Open();
		}
	}

	private void Show()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_005c: Invalid comparison between F4 and I4
		//IL_00d2: Expected VT, but got I4
		//IL_008f: Invalid comparison between F4 and I4
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
		if (!(fill != null))
		{
			return;
		}
		if (hold > 0f)
		{
			float num = held / hold;
			if (!(num < 0f) && !((double)num > 1.0))
			{
			}
		}
		fill.localScale = (Vector3)0;
	}

	private unsafe bool MouseOn()
	{
		//IL_0276: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_0253: Expected I4, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_01fd: Expected VT, but got I4
		//IL_023c: Expected VT, but got Ref
		bool isDeviceActive = XRSettings.isDeviceActive;
		bool flag = !isDeviceActive;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+A0]");
			object obj4 = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v14+A0]");
				object obj7 = 0;
				object obj8 = obj7;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v16+1C0]");
					if ((nint)0 == 0)
					{
						goto IL_0245;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v16+1C0]");
					if (((ButtonControl)0).isPressed)
					{
						Camera main = Camera.main;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj9 = 0;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v18+E4]");
						bool flag2 = (nint)0 == 0;
						object obj11 = !flag2;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = main == null;
						bool flag4 = !flag3;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							object obj13 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v19+E4]");
							bool flag5 = (nint)0 == 0;
							object obj14 = !flag5;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag6 = box == null;
							bool flag7 = !flag6;
							object obj15 = !flag7;
							if (obj15 == null)
							{
								Camera main2 = Camera.main;
								object obj16 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v22+A0]");
								object obj17 = 0;
								object obj18 = obj17;
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v24+188]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v24+188]");
										Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
										if ((object)main2 != null)
										{
											Ray ray = main2.ScreenPointToRay((Vector3)0);
											object obj19 = default;
											RaycastHit hitInfo;
											if ((object)box != null)
											{
												return box.Raycast((Ray)(&obj19), out hitInfo, 5f);
											}
										}
									}
								}
								goto IL_0245;
							}
						}
					}
				}
			}
		}
		return false;
		IL_0245:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Open()
	{
		//IL_002e: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0196: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_01fc: Expected VT, but got I4
		float unscaledTime = Time.unscaledTime;
		if (unscaledTime < next)
		{
			return;
		}
		bool flag = string.IsNullOrEmpty(url);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		float volume = unscaledTime2 + 5f;
		object obj3 = obj2;
		next = volume;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = openSound != null;
		bool flag5 = !flag4;
		float num = 5f;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			AudioClip[] array = default;
			if (array != null)
			{
				object obj6 = array + 32;
				obj6 = openSound;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v39+E4]");
					bool flag6 = (nint)0 == 0;
					object obj9 = !flag6;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float pitchMax = default;
					Sfx.Play(array, (Vector3)0, volume, 5f, pitchMax);
					num = 5f;
					goto IL_020e;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
		goto IL_020e;
		IL_020e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BB8]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v10+A0]");
		object obj12 = 0;
		object obj13 = obj12;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X8_v12+18] (should have been resolved before IL gen)");
		}
		else if (~(store ? 1u : 0u) == 0)
		{
			OpenStore(url);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BC0]");
			object obj14 = 0;
			string message = (string)obj14 + url;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v20+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.Log(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v18+E4]");
			bool flag8 = (nint)0 == 0;
			object obj20 = !flag8;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Application.OpenURL(url);
		}
		Action opened = this.m_Opened;
		if (this.m_Opened != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe static void OpenStore(string web)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1b9f: Expected Obj, but got I
		//IL_1bc4: Expected Obj, but got I
		//IL_155d: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_1c00: Expected Obj, but got I
		//IL_1c22: Expected Obj, but got I4
		//IL_1e01: Expected Obj, but got I
		//IL_1e11: Expected Obj, but got I
		//IL_1e2b: Expected Obj, but got I
		//IL_1e4c: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got Ref
		//IL_012f: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got Ref
		//IL_026c: Expected Obj, but got I4
		//IL_0191: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got Ref
		//IL_01f5: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I8
		//IL_03aa: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I4
		//IL_03c0: Expected Obj, but got Ref
		//IL_03d1: Expected Obj, but got I4
		//IL_02e4: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_0337: Expected Obj, but got Ref
		//IL_0348: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0437: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got Ref
		//IL_045e: Expected Obj, but got I4
		//IL_0489: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I
		//IL_0503: Expected Obj, but got I4
		//IL_1539: Expected Obj, but got I4
		//IL_1546: Expected Obj, but got Ref
		//IL_0521: Expected Obj, but got I
		//IL_0539: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I4
		//IL_0607: Expected Obj, but got Ref
		//IL_0618: Expected Obj, but got I4
		//IL_054f: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I4
		//IL_0599: Expected Obj, but got Ref
		//IL_05aa: Expected Obj, but got I4
		//IL_05c7: Expected Obj, but got I
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0688: Expected Obj, but got I
		//IL_06fd: Expected Obj, but got I4
		//IL_070a: Expected Obj, but got Ref
		//IL_071b: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I4
		//IL_074f: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I4
		//IL_0828: Expected Obj, but got I4
		//IL_0835: Expected Obj, but got Ref
		//IL_0846: Expected Obj, but got I4
		//IL_077d: Expected I, but got Obj
		//IL_078d: Expected Obj, but got I
		//IL_07ba: Expected Obj, but got I4
		//IL_07c7: Expected Obj, but got Ref
		//IL_07d8: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_0899: Expected Obj, but got I
		//IL_0958: Expected Obj, but got I8
		//IL_097b: Expected Obj, but got I4
		//IL_0988: Expected Obj, but got Ref
		//IL_0999: Expected Obj, but got I4
		//IL_08be: Expected I, but got Obj
		//IL_08ce: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I4
		//IL_0908: Expected Obj, but got Ref
		//IL_0919: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_09ff: Expected Obj, but got I4
		//IL_0a0c: Expected Obj, but got Ref
		//IL_0a1d: Expected Obj, but got I4
		//IL_0a48: Expected Obj, but got I
		//IL_0abd: Expected Obj, but got I4
		//IL_0aca: Expected Obj, but got Ref
		//IL_0adb: Expected Obj, but got I4
		//IL_0af1: Expected Obj, but got I4
		//IL_0b0f: Expected Obj, but got I
		//IL_0b27: Expected Obj, but got I4
		//IL_0be8: Expected Obj, but got I4
		//IL_0bf5: Expected Obj, but got Ref
		//IL_0c06: Expected Obj, but got I4
		//IL_0b3d: Expected I, but got Obj
		//IL_0b4d: Expected Obj, but got I
		//IL_0b7a: Expected Obj, but got I4
		//IL_0b87: Expected Obj, but got Ref
		//IL_0b98: Expected Obj, but got I4
		//IL_0bb5: Expected Obj, but got I
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected Obj, but got Unknown
		//IL_0c59: Expected Obj, but got I
		//IL_0d18: Expected Obj, but got I8
		//IL_0d3b: Expected Obj, but got I4
		//IL_0d48: Expected Obj, but got Ref
		//IL_0d59: Expected Obj, but got I4
		//IL_0c7e: Expected I, but got Obj
		//IL_0c8e: Expected Obj, but got I
		//IL_0cbb: Expected Obj, but got I4
		//IL_0cc8: Expected Obj, but got Ref
		//IL_0cd9: Expected Obj, but got I4
		//IL_0cf6: Expected Obj, but got I
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected Obj, but got Unknown
		//IL_0dbf: Expected Obj, but got I4
		//IL_0dcc: Expected Obj, but got Ref
		//IL_0ddd: Expected Obj, but got I4
		//IL_0e6a: Expected Obj, but got I4
		//IL_0e90: Expected Obj, but got I4
		//IL_0f51: Expected Obj, but got I4
		//IL_0f5e: Expected Obj, but got Ref
		//IL_0f6f: Expected Obj, but got I4
		//IL_0ea6: Expected I, but got Obj
		//IL_0eb6: Expected Obj, but got I
		//IL_0ee3: Expected Obj, but got I4
		//IL_0ef0: Expected Obj, but got Ref
		//IL_0f01: Expected Obj, but got I4
		//IL_0f1e: Expected Obj, but got I
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected Obj, but got Unknown
		//IL_0fe7: Expected Obj, but got I
		//IL_1d99: Expected Obj, but got Ref
		//IL_1c44: Expected Obj, but got I4
		//IL_1c4d: Expected Obj, but got I4
		//IL_1c5a: Expected Obj, but got Ref
		//IL_1c6b: Expected Obj, but got I4
		//IL_101d: Expected Obj, but got I
		//IL_1ca9: Expected Obj, but got I
		//IL_1058: Expected Obj, but got I
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected Obj, but got Unknown
		//IL_1073: Expected Obj, but got I
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAD0]");
		object obj2 = 0;
		string text = (string)obj2;
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector((string)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj3 = 0;
		bool flag = androidJavaClass == null;
		AndroidJavaObject androidJavaObject = null;
		AndroidJavaObject androidJavaObject2 = null;
		object[] array = null;
		if (flag)
		{
			goto IL_154b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAE0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @357DD18");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X20_v49+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X20_v49+38]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X20_v49+38]");
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v82+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v175+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X20_v49+38]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v129+10]");
			obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEC80]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v175+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C00]");
		object className = 0;
		AndroidJavaObject androidJavaObject3 = default;
		androidJavaObject3._002Ector((string)className, (object[])obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		AndroidJavaObject androidJavaObject4 = (AndroidJavaObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array2 = default;
		bool flag4 = array2 == null;
		androidJavaObject = androidJavaObject3;
		object obj15 = 0;
		object obj16 = 0;
		IndexOutOfRangeException ex = null;
		object obj17 = (object)(&androidJavaObject2);
		AndroidJavaObject androidJavaObject5 = default;
		androidJavaObject2 = androidJavaObject5;
		object obj18 = 0;
		OutOfMemoryException ex2 = null;
		object[] array3 = (object[])obj14;
		text = (string)2;
		if (flag4)
		{
			goto IL_158c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BF8]");
		object obj19 = 0;
		bool flag5 = obj19 == null;
		text = (string)2;
		IndexOutOfRangeException ex3 = default;
		string text2;
		if (!flag5)
		{
			nint num = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v128 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag6 = ex3 == null;
			androidJavaObject = androidJavaObject3;
			obj15 = 0;
			obj16 = 0;
			ex = null;
			obj17 = (object)(&androidJavaObject2);
			androidJavaObject2 = androidJavaObject5;
			obj18 = 0;
			ex2 = null;
			array3 = (object[])obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v128 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			if (flag6)
			{
				goto IL_1692;
			}
		}
		bool flag7 = array2.Length == 0;
		androidJavaObject = androidJavaObject3;
		obj15 = 0;
		obj16 = 0;
		ex = null;
		obj17 = (object)(&androidJavaObject2);
		androidJavaObject2 = androidJavaObject5;
		obj18 = 0;
		ex2 = null;
		array3 = (object[])obj14;
		if (flag7)
		{
			goto IL_15a8;
		}
		text = (string)obj19;
		object obj20 = array2 + 32;
		obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BD0]");
		obj19 = 0;
		ArgumentNullException ex4 = default;
		string text3;
		if (obj19 != null)
		{
			nint num2 = (nint)array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v127 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag8 = ex4 == null;
			androidJavaObject = androidJavaObject3;
			obj15 = 0;
			obj16 = 0;
			ex = null;
			obj17 = (object)(&androidJavaObject2);
			androidJavaObject2 = androidJavaObject5;
			obj18 = 0;
			ex2 = null;
			array3 = (object[])obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v127 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			if (flag8)
			{
				goto IL_16af;
			}
		}
		object obj21 = array2.Length & 0xFFFFFFFEL;
		bool flag9 = obj21 == null;
		androidJavaObject = androidJavaObject3;
		obj15 = 0;
		obj16 = 0;
		ex = null;
		obj17 = (object)(&androidJavaObject2);
		androidJavaObject2 = androidJavaObject5;
		obj18 = 0;
		ex2 = null;
		array3 = (object[])obj14;
		if (flag9)
		{
			goto IL_15c5;
		}
		text = (string)obj19;
		object obj22 = array2 + 40;
		obj22 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag10 = androidJavaObject3 == null;
		androidJavaObject = androidJavaObject3;
		obj15 = 0;
		obj16 = 0;
		ex = null;
		obj17 = (object)(&androidJavaObject2);
		androidJavaObject2 = androidJavaObject5;
		obj18 = 0;
		ex2 = null;
		array3 = (object[])obj14;
		ArgumentNullException ex8 = default;
		string text7;
		ArgumentNullException ex10 = default;
		string text9;
		ArgumentNullException ex5 = default;
		string text4;
		ArgumentNullException ex6 = default;
		string text5;
		ArgumentNullException ex7 = default;
		string text6;
		ArgumentNullException ex9 = default;
		string text8;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C08]");
			object methodName = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAB0]");
			obj19 = 0;
			obj15 = obj19;
			((AndroidJavaObject)(object)androidJavaObject3.Call<System.__Canon>((string)methodName, array2))?.Dispose();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object[] array4 = default;
			bool flag11 = array4 == null;
			text = (string)1;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BD8]");
				object obj23 = 0;
				bool flag12 = obj23 == null;
				text = (string)1;
				if (!flag12)
				{
					nint num3 = (nint)array4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v126 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag13 = ex5 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v126 (Il2CppClass<System.Object[]>)+40]");
					text4 = (string)0;
					if (flag13)
					{
						goto IL_16cc;
					}
				}
				bool flag14 = array4.Length == 0;
				androidJavaObject = androidJavaObject3;
				obj16 = 0;
				ex = null;
				obj17 = (object)(&androidJavaObject2);
				androidJavaObject2 = androidJavaObject5;
				obj18 = 0;
				ex2 = null;
				array3 = array2;
				if (flag14)
				{
					goto IL_15fe;
				}
				text = (string)obj23;
				object obj24 = array4 + 32;
				obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if (androidJavaObject3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C20]");
					object methodName2 = 0;
					obj15 = obj19;
					((AndroidJavaObject)(object)androidJavaObject3.Call<System.__Canon>((string)methodName2, array4))?.Dispose();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object[] array5 = default;
					bool flag15 = array5 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array4;
					text = (string)2;
					if (flag15)
					{
						goto IL_160c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BC8]");
					obj23 = 0;
					bool flag16 = obj23 == null;
					text = (string)2;
					if (!flag16)
					{
						nint num4 = (nint)array5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ X8_v125 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag17 = ex6 == null;
						androidJavaObject = androidJavaObject3;
						obj16 = 0;
						ex = null;
						obj17 = (object)(&androidJavaObject2);
						androidJavaObject2 = androidJavaObject5;
						obj18 = 0;
						ex2 = null;
						array3 = array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ X8_v125 (Il2CppClass<System.Object[]>)+40]");
						text5 = (string)0;
						if (flag17)
						{
							goto IL_16e9;
						}
					}
					bool flag18 = array5.Length == 0;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array4;
					if (flag18)
					{
						goto IL_161a;
					}
					text = (string)obj23;
					object obj25 = array5 + 32;
					obj25 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BF0]");
					obj23 = 0;
					if (obj23 != null)
					{
						nint num5 = (nint)array5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ X8_v124 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag19 = ex7 == null;
						androidJavaObject = androidJavaObject3;
						obj16 = 0;
						ex = null;
						obj17 = (object)(&androidJavaObject2);
						androidJavaObject2 = androidJavaObject5;
						obj18 = 0;
						ex2 = null;
						array3 = array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ X8_v124 (Il2CppClass<System.Object[]>)+40]");
						text6 = (string)0;
						if (flag19)
						{
							goto IL_1706;
						}
					}
					object obj26 = array5.Length & 0xFFFFFFFEL;
					bool flag20 = obj26 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array4;
					if (flag20)
					{
						goto IL_1628;
					}
					text = (string)obj23;
					object obj27 = array5 + 40;
					obj27 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag21 = androidJavaObject3 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array4;
					if (flag21)
					{
						goto IL_1636;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C18]");
					obj23 = 0;
					obj15 = obj19;
					((AndroidJavaObject)(object)androidJavaObject3.Call<System.__Canon>((string)obj23, array5))?.Dispose();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object[] array6 = default;
					bool flag22 = array6 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array5;
					text = (string)2;
					if (flag22)
					{
						goto IL_1644;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C28]");
					object obj28 = 0;
					bool flag23 = obj28 == null;
					text = (string)2;
					if (!flag23)
					{
						nint num6 = (nint)array6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v123 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag24 = ex8 == null;
						androidJavaObject = androidJavaObject3;
						obj16 = 0;
						ex = null;
						obj17 = (object)(&androidJavaObject2);
						androidJavaObject2 = androidJavaObject5;
						obj18 = 0;
						ex2 = null;
						array3 = array5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ X8_v123 (Il2CppClass<System.Object[]>)+40]");
						text7 = (string)0;
						if (flag24)
						{
							goto IL_1723;
						}
					}
					bool flag25 = array6.Length == 0;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array5;
					if (flag25)
					{
						goto IL_1652;
					}
					text = (string)obj28;
					object obj29 = array6 + 32;
					obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C10]");
					obj28 = 0;
					if (obj28 != null)
					{
						nint num7 = (nint)array6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X8_v122 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag26 = ex9 == null;
						androidJavaObject = androidJavaObject3;
						obj16 = 0;
						ex = null;
						obj17 = (object)(&androidJavaObject2);
						androidJavaObject2 = androidJavaObject5;
						obj18 = 0;
						ex2 = null;
						array3 = array5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X8_v122 (Il2CppClass<System.Object[]>)+40]");
						text8 = (string)0;
						if (flag26)
						{
							goto IL_1740;
						}
					}
					object obj30 = array6.Length & 0xFFFFFFFEL;
					bool flag27 = obj30 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array5;
					if (flag27)
					{
						goto IL_1660;
					}
					text = (string)obj28;
					object obj31 = array6 + 40;
					obj31 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag28 = androidJavaObject3 == null;
					androidJavaObject = androidJavaObject3;
					obj16 = 0;
					ex = null;
					obj17 = (object)(&androidJavaObject2);
					androidJavaObject2 = androidJavaObject5;
					obj18 = 0;
					ex2 = null;
					array3 = array5;
					if (!flag28)
					{
						obj15 = obj19;
						((AndroidJavaObject)(object)androidJavaObject3.Call<System.__Canon>((string)obj23, array6))?.Dispose();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object[] array7 = default;
						bool flag29 = array7 == null;
						array = array6;
						text = (string)1;
						if (!flag29)
						{
							bool flag30 = androidJavaObject3 == null;
							text = (string)1;
							if (!flag30)
							{
								nint num8 = (nint)array7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1514 @ X8_v121 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag31 = ex10 == null;
								androidJavaObject = androidJavaObject3;
								obj16 = 0;
								ex = null;
								obj17 = (object)(&androidJavaObject2);
								androidJavaObject2 = androidJavaObject5;
								obj18 = 0;
								ex2 = null;
								array3 = array6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1514 @ X8_v121 (Il2CppClass<System.Object[]>)+40]");
								text9 = (string)0;
								if (flag31)
								{
									goto IL_175d;
								}
							}
							bool flag32 = array7.Length == 0;
							androidJavaObject = androidJavaObject3;
							obj16 = 0;
							ex = null;
							obj17 = (object)(&androidJavaObject2);
							androidJavaObject2 = androidJavaObject5;
							obj18 = 0;
							ex2 = null;
							array3 = array6;
							if (flag32)
							{
								goto IL_167c;
							}
							object obj32 = array7 + 32;
							obj32 = androidJavaObject3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag33 = androidJavaObject5 == null;
							array = array6;
							text = (string)(object)androidJavaObject3;
							if (!flag33)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1BE8]");
								object obj33 = 0;
								text = (string)obj33;
								androidJavaObject5.Call((string)obj33, array7);
								object obj34 = (object)(&androidJavaObject);
								object obj35 = obj34;
								bool flag34 = obj34 == null;
								array3 = array7;
								if (flag34)
								{
									goto IL_1c30;
								}
								object obj36 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2139 @ X8_v117+12E]");
								obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2139 @ X8_v117+12E]");
								if ((nint)0 == 0)
								{
									goto IL_10a9;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2139 @ X8_v117+98]");
								object obj37 = (nint)0 + (nint)8;
								object obj38;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X10_v51-8]");
									if (0 == (nint)obj3)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2139 @ X8_v117+12E]");
									obj14 = -1;
									obj38 = obj37 + 16;
									bool flag35 = (nint)obj14 != 1;
									obj37 = obj38;
									if (flag35)
									{
										continue;
									}
									goto IL_10a9;
								}
								obj14 = obj37;
								object obj39 = obj36 + obj37;
								object obj40 = obj39 + 312;
								obj38 = obj37;
								array3 = array7;
								goto IL_1c99;
							}
						}
						goto IL_1524;
					}
					goto IL_166e;
				}
			}
			NullReferenceException ex11 = new NullReferenceException();
			array = array2;
			goto IL_1524;
		}
		goto IL_15d3;
		IL_1706:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex8 = new ArgumentNullException();
		text7 = null;
		goto IL_1723;
		IL_175d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex12 = new ArgumentNullException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		string text10 = null;
		ArgumentNullException ex13 = ex12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_1740:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex10 = new ArgumentNullException();
		text9 = null;
		goto IL_175d;
		IL_10a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		array3 = null;
		goto IL_1c99;
		IL_1c99:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2231 @ X0_v242+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2231 @ X0_v242] (should have been resolved before IL gen)");
		goto IL_1c30;
		IL_1c30:
		androidJavaObject = androidJavaObject3;
		obj15 = 0;
		obj16 = 0;
		ex = null;
		obj17 = (object)(&androidJavaObject2);
		androidJavaObject2 = androidJavaObject5;
		obj18 = 0;
		ex2 = null;
		goto IL_15e1;
		IL_15e1:
		OutOfMemoryException ex14 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_15fe;
		IL_15fe:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		goto IL_160c;
		IL_160c:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_161a;
		IL_161a:
		IndexOutOfRangeException ex17 = new IndexOutOfRangeException();
		goto IL_1628;
		IL_1628:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_1636;
		IL_1636:
		NullReferenceException ex19 = new NullReferenceException();
		goto IL_1644;
		IL_1644:
		NullReferenceException ex20 = new NullReferenceException();
		goto IL_1652;
		IL_1652:
		IndexOutOfRangeException ex21 = new IndexOutOfRangeException();
		goto IL_1660;
		IL_1660:
		IndexOutOfRangeException ex22 = new IndexOutOfRangeException();
		goto IL_166e;
		IL_1692:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex4 = new ArgumentNullException();
		text3 = null;
		goto IL_16af;
		IL_16af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex5 = new ArgumentNullException();
		text4 = null;
		goto IL_16cc;
		IL_167c:
		ex3 = new IndexOutOfRangeException();
		text2 = text;
		goto IL_1692;
		IL_1524:
		NullReferenceException ex23 = new NullReferenceException();
		obj16 = 0;
		ex = null;
		obj17 = (object)(&androidJavaObject2);
		goto IL_154b;
		IL_166e:
		NullReferenceException ex24 = new NullReferenceException();
		goto IL_167c;
		IL_154b:
		NullReferenceException ex25 = new NullReferenceException();
		obj18 = 0;
		ex2 = null;
		OutOfMemoryException ex26 = new OutOfMemoryException();
		array3 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_158c;
		IL_15a8:
		IndexOutOfRangeException ex27 = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_15c5;
		IL_158c:
		NullReferenceException ex28 = new NullReferenceException();
		OutOfMemoryException ex29 = new OutOfMemoryException();
		goto IL_15a8;
		IL_15c5:
		IndexOutOfRangeException ex30 = new IndexOutOfRangeException();
		goto IL_15d3;
		IL_16cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex6 = new ArgumentNullException();
		text5 = null;
		goto IL_16e9;
		IL_15d3:
		NullReferenceException ex31 = new NullReferenceException();
		goto IL_15e1;
		IL_16e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex7 = new ArgumentNullException();
		text6 = null;
		goto IL_1706;
		IL_1723:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ex9 = new ArgumentNullException();
		text8 = null;
		goto IL_1740;
	}

	public GillaLinkButton()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1C48]");
		object obj = 0;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
