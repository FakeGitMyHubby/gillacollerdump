using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2)]
public struct BitSet192 : _0021_00210, Action<LinkGoogleAccountResult>, _0021_00210, Action<LinkGooglePlayGamesServicesAccountResult>
{
	public struct Iterator
	{
		private int _bit = -1;

		public BitSet192 _set;

		public Iterator(BitSet192 set)
		{
			//IL_000f: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [set @ X1 (Fusion.BitSet192)+10]");
			_ = 0;
			_set = (BitSet192)set.Bits;
		}

		public unsafe bool Next(out int index)
		{
			//IL_03b4: Expected I4, but got I8
			//IL_0042: Expected Obj, but got Ref
			//IL_004a: Expected Obj, but got Ref
			//IL_0425: Expected Obj, but got I4
			//IL_02df: Expected I4, but got I8
			//IL_02ec: Expected Obj, but got I4
			//IL_02fa: Expected Obj, but got I4
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Expected Obj, but got Unknown
			//IL_0343: Expected Obj, but got I4
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected Obj, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected Obj, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got Unknown
			//IL_0176: Expected Obj, but got I4
			//IL_01c7: Expected Obj, but got I4
			//IL_01f9: Expected Obj, but got I4
			int num = ++_bit;
			bool flag5;
			bool result;
			if (num <= 191)
			{
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				object obj3 = default;
				object obj2 = (object)(&obj3);
				while (true)
				{
					int num2 = num + 63;
					bool flag = num < 0;
					int num3 = num ^ num;
					int num4 = num & num3;
					bool flag2 = num4 < 0;
					bool flag3 = flag == flag2;
					object obj4 = !flag3;
					object obj5 = ~obj4;
					if (obj5 != null)
					{
						num2 = num;
					}
					int num5 = num2 >> 6;
					int num6 = (int)(num2 & 0xFFFFFFC0L);
					object obj6 = num - num6;
					object obj7 = 1 << (int)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X10_v3+v25 @ X13_v4 (System.Int32)*8]");
					object obj8 = 0 & obj7;
					bool flag4 = obj8 == null;
					flag5 = !flag4;
					bool flag6 = obj8 == null;
					object obj9 = !flag6;
					result = flag5;
					if (obj9 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X10_v3+v25 @ X13_v4 (System.Int32)*8]");
					int num7;
					if ((nint)0 != 0)
					{
						object obj10 = obj6 >> 10;
						object obj11 = obj10 & 0x1F;
						object obj12 = obj6 + obj11;
						object obj13 = obj12 >> 5;
						object obj14 = obj13 & 7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X12_v3+v164 @ X17_v9*4]");
						if ((nint)0 != 0)
						{
							object obj15 = obj6 >> 11;
							object obj16 = obj15 & 0xF;
							object obj17 = obj6 + obj16;
							object obj18 = obj17 >> 4;
							object obj19 = obj18 & 0xF;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X12_v3+v171 @ X15_v8*2]");
							if ((nint)0 != 0)
							{
								while (true)
								{
									num7 = num + 1;
									object obj20 = num + 64;
									bool flag7 = num7 < 0;
									int num8 = num7 ^ num7;
									int num9 = num7 & num8;
									bool flag8 = num9 < 0;
									bool flag9 = flag7 == flag8;
									object obj21 = !flag9;
									object obj22 = ~obj21;
									object obj23 = ((obj22 != null) ? ((object)(num + 1)) : obj20);
									bool flag10 = num5 != (nint)obj23;
									num = num7;
									if (flag10)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X10_v3+v25 @ X13_v4 (System.Int32)*8]");
									int num10 = (int)((nint)0 >> num7);
									int num11 = num10 & 1;
									bool flag11 = num11 == 0;
									num = num7;
									if (flag11)
									{
										continue;
									}
									goto IL_029f;
								}
							}
							else
							{
								num += 16;
							}
						}
						else
						{
							num += 32;
						}
					}
					else
					{
						num += 64;
					}
					_bit = num;
					if (num < 192)
					{
						continue;
					}
					goto IL_0284;
					IL_029f:
					_bit = num7;
					num = num7;
					result = true;
					break;
				}
				goto IL_03b9;
			}
			result = false;
			goto IL_03a7;
			IL_03b9:
			ref int reference = ref *(int*)num;
			return result;
			IL_0284:
			result = flag5;
			goto IL_03a7;
			IL_03a7:
			num = -1;
			goto IL_03b9;
		}
	}

	public unsafe struct Enumerator(ulong* bits) : Action<LinkAndroidDeviceIDResult>, _0021_00210, Action<LinkFacebookAccountResult>
	{
		private unsafe ulong* _bits = bits;

		private int _bit = -1;

		public int Current => _bit;

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_0010: Expected Obj, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object result = default;
				return result;
			}
		}

		public void Reset()
		{
			//IL_000f: Expected I4, but got I8
			_bit = -1;
		}

		public unsafe bool MoveNext()
		{
			//IL_0049: Expected Obj, but got Ref
			//IL_0403: Expected Obj, but got I4
			//IL_02d6: Expected I4, but got I8
			//IL_02e3: Expected Obj, but got I4
			//IL_02f1: Expected Obj, but got I4
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Expected Obj, but got Unknown
			//IL_033a: Expected Obj, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected Obj, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected Obj, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected Obj, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_0175: Expected Obj, but got I4
			//IL_01c6: Expected Obj, but got I4
			//IL_01f8: Expected Obj, but got I4
			int num = ++_bit;
			bool result;
			if (num <= 191)
			{
				ulong* bits = _bits;
				object obj2 = default;
				object obj = (object)(&obj2);
				while (true)
				{
					int num2 = num + 63;
					bool flag = num < 0;
					int num3 = num ^ num;
					int num4 = num & num3;
					bool flag2 = num4 < 0;
					bool flag3 = flag == flag2;
					object obj3 = !flag3;
					object obj4 = ~obj3;
					if (obj4 != null)
					{
						num2 = num;
					}
					int num5 = num2 >> 6;
					int num6 = (int)(num2 & 0xFFFFFFC0L);
					object obj5 = num - num6;
					object obj6 = 1 << (int)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X10_v2 (System.UInt64*)+v27 @ X13_v3 (System.Int32)*8]");
					object obj7 = 0 & obj6;
					bool flag4 = obj7 == null;
					bool flag5 = !flag4;
					bool flag6 = obj7 == null;
					object obj8 = !flag6;
					result = true;
					if (obj8 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X10_v2 (System.UInt64*)+v27 @ X13_v3 (System.Int32)*8]");
					int num7;
					if ((nint)0 != 0)
					{
						object obj9 = obj5 >> 10;
						object obj10 = obj9 & 0x1F;
						object obj11 = obj5 + obj10;
						object obj12 = obj11 >> 5;
						object obj13 = obj12 & 7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X11_v2+v138 @ X16_v9*4]");
						if ((nint)0 != 0)
						{
							object obj14 = obj5 >> 11;
							object obj15 = obj14 & 0xF;
							object obj16 = obj5 + obj15;
							object obj17 = obj16 >> 4;
							object obj18 = obj17 & 0xF;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X11_v2+v145 @ X8_v16*2]");
							if ((nint)0 != 0)
							{
								while (true)
								{
									num7 = num + 1;
									object obj19 = num + 64;
									bool flag7 = num7 < 0;
									int num8 = num7 ^ num7;
									int num9 = num7 & num8;
									bool flag8 = num9 < 0;
									bool flag9 = flag7 == flag8;
									object obj20 = !flag9;
									object obj21 = ~obj20;
									object obj22 = ((obj21 != null) ? ((object)(num + 1)) : obj19);
									bool flag10 = num5 != (nint)obj22;
									num = num7;
									if (flag10)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X10_v2 (System.UInt64*)+v27 @ X13_v3 (System.Int32)*8]");
									int num10 = (int)((nint)0 >> num7);
									int num11 = num10 & 1;
									bool flag11 = num11 == 0;
									num = num7;
									if (flag11)
									{
										continue;
									}
									goto IL_029e;
								}
							}
							else
							{
								num += 16;
							}
						}
						else
						{
							num += 32;
						}
					}
					else
					{
						num += 64;
					}
					_bit = num;
					if (num >= 192)
					{
						result = flag5;
						break;
					}
					continue;
					IL_029e:
					_bit = num7;
					result = true;
					break;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		public unsafe void Dispose()
		{
			//IL_0007: Expected I, but got Obj
			//IL_0016: Expected I4, but got I8
			_bits = (ulong*)unchecked((nint)null);
			_bit = -1;
		}
	}

	public const int SIZE = default(int);

	public const int CAPACITY = default(int);

	[FieldOffset(0)]
	public BitSet256._003CBits_003Ee__FixedBuffer Bits;

	public int Length => 192;

	// C# has no syntax for parameterized property 'Item'.
	[MethodImpl((MethodImplOptions)256)]
	public bool get_Item(int index)
	{
		//IL_005f: Expected Obj, but got I4
		int num = index + 63;
		bool flag = index < 0;
		int num2 = index ^ index;
		int num3 = index & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj = !flag3;
		object obj2 = ~obj;
		if (obj2 != null)
		{
			num = index;
		}
		int num4 = num >> 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+v17 @ X8_v3 (System.Int32)*8]");
		int num5 = (int)((nint)0 >> index);
		return (byte)(num5 & 1) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void set_Item(int index, bool value)
	{
		//IL_0151: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_016a: Expected I4, but got Obj
		//IL_01d6: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_007e: Expected I4, but got Obj
		//IL_00ea: Expected Obj, but got I4
		int num5;
		int num6;
		if (value)
		{
			bool flag = index < 192;
			object obj = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6B98]");
			object error = 0;
			bool condition = (byte)(int)(~obj) != 0;
			Assert.Check(condition, (string)error);
			int num = index + 63;
			bool flag2 = index < 0;
			int num2 = index ^ index;
			int num3 = index & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag2 == flag3;
			object obj2 = !flag4;
			object obj3 = ~obj2;
			if (obj3 != null)
			{
				num = index;
			}
			int num4 = 1 << index;
			num5 = num >> 6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+v136 @ X8_v1 (System.Int32)*8]");
			num6 = (int)((nint)0 | (nint)num4);
			return;
		}
		bool flag5 = index < 192;
		object obj4 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6B98]");
		object error2 = 0;
		bool condition2 = (byte)(int)(~obj4) != 0;
		Assert.Check(condition2, (string)error2);
		int num7 = index + 63;
		bool flag6 = index < 0;
		int num8 = index ^ index;
		int num9 = index & num8;
		bool flag7 = num9 < 0;
		bool flag8 = flag6 == flag7;
		object obj5 = !flag8;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num7 = index;
		}
		int num10 = 1 << index;
		num5 = num7 >> 6;
		int num11 = ~num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+v136 @ X8_v1 (System.Int32)*8]");
		num6 = (int)((nint)0 & (nint)num11);
	}

	public unsafe Iterator GetIterator()
	{
		//IL_0018: Expected I4, but got I8
		//IL_0013: Expected native int or pointer, but got VT
		//IL_004e: Expected VT, but got Ref
		_ = 0;
		Iterator iterator = default;
		((Iterator*)(nint)iterator)->_bit = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		if (num == 0)
		{
			return (Iterator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Iterator result = default;
		return result;
	}

	public unsafe static BitSet192 FromArray(ulong[] values)
	{
		//IL_0186: Expected Obj, but got I
		//IL_0281: Expected I, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got Ref
		//IL_005e: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00bd: Expected VT, but got I4
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00ff: Expected VT, but got Obj
		ArgumentException ex2 = default;
		object obj6;
		string text4;
		ArgumentNullException ex;
		if (values != null)
		{
			if (values.Length == 3)
			{
				object obj = values + 32;
				object obj3 = default;
				object obj2 = (object)(&obj3);
				object obj4 = 0;
				BitSet192 bitSet = default;
				while (true)
				{
					bool flag = (nint)obj4 < values.Length;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj4++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X11_v4+v122 @ X9_v8*8]");
						obj2 = 0;
						obj2 += 8;
						if ((nint)obj4 == 3)
						{
							((BitSet192*)(nint)bitSet)->Bits = (BitSet256._003CBits_003Ee__FixedBuffer)0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
							bool flag2 = num != 0;
							ex = (ArgumentNullException)(object)values;
							if (flag2)
							{
								break;
							}
							return (BitSet192)values;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
					bool flag3 = num2 != 0;
					ex = (ArgumentNullException)(object)values;
					if (flag3)
					{
						break;
					}
					throw new IndexOutOfRangeException();
				}
				goto IL_0228;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text = default;
			string text2 = default;
			ex2._002Ector(text, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			obj6 = 0;
			string text3 = text2;
			text4 = text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex3 = default;
			string text5 = default;
			ex3._002Ector(text5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			obj6 = 0;
			string text3 = null;
			text4 = text5;
			ex2 = ex3;
		}
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		bool flag4 = obj7 != null;
		nint num3 = (nint)text4;
		ex = (ArgumentNullException)ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ex = new ArgumentNullException();
			IntPtr intPtr = default;
			num3 = intPtr;
		}
		goto IL_0228;
		IL_0228:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		BitSet192 result = default;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void Set(int bit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6B98]");
		object error = 0;
		bool flag = bit < 192;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		int num = bit + 63;
		bool flag2 = bit < 0;
		int num2 = bit ^ bit;
		int num3 = bit & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag2 == flag3;
		object obj2 = !flag4;
		object obj3 = ~obj2;
		if (obj3 != null)
		{
			num = bit;
		}
		int num4 = 1 << bit;
		int num5 = num >> 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+v72 @ X8_v5 (System.Int32)*8]");
		int num6 = (int)((nint)0 | (nint)num4);
	}

	[MethodImpl((MethodImplOptions)256)]
	public void Clear(int bit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6B98]");
		object error = 0;
		bool flag = bit < 192;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		int num = bit + 63;
		bool flag2 = bit < 0;
		int num2 = bit ^ bit;
		int num3 = bit & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag2 == flag3;
		object obj2 = !flag4;
		object obj3 = ~obj2;
		if (obj3 != null)
		{
			num = bit;
		}
		int num4 = 1 << bit;
		int num5 = num >> 6;
		int num6 = ~num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+v72 @ X8_v5 (System.Int32)*8]");
		int num7 = (int)((nint)0 & (nint)num6);
	}

	public void And(BitSet192 other)
	{
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		BitSet256._003CBits_003Ee__FixedBuffer bits = (BitSet256._003CBits_003Ee__FixedBuffer)(other.Bits & Bits);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
		object obj = num & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
		object obj2 = num2 & 0;
	}

	public void Or(BitSet192 other)
	{
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		BitSet256._003CBits_003Ee__FixedBuffer bits = (BitSet256._003CBits_003Ee__FixedBuffer)(other.Bits | Bits);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
		object obj = num | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
		object obj2 = num2 | 0;
	}

	public void Xor(BitSet192 other)
	{
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		BitSet256._003CBits_003Ee__FixedBuffer bits = (BitSet256._003CBits_003Ee__FixedBuffer)(other.Bits ^ Bits);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
		object obj = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
		object obj2 = num2 ^ 0;
	}

	public void AndNot(BitSet192 other)
	{
		//IL_000e: Expected Obj, but got VT
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected VT, but got Unknown
		//IL_0038: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		object obj = ~other.Bits;
		BitSet256._003CBits_003Ee__FixedBuffer bits = (BitSet256._003CBits_003Ee__FixedBuffer)(Bits & obj);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+8]");
		object obj2 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
		object obj3 = 0 & obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+10]");
		object obj4 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
		object obj5 = 0 & obj4;
	}

	public void Not()
	{
		//IL_000b: Expected Obj, but got VT
		//IL_001c: Expected Obj, but got I
		//IL_0026: Expected VT, but got Obj
		//IL_003c: Expected Obj, but got I
		object obj = ~Bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
		object obj2 = ~(nint)0;
		Bits = (BitSet256._003CBits_003Ee__FixedBuffer)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
		object obj3 = ~(nint)0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void ClearAll()
	{
		//IL_000b: Expected VT, but got I4
		Bits = (BitSet256._003CBits_003Ee__FixedBuffer)0;
		_ = 0;
		_ = 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool IsSet(int bit)
	{
		//IL_005f: Expected Obj, but got I4
		int num = bit + 63;
		bool flag = bit < 0;
		int num2 = bit ^ bit;
		int num3 = bit & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj = !flag3;
		object obj2 = ~obj;
		if (obj2 != null)
		{
			num = bit;
		}
		int num4 = num >> 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+v17 @ X8_v3 (System.Int32)*8]");
		int num5 = (int)((nint)0 >> bit);
		return (byte)(num5 & 1) != 0;
	}

	public int GetSetCount()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
		object obj4 = 0 + Bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
		return obj4 + 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Any()
	{
		//IL_000b: Invalid comparison between VT and I4
		//IL_001c: Expected Obj, but got I4
		bool flag = Bits == (BitSet256._003CBits_003Ee__FixedBuffer)(object)0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
				bool flag2 = (nint)0 == 0;
				return !flag2;
			}
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Empty()
	{
		//IL_000b: Invalid comparison between VT and I4
		//IL_001c: Expected Obj, but got I4
		bool flag = Bits == (BitSet256._003CBits_003Ee__FixedBuffer)(object)0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
				return (nint)0 == 0;
			}
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		return HashCodeUtilities.GetArrayHashCode((ulong*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), 3, 43);
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0046: Invalid comparison between VT and I
		//IL_00a1: Expected Obj, but got I
		bool result;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BA0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				BitSet256._003CBits_003Ee__FixedBuffer bits = Bits;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if (bits == (BitSet256._003CBits_003Ee__FixedBuffer)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
					object obj3 = default;
					if (0 == (nint)obj3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+20]");
						object obj4 = num - 0;
						bool flag = obj4 == null;
						result = flag;
						goto IL_00fc;
					}
				}
			}
		}
		result = false;
		goto IL_00fc;
		IL_00fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		if (num2 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public bool Equals(BitSet192 other)
	{
		//IL_0072: Expected Obj, but got I
		if (Bits == other.Bits)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+8]");
			if (num == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet192)+10]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet192)+10]");
				object obj = num2 - 0;
				return obj == null;
			}
		}
		return false;
	}

	public unsafe Enumerator GetEnumerator()
	{
		//IL_0002: Expected VT, but got Ref
		return (Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
	}

	private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<int> result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BA8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator result = default;
		return result;
	}

	public static bool operator ==(BitSet192 a, BitSet192 b)
	{
		//IL_006d: Expected Obj, but got I
		bool result;
		if (a.Bits == b.Bits)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (Fusion.BitSet192)+8]");
			object obj = default;
			if (0 == (nint)obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (Fusion.BitSet192)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (Fusion.BitSet192)+10]");
				object obj2 = num - 0;
				bool flag = obj2 == null;
				result = flag;
				goto IL_00ab;
			}
		}
		result = false;
		goto IL_00ab;
		IL_00ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		if (num2 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public static bool operator !=(BitSet192 a, BitSet192 b)
	{
		//IL_006d: Expected Obj, but got I
		bool result;
		if (a.Bits == b.Bits)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (Fusion.BitSet192)+8]");
			object obj = default;
			if (0 == (nint)obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X0 (Fusion.BitSet192)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ X1 (Fusion.BitSet192)+10]");
				object obj2 = num - 0;
				bool flag = obj2 == null;
				bool flag2 = !flag;
				result = flag2;
				goto IL_00b6;
			}
		}
		result = true;
		goto IL_00b6;
		IL_00b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		if (num2 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}
}
