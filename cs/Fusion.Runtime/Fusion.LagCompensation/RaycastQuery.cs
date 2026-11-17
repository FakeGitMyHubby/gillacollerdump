using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

[Serializable]
public class RaycastQuery : Query
{
	public Vector3 Direction;

	public Vector3 Origin;

	public float Length;

	private RaycastHit _raycastHit;

	private RaycastHit2D _raycastHit2D;

	public RaycastQuery(ref RaycastQueryParams raycastQueryParams)
		: base(ref System.Runtime.CompilerServices.Unsafe.As<RaycastQueryParams, QueryParams>(ref raycastQueryParams))
	{
		//IL_0029: Expected VT, but got I
		//IL_0048: Expected VT, but got I
		//IL_005a: Expected F4, but got I
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
	}

	protected override bool Check(ref AABB bounds)
	{
		//IL_0012: Invalid comparison between VT and I
		//IL_0059: Invalid comparison between VT and I
		//IL_0097: Expected F8, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_0039: Expected F8, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_0080: Expected F8, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_00f4: Invalid comparison between F8 and I4
		//IL_0103: Invalid comparison between F8 and I4
		//IL_0126: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_00b5: Expected F8, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_0905: Expected Obj, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_0234: Invalid comparison between F8 and I4
		//IL_0243: Invalid comparison between F8 and I4
		//IL_0266: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_0942: Expected Obj, but got I4
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_01fe: Expected F8, but got I
		//IL_0207: Expected Obj, but got I4
		//IL_01e9: Expected F8, but got I
		//IL_097f: Expected Obj, but got I4
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_09a5: Expected Obj, but got I4
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I4
		//IL_0323: Invalid comparison between VT and I4
		//IL_0334: Expected Obj, but got I4
		//IL_01d4: Expected F8, but got I4
		//IL_030d: Expected F8, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected Obj, but got Unknown
		//IL_02f8: Expected F8, but got I4
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected Obj, but got Unknown
		//IL_0a24: Expected Obj, but got I4
		//IL_0bb1: Expected Obj, but got I4
		//IL_039b: Expected Obj, but got I4
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Expected Obj, but got Unknown
		//IL_0a67: Expected Obj, but got I4
		//IL_0bea: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I4
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected Obj, but got Unknown
		//IL_0aaa: Expected Obj, but got I4
		//IL_0add: Invalid comparison between F8 and I4
		//IL_0aee: Expected Obj, but got I4
		//IL_0b0e: Invalid comparison between F8 and I4
		//IL_05ea: Invalid comparison between F8 and I4
		//IL_05fb: Expected Obj, but got I4
		//IL_0b6f: Expected Obj, but got I4
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Expected Obj, but got Unknown
		//IL_0632: Invalid comparison between F8 and I4
		//IL_0641: Invalid comparison between F8 and I4
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0669: Expected Obj, but got F8
		//IL_04db: Invalid comparison between F8 and I4
		//IL_04ec: Expected Obj, but got I4
		//IL_0b3b: Expected Obj, but got I4
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected Obj, but got Unknown
		//IL_0523: Invalid comparison between F8 and I4
		//IL_0532: Invalid comparison between F8 and I4
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_055a: Expected Obj, but got F8
		//IL_084d: Expected Obj, but got I4
		//IL_0865: Invalid comparison between F8 and I4
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected I4, but got Unknown
		//IL_074d: Invalid comparison between F8 and I
		//IL_077a: Invalid comparison between F8 and I
		Vector3 origin = Origin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+18]");
		double num;
		object obj;
		if (origin < (object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+18]");
			num = 0.0;
			obj = 0;
		}
		else
		{
			Vector3 origin2 = Origin;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+24]");
			if (origin2 > (object)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+24]");
				num = 0.0;
				obj = 0;
			}
			else
			{
				num = 0.0;
				obj = 1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+1C]");
		double num3;
		object obj2;
		object obj3;
		if (num2 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+1C]");
			num3 = 0.0;
			obj2 = 0;
			obj3 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
			double num4 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
			double num5 = num4 - 0.0;
			bool flag = num5 < 0.0;
			bool flag2 = num5 == 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
			object obj4 = num6 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
			object obj5 = 0 ^ num5;
			object obj6 = obj4 & obj5;
			bool flag3 = (nint)obj6 < 0;
			bool flag4 = flag == flag3;
			object obj7 = !flag4;
			object obj8 = obj7 | flag2;
			object obj9 = ~obj8;
			obj3 = ((obj9 != null) ? ((object)0) : ((object)1));
			bool flag5 = flag == flag3;
			object obj10 = !flag5;
			object obj11 = obj10 | flag2;
			object obj12 = ~obj11;
			obj2 = ((obj12 != null) ? ((object)0) : obj);
			bool flag6 = flag == flag3;
			object obj13 = !flag6;
			object obj14 = obj13 | flag2;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				num3 = 0.0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
				num3 = 0.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+20]");
		double num8;
		object obj16;
		if (num7 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+20]");
			num8 = 0.0;
			obj16 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
			double num9 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+2C]");
			double num10 = num9 - 0.0;
			bool flag7 = num10 < 0.0;
			bool flag8 = num10 == 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+2C]");
			object obj17 = num11 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
			object obj18 = 0 ^ num10;
			object obj19 = obj17 & obj18;
			bool flag9 = (nint)obj19 < 0;
			bool flag10 = flag7 == flag9;
			object obj20 = !flag8;
			object obj21 = flag10 & obj20;
			object obj22 = ~obj21;
			object obj23 = ((obj22 != null) ? obj2 : ((object)0));
			bool flag11 = flag7 == flag9;
			object obj24 = !flag11;
			object obj25 = obj24 | flag8;
			bool flag12 = flag7 == flag9;
			object obj26 = !flag12;
			object obj27 = obj26 | flag8;
			object obj28 = ~obj27;
			if (obj28 == null)
			{
				num8 = 0.0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+2C]");
				num8 = 0.0;
			}
			object obj29 = obj23 & 1;
			bool flag13 = obj29 == null;
			obj16 = obj25;
			if (!flag13)
			{
				return true;
			}
		}
		bool flag14 = Direction == (Vector3)(object)0;
		object obj30 = !flag14;
		object obj31 = ~obj30;
		if (obj31 != null)
		{
			obj = 1;
		}
		object obj32 = obj & 1;
		bool flag15 = obj32 == null;
		object obj33 = !flag15;
		double num12 = -1.0;
		if (obj33 == null)
		{
			double num13 = num - (double)Origin;
			num12 = num13 / (double)Direction;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+4C]");
		bool flag16 = (nint)0 == 0;
		object obj34 = !flag16;
		object obj35 = ~obj34;
		object obj36 = ((obj35 != null) ? ((object)1) : obj3);
		object obj37 = obj36 & 1;
		bool flag17 = obj37 == null;
		object obj38 = !flag17;
		double num14 = -1.0;
		if (obj38 == null)
		{
			double num15 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
			double num16 = num15 - 0.0;
			double num17 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+4C]");
			num14 = num17 / 0.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+50]");
		bool flag18 = (nint)0 == 0;
		object obj39 = !flag18;
		object obj40 = ~obj39;
		object obj41 = ((obj40 != null) ? ((object)1) : obj16);
		object obj42 = obj41 & 1;
		bool flag19 = obj42 == null;
		object obj43 = !flag19;
		double num18 = -1.0;
		if (obj43 == null)
		{
			double num19 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
			double num20 = num19 - 0.0;
			double num21 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+50]");
			num18 = num21 / 0.0;
		}
		double num22 = ((!(num12 < num14)) ? num12 : num14);
		double num23 = num22 - num18;
		bool flag20 = num23 < 0.0;
		object obj44 = !flag20;
		object obj45 = ~obj44;
		double num24 = ((obj45 != null) ? num18 : num22);
		double num31;
		if (!(num24 < 0.0))
		{
			if (num22 < num18 || num12 < num14)
			{
				double num25 = (double)Direction * num24;
				num = (double)Origin + num25;
				double num26 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+18]");
				double num27 = num26 - 0.0;
				bool flag21 = num27 < 0.0;
				object obj46 = !flag21;
				object obj47 = ~obj46;
				bool flag22;
				bool flag23;
				bool flag24;
				if (obj47 == null)
				{
					double num28 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+24]");
					double num29 = num28 - 0.0;
					flag22 = num29 < 0.0;
					flag23 = num29 == 0.0;
					double num30 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+24]");
					object obj48 = num30 ^ 0;
					object obj49 = num ^ num29;
					object obj50 = obj48 & obj49;
					flag24 = (nint)obj50 < 0;
				}
				else
				{
					flag24 = false;
					flag23 = false;
					flag22 = false;
				}
				bool flag25 = flag22 == flag24;
				object obj51 = !flag25;
				object obj52 = obj51 | flag23;
				if (obj52 == null)
				{
					goto IL_06aa;
				}
				if (num12 < num14)
				{
					bool flag26 = num22 < num18;
					num31 = num;
					if (!flag26)
					{
						goto IL_06f3;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+4C]");
			double num32 = 0.0 * num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
			num3 = 0.0 + num32;
			double num33 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+1C]");
			double num34 = num33 - 0.0;
			bool flag27 = num34 < 0.0;
			object obj53 = !flag27;
			object obj54 = ~obj53;
			bool flag28;
			bool flag29;
			bool flag30;
			if (obj54 == null)
			{
				double num35 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
				double num36 = num35 - 0.0;
				flag28 = num36 < 0.0;
				flag29 = num36 == 0.0;
				double num37 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+28]");
				object obj55 = num37 ^ 0;
				object obj56 = num3 ^ num36;
				object obj57 = obj55 & obj56;
				flag30 = (nint)obj57 < 0;
			}
			else
			{
				flag30 = false;
				flag29 = false;
				flag28 = false;
			}
			bool flag31 = flag28 == flag30;
			object obj58 = !flag29;
			object obj59 = flag31 & obj58;
			if (obj59 == null)
			{
				num31 = num;
				goto IL_06f3;
			}
		}
		goto IL_06aa;
		IL_06aa:
		return false;
		IL_0b8a:
		bool result;
		return result;
		IL_0797:
		double num38 = (double)Origin - num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
		double num39 = 0.0 - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
		double num40 = 0.0 - num8;
		double num41 = num38 * num38;
		double num42 = num39 * num39;
		double num43 = num41 + num42;
		double num44 = num40 * num40;
		float num45 = Length * Length;
		double num46 = num43 + num44;
		bool flag32 = num46 < (double)num45;
		object obj60 = !flag32;
		double num47 = num46 - (double)num45;
		bool flag33 = num47 == 0.0;
		object obj61 = ~obj60;
		bool flag34 = (byte)((obj61 | flag33) ? 1 : 0) != 0;
		result = flag34;
		goto IL_0b8a;
		IL_06f3:
		if (num22 < num18)
		{
			goto IL_0797;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+50]");
		double num48 = 0.0 * num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
		num8 = 0.0 + num48;
		double num49 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+20]");
		bool flag35 = num49 < 0.0;
		result = false;
		if (!flag35)
		{
			double num50 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (Fusion.LagCompensation.AABB&)+2C]");
			bool flag36 = num50 > 0.0;
			result = false;
			if (!flag36)
			{
				goto IL_0797;
			}
		}
		goto IL_0b8a;
	}

	internal unsafe override bool NarrowPhase(IHitboxColliderContainer container, HashSet<int> candidates, List<HitboxHit> hits)
	{
		//IL_0010: Expected VT, but got I
		//IL_0617: Expected VT, but got I4
		//IL_0628: Expected Obj, but got I4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected VT, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Ref
		//IL_00a6: Expected VT, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Expected VT, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got I4
		//IL_037e: Expected VT, but got I4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected Ref, but got Unknown
		//IL_07a8: Expected Obj, but got I4
		//IL_04fb: Expected VT, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got I4
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Invalid comparison between VT and I4
		//IL_03ca: Expected Obj, but got I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected VT, but got Obj
		//IL_06a3: Expected Obj, but got I
		//IL_06b3: Expected Obj, but got I
		//IL_06da: Expected F4, but got VT
		//IL_06da: Expected VT, but got Ref
		//IL_06da: Expected VT, but got Ref
		//IL_06fd: Expected Obj, but got Ref
		//IL_0705: Expected Obj, but got Ref
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04cf: Expected Obj, but got I4
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected VT, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_058d: Expected VT, but got I4
		//IL_059e: Expected VT, but got I4
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected I4, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got VT
		//IL_0265: Expected Obj, but got Ref
		//IL_026d: Expected Obj, but got Ref
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between Unknown and I4
		//IL_02a7: Expected Obj, but got Ref
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected VT, but got I
		//IL_0323: Expected Obj, but got F4
		//IL_033c: Expected VT, but got Ref
		//IL_0360: Expected Obj, but got I4
		//IL_0368: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEF25]");
		Vector3 vector = (Vector3)0;
		bool flag = hits == null;
		Vector3 point = (Vector3)0;
		List<HitboxHit> list = hits;
		object obj = 0;
		Enumerator val = (Enumerator)0;
		if (!flag)
		{
			HashSet<int> hashSet = default;
			bool flag2 = hashSet == null;
			point = (Vector3)0;
			list = hits;
			obj = 0;
			val = (Enumerator)0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65E0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65D8]");
				object obj4 = 0;
				Enumerator enumerator = hashSet.GetEnumerator();
				object obj6 = default;
				object obj5 = (object)(&obj6);
				point = (Vector3)0;
				list = hits;
				obj = 0;
				Vector3 vector2 = (Vector3)2139095039;
				Enumerator val2 = (Enumerator)(ref val);
				Enumerator val4 = default;
				Enumerator val3 = val4;
				vector = (Vector3)2139095039;
				bool flag4 = default;
				object obj11 = default;
				object obj23 = default;
				bool result = default;
				RaycastQuery raycastQuery = default;
				object obj26 = default;
				ref Vector3 normal = default;
				ref float distance = default;
				object obj28 = default;
				Vector3 vector3;
				object obj12;
				Enumerator val5;
				IHitboxColliderContainer hitboxColliderContainer = default;
				while (true)
				{
					if (val.MoveNext())
					{
						if (hitboxColliderContainer == null)
						{
							break;
						}
						nint num = (nint)hitboxColliderContainer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v19 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
						val2 = (Enumerator)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v19 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01d4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v19 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
						object obj7 = (nint)0 + (nint)8;
						bool flag3 = flag4;
						object obj9;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v11-8]");
							object obj8 = 0 - obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X10_v11-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v19 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
							val2 = (Enumerator)(-1);
							obj8 = val2 - 1;
							bool flag5 = obj8 == null;
							obj9 = obj7 + 16;
							flag4 = (int)val2 != 1;
							flag3 = flag4;
							obj7 = obj9;
							if (flag4)
							{
								continue;
							}
							goto IL_01d4;
						}
						val2 = (Enumerator)(obj7 + 2);
						object obj10 = num + val2;
						obj11 = obj10 + 312;
						flag4 = flag3;
						obj9 = obj7;
						goto IL_0681;
					}
					vector3 = (Vector3)0;
					val = val4;
					obj12 = 0;
					val5 = (Enumerator)(ref val);
					object obj13 = 6;
					object obj14 = 0;
					while (true)
					{
						hitboxColliderContainer = (IHitboxColliderContainer)obj4;
						((Enumerator*)val5)->Dispose();
						bool flag6 = obj14 == null;
						object obj15 = !flag6;
						Vector3 vector4;
						if (obj15 == null)
						{
							bool flag7 = vector3 == (Vector3)(object)0;
							object obj16 = !flag7;
							OutOfMemoryException ex = (OutOfMemoryException)val5;
							if (obj16 == null)
							{
								if ((nint)obj13 != 6)
								{
									bool flag8 = obj13 == null;
									object obj17 = !flag8;
									vector4 = vector3;
									if (obj17 != null)
									{
										goto IL_0747;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								object obj18 = num2 - 0;
								bool flag9 = (nint)obj18 < 0;
								bool flag10 = obj18 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								object obj19 = num3 ^ 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
								object obj20 = 0 ^ obj18;
								object obj21 = obj19 & obj20;
								bool flag11 = (nint)obj21 < 0;
								bool flag12 = flag9 == flag11;
								object obj22 = !flag10;
								Vector3 vector5 = (Vector3)(flag12 & obj22);
								vector4 = vector5;
								goto IL_0747;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)hitboxColliderContainer == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							vector3 = (Vector3)1;
							obj14 = obj12;
							vector = (Vector3)1;
						}
						else
						{
							if ((nint)hitboxColliderContainer != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj14 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj12 = obj23;
						}
						obj13 = 0;
						continue;
						IL_0747:
						return (byte)(vector4 & 1) != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A50E0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return result;
					IL_01d4:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_0681;
					IL_0681:
					vector = (Vector3)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v585 @ X0_v30] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+58]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+5C]");
					object obj25 = 0;
					bool flag13 = raycastQuery.NarrowPhaseRay(ref *(HitboxCollider*)raycastQuery, (Vector3)(&obj), (Vector3)(&obj26), (float)Origin, out point, out normal, out distance);
					bool flag14 = !flag13;
					nint num4 = (nint)(&point);
					list = (List<HitboxHit>)(&obj26);
					hashSet = (HashSet<int>)(&obj);
					val3 = (Enumerator)Origin;
					if (!flag14)
					{
						object obj8 = point - vector2;
						bool flag5 = obj8 == null;
						flag4 = point >= vector2;
						num4 = (nint)(&point);
						list = (List<HitboxHit>)(&obj26);
						hashSet = (HashSet<int>)(&obj);
						val3 = (Enumerator)Origin;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
							object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 32));
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj9 = raycastQuery + 452;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v32 (Fusion.LagCompensation.RaycastQuery)+1C0]");
							val2 = (Enumerator)0;
							val3 = (Enumerator)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v32 (Fusion.LagCompensation.RaycastQuery)+1B8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v32 (Fusion.LagCompensation.RaycastQuery)+1C0]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66E0]");
							list = (List<HitboxHit>)((Vector3)0).x;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
							hits.Insert(0, (HitboxHit)(&val4));
							num4 = (nint)(&point);
							obj6 = obj;
							obj24 = obj28;
							obj25 = 0;
							hashSet = (HashSet<int>)(&val4);
							vector2 = point;
						}
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				vector3 = (Vector3)0;
				val = val4;
				obj12 = 0;
				val5 = (Enumerator)(ref val);
				hitboxColliderContainer = (IHitboxColliderContainer)obj2;
			}
		}
		throw new NullReferenceException();
	}

	internal unsafe override void PerformStaticQuery(NetworkRunner runner, List<LagCompensatedHit> hits, HitOptions options)
	{
		//IL_038e: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected VT, but got Unknown
		//IL_01dc: Expected F4, but got I
		//IL_020e: Expected F4, but got VT
		//IL_0013: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_025e: Expected VT, but got I
		//IL_0267: Expected VT, but got Ref
		//IL_0038: Expected Obj, but got Ref
		//IL_005f: Expected VT, but got I
		//IL_0087: Expected F4, but got VT
		//IL_0087: Expected VT, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected VT, but got Unknown
		//IL_00a5: Expected VT, but got Obj
		//IL_00c0: Expected Ref, but got VT
		//IL_00d4: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I4
		//IL_0373: Expected VT, but got Ref
		//IL_02f8: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I
		//IL_0169: Expected VT, but got Ref
		//IL_0187: Expected Obj, but got I4
		object obj = options & (HitOptions)1;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj5 = default;
		if (obj2 == null)
		{
			object obj3 = options & (HitOptions)2;
			if (obj3 == null)
			{
				return;
			}
			object obj4 = (object)(&obj5);
			PhysicsScene2D physicsScene2D = runner.GetPhysicsScene2D();
			Vector3 direction = Direction;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+4C]");
			Vector3 vector = (Vector3)0;
			float length = Length;
			PhysicsScene2D physicsScene2D2 = default;
			RaycastHit2D raycastHit2D = physicsScene2D2.Raycast((Vector2)LayerMask, (Vector2)0, (float)Origin, (int)options);
			RaycastHit2D raycastHit2D2 = (RaycastHit2D)(this + 152);
			_raycastHit2D = (RaycastHit2D)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X22_v6+10]");
			_ = 0;
			Collider2D collider = ((RaycastHit2D*)raycastHit2D2)->collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(collider != null))
			{
				return;
			}
			RaycastHit raycastHit2D3 = (RaycastHit)_raycastHit2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+A8]");
			object obj9 = 0;
			object obj10 = default;
			LagCompensatedHit lagCompensatedHit = (LagCompensatedHit)(RaycastHit2D)(&obj10);
			bool flag3 = hits == null;
			object obj11 = !flag3;
			ref RaycastHit reference = ref *(RaycastHit*)(int)options;
			IntPtr intPtr = default;
			int num = (int)(nint)intPtr;
			if (obj11 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			PhysicsScene physicsScene = runner.GetPhysicsScene();
			Vector3 origin = (Vector3)(this + 104);
			Vector3 vector = Direction;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+4C]");
			float length = 0f;
			ref RaycastHit reference = ref *(RaycastHit*)(int)TriggerInteraction;
			PhysicsScene physicsScene2 = default;
			QueryTriggerInteraction queryTriggerInteraction = default;
			if (!physicsScene2.Raycast(origin, (Vector3)LayerMask, out *(RaycastHit*)(int)TriggerInteraction, (float)Origin, 0, queryTriggerInteraction))
			{
				return;
			}
			RaycastHit raycastHit2D3 = _raycastHit;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+78]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.RaycastQuery)+88]");
			Vector3 direction = (Vector3)0;
			object obj12 = default;
			LagCompensatedHit lagCompensatedHit2 = (LagCompensatedHit)(RaycastHit)(&obj12);
			int num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
		object obj14 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6+18]");
		bool flag4 = num2 < 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			object obj16 = (nint)0 * (nint)104;
			object obj17 = obj13 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			object obj18 = (nint)0 + (nint)1;
			object obj19 = obj17 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			object obj20 = obj17 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			hits.AddWithResize((LagCompensatedHit)(&obj5));
		}
	}

	internal unsafe bool NarrowPhaseRay(ref HitboxCollider c, Vector3 origin, Vector3 direction, float length, out Vector3 point, out Vector3 normal, out float distance)
	{
		//IL_000e: Invalid comparison between VT and I4
		//IL_0030: Invalid comparison between VT and I4
		//IL_02b3: Expected VT, but got Ref
		//IL_02d6: Expected Obj, but got I4
		//IL_0052: Invalid comparison between VT and I4
		//IL_077b: Expected Obj, but got I
		//IL_07a5: Expected Obj, but got I4
		//IL_0569: Expected native int or pointer, but got VT
		//IL_0577: Expected native int or pointer, but got VT
		//IL_0585: Expected native int or pointer, but got VT
		//IL_0593: Expected native int or pointer, but got VT
		//IL_0738: Expected VT, but got I4
		//IL_0738: Expected VT, but got Ref
		//IL_00c6: Expected Ref, but got VT
		//IL_00c6: Expected Ref, but got VT
		//IL_05b7: Expected native int or pointer, but got VT
		//IL_05c4: Expected native int or pointer, but got VT
		//IL_067b: Expected native int or pointer, but got VT
		//IL_0688: Expected native int or pointer, but got VT
		Matrix4x4 m = default;
		object obj2 = default;
		object obj3 = default;
		object obj4 = default;
		object obj5 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		float num20 = default;
		object obj20 = default;
		float x;
		double num22;
		float num23 = default;
		object obj50 = default;
		if (c != (HitboxCollider)(object)3)
		{
			if (c != (HitboxCollider)(object)2)
			{
				if (c == (HitboxCollider)(object)1)
				{
					Matrix4x4 localToWorld = c.LocalToWorld;
					Matrix4x4 matrix4x = Matrix4x4.Internal_Inverse(ref m);
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					object obj = default;
					float sqrMaxdistance = (float)obj * (float)obj;
					Vector3 minB = default;
					Vector3 maxB = default;
					Vector3 origin2 = default;
					Vector3 dir = default;
					if (LagCompensationUtils.RayAABB(ref minB, ref maxB, ref origin2, ref dir, sqrMaxdistance, out *(Vector3*)origin, out *(Vector3*)direction, out System.Runtime.CompilerServices.Unsafe.As<Vector3, float>(ref point)))
					{
						Matrix4x4 localToWorld2 = c.LocalToWorld;
						float num = origin.x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+48]");
						float num2 = num + 0f;
						float num3 = origin.y;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+4C]");
						float num4 = num3 + 0f;
						float num5 = origin.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (Fusion.LagCompensation.HitboxCollider&)+50]");
						float num6 = num5 + 0f;
						float num7 = num2 * (float)obj2;
						float num8 = num4 * (float)obj3;
						float num9 = num7 + num8;
						float num10 = num6 * (float)obj4;
						float num11 = num9 + num10;
						float num12 = (float)obj5 + num11;
						object obj7 = default;
						object obj6 = obj7 * obj8;
						object obj9 = obj10 * obj11;
						float num13 = num2 * (float)obj12;
						float num14 = num4 * (float)obj13;
						object obj14 = obj15 * obj16;
						double num15 = 1.0 / (double)num12;
						object obj17 = obj6 + obj9;
						float num16 = num6 * (float)obj18;
						float num17 = num13 + num14;
						object obj19 = obj17 + obj14;
						float num18 = num17 + num16;
						float num19 = num20 + (float)obj19;
						float num21 = (float)obj20 + num18;
						object obj21 = default;
						x = num19 * (float)obj21;
						num22 = (double)num21 * num15;
						goto IL_05af;
					}
				}
			}
			else
			{
				Matrix4x4 localToWorld3 = c.LocalToWorld;
				bool flag = LagCompensationUtils.RaySphereIntersection(origin, direction, length, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref point), num23, out *(Vector3*)null, out point, out System.Runtime.CompilerServices.Unsafe.As<Vector3, float>(ref normal));
				bool flag2 = !flag;
				object obj22 = !flag2;
				if (obj22 != null)
				{
					goto IL_0692;
				}
			}
		}
		else
		{
			Matrix4x4 localToWorld4 = c.LocalToWorld;
			Matrix4x4 matrix4x2 = Matrix4x4.Internal_Inverse(ref m);
			object obj23 = default;
			float num24 = length * (float)obj23;
			object obj24 = default;
			float num25 = num23 * (float)obj24;
			object obj26 = default;
			object obj27 = default;
			object obj25 = obj26 * obj27;
			float num26 = num24 + num25;
			object obj28 = default;
			float num27 = num23 * (float)obj28;
			object obj30 = default;
			object obj31 = default;
			object obj29 = obj30 * obj31;
			object obj33 = default;
			object obj32 = obj10 * obj33;
			object obj34 = default;
			float num28 = length * (float)obj34;
			object obj36 = default;
			object obj35 = obj30 * obj36;
			float num29 = num26 + (float)obj25;
			float maxDistance = num28 + num27;
			object obj37 = default;
			float num30 = num29 + (float)obj37;
			object obj38 = obj10 * obj8;
			Vector3 capsuleLocalTopCenter = c.CapsuleLocalTopCenter;
			Vector3 capsuleLocalBottomCenter = c.CapsuleLocalBottomCenter;
			double num31 = 1.0 / (double)num30;
			object obj39 = obj35 + obj38;
			object obj40 = obj15 * obj8;
			object obj41 = obj39 + obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj44 = !flag3;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if ((nint)obj10 > 0)
			{
			}
			if (LagCompensationUtils.LocalRayCapsuleIntersection(origin, direction, num20, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref point), (Vector3)0, maxDistance, out point, out normal, out distance))
			{
				Matrix4x4 localToWorld5 = c.LocalToWorld;
				float num32 = origin.x * (float)obj2;
				float num33 = origin.y * (float)obj3;
				float num34 = origin.z * (float)obj4;
				object obj46 = default;
				object obj45 = obj46 * obj8;
				float num35 = origin.x * (float)obj12;
				float num36 = num32 + num33;
				float num37 = num36 + num34;
				object obj47 = obj10 * obj11;
				float num38 = origin.y * (float)obj13;
				float num39 = (float)obj5 + num37;
				object obj48 = obj45 + obj47;
				float num40 = num35 + num38;
				double num41 = 1.0 / (double)num39;
				object obj49 = obj15 * obj50;
				float num42 = origin.z * (float)obj18;
				object obj51 = obj48 + obj49;
				float num43 = num40 + num42;
				float num44 = num20 + (float)obj51;
				float num45 = (float)obj20 + num43;
				x = num44 * (float)obj16;
				num22 = (double)num45 * num41;
				goto IL_05af;
			}
		}
		((Vector3*)(nint)origin)->z = 0f;
		((Vector3*)(nint)origin)->x = 0f;
		((Vector3*)(nint)direction)->z = 0f;
		((Vector3*)(nint)direction)->x = 0f;
		ref Vector3 reference = ref *(Vector3*)null;
		return false;
		IL_0692:
		return true;
		IL_05af:
		((Vector3*)(nint)origin)->x = x;
		((Vector3*)(nint)origin)->z = (float)num22;
		Matrix4x4 localToWorld6 = c.LocalToWorld;
		object obj53 = default;
		object obj52 = obj53 * obj8;
		object obj55 = default;
		object obj54 = obj55 * obj11;
		float num46 = direction.x * (float)obj12;
		float num47 = direction.y * (float)obj13;
		object obj56 = obj52 + obj54;
		object obj58 = default;
		object obj57 = obj58 * obj50;
		float num48 = direction.z * (float)obj18;
		float num49 = num46 + num47;
		float x2 = (float)obj56 + (float)obj57;
		float z = num49 + num48;
		((Vector3*)(nint)direction)->x = x2;
		((Vector3*)(nint)direction)->z = z;
		goto IL_0692;
	}
}
