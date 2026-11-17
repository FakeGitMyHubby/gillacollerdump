using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public struct PieceKey(byte kind, int id, byte part, int path) : _00210
{
	public const byte Half = default(byte);

	public const byte Part = default(byte);

	public const byte Sawn = default(byte);

	public const byte SawnBody = default(byte);

	public byte kind = kind;

	public byte part = part;

	public int id = id;

	public int path = path;

	public unsafe int Depth
	{
		get
		{
			//IL_0032: Expected VT, but got I4
			//IL_0037: Expected VT, but got Ref
			//IL_006a: Expected Obj, but got I4
			//IL_0078: Expected Obj, but got I4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected I4, but got Unknown
			//IL_00a0: Expected Obj, but got I4
			int num = path;
			if (path >= 2)
			{
				PieceKey pieceKey = (PieceKey)0;
				pieceKey = (PieceKey)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				int num2 = default;
				num = num2;
				int result;
				object obj4;
				do
				{
					bool flag = num < 3;
					object obj = !flag;
					object obj2 = num - 3;
					bool flag2 = obj2 == null;
					result = pieceKey + 1;
					object obj3 = !flag2;
					obj4 = obj & obj3;
				}
				while (obj4 != null);
				return result;
			}
			return 0;
		}
	}

	public bool Valid => false;

	public PieceKey Child(int side)
	{
		//IL_0020: Expected VT, but got I4
		int num = kind | id;
		return (PieceKey)(num | part);
	}

	public bool Equals(PieceKey o)
	{
		//IL_000a: Invalid comparison between I4 and VT
		//IL_002f: Expected Obj, but got VT
		//IL_005e: Expected Obj, but got VT
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I
		if ((object)kind == (object)o)
		{
			object obj = o >> 32;
			if (id == (nint)obj)
			{
				object obj2 = o >> 8;
				object obj3 = obj2 & 0xFFFFFF;
				if ((int)part == (nint)obj3)
				{
					nint num = default;
					object obj4 = path - num;
					return obj4 == null;
				}
			}
		}
		return false;
	}

	public override bool Equals(object o)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00f0: Expected Obj, but got I
		if (o != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7420]");
			object obj = 0;
			if (o == obj)
			{
				byte b = kind;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [o @ X1 (System.Object)+10]");
				if ((nint)(int)b == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [o @ X1 (System.Object)+10]");
					object obj2 = (nint)0 >> 32;
					if (id == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [o @ X1 (System.Object)+10]");
						object obj3 = (nint)0 >> 8;
						object obj4 = obj3 & 0xFFFFFF;
						if ((int)part == (nint)obj4)
						{
							int num = path;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [o @ X1 (System.Object)+18]");
							object obj5 = (nint)num - (nint)0;
							return obj5 == null;
						}
					}
				}
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0011: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0059: Expected I4, but got Obj
		object obj = part - kind;
		object obj2 = obj + kind;
		object obj3 = obj2 * 1000003;
		object obj4 = id + obj3;
		object obj5 = path - obj4;
		return (int)(obj5 + obj4);
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I8
		//IL_009b: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I8
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string text = ((byte)this).ToString();
		string[] array = default;
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = array + 32;
				obj2 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X21_v6-8]");
				object obj3 = 0 & 0xFFFFFFFEL;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
					object obj4 = 0;
					object obj5 = array + 40;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
					string text2 = ((int*)num)->ToString();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj6 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v8-10]");
					object obj7 = -2;
					bool flag2 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag2;
					if (obj9 == null)
					{
						object obj10 = array + 48;
						obj10 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v10-18]");
						object obj11 = 0 & 0xFFFFFFFCL;
						if (obj11 != null)
						{
							object obj12 = array + 56;
							obj12 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							byte b = (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 1));
							string text3 = ((byte*)b)->ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X21_v12-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj13 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X21_v12-20]");
							object obj14 = -4;
							bool flag4 = obj14 == null;
							object obj15 = ~obj13;
							object obj16 = obj15 | flag4;
							if (obj16 == null)
							{
								object obj17 = array + 64;
								obj17 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X21_v14-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj18 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X21_v14-28]");
								object obj19 = -5;
								bool flag6 = obj19 == null;
								object obj20 = ~obj18;
								object obj21 = obj20 | flag6;
								if (obj21 == null)
								{
									object obj22 = array + 72;
									obj22 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num2 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
									string text4 = ((int*)num2)->ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X21_v16-30]");
									bool flag7 = (nint)0 < (nint)6;
									object obj23 = !flag7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X21_v16-30]");
									object obj24 = -6;
									bool flag8 = obj24 == null;
									object obj25 = ~obj23;
									object obj26 = obj25 | flag8;
									if (obj26 == null)
									{
										object obj27 = array + 80;
										obj27 = text4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										return string.Concat(array);
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}
}
