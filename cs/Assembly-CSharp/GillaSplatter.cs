using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaSplatter : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass34_0
	{
		public GillaSplashGame game;
	}

	private const int MostSplats = default(int);

	private const float Stays = default(float);

	private const float Thins = default(float);

	internal const int Solid = default(int);

	public const int Tiles = default(int);

	private static GillaSplatter here;

	private static GillaGoreAssets gore;

	private Mesh mesh;

	private Vector3[] verts;

	private Vector3[] normals;

	private Vector2[] uvs;

	private Color32[] colours;

	private readonly float[] born;

	private readonly byte[] lit;

	private readonly Collider[] onCol;

	private readonly bool[] rides;

	private readonly Vector3[] onLocal;

	private readonly Vector3[] onFaces;

	private readonly Vector3[] onAt;

	private readonly Quaternion[] onTurn;

	private int next;

	private int showing;

	private float nextFade;

	private readonly Vector3[] dirs;

	private readonly Color[] heard;

	public static bool OnBodies;

	private const float RaysLately = default(float);

	private const float RaysFor = default(float);

	private static float rayed;

	private static float rayedAt;

	private static GillaGoreAssets Gore
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0153: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I4
			//IL_01f5: Expected Obj, but got I
			//IL_0217: Expected Obj, but got I4
			//IL_004d: Expected Obj, but got I
			//IL_00cd: Expected Obj, but got I
			//IL_00dd: Expected Obj, but got I
			//IL_0111: Expected Obj, but got I4
			//IL_01be: Expected Obj, but got I
			//IL_0098: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I
			//IL_01a3: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v1+8]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v18+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v12+8]");
				return (GillaGoreAssets)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+A0]");
			object obj15 = (nint)0 + (nint)8;
			GillaGoreAssets gillaGoreAssets = default;
			obj15 = gillaGoreAssets;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return gillaGoreAssets;
		}
	}

	public static void Around(Vector3 at, float strength, Dismemberment not = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I
		//IL_0289: Expected VT, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gillaGoreAssets = Gore;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = gillaGoreAssets == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gillaGoreAssets2 = Gore;
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = gillaGoreAssets2.splat == null;
		bool flag9 = !flag8;
		object obj15 = !flag9;
		if (obj15 != null)
		{
			return;
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v22+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Here();
		object obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v11+A0]");
		object obj19 = 0;
		((GillaSplatter)obj19).Ground((Vector3)0, strength);
		object obj20 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v24+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v13+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v24+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Bodies(at, strength, null);
		}
	}

	public unsafe static void Stain(int playerId, Vector3 worldPoint, float radius, GillaStains.Stuff stuff)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0d0f: Expected I, but got Obj
		//IL_0d31: Expected Obj, but got I4
		//IL_0d47: Expected I, but got Obj
		//IL_0d57: Expected Obj, but got I
		//IL_0d79: Expected Obj, but got I4
		//IL_0f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f42: Expected Obj, but got Unknown
		//IL_0f64: Expected Obj, but got I4
		//IL_003b: Expected I, but got Obj
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_015d: Expected VT, but got I4
		//IL_0882: Expected I, but got Obj
		//IL_08a4: Expected Obj, but got I4
		//IL_0e2b: Expected Obj, but got I
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_08cc: Expected I, but got Obj
		//IL_08e3: Expected Obj, but got I
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I4
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected Obj, but got I4
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got I4
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_0ebd: Expected Obj, but got I
		//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected Ref, but got Unknown
		//IL_0ee8: Expected Obj, but got I4
		//IL_092f: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got I4
		//IL_0bb7: Expected Obj, but got I4
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected Obj, but got Unknown
		//IL_09aa: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Expected Obj, but got I4
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected Obj, but got I4
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got I
		//IL_0a63: Expected Obj, but got I
		//IL_0a85: Expected Obj, but got I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected Obj, but got I
		//IL_0b20: Expected Obj, but got I4
		//IL_0b53: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0408: Expected I, but got Obj
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got I4
		//IL_0476: Invalid comparison between VT and I4
		//IL_0487: Expected Obj, but got I4
		//IL_049d: Expected I, but got Obj
		//IL_04bf: Expected Obj, but got I4
		//IL_0df6: Expected Obj, but got I
		//IL_04e7: Expected I, but got Obj
		//IL_04fc: Expected Obj, but got I
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got VT
		//IL_0554: Expected Obj, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got VT
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got VT
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got I4
		//IL_065d: Expected Obj, but got I
		//IL_068e: Expected Obj, but got I
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got I
		//IL_07cf: Expected I, but got Obj
		//IL_07f1: Expected Obj, but got I4
		//IL_0820: Expected VT, but got I4
		//IL_082c: Expected I, but got Obj
		//IL_084e: Expected Obj, but got I4
		//IL_0875: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num2 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v5 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		nint num3 = num2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v6 (Il2CppClass<UnityEngine.Object>)+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj6 = (UnityEngine.Object)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num4;
		UnityEngine.Object obj13 = default;
		Enumerator<, > val2;
		UnityEngine.Object obj12;
		UnityEngine.Object obj11;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v110+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			PlayerRef playerRef = default;
			num4 = playerRef.PlayerId;
			obj11 = null;
		}
		else
		{
			bool flag5 = (object)obj6 == null;
			obj12 = obj13;
			val2 = (Enumerator<, >)0;
			PlayerRef playerRef = (PlayerRef)0;
			GillaStains.Stuff stuff2 = (GillaStains.Stuff)0;
			obj11 = null;
			int num5 = playerId;
			if (flag5)
			{
				goto IL_0c23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X21_v4 (UnityEngine.Object)+6CC]");
			num4 = 0;
			playerRef = (PlayerRef)0;
			obj11 = null;
		}
		float num14;
		object obj51;
		object obj50 = default;
		Enumerator<, > val3 = default;
		float num7 = default;
		if (num4 == playerId)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v43+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v47+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj14;
			}
			object obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v47+A0]");
			val = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X9_v2 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8]");
			int num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v32+E4]");
			bool flag8 = (nint)0 == 0;
			object obj20 = !flag8;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)num5 != null))
			{
				return;
			}
			bool flag9 = num5 == 0;
			obj12 = obj13;
			val2 = (Enumerator<, >)0;
			GillaStains.Stuff stuff2 = (GillaStains.Stuff)0;
			obj11 = null;
			obj6 = (UnityEngine.Object)109891584;
			if (!flag9)
			{
				object obj21 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
				obj6 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v51+E4]");
				bool flag10 = (nint)0 == 0;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(obj6 != null))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
				bool flag11 = (nint)0 == 0;
				obj12 = obj13;
				val2 = (Enumerator<, >)0;
				stuff2 = (GillaStains.Stuff)0;
				obj11 = null;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v34+20]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v34+20]");
					if ((nint)0 == 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v35+18]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v35+18]");
					if ((nint)0 == 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v35+18]");
					bool flag12 = (nint)0 == 0;
					obj12 = obj13;
					val2 = (Enumerator<, >)0;
					stuff2 = (GillaStains.Stuff)0;
					obj11 = null;
					if (flag12)
					{
						goto IL_0c4b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
					UnityEngine.Object obj25 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v35+20]");
					obj6 = (UnityEngine.Object)0;
					nint num6 = (nint)obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v55 (Il2CppClass<UnityEngine.Object>)+E4]");
					val = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v55 (Il2CppClass<UnityEngine.Object>)+E4]");
					bool flag13 = (nint)0 == 0;
					object obj26 = !flag13;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Stain((Dismemberment)obj6, worldPoint, num7, (GillaStains.Stuff)0);
					bool flag14 = worldPoint == (Vector3)(object)0;
					object obj27 = !flag14;
					if (obj27 != null)
					{
						return;
					}
					nint num8 = (nint)obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v58 (Il2CppClass<UnityEngine.Object>)+E4]");
					bool flag15 = (nint)0 == 0;
					object obj28 = !flag15;
					nint num9 = num8;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num9 = (nint)obj25;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v59 (Il2CppClass<UnityEngine.Object>)+A0]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v37+10]");
					if ((nint)0 == 0)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
					bool flag16 = (nint)0 == 0;
					obj12 = obj13;
					val2 = (Enumerator<, >)0;
					stuff2 = (GillaStains.Stuff)0;
					obj11 = (UnityEngine.Object)worldPoint;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v39+20]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v39+20]");
						bool flag17 = (nint)0 == 0;
						obj12 = obj13;
						val2 = (Enumerator<, >)0;
						stuff2 = (GillaStains.Stuff)0;
						obj11 = (UnityEngine.Object)worldPoint;
						if (!flag17)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v40+18]");
							val = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v40+18]");
							bool flag18 = (nint)0 == 0;
							obj12 = obj13;
							val2 = (Enumerator<, >)0;
							stuff2 = (GillaStains.Stuff)0;
							obj11 = (UnityEngine.Object)worldPoint;
							if (flag18)
							{
								goto IL_0c4b;
							}
							object obj32 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v60+E4]");
							val = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v60+E4]");
							bool flag19 = (nint)0 == 0;
							object obj33 = !flag19;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v40+20]");
							if (!((UnityEngine.Object)0 != null))
							{
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X20_v2 (System.Int32)+68]");
							bool flag20 = (nint)0 == 0;
							obj12 = obj13;
							val2 = (Enumerator<, >)0;
							stuff2 = (GillaStains.Stuff)0;
							obj11 = null;
							if (!flag20)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v41+20]");
								object obj35 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v41+20]");
								bool flag21 = (nint)0 == 0;
								obj12 = obj13;
								val2 = (Enumerator<, >)0;
								stuff2 = (GillaStains.Stuff)0;
								obj11 = null;
								if (!flag21)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v42+18]");
									bool flag22 = (nint)0 == 0;
									obj12 = obj13;
									val2 = (Enumerator<, >)0;
									stuff2 = (GillaStains.Stuff)0;
									obj11 = null;
									if (flag22)
									{
										goto IL_0c4b;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v42+20]");
									bool flag23 = (nint)0 == 0;
									obj12 = obj13;
									val2 = (Enumerator<, >)0;
									stuff2 = (GillaStains.Stuff)0;
									obj11 = null;
									if (!flag23)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v42+20]");
										Transform body = ((Component)0).transform;
										nint num10 = (nint)obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v43 (Il2CppClass<UnityEngine.Object>)+E4]");
										bool flag24 = (nint)0 == 0;
										object obj36 = !flag24;
										if (obj36 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Vector4 vector = Landed(body, (Vector3)0, num7);
										nint num11 = (nint)obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v69 (Il2CppClass<UnityEngine.Object>)+E4]");
										bool flag25 = (nint)0 == 0;
										object obj37 = !flag25;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										NetworkApe.SplashedYou((Vector4)0);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		else
		{
			nint num12 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v13 (Il2CppClass<UnityEngine.Object>)+E4]");
			bool flag26 = (nint)0 == 0;
			object obj38 = !flag26;
			nint num13 = num12;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num13 = (nint)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v14 (Il2CppClass<UnityEngine.Object>)+A0]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v14+8]");
			bool flag27 = (nint)0 == 0;
			obj12 = obj13;
			val2 = (Enumerator<, >)0;
			GillaStains.Stuff stuff2 = (GillaStains.Stuff)0;
			int num5 = playerId;
			if (!flag27)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v14+8]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
				object obj40 = 0;
				stuff2 = (GillaStains.Stuff)0;
				float num15 = default;
				while (true)
				{
					bool flag28 = val2.MoveNext();
					bool flag29 = !flag28;
					num14 = num15;
					num5 = playerId;
					if (!flag29)
					{
						object obj41 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v21+E4]");
						bool flag30 = (nint)0 == 0;
						object obj42 = !flag30;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag31 = obj13 != null;
						bool flag32 = !flag31;
						stuff2 = (GillaStains.Stuff)0;
						if (flag32)
						{
							continue;
						}
						object obj43 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v25+E4]");
						bool flag33 = (nint)0 == 0;
						object obj44 = !flag33;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag34 = obj13 != obj6;
						bool flag35 = !flag34;
						stuff2 = (GillaStains.Stuff)0;
						if (flag35)
						{
							continue;
						}
						if ((object)obj13 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-88 (UnityEngine.Object)+6CC]");
						bool flag36 = (nint)0 != playerId;
						stuff2 = (GillaStains.Stuff)0;
						if (flag36)
						{
							continue;
						}
						object obj45 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-88 (UnityEngine.Object)+A8]");
						UnityEngine.Object obj25 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v30+E4]");
						bool flag37 = (nint)0 == 0;
						object obj46 = !flag37;
						if (obj46 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag38 = obj25 != null;
						bool flag39 = !flag38;
						stuff2 = (GillaStains.Stuff)0;
						if (flag39)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ stack_-88 (UnityEngine.Object)+A8]");
						num5 = 0;
						object obj48 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v34+E4]");
						bool flag40 = (nint)0 == 0;
						object obj49 = !flag40;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Stain((Dismemberment)num5, worldPoint, num7, (GillaStains.Stuff)0);
						num14 = num7;
						stuff2 = (GillaStains.Stuff)0;
					}
					obj12 = null;
					val2 = (Enumerator<, >)num15;
					obj50 = 0;
					val3 = (Enumerator<, >)(ref val2);
					val = (Enumerator<, >)(ref val2);
					obj51 = 0;
					goto IL_0ead;
				}
				NullReferenceException ex = new NullReferenceException();
				obj12 = null;
				val2 = (Enumerator<, >)num15;
				obj50 = 0;
				val3 = (Enumerator<, >)(ref val2);
				num7 = num15;
				val = (Enumerator<, >)(ref val2);
				stuff2 = (GillaStains.Stuff)0;
				obj11 = obj6;
			}
		}
		goto IL_0c23;
		IL_0c23:
		throw new NullReferenceException();
		IL_0c4b:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = (UnityEngine.Object)1;
			num14 = num7;
			obj51 = obj50;
		}
		else
		{
			if ((nint)obj11 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj52 = default;
			obj51 = obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj50 = obj52;
			num14 = num7;
		}
		goto IL_0ead;
		IL_0ead:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj53 = 0;
		obj11 = (UnityEngine.Object)obj53;
		((Enumerator<, >*)val3)->Dispose();
		bool flag41 = obj51 == null;
		object obj54 = !flag41;
		num7 = num14;
		if (obj54 == null)
		{
			bool flag42 = (object)obj12 == null;
			object obj55 = !flag42;
			num7 = num14;
			OutOfMemoryException ex3 = (OutOfMemoryException)val3;
			if (obj55 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0c4b;
	}

	public static void Stain(Dismemberment copy, Vector3 worldPoint, float radius, GillaStains.Stuff stuff)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0433: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_02df: Invalid comparison between VT and I4
		//IL_02f0: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I
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
		bool flag2 = copy == null;
		object obj4 = default;
		bool flag3 = (nint)obj4 < 0;
		object obj5 = !flag3;
		bool flag4 = obj4 == null;
		object obj6 = ~obj5;
		object obj7 = obj6 | flag4;
		if (obj7 != null)
		{
			return;
		}
		bool flag5 = !flag2;
		object obj8 = !flag5;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gillaGoreAssets = Gore;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = gillaGoreAssets == null;
		bool flag10 = !flag9;
		object obj17 = !flag10;
		if (obj17 != null)
		{
			return;
		}
		object obj18 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		object obj19 = !flag11;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gillaGoreAssets2 = Gore;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaGoreAssets2.splat == null)
		{
			return;
		}
		object obj22 = obj12;
		bool flag13 = worldPoint == (Vector3)(object)0;
		object obj23 = !flag13;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v27+E4]");
			bool flag14 = (nint)0 == 0;
			object obj24 = !flag14;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v27+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v19+10]");
			if ((nint)0 == 0)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v27+E4]");
		bool flag15 = (nint)0 == 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Here();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v28+E4]");
		bool flag16 = (nint)0 == 0;
		object obj29 = !flag16;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBloodied gillaBloodied = GillaBloodied.On(copy);
		gillaBloodied.Hit(worldPoint, radius, (GillaStains.Stuff)0);
	}

	public static void Stump(Dismemberment copy, Vector3 at, float radius)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_003a: Expected VT, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_0435: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02a8: Expected I4, but got I8
		//IL_02c2: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_0336: Expected VT, but got I4
		//IL_034a: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I4
		//IL_039b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IntPtr intPtr = default;
		Stain(copy, (Vector3)0, radius, (GillaStains.Stuff)(nint)intPtr);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v8+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+10]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v9+A0]");
		object obj12 = 0;
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X9_v2+8]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(copy != null))
		{
			return;
		}
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X9_v2+8]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		object obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v20+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v6 (UnityEngine.Object)+68]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X20_v6 (UnityEngine.Object)+68]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v16+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FD8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v16+20]");
		int num = Array.IndexOf((System.__Canon[])0, (System.__Canon)(object)copy);
		int num2 = (int)(num & 0x80000000L);
		bool flag7 = num2 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Transform body = copy.transform;
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v19+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector4 vector = Landed(body, (Vector3)0, radius);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v31+E4]");
			bool flag9 = (nint)0 == 0;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe.SplashedYou((Vector4)0);
		}
	}

	public static Vector4 Thrown(Transform body, Vector3 from, float strength)
	{
		//IL_004c: Expected VT, but got Obj
		//IL_002b: Expected VT, but got I4
		if ((object)body != null)
		{
			Vector4 result = body.InverseTransformPoint((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector4)ex;
	}

	public static Vector4 Landed(Transform body, Vector3 at, float radius)
	{
		//IL_004c: Expected VT, but got Obj
		//IL_002b: Expected VT, but got I4
		if ((object)body != null)
		{
			Vector4 result = body.InverseTransformPoint((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector4)ex;
	}

	public static void ThrowAgain(Dismemberment copy, Vector4 v)
	{
		//IL_0010: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_049b: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_02f0: Expected VT, but got I4
		//IL_031e: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I4
		//IL_0452: Expected VT, but got I4
		//IL_03e9: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = copy == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v8+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+10]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gillaGoreAssets = Gore;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = gillaGoreAssets == null;
		bool flag9 = !flag8;
		object obj16 = !flag9;
		if (obj16 != null)
		{
			return;
		}
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v20+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaGoreAssets gillaGoreAssets2 = Gore;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v15+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaGoreAssets2.splat == null)
		{
			return;
		}
		Transform transform = copy.transform;
		Vector3 vector = transform.TransformPoint((Vector3)0);
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v31+E4]");
		bool flag12 = (nint)0 == 0;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Here();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = default;
		float num = default;
		if ((nint)obj25 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v32+E4]");
			bool flag13 = (nint)0 == 0;
			object obj26 = !flag13;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaBloodied gillaBloodied = GillaBloodied.On(copy);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			float strength = default;
			gillaBloodied.Splash((Vector3)0, num, strength);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v32+E4]");
			bool flag14 = (nint)0 == 0;
			object obj27 = !flag14;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaBloodied gillaBloodied2 = GillaBloodied.On(copy);
			gillaBloodied2.Hit((Vector3)0, num, (GillaStains.Stuff)0);
		}
	}

	public static void CarryOver(Renderer from, Renderer to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaBloodied.CarryOver(from, to);
	}

	internal static void Here()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8598]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			GameObject gameObject = default;
			gameObject._002Ector((string)obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8590]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v10+A0]");
			object obj13 = 0;
			object obj14 = default;
			obj13 = obj14;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I4
		//IL_05b2: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0275: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_05d0: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_044a: Expected VT, but got Ref
		//IL_04ba: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 48;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X21_v5-8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 56;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X22_v3-10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 64;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8598]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj20 = 0;
		int[] array = default;
		object obj21 = array + 52;
		object obj22 = 0;
		object obj23 = 0;
		Mesh mesh = default;
		object obj43 = default;
		object obj46 = default;
		MeshFilter meshFilter = default;
		Renderer renderer = default;
		while (true)
		{
			bool flag = (nint)obj22 < array.Length;
			object obj24 = !flag;
			if (obj24 != null)
			{
				break;
			}
			object obj25 = obj22 + 1;
			bool flag2 = (nint)obj25 < array.Length;
			object obj26 = !flag2;
			if (obj26 != null)
			{
				break;
			}
			object obj27 = obj22 + 2;
			object obj28 = obj23 + 1;
			bool flag3 = (nint)obj27 < array.Length;
			object obj29 = !flag3;
			if (obj29 != null)
			{
				break;
			}
			object obj30 = obj22 + 3;
			object obj31 = obj23 + 2;
			bool flag4 = (nint)obj30 < array.Length;
			object obj32 = !flag4;
			if (obj32 != null)
			{
				break;
			}
			object obj33 = obj22 + 4;
			bool flag5 = (nint)obj33 < array.Length;
			object obj34 = !flag5;
			if (obj34 != null)
			{
				break;
			}
			object obj35 = obj22 + 5;
			bool flag6 = (nint)obj35 < array.Length;
			object obj36 = !flag6;
			if (obj36 != null)
			{
				break;
			}
			obj22 += 6;
			object obj37 = obj23 + 3;
			obj23 += 4;
			obj21 = obj37;
			obj21 += 24;
			if ((nint)obj22 == 576)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				mesh._002Ector();
				mesh.name = (string)obj17;
				object obj38 = this + 32;
				obj38 = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				((Mesh)obj38).MarkDynamic();
				((Mesh)obj38).vertices = (Vector3[])obj2;
				((Mesh)obj38).normals = (Vector3[])obj5;
				((Mesh)obj38).uv = (Vector2[])obj9;
				((Mesh)obj38).colors32 = (Color32[])obj14;
				((Mesh)obj38).triangles = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj39 = 0;
				object obj40 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v15+A0]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v16+C]");
				object obj42 = 0 * obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v16+14]");
				object obj44 = (nint)0 * (nint)1157234688;
				object obj45 = obj42 * 63;
				double num = (double)obj44 * 0.5;
				((Mesh)obj38).bounds = (Bounds)(&obj46);
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				meshFilter.sharedMesh = this.mesh;
				GameObject gameObject2 = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				object obj47 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v17+E4]");
				bool flag7 = (nint)0 == 0;
				object obj48 = !flag7;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaGoreAssets gillaGoreAssets = Gore;
				renderer.sharedMaterial = gillaGoreAssets.splat;
				renderer.shadowCastingMode = (ShadowCastingMode)0;
				renderer.receiveShadows = false;
				renderer.lightProbeUsage = (LightProbeUsage)0;
				renderer.reflectionProbeUsage = (ReflectionProbeUsage)0;
				renderer.allowOcclusionWhenDynamic = false;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj4 = 0;
		bool flag2 = mesh != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(mesh);
			obj5 = null;
		}
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj4;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj11 == this)
		{
			object obj13 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v13+A0]");
			object obj15 = 0;
			obj15 = 0;
			object obj16 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03f1: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0255: Invalid comparison between F8 and I4
		//IL_0264: Expected F8, but got I4
		//IL_04b4: Invalid comparison between F8 and I4
		//IL_04c5: Expected Obj, but got I4
		//IL_04ce: Invalid comparison between F8 and I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		//IL_0345: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_039d: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaStains.Pump();
		if (showing == 0)
		{
			return;
		}
		bool flag2 = Follow(all: false);
		float time = Time.time;
		if (time < nextFade)
		{
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			float time2 = Time.time;
			float num = time2 + 0.25f;
			nextFade = num;
			bool flag3 = Follow(all: true);
			object obj4 = flag2 | flag3;
			showing = 0;
			object obj5 = 0;
			double num2 = 0.25;
			object obj6 = 35;
			int num3 = 0;
			do
			{
				float[] array = born;
				bool flag4 = num3 < array.Length;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					object obj8 = array + num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v10+20]");
					bool flag5 = (nint)0 < (nint)0;
					object obj9 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v10+20]");
					bool flag6 = (nint)0 == 0;
					object obj10 = ~obj9;
					object obj11 = obj10 | flag6;
					if (obj11 != null)
					{
						goto IL_044d;
					}
					float time3 = Time.time;
					float[] array2 = born;
					bool flag7 = num3 < array2.Length;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						object obj13 = array2 + num3;
						float num4 = time3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v13+20]");
						float num5 = num4 - 0f;
						float num6 = num5 + 3.2608092E+09f;
						num2 = (double)num6 / 6.0;
						bool flag8 = num2 < 0.0;
						double num7 = 0.0;
						if (!flag8)
						{
							bool flag9 = !(num2 > 1.0);
							num7 = num2;
							if (!flag9)
							{
								num7 = 1.0;
							}
						}
						double num8 = 1.0 - num7;
						bool flag10 = num8 < 0.0;
						object obj14 = !flag10;
						bool flag11 = num8 == 0.0;
						object obj15 = ~obj14;
						object obj16 = obj15 | flag11;
						if (obj16 != null)
						{
							Drop(num3);
							goto IL_03bb;
						}
						int num9 = showing + 1;
						showing = num9;
						bool flag12 = !(num8 < 1.0);
						flag3 = false;
						if (flag12)
						{
							goto IL_044d;
						}
						double num10 = num8 * 1132396544.0;
						object obj17 = obj6;
						object obj18 = 0;
						while (true)
						{
							Color32[] array3 = colours;
							object obj19 = obj5 + obj18;
							bool flag13 = (nint)obj19 < array3.Length;
							object obj20 = !flag13;
							if (obj20 != null)
							{
								break;
							}
							obj18++;
							obj17 += 4;
							if ((nint)obj18 != 4)
							{
								continue;
							}
							goto IL_0394;
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
				IL_0394:
				num2 = 1132396544.0;
				flag3 = false;
				goto IL_03bb;
				IL_044d:
				num3++;
				obj5 += 4;
				obj6 += 16;
				continue;
				IL_03bb:
				obj4 = 1;
				goto IL_044d;
			}
			while (num3 != 96);
			object obj21 = obj4 & 1;
			bool flag14 = obj21 == null;
			object obj22 = !flag14;
			if (obj22 == null)
			{
				return;
			}
		}
		Push();
	}

	private bool Follow(bool all)
	{
		//IL_0a8e: Expected Obj, but got I
		//IL_0a97: Expected Obj, but got I4
		//IL_0aa0: Expected Obj, but got I4
		//IL_0aa9: Expected Obj, but got I4
		//IL_0a7e: Expected I4, but got Obj
		//IL_0020: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got Unknown
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected Obj, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected I4, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		//IL_0a3d: Expected Obj, but got I4
		//IL_0a42: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0356: Expected I, but got Obj
		//IL_03fa: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I
		//IL_0739: Expected Obj, but got I4
		//IL_0535: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_057d: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got I
		//IL_05c7: Expected Obj, but got I
		//IL_05f1: Expected Obj, but got I
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_064f: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I
		//IL_0687: Expected Obj, but got I4
		//IL_0697: Expected Obj, but got I
		//IL_06ac: Expected I, but got Obj
		//IL_07c6: Expected Obj, but got I4
		//IL_07e2: Expected Obj, but got I4
		//IL_07ff: Expected VT, but got I4
		//IL_0814: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got I4
		//IL_0876: Expected VT, but got I4
		//IL_08b4: Expected Obj, but got I4
		//IL_0949: Expected Obj, but got I4
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		//IL_09df: Expected Obj, but got I4
		//IL_0a14: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = 0;
		object obj3 = 0;
		object obj4 = 0;
		bool flag = all;
		int num = 0;
		object obj35 = default;
		object obj37 = default;
		object obj39 = default;
		object obj47 = default;
		while (true)
		{
			float[] array = born;
			Transform transform;
			object obj27;
			object obj31;
			object obj32;
			object obj34;
			object obj36;
			object obj38;
			object obj51;
			object obj52;
			object obj53;
			nint num2;
			UnityEngine.Object obj12;
			if (born != null)
			{
				bool flag2 = num < array.Length;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				object obj6 = born + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v8+20]");
				bool flag3 = (nint)0 < (nint)0;
				object obj7 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v8+20]");
				bool flag4 = (nint)0 == 0;
				object obj8 = ~obj7;
				object obj9 = obj8 | flag4;
				if (obj9 != null)
				{
					goto IL_0abf;
				}
				Collider[] array2 = onCol;
				if (onCol != null)
				{
					bool flag5 = num < array2.Length;
					object obj10 = !flag5;
					if (obj10 != null)
					{
						break;
					}
					object obj11 = onCol + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v11+20]");
					obj12 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v11+20]");
					if ((nint)0 == 0)
					{
						goto IL_0abf;
					}
					bool flag6 = !all;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						bool[] array3 = rides;
						if (rides == null)
						{
							goto IL_0a62;
						}
						bool flag7 = num < array3.Length;
						object obj14 = !flag7;
						if (obj14 != null)
						{
							break;
						}
						object obj15 = rides + num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v35+20]");
						if ((nint)0 == 0)
						{
							goto IL_0abf;
						}
					}
					object obj16 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X0_v9+E4]");
					bool flag8 = (nint)0 == 0;
					object obj17 = !flag8;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = obj12 == null;
					bool flag10 = !flag9;
					object obj18 = !flag10;
					if (obj18 != null || !((Collider)obj12).enabled)
					{
						goto IL_0a2a;
					}
					GameObject gameObject = ((Component)obj12).gameObject;
					if ((object)gameObject != null)
					{
						if (!gameObject.activeInHierarchy)
						{
							goto IL_0a2a;
						}
						bool[] array4 = rides;
						if (rides != null)
						{
							bool flag11 = num < array4.Length;
							object obj19 = !flag11;
							if (obj19 != null)
							{
								break;
							}
							object obj20 = rides + num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v15+20]");
							bool flag12 = (nint)0 == 0;
							num2 = unchecked((nint)null);
							flag = false;
							if (flag12)
							{
								goto IL_0abf;
							}
							transform = ((Component)obj12).transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								Quaternion rotation = transform.rotation;
								Vector3[] array5 = onAt;
								if (onAt != null)
								{
									bool flag13 = num < array5.Length;
									object obj21 = !flag13;
									if (obj21 != null)
									{
										break;
									}
									object obj22 = num * 12;
									object obj23 = (object)onAt + obj22;
									object obj24 = obj23 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+24]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v19+4]");
									object obj25 = num3 - 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v8+20]");
									object obj26 = 0 - obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+28]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v19+8]");
									obj27 = num4 - 0;
									object obj28 = obj26 * obj26;
									object obj29 = obj25 * obj25;
									object obj30 = obj28 + obj29;
									obj31 = obj27 * obj27;
									obj32 = obj31 + obj30;
									object obj33 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									bool flag14 = (nint)obj33 >= 0;
									obj34 = obj35;
									obj36 = obj37;
									obj38 = obj39;
									if (!flag14)
									{
										Quaternion[] array6 = onTurn;
										if (onTurn == null)
										{
											goto IL_0a62;
										}
										obj38 = array6.Length;
										bool flag15 = num < array6.Length;
										object obj40 = !flag15;
										if (obj40 != null)
										{
											break;
										}
										object obj41 = onTurn + num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+28]");
										obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+2C]");
										obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v8+20]");
										nint num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+20]");
										object obj42 = num5 * 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+24]");
										nint num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+24]");
										object obj43 = num6 * 0;
										object obj44 = obj42 + obj43;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+28]");
										nint num7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+28]");
										object obj45 = num7 * 0;
										object obj46 = obj45 + obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+2C]");
										obj31 = obj47 * 0;
										obj32 = obj31 + obj46;
										object obj48 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
										object obj49 = obj48 - 0;
										bool flag16 = obj49 == null;
										obj34 = !flag16;
										object obj50 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
										bool flag17 = (nint)obj50 > 0;
										obj35 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+2C]");
										obj37 = 0;
										obj39 = array6.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X9_v18+28]");
										obj51 = 0;
										obj52 = obj31;
										obj53 = obj32;
										num2 = unchecked((nint)null);
										flag = false;
										obj12 = transform;
										if (flag17)
										{
											goto IL_0abf;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v8+20]");
									obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+24]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+28]");
									_ = 0;
									Quaternion[] array7 = onTurn;
									if (onTurn != null)
									{
										bool flag18 = num < array7.Length;
										object obj54 = !flag18;
										if (obj54 != null)
										{
											break;
										}
										object obj55 = onTurn + num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v8+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+24]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+28]");
										_ = 0;
										Vector3[] array8 = onFaces;
										if (onFaces != null)
										{
											bool flag19 = num < array8.Length;
											object obj56 = !flag19;
											if (obj56 != null)
											{
												break;
											}
											object obj57 = num * 12;
											object obj58 = (object)onFaces + obj57;
											Vector3 vector = transform.TransformDirection((Vector3)0);
											object obj59 = obj3;
											object obj60 = 0;
											while (true)
											{
												Vector3[] array9 = onLocal;
												if (onLocal == null)
												{
													break;
												}
												bool flag20 = (nint)obj59 < array9.Length;
												object obj61 = !flag20;
												if (obj61 != null)
												{
													goto end_IL_0b32;
												}
												object obj62 = (object)onLocal + obj2;
												Vector3[] array10 = verts;
												object obj63 = obj62 + obj60;
												Vector3 vector2 = transform.TransformPoint((Vector3)0);
												if (verts == null)
												{
													break;
												}
												bool flag21 = (nint)obj59 < array10.Length;
												object obj64 = !flag21;
												if (obj64 != null)
												{
													goto end_IL_0b32;
												}
												object obj65 = (object)verts + obj2;
												object obj66 = obj65 + obj60;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+20]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+24]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v27+28]");
												_ = 0;
												Vector3[] array11 = normals;
												if (normals == null)
												{
													break;
												}
												bool flag22 = (nint)obj59 < array11.Length;
												object obj67 = !flag22;
												if (obj67 != null)
												{
													goto end_IL_0b32;
												}
												object obj68 = (object)normals + obj2;
												obj59++;
												object obj69 = obj68 + obj60;
												obj60 += 12;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v23+20]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v23+24]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v23+28]");
												_ = 0;
												if ((nint)obj60 != 48)
												{
													continue;
												}
												goto IL_09d6;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_0a62;
			IL_0a62:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0a2a:
			Drop(num);
			obj4 = 1;
			num2 = unchecked((nint)null);
			flag = (byte)num != 0;
			goto IL_0abf;
			IL_09d6:
			obj4 = 1;
			obj35 = obj34;
			obj37 = obj36;
			obj39 = obj38;
			obj51 = obj27;
			obj52 = obj31;
			obj53 = obj32;
			num2 = unchecked((nint)null);
			flag = false;
			obj12 = transform;
			goto IL_0abf;
			IL_0abf:
			num++;
			obj3 += 4;
			obj2 += 48;
			if (num == 96)
			{
				return (byte)(obj4 & 1) != 0;
			}
			continue;
			end_IL_0b32:
			break;
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void Drop(int i)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I
		float[] array = born;
		if (born != null)
		{
			bool flag = array.Length < i;
			object obj = !flag;
			object obj2 = array.Length - i;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 != null)
			{
				goto IL_02e1;
			}
			object obj5 = born + i;
			Collider[] array2 = onCol;
			_ = 0;
			if (onCol != null)
			{
				bool flag3 = array2.Length < i;
				object obj6 = !flag3;
				object obj7 = array2.Length - i;
				bool flag4 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag4;
				if (obj9 != null)
				{
					goto IL_02e1;
				}
				object obj10 = onCol + i;
				object obj11 = obj10 + 32;
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool[] array3 = rides;
				if (rides != null)
				{
					bool flag5 = array3.Length < i;
					object obj12 = !flag5;
					object obj13 = array3.Length - i;
					bool flag6 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag6;
					if (obj15 != null)
					{
						goto IL_02e1;
					}
					int num = i << 2;
					object obj16 = rides + i;
					_ = 0;
					object obj17 = num * 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj18 = 0;
					object obj19 = 0;
					while (true)
					{
						Vector3[] array4 = verts;
						if (verts == null)
						{
							break;
						}
						object obj20 = num + obj19;
						bool flag7 = (nint)obj20 < array4.Length;
						object obj21 = !flag7;
						if (obj21 == null)
						{
							object obj22 = obj18;
							obj19++;
							object obj23 = (object)verts + obj17;
							obj17 += 12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X9_v10+A0]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v11+8]");
							_ = 0;
							if ((nint)obj19 == 4)
							{
								return;
							}
							continue;
						}
						goto IL_02e1;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02e1;
		IL_02e1:
		throw new IndexOutOfRangeException();
	}

	private static bool Moves(Collider col)
	{
		//IL_024a: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		if ((object)col != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Rigidbody attachedRigidbody = col.attachedRigidbody;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = attachedRigidbody != null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj8 = default;
				bool flag5 = obj8 != null;
				bool flag6 = !flag5;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85B0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object obj13 = default;
					if (!(obj13 != null))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
						object obj15 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v13+E4]");
						bool flag8 = (nint)0 == 0;
						object obj16 = !flag8;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object obj17 = default;
						return obj17 != null;
					}
				}
			}
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Push()
	{
		mesh.vertices = verts;
		mesh.normals = normals;
		mesh.uv = uvs;
		mesh.colors32 = colours;
	}

	private static void FreshRays()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
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
		object obj4 = 0;
		_ = 0;
		_ = 0;
	}

	private static int RaysNow(int want)
	{
		//IL_0010: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02c2: Invalid comparison between F4 and I4
		//IL_0330: Invalid comparison between F4 and I4
		//IL_0341: Expected Obj, but got I4
		//IL_035a: Invalid comparison between F4 and I4
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_0035: Expected F4, but got I4
		//IL_0521: Expected Obj, but got I
		//IL_0536: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_03e4: Invalid comparison between F4 and I4
		//IL_03f3: Expected F8, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected F4, but got I
		//IL_0550: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I4
		//IL_0101: Invalid comparison between F8 and I4
		//IL_0488: Invalid comparison between F4 and I4
		//IL_0497: Invalid comparison between F4 and I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got F4
		//IL_04ed: Expected Obj, but got I4
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_044c: Expected Obj, but got I4
		//IL_021e: Expected I4, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj = 0;
		float unscaledTime = Time.unscaledTime;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		object obj4 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v5+A0]");
		object obj5 = 0;
		float num = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v1+18]");
		float num2 = num - 0f;
		if (num2 < 0f)
		{
			num2 = 0f;
		}
		float num3 = num2 / -1.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v1+14]");
		float num4 = 0f * num3;
		float num5 = num4 + (float)want;
		bool flag2 = num5 < 1.1190927E+09f;
		object obj6 = !flag2;
		float num6 = num5 - 1.1190927E+09f;
		bool flag3 = num6 == 0f;
		object obj7 = ~obj6;
		object obj8 = obj7 | flag3;
		int num7 = want;
		if (obj8 != null)
		{
			goto IL_038c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v20+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v21+14]");
			num4 = 0f;
		}
		float num8 = 1.1190927E+09f - num4;
		float num9 = num8 / (float)want;
		bool flag5 = num9 < 0f;
		double num10 = 0.0;
		if (!flag5)
		{
			bool flag6 = !((double)num9 > 1.0);
			num10 = num9;
			if (!flag6)
			{
				num10 = 1.0;
			}
		}
		double num11 = num10 * (double)want;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj12 = 0;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num12;
		float num13 = default;
		if (num11 < 0.0)
		{
			if (num11 == -0.5)
			{
				num12 = -1.0;
				num4 = num13;
				goto IL_0415;
			}
			double num14 = num11 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num5 = -0.5f;
			num4 = (float)num14;
		}
		else
		{
			if (num11 == 0.5)
			{
				num12 = 1.0;
				num4 = num13;
				goto IL_0415;
			}
			double num15 = num11 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num5 = 0.5f;
			num4 = (float)num15;
		}
		goto IL_0467;
		IL_0467:
		obj2 = obj;
		float num16 = num4 - 3f;
		bool flag8 = num16 < 0f;
		bool flag9 = num16 == 0f;
		object obj15 = num4 ^ 3;
		object obj16 = num4 ^ num16;
		object obj17 = obj15 & obj16;
		bool flag10 = (nint)obj17 < 0;
		bool flag11 = flag8 == flag10;
		object obj18 = !flag9;
		object obj19 = flag11 & obj18;
		object obj20 = ~obj19;
		num7 = ((obj20 != null) ? 3 : ((int)num4));
		goto IL_038c;
		IL_038c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v5+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v5+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7+14]");
		object obj23 = (nint)0 + (nint)num7;
		return num7;
		IL_0415:
		double num17 = (double)num4 + num12;
		object obj24 = num4 & 1;
		bool flag13 = obj24 == null;
		object obj25 = !flag13;
		if (obj25 != null)
		{
			num4 = (float)num17;
		}
		num5 = (float)num17;
		goto IL_0467;
	}

	private unsafe void Ground(Vector3 at, float strength)
	{
		//IL_090e: Expected Obj, but got I
		//IL_0938: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0037: Invalid comparison between F8 and I4
		//IL_0616: Expected Obj, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I4, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05d9: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_0656: Expected Obj, but got I
		//IL_0666: Expected F4, but got I
		//IL_0683: Expected Obj, but got I
		//IL_06fe: Expected Obj, but got I
		//IL_08c1: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_01c9: Expected F4, but got I
		//IL_01da: Expected Obj, but got I4
		//IL_01ea: Expected F4, but got I
		//IL_055b: Expected VT, but got I8
		//IL_055b: Expected VT, but got Ref
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I4
		//IL_08f8: Expected Obj, but got I4
		//IL_08f8: Expected VT, but got I4
		//IL_08f8: Expected F4, but got VT
		//IL_08f8: Expected VT, but got I4
		//IL_08f8: Expected VT, but got Obj
		//IL_0970: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_02c1: Invalid comparison between F4 and I
		//IL_02d3: Expected F4, but got I4
		//IL_02dc: Expected F4, but got I4
		//IL_02e5: Expected F4, but got I4
		//IL_075a: Expected Obj, but got I4
		//IL_0358: Expected VT, but got I8
		//IL_0358: Expected VT, but got Ref
		//IL_0388: Expected VT, but got I8
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_040d: Invalid comparison between F8 and I4
		//IL_041c: Invalid comparison between F8 and I4
		//IL_0434: Expected Obj, but got F8
		//IL_0441: Expected Obj, but got F8
		//IL_0476: Expected Obj, but got I4
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_07f5: Expected Obj, but got I4
		//IL_07f5: Expected VT, but got I4
		//IL_07f5: Expected VT, but got I4
		//IL_07f5: Expected VT, but got Obj
		//IL_0805: Expected VT, but got Obj
		//IL_080e: Expected F4, but got I4
		object obj = default;
		double num = (double)obj * 10.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num2;
		double num3;
		double num4 = default;
		double num5;
		if (num < 0.0)
		{
			if (num == -0.5)
			{
				num2 = -1.0;
				num3 = num4;
				goto IL_05a2;
			}
			num3 = num + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num5 = -0.5;
		}
		else
		{
			if (num == 0.5)
			{
				num2 = 1.0;
				num3 = num4;
				goto IL_05a2;
			}
			num3 = num + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num5 = 0.5;
		}
		goto IL_05ec;
		IL_05ec:
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int want = (int)(num3 + 4);
		int num6 = RaysNow(want);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11+20]");
		float num7 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11+18]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		object obj11 = num8 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11+1C]");
		float num9 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num10 = num9 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11+20]");
		float num11 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		float num12 = num11 * 0f;
		float num13 = strength + (float)obj11;
		object obj12 = default;
		float num14 = (float)obj12 + num10;
		object obj13 = default;
		float num15 = (float)obj13 + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj14 = 0;
		bool flag3 = num6 < 1;
		IntPtr intPtr = default;
		ref RaycastHit reference = ref *(RaycastHit*)intPtr;
		float num16 = num14;
		QueryTriggerInteraction queryTriggerInteraction = default;
		if (!flag3)
		{
			object obj15 = 17281024 + 80;
			double num17 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA50]");
			double num18 = num17 * 0.0;
			int num20 = default;
			int num19 = num20;
			double num22 = default;
			double num21 = num22;
			float num24 = default;
			float num23 = num24;
			Vector3 vector2 = default;
			Vector3 vector = vector2;
			float num26 = default;
			float num25 = num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11+20]");
			float num27 = 0f;
			float num28 = num10;
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			float num29 = 0f;
			float num30 = num15;
			float num31 = num13;
			float num39 = default;
			object obj27 = default;
			RaycastHit raycastHit = default;
			float num49 = default;
			float num50 = default;
			float num51 = default;
			float num52 = default;
			bool flag14;
			do
			{
				Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
				object obj17 = obj16 & 3;
				object obj18 = obj17 - 3;
				bool flag4 = obj18 == null;
				object obj19;
				if ((nint)obj17 == 3)
				{
					obj19 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					obj19 = 0;
				}
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v35+E4]");
				bool flag5 = (nint)0 == 0;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X25_v4+v431 @ Z_v6 (System.Boolean)*4]");
				object obj22 = (nint)0 * (nint)0;
				float num32 = num29 * num29;
				object obj23 = obj22 - obj19;
				object obj24 = obj23 * obj23;
				float num33 = num32 + (float)obj24;
				float num34 = num28 * num28;
				float num35 = num34 + num33;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				bool flag6 = !(num35 > 0f);
				float num36 = 0f;
				float num37 = 0f;
				float num38 = 0f;
				if (!flag6)
				{
					num38 = num29 / num35;
					num37 = (float)obj23 / num35;
					num36 = num28 / num35;
				}
				object obj25 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v37+E4]");
				bool flag7 = (nint)0 == 0;
				object obj26 = !flag7;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = Physics.Raycast((Vector3)(&num39), (Vector3)4294951163L, out *(RaycastHit*)1, num31, 0, queryTriggerInteraction);
				bool flag9 = !flag8;
				num22 = num18;
				num24 = num36;
				vector2 = (Vector3)4294951163L;
				num26 = num37;
				num7 = num38;
				num10 = num30;
				num16 = num14;
				num12 = num31;
				if (!flag9)
				{
					double num40 = (double)obj27 / num18;
					double num41 = 1.0 - num40;
					double num42 = num41 * num41;
					double num43 = num42 - 1.0;
					bool flag10 = num43 < 0.0;
					bool flag11 = num43 == 0.0;
					object obj28 = num42 ^ 1.0;
					object obj29 = num42 ^ num43;
					object obj30 = obj28 & obj29;
					bool flag12 = (nint)obj30 < 0;
					bool flag13 = flag10 == flag12;
					object obj31 = !flag11;
					object obj32 = flag13 & obj31;
					object obj33 = ~obj32;
					if (obj33 == null)
					{
						num42 = 1.0;
					}
					double num44 = num42 * 0.5;
					double num45 = num44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
					double num46 = num45 + 0.0;
					float num47 = UnityEngine.Random.Range(0.75f, 1.25f);
					Collider collider = raycastHit.collider;
					double num48 = num46 * (double)num47;
					num22 = num3 * num48;
					Splat((Vector3)collider, (Vector3)1, num39, (Vector3)0, (Collider)queryTriggerInteraction);
					num24 = num49;
					vector2 = (Vector3)collider;
					num26 = 0f;
					num7 = num50;
					num10 = num51;
					num16 = num52;
					num12 = num39;
					num30 = num15;
					num31 = num13;
				}
				obj16++;
				flag14 = num6 != (nint)obj16;
				reference = ref *(RaycastHit*)1;
				num19 = 0;
				num21 = num22;
				num23 = num24;
				vector = vector2;
				num25 = num26;
				num27 = num7;
				num28 = num10;
				num29 = num12;
			}
			while (flag14);
		}
		object obj34 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj35 = !flag15;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RaycastHit raycastHit2 = default;
		if (Physics.Raycast((Vector3)(&raycastHit2), (Vector3)4294951163L, out *(RaycastHit*)1, num13, 0, queryTriggerInteraction))
		{
			Collider collider2 = raycastHit2.collider;
			Splat((Vector3)collider2, (Vector3)1, (float)raycastHit2, (Vector3)0, (Collider)queryTriggerInteraction);
		}
		Push();
		return;
		IL_05a2:
		num5 = num3 + num2;
		object obj36 = num3 & 1;
		bool flag16 = obj36 == null;
		object obj37 = !flag16;
		if (obj37 != null)
		{
			num3 = num5;
		}
		goto IL_05ec;
	}

	private unsafe void Splat(Vector3 at, Vector3 normal, float size, Vector3 came, Collider on)
	{
		//IL_2111: Expected Obj, but got I
		//IL_2147: Expected Obj, but got I
		//IL_215e: Invalid comparison between F8 and Obj
		//IL_187e: Invalid comparison between F4 and I
		//IL_21d3: Expected Obj, but got I
		//IL_21fd: Expected Obj, but got I4
		//IL_18ad: Expected Obj, but got I
		//IL_18b5: Invalid comparison between F8 and Obj
		//IL_18d3: Expected F4, but got I
		//IL_0211: Invalid comparison between F4 and I
		//IL_18fe: Expected Obj, but got I
		//IL_190e: Expected Obj, but got I
		//IL_191d: Expected VT, but got I4
		//IL_191d: Expected VT, but got I4
		//IL_1931: Expected F8, but got I
		//IL_1a70: Expected Obj, but got I4
		//IL_1a79: Expected VT, but got I4
		//IL_1b58: Expected Obj, but got I4
		//IL_1aa8: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_1af2: Expected Obj, but got I4
		//IL_0399: Expected I4, but got VT
		//IL_0399: Expected VT, but got I4
		//IL_0399: Expected VT, but got I8
		//IL_03b7: Expected Obj, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I4
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_057d: Expected I4, but got Obj
		//IL_05c1: Expected F4, but got I
		//IL_05da: Expected VT, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0422: Expected Obj, but got I4
		//IL_042b: Expected VT, but got I4
		//IL_0443: Expected F4, but got I
		//IL_045c: Expected VT, but got I4
		//IL_0605: Expected Obj, but got I4
		//IL_062e: Expected F4, but got I
		//IL_0647: Expected VT, but got I4
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_04db: Expected VT, but got I4
		//IL_04f3: Expected F4, but got I
		//IL_050c: Expected VT, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_068e: Expected Obj, but got I4
		//IL_06a8: Expected Obj, but got I4
		//IL_1b83: Expected Obj, but got I4
		//IL_1bac: Expected F4, but got I
		//IL_1bc5: Expected VT, but got I4
		//IL_06ea: Expected Obj, but got F4
		//IL_1c10: Expected Obj, but got I4
		//IL_1c55: Invalid comparison between F8 and I4
		//IL_1c64: Expected F8, but got I4
		//IL_07f2: Expected Obj, but got Ref
		//IL_07f2: Expected VT, but got I4
		//IL_082e: Expected F4, but got I
		//IL_0846: Expected VT, but got Ref
		//IL_1ca9: Invalid comparison between F8 and I4
		//IL_1cb8: Expected F8, but got I4
		//IL_1cfd: Invalid comparison between F8 and I4
		//IL_1d0c: Expected F8, but got I4
		//IL_0886: Expected F4, but got I
		//IL_089e: Expected VT, but got Ref
		//IL_1da6: Expected Obj, but got I4
		//IL_08fe: Expected VT, but got I4
		//IL_0908: Expected I4, but got Obj
		//IL_0920: Expected F4, but got I
		//IL_093a: Expected VT, but got Obj
		//IL_1dec: Expected I4, but got I8
		//IL_1dfe: Expected I4, but got I8
		//IL_1e46: Expected Obj, but got I4
		//IL_1e58: Expected I4, but got I8
		//IL_1e78: Expected I4, but got I8
		//IL_1ea2: Expected Obj, but got I4
		//IL_1eab: Expected Obj, but got I4
		//IL_1eb4: Expected Obj, but got I4
		//IL_0962: Expected VT, but got I4
		//IL_096c: Expected I4, but got Obj
		//IL_0984: Expected F4, but got I
		//IL_099e: Expected VT, but got Obj
		//IL_1ed3: Expected Obj, but got I4
		//IL_1edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee1: Expected Obj, but got Unknown
		//IL_1efb: Expected Obj, but got I4
		//IL_09bc: Expected F8, but got I
		//IL_09cc: Expected F8, but got I
		//IL_09dc: Expected F8, but got I
		//IL_09e5: Expected VT, but got I4
		//IL_1f4f: Expected VT, but got I4
		//IL_1f57: Expected F8, but got I4
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b52: Expected Obj, but got I4
		//IL_0b71: Expected VT, but got I4
		//IL_0b79: Expected F8, but got I4
		//IL_0cad: Expected VT, but got I4
		//IL_0cb5: Expected F8, but got I4
		//IL_0ce6: Expected Obj, but got I4
		//IL_0d05: Expected VT, but got I4
		//IL_0d0d: Expected F8, but got I4
		//IL_0d40: Expected F4, but got I4
		//IL_1f87: Expected Obj, but got I4
		//IL_1f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f95: Expected Obj, but got Unknown
		//IL_1fbc: Expected Obj, but got I4
		//IL_0d72: Expected F8, but got I4
		//IL_2029: Expected VT, but got I4
		//IL_2031: Expected F8, but got I4
		//IL_0d92: Expected Obj, but got I4
		//IL_0db1: Expected VT, but got I4
		//IL_0db9: Expected F8, but got I4
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Expected Obj, but got Unknown
		//IL_0e40: Expected VT, but got I4
		//IL_0e48: Expected F8, but got I4
		//IL_0e79: Expected Obj, but got I4
		//IL_0e98: Expected VT, but got I4
		//IL_0ea0: Expected F8, but got I4
		//IL_0ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Expected Obj, but got Unknown
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f4e: Expected VT, but got I4
		//IL_0f56: Expected F8, but got I4
		//IL_0f75: Invalid comparison between VT and I4
		//IL_0f84: Expected VT, but got I4
		//IL_1024: Expected Obj, but got I4
		//IL_104a: Expected F8, but got I4
		//IL_0f9a: Expected I, but got Obj
		//IL_0faa: Expected VT, but got I
		//IL_0fe9: Expected VT, but got I
		//IL_0ff1: Expected F8, but got I4
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Expected Obj, but got Unknown
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected Obj, but got Unknown
		//IL_1087: Expected Obj, but got VT
		//IL_10c5: Expected Obj, but got I4
		//IL_10ec: Expected Obj, but got VT
		//IL_2086: Expected VT, but got I4
		//IL_208e: Expected F8, but got I4
		//IL_111d: Expected Obj, but got I
		//IL_1147: Expected Obj, but got I4
		//IL_116d: Expected Obj, but got VT
		//IL_11a1: Expected Obj, but got I4
		//IL_11c0: Expected VT, but got I4
		//IL_11c8: Expected F8, but got I4
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Expected Obj, but got Unknown
		//IL_121e: Expected Obj, but got I4
		//IL_1245: Expected Obj, but got VT
		//IL_1263: Expected Obj, but got I4
		//IL_127a: Invalid comparison between VT and I4
		//IL_129f: Expected VT, but got I4
		//IL_12a7: Expected F8, but got I4
		//IL_12c6: Expected Obj, but got VT
		//IL_12d7: Expected Obj, but got I4
		//IL_12ee: Expected Obj, but got I4
		//IL_12f7: Expected VT, but got I4
		//IL_12ff: Expected F8, but got I4
		//IL_1327: Expected Obj, but got I4
		//IL_13b4: Expected F4, but got I
		//IL_13c4: Expected F8, but got I
		//IL_13d4: Expected F4, but got I
		//IL_13e2: Expected VT, but got I4
		//IL_1416: Expected VT, but got I4
		//IL_143f: Expected Obj, but got I4
		//IL_145e: Expected VT, but got I4
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a4: Expected Obj, but got Unknown
		//IL_14e6: Expected VT, but got I4
		//IL_150c: Expected VT, but got I4
		//IL_1540: Expected VT, but got I4
		//IL_1583: Expected Obj, but got I4
		//IL_15a2: Expected VT, but got I4
		//IL_15d8: Expected Obj, but got I4
		//IL_163d: Expected VT, but got I4
		//IL_1680: Expected Obj, but got I4
		//IL_169f: Expected VT, but got I4
		//IL_16d5: Expected Obj, but got I4
		//IL_173a: Expected VT, but got I4
		//IL_177d: Expected Obj, but got I4
		//IL_179c: Expected VT, but got I4
		//IL_17ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d3: Expected Obj, but got Unknown
		float num2 = default;
		float num = num2 * num2;
		float num4 = default;
		float num3 = num4 * num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj = 0;
		object obj2 = obj;
		float num5 = num + num3;
		double num7 = default;
		double num6 = num7 * num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5+A0]");
		object obj3 = 0;
		double num8 = num6 + (double)num5;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
		double num10 = default;
		double num9 = num10;
		float num12 = default;
		float num11 = num12;
		float num14 = default;
		float num13 = num14;
		float num16 = default;
		float num15 = num16;
		if (!flag)
		{
			float num17 = num2 * num14;
			float num18 = num4 * num12;
			double num19 = num7 * num10;
			float num20 = num17 + num18;
			double num21 = num19 + (double)num20;
			double num22 = num21 / num8;
			float num23 = num2 * (float)num22;
			num15 = num4 * (float)num22;
			double num24 = num7 * num22;
			num13 = num14 - num23;
			num11 = num12 - num15;
			num9 = num10 - num24;
		}
		float num25 = num13 * num13;
		float num26 = num11 * num11;
		float num27 = num25 + num26;
		double num28 = num9 * num9;
		float num29 = num27 + (float)num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
		if (num29 < 0f)
		{
			Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v79+A0]");
			object obj5 = 0;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			num9 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			num11 = 0f;
			num13 = num29;
			if (!flag2)
			{
				float num30 = num2 * num29;
				float num31 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				float num32 = num31 * 0f;
				double num33 = num7 * (double)num15;
				float num34 = num30 + num32;
				double num35 = num33 + (double)num34;
				double num36 = num35 / num8;
				float num37 = num2 * (float)num36;
				float num38 = num4 * (float)num36;
				double num39 = num7 * num36;
				num13 = num29 - num37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
				num11 = 0f - num38;
				num9 = (double)num15 - num39;
				num15 = num38;
			}
		}
		float num40 = UnityEngine.Random.Range(-25f, 25f);
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(num40, ref axis);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num41 = num13 * num13;
		float num42 = num11 * num11;
		float num43 = num41 + num42;
		double num44 = num9 * num9;
		float num45 = num43 + (float)num44;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if (num45 > 0f)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj10 = 0;
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
		double num46 = 0.0;
		float num47 = (float)num7 * num40;
		float num48 = num4 * num40;
		float num49 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
		float num50 = num49 * 0f;
		float num51 = num4 * num15;
		float num52 = 0f - num2;
		double num53 = num7 * 25.0;
		float num54 = num2 * num15;
		double num55 = 0f - num4;
		float num56 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
		float num57 = num56 * 0f;
		double num58 = (double)num2 * 25.0;
		double num59 = 0.0 - num7;
		double num60 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE2C]");
		double num61 = num60 * 0.0;
		float num62 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		float num63 = num62 * 0f;
		double num64 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		double num65 = num64 * 0.0;
		double num66 = (double)num51 - num53;
		float num67 = num47 - num54;
		float num68 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		float num69 = num68 * 0f;
		double num70 = num58 - (double)num48;
		object obj11 = 0;
		Vector3 vector2 = (Vector3)0;
		double num71 = num66;
		object obj13 = default;
		object obj12 = obj13;
		object obj21 = default;
		SphericalHarmonicsL2 sphericalHarmonicsL = default;
		Vector3 vector3 = default;
		IndexOutOfRangeException ex2 = default;
		while (true)
		{
			double num72 = (double)obj12 * 0.5;
			double num73 = (double)obj12 * 0.5;
			double num74 = 0.0 - num73;
			object obj14 = 0;
			bool flag7;
			object obj26;
			float maxDistance;
			float num89;
			do
			{
				double num75;
				if ((nint)obj14 != 3)
				{
					bool flag4 = obj14 == null;
					object obj15 = !flag4;
					num75 = num72;
					if (obj15 != null)
					{
						goto IL_1a8e;
					}
				}
				num75 = num74;
				goto IL_1a8e;
				IL_1a8e:
				bool flag5 = (nint)obj14 < 2;
				object obj16 = !flag5;
				object obj17 = obj9;
				object obj18 = ~obj16;
				object obj19 = ~obj18;
				double num76 = ((obj19 != null) ? num72 : num74);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v15+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num77 = num40 * (float)num75;
				double num78 = 25.0 * num75;
				double num79 = (double)num15 * num75;
				double num80 = num66 * num76;
				float num81 = size + num77;
				double num82 = (double)obj21 + num78;
				double num83 = (double)num16 + num79;
				double num84 = num70 * num76;
				double num85 = num80 + (double)num81;
				float num86 = num67 * (float)num76;
				double num87 = num84 + num83;
				maxDistance = num69 + (float)num85;
				float num88 = num86 + (float)num82;
				num71 = num65 + num87;
				num89 = num63 + num88;
				flag7 = Physics.Raycast((Vector3)4294951163L, (Vector3)1, maxDistance, 0, (QueryTriggerInteraction)vector3);
				bool flag8 = (nint)obj14 < 2;
				object obj22 = !flag8;
				object obj23 = obj14 - 2;
				bool flag9 = obj23 == null;
				object obj24 = !flag9;
				object obj25 = obj22 & obj24;
				if (obj25 != null)
				{
					break;
				}
				obj14++;
				bool flag10 = !flag7;
				obj26 = !flag10;
				Vector3 vector4 = (Vector3)0;
				num54 = num52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
				num48 = 0f;
				num58 = num59;
				num46 = num55;
				vector2 = (Vector3)1;
			}
			while (obj26 != null);
			bool flag11 = !flag7;
			object obj27 = !flag11;
			if (obj27 == null)
			{
				if ((nint)obj11 != 2)
				{
					obj11++;
					object obj28 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
					obj12 = obj28 * 0;
					Vector3 vector4 = (Vector3)0;
					num54 = num52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					num48 = 0f;
					num58 = num59;
					num46 = num55;
					vector2 = (Vector3)1;
					continue;
				}
				break;
			}
			float[] array = born;
			object obj29 = next + 1;
			object obj30 = obj29 * 715827883;
			object obj31 = obj30 >> 63;
			object obj32 = obj30 >> 36;
			object obj33 = obj32 + obj31;
			object obj34 = obj33 * 96;
			int num90 = obj29 - obj34;
			next = num90;
			bool flag12 = born == null;
			int num91 = 0;
			float num92 = num52;
			double num93 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			float num94 = 0f;
			double num95 = num59;
			double num96 = num55;
			Vector3 vector5 = (Vector3)1;
			if (flag12)
			{
				goto IL_17ec;
			}
			bool flag13 = next < array.Length;
			object obj35 = !flag13;
			num91 = 0;
			num92 = num52;
			num93 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			num94 = 0f;
			num95 = num59;
			num96 = num55;
			vector5 = (Vector3)1;
			double num99;
			double num100;
			double num101;
			if (obj35 == null)
			{
				object obj36 = born + next;
				object obj37 = obj36 + 32;
				bool flag14 = (nint)obj37 < 0;
				object obj38 = !flag14;
				bool flag15 = obj37 == null;
				object obj39 = !flag15;
				object obj40 = obj38 & obj39;
				if (obj40 == null)
				{
					int num97 = showing + 1;
					showing = num97;
				}
				maxDistance = Time.time;
				bool flag16 = next < array.Length;
				object obj41 = !flag16;
				num91 = 0;
				num92 = num52;
				num93 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
				num94 = 0f;
				num95 = num59;
				num96 = num55;
				vector5 = (Vector3)1;
				if (obj41 == null)
				{
					obj37 = maxDistance;
					float time = Time.time;
					float num98 = time + 1f;
					if (nextFade < num98)
					{
						num98 = nextFade;
					}
					nextFade = num98;
					LightProbes lightProbes = LightmapSettings.lightProbes;
					object obj42 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v33+E4]");
					bool flag17 = (nint)0 == 0;
					object obj43 = !flag17;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(lightProbes != null))
					{
						Color[] array2 = null;
						num99 = 1.0;
						UnityEngine.Object obj44 = null;
						num100 = 1.0;
						num101 = 1.0;
						goto IL_1c1e;
					}
					float num102 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					float num103 = num102 * 0f;
					float num104 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					float num105 = num104 * 0f;
					float num106 = (float)num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					num92 = num106 * 0f;
					maxDistance = size + num103;
					num89 = (float)obj21 + num105;
					num71 = (double)num16 + (double)num92;
					LightProbes.GetInterpolatedProbe((Vector3)0, (Renderer)(&sphericalHarmonicsL), out *(SphericalHarmonicsL2*)null);
					Vector3[] array3 = dirs;
					bool flag18 = dirs == null;
					num91 = 0;
					num93 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					num94 = 0f;
					num95 = num59;
					num96 = num55;
					vector5 = (Vector3)(&sphericalHarmonicsL);
					if (flag18)
					{
						goto IL_17ec;
					}
					bool flag19 = array3.Length == 0;
					num91 = 0;
					num93 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					num94 = 0f;
					num95 = num59;
					num96 = num55;
					vector5 = (Vector3)(&sphericalHarmonicsL);
					if (!flag19)
					{
						Color[] array2 = heard;
						sphericalHarmonicsL.Evaluate(dirs, heard);
						Color[] array4 = heard;
						bool flag20 = heard == null;
						vector3 = (Vector3)0;
						num91 = (int)heard;
						num93 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
						num94 = 0f;
						num95 = num59;
						num96 = num55;
						vector5 = (Vector3)dirs;
						if (flag20)
						{
							goto IL_17ec;
						}
						bool flag21 = array4.Length == 0;
						vector3 = (Vector3)0;
						num91 = (int)heard;
						num93 = num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
						num94 = 0f;
						num95 = num59;
						num96 = num55;
						vector5 = (Vector3)dirs;
						if (!flag21)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v67 (UnityEngine.Color[])+20]");
							num100 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v67 (UnityEngine.Color[])+24]");
							num99 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v67 (UnityEngine.Color[])+28]");
							num101 = 0.0;
							vector3 = (Vector3)0;
							UnityEngine.Object obj44 = (UnityEngine.Object)(object)dirs;
							goto IL_1c1e;
						}
					}
				}
			}
			goto IL_17fa;
			IL_17ec:
			NullReferenceException ex = new NullReferenceException();
			goto IL_17fa;
			IL_0f14:
			Collider[] array5 = onCol;
			bool flag22 = onCol == null;
			num91 = 0;
			num95 = 0.25;
			vector5 = (Vector3)16;
			int num107;
			num71 = num107;
			float num108;
			num89 = num108;
			int num110;
			if (!flag22)
			{
				bool flag23 = at == (Vector3)(object)0;
				Vector3 vector6 = (Vector3)16;
				if (!flag23)
				{
					nint num109 = (nint)array5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X8_v64 (Il2CppClass<UnityEngine.Collider[]>)+40]");
					vector6 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag24 = ex2 == null;
					num91 = 0;
					num95 = 0.25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X8_v64 (Il2CppClass<UnityEngine.Collider[]>)+40]");
					vector5 = (Vector3)0;
					num71 = num107;
					num89 = num108;
					if (flag24)
					{
						goto IL_1808;
					}
				}
				bool flag25 = next < array5.Length;
				object obj45 = !flag25;
				num91 = 0;
				num95 = 0.25;
				vector5 = vector6;
				num71 = num107;
				num89 = num108;
				if (obj45 != null)
				{
					goto IL_17fa;
				}
				object obj46 = onCol + next;
				object obj47 = obj46 + 32;
				obj47 = at;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj48 = obj10;
				bool[] array6 = rides;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X0_v43+E4]");
				bool flag26 = (nint)0 == 0;
				object obj49 = !flag26;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)at != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
					object obj50 = 0;
					object obj51 = obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X0_v65+E4]");
					bool flag27 = (nint)0 == 0;
					object obj52 = !flag27;
					if (obj52 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag28 = Moves((Collider)at);
				}
				else
				{
					bool flag28 = false;
				}
				bool flag29 = rides == null;
				num91 = 0;
				num95 = 0.25;
				vector5 = (Vector3)0;
				num71 = num107;
				num89 = num108;
				if (!flag29)
				{
					bool flag30 = next < array6.Length;
					object obj53 = !flag30;
					num91 = 0;
					num95 = 0.25;
					vector5 = (Vector3)0;
					num71 = num107;
					num89 = num108;
					if (obj53 != null)
					{
						goto IL_17fa;
					}
					object obj54 = obj10;
					object obj55 = rides + next;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v44+E4]");
					bool flag31 = (nint)0 == 0;
					object obj56 = !flag31;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag32 = (UnityEngine.Object)at == null;
					bool flag33 = !flag32;
					object obj57 = !flag33;
					if (obj57 != null)
					{
						break;
					}
					bool flag34 = at == (Vector3)(object)0;
					num91 = 0;
					num95 = 0.25;
					vector5 = (Vector3)0;
					num71 = num107;
					num89 = num108;
					if (!flag34)
					{
						Transform transform = ((Component)at).transform;
						object obj58 = num110 + num110;
						object obj59 = obj58 << 2;
						object obj60 = 0;
						vector5 = (Vector3)0;
						num71 = num107;
						num89 = num108;
						while (true)
						{
							Vector3[] array7 = verts;
							bool flag35 = verts == null;
							num91 = 0;
							num95 = 0.25;
							if (flag35)
							{
								break;
							}
							bool flag36 = num110 < array7.Length;
							object obj61 = !flag36;
							num91 = 0;
							num95 = 0.25;
							if (obj61 == null)
							{
								bool flag37 = (object)transform == null;
								num91 = 0;
								num95 = 0.25;
								if (flag37)
								{
									break;
								}
								object obj62 = (object)verts + obj59;
								Vector3[] array8 = onLocal;
								object obj63 = obj62 + obj60;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v49+24]");
								num89 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v49+28]");
								num71 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v49+20]");
								maxDistance = 0f;
								Vector3 vector7 = transform.InverseTransformPoint((Vector3)0);
								bool flag38 = onLocal == null;
								num91 = 0;
								num95 = 0.25;
								vector5 = (Vector3)0;
								if (flag38)
								{
									break;
								}
								bool flag39 = num110 < array8.Length;
								object obj64 = !flag39;
								num91 = 0;
								num95 = 0.25;
								vector5 = (Vector3)0;
								if (obj64 == null)
								{
									object obj65 = (object)onLocal + obj59;
									num110++;
									object obj66 = obj65 + obj60;
									obj60 += 12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v49+20]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v49+24]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v49+28]");
									_ = 0;
									bool flag40 = (nint)obj60 != 48;
									vector5 = (Vector3)0;
									if (flag40)
									{
										continue;
									}
									Vector3[] array9 = onFaces;
									Vector3 vector8 = transform.InverseTransformDirection((Vector3)0);
									bool flag41 = onFaces == null;
									num91 = 0;
									num95 = 0.25;
									vector5 = (Vector3)0;
									num71 = num7;
									num89 = num4;
									maxDistance = num2;
									if (flag41)
									{
										break;
									}
									bool flag42 = next < array9.Length;
									object obj67 = !flag42;
									num91 = 0;
									num95 = 0.25;
									vector5 = (Vector3)0;
									num71 = num7;
									num89 = num4;
									maxDistance = num2;
									if (obj67 == null)
									{
										object obj68 = next * 12;
										object obj69 = (object)onFaces + obj68;
										Vector3[] array10 = onAt;
										Vector3 position = transform.position;
										bool flag43 = onAt == null;
										num91 = 0;
										num95 = 0.25;
										vector5 = (Vector3)0;
										num71 = num7;
										num89 = num4;
										maxDistance = num2;
										if (flag43)
										{
											break;
										}
										bool flag44 = next < array10.Length;
										object obj70 = !flag44;
										num91 = 0;
										num95 = 0.25;
										vector5 = (Vector3)0;
										num71 = num7;
										num89 = num4;
										maxDistance = num2;
										if (obj70 == null)
										{
											object obj71 = next * 12;
											object obj72 = (object)onAt + obj71;
											Quaternion[] array11 = onTurn;
											Quaternion rotation = transform.rotation;
											bool flag45 = onTurn == null;
											num91 = 0;
											num95 = 0.25;
											vector5 = (Vector3)0;
											num71 = num7;
											num89 = num4;
											maxDistance = num2;
											if (flag45)
											{
												break;
											}
											bool flag46 = next < array11.Length;
											object obj73 = !flag46;
											num91 = 0;
											num95 = 0.25;
											vector5 = (Vector3)0;
											num71 = num7;
											num89 = num4;
											maxDistance = num2;
											if (obj73 == null)
											{
												object obj74 = onTurn + next;
												return;
											}
										}
									}
								}
							}
							goto IL_17fa;
						}
					}
				}
			}
			goto IL_17ec;
			IL_1808:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			throw new ArgumentNullException();
			IL_1c1e:
			double num111 = num100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			double num112 = num111 * 0.0;
			double num113 = num112;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			double num114 = num113 + 0.0;
			bool flag47 = num114 < 0.0;
			double num115 = 0.0;
			if (!flag47)
			{
				bool flag48 = !(num114 > 1.0);
				num115 = num114;
				if (!flag48)
				{
					num115 = 1.0;
				}
			}
			double num116 = num99;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			double num117 = num116 * 0.0;
			double num118 = num117;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			double num119 = num118 + 0.0;
			bool flag49 = num119 < 0.0;
			double num120 = 0.0;
			if (!flag49)
			{
				bool flag50 = !(num119 > 1.0);
				num120 = num119;
				if (!flag50)
				{
					num120 = 1.0;
				}
			}
			double num121 = num101;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
			double num122 = num121 * 0.0;
			double num123 = num122;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
			double num124 = num123 + 0.0;
			bool flag51 = num124 < 0.0;
			double num125 = 0.0;
			if (!flag51)
			{
				bool flag52 = !(num124 > 1.0);
				num125 = num124;
				if (!flag52)
				{
					num125 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B470");
			int num126 = UnityEngine.Random.Range(0, 16);
			int num127 = num126 + 3;
			bool flag53 = num126 < 0;
			int num128 = num126 ^ num126;
			int num129 = num126 & num128;
			bool flag54 = num129 < 0;
			num110 = next << 2;
			bool flag55 = flag53 == flag54;
			object obj75 = !flag55;
			object obj76 = ~obj75;
			if (obj76 != null)
			{
				num127 = num126;
			}
			num92 = (float)obj21 + num57;
			num107 = num127 >> 2;
			int num130 = (int)(num127 & 0xFFFFFFFCL);
			int num131 = (int)(num110 & 0xFFFFFFFFL);
			int num132 = num131 << 1;
			num108 = (float)num126 - (float)num130;
			maxDistance = size + num50;
			num96 = (double)num16 + num61;
			object obj77 = num132 + num110;
			int num133 = (int)(num110 & 0xFFFFFFFFL);
			int num134 = num133 << 2;
			int num135 = (int)(num110 & 0xFFFFFFFFL);
			int num136 = num135 << 3;
			object obj78 = obj77 << 2;
			object obj79 = num134 + 32;
			object obj80 = 0;
			object obj81 = 0;
			while (true)
			{
				Vector3[] array12 = verts;
				num93 = num74;
				bool flag56 = (nint)obj80 < 1;
				object obj82 = !flag56;
				object obj83 = obj80 - 1;
				bool flag57 = obj83 == null;
				object obj84 = !flag57;
				object obj85 = obj82 & obj84;
				object obj86 = ~obj85;
				num94 = ((obj86 != null) ? ((float)num74) : ((float)num72));
				bool flag58 = verts == null;
				num91 = 0;
				num95 = 0.25;
				vector5 = (Vector3)16;
				num71 = num107;
				num89 = num108;
				if (flag58)
				{
					break;
				}
				object obj87 = num110 + obj80;
				bool flag59 = (nint)obj87 < array12.Length;
				object obj88 = !flag59;
				num91 = 0;
				num95 = 0.25;
				vector5 = (Vector3)16;
				num71 = num107;
				num89 = num108;
				if (obj88 == null)
				{
					object obj89 = (object)verts + obj78;
					object obj90 = obj89 + obj81;
					float num137 = num40 * (float)num93;
					double num138 = 25.0 * num93;
					double num139 = (double)num15 * num93;
					double num140 = num66 * (double)num94;
					float num141 = num67 * num94;
					double num142 = num70 * (double)num94;
					float num143 = maxDistance + num137;
					double num144 = (double)num92 + num138;
					num93 = num96 + num139;
					double num145 = num140 + (double)num143;
					float num146 = num141 + (float)num144;
					num94 = (float)num142 + (float)num93;
					Vector3[] array13 = normals;
					bool flag60 = normals == null;
					num91 = 0;
					num95 = 0.25;
					vector5 = (Vector3)16;
					num71 = num107;
					num89 = num108;
					if (flag60)
					{
						break;
					}
					bool flag61 = (nint)obj87 < array13.Length;
					object obj91 = !flag61;
					num91 = 0;
					num95 = 0.25;
					vector5 = (Vector3)16;
					num71 = num107;
					num89 = num108;
					if (obj91 == null)
					{
						object obj92 = (object)normals + obj78;
						num94 = 0f;
						bool flag62 = (nint)obj80 < 1;
						object obj93 = !flag62;
						object obj94 = obj80 - 1;
						bool flag63 = obj94 == null;
						object obj95 = obj92 + obj81;
						object obj96 = !flag63;
						object obj97 = obj93 & obj96;
						object obj98 = ~obj97;
						num93 = ((obj98 != null) ? 0.0 : 0.25);
						Vector2[] array14 = uvs;
						bool flag64 = uvs == null;
						num91 = 0;
						num95 = 0.25;
						vector5 = (Vector3)16;
						num71 = num107;
						num89 = num108;
						if (flag64)
						{
							break;
						}
						bool flag65 = (nint)obj87 < array14.Length;
						object obj99 = !flag65;
						num91 = 0;
						num95 = 0.25;
						vector5 = (Vector3)16;
						num71 = num107;
						num89 = num108;
						if (obj99 == null)
						{
							num94 = num108 + num94;
							num93 = (double)num107 + num93;
							object obj100 = uvs + num136;
							Color32[] array15 = colours;
							bool flag66 = colours == null;
							num91 = 0;
							num95 = 0.25;
							vector5 = (Vector3)16;
							num71 = num107;
							num89 = num108;
							if (flag66)
							{
								break;
							}
							bool flag67 = (nint)obj87 < array15.Length;
							object obj101 = !flag67;
							num91 = 0;
							num95 = 0.25;
							vector5 = (Vector3)16;
							num71 = num107;
							num89 = num108;
							if (obj101 == null)
							{
								obj81 += 12;
								object obj102 = (object)colours + obj79;
								num136 += 8;
								obj80++;
								if ((nint)obj81 != 48)
								{
									continue;
								}
								goto IL_0f14;
							}
						}
					}
				}
				goto IL_17fa;
			}
			goto IL_17ec;
			IL_17fa:
			ex2 = new IndexOutOfRangeException();
			goto IL_1808;
		}
	}

	private unsafe static void Bodies(Vector3 at, float strength, Dismemberment not)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1082: Expected Obj, but got I4
		//IL_10a8: Expected Obj, but got I
		//IL_10ca: Expected Obj, but got I4
		//IL_1371: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got I
		//IL_13a8: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_044c: Expected Obj, but got I4
		//IL_10e8: Expected Obj, but got I
		//IL_1105: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got I4
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected F4, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Obj, but got I4
		//IL_12ae: Expected Obj, but got I
		//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bf: Expected Ref, but got Unknown
		//IL_12d9: Expected Obj, but got I4
		//IL_0506: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected Obj, but got I4
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0585: Expected Obj, but got I4
		//IL_0868: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_11b3: Expected Obj, but got I
		//IL_1195: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I4
		//IL_13ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d6: Expected Obj, but got Unknown
		//IL_13f8: Expected Obj, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected F4, but got Unknown
		//IL_0334: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_130e: Expected Obj, but got I
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1323: Unknown result type (might be due to invalid IL or missing references)
		//IL_1335: Expected Obj, but got I4
		//IL_1339: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected VT, but got I4
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected F4, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03cc: Expected Obj, but got VT
		//IL_03cc: Expected Obj, but got I
		//IL_03e2: Expected I4, but got I8
		//IL_03fc: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got VT
		//IL_08d2: Expected Obj, but got I4
		//IL_0aab: Expected Obj, but got I
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got VT
		//IL_069e: Expected Obj, but got I4
		//IL_06cd: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_0b24: Expected Obj, but got I
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected Obj, but got VT
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected Obj, but got I4
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got I
		//IL_0745: Expected Obj, but got I4
		//IL_0bbc: Expected Obj, but got VT
		//IL_0fdb: Expected Obj, but got I4
		//IL_0954: Expected Obj, but got I
		//IL_0976: Expected Obj, but got I4
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Expected Obj, but got I
		//IL_0be4: Expected Obj, but got I8
		//IL_0bfa: Expected Obj, but got I
		//IL_0c03: Expected Obj, but got I4
		//IL_0c0b: Expected Obj, but got VT
		//IL_121b: Expected Obj, but got I4
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected Obj, but got I4
		//IL_0a28: Expected Obj, but got I
		//IL_0c28: Expected Obj, but got I
		//IL_0c4a: Expected Obj, but got I4
		//IL_0d44: Expected Obj, but got I
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected Obj, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected Obj, but got I4
		//IL_0dc7: Expected Obj, but got I4
		//IL_0e32: Expected Obj, but got VT
		//IL_0e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e87: Expected Obj, but got I4
		//IL_0eb6: Expected VT, but got I4
		//IL_0ee4: Expected Obj, but got I4
		//IL_126f: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v6+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9 (System.Collections.Generic.LowLevelDictionary`2<System.__Canon>+Enumerator<System.__Canon>)+8]");
		UnityEngine.Object obj8 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A888]");
		object obj13 = default;
		object obj12 = obj13 * 0;
		bool flag4 = obj8 != null;
		bool flag5 = !flag4;
		object obj15 = default;
		object obj14 = obj15;
		float num2 = default;
		float num = num2;
		Dismemberment dismemberment = null;
		System.__Canon _Canon = null;
		Enumerator<, > val2;
		object obj17 = default;
		float num4 = default;
		Enumerator<, > val3;
		object obj32;
		object obj31;
		Vector3 vector;
		UnityEngine.Object obj18;
		object obj16;
		float num3;
		if (!flag5)
		{
			bool flag6 = (object)obj8 == null;
			val2 = (Enumerator<, >)0;
			obj14 = obj15;
			obj16 = obj17;
			num3 = num4;
			val3 = (Enumerator<, >)0;
			num = num2;
			dismemberment = null;
			obj18 = null;
			vector = at;
			if (flag6)
			{
				goto IL_0f55;
			}
			object obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
			UnityEngine.Object obj20 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v103+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = obj20 != null;
			bool flag9 = !flag8;
			obj14 = obj15;
			num = num2;
			dismemberment = null;
			_Canon = null;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
				bool flag10 = (nint)0 == 0;
				val2 = (Enumerator<, >)0;
				obj14 = obj15;
				obj16 = obj17;
				num3 = num4;
				val3 = (Enumerator<, >)0;
				num = num2;
				dismemberment = null;
				obj18 = null;
				vector = at;
				if (flag10)
				{
					goto IL_0f55;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v48+20]");
				bool flag11 = (nint)0 == 0;
				obj14 = obj15;
				num = num2;
				dismemberment = null;
				_Canon = null;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v107+E4]");
					bool flag12 = (nint)0 == 0;
					object obj25 = !flag12;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool isMonster = MonsterPlayer.IsMonster;
					bool flag13 = !isMonster;
					object obj26 = !flag13;
					obj14 = obj15;
					num = num2;
					dismemberment = null;
					_Canon = null;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
						bool flag14 = (nint)0 == 0;
						val2 = (Enumerator<, >)0;
						obj14 = obj15;
						obj16 = obj17;
						num3 = num4;
						val3 = (Enumerator<, >)0;
						num = num2;
						dismemberment = null;
						obj18 = null;
						vector = at;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FD8]");
							val = (Enumerator<, >)0;
							dismemberment = (Dismemberment)val;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v53+20]");
							int num5 = Array.IndexOf((System.__Canon[])0, (System.__Canon)at);
							int num6 = (int)(num5 & 0x80000000L);
							bool flag15 = num6 == 0;
							object obj28 = !flag15;
							obj14 = obj15;
							num = num2;
							_Canon = (System.__Canon)at;
							if (obj28 == null)
							{
								goto IL_0422;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v19 (UnityEngine.Object)+68]");
							bool flag16 = (nint)0 == 0;
							val2 = (Enumerator<, >)0;
							obj14 = obj15;
							obj16 = obj17;
							num3 = num4;
							val3 = (Enumerator<, >)0;
							num = num2;
							obj18 = (UnityEngine.Object)at;
							vector = at;
							if (!flag16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v54+20]");
								obj20 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v54+20]");
								bool flag17 = (nint)0 == 0;
								val2 = (Enumerator<, >)0;
								obj14 = obj15;
								obj16 = obj17;
								num3 = num4;
								val3 = (Enumerator<, >)0;
								num = num2;
								obj18 = (UnityEngine.Object)at;
								vector = at;
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X22_v8 (UnityEngine.Object)+18]");
									bool flag18 = (nint)0 < (nint)1;
									obj14 = obj15;
									num = num2;
									_Canon = (System.__Canon)at;
									if (flag18)
									{
										goto IL_0422;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X22_v8 (UnityEngine.Object)+18]");
									object obj30 = 0 & 0xFFFFFFFFL;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v54+20]");
									obj31 = (nint)0 + (nint)32;
									obj32 = 0;
									obj18 = (UnityEngine.Object)at;
									while (true)
									{
										bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
										object obj33 = !flag19;
										val2 = (Enumerator<, >)0;
										obj14 = obj15;
										obj16 = obj17;
										num3 = num4;
										val3 = (Enumerator<, >)0;
										num = num2;
										vector = at;
										if (obj33 != null)
										{
											break;
										}
										object obj34 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X26_v8+v368 @ X25_v8*8]");
										obj8 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v114+E4]");
										bool flag20 = (nint)0 == 0;
										object obj35 = !flag20;
										if (obj35 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag21 = obj8 != null;
										bool flag22 = !flag21;
										_Canon = null;
										if (!flag22)
										{
											bool flag23 = (object)obj8 == null;
											val2 = (Enumerator<, >)0;
											obj14 = obj15;
											obj16 = obj17;
											num3 = num4;
											val3 = (Enumerator<, >)0;
											num = num2;
											dismemberment = null;
											obj18 = null;
											vector = at;
											if (flag23)
											{
												goto IL_0f55;
											}
											bool flag24 = ((UnityEngine.Behaviour)obj8).isActiveAndEnabled;
											bool flag25 = !flag24;
											object obj36 = !flag25;
											_Canon = null;
											if (obj36 != null)
											{
												goto IL_0d9d;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X22_v8 (UnityEngine.Object)+18]");
										obj30 = 0;
										obj32++;
										object obj37 = obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X22_v8 (UnityEngine.Object)+18]");
										bool flag26 = (nint)obj37 < 0;
										dismemberment = null;
										obj18 = (UnityEngine.Object)(object)_Canon;
										if (flag26)
										{
											continue;
										}
										goto IL_0d83;
									}
									goto IL_0f8b;
								}
							}
						}
						goto IL_0f55;
					}
				}
			}
		}
		goto IL_0422;
		IL_0d83:
		obj14 = obj15;
		num = num2;
		dismemberment = null;
		goto IL_0422;
		IL_0422:
		object obj38 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v65+E4]");
		bool flag27 = (nint)0 == 0;
		object obj39 = !flag27;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v65+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v34+8]");
		bool flag28 = (nint)0 == 0;
		val2 = (Enumerator<, >)0;
		obj16 = obj17;
		num3 = num4;
		val3 = (Enumerator<, >)0;
		obj18 = (UnityEngine.Object)(object)_Canon;
		vector = at;
		if (flag28)
		{
			goto IL_0f55;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C58]");
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v34+8]");
		Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
		obj16 = obj17;
		num3 = num4;
		Enumerator<, > val5 = default;
		Enumerator<, > val4 = val5;
		val = (Enumerator<, >)(ref val3);
		UnityEngine.Object obj51;
		Enumerator<, > val6 = default;
		object obj52 = default;
		UnityEngine.Object obj44 = default;
		object obj57;
		while (val3.MoveNext())
		{
			object obj42 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X0_v71+E4]");
			bool flag29 = (nint)0 == 0;
			object obj43 = !flag29;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag30 = obj44 != null;
			bool flag31 = !flag30;
			dismemberment = null;
			obj8 = obj44;
			if (flag31)
			{
				continue;
			}
			object obj45 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v75+E4]");
			bool flag32 = (nint)0 == 0;
			object obj46 = !flag32;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj47 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v79+E4]");
			bool flag33 = (nint)0 == 0;
			object obj48 = !flag33;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj47 = obj10;
			}
			object obj49 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v79+A0]");
			val = (Enumerator<, >)0;
			UnityEngine.Object obj20 = (UnityEngine.Object)val;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v44+E4]");
			bool flag34 = (nint)0 == 0;
			object obj50 = !flag34;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag35 = obj44 != obj20;
			bool flag36 = !flag35;
			dismemberment = null;
			obj8 = obj44;
			if (flag36)
			{
				continue;
			}
			bool flag37 = (object)obj44 == null;
			val2 = (Enumerator<, >)0;
			obj51 = null;
			val3 = val5;
			obj52 = 0;
			num = (float)val4;
			val6 = (Enumerator<, >)(ref val3);
			dismemberment = null;
			obj18 = obj20;
			vector = at;
			obj8 = obj44;
			if (!flag37)
			{
				object obj53 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X0_v83+E4]");
				bool flag38 = (nint)0 == 0;
				object obj54 = !flag38;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ stack_-E8_v3 (UnityEngine.Object)+A8]");
				bool flag39 = (UnityEngine.Object)0 != null;
				bool flag40 = !flag39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ stack_-E8_v3 (UnityEngine.Object)+A8]");
				obj20 = (UnityEngine.Object)0;
				dismemberment = null;
				obj8 = obj44;
				if (!flag40)
				{
					object obj55 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ stack_-E8_v3 (UnityEngine.Object)+A8]");
					obj8 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ X0_v87+E4]");
					bool flag41 = (nint)0 == 0;
					object obj56 = !flag41;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag42 = Body((Dismemberment)obj8, at, num2, num4, null);
					obj57 = obj15;
					obj14 = obj12;
					obj16 = obj17;
					num3 = num4;
					val4 = (Enumerator<, >)num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ stack_-E8_v3 (UnityEngine.Object)+A8]");
					obj20 = (UnityEngine.Object)0;
					dismemberment = null;
				}
				continue;
			}
			goto IL_0f3f;
		}
		val2 = (Enumerator<, >)0;
		UnityEngine.Object obj58 = null;
		val3 = val5;
		obj52 = 0;
		num = (float)val4;
		val6 = (Enumerator<, >)(ref val3);
		vector = at;
		object obj59 = 0;
		goto IL_129e;
		IL_0f72:
		throw new OutOfMemoryException();
		IL_0f01:
		NullReferenceException ex = new NullReferenceException();
		Enumerator<, > val7 = default;
		val2 = val7;
		obj51 = null;
		obj52 = 0;
		val6 = (Enumerator<, >)(ref val2);
		val = (Enumerator<, >)(ref val2);
		dismemberment = null;
		obj18 = null;
		goto IL_0f3f;
		IL_0f3f:
		NullReferenceException ex2 = new NullReferenceException();
		obj44 = obj51;
		goto IL_0f55;
		IL_0f63:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0f72;
		IL_0f55:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0f63;
		IL_0d9d:
		object obj60 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X0_v121+E4]");
		bool flag43 = (nint)0 == 0;
		object obj61 = !flag43;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag44 = Body((Dismemberment)obj8, at, num2, num4, null);
		bool flag45 = !flag44;
		obj57 = obj15;
		obj14 = obj12;
		num = num2;
		dismemberment = null;
		_Canon = (System.__Canon)at;
		if (!flag45)
		{
			Transform transform = ((Component)obj8).transform;
			object obj62 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v61+E4]");
			val = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v61+E4]");
			bool flag46 = (nint)0 == 0;
			object obj63 = !flag46;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector4 vector2 = Thrown(transform, (Vector3)0, num2);
			object obj64 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v130+E4]");
			bool flag47 = (nint)0 == 0;
			object obj65 = !flag47;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NetworkApe.SplashedYou((Vector4)0);
			obj57 = obj15;
			obj14 = obj15;
			num = num2;
			dismemberment = null;
			_Canon = null;
			obj8 = transform;
		}
		goto IL_0422;
		IL_0f8b:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		if ((nint)obj18 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj58 = (UnityEngine.Object)1;
			obj59 = obj52;
		}
		else
		{
			if ((nint)obj18 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj66 = default;
			obj59 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj58 = obj44;
			obj52 = obj66;
		}
		goto IL_129e;
		IL_129e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
		object obj67 = 0;
		obj18 = (UnityEngine.Object)obj67;
		((Enumerator<, >*)val6)->Dispose();
		bool flag48 = obj59 == null;
		object obj68 = !flag48;
		obj44 = obj58;
		if (obj68 != null)
		{
			goto IL_0f72;
		}
		bool flag49 = (object)obj58 == null;
		object obj69 = !flag49;
		obj44 = obj58;
		ex3 = (NullReferenceException)val6;
		if (obj69 != null)
		{
			goto IL_0f63;
		}
		object obj70 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v13+E4]");
		bool flag50 = (nint)0 == 0;
		object obj71 = !flag50;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj70 = obj41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v13+A0]");
		object obj72 = 0;
		bool flag51 = obj72 == null;
		obj44 = obj58;
		if (flag51)
		{
			goto IL_0f55;
		}
		Enumerator<, > enumerator2 = ((List<System.__Canon>)obj72).GetEnumerator();
		num = (float)val7;
		while (val2.MoveNext())
		{
			object obj73 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v20+E4]");
			bool flag52 = (nint)0 == 0;
			object obj74 = !flag52;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag53 = obj58 != null;
			bool flag54 = !flag53;
			dismemberment = null;
			if (flag54)
			{
				continue;
			}
			if ((object)obj58 != null)
			{
				object obj75 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ stack_-E8_v1 (UnityEngine.Object)+80]");
				obj8 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v25+E4]");
				bool flag55 = (nint)0 == 0;
				object obj76 = !flag55;
				if (obj76 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag56 = obj8 != null;
				bool flag57 = !flag56;
				dismemberment = null;
				if (!flag57)
				{
					object obj77 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X0_v29+E4]");
					bool flag58 = (nint)0 == 0;
					object obj78 = !flag58;
					if (obj78 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ stack_-E8_v1 (UnityEngine.Object)+80]");
					bool flag59 = Body((Dismemberment)0, vector, num2, num4, null);
					obj57 = obj15;
					obj14 = obj12;
					obj16 = obj17;
					num3 = num4;
					num = num2;
					dismemberment = null;
				}
				continue;
			}
			goto IL_0f01;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C40]");
		object obj79 = 0;
		obj18 = (UnityEngine.Object)obj79;
		val2.Dispose();
		val2 = val7;
		obj44 = null;
		obj52 = 0;
		val6 = (Enumerator<, >)(ref val2);
		val = (Enumerator<, >)(ref val2);
		vector = (Vector3)0;
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0f8b;
	}

	private static bool Body(Dismemberment copy, Vector3 at, float reach, float strength, Dismemberment not)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got VT
		//IL_00cc: Expected Obj, but got I4
		//IL_0319: Expected I4, but got Obj
		//IL_01e1: Invalid comparison between F4 and Obj
		//IL_0216: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_02f8: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = copy == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = copy == (UnityEngine.Object)at;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				if ((object)copy != null)
				{
					if (!copy.isActiveAndEnabled)
					{
						goto IL_01f8;
					}
					Transform transform = copy.transform;
					if ((object)transform != null)
					{
						Vector3 position = transform.position;
						float num = reach - reach;
						float num2 = strength - strength;
						object obj9 = default;
						object obj8 = obj9 - obj9;
						float num3 = num * num;
						float num4 = num2 * num2;
						float num5 = num3 + num4;
						object obj10 = obj8 * obj8;
						float num6 = (float)obj10 + num5;
						object obj12 = default;
						object obj11 = obj12 * obj12;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
						{
							goto IL_01f8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
						object obj13 = 0;
						object obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v20+E4]");
						bool flag7 = (nint)0 == 0;
						object obj15 = !flag7;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaBloodied gillaBloodied = GillaBloodied.On(copy);
						if ((object)gillaBloodied != null)
						{
							GillaStains.Sheet sheet = gillaBloodied.sheet;
							if (gillaBloodied.sheet != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
								if (sheet.working > 1)
								{
									goto IL_02fd;
								}
							}
							gillaBloodied.Splash((Vector3)0, reach, strength);
							goto IL_02fd;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		goto IL_01f8;
		IL_02fd:
		return true;
		IL_01f8:
		return false;
	}

	public GillaSplatter()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 72;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 80;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = this + 88;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 96;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj15 = this + 104;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = this + 112;
		object obj18 = default;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj19 = this + 120;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj21 = this + 128;
		object obj22 = default;
		obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v8+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+20]");
			_ = 0;
			object obj27 = this + 152;
			obj27 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj28 = this + 160;
			object obj29 = default;
			obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	static GillaSplatter()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 1;
	}
}
