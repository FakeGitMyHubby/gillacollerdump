using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public static class Surfaces
{
	private static readonly Dictionary<Collider, SurfaceKind> known;

	private static readonly List<string> names;

	private static readonly int BaseMap;

	private static readonly Collider[] near;

	private static readonly (SurfaceKind, string[])[] Words;

	public static SurfaceKind KindOf(Collider c)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I
		//IL_018a: Expected I4, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
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
		if (c == null)
		{
			return (SurfaceKind)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+A0]");
		object obj7 = 0;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43E8]");
			object obj8 = 0;
			bool flag3 = ((Dictionary<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)obj7).TryGetValue((System.__Canon)(object)c, out Unity.IL2CPP.Metadata.__Il2CppInt32Enum _);
			bool flag4 = !flag3;
			object obj9 = !flag4;
			SurfaceKind surfaceKind = default;
			if (obj9 == null)
			{
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v16+A0]");
				object obj12 = 0;
				surfaceKind = Find(c);
				if (obj12 == null)
				{
					goto IL_017c;
				}
				((Dictionary<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum>)obj12).set_Item((System.__Canon)(object)c, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)surfaceKind);
			}
			return surfaceKind;
		}
		goto IL_017c;
		IL_017c:
		NullReferenceException ex = new NullReferenceException();
		return (SurfaceKind)ex;
	}

	public unsafe static Collider Under(Vector3 at, float radius, int layers)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I4
		//IL_04b0: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got VT
		//IL_005e: Expected VT, but got I
		//IL_008f: Expected Obj, but got I
		//IL_0099: Expected VT, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got VT
		//IL_00d9: Expected F4, but got I4
		//IL_050a: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_017e: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I4
		//IL_024a: Expected VT, but got I4
		//IL_024a: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_0374: Expected VT, but got F4
		//IL_037c: Expected VT, but got F4
		//IL_038d: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v1+18]");
		int num = Physics.OverlapSphereNonAlloc((Vector3)0, radius, (Collider[])at, 1, (QueryTriggerInteraction)0);
		Collider result;
		if (num >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4370]");
			object obj8 = 0;
			Bounds bounds = (Bounds)0;
			object obj9 = 0;
			int num2 = 1;
			Collider[] array = (Collider[])at;
			object obj11 = default;
			object obj10 = obj11;
			object obj13 = default;
			object obj12 = obj13;
			float num3 = radius;
			result = null;
			float num4 = 2.139095E+09f;
			Vector3 point = default;
			float num8 = default;
			bool flag6;
			do
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj14 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v11+A0]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
				float num9;
				if ((nint)0 != 0)
				{
					object obj18 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10+18]");
					bool flag4 = (nint)obj18 < 0;
					object obj19 = !flag4;
					if (obj19 != null)
					{
						goto IL_03b2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9+18]");
					object obj20 = 0 + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v13+20]");
					Collider collider = (Collider)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v13+20]");
					if ((nint)0 != 0)
					{
						object obj21 = obj8;
						nint num5 = (nint)collider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v7 (Il2CppClass<UnityEngine.Collider>)+130]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v14+130]");
						bool flag5 = num6 < 0;
						object obj22 = !flag5;
						object obj23 = ~obj22;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v7 (Il2CppClass<UnityEngine.Collider>)+B0]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v14+130]");
							object obj24 = num7 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v11-8]");
							if (0 == (nint)obj21)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v13+20]");
								if (!((MeshCollider)0).convex)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v13+20]");
									Bounds bounds2 = ((Collider)0).bounds;
									Vector3 vector = bounds.Internal_ClosestPoint(ref point);
									bounds = (Bounds)num8;
									point = (Vector3)radius;
									num2 = 0;
									array = (Collider[])(&point);
									num9 = num8;
									goto IL_0270;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v13+20]");
						Vector3 vector2 = ((Collider)0).ClosestPoint((Vector3)0);
						array = null;
						obj10 = obj11;
						obj12 = obj13;
						num9 = radius;
						goto IL_0270;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_03b2;
				IL_03b2:
				return (Collider)(object)new IndexOutOfRangeException();
				IL_0270:
				float num10 = num9 - radius;
				object obj25 = obj12 - obj13;
				obj9++;
				obj10 -= obj11;
				float num11 = num10 * num10;
				object obj26 = obj25 * obj25;
				float num12 = num11 + (float)obj26;
				obj12 = obj10 * obj10;
				num3 = (float)obj12 + num12;
				float num13 = ((!(num3 < num4)) ? num4 : num3);
				if (num3 < num4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v13+20]");
					result = (Collider)0;
				}
				flag6 = num != (nint)obj9;
				num4 = num13;
			}
			while (flag6);
		}
		else
		{
			result = null;
		}
		return result;
	}

	public static bool Play(AudioSource src, Collider surface, float loud, float pitchMin = default(float), float pitchMax = default(float))
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_02c2: Expected I4, but got Obj
		//IL_00f8: Expected I4, but got Obj
		//IL_0183: Expected Obj, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		GillaSounds gillaSounds = GillaSounds.Get();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool result;
		if (gillaSounds != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SurfaceKind kind = KindOf(surface);
			if ((object)gillaSounds == null)
			{
				goto IL_02a6;
			}
			ReverbProbe.SurfaceSet surfaceSet = gillaSounds.For(kind);
			bool flag3 = surfaceSet == null;
			result = (byte)(int)surfaceSet != 0;
			if (flag3)
			{
				goto IL_0303;
			}
			AudioClip[] clips = surfaceSet.clips;
			if (surfaceSet.clips != null && clips.Length != 0)
			{
				int num = UnityEngine.Random.Range(0, clips.Length);
				bool flag4 = num < clips.Length;
				object obj7 = !flag4;
				if (obj7 != null)
				{
					goto IL_02b4;
				}
				object obj8 = obj;
				object obj9 = surfaceSet.clips + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v21+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12+20]");
				if (!((UnityEngine.Object)0 == null))
				{
					float pitch = UnityEngine.Random.Range(pitchMin, pitchMax);
					AudioSource audioSource = default;
					if ((object)audioSource == null)
					{
						goto IL_02a6;
					}
					audioSource.pitch = pitch;
					float volumeScale = surfaceSet.volume * loud;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12+20]");
					audioSource.PlayOneShot((AudioClip)0, volumeScale);
					result = true;
					goto IL_0303;
				}
			}
		}
		result = false;
		goto IL_0303;
		IL_02b4:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_02a6:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02b4;
		IL_0303:
		return result;
	}

	private unsafe static SurfaceKind Find(Collider c)
	{
		//IL_10e7: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_110a: Expected Obj, but got I
		//IL_111a: Expected Obj, but got I
		//IL_113a: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_046c: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_11cf: Expected Obj, but got I4
		//IL_115d: Expected Obj, but got I
		//IL_116d: Expected Obj, but got I
		//IL_1192: Expected Obj, but got I4
		//IL_04d1: Expected Obj, but got I
		//IL_1207: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_0593: Expected Obj, but got I4
		//IL_053f: Expected Obj, but got I
		//IL_0c57: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I4
		//IL_1349: Expected Obj, but got I
		//IL_1359: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I4
		//IL_05f6: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_0cb1: Expected Obj, but got I
		//IL_0ccb: Expected Obj, but got I8
		//IL_0cd4: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_1425: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I8
		//IL_065a: Expected Obj, but got I
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0671: Expected Obj, but got I4
		//IL_067a: Expected Obj, but got I4
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_0d0f: Expected Obj, but got I
		//IL_0d31: Expected Obj, but got I4
		//IL_131b: Expected Obj, but got I4
		//IL_138e: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I4
		//IL_0d68: Expected Obj, but got I
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I4
		//IL_0704: Expected Obj, but got I4
		//IL_0bf1: Expected Obj, but got I4
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected Obj, but got Unknown
		//IL_0fdf: Expected Obj, but got I4
		//IL_0fe8: Expected Obj, but got I4
		//IL_0741: Expected Obj, but got I4
		//IL_1443: Expected Obj, but got I
		//IL_146e: Expected Obj, but got I4
		//IL_146e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1235: Expected Obj, but got I4
		//IL_103a: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Expected Obj, but got Ref
		//IL_0776: Expected Obj, but got I
		//IL_0786: Expected Obj, but got I
		//IL_0797: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I4
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected I4, but got Obj
		//IL_0820: Expected Obj, but got I4
		//IL_0e13: Expected Obj, but got I8
		//IL_0e1c: Expected Obj, but got I4
		//IL_0855: Expected Obj, but got I4
		//IL_13fe: Expected Obj, but got I4
		//IL_08d6: Expected Obj, but got I
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected Obj, but got I
		//IL_0920: Expected Obj, but got I
		//IL_0941: Expected Obj, but got I4
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_1272: Expected Obj, but got I4
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got I4
		//IL_0979: Expected Obj, but got I4
		//IL_0e58: Expected Obj, but got I
		//IL_0e76: Expected Obj, but got I4
		//IL_1290: Expected Obj, but got I
		//IL_12bd: Expected Obj, but got I
		//IL_12d2: Expected Obj, but got I4
		//IL_0ef6: Expected Obj, but got I4
		//IL_0eff: Expected Obj, but got I4
		//IL_0f18: Expected Obj, but got I4
		//IL_0a10: Expected Obj, but got I4
		//IL_0e94: Expected Obj, but got I
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected Obj, but got Unknown
		//IL_0ec1: Expected Obj, but got I4
		//IL_0ed1: Expected Obj, but got I
		//IL_12ef: Expected Obj, but got I4
		//IL_0ee8: Expected Obj, but got I4
		//IL_0a45: Expected Obj, but got I
		//IL_0a55: Expected Obj, but got I
		//IL_0a82: Expected Obj, but got I4
		//IL_0aaa: Expected I4, but got Obj
		//IL_0ae7: Expected Obj, but got I4
		//IL_0b1a: Expected Obj, but got I4
		//IL_0ba5: Expected Obj, but got I
		//IL_0bb5: Expected Obj, but got I
		//IL_0bc5: Expected Obj, but got I
		//IL_0bda: Expected Obj, but got I
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_0b88: Expected Obj, but got I4
		bool flag = (object)c == null;
		IntPtr intPtr = default;
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		object obj3;
		object obj8;
		object obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4400]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj6 = default;
			if (obj6 != null)
			{
				bool flag3 = (object)obj6 == null;
				obj7 = 0;
				obj = null;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v18 (UnityEngine.Object)+20]");
					return (SurfaceKind)0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
				obj8 = 0;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v25+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v25+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v13+8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v13+8]");
				bool flag5 = (nint)0 == 0;
				obj7 = 0;
				obj = null;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14+1C]");
					object obj13 = (nint)0 + (nint)1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14+10]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v14+18]");
						Array.Clear((Array)num, 0, 0);
					}
					PhysicsMaterial sharedMaterial = c.sharedMaterial;
					object obj14 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v15+E4]");
					bool flag6 = (nint)0 == 0;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag7 = sharedMaterial != null;
					bool flag8 = !flag7;
					object obj16 = 0;
					if (flag8)
					{
						goto IL_0418;
					}
					object obj17 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v128+E4]");
					bool flag9 = (nint)0 == 0;
					object obj18 = !flag9;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v128+A0]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v75+8]");
					List<System.__Canon> list = (List<System.__Canon>)0;
					PhysicsMaterial sharedMaterial2 = c.sharedMaterial;
					bool flag10 = (object)sharedMaterial2 == null;
					obj7 = 0;
					obj = null;
					if (!flag10)
					{
						string name = sharedMaterial2.name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v75+8]");
						bool flag11 = (nint)0 == 0;
						obj7 = 0;
						obj = null;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
							object obj20 = 0;
							System.__Canon[] items = list._items;
							object obj21 = obj20;
							int version = list._version + 1;
							list._version = version;
							bool flag12 = list._items == null;
							obj7 = 0;
							obj = null;
							if (!flag12)
							{
								bool flag13 = list._size < items.Length;
								object obj22 = !flag13;
								if (obj22 == null)
								{
									object obj23 = list._items + list._size;
									int size = list._size + 1;
									list._size = size;
									object obj24 = obj23 + 32;
									obj24 = name;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj16 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v26+20]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v77+A8]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v78+70]");
									obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v75+8]");
									((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)name);
								}
								goto IL_0418;
							}
						}
					}
				}
			}
		}
		goto IL_1090;
		IL_109e:
		throw new IndexOutOfRangeException();
		IL_0418:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4410]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v19+E4]");
		int num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v19+E4]");
		bool flag14 = (nint)0 == 0;
		object obj29 = !flag14;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj30 = default;
		bool flag15 = obj30 == null;
		bool flag16 = !flag15;
		UnityEngine.Object obj31 = null;
		UnityEngine.Object obj32 = obj30;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4408]");
			object obj33 = 0;
			obj31 = (UnityEngine.Object)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
			UnityEngine.Object obj34 = default;
			obj32 = obj34;
		}
		object obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X0_v39+E4]");
		bool flag17 = (nint)0 == 0;
		object obj36 = !flag17;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag18 = obj32 == null;
		bool flag19 = !flag18;
		UnityEngine.Object obj37 = null;
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43F8]");
			object obj38 = 0;
			obj37 = (UnityEngine.Object)obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
			UnityEngine.Object obj39 = default;
			obj32 = obj39;
		}
		object obj40 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v44+E4]");
		bool flag20 = (nint)0 == 0;
		object obj41 = !flag20;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag21 = obj32 != null;
		bool flag22 = !flag21;
		obj7 = 0;
		obj = null;
		if (flag22)
		{
			goto IL_0c2d;
		}
		bool flag23 = (object)obj32 == null;
		obj7 = 0;
		obj = null;
		if (!flag23)
		{
			Material[] sharedMaterials = ((Renderer)obj32).sharedMaterials;
			bool flag24 = sharedMaterials == null;
			obj7 = 0;
			obj = null;
			if (!flag24)
			{
				bool flag25 = sharedMaterials.Length < 1;
				obj7 = 0;
				obj = null;
				if (flag25)
				{
					goto IL_0c2d;
				}
				object obj42 = sharedMaterials.Length & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
				object obj43 = 0;
				object obj44 = sharedMaterials + 32;
				object obj45 = 0;
				object obj46 = 0;
				UnityEngine.Object obj47 = null;
				while (true)
				{
					bool flag26 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
					object obj48 = !flag26;
					obj7 = obj46;
					obj = obj47;
					if (obj48 != null)
					{
						break;
					}
					object obj49 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X0_v78+E4]");
					bool flag27 = (nint)0 == 0;
					object obj50 = !flag27;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X26_v12+v98 @ X24_v16*8]");
					bool flag28 = (UnityEngine.Object)0 == null;
					bool flag29 = !flag28;
					object obj51 = !flag29;
					obj7 = 0;
					obj = null;
					if (obj51 != null)
					{
						goto IL_0be7;
					}
					object obj52 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v84+E4]");
					bool flag30 = (nint)0 == 0;
					object obj53 = !flag30;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj52 = obj8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X26_v12+v98 @ X24_v16*8]");
					bool flag31 = (nint)0 == 0;
					obj7 = 0;
					obj = null;
					if (!flag31)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v84+A0]");
						object obj54 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v54+8]");
						List<System.__Canon> list2 = (List<System.__Canon>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X26_v12+v98 @ X24_v16*8]");
						string name2 = ((UnityEngine.Object)0).name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v54+8]");
						bool flag32 = (nint)0 == 0;
						obj7 = 0;
						obj = null;
						if (!flag32)
						{
							System.__Canon[] items2 = list2._items;
							num2 = (int)obj43;
							int version2 = list2._version + 1;
							list2._version = version2;
							bool flag33 = list2._items == null;
							obj7 = 0;
							obj = null;
							if (!flag33)
							{
								bool flag34 = list2._size < items2.Length;
								object obj55 = !flag34;
								if (obj55 == null)
								{
									object obj56 = list2._items + list2._size;
									num2 = list2._size + 1;
									list2._size = num2;
									object obj57 = obj56 + 32;
									obj57 = name2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v54+8]");
									((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)name2);
								}
								object obj58 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v57+A0]");
								object obj59 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v58+10]");
								int num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X26_v12+v98 @ X24_v16*8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v58+10]");
								bool flag35 = ((Material)num4).HasProperty(0);
								bool flag36 = !flag35;
								UnityEngine.Object obj60 = null;
								object obj61 = 0;
								if (!flag36)
								{
									object obj62 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v107+E4]");
									bool flag37 = (nint)0 == 0;
									object obj63 = !flag37;
									if (obj63 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj62 = obj8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v107+A0]");
									object obj64 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v67+10]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X26_v12+v98 @ X24_v16*8]");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X8_v67+10]");
									Texture texture = ((Material)num5).GetTexture(0);
									obj60 = texture;
									obj61 = 0;
								}
								object obj65 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X0_v91+E4]");
								bool flag38 = (nint)0 == 0;
								object obj66 = !flag38;
								if (obj66 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag39 = obj60 != null;
								bool flag40 = !flag39;
								obj7 = 0;
								obj = null;
								if (flag40)
								{
									goto IL_0be7;
								}
								object obj67 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v96+E4]");
								bool flag41 = (nint)0 == 0;
								object obj68 = !flag41;
								if (obj68 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj67 = obj8;
								}
								bool flag42 = (object)obj60 == null;
								obj7 = 0;
								obj = null;
								if (!flag42)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v96+A0]");
									object obj69 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v62+8]");
									List<System.__Canon> list3 = (List<System.__Canon>)0;
									string name3 = obj60.name;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v62+8]");
									bool flag43 = (nint)0 == 0;
									obj7 = 0;
									obj = null;
									if (!flag43)
									{
										System.__Canon[] items3 = list3._items;
										num2 = (int)obj43;
										int version3 = list3._version + 1;
										list3._version = version3;
										bool flag44 = list3._items == null;
										obj7 = 0;
										obj = null;
										if (!flag44)
										{
											bool flag45 = list3._size < items3.Length;
											object obj70 = !flag45;
											if (obj70 == null)
											{
												object obj71 = list3._items + list3._size;
												num2 = list3._size + 1;
												list3._size = num2;
												object obj72 = obj71 + 32;
												obj72 = name3;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												obj7 = 0;
												obj = (UnityEngine.Object)(object)name3;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X9_v18 (System.Int32)+20]");
												object obj73 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v64+A8]");
												object obj74 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v65+70]");
												obj7 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v62+8]");
												((List<System.__Canon>)0).AddWithResize((System.__Canon)(object)name3);
												obj = (UnityEngine.Object)(object)name3;
											}
											goto IL_0be7;
										}
									}
								}
							}
						}
					}
					goto IL_1090;
					IL_0be7:
					obj42 = sharedMaterials.Length;
					obj45++;
					bool flag46 = (nint)obj45 < sharedMaterials.Length;
					obj46 = obj7;
					obj47 = obj;
					if (flag46)
					{
						continue;
					}
					goto IL_0c2d;
				}
				goto IL_109e;
			}
		}
		goto IL_1090;
		IL_0c2d:
		object obj75 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v50+E4]");
		bool flag47 = (nint)0 == 0;
		object obj76 = !flag47;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj75 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v50+A0]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v26+20]");
		object obj78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v26+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v9+18]");
			if ((nint)0 < (nint)1)
			{
				return (SurfaceKind)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X21_v9+18]");
			object obj80 = 0 & 0xFFFFFFFFL;
			object obj81 = 0;
			SurfaceKind surfaceKind = (SurfaceKind)0;
			bool flag48 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj81) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj80);
			object obj82 = !flag48;
			if (obj82 != null)
			{
				goto IL_109e;
			}
			object obj83 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v26+20]");
			object obj84 = 0 + obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v31+28]");
			object obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v54+E4]");
			bool flag49 = (nint)0 == 0;
			object obj86 = !flag49;
			if (obj86 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj83 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v54+A0]");
			object obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v32+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v32+8]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v31+28]");
				object obj88 = (nint)0 + (nint)32;
				Enumerator<, > val = default;
				Enumerator<, > val3 = default;
				while (true)
				{
					obj = (UnityEngine.Object)obj79;
					Enumerator<, > val2;
					Enumerator<, > val4;
					IndexOutOfRangeException ex;
					if (val.MoveNext())
					{
						if (false)
						{
							string text = ((string)null).ToLowerInvariant();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v31+28]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X28_v10+18]");
								if ((nint)0 < (nint)1)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X28_v10+18]");
								object obj89 = 0 & 0xFFFFFFFFL;
								object obj44 = 0;
								obj = null;
								while (true)
								{
									bool flag50 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj89);
									object obj90 = !flag50;
									if (obj90 != null)
									{
										break;
									}
									if (text != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X24_v11+v361 @ X26_v12*8]");
										bool flag51 = text.Contains((string)0);
										bool flag52 = !flag51;
										object obj91 = !flag52;
										if (obj91 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X28_v10+18]");
											obj89 = 0;
											obj44++;
											object obj92 = obj44;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X28_v10+18]");
											bool flag53 = (nint)obj92 < 0;
											obj7 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X24_v11+v361 @ X26_v12*8]");
											obj = (UnityEngine.Object)0;
											if (flag53)
											{
												continue;
											}
											goto IL_0edf;
										}
										goto IL_0eed;
									}
									goto IL_100b;
								}
								ex = new IndexOutOfRangeException();
								val2 = val3;
								val4 = (Enumerator<, >)(ref val);
								break;
							}
							NullReferenceException ex2 = new NullReferenceException();
							val2 = val3;
							val4 = (Enumerator<, >)(ref val);
							obj = null;
							ex = (IndexOutOfRangeException)(object)ex2;
							break;
						}
						NullReferenceException ex3 = new NullReferenceException();
						val2 = val3;
						val4 = (Enumerator<, >)(ref val);
						ex = (IndexOutOfRangeException)(object)ex3;
						break;
					}
					object obj93 = 20;
					object obj94 = 0;
					goto IL_1433;
					IL_0edf:
					obj7 = 0;
					continue;
					IL_0eed:
					obj93 = 19;
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v31+20]");
					surfaceKind = (SurfaceKind)0;
					obj94 = 0;
					goto IL_1433;
					IL_1433:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4418]");
					object obj95 = 0;
					obj = (UnityEngine.Object)obj95;
					val.Dispose();
					bool flag54 = obj94 == null;
					object obj96 = !flag54;
					val2 = val3;
					val4 = (Enumerator<, >)(ref val);
					if (obj96 == null)
					{
						val2 = val3;
						val4 = (Enumerator<, >)(ref val);
						OutOfMemoryException ex4 = (OutOfMemoryException)(&val);
					}
					else
					{
						OutOfMemoryException ex4 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					break;
					IL_100b:
					NullReferenceException ex5 = new NullReferenceException();
					val2 = val3;
					val4 = (Enumerator<, >)(ref val);
					ex = (IndexOutOfRangeException)(object)ex5;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE0C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				SurfaceKind result = default;
				return result;
			}
		}
		goto IL_1090;
		IL_1090:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_109e;
	}

	static Surfaces()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_1716: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I8
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I8
		//IL_0317: Expected Obj, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got I4
		//IL_036f: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03b2: Expected Obj, but got I
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03ec: Expected Obj, but got I8
		//IL_0419: Expected Obj, but got I
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_046a: Expected Obj, but got I8
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04e9: Expected Obj, but got I
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I8
		//IL_0550: Expected Obj, but got I
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_0592: Expected Obj, but got I4
		//IL_05a8: Expected Obj, but got I
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_05eb: Expected Obj, but got I
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_0625: Expected Obj, but got I8
		//IL_0652: Expected Obj, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0694: Expected Obj, but got I4
		//IL_06aa: Expected Obj, but got I
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_06ed: Expected Obj, but got I
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_072f: Expected Obj, but got I4
		//IL_0745: Expected Obj, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected Obj, but got Unknown
		//IL_0788: Expected Obj, but got I
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_07ca: Expected Obj, but got I4
		//IL_07e0: Expected Obj, but got I
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_0823: Expected Obj, but got I
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_085d: Expected Obj, but got I8
		//IL_088a: Expected Obj, but got I
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected Obj, but got Unknown
		//IL_08cc: Expected Obj, but got I4
		//IL_08e2: Expected Obj, but got I
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected Obj, but got Unknown
		//IL_0925: Expected Obj, but got I
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected Obj, but got Unknown
		//IL_0967: Expected Obj, but got I4
		//IL_097d: Expected Obj, but got I
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_09c0: Expected Obj, but got I
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected Obj, but got Unknown
		//IL_0a19: Expected Obj, but got I4
		//IL_0a2f: Expected Obj, but got I
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Expected Obj, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected Obj, but got Unknown
		//IL_0ac4: Expected Obj, but got I
		//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected Obj, but got Unknown
		//IL_0afe: Expected Obj, but got I8
		//IL_0b2b: Expected Obj, but got I
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected Obj, but got Unknown
		//IL_0b6d: Expected Obj, but got I4
		//IL_0b83: Expected Obj, but got I
		//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Expected Obj, but got Unknown
		//IL_0bc6: Expected Obj, but got I
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected Obj, but got Unknown
		//IL_0c00: Expected Obj, but got I8
		//IL_0c2d: Expected Obj, but got I
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got I4
		//IL_0c85: Expected Obj, but got I
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Unknown
		//IL_0cc8: Expected Obj, but got I
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected Obj, but got Unknown
		//IL_0d0a: Expected Obj, but got I4
		//IL_0d20: Expected Obj, but got I
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected Obj, but got Unknown
		//IL_0d63: Expected Obj, but got I
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected Obj, but got Unknown
		//IL_0db4: Expected Obj, but got I8
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected Obj, but got Unknown
		//IL_0e33: Expected Obj, but got I
		//IL_0e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected Obj, but got Unknown
		//IL_0e6d: Expected Obj, but got I8
		//IL_0e9a: Expected Obj, but got I
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected Obj, but got Unknown
		//IL_0edc: Expected Obj, but got I4
		//IL_0ef2: Expected Obj, but got I
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected Obj, but got Unknown
		//IL_0f35: Expected Obj, but got I
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected Obj, but got Unknown
		//IL_0f6f: Expected Obj, but got I8
		//IL_0f9c: Expected Obj, but got I
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected Obj, but got Unknown
		//IL_0fde: Expected Obj, but got I4
		//IL_0ff4: Expected Obj, but got I
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_1019: Expected Obj, but got Unknown
		//IL_1037: Expected Obj, but got I
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Expected Obj, but got Unknown
		//IL_1079: Expected Obj, but got I4
		//IL_108f: Expected Obj, but got I
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected Obj, but got Unknown
		//IL_10d2: Expected Obj, but got I
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected Obj, but got Unknown
		//IL_1114: Expected Obj, but got I4
		//IL_112a: Expected Obj, but got I
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected Obj, but got Unknown
		//IL_116d: Expected Obj, but got I
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Expected Obj, but got Unknown
		//IL_11c6: Expected Obj, but got I4
		//IL_11dc: Expected Obj, but got I
		//IL_11fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1201: Expected Obj, but got Unknown
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected Obj, but got Unknown
		//IL_1271: Expected Obj, but got I
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f: Expected Obj, but got Unknown
		//IL_12ab: Expected Obj, but got I8
		//IL_12d8: Expected Obj, but got I
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e6: Expected Obj, but got Unknown
		//IL_1331: Expected Obj, but got I4
		//IL_1347: Expected Obj, but got I
		//IL_1367: Unknown result type (might be due to invalid IL or missing references)
		//IL_136c: Expected Obj, but got Unknown
		//IL_1383: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Expected Obj, but got Unknown
		//IL_13dc: Expected Obj, but got I
		//IL_13e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ea: Expected Obj, but got Unknown
		//IL_1416: Expected Obj, but got I8
		//IL_1443: Expected Obj, but got I
		//IL_144c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1451: Expected Obj, but got Unknown
		//IL_1485: Expected Obj, but got I4
		//IL_149b: Expected Obj, but got I
		//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Expected Obj, but got Unknown
		//IL_14de: Expected Obj, but got I
		//IL_14e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ec: Expected Obj, but got Unknown
		//IL_1518: Expected Obj, but got I8
		//IL_1545: Expected Obj, but got I
		//IL_154e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1553: Expected Obj, but got Unknown
		//IL_1587: Expected Obj, but got I4
		//IL_159d: Expected Obj, but got I
		//IL_15bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c2: Expected Obj, but got Unknown
		//IL_15e0: Expected Obj, but got I
		//IL_15e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ee: Expected Obj, but got Unknown
		//IL_1639: Expected Obj, but got I4
		//IL_164f: Expected Obj, but got I
		//IL_166f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1674: Expected Obj, but got Unknown
		//IL_168b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Expected Obj, but got Unknown
		//IL_16be: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4448]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4368]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object name = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4478]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> dictionary = default;
		dictionary._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+A0]");
		object obj8 = 0;
		obj8 = dictionary;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+A0]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int num = Shader.PropertyToID((string)name);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v7+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+A0]");
		object obj15 = (nint)0 + (nint)24;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v20 (System.__Canon)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4548]");
			object obj17 = 0;
			System.__Canon _Canon = default;
			object obj18 = _Canon + 32;
			obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X21_v6-8]");
			object obj19 = 0 & 0xFFFFFFFEL;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4500]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4488]");
				object obj21 = 0;
				object obj22 = _Canon + 40;
				obj22 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)3, _Canon);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
				if ((nint)0 != 0)
				{
					object obj24 = default;
					object obj23 = obj24 + 40;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v34 (System.__Canon)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4560]");
						object obj25 = 0;
						System.__Canon _Canon2 = default;
						object obj26 = _Canon2 + 32;
						obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X21_v8-8]");
						object obj27 = 0 & 0xFFFFFFFEL;
						if (obj27 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4570]");
							object obj28 = 0;
							object obj29 = _Canon2 + 40;
							obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X21_v10-10]");
							bool flag = (nint)0 < (nint)2;
							object obj30 = !flag;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X21_v10-10]");
							object obj31 = -2;
							bool flag2 = obj31 == null;
							object obj32 = ~obj30;
							object obj33 = obj32 | flag2;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44F8]");
								object obj34 = 0;
								object obj35 = _Canon2 + 48;
								obj35 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X21_v12-18]");
								object obj36 = 0 & 0xFFFFFFFCL;
								if (obj36 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4518]");
									object obj37 = 0;
									object obj38 = _Canon2 + 56;
									obj38 = obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple2 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)2, _Canon2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
									object obj39 = 0 & 0xFFFFFFFEL;
									if (obj39 != null)
									{
										object obj40 = obj24 + 56;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v48 (System.__Canon)+18]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45A0]");
											object obj41 = 0;
											System.__Canon _Canon3 = default;
											object obj42 = _Canon3 + 32;
											obj42 = obj41;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X21_v14-8]");
											object obj43 = 0 & 0xFFFFFFFEL;
											if (obj43 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4590]");
												object obj44 = 0;
												object obj45 = _Canon3 + 40;
												obj45 = obj44;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X21_v16-10]");
												bool flag3 = (nint)0 < (nint)2;
												object obj46 = !flag3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X21_v16-10]");
												object obj47 = -2;
												bool flag4 = obj47 == null;
												object obj48 = ~obj46;
												object obj49 = obj48 | flag4;
												if (obj49 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4558]");
													object obj50 = 0;
													object obj51 = _Canon3 + 48;
													obj51 = obj50;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X21_v18-18]");
													object obj52 = 0 & 0xFFFFFFFCL;
													if (obj52 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4530]");
														object obj53 = 0;
														object obj54 = _Canon3 + 56;
														obj54 = obj53;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X21_v20-20]");
														bool flag5 = (nint)0 < (nint)4;
														object obj55 = !flag5;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X21_v20-20]");
														object obj56 = -4;
														bool flag6 = obj56 == null;
														object obj57 = ~obj55;
														object obj58 = obj57 | flag6;
														if (obj58 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44D8]");
															object obj59 = 0;
															object obj60 = _Canon3 + 64;
															obj60 = obj59;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X21_v22-28]");
															bool flag7 = (nint)0 < (nint)5;
															object obj61 = !flag7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X21_v22-28]");
															object obj62 = -5;
															bool flag8 = obj62 == null;
															object obj63 = ~obj61;
															object obj64 = obj63 | flag8;
															if (obj64 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4540]");
																object obj65 = 0;
																object obj66 = _Canon3 + 72;
																obj66 = obj65;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X21_v24-30]");
																bool flag9 = (nint)0 < (nint)6;
																object obj67 = !flag9;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X21_v24-30]");
																object obj68 = -6;
																bool flag10 = obj68 == null;
																object obj69 = ~obj67;
																object obj70 = obj69 | flag10;
																if (obj70 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4550]");
																	object obj71 = 0;
																	object obj72 = _Canon3 + 80;
																	obj72 = obj71;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X21_v26-38]");
																	object obj73 = 0 & 0xFFFFFFF8L;
																	if (obj73 != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4520]");
																		object obj74 = 0;
																		object obj75 = _Canon3 + 88;
																		obj75 = obj74;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X21_v28-40]");
																		bool flag11 = (nint)0 < (nint)8;
																		object obj76 = !flag11;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X21_v28-40]");
																		object obj77 = -8;
																		bool flag12 = obj77 == null;
																		object obj78 = ~obj76;
																		object obj79 = obj78 | flag12;
																		if (obj79 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4508]");
																			object obj80 = 0;
																			object obj81 = _Canon3 + 96;
																			obj81 = obj80;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X21_v30-48]");
																			bool flag13 = (nint)0 < (nint)9;
																			object obj82 = !flag13;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X21_v30-48]");
																			object obj83 = -9;
																			bool flag14 = obj83 == null;
																			object obj84 = ~obj82;
																			object obj85 = obj84 | flag14;
																			if (obj85 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4568]");
																				object obj86 = 0;
																				object obj87 = _Canon3 + 104;
																				obj87 = obj86;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple3 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)1, _Canon3);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																				bool flag15 = (nint)0 < (nint)2;
																				object obj88 = !flag15;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																				object obj89 = -2;
																				bool flag16 = obj89 == null;
																				object obj90 = ~obj88;
																				object obj91 = obj90 | flag16;
																				if (obj91 == null)
																				{
																					object obj92 = obj24 + 72;
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v74 (System.__Canon)+18]");
																					if ((nint)0 != 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44C8]");
																						object obj93 = 0;
																						System.__Canon _Canon4 = default;
																						object obj94 = _Canon4 + 32;
																						obj94 = obj93;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X21_v32-8]");
																						object obj95 = 0 & 0xFFFFFFFEL;
																						if (obj95 != null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44A8]");
																							object obj96 = 0;
																							object obj97 = _Canon4 + 40;
																							obj97 = obj96;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X21_v34-10]");
																							bool flag17 = (nint)0 < (nint)2;
																							object obj98 = !flag17;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X21_v34-10]");
																							object obj99 = -2;
																							bool flag18 = obj99 == null;
																							object obj100 = ~obj98;
																							object obj101 = obj100 | flag18;
																							if (obj101 == null)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4528]");
																								object obj102 = 0;
																								object obj103 = _Canon4 + 48;
																								obj103 = obj102;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X21_v36-18]");
																								object obj104 = 0 & 0xFFFFFFFCL;
																								if (obj104 != null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44A0]");
																									object obj105 = 0;
																									object obj106 = _Canon4 + 56;
																									obj106 = obj105;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X21_v38-20]");
																									bool flag19 = (nint)0 < (nint)4;
																									object obj107 = !flag19;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X21_v38-20]");
																									object obj108 = -4;
																									bool flag20 = obj108 == null;
																									object obj109 = ~obj107;
																									object obj110 = obj109 | flag20;
																									if (obj110 == null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4578]");
																										object obj111 = 0;
																										object obj112 = _Canon4 + 64;
																										obj112 = obj111;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X21_v40-28]");
																										bool flag21 = (nint)0 < (nint)5;
																										object obj113 = !flag21;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X21_v40-28]");
																										object obj114 = -5;
																										bool flag22 = obj114 == null;
																										object obj115 = ~obj113;
																										object obj116 = obj115 | flag22;
																										if (obj116 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44C0]");
																											object obj117 = 0;
																											object obj118 = _Canon4 + 72;
																											obj118 = obj117;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple4 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)4, _Canon4);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																											object obj119 = 0 & 0xFFFFFFFCL;
																											if (obj119 != null)
																											{
																												object obj120 = obj24 + 88;
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v92 (System.__Canon)+18]");
																												if ((nint)0 != 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4498]");
																													object obj121 = 0;
																													System.__Canon _Canon5 = default;
																													object obj122 = _Canon5 + 32;
																													obj122 = obj121;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X21_v42-8]");
																													object obj123 = 0 & 0xFFFFFFFEL;
																													if (obj123 != null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44E8]");
																														object obj124 = 0;
																														object obj125 = _Canon5 + 40;
																														obj125 = obj124;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X21_v44-10]");
																														bool flag23 = (nint)0 < (nint)2;
																														object obj126 = !flag23;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X21_v44-10]");
																														object obj127 = -2;
																														bool flag24 = obj127 == null;
																														object obj128 = ~obj126;
																														object obj129 = obj128 | flag24;
																														if (obj129 == null)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4510]");
																															object obj130 = 0;
																															object obj131 = _Canon5 + 48;
																															obj131 = obj130;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X21_v46-18]");
																															object obj132 = 0 & 0xFFFFFFFCL;
																															if (obj132 != null)
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44B8]");
																																object obj133 = 0;
																																object obj134 = _Canon5 + 56;
																																obj134 = obj133;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X21_v48-20]");
																																bool flag25 = (nint)0 < (nint)4;
																																object obj135 = !flag25;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X21_v48-20]");
																																object obj136 = -4;
																																bool flag26 = obj136 == null;
																																object obj137 = ~obj135;
																																object obj138 = obj137 | flag26;
																																if (obj138 == null)
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4598]");
																																	object obj139 = 0;
																																	object obj140 = _Canon5 + 64;
																																	obj140 = obj139;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X21_v50-28]");
																																	bool flag27 = (nint)0 < (nint)5;
																																	object obj141 = !flag27;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X21_v50-28]");
																																	object obj142 = -5;
																																	bool flag28 = obj142 == null;
																																	object obj143 = ~obj141;
																																	object obj144 = obj143 | flag28;
																																	if (obj144 == null)
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C45A8]");
																																		object obj145 = 0;
																																		object obj146 = _Canon5 + 72;
																																		obj146 = obj145;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X21_v52-30]");
																																		bool flag29 = (nint)0 < (nint)6;
																																		object obj147 = !flag29;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X21_v52-30]");
																																		object obj148 = -6;
																																		bool flag30 = obj148 == null;
																																		object obj149 = ~obj147;
																																		object obj150 = obj149 | flag30;
																																		if (obj150 == null)
																																		{
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44E0]");
																																			object obj151 = 0;
																																			object obj152 = _Canon5 + 80;
																																			obj152 = obj151;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																			(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple5 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)5, _Canon5);
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																																			bool flag31 = (nint)0 < (nint)4;
																																			object obj153 = !flag31;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																																			object obj154 = -4;
																																			bool flag32 = obj154 == null;
																																			object obj155 = ~obj153;
																																			object obj156 = obj155 | flag32;
																																			if (obj156 == null)
																																			{
																																				object obj157 = obj24 + 104;
																																				_ = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v112 (System.__Canon)+18]");
																																				if ((nint)0 != 0)
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4538]");
																																					object obj158 = 0;
																																					System.__Canon _Canon6 = default;
																																					object obj159 = _Canon6 + 32;
																																					obj159 = obj158;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X21_v54-8]");
																																					object obj160 = 0 & 0xFFFFFFFEL;
																																					if (obj160 != null)
																																					{
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44F0]");
																																						object obj161 = 0;
																																						object obj162 = _Canon6 + 40;
																																						obj162 = obj161;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																						(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple6 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)6, _Canon6);
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																																						bool flag33 = (nint)0 < (nint)5;
																																						object obj163 = !flag33;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																																						object obj164 = -5;
																																						bool flag34 = obj164 == null;
																																						object obj165 = ~obj163;
																																						object obj166 = obj165 | flag34;
																																						if (obj166 == null)
																																						{
																																							object obj167 = obj24 + 120;
																																							_ = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v122 (System.__Canon)+18]");
																																							if ((nint)0 != 0)
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4490]");
																																								object obj168 = 0;
																																								System.__Canon _Canon7 = default;
																																								object obj169 = _Canon7 + 32;
																																								obj169 = obj168;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X21_v56-8]");
																																								object obj170 = 0 & 0xFFFFFFFEL;
																																								if (obj170 != null)
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44D0]");
																																									object obj171 = 0;
																																									object obj172 = _Canon7 + 40;
																																									obj172 = obj171;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X21_v58-10]");
																																									bool flag35 = (nint)0 < (nint)2;
																																									object obj173 = !flag35;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X21_v58-10]");
																																									object obj174 = -2;
																																									bool flag36 = obj174 == null;
																																									object obj175 = ~obj173;
																																									object obj176 = obj175 | flag36;
																																									if (obj176 == null)
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4588]");
																																										object obj177 = 0;
																																										object obj178 = _Canon7 + 48;
																																										obj178 = obj177;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X21_v60-18]");
																																										object obj179 = 0 & 0xFFFFFFFCL;
																																										if (obj179 != null)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C44B0]");
																																											object obj180 = 0;
																																											object obj181 = _Canon7 + 56;
																																											obj181 = obj180;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X21_v62-20]");
																																											bool flag37 = (nint)0 < (nint)4;
																																											object obj182 = !flag37;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X21_v62-20]");
																																											object obj183 = -4;
																																											bool flag38 = obj183 == null;
																																											object obj184 = ~obj182;
																																											object obj185 = obj184 | flag38;
																																											if (obj185 == null)
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4580]");
																																												object obj186 = 0;
																																												object obj187 = _Canon7 + 64;
																																												obj187 = obj186;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																												(Unity.IL2CPP.Metadata.__Il2CppInt32Enum, System.__Canon) tuple7 = ((Unity.IL2CPP.Metadata.__Il2CppInt32Enum)7, _Canon7);
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																																												bool flag39 = (nint)0 < (nint)6;
																																												object obj188 = !flag39;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v18+18]");
																																												object obj189 = -6;
																																												bool flag40 = obj189 == null;
																																												object obj190 = ~obj188;
																																												object obj191 = obj190 | flag40;
																																												if (obj191 == null)
																																												{
																																													object obj192 = obj24 + 136;
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																													object obj193 = obj2;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v130+A0]");
																																													object obj194 = (nint)0 + (nint)32;
																																													obj194 = obj24;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
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
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
