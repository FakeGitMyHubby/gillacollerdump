using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion.Internal;

[Serializable]
public abstract class UnityDictionarySurrogate<TKeyType, TKeyReaderWriter, TValueType, TValueReaderWriter> : UnitySurrogateBase where TKeyType : struct where TKeyReaderWriter : struct, IElementReaderWriter<TKeyType> where TValueType : struct where TValueReaderWriter : struct, IElementReaderWriter<TValueType>
{
	private static IElementReaderWriter<TKeyType> _keyReaderWriter;

	private static IElementReaderWriter<TValueType> _valReaderWriter;

	public abstract SerializableDictionary<TKeyType, TValueType> DataProperty { get; set; }

	public unsafe override void Read(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0010: Expected Obj, but got Ref
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0070: Expected Obj, but got Ref
		//IL_0086: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got Ref
		//IL_00b5: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got Ref
		//IL_0100: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got Ref
		//IL_0132: Expected Obj, but got Ref
		//IL_013b: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got Ref
		//IL_01ae: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I4
		//IL_0bdc: Expected Obj, but got I
		//IL_0bec: Expected Obj, but got I
		//IL_0bfa: Expected Obj, but got Ref
		//IL_0c22: Expected Obj, but got I
		//IL_0c3c: Expected Obj, but got I
		//IL_0c4a: Expected Obj, but got Ref
		//IL_0c5a: Expected Obj, but got I
		//IL_0c6a: Expected Obj, but got I
		//IL_0c7a: Expected Obj, but got I
		//IL_09e5: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_02a8: Expected I, but got Obj
		//IL_06b5: Expected Obj, but got I
		//IL_06c3: Expected Obj, but got Ref
		//IL_06d1: Expected Obj, but got Ref
		//IL_06e1: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I
		//IL_0701: Expected Obj, but got I
		//IL_0719: Expected Obj, but got Ref
		//IL_0a32: Expected Obj, but got I
		//IL_0d30: Expected Obj, but got I
		//IL_0d40: Expected Obj, but got I
		//IL_0d50: Expected Obj, but got I
		//IL_0d60: Expected Obj, but got I
		//IL_0d6e: Expected Obj, but got Ref
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got Ref
		//IL_02e4: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_031c: Expected Obj, but got Ref
		//IL_032a: Expected Obj, but got Ref
		//IL_0350: Expected Obj, but got Ref
		//IL_0eb0: Expected VT, but got I
		//IL_0ec0: Expected Obj, but got I
		//IL_0ed8: Expected Obj, but got I
		//IL_0ee8: Expected Obj, but got I
		//IL_0ef8: Expected Obj, but got I
		//IL_0f19: Expected Obj, but got I
		//IL_0f22: Expected Obj, but got I4
		//IL_0cad: Expected Obj, but got I
		//IL_0cbd: Expected Obj, but got I
		//IL_0ccd: Expected Obj, but got I
		//IL_0cdd: Expected Obj, but got I
		//IL_0ceb: Expected Obj, but got Ref
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected Obj, but got Unknown
		//IL_0744: Expected Obj, but got I
		//IL_0754: Expected Obj, but got I
		//IL_0764: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I
		//IL_0787: Expected Obj, but got Ref
		//IL_0795: Expected Obj, but got Ref
		//IL_07b9: Expected Obj, but got I
		//IL_07c9: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_07fc: Expected Obj, but got Ref
		//IL_0816: Expected Obj, but got I
		//IL_0826: Expected Obj, but got I
		//IL_0836: Expected Obj, but got I
		//IL_0846: Expected Obj, but got I
		//IL_0859: Expected Obj, but got Ref
		//IL_0873: Expected Obj, but got I
		//IL_0883: Expected Obj, but got I
		//IL_0893: Expected Obj, but got I
		//IL_08a3: Expected Obj, but got I
		//IL_08bb: Expected Obj, but got Ref
		//IL_0610: Expected Obj, but got I4
		//IL_0a7f: Expected Obj, but got I
		//IL_0e02: Expected Obj, but got I
		//IL_0e1a: Expected Obj, but got I
		//IL_0e2a: Expected Obj, but got I
		//IL_0e3a: Expected Obj, but got I
		//IL_0e65: Expected Obj, but got I4
		//IL_0e75: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got Ref
		//IL_03d5: Expected Obj, but got Ref
		//IL_03f9: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I
		//IL_043c: Expected Obj, but got Ref
		//IL_0456: Expected Obj, but got I
		//IL_0466: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I
		//IL_0499: Expected Obj, but got Ref
		//IL_04a7: Expected Obj, but got Ref
		//IL_04c1: Expected Obj, but got I
		//IL_04d1: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I
		//IL_0678: Expected VT, but got Ref
		//IL_0681: Expected Ref, but got VT
		//IL_0637: Expected Obj, but got I4
		//IL_0647: Expected Obj, but got I
		//IL_0516: Expected Obj, but got I
		//IL_0529: Expected Obj, but got Ref
		//IL_0543: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I
		//IL_0563: Expected Obj, but got I
		//IL_0573: Expected Obj, but got I
		//IL_0586: Expected Obj, but got Ref
		//IL_05a0: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I
		//IL_05c0: Expected Obj, but got I
		//IL_05d0: Expected Obj, but got I
		//IL_05e8: Expected Obj, but got Ref
		//IL_0665: Expected Obj, but got I
		//IL_0e91: Expected Obj, but got Ref
		//IL_0975: Expected Obj, but got I
		//IL_0985: Expected Obj, but got I
		//IL_0995: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I
		//IL_0b74: Expected Obj, but got I
		//IL_0b14: Expected Obj, but got I
		//IL_0de4: Expected Obj, but got VT
		object obj2 = default;
		object obj = (object)(&obj2);
		object obj4 = default;
		object obj3 = (object)(&obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+70]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+88]");
		object obj7 = 0;
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 176));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X10_v1+FC]");
		object obj9 = (nint)0 + (nint)15;
		object obj10 = obj9 & 0x1FFFFFFF0L;
		object obj11 = (ref *(byte*)(&obj4)) - (ref *(byte*)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+FC]");
		object obj13 = (nint)0 + (nint)15;
		object obj14 = obj13 & 0x1FFFFFFF0L;
		object obj15 = (ref *(byte*)(&obj4)) - (ref *(byte*)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v1+FC]");
		object obj16 = (nint)0 + (nint)15;
		object obj17 = obj16 & 0x1FFFFFFF0L;
		object obj18 = (ref *(byte*)(&obj4)) - (ref *(byte*)obj17);
		_ = 0;
		object obj19 = (ref *(byte*)(&obj4)) - (ref *(byte*)obj17);
		obj8 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		_ = 0;
		object obj20 = (ref *(byte*)(&obj4)) - (ref *(byte*)obj17);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		nint num2 = (nint)this;
		bool flag = ((Attribute)(object)this).Match((object)0);
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v13 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v9+20]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj23 = !flag2;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v119 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v9+20]");
			obj22 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v15+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v9+30]");
		object obj25 = 0;
		object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+C]");
		bool flag3 = false;
		object obj27 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ X5_v1] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj29 = 0;
		object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v18+20]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v19+A8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v20+40]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X1_v8] (should have been resolved before IL gen)");
		object obj83;
		NullReferenceException ex = default;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v47+20]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v48+A8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v49+48]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ X1_v14] (should have been resolved before IL gen)");
			object obj38 = default;
			bool flag4 = ex != obj38;
			nint num5 = (nint)ex;
			if (flag4)
			{
				goto IL_068e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj39 = 0;
			object obj40 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v84+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v85+A8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v86+50]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X1_v26] (should have been resolved before IL gen)");
			object obj44 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 176));
			object obj45 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 24));
			num5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 176));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj46 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
			_ = 0;
			_ = 0;
			flag3 = true;
			object obj53 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v90+20]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v91+A8]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v92+B0]");
				object obj50 = 0;
				object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 176));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v387 @ X1_v29] (should have been resolved before IL gen)");
				object obj52 = obj53 & 1;
				if (obj52 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v94+20]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v95+A8]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v96+60]");
				object obj57 = 0;
				object obj58 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 176));
				object obj59 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v412 @ X1_v30+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v98+20]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v99+A8]");
				object obj62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v100+78]");
				object obj63 = 0;
				object obj64 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v513 @ X1_v32+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				object obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v102+20]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v103+A8]");
				object obj67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v104+90]");
				object obj68 = 0;
				obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
				obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 44));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v523 @ X1_v33+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
				object obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v106+20]");
				object obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v107+A8]");
				object obj71 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-2C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v108+78]");
					object obj72 = 0;
					object obj73 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v561 @ X1_v35+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
					object obj74 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v110+20]");
					object obj75 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v111+A8]");
					object obj76 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v112+98]");
					object obj77 = 0;
					object obj78 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ X1_v36+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
					object obj79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v114+20]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v115+A8]");
					object obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v116+A8]");
					object obj82 = 0;
					obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ X1_v37+10] (should have been resolved before IL gen)");
					obj28 = obj15;
					flag3 = flag;
					continue;
				}
				goto IL_066a;
			}
			obj83 = 0;
			goto IL_0df2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+10]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v40+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
		if (num6 == 0)
		{
			ex = new NullReferenceException();
			goto IL_0a22;
		}
		goto IL_0bb2;
		IL_0df2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+20]");
		object obj85 = 0;
		object obj86 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v24+20]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v25+A8]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v26+B8]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+18]");
		((NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator*)null)->Dispose();
		bool flag5 = obj83 == null;
		object obj89 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+18]");
		ex = (NullReferenceException)0;
		if (obj89 != null)
		{
			goto IL_0a22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+30]");
		bool flag6 = (nint)0 == 0;
		object obj90 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+18]");
		OutOfMemoryException ex2 = (OutOfMemoryException)0;
		if (obj90 != null)
		{
			goto IL_0a6f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+10]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v43+20]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v44+A8]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v45+D0]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X1_v8] (should have been resolved before IL gen)");
		object obj95 = obj28;
		object obj96 = obj27;
		bool flag7 = flag3;
		object obj97 = obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X21_v4+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
		bool flag8 = num7 != 0;
		obj28 = obj95;
		obj27 = obj96;
		flag3 = flag7;
		NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator enumerator = default;
		ex = (NullReferenceException)enumerator;
		if (!flag8)
		{
			return;
		}
		goto IL_0bb2;
		IL_0a22:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+10]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v38+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
		if (num8 == 0)
		{
			ex2 = new OutOfMemoryException();
			goto IL_0a6f;
		}
		goto IL_0bb2;
		IL_066a:
		NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator enumerator2 = (NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 176));
		((NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator*)enumerator2)->Dispose();
		flag3 = flag;
		goto IL_068e;
		IL_0a6f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+10]");
		object obj99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v32+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
		bool flag9 = num9 != 0;
		ex = (NullReferenceException)(object)ex2;
		if (flag9)
		{
			goto IL_0bb2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj33 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+28]");
			obj83 = 0;
		}
		else
		{
			if ((nint)obj33 != 1)
			{
				object obj100 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 24));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @29594D4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+10]");
				object obj101 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v34+28]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
				if (num10 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_0bb2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj102 = default;
			obj83 = obj102;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		goto IL_0df2;
		IL_0bb2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_068e:
		bool value = ((bool*)(flag ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ X8_v52 (System.Boolean)+2A8] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		object obj103 = 0;
		object obj104 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
		obj19 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 96));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v53+20]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v54+A8]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v55+50]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X1_v17] (should have been resolved before IL gen)");
		object obj108 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		_ = 0;
		_ = 0;
		object obj115 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj109 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v59+20]");
			object obj110 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v60+A8]");
			object obj111 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v61+B0]");
			object obj112 = 0;
			object obj113 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 96));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v324 @ X1_v19] (should have been resolved before IL gen)");
			object obj114 = obj115 & 1;
			if (obj114 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj116 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v68+20]");
			object obj117 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v69+A8]");
			object obj118 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v70+60]");
			object obj119 = 0;
			object obj120 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 96));
			object obj121 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v396 @ X1_v21+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj122 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v72+20]");
			object obj123 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v73+A8]");
			object obj124 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v74+78]");
			object obj125 = 0;
			object obj126 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ X1_v23+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj127 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v76+20]");
			object obj128 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v77+A8]");
			object obj129 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v78+98]");
			object obj130 = 0;
			object obj131 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X1_v24+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
			object obj132 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v80+20]");
			object obj133 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v81+A8]");
			object obj134 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v82+C8]");
			object obj135 = 0;
			obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X1_v25+10] (should have been resolved before IL gen)");
			obj28 = obj15;
			flag3 = flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+18]");
		enumerator = (NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+20]");
		object obj136 = 0;
		object obj137 = obj136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v64+20]");
		object obj138 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v65+A8]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v66+B8]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+18]");
		((NetworkDictionary<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>.Enumerator*)null)->Dispose();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X19_v1+18]");
		ex = (NullReferenceException)0;
		obj11 = 12;
		goto IL_0a22;
	}

	public unsafe override void Write(int* data, int capacity)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got Ref
		//IL_00b9: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got Ref
		//IL_00fe: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got Ref
		//IL_0149: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got Ref
		//IL_017e: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got Ref
		//IL_01aa: Expected Obj, but got Ref
		//IL_01de: Expected Obj, but got Ref
		//IL_01fd: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_0714: Expected Obj, but got I
		//IL_0724: Expected Obj, but got I
		//IL_0732: Expected Obj, but got Ref
		//IL_0742: Expected Obj, but got I
		//IL_075a: Expected Obj, but got I
		//IL_0778: Expected Obj, but got Ref
		//IL_0788: Expected Obj, but got I
		//IL_0798: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I
		//IL_07ca: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_0276: Expected Obj, but got Ref
		//IL_0286: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got Ref
		//IL_02cb: Expected Obj, but got Ref
		//IL_02e9: Expected Obj, but got Ref
		//IL_030c: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I
		//IL_0817: Expected Obj, but got I
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_05a9: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I4
		//IL_085c: Expected Obj, but got I
		//IL_086c: Expected Obj, but got I
		//IL_087a: Expected Obj, but got Ref
		//IL_088a: Expected Obj, but got I
		//IL_08b2: Expected Obj, but got I
		//IL_08c2: Expected Obj, but got I
		//IL_08dc: Expected Obj, but got I
		//IL_0900: Expected Obj, but got I4
		//IL_0321: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I
		//IL_0364: Expected Obj, but got Ref
		//IL_0388: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got Ref
		//IL_03e5: Expected Obj, but got I
		//IL_03f5: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I
		//IL_0428: Expected Obj, but got Ref
		//IL_0442: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I
		//IL_048a: Expected Obj, but got Ref
		//IL_0498: Expected Obj, but got Ref
		//IL_04a6: Expected Obj, but got Ref
		//IL_04c1: Expected Obj, but got I
		//IL_05f6: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I4
		//IL_051c: Expected Obj, but got I
		//IL_091c: Expected Obj, but got Ref
		//IL_0936: Expected Obj, but got I
		//IL_068b: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v3 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+F0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
		object obj6 = (nint)0 + (nint)16;
		object obj7 = obj6 + 15;
		object obj8 = obj7 & 0x1FFFFFFF0L;
		object obj10 = default;
		object obj9 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+88]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v9+FC]");
		object obj12 = (nint)0 + (nint)15;
		object obj13 = obj12 & 0x1FFFFFFF0L;
		object obj14 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v13+FC]");
		object obj16 = (nint)0 + (nint)15;
		object obj17 = obj16 & 0x1FFFFFFF0L;
		object obj18 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj17);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
		object obj19 = (nint)0 + (nint)15;
		object obj20 = obj19 & 0x1FFFFFFF0L;
		object obj21 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X9_v1+FC]");
		object obj22 = (nint)0 + (nint)15;
		object obj23 = obj22 & 0x1FFFFFFF0L;
		object obj24 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj23);
		object obj25 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj20);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj26 = (ref *(byte*)(&obj10)) - (ref *(byte*)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+20]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj28 = !flag;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v76 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+20]");
			obj27 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+A0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X26_v2+30]");
		object obj30 = 0;
		object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D4]");
		object obj32 = 0;
		object obj33 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v23+8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v114 @ X5_v1] (should have been resolved before IL gen)");
		nint num3 = 0;
		object obj35 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v25 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v26+E0]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ X1_v4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D0]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v28+1D0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X8_v28+1C8] (should have been resolved before IL gen)");
		object obj72;
		NullReferenceException ex = default;
		if (ex != null)
		{
			nint num4 = 0;
			object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 192));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v50 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v51+E8]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X1_v12+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj44 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
			object obj45 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
			_ = 0;
			object obj46 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 72));
			_ = 0;
			object obj47 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v4+FC]");
			object obj48 = 0;
			object obj52 = default;
			while (true)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v56 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v57+110]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ X1_v15] (should have been resolved before IL gen)");
				object obj51 = obj52 & 1;
				if (obj51 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v59+20]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v60+A8]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v61+F8]");
				object obj56 = 0;
				object obj57 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X1_v16+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v63+20]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v64+A8]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v65+78]");
				object obj61 = 0;
				object obj62 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X1_v18+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v67+20]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v68+A8]");
				object obj65 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v69+98]");
				object obj66 = 0;
				object obj67 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X1_v19+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
				object obj68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v71+20]");
				object obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v72+A8]");
				object obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v73+108]");
				object obj71 = 0;
				obj48 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
				obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
				obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 33));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X1_v20+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
				obj25 = 0;
			}
			obj72 = 0;
			goto IL_084c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v48+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
		if (num6 == 0)
		{
			ex = new NullReferenceException();
			goto IL_0599;
		}
		goto IL_06ea;
		IL_0599:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v46+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
		OutOfMemoryException ex2;
		if (num7 == 0)
		{
			ex2 = new OutOfMemoryException();
			goto IL_05e6;
		}
		goto IL_06ea;
		IL_05e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v40+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
		bool flag2 = num8 != 0;
		ex = (NullReferenceException)(object)ex2;
		if (flag2)
		{
			goto IL_06ea;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj40 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
			obj72 = 0;
		}
		else
		{
			if ((nint)obj40 != 1)
			{
				object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 192));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2959514");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
				object obj77 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v42+28]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
				if (num9 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				}
				goto IL_06ea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj78 = default;
			obj72 = obj78;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
		}
		goto IL_084c;
		IL_084c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
		object obj80 = 0;
		obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
		object obj81 = 0;
		object obj82 = obj79;
		obj32 = obj80;
		obj34 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v31+20]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v32+A8]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65B94");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-20]");
		obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v403 @ X0_v15 (should have been resolved before IL gen)");
		bool flag3 = obj72 == null;
		object obj85 = !flag3;
		if (obj85 != null)
		{
			goto IL_0599;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
		bool flag4 = (nint)0 == 0;
		object obj86 = !flag4;
		ex2 = (OutOfMemoryException)(object)ex;
		if (obj86 != null)
		{
			goto IL_05e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v36+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
		if (num10 == 0)
		{
			return;
		}
		goto IL_06ea;
		IL_06ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public override void Init(int capacity)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0055: Expected I, but got Obj
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v4 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v5+120]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ X1_v1] (should have been resolved before IL gen)");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v7 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4<TKeyType, TKeyReaderWriter, TValueType, TValueReaderWriter>>)+1D8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v7 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4<TKeyType, TKeyReaderWriter, TValueType, TValueReaderWriter>>)+1E0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v40 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	unsafe static UnityDictionarySurrogate()
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0021: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_02ff: Expected Obj, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got Ref
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0346: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a9: Expected Obj, but got Ref
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03d1: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_0584: Expected Obj, but got I
		//IL_0592: Expected Obj, but got Ref
		//IL_05a2: Expected Obj, but got I
		//IL_05bd: Expected Obj, but got I
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_05e5: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_0445: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I4
		//IL_0609: Expected Obj, but got I
		//IL_0619: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_065f: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04f3: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I
		//IL_067d: Expected Obj, but got I
		//IL_068b: Expected Obj, but got Ref
		//IL_069b: Expected Obj, but got I
		//IL_06b6: Expected Obj, but got I
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06de: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0272: Expected Obj, but got I4
		//IL_0511: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I
		//IL_0531: Expected Obj, but got I
		//IL_054c: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I4
		//IL_0702: Expected Obj, but got I
		//IL_0712: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X10_v1+138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X10_v2+FC]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X10_v6+148]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v7+FC]");
		object obj19 = (nint)0 + (nint)15;
		object obj20 = obj19 & 0x1FFFFFFF0L;
		object obj21 = (ref *(byte*)(&obj13)) - (ref *(byte*)obj20);
		object obj22 = obj4 & 1;
		bool flag3 = obj22 == null;
		object obj23 = !flag3;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj24 = (nint)0 + (nint)309;
			obj4 = obj24;
			num = 0;
		}
		else
		{
			IntPtr intPtr2 = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v3 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v11+130]");
		object obj26 = 0;
		object obj27 = obj4 & 1;
		bool flag4 = obj27 == null;
		object obj28 = !flag4;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr3 = default;
			num = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj29 = 0;
		object obj30 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+130]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ X1_v1+10] (should have been resolved before IL gen)");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag5 = obj33 == null;
		object obj34 = !flag5;
		nint num3 = 0;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj36 = (nint)0 + (nint)309;
		object obj37 = obj36 & 1;
		bool flag6 = obj37 == null;
		object obj38 = !flag6;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			nint num4 = 0;
		}
		else
		{
			nint num5 = 0;
			nint num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v11 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v8+20]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X9_v9+A0]");
		object obj41 = 0;
		object obj42 = default;
		obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v14 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+135]");
		object obj43 = (nint)0 & (nint)1;
		bool flag7 = obj43 == null;
		object obj44 = !flag7;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr4 = default;
			nint num4 = intPtr4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v14 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v15+20]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47;
		object obj49 = obj47 & 1;
		bool flag8 = obj49 == null;
		object obj50 = !flag8;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj51 = (nint)0 + (nint)309;
			obj48 = obj51;
			nint num6 = 0;
		}
		else
		{
			nint num7 = 0;
			nint num6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v15 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v13+140]");
		object obj53 = 0;
		object obj54 = obj48 & 1;
		bool flag9 = obj54 == null;
		object obj55 = !flag9;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr5 = default;
			nint num6 = intPtr5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v19 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj56 = 0;
		object obj57 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v20+140]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ X1_v4+10] (should have been resolved before IL gen)");
		object obj59 = (nint)0 + (nint)309;
		object obj60 = obj59 & 1;
		bool flag10 = obj60 == null;
		object obj61 = !flag10;
		nint num8 = 0;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v20 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj63 = (nint)0 + (nint)309;
		object obj64 = obj63 & 1;
		bool flag11 = obj64 == null;
		object obj65 = !flag11;
		if (obj65 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			nint num9 = 0;
		}
		else
		{
			nint num10 = 0;
			nint num9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v23 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X9_v17+20]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v18+A0]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v27 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+135]");
		object obj69 = (nint)0 & (nint)1;
		bool flag12 = obj69 == null;
		object obj70 = !flag12;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr6 = default;
			nint num9 = intPtr6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v27 (Il2CppClass<Fusion.Internal.UnityDictionarySurrogate`4>)+A8]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v28+20]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v29+A0]");
		object obj73 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X29_v1-8]");
		if (num11 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}
}
