using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4)]
public struct SceneRef : _0021_00210, Action<PressKey>
{
	public const uint FLAG_ADDRESSABLE = default(uint);

	public const uint FLAG_PATH = default(uint);

	[FieldOffset(0)]
	public uint RawValue;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW_VALUE = default(int);

	internal const int BYTE_COUNT_OF_RAW_VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static SceneRef None
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (SceneRef)0;
		}
	}

	public bool IsValid
	{
		get
		{
			bool flag = RawValue == 0;
			return !flag;
		}
	}

	public bool IsIndex
	{
		get
		{
			int num = (int)(~RawValue);
			return (byte)(num >> 31) != 0;
		}
	}

	public int AsIndex
	{
		get
		{
			//IL_0014: Expected I4, but got I8
			//IL_002e: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_00d3: Expected I4, but got Obj
			int num = (int)((int)RawValue & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				return (int)(RawValue - 1);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			string message = string.Format(format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (int)ex2;
		}
	}

	public uint AsPathHash
	{
		get
		{
			//IL_0014: Expected I4, but got I8
			//IL_0056: Expected Obj, but got I
			//IL_00c8: Expected I4, but got Obj
			if ((int)((int)RawValue & 0x80000000L) != 0)
			{
				return RawValue & 0x7FFFFFFF;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			string message = string.Format(format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (uint)(int)ex2;
		}
	}

	public bool IsPath(string path)
	{
		//IL_0014: Expected I4, but got I8
		//IL_002e: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		int num = (int)((int)RawValue & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null)
		{
			return false;
		}
		SceneRef sceneRef = FromPath(path);
		object obj2 = RawValue - sceneRef;
		return obj2 == null;
	}

	public static SceneRef FromIndex(int index)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0036: Expected VT, but got I4
		//IL_008d: Expected VT, but got Obj
		bool flag = index < 2147483647;
		object obj = !flag;
		if (obj == null)
		{
			return (SceneRef)(index + 1);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentOutOfRangeException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (SceneRef)ex2;
	}

	public static SceneRef FromPath(string path)
	{
		//IL_0041: Expected VT, but got I8
		//IL_0098: Expected VT, but got Obj
		if (path != null)
		{
			int hashCodeDeterministic = HashCodeUtilities.GetHashCodeDeterministic(path, 0);
			return (SceneRef)(hashCodeDeterministic | 0x80000000L);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (SceneRef)ex2;
	}

	public static SceneRef FromRaw(uint rawValue)
	{
		//IL_0005: Expected VT, but got I4
		return (SceneRef)rawValue;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EB0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				uint rawValue = RawValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)(int)rawValue - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public bool Equals(SceneRef other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = RawValue - other;
		return obj == null;
	}

	public override int GetHashCode()
	{
		return ((uint)this).GetHashCode();
	}

	public override string ToString()
	{
		return ToString(brackets: true, prefix: true);
	}

	public string ToString(bool brackets, bool prefix)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f1: Expected I4, but got I8
		//IL_010b: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I
		//IL_0260: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		bool flag = !brackets;
		bool flag2 = prefix;
		if (!flag)
		{
			if (stringBuilder == null)
			{
				goto IL_02df;
			}
			StringBuilder stringBuilder2 = stringBuilder.Append('[');
			flag2 = false;
		}
		if (prefix)
		{
			if (stringBuilder == null)
			{
				goto IL_02df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EC8]");
			object value = 0;
			StringBuilder stringBuilder3 = stringBuilder.Append((string)value);
			flag2 = false;
		}
		if (RawValue != 0)
		{
			int num = (int)((int)RawValue & 0x80000000L);
			bool flag3 = num == 0;
			object obj2 = !flag3;
			if (obj2 == null)
			{
				if (stringBuilder != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4208]");
					object value2 = 0;
					StringBuilder stringBuilder4 = stringBuilder.Append((string)value2);
					int asIndex = AsIndex;
					if (stringBuilder4 != null)
					{
						StringBuilder stringBuilder5 = stringBuilder4.Append(asIndex);
						bool flag4 = !brackets;
						object obj3 = !flag4;
						if (obj3 != null)
						{
							goto IL_021e;
						}
						goto IL_0236;
					}
				}
			}
			else
			{
				uint asPathHash = AsPathHash;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				if (stringBuilder != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EC0]");
					object format = 0;
					object arg = default;
					StringBuilder stringBuilder6 = stringBuilder.AppendFormat((string)format, arg);
					bool flag5 = !brackets;
					object obj5 = !flag5;
					if (obj5 != null)
					{
						goto IL_021e;
					}
					goto IL_0236;
				}
			}
		}
		else if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EB8]");
			object value3 = 0;
			StringBuilder stringBuilder7 = stringBuilder.Append((string)value3);
			if (brackets)
			{
				goto IL_021e;
			}
			goto IL_0236;
		}
		goto IL_02df;
		IL_02df:
		return (string)(object)new NullReferenceException();
		IL_021e:
		StringBuilder stringBuilder8 = stringBuilder.Append(']');
		goto IL_0236;
		IL_0236:
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		string result = default;
		return result;
	}

	public unsafe static SceneRef Parse(string str)
	{
		//IL_0eaa: Expected Obj, but got I
		//IL_0c81: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		//IL_0cc8: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_007b: Expected I, but got Obj
		//IL_0ce6: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I4
		//IL_00c6: Expected VT, but got Ref
		//IL_00d3: Expected VT, but got Ref
		//IL_0423: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00fc: Expected I8, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_0d85: Expected Obj, but got I4
		//IL_048c: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I4
		//IL_06a7: Expected Obj, but got I4
		//IL_04b9: Expected VT, but got Ref
		//IL_04c6: Expected VT, but got Ref
		//IL_01b3: Expected Obj, but got I4
		//IL_0675: Expected Obj, but got I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04ef: Expected I8, but got Obj
		//IL_051c: Expected Obj, but got I4
		//IL_0d23: Expected Obj, but got I
		//IL_0d4d: Expected Obj, but got I4
		//IL_0dea: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I4
		//IL_054c: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I4
		//IL_086a: Expected Obj, but got I
		//IL_05c7: Expected Obj, but got I
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_05ef: Expected Obj, but got I4
		//IL_0242: Expected VT, but got Ref
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0277: Expected VT, but got Ref
		//IL_0900: Expected Obj, but got I4
		//IL_06f3: Expected VT, but got Ref
		//IL_0700: Expected VT, but got Ref
		//IL_0631: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02a0: Expected I8, but got Obj
		//IL_02cd: Expected Obj, but got I4
		//IL_08ce: Expected Obj, but got I4
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_0729: Expected I8, but got Obj
		//IL_0756: Expected Obj, but got I4
		//IL_0c6c: Expected VT, but got Obj
		//IL_0e22: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I4
		//IL_0b00: Expected Obj, but got I
		//IL_07cc: Expected Obj, but got I
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07f4: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_0e45: Expected Obj, but got I
		//IL_094c: Expected VT, but got Ref
		//IL_0959: Expected VT, but got Ref
		//IL_082d: Expected VT, but got Ref
		//IL_083f: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_0982: Expected I8, but got Obj
		//IL_09af: Expected Obj, but got I4
		//IL_0e8c: Expected Obj, but got I4
		//IL_0b27: Expected Obj, but got I4
		//IL_09df: Expected Obj, but got I4
		//IL_09ed: Expected Obj, but got I4
		//IL_0a0c: Expected Obj, but got I
		//IL_0a1f: Expected Obj, but got I4
		//IL_0a5a: Expected Obj, but got I
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected Obj, but got Unknown
		//IL_0a82: Expected Obj, but got I4
		//IL_0b82: Expected VT, but got Ref
		//IL_0b8f: Expected VT, but got Ref
		//IL_0abb: Expected VT, but got Ref
		//IL_0acd: Expected Obj, but got I4
		//IL_0ae3: Expected I4, but got I8
		//IL_0aeb: Expected VT, but got I4
		//IL_0baa: Expected I4, but got I8
		//IL_0bb8: Expected I8, but got I4
		//IL_0be5: Expected Obj, but got I4
		//IL_0c04: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
		object obj = 0;
		int num;
		string text;
		nint num2 = default;
		ref char reference;
		if (str != null)
		{
			ref char rawStringData = ref str.GetRawStringData();
			num = str._stringLength;
			text = (string)obj;
			num2 = unchecked((nint)null);
			reference = ref rawStringData;
		}
		else
		{
			text = (string)obj;
			num = 0;
			reference = ref *(char*)null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EE0]");
		object obj2 = 0;
		ref char reference2;
		if (text != null)
		{
			ref char rawStringData2 = ref text.GetRawStringData();
			text = (string)text._stringLength;
			reference2 = ref rawStringData2;
			num2 = unchecked((nint)null);
		}
		else
		{
			reference2 = ref *(char*)null;
		}
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X24_v1+38]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		bool flag2 = (nint)text > num;
		ref byte reference3 = ref *(byte*)num2;
		string text2;
		ref char reference6;
		ref byte reference7;
		object obj6;
		if (!flag2)
		{
			ref char reference4 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			ref char reference5 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2));
			object obj5 = text & 0xFFFFFFFFL;
			ulong length = (ulong)(obj5 << 1);
			bool flag3 = System.SpanHelpers.SequenceEqual(ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference4), ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference5), length);
			bool flag4 = !flag3;
			obj6 = 0;
			reference3 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference5);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
				object obj7 = 0;
				text2 = (string)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CECE0]");
				if ((nint)0 != 0)
				{
					if (obj7 != null)
					{
						goto IL_0199;
					}
				}
				else
				{
					_ = 1;
					bool flag5 = obj7 == null;
					object obj8 = !flag5;
					if (obj8 != null)
					{
						goto IL_0199;
					}
				}
				reference6 = ref *(char*)null;
				reference7 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference5);
				goto IL_0d13;
			}
		}
		goto IL_0cd6;
		IL_0199:
		ref char rawStringData3 = ref text2.GetRawStringData();
		text2 = (string)text2._stringLength;
		reference6 = ref rawStringData3;
		reference7 = ref *(byte*)null;
		goto IL_0d13;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X23_v20+20]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag6 = obj10 == null;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		reference = ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 1);
		obj6 = 0;
		int num3;
		num = num3;
		ref char reference8;
		reference3 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference8);
		goto IL_0cd6;
		IL_08b4:
		string text3;
		ref char rawStringData4 = ref text3.GetRawStringData();
		text3 = (string)text3._stringLength;
		ref char reference9 = ref rawStringData4;
		ref byte reference10 = ref *(byte*)null;
		goto IL_0df8;
		IL_0cd6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EC8]");
		object obj12 = 0;
		string text4 = (string)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CECE0]");
		if ((nint)0 != 0)
		{
			if (obj12 != null)
			{
				goto IL_0409;
			}
		}
		else
		{
			_ = 1;
			bool flag7 = obj12 == null;
			object obj13 = !flag7;
			if (obj13 != null)
			{
				goto IL_0409;
			}
		}
		ref char reference11 = ref *(char*)null;
		goto IL_0d5b;
		IL_0c09:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text5 = default;
		string message = text5 + str;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		FormatException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (SceneRef)ex2;
		IL_0d13:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6ED0]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X24_v20+38]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		bool flag9 = (nint)text2 > num;
		obj6 = 0;
		if (!flag9)
		{
			ref char reference12 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			object obj17 = num - text2;
			object obj18 = obj17 << 32;
			ref byte first = ref *(byte*)((ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference12)) + (ref *(byte*)obj18));
			reference8 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference6));
			object obj19 = text2 & 0xFFFFFFFFL;
			ulong length = (ulong)(obj19 << 1);
			bool flag10 = System.SpanHelpers.SequenceEqual(ref first, ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference8), length);
			bool flag11 = !flag10;
			obj6 = 0;
			reference7 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference8);
			if (!flag11)
			{
				num3 = num - 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EF0]");
				object obj20 = 0;
				object obj21 = obj20;
				if (num != 0)
				{
					object obj22 = num - 1;
					bool flag12 = (nint)obj22 < num3;
					object obj23 = !flag12;
					if (obj23 != null)
					{
						goto IL_0365;
					}
				}
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				goto IL_0365;
			}
		}
		goto IL_0c09;
		IL_065b:
		string text6;
		ref char rawStringData5 = ref text6.GetRawStringData();
		text6 = (string)text6._stringLength;
		ref char reference13 = ref rawStringData5;
		reference10 = ref *(byte*)null;
		goto IL_0dc0;
		IL_0df8:
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X24_v7+38]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		if ((nint)text3 <= num)
		{
			ref char reference14 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			ref char reference15 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference9));
			object obj26 = text3 & 0xFFFFFFFFL;
			ulong length = (ulong)(obj26 << 1);
			bool flag14 = System.SpanHelpers.SequenceEqual(ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference14), ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference15), length);
			bool flag15 = !flag14;
			obj6 = 0;
			reference10 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference15);
			if (!flag15)
			{
				bool flag16 = num < 1;
				object obj27 = !flag16;
				object obj28 = num - 1;
				bool flag17 = obj28 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EE8]");
				object obj29 = 0;
				object obj30 = obj29;
				object obj31 = !flag17;
				object obj32 = obj27 & obj31;
				if (obj32 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X19_v4+20]");
				object obj33 = (nint)0 + (nint)309;
				object obj34 = obj33 & 1;
				bool flag18 = obj34 == null;
				object obj35 = !flag18;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				NumberStyles style = (NumberStyles)(num - 2);
				ReadOnlySpan<char> s = (ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 2));
				uint num4 = uint.Parse(s, style, (IFormatProvider)515);
				int num5 = (int)((int)num4 | 0x80000000L);
				return (SceneRef)num5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EB8]");
		object obj36 = 0;
		string text7 = (string)obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6ED8]");
		object obj37 = 0;
		ref char reference16;
		if (obj36 != null)
		{
			ref char rawStringData6 = ref ((string)obj36).GetRawStringData();
			text7 = (string)text7._stringLength;
			reference16 = ref rawStringData6;
			reference7 = ref *(byte*)null;
		}
		else
		{
			reference16 = ref *(char*)null;
			reference7 = ref reference10;
		}
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X24_v13+38]");
		bool flag19 = (nint)0 == 0;
		object obj39 = !flag19;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		if (num == (nint)text7)
		{
			ref char reference17 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			ref char reference18 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference16));
			int num6 = (int)(num & 0xFFFFFFFFL);
			ulong length = (ulong)(num6 << 1);
			bool flag20 = System.SpanHelpers.SequenceEqual(ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference17), ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference18), length);
			bool flag21 = !flag20;
			obj6 = 0;
			reference7 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference18);
			if (!flag21)
			{
				return (SceneRef)0;
			}
		}
		goto IL_0c09;
		IL_0d5b:
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X24_v3+38]");
		bool flag22 = (nint)0 == 0;
		object obj41 = !flag22;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4208]");
		object obj42 = 0;
		bool flag23 = (nint)text4 > num;
		reference10 = ref reference3;
		if (!flag23)
		{
			ref char reference19 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			ref char reference20 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference11));
			object obj43 = text4 & 0xFFFFFFFFL;
			ulong length = (ulong)(obj43 << 1);
			bool flag24 = System.SpanHelpers.SequenceEqual(ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference19), ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference20), length);
			bool flag25 = !flag24;
			obj6 = 0;
			reference10 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference20);
			if (!flag25)
			{
				bool flag26 = num < 5;
				object obj44 = !flag26;
				object obj45 = num - 5;
				bool flag27 = obj45 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EE8]");
				object obj46 = 0;
				object obj47 = obj46;
				object obj48 = !flag27;
				object obj49 = obj44 & obj48;
				if (obj49 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X22_v21+20]");
				object obj50 = (nint)0 + (nint)309;
				object obj51 = obj50 & 1;
				bool flag28 = obj51 == null;
				object obj52 = !flag28;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				num -= 6;
				reference = ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 6);
				obj6 = 0;
				reference10 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference20);
			}
		}
		text6 = (string)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CECE0]");
		if ((nint)0 != 0)
		{
			if (obj42 != null)
			{
				goto IL_065b;
			}
		}
		else
		{
			_ = 1;
			bool flag29 = obj42 == null;
			object obj53 = !flag29;
			if (obj53 != null)
			{
				goto IL_065b;
			}
		}
		reference13 = ref *(char*)null;
		goto IL_0dc0;
		IL_0409:
		ref char rawStringData7 = ref text4.GetRawStringData();
		text4 = (string)text4._stringLength;
		reference11 = ref rawStringData7;
		reference3 = ref *(byte*)null;
		goto IL_0d5b;
		IL_0dc0:
		object obj54 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X24_v5+38]");
		bool flag30 = (nint)0 == 0;
		object obj55 = !flag30;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
		}
		if ((nint)text6 <= num)
		{
			ref char reference21 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			ref char reference22 = ref MemoryMarshal.GetReference((ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference13));
			object obj56 = text6 & 0xFFFFFFFFL;
			ulong length = (ulong)(obj56 << 1);
			bool flag31 = System.SpanHelpers.SequenceEqual(ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference21), ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference22), length);
			bool flag32 = !flag31;
			obj6 = 0;
			reference10 = ref System.Runtime.CompilerServices.Unsafe.As<char, byte>(ref reference22);
			if (!flag32)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EE8]");
				object obj57 = 0;
				object obj58 = obj57;
				bool flag33 = num == 0;
				object obj59 = !flag33;
				if (obj59 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X19_v5+20]");
				object obj60 = (nint)0 + (nint)309;
				object obj61 = obj60 & 1;
				bool flag34 = obj61 == null;
				object obj62 = !flag34;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				NumberStyles style2 = (NumberStyles)(num - 1);
				ReadOnlySpan<char> s2 = (ReadOnlySpan<char>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference, 1));
				int index = int.Parse(s2, style2, (IFormatProvider)7);
				return FromIndex(index);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6EF8]");
		object obj63 = 0;
		text3 = (string)obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CECE0]");
		if ((nint)0 != 0)
		{
			if (obj63 != null)
			{
				goto IL_08b4;
			}
		}
		else
		{
			_ = 1;
			bool flag35 = obj63 == null;
			object obj64 = !flag35;
			if (obj64 != null)
			{
				goto IL_08b4;
			}
		}
		reference9 = ref *(char*)null;
		goto IL_0df8;
	}

	public static bool operator ==(SceneRef a, SceneRef b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		return obj == null;
	}

	public static bool operator !=(SceneRef a, SceneRef b)
	{
		//IL_000d: Expected Obj, but got VT
		object obj = a - b;
		bool flag = obj == null;
		return !flag;
	}
}
