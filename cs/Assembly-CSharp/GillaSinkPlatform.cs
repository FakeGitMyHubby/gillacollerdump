using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class GillaSinkPlatform : MonoBehaviour
{
	public int index;

	public Vector3 home;

	public Quaternion homeTurn;

	public const float Depth = default(float);

	public unsafe static (float, float, float, float) Times(int round)
	{
		//IL_0014: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_00ec: Expected F4, but got I
		//IL_00f1: Expected VT, but got Ref
		object obj = round - 2;
		object obj2 = ~obj;
		object obj3 = obj & obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C6B8]");
		object obj5 = default;
		object obj4 = 0 * obj5;
		float num = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BE70]");
		float item = num + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		object obj6 = obj3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C5E0]");
		float num2 = 0f + 4.5f;
		float num3 = (float)obj6 + num2;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
		float item2 = num4 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C5E0]");
		(float, float, float, float) tuple = (item, 0f, num3, item2);
		return ((float, float, float, float))(&tuple);
	}

	public static float Cycle(int round)
	{
		(float, float, float, float) tuple = Times(round);
		object obj = default;
		float num = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		return num + 0f;
	}

	public static float Under(float t, int round)
	{
		//IL_0009: Invalid comparison between F4 and I4
		//IL_0018: Expected F8, but got I4
		//IL_0073: Invalid comparison between F4 and I4
		//IL_0082: Expected F8, but got I4
		bool flag = t < 0f;
		double num = 0.0;
		if (!flag)
		{
			(float, float) tuple = At(t, 0, round);
			float num2 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
			float num3 = num2 + 0f;
			float num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
			float num5 = num4 / 0f;
			bool flag2 = num5 < 0f;
			num = 0.0;
			if (!flag2)
			{
				bool flag3 = !((double)num5 > 1.0);
				num = num5;
				if (!flag3)
				{
					num = 1.0;
				}
			}
		}
		return (float)num;
	}

	public unsafe static (float, float) At(float t, int seed, int round)
	{
		//IL_038f: Invalid comparison between F4 and I4
		//IL_017d: Expected F4, but got I4
		//IL_0447: Expected F4, but got I4
		//IL_044f: Expected VT, but got Ref
		//IL_000d: Invalid comparison between Obj and F4
		//IL_001e: Expected Obj, but got I4
		//IL_0036: Invalid comparison between F4 and I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_03af: Expected native int or pointer, but got VT
		//IL_018a: Invalid comparison between Obj and F4
		//IL_027b: Invalid comparison between Obj and F4
		//IL_00cc: Expected Obj, but got I
		//IL_031d: Invalid comparison between F4 and I4
		//IL_032c: Expected F8, but got I4
		//IL_0218: Invalid comparison between F4 and I4
		//IL_0227: Expected F8, but got I4
		//IL_016e: Expected VT, but got Ref
		//IL_02a3: Expected F4, but got I
		//IL_0439: Expected VT, but got Ref
		(float, float, float, float) tuple = Times(round);
		float item;
		float item2;
		(float, float) tuple2;
		object obj6 = default;
		if (!(t < 0f))
		{
			object obj = default;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)t);
			object obj2 = !flag;
			float num = (float)obj - t;
			bool flag2 = num == 0f;
			object obj3 = ~obj2;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				if (t > t)
				{
					float num2 = t / t;
					float num3 = t * 1.1133256E+09f;
					float num4 = num3 + (float)seed;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
					object obj5 = (nint)seed * (nint)0;
					float num5 = t * 1.1088691E+09f;
					float num6 = num5 + (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					float num7 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					float num8 = num7 * 0f;
					float num9 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
					float num10 = num9 * 0f;
					float num11 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
					float num12 = num11 * 0f;
					float num13 = num10 + num8;
					item = num6 * num12;
					item2 = num13;
					tuple2 = ((float, float))(&obj6);
				}
				else
				{
					object obj7 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)t))
					{
						object obj8 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)t))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
							item2 = 0f;
						}
						else
						{
							float num14 = t - (float)obj8;
							object obj9 = obj - obj8;
							float num15 = num14 / (float)obj9;
							float num16 = num15 + num15;
							float num17 = num15 * num15;
							double num18 = 3.0 - (double)num16;
							float num19 = num17 * (float)num18;
							bool flag3 = num19 < 0f;
							double num20 = 0.0;
							if (!flag3)
							{
								bool flag4 = !((double)num19 > 1.0);
								num20 = num19;
								if (!flag4)
								{
									num20 = 1.0;
								}
							}
							double num21 = num20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
							double num22 = num21 * 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
							double num23 = 0.0 - num22;
							item2 = (float)num23;
						}
						goto IL_043e;
					}
					float num24 = t - t;
					float num25 = (float)obj7 - t;
					float num26 = num24 / num25;
					float num27 = num26 + num26;
					float num28 = num26 * num26;
					double num29 = 3.0 - (double)num27;
					float num30 = num28 * (float)num29;
					bool flag5 = num30 < 0f;
					double num31 = 0.0;
					if (!flag5)
					{
						bool flag6 = !((double)num30 > 1.0);
						num31 = num30;
						if (!flag6)
						{
							num31 = 1.0;
						}
					}
					double num32 = num31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAE8]");
					double num33 = num32 * 0.0;
					double num34 = num33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
					double num35 = num34 + 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
					double num36 = 1.0 - (double)num26;
					double num37 = num36 * 4.0;
					item = (float)seed * (float)num37;
					item2 = (float)num35;
					tuple2 = ((float, float))(&obj6);
				}
				goto IL_03a3;
			}
		}
		item2 = 0f;
		goto IL_043e;
		IL_03a3:
		*((float, float)*)(nint)tuple2 = (item2, item);
		return tuple2;
		IL_043e:
		item = 0f;
		tuple2 = ((float, float))(&obj6);
		goto IL_03a3;
	}

	public bool Show(float t, int round)
	{
		//IL_04a7: Expected Obj, but got I
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		//IL_04e9: Expected Obj, but got I
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0497: Expected I4, but got Obj
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_02ed: Invalid comparison between F4 and I
		//IL_047b: Expected VT, but got I
		//IL_047b: Expected VT, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_03c9: Invalid comparison between F4 and I
		//IL_041d: Invalid comparison between F4 and I
		(float, float) tuple = At(t, index, round);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj3 = default;
		object obj2 = obj3 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		object obj4 = obj3 * 0;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
		object obj7 = obj2 * 0;
		Vector3 euler = default;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+3C]");
			object obj8 = 0 * obj7;
			object obj10 = default;
			object obj9 = homeTurn * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+3C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+2C]");
			object obj11 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+34]");
			object obj12 = 0 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+3C]");
			object obj13 = 0 * obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+38]");
			object obj14 = 0 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+3C]");
			object obj15 = 0 * obj10;
			object obj16 = homeTurn * obj7;
			object obj17 = obj8 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+34]");
			object obj18 = 0 * obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+38]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+2C]");
			object obj19 = num2 * 0;
			object obj20 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+38]");
			object obj21 = 0 * obj7;
			object obj22 = homeTurn * obj4;
			object obj23 = obj13 + obj14;
			Quaternion quaternion2 = homeTurn;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+2C]");
			object obj24 = quaternion2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+38]");
			object obj25 = 0 * obj4;
			object obj26 = obj15 - obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+34]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+2C]");
			object obj27 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+34]");
			object obj28 = 0 * obj7;
			object obj29 = obj18 + obj17;
			object obj30 = obj21 + obj20;
			object obj31 = obj24 + obj23;
			float num4 = t;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+2C]");
			float num5 = num4 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+24]");
			object obj33 = default;
			object obj32 = 0 * obj33;
			object obj34 = obj29 - obj19;
			object obj35 = obj26 - obj27;
			object obj36 = obj30 - obj22;
			object obj37 = obj31 - obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaSinkPlatform)+2C]");
			float num6 = 0f + num5;
			object obj38 = obj35 - obj25;
			object obj39 = home + obj32;
			Vector3 localPosition = transform.localPosition;
			float num7 = (float)obj31 - num6;
			object obj40 = obj39 - obj39;
			object obj42 = default;
			object obj41 = obj30 - obj42;
			object obj43 = obj40 * obj40;
			object obj44 = obj41 * obj41;
			object obj45 = obj43 + obj44;
			float num8 = num7 * num7;
			float num9 = num8 + (float)obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			if (!(num9 < 0f))
			{
				goto IL_0442;
			}
			Transform transform2 = base.transform;
			if ((object)transform2 != null)
			{
				Quaternion localRotation = transform2.localRotation;
				float num10 = (float)obj34 * num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
				object obj46 = obj36 * 0;
				float num11 = num10 + (float)obj46;
				float num12 = (float)obj37 * num7;
				float num13 = num12 + num11;
				object obj47 = obj38 * obj39;
				float num14 = (float)obj47 + num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
				if (!(num14 > 0f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
					float num15 = num14 + num14;
					float num16 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
					float num17 = num16 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
					if (!(num17 < 0f))
					{
						goto IL_0442;
					}
				}
				return false;
			}
		}
		goto IL_0489;
		IL_0442:
		Transform transform3 = base.transform;
		if ((object)transform3 != null)
		{
			IntPtr intPtr = default;
			transform3.SetLocalPositionAndRotation((Vector3)0, (Quaternion)(nint)intPtr);
			return true;
		}
		goto IL_0489;
		IL_0489:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public GillaSinkPlatform()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0037: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v5+A0]");
		homeTurn = (Quaternion)(object)0;
		base._002Ector();
	}
}
