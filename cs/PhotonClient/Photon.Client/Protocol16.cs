using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;

namespace Photon.Client;

public class Protocol16 : Protocol
{
	public enum DeserializationFlags
	{
		// error: enumerator has no value
		None,
		// error: enumerator has no value
		AllowPooledByteArray,
		// error: enumerator has no value
		WrapIncomingStructs
	}

	private readonly byte[] versionBytes;

	private readonly byte[] memShort;

	private readonly long[] memLongBlock;

	private readonly byte[] memLongBlockBytes;

	private static readonly float[] memFloatBlock;

	private static readonly byte[] memFloatBlockBytes;

	private readonly double[] memDoubleBlock;

	private readonly byte[] memDoubleBlockBytes;

	private readonly byte[] memInteger;

	private readonly byte[] memLong;

	private readonly byte[] memFloat;

	private readonly byte[] memDouble;

	public override string ProtocolType
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516988]");
			return (string)0;
		}
	}

	public override byte[] VersionBytes => versionBytes;

	private unsafe bool SerializeCustom(StreamBuffer dout, object serObject)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0603: Expected I, but got Obj
		//IL_0625: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_05c9: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_00df: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_014e: Expected Obj, but got Ref
		//IL_0188: Expected Obj, but got Ref
		//IL_0433: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got Ref
		//IL_0465: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I4
		//IL_0587: Expected I4, but got Obj
		//IL_0278: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I4
		bool flag = serObject == null;
		System.__Canon _Canon = (System.__Canon)(object)dout;
		System.__Canon value = null;
		object obj = serObject;
		if (flag)
		{
			goto IL_03ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
		object obj2 = 0;
		nint num = (nint)serObject;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
		System.__Canon _Canon2 = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v5 (Il2CppClass<System.Object>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v10+130]");
		bool flag2 = num2 < 0;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		System.__Canon _Canon3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v5 (Il2CppClass<System.Object>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v10+130]");
			object obj6 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v11-8]");
			if (0 == (nint)obj3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Object)+18]");
				_Canon3 = (System.__Canon)0;
				goto IL_05fb;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		System.__Canon _Canon4 = default;
		_Canon3 = _Canon4;
		goto IL_05fb;
		IL_05fb:
		nint num4 = (nint)_Canon2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v26 (Il2CppClass<System.__Canon>)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		nint num5 = num4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num5 = (nint)_Canon2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v27 (Il2CppClass<System.__Canon>)+A0]");
		object obj8 = 0;
		bool flag4 = obj8 == null;
		_Canon = (System.__Canon)(object)dout;
		value = null;
		obj = serObject;
		bool flag5;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516990]");
			object obj9 = 0;
			nint num6 = (nint)obj9;
			flag5 = ((Dictionary<System.__Canon, System.__Canon>)obj8).TryGetValue(_Canon3, out value);
			if (!flag5)
			{
				goto IL_03e5;
			}
			bool flag6 = 0 == 0;
			_Canon = _Canon3;
			obj = (object)(&value);
			_Canon2 = null;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-38_v4 (System.__Canon)+20]");
				bool flag7 = (nint)0 == 0;
				_Canon = _Canon3;
				obj = (object)(&value);
				_Canon2 = null;
				if (flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X23_v2 (System.__Canon)+18]");
					string format = default;
					object arg = default;
					string text = string.Format(format, 0, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					NullReferenceException ex = default;
					ex._002Ector(text);
					object obj11 = null;
					string text2 = text;
					object obj12 = 0;
					goto IL_056a;
				}
				bool flag8 = dout == null;
				_Canon = _Canon3;
				obj = (object)(&value);
				_Canon2 = null;
				if (!flag8)
				{
					dout.WriteByte(99);
					bool flag9 = 0 == 0;
					_Canon = (System.__Canon)99;
					obj = null;
					_Canon2 = null;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-38_v4 (System.__Canon)+10]");
						dout.WriteByte(0);
						int position = dout.Position;
						int position2 = dout.Position;
						int num7 = (dout.Position = position2 + 2);
						bool flag10 = 0 == 0;
						_Canon = (System.__Canon)num7;
						obj = null;
						_Canon2 = null;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-38_v4 (System.__Canon)+20]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ stack_-38_v4 (System.__Canon)+20]");
							bool flag11 = (nint)0 == 0;
							_Canon = (System.__Canon)num7;
							obj = null;
							_Canon2 = null;
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v19+28]");
								num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X8_v19+18] (should have been resolved before IL gen)");
								int position3 = dout.Position;
								dout.Position = position;
								bool flag12 = 0 == 0;
								_Canon = (System.__Canon)position;
								obj = null;
								_Canon2 = (System.__Canon)position3;
								if (!flag12)
								{
									byte b = default;
									string text3 = b.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516998]");
									object obj14 = 0;
									string type = (string)obj14 + text3;
									int num9 = default;
									SerializeLengthAsShort(dout, num9, type);
									int position4 = dout.Position;
									int position5 = position4 + num9;
									dout.Position = position5;
									int position6 = dout.Position;
									if (position6 == position3)
									{
										goto IL_03e5;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
									int position7 = dout.Position;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									string format2 = default;
									object arg2 = default;
									object arg3 = default;
									object obj16 = default;
									string text4 = string.Format(format2, arg2, arg3, obj16);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Exception ex2 = default;
									ex2._002Ector(text4);
									object obj11 = obj16;
									string text2 = text4;
									object obj12 = 0;
									goto IL_056a;
								}
							}
						}
					}
				}
			}
		}
		goto IL_03ff;
		IL_03ff:
		throw new NullReferenceException();
		IL_056a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex3 = new ArgumentNullException();
		return (byte)(int)ex3 != 0;
		IL_03e5:
		return flag5;
	}

	private unsafe object DeserializeCustom(StreamBuffer din, byte customTypeCode, DeserializationFlags flags = default(DeserializationFlags))
	{
		//IL_044c: Expected I, but got Obj
		//IL_045c: Expected Obj, but got I
		//IL_0478: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_04be: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_00d9: Expected I4, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_010d: Expected Obj, but got Ref
		//IL_0133: Expected Obj, but got Ref
		//IL_0160: Expected Obj, but got Ref
		//IL_03bb: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got Ref
		//IL_03ed: Expected Obj, but got I
		//IL_01be: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got Ref
		//IL_042c: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+210]");
		object obj = 0;
		bool flag = ((ValueType)(object)this).Equals((object)din);
		object obj2 = (flag ? 1 : 0) & 0x8000;
		bool flag2 = obj2 == null;
		bool flag3 = !flag2;
		System.__Canon value = null;
		object obj3 = 109924352;
		byte[] result;
		System.__Canon _Canon;
		DeserializationFlags deserializationFlags;
		object obj8;
		string text2;
		byte b;
		if (!flag3)
		{
			flag3 = din == null;
			value = null;
			obj3 = 109924352;
			if (!flag3)
			{
				int available = din.Available;
				if (available < (flag ? 1 : 0))
				{
					goto IL_025a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
				obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v59+E4]");
				bool flag4 = (nint)0 == 0;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v59+A0]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v14+8]");
				flag3 = (nint)0 == 0;
				value = null;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65169C8]");
					object obj7 = 0;
					deserializationFlags = (DeserializationFlags)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v14+8]");
					bool flag5 = ((Dictionary<byte, System.__Canon>)0).TryGetValue(customTypeCode, out value);
					bool flag6 = !flag5;
					obj = (object)(&value);
					if (flag6)
					{
						goto IL_025a;
					}
					flag3 = 0 == 0;
					obj = (object)(&value);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ stack_-28_v4 (System.__Canon)+28]");
						flag3 = (nint)0 == 0;
						obj8 = (object)(&value);
						b = customTypeCode;
						_Canon = null;
						if (flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X21_v2 (System.__Canon)+18]");
							string format = default;
							object arg = default;
							string text = string.Format(format, 0, arg);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							NullReferenceException ex = default;
							ex._002Ector(text);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ stack_-28_v4 (System.__Canon)+10]");
							object obj10 = 0;
							deserializationFlags = (DeserializationFlags)0;
							obj8 = null;
							text2 = text;
							goto IL_0375;
						}
						int position = din.Position;
						flag3 = 0 == 0;
						obj = (object)(&value);
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ stack_-28_v4 (System.__Canon)+28]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ stack_-28_v4 (System.__Canon)+28]");
							flag3 = (nint)0 == 0;
							obj = (object)(&value);
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ X8_v19+18] (should have been resolved before IL gen)");
								int position2 = din.Position;
								object obj12 = position2 - position;
								bool flag7 = (nint)obj12 == (flag ? 1 : 0);
								byte[] array = default;
								result = array;
								if (!flag7)
								{
									int position3 = position + (flag ? 1 : 0);
									din.Position = position3;
									result = array;
								}
								goto IL_02b8;
							}
						}
					}
				}
			}
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		_Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		int position4 = din.Position;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format2 = default;
		object arg2 = default;
		object obj13 = default;
		string text3 = string.Format(format2, arg2, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidDataException ex2 = default;
		ex2._002Ector(text3);
		deserializationFlags = (DeserializationFlags)0;
		obj8 = obj13;
		text2 = text3;
		goto IL_0375;
		IL_02b8:
		return result;
		IL_025a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj14 = 0;
		int available2 = din.Available;
		bool flag8 = available2 >= (flag ? 1 : 0);
		int count = (flag ? 1 : 0);
		if (!flag8)
		{
			int available3 = din.Available;
			count = available3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		byte[] array2 = default;
		int num2 = din.Read(array2, 0, count);
		result = array2;
		goto IL_02b8;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		byte b2 = default;
		b = b2;
		throw new ArgumentNullException();
	}

	private Type GetTypeOfCode(byte typeCode)
	{
		//IL_0237: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_02c8: Expected VT, but got I
		//IL_02ea: Expected Obj, but got I4
		//IL_0282: Expected VT, but got Obj
		//IL_02a4: Expected Obj, but got I4
		//IL_0195: Expected VT, but got Obj
		int num = typeCode & 0xFF;
		bool flag = num < 42;
		object obj = !flag;
		object obj2 = num - 42;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		RuntimeTypeHandle runtimeTypeHandle;
		RuntimeTypeHandle handle;
		if (obj4 == null)
		{
			int num2 = typeCode & 0xFF;
			if (num2 == 0 || num2 == 42)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v15+E8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v15+10]");
				runtimeTypeHandle = (RuntimeTypeHandle)((nint)0 + (nint)32);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v21+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				handle = runtimeTypeHandle;
				if (obj7 == null)
				{
					goto IL_0075;
				}
				goto IL_008c;
			}
		}
		else
		{
			object obj8 = num - 97;
			bool flag4 = (nint)obj8 < 25;
			object obj9 = !flag4;
			object obj10 = obj8 - 25;
			bool flag5 = obj10 == null;
			object obj11 = !flag5;
			object obj12 = obj9 & obj11;
			if (obj12 == null)
			{
				object obj13 = 18214912 + 2974;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v10+v56 @ X9_v2]");
				object obj14 = (nint)86043744 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X10_v2 (should have been resolved before IL gen)");
			}
			if (num == 68)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v6+E8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD200]");
				object obj16 = 0;
				handle = (RuntimeTypeHandle)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					runtimeTypeHandle = (RuntimeTypeHandle)obj16;
					goto IL_0075;
				}
				goto IL_008c;
			}
		}
		byte b = default;
		string text = b.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text2 = default;
		string message = text2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		return (Type)(object)new ArgumentNullException();
		IL_008c:
		return Type.GetTypeFromHandle(handle);
		IL_0075:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		handle = runtimeTypeHandle;
		goto IL_008c;
	}

	private Protocol18.GpType GetCodeOfType(Type type)
	{
		//IL_0679: Expected Obj, but got I
		//IL_0689: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0669: Expected I4, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_01be: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_0206: Expected VT, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_014a: Expected VT, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_02d7: Expected VT, but got Obj
		//IL_0324: Expected I, but got Obj
		//IL_0334: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I4
		//IL_049a: Expected VT, but got Obj
		//IL_0377: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I4
		//IL_03cf: Expected VT, but got Obj
		//IL_03e0: Expected Obj, but got I4
		//IL_04ef: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I4
		//IL_040e: Expected Obj, but got I4
		//IL_0547: Expected VT, but got Obj
		//IL_059c: Expected Obj, but got I
		//IL_05ac: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I4
		//IL_05f4: Expected VT, but got Obj
		//IL_0628: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TypeCode typeCode = Type.GetTypeCode(type);
		object obj4 = typeCode - 3;
		bool flag2 = (nint)obj4 < 16;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = 36185 >> (int)obj4;
			object obj7 = obj6 & 1;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				object obj9 = 17289216 + 2512;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X9_v15+v54 @ X8_v4]");
				return (Protocol18.GpType)0;
			}
		}
		if ((object)type != null)
		{
			bool isArray = type.IsArray;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
			object obj10 = 0;
			if (isArray)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD0A8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v10+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj11);
				bool flag5 = type == typeFromHandle;
				bool flag6 = !flag5;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					return (Protocol18.GpType)121;
				}
				return (Protocol18.GpType)120;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj14);
			if (type == typeFromHandle2)
			{
				return (Protocol18.GpType)104;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6503F78]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v16+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj17);
			if (type == typeFromHandle3)
			{
				return (Protocol18.GpType)122;
			}
			nint num = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v11 (Il2CppClass<System.Type>)+3C0]");
			Type type2 = (Type)0;
			bool isExplicitLayout = type.IsExplicitLayout;
			bool flag9 = !isExplicitLayout;
			object obj19 = 0;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v50+E4]");
				bool flag10 = (nint)0 == 0;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj21);
				Type type3 = (Type)type.IsMarshalByRefImpl();
				bool flag11 = typeFromHandle4 == type3;
				bool flag12 = !flag11;
				obj19 = 0;
				type2 = type3;
				if (!flag12)
				{
					return (Protocol18.GpType)68;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65169F8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v25+E4]");
			bool flag13 = (nint)0 == 0;
			object obj25 = !flag13;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj24);
			if (type == typeFromHandle5)
			{
				return (Protocol18.GpType)101;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A00]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v31+E4]");
			bool flag14 = (nint)0 == 0;
			object obj28 = !flag14;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj27);
			if (type == typeFromHandle6)
			{
				return (Protocol18.GpType)113;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v2+E8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A08]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+E4]");
			bool flag15 = (nint)0 == 0;
			object obj31 = !flag15;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj30);
			bool flag16 = type == typeFromHandle7;
			bool flag17 = !flag16;
			object obj32 = !flag17;
			object obj33 = ~obj32;
			if (obj33 == null)
			{
				return (Protocol18.GpType)112;
			}
			return (Protocol18.GpType)0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Protocol18.GpType)(int)ex;
	}

	private Array CreateArrayByType(byte arrayType, short length)
	{
		Type typeOfCode = GetTypeOfCode(arrayType);
		return Array.CreateInstance(typeOfCode, length);
	}

	public void SerializeOperationRequest(StreamBuffer stream, OperationRequest operation, bool setType)
	{
		//IL_0005: Expected I, but got Obj
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		nint num = (nint)this;
		ParameterDictionary parameters = operation.Parameters;
		byte operationCode = operation.OperationCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1 (Il2CppClass<Photon.Client.Protocol16>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1 (Il2CppClass<Photon.Client.Protocol16>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X6_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, ParameterDictionary parameters, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(113);
		}
		stream.WriteByte(operationCode);
		SerializeParameterTable(stream, parameters);
	}

	public override OperationRequest DeserializeOperationRequest(StreamBuffer din, DeserializationFlags flags)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		OperationRequest operationRequest = default;
		operationRequest._002Ector();
		base.Finalize();
		if (operationRequest != null)
		{
			byte operationCode = default;
			operationRequest.OperationCode = operationCode;
			object target = operationRequest + 24;
			ParameterDictionary parameterDictionary = DeserializeParameterDictionary(din, (ParameterDictionary)target, flags);
			target = parameterDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return operationRequest;
		}
		return (OperationRequest)(object)new NullReferenceException();
	}

	public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(112);
		}
		stream.WriteByte(serObject.OperationCode);
		float num = ((Enum)(object)this).System_002EIConvertible_002EToSingle((IFormatProvider)stream);
		if (string.IsNullOrEmpty(serObject.DebugMessage))
		{
			stream.WriteByte(42);
		}
		else
		{
			double num2 = ((Enum)(object)this).System_002EIConvertible_002EToDouble((IFormatProvider)stream);
		}
		SerializeParameterTable(stream, serObject.Parameters);
	}

	public override DisconnectMessage DeserializeDisconnectMessage(StreamBuffer stream)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected I, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		DisconnectMessage disconnectMessage = default;
		disconnectMessage._002Ector();
		bool code = ((ValueType)(object)this).Equals((object)stream);
		if (disconnectMessage != null)
		{
			disconnectMessage.Code = (code ? ((short)1) : ((short)0));
			base.Finalize();
			nint num = (nint)this;
			IFormatProvider provider = default;
			object obj2 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)stream, provider);
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v6+98]");
				object obj4 = ((obj2 != null) ? null : obj2);
				object obj5 = disconnectMessage + 24;
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v6+98]");
				if (obj2 == null)
				{
					object obj6 = obj2;
				}
				else
				{
					object obj6 = null;
				}
			}
			else
			{
				object obj5 = disconnectMessage + 24;
				obj5 = 0;
				object obj6 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ParameterDictionary parameterDictionary = DeserializeParameterDictionary(stream, null, (DeserializationFlags)0);
			object obj7 = disconnectMessage + 32;
			obj7 = parameterDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return disconnectMessage;
		}
		return (DisconnectMessage)(object)new NullReferenceException();
	}

	public override OperationResponse DeserializeOperationResponse(StreamBuffer stream, DeserializationFlags flags = default(DeserializationFlags))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0048: Expected I, but got Obj
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		OperationResponse operationResponse = default;
		operationResponse._002Ector();
		base.Finalize();
		if (operationResponse != null)
		{
			byte operationCode = default;
			operationResponse.OperationCode = operationCode;
			bool returnCode = ((ValueType)(object)this).Equals((object)stream);
			operationResponse.ReturnCode = (returnCode ? ((short)1) : ((short)0));
			base.Finalize();
			nint num = (nint)this;
			IFormatProvider provider = default;
			object obj2 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)stream, provider);
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v7+98]");
				object obj4 = ((obj2 != null) ? null : obj2);
				object obj5 = operationResponse + 24;
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X9_v7+98]");
				if (obj2 == null)
				{
					object obj6 = obj2;
				}
				else
				{
					object obj6 = null;
				}
			}
			else
			{
				object obj5 = operationResponse + 24;
				obj5 = 0;
				object obj6 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			ParameterDictionary parameterDictionary = DeserializeParameterDictionary(stream, null, (DeserializationFlags)0);
			object obj7 = operationResponse + 32;
			obj7 = parameterDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return operationResponse;
		}
		return (OperationResponse)(object)new NullReferenceException();
	}

	public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType)
	{
		if (setType)
		{
			stream.WriteByte(101);
		}
		stream.WriteByte(serObject.Code);
		SerializeParameterTable(stream, serObject.Parameters);
	}

	public override EventData DeserializeEventData(StreamBuffer din, EventData target = null, DeserializationFlags flags = default(DeserializationFlags))
	{
		//IL_002b: Expected Obj, but got I
		EventData eventData;
		if (target != null)
		{
			target.Reset();
			eventData = target;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A68]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			EventData eventData2 = default;
			eventData2._002Ector();
			eventData = eventData2;
		}
		base.Finalize();
		if (eventData != null)
		{
			byte code = default;
			eventData.Code = code;
			ParameterDictionary parameterDictionary = DeserializeParameterDictionary(din, eventData.Parameters, (DeserializationFlags)0);
			return eventData;
		}
		return (EventData)(object)new NullReferenceException();
	}

	private unsafe void SerializeParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters)
	{
		//IL_00d3: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got Ref
		//IL_008a: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		object obj2 = default;
		Dictionary<byte, System.__Canon>.Enumerator enumerator2 = default;
		if (parameters != null && ((Dictionary<byte, System.__Canon>)(object)parameters).Count != 0)
		{
			int count = ((Dictionary<byte, System.__Canon>)(object)parameters).Count;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A98]");
			object obj = 0;
			string text = (string)obj;
			SerializeLengthAsShort(stream, count, (string)obj);
			Dictionary<byte, System.__Canon>.Enumerator enumerator = ((Dictionary<byte, System.__Canon>)(object)parameters).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A88]");
			obj2 = 0;
			int num = count;
			int num4 = default;
			while (enumerator2.MoveNext())
			{
				stream.WriteByte(0);
				nint num2 = (nint)this;
				ulong num3 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)stream);
				text = (string)1;
				num = num4;
			}
		}
		else
		{
			nint num5 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+1A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+1B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X5_v1 (should have been resolved before IL gen)");
		}
		object obj5 = 0;
		object obj6 = 0;
		object obj7 = 0;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A80]");
			object obj8 = 0;
			object obj9 = obj8;
			enumerator2.Dispose();
			bool flag = obj7 == null;
			object obj10 = !flag;
			if (obj10 == null)
			{
				bool flag2 = obj5 == null;
				object obj11 = !flag2;
				OutOfMemoryException ex = (OutOfMemoryException)(&enumerator2);
				if (obj11 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj5 = 0;
				obj6 = 0;
				obj9 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj9 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj5 = 1;
				obj7 = obj6;
				continue;
			}
			if ((nint)obj9 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj7 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj6 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB90C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private unsafe void SerializeParameterTable(StreamBuffer stream, ParameterDictionary parameters)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02a9: Expected I4, but got Obj
		//IL_02cd: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_018d: Expected I4, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got Ref
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_01e3: Expected Obj, but got I4
		//IL_00c6: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I4
		//IL_00e5: Expected I4, but got Obj
		object obj3 = default;
		if (parameters != null && parameters.Count != 0)
		{
			int count = parameters.Count;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6512638]");
			object obj = 0;
			string text = (string)obj;
			SerializeLengthAsShort(stream, count, (string)obj);
			NonAllocDictionary<byte, object>.PairIterator enumerator = parameters.GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A48]");
			obj3 = 0;
			int num = count;
			object obj5 = default;
			byte value = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F330");
				object obj4 = obj5 & 1;
				if (obj4 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F298");
				stream.WriteByte(value);
				nint num2 = (nint)this;
				ulong num3 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)stream);
				text = (string)1;
				num = (int)obj3;
			}
		}
		else
		{
			nint num4 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+1A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+1B0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X5_v1 (should have been resolved before IL gen)");
		}
		object obj8 = 0;
		object obj9 = 0;
		object obj10 = 0;
		NonAllocDictionary<byte, object>.PairIterator pairIterator = default;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516A38]");
			object obj11 = 0;
			int num5 = (int)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F3BC");
			bool flag = obj10 == null;
			object obj12 = !flag;
			if (obj12 == null)
			{
				bool flag2 = obj8 == null;
				object obj13 = !flag2;
				OutOfMemoryException ex = (OutOfMemoryException)(&pairIterator);
				if (obj13 == null)
				{
					break;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj8 = 0;
				obj9 = 0;
				num5 = (int)obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			switch (num5)
			{
			case 2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj8 = 1;
				obj10 = obj9;
				break;
			case 1:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj10 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj9 = obj14;
				break;
			default:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB948");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
	}

	private Dictionary<byte, object> DeserializeParameterTable(StreamBuffer stream, Dictionary<byte, object> target = null)
	{
		//IL_00d9: Expected I, but got Obj
		//IL_0101: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		nint num = (nint)this;
		bool flag = ((ValueType)(object)this).Equals((object)stream);
		bool flag2 = target == null;
		object obj = !flag2;
		Dictionary<byte, System.__Canon> dictionary = (Dictionary<byte, System.__Canon>)(object)target;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515C20]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<byte, System.__Canon> dictionary2 = default;
			dictionary2._002Ector(flag ? 1 : 0);
			dictionary = dictionary2;
		}
		if ((flag ? 1 : 0) >= (true ? 1 : 0))
		{
			if (stream != null)
			{
				int num2 = (flag ? 1 : 0);
				while (true)
				{
					byte key = stream.ReadByte();
					byte b = stream.ReadByte();
					System.__Canon value = (System.__Canon)((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)stream, (IFormatProvider)b);
					if (dictionary == null)
					{
						break;
					}
					dictionary.set_Item(key, value);
					num2--;
					if (num2 != 1)
					{
						continue;
					}
					goto IL_00c1;
				}
			}
			return (Dictionary<byte, object>)(object)new NullReferenceException();
		}
		goto IL_00c1;
		IL_00c1:
		return (Dictionary<byte, object>)(object)dictionary;
	}

	private ParameterDictionary DeserializeParameterDictionary(StreamBuffer stream, ParameterDictionary target = null, DeserializationFlags flags = default(DeserializationFlags))
	{
		//IL_0120: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I4
		nint num = (nint)this;
		bool flag = ((ValueType)(object)this).Equals((object)stream);
		bool flag2 = target == null;
		object obj = !flag2;
		ParameterDictionary parameterDictionary = target;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3058]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ParameterDictionary parameterDictionary2 = default;
			parameterDictionary2._002Ector(flag ? 1 : 0);
			parameterDictionary = parameterDictionary2;
		}
		if ((flag ? 1 : 0) >= (true ? 1 : 0))
		{
			bool flag3 = stream == null;
			int num2 = (flag ? 1 : 0);
			if (!flag3)
			{
				while (true)
				{
					byte code = stream.ReadByte();
					byte b = stream.ReadByte();
					object value = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)stream, (IFormatProvider)b);
					if (parameterDictionary == null)
					{
						break;
					}
					parameterDictionary.Add(code, value);
					num2--;
					if (num2 != 1)
					{
						continue;
					}
					goto IL_0108;
				}
			}
			return (ParameterDictionary)(object)new NullReferenceException();
		}
		goto IL_0108;
		IL_0108:
		return parameterDictionary;
	}

	public override void Serialize(StreamBuffer dout, object serObject, bool setType)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_0510: Expected Obj, but got I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I
		//IL_02c3: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got I4
		//IL_043e: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		object obj = default;
		if (obj == null)
		{
			goto IL_00ec;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8620]");
		object obj2 = 0;
		nint num = (nint)obj;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v9 (Il2CppClass<System.Object>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v16+130]");
		bool flag = num2 < 0;
		object obj4 = !flag;
		object obj5 = ~obj4;
		Protocol16 protocol = default;
		Type type;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v9 (Il2CppClass<System.Object>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v16+130]");
			object obj6 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v16-8]");
			if (0 == (nint)obj3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X2_v5 (System.Object)+18]");
				type = (Type)0;
				protocol = this;
				goto IL_04c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		type = (Type)(object)protocol;
		goto IL_04c9;
		IL_04c9:
		Protocol18.GpType codeOfType = protocol.GetCodeOfType(type);
		object obj7 = codeOfType & (Protocol18.GpType)0xFF;
		object obj8 = obj7 - 98;
		bool flag2 = (nint)obj8 < 24;
		object obj9 = !flag2;
		object obj10 = obj8 - 24;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		object obj12 = obj9 & obj11;
		if (obj12 == null)
		{
			object obj13 = 18214912 + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X9_v13+v255 @ X8_v17]");
			object obj14 = (nint)86048560 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v230 @ X10_v8 (should have been resolved before IL gen)");
			goto IL_00ec;
		}
		StreamBuffer streamBuffer = default;
		bool flag4 = default;
		if ((nint)obj7 == 68)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
			object obj15 = 0;
			type = (Type)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			IDictionary dictionary = default;
			if (dictionary != null)
			{
				SerializeDictionary(streamBuffer, dictionary, flag4);
				return;
			}
			object obj16 = obj;
			throw new InvalidCastException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6DF8]");
		object obj17 = 0;
		object obj18 = obj17;
		string message;
		if (obj != obj17)
		{
			if (SerializeCustom(streamBuffer, obj))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			nint num4 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v8 (Il2CppClass<System.Object>)+130]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v24+130]");
			bool flag5 = num5 < 0;
			object obj19 = !flag5;
			object obj20 = ~obj19;
			object obj16 = obj;
			string text5;
			string text4;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v8 (Il2CppClass<System.Object>)+B0]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v24+130]");
				object obj21 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v10-8]");
				object obj22 = default;
				bool flag6 = 0 != (nint)obj22;
				obj16 = obj;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB47C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEB47C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v33+18]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v436 @ X8_v12+1B8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text = default;
					string text2 = default;
					string text3 = default;
					message = text + text2 + text3;
					text4 = text3;
					text5 = text2;
					goto IL_0470;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			bool flag7 = (object)type == null;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				text5 = null;
			}
			else
			{
				Assembly assembly = ((System.RuntimeType)type).Assembly;
				text5 = (string)(object)assembly;
			}
			string text6 = default;
			message = text6 + text5;
			text4 = null;
			goto IL_0470;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v53+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X2_v5 (System.Object)+10]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X2_v5 (System.Object)+18]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X2_v5 (System.Object)+1C]");
		SerializeByteArraySegment(streamBuffer, (byte[])num7, (int)num8, 0, flag4);
		return;
		IL_00ec:
		if (flag4)
		{
			if (streamBuffer == null)
			{
				throw new NullReferenceException();
			}
			streamBuffer.WriteByte(42);
		}
		return;
		IL_0470:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	private void SerializeByte(StreamBuffer dout, byte serObject, bool setType)
	{
		if (setType)
		{
			dout.WriteByte(98);
		}
		dout.WriteByte(serObject);
	}

	private void SerializeBoolean(StreamBuffer dout, bool serObject, bool setType)
	{
		if (setType)
		{
			dout.WriteByte(111);
		}
		dout.WriteByte(serObject ? ((byte)1) : ((byte)0));
	}

	public unsafe override void SerializeShort(StreamBuffer dout, short serObject, bool setType)
	{
		//IL_008e: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got Ref
		//IL_00ef: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got Ref
		//IL_0170: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got Ref
		//IL_01d9: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got Ref
		//IL_03bb: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got Ref
		//IL_02bf: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		bool flag = default;
		StreamBuffer streamBuffer = default;
		bool lockTaken = default;
		object obj = default;
		if (flag)
		{
			bool flag2 = streamBuffer == null;
			lockTaken = false;
			obj = null;
			if (flag2)
			{
				goto IL_036b;
			}
			streamBuffer.WriteByte(107);
		}
		Monitor.Enter(memShort, ref lockTaken);
		byte[] array = memShort;
		bool flag3 = memShort == null;
		object obj2 = 0;
		NullReferenceException ex = null;
		int num = (int)(&obj);
		object obj3 = (object)(&lockTaken);
		int num2 = (int)(&obj);
		int num3 = 0;
		lockTaken = false;
		obj = memShort;
		if (flag3)
		{
			goto IL_0314;
		}
		bool flag4 = array.Length == 0;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num2 = (int)(&obj);
		short num4 = 0;
		lockTaken = false;
		obj = memShort;
		if (flag4)
		{
			goto IL_0339;
		}
		short num5 = default;
		num2 = num5 >> 8;
		bool flag5 = array.Length == 1;
		array[0] = (byte)num2;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num4 = 0;
		lockTaken = false;
		obj = memShort;
		if (flag5)
		{
			goto IL_0347;
		}
		array[1] = (byte)num5;
		bool flag6 = streamBuffer == null;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num4 = 0;
		StreamBuffer streamBuffer2 = (StreamBuffer)(object)memShort;
		lockTaken = false;
		obj = memShort;
		if (!flag6)
		{
			streamBuffer.Write(memShort, 0, 2);
			obj2 = 0;
			ex = null;
			num = (int)(&obj);
			obj3 = (object)(&lockTaken);
			num3 = 0;
			lockTaken = false;
			goto IL_0270;
		}
		goto IL_035d;
		IL_036b:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)streamBuffer2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			num3 = num4;
			array = (byte[])(object)streamBuffer2;
		}
		else
		{
			if ((nint)streamBuffer2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj4 = default;
			ex = (NullReferenceException)obj4;
			num3 = num4;
			array = (byte[])(object)streamBuffer2;
		}
		goto IL_0270;
		IL_0347:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		streamBuffer2 = (StreamBuffer)(object)array;
		goto IL_035d;
		IL_0270:
		if (obj3 != null)
		{
			Monitor.Exit(((int*)num)->m_value);
			array = null;
		}
		bool flag7 = ex == null;
		object obj5 = !flag7;
		NullReferenceException ex4;
		if (obj5 == null)
		{
			bool flag8 = obj2 == null;
			object obj6 = !flag8;
			num4 = (short)num3;
			ex4 = ex;
			if (obj6 == null)
			{
				return;
			}
			goto IL_032a;
		}
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0314;
		IL_0339:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_0347;
		IL_0314:
		ex4 = new NullReferenceException();
		num4 = (short)num3;
		goto IL_032a;
		IL_035d:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_036b;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0339;
	}

	public unsafe void SerializeLengthAsShort(StreamBuffer dout, int serObject, string type)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		bool flag = serObject < 32768;
		object obj = !flag;
		bool lockTaken = default;
		byte[] array;
		object obj2 = default;
		NullReferenceException ex = default;
		int num2 = default;
		object obj3 = default;
		int num3;
		string text = default;
		int num;
		if (obj == null)
		{
			Monitor.Enter(memShort, ref lockTaken);
			array = memShort;
			bool flag2 = memShort == null;
			num = 0;
			obj2 = 0;
			ex = null;
			num2 = (int)(&obj3);
			num3 = (int)(&lockTaken);
			int num4 = (int)(&obj3);
			lockTaken = false;
			obj3 = memShort;
			if (flag2)
			{
				goto IL_038a;
			}
			bool flag3 = array.Length == 0;
			num = 0;
			obj2 = 0;
			ex = null;
			num2 = (int)(&obj3);
			num3 = (int)(&lockTaken);
			num4 = (int)(&obj3);
			lockTaken = false;
			obj3 = memShort;
			if (flag3)
			{
				goto IL_03a7;
			}
			num4 = serObject >> 8;
			bool flag4 = array.Length == 1;
			array[0] = (byte)num4;
			num = 0;
			obj2 = 0;
			ex = null;
			num2 = (int)(&obj3);
			num3 = (int)(&lockTaken);
			lockTaken = false;
			obj3 = memShort;
			if (flag4)
			{
				goto IL_03b5;
			}
			array[1] = (byte)serObject;
			bool flag5 = dout == null;
			num = 0;
			obj2 = 0;
			ex = null;
			num2 = (int)(&obj3);
			num3 = (int)(&lockTaken);
			lockTaken = false;
			obj3 = memShort;
			if (!flag5)
			{
				dout.Write(memShort, 0, 2);
				text = (string)2;
				num = 0;
				obj2 = 0;
				ex = null;
				num2 = (int)(&obj3);
				num3 = (int)(&lockTaken);
				lockTaken = false;
				goto IL_023c;
			}
			goto IL_03c3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format = default;
		object arg = default;
		string message = string.Format(format, text, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotSupportedException ex2 = default;
		ex2._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex3 = new ArgumentNullException();
		text = null;
		num = 0;
		byte[] array2 = default;
		array = array2;
		num3 = serObject;
		lockTaken = false;
		obj3 = null;
		goto IL_037c;
		IL_03b5:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_03c3;
		IL_03c3:
		NullReferenceException ex5 = new NullReferenceException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj5 = default;
			ex = (NullReferenceException)obj5;
		}
		goto IL_023c;
		IL_037c:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		goto IL_038a;
		IL_038a:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0398;
		IL_03a7:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_03b5;
		IL_0398:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_03a7;
		IL_023c:
		if (((int*)num3)->m_value != 0)
		{
			Monitor.Exit(((int*)num2)->m_value);
			array = null;
		}
		bool flag6 = ex == null;
		object obj6 = !flag6;
		if (obj6 != null)
		{
			goto IL_037c;
		}
		bool flag7 = obj2 == null;
		object obj7 = !flag7;
		ex7 = ex;
		if (obj7 == null)
		{
			return;
		}
		goto IL_0398;
	}

	private unsafe void SerializeInteger(StreamBuffer dout, int serObject, bool setType)
	{
		//IL_008e: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got Ref
		//IL_00ef: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got Ref
		//IL_0170: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got Ref
		//IL_01d9: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got Ref
		//IL_0511: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got Ref
		//IL_03f1: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got Ref
		//IL_0419: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got Ref
		bool flag = default;
		StreamBuffer streamBuffer = default;
		bool lockTaken = default;
		object obj = default;
		if (flag)
		{
			bool flag2 = streamBuffer == null;
			lockTaken = false;
			obj = null;
			if (flag2)
			{
				goto IL_04c1;
			}
			streamBuffer.WriteByte(105);
		}
		Monitor.Enter(memInteger, ref lockTaken);
		byte[] array = memInteger;
		bool flag3 = memInteger == null;
		object obj2 = 0;
		NullReferenceException ex = null;
		int num = (int)(&obj);
		object obj3 = (object)(&lockTaken);
		int num2 = (int)(&obj);
		int num3 = 0;
		lockTaken = false;
		obj = memInteger;
		if (flag3)
		{
			goto IL_044e;
		}
		bool flag4 = array.Length == 0;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num2 = (int)(&obj);
		num3 = 0;
		lockTaken = false;
		obj = memInteger;
		if (flag4)
		{
			goto IL_046b;
		}
		int num4 = default;
		num2 = num4 >> 24;
		bool flag5 = array.Length == 1;
		array[0] = (byte)num2;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num3 = 0;
		lockTaken = false;
		obj = memInteger;
		if (flag5)
		{
			goto IL_0479;
		}
		num2 = num4 >> 16;
		bool flag6 = array.Length < 2;
		object obj4 = !flag6;
		object obj5 = array.Length - 2;
		bool flag7 = obj5 == null;
		array[1] = (byte)num2;
		object obj6 = ~obj4;
		object obj7 = obj6 | flag7;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num3 = 0;
		lockTaken = false;
		obj = memInteger;
		if (obj7 != null)
		{
			goto IL_0487;
		}
		num2 = num4 >> 8;
		bool flag8 = array.Length == 3;
		array[2] = (byte)num2;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num3 = 0;
		lockTaken = false;
		obj = memInteger;
		if (flag8)
		{
			goto IL_0495;
		}
		array[3] = (byte)num4;
		bool flag9 = streamBuffer == null;
		obj2 = 0;
		ex = null;
		num = (int)(&obj);
		obj3 = (object)(&lockTaken);
		num3 = 0;
		StreamBuffer streamBuffer2 = (StreamBuffer)(object)memInteger;
		lockTaken = false;
		obj = memInteger;
		if (!flag9)
		{
			streamBuffer.Write(memInteger, 0, 4);
			obj2 = 0;
			ex = null;
			num = (int)(&obj);
			obj3 = (object)(&lockTaken);
			num4 = 0;
			lockTaken = false;
			goto IL_03a2;
		}
		goto IL_04ab;
		IL_04c1:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)streamBuffer2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			array = (byte[])(object)streamBuffer2;
		}
		else
		{
			if ((nint)streamBuffer2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
			array = (byte[])(object)streamBuffer2;
		}
		goto IL_03a2;
		IL_0495:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		streamBuffer2 = (StreamBuffer)(object)array;
		goto IL_04ab;
		IL_03a2:
		if (obj3 != null)
		{
			Monitor.Exit(((int*)num)->m_value);
			array = null;
		}
		bool flag10 = ex == null;
		object obj9 = !flag10;
		NullReferenceException ex4;
		if (obj9 == null)
		{
			bool flag11 = obj2 == null;
			object obj10 = !flag11;
			num3 = num4;
			ex4 = ex;
			if (obj10 == null)
			{
				return;
			}
			goto IL_045c;
		}
		OutOfMemoryException ex5 = new OutOfMemoryException();
		num3 = num4;
		goto IL_044e;
		IL_0487:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_0495;
		IL_044e:
		ex4 = new NullReferenceException();
		goto IL_045c;
		IL_04ab:
		NullReferenceException ex7 = new NullReferenceException();
		num4 = num3;
		goto IL_04c1;
		IL_045c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_046b;
		IL_046b:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_0479;
		IL_0479:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_0487;
	}

	private unsafe void SerializeLong(StreamBuffer dout, long serObject, bool setType)
	{
		//IL_008e: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got Ref
		//IL_00b5: Expected Obj, but got Ref
		//IL_06bc: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got Ref
		//IL_018d: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got Ref
		//IL_01f9: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got Ref
		//IL_07a0: Expected Obj, but got I4
		//IL_07a8: Expected I4, but got I8
		//IL_07fe: Expected I4, but got I8
		//IL_0265: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got Ref
		//IL_0656: Expected Obj, but got I4
		//IL_0735: Expected I8, but got Obj
		//IL_0632: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0311: Expected Obj, but got I4
		//IL_032c: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got Ref
		//IL_067e: Expected Obj, but got I4
		//IL_0686: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got Ref
		//IL_03eb: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0429: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got Ref
		//IL_053d: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I4
		//IL_056d: Expected Obj, but got Ref
		//IL_0577: Expected I8, but got Obj
		//IL_05c4: Expected Obj, but got I4
		//IL_05c9: Expected I, but got Obj
		//IL_05db: Expected Obj, but got I4
		//IL_05f0: Expected Obj, but got Ref
		StreamBuffer streamBuffer = default;
		bool lockTaken = default;
		object obj = default;
		bool flag = default;
		if (flag)
		{
			bool flag2 = streamBuffer == null;
			lockTaken = false;
			obj = null;
			if (flag2)
			{
				goto IL_0750;
			}
			streamBuffer.WriteByte(108);
		}
		Monitor.Enter(memLongBlock, ref lockTaken);
		Array array = memLongBlock;
		bool flag3 = memLongBlock == null;
		object obj2 = 0;
		NullReferenceException ex = null;
		byte b = (byte)(&obj);
		object obj3 = (object)(&lockTaken);
		int num = 0;
		byte[] array2 = (byte[])(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (flag3)
		{
			goto IL_06ab;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v41 (System.Array)+18]");
		bool flag4 = (nint)0 == 0;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		Array array3 = null;
		array2 = (byte[])(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (flag4)
		{
			goto IL_06d0;
		}
		array3 = memLongBlockBytes;
		Buffer.BlockCopy(memLongBlock, 0, memLongBlockBytes, 0, 8);
		array2 = memLongBlockBytes;
		bool flag5 = memLongBlockBytes == null;
		object obj4 = 0;
		nint num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (flag5)
		{
			goto IL_06de;
		}
		bool flag6 = array2.Length == 0;
		obj4 = 0;
		num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (flag6)
		{
			goto IL_06ec;
		}
		bool flag7 = array2.Length == 1;
		obj4 = 0;
		num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (flag7)
		{
			goto IL_06fa;
		}
		bool flag8 = array2.Length < 2;
		object obj5 = !flag8;
		object obj6 = array2.Length - 2;
		bool flag9 = obj6 == null;
		object obj7 = ~obj5;
		object obj8 = obj7 | flag9;
		obj4 = 0;
		num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (obj8 != null)
		{
			goto IL_0708;
		}
		bool flag10 = array2.Length == 3;
		obj4 = 0;
		num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (flag10)
		{
			goto IL_0716;
		}
		bool flag11 = array2.Length < 7;
		object obj9 = !flag11;
		object obj10 = array2.Length - 7;
		bool flag12 = obj10 == null;
		object obj11 = ~obj9;
		object obj12 = obj11 | flag12;
		obj4 = 0;
		num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memLongBlock;
		if (obj12 != null)
		{
			goto IL_0724;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[4] = array2[3];
		array2[5] = array2[2];
		array2[6] = array2[1];
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[7] = array2[0];
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[0] = array2[4];
		bool flag13 = streamBuffer == null;
		obj4 = 0;
		num2 = 8;
		flag = false;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		long num3 = (long)memLongBlockBytes;
		StreamBuffer streamBuffer2 = (StreamBuffer)(object)memLongBlockBytes;
		lockTaken = false;
		obj = memLongBlock;
		if (!flag13)
		{
			streamBuffer.Write(memLongBlockBytes, 0, 8);
			obj4 = 0;
			num2 = unchecked((nint)null);
			flag = true;
			obj2 = 0;
			ex = null;
			b = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			num = 0;
			lockTaken = false;
			goto IL_0607;
		}
		goto IL_0742;
		IL_0750:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)streamBuffer2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			num = (int)num3;
			array2 = (byte[])(object)streamBuffer2;
		}
		else
		{
			if ((nint)streamBuffer2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj13 = default;
			ex = (NullReferenceException)obj13;
			num = (int)num3;
			array2 = (byte[])(object)streamBuffer2;
		}
		goto IL_0607;
		IL_0724:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		num3 = (long)array3;
		streamBuffer2 = (StreamBuffer)(object)array2;
		goto IL_0742;
		IL_0607:
		if (obj3 != null)
		{
			Monitor.Exit(((byte*)(int)b)->m_value);
			array2 = null;
		}
		bool flag14 = ex == null;
		object obj14 = !flag14;
		NullReferenceException ex4;
		if (obj14 == null)
		{
			bool flag15 = obj2 == null;
			object obj15 = !flag15;
			array3 = (Array)num;
			ex4 = ex;
			if (obj15 == null)
			{
				return;
			}
			goto IL_06c1;
		}
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_06ab;
		IL_0716:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_0724;
		IL_06ab:
		ex4 = new NullReferenceException();
		array3 = (Array)num;
		goto IL_06c1;
		IL_0742:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0750;
		IL_06c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_06d0;
		IL_06d0:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_06de;
		IL_06de:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_06ec;
		IL_06ec:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_06fa;
		IL_06fa:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_0708;
		IL_0708:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		goto IL_0716;
	}

	private unsafe void SerializeFloat(StreamBuffer dout, float serObject, bool setType)
	{
		//IL_0bc9: Expected I4, but got Obj
		//IL_009c: Expected Obj, but got I4
		//IL_0be7: Expected Obj, but got I
		//IL_0bfc: Expected Obj, but got I
		//IL_0c2b: Expected Obj, but got I4
		//IL_0c49: Expected Obj, but got I
		//IL_0c68: Expected Obj, but got Ref
		//IL_0c70: Expected Obj, but got Ref
		//IL_0c89: Expected Obj, but got I
		//IL_0c97: Expected Obj, but got I4
		//IL_0c9f: Expected Obj, but got Ref
		//IL_0ca7: Expected Obj, but got Ref
		//IL_0cb8: Expected Obj, but got Ref
		//IL_0a31: Expected Obj, but got I4
		//IL_0a39: Expected I4, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_0111: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got Ref
		//IL_0132: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_0148: Expected Obj, but got Ref
		//IL_0173: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I4
		//IL_0b46: Expected Obj, but got I4
		//IL_0cd6: Expected Obj, but got I
		//IL_0ce6: Expected Obj, but got I
		//IL_0d05: Expected Obj, but got Ref
		//IL_0d0d: Expected Obj, but got Ref
		//IL_0d26: Expected Obj, but got I
		//IL_0d34: Expected Obj, but got I4
		//IL_0d3c: Expected Obj, but got Ref
		//IL_0d45: Expected Obj, but got I4
		//IL_0d53: Expected I, but got Obj
		//IL_09c4: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got Ref
		//IL_021c: Expected Obj, but got Ref
		//IL_0235: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got Ref
		//IL_0254: Expected Obj, but got I4
		//IL_0262: Expected I, but got Obj
		//IL_09ec: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got Ref
		//IL_02a0: Expected Obj, but got Ref
		//IL_02b9: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got Ref
		//IL_02d8: Expected Obj, but got I4
		//IL_02e6: Expected I, but got Obj
		//IL_031f: Expected Obj, but got I4
		//IL_0335: Expected Obj, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0362: Expected Obj, but got Ref
		//IL_036a: Expected Obj, but got Ref
		//IL_0383: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got Ref
		//IL_03a2: Expected Obj, but got I4
		//IL_03b0: Expected I, but got Obj
		//IL_0adb: Expected I4, but got Obj
		//IL_0ae3: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I
		//IL_0411: Expected Obj, but got I
		//IL_0430: Expected Obj, but got Ref
		//IL_0438: Expected Obj, but got Ref
		//IL_0451: Expected Obj, but got I
		//IL_045f: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I4
		//IL_0476: Expected I, but got Obj
		//IL_04b0: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_04f3: Expected Obj, but got Ref
		//IL_04fb: Expected Obj, but got Ref
		//IL_0514: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_052b: Expected Obj, but got I4
		//IL_0539: Expected I, but got Obj
		//IL_057b: Expected Obj, but got I
		//IL_058b: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got Ref
		//IL_05b2: Expected Obj, but got Ref
		//IL_05cb: Expected Obj, but got I
		//IL_05d9: Expected Obj, but got I4
		//IL_05e2: Expected Obj, but got I4
		//IL_05f0: Expected I, but got Obj
		//IL_0629: Expected Obj, but got I4
		//IL_063f: Expected Obj, but got I
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected Obj, but got Unknown
		//IL_066c: Expected Obj, but got Ref
		//IL_0674: Expected Obj, but got Ref
		//IL_068d: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I4
		//IL_06a4: Expected Obj, but got I4
		//IL_06b2: Expected I, but got Obj
		//IL_06f3: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I
		//IL_0722: Expected Obj, but got Ref
		//IL_072a: Expected Obj, but got Ref
		//IL_0743: Expected Obj, but got I
		//IL_0751: Expected Obj, but got I4
		//IL_075a: Expected Obj, but got I4
		//IL_0768: Expected I, but got Obj
		//IL_0799: Expected Obj, but got I8
		//IL_07b0: Expected Obj, but got Ref
		//IL_07b8: Expected Obj, but got Ref
		//IL_07d1: Expected Obj, but got I
		//IL_07df: Expected Obj, but got I4
		//IL_07e8: Expected Obj, but got I4
		//IL_07f6: Expected I, but got Obj
		//IL_0849: Expected Obj, but got I4
		//IL_087d: Expected Obj, but got Ref
		//IL_0885: Expected Obj, but got Ref
		//IL_089e: Expected Obj, but got I
		//IL_08ac: Expected Obj, but got I4
		//IL_08b5: Expected Obj, but got I4
		//IL_08c3: Expected I, but got Obj
		//IL_08cb: Expected I4, but got Obj
		//IL_08fb: Expected Obj, but got I
		//IL_090b: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I
		//IL_0932: Expected Obj, but got Ref
		//IL_093a: Expected Obj, but got Ref
		//IL_0951: Expected Obj, but got I4
		//IL_095a: Expected Obj, but got I4
		bool flag2 = default;
		bool flag = !flag2;
		StreamBuffer streamBuffer = default;
		byte b = (byte)(int)streamBuffer;
		bool lockTaken = default;
		object obj = default;
		bool flag4;
		if (!flag)
		{
			bool flag3 = streamBuffer == null;
			lockTaken = false;
			obj = null;
			flag4 = flag2;
			if (flag3)
			{
				goto IL_0af6;
			}
			streamBuffer.WriteByte(102);
			flag2 = false;
			b = 102;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516958]");
		flag4 = false;
		bool value = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v50 (System.Boolean)+E4]");
		bool flag5 = (nint)0 == 0;
		object obj2 = !flag5;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = ((bool*)(flag4 ? 1 : 0))->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v50 (System.Boolean)+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		Monitor.Enter(0, ref lockTaken);
		bool value2 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v53 (System.Boolean)+E4]");
		bool flag6 = (nint)0 == 0;
		object obj4 = !flag6;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value2 = ((bool*)(flag4 ? 1 : 0))->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v53 (System.Boolean)+A0]");
		object obj5 = 0;
		Array array = (Array)obj5;
		bool flag7 = obj5 == null;
		object obj6 = (object)(&obj);
		object obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		OutOfMemoryException ex = null;
		object obj8 = 0;
		object obj9 = (object)(&obj);
		object obj10 = (object)(&lockTaken);
		int num = 0;
		byte[] array2 = (byte[])(&lockTaken);
		if (flag7)
		{
			goto IL_0a20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v54 (System.Array)+18]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v54 (System.Array)+18]");
		bool flag8 = (nint)0 == 0;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj9 = (object)(&obj);
		Array array3 = null;
		int num2 = (int)(&lockTaken);
		if (flag8)
		{
			goto IL_0a3e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v29+8]");
		array3 = (Array)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v29+8]");
		Buffer.BlockCopy((Array)obj5, 0, (Array)0, 0, 4);
		bool value3 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v56 (System.Boolean)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj11 = !flag9;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value3 = ((bool*)(flag4 ? 1 : 0))->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v56 (System.Boolean)+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v31+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v31+8]");
		bool flag10 = (nint)0 == 0;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj9 = (object)(&obj);
		object obj13 = 0;
		int num3 = 4;
		nint num4 = unchecked((nint)null);
		num2 = 0;
		if (flag10)
		{
			goto IL_0a4c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+18]");
		bool flag11 = (nint)0 == 0;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj9 = (object)(&obj);
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (flag11)
		{
			goto IL_0a5a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+18]");
		bool flag12 = (nint)0 == 1;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj9 = (object)(&obj);
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (flag12)
		{
			goto IL_0a68;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+18]");
		bool flag13 = (nint)0 < (nint)3;
		object obj14 = !flag13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+18]");
		object obj15 = -3;
		bool flag14 = obj15 == null;
		object obj16 = ~obj14;
		object obj17 = obj16 | flag14;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj9 = (object)(&obj);
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (obj17 != null)
		{
			goto IL_0a76;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+23]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+21]");
		obj10 = 0;
		bool value4 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X10_v18 (System.Boolean)+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X10_v19+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X10_v19+8]");
		bool flag15 = (nint)0 == 0;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (flag15)
		{
			goto IL_0a84;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X10_v2+18]");
		bool flag16 = (nint)0 < (nint)2;
		object obj19 = !flag16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X10_v2+18]");
		object obj20 = -2;
		bool flag17 = obj20 == null;
		object obj21 = ~obj19;
		object obj22 = obj21 | flag17;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (obj22 != null)
		{
			goto IL_0a92;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X10_v2+22]");
		_ = 0;
		bool value5 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X10_v21 (System.Boolean)+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X10_v22+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X10_v22+8]");
		bool flag18 = (nint)0 == 0;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (flag18)
		{
			goto IL_0aa0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X10_v2+18]");
		bool flag19 = (nint)0 < (nint)2;
		object obj24 = !flag19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X10_v2+18]");
		object obj25 = -2;
		bool flag20 = obj25 == null;
		object obj26 = ~obj24;
		object obj27 = obj26 | flag20;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (obj27 != null)
		{
			goto IL_0aae;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+21]");
		_ = 0;
		bool value6 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X9_v20 (System.Boolean)+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X9_v21+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X9_v21+8]");
		bool flag21 = (nint)0 == 0;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (flag21)
		{
			goto IL_0abc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+18]");
		object obj29 = 0 & 0xFFFFFFFCL;
		bool flag22 = obj29 == null;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		num2 = 0;
		if (flag22)
		{
			goto IL_0aca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v2+20]");
		_ = 0;
		bool value7 = ((bool*)(flag4 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v57 (System.Boolean)+E4]");
		bool flag23 = (nint)0 == 0;
		object obj30 = !flag23;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = streamBuffer == null;
		obj6 = (object)(&obj);
		obj7 = (object)(&lockTaken);
		lockTaken = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v27+8]");
		obj = 0;
		ex = null;
		obj8 = 0;
		obj13 = 0;
		num3 = 4;
		num4 = unchecked((nint)null);
		flag2 = (byte)(int)array3 != 0;
		StreamBuffer streamBuffer2 = null;
		if (!flag24)
		{
			bool value8 = ((bool*)(flag4 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v35 (System.Boolean)+A0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v36+8]");
			array2 = (byte[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v36+8]");
			streamBuffer.Write((byte[])0, 0, 4);
			obj6 = (object)(&obj);
			obj7 = (object)(&lockTaken);
			lockTaken = false;
			ex = null;
			obj8 = 0;
			obj13 = 0;
			num3 = 0;
			num4 = 4;
			num = 0;
			goto IL_097a;
		}
		goto IL_0ae8;
		IL_0a3e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0a4c;
		IL_0a4c:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0a5a;
		IL_0a20:
		NullReferenceException ex4 = new NullReferenceException();
		array3 = (Array)num;
		num2 = (int)array2;
		goto IL_0a3e;
		IL_0a68:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0a76;
		IL_0a5a:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_0a68;
		IL_0a92:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_0aa0;
		IL_0a76:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_0a84;
		IL_0a84:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0a92;
		IL_0aa0:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0aae;
		IL_0abc:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0aca;
		IL_097a:
		if (obj7 != null)
		{
			Monitor.Exit(obj6);
			array2 = null;
		}
		bool flag25 = ex == null;
		object obj32 = !flag25;
		if (obj32 == null)
		{
			bool flag26 = obj8 == null;
			object obj33 = !flag26;
			OutOfMemoryException ex12 = ex;
			if (obj33 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex12 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0a20;
		IL_0af6:
		NullReferenceException ex13 = new NullReferenceException();
		if ((nint)streamBuffer2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj8 = 1;
			num = (flag2 ? 1 : 0);
			array2 = (byte[])(object)streamBuffer2;
		}
		else
		{
			if ((nint)streamBuffer2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj34 = default;
			ex = (OutOfMemoryException)obj34;
			num = (flag2 ? 1 : 0);
			array2 = (byte[])(object)streamBuffer2;
		}
		goto IL_097a;
		IL_0aae:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		goto IL_0abc;
		IL_0aca:
		IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
		flag2 = (byte)(int)array3 != 0;
		streamBuffer2 = (StreamBuffer)num2;
		goto IL_0ae8;
		IL_0ae8:
		NullReferenceException ex16 = new NullReferenceException();
		goto IL_0af6;
	}

	private unsafe void SerializeDouble(StreamBuffer dout, double serObject, bool setType)
	{
		//IL_008e: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got Ref
		//IL_00b5: Expected Obj, but got Ref
		//IL_06a4: Expected Obj, but got I4
		//IL_00f6: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got Ref
		//IL_018d: Expected Obj, but got I4
		//IL_019b: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got Ref
		//IL_01f5: Expected Obj, but got I4
		//IL_0203: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got Ref
		//IL_0788: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_026b: Expected I, but got Obj
		//IL_0274: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got Ref
		//IL_063e: Expected Obj, but got I4
		//IL_071d: Expected I4, but got Obj
		//IL_061a: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0305: Expected Obj, but got I4
		//IL_0313: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I4
		//IL_0331: Expected Obj, but got Ref
		//IL_0666: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I4
		//IL_037b: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got Ref
		//IL_03d7: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_0423: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got Ref
		//IL_0525: Expected Obj, but got I4
		//IL_0533: Expected I, but got Obj
		//IL_053c: Expected Obj, but got I4
		//IL_0551: Expected Obj, but got Ref
		//IL_055b: Expected I4, but got Obj
		//IL_05a8: Expected Obj, but got I4
		//IL_05c3: Expected Obj, but got I4
		//IL_05d8: Expected Obj, but got Ref
		bool flag = default;
		StreamBuffer streamBuffer = default;
		bool lockTaken = default;
		object obj = default;
		if (flag)
		{
			bool flag2 = streamBuffer == null;
			lockTaken = false;
			obj = null;
			if (flag2)
			{
				goto IL_0738;
			}
			streamBuffer.WriteByte(100);
		}
		Monitor.Enter(memDoubleBlockBytes, ref lockTaken);
		Array array = memDoubleBlock;
		bool flag3 = memDoubleBlock == null;
		object obj2 = 0;
		NullReferenceException ex = null;
		byte b = (byte)(&obj);
		object obj3 = (object)(&lockTaken);
		int num = 0;
		byte[] array2 = (byte[])(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (flag3)
		{
			goto IL_0693;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v41 (System.Array)+18]");
		bool flag4 = (nint)0 == 0;
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		Array array3 = null;
		array2 = (byte[])(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (flag4)
		{
			goto IL_06b8;
		}
		array3 = memDoubleBlockBytes;
		Buffer.BlockCopy(memDoubleBlock, 0, memDoubleBlockBytes, 0, 8);
		array2 = memDoubleBlockBytes;
		bool flag5 = memDoubleBlockBytes == null;
		object obj4 = 0;
		int num2 = 8;
		nint num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (flag5)
		{
			goto IL_06c6;
		}
		bool flag6 = array2.Length == 0;
		obj4 = 0;
		num2 = 8;
		num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (flag6)
		{
			goto IL_06d4;
		}
		bool flag7 = array2.Length == 1;
		obj4 = 0;
		num2 = 8;
		num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (flag7)
		{
			goto IL_06e2;
		}
		bool flag8 = array2.Length < 2;
		object obj5 = !flag8;
		object obj6 = array2.Length - 2;
		bool flag9 = obj6 == null;
		object obj7 = ~obj5;
		object obj8 = obj7 | flag9;
		obj4 = 0;
		num2 = 8;
		num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (obj8 != null)
		{
			goto IL_06f0;
		}
		bool flag10 = array2.Length == 3;
		obj4 = 0;
		num2 = 8;
		num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (flag10)
		{
			goto IL_06fe;
		}
		bool flag11 = array2.Length < 7;
		object obj9 = !flag11;
		object obj10 = array2.Length - 7;
		bool flag12 = obj10 == null;
		object obj11 = ~obj9;
		object obj12 = obj11 | flag12;
		obj4 = 0;
		num2 = 8;
		num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (obj12 != null)
		{
			goto IL_070c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[4] = array2[3];
		array2[5] = array2[2];
		array2[6] = array2[1];
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[7] = array2[0];
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[0] = array2[4];
		bool flag13 = streamBuffer == null;
		obj4 = 0;
		num2 = 8;
		num3 = unchecked((nint)null);
		obj2 = 0;
		ex = null;
		b = (byte)(&obj);
		obj3 = (object)(&lockTaken);
		flag = (byte)(int)memDoubleBlockBytes != 0;
		StreamBuffer streamBuffer2 = (StreamBuffer)(object)memDoubleBlockBytes;
		lockTaken = false;
		obj = memDoubleBlockBytes;
		if (!flag13)
		{
			streamBuffer.Write(memDoubleBlockBytes, 0, 8);
			obj4 = 0;
			num2 = 0;
			num3 = 8;
			obj2 = 0;
			ex = null;
			b = (byte)(&obj);
			obj3 = (object)(&lockTaken);
			num = 0;
			lockTaken = false;
			goto IL_05ef;
		}
		goto IL_072a;
		IL_0738:
		NullReferenceException ex2 = new NullReferenceException();
		if ((nint)streamBuffer2 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
			num = (flag ? 1 : 0);
			array2 = (byte[])(object)streamBuffer2;
		}
		else
		{
			if ((nint)streamBuffer2 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj13 = default;
			ex = (NullReferenceException)obj13;
			num = (flag ? 1 : 0);
			array2 = (byte[])(object)streamBuffer2;
		}
		goto IL_05ef;
		IL_070c:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		flag = (byte)(int)array3 != 0;
		streamBuffer2 = (StreamBuffer)(object)array2;
		goto IL_072a;
		IL_05ef:
		if (obj3 != null)
		{
			Monitor.Exit(((byte*)(int)b)->m_value);
			array2 = null;
		}
		bool flag14 = ex == null;
		object obj14 = !flag14;
		NullReferenceException ex4;
		if (obj14 == null)
		{
			bool flag15 = obj2 == null;
			object obj15 = !flag15;
			array3 = (Array)num;
			ex4 = ex;
			if (obj15 == null)
			{
				return;
			}
			goto IL_06a9;
		}
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_0693;
		IL_06fe:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		goto IL_070c;
		IL_0693:
		ex4 = new NullReferenceException();
		array3 = (Array)num;
		goto IL_06a9;
		IL_072a:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0738;
		IL_06a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_06b8;
		IL_06b8:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_06c6;
		IL_06c6:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_06d4;
		IL_06d4:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_06e2;
		IL_06e2:
		IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
		goto IL_06f0;
		IL_06f0:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		goto IL_06fe;
	}

	public unsafe override void SerializeString(StreamBuffer stream, string value, bool setType)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0097: Expected VT, but got I
		//IL_00b5: Expected I4, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00e5: Expected I4, but got Obj
		//IL_00fc: Expected I4, but got Obj
		//IL_0104: Expected I4, but got Obj
		//IL_012b: Expected I4, but got Obj
		//IL_015d: Expected I4, but got Obj
		//IL_0165: Expected Obj, but got Ref
		//IL_0193: Expected I4, but got Obj
		//IL_019b: Expected Obj, but got Ref
		//IL_01b6: Expected VT, but got Obj
		bool flag2 = default;
		bool flag = !flag2;
		string text = value;
		if (!flag)
		{
			bool flag3 = stream == null;
			text = value;
			if (flag3)
			{
				goto IL_01b7;
			}
			stream.WriteByte(115);
			text = null;
		}
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v5 (Il2CppClass<System.Text.Encoding>)+1F0]");
			text = (string)0;
			IntPtr intPtr = default;
			Task task = ((Stream)(object)uTF).WriteAsync((byte[])(object)value, 0, flag2 ? 1 : 0, (CancellationToken)(nint)intPtr);
			bool flag4 = (nint)task >= 32768;
			int num2 = (int)task;
			if (flag4)
			{
				string text2 = num2.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string text3 = default;
				string message = text3 + text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				NotSupportedException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65045F8]");
			object obj = 0;
			SerializeLengthAsShort(stream, (int)task, (string)obj);
			bool flag5 = stream == null;
			flag2 = (byte)(int)obj != 0;
			num2 = (int)task;
			text = (string)(object)task;
			if (!flag5)
			{
				byte[] bufferAndAdvance = stream.GetBufferAndAdvance((int)task, out var offset);
				Encoding uTF2 = Encoding.UTF8;
				bool flag6 = value == null;
				flag2 = false;
				num2 = (int)task;
				text = (string)(&offset);
				if (!flag6)
				{
					bool flag7 = uTF2 == null;
					flag2 = false;
					num2 = (int)task;
					text = (string)(&offset);
					if (!flag7)
					{
						((Stream)(object)uTF2).Write((ReadOnlySpan<byte>)value);
						return;
					}
				}
			}
		}
		goto IL_01b7;
		IL_01b7:
		throw new NullReferenceException();
	}

	private unsafe void SerializeArray(StreamBuffer dout, Array serObject, bool setType)
	{
		//IL_0aa4: Expected I4, but got Obj
		//IL_00ad: Expected I8, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_0026: Expected I8, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_0144: Expected I8, but got I4
		//IL_015a: Expected I4, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I
		//IL_02f2: Expected I, but got Obj
		//IL_0314: Expected Obj, but got I4
		//IL_0b4f: Expected Obj, but got I
		//IL_0b70: Expected I8, but got I4
		//IL_0b88: Expected I4, but got Obj
		//IL_0b98: Expected Obj, but got I
		//IL_0ba8: Expected I4, but got Obj
		//IL_0202: Expected I8, but got I4
		//IL_021a: Expected I4, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_023a: Expected I4, but got Obj
		//IL_0243: Expected Obj, but got I4
		//IL_033c: Expected I, but got Obj
		//IL_0351: Expected Obj, but got I
		//IL_0359: Expected I4, but got Obj
		//IL_0398: Expected I8, but got I4
		//IL_03b3: Expected Obj, but got Ref
		//IL_03c3: Expected I4, but got Obj
		//IL_026c: Expected Obj, but got I4
		//IL_0a2a: Expected Obj, but got I4
		//IL_03f2: Expected I8, but got I4
		//IL_0405: Expected Obj, but got Ref
		//IL_0415: Expected I4, but got Obj
		//IL_0453: Expected I8, but got I4
		//IL_046c: Expected Obj, but got I4
		//IL_0474: Expected I4, but got Obj
		//IL_04af: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_050a: Expected I8, but got I4
		//IL_0beb: Expected Obj, but got I4
		//IL_054d: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I
		//IL_086e: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I
		//IL_0603: Expected Obj, but got I4
		//IL_0661: Expected I8, but got I4
		//IL_0671: Expected Obj, but got I4
		//IL_067e: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I4
		//IL_076e: Expected Obj, but got I
		//IL_07b0: Expected I8, but got I4
		//IL_07c0: Expected I4, but got Obj
		bool flag = !setType;
		Array array = serObject;
		byte b = (byte)(int)dout;
		System.__Canon value;
		object obj;
		byte b2;
		bool flag4;
		StreamBuffer streamBuffer;
		long num;
		short num2;
		bool flag3;
		if (!flag)
		{
			bool flag2 = dout == null;
			b2 = 0;
			num = 0L;
			num2 = 0;
			value = null;
			flag3 = setType;
			array = serObject;
			streamBuffer = dout;
			flag4 = setType;
			obj = 109924352;
			if (flag2)
			{
				goto IL_0807;
			}
			dout.WriteByte(121);
			array = null;
			b = 121;
		}
		bool flag5 = serObject == null;
		b2 = 0;
		num = 0L;
		num2 = 0;
		value = null;
		flag3 = setType;
		streamBuffer = (StreamBuffer)b;
		flag4 = setType;
		obj = 109924352;
		string text9;
		string text;
		int num10;
		System.__Canon _Canon;
		string text2;
		Array array2;
		string text7;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6512638]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
			SerializeLengthAsShort(dout, 0, (string)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			object obj3 = default;
			bool flag6 = obj3 == null;
			b2 = 0;
			num = 0L;
			num2 = 0;
			value = null;
			flag3 = (byte)(int)obj2 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
			array = (Array)0;
			streamBuffer = dout;
			flag4 = setType;
			obj = 109924352;
			if (!flag6)
			{
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X8_v13+418] (should have been resolved before IL gen)");
				Protocol16 protocol = default;
				Protocol18.GpType codeOfType = protocol.GetCodeOfType((Type)(object)protocol);
				object obj5 = codeOfType & (Protocol18.GpType)0xFF;
				if (obj5 != null)
				{
					bool flag7 = dout == null;
					b2 = 0;
					num = 0L;
					num2 = 0;
					value = null;
					flag3 = (byte)(int)obj2 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
					array = (Array)0;
					streamBuffer = (StreamBuffer)(object)protocol;
					flag4 = (byte)(int)protocol != 0;
					obj = 109924352;
					if (!flag7)
					{
						dout.WriteByte((byte)codeOfType);
						object obj6 = codeOfType & (Protocol18.GpType)0xFF;
						if ((nint)obj6 == 68)
						{
							SerializeDictionaryHeader(dout, serObject, out var setKeyType, out var setValueType);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
							if ((nint)0 >= (nint)1)
							{
								int num3 = 0;
								int num4;
								do
								{
									bool flag8 = !setValueType;
									bool setValueType2 = !flag8;
									bool flag9 = !setKeyType;
									bool setKeyType2 = !flag9;
									object value2 = serObject.GetValue(num3);
									SerializeDictionaryElements(dout, value2, setKeyType2, setValueType2);
									num3++;
									num4 = num3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
								}
								while ((nint)num4 < (nint)0);
							}
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
						if ((nint)0 >= (nint)1)
						{
							int num5 = 0;
							int num7;
							do
							{
								object value3 = serObject.GetValue(num5);
								ulong num6 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)dout);
								num5++;
								num7 = num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
							}
							while ((nint)num7 < (nint)0);
						}
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
					obj = 0;
					nint num8 = (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v45 (Il2CppClass<System.Object>)+E4]");
					bool flag10 = (nint)0 == 0;
					object obj7 = !flag10;
					nint num9 = num8;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						num9 = (nint)obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v46 (Il2CppClass<System.Object>)+A0]");
					object obj8 = 0;
					bool flag11 = obj8 == null;
					b2 = 0;
					num = 0L;
					num2 = 0;
					value = null;
					flag3 = (byte)(int)obj2 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
					array = (Array)0;
					streamBuffer = (StreamBuffer)(object)protocol;
					flag4 = (byte)(int)protocol != 0;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516990]");
						text = (string)0;
						flag3 = (byte)(int)text != 0;
						bool flag12 = ((Dictionary<System.__Canon, System.__Canon>)obj8).TryGetValue((System.__Canon)(object)protocol, out value);
						bool flag13 = !flag12;
						num10 = 0;
						b2 = 0;
						num = 0L;
						num2 = 0;
						text2 = text;
						array2 = (Array)(&value);
						_Canon = (System.__Canon)(object)protocol;
						flag4 = (byte)(int)protocol != 0;
						if (flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							bool flag14 = !flag4;
							object obj9 = !flag14;
							string text3;
							if (obj9 == null)
							{
								text3 = null;
							}
							else
							{
								bool value4 = ((bool*)(flag4 ? 1 : 0))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v574 @ X8_v5 (System.Boolean)+168] (should have been resolved before IL gen)");
								string text4 = default;
								text3 = text4;
							}
							string text6 = default;
							string text5 = text6 + text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							NotSupportedException ex = default;
							ex._002Ector(text5);
							array2 = null;
							text7 = text5;
							goto IL_09ed;
						}
						bool flag15 = dout == null;
						b2 = 0;
						num = 0L;
						num2 = 0;
						array = (Array)(&value);
						streamBuffer = (StreamBuffer)(object)protocol;
						flag4 = (byte)(int)protocol != 0;
						if (!flag15)
						{
							dout.WriteByte(99);
							bool flag16 = 0 == 0;
							b2 = 0;
							num = 0L;
							num2 = 0;
							array = null;
							streamBuffer = (StreamBuffer)99;
							flag4 = (byte)(int)protocol != 0;
							if (!flag16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ stack_-58_v5 (System.__Canon)+10]");
								dout.WriteByte(0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
								object obj10 = -1;
								bool flag17 = obj10 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
								if ((nint)0 < (nint)1)
								{
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516998]");
								object obj11 = 0;
								b2 = 0;
								num = 0L;
								num2 = 0;
								flag4 = false;
								short num13 = default;
								while (true)
								{
									object value5 = serObject.GetValue(flag4 ? 1 : 0);
									bool flag18 = value == null;
									System.__Canon _Canon2 = value;
									array = null;
									streamBuffer = (StreamBuffer)flag4;
									if (flag18)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ stack_-58_v5 (System.__Canon)+20]");
									bool flag19 = (nint)0 == 0;
									_Canon2 = value;
									array = null;
									streamBuffer = (StreamBuffer)flag4;
									if (flag19)
									{
										goto IL_0812;
									}
									int position = dout.Position;
									int position2 = dout.Position;
									int num11 = (dout.Position = position2 + 2);
									bool flag20 = value == null;
									_Canon2 = value;
									array = null;
									streamBuffer = (StreamBuffer)num11;
									if (flag20)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ stack_-58_v5 (System.__Canon)+20]");
									object obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ stack_-58_v5 (System.__Canon)+20]");
									bool flag21 = (nint)0 == 0;
									_Canon2 = value;
									array = null;
									streamBuffer = (StreamBuffer)num11;
									if (flag21)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v24+28]");
									flag3 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X8_v24+18] (should have been resolved before IL gen)");
									int position3 = dout.Position;
									dout.Position = position;
									bool flag22 = value == null;
									num = position3;
									num2 = num13;
									_Canon2 = (System.__Canon)num13;
									array = null;
									streamBuffer = (StreamBuffer)position;
									if (flag22)
									{
										break;
									}
									string text8 = b2.ToString();
									text = (string)obj11;
									text9 = (string)obj11 + text8;
									SerializeLengthAsShort(dout, num13, text9);
									int position4 = dout.Position;
									int position5 = position4 + num13;
									dout.Position = position5;
									int position6 = dout.Position;
									obj10 = position3 - position6;
									flag17 = obj10 == null;
									if (position3 == position6)
									{
										flag4 = (byte)((flag4 ? 1u : 0u) + 1u) != 0;
										bool flag23 = flag4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
										obj10 = (nint)(flag23 ? 1 : 0) - (nint)0;
										flag17 = obj10 == null;
										bool flag24 = flag4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serObject @ X2 (System.Array)+18]");
										bool flag25 = (nint)(flag24 ? 1 : 0) < (nint)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ stack_-58_v5 (System.__Canon)+10]");
										b2 = 0;
										num = position3;
										num2 = num13;
										flag3 = (byte)(int)text9 != 0;
										if (!flag25)
										{
											return;
										}
										continue;
									}
									goto IL_08bd;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0807;
		IL_0807:
		throw new NullReferenceException();
		IL_0812:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X24_v3 (System.__Canon)+18]");
		string format = default;
		object arg = default;
		string text10 = string.Format(format, 0, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NullReferenceException ex2 = default;
		ex2._002Ector(text10);
		num10 = 0;
		text2 = null;
		array2 = null;
		text7 = text10;
		goto IL_09ed;
		IL_09ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		System.__Canon _Canon3 = default;
		_Canon = _Canon3;
		throw new ArgumentNullException();
		IL_08bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		string text11 = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		int position7 = dout.Position;
		string text12 = num10.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		string text13 = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		string[] array3 = default;
		string text14 = string.Concat(array3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex3 = default;
		ex3._002Ector(text14);
		text2 = text9;
		array2 = null;
		text7 = text14;
		goto IL_09ed;
	}

	private void SerializeByteArray(StreamBuffer dout, byte[] serObject, bool setType)
	{
		if (setType)
		{
			dout.WriteByte(120);
		}
		SerializeInteger(dout, serObject.Length, setType: false);
		dout.Write(serObject, 0, serObject.Length);
	}

	private void SerializeByteArraySegment(StreamBuffer dout, byte[] serObject, int offset, int count, bool setType)
	{
		if (setType)
		{
			dout.WriteByte(120);
			SerializeInteger(dout, count, setType: false);
		}
		else
		{
			SerializeInteger(dout, count, setType: false);
		}
		dout.Write(serObject, offset, count);
	}

	private void SerializeIntArrayOptimized(StreamBuffer inWriter, int[] serObject, bool setType)
	{
		//IL_0028: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I8
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_0387: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I4
		if (setType)
		{
			inWriter.WriteByte(121);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B10]");
		object type = 0;
		SerializeLengthAsShort(inWriter, serObject.Length, (string)type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		inWriter.WriteByte(105);
		object obj2 = serObject.Length << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		byte[] array = default;
		if (serObject.Length >= 1)
		{
			object obj3 = serObject.Length & 0xFFFFFFFFL;
			object obj4 = serObject + 32;
			object obj5 = 0;
			object obj6 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				object obj7 = !flag;
				if (obj7 == null)
				{
					bool flag2 = (nint)obj5 < array.Length;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						object obj9 = (object)array + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v4+v70 @ X10_v4]");
						object obj10 = (nint)0 >> 24;
						bool flag3 = (nint)obj6 < serObject.Length;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							object obj12 = obj5 + 1;
							bool flag4 = (nint)obj12 < array.Length;
							object obj13 = !flag4;
							if (obj13 == null)
							{
								object obj14 = obj5 + 1;
								object obj15 = obj4 + obj5;
								object obj16 = (object)array + obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X13_v5+2]");
								_ = 0;
								bool flag5 = (nint)obj6 < serObject.Length;
								object obj17 = !flag5;
								if (obj17 == null)
								{
									object obj18 = obj12 + 1;
									bool flag6 = (nint)obj18 < array.Length;
									object obj19 = !flag6;
									if (obj19 == null)
									{
										object obj20 = obj5 + 2;
										object obj21 = (object)array + obj20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v4+v70 @ X10_v4]");
										object obj22 = (nint)0 >> 8;
										bool flag7 = (nint)obj6 < serObject.Length;
										object obj23 = !flag7;
										if (obj23 == null)
										{
											object obj24 = obj18 + 1;
											bool flag8 = (nint)obj24 < array.Length;
											object obj25 = !flag8;
											if (obj25 == null)
											{
												object obj26 = obj5 + 3;
												obj6++;
												object obj27 = (object)array + obj26;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v4+v70 @ X10_v4]");
												_ = 0;
												obj5 = obj24 + 1;
												obj3 = serObject.Length;
												if ((nint)obj6 >= serObject.Length)
												{
													break;
												}
												continue;
											}
										}
									}
								}
							}
						}
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
		}
		inWriter.Write(array, 0, array.Length);
	}

	private void SerializeStringArray(StreamBuffer dout, string[] serObject, bool setType)
	{
		//IL_0028: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I8
		//IL_0079: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		if (setType)
		{
			dout.WriteByte(97);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B90]");
		object type = 0;
		SerializeLengthAsShort(dout, serObject.Length, (string)type);
		if (serObject.Length < 1)
		{
			return;
		}
		object obj = serObject.Length & 0xFFFFFFFFL;
		object obj2 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj3 = !flag;
			if (obj3 != null)
			{
				break;
			}
			double num = ((Enum)(object)this).System_002EIConvertible_002EToDouble((IFormatProvider)dout);
			obj = serObject.Length;
			obj2++;
			if ((nint)obj2 >= serObject.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void SerializeObjectArray(StreamBuffer dout, IList objects, bool setType)
	{
		//IL_0025: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_03f7: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_01dc: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_03bd: Expected I, but got Obj
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03e2: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		bool flag = !setType;
		IList list = objects;
		if (!flag)
		{
			dout.WriteByte(122);
			list = null;
		}
		nint num = (nint)objects;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3 (Il2CppClass<System.Collections.IList>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B08]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3 (Il2CppClass<System.Collections.IList>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3 (Il2CppClass<System.Collections.IList>)+98]");
		object obj4 = (nint)0 + (nint)8;
		object obj5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v18-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj2--;
			obj5 = obj4 + 16;
			bool flag2 = (nint)obj2 != 1;
			obj4 = obj5;
			if (flag2)
			{
				continue;
			}
			goto IL_00d9;
		}
		object obj6 = obj4 + 1;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		obj5 = obj4;
		goto IL_02f2;
		IL_02f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A98]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ X0_v5] (should have been resolved before IL gen)");
		string text = (string)obj3;
		int num2 = default;
		SerializeLengthAsShort(dout, num2, (string)obj3);
		int num3 = num2;
		object obj10 = 0;
		object obj16 = default;
		int num8 = default;
		while (true)
		{
			nint num4 = (nint)objects;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v7 (Il2CppClass<System.Collections.IList>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v7 (Il2CppClass<System.Collections.IList>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0186;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v7 (Il2CppClass<System.Collections.IList>)+98]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X10_v13-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11--;
				obj5 = obj12 + 16;
				bool flag3 = (nint)obj11 != 1;
				obj12 = obj5;
				if (flag3)
				{
					continue;
				}
				goto IL_0186;
			}
			object obj13 = obj12 + 1;
			object obj14 = num4 + obj13;
			object obj15 = obj14 + 312;
			obj5 = obj12;
			goto IL_0361;
			IL_0361:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X0_v10] (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
			{
				break;
			}
			nint num5 = (nint)objects;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v10 (Il2CppClass<System.Collections.IList>)+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v10 (Il2CppClass<System.Collections.IList>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v10 (Il2CppClass<System.Collections.IList>)+98]");
				object obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X10_v8-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj17--;
					obj5 = obj18 + 16;
					bool flag4 = (nint)obj17 != 1;
					obj18 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_0270;
				}
				object obj19 = num5 + obj18;
				object obj20 = obj19 + 312;
				obj5 = obj18;
				goto IL_03ae;
			}
			goto IL_0270;
			IL_0270:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_03ae;
			IL_03ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v388 @ X0_v13] (should have been resolved before IL gen)");
			nint num6 = (nint)this;
			ulong num7 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)dout);
			obj10++;
			text = (string)1;
			num3 = num8;
			continue;
			IL_0186:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num3 = 1;
			goto IL_0361;
		}
		return;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		list = (IList)1;
		goto IL_02f2;
	}

	private unsafe void SerializeHashTable(StreamBuffer dout, PhotonHashtable serObject, bool setType)
	{
		//IL_0335: Expected I4, but got Obj
		//IL_008b: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected I4, but got Obj
		//IL_0208: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I4
		//IL_0398: Expected Obj, but got I4
		//IL_01b4: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I4
		//IL_01d4: Expected I4, but got Obj
		//IL_0230: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68D55BA]");
		nint num = 0;
		bool flag2 = default;
		bool flag = !flag2;
		PhotonHashtable photonHashtable = serObject;
		byte b = (byte)(int)dout;
		object obj;
		bool flag4;
		StreamBuffer streamBuffer;
		if (!flag)
		{
			bool flag3 = dout == null;
			photonHashtable = serObject;
			streamBuffer = dout;
			flag4 = flag2;
			obj = 109924352;
			if (flag3)
			{
				goto IL_0247;
			}
			dout.WriteByte(104);
			photonHashtable = null;
			b = 104;
		}
		bool flag5 = serObject == null;
		streamBuffer = (StreamBuffer)b;
		flag4 = flag2;
		obj = 109924352;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6514E90]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B00]");
			flag4 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515818]");
			obj = 0;
			int count = ((Dictionary<System.__Canon, System.__Canon>)(object)serObject).Count;
			string text = (string)((bool*)(flag4 ? 1 : 0))->m_value;
			SerializeLengthAsShort(dout, count, (string)((bool*)(flag4 ? 1 : 0))->m_value);
			streamBuffer = (StreamBuffer)obj;
			Dictionary<System.__Canon, System.__Canon>.KeyCollection keys = ((Dictionary<System.__Canon, System.__Canon>)(object)serObject).Keys;
			bool flag6 = keys == null;
			flag2 = ((bool*)(flag4 ? 1 : 0))->m_value;
			photonHashtable = (PhotonHashtable)count;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6515820]");
				obj = 0;
				Enumerator<> enumerator = keys.GetEnumerator();
				int num2 = count;
				Enumerator<> val = default;
				num = (nint)(&val);
				flag4 = (byte)(&val) != 0;
				while (val.MoveNext())
				{
					ulong num3 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)dout);
					object obj2 = serObject.get_Item((object)null);
					num = (nint)this;
					ulong num4 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)dout);
					text = (string)1;
					num2 = (int)obj2;
					flag4 = false;
				}
				nint num5 = unchecked((nint)null);
				object obj3 = 0;
				Enumerator<> val2 = (Enumerator<>)(ref val);
				flag2 = (byte)(int)text != 0;
				photonHashtable = (PhotonHashtable)num2;
				object obj4 = 0;
				object obj7 = default;
				while (true)
				{
					streamBuffer = (StreamBuffer)obj;
					val.Dispose();
					bool flag7 = obj4 == null;
					object obj5 = !flag7;
					if (obj5 == null)
					{
						bool flag8 = num5 == 0;
						object obj6 = !flag8;
						OutOfMemoryException ex = (OutOfMemoryException)(&val);
						if (obj6 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)streamBuffer == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						num5 = 1;
						num = 1;
						obj4 = obj3;
						continue;
					}
					if ((nint)streamBuffer != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj4 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj3 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BEAE10");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
		goto IL_0247;
		IL_0247:
		throw new NullReferenceException();
	}

	private void SerializeDictionary(StreamBuffer dout, IDictionary serObject, bool setType)
	{
		if (setType)
		{
			dout.WriteByte(68);
		}
		SerializeDictionaryHeader(dout, serObject, out var setKeyType, out var setValueType);
		SerializeDictionaryElements(dout, serObject, setKeyType, setValueType);
	}

	private void SerializeDictionaryHeader(StreamBuffer writer, Type dictType)
	{
		SerializeDictionaryHeader(writer, dictType, out var _, out var _);
	}

	private unsafe void SerializeDictionaryHeader(StreamBuffer writer, object dict, out bool setKeyType, out bool setValueType)
	{
		//IL_0552: Expected Obj, but got I
		//IL_0562: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_0693: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0145: Expected VT, but got I
		//IL_0167: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I8
		//IL_01da: Expected VT, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_03d6: Expected Obj, but got I8
		//IL_03fa: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I4
		//IL_0418: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_043f: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I8
		//IL_059b: Expected Obj, but got I4
		//IL_05c5: Expected Obj, but got I
		//IL_0606: Expected Obj, but got I
		//IL_0616: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I4
		//IL_04b1: Expected Obj, but got I8
		//IL_04d5: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I
		object obj = default;
		bool flag = obj == null;
		StreamBuffer streamBuffer = writer;
		object obj4 = default;
		object obj5 = default;
		Type type;
		byte b;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			object obj2 = default;
			bool flag2 = obj2 == null;
			streamBuffer = writer;
			if (!flag2)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+460]");
				streamBuffer = (StreamBuffer)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ X8_v9+458] (should have been resolved before IL gen)");
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+18]");
					bool flag3 = (nint)0 == 0;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+460]");
					type = (Type)0;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+E8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v30+E4]");
						bool flag4 = (nint)0 == 0;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+10]");
						RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
						Type typeFromHandle = Type.GetTypeFromHandle(handle);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+20]");
						bool flag5 = (Type)0 == typeFromHandle;
						ref bool reference = ref *(flag5 ? ((bool*)1) : ((bool*)null));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+18]");
						object obj9 = 0 & 0xFFFFFFFEL;
						bool flag6 = obj9 == null;
						obj = null;
						obj5 = obj4;
						type = typeFromHandle;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X25_v7+10]");
							RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
							Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+28]");
							bool flag7 = (Type)0 == typeFromHandle2;
							ref bool reference2 = ref *(flag7 ? ((bool*)1) : ((bool*)null));
							if (setKeyType)
							{
								bool flag8 = writer == null;
								obj = null;
								obj5 = obj4;
								streamBuffer = (StreamBuffer)(object)typeFromHandle2;
								if (!flag8)
								{
									b = 0;
									goto IL_037e;
								}
								goto IL_0507;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+18]");
							bool flag9 = (nint)0 == 0;
							obj = null;
							obj5 = obj4;
							type = typeFromHandle2;
							if (!flag9)
							{
								bool flag10 = flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+20]");
								Protocol18.GpType codeOfType = ((Protocol16)flag10).GetCodeOfType((Type)0);
								object obj10 = codeOfType & (Protocol18.GpType)0xFF;
								bool flag11 = (nint)obj10 == 68;
								obj = null;
								obj5 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+20]");
								streamBuffer = (StreamBuffer)0;
								if (!flag11)
								{
									bool flag12 = obj10 == null;
									obj = null;
									obj5 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+20]");
									streamBuffer = (StreamBuffer)0;
									if (!flag12)
									{
										bool flag13 = writer == null;
										b = (byte)codeOfType;
										obj = null;
										obj5 = obj4;
										streamBuffer = (StreamBuffer)codeOfType;
										if (!flag13)
										{
											goto IL_037e;
										}
										goto IL_0507;
									}
								}
								goto IL_0515;
							}
						}
					}
					goto IL_05d3;
				}
			}
		}
		goto IL_0507;
		IL_037e:
		writer.WriteByte(b);
		if (setValueType)
		{
			writer.WriteByte(0);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+18]");
		object obj11 = 0 & 0xFFFFFFFEL;
		bool flag14 = obj11 == null;
		obj = null;
		obj5 = obj4;
		type = (Type)b;
		object obj19;
		object obj20;
		object obj17;
		object obj18;
		if (!flag14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+28]");
			type = (Type)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+28]");
			Protocol18.GpType codeOfType2 = ((Protocol16)(object)writer).GetCodeOfType((Type)0);
			object obj12 = codeOfType2 & (Protocol18.GpType)0xFF;
			if (obj12 != null)
			{
				writer.WriteByte((byte)codeOfType2);
				object obj13 = codeOfType2 & (Protocol18.GpType)0xFF;
				if ((nint)obj13 != 68)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+18]");
				object obj14 = 0 & 0xFFFFFFFEL;
				bool flag15 = obj14 == null;
				obj = null;
				obj5 = obj4;
				type = (Type)codeOfType2;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+28]");
					SerializeDictionaryHeader(writer, 0, out var _, out var _);
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+18]");
				object obj15 = 0 & 0xFFFFFFFEL;
				bool flag16 = obj15 == null;
				object obj16 = !flag16;
				obj = null;
				obj5 = obj4;
				obj17 = null;
				obj18 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v29+28]");
				streamBuffer = (StreamBuffer)0;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X21_v2+28]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B60]");
					obj20 = 0;
					obj = obj17;
					goto IL_066f;
				}
			}
		}
		goto IL_05d3;
		IL_0507:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0515;
		IL_0515:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X21_v3+18]");
		bool flag17 = (nint)0 == 0;
		type = (Type)(object)streamBuffer;
		if (flag17)
		{
			goto IL_05d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X21_v3+20]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B58]");
		obj20 = 0;
		goto IL_066f;
		IL_05d3:
		obj17 = obj;
		obj18 = obj5;
		streamBuffer = (StreamBuffer)(object)type;
		throw new IndexOutOfRangeException();
		IL_066f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		bool flag18 = obj19 == null;
		object obj21 = !flag18;
		string text;
		if (obj21 == null)
		{
			text = null;
		}
		else
		{
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X8_v3+168] (should have been resolved before IL gen)");
			string text2 = default;
			text = text2;
		}
		string text3 = default;
		string message = text3 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex2 = default;
		ex2._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	private unsafe void SerializeDictionaryElements(StreamBuffer writer, object dict, bool setKeyType, bool setValueType)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_0689: Expected Obj, but got I4
		//IL_0707: Expected I, but got Obj
		//IL_0952: Expected Obj, but got I
		//IL_0962: Expected Obj, but got I
		//IL_0972: Expected Obj, but got I
		//IL_0984: Expected I4, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0a91: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_074e: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0818: Expected Obj, but got I4
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected Obj, but got Unknown
		//IL_09e5: Expected Obj, but got Ref
		//IL_09ed: Expected Obj, but got Ref
		//IL_09fb: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0789: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02de: Expected Obj, but got I4
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got Ref
		//IL_060b: Expected Obj, but got Ref
		//IL_0619: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I4
		//IL_04e6: Expected I, but got Obj
		object obj = default;
		bool flag = obj == null;
		object obj2 = obj;
		if (flag)
		{
			goto IL_062e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
		object obj3 = 0;
		nint num = (nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj4 = default;
		bool flag2 = obj4 == null;
		obj2 = obj;
		object obj8;
		object obj6;
		if (!flag2)
		{
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F5A90]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v18+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516B70]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0108;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v18+98]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v42-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj7--;
				obj6 = obj9 + 16;
				bool flag3 = (nint)obj7 != 1;
				obj9 = obj6;
				if (flag3)
				{
					continue;
				}
				goto IL_0108;
			}
			object obj10 = obj9 + 1;
			object obj11 = obj5 + obj10;
			object obj12 = obj11 + 312;
			obj6 = obj9;
			goto IL_08b4;
		}
		InvalidCastException ex = new InvalidCastException();
		bool flag4;
		bool flag6;
		OutOfMemoryException ex3 = default;
		object obj13 = default;
		bool flag5 = default;
		bool flag7 = default;
		InvalidCastException ex2;
		nint num2;
		if (num == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj13 = 1;
			flag4 = flag5;
			flag6 = flag7;
		}
		else
		{
			bool flag8 = num != 1;
			num2 = num;
			ex2 = ex;
			if (flag8)
			{
				goto IL_0a54;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj14 = default;
			ex3 = (OutOfMemoryException)obj14;
			flag4 = flag5;
			flag6 = flag7;
		}
		goto IL_06ff;
		IL_0108:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj = 1;
		goto IL_08b4;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		int num3 = 9;
		goto IL_0932;
		IL_0ac3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v16+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v717 @ X0_v16] (should have been resolved before IL gen)");
		goto IL_0a77;
		IL_0a54:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_062e:
		throw new NullReferenceException();
		IL_08b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ X0_v35] (should have been resolved before IL gen)");
		int num4 = default;
		SerializeLengthAsShort(writer, num4, (string)obj8);
		object obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v21+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v21+98]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X10_v37-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj16--;
			obj6 = obj17 + 16;
			bool flag9 = (nint)obj16 != 1;
			obj17 = obj6;
			if (flag9)
			{
				continue;
			}
			goto IL_01b5;
		}
		object obj18 = obj17 + 9;
		object obj19 = obj15 + obj18;
		object obj20 = obj19 + 312;
		num3 = num4;
		obj6 = obj17;
		goto IL_0932;
		IL_0932:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FABF0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v39+8]");
		StreamBuffer streamBuffer = (StreamBuffer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v477 @ X0_v39] (should have been resolved before IL gen)");
		flag4 = (byte)(int)obj8 != 0;
		flag6 = flag7;
		object obj23 = default;
		object obj29 = default;
		object obj31 = default;
		object obj33 = default;
		object obj40 = default;
		Exception ex7 = default;
		string message = default;
		Exception ex9 = default;
		string message2 = default;
		StreamBuffer streamBuffer3 = default;
		object obj28;
		while (true)
		{
			object obj22 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v31+12E]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v31+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v31+98]");
			object obj25 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X10_v32-8]");
				if (0 == num)
				{
					break;
				}
				obj24--;
				obj6 = obj25 + 16;
				bool flag10 = (nint)obj24 != 1;
				obj25 = obj6;
				if (flag10)
				{
					continue;
				}
				goto IL_02a7;
			}
			object obj26 = obj22 + obj25;
			object obj27 = obj26 + 312;
			obj = num3;
			obj6 = obj25;
			goto IL_09b6;
			IL_05d6:
			InvalidCastException ex4 = new InvalidCastException();
			goto IL_05e4;
			IL_05e4:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_05f2;
			IL_05f2:
			NullReferenceException ex6 = new NullReferenceException();
			obj28 = (object)(&obj29);
			object obj30 = (object)(&obj31);
			ex3 = null;
			obj13 = 0;
			flag5 = flag4;
			flag7 = flag6;
			goto IL_062e;
			IL_02a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj = null;
			goto IL_09b6;
			IL_09b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v746 @ X0_v78] (should have been resolved before IL gen)");
			object obj32 = obj33 & 1;
			bool flag11 = obj32 == null;
			obj28 = (object)(&obj29);
			obj30 = (object)(&obj31);
			ex3 = null;
			obj13 = 0;
			if (flag11)
			{
				break;
			}
			if (obj23 == null)
			{
				goto IL_05e4;
			}
			object obj34 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v34+12E]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v34+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03a4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v34+98]");
			object obj36 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X10_v27-8]");
				if (0 == num)
				{
					break;
				}
				obj35--;
				obj6 = obj36 + 16;
				bool flag12 = (nint)obj35 != 1;
				obj36 = obj6;
				if (flag12)
				{
					continue;
				}
				goto IL_03a4;
			}
			object obj37 = obj36 + 1;
			object obj38 = obj34 + obj37;
			object obj39 = obj38 + 312;
			obj6 = obj36;
			goto IL_0a2d;
			IL_03a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			obj = 1;
			goto IL_0a2d;
			IL_0a2d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v901 @ X0_v81] (should have been resolved before IL gen)");
			if (obj40 != null)
			{
				StreamBuffer streamBuffer2 = (StreamBuffer)obj21;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v37+40]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X1_v20 (Photon.Client.StreamBuffer)+40]");
				if (num5 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v83+10]");
					int num6 = 0;
					bool flag13 = !flag7;
					object obj42 = !flag13;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v83+18]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ex7._002Ector(message);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							ArgumentNullException ex8 = new ArgumentNullException();
							obj = null;
							goto IL_05d6;
						}
					}
					bool flag14 = !flag5;
					object obj43 = !flag14;
					if (obj43 != null || num6 != 0)
					{
						ulong num7 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)writer);
						nint num8 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v40 (Il2CppClass<Photon.Client.Protocol16>)+1A0]");
						flag6 = false;
						ulong num9 = ((Enum)(object)this).System_002EIConvertible_002EToUInt64((IFormatProvider)writer);
						flag4 = flag7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v83+18]");
						num3 = 0;
						streamBuffer = writer;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ex9._002Ector(message2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					num6 = 0;
					streamBuffer2 = streamBuffer3;
					throw new ArgumentNullException();
				}
				goto IL_05d6;
			}
			goto IL_05f2;
		}
		goto IL_06ff;
		IL_0a77:
		bool flag15 = ex3 == null;
		object obj44 = !flag15;
		if (obj44 == null)
		{
			bool flag16 = obj13 == null;
			object obj45 = !flag16;
			OutOfMemoryException ex10 = ex3;
			if (obj45 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex10 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		flag5 = flag4;
		flag7 = flag6;
		InvalidCastException ex11 = default;
		ex2 = ex11;
		goto IL_0a54;
		IL_07ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		obj = null;
		goto IL_0ac3;
		IL_06ff:
		num2 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj46 = default;
		obj28 = obj46;
		if (obj46 == null)
		{
			goto IL_0a77;
		}
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v10+12E]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07ca;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v10+98]");
		object obj49 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X10_v8-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj48--;
			obj49 += 16;
			if ((nint)obj48 != 1)
			{
				continue;
			}
			goto IL_07ca;
		}
		object obj50 = obj47 + obj49;
		object obj51 = obj50 + 312;
		goto IL_0ac3;
	}

	public override object Deserialize(StreamBuffer din, byte type, DeserializationFlags flags = default(DeserializationFlags))
	{
		//IL_0028: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_0209: Expected I4, but got I8
		byte b = default;
		int num = b & 0xFF;
		bool flag = num < 42;
		object obj = !flag;
		object obj2 = num - 42;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		ArgumentNullException ex = (ArgumentNullException)(object)this;
		StreamBuffer streamBuffer2 = default;
		StreamBuffer streamBuffer = streamBuffer2;
		if (obj4 == null)
		{
			num = b & 0xFF;
			if (num != 0)
			{
				bool flag3 = num == 42;
				streamBuffer = streamBuffer2;
				if (!flag3)
				{
					goto IL_00c8;
				}
			}
			return null;
		}
		goto IL_0279;
		IL_00c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		byte b2 = default;
		string text = b2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		int position = streamBuffer.Position;
		int num2 = default;
		string text2 = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		int length = streamBuffer.Length;
		string text3 = num2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		byte[] buffer = streamBuffer.GetBuffer();
		string text4 = SupportClass.ByteArrayToString(buffer, -1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
		string[] array = default;
		string text5 = string.Concat(array);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex2 = default;
		ex2._002Ector(text5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ex = new ArgumentNullException();
		streamBuffer = (StreamBuffer)(object)text5;
		goto IL_0279;
		IL_0279:
		object obj5 = num - 97;
		bool flag4 = (nint)obj5 < 25;
		object obj6 = !flag4;
		object obj7 = obj5 - 25;
		bool flag5 = obj7 == null;
		object obj8 = !flag5;
		object obj9 = obj6 & obj8;
		if (obj9 == null)
		{
			object obj10 = 18214912 + 3026;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+v65 @ X9_v2*2]");
			object obj11 = (nint)86058688 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v102 @ X10_v2 (should have been resolved before IL gen)");
		}
		if (num == 68)
		{
			return ((Protocol16)(object)ex).DeserializeDictionary(streamBuffer);
		}
		goto IL_00c8;
	}

	public override byte DeserializeByte(StreamBuffer din)
	{
		//IL_003d: Expected I4, but got Obj
		if (din != null)
		{
			return din.ReadByte();
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex;
	}

	private bool DeserializeBoolean(StreamBuffer din)
	{
		//IL_0065: Expected I4, but got Obj
		if (din != null)
		{
			byte b = din.ReadByte();
			int num = b & 0xFF;
			bool flag = num == 0;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe override short DeserializeShort(StreamBuffer din)
	{
		//IL_002f: Expected Obj, but got Ref
		//IL_0038: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got Ref
		//IL_0206: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got Ref
		//IL_022e: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(memShort, ref lockTaken);
		bool flag = din == null;
		int num = 0;
		byte[] array = (byte[])(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		Protocol16 protocol = this;
		if (flag)
		{
			goto IL_025f;
		}
		byte[] array2 = memShort;
		int num2 = din.Read(memShort, 0, 2);
		bool flag2 = memShort == null;
		object obj2 = 0;
		int num3 = 2;
		num = 0;
		array = memShort;
		obj = 0;
		ex = null;
		if (flag2)
		{
			goto IL_0284;
		}
		bool flag3 = array2.Length == 1;
		obj2 = 0;
		num3 = 2;
		num = 0;
		array = memShort;
		obj = 0;
		ex = null;
		if (flag3)
		{
			goto IL_0292;
		}
		bool flag4 = array2.Length == 0;
		obj2 = 0;
		num3 = 2;
		num = 0;
		array = memShort;
		obj = 0;
		ex = null;
		if (flag4)
		{
			goto IL_02a0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction REV not yet implemented.\"");
		int result = array2[0] >> 16;
		obj2 = 0;
		num3 = 2;
		num = 0;
		array = memShort;
		obj = 0;
		ex = null;
		protocol = (Protocol16)(object)memShort;
		goto IL_0374;
		IL_0292:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_02a0;
		IL_0275:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0284;
		IL_025f:
		NullReferenceException ex3 = new NullReferenceException();
		array2 = (byte[])(object)protocol;
		goto IL_0275;
		IL_0284:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0292;
		IL_0374:
		object obj3 = (object)(&lockTaken);
		if (obj3 != null)
		{
			object obj5 = default;
			object obj4 = (object)(&obj5);
			Monitor.Exit(obj4);
			array = null;
		}
		bool flag5 = ex == null;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			bool flag6 = obj == null;
			object obj7 = !flag6;
			ex3 = ex;
			array2 = (byte[])(object)protocol;
			if (obj7 == null)
			{
				return (short)result;
			}
			goto IL_0275;
		}
		OutOfMemoryException ex5 = new OutOfMemoryException();
		goto IL_025f;
		IL_02a0:
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				short result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj8 = default;
			ex = (NullReferenceException)obj8;
		}
		result = 0;
		protocol = (Protocol16)(object)array2;
		goto IL_0374;
	}

	private unsafe int DeserializeInteger(StreamBuffer din)
	{
		//IL_002f: Expected Obj, but got Ref
		//IL_0038: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I4
		//IL_049b: Expected Obj, but got Ref
		//IL_0321: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I4
		//IL_0349: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(memInteger, ref lockTaken);
		bool flag = din == null;
		int num = 0;
		byte[] array = (byte[])(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_0372;
		}
		byte[] array2 = memInteger;
		int num2 = din.Read(memInteger, 0, 4);
		bool flag2 = memInteger == null;
		object obj2 = 0;
		int num3 = 4;
		num = 0;
		array = memInteger;
		obj = 0;
		ex = null;
		if (flag2)
		{
			goto IL_038f;
		}
		bool flag3 = array2.Length == 0;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memInteger;
		obj = 0;
		ex = null;
		if (flag3)
		{
			goto IL_039d;
		}
		bool flag4 = array2.Length == 1;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memInteger;
		obj = 0;
		ex = null;
		if (flag4)
		{
			goto IL_03ab;
		}
		bool flag5 = array2.Length < 2;
		object obj3 = !flag5;
		object obj4 = array2.Length - 2;
		bool flag6 = obj4 == null;
		object obj5 = ~obj3;
		object obj6 = obj5 | flag6;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memInteger;
		obj = 0;
		ex = null;
		if (obj6 != null)
		{
			goto IL_03b9;
		}
		bool flag7 = array2.Length == 3;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memInteger;
		obj = 0;
		ex = null;
		if (flag7)
		{
			goto IL_03c7;
		}
		int num4 = array2[0] << 24;
		int num5 = num4 | array2[1];
		int num6 = num5 | array2[2];
		int result = num6 | array2[3];
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memInteger;
		obj = 0;
		ex = null;
		goto IL_0493;
		IL_03b9:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_03c7;
		IL_039d:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_03ab;
		IL_0372:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0380;
		IL_03ab:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_03b9;
		IL_0380:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_038f;
		IL_038f:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_039d;
		IL_0493:
		object obj7 = (object)(&lockTaken);
		if (obj7 != null)
		{
			object obj8 = default;
			byte b = (byte)(&obj8);
			Monitor.Exit(((byte*)(int)b)->m_value);
			array = null;
		}
		bool flag8 = ex == null;
		object obj9 = !flag8;
		if (obj9 == null)
		{
			bool flag9 = obj == null;
			object obj10 = !flag9;
			ex4 = ex;
			if (obj10 == null)
			{
				return result;
			}
			goto IL_0380;
		}
		OutOfMemoryException ex7 = new OutOfMemoryException();
		goto IL_0372;
		IL_03c7:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				int result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj11 = default;
			ex = (NullReferenceException)obj11;
		}
		result = 0;
		goto IL_0493;
	}

	private unsafe long DeserializeLong(StreamBuffer din)
	{
		//IL_002f: Expected Obj, but got Ref
		//IL_0038: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0364: Expected Obj, but got I4
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0392: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_06fb: Expected Obj, but got Ref
		//IL_0549: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		//IL_0525: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I4
		//IL_058c: Expected I8, but got I4
		bool lockTaken = default;
		Monitor.Enter(memLong, ref lockTaken);
		bool flag = din == null;
		int num = 0;
		byte[] array = (byte[])(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_059a;
		}
		byte[] array2 = memLong;
		int num2 = din.Read(memLong, 0, 8);
		bool flag2 = memLong == null;
		object obj2 = 0;
		int num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (flag2)
		{
			goto IL_05b7;
		}
		bool flag3 = array2.Length == 0;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (flag3)
		{
			goto IL_05c5;
		}
		bool flag4 = array2.Length == 1;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (flag4)
		{
			goto IL_05d3;
		}
		bool flag5 = array2.Length < 2;
		object obj3 = !flag5;
		object obj4 = array2.Length - 2;
		bool flag6 = obj4 == null;
		object obj5 = ~obj3;
		object obj6 = obj5 | flag6;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (obj6 != null)
		{
			goto IL_05e1;
		}
		bool flag7 = array2.Length == 3;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (flag7)
		{
			goto IL_05ef;
		}
		bool flag8 = array2.Length < 4;
		object obj7 = !flag8;
		object obj8 = array2.Length - 4;
		bool flag9 = obj8 == null;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag9;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (obj10 != null)
		{
			goto IL_05fd;
		}
		bool flag10 = array2.Length == 5;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (flag10)
		{
			goto IL_060b;
		}
		bool flag11 = array2.Length < 6;
		object obj11 = !flag11;
		object obj12 = array2.Length - 6;
		bool flag12 = obj12 == null;
		object obj13 = ~obj11;
		object obj14 = obj13 | flag12;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (obj14 != null)
		{
			goto IL_0619;
		}
		bool flag13 = array2.Length == 7;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		if (flag13)
		{
			goto IL_0627;
		}
		int num4 = array2[0] << 56;
		int num5 = num4 | array2[1];
		int num6 = num5 | array2[2];
		int num7 = num6 | array2[3];
		int num8 = num7 | array2[4];
		int num9 = num8 | array2[5];
		int num10 = num9 | array2[6];
		int num11 = num10 | array2[7];
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memLong;
		obj = 0;
		ex = null;
		goto IL_06f3;
		IL_0619:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0627;
		IL_05fd:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_060b;
		IL_059a:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_05a8;
		IL_060b:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0619;
		IL_05a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_05b7;
		IL_05b7:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_05c5;
		IL_05c5:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_05d3;
		IL_05d3:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_05e1;
		IL_05e1:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		goto IL_05ef;
		IL_05ef:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_05fd;
		IL_06f3:
		object obj15 = (object)(&lockTaken);
		if (obj15 != null)
		{
			object obj16 = default;
			byte b = (byte)(&obj16);
			Monitor.Exit(((byte*)(int)b)->m_value);
			array = null;
		}
		bool flag14 = ex == null;
		object obj17 = !flag14;
		if (obj17 == null)
		{
			bool flag15 = obj == null;
			object obj18 = !flag15;
			ex4 = ex;
			if (obj18 == null)
			{
				return num11;
			}
			goto IL_05a8;
		}
		OutOfMemoryException ex11 = new OutOfMemoryException();
		goto IL_059a;
		IL_0627:
		IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				long result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj19 = default;
			ex = (NullReferenceException)obj19;
		}
		num11 = 0;
		goto IL_06f3;
	}

	private unsafe float DeserializeFloat(StreamBuffer din)
	{
		//IL_002f: Expected Obj, but got Ref
		//IL_0038: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_03e4: Expected F4, but got I4
		//IL_03ec: Expected I4, but got Obj
		//IL_03f5: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_043c: Expected F4, but got I4
		//IL_0444: Expected I4, but got Obj
		//IL_045e: Expected Obj, but got Ref
		//IL_0475: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(memFloat, ref lockTaken);
		bool flag = din == null;
		int num = 0;
		byte[] array = (byte[])(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_034d;
		}
		byte[] array2 = memFloat;
		int num2 = din.Read(memFloat, 0, 4);
		bool flag2 = memFloat == null;
		object obj2 = 0;
		int num3 = 4;
		num = 0;
		array = memFloat;
		obj = 0;
		ex = null;
		if (flag2)
		{
			goto IL_036a;
		}
		bool flag3 = array2.Length == 0;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memFloat;
		obj = 0;
		ex = null;
		if (flag3)
		{
			goto IL_0378;
		}
		bool flag4 = array2.Length == 1;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memFloat;
		obj = 0;
		ex = null;
		if (flag4)
		{
			goto IL_0386;
		}
		bool flag5 = array2.Length < 3;
		object obj3 = !flag5;
		object obj4 = array2.Length - 3;
		bool flag6 = obj4 == null;
		object obj5 = ~obj3;
		object obj6 = obj5 | flag6;
		obj2 = 0;
		num3 = 4;
		num = 0;
		array = memFloat;
		obj = 0;
		ex = null;
		if (obj6 != null)
		{
			goto IL_0394;
		}
		array2[0] = array2[3];
		array2[1] = array2[2];
		array2[2] = array2[1];
		array2[3] = array2[0];
		float num4 = BitConverter.ToSingle(memFloat, 0);
		float result = num4;
		obj2 = 0;
		num3 = 4;
		num = 0;
		int num5 = 0;
		obj = 0;
		ex = null;
		goto IL_0456;
		IL_0378:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0386;
		IL_036a:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0378;
		IL_034d:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_035b;
		IL_0386:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_0394;
		IL_035b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_036a;
		IL_0456:
		object obj7 = (object)(&lockTaken);
		bool flag7 = obj7 == null;
		array = (byte[])num5;
		if (!flag7)
		{
			object obj8 = default;
			byte b = (byte)(&obj8);
			Monitor.Exit(((byte*)(int)b)->m_value);
			array = null;
		}
		bool flag8 = ex == null;
		object obj9 = !flag8;
		if (obj9 == null)
		{
			bool flag9 = obj == null;
			object obj10 = !flag9;
			ex4 = ex;
			if (obj10 == null)
			{
				return result;
			}
			goto IL_035b;
		}
		OutOfMemoryException ex6 = new OutOfMemoryException();
		goto IL_034d;
		IL_0394:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			result = 0f;
			num5 = (int)array;
			obj = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			result = 0f;
			num5 = (int)array;
			object obj11 = default;
			ex = (NullReferenceException)obj11;
		}
		goto IL_0456;
	}

	private unsafe double DeserializeDouble(StreamBuffer din)
	{
		//IL_002f: Expected Obj, but got Ref
		//IL_0038: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0158: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_0520: Expected F8, but got I4
		//IL_0528: Expected I4, but got Obj
		//IL_0531: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_0578: Expected F8, but got I4
		//IL_0580: Expected I4, but got Obj
		//IL_059a: Expected Obj, but got Ref
		//IL_05b1: Expected Obj, but got I4
		//IL_041c: Expected Obj, but got I4
		//IL_03b4: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(memDouble, ref lockTaken);
		bool flag = din == null;
		int num = 0;
		byte[] array = (byte[])(&lockTaken);
		object obj = 0;
		NullReferenceException ex = null;
		if (flag)
		{
			goto IL_046d;
		}
		byte[] array2 = memDouble;
		int num2 = din.Read(memDouble, 0, 8);
		bool flag2 = memDouble == null;
		object obj2 = 0;
		int num3 = 8;
		num = 0;
		array = memDouble;
		obj = 0;
		ex = null;
		if (flag2)
		{
			goto IL_048a;
		}
		bool flag3 = array2.Length == 0;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memDouble;
		obj = 0;
		ex = null;
		if (flag3)
		{
			goto IL_0498;
		}
		bool flag4 = array2.Length == 1;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memDouble;
		obj = 0;
		ex = null;
		if (flag4)
		{
			goto IL_04a6;
		}
		bool flag5 = array2.Length < 2;
		object obj3 = !flag5;
		object obj4 = array2.Length - 2;
		bool flag6 = obj4 == null;
		object obj5 = ~obj3;
		object obj6 = obj5 | flag6;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memDouble;
		obj = 0;
		ex = null;
		if (obj6 != null)
		{
			goto IL_04b4;
		}
		bool flag7 = array2.Length == 3;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memDouble;
		obj = 0;
		ex = null;
		if (flag7)
		{
			goto IL_04c2;
		}
		bool flag8 = array2.Length < 7;
		object obj7 = !flag8;
		object obj8 = array2.Length - 7;
		bool flag9 = obj8 == null;
		object obj9 = ~obj7;
		object obj10 = obj9 | flag9;
		obj2 = 0;
		num3 = 8;
		num = 0;
		array = memDouble;
		obj = 0;
		ex = null;
		if (obj10 != null)
		{
			goto IL_04d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[4] = array2[3];
		array2[5] = array2[2];
		array2[6] = array2[1];
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[7] = array2[0];
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		array2[0] = array2[4];
		double num4 = BitConverter.ToDouble(memDouble, 0);
		double result = num4;
		obj2 = 0;
		num3 = 8;
		num = 0;
		int num5 = 0;
		obj = 0;
		ex = null;
		goto IL_0592;
		IL_04b4:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_04c2;
		IL_04a6:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_04b4;
		IL_046d:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_047b;
		IL_04c2:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_04d0;
		IL_047b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_048a;
		IL_048a:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_0498;
		IL_0498:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_04a6;
		IL_0592:
		object obj11 = (object)(&lockTaken);
		bool flag10 = obj11 == null;
		array = (byte[])num5;
		if (!flag10)
		{
			object obj12 = default;
			byte b = (byte)(&obj12);
			Monitor.Exit(((byte*)(int)b)->m_value);
			array = null;
		}
		bool flag11 = ex == null;
		object obj13 = !flag11;
		if (obj13 == null)
		{
			bool flag12 = obj == null;
			object obj14 = !flag12;
			ex4 = ex;
			if (obj14 == null)
			{
				return result;
			}
			goto IL_047b;
		}
		OutOfMemoryException ex8 = new OutOfMemoryException();
		goto IL_046d;
		IL_04d0:
		IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
		if ((nint)array == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			result = 0.0;
			num5 = (int)array;
			obj = 1;
		}
		else
		{
			if ((nint)array != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			result = 0.0;
			num5 = (int)array;
			object obj15 = default;
			ex = (NullReferenceException)obj15;
		}
		goto IL_0592;
	}

	private unsafe string DeserializeString(StreamBuffer din)
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_0060: Expected I4, but got I8
		//IL_007a: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got Ref
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Il2CppClass<Photon.Client.Protocol16>)+210]");
		object obj = 0;
		short num2 = (((ValueType)(object)this).Equals((object)din) ? ((short)1) : ((short)0));
		if ((num2 & 0xFFFF) != 0)
		{
			int num3 = (int)(num2 & 0x80000000L);
			bool flag = num3 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				if (din != null)
				{
					int length = num2 & 0xFFFF;
					byte[] bufferAndAdvance = din.GetBufferAndAdvance(length, out var offset);
					Encoding uTF = Encoding.UTF8;
					bool flag2 = uTF == null;
					obj = (object)(&offset);
					if (!flag2)
					{
						int inputCount = num2 & 0xFFFF;
						return (string)(object)((HashAlgorithm)(object)uTF).TransformFinalBlock(bufferAndAdvance, offset, inputCount);
					}
				}
				throw new NullReferenceException();
			}
			short num4 = default;
			string text = num4.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text2 = default;
			string message = text2 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			return (string)(object)new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v4+98]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+A0]");
		return (string)0;
	}

	private unsafe Array DeserializeArray(StreamBuffer din)
	{
		//IL_0a3c: Expected I, but got Obj
		//IL_06cd: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I4
		//IL_0735: Expected VT, but got Obj
		//IL_046f: Expected Obj, but got I4
		//IL_075f: Expected Obj, but got I4
		//IL_05b9: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_05e3: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_0bd5: Expected I4, but got I8
		//IL_0bfa: Expected I4, but got I8
		//IL_0c02: Expected I4, but got Obj
		//IL_0a8d: Expected Obj, but got I
		//IL_0b74: Expected I, but got Obj
		//IL_0b83: Expected Obj, but got I4
		//IL_0b9f: Expected Obj, but got I4
		//IL_0bb4: Expected I4, but got Obj
		//IL_07e2: Expected Obj, but got I4
		//IL_0818: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0181: Expected Obj, but got Ref
		//IL_0666: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_0ac4: Expected I, but got Obj
		//IL_0af1: Expected Obj, but got I4
		//IL_0b13: Expected I4, but got Obj
		//IL_0253: Expected I4, but got Obj
		//IL_08d6: Expected Obj, but got I4
		//IL_0914: Expected Obj, but got I
		//IL_02aa: Expected I4, but got Obj
		//IL_0946: Expected Obj, but got I
		//IL_0989: Expected Obj, but got I4
		//IL_0996: Expected I4, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_02e7: Expected I4, but got Obj
		//IL_0305: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_03a0: Expected I4, but got Obj
		//IL_03dc: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I4
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+210]");
		int num2 = 0;
		bool flag = ((ValueType)(object)this).Equals((object)din);
		bool flag2 = din == null;
		System.__Canon value = null;
		byte b;
		Array result;
		Array array;
		int num6;
		object obj6;
		string text2;
		bool flag7;
		object obj5;
		byte b4;
		object obj;
		bool flag4;
		if (!flag2)
		{
			b = din.ReadByte();
			int num3 = b & 0xFF;
			if (num3 <= 104)
			{
				if (num3 == 68)
				{
					bool flag3 = DeserializeDictionaryArray(din, flag ? ((short)1) : ((short)0), out var _);
					result = null;
					goto IL_0826;
				}
				if (num3 == 98)
				{
					return DeserializeByteArray(din, flag ? 1 : 0);
				}
				obj = num3 - 99;
				flag4 = obj == null;
				if (num3 != 99)
				{
					goto IL_05ac;
				}
				byte b2 = din.ReadByte();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
				byte b3 = 0;
				byte value2 = ((byte*)(int)b3)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v20 (System.Byte)+E4]");
				bool flag5 = (nint)0 == 0;
				object obj2 = !flag5;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					value2 = ((byte*)(int)b3)->m_value;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v20 (System.Byte)+A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v21+8]");
				flag2 = (nint)0 == 0;
				value = null;
				b4 = b2;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65169C8]");
					object obj4 = 0;
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v21+8]");
					bool flag6 = ((Dictionary<byte, System.__Canon>)0).TryGetValue(b2, out value);
					flag2 = !flag6;
					obj6 = (object)(&value);
					b4 = b2;
					short num4 = (flag ? ((short)1) : ((short)0));
					if (!flag2)
					{
						flag2 = value == null;
						num2 = (int)(&value);
						b4 = b2;
						if (flag2)
						{
							goto IL_082b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ stack_-48_v5 (System.__Canon)+18]");
						array = Array.CreateInstance((Type)0, flag ? 1 : 0);
						obj = (flag ? 1 : 0) - 1;
						flag4 = obj == null;
						flag7 = (flag ? 1 : 0) < (true ? 1 : 0);
						result = array;
						if (flag7)
						{
							goto IL_0826;
						}
						b3 = 0;
						object value3 = default;
						while (true)
						{
							nint num5 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v26 (Il2CppClass<Photon.Client.Protocol16>)+210]");
							num2 = 0;
							bool flag8 = ((ValueType)(object)this).Equals((object)din);
							object obj7 = (flag8 ? 1 : 0) & 0x8000;
							bool flag9 = obj7 == null;
							flag2 = !flag9;
							b4 = (byte)(int)array;
							if (flag2)
							{
								break;
							}
							flag2 = value == null;
							b4 = (byte)(int)array;
							if (!flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ stack_-48_v5 (System.__Canon)+28]");
								if ((nint)0 == 0)
								{
									goto IL_08eb;
								}
								int position = din.Position;
								flag2 = value == null;
								b4 = (byte)(int)array;
								if (!flag2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ stack_-48_v5 (System.__Canon)+28]");
									object obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ stack_-48_v5 (System.__Canon)+28]");
									flag2 = (nint)0 == 0;
									b4 = (byte)(int)array;
									if (!flag2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v31+28]");
										obj5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X8_v31+18] (should have been resolved before IL gen)");
										int position2 = din.Position;
										object obj9 = position2 - position;
										obj = obj9 - flag8;
										flag4 = (nint)obj9 == (flag8 ? 1 : 0);
										num2 = (flag8 ? 1 : 0);
										if (!flag4)
										{
											int position3 = position + (flag8 ? 1 : 0);
											din.Position = position3;
											num2 = 0;
										}
										flag2 = array == null;
										b4 = (byte)(int)array;
										if (!flag2)
										{
											array.SetValue(value3, b3);
											b3++;
											obj = (flag ? 1 : 0) - (int)b3;
											flag4 = obj == null;
											flag7 = (flag ? 1u : 0u) != b3;
											obj5 = 0;
											if (flag7)
											{
												continue;
											}
											goto IL_0418;
										}
									}
								}
							}
							goto IL_082b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
						int position4 = din.Position;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						string format = default;
						object arg = default;
						object obj10 = default;
						string text = string.Format(format, arg, obj10);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						InvalidDataException ex = default;
						ex._002Ector(text);
						num6 = position4;
						obj5 = 0;
						obj6 = obj10;
						text2 = text;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						string format2 = default;
						object arg2 = default;
						string text3 = string.Format(format2, arg2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Exception ex2 = default;
						ex2._002Ector(text3);
						num6 = b4;
						obj6 = null;
						text2 = text3;
					}
					goto IL_09a3;
				}
			}
			else
			{
				if (num3 == 105)
				{
					return DeserializeIntArray(din, flag ? 1 : 0);
				}
				if (num3 != 120)
				{
					obj = num3 - 121;
					flag4 = obj == null;
					if (num3 != 121)
					{
						goto IL_05ac;
					}
					Array array2 = DeserializeArray(din);
					flag2 = array2 == null;
					value = null;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
						Type elementType = default;
						Array array3 = Array.CreateInstance(elementType, flag ? 1 : 0);
						flag2 = array3 == null;
						value = null;
						num2 = 0;
						if (!flag2)
						{
							array3.SetValue(array2, 0);
							bool flag10 = (flag ? 1 : 0) < 2;
							result = array3;
							if (!flag10)
							{
								int num7 = (flag ? 1 : 0) & 0xFFFF;
								int num8;
								do
								{
									Array value4 = DeserializeArray(din);
									array3.SetValue(value4, 1);
									num8 = 1 + 1;
								}
								while (num7 != num8);
								result = array3;
							}
							goto IL_0826;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v16+E8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FD0A8]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v52+E4]");
					bool flag11 = (nint)0 == 0;
					object obj15 = !flag11;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj14);
					Array array4 = Array.CreateInstance(typeFromHandle, flag ? 1 : 0);
					obj = (flag ? 1 : 0) - 1;
					flag4 = obj == null;
					flag7 = (flag ? 1 : 0) < (true ? 1 : 0);
					result = array4;
					if (flag7)
					{
						goto IL_0826;
					}
					int num9 = (flag ? 1 : 0) & 0xFFFF;
					byte b3 = 0;
					while (true)
					{
						byte[] value5 = DeserializeByteArray(din, -1);
						flag2 = array4 == null;
						value = null;
						num2 = -1;
						b4 = (byte)(int)array4;
						if (flag2)
						{
							break;
						}
						array4.SetValue(value5, b3);
						b3++;
						obj = num9 - b3;
						flag4 = obj == null;
						flag7 = num9 != b3;
						result = array4;
						obj5 = 0;
						if (flag7)
						{
							continue;
						}
						goto IL_0826;
					}
				}
			}
		}
		goto IL_082b;
		IL_082b:
		throw new NullReferenceException();
		IL_0418:
		result = array;
		goto IL_0826;
		IL_0826:
		return result;
		IL_08eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ stack_-48_v5 (System.__Canon)+18]");
		string format3 = default;
		object arg3 = default;
		string text4 = string.Format(format3, 0, arg3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NullReferenceException ex3 = default;
		ex3._002Ector(text4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ stack_-48_v5 (System.__Canon)+10]");
		num6 = 0;
		obj5 = 0;
		obj6 = null;
		b4 = (byte)(int)array;
		text2 = text4;
		goto IL_09a3;
		IL_0699:
		Array array5;
		result = array5;
		goto IL_0826;
		IL_05ac:
		Type typeOfCode = ((Protocol16)b).GetTypeOfCode(b);
		array5 = Array.CreateInstance(typeOfCode, flag ? 1 : 0);
		obj = (flag ? 1 : 0) - 1;
		flag4 = obj == null;
		flag7 = (flag ? 1 : 0) < (true ? 1 : 0);
		result = array5;
		if (flag7)
		{
			goto IL_0826;
		}
		int num10 = (flag ? 1 : 0) & 0xFFFF;
		int num11 = 0;
		while (true)
		{
			nint num12 = (nint)this;
			object value6 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)din, (IFormatProvider)b);
			flag2 = array5 == null;
			obj5 = 0;
			value = null;
			num2 = b;
			b4 = (byte)(int)array5;
			if (flag2)
			{
				break;
			}
			array5.SetValue(value6, num11);
			num11++;
			obj = num10 - num11;
			flag4 = obj == null;
			if (num10 != num11)
			{
				continue;
			}
			goto IL_0699;
		}
		goto IL_082b;
		IL_09a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	private byte[] DeserializeByteArray(StreamBuffer din, int size = default(int))
	{
		//IL_005b: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		object obj = size + 1;
		bool flag = obj == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj2 = 0;
		object obj3 = !flag;
		int count = size;
		if (obj3 == null)
		{
			int num = DeserializeInteger(din);
			count = num;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if (din != null)
		{
			byte[] array = default;
			int num2 = din.Read(array, 0, count);
			return array;
		}
		return (byte[])(object)new NullReferenceException();
	}

	private int[] DeserializeIntArray(StreamBuffer din, int size = default(int))
	{
		//IL_00c6: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		object obj = size + 1;
		bool flag = obj == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj2 = 0;
		object obj3 = !flag;
		int num = size;
		if (obj3 == null)
		{
			int num2 = DeserializeInteger(din);
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		int[] array = default;
		if (num >= 1)
		{
			object obj4 = array + 32;
			object obj5 = 0;
			while (true)
			{
				int num3 = DeserializeInteger(din);
				if (array != null)
				{
					bool flag2 = (nint)obj5 < array.Length;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						obj5++;
						if (num == (nint)obj5)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return (int[])(object)new IndexOutOfRangeException();
			}
		}
		return array;
	}

	private string[] DeserializeStringArray(StreamBuffer din)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		nint num = (nint)this;
		bool flag = ((ValueType)(object)this).Equals((object)din);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array = default;
		if ((flag ? 1 : 0) >= (true ? 1 : 0))
		{
			object obj2 = array + 32;
			object obj3 = 0;
			while (true)
			{
				string text = DeserializeString(din);
				if (array != null)
				{
					bool flag2 = (nint)obj3 < array.Length;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						obj2 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj3++;
						if ((flag ? 1 : 0) == (nint)obj3)
						{
							break;
						}
						continue;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
				return (string[])(object)new IndexOutOfRangeException();
			}
		}
		return array;
	}

	private object[] DeserializeObjectArray(StreamBuffer din)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01a0: Expected I, but got Obj
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_01f7: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_0229: Expected I4, but got Obj
		//IL_00f6: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0107: Expected I4, but got Obj
		//IL_0083: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<Photon.Client.Protocol16>)+210]");
		byte b = 0;
		bool flag = ((ValueType)(object)this).Equals((object)din);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		if ((flag ? 1 : 0) < (true ? 1 : 0))
		{
			goto IL_015d;
		}
		bool flag2 = din == null;
		bool flag3 = flag;
		object[] array = default;
		IndexOutOfRangeException ex = default;
		if (!flag2)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			while (true)
			{
				byte b2 = din.ReadByte();
				nint num2 = (nint)this;
				object obj4 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)din, (IFormatProvider)b2);
				bool flag4 = array == null;
				object obj5 = 0;
				flag3 = (byte)(int)din != 0;
				b = b2;
				if (flag4)
				{
					break;
				}
				bool flag5 = obj4 == null;
				StreamBuffer streamBuffer = din;
				if (!flag5)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					streamBuffer = (StreamBuffer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag6 = ex == null;
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					flag3 = false;
					b = b2;
					if (flag6)
					{
						goto IL_017e;
					}
				}
				bool flag7 = (nint)obj3 < array.Length;
				object obj6 = !flag7;
				obj5 = 0;
				flag3 = (byte)(int)streamBuffer != 0;
				b = b2;
				if (obj6 == null)
				{
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj3++;
					if ((flag ? 1 : 0) != (nint)obj3)
					{
						continue;
					}
					goto IL_015d;
				}
				goto IL_0170;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0170;
		IL_015d:
		return array;
		IL_0170:
		ex = new IndexOutOfRangeException();
		goto IL_017e;
		IL_017e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (object[])(object)new ArgumentNullException();
	}

	private PhotonHashtable DeserializeHashTable(StreamBuffer din)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0055: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2FF0]");
		object obj = 0;
		nint num = (nint)this;
		bool flag = ((ValueType)(object)this).Equals((object)din);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		PhotonHashtable photonHashtable = default;
		photonHashtable._002Ector(flag ? 1 : 0);
		if ((flag ? 1 : 0) >= (true ? 1 : 0))
		{
			bool flag2 = din == null;
			int num2 = (flag ? 1 : 0);
			if (!flag2)
			{
				while (true)
				{
					byte b = din.ReadByte();
					object obj2 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)din, (IFormatProvider)b);
					byte b2 = din.ReadByte();
					object value = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)din, (IFormatProvider)b2);
					if (obj2 != null)
					{
						if (photonHashtable == null)
						{
							break;
						}
						photonHashtable.set_Item(obj2, value);
					}
					num2--;
					if (num2 != 1)
					{
						continue;
					}
					goto IL_00fb;
				}
			}
			return (PhotonHashtable)(object)new NullReferenceException();
		}
		goto IL_00fb;
		IL_00fb:
		return photonHashtable;
	}

	private IDictionary DeserializeDictionary(StreamBuffer din)
	{
		//IL_05c6: Expected Obj, but got I
		//IL_061c: Expected I, but got Obj
		//IL_05fc: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_00d3: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_0190: Expected VT, but got Obj
		//IL_01bb: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I4
		//IL_01f7: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I8
		//IL_02b8: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_038b: Expected I, but got Obj
		//IL_039b: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I4
		//IL_03ee: Expected Obj, but got I4
		//IL_0687: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_06bb: Expected I, but got Obj
		//IL_06c9: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I4
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_04b4: Expected I, but got Obj
		//IL_04c4: Expected Obj, but got I
		//IL_04ff: Expected Obj, but got I
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected Obj, but got Unknown
		bool flag = din == null;
		StreamBuffer streamBuffer = din;
		if (flag)
		{
			goto IL_0592;
		}
		byte b = din.ReadByte();
		byte b2 = din.ReadByte();
		int num = b & 0xFF;
		bool flag2 = num == 121;
		streamBuffer = null;
		IDictionary dictionary = default;
		NotSupportedException ex2;
		object obj21;
		IndexOutOfRangeException ex = default;
		nint num4;
		StreamBuffer streamBuffer3;
		if (!flag2)
		{
			bool flag3 = num == 68;
			streamBuffer = null;
			if (!flag3)
			{
				int num2 = b2 & 0xFF;
				if (num2 != 121 && num2 != 68)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
					object obj = 0;
					nint num3 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v10 (Il2CppClass<Photon.Client.Protocol16>)+210]");
					num4 = 0;
					Protocol16 protocol = (Protocol16)((ValueType)(object)this).Equals((object)din);
					Type typeOfCode = protocol.GetTypeOfCode(b);
					Type typeOfCode2 = ((Protocol16)(object)typeOfCode).GetTypeOfCode(b2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v12+E8]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v13+E4]");
					bool flag4 = (nint)0 == 0;
					object obj5 = !flag4;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					IFormatProvider formatProvider = default;
					bool flag5 = formatProvider == null;
					streamBuffer = (StreamBuffer)2;
					if (flag5)
					{
						goto IL_0592;
					}
					bool flag6 = (object)typeOfCode == null;
					StreamBuffer streamBuffer2 = (StreamBuffer)2;
					if (!flag6)
					{
						nint num5 = (nint)formatProvider;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v32 (Il2CppClass<System.IFormatProvider>)+40]");
						streamBuffer2 = (StreamBuffer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag7 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v32 (Il2CppClass<System.IFormatProvider>)+40]");
						streamBuffer3 = (StreamBuffer)0;
						if (flag7)
						{
							goto IL_0637;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v42 (System.IFormatProvider)+18]");
					bool flag8 = (nint)0 == 0;
					streamBuffer3 = streamBuffer2;
					if (!flag8)
					{
						object obj6 = formatProvider + 32;
						obj6 = typeOfCode;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag9 = (object)typeOfCode2 == null;
						Type type = typeOfCode;
						if (!flag9)
						{
							nint num6 = (nint)formatProvider;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v31 (Il2CppClass<System.IFormatProvider>)+40]");
							type = (Type)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v31 (Il2CppClass<System.IFormatProvider>)+40]");
							streamBuffer3 = (StreamBuffer)0;
							if (flag10)
							{
								goto IL_0637;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v42 (System.IFormatProvider)+18]");
						object obj7 = 0 & 0xFFFFFFFEL;
						bool flag11 = obj7 == null;
						streamBuffer3 = (StreamBuffer)(object)type;
						if (!flag11)
						{
							object obj8 = formatProvider + 40;
							obj8 = typeOfCode2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag12 = (object)typeFromHandle == null;
							streamBuffer = (StreamBuffer)(object)typeOfCode2;
							if (!flag12)
							{
								nint num7 = (nint)typeFromHandle;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
								object obj9 = 0;
								Type type2 = (Type)((Enum)(object)typeFromHandle).System_002EIConvertible_002EToSByte(formatProvider);
								object obj10 = Activator.CreateInstance(type2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								if ((nint)protocol < 1)
								{
									goto IL_058d;
								}
								object obj11 = 0;
								while (true)
								{
									int num8 = b & 0xFF;
									byte b3;
									if (num8 != 42)
									{
										bool flag13 = num8 == 0;
										object obj12 = !flag13;
										b3 = b;
										if (obj12 != null)
										{
											goto IL_0679;
										}
									}
									byte b4 = din.ReadByte();
									b3 = b4;
									goto IL_0679;
									IL_070e:
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ X0_v65] (should have been resolved before IL gen)");
									goto IL_0743;
									IL_06b6:
									nint num9 = (nint)this;
									Type type3 = (Type)((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)din, (IFormatProvider)num4);
									object obj13;
									if (obj13 != null)
									{
										bool flag14 = dictionary == null;
										streamBuffer = din;
										if (flag14)
										{
											break;
										}
										nint num10 = (nint)dictionary;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v27 (Il2CppClass<System.Collections.IDictionary>)+12E]");
										object obj14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v27 (Il2CppClass<System.Collections.IDictionary>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0548;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v27 (Il2CppClass<System.Collections.IDictionary>)+98]");
										object obj15 = (nint)0 + (nint)8;
										object obj16;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X10_v13-8]");
											if (0 == (nint)obj9)
											{
												break;
											}
											obj14--;
											obj16 = obj15 + 16;
											bool flag15 = (nint)obj14 != 1;
											obj15 = obj16;
											if (flag15)
											{
												continue;
											}
											goto IL_0548;
										}
										object obj17 = obj15 + 5;
										object obj18 = num10 + obj17;
										object obj19 = obj18 + 312;
										obj16 = obj15;
										goto IL_070e;
									}
									goto IL_0743;
									IL_0679:
									obj13 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)din, (IFormatProvider)b3);
									int num11 = b2 & 0xFF;
									if (num11 != 42)
									{
										bool flag16 = num11 == 0;
										object obj20 = !flag16;
										num4 = (int)b2;
										if (obj20 != null)
										{
											goto IL_06b6;
										}
									}
									byte b5 = din.ReadByte();
									num4 = (int)b5;
									goto IL_06b6;
									IL_0548:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
									goto IL_070e;
									IL_0743:
									obj11++;
									if (obj11 != protocol)
									{
										continue;
									}
									goto IL_058d;
								}
							}
							goto IL_0592;
						}
					}
					goto IL_0629;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516BD0]");
				obj21 = 0;
				streamBuffer = null;
				NotSupportedException ex3 = default;
				ex2 = ex3;
				goto IL_071d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516BC8]");
		obj21 = 0;
		NotSupportedException ex4 = default;
		ex2 = ex4;
		goto IL_071d;
		IL_0592:
		throw new NullReferenceException();
		IL_0629:
		ex = new IndexOutOfRangeException();
		goto IL_0637;
		IL_071d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string message = default;
		ex2._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex5 = new ArgumentNullException();
		num4 = unchecked((nint)null);
		StreamBuffer streamBuffer4 = default;
		streamBuffer3 = streamBuffer4;
		goto IL_0629;
		IL_0637:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		return (IDictionary)new ArgumentNullException();
		IL_058d:
		return dictionary;
	}

	private unsafe bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult)
	{
		//IL_0032: Expected Obj, but got I
		//IL_039e: Expected I4, but got Obj
		//IL_029b: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I4
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected I4, but got Unknown
		//IL_02f7: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_013e: Expected I4, but got Obj
		//IL_0146: Expected I4, but got Obj
		//IL_0170: Expected I, but got Obj
		//IL_03ef: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		StreamBuffer streamBuffer = default;
		Type type = DeserializeDictionaryType(streamBuffer, out var _, out var _);
		Array array = Array.CreateInstance(type, size);
		ref Array reference = ref *(Array*)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (size >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9D90]");
			object obj = 0;
			object obj2 = Activator.CreateInstance(type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag = default;
			if (flag)
			{
				int num = size & 0xFFFF;
				int num2 = 0;
				bool flag2 = flag;
				Type type2 = type;
				short num3 = size;
				object obj3 = default;
				bool flag6 = default;
				while (true)
				{
					bool flag3 = ((ValueType)(object)this).Equals((object)streamBuffer);
					if ((flag3 ? 1 : 0) >= (true ? 1 : 0))
					{
						obj3 = obj3;
						while (streamBuffer != null)
						{
							byte b = streamBuffer.ReadByte();
							object obj4 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)streamBuffer, (IFormatProvider)b);
							num3 = (short)(int)obj4;
							short num4 = (short)(int)obj4;
							byte b2 = streamBuffer.ReadByte();
							nint num5 = (nint)this;
							byte b3 = b2;
							num3 = num4;
							object obj5 = ((Enum)(object)this).System_002EIConvertible_002EToType((Type)(object)streamBuffer, (IFormatProvider)b3);
							if (num3 != 0)
							{
								bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v15 (System.Boolean)+12E]");
								object obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v15 (System.Boolean)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0226;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v15 (System.Boolean)+98]");
								object obj7 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X10_v11-8]");
									if (0 == (nint)obj)
									{
										break;
									}
									obj6--;
									obj3 = obj7 + 16;
									bool flag4 = (nint)obj6 != 1;
									obj7 = obj3;
									if (flag4)
									{
										continue;
									}
									goto IL_0226;
								}
								object obj8 = obj7 + 5;
								object obj9 = value + obj8;
								object obj10 = obj9 + 312;
								obj3 = obj7;
								goto IL_0435;
							}
							goto IL_046f;
							IL_0435:
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X0_v27] (should have been resolved before IL gen)");
							goto IL_046f;
							IL_046f:
							type2 = (Type)(0 + 1);
							if ((nint)type2 == (flag3 ? 1 : 0))
							{
								goto IL_026b;
							}
							continue;
							IL_0226:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
							goto IL_0435;
						}
						break;
					}
					goto IL_026b;
					IL_026b:
					if (arrayResult == null)
					{
						break;
					}
					arrayResult.SetValue(flag2, num2);
					int num6 = num2 + 1;
					if (num6 != num)
					{
						object obj11 = Activator.CreateInstance(type);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag5 = !flag6;
						object obj12 = !flag5;
						num2 = num6;
						flag2 = flag6;
						if (obj12 != null)
						{
							continue;
						}
					}
					object obj13 = num6 - size;
					bool flag7 = (nint)obj13 < 0;
					int num7 = num6 ^ size;
					int num8 = num6 ^ obj13;
					int num9 = num7 & num8;
					bool flag8 = num9 < 0;
					return flag7 == flag8;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return flag;
		}
		return true;
	}

	private unsafe Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode)
	{
		//IL_0051: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_013f: Expected VT, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		//IL_0254: Expected VT, but got I
		//IL_027f: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_02e7: Expected VT, but got Obj
		//IL_05a5: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got I8
		//IL_041f: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04e2: Expected I, but got Obj
		//IL_04f2: Expected Obj, but got I
		//IL_0502: Expected Obj, but got I
		NotSupportedException ex;
		StreamBuffer streamBuffer = default;
		IndexOutOfRangeException ex4 = default;
		byte b3;
		if (streamBuffer != null)
		{
			byte b = streamBuffer.ReadByte();
			ref byte reference = ref *(byte*)b;
			byte b2 = streamBuffer.ReadByte();
			ref byte reference2 = ref *(byte*)b2;
			b3 = keyTypeCode;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Protocol16 protocol;
			if (keyTypeCode != 0)
			{
				if (keyTypeCode == 68 || keyTypeCode == 121)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516BC8]");
					object obj2 = 0;
					NotSupportedException ex2 = default;
					ex = ex2;
					goto IL_05dd;
				}
				Type typeOfCode = ((Protocol16)b2).GetTypeOfCode(keyTypeCode);
				protocol = (Protocol16)(object)typeOfCode;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X22_v8+E8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v62+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X22_v8+10]");
				RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				b3 = 0;
				protocol = (Protocol16)(object)typeFromHandle;
			}
			int num = b2 & 0xFF;
			Type type;
			if (num != 0)
			{
				if (num == 68 || num == 121)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516BD0]");
					object obj2 = 0;
					NotSupportedException ex3 = default;
					ex = ex3;
					goto IL_05dd;
				}
				byte b4 = valTypeCode;
				type = protocol.GetTypeOfCode(valTypeCode);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X22_v8+E8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v50+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X22_v8+10]");
				RuntimeTypeHandle handle2 = (RuntimeTypeHandle)((nint)0 + (nint)32);
				type = Type.GetTypeFromHandle(handle2);
				byte b4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X22_v8+E8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8428]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v30+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj8);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj11 = default;
			bool flag4 = obj11 == null;
			streamBuffer = (StreamBuffer)2;
			if (!flag4)
			{
				bool flag5 = protocol == null;
				StreamBuffer streamBuffer2 = (StreamBuffer)2;
				if (!flag5)
				{
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v20+40]");
					streamBuffer2 = (StreamBuffer)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag6 = ex4 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v20+40]");
					streamBuffer = (StreamBuffer)0;
					if (flag6)
					{
						goto IL_0528;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v35+18]");
				bool flag7 = (nint)0 == 0;
				streamBuffer = streamBuffer2;
				if (!flag7)
				{
					object obj13 = obj11 + 32;
					obj13 = protocol;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag8 = (object)type == null;
					StreamBuffer streamBuffer3 = (StreamBuffer)(object)protocol;
					if (!flag8)
					{
						object obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v19+40]");
						streamBuffer3 = (StreamBuffer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag9 = ex4 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v19+40]");
						streamBuffer = (StreamBuffer)0;
						if (flag9)
						{
							goto IL_0528;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v35+18]");
					object obj15 = 0 & 0xFFFFFFFEL;
					bool flag10 = obj15 == null;
					streamBuffer = streamBuffer3;
					if (!flag10)
					{
						object obj16 = obj11 + 40;
						obj16 = type;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag11 = (object)typeFromHandle2 == null;
						streamBuffer = (StreamBuffer)(object)type;
						if (!flag11)
						{
							nint num2 = (nint)typeFromHandle2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v18 (Il2CppClass<System.Type>)+940]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v18 (Il2CppClass<System.Type>)+938]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v325 @ X3_v1 (should have been resolved before IL gen)");
						}
						goto IL_050c;
					}
				}
				goto IL_051a;
			}
		}
		goto IL_050c;
		IL_05dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		return (Type)(object)new ArgumentNullException();
		IL_051a:
		ex4 = new IndexOutOfRangeException();
		goto IL_0528;
		IL_050c:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_051a;
		IL_0528:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		b3 = 0;
		throw new ArgumentNullException();
	}

	public Protocol16()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_026e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+18]");
			bool flag = (nint)0 == 1;
			_ = 1;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6503928]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D29E8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65168B8]");
				object obj4 = 0;
				_ = 6;
				object obj5 = this + 24;
				object obj6 = default;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj7 = this + 32;
				object obj8 = default;
				obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj9 = this + 40;
				object obj10 = default;
				obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj11 = this + 48;
				object obj12 = default;
				obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj13 = this + 56;
				object obj14 = default;
				obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj15 = this + 64;
				object obj16 = default;
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj17 = this + 72;
				object obj18 = default;
				obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj19 = this + 80;
				object obj20 = default;
				obj19 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj21 = this + 88;
				object obj22 = default;
				obj21 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj23 = this + 96;
				object obj24 = default;
				obj23 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj25 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v55+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				base._002Ector();
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static Protocol16()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516958]");
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
