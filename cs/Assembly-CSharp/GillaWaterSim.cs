using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class GillaWaterSim : MonoBehaviour
{
	private sealed class _003CPrefabs_003Ed__59 : _00210, _0021_00210, _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private GameObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private GillaSpawnables _003Cspawnables_003E5__2;

		private MonsterDirector.Entry[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private CosmeticCatalog.Entry[] _003C_003E7__wrap4;

		private MonsterDirector[] _003C_003E7__wrap5;

		private MonsterDisplay.Spawn[] _003C_003E7__wrap6;

		private int _003C_003E7__wrap7;

		private GillaItemDirector[] _003C_003E7__wrap8;

		private GillaItemDirector.Kind[] _003C_003E7__wrap9;

		private GillaSplashDirector[] _003C_003E7__wrap10;

		private NetworkBootstrap[] _003C_003E7__wrap11;

		private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CPrefabs_003Ed__59(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005a: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I4
			//IL_0084: Expected Obj, but got I4
			//IL_0014: Expected Obj, but got I4
			//IL_002a: Expected Obj, but got I
			while (true)
			{
				int num = _003C_003E1__state;
				bool flag = _003C_003E1__state < 12;
				object obj = !flag;
				object obj2 = _003C_003E1__state - 12;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				object obj4 = obj & obj3;
				if (obj4 != null)
				{
					break;
				}
				object obj5 = 17588224 + 3230;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X9_v2+v39 @ X8_v3 (System.Int32)*2]");
				object obj6 = (nint)48714608 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X10_v2 (should have been resolved before IL gen)");
			}
			return false;
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

		private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
		{
			//IL_009d: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got I
			object obj = _003C_003E1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					return (IEnumerator<GameObject>)(object)this;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA448]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			obj4._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			return (IEnumerator<GameObject>)obj4;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator();
		}
	}

	public Shader simShader;

	public float spread;

	public float damp;

	public float keep;

	public const int Size = default(int);

	public const float Cell = default(float);

	private const float StepEvery = default(float);

	private const int MaxDrops = default(int);

	private static GillaWaterSim instance;

	private static readonly List<Vector4> pending;

	private static readonly Vector4[] drops;

	private static readonly int WaveTex;

	private static readonly int WaveRect;

	private static readonly int SolidTex;

	private static readonly int SolidRect;

	private static readonly int SimRect;

	private static readonly int Shift;

	private static readonly int C;

	private static readonly int Damp;

	private static readonly int Keep;

	private static readonly int DropCount;

	private static readonly int Drops;

	private RenderTexture front;

	private RenderTexture back;

	private Material mat;

	private int cornerX;

	private int cornerZ;

	private bool placed;

	private bool broken;

	private float budget;

	public static void Drop(Vector3 at, float strength)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_0426: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_0445: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_019b: Invalid comparison between F8 and I4
		//IL_01b2: Expected F8, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_04ea: Expected Obj, but got I
		//IL_04fa: Expected Obj, but got I
		//IL_0503: Invalid comparison between F8 and I4
		//IL_016e: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0245: Expected F8, but got I4
		//IL_02d0: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_027e: Expected F8, but got I
		//IL_0348: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I
		//IL_03eb: Expected VT, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0398: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v7+8]");
		List<Vector4> list = (List<Vector4>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v22 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
		bool flag6 = (nint)0 < (nint)16;
		object obj12 = 0;
		int num = 0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v23+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v24+8]");
				list = (List<Vector4>)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6C8]");
			object obj16 = 0;
			obj12 = obj16;
			list.RemoveAt(0);
			num = 0;
		}
		double num2 = default;
		bool flag8 = num2 < 0.0;
		double num3 = strength;
		double num4 = 0.0;
		if (!flag8)
		{
			bool flag9 = !(num2 > 1.0);
			num3 = 1.0;
			num4 = num2;
			if (!flag9)
			{
				num3 = 1.0;
				num4 = 1.0;
			}
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v14+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v12+8]");
		List<Vector4> list2 = (List<Vector4>)0;
		if (num4 < 0.0)
		{
			double num5 = 0.25;
			num4 = 0.0;
		}
		else if (num4 > 1.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			double num5 = 0.0;
			num4 = 1.0;
		}
		else
		{
			double num6 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			double num7 = num6 * 0.0;
			double num5 = num7 + 0.25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A58]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
		object obj21 = 0;
		object obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
		object obj23 = (nint)0 + (nint)1;
		double num8 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A854]");
		double num9 = num8 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X9_v6+18]");
		bool flag11 = num10 < 0;
		object obj24 = !flag11;
		double num11 = num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
		double num12 = num11 + 0.0;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
			object obj25 = obj21 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
			object obj26 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v16+20]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v17+A8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v18+70]");
			list2.AddWithResize((Vector4)0);
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
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
		object obj4 = 0;
		obj4 = this;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I4
		//IL_01e7: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj6 == this;
		bool flag4 = !flag3;
		UnityEngine.Object obj8 = this;
		if (!flag4)
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v20+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v20+A0]");
			object obj11 = 0;
			obj11 = 0;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = null;
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v9+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v2+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+1C]");
		object obj17 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v2+1C]");
		Shader.SetGlobalVector(0, (Vector4)0);
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
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
		bool flag2 = front != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			front.Release();
			obj4 = null;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = back != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj7 = null;
		if (!flag6)
		{
			back.Release();
			obj7 = null;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mat != null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v18+E4]");
			bool flag8 = (nint)0 == 0;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(mat);
		}
	}

	private bool Ready()
	{
		//IL_0010: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0346: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0131: Expected VT, but got I4
		//IL_0293: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I4
		//IL_0151: Expected VT, but got I4
		//IL_02f5: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			goto IL_004f;
		}
		bool flag2 = (byte)(~(broken ? 1u : 0u)) != 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = simShader == null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				bool flag6 = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)13);
				bool flag7 = !flag6;
				object obj9 = !flag7;
				GillaWounds._003C_003Ec__DisplayClass34_0 obj10 = (GillaWounds._003C_003Ec__DisplayClass34_0)13;
				RenderTextureFormat format = (RenderTextureFormat)13;
				if (obj9 == null)
				{
					obj10 = (GillaWounds._003C_003Ec__DisplayClass34_0)2;
					format = (RenderTextureFormat)2;
				}
				if (SystemInfo.SupportsRenderTextureFormat(format))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v21+E4]");
					bool flag8 = (nint)0 == 0;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6D8]");
					object obj14 = 0;
					RenderTexture renderTexture = _003CReady_003Eg__Make_007C34_0((string)obj14, ref obj10);
					front = renderTexture;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6D0]");
					object obj15 = 0;
					RenderTexture renderTexture2 = _003CReady_003Eg__Make_007C34_0((string)obj15, ref obj10);
					object obj16 = this + 64;
					obj16 = renderTexture2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Material material = default;
					material._002Ector(simShader);
					object obj18 = this + 72;
					obj18 = material;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_004f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj19 = 0;
				broken = true;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v17+E4]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6E0]");
				object message = 0;
				Debug.LogWarning(message);
			}
		}
		return false;
		IL_004f:
		return true;
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I4
		//IL_05d6: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_0681: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I4
		//IL_00dd: Expected VT, but got I4
		//IL_0332: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I4
		//IL_06ac: Expected VT, but got I4
		//IL_05f4: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I4
		//IL_0278: Invalid comparison between F4 and I4
		//IL_085e: Expected Obj, but got I4
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0663: Expected Obj, but got I4
		//IL_0404: Invalid comparison between F8 and I4
		//IL_0756: Expected Obj, but got I4
		//IL_08bf: Invalid comparison between F4 and I
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_070d: Expected Obj, but got I4
		//IL_0546: Expected Obj, but got I4
		//IL_04f9: Expected I4, but got F4
		//IL_0503: Expected I4, but got F8
		//IL_07e4: Expected Obj, but got I
		//IL_081d: Expected Obj, but got I
		//IL_0833: Expected VT, but got I4
		//IL_0799: Expected I4, but got F8
		//IL_0799: Expected I4, but got F4
		//IL_07b5: Invalid comparison between F4 and I
		//IL_07c6: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		UnityEngine.Object obj5 = null;
		float num = default;
		if (!flag3)
		{
			Transform transform = main.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7A00]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v69+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaSplashPool gillaSplashPool = GillaSplashPool.Near((Vector3)0, num);
			obj4 = null;
			obj5 = gillaSplashPool;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
		object obj11 = 0;
		bool flag6 = obj5 == null;
		bool flag7 = !flag6;
		object obj12 = !flag7;
		int num2 = 0;
		UnityEngine.Object obj13 = null;
		object obj17;
		double num4;
		float num5;
		float num8;
		double num7;
		if (obj12 == null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v22+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X20_v3 (UnityEngine.Object)+80]");
			bool flag9 = (UnityEngine.Object)0 == null;
			bool flag10 = !flag9;
			object obj16 = !flag10;
			num2 = 0;
			obj13 = null;
			if (obj16 == null)
			{
				bool flag11 = Ready();
				bool flag12 = !flag11;
				num2 = 0;
				obj13 = null;
				if (!flag12)
				{
					Transform transform2 = main.transform;
					Vector3 position2 = transform2.position;
					float num3 = num * 8f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					obj17 = 0;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v32+E4]");
					bool flag13 = (nint)0 == 0;
					object obj19 = !flag13;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					float num6 = default;
					if (num3 < 0f)
					{
						if ((double)num3 == -0.5)
						{
							num4 = -1.0;
							num5 = num6;
							goto IL_062c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
						num7 = -0.5;
						num8 = num3;
					}
					else
					{
						if ((double)num3 == 0.5)
						{
							num4 = 1.0;
							num5 = num6;
							goto IL_062c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						num7 = 0.5;
						num8 = num3;
					}
					goto IL_06bd;
				}
			}
		}
		object obj20 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+E4]");
		bool flag14 = (nint)0 == 0;
		object obj21 = !flag14;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v14+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X9_v2+1C]");
		object obj24 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+1C]");
		Shader.SetGlobalVector(0, (Vector4)0);
		placed = false;
		return;
		IL_06bd:
		object obj25 = default;
		double num9 = (double)obj25 * 8.0;
		object obj26 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v37+E4]");
		bool flag15 = (nint)0 == 0;
		object obj27 = !flag15;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num10;
		double num11;
		double num12 = default;
		if (num9 < 0.0)
		{
			if (num9 == -0.5)
			{
				num10 = -1.0;
				num11 = num12;
				goto IL_06d6;
			}
			num11 = num9 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (num9 == 0.5)
			{
				num10 = 1.0;
				num11 = num12;
				goto IL_06d6;
			}
			num11 = num9 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_0720;
		IL_06d6:
		double num13 = num11 + num10;
		object obj28 = num11 & 1;
		bool flag16 = obj28 == null;
		object obj29 = !flag16;
		if (obj29 != null)
		{
			num11 = num13;
		}
		goto IL_0720;
		IL_0720:
		float num14 = num8 - 128f;
		double num15 = num11 - 128.0;
		bool flag17 = (byte)(~(placed ? 1u : 0u)) != 0;
		object obj30 = !flag17;
		if (obj30 == null)
		{
			cornerX = (int)num14;
			cornerZ = (int)num15;
			placed = true;
		}
		float deltaTime = Time.deltaTime;
		float num16 = budget + deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		budget = num16;
		RenderTexture active = RenderTexture.active;
		float num17 = budget;
		float num18 = budget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF1C]");
		bool flag18 = num18 < 0f;
		int num19 = 0;
		if (!flag18)
		{
			bool flag19;
			do
			{
				float num20 = budget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8A0]");
				float num21 = num20 + 0f;
				budget = num21;
				Step((GillaSplashPool)obj5, (int)num14, (int)num15);
				num17 = budget;
				float num22 = budget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF1C]");
				flag19 = !(num22 < 0f);
				num19 = (int)num14;
			}
			while (flag19);
		}
		RenderTexture.active = active;
		object obj31 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v47+E4]");
		bool flag20 = (nint)0 == 0;
		object obj32 = !flag20;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v47+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v30+18]");
		Shader.SetGlobalTexture(0, front);
		object obj34 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v31+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v32+1C]");
		Shader.SetGlobalVector(0, (Vector4)0);
		return;
		IL_062c:
		num7 = (double)num5 + num4;
		object obj36 = num5 & 1;
		bool flag21 = obj36 == null;
		object obj37 = !flag21;
		num8 = ((obj37 != null) ? ((float)num7) : num5);
		goto IL_06bd;
	}

	private void Step(GillaSplashPool pool, int x, int z)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_0077: Expected VT, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00de: Expected VT, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_01b7: Expected VT, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I
		//IL_02eb: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected I4, but got Unknown
		//IL_0395: Expected Obj, but got I4
		//IL_0729: Expected Obj, but got I4
		//IL_07fb: Expected Obj, but got I4
		//IL_07b4: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I4
		//IL_0796: Expected Obj, but got I4
		//IL_055d: Expected Obj, but got I
		//IL_0747: Expected Obj, but got I
		//IL_0594: Expected Obj, but got I
		//IL_05af: Expected F4, but got I4
		//IL_042e: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		//IL_05f6: Expected Obj, but got I
		//IL_0619: Expected Obj, but got I
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_065c: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5;
		int num8;
		object obj18;
		int num;
		if ((object)mat != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v3+A0]");
			object obj5 = 0;
			Material material = mat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8+2C]");
			material.SetVector(0, (Vector4)0);
			cornerX = x;
			cornerZ = z;
			if ((object)mat != null)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v9+A0]");
				object obj7 = 0;
				Material material2 = mat;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v10+28]");
				material2.SetVector(0, (Vector4)0);
				if ((object)pool != null && (object)mat != null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v11+A0]");
					object obj9 = 0;
					Material material3 = mat;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v12+20]");
					material3.SetTexture(0, pool.foamMap);
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v13+A0]");
					object obj11 = 0;
					Vector4 foamRect = pool.FoamRect;
					if ((object)mat != null)
					{
						Material material4 = mat;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v14+24]");
						material4.SetVector(0, (Vector4)0);
						if ((object)mat != null)
						{
							object obj12 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v15+A0]");
							object obj13 = 0;
							Material material5 = mat;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v16+30]");
							material5.SetFloat(0, spread);
							if ((object)mat != null)
							{
								object obj14 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v17+A0]");
								object obj15 = 0;
								Material material6 = mat;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v18+34]");
								material6.SetFloat(0, damp);
								if ((object)mat != null)
								{
									object obj16 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v19+A0]");
									object obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v20+38]");
									num = 0;
									Material material7 = mat;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v20+38]");
									material7.SetFloat(0, keep);
									obj18 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v19+A0]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v21+8]");
									object obj20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v21+8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v22+18]");
										object obj21 = -8;
										bool flag2 = (nint)obj21 < 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v22+18]");
										int num2 = (int)((nint)0 ^ (nint)8);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v22+18]");
										int num3 = 0 ^ obj21;
										int num4 = num2 & num3;
										bool flag3 = num4 < 0;
										bool flag4 = flag2 == flag3;
										object obj22 = !flag4;
										object obj23 = ~obj22;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v22+18]");
											num5 = 0;
										}
										else
										{
											num5 = 8;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v22+18]");
										bool flag5 = (nint)0 < (nint)1;
										object obj24 = 0;
										if (flag5)
										{
											goto IL_07d9;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6B08]");
										object obj25 = 0;
										obj24 = 0;
										int num6 = 0;
										object obj26 = 32;
										while (true)
										{
											object obj27 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v35+E4]");
											bool flag6 = (nint)0 == 0;
											object obj28 = !flag6;
											if (obj28 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj27 = obj;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v35+A0]");
											object obj29 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v36+8]");
											if ((nint)0 == 0)
											{
												break;
											}
											obj24 = obj25;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v36+10]");
											object obj30 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v36+8]");
											Vector4 vector = ((List<Vector4>)0).get_Item(num6);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v36+10]");
											if ((nint)0 == 0)
											{
												break;
											}
											int num7 = num6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X25_v6+18]");
											bool flag7 = (nint)num7 < (nint)0;
											object obj31 = !flag7;
											if (obj31 == null)
											{
												num8 = num6 + 1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v36+10]");
												object obj32 = 0 + obj26;
												obj26 += 16;
												obj32 = keep;
												_ = 66;
												_ = 0;
												bool flag8 = num5 != num8;
												num = num6;
												num6 = num8;
												if (flag8)
												{
													continue;
												}
												goto IL_0516;
											}
											goto IL_06ca;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_06bc;
		IL_06ca:
		throw new IndexOutOfRangeException();
		IL_07d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v19+E4]");
		bool flag9 = (nint)0 == 0;
		object obj33 = !flag9;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v19+A0]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v26+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v26+8]");
			((List<Vector4>)0).RemoveRange(0, num5);
			if ((object)mat != null)
			{
				object obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v29+A0]");
				object obj36 = 0;
				Material material8 = mat;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v30+3C]");
				material8.SetFloat(0, num5);
				if ((object)mat != null)
				{
					object obj37 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v31+A0]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6E8]");
					object obj39 = 0;
					Material material9 = mat;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v32+40]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v32+10]");
					material9.SetVectorArray((int)num9, (Vector4[])0);
					object obj40 = obj39;
					object obj41 = this + 56;
					object obj42 = obj41 + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v23+E4]");
					bool flag10 = (nint)0 == 0;
					object obj43 = !flag10;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object source = obj41;
					object dest = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X19_v2+10]");
					Graphics.Blit((Texture)source, (RenderTexture)dest, (Material)0);
					obj41 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj42 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
		}
		goto IL_06bc;
		IL_06bc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06ca;
		IL_0516:
		obj18 = obj;
		num = num8;
		goto IL_07d9;
	}

	public GillaWaterSim()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B358]");
		spread = 0f;
		keep = 0.9985f;
		base._002Ector();
	}

	static GillaWaterSim()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C84F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA6F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA700]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA708]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA710]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA718]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA720]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<Vector4> list = default;
		list._002Ector();
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v3+A0]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+A0]");
		object obj13 = (nint)0 + (nint)16;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)obj4);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v7+A0]");
		object obj16 = 0;
		int num2 = Shader.PropertyToID((string)obj5);
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+A0]");
		object obj18 = 0;
		int num3 = Shader.PropertyToID((string)obj6);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+A0]");
		object obj20 = 0;
		int num4 = Shader.PropertyToID((string)obj7);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v13+A0]");
		object obj22 = 0;
		int num5 = Shader.PropertyToID((string)obj8);
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v15+A0]");
		object obj24 = 0;
		int num6 = Shader.PropertyToID((string)obj9);
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v17+A0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA740]");
		object obj27 = 0;
		int num7 = Shader.PropertyToID((string)obj27);
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v21+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA728]");
		object obj30 = 0;
		int num8 = Shader.PropertyToID((string)obj30);
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v25+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA748]");
		object obj33 = 0;
		int num9 = Shader.PropertyToID((string)obj33);
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v29+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA738]");
		object obj36 = 0;
		int num10 = Shader.PropertyToID((string)obj36);
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v33+A0]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA730]");
		object obj39 = 0;
		int num11 = Shader.PropertyToID((string)obj39);
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v37+A0]");
		object obj41 = 0;
	}

	internal static RenderTexture _003CReady_003Eg__Make_007C34_0(string name, ref GillaWounds._003C_003Ec__DisplayClass34_0 P_1)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f2: Expected I4, but got VT
		//IL_00a1: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8568]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RenderTexture renderTexture = default;
		renderTexture._002Ector(256, 256, 0, (RenderTextureFormat)P_1, (RenderTextureReadWrite)1);
		if ((object)renderTexture != null)
		{
			renderTexture.name = name;
			renderTexture.filterMode = (FilterMode)1;
			renderTexture.wrapMode = (TextureWrapMode)1;
			renderTexture.useMipMap = false;
			renderTexture.antiAliasing = 1;
			bool flag = renderTexture.Create();
			RenderTexture active = RenderTexture.active;
			RenderTexture.active = renderTexture;
			GL.Clear(clearDepth: false, clearColor: true, (Color)0);
			RenderTexture.active = active;
			return renderTexture;
		}
		return (RenderTexture)(object)new NullReferenceException();
	}
}
