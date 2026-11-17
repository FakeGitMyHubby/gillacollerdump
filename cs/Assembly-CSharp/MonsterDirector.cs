using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class MonsterDirector : MonoBehaviour
{
	[Serializable]
	public class Entry
	{
		public string name;

		public string label;

		public GameObject prefab;

		public float eyeHeight;

		public float reach;

		public float walkSpeed;

		public float runSpeed;

		public bool legs;

		public bool grabs;

		public Mesh firstPersonMesh;

		public Vector3 palmL;

		public Vector3 palmR;

		public bool hangs;

		public bool onArms;

		public float playedSize = 1f;

		public bool choosable;

		public bool hingeArms;

		public Entry()
		{
			//IL_001d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F170]");
			eyeHeight = 0f;
			base._002Ector();
		}
	}

	public MonsterDisplay.Spawn[] spawns;

	public float backAfter;

	private const float CheckEvery = default(float);

	private const float Margin = default(float);

	private const float FallBelow = default(float);

	private const int MostEach = default(int);

	public static float LostAfter;

	public static float DeadTooLong;

	public static float FallbackAfter;

	public static float FallbackStagger;

	private static readonly Dictionary<string, float> deadTill;

	private readonly List<GameObject> local;

	private readonly Dictionary<string, int> inRoom;

	private readonly Dictionary<MonsterNet, float> lostSince;

	private readonly Dictionary<MonsterNet, float> deadSince;

	private readonly HashSet<string> takenOut;

	private readonly Dictionary<int, float> missingSince;

	private float offlineFor;

	private float nextCheck;

	private float joinedAt;

	private float fallbackQuietTill;

	private NetworkRunner joinedRunner;

	private bool toldNoMaster;

	private bool lookedForArea;

	private bool haveArea;

	private bool toldCrowded;

	private Bounds baseArea;

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0cfc: Expected Obj, but got I4
		//IL_0d22: Expected Obj, but got I
		//IL_0d44: Expected Obj, but got I4
		//IL_0e52: Expected Obj, but got I
		//IL_0e63: Expected Obj, but got I
		//IL_0e85: Expected Obj, but got I4
		//IL_0d7c: Expected Obj, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_055d: Expected F8, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_0595: Expected Obj, but got I4
		//IL_09fa: Invalid comparison between F4 and I4
		//IL_0a12: Expected Obj, but got F8
		//IL_0a1f: Expected Obj, but got F4
		//IL_0a54: Expected Obj, but got I4
		//IL_05c4: Expected Obj, but got I
		//IL_05d4: Expected Obj, but got I
		//IL_05dd: Expected Obj, but got I4
		//IL_05fc: Expected Obj, but got I4
		//IL_0dbf: Expected Obj, but got I
		//IL_0de9: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_0e2c: Expected Obj, but got I4
		//IL_0b38: Expected Obj, but got I4
		//IL_0625: Expected Obj, but got I
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected Obj, but got Unknown
		//IL_0ca4: Expected Obj, but got I4
		//IL_0674: Expected Obj, but got I4
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected Obj, but got Unknown
		//IL_0afa: Expected Obj, but got I4
		//IL_06a3: Expected Obj, but got I
		//IL_06cf: Expected Obj, but got I4
		//IL_0bae: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I
		//IL_0996: Expected Obj, but got I4
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected Obj, but got Unknown
		//IL_0bee: Expected Obj, but got I4
		//IL_06f2: Expected F4, but got I
		//IL_070c: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I4
		//IL_0c0c: Expected Obj, but got I
		//IL_0c41: Expected Obj, but got I4
		//IL_0c6e: Expected Obj, but got I
		//IL_07bb: Expected I4, but got Obj
		//IL_081d: Expected Obj, but got I4
		//IL_08fc: Expected Obj, but got I
		//IL_090c: Expected Obj, but got I
		//IL_091c: Expected Obj, but got I
		//IL_095f: Expected VT, but got I4
		//IL_096f: Expected F8, but got I
		//IL_097f: Expected F8, but got I
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_08b6: Expected VT, but got I4
		//IL_08c6: Expected F8, but got I
		//IL_08d6: Expected F8, but got I
		//IL_08df: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = obj9 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			if ((object)obj9 == null)
			{
				goto IL_0cbd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X21_v7 (UnityEngine.Object)+B0]");
			obj11 = (UnityEngine.Object)0;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(obj11 != null))
		{
			goto IL_0365;
		}
		if ((object)obj11 != null)
		{
			if (!((NetworkRunner)obj11).IsRunning)
			{
				goto IL_0365;
			}
			offlineFor = 0f;
			ClearLocal();
			if ((object)obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X21_v7 (UnityEngine.Object)+A4]");
				bool flag7 = (nint)0 == 0;
				object obj14 = !flag7;
				if (obj14 != null)
				{
					return;
				}
				float unscaledTime = Time.unscaledTime;
				if (unscaledTime < nextCheck)
				{
					return;
				}
				float unscaledTime2 = Time.unscaledTime;
				object obj15 = obj5;
				object obj16 = this + 112;
				float num = unscaledTime2 + 2f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v52+E4]");
				bool flag8 = (nint)0 == 0;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag9 = obj11 != (UnityEngine.Object)obj16;
				bool flag10 = !flag9;
				UnityEngine.Object obj18 = (UnityEngine.Object)obj16;
				if (flag10)
				{
					goto IL_0d8a;
				}
				joinedRunner = (NetworkRunner)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num = Time.unscaledTime;
				joinedAt = num;
				toldCrowded = false;
				toldNoMaster = false;
				if ((object)lostSince != null)
				{
					((Dictionary<System.__Canon, float>)(object)lostSince).Clear();
					if ((object)deadSince != null)
					{
						((Dictionary<System.__Canon, float>)(object)deadSince).Clear();
						if (missingSince != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCC8]");
							object obj19 = 0;
							obj18 = (UnityEngine.Object)obj19;
							missingSince.Clear();
							fallbackQuietTill = 0f;
							goto IL_0d8a;
						}
					}
				}
			}
		}
		goto IL_0cbd;
		IL_0365:
		object obj20 = this + 112;
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj21 = obj5;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		object obj22 = !flag11;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj9 != null)
		{
			if ((object)obj9 == null)
			{
				goto IL_0cbd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X21_v7 (UnityEngine.Object)+A4]");
			if ((nint)0 != 0)
			{
				offlineFor = 0f;
				return;
			}
		}
		float deltaTime = Time.deltaTime;
		float num2 = offlineFor + deltaTime;
		List<GameObject> list = local;
		offlineFor = num2;
		if ((object)local != null)
		{
			if (list._size > 0)
			{
				return;
			}
			object obj23 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v23+E4]");
			bool flag12 = (nint)0 == 0;
			object obj24 = !flag12;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = obj9 != null;
			bool flag14 = !flag13;
			object obj25 = !flag14;
			object obj26 = ~obj25;
			double num3 = ((obj26 != null) ? 0.0 : 2.0);
			if ((double)num2 < num3)
			{
				return;
			}
			MonsterDisplay.Spawn[] array = spawns;
			if (spawns != null)
			{
				object obj27 = array.Length;
				if (array.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4940]");
				object obj29 = 0;
				object obj30 = 0;
				int num4 = 17276928;
				double num5 = 2.0;
				object obj31 = 0;
				UnityEngine.Object obj32 = null;
				object obj38 = default;
				float num6 = default;
				Vector3 euler = default;
				System.__Canon _Canon = default;
				while (true)
				{
					bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
					object obj33 = !flag15;
					if (obj33 != null)
					{
						break;
					}
					object obj34 = (object)spawns + obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v17+20]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v17+20]");
					if ((nint)0 != 0)
					{
						object obj36 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v28+E4]");
						bool flag16 = (nint)0 == 0;
						object obj37 = !flag16;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+10]");
						bool flag17 = (UnityEngine.Object)0 != null;
						bool flag18 = !flag17;
						obj38 = obj38;
						num6 = num6;
						obj31 = 0;
						obj32 = null;
						if (flag18)
						{
							goto IL_098c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+20]");
						num2 = 0f;
						List<System.__Canon> list2 = (List<System.__Canon>)(object)local;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+10]");
						obj9 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+24]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
						object obj39 = num7 * 0;
						Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
						object obj40 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X0_v35+E4]");
						bool flag19 = (nint)0 == 0;
						object obj41 = !flag19;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
						if ((object)local != null)
						{
							System.__Canon[] items = list2._items;
							num4 = (int)obj29;
							int version = list2._version + 1;
							list2._version = version;
							if (list2._items != null)
							{
								bool flag20 = list2._size < items.Length;
								object obj42 = !flag20;
								if (obj42 == null)
								{
									object obj43 = list2._items + list2._size;
									num4 = list2._size + 1;
									list2._size = num4;
									object obj44 = obj43 + 32;
									obj44 = _Canon;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									object obj45 = obj38;
									float num8 = num6;
									double num9 = num5;
									obj38 = obj39;
									num6 = num2;
									euler = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+1C]");
									num5 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+18]");
									num3 = 0.0;
									obj31 = 0;
									obj32 = (UnityEngine.Object)(object)_Canon;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X9_v5 (System.Int32)+20]");
									object obj46 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v23+A8]");
									object obj47 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v24+70]");
									obj31 = 0;
									((List<System.__Canon>)(object)local).AddWithResize(_Canon);
									object obj45 = obj38;
									float num8 = num6;
									double num9 = num5;
									obj38 = obj39;
									num6 = num2;
									euler = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+1C]");
									num5 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X27_v4+18]");
									num3 = 0.0;
									obj32 = (UnityEngine.Object)(object)_Canon;
								}
								goto IL_098c;
							}
						}
					}
					goto IL_0cbd;
					IL_098c:
					obj27 = array.Length;
					obj30++;
					if ((nint)obj30 >= array.Length)
					{
						return;
					}
				}
				goto IL_0ccb;
			}
		}
		goto IL_0cbd;
		IL_0d8a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X21_v7 (UnityEngine.Object)+90]");
		object obj48;
		if ((nint)0 != 0)
		{
			double num10 = 2.0;
			obj48 = 1;
		}
		else
		{
			float unscaledTime3 = Time.unscaledTime;
			float num = unscaledTime3 - joinedAt;
			float num11 = num - 5f;
			bool flag21 = num11 < 0f;
			object obj49 = (double)num ^ 5.0;
			object obj50 = num ^ num11;
			object obj51 = obj49 & obj50;
			bool flag22 = (nint)obj51 < 0;
			bool flag23 = flag21 == flag22;
			object obj52 = !flag23;
			double num10 = 5.0;
			obj48 = obj52;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
		object obj53 = 0;
		object obj54 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v58+E4]");
		bool flag24 = (nint)0 == 0;
		object obj55 = !flag24;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (((NetworkRunner)obj11).IsSharedModeMasterClient)
		{
			if (missingSince != null)
			{
				missingSince.Clear();
				object obj56 = obj48 & 1;
				bool flag25 = obj56 == null;
				object obj57 = !flag25;
				if (obj57 == null)
				{
					TakeOutLost((NetworkRunner)obj11);
					MakeMissing((NetworkRunner)obj11);
				}
				return;
			}
			goto IL_0cbd;
		}
		bool flag26 = (byte)(~(toldNoMaster ? 1u : 0u)) != 0;
		object obj58 = !flag26;
		if (obj58 == null)
		{
			float unscaledTime4 = Time.unscaledTime;
			float num12 = unscaledTime4 - joinedAt;
			if ((double)num12 > 8.0)
			{
				object obj59 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v66+E4]");
				bool flag27 = (nint)0 == 0;
				object obj60 = !flag27;
				if (obj60 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag28 = AnyLive();
				bool flag29 = !flag28;
				object obj61 = !flag29;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj62 = 0;
					toldNoMaster = true;
					object obj63 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v68+E4]");
					bool flag30 = (nint)0 == 0;
					object obj64 = !flag30;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCD0]");
					object message = 0;
					Debug.Log(message);
				}
			}
		}
		object obj65 = obj48 & 1;
		bool flag31 = obj65 == null;
		object obj66 = !flag31;
		if (obj66 == null)
		{
			Fallback((NetworkRunner)obj11);
		}
		return;
		IL_0ccb:
		throw new IndexOutOfRangeException();
		IL_0cbd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ccb;
	}

	private static bool Master(NetworkRunner runner)
	{
		//IL_003d: Expected I4, but got Obj
		if ((object)runner != null)
		{
			return runner.IsSharedModeMasterClient;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void ClearLocal()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got Ref
		//IL_0105: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE248]");
		List<GameObject> list = (List<GameObject>)0;
		bool flag = (object)local == null;
		UnityEngine.Object obj = default;
		List<GameObject> list2 = (List<GameObject>)obj;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4928]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4920]");
			object obj4 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)local).GetEnumerator();
			UnityEngine.Object obj5 = obj;
			while (val.MoveNext())
			{
				object obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
				obj5 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = obj != null;
				bool flag4 = !flag3;
				object obj8 = 0;
				if (!flag4)
				{
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v33+E4]");
					obj5 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v33+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj);
					obj8 = 0;
				}
			}
			list2 = null;
			Enumerator<, > val2 = default;
			val = val2;
			object obj11 = 0;
			Enumerator<, > val3 = (Enumerator<, >)(ref val);
			list = (List<GameObject>)obj5;
			object obj12 = 0;
			object obj15 = default;
			while (true)
			{
				val.Dispose();
				bool flag6 = obj12 == null;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					bool flag7 = (object)list2 == null;
					object obj14 = !flag7;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					list = list2;
					if (obj14 == null)
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
					list2 = (List<GameObject>)1;
					list = (List<GameObject>)1;
					obj12 = obj11;
					continue;
				}
				if ((nint)obj4 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj12 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj11 = obj15;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D0C4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			list = local;
			if ((object)local != null)
			{
				int version = list._version + 1;
				list._size = 0;
				list._version = version;
				if (list._size >= 1)
				{
					Array.Clear(list._items, 0, list._size);
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	private static bool AnyLive()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_02a7: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected I4, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCD8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj5 = default;
		if (obj5 == null)
		{
			goto IL_028b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		bool flag2 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		bool flag3 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		object obj7 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		object obj8 = 0 & obj7;
		bool flag4 = (nint)obj8 < 0;
		bool flag5 = flag2 == flag4;
		object obj9 = !flag3;
		object obj10 = flag5 & obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
		bool flag6 = (nint)0 < (nint)1;
		object obj11 = obj10;
		if (flag6)
		{
			goto IL_0278;
		}
		object obj12 = obj5 + 32;
		object obj13 = 0;
		object obj14 = obj10;
		while (true)
		{
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			object obj15 = !flag7;
			if (obj15 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X22_v5+v83 @ X21_v6*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X22_v5+v83 @ X21_v6*8]");
				bool live = ((MonsterNet)0).Live;
				bool flag8 = !live;
				object obj16 = !flag8;
				obj11 = obj14;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
					obj6 = 0;
					obj13++;
					object obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
					object obj18 = obj17 - 0;
					bool flag9 = (nint)obj18 < 0;
					object obj19 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
					object obj20 = obj19 ^ 0;
					object obj21 = obj13 ^ obj18;
					object obj22 = obj20 & obj21;
					bool flag10 = (nint)obj22 < 0;
					bool flag11 = flag9 == flag10;
					object obj23 = !flag11;
					object obj24 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+18]");
					bool flag12 = (nint)obj24 < 0;
					obj11 = obj23;
					obj14 = obj23;
					if (flag12)
					{
						continue;
					}
				}
				goto IL_0278;
			}
			goto IL_028b;
		}
		goto IL_0299;
		IL_0299:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_028b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0299;
		IL_0278:
		return (byte)(obj11 & 1) != 0;
	}

	private static string Kind(MonsterNet m)
	{
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		if ((object)m != null)
		{
			string text = m.name;
			if (text != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB568]");
				object oldValue = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object newValue = 0;
				string text2 = text.Replace((string)oldValue, (string)newValue);
				if (text2 != null)
				{
					return text2.Trim();
				}
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public static void Killed(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB568]");
		object oldValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object newValue = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v5+A0]");
		object obj8 = 0;
		string text = name.Replace((string)oldValue, (string)newValue);
		string key = text.Trim();
		float time = Time.time;
		UnityEngine.Object obj9 = default;
		object obj10;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5 (UnityEngine.Object)+28]");
			obj10 = 0;
		}
		else
		{
			obj10 = 1123024896;
		}
		float value = time + (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7+10]");
		((Dictionary<System.__Canon, float>)0).set_Item((System.__Canon)(object)key, value);
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		((Dictionary<System.__Canon, float>)0).Clear();
	}

	private unsafe void MakeMissing(NetworkRunner runner)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		//IL_07cc: Expected Obj, but got I4
		//IL_033d: Expected F4, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_09f3: Expected Obj, but got I4
		//IL_07e1: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_01cf: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I
		//IL_0416: Expected Obj, but got I4
		//IL_041b: Expected I, but got Obj
		//IL_0856: Expected Obj, but got I
		//IL_0866: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I4
		//IL_0967: Expected Obj, but got I4
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_058d: Expected Obj, but got I4
		//IL_05c2: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I
		//IL_062a: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I
		//IL_0713: Expected I, but got Obj
		//IL_0740: Expected Obj, but got I4
		//IL_0780: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		object obj2;
		object obj9;
		object obj10;
		if ((object)inRoom != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6398]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCD8]");
			object obj3 = 0;
			((Dictionary<System.__Canon, int>)(object)inRoom).Clear();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			System.__Canon _Canon = (System.__Canon)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6418]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v10+18]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6420]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v10+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_02e2;
				}
				nint num2 = default;
				nint num = num2;
				object obj12 = default;
				object obj11 = obj12;
				System.__Canon _Canon2 = (System.__Canon)obj3;
				object obj13 = 0;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
					object obj14 = !flag2;
					if (obj14 != null)
					{
						break;
					}
					object obj15 = obj6 + obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v32+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v32+20]");
						if (((MonsterNet)0).Live)
						{
							object obj16 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v57+E4]");
							bool flag3 = (nint)0 == 0;
							object obj17 = !flag3;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v32+20]");
							string text = Kind((MonsterNet)0);
							if ((object)inRoom == null)
							{
								goto IL_08da;
							}
							bool flag4 = ((Dictionary<System.__Canon, int>)(object)inRoom).TryGetValue((System.__Canon)(object)text, out int value);
							bool flag5 = !flag4;
							obj11 = obj9;
							object obj18 = !flag5;
							int num3 = ((obj18 == null) ? 1 : (value + 1));
							((Dictionary<System.__Canon, int>)(object)inRoom).set_Item((System.__Canon)(object)text, num3);
							num = num3;
							_Canon2 = (System.__Canon)(object)text;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v10+18]");
						obj8 = 0;
						obj13++;
						object obj19 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v10+18]");
						bool flag6 = (nint)obj19 < 0;
						num2 = num;
						obj12 = obj11;
						_Canon = _Canon2;
						if (flag6)
						{
							continue;
						}
						goto IL_02e2;
					}
					goto IL_08da;
				}
				goto IL_08e8;
			}
		}
		goto IL_08da;
		IL_02e2:
		MonsterDisplay.Spawn[] array = spawns;
		if (spawns == null)
		{
			goto IL_08da;
		}
		object obj20 = array.Length;
		object obj21;
		if (array.Length >= 1)
		{
			float value2 = 0f;
			int value3 = 0;
			obj21 = 0;
			object obj22 = 0;
			float num6 = default;
			float num8 = default;
			while (true)
			{
				bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
				object obj23 = !flag7;
				if (obj23 != null)
				{
					break;
				}
				object obj24 = (object)spawns + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+20]");
				MonsterDisplay.Spawn spawn = (MonsterDisplay.Spawn)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+20]");
				NetworkRunner networkRunner;
				if ((nint)0 != 0)
				{
					object obj25 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v25+E4]");
					bool flag8 = (nint)0 == 0;
					object obj26 = !flag8;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = spawn.prefab == null;
					bool flag10 = !flag9;
					object obj27 = !flag10;
					nint num2 = unchecked((nint)null);
					networkRunner = null;
					if (obj27 != null)
					{
						goto IL_095d;
					}
					if ((object)spawn.prefab != null)
					{
						string key = spawn.prefab.name;
						if ((object)inRoom != null)
						{
							if (((Dictionary<System.__Canon, int>)(object)inRoom).TryGetValue((System.__Canon)(object)key, out value3) && value3 >= 1)
							{
								if ((object)spawn.prefab != null)
								{
									string text2 = spawn.prefab.name;
									if ((object)inRoom != null)
									{
										object obj12 = obj9;
										int num4 = value3 - 1;
										((Dictionary<System.__Canon, int>)(object)inRoom).set_Item((System.__Canon)(object)text2, num4);
										num2 = num4;
										networkRunner = (NetworkRunner)(object)text2;
										goto IL_095d;
									}
								}
							}
							else
							{
								object obj28 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v35+E4]");
								bool flag11 = (nint)0 == 0;
								object obj29 = !flag11;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj28 = obj10;
								}
								if ((object)spawn.prefab != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v35+A0]");
									object obj30 = 0;
									string text3 = spawn.prefab.name;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X9_v9+10]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE48]");
										object obj31 = 0;
										object obj12 = obj31;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X9_v9+10]");
										bool flag12 = ((Dictionary<System.__Canon, float>)0).TryGetValue((System.__Canon)(object)text3, out value2);
										bool flag13 = !flag12;
										float num5 = num6;
										float num7 = num8;
										if (!flag13)
										{
											num7 = Time.time;
											bool flag14 = num7 < value2;
											num5 = value2;
											num6 = value2;
											num8 = num7;
											num2 = (nint)(&value2);
											networkRunner = (NetworkRunner)(object)text3;
											if (flag14)
											{
												goto IL_095d;
											}
										}
										if ((object)spawn.prefab != null)
										{
											string text4 = spawn.prefab.name;
											if (takenOut != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
												object obj32 = 0;
												num2 = (nint)obj32;
												bool flag15 = ((HashSet<System.__Canon>)(object)takenOut).Contains((System.__Canon)(object)text4);
												bool flag16 = !flag15;
												object obj33 = !flag16;
												num6 = num5;
												num8 = num7;
												networkRunner = (NetworkRunner)(object)text4;
												if (obj33 == null)
												{
													bool flag17 = flag15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+20]");
													bool flag18 = ((MonsterDirector)flag17).SpawnOne(runner, (MonsterDisplay.Spawn)0);
													obj21 += flag18;
													num6 = num5;
													num8 = num7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v17+20]");
													num2 = 0;
													networkRunner = runner;
												}
												goto IL_095d;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_08da;
				IL_095d:
				obj20 = array.Length;
				obj22++;
				bool flag19 = (nint)obj22 < array.Length;
				System.__Canon _Canon = (System.__Canon)(object)networkRunner;
				if (flag19)
				{
					continue;
				}
				goto IL_09bd;
			}
			goto IL_08e8;
		}
		obj21 = 0;
		goto IL_09bd;
		IL_09bd:
		if ((nint)obj21 < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		if ((object)runner != null)
		{
			SessionInfo sessionInfo = runner.SessionInfo__BackingField;
			if (runner.SessionInfo__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD28]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj35 = 0;
				object arg = default;
				object arg2 = default;
				string message = string.Format((string)format, arg, arg2, sessionInfo.Name__BackingField);
				object obj36 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v15+E4]");
				bool flag20 = (nint)0 == 0;
				object obj37 = !flag20;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message);
				return;
			}
		}
		goto IL_08da;
		IL_08da:
		NullReferenceException ex = new NullReferenceException();
		goto IL_08e8;
		IL_08e8:
		throw new IndexOutOfRangeException();
	}

	private unsafe bool SpawnOne(NetworkRunner runner, MonsterDisplay.Spawn s)
	{
		//IL_0047: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got Ref
		//IL_0094: Expected Obj, but got I
		//IL_00a1: Expected VT, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected VT, but got Unknown
		//IL_0295: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_00e5: Expected VT, but got Obj
		//IL_00f2: Expected VT, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_01a5: Expected VT, but got Ref
		//IL_01a5: Expected VT, but got I4
		//IL_01b9: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_044a: Invalid comparison between VT and I4
		//IL_034e: Expected VT, but got I4
		//IL_048a: Expected I, but got Obj
		//IL_0492: Expected Obj, but got I
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I
		//IL_0647: Expected VT, but got I4
		//IL_039d: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I
		//IL_03ec: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got Ref
		//IL_0568: Expected Obj, but got I
		//IL_057c: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got VT
		//IL_05df: Expected Obj, but got I4
		MonsterDisplay.Spawn spawn = default;
		bool flag = spawn == null;
		NetworkRunner networkRunner = runner;
		NetworkRunner networkRunner2 = runner;
		MonsterDisplay.Spawn spawn2;
		if (!flag)
		{
			bool flag2 = (object)spawn.prefab == null;
			networkRunner = runner;
			networkRunner2 = runner;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5358]");
				object obj = 0;
				spawn2 = (MonsterDisplay.Spawn)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
				object obj3 = default;
				object obj2 = obj3 & 1;
				NetworkObject networkObject = default;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
					object obj4 = 0;
					Vector3? position = (Vector3)obj4;
					float yaw = spawn.yaw;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
					Quaternion? quaternion = (Quaternion?)(object)(yaw * 0);
					Vector3 euler = default;
					Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(ref euler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
					object obj5 = 0;
					Quaternion quaternion3 = (Quaternion)obj5;
					Quaternion? quaternion4 = (Quaternion)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7B0]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v30+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)runner != null)
					{
						object obj9 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v31+A0]");
						object obj10 = 0;
						NetworkObject prefab = networkObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v32+8]");
						Quaternion? quaternion5 = default;
						NetworkObject networkObject2 = runner.Spawn(prefab, position, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion5), null, (NetworkSpawnFlags)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj11 = 0;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v61+E4]");
						bool flag4 = (nint)0 == 0;
						object obj13 = !flag4;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)networkObject2 != (UnityEngine.Object)null)
						{
							return true;
						}
						bool flag5 = (object)spawn.prefab == null;
						quaternion = quaternion4;
						spawn2 = null;
						quaternion3 = (Quaternion)0;
						if (!flag5)
						{
							string arg = spawn.prefab.name;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD38]");
							object format = 0;
							object arg2 = default;
							string message = string.Format((string)format, arg, arg2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj15 = 0;
							object obj16 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v71+E4]");
							bool flag6 = (nint)0 == 0;
							object obj17 = !flag6;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogError(message);
							goto IL_0417;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					NullReferenceException ex2 = new NullReferenceException();
					bool flag7 = quaternion3 != (Quaternion)(object)1;
					NullReferenceException ex3 = ex2;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						NetworkRunner networkRunner3 = default;
						nint num = (nint)networkRunner3;
						networkRunner = (NetworkRunner)num;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
						object obj19 = default;
						object obj18 = obj19 & 1;
						bool flag8 = obj18 == null;
						networkRunner2 = networkRunner3;
						if (!flag8)
						{
							object obj20 = 0;
							networkRunner2 = networkRunner3;
							object obj22 = default;
							object obj21 = (object)(&obj22);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							bool flag9 = (object)spawn2.prefab == null;
							spawn = spawn2;
							if (!flag9)
							{
								string arg3 = spawn2.prefab.name;
								bool flag10 = (object)networkRunner3 == null;
								spawn = spawn2;
								networkRunner = null;
								if (!flag10)
								{
									SceneRef sceneRef = ((Fusion.NetworkSceneManagerDummy)(object)networkRunner3).GetSceneRef((GameObject)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									string format2 = default;
									object arg4 = default;
									string message2 = string.Format(format2, arg3, sceneRef, arg4);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v53+E4]");
									bool flag11 = (nint)0 == 0;
									object obj24 = !flag11;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Debug.LogError(message2);
									return false;
								}
							}
							goto IL_0613;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj25 = networkRunner2;
						quaternion3 = (Quaternion)(101789696 + 1224);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						spawn2 = null;
						NullReferenceException ex4 = default;
						ex3 = ex4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					bool result = default;
					return result;
				}
				bool flag12 = (object)spawn.prefab == null;
				spawn = (MonsterDisplay.Spawn)obj;
				networkRunner = (NetworkRunner)(&networkObject);
				networkRunner2 = runner;
				if (!flag12)
				{
					string text = spawn.prefab.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD48]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD40]");
					object obj27 = 0;
					string message3 = (string)obj26 + text + (string)obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj28 = 0;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v16+E4]");
					bool flag13 = (nint)0 == 0;
					object obj30 = !flag13;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogError(message3);
					goto IL_0417;
				}
			}
		}
		goto IL_0613;
		IL_0417:
		return false;
		IL_0613:
		spawn2 = spawn;
		throw new NullReferenceException();
	}

	private unsafe void TakeOutLost(NetworkRunner runner)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_0cf2: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_013a: Expected F4, but got I4
		//IL_0143: Expected Obj, but got I4
		//IL_0e6a: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_0c89: Expected Obj, but got I
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_03ac: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_03e7: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I
		//IL_044b: Expected I, but got Obj
		//IL_0466: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I
		//IL_0e06: Expected Obj, but got I4
		//IL_0313: Expected I, but got Obj
		//IL_0e88: Expected Obj, but got I
		//IL_0349: Expected Obj, but got I4
		//IL_0e36: Expected I, but got Obj
		//IL_04b9: Expected F8, but got I4
		//IL_04f6: Expected I, but got Obj
		//IL_0524: Expected Obj, but got I4
		//IL_053e: Expected Obj, but got I4
		//IL_0543: Expected I, but got Obj
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_058a: Expected I, but got Obj
		//IL_05cf: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I
		//IL_0634: Expected I, but got Obj
		//IL_0645: Expected Obj, but got I4
		//IL_066b: Expected Obj, but got I4
		//IL_06eb: Expected I, but got Obj
		//IL_0681: Expected I, but got Obj
		//IL_0691: Expected Obj, but got I
		//IL_06af: Expected I, but got Obj
		//IL_06c7: Expected Obj, but got I
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Obj, but got Unknown
		//IL_0731: Expected I, but got Obj
		//IL_0741: Expected Obj, but got I
		//IL_0764: Expected I, but got Obj
		//IL_078e: Expected Obj, but got I8
		//IL_07a2: Expected I, but got Obj
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_07e9: Expected Obj, but got I
		//IL_0806: Expected I, but got Obj
		//IL_083e: Expected Obj, but got I
		//IL_0864: Expected Obj, but got Ref
		//IL_08ea: Expected Obj, but got I4
		//IL_08fa: Expected Obj, but got I4
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected Obj, but got Unknown
		//IL_0924: Expected I, but got Obj
		//IL_087a: Expected I, but got Obj
		//IL_088a: Expected Obj, but got I
		//IL_08a8: Expected I, but got Obj
		//IL_08c0: Expected Obj, but got I
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_0976: Expected I, but got Obj
		//IL_09ba: Expected I, but got Obj
		//IL_0a77: Expected Obj, but got I8
		//IL_0a8b: Expected I, but got Obj
		//IL_0a17: Expected I, but got Obj
		//IL_0a27: Expected Obj, but got I
		//IL_0a45: Expected I, but got Obj
		//IL_0a55: Expected Obj, but got I
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected Obj, but got Unknown
		//IL_0ad1: Expected Obj, but got I
		//IL_0af7: Expected Obj, but got I
		//IL_0b21: Expected Obj, but got I4
		//IL_0b5d: Expected I, but got Obj
		//IL_0b80: Expected I, but got Obj
		//IL_0b97: Expected Obj, but got I
		//IL_0bc4: Expected Obj, but got I
		//IL_0bda: Expected I, but got Obj
		//IL_0bf1: Expected Obj, but got I
		//IL_0c1e: Expected Obj, but got I
		//IL_0c5f: Expected I, but got Obj
		bool flag = takenOut == null;
		MonsterNet monsterNet = (MonsterNet)(object)runner;
		object obj8;
		float num;
		IndexOutOfRangeException ex = default;
		float unscaledTime;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47C0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCD8]");
			object obj3 = 0;
			((HashSet<System.__Canon>)(object)takenOut).Clear();
			unscaledTime = Time.unscaledTime;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			monsterNet = (MonsterNet)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
			object obj6 = default;
			bool flag3 = obj6 == null;
			num = unscaledTime;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0cc8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCF8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD00]");
				object obj10 = 0;
				float value = 0f;
				object obj11 = 0;
				num = unscaledTime;
				object obj23 = default;
				object[] array = default;
				MonsterNet monsterNet4 = default;
				float num7 = default;
				while (true)
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
					object obj12 = !flag4;
					if (obj12 != null)
					{
						break;
					}
					object obj13 = obj6 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
					MonsterNet monsterNet2 = (MonsterNet)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
						if (!((MonsterNet)0).Live)
						{
							goto IL_0c79;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
						string text = LostWhy((MonsterNet)0, unscaledTime);
						if (text != null)
						{
							bool flag5 = (object)lostSince == null;
							string text2 = text;
							num = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
							monsterNet = (MonsterNet)0;
							if (!flag5)
							{
								Dictionary<MonsterNet, float> dictionary = lostSince;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
								if (((Dictionary<System.__Canon, float>)(object)dictionary).TryGetValue((System.__Canon)0, out value))
								{
									object obj14 = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v38+E4]");
									bool flag6 = (nint)0 == 0;
									object obj15 = !flag6;
									if (obj15 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag9;
									nint num2;
									if (monsterNet2.brain != null)
									{
										MonsterBrain brain = monsterNet2.brain;
										bool flag7 = (object)monsterNet2.brain == null;
										num2 = unchecked((nint)null);
										text2 = text;
										num = unscaledTime;
										monsterNet = null;
										if (flag7)
										{
											goto IL_0d2b;
										}
										object obj16 = brain.state__BackingField - 4;
										bool flag8 = obj16 == null;
										flag9 = flag8;
									}
									else
									{
										flag9 = false;
									}
									object obj17 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v43+E4]");
									bool flag10 = (nint)0 == 0;
									object obj18 = !flag10;
									if (obj18 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj17 = obj8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v43+A0]");
									object obj19 = 0;
									float num3 = unscaledTime - value;
									double num4 = (flag9 ? 20.0 : 0.0);
									num = (float)obj19 + (float)num4;
									bool flag11 = num3 < num;
									num2 = unchecked((nint)null);
									text2 = text;
									monsterNet = null;
									if (!flag11)
									{
										NetworkObject networkObject = ((SimulationBehaviour)monsterNet2)._object;
										bool flag12 = (object)((SimulationBehaviour)monsterNet2)._object == null;
										num2 = unchecked((nint)null);
										text2 = text;
										monsterNet = null;
										if (!flag12)
										{
											object obj20 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
											bool flag13 = obj20 == null;
											object obj21 = !flag13;
											num2 = unchecked((nint)null);
											text2 = text;
											monsterNet = null;
											if (obj21 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
												object obj22 = obj23 & 1;
												bool flag14 = obj22 == null;
												num2 = unchecked((nint)null);
												text2 = text;
												monsterNet = null;
												if (!flag14)
												{
													object obj24 = obj8;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v46+E4]");
													bool flag15 = (nint)0 == 0;
													object obj25 = !flag15;
													if (obj25 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
													string text3 = Kind((MonsterNet)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
													object obj26 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													bool flag16 = array == null;
													num2 = unchecked((nint)null);
													text2 = text;
													monsterNet = (MonsterNet)4;
													if (!flag16)
													{
														bool flag17 = text3 == null;
														MonsterNet monsterNet3 = (MonsterNet)4;
														if (!flag17)
														{
															nint num5 = (nint)array;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
															monsterNet3 = (MonsterNet)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag18 = ex == null;
															num2 = unchecked((nint)null);
															text2 = text;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
															monsterNet = (MonsterNet)0;
															if (flag18)
															{
																goto IL_0d47;
															}
														}
														bool flag19 = array.Length == 0;
														num2 = unchecked((nint)null);
														text2 = text;
														monsterNet = monsterNet3;
														if (flag19)
														{
															break;
														}
														object obj27 = array + 32;
														obj27 = text3;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														nint num6 = (nint)array;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
														monsterNet = (MonsterNet)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag20 = ex == null;
														num2 = unchecked((nint)null);
														text2 = text;
														if (flag20)
														{
															goto IL_0d47;
														}
														object obj28 = array.Length & 0xFFFFFFFEL;
														bool flag21 = obj28 == null;
														num2 = unchecked((nint)null);
														text2 = text;
														if (flag21)
														{
															break;
														}
														object obj29 = array + 40;
														obj29 = text;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
														Transform transform = ((Component)0).transform;
														bool flag22 = (object)transform == null;
														num2 = unchecked((nint)null);
														text2 = text;
														monsterNet = null;
														if (!flag22)
														{
															Vector3 position = transform.position;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
															object obj30 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
															bool flag23 = (object)monsterNet4 == null;
															MonsterNet monsterNet5 = (MonsterNet)(&num7);
															if (!flag23)
															{
																nint num8 = (nint)array;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
																monsterNet5 = (MonsterNet)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag24 = ex == null;
																num2 = unchecked((nint)null);
																text2 = (string)(object)monsterNet4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
																monsterNet = (MonsterNet)0;
																if (flag24)
																{
																	goto IL_0d47;
																}
															}
															bool flag25 = array.Length < 2;
															object obj31 = !flag25;
															object obj32 = array.Length - 2;
															bool flag26 = obj32 == null;
															object obj33 = ~obj31;
															object obj34 = obj33 | flag26;
															num2 = unchecked((nint)null);
															text2 = (string)(object)monsterNet4;
															monsterNet = monsterNet5;
															if (obj34 != null)
															{
																break;
															}
															object obj35 = array + 48;
															obj35 = monsterNet4;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															bool flag27 = (object)runner == null;
															num2 = unchecked((nint)null);
															text2 = (string)(object)monsterNet4;
															monsterNet = monsterNet4;
															if (!flag27)
															{
																SessionInfo sessionInfo = runner.SessionInfo__BackingField;
																bool flag28 = runner.SessionInfo__BackingField == null;
																num2 = unchecked((nint)null);
																text2 = (string)(object)monsterNet4;
																monsterNet = monsterNet4;
																if (!flag28)
																{
																	text2 = sessionInfo.Name__BackingField;
																	bool flag29 = sessionInfo.Name__BackingField == null;
																	MonsterNet monsterNet6 = monsterNet4;
																	if (!flag29)
																	{
																		nint num9 = (nint)array;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
																		monsterNet6 = (MonsterNet)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																		bool flag30 = ex == null;
																		num2 = unchecked((nint)null);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
																		monsterNet = (MonsterNet)0;
																		if (flag30)
																		{
																			goto IL_0d47;
																		}
																	}
																	object obj36 = array.Length & 0xFFFFFFFCL;
																	bool flag31 = obj36 == null;
																	num2 = unchecked((nint)null);
																	monsterNet = monsterNet6;
																	if (flag31)
																	{
																		break;
																	}
																	object obj37 = array + 56;
																	obj37 = text2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD10]");
																	object format = 0;
																	string text4 = string.Format((string)format, array);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
																	object obj38 = 0;
																	object obj39 = obj38;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v44+E4]");
																	bool flag32 = (nint)0 == 0;
																	object obj40 = !flag32;
																	if (obj40 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	Debug.LogWarning(text4);
																	bool flag33 = (object)lostSince == null;
																	num2 = unchecked((nint)null);
																	text2 = text4;
																	monsterNet = null;
																	if (!flag33)
																	{
																		num2 = (nint)obj9;
																		Dictionary<MonsterNet, float> dictionary2 = lostSince;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
																		bool flag34 = ((Dictionary<System.__Canon, float>)(object)dictionary2).Remove((System.__Canon)0);
																		bool flag35 = (object)deadSince == null;
																		text2 = text4;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
																		monsterNet = (MonsterNet)0;
																		if (!flag35)
																		{
																			num2 = (nint)obj9;
																			Dictionary<MonsterNet, float> dictionary3 = deadSince;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
																			bool flag36 = ((Dictionary<System.__Canon, float>)(object)dictionary3).Remove((System.__Canon)0);
																			bool flag37 = takenOut == null;
																			text2 = text4;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
																			monsterNet = (MonsterNet)0;
																			if (!flag37)
																			{
																				bool flag38 = ((HashSet<System.__Canon>)(object)takenOut).Add((System.__Canon)(object)text3);
																				runner.Despawn(((SimulationBehaviour)monsterNet2)._object);
																				num7 = num;
																				num2 = unchecked((nint)null);
																				text2 = text4;
																				monsterNet = (MonsterNet)(object)((SimulationBehaviour)monsterNet2)._object;
																				goto IL_0c79;
																			}
																		}
																	}
																}
															}
														}
													}
													goto IL_0d2b;
												}
											}
										}
									}
								}
								else
								{
									bool flag39 = (object)lostSince == null;
									nint num2 = (nint)(&value);
									text2 = text;
									num = unscaledTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
									monsterNet = (MonsterNet)0;
									if (flag39)
									{
										goto IL_0d2b;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD08]");
									object obj41 = 0;
									num2 = (nint)obj41;
									Dictionary<MonsterNet, float> dictionary4 = lostSince;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
									((Dictionary<System.__Canon, float>)(object)dictionary4).set_Item((System.__Canon)0, unscaledTime);
									text2 = text;
									num = unscaledTime;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
									monsterNet = (MonsterNet)0;
								}
								goto IL_0c79;
							}
						}
						else
						{
							bool flag40 = (object)lostSince == null;
							string text2 = text;
							num = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
							monsterNet = (MonsterNet)0;
							if (!flag40)
							{
								nint num2 = (nint)obj9;
								Dictionary<MonsterNet, float> dictionary5 = lostSince;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
								bool flag41 = ((Dictionary<System.__Canon, float>)(object)dictionary5).Remove((System.__Canon)0);
								text2 = text;
								num = unscaledTime;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v14+20]");
								monsterNet = (MonsterNet)0;
								goto IL_0c79;
							}
						}
					}
					goto IL_0d2b;
					IL_0c79:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+18]");
					obj7 = 0;
					obj11++;
					object obj42 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+18]");
					if ((nint)obj42 < 0)
					{
						continue;
					}
					goto IL_0cbb;
				}
				goto IL_0d39;
			}
		}
		goto IL_0d2b;
		IL_0d47:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0d39:
		ex = new IndexOutOfRangeException();
		goto IL_0d47;
		IL_0cbb:
		unscaledTime = num;
		goto IL_0cc8;
		IL_0cc8:
		object obj43 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v23+E4]");
		bool flag42 = (nint)0 == 0;
		object obj44 = !flag42;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Prune(lostSince);
		Prune(deadSince);
		return;
		IL_0d2b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d39;
	}

	private unsafe static void Prune(Dictionary<MonsterNet, float> since)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Ref, but got Unknown
		//IL_081b: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got I4
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got I4
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got I4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I4
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03e6: Expected Obj, but got I4
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got I
		//IL_077f: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I4
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I4
		//IL_065d: Expected Obj, but got I4
		//IL_06b9: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE250]");
		System.__Canon[] array = (System.__Canon[])0;
		bool flag = (object)since == null;
		UnityEngine.Object obj = default;
		System.__Canon[] array2 = (System.__Canon[])(object)obj;
		Enumerator<> val = (Enumerator<>)0;
		IntPtr intPtr = default;
		UnityEngine.Object obj2 = (UnityEngine.Object)(nint)intPtr;
		UnityEngine.Object obj9;
		Enumerator<> val3 = default;
		NullReferenceException ex;
		Dictionary<MonsterNet, float> dictionary;
		object obj14;
		object obj17;
		Enumerator<> val4;
		Enumerator<> val5;
		if (!flag)
		{
			if (((Dictionary<System.__Canon, float>)(object)since).Count == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD80]");
			array = (System.__Canon[])0;
			obj2 = (UnityEngine.Object)(object)array;
			Dictionary<System.__Canon, float>.KeyCollection keys = ((Dictionary<System.__Canon, float>)(object)since).Keys;
			bool flag2 = keys == null;
			array2 = (System.__Canon[])(object)obj;
			val = (Enumerator<>)0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD98]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDD8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDD0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDC0]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD88]");
				object obj8 = 0;
				Enumerator<> enumerator = keys.GetEnumerator();
				Enumerator<> val2 = (Enumerator<>)(ref val);
				obj9 = obj;
				List<System.__Canon> list = null;
				List<System.__Canon> list2 = default;
				while (val.MoveNext())
				{
					object obj10 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v47+E4]");
					obj9 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v47+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj == null;
					bool flag5 = !flag4;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						if ((object)obj == null)
						{
							goto IL_0585;
						}
						bool live = ((MonsterNet)obj).Live;
						bool flag6 = !live;
						object obj13 = !flag6;
						obj14 = 0;
						if (obj13 != null)
						{
							continue;
						}
					}
					bool flag7 = list == null;
					object obj15 = !flag7;
					UnityEngine.Object obj16 = null;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						obj16 = (UnityEngine.Object)obj6;
						list2._002Ector();
						bool flag8 = list2 == null;
						list = list2;
						obj14 = 0;
						array2 = null;
						val = val3;
						obj17 = 0;
						val4 = val3;
						val5 = (Enumerator<>)(ref val);
						obj2 = (UnityEngine.Object)obj6;
						array = (System.__Canon[])(object)obj9;
						dictionary = since;
						if (flag8)
						{
							goto IL_0610;
						}
					}
					array = list._items;
					val2 = (Enumerator<>)obj7;
					int version = list._version + 1;
					list._version = version;
					bool flag9 = list._items == null;
					obj14 = 0;
					array2 = null;
					val = val3;
					obj17 = 0;
					val4 = val3;
					val5 = (Enumerator<>)(ref val);
					obj2 = obj16;
					if (!flag9)
					{
						version = list._size;
						bool flag10 = list._size < array.Length;
						object obj18 = !flag10;
						if (obj18 == null)
						{
							object obj19 = list._items + list._size;
							int num = ++list._size;
							object obj20 = obj19 + 32;
							obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj14 = 0;
							val2 = (Enumerator<>)num;
							obj9 = (UnityEngine.Object)(object)list._items;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X9_v3 (System.Collections.Generic.List`1<System.__Canon>+ValueCollection<System.__Canon, System.Single>+Enumerator<System.__Canon, System.Single>)+20]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v31+A8]");
							obj9 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v11 (UnityEngine.Object)+70]");
							obj14 = 0;
							list.AddWithResize((System.__Canon)(object)obj);
						}
						continue;
					}
					goto IL_05dd;
				}
				array2 = null;
				val = val3;
				obj17 = 0;
				val4 = val3;
				val5 = (Enumerator<>)(ref val);
				object obj22 = 7;
				dictionary = since;
				Enumerator<, > val6 = default;
				object obj28 = default;
				while (true)
				{
					object obj23 = obj17;
					array = (System.__Canon[])(object)obj9;
					List<System.__Canon> list3 = list;
					while (true)
					{
						obj2 = (UnityEngine.Object)obj8;
						((Enumerator<>*)val5)->Dispose();
						bool flag11 = obj23 == null;
						object obj24 = !flag11;
						if (obj24 != null)
						{
							break;
						}
						bool flag12 = array2 == null;
						object obj25 = !flag12;
						ex = (NullReferenceException)val5;
						array = array2;
						if (obj25 == null)
						{
							if ((nint)obj22 != 7)
							{
								bool flag13 = obj22 == null;
								object obj26 = !flag13;
								if (obj26 != null)
								{
									return;
								}
							}
							if (list3 != null)
							{
								Enumerator<, > enumerator2 = list3.GetEnumerator();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCF8]");
								object obj27 = 0;
								while (val6.MoveNext())
								{
									obj14 = obj27;
									bool flag14 = ((Dictionary<System.__Canon, float>)(object)dictionary).Remove((System.__Canon)null);
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD90]");
								array = (System.__Canon[])0;
								obj2 = (UnityEngine.Object)(object)array;
								val6.Dispose();
								array2 = null;
								obj17 = 0;
								val5 = (Enumerator<>)(ref val6);
								dictionary = null;
								OutOfMemoryException ex2 = new OutOfMemoryException();
								if ((nint)obj2 != 2)
								{
									if ((nint)obj2 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
										obj23 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
										obj17 = obj28;
										obj22 = 0;
										list3 = null;
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FF28");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return;
								}
								goto IL_0629;
							}
							return;
						}
						goto IL_05f3;
					}
					break;
					IL_0629:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					array2 = (System.__Canon[])1;
					obj22 = 0;
					obj9 = (UnityEngine.Object)1;
					list = null;
				}
				goto IL_0602;
			}
		}
		goto IL_05cf;
		IL_05cf:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_05dd;
		IL_05dd:
		ex = new NullReferenceException();
		dictionary = since;
		goto IL_05f3;
		IL_0585:
		NullReferenceException ex4 = new NullReferenceException();
		obj14 = 0;
		array2 = null;
		val = val3;
		obj17 = 0;
		val4 = val3;
		val5 = (Enumerator<>)(ref val);
		obj2 = null;
		array = (System.__Canon[])(object)obj9;
		goto IL_05cf;
		IL_0610:
		throw new NullReferenceException();
		IL_0602:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0610;
		IL_05f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0602;
	}

	private unsafe string LostWhy(MonsterNet m, float now)
	{
		//IL_003f: Expected Obj, but got I
		//IL_0076: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got F4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got I4
		//IL_033f: Invalid comparison between Obj and F4
		//IL_0350: Expected F4, but got VT
		//IL_0358: Expected Obj, but got Ref
		//IL_038b: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got Ref
		//IL_0376: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I
		//IL_0634: Invalid comparison between F4 and I
		//IL_050f: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I
		object result;
		if ((object)m != null)
		{
			Transform transform = m.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
				object obj = 0;
				Vector3 position = transform.position;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = now >> 23;
				object obj5 = obj4 & 0xFF;
				bool flag2 = (nint)obj5 < 254;
				object obj6 = !flag2;
				object obj7 = obj5 - 254;
				bool flag3 = obj7 == null;
				object obj8 = !flag3;
				object obj9 = obj6 & obj8;
				if (obj9 == null)
				{
					object obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v13+E4]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj13 = default;
					object obj12 = obj13 >> 23;
					object obj14 = obj12 & 0xFF;
					bool flag5 = (nint)obj14 < 254;
					object obj15 = !flag5;
					object obj16 = obj14 - 254;
					bool flag6 = obj16 == null;
					object obj17 = !flag6;
					object obj18 = obj15 & obj17;
					if (obj18 == null)
					{
						object obj19 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v15+E4]");
						bool flag7 = (nint)0 == 0;
						object obj20 = !flag7;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj22 = default;
						object obj21 = obj22 >> 23;
						object obj23 = obj21 & 0xFF;
						bool flag8 = (nint)obj23 < 255;
						object obj24 = !flag8;
						if (obj24 == null)
						{
							Vector3 point = default;
							if (Area(out var area))
							{
								bool flag9 = area.Internal_Contains(ref point);
								bool flag10 = !flag9;
								object obj25 = !flag10;
								float num = now;
								float num2 = now;
								object obj26 = (object)(&point);
								if (obj25 == null)
								{
									object obj27 = default;
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27))
									{
										goto IL_0366;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD70]");
									result = 0;
									goto IL_05f8;
								}
							}
							else
							{
								float num3 = LowestSpot();
								float num = num3 + 3.256877E+09f;
								bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num);
								float num2 = (float)point;
								object obj26 = (object)(&area);
								if (!flag11)
								{
									goto IL_0366;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
							object obj28 = 0;
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v20+E4]");
							bool flag12 = (nint)0 == 0;
							object obj30 = !flag12;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (!(m.brain != null))
							{
								goto IL_0553;
							}
							MonsterBrain brain = m.brain;
							if ((object)m.brain != null)
							{
								if (~(brain.Dead__BackingField ? 1u : 0u) != 0)
								{
									goto IL_0553;
								}
								if ((object)deadSince != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD00]");
									object obj31 = 0;
									if (((Dictionary<System.__Canon, float>)(object)deadSince).TryGetValue((System.__Canon)(object)m, out float value))
									{
										object obj32 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v32+E4]");
										bool flag13 = (nint)0 == 0;
										object obj33 = !flag13;
										if (obj33 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											obj32 = obj;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v32+A0]");
										object obj34 = 0;
										float num4 = now - value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v36+4]");
										if (num4 > 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
											object obj35 = 0;
											float num5 = now - value;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD60]");
											object format = 0;
											object arg = default;
											return string.Format((string)format, arg);
										}
									}
									else
									{
										if ((object)deadSince == null)
										{
											goto IL_05cd;
										}
										((Dictionary<System.__Canon, float>)(object)deadSince).set_Item((System.__Canon)(object)m, now);
									}
									goto IL_058b;
								}
							}
							goto IL_05cd;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD68]");
				result = 0;
				goto IL_05f8;
			}
		}
		goto IL_05cd;
		IL_0553:
		if ((object)deadSince != null)
		{
			bool flag14 = ((Dictionary<System.__Canon, float>)(object)deadSince).Remove((System.__Canon)(object)m);
			goto IL_058b;
		}
		goto IL_05cd;
		IL_05f8:
		return (string)result;
		IL_058b:
		return null;
		IL_0366:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCD58]");
		result = 0;
		goto IL_05f8;
		IL_05cd:
		return (string)(object)new NullReferenceException();
	}

	private static bool Finite(float f)
	{
		//IL_000e: Expected Obj, but got F4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		object obj = f >> 23;
		object obj2 = obj & 0xFF;
		bool flag = (nint)obj2 < 255;
		object obj3 = !flag;
		return (byte)(int)(~obj3) != 0;
	}

	private unsafe bool Area(out Bounds area)
	{
		//IL_0435: Expected Obj, but got I4
		//IL_03fc: Expected Ref, but got VT
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0020: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected VT, but got Unknown
		//IL_0080: Expected Ref, but got VT
		//IL_041f: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_01e7: Expected F8, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected VT, but got Unknown
		//IL_01ff: Expected Ref, but got VT
		//IL_0222: Expected VT, but got I
		//IL_022b: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got Ref
		//IL_02bd: Expected Obj, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0348: Expected Obj, but got I
		//IL_0362: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I4
		bool flag = (byte)(~(lookedForArea ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			ref Bounds area2 = ref *(Bounds*)(this + 124);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDE8]");
			object obj2 = 0;
			lookedForArea = true;
			if (haveArea = GillaPlaces.AreaNamed((string)obj2, out area2))
			{
				Bounds bounds = (Bounds)(this + 124);
				((Bounds*)bounds)->Expand(10f);
				MonsterDisplay.Spawn[] array = spawns;
				if (spawns == null)
				{
					goto IL_0403;
				}
				object obj3 = array.Length;
				if (array.Length >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj4 = 0;
					object obj5 = 0;
					double num = 10.0;
					object obj6 = 0;
					UnityEngine.Object obj7 = null;
					Vector3 point = default;
					object arg2 = default;
					object arg3 = default;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
						object obj8 = !flag2;
						if (obj8 != null)
						{
							break;
						}
						object obj9 = (object)spawns + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v13+20]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v13+20]");
						if ((nint)0 != 0)
						{
							object obj11 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v12+E4]");
							bool flag3 = (nint)0 == 0;
							object obj12 = !flag3;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v6+10]");
							bool flag4 = (UnityEngine.Object)0 != null;
							bool flag5 = !flag4;
							obj6 = 0;
							obj7 = null;
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v6+18]");
								num = 0.0;
								Bounds bounds2 = (Bounds)(this + 124);
								bool flag6 = ((Bounds*)bounds2)->Internal_Contains(ref point);
								bool flag7 = !flag6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v6+18]");
								point = (Vector3)0;
								obj6 = 0;
								obj7 = (UnityEngine.Object)(&point);
								if (flag7)
								{
									haveArea = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v6+10]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v6+10]");
										string arg = ((UnityEngine.Object)0).name;
										Bounds bounds3 = baseArea;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+88]");
										object obj13 = bounds3 - 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+84]");
										nint num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+90]");
										object obj15 = num2 - 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Bounds bounds4 = baseArea;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+88]");
										object obj16 = bounds4 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+84]");
										nint num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+90]");
										object obj17 = num3 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDE0]");
										object format = 0;
										string message = string.Format((string)format, arg, arg2, arg3);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
										object obj18 = 0;
										object obj19 = obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v21+E4]");
										bool flag8 = (nint)0 == 0;
										object obj20 = !flag8;
										if (obj20 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.LogWarning(message);
										goto IL_03e5;
									}
									goto IL_0403;
								}
							}
							obj3 = array.Length;
							obj5++;
							if ((nint)obj5 < array.Length)
							{
								continue;
							}
							goto IL_03e5;
						}
						goto IL_0403;
					}
					goto IL_0411;
				}
			}
		}
		goto IL_03e5;
		IL_0411:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0403:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0411;
		IL_03e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterDirector)+8C]");
		_ = 0;
		ref Bounds reference = ref *(Bounds*)baseArea;
		return haveArea;
	}

	private float LowestSpot()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0162: Expected F4, but got I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		//IL_0047: Expected F4, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0170: Expected F4, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0123: Invalid comparison between F4 and I
		//IL_014f: Expected F4, but got I
		MonsterDisplay.Spawn[] array = spawns;
		if (spawns == null)
		{
			goto IL_0182;
		}
		object obj = array.Length;
		float num;
		if (array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			num = 2.139095E+09f;
			object obj3 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj4 = !flag;
				if (obj4 != null)
				{
					break;
				}
				object obj5 = (object)spawns + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+20]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+20]");
				if ((nint)0 == 0)
				{
					goto IL_0182;
				}
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v6+10]");
				if ((UnityEngine.Object)0 != null)
				{
					float num2 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v6+1C]");
					if (!(num2 < 0f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v6+1C]");
						num = 0f;
					}
				}
				obj = array.Length;
				obj3++;
				if ((nint)obj3 < array.Length)
				{
					continue;
				}
				goto IL_0202;
			}
			goto IL_0190;
		}
		num = 2.139095E+09f;
		goto IL_0202;
		IL_0190:
		throw new IndexOutOfRangeException();
		IL_0182:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0190;
		IL_0202:
		object obj9 = num & 0x7FFFFFFF;
		if ((nint)obj9 == 2139095040)
		{
			return 0f;
		}
		return num;
	}

	private unsafe void Fallback(NetworkRunner runner)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I4
		//IL_103e: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_1006: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_0578: Expected F4, but got I4
		//IL_0581: Expected Obj, but got I4
		//IL_1156: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_0c0d: Expected Obj, but got I
		//IL_0c50: Expected Obj, but got I
		//IL_0c7a: Expected Obj, but got I4
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f34: Expected Obj, but got Unknown
		//IL_0f4a: Expected Obj, but got I
		//IL_0f68: Expected Obj, but got I4
		//IL_0f80: Expected Obj, but got I
		//IL_0cb0: Expected Obj, but got I
		//IL_0cfc: Expected Obj, but got I
		//IL_0d26: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I4
		//IL_0cdf: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I4
		//IL_0658: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_0d72: Expected Obj, but got I
		//IL_0acb: Expected Obj, but got I4
		//IL_0ad3: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I4
		//IL_0dad: Expected Obj, but got I
		//IL_0dd7: Expected Obj, but got I4
		//IL_0e4f: Expected Obj, but got I
		//IL_0312: Expected I, but got Obj
		//IL_0e93: Expected Obj, but got I
		//IL_0ebd: Expected Obj, but got I4
		//IL_085a: Expected Obj, but got I4
		//IL_0a67: Expected Obj, but got I
		//IL_0a6f: Expected I, but got Obj
		//IL_105c: Expected Obj, but got I
		//IL_1080: Expected Obj, but got I
		//IL_0776: Expected Obj, but got I
		//IL_07d0: Expected I, but got Obj
		//IL_08f1: Expected Obj, but got I4
		//IL_0afc: Expected Obj, but got I4
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_0952: Invalid comparison between F4 and I4
		//IL_0961: Invalid comparison between F4 and I4
		//IL_0974: Expected Obj, but got F4
		//IL_0981: Expected Obj, but got F4
		//IL_09b6: Expected Obj, but got I4
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected Obj, but got Unknown
		//IL_0b35: Expected Obj, but got I
		//IL_0b4f: Expected Obj, but got I
		//IL_0b75: Expected Obj, but got I
		//IL_0b9f: Expected Obj, but got I4
		//IL_10dc: Expected Obj, but got I
		//IL_110f: Expected I4, but got Obj
		//IL_0bd2: Expected I, but got Obj
		//IL_0a1d: Expected I, but got Obj
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected Obj, but got Unknown
		float unscaledTime = Time.unscaledTime;
		object obj3;
		object obj10;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		object obj13;
		if ((object)inRoom != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6398]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj3 = 0;
			((Dictionary<System.__Canon, int>)(object)inRoom).Clear();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCD8]");
			object obj6 = 0;
			PlayerRef none = PlayerRef.None;
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			System.__Canon _Canon = (System.__Canon)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
			object obj9 = default;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v14+18]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v14+18]");
				float num;
				if ((nint)0 >= (nint)1)
				{
					num = unscaledTime;
					object obj12 = 0;
					playerRef = none;
					playerRef2 = none;
					obj13 = 0;
					PlayerRef none3 = default;
					while (true)
					{
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
						object obj14 = !flag3;
						if (obj14 != null)
						{
							break;
						}
						object obj15 = obj9 + obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v74+20]");
						MonsterNet monsterNet = (MonsterNet)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v74+20]");
						if ((nint)0 == 0)
						{
							goto IL_0ee9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v74+20]");
						if (((MonsterNet)0).Live)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
							object obj16 = 0;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X0_v101+E4]");
							bool flag4 = (nint)0 == 0;
							object obj18 = !flag4;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							PlayerRef none2 = PlayerRef.None;
							if (playerRef2 == none2)
							{
								NetworkObject networkObject = ((SimulationBehaviour)monsterNet)._object;
								if ((object)((SimulationBehaviour)monsterNet)._object == null)
								{
									goto IL_0ee9;
								}
								int* ptr = networkObject.Ptr;
								if (networkObject.Ptr != null)
								{
									NetworkRunner runner2 = networkObject._runner;
									if ((object)networkObject._runner == null || (object)runner2._simulation == null)
									{
										goto IL_0ee9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
									nint num2 = unchecked((nint)null);
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
									object obj19 = 0;
									object obj20 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v118+E4]");
									bool flag5 = (nint)0 == 0;
									object obj21 = !flag5;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									none3 = PlayerRef.None;
								}
								playerRef = none3;
								playerRef2 = none3;
							}
							obj13++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v74+20]");
							string text = LostWhy((MonsterNet)0, unscaledTime);
							bool flag6 = text == null;
							object obj22 = !flag6;
							num = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v74+20]");
							_Canon = (System.__Canon)0;
							if (obj22 == null)
							{
								object obj23 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X0_v108+E4]");
								bool flag7 = (nint)0 == 0;
								object obj24 = !flag7;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v74+20]");
								string text2 = Kind((MonsterNet)0);
								if ((object)inRoom == null)
								{
									goto IL_0ee9;
								}
								bool flag8 = ((Dictionary<System.__Canon, int>)(object)inRoom).TryGetValue((System.__Canon)(object)text2, out int value);
								bool flag9 = !flag8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6420]");
								object obj25 = 0;
								object obj26 = obj25;
								object obj27 = !flag9;
								int num3 = ((obj27 == null) ? 1 : (value + 1));
								((Dictionary<System.__Canon, int>)(object)inRoom).set_Item((System.__Canon)(object)text2, num3);
								num = unscaledTime;
								nint num2 = num3;
								_Canon = (System.__Canon)(object)text2;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v14+18]");
						obj11 = 0;
						obj12++;
						object obj28 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v14+18]");
						if ((nint)obj28 < 0)
						{
							continue;
						}
						goto IL_1014;
					}
					goto IL_0ef7;
				}
				num = unscaledTime;
				playerRef = none;
				playerRef2 = none;
				obj13 = 0;
				goto IL_1014;
			}
		}
		goto IL_0ee9;
		IL_0ef7:
		throw new IndexOutOfRangeException();
		IL_1014:
		object obj29 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X0_v16+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Prune(deadSince);
		int num4 = Rank(runner);
		MonsterDisplay.Spawn[] array = spawns;
		if (spawns == null)
		{
			goto IL_0ee9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DD0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7168]");
		object obj32 = 0;
		int value2 = 0;
		float num5 = 0f;
		object obj33 = 0;
		int num6 = 0;
		object obj45 = default;
		object obj52 = default;
		object arg = default;
		int num11 = default;
		object arg3 = default;
		object arg4 = default;
		PlayerRef playerRef3 = default;
		object arg5 = default;
		object arg6 = default;
		while (true)
		{
			bool flag11 = num6 < array.Length;
			object obj34 = !flag11;
			int num7;
			Dictionary<int, float> dictionary;
			if (num6 < array.Length)
			{
				if (obj34 != null)
				{
					break;
				}
				object obj35 = array + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v41+20]");
				MonsterDisplay.Spawn spawn = (MonsterDisplay.Spawn)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v41+20]");
				if ((nint)0 != 0)
				{
					object obj36 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v63+E4]");
					bool flag12 = (nint)0 == 0;
					object obj37 = !flag12;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = spawn.prefab == null;
					bool flag14 = !flag13;
					object obj38 = !flag14;
					nint num2 = unchecked((nint)null);
					num7 = 0;
					if (obj38 != null)
					{
						goto IL_0a97;
					}
					if ((object)spawn.prefab != null)
					{
						string key = spawn.prefab.name;
						if ((object)inRoom != null)
						{
							if (((Dictionary<System.__Canon, int>)(object)inRoom).TryGetValue((System.__Canon)(object)key, out value2) && value2 >= 1)
							{
								if ((object)spawn.prefab != null)
								{
									string key2 = spawn.prefab.name;
									if ((object)inRoom != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6420]");
										object obj39 = 0;
										int value3 = value2 - 1;
										object obj26 = obj39;
										((Dictionary<System.__Canon, int>)(object)inRoom).set_Item((System.__Canon)(object)key2, value3);
										dictionary = missingSince;
										if (missingSince != null)
										{
											num2 = (nint)obj31;
											goto IL_111d;
										}
									}
								}
							}
							else if (missingSince != null)
							{
								object obj26 = obj32;
								if (missingSince.TryGetValue(num6, out var value4))
								{
									MonsterDirector monsterDirector = (MonsterDirector)obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v78 (MonsterDirector)+E4]");
									bool flag15 = (nint)0 == 0;
									object obj40 = !flag15;
									if (obj40 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										monsterDirector = (MonsterDirector)obj10;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v78 (MonsterDirector)+A0]");
									object obj41 = 0;
									float num8 = unscaledTime - value4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v52+C]");
									object obj42 = (nint)0 * (nint)num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v52+8]");
									float num = 0f + (float)obj42;
									bool flag16 = num8 < num;
									num2 = (nint)(&value4);
									num7 = num6;
									if (!flag16)
									{
										num = fallbackQuietTill;
										bool flag17 = unscaledTime < fallbackQuietTill;
										num2 = (nint)(&value4);
										num7 = num6;
										if (!flag17)
										{
											MonsterDisplay.Spawn[] array2 = spawns;
											if (spawns == null)
											{
												goto IL_0ee9;
											}
											object obj43 = array2.Length + array2.Length;
											object obj44 = obj45 + obj13;
											if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43))
											{
												num = unscaledTime - value4;
												object obj46 = obj33 + 1;
												float num9 = num5 - num;
												bool flag18 = num9 < 0f;
												bool flag19 = num9 == 0f;
												object obj47 = num5 ^ num;
												object obj48 = num5 ^ num9;
												object obj49 = obj47 & obj48;
												bool flag20 = (nint)obj49 < 0;
												bool flag21 = flag18 == flag20;
												object obj50 = !flag19;
												object obj51 = flag21 & obj50;
												object obj27 = ~obj51;
												if (obj27 != null)
												{
													num5 = num;
												}
												MonsterDirector monsterDirector2 = monsterDirector;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v41+20]");
												bool flag22 = monsterDirector2.SpawnOne(runner, (MonsterDisplay.Spawn)0);
												bool flag23 = !flag22;
												obj33 = obj46;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v41+20]");
												num2 = 0;
												num7 = (int)runner;
												if (!flag23)
												{
													dictionary = missingSince;
													if (missingSince == null)
													{
														goto IL_0ee9;
													}
													num2 = (nint)obj31;
													obj45 = obj52 + 1;
													obj33 = obj46;
													goto IL_111d;
												}
											}
											else
											{
												bool flag24 = (byte)(~(toldCrowded ? 1u : 0u)) != 0;
												object obj53 = !flag24;
												num2 = (nint)(&value4);
												num7 = num6;
												if (obj53 == null)
												{
													toldCrowded = true;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj54 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCE8]");
													object format = 0;
													string message = string.Format((string)format, arg);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
													object obj55 = 0;
													object obj56 = obj55;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X8_v65+E4]");
													bool flag25 = (nint)0 == 0;
													object obj57 = !flag25;
													if (obj57 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Debug.LogWarning(message);
													object obj58 = obj13;
													num2 = unchecked((nint)null);
													num7 = 0;
												}
											}
										}
									}
								}
								else
								{
									if (missingSince == null)
									{
										goto IL_0ee9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F28]");
									object obj59 = 0;
									num2 = (nint)obj59;
									missingSince.set_Item(num6, unscaledTime);
									float num = unscaledTime;
									num7 = num6;
								}
								goto IL_0a97;
							}
						}
					}
				}
			}
			else
			{
				if (obj33 == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj60 = 0;
				float num10 = unscaledTime + 1.1146363E+09f;
				fallbackQuietTill = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj61 = 0;
				object obj62 = obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v18+E4]");
				bool flag26 = (nint)0 == 0;
				object obj63 = !flag26;
				if (obj63 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none4 = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCF0]");
				object format2 = 0;
				object arg2;
				if (playerRef2 == none4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC2A0]");
					object obj64 = 0;
					arg2 = obj64;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj65 = 0;
					object obj66 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X0_v52+E4]");
					bool flag27 = (nint)0 == 0;
					object obj67 = !flag27;
					if (obj67 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int playerId = playerRef.PlayerId;
					string text3 = num11.ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F60]");
					object obj68 = 0;
					string text4 = (string)obj68 + text3;
					arg2 = text4;
				}
				string text5 = string.Format((string)format2, arg3, arg4, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				if ((object)runner != null)
				{
					PlayerRef localPlayer = runner.LocalPlayer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj69 = 0;
					object obj70 = obj69;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X8_v25+E4]");
					bool flag28 = (nint)0 == 0;
					object obj71 = !flag28;
					if (obj71 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int playerId2 = playerRef3.PlayerId;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					SessionInfo sessionInfo = runner.SessionInfo__BackingField;
					if (runner.SessionInfo__BackingField != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCCE0]");
						object format3 = 0;
						string text6 = string.Format((string)format3, arg5, arg6, sessionInfo.Name__BackingField);
						string message2 = text5 + text6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj72 = 0;
						object obj73 = obj72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v32+E4]");
						bool flag29 = (nint)0 == 0;
						object obj74 = !flag29;
						if (obj74 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogWarning(message2);
						return;
					}
				}
			}
			goto IL_0ee9;
			IL_0a97:
			array = spawns;
			num6++;
			bool flag30 = spawns == null;
			object obj75 = !flag30;
			System.__Canon _Canon = (System.__Canon)num7;
			if (obj75 != null)
			{
				continue;
			}
			goto IL_0ee9;
			IL_111d:
			bool flag31 = dictionary.Remove(num6);
			num7 = num6;
			goto IL_0a97;
		}
		goto IL_0ef7;
		IL_0ee9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ef7;
	}

	private unsafe static int Rank(NetworkRunner runner)
	{
		//IL_0010: Expected VT, but got I
		//IL_080f: Expected Obj, but got I4
		//IL_0818: Expected VT, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_003a: Expected VT, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_00c9: Expected VT, but got I4
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0909: Expected VT, but got Ref
		//IL_091a: Expected VT, but got I4
		//IL_0922: Expected VT, but got Ref
		//IL_013f: Expected Obj, but got I
		//IL_0848: Expected Obj, but got I4
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected I4, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected I4, but got Unknown
		//IL_0274: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_028e: Expected VT, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0bc5: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected I4, but got Unknown
		//IL_01c3: Expected I4, but got Obj
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_040c: Expected Obj, but got I4
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I
		//IL_06b6: Expected VT, but got Ref
		//IL_0952: Expected Obj, but got I4
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected I4, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected I4, but got Unknown
		//IL_0462: Expected VT, but got Ref
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0702: Expected Obj, but got I
		//IL_0712: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected I4, but got Unknown
		//IL_039f: Expected I4, but got Obj
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_07a1: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I4
		//IL_0a6b: Expected Obj, but got I
		//IL_0a8d: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got I
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_05d9: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected I4, but got Unknown
		//IL_065e: Expected Obj, but got I4
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected Obj, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_0abf: Expected VT, but got Ref
		//IL_0ad4: Expected I, but got Obj
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE255]");
		PlayerRef playerRef = (PlayerRef)0;
		bool flag = (object)runner == null;
		object obj = 0;
		PlayerRef playerRef2 = (PlayerRef)0;
		object obj2;
		int playerId;
		object obj5;
		nint num;
		bool flag4 = default;
		bool flag8 = default;
		int num5 = default;
		int num4 = default;
		int num3 = default;
		bool flag7 = default;
		bool flag6 = default;
		object obj8 = default;
		object obj7 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj2 = 0;
			PlayerRef localPlayer = runner.LocalPlayer;
			playerRef = (PlayerRef)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5 (Fusion.PlayerRef)+E4]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5 (Fusion.PlayerRef)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef3 = default;
			playerId = playerRef3.PlayerId;
			IEnumerable<PlayerRef> activePlayers = runner.ActivePlayers;
			flag = activePlayers == null;
			obj = 0;
			playerRef2 = (PlayerRef)0;
			num = unchecked((nint)null);
			if (!flag)
			{
				nint num2 = (nint)activePlayers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDF0]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_021d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+98]");
				object obj6 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v33-8]");
					bool flag5 = 0 < (nint)obj5;
					obj7 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v33-8]");
					obj8 = 0 - obj5;
					flag6 = (nint)obj8 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v33-8]");
					flag7 = 0 == (nint)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v33-8]");
					num3 = 0 ^ obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v33-8]");
					num4 = 0 ^ obj8;
					num5 = num3 & num4;
					flag8 = num5 < 0;
					if (flag7)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
					obj3 = -1;
					bool flag9 = (nint)obj3 < 1;
					obj7 = !flag9;
					obj8 = obj3 - 1;
					flag6 = (nint)obj8 < 0;
					flag7 = obj8 == null;
					num3 = obj3 ^ 1;
					num4 = obj3 ^ obj8;
					num5 = num3 & num4;
					flag8 = num5 < 0;
					obj5 = obj6 + 16;
					flag4 = (nint)obj3 != 1;
					flag3 = flag4;
					obj6 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_021d;
				}
				obj3 = obj6;
				object obj9 = num2 + obj6;
				object obj10 = obj9 + 312;
				flag4 = flag3;
				obj5 = obj6;
				goto IL_08d6;
			}
		}
		goto IL_069b;
		IL_069b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_067f;
		IL_067f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_068d;
		IL_068d:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_069b;
		IL_021d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_08d6;
		IL_08d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v16+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X0_v16] (should have been resolved before IL gen)");
		object obj11 = default;
		flag = obj11 == null;
		PlayerRef playerRef4 = (PlayerRef)(&obj);
		obj = obj11;
		playerRef2 = (PlayerRef)0;
		playerRef = (PlayerRef)(&obj);
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDF8]");
			object obj13 = 0;
			playerRef2 = (PlayerRef)0;
			object obj15 = default;
			object obj14 = obj15;
			object obj16 = obj11;
			object obj17 = 0;
			bool flag10 = flag4;
			bool flag11 = flag8;
			int num6 = num5;
			int num7 = num4;
			int num8 = num3;
			bool flag12 = flag7;
			bool flag13 = flag6;
			object obj18 = obj8;
			object obj19 = obj7;
			object obj20 = obj5;
			int num9 = 0;
			PlayerRef playerRef5 = default;
			object obj28 = default;
			int result = default;
			while (true)
			{
				object obj21 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13+98]");
				object obj22 = (nint)0 + (nint)8;
				bool flag14 = flag10;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v28-8]");
					bool flag15 = 0 < (nint)obj12;
					obj19 = !flag15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v28-8]");
					obj18 = 0 - obj12;
					flag13 = (nint)obj18 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v28-8]");
					flag12 = 0 == (nint)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v28-8]");
					num8 = 0 ^ obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X10_v28-8]");
					num7 = 0 ^ obj18;
					num6 = num8 & num7;
					flag11 = num6 < 0;
					if (flag12)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v13+12E]");
					obj3 = -1;
					bool flag16 = (nint)obj3 < 1;
					obj19 = !flag16;
					obj18 = obj3 - 1;
					flag13 = (nint)obj18 < 0;
					flag12 = obj18 == null;
					num8 = obj3 ^ 1;
					num7 = obj3 ^ obj18;
					num6 = num8 & num7;
					flag11 = num6 < 0;
					obj20 = obj22 + 16;
					flag10 = (nint)obj3 != 1;
					flag14 = flag10;
					obj22 = obj20;
					if (flag10)
					{
						continue;
					}
					goto IL_03f9;
				}
				obj3 = obj22;
				object obj23 = obj21 + obj22;
				object obj24 = obj23 + 312;
				flag10 = flag14;
				obj20 = obj22;
				goto IL_09e0;
				IL_0a49:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v613 @ X0_v41] (should have been resolved before IL gen)");
				object obj25 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v44+E4]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X0_v44+E4]");
				bool flag17 = (nint)0 == 0;
				object obj26 = !flag17;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int playerId2 = playerRef2.PlayerId;
				bool flag18 = playerId2 < playerId;
				obj7 = !flag18;
				obj8 = playerId2 - playerId;
				flag6 = (nint)obj8 < 0;
				flag7 = obj8 == null;
				num3 = playerId2 ^ playerId;
				num4 = playerId2 ^ obj8;
				num5 = num3 & num4;
				flag8 = num5 < 0;
				bool flag19 = flag6 == flag8;
				flag4 = !flag19;
				obj15 = !flag4;
				if (obj15 == null)
				{
					num9++;
				}
				bool flag20 = obj11 == null;
				flag = !flag20;
				playerRef4 = (PlayerRef)(&obj);
				obj = obj11;
				playerRef2 = playerRef5;
				num = unchecked((nint)null);
				playerRef2 = playerRef5;
				obj14 = obj15;
				obj16 = obj11;
				flag10 = flag4;
				flag11 = flag8;
				num6 = num5;
				num7 = num4;
				num8 = num3;
				flag12 = flag7;
				flag13 = flag6;
				obj18 = obj8;
				obj19 = obj7;
				if (flag)
				{
					continue;
				}
				goto IL_067f;
				IL_0b8e:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v35+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v626 @ X0_v35] (should have been resolved before IL gen)");
				goto IL_07d5;
				IL_078e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj17 = 0;
				goto IL_0b8e;
				IL_03f9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj17 = 0;
				goto IL_09e0;
				IL_09e0:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v20+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v429 @ X0_v20] (should have been resolved before IL gen)");
				object obj27 = obj28 & 1;
				if (obj27 != null)
				{
					flag = obj11 == null;
					playerRef4 = (PlayerRef)(&obj);
					obj = obj11;
					obj15 = obj14;
					flag4 = flag10;
					flag8 = flag11;
					num5 = num6;
					num4 = num7;
					num3 = num8;
					flag7 = flag12;
					flag6 = flag13;
					obj8 = obj18;
					obj7 = obj19;
					if (flag)
					{
						break;
					}
					object obj29 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v25+12E]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v25+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0564;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v25+98]");
					object obj31 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X10_v23-8]");
						if (0 == (nint)obj13)
						{
							break;
						}
						obj30--;
						obj20 = obj31 + 16;
						bool flag21 = (nint)obj30 != 1;
						obj31 = obj20;
						if (flag21)
						{
							continue;
						}
						goto IL_0564;
					}
					object obj32 = obj29 + obj31;
					object obj33 = obj32 + 312;
					obj20 = obj31;
					goto IL_0a49;
				}
				PlayerRef playerRef6 = (PlayerRef)(&obj);
				int raw = playerRef6.Raw;
				if (playerRef6.Raw != 0)
				{
					int value = ((int*)raw)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v21 (System.Int32)+12E]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v21 (System.Int32)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_078e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v21 (System.Int32)+98]");
					object obj36 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X10_v17-8]");
						if (0 == (nint)obj34)
						{
							break;
						}
						obj35--;
						obj36 += 16;
						if ((nint)obj35 != 1)
						{
							continue;
						}
						goto IL_078e;
					}
					object obj37 = value + obj36;
					object obj38 = obj37 + 312;
					goto IL_0b8e;
				}
				goto IL_07d5;
				IL_0564:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				obj17 = 0;
				goto IL_0a49;
				IL_07d5:
				OutOfMemoryException ex4 = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			goto IL_068d;
		}
		goto IL_067f;
	}

	public MonsterDirector()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6550]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCE08]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj6 = this + 32;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		backAfter = 120f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj8 = this + 48;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, int> dictionary = default;
		dictionary._002Ector();
		object obj9 = this + 56;
		obj9 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary2 = default;
		dictionary2._002Ector();
		object obj10 = this + 64;
		obj10 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary3 = default;
		dictionary3._002Ector();
		object obj11 = this + 72;
		obj11 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj12 = this + 80;
		obj12 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7138]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<int, float> dictionary4 = default;
		dictionary4._002Ector();
		object obj14 = this + 88;
		obj14 = dictionary4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static MonsterDirector()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBFF8]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D800]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, float> dictionary = default;
		dictionary._002Ector();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+A0]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
