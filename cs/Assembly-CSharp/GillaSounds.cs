using System;
using Cpp2ILInjected;
using UnityEngine;

public class GillaSounds : ScriptableObject
{
	public ReverbProbe.SurfaceSet[] surfaces;

	public AudioClip[] keyPresses;

	public float keyPressVolume;

	private static GillaSounds loaded;

	public static GillaSounds Get()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I4
		//IL_00d8: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4320]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4330]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4328]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v10+A0]");
			object obj10 = 0;
			object obj11 = default;
			obj10 = obj11;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		return (GillaSounds)0;
	}

	public ReverbProbe.SurfaceSet For(SurfaceKind kind)
	{
		//IL_005c: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I8
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		ReverbProbe.SurfaceSet[] array = surfaces;
		ReverbProbe.SurfaceSet surfaceSet;
		if (surfaces != null)
		{
			if (array.Length < 1)
			{
				surfaceSet = null;
				goto IL_01ed;
			}
			object obj = ~array.Length;
			object obj2 = array.Length & obj;
			object obj3 = array.Length & 0xFFFFFFFFL;
			object obj4 = surfaces + 32;
			ReverbProbe.SurfaceSet surfaceSet2 = null;
			while (obj3 != null)
			{
				surfaceSet = (ReverbProbe.SurfaceSet)obj4;
				if (obj4 != null)
				{
					AudioClip[] clips = surfaceSet.clips;
					if (surfaceSet.clips != null)
					{
						clips = (AudioClip[])clips.Length;
						if (clips.Length != 0)
						{
							clips = (AudioClip[])surfaceSet.kind;
							if (surfaceSet.kind == kind)
							{
								goto IL_01ed;
							}
							if (surfaceSet.kind == 0)
							{
								surfaceSet2 = (ReverbProbe.SurfaceSet)obj4;
							}
						}
					}
				}
				obj4 += 8;
				obj3--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				surfaceSet = surfaceSet2;
				goto IL_01ed;
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (ReverbProbe.SurfaceSet)(object)new NullReferenceException();
		IL_01ed:
		return surfaceSet;
	}

	public GillaSounds()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4338]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 24;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = this + 32;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		keyPressVolume = 0.6f;
		base._002Ector();
	}
}
