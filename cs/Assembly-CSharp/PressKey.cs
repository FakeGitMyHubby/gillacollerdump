using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class PressKey : MonoBehaviour
{
	public string id;

	public Transform[] fingertips;

	public float fingerRadius;

	public float hover;

	public float travel;

	public Renderer[] caps;

	public Material pressedMaterial;

	private Action<PressKey> m_Pressed;

	public Func<PressKey, int, bool> Allow;

	private const float MinDownTime = default(float);

	private const float Release = default(float);

	private const float DepthBelow = default(float);

	private const float NearEnough = default(float);

	private static AudioClip click;

	private static AudioSource voice;

	private static int lastPress;

	private static Transform[] shared;

	private Vector3 rest;

	private BoxCollider box;

	private Material[][] upMaterials;

	private Material[][] downMaterials;

	private bool touching;

	private bool shownDown;

	private float depth;

	private float heldUntil;

	private float nextBorrow;

	public bool IsDown
	{
		get
		{
			//IL_0042: Invalid comparison between F4 and I4
			if (~(touching ? 1u : 0u) == 0)
			{
				return true;
			}
			float time = Time.time;
			float num = time - heldUntil;
			return num < 0f;
		}
	}

	public event Action<PressKey> Pressed
	{
		add
		{
			//IL_006a: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_004d: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj = 0;
			object obj2 = this + 80;
			Delegate obj3 = (Delegate)obj2;
			object obj5 = default;
			Delegate obj8 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj7 = obj5;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					object obj7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag2 = (object)obj8 != obj3;
				obj3 = obj8;
				if (!flag2)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_006a: Expected Obj, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected Obj, but got Unknown
			//IL_004d: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj = 0;
			object obj2 = this + 80;
			Delegate obj3 = (Delegate)obj2;
			object obj5 = default;
			Delegate obj8 = default;
			while (true)
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag = obj5 == null;
					object obj6 = !flag;
					object obj7 = obj5;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					object obj7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag2 = (object)obj8 != obj3;
				obj3 = obj8;
				if (!flag2)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	private static void ForgetShared()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
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
		object obj4 = (nint)0 + (nint)24;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_09bb: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_09d9: Expected Obj, but got I
		//IL_09ea: Expected Obj, but got I
		//IL_0a08: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0a2c: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I
		//IL_04c6: Expected Obj, but got I4
		//IL_04cf: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I
		//IL_0487: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_0540: Expected Obj, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I
		//IL_063e: Expected Obj, but got I4
		//IL_0647: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I
		//IL_05ff: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_06a0: Expected Obj, but got I4
		//IL_06a9: Expected Obj, but got I4
		//IL_0aaf: Expected Obj, but got I4
		//IL_06d3: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I4
		//IL_076e: Expected Obj, but got I4
		//IL_08c6: Expected Obj, but got I4
		//IL_08cf: Expected Obj, but got I4
		//IL_0865: Expected Obj, but got I
		//IL_0887: Expected Obj, but got I4
		//IL_0897: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I4
		//IL_07bb: Expected Obj, but got I4
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected Obj, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		//IL_0942: Expected Obj, but got I4
		//IL_094b: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I
		//IL_0811: Expected Obj, but got I4
		//IL_081a: Expected Obj, but got I4
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Pointing(fingertips))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v73+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v73+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v49+18]");
			bool flag3 = Pointing((Transform[])0);
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v77+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v77+A0]");
				object obj10 = (nint)0 + (nint)24;
				obj10 = fingertips;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
		}
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5F40]");
		object obj11 = 0;
		Vector3 localPosition = transform.localPosition;
		Vector3 vector = default;
		rest = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj12 = this + 112;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = this + 64;
		object obj15 = obj14;
		bool flag6 = obj14 == null;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj18 = default;
			obj14 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj15 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41A8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj20 = this + 120;
		object obj21 = default;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X20_v7-38]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj23 = this + 128;
		UnityEngine.Object obj24 = default;
		obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X21_v7-40]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B58]");
		object obj27 = 0;
		object obj28 = this + 72;
		object obj29 = 0;
		UnityEngine.Object obj30 = obj24;
		UnityEngine.Object obj56 = default;
		IndexOutOfRangeException ex = default;
		while (true)
		{
			object obj31 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v11+18]");
			if ((nint)obj31 >= 0)
			{
				return;
			}
			object obj32 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v11+18]");
			bool flag7 = (nint)obj32 < 0;
			object obj33 = !flag7;
			if (obj33 == null)
			{
				object obj34 = obj26;
				object obj35 = obj25 + obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v33+E4]");
				bool flag8 = (nint)0 == 0;
				object obj36 = !flag8;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v14+20]");
				bool flag9 = (UnityEngine.Object)0 == null;
				bool flag10 = !flag9;
				object obj37 = 0;
				obj30 = null;
				if (!flag10)
				{
					goto IL_036a;
				}
				object obj38 = obj14;
				object obj39 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v15+18]");
				bool flag11 = (nint)obj39 < 0;
				object obj40 = !flag11;
				obj37 = 0;
				obj30 = null;
				if (obj40 == null)
				{
					object obj41 = obj38 + obj29;
					object obj42 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v16+20]");
					Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
					bool flag12 = sharedMaterials == null;
					UnityEngine.Object obj43 = null;
					if (!flag12)
					{
						object obj44 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v41+40]");
						obj43 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag13 = ex == null;
						obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v41+40]");
						obj30 = (UnityEngine.Object)0;
						if (flag13)
						{
							break;
						}
					}
					object obj45 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X27_v7+18]");
					bool flag14 = (nint)obj45 < 0;
					object obj46 = !flag14;
					obj37 = 0;
					obj30 = obj43;
					if (obj46 == null)
					{
						object obj47 = obj42 + obj29;
						object obj48 = obj47 + 32;
						obj48 = sharedMaterials;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj49 = obj20;
						object obj50 = obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v19+18]");
						bool flag15 = (nint)obj50 < 0;
						object obj51 = !flag15;
						obj37 = 0;
						obj30 = (UnityEngine.Object)(object)sharedMaterials;
						if (obj51 == null)
						{
							object obj52 = obj49 + obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v20+20]");
							object obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v21+18]");
							UnityEngine.Object obj54 = (UnityEngine.Object)0;
							object obj55 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							if ((object)obj56 != null)
							{
								object obj57 = obj55;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v40+40]");
								obj54 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag16 = ex == null;
								obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v40+40]");
								obj30 = (UnityEngine.Object)0;
								if (flag16)
								{
									break;
								}
							}
							object obj58 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X27_v8+18]");
							bool flag17 = (nint)obj58 < 0;
							object obj59 = !flag17;
							obj37 = 0;
							obj30 = obj54;
							if (obj59 == null)
							{
								object obj60 = obj55 + obj29;
								object obj61 = obj60 + 32;
								obj61 = obj56;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj62 = obj23;
								object obj63 = 0;
								obj37 = 0;
								obj30 = obj56;
								while (true)
								{
									object obj64 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v25+18]");
									bool flag18 = (nint)obj64 < 0;
									object obj65 = !flag18;
									if (obj65 != null)
									{
										break;
									}
									object obj66 = obj62 + obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v26+20]");
									object obj67 = 0;
									object obj68 = obj63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X28_v9+18]");
									if ((nint)obj68 >= 0)
									{
										goto IL_036a;
									}
									object obj69 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v50+E4]");
									bool flag19 = (nint)0 == 0;
									object obj70 = !flag19;
									if (obj70 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag20 = (UnityEngine.Object)obj28 != null;
									bool flag21 = !flag20;
									object obj71 = !flag21;
									object obj72 = obj28;
									if (obj71 == null)
									{
										object obj73 = obj20;
										object obj74 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v35+18]");
										bool flag22 = (nint)obj74 < 0;
										object obj75 = !flag22;
										obj37 = 0;
										obj30 = null;
										if (obj75 != null)
										{
											break;
										}
										object obj76 = obj73 + obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v36+20]");
										object obj77 = 0;
										object obj78 = obj63;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v37+18]");
										bool flag23 = (nint)obj78 < 0;
										object obj79 = !flag23;
										obj37 = 0;
										obj30 = null;
										if (obj79 != null)
										{
											break;
										}
										object obj80 = obj77 + obj63;
										obj72 = obj80 + 32;
									}
									bool flag24 = obj72 == null;
									UnityEngine.Object obj81 = null;
									if (!flag24)
									{
										object obj82 = obj67;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v34+40]");
										obj81 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag25 = ex == null;
										obj37 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v34+40]");
										obj30 = (UnityEngine.Object)0;
										if (flag25)
										{
											goto end_IL_0a45;
										}
									}
									object obj83 = obj63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X28_v9+18]");
									bool flag26 = (nint)obj83 < 0;
									object obj84 = !flag26;
									obj37 = 0;
									obj30 = obj81;
									if (obj84 != null)
									{
										break;
									}
									object obj85 = obj67 + obj63;
									object obj86 = obj85 + 32;
									obj86 = obj72;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj62 = obj23;
									obj63++;
									bool flag27 = obj23 == null;
									object obj87 = !flag27;
									obj37 = 0;
									obj30 = (UnityEngine.Object)obj72;
									if (obj87 != null)
									{
										continue;
									}
									goto IL_0961;
								}
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			break;
			IL_036a:
			obj25 = obj14;
			obj29++;
			bool flag28 = obj14 == null;
			object obj88 = !flag28;
			if (obj88 != null)
			{
				continue;
			}
			goto IL_0961;
			IL_0961:
			throw new NullReferenceException();
			continue;
			end_IL_0a45:
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private unsafe void Update()
	{
		//IL_0583: Invalid comparison between F4 and I4
		//IL_0594: Expected Obj, but got I4
		//IL_059f: Invalid comparison between F4 and I4
		//IL_05b0: Expected Obj, but got I4
		//IL_00c9: Expected F4, but got I
		//IL_001b: Expected Obj, but got I4
		//IL_05eb: Expected I4, but got I8
		//IL_0605: Expected Obj, but got I4
		//IL_00b4: Expected F4, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_06a3: Invalid comparison between F4 and I4
		//IL_06b6: Expected Obj, but got F4
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06f4: Expected Obj, but got I4
		//IL_01a1: Expected F4, but got I4
		//IL_0623: Expected Obj, but got I
		//IL_063b: Expected Obj, but got I
		//IL_073f: Expected Obj, but got I4
		//IL_0757: Invalid comparison between F4 and I4
		//IL_0768: Expected Obj, but got I4
		//IL_07e6: Expected Obj, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I
		//IL_0858: Expected Obj, but got I
		//IL_0870: Expected Obj, but got I
		//IL_07be: Expected VT, but got I4
		//IL_07be: Expected VT, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I4
		//IL_0212: Expected VT, but got I4
		//IL_0547: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		//IL_025c: Invalid comparison between F4 and I4
		//IL_083b: Expected Obj, but got I
		//IL_035b: Expected Obj, but got I
		//IL_0372: Expected VT, but got I4
		//IL_03a2: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I4
		//IL_0416: Expected VT, but got Ref
		//IL_048f: Expected Obj, but got I4
		//IL_04f2: Expected I4, but got I8
		bool flag = depth < 0f;
		object obj = !flag;
		bool flag2 = depth == 0f;
		object obj2 = !flag2;
		object obj3 = obj & obj2;
		if (obj3 == null)
		{
			bool flag3 = (byte)(~(touching ? 1u : 0u)) != 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				float time = Time.time;
				if (!(time < heldUntil))
				{
					bool flag4 = (byte)(~(shownDown ? 1u : 0u)) != 0;
					object obj5 = !flag4;
					if (obj5 == null && !FingerNear())
					{
						bool isDeviceActive = XRSettings.isDeviceActive;
						bool flag5 = !isDeviceActive;
						object obj6 = !flag5;
						if (obj6 != null)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
						object obj7 = 0;
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v57+A0]");
						object obj9 = 0;
						object obj10 = obj9;
						if (obj9 == null)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v59+1C0]");
						bool wasPressedThisFrame = ((ButtonControl)0).wasPressedThisFrame;
						bool flag6 = !wasPressedThisFrame;
						object obj11 = !flag6;
						if (obj11 == null)
						{
							return;
						}
					}
				}
			}
		}
		float slack;
		if (!touching)
		{
			slack = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
			slack = 0f;
		}
		int num = TouchingHand(slack);
		int num2 = (int)(num & 0x80000000L);
		bool flag7 = num2 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			bool flag8 = (byte)(~(touching ? 1u : 0u)) != 0;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				Press(num);
			}
		}
		int num3 = ~num;
		int num4 = num3 >> 31;
		touching = (byte)num4 != 0;
		bool isDeviceActive2 = XRSettings.isDeviceActive;
		bool flag9 = !isDeviceActive2;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v25+A0]");
			object obj17 = 0;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v30+A0]");
				object obj20 = 0;
				object obj21 = obj20;
				if (obj20 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v32+1C0]");
					if (((ButtonControl)0).wasPressedThisFrame)
					{
						Camera main = Camera.main;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v33+E4]");
						bool flag10 = (nint)0 == 0;
						object obj24 = !flag10;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = main != null;
						bool flag12 = !flag11;
						int num5 = 0;
						if (!flag12)
						{
							Camera main2 = Camera.main;
							object obj25 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v36+A0]");
							object obj26 = 0;
							object obj27 = obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v38+188]");
							Vector2 vector = ((InputControl<Vector2>)0).ReadValue();
							Ray ray = main2.ScreenPointToRay((Vector3)0);
							GameObject gameObject = base.gameObject;
							int layer = gameObject.layer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
							object obj28 = 0;
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v44+E4]");
							bool flag13 = (nint)0 == 0;
							object obj30 = !flag13;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							num5 = 1 << layer;
							object obj31 = default;
							if (Physics.Raycast((Ray)(&obj31), out var hitInfo, 5f, num5, (QueryTriggerInteraction)2))
							{
								Collider collider = hitInfo.collider;
								GameObject gameObject2 = collider.gameObject;
								GameObject gameObject3 = base.gameObject;
								object obj32 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v46+E4]");
								bool flag14 = (nint)0 == 0;
								object obj33 = !flag14;
								if (obj33 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag15 = gameObject2 == gameObject3;
								bool flag16 = !flag15;
								num5 = 0;
								if (!flag16)
								{
									Press(-1);
									num5 = 0;
								}
							}
						}
					}
				}
			}
		}
		bool flag17 = (byte)(~(touching ? 1u : 0u)) != 0;
		object obj34 = !flag17;
		float num6;
		if (obj34 == null)
		{
			float time2 = Time.time;
			bool flag18 = !(time2 < heldUntil);
			num6 = 0f;
			if (flag18)
			{
				goto IL_0658;
			}
		}
		num6 = travel;
		goto IL_0658;
		IL_0658:
		float deltaTime = Time.deltaTime;
		float num7 = deltaTime * travel;
		float num8 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num9 = num8 / 0f;
		float num10 = num6 - depth;
		bool flag19 = num10 < 0f;
		object obj35 = num10 ^ num10;
		object obj36 = num10 & obj35;
		bool flag20 = (nint)obj36 < 0;
		float num11 = 0f - num9;
		bool flag21 = flag19 == flag20;
		object obj37 = !flag21;
		object obj38 = ~obj37;
		float num12 = ((obj38 != null) ? num9 : num11);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num13 = depth + num12;
		bool flag22 = num11 < num9;
		object obj39 = !flag22;
		float num14 = num11 - num9;
		bool flag23 = num14 == 0f;
		object obj40 = !flag23;
		object obj41 = obj39 & obj40;
		object obj42 = ~obj41;
		float num15 = ((obj42 != null) ? num6 : num13);
		depth = num15;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Quaternion localRotation = transform2.localRotation;
		Vector3 vector2 = (Quaternion)0 * (Vector3)0;
		transform.localPosition = (Vector3)0;
		bool down;
		if (~(touching ? 1u : 0u) == 0)
		{
			down = true;
		}
		else
		{
			float time3 = Time.time;
			float num16 = time3 - heldUntil;
			bool flag24 = num16 < 0f;
			down = flag24;
		}
		ShowDown(down);
	}

	private bool FingerNear()
	{
		//IL_0021: Expected Obj, but got I4
		//IL_02e6: Expected I4, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I8
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_01e6: Expected Obj, but got I
		//IL_025f: Invalid comparison between Obj and F8
		Transform[] array = fingertips;
		if (fingertips != null)
		{
			bool flag = array.Length == 0;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0056;
			}
		}
		if (Borrow())
		{
			goto IL_0056;
		}
		goto IL_02ae;
		IL_02ae:
		return false;
		IL_0056:
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			Transform[] array2 = fingertips;
			if (fingertips != null)
			{
				if (array2.Length < 1)
				{
					goto IL_02ae;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = array2.Length & 0xFFFFFFFFL;
				object obj4 = fingertips + 32;
				object obj6 = default;
				object obj5 = obj6;
				object obj8 = default;
				object obj7 = obj8;
				object obj10 = default;
				object obj9 = obj10;
				object obj11 = 0;
				UnityEngine.Object obj12 = null;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj13 = !flag2;
					if (obj13 == null)
					{
						object obj14 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v13+E4]");
						bool flag3 = (nint)0 == 0;
						object obj15 = !flag3;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v5+v151 @ X21_v6*8]");
						bool flag4 = (UnityEngine.Object)0 != null;
						bool flag5 = !flag4;
						obj12 = null;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v5+v151 @ X21_v6*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v5+v151 @ X21_v6*8]");
							Vector3 position2 = ((Transform)0).position;
							object obj16 = obj9 - obj10;
							object obj17 = obj7 - obj8;
							obj5 -= obj6;
							object obj18 = obj16 * obj16;
							object obj19 = obj17 * obj17;
							object obj20 = obj18 + obj19;
							obj7 = obj5 * obj5;
							obj9 = obj7 + obj20;
							bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0);
							obj12 = null;
							if (flag6)
							{
								return true;
							}
						}
						obj3 = array2.Length;
						obj11++;
						if ((nint)obj11 < array2.Length)
						{
							continue;
						}
						goto IL_02ae;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					break;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	private bool Borrow()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_046a: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_052c: Expected Obj, but got I
		//IL_053d: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I4
		//IL_0433: Expected I4, but got Obj
		//IL_056e: Expected Obj, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_0589: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I8
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		//IL_0181: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_02fb: Expected I, but got Obj
		//IL_0312: Expected Obj, but got I4
		//IL_0317: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_04f4: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I4
		float unscaledTime = Time.unscaledTime;
		object obj;
		object obj10;
		nint num2;
		if (!(unscaledTime < nextBorrow))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
			obj = 0;
			float unscaledTime2 = Time.unscaledTime;
			object obj2 = obj;
			float num = unscaledTime2 + 1f;
			nextBorrow = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v8+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v6+18]");
			bool flag2 = Pointing((Transform[])0);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v25+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE898]");
				object obj9 = 0;
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD840");
				object obj11 = default;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v28+18]");
					bool flag5 = (nint)0 < (nint)1;
					num2 = unchecked((nint)null);
					if (flag5)
					{
						goto IL_036b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v28+18]");
					object obj12 = 0 & 0xFFFFFFFFL;
					object obj13 = obj11 + 32;
					object obj14 = 0;
					nint num3 = unchecked((nint)null);
					while (true)
					{
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
						object obj15 = !flag6;
						if (obj15 == null)
						{
							object obj16 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X26_v6+v220 @ X25_v7*8]");
							UnityEngine.Object obj17 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v33+E4]");
							bool flag7 = (nint)0 == 0;
							object obj18 = !flag7;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X26_v6+v220 @ X25_v7*8]");
							if ((UnityEngine.Object)0 != this)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X26_v6+v220 @ X25_v7*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								object obj19 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v38+E4]");
								bool flag8 = (nint)0 == 0;
								object obj20 = !flag8;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X21_v7 (UnityEngine.Object)+28]");
								bool flag9 = Pointing((Transform[])0);
								bool flag10 = !flag9;
								object obj21 = !flag10;
								if (obj21 != null)
								{
									goto IL_031c;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v28+18]");
							obj12 = 0;
							obj14++;
							object obj22 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v28+18]");
							bool flag11 = (nint)obj22 < 0;
							obj10 = 0;
							num3 = (nint)this;
							if (flag11)
							{
								continue;
							}
							goto IL_0309;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_036b;
		}
		goto IL_0409;
		IL_0309:
		obj10 = 0;
		num2 = (nint)this;
		goto IL_036b;
		IL_036b:
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v13+E4]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v13+A0]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v9+18]");
		if (Pointing((Transform[])0))
		{
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v17+E4]");
			bool flag13 = (nint)0 == 0;
			object obj27 = !flag13;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v17+A0]");
			object obj28 = 0;
			object obj29 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v11+18]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return true;
		}
		goto IL_0409;
		IL_0409:
		return false;
		IL_031c:
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v43+E4]");
		bool flag14 = (nint)0 == 0;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v43+A0]");
		object obj32 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X21_v7 (UnityEngine.Object)+28]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X21_v7 (UnityEngine.Object)+28]");
		num2 = 0;
		goto IL_036b;
	}

	private static bool Pointing(Transform[] tips)
	{
		//IL_0038: Expected Obj, but got I8
		//IL_0048: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0140: Expected I4, but got Obj
		//IL_008e: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		bool flag3;
		if (tips != null && tips.Length >= 1)
		{
			object obj = tips.Length & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = tips + 32;
			object obj4 = 0;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj5 = !flag;
				if (obj5 == null)
				{
					object obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v7+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X23_v3+v84 @ X21_v4*8]");
					flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					object obj8 = !flag4;
					if (obj8 != null)
					{
						break;
					}
					obj = tips.Length;
					obj4++;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				return (byte)(int)ex != 0;
			}
			while ((nint)obj4 < tips.Length);
		}
		else
		{
			flag3 = false;
		}
		return flag3;
	}

	private int TouchingHand(float slack)
	{
		//IL_0096: Expected I4, but got I8
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_082a: Expected I4, but got Obj
		//IL_00f9: Expected Obj, but got I4
		//IL_0880: Expected Obj, but got I
		//IL_0898: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_0496: Expected Obj, but got I
		//IL_04b4: Expected Obj, but got I4
		//IL_07f7: Expected Obj, but got I4
		//IL_0800: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got I4
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_055e: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I4
		//IL_066b: Invalid comparison between F8 and I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_06fb: Expected Obj, but got I4
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected Obj, but got Unknown
		//IL_06c6: Expected Obj, but got I4
		//IL_06de: Invalid comparison between F8 and I4
		//IL_074e: Expected Obj, but got I4
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_0719: Expected Obj, but got I4
		//IL_0731: Invalid comparison between F8 and I4
		//IL_076b: Invalid comparison between F8 and I4
		//IL_077e: Expected Obj, but got F8
		//IL_078b: Expected Obj, but got F8
		object obj;
		if (fingertips != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(box == null))
			{
				Transform transform = base.transform;
				if ((object)transform != null)
				{
					Transform parent = transform.parent;
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(parent != null))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
						object obj6 = 0;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v25+A0]");
						object obj8 = 0;
						goto IL_0849;
					}
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Transform parent2 = transform2.parent;
						if ((object)parent2 != null)
						{
							Matrix4x4 localToWorldMatrix = parent2.localToWorldMatrix;
							goto IL_0849;
						}
					}
				}
				goto IL_080e;
			}
		}
		goto IL_0089;
		IL_0849:
		Transform transform3 = base.transform;
		int num17;
		if ((object)transform3 != null)
		{
			Quaternion localRotation = transform3.localRotation;
			Transform transform4 = base.transform;
			if ((object)transform4 != null)
			{
				Vector3 localScale = transform4.localScale;
				Vector3 pos = default;
				Quaternion q = default;
				Vector3 s = default;
				Matrix4x4 matrix4x = Matrix4x4.Internal_TRS(ref pos, ref q, ref s);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DF8E5C");
				Matrix4x4 m = default;
				Matrix4x4 matrix4x2 = Matrix4x4.Internal_Inverse(ref m);
				Transform transform5 = base.transform;
				if ((object)transform5 != null)
				{
					Vector3 lossyScale = transform5.lossyScale;
					if ((object)box != null)
					{
						Vector3 center = box.center;
						if ((object)box != null)
						{
							Vector3 size = box.size;
							Transform[] array = fingertips;
							if (fingertips != null)
							{
								float num = fingerRadius + hover;
								float num2 = fingerRadius + slack;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
								float num3 = num + slack;
								float num4 = num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								float num5 = num4 / 0f;
								float num6 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								float num7 = num6 / 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
								object obj9 = num8 / 0;
								object obj10 = default;
								double num9 = (double)obj10 * 0.5;
								object obj11 = default;
								double num10 = (double)obj11 * 0.5;
								object obj12 = default;
								double num11 = (double)obj12 * 0.5;
								float num12 = num5 + (float)num9;
								float num13 = num5 + (float)num10;
								float num14 = num7 + (float)num11;
								double num15 = num11 - (double)obj9;
								double num16 = 0.5;
								object obj13 = 0;
								UnityEngine.Object obj14 = null;
								num17 = 0;
								object obj22 = default;
								object obj23 = default;
								object obj24 = default;
								object obj25 = default;
								float num30 = default;
								while (num17 < array.Length)
								{
									bool flag3 = num17 < array.Length;
									object obj15 = !flag3;
									if (obj15 == null)
									{
										object obj16 = obj;
										object obj17 = array + num17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v40+E4]");
										bool flag4 = (nint)0 == 0;
										object obj18 = !flag4;
										if (obj18 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v16+20]");
										bool flag5 = (UnityEngine.Object)0 == null;
										bool flag6 = !flag5;
										object obj19 = !flag6;
										obj14 = null;
										if (obj19 != null)
										{
											goto IL_07c3;
										}
										Transform[] array2 = fingertips;
										if (fingertips != null)
										{
											bool flag7 = num17 < array2.Length;
											object obj20 = !flag7;
											if (obj20 != null)
											{
												goto IL_081c;
											}
											object obj21 = fingertips + num17;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v20+20]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v20+20]");
												Vector3 position = ((Transform)0).position;
												double num18 = (double)obj22 * num11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v26+70]");
												double num19 = 0.0 * num9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v26+50]");
												double num20 = 0.0 * num9;
												double num21 = (double)obj23 * num11;
												num7 = (float)num19 + (float)num18;
												num16 = (double)obj12 * num10;
												double num22 = num20 + num21;
												double num23 = num16 + (double)num7;
												num10 = (double)obj24 * num10;
												num11 = (double)obj25 + num23;
												double num24 = num10 + num22;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
												double num25 = (double)obj10 + num24;
												bool flag8 = num10 < (double)num12;
												object obj26 = !flag8;
												double num26 = num10 - (double)num12;
												bool flag9 = num26 == 0.0;
												num9 = num25 - (double)obj12;
												object obj27 = ~obj26;
												object obj28 = obj27 | flag9;
												object obj29 = ~obj28;
												object obj30;
												bool flag11;
												if (obj29 == null)
												{
													bool flag10 = num11 < (double)num13;
													obj30 = !flag10;
													double num27 = num11 - (double)num13;
													flag11 = num27 == 0.0;
												}
												else
												{
													flag11 = false;
													obj30 = 1;
												}
												object obj31 = ~obj30;
												object obj32 = obj31 | flag11;
												object obj33 = ~obj32;
												object obj34;
												bool flag13;
												if (obj33 == null)
												{
													bool flag12 = num9 < (double)num14;
													obj34 = !flag12;
													double num28 = num9 - (double)num14;
													flag13 = num28 == 0.0;
												}
												else
												{
													flag13 = false;
													obj34 = 1;
												}
												object obj35 = ~obj34;
												object obj36 = obj35 | flag13;
												object obj37 = ~obj36;
												bool flag14;
												bool flag15;
												if (obj37 == null)
												{
													double num29 = num9 - num15;
													flag14 = num29 < 0.0;
													object obj38 = num9 ^ num15;
													object obj39 = num9 ^ num29;
													object obj40 = obj38 & obj39;
													flag15 = (nint)obj40 < 0;
												}
												else
												{
													flag15 = false;
													flag14 = true;
												}
												bool flag16 = flag14 == flag15;
												obj9 = obj10;
												num5 = num30;
												obj14 = null;
												if (!flag16)
												{
													goto IL_07c3;
												}
												goto IL_0949;
											}
										}
										goto IL_080e;
									}
									goto IL_081c;
									IL_07c3:
									array = fingertips;
									num17++;
									bool flag17 = fingertips == null;
									object obj41 = !flag17;
									obj13 = 0;
									if (obj41 != null)
									{
										continue;
									}
									goto IL_080e;
								}
								goto IL_0089;
							}
						}
					}
				}
			}
		}
		goto IL_080e;
		IL_081c:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_0949:
		return num17;
		IL_0089:
		num17 = -1;
		goto IL_0949;
		IL_080e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_081c;
	}

	public void Click()
	{
		//IL_000f: Expected I4, but got I8
		Press(-1);
	}

	private void Press(int hand)
	{
		//IL_0010: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_015e: Expected VT, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_01b8: Expected I4, but got I8
		//IL_01d2: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_02ab: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE890]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = GillaOneArm.Resting(hand);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Func<PressKey, int, bool> allow = Allow;
		bool flag4 = Allow == null;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ X8_v5 (System.Func`3<PressKey, System.Int32, System.Boolean>)+18] (should have been resolved before IL gen)");
			object obj6 = default;
			object obj5 = obj6 & 1;
			bool flag5 = obj5 == null;
			num = hand;
			if (flag5)
			{
				return;
			}
		}
		float time = Time.time;
		Action<PressKey> pressed = this.m_Pressed;
		float num2 = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		float num3 = num2 + 0f;
		heldUntil = num3;
		if (this.m_Pressed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7 (System.Action`1<PressKey>)+28]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ X8_v7 (System.Action`1<PressKey>)+18] (should have been resolved before IL gen)");
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
		object obj7 = 0;
		Vector3 at = (Vector3)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v15 (UnityEngine.Vector3)+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sound(at);
		int num4 = (int)(hand & 0x80000000L);
		bool flag7 = num4 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			bool flag8 = hand == 0;
			object obj10 = !flag8;
			object obj11 = ~obj10;
			XRNode node = ((obj11 != null) ? ((XRNode)4) : ((XRNode)5));
			UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			UnityEngine.XR.InputDevice inputDevice = default;
			bool flag9 = inputDevice.SendHapticImpulse(0u, 0.25f, 0f);
		}
	}

	private void ShowDown(bool down)
	{
		//IL_004d: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00fd: Expected I, but got Obj
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_0172: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_024c: Expected I, but got Obj
		//IL_0254: Expected I4, but got Obj
		//IL_020f: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I
		if (shownDown == down || upMaterials == null)
		{
			return;
		}
		Renderer[] array = caps;
		shownDown = down;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		bool flag = down;
		object obj2 = 4;
		while (true)
		{
			object obj3 = obj2 - 4;
			if ((nint)obj3 >= array.Length)
			{
				return;
			}
			bool flag2 = (nint)obj3 < array.Length;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8 (UnityEngine.Renderer[])+v99 @ X23_v5*8]");
			bool flag4 = (UnityEngine.Object)0 != null;
			bool flag5 = !flag4;
			nint num = unchecked((nint)null);
			flag = false;
			if (!flag5)
			{
				Material[][] array2 = upMaterials;
				bool flag6 = (nint)obj3 < array2.Length;
				object obj7 = !flag6;
				if (obj7 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v12 (UnityEngine.Material[][])+v99 @ X23_v5*8]");
				flag = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v12 (UnityEngine.Material[][])+v99 @ X23_v5*8]");
				bool flag7 = (byte)(~(nuint)0u) != 0;
				num = unchecked((nint)null);
				if (!flag7)
				{
					Renderer[] array3 = caps;
					bool flag8 = (nint)obj3 < array3.Length;
					object obj8 = !flag8;
					if (obj8 != null)
					{
						break;
					}
					bool flag9 = !down;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v12 (UnityEngine.Material[][])+v99 @ X23_v5*8]");
					Material[] array4 = (Material[])0;
					if (!flag9)
					{
						Material[][] array5 = downMaterials;
						bool flag10 = (nint)obj3 < array5.Length;
						object obj9 = !flag10;
						if (obj9 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v15 (UnityEngine.Material[][])+v99 @ X23_v5*8]");
						array4 = (Material[])0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v13 (UnityEngine.Renderer[])+v99 @ X23_v5*8]");
					((Renderer)0).sharedMaterials = array4;
					num = unchecked((nint)null);
					flag = (byte)(int)array4 != 0;
				}
			}
			array = caps;
			obj2++;
			bool flag11 = caps == null;
			object obj10 = !flag11;
			if (obj10 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	private static void Sound(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I
		//IL_0799: Expected Obj, but got I4
		//IL_0964: Expected Obj, but got I
		//IL_0986: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I4
		//IL_081c: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I
		//IL_0406: Expected VT, but got I4
		//IL_013d: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I4
		//IL_07bd: Expected Obj, but got I
		//IL_07e7: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I
		//IL_0889: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_04dc: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I
		//IL_08be: Expected Obj, but got I
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected I4, but got Unknown
		//IL_08f3: Expected Obj, but got I
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected Obj, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected Obj, but got Unknown
		//IL_0935: Expected Obj, but got I4
		//IL_0526: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I4
		//IL_086b: Expected Obj, but got I4
		//IL_066f: Expected Obj, but got I4
		//IL_0357: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I4
		//IL_09a4: Expected Obj, but got I
		//IL_09c6: Expected F4, but got I
		//IL_09c6: Expected F4, but got I
		//IL_06a0: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I4
		//IL_06e1: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I
		//IL_0745: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1+8]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		double num2 = default;
		double num = num2;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_0377;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj11);
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v49+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v35+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v35+A0]");
			object obj17 = (nint)0 + (nint)8;
			object obj18 = default;
			obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v36+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v37+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v37+8]");
				((AudioSource)0).playOnAwake = false;
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v38+A0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v39+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v39+8]");
					((AudioSource)0).spatialBlend = 1f;
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v40+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v41+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v41+8]");
						((AudioSource)0).priority = 0;
						object obj25 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v42+A0]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v43+8]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v43+8]");
							((AudioSource)0).dopplerLevel = 0f;
							object obj27 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v44+A0]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v45+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v45+8]");
								((AudioSource)0).minDistance = 1f;
								object obj29 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v46+A0]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v47+8]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v47+8]");
									((AudioSource)0).maxDistance = 20f;
									num = 20.0;
									obj8 = 0;
									obj9 = null;
									goto IL_0377;
								}
							}
						}
					}
				}
			}
		}
		goto IL_074a;
		IL_0758:
		throw new IndexOutOfRangeException();
		IL_093a:
		AudioSource audioSource;
		AudioClip clip;
		float volumeScale;
		audioSource.PlayOneShot(clip, volumeScale);
		return;
		IL_074a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0758;
		IL_0377:
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v13+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9+8]");
			Transform transform = ((Component)0).transform;
			if ((object)transform != null)
			{
				transform.position = (Vector3)0;
				GillaSounds gillaSounds = GillaSounds.Get();
				object obj34 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v10+E4]");
				bool flag8 = (nint)0 == 0;
				object obj35 = !flag8;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (gillaSounds != null)
				{
					if ((object)gillaSounds == null)
					{
						goto IL_074a;
					}
					AudioClip[] keyPresses = gillaSounds.keyPresses;
					if (gillaSounds.keyPresses != null)
					{
						object obj36 = keyPresses.Length;
						if (keyPresses.Length != 0)
						{
							object obj37;
							if (keyPresses.Length == 1)
							{
								obj37 = 0;
								object obj38 = 0;
								int num3 = 0;
							}
							else
							{
								object obj39 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v38+E4]");
								bool flag9 = (nint)0 == 0;
								object obj40 = !flag9;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj39 = obj;
									obj36 = keyPresses.Length;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v38+A0]");
								object obj41 = 0;
								int num3 = obj36 - 1;
								int num4 = UnityEngine.Random.Range(0, num3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X9_v10+10]");
								object obj42 = (nint)0 + (nint)num4;
								object obj43 = obj42 + 1;
								object obj44 = obj43 / keyPresses.Length;
								object obj45 = obj44 * keyPresses.Length;
								obj37 = obj43 - obj45;
								object obj38 = 0;
							}
							object obj46 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v31+E4]");
							bool flag10 = (nint)0 == 0;
							object obj47 = !flag10;
							if (obj47 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj46 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v31+A0]");
							object obj48 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC78]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADD8]");
							float pitch = UnityEngine.Random.Range(num5, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v20+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v20+8]");
								((AudioSource)0).pitch = pitch;
								bool flag11 = (nint)obj37 < keyPresses.Length;
								object obj49 = !flag11;
								if (obj49 != null)
								{
									goto IL_0758;
								}
								object obj50 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v23+A0]");
								object obj51 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24+8]");
								audioSource = (AudioSource)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v24+8]");
								if ((nint)0 != 0)
								{
									object obj52 = (object)gillaSounds.keyPresses + obj37;
									volumeScale = gillaSounds.keyPressVolume;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v25+20]");
									clip = (AudioClip)0;
									goto IL_093a;
								}
							}
							goto IL_074a;
						}
					}
				}
				object obj53 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v23+E4]");
				bool flag12 = (nint)0 == 0;
				object obj54 = !flag12;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj53 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v23+A0]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v14+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v14+8]");
					((AudioSource)0).pitch = 1f;
					object obj56 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v15+A0]");
					object obj57 = 0;
					AudioClip audioClip = ClickSound();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v16+8]");
					if ((nint)0 != 0)
					{
						volumeScale = 0.5f;
						clip = audioClip;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v16+8]");
						audioSource = (AudioSource)0;
						goto IL_093a;
					}
				}
			}
		}
		goto IL_074a;
	}

	private static AudioClip ClickSound()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0378: Expected I, but got Obj
		//IL_0398: Expected VT, but got I4
		//IL_0398: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0214: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v31+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			goto IL_029f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F90]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		System.Random random = default;
		random._002Ector(3);
		float[] array = default;
		if (random != null)
		{
			object obj12 = 0;
			int num = 3;
			System.Random random2 = random;
			while (true)
			{
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB44]");
				object obj14 = obj13 / 0;
				object obj15 = obj14 * 3274964992L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB00]");
				object obj16 = obj14 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				nint num2 = (nint)random;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v16 (Il2CppClass<System.Random>)+1C0]");
				num = 0;
				((System.Empty)(object)random).GetObjectData((SerializationInfo)0, (StreamingContext)0);
				if (array == null)
				{
					break;
				}
				bool flag4 = (nint)obj12 < array.Length;
				object obj17 = !flag4;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					object obj18 = obj16 * 0;
					object obj19 = (object)array + obj12;
					obj12++;
					object obj20 = obj16 + obj16;
					double num3 = (double)obj20 + -1.0;
					double num4 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					double num5 = num4 * 0.0;
					double num6 = (double)obj18 + num5;
					double num7 = (double)obj15 * num6;
					if ((nint)obj12 != 1102)
					{
						continue;
					}
					goto IL_0204;
				}
				goto IL_02ca;
			}
		}
		goto IL_02bc;
		IL_02ca:
		return (AudioClip)(object)new IndexOutOfRangeException();
		IL_0204:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE8A8]");
		object obj21 = 0;
		AudioClip audioClip = AudioClip.Create((string)obj21, 1102, 1, 44100, stream: false);
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj23 = !flag5;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v22+A0]");
		object obj24 = 0;
		obj24 = audioClip;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v25+A0]");
		object obj27 = 0;
		if (obj27 != null)
		{
			bool flag6 = ((AudioClip)obj27).SetData(array, 0);
			goto IL_029f;
		}
		goto IL_02bc;
		IL_029f:
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v6+A0]");
		return (AudioClip)0;
		IL_02bc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02ca;
	}

	public PressKey()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C6E0]");
		fingerRadius = 0f;
		travel = 0.01f;
		base._002Ector();
	}

	static PressKey()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE888]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 4294967295L;
	}
}
