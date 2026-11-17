using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public class BoxOverlapQuery : Query
{
	public Vector3 Center;

	public Vector3 Extents;

	public Quaternion Rotation;

	private Collider[] _physXOverlapHits;

	private Collider2D[] _box2DOverlapHits;

	internal LagCompensationUtils.BoxNarrowData _queryNarrowData;

	public BoxOverlapQuery(ref BoxOverlapQueryParams boxOverlapParams)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00ac: Expected VT, but got I
		//IL_00cb: Expected VT, but got I
		//IL_00ea: Expected VT, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0072: Expected VT, but got I4
		//IL_0072: Expected VT, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6690]");
		object obj2 = 0;
		base._002Ector(ref System.Runtime.CompilerServices.Unsafe.As<BoxOverlapQueryParams, QueryParams>(ref boxOverlapParams));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+50]");
		Rotation = (Quaternion)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+4C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+44]");
		Extents = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+38]");
		Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 112;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 120;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Vector3 extents = default;
		LagCompensationUtils.BoxNarrowData boxNarrowData = new LagCompensationUtils.BoxNarrowData((Vector3)0, (Quaternion)300, extents);
		object obj7 = obj5 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
	}

	public BoxOverlapQuery(ref BoxOverlapQueryParams boxOverlapParams, Collider[] physXOverlapHitsCache, Collider2D[] box2DOverlapHitsCache)
		: base(ref System.Runtime.CompilerServices.Unsafe.As<BoxOverlapQueryParams, QueryParams>(ref boxOverlapParams))
	{
		//IL_001c: Expected VT, but got I
		//IL_003b: Expected VT, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_006d: Expected VT, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00bf: Expected VT, but got Obj
		//IL_00bf: Expected VT, but got I4
		//IL_00bf: Expected VT, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+50]");
		Rotation = (Quaternion)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+4C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+44]");
		Extents = (Vector3)0;
		object obj = this + 112;
		obj = physXOverlapHitsCache;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxOverlapParams @ X1 (Fusion.LagCompensation.BoxOverlapQueryParams&)+38]");
		Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = this + 120;
		obj2 = box2DOverlapHitsCache;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		LagCompensationUtils.BoxNarrowData boxNarrowData = new LagCompensationUtils.BoxNarrowData((Vector3)0, (Quaternion)300, (Vector3)box2DOverlapHitsCache);
		object obj3 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
	}

	protected unsafe override bool Check(ref AABB bounds)
	{
		//IL_000e: Expected VT, but got Ref
		//IL_000e: Expected VT, but got I4
		//IL_0023: Expected Obj, but got VT
		//IL_0034: Expected Obj, but got VT
		//IL_0051: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I4
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0539: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		Vector3 vector = (Quaternion)0 * (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bounds);
		object obj = Center + Rotation;
		object obj2 = Center - Rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+64]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+4C]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+4C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+64]");
		object obj4 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+68]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+50]");
		object obj5 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+50]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+68]");
		object obj6 = num4 - 0;
		object obj7 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj)) ? obj : obj2);
		object obj8 = obj4 - obj3;
		bool flag = (nint)obj8 < 0;
		bool flag2 = obj8 == null;
		object obj9 = obj4 ^ obj3;
		object obj10 = obj4 ^ obj8;
		object obj11 = obj9 & obj10;
		bool flag3 = (nint)obj11 < 0;
		object obj12 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3)) ? obj3 : obj4);
		bool flag4 = flag == flag3;
		object obj13 = !flag2;
		object obj14 = flag4 & obj13;
		object obj15 = ~obj14;
		if (obj15 != null)
		{
			obj4 = obj3;
		}
		object obj16 = obj6 - obj5;
		bool flag5 = (nint)obj16 < 0;
		bool flag6 = obj16 == null;
		object obj17 = obj6 ^ obj5;
		object obj18 = obj6 ^ obj16;
		object obj19 = obj17 & obj18;
		bool flag7 = (nint)obj19 < 0;
		object obj20 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5)) ? obj5 : obj6);
		bool flag8 = flag5 == flag7;
		object obj21 = !flag6;
		object obj22 = flag8 & obj21;
		object obj23 = ~obj22;
		object obj24 = ((obj23 != null) ? obj5 : obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+24]");
		bool flag9 = (nint)obj7 < 0;
		object obj25 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+24]");
		object obj26 = obj7 - 0;
		bool flag10 = obj26 == null;
		object obj27 = !flag10;
		object obj28 = obj25 & obj27;
		if (obj28 == null)
		{
			object obj29 = obj2 - obj;
			bool flag11 = (nint)obj29 < 0;
			bool flag12 = obj29 == null;
			object obj30 = obj2 ^ obj;
			object obj31 = obj2 ^ obj29;
			object obj32 = obj30 & obj31;
			bool flag13 = (nint)obj32 < 0;
			bool flag14 = flag11 == flag13;
			object obj33 = !flag12;
			object obj34 = flag14 & obj33;
			object obj35 = ~obj34;
			if (obj35 == null)
			{
				obj = obj2;
			}
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+18]");
			if ((nint)obj36 >= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
				bool flag15 = (nint)obj12 < 0;
				object obj37 = !flag15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
				object obj38 = obj12 - 0;
				bool flag16 = obj38 == null;
				object obj39 = !flag16;
				object obj40 = obj37 & obj39;
				if (obj40 == null)
				{
					object obj41 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+1C]");
					if ((nint)obj41 >= 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+2C]");
						bool flag17 = (nint)obj20 < 0;
						object obj42 = !flag17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+2C]");
						object obj43 = obj20 - 0;
						bool flag18 = obj43 == null;
						object obj44 = ~obj42;
						object obj45 = obj44 | flag18;
						if (obj45 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+20]");
							object obj46 = obj24 - 0;
							bool flag19 = (nint)obj46 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+20]");
							object obj47 = obj24 ^ 0;
							object obj48 = obj24 ^ obj46;
							object obj49 = obj47 & obj48;
							bool flag20 = (nint)obj49 < 0;
							return flag19 == flag20;
						}
					}
				}
			}
		}
		return false;
	}

	internal unsafe override bool NarrowPhase(IHitboxColliderContainer container, HashSet<int> candidates, List<HitboxHit> hits)
	{
		//IL_06e9: Expected Obj, but got Ref
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected Obj, but got Unknown
		//IL_0720: Expected VT, but got I4
		//IL_073a: Expected Obj, but got Ref
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_002e: Expected Obj, but got Ref
		//IL_0036: Expected Obj, but got Ref
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected VT, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_056c: Expected Obj, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected Ref, but got Unknown
		//IL_08ba: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I4
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_05f7: Expected Obj, but got I4
		//IL_0601: Expected Obj, but got I4
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected I, but got Obj
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected I4, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected Ref, but got Unknown
		//IL_07ff: Expected Obj, but got I4
		//IL_0807: Expected Obj, but got Ref
		//IL_00f8: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I4
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got Ref
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_0667: Expected Obj, but got I4
		//IL_0678: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got Ref
		//IL_02b0: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got Ref
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Invalid comparison between Unknown and I4
		//IL_0135: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_06d7: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got Ref
		//IL_035d: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got Ref
		//IL_0394: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I4
		//IL_03da: Expected Obj, but got I
		//IL_04d3: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I
		//IL_050a: Expected VT, but got Ref
		//IL_0518: Expected Obj, but got I4
		//IL_0520: Expected Obj, but got Ref
		//IL_053b: Expected Obj, but got I4
		//IL_0554: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got I
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0480: Expected Obj, but got I4
		//IL_0488: Expected Obj, but got Ref
		//IL_04a3: Expected Obj, but got I4
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got I4
		Vector3 vector = default;
		object obj = (object)(&vector);
		LagCompensationUtils.BoxNarrowData boxNarrowData = PreComputeNarrowData();
		object obj2 = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		bool flag = candidates == null;
		Vector3 hitPoint = (Vector3)0;
		object obj4 = default;
		object obj3 = obj4;
		ref HitboxCollider reference = ref *(HitboxCollider*)300;
		object obj5 = (object)(&vector);
		HashSet<int> hashSet = candidates;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65E0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
			object obj7 = 0;
			Vector3 hitNormal = default;
			object obj8 = (object)(&hitNormal);
			object obj9 = (object)(&vector);
			Enumerator enumerator = candidates.GetEnumerator();
			List<HitboxHit> list2 = default;
			List<HitboxHit> list = list2;
			hitPoint = (Vector3)0;
			Enumerator val2 = default;
			Enumerator val = (Enumerator)(ref val2);
			Enumerator val3 = default;
			object obj10 = val3;
			reference = ref *(HitboxCollider*)300;
			hashSet = candidates;
			object obj11 = 0;
			bool flag3 = default;
			object obj23 = default;
			bool result = default;
			BoxOverlapQuery boxOverlapQuery = default;
			object obj18;
			while (true)
			{
				obj5 = obj6;
				if (val2.MoveNext())
				{
					if (container != null)
					{
						nint num = (nint)container;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
						val = (Enumerator)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0195;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
						object obj12 = (nint)0 + (nint)8;
						bool flag2 = flag3;
						object obj15;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v15-8]");
							bool flag4 = 0 < (nint)obj7;
							object obj13 = !flag4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v15-8]");
							object obj14 = 0 - obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X10_v15-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v18 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
							val = (Enumerator)(-1);
							bool flag5 = (int)val < 1;
							obj13 = !flag5;
							obj14 = val - 1;
							bool flag6 = obj14 == null;
							obj15 = obj12 + 16;
							flag3 = (int)val != 1;
							flag2 = flag3;
							obj12 = obj15;
							if (flag3)
							{
								continue;
							}
							goto IL_0195;
						}
						val = (Enumerator)(obj12 + 2);
						object obj16 = num + val;
						object obj17 = obj16 + 312;
						flag3 = flag2;
						obj15 = obj12;
						goto IL_07b0;
					}
					NullReferenceException ex = new NullReferenceException();
					break;
				}
				obj3 = 0;
				obj18 = 0;
				val3 = (Enumerator)(ref val2);
				object obj19 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65D8]");
					object obj20 = 0;
					obj5 = obj20;
					((Enumerator*)val3)->Dispose();
					bool flag7 = obj19 == null;
					object obj21 = !flag7;
					list2 = list;
					if (obj21 == null)
					{
						bool flag8 = obj3 == null;
						object obj22 = !flag8;
						list2 = list;
						OutOfMemoryException ex2 = (OutOfMemoryException)val3;
						if (obj22 == null)
						{
							return (byte)(obj11 & 1) != 0;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list = list2;
						obj3 = 1;
						obj19 = obj18;
						obj11 = 1;
						continue;
					}
					if ((nint)obj5 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj19 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list = list2;
					obj18 = obj23;
					obj11 = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A50E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
				IL_07b0:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X0_v35] (should have been resolved before IL gen)");
				bool flag9 = boxOverlapQuery.NarrowPhaseBox(ref *(LagCompensationUtils.BoxNarrowData*)(this + 128), ref *(HitboxCollider*)boxOverlapQuery, computeDetailedInfo: true, out hitPoint, out hitNormal);
				bool flag10 = !flag9;
				list = (List<HitboxHit>)1;
				object obj24 = (object)(&hitNormal);
				nint num2 = (nint)(&hitPoint);
				reference = ref *(HitboxCollider*)boxOverlapQuery;
				hashSet = (HashSet<int>)(object)boxOverlapQuery;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					_ = 0;
					object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref vector, 32));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj15 = boxOverlapQuery + 452;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v37 (Fusion.LagCompensation.BoxOverlapQuery)+1C0]");
					val = (Enumerator)0;
					obj10 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v37 (Fusion.LagCompensation.BoxOverlapQuery)+1B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v37 (Fusion.LagCompensation.BoxOverlapQuery)+1C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					bool flag11 = list2 == null;
					list = (List<HitboxHit>)1;
					obj24 = (object)(&hitNormal);
					num2 = (nint)(&hitPoint);
					vector = hitPoint;
					object obj26 = 0;
					reference = ref *(HitboxCollider*)80;
					obj5 = (object)(&vector);
					hashSet = (HashSet<int>)(object)boxOverlapQuery;
					if (flag11)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6698]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+1C]");
					obj15 = (nint)0 + (nint)1;
					val = (Enumerator)obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
					bool flag12 = (nint)0 == 0;
					list = (List<HitboxHit>)1;
					obj24 = (object)(&hitNormal);
					num2 = (nint)(&hitPoint);
					vector = hitPoint;
					obj26 = 0;
					reference = ref *(HitboxCollider*)80;
					obj5 = (object)(&vector);
					hashSet = (HashSet<int>)(object)boxOverlapQuery;
					if (flag12)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v25+18]");
					bool flag13 = num3 < 0;
					object obj13 = !flag13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v25+18]");
					object obj14 = num4 - 0;
					bool flag6 = obj14 == null;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						object obj29 = (nint)0 * (nint)80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
						hashSet = (HashSet<int>)(0 + obj29);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X3_v2 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						object obj30 = (nint)0 + (nint)1;
						object obj31 = hashSet + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						object obj32 = hashSet + 64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						list = (List<HitboxHit>)1;
						obj24 = (object)(&hitNormal);
						num2 = (nint)(&hitPoint);
						vector = hitPoint;
						obj26 = 0;
						val = (Enumerator)80;
						reference = ref *(HitboxCollider*)80;
						obj11 = 1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X9_v2 (System.Threading.ReaderWriterLockSlim+Enumerator<System.Int32>)+20]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v26+A8]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v27+70]");
						hashSet = (HashSet<int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						list2.AddWithResize((HitboxHit)(&vector));
						list = (List<HitboxHit>)1;
						obj24 = (object)(&hitNormal);
						num2 = (nint)(&hitPoint);
						vector = hitPoint;
						obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v27+70]");
						reference = ref *(HitboxCollider*)null;
						obj11 = 1;
					}
				}
				continue;
				IL_0195:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_07b0;
			}
			NullReferenceException ex3 = new NullReferenceException();
			list2 = list;
			obj3 = 0;
			obj18 = 0;
			val3 = (Enumerator)(ref val2);
		}
		throw new NullReferenceException();
	}

	internal unsafe override void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_06a1: Expected Obj, but got I4
		//IL_06af: Expected Obj, but got I4
		//IL_06c9: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got VT
		//IL_03d5: Expected VT, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_03d5: Expected VT, but got Obj
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Ref, but got Unknown
		//IL_0403: Expected Obj, but got Ref
		//IL_0413: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_00bf: Expected F4, but got VT
		//IL_00bf: Expected VT, but got Obj
		//IL_043c: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got Ref
		//IL_00fd: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got Ref
		//IL_0126: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I
		//IL_04c5: Expected Obj, but got I
		//IL_0151: Expected Obj, but got Ref
		//IL_0501: Expected Obj, but got I
		//IL_051f: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I4
		//IL_0619: Expected Obj, but got I
		//IL_0629: Expected Obj, but got I
		//IL_0640: Expected VT, but got Ref
		//IL_0650: Expected VT, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_0596: Expected Obj, but got I
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05c1: Expected Obj, but got I
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_0604: Expected VT, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		//IL_032a: Expected VT, but got Ref
		//IL_033a: Expected VT, but got I
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02ee: Expected VT, but got I4
		PhysicsScene physicsScene = default;
		object obj = (object)(&physicsScene);
		obj = 0;
		object obj2 = options & (HitOptions)1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		object obj6 = default;
		object obj24 = default;
		if (obj3 == null)
		{
			object obj4 = options & (HitOptions)2;
			if (obj4 == null)
			{
				return;
			}
			Quaternion.Internal_ToAxisAngleRad(ref *(Quaternion*)(this + 96), out Vector3 _, out float angle);
			float num = angle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			float num2 = num * 0f;
			if ((object)runner != null)
			{
				PhysicsScene2D physicsScene2D = runner.GetPhysicsScene2D();
				Vector2 layerMask = (Vector2)LayerMask;
				PhysicsScene2D physicsScene2D2 = default;
				IntPtr intPtr = default;
				int num3 = physicsScene2D2.OverlapBox((Vector2)_box2DOverlapHits, (Vector2)LayerMask, (float)Center, null, (int)(nint)intPtr);
				if (num3 < 1)
				{
					return;
				}
				object obj5 = (object)(&obj6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66A8]");
				object obj7 = 0;
				object obj8 = 0;
				while (true)
				{
					Collider2D[] box2DOverlapHits = _box2DOverlapHits;
					if (_box2DOverlapHits == null)
					{
						break;
					}
					bool flag2 = (nint)obj8 < box2DOverlapHits.Length;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						object obj10 = (object)_box2DOverlapHits + obj8;
						object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 88));
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v18+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v18+20]");
						GameObject gameObject = ((Component)0).gameObject;
						object obj12 = (nint)(&obj6) | (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						if (hits == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						object obj13 = 0;
						object obj14 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v19+18]");
						bool flag3 = num4 < 0;
						object obj16 = !flag3;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
							object obj17 = (nint)0 * (nint)104;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
							object obj18 = 0 + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
							object obj19 = (nint)0 + (nint)1;
							object obj20 = obj18 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
							object obj21 = obj18 + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							layerMask = (Vector2)104;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v9+20]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v21+A8]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							hits.AddWithResize((LagCompensatedHit)(&obj24));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v22+70]");
							layerMask = (Vector2)0;
						}
						obj8++;
						if (num3 == (nint)obj8)
						{
							return;
						}
						continue;
					}
					goto IL_0691;
				}
			}
		}
		else if ((object)runner != null)
		{
			PhysicsScene physicsScene2 = runner.GetPhysicsScene();
			Vector3 layerMask2 = (Vector3)LayerMask;
			obj = physicsScene2;
			int layerMask3 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			int num5 = physicsScene.OverlapBox((Vector3)_physXOverlapHits, (Vector3)LayerMask, (Collider[])TriggerInteraction, (Quaternion)0, layerMask3, queryTriggerInteraction);
			if (num5 < 1)
			{
				return;
			}
			object obj25 = (object)(&obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66A8]");
			object obj26 = 0;
			object obj27 = 0;
			while (true)
			{
				Collider[] physXOverlapHits = _physXOverlapHits;
				if (_physXOverlapHits == null)
				{
					break;
				}
				bool flag4 = (nint)obj27 < physXOverlapHits.Length;
				object obj28 = !flag4;
				if (obj28 == null)
				{
					object obj29 = (object)_physXOverlapHits + obj27;
					object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 80));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v9+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v9+20]");
					GameObject gameObject2 = ((Component)0).gameObject;
					object obj31 = (nint)(&obj6) | (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (hits == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					object obj32 = 0;
					object obj33 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
					object obj34 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v10+18]");
					bool flag5 = num6 < 0;
					object obj35 = !flag5;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						object obj36 = (nint)0 * (nint)104;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
						object obj37 = 0 + obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
						object obj38 = (nint)0 + (nint)1;
						object obj39 = obj37 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						object obj40 = obj37 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						layerMask2 = (Vector3)104;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v6+20]");
						object obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v12+A8]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						hits.AddWithResize((LagCompensatedHit)(&obj24));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v13+70]");
						layerMask2 = (Vector3)0;
					}
					obj27++;
					if (num5 == (nint)obj27)
					{
						return;
					}
					continue;
				}
				goto IL_0691;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0691;
		IL_0691:
		throw new IndexOutOfRangeException();
	}

	internal unsafe bool NarrowPhaseBox(ref LagCompensationUtils.BoxNarrowData boxQueryNarrowData, ref HitboxCollider c, bool computeDetailedInfo, out Vector3 hitPoint, out Vector3 hitNormal)
	{
		//IL_02fa: Invalid comparison between VT and I4
		//IL_019e: Expected VT, but got Ref
		//IL_0013: Invalid comparison between VT and I4
		//IL_01ce: Expected VT, but got Ref
		//IL_00b4: Expected VT, but got Ref
		//IL_00b4: Expected VT, but got I4
		//IL_00c5: Expected VT, but got Ref
		//IL_01f4: Expected Obj, but got I
		//IL_0215: Expected VT, but got Ref
		//IL_0237: Expected VT, but got I4
		//IL_0237: Expected VT, but got Ref
		//IL_0237: Expected VT, but got I4
		//IL_0237: Expected VT, but got Ref
		//IL_00ec: Expected F4, but got I
		//IL_00ec: Expected VT, but got I4
		//IL_00ec: Expected VT, but got Ref
		//IL_0035: Invalid comparison between VT and I4
		//IL_011b: Expected VT, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_0133: Unsupported input type for neg.
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_014e: Unsupported input type for neg.
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I4
		//IL_016d: Expected VT, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_026b: Expected VT, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		//IL_02bb: Expected VT, but got I4
		object obj = default;
		object obj4 = default;
		object obj6;
		object obj7 = default;
		Vector3 vec;
		ref Vector3 reference;
		if (c != (HitboxCollider)(object)3)
		{
			if (c != (HitboxCollider)(object)2)
			{
				if (c == (HitboxCollider)(object)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66A0]");
					object error = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X2 (Fusion.LagCompensation.HitboxCollider&)+1B4]");
					Assert.Check(condition: false, (string)error);
					return LagCompensationUtils.NarrowBoxBox(ref boxQueryNarrowData, ref System.Runtime.CompilerServices.Unsafe.As<HitboxCollider, LagCompensationUtils.BoxNarrowData>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref c, 136)), computeDetailedInfo, out hitPoint, out hitNormal);
				}
			}
			else
			{
				Vector3 vector = (Quaternion)0 * (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxQueryNarrowData);
				Vector3 vector2 = boxQueryNarrowData.WorldToLocalVector((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxQueryNarrowData));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxQueryNarrowData @ X1 (BoxNarrowData&)+C]");
				if (LagCompensationUtils.LocalAABBSphereContact((Vector3)(&obj), (Vector3)0, 0f, out System.Runtime.CompilerServices.Unsafe.As<HitboxCollider, SnapshotHistoryDraw.ContactData>(ref c)))
				{
					Vector3 vector3 = boxQueryNarrowData.LocalToWorldVector((Vector3)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxQueryNarrowData @ X1 (BoxNarrowData&)+8]");
					object obj2 = 0;
					object obj3 = 0 - obj4;
					object obj5 = obj + boxQueryNarrowData;
					obj6 = 0 - obj7;
					reference = ref *(Vector3*)obj5;
					object obj8 = 0;
					vec = (Vector3)0;
					goto IL_030e;
				}
			}
		}
		else
		{
			Matrix4x4 localToWorld = c.LocalToWorld;
			Vector3 capsuleLocalTopCenter = c.CapsuleLocalTopCenter;
			Vector3 vector4 = boxQueryNarrowData.WorldToLocalVector((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxQueryNarrowData));
			Matrix4x4 localToWorld2 = c.LocalToWorld;
			Vector3 capsuleLocalBottomCenter = c.CapsuleLocalBottomCenter;
			Vector3 vector5 = boxQueryNarrowData.WorldToLocalVector((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxQueryNarrowData));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X2 (Fusion.LagCompensation.HitboxCollider&)+1B8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X2 (Fusion.LagCompensation.HitboxCollider&)+48]");
			object obj9 = num + 0;
			float capsuleRadius = (float)obj9 - (float)boxQueryNarrowData;
			Vector3 vector6 = boxQueryNarrowData.WorldToLocalVector((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref boxQueryNarrowData));
			if (LagCompensationUtils.LocalAABBCapsuleIntersection((Vector3)(&obj), (Vector3)0, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref c), capsuleRadius, (Vector3)computeDetailedInfo, out System.Runtime.CompilerServices.Unsafe.As<Vector3, SnapshotHistoryDraw.ContactData>(ref hitPoint)))
			{
				Vector3 vector7 = boxQueryNarrowData.LocalToWorldVector((Vector3)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boxQueryNarrowData @ X1 (BoxNarrowData&)+8]");
				object obj2 = 0;
				object obj10 = obj + boxQueryNarrowData;
				reference = ref *(Vector3*)obj10;
				object obj3 = obj4;
				object obj8 = 0;
				obj6 = obj7;
				vec = (Vector3)0;
				goto IL_030e;
			}
		}
		_ = 0;
		reference = ref *(Vector3*)null;
		_ = 0;
		ref Vector3 reference2 = ref *(Vector3*)null;
		return false;
		IL_030e:
		Vector3 vector8 = boxQueryNarrowData.LocalToWorldVector(vec);
		reference2 = ref *(Vector3*)obj6;
		return true;
	}

	internal LagCompensationUtils.BoxNarrowData PreComputeNarrowData()
	{
		//IL_0069: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I
		//IL_010a: Expected VT, but got I4
		//IL_0113: Expected VT, but got I4
		//IL_0022: Expected VT, but got I4
		//IL_002b: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+A0]");
		object obj3 = 0;
		object obj4 = Rotation * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BoxOverlapQuery)+68]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6+8]");
		object obj5 = num * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj7 = default;
		object obj6 = obj4 + obj7;
		object obj8 = obj5 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj9 = obj5 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
		bool flag = (nint)obj9 <= 0;
		Quaternion rot = (Quaternion)300;
		Vector3 pos = (Vector3)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			rot = (Quaternion)300;
			pos = (Vector3)0;
		}
		Vector3 extents = default;
		LagCompensationUtils.BoxNarrowData boxNarrowData = new LagCompensationUtils.BoxNarrowData(pos, rot, extents);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		LagCompensationUtils.BoxNarrowData result = default;
		return result;
	}
}
