using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR;

public class HandPoser : MonoBehaviour
{
	private sealed class _003CSawnFleshSkins_003Ed__57 : _00210, _0021_00210, _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private SkinnedMeshRenderer _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public GillaWounds _003C_003E4__this;

		private Enumerator<, > _003C_003E7__wrap1;

		private SkinnedMeshRenderer System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002ESkinnedMeshRenderer_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CSawnFleshSkins_003Ed__57(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_002f: Expected Obj, but got I4
			//IL_0049: Expected Obj, but got I4
			if (_003C_003E1__state != 1)
			{
				object obj = _003C_003E1__state + 3;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					return;
				}
			}
			_003C_003Em__Finally1();
		}

		private unsafe bool MoveNext()
		{
			//IL_0499: Expected I4, but got I8
			//IL_04a9: Expected Obj, but got I
			//IL_04b9: Expected Obj, but got I
			//IL_04c9: Expected Obj, but got I
			//IL_042c: Expected I, but got Obj
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Expected Ref, but got Unknown
			//IL_0021: Expected Obj, but got I4
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected Obj, but got I4
			//IL_0051: Expected I4, but got I8
			//IL_0142: Expected Obj, but got I
			//IL_0416: Expected Obj, but got I4
			//IL_02fe: Expected Obj, but got I4
			//IL_0303: Expected I, but got Obj
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected Obj, but got Unknown
			//IL_0259: Expected Obj, but got I4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected Obj, but got I4
			//IL_020d: Expected I, but got Obj
			//IL_0242: Expected Obj, but got I4
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected Obj, but got Unknown
			//IL_02d1: Expected Obj, but got I4
			//IL_02d9: Expected I, but got Obj
			bool flag = _003C_003E1__state == 1;
			_003CSawnFleshSkins_003Ed__57 obj = this;
			_003CSawnFleshSkins_003Ed__57 obj3 = default;
			Enumerator<, > val2;
			bool flag3;
			if (!flag)
			{
				bool flag2 = _003C_003E1__state == 0;
				object obj2 = !flag2;
				flag3 = false;
				if (obj2 != null)
				{
					goto IL_0399;
				}
				GillaWounds gillaWounds = _003C_003E4__this;
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this == null)
				{
					goto IL_0316;
				}
				if ((object)gillaWounds.sawnFlesh == null)
				{
					goto IL_0324;
				}
				Enumerator<, > enumerator = ((List<(System.__Canon, System.__Canon)>)(object)gillaWounds.sawnFlesh).GetEnumerator();
				Enumerator<, > val = default;
				obj3._003C_003E7__wrap1 = val;
				object obj4 = obj3 + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				val2 = val;
				obj = obj3;
			}
			obj._003C_003E1__state = -3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9568]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9658]");
			object obj7 = 0;
			UnityEngine.Object obj12;
			UnityEngine.Object obj13 = default;
			object obj10;
			nint num = default;
			while (true)
			{
				num = (nint)obj5;
				Enumerator<, > val3 = (Enumerator<, >)(obj + 48);
				if (!((Enumerator<, >*)val3)->MoveNext())
				{
					break;
				}
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ stack_-28_v2 (HandPoser+<SawnFleshSkins>d__57)+40]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ stack_-28_v2 (HandPoser+<SawnFleshSkins>d__57)+40]");
					if ((nint)0 == 0)
					{
						NullReferenceException ex = new NullReferenceException();
						obj10 = 0;
						num = unchecked((nint)null);
						goto IL_0308;
					}
					UnityEngine.Object obj11 = (UnityEngine.Object)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					obj12 = obj13;
				}
				else
				{
					UnityEngine.Object obj11 = null;
					obj12 = null;
				}
				object obj14 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v12+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(obj12 != null))
				{
					goto IL_0250;
				}
				bool flag6 = (object)obj12 == null;
				obj10 = 0;
				num = unchecked((nint)null);
				if (!flag6)
				{
					bool enabled = ((Renderer)obj12).enabled;
					bool flag7 = !enabled;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						goto IL_0250;
					}
					goto IL_029a;
				}
				goto IL_0308;
				IL_0308:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0316;
				IL_0250:
				obj10 = 0;
				obj = obj3;
			}
			obj3._003C_003Em__Finally1();
			obj3._003C_003E7__wrap1 = (Enumerator<, >)0;
			_ = 0;
			val2 = (Enumerator<, >)0;
			flag3 = false;
			goto IL_0399;
			IL_029a:
			object obj17 = obj3 + 24;
			obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj3._003C_003E1__state = 1;
			obj10 = 0;
			num = (nint)obj12;
			flag3 = true;
			goto IL_0399;
			IL_0324:
			NullReferenceException ex3 = new NullReferenceException();
			bool flag8 = num != 1;
			OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj18 = default;
				bool flag9 = obj18 == null;
				flag3 = false;
				if (flag9)
				{
					return flag3;
				}
				goto IL_0399;
			}
			goto IL_0464;
			IL_0464:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F7E8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			bool result = default;
			return result;
			IL_0399:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F808");
			OutOfMemoryException ex5 = new OutOfMemoryException();
			ex4 = ex5;
			goto IL_0464;
			IL_0316:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0324;
		}

		private unsafe void _003C_003Em__Finally1()
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got I8
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Ref, but got Unknown
			Enumerator<, > val = (Enumerator<, >)(this + 48);
			_003C_003E1__state = -1;
			((Enumerator<, >*)val)->Dispose();
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}

		private IEnumerator<SkinnedMeshRenderer> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002ESkinnedMeshRenderer_003E_002EGetEnumerator()
		{
			//IL_00c4: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			object obj = _003C_003E1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					return (IEnumerator<SkinnedMeshRenderer>)(object)this;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9640]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			obj4._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			object obj5 = obj4 + 40;
			obj5 = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return (IEnumerator<SkinnedMeshRenderer>)obj4;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002ESkinnedMeshRenderer_003E_002EGetEnumerator();
		}
	}

	[Serializable]
	public class Finger
	{
		public Transform[] bones;
	}

	private class Curler
	{
		public Transform[] bones;

		public Quaternion[] rest;

		public Vector3[] axis;

		public float value;

		public float vel;
	}

	public XRNode node = (XRNode)5;

	public Transform hand;

	public Finger thumb;

	public Finger index;

	public Finger[] gripFingers;

	public float fingerCurl;

	public float thumbCurl;

	public float responsiveness;

	public float overshoot;

	public float knuckleWeight = 0.75f;

	public bool invertCurl;

	public Vector3 palmNormalLocal;

	public float[] fingerJointWeights;

	public float[] thumbJointWeights;

	public float gripOverride;

	public bool desktopFallback;

	public bool remote;

	public float trigger;

	public float grip;

	public float thumbPress;

	private Curler _thumb;

	private Curler _index;

	private Curler[] _grip;

	private Vector3 _palmCentre;

	private Vector3 _palmN;

	private Vector3 _palmFace;

	private bool _ready;

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0789: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00a7: Expected VT, but got Obj
		//IL_00b7: Invalid comparison between VT and I
		//IL_00f5: Expected Obj, but got VT
		//IL_0112: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_0875: Expected Obj, but got I
		//IL_087d: Expected VT, but got Obj
		//IL_088d: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected Obj, but got Unknown
		//IL_01c3: Expected VT, but got I4
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_07a7: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0965: Expected Obj, but got I
		//IL_098f: Expected Obj, but got I4
		//IL_07c3: Expected Obj, but got VT
		//IL_07fa: Expected Obj, but got I
		//IL_0817: Expected VT, but got I
		//IL_0481: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I
		//IL_0920: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected VT, but got Unknown
		//IL_02e7: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03c5: Expected Obj, but got I
		//IL_03df: Expected VT, but got Obj
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected VT, but got Unknown
		//IL_04ff: Expected Obj, but got I8
		//IL_050f: Expected Obj, but got I
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got I4
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0947: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_05a4: Expected I4, but got Obj
		//IL_0606: Expected Obj, but got I4
		//IL_0689: Expected Obj, but got I
		//IL_0699: Expected Obj, but got I
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = hand == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj10;
		object obj11 = default;
		object obj14;
		object obj27;
		object obj29;
		Vector3 vector7;
		if (obj4 == null)
		{
			Vector3 vector = KnuckleAxis();
			object obj6 = default;
			object obj5 = obj6 * obj6;
			object obj8 = default;
			object obj7 = obj8 * obj8;
			object obj9 = obj5 + obj7;
			obj10 = obj11 * obj11;
			Vector3 vector2 = (Vector3)(obj10 + obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
			if (vector2 >= (object)0)
			{
				Vector3 vector3 = PalmCentre();
				object obj12 = palmNormalLocal * palmNormalLocal;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+64]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+64]");
				object obj13 = num * 0;
				_palmCentre = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				obj14 = 0;
				object obj15 = obj12 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+68]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+68]");
				object obj16 = num2 * 0;
				object obj17 = obj15 + obj16;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
				if ((nint)obj18 > 0)
				{
					if ((object)hand == null)
					{
						goto IL_074a;
					}
					Vector3 vector4 = hand.TransformDirection((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+64]");
					object obj19 = 0;
					Vector3 vector5 = palmNormalLocal;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj20 = 0;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v69+E4]");
					bool flag4 = (nint)0 == 0;
					object obj22 = !flag4;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+64]");
						obj19 = 0;
						vector5 = palmNormalLocal;
					}
					object obj23 = vector5 * vector5;
					object obj24 = obj19 * obj19;
					object obj25 = obj23 + obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+68]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+68]");
					object obj26 = num3 * 0;
					obj27 = obj26 + obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					Vector3 vector6 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					object obj28 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					if ((nint)obj28 > 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+68]");
						obj29 = 0 / obj27;
						vector7 = vector5 / obj19;
						goto IL_0849;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+68]");
					obj27 = 0;
					Vector3 vector6 = vector2;
				}
				object obj30 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v7+A0]");
				object obj31 = 0;
				vector7 = (Vector3)obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v8+8]");
				obj29 = 0;
				goto IL_0849;
			}
		}
		enabled = false;
		return;
		IL_0758:
		throw new IndexOutOfRangeException();
		IL_06f1:
		List<System.__Canon> list = default;
		if (list != null)
		{
			System.__Canon[] array = list.ToArray();
			object obj32 = this + 168;
			obj32 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_073e;
		}
		goto IL_074a;
		IL_0849:
		_palmN = vector7;
		object obj33 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v12+A0]");
		object obj34 = 0;
		object obj35 = vector7 - obj34;
		object obj36 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v13+8]");
		object obj37 = obj36 - 0;
		object obj38 = obj35 * obj35;
		object obj39 = obj37 * obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj40 = obj39 + obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		bool flag5 = (nint)obj40 < 0;
		object obj41 = obj11;
		object obj42 = obj10;
		if (!flag5)
		{
			Vector3 vector8 = KnuckleCentre();
			if ((object)hand != null)
			{
				Vector3 position = hand.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj43 = 0;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v47+E4]");
				bool flag6 = (nint)0 == 0;
				object obj45 = !flag6;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((object)hand != null)
				{
					object obj46 = obj27 - obj27;
					object obj47 = obj40 - obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					object obj48 = num4 - 0;
					object obj49 = obj46 * obj46;
					object obj50 = obj47 * obj47;
					object obj51 = obj48 * obj48;
					object obj52 = obj50 + obj51;
					object obj53 = obj49 + obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Vector3 position2 = hand.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					object obj54 = obj27 - obj49;
					object obj55 = default;
					obj41 = _palmN * obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+C4]");
					object obj17 = obj53 * 0;
					object obj56 = obj40 - obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
					obj42 = obj54 * 0;
					object obj57 = obj56 * obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					object obj16 = 0;
					object obj58 = obj49 + obj42;
					Vector3 vector6 = (Vector3)(obj41 * obj56);
					object obj59 = obj53 + obj57;
					object obj60 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					object obj61 = obj60 * 0;
					Vector3 palmFace = vector6 + obj59;
					object obj62 = obj58 + obj61;
					_palmFace = palmFace;
					goto IL_0892;
				}
			}
			goto IL_074a;
		}
		goto IL_0892;
		IL_0892:
		Vector3 across = default;
		Curler curler = Build(thumb, isThumb: true, across);
		object obj63 = this + 152;
		obj63 = curler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Curler curler2 = Build(index, isThumb: false, across);
		object obj64 = this + 160;
		obj64 = curler2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X20_v9-60]");
		if ((nint)0 == 0)
		{
			goto IL_073e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA7E0]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list._002Ector();
		Finger[] array2 = gripFingers;
		if (gripFingers == null)
		{
			goto IL_074a;
		}
		bool flag7 = array2.Length < 1;
		bool flag8 = false;
		if (flag7)
		{
			goto IL_06f1;
		}
		object obj66 = array2.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA7C8]");
		object obj67 = 0;
		object obj68 = gripFingers + 32;
		object obj69 = 0;
		while (true)
		{
			bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66);
			object obj70 = !flag9;
			if (obj70 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X25_v5+v373 @ X23_v6*8]");
			Curler curler3 = Build((Finger)0, isThumb: false, across);
			bool flag10 = curler3 == null;
			flag8 = false;
			if (flag10)
			{
				goto IL_06bb;
			}
			if (list != null)
			{
				System.__Canon[] items = list._items;
				int num5 = (int)obj67;
				int version = list._version + 1;
				list._version = version;
				if (list._items != null)
				{
					bool flag11 = list._size < items.Length;
					object obj71 = !flag11;
					if (obj71 == null)
					{
						object obj72 = list._items + list._size;
						num5 = list._size + 1;
						list._size = num5;
						object obj73 = obj72 + 32;
						obj73 = curler3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						flag8 = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X9_v4 (System.Int32)+20]");
						object obj74 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v31+A8]");
						object obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X8_v32+70]");
						flag8 = false;
						list.AddWithResize((System.__Canon)(object)curler3);
					}
					goto IL_06bb;
				}
			}
			goto IL_074a;
			IL_06bb:
			obj66 = array2.Length;
			obj69++;
			if ((nint)obj69 < array2.Length)
			{
				continue;
			}
			goto IL_06f1;
		}
		goto IL_0758;
		IL_074a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0758;
		IL_073e:
		_ready = true;
	}

	private Vector3 KnuckleAxis()
	{
		//IL_0ccc: Expected Obj, but got I
		//IL_0cdc: Expected Obj, but got I
		//IL_0ce5: Expected Obj, but got I4
		//IL_0cf5: Expected Obj, but got I
		//IL_0d03: Expected Obj, but got I4
		//IL_0e66: Expected Obj, but got I
		//IL_0e80: Expected Obj, but got I
		//IL_0e88: Expected VT, but got Obj
		//IL_0cbc: Expected VT, but got Obj
		//IL_092d: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I8
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0974: Expected Obj, but got I4
		//IL_0d21: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_09ee: Expected Obj, but got I
		//IL_0a06: Expected Obj, but got I
		//IL_0a1e: Expected Obj, but got I
		//IL_0a2e: Expected Obj, but got I
		//IL_0a3e: Expected Obj, but got I
		//IL_0a4e: Expected Obj, but got I
		//IL_0a57: Expected Obj, but got I4
		//IL_0e2f: Expected Obj, but got I4
		//IL_0e48: Expected I, but got VT
		//IL_0992: Expected Obj, but got I
		//IL_09a2: Expected Obj, but got I
		//IL_09c8: Expected Obj, but got I4
		//IL_09d0: Expected I, but got VT
		//IL_04a3: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0b91: Expected I4, but got Obj
		//IL_0b99: Expected VT, but got I
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Expected Obj, but got Unknown
		//IL_089c: Expected Obj, but got I4
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_0150: Expected VT, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0a9d: Expected I4, but got Obj
		//IL_04d8: Expected Obj, but got I
		//IL_0bd0: Expected Obj, but got I
		//IL_0d59: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I
		//IL_0f04: Expected VT, but got Obj
		//IL_0f26: Expected Obj, but got I4
		//IL_0d77: Expected Obj, but got I
		//IL_0d85: Expected Obj, but got I4
		//IL_0ddb: Expected I4, but got Obj
		//IL_0555: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_0e13: Expected Obj, but got I4
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0588: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I
		//IL_05d2: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I4
		//IL_061e: Expected VT, but got I4
		//IL_0626: Expected Obj, but got I4
		//IL_0644: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_02ce: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03b9: Expected VT, but got I
		//IL_03ce: Expected VT, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_06e3: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0356: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I4
		//IL_037c: Expected VT, but got I4
		//IL_0384: Expected Obj, but got VT
		//IL_0714: Expected Obj, but got I
		//IL_0724: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I4
		//IL_0847: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I
		//IL_0867: Expected VT, but got I
		//IL_087c: Expected VT, but got I
		//IL_0885: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Obj, but got Unknown
		//IL_0804: Expected Obj, but got I
		//IL_0821: Expected Obj, but got I4
		//IL_082a: Expected VT, but got I4
		//IL_0832: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6930]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj4 = 0;
		HandPoser handPoser = this;
		UnityEngine.Object obj5 = (UnityEngine.Object)109891584;
		List<Vector3> list = default;
		UnityEngine.Object obj12 = default;
		object obj15 = default;
		object obj21 = default;
		object obj22 = default;
		object obj76 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
			object obj7 = 0;
			Vector3 vector = (Vector3)obj7;
			list._002Ector();
			Finger finger = handPoser.index;
			bool flag = handPoser.index == null;
			List<Vector3> list2 = list;
			object obj8;
			if (!flag)
			{
				Transform[] bones = finger.bones;
				bool flag2 = finger.bones == null;
				list2 = list;
				if (!flag2)
				{
					obj8 = bones.Length;
					bool flag3 = (nint)obj3 >= bones.Length;
					list2 = list;
					if (!flag3)
					{
						bool flag4 = (nint)obj3 < bones.Length;
						object obj9 = !flag4;
						if (obj9 != null)
						{
							goto IL_0ca0;
						}
						object obj10 = (object)finger.bones + obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v58+20]");
						obj12 = (UnityEngine.Object)0;
						object obj13 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v61+E4]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v61+E4]");
						bool flag5 = (nint)0 == 0;
						object obj14 = !flag5;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag6 = obj12 != null;
						bool flag7 = !flag6;
						obj15 = 0;
						vector = (Vector3)0;
						list2 = (List<Vector3>)flag6;
						if (!flag7)
						{
							Finger finger2 = handPoser.index;
							if (handPoser.index == null)
							{
								break;
							}
							Transform[] bones2 = finger2.bones;
							if (finger2.bones == null)
							{
								break;
							}
							bool flag8 = (nint)obj3 < bones2.Length;
							object obj16 = !flag8;
							if (obj16 != null)
							{
								goto IL_0ca0;
							}
							object obj17 = (object)finger2.bones + obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v61+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v61+20]");
							Vector3 position = ((Transform)0).position;
							if (list == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
							object obj20 = (nint)0 + (nint)1;
							obj8 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v62+18]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v62+18]");
							bool flag9 = num < 0;
							object obj23 = !flag9;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								object obj24 = (nint)0 * (nint)12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj25 = 0 + obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								obj8 = (nint)0 + (nint)1;
								obj15 = 0;
								vector = (Vector3)0;
								list2 = (List<Vector3>)position;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+20]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v63+A8]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v64+70]");
								vector = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v64+70]");
								list.AddWithResize((Vector3)0);
								obj15 = 0;
								list2 = list;
							}
						}
					}
				}
			}
			Finger[] array = handPoser.gripFingers;
			if (handPoser.gripFingers == null || array.Length < 1)
			{
				goto IL_0900;
			}
			object obj28 = array.Length & 0xFFFFFFFFL;
			object obj29 = handPoser.gripFingers + 32;
			object obj30 = obj22;
			object obj31 = obj21;
			object obj32 = obj15;
			UnityEngine.Object obj33 = obj12;
			Vector3 vector2 = vector;
			List<Vector3> list3 = list2;
			UnityEngine.Object obj34 = null;
			while (true)
			{
				bool flag10 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj34) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28);
				object obj35 = !flag10;
				if (obj35 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X27_v4+v472 @ X19_v14 (UnityEngine.Object)*8]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X27_v4+v472 @ X19_v14 (UnityEngine.Object)*8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v9+10]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v9+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v46+18]");
						obj8 = 0;
						object obj38 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v46+18]");
						if ((nint)obj38 < 0)
						{
							object obj39 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v46+18]");
							bool flag11 = (nint)obj39 < 0;
							object obj40 = !flag11;
							if (obj40 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v9+10]");
							object obj41 = 0 + obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v47+20]");
							obj33 = (UnityEngine.Object)0;
							object obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v53+E4]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v53+E4]");
							bool flag12 = (nint)0 == 0;
							object obj44 = !flag12;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag13 = obj33 != null;
							bool flag14 = !flag13;
							obj32 = 0;
							vector2 = (Vector3)0;
							list3 = (List<Vector3>)flag13;
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v9+10]");
								object obj45 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v9+10]");
								if ((nint)0 == 0)
								{
									goto end_IL_0e56;
								}
								object obj46 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v48+18]");
								bool flag15 = (nint)obj46 < 0;
								object obj47 = !flag15;
								if (obj47 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X20_v9+10]");
								object obj48 = 0 + obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v49+20]");
								if ((nint)0 == 0)
								{
									goto end_IL_0e56;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v49+20]");
								Vector3 position2 = ((Transform)0).position;
								if (list == null)
								{
									goto end_IL_0e56;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								obj8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
								object obj50 = (nint)0 + (nint)1;
								object obj51 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								if ((nint)0 == 0)
								{
									goto end_IL_0e56;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+18]");
								obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+18]");
								bool flag16 = num2 < 0;
								object obj52 = !flag16;
								if (obj52 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									object obj53 = (nint)0 * (nint)12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj54 = 0 + obj53;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									obj8 = (nint)0 + (nint)1;
									obj32 = 0;
									vector2 = (Vector3)0;
									list3 = (List<Vector3>)position2;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v52+20]");
									object obj55 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v53+A8]");
									object obj56 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v54+70]");
									vector2 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v54+70]");
									list.AddWithResize((Vector3)0);
									obj32 = 0;
									list3 = list;
								}
							}
						}
					}
				}
				obj28 = array.Length;
				obj5 = (UnityEngine.Object)(obj34 + 1);
				bool flag17 = (nint)obj5 < array.Length;
				obj22 = obj30;
				obj21 = obj31;
				obj15 = obj32;
				obj12 = obj33;
				vector = vector2;
				list2 = list3;
				obj34 = obj5;
				if (flag17)
				{
					continue;
				}
				goto IL_0900;
			}
			goto IL_0ca0;
			IL_0be6:
			obj3++;
			bool flag18 = (nint)obj3 != 2;
			handPoser = this;
			if (flag18)
			{
				continue;
			}
			goto IL_0c19;
			IL_0ca0:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			break;
			IL_0900:
			if (list == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
			if ((nint)0 < (nint)2)
			{
				goto IL_0c19;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99B]");
			bool flag19 = (nint)0 == 0;
			object obj58 = !flag19;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				list2 = (List<Vector3>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				obj57 = 0;
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
				bool flag20 = (nint)0 < (nint)1;
				obj8 = 109891584;
				nint num3 = (nint)vector;
				if (flag20)
				{
					goto IL_0be6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj59 = 0;
			object obj60 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v14+A0]");
			obj8 = 0;
			object obj61 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+4]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+8]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+8]");
			object obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X9_v18+4]");
			object obj65 = 0;
			object obj66 = 0;
			int num4 = 0;
			bool flag25;
			do
			{
				obj5 = (UnityEngine.Object)(num4 + 1);
				bool flag21 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj57);
				nint num3 = (nint)vector;
				if (!flag21)
				{
					object obj67 = obj64;
					object obj68 = obj65;
					object obj69 = obj63;
					object obj70 = obj62;
					object obj71 = obj61;
					object obj72 = obj66;
					int num5 = (int)obj5;
					bool flag24;
					do
					{
						Vector3 vector3 = list.get_Item(num5);
						obj15 = obj;
						Vector3 vector4 = list.get_Item(num4);
						list2 = (List<Vector3>)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E4]");
						bool flag22 = (nint)0 == 0;
						obj58 = !flag22;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj73 = obj69 - obj69;
						object obj74 = obj70 - obj70;
						object obj75 = obj76 - obj76;
						object obj77 = obj73 * obj73;
						object obj78 = obj74 * obj74;
						object obj79 = obj77 + obj78;
						obj62 = obj75 * obj75;
						obj63 = obj62 + obj79;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj72))
						{
							list2 = (List<Vector3>)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E4]");
							bool flag23 = (nint)0 == 0;
							obj58 = !flag23;
							if (obj58 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							obj67 = obj75;
							obj68 = obj74;
							obj71 = obj73;
							obj72 = obj69;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						obj57 = 0;
						array = (Finger[])(num5 + 1);
						Finger[] array2 = array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v4 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						flag24 = (nint)array2 < 0;
						obj64 = obj67;
						obj65 = obj68;
						obj61 = obj71;
						obj66 = obj72;
						num3 = num4;
						obj69 = obj63;
						obj70 = obj62;
						num5 = (int)array;
					}
					while (flag24);
				}
				flag25 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj57);
				num4 = (int)obj5;
				vector = (Vector3)num3;
			}
			while (flag25);
			object obj80 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			bool flag26 = (nint)obj80 > 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			obj4 = 0;
			obj12 = obj5;
			if (!flag26)
			{
				goto IL_0be6;
			}
			Vector3 result = (Vector3)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v11 (UnityEngine.Vector3)+E4]");
			bool flag27 = (nint)0 == 0;
			object obj81 = !flag27;
			if (obj81 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj76 <= 0)
			{
			}
			goto IL_0c4c;
			IL_0c4c:
			return result;
			IL_0c19:
			if ((object)hand == null)
			{
				break;
			}
			result = hand.right;
			goto IL_0c4c;
			continue;
			end_IL_0e56:
			break;
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (Vector3)ex2;
	}

	private Vector3 KnuckleCentre()
	{
		//IL_05be: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_051b: Expected VT, but got Obj
		//IL_04c2: Expected VT, but got Obj
		//IL_024e: Expected Obj, but got I8
		//IL_025e: Expected Obj, but got I
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I4
		//IL_05e5: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_011a: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I4
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I4
		//IL_03c4: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_0200: Expected I, but got Obj
		//IL_0208: Expected Obj, but got VT
		//IL_03ea: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got I4
		//IL_048d: Expected I, but got Obj
		//IL_0495: Expected Obj, but got VT
		HandPoser handPoser = this;
		Finger finger = index;
		bool flag = index == null;
		UnityEngine.Object obj = (UnityEngine.Object)109891584;
		object obj6;
		if (!flag)
		{
			Transform[] bones = finger.bones;
			bool flag2 = finger.bones == null;
			obj = (UnityEngine.Object)109891584;
			if (!flag2)
			{
				bool flag3 = bones.Length == 0;
				obj = (UnityEngine.Object)109891584;
				if (!flag3)
				{
					if (bones.Length == 0)
					{
						goto IL_04ff;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj2 = 0;
					obj = bones[0];
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v22+E4]");
					bool flag4 = (nint)0 == 0;
					object obj4 = !flag4;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = obj != null;
					bool flag6 = !flag5;
					object obj5 = 0;
					nint num = unchecked((nint)null);
					handPoser = (HandPoser)flag5;
					if (!flag6)
					{
						Finger finger2 = index;
						if (index != null)
						{
							Transform[] bones2 = finger2.bones;
							if (finger2.bones != null)
							{
								if (bones2.Length == 0)
								{
									goto IL_04ff;
								}
								if ((object)bones2[0] != null)
								{
									Vector3 position = bones2[0].position;
									obj6 = 1;
									obj5 = 0;
									num = unchecked((nint)null);
									handPoser = (HandPoser)position;
									goto IL_0525;
								}
							}
						}
						goto IL_050d;
					}
				}
			}
		}
		obj6 = 0;
		goto IL_0525;
		IL_049a:
		if ((nint)obj6 > 0)
		{
			return (Vector3)handPoser;
		}
		if ((object)hand != null)
		{
			return hand.position;
		}
		goto IL_050d;
		IL_04ff:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_050d;
		IL_050d:
		NullReferenceException ex2 = new NullReferenceException();
		return (Vector3)ex2;
		IL_0525:
		Finger[] array = gripFingers;
		if (gripFingers == null || array.Length < 1)
		{
			goto IL_049a;
		}
		object obj7 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		object obj9 = gripFingers + 32;
		object obj10 = 0;
		object obj11 = obj6;
		HandPoser handPoser2 = handPoser;
		while (true)
		{
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj12 = !flag7;
			if (obj12 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X25_v3+v203 @ X23_v4*8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X25_v3+v203 @ X23_v4*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v4+10]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v4+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+18]");
						if ((nint)0 == 0)
						{
							break;
						}
						object obj15 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+20]");
						obj = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v10+E4]");
						bool flag8 = (nint)0 == 0;
						object obj16 = !flag8;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag9 = obj != null;
						bool flag10 = !flag9;
						object obj5 = 0;
						nint num = unchecked((nint)null);
						handPoser2 = (HandPoser)flag9;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v4+10]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X26_v4+10]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+18]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+20]");
									Vector3 position2 = ((Transform)0).position;
									obj11++;
									obj5 = 0;
									num = unchecked((nint)null);
									handPoser2 = (HandPoser)position2;
									goto IL_054e;
								}
							}
							goto IL_050d;
						}
					}
				}
			}
			goto IL_054e;
			IL_054e:
			obj7 = array.Length;
			obj10++;
			bool flag11 = (nint)obj10 < array.Length;
			obj6 = obj11;
			handPoser = handPoser2;
			if (flag11)
			{
				continue;
			}
			goto IL_049a;
		}
		goto IL_04ff;
	}

	private Vector3 PalmCentre()
	{
		//IL_0133: Expected VT, but got Obj
		//IL_00da: Expected VT, but got Obj
		//IL_0038: Expected Obj, but got I8
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		KillCam._003C_003Ec__DisplayClass32_0 obj = default;
		_003CPalmCentre_003Eg__Add_007C32_0(index, ref obj);
		Finger finger = thumb;
		_003CPalmCentre_003Eg__Add_007C32_0(thumb, ref obj);
		Finger[] array = gripFingers;
		if (gripFingers == null || array.Length < 1)
		{
			goto IL_00b1;
		}
		object obj2 = array.Length & 0xFFFFFFFFL;
		object obj3 = gripFingers + 32;
		object obj4 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			object obj5 = !flag;
			if (obj5 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v4+v131 @ X21_v5*8]");
			finger = (Finger)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v4+v131 @ X21_v5*8]");
			_003CPalmCentre_003Eg__Add_007C32_0((Finger)0, ref obj);
			obj2 = array.Length;
			obj4++;
			if ((nint)obj4 < array.Length)
			{
				continue;
			}
			goto IL_00b1;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0125;
		IL_0125:
		NullReferenceException ex2 = new NullReferenceException();
		return (Vector3)ex2;
		IL_00b1:
		if (0 > 0)
		{
			return (Vector3)finger;
		}
		if ((object)hand != null)
		{
			return hand.position;
		}
		goto IL_0125;
	}

	private Curler Build(Finger f, bool isThumb, Vector3 across)
	{
		//IL_003e: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_1a08: Expected Obj, but got I4
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0126: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_0348: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_0649: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I
		//IL_07d3: Expected Obj, but got I
		//IL_07dc: Expected Obj, but got I4
		//IL_07e5: Expected Obj, but got I4
		//IL_07f5: Expected VT, but got I
		//IL_07fe: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I4
		//IL_04c7: Expected Obj, but got I4
		//IL_06e4: Expected Obj, but got I4
		//IL_082e: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got I
		//IL_0536: Expected Obj, but got VT
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected VT, but got Unknown
		//IL_0747: Expected Obj, but got I
		//IL_088f: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I4
		//IL_090b: Expected Obj, but got VT
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_1a5e: Expected Obj, but got I
		//IL_1aea: Invalid comparison between F8 and I
		//IL_1afc: Expected Obj, but got I4
		//IL_1b1a: Invalid comparison between F8 and I
		//IL_09a4: Expected Obj, but got I4
		//IL_0a34: Expected Obj, but got I
		//IL_0a50: Expected Obj, but got I4
		//IL_1b5b: Expected Obj, but got I4
		//IL_0b74: Expected Obj, but got I
		//IL_0b98: Expected F8, but got I
		//IL_0ba1: Expected Obj, but got I4
		//IL_0c1a: Invalid comparison between F8 and I
		//IL_0c2c: Expected F8, but got I4
		//IL_0c35: Expected F8, but got I4
		//IL_0c3e: Expected F8, but got I4
		//IL_0a74: Expected Obj, but got I
		//IL_1b90: Expected F8, but got VT
		//IL_0a02: Expected Obj, but got I
		//IL_1d15: Invalid comparison between F8 and I
		//IL_0abb: Expected Obj, but got I
		//IL_1d3c: Invalid comparison between F8 and I
		//IL_0b5e: Expected Obj, but got I4
		//IL_1d63: Invalid comparison between F8 and I
		//IL_0e4b: Expected F8, but got VT
		//IL_1bc2: Expected VT, but got F8
		//IL_1be1: Expected Obj, but got I
		//IL_1c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0c: Expected VT, but got Unknown
		//IL_1c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1b: Expected Obj, but got Unknown
		//IL_1c38: Expected Obj, but got I
		//IL_2198: Expected Obj, but got I
		//IL_21ce: Expected Obj, but got I
		//IL_21e5: Invalid comparison between F8 and Obj
		//IL_0c94: Expected Obj, but got I
		//IL_0cb5: Expected Obj, but got I
		//IL_0cdd: Expected Obj, but got VT
		//IL_0dad: Expected VT, but got F8
		//IL_0dbd: Invalid comparison between VT and I
		//IL_0dd6: Expected F8, but got I
		//IL_0ddf: Expected Obj, but got I4
		//IL_1dda: Invalid comparison between F8 and I
		//IL_1df3: Expected F8, but got I
		//IL_0e95: Expected VT, but got F8
		//IL_0e0d: Expected F8, but got I
		//IL_0e2e: Expected Obj, but got I4
		//IL_2495: Expected Obj, but got I4
		//IL_0f9a: Invalid comparison between F8 and I
		//IL_0fac: Expected VT, but got I4
		//IL_0fb5: Expected F8, but got I4
		//IL_0fbe: Expected F8, but got I4
		//IL_0fce: Expected F8, but got I
		//IL_1e19: Expected Obj, but got I
		//IL_1e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5c: Expected VT, but got Unknown
		//IL_1ee4: Expected Obj, but got I
		//IL_1f05: Expected Obj, but got I
		//IL_1f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f23: Expected Obj, but got Unknown
		//IL_1f40: Expected Obj, but got I
		//IL_1fa1: Invalid comparison between F8 and I
		//IL_1011: Expected VT, but got F8
		//IL_124e: Expected Obj, but got I
		//IL_1278: Expected VT, but got I4
		//IL_1278: Expected VT, but got I4
		//IL_103b: Expected VT, but got I4
		//IL_103b: Expected VT, but got I4
		//IL_205f: Expected Obj, but got I4
		//IL_12ab: Expected Obj, but got I
		//IL_1772: Invalid comparison between F8 and I4
		//IL_1783: Expected F4, but got VT
		//IL_12d5: Expected VT, but got I4
		//IL_12d5: Expected VT, but got I4
		//IL_1662: Unsupported input type for neg.
		//IL_1662: Unknown result type (might be due to invalid IL or missing references)
		//IL_1667: Expected VT, but got Unknown
		//IL_166f: Expected VT, but got F4
		//IL_10ac: Expected Obj, but got I
		//IL_2097: Expected Obj, but got I4
		//IL_20a9: Unsupported input type for neg.
		//IL_20a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ae: Expected VT, but got Unknown
		//IL_1fdf: Expected Obj, but got I4
		//IL_14bc: Expected F4, but got I
		//IL_14dc: Expected F4, but got I
		//IL_14ec: Expected F8, but got I
		//IL_150c: Expected F4, but got I
		//IL_151c: Expected VT, but got I
		//IL_152c: Expected F8, but got I
		//IL_1541: Expected F4, but got I8
		//IL_1569: Expected F8, but got I
		//IL_1579: Expected VT, but got I
		//IL_1599: Expected F4, but got I
		//IL_15a9: Expected F8, but got I
		//IL_15e1: Expected F4, but got I
		//IL_15f1: Expected VT, but got I
		//IL_1601: Expected F8, but got I
		//IL_1616: Expected F4, but got I8
		//IL_163e: Expected F8, but got I
		//IL_10d5: Expected Obj, but got I
		//IL_10f3: Expected F8, but got I
		//IL_110b: Expected F8, but got I
		//IL_2017: Expected Obj, but got I4
		//IL_2027: Expected VT, but got I
		//IL_210e: Expected VT, but got I4
		//IL_210e: Expected Obj, but got I
		//IL_23f6: Expected F4, but got VT
		//IL_2406: Expected F8, but got I
		//IL_2416: Expected F4, but got I
		//IL_2445: Expected F4, but got I
		//IL_245d: Expected F8, but got I
		//IL_113c: Expected F8, but got I
		//IL_114c: Expected F4, but got I
		//IL_115c: Expected F8, but got I
		//IL_116c: Expected VT, but got I
		//IL_117c: Expected VT, but got I
		//IL_18a6: Expected Obj, but got I4
		//IL_11d1: Expected F8, but got I
		//IL_11e1: Expected F4, but got I
		//IL_1210: Expected F4, but got I
		//IL_1230: Expected F8, but got I
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cf: Expected Obj, but got Unknown
		//IL_18d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dd: Expected Obj, but got Unknown
		//IL_18f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f5: Expected Obj, but got Unknown
		//IL_1926: Expected Obj, but got I4
		if (f != null)
		{
			Transform[] bones = f.bones;
			if (f.bones != null)
			{
				object obj = bones.Length;
				if (bones.Length != 0)
				{
					bool flag = bones.Length < 1;
					bool flag2 = isThumb;
					UnityEngine.Object obj2 = (UnityEngine.Object)(object)f;
					if (flag)
					{
						goto IL_01a4;
					}
					object obj3 = f.bones + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj4 = 0;
					bool flag3 = isThumb;
					Finger finger = f;
					object obj5 = 0;
					while (true)
					{
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj6 = !flag4;
						if (obj6 != null)
						{
							break;
						}
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v139+E4]");
						bool flag5 = (nint)0 == 0;
						object obj8 = !flag5;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X26_v10+v87 @ X24_v13*8]");
						bool flag6 = (UnityEngine.Object)0 == null;
						bool flag7 = !flag6;
						object obj9 = !flag7;
						if (obj9 == null)
						{
							obj = bones.Length;
							obj5++;
							bool flag8 = (nint)obj5 < bones.Length;
							flag2 = false;
							obj2 = null;
							flag3 = false;
							finger = null;
							if (flag8)
							{
								continue;
							}
							goto IL_01a4;
						}
						goto IL_059c;
					}
					goto IL_19c4;
				}
			}
		}
		goto IL_059c;
		IL_19ac:
		throw new NullReferenceException();
		IL_19c4:
		return (Curler)(object)new IndexOutOfRangeException();
		IL_1a16:
		Transform[] bones2 = f.bones;
		bool flag9 = f.bones == null;
		Curler curler2 = default;
		Curler curler = curler2;
		if (flag9)
		{
			goto IL_19ac;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj11 = 0;
		object obj12 = 44;
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Vector3 vector = (Vector3)0;
		object obj14 = 0;
		double num2 = default;
		double num = num2;
		double num4 = default;
		double num3 = num4;
		double num6;
		double num8;
		Vector3 vector4;
		double num9;
		double num10;
		Vector3 vector5 = default;
		Vector3 vector6 = default;
		Vector3 vector2 = default;
		Vector3 vector10 = default;
		double num100 = default;
		Vector3 vector11 = default;
		double num102 = default;
		double num103 = default;
		float num104 = default;
		double num105 = default;
		Vector3 vector12 = default;
		double num139 = default;
		float num140 = default;
		Vector3 vector13 = default;
		double num141 = default;
		double num142 = default;
		float num143 = default;
		Vector3 axis = default;
		object obj18;
		object obj59;
		while (true)
		{
			bool flag10 = (nint)obj14 >= bones2.Length;
			curler = curler2;
			Vector3 vector8;
			double num88;
			double num89;
			double num99;
			double num101;
			float num138;
			double num144;
			double num145;
			double num146;
			float num147;
			double num148;
			Vector3 vector14;
			Vector3 vector15;
			double num149;
			Vector3 vector16;
			double num150;
			float num151;
			Vector3 vector17;
			double num152;
			double num153;
			float num154;
			double num38;
			double num36;
			double num37;
			if (!flag10)
			{
				bool flag11 = (nint)obj14 < bones2.Length;
				object obj15 = !flag11;
				if (obj15 != null)
				{
					break;
				}
				object obj16 = (object)bones2 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
				bool flag12 = (nint)0 == 0;
				curler = curler2;
				if (!flag12)
				{
					object obj17 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
					Quaternion localRotation = ((Transform)0).localRotation;
					bool flag13 = obj18 == null;
					curler = curler2;
					if (!flag13)
					{
						object obj19 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X24_v10+18]");
						bool flag14 = (nint)obj19 < 0;
						object obj20 = !flag14;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = obj18 + obj12;
						obj21 = vector2;
						Transform[] bones3 = f.bones;
						bool flag15 = f.bones == null;
						curler = curler2;
						if (!flag15)
						{
							object obj22 = obj14 + 1;
							bool flag16 = (nint)obj22 >= bones3.Length;
							double num5 = num6;
							double num7 = num8;
							Vector3 vector3 = vector4;
							if (!flag16)
							{
								bool flag17 = (nint)obj22 < bones3.Length;
								object obj23 = !flag17;
								if (obj23 != null)
								{
									break;
								}
								object obj24 = (object)f.bones + obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X8_v94+28]");
								bool flag18 = (nint)0 == 0;
								curler = curler2;
								if (flag18)
								{
									goto IL_19ac;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X8_v94+28]");
								Vector3 position = ((Transform)0).position;
								num5 = num9;
								num7 = num10;
								vector3 = vector;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
							Vector3 position2 = ((Transform)0).position;
							double num11 = (double)vector3 - (double)vector;
							double num12 = num7 - num10;
							double num13 = num5 - num9;
							double num14 = num11 * num11;
							double num15 = num12 * num12;
							double num16 = num14 + num15;
							double num17 = num13 * num13;
							double num18 = num17 + num16;
							double num19 = num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							bool flag19 = !(num19 < 0.0);
							object obj25 = 0;
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
								int childCount = ((Transform)0).childCount;
								bool flag20 = childCount < 1;
								obj25 = 0;
								if (!flag20)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
									Transform child = ((Transform)0).GetChild(0);
									bool flag21 = (object)child == null;
									curler = curler2;
									if (flag21)
									{
										goto IL_19ac;
									}
									Vector3 position3 = child.position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
									Vector3 position4 = ((Transform)0).position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
									double num20 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
									num11 = num20 - 0.0;
									num12 = num17 - num17;
									num13 = num9 - num9;
									double num21 = num11 * num11;
									double num22 = num12 * num12;
									double num23 = num22 + num21;
									num17 = num13 * num13;
									num18 = num17 + num23;
									bool flag2 = false;
									obj25 = 0;
								}
							}
							double num24 = num18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							if (num24 < 0.0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
								Vector3 up = ((Transform)0).up;
								num13 = num9;
								num12 = num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
								num11 = 0.0;
								obj25 = 0;
							}
							object obj26 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X0_v39+E4]");
							bool flag22 = (nint)0 == 0;
							object obj27 = !flag22;
							if (obj27 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							double num25 = num11 * num11;
							double num26 = num12 * num12;
							double num27 = num26 + num25;
							double num28 = num13 * num13;
							double num29 = num28 + num27;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							bool flag23 = !(num29 > 0.0);
							double num30 = 0.0;
							double num31 = 0.0;
							double num32 = 0.0;
							if (!flag23)
							{
								num32 = num11 / num29;
								num31 = num12 / num29;
								num30 = num13 / num29;
							}
							bool flag24 = !isThumb;
							double num33 = num3;
							double num34 = num;
							double num35 = (double)vector5;
							if (!flag24)
							{
								object obj28 = obj11;
								num9 = num3 * num31;
								vector2 = (Vector3)(num * num30);
								num36 = num3 * num32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v89+A0]");
								object obj29 = 0;
								num37 = (double)vector5 * num30;
								num38 = num * num32;
								vector6 = vector5 * num31;
								object obj30 = _palmN - obj29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+C4]");
								nint num39 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ X8_v90+8]");
								object obj31 = num39 - 0;
								num35 = num9 - (double)vector2;
								num34 = num37 - num36;
								num33 = num38 - (double)vector6;
								object obj32 = obj30 * obj30;
								object obj33 = obj31 * obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								object obj34 = obj33 + obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								if ((nint)obj34 >= 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
									Vector3 position5 = ((Transform)0).position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									nint num40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									object obj35 = num40 - 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
									double num41 = 0.0 - num9;
									object obj36 = _palmFace - _palmFace;
									double num42 = num31 * num41;
									double num43 = num30 * (double)obj35;
									double num44 = num32 * num41;
									double num45 = num32 * (double)obj35;
									num36 = num30 * (double)obj36;
									double num46 = num31 * (double)obj36;
									double num47 = num42 - num43;
									double num48 = num36 - num44;
									num9 = num45 - num46;
									double num49 = num47 * num47;
									double num50 = num48 * num48;
									double num51 = num49 + num50;
									double num52 = num9 * num9;
									vector2 = (Vector3)(num52 + num51);
									Vector3 vector7 = vector2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
									bool flag25 = vector7 <= (object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
									num37 = 0.0;
									obj25 = 0;
									num = num2;
									num3 = num4;
									if (!flag25)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
										num37 = 0.0;
										num33 = num9;
										num34 = num48;
										num35 = num47;
										obj25 = 0;
										num = num2;
										num3 = num4;
									}
								}
							}
							double num53 = num35 * num35;
							double num54 = num34 * num34;
							double num55 = num53 + num54;
							double num56 = num33 * num33;
							double num57 = num55 + num56;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							if (num57 < 0.0)
							{
								num35 = (double)vector5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							if (num57 < 0.0)
							{
								num34 = num;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							if (num57 < 0.0)
							{
								num33 = num3;
							}
							double num58 = num32 * num32;
							double num59 = num31 * num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
							object obj37 = 0;
							object obj38 = obj37;
							double num60 = num58 + num59;
							double num61 = num30 * num30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X8_v35+A0]");
							object obj39 = 0;
							double num62 = num61 + num60;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num62) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39))
							{
								double num63 = num32 * num35;
								double num64 = num31 * num34;
								vector2 = (Vector3)(num30 * num33);
								double num65 = num63 + num64;
								double num66 = (double)vector2 + num65;
								double num67 = num66 / num62;
								double num68 = num32 * num67;
								num9 = num31 * num67;
								double num69 = num30 * num67;
								num35 -= num68;
								num34 -= num9;
								num33 -= num69;
							}
							double num70 = num35 * num35;
							double num71 = num34 * num34;
							double num72 = num70 + num71;
							double num73 = num33 * num33;
							double num74 = num72 + num73;
							double num75 = num74;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							bool flag26 = !(num75 < 0.0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
							double num76 = 0.0;
							if (!flag26)
							{
								object obj40 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ X8_v82+A0]");
								object obj41 = 0;
								double num77 = num30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v83+18]");
								num36 = num77 * 0.0;
								double num78 = num31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v83+18]");
								num9 = num78 * 0.0;
								double num79 = num31;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v83+20]");
								vector2 = (Vector3)(num79 * 0);
								double num80 = num30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v83+1C]");
								num37 = num80 * 0.0;
								double num81 = num32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v83+20]");
								num76 = num81 * 0.0;
								double num82 = num32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ X8_v83+1C]");
								num74 = num82 * 0.0;
								num35 = (double)vector2 - num37;
								num34 = num36 - num76;
								num33 = num74 - num9;
							}
							object obj42 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ X0_v45+E4]");
							bool flag27 = (nint)0 == 0;
							object obj43 = !flag27;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							double num83 = num35 * num35;
							double num84 = num34 * num34;
							double num85 = num83 + num84;
							double num86 = num33 * num33;
							double num87 = num85 + num86;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							bool flag28 = !(num87 > 0.0);
							vector8 = (Vector3)0;
							num88 = 0.0;
							num89 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
							double num90 = 0.0;
							if (!flag28)
							{
								num90 = num35 / num87;
								num88 = num34 / num87;
								num89 = num33 / num87;
								vector8 = (Vector3)num90;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
							Vector3 position6 = ((Transform)0).position;
							object obj44 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1471 @ X8_v44+A0]");
							object obj45 = 0;
							double num91 = num8 - num90;
							object obj46 = _palmN - obj45;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+C4]");
							nint num92 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1474 @ X8_v45+8]");
							object obj47 = num92 - 0;
							double num93 = (double)vector4 - num87;
							double num94 = num6 - num9;
							object obj48 = obj46 * obj46;
							object obj49 = obj47 * obj47;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							double num95 = (double)obj49 + (double)obj48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
							if (!(num95 < 0.0))
							{
								Quaternion quaternion = Quaternion.Internal_AngleAxis(30f, ref axis);
								Vector3 vector9 = (Quaternion)0 * (Vector3)0;
								double num96 = 30.0 - num93;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								float num97 = 0f - (float)num91;
								double num98 = num6 - num94;
								if (isThumb)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
									Vector3 position7 = ((Transform)0).position;
									object obj50 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1764 @ X0_v86+E4]");
									bool flag29 = (nint)0 == 0;
									object obj51 = !flag29;
									if (obj51 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
									Vector3 position8 = ((Transform)0).position;
									vector10 = _palmFace;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
									num99 = 0.0;
									num100 = num6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
									num101 = 0.0;
									object obj52 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1849 @ X0_v91+E4]");
									bool flag30 = (nint)0 == 0;
									object obj53 = !flag30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									vector6 = (Vector3)0;
									if (obj53 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										vector11 = _palmFace;
										num102 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
										num103 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
										num104 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
										num105 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
										vector12 = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
										vector6 = (Vector3)0;
									}
									double num106 = num93 + 30.0;
									float num107 = (float)num91;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									float num108 = num107 + 0f;
									double num109 = num94 + num6;
									double num110 = num96 + num106;
									float num111 = num97 + num108;
									double num112 = num98 + num109;
									double num113 = num110 - (double)_palmFace;
									float num114 = num111;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									float num115 = num114 - 0f;
									double num116 = num112;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
									double num117 = num116 - 0.0;
									double num118 = num113 * num113;
									double num119 = num94 + num100;
									float num120 = num115 * num115;
									double num121 = num117 * num117;
									double num122 = num119 - num98;
									double num123 = num118 + (double)num120;
									double num124 = num93 + num101;
									double num125 = num122 - num99;
									double num126 = num121 + num123;
									double num127 = num91 + (double)vector6;
									double num128 = num124 - num96;
									float num129 = (float)num127 - num97;
									double num130 = num128 - (double)vector10;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									float num131 = num129;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									float num132 = num131 - 0f;
									double num133 = num130 * num130;
									float num134 = num132 * num132;
									double num135 = num133 + (double)num134;
									double num136 = num125 * num125;
									double num137 = num136 + num135;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									bool flag31 = !(num126 < num137);
									num138 = (float)vector11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
									num139 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									num140 = 0f;
									vector13 = _palmFace;
									num141 = num6;
									num142 = 30.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									num143 = 0f;
									axis = vector8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									num144 = 0.0;
									if (flag31)
									{
										goto IL_164c;
									}
									num145 = num102;
									num146 = num103;
									num147 = num104;
									num148 = num105;
									vector14 = vector12;
									vector15 = vector10;
									num149 = num100;
									vector16 = vector6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+D0]");
									num150 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									num151 = 0f;
									vector17 = _palmFace;
									num152 = num6;
									num153 = 30.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									num154 = 0f;
									num38 = num101;
									axis = vector8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+CC]");
									num36 = 0.0;
									num37 = num99;
								}
								else
								{
									double num155 = num96 * (double)_palmN;
									float num156 = num97;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+C0]");
									float num157 = num156 * 0f;
									double num158 = num155 + (double)num157;
									double num159 = num98;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+C4]");
									double num160 = num159 * 0.0;
									double num161 = num160 + num158;
									bool flag32 = !(num161 > 0.0);
									num138 = (float)vector11;
									num101 = num94;
									axis = vector8;
									num144 = num91;
									num99 = num93;
									num145 = num102;
									num146 = num103;
									num147 = num104;
									num148 = num105;
									vector14 = vector12;
									vector15 = vector10;
									num149 = num100;
									vector16 = vector6;
									num150 = num139;
									num151 = num140;
									vector17 = vector13;
									num152 = num141;
									num153 = num142;
									num154 = num143;
									num38 = num94;
									axis = vector8;
									num36 = num91;
									num37 = num93;
									if (flag32)
									{
										goto IL_164c;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
								Vector3 position9 = ((Transform)0).position;
								Quaternion quaternion2 = Quaternion.Internal_AngleAxis(-55f, ref axis);
								Vector3 vector18 = (Quaternion)0 * (Vector3)0;
								vector6 = _palmCentre;
								object obj54 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ X0_v62+E4]");
								bool flag33 = (nint)0 == 0;
								object obj55 = !flag33;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
								Vector3 position10 = ((Transform)0).position;
								Quaternion quaternion3 = Quaternion.Internal_AngleAxis(55f, ref axis);
								Vector3 vector19 = (Quaternion)0 * (Vector3)0;
								object obj56 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1907 @ X0_v71+E4]");
								bool flag34 = (nint)0 == 0;
								object obj57 = !flag34;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								float num162 = (float)num95 + 3.2608092E+09f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								float num163 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								float num164 = num163 + 0f;
								double num165 = num6 + num6;
								float num166 = num162 - (float)vector6;
								float num167 = num164;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B4]");
								float num168 = num167 - 0f;
								double num169 = num165;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								double num170 = num169 - 0.0;
								float num171 = num166 * num166;
								double num172 = num6 + num6;
								float num173 = num168 * num168;
								double num174 = num170 * num170;
								double num175 = num172;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								double num176 = num175 - 0.0;
								float num177 = num171 + num173;
								double num178 = num174 + (double)num177;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								float num179 = 0f + 1.1133256E+09f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								float num180 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								float num181 = num180 + 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								float num182 = num179 - (float)_palmCentre;
								float num183 = num181;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B4]");
								float num184 = num183 - 0f;
								float num185 = num182 * num182;
								float num186 = num184 * num184;
								float num187 = num185 + num186;
								double num188 = num176 * num176;
								float num189 = (float)num188 + num187;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								bool flag35 = !((double)num189 > num178);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								num138 = 0f;
								num102 = num6;
								num103 = num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								num104 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B4]");
								num105 = 0.0;
								vector12 = vector6;
								num139 = num95;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								num140 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								vector13 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								num141 = 0.0;
								num142 = num6;
								num143 = 3.2608092E+09f;
								num101 = num94;
								axis = vector8;
								num144 = num91;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B4]");
								num99 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								vector11 = (Vector3)0;
								num145 = num6;
								num146 = num6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								num147 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B4]");
								num148 = 0.0;
								vector14 = vector6;
								vector15 = vector10;
								num149 = num100;
								vector16 = vector6;
								num150 = num95;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								num151 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
								vector17 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B8]");
								num152 = 0.0;
								num153 = num6;
								num154 = 3.2608092E+09f;
								num38 = num94;
								axis = vector8;
								num36 = num91;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (HandPoser)+B4]");
								num37 = 0.0;
								if (!flag35)
								{
									goto IL_164c;
								}
							}
							vector2 = vector8;
							num = num2;
							num3 = num4;
							goto IL_20a5;
						}
					}
				}
				goto IL_19ac;
			}
			return curler;
			IL_164c:
			num88 = 0.0 - num88;
			num89 = 0.0 - num89;
			vector2 = 0 - vector8;
			vector11 = (Vector3)num138;
			num145 = num102;
			num146 = num103;
			num147 = num104;
			num148 = num105;
			vector14 = vector12;
			vector15 = vector10;
			num149 = num100;
			vector16 = vector6;
			num150 = num139;
			num151 = num140;
			vector17 = vector13;
			num152 = num141;
			num153 = num142;
			num154 = num143;
			num38 = num101;
			num36 = num144;
			num37 = num99;
			num = num2;
			num3 = num4;
			goto IL_20a5;
			IL_20a5:
			vector = 0 - vector2;
			num10 = 0.0 - num88;
			num9 = 0.0 - num89;
			if (!invertCurl)
			{
				vector = vector2;
			}
			if (!invertCurl)
			{
				num10 = num88;
			}
			object obj58 = obj59;
			if (!invertCurl)
			{
				num9 = num89;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X8_v20+20]");
			Vector3 vector20 = ((Transform)0).InverseTransformDirection((Vector3)0);
			bool flag36 = obj59 == null;
			curler = curler2;
			if (!flag36)
			{
				object obj60 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X24_v11+18]");
				bool flag37 = (nint)obj60 < 0;
				object obj61 = !flag37;
				if (obj61 != null)
				{
					break;
				}
				object obj62 = obj59 + obj13;
				obj14++;
				obj12 += 16;
				obj13 += 12;
				bones2 = f.bones;
				bool flag38 = f.bones == null;
				object obj63 = !flag38;
				curler = curler2;
				num102 = num145;
				num103 = num146;
				num104 = num147;
				num105 = num148;
				vector12 = vector14;
				vector10 = vector15;
				num100 = num149;
				vector6 = vector16;
				num139 = num150;
				num140 = num151;
				vector13 = vector17;
				num141 = num152;
				num142 = num153;
				num143 = num154;
				if (obj63 != null)
				{
					continue;
				}
			}
			goto IL_19ac;
		}
		goto IL_19c4;
		IL_059c:
		return null;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA7E8]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		curler2._002Ector();
		if (curler2 != null)
		{
			object obj65 = curler2 + 16;
			obj65 = f.bones;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform[] bones4 = f.bones;
			if (f.bones != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				obj18 = curler2 + 24;
				object obj67 = default;
				obj18 = obj67;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Transform[] bones5 = f.bones;
				if (f.bones != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
					object obj68 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					obj59 = curler2 + 32;
					object obj69 = default;
					obj59 = obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Transform[] bones6 = f.bones;
					if (f.bones != null)
					{
						if (bones6.Length == 0)
						{
							goto IL_19c4;
						}
						object obj70 = bones6.Length - 1;
						object obj71 = (object)f.bones + obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v15+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v15+20]");
							Vector3 position11 = ((Transform)0).position;
							Transform[] bones7 = f.bones;
							if ((nint)obj70 >= 1)
							{
								bool flag39 = f.bones == null;
								curler = curler2;
								if (!flag39)
								{
									bool flag40 = (nint)obj70 < bones7.Length;
									object obj72 = !flag40;
									if (obj72 != null)
									{
										goto IL_19c4;
									}
									object obj73 = (object)f.bones + obj70;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v98+20]");
									bool flag41 = (nint)0 == 0;
									curler = curler2;
									if (!flag41)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v98+20]");
										Vector3 position12 = ((Transform)0).position;
										Transform[] bones8 = f.bones;
										bool flag42 = f.bones == null;
										curler = curler2;
										if (!flag42)
										{
											object obj74 = bones6.Length - 2;
											bool flag43 = (nint)obj74 < bones8.Length;
											object obj75 = !flag43;
											if (obj75 != null)
											{
												goto IL_19c4;
											}
											object obj76 = (object)f.bones + obj74;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v100+20]");
											bool flag44 = (nint)0 == 0;
											curler = curler2;
											if (!flag44)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v100+20]");
												Vector3 position13 = ((Transform)0).position;
												object obj77 = vector5 - vector5;
												num10 = num2 - num2;
												num9 = num4 - num4;
												vector2 = vector5 + obj77;
												double num190 = num2 + num10;
												double num191 = num4 + num9;
												num6 = num191;
												vector4 = vector2;
												num8 = num190;
												goto IL_1a16;
											}
										}
									}
								}
							}
							else
							{
								bool flag45 = f.bones == null;
								curler = curler2;
								if (!flag45)
								{
									bool flag46 = (nint)obj70 < bones7.Length;
									object obj78 = !flag46;
									if (obj78 != null)
									{
										goto IL_19c4;
									}
									object obj79 = (object)f.bones + obj70;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v95+20]");
									bool flag47 = (nint)0 == 0;
									curler = curler2;
									if (!flag47)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v95+20]");
										int childCount2 = ((Transform)0).childCount;
										bool flag48 = childCount2 < 1;
										num9 = num4;
										num10 = num2;
										num6 = num4;
										vector4 = vector5;
										num8 = num2;
										if (flag48)
										{
											goto IL_1a16;
										}
										Transform[] bones9 = f.bones;
										bool flag49 = f.bones == null;
										curler = curler2;
										if (!flag49)
										{
											bool flag50 = (nint)obj70 < bones9.Length;
											object obj80 = !flag50;
											if (obj80 != null)
											{
												goto IL_19c4;
											}
											object obj81 = (object)f.bones + obj70;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v97+20]");
											bool flag51 = (nint)0 == 0;
											curler = curler2;
											if (!flag51)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X8_v97+20]");
												Transform child2 = ((Transform)0).GetChild(0);
												bool flag52 = (object)child2 == null;
												curler = curler2;
												if (!flag52)
												{
													Vector3 position14 = child2.position;
													num9 = num4;
													num10 = num2;
													num6 = num4;
													vector4 = vector5;
													num8 = num2;
													bool flag2 = false;
													goto IL_1a16;
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
		goto IL_19ac;
	}

	private unsafe void LateUpdate()
	{
		//IL_002f: Expected Obj, but got I4
		//IL_009e: Invalid comparison between F4 and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Ref, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Ref, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Ref, but got Unknown
		//IL_00d1: Invalid comparison between F4 and I4
		//IL_00e0: Invalid comparison between F4 and I4
		//IL_00f7: Expected Obj, but got F4
		//IL_0106: Expected Obj, but got F4
		//IL_0154: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_030d: Invalid comparison between F4 and I4
		//IL_031c: Invalid comparison between F4 and I4
		//IL_032f: Expected Obj, but got F4
		//IL_033c: Expected Obj, but got F4
		//IL_0371: Expected Obj, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I8
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_03ad: Invalid comparison between F4 and I4
		//IL_03bc: Invalid comparison between F4 and I4
		//IL_03cf: Expected Obj, but got F4
		//IL_03dc: Expected Obj, but got F4
		//IL_0411: Expected Obj, but got I4
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		if (~(_ready ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag = (byte)(~(remote ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			ReadInput(out *(float*)(this + 136), out *(float*)(this + 140), out *(float*)(this + 144));
		}
		float num = trigger;
		float target = grip;
		float num2 = thumbPress;
		if (gripOverride > 0f)
		{
			float num3 = grip - gripOverride;
			bool flag2 = num3 < 0f;
			bool flag3 = num3 == 0f;
			object obj2 = grip ^ gripOverride;
			object obj3 = grip ^ num3;
			object obj4 = obj2 & obj3;
			bool flag4 = (nint)obj4 < 0;
			float num4 = gripOverride;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num5 = num4 * 0f;
			bool flag5 = flag2 == flag4;
			object obj5 = !flag3;
			object obj6 = flag5 & obj5;
			object obj7 = ~obj6;
			if (obj7 != null)
			{
				target = gripOverride;
			}
			float num6 = gripOverride;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num7 = num6 * 0f;
			float num8 = num - num5;
			bool flag6 = num8 < 0f;
			bool flag7 = num8 == 0f;
			object obj8 = num ^ num5;
			object obj9 = num ^ num8;
			object obj10 = obj8 & obj9;
			bool flag8 = (nint)obj10 < 0;
			bool flag9 = flag6 == flag8;
			object obj11 = !flag7;
			object obj12 = flag9 & obj11;
			object obj13 = ~obj12;
			if (obj13 != null)
			{
				num = num5;
			}
			float num9 = num2 - num7;
			bool flag10 = num9 < 0f;
			bool flag11 = num9 == 0f;
			object obj14 = num2 ^ num7;
			object obj15 = num2 ^ num9;
			object obj16 = obj14 & obj15;
			bool flag12 = (nint)obj16 < 0;
			bool flag13 = flag10 == flag12;
			object obj17 = !flag11;
			object obj18 = flag13 & obj17;
			object obj19 = ~obj18;
			if (obj19 != null)
			{
				num2 = num7;
			}
		}
		float deltaTime = Time.deltaTime;
		Apply(_index, num, fingerCurl, deltaTime, fingerJointWeights);
		Apply(_thumb, num2, thumbCurl, deltaTime, thumbJointWeights);
		Curler[] array = _grip;
		if (_grip == null || array.Length < 1)
		{
			return;
		}
		object obj20 = array.Length & 0xFFFFFFFFL;
		object obj21 = _grip + 32;
		object obj22 = 0;
		while (true)
		{
			bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
			object obj23 = !flag14;
			if (obj23 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X22_v3+v159 @ X21_v4*8]");
			Apply((Curler)0, target, fingerCurl, deltaTime, fingerJointWeights);
			obj20 = array.Length;
			obj22++;
			if ((nint)obj22 >= array.Length)
			{
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	private void Apply(Curler c, float target, float degrees, float dt, float[] weights)
	{
		//IL_002d: Expected F4, but got I
		//IL_003f: Invalid comparison between F4 and I
		//IL_043e: Invalid comparison between F4 and I4
		//IL_044d: Expected F8, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01b8: Expected I4, but got Obj
		//IL_0266: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_01f0: Expected F8, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_03c8: Expected VT, but got I4
		//IL_03c8: Expected Obj, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0402: Expected Obj, but got I4
		//IL_0412: Expected VT, but got I
		if (c == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		float num = 0f;
		float num2 = responsiveness;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (!(num2 < 0f))
		{
			num = responsiveness;
		}
		bool flag = overshoot < 0f;
		double num3 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)overshoot > 1.0);
			num3 = overshoot;
			if (!flag2)
			{
				num3 = 1.0;
			}
		}
		float num4 = num * num;
		double num5 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA8C]");
		double num6 = num5 * 0.0;
		double num7 = num6 + 1.0;
		float num8 = target - c.value;
		double num9 = num7 + num7;
		float num10 = num4 * num8;
		float num11 = num * (float)num9;
		float num12 = num11 * c.vel;
		float num13 = num10 - num12;
		float num14 = num13 * dt;
		float num15 = c.vel + num14;
		float num16 = num15 * dt;
		c.vel = num15;
		float num17 = c.value + num16;
		bool flag3 = (double)num17 < -0.25;
		double num18 = -0.25;
		if (!flag3)
		{
			bool flag4 = !((double)num17 > 1.25);
			num18 = num17;
			if (!flag4)
			{
				num18 = 1.25;
			}
		}
		Transform[] bones = c.bones;
		c.value = (float)num18;
		object obj = 0;
		Vector3 axis2 = default;
		while (true)
		{
			if ((nint)obj >= bones.Length)
			{
				return;
			}
			double num19;
			if (weights != null && weights.Length != 0)
			{
				object obj2 = weights.Length - 1;
				object obj3 = obj - obj2;
				bool flag5 = (nint)obj3 < 0;
				object obj4 = obj ^ obj2;
				object obj5 = obj ^ obj3;
				object obj6 = obj4 & obj5;
				bool flag6 = (nint)obj6 < 0;
				bool flag7 = flag5 == flag6;
				object obj7 = !flag7;
				if ((int)(~obj7) == 0)
				{
					obj2 = obj;
				}
				bool flag8 = (nint)obj2 < weights.Length;
				object obj8 = !flag8;
				if (obj8 != null)
				{
					break;
				}
				object obj9 = (object)weights + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v11+20]");
				num19 = 0.0;
			}
			else
			{
				bool flag9 = obj == null;
				object obj10 = !flag9;
				num19 = 1.0;
				if (obj10 == null)
				{
					num19 = knuckleWeight;
				}
			}
			bool flag10 = (nint)obj < bones.Length;
			object obj11 = !flag10;
			if (obj11 != null)
			{
				break;
			}
			Quaternion[] rest = c.rest;
			bool flag11 = (nint)obj < rest.Length;
			object obj12 = !flag11;
			if (obj12 != null)
			{
				break;
			}
			Vector3[] axis = c.axis;
			bool flag12 = (nint)obj < axis.Length;
			object obj13 = !flag12;
			if (obj13 != null)
			{
				break;
			}
			double num20 = num19 * (double)degrees;
			object obj14 = obj * 12;
			object obj15 = (object)axis + obj14;
			object obj16 = (object)rest + obj;
			object obj17 = (object)bones + obj;
			float num21 = (float)num20 * c.value;
			Quaternion quaternion = Quaternion.Internal_AngleAxis(num21, ref axis2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X9_v6+2C]");
			float num22 = 0f * num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X9_v6+20]");
			float num23 = 0f * num21;
			float num24 = num22 - num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X9_v6+24]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v7+20]");
			object obj18 = num25 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X9_v6+28]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v7+28]");
			object obj19 = num26 * 0;
			float num27 = num24 - (float)obj18;
			num15 = num27 - (float)obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v7+20]");
			((Transform)0).localRotation = (Quaternion)0;
			bones = c.bones;
			obj++;
			bool flag13 = c.bones == null;
			object obj20 = !flag13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X10_v7+20]");
			axis2 = (Vector3)0;
			if (obj20 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	public void ReadNow(out float trigger, out float grip, out float thumbPress)
	{
		ReadInput(out trigger, out grip, out thumbPress);
	}

	private unsafe void ReadInput(out float trigger, out float grip, out float thumbPress)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_030b: Expected VT, but got I
		//IL_0327: Expected Obj, but got I
		//IL_0340: Expected VT, but got I
		//IL_035c: Expected Obj, but got I
		//IL_0375: Expected VT, but got I
		//IL_038e: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bc: Expected VT, but got I
		//IL_00da: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0140: Expected F8, but got I4
		//IL_03d3: Expected Obj, but got I
		//IL_03eb: Expected Obj, but got I
		//IL_0432: Expected Ref, but got F8
		//IL_044c: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I4
		//IL_01ca: Expected F8, but got I4
		//IL_0418: Expected Ref, but got F8
		//IL_026e: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_0230: Expected F8, but got I4
		//IL_0425: Expected Ref, but got F8
		ref float reference = ref *(float*)null;
		ref float reference2 = ref *(float*)null;
		ref float reference3 = ref *(float*)null;
		UnityEngine.XR.InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
		UnityEngine.XR.InputDevice inputDevice = default;
		double num;
		if (inputDevice.isValid)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8EB0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v31+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v30+78]");
			bool flag2 = inputDevice.TryGetFeatureValue((InputFeatureUsage<float>)0, out trigger);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v31+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v32+80]");
			bool flag3 = inputDevice.TryGetFeatureValue((InputFeatureUsage<float>)0, out grip);
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v33+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v34+8]");
			bool flag4 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out var value);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v35+A0]");
			object obj10 = 0;
			bool flag5 = !value;
			object obj11 = !flag5;
			object obj12 = flag4 & obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v36+18]");
			bool flag6 = inputDevice.TryGetFeatureValue((InputFeatureUsage<bool>)0, out var value2);
			bool flag7 = !value2;
			object obj13 = !flag7;
			object obj14 = flag6 & obj13;
			object obj15 = obj12 | obj14;
			bool flag8 = obj15 == null;
			object obj16 = !flag8;
			object obj17 = ~obj16;
			num = ((obj17 != null) ? 0.0 : 1.0);
		}
		else
		{
			if (~(desktopFallback ? 1u : 0u) != 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D00]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v10+A0]");
			object obj20 = 0;
			if (obj20 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D10]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v17+A0]");
			object obj23 = 0;
			object obj24 = obj23;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X22_v7+1C0]");
				bool isPressed = ((ButtonControl)0).isPressed;
				bool flag9 = !isPressed;
				object obj25 = !flag9;
				object obj26 = ~obj25;
				double num2 = ((obj26 != null) ? 0.0 : 1.0);
				reference3 = ref *(float*)num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X22_v7+1D0]");
				bool isPressed2 = ((ButtonControl)0).isPressed;
				bool flag10 = !isPressed2;
				object obj27 = !flag10;
				object obj28 = ~obj27;
				double num3 = ((obj28 != null) ? 0.0 : 1.0);
				reference2 = ref *(float*)num3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
			object obj29 = 0;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v23+A0]");
			object obj31 = 0;
			if (obj31 == null)
			{
				return;
			}
			KeyControl spaceKey = ((Keyboard)obj31).spaceKey;
			bool isPressed3 = spaceKey.isPressed;
			bool flag11 = !isPressed3;
			object obj32 = !flag11;
			num = 1.0;
			if (obj32 == null)
			{
				return;
			}
		}
		reference = ref *(float*)num;
	}

	public HandPoser()
	{
		//IL_0028: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EA50]");
		fingerCurl = 0f;
		desktopFallback = true;
		base._002Ector();
	}

	internal unsafe static void _003CPalmCentre_003Eg__Add_007C32_0(Finger f, ref KillCam._003C_003Ec__DisplayClass32_0 P_1)
	{
		//IL_0082: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		if (f == null)
		{
			return;
		}
		Transform[] bones = f.bones;
		if (f.bones == null || bones.Length == 0)
		{
			return;
		}
		if (bones.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(bones[0] != null))
			{
				return;
			}
			Transform[] bones2 = f.bones;
			if (bones2.Length != 0)
			{
				Vector3 position = bones2[0].position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass32_0&)+8]");
				object obj5 = default;
				object obj4 = 0 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X1 (<>c__DisplayClass32_0&)+C]");
				object obj6 = (nint)0 + (nint)1;
				object obj8 = default;
				object obj7 = P_1 + obj8;
				ref KillCam._003C_003Ec__DisplayClass32_0 reference = ref *(KillCam._003C_003Ec__DisplayClass32_0*)obj7;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
