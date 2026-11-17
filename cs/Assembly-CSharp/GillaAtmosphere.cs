using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaAtmosphere : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass43_0
	{
		public TornArm arm;

		public BoxCollider box;
	}

	public GillaBackpack.Air indoors;

	public GillaBackpack.Air[] zones;

	public float ease;

	private const float DarkDensity = default(float);

	public unsafe GillaBackpack.Air At(Vector3 p)
	{
		//IL_0150: Expected VT, but got Obj
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I8
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_0092: Expected VT, but got I
		//IL_009f: Expected Ref, but got VT
		//IL_00c2: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got Ref
		//IL_00e2: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		GillaBackpack.Air[] array = zones;
		object obj7;
		if (zones != null)
		{
			if (array.Length < 1)
			{
				goto IL_0124;
			}
			object obj = array.Length & 0xFFFFFFFFL;
			object obj2 = zones + 32;
			object obj3 = 0;
			object obj5 = default;
			Vector3 point = default;
			Vector3 vector = default;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
				Bounds bounds = (Bounds)((nint)(&obj5) | (nint)8);
				bool flag2 = ((Bounds*)bounds)->Internal_Contains(ref point);
				bool flag3 = !flag2;
				object obj6 = !flag3;
				obj7 = (object)(&obj5);
				if (obj6 == null)
				{
					obj = array.Length;
					obj3++;
					obj2 += 104;
					bool flag4 = (nint)obj3 < array.Length;
					point = vector;
					if (flag4)
					{
						continue;
					}
					goto IL_0124;
				}
				goto IL_0150;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (GillaBackpack.Air)ex2;
		IL_0124:
		obj7 = this + 32;
		goto IL_0150;
		IL_0150:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		GillaBackpack.Air result = default;
		return result;
	}

	public unsafe void ApplyAt(Vector3 p)
	{
		//IL_0020: Expected VT, but got Ref
		GillaBackpack.Air air = At(p);
		object obj = default;
		Apply((GillaBackpack.Air)(&obj), 1f);
	}

	private unsafe void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_0083: Expected VT, but got I4
		//IL_0099: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component = ((!(main != null)) ? ((Behaviour)this) : ((Behaviour)main));
		Transform transform = component.transform;
		Vector3 position = transform.position;
		GillaBackpack.Air air = At((Vector3)0);
		object obj4 = default;
		Apply((GillaBackpack.Air)(&obj4), 1f);
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected VT, but got I4
		//IL_00f5: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Transform transform = main.transform;
			Vector3 position = transform.position;
			GillaBackpack.Air air = At((Vector3)0);
			float deltaTime = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float num = deltaTime * -3f;
			float num2 = num / ease;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			float k = 1f - num2;
			object obj5 = default;
			Apply((GillaBackpack.Air)(&obj5), k);
		}
	}

	private static void Apply(GillaBackpack.Air a, float k)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_05b4: Expected Obj, but got I
		//IL_0194: Invalid comparison between F4 and I4
		//IL_01a3: Invalid comparison between F4 and I4
		//IL_01bb: Expected Obj, but got F8
		//IL_01c8: Expected Obj, but got F4
		//IL_01fd: Expected Obj, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_022a: Invalid comparison between F4 and I4
		//IL_004d: Invalid comparison between Obj and F8
		//IL_024b: Expected VT, but got I4
		//IL_026c: Expected F8, but got I4
		//IL_0297: Invalid comparison between F4 and I4
		//IL_02a6: Invalid comparison between F4 and I4
		//IL_02be: Expected Obj, but got F8
		//IL_02cb: Expected Obj, but got F4
		//IL_033f: Expected Obj, but got I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0076: Invalid comparison between Obj and F8
		//IL_0087: Expected F8, but got Obj
		//IL_036c: Invalid comparison between F4 and I4
		//IL_03df: Invalid comparison between F4 and I4
		//IL_03ee: Invalid comparison between F4 and I4
		//IL_0406: Expected Obj, but got F8
		//IL_0413: Expected Obj, but got F4
		//IL_0448: Expected Obj, but got I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_0475: Invalid comparison between F4 and I4
		//IL_00cf: Expected F8, but got I4
		//IL_0496: Expected VT, but got I4
		//IL_04bc: Invalid comparison between F4 and I4
		//IL_04cb: Invalid comparison between F4 and I4
		//IL_04e3: Expected Obj, but got F8
		//IL_04f0: Expected Obj, but got F4
		//IL_0525: Expected Obj, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0552: Invalid comparison between F4 and I4
		//IL_0573: Expected VT, but got I4
		//IL_0585: Invalid comparison between F4 and I4
		//IL_05a3: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50A8]");
		object obj = 0;
		do
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+A0]");
			object obj6 = 0;
			Color fogColor = RenderSettings.fogColor;
			if ((nint)obj6 < 0 || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
			{
				float num = k - 1f;
				bool flag3 = num < 0f;
				bool flag4 = num == 0f;
				object obj7 = (double)k ^ 1.0;
				object obj8 = k ^ num;
				object obj9 = obj7 & obj8;
				bool flag5 = (nint)obj9 < 0;
				bool flag6 = flag3 == flag5;
				object obj10 = !flag6;
				object obj11 = obj10 | flag4;
				object obj12 = ~obj11;
				if (obj12 != null)
				{
				}
			}
			if (k < 0f)
			{
			}
			RenderSettings.fogColor = (Color)0;
			float fogDensity = RenderSettings.fogDensity;
			bool flag7 = (nint)obj6 < 0;
			double num2 = 0.0;
			if (!flag7)
			{
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0);
				num2 = (double)obj6;
				if (!flag8)
				{
					num2 = 1.0;
				}
			}
			float num3 = k - 1f;
			bool flag9 = num3 < 0f;
			bool flag10 = num3 == 0f;
			object obj13 = (double)k ^ 1.0;
			object obj14 = k ^ num3;
			object obj15 = obj13 & obj14;
			bool flag11 = (nint)obj15 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			float num4 = 0f - a.density;
			double num5 = (double)num4 * num2;
			double num6 = (double)a.density + num5;
			bool flag12 = flag9 == flag11;
			object obj16 = !flag12;
			object obj17 = obj16 | flag10;
			object obj18 = ~obj17;
			double num7 = ((obj18 != null) ? 1.0 : ((double)k));
			if (k < 0f)
			{
				num7 = 0.0;
			}
			double num8 = num6 - (double)fogDensity;
			double num9 = num8 * num7;
			float fogDensity2 = fogDensity + (float)num9;
			RenderSettings.fogDensity = fogDensity2;
			Color ambientSkyColor = RenderSettings.ambientSkyColor;
			float num10 = k - 1f;
			bool flag13 = num10 < 0f;
			bool flag14 = num10 == 0f;
			object obj19 = (double)k ^ 1.0;
			object obj20 = k ^ num10;
			object obj21 = obj19 & obj20;
			bool flag15 = (nint)obj21 < 0;
			bool flag16 = flag13 == flag15;
			object obj22 = !flag16;
			object obj23 = obj22 | flag14;
			object obj24 = ~obj23;
			if (obj24 == null)
			{
			}
			if (k < 0f)
			{
			}
			RenderSettings.ambientSkyColor = (Color)0;
			Color ambientEquatorColor = RenderSettings.ambientEquatorColor;
			float num11 = k - 1f;
			bool flag17 = num11 < 0f;
			bool flag18 = num11 == 0f;
			object obj25 = (double)k ^ 1.0;
			object obj26 = k ^ num11;
			object obj27 = obj25 & obj26;
			bool flag19 = (nint)obj27 < 0;
			bool flag20 = flag17 == flag19;
			object obj28 = !flag20;
			object obj29 = obj28 | flag18;
			object obj30 = ~obj29;
			if (obj30 == null)
			{
			}
			if (k < 0f)
			{
			}
			RenderSettings.ambientEquatorColor = (Color)0;
			Color ambientGroundColor = RenderSettings.ambientGroundColor;
		}
		while (!(k < 0f) && (double)k > 1.0);
		RenderSettings.ambientGroundColor = (Color)0;
	}

	public GillaAtmosphere()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 136;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ease = 0.8f;
		base._002Ector();
	}
}
