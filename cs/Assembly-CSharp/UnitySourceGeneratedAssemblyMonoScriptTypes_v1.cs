using System.Runtime.CompilerServices;
using Cpp2ILInjected;

internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	private sealed class Line
	{
		public int sampleRate;

		public float windowMs;

		public float glideMs;

		public float[] buf;

		public int size;

		public int mask;

		public float window;

		public double invWindow;

		public float glideK;

		public float fadeStep;

		public int write;

		public double phase;

		public float glide = 1f;

		public float mix;

		public int warmup;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe static _003CPrivateImplementationDetails_003E.MonoScriptData Get()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_007c: Expected native int or pointer, but got VT
		//IL_0091: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC98]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCA0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = default;
		object obj4 = obj5 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = default;
		object obj6 = obj7 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		byte[] filePathsData = default;
		object obj8 = (nint)(&filePathsData) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_003CPrivateImplementationDetails_003E.MonoScriptData monoScriptData = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((_003CPrivateImplementationDetails_003E.MonoScriptData*)(nint)monoScriptData)->FilePathsData, filePathsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4E8]");
		((_003CPrivateImplementationDetails_003E.MonoScriptData*)(nint)monoScriptData)->TotalTypes = 0;
		_003CPrivateImplementationDetails_003E.MonoScriptData result = default;
		return result;
	}
}
