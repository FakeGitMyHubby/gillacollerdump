using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Liv.Lck;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GillaLoading : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass239_0
	{
		public GillaLivCamera _003C_003E4__this;

		public LckResult r;

		internal void _003CPhotoSaved_003Eb__0()
		{
			//IL_0078: Expected Obj, but got I
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected Obj, but got Unknown
			//IL_0031: Expected Obj, but got I
			//IL_0055: Expected Obj, but got I4
			//IL_00dc: Expected Obj, but got I
			//IL_019b: Expected Obj, but got I4
			//IL_01d0: Expected Obj, but got I
			//IL_01e6: Expected Obj, but got I
			//IL_014c: Expected Obj, but got I4
			//IL_021e: Expected Obj, but got I
			//IL_0234: Expected Obj, but got I
			LckResult lckResult = r;
			string text;
			if (~(lckResult._success ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2070]");
				object obj = 0;
				text = (string)obj;
				bool flag = (object)_003C_003E4__this == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2068]");
				object obj3 = 0;
				string text2 = (string)obj3 + lckResult._message;
				text = text2;
			}
			object obj4 = _003C_003E4__this + 176;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			LckResult lckResult2 = r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CD698]");
			object obj5 = 0;
			GillaLivCamera gillaLivCamera = _003C_003E4__this;
			object words;
			object colours;
			float seconds;
			if (~(lckResult2._success ? 1u : 0u) == 0)
			{
				object obj6 = obj5;
				int num = gillaLivCamera.PhotosSaved__BackingField + 1;
				gillaLivCamera.PhotosSaved__BackingField = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2080]");
				words = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+A0]");
				colours = (nint)0 + (nint)144;
				seconds = 2f;
			}
			else
			{
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2078]");
				words = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+A0]");
				colours = (nint)0 + (nint)136;
				seconds = 3f;
			}
			gillaLivCamera.Say((string)words, (Color32[])colours, seconds);
		}
	}

	public struct Words
	{
		public GillaIntegrity.Verdict verdict;

		public string status;

		public string latest;

		public string message;

		public string codes;

		public float progress;

		public int build;
	}

	public Transform head;

	public Transform panel;

	public Renderer picture;

	public Renderer words;

	public TextAsset titleFont;

	public TextAsset textFont;

	public string next;

	public AudioSource intro;

	public GillaTerms terms;

	private const float Distance = default(float);

	private const float Settle = default(float);

	private const float PlaceFor = default(float);

	private const int FramesBeforeLoad = default(int);

	private const float ExitTime = default(float);

	private const float MinShown = default(float);

	private static readonly float[] StepAt;

	private const double Lead = default(double);

	private const float TurnAfter = default(float);

	private static readonly int[] Steps;

	private const int SourceSize = default(int);

	private const int W = default(int);

	private const int H = default(int);

	private static readonly Color32[] Blue;

	private static readonly Color32[] Milk;

	private static readonly Color32[] Gold;

	private static readonly Color32[] Red;

	private static readonly Color32[] Grey;

	private static readonly Color32 BarOff;

	private static readonly Color32 Clear;

	private static readonly int CellsId;

	private static readonly int LodId;

	private static readonly int LevelsId;

	private static readonly int GainId;

	private static readonly int RevealId;

	private static readonly int GlitchId;

	private static readonly int BandId;

	private static readonly int TintId;

	private static readonly int MainTexId;

	private AsyncOperation load;

	private float started;

	private float exitAt;

	private float termsAt;

	private float shownProgress;

	private float yaw;

	private float height;

	private bool going;

	private bool placed;

	private bool queued;

	private double introAt;

	private Material pictureMat;

	private Material wordsMat;

	private Texture2D tex;

	private Color32[] px;

	private ScreenFont title;

	private ScreenFont text;

	private string drawn;

	private static int lobbyFrames;

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	private IEnumerator Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private unsafe void Update()
	{
		//IL_1098: Expected Obj, but got I
		//IL_10bb: Expected F8, but got I4
		//IL_112f: Invalid comparison between F8 and I4
		//IL_1142: Expected Obj, but got F8
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected Obj, but got Unknown
		//IL_1177: Expected Obj, but got I4
		//IL_0034: Invalid comparison between F4 and I4
		//IL_003f: Expected I, but got Obj
		//IL_0048: Expected F8, but got I4
		//IL_11ac: Expected Obj, but got I4
		//IL_11c9: Invalid comparison between F8 and I4
		//IL_11eb: Expected Obj, but got I4
		//IL_0071: Expected I, but got Obj
		//IL_123b: Expected Obj, but got I4
		//IL_008c: Expected I, but got Obj
		//IL_1273: Expected Obj, but got I4
		//IL_1698: Expected Obj, but got I
		//IL_16b9: Expected Obj, but got I
		//IL_16c9: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I4
		//IL_12ab: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_12d1: Expected Obj, but got I4
		//IL_12dc: Invalid comparison between F4 and I4
		//IL_030c: Invalid comparison between F4 and I4
		//IL_0324: Expected Obj, but got F8
		//IL_0331: Expected Obj, but got F4
		//IL_0468: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I4
		//IL_12fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1301: Expected Obj, but got Unknown
		//IL_131b: Expected Obj, but got I4
		//IL_0482: Invalid comparison between F4 and I4
		//IL_0493: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I4
		//IL_1380: Invalid comparison between F4 and I4
		//IL_0612: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_1332: Invalid comparison between F4 and I4
		//IL_0aaa: Expected Obj, but got I4
		//IL_0ab5: Expected Obj, but got I4
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Unknown
		//IL_0aea: Expected Obj, but got I4
		//IL_04f1: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I4
		//IL_0688: Invalid comparison between F4 and I4
		//IL_055b: Expected Obj, but got I4
		//IL_0b17: Expected F8, but got I
		//IL_0b27: Invalid comparison between F4 and I
		//IL_172a: Expected Obj, but got I4
		//IL_06b2: Expected Obj, but got I4
		//IL_086d: Expected F8, but got I
		//IL_08c1: Invalid comparison between F8 and I4
		//IL_08d0: Invalid comparison between F8 and I4
		//IL_08e3: Expected Obj, but got F8
		//IL_08f0: Expected Obj, but got F8
		//IL_0925: Expected Obj, but got I4
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_058f: Expected F4, but got I
		//IL_13e2: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_174b: Invalid comparison between F4 and I4
		//IL_1762: Expected Obj, but got F4
		//IL_176c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1771: Expected Obj, but got Unknown
		//IL_1799: Expected Obj, but got I4
		//IL_0b79: Expected Obj, but got I
		//IL_0b93: Expected Obj, but got I
		//IL_09bd: Expected Obj, but got I4
		//IL_0bb9: Expected Obj, but got I
		//IL_0be3: Expected Obj, but got I4
		//IL_1412: Expected Obj, but got I4
		//IL_09af: Expected Obj, but got I4
		//IL_077b: Expected Obj, but got I4
		//IL_0c19: Expected Obj, but got I
		//IL_09f4: Expected Obj, but got I4
		//IL_0c38: Expected Obj, but got I
		//IL_0c46: Expected I, but got Obj
		//IL_0c56: Expected Obj, but got I
		//IL_0c80: Expected Obj, but got I4
		//IL_142e: Expected Obj, but got I
		//IL_1448: Expected Obj, but got I4
		//IL_0a26: Expected Obj, but got I4
		//IL_07f5: Expected F8, but got I
		//IL_0cc3: Expected I, but got Obj
		//IL_0cfb: Expected Obj, but got I4
		//IL_0f77: Expected Obj, but got I
		//IL_0f85: Expected Obj, but got Ref
		//IL_0d40: Expected Obj, but got I4
		//IL_14ec: Expected Obj, but got I4
		//IL_0a55: Expected Obj, but got I4
		//IL_0d83: Expected Obj, but got I4
		//IL_154d: Expected Obj, but got I4
		//IL_14a2: Expected Obj, but got I4
		//IL_17db: Expected Obj, but got I
		//IL_17c6: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I4
		//IL_157d: Expected Obj, but got I4
		//IL_0e1b: Expected Obj, but got I4
		//IL_0fd7: Expected Obj, but got I4
		//IL_15ed: Expected Obj, but got I4
		//IL_1810: Expected Obj, but got I
		//IL_181e: Expected Obj, but got Ref
		//IL_15b5: Expected Obj, but got I4
		//IL_1625: Expected Obj, but got I4
		//IL_0e98: Expected Obj, but got I4
		//IL_183d: Expected Obj, but got I
		//IL_184b: Expected Obj, but got Ref
		//IL_165d: Expected Obj, but got I4
		//IL_1881: Expected Obj, but got I
		//IL_18b5: Expected Obj, but got I
		//IL_18c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ca: Expected Obj, but got Unknown
		//IL_18e7: Expected Obj, but got Ref
		//IL_190f: Expected Obj, but got I4
		//IL_1687: Expected VT, but got Ref
		//IL_0f2b: Expected F8, but got I
		//IL_0f3b: Invalid comparison between F4 and I
		//IL_1510: Expected Obj, but got I4
		//IL_0f62: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj = 0;
		float unscaledTime = Time.unscaledTime;
		bool flag = load == null;
		double num = 0.0;
		if (!flag)
		{
			float progress = load.progress;
			float num2 = progress;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num3 = num2 / 0f;
			bool flag2 = num3 < 0f;
			nint num4 = unchecked((nint)null);
			num = 0.0;
			if (!flag2)
			{
				bool flag3 = !((double)num3 > 1.0);
				num4 = unchecked((nint)null);
				num = num3;
				if (!flag3)
				{
					num4 = unchecked((nint)null);
					num = 1.0;
				}
			}
		}
		float unscaledDeltaTime = Time.unscaledDeltaTime;
		double num5 = num - (double)shownProgress;
		object obj2 = obj;
		float num6 = unscaledDeltaTime * 1.5f;
		float num7 = unscaledDeltaTime * 1.5f;
		float num8 = 0f - num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag4 = num5 < 0.0;
		object obj3 = num5 ^ num5;
		object obj4 = num5 & obj3;
		bool flag5 = (nint)obj4 < 0;
		bool flag6 = flag4 == flag5;
		object obj5 = !flag6;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num8 = num6;
		}
		bool flag7 = 1.5 < (double)num6;
		object obj7 = !flag7;
		double num9 = 1.5 - (double)num6;
		bool flag8 = num9 == 0.0;
		float num10 = shownProgress + num8;
		object obj8 = !flag8;
		object obj9 = obj7 & obj8;
		object obj10 = ~obj9;
		double num11 = ((obj10 != null) ? num : ((double)num10));
		shownProgress = (float)num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj11 = !flag9;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v9+A0]");
		object obj14 = 0;
		float num12 = unscaledTime - started;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v8+18]");
		bool flag14;
		bool flag15;
		if ((nint)0 != 2)
		{
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v195+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Application.isEditor)
			{
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v200+E4]");
				bool flag12 = (nint)0 == 0;
				object obj20 = !flag12;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool cleared = GillaIntegrity.Cleared;
				bool flag13 = !cleared;
				object obj21 = !flag13;
				if (obj21 != null)
				{
					goto IL_00f5;
				}
			}
			flag14 = false;
			flag15 = true;
			double num13 = 1.5;
			goto IL_1281;
		}
		goto IL_00f5;
		IL_00f5:
		if (!(num < 1.0))
		{
			bool flag16 = load == null;
			flag14 = false;
			flag15 = false;
			double num13 = 1.5;
			num11 = 1.0;
			if (!flag16)
			{
				num13 = shownProgress;
				if ((double)shownProgress < 1.0)
				{
					flag14 = false;
					flag15 = false;
					num11 = 1.0;
				}
				else
				{
					float num14 = num12 - 4.5f;
					bool flag17 = num14 < 0f;
					object obj22 = (double)num12 ^ 4.5;
					object obj23 = num12 ^ num14;
					object obj24 = obj22 & obj23;
					bool flag18 = (nint)obj24 < 0;
					bool flag19 = flag17 == flag18;
					flag14 = flag19;
					flag15 = false;
					num11 = 4.5;
				}
			}
		}
		else
		{
			flag14 = false;
			flag15 = false;
			double num13 = 1.5;
			num11 = 1.0;
		}
		goto IL_1281;
		IL_134e:
		bool flag20;
		bool flag22;
		if (flag20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v170+E4]");
			bool flag21 = (nint)0 == 0;
			object obj27 = !flag21;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag22 = GillaTerms.Accepted;
		}
		else
		{
			flag22 = true;
		}
		float num15 = exitAt;
		if (!(exitAt < 0f))
		{
			bool flag23 = !going;
			object obj28 = !flag23;
			object obj29 = !flag22;
			object obj30 = obj28 | obj29;
			object obj31 = obj30 & 1;
			bool flag24 = obj31 == null;
			object obj32 = !flag24;
			if (obj32 == null)
			{
				num15 = num12 - num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				double num13 = 0.0;
				float num16 = num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				if (!(num16 < 0f))
				{
					going = true;
					load.allowSceneActivation = true;
					num15 = Time.realtimeSinceStartup;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2148]");
					object format = 0;
					object arg = default;
					string message = string.Format((string)format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj34 = 0;
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v29+E4]");
					bool flag25 = (nint)0 == 0;
					object obj36 = !flag25;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.Log(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2140]");
					object obj38 = 0;
					UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
					unityAction._002Ector((object)null, (IntPtr)obj38);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
					object obj39 = 0;
					object obj40 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X0_v28+E4]");
					bool flag26 = (nint)0 == 0;
					object obj41 = !flag26;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
					unityAction2._002Ector((object)null, (IntPtr)obj38);
					SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
					object obj42 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X0_v34+E4]");
					bool flag27 = (nint)0 == 0;
					object obj43 = !flag27;
					if (obj43 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag28 = intro != null;
					bool flag29 = !flag28;
					object obj44 = 0;
					bool flag30 = false;
					UnityEngine.Object obj45 = null;
					if (!flag29)
					{
						bool isPlaying = intro.isPlaying;
						bool flag31 = !isPlaying;
						obj44 = 0;
						flag30 = false;
						obj45 = null;
						if (!flag31)
						{
							AudioClip clip = intro.clip;
							object obj46 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v34+E4]");
							bool flag32 = (nint)0 == 0;
							object obj47 = !flag32;
							if (obj47 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag33 = clip != null;
							bool flag34 = !flag33;
							obj44 = 0;
							flag30 = false;
							obj45 = null;
							if (!flag34)
							{
								Transform transform = intro.transform;
								transform.SetParent(null, worldPositionStays: false);
								GameObject target = intro.gameObject;
								object obj48 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v35+E4]");
								bool flag35 = (nint)0 == 0;
								object obj49 = !flag35;
								if (obj49 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object.DontDestroyOnLoad(target);
								GameObject obj50 = intro.gameObject;
								AudioClip clip2 = intro.clip;
								float length = clip2.length;
								float time = intro.time;
								num15 = length - time;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
								num13 = 0.0;
								float num17 = num15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
								if (num17 < 0f)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
									num15 = 0f;
								}
								UnityEngine.Object.Destroy(obj50, num15);
								obj44 = 0;
								flag30 = false;
								obj45 = null;
							}
						}
					}
				}
			}
		}
		bool flag36 = queued;
		if (!(num12 < 0f))
		{
			bool flag37 = (byte)(~(queued ? 1u : 0u)) != 0;
			object obj51 = !flag37;
			if (obj51 == null)
			{
				object obj52 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v154+E4]");
				bool flag38 = (nint)0 == 0;
				object obj53 = !flag38;
				if (obj53 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag39 = intro != null;
				bool flag40 = !flag39;
				bool flag30 = false;
				UnityEngine.Object obj45 = null;
				if (!flag40)
				{
					AudioClip clip3 = intro.clip;
					object obj54 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v104+E4]");
					bool flag41 = (nint)0 == 0;
					object obj55 = !flag41;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag42 = clip3 != null;
					bool flag43 = !flag42;
					flag30 = false;
					obj45 = null;
					if (!flag43)
					{
						queued = true;
						double dspTime = AudioSettings.dspTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAC8]");
						double num13 = 0.0;
						double num18 = dspTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BAC8]");
						double num19 = (introAt = num18 + 0.0);
						intro.PlayScheduled(num19);
						flag30 = false;
						num15 = (float)num19;
						obj45 = null;
					}
				}
				flag36 = queued;
			}
		}
		bool flag44 = !flag36;
		float num20 = num12;
		if (!flag44)
		{
			double dspTime2 = AudioSettings.dspTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			num5 = 0.0;
			double num21 = dspTime2 - introAt;
			float num22 = num12 + -0.25f;
			double num23 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			double num24 = num23 + 0.0;
			double num25 = num24 - (double)num22;
			bool flag45 = num25 < 0.0;
			bool flag46 = num25 == 0.0;
			object obj56 = num24 ^ (double)num22;
			object obj57 = num24 ^ num25;
			object obj58 = obj56 & obj57;
			bool flag47 = (nint)obj58 < 0;
			bool flag48 = flag45 == flag47;
			object obj59 = !flag46;
			object obj60 = flag48 & obj59;
			object obj61 = ~obj60;
			if (obj61 == null)
			{
				double num13 = num22;
				num15 = (float)num24;
				num20 = (float)num24;
			}
			else
			{
				double num13 = num22;
				num15 = (float)num24;
				num20 = num22;
			}
		}
		object obj62 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v68+E4]");
		bool flag49 = (nint)0 == 0;
		object obj63 = !flag49;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj64 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v71+E4]");
		bool flag50 = (nint)0 == 0;
		object obj65 = !flag50;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj66 = obj15;
		bool flag51 = exitAt < 0f;
		object obj67 = exitAt ^ exitAt;
		object obj68 = exitAt & obj67;
		bool flag52 = (nint)obj68 < 0;
		bool flag53 = flag51 == flag52;
		object obj69 = !flag53;
		object obj70 = ~obj69;
		if (obj70 == null)
		{
			object obj71 = 120;
		}
		else
		{
			object obj71 = 116;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X0_v73+E4]");
		bool flag54 = (nint)0 == 0;
		object obj72 = !flag54;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isEditor = Application.isEditor;
		bool flag55 = !isEditor;
		object obj73 = !flag55;
		object obj74 = ~obj73;
		if (obj74 == null)
		{
		}
		object obj76 = default;
		object obj75 = (nint)(&obj76) | (nint)8;
		bool flag56 = !flag15;
		object obj77 = !flag56;
		object obj78 = ~obj77;
		object obj79;
		if (obj78 == null)
		{
			obj79 = obj75;
		}
		else
		{
			obj79 = 8;
		}
		object obj84;
		if (flag15)
		{
			object obj80 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v135+E4]");
			bool flag57 = (nint)0 == 0;
			object obj81 = !flag57;
			if (obj81 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj82 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v139+E4]");
			bool flag58 = (nint)0 == 0;
			object obj83 = !flag58;
			if (obj83 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj82 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v139+A0]");
			obj84 = (nint)0 + (nint)32;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1500]");
			obj84 = 0;
			obj79 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj76, 8));
		}
		obj79 = obj84;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj85 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X0_v80+E4]");
		bool flag59 = (nint)0 == 0;
		object obj86 = !flag59;
		if (obj86 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj87 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X0_v85+E4]");
		bool flag60 = (nint)0 == 0;
		object obj88 = !flag60;
		if (obj88 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj87 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X0_v85+A0]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v56+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X0_v85+E4]");
			bool flag61 = (nint)0 == 0;
			object obj90 = !flag61;
			if (obj90 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj87 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X0_v85+E4]");
			bool flag62 = (nint)0 == 0;
			object obj91 = !flag62;
			if (obj91 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj87 = obj;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X0_v85+E4]");
		bool flag63 = (nint)0 == 0;
		object obj92 = !flag63;
		if (obj92 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj93 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v89+E4]");
		bool flag64 = (nint)0 == 0;
		object obj94 = !flag64;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj93 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v89+A0]");
		object obj95 = 0;
		object obj96 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj76, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj97 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X0_v94+E4]");
		bool flag65 = (nint)0 == 0;
		object obj98 = !flag65;
		if (obj98 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj97 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X0_v94+A0]");
		object obj99 = 0;
		object obj100 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj76, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj101 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X0_v99+E4]");
		bool flag66 = (nint)0 == 0;
		object obj102 = !flag66;
		if (obj102 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj101 = obj;
		}
		float num26 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLoading)+v927 @ X8_v48]");
		float num27 = num26 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X0_v99+A0]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLoading)+v927 @ X8_v48]");
		bool flag67 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLoading)+v927 @ X8_v48]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLoading)+v927 @ X8_v48]");
		object obj104 = num28 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaLoading)+v927 @ X8_v48]");
		object obj105 = 0 & obj104;
		bool flag68 = (nint)obj105 < 0;
		object obj106 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj76, 32));
		float num29 = num20 - num27;
		bool flag69 = flag67 == flag68;
		object obj107 = !flag69;
		object obj108 = ~obj107;
		float num30 = ((obj108 != null) ? num29 : (-1f));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj109 = default;
		Show(num20, num30, (Words)(&obj109));
		return;
		IL_1281:
		object obj110 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v11+E4]");
		bool flag70 = (nint)0 == 0;
		object obj111 = !flag70;
		if (obj111 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (terms != null)
		{
			GillaTerms gillaTerms = terms;
			object obj112 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v188+E4]");
			bool flag71 = (nint)0 == 0;
			object obj113 = !flag71;
			if (obj113 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag72 = gillaTerms.board != null;
			bool flag30 = false;
			UnityEngine.Object obj45 = null;
			flag20 = flag72;
		}
		else
		{
			bool flag30 = false;
			UnityEngine.Object obj45 = null;
			flag20 = false;
		}
		float num31 = exitAt;
		object obj114 = (flag14 ? 1 : 0) ^ 1;
		if (!(exitAt < 0f))
		{
			obj114 = 1;
		}
		object obj115 = obj114 & 1;
		bool flag73 = obj115 == null;
		object obj116 = !flag73;
		if (obj116 == null)
		{
			float num32 = termsAt;
			bool flag74 = termsAt < 0f;
			object obj117 = !flag74;
			object obj118 = !flag20;
			object obj119 = obj117 | obj118;
			object obj120 = obj119 & 1;
			bool flag75 = obj120 == null;
			object obj121 = !flag75;
			if (obj121 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C91B0]");
				object obj122 = 0;
				object obj123 = obj122;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v179+E4]");
				bool flag76 = (nint)0 == 0;
				object obj124 = !flag76;
				if (obj124 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool accepted = GillaTerms.Accepted;
				bool flag77 = !accepted;
				object obj125 = !flag77;
				if (obj125 == null)
				{
					termsAt = num12;
					GillaTerms gillaTerms2 = terms;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
					gillaTerms2.Show(0f);
					UnityEngine.Object obj45 = null;
				}
				num32 = termsAt;
			}
			bool flag78 = num32 < 0f;
			num31 = num12;
			if (!flag78)
			{
				bool done = terms.Done;
				bool flag79 = !done;
				num31 = num12;
				UnityEngine.Object obj45 = null;
				if (flag79)
				{
					goto IL_134e;
				}
				float num33 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
				num31 = num33 + 0f;
				obj45 = null;
			}
			exitAt = num31;
		}
		goto IL_134e;
	}

	private static void LobbyIn(Scene scene, LoadSceneMode mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		//IL_0221: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I4
		//IL_01b0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2140]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2160]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2150]");
		object obj7 = 0;
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Scene scene2 = default;
		string arg = scene2.name;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg2 = default;
		string message = string.Format((string)format, arg, arg2);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2158]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj13 = 0;
		Debug.Log(message);
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v17+A0]");
		object obj16 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction2 = default;
		unityAction2._002Ector(null, (IntPtr)obj12);
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction3 = default;
		unityAction3._002Ector(null, (IntPtr)obj12);
		Application.onBeforeRender += unityAction3;
	}

	private static void LobbyFrame()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		//IL_020f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v1+64]");
		object obj5 = (nint)0 + (nint)1;
		object obj8;
		if ((nint)obj5 != 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+A0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v25+64]");
				obj5 = 0;
			}
			bool flag3 = (nint)obj5 != 8;
			obj8 = obj2;
			if (flag3)
			{
				goto IL_038d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2168]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v16+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v16+64]");
		object arg;
		if ((nint)0 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC9C8]");
			arg = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2170]");
			arg = 0;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg2 = default;
		string message = string.Format((string)format, arg, arg2);
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		obj8 = obj;
		goto IL_038d;
		IL_038d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v5+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+64]");
		if ((nint)0 >= (nint)8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2158]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			UnityAction unityAction = default;
			unityAction._002Ector(null, (IntPtr)obj18);
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v9+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Application.onBeforeRender -= unityAction;
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I4
		//IL_01ab: Invalid comparison between F4 and I
		//IL_0476: Expected VT, but got I4
		//IL_0476: Expected VT, but got I4
		//IL_0239: Invalid comparison between F4 and I4
		//IL_0248: Expected F4, but got I4
		//IL_0394: Expected VT, but got I4
		//IL_0394: Expected VT, but got I4
		//IL_0410: Invalid comparison between F4 and I4
		//IL_04c3: Invalid comparison between F8 and I4
		//IL_04d2: Expected F8, but got I4
		//IL_025f: Invalid comparison between F4 and I4
		//IL_026e: Expected F4, but got I4
		//IL_02cd: Expected F4, but got I8
		//IL_0285: Invalid comparison between F4 and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
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
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = panel == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		Vector3 position = head.position;
		Vector3 forward = head.forward;
		object obj9 = default;
		object obj8 = obj9 * obj9;
		object obj11 = default;
		object obj10 = obj11 * obj11;
		object obj12 = obj8 + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num2;
		if ((nint)obj12 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFF0");
			float num = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			num2 = num * 0f;
		}
		else
		{
			num2 = yaw;
		}
		float num7;
		float num8;
		if (~(placed ? 1u : 0u) == 0)
		{
			float unscaledTime = Time.unscaledTime;
			float num3 = unscaledTime - started;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			if (!(num3 < 0f))
			{
				float num4 = num2 - yaw;
				float num5 = num4 / 1.13587E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				float num6 = num5 * 1.13587E+09f;
				num7 = num4 - num6;
				bool flag7 = num7 < 0f;
				num8 = 0f;
				if (!flag7)
				{
					bool flag8 = num7 > 1.13587E+09f;
					float num9 = 1.13587E+09f;
					if (!flag8)
					{
						bool flag9 = !(num7 > 1.1274813E+09f);
						num9 = num7;
						num8 = num7;
						if (flag9)
						{
							goto IL_03fd;
						}
					}
					num8 = num9 + 3.2833536E+09f;
					num7 = 3.2833536E+09f;
				}
				goto IL_03fd;
			}
		}
		yaw = num2;
		float num10 = default;
		height = num10;
		placed = true;
		goto IL_03eb;
		IL_03eb:
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		panel.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		return;
		IL_03fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		if (num7 > 1.1080827E+09f)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float num11 = unscaledDeltaTime * -3f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num12 = 1.0 - (double)num11;
			double num13 = (double)num8 * num12;
			double num14 = (double)yaw + num13;
			yaw = (float)num14;
		}
		float unscaledDeltaTime2 = Time.unscaledDeltaTime;
		float num15 = unscaledDeltaTime2 * -2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num16 = 1.0 - (double)num15;
		bool flag10 = num16 < 0.0;
		double num17 = 0.0;
		if (!flag10)
		{
			bool flag11 = !(num16 > 1.0);
			num17 = num16;
			if (!flag11)
			{
				num17 = 1.0;
			}
		}
		float num18 = num10 - height;
		double num19 = (double)num18 * num17;
		double num20 = (double)height + num19;
		height = (float)num20;
		goto IL_03eb;
	}

	public unsafe void Preview(float t, float exitAt, Words w)
	{
		//IL_0012: Expected VT, but got Ref
		object obj = default;
		Show(t, exitAt, (Words)(&obj));
	}

	private unsafe void Show(float t, float exitAt, Words w)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1261: Expected F8, but got Obj
		//IL_126b: Expected VT, but got Ref
		//IL_1295: Expected Obj, but got I4
		//IL_12b3: Expected Obj, but got I
		//IL_0053: Invalid comparison between F4 and I
		//IL_00a7: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0080: Expected F4, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_12f8: Invalid comparison between F4 and I4
		//IL_1307: Expected F8, but got I4
		//IL_0177: Invalid comparison between F4 and I
		//IL_131e: Invalid comparison between F4 and I4
		//IL_1330: Expected F8, but got I4
		//IL_1339: Expected F4, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_1904: Invalid comparison between F4 and I
		//IL_0230: Invalid comparison between F4 and I
		//IL_01a4: Expected F4, but got I4
		//IL_1a5c: Invalid comparison between F4 and I4
		//IL_1a6b: Expected F8, but got I4
		//IL_02fb: Invalid comparison between F8 and I4
		//IL_030a: Expected F8, but got I4
		//IL_0278: Expected F4, but got I4
		//IL_01fb: Expected Obj, but got I
		//IL_149b: Invalid comparison between F4 and I4
		//IL_035f: Invalid comparison between F4 and I4
		//IL_1399: Expected F8, but got I
		//IL_025d: Expected F4, but got I4
		//IL_1970: Invalid comparison between F4 and I4
		//IL_1985: Expected Obj, but got I4
		//IL_1995: Expected F8, but got I
		//IL_19a0: Expected Obj, but got I4
		//IL_06ad: Expected F8, but got I
		//IL_04e0: Expected F8, but got I
		//IL_0500: Invalid comparison between F4 and I4
		//IL_050f: Expected F8, but got I4
		//IL_13ee: Expected Obj, but got I4
		//IL_037f: Expected F4, but got I4
		//IL_1537: Invalid comparison between F4 and I4
		//IL_192b: Expected Obj, but got I
		//IL_0a6d: Expected F8, but got I4
		//IL_19b5: Expected Obj, but got I
		//IL_19df: Expected Obj, but got I4
		//IL_1a17: Expected Obj, but got I4
		//IL_06d0: Invalid comparison between F4 and I4
		//IL_05cd: Invalid comparison between F4 and I4
		//IL_05e0: Expected Obj, but got F4
		//IL_05ed: Expected Obj, but got F4
		//IL_0636: Expected Obj, but got I4
		//IL_0428: Invalid comparison between F4 and I4
		//IL_0437: Expected F8, but got I4
		//IL_1739: Expected Obj, but got I
		//IL_1749: Expected Obj, but got I
		//IL_1423: Expected F8, but got I
		//IL_0732: Expected Obj, but got I4
		//IL_14c5: Invalid comparison between F8 and I4
		//IL_14d4: Expected F8, but got I4
		//IL_0a99: Invalid comparison between F4 and I
		//IL_0aaa: Expected Obj, but got I4
		//IL_07d9: Invalid comparison between F8 and I4
		//IL_08ff: Expected Obj, but got I4
		//IL_0ac8: Expected F8, but got I
		//IL_0ad8: Expected F8, but got I
		//IL_097b: Invalid comparison between F4 and I4
		//IL_098a: Expected F8, but got I4
		//IL_0817: Invalid comparison between F8 and I4
		//IL_0826: Invalid comparison between F8 and I4
		//IL_083e: Expected Obj, but got F8
		//IL_084b: Expected Obj, but got F8
		//IL_0880: Expected Obj, but got I4
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected Obj, but got Unknown
		//IL_1607: Invalid comparison between F4 and I4
		//IL_16a5: Invalid comparison between F4 and I4
		//IL_16b4: Expected F8, but got I4
		//IL_1559: Expected Obj, but got I4
		//IL_157c: Expected F8, but got I4
		//IL_08bc: Invalid comparison between F8 and I4
		//IL_1700: Expected F8, but got I
		//IL_1783: Expected Obj, but got I
		//IL_17a5: Expected Obj, but got I4
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected Ref, but got Unknown
		//IL_0b91: Expected Obj, but got I4
		//IL_0bd4: Expected VT, but got I4
		//IL_0ea9: Expected Obj, but got I4
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Expected Ref, but got Unknown
		//IL_0f0e: Expected Obj, but got I4
		//IL_0c22: Expected Obj, but got I4
		//IL_0f80: Expected Obj, but got I4
		//IL_0c74: Expected Obj, but got I
		//IL_0c8e: Expected VT, but got I4
		//IL_0ca6: Expected Obj, but got I
		//IL_17db: Expected Obj, but got I
		//IL_1805: Expected Obj, but got I4
		//IL_0fd2: Expected Obj, but got I
		//IL_1015: Expected Obj, but got I4
		//IL_0d06: Expected Obj, but got I
		//IL_0d37: Expected Obj, but got I
		//IL_1063: Expected I4, but got Obj
		//IL_0d6d: Expected Obj, but got I
		//IL_0db5: Expected Obj, but got I
		//IL_10ea: Expected Obj, but got I4
		//IL_0deb: Expected Obj, but got I
		//IL_0e05: Expected VT, but got I4
		//IL_0e1d: Expected Obj, but got I
		//IL_0e47: Expected VT, but got I4
		//IL_0e50: Expected VT, but got I4
		//IL_186d: Expected Obj, but got I
		//IL_1887: Expected VT, but got I4
		//IL_189f: Expected Obj, but got I
		//IL_18d1: Expected Obj, but got I
		//IL_109b: Expected Obj, but got I4
		//IL_1127: Expected Obj, but got I
		//IL_1158: Expected Obj, but got I
		//IL_1823: Expected Obj, but got I
		//IL_11a3: Expected Obj, but got I
		//IL_11e8: Expected Obj, but got I
		//IL_1202: Expected VT, but got I4
		//IL_121f: Expected Obj, but got I
		//IL_1239: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2150]");
		object obj = 0;
		double num = (double)w.codes;
		object obj2 = default;
		Draw((Words)(&obj2));
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+A0]");
		object obj5 = 0;
		object obj6 = obj5;
		if (obj5 == null)
		{
			goto IL_123f;
		}
		float num2 = t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE28]");
		float num3 = num2 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+24]");
		double num4;
		float num5;
		if (num3 < 0f)
		{
			num4 = 3.0;
			num5 = 0f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+A0]");
				object obj8 = 0;
				obj6 = obj8;
				if (obj8 == null)
				{
					goto IL_123f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+18]");
			bool flag3 = (nint)0 < (nint)2;
			object obj9 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+18]");
			object obj10 = -2;
			bool flag4 = obj10 == null;
			object obj11 = ~obj9;
			object obj12 = obj11 | flag4;
			if (obj12 != null)
			{
				goto IL_124d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+28]");
			if (num3 < 0f)
			{
				num4 = 3.0;
				num5 = 1f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+A0]");
					object obj14 = 0;
					obj6 = obj14;
					if (obj14 == null)
					{
						goto IL_123f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+2C]");
				if (num3 < 0f)
				{
					num4 = 3.0;
					num5 = 2f;
				}
				else
				{
					num4 = 6.0;
					num5 = 3f;
				}
			}
		}
		float num6 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num7 = num6 / 0f;
		bool flag6 = num7 < 0f;
		double num8 = 0.0;
		if (!flag6)
		{
			bool flag7 = !((double)num7 > 1.0);
			num8 = num7;
			if (!flag7)
			{
				num8 = 1.0;
			}
		}
		bool flag8 = !(num3 > 0f);
		double num9 = 0.0;
		float value = 0f;
		if (!flag8)
		{
			double num10 = 1.0 - num8;
			double num11 = num10 * num10;
			double num12 = 1.0 - num11;
			bool flag9 = num12 < 0.0;
			double num13 = 0.0;
			if (!flag9)
			{
				bool flag10 = !(num12 > 1.0);
				num13 = num12;
				if (!flag10)
				{
					num13 = 1.0;
				}
			}
			float num14 = num3 * 3f;
			double num15 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			double num16 = num15 * 0.0;
			float num17 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			value = num17 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			double num18 = 0.0;
			double num19 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			num9 = num19 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			num = 1.5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+2C]");
		if (num3 < 0f)
		{
			float num20 = ((!(num3 < 0f)) ? num3 : 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+E4]");
			bool flag11 = (nint)0 == 0;
			object obj15 = !flag11;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v102+A0]");
			object obj16 = 0;
			object obj17 = obj16;
			if (obj16 == null)
			{
				goto IL_123f;
			}
			float num21 = t * 14f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num22 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
			float num23 = num22 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num24 = num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
			float num25 = num24 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num26 = num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
			float num27 = num26 - 0f;
			bool flag12 = num27 < 0f;
			double num28 = 0.0;
			if (!flag12)
			{
				bool flag13 = !((double)num27 > 1.0);
				num28 = num27;
				if (!flag13)
				{
					num28 = 1.0;
				}
			}
			float num29 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v93+2C]");
			float num30 = num29 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			double num18 = 0.0;
			double num31 = 1.0 - (double)num30;
			double num32 = num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			double num33 = num32 * 0.0;
			double num34 = num33 * num28;
			double num35 = num34 + 1.0;
			num9 *= num35;
			num = 1.0;
		}
		float num36 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE78]");
		float num37 = num36 + 0f;
		float num38 = num37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num39 = num38 / 0f;
		bool flag14 = num39 < 0f;
		double num40 = 0.0;
		if (!flag14)
		{
			bool flag15 = !((double)num39 > 1.0);
			num40 = num39;
			if (!flag15)
			{
				num40 = 1.0;
			}
		}
		bool flag16 = exitAt < 0f;
		float value2 = (float)num9;
		if (!flag16)
		{
			float num41 = t - exitAt;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			double num42 = 0.0;
			float num43 = num41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			float num44 = num43 / 0f;
			bool flag17 = num44 < 0f;
			double num45 = 0.0;
			if (!flag17)
			{
				bool flag18 = !((double)num44 > 1.0);
				num42 = 1.0;
				num45 = num44;
				if (!flag18)
				{
					num42 = 1.0;
					num45 = 1.0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v96+E4]");
			bool flag19 = (nint)0 == 0;
			object obj20 = !flag19;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num46 = num45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
			double num18 = num46 * 0.0;
			float num47 = 3f - num44;
			float num48 = num5 - num47;
			bool flag20 = num48 < 0f;
			object obj21 = num5 ^ num47;
			object obj22 = num5 ^ num48;
			object obj23 = obj21 & obj22;
			bool flag21 = (nint)obj23 < 0;
			double num49 = 1.0 - num45;
			bool flag22 = flag20 == flag21;
			object obj24 = !flag22;
			object obj25 = ~obj24;
			if (obj25 != null)
			{
				num5 = num47;
			}
			bool flag23 = num18 < 0.0;
			num = 0.0;
			if (!flag23)
			{
				bool flag24 = !(num18 > 1.0);
				num = num18;
				if (!flag24)
				{
					num = 1.0;
				}
			}
			double num50 = 1.0 - num;
			double num51 = num9 * num49;
			num40 *= num50;
			value2 = (float)num51;
			num4 = 3.0;
		}
		float num52 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v99+2C]");
		float num53 = num52 - 0f;
		bool flag25 = num53 < 0f;
		object obj26 = 17281024 + 2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA90]");
		double num54 = 0.0;
		object obj27 = !flag25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X9_v10+v738 @ TEMPCOND_v16*4]");
		double num55 = 0.0;
		double num69;
		if (exitAt < 0f && num3 > 0f)
		{
			object obj28 = obj;
			float num56 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF84]");
			float num57 = num56 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X0_v86+E4]");
			bool flag26 = (nint)0 == 0;
			object obj29 = !flag26;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num58 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
			float num59 = num58 * 0f;
			float num60 = num59 + 3f;
			float num61 = num60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
			float num62 = num61 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num63 = num62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
			float num64 = num63 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num65 = (double)num64 - 3.0;
			bool flag27 = num65 < 0.0;
			double num66 = 3.0;
			if (!flag27)
			{
				double num67 = num65 - 1.0;
				bool flag28 = num67 < 0.0;
				bool flag29 = num67 == 0.0;
				object obj30 = num65 ^ 1.0;
				object obj31 = num65 ^ num67;
				object obj32 = obj30 & obj31;
				bool flag30 = (nint)obj32 < 0;
				bool flag31 = flag28 == flag30;
				object obj33 = !flag31;
				object obj34 = obj33 | flag29;
				object obj35 = ~obj34;
				bool flag32;
				if (obj35 == null)
				{
					double num68 = num65 - num55;
					flag32 = num68 < 0.0;
				}
				else
				{
					flag32 = false;
				}
				object obj36 = !flag32;
				num66 = 1.0;
				num54 = 1.0;
				num69 = 0.0;
				if (obj36 != null)
				{
					goto IL_19ed;
				}
			}
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X0_v89+E4]");
			bool flag33 = (nint)0 == 0;
			object obj38 = !flag33;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num70 = num3 + 11f;
			float num71 = num70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
			float num72 = num71 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num73 = num72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
			float num74 = num73 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			bool flag34 = num74 < 0f;
			double num75 = 0.0;
			if (!flag34)
			{
				bool flag35 = !((double)num74 > 1.0);
				num75 = num74;
				if (!flag35)
				{
					num75 = 1.0;
				}
			}
			double num76 = num75 + num75;
			float num77 = num3 + 23f;
			float num78 = num77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
			float num79 = num78 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num80 = num79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
			float num81 = num80 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num82 = num81 - num77;
			bool flag36 = num82 < 0f;
			double num83 = num77;
			if (!flag36)
			{
				bool flag37 = !((double)num82 > 1.0);
				num83 = 1.0;
				if (!flag37)
				{
					num83 = 1.0;
				}
			}
			double num84 = num76 + -1.0;
			float num85 = num3 + 31f;
			float num86 = num85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
			float num87 = num86 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
			float num88 = num87;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
			float num89 = num88 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			float num90 = num89 - (float)num;
			bool flag38 = num90 < 0f;
			double num91 = 0.0;
			if (!flag38)
			{
				bool flag39 = !((double)num90 > 1.0);
				num91 = num90;
				if (!flag39)
				{
					num91 = 1.0;
				}
			}
			double num92 = num84;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
			num69 = num92 * 0.0;
			double num93 = num91;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
			double num94 = num93 * 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			num54 = 0.0;
			double num95 = num94;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
			num65 = num95 + 0.0;
			num4 = 3.0;
		}
		else
		{
			double num65 = 0.5;
			num69 = 0.0;
		}
		goto IL_19ed;
		IL_123f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_124d;
		IL_19ed:
		object obj39 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+E4]");
		bool flag40 = (nint)0 == 0;
		object obj40 = !flag40;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj39 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+A0]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X8_v18+8]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X8_v18+8]");
		if ((nint)0 != 0)
		{
			float num96 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v19+18]");
			bool flag41 = num96 < 0f;
			object obj43 = !flag41;
			if (obj43 != null)
			{
				goto IL_124d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
			double num97 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
			double num98 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X8_v18+8]");
			float num99 = 0f + num5;
			double num100 = 1.0;
			double num101 = 1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+E4]");
			bool flag42 = (nint)0 == 0;
			object obj45 = !flag42;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Material material = Mat(picture, ref *(Material*)(this + 152));
			object obj46 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v21+E4]");
			bool flag43 = (nint)0 == 0;
			object obj47 = !flag43;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag44 = material != null;
			bool flag45 = !flag44;
			Color color = (Color)0;
			int num102 = 0;
			double num103 = 1.0;
			if (!flag45)
			{
				object obj48 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1179 @ X0_v61+E4]");
				bool flag46 = (nint)0 == 0;
				object obj49 = !flag46;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((object)material == null)
				{
					goto IL_123f;
				}
				object obj50 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v52+A0]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ X8_v53+40]");
				material.SetVector(0, (Vector4)0);
				object obj52 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v54+A0]");
				object obj53 = 0;
				double num104 = 68.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v20 (System.Single)+20]");
				double a = num104 / 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj54 = 0;
				object obj55 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ X0_v65+E4]");
				bool flag47 = (nint)0 == 0;
				object obj56 = !flag47;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num105 = Math.Log(a, 2.0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v55+44]");
				material.SetFloat(0, (float)num105);
				object obj57 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1279 @ X8_v60+A0]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1283 @ X8_v61+48]");
				material.SetFloat(0, (float)num4);
				object obj59 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v62+A0]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v63+4C]");
				material.SetFloat(0, value2);
				object obj61 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ X8_v64+A0]");
				object obj62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ X8_v65+50]");
				material.SetFloat(0, value);
				object obj63 = obj;
				float num106 = (float)num69;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v20 (System.Single)+20]");
				float value3 = num106 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X8_v66+A0]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1317 @ X8_v67+54]");
				material.SetFloat(0, value3);
				object obj65 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X8_v68+A0]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ X8_v69+58]");
				material.SetVector(0, (Vector4)0);
				object obj67 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1347 @ X8_v70+A0]");
				object obj68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v71+5C]");
				num102 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v71+5C]");
				material.SetColor(0, (Color)0);
				color = (Color)0;
				double num18 = 1.0;
				num98 = num100;
				num97 = num101;
				num103 = 1.0;
			}
			object obj69 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X0_v22+E4]");
			bool flag48 = (nint)0 == 0;
			object obj70 = !flag48;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Material material2 = Mat(words, ref *(Material*)(this + 160));
			object obj71 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v24+E4]");
			bool flag49 = (nint)0 == 0;
			object obj72 = !flag49;
			if (obj72 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(material2 != null))
			{
				return;
			}
			object obj73 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ X0_v30+E4]");
			bool flag50 = (nint)0 == 0;
			object obj74 = !flag50;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)material2 != null)
			{
				object obj75 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ X8_v27+A0]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ X8_v28+60]");
				Texture texture = material2.GetTexture(0);
				object obj77 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X8_v29+E4]");
				bool flag51 = (nint)0 == 0;
				object obj78 = !flag51;
				if (obj78 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag52 = texture != tex;
				bool flag53 = !flag52;
				Texture texture2 = null;
				int num107 = (int)tex;
				if (!flag53)
				{
					object obj79 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X0_v51+E4]");
					bool flag54 = (nint)0 == 0;
					object obj80 = !flag54;
					if (obj80 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj79 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X0_v51+A0]");
					object obj81 = 0;
					texture2 = tex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v50+60]");
					num107 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ X8_v50+60]");
					material2.SetTexture(0, tex);
				}
				object obj82 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X0_v39+E4]");
				bool flag55 = (nint)0 == 0;
				object obj83 = !flag55;
				if (obj83 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj82 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X0_v39+A0]");
				object obj84 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X8_v32+40]");
				material2.SetVector(0, (Vector4)0);
				object obj85 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1364 @ X8_v35+A0]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X8_v36+44]");
				material2.SetFloat(0, 0f);
				object obj87 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1370 @ X8_v37+A0]");
				object obj88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1374 @ X8_v38+48]");
				material2.SetFloat(0, 6f);
				object obj89 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X8_v39+A0]");
				object obj90 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1380 @ X8_v40+4C]");
				material2.SetFloat(0, (float)num40);
				object obj91 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1382 @ X8_v41+A0]");
				object obj92 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X8_v42+50]");
				material2.SetFloat(0, 1.5f);
				double num108 = num69 * 1132462080.0;
				object obj93 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1390 @ X8_v43+A0]");
				object obj94 = 0;
				float value4 = (float)num108 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ X8_v44+54]");
				material2.SetFloat(0, value4);
				object obj95 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X8_v45+A0]");
				object obj96 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v46+58]");
				material2.SetVector(0, (Vector4)0);
				object obj97 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ X8_v47+A0]");
				object obj98 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1271 @ X8_v48+5C]");
				material2.SetColor(0, (Color)0);
				return;
			}
		}
		goto IL_123f;
		IL_124d:
		throw new IndexOutOfRangeException();
	}

	private unsafe static Material Mat(Renderer r, ref Material own)
	{
		//IL_0010: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
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
		bool flag2 = r == null;
		bool flag3 = !flag2;
		Material result = null;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Application.isPlaying)
			{
				if ((object)r != null)
				{
					return r.sharedMaterial;
				}
				goto IL_01d4;
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (own != null)
			{
				result = own;
			}
			else
			{
				if ((object)r == null)
				{
					goto IL_01d4;
				}
				Material material = r.material;
				ref Material reference = ref *(Material*)material;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				result = material;
			}
		}
		return result;
		IL_01d4:
		return (Material)(object)new NullReferenceException();
	}

	private static float Hash(float n)
	{
		//IL_0062: Invalid comparison between F4 and I4
		//IL_0071: Expected F4, but got I4
		float num = n;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE04]");
		float num2 = num * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num4 = num3 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		float num5 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A924]");
		float num6 = num5 - 0f;
		bool flag = num6 < 0f;
		float result = 0f;
		if (!flag)
		{
			bool flag2 = !((double)num6 > 1.0);
			result = num6;
			if (!flag2)
			{
				result = 1f;
			}
		}
		return result;
	}

	private unsafe void Draw(Words w)
	{
		//IL_240f: Expected Obj, but got I
		//IL_2439: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0047: Invalid comparison between F8 and I4
		//IL_0100: Expected Obj, but got I4
		//IL_011e: Invalid comparison between F8 and I4
		//IL_007c: Expected Obj, but got I4
		//IL_009a: Invalid comparison between F8 and I4
		//IL_1c62: Expected F8, but got I4
		//IL_1bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf3: Expected Obj, but got Unknown
		//IL_1c26: Expected Obj, but got I4
		//IL_021d: Expected I, but got Obj
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I8
		//IL_02d5: Expected I, but got Obj
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_03be: Expected I, but got Obj
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_051c: Expected Obj, but got I8
		//IL_04c1: Expected I, but got Obj
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_054f: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I4
		//IL_05fe: Expected Obj, but got I4
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected Obj, but got Unknown
		//IL_058b: Expected I, but got Obj
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0677: Expected I4, but got Obj
		//IL_06f0: Expected Obj, but got I4
		//IL_0700: Expected Obj, but got I4
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_068d: Expected I, but got Obj
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0779: Expected I4, but got Obj
		//IL_07f2: Expected Obj, but got I4
		//IL_080e: Invalid comparison between F8 and I4
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected I4, but got Unknown
		//IL_078f: Expected I, but got Obj
		//IL_084c: Expected Obj, but got I
		//IL_085c: Expected Obj, but got I
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_08cb: Expected Obj, but got I4
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected Obj, but got Unknown
		//IL_09b4: Expected Obj, but got I4
		//IL_09f3: Expected I, but got Obj
		//IL_0903: Expected Obj, but got I4
		//IL_0baf: Expected F8, but got I4
		//IL_094a: Expected Obj, but got I4
		//IL_0953: Expected Obj, but got I4
		//IL_0a1a: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I
		//IL_0bed: Expected F8, but got I
		//IL_0a68: Expected F8, but got I4
		//IL_0a71: Expected VT, but got I4
		//IL_1cdc: Expected Obj, but got I4
		//IL_1cf7: Expected Obj, but got I4
		//IL_1d12: Invalid comparison between F8 and I4
		//IL_1d42: Expected F8, but got I4
		//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected Obj, but got Unknown
		//IL_0d3e: Expected Obj, but got I4
		//IL_0e85: Expected native int or pointer, but got F8
		//IL_0e8f: Invalid comparison between F8 and I4
		//IL_0ea0: Expected Obj, but got I4
		//IL_0c3e: Expected Obj, but got I4
		//IL_0af2: Expected Obj, but got I
		//IL_0d76: Expected Obj, but got I4
		//IL_1ca1: Expected Obj, but got I4
		//IL_1cba: Invalid comparison between F8 and I4
		//IL_0b28: Expected Obj, but got I
		//IL_100d: Expected Obj, but got I4
		//IL_0ed8: Expected Obj, but got I4
		//IL_0db7: Expected I, but got Obj
		//IL_0c60: Expected Obj, but got I4
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected Obj, but got Unknown
		//IL_0b4a: Expected Obj, but got I4
		//IL_0b5d: Expected VT, but got I4
		//IL_0b74: Expected I, but got Obj
		//IL_1d80: Expected Obj, but got I
		//IL_1d90: Expected F8, but got I
		//IL_1dc2: Expected F8, but got I
		//IL_0f19: Expected I, but got Obj
		//IL_0e55: Expected Obj, but got I4
		//IL_0e6f: Expected Obj, but got I4
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got Unknown
		//IL_0c9a: Expected Obj, but got I
		//IL_0ccd: Expected Obj, but got I4
		//IL_0ce0: Expected F8, but got I4
		//IL_1dea: Expected Obj, but got I4
		//IL_0fc4: Expected F8, but got I4
		//IL_0fbf: Expected native int or pointer, but got F8
		//IL_0de4: Expected I, but got Obj
		//IL_109b: Expected native int or pointer, but got F8
		//IL_10a9: Expected VT, but got Ref
		//IL_10a9: Expected Obj, but got F8
		//IL_0f4e: Expected I, but got Obj
		//IL_113d: Expected Obj, but got I
		//IL_0e1f: Expected Obj, but got I
		//IL_1e6f: Expected Obj, but got I4
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected I4, but got Unknown
		//IL_10f9: Expected Obj, but got I
		//IL_0f89: Expected Obj, but got I
		//IL_0e40: Expected I, but got Obj
		//IL_0e48: Expected I4, but got Obj
		//IL_12e9: Expected Obj, but got I4
		//IL_0faa: Expected I, but got Obj
		//IL_0fb2: Expected I4, but got Obj
		//IL_1f78: Expected Obj, but got I
		//IL_1f92: Expected Obj, but got I
		//IL_1f97: Expected native int or pointer, but got F8
		//IL_1fb3: Expected VT, but got Ref
		//IL_1fb3: Expected Obj, but got F8
		//IL_1fcb: Expected Obj, but got I
		//IL_117a: Expected Obj, but got I4
		//IL_1199: Invalid comparison between F8 and I4
		//IL_131e: Expected Obj, but got I
		//IL_133c: Expected VT, but got Ref
		//IL_134c: Expected Obj, but got I
		//IL_1409: Expected Obj, but got I
		//IL_1389: Expected Obj, but got I
		//IL_139c: Expected Obj, but got I4
		//IL_13a5: Expected Obj, but got I4
		//IL_13ae: Expected Obj, but got I4
		//IL_13b7: Expected VT, but got Ref
		//IL_13d2: Expected Obj, but got I4
		//IL_13ec: Expected F8, but got I
		//IL_16bf: Expected Obj, but got I
		//IL_11f2: Expected Obj, but got I4
		//IL_200c: Expected F8, but got Obj
		//IL_1ebb: Expected Obj, but got I
		//IL_1ed5: Expected Obj, but got I
		//IL_1eda: Expected native int or pointer, but got F8
		//IL_1ef6: Expected VT, but got Ref
		//IL_1ef6: Expected Obj, but got F8
		//IL_1f06: Expected Obj, but got I
		//IL_1f16: Expected Obj, but got I
		//IL_1a2f: Expected native int or pointer, but got F8
		//IL_1a38: Expected VT, but got F8
		//IL_1a55: Expected Obj, but got I
		//IL_1a65: Expected Obj, but got I
		//IL_2021: Expected Obj, but got I
		//IL_204b: Expected Obj, but got I4
		//IL_122f: Expected Obj, but got I
		//IL_1257: Expected VT, but got Ref
		//IL_1aad: Expected Obj, but got I4
		//IL_24c3: Expected Obj, but got I4
		//IL_1480: Invalid comparison between F8 and I4
		//IL_2344: Expected Obj, but got I
		//IL_236a: Expected VT, but got Ref
		//IL_236a: Expected Obj, but got VT
		//IL_2384: Expected F8, but got I4
		//IL_2395: Expected Obj, but got F8
		//IL_239e: Expected F8, but got I4
		//IL_23ae: Expected VT, but got Ref
		//IL_23b6: Expected I4, but got Obj
		//IL_23d0: Expected I4, but got VT
		//IL_23e0: Expected F8, but got I
		//IL_23e9: Expected F8, but got I4
		//IL_213e: Expected Obj, but got I
		//IL_214d: Expected native int or pointer, but got F8
		//IL_2169: Expected VT, but got Ref
		//IL_2169: Expected Obj, but got F8
		//IL_2172: Expected F8, but got I4
		//IL_217b: Expected F8, but got I4
		//IL_2184: Expected Obj, but got I4
		//IL_2188: Expected native int or pointer, but got F8
		//IL_2191: Expected Obj, but got F8
		//IL_219a: Expected F8, but got I4
		//IL_21a3: Expected VT, but got I4
		//IL_14e5: Expected Obj, but got I
		//IL_14f5: Expected Obj, but got I
		//IL_1516: Expected Obj, but got I
		//IL_232f: Expected Obj, but got I4
		//IL_1f5a: Expected Obj, but got I4
		//IL_129b: Expected Obj, but got I
		//IL_12b5: Expected Obj, but got I4
		//IL_1afd: Expected F8, but got I4
		//IL_1b0e: Expected Obj, but got F8
		//IL_1b17: Expected F8, but got I4
		//IL_1b27: Expected VT, but got Ref
		//IL_1b2f: Expected I4, but got Obj
		//IL_1b3d: Expected I, but got Obj
		//IL_1b47: Expected I4, but got Obj
		//IL_1b57: Expected F8, but got I
		//IL_1b60: Expected F8, but got I4
		//IL_20db: Expected Obj, but got I
		//IL_20eb: Expected Obj, but got I
		//IL_2110: Expected I4, but got F8
		//IL_2457: Expected Obj, but got I
		//IL_247f: Expected VT, but got Ref
		//IL_2490: Expected Obj, but got I
		//IL_22a9: Invalid comparison between VT and F8
		//IL_22ba: Expected Obj, but got I4
		//IL_22d3: Invalid comparison between F8 and I4
		//IL_22e5: Invalid comparison between VT and F8
		//IL_2076: Expected Obj, but got I4
		//IL_1561: Expected Obj, but got I4
		//IL_156a: Expected Obj, but got I4
		//IL_1573: Expected Obj, but got I4
		//IL_157c: Expected Obj, but got I4
		//IL_158d: Expected VT, but got Ref
		//IL_159d: Expected F8, but got Obj
		//IL_15ad: Expected F8, but got I
		//IL_183b: Expected Obj, but got I4
		//IL_2272: Expected Obj, but got I
		//IL_2282: Expected VT, but got I
		//IL_228a: Expected I4, but got Obj
		//IL_17f4: Expected Obj, but got I4
		//IL_1749: Expected F8, but got I4
		//IL_15c7: Expected native int or pointer, but got F8
		//IL_15d0: Expected Obj, but got F8
		//IL_15f2: Expected Obj, but got I4
		//IL_2201: Expected F8, but got I4
		//IL_2209: Expected Obj, but got F8
		//IL_2212: Expected F8, but got I4
		//IL_2222: Expected VT, but got Ref
		//IL_222a: Expected I4, but got Obj
		//IL_2254: Expected F8, but got I
		//IL_21b8: Expected Obj, but got I
		//IL_21cd: Expected Obj, but got I
		//IL_1620: Expected Obj, but got I
		//IL_163c: Expected Obj, but got I
		//IL_1654: Expected Obj, but got I4
		//IL_165d: Expected Obj, but got I4
		//IL_1666: Expected Obj, but got I4
		//IL_166f: Expected Obj, but got I4
		//IL_1678: Expected VT, but got Ref
		//IL_16a2: Expected F8, but got I
		//IL_1879: Invalid comparison between F8 and I4
		//IL_188a: Expected Obj, but got I4
		//IL_1892: Expected VT, but got Ref
		//IL_189a: Expected I4, but got Obj
		//IL_18bc: Expected F8, but got I
		//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ec: Expected Obj, but got Unknown
		//IL_1906: Expected Obj, but got I4
		//IL_191d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1922: Expected Obj, but got Unknown
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1930: Expected Obj, but got Unknown
		//IL_195a: Expected Obj, but got I4
		//IL_1971: Unknown result type (might be due to invalid IL or missing references)
		//IL_1976: Expected VT, but got Unknown
		//IL_197f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1984: Expected Obj, but got Unknown
		//IL_199d: Invalid comparison between VT and I4
		//IL_19ae: Expected Obj, but got I4
		//IL_19c8: Invalid comparison between F8 and I4
		//IL_19db: Invalid comparison between VT and I4
		//IL_19ed: Expected F8, but got I4
		//IL_19f5: Expected VT, but got Ref
		//IL_1a05: Expected F8, but got I
		//IL_1a1d: Expected Obj, but got I4
		double num = (double)w.progress * 30.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE468]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num3;
		double num5 = default;
		double num6;
		object obj6;
		double num7;
		double num4;
		if (num < 0.0)
		{
			bool flag2 = num < -0.5;
			obj6 = !flag2;
			double num2 = num - -0.5;
			bool flag3 = num2 == 0.0;
			if (num == -0.5)
			{
				num3 = -1.0;
				num4 = num5;
				goto IL_1bd6;
			}
			num4 = num + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num6 = num;
			num7 = -0.5;
		}
		else
		{
			bool flag4 = num < 0.5;
			obj6 = !flag4;
			double num2 = num - 0.5;
			bool flag3 = num2 == 0.0;
			if (num == 0.5)
			{
				num3 = 1.0;
				num4 = num5;
				goto IL_1bd6;
			}
			num4 = num + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num6 = num;
			num7 = 0.5;
		}
		goto IL_1c2b;
		IL_0d0e:
		throw new NullReferenceException();
		IL_1ba2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_1bd6:
		num7 = num4 + num3;
		object obj7 = num4 & 1;
		num6 = ((obj7 != null) ? num7 : num4);
		obj6 = 0;
		goto IL_1c2b;
		IL_1c2b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object[] array = default;
		bool flag5 = array == null;
		int num8 = 0;
		double num9 = 0.0;
		int num10 = (int)(&num5);
		Words words = w;
		object[] array2 = array;
		if (flag5)
		{
			goto IL_0d0e;
		}
		int num11 = default;
		bool flag6 = num11 == 0;
		num10 = (int)(&num5);
		IndexOutOfRangeException ex = default;
		int num13;
		if (!flag6)
		{
			nint num12 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v152 (Il2CppClass<System.Object[]>)+40]");
			num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag7 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v152 (Il2CppClass<System.Object[]>)+40]");
			num13 = 0;
			if (flag7)
			{
				goto IL_1ba2;
			}
		}
		if (array.Length != 0)
		{
			object obj8 = array + 32;
			obj8 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag8 = w.status == null;
			num10 = num11;
			if (!flag8)
			{
				nint num14 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v151 (Il2CppClass<System.Object[]>)+40]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag9 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v151 (Il2CppClass<System.Object[]>)+40]");
				num13 = 0;
				if (flag9)
				{
					goto IL_1ba2;
				}
			}
			object obj9 = array.Length & 0xFFFFFFFEL;
			if (obj9 != null)
			{
				object obj10 = array + 40;
				obj10 = w.status;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj12 = default;
				bool flag10 = obj12 == null;
				double num15 = default;
				num10 = (int)(&num15);
				if (!flag10)
				{
					nint num16 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v150 (Il2CppClass<System.Object[]>)+40]");
					num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag11 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v150 (Il2CppClass<System.Object[]>)+40]");
					num13 = 0;
					if (flag11)
					{
						goto IL_1ba2;
					}
				}
				bool flag12 = array.Length < 2;
				object obj13 = !flag12;
				object obj14 = array.Length - 2;
				bool flag13 = obj14 == null;
				object obj15 = ~obj13;
				object obj16 = obj15 | flag13;
				if (obj16 == null)
				{
					object obj17 = array + 48;
					obj17 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					int num17 = default;
					bool flag14 = num17 == 0;
					int num18 = default;
					num10 = (int)(&num18);
					if (!flag14)
					{
						nint num19 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v149 (Il2CppClass<System.Object[]>)+40]");
						num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag15 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v149 (Il2CppClass<System.Object[]>)+40]");
						num13 = 0;
						if (flag15)
						{
							goto IL_1ba2;
						}
					}
					object obj18 = array.Length & 0xFFFFFFFCL;
					if (obj18 != null)
					{
						object obj19 = array + 56;
						obj19 = num17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag16 = w.latest == null;
						num10 = num17;
						if (!flag16)
						{
							nint num20 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v148 (Il2CppClass<System.Object[]>)+40]");
							num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag17 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v148 (Il2CppClass<System.Object[]>)+40]");
							num13 = 0;
							if (flag17)
							{
								goto IL_1ba2;
							}
						}
						bool flag18 = array.Length < 4;
						object obj20 = !flag18;
						object obj21 = array.Length - 4;
						bool flag19 = obj21 == null;
						object obj22 = ~obj20;
						object obj23 = obj22 | flag19;
						if (obj23 == null)
						{
							object obj24 = array + 64;
							obj24 = w.latest;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag20 = w.message == null;
							num10 = (int)w.latest;
							if (!flag20)
							{
								nint num21 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v147 (Il2CppClass<System.Object[]>)+40]");
								num10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag21 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X8_v147 (Il2CppClass<System.Object[]>)+40]");
								num13 = 0;
								if (flag21)
								{
									goto IL_1ba2;
								}
							}
							bool flag22 = array.Length < 5;
							object obj25 = !flag22;
							object obj26 = array.Length - 5;
							bool flag23 = obj26 == null;
							object obj27 = ~obj25;
							object obj28 = obj27 | flag23;
							if (obj28 == null)
							{
								object obj29 = array + 72;
								obj29 = w.message;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag24 = w.codes == null;
								num10 = (int)w.message;
								if (!flag24)
								{
									nint num22 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v146 (Il2CppClass<System.Object[]>)+40]");
									num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag25 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v146 (Il2CppClass<System.Object[]>)+40]");
									num13 = 0;
									if (flag25)
									{
										goto IL_1ba2;
									}
								}
								bool flag26 = array.Length < 6;
								obj6 = !flag26;
								double num2 = (double)array.Length - 6.0;
								bool flag3 = num2 == 0.0;
								object obj30 = ~obj6;
								if (((obj30 | flag3) ? 1 : 0) == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21D0]");
									string format = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									object obj31 = 0;
									object obj32 = array + 80;
									obj32 = w.codes;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text = string.Format(format, array);
									object obj33 = this + 200;
									bool flag27 = text == (string)obj33;
									bool flag28 = !flag27;
									object obj34 = 0;
									if (!flag28)
									{
										object obj35 = obj31;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X0_v230+E4]");
										bool flag29 = (nint)0 == 0;
										object obj36 = !flag29;
										if (obj36 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag30 = tex != null;
										bool flag31 = !flag30;
										object obj37 = !flag31;
										obj34 = 0;
										format = (string)(object)tex;
										if (obj37 != null)
										{
											return;
										}
									}
									drawn = text;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj38 = obj31;
									array2 = (object[])(this + 168);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X0_v207+E4]");
									bool flag32 = (nint)0 == 0;
									object obj39 = !flag32;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag33 = (UnityEngine.Object)(object)array2 == null;
									bool flag34 = !flag33;
									nint num23 = unchecked((nint)null);
									num10 = 0;
									double num24;
									if (!flag34)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
										object obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Texture2D texture2D = default;
										texture2D._002Ector(256, 88, (TextureFormat)4, mipChain: false);
										bool flag35 = (object)texture2D == null;
										num8 = 0;
										num9 = 0.0;
										ShiftAuth.Style style = (ShiftAuth.Style)0;
										bool flag36 = false;
										TextureFormat textureFormat = (TextureFormat)4;
										num23 = 88;
										num24 = num6;
										num10 = 256;
										words = w;
										if (flag35)
										{
											goto IL_0d0e;
										}
										texture2D.filterMode = (FilterMode)0;
										texture2D.wrapMode = (TextureWrapMode)1;
										texture2D.hideFlags = (HideFlags)52;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2180]");
										object obj41 = 0;
										texture2D.name = (string)obj41;
										tex = texture2D;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
										object obj42 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										object obj43 = this + 176;
										int num25 = default;
										obj43 = num25;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										style = (ShiftAuth.Style)0;
										flag36 = false;
										textureFormat = (TextureFormat)4;
										num23 = unchecked((nint)null);
										num10 = num25;
									}
									Color32[] array3 = px;
									bool flag37 = px == null;
									num8 = 0;
									num9 = 0.0;
									num24 = num6;
									words = w;
									if (flag37)
									{
										goto IL_0d0e;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2150]");
									object obj44 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F98]");
									double num26 = 0.0;
									double num27 = (double)w.verdict - 5.0;
									double num29 = default;
									double num28 = num29;
									object[] array4 = null;
									ScreenFont screenFont = default;
									ScreenFont screenFont2 = default;
									object obj65 = default;
									GillaIntegrity.Verdict verdict2 = default;
									string text8 = default;
									string text9 = default;
									object obj85 = default;
									string text15 = default;
									string text16 = default;
									double num44 = default;
									double num47 = default;
									while (true)
									{
										object obj45 = array3.Length;
										bool flag38 = (nint)array4 < array3.Length;
										obj6 = !flag38;
										num2 = (double)array4 - (double)array3.Length;
										flag3 = num2 == 0.0;
										bool flag39 = (nint)array4 >= array3.Length;
										num8 = 0;
										num9 = 0.0;
										num29 = num28;
										num24 = num6;
										words = w;
										array2 = array4;
										if (!flag39)
										{
											object obj46 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1958 @ X0_v213+E4]");
											bool flag40 = (nint)0 == 0;
											object obj47 = !flag40;
											if (obj47 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj45 = array3.Length;
											}
											bool flag41 = System.Runtime.CompilerServices.Unsafe.As<object[], UIntPtr>(ref array4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45);
											obj6 = !flag41;
											num2 = (double)array4 - (double)obj45;
											flag3 = num2 == 0.0;
											if (obj6 != null)
											{
												break;
											}
											object obj48 = obj44;
											num29 = (double)array3 + (double)array4;
											array2 = (object[])(array4 + 1);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1969 @ X8_v135+A0]");
											object obj49 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X8_v136+3C]");
											_ = 0;
											array3 = px;
											bool flag42 = px == null;
											object obj50 = !flag42;
											num8 = 0;
											num9 = 0.0;
											num24 = num6;
											words = w;
											num28 = num29;
											array4 = array2;
											if (obj50 != null)
											{
												continue;
											}
											goto IL_0d0e;
										}
										object obj51 = this + 184;
										bool flag43 = obj51 == null;
										object obj52 = !flag43;
										if (obj52 == null)
										{
											object obj53 = obj31;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X0_v155+E4]");
											bool flag44 = (nint)0 == 0;
											object obj54 = !flag44;
											if (obj54 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag45 = titleFont != null;
											bool flag46 = !flag45;
											num23 = unchecked((nint)null);
											int num30 = 0;
											if (!flag46)
											{
												bool flag47 = (object)titleFont == null;
												num23 = unchecked((nint)null);
												num10 = 0;
												array2 = null;
												if (flag47)
												{
													goto IL_0d0e;
												}
												string baked = titleFont.text;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
												object obj55 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												screenFont._002Ector(baked);
												num23 = unchecked((nint)null);
												num30 = (int)screenFont;
											}
											obj51 = num30;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											num10 = num30;
											array2 = (object[])num30;
										}
										double num31 = (double)this + 192.0;
										bool flag48 = ((double*)(nint)num31)->m_value == 0.0;
										object obj56 = !flag48;
										if (obj56 == null)
										{
											object obj57 = obj31;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X0_v143+E4]");
											bool flag49 = (nint)0 == 0;
											object obj58 = !flag49;
											if (obj58 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag50 = textFont != null;
											bool flag51 = !flag50;
											num23 = unchecked((nint)null);
											int num32 = 0;
											if (!flag51)
											{
												bool flag52 = (object)textFont == null;
												num29 = num31;
												num23 = unchecked((nint)null);
												format = null;
												num10 = 0;
												if (flag52)
												{
													goto IL_0d0e;
												}
												string baked2 = textFont.text;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
												object obj59 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
												screenFont2._002Ector(baked2);
												num23 = unchecked((nint)null);
												num32 = (int)screenFont2;
											}
											((double*)(nint)num31)->m_value = num32;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											num10 = num32;
										}
										object obj60 = obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v131+E4]");
										bool flag53 = (nint)0 == 0;
										object obj61 = !flag53;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj60 = obj44;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v131+A0]");
										object obj62 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v101+10]");
										double num33 = 0.0;
										double num34 = (double)(ref num9) + 16.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										object obj63 = obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X8_v101+10]");
										double num35 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v21+E4]");
										bool flag54 = (nint)0 == 0;
										object obj64 = !flag54;
										if (obj64 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Line((ScreenFont)obj51, 128, 2, (string)((double*)(nint)num26)->m_value, (ShiftAuth.Style)(&obj65));
										string text4;
										if (words.build > 0)
										{
											int num36 = words + 44;
											string text2 = ((int*)num36)->ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21A0]");
											object obj66 = 0;
											string text3 = (string)obj66 + text2;
											int num37 = 0;
											text4 = text3;
											ScreenFont screenFont3 = (ScreenFont)(object)text2;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEED8]");
											object obj67 = 0;
											text4 = (string)obj67;
											int num37 = 128;
											ScreenFont screenFont3 = (ScreenFont)obj51;
										}
										bool flag55 = words.verdict < (GillaIntegrity.Verdict)4;
										obj6 = !flag55;
										num2 = (double)words.verdict - 4.0;
										double num38;
										GillaIntegrity.Verdict verdict;
										double num39;
										string text6;
										string text10;
										int y;
										int x;
										ScreenFont font;
										string line3;
										ShiftAuth.Style style2;
										string text7;
										int num41;
										string text5;
										double num40;
										if (words.verdict != (GillaIntegrity.Verdict)4)
										{
											bool flag56 = words.verdict < (GillaIntegrity.Verdict)3;
											obj6 = !flag56;
											num2 = (double)words.verdict - 3.0;
											flag3 = num2 == 0.0;
											if (words.verdict != (GillaIntegrity.Verdict)3)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1500]");
												object obj68 = 0;
												text5 = (string)obj68;
												if (words.status == (string)obj68)
												{
													num = (double)words.progress * 1120403456.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
													object obj69 = 0;
													object obj70 = obj69;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1347 @ X0_v80+E4]");
													bool flag57 = (nint)0 == 0;
													object obj71 = !flag57;
													if (obj71 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
													if (num < 0.0)
													{
														if (num == -0.5)
														{
															num38 = -1.0;
															verdict = verdict2;
															goto IL_2059;
														}
														num39 = num + -0.5;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
														num40 = -0.5;
													}
													else
													{
														if (num == 0.5)
														{
															num38 = 1.0;
															verdict = verdict2;
															goto IL_2059;
														}
														num39 = num + 0.5;
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
														num40 = 0.5;
													}
													goto IL_20be;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
												object obj72 = 0;
												text6 = (string)((words.status != null) ? words.status : obj72);
												num41 = 2;
												text7 = null;
												num40 = num35;
												goto IL_2499;
											}
											object obj73 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X0_v93+E4]");
											bool flag58 = (nint)0 == 0;
											object obj74 = !flag58;
											if (obj74 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj73 = obj44;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X0_v93+A0]");
											object obj75 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2178]");
											object line = 0;
											Line((ScreenFont)((double*)(nint)num31)->m_value, 128, 32, (string)line, (ShiftAuth.Style)(&text8));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21B8]");
											object obj76 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21C0]");
											object obj77 = 0;
											string line2 = (string)obj76 + text4 + (string)obj77;
											object obj78 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ X8_v82+A0]");
											object obj79 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Line(this.text, 128, 44, line2, (ShiftAuth.Style)(&text9));
											if (string.IsNullOrEmpty(words.latest))
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21B0]");
												object obj80 = 0;
												text10 = (string)obj80;
												int num42 = 44;
												string text11 = (string)128;
												string text12 = null;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2190]");
												object obj81 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD010]");
												string text12 = (string)0;
												string text11 = (string)obj77;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD010]");
												string text13 = (string)obj81 + (string)0 + (string)obj77;
												int num42 = 0;
												text10 = text13;
											}
											object obj82 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1745 @ X0_v106+E4]");
											bool flag59 = (nint)0 == 0;
											object obj83 = !flag59;
											if (obj83 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj82 = obj44;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1745 @ X0_v106+A0]");
											object obj84 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Line(this.text, 128, 54, text10, (ShiftAuth.Style)(&obj85));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD018]");
											bool flag60 = string.IsNullOrEmpty((string)0);
											bool flag61 = !flag60;
											object obj86 = !flag61;
											obj85 = 1;
											text9 = (string)1;
											text8 = (string)1;
											num27 = num34;
											style2 = (ShiftAuth.Style)(&obj85);
											format = text4;
											num24 = (double)text10;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1732 @ X8_v86+18]");
											double num43 = 0.0;
											if (obj86 != null)
											{
												goto IL_1a2b;
											}
											object obj87 = obj44;
											ScreenFont screenFont4 = (ScreenFont)((double*)(nint)num31)->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1888 @ X0_v112+E4]");
											bool flag62 = (nint)0 == 0;
											object obj88 = !flag62;
											if (obj88 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD018]");
											string text14 = Fit((string)0);
											object obj89 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ X8_v88+A0]");
											object obj90 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj91 = 1;
											obj85 = 1;
											text9 = (string)1;
											text8 = (string)1;
											style2 = (ShiftAuth.Style)(&obj91);
											y = 64;
											x = 128;
											font = screenFont4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1593 @ X8_v89+20]");
											num43 = 0.0;
											line3 = text14;
										}
										else
										{
											object obj92 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v41+E4]");
											bool flag63 = (nint)0 == 0;
											object obj93 = !flag63;
											if (obj93 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj92 = obj44;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X0_v41+A0]");
											object obj94 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2198]");
											object line4 = 0;
											Line((ScreenFont)((double*)(nint)num31)->m_value, 128, 32, (string)line4, (ShiftAuth.Style)(&text15));
											object obj95 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ X8_v37+A0]");
											object obj96 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21C8]");
											object line5 = 0;
											Line(this.text, 128, 44, (string)line5, (ShiftAuth.Style)(&text16));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2188]");
											object obj97 = 0;
											ScreenFont screenFont4 = this.text;
											string text17 = (string)obj97 + words.codes;
											object obj98 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v43+A0]");
											object obj99 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											string text18 = (string)1;
											text16 = (string)1;
											text15 = (string)1;
											style2 = (ShiftAuth.Style)(&text18);
											y = 54;
											x = 128;
											text10 = (string)1;
											font = this.text;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X8_v44+30]");
											double num43 = 0.0;
											line3 = text17;
										}
										Line(font, x, y, line3, style2);
										num27 = num34;
										format = text4;
										num24 = (double)text10;
										goto IL_1a2b;
										IL_2499:
										object obj100 = obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1508 @ X0_v59+E4]");
										bool flag64 = (nint)0 == 0;
										object obj101 = !flag64;
										if (obj101 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj100 = obj44;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1508 @ X0_v59+A0]");
										object obj102 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Line((ScreenFont)((double*)(nint)num31)->m_value, 128, 34, text6, (ShiftAuth.Style)(&num44));
										num29 = 1.0;
										double num45 = 10263.0;
										string text19 = (string)41084;
										ScreenFont screenFont5 = (ScreenFont)((double*)(nint)num31)->m_value;
										num4 = 1.0;
										words = (Words)0;
										ShiftAuth.Style style;
										bool flag36;
										TextureFormat textureFormat;
										while (true)
										{
											string text20 = text19;
											num26 = num45;
											obj31 = 47;
											while (true)
											{
												double num46 = (double)obj31 - 47.0;
												array2 = null;
												while (true)
												{
													object obj103 = obj44;
													Color32[] array5 = px;
													bool flag65 = words < (object)num24;
													obj6 = !flag65;
													num2 = (double)words - num24;
													flag3 = num2 == 0.0;
													if (words < (object)num24)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ X0_v68+E4]");
														bool flag66 = (nint)0 == 0;
														object obj104 = !flag66;
														if (obj104 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															obj103 = obj44;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ X0_v68+A0]");
														object obj105 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1868 @ X8_v59+10]");
														Color32 color = ScreenFont.Gradient((Color32[])0, (float)num46);
														num10 = 0;
														num4 = num46;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ X0_v68+E4]");
														bool flag67 = (nint)0 == 0;
														object obj106 = !flag67;
														if (obj106 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															obj103 = obj44;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1874 @ X0_v68+A0]");
														object obj107 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ X8_v58+38]");
														Color32 color = (Color32)0;
														num10 = (int)screenFont5;
													}
													bool flag68 = px == null;
													num44 = 1.0;
													obj65 = num9;
													num9 = 1.0;
													num27 = num45;
													style = (ShiftAuth.Style)(&num44);
													flag36 = (byte)(int)text6 != 0;
													textureFormat = (TextureFormat)34;
													num23 = 128;
													format = text19;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1510 @ X8_v49+18]");
													num7 = 0.0;
													if (flag68)
													{
														break;
													}
													num29 = num26 + (double)array2;
													bool flag69 = num29 < (double)array5.Length;
													object obj108 = !flag69;
													style = (ShiftAuth.Style)(&num44);
													flag36 = (byte)(int)text6 != 0;
													textureFormat = (TextureFormat)34;
													num23 = 128;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1510 @ X8_v49+18]");
													num7 = 0.0;
													if (obj108 != null)
													{
														goto end_IL_1cd2;
													}
													object obj109 = px + text20;
													array2 = (object[])(array2 + 1);
													bool flag70 = (nint)array2 != 6;
													screenFont5 = (ScreenFont)num10;
													if (flag70)
													{
														continue;
													}
													goto IL_1914;
												}
												break;
												IL_1914:
												obj31++;
												text20 = (string)(text20 - 1024);
												num26 -= 256.0;
												bool flag71 = (nint)obj31 != 52;
												screenFont5 = (ScreenFont)num10;
												if (flag71)
												{
													continue;
												}
												goto IL_1968;
											}
											break;
											IL_1968:
											words = (Words)(words + 1);
											format = text19 + 28;
											num27 = num45 + 7.0;
											bool flag72 = words < (object)30;
											obj6 = !flag72;
											num2 = (double)words - 30.0;
											flag3 = num2 == 0.0;
											flag39 = words != (Words)(object)30;
											num44 = 1.0;
											style2 = (ShiftAuth.Style)(&num44);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1510 @ X8_v49+18]");
											double num43 = 0.0;
											num45 = num27;
											text19 = format;
											screenFont5 = (ScreenFont)num10;
											if (flag39)
											{
												continue;
											}
											goto IL_1a2b;
										}
										goto IL_0d0e;
										IL_1a2b:
										words = (Words)((double*)(nint)num31)->m_value;
										string text21 = num8.ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF7E0]");
										object obj110 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA210]");
										object obj111 = 0;
										string text22 = (string)obj110 + text21 + (string)obj111 + text4;
										object obj112 = obj44;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X0_v32+E4]");
										bool flag73 = (nint)0 == 0;
										object obj113 = !flag73;
										if (obj113 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj112 = obj44;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ X0_v32+A0]");
										object obj114 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Line((ScreenFont)words, 128, 78, text22, (ShiftAuth.Style)(&num47));
										bool flag74 = (object)tex == null;
										num47 = 1.0;
										num8 = 54;
										obj65 = num9;
										num9 = 1.0;
										num29 = num34;
										style = (ShiftAuth.Style)(&num47);
										flag36 = (byte)(int)text22 != 0;
										textureFormat = (TextureFormat)78;
										num23 = 128;
										num10 = (int)words;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v32+30]");
										num7 = 0.0;
										num4 = 1.0;
										array2 = (object[])(object)text22;
										if (!flag74)
										{
											tex.SetPixels32(px);
											bool flag75 = (object)tex == null;
											num47 = 1.0;
											num8 = 54;
											obj65 = num9;
											num9 = 1.0;
											num29 = num34;
											style = (ShiftAuth.Style)(&num47);
											flag36 = (byte)(int)text22 != 0;
											textureFormat = (TextureFormat)78;
											num23 = unchecked((nint)null);
											num10 = (int)px;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v32+30]");
											num7 = 0.0;
											num4 = 1.0;
											array2 = (object[])(object)text22;
											if (!flag75)
											{
												tex.Apply(updateMipmaps: false);
												return;
											}
										}
										goto IL_0d0e;
										IL_20be:
										string text23 = num8.ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21A8]");
										object obj115 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C92E8]");
										object obj116 = 0;
										text7 = (string)obj116;
										string text24 = (string)obj115 + text23 + (string)obj116;
										num8 = (int)num39;
										num41 = 0;
										text5 = text23;
										text6 = text24;
										goto IL_2499;
										IL_2059:
										num40 = (double)verdict + num38;
										object obj117 = verdict & (GillaIntegrity.Verdict)1;
										num39 = ((obj117 != null) ? num40 : ((double)verdict));
										goto IL_20be;
										continue;
										end_IL_1cd2:
										break;
									}
								}
							}
						}
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		num13 = num10;
		goto IL_1ba2;
	}

	private static string Fit(string line)
	{
		//IL_0056: Expected Obj, but got I
		if (line != null)
		{
			if (line._stringLength < 43)
			{
				return line;
			}
			string text = line.Substring(0, 39);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF630]");
			object obj = 0;
			return text + (string)obj;
		}
		return (string)(object)new NullReferenceException();
	}

	private unsafe void Line(ScreenFont font, int x, int y, string line, ShiftAuth.Style style)
	{
		//IL_0047: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected I4, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_002e: Expected Ref, but got VT
		//IL_024a: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I4
		//IL_0298: Expected VT, but got Ref
		if (font != null)
		{
			int num = font.DrawCentred(px, 256, 88, x, y, line, ref *(ShiftAuth.Style*)style);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6180]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = style.scale - 1;
		bool flag = (nint)obj3 < 0;
		bool flag2 = obj3 == null;
		int num2 = style.scale ^ 1;
		int num3 = style.scale ^ obj3;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		int scale = ((obj6 != null) ? 1 : style.scale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num5 = PixelFont.Measure(line, scale);
		Color32[] colours = style.colours;
		if (style.colours != null)
		{
			bool flag6 = num5 < 0;
			int num6 = num5 ^ num5;
			int num7 = num5 & num6;
			bool flag7 = num7 < 0;
			bool flag8 = flag6 == flag7;
			object obj8 = !flag8;
			object obj9 = ~obj8;
			int num8 = ((obj9 != null) ? num5 : (num5 + 1));
			int x2 = x - num8;
			PixelFont.Draw(px, 256, 88, x2, y, line, (Color32)System.Runtime.CompilerServices.Unsafe.AsPointer(ref colours[0]), scale);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
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
		bool flag2 = tex != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			object obj8 = obj;
			if (isPlaying)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v31+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(tex);
				obj4 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v31+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.DestroyImmediate(tex);
				obj4 = null;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = pictureMat != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj13 = null;
		if (!flag9)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v22+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(pictureMat);
			obj13 = null;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v12+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (wordsMat != null)
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v16+E4]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(wordsMat);
		}
	}

	public GillaLoading()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7230]");
		object obj = 0;
		object obj2 = this + 80;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		exitAt = 0f;
		base._002Ector();
	}

	static GillaLoading()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		//IL_03c9: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_04fe: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I
		//IL_0581: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2150]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21E0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = obj2;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj9 = 0;
		object obj10 = default;
		obj9 = obj10;
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = obj5;
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8+A0]");
		object obj14 = (nint)0 + (nint)8;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v12+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v12+18]");
			bool flag = (nint)0 == 1;
			_ = 4294963370L;
			if (!flag)
			{
				_ = 4294945340L;
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v13+A0]");
				object obj17 = (nint)0 + (nint)16;
				object obj18 = default;
				obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v21+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v21+18]");
					bool flag2 = (nint)0 == 1;
					_ = 4294967295L;
					if (!flag2)
					{
						_ = 4293648865L;
						object obj19 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v17+A0]");
						object obj20 = (nint)0 + (nint)24;
						object obj21 = default;
						obj20 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v26+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v26+18]");
							bool flag3 = (nint)0 == 1;
							_ = 4289392895L;
							if (!flag3)
							{
								_ = 4281510630L;
								object obj22 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v21+A0]");
								object obj23 = (nint)0 + (nint)32;
								object obj24 = default;
								obj23 = obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v31+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v31+18]");
									bool flag4 = (nint)0 == 1;
									_ = 4287403775L;
									if (!flag4)
									{
										_ = 4280821980L;
										object obj25 = obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v25+A0]");
										object obj26 = (nint)0 + (nint)40;
										object obj27 = default;
										obj26 = obj27;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v36+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v36+18]");
											bool flag5 = (nint)0 == 1;
											_ = 4288386198L;
											if (!flag5)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9398]");
												object obj28 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9340]");
												object obj29 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9378]");
												object obj30 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93D8]");
												object obj31 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9400]");
												object obj32 = 0;
												_ = 4286412408L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9388]");
												object obj33 = 0;
												object obj34 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9370]");
												object obj35 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C93F0]");
												object obj36 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9360]");
												object obj37 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v29+A0]");
												object obj38 = (nint)0 + (nint)48;
												object obj39 = default;
												obj38 = obj39;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj40 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v30+A0]");
												object obj41 = 0;
												_ = 4281607196L;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v30+A0]");
												object obj42 = 0;
												_ = 0;
												int num = Shader.PropertyToID((string)obj28);
												object obj43 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v32+A0]");
												object obj44 = 0;
												int num2 = Shader.PropertyToID((string)obj29);
												object obj45 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v34+A0]");
												object obj46 = 0;
												int num3 = Shader.PropertyToID((string)obj30);
												object obj47 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v36+A0]");
												object obj48 = 0;
												int num4 = Shader.PropertyToID((string)obj31);
												object obj49 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v38+A0]");
												object obj50 = 0;
												int num5 = Shader.PropertyToID((string)obj32);
												object obj51 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v40+A0]");
												object obj52 = 0;
												int num6 = Shader.PropertyToID((string)obj33);
												object obj53 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v42+A0]");
												object obj54 = 0;
												int num7 = Shader.PropertyToID((string)obj35);
												object obj55 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v44+A0]");
												object obj56 = 0;
												int num8 = Shader.PropertyToID((string)obj36);
												object obj57 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v46+A0]");
												object obj58 = 0;
												int num9 = Shader.PropertyToID((string)obj37);
												object obj59 = obj3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v48+A0]");
												object obj60 = 0;
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
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
