using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct WordList
{
	private (int, int)[] _words = null;

	private int _count;

	public int Count => _count;

	public Span<(int, int)> AsSpan
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_00b7: Expected VT, but got I4
			//IL_0022: Expected Obj, but got I4
			//IL_0033: Expected Obj, but got I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected VT, but got Unknown
			(int, int)[] words = _words;
			if (_words != null)
			{
				bool flag = _count < words.Length;
				object obj = !flag;
				object obj2 = _count - words.Length;
				bool flag2 = obj2 == null;
				object obj3 = ~obj;
				object obj4 = obj3 | flag2;
				if (obj4 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				return (Span<(int, int)>)(_words + 32);
			}
			if (_count != 0)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return (Span<(int, int)>)0;
		}
	}

	public WordList(ReadOnlySpan<(int, int)> source)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_count = 0;
		IntPtr intPtr = default;
		if (intPtr != (IntPtr)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6760]");
			object obj = 0;
			object obj2 = 1024;
			object obj3 = default;
			obj2 = obj3;
			do
			{
				object obj4 = obj2 << 1;
			}
			while ((nint)obj2 < (nint)intPtr);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			(int, int)[] words = default;
			_words = words;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Span<(int, int)> destination = _words;
			ReadOnlySpan<(int, int)> readOnlySpan = default;
			readOnlySpan.CopyTo(destination);
			_count = (int)(nint)intPtr;
		}
	}

	public void Add(int offset, int value)
	{
		//IL_025a: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00c3: Expected I4, but got Obj
		//IL_01fd: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_01dd: Expected VT, but got I
		(int, int)[] words = _words;
		bool flag = _words == null;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6760]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			(int, int)[] words2 = default;
			_words = words2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			words = _words;
			if (_words == null)
			{
				goto IL_021f;
			}
		}
		int count = _count;
		bool flag2 = _count < words.Length;
		int num = value;
		(int, int)[] array = words;
		if (!flag2)
		{
			int newSize = words.Length << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7048]");
			object obj3 = 0;
			num = (int)obj3;
			Array.Resize(ref System.Runtime.CompilerServices.Unsafe.As<WordList, (int, int)[]>(ref this), newSize);
			count = _count;
			array = _words;
		}
		object obj4 = count - 1;
		(int, int) tuple;
		if (count >= 1)
		{
			if (array == null)
			{
				goto IL_021f;
			}
			bool flag3 = (nint)obj4 < array.Length;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				goto IL_022d;
			}
			object obj6 = (object)array + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v13+20]");
			if ((nint)0 >= (nint)offset)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7050]");
				object format = 0;
				object arg = default;
				object arg2 = default;
				string error = string.Format((string)format, arg, arg2);
				Assert.Fail(error);
				array = _words;
				count = _count;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v13+20]");
				tuple = ((int, int))0;
			}
		}
		int count2 = count + 1;
		_count = count2;
		tuple = (offset, value);
		if (array == null)
		{
			goto IL_021f;
		}
		bool flag4 = count < array.Length;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			object obj9 = array + count;
			_ = 0;
			return;
		}
		goto IL_022d;
		IL_022d:
		throw new IndexOutOfRangeException();
		IL_021f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_022d;
	}

	public void Clear()
	{
		_count = 0;
	}

	public bool RemoveAll(OffsetSet offsetSet)
	{
		//IL_0043: Expected I4, but got Obj
		if (offsetSet != null)
		{
			return RemoveAll(offsetSet._003CsortedOffsets_003EP);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool RemoveAll(int[] sortedOffsets)
	{
		//IL_06e2: Expected I4, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I8
		//IL_0051: Expected Obj, but got I4
		//IL_077f: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0330: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		//IL_0439: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_0554: Expected Obj, but got I4
		//IL_0563: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I4
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		if (sortedOffsets != null)
		{
			if (sortedOffsets.Length < 1)
			{
				goto IL_02bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7058]");
			object error = 0;
			object obj = sortedOffsets.Length & 0xFFFFFFFFL;
			object obj2 = 0;
			int num = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
				object obj3 = !flag;
				object obj5;
				int count;
				object obj16;
				if (obj3 == null)
				{
					object obj4 = (object)sortedOffsets + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v10+20]");
					obj5 = 0;
					bool condition;
					if (obj2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v10+20]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v10+1C]");
						object obj6 = num2 - 0;
						bool flag2 = (nint)obj6 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v10+20]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v10+1C]");
						object obj7 = num3 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v10+20]");
						object obj8 = 0 ^ obj6;
						object obj9 = obj7 & obj8;
						bool flag3 = (nint)obj9 < 0;
						bool flag4 = flag2 == flag3;
						condition = flag4;
					}
					else
					{
						condition = true;
					}
					Assert.Check(condition, (string)error);
					count = _count;
					if (num >= _count)
					{
						goto IL_0286;
					}
					(int, int)[] words = _words;
					if (_words == null)
					{
						break;
					}
					object obj10 = _words + num;
					bool flag5 = num < words.Length;
					object obj11 = !flag5;
					object obj12 = num - words.Length;
					bool flag6 = obj12 == null;
					object obj13 = !flag6;
					object obj14 = obj11 & obj13;
					object obj15 = ~obj14;
					int num4 = ((obj15 != null) ? words.Length : num);
					obj16 = obj10 + 32;
					while (num4 != num)
					{
						object obj17 = obj16;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
						{
							num++;
							obj16 += 8;
							if (count != num)
							{
								continue;
							}
							goto IL_025a;
						}
						goto IL_0267;
					}
				}
				goto IL_06c6;
				IL_025a:
				num = count;
				goto IL_0286;
				IL_0267:
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
				{
					goto IL_0286;
				}
				int num5 = num + 1;
				while (true)
				{
					if (num5 >= count)
					{
						goto IL_0400;
					}
					(int, int)[] words2 = _words;
					if (_words == null)
					{
						break;
					}
					object obj18 = _words + num5;
					bool flag7 = num5 < words2.Length;
					object obj19 = !flag7;
					object obj20 = num5 - words2.Length;
					bool flag8 = obj20 == null;
					object obj21 = !flag8;
					object obj22 = obj19 & obj21;
					object obj15 = ~obj22;
					int num6 = ((obj15 != null) ? words2.Length : num5);
					object obj17 = obj18 + 32;
					while (num6 != num5)
					{
						if (obj17 == obj5)
						{
							num5++;
							obj17 += 8;
							if (count != num5)
							{
								continue;
							}
							goto IL_03f3;
						}
						goto IL_0400;
					}
					goto IL_06c6;
					IL_03f3:
					int num7 = count;
					goto IL_07bc;
					IL_0803:
					int num8 = num5 - num7;
					bool flag9 = num8 < 1;
					object obj23;
					obj2 = obj23;
					if (!flag9)
					{
						Array.Copy(_words, num7, _words, num, num8);
						count = _count;
						num = num8 + num;
						obj2 = obj23;
					}
					continue;
					IL_0400:
					num7 = num5;
					goto IL_07bc;
					IL_07bc:
					obj23 = obj2 + 1;
					bool flag10 = (nint)obj23 < sortedOffsets.Length;
					object obj24 = !flag10;
					if ((nint)obj23 != sortedOffsets.Length)
					{
						if (obj24 == null)
						{
							object obj25 = sortedOffsets + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v15+v130 @ X25_v10*4]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v15+v130 @ X25_v10*4]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v15+v129 @ X25_v9*4]");
							object obj26 = num9 - 0;
							bool flag11 = (nint)obj26 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v15+v130 @ X25_v10*4]");
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v15+v129 @ X25_v9*4]");
							object obj27 = num10 ^ 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v15+v130 @ X25_v10*4]");
							object obj28 = 0 ^ obj26;
							object obj29 = obj27 & obj28;
							bool flag12 = (nint)obj29 < 0;
							bool condition2 = flag11 == flag12;
							Assert.Check(condition2, (string)error);
							count = _count;
							bool flag13 = num7 >= _count;
							num5 = num7;
							if (flag13)
							{
								goto IL_0803;
							}
							(int, int)[] words3 = _words;
							if (_words == null)
							{
								break;
							}
							object obj30 = _words + num7;
							bool flag14 = num7 < words3.Length;
							object obj31 = !flag14;
							object obj32 = num7 - words3.Length;
							bool flag15 = obj32 == null;
							object obj33 = !flag15;
							object obj34 = obj31 & obj33;
							obj15 = ~obj34;
							int num11 = ((obj15 != null) ? words3.Length : num7);
							object obj35 = obj30 + 32;
							num5 = num7;
							while (num11 != num5)
							{
								obj17 = obj35;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
								{
									num5++;
									obj35 += 8;
									if (count != num5)
									{
										continue;
									}
									num5 = count;
								}
								goto IL_0803;
							}
						}
						goto IL_06c6;
					}
					int num12 = count - num7;
					if (num12 >= 1)
					{
						Array.Copy(_words, num7, _words, num, num12);
						num = num12 + num;
					}
					_count = num;
					return true;
				}
				break;
				IL_0286:
				obj = sortedOffsets.Length;
				obj2++;
				if ((nint)obj2 < sortedOffsets.Length)
				{
					continue;
				}
				goto IL_02bc;
				IL_06c6:
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				break;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_02bc:
		return false;
	}
}
