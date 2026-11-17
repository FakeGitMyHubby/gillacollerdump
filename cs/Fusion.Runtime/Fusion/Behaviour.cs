using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using PlayFab.MultiplayerModels;
using UnityEngine;

namespace Fusion;

public abstract class Behaviour : MonoBehaviour, Action<JoinLobbyResult>, _0021_00210
{
	private const string NameUnavailable = null;

	private const string NameDestroyed = null;

	internal string DebugNameThreadSafe
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00a1: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((bool)this)
			{
				return name;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4870]");
			return (string)0;
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public T AddBehaviour<T>() where T : Behaviour
	{
		if ((object)this != null)
		{
			GameObject gameObject = base.gameObject;
			if ((object)gameObject != null)
			{
				return gameObject.AddComponent<T>();
			}
		}
		return (T)(object)new NullReferenceException();
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool TryGetBehaviour<T>(out T behaviour) where T : Behaviour
	{
		//IL_0079: Expected I4, but got Obj
		if ((object)this != null)
		{
			GameObject gameObject = base.gameObject;
			if ((object)gameObject != null)
			{
				return gameObject.TryGetComponent<T>(out behaviour);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public T GetBehaviour<T>() where T : Behaviour
	{
		if ((object)this != null)
		{
			GameObject gameObject = base.gameObject;
			if ((object)gameObject != null)
			{
				return gameObject.GetComponentInChildren<T>();
			}
		}
		return (T)(object)new NullReferenceException();
	}

	[MethodImpl((MethodImplOptions)256)]
	public static void DestroyBehaviour(Behaviour behaviour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(behaviour);
	}

	private void Fusion_002EILogDumpable_002EDump(StringBuilder builder)
	{
		//IL_0005: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.Behaviour>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Fusion.Behaviour>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected internal virtual void GetDumpString(StringBuilder builder)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
		object value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
		object value2 = 0;
		StringBuilder stringBuilder = builder.Append((string)value);
		string debugNameThreadSafe = DebugNameThreadSafe;
		StringBuilder stringBuilder2 = builder.Append(debugNameThreadSafe);
		StringBuilder stringBuilder3 = builder.Append((string)value2);
	}
}
