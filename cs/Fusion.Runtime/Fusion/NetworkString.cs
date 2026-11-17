using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Fusion.Async;
using Photon.Client;
using UnityEngine.XR.OpenXR;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)0, Pack = 4)]
public struct NetworkString<TSize> : _0021_00210, Action<OpenXRLoaderBase>, _0021_00210, Action<OperationResponse>, _0021_00210, Action<OperationResponse> where TSize : struct, IFixedStorage
{
	internal int _length;

	internal TSize _data;

	public int Capacity => 128;

	public string Value
	{
		get
		{
			//IL_000c: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0067: Expected Obj, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X0_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA70A4");
			string result = default;
			return result;
		}
		set
		{
			//IL_000c: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_006f: Expected Obj, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA726C");
		}
	}

	public unsafe int Length => (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);

	// C# has no syntax for parameterized property 'Item'.
	public unsafe ref uint get_Item(int index)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Ref, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8EA0");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8CBC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+38]");
		bool flag3 = (nint)0 < (nint)index;
		object obj9 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+38]");
		object obj10 = -index;
		bool flag4 = obj10 == null;
		object obj11 = ~obj9;
		object obj12 = obj11 | flag4;
		object obj13 = default;
		if (obj12 == null)
		{
			return ref *(uint*)(obj13 + index);
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return ref *(uint*)ex;
	}

	private unsafe int SafeLength
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_000f: Expected I4, but got I8
			//IL_0029: Expected Obj, but got I4
			//IL_00a7: Expected Obj, but got I
			//IL_0043: Expected Obj, but got I
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected Obj, but got Unknown
			//IL_006b: Expected Obj, but got I4
			//IL_0121: Expected Obj, but got I4
			//IL_010a: Expected I4, but got Obj
			int num = (int)((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				int result = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					result = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
				}
				bool flag3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < (nint)129;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					return result;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			object arg = default;
			string message = string.Format(format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			ArgumentNullException ex2 = new ArgumentNullException();
			return (int)ex2;
		}
	}

	private unsafe ReadOnlySpan<uint> DataSpan
	{
		get
		{
			//IL_000c: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0134: Expected Obj, but got I
			//IL_0144: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			//IL_00a2: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got I
			//IL_00e5: Expected Obj, but got I
			//IL_0107: Expected Obj, but got I4
			//IL_017f: Expected VT, but got Ref
			//IL_018c: Expected VT, but got Ref
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+F8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			nint num2 = 0;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v7+108]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v2+38]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			ReadOnlySpan<_128> span = (ReadOnlySpan<_128>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
			return (ReadOnlySpan<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref MemoryMarshal.GetReference(span));
		}
	}

	private unsafe Span<uint> DataSpanMut
	{
		get
		{
			//IL_000c: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0144: Expected Obj, but got I
			//IL_0154: Expected Obj, but got I
			//IL_0176: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			//IL_00a2: Expected Obj, but got I4
			//IL_00d5: Expected Obj, but got I
			//IL_00e5: Expected Obj, but got I
			//IL_0107: Expected Obj, but got I4
			//IL_012f: Expected VT, but got Ref
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+110]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			nint num2 = 0;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v7+120]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+38]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
			return (Span<uint>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
		}
	}

	public NetworkString(string value)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA6CC8");
	}

	public unsafe NetworkString(int length, uint[] data)
	{
		//IL_0019: Expected VT, but got I4
		//IL_0024: Expected VT, but got Ref
		//IL_003e: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		NetworkString<TSize> networkString = (NetworkString<TSize>)length;
		_128 _513 = (_128)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
		ReadOnlySpan<uint> values = data;
		((_128*)_513)->Set(values);
	}

	public static implicit operator NetworkString<TSize>(string str)
	{
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA726C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ SYSREG+28]");
		NetworkString<TSize> result = default;
		if (num2 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkString<TSize> result2 = default;
		return result2;
	}

	public static explicit operator string(NetworkString<TSize> str)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA6C80");
		string result = default;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkString<TSize> a, NetworkString<TSize> b)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v4+20]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v4+20]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8388");
		object obj11 = default;
		bool flag3 = obj11 == null;
		return !flag3;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(string a, NetworkString<TSize> b)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA84F0");
		object obj6 = default;
		object obj5 = ~obj6;
		return (byte)(1 & obj5) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator !=(NetworkString<TSize> a, string b)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA84F0");
		object obj6 = default;
		object obj5 = ~obj6;
		return (byte)(1 & obj5) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkString<TSize> a, NetworkString<TSize> b)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v4+20]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v4+20]");
		object obj7 = (nint)0 + (nint)309;
		object obj8 = obj7 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8388");
		object obj11 = default;
		return obj11 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(string a, NetworkString<TSize> b)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA84F0");
		bool result = default;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static bool operator ==(NetworkString<TSize> a, string b)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA84F0");
		bool result = default;
		return result;
	}

	public unsafe bool Get(ref string cache)
	{
		//IL_00b4: Expected Obj, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0313: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_0400: Expected Obj, but got I
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01e6: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I4
		//IL_0366: Expected I4, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_02e5: Expected I, but got Obj
		//IL_02f2: Expected VT, but got Ref
		bool flag = cache == null;
		ref string reference = ref cache;
		if (!flag)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v40 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v30+68]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA80F8");
			bool flag4 = default;
			bool flag3 = !flag4;
			reference = ref *(string*)cache;
			if (flag3)
			{
				return flag4;
			}
		}
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag5 = obj6 == null;
		object obj7 = !flag5;
		nint num3 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj9 = default;
		string text2;
		if (obj9 != null)
		{
			Encoding uTF = Encoding.UTF32;
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag6 = obj11 == null;
			object obj12 = !flag6;
			nint num4 = 0;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num4 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v14 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v15+78]");
			bool flag7 = (nint)obj9 < 0;
			object obj14 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v15+78]");
			object obj15 = obj9 - 0;
			bool flag8 = obj15 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
			object obj16 = 0;
			object obj17 = obj16;
			object obj18 = ~obj14;
			object obj19 = obj18 | flag8;
			if (obj19 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X23_v4+20]");
			object obj20 = (nint)0 + (nint)309;
			object obj21 = obj20 & 1;
			bool flag9 = obj21 == null;
			object obj22 = !flag9;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A60]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X23_v5+38]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X23_v5+38]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X23_v5+38]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X23_v5+38]");
				bool flag11 = (nint)0 == 0;
				object obj27 = !flag11;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X23_v5+38]");
					obj25 = 0;
				}
			}
			ReadOnlySpan<uint> span = default;
			ref uint reference2 = ref MemoryMarshal.GetReference(span);
			object obj28 = obj9 & 0xFFFFFFFFL;
			object obj29 = obj28 << 2;
			if (obj29 == obj29)
			{
				if (uTF != null)
				{
					nint num2 = obj9 << 2;
					string text = uTF.GetString((ReadOnlySpan<byte>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2));
					text2 = text;
					goto IL_0478;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65380");
				ArgumentNullException ex = new ArgumentNullException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v10+98]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v11+A0]");
		object obj32 = 0;
		text2 = (string)obj32;
		goto IL_0478;
		IL_0478:
		ref string reference3 = ref *(string*)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return true;
	}

	public bool Set(string value)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0147: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got VT
		//IL_00c2: Expected VT, but got Obj
		//IL_0113: Expected I4, but got Obj
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		bool flag = value == null;
		object obj = !flag;
		string text = value;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v9+98]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v10+A0]");
			object obj4 = 0;
			text = (string)obj4;
		}
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8EA0");
		Span<uint> dst = default;
		TaskManager._003C_003Ec__DisplayClass10_0.ConversionResult conversionResult = UTF32Tools.Convert(text, dst);
		object obj9 = conversionResult >> 32;
		NetworkString<TSize> networkString = (NetworkString<TSize>)obj9;
		if (text != null)
		{
			object obj10 = text._stringLength - conversionResult;
			return obj10 == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe int IndexOf(char c, int startIndex = default(int))
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			num = 0;
		}
		object obj6 = obj2 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref this, startIndex));
		int num2 = c & 0xFFFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA7454");
		int result = default;
		return result;
	}

	public int IndexOf(char c, int startIndex, int count)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		int num2 = c & 0xFFFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA7454");
		int result = default;
		return result;
	}

	public unsafe int IndexOf(uint codePoint, int startIndex = default(int))
	{
		//IL_000c: Expected Obj, but got I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got Ref
		//IL_0066: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			num = 0;
		}
		object obj6 = obj2 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref this, startIndex));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA7454");
		int result = default;
		return result;
	}

	public int IndexOf(uint codePoint, int startIndex, int count)
	{
		//IL_0346: Expected Obj, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0040: Expected I4, but got I8
		//IL_005a: Expected Obj, but got I4
		//IL_02f2: Expected Obj, but got I
		//IL_033a: Expected I4, but got Obj
		//IL_0096: Expected I4, but got I8
		//IL_00b0: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_012b: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_02c4: Expected I4, but got I8
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		int num2 = (int)(startIndex & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj5 = !flag2;
		object obj6 = default;
		ArgumentOutOfRangeException ex;
		if (obj5 == null && (nint)obj6 >= startIndex)
		{
			int num3 = (int)(count & 0x80000000L);
			bool flag3 = num3 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				object obj8 = count + startIndex;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
				{
					object obj9 = (nint)0 + (nint)309;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
					object obj10 = 0;
					object obj11 = obj9 & 1;
					bool flag4 = obj11 == null;
					object obj12 = !flag4;
					nint num4 = 0;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v24 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
					object obj14 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v11+78]");
					object obj15 = -startIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v11+78]");
					bool flag5 = (nint)0 < (nint)startIndex;
					object obj16 = !flag5;
					object obj17 = ~obj16;
					if (obj17 == null)
					{
						bool flag6 = (nint)obj15 < count;
						object obj18 = !flag6;
						if (obj18 != null)
						{
							goto IL_01ee;
						}
					}
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					goto IL_01ee;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEB8]");
			object obj19 = 0;
			ArgumentOutOfRangeException ex2 = default;
			ex = ex2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CA0]");
			object obj19 = 0;
			ArgumentOutOfRangeException ex3 = default;
			ex = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string paramName = default;
		ex._002Ector(paramName);
		ArgumentNullException ex4 = new ArgumentNullException();
		return (int)ex4;
		IL_0382:
		int num5;
		return num5;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X23_v2+20]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag7 = obj21 == null;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if (count == 0)
		{
			goto IL_02b7;
		}
		num5 = startIndex;
		int num6 = count;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v26+returnVal2 @ X0_v30 (System.Int32)*4]");
			if ((nint)0 == (int)codePoint)
			{
				break;
			}
			num6--;
			num5++;
			if (num6 != 1)
			{
				continue;
			}
			goto IL_02b7;
		}
		goto IL_0382;
		IL_02b7:
		num5 = -1;
		goto IL_0382;
	}

	public int IndexOf(string str, int startIndex = default(int))
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num2 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		object obj10 = default;
		object obj9 = obj10 - startIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA7668");
		int result = default;
		return result;
	}

	public int IndexOf(string str, int startIndex, int count)
	{
		//IL_0017: Expected I4, but got I8
		//IL_0031: Expected Obj, but got I4
		//IL_047a: Expected I4, but got Obj
		//IL_03f4: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00f6: Expected I4, but got I8
		//IL_0110: Expected Obj, but got I4
		//IL_042a: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected VT, but got Unknown
		//IL_0344: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		ArgumentOutOfRangeException ex;
		if (str != null)
		{
			int num = (int)(startIndex & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			string text = str;
			object obj24;
			if (obj == null)
			{
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				nint num2 = 0;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v24 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v8+70]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
				object obj6 = default;
				if ((nint)obj6 >= startIndex)
				{
					int num3 = (int)(count & 0x80000000L);
					bool flag3 = num3 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						object obj8 = (nint)0 + (nint)309;
						object obj9 = obj8 & 1;
						bool flag4 = obj9 == null;
						object obj10 = !flag4;
						nint num4 = 0;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v35 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v12+70]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
						object obj12 = count + startIndex;
						object obj13 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
						{
							object obj14 = (nint)0 + (nint)309;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
							object obj15 = 0;
							object obj16 = obj14 & 1;
							bool flag5 = obj16 == null;
							object obj17 = !flag5;
							nint num5 = 0;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v39 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
							object obj19 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v16+78]");
							object obj20 = -startIndex;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v16+78]");
							bool flag6 = (nint)0 < (nint)startIndex;
							object obj21 = !flag6;
							object obj22 = ~obj21;
							if (obj22 == null)
							{
								bool flag7 = (nint)obj20 < count;
								object obj23 = !flag7;
								if (obj23 != null)
								{
									goto IL_02cf;
								}
							}
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							goto IL_02cf;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEB8]");
					obj24 = 0;
					ArgumentOutOfRangeException ex2 = default;
					ex = ex2;
					goto IL_04a9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CA0]");
			obj24 = 0;
			ArgumentOutOfRangeException ex3 = default;
			ex = ex3;
			goto IL_04a9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex4 = default;
		string paramName = default;
		ex4._002Ector(paramName);
		goto IL_046c;
		IL_04a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string paramName2 = default;
		ex._002Ector(paramName2);
		goto IL_046c;
		IL_02cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X23_v2+20]");
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag8 = obj26 == null;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj28 = default;
		ReadOnlySpan<uint> str2 = (ReadOnlySpan<uint>)(obj28 + startIndex);
		int num6 = UTF32Tools.IndexOf(str2, (string)count);
		bool flag9 = num6 < 0;
		int num7 = num6 ^ num6;
		int num8 = num6 & num7;
		bool flag10 = num8 < 0;
		bool flag11 = flag9 == flag10;
		object obj29 = !flag11;
		object obj30 = ~obj29;
		int num9 = ((obj30 != null) ? startIndex : 0);
		return num9 + num6;
		IL_046c:
		ArgumentNullException ex5 = new ArgumentNullException();
		return (int)ex5;
	}

	public int IndexOf<TOtherSize>(NetworkString<TOtherSize> str, int startIndex = default(int)) where TOtherSize : struct, IFixedStorage
	{
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X10_v1+70]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ X10_v2] (should have been resolved before IL gen)");
		object obj12 = default;
		object obj11 = obj12 - startIndex;
		nint num3 = 0;
		object obj13 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public int IndexOf<TOtherSize>(NetworkString<TOtherSize> str, int startIndex, int count) where TOtherSize : struct, IFixedStorage
	{
		//IL_0022: Expected Obj, but got I
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public int IndexOf<TOtherSize>(ref NetworkString<TOtherSize> str, int startIndex = default(int)) where TOtherSize : struct, IFixedStorage
	{
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X10_v1+70]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ X10_v2] (should have been resolved before IL gen)");
		object obj12 = default;
		object obj11 = obj12 - startIndex;
		nint num3 = 0;
		object obj13 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public unsafe int IndexOf<TOtherSize>(ref NetworkString<TOtherSize> str, int startIndex, int count) where TOtherSize : struct, IFixedStorage
	{
		//IL_002b: Expected I4, but got I8
		//IL_0045: Expected Obj, but got I4
		//IL_04df: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_0527: Expected I4, but got Obj
		//IL_0537: Expected Obj, but got I
		//IL_0547: Expected Obj, but got I
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_0675: Expected Obj, but got I
		//IL_0108: Expected I4, but got I8
		//IL_0122: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I4
		//IL_058d: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05c5: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I
		//IL_06e2: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_0207: Expected I4, but got I8
		//IL_05e8: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got Unknown
		//IL_0620: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_070e: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I
		//IL_074e: Expected Obj, but got I4
		//IL_075e: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0316: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected VT, but got Unknown
		//IL_037f: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03dd: Expected Obj, but got I
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0405: Expected Obj, but got I4
		//IL_042f: Expected VT, but got I4
		//IL_0484: Expected Obj, but got I4
		int num = (int)(startIndex & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		ref NetworkString<TOtherSize> reference = ref str;
		object obj39;
		ArgumentOutOfRangeException ex;
		object obj43;
		if (obj == null)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2;
			object obj4 = obj2 & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				object obj6 = (nint)0 + (nint)309;
				obj3 = obj6;
				nint num2 = 0;
			}
			else
			{
				nint num3 = 0;
				nint num2 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v3+70]");
			object obj8 = 0;
			object obj9 = obj3 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				nint num2 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8+70]");
			reference = ref *(NetworkString<TOtherSize>*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ X10_v4] (should have been resolved before IL gen)");
			object obj12 = default;
			if ((nint)obj12 >= startIndex)
			{
				int num4 = (int)(count & 0x80000000L);
				bool flag4 = num4 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					object obj14 = (nint)0 + (nint)309;
					object obj15 = obj14;
					object obj16 = obj14 & 1;
					bool flag5 = obj16 == null;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						object obj18 = (nint)0 + (nint)309;
						obj15 = obj18;
						nint num5 = 0;
					}
					else
					{
						nint num6 = 0;
						nint num5 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v25 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v6+70]");
					object obj20 = 0;
					object obj21 = obj15 & 1;
					bool flag6 = obj21 == null;
					object obj22 = !flag6;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						IntPtr intPtr2 = default;
						nint num5 = intPtr2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v12 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v13+70]");
					reference = ref *(NetworkString<TOtherSize>*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X10_v7] (should have been resolved before IL gen)");
					object obj24 = count + startIndex;
					object obj25 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25))
					{
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v287 @ X1_v8 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
						object obj26 = default;
						if ((nint)obj26 > count)
						{
							return -1;
						}
						object obj27 = (nint)0 + (nint)309;
						object obj28 = obj27;
						object obj29 = obj27 & 1;
						bool flag7 = obj29 == null;
						object obj30 = !flag7;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							object obj31 = (nint)0 + (nint)309;
							obj28 = obj31;
							nint num8 = 0;
						}
						else
						{
							nint num9 = 0;
							nint num8 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v32 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X10_v9+78]");
						object obj33 = 0;
						object obj34 = obj28 & 1;
						bool flag8 = obj34 == null;
						object obj35 = !flag8;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
							IntPtr intPtr3 = default;
							nint num8 = intPtr3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v20 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X10_v10] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v21+78]");
						object obj37 = -startIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v21+78]");
						bool flag9 = (nint)0 < (nint)startIndex;
						object obj38 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
						obj39 = 0;
						object obj40 = obj39;
						object obj41 = ~obj38;
						if (obj41 == null)
						{
							bool flag10 = (nint)obj37 < count;
							object obj42 = !flag10;
							if (obj42 != null)
							{
								goto IL_02d8;
							}
						}
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						goto IL_02d8;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEB8]");
				obj43 = 0;
				ArgumentOutOfRangeException ex2 = default;
				ex = ex2;
				goto IL_0640;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CA0]");
		obj43 = 0;
		ArgumentOutOfRangeException ex3 = default;
		ex = ex3;
		goto IL_0640;
		IL_02d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X24_v9+20]");
		object obj44 = (nint)0 + (nint)309;
		object obj45 = obj44 & 1;
		bool flag11 = obj45 == null;
		object obj46 = !flag11;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj47 = default;
		ReadOnlySpan<uint> str2 = (ReadOnlySpan<uint>)(obj47 + startIndex);
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v416 @ X1_v11 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v421 @ X8_v28 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj48 = obj39;
		object obj49 = default;
		bool flag12 = (nint)obj49 < 0;
		object obj50 = !flag12;
		object obj51 = obj49 - 0;
		bool flag13 = obj51 == null;
		object obj52 = ~obj50;
		object obj53 = obj52 | flag13;
		if (obj53 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X21_v4+20]");
		object obj54 = (nint)0 + (nint)309;
		object obj55 = obj54 & 1;
		bool flag14 = obj55 == null;
		object obj56 = !flag14;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		int num12 = UTF32Tools.IndexOf(str2, (ReadOnlySpan<uint>)count);
		bool flag15 = num12 < 0;
		int num13 = num12 ^ num12;
		int num14 = num12 & num13;
		bool flag16 = num14 < 0;
		bool flag17 = flag15 == flag16;
		object obj57 = !flag17;
		object obj58 = ~obj57;
		int num15 = ((obj58 != null) ? startIndex : 0);
		return num15 + num12;
		IL_0640:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string paramName = default;
		ex._002Ector(paramName);
		ArgumentNullException ex4 = new ArgumentNullException();
		return (int)ex4;
	}

	public bool Contains(char c)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_0090: Expected I4, but got Obj
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA72FC");
		object obj6 = default;
		object obj5 = ~obj6;
		return (byte)(obj5 >> 31) != 0;
	}

	public bool Contains(uint codePoint)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_0090: Expected I4, but got Obj
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA73D8");
		object obj6 = default;
		object obj5 = ~obj6;
		return (byte)(obj5 >> 31) != 0;
	}

	public bool Contains(string str)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_0090: Expected I4, but got Obj
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA75D8");
		object obj6 = default;
		object obj5 = ~obj6;
		return (byte)(obj5 >> 31) != 0;
	}

	public bool Contains<TOtherSize>(NetworkString<TOtherSize> str) where TOtherSize : struct, IFixedStorage
	{
		//IL_003b: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ X3_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj = ~obj2;
		return (byte)(obj >> 31) != 0;
	}

	public bool Contains<TOtherSize>(ref NetworkString<TOtherSize> str) where TOtherSize : struct, IFixedStorage
	{
		//IL_003b: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ X3_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj = ~obj2;
		return (byte)(obj >> 31) != 0;
	}

	public NetworkString<TSize> Substring(int startIndex)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num2 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		object obj10 = default;
		object obj9 = obj10 - startIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA7A1C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ SYSREG+28]");
		NetworkString<TSize> result = default;
		if (num3 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkString<TSize> result2 = default;
		return result2;
	}

	public unsafe NetworkString<TSize> Substring(int startIndex, int length)
	{
		//IL_04a7: Expected I4, but got I8
		//IL_04c1: Expected Obj, but got I4
		//IL_04c6: Expected I, but got Obj
		//IL_040d: Expected Obj, but got I
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I4
		//IL_00b7: Expected I4, but got I8
		//IL_00d1: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02da: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_033e: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		int num = (int)(startIndex & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		nint num2 = unchecked((nint)null);
		ArgumentOutOfRangeException ex;
		object obj23;
		if (obj == null)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			nint num3 = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v19 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v8+70]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
			object obj6 = default;
			if ((nint)obj6 > startIndex)
			{
				int num4 = (int)(length & 0x80000000L);
				bool flag3 = num4 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					object obj8 = (nint)0 + (nint)309;
					object obj9 = obj8 & 1;
					bool flag4 = obj9 == null;
					object obj10 = !flag4;
					nint num5 = 0;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v30 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v12+70]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
					object obj12 = length + startIndex;
					object obj13 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v35 (Il2CppClass<Fusion.NetworkString`1>)+135]");
						object obj15 = (nint)0 & (nint)1;
						bool flag5 = obj15 == null;
						object obj16 = !flag5;
						nint num7 = 0;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v36 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
						object obj18 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15+78]");
						object obj19 = -startIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15+78]");
						bool flag6 = (nint)0 < (nint)startIndex;
						object obj20 = !flag6;
						object obj21 = ~obj20;
						if (obj21 == null)
						{
							bool flag7 = (nint)obj19 < length;
							object obj22 = !flag7;
							if (obj22 != null)
							{
								goto IL_029c;
							}
						}
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						goto IL_029c;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6EE0]");
				obj23 = 0;
				ArgumentOutOfRangeException ex2 = default;
				ex = ex2;
				goto IL_04d4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F6CA0]");
		obj23 = 0;
		ArgumentOutOfRangeException ex3 = default;
		ex = ex3;
		goto IL_04d4;
		IL_047c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkString<TSize> result = default;
		return result;
		IL_029c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X25_v5+20]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag8 = obj25 == null;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6C70]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v42 (Il2CppClass<Fusion.NetworkString`1>)+135]");
		object obj28 = (nint)0 & (nint)1;
		bool flag9 = obj28 == null;
		object obj29 = !flag9;
		nint num9 = 0;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v43 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8EA0");
		ReadOnlySpan<uint> readOnlySpan = default;
		Span<uint> destination = default;
		readOnlySpan.CopyTo(destination);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		bool flag10 = num10 != 0;
		object obj31 = 516;
		int num11 = default;
		num2 = (nint)(&num11);
		NetworkString<TSize> networkString = default;
		ArgumentNullException ex4 = (ArgumentNullException)networkString;
		if (!flag10)
		{
			return networkString;
		}
		goto IL_047c;
		IL_04d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		bool flag11 = num12 != 0;
		obj31 = 516;
		string text = default;
		ex4 = (ArgumentNullException)(object)text;
		if (!flag11)
		{
			ex._002Ector(text);
			ex4 = new ArgumentNullException();
			obj31 = 0;
			IntPtr intPtr = default;
			num2 = intPtr;
		}
		goto IL_047c;
	}

	public NetworkString<TSize> ToLower()
	{
		//IL_027e: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00d0: Invalid comparison between VT and I
		//IL_00e1: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5 (Il2CppClass<Fusion.NetworkString`1>)+135]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		nint num3 = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num3 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		nint num4 = 0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v14 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+78]");
		Span<uint> span = default;
		bool flag4 = span < (object)0;
		object obj14 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+78]");
		object obj15 = span - 0;
		bool flag5 = obj15 == null;
		object obj16 = ~obj14;
		object obj17 = obj16 | flag5;
		if (obj17 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X25_v3+20]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag6 = obj19 == null;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag7 = obj22 == null;
		object obj23 = !flag7;
		nint num5 = 0;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v21 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8EA0");
		ReadOnlySpan<uint> src = default;
		UTF32Tools.ToLowerInvariant(src, span);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		NetworkString<TSize> result = default;
		if (num6 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkString<TSize> result2 = default;
		return result2;
	}

	public NetworkString<TSize> ToUpper()
	{
		//IL_027e: Expected Obj, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_02ca: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00d0: Invalid comparison between VT and I
		//IL_00e1: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v5 (Il2CppClass<Fusion.NetworkString`1>)+135]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		nint num3 = 0;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num3 = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		nint num4 = 0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v14 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+78]");
		Span<uint> span = default;
		bool flag4 = span < (object)0;
		object obj14 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7+78]");
		object obj15 = span - 0;
		bool flag5 = obj15 == null;
		object obj16 = ~obj14;
		object obj17 = obj16 | flag5;
		if (obj17 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X25_v3+20]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag6 = obj19 == null;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag7 = obj22 == null;
		object obj23 = !flag7;
		nint num5 = 0;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v21 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8EA0");
		ReadOnlySpan<uint> src = default;
		UTF32Tools.ToUpperInvariant(src, span);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		NetworkString<TSize> result = default;
		if (num6 == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkString<TSize> result2 = default;
		return result2;
	}

	public unsafe int GetCharCount()
	{
		//IL_0247: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_026f: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got Ref
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I8
		//IL_0163: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_0232: Expected I4, but got Obj
		//IL_01ad: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		Encoding uTF = Encoding.UTF32;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+78]");
		bool flag3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < unchecked((nint)null);
		object obj10 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+78]");
		object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref this, 0));
		bool flag4 = obj11 == null;
		object obj12 = ~obj10;
		object obj13 = obj12 | flag4;
		if (obj13 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X23_v3+20]");
		object obj14 = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A60]");
		object obj15 = 0;
		object obj16 = obj14 & 1;
		bool flag5 = obj16 == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X22_v5+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X22_v5+38]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X22_v5+38]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X22_v5+38]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X22_v5+38]");
				obj19 = 0;
			}
		}
		ReadOnlySpan<uint> span = default;
		ref uint reference = ref MemoryMarshal.GetReference(span);
		object obj22 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) & 0xFFFFFFFFL;
		object obj23 = obj22 << 2;
		if (obj23 == obj23)
		{
			if (uTF == null)
			{
				goto IL_0224;
			}
			nint num2 = (nint)uTF;
			object obj24 = (nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v13 (Il2CppClass<System.Text.Encoding>)+3B0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v13 (Il2CppClass<System.Text.Encoding>)+3A8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v142 @ X4_v1 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65380");
		ArgumentNullException ex = new ArgumentNullException();
		goto IL_0224;
		IL_0224:
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
	}

	public int Compare(string s)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_022a: Expected I4, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I4
		if (s != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			nint num2 = 0;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v17 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
			object obj10 = obj5;
			bool flag4 = default;
			bool flag3 = flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+78]");
			bool flag5 = (nint)(flag3 ? 1 : 0) < (nint)0;
			object obj11 = !flag5;
			bool flag6 = flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+78]");
			object obj12 = (nint)(flag6 ? 1 : 0) - (nint)0;
			bool flag7 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag7;
			if (obj14 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X21_v2+20]");
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag8 = obj16 == null;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			ReadOnlySpan<uint> strB = default;
			return UTF32Tools.CompareOrdinal(s, strB, flag4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}

	public int Compare(NetworkString<TSize> s)
	{
		//IL_0363: Expected Obj, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00c7: Invalid comparison between VT and I
		//IL_00d8: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0320: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		nint num2 = 0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+78]");
		ReadOnlySpan<uint> readOnlySpan = default;
		bool flag3 = readOnlySpan < (object)0;
		object obj11 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+78]");
		object obj12 = readOnlySpan - 0;
		bool flag4 = obj12 == null;
		object obj13 = ~obj11;
		object obj14 = obj13 | flag4;
		if (obj14 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X25_v1+20]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag5 = obj16 == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag6 = obj19 == null;
		object obj20 = !flag6;
		nint num3 = 0;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v14 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag7 = obj23 == null;
		object obj24 = !flag7;
		nint num4 = 0;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj26 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v13+78]");
		object obj27 = default;
		bool flag8 = (nint)obj27 < 0;
		object obj28 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v13+78]");
		object obj29 = obj27 - 0;
		bool flag9 = obj29 == null;
		object obj30 = ~obj28;
		object obj31 = obj30 | flag9;
		if (obj31 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X24_v3+20]");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag10 = obj33 == null;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<uint> strA = default;
		bool ignoreCase = default;
		return UTF32Tools.CompareOrdinal(strA, readOnlySpan, ignoreCase);
	}

	public int Compare(ref NetworkString<TSize> s)
	{
		//IL_0363: Expected Obj, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00c7: Invalid comparison between VT and I
		//IL_00d8: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_0191: Expected Obj, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0320: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		nint num2 = 0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+78]");
		ReadOnlySpan<uint> readOnlySpan = default;
		bool flag3 = readOnlySpan < (object)0;
		object obj11 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+78]");
		object obj12 = readOnlySpan - 0;
		bool flag4 = obj12 == null;
		object obj13 = ~obj11;
		object obj14 = obj13 | flag4;
		if (obj14 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X25_v1+20]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag5 = obj16 == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag6 = obj19 == null;
		object obj20 = !flag6;
		nint num3 = 0;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v14 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag7 = obj23 == null;
		object obj24 = !flag7;
		nint num4 = 0;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v18 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj26 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v13+78]");
		object obj27 = default;
		bool flag8 = (nint)obj27 < 0;
		object obj28 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v13+78]");
		object obj29 = obj27 - 0;
		bool flag9 = obj29 == null;
		object obj30 = ~obj28;
		object obj31 = obj30 | flag9;
		if (obj31 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X24_v3+20]");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag10 = obj33 == null;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<uint> strA = default;
		bool ignoreCase = default;
		return UTF32Tools.CompareOrdinal(strA, readOnlySpan, ignoreCase);
	}

	public int Compare<TOtherSize>(NetworkString<TOtherSize> other) where TOtherSize : struct, IFixedStorage
	{
		//IL_0022: Expected Obj, but got I
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v41 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public int Compare<TOtherSize>(ref NetworkString<TOtherSize> other) where TOtherSize : struct, IFixedStorage
	{
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_0096: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_010b: Invalid comparison between VT and I
		//IL_011c: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got I
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got I4
		//IL_01ee: Expected I4, but got VT
		//IL_021c: Expected Obj, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+78]");
		ReadOnlySpan<uint> readOnlySpan = default;
		bool flag3 = readOnlySpan < (object)0;
		object obj9 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5+78]");
		object obj10 = readOnlySpan - 0;
		bool flag4 = obj10 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = ~obj9;
		object obj14 = obj13 | flag4;
		if (obj14 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X23_v2+20]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag5 = obj16 == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		bool ignoreCase = (byte)(int)other.DataSpan != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj18 = obj11;
		object obj19 = default;
		bool flag6 = (nint)obj19 < 0;
		object obj20 = !flag6;
		object obj21 = obj19 - 0;
		bool flag7 = obj21 == null;
		object obj22 = ~obj20;
		object obj23 = obj22 | flag7;
		if (obj23 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X24_v3+20]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag8 = obj25 == null;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<uint> strA = default;
		return UTF32Tools.CompareOrdinal(strA, readOnlySpan, ignoreCase);
	}

	public bool Equals(string s)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA80F8");
		object obj5 = default;
		return obj5 == null;
	}

	public unsafe override bool Equals(object obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A78]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		bool flag = default;
		if (flag)
		{
			object obj3 = (nint)0 + (nint)309;
			object obj4 = obj3 & 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			nint num = 0;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj6 = 0;
			bool value = ((bool*)(flag ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v1+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5 (System.Boolean)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5 (System.Boolean)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0125;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5 (System.Boolean)+98]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v5-8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v3+20]");
				if (num2 == 0)
				{
					break;
				}
				obj8--;
				obj9 += 16;
				if ((nint)obj8 != 1)
				{
					continue;
				}
				goto IL_0125;
			}
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X21_v3+50]");
			object obj11 = obj10 + 0;
			object obj12 = value + obj11;
			object obj13 = obj12 + 312;
			goto IL_01bd;
		}
		return flag;
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		goto IL_01bd;
		IL_01bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F84");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v8+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v74 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Equals(NetworkString<TSize> other)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8388");
		object obj5 = default;
		return obj5 == null;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Equals(ref NetworkString<TSize> other)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8388");
		object obj5 = default;
		return obj5 == null;
	}

	public bool Equals<TOtherSize>(NetworkString<TOtherSize> other) where TOtherSize : struct, IFixedStorage
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ X2_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj = default;
		return obj == null;
	}

	public bool Equals<TOtherSize>(ref NetworkString<TOtherSize> other) where TOtherSize : struct, IFixedStorage
	{
		int num = Compare(ref other);
		return num == 0;
	}

	public void Assign(string value)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA6CC8");
	}

	public bool StartsWith(string s)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_022a: Expected I4, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I4
		//IL_01de: Expected I4, but got Obj
		if (s != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			nint num2 = 0;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v17 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+78]");
			string text = default;
			bool flag3 = (nint)text < 0;
			object obj11 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+78]");
			object obj12 = text - 0;
			bool flag4 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag4;
			if (obj14 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X21_v2+20]");
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag5 = obj16 == null;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			ReadOnlySpan<uint> strA = default;
			return UTF32Tools.StartsWithOrdinal(strA, text, (byte)(int)s != 0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (byte)(int)ex2 != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool StartsWith<TOtherSize>(ref NetworkString<TOtherSize> other) where TOtherSize : struct, IFixedStorage
	{
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_0304: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I
		//IL_03a0: Invalid comparison between VT and I
		//IL_03b1: Expected Obj, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v1+78]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ X10_v2] (should have been resolved before IL gen)");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11;
		object obj13 = obj11 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj15 = (nint)0 + (nint)309;
			obj12 = obj15;
			nint num3 = 0;
		}
		else
		{
			nint num4 = 0;
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v3+70]");
		object obj17 = 0;
		object obj18 = obj12 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			nint num3 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v9 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X10_v4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+78]");
		ReadOnlySpan<uint> readOnlySpan = default;
		bool flag5 = readOnlySpan < (object)0;
		object obj21 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+78]");
		object obj22 = readOnlySpan - 0;
		bool flag6 = obj22 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = ~obj21;
		object obj26 = obj25 | flag6;
		if (obj26 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X23_v2+20]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag7 = obj28 == null;
		object obj29 = !flag7;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X1_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X8_v16 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj30 = obj23;
		object obj31 = default;
		bool flag8 = (nint)obj31 < 0;
		object obj32 = !flag8;
		object obj33 = obj31 - 0;
		bool flag9 = obj33 == null;
		object obj34 = ~obj32;
		object obj35 = obj34 | flag9;
		if (obj35 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X24_v4+20]");
		object obj36 = (nint)0 + (nint)309;
		object obj37 = obj36 & 1;
		bool flag10 = obj37 == null;
		object obj38 = !flag10;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<uint> strA = default;
		bool ignoreCase = default;
		return UTF32Tools.StartsWithOrdinal(strA, readOnlySpan, ignoreCase);
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool EndsWith<TOtherSize>(ref NetworkString<TOtherSize> other) where TOtherSize : struct, IFixedStorage
	{
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_0304: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I
		//IL_03a0: Invalid comparison between VT and I
		//IL_03b1: Expected Obj, but got I4
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj5 = (nint)0 + (nint)309;
			obj2 = obj5;
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v1+78]");
		object obj7 = 0;
		object obj8 = obj2 & 1;
		bool flag2 = obj8 == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ X10_v2] (should have been resolved before IL gen)");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11;
		object obj13 = obj11 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			object obj15 = (nint)0 + (nint)309;
			obj12 = obj15;
			nint num3 = 0;
		}
		else
		{
			nint num4 = 0;
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v3+70]");
		object obj17 = 0;
		object obj18 = obj12 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			nint num3 = intPtr2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v9 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X10_v4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+78]");
		ReadOnlySpan<uint> readOnlySpan = default;
		bool flag5 = readOnlySpan < (object)0;
		object obj21 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+78]");
		object obj22 = readOnlySpan - 0;
		bool flag6 = obj22 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = ~obj21;
		object obj26 = obj25 | flag6;
		if (obj26 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X23_v2+20]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag7 = obj28 == null;
		object obj29 = !flag7;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X1_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X8_v16 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj30 = obj23;
		object obj31 = default;
		bool flag8 = (nint)obj31 < 0;
		object obj32 = !flag8;
		object obj33 = obj31 - 0;
		bool flag9 = obj33 == null;
		object obj34 = ~obj32;
		object obj35 = obj34 | flag9;
		if (obj35 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X24_v4+20]");
		object obj36 = (nint)0 + (nint)309;
		object obj37 = obj36 & 1;
		bool flag10 = obj37 == null;
		object obj38 = !flag10;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<uint> strA = default;
		bool ignoreCase = default;
		return UTF32Tools.EndsWithOrdinal(strA, readOnlySpan, ignoreCase);
	}

	public bool EndsWith(string s)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_022a: Expected I4, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I4
		//IL_01de: Expected I4, but got Obj
		if (s != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			nint num2 = 0;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v17 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+78]");
			string text = default;
			bool flag3 = (nint)text < 0;
			object obj11 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+78]");
			object obj12 = text - 0;
			bool flag4 = obj12 == null;
			object obj13 = ~obj11;
			object obj14 = obj13 | flag4;
			if (obj14 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X21_v2+20]");
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag5 = obj16 == null;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			ReadOnlySpan<uint> strA = default;
			return UTF32Tools.EndsWithOrdinal(strA, text, (byte)(int)s != 0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (byte)(int)ex2 != 0;
	}

	public override int GetHashCode()
	{
		//IL_01a3: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4378]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8E10");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		nint num2 = 0;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5+78]");
		object obj11 = default;
		bool flag3 = (nint)obj11 < 0;
		object obj12 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5+78]");
		object obj13 = obj11 - 0;
		bool flag4 = obj13 == null;
		object obj14 = ~obj12;
		object obj15 = obj14 | flag4;
		if (obj15 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v3+20]");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag5 = obj17 == null;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		ReadOnlySpan<uint> str = default;
		return UTF32Tools.GetHashDeterministic(str);
	}

	public override string ToString()
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA6C80");
		string result = default;
		return result;
	}

	private unsafe void Fusion_002EIReadOnlySpanAssignable_002ESet(ReadOnlySpan<uint> values)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected I4, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_009c: Expected VT, but got Ref
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00b7: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A80]");
		object error = 0;
		nint num = default;
		bool flag = num < 0;
		bool flag2 = num == 0;
		object obj = num ^ num;
		object obj2 = num & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		bool condition = (byte)((flag4 & obj3) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4370]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+20]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag5 = obj7 == null;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		_128 _513 = (_128)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
		ReadOnlySpan<uint> values2 = (ReadOnlySpan<uint>)(values + 4);
		((_128*)_513)->Set(values2);
	}

	public unsafe UTF32Tools.CharEnumerator GetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0086: Expected native int or pointer, but got VT
		//IL_0093: Expected native int or pointer, but got VT
		//IL_009d: Expected VT, but got Ref
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X0_v1 (Il2CppClass<Fusion.NetworkString`1>)+135]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		int num2 = 0;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			num2 = 0;
		}
		uint* utf = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 4));
		UTF32Tools.CharEnumerator charEnumerator = new UTF32Tools.CharEnumerator(utf, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this));
		UTF32Tools.CharEnumerator charEnumerator2 = default;
		((UTF32Tools.CharEnumerator*)(nint)charEnumerator2)->_index = num2;
		((UTF32Tools.CharEnumerator*)(nint)charEnumerator2)->_ptr = (uint*)num2;
		return (UTF32Tools.CharEnumerator)(&charEnumerator);
	}

	private IEnumerator<char> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EChar_003E_002EGetEnumerator()
	{
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A88]");
		object obj2 = 0;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8B48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<char> result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I
		object obj = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9A88]");
		object obj2 = 0;
		object obj3 = obj & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FA8B48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator result = default;
		return result;
	}

	private int SafeIndex(int index)
	{
		//IL_000c: Expected Obj, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_00f2: Expected I4, but got I8
		//IL_010c: Expected Obj, but got I4
		//IL_00c6: Expected I4, but got Obj
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v2 (Il2CppClass<Fusion.NetworkString`1>)+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3383890");
		int num2 = (int)(index & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj5 = !flag2;
		object obj6 = default;
		if (obj5 == null && (nint)obj6 > index)
		{
			return index;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentOutOfRangeException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}
}
public static class NetworkString
{
	public static int GetCapacity<TSize>() where TSize : struct, IFixedStorage
	{
		//IL_0037: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00e3: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<TSize>)+FC]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<TSize>)+FC]");
		object obj2 = (nint)0 + (nint)3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<TSize>)+FC]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<TSize>)+FC]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<TSize>)+FC]");
		object obj3 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v3 (Il2CppClass<TSize>)+FC]");
		object obj4 = 0 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			obj = obj2;
		}
		return obj >> 2;
	}
}
