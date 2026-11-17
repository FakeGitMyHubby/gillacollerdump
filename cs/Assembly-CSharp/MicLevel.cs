using System;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class MicLevel : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RaycastHit> _003C_003E9__132_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC510]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal int _003CUnblocked_003Eb__132_0(RaycastHit x, RaycastHit y)
		{
			float num = default;
			return num.CompareTo(y.m_Distance);
		}
	}

	public float minDb;

	public float maxDb;

	public float attack;

	public float release;

	public int sampleWindow = 512;

	public bool useKeyboardFallback = true;

	public KeyCode testKey;

	private float Level__BackingField;

	private float RawLevel__BackingField;

	private float Db__BackingField;

	private ModMenu.MicState State__BackingField;

	public float ExternalLevel = -1f;

	public bool externalOnly;

	public static bool TestDenied;

	private static int Asks__BackingField;

	private static bool asked;

	private AudioClip clip;

	private string device;

	private float[] buffer;

	private int lastPos;

	private float posStuckFor;

	private float retryIn;

	private int rateIndex;

	private float zeroFor;

	private KeyCode mappedFrom;

	private Key mappedKey;

	public float Level
	{
		get
		{
			return Level__BackingField;
		}
		private set
		{
			Level__BackingField = value;
		}
	}

	public float RawLevel
	{
		get
		{
			return RawLevel__BackingField;
		}
		private set
		{
			RawLevel__BackingField = value;
		}
	}

	public float Db
	{
		get
		{
			return Db__BackingField;
		}
		private set
		{
			Db__BackingField = value;
		}
	}

	public ModMenu.MicState State
	{
		get
		{
			return State__BackingField;
		}
		private set
		{
			State__BackingField = value;
		}
	}

	public static bool Allowed
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC520]");
			object permission = 0;
			return Permission.HasUserAuthorizedPermission((string)permission);
		}
	}

	public static int Asks
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC528]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4+4]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC528]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
			object obj3 = 0;
		}
	}

	private unsafe Key TestKeyMapped
	{
		get
		{
			//IL_001b: Expected Obj, but got Ref
			//IL_002f: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Ref, but got Unknown
			//IL_00b4: Expected Obj, but got I4
			if (testKey != mappedFrom)
			{
				mappedFrom = testKey;
				object obj = default;
				string value = ((Enum)(&obj)).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = Enum.TryParse<Unity.IL2CPP.Metadata.__Il2CppInt32Enum>(value, out *(Unity.IL2CPP.Metadata.__Il2CppInt32Enum*)(this + 136));
				bool flag3 = !flag2;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					mappedKey = (Key)36;
				}
			}
			return mappedKey;
		}
	}

	public static void AskOnce()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC528]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4+8]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null && !Allowed)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+A0]");
			object obj6 = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v9+4]");
			object obj7 = (nint)0 + (nint)1;
			GillaMic.AskOnce();
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC528]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		_ = 0;
		_ = 0;
		obj3 = 0;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		object obj2 = sampleWindow - 64;
		bool flag = (nint)obj2 < 0;
		bool flag2 = obj2 == null;
		int num = sampleWindow ^ 0x40;
		int num2 = sampleWindow ^ obj2;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		object obj4 = flag4 & obj3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			int num4 = sampleWindow;
		}
		else
		{
			int num4 = 64;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 104;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Start()
	{
		TryStartMic();
	}

	public void Restart()
	{
		externalOnly = false;
		ExternalLevel = -1f;
		TryStartMic();
	}

	private unsafe void TryStartMic()
	{
		//IL_0900: Expected Obj, but got I
		//IL_0940: Expected Obj, but got I4
		//IL_096d: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_017a: Expected Obj, but got Ref
		//IL_01c2: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01f2: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got Ref
		//IL_023c: Expected Obj, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected I4, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_1086: Expected Obj, but got I
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Expected I4, but got Unknown
		//IL_10f4: Expected Obj, but got I4
		//IL_114e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected Obj, but got Unknown
		//IL_1175: Expected Obj, but got I
		//IL_119f: Expected Obj, but got I4
		//IL_0987: Expected Obj, but got I
		//IL_0996: Expected I4, but got I8
		//IL_09c3: Expected Obj, but got I4
		//IL_09d4: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_0a96: Expected Obj, but got I4
		//IL_0aa7: Expected Obj, but got I4
		//IL_0a1b: Expected I, but got Obj
		//IL_0a4d: Expected Obj, but got I4
		//IL_0a5e: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I4
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected Obj, but got Unknown
		//IL_0aef: Expected Obj, but got I
		//IL_0413: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I4
		//IL_0456: Expected Obj, but got I4
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04e7: Expected Obj, but got I
		//IL_0ba0: Expected Obj, but got I8
		//IL_0bb8: Expected Obj, but got I4
		//IL_0bc9: Expected Obj, but got I4
		//IL_0b2b: Expected I, but got Obj
		//IL_0b5d: Expected Obj, but got I4
		//IL_0b6e: Expected Obj, but got I4
		//IL_0598: Expected Obj, but got I8
		//IL_05b0: Expected Obj, but got I4
		//IL_05c1: Expected Obj, but got I4
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got Unknown
		//IL_0523: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I4
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_0cb8: Expected Obj, but got I4
		//IL_0cc8: Expected Obj, but got I4
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected Obj, but got Unknown
		//IL_0cf6: Expected Obj, but got I4
		//IL_0d07: Expected Obj, but got I4
		//IL_0c3b: Expected I, but got Obj
		//IL_0c6d: Expected Obj, but got I4
		//IL_0c7e: Expected Obj, but got I4
		//IL_06b0: Expected Obj, but got I4
		//IL_06c0: Expected Obj, but got I4
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_06ee: Expected Obj, but got I4
		//IL_06ff: Expected Obj, but got I4
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Expected Obj, but got Unknown
		//IL_0633: Expected I, but got Obj
		//IL_0665: Expected Obj, but got I4
		//IL_0676: Expected Obj, but got I4
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_0dee: Expected Obj, but got I8
		//IL_0e06: Expected Obj, but got I4
		//IL_0e17: Expected Obj, but got I4
		//IL_0d79: Expected I, but got Obj
		//IL_0dab: Expected Obj, but got I4
		//IL_0dbc: Expected Obj, but got I4
		//IL_07e6: Expected Obj, but got I8
		//IL_07fe: Expected Obj, but got I4
		//IL_080f: Expected Obj, but got I4
		//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3b: Expected Obj, but got Unknown
		//IL_0771: Expected I, but got Obj
		//IL_07a3: Expected Obj, but got I4
		//IL_07b4: Expected Obj, but got I4
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected Obj, but got Unknown
		//IL_0855: Expected Obj, but got I
		//IL_0f0f: Expected Obj, but got I4
		//IL_0f1f: Expected Obj, but got I4
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected Obj, but got Unknown
		//IL_0f4d: Expected Obj, but got I4
		//IL_0f5e: Expected Obj, but got I4
		//IL_087b: Expected Obj, but got I
		//IL_08a5: Expected Obj, but got I4
		//IL_0e92: Expected I, but got Obj
		//IL_0ec4: Expected Obj, but got I4
		//IL_0ed5: Expected Obj, but got I4
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Expected Obj, but got Unknown
		//IL_0fa4: Expected Obj, but got I
		//IL_0fca: Expected Obj, but got I
		//IL_0ff4: Expected Obj, but got I4
		StopMic();
		if (~(externalOnly ? 1u : 0u) == 0)
		{
			retryIn = 0f;
			State__BackingField = (ModMenu.MicState)6;
			return;
		}
		NullReferenceException ex = default;
		if (Allowed)
		{
			string[] devices = Microphone.devices;
			if (devices != null)
			{
				if (devices.Length == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj = 0;
					State__BackingField = (ModMenu.MicState)2;
					retryIn = 2f;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v12+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC538]");
					object message = 0;
					Debug.LogWarning(message);
					return;
				}
				string[] devices2 = Microphone.devices;
				if (devices2 != null)
				{
					if (devices2.Length != 0)
					{
						object obj4 = this + 96;
						obj4 = devices2[0];
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Microphone.GetDeviceCaps((string)obj4, out var minFreq, out var maxFreq);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC530]");
						object obj6 = 0;
						object obj7 = obj6;
						int outputSampleRate = AudioSettings.outputSampleRate;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v24+18]");
						bool flag2 = (nint)0 == 0;
						int num = 0;
						object obj8 = (object)(&maxFreq);
						nint num2 = 4;
						if (!flag2)
						{
							int num3 = rateIndex;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v24+18]");
							int num4 = (int)((nint)num3 / (nint)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v24+18]");
							object obj9 = (nint)num4 * (nint)0;
							object obj10 = rateIndex - obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v24+18]");
							bool flag3 = (nint)obj10 < 0;
							object obj11 = !flag3;
							num = 0;
							obj8 = (object)(&maxFreq);
							num2 = 4;
							if (obj11 == null)
							{
								object obj13 = default;
								object obj12 = obj13 + obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
								object obj14 = -maxFreq;
								bool flag4 = (nint)obj14 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
								int num5 = (int)((nint)0 ^ (nint)maxFreq);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
								int num6 = 0 ^ obj14;
								int num7 = num5 & num6;
								bool flag5 = num7 < 0;
								int num8 = minFreq | maxFreq;
								bool flag6 = flag4 == flag5;
								object obj15 = !flag6;
								object obj16 = ~obj15;
								int num9;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
									num9 = 0;
								}
								else
								{
									num9 = maxFreq;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
								object obj17 = -minFreq;
								bool flag7 = (nint)obj17 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
								int num10 = (int)((nint)0 ^ (nint)minFreq);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
								int num11 = 0 ^ obj17;
								int num12 = num10 & num11;
								bool flag8 = num12 < 0;
								bool flag9 = flag7 == flag8;
								object obj18 = !flag9;
								object obj19 = ~obj18;
								if (obj19 == null)
								{
									num9 = minFreq;
								}
								int num13;
								if (num8 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23+20]");
									num13 = 0;
								}
								else
								{
									num13 = num9;
								}
								AudioClip audioClip = Microphone.Start(device, loop: true, 1, num13);
								object obj20 = this + 88;
								obj20 = audioClip;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
								object obj21 = 0;
								object obj22 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v31+E4]");
								bool flag10 = (nint)0 == 0;
								object obj23 = !flag10;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj29 = default;
								object obj33 = default;
								object obj40 = default;
								if ((UnityEngine.Object)obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
									object obj24 = 0;
									State__BackingField = (ModMenu.MicState)3;
									int num14 = rateIndex + 1;
									retryIn = 2f;
									rateIndex = num14;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									object[] array = default;
									bool flag11 = array == null;
									object obj25 = 0;
									num = num13;
									obj8 = 0;
									num2 = 4;
									if (!flag11)
									{
										bool flag12 = device == null;
										nint num15 = 4;
										if (!flag12)
										{
											nint num16 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
											num15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag13 = ex == null;
											obj25 = 0;
											num = num13;
											obj8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v73 (Il2CppClass<System.Object[]>)+40]");
											num2 = 0;
											if (flag13)
											{
												goto IL_103c;
											}
										}
										bool flag14 = array.Length == 0;
										obj25 = 0;
										num = num13;
										obj8 = 0;
										num2 = num15;
										if (!flag14)
										{
											object obj26 = array + 32;
											obj26 = device;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
											object obj27 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj28 = default;
											bool flag15 = obj28 == null;
											nint num17 = (nint)(&obj29);
											if (!flag15)
											{
												nint num18 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
												num17 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag16 = ex == null;
												obj25 = 0;
												num = num13;
												obj8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v72 (Il2CppClass<System.Object[]>)+40]");
												num2 = 0;
												if (flag16)
												{
													goto IL_103c;
												}
											}
											object obj30 = array.Length & 0xFFFFFFFEL;
											bool flag17 = obj30 == null;
											obj25 = 0;
											num = num13;
											obj8 = 0;
											num2 = num17;
											if (!flag17)
											{
												object obj31 = array + 40;
												obj31 = obj28;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object obj32 = default;
												bool flag18 = obj32 == null;
												nint num19 = (nint)(&obj33);
												if (!flag18)
												{
													nint num20 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v71 (Il2CppClass<System.Object[]>)+40]");
													num19 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag19 = ex == null;
													obj25 = 0;
													num = num13;
													obj8 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v71 (Il2CppClass<System.Object[]>)+40]");
													num2 = 0;
													if (flag19)
													{
														goto IL_103c;
													}
												}
												bool flag20 = array.Length < 2;
												object obj34 = !flag20;
												object obj35 = array.Length - 2;
												bool flag21 = obj35 == null;
												object obj36 = ~obj34;
												object obj37 = obj36 | flag21;
												obj25 = 0;
												num = num13;
												obj8 = 0;
												num2 = num19;
												if (obj37 == null)
												{
													object obj38 = array + 48;
													obj38 = obj32;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													object obj39 = default;
													bool flag22 = obj39 == null;
													nint num21 = (nint)(&obj40);
													if (!flag22)
													{
														nint num22 = (nint)array;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v70 (Il2CppClass<System.Object[]>)+40]");
														num21 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag23 = ex == null;
														obj25 = 0;
														num = num13;
														obj8 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v70 (Il2CppClass<System.Object[]>)+40]");
														num2 = 0;
														if (flag23)
														{
															goto IL_103c;
														}
													}
													object obj41 = array.Length & 0xFFFFFFFCL;
													bool flag24 = obj41 == null;
													obj25 = 0;
													num = num13;
													obj8 = 0;
													num2 = num21;
													if (!flag24)
													{
														object obj42 = array + 56;
														obj42 = obj39;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC548]");
														object format = 0;
														string message2 = string.Format((string)format, array);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
														object obj43 = 0;
														object obj44 = obj43;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v69+E4]");
														bool flag25 = (nint)0 == 0;
														object obj45 = !flag25;
														if (obj45 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														}
														Debug.LogWarning(message2);
														return;
													}
												}
											}
										}
										goto IL_1020;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
									object obj46 = 0;
									lastPos = -1;
									State__BackingField = (ModMenu.MicState)6;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									object[] array2 = default;
									bool flag26 = array2 == null;
									object obj25 = 0;
									num = num13;
									obj8 = 0;
									num2 = 5;
									if (!flag26)
									{
										bool flag27 = device == null;
										nint num23 = 5;
										if (!flag27)
										{
											nint num24 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
											num23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag28 = ex == null;
											obj25 = 0;
											num = num13;
											obj8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
											num2 = 0;
											if (flag28)
											{
												goto IL_103c;
											}
										}
										bool flag29 = array2.Length == 0;
										obj25 = 0;
										num = num13;
										obj8 = 0;
										num2 = num23;
										if (!flag29)
										{
											object obj47 = array2 + 32;
											obj47 = device;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
											object obj48 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj49 = default;
											bool flag30 = obj49 == null;
											nint num25 = (nint)(&obj29);
											if (!flag30)
											{
												nint num26 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
												num25 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag31 = ex == null;
												obj25 = 0;
												num = num13;
												obj8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v51 (Il2CppClass<System.Object[]>)+40]");
												num2 = 0;
												if (flag31)
												{
													goto IL_103c;
												}
											}
											object obj50 = array2.Length & 0xFFFFFFFEL;
											bool flag32 = obj50 == null;
											obj25 = 0;
											num = num13;
											obj8 = 0;
											num2 = num25;
											if (!flag32)
											{
												object obj51 = array2 + 40;
												obj51 = obj49;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object obj52 = default;
												bool flag33 = obj52 == null;
												nint num27 = (nint)(&obj33);
												if (!flag33)
												{
													nint num28 = (nint)array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
													num27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag34 = ex == null;
													obj25 = 0;
													num = num13;
													obj8 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
													num2 = 0;
													if (flag34)
													{
														goto IL_103c;
													}
												}
												bool flag35 = array2.Length < 2;
												object obj53 = !flag35;
												object obj54 = array2.Length - 2;
												bool flag36 = obj54 == null;
												object obj55 = ~obj53;
												object obj56 = obj55 | flag36;
												obj25 = 0;
												num = num13;
												obj8 = 0;
												num2 = num27;
												if (obj56 == null)
												{
													object obj57 = array2 + 48;
													obj57 = obj52;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													object obj58 = default;
													bool flag37 = obj58 == null;
													nint num29 = (nint)(&obj40);
													if (!flag37)
													{
														nint num30 = (nint)array2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
														num29 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag38 = ex == null;
														obj25 = 0;
														num = num13;
														obj8 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
														num2 = 0;
														if (flag38)
														{
															goto IL_103c;
														}
													}
													object obj59 = array2.Length & 0xFFFFFFFCL;
													bool flag39 = obj59 == null;
													obj25 = 0;
													num = num13;
													obj8 = 0;
													num2 = num29;
													if (!flag39)
													{
														object obj60 = array2 + 56;
														obj60 = obj58;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														int outputSampleRate2 = AudioSettings.outputSampleRate;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														object obj61 = default;
														bool flag40 = obj61 == null;
														int num32 = default;
														nint num31 = (nint)(&num32);
														if (!flag40)
														{
															nint num33 = (nint)array2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
															num31 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag41 = ex == null;
															obj25 = 0;
															num = num13;
															obj8 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
															num2 = 0;
															if (flag41)
															{
																goto IL_103c;
															}
														}
														bool flag42 = array2.Length < 4;
														object obj62 = !flag42;
														object obj63 = array2.Length - 4;
														bool flag43 = obj63 == null;
														object obj64 = ~obj62;
														object obj65 = obj64 | flag43;
														obj25 = 0;
														num = num13;
														obj8 = 0;
														num2 = num31;
														if (obj65 == null)
														{
															object obj66 = array2 + 64;
															obj66 = obj61;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC540]");
															object format2 = 0;
															string message3 = string.Format((string)format2, array2);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
															object obj67 = 0;
															object obj68 = obj67;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v47+E4]");
															bool flag44 = (nint)0 == 0;
															object obj69 = !flag44;
															if (obj69 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															Debug.Log(message3);
															return;
														}
													}
												}
											}
										}
										goto IL_1020;
									}
								}
								goto IL_102e;
							}
						}
					}
					goto IL_1020;
				}
			}
			goto IL_102e;
		}
		State__BackingField = (ModMenu.MicState)1;
		AskOnce();
		retryIn = 1f;
		return;
		IL_102e:
		ex = new NullReferenceException();
		goto IL_103c;
		IL_103c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_1020:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_102e;
	}

	private void StopMic()
	{
		//IL_0029: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I4
		bool flag = string.IsNullOrEmpty(device);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null && Microphone.IsRecording(device))
		{
			Microphone.End(device);
		}
		object obj2 = this + 88;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Update()
	{
		//IL_0a75: Invalid comparison between F4 and I4
		//IL_0a86: Expected Obj, but got I4
		//IL_0a8f: Invalid comparison between F4 and I4
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected Obj, but got Unknown
		//IL_0164: Invalid comparison between F4 and I4
		//IL_0175: Invalid comparison between F4 and I4
		//IL_03fd: Expected F8, but got I4
		//IL_002e: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		//IL_01a1: Invalid comparison between F4 and I4
		//IL_009c: Expected Obj, but got I4
		//IL_0966: Invalid comparison between F4 and I4
		//IL_0975: Invalid comparison between F4 and I4
		//IL_098c: Expected Obj, but got F4
		//IL_099b: Expected Obj, but got F4
		//IL_09d0: Expected Obj, but got I4
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_00cf: Invalid comparison between F4 and I4
		//IL_0a0b: Expected Obj, but got I4
		//IL_01d0: Invalid comparison between F4 and I4
		//IL_01e1: Expected Obj, but got I4
		//IL_01ea: Invalid comparison between F4 and I4
		//IL_0205: Expected Obj, but got I4
		//IL_0ad7: Invalid comparison between F8 and I4
		//IL_0ae6: Invalid comparison between F8 and I4
		//IL_0afe: Expected Obj, but got F8
		//IL_0b0b: Expected Obj, but got F8
		//IL_0b40: Expected Obj, but got I4
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0ca4: Expected Obj, but got F4
		//IL_0ccb: Invalid comparison between F8 and I4
		//IL_0cda: Expected F8, but got I4
		//IL_09fd: Expected Obj, but got I4
		//IL_0466: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		//IL_0154: Expected I4, but got Obj
		//IL_00ef: Expected F4, but got I4
		//IL_011c: Expected I, but got Obj
		//IL_0124: Expected I4, but got Obj
		//IL_0c2f: Expected Obj, but got I
		//IL_0c47: Expected Obj, but got I
		//IL_04e9: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I
		//IL_03da: Expected F4, but got I
		//IL_03ef: Expected I4, but got Obj
		//IL_0826: Expected I, but got Obj
		//IL_060c: Expected F8, but got I4
		//IL_0547: Expected Obj, but got I4
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_056a: Expected Obj, but got I8
		//IL_08a2: Invalid comparison between F4 and I4
		//IL_08b1: Invalid comparison between F4 and I4
		//IL_08c6: Expected Obj, but got F4
		//IL_08d5: Expected Obj, but got F4
		//IL_090a: Expected Obj, but got I4
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected Obj, but got Unknown
		//IL_07b3: Expected Obj, but got I4
		//IL_07bb: Expected I, but got Obj
		//IL_0654: Invalid comparison between F8 and I4
		//IL_0663: Expected F8, but got I4
		//IL_06f3: Expected Obj, but got I4
		//IL_0708: Expected I, but got Obj
		//IL_0c7f: Expected I, but got Obj
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_0c12: Expected Obj, but got I4
		//IL_0c1a: Expected I, but got Obj
		//IL_0740: Expected Obj, but got I4
		//IL_0755: Expected I, but got Obj
		float deltaTime = Time.deltaTime;
		bool flag = deltaTime < 0f;
		object obj = !flag;
		bool flag2 = deltaTime == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		double num4;
		bool flag10;
		double num3;
		nint num6;
		if (~(externalOnly ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v39+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = clip != null;
			bool flag5 = !flag4;
			MicLevel micLevel = (MicLevel)flag4;
			if (!flag5)
			{
				StopMic();
				micLevel = this;
			}
			float num = ExternalLevel;
			if (ExternalLevel < 0f)
			{
				num = 0f;
			}
			double num2 = (double)num - 1.0;
			bool flag6 = num2 < 0.0;
			bool flag7 = num2 == 0.0;
			object obj7 = (double)num ^ 1.0;
			object obj8 = (double)num ^ num2;
			object obj9 = obj7 & obj8;
			bool flag8 = (nint)obj9 < 0;
			bool flag9 = flag6 == flag8;
			object obj10 = !flag7;
			object obj11 = flag9 & obj10;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				num3 = 1.0;
				num4 = 1.0;
				int num5 = 0;
				num6 = unchecked((nint)null);
				flag10 = (byte)(int)micLevel != 0;
			}
			else
			{
				num3 = 1.0;
				num4 = num;
				int num5 = 0;
				num6 = unchecked((nint)null);
				flag10 = (byte)(int)micLevel != 0;
			}
			goto IL_0d2a;
		}
		bool flag11 = ExternalLevel < 0f;
		float[] array;
		ModMenu.MicState micState;
		double num13;
		object obj27;
		if (ExternalLevel < 0f)
		{
			float num7 = retryIn;
			if (retryIn > 0f)
			{
				num7 -= deltaTime;
				bool flag12 = num7 < 0f;
				object obj13 = !flag12;
				bool flag13 = num7 == 0f;
				retryIn = num7;
				object obj14 = !flag13;
				object obj15 = obj13 & obj14;
				if (obj15 == null)
				{
					TryStartMic();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v8+E4]");
			bool flag14 = (nint)0 == 0;
			object obj18 = !flag14;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (clip != null)
			{
				int position = Microphone.GetPosition(device);
				if (position == lastPos)
				{
					bool flag15 = !((double)(posStuckFor = deltaTime + posStuckFor) > 2.0);
					num3 = 2.0;
					flag10 = (byte)position != 0;
					if (!flag15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj19 = 0;
						State__BackingField = (ModMenu.MicState)4;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v33+E4]");
						bool flag16 = (nint)0 == 0;
						object obj21 = !flag16;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC550]");
						object obj22 = 0;
						Debug.LogWarning(obj22);
						int num8 = rateIndex + 1;
						rateIndex = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3E8]");
						posStuckFor = 0f;
						num3 = 2.0;
						flag10 = (byte)(int)obj22 != 0;
					}
				}
				else
				{
					lastPos = position;
					posStuckFor = 0f;
					bool flag17 = State__BackingField != (ModMenu.MicState)4;
					flag10 = (byte)position != 0;
					if (!flag17)
					{
						State__BackingField = (ModMenu.MicState)6;
						flag10 = (byte)position != 0;
					}
				}
				array = buffer;
				int num5 = position - array.Length;
				bool flag18 = position < array.Length;
				num6 = (nint)array;
				if (!flag18)
				{
					bool data = clip.GetData(array, num5);
					float[] array2 = buffer;
					if (array2.Length >= 1)
					{
						object obj23 = ~array2.Length;
						object obj24 = array2.Length & obj23;
						object obj25 = array2.Length & 0xFFFFFFFFL;
						do
						{
							if (obj25 != null)
							{
								obj25--;
								continue;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							throw new NullReferenceException();
						}
						while ((nint)obj24 != 1);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D120");
					num3 = minDb;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE38]");
					double num9 = 0.0 * 20.0;
					bool flag19 = minDb == maxDb;
					Db__BackingField = (float)num9;
					double num10 = 0.0;
					if (!flag19)
					{
						double num11 = num9 - (double)minDb;
						num3 = (double)maxDb - num3;
						double num12 = num11 / num3;
						bool flag20 = num12 < 0.0;
						num10 = 0.0;
						if (!flag20)
						{
							bool flag21 = num12 > 1.0;
							num10 = 1.0;
							if (!flag21)
							{
								num10 = num12;
							}
						}
					}
					RawLevel__BackingField = (float)num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
					object obj26 = default;
					if ((nint)obj26 < 0)
					{
						bool flag22 = !((double)(zeroFor = deltaTime + zeroFor) > 3.0);
						num13 = 20.0;
						obj27 = 0;
						num3 = 3.0;
						num6 = (nint)array;
						if (!flag22)
						{
							bool flag23 = State__BackingField != (ModMenu.MicState)6;
							num13 = 20.0;
							obj27 = 0;
							num3 = 3.0;
							num6 = (nint)array;
							if (!flag23)
							{
								num3 = 3.0;
								micState = (ModMenu.MicState)5;
								goto IL_0bf2;
							}
						}
					}
					else
					{
						zeroFor = 0f;
						bool flag24 = State__BackingField != (ModMenu.MicState)5;
						num13 = 20.0;
						obj27 = 0;
						num6 = (nint)array;
						if (!flag24)
						{
							micState = (ModMenu.MicState)6;
							goto IL_0bf2;
						}
					}
				}
			}
			else
			{
				RawLevel__BackingField = 0f;
				int num5 = 0;
				num6 = unchecked((nint)null);
			}
			goto IL_0b8b;
		}
		num3 = 0.0;
		if (!flag11)
		{
			bool flag25 = !((double)ExternalLevel > 1.0);
			num3 = ExternalLevel;
			if (!flag25)
			{
				num3 = 1.0;
			}
		}
		RawLevel__BackingField = (float)num3;
		flag10 = false;
		goto IL_094a;
		IL_0b8b:
		if (~(useKeyboardFallback ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D08]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v20+A0]");
			object obj30 = 0;
			if (obj30 != null)
			{
				Key testKeyMapped = TestKeyMapped;
				KeyControl keyControl = ((Keyboard)obj30).get_Item(testKeyMapped);
				flag10 = keyControl.isPressed;
				bool flag26 = !flag10;
				int num5 = 0;
				num6 = unchecked((nint)null);
				if (!flag26)
				{
					float time = Time.time;
					float num14 = time * 7f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					float num15 = num14 * 0.5f;
					float num16 = num15 + 0.5f;
					float num17 = RawLevel__BackingField - num16;
					bool flag27 = num17 < 0f;
					bool flag28 = num17 == 0f;
					object obj31 = RawLevel__BackingField ^ num16;
					object obj32 = RawLevel__BackingField ^ num17;
					object obj33 = obj31 & obj32;
					bool flag29 = (nint)obj33 < 0;
					bool flag30 = flag27 == flag29;
					object obj34 = !flag28;
					object obj35 = flag30 & obj34;
					object obj36 = ~obj35;
					num4 = ((obj36 != null) ? ((double)num16) : ((double)RawLevel__BackingField));
					num3 = 0.5;
					num5 = 0;
					num6 = unchecked((nint)null);
					goto IL_0d2a;
				}
			}
		}
		goto IL_094a;
		IL_0bf2:
		State__BackingField = micState;
		num13 = 20.0;
		obj27 = 0;
		num6 = (nint)array;
		goto IL_0b8b;
		IL_094a:
		float num18 = RawLevel__BackingField - Level__BackingField;
		bool flag31 = num18 < 0f;
		bool flag32 = num18 == 0f;
		object obj37 = RawLevel__BackingField ^ Level__BackingField;
		object obj38 = RawLevel__BackingField ^ num18;
		object obj39 = obj37 & obj38;
		bool flag33 = (nint)obj39 < 0;
		bool flag34 = flag31 == flag33;
		object obj40 = !flag32;
		object obj41 = flag34 & obj40;
		object obj42 = ~obj41;
		if (obj42 == null)
		{
			object obj43 = 40;
		}
		else
		{
			object obj43 = 44;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MicLevel)+v119 @ X8_v8]");
		float num19 = 0f * deltaTime;
		object obj44 = 0f - num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
		double num20 = 1.0 - (double)obj44;
		bool flag35 = num20 < 0.0;
		double num21 = 0.0;
		if (!flag35)
		{
			bool flag36 = !(num20 > 1.0);
			num21 = num20;
			if (!flag36)
			{
				num21 = 1.0;
			}
		}
		float num22 = RawLevel__BackingField - Level__BackingField;
		double num23 = (double)num22 * num21;
		double num24 = (double)Level__BackingField + num23;
		Level__BackingField = (float)num24;
		return;
		IL_0d2a:
		RawLevel__BackingField = (float)num4;
		goto IL_094a;
	}

	private void OnDisable()
	{
		StopMic();
	}

	private void OnApplicationFocus(bool focused)
	{
		if (focused && isActiveAndEnabled)
		{
			TryStartMic();
		}
	}

	public MicLevel()
	{
		//IL_0033: Expected F4, but got I
		//IL_004d: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D9B0]");
		minDb = 0f;
		testKey = (KeyCode)118;
		lastPos = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C500]");
		mappedFrom = (KeyCode)0;
		base._002Ector();
	}
}
