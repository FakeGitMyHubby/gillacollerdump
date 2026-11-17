using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public static class Spline
{
	public static float Eval(float t, float[] T, float[] V)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0440: Expected F4, but got I4
		//IL_0075: Invalid comparison between I and F4
		//IL_0086: Expected Obj, but got I4
		//IL_00a6: Invalid comparison between F4 and I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_0496: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_04c1: Expected F4, but got I
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0168: Invalid comparison between I and F4
		//IL_0179: Expected Obj, but got I4
		//IL_0199: Invalid comparison between F4 and I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I4
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0565: Expected Obj, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got I4
		//IL_038d: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_03b6: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		object obj = T.Length - 1;
		if (T.Length >= 1)
		{
			if (T[0] < t)
			{
				object obj2 = (object)T + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X10_v4+20]");
				bool flag = 0f < t;
				object obj3 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X10_v4+20]");
				float num = 0f - t;
				bool flag2 = num == 0f;
				object obj4 = ~obj3;
				object obj5 = obj4 | flag2;
				if (obj5 == null)
				{
					object obj6 = T.Length - 2;
					object obj7 = 0 - obj;
					object obj8 = ~obj6;
					object obj9 = obj6 & obj8;
					object obj10 = 0 - obj9;
					object obj11 = 9;
					while (true)
					{
						object obj12 = obj10 + obj11;
						if ((nint)obj12 != 9)
						{
							object obj13 = obj7 + obj11;
							if ((nint)obj13 == 9)
							{
								break;
							}
							obj11++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [T @ X0 (System.Single[])+v258 @ X12_v5*4]");
							bool flag3 = 0f < t;
							object obj14 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [T @ X0 (System.Single[])+v258 @ X12_v5*4]");
							float num2 = 0f - t;
							bool flag4 = num2 == 0f;
							object obj15 = ~obj14;
							object obj16 = obj15 | flag4;
							if (obj16 != null)
							{
								continue;
							}
							obj9 = obj11 - 10;
						}
						object obj17 = obj9 + 1;
						bool flag5 = (nint)obj17 < T.Length;
						object obj18 = !flag5;
						if (obj18 != null)
						{
							break;
						}
						bool flag6 = (nint)obj9 < V.Length;
						object obj19 = !flag6;
						if (obj19 != null)
						{
							break;
						}
						bool flag7 = (nint)obj17 < V.Length;
						object obj20 = !flag7;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = (object)T + obj9;
						object obj22 = (object)T + obj17;
						object obj23 = (object)V + obj17;
						object obj24 = (object)V + obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X14_v7+20]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X13_v5+20]");
						object obj25 = num3 - 0;
						bool flag8 = obj9 == null;
						object obj26 = 0;
						if (!flag8)
						{
							object obj27 = obj9 - 1;
							bool flag9 = (nint)obj27 < V.Length;
							object obj28 = !flag9;
							if (obj28 != null)
							{
								break;
							}
							bool flag10 = (nint)obj27 < T.Length;
							object obj29 = !flag10;
							if (obj29 != null)
							{
								break;
							}
							object obj30 = (object)T + obj27;
							object obj31 = (object)V + obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X14_v7+20]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X13_v8+20]");
							object obj32 = num4 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X12_v9+20]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X12_v12+20]");
							object obj33 = num5 - 0;
							object obj34 = obj25 / obj32;
							obj26 = obj33 * obj34;
						}
						object obj35 = obj9 + 2;
						bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj36 = 0;
						if (!flag11)
						{
							bool flag12 = (nint)obj35 < V.Length;
							object obj37 = !flag12;
							if (obj37 != null)
							{
								break;
							}
							bool flag13 = (nint)obj35 < T.Length;
							object obj38 = !flag13;
							if (obj38 != null)
							{
								break;
							}
							object obj39 = (object)T + obj35;
							object obj40 = (object)V + obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X9_v5+20]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X13_v5+20]");
							object obj41 = num6 - 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v10+20]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X13_v6+20]");
							object obj42 = num7 - 0;
							object obj43 = obj25 / obj41;
							obj36 = obj42 * obj43;
						}
						float num8 = t;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X13_v5+20]");
						float num9 = num8 - 0f;
						float num10 = num9 / (float)obj25;
						float num11 = num10 * num10;
						float num12 = num10 * num11;
						float num13 = num11 * 3f;
						float num14 = num11 + num11;
						float num15 = num12 + num12;
						float num16 = num12 - num14;
						float num17 = num15 - num13;
						float num18 = num10 + num16;
						float num19 = num17 + 1f;
						float num20 = num18 * (float)obj26;
						float num21 = num13 - num15;
						float num22 = num19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X13_v6+20]");
						float num23 = num22 * 0f;
						float num24 = num21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X12_v9+20]");
						float num25 = num24 * 0f;
						float num26 = num23 + num20;
						float num27 = num12 - num11;
						float num28 = num25 + num26;
						float num29 = num27 * (float)obj36;
						return num28 + num29;
					}
				}
				else
				{
					bool flag14 = (nint)obj < V.Length;
					object obj44 = !flag14;
					if (obj44 == null)
					{
						object obj45 = (object)V + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v7+20]");
						return 0f;
					}
				}
			}
			else if (V.Length != 0)
			{
				return V[0];
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			throw new NullReferenceException();
		}
		return 0f;
	}
}
