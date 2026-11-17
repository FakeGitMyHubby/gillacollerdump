using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class GillaOreVeins : MonoBehaviour
{
	public struct Look
	{
		public string name;

		public Color mineral;

		public Color rock;

		public float glowBase;

		public float glow;

		public int health;

		public bool crystal;

		public int[] bolts;

		public float[] mass;
	}

	[Serializable]
	public struct Node
	{
		public Vector3 at;

		public Vector3 normal;

		public int vein;
	}

	[Serializable]
	public class Rule
	{
		public GillaOre.Kind kind;

		public int most;

		public int each;

		public float every = 120f;

		public int[] veins;

		public Rule()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4A0]");
			most = 0;
			base._002Ector();
		}
	}

	private static GillaOreVeins Instance__BackingField;

	public Node[] nodes;

	public int[] links;

	public Rule[] rules;

	public GillaOre[] ores;

	public Material oreMaterial;

	public Mesh[] chipMeshes;

	public Material chipMaterial;

	public Material sparkMaterial;

	public AudioClip[] hitSounds;

	public AudioClip[] breakSounds;

	public AudioClip[] crystalHitSounds;

	public AudioClip[] crystalBreakSounds;

	public AudioClip[] dropSounds;

	public const int Most = default(int);

	private const float Clear = default(float);

	private GillaOreFX FX__BackingField;

	private readonly Dictionary<GillaOre.Kind, Material> materials;

	private List<int>[] next;

	private byte[] kinds;

	private byte[] damage;

	private float[] changed;

	private float[] ticks;

	private bool filled;

	public static int SizeForTest;

	public static GillaOreVeins Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
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
			return (GillaOreVeins)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
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
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public GillaOreFX FX
	{
		get
		{
			return FX__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private GillaOreField LiveField
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01b3: Expected Obj, but got I
			//IL_01d5: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I4
			//IL_0160: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaOreField current = GillaOreField.Current;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)current != (UnityEngine.Object)null)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaOreField current2 = GillaOreField.Current;
				if ((object)current2 == null)
				{
					return (GillaOreField)(object)new NullReferenceException();
				}
				if (current2.Live)
				{
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v16+E4]");
					bool flag4 = (nint)0 == 0;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return GillaOreField.Current;
				}
			}
			return null;
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
		object obj6 = 0;
		obj6 = this;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj8 == this)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v14+A0]");
			object obj14 = 0;
			obj14 = 0;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private unsafe void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I4, but got Unknown
		//IL_002d: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Expected Obj, but got Unknown
		//IL_0b47: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0cd7: Expected Obj, but got I4
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected Obj, but got Unknown
		//IL_0ba8: Expected Obj, but got I
		//IL_016c: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I4
		//IL_01a3: Expected I4, but got Obj
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0d09: Expected Obj, but got I4
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected Obj, but got Unknown
		//IL_0d32: Expected Obj, but got I4
		//IL_0c09: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_01d6: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02ce: Expected I4, but got Obj
		//IL_042a: Expected I4, but got I8
		//IL_0444: Expected Obj, but got I4
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected Obj, but got Unknown
		//IL_0a8e: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_0551: Expected I, but got Obj
		//IL_05bf: Expected Obj, but got I4
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_0609: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I
		//IL_06de: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I
		//IL_07cb: Expected Obj, but got I
		//IL_07d3: Expected I, but got Obj
		//IL_07fa: Expected Obj, but got I
		//IL_080a: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I
		//IL_0749: Expected Obj, but got I
		//IL_075f: Expected Obj, but got I
		//IL_0779: Expected I, but got Obj
		//IL_0840: Expected Obj, but got I
		//IL_0861: Expected Obj, but got I4
		//IL_0893: Expected Obj, but got I
		//IL_08a3: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_0916: Expected Obj, but got I
		//IL_0968: Expected Obj, but got I
		//IL_0978: Expected Obj, but got I
		//IL_09a1: Expected Obj, but got I4
		//IL_0a10: Expected Obj, but got I
		//IL_0a20: Expected Obj, but got I
		//IL_0a30: Expected Obj, but got I
		//IL_0a45: Expected Obj, but got I
		//IL_0a55: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I
		//IL_09e9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = this + 136;
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X21_v8 (System.Int32)-68]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X21_v8 (System.Int32)-68]");
		bool flag = (nint)0 == 0;
		object obj5 = obj2;
		object obj6 = obj2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			obj6 = this + 152;
			object obj8 = default;
			obj6 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-78]");
			Node[] array = (Node[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-78]");
			bool flag2 = (nint)0 == 0;
			obj5 = obj8;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
				object obj13 = 0;
				object obj14 = 32;
				int num2 = 0;
				obj5 = obj8;
				List<int> list = default;
				object obj22 = default;
				object obj24 = default;
				object obj26 = default;
				IndexOutOfRangeException ex = default;
				while (true)
				{
					bool flag3 = num2 < array.Length;
					object obj15 = !flag3;
					object obj17;
					if (num2 < array.Length)
					{
						nint num3 = (nint)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj5 = obj10;
						list._002Ector();
						bool flag4 = obj6 == null;
						num = (int)list;
						if (flag4)
						{
							break;
						}
						if (list != null)
						{
							object obj16 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v37+40]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag5 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v37+40]");
							obj17 = 0;
							if (flag5)
							{
								goto IL_0c71;
							}
						}
						int num4 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X29_v4 (Il2CppClass<System.Object>)+18]");
						bool flag6 = (nint)num4 < (nint)0;
						obj15 = !flag6;
						if (obj15 == null)
						{
							object obj18 = obj6 + num2;
							object obj19 = obj6 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							array = nodes;
							num2++;
							obj14 += 8;
							bool flag7 = nodes == null;
							object obj20 = !flag7;
							obj5 = list;
							num = (int)list;
							if (obj20 == null)
							{
								break;
							}
							continue;
						}
						goto IL_0c5b;
					}
					int[] array2 = links;
					if (links == null)
					{
						break;
					}
					object obj21 = obj22;
					object obj23 = obj24;
					object obj25 = obj26;
					int num5 = num2;
					object obj27 = 0;
					object obj28 = obj5;
					int num6 = num;
					while (true)
					{
						object obj29 = array2.Length;
						obj7 = obj27 + 1;
						bool flag8 = (nint)obj7 < array2.Length;
						obj15 = !flag8;
						bool flag9 = (nint)obj7 >= array2.Length;
						obj22 = obj21;
						obj24 = obj23;
						obj26 = obj25;
						num2 = num5;
						obj9 = obj27;
						obj5 = obj28;
						num = num6;
						if (flag9)
						{
							break;
						}
						bool flag10 = (nint)obj27 < array2.Length;
						object obj30 = !flag10;
						obj22 = obj21;
						obj5 = obj28;
						if (obj30 == null)
						{
							bool flag11 = (nint)obj7 < array2.Length;
							obj15 = !flag11;
							obj22 = obj21;
							obj5 = obj28;
							if (obj15 == null)
							{
								obj29 = (object)array2 + obj27;
								object obj31 = (object)array2 + obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
								int num8 = (int)(num7 | 0);
								int num9 = (int)(num8 & 0x80000000L);
								bool flag12 = num9 == 0;
								object obj32 = !flag12;
								if (obj32 == null)
								{
									Node[] array3 = nodes;
									bool flag13 = nodes == null;
									obj22 = obj21;
									obj24 = obj23;
									obj26 = obj25;
									obj9 = obj27;
									obj5 = obj28;
									if (flag13)
									{
										goto end_IL_0cbc;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
									bool flag14 = (nint)0 < (nint)array3.Length;
									obj15 = !flag14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
									if ((nint)0 < (nint)array3.Length)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
										bool flag15 = (nint)0 < (nint)array3.Length;
										obj15 = !flag15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
										if ((nint)0 < (nint)array3.Length)
										{
											nint num10 = (nint)obj6;
											bool flag16 = obj6 == null;
											obj22 = obj21;
											obj24 = obj23;
											obj26 = obj25;
											obj9 = obj27;
											obj5 = obj28;
											if (flag16)
											{
												goto end_IL_0cbc;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
											nint num11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v23 (Il2CppClass<System.Object>)+18]");
											bool flag17 = num11 < 0;
											obj15 = !flag17;
											obj22 = obj21;
											obj5 = obj28;
											if (obj15 == null)
											{
												object obj33 = obj6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
												obj7 = obj33 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+20]");
												List<int> list2 = (List<int>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+20]");
												bool flag18 = (nint)0 == 0;
												obj22 = obj21;
												obj24 = obj23;
												obj26 = obj25;
												obj9 = obj27;
												obj5 = obj28;
												if (flag18)
												{
													goto end_IL_0cbc;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+10]");
												obj7 = 0;
												obj29 = obj11;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+1C]");
												obj26 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+10]");
												bool flag19 = (nint)0 == 0;
												obj22 = obj21;
												obj24 = obj23;
												obj9 = obj27;
												obj5 = obj28;
												if (flag19)
												{
													goto end_IL_0cbc;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+18]");
												obj26 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+18]");
												obj24 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+18]");
												nint num12 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+18]");
												bool flag20 = num12 < 0;
												obj15 = !flag20;
												object obj35;
												nint num14;
												if (obj15 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+10]");
													nint num13 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+18]");
													object obj34 = num13 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v40 (System.Collections.Generic.List`1<System.Int32>)+18]");
													obj35 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
													_ = 0;
													num14 = (nint)obj6;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v1+20]");
													object obj36 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v30+A8]");
													object obj37 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v31+70]");
													obj21 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+20]");
													nint num15 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
													((List<int>)num15).AddWithResize(0);
													num14 = (nint)obj6;
													bool flag21 = obj6 == null;
													obj35 = obj29;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
													obj28 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v31+70]");
													obj22 = 0;
													obj9 = obj27;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v17+20]");
													obj5 = 0;
													if (flag21)
													{
														goto end_IL_0cbc;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v24 (Il2CppClass<System.Object>)+18]");
												obj7 = 0;
												int num16 = num2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v24 (Il2CppClass<System.Object>)+18]");
												bool flag22 = (nint)num16 < (nint)0;
												obj15 = !flag22;
												obj22 = obj21;
												obj5 = obj28;
												if (obj15 == null)
												{
													object obj38 = num14 + num2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v25+20]");
													List<int> list3 = (List<int>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v25+20]");
													bool flag23 = (nint)0 == 0;
													obj22 = obj21;
													obj29 = obj35;
													obj9 = obj27;
													obj5 = obj28;
													if (flag23)
													{
														goto end_IL_0cbc;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+10]");
													object obj39 = 0;
													obj7 = obj11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+1C]");
													obj29 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+10]");
													bool flag24 = (nint)0 == 0;
													obj22 = obj21;
													obj9 = obj27;
													obj5 = obj28;
													if (flag24)
													{
														goto end_IL_0cbc;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+18]");
													obj29 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v26+18]");
													obj25 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+18]");
													nint num17 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v26+18]");
													bool flag25 = num17 < 0;
													obj15 = !flag25;
													if (obj15 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+10]");
														nint num18 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+18]");
														object obj40 = num18 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v39 (System.Collections.Generic.List`1<System.Int32>)+18]");
														obj7 = (nint)0 + (nint)1;
														obj23 = obj24;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v9+20]");
														object obj41 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v27+A8]");
														object obj42 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v28+70]");
														obj21 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v25+20]");
														((List<int>)0).AddWithResize(num);
														obj23 = obj24;
														obj28 = num;
													}
													goto IL_0a5a;
												}
											}
											goto IL_0c5b;
										}
									}
								}
								goto IL_0a5a;
							}
						}
						goto IL_0c5b;
						IL_0a5a:
						array2 = links;
						obj9 = obj27 + 2;
						bool flag26 = links == null;
						object obj43 = !flag26;
						obj22 = obj21;
						obj24 = obj23;
						obj26 = obj25;
						obj5 = obj28;
						num5 = num2;
						obj27 = obj9;
						num6 = num;
						if (obj43 == null)
						{
							goto end_IL_0cbc;
						}
					}
					goto IL_0ae2;
					IL_0c5b:
					ex = new IndexOutOfRangeException();
					obj17 = obj5;
					goto IL_0c71;
					IL_0c71:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
					throw new ArgumentNullException();
					continue;
					end_IL_0cbc:
					break;
				}
			}
		}
		goto IL_0ad4;
		IL_0ae2:
		Node[] array4 = nodes;
		if (nodes != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			obj6 = this + 160;
			object obj44 = default;
			obj6 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-80]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-80]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				obj6 = this + 168;
				object obj46 = default;
				obj6 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-88]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-88]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					obj6 = this + 176;
					object obj48 = default;
					obj6 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-80]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v3 (System.Object)-80]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj50 = this + 184;
						object obj51 = default;
						obj50 = obj51;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return;
					}
				}
			}
		}
		goto IL_0ad4;
		IL_0ad4:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ae2;
	}

	public unsafe Material MaterialOf(GillaOre.Kind kind)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got Ref
		//IL_011e: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_0532: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_030c: Expected VT, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_0350: Expected VT, but got I4
		//IL_037d: Expected Obj, but got I
		//IL_0396: Expected F4, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03dc: Expected F4, but got I
		//IL_03f2: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I
		//IL_047f: Expected Obj, but got I
		//IL_0498: Expected F4, but got I
		Material result;
		Material material = default;
		if (materials != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			bool flag = ((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)(object)materials).TryGetValue((Unity.IL2CPP.Metadata.__Il2CppByteEnum)kind, out System.__Canon value);
			bool flag2 = !flag;
			UnityEngine.Object obj3 = (UnityEngine.Object)kind;
			object obj4 = (object)(&value);
			if (!flag2)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v35+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = (UnityEngine.Object)(object)value != null;
				bool flag5 = !flag4;
				object obj7 = !flag5;
				obj3 = null;
				obj4 = 0;
				if (obj7 != null)
				{
					goto IL_04d5;
				}
			}
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = oreMaterial == null;
			bool flag8 = !flag7;
			object obj10 = !flag8;
			result = null;
			if (obj10 != null)
			{
				goto IL_051d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
			object obj11 = 0;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v18+E4]");
			bool flag9 = (nint)0 == 0;
			object obj13 = !flag9;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v18+A0]");
			object obj14 = 0;
			object obj15 = obj14;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v14+18]");
				bool flag10 = (nint)0 < (nint)(int)kind;
				object obj16 = !flag10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v14+18]");
				object obj17 = -(int)kind;
				bool flag11 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag11;
				if (obj19 != null)
				{
					goto IL_04f0;
				}
				object obj20 = kind & (GillaOre.Kind)0xFF;
				object obj21 = obj20 * 72;
				object obj22 = obj14 + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				material._002Ector(oreMaterial);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56D0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v15+20]");
				string text = (string)obj24 + (string)0;
				if ((object)material != null)
				{
					material.name = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5700]");
					object obj25 = 0;
					material.SetColor((string)obj25, (Color)0);
					if ((object)material != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56E8]");
						object obj26 = 0;
						material.SetColor((string)obj26, (Color)0);
						if ((object)material != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56E0]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v15+48]");
							material.SetFloat((string)obj27, 0f);
							if ((object)material != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56F8]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v15+4C]");
								material.SetFloat((string)obj28, 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v15+54]");
								object obj29 = (nint)0 & (nint)1;
								if (obj29 == null)
								{
									goto IL_049d;
								}
								if ((object)material != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56F0]");
									object obj30 = 0;
									material.SetFloat((string)obj30, 0.75f);
									if ((object)material != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56D8]");
										object obj31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD80]");
										material.SetFloat((string)obj31, 0f);
										goto IL_049d;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_04e2;
		IL_04f0:
		return (Material)(object)new IndexOutOfRangeException();
		IL_051d:
		return result;
		IL_04d5:
		result = material;
		goto IL_051d;
		IL_049d:
		if (materials != null)
		{
			((Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon>)(object)materials).set_Item((Unity.IL2CPP.Metadata.__Il2CppByteEnum)kind, (System.__Canon)(object)material);
			goto IL_04d5;
		}
		goto IL_04e2;
		IL_04e2:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04f0;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b3: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_055e: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I4
		//IL_065b: Expected Obj, but got I4
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0420: Expected Obj, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_044b: Expected F4, but got I
		//IL_046b: Expected Obj, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0691: Expected Obj, but got I4
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected I4, but got Unknown
		//IL_06bb: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I4
		//IL_04c7: Invalid comparison between F4 and I4
		//IL_04d6: Invalid comparison between F4 and I4
		//IL_04e9: Expected Obj, but got F4
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaOreField liveField = LiveField;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)liveField == (UnityEngine.Object)null)
		{
			RunHere();
		}
		else
		{
			filled = false;
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = ((!((UnityEngine.Object)liveField != (UnityEngine.Object)null)) ? Time.time : liveField.Now);
		GillaOre[] array = ores;
		int num2 = 0;
		float num3 = num;
		int num4 = 0;
		UnityEngine.Object obj6 = null;
		while (true)
		{
			if (num2 >= array.Length)
			{
				return;
			}
			Node[] array2 = nodes;
			if (num2 >= array2.Length)
			{
				return;
			}
			bool flag3 = num2 < array.Length;
			object obj7 = !flag3;
			if (obj7 != null)
			{
				break;
			}
			object obj8 = obj;
			object obj9 = array + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v10+20]");
			bool flag5 = (UnityEngine.Object)0 == null;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			num4 = 0;
			obj6 = null;
			if (obj11 == null)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v23+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				byte b2;
				if ((UnityEngine.Object)liveField != (UnityEngine.Object)null)
				{
					byte b = liveField.KindAt(num2);
					b2 = b;
					UnityEngine.Object obj14 = (UnityEngine.Object)num2;
				}
				else
				{
					byte[] array3 = kinds;
					bool flag8 = num2 < array3.Length;
					object obj15 = !flag8;
					if (obj15 != null)
					{
						break;
					}
					object obj16 = array3 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v26+20]");
					b2 = 0;
					UnityEngine.Object obj14 = null;
				}
				object obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v28+E4]");
				bool flag9 = (nint)0 == 0;
				object obj18 = !flag9;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num6;
				if ((UnityEngine.Object)liveField != (UnityEngine.Object)null)
				{
					int num5 = liveField.DamageAt(num2);
					num6 = num5;
					UnityEngine.Object obj19 = (UnityEngine.Object)num2;
				}
				else
				{
					byte[] array4 = damage;
					bool flag10 = num2 < array4.Length;
					object obj20 = !flag10;
					if (obj20 != null)
					{
						break;
					}
					object obj21 = array4 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v24+20]");
					num6 = 0;
					UnityEngine.Object obj19 = null;
				}
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v33+E4]");
				bool flag11 = (nint)0 == 0;
				object obj23 = !flag11;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)liveField != (UnityEngine.Object)null)
				{
					num3 = liveField.ChangedAt(num2);
				}
				else
				{
					float[] array5 = changed;
					bool flag12 = num2 < array5.Length;
					object obj24 = !flag12;
					if (obj24 != null)
					{
						break;
					}
					object obj25 = array5 + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v22+20]");
					num3 = 0f;
				}
				GillaOre[] array6 = ores;
				bool flag13 = num2 < array6.Length;
				object obj26 = !flag13;
				if (obj26 != null)
				{
					break;
				}
				object obj27 = array6 + num2;
				float num7 = num - num3;
				bool flag14;
				bool flag15;
				bool flag16;
				if ((double)num7 < 1.5)
				{
					flag14 = num3 < 0f;
					flag15 = num3 == 0f;
					object obj28 = num3 ^ num3;
					object obj29 = num3 & obj28;
					flag16 = (nint)obj29 < 0;
				}
				else
				{
					flag16 = false;
					flag15 = true;
					flag14 = false;
				}
				bool flag17 = flag14 == flag16;
				object obj30 = !flag15;
				bool fresh = (byte)((flag17 & obj30) ? 1 : 0) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v20+20]");
				((GillaOre)0).Show((GillaOre.Kind)b2, num6, fresh);
				num4 = num6;
				obj6 = (UnityEngine.Object)b2;
			}
			array = ores;
			num2++;
			bool flag18 = ores == null;
			object obj31 = !flag18;
			if (obj31 == null)
			{
				throw new NullReferenceException();
			}
		}
		throw new IndexOutOfRangeException();
	}

	public void Hit(int node, int amount, Vector3 at, Vector3 normal)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I4
		//IL_0098: Expected I4, but got I8
		//IL_00b2: Expected Obj, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_0637: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0364: Expected Obj, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I4
		//IL_0393: Expected Obj, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_04be: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I4
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_0562: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaOreField liveField = LiveField;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)liveField != (UnityEngine.Object)null)
		{
			if ((object)liveField != null)
			{
				liveField.Hit(node, amount, at, normal);
				return;
			}
		}
		else
		{
			int num = (int)(node & 0x80000000L);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				return;
			}
			byte[] array = kinds;
			if (kinds != null)
			{
				if (array.Length <= node)
				{
					return;
				}
				object obj5 = kinds + node;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v8+20]");
				if ((nint)0 == 0)
				{
					return;
				}
				byte[] array2 = damage;
				if (damage != null)
				{
					bool flag3 = array2.Length < node;
					object obj6 = !flag3;
					object obj7 = array2.Length - node;
					bool flag4 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag4;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
						object obj10 = 0;
						object obj11 = damage + node;
						object obj12 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v12+E4]");
						bool flag5 = (nint)0 == 0;
						object obj13 = !flag5;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj10;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v12+A0]");
						object obj14 = 0;
						object obj15 = obj14;
						if (obj14 == null)
						{
							goto IL_05cf;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v8+20]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v12+18]");
						bool flag6 = num2 < 0;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v8+20]");
							object obj17 = (nint)0 * (nint)72;
							object obj18 = obj14 + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v10+20]");
							object obj19 = (nint)0 + (nint)amount;
							object obj20 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v13+50]");
							if ((nint)obj20 < 0)
							{
								byte[] array3 = damage;
								object obj21 = obj19 - 255;
								bool flag7 = (nint)obj21 < 0;
								object obj22 = obj19 ^ 0xFF;
								object obj23 = obj19 ^ obj21;
								object obj24 = obj22 & obj23;
								bool flag8 = (nint)obj24 < 0;
								bool flag9 = flag7 == flag8;
								object obj25 = !flag9;
								object obj26 = ~obj25;
								if (obj26 != null)
								{
									obj19 = 255;
								}
								if (damage == null)
								{
									goto IL_05cf;
								}
								bool flag10 = array3.Length < node;
								object obj27 = !flag10;
								object obj28 = array3.Length - node;
								bool flag11 = obj28 == null;
								object obj29 = ~obj27;
								object obj30 = obj29 | flag11;
								if (obj30 == null)
								{
									object obj31 = damage + node;
									return;
								}
							}
							else
							{
								byte[] array4 = kinds;
								if (kinds == null)
								{
									goto IL_05cf;
								}
								bool flag12 = array4.Length < node;
								object obj32 = !flag12;
								object obj33 = array4.Length - node;
								bool flag13 = obj33 == null;
								object obj34 = ~obj32;
								object obj35 = obj34 | flag13;
								if (obj35 == null)
								{
									object obj36 = kinds + node;
									_ = 0;
									byte[] array5 = damage;
									if (damage == null)
									{
										goto IL_05cf;
									}
									bool flag14 = array5.Length < node;
									object obj37 = !flag14;
									object obj38 = array5.Length - node;
									bool flag15 = obj38 == null;
									object obj39 = ~obj37;
									object obj40 = obj39 | flag15;
									if (obj40 == null)
									{
										object obj41 = damage + node;
										_ = 0;
										float[] array6 = changed;
										float time = Time.time;
										if (changed == null)
										{
											goto IL_05cf;
										}
										bool flag16 = array6.Length < node;
										object obj42 = !flag16;
										object obj43 = array6.Length - node;
										bool flag17 = obj43 == null;
										object obj44 = ~obj42;
										object obj45 = obj44 | flag17;
										if (obj45 == null)
										{
											object obj46 = changed + node;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v8+20]");
											Drop((GillaOre.Kind)0, node);
											return;
										}
									}
								}
							}
						}
					}
					goto IL_05dd;
				}
			}
		}
		goto IL_05cf;
		IL_05dd:
		throw new IndexOutOfRangeException();
		IL_05cf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05dd;
	}

	public void Heard(int node, Vector3 at, Vector3 normal)
	{
		//IL_01e6: Expected I4, but got I8
		//IL_0200: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_01bd: Expected VT, but got I4
		//IL_01bd: Expected VT, but got I4
		//IL_01bd: Expected Obj, but got I
		int num = (int)(node & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		GillaOre[] array = ores;
		if (ores != null)
		{
			if (array.Length <= node)
			{
				return;
			}
			object obj2 = ores + node;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+20]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
			GillaOre[] array2 = ores;
			if (ores != null)
			{
				bool flag3 = array2.Length < node;
				object obj6 = !flag3;
				object obj7 = array2.Length - node;
				bool flag4 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag4;
				if (obj9 != null)
				{
					goto IL_01cd;
				}
				object obj10 = ores + node;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9+20]");
					((GillaOre)0).Knocked((Vector3)0, (Vector3)0);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01cd;
		IL_01cd:
		throw new IndexOutOfRangeException();
	}

	private void RunHere()
	{
		//IL_087b: Expected Obj, but got I
		//IL_088b: Expected Obj, but got I
		//IL_089b: Expected Obj, but got I
		//IL_08af: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_0507: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I4
		//IL_08d8: Expected Obj, but got I4
		//IL_08f2: Invalid comparison between F4 and I4
		//IL_0937: Expected Obj, but got I4
		//IL_094f: Invalid comparison between F4 and I4
		//IL_00a9: Expected I4, but got Obj
		//IL_0561: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_05ae: Expected I, but got Obj
		//IL_05cb: Expected I, but got Obj
		//IL_015e: Expected F4, but got I
		//IL_016e: Invalid comparison between F4 and I
		//IL_017f: Expected Obj, but got I4
		//IL_01a6: Invalid comparison between F4 and I
		//IL_05f8: Expected Obj, but got I
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0465: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I4
		//IL_0698: Expected Obj, but got I4
		//IL_06b2: Invalid comparison between F4 and I4
		//IL_0244: Expected Obj, but got I4
		//IL_025e: Invalid comparison between F4 and I4
		//IL_06ea: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_032c: Invalid comparison between F4 and I4
		//IL_07b8: Expected Obj, but got I4
		//IL_0390: Expected I, but got Obj
		//IL_03ad: Expected I, but got Obj
		//IL_07d6: Expected F4, but got I
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_03da: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5708]");
		object obj3 = 0;
		bool flag = (byte)(~(filled ? 1u : 0u)) != 0;
		Rule rule = (Rule)109891584;
		object obj4;
		object obj7;
		if (!flag)
		{
			Rule[] array = rules;
			bool flag2 = rules == null;
			rule = (Rule)109891584;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5718]");
				obj4 = 0;
				bool flag4 = default;
				bool flag3 = flag4;
				Action<int, byte> action2 = default;
				Action<int, byte> action = action2;
				Func<int, byte> func2 = default;
				Func<int, byte> func = func2;
				nint num2 = default;
				nint num = num2;
				int num4 = default;
				int num3 = num4;
				float num6 = default;
				float num5 = num6;
				Func<int, byte> func4 = default;
				Func<int, byte> func3 = func4;
				object obj5 = 0;
				Rule rule2 = (Rule)109891584;
				Func<int, byte> func5 = default;
				Action<int, byte> action3 = default;
				object obj12;
				do
				{
					bool flag5 = (nint)obj5 < array.Length;
					object obj6 = !flag5;
					float num7 = (float)obj5 - (float)array.Length;
					bool flag6 = num7 < 0f;
					if ((nint)obj5 >= array.Length)
					{
						return;
					}
					float time = Time.time;
					int num8 = (int)ticks;
					bool flag7 = ticks == null;
					flag4 = flag3;
					action2 = action;
					func2 = func;
					num2 = num;
					num4 = num3;
					num6 = num5;
					func4 = func3;
					obj7 = obj5;
					rule = rule2;
					if (flag7)
					{
						break;
					}
					object obj8 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X21_v10 (System.Int32)+18]");
					bool flag8 = (nint)obj8 < 0;
					object obj9 = !flag8;
					if (obj9 == null)
					{
						func4 = (Func<int, byte>)(object)((object)ticks + obj5);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X22_v5 (System.Func`2<System.Int32, System.Byte>)+20]");
						num6 = 0f;
						float num9 = time;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X22_v5 (System.Func`2<System.Int32, System.Byte>)+20]");
						bool flag9 = num9 < 0f;
						obj6 = !flag9;
						float num10 = time;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X22_v5 (System.Func`2<System.Int32, System.Byte>)+20]");
						num7 = num10 - 0f;
						float num11 = time;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X22_v5 (System.Func`2<System.Int32, System.Byte>)+20]");
						if (num11 < 0f)
						{
							goto IL_0431;
						}
						time = Time.time;
						Rule[] array2 = rules;
						bool flag10 = rules == null;
						flag4 = flag3;
						action2 = action;
						func2 = func;
						num2 = num;
						num4 = num3;
						obj7 = obj5;
						rule = rule2;
						if (flag10)
						{
							break;
						}
						bool flag11 = (nint)obj5 < array2.Length;
						obj6 = !flag11;
						num7 = (float)obj5 - (float)array2.Length;
						flag6 = num7 < 0f;
						if (obj6 == null)
						{
							object obj10 = (object)rules + obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v19+20]");
							rule = (Rule)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v19+20]");
							bool flag12 = (nint)0 == 0;
							flag4 = flag3;
							action2 = action;
							func2 = func;
							num2 = num;
							num4 = num3;
							obj7 = obj5;
							if (flag12)
							{
								break;
							}
							object obj11 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X21_v10 (System.Int32)+18]");
							bool flag13 = (nint)obj11 < 0;
							obj6 = !flag13;
							float num12 = (float)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X21_v10 (System.Int32)+18]");
							num7 = num12 - 0f;
							flag6 = num7 < 0f;
							if (obj6 == null)
							{
								num6 = rule.every;
								num8 = rule.each;
								time += rule.every;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								func5._002Ector((object)this, (IntPtr)obj4);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								action3._002Ector((object)this, (IntPtr)obj3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v19+20]");
								int num13 = Grow((Rule)0, rule.each, func5, action3, anywhere: false);
								flag3 = false;
								action = action3;
								func = func5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v19+20]");
								num = 0;
								num3 = rule.each;
								func4 = func5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v19+20]");
								rule2 = (Rule)0;
								goto IL_0431;
							}
						}
					}
					goto IL_0864;
					IL_0431:
					array = rules;
					obj7 = obj5 + 1;
					bool flag14 = rules == null;
					obj12 = !flag14;
					flag4 = flag3;
					action2 = action;
					func2 = func;
					num2 = num;
					num4 = num3;
					rule = rule2;
					num5 = num6;
					func3 = func4;
					obj5 = obj7;
				}
				while (obj12 != null);
			}
			goto IL_04bb;
		}
		goto IL_04c9;
		IL_0864:
		throw new IndexOutOfRangeException();
		IL_04bb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04c9;
		IL_04c9:
		Rule[] array3 = rules;
		filled = true;
		if (rules == null)
		{
			goto IL_04bb;
		}
		object obj13 = array3.Length;
		if (array3.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5710]");
		obj4 = 0;
		obj7 = 0;
		Func<int, byte> func6 = default;
		Action<int, byte> action4 = default;
		while (true)
		{
			bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
			object obj6 = !flag15;
			float num7 = (float)obj7 - (float)obj13;
			bool flag6 = num7 < 0f;
			if (obj6 != null)
			{
				break;
			}
			object obj14 = (object)array3 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
			Rule rule3 = (Rule)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
			bool flag16 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
			rule = (Rule)0;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				func6._002Ector((object)this, (IntPtr)obj4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				action4._002Ector((object)this, (IntPtr)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
				int num14 = Grow((Rule)0, rule3.most, func6, action4, anywhere: true);
				rule = (Rule)(object)ticks;
				float time = Time.time;
				array3 = rules;
				bool flag17 = rules == null;
				bool flag4 = true;
				Action<int, byte> action2 = action4;
				Func<int, byte> func2 = func6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
				nint num2 = 0;
				int num4 = rule3.most;
				if (!flag17)
				{
					obj13 = array3.Length;
					bool flag18 = (nint)obj7 < array3.Length;
					obj6 = !flag18;
					num7 = (float)obj7 - (float)array3.Length;
					flag6 = num7 < 0f;
					if (obj6 != null)
					{
						break;
					}
					object obj15 = (object)rules + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X10_v5+20]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X10_v5+20]");
					bool flag19 = (nint)0 == 0;
					flag4 = true;
					action2 = action4;
					func2 = func6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
					num2 = 0;
					num4 = rule3.most;
					if (!flag19)
					{
						bool flag20 = ticks == null;
						flag4 = true;
						action2 = action4;
						func2 = func6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
						num2 = 0;
						num4 = rule3.most;
						if (!flag20)
						{
							bool flag21 = (nint)obj7 < rule.each;
							object obj17 = !flag21;
							if (obj17 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v4+1C]");
							float num6 = 0f;
							obj16 = (object)ticks + obj7;
							obj7++;
							float num15 = time;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v4+1C]");
							time = num15 + 0f;
							bool flag22 = (nint)obj7 < array3.Length;
							flag4 = true;
							action2 = action4;
							func2 = func6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v9+20]");
							num2 = 0;
							num4 = rule3.most;
							if (!flag22)
							{
								return;
							}
							continue;
						}
					}
				}
			}
			goto IL_04bb;
		}
		goto IL_0864;
	}

	private void SetHere(int node, byte kind)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		byte[] array = kinds;
		if (kinds == null)
		{
			goto IL_01d9;
		}
		bool flag = array.Length < node;
		object obj = !flag;
		object obj2 = array.Length - node;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			object obj5 = kinds + node;
			byte[] array2 = damage;
			if (damage == null)
			{
				goto IL_01d9;
			}
			bool flag3 = array2.Length < node;
			object obj6 = !flag3;
			object obj7 = array2.Length - node;
			bool flag4 = obj7 == null;
			object obj8 = ~obj6;
			object obj9 = obj8 | flag4;
			if (obj9 == null)
			{
				object obj10 = damage + node;
				_ = 0;
				float[] array3 = changed;
				float time = Time.time;
				if (changed == null)
				{
					goto IL_01d9;
				}
				bool flag5 = array3.Length < node;
				object obj11 = !flag5;
				object obj12 = array3.Length - node;
				bool flag6 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag6;
				if (obj14 == null)
				{
					object obj15 = changed + node;
					return;
				}
			}
		}
		goto IL_01e7;
		IL_01d9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e7;
		IL_01e7:
		throw new IndexOutOfRangeException();
	}

	public void SetForTest(int node, GillaOre.Kind kind)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_0073: Expected I4, but got I8
		//IL_008d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaOreField liveField = LiveField;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)liveField != (UnityEngine.Object)null)
		{
			liveField.SetForTest(node, kind);
			return;
		}
		int num = (int)(node & 0x80000000L);
		bool flag2 = num == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			byte[] array = kinds;
			if (kinds != null && array.Length > node)
			{
				SetHere(node, (byte)kind);
			}
		}
	}

	public int Grow(Rule rule, int count, Func<int, byte> kindAt, Action<int, byte> set, bool anywhere)
	{
		//IL_0063: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_009d: Expected I4, but got Obj
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_01a1: Expected I4, but got Obj
		//IL_01aa: Expected Obj, but got I4
		//IL_1830: Expected Obj, but got I4
		//IL_183e: Expected Obj, but got I4
		//IL_1858: Expected Obj, but got I4
		//IL_186a: Unknown result type (might be due to invalid IL or missing references)
		//IL_187c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected Obj, but got I
		//IL_0d1f: Expected Obj, but got I
		//IL_0d2f: Expected F4, but got I
		//IL_0283: Expected I4, but got Obj
		//IL_02c3: Expected I4, but got I8
		//IL_02dd: Expected Obj, but got I4
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0c0d: Expected Obj, but got I4
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got I4
		//IL_141e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Expected Obj, but got I4
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got I
		//IL_048b: Expected I4, but got Obj
		//IL_04a1: Expected Obj, but got I
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a6: Expected Obj, but got I
		//IL_19ae: Expected I4, but got Obj
		//IL_19bb: Expected I4, but got Obj
		//IL_19cf: Expected Obj, but got I
		//IL_19d7: Expected I4, but got Obj
		//IL_19ed: Expected Obj, but got I
		//IL_1a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a59: Expected I4, but got Obj
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1f: Expected Obj, but got I
		//IL_09f9: Expected Obj, but got I
		//IL_0a01: Expected I4, but got Obj
		//IL_0a17: Expected Obj, but got I
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got I
		//IL_056f: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I4
		//IL_147b: Expected Obj, but got I
		//IL_148b: Expected Obj, but got I
		//IL_14b4: Expected Obj, but got I4
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected F4, but got Unknown
		//IL_0778: Expected Obj, but got I4
		//IL_0b71: Expected Obj, but got I
		//IL_151c: Expected Obj, but got I
		//IL_152c: Expected Obj, but got I
		//IL_1549: Expected I4, but got Obj
		//IL_1551: Expected I4, but got Obj
		//IL_1946: Expected I4, but got Obj
		//IL_0aa5: Expected Obj, but got I
		//IL_0ab5: Expected Obj, but got I
		//IL_0ade: Expected Obj, but got I4
		//IL_17ec: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_157d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Expected Obj, but got I
		//IL_1507: Expected I4, but got Obj
		//IL_11a0: Expected Obj, but got I4
		//IL_0b8e: Expected Obj, but got I
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae3: Expected Obj, but got I
		//IL_1aeb: Expected I4, but got Obj
		//IL_0b09: Expected Obj, but got I
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Unknown result type (might be due to invalid IL or missing references)
		//IL_1641: Expected I4, but got Obj
		//IL_1722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got I
		//IL_0868: Expected Obj, but got I
		//IL_0878: Expected F4, but got I
		//IL_0886: Expected VT, but got I4
		//IL_0892: Expected VT, but got Obj
		//IL_08b4: Expected Obj, but got I4
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected Obj, but got I4
		//IL_0ea1: Expected Obj, but got I4
		//IL_08f8: Expected Obj, but got I4
		//IL_1669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebe: Expected Obj, but got Unknown
		//IL_168f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got I
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1980: Expected Obj, but got I
		//IL_1988: Expected I4, but got Obj
		//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected I4, but got Obj
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f71: Expected Obj, but got I
		//IL_0f79: Expected I4, but got Obj
		//IL_0f8f: Expected Obj, but got I
		//IL_0fc9: Expected Obj, but got I
		//IL_0fd9: Expected Obj, but got I
		//IL_1002: Expected Obj, but got I4
		//IL_106a: Expected Obj, but got I
		//IL_107a: Expected Obj, but got I
		//IL_102d: Expected Obj, but got I
		List<int> list = default;
		List<int> list2 = default;
		Enumerator<, > val;
		int num2;
		Enumerator<, > val2;
		int num3;
		object obj2 = default;
		float num8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj;
		object obj3;
		float num6 = default;
		bool flag2;
		object obj13 = default;
		int num14 = default;
		float num7;
		Action<int, byte> action;
		int num;
		object obj8;
		object obj10;
		if (rule != null)
		{
			int[] veins = rule.veins;
			if (rule.veins != null && veins.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
				action = (Action<int, byte>)0;
				list._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				num = (int)action;
				list2._002Ector();
				Node[] array = nodes;
				bool flag = nodes == null;
				val = (Enumerator<, >)0;
				num2 = 0;
				val2 = (Enumerator<, >)0;
				num3 = 0;
				int num4 = count;
				Func<int, byte> func2 = default;
				Func<int, byte> func = func2;
				flag2 = anywhere;
				if (flag)
				{
					goto IL_0cb7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55E8]");
				action = (Action<int, byte>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
				obj3 = 0;
				object obj5 = default;
				object obj4 = obj5;
				object obj7 = default;
				object obj6 = obj7;
				float num5 = num6;
				num7 = num8;
				obj8 = obj9;
				obj10 = obj11;
				object obj12 = obj13;
				object obj15 = default;
				object obj14 = obj15;
				int num9 = count;
				int num11 = default;
				int num10 = num11;
				int num12 = 0;
				int num13 = (int)action;
				object obj16 = 0;
				object obj23 = default;
				while (true)
				{
					bool flag3 = num12 < 95;
					object obj17 = !flag3;
					object obj18 = num12 - 95;
					bool flag4 = obj18 == null;
					object obj19 = !flag4;
					object obj20 = obj17 & obj19;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					num3 = 0;
					obj5 = obj4;
					obj7 = obj6;
					num6 = num5;
					num8 = num7;
					obj9 = obj8;
					obj11 = obj10;
					obj13 = obj12;
					obj15 = obj14;
					num4 = num9;
					num11 = num10;
					num14 = num12;
					num = num13;
					func = func2;
					flag2 = anywhere;
					obj = obj16;
					if (obj20 != null)
					{
						break;
					}
					num11 = array.Length;
					bool flag5 = num12 >= array.Length;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					num3 = 0;
					obj5 = obj4;
					obj7 = obj6;
					num6 = num5;
					num8 = num7;
					obj9 = obj8;
					obj11 = obj10;
					obj13 = obj12;
					obj15 = obj14;
					num4 = num9;
					num14 = num12;
					num = num13;
					func = func2;
					flag2 = anywhere;
					obj = obj16;
					if (flag5)
					{
						break;
					}
					object obj21 = (object)array + obj16;
					num4 = (int)action;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v64+38]");
					num = 0;
					int[] veins2 = rule.veins;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v64+38]");
					int num15 = Array.IndexOf(veins2, 0);
					int num16 = (int)(num15 & 0x80000000L);
					bool flag6 = num16 == 0;
					object obj22 = !flag6;
					if (obj22 != null)
					{
						goto IL_0bcb;
					}
					bool flag7 = func2 == null;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					num3 = 0;
					obj5 = obj4;
					obj7 = obj6;
					num6 = num5;
					num8 = num7;
					obj9 = obj8;
					obj11 = obj10;
					obj13 = obj12;
					obj15 = obj14;
					num14 = num12;
					func = func2;
					flag2 = anywhere;
					obj = obj16;
					List<int> list3;
					int num19;
					int num20;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X3_v3 (System.Func`2<System.Int32, System.Byte>)+28]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v374 @ X3_v3 (System.Func`2<System.Int32, System.Byte>)+18] (should have been resolved before IL gen)");
						if ((int)rule.kind == (nint)obj23)
						{
							bool flag8 = list == null;
							val = (Enumerator<, >)0;
							num2 = 0;
							val2 = (Enumerator<, >)0;
							num3 = 0;
							obj5 = obj4;
							obj7 = obj6;
							num6 = num5;
							num8 = num7;
							obj9 = obj8;
							obj11 = obj10;
							obj13 = obj12;
							obj15 = obj14;
							num14 = num12;
							num = num12;
							func = func2;
							flag2 = anywhere;
							obj = obj16;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj24 = 0;
								num11 = (int)obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
								obj15 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
								bool flag9 = (nint)0 == 0;
								val = (Enumerator<, >)0;
								num2 = 0;
								val2 = (Enumerator<, >)0;
								num3 = 0;
								obj5 = obj4;
								obj7 = obj6;
								num6 = num5;
								num8 = num7;
								obj9 = obj8;
								obj11 = obj10;
								obj13 = obj12;
								num14 = num12;
								num = num12;
								func = func2;
								flag2 = anywhere;
								obj = obj16;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
									obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v79+18]");
									obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
									nint num17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v79+18]");
									bool flag10 = num17 < 0;
									object obj25 = !flag10;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
										nint num18 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
										object obj26 = num18 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
										num11 = (int)((nint)0 + (nint)1);
										num = num12;
										goto IL_0bcb;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v11 (System.Int32)+20]");
									object obj27 = 0;
									list3 = list;
									goto IL_17dc;
								}
							}
						}
						else
						{
							object obj28 = obj23 & 0xFF;
							bool flag11 = obj28 == null;
							object obj29 = !flag11;
							num = num12;
							if (obj29 != null)
							{
								goto IL_0bcb;
							}
							bool flag12 = !anywhere;
							object obj30 = !flag12;
							obj5 = obj4;
							obj7 = obj6;
							num6 = num5;
							num8 = num7;
							obj9 = obj8;
							obj11 = obj10;
							num19 = array.Length;
							num20 = num12;
							if (obj30 != null)
							{
								goto IL_0968;
							}
							Transform transform = base.transform;
							Node[] array2 = nodes;
							bool flag13 = nodes == null;
							val = (Enumerator<, >)0;
							num2 = 0;
							val2 = (Enumerator<, >)0;
							num3 = 0;
							obj5 = obj4;
							obj7 = obj6;
							num6 = num5;
							num8 = num7;
							obj9 = obj8;
							obj11 = obj10;
							obj13 = obj12;
							obj15 = obj14;
							num14 = num12;
							num = 0;
							func = func2;
							flag2 = anywhere;
							obj = obj16;
							if (!flag13)
							{
								num11 = array2.Length;
								bool flag14 = num12 < array2.Length;
								object obj31 = !flag14;
								num = 0;
								if (obj31 != null)
								{
									goto IL_1793;
								}
								bool flag15 = (object)transform == null;
								val = (Enumerator<, >)0;
								num2 = 0;
								val2 = (Enumerator<, >)0;
								num3 = 0;
								obj5 = obj4;
								obj7 = obj6;
								num6 = num5;
								num8 = num7;
								obj9 = obj8;
								obj11 = obj10;
								obj13 = obj12;
								obj15 = obj14;
								num14 = num12;
								num = 0;
								func = func2;
								flag2 = anywhere;
								obj = obj16;
								if (!flag15)
								{
									object obj32 = (object)nodes + obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v77+24]");
									obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v77+28]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v77+20]");
									num8 = 0f;
									Vector3 vector = transform.TransformPoint((Vector3)0);
									Vector3 p = (Vector3)obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X0_v82 (UnityEngine.Vector3)+E4]");
									bool flag16 = (nint)0 == 0;
									object obj33 = !flag16;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag17 = SomeoneBy(p);
									bool flag18 = !flag17;
									object obj34 = !flag18;
									obj5 = obj9;
									obj7 = obj11;
									num6 = num8;
									num19 = num11;
									num20 = 0;
									obj4 = obj9;
									obj6 = obj11;
									num5 = num8;
									num7 = num8;
									obj8 = obj9;
									obj10 = obj11;
									num = 0;
									if (obj34 == null)
									{
										goto IL_0968;
									}
									goto IL_0bcb;
								}
							}
						}
					}
					goto IL_0cb7;
					IL_17dc:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X8_v69+A8]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v70+70]");
					num4 = 0;
					list3.AddWithResize(num12);
					num = num12;
					goto IL_0bcb;
					IL_0968:
					bool flag19 = list2 == null;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					num3 = 0;
					obj13 = obj12;
					obj15 = obj14;
					num11 = num19;
					num14 = num12;
					num = num20;
					func = func2;
					flag2 = anywhere;
					obj = obj16;
					if (!flag19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj36 = 0;
						num11 = (int)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+10]");
						bool flag20 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						num2 = 0;
						val2 = (Enumerator<, >)0;
						num3 = 0;
						obj13 = obj12;
						num14 = num12;
						num = num20;
						func = func2;
						flag2 = anywhere;
						obj = obj16;
						if (!flag20)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
							obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v73+18]");
							obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v73+18]");
							bool flag21 = num21 < 0;
							object obj37 = !flag21;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+10]");
								nint num22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj26 = num22 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
								num11 = (int)((nint)0 + (nint)1);
								obj4 = obj5;
								obj6 = obj7;
								num5 = num6;
								num7 = num8;
								obj8 = obj9;
								obj10 = obj11;
								num = num20;
								goto IL_0bcb;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v11 (System.Int32)+20]");
							object obj27 = 0;
							obj4 = obj5;
							obj6 = obj7;
							num5 = num6;
							num7 = num8;
							obj8 = obj9;
							obj10 = obj11;
							list3 = list2;
							goto IL_17dc;
						}
					}
					goto IL_0cb7;
					IL_0bcb:
					array = nodes;
					num14 = num12 + 1;
					obj = obj16 + 28;
					bool flag22 = nodes == null;
					object obj38 = !flag22;
					val = (Enumerator<, >)0;
					num2 = 0;
					val2 = (Enumerator<, >)0;
					num3 = 0;
					obj5 = obj4;
					obj7 = obj6;
					num6 = num5;
					num8 = num7;
					obj9 = obj8;
					obj11 = obj10;
					obj13 = obj12;
					obj15 = obj14;
					func = func2;
					flag2 = anywhere;
					num9 = num4;
					num10 = num11;
					num12 = num14;
					num13 = num;
					obj16 = obj;
					if (obj38 != null)
					{
						continue;
					}
					goto IL_0cb7;
				}
				goto IL_0cc5;
			}
		}
		goto IL_1743;
		IL_1743:
		int result = 0;
		goto IL_190f;
		IL_1793:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_1ab0;
		IL_1ab0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D61C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		int result2 = default;
		return result2;
		IL_0cb7:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0cc5;
		IL_0cc5:
		if (count < 1)
		{
			goto IL_1743;
		}
		if (list == null)
		{
			goto IL_0cb7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5610]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
		num6 = 0f;
		int num24 = default;
		int num23 = num24;
		action = set;
		flag2 = false;
		object obj40 = default;
		int num29 = default;
		Enumerator<, > val4 = default;
		int num31 = default;
		while (true)
		{
			int num11 = rule.most;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag23 = (nint)0 >= (nint)rule.most;
			result = (flag2 ? 1 : 0);
			if (flag23)
			{
				break;
			}
			bool flag24 = list2 == null;
			num24 = num23;
			if (!flag24)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
				num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag25 = (nint)0 <= (nint)0;
				result = (flag2 ? 1 : 0);
				if (flag25)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
				bool flag26 = (nint)0 < (nint)1;
				int num25 = num23;
				if (!flag26)
				{
					num8 = UnityEngine.Random.value;
					bool flag27 = !(num8 < num6);
					num25 = num23;
					if (!flag27)
					{
						goto IL_0e0f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
				int index = UnityEngine.Random.Range(0, 0);
				int num26 = list2.get_Item(index);
				object obj39 = obj40;
				int num27 = num2;
				int num28 = num29;
				Enumerator<, > val3 = val4;
				int num30 = num31;
				int num32 = num3;
				num24 = num25;
				num7 = num8;
				object obj41 = obj13;
				int num33 = num14;
				Func<int, byte> func = (Func<int, byte>)num26;
				Action<int, byte> action2 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5620]");
				object obj42 = 0;
				int num4 = (int)obj42;
				bool flag28 = list2.Remove((int)func);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj43 = 0;
				num11 = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj15 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
				bool flag29 = (nint)0 == 0;
				obj40 = obj39;
				num2 = num27;
				num29 = num28;
				val4 = val3;
				num31 = num30;
				num3 = num32;
				num8 = num7;
				obj13 = obj41;
				num14 = num33;
				num = (int)func;
				action = action2;
				if (!flag29)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v19+18]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v19+18]");
					bool flag30 = num34 < 0;
					object obj44 = !flag30;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj45 = num35 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v6 (System.Collections.Generic.List`1<System.Int32>)+18]");
						num11 = (int)((nint)0 + (nint)1);
						num = (int)func;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v11 (System.Int32)+20]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v23+A8]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X8_v24+70]");
						num4 = 0;
						list.AddWithResize((int)func);
						num = (int)func;
					}
					bool flag31 = action2 == null;
					obj40 = obj39;
					num2 = num27;
					num29 = num28;
					val4 = val3;
					num31 = num30;
					num3 = num32;
					num8 = num7;
					num14 = num33;
					action = action2;
					if (!flag31)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v342 @ X20_v12 (System.Action`2<System.Int32, System.Byte>)+18] (should have been resolved before IL gen)");
						flag2 = (byte)((flag2 ? 1u : 0u) + 1u) != 0;
						bool flag32 = (flag2 ? 1 : 0) != count;
						obj40 = obj39;
						num2 = num27;
						num29 = num28;
						val4 = val3;
						num31 = num30;
						num3 = num32;
						num23 = num24;
						num8 = num7;
						num4 = (int)rule.kind;
						num14 = num33;
						num = (int)func;
						action = action2;
						if (!flag32)
						{
							result = count;
							break;
						}
						continue;
					}
				}
			}
			goto IL_0cb7;
		}
		goto IL_190f;
		IL_0e0f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<int> list4 = default;
		list4._002Ector();
		Enumerator<, > enumerator = list.GetEnumerator();
		Enumerator<, > val5 = default;
		num7 = (float)val5;
		num = (int)obj;
		Enumerator<, > val6;
		if (val2.MoveNext())
		{
			List<int>[] array3 = next;
			if (next != null)
			{
				object obj15 = array3.Length;
				bool flag33 = num23 < array3.Length;
				object obj49 = !flag33;
				if (obj49 == null)
				{
					object obj50 = next + num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X8_v47+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X8_v47+20]");
						Enumerator<, > enumerator2 = ((List<int>)0).GetEnumerator();
						int num11 = num23;
						float num38 = default;
						while (true)
						{
							if (val.MoveNext())
							{
								int num4 = (int)obj3;
								bool flag34 = list2.Contains(num29);
								bool flag35 = !flag34;
								num14 = num29;
								if (flag35)
								{
									continue;
								}
								if (list4 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+10]");
									object obj51 = 0;
									num11 = (int)obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+1C]");
									object obj52 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+10]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
										obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X8_v58+18]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
										nint num36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X8_v58+18]");
										bool flag36 = num36 < 0;
										object obj53 = !flag36;
										if (obj53 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+10]");
											nint num37 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
											object obj54 = num37 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v34 (System.Collections.Generic.List`1<System.Int32>)+18]");
											num11 = (int)((nint)0 + (nint)1);
											num14 = num29;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X9_v11 (System.Int32)+20]");
											object obj55 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X8_v59+A8]");
											object obj56 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v60+70]");
											num4 = 0;
											list4.AddWithResize(num29);
											num14 = num29;
										}
										continue;
									}
								}
								NullReferenceException ex3 = new NullReferenceException();
								val6 = (Enumerator<, >)(ref val2);
								num7 = num38;
								obj8 = obj9;
								obj10 = obj11;
								num = num29;
								ex = (IndexOutOfRangeException)(object)ex3;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
							object obj57 = 0;
							num = (int)obj57;
							val.Dispose();
							OutOfMemoryException ex4 = new OutOfMemoryException();
							val6 = (Enumerator<, >)(ref val2);
							num7 = num38;
							obj8 = obj9;
							obj10 = obj11;
							ex = (IndexOutOfRangeException)(object)ex4;
							break;
						}
					}
					else
					{
						NullReferenceException ex5 = new NullReferenceException();
						val6 = (Enumerator<, >)(ref val2);
						obj8 = obj9;
						obj10 = obj11;
						ex = (IndexOutOfRangeException)(object)ex5;
					}
				}
				else
				{
					ex = new IndexOutOfRangeException();
					val6 = (Enumerator<, >)(ref val2);
					obj8 = obj9;
					obj10 = obj11;
				}
			}
			else
			{
				NullReferenceException ex6 = new NullReferenceException();
				val6 = (Enumerator<, >)(ref val2);
				obj8 = obj9;
				obj10 = obj11;
				ex = (IndexOutOfRangeException)(object)ex6;
			}
			goto IL_1ab0;
		}
		action = (Action<int, byte>)17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55F0]");
		object obj58 = 0;
		num = (int)obj58;
		val2.Dispose();
		OutOfMemoryException ex7 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		val6 = (Enumerator<, >)(ref val2);
		obj8 = obj9;
		obj10 = obj11;
		goto IL_1793;
		IL_190f:
		return result;
	}

	public unsafe static bool SomeoneBy(Vector3 p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_07fd: Expected Obj, but got I
		//IL_0820: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I4
		//IL_083e: Expected Obj, but got I
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got I4
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got I4
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Ref, but got Unknown
		//IL_0915: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I4
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got I4
		//IL_06a1: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_06bd: Expected Obj, but got I4
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_074b: Expected Obj, but got I4
		//IL_0754: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I4
		//IL_0512: Expected Obj, but got I4
		//IL_0536: Expected Obj, but got I
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Invalid comparison between Unknown and F8
		//IL_05d5: Expected Obj, but got I4
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 != null;
		bool flag3 = !flag2;
		object obj8 = default;
		object obj7 = obj8;
		double num2 = default;
		double num = num2;
		double num4 = default;
		double num3 = num4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (flag3)
		{
			goto IL_032a;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v25+A0]");
		object obj12 = 0;
		UnityEngine.Object obj13 = (UnityEngine.Object)obj12;
		bool flag4 = obj12 == null;
		Enumerator<, > val = (Enumerator<, >)0;
		obj7 = obj8;
		num = num2;
		Enumerator<, > val2 = (Enumerator<, >)num4;
		obj9 = 0;
		obj10 = null;
		bool result;
		if (!flag4)
		{
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v55+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v8 (UnityEngine.Object)+20]");
			bool flag6 = (UnityEngine.Object)0 != null;
			bool flag7 = !flag6;
			obj7 = obj8;
			num = num2;
			num3 = num4;
			obj9 = 0;
			obj10 = null;
			if (flag7)
			{
				goto IL_032a;
			}
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+A0]");
			object obj17 = 0;
			obj13 = (UnityEngine.Object)obj17;
			bool flag8 = obj17 == null;
			val = (Enumerator<, >)0;
			obj7 = obj8;
			num = num2;
			val2 = (Enumerator<, >)num4;
			obj9 = 0;
			obj10 = null;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v8 (UnityEngine.Object)+20]");
				bool flag9 = (nint)0 == 0;
				val = (Enumerator<, >)0;
				obj7 = obj8;
				num = num2;
				val2 = (Enumerator<, >)num4;
				obj9 = 0;
				obj10 = null;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v8 (UnityEngine.Object)+20]");
					Vector3 position = ((Transform)0).position;
					double num5 = num4 - num4;
					double num6 = num2 - num2;
					obj7 = obj8 - obj8;
					double num7 = num5 * num5;
					double num8 = num6 * num6;
					double num9 = num7 + num8;
					object obj18 = obj7 * obj7;
					num3 = (double)obj18 + num9;
					bool flag10 = !(num3 < 4.0);
					num = 4.0;
					obj9 = 0;
					obj10 = null;
					if (flag10)
					{
						goto IL_032a;
					}
					result = true;
					goto IL_068a;
				}
			}
		}
		goto IL_06e1;
		IL_06e1:
		throw new NullReferenceException();
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj19 = 0;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v31+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v31+A0]");
		obj13 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v8 (UnityEngine.Object)+8]");
		bool flag12 = (nint)0 == 0;
		val = (Enumerator<, >)0;
		val2 = (Enumerator<, >)num3;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v8 (UnityEngine.Object)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Enumerator<, > val4 = default;
			Enumerator<, > val3 = val4;
			bool flag13;
			UnityEngine.Object obj24;
			object obj26;
			double num10;
			object obj27;
			object obj33;
			UnityEngine.Object obj30 = default;
			Enumerator<, > val5;
			UnityEngine.Object obj25 = default;
			while (true)
			{
				flag13 = val.MoveNext();
				bool flag14 = !flag13;
				obj24 = obj25;
				obj26 = obj7;
				num10 = num;
				val2 = val3;
				obj27 = obj9;
				if (flag14)
				{
					break;
				}
				object obj28 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X0_v38+E4]");
				bool flag15 = (nint)0 == 0;
				object obj29 = !flag15;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag16 = obj30 != null;
				bool flag17 = !flag16;
				obj9 = 0;
				if (flag17)
				{
					continue;
				}
				if ((object)obj30 != null)
				{
					object obj31 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ stack_-88_v3 (UnityEngine.Object)+68]");
					obj25 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v45+E4]");
					bool flag18 = (nint)0 == 0;
					object obj32 = !flag18;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag19 = obj25 != null;
					bool flag20 = !flag19;
					obj9 = 0;
					if (flag20)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ stack_-88_v3 (UnityEngine.Object)+68]");
					bool flag21 = (nint)0 == 0;
					obj9 = 0;
					obj10 = null;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ stack_-88_v3 (UnityEngine.Object)+68]");
						Vector3 position2 = ((Transform)0).position;
						double num11 = (double)val3 - num4;
						double num12 = num - num2;
						obj26 = obj7 - obj8;
						double num13 = num11 * num11;
						double num14 = num12 * num12;
						double num15 = num13 + num14;
						num10 = (double)obj26 * (double)obj26;
						val2 = (Enumerator<, >)(num10 + num15);
						bool flag22 = !((double)val2 < 4.0);
						obj24 = obj25;
						obj27 = 0;
						obj7 = obj26;
						num = num10;
						val3 = val2;
						obj9 = 0;
						if (!flag22)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					obj9 = 0;
					obj10 = null;
				}
				NullReferenceException ex2 = new NullReferenceException();
				obj33 = 0;
				val = val4;
				obj30 = null;
				val5 = (Enumerator<, >)(ref val);
				val2 = val3;
				goto IL_06e1;
			}
			obj33 = 0;
			val = val4;
			obj30 = null;
			val5 = (Enumerator<, >)(ref val);
			object obj34 = 0;
			result = flag13;
			bool result2 = default;
			object obj37 = default;
			while (true)
			{
				obj10 = (UnityEngine.Object)obj23;
				((Enumerator<, >*)val5)->Dispose();
				bool flag23 = obj34 == null;
				object obj35 = !flag23;
				obj25 = obj24;
				obj7 = obj26;
				num = num10;
				obj9 = obj27;
				if (obj35 == null)
				{
					bool flag24 = (object)obj30 == null;
					object obj36 = !flag24;
					obj25 = obj24;
					obj7 = obj26;
					num = num10;
					obj9 = obj27;
					OutOfMemoryException ex3 = (OutOfMemoryException)val5;
					if (obj36 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj10 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj30 = (UnityEngine.Object)1;
					obj13 = (UnityEngine.Object)1;
					obj34 = obj33;
				}
				else
				{
					if ((nint)obj10 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj34 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj33 = obj37;
				}
				obj24 = obj25;
				obj26 = obj7;
				num10 = num;
				obj27 = obj9;
				result = false;
			}
			goto IL_068a;
		}
		goto IL_06e1;
		IL_068a:
		return result;
	}

	public unsafe void Drop(GillaOre.Kind kind, int node)
	{
		//IL_0010: Expected Obj, but got I
		//IL_11b9: Expected I4, but got I8
		//IL_11d3: Expected Obj, but got I4
		//IL_0041: Expected VT, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_11f1: Expected Obj, but got I
		//IL_1219: Expected VT, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_0117: Expected VT, but got I4
		//IL_0fb5: Invalid comparison between VT and I4
		//IL_0149: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I4
		//IL_0267: Expected VT, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_0193: Expected I4, but got Obj
		//IL_019b: Expected Obj, but got I4
		//IL_0ff5: Expected I, but got Obj
		//IL_0ffd: Expected VT, but got I
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I
		//IL_021f: Expected VT, but got I4
		//IL_123f: Expected Obj, but got I
		//IL_1269: Expected Obj, but got I4
		//IL_114b: Expected VT, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_0421: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_1043: Expected Obj, but got I4
		//IL_1053: Expected Obj, but got Ref
		//IL_0338: Expected VT, but got I4
		//IL_0560: Expected VT, but got I4
		//IL_1087: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I4
		//IL_0380: Expected VT, but got I4
		//IL_04a3: Expected Obj, but got I
		//IL_04b3: Expected Obj, but got I
		//IL_04c4: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I4
		//IL_10bf: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05d7: Expected VT, but got I4
		//IL_10f4: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I4
		//IL_03f0: Expected I4, but got Obj
		//IL_0606: Expected VT, but got I4
		//IL_062a: Expected Obj, but got I4
		//IL_0647: Expected VT, but got I4
		//IL_1287: Expected F4, but got I
		//IL_1297: Expected F4, but got I
		//IL_14fe: Expected Obj, but got I
		//IL_1528: Expected Obj, but got I4
		//IL_12ca: Expected Obj, but got I
		//IL_12f6: Expected Obj, but got I
		//IL_1315: Expected F4, but got I
		//IL_132f: Invalid comparison between F4 and I
		//IL_06d4: Expected Obj, but got I
		//IL_06dc: Expected F4, but got Obj
		//IL_06ec: Expected F4, but got I
		//IL_06f4: Expected F4, but got Obj
		//IL_066a: Expected F4, but got I
		//IL_067a: Expected F4, but got I
		//IL_137d: Expected VT, but got I4
		//IL_0714: Expected Obj, but got I4
		//IL_0723: Expected Obj, but got I4
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_075a: Expected VT, but got I4
		//IL_0789: Expected VT, but got I4
		//IL_07ad: Expected Obj, but got I4
		//IL_07ca: Expected VT, but got I4
		//IL_07e8: Expected F4, but got I
		//IL_13ab: Expected Obj, but got I
		//IL_13bb: Expected F4, but got I
		//IL_13d5: Expected F4, but got I
		//IL_1401: Expected F4, but got I
		//IL_1413: Expected VT, but got I4
		//IL_08e1: Expected Obj, but got I
		//IL_090b: Expected Obj, but got I4
		//IL_1453: Expected Obj, but got I4
		//IL_154e: Expected Obj, but got I
		//IL_155e: Expected Obj, but got I
		//IL_1580: Expected Obj, but got I4
		//IL_0965: Expected Obj, but got I
		//IL_1479: Expected F4, but got I
		//IL_14e0: Expected Obj, but got I4
		//IL_09d4: Expected VT, but got I4
		//IL_0d1d: Expected Obj, but got I4
		//IL_0d4a: Expected Obj, but got I
		//IL_0d52: Expected VT, but got Obj
		//IL_0ac5: Expected VT, but got I4
		//IL_09fa: Expected Obj, but got I
		//IL_0e16: Expected VT, but got I4
		//IL_0e49: Expected Obj, but got I
		//IL_0e51: Expected I4, but got Obj
		//IL_0b54: Expected VT, but got I4
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Expected Obj, but got Unknown
		//IL_0b8c: Expected Obj, but got I4
		//IL_0eda: Expected VT, but got Ref
		//IL_0be1: Expected VT, but got I4
		//IL_0f00: Expected F4, but got I
		//IL_0f10: Expected F4, but got I
		//IL_0f20: Expected F4, but got I
		//IL_0f2e: Expected VT, but got I4
		//IL_0f74: Expected VT, but got I4
		//IL_0c07: Expected Obj, but got I
		//IL_0c0f: Expected I4, but got Obj
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c27: Expected Obj, but got Unknown
		//IL_0c3e: Expected Obj, but got Ref
		//IL_0f98: Expected VT, but got I4
		//IL_0c5c: Expected Obj, but got I
		//IL_0c69: Expected VT, but got Obj
		//IL_0c79: Expected Obj, but got I
		//IL_0c86: Expected VT, but got Obj
		//IL_0c9b: Expected Obj, but got I
		//IL_0cb5: Expected Obj, but got I
		//IL_0cc6: Expected I, but got Obj
		//IL_0cea: Expected I4, but got Obj
		//IL_0cea: Expected VT, but got Ref
		//IL_0cea: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5598]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		int num = (int)(node & 0x80000000L);
		bool flag = num == 0;
		object obj3 = !flag;
		if (obj3 != null)
		{
			return;
		}
		Node[] array = nodes;
		bool flag2 = nodes == null;
		int num2 = node;
		Vector3 vector = (Vector3)0;
		object obj4 = obj2;
		GillaOre.Kind kind2;
		Vector3 vector2;
		if (!flag2)
		{
			if (array.Length <= node)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v17+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			bool flag4 = obj8 == null;
			num2 = node;
			vector = (Vector3)0;
			obj4 = obj2;
			if (!flag4)
			{
				object obj10 = kind & (GillaOre.Kind)0xFF;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X9_v18+18]");
				bool flag5 = (nint)obj10 < 0;
				object obj11 = !flag5;
				num2 = node;
				vector2 = (Vector3)0;
				kind2 = kind;
				if (obj11 == null)
				{
					kind2 = kind & (GillaOre.Kind)0xFF;
					object obj12 = (int)kind2 * 72;
					object obj13 = obj8 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X10_v8+54]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5128]");
						object obj14 = 0;
						kind2 = (GillaOre.Kind)(int)obj14;
						string text = (string)node;
						string text2 = null;
						goto IL_122f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v17+E4]");
					bool flag6 = (nint)0 == 0;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj16 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v84+A0]");
						obj8 = 0;
						obj9 = obj8;
						bool flag7 = obj8 == null;
						num2 = node;
						vector = (Vector3)0;
						obj4 = obj2;
						if (flag7)
						{
							goto IL_111f;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X9_v18+18]");
					bool flag8 = (nint)obj10 < 0;
					object obj17 = !flag8;
					num2 = node;
					vector2 = (Vector3)0;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
						object obj18 = 0;
						object obj19 = (int)kind2 * 72;
						object obj20 = obj9 + obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v81+8]");
						object obj21 = 0;
						object obj22 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v19+20]");
						kind2 = (GillaOre.Kind)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X0_v135+E4]");
						bool flag9 = (nint)0 == 0;
						object obj23 = !flag9;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num3 = RollSize();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v81+8]");
						bool flag10 = (nint)0 == 0;
						num2 = node;
						vector = (Vector3)0;
						obj4 = obj2;
						if (flag10)
						{
							goto IL_111f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X21_v15+18]");
						bool flag11 = (nint)num3 < (nint)0;
						object obj24 = !flag11;
						num2 = node;
						vector2 = (Vector3)0;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v81+8]");
							object obj25 = (nint)0 + (nint)num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5160]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v83+20]");
							string text = (string)0;
							GillaOre.Kind kind3 = kind2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v83+20]");
							string text3 = (string)obj26 + (string)kind3 + (string)0;
							string text2 = (string)kind2;
							kind2 = (GillaOre.Kind)(int)text3;
							goto IL_122f;
						}
					}
				}
				goto IL_0f9e;
			}
		}
		goto IL_111f;
		IL_122f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v44+E4]");
		bool flag12 = (nint)0 == 0;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameObject gameObject = ItemPrefab((string)kind2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v22+E4]");
		bool flag13 = (nint)0 == 0;
		object obj32 = !flag13;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (gameObject == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55B0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5380]");
			object obj34 = 0;
			string message = (string)obj33 + (string)kind2 + (string)obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v80+E4]");
			bool flag14 = (nint)0 == 0;
			object obj37 = !flag14;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			return;
		}
		Transform transform = base.transform;
		Node[] array2 = nodes;
		bool flag15 = nodes == null;
		num2 = 0;
		vector = (Vector3)0;
		obj4 = obj2;
		if (!flag15)
		{
			bool flag16 = array2.Length < node;
			object obj38 = !flag16;
			object obj39 = array2.Length - node;
			bool flag17 = obj39 == null;
			object obj40 = ~obj38;
			object obj41 = obj40 | flag17;
			num2 = 0;
			vector2 = (Vector3)0;
			if (obj41 != null)
			{
				goto IL_0f9e;
			}
			bool flag18 = (object)transform == null;
			num2 = 0;
			vector = (Vector3)0;
			obj4 = obj2;
			if (!flag18)
			{
				object obj42 = node * 28;
				object obj43 = (object)nodes + obj42;
				Vector3 vector3 = transform.TransformDirection((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+2C]");
				float num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+30]");
				float num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj44 = 0;
				object obj45 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X0_v56+E4]");
				bool flag19 = (nint)0 == 0;
				object obj46 = !flag19;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+2C]");
					num4 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+30]");
					num5 = 0f;
				}
				float num6 = num4 * num4;
				float num7 = num5 * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj47 = 0;
				float num8 = num6 + num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+34]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+34]");
				object obj48 = num9 * 0;
				float num10 = (float)obj48 + num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num11 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				float num12 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				float num13;
				float num14;
				if (num12 > 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X8_v24+34]");
					num13 = 0f / num10;
					num5 = num4 / num5;
					num14 = num5;
				}
				else
				{
					object obj49 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X8_v72+A0]");
					object obj50 = 0;
					num4 = (float)obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v73+8]");
					num13 = 0f;
					num14 = (float)obj50;
				}
				Transform transform2 = base.transform;
				Node[] array3 = nodes;
				bool flag20 = nodes == null;
				num2 = 0;
				vector = (Vector3)0;
				obj4 = obj2;
				if (!flag20)
				{
					bool flag21 = array3.Length < node;
					object obj51 = !flag21;
					object obj52 = array3.Length - node;
					bool flag22 = obj52 == null;
					object obj53 = ~obj51;
					object obj54 = obj53 | flag22;
					num2 = 0;
					vector2 = (Vector3)0;
					if (obj54 != null)
					{
						goto IL_0f9e;
					}
					bool flag23 = (object)transform2 == null;
					num2 = 0;
					vector = (Vector3)0;
					obj4 = obj2;
					if (!flag23)
					{
						object obj55 = node * 28;
						object obj56 = (object)nodes + obj55;
						Vector3 vector4 = transform2.TransformPoint((Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						float num15 = UnityEngine.Random.Range(0f, 2f);
						object obj57 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v39+A0]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
						num5 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
						num4 = UnityEngine.Random.Range(1f, 0f);
						Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
						bool flag24 = obj2 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v35+28]");
						num10 = 0f;
						num2 = 0;
						vector = (Vector3)0;
						obj4 = obj2;
						if (!flag24)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							object obj59 = default;
							float num16 = num14 * (float)obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X8_v40+18]");
							object obj60 = default;
							float num17 = 0f * (float)obj60;
							float num18 = num13 * num15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X8_v40+20]");
							float num19 = 0f * num4;
							float num20 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
							float num21 = num20 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v35+28]");
							float num22 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							float num23 = num22 * 0f;
							float num24 = num16 + num17;
							float num25 = num18 + num19;
							float num26 = num24 + num21;
							float num27 = num25 + num23;
							Quaternion rotation = UnityEngine.Random.rotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
							object obj61 = 0;
							object obj62 = obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X0_v68+E4]");
							bool flag25 = (nint)0 == 0;
							object obj63 = !flag25;
							if (obj63 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj64 = obj61;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X0_v72+E4]");
							bool flag26 = (nint)0 == 0;
							object obj65 = !flag26;
							if (obj65 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj64 = obj61;
							}
							object obj66 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X0_v72+A0]");
							object obj67 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v14+8]");
							UnityEngine.Object obj68 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v49+E4]");
							bool flag27 = (nint)0 == 0;
							object obj69 = !flag27;
							if (obj69 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v14+8]");
							bool flag28 = (UnityEngine.Object)0 != null;
							bool flag29 = !flag28;
							UnityEngine.Object obj70 = null;
							if (!flag29)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v14+8]");
								bool flag30 = (nint)0 == 0;
								num11 = num24;
								num4 = num26;
								num10 = num25;
								num5 = num27;
								num2 = 0;
								vector = (Vector3)0;
								obj4 = obj2;
								if (flag30)
								{
									goto IL_111f;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X23_v8 (UnityEngine.Object)+B0]");
								obj70 = (UnityEngine.Object)0;
							}
							object obj71 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							num4 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							float num28 = 0f * num14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							object obj72 = default;
							float num29 = 0f * (float)obj72;
							float num30 = num13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
							float num31 = num30 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X0_v76+E4]");
							bool flag31 = (nint)0 == 0;
							object obj73 = !flag31;
							if (obj73 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num32 = num28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v35+20]");
							float num33 = num32 + 0f;
							float num34 = num29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v35+24]");
							float num35 = num34 + 0f;
							float num36 = num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v35+28]");
							float num37 = num36 + 0f;
							bool flag32 = obj70 != null;
							bool flag33 = !flag32;
							num2 = 0;
							UnityEngine.Object obj74 = null;
							if (!flag33)
							{
								bool flag34 = (object)obj70 == null;
								num11 = num24;
								num10 = num25;
								num5 = num14;
								num2 = 0;
								vector = (Vector3)0;
								obj4 = obj2;
								if (flag34)
								{
									goto IL_111f;
								}
								bool isRunning = ((NetworkRunner)obj70).IsRunning;
								bool flag35 = !isRunning;
								num2 = 0;
								obj74 = null;
								if (!flag35)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X9_v14+8]");
									bool flag36 = (nint)0 == 0;
									num11 = num24;
									num10 = num25;
									num5 = num14;
									num2 = 0;
									vector = (Vector3)0;
									obj4 = obj2;
									if (flag36)
									{
										goto IL_111f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X23_v8 (UnityEngine.Object)+A4]");
									bool flag37 = (nint)0 == 0;
									object obj75 = !flag37;
									num2 = 0;
									obj74 = null;
									if (obj75 == null)
									{
										bool flag38 = (object)gameObject == null;
										num11 = num24;
										num10 = num25;
										num5 = num14;
										num2 = 0;
										vector = (Vector3)0;
										obj4 = obj2;
										if (flag38)
										{
											goto IL_111f;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
										object obj76 = 0;
										num2 = (int)obj76;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
										object obj78 = default;
										object obj77 = obj78 & 1;
										bool flag39 = obj77 == null;
										NetworkObject prefab = default;
										obj74 = (UnityEngine.Object)(&prefab);
										if (!flag39)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
											object obj79 = 0;
											Vector3? position = (Vector3)obj79;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
											object obj80 = 0;
											Quaternion? quaternion = (Quaternion)obj80;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55A0]");
											object obj81 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55A8]");
											object obj82 = 0;
											NetworkRunner.OnBeforeSpawned onBeforeSpawned = default;
											onBeforeSpawned._002Ector(obj2, (IntPtr)obj82);
											Quaternion? quaternion2 = default;
											NetworkObject networkObject = ((NetworkRunner)obj70).Spawn(prefab, position, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion2), (NetworkRunner.OnBeforeSpawned)null, (NetworkSpawnFlags)(int)onBeforeSpawned);
											return;
										}
									}
								}
							}
							object obj83 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X0_v81+E4]");
							bool flag40 = (nint)0 == 0;
							object obj84 = !flag40;
							if (obj84 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
							object obj85 = 0;
							vector = (Vector3)obj85;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
							bool flag41 = (object)gameObject == null;
							num17 = num27;
							num19 = num24;
							num11 = num26;
							num18 = num25;
							num4 = num33;
							num10 = num37;
							num5 = num35;
							obj4 = obj2;
							if (!flag41)
							{
								string text4 = gameObject.name;
								UnityEngine.Object obj86 = default;
								bool flag42 = (object)obj86 == null;
								num17 = num27;
								num19 = num24;
								num11 = num26;
								num18 = num25;
								num4 = num33;
								num10 = num37;
								num5 = num35;
								vector = (Vector3)0;
								obj4 = obj2;
								if (!flag42)
								{
									obj86.name = text4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
									object obj87 = 0;
									num2 = (int)obj87;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
									object obj89 = default;
									object obj88 = obj89 & 1;
									if (obj88 == null)
									{
										return;
									}
									Rigidbody rigidbody = default;
									bool flag43 = (object)rigidbody == null;
									num17 = num27;
									num19 = num24;
									num11 = num26;
									num18 = num25;
									num4 = num33;
									num10 = num37;
									num5 = num35;
									vector = (Vector3)(&rigidbody);
									obj4 = obj2;
									if (!flag43)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3 (System.Object)+14]");
										num5 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3 (System.Object)+18]");
										num10 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3 (System.Object)+10]");
										num4 = 0f;
										rigidbody.linearVelocity = (Vector3)0;
										Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
										bool flag44 = (object)rigidbody == null;
										num17 = num27;
										num19 = num24;
										num11 = num26;
										num18 = num25;
										vector = (Vector3)0;
										obj4 = rigidbody;
										if (!flag44)
										{
											rigidbody.angularVelocity = (Vector3)0;
											return;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_111f;
		IL_0f9e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		bool flag45 = vector2 != (Vector3)(object)1;
		IndexOutOfRangeException ex2 = ex;
		if (!flag45)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj90 = default;
			nint num38 = (nint)obj90;
			vector = (Vector3)num38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj92 = default;
			object obj91 = obj92 & 1;
			bool flag46 = obj91 == null;
			obj4 = obj90;
			if (!flag46)
			{
				object obj93 = 0;
				obj4 = obj90;
				object obj95 = default;
				object obj94 = (object)(&obj95);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				if (obj90 != null)
				{
					nint num39 = (nint)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v893 @ X8_v16 (Il2CppClass<System.Object>)+188] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text5 = default;
					string text6 = default;
					string text7 = default;
					string message2 = text5 + (string)kind2 + text6 + text7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v39+E4]");
					bool flag47 = (nint)0 == 0;
					object obj96 = !flag47;
					if (obj96 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogError(message2);
					return;
				}
				goto IL_111f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj97 = obj4;
			vector2 = (Vector3)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			num2 = 0;
			IndexOutOfRangeException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_111f:
		throw new NullReferenceException();
	}

	private static int RollSize()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I4
		//IL_0492: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I8
		//IL_04d6: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I4
		//IL_0329: Expected I4, but got Obj
		//IL_00a1: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_03fb: Expected I4, but got Obj
		//IL_013d: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01ee: Invalid comparison between F4 and I
		//IL_0224: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02e3: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
		object obj6 = 0 & 0x80000000L;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v25+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v26+8]");
				obj5 = 0;
			}
			object obj11 = obj5 - 2;
			bool flag4 = (nint)obj11 < 0;
			object obj12 = obj5 ^ 2;
			object obj13 = obj5 ^ obj11;
			object obj14 = obj12 & obj13;
			bool flag5 = (nint)obj14 < 0;
			bool flag6 = flag4 == flag5;
			object obj15 = !flag6;
			object obj16 = ~obj15;
			if (obj16 != null)
			{
				obj5 = 2;
			}
			object obj17 = ~obj5;
			return obj5 & obj17;
		}
		float value = UnityEngine.Random.value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj18 = 0;
		object obj19 = obj18;
		float num = value;
		int num2 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16+A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v9+10]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v9+10]");
			if ((nint)0 != 0)
			{
				int num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v15+18]");
				if ((nint)num3 >= (nint)0)
				{
					num2 = 0;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16+E4]");
				bool flag8 = (nint)0 == 0;
				object obj23 = !flag8;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16+A0]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v19+10]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v19+10]");
					if ((nint)0 == 0)
					{
						goto IL_031b;
					}
				}
				int num4 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v15+18]");
				bool flag9 = (nint)num4 < (nint)0;
				object obj25 = !flag9;
				if (obj25 == null)
				{
					object obj26 = obj22 + num2;
					float num5 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v9+20]");
					if (num5 < 0f)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16+E4]");
					bool flag10 = (nint)0 == 0;
					object obj27 = !flag10;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v16+A0]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v17+10]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v17+10]");
						if ((nint)0 == 0)
						{
							goto IL_031b;
						}
					}
					int num6 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v15+18]");
					bool flag11 = (nint)num6 < (nint)0;
					object obj29 = !flag11;
					if (obj29 == null)
					{
						object obj30 = obj22 + num2;
						num2++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v16+20]");
						value = 0f;
						float num7 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v16+20]");
						num = num7 - 0f;
						continue;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			goto IL_031b;
			IL_031b:
			NullReferenceException ex2 = new NullReferenceException();
			return (int)ex2;
		}
		return num2;
	}

	private static GameObject ItemPrefab(string name)
	{
		//IL_02ee: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I8
		//IL_00f6: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7+A0]");
		object obj5 = 0;
		UnityEngine.Object obj6 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		GameObject result = null;
		if (obj8 == null)
		{
			if ((object)obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X20_v9 (UnityEngine.Object)+20]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X20_v9 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X22_v4+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X22_v4+18]");
						object obj10 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X20_v9 (UnityEngine.Object)+20]");
						object obj11 = (nint)0 + (nint)32;
						object obj12 = 0;
						object obj13 = 0;
						UnityEngine.Object obj14 = null;
						while (true)
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
							object obj15 = !flag4;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X24_v5+v85 @ X23_v6*8]");
								object obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X24_v5+v85 @ X23_v6*8]");
								if ((nint)0 != 0)
								{
									object obj17 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
									obj6 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v16+E4]");
									bool flag5 = (nint)0 == 0;
									object obj18 = !flag5;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag6 = obj6 != null;
									bool flag7 = !flag6;
									obj13 = 0;
									obj14 = null;
									if (!flag7)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
										string text = ((UnityEngine.Object)0).name;
										bool flag8 = text == name;
										bool flag9 = !flag8;
										object obj19 = !flag9;
										obj13 = 0;
										obj14 = (UnityEngine.Object)(object)name;
										if (obj19 != null)
										{
											goto IL_02ad;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X22_v4+18]");
								obj10 = 0;
								obj12++;
								object obj20 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X22_v4+18]");
								if ((nint)obj20 < 0)
								{
									continue;
								}
								goto IL_02a3;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							break;
						}
						goto IL_02d0;
					}
				}
				goto IL_02a3;
			}
			goto IL_02d0;
		}
		goto IL_02f3;
		IL_02a3:
		result = null;
		goto IL_02f3;
		IL_02f3:
		return result;
		IL_02d0:
		return (GameObject)(object)new NullReferenceException();
		IL_02ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X25_v6+10]");
		result = (GameObject)0;
		goto IL_02f3;
	}

	public GillaOreVeins()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5740]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5748]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5750]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5758]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 32;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 40;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 48;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 56;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<Unity.IL2CPP.Metadata.__Il2CppByteEnum, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj14 = this + 144;
		obj14 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaOreVeins()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 4294967295L;
	}

	private byte _003CRunHere_003Eb__41_0(int i)
	{
		//IL_00be: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		byte[] array = kinds;
		if (kinds != null)
		{
			bool flag = array.Length < i;
			object obj = !flag;
			object obj2 = array.Length - i;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = kinds + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				return 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2;
	}

	private byte _003CRunHere_003Eb__41_1(int i)
	{
		//IL_00be: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		byte[] array = kinds;
		if (kinds != null)
		{
			bool flag = array.Length < i;
			object obj = !flag;
			object obj2 = array.Length - i;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = kinds + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				return 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2;
	}
}
