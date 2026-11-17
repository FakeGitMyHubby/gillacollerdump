using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public class RaycastAllQuery : RaycastQuery
{
	private RaycastHit[] _physXRaycastHits;

	private RaycastHit2D[] _box2DRaycastHits;

	public RaycastAllQuery(ref RaycastQueryParams raycastQueryParams)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_007b: Expected VT, but got I
		//IL_009a: Expected VT, but got I
		//IL_00ac: Expected F4, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCD0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66D0]");
		object obj2 = 0;
		base._002Ector(ref System.Runtime.CompilerServices.Unsafe.As<RaycastQueryParams, QueryParams>(ref raycastQueryParams));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+4C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+44]");
		Direction = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+38]");
		Origin = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+50]");
		Length = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 192;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 200;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public RaycastAllQuery(ref RaycastQueryParams raycastQueryParams, RaycastHit[] physXRaycastHitsCache, RaycastHit2D[] box2DRaycastHitCache)
		: base(ref System.Runtime.CompilerServices.Unsafe.As<RaycastQueryParams, QueryParams>(ref raycastQueryParams))
	{
		//IL_0029: Expected VT, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_005b: Expected VT, but got I
		//IL_006d: Expected F4, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+4C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+44]");
		Direction = (Vector3)0;
		object obj = this + 192;
		obj = physXRaycastHitsCache;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+38]");
		Origin = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [raycastQueryParams @ X1 (Fusion.LagCompensation.RaycastQueryParams&)+50]");
		Length = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 200;
		obj2 = box2DRaycastHitCache;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe override bool NarrowPhase(IHitboxColliderContainer container, HashSet<int> candidates, List<HitboxHit> hits)
	{
		//IL_07c0: Expected VT, but got I4
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected VT, but got I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0088: Expected Obj, but got Ref
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected VT, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I4
		//IL_0544: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Ref, but got Unknown
		//IL_0993: Expected Obj, but got I4
		//IL_0564: Expected Obj, but got I4
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		//IL_0693: Expected Obj, but got I4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got I4
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected VT, but got I
		//IL_0874: Expected Obj, but got I
		//IL_08a5: Expected F4, but got VT
		//IL_08a5: Expected VT, but got Ref
		//IL_08a5: Expected VT, but got Ref
		//IL_08c8: Expected Obj, but got Ref
		//IL_08d0: Expected Obj, but got Ref
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got I
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I4
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_080c: Expected Obj, but got I4
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected Obj, but got Unknown
		//IL_0737: Expected Obj, but got I4
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected I4, but got Unknown
		//IL_05b1: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got Ref
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0796: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got Ref
		//IL_0304: Expected VT, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Ref
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Invalid comparison between Unknown and I4
		//IL_0170: Expected Obj, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Invalid comparison between Unknown and I4
		//IL_0343: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I4
		//IL_0389: Expected Obj, but got I
		//IL_0478: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I
		//IL_04af: Expected VT, but got Ref
		//IL_04c4: Expected Obj, but got Ref
		//IL_04e0: Expected VT, but got I4
		//IL_04f0: Expected Obj, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got I
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03ec: Expected Obj, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0436: Expected Obj, but got Ref
		//IL_0452: Expected VT, but got I4
		//IL_045b: Expected Obj, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = hits == null;
		List<HitboxHit> list = hits;
		Vector3 point = (Vector3)0;
		Enumerator val = (Enumerator)0;
		Enumerator val2 = (Enumerator)0;
		HashSet<int> hashSet2 = default;
		HashSet<int> hashSet = hashSet2;
		if (!flag)
		{
			bool flag2 = hashSet2 == null;
			list = hits;
			point = (Vector3)0;
			val = (Enumerator)0;
			val2 = (Enumerator)0;
			hashSet = hashSet2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65E0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6698]");
				object obj3 = 0;
				Enumerator val3 = default;
				object obj4 = (object)(&val3);
				Enumerator enumerator = hashSet2.GetEnumerator();
				list = hits;
				point = (Vector3)0;
				Enumerator val4 = val3;
				Enumerator val5 = (Enumerator)(ref val);
				hashSet = hashSet2;
				IHitboxColliderContainer hitboxColliderContainer;
				bool flag4 = default;
				object obj27 = default;
				bool result = default;
				RaycastQuery raycastQuery = default;
				object obj29 = default;
				ref Vector3 normal = default;
				ref float distance = default;
				object obj33 = default;
				object obj11;
				object obj12;
				Enumerator val6;
				object obj13;
				IHitboxColliderContainer hitboxColliderContainer2 = default;
				while (true)
				{
					hitboxColliderContainer = (IHitboxColliderContainer)obj;
					if (val.MoveNext())
					{
						if (hitboxColliderContainer2 != null)
						{
							nint num = (nint)hitboxColliderContainer2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
							val5 = (Enumerator)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_01d0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
							object obj5 = (nint)0 + (nint)8;
							bool flag3 = flag4;
							object obj8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v15-8]");
								bool flag5 = 0 < (nint)obj2;
								object obj6 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v15-8]");
								object obj7 = 0 - obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X10_v15-8]");
								if (0 == (nint)obj2)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
								val5 = (Enumerator)(-1);
								bool flag6 = (int)val5 < 1;
								obj6 = !flag6;
								obj7 = val5 - 1;
								bool flag7 = obj7 == null;
								obj8 = obj5 + 16;
								flag4 = (int)val5 != 1;
								flag3 = flag4;
								obj5 = obj8;
								if (flag4)
								{
									continue;
								}
								goto IL_01d0;
							}
							val5 = (Enumerator)(obj5 + 2);
							object obj9 = num + val5;
							object obj10 = obj9 + 312;
							flag4 = flag3;
							obj8 = obj5;
							goto IL_084a;
						}
						NullReferenceException ex = new NullReferenceException();
						break;
					}
					obj11 = 0;
					val = val3;
					obj12 = 0;
					val6 = (Enumerator)(ref val);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					obj13 = 0;
					object obj14 = 5;
					object obj15 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65D8]");
						object obj16 = 0;
						hitboxColliderContainer2 = (IHitboxColliderContainer)obj16;
						((Enumerator*)val6)->Dispose();
						bool flag8 = obj15 == null;
						object obj17 = !flag8;
						object obj20;
						if (obj17 == null)
						{
							bool flag9 = obj11 == null;
							object obj18 = !flag9;
							OutOfMemoryException ex2 = (OutOfMemoryException)val6;
							if (obj18 == null)
							{
								if ((nint)obj14 != 5)
								{
									bool flag10 = obj14 == null;
									object obj19 = !flag10;
									obj20 = obj11;
									if (obj19 != null)
									{
										goto IL_0922;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								object obj21 = 0 - obj13;
								bool flag11 = (nint)obj21 < 0;
								bool flag12 = obj21 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								object obj22 = 0 ^ obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								object obj23 = 0 ^ obj21;
								object obj24 = obj22 & obj23;
								bool flag13 = (nint)obj24 < 0;
								bool flag14 = flag11 == flag13;
								object obj25 = !flag12;
								object obj26 = flag14 & obj25;
								obj20 = obj26;
								goto IL_0922;
							}
						}
						else
						{
							OutOfMemoryException ex2 = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)hitboxColliderContainer2 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj11 = 1;
							obj15 = obj12;
						}
						else
						{
							if ((nint)hitboxColliderContainer2 != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj15 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj12 = obj27;
						}
						obj14 = 0;
						continue;
						IL_0922:
						return (byte)(obj20 & 1) != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A50E0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
					IL_084a:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v621 @ X0_v32] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastAllQuery)+58]");
					Vector3 vector = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastAllQuery)+5C]");
					object obj28 = 0;
					Vector3 direction = Direction;
					bool flag15 = raycastQuery.NarrowPhaseRay(ref *(HitboxCollider*)raycastQuery, (Vector3)(&val2), (Vector3)(&obj29), (float)Origin, out point, out normal, out distance);
					bool flag16 = !flag15;
					nint num2 = (nint)(&point);
					list = (List<HitboxHit>)(&obj29);
					hashSet2 = (HashSet<int>)(&val2);
					val4 = (Enumerator)Origin;
					hashSet = (HashSet<int>)(object)raycastQuery;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
						object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref val3, 32));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj31 = raycastQuery + 452;
						val4 = (Enumerator)obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v34 (Fusion.LagCompensation.RaycastQuery)+1B8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v34 (Fusion.LagCompensation.RaycastQuery)+1C0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
						object obj32 = 0;
						val5 = (Enumerator)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+1C]");
						object obj8 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
						bool flag17 = (nint)0 == 0;
						num2 = (nint)(&point);
						list = (List<HitboxHit>)(&obj29);
						obj28 = obj33;
						vector = point;
						direction = (Vector3)0;
						hashSet2 = (HashSet<int>)80;
						val3 = val2;
						hitboxColliderContainer = (IHitboxColliderContainer)(&val3);
						hashSet = (HashSet<int>)(object)raycastQuery;
						if (flag17)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v27+18]");
						bool flag18 = num3 < 0;
						object obj6 = !flag18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v27+18]");
						object obj7 = num4 - 0;
						bool flag7 = obj7 == null;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
							object obj34 = (nint)0 * (nint)80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
							hashSet = (HashSet<int>)(0 + obj34);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
							object obj35 = (nint)0 + (nint)1;
							object obj36 = hashSet + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							object obj37 = hashSet + 64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							num2 = (nint)(&point);
							list = (List<HitboxHit>)(&obj29);
							obj28 = obj33;
							vector = point;
							direction = (Vector3)0;
							hashSet2 = (HashSet<int>)80;
							val3 = val2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v4 (System.Threading.ReaderWriterLockSlim+Enumerator<System.Int32>)+20]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v28+A8]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v29+70]");
							hashSet = (HashSet<int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							hits.AddWithResize((HitboxHit)(&val3));
							num2 = (nint)(&point);
							list = (List<HitboxHit>)(&obj29);
							obj28 = obj33;
							vector = point;
							direction = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v29+70]");
							hashSet2 = (HashSet<int>)0;
							val3 = val2;
						}
					}
					continue;
					IL_01d0:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_084a;
				}
				NullReferenceException ex3 = new NullReferenceException();
				obj11 = 0;
				val = val3;
				obj12 = 0;
				val6 = (Enumerator)(ref val);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
				obj13 = 0;
				hitboxColliderContainer2 = hitboxColliderContainer;
			}
		}
		throw new NullReferenceException();
	}

	internal unsafe override void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options)
	{
		//IL_0509: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_02dc: Expected F4, but got VT
		//IL_02dc: Expected Obj, but got I4
		//IL_02dc: Expected VT, but got Obj
		//IL_030c: Expected Obj, but got I4
		//IL_0315: Expected Obj, but got I4
		//IL_007a: Expected F4, but got VT
		//IL_007a: Expected VT, but got Obj
		//IL_0335: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_035b: Expected VT, but got Ref
		//IL_00d3: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_00f9: Expected VT, but got Ref
		//IL_03f6: Expected Obj, but got I4
		//IL_049d: Expected VT, but got Ref
		//IL_012a: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_041a: Expected Obj, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0445: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_023b: Expected VT, but got Ref
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		object obj = options & (HitOptions)1;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj17 = default;
		if (obj2 == null)
		{
			object obj3 = options & (HitOptions)2;
			if (obj3 == null)
			{
				return;
			}
			if ((object)runner != null)
			{
				PhysicsScene2D physicsScene2D = runner.GetPhysicsScene2D();
				PhysicsScene2D physicsScene2D2 = default;
				IntPtr intPtr = default;
				int num = physicsScene2D2.Raycast((Vector2)_box2DRaycastHits, (Vector2)LayerMask, (float)Origin, null, (int)(nint)intPtr);
				if (num < 1)
				{
					return;
				}
				object obj4 = 32;
				object obj5 = 0;
				object obj8 = default;
				while (true)
				{
					RaycastHit2D[] box2DRaycastHits = _box2DRaycastHits;
					if (_box2DRaycastHits == null)
					{
						break;
					}
					bool flag2 = (nint)obj5 < box2DRaycastHits.Length;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						object obj7 = (object)_box2DRaycastHits + obj4;
						LagCompensatedHit lagCompensatedHit = (LagCompensatedHit)(RaycastHit2D)(&obj8);
						if (hits == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
						object obj10 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v20+18]");
						bool flag3 = num2 < 0;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
							object obj12 = (nint)0 * (nint)104;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
							object obj13 = 0 + obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
							object obj14 = (nint)0 + (nint)1;
							object obj15 = obj13 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
							object obj16 = obj13 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							hits.AddWithResize((LagCompensatedHit)(&obj17));
						}
						obj5++;
						obj4 += 40;
						bool flag4 = num != (nint)obj5;
						obj8 = obj7;
						if (!flag4)
						{
							return;
						}
						continue;
					}
					goto IL_04f4;
				}
			}
		}
		else if ((object)runner != null)
		{
			PhysicsScene physicsScene = runner.GetPhysicsScene();
			PhysicsScene physicsScene2 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			int num3 = physicsScene2.Raycast((Vector3)_physXRaycastHits, (Vector3)LayerMask, (RaycastHit[])TriggerInteraction, (float)Origin, 0, queryTriggerInteraction);
			if (num3 < 1)
			{
				return;
			}
			object obj18 = 32;
			object obj19 = 0;
			object obj22 = default;
			while (true)
			{
				RaycastHit[] physXRaycastHits = _physXRaycastHits;
				if (_physXRaycastHits == null)
				{
					break;
				}
				bool flag5 = (nint)obj19 < physXRaycastHits.Length;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					object obj21 = (object)_physXRaycastHits + obj18;
					LagCompensatedHit lagCompensatedHit2 = (LagCompensatedHit)(RaycastHit)(&obj22);
					if (hits == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
					object obj24 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v10+18]");
					bool flag6 = num4 < 0;
					object obj25 = !flag6;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						object obj26 = (nint)0 * (nint)104;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						object obj27 = 0 + obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						object obj28 = (nint)0 + (nint)1;
						object obj29 = obj27 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj30 = obj27 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						hits.AddWithResize((LagCompensatedHit)(&obj17));
					}
					obj19++;
					obj18 += 48;
					bool flag7 = num3 != (nint)obj19;
					obj22 = obj21;
					if (!flag7)
					{
						return;
					}
					continue;
				}
				goto IL_04f4;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_04f4;
		IL_04f4:
		throw new IndexOutOfRangeException();
	}
}
