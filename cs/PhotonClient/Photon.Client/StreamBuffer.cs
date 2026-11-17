using System;
using System.IO;
using Cpp2ILInjected;

namespace Photon.Client;

public class StreamBuffer
{
	private const int DefaultInitialSize = default(int);

	private int pos;

	private int len;

	private byte[] buf;

	public bool CanRead => true;

	public bool CanSeek => true;

	public bool CanWrite => true;

	public int Length => len;

	public int Position
	{
		get
		{
			return pos;
		}
		set
		{
			pos = value;
			if (len < value)
			{
				len = value;
				bool flag = CheckSize(value);
			}
		}
	}

	public int Available
	{
		get
		{
			//IL_0011: Expected Obj, but got I4
			//IL_0027: Expected I4, but got Obj
			object obj = len - pos;
			object obj2 = ~obj;
			return obj & obj2;
		}
	}

	public StreamBuffer(int size = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 24;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public StreamBuffer(byte[] buf)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = buf;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		len = buf.Length;
	}

	public byte[] ToArray()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Array array = default;
		Buffer.BlockCopy(buf, 0, array, 0, len);
		return (byte[])array;
	}

	public byte[] ToArrayFromPos()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		int num = len - pos;
		if (num > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Array array = default;
			Buffer.BlockCopy(buf, pos, array, 0, num);
			return (byte[])array;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		byte[] result = default;
		return result;
	}

	public ArraySegment<byte> ToArraySegmentFromPos()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I4
		//IL_0036: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FADE8]");
		object obj = 0;
		object obj2 = len - pos;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4969888");
		return (ArraySegment<byte>)0;
	}

	public void Compact()
	{
		//IL_00ef: Expected I4, but got I8
		int num = len;
		int num2 = len - pos;
		if (num2 >= 1)
		{
			Buffer.BlockCopy(buf, pos, buf, 0, num2);
			num = len;
		}
		pos = 0;
		if ((int)(num & 0x80000000L) != 0)
		{
			len = 0;
			bool flag = CheckSize(0);
		}
		len = num2;
		bool flag2 = CheckSize(num2);
		if (pos > len)
		{
			pos = len;
		}
	}

	public byte[] GetBuffer()
	{
		return buf;
	}

	public unsafe byte[] GetBufferAndAdvance(int length, out int offset)
	{
		ref int reference = ref *(int*)pos;
		int num = (pos += length);
		if (len < num)
		{
			len = num;
			bool flag = CheckSize(num);
		}
		return buf;
	}

	public void Flush()
	{
	}

	public void Reset()
	{
		pos = 0;
	}

	public long Seek(long offset, SeekOrigin origin)
	{
		//IL_017e: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		//IL_0152: Expected I8, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_00d3: Expected I4, but got I8
		//IL_0080: Expected Obj, but got I
		ArgumentException ex;
		int num;
		if (origin != (SeekOrigin)2)
		{
			if (origin != (SeekOrigin)1)
			{
				if (origin == 0)
				{
					goto IL_0152;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517050]");
				object obj = 0;
				ArgumentException ex2 = default;
				ex = ex2;
				goto IL_018c;
			}
			num = pos;
		}
		else
		{
			num = len;
		}
		long num2 = num + num2;
		goto IL_0152;
		IL_0152:
		long num3 = num2 & 0x80000000L;
		bool flag = num3 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			if (num2 <= len)
			{
				pos = (int)num2;
				return num2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517060]");
			object obj = 0;
			ArgumentException ex3 = default;
			ex = ex3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6517058]");
			object obj = 0;
			ArgumentException ex4 = default;
			ex = ex4;
		}
		goto IL_018c;
		IL_018c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex5 = new ArgumentNullException();
		return (long)ex5;
	}

	public void SetLength(long value)
	{
		//IL_000a: Expected I4, but got I8
		//IL_0014: Expected I4, but got I8
		len = (int)value;
		bool flag = CheckSize((int)value);
		if (pos > len)
		{
			pos = len;
		}
	}

	public void SetCapacityMinimum(int neededSize)
	{
		bool flag = CheckSize(neededSize);
	}

	public int Read(byte[] buffer, int dstOffset, int count)
	{
		//IL_003b: Expected Obj, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected I4, but got Unknown
		//IL_0099: Expected Obj, but got I4
		int num = len - pos;
		int num5;
		if (num >= 1)
		{
			object obj = num - count;
			bool flag = (nint)obj < 0;
			int num2 = num ^ count;
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag2 = num4 < 0;
			bool flag3 = flag == flag2;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			num5 = ((obj3 != null) ? count : num);
			Buffer.BlockCopy(buf, pos, buffer, dstOffset, num5);
			int num6 = pos + num5;
			pos = num6;
		}
		else
		{
			num5 = 0;
		}
		return num5;
	}

	public void Write(byte[] buffer, int srcOffset, int count)
	{
		int num = pos + count;
		bool flag = CheckSize(num);
		if (num > len)
		{
			len = num;
		}
		Buffer.BlockCopy(buffer, srcOffset, buf, pos, count);
		pos = num;
	}

	public unsafe byte ReadByte()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0187: Expected I4, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		int num = this + 16;
		int num2 = num + 4;
		if (((int*)num)->m_value < ((int*)num2)->m_value)
		{
			byte[] array = buf;
			int num3 = ((int*)num)->m_value + 1;
			pos = num3;
			if (buf != null)
			{
				bool flag = ((int*)num)->m_value < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = buf + ((int*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+20]");
					return 0;
				}
				goto IL_0179;
			}
		}
		else
		{
			string text = ((int*)num)->ToString();
			string text2 = ((int*)num2)->ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text3 = default;
			string text4 = default;
			string message = text3 + text + text4 + text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			EndOfStreamException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0179;
		IL_0179:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		return (byte)(int)ex4;
	}

	public void WriteByte(byte value)
	{
		//IL_007c: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		int num = pos;
		if (pos >= len)
		{
			bool flag = CheckSize(len = pos + 1);
			num = pos;
		}
		byte[] array = buf;
		int num2 = num + 1;
		pos = num2;
		if (buf != null)
		{
			bool flag2 = num < array.Length;
			object obj = !flag2;
			if (obj == null)
			{
				object obj2 = buf + num;
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public void WriteBytes(byte v0, byte v1)
	{
		//IL_007d: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		int num = pos;
		int num2 = pos + 2;
		if (len < num2)
		{
			len = num2;
			bool flag = CheckSize(num2);
			num = pos;
		}
		byte[] array = buf;
		int num3 = num + 1;
		pos = num3;
		if (buf == null)
		{
			goto IL_0124;
		}
		bool flag2 = num < array.Length;
		object obj = !flag2;
		if (obj == null)
		{
			object obj2 = buf + num;
			byte[] array2 = buf;
			int num4 = pos + 1;
			pos = num4;
			if (buf == null)
			{
				goto IL_0124;
			}
			bool flag3 = pos < array2.Length;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				object obj4 = buf + pos;
				return;
			}
		}
		goto IL_0132;
		IL_0132:
		throw new IndexOutOfRangeException();
		IL_0124:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0132;
	}

	public void WriteBytes(byte v0, byte v1, byte v2)
	{
		//IL_007d: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		int num = pos;
		int num2 = pos + 3;
		if (len < num2)
		{
			len = num2;
			bool flag = CheckSize(num2);
			num = pos;
		}
		byte[] array = buf;
		int num3 = num + 1;
		pos = num3;
		if (buf == null)
		{
			goto IL_01a8;
		}
		bool flag2 = num < array.Length;
		object obj = !flag2;
		if (obj == null)
		{
			object obj2 = buf + num;
			byte[] array2 = buf;
			int num4 = pos + 1;
			pos = num4;
			if (buf == null)
			{
				goto IL_01a8;
			}
			bool flag3 = pos < array2.Length;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				object obj4 = buf + pos;
				byte[] array3 = buf;
				int num5 = pos + 1;
				pos = num5;
				if (buf == null)
				{
					goto IL_01a8;
				}
				bool flag4 = pos < array3.Length;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					object obj6 = buf + pos;
					return;
				}
			}
		}
		goto IL_01b6;
		IL_01b6:
		throw new IndexOutOfRangeException();
		IL_01a8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01b6;
	}

	public void WriteBytes(byte v0, byte v1, byte v2, byte v3)
	{
		//IL_007d: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		int num = pos;
		int num2 = pos + 4;
		if (len < num2)
		{
			len = num2;
			bool flag = CheckSize(num2);
			num = pos;
		}
		byte[] array = buf;
		int num3 = num + 1;
		pos = num3;
		if (buf == null)
		{
			goto IL_022c;
		}
		bool flag2 = num < array.Length;
		object obj = !flag2;
		if (obj == null)
		{
			object obj2 = buf + num;
			byte[] array2 = buf;
			int num4 = pos + 1;
			pos = num4;
			if (buf == null)
			{
				goto IL_022c;
			}
			bool flag3 = pos < array2.Length;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				object obj4 = buf + pos;
				byte[] array3 = buf;
				int num5 = pos + 1;
				pos = num5;
				if (buf == null)
				{
					goto IL_022c;
				}
				bool flag4 = pos < array3.Length;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					object obj6 = buf + pos;
					byte[] array4 = buf;
					int num6 = pos + 1;
					pos = num6;
					if (buf == null)
					{
						goto IL_022c;
					}
					bool flag5 = pos < array4.Length;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						object obj8 = buf + pos;
						return;
					}
				}
			}
		}
		goto IL_023a;
		IL_023a:
		throw new IndexOutOfRangeException();
		IL_022c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_023a;
	}

	public void WriteBytes(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7)
	{
		//IL_007d: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		int num = pos;
		int num2 = pos + 8;
		if (len < num2)
		{
			len = num2;
			bool flag = CheckSize(num2);
			num = pos;
		}
		byte[] array = buf;
		int num3 = num + 1;
		pos = num3;
		if (buf == null)
		{
			goto IL_043c;
		}
		bool flag2 = num < array.Length;
		object obj = !flag2;
		if (obj == null)
		{
			object obj2 = buf + num;
			byte[] array2 = buf;
			int num4 = pos + 1;
			pos = num4;
			if (buf == null)
			{
				goto IL_043c;
			}
			bool flag3 = pos < array2.Length;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				object obj4 = buf + pos;
				byte[] array3 = buf;
				int num5 = pos + 1;
				pos = num5;
				if (buf == null)
				{
					goto IL_043c;
				}
				bool flag4 = pos < array3.Length;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					object obj6 = buf + pos;
					byte[] array4 = buf;
					int num6 = pos + 1;
					pos = num6;
					if (buf == null)
					{
						goto IL_043c;
					}
					bool flag5 = pos < array4.Length;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						object obj8 = buf + pos;
						byte[] array5 = buf;
						int num7 = pos + 1;
						pos = num7;
						if (buf == null)
						{
							goto IL_043c;
						}
						bool flag6 = pos < array5.Length;
						object obj9 = !flag6;
						if (obj9 == null)
						{
							object obj10 = buf + pos;
							byte[] array6 = buf;
							int num8 = pos + 1;
							pos = num8;
							if (buf == null)
							{
								goto IL_043c;
							}
							bool flag7 = pos < array6.Length;
							object obj11 = !flag7;
							if (obj11 == null)
							{
								object obj12 = buf + pos;
								byte[] array7 = buf;
								int num9 = pos + 1;
								pos = num9;
								if (buf == null)
								{
									goto IL_043c;
								}
								bool flag8 = pos < array7.Length;
								object obj13 = !flag8;
								if (obj13 == null)
								{
									object obj14 = buf + pos;
									byte[] array8 = buf;
									int num10 = pos + 1;
									pos = num10;
									if (buf == null)
									{
										goto IL_043c;
									}
									bool flag9 = pos < array8.Length;
									object obj15 = !flag9;
									if (obj15 == null)
									{
										object obj16 = buf + pos;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_044a;
		IL_044a:
		throw new IndexOutOfRangeException();
		IL_043c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_044a;
	}

	private bool CheckSize(int size)
	{
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01d4: Expected I4, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected I4, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		object obj = this + 24;
		object obj2 = obj;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
			if ((nint)0 < (nint)size)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
				bool flag = (nint)0 < (nint)1;
				object obj3 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
				object obj4 = -1;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				object obj6 = obj3 & obj5;
				object obj7 = ~obj6;
				object obj8;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
					obj8 = 0;
				}
				else
				{
					obj8 = 1;
				}
				object obj9 = default;
				obj8 = obj9;
				do
				{
					object obj10 = obj8 << 1;
				}
				while ((nint)obj8 < size);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Array array = (Array)obj;
				if (obj == null)
				{
					goto IL_01c6;
				}
				object src = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v11 (System.Array)+18]");
				Array array2 = default;
				Buffer.BlockCopy((Array)src, 0, array2, 0, 0);
				obj = array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
			object obj12 = -size;
			bool flag3 = (nint)obj12 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
			int num = (int)((nint)0 ^ (nint)size);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+18]");
			object obj13 = 0 ^ obj12;
			int num2 = num & obj13;
			bool flag4 = num2 < 0;
			bool flag5 = flag3 == flag4;
			return !flag5;
		}
		goto IL_01c6;
		IL_01c6:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
