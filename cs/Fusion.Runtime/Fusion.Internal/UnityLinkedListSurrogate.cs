using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion.Internal;

[Serializable]
public abstract class UnityLinkedListSurrogate<T, ReaderWriter> : UnitySurrogateBase where T : struct where ReaderWriter : struct, IElementReaderWriter<T>
{
	private static IElementReaderWriter<T> _readerWriter;

	public abstract T[] DataProperty { get; set; }

	public unsafe override void Read(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got Ref
		//IL_0082: Expected Obj, but got Ref
		//IL_00b6: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_0606: Expected Obj, but got Ref
		//IL_0620: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I
		//IL_0647: Expected Obj, but got Ref
		//IL_0657: Expected Obj, but got I
		//IL_0667: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_069f: Expected Obj, but got Ref
		//IL_06af: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I
		//IL_06cf: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got Ref
		//IL_0707: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0727: Expected Obj, but got I
		//IL_073f: Expected Obj, but got Ref
		//IL_074d: Expected Obj, but got Ref
		//IL_0792: Expected Obj, but got I8
		//IL_07a7: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I
		//IL_07d7: Expected Obj, but got I
		//IL_07e5: Expected Obj, but got Ref
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I4
		//IL_082a: Expected Obj, but got I
		//IL_083a: Expected Obj, but got I
		//IL_0852: Expected Obj, but got I
		//IL_0862: Expected Obj, but got I
		//IL_0872: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_016e: Expected Obj, but got Ref
		//IL_017c: Expected Obj, but got Ref
		//IL_01c7: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected I, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I
		//IL_038d: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02ab: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I
		//IL_08b2: Expected Obj, but got Ref
		//IL_055f: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v2 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+70]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj7 = default;
		IFormatProvider formatProvider = (IFormatProvider)((ref *(byte*)(&obj7)) - (ref *(byte*)obj6));
		object obj8 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj6);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v55 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+10]");
			obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4+18]");
		IFormatProvider formatProvider2 = (IFormatProvider)0;
		object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X4_v4 (System.IFormatProvider)] (should have been resolved before IL gen)");
		sbyte b = ((Enum)(object)this).System_002EIConvertible_002EToSByte((IFormatProvider)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
		object obj14 = 0;
		object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7+20]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v8+A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v9+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ X1_v3] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
		object obj19 = 0;
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v11+20]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v12+A8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v13+40]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ X2_v7] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
		object obj24 = 0;
		object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v15+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v16+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v17+50]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ X1_v5] (should have been resolved before IL gen)");
		object obj29 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-70]");
		_ = 0;
		_ = 0;
		int* ptr = data;
		object obj31 = 4294967295L;
		object obj38 = default;
		object obj63 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v21+20]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v22+A8]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v23+78]");
			object obj35 = 0;
			object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ X1_v7] (should have been resolved before IL gen)");
			object obj37 = obj38 & 1;
			IFormatProvider formatProvider3;
			IndexOutOfRangeException ex;
			if (obj37 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v40+20]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v41+A8]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v42+60]");
				object obj42 = 0;
				object obj43 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ X1_v14+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-38]");
				ptr = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-38]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
				obj23 = 0;
				formatProvider3 = formatProvider;
				if (!flag2)
				{
					nint num3 = (nint)(obj31 + 1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X24_v6 (System.Int32*)+18]");
					bool flag3 = num3 < 0;
					object obj44 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
					obj23 = 0;
					formatProvider3 = formatProvider;
					if (obj44 == null)
					{
						IntPtr intPtr = (nint)ptr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-38]");
						object obj45 = (nint)0 + (nint)32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X9_v24 (Il2CppClass<System.Int32*>)+104]");
						object obj46 = 0 * num3;
						object obj47 = obj45 + obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						obj31++;
						object obj48 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X24_v6 (System.Int32*)+18]");
						bool flag4 = (nint)obj48 < 0;
						object obj49 = !flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
						obj23 = 0;
						formatProvider3 = formatProvider;
						if (obj49 == null)
						{
							IntPtr intPtr2 = (nint)ptr;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
							object obj50 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X9_v25+20]");
							object obj51 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v51 (Il2CppClass<System.Int32*>)+104]");
							object obj52 = 0 * num3;
							object obj53 = obj45 + obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v26+A8]");
							object obj54 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
							formatProvider2 = formatProvider;
							obj23 = obj8;
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
					bool flag5 = num4 != 0;
					formatProvider2 = formatProvider;
					if (flag5)
					{
						break;
					}
					ex = new IndexOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
				bool flag6 = num5 != 0;
				formatProvider2 = formatProvider;
				if (flag6)
				{
					break;
				}
				NullReferenceException ex2 = new NullReferenceException();
				formatProvider2 = formatProvider;
				ex = (IndexOutOfRangeException)(object)ex2;
				goto IL_048d;
			}
			object obj55 = 0;
			goto IL_081a;
			IL_081a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-80]");
			ex = (IndexOutOfRangeException)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-78]");
			object obj56 = 0;
			object obj57 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v27+20]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v28+A8]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v29+80]");
			formatProvider3 = (IFormatProvider)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B38064");
			bool flag7 = obj55 == null;
			object obj60 = !flag7;
			if (obj60 != null)
			{
				goto IL_048d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-68]");
			bool flag8 = (nint)0 == 0;
			object obj61 = !flag8;
			if (obj61 == null)
			{
				nint num6 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-38]");
				formatProvider3 = (IFormatProvider)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v31 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2<T, ReaderWriter>>)+1E0]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-38]");
				ex = (IndexOutOfRangeException)((Enum)(object)this).System_002EIConvertible_002EToByte((IFormatProvider)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
				if (num7 != 0)
				{
					break;
				}
				return;
			}
			goto IL_04d2;
			IL_048d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			if (num8 != 0)
			{
				break;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex = (IndexOutOfRangeException)(object)ex3;
			goto IL_04d2;
			IL_04d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			if (num9 != 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)formatProvider3 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-70]");
				obj55 = 0;
			}
			else
			{
				if ((nint)formatProvider3 != 1)
				{
					object obj62 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2959580");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
					if (num10 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					}
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj55 = obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			}
			goto IL_081a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public unsafe override void Write(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got Ref
		//IL_0092: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got Ref
		//IL_03de: Expected Obj, but got Ref
		//IL_03ee: Expected Obj, but got I
		//IL_03fe: Expected Obj, but got I
		//IL_040d: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_045f: Expected Obj, but got I4
		//IL_0194: Expected I, but got Obj
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got Ref
		//IL_01f2: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v2 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+70]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj8 = default;
		object obj7 = (ref *(byte*)(&obj8)) - (ref *(byte*)obj6);
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v26 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
		object obj12 = 0;
		object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v206 @ X4_v2] (should have been resolved before IL gen)");
		nint num3 = 0;
		object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+98]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ X1_v2] (should have been resolved before IL gen)");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2<T, ReaderWriter>>)+1D0]");
		object obj18 = 0;
		IndexOutOfRangeException ex = (IndexOutOfRangeException)((Enum)(object)this).System_002EIConvertible_002EToSByte((IFormatProvider)0);
		IndexOutOfRangeException ex2;
		NullReferenceException ex3;
		if (ex != null)
		{
			bool flag2 = (nint)((Exception)ex)._message < 1;
			ex2 = ex;
			if (flag2)
			{
				goto IL_0285;
			}
			object obj19 = ex + 32;
			string text = (string)(((Exception)ex)._message & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
			object obj20 = 0;
			object obj21 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2<T, ReaderWriter>>)+1D0]");
			object obj22 = 0;
			int num6 = default;
			int num5 = num6;
			ex3 = (NullReferenceException)(object)ex;
			object obj23 = 0;
			while (true)
			{
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text);
				object obj24 = !flag3;
				if (obj24 != null)
				{
					break;
				}
				nint num7 = (nint)ex;
				object obj25 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v19 (Il2CppClass<System.IndexOutOfRangeException>)+104]");
				object obj26 = obj25 * 0;
				object obj27 = obj19 + obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
				nint num8 = 0;
				num6 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v21 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v22+A0]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X1_v4+10] (should have been resolved before IL gen)");
				text = ((Exception)ex)._message;
				obj23++;
				object obj29 = obj23;
				string message = ((Exception)ex)._message;
				bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref message);
				obj12 = obj7;
				obj20 = obj7;
				obj21 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v22+A0]");
				obj22 = 0;
				num5 = num6;
				ex3 = (NullReferenceException)(object)ex2;
				if (flag4)
				{
					continue;
				}
				goto IL_0285;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
			bool flag5 = num9 != 0;
			obj12 = obj20;
			obj14 = obj21;
			obj18 = obj22;
			num6 = num5;
			if (flag5)
			{
				goto IL_037f;
			}
			ex = new IndexOutOfRangeException();
			obj12 = obj20;
			obj14 = obj21;
			obj18 = obj22;
			num6 = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		bool flag6 = num10 != 0;
		ex3 = (NullReferenceException)(object)ex;
		if (!flag6)
		{
			ex3 = new NullReferenceException();
		}
		goto IL_037f;
		IL_037f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X29_v1-8]");
		bool flag7 = num11 != 0;
		ex3 = (NullReferenceException)(object)ex2;
		if (!flag7)
		{
			return;
		}
		goto IL_037f;
	}

	public override void Init(int capacity)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0035: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2+A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ X8_v3] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v4 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2<T, ReaderWriter>>)+1D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v4 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2<T, ReaderWriter>>)+1E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	unsafe static UnityLinkedListSurrogate()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0021: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got Ref
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I
		//IL_030f: Expected Obj, but got Ref
		//IL_031f: Expected Obj, but got I
		//IL_033a: Expected Obj, but got I
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0362: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I4
		//IL_0386: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		_ = 0;
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3;
		object obj5 = obj3 & 1;
		bool flag = obj5 == null;
		object obj6 = !flag;
		nint num;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj7 = (nint)0 + (nint)309;
			obj4 = obj7;
			num = 0;
		}
		else
		{
			nint num2 = 0;
			num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v1 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X10_v1+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X10_v2+FC]");
		object obj10 = (nint)0 + (nint)15;
		object obj11 = obj10 & 0x1FFFFFFF0L;
		object obj13 = default;
		object obj12 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj11);
		object obj14 = obj4 & 1;
		bool flag2 = obj14 == null;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj16 = (nint)0 + (nint)309;
			obj4 = obj16;
			num = 0;
		}
		else
		{
			IntPtr intPtr = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v2 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X10_v6+B0]");
		object obj18 = 0;
		object obj19 = obj4 & 1;
		bool flag3 = obj19 == null;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj21 = 0;
		object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+B0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X1_v1+10] (should have been resolved before IL gen)");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag4 = obj25 == null;
		object obj26 = !flag4;
		nint num3 = 0;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag5 = obj29 == null;
		object obj30 = !flag5;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			nint num4 = 0;
		}
		else
		{
			nint num5 = 0;
			nint num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v10 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v7+10]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v8+A0]");
		object obj33 = 0;
		object obj34 = default;
		obj33 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+135]");
		object obj35 = (nint)0 & (nint)1;
		bool flag6 = obj35 == null;
		object obj36 = !flag6;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			nint num4 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13 (Il2CppClass<Fusion.Internal.UnityLinkedListSurrogate`2>)+A8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v14+10]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-8]");
		if (num6 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}
}
