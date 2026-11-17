using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public class SphereOverlapQuery : Query
{
	public Vector3 Center;

	public float Radius;

	private Collider[] _physXOverlapHits;

	private Collider2D[] _box2DOverlapHits;

	public SphereOverlapQuery(ref SphereOverlapQueryParams sphereOverlapParams)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_007b: Expected VT, but got I
		//IL_008d: Expected F4, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6690]");
		object obj2 = 0;
		base._002Ector(ref System.Runtime.CompilerServices.Unsafe.As<SphereOverlapQueryParams, QueryParams>(ref sphereOverlapParams));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sphereOverlapParams @ X1 (Fusion.LagCompensation.SphereOverlapQueryParams&)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sphereOverlapParams @ X1 (Fusion.LagCompensation.SphereOverlapQueryParams&)+38]");
		Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sphereOverlapParams @ X1 (Fusion.LagCompensation.SphereOverlapQueryParams&)+44]");
		Radius = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 88;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 96;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public SphereOverlapQuery(ref SphereOverlapQueryParams sphereOverlapParams, Collider[] physXOverlapHitsCache, Collider2D[] box2DOverlapHitsCache)
		: base(ref System.Runtime.CompilerServices.Unsafe.As<SphereOverlapQueryParams, QueryParams>(ref sphereOverlapParams))
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003c: Expected VT, but got I
		//IL_004e: Expected F4, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		object obj = this + 88;
		obj = physXOverlapHitsCache;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sphereOverlapParams @ X1 (Fusion.LagCompensation.SphereOverlapQueryParams&)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sphereOverlapParams @ X1 (Fusion.LagCompensation.SphereOverlapQueryParams&)+38]");
		Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sphereOverlapParams @ X1 (Fusion.LagCompensation.SphereOverlapQueryParams&)+44]");
		Radius = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 96;
		obj2 = box2DOverlapHitsCache;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	protected unsafe override bool Check(ref AABB bounds)
	{
		//IL_001a: Expected F4, but got I
		//IL_001a: Expected VT, but got Ref
		//IL_001a: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+C]");
		return LagCompensationUtils.LocalAABBSphereIntersection((Vector3)0, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bounds), 0f);
	}

	internal unsafe override bool NarrowPhase(IHitboxColliderContainer container, HashSet<int> candidates, List<HitboxHit> hits)
	{
		//IL_06cc: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_002e: Expected Obj, but got Ref
		//IL_0036: Expected Obj, but got Ref
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected F4, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I4
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got I4
		//IL_0831: Expected Obj, but got I
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Ref, but got Unknown
		//IL_085c: Expected Obj, but got I4
		//IL_0567: Expected Obj, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_05c0: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I4
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected I, but got Obj
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected I4, but got Unknown
		//IL_0757: Expected F4, but got VT
		//IL_0767: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I
		//IL_0796: Expected F4, but got VT
		//IL_0796: Expected VT, but got Ref
		//IL_07b1: Expected Obj, but got Ref
		//IL_07b9: Expected Obj, but got Ref
		//IL_00f9: Expected Obj, but got I
		//IL_0705: Expected Obj, but got I4
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got Ref
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected F4, but got Obj
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0639: Expected Obj, but got I4
		//IL_0642: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got Ref
		//IL_02ab: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got Ref
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_0136: Expected Obj, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Invalid comparison between Unknown and I4
		//IL_06a9: Expected Obj, but got I4
		//IL_02e2: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_0308: Expected Obj, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Ref
		//IL_0347: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got Ref
		//IL_037e: Expected Obj, but got I
		//IL_03a7: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I
		//IL_04e3: Expected VT, but got Ref
		//IL_04f0: Expected Obj, but got Ref
		//IL_0503: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I4
		//IL_03fc: Expected Obj, but got I
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0469: Expected Obj, but got Ref
		//IL_047c: Expected Obj, but got I4
		//IL_0485: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		HashSet<int> hashSet = default;
		bool flag = hashSet == null;
		object obj = 0;
		HashSet<int> hashSet2 = hashSet;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
			object obj3 = 0;
			Enumerator val = default;
			object obj4 = (object)(&val);
			object obj6 = default;
			object obj5 = (object)(&obj6);
			Enumerator enumerator = hashSet.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X27_v6+20]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X27_v6+20]");
			obj4 = 0;
			List<HitboxHit> list2 = default;
			List<HitboxHit> list = list2;
			object obj7 = 0;
			Enumerator val2 = (Enumerator)(ref val);
			hashSet2 = hashSet;
			IHitboxColliderContainer hitboxColliderContainer;
			bool flag3 = default;
			object obj20 = default;
			bool result = default;
			SphereOverlapQuery sphereOverlapQuery = default;
			IntPtr intPtr = default;
			object obj24 = default;
			object obj14;
			object obj15;
			Enumerator val3;
			IHitboxColliderContainer hitboxColliderContainer2 = default;
			while (true)
			{
				hitboxColliderContainer = (IHitboxColliderContainer)obj2;
				if (val.MoveNext())
				{
					if (hitboxColliderContainer2 != null)
					{
						nint num2 = (nint)hitboxColliderContainer2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v17 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
						val2 = (Enumerator)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v17 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0196;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v17 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
						object obj8 = (nint)0 + (nint)8;
						bool flag2 = flag3;
						object obj11;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X10_v15-8]");
							bool flag4 = 0 < (nint)obj3;
							object obj9 = !flag4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X10_v15-8]");
							object obj10 = 0 - obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X10_v15-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v17 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
							val2 = (Enumerator)(-1);
							bool flag5 = (int)val2 < 1;
							obj9 = !flag5;
							obj10 = val2 - 1;
							bool flag6 = obj10 == null;
							obj11 = obj8 + 16;
							flag3 = (int)val2 != 1;
							flag2 = flag3;
							obj8 = obj11;
							if (flag3)
							{
								continue;
							}
							goto IL_0196;
						}
						val2 = (Enumerator)(obj8 + 2);
						object obj12 = num2 + val2;
						object obj13 = obj12 + 312;
						flag3 = flag2;
						obj11 = obj8;
						goto IL_0743;
					}
					NullReferenceException ex = new NullReferenceException();
					break;
				}
				obj14 = 0;
				obj15 = 0;
				val3 = (Enumerator)(ref val);
				object obj16 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65D8]");
					object obj17 = 0;
					hitboxColliderContainer2 = (IHitboxColliderContainer)obj17;
					((Enumerator*)val3)->Dispose();
					bool flag7 = obj16 == null;
					object obj18 = !flag7;
					list2 = list;
					if (obj18 == null)
					{
						bool flag8 = obj14 == null;
						object obj19 = !flag8;
						list2 = list;
						OutOfMemoryException ex2 = (OutOfMemoryException)val3;
						if (obj19 == null)
						{
							return (byte)(obj7 & 1) != 0;
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
						list = list2;
						obj14 = 1;
						obj7 = 1;
						obj16 = obj15;
						continue;
					}
					if ((nint)hitboxColliderContainer2 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj16 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list = list2;
					obj15 = obj20;
					obj7 = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A50E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
				IL_0743:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v529 @ X0_v31] (should have been resolved before IL gen)");
				num = (float)Center;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.SphereOverlapQuery)+4C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.SphereOverlapQuery)+50]");
				object obj22 = 0;
				bool flag9 = sphereOverlapQuery.NarrowPhaseSphere(ref *(HitboxCollider*)sphereOverlapQuery, (Vector3)(&obj), (float)Center, out var point, out *(Vector3*)intPtr);
				bool flag10 = !flag9;
				list = (List<HitboxHit>)(&point);
				hashSet = (HashSet<int>)(&obj);
				hashSet2 = (HashSet<int>)(object)sphereOverlapQuery;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					_ = 0;
					_ = 0;
					object obj23 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 32));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj11 = sphereOverlapQuery + 452;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v33 (Fusion.LagCompensation.SphereOverlapQuery)+1C0]");
					val2 = (Enumerator)0;
					num = (float)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v33 (Fusion.LagCompensation.SphereOverlapQuery)+1B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v33 (Fusion.LagCompensation.SphereOverlapQuery)+1C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					bool flag11 = list2 == null;
					list = (List<HitboxHit>)(&point);
					obj21 = obj24;
					obj22 = 0;
					hashSet = (HashSet<int>)80;
					hitboxColliderContainer = (IHitboxColliderContainer)(&obj6);
					hashSet2 = (HashSet<int>)(object)sphereOverlapQuery;
					if (flag11)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6698]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+1C]");
					obj11 = (nint)0 + (nint)1;
					val2 = (Enumerator)obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
					bool flag12 = (nint)0 == 0;
					list = (List<HitboxHit>)(&point);
					obj21 = obj24;
					obj22 = 0;
					hashSet = (HashSet<int>)80;
					hitboxColliderContainer = (IHitboxColliderContainer)(&obj6);
					hashSet2 = (HashSet<int>)(object)sphereOverlapQuery;
					if (flag12)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v23+18]");
					bool flag13 = num3 < 0;
					object obj9 = !flag13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v23+18]");
					object obj10 = num4 - 0;
					bool flag6 = obj10 == null;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						object obj27 = (nint)0 * (nint)80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
						hashSet2 = (HashSet<int>)(0 + obj27);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						object obj28 = (nint)0 + (nint)1;
						object obj29 = hashSet2 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						object obj30 = hashSet2 + 64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						list = (List<HitboxHit>)(&point);
						obj21 = obj24;
						obj22 = 0;
						hashSet = (HashSet<int>)80;
						obj7 = 1;
						val2 = (Enumerator)80;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X9_v2 (System.Threading.ReaderWriterLockSlim+Enumerator<System.Int32>)+20]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v24+A8]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v25+70]");
						hashSet2 = (HashSet<int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						list2.AddWithResize((HitboxHit)(&obj6));
						list = (List<HitboxHit>)(&point);
						obj21 = obj24;
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v25+70]");
						hashSet = (HashSet<int>)0;
						obj7 = 1;
					}
				}
				continue;
				IL_0196:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0743;
			}
			NullReferenceException ex3 = new NullReferenceException();
			list2 = list;
			obj14 = 0;
			obj15 = 0;
			val3 = (Enumerator)(ref val);
			hitboxColliderContainer2 = hitboxColliderContainer;
		}
		throw new NullReferenceException();
	}

	internal unsafe override void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options)
	{
		//IL_0661: Expected Obj, but got I4
		//IL_067b: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got VT
		//IL_0390: Expected Obj, but got VT
		//IL_0390: Expected F4, but got VT
		//IL_0390: Expected VT, but got Obj
		//IL_03be: Expected Obj, but got Ref
		//IL_03ce: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got VT
		//IL_0084: Expected Obj, but got VT
		//IL_0084: Expected F4, but got VT
		//IL_0084: Expected VT, but got Obj
		//IL_03f7: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got Ref
		//IL_00c2: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got Ref
		//IL_00eb: Expected Obj, but got I4
		//IL_046e: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I
		//IL_0116: Expected Obj, but got Ref
		//IL_04bc: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_052d: Expected Obj, but got I4
		//IL_05d4: Expected Obj, but got I
		//IL_05e4: Expected Obj, but got I
		//IL_05fb: Expected VT, but got Ref
		//IL_060b: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01ce: Expected Obj, but got I
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_0551: Expected Obj, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_057c: Expected Obj, but got I
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected Obj, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_05bf: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I
		//IL_02ef: Expected VT, but got Ref
		//IL_02ff: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02b3: Expected Obj, but got I4
		object obj = options & (HitOptions)1;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj5 = default;
		object obj23 = default;
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
				Collider2D[] array = (Collider2D[])LayerMask;
				PhysicsScene2D physicsScene2D2 = default;
				int num = physicsScene2D2.OverlapCircle((Vector2)_box2DOverlapHits, (float)Center, (Collider2D[])LayerMask, 0);
				if (num < 1)
				{
					return;
				}
				object obj4 = (object)(&obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66A8]");
				object obj6 = 0;
				object obj7 = 0;
				while (true)
				{
					Collider2D[] box2DOverlapHits = _box2DOverlapHits;
					if (_box2DOverlapHits == null)
					{
						break;
					}
					bool flag2 = (nint)obj7 < box2DOverlapHits.Length;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						object obj9 = (object)_box2DOverlapHits + obj7;
						object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 88));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v16+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v16+20]");
						GameObject gameObject = ((Component)0).gameObject;
						object obj11 = (nint)(&obj5) | (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (hits == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						object obj12 = 0;
						object obj13 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v17+18]");
						bool flag3 = num2 < 0;
						object obj15 = !flag3;
						if (obj15 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
							object obj16 = (nint)0 * (nint)104;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
							object obj17 = 0 + obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
							object obj18 = (nint)0 + (nint)1;
							object obj19 = obj17 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
							object obj20 = obj17 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							array = (Collider2D[])104;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X9_v9+20]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v19+A8]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							hits.AddWithResize((LagCompensatedHit)(&obj23));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v20+70]");
							array = (Collider2D[])0;
						}
						obj7++;
						if (num == (nint)obj7)
						{
							return;
						}
						continue;
					}
					goto IL_064c;
				}
			}
		}
		else if ((object)runner != null)
		{
			PhysicsScene physicsScene = runner.GetPhysicsScene();
			Collider[] array2 = (Collider[])LayerMask;
			PhysicsScene physicsScene2 = default;
			int num3 = physicsScene2.OverlapSphere((Vector3)_physXOverlapHits, (float)Center, (Collider[])LayerMask, (int)TriggerInteraction, (QueryTriggerInteraction)0);
			if (num3 < 1)
			{
				return;
			}
			object obj24 = (object)(&obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66A8]");
			object obj25 = 0;
			object obj26 = 0;
			while (true)
			{
				Collider[] physXOverlapHits = _physXOverlapHits;
				if (_physXOverlapHits == null)
				{
					break;
				}
				bool flag4 = (nint)obj26 < physXOverlapHits.Length;
				object obj27 = !flag4;
				if (obj27 == null)
				{
					object obj28 = (object)_physXOverlapHits + obj26;
					object obj29 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 80));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v8+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v8+20]");
					GameObject gameObject2 = ((Component)0).gameObject;
					object obj30 = (nint)(&obj5) | (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (hits == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					object obj31 = 0;
					object obj32 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
					object obj33 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v9+18]");
					bool flag5 = num4 < 0;
					object obj34 = !flag5;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						object obj35 = (nint)0 * (nint)104;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						object obj36 = 0 + obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						object obj37 = (nint)0 + (nint)1;
						object obj38 = obj36 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj39 = obj36 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						array2 = (Collider[])104;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v6+20]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v11+A8]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						hits.AddWithResize((LagCompensatedHit)(&obj23));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v12+70]");
						array2 = (Collider[])0;
					}
					obj26++;
					if (num3 == (nint)obj26)
					{
						return;
					}
					continue;
				}
				goto IL_064c;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_064c;
		IL_064c:
		throw new IndexOutOfRangeException();
	}

	internal unsafe bool NarrowPhaseSphere(ref HitboxCollider c, Vector3 origin, float radius, out Vector3 point, out Vector3 normal)
	{
		//IL_000e: Invalid comparison between VT and I4
		//IL_0030: Invalid comparison between VT and I4
		//IL_041d: Expected VT, but got I4
		//IL_041d: Expected VT, but got Ref
		//IL_02c7: Expected VT, but got Ref
		//IL_05e8: Expected native int or pointer, but got VT
		//IL_05f6: Expected native int or pointer, but got VT
		//IL_02ea: Expected Obj, but got I4
		//IL_0052: Invalid comparison between VT and I4
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_0571: Expected native int or pointer, but got VT
		//IL_057e: Expected native int or pointer, but got VT
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_00a6: Expected Ref, but got VT
		//IL_00a6: Expected F4, but got I
		//IL_00a6: Expected VT, but got I4
		//IL_00a6: Expected VT, but got Ref
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_0232: Expected native int or pointer, but got VT
		//IL_023f: Expected native int or pointer, but got VT
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		Matrix4x4 m = default;
		object obj7 = default;
		object obj9 = default;
		object obj12 = default;
		object obj15 = default;
		object obj18 = default;
		object obj20 = default;
		object obj21 = default;
		object obj23 = default;
		object obj25 = default;
		object obj27 = default;
		object obj28 = default;
		object obj31 = default;
		object obj36 = default;
		object obj38 = default;
		object obj40;
		object obj42;
		object obj44;
		object obj45 = default;
		object obj46;
		object obj47;
		object obj49;
		object obj50 = default;
		float num3 = default;
		object obj69 = default;
		if (c != (HitboxCollider)(object)3)
		{
			if (c != (HitboxCollider)(object)2)
			{
				if (c == (HitboxCollider)(object)1)
				{
					Matrix4x4 localToWorld = c.LocalToWorld;
					Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref m);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+54]");
					object obj = default;
					if (LagCompensationUtils.LocalAABBSphereContact((Vector3)(&obj), (Vector3)0, 0f, out *(SnapshotHistoryDraw.ContactData*)origin))
					{
						Matrix4x4 localToWorld2 = c.LocalToWorld;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+48]");
						object obj3 = obj2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+4C]");
						object obj5 = default;
						object obj4 = obj5 + 0;
						object obj6 = obj3 * obj7;
						object obj8 = obj4 * obj9;
						object obj10 = obj6 + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+50]");
						object obj11 = 0 * obj12;
						object obj13 = obj10 + obj11;
						object obj14 = obj15 + obj13;
						object obj17 = default;
						object obj16 = obj17 * obj18;
						object obj19 = obj20 * obj21;
						object obj22 = obj3 * obj23;
						object obj24 = obj4 * obj25;
						object obj26 = obj27 * obj28;
						double num = 1.0 / (double)obj14;
						object obj29 = obj16 + obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+50]");
						object obj30 = 0 * obj31;
						object obj32 = obj22 + obj24;
						object obj33 = obj29 + obj26;
						object obj34 = obj32 + obj30;
						object obj35 = obj36 + obj33;
						object obj37 = obj38 + obj34;
						object obj39 = default;
						float x = (float)obj35 * (float)obj39;
						double num2 = (double)obj37 * num;
						((Vector3*)(nint)origin)->x = x;
						((Vector3*)(nint)origin)->z = (float)num2;
						Matrix4x4 localToWorld3 = c.LocalToWorld;
						object obj41 = default;
						obj40 = obj41 * obj18;
						object obj43 = default;
						obj42 = obj43 * obj23;
						obj44 = obj45 * obj21;
						obj46 = 0 * obj25;
						object obj48 = default;
						obj47 = obj48;
						obj49 = obj50;
						goto IL_0618;
					}
				}
			}
			else
			{
				Matrix4x4 localToWorld4 = c.LocalToWorld;
				bool flag = LagCompensationUtils.SphereSphere(origin, radius, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref point), num3, out *(Vector3*)null, out point);
				bool flag2 = !flag;
				object obj51 = !flag2;
				if (obj51 != null)
				{
					goto IL_0678;
				}
			}
		}
		else
		{
			Matrix4x4 localToWorld5 = c.LocalToWorld;
			Matrix4x4 matrix4x2 = Matrix4x4.Internal_Inverse(ref m);
			float num4 = radius * (float)obj7;
			float num5 = num3 * (float)obj9;
			float num6 = num4 + num5;
			object obj53 = default;
			object obj52 = obj53 * obj12;
			float num7 = num3 * (float)obj25;
			float num8 = num6 + (float)obj52;
			float num9 = radius * (float)obj23;
			float num10 = (float)obj15 + num8;
			float num11 = num9 + num7;
			object obj54 = obj53 * obj31;
			double num12 = 1.0 / (double)num10;
			float num13 = num11 + (float)obj54;
			float sphereRadius = (float)obj38 + num13;
			Vector3 capsuleLocalTopCenter = c.CapsuleLocalTopCenter;
			Vector3 capsuleLocalBottomCenter = c.CapsuleLocalBottomCenter;
			object obj55 = default;
			if (LagCompensationUtils.LocalSphereCapsuleIntersection((Vector3)(&obj55), (Vector3)0, (float)num12, origin, sphereRadius, out System.Runtime.CompilerServices.Unsafe.As<Vector3, SnapshotHistoryDraw.ContactData>(ref point)))
			{
				Matrix4x4 localToWorld6 = c.LocalToWorld;
				object obj56 = obj55 * obj7;
				object obj58 = default;
				object obj57 = obj58 * obj9;
				object obj59 = 0 * obj12;
				object obj60 = obj56 + obj57;
				object obj61 = obj60 + obj59;
				object obj62 = obj15 + obj61;
				object obj64 = default;
				object obj63 = obj64 * obj18;
				object obj65 = obj20 * obj21;
				object obj66 = obj55 * obj23;
				object obj67 = obj58 * obj25;
				object obj68 = obj27 * obj69;
				double num14 = 1.0 / (double)obj62;
				object obj70 = obj63 + obj65;
				object obj71 = 0 * obj31;
				object obj72 = obj66 + obj67;
				object obj73 = obj70 + obj68;
				object obj74 = obj72 + obj71;
				object obj75 = obj36 + obj73;
				object obj76 = obj38 + obj74;
				float x2 = (float)obj75 * (float)obj28;
				double num15 = (double)obj76 * num14;
				((Vector3*)(nint)origin)->x = x2;
				((Vector3*)(nint)origin)->z = (float)num15;
				Matrix4x4 localToWorld7 = c.LocalToWorld;
				object obj77 = default;
				obj40 = obj77 * obj18;
				obj44 = obj45 * obj21;
				object obj78 = default;
				obj42 = obj78 * obj23;
				obj46 = 0 * obj25;
				object obj79 = default;
				obj47 = obj79;
				obj49 = obj50;
				goto IL_0618;
			}
		}
		((Vector3*)(nint)origin)->z = 0f;
		((Vector3*)(nint)origin)->x = 0f;
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)null;
		return false;
		IL_0618:
		object obj80 = obj40 + obj44;
		object obj81 = obj42 + obj46;
		object obj82 = obj49 * obj69;
		object obj83 = obj47 * obj31;
		object obj84 = obj80 + obj82;
		object obj85 = obj81 + obj83;
		reference = ref *(Vector3*)obj84;
		goto IL_0678;
		IL_0678:
		return true;
	}
}
