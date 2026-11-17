using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public static class Sfx
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Dismemberment.Part> _003C_003E9__26_1;

		public static Predicate<SkinnedMeshRenderer> _003C_003E9__26_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFB20]");
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

		internal bool _003CYank_003Eb__26_1(Dismemberment.Part p)
		{
			//IL_00aa: Expected I4, but got Obj
			//IL_003d: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			if (p != null)
			{
				if (p.id != 0)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return p.renderer != null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool _003CYank_003Eb__26_0(SkinnedMeshRenderer r)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0146: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got I4
			//IL_011c: Expected I4, but got Obj
			//IL_00d8: Expected Obj, but got I4
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
			bool flag2 = r == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				if ((object)r == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				if (r.enabled)
				{
					Mesh sharedMesh = r.sharedMesh;
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return sharedMesh == null;
				}
			}
			return true;
		}
	}

	private const int MostAtOnce = default(int);

	private const int SameAtOnce = default(int);

	private const float Moment = default(float);

	private const float Near = default(float);

	private static readonly List<float> ending;

	private static readonly List<(AudioClip[], Vector3, float)> lately;

	private static void Fresh()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A0]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v1+1C]");
		object obj7 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+1C]");
		object obj8 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+18]");
			Array.Clear((Array)num, 0, 0);
		}
	}

	private unsafe static bool Room(AudioClip[] clips, Vector3 at, float now)
	{
		//IL_0010: Expected Obj, but got I
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_0592: Expected Obj, but got I
		//IL_05ad: Expected I, but got Obj
		//IL_05c5: Expected Obj, but got I4
		//IL_05cd: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_0327: Expected Obj, but got I4
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected I4, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_0626: Expected I, but got Obj
		//IL_0646: Expected Obj, but got I4
		//IL_064e: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_01af: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_0369: Expected Obj, but got I4
		//IL_06dc: Expected Obj, but got I
		//IL_0707: Expected Obj, but got I4
		//IL_0389: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got Ref
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Invalid comparison between Unknown and F8
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_04e4: Expected Obj, but got I4
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0459: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		bool flag = obj2 == null;
		object obj3 = null;
		object obj15;
		Enumerator<, > val;
		object obj26;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC48]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v28+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Predicate<float> predicate = default;
			predicate._002Ector(obj2, (IntPtr)obj7);
			bool flag3 = obj9 == null;
			object obj10 = 0;
			nint num = (nint)obj7;
			Predicate<float> predicate2 = predicate;
			obj3 = obj2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC28]");
				object obj11 = 0;
				num = (nint)obj11;
				int num2 = ((List<float>)obj9).RemoveAll(predicate);
				object obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+A0]");
				object obj13 = 0;
				object obj14 = obj13;
				bool flag4 = obj13 == null;
				obj10 = 0;
				predicate2 = predicate;
				obj3 = predicate;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v1+18]");
					if ((nint)0 > (nint)23)
					{
						obj15 = 0;
						goto IL_0696;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v33+E4]");
					bool flag5 = (nint)0 == 0;
					object obj16 = !flag5;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj17 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v32+A0]");
						obj13 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC38]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC50]");
					object obj18 = 0;
					Predicate<(System.__Canon, Vector3, float)> predicate3 = default;
					predicate3._002Ector(obj2, (IntPtr)obj18);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v20+8]");
					bool flag6 = (nint)0 == 0;
					obj10 = 0;
					num = (nint)obj18;
					predicate2 = (Predicate<float>)(object)predicate3;
					obj3 = obj2;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC30]");
						object obj19 = 0;
						num = (nint)obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v20+8]");
						int num3 = ((List<(System.__Canon, Vector3, float)>)0).RemoveAll(predicate3);
						object obj20 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v25+A0]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v26+8]");
						bool flag7 = (nint)0 == 0;
						obj10 = 0;
						predicate2 = (Predicate<float>)(object)predicate3;
						obj3 = predicate3;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v26+8]");
							Enumerator<, > enumerator = ((List<(System.__Canon, Vector3, float)>)0).GetEnumerator();
							object obj23 = default;
							object obj22 = obj23;
							val = (Enumerator<, >)0;
							object obj25 = default;
							object obj24 = obj25;
							obj26 = null;
							Enumerator<, > val2 = default;
							object obj27 = default;
							object obj29 = default;
							while (val2.MoveNext())
							{
								if (0 == (nint)clips)
								{
									obj22 = 0 - obj23;
									float num4 = (float)obj27 - now;
									object obj28 = obj29 - obj25;
									float num5 = num4 * num4;
									object obj30 = obj28 * obj28;
									float num6 = (float)obj30 + num5;
									obj24 = obj22 * obj22;
									val = (Enumerator<, >)(obj24 + num6);
									if ((double)val < 4.0)
									{
										obj26++;
									}
								}
							}
							object obj31 = 0;
							object obj32 = 0;
							Enumerator<, > val3 = (Enumerator<, >)(ref val2);
							obj10 = 0;
							Predicate<(System.__Canon, Vector3, float)> predicate4 = predicate3;
							object obj33 = 0;
							object obj34 = 5;
							bool result = default;
							object obj38 = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC08]");
								object obj35 = 0;
								obj3 = obj35;
								val2.Dispose();
								bool flag8 = obj33 == null;
								object obj36 = !flag8;
								predicate2 = (Predicate<float>)(object)predicate4;
								if (obj36 == null)
								{
									bool flag9 = obj31 == null;
									object obj37 = !flag9;
									OutOfMemoryException ex = (OutOfMemoryException)(&val2);
									if (obj37 == null)
									{
										break;
									}
								}
								else
								{
									OutOfMemoryException ex = new OutOfMemoryException();
									predicate4 = (Predicate<(System.__Canon, Vector3, float)>)(object)predicate2;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
								if ((nint)obj3 == 2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj31 = 1;
									obj33 = obj32;
								}
								else
								{
									if ((nint)obj3 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A06D0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
										return result;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj33 = obj38;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj32 = obj38;
								}
								obj34 = 0;
							}
							if ((nint)obj34 != 5)
							{
								bool flag10 = obj34 == null;
								object obj39 = !flag10;
								obj15 = obj31;
								if (obj39 != null)
								{
									goto IL_0696;
								}
							}
							object obj40 = obj26 - 2;
							bool flag11 = (nint)obj40 < 0;
							object obj41 = obj26 ^ 2;
							object obj42 = obj26 ^ obj40;
							object obj43 = obj41 & obj42;
							bool flag12 = (nint)obj43 < 0;
							bool flag13 = flag11 == flag12;
							object obj44 = !flag13;
							obj15 = obj44;
							goto IL_0696;
						}
					}
				}
			}
		}
		val = (Enumerator<, >)0;
		obj26 = obj2;
		throw new NullReferenceException();
		IL_0696:
		return (byte)(obj15 & 1) != 0;
	}

	public unsafe static void Play(AudioClip[] clips, Vector3 at, float volume, float pitchMin, float pitchMax)
	{
		//IL_0737: Expected VT, but got I4
		//IL_0070: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I4
		//IL_0192: Expected VT, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I
		//IL_0778: Expected Obj, but got I
		//IL_0788: Expected Obj, but got I
		//IL_079d: Expected VT, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		//IL_031a: Expected VT, but got Ref
		//IL_031a: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_0409: Expected VT, but got I4
		//IL_0419: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_050a: Expected Obj, but got I
		//IL_0538: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I
		//IL_057d: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I
		//IL_06e8: Expected Obj, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0664: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I4
		bool flag = GillaBackroomsSwitch.OnYourSide((Vector3)0);
		if (clips == null || !flag || clips.Length == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, clips.Length);
		bool flag2 = num < clips.Length;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = clips + num;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+20]");
			bool flag4 = (UnityEngine.Object)0 == null;
			bool flag5 = !flag4;
			object obj6 = !flag5;
			if (obj6 != null)
			{
				return;
			}
			float time = Time.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Room(clips, (Vector3)0, volume))
			{
				return;
			}
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v19+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAD8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v9+8]");
			List<(System.__Canon, Vector3, float)> list = (List<(System.__Canon, Vector3, float)>)0;
			(System.__Canon, Vector3, float) tuple = ((System.__Canon)(object)clips, (Vector3)obj13, volume);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v9+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+10]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+1C]");
				object obj15 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+18]");
					bool flag8 = num2 < 0;
					object obj16 = !flag8;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+18]");
						object obj17 = (nint)0 * (nint)24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+10]");
						object obj18 = 0 + obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X21_v4 (System.Collections.Generic.List`1<System.ValueTuple`3<System.__Canon, UnityEngine.Vector3, System.Single>>)+18]");
						object obj19 = (nint)0 + (nint)1;
						object obj20 = obj18 + 32;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj21 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v9+8]");
						object obj22 = default;
						((List<(System.__Canon, Vector3, float)>)0).AddWithResize(((System.__Canon, Vector3, float))(&obj22));
						object obj21 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+20]");
						string name = ((UnityEngine.Object)0).name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAE0]");
						object obj23 = 0;
						string name2 = (string)obj23 + name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						GameObject gameObject = default;
						gameObject._002Ector(name2);
						if ((object)gameObject != null)
						{
							Transform transform = gameObject.transform;
							if ((object)transform != null)
							{
								transform.position = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
								AudioSource audioSource = default;
								if ((object)audioSource != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+20]");
									audioSource.clip = (AudioClip)0;
									float volume2 = default;
									audioSource.volume = volume2;
									float minInclusive = default;
									float maxInclusive = default;
									float pitch = UnityEngine.Random.Range(minInclusive, maxInclusive);
									audioSource.pitch = pitch;
									audioSource.spatialBlend = 1f;
									audioSource.minDistance = 1f;
									audioSource.maxDistance = 25f;
									audioSource.rolloffMode = (AudioRolloffMode)1;
									audioSource.dopplerLevel = 0f;
									audioSource.Play();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+20]");
									float length = ((AudioClip)0).length;
									float pitch2 = audioSource.pitch;
									object obj26 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v21+A0]");
									object obj27 = 0;
									List<float> list2 = (List<float>)obj27;
									if (obj27 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73B0]");
										object obj28 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+10]");
										object obj29 = 0;
										object obj30 = obj28;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+1C]");
										object obj31 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+10]");
										if ((nint)0 != 0)
										{
											float num3 = length / pitch2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+18]");
											nint num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v23+18]");
											bool flag9 = num4 < 0;
											object obj32 = !flag9;
											float num5 = num3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											float num6 = num5 + 0f;
											float item = time + num6;
											if (obj32 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+10]");
												nint num7 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+18]");
												object obj33 = num7 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v45 (System.Collections.Generic.List`1<System.Single>)+18]");
												object obj34 = (nint)0 + (nint)1;
												object obj35 = 0;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X9_v14+20]");
												object obj36 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v26+A8]");
												object obj37 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v27+70]");
												object obj35 = 0;
												((List<float>)obj27).AddWithResize(item);
											}
											object obj38 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v46+E4]");
											bool flag10 = (nint)0 == 0;
											object obj39 = !flag10;
											if (obj39 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											UnityEngine.Object.Destroy(gameObject, num6);
											return;
										}
									}
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	static Sfx()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC58]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<float> list = default;
		list._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = list;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(System.__Canon, Vector3, float)> list2 = default;
		list2._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
