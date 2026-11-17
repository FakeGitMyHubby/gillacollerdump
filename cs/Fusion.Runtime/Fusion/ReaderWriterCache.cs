using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;

namespace Fusion;

internal static class ReaderWriterCache
{
	private static readonly Dictionary<Type, object> _readerWriters;

	public unsafe static IElementReaderWriter<T> Get<T>(Type readerWriterType)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_06a3: Expected Obj, but got I
		//IL_06da: Expected Obj, but got I4
		//IL_06f8: Expected Obj, but got I
		//IL_070f: Expected Obj, but got Ref
		//IL_009f: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got Ref
		//IL_00fd: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_074f: Expected Obj, but got I4
		//IL_075f: Expected Obj, but got Ref
		//IL_023e: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_05e7: Expected I, but got Obj
		//IL_0775: Expected Obj, but got Ref
		//IL_0174: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got Ref
		//IL_026f: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I4
		//IL_0621: Expected Obj, but got I4
		//IL_07a2: Expected Obj, but got I
		//IL_07c4: Expected Obj, but got I4
		//IL_05f4: Expected Obj, but got Ref
		//IL_0531: Expected Obj, but got I
		//IL_0887: Expected I, but got Obj
		//IL_0895: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_0315: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_0664: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I4
		//IL_07e2: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I4
		//IL_05dd: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got I4
		//IL_0452: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E30]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		object obj4 = 0;
		bool lockTaken = default;
		Monitor.Enter(obj4, ref lockTaken);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+A0]");
		object obj7 = 0;
		bool flag3 = obj7 == null;
		System.__Canon _Canon = (System.__Canon)(&lockTaken);
		System.__Canon _Canon2 = null;
		Type type = readerWriterType;
		IntPtr intPtr2 = default;
		IntPtr intPtr = intPtr2;
		if (flag3)
		{
			goto IL_04a6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F7200]");
		object obj8 = 0;
		object obj9 = obj8;
		bool flag4 = ((Dictionary<System.__Canon, System.__Canon>)obj7).TryGetValue((System.__Canon)(object)readerWriterType, out System.__Canon value);
		bool flag5 = !flag4;
		_Canon = (System.__Canon)(object)readerWriterType;
		type = readerWriterType;
		intPtr = intPtr2;
		OutOfMemoryException ex;
		object obj13;
		nint num;
		System.__Canon _Canon3;
		if (!flag5)
		{
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag6 = obj11 == null;
			object obj12 = !flag6;
			type = (Type)0;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				Type type2 = default;
				type = type2;
			}
			bool flag7 = value == null;
			ex = null;
			obj13 = 0;
			_Canon3 = (System.__Canon)(object)readerWriterType;
			System.__Canon _Canon4 = (System.__Canon)(&value);
			if (flag7)
			{
				goto IL_05e2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			IntPtr intPtr3 = default;
			bool flag8 = intPtr3 == (IntPtr)0;
			object obj14 = !flag8;
			ex = null;
			obj13 = 0;
			_Canon3 = (System.__Canon)(object)type;
			_Canon4 = (System.__Canon)(&value);
			num = intPtr3;
			if (obj14 != null)
			{
				goto IL_076d;
			}
			InvalidCastException ex2 = new InvalidCastException();
			_Canon = (System.__Canon)(object)type;
			intPtr = intPtr3;
		}
		bool flag9 = (object)type == null;
		_Canon2 = (System.__Canon)(&value);
		if (flag9)
		{
			goto IL_04b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8408]");
		object name = 0;
		MethodInfo method = type.GetMethod((string)name, (BindingFlags)24);
		bool flag10 = method == null;
		bool flag11 = !flag10;
		object obj15 = !flag11;
		_Canon = null;
		_Canon2 = null;
		obj9 = 0;
		nint num2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEAC8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X22_v10+38]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X22_v10+38]");
			bool flag12 = (nint)0 == 0;
			object obj19 = !flag12;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X22_v10+38]");
				obj18 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v31+10]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v55+E4]");
			bool flag13 = (nint)0 == 0;
			object obj21 = !flag13;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X22_v10+38]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v44+10]");
				obj20 = 0;
			}
			bool flag14 = (object)method == null;
			num2 = unchecked((nint)null);
			System.__Canon _Canon4 = null;
			obj9 = 0;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v55+A0]");
				object parameters = 0;
				object obj23 = method.Invoke(null, (object[])parameters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8410]");
				object obj24 = 0;
				Assert.Check(obj23, (string)obj24);
				object obj25 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59+E4]");
				bool flag15 = (nint)0 == 0;
				object obj26 = !flag15;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj25 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v59+A0]");
				object obj27 = 0;
				bool flag16 = obj27 == null;
				_Canon3 = (System.__Canon)obj24;
				_Canon4 = null;
				obj9 = 0;
				if (flag16)
				{
					goto IL_0536;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8400]");
				object obj28 = 0;
				obj9 = obj28;
				((Dictionary<System.__Canon, System.__Canon>)obj27).Add((System.__Canon)(object)type, (System.__Canon)obj23);
				object obj29 = (nint)0 + (nint)309;
				object obj30 = obj29 & 1;
				bool flag17 = obj30 == null;
				object obj31 = !flag17;
				Type type3 = (Type)0;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					Type type4 = default;
					type3 = type4;
				}
				bool flag18 = obj23 == null;
				ex = null;
				obj13 = 0;
				_Canon3 = (System.__Canon)(object)type;
				_Canon4 = (System.__Canon)obj23;
				if (flag18)
				{
					goto IL_05e2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				IntPtr intPtr4 = default;
				bool flag19 = intPtr4 == (IntPtr)0;
				object obj32 = !flag19;
				ex = null;
				obj13 = 0;
				_Canon3 = (System.__Canon)(object)type3;
				_Canon4 = (System.__Canon)obj23;
				num = intPtr4;
				if (obj32 == null)
				{
					InvalidCastException ex3 = new InvalidCastException();
					_Canon = (System.__Canon)(object)type3;
					_Canon2 = (System.__Canon)obj23;
					type = type3;
					intPtr = intPtr4;
					goto IL_04a6;
				}
				goto IL_076d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			string message = string.Format(format, type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex4 = default;
			ex4._002Ector(message);
			ArgumentNullException ex5 = new ArgumentNullException();
			num2 = intPtr;
			System.__Canon _Canon4 = null;
		}
		NullReferenceException ex6 = new NullReferenceException();
		_Canon3 = (System.__Canon)num2;
		goto IL_0536;
		IL_04b4:
		throw new NullReferenceException();
		IL_0536:
		NullReferenceException ex7 = new NullReferenceException();
		NullReferenceException ex8;
		if ((nint)_Canon3 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			ex = null;
			obj13 = 1;
		}
		else
		{
			bool flag20 = (nint)_Canon3 != 1;
			ex8 = ex7;
			if (flag20)
			{
				goto IL_0850;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj33 = default;
			ex = (OutOfMemoryException)obj33;
			obj13 = 0;
		}
		goto IL_05e2;
		IL_0850:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		IElementReaderWriter<T> result = default;
		return result;
		IL_05e2:
		num = unchecked((nint)null);
		goto IL_076d;
		IL_04a6:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_04b4;
		IL_076d:
		object obj34 = (object)(&lockTaken);
		if (obj34 != null)
		{
			object obj36 = default;
			object obj35 = (object)(&obj36);
			Monitor.Exit(obj35);
			_Canon3 = null;
		}
		bool flag21 = ex == null;
		object obj37 = !flag21;
		if (obj37 == null)
		{
			bool flag22 = obj13 == null;
			object obj38 = !flag22;
			OutOfMemoryException ex10 = ex;
			if (obj38 == null)
			{
				return (IElementReaderWriter<T>)num;
			}
		}
		else
		{
			OutOfMemoryException ex10 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex11 = default;
		ex8 = ex11;
		goto IL_0850;
	}

	static ReaderWriterCache()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = dictionary;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
