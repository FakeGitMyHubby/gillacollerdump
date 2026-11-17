using System;
using Cpp2ILInjected;

namespace Fusion;

public struct NetworkArrayReadOnly<T>
{
	private unsafe readonly byte* _array;

	private readonly int _length;

	private readonly IElementReaderWriter<T> _readerWriter;

	public int Length
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArrayReadOnly`1<T>)+8]");
			return 0;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public unsafe T get_Item(int index)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_01cc: Expected VT, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArrayReadOnly`1<T>)+8]");
		bool flag = (nint)0 < (nint)index;
		object obj = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkArrayReadOnly`1<T>)+8]");
		object obj2 = -index;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			byte* array = _array;
			if (_array != null)
			{
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag3 = obj6 == null;
				object obj7 = !flag3;
				nint num = 0;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Fusion.NetworkArrayReadOnly`1>)+A8]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+8]");
				object obj10 = (nint)0 + (nint)309;
				object obj11 = obj10 & 1;
				bool flag4 = obj11 == null;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj13 = default;
					obj9 = obj13;
				}
				while (true)
				{
					IntPtr intPtr2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7 (Il2CppClass<System.Byte*>)+98]");
						object obj15 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v5-8]");
							if (0 == (nint)obj9)
							{
								break;
							}
							obj14--;
							obj15 += 16;
							if ((nint)obj14 != 1)
							{
								continue;
							}
							goto IL_015f;
						}
						object obj16 = (nint)intPtr2 + obj15;
						object obj17 = obj16 + 312;
						goto IL_025c;
					}
					goto IL_015f;
					IL_025c:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v186 @ X0_v11] (should have been resolved before IL gen)");
					continue;
					IL_015f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					goto IL_025c;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			IndexOutOfRangeException ex = default;
			ex._002Ector();
			ArgumentNullException ex2 = new ArgumentNullException();
		}
		NullReferenceException ex3 = new NullReferenceException();
		return (T)ex3;
	}

	internal unsafe NetworkArrayReadOnly(byte* array, int length, IElementReaderWriter<T> readerWriter)
	{
		//IL_0008: Expected VT, but got I
		//IL_0017: Expected I, but got Obj
		NetworkArrayReadOnly<T> networkArrayReadOnly = (NetworkArrayReadOnly<T>)array;
		_array = (byte*)(nint)readerWriter;
	}
}
