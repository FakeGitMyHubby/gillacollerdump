using System;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

public class MessageProtocol
{
	private static readonly float[] memFloatBlock;

	private static readonly byte[] memDeserialize;

	public unsafe static void Serialize(short value, byte[] target, ref int targetOffset)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		object obj = targetOffset + 1;
		ref int reference = ref *(int*)obj;
		bool flag = targetOffset < target.Length;
		object obj2 = !flag;
		if (obj2 == null)
		{
			int num = value >> 8;
			object obj3 = target + targetOffset;
			object obj4 = targetOffset + 1;
			reference = ref *(int*)obj4;
			bool flag2 = targetOffset < target.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = target + targetOffset;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public unsafe static void Deserialize(out short value, byte[] source, ref int offset)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		object obj = offset + 1;
		ref int reference = ref *(int*)obj;
		bool flag = offset < source.Length;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = source + offset;
			object obj4 = offset + 2;
			reference = ref *(int*)obj4;
			bool flag2 = (nint)obj < source.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = (object)source + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v2+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v4+20]");
				object obj7 = num | 0;
				ref short reference2 = ref *(short*)obj7;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public unsafe static void Serialize(int value, byte[] target, ref int targetOffset)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		object obj = targetOffset + 1;
		ref int reference = ref *(int*)obj;
		bool flag = targetOffset < target.Length;
		object obj2 = !flag;
		if (obj2 == null)
		{
			int num = value >> 24;
			object obj3 = target + targetOffset;
			object obj4 = targetOffset + 1;
			reference = ref *(int*)obj4;
			bool flag2 = targetOffset < target.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				int num2 = value >> 16;
				object obj6 = target + targetOffset;
				object obj7 = targetOffset + 1;
				reference = ref *(int*)obj7;
				bool flag3 = targetOffset < target.Length;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					int num3 = value >> 8;
					object obj9 = target + targetOffset;
					object obj10 = targetOffset + 1;
					reference = ref *(int*)obj10;
					bool flag4 = targetOffset < target.Length;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						object obj12 = target + targetOffset;
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public unsafe static void Deserialize(out int value, byte[] source, ref int offset)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		object obj = offset + 1;
		ref int reference = ref *(int*)obj;
		bool flag = offset < source.Length;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = source + offset;
			object obj4 = offset + 2;
			reference = ref *(int*)obj4;
			bool flag2 = (nint)obj < source.Length;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				object obj6 = (object)source + obj;
				object obj7 = offset + 3;
				reference = ref *(int*)obj7;
				bool flag3 = (nint)obj4 < source.Length;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					object obj9 = (object)source + obj4;
					object obj10 = offset + 4;
					reference = ref *(int*)obj10;
					bool flag4 = (nint)obj7 < source.Length;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v4+20]");
						object obj12 = (nint)0 << 24;
						object obj13 = (object)source + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v4+20]");
						object obj14 = obj12 | 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X12_v4+20]");
						object obj15 = obj14 | 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X11_v5+20]");
						object obj16 = obj15 | 0;
						ref int reference2 = ref *(int*)obj16;
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	public unsafe static void Serialize(float value, byte[] target, ref int targetOffset)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0535: Expected Obj, but got I4
		//IL_05d6: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got Ref
		//IL_0588: Expected Obj, but got Ref
		//IL_0068: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got Ref
		//IL_0078: Expected Obj, but got Ref
		//IL_00c6: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got Ref
		//IL_00d6: Expected Obj, but got Ref
		//IL_00f4: Expected Obj, but got Ref
		//IL_014a: Expected Obj, but got I4
		//IL_04bf: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got Ref
		//IL_0172: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_02f4: Expected Obj, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_03be: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		bool lockTaken = default;
		Monitor.Enter(obj4, ref lockTaken);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+A0]");
		object obj7 = 0;
		Array array = (Array)obj7;
		bool flag3 = obj7 == null;
		OutOfMemoryException ex = null;
		object obj8 = 0;
		object obj9 = (object)(&lockTaken);
		object obj11 = default;
		object obj10 = (object)(&obj11);
		Array array2 = null;
		int num = (int)(&lockTaken);
		if (flag3)
		{
			goto IL_0453;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7 (System.Array)+18]");
		bool flag4 = (nint)0 == 0;
		ex = null;
		obj8 = 0;
		obj9 = (object)(&lockTaken);
		obj10 = (object)(&obj11);
		array2 = null;
		num = (int)(&lockTaken);
		if (!flag4)
		{
			Buffer.BlockCopy((Array)obj7, 0, target, targetOffset, 4);
			ex = null;
			obj8 = 0;
			obj9 = (object)(&lockTaken);
			obj10 = (object)(&obj11);
			array2 = target;
			num = 0;
			goto IL_00ec;
		}
		goto IL_046f;
		IL_00ec:
		object obj12 = (object)(&lockTaken);
		if (obj12 != null)
		{
			object obj13 = (object)(&obj11);
			Monitor.Exit(obj13);
			num = 0;
		}
		bool flag5 = ex == null;
		object obj14 = !flag5;
		OutOfMemoryException ex2;
		if (obj14 == null)
		{
			bool flag6 = obj8 == null;
			object obj15 = !flag6;
			ex2 = ex;
			if (obj15 != null)
			{
				goto IL_0444;
			}
			if (target == null)
			{
				goto IL_0461;
			}
			obj10 = target.Length;
			bool flag7 = targetOffset < target.Length;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				obj9 = targetOffset + 1;
				bool flag8 = (nint)obj9 < target.Length;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					object obj18 = targetOffset + 3;
					bool flag9 = (nint)obj18 < target.Length;
					object obj19 = !flag9;
					if (obj19 == null)
					{
						object obj20 = (object)target + obj18;
						object obj21 = (object)target + obj9;
						object obj22 = target + targetOffset;
						object obj23 = obj22 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v10+20]");
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X10_v10+20]");
						obj23 = 0;
						obj18 = targetOffset;
						object obj24 = target.Length;
						obj10 = targetOffset + 2;
						bool flag10 = (nint)obj10 < target.Length;
						object obj25 = !flag10;
						if (obj25 == null)
						{
							obj18++;
							bool flag11 = (nint)obj18 < target.Length;
							object obj26 = !flag11;
							if (obj26 == null)
							{
								obj24 = target + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X12_v7+v117 @ X10_v6]");
								_ = 0;
								obj18 = target.Length;
								obj10 = targetOffset + 2;
								bool flag12 = (nint)obj10 < target.Length;
								object obj27 = !flag12;
								if (obj27 == null)
								{
									object obj28 = (object)target + obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X9_v10+20]");
									_ = 0;
									obj10 = target.Length;
									obj9 = targetOffset + 3;
									bool flag13 = (nint)obj9 < target.Length;
									object obj29 = !flag13;
									if (obj29 == null)
									{
										object obj30 = (object)target + obj9;
										object obj31 = targetOffset + 4;
										ref int reference = ref *(int*)obj31;
										return;
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		}
		ex2 = new OutOfMemoryException();
		goto IL_0444;
		IL_0444:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0453;
		IL_0461:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_046f;
		IL_046f:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj8 = 1;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj32 = default;
			ex = (OutOfMemoryException)obj32;
		}
		goto IL_00ec;
		IL_0453:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0461;
	}

	public unsafe static void Deserialize(out float value, byte[] source, ref int offset)
	{
		//IL_0010: Expected Obj, but got I
		//IL_056d: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_0689: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_05ae: Expected Obj, but got I4
		//IL_05d3: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I8
		//IL_05fa: Expected Obj, but got Ref
		//IL_03e6: Expected Obj, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_03b5: Expected Obj, but got Ref
		//IL_040e: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I8
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02db: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_030d: Expected Obj, but got I4
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I
		//IL_0388: Expected Ref, but got F4
		//IL_0396: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+8]");
		bool lockTaken = default;
		Monitor.Enter(0, ref lockTaken);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+8]");
		byte[] array = (byte[])0;
		object obj8 = offset + 1;
		ref int reference = ref *(int*)obj8;
		bool flag3 = source == null;
		OutOfMemoryException ex = null;
		object obj9 = 0;
		object obj10 = 0;
		int num = (int)(&lockTaken);
		if (!flag3)
		{
			obj8 = source.Length;
			bool flag4 = offset < source.Length;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+8]");
				bool flag5 = (nint)0 == 0;
				ex = null;
				obj9 = 0;
				obj10 = 0;
				num = (int)(&lockTaken);
				if (flag5)
				{
					goto IL_04a7;
				}
				obj8 = array.Length;
				object obj12 = array.Length & 0xFFFFFFFCL;
				if (obj12 != null)
				{
					object obj13 = source + offset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v22+20]");
					array[3] = 0;
					object obj14 = offset + 1;
					reference = ref *(int*)obj14;
					obj8 = source.Length;
					bool flag6 = offset < source.Length;
					object obj15 = !flag6;
					if (obj15 == null)
					{
						obj8 = array.Length;
						bool flag7 = array.Length < 2;
						object obj16 = !flag7;
						object obj17 = array.Length - 2;
						bool flag8 = obj17 == null;
						object obj18 = ~obj16;
						object obj19 = obj18 | flag8;
						if (obj19 == null)
						{
							object obj20 = source + offset;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v25+20]");
							array[2] = 0;
							object obj21 = offset + 1;
							reference = ref *(int*)obj21;
							obj8 = source.Length;
							bool flag9 = offset < source.Length;
							object obj22 = !flag9;
							if (obj22 == null)
							{
								obj8 = array.Length;
								object obj23 = array.Length & 0xFFFFFFFEL;
								if (obj23 != null)
								{
									object obj24 = source + offset;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v28+20]");
									array[1] = 0;
									object obj25 = offset + 1;
									reference = ref *(int*)obj25;
									obj8 = source.Length;
									bool flag10 = offset < source.Length;
									object obj26 = !flag10;
									if (obj26 != null || array.Length == 0)
									{
										goto IL_044f;
									}
									object obj27 = source + offset;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v31+20]");
									array[0] = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+8]");
									float num2 = BitConverter.ToSingle((byte[])0, 0);
									ref float reference2 = ref *(float*)num2;
									ex = null;
									obj9 = 0;
									obj10 = 0;
									num = 0;
									goto IL_05f2;
								}
							}
							goto IL_0441;
						}
					}
					goto IL_0433;
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_0433;
		}
		goto IL_0499;
		IL_048a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0499;
		IL_044f:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		ex = null;
		obj9 = 0;
		obj10 = 0;
		num = (int)(&lockTaken);
		goto IL_047c;
		IL_05f2:
		object obj28 = (object)(&lockTaken);
		if (obj28 != null)
		{
			object obj30 = default;
			object obj29 = (object)(&obj30);
			Monitor.Exit(obj29);
			num = 0;
		}
		bool flag11 = ex == null;
		object obj31 = !flag11;
		if (obj31 != null)
		{
			goto IL_047c;
		}
		bool flag12 = obj9 == null;
		object obj32 = !flag12;
		OutOfMemoryException ex4 = ex;
		if (obj32 == null)
		{
			return;
		}
		goto IL_048a;
		IL_0433:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0441;
		IL_04a7:
		NullReferenceException ex6 = new NullReferenceException();
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj9 = 1;
		}
		else
		{
			if (num != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj33 = default;
			ex = (OutOfMemoryException)obj33;
		}
		goto IL_05f2;
		IL_0499:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_04a7;
		IL_047c:
		ex4 = new OutOfMemoryException();
		goto IL_048a;
		IL_0441:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_044f;
	}

	static MessageProtocol()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65156E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+A0]");
		object obj5 = 0;
		object obj6 = default;
		obj5 = obj6;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+A0]");
		object obj9 = (nint)0 + (nint)8;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
