using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public class GillaBloodied : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass39_1
	{
		public GillaStains.Sheet fading;

		internal void _003CPump_003Eb__2(Task _)
		{
			//IL_0010: Expected Obj, but got I
			//IL_005a: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaStains.Fade(fading);
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public ApePart part;

		internal bool _003COnTorn_003Eb__0(Dismemberment.Part p)
		{
			//IL_0053: Expected I4, but got Obj
			//IL_0031: Expected Obj, but got I4
			if (p != null)
			{
				object obj = p.id - part;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static readonly int MapId;

	private const int Fur = default(int);

	private static MaterialPropertyBlock block;

	private Dismemberment body;

	private DismemberGroup group;

	private SkinnedMeshRenderer[] skins;

	private Transform[][] bonesOf;

	private GillaStains.Sheet sheet;

	private float nextShow;

	private CosmeticWearer wearer;

	private readonly Dictionary<string, GillaStains.Sheet> wornSheets;

	private static readonly List<(string, Renderer, Mesh)> wornNow;

	private static Material overlay;

	private static bool overlayLooked;

	public GillaStains.Sheet Sheet => sheet;

	public bool Showing
	{
		get
		{
			//IL_0402: Expected I4, but got Obj
			//IL_0067: Expected Obj, but got I4
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_009e: Expected Obj, but got I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected I4, but got Unknown
			//IL_00e6: Expected Obj, but got I8
			//IL_00f6: Expected Obj, but got I
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_0112: Expected Obj, but got I4
			//IL_0448: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got I4
			//IL_0178: Expected Obj, but got I
			//IL_0194: Expected Obj, but got I4
			//IL_0199: Expected I, but got Obj
			//IL_0328: Expected Obj, but got I4
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected Obj, but got Unknown
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected Obj, but got Unknown
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected Obj, but got Unknown
			//IL_03a5: Expected Obj, but got I4
			//IL_01dd: Expected Obj, but got I
			//IL_01f9: Expected Obj, but got I4
			//IL_01fe: Expected I, but got Obj
			//IL_021d: Expected Obj, but got I
			//IL_0263: Expected Obj, but got I4
			//IL_0268: Expected I, but got Obj
			//IL_0287: Expected Obj, but got I
			//IL_02b5: Expected Obj, but got I4
			//IL_02fa: Expected Obj, but got I4
			//IL_0303: Expected Obj, but got I4
			//IL_0308: Expected I, but got Obj
			Find();
			GillaBloodied gillaBloodied = Painter();
			object obj5;
			if ((object)gillaBloodied != null)
			{
				SkinnedMeshRenderer[] array = gillaBloodied.skins;
				if (gillaBloodied.skins != null)
				{
					bool flag = array.Length < 0;
					bool flag2 = array.Length == 0;
					object obj = array.Length ^ array.Length;
					object obj2 = array.Length & obj;
					bool flag3 = (nint)obj2 < 0;
					bool flag4 = flag == flag3;
					object obj3 = !flag2;
					object obj4 = flag4 & obj3;
					bool flag5 = array.Length < 1;
					obj5 = obj4;
					if (flag5)
					{
						goto IL_03d3;
					}
					object obj6 = array.Length & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj7 = 0;
					object obj8 = gillaBloodied.skins + 32;
					object obj9 = 0;
					object obj10 = obj4;
					while (true)
					{
						bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj11 = !flag6;
						if (obj11 == null)
						{
							object obj12 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v11+E4]");
							bool flag7 = (nint)0 == 0;
							object obj13 = !flag7;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4+v61 @ X22_v5*8]");
							bool flag8 = (UnityEngine.Object)0 != null;
							bool flag9 = !flag8;
							object obj14 = 0;
							nint num = unchecked((nint)null);
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4+v61 @ X22_v5*8]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4+v61 @ X22_v5*8]");
								bool flag10 = ((Renderer)0).enabled;
								bool flag11 = !flag10;
								obj14 = 0;
								num = unchecked((nint)null);
								if (!flag11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4+v61 @ X22_v5*8]");
									GameObject gameObject = ((Component)0).gameObject;
									if ((object)gameObject == null)
									{
										break;
									}
									bool activeInHierarchy = gameObject.activeInHierarchy;
									bool flag12 = !activeInHierarchy;
									obj14 = 0;
									num = unchecked((nint)null);
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4+v61 @ X22_v5*8]");
										Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
										object obj15 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+E4]");
										bool flag13 = (nint)0 == 0;
										object obj16 = !flag13;
										if (obj16 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag14 = sharedMesh != null;
										bool flag15 = !flag14;
										object obj17 = !flag15;
										obj14 = 0;
										num = unchecked((nint)null);
										obj5 = obj10;
										if (obj17 != null)
										{
											goto IL_03d3;
										}
									}
								}
							}
							obj6 = array.Length;
							obj9++;
							object obj18 = obj9 - array.Length;
							bool flag16 = (nint)obj18 < 0;
							object obj19 = obj9 ^ array.Length;
							object obj20 = obj9 ^ obj18;
							object obj21 = obj19 & obj20;
							bool flag17 = (nint)obj21 < 0;
							bool flag18 = flag16 == flag17;
							object obj22 = !flag18;
							bool flag19 = (nint)obj9 < array.Length;
							obj5 = obj22;
							obj10 = obj22;
							if (flag19)
							{
								continue;
							}
							goto IL_03d3;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						break;
					}
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
			IL_03d3:
			return (byte)(obj5 & 1) != 0;
		}
	}

	private bool HasWorn
	{
		get
		{
			//IL_0095: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got I4
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected I4, but got Unknown
			if ((object)wornSheets != null)
			{
				int count = ((Dictionary<System.__Canon, System.__Canon>)(object)wornSheets).Count;
				bool flag = count < 0;
				bool flag2 = count == 0;
				int num = count ^ count;
				int num2 = count & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static GillaBloodied On(Dismemberment copy)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I
		if ((object)copy != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8858]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj5 = default;
			bool flag2 = obj5 == null;
			bool flag3 = !flag2;
			UnityEngine.Object obj6 = obj5;
			if (!flag3)
			{
				GameObject gameObject = copy.gameObject;
				if ((object)gameObject == null)
				{
					goto IL_010a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8860]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				UnityEngine.Object obj8 = default;
				obj6 = obj8;
			}
			if ((object)obj6 != null)
			{
				((GillaBloodied)obj6).Find();
				return (GillaBloodied)obj6;
			}
		}
		goto IL_010a;
		IL_010a:
		return (GillaBloodied)(object)new NullReferenceException();
	}

	public static GillaBloodied OnBody(GameObject body)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_0764: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I8
		//IL_0280: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I4
		//IL_07f5: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_059f: Expected Obj, but got I
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_0372: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I
		//IL_0440: Expected I4, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I4
		//IL_0568: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_07b7: Expected Obj, but got I
		//IL_04ce: Expected I4, but got Obj
		//IL_04ce: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I4
		//IL_0541: Expected Obj, but got I4
		UnityEngine.Object obj7;
		GillaStains.Sheet sheet2;
		object obj10;
		if ((object)body != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8868]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj5 = default;
			bool flag2 = obj5 == null;
			bool flag3 = !flag2;
			UnityEngine.Object obj6 = null;
			obj7 = obj5;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8860]");
				object obj8 = 0;
				obj6 = (UnityEngine.Object)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				UnityEngine.Object obj9 = default;
				obj7 = obj9;
			}
			if ((object)obj7 != null)
			{
				((GillaBloodied)obj7).Find();
				obj10 = obj7 + 64;
				bool flag4 = obj10 == null;
				object obj11 = !flag4;
				if (obj11 != null)
				{
					goto IL_06d7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj12;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v16+A0]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v12+8]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					object obj18 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v57+E4]");
					bool flag7 = (nint)0 == 0;
					object obj19 = !flag7;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj18 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v57+A0]");
					object obj20 = (nint)0 + (nint)8;
					obj20 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj6 = (UnityEngine.Object)(object)materialPropertyBlock;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X19_v5 (UnityEngine.Object)+30]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X19_v5 (UnityEngine.Object)+30]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X24_v5+18]");
					bool flag8 = (nint)0 < (nint)1;
					object obj22 = 0;
					if (flag8)
					{
						goto IL_05d9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X24_v5+18]");
					object obj23 = 0 & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X19_v5 (UnityEngine.Object)+30]");
					object obj25 = (nint)0 + (nint)32;
					object obj27 = default;
					object obj26 = obj27;
					object obj28 = 0;
					object obj29 = 0;
					while (true)
					{
						bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
						object obj30 = !flag9;
						if (obj30 != null)
						{
							break;
						}
						object obj31 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v28+E4]");
						bool flag10 = (nint)0 == 0;
						object obj32 = !flag10;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X27_v7+v68 @ X25_v8*8]");
						bool flag11 = (UnityEngine.Object)0 == null;
						bool flag12 = !flag11;
						object obj33 = !flag12;
						obj29 = 0;
						obj6 = null;
						if (obj33 != null)
						{
							goto IL_058f;
						}
						object obj34 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v33+E4]");
						bool flag13 = (nint)0 == 0;
						object obj35 = !flag13;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X27_v7+v68 @ X25_v8*8]");
						if ((nint)0 != 0)
						{
							object obj36 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v29+A0]");
							object obj37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X27_v7+v68 @ X25_v8*8]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v30+8]");
							((Renderer)num).GetPropertyBlock((MaterialPropertyBlock)0, 0);
							object obj38 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v31+A0]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v32+8]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v32+8]");
								bool flag14 = ((MaterialPropertyBlock)0).HasTexture((int)obj39);
								bool flag15 = !flag14;
								obj29 = 0;
								if (!flag15)
								{
									object obj40 = obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v40+E4]");
									bool flag16 = (nint)0 == 0;
									object obj41 = !flag16;
									if (obj41 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj40 = obj12;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v40+A0]");
									object obj42 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v35+8]");
									if ((nint)0 == 0)
									{
										goto IL_06dc;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v35+8]");
									Texture texture = ((MaterialPropertyBlock)0).GetTexture((int)obj42);
									object obj43 = obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v36+E4]");
									bool flag17 = (nint)0 == 0;
									object obj44 = !flag17;
									if (obj44 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									GillaStains.Sheet sheet = GillaStains.OfMap(texture);
									obj10 = sheet;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj29 = 0;
								}
								sheet2 = (GillaStains.Sheet)obj10;
								bool flag18 = obj10 == null;
								object obj45 = !flag18;
								obj26 = 0;
								obj6 = (UnityEngine.Object)obj10;
								obj22 = obj29;
								if (obj45 == null)
								{
									goto IL_058f;
								}
								goto IL_06a5;
							}
						}
						goto IL_06dc;
						IL_058f:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X24_v5+18]");
						obj23 = 0;
						obj28++;
						object obj46 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X24_v5+18]");
						bool flag19 = (nint)obj46 < 0;
						obj22 = obj29;
						if (flag19)
						{
							continue;
						}
						goto IL_05d9;
					}
					goto IL_06ea;
				}
			}
		}
		goto IL_06dc;
		IL_06a5:
		int users = sheet2.users + 1;
		sheet2.users = users;
		((GillaBloodied)obj7).Show(sheet2);
		goto IL_06d7;
		IL_06ea:
		return (GillaBloodied)(object)new IndexOutOfRangeException();
		IL_06d7:
		return (GillaBloodied)obj7;
		IL_05d9:
		sheet2 = (GillaStains.Sheet)obj10;
		bool flag20 = obj10 == null;
		object obj47 = !flag20;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj48 = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v22+E4]");
			bool flag21 = (nint)0 == 0;
			object obj50 = !flag21;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaStains.Sheet sheet3 = GillaStains.NewSheet();
			obj10 = sheet3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			sheet2 = (GillaStains.Sheet)obj10;
			if (obj10 == null)
			{
				goto IL_06dc;
			}
		}
		goto IL_06a5;
		IL_06dc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06ea;
	}

	public void Scratch(Vector3 at, Vector3 to, float width)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8870]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 1;
		_ = 0;
		Send((GillaStains.Job)obj2);
	}

	private void Find()
	{
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_00ff: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_0297: Expected Obj, but got I
		//IL_029f: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_0193: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I4
		//IL_031d: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0335: Expected I, but got Obj
		//IL_033e: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I4
		//IL_070e: Expected Obj, but got I
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I4
		//IL_0788: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0434: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I4
		//IL_0817: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I4
		//IL_08cf: Expected Obj, but got I4
		//IL_05f3: Expected Obj, but got I
		//IL_0603: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I
		//IL_08a0: Expected Obj, but got I
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05bb: Expected Obj, but got I
		//IL_05de: Expected Obj, but got I
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected Obj, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected Obj, but got Unknown
		//IL_0942: Expected Obj, but got I4
		object obj = this + 48;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4890]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = this + 32;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj8 = 0;
		if (flag3)
		{
			goto IL_01e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8830]");
		object obj10 = 0;
		nint num = (nint)obj10;
		Action action = default;
		action._002Ector(this, (IntPtr)obj10);
		bool flag4 = (object)body == null;
		object obj11 = 0;
		object obj12 = this;
		if (!flag4)
		{
			body.PartsReset += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4878]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8838]");
			object obj14 = 0;
			num = (nint)obj14;
			Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj14);
			bool flag5 = (object)body == null;
			obj11 = 0;
			obj12 = this;
			if (!flag5)
			{
				body.PartTorn += (Action<ApePart, GameObject>)(object)action2;
				obj11 = 0;
				obj8 = 0;
				goto IL_01e6;
			}
		}
		goto IL_0960;
		IL_0960:
		NullReferenceException ex = new NullReferenceException();
		goto IL_096e;
		IL_096e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_097c;
		IL_01e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8820]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
		object obj16 = this + 40;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8828]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj19 = this + 80;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
		object obj22 = 0;
		num = (nint)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj23 = default;
		bool flag6 = obj23 == null;
		obj12 = 1;
		if (flag6)
		{
			goto IL_0960;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v31+18]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v31+18]");
		bool flag7 = (nint)0 < (nint)1;
		obj12 = 1;
		if (flag7)
		{
			goto IL_068f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8850]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D88]");
		object obj26 = 0;
		nint num2 = (nint)obj22;
		object obj27 = 1;
		object obj28 = 0;
		while (true)
		{
			bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
			object obj29 = !flag8;
			num = num2;
			obj12 = obj27;
			if (obj29 != null)
			{
				break;
			}
			object obj30 = obj23 + obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
			bool flag9 = (nint)0 == 0;
			num = num2;
			obj12 = obj27;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
				Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
				object obj31 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v35+E4]");
				bool flag10 = (nint)0 == 0;
				object obj32 = !flag10;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = sharedMesh != null;
				bool flag12 = !flag11;
				num = 0;
				obj12 = null;
				if (flag12)
				{
					goto IL_063d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
				string text = ((UnityEngine.Object)0).name;
				bool flag13 = text == null;
				num = 0;
				obj12 = null;
				if (!flag13)
				{
					bool flag14 = text.StartsWith((string)obj25);
					bool flag15 = !flag14;
					num = 0;
					obj12 = obj25;
					if (flag15)
					{
						goto IL_063d;
					}
					bool flag16 = list == null;
					num = 0;
					obj12 = obj25;
					if (!flag16)
					{
						System.__Canon[] items = list._items;
						object obj33 = obj26;
						int version = list._version + 1;
						list._version = version;
						bool flag17 = list._items == null;
						num = 0;
						obj12 = obj25;
						if (!flag17)
						{
							bool flag18 = list._size < items.Length;
							object obj34 = !flag18;
							if (obj34 == null)
							{
								object obj35 = list._items + list._size;
								int size = list._size + 1;
								list._size = size;
								object obj36 = obj35 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
								obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
								obj12 = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X9_v12+20]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v39+A8]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v40+70]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
								list.AddWithResize((System.__Canon)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v34+20]");
								obj12 = 0;
							}
							goto IL_063d;
						}
					}
				}
			}
			goto IL_0960;
			IL_063d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v31+18]");
			obj24 = 0;
			obj28++;
			object obj39 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X0_v31+18]");
			bool flag19 = (nint)obj39 < 0;
			num2 = num;
			obj27 = obj12;
			if (flag19)
			{
				continue;
			}
			goto IL_068f;
		}
		goto IL_096e;
		IL_097c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_068f:
		if (list != null)
		{
			System.__Canon[] array = list.ToArray();
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj40 = obj;
			bool flag20 = obj == null;
			obj12 = array;
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8848]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj42 = this + 56;
				object obj43 = default;
				obj42 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X19_v5-8]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X19_v5-8]");
				bool flag21 = (nint)0 == 0;
				obj12 = obj43;
				if (!flag21)
				{
					object obj45 = obj43;
					object obj46 = 0;
					while (true)
					{
						object obj47 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v27+18]");
						if ((nint)obj47 >= 0)
						{
							return;
						}
						object obj48 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v27+18]");
						bool flag22 = (nint)obj48 < 0;
						object obj49 = !flag22;
						obj12 = obj45;
						if (obj49 != null)
						{
							break;
						}
						object obj50 = obj44 + obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v28+20]");
						bool flag23 = (nint)0 == 0;
						obj12 = obj45;
						if (!flag23)
						{
							object obj51 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v28+20]");
							Transform[] bones = ((SkinnedMeshRenderer)0).bones;
							bool flag24 = obj42 == null;
							obj12 = null;
							if (!flag24)
							{
								bool flag25 = bones == null;
								object obj52 = null;
								if (!flag25)
								{
									object obj53 = obj51;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v32+40]");
									obj52 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag26 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v32+40]");
									obj12 = 0;
									if (flag26)
									{
										goto IL_097c;
									}
								}
								object obj54 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X24_v6+18]");
								bool flag27 = (nint)obj54 < 0;
								object obj55 = !flag27;
								obj12 = obj52;
								if (obj55 != null)
								{
									break;
								}
								object obj56 = obj42 + obj46;
								obj46++;
								object obj57 = obj56 + 32;
								obj57 = bones;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								obj44 = obj;
								bool flag28 = obj == null;
								object obj58 = !flag28;
								obj12 = bones;
								obj45 = bones;
								if (obj58 != null)
								{
									continue;
								}
							}
						}
						goto IL_0960;
					}
					goto IL_096e;
				}
			}
		}
		goto IL_0960;
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
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
		if (body != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8830]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Action action = default;
			action._002Ector(this, (IntPtr)obj5);
			body.PartsReset -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4878]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8838]");
			object obj7 = 0;
			Action<Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon> action2 = default;
			action2._002Ector((object)this, (IntPtr)obj7);
			body.PartTorn -= (Action<ApePart, GameObject>)(object)action2;
		}
		LetGo(drawn: false);
	}

	public void Clear()
	{
		LetGo(drawn: true);
	}

	private unsafe void LetGo(bool drawn)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a6d: Expected VT, but got I4
		//IL_0a75: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_005d: Expected VT, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00be: Expected VT, but got Ref
		//IL_0119: Expected Obj, but got I4
		//IL_0136: Expected VT, but got Ref
		//IL_0cd0: Expected Ref, but got VT
		//IL_0cea: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I4
		//IL_0953: Expected VT, but got Ref
		//IL_0167: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got VT
		//IL_00fe: Expected VT, but got I
		//IL_09e5: Expected Obj, but got I4
		//IL_09ee: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0231: Expected VT, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got I
		//IL_0ae2: Expected Obj, but got I
		//IL_0b04: Expected Obj, but got I4
		//IL_02f7: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I4
		//IL_0b2d: Expected Obj, but got I
		//IL_0b4f: Expected I4, but got Obj
		//IL_03cc: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I8
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_040c: Expected Obj, but got I4
		//IL_0cb1: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I4
		//IL_0495: Expected I, but got Obj
		//IL_08f7: Expected Obj, but got I4
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I4
		//IL_0513: Expected I, but got Obj
		//IL_053e: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_0588: Expected VT, but got I
		//IL_05ba: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I4
		//IL_05f0: Expected I, but got Obj
		//IL_0600: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I
		//IL_0633: Expected I4, but got Obj
		//IL_0633: Expected Obj, but got I4
		//IL_064f: Expected VT, but got I4
		//IL_0658: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I4
		//IL_066f: Expected I, but got Obj
		//IL_0b7e: Expected Obj, but got I4
		//IL_0d2b: Expected Obj, but got I
		//IL_0d4b: Expected Obj, but got I4
		//IL_06af: Expected Obj, but got I4
		//IL_0ba4: Expected VT, but got I
		//IL_0bb5: Expected Obj, but got I
		//IL_0bd7: Expected Obj, but got I4
		//IL_07c5: Expected Obj, but got I
		//IL_06fb: Expected VT, but got I4
		//IL_0704: Expected Obj, but got I4
		//IL_070d: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I4
		//IL_071f: Expected Obj, but got I4
		//IL_0724: Expected I, but got Obj
		//IL_0c00: Expected Obj, but got I4
		//IL_0c05: Expected I, but got Obj
		//IL_0819: Expected Obj, but got I4
		//IL_075a: Expected Obj, but got I
		//IL_0767: Expected I4, but got Obj
		//IL_0790: Expected I, but got Obj
		//IL_0c2a: Expected VT, but got I
		//IL_0c5d: Expected Obj, but got I4
		//IL_0861: Expected Obj, but got I4
		//IL_088c: Expected Obj, but got I
		//IL_089e: Expected VT, but got I4
		//IL_089e: Expected I4, but got Obj
		//IL_089e: Expected Obj, but got I4
		//IL_08c8: Expected Obj, but got I4
		//IL_0c7b: Expected Obj, but got I
		//IL_0c8b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDD5E]");
		object obj = 0;
		bool flag = (object)wornSheets == null;
		object obj3 = default;
		object obj2 = obj3;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
		UnityEngine.Object obj4 = (UnityEngine.Object)drawn;
		GillaBloodied gillaBloodied = this;
		bool flag2 = drawn;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator4 = default;
		MaterialPropertyBlock materialPropertyBlock;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator5;
		Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator6;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8880]");
			obj = 0;
			obj4 = (UnityEngine.Object)obj;
			ValueCollection<> values = ((Dictionary<System.__Canon, System.__Canon>)(object)wornSheets).Values;
			bool flag3 = values == null;
			obj2 = obj3;
			enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
			gillaBloodied = this;
			flag2 = drawn;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8890]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8888]");
				SkinnedMeshRenderer[] array = (SkinnedMeshRenderer[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8878]");
				object obj6 = 0;
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator2 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)values.GetEnumerator();
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
				obj = obj3;
				while (true)
				{
					obj4 = (UnityEngine.Object)obj5;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ stack_-98+20]");
						enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(-1);
						obj = obj3;
						continue;
					}
					goto IL_0924;
				}
				obj2 = 0;
				enumerator = enumerator4;
				materialPropertyBlock = null;
				enumerator5 = enumerator4;
				enumerator6 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
				gillaBloodied = this;
				flag2 = drawn;
				MaterialPropertyBlock materialPropertyBlock2 = null;
				object obj9 = default;
				while (true)
				{
					obj4 = (UnityEngine.Object)(object)array;
					((Dictionary<System.__Canon, System.__Canon>.Enumerator*)enumerator6)->Dispose();
					bool flag4 = materialPropertyBlock2 == null;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						bool flag5 = obj2 == null;
						object obj8 = !flag5;
						OutOfMemoryException ex = (OutOfMemoryException)enumerator6;
						obj = obj2;
						if (obj8 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj4 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj2 = 1;
						obj = 1;
						materialPropertyBlock2 = materialPropertyBlock;
						continue;
					}
					if ((nint)obj4 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						materialPropertyBlock2 = (MaterialPropertyBlock)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						materialPropertyBlock = (MaterialPropertyBlock)obj9;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EA3C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				bool flag6 = (object)gillaBloodied.wornSheets == null;
				obj = obj2;
				if (!flag6)
				{
					((Dictionary<System.__Canon, System.__Canon>)(object)gillaBloodied.wornSheets).Clear();
					if (flag2)
					{
						gillaBloodied.NoneWorn();
					}
					object obj10 = gillaBloodied + 64;
					object obj11 = obj10;
					if (obj10 == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v5+20]");
					enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(-1);
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (!flag2 || gillaBloodied.skins == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
					obj6 = 0;
					object obj12 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v12+E4]");
					bool flag7 = (nint)0 == 0;
					object obj13 = !flag7;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X0_v12+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v9+8]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v9+8]");
					bool flag8 = (nint)0 == 0;
					object obj15 = !flag8;
					obj4 = null;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						MaterialPropertyBlock materialPropertyBlock3 = default;
						materialPropertyBlock3._002Ector();
						object obj17 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v62+E4]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v62+E4]");
						bool flag9 = (nint)0 == 0;
						object obj18 = !flag9;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj17 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v62+A0]");
						object obj19 = (nint)0 + (nint)8;
						obj19 = materialPropertyBlock3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj4 = (UnityEngine.Object)(object)materialPropertyBlock3;
						flag2 = (byte)(int)materialPropertyBlock3 != 0;
					}
					array = gillaBloodied.skins;
					if (gillaBloodied.skins != null)
					{
						if (array.Length < 1)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4860]");
						object obj21 = 0;
						obj = array.Length & 0xFFFFFFFFL;
						object obj22 = gillaBloodied.skins + 32;
						object obj23 = 0;
						while (true)
						{
							bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
							object obj24 = !flag10;
							if (obj24 != null)
							{
								break;
							}
							object obj25 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X27_v1+v120 @ X24_v1*8]");
							gillaBloodied = (GillaBloodied)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v15+E4]");
							bool flag11 = (nint)0 == 0;
							object obj26 = !flag11;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag12 = gillaBloodied == null;
							bool flag13 = !flag12;
							object obj27 = !flag13;
							nint num = unchecked((nint)null);
							obj4 = null;
							if (obj27 != null)
							{
								goto IL_08ed;
							}
							object obj28 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X0_v20+E4]");
							obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X0_v20+E4]");
							bool flag14 = (nint)0 == 0;
							object obj29 = !flag14;
							if (obj29 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag15 = (object)gillaBloodied == null;
							num = unchecked((nint)null);
							obj4 = null;
							if (!flag15)
							{
								object obj30 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v19+A0]");
								object obj31 = 0;
								GillaBloodied gillaBloodied2 = gillaBloodied;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v20+8]");
								((Renderer)(object)gillaBloodied2).GetPropertyBlock((MaterialPropertyBlock)0, 0);
								object obj32 = obj6;
								object obj33 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v21+A0]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v23+E4]");
								enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v42+8]");
								flag2 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v23+E4]");
								bool flag16 = (nint)0 == 0;
								object obj34 = !flag16;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag17 = !flag2;
								object obj35 = 0;
								num = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v20+8]");
								obj4 = (UnityEngine.Object)0;
								if (!flag17)
								{
									object obj36 = obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v23+A0]");
									object obj37 = 0;
									bool flag18 = ((MaterialPropertyBlock)flag2).HasColor((int)obj37);
									bool flag19 = !flag18;
									Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator7 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
									object obj38 = 0;
									object obj39 = 0;
									object obj40 = 0;
									num = unchecked((nint)null);
									obj4 = (UnityEngine.Object)obj37;
									if (!flag19)
									{
										object obj41 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v48+E4]");
										bool flag20 = (nint)0 == 0;
										object obj42 = !flag20;
										if (obj42 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj41 = obj6;
										}
										obj = obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v48+A0]");
										enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X9_v9 (System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>+Enumerator<System.__Canon, System.__Canon>)+8]");
										materialPropertyBlock2 = (MaterialPropertyBlock)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v42+E4]");
										bool flag21 = (nint)0 == 0;
										object obj43 = !flag21;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag22 = materialPropertyBlock2 == null;
										enumerator7 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
										obj38 = 0;
										obj39 = 0;
										obj40 = 0;
										obj35 = 0;
										num = unchecked((nint)null);
										obj4 = (UnityEngine.Object)obj37;
										flag2 = flag18;
										if (flag22)
										{
											goto IL_096d;
										}
										object obj44 = obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v37+A0]");
										object obj45 = 0;
										Color color = materialPropertyBlock2.GetColor((int)obj45);
										enumerator7 = enumerator5;
										obj38 = obj38;
										obj39 = obj39;
										obj40 = obj40;
										num = unchecked((nint)null);
										obj4 = (UnityEngine.Object)obj45;
									}
									object obj46 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v29+E4]");
									bool flag23 = (nint)0 == 0;
									object obj47 = !flag23;
									if (obj47 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj46 = obj6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v29+A0]");
									obj = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v42+8]");
									bool flag24 = (nint)0 == 0;
									obj35 = 0;
									flag2 = flag18;
									if (!flag24)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v42+8]");
										((MaterialPropertyBlock)0).Clear();
										bool flag25 = !flag18;
										MaterialPropertyBlock materialPropertyBlock4 = null;
										flag2 = flag18;
										if (!flag25)
										{
											object obj48 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v34+E4]");
											bool flag26 = (nint)0 == 0;
											object obj49 = !flag26;
											if (obj49 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj48 = obj6;
											}
											obj = obj21;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v34+A0]");
											enumerator3 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X9_v9 (System.Collections.Generic.Dictionary`2<System.__Canon, System.__Canon>+Enumerator<System.__Canon, System.__Canon>)+8]");
											flag2 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v42+E4]");
											bool flag27 = (nint)0 == 0;
											object obj50 = !flag27;
											if (obj50 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag28 = !flag2;
											obj35 = 0;
											obj4 = null;
											if (flag28)
											{
												goto IL_096d;
											}
											object obj51 = obj21;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v31+A0]");
											object obj52 = 0;
											((MaterialPropertyBlock)flag2).SetColor((int)obj52, (Color)0);
											object obj53 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v38+E4]");
											bool flag29 = (nint)0 == 0;
											object obj54 = !flag29;
											if (obj54 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj53 = obj6;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v38+A0]");
											object obj55 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v34+8]");
											materialPropertyBlock4 = (MaterialPropertyBlock)0;
											enumerator5 = enumerator7;
										}
										((Renderer)(object)gillaBloodied).SetPropertyBlock(materialPropertyBlock4, 0);
										obj35 = 0;
										num = unchecked((nint)null);
										obj4 = (UnityEngine.Object)(object)materialPropertyBlock4;
										goto IL_08ed;
									}
								}
							}
							goto IL_096d;
							IL_08ed:
							obj = array.Length;
							obj23++;
							if ((nint)obj23 >= array.Length)
							{
								return;
							}
						}
						goto IL_097b;
					}
				}
			}
		}
		goto IL_096d;
		IL_097b:
		throw new IndexOutOfRangeException();
		IL_096d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_097b;
		IL_0924:
		NullReferenceException ex3 = new NullReferenceException();
		obj2 = 0;
		enumerator = enumerator4;
		materialPropertyBlock = null;
		enumerator5 = enumerator4;
		enumerator6 = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(&enumerator);
		obj = obj3;
		gillaBloodied = this;
		flag2 = drawn;
		goto IL_096d;
	}

	private void OnTorn(ApePart part, GameObject piece)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01b1: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02bc: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = piece == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null || sheet == null)
		{
			return;
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = body == null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null)
		{
			return;
		}
		Dismemberment dismemberment = body;
		if (dismemberment.parts == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88F8]");
		object obj11 = 0;
		Predicate<System.__Canon> predicate = default;
		predicate._002Ector(obj2, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88E8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37ACF48");
		object obj13 = default;
		if (obj13 == null)
		{
			return;
		}
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v18+18]");
		if (!((UnityEngine.Object)0 != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88F0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
		object obj18 = default;
		object obj17 = obj18 & 1;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
			object obj19 = 0;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v18+18]");
			Renderer to = default;
			CarryOver((Renderer)0, to);
		}
	}

	public static void CarryOver(Renderer from, Renderer to)
	{
		//IL_0010: Expected Obj, but got I
		//IL_04bb: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I4
		//IL_05de: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0220: Expected I4, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0524: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I
		//IL_02f7: Expected I4, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_037c: Expected I4, but got Obj
		//IL_037c: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_0570: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = from == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = to == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+8]");
		bool flag8 = (nint)0 == 0;
		object obj12 = !flag8;
		UnityEngine.Object obj13 = null;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj15 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v51+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v51+A0]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj9 = obj8;
			obj13 = (UnityEngine.Object)(object)materialPropertyBlock;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v13+E4]");
		bool flag10 = (nint)0 == 0;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v12+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+8]");
		to.GetPropertyBlock((MaterialPropertyBlock)0, 0);
		object obj21 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v14+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15+8]");
		bool flag11 = ((MaterialPropertyBlock)0).HasTexture((int)obj22);
		bool flag12 = !flag11;
		object obj23 = !flag12;
		if (obj23 != null)
		{
			return;
		}
		object obj24 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v20+E4]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj26 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v17+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v18+8]");
		from.GetPropertyBlock((MaterialPropertyBlock)0, 0);
		object obj28 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v19+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v20+8]");
		if (!((MaterialPropertyBlock)0).HasTexture((int)obj29))
		{
			return;
		}
		object obj30 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v26+E4]");
		bool flag14 = (nint)0 == 0;
		object obj31 = !flag14;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v26+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v22+8]");
		Texture texture = ((MaterialPropertyBlock)0).GetTexture((int)obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
		object obj33 = 0;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v25+E4]");
		bool flag15 = (nint)0 == 0;
		object obj35 = !flag15;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaStains.Sheet sheet = GillaStains.OfMap(texture);
		if (sheet != null)
		{
			object obj36 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v33+E4]");
			bool flag16 = (nint)0 == 0;
			object obj37 = !flag16;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj36 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v33+A0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v27+8]");
			to.SetPropertyBlock((MaterialPropertyBlock)0, 0);
			int users = sheet.users + 1;
			sheet.users = users;
			GameObject gameObject = to.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8900]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			object obj41 = default;
			object obj40 = obj41 + 32;
			obj40 = sheet;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void Share()
	{
		//IL_07e6: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0254: Expected I, but got Obj
		//IL_0264: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I
		//IL_0140: Expected I4, but got I8
		//IL_015a: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I8
		//IL_04de: Expected Obj, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_08bd: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_0581: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I4
		//IL_0556: Expected Obj, but got I4
		//IL_088e: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_03d5: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I4
		//IL_05b9: Expected Obj, but got I4
		//IL_07fe: Expected Obj, but got I4
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I
		//IL_0606: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_075a: Expected Obj, but got I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0781: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I4
		//IL_0671: Expected Obj, but got I
		//IL_068d: Expected Obj, but got I4
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected Obj, but got Unknown
		//IL_06c8: Expected Obj, but got I4
		//IL_0705: Expected Obj, but got I4
		//IL_0731: Expected Obj, but got I
		bool flag = this.sheet == null;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = group != null;
		bool flag4 = !flag3;
		object obj5 = 0;
		System.__Canon _Canon;
		Dismemberment[] array;
		UnityEngine.Object obj6;
		if (!flag4)
		{
			DismemberGroup dismemberGroup = group;
			bool flag5 = (object)group == null;
			obj5 = 0;
			obj6 = null;
			if (flag5)
			{
				goto IL_07a6;
			}
			bool flag6 = dismemberGroup.copies == null;
			obj5 = 0;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FD8]");
				object obj7 = 0;
				_Canon = (System.__Canon)(object)body;
				obj5 = obj7;
				int num = Array.IndexOf((System.__Canon[])(object)dismemberGroup.copies, (System.__Canon)(object)body);
				int num2 = (int)(num & 0x80000000L);
				bool flag7 = num2 == 0;
				object obj8 = !flag7;
				if (obj8 == null)
				{
					DismemberGroup dismemberGroup2 = group;
					bool flag8 = (object)group == null;
					obj6 = body;
					if (!flag8)
					{
						array = dismemberGroup2.copies;
						bool flag9 = dismemberGroup2.copies == null;
						object obj9 = !flag9;
						if (obj9 != null)
						{
							goto IL_02f3;
						}
						obj6 = body;
					}
					goto IL_07a6;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8908]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Dismemberment[] array2 = default;
		bool flag10 = array2 == null;
		obj6 = (UnityEngine.Object)1;
		UnityEngine.Object obj11;
		NullReferenceException ex = default;
		if (!flag10)
		{
			bool flag11 = (object)body == null;
			obj11 = (UnityEngine.Object)1;
			if (!flag11)
			{
				nint num3 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v37 (Il2CppClass<Dismemberment[]>)+40]");
				obj11 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag12 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v37 (Il2CppClass<Dismemberment[]>)+40]");
				obj6 = (UnityEngine.Object)0;
				if (flag12)
				{
					goto IL_07b4;
				}
			}
			if (array2.Length != 0)
			{
				object obj12 = array2 + 32;
				obj12 = body;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_Canon = (System.__Canon)(object)body;
				array = array2;
				goto IL_02f3;
			}
			goto IL_0790;
		}
		goto IL_07a6;
		IL_02f3:
		object obj13 = array.Length & 0xFFFFFFFFL;
		bool flag13 = array.Length < 1;
		UnityEngine.Object obj14 = (UnityEngine.Object)(object)_Canon;
		UnityEngine.Object obj15 = null;
		if (flag13)
		{
			goto IL_04c4;
		}
		object obj16 = array + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj17 = 0;
		object obj18 = 0;
		object obj19 = obj5;
		obj11 = (UnityEngine.Object)(object)_Canon;
		object obj20 = obj13;
		GillaStains.Sheet sheet = null;
		while (true)
		{
			bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
			object obj21 = !flag14;
			obj5 = obj19;
			if (obj21 != null)
			{
				break;
			}
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v37+E4]");
			bool flag15 = (nint)0 == 0;
			object obj23 = !flag15;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X25_v8+v229 @ X23_v11*8]");
			bool flag16 = (UnityEngine.Object)0 == null;
			bool flag17 = !flag16;
			object obj24 = !flag17;
			if (obj24 == null)
			{
				object obj25 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v42+E4]");
				bool flag18 = (nint)0 == 0;
				object obj26 = !flag18;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X25_v8+v229 @ X23_v11*8]");
				GillaBloodied gillaBloodied = On((Dismemberment)0);
				bool flag19 = (object)gillaBloodied == null;
				obj5 = 0;
				obj6 = null;
				if (flag19)
				{
					goto IL_07a6;
				}
				if (gillaBloodied.sheet != null)
				{
					sheet = gillaBloodied.sheet;
				}
			}
			obj13 = array.Length;
			obj18++;
			bool flag20 = (nint)obj18 < array.Length;
			obj5 = 0;
			obj14 = null;
			obj15 = (UnityEngine.Object)(object)sheet;
			obj19 = 0;
			obj11 = null;
			obj20 = array.Length;
			if (flag20)
			{
				continue;
			}
			goto IL_04c4;
		}
		goto IL_0790;
		IL_04c4:
		bool flag21 = (object)obj15 == null;
		object obj27 = !flag21;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v33+E4]");
			bool flag22 = (nint)0 == 0;
			object obj30 = !flag22;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaStains.Sheet sheet2 = GillaStains.NewSheet();
			obj13 = array.Length;
			obj15 = (UnityEngine.Object)(object)sheet2;
		}
		if ((nint)obj13 < 1)
		{
			return;
		}
		object obj31 = array + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj32 = 0;
		object obj33 = 0;
		while (true)
		{
			bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
			object obj34 = !flag23;
			obj11 = obj14;
			if (obj34 != null)
			{
				break;
			}
			object obj35 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v18+E4]");
			bool flag24 = (nint)0 == 0;
			object obj36 = !flag24;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X25_v7+v230 @ X23_v8*8]");
			bool flag25 = (UnityEngine.Object)0 == null;
			bool flag26 = !flag25;
			object obj37 = !flag26;
			obj14 = null;
			if (obj37 == null)
			{
				object obj38 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v23+E4]");
				bool flag27 = (nint)0 == 0;
				object obj39 = !flag27;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X25_v7+v230 @ X23_v8*8]");
				GillaBloodied gillaBloodied2 = On((Dismemberment)0);
				bool flag28 = (object)gillaBloodied2 == null;
				obj5 = 0;
				obj6 = null;
				if (flag28)
				{
					goto IL_07a6;
				}
				object obj40 = gillaBloodied2 + 64;
				bool flag29 = obj40 == null;
				object obj41 = !flag29;
				obj14 = null;
				if (obj41 == null)
				{
					obj40 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag30 = (object)obj15 == null;
					obj5 = 0;
					obj6 = obj15;
					if (flag30)
					{
						goto IL_07a6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X20_v10 (UnityEngine.Object)+20]");
					object obj42 = (nint)0 + (nint)1;
					gillaBloodied2.Show((GillaStains.Sheet)(object)obj15);
					obj14 = obj15;
				}
			}
			obj13 = array.Length;
			obj33++;
			bool flag31 = (nint)obj33 < array.Length;
			obj5 = 0;
			if (!flag31)
			{
				return;
			}
		}
		goto IL_0790;
		IL_07a6:
		ex = new NullReferenceException();
		goto IL_07b4;
		IL_0790:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		obj6 = obj11;
		goto IL_07a6;
		IL_07b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private void Show(GillaStains.Sheet s)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I
		//IL_0440: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I8
		//IL_010f: Expected Obj, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_01e6: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_02da: Expected I4, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_0319: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		GillaStains.Sheet sheet = s;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v27+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v27+A0]");
			object obj9 = (nint)0 + (nint)8;
			obj9 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			sheet = (GillaStains.Sheet)(object)materialPropertyBlock;
		}
		SkinnedMeshRenderer[] array = skins;
		if (skins == null)
		{
			goto IL_0365;
		}
		if (array.Length < 1)
		{
			return;
		}
		object obj10 = array.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		object obj12 = skins + 32;
		object obj13 = 0;
		while (true)
		{
			bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			object obj14 = !flag4;
			if (obj14 != null)
			{
				break;
			}
			object obj15 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X25_v5+v102 @ X23_v6*8]");
			bool flag6 = (UnityEngine.Object)0 == null;
			bool flag7 = !flag6;
			object obj17 = !flag7;
			nint num = unchecked((nint)null);
			sheet = null;
			if (obj17 != null)
			{
				goto IL_032e;
			}
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X25_v5+v102 @ X23_v6*8]");
			if ((nint)0 != 0)
			{
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v17+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X25_v5+v102 @ X23_v6*8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v18+8]");
				((Renderer)num2).GetPropertyBlock((MaterialPropertyBlock)0, 0);
				if (s != null)
				{
					object obj22 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v19+A0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v20+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v20+8]");
						((MaterialPropertyBlock)0).SetTexture((int)obj23, s.map);
						object obj24 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v21+A0]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X25_v5+v102 @ X23_v6*8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v22+8]");
						((Renderer)num3).SetPropertyBlock((MaterialPropertyBlock)0, 0);
						num = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v22+8]");
						sheet = (GillaStains.Sheet)0;
						goto IL_032e;
					}
				}
			}
			goto IL_0365;
			IL_032e:
			obj10 = array.Length;
			obj13++;
			if ((nint)obj13 >= array.Length)
			{
				return;
			}
		}
		goto IL_0373;
		IL_0373:
		throw new IndexOutOfRangeException();
		IL_0365:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0373;
	}

	private void Update()
	{
		float time = Time.time;
		if (time < nextShow)
		{
			return;
		}
		float time2 = Time.time;
		float num = time2 + 1f;
		nextShow = num;
		if (sheet != null)
		{
			Show(sheet);
		}
		int count = ((Dictionary<System.__Canon, System.__Canon>)(object)wornSheets).Count;
		if (count <= 0)
		{
			GillaBloodied gillaBloodied = Painter();
			if (!gillaBloodied.HasWorn)
			{
				return;
			}
		}
		ShowWorn();
	}

	private unsafe void OnWorn(GillaStains.Job j)
	{
		//IL_100d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected I, but got Obj
		//IL_09e1: Expected Obj, but got I4
		//IL_09ea: Expected Obj, but got I4
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected Obj, but got I4
		//IL_0a09: Expected Obj, but got I4
		//IL_10bc: Expected Obj, but got I
		//IL_10cc: Expected Obj, but got I
		//IL_10dc: Expected Obj, but got I
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Expected Ref, but got Unknown
		//IL_1107: Expected Obj, but got I4
		//IL_0a28: Expected Obj, but got I4
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got Ref
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_04bb: Expected Obj, but got I
		//IL_04ea: Expected I, but got Obj
		//IL_03a0: Expected Obj, but got I4
		//IL_0aad: Expected Obj, but got I4
		//IL_03e5: Expected I, but got Obj
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0f83: Expected Obj, but got I4
		//IL_0a75: Expected Obj, but got I4
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Invalid comparison between Unknown and I4
		//IL_053c: Expected I, but got Obj
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0ee8: Expected Obj, but got I4
		//IL_0ef1: Expected Obj, but got I4
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_0442: Expected I, but got Obj
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0b21: Expected I, but got Obj
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got I
		//IL_0470: Expected Obj, but got I
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_05d8: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I4
		//IL_0b6f: Expected Obj, but got I
		//IL_0b77: Expected I, but got Obj
		//IL_0ba4: Expected I4, but got I8
		//IL_0bbe: Expected Obj, but got I4
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected I, but got Obj
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected I, but got Obj
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected I, but got Obj
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0c88: Expected Obj, but got I8
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Expected Obj, but got Unknown
		//IL_0cb1: Expected Obj, but got I4
		//IL_107b: Expected Obj, but got I4
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected I4, but got Obj
		//IL_0ce0: Expected Obj, but got I4
		//IL_0d0f: Expected Obj, but got I
		//IL_07fa: Expected Obj, but got I4
		//IL_0dcb: Expected Obj, but got I4
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Expected Obj, but got Unknown
		//IL_0dee: Expected I, but got Obj
		//IL_0879: Expected Obj, but got I
		//IL_0889: Expected Obj, but got I
		//IL_0d5a: Expected Obj, but got I4
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_0864: Expected I, but got Obj
		//IL_0d88: Expected Obj, but got I
		//IL_0da0: Expected I, but got Obj
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected Obj, but got I4
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		GillaBloodied gillaBloodied = Painter();
		bool flag = (object)gillaBloodied == null;
		System.__Canon value = null;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		GillaStains.Job job = j;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = gillaBloodied.wearer == null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v54+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Overlay())
			{
				return;
			}
			object obj8 = obj5;
			CosmeticWearer cosmeticWearer = gillaBloodied.wearer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v56+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = (object)cosmeticWearer == null;
			value = null;
			val = (Enumerator<, >)0;
			val2 = (Enumerator<, >)0;
			nint num = unchecked((nint)null);
			job = null;
			System.__Canon _Canon = (System.__Canon)(object)cosmeticWearer;
			if (!flag7)
			{
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v32+A0]");
				object obj11 = 0;
				CosmeticWearer cosmeticWearer2 = cosmeticWearer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v33+10]");
				cosmeticWearer2.Stainable((List<(string, Renderer, Mesh)>)0);
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v34+A0]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v35+10]");
				bool flag8 = (nint)0 == 0;
				value = null;
				val = (Enumerator<, >)0;
				val2 = (Enumerator<, >)0;
				GillaBloodied gillaBloodied2 = this;
				num = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v33+10]");
				job = (GillaStains.Job)0;
				_Canon = (System.__Canon)(object)cosmeticWearer;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v35+10]");
					Enumerator<, > enumerator = ((List<(System.__Canon, System.__Canon, System.__Canon)>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88B8]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8870]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8998]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8990]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8988]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
					object obj19 = 0;
					value = null;
					Enumerator<, > val4 = default;
					Enumerator<, > val3 = val4;
					Enumerator<, > val5 = default;
					val2 = val5;
					num = unchecked((nint)null);
					object obj29 = default;
					Enumerator<, > val6 = default;
					Renderer renderer = default;
					object obj34 = default;
					object obj36 = default;
					object obj38 = default;
					List<System.__Canon> list = default;
					object obj48;
					object obj49;
					Enumerator<, > val7;
					while (true)
					{
						UnityEngine.Object obj20 = (UnityEngine.Object)obj14;
						if (!val.MoveNext())
						{
							break;
						}
						if ((object)gillaBloodied.wornSheets == null)
						{
							goto IL_0e72;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8928]");
						object obj21 = 0;
						object obj22 = obj21;
						bool flag9 = ((Dictionary<System.__Canon, System.__Canon>)(object)gillaBloodied.wornSheets).TryGetValue((System.__Canon)val4, out value);
						bool flag10 = !flag9;
						object obj23 = !flag10;
						System.__Canon _Canon2 = (System.__Canon)(&value);
						System.__Canon _Canon3 = (System.__Canon)val4;
						if (obj23 == null)
						{
							object obj24 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v127+E4]");
							bool flag11 = (nint)0 == 0;
							object obj25 = !flag11;
							if (obj25 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							GillaStains.Sheet sheet = GillaStains.NewSheet();
							bool flag12 = sheet == null;
							value = (System.__Canon)(object)sheet;
							num = (nint)sheet;
							job = (GillaStains.Job)val4;
							_Canon = (System.__Canon)val4;
							if (flag12)
							{
								goto IL_0ed6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X0_v128 (GillaStains+Sheet)+20]");
							object obj26 = (nint)0 + (nint)1;
							bool flag13 = (object)gillaBloodied.wornSheets == null;
							value = (System.__Canon)(object)sheet;
							num = (nint)sheet;
							job = (GillaStains.Job)val4;
							_Canon = (System.__Canon)val4;
							if (flag13)
							{
								goto IL_0ec8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8980]");
							object obj27 = 0;
							obj22 = obj27;
							((Dictionary<System.__Canon, System.__Canon>)(object)gillaBloodied.wornSheets).set_Item((System.__Canon)val4, (System.__Canon)(object)sheet);
							value = (System.__Canon)(object)sheet;
							_Canon2 = (System.__Canon)(object)sheet;
							_Canon3 = (System.__Canon)val4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89A0]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj29._002Ector();
						bool flag14 = obj29 == null;
						num = (nint)_Canon2;
						obj20 = null;
						cosmeticWearer = (CosmeticWearer)obj29;
						if (!flag14)
						{
							object obj30 = obj29 + 16;
							obj30 = val6;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag15 = (int)val6 == 0;
							num = (nint)_Canon2;
							obj20 = (UnityEngine.Object)val6;
							if (!flag15)
							{
								string text = ((UnityEngine.Object)val6).name;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89A8]");
								object obj31 = 0;
								string text2 = (string)obj31 + text;
								object obj32 = obj29 + 24;
								obj32 = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								bool flag16 = (object)renderer == null;
								num = unchecked((nint)null);
								obj20 = (UnityEngine.Object)1;
								if (flag16)
								{
									goto IL_0e5c;
								}
								Matrix4x4 localToWorldMatrix = renderer.localToWorldMatrix;
								bool flag17 = obj34 == null;
								object obj35 = obj36;
								val3 = val4;
								val2 = val6;
								obj20 = null;
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X0_v98+18]");
									bool flag18 = (nint)0 == 0;
									obj35 = obj36;
									val3 = val4;
									val2 = val6;
									num = unchecked((nint)null);
									job = null;
									cosmeticWearer = (CosmeticWearer)obj29;
									if (flag18)
									{
										goto IL_0ea4;
									}
									object obj37 = obj29 + 40;
									obj37 = obj34;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									obj38._002Ector();
									bool flag19 = obj38 == null;
									obj35 = obj36;
									val3 = val4;
									val2 = val6;
									num = unchecked((nint)null);
									job = null;
									cosmeticWearer = (CosmeticWearer)obj29;
									if (flag19)
									{
										goto IL_0e96;
									}
									object obj39 = obj38 + 16;
									obj39 = value;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									obj20 = (UnityEngine.Object)obj17;
									list._002Ector();
									if (list != null)
									{
										System.__Canon[] items = list._items;
										int num2 = (int)obj18;
										int version = list._version + 1;
										list._version = version;
										if (list._items != null)
										{
											version = list._size;
											bool flag20 = list._size < items.Length;
											object obj40 = !flag20;
											if (obj40 == null)
											{
												object obj41 = list._items + list._size;
												num2 = list._size + 1;
												list._size = num2;
												object obj42 = obj41 + 32;
												obj42 = obj29;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												num = unchecked((nint)null);
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X9_v20 (System.Int32)+20]");
												object obj43 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v70+A8]");
												object obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v71+70]");
												num = 0;
												list.AddWithResize((System.__Canon)obj29);
											}
											object obj45 = obj38 + 24;
											obj45 = list;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag21 = j == null;
											obj35 = obj36;
											val3 = val4;
											val2 = val6;
											job = (GillaStains.Job)(object)list;
											_Canon = (System.__Canon)obj29;
											if (!flag21)
											{
												object obj46 = obj19;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X1 (GillaStains+Job)+28]");
												_ = 0;
												_ = j.point;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [j @ X1 (GillaStains+Job)+34]");
												_ = 0;
												_ = j.to;
												_ = j.line;
												_ = j.radius;
												val2 = (Enumerator<, >)j.stuff;
												_ = j.stuff;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X0_v118+E4]");
												bool flag22 = (nint)0 == 0;
												object obj47 = !flag22;
												if (obj47 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												GillaStains.Add((GillaStains.Job)obj38);
												obj35 = obj36;
												val3 = val4;
												cosmeticWearer = (CosmeticWearer)obj29;
												continue;
											}
											goto IL_0eba;
										}
									}
									NullReferenceException ex = new NullReferenceException();
									obj35 = obj36;
									val3 = val4;
									val2 = val6;
								}
								NullReferenceException ex2 = new NullReferenceException();
								num = unchecked((nint)null);
							}
							NullReferenceException ex3 = new NullReferenceException();
							goto IL_0e5c;
						}
						goto IL_0e80;
						IL_0e96:
						NullReferenceException ex4 = new NullReferenceException();
						goto IL_0ea4;
						IL_0e80:
						NullReferenceException ex5 = new NullReferenceException();
						job = (GillaStains.Job)(object)obj20;
						goto IL_0e96;
						IL_0ec8:
						NullReferenceException ex6 = new NullReferenceException();
						goto IL_0ed6;
						IL_0ed6:
						NullReferenceException ex7 = new NullReferenceException();
						obj48 = 0;
						obj49 = 0;
						val7 = (Enumerator<, >)(ref val);
						gillaBloodied2 = this;
						goto IL_0f03;
						IL_0ea4:
						IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
						_Canon = (System.__Canon)(object)cosmeticWearer;
						goto IL_0eba;
						IL_0e5c:
						NullReferenceException ex9 = new NullReferenceException();
						cosmeticWearer = (CosmeticWearer)obj29;
						goto IL_0e72;
						IL_0e72:
						NullReferenceException ex10 = new NullReferenceException();
						goto IL_0e80;
						IL_0eba:
						NullReferenceException ex11 = new NullReferenceException();
						goto IL_0ec8;
					}
					obj48 = 0;
					obj49 = 0;
					val7 = (Enumerator<, >)(ref val);
					gillaBloodied2 = this;
					object obj50 = 0;
					object obj51 = 7;
					object obj52;
					object obj53;
					object obj57 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						obj52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
						obj53 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88B0]");
						object obj54 = 0;
						job = (GillaStains.Job)obj54;
						((Enumerator<, >*)val7)->Dispose();
						bool flag23 = obj50 == null;
						object obj55 = !flag23;
						_Canon = (System.__Canon)(object)cosmeticWearer;
						if (obj55 == null)
						{
							bool flag24 = obj48 == null;
							object obj56 = !flag24;
							OutOfMemoryException ex12 = (OutOfMemoryException)val7;
							if (obj56 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex12 = new OutOfMemoryException();
							cosmeticWearer = (CosmeticWearer)(object)_Canon;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)job == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj48 = 1;
							obj50 = obj49;
						}
						else
						{
							if ((nint)job != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EA78");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj50 = obj57;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj49 = obj57;
						}
						obj51 = 0;
					}
					if ((nint)obj51 != 7)
					{
						bool flag25 = obj51 == null;
						object obj58 = !flag25;
						if (obj58 != null)
						{
							return;
						}
					}
					object obj59 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v6+E4]");
					bool flag26 = (nint)0 == 0;
					object obj60 = !flag26;
					if (obj60 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (gillaBloodied2.group != null)
					{
						DismemberGroup dismemberGroup = gillaBloodied2.group;
						bool flag27 = (object)gillaBloodied2.group == null;
						num = unchecked((nint)null);
						job = null;
						_Canon = (System.__Canon)(object)cosmeticWearer;
						if (flag27)
						{
							goto IL_0f03;
						}
						if (dismemberGroup.copies != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FD8]");
							object obj61 = 0;
							num = (nint)obj61;
							int num3 = Array.IndexOf((System.__Canon[])(object)dismemberGroup.copies, (System.__Canon)(object)gillaBloodied2.body);
							int num4 = (int)(num3 & 0x80000000L);
							bool flag28 = num4 == 0;
							object obj62 = !flag28;
							if (obj62 == null)
							{
								DismemberGroup dismemberGroup2 = gillaBloodied2.group;
								bool flag29 = (object)gillaBloodied2.group == null;
								job = (GillaStains.Job)(object)gillaBloodied2.body;
								_Canon = (System.__Canon)(object)cosmeticWearer;
								if (!flag29)
								{
									Dismemberment[] copies = dismemberGroup2.copies;
									bool flag30 = dismemberGroup2.copies == null;
									job = (GillaStains.Job)(object)gillaBloodied2.body;
									_Canon = (System.__Canon)(object)cosmeticWearer;
									if (!flag30)
									{
										if (copies.Length < 1)
										{
											return;
										}
										object obj63 = copies.Length & 0xFFFFFFFFL;
										_Canon = (System.__Canon)(dismemberGroup2.copies + 32);
										job = (GillaStains.Job)(object)gillaBloodied2.body;
										object obj64 = 0;
										while (true)
										{
											bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj63);
											object obj65 = !flag31;
											if (obj65 != null)
											{
												break;
											}
											object obj66 = obj52;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ X0_v15+E4]");
											bool flag32 = (nint)0 == 0;
											object obj67 = !flag32;
											if (obj67 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X22_v4 (System.__Canon)+v231 @ X21_v4*8]");
											if ((UnityEngine.Object)0 != null)
											{
												object obj68 = obj53;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X0_v20+E4]");
												bool flag33 = (nint)0 == 0;
												object obj69 = !flag33;
												if (obj69 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X22_v4 (System.__Canon)+v231 @ X21_v4*8]");
												GillaBloodied gillaBloodied3 = On((Dismemberment)0);
												bool flag34 = (object)gillaBloodied3 == null;
												num = unchecked((nint)null);
												job = null;
												if (flag34)
												{
													goto IL_0f03;
												}
												gillaBloodied3.ShowWorn();
											}
											obj63 = copies.Length;
											obj64++;
											bool flag35 = (nint)obj64 < copies.Length;
											num = unchecked((nint)null);
											job = null;
											if (!flag35)
											{
												return;
											}
										}
										goto IL_0f11;
									}
								}
								goto IL_0f03;
							}
						}
					}
					gillaBloodied2.ShowWorn();
					return;
				}
			}
		}
		goto IL_0f03;
		IL_0f03:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_0f11;
		IL_0f11:
		throw new IndexOutOfRangeException();
	}

	private unsafe void ShowWorn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1a8c: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Expected Obj, but got I4
		//IL_1be9: Expected Obj, but got I
		//IL_1c0b: Expected Obj, but got I4
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2124: Expected Obj, but got I4
		//IL_1c6e: Expected Obj, but got I
		//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Expected Obj, but got I4
		//IL_0f2b: Expected Obj, but got I
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Expected Obj, but got I
		//IL_0f4f: Expected Obj, but got I
		//IL_0f5f: Expected Obj, but got I
		//IL_0f6f: Expected Obj, but got I
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2f: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		//IL_03d3: Expected Obj, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_1611: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Unknown result type (might be due to invalid IL or missing references)
		//IL_162f: Expected Obj, but got I4
		//IL_162f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1633: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1648: Expected Obj, but got I4
		//IL_203e: Expected Obj, but got I
		//IL_2046: Unknown result type (might be due to invalid IL or missing references)
		//IL_204f: Expected Ref, but got Unknown
		//IL_2069: Expected Obj, but got I4
		//IL_2099: Unknown result type (might be due to invalid IL or missing references)
		//IL_209d: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got I
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1667: Expected Obj, but got I4
		//IL_1697: Unknown result type (might be due to invalid IL or missing references)
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected Obj, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got I
		//IL_052a: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I
		//IL_054a: Expected Obj, but got I
		//IL_170b: Unknown result type (might be due to invalid IL or missing references)
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1729: Expected Obj, but got I4
		//IL_1729: Unknown result type (might be due to invalid IL or missing references)
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected I, but got Obj
		//IL_1f61: Expected Obj, but got I
		//IL_1f82: Expected Obj, but got I
		//IL_1f92: Expected Obj, but got I
		//IL_1fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe6: Expected Obj, but got I4
		//IL_1ff4: Expected Obj, but got I4
		//IL_1ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2000: Unknown result type (might be due to invalid IL or missing references)
		//IL_2004: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_2010: Unknown result type (might be due to invalid IL or missing references)
		//IL_2014: Unknown result type (might be due to invalid IL or missing references)
		//IL_2018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got I
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got I4
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected Obj, but got I
		//IL_106d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Expected Obj, but got I4
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_0638: Expected Obj, but got I
		//IL_0662: Expected Obj, but got I4
		//IL_10d8: Expected Obj, but got I4
		//IL_1aaa: Expected Obj, but got I
		//IL_1aba: Expected Obj, but got I
		//IL_1acc: Expected I, but got Obj
		//IL_1add: Expected I, but got Obj
		//IL_1b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1c: Expected I, but got Obj
		//IL_1b3a: Expected Obj, but got I4
		//IL_1b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got I
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected Obj, but got I4
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected I4, but got Obj
		//IL_06b4: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I4
		//IL_06d7: Expected I, but got Obj
		//IL_06e7: Expected I, but got Obj
		//IL_11a7: Expected Obj, but got I4
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got I
		//IL_073c: Expected I, but got Obj
		//IL_075a: Expected Obj, but got I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Expected Obj, but got I
		//IL_1d22: Expected I, but got Obj
		//IL_1d37: Expected Obj, but got I
		//IL_1d4d: Expected I4, but got I8
		//IL_1d6c: Expected Obj, but got I4
		//IL_1d7c: Expected Obj, but got I
		//IL_14db: Expected Obj, but got I4
		//IL_07d2: Expected Obj, but got I
		//IL_07e8: Expected Obj, but got I
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got I
		//IL_0841: Expected I, but got Obj
		//IL_085f: Expected Obj, but got I4
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e15: Expected Obj, but got I
		//IL_1e2e: Expected I4, but got Obj
		//IL_1e2e: Expected Obj, but got I
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e52: Expected I, but got Obj
		//IL_1e60: Expected Obj, but got I4
		//IL_1e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e88: Expected I, but got Obj
		//IL_1e98: Expected Obj, but got I
		//IL_11e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Expected Obj, but got I4
		//IL_1211: Unknown result type (might be due to invalid IL or missing references)
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected Obj, but got I4
		//IL_1239: Expected I, but got Obj
		//IL_1249: Expected Obj, but got I
		//IL_08bf: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I4
		//IL_1514: Unknown result type (might be due to invalid IL or missing references)
		//IL_152f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1533: Unknown result type (might be due to invalid IL or missing references)
		//IL_1544: Expected I, but got Obj
		//IL_1552: Expected Obj, but got I4
		//IL_155a: Unknown result type (might be due to invalid IL or missing references)
		//IL_155e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_1572: Expected I, but got Obj
		//IL_1582: Expected Obj, but got I
		//IL_1269: Expected Obj, but got I4
		//IL_1271: Expected I, but got Obj
		//IL_12b8: Expected Obj, but got I4
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got VT
		//IL_0989: Expected Obj, but got I
		//IL_09ab: Expected I, but got Obj
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbf: Expected Obj, but got I4
		//IL_1dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1def: Expected Obj, but got I4
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_094f: Expected I, but got Obj
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected I, but got Obj
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Expected Obj, but got I
		//IL_15b9: Expected I4, but got Unknown
		//IL_15b9: Expected Obj, but got I
		//IL_15d1: Expected Obj, but got I
		//IL_15ea: Expected I4, but got Obj
		//IL_15ea: Expected Obj, but got I
		//IL_15f4: Expected I, but got Obj
		//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1604: Expected I4, but got Obj
		//IL_12ed: Expected Obj, but got I
		//IL_12fd: Expected Obj, but got I
		//IL_131c: Expected Obj, but got I4
		//IL_13ea: Expected Obj, but got I4
		//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1417: Expected Obj, but got I4
		//IL_1427: Unknown result type (might be due to invalid IL or missing references)
		//IL_142b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_1437: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1332: Expected I, but got Obj
		//IL_1342: Expected Obj, but got I
		//IL_135b: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected Obj, but got I4
		//IL_1391: Unknown result type (might be due to invalid IL or missing references)
		//IL_1395: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b9: Expected Obj, but got I
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Expected Obj, but got Unknown
		//IL_14a4: Expected I, but got Obj
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
		bool flag2 = wearer == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Overlay())
		{
			return;
		}
		GillaBloodied gillaBloodied = Painter();
		object obj8 = obj5;
		CosmeticWearer cosmeticWearer = wearer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v6+E4]");
		Enumerator<> val = (Enumerator<>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = (object)cosmeticWearer == null;
		System.__Canon[] array = null;
		System.__Canon value = null;
		Enumerator<, > val2 = (Enumerator<, >)0;
		CosmeticWearer cosmeticWearer2 = null;
		Enumerator<, > val3 = (Enumerator<, >)0;
		CosmeticWearer cosmeticWearer4 = default;
		CosmeticWearer cosmeticWearer3 = cosmeticWearer4;
		CosmeticWearer cosmeticWearer5 = null;
		Enumerator<> val4 = (Enumerator<>)0;
		Enumerator<> val5 = (Enumerator<>)0;
		nint num = 0;
		UnityEngine.Object obj10 = null;
		GillaBloodied gillaBloodied2 = this;
		CosmeticWearer cosmeticWearer7;
		System.__Canon _Canon;
		CosmeticWearer cosmeticWearer8;
		Enumerator<> val6;
		GillaBloodied gillaBloodied3;
		object obj24 = default;
		object obj25;
		nint num3 = default;
		System.__Canon[] array3 = default;
		System.__Canon _Canon2;
		CancellationTokenSource cancellationTokenSource = default;
		object obj34 = default;
		List<(System.__Canon, System.__Canon, System.__Canon)> list3;
		int num2;
		object obj23;
		Predicate<(System.__Canon, System.__Canon, System.__Canon)> predicate3;
		object obj20;
		List<(System.__Canon, System.__Canon, System.__Canon)> list2 = default;
		Enumerator<> val9;
		object obj44;
		UnityEngine.Object obj40;
		object obj43;
		CancellationTokenSource cancellationTokenSource4;
		IntPtr intPtr;
		System.__Canon[] array2;
		Enumerator<> val8;
		CosmeticWearer cosmeticWearer9;
		object obj42;
		object obj41;
		if (!flag6)
		{
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v21+A0]");
			object obj12 = 0;
			CosmeticWearer cosmeticWearer6 = cosmeticWearer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v22+10]");
			cosmeticWearer6.Stainable((List<(string, Renderer, Mesh)>)0);
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v49+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = gillaBloodied == this;
			bool flag9 = !flag8;
			cosmeticWearer7 = null;
			val3 = (Enumerator<, >)0;
			_Canon = (System.__Canon)(object)cosmeticWearer4;
			cosmeticWearer8 = null;
			val4 = (Enumerator<>)0;
			val6 = (Enumerator<>)0;
			num2 = 0;
			obj10 = this;
			gillaBloodied3 = this;
			if (flag9)
			{
				goto IL_0e3c;
			}
			bool flag10 = (object)wornSheets == null;
			array = null;
			value = null;
			val2 = (Enumerator<, >)0;
			cosmeticWearer2 = null;
			val3 = (Enumerator<, >)0;
			cosmeticWearer3 = cosmeticWearer4;
			cosmeticWearer5 = null;
			val4 = (Enumerator<>)0;
			val5 = (Enumerator<>)0;
			num = 0;
			obj10 = this;
			gillaBloodied2 = this;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8910]");
				object obj15 = 0;
				obj10 = (UnityEngine.Object)obj15;
				int count = ((Dictionary<System.__Canon, System.__Canon>)(object)wornSheets).Count;
				bool flag11 = count < 1;
				object obj16 = !flag11;
				bool flag12 = count < 1;
				cosmeticWearer7 = null;
				val3 = (Enumerator<, >)0;
				_Canon = (System.__Canon)(object)cosmeticWearer4;
				cosmeticWearer8 = null;
				val4 = (Enumerator<>)0;
				val6 = (Enumerator<>)0;
				num2 = 0;
				gillaBloodied3 = this;
				if (flag12)
				{
					goto IL_0e3c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
				object obj18 = 0;
				obj10 = (UnityEngine.Object)obj18;
				List<System.__Canon> list = default;
				list._002Ector();
				bool flag13 = (object)wornSheets == null;
				array = null;
				value = null;
				val2 = (Enumerator<, >)0;
				cosmeticWearer2 = null;
				val3 = (Enumerator<, >)0;
				cosmeticWearer3 = cosmeticWearer4;
				cosmeticWearer5 = null;
				val4 = (Enumerator<>)0;
				val5 = (Enumerator<>)0;
				cosmeticWearer = (CosmeticWearer)(object)list;
				num = 0;
				gillaBloodied2 = this;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8938]");
					object obj19 = 0;
					obj10 = (UnityEngine.Object)obj19;
					Dictionary<System.__Canon, System.__Canon>.KeyCollection keys = ((Dictionary<System.__Canon, System.__Canon>)(object)wornSheets).Keys;
					bool flag14 = keys == null;
					array = null;
					value = null;
					val2 = (Enumerator<, >)0;
					cosmeticWearer2 = null;
					val3 = (Enumerator<, >)0;
					cosmeticWearer3 = cosmeticWearer4;
					cosmeticWearer5 = null;
					val4 = (Enumerator<>)0;
					val5 = (Enumerator<>)0;
					cosmeticWearer = (CosmeticWearer)(object)list;
					num = 0;
					gillaBloodied2 = this;
					if (!flag14)
					{
						Enumerator<> enumerator = keys.GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8948]");
						obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8968]");
						array2 = (System.__Canon[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8970]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8960]");
						obj = 0;
						num = 0;
						object obj22 = default;
						Enumerator<> val7 = default;
						Predicate<(System.__Canon, System.__Canon, System.__Canon)> predicate = default;
						Predicate<(System.__Canon, System.__Canon, System.__Canon)> predicate2 = default;
						while (true)
						{
							if (val4.MoveNext())
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8978]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								obj22._002Ector();
								bool flag15 = obj22 == null;
								array = null;
								value = null;
								val2 = (Enumerator<, >)0;
								cosmeticWearer7 = null;
								val3 = (Enumerator<, >)0;
								obj23 = obj22;
								cosmeticWearer3 = null;
								obj24 = 0;
								cosmeticWearer8 = cosmeticWearer4;
								val4 = val7;
								val5 = val7;
								val8 = (Enumerator<>)(ref val4);
								cosmeticWearer = (CosmeticWearer)(object)list;
								obj25 = null;
								gillaBloodied3 = this;
								if (flag15)
								{
									break;
								}
								object obj26 = obj22 + 16;
								obj26 = cosmeticWearer4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
								object obj27 = 0;
								object obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X0_v161+E4]");
								bool flag16 = (nint)0 == 0;
								object obj29 = !flag16;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
									object obj30 = 0;
									obj28 = obj30;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1468 @ X0_v161+A0]");
								object obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v97+10]");
								list2 = (List<(System.__Canon, System.__Canon, System.__Canon)>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								num = (nint)obj5;
								predicate._002Ector(obj22, (IntPtr)obj5);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v97+10]");
								bool flag17 = (nint)0 == 0;
								array = null;
								value = null;
								val2 = (Enumerator<, >)0;
								cosmeticWearer7 = null;
								val3 = (Enumerator<, >)0;
								num3 = unchecked((nint)null);
								predicate2 = predicate;
								obj23 = obj22;
								cosmeticWearer3 = null;
								obj24 = 0;
								cosmeticWearer8 = cosmeticWearer4;
								val4 = val7;
								val5 = val7;
								val8 = (Enumerator<>)(ref val4);
								cosmeticWearer = (CosmeticWearer)(object)list;
								obj25 = obj22;
								gillaBloodied3 = this;
								if (!flag17)
								{
									num2 = (int)obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v97+10]");
									bool flag18 = ((List<(System.__Canon, System.__Canon, System.__Canon)>)0).Exists(predicate);
									bool flag19 = !flag18;
									object obj32 = !flag19;
									num3 = unchecked((nint)null);
									predicate2 = predicate;
									num = (nint)obj;
									if (obj32 != null)
									{
										continue;
									}
									bool flag20 = list == null;
									array = null;
									value = null;
									val2 = (Enumerator<, >)0;
									cosmeticWearer7 = null;
									val3 = (Enumerator<, >)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v97+10]");
									list3 = (List<(System.__Canon, System.__Canon, System.__Canon)>)0;
									num3 = unchecked((nint)null);
									predicate3 = predicate;
									obj23 = obj22;
									cosmeticWearer3 = null;
									obj24 = 0;
									cosmeticWearer8 = cosmeticWearer4;
									val4 = val7;
									array3 = array2;
									val5 = val7;
									val8 = (Enumerator<>)(ref val4);
									val9 = val;
									cosmeticWearer = (CosmeticWearer)(object)list;
									_Canon2 = (System.__Canon)(object)predicate;
									gillaBloodied3 = this;
									if (!flag20)
									{
										IntPtr cachedPtr = ((UnityEngine.Object)(object)list).m_CachedPtr;
										_Canon2 = (System.__Canon)obj26;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
										object obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v138 (System.Collections.Generic.List`1<System.__Canon>)+1C]");
										cancellationTokenSource = (CancellationTokenSource)((nint)0 + (nint)1);
										val9 = (Enumerator<>)obj33;
										bool flag21 = ((UnityEngine.Object)(object)list).m_CachedPtr == (IntPtr)0;
										array = null;
										value = null;
										val2 = (Enumerator<, >)0;
										cosmeticWearer7 = null;
										val3 = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v97+10]");
										list3 = (List<(System.__Canon, System.__Canon, System.__Canon)>)0;
										num3 = unchecked((nint)null);
										predicate3 = predicate;
										obj23 = obj22;
										cosmeticWearer3 = null;
										obj24 = 0;
										cosmeticWearer8 = cosmeticWearer4;
										val4 = val7;
										array3 = array2;
										val5 = val7;
										val8 = (Enumerator<>)(ref val4);
										cosmeticWearer = (CosmeticWearer)(object)list;
										gillaBloodied3 = this;
										if (!flag21)
										{
											cancellationTokenSource = ((MonoBehaviour)(object)list).m_CancellationTokenSource;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X8_v98 (System.IntPtr)+18]");
											obj34 = 0;
											CancellationTokenSource cancellationTokenSource2 = ((MonoBehaviour)(object)list).m_CancellationTokenSource;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X8_v98 (System.IntPtr)+18]");
											bool flag22 = (nint)cancellationTokenSource2 < 0;
											object obj35 = !flag22;
											if (obj35 == null)
											{
												object obj36 = (nint)((UnityEngine.Object)(object)list).m_CachedPtr + ((MonoBehaviour)(object)list).m_CancellationTokenSource;
												CancellationTokenSource cancellationTokenSource3 = (((MonoBehaviour)(object)list).m_CancellationTokenSource = (CancellationTokenSource)(((MonoBehaviour)(object)list).m_CancellationTokenSource + 1));
												object obj37 = obj36 + 32;
												obj37 = obj26;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												num3 = unchecked((nint)null);
												predicate2 = predicate;
												val = (Enumerator<>)cancellationTokenSource3;
												num = (nint)obj;
											}
											else
											{
												System.__Canon _Canon3 = (System.__Canon)val9._currentKey;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ X8_v99 (System.__Canon)+A8]");
												object obj38 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v100+70]");
												num = 0;
												list.AddWithResize((System.__Canon)obj26);
												num3 = unchecked((nint)null);
												predicate2 = predicate;
												val = val9;
											}
											continue;
										}
									}
									goto IL_173e;
								}
								goto IL_177a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8940]");
							object obj39 = 0;
							obj40 = (UnityEngine.Object)obj39;
							val4.Dispose();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
							obj42 = 0;
							array = null;
							value = null;
							val2 = (Enumerator<, >)0;
							cosmeticWearer2 = null;
							val3 = (Enumerator<, >)0;
							list3 = list2;
							obj43 = obj34;
							cancellationTokenSource4 = cancellationTokenSource;
							intPtr = num3;
							predicate3 = predicate2;
							obj23 = 7;
							cosmeticWearer3 = null;
							obj44 = 0;
							cosmeticWearer5 = cosmeticWearer4;
							val4 = val7;
							val5 = val7;
							val8 = (Enumerator<>)(ref val4);
							val9 = val;
							cosmeticWearer9 = (CosmeticWearer)(object)list;
							gillaBloodied2 = this;
							num2 = (int)num;
							throw new OutOfMemoryException();
						}
						goto IL_176c;
					}
				}
			}
		}
		goto IL_1834;
		IL_18d8:
		throw new OutOfMemoryException();
		IL_173e:
		NullReferenceException ex = new NullReferenceException();
		list2 = list3;
		array2 = array3;
		num = num2;
		obj25 = _Canon2;
		goto IL_176c;
		IL_186c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		obj43 = obj34;
		cancellationTokenSource4 = cancellationTokenSource;
		intPtr = num3;
		obj44 = obj24;
		array2 = array3;
		cosmeticWearer9 = cosmeticWearer;
		obj42 = obj5;
		obj40 = null;
		obj41 = obj;
		goto IL_18c9;
		IL_185e:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_186c;
		IL_1850:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_185e;
		IL_18c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_18d8;
		IL_1842:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_1850;
		IL_1834:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_1842;
		IL_17a4:
		NullReferenceException ex7 = new NullReferenceException();
		NullReferenceException ex8 = new NullReferenceException();
		cosmeticWearer9 = cosmeticWearer;
		obj42 = obj5;
		obj41 = obj;
		NullReferenceException ex9 = new NullReferenceException();
		obj10 = (UnityEngine.Object)obj25;
		NullReferenceException ex10 = new NullReferenceException();
		cosmeticWearer2 = cosmeticWearer7;
		cosmeticWearer5 = cosmeticWearer8;
		array3 = array2;
		cosmeticWearer = cosmeticWearer9;
		obj5 = obj42;
		gillaBloodied2 = gillaBloodied3;
		obj = obj41;
		goto IL_1834;
		IL_1788:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_1796;
		IL_1796:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_17a4;
		IL_177a:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_1788;
		IL_176c:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_177a;
		IL_0e3c:
		object obj45 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v75+E4]");
		bool flag23 = (nint)0 == 0;
		object obj46 = !flag23;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj45 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v75+A0]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v35+8]");
		bool flag24 = (nint)0 == 0;
		object obj48 = !flag24;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj50 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v126+E4]");
			bool flag25 = (nint)0 == 0;
			object obj51 = !flag25;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj50 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ X0_v126+A0]");
			object obj52 = (nint)0 + (nint)8;
			obj52 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj45 = obj5;
			obj10 = (UnityEngine.Object)(object)materialPropertyBlock;
			gillaBloodied3 = (GillaBloodied)(object)materialPropertyBlock;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v75+E4]");
		bool flag26 = (nint)0 == 0;
		object obj53 = !flag26;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj45 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v75+A0]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v39+10]");
		bool flag27 = (nint)0 == 0;
		array = null;
		value = null;
		val2 = (Enumerator<, >)0;
		cosmeticWearer2 = cosmeticWearer7;
		cosmeticWearer3 = (CosmeticWearer)(object)_Canon;
		cosmeticWearer5 = cosmeticWearer8;
		val5 = val6;
		num = num2;
		gillaBloodied2 = gillaBloodied3;
		if (flag27)
		{
			goto IL_1834;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v39+10]");
		Enumerator<, > enumerator2 = ((List<(System.__Canon, System.__Canon, System.__Canon)>)0).GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88B8]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8928]");
		list3 = (List<(System.__Canon, System.__Canon, System.__Canon)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88A8]");
		predicate3 = (Predicate<(System.__Canon, System.__Canon, System.__Canon)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8918]");
		obj20 = 0;
		array = null;
		value = null;
		val9 = (Enumerator<>)(ref val2);
		GillaBloodied gillaBloodied4 = default;
		Enumerator<, > val10 = default;
		System.__Canon _Canon4;
		while (true)
		{
			_Canon2 = (System.__Canon)obj23;
			if (!val2.MoveNext())
			{
				break;
			}
			if ((object)gillaBloodied != null)
			{
				if ((object)gillaBloodied.wornSheets != null)
				{
					num3 = (nint)list3;
					bool flag28 = ((Dictionary<System.__Canon, System.__Canon>)(object)gillaBloodied.wornSheets).TryGetValue(_Canon, out value);
					bool flag29 = !flag28;
					num2 = (int)(&value);
					gillaBloodied3 = gillaBloodied4;
					if (flag29)
					{
						continue;
					}
					bool flag30 = value == null;
					num2 = (int)(&value);
					_Canon2 = _Canon;
					gillaBloodied3 = gillaBloodied4;
					if (flag30)
					{
						goto IL_1702;
					}
					object obj55 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ stack_-D8_v12 (System.__Canon)+10]");
					cosmeticWearer = (CosmeticWearer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X0_v88+E4]");
					val9 = (Enumerator<>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X0_v88+E4]");
					bool flag31 = (nint)0 == 0;
					object obj56 = !flag31;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag32 = cosmeticWearer == null;
					bool flag33 = !flag32;
					object obj57 = !flag33;
					num2 = 0;
					gillaBloodied3 = gillaBloodied4;
					if (obj57 != null)
					{
						continue;
					}
					bool flag34 = (object)gillaBloodied4 == null;
					val2 = val10;
					_Canon4 = _Canon;
					list2 = list3;
					cosmeticWearer3 = null;
					obj24 = 0;
					array2 = array3;
					val5 = (Enumerator<>)val10;
					val8 = (Enumerator<>)(ref val2);
					val = val9;
					num = 0;
					obj25 = null;
					gillaBloodied3 = gillaBloodied4;
					if (!flag34)
					{
						Material[] sharedMaterials = ((Renderer)(object)gillaBloodied4).sharedMaterials;
						object obj58 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X0_v95+E4]");
						bool flag35 = (nint)0 == 0;
						object obj59 = !flag35;
						if (obj59 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj58 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1588 @ X0_v95+A0]");
						object obj60 = 0;
						nint num4 = (nint)predicate3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X8_v48+18]");
						int num5 = Array.IndexOf((System.__Canon[])(object)sharedMaterials, (System.__Canon)0);
						int num6 = (int)(num5 & 0x80000000L);
						bool flag36 = num6 == 0;
						array = (System.__Canon[])(object)sharedMaterials;
						cosmeticWearer = (CosmeticWearer)num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X8_v48+18]");
						Material[] array4 = (Material[])0;
						if (!flag36)
						{
							bool flag37 = sharedMaterials == null;
							array = (System.__Canon[])(object)sharedMaterials;
							val2 = val10;
							_Canon4 = _Canon;
							cosmeticWearer2 = cosmeticWearer7;
							cosmeticWearer3 = null;
							obj24 = 0;
							cosmeticWearer5 = cosmeticWearer8;
							val5 = (Enumerator<>)val10;
							val8 = (Enumerator<>)(ref val2);
							val = val9;
							cosmeticWearer = (CosmeticWearer)num5;
							num = (nint)predicate3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1590 @ X8_v48+18]");
							obj10 = (UnityEngine.Object)0;
							gillaBloodied2 = gillaBloodied4;
							if (flag37)
							{
								goto IL_1842;
							}
							cosmeticWearer = (CosmeticWearer)sharedMaterials.Length;
							num = (nint)obj20;
							int num7 = sharedMaterials.Length + 1;
							Array.Resize(ref array, num7);
							object obj61 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v108+E4]");
							bool flag38 = (nint)0 == 0;
							object obj62 = !flag38;
							if (obj62 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj61 = obj5;
							}
							bool flag39 = array == null;
							val2 = val10;
							_Canon4 = _Canon;
							cosmeticWearer2 = cosmeticWearer7;
							cosmeticWearer3 = null;
							obj24 = 0;
							cosmeticWearer5 = cosmeticWearer8;
							array3 = array;
							val5 = (Enumerator<>)val10;
							val8 = (Enumerator<>)(ref val2);
							val = val9;
							obj10 = (UnityEngine.Object)num7;
							gillaBloodied2 = gillaBloodied4;
							if (flag39)
							{
								goto IL_185e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v108+A0]");
							object obj63 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1691 @ X8_v57+18]");
							object obj64 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1691 @ X8_v57+18]");
							bool flag40 = (nint)0 == 0;
							UnityEngine.Object obj65 = (UnityEngine.Object)num7;
							if (!flag40)
							{
								nint num8 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v60 (Il2CppClass<System.__Canon[]>)+40]");
								obj65 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag41 = ex3 == null;
								val2 = val10;
								_Canon4 = _Canon;
								cosmeticWearer2 = cosmeticWearer7;
								cosmeticWearer3 = null;
								obj24 = 0;
								cosmeticWearer5 = cosmeticWearer8;
								array3 = array;
								val5 = (Enumerator<>)val10;
								val8 = (Enumerator<>)(ref val2);
								val = val9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v60 (Il2CppClass<System.__Canon[]>)+40]");
								obj10 = (UnityEngine.Object)0;
								gillaBloodied2 = gillaBloodied4;
								if (flag41)
								{
									goto IL_186c;
								}
							}
							bool flag42 = (nint)cosmeticWearer < array.Length;
							object obj16 = !flag42;
							val2 = val10;
							_Canon4 = _Canon;
							cosmeticWearer2 = cosmeticWearer7;
							cosmeticWearer3 = null;
							obj24 = 0;
							cosmeticWearer5 = cosmeticWearer8;
							array3 = array;
							val5 = (Enumerator<>)val10;
							val8 = (Enumerator<>)(ref val2);
							val = val9;
							obj10 = obj65;
							gillaBloodied2 = gillaBloodied4;
							if (obj16 != null)
							{
								goto IL_1850;
							}
							object obj66 = (object)array + (object)cosmeticWearer;
							object obj67 = obj66 + 32;
							obj67 = obj64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							((Renderer)(object)gillaBloodied4).sharedMaterials = (Material[])(object)array;
							array3 = array;
							num4 = unchecked((nint)null);
							array4 = (Material[])(object)array;
						}
						object obj68 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1671 @ X0_v100+E4]");
						bool flag43 = (nint)0 == 0;
						object obj69 = !flag43;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj68 = obj5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1671 @ X0_v100+A0]");
						object obj70 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X8_v51+8]");
						((Renderer)(object)gillaBloodied4).GetPropertyBlock((MaterialPropertyBlock)0, (int)cosmeticWearer);
						bool flag44 = value == null;
						val2 = val10;
						_Canon4 = _Canon;
						num3 = unchecked((nint)null);
						cosmeticWearer3 = null;
						obj24 = 0;
						array2 = array3;
						val5 = (Enumerator<>)val10;
						val8 = (Enumerator<>)(ref val2);
						val = val9;
						num = (nint)cosmeticWearer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X8_v51+8]");
						obj25 = 0;
						gillaBloodied3 = gillaBloodied4;
						if (flag44)
						{
							goto IL_1788;
						}
						object obj71 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1685 @ X9_v26+A0]");
						val = (Enumerator<>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X9_v13 (System.Collections.Generic.List`1<System.__Canon>+ValueCollection<System.__Canon, System.__Canon>+Enumerator<System.__Canon, System.__Canon>)+8]");
						bool flag45 = (nint)0 == 0;
						val2 = val10;
						_Canon4 = _Canon;
						num3 = unchecked((nint)null);
						cosmeticWearer3 = null;
						obj24 = 0;
						array2 = array3;
						val5 = (Enumerator<>)val10;
						val8 = (Enumerator<>)(ref val2);
						num = (nint)cosmeticWearer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X8_v51+8]");
						obj25 = 0;
						gillaBloodied3 = gillaBloodied4;
						if (!flag45)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X9_v13 (System.Collections.Generic.List`1<System.__Canon>+ValueCollection<System.__Canon, System.__Canon>+Enumerator<System.__Canon, System.__Canon>)+8]");
							nint num9 = 0;
							Enumerator<> val11 = val;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ stack_-D8_v12 (System.__Canon)+10]");
							((MaterialPropertyBlock)num9).SetTexture((int)val11, (Texture)0);
							object obj72 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X8_v53+A0]");
							object obj73 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v54+8]");
							((Renderer)(object)gillaBloodied4).SetPropertyBlock((MaterialPropertyBlock)0, (int)cosmeticWearer);
							num3 = unchecked((nint)null);
							val9 = val;
							num2 = (int)cosmeticWearer;
							gillaBloodied3 = gillaBloodied4;
							continue;
						}
						goto IL_1796;
					}
					goto IL_17a4;
				}
			}
			else
			{
				NullReferenceException ex15 = new NullReferenceException();
			}
			NullReferenceException ex16 = new NullReferenceException();
			goto IL_1702;
			IL_1702:
			NullReferenceException ex17 = new NullReferenceException();
			val2 = val10;
			_Canon4 = _Canon;
			cosmeticWearer3 = null;
			obj24 = 0;
			val5 = (Enumerator<>)val10;
			val8 = (Enumerator<>)(ref val2);
			goto IL_173e;
		}
		val2 = val10;
		_Canon4 = _Canon;
		cosmeticWearer3 = null;
		obj44 = 0;
		Enumerator<, > val12 = val10;
		Enumerator<, > val13 = (Enumerator<, >)(ref val2);
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88B0]");
		object obj75 = 0;
		obj40 = (UnityEngine.Object)obj75;
		((Enumerator<, >*)val13)->Dispose();
		bool flag46 = obj74 == null;
		object obj76 = !flag46;
		cosmeticWearer2 = cosmeticWearer7;
		obj43 = obj34;
		cancellationTokenSource4 = cancellationTokenSource;
		intPtr = num3;
		cosmeticWearer5 = cosmeticWearer8;
		array2 = array3;
		val5 = (Enumerator<>)val12;
		val8 = (Enumerator<>)val13;
		cosmeticWearer9 = cosmeticWearer;
		obj42 = obj5;
		num = num2;
		gillaBloodied2 = gillaBloodied3;
		obj41 = obj;
		if (obj76 == null)
		{
			bool flag47 = (object)cosmeticWearer3 == null;
			object obj77 = !flag47;
			cosmeticWearer2 = cosmeticWearer7;
			obj43 = obj34;
			cancellationTokenSource4 = cancellationTokenSource;
			intPtr = num3;
			cosmeticWearer5 = cosmeticWearer8;
			array2 = array3;
			val5 = (Enumerator<>)val12;
			val8 = (Enumerator<>)val13;
			cosmeticWearer9 = cosmeticWearer;
			obj42 = obj5;
			num = num2;
			ex2 = (ArgumentNullException)val13;
			gillaBloodied2 = gillaBloodied3;
			obj41 = obj;
			if (obj77 == null)
			{
				return;
			}
			goto IL_18c9;
		}
		goto IL_18d8;
	}

	private unsafe void NoneWorn()
	{
		//IL_057f: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I4
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got I4
		//IL_0687: Expected Obj, but got I
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Ref, but got Unknown
		//IL_06b2: Expected Obj, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Invalid comparison between Unknown and I4
		//IL_041d: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got I4
		//IL_05ea: Expected Obj, but got I
		//IL_0607: Expected Obj, but got I
		//IL_061d: Expected I4, but got I8
		//IL_0637: Expected Obj, but got I4
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		int num = 0;
		int value = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2 (System.Int32)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = wearer == null;
		bool flag3 = !flag2;
		object obj2 = !flag3;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		int value2 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v8+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6 (System.Int32)+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X9_v4 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`3<System.__Canon, System.__Canon, System.__Canon>>+Enumerator<System.ValueTuple`3<System.__Canon, System.__Canon, System.__Canon>>)+18]");
		bool flag6 = (UnityEngine.Object)0 == null;
		bool flag7 = !flag6;
		object obj7 = !flag7;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj9 = !flag8;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = (object)wearer == null;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		Enumerator<, > val4 = (Enumerator<, >)0;
		Enumerator<, > val5 = (Enumerator<, >)0;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		if (!flag9)
		{
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v16+A0]");
			object obj13 = 0;
			CosmeticWearer cosmeticWearer = wearer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v17+10]");
			cosmeticWearer.Stainable((List<(string, Renderer, Mesh)>)0);
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+A0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v19+10]");
			bool flag10 = (nint)0 == 0;
			val2 = val3;
			val4 = (Enumerator<, >)0;
			val5 = (Enumerator<, >)0;
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v17+10]");
			obj11 = (UnityEngine.Object)0;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v19+10]");
				Enumerator<, > enumerator = ((List<(System.__Canon, System.__Canon, System.__Canon)>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88B8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88A8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4210]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88D8]");
				object obj19 = 0;
				obj10 = 0;
				Renderer renderer = default;
				List<System.__Canon> list = default;
				Enumerator<, > val6 = default;
				object obj30 = default;
				object obj25;
				Enumerator<, > val7;
				Enumerator<, > val8;
				while (true)
				{
					obj11 = (UnityEngine.Object)obj16;
					if (val4.MoveNext())
					{
						if ((object)renderer != null)
						{
							Material[] sharedMaterials = renderer.sharedMaterials;
							object obj20 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v46+E4]");
							bool flag11 = (nint)0 == 0;
							object obj21 = !flag11;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj20 = obj3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v46+A0]");
							object obj22 = 0;
							obj10 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v27+18]");
							int num2 = Array.IndexOf((System.__Canon[])(object)sharedMaterials, (System.__Canon)0);
							int num3 = (int)(num2 & 0x80000000L);
							bool flag12 = num3 == 0;
							object obj23 = !flag12;
							if (obj23 == null)
							{
								renderer.SetPropertyBlock(null, num2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								obj10 = obj19;
								list._002Ector((IEnumerable<System.__Canon>)(object)sharedMaterials);
								bool flag13 = list == null;
								object obj24 = 0;
								obj11 = (UnityEngine.Object)(object)sharedMaterials;
								if (flag13)
								{
									break;
								}
								list.RemoveAt(num2);
								System.__Canon[] sharedMaterials2 = list.ToArray();
								renderer.sharedMaterials = (Material[])(object)sharedMaterials2;
								obj24 = 0;
								obj10 = 0;
							}
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						break;
					}
					val2 = (Enumerator<, >)0;
					obj25 = 0;
					val = (Enumerator<, >)(ref val4);
					val4 = val6;
					val7 = val3;
					val5 = val6;
					val8 = (Enumerator<, >)(ref val4);
					object obj26 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C88B0]");
						object obj27 = 0;
						obj11 = (UnityEngine.Object)obj27;
						((Enumerator<, >*)val8)->Dispose();
						bool flag14 = obj26 == null;
						object obj28 = !flag14;
						if (obj28 == null)
						{
							bool flag15 = (int)val2 == 0;
							object obj29 = !flag15;
							OutOfMemoryException ex2 = (OutOfMemoryException)val8;
							if (obj29 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex2 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj11 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							val2 = (Enumerator<, >)1;
							obj26 = obj25;
							continue;
						}
						if ((nint)obj11 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj26 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj25 = obj30;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289EA78");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				NullReferenceException ex3 = new NullReferenceException();
				val2 = (Enumerator<, >)0;
				obj25 = 0;
				val = (Enumerator<, >)(ref val4);
				val4 = val6;
				val7 = val3;
				val5 = val6;
				val8 = (Enumerator<, >)(ref val4);
			}
		}
		throw new NullReferenceException();
	}

	private static bool Overlay()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8+20]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v12+A0]");
				obj4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89B0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
			object obj9 = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9+A0]");
			object obj11 = (nint)0 + (nint)24;
			object obj12 = default;
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v3+18]");
		return (UnityEngine.Object)0 != null;
	}

	private GillaBloodied Painter()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00e8: Expected I4, but got I8
		//IL_0102: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I8
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_01f6: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I4
		//IL_0385: Expected Obj, but got I
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
		if (group != null)
		{
			DismemberGroup dismemberGroup = group;
			if ((object)group == null)
			{
				goto IL_039c;
			}
			if (dismemberGroup.copies != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5FD8]");
				object obj4 = 0;
				System.__Canon _Canon = (System.__Canon)(object)body;
				object obj5 = obj4;
				int num = Array.IndexOf((System.__Canon[])(object)dismemberGroup.copies, (System.__Canon)(object)body);
				int num2 = (int)(num & 0x80000000L);
				bool flag2 = num2 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					DismemberGroup dismemberGroup2 = group;
					if ((object)group != null)
					{
						Dismemberment[] copies = dismemberGroup2.copies;
						if (dismemberGroup2.copies != null)
						{
							if (copies.Length < 1)
							{
								goto IL_031b;
							}
							object obj7 = copies.Length & 0xFFFFFFFFL;
							object obj8 = dismemberGroup2.copies + 32;
							object obj9 = 0;
							while (true)
							{
								bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
								object obj10 = !flag3;
								if (obj10 == null)
								{
									object obj11 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X24_v4+v138 @ X23_v5*8]");
									UnityEngine.Object obj12 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v14+E4]");
									bool flag4 = (nint)0 == 0;
									object obj13 = !flag4;
									if (obj13 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X24_v4+v138 @ X23_v5*8]");
									bool flag5 = (UnityEngine.Object)0 != null;
									bool flag6 = !flag5;
									_Canon = null;
									if (!flag6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X24_v4+v138 @ X23_v5*8]");
										if ((nint)0 == 0)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v7 (UnityEngine.Object)+28]");
										bool flag7 = (nint)0 == 0;
										_Canon = null;
										if (!flag7)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X24_v4+v138 @ X23_v5*8]");
											bool flag8 = ((Behaviour)0).isActiveAndEnabled;
											bool flag9 = !flag8;
											object obj14 = !flag9;
											_Canon = null;
											if (obj14 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
												object obj15 = 0;
												object obj16 = obj15;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v21+E4]");
												bool flag10 = (nint)0 == 0;
												object obj17 = !flag10;
												if (obj17 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X24_v4+v138 @ X23_v5*8]");
												return On((Dismemberment)0);
											}
										}
									}
									obj7 = copies.Length;
									obj9++;
									bool flag11 = (nint)obj9 < copies.Length;
									obj5 = 0;
									if (flag11)
									{
										continue;
									}
									goto IL_031b;
								}
								IndexOutOfRangeException ex = new IndexOutOfRangeException();
								break;
							}
						}
					}
					goto IL_039c;
				}
			}
		}
		goto IL_031b;
		IL_031b:
		return this;
		IL_039c:
		return (GillaBloodied)(object)new NullReferenceException();
	}

	private List<GillaStains.Piece> Pieces()
	{
		//IL_09b0: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected Obj, but got Unknown
		//IL_0958: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I4
		//IL_09e2: Expected Obj, but got I4
		//IL_0a2d: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I4
		//IL_0a14: Expected Obj, but got I
		//IL_04c4: Expected Obj, but got I8
		//IL_04cd: Expected Obj, but got I4
		//IL_04d6: Expected Obj, but got I4
		//IL_04df: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I4
		//IL_048a: Expected I4, but got Obj
		//IL_0493: Expected Obj, but got I4
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Expected Obj, but got Unknown
		//IL_0afc: Expected Obj, but got I4
		//IL_073e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected Obj, but got Unknown
		//IL_0766: Expected Obj, but got I
		//IL_050e: Expected Obj, but got I4
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected Obj, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected Obj, but got Unknown
		//IL_053d: Expected Obj, but got I
		//IL_0a6f: Expected Obj, but got I
		//IL_0a87: Expected Obj, but got I
		//IL_0a97: Expected Obj, but got I
		//IL_0aa7: Expected Obj, but got I
		//IL_0ab7: Expected Obj, but got I
		//IL_0ac7: Expected Obj, but got I
		//IL_0579: Expected Obj, but got I4
		//IL_0858: Expected Obj, but got I4
		//IL_0605: Expected Obj, but got I4
		//IL_08e2: Expected Obj, but got I
		//IL_08f2: Expected Obj, but got I
		//IL_0902: Expected Obj, but got I
		//IL_091f: Expected I4, but got Obj
		//IL_05c5: Expected Obj, but got I
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08cd: Expected I4, but got Obj
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_066b: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I4
		//IL_06c2: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I4
		SkinnedMeshRenderer[] array = skins;
		bool flag = skins == null;
		List<System.__Canon> list = (List<System.__Canon>)109891584;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8998]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89B8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj3 = obj2;
			List<System.__Canon> list2 = default;
			list2._002Ector(array.Length);
			SkinnedMeshRenderer[] array2 = skins;
			bool flag2 = skins == null;
			list = list2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8988]");
				object obj7 = 0;
				object obj8 = 0;
				object obj9 = 0;
				object obj10 = 0;
				object obj11 = 0;
				object obj12 = 0;
				Transform[] array3 = null;
				object obj13 = 0;
				object obj14 = 0;
				int num = array.Length;
				object obj38 = default;
				object obj42 = default;
				object obj49 = default;
				object obj59;
				do
				{
					bool flag3 = (nint)obj14 >= array2.Length;
					list = list2;
					Transform[] array6;
					object obj46;
					object obj47;
					object obj48;
					if (!flag3)
					{
						bool flag4 = (nint)obj14 < array2.Length;
						object obj15 = !flag4;
						if (obj15 == null)
						{
							object obj16 = obj4;
							object obj17 = (object)array2 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v11+E4]");
							bool flag5 = (nint)0 == 0;
							object obj18 = !flag5;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
							bool flag6 = (UnityEngine.Object)0 == null;
							bool flag7 = !flag6;
							object obj19 = !flag7;
							num = 0;
							obj3 = 0;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
								bool flag8 = (nint)0 == 0;
								list = list2;
								if (flag8)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
								bool flag9 = ((Renderer)0).enabled;
								bool flag10 = !flag9;
								num = 0;
								obj3 = 0;
								if (!flag10)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
									Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
									object obj20 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v12+E4]");
									bool flag11 = (nint)0 == 0;
									object obj21 = !flag11;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag12 = sharedMesh == null;
									bool flag13 = !flag12;
									object obj22 = !flag13;
									num = 0;
									obj3 = 0;
									if (obj22 == null)
									{
										Transform[][] array4 = bonesOf;
										bool flag14 = bonesOf == null;
										list = list2;
										if (flag14)
										{
											break;
										}
										bool flag15 = (nint)obj14 < array4.Length;
										object obj23 = !flag15;
										if (obj23 != null)
										{
											goto IL_097e;
										}
										object obj24 = (object)bonesOf + obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v14+20]");
										Transform[] array5 = (Transform[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v14+20]");
										bool flag16 = (nint)0 == 0;
										num = 0;
										obj3 = 0;
										if (!flag16)
										{
											num = array5.Length;
											bool flag17 = array5.Length == 0;
											obj3 = 0;
											if (!flag17)
											{
												if (obj13 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
													object obj25 = 0;
													object obj26 = obj25;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v60+E4]");
													bool flag18 = (nint)0 == 0;
													object obj27 = !flag18;
													if (obj27 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v14+20]");
													bool flag19 = SameBones((Transform[])0, array3);
													bool flag20 = !flag19;
													object obj28 = !flag20;
													array6 = array3;
													num = (int)array3;
													obj3 = 0;
													if (obj28 != null)
													{
														goto IL_09f0;
													}
													num = array5.Length;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												bool flag21 = array5.Length < 1;
												obj3 = 0;
												if (!flag21)
												{
													object obj29 = array5.Length & 0xFFFFFFFFL;
													object obj30 = 4;
													object obj31 = 32;
													object obj32 = 0;
													while (true)
													{
														object obj33 = obj30 - 4;
														bool flag22 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
														object obj34 = !flag22;
														if (obj34 != null)
														{
															break;
														}
														object obj35 = obj4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v48+E4]");
														bool flag23 = (nint)0 == 0;
														object obj36 = !flag23;
														if (obj36 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X25_v8 (UnityEngine.Transform[])+v212 @ X29_v12*8]");
														if ((UnityEngine.Object)0 != null)
														{
															bool flag24 = (nint)obj33 < array5.Length;
															object obj37 = !flag24;
															if (obj37 != null)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X25_v8 (UnityEngine.Transform[])+v212 @ X29_v12*8]");
															bool flag25 = (nint)0 == 0;
															list = list2;
															if (flag25)
															{
																goto end_IL_0b0a;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X25_v8 (UnityEngine.Transform[])+v212 @ X29_v12*8]");
															Matrix4x4 localToWorldMatrix = ((Transform)0).localToWorldMatrix;
															obj12 = obj38;
															num = 0;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
															object obj39 = 0;
															object obj40 = obj39;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v34+A0]");
															object obj41 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v35+70]");
															obj8 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v35+60]");
															obj9 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v35+50]");
															obj10 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v35+40]");
															obj12 = 0;
															num = 0;
														}
														bool flag26 = obj42 == null;
														list = list2;
														if (flag26)
														{
															goto end_IL_0b0a;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v45+18]");
														bool flag27 = (nint)obj33 < 0;
														object obj43 = !flag27;
														if (obj43 != null)
														{
															break;
														}
														object obj44 = obj42 + obj31;
														object obj45 = obj30 - 3;
														obj30++;
														obj31 += 64;
														obj44 = obj12;
														obj29 = array5.Length;
														bool flag28 = (nint)obj45 < array5.Length;
														obj46 = obj10;
														obj47 = obj12;
														obj11 = obj8;
														obj48 = obj9;
														obj32 = 0;
														if (flag28)
														{
															continue;
														}
														goto IL_06b2;
													}
													goto IL_097e;
												}
												goto IL_0a1d;
											}
										}
									}
								}
							}
							goto IL_0924;
						}
						goto IL_097e;
					}
					return (List<GillaStains.Piece>)(object)list;
					IL_097e:
					return (List<GillaStains.Piece>)(object)new IndexOutOfRangeException();
					IL_06b2:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89A0]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8988]");
					obj7 = 0;
					obj46 = obj10;
					obj47 = obj12;
					obj11 = obj8;
					obj48 = obj9;
					obj3 = 0;
					goto IL_0a1d;
					IL_09f0:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					obj49._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
					Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
					bool flag29 = obj49 == null;
					list = list2;
					if (flag29)
					{
						break;
					}
					object obj50 = obj49 + 16;
					obj50 = sharedMesh2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+20]");
					string text = ((UnityEngine.Object)0).name;
					object obj51 = obj49 + 24;
					obj51 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj52 = obj49 + 40;
					obj52 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag30 = list2 == null;
					list = list2;
					if (flag30)
					{
						break;
					}
					System.__Canon[] items = list2._items;
					object obj53 = obj7;
					int version = list2._version + 1;
					list2._version = version;
					bool flag31 = list2._items == null;
					list = list2;
					if (flag31)
					{
						break;
					}
					bool flag32 = list2._size < items.Length;
					object obj54 = !flag32;
					if (obj54 == null)
					{
						object obj55 = list2._items + list2._size;
						int size = list2._size + 1;
						list2._size = size;
						object obj56 = obj55 + 32;
						obj56 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						array3 = array6;
						num = (int)obj49;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X9_v13+20]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v17+A8]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v18+70]");
						obj3 = 0;
						list2.AddWithResize((System.__Canon)obj49);
						array3 = array6;
						num = (int)obj49;
					}
					goto IL_0924;
					IL_0924:
					array2 = skins;
					obj14++;
					bool flag33 = skins == null;
					obj59 = !flag33;
					list = list2;
					continue;
					IL_0a1d:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v14+20]");
					array6 = (Transform[])0;
					obj13 = obj42;
					goto IL_09f0;
					continue;
					end_IL_0b0a:
					break;
				}
				while (obj59 != null);
			}
		}
		throw new NullReferenceException();
	}

	private static bool SameBones(Transform[] x, Transform[] y)
	{
		//IL_0204: Expected I4, but got Obj
		//IL_01d5: Expected Obj, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected I4, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I8
		//IL_0088: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I
		if (x == null || y == null)
		{
			goto IL_01f6;
		}
		bool flag4;
		object obj11;
		if (x.Length == y.Length)
		{
			if (x.Length >= 1)
			{
				object obj = x.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				object obj3 = x + 32;
				object obj4 = y + 32;
				Transform[] array = y;
				object obj5 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					bool flag2 = (nint)obj5 < y.Length;
					object obj7 = !flag2;
					if (obj7 != null)
					{
						break;
					}
					object obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v8+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X25_v4+v60 @ X23_v5*8]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v4+v60 @ X23_v5*8]");
					flag4 = (UnityEngine.Object)num != (UnityEngine.Object)0;
					bool flag5 = !flag4;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						obj = x.Length;
						obj5++;
						bool flag6 = (nint)obj5 < x.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X26_v4+v60 @ X23_v5*8]");
						array = (Transform[])0;
						if (flag6)
						{
							continue;
						}
					}
					goto IL_01b9;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				goto IL_01f6;
			}
			obj11 = 1;
		}
		else
		{
			obj11 = 0;
		}
		goto IL_0248;
		IL_0248:
		return (byte)(obj11 & 1) != 0;
		IL_01b9:
		obj11 = (flag4 ? 1 : 0) ^ 1;
		goto IL_0248;
		IL_01f6:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public void Splash(Vector3 from, float reach, float strength)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8870]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		Send((GillaStains.Job)obj2);
	}

	public void Hit(Vector3 at, float radius, GillaStains.Stuff stuff)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8870]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Send((GillaStains.Job)obj2);
	}

	private void Send(GillaStains.Job j)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		//IL_00d2: Expected F4, but got I
		//IL_00e2: Invalid comparison between F4 and I
		//IL_0169: Expected I4, but got I8
		//IL_01a4: Expected Obj, but got I4
		Find();
		GillaBloodied gillaBloodied = Painter();
		List<GillaStains.Piece> list = gillaBloodied.Pieces();
		object obj = j + 24;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+18]");
		if ((nint)0 != 0)
		{
			Share();
			object obj3 = j + 16;
			obj3 = sheet;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Transform transform = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B88]");
			object obj4 = 0;
			Vector3 lossyScale = transform.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			float big = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
			float num = default;
			if (!(num < 0f))
			{
				big = num;
			}
			j.big = big;
			int seed = UnityEngine.Random.Range(-2147483648, 2147483647);
			object obj5 = obj4;
			j.seed = seed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaStains.Add(j);
			OnWorn(j);
		}
	}

	public GillaBloodied()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj2 = this + 88;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaBloodied()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5D80]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C89D8]");
		object obj3 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, System.__Canon, System.__Canon)> list = default;
		list._002Ector();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+A0]");
		object obj7 = (nint)0 + (nint)16;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
