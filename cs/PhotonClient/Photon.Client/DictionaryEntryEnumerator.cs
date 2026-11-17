using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Photon.Client;

public struct DictionaryEntryEnumerator : IEnumerable<KeyValuePair<string, JToken>>, _0021_00210, IEnumerable<KeyValuePair<string, object>>
{
	private Dictionary<object, object>.Enumerator enumerator;

	private object System_002ECollections_002EIEnumerator_002ECurrent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64FABF0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.DictionaryEntryEnumerator)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.DictionaryEntryEnumerator)+18]");
			DictionaryEntry dictionaryEntry = new DictionaryEntry(num, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object result = default;
			return result;
		}
	}

	public DictionaryEntry Current
	{
		get
		{
			//IL_0026: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_002c: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.DictionaryEntryEnumerator)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.DictionaryEntryEnumerator)+18]");
			DictionaryEntry dictionaryEntry = new DictionaryEntry(num, 0);
			return (DictionaryEntry)0;
		}
	}

	public object Key
	{
		get
		{
			//IL_0012: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.DictionaryEntryEnumerator)+10]");
			return 0;
		}
	}

	public object Value
	{
		get
		{
			//IL_0012: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.DictionaryEntryEnumerator)+18]");
			return 0;
		}
	}

	public DictionaryEntryEnumerator(Dictionary<object, object>.Enumerator original)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [original @ X1 (System.Collections.Generic.Dictionary`2<System.Object, System.Object>+Enumerator<System.Object, System.Object>)+20]");
		_ = 0;
		enumerator = original;
		_ = original._dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public bool MoveNext()
	{
		return ((Dictionary<System.__Canon, System.__Canon>.Enumerator)this).MoveNext();
	}

	public unsafe void Reset()
	{
		//IL_0010: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected VT, but got Unknown
		//IL_006c: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516048]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object obj2 = default;
		if (obj2 != null)
		{
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+40]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v3+40]");
			if (num == 0)
			{
				Dictionary<System.__Canon, System.__Canon>.Enumerator enumerator = (Dictionary<System.__Canon, System.__Canon>.Enumerator)(obj2 + 16);
				((Dictionary<System.__Canon, System.__Canon>.Enumerator*)enumerator)->System_002ECollections_002EIEnumerator_002EReset();
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new InvalidCastException();
	}

	public void Dispose()
	{
	}
}
