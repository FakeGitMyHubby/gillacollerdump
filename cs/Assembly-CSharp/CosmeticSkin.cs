using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class CosmeticSkin : MonoBehaviour
{
	public Material body;

	public bool furTint;

	public Material eyes;

	public Material blood;

	public string[] pieces;

	public Mesh[] suitMeshes;

	public string[] suitPieces;

	public Material suitMaterial;

	public Mesh suitTrim;

	public Material suitCloth;

	public static readonly int FurColor;

	public bool Covers(Renderer r)
	{
		//IL_0033: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_01dc: Expected Obj, but got I4
		//IL_01c3: Expected I4, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		string[] array = pieces;
		if (pieces != null)
		{
			object obj = array.Length;
			if (array.Length != 0)
			{
				if (array.Length < 1)
				{
					goto IL_018b;
				}
				object obj2 = pieces + 32;
				object obj3 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X23_v5+v30 @ X22_v6*8]");
						bool flag2 = string.IsNullOrEmpty((string)0);
						bool flag3 = !flag2;
						object obj5 = !flag3;
						if (obj5 != null)
						{
							goto IL_0155;
						}
						if ((object)r != null)
						{
							string text = r.name;
							if (text != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X23_v5+v30 @ X22_v6*8]");
								bool flag4 = text.Contains((string)0);
								bool flag5 = !flag4;
								object obj6 = !flag5;
								if (obj6 != null)
								{
									break;
								}
								goto IL_0155;
							}
						}
						NullReferenceException ex = new NullReferenceException();
					}
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					return (byte)(int)ex2 != 0;
					IL_0155:
					obj = array.Length;
					obj3++;
					if ((nint)obj3 < array.Length)
					{
						continue;
					}
					goto IL_018b;
				}
			}
		}
		return true;
		IL_018b:
		return false;
	}

	public CosmeticSkin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4850]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 64;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 72;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 80;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static CosmeticSkin()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4858]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4860]");
		object obj2 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = num;
	}
}
