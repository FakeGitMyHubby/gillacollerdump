using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

public class BVHNodeDrawInfo
{
	internal HitboxBuffer Buffer;

	internal int NodeIndex;

	public unsafe Bounds Bounds
	{
		get
		{
			//IL_0119: Expected VT, but got Obj
			//IL_002e: Expected VT, but got Obj
			//IL_0037: Invalid comparison between VT and I4
			//IL_005b: Expected Obj, but got I
			//IL_00a3: Expected Obj, but got I4
			//IL_00c1: Expected Obj, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_00eb: Expected VT, but got I
			//IL_00e6: Expected native int or pointer, but got VT
			if (Buffer != null)
			{
				Bounds bounds = (Bounds)Buffer.BVH;
				if (bounds != (Bounds)(object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v6 (UnityEngine.Bounds)+10]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v6 (UnityEngine.Bounds)+10]");
					if ((nint)0 != 0)
					{
						int nodeIndex = NodeIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v3+18]");
						bool flag = (nint)nodeIndex < (nint)0;
						object obj2 = !flag;
						if (obj2 == null)
						{
							object obj3 = NodeIndex * 120;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v6 (UnityEngine.Bounds)+10]");
							object obj4 = 0 + obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+20]");
							Bounds bounds2 = default;
							((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+30]");
							_ = 0;
							return bounds;
						}
						goto IL_010b;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_010b;
			IL_010b:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (Bounds)ex2;
		}
	}

	public int Depth
	{
		get
		{
			//IL_00f0: Expected I4, but got Obj
			//IL_0097: Expected Obj, but got I4
			//IL_00b5: Expected Obj, but got I4
			if (Buffer != null)
			{
				BVH bVH = Buffer.BVH;
				if ((object)bVH != null)
				{
					BVHNode[] nodes = bVH._nodes;
					if (bVH._nodes != null)
					{
						bool flag = NodeIndex < nodes.Length;
						object obj = !flag;
						if (obj == null)
						{
							object obj2 = NodeIndex * 120;
							object obj3 = (object)bVH._nodes + obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4+7C]");
							return 0;
						}
						goto IL_00e2;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_00e2;
			IL_00e2:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
		}
	}

	public int MaxDepth
	{
		get
		{
			//IL_0063: Expected I4, but got Obj
			if (Buffer != null)
			{
				BVH bVH = Buffer.BVH;
				if ((object)bVH != null)
				{
					return bVH.maxDepth;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal BVHNodeDrawInfo(HitboxBuffer buffer)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = buffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal BVHNodeDrawInfo FromBVHNode(ref BVHNode node)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X1 (Fusion.LagCompensation.BVHNode&)+48]");
		NodeIndex = 0;
		return this;
	}
}
