using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion.Internal;

[Serializable]
public abstract class UnityArraySurrogate<T, ReaderWriter> : UnitySurrogateBase where T : struct where ReaderWriter : struct, IElementReaderWriter<T>
{
	public abstract T[] DataProperty { get; set; }

	public unsafe override void Read(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0030: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got Ref
		//IL_008b: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got Ref
		//IL_00d6: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got Ref
		//IL_0135: Expected Obj, but got Ref
		//IL_0145: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I
		//IL_0434: Expected Obj, but got Ref
		//IL_0444: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I
		//IL_047c: Expected Obj, but got Ref
		//IL_03b8: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_028a: Expected Obj, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)16;
		object obj6 = obj5 + 15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default;
		object obj8 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+40]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+FC]");
		object obj11 = (nint)0 + (nint)15;
		object obj12 = obj11 & 0x1FFFFFFF0L;
		object obj13 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v1+FC]");
		object obj14 = (nint)0 + (nint)15;
		object obj15 = obj14 & 0x1FFFFFFF0L;
		object obj16 = (ref *(byte*)(&obj9)) - (ref *(byte*)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		base.Finalize();
		nint num2 = 0;
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v10+20]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X2_v3] (should have been resolved before IL gen)");
		object obj24;
		object obj25;
		if (capacity >= 1)
		{
			object obj20 = 0;
			while (true)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				object obj21 = 0;
				object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v18 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
				obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				obj25 = 0;
				object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
				nint num4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X1_v5+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				object obj41;
				if ((nint)0 != 0)
				{
					object obj27 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X19_v6+18]");
					bool flag = (nint)obj27 < 0;
					object obj28 = !flag;
					if (obj28 == null)
					{
						object obj29 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
						object obj30 = (nint)0 + (nint)32;
						object obj31 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+104]");
						object obj32 = obj31 * 0;
						object obj33 = obj30 + obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						object obj34 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X19_v6+18]");
						bool flag2 = (nint)obj34 < 0;
						object obj35 = !flag2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+FC]");
						obj25 = 0;
						obj24 = obj13;
						if (obj35 == null)
						{
							object obj36 = obj21;
							nint num5 = 0;
							object obj37 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v31+104]");
							object obj38 = obj37 * 0;
							object obj39 = obj30 + obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X9_v19 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
							obj20++;
							bool flag3 = capacity != (nint)obj20;
							obj41 = obj13;
							if (!flag3)
							{
								break;
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-48]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v26+28]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					bool flag4 = num6 != 0;
					obj41 = obj13;
					if (flag4)
					{
						goto IL_0405;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					NullReferenceException ex2 = (NullReferenceException)(object)ex;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-48]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22+28]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
				bool flag5 = num7 != 0;
				obj41 = obj13;
				if (!flag5)
				{
					NullReferenceException ex2 = new NullReferenceException();
					obj41 = obj13;
				}
				goto IL_0405;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-50]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
		obj24 = 0;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v14+1E0]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ X8_v14+1D8] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-48]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v15+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num8 == 0)
		{
			return;
		}
		goto IL_0405;
		IL_0405:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public unsafe override void Write(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_002b: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got Ref
		//IL_009c: Expected Obj, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got Ref
		//IL_00d1: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got Ref
		//IL_012e: Expected Obj, but got Ref
		//IL_013e: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_018b: Expected Obj, but got Ref
		//IL_01ab: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got Ref
		//IL_0266: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_0308: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v2 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X9_v1+FC]");
		object obj6 = (nint)0 + (nint)16;
		object obj7 = obj6 + 15;
		object obj8 = obj7 & 0x1FFFFFFF0L;
		object obj10 = default;
		object obj9 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+FC]");
		object obj11 = (nint)0 + (nint)15;
		object obj12 = obj11 & 0x1FFFFFFF0L;
		object obj13 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X9_v1+FC]");
		object obj14 = (nint)0 + (nint)15;
		object obj15 = obj14 & 0x1FFFFFFF0L;
		object obj16 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		base.Finalize();
		nint num2 = 0;
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v12+20]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ X2_v4] (should have been resolved before IL gen)");
		bool flag = capacity < 1;
		int num3 = capacity;
		if (!flag)
		{
			object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 12));
			object obj22 = default;
			object obj21 = obj22;
			nint num5 = default;
			nint num4 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v12+20]");
			object obj23 = 0;
			int num6 = capacity;
			IndexOutOfRangeException ex2 = default;
			IndexOutOfRangeException ex = ex2;
			object obj24 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
				if ((nint)0 != 0)
				{
					object obj26 = obj24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v18+18]");
					bool flag2 = (nint)obj26 < 0;
					object obj27 = !flag2;
					if (obj27 == null)
					{
						object obj28 = obj25;
						object obj29 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v16+104]");
						object obj30 = obj29 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-30]");
						object obj31 = 0 + obj30;
						object obj32 = obj31 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						nint num7 = 0;
						object obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v23 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
						obj19 = 0;
						num5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X1_v5 (System.Int32)+10] (should have been resolved before IL gen)");
						obj24++;
						bool flag3 = capacity != (nint)obj24;
						obj22 = obj13;
						obj21 = obj13;
						num4 = num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
						obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
						num6 = 0;
						ex = ex2;
						if (!flag3)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					bool flag4 = num8 != 0;
					obj22 = obj21;
					num5 = num4;
					obj19 = obj23;
					num3 = num6;
					ex2 = ex;
					if (flag4)
					{
						goto IL_0450;
					}
					NullReferenceException ex3 = new NullReferenceException();
					ex = (IndexOutOfRangeException)(object)ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
				bool flag5 = num9 != 0;
				obj22 = obj21;
				num5 = num4;
				obj19 = obj23;
				num3 = num6;
				ex2 = ex;
				if (!flag5)
				{
					ex2 = new IndexOutOfRangeException();
					obj22 = obj21;
					num5 = num4;
					obj19 = obj23;
					num3 = num6;
				}
				goto IL_0450;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num10 == 0)
		{
			return;
		}
		goto IL_0450;
		IL_0450:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public override void Init(int capacity)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X8_v4 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2<T, ReaderWriter>>)+1D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X8_v4 (Il2CppClass<Fusion.Internal.UnityArraySurrogate`2<T, ReaderWriter>>)+1E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v29 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
