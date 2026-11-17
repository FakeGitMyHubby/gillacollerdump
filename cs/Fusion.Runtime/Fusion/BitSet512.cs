using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using PlayFab.MultiplayerModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2)]
public struct BitSet512 : _0021_00210, Action<ListBuildSummariesResponse>, _0021_00210, Action<LinkXboxAccountResult>
{
	public struct Iterator
	{
		private int _bit = -1;

		public BitSet512 _set;

		public Iterator(BitSet512 set)
		{
			//IL_000f: Expected I4, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [set @ X1 (Fusion.BitSet512)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [set @ X1 (Fusion.BitSet512)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [set @ X1 (Fusion.BitSet512)+10]");
			_ = 0;
			_set = (BitSet512)set.Bits;
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
			if (num <= 511)
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
					if (num < 512)
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

	public unsafe struct Enumerator(ulong* bits) : Action<LinkTwitchAccountResult>, _0021_00210, Action<ListAssetSummariesResponse>
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
			if (num <= 511)
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
					if (num >= 512)
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
	public _2._003CBits_003Ee__FixedBuffer Bits;

	public int Length => 512;

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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+v17 @ X8_v3 (System.Int32)*8]");
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
			bool flag = index < 512;
			object obj = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BF8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+v136 @ X8_v1 (System.Int32)*8]");
			num6 = (int)((nint)0 | (nint)num4);
			return;
		}
		bool flag5 = index < 512;
		object obj4 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BF8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+v136 @ X8_v1 (System.Int32)*8]");
		num6 = (int)((nint)0 & (nint)num11);
	}

	public unsafe Iterator GetIterator()
	{
		//IL_0012: Expected I4, but got I8
		//IL_000d: Expected native int or pointer, but got VT
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Iterator iterator = default;
		((Iterator*)(nint)iterator)->_bit = -1;
		object obj = iterator + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		Iterator result = default;
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Iterator result2 = default;
		return result2;
	}

	public unsafe static BitSet512 FromArray(ulong[] values)
	{
		//IL_01a4: Expected Obj, but got I
		//IL_02a8: Expected I, but got Obj
		//IL_02b9: Expected VT, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got Ref
		//IL_005e: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_024a: Expected VT, but got I4
		//IL_0146: Expected VT, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00bd: Expected VT, but got I4
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_0101: Expected VT, but got I4
		//IL_0114: Expected VT, but got Obj
		ArgumentException ex2 = default;
		object obj7;
		string text4;
		ArgumentNullException ex;
		_2._003CBits_003Ee__FixedBuffer obj6;
		if (values != null)
		{
			if (values.Length == 8)
			{
				object obj = values + 32;
				_2._003CBits_003Ee__FixedBuffer obj3 = default;
				object obj2 = (object)(&obj3);
				object obj4 = 0;
				BitSet512 bitSet = default;
				while (true)
				{
					bool flag = (nint)obj4 < values.Length;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj4++;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X11_v4+v125 @ X9_v8*8]");
						obj2 = 0;
						obj2 += 8;
						if ((nint)obj4 == 8)
						{
							((BitSet512*)(nint)bitSet)->Bits = (_2._003CBits_003Ee__FixedBuffer)0;
							_ = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
							bool flag2 = num != 0;
							ex = (ArgumentNullException)(object)values;
							obj6 = (_2._003CBits_003Ee__FixedBuffer)0;
							if (flag2)
							{
								break;
							}
							return (BitSet512)values;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
					bool flag3 = num2 != 0;
					ex = (ArgumentNullException)(object)values;
					obj6 = (_2._003CBits_003Ee__FixedBuffer)0;
					if (flag3)
					{
						break;
					}
					throw new IndexOutOfRangeException();
				}
				goto IL_024f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text = default;
			string text2 = default;
			ex2._002Ector(text, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
			obj7 = 0;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
			obj7 = 0;
			string text3 = null;
			text4 = text5;
			ex2 = ex3;
		}
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ SYSREG+28]");
		bool flag4 = obj8 != null;
		nint num3 = (nint)text4;
		ex = (ArgumentNullException)ex2;
		obj6 = (_2._003CBits_003Ee__FixedBuffer)0;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ex = new ArgumentNullException();
			IntPtr intPtr = default;
			num3 = intPtr;
			obj6 = (_2._003CBits_003Ee__FixedBuffer)0;
		}
		goto IL_024f;
		IL_024f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		BitSet512 result = default;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void Set(int bit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BF8]");
		object error = 0;
		bool flag = bit < 512;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+v72 @ X8_v5 (System.Int32)*8]");
		int num6 = (int)((nint)0 | (nint)num4);
	}

	[MethodImpl((MethodImplOptions)256)]
	public void Clear(int bit)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I4
		//IL_004a: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BF8]");
		object error = 0;
		bool flag = bit < 512;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+v72 @ X8_v5 (System.Int32)*8]");
		int num7 = (int)((nint)0 & (nint)num6);
	}

	public void And(BitSet512 other)
	{
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		_2._003CBits_003Ee__FixedBuffer bits = (_2._003CBits_003Ee__FixedBuffer)(other.Bits & Bits);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
		object obj = num & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
		object obj2 = num2 & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
		object obj3 = num3 & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
		object obj4 = num4 & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
		object obj5 = num5 & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+30]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
		object obj6 = num6 & 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+38]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
		object obj7 = num7 & 0;
	}

	public void Or(BitSet512 other)
	{
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		_2._003CBits_003Ee__FixedBuffer bits = (_2._003CBits_003Ee__FixedBuffer)(other.Bits | Bits);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
		object obj = num | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
		object obj2 = num2 | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
		object obj3 = num3 | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
		object obj4 = num4 | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
		object obj5 = num5 | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+30]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
		object obj6 = num6 | 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+38]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
		object obj7 = num7 | 0;
	}

	public void Xor(BitSet512 other)
	{
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		_2._003CBits_003Ee__FixedBuffer bits = (_2._003CBits_003Ee__FixedBuffer)(other.Bits ^ Bits);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
		object obj = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
		object obj2 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
		object obj3 = num3 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
		object obj4 = num4 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
		object obj5 = num5 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+30]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
		object obj6 = num6 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+38]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
		object obj7 = num7 ^ 0;
	}

	public void AndNot(BitSet512 other)
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
		//IL_008e: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		object obj = ~other.Bits;
		_2._003CBits_003Ee__FixedBuffer bits = (_2._003CBits_003Ee__FixedBuffer)(Bits & obj);
		Bits = bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+8]");
		object obj2 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
		object obj3 = 0 & obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+10]");
		object obj4 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
		object obj5 = 0 & obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+18]");
		object obj6 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
		object obj7 = 0 & obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+20]");
		object obj8 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
		object obj9 = 0 & obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+28]");
		object obj10 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
		object obj11 = 0 & obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+30]");
		object obj12 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
		object obj13 = 0 & obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+38]");
		object obj14 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
		object obj15 = 0 & obj14;
	}

	public void Not()
	{
		//IL_000b: Expected Obj, but got VT
		//IL_001c: Expected Obj, but got I
		//IL_0026: Expected VT, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		object obj = ~Bits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
		object obj2 = ~(nint)0;
		Bits = (_2._003CBits_003Ee__FixedBuffer)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
		object obj3 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
		object obj4 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
		object obj5 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
		object obj6 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
		object obj7 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
		object obj8 = ~(nint)0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void ClearAll()
	{
		//IL_000b: Expected VT, but got I4
		Bits = (_2._003CBits_003Ee__FixedBuffer)0;
		_ = 0;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+v17 @ X8_v3 (System.Int32)*8]");
		int num5 = (int)((nint)0 >> bit);
		return (byte)(num5 & 1) != 0;
	}

	public int GetSetCount()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
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
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
		int result = (int)(num + 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Any()
	{
		//IL_000b: Invalid comparison between VT and I4
		//IL_001c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		bool flag = Bits == (_2._003CBits_003Ee__FixedBuffer)(object)0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
			bool flag2 = (nint)0 == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
					bool flag4 = (nint)0 == 0;
					object obj4 = !flag4;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
						bool flag5 = (nint)0 == 0;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
							bool flag6 = (nint)0 == 0;
							object obj6 = !flag6;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
									bool flag7 = (nint)0 == 0;
									return !flag7;
								}
							}
						}
					}
				}
			}
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Empty()
	{
		//IL_000b: Invalid comparison between VT and I4
		//IL_001c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I4
		bool flag = Bits == (_2._003CBits_003Ee__FixedBuffer)(object)0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
			bool flag2 = (nint)0 == 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
					bool flag4 = (nint)0 == 0;
					object obj4 = !flag4;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
						bool flag5 = (nint)0 == 0;
						object obj5 = !flag5;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
							bool flag6 = (nint)0 == 0;
							object obj6 = !flag6;
							if (obj6 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
									return (nint)0 == 0;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		return HashCodeUtilities.GetArrayHashCode((ulong*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), 8, 43);
	}

	public unsafe override bool Equals(object obj)
	{
		//IL_0039: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0051: Expected VT, but got Ref
		//IL_005d: Expected VT, but got Ref
		bool result;
		BitSet512 bitSet;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C00]");
			object obj2 = 0;
			if (obj == obj2)
			{
				object obj3 = default;
				result = Equals((BitSet512)(&obj3));
				bitSet = (BitSet512)(&obj3);
				goto IL_0062;
			}
		}
		bitSet = (BitSet512)obj;
		result = false;
		goto IL_0062;
		IL_0062:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public bool Equals(BitSet512 other)
	{
		//IL_015d: Expected Obj, but got I
		if (Bits == other.Bits)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+8]");
			if (num == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+10]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+10]");
				if (num2 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+18]");
					if (num3 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+20]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+20]");
						if (num4 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+28]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+28]");
							if (num5 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+30]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+30]");
								if (num6 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.BitSet512)+38]");
									nint num7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.BitSet512)+38]");
									object obj = num7 - 0;
									return obj == null;
								}
							}
						}
					}
				}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<int> result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator result = default;
		return result;
	}

	public unsafe static bool operator ==(BitSet512 a, BitSet512 b)
	{
		//IL_000e: Expected VT, but got Ref
		//IL_000e: Expected Ref, but got VT
		_2._003CBits_003Ee__FixedBuffer obj = default;
		bool result = ((BitSet512*)a)->Equals((BitSet512)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe static bool operator !=(BitSet512 a, BitSet512 b)
	{
		//IL_000e: Expected VT, but got Ref
		//IL_000e: Expected Ref, but got VT
		//IL_004f: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
		_2._003CBits_003Ee__FixedBuffer obj = default;
		bool flag = ((BitSet512*)a)->Equals((BitSet512)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			object obj2 = (flag ? 1 : 0) ^ 1;
			return (byte)(obj2 & 1) != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result = default;
		return result;
	}
}
