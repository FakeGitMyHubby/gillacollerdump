using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GorillaLocomotion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FallRespawn : MonoBehaviour
{
	public float fallBelow = 5f;

	private const int NotFloors = default(int);

	private Player gt;

	private Transform head;

	private float killY;

	private float tall;

	private Vector3 spawnFeet;

	private Vector3 spawnFacing;

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F38]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj2);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		Attach();
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Attach();
	}

	private static void Attach()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_0352: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj15;
		if ((UnityEngine.Object)obj8 != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v35+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v39+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v39+A0]");
			object obj14 = 0;
			obj15 = (UnityEngine.Object)obj14;
		}
		else
		{
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F50]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v30+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
			UnityEngine.Object obj19 = default;
			obj15 = obj19;
		}
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj15 == null;
		bool flag9 = !flag8;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F40]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj24 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj26 = default;
			if (!(obj26 != null))
			{
				GameObject gameObject = ((Component)obj15).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F48]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			}
		}
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_0712: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I4
		//IL_0730: Expected Obj, but got I
		//IL_0748: Expected Obj, but got I
		//IL_085b: Expected Obj, but got I
		//IL_0878: Expected Obj, but got I
		//IL_0888: Expected Obj, but got I
		//IL_08ba: Expected Obj, but got I
		//IL_08ca: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0767: Expected Obj, but got I
		//IL_0781: Expected Obj, but got I
		//IL_079a: Expected VT, but got I4
		//IL_079a: Expected VT, but got I4
		//IL_07c8: Expected Obj, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected VT, but got Unknown
		//IL_0351: Expected Obj, but got I
		//IL_0687: Expected VT, but got I4
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_037f: Expected Obj, but got I4
		//IL_0388: Expected VT, but got I4
		//IL_07ef: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_040e: Expected Obj, but got I
		//IL_04cd: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I4
		//IL_05b9: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I4
		//IL_061d: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I4
		//IL_063c: Expected Obj, but got I
		//IL_064d: Expected VT, but got Obj
		//IL_0839: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 40;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj7 = 0;
		Component component = this;
		if (flag3)
		{
			goto IL_017d;
		}
		object obj8 = obj3;
		if (obj3 != null)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v68+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v33+20]");
			bool flag5 = (UnityEngine.Object)0 != null;
			bool flag6 = !flag5;
			obj7 = 0;
			component = this;
			if (flag6)
			{
				goto IL_017d;
			}
			object obj11 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v35+20]");
				component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v35+20]");
				bool flag7 = (nint)0 == 0;
				obj7 = 0;
				if (!flag7)
				{
					goto IL_017d;
				}
			}
		}
		goto IL_06ac;
		IL_017d:
		Transform transform = component.transform;
		object obj12 = this + 48;
		obj12 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Transform transform2 = base.transform;
		Vector3 vector4;
		if ((object)transform2 != null)
		{
			Vector3 position = transform2.position;
			Vector3 vector = default;
			spawnFeet = vector;
			Transform transform3 = base.transform;
			if ((object)transform3 != null)
			{
				Vector3 forward = transform3.forward;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj13 = 0;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v12+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+18]");
				object obj16 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+1C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+1C]");
				object obj17 = num2 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
				object obj18 = 0;
				object obj19 = obj18;
				object obj20 = obj16 + obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+20]");
				object obj21 = num3 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v17+A0]");
				object obj22 = 0;
				object obj23 = obj21 + obj20;
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
				object obj25 = default;
				object obj24 = obj25;
				object obj27 = default;
				object obj26 = obj27;
				Vector3 vector2 = vector;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+18]");
					object obj28 = vector * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+1C]");
					object obj29 = obj27 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+20]");
					object obj30 = obj25 * 0;
					object obj31 = obj28 + obj29;
					object obj32 = obj30 + obj31;
					object obj33 = obj32 / obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+18]");
					object obj34 = 0 * obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+1C]");
					object obj35 = 0 * obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v13+20]");
					object obj36 = 0 * obj33;
					vector2 = vector - obj34;
					obj26 = obj27 - obj35;
					obj24 = obj25 - obj36;
				}
				spawnFacing = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F58]");
				object obj37 = 0;
				Vector3 vector3 = spawnFeet;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FallRespawn)+44]");
				object obj38 = 0;
				bool flag9 = GillaTeleport.To((Vector3)0, (Vector3)0);
				object obj39 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v30+E4]");
				bool flag10 = (nint)0 == 0;
				object obj40 = !flag10;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj41 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD840");
				object obj42 = default;
				if (obj42 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v33+18]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v33+18]");
					if ((nint)0 >= (nint)1)
					{
						object obj44 = 0;
						vector4 = (Vector3)2139095040;
						object obj51 = default;
						object obj52 = default;
						while (true)
						{
							bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43);
							object obj45 = !flag11;
							if (obj45 != null)
							{
								break;
							}
							object obj46 = obj42 + obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
								bool isTrigger = ((Collider)0).isTrigger;
								bool flag12 = !isTrigger;
								object obj47 = !flag12;
								if (obj47 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
									GameObject gameObject = ((Component)0).gameObject;
									if ((object)gameObject == null)
									{
										goto IL_06ac;
									}
									int layer = gameObject.layer;
									int num4 = 1 << layer;
									if ((num4 & 0x1F04) == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
										Rigidbody attachedRigidbody = ((Collider)0).attachedRigidbody;
										object obj48 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v29+E4]");
										bool flag13 = (nint)0 == 0;
										object obj49 = !flag13;
										if (obj49 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										if (attachedRigidbody != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
											Rigidbody attachedRigidbody2 = ((Collider)0).attachedRigidbody;
											if ((object)attachedRigidbody2 == null)
											{
												goto IL_06ac;
											}
											bool isKinematic = attachedRigidbody2.isKinematic;
											bool flag14 = !isKinematic;
											obj41 = 0;
											if (flag14)
											{
												goto IL_0475;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
										Transform transform4 = ((Component)0).transform;
										Transform parent = base.transform;
										if ((object)transform4 == null)
										{
											goto IL_06ac;
										}
										bool flag15 = transform4.IsChildOf(parent);
										bool flag16 = !flag15;
										object obj50 = !flag16;
										obj41 = 0;
										if (obj50 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v25+20]");
											Bounds bounds = ((Collider)0).bounds;
											vector3 = (Vector3)(obj51 - obj52);
											if (vector4 >= vector3)
											{
												vector4 = vector3;
											}
											obj38 = obj52;
											obj41 = 0;
										}
									}
								}
								goto IL_0475;
							}
							goto IL_06ac;
							IL_0475:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v33+18]");
							obj43 = 0;
							obj44++;
							object obj53 = obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v33+18]");
							if ((nint)obj53 < 0)
							{
								continue;
							}
							goto IL_07fd;
						}
						goto IL_06ba;
					}
					vector4 = (Vector3)2139095040;
					goto IL_07fd;
				}
			}
		}
		goto IL_06ac;
		IL_07fd:
		object obj54 = vector4 & 0x7FFFFFFF;
		if ((nint)obj54 != 2139095040)
		{
			float num5 = (float)vector4 - fallBelow;
			killY = num5;
		}
		return;
		IL_06ba:
		throw new IndexOutOfRangeException();
		IL_06ac:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06ba;
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I
		//IL_0385: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I4
		//IL_00a4: Expected VT, but got I8
		//IL_00a4: Expected VT, but got Ref
		//IL_03df: Invalid comparison between Obj and F4
		//IL_00f3: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0256: Expected VT, but got I4
		//IL_0195: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I4
		//IL_02ea: Expected VT, but got I4
		//IL_0315: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = head == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Vector3 position = head.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj6 = 0;
		object obj7 = obj5;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X9_v3+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		object obj11 = default;
		if (Physics.Raycast((Vector3)(&num), (Vector3)4294959355L, out *(RaycastHit*)1, 0f, 0, queryTriggerInteraction))
		{
			object obj12 = default;
			float num2 = (float)obj11 - (float)obj12;
			tall = num2;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)killY))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj13 = 0;
		object obj14 = obj;
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v11+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj16 != null)
		{
			object obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v27+A0]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v29+A9]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isMonster = MonsterPlayer.IsMonster;
		bool flag8 = !isMonster;
		object obj25 = !flag8;
		Vector3 eyes = (Vector3)0;
		if (obj25 == null)
		{
			object obj26 = obj13;
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v23+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj29 = !flag9;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = (UnityEngine.Object)obj28 == null;
			bool flag11 = !flag10;
			eyes = (Vector3)0;
			if (flag11)
			{
				object obj30 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v25+A0]");
				object obj31 = 0;
				bool flag12 = ((KillCam)obj31).Fell();
				return;
			}
		}
		Put(eyes);
	}

	private unsafe void Put(Vector3 eyes)
	{
		//IL_0542: Expected Obj, but got I
		//IL_055a: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0622: Expected Obj, but got I
		//IL_0632: Expected Obj, but got I
		//IL_0649: Expected F4, but got Obj
		//IL_0659: Expected Obj, but got I
		//IL_0661: Invalid comparison between F4 and Obj
		//IL_0589: Expected Obj, but got I4
		//IL_0199: Expected F4, but got I
		//IL_01a9: Invalid comparison between F4 and I
		//IL_02b2: Expected Obj, but got I
		//IL_0329: Expected VT, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_035d: Expected VT, but got Ref
		//IL_01d1: Expected Obj, but got VT
		//IL_01ee: Expected Obj, but got I
		//IL_0239: Invalid comparison between F4 and I
		//IL_0461: Expected Obj, but got I
		//IL_048b: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_039a: Expected VT, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_03cf: Expected VT, but got I4
		//IL_03f0: Expected VT, but got I4
		//IL_040d: Expected Obj, but got I
		//IL_041d: Expected F4, but got I
		//IL_042d: Expected F4, but got I
		//IL_0435: Expected F4, but got Obj
		//IL_0443: Expected VT, but got I4
		//IL_044c: Expected VT, but got I4
		Vector3 forward = head.forward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v6+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+18]");
		object obj4 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+1C]");
		object obj5 = num2 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+20]");
		object obj9 = num3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v11+A0]");
		object obj10 = 0;
		float num4 = (float)obj9 + (float)obj8;
		float num5 = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
		float num7 = default;
		float num6 = num7;
		float num8 = num7;
		float num10 = default;
		float num9 = num10;
		float num12 = default;
		float num11 = num12;
		if (!flag)
		{
			float num13 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+18]");
			float num14 = num13 * 0f;
			float num15 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+1C]");
			float num16 = num15 * 0f;
			float num17 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+20]");
			float num18 = num17 * 0f;
			float num19 = num14 + num16;
			float num20 = num18 + num19;
			float num21 = num20 / num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+18]");
			num5 = 0f * num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+1C]");
			num6 = 0f * num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v7+20]");
			num4 = 0f * num21;
			num11 = num12 - num5;
			num9 = num10 - num6;
			num8 = num7 - num4;
		}
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gt != null)
		{
			float num22 = num11 * num11;
			float num23 = num9 * num9;
			float num24 = num22 + num23;
			float num25 = num8 * num8;
			num5 = num24 + num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			num4 = 0f;
			float num26 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			if (num26 > 0f)
			{
				object obj14 = spawnFacing * spawnFacing;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FallRespawn)+50]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FallRespawn)+50]");
				object obj15 = num27 * 0;
				object obj16 = obj14 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FallRespawn)+54]");
				float num28 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FallRespawn)+54]");
				num6 = num28 * 0f;
				num5 = (float)obj16 + num6;
				float num29 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				if (num29 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72DCC");
					gt.Turn(num11);
					num4 = num11;
					num6 = num8;
					num5 = num9;
				}
			}
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
		object obj17 = 0;
		Vector3 position2 = head.position;
		float num30 = num12 - num4;
		float num31 = num10 - num5;
		float num32 = num7 - num6;
		float num33 = num4 + num30;
		float num34 = num5 + num31;
		float num35 = num6 + num32;
		transform.position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
		object obj19 = default;
		object obj18 = obj19 & 1;
		bool flag3 = obj18 == null;
		Rigidbody rigidbody = default;
		Vector3 vector = (Vector3)(&rigidbody);
		if (!flag3)
		{
			Transform transform2 = base.transform;
			Vector3 position3 = transform2.position;
			rigidbody.position = (Vector3)0;
			bool isKinematic = rigidbody.isKinematic;
			bool flag4 = !isKinematic;
			object obj20 = !flag4;
			vector = (Vector3)0;
			if (obj20 == null)
			{
				rigidbody.linearVelocity = (Vector3)0;
				object obj21 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v26+A0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v27+4]");
				num34 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v27+8]");
				num35 = 0f;
				num33 = (float)obj22;
				rigidbody.angularVelocity = (Vector3)0;
				vector = (Vector3)0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Physics.SyncTransforms();
		object obj26 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v25+E4]");
		bool flag6 = (nint)0 == 0;
		object obj27 = !flag6;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gt != null)
		{
			gt.InitializeValues();
		}
	}

	public FallRespawn()
	{
		//IL_001d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B7D8]");
		killY = 0f;
		base._002Ector();
	}
}
