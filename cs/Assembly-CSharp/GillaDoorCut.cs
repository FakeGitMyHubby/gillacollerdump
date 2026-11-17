using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

public class GillaDoorCut : MonoBehaviour
{
	private const float MostLean = default(float);

	private const float GiveUp = default(float);

	private const float GiveUpForGood = default(float);

	private const float BleedEvery = default(float);

	private const float Clear = default(float);

	private const float MostPush = default(float);

	private const float NoDoorSpeed = default(float);

	private GillaCorpse body;

	private GillaCorpse plus;

	private GillaCorpse minus;

	private GillaDoor door;

	private bool sawn;

	private GillaRip.Along along;

	private int seed;

	private int stage;

	private List<Mesh> meshes;

	private List<(Rigidbody, Vector3, Vector3)> kept;

	private float since;

	private float nextBleed;

	private float top;

	private float hips;

	private float bottom;

	private bool bleedPlus;

	private Vector3 way;

	private Vector3 pivot;

	private Vector3 axis;

	private readonly Vector3[] baseAt;

	private readonly Quaternion[] baseTurn;

	private readonly float[] push;

	private static int Cutting__BackingField;

	public static float LastReadyAfter;

	public static float LastFirstHalfMs;

	public static float LastSecondHalfMs;

	public static string LastMeshes;

	private float beganAt;

	private CancellationTokenSource dropping;

	private static int halfFrame;

	private static int halvesOpen;

	private const float Catch = default(float);

	private float madeAt;

	private const int SawnDrops = default(int);

	public static int Cutting
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0079: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
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
			return (int)obj4;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
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
			obj4 = value;
		}
	}

	public static bool MayGoMiddle
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01f5: Expected Obj, but got I
			//IL_0217: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_00aa: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I4
			//IL_01dd: Expected I4, but got Obj
			//IL_018c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaModeRound current = GillaModeRound.Current;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (GillaRip.Ready)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)current != (UnityEngine.Object)null)
				{
					if ((object)current == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (current.Live)
					{
						byte phase = current.Phase;
						int num = phase & 0xFF;
						object obj10 = num - 1;
						bool flag4 = obj10 == null;
						return !flag4;
					}
				}
				return true;
			}
			return false;
		}
	}

	private Vector3 Through
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I4
			//IL_0034: Expected VT, but got I4
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected Obj, but got Unknown
			//IL_0091: Expected VT, but got Obj
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
			Vector3 vector = (Vector3)(door != null);
			object obj4 = vector & 1;
			if (obj4 != null && (object)door == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (Vector3)ex;
			}
			return vector;
		}
	}

	private static void FreshCounts()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+A0]");
		object obj6 = 0;
		obj6 = 0;
	}

	public unsafe void Begin(GillaCorpse c, int seed, GillaRip.Along along, GillaDoor door, bool sawn = default(bool))
	{
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_0957: Expected Obj, but got I
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected Obj, but got Unknown
		//IL_0026: Expected VT, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0100: Expected VT, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got I
		//IL_0405: Expected VT, but got I4
		//IL_040f: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I4
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected F4, but got Unknown
		//IL_0be9: Expected Obj, but got I
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected Ref, but got Unknown
		//IL_0c14: Expected Obj, but got I4
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected F4, but got Unknown
		//IL_0478: Expected Obj, but got I4
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_079c: Expected VT, but got I4
		//IL_07ae: Expected Obj, but got I4
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected Obj, but got I4
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dc: Expected F4, but got Unknown
		//IL_028a: Expected Obj, but got I
		//IL_04d3: Expected I, but got Obj
		//IL_0507: Expected Obj, but got I4
		//IL_0a84: Expected Obj, but got I
		//IL_0a9f: Expected Ref, but got VT
		//IL_0abd: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I
		//IL_0341: Expected VT, but got Ref
		//IL_035d: Expected VT, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got I4
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected F4, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_059b: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected Obj, but got I4
		//IL_0c65: Expected VT, but got I4
		//IL_0b2f: Expected Obj, but got I4
		//IL_0c82: Expected Obj, but got I
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected Obj, but got Unknown
		//IL_0a0c: Expected VT, but got I4
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected Obj, but got I
		//IL_0673: Expected VT, but got I4
		//IL_0b5f: Expected Obj, but got I4
		//IL_0b99: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I4
		//IL_0655: Expected VT, but got Ref
		//IL_0ca6: Expected Obj, but got I
		//IL_0cc7: Expected Obj, but got I4
		//IL_069c: Expected VT, but got Ref
		//IL_06a9: Expected F4, but got VT
		//IL_06c9: Expected Obj, but got I
		//IL_06d6: Expected F4, but got VT
		//IL_088c: Expected Obj, but got I4
		object obj = this + 32;
		obj = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		this.seed = seed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X3 (GillaRip+Along)+10]");
		GillaDoor gillaDoor = (GillaDoor)0;
		object obj2 = this + 56;
		GillaDoor gillaDoor2 = default;
		obj2 = gillaDoor2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X3 (GillaRip+Along)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X3 (GillaRip+Along)+10]");
		_ = 0;
		_ = along.n;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag = (object)c == null;
		Vector3 vector = (Vector3)0;
		GillaRip.Along along2 = along;
		GillaDoor gillaDoor4 = default;
		GillaDoor gillaDoor3 = gillaDoor4;
		Enumerator<, > val = (Enumerator<, >)0;
		int num = seed;
		GillaDoor gillaDoor5 = gillaDoor2;
		GillaDoor gillaDoor6 = (GillaDoor)sawn;
		GillaCorpse gillaCorpse = c;
		GillaRip.Along along3 = along;
		GillaDoor gillaDoor7 = gillaDoor2;
		NullReferenceException ex5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
			gillaDoor6 = (GillaDoor)0;
			c.Pin(held: true);
			List<Mesh> list = c.CutMeshes();
			gillaDoor7 = (GillaDoor)(this + 120);
			gillaDoor7 = (GillaDoor)(object)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector();
			bool flag2 = (object)gillaDoor7 == null;
			vector = (Vector3)0;
			along2 = along;
			gillaDoor3 = gillaDoor4;
			val = (Enumerator<, >)0;
			GillaDoor gillaDoor8 = gillaDoor7;
			GillaCorpse gillaCorpse2 = c;
			num = 0;
			gillaDoor5 = null;
			gillaCorpse = (GillaCorpse)(object)stringBuilder;
			along3 = along;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				gillaDoor6 = (GillaDoor)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0480]");
				GillaDoor gillaDoor9 = (GillaDoor)0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)gillaDoor7).GetEnumerator();
				along2 = along;
				GillaDoor gillaDoor10 = gillaDoor4;
				num = 0;
				Enumerator<, > val3 = default;
				Enumerator<, > val2 = val3;
				Enumerator<, > val4 = default;
				object obj11;
				object obj12;
				Enumerator<, > val5;
				while (true)
				{
					gillaDoor5 = (GillaDoor)obj3;
					if (!val.MoveNext())
					{
						break;
					}
					if (stringBuilder != null)
					{
						int length = stringBuilder.Length;
						bool flag3 = length < 0;
						bool flag4 = length == 0;
						int num2 = length ^ length;
						int num3 = length & num2;
						bool flag5 = num3 < 0;
						bool flag6 = flag3 == flag5;
						object obj5 = !flag4;
						object obj6 = flag6 & obj5;
						object obj7 = ~obj6;
						GillaDoor gillaDoor11;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
							gillaDoor11 = (GillaDoor)0;
						}
						else
						{
							gillaDoor11 = gillaDoor6;
						}
						StringBuilder stringBuilder2 = stringBuilder.Append((string)(object)gillaDoor11);
						bool flag7 = (object)gillaDoor4 == null;
						num = 0;
						realtimeSinceStartup = (float)val2;
						gillaDoor5 = gillaDoor11;
						if (flag7)
						{
							goto IL_0786;
						}
						string text = gillaDoor4.name;
						string text2;
						if (stringBuilder2 != null)
						{
							StringBuilder stringBuilder3 = stringBuilder2.Append(text);
							object obj8 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [along @ X3 (GillaRip+Along)+10]");
							gillaDoor = (GillaDoor)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v105+E4]");
							bool flag8 = (nint)0 == 0;
							object obj9 = !flag8;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag9 = GillaRip.IsReady((Mesh)(object)gillaDoor4, seed, (GillaRip.Along)(&val4));
							bool flag10 = stringBuilder3 == null;
							along2 = (GillaRip.Along)0;
							val4 = (Enumerator<, >)along.n;
							gillaDoor10 = gillaDoor;
							num = (int)(&val4);
							val2 = (Enumerator<, >)along.n;
							text2 = (string)seed;
							if (!flag10)
							{
								bool flag11 = !flag9;
								object obj10 = !flag11;
								obj7 = ~obj10;
								GillaDoor value = ((obj7 != null) ? gillaDoor6 : gillaDoor9);
								StringBuilder stringBuilder4 = stringBuilder3.Append((string)(object)value);
								along2 = (GillaRip.Along)0;
								val4 = (Enumerator<, >)along.n;
								gillaDoor10 = gillaDoor;
								num = 0;
								val2 = (Enumerator<, >)along.n;
								continue;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
							num = 0;
							text2 = text;
						}
						NullReferenceException ex2 = new NullReferenceException();
						gillaDoor5 = (GillaDoor)(object)text2;
					}
					NullReferenceException ex3 = new NullReferenceException();
					realtimeSinceStartup = (float)val2;
					goto IL_0786;
					IL_0786:
					NullReferenceException ex4 = new NullReferenceException();
					vector = (Vector3)0;
					gillaDoor3 = gillaDoor10;
					obj11 = 0;
					val = val3;
					obj12 = 0;
					val5 = (Enumerator<, >)(ref val);
					gillaDoor8 = gillaDoor7;
					gillaCorpse2 = c;
					gillaCorpse = (GillaCorpse)(object)stringBuilder;
					along3 = along;
					gillaDoor7 = gillaDoor9;
					goto IL_07f4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
				object obj13 = 0;
				vector = (Vector3)0;
				object obj14 = 0;
				obj11 = 0;
				val = val3;
				obj12 = 0;
				val5 = (Enumerator<, >)(ref val);
				gillaDoor8 = gillaDoor7;
				gillaCorpse2 = c;
				realtimeSinceStartup = (float)val2;
				gillaCorpse = (GillaCorpse)(object)stringBuilder;
				along3 = along;
				GillaCorpse gillaCorpse3 = default;
				CancellationTokenSource cancellationTokenSource = default;
				Enumerator<, > val6 = default;
				float num5 = default;
				object obj34 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
					object obj15 = 0;
					gillaDoor5 = (GillaDoor)obj15;
					((Enumerator<, >*)val5)->Dispose();
					bool flag12 = obj14 == null;
					object obj16 = !flag12;
					gillaDoor3 = gillaDoor10;
					gillaDoor7 = gillaDoor9;
					if (obj16 != null)
					{
						break;
					}
					bool flag13 = obj11 == null;
					object obj17 = !flag13;
					gillaDoor3 = gillaDoor10;
					ex5 = (NullReferenceException)val5;
					gillaDoor7 = gillaDoor9;
					if (obj17 == null)
					{
						bool flag14 = (object)gillaCorpse == null;
						gillaDoor3 = gillaDoor10;
						gillaDoor7 = gillaDoor9;
						if (!flag14)
						{
							nint num4 = (nint)gillaCorpse;
							((object)gillaCorpse).Finalize();
							object obj18 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v10+E4]");
							bool flag15 = (nint)0 == 0;
							object obj19 = !flag15;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj18 = obj13;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v10+A0]");
							object obj20 = (nint)0 + (nint)16;
							obj20 = gillaCorpse3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool isMiddle = ((GillaRip.Along*)along3)->IsMiddle;
							bool flag16 = !isMiddle;
							object obj21 = !flag16;
							gillaDoor5 = null;
							gillaCorpse = gillaCorpse3;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7050]");
								object obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								cancellationTokenSource._002Ector();
								object obj23 = this + 232;
								obj23 = cancellationTokenSource;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj24 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X0_v39+E4]");
								bool flag17 = (nint)0 == 0;
								object obj25 = !flag17;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj26 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v45+E4]");
								bool flag18 = (nint)0 == 0;
								object obj27 = !flag18;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj26 = obj13;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v45+A0]");
								object obj28 = 0;
								gillaDoor6 = (GillaDoor)(obj28 + 1);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v45+E4]");
								bool flag19 = (nint)0 == 0;
								object obj29 = !flag19;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj26 = obj13;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v45+A0]");
								object obj30 = 0;
								obj30 = gillaDoor6;
								gillaDoor5 = (GillaDoor)(object)cancellationTokenSource;
								gillaCorpse = (GillaCorpse)(object)cancellationTokenSource;
								gillaDoor9 = (GillaDoor)109895680;
							}
							bool flag20 = (object)gillaDoor8 == null;
							gillaDoor3 = gillaDoor10;
							gillaDoor7 = gillaDoor9;
							if (!flag20)
							{
								Enumerator<, > enumerator2 = ((List<System.__Canon>)(object)gillaDoor8).GetEnumerator();
								realtimeSinceStartup = (float)val6;
								while (true)
								{
									object obj31 = obj3;
									if (!val.MoveNext())
									{
										break;
									}
									GillaRip.Along along4;
									CancellationToken cancellationToken;
									if (dropping != null)
									{
										CancellationToken token = dropping.Token;
										vector = along3.n;
										obj31 = 0;
										along4 = (GillaRip.Along)(&vector);
										cancellationToken = token;
									}
									else
									{
										along4 = along3;
										cancellationToken = (CancellationToken)0;
									}
									object obj32 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v29+E4]");
									bool flag21 = (nint)0 == 0;
									object obj33 = !flag21;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									GillaRip.Begin((Mesh)(object)gillaDoor10, seed, (GillaRip.Along)(&num5), cancellationToken);
									num5 = (float)along4.n;
									along2 = (GillaRip.Along)cancellationToken;
									num = (int)(&num5);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X8_v21 (GillaRip+Along)+10]");
									gillaDoor = (GillaDoor)0;
									realtimeSinceStartup = (float)along4.n;
									gillaDoor9 = gillaDoor10;
								}
								val.Dispose();
								gillaDoor3 = null;
								val = val6;
								gillaDoor5 = (GillaDoor)(object)gillaCorpse2;
								gillaDoor6 = (GillaDoor)14;
								along3 = (GillaRip.Along)0;
								gillaDoor7 = gillaDoor9;
								OutOfMemoryException ex6 = new OutOfMemoryException();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
								obj13 = 0;
								if ((nint)gillaDoor5 == 2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									gillaDoor10 = gillaDoor3;
									obj14 = obj12;
									obj11 = 1;
									gillaDoor9 = gillaDoor7;
									continue;
								}
								if ((nint)gillaDoor5 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj14 = obj34;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									gillaDoor10 = gillaDoor3;
									obj12 = obj34;
									gillaDoor9 = gillaDoor7;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
						}
						goto IL_07f4;
					}
					goto IL_0802;
				}
				goto IL_0811;
			}
		}
		goto IL_07f4;
		IL_0802:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0811;
		IL_0811:
		throw new OutOfMemoryException();
		IL_07f4:
		ex5 = new NullReferenceException();
		goto IL_0802;
	}

	private void Frame(GillaCorpse c)
	{
		//IL_0156: Expected VT, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01a7: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		//IL_01df: Expected VT, but got I4
		//IL_0217: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b8: Expected VT, but got Obj
		//IL_02f0: Expected Obj, but got I
		//IL_0308: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03aa: Expected VT, but got Obj
		//IL_03d4: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got VT
		//IL_0446: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I
		//IL_05bc: Expected Obj, but got I4
		//IL_047d: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04ba: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected VT, but got Unknown
		//IL_053a: Expected VT, but got Obj
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_0139: Expected VT, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected VT, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		Bounds boxNow = c.BoxNow;
		float topNow = c.TopNow;
		object obj = default;
		object obj2 = default;
		float num = (float)obj - (float)obj2;
		top = topNow;
		hips = num;
		Transform transform = c.transform;
		Vector3 position = transform.position;
		float num3 = default;
		float num2 = ((!(num < num3)) ? num3 : num);
		bottom = num2;
		Vector3 vector = c.WorldWay((Vector3)0);
		way = (Vector3)this.along;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+48]");
		_ = 0;
		GillaRip.Along along = this.along;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+68]");
		object obj3 = along * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+48]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+68]");
		object obj4 = num4 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+4C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+4C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+68]");
		object obj5 = num5 * 0;
		Vector3 vector2 = c.WorldPoint((Vector3)0);
		object obj7 = default;
		object obj6 = obj7 - obj3;
		object obj8 = obj - obj4;
		Vector3 vector3 = way;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A4]");
		object obj9 = 0;
		object obj11 = default;
		object obj10 = obj11 - obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
		object obj12 = 0;
		object obj13 = way * obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A4]");
		object obj14 = obj8 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
		object obj15 = obj10 * 0;
		object obj16 = obj13 + obj14;
		object obj17 = obj15 + obj16;
		object obj18 = way * obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
		object obj19 = 0 * obj17;
		Vector3 vector4 = (Vector3)(obj7 - obj18);
		object obj20 = obj11 - obj19;
		pivot = vector4;
		_ = bottom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v14+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+18]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+18]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
		object obj25 = num6 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+1C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
		object obj26 = num7 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+20]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A4]");
		object obj27 = num8 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+20]");
		object obj28 = 0 * way;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+1C]");
		object obj29 = 0 * way;
		Vector3 vector5 = (Vector3)(obj26 - obj27);
		object obj30 = obj28 - obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v1+18]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A4]");
		object obj31 = num9 * 0;
		object obj32 = obj31 - obj29;
		object obj33 = vector5 * vector5;
		object obj34 = obj30 * obj30;
		axis = vector5;
		object obj35 = obj33 + obj34;
		object obj36 = obj32 * obj32;
		object obj37 = obj36 + obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		object obj38 = 0;
		object obj39 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj39 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v14+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+4C]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+48]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+4C]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
			obj26 = num10 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+50]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A4]");
			obj27 = num11 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+50]");
			obj38 = 0 * way;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+48]");
			obj12 = 0 * obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+48]");
			obj9 = 0 * obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v15+4C]");
			vector3 = 0 * vector3;
			Vector3 vector6 = (Vector3)(obj26 - obj27);
			object obj41 = obj38 - obj12;
			obj32 = obj9 - vector3;
			axis = vector6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj42 = 0;
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj44 = !flag;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj45 = obj32 * obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		Vector3 vector8;
		if ((nint)obj45 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Vector3 vector7 = axis;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			vector8 = vector7 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+C0]");
			object obj46 = 0 / obj45;
		}
		else
		{
			object obj46 = 0;
			vector8 = (Vector3)0;
		}
		axis = vector8;
	}

	private void Counted()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		object obj = this + 232;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
			object obj2 = 0;
			((CancellationTokenSource)obj).Dispose();
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+A0]");
			object obj7 = 0;
			object obj8 = obj7 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v12+A0]");
			object obj10 = 0;
			obj10 = obj8;
		}
	}

	private unsafe void GoMiddle()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected I, but got Obj
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected I4, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got I4
		//IL_014a: Expected VT, but got Ref
		//IL_0153: Expected VT, but got I4
		//IL_015b: Expected VT, but got Ref
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected I, but got Obj
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Ref, but got Unknown
		//IL_0605: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE6FB]");
		int num = 0;
		if (dropping != null)
		{
			dropping.Cancel();
			nint num2 = unchecked((nint)null);
		}
		bool flag = (object)meshes == null;
		Mesh mesh2 = default;
		Mesh mesh = mesh2;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
			object obj3 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)meshes).GetEnumerator();
			mesh = mesh2;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			Mesh mesh3 = mesh2;
			Enumerator<, > val5 = default;
			while (val.MoveNext())
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+54]");
				Mesh mesh4 = (Mesh)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+64]");
				mesh3 = (Mesh)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v50+E4]");
				val2 = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v50+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaRip.Forget(mesh2, seed, (GillaRip.Along)(&val5));
				CancellationToken cancellationToken = (CancellationToken)0;
				GillaRip.Along along = (GillaRip.Along)(&val5);
				mesh = mesh4;
				val3 = (Enumerator<, >)this.along;
			}
			nint num2 = (nint)obj3;
			val.Dispose();
			int num3 = 5;
			int num4 = 0;
			val = val4;
			object obj6 = 0;
			Enumerator<, > val6 = (Enumerator<, >)(ref val);
			num = (int)mesh3;
			object obj8 = default;
			while (true)
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					object obj7;
					if (num2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num4 = 1;
						num = 1;
						obj7 = obj6;
					}
					else
					{
						if (num2 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj6 = obj8;
					}
					num2 = (nint)obj3;
					((Enumerator<, >*)val6)->Dispose();
					bool flag3 = obj7 == null;
					object obj9 = !flag3;
					if (obj9 != null)
					{
						break;
					}
					bool flag4 = num4 == 0;
					object obj10 = !flag4;
					ex = (OutOfMemoryException)val6;
					if (obj10 == null)
					{
						Frame(body);
						return;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private float Edge()
	{
		//IL_0024: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		if (~(sawn ? 1u : 0u) == 0)
		{
			return hips;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (door != null)
		{
			Vector3 foot = door.Foot;
			GillaDoor gillaDoor = door;
			float num = door.Height();
			float num2 = gillaDoor.rise * num;
			object obj4 = default;
			return (float)obj4 + num2;
		}
		double num3 = (double)since * -1.5;
		return top + (float)num3;
	}

	private unsafe bool Ready()
	{
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Ref
		//IL_01aa: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got I4
		//IL_03b3: Expected I, but got Obj
		//IL_03d6: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I4
		//IL_011c: Expected VT, but got Ref
		//IL_013a: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_014b: Expected VT, but got Ref
		//IL_015d: Expected Obj, but got I4
		//IL_0165: Expected VT, but got Ref
		//IL_01ec: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got Ref
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected I4, but got Unknown
		//IL_02b4: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
		object obj3 = 0;
		Enumerator<, > enumerator = ((List<System.__Canon>)(object)meshes).GetEnumerator();
		object obj5 = default;
		object obj4 = obj5;
		GillaRip.Along along2 = default;
		GillaRip.Along along = along2;
		object obj7 = default;
		object obj6 = obj7;
		int num2 = default;
		int num = num2;
		object obj9 = default;
		object obj8 = obj9;
		GillaRip.Along along4 = default;
		GillaRip.Along along3 = along4;
		Enumerator<, > val = default;
		object obj10 = (object)(&val);
		bool flag;
		GillaRip.Along along7 = default;
		object obj17;
		do
		{
			flag = val.MoveNext();
			bool flag2 = !flag;
			object obj11 = obj4;
			GillaRip.Along along5 = along;
			object obj12 = obj6;
			int num3 = num;
			object obj13 = obj8;
			GillaRip.Along along6 = along3;
			object obj14 = obj10;
			if (flag2)
			{
				break;
			}
			object obj15 = obj2;
			along6 = this.along;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+54]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+64]");
			obj14 = 0;
			num3 = seed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v29+E4]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v29+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = GillaRip.IsReady(null, num3, (GillaRip.Along)(&along7));
			bool flag5 = !flag4;
			obj17 = !flag5;
			obj11 = 0;
			along5 = (GillaRip.Along)(&along7);
			along7 = along6;
			obj4 = 0;
			along = (GillaRip.Along)(&along7);
			obj6 = obj12;
			num = num3;
			obj8 = obj13;
			along3 = along6;
			obj10 = obj14;
		}
		while (obj17 != null);
		object obj18 = (flag ? 1 : 0) ^ 1;
		object obj19 = 0;
		object obj20 = 0;
		Enumerator<, > val2 = (Enumerator<, >)(ref val);
		object obj21 = 0;
		object obj24 = default;
		object obj25 = default;
		IntPtr intPtr = default;
		object obj26 = default;
		object obj27 = default;
		bool result = default;
		while (true)
		{
			nint num4 = (nint)obj3;
			val.Dispose();
			bool flag6 = obj21 == null;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				bool flag7 = obj19 == null;
				object obj23 = !flag7;
				OutOfMemoryException ex = (OutOfMemoryException)(&val);
				if (obj23 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				object obj11 = obj5;
				GillaRip.Along along5 = along2;
				object obj13 = obj9;
				GillaRip.Along along6 = along4;
				obj19 = obj24;
				obj20 = obj25;
				num4 = intPtr;
				obj3 = obj26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch ((long)num4)
			{
			case 2L:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj19 = 1;
				object obj14 = 1;
				obj21 = obj20;
				break;
			}
			case 1L:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj21 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj20 = obj27;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			obj18 = 1;
		}
		return (byte)(obj18 & 1) != 0;
	}

	private static void FreshTurns()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
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
		_ = 4294967295L;
	}

	private unsafe void OnDestroy()
	{
		//IL_0015: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I4
		//IL_01ba: Expected Obj, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_0402: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_0286: Expected I, but got Obj
		//IL_0192: Expected VT, but got Ref
		//IL_019b: Expected Obj, but got I4
		//IL_01a3: Expected VT, but got Ref
		//IL_01f3: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got Ref
		//IL_02dc: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		int num = stage;
		if (stage == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				num = 1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				num = stage;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v38+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v4+1C]");
			object obj4 = -1;
		}
		if (num == 0 && dropping != null && (object)meshes != null)
		{
			dropping.Cancel();
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)meshes).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj6 = 0;
			object obj8 = default;
			object obj7 = obj8;
			GillaRip.Along along2 = default;
			GillaRip.Along along = along2;
			object obj10 = default;
			object obj9 = obj10;
			GillaRip.Along along4 = default;
			GillaRip.Along along3 = along4;
			Enumerator<, > val = default;
			GillaRip.Along along5 = default;
			while (val.MoveNext())
			{
				object obj11 = obj6;
				along3 = this.along;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+54]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj12 = !flag;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaRip.Forget(null, seed, (GillaRip.Along)(&along5));
				obj7 = 0;
				along = (GillaRip.Along)(&along5);
			}
			object obj13 = 0;
			object obj14 = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			object obj15 = 3;
			object obj16 = 0;
			object obj20 = default;
			object obj21 = default;
			object obj22 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
				object obj17 = 0;
				nint num2 = (nint)obj17;
				val.Dispose();
				bool flag2 = obj16 == null;
				object obj18 = !flag2;
				if (obj18 == null)
				{
					bool flag3 = obj13 == null;
					object obj19 = !flag3;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					if (obj19 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					obj7 = obj8;
					along = along2;
					obj9 = obj10;
					along3 = along4;
					obj13 = obj20;
					obj14 = obj21;
					num2 = unchecked((nint)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				switch ((long)num2)
				{
				case 2L:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj13 = 1;
					obj16 = obj14;
					break;
				case 1L:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj16 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = obj22;
					break;
				default:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				obj15 = 0;
			}
			if ((nint)obj15 != 3 && obj15 != null)
			{
				return;
			}
		}
		Counted();
	}

	private unsafe void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_0128: Invalid comparison between F4 and I4
		//IL_0137: Expected F8, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_07a0: Expected Obj, but got I4
		//IL_0bdd: Expected Obj, but got I
		//IL_0bb0: Invalid comparison between F4 and I4
		//IL_0bbf: Expected F8, but got I4
		//IL_01cf: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_08ae: Expected Obj, but got I4
		//IL_0ad1: Expected Obj, but got I
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected VT, but got Unknown
		//IL_07c7: Expected Ref, but got VT
		//IL_07e5: Expected Obj, but got I4
		//IL_04a5: Expected Obj, but got I4
		//IL_0c1a: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_0808: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got I4
		//IL_0b0e: Expected Obj, but got I
		//IL_0b1e: Expected Obj, but got I
		//IL_0b3c: Expected Obj, but got I
		//IL_0b73: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I4
		//IL_0935: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02c9: Expected VT, but got I4
		//IL_02c9: Expected VT, but got Ref
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_0c4f: Expected Obj, but got I
		//IL_0c6d: Expected Obj, but got I
		//IL_0c9e: Expected Obj, but got I
		//IL_0cc5: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_038a: Expected Obj, but got I
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Ref, but got Unknown
		//IL_056e: Expected VT, but got Ref
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_05b1: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I4
		//IL_0628: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I
		//IL_09e2: Expected F8, but got I
		//IL_09f2: Invalid comparison between F8 and I
		//IL_0a03: Expected Obj, but got I4
		//IL_0a23: Invalid comparison between F8 and I4
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (body == null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v105+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(this);
			return;
		}
		float deltaTime = Time.deltaTime;
		float num = since + deltaTime;
		since = num;
		float num2 = Edge();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		object obj6 = 0;
		double num3 = (double)top - (double)hips;
		float num4 = top - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num5 = num4 / (float)num3;
		bool flag3 = num5 < 0f;
		double num6 = 0.0;
		if (!flag3)
		{
			bool flag4 = !((double)num5 > 1.0);
			num3 = 1.0;
			num6 = num5;
			if (!flag4)
			{
				num3 = 1.0;
				num6 = 1.0;
			}
		}
		Bleed(num2);
		TimeSpan timeSpan = default;
		if (stage != 0)
		{
			float num7;
			float num8;
			if (stage == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v74+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v74+A0]");
				object obj10 = 0;
				int frameCount = Time.frameCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v39+18]");
				if ((nint)0 == frameCount)
				{
					return;
				}
				int frameCount2 = Time.frameCount;
				object obj11 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v41+E4]");
				bool flag6 = (nint)0 == 0;
				object obj12 = !flag6;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v41+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v42+1C]");
				object obj16 = -1;
				stage = 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v80+E4]");
				bool flag7 = (nint)0 == 0;
				object obj17 = !flag7;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Stopwatch stopwatch = Stopwatch.StartNew();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+54]");
				obj6 = 0;
				object obj18 = default;
				GillaCorpse gillaCorpse = body.SecondHalf(plus, kept, seed, (GillaRip.Along)(&obj18), (Vector3)0);
				object obj19 = this + 48;
				obj19 = gillaCorpse;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				TimeSpan elapsed = stopwatch.Elapsed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
				object obj20 = 0;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v47+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalMilliseconds = timeSpan.TotalMilliseconds;
				object obj23 = obj7;
				object obj24 = this + 128;
				kept = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v48+A0]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Hold(plus, 0);
				Hold(minus, 1);
				Own();
				num7 = since;
				madeAt = since;
				num8 = since;
			}
			else
			{
				num8 = since;
				num7 = madeAt;
			}
			float num9 = num8 - num7;
			float num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num11 = num10 / 0f;
			bool flag9 = num11 < 0f;
			double num12 = 0.0;
			if (!flag9)
			{
				bool flag10 = !((double)num11 > 1.0);
				num12 = num11;
				if (!flag10)
				{
					num12 = 1.0;
				}
			}
			double num13 = ((!(num6 < num12)) ? num12 : num6);
			double num14 = num13 + num13;
			double num15 = num13 * num13;
			double num16 = 3.0 - num14;
			double num17 = num15 * num16;
			Place(plus, 0, (float)num17, 1f);
			GillaCorpse gillaCorpse2 = minus;
			Place(minus, 1, (float)num17, -1f);
			bool flag11 = !(num13 < 1.0);
			double num18 = -1.0;
			double num19 = num17;
			int num20 = 1;
			if (!flag11)
			{
				num18 = since;
				bool flag12 = !((double)since > 4.5);
				num19 = 4.5;
				num20 = 1;
				if (flag12)
				{
					object obj26 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v67+E4]");
					bool flag13 = (nint)0 == 0;
					object obj27 = !flag13;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!(door != null))
					{
						return;
					}
					GillaDoor gillaDoor = door;
					float num21 = door.Height();
					if (num12 < 1.0)
					{
						return;
					}
					num19 = (double)gillaDoor.rise * (double)num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					num18 = 0.0;
					double num22 = num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					bool flag14 = num22 < 0.0;
					object obj28 = !flag14;
					double num23 = num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					double num24 = num23 - 0.0;
					bool flag15 = num24 == 0.0;
					object obj29 = ~obj28;
					object obj30 = obj29 | flag15;
					num20 = 0;
					gillaCorpse2 = null;
					if (obj30 == null)
					{
						return;
					}
				}
			}
			LetGo();
			object obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v63+E4]");
			bool flag16 = (nint)0 == 0;
			object obj32 = !flag16;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(this);
			return;
		}
		bool flag17 = Ready();
		bool flag18 = !flag17;
		UnityEngine.Object obj33 = null;
		if (flag18)
		{
			num5 = since;
			if ((double)since < 3.0)
			{
				return;
			}
			bool flag19 = (byte)(~(sawn ? 1u : 0u)) != 0;
			object obj34 = !flag19;
			obj33 = null;
			if (obj34 == null)
			{
				GillaRip.Along along = (GillaRip.Along)(this + 68);
				bool isMiddle = ((GillaRip.Along*)along)->IsMiddle;
				bool flag20 = !isMiddle;
				object obj35 = !flag20;
				obj33 = null;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
					object obj36 = 0;
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v20+E4]");
					bool flag21 = (nint)0 == 0;
					object obj38 = !flag21;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool mayGoMiddle = MayGoMiddle;
					bool flag22 = !mayGoMiddle;
					obj33 = null;
					if (!flag22)
					{
						GoMiddle();
						obj33 = null;
					}
				}
			}
			bool flag23 = Ready();
			bool flag24 = !flag23;
			object obj39 = !flag24;
			num2 = 3f;
			if (obj39 == null)
			{
				num5 = since;
				bool flag25 = !((double)since < 15.0);
				num2 = 15f;
				if (!flag25)
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
		object obj40 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v26+E4]");
		bool flag26 = (nint)0 == 0;
		object obj42 = !flag26;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj41 = obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v26+A0]");
		object obj43 = 0;
		int frameCount3 = Time.frameCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v15+18]");
		if ((nint)0 == frameCount3)
		{
			return;
		}
		object obj44 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v30+E4]");
		bool flag27 = (nint)0 == 0;
		object obj45 = !flag27;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj44 = obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X0_v30+A0]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v17+1C]");
		if ((nint)0 <= (nint)0)
		{
			Counted();
			int frameCount4 = Time.frameCount;
			object obj47 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v20+E4]");
			bool flag28 = (nint)0 == 0;
			object obj48 = !flag28;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj47 = obj40;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v20+A0]");
			object obj49 = 0;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
			object obj50 = 0;
			object obj51 = obj40;
			float num25 = realtimeSinceStartup - beganAt;
			object obj52 = obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X9_v4+A0]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X0_v36+E4]");
			bool flag29 = (nint)0 == 0;
			object obj54 = !flag29;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Stopwatch stopwatch2 = Stopwatch.StartNew();
			object obj55 = default;
			GillaCorpse gillaCorpse3 = body.FirstHalf(seed, (GillaRip.Along)(&obj55), out *(List<(Rigidbody, Vector3, Vector3)>*)(this + 128));
			object obj56 = this + 40;
			obj56 = gillaCorpse3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			TimeSpan elapsed2 = stopwatch2.Elapsed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
			object obj57 = 0;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v28+E4]");
			bool flag30 = (nint)0 == 0;
			object obj59 = !flag30;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double totalMilliseconds2 = timeSpan.TotalMilliseconds;
			object obj60 = obj40;
			stage = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v29+A0]");
			object obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v30+1C]");
			object obj62 = (nint)0 + (nint)1;
		}
	}

	private void Bleed(float edge)
	{
		//IL_00b8: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_01f7: Expected F4, but got VT
		//IL_01f7: Expected VT, but got I4
		//IL_01f7: Expected VT, but got Obj
		if (~(sawn ? 1u : 0u) == 0)
		{
			SawnBleed();
			return;
		}
		float time = Time.time;
		if (time < nextBleed || top < edge || bottom > edge)
		{
			return;
		}
		float time2 = Time.time;
		GillaCorpse gillaCorpse = body;
		float num = time2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		float num2 = (nextBleed = num + 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = gillaCorpse.blood == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			bool flag4 = !bleedPlus;
			bool flag5 = (byte)((bleedPlus ? 1u : 0u) ^ 1u) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
			object obj5 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			bleedPlus = flag5;
			object obj6 = !flag4;
			object obj7 = ~obj6;
			object obj8;
			if (obj7 == null)
			{
				obj8 = obj5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B42C");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
			float num4 = num3 * 0f;
			Vector3 vector = way;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			object obj9 = vector * 0;
			float num5 = num2 + num4;
			object obj10 = obj8 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Blood.Burst((Vector3)gillaCorpse.blood, (Vector3)0, null, (float)pivot);
		}
	}

	private void SawnBleed()
	{
		//IL_0017: Invalid comparison between F4 and I
		//IL_003b: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_0334: Expected F8, but got I
		//IL_036d: Expected VT, but got I4
		//IL_037a: Expected VT, but got I4
		//IL_04a2: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_056e: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_0507: Expected Obj, but got I
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05cb: Expected Obj, but got I
		//IL_05f5: Expected Obj, but got I4
		//IL_0300: Expected VT, but got F4
		//IL_0316: Expected Obj, but got I4
		//IL_031f: Expected VT, but got I4
		//IL_044e: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_061b: Expected VT, but got I4
		//IL_061b: Expected VT, but got I4
		float time = Time.time;
		if (time < nextBleed)
		{
			return;
		}
		float num = since;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		if (num > 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = body == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		float time2 = Time.time;
		GillaCorpse gillaCorpse = body;
		float num2 = time2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
		float num3 = (nextBleed = num2 + 0f);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gillaCorpse.blood == null)
		{
			return;
		}
		object obj7 = obj;
		bool flag5 = (byte)((bleedPlus ? 1u : 0u) ^ 1u) != 0;
		bleedPlus = flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = plus != null;
		bool flag8 = !flag7;
		object obj9 = 0;
		double num7;
		GillaRip.Along along;
		double num5;
		Vector3 vector;
		if (!flag8)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v42+E4]");
			bool flag9 = (nint)0 == 0;
			object obj11 = !flag9;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = minus != null;
			bool flag11 = !flag10;
			obj9 = 0;
			if (!flag11)
			{
				Transform transform = plus.transform;
				Vector3 position = transform.position;
				Transform transform2 = minus.transform;
				Vector3 position2 = transform2.position;
				float num4 = num3 + num3;
				object obj12 = default;
				num5 = (double)obj12 + (double)obj12;
				float num6 = num4 * 0.5f;
				along = (GillaRip.Along)num6;
				num7 = 0.5;
				obj9 = 0;
				vector = (Vector3)0;
				goto IL_0491;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+68]");
		num7 = 0.0;
		along = this.along;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+4C]");
		double num8 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+68]");
		num5 = num8 * 0.0;
		Vector3 vector2 = body.WorldPoint((Vector3)0);
		vector = (Vector3)0;
		goto IL_0491;
		IL_0491:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
		object obj13 = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj14;
		if (!bleedPlus)
		{
			obj14 = obj13;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+A8]");
			obj14 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v16+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v17+18]");
		object obj19 = default;
		object obj18 = 0 * obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v17+20]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		object obj20 = num9 * 0;
		object obj21 = way + obj18;
		object obj22 = obj14 + obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v23+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26 = obj21 * obj21;
		object obj27 = obj22 * obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj28 = obj26 + obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if ((nint)obj28 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj29 = obj21 / 0;
		}
		else
		{
			object obj30 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v29+A0]");
			object obj31 = 0;
			object obj29 = obj31;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj32 = 0;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v25+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int bits = default;
		Blood.Chain((Vector3)16, (Vector3)1, 0, bits);
	}

	private void Hold(GillaCorpse half, int i)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0720: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_026a: Expected Obj, but got I4
		//IL_0388: Unsupported input type for neg.
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I8
		//IL_03be: Expected Obj, but got I4
		//IL_084f: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_0368: Expected F8, but got I
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_07c6: Expected Obj, but got I4
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_060c: Invalid comparison between F8 and I4
		//IL_061b: Expected F8, but got I4
		//IL_0593: Invalid comparison between F8 and I4
		//IL_05a2: Expected F8, but got I4
		//IL_0639: Invalid comparison between F8 and I
		//IL_0688: Expected Obj, but got I4
		//IL_0697: Expected Obj, but got I4
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_05c0: Invalid comparison between F8 and I
		//IL_0668: Expected F8, but got I
		//IL_05ef: Expected F8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = half == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		float[] array3;
		GillaDoor gillaDoor;
		object obj25;
		object obj26;
		if ((object)half != null)
		{
			Vector3[] array = baseAt;
			Transform transform = half.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				if (baseAt != null)
				{
					bool flag4 = array.Length < i;
					object obj5 = !flag4;
					object obj6 = array.Length - i;
					bool flag5 = obj6 == null;
					object obj7 = ~obj5;
					object obj8 = obj7 | flag5;
					if (obj8 != null)
					{
						goto IL_06ef;
					}
					object obj9 = i * 12;
					object obj10 = (object)baseAt + obj9;
					Quaternion[] array2 = baseTurn;
					Transform transform2 = half.transform;
					if ((object)transform2 != null)
					{
						Quaternion rotation = transform2.rotation;
						if (baseTurn != null)
						{
							bool flag6 = array2.Length < i;
							object obj11 = !flag6;
							object obj12 = array2.Length - i;
							bool flag7 = obj12 == null;
							object obj13 = ~obj11;
							object obj14 = obj13 | flag7;
							if (obj14 != null)
							{
								goto IL_06ef;
							}
							object obj15 = baseTurn + i;
							object obj16 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v17+E4]");
							bool flag8 = (nint)0 == 0;
							object obj17 = !flag8;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (door == null)
							{
								array3 = push;
								if (push != null)
								{
									bool flag9 = array3.Length < i;
									object obj18 = !flag9;
									object obj19 = array3.Length - i;
									bool flag10 = obj19 == null;
									object obj20 = ~obj18;
									object obj21 = obj20 | flag10;
									if (obj21 == null)
									{
										bool flag11 = i == 0;
										object obj22 = 17281024 + 3288;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X10_v7+v458 @ Z_v21 (System.Boolean)*4]");
										double num = 0.0;
										goto IL_06ca;
									}
									goto IL_06ef;
								}
							}
							else
							{
								Bounds boxNow = half.BoxNow;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj24 = default;
								object obj23 = 0 - obj24;
								gillaDoor = door;
								obj25 = 2139095039;
								obj26 = 4286578687L;
								object obj28 = default;
								object obj27 = obj28;
								object obj29 = 0;
								object obj36 = default;
								object obj38 = default;
								object obj40 = default;
								object obj43 = default;
								while (true)
								{
									bool flag12 = (nint)obj29 < 4;
									object obj30 = !flag12;
									object obj31 = ~obj30;
									object obj32 = ~obj31;
									object obj33 = ((obj32 != null) ? obj24 : obj23);
									if ((object)gillaDoor == null)
									{
										break;
									}
									Vector3 foot = gillaDoor.Foot;
									gillaDoor = door;
									if ((object)door == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									object obj34 = door + 324;
									obj29++;
									object obj35 = obj36 + obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCB8]");
									object obj37 = obj38 & 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									object obj39 = obj35 - obj40;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v25 (GillaDoor)+14C]");
									object obj41 = obj39 * 0;
									object obj42 = obj43 + obj37;
									object obj44 = obj42 - obj27;
									object obj45 = obj44 * obj34;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									obj27 = obj41 + obj45;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27))
									{
										obj25 = obj27;
									}
									object obj46 = obj26 - obj27;
									bool flag13 = (nint)obj46 < 0;
									bool flag14 = obj46 == null;
									object obj47 = obj26 ^ obj27;
									object obj48 = obj26 ^ obj46;
									object obj49 = obj47 & obj48;
									bool flag15 = (nint)obj49 < 0;
									bool flag16 = flag13 == flag15;
									object obj50 = !flag14;
									object obj51 = flag16 & obj50;
									object obj52 = ~obj51;
									if (obj52 != null)
									{
										obj26 = obj27;
									}
									if ((nint)obj29 != 8)
									{
										continue;
									}
									goto IL_0514;
								}
							}
						}
					}
				}
			}
		}
		goto IL_06e1;
		IL_0514:
		array3 = push;
		double num2 = (double)gillaDoor.Thickness__BackingField * 0.5;
		object obj53 = obj26 + obj25;
		double num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
		double num4 = num3 + 0.0;
		if ((nint)obj53 < 0)
		{
			double num5 = (double)obj26 + num4;
			bool flag17 = num5 < 0.0;
			double num6 = 0.0;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				bool flag18 = !(num5 > 0.0);
				num6 = num5;
				if (!flag18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num6 = 0.0;
				}
			}
			double num = 0.0 - num6;
		}
		else
		{
			double num7 = num4 - (double)obj25;
			bool flag19 = num7 < 0.0;
			double num = 0.0;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				bool flag20 = !(num7 > 0.0);
				num = num7;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
					num = 0.0;
				}
			}
		}
		if (array3 == null)
		{
			goto IL_06e1;
		}
		bool flag21 = array3.Length < i;
		object obj54 = !flag21;
		object obj55 = array3.Length - i;
		bool flag22 = obj55 == null;
		object obj56 = ~obj54;
		object obj57 = obj56 | flag22;
		if (obj57 == null)
		{
			goto IL_06ca;
		}
		goto IL_06ef;
		IL_06e1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06ef;
		IL_06ca:
		object obj58 = array3 + i;
		return;
		IL_06ef:
		throw new IndexOutOfRangeException();
	}

	private void Place(GillaCorpse half, int i, float k, float side)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0123: Expected VT, but got I4
		//IL_0123: Expected VT, but got I4
		//IL_017a: Expected Obj, but got I4
		//IL_0189: Expected Obj, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_0200: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0300: Expected VT, but got I4
		//IL_0300: Expected VT, but got I4
		//IL_0310: Expected Obj, but got I
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0375: Expected VT, but got I4
		//IL_03a0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = half == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		float num = k * 8f;
		float angle = num * side;
		Vector3 vector = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(angle, ref vector);
		Vector3[] array = baseAt;
		if (baseAt != null)
		{
			bool flag4 = array.Length < i;
			object obj5 = !flag4;
			object obj6 = array.Length - i;
			bool flag5 = obj6 == null;
			object obj7 = ~obj5;
			object obj8 = obj7 | flag5;
			if (obj8 != null)
			{
				goto IL_03b4;
			}
			Vector3 vector2 = (Quaternion)0 * (Vector3)0;
			Vector3 through = Through;
			float[] array2 = push;
			if (push != null)
			{
				bool flag6 = array2.Length < i;
				object obj9 = !flag6;
				object obj10 = array2.Length - i;
				bool flag7 = obj10 == null;
				object obj11 = ~obj9;
				object obj12 = obj11 | flag7;
				if (obj12 != null)
				{
					goto IL_03b4;
				}
				Quaternion[] array3 = baseTurn;
				if (baseTurn != null)
				{
					bool flag8 = array3.Length < i;
					object obj13 = !flag8;
					object obj14 = array3.Length - i;
					bool flag9 = obj14 == null;
					object obj15 = ~obj13;
					object obj16 = obj15 | flag9;
					if (obj16 != null)
					{
						goto IL_03b4;
					}
					if ((object)half != null)
					{
						Transform transform = half.transform;
						if ((object)transform != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
							object obj19 = default;
							object obj18 = obj19 & 1;
							if (obj18 == null)
							{
								return;
							}
							Rigidbody rigidbody = default;
							if ((object)rigidbody != null)
							{
								rigidbody.position = (Vector3)0;
								if ((object)rigidbody != null)
								{
									rigidbody.rotation = (Quaternion)0;
									return;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_03b4;
		IL_03b4:
		throw new IndexOutOfRangeException();
	}

	private unsafe void LetGo()
	{
		//IL_0367: Expected Obj, but got I
		//IL_0381: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_03a9: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_046c: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0321: Expected Obj, but got I4
		//IL_032a: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_027c: Expected VT, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02ef: Expected VT, but got I4
		//IL_02f4: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F70]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj3 = 0;
		object obj4 = 17281024 + 4024;
		object obj5 = 0;
		Rigidbody rigidbody = null;
		object obj6 = 1;
		double num = default;
		object obj16 = default;
		object obj29 = default;
		while (true)
		{
			object obj7 = obj;
			object obj8 = obj6 & 1;
			bool flag = obj8 == null;
			object obj9 = !flag;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				object obj11 = 40;
			}
			else
			{
				object obj11 = 48;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+v176 @ X8_v8]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			num = num;
			object obj14 = 0;
			nint num2 = unchecked((nint)null);
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+v176 @ X8_v8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+v176 @ X8_v8]");
					((GillaCorpse)0).Pin(held: false);
					obj14 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
					object obj15 = obj16 & 1;
					bool flag5 = obj15 == null;
					num = num;
					num2 = (nint)(&rigidbody);
					if (flag5)
					{
						goto IL_02f9;
					}
					object obj17 = obj6 & 1;
					bool flag6 = obj17 == null;
					object obj18 = !flag6;
					object obj19 = ~obj18;
					double num3 = ((obj19 != null) ? (-1.0) : 1.0);
					Vector3 through = Through;
					float[] array = push;
					if (push != null)
					{
						bool flag7 = (nint)obj5 < array.Length;
						object obj20 = !flag7;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = (object)push + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+20]");
						bool flag8 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+20]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+20]");
						object obj22 = num4 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+20]");
						object obj23 = 0 & obj22;
						bool flag9 = (nint)obj23 < 0;
						bool flag10 = flag8 == flag9;
						object obj24 = !flag10;
						if ((object)rigidbody != null)
						{
							object obj25 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v17+A0]");
							object obj26 = 0;
							double num5 = num;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X26_v2+v209 @ TEMPCOND_v8*4]");
							double num6 = num5 * 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v18+20]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							object obj27 = num7 * 0;
							rigidbody.linearVelocity = (Vector3)0;
							if ((object)rigidbody != null)
							{
								object obj28 = axis * obj29;
								double num8 = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+C0]");
								double num9 = num8 * 0.0;
								object obj30 = obj28 * 0;
								num = num9 * 1.5;
								rigidbody.angularVelocity = (Vector3)0;
								num2 = unchecked((nint)null);
								goto IL_02f9;
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				break;
			}
			goto IL_02f9;
			IL_02f9:
			object obj31 = obj6 & 1;
			bool flag11 = obj31 == null;
			object obj32 = !flag11;
			obj5 = 1;
			obj6 = 0;
			if (obj32 == null)
			{
				return;
			}
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void Own()
	{
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected VT, but got Unknown
		//IL_0a2c: Expected Ref, but got VT
		//IL_0a4a: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		//IL_0027: Expected I4, but got VT
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I4
		//IL_0860: Expected Obj, but got I4
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected Obj, but got I4
		//IL_0b7f: Expected Obj, but got I
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected Ref, but got Unknown
		//IL_0baa: Expected Obj, but got I4
		//IL_0bb2: Expected I4, but got VT
		//IL_00ad: Expected Obj, but got I4
		//IL_0966: Expected VT, but got I4
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_0b16: Expected Obj, but got I4
		//IL_0892: Expected Obj, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_0a68: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_010e: Expected VT, but got I4
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected Obj, but got Unknown
		//IL_0792: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_09bc: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got I4
		//IL_07c1: Expected Obj, but got I
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected Obj, but got I4
		//IL_0824: Expected VT, but got Ref
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected VT, but got I4
		//IL_083f: Expected VT, but got Ref
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Invalid comparison between Unknown and I4
		//IL_0ab2: Expected Obj, but got I4
		//IL_01c2: Expected VT, but got Ref
		//IL_01f0: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I
		//IL_0216: Expected I4, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0917: Expected Obj, but got I4
		//IL_091f: Expected VT, but got Ref
		//IL_0928: Expected Obj, but got I4
		//IL_0931: Expected Obj, but got I4
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Ref
		//IL_02a8: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got I4
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got VT
		//IL_044d: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I4
		//IL_03f0: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_04f9: Expected Obj, but got I4
		//IL_0501: Expected VT, but got Ref
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected VT, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got I
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got I4
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Expected Obj, but got VT
		//IL_0713: Expected Obj, but got I
		//IL_0723: Expected VT, but got I
		//IL_0738: Expected Obj, but got I
		//IL_0741: Expected Obj, but got I4
		//IL_0749: Expected VT, but got Ref
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_06c4: Expected Obj, but got I4
		//IL_06cc: Expected VT, but got Ref
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected VT, but got I4
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		GillaRip.Along along = (GillaRip.Along)(this + 68);
		bool isMiddle = ((GillaRip.Along*)along)->IsMiddle;
		bool flag = !isMiddle;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		bool flag2 = (object)meshes == null;
		object obj2 = 0;
		GillaRip.Along along2 = default;
		int num = (int)along2;
		Enumerator<, > val = (Enumerator<, >)0;
		System.__Canon _Canon = null;
		if (!flag2)
		{
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)meshes).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
			object obj5 = 0;
			obj2 = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			Mesh source = default;
			Enumerator<, > val5 = default;
			object obj21 = default;
			object obj22 = default;
			object obj44 = default;
			Enumerator<, > val7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
				object obj6 = 0;
				System.__Canon _Canon2 = (System.__Canon)obj6;
				object obj36;
				object obj37;
				Enumerator<, > val6;
				Mesh mesh;
				GillaRip.Along along3;
				if (val.MoveNext())
				{
					object obj7 = 1;
					while (true)
					{
						object obj8 = obj3;
						object obj9 = obj7 & 1;
						bool flag3 = obj9 == null;
						object obj10 = !flag3;
						object obj11 = ~obj10;
						if (obj11 == null)
						{
							object obj12 = 40;
						}
						else
						{
							object obj12 = 48;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+v651 @ X8_v21]");
						UnityEngine.Object obj13 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v31+E4]");
						bool flag4 = (nint)0 == 0;
						object obj14 = !flag4;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag5 = obj13 == null;
						bool flag6 = !flag5;
						object obj15 = !flag6;
						along2 = (GillaRip.Along)0;
						_Canon2 = null;
						if (obj15 != null)
						{
							goto IL_076a;
						}
						object obj16 = obj4;
						object obj17 = obj7 & 1;
						bool flag7 = obj17 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+54]");
						mesh = (Mesh)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v40+E4]");
						val2 = (Enumerator<, >)0;
						obj11 = !flag7;
						int num2 = ((obj11 != null) ? 1 : (-1));
						bool flag8 = (int)val2 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaRip.Half half = GillaRip.Cut(source, num2, seed, (GillaRip.Along)(&val5));
						bool flag9 = (object)obj13 == null;
						int num3 = 1;
						num = seed;
						_Canon = (System.__Canon)num2;
						object obj30;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0488]");
							object obj19 = 0;
							num = (int)obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
							object obj20 = obj21 & 1;
							if (obj20 != null)
							{
								_Canon = (System.__Canon)(&obj2);
								obj22 = obj2;
							}
							else
							{
								GameObject gameObject = ((Component)obj13).gameObject;
								bool flag10 = (object)gameObject == null;
								num3 = 1;
								_Canon = null;
								if (flag10)
								{
									goto IL_0905;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7688]");
								object obj23 = 0;
								_Canon = (System.__Canon)obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
								obj2 = obj22;
							}
							bool flag11 = obj22 == null;
							num3 = 1;
							if (flag11)
							{
								goto IL_08e9;
							}
							bool flag12 = half == null;
							num3 = 1;
							if (flag12)
							{
								goto IL_08cd;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v58+20]");
							obj13 = (UnityEngine.Object)0;
							Mesh skin = half.skin;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v58+20]");
							bool flag13 = (nint)0 == 0;
							num3 = 1;
							if (!flag13)
							{
								IntPtr cachedPtr = obj13.m_CachedPtr;
								val2 = (Enumerator<, >)obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+1C]");
								num3 = (int)((nint)0 + (nint)1);
								if (obj13.m_CachedPtr != (IntPtr)0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v38 (System.IntPtr)+18]");
									bool flag14 = num4 < 0;
									object obj24 = !flag14;
									if (obj24 == null)
									{
										IntPtr cachedPtr2 = obj13.m_CachedPtr;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
										object obj25 = (nint)cachedPtr2 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
										val2 = (Enumerator<, >)((nint)0 + (nint)1);
										object obj26 = obj25 + 32;
										obj26 = skin;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									}
									else
									{
										System.__Canon _Canon3 = (System.__Canon)val2._current;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v45 (System.__Canon)+A8]");
										object obj27 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v46+70]");
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v58+20]");
										((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)skin);
									}
									Mesh inside = half.inside;
									object obj28 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v65+E4]");
									bool flag15 = (nint)0 == 0;
									object obj29 = !flag15;
									if (obj29 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag16 = inside != null;
									bool flag17 = !flag16;
									obj13 = inside;
									obj30 = 0;
									along3 = (GillaRip.Along)(&val5);
									val5 = (Enumerator<, >)this.along;
									along2 = (GillaRip.Along)0;
									val3 = (Enumerator<, >)this.along;
									_Canon2 = null;
									if (flag17)
									{
										goto IL_076a;
									}
									bool flag18 = obj2 == null;
									obj13 = inside;
									num = 0;
									_Canon = null;
									if (!flag18)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ stack_-88_v6+20]");
										obj13 = (UnityEngine.Object)0;
										Mesh inside2 = half.inside;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ stack_-88_v6+20]");
										bool flag19 = (nint)0 == 0;
										num = 0;
										_Canon = (System.__Canon)(object)inside2;
										if (!flag19)
										{
											IntPtr cachedPtr3 = obj13.m_CachedPtr;
											val2 = (Enumerator<, >)obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+1C]");
											num3 = (int)((nint)0 + (nint)1);
											bool flag20 = obj13.m_CachedPtr == (IntPtr)0;
											num = 0;
											_Canon = (System.__Canon)(object)inside2;
											if (!flag20)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
												num3 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
												nint num5 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v42 (System.IntPtr)+18]");
												bool flag21 = num5 < 0;
												object obj31 = !flag21;
												if (obj31 == null)
												{
													IntPtr cachedPtr4 = obj13.m_CachedPtr;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
													object obj32 = (nint)cachedPtr4 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X22_v12 (UnityEngine.Object)+18]");
													object obj33 = (nint)0 + (nint)1;
													object obj34 = obj32 + 32;
													obj34 = inside2;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													obj30 = 0;
													along3 = (GillaRip.Along)(&val5);
													val5 = (Enumerator<, >)this.along;
													along2 = (GillaRip.Along)0;
													val3 = (Enumerator<, >)this.along;
													_Canon2 = (System.__Canon)(object)inside2;
												}
												else
												{
													System.__Canon _Canon4 = (System.__Canon)val2._current;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v43 (System.__Canon)+A8]");
													object obj35 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v44+70]");
													along2 = (GillaRip.Along)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ stack_-88_v6+20]");
													((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)inside2);
													obj30 = 0;
													along3 = (GillaRip.Along)(&val5);
													val5 = (Enumerator<, >)this.along;
													val3 = (Enumerator<, >)this.along;
													_Canon2 = (System.__Canon)(object)inside2;
												}
												goto IL_076a;
											}
										}
										goto IL_08db;
									}
									goto IL_08f7;
								}
							}
							NullReferenceException ex = new NullReferenceException();
							_Canon = (System.__Canon)(object)skin;
						}
						NullReferenceException ex2 = new NullReferenceException();
						goto IL_08cd;
						IL_08f7:
						NullReferenceException ex3 = new NullReferenceException();
						goto IL_0905;
						IL_0905:
						NullReferenceException ex4 = new NullReferenceException();
						obj30 = 0;
						along3 = (GillaRip.Along)(&val5);
						obj36 = 0;
						obj37 = 0;
						val6 = (Enumerator<, >)(ref val);
						val3 = (Enumerator<, >)this.along;
						break;
						IL_076a:
						object obj38 = obj7 & 1;
						bool flag22 = obj38 == null;
						object obj39 = !flag22;
						obj7 = 0;
						if (obj39 != null)
						{
							continue;
						}
						goto IL_07a9;
						IL_08e9:
						NullReferenceException ex5 = new NullReferenceException();
						goto IL_08f7;
						IL_08cd:
						NullReferenceException ex6 = new NullReferenceException();
						goto IL_08db;
						IL_08db:
						NullReferenceException ex7 = new NullReferenceException();
						goto IL_08e9;
					}
					break;
				}
				obj36 = 0;
				obj37 = 0;
				val6 = (Enumerator<, >)(ref val);
				object obj40 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
					object obj41 = 0;
					_Canon = (System.__Canon)obj41;
					((Enumerator<, >*)val6)->Dispose();
					bool flag23 = obj40 == null;
					object obj42 = !flag23;
					num = (int)along2;
					if (obj42 == null)
					{
						bool flag24 = obj36 == null;
						object obj43 = !flag24;
						OutOfMemoryException ex8 = (OutOfMemoryException)val6;
						if (obj43 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex8 = new OutOfMemoryException();
						along2 = (GillaRip.Along)num;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)_Canon == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj36 = 1;
						obj40 = obj37;
						continue;
					}
					if ((nint)_Canon != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj40 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj37 = obj44;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
				IL_07a9:
				object obj45 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoorCut)+54]");
				mesh = (Mesh)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X0_v36+E4]");
				val2 = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X0_v36+E4]");
				bool flag25 = (nint)0 == 0;
				object obj46 = !flag25;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaRip.Forget(source, seed, (GillaRip.Along)(&val7));
				val7 = (Enumerator<, >)this.along;
				along3 = (GillaRip.Along)0;
				along2 = (GillaRip.Along)(&val7);
				val3 = (Enumerator<, >)this.along;
			}
		}
		throw new NullReferenceException();
	}

	public GillaDoorCut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = this + 200;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 208;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 216;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaDoorCut()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFFB0]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj4 = (nint)0 + (nint)16;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+A0]");
		object obj6 = 0;
		_ = 4294967295L;
	}
}
