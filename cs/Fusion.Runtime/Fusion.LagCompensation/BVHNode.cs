using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion.LagCompensation;

internal struct BVHNode
{
	internal const int MaxEntriesPerNode = default(int);

	internal const int RootNodeIndex = default(int);

	private static readonly HitboxRoot.HitboxComparerX ComparerX;

	private static readonly HitboxRoot.HitboxComparerY ComparerY;

	private static readonly BehaviourUtils.HitboxComparerZ ComparerZ;

	public Bounds Box;

	internal AABB _cachedBounds;

	private int _nodeIndex;

	private int _parentIndex;

	private int _leftIndex;

	private int _rightIndex;

	internal bool Active;

	internal int Depth;

	internal bool Used;

	internal int Next;

	internal HitboxRoot _root;

	internal bool _isLeaf;

	internal int Index => _nodeIndex;

	internal bool IsValid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = _nodeIndex < 0;
			bool flag2 = _nodeIndex == 0;
			int num = _nodeIndex ^ _nodeIndex;
			int num2 = _nodeIndex & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	internal bool IsRootNode
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = _nodeIndex - 1;
			return obj == null;
		}
	}

	internal bool HasParent
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = _parentIndex < 0;
			bool flag2 = _parentIndex == 0;
			int num = _parentIndex ^ _parentIndex;
			int num2 = _parentIndex & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	internal bool HasLeft
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = _leftIndex < 0;
			bool flag2 = _leftIndex == 0;
			int num = _leftIndex ^ _leftIndex;
			int num2 = _leftIndex & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	internal bool HasRight
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = _rightIndex < 0;
			bool flag2 = _rightIndex == 0;
			int num = _rightIndex ^ _rightIndex;
			int num2 = _rightIndex & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	internal bool IsLeaf
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _isLeaf;
		}
	}

	internal bool HasValidRoot
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003c: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			//IL_00a6: Expected Obj, but got I4
			HitboxRoot root = _root;
			if ((object)_root != null)
			{
				object obj = root.Flags & (SimulationBehaviourRuntimeFlags)8;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					NetworkObject networkObject = ((SimulationBehaviour)root)._object;
					if ((object)((SimulationBehaviour)root)._object != null)
					{
						object obj3 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
						return obj3 == null;
					}
				}
			}
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe ref BVHNode GetParent(BVH bvh)
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Ref, but got Unknown
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				bool flag = _parentIndex < nodes.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = _parentIndex * 120;
					object obj3 = (object)bvh._nodes + obj2;
					return ref *(BVHNode*)(obj3 + 32);
				}
				goto IL_00ba;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ba;
		IL_00ba:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(BVHNode*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe ref BVHNode GetRight(BVH bvh)
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Ref, but got Unknown
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				bool flag = _rightIndex < nodes.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = _rightIndex * 120;
					object obj3 = (object)bvh._nodes + obj2;
					return ref *(BVHNode*)(obj3 + 32);
				}
				goto IL_00ba;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ba;
		IL_00ba:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(BVHNode*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe ref BVHNode GetLeft(BVH bvh)
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Ref, but got Unknown
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				bool flag = _leftIndex < nodes.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = _leftIndex * 120;
					object obj3 = (object)bvh._nodes + obj2;
					return ref *(BVHNode*)(obj3 + 32);
				}
				goto IL_00ba;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ba;
		IL_00ba:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(BVHNode*)ex2;
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADF8]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		return string.Format((string)format, arg);
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void RefitObjectChanged(BVH bvh)
	{
		//IL_016e: Expected Obj, but got I
		//IL_0018: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I
		HitboxRoot root = _root;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACD0]");
		object error = 0;
		bool condition;
		if ((object)_root != null)
		{
			object obj = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj == null;
			condition = flag;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65C0]");
		object obj2 = 0;
		throw new ArgumentNullException();
	}

	private unsafe void ExpandVolume(BVH bvh, Vector3 objectpos, float radius, ref Bounds bounds, bool expandParent)
	{
		//IL_07d7: Expected F4, but got I
		//IL_081f: Expected F4, but got I
		//IL_00f4: Expected Obj, but got I4
		//IL_00cb: Expected native int or pointer, but got VT
		//IL_00d8: Expected native int or pointer, but got VT
		//IL_00e6: Expected Obj, but got I4
		//IL_092f: Invalid comparison between Obj and F4
		//IL_089f: Invalid comparison between Obj and F8
		//IL_0198: Expected native int or pointer, but got VT
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_01b3: Expected Obj, but got I4
		//IL_098a: Invalid comparison between Obj and F8
		//IL_0257: Expected native int or pointer, but got VT
		//IL_0264: Expected native int or pointer, but got VT
		//IL_0292: Expected Obj, but got I4
		//IL_038a: Expected native int or pointer, but got VT
		//IL_0397: Expected native int or pointer, but got VT
		//IL_03a4: Expected native int or pointer, but got VT
		//IL_03b7: Expected Obj, but got I4
		//IL_04af: Expected native int or pointer, but got VT
		//IL_04bc: Expected native int or pointer, but got VT
		//IL_04c9: Expected native int or pointer, but got VT
		//IL_04dc: Expected Obj, but got I4
		//IL_05d4: Expected native int or pointer, but got VT
		//IL_05e1: Expected native int or pointer, but got VT
		//IL_05ee: Expected native int or pointer, but got VT
		//IL_0601: Expected Obj, but got I4
		//IL_0614: Expected Obj, but got I
		//IL_0641: Expected Obj, but got I
		//IL_066b: Expected Obj, but got I4
		//IL_06d1: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I4
		//IL_0775: Expected Obj, but got I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected VT, but got Unknown
		//IL_07a3: Expected Ref, but got VT
		float num = objectpos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [objectpos @ X2 (UnityEngine.Vector3)+C]");
		float num2 = 0f;
		object obj = default;
		float num3 = radius - (float)obj;
		float num4 = objectpos.y;
		float num5 = objectpos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [objectpos @ X2 (UnityEngine.Vector3)+C]");
		float num6 = num5 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [objectpos @ X2 (UnityEngine.Vector3)+10]");
		float num7 = 0f;
		object obj2;
		if (num3 < num6)
		{
			float num8 = objectpos.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [objectpos @ X2 (UnityEngine.Vector3)+C]");
			float num9 = num8 + 0f;
			float num10 = objectpos.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [objectpos @ X2 (UnityEngine.Vector3)+10]");
			float num11 = num10 - 0f;
			float num12 = objectpos.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [objectpos @ X2 (UnityEngine.Vector3)+10]");
			float num13 = num12 + 0f;
			float num14 = num9 - num3;
			float num15 = num13 - num11;
			num2 = num14 * 0.5f;
			num7 = num15 * 63f;
			num = num3 + num2;
			num4 = num11 + num7;
			((Vector3*)(nint)objectpos)->x = num;
			((Vector3*)(nint)objectpos)->y = num4;
			obj2 = 1;
		}
		else
		{
			obj2 = 0;
		}
		float num16 = num + num2;
		float num17 = radius + (float)obj;
		if (num17 > num16)
		{
			float num18 = num - num2;
			float num19 = num4 + num7;
			float num20 = num4 - num7;
			float num21 = num17 - num18;
			float num22 = num19 - num20;
			num2 = num21 * 0.5f;
			num7 = num22 * 63f;
			num = num18 + num2;
			num4 = num20 + num7;
			((Vector3*)(nint)objectpos)->x = num;
			((Vector3*)(nint)objectpos)->y = num4;
			obj2 = 1;
		}
		float num23 = num4 - num7;
		object obj4 = default;
		object obj3 = obj4 - obj;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num23);
		double num25 = default;
		double num24 = num25;
		double num26 = num4;
		double num27 = num7;
		double num29 = default;
		double num28 = num29;
		if (!flag)
		{
			float num30 = num4 + num7;
			float num31 = num - num2;
			float num32 = num + num2;
			float num33 = num30 - (float)obj3;
			float num34 = num32 - num31;
			float num35 = num33 * 63f;
			num2 = num34 * 0.5f;
			float num36 = (float)obj3 + num35;
			num = (((Vector3*)(nint)objectpos)->x = num31 + num2);
			((Vector3*)(nint)objectpos)->y = num36;
			num24 = num25;
			num26 = num36;
			num27 = num35;
			num28 = num29;
			obj2 = 1;
		}
		double num37 = num26 + num27;
		object obj5 = obj4 + obj;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num37))
		{
			float num38 = num + num2;
			float num39 = num - num2;
			double num40 = num26 - num27;
			double num41 = num28 + num24;
			double num42 = num28 - num24;
			float num43 = num38 - num39;
			double num44 = (double)obj5 - num40;
			double num45 = num41 - num42;
			num2 = num43 * 0.5f;
			num27 = num44 * 0.5;
			num24 = num45 * 0.5;
			num = num39 + num2;
			num26 = num40 + num27;
			num28 = num42 + num24;
			((Vector3*)(nint)objectpos)->x = num;
			((Vector3*)(nint)objectpos)->y = (float)num26;
			((Vector3*)(nint)objectpos)->z = (float)num28;
			obj2 = 1;
		}
		double num46 = num28 - num24;
		object obj7 = default;
		object obj6 = obj7 - obj;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num46))
		{
			float num47 = num - num2;
			float num48 = num + num2;
			double num49 = num26 - num27;
			double num50 = num26 + num27;
			double num51 = num28 + num24;
			float num52 = num48 - num47;
			double num53 = num50 - num49;
			double num54 = num51 - (double)obj6;
			num2 = num52 * 0.5f;
			num27 = num53 * 0.5;
			num24 = num54 * 0.5;
			num = num47 + num2;
			num26 = num49 + num27;
			num28 = (double)obj6 + num24;
			((Vector3*)(nint)objectpos)->x = num;
			((Vector3*)(nint)objectpos)->y = (float)num26;
			((Vector3*)(nint)objectpos)->z = (float)num28;
			obj2 = 1;
		}
		double num55 = num28 + num24;
		double num56 = (double)obj7 + (double)obj;
		bool flag2 = !(num56 > num55);
		float num57 = (float)num55;
		float num58 = (float)num24;
		double num59 = num;
		if (!flag2)
		{
			num57 = num + num2;
			float num60 = num - num2;
			double num61 = num26 + num27;
			double num62 = num26 - num27;
			num26 = num28 - num24;
			float num63 = num57 - num60;
			double num64 = num61 - num62;
			num56 -= num26;
			num58 = num63 * 0.5f;
			double num65 = num64 * 0.5;
			num28 = num56 * 0.5;
			num2 = num60 + num58;
			num27 = num62 + num65;
			num59 = num26 + num28;
			((Vector3*)(nint)objectpos)->x = num2;
			((Vector3*)(nint)objectpos)->y = (float)num27;
			((Vector3*)(nint)objectpos)->z = (float)num59;
			obj2 = 1;
		}
		if (obj2 == null)
		{
			return;
		}
		object obj8 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bounds) & (nint)1;
		if (obj8 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (_parentIndex < 1)
		{
			return;
		}
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				bool flag5 = _parentIndex < nodes.Length;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					object obj15 = _parentIndex * 120;
					object obj16 = (object)bvh._nodes + obj15;
					BVHNode bVHNode = (BVHNode)(obj16 + 32);
					((BVHNode*)bVHNode)->ChildExpanded(bvh, ref this);
					return;
				}
				goto IL_07b3;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_07b3;
		IL_07b3:
		throw new IndexOutOfRangeException();
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void AssignVolume(Vector3 pos, float radius, ref Bounds bounds)
	{
		//IL_016a: Expected native int or pointer, but got VT
		//IL_0177: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj4 = obj2 + obj3;
		float num = pos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pos @ X1 (UnityEngine.Vector3)+C]");
		float num2 = num + 0f;
		float num3 = pos.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pos @ X1 (UnityEngine.Vector3)+14]");
		float num4 = num3 + 0f;
		object obj5 = default;
		float num5 = radius - (float)obj5;
		float num6 = radius + (float)obj5;
		float num7 = num4 - (float)obj;
		float num8 = num2 - num5;
		float num9 = num7 * 0.5f;
		float num10 = num8 * 63f;
		float num11 = (float)obj + num9;
		float num12 = num5 + num10;
		float num13 = num11 - num9;
		float num14 = num12 - num10;
		float num15 = (float)obj4 - num13;
		float num16 = num6 - num14;
		float num17 = num15 * 0.5f;
		float num18 = num16 * 63f;
		float z = num13 + num17;
		float x = num14 + num18;
		((Vector3*)(nint)pos)->z = z;
		((Vector3*)(nint)pos)->x = x;
	}

	private void ComputeVolume(BVH bvh)
	{
		//IL_0123: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Expected VT, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_029d: Expected VT, but got Obj
		HitboxRoot root = _root;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		if ((object)_root != null)
		{
			object obj2 = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Vector3 vector = root.CachedTransform.TransformPoint((Vector3)0);
				HitboxRoot root2 = _root;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (Fusion.HitboxRoot)+78]");
				float num = 0f - root2.BroadRadius;
				Bounds box = Box;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+C]");
				object obj6 = box + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+14]");
				object obj7 = num2 + 0;
				object obj9 = default;
				object obj8 = root.Offset - obj9;
				object obj10 = root.Offset + obj9;
				float num3 = (float)obj7 - num;
				object obj11 = obj6 - obj8;
				double num4 = (double)num3 * 0.5;
				object obj12 = obj11 * 63;
				double num5 = (double)num + num4;
				object obj13 = obj8 + obj12;
				double num6 = num5 - num4;
				object obj14 = obj13 - obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (Fusion.HitboxRoot)+78]");
				float num7 = 0f + root2.BroadRadius;
				object obj15 = obj10 - obj14;
				double num8 = (double)num7 - num6;
				object obj16 = obj15 * 63;
				double num9 = num8 * 0.5;
				Bounds box2 = (Bounds)(obj14 + obj16);
				double num10 = num6 + num9;
				Box = box2;
				return;
			}
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ChildRefit(bvh, _nodeIndex, propagate: false);
	}

	private unsafe Bounds ComputeMinVolume(BVH bvh)
	{
		//IL_01a2: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0152: Expected VT, but got I4
		//IL_015b: Expected F8, but got I4
		//IL_0164: Expected F8, but got I4
		//IL_016d: Expected VT, but got I4
		//IL_0175: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0306: Expected native int or pointer, but got VT
		//IL_0318: Expected native int or pointer, but got VT
		//IL_0188: Expected VT, but got Obj
		//IL_0075: Expected VT, but got I4
		//IL_00aa: Expected VT, but got Obj
		//IL_00cc: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected VT, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected VT, but got Unknown
		HitboxRoot root = _root;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		Bounds result;
		Vector3 vector2;
		Vector3 center;
		double num8;
		double num9;
		if ((object)_root != null)
		{
			object obj2 = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				if ((object)root.CachedTransform != null)
				{
					Vector3 vector = root.CachedTransform.TransformPoint((Vector3)0);
					HitboxRoot root2 = _root;
					if ((object)_root != null)
					{
						result = (Bounds)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v2 (UnityEngine.Bounds)+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v2 (Fusion.HitboxRoot)+78]");
						float num = 0f - root2.BroadRadius;
						object obj6 = default;
						object obj5 = root.Offset - obj6;
						object obj7 = root.Offset + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v2 (Fusion.HitboxRoot)+78]");
						float num2 = 0f + root2.BroadRadius;
						float num3 = 0f - num;
						object obj8 = 0 - obj5;
						double num4 = (double)num3 * 0.5;
						object obj9 = obj8 * 63;
						double num5 = (double)num + num4;
						object obj10 = obj5 + obj9;
						double num6 = num5 - num4;
						object obj11 = obj10 - obj9;
						double num7 = (double)num2 - num6;
						object obj12 = obj7 - obj11;
						vector2 = (Vector3)(obj12 * 63);
						num8 = num7 * 0.5;
						center = obj11 + vector2;
						num9 = num6 + num8;
						goto IL_02fe;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (Bounds)ex;
			}
		}
		Assert.Fail();
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ChildRefit(bvh, _nodeIndex, propagate: false);
		vector2 = (Vector3)0;
		num8 = 0.0;
		num9 = 0.0;
		center = (Vector3)0;
		result = (Bounds)bvh;
		goto IL_02fe;
		IL_02fe:
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Center = center;
		((Bounds*)(nint)bounds)->m_Extents = vector2;
		return result;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe bool RefitVolume(BVH bvh)
	{
		//IL_026b: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected VT, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got Ref
		//IL_025b: Expected I4, but got Obj
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got Ref
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_0228: Expected VT, but got Ref
		//IL_0233: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACD0]");
		object error = 0;
		HitboxRoot root = _root;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		bool condition;
		if ((object)_root != null)
		{
			object obj2 = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj2 == null;
			condition = flag;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Bounds bounds = ComputeMinVolume(bvh);
		Vector3 point = default;
		object obj5 = default;
		Vector3 vector = point - obj5;
		Bounds bounds2 = default;
		bool flag3 = bounds2.Internal_Contains(ref point);
		bool flag4 = !flag3;
		object obj6 = 0;
		object obj7 = (object)(&point);
		AABB aABB = (AABB)vector;
		if (!flag4)
		{
			AABB aABB2 = (AABB)(point + obj5);
			bool flag5 = bounds2.Internal_Contains(ref point);
			bool flag6 = !flag5;
			obj6 = 0;
			obj7 = (object)(&point);
			aABB = aABB2;
			if (!flag6)
			{
				return false;
			}
		}
		Box = (Bounds)point;
		if ((object)bvh != null)
		{
			object obj8 = obj5 + obj5;
			object obj10 = default;
			object obj9 = obj10 + obj10;
			object obj11 = obj;
			object obj13 = default;
			object obj12 = obj8 * obj13;
			float num = (float)obj9 * bvh.ExpansionFactor;
			object obj14 = obj12 * 63;
			double num2 = (double)num * 0.5;
			object obj15 = obj5 + obj14;
			double num3 = (double)obj10 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = default;
			aABB = new AABB((Bounds)(&obj17));
			_cachedBounds = (AABB)0;
			_ = 0;
			_ = 0;
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	internal static float SA(Bounds box)
	{
		//IL_0017: Expected Obj, but got VT
		//IL_002e: Expected Obj, but got VT
		//IL_004b: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		object obj = box.m_Center + box.m_Extents;
		object obj2 = box.m_Center - box.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds)+14]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds)+14]");
		object obj4 = num2 - 0;
		object obj5 = obj - obj2;
		object obj6 = obj3 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj7 = obj6 * obj5;
		object obj8 = obj5 * obj;
		object obj9 = obj8 + obj7;
		object obj11 = default;
		object obj10 = obj11 + obj9;
		return (float)obj10 + (float)obj10;
	}

	internal static float SA(ref Bounds box)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		Bounds bounds = box;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds&)+C]");
		object obj = bounds + 0;
		Bounds bounds2 = box;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds&)+C]");
		object obj2 = bounds2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds&)+14]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds&)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [box @ X0 (UnityEngine.Bounds&)+14]");
		object obj4 = num2 - 0;
		object obj5 = obj - obj2;
		object obj6 = obj3 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj7 = obj6 * obj5;
		object obj8 = obj5 * obj;
		object obj9 = obj8 + obj7;
		object obj11 = default;
		object obj10 = obj11 + obj9;
		return (float)obj10 + (float)obj10;
	}

	internal static float SA(ref BVHNode node)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		BVHNode bVHNode = node;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+C]");
		object obj = bVHNode + 0;
		BVHNode bVHNode2 = node;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+C]");
		object obj2 = bVHNode2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+14]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+14]");
		object obj4 = num2 - 0;
		object obj5 = obj - obj2;
		object obj6 = obj3 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj7 = obj6 * obj5;
		object obj8 = obj5 * obj;
		object obj9 = obj8 + obj7;
		object obj11 = default;
		object obj10 = obj11 + obj9;
		return (float)obj10 + (float)obj10;
	}

	internal unsafe static Bounds AABBofPair(ref BVHNode nodea, ref BVHNode nodeb)
	{
		//IL_001d: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0295: Invalid comparison between F8 and I4
		//IL_02a4: Invalid comparison between F8 and I4
		//IL_02b7: Expected Obj, but got F8
		//IL_02c4: Expected Obj, but got F8
		//IL_030d: Expected Obj, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected VT, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected VT, but got Unknown
		//IL_0384: Expected native int or pointer, but got VT
		//IL_03a5: Expected native int or pointer, but got VT
		//IL_03b4: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodea @ X0 (Fusion.LagCompensation.BVHNode&)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodea @ X0 (Fusion.LagCompensation.BVHNode&)+14]");
		object obj = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodea @ X0 (Fusion.LagCompensation.BVHNode&)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodea @ X0 (Fusion.LagCompensation.BVHNode&)+14]");
		object obj2 = num2 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodeb @ X1 (Fusion.LagCompensation.BVHNode&)+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodeb @ X1 (Fusion.LagCompensation.BVHNode&)+14]");
		object obj3 = num3 - 0;
		BVHNode bVHNode = nodea;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodea @ X0 (Fusion.LagCompensation.BVHNode&)+C]");
		object obj4 = bVHNode + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodeb @ X1 (Fusion.LagCompensation.BVHNode&)+8]");
		double num4 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [nodeb @ X1 (Fusion.LagCompensation.BVHNode&)+14]");
		double num5 = num4 + 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			obj = obj3;
		}
		object obj5 = obj2 - obj3;
		bool flag = (nint)obj5 < 0;
		bool flag2 = obj5 == null;
		object obj6 = obj2 ^ obj3;
		object obj7 = obj2 ^ obj5;
		object obj8 = obj6 & obj7;
		bool flag3 = (nint)obj8 < 0;
		bool flag4 = flag == flag3;
		object obj9 = !flag2;
		object obj10 = flag4 & obj9;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			obj2 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
		object obj12 = obj2 - obj;
		object obj13 = obj4 - nodea;
		double num6 = (double)obj12 * 0.5;
		object obj14 = obj13 * 63;
		double num7 = (double)obj + num6;
		object obj15 = nodea + obj14;
		double num8 = num7 - num6;
		object obj16 = obj14 + obj15;
		double num9 = num6 + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
		if (!(num8 < num5))
		{
			num8 = num5;
		}
		double num10 = num9 - num5;
		bool flag5 = num10 < 0.0;
		bool flag6 = num10 == 0.0;
		object obj17 = num9 ^ num5;
		object obj18 = num9 ^ num10;
		object obj19 = obj17 & obj18;
		bool flag7 = (nint)obj19 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
		bool flag8 = flag5 == flag7;
		object obj20 = !flag6;
		object obj21 = flag8 & obj20;
		object obj22 = ~obj21;
		if (obj22 != null)
		{
			num9 = num5;
		}
		object obj23 = obj16 - obj15;
		double num11 = num9 - num8;
		Vector3 vector = (Vector3)(obj23 * 63);
		double num12 = num11 * 0.5;
		Vector3 center = obj15 + vector;
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Extents = vector;
		double num13 = num8 + num12;
		((Bounds*)(nint)bounds)->m_Center = center;
		return (Bounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nodea);
	}

	private unsafe static Bounds GetEntryBounds(HitboxRoot entry)
	{
		//IL_00d1: Expected VT, but got Obj
		//IL_00a7: Expected VT, but got F4
		//IL_00a2: Expected native int or pointer, but got VT
		//IL_00be: Expected VT, but got F4
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00c3: Expected VT, but got Obj
		if ((object)entry != null)
		{
			float num = entry.BroadRadius * 0.5f;
			float num2 = num - entry.BroadRadius;
			float num3 = num2 - num;
			float num4 = entry.BroadRadius - num3;
			float num5 = num4 * 0.5f;
			float num6 = num3 + num5;
			Bounds bounds = default;
			((Bounds*)(nint)bounds)->m_Center = (Vector3)num6;
			((Bounds*)(nint)bounds)->m_Extents = (Vector3)num5;
			return (Bounds)entry;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Bounds)ex;
	}

	private unsafe static float SAofList(List<HitboxRoot> entries)
	{
		//IL_0010: Expected Obj, but got I
		//IL_065b: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected I4, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Ref
		//IL_099f: Expected I4, but got Obj
		//IL_03db: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got I4
		//IL_0943: Expected I4, but got Obj
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected Ref, but got Unknown
		//IL_0966: Expected Obj, but got I4
		//IL_0260: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0547: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I4
		//IL_05db: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CF4D3]");
		object obj = 0;
		bool flag = (object)entries == null;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		System.__Canon _Canon = (System.__Canon)109899776;
		double num14 = default;
		float result;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE00]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD68]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
			object obj3 = 0;
			bool flag2 = entries._size < 0;
			bool flag3 = entries._size == 0;
			int num2 = entries._size ^ entries._size;
			int num3 = entries._size & num2;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool condition = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			Assert.Check(condition, (string)error);
			System.__Canon _Canon2 = ((List<System.__Canon>)(object)entries).get_Item(0);
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v6+E4]");
			bool flag6 = (nint)0 == 0;
			object obj5 = !flag6;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = _Canon2 == null;
			num = 0;
			_Canon = _Canon2;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v27 (System.__Canon)+6C]");
				double num4 = 0.0 * 0.5;
				double num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v27 (System.__Canon)+6C]");
				double num6 = num5 - 0.0;
				double num7 = num6 - num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v27 (System.__Canon)+6C]");
				double num8 = 0.0 - num7;
				double num9 = num8 * 0.5;
				double num10 = num7 + num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6598]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6590]");
				_Canon = (System.__Canon)0;
				Enumerator<, > enumerator = ((List<System.__Canon>)(object)entries).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				double num11 = num10;
				double num12 = num9;
				double num13 = num9;
				num14 = num10;
				Enumerator<, > val = default;
				obj = (object)(&val);
				num = (int)obj6;
				object obj7;
				object obj8;
				Enumerator<, > val2;
				if (!val.MoveNext())
				{
					obj7 = 0;
					obj8 = 0;
					val2 = (Enumerator<, >)(ref val);
					result = (float)num14;
					object obj9 = 0;
					object obj12 = default;
					while (true)
					{
						num = (int)_Canon;
						((Enumerator<, >*)val2)->Dispose();
						bool flag8 = obj9 == null;
						object obj10 = !flag8;
						if (obj10 == null)
						{
							bool flag9 = obj7 == null;
							object obj11 = !flag9;
							OutOfMemoryException ex = (OutOfMemoryException)val2;
							if (obj11 == null)
							{
								break;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						switch (num)
						{
						case 2:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj7 = 1;
							obj = 1;
							obj9 = obj8;
							break;
						case 1:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj9 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj8 = obj12;
							break;
						default:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A511C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return result;
						}
					}
					object obj13 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v4+E4]");
					bool flag10 = (nint)0 == 0;
					object obj14 = !flag10;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					double num16 = default;
					double num17 = default;
					double num15 = num16 + num17;
					double num18 = num12 + num11;
					double num19 = num11 - num12;
					double num20 = num17 - num16;
					double num21 = num18 - num19;
					double num22 = num15 - num20;
					object obj15 = default;
					double num23 = num21 * (double)obj15;
					double num24 = num21 * num22;
					double num25 = num22 * (double)obj15;
					double num26 = num23 + num24;
					double num27 = num25 + num26;
					return (float)num27 + (float)num27;
				}
				object obj16 = obj3;
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v34+E4]");
				bool flag11 = (nint)0 == 0;
				object obj18 = !flag11;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NullReferenceException ex2 = new NullReferenceException();
				obj7 = 0;
				obj8 = 0;
				val2 = (Enumerator<, >)(ref val);
			}
		}
		result = (float)num14;
		throw new NullReferenceException();
	}

	internal void SplitNode(BVH bvh, List<HitboxRoot> entries)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected I4, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected I4, but got Unknown
		//IL_0165: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I4
		//IL_06dd: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I
		//IL_0695: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I4
		//IL_073c: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_0361: Invalid comparison between F4 and I
		//IL_0580: Expected Obj, but got I4
		//IL_04c5: Invalid comparison between F4 and I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE08]");
		object error = 0;
		bool flag = (object)entries == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE20]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE10]");
		object obj2 = 0;
		object obj3 = entries._size - 1;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = obj3 == null;
		int num = entries._size ^ 1;
		int num2 = entries._size ^ obj3;
		int num3 = num & num2;
		bool flag4 = num3 < 0;
		bool flag5 = flag2 == flag4;
		object obj4 = !flag3;
		bool condition2 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
		Assert.Check(condition2, (string)error2);
		int num4 = entries._size;
		object obj5 = obj;
		bool flag6 = entries._size < 0;
		int num5 = entries._size ^ entries._size;
		int num6 = entries._size & num5;
		bool flag7 = num6 < 0;
		bool flag8 = flag6 == flag7;
		object obj6 = !flag8;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			num4++;
		}
		int num7 = num4 >> 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v7+E4]");
		bool flag9 = (nint)0 == 0;
		object obj8 = !flag9;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v7+A0]");
		object comparer = 0;
		((List<System.__Canon>)(object)entries).Sort((IComparer<System.__Canon>)comparer);
		List<System.__Canon> range = ((List<System.__Canon>)(object)entries).GetRange(0, num7);
		int count = entries._size - num7;
		List<System.__Canon> range2 = ((List<System.__Canon>)(object)entries).GetRange(num7, count);
		float num8 = SAofList((List<HitboxRoot>)(object)range);
		float num9 = SAofList((List<HitboxRoot>)(object)range2);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v11+8]");
		((List<System.__Canon>)(object)entries).Sort((IComparer<System.__Canon>)0);
		List<System.__Canon> range3 = ((List<System.__Canon>)(object)entries).GetRange(0, num7);
		int count2 = entries._size - num7;
		List<System.__Canon> range4 = ((List<System.__Canon>)(object)entries).GetRange(num7, count2);
		float num10 = SAofList((List<HitboxRoot>)(object)range3);
		float num11 = SAofList((List<HitboxRoot>)(object)range4);
		int num12 = range4._size;
		float num13 = num8 * (float)range._size;
		float num14 = num9 * (float)range2._size;
		float num15 = num10 * (float)range3._size;
		float num16 = num11 * (float)range4._size;
		float num17 = num13 + num14;
		float num18 = num15 + num16;
		if (num18 < num17)
		{
			goto IL_03a0;
		}
		bool flag10 = num18 != num17;
		int size = range4._size;
		float num19 = num16;
		List<System.__Canon> entries2 = range2;
		List<System.__Canon> entries3 = range;
		if (!flag10)
		{
			num16 = UnityEngine.Random.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
			num12 = 0;
			float num20 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
			bool flag11 = !(num20 > 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
			size = 0;
			num19 = num16;
			entries2 = range2;
			entries3 = range;
			if (!flag11)
			{
				goto IL_03a0;
			}
		}
		goto IL_0685;
		IL_04f4:
		int num22;
		int num21 = num22;
		float num24;
		float num23 = num24;
		List<System.__Canon> range5;
		entries2 = range5;
		List<System.__Canon> range6;
		entries3 = range6;
		goto IL_0519;
		IL_0519:
		ref BVHNode nextNode = ref bvh.GetNextNode(out System.Runtime.CompilerServices.Unsafe.As<BVHNode, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80)));
		ref BVHNode nextNode2 = ref bvh.GetNextNode(out System.Runtime.CompilerServices.Unsafe.As<BVHNode, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 84)));
		object obj12;
		object obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj13 = !flag12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int curDepth = Depth + 1;
		InitNode(ref nextNode, bvh, _leftIndex, _nodeIndex, curDepth, (List<HitboxRoot>)(object)entries3);
		int curDepth2 = Depth + 1;
		InitNode(ref nextNode2, bvh, _rightIndex, _nodeIndex, curDepth2, (List<HitboxRoot>)(object)entries2);
		_isLeaf = false;
		Active = true;
		return;
		IL_0685:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		obj12 = 0;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v24+E4]");
		bool flag13 = (nint)0 == 0;
		object obj15 = !flag13;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v24+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v15+10]");
		((List<System.__Canon>)(object)entries).Sort((IComparer<System.__Canon>)0);
		range6 = ((List<System.__Canon>)(object)entries).GetRange(0, num7);
		int count3 = entries._size - num7;
		range5 = ((List<System.__Canon>)(object)entries).GetRange(num7, count3);
		float num25 = SAofList((List<HitboxRoot>)(object)range6);
		float num26 = SAofList((List<HitboxRoot>)(object)range5);
		num22 = range5._size;
		float num27 = num25 * (float)range6._size;
		float num28 = num26 * (float)range5._size;
		num24 = num27 + num28;
		if (num24 < num17)
		{
			goto IL_04f4;
		}
		bool flag14 = num24 != num17;
		num21 = range5._size;
		num23 = num24;
		if (!flag14)
		{
			num24 = UnityEngine.Random.value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
			num22 = 0;
			float num29 = num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
			bool flag15 = !(num29 > 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9DC]");
			num21 = 0;
			num23 = num24;
			if (!flag15)
			{
				goto IL_04f4;
			}
		}
		goto IL_0519;
		IL_03a0:
		size = num12;
		num17 = num18;
		num19 = num16;
		entries2 = range4;
		entries3 = range3;
		goto IL_0685;
	}

	private static void AddObjectPushdown(BVH bvh, ref BVHNode curNode, HitboxRoot entry)
	{
		//IL_0010: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got I
		//IL_0243: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I
		//IL_04d4: Expected Obj, but got I4
		//IL_03cf: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+4C]");
				bool flag2 = (nint)0 < (nint)nodes.Length;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					goto IL_044b;
				}
				List<System.__Canon> reusableList = (List<System.__Canon>)(object)bvh.ReusableList;
				if ((object)bvh.ReusableList != null)
				{
					object obj5 = bvh._nodes + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+4C]");
					object obj6 = (nint)0 * (nint)120;
					object obj7 = obj5 + obj6;
					int size = reusableList._size;
					object obj8 = obj7 + 84;
					int version = reusableList._version + 1;
					reusableList._size = 0;
					reusableList._version = version;
					if (reusableList._size >= 1)
					{
						Array.Clear(reusableList._items, 0, reusableList._size);
						reusableList = (List<System.__Canon>)(object)bvh.ReusableList;
						if ((object)bvh.ReusableList == null)
						{
							goto IL_043d;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69E8]");
					object obj9 = 0;
					System.__Canon[] items = reusableList._items;
					object obj10 = obj9;
					int version2 = reusableList._version + 1;
					reusableList._version = version2;
					if (reusableList._items != null)
					{
						bool flag3 = reusableList._size < items.Length;
						object obj11 = !flag3;
						if (obj11 == null)
						{
							object obj12 = reusableList._items + reusableList._size;
							int size2 = reusableList._size + 1;
							reusableList._size = size2;
							object obj13 = obj12 + 32;
							obj13 = entry;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v7+20]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v20+A8]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v21+70]");
							size = 0;
							reusableList.AddWithResize((System.__Canon)(object)entry);
						}
						ref BVHNode nextNode = ref bvh.GetNextNode(out var index);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+4C]");
						object obj16 = (nint)0 * (nint)120;
						object obj17 = obj5 + obj16;
						int index2 = index;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v12+48]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+5C]");
						InitNode(ref nextNode, bvh, index2, (int)num, 0);
						ref BVHNode nextNode2 = ref bvh.GetNextNode(out var index3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v12 (Fusion.LagCompensation.BVHNode&)+5C]");
						int curDepth = (int)((nint)0 + (nint)1);
						InitNode(ref nextNode2, bvh, index3, index, curDepth, bvh.ReusableList);
						object obj18 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+48]");
						if (obj18 == null)
						{
							obj8 = index;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+4C]");
							object obj19 = (nint)0 * (nint)120;
							object obj20 = obj5 + obj19;
						}
						object obj21 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v12 (Fusion.LagCompensation.BVHNode&)+5C]");
						object obj22 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v15+E4]");
						bool flag4 = (nint)0 == 0;
						object obj23 = !flag4;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [curNode @ X1 (Fusion.LagCompensation.BVHNode&)+48]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v14 (Fusion.LagCompensation.BVHNode&)+48]");
						_ = 0;
						ChildRefit(bvh, index, propagate: true);
						return;
					}
				}
			}
		}
		goto IL_043d;
		IL_043d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_044b;
		IL_044b:
		throw new IndexOutOfRangeException();
	}

	internal unsafe static void Add(BVH bvh, ref BVHNode startNode, HitboxRoot entry, ref Bounds newObBox, float newObSah)
	{
		//IL_0e79: Expected Obj, but got I
		//IL_0e89: Expected Obj, but got I
		//IL_0ee5: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_1914: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_0f42: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_06c9: Expected Obj, but got I4
		//IL_0722: Expected Obj, but got I4
		//IL_0755: Expected Obj, but got I
		//IL_077a: Expected Obj, but got I
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_0f60: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I4
		//IL_08e5: Expected Obj, but got I
		//IL_0d33: Expected Obj, but got I
		//IL_0965: Expected Obj, but got I4
		//IL_033b: Expected Obj, but got I4
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected Obj, but got Unknown
		//IL_036c: Expected Obj, but got I4
		//IL_1888: Expected Obj, but got I
		//IL_18a7: Expected Obj, but got I
		//IL_0c20: Expected Obj, but got I4
		//IL_0a28: Expected Obj, but got I
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_051b: Expected Obj, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_0e14: Expected I, but got Obj
		//IL_0fb3: Invalid comparison between F8 and I4
		//IL_0fc2: Invalid comparison between F8 and I4
		//IL_0fd5: Expected Obj, but got F8
		//IL_0fe2: Expected Obj, but got F8
		//IL_1033: Expected Obj, but got I4
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected Obj, but got Unknown
		//IL_0aa1: Expected Obj, but got I
		//IL_0afe: Expected Obj, but got I
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Expected Obj, but got Unknown
		//IL_109d: Expected Obj, but got I
		//IL_10b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Expected Obj, but got Unknown
		//IL_1169: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected Obj, but got Unknown
		//IL_0b2c: Expected Obj, but got I4
		//IL_0bb7: Expected Obj, but got I
		//IL_0bc7: Expected Obj, but got I
		//IL_0bf1: Expected Obj, but got I
		//IL_1279: Invalid comparison between F8 and I4
		//IL_1288: Invalid comparison between F8 and I4
		//IL_129b: Expected Obj, but got F8
		//IL_12a8: Expected Obj, but got F8
		//IL_1315: Expected Obj, but got I4
		//IL_131d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1322: Expected Obj, but got Unknown
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected Obj, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0b8f: Expected Obj, but got I
		//IL_139b: Invalid comparison between F8 and I4
		//IL_13aa: Invalid comparison between F8 and I4
		//IL_13bd: Expected Obj, but got F8
		//IL_13ca: Expected Obj, but got F8
		//IL_1413: Expected Obj, but got I4
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420: Expected Obj, but got Unknown
		//IL_147b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1480: Expected Obj, but got Unknown
		//IL_159c: Invalid comparison between F8 and I4
		//IL_15ab: Invalid comparison between F8 and I4
		//IL_15be: Expected Obj, but got F8
		//IL_15cb: Expected Obj, but got F8
		//IL_160f: Expected Obj, but got I4
		//IL_1617: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Expected Obj, but got Unknown
		//IL_1668: Unknown result type (might be due to invalid IL or missing references)
		//IL_166d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj2 = 0;
		bool condition;
		if ((object)entry != null)
		{
			object obj3 = entry.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag = obj3 == null;
			condition = flag;
		}
		else
		{
			condition = false;
		}
		string text = (string)obj;
		Assert.Check(condition, (string)obj);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+50]");
		ref BVHNode curNode;
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+54]");
			bool flag4 = (nint)0 > (nint)0;
			curNode = ref startNode;
			if (flag4)
			{
				goto IL_0f18;
			}
			obj4 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+48]");
		bool flag6 = (nint)0 != 1;
		curNode = ref startNode;
		if (!flag6)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v7+E4]");
			bool flag7 = (nint)0 == 0;
			object obj9 = !flag7;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+50]");
			bool condition2;
			if ((nint)0 > (nint)0)
			{
				condition2 = false;
			}
			else
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v26+E4]");
				bool flag8 = (nint)0 == 0;
				object obj11 = !flag8;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+54]");
				object obj12 = -1;
				bool flag9 = (nint)obj12 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+54]");
				object obj13 = (nint)0 ^ (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+54]");
				object obj14 = 0 ^ obj12;
				object obj15 = obj13 & obj14;
				bool flag10 = (nint)obj15 < 0;
				bool flag11 = flag9 == flag10;
				bool flag12 = !flag11;
				condition2 = flag12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACF0]");
			object obj16 = 0;
			text = (string)obj16;
			Assert.Check(condition2, (string)obj16);
			bool flag13 = (object)bvh == null;
			int num = 0;
			if (!flag13)
			{
				List<System.__Canon> reusableList = (List<System.__Canon>)(object)bvh.ReusableList;
				bool flag14 = (object)bvh.ReusableList == null;
				num = 0;
				if (!flag14)
				{
					num = reusableList._size;
					int version = reusableList._version + 1;
					reusableList._size = 0;
					reusableList._version = version;
					bool flag15 = reusableList._size < 1;
					ref Bounds reference2 = default;
					ref Bounds reference = ref reference2;
					string text2 = (string)obj16;
					if (!flag15)
					{
						Array.Clear(reusableList._items, 0, reusableList._size);
						reusableList = (List<System.__Canon>)(object)bvh.ReusableList;
						bool flag16 = (object)bvh.ReusableList == null;
						reference = ref *(Bounds*)null;
						text2 = null;
						reference2 = ref *(Bounds*)null;
						text = null;
						if (flag16)
						{
							goto IL_0c6a;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69E8]");
					object obj17 = 0;
					System.__Canon[] items = reusableList._items;
					int version2 = reusableList._version + 1;
					reusableList._version = version2;
					bool flag17 = reusableList._items == null;
					reference2 = ref reference;
					text = text2;
					if (!flag17)
					{
						bool flag18 = reusableList._size < items.Length;
						object obj18 = !flag18;
						if (obj18 == null)
						{
							object obj19 = reusableList._items + reusableList._size;
							int size = reusableList._size + 1;
							reusableList._size = size;
							object obj20 = obj19 + 32;
							obj20 = entry;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							reusableList.AddWithResize((System.__Canon)(object)entry);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+68]");
						bool flag19 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+68]");
						if ((int)(~(nint)0) == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X9_v5 (System.Boolean)+30]");
							object obj21 = (nint)0 & (nint)8;
							bool flag20 = obj21 == null;
							flag19 = flag20;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+70]");
						object obj22 = -(flag19 ? 1 : 0);
						bool condition3 = obj22 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACF8]");
						object obj23 = 0;
						text = (string)obj23;
						Assert.Check(condition3, (string)obj23);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+70]");
						bool flag21 = (nint)0 == 0;
						int num2 = 0;
						System.__Canon _Canon = (System.__Canon)obj23;
						if (flag21)
						{
							goto IL_0bf6;
						}
						List<System.__Canon> reusableList2 = (List<System.__Canon>)(object)bvh.ReusableList;
						bool flag22 = (object)bvh.ReusableList == null;
						reference2 = ref reference;
						num = 0;
						if (!flag22)
						{
							System.__Canon[] items2 = reusableList2._items;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+68]");
							_Canon = (System.__Canon)0;
							object obj24 = obj17;
							int version3 = reusableList2._version + 1;
							reusableList2._version = version3;
							bool flag23 = reusableList2._items == null;
							reference2 = ref reference;
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+68]");
							text = (string)0;
							if (!flag23)
							{
								bool flag24 = reusableList2._size < items2.Length;
								object obj25 = !flag24;
								if (obj25 == null)
								{
									object obj26 = reusableList2._items + reusableList2._size;
									int size2 = reusableList2._size + 1;
									reusableList2._size = size2;
									object obj27 = obj26 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+68]");
									obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									num2 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X9_v7+20]");
									object obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X8_v24+A8]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X8_v25+70]");
									num2 = 0;
									List<HitboxRoot> reusableList3 = bvh.ReusableList;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+68]");
									((List<System.__Canon>)(object)reusableList3).AddWithResize((System.__Canon)0);
								}
								goto IL_0bf6;
							}
						}
					}
				}
			}
			goto IL_0c6a;
		}
		goto IL_0f18;
		IL_0f18:
		object obj69 = default;
		object obj74 = default;
		object obj115 = default;
		object obj116 = default;
		StringBuilder stringBuilder = default;
		string format = default;
		object[] args = default;
		InvalidOperationException ex = default;
		string message = default;
		while (true)
		{
			object obj30 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v34+E4]");
			bool flag25 = (nint)0 == 0;
			object obj31 = !flag25;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj32 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+70]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v36+E4]");
				bool flag26 = (nint)0 == 0;
				object obj33 = !flag26;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+50]");
				bool flag27 = (nint)0 < (nint)1;
				int num = 0;
				if (!flag27)
				{
					object obj34 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v41+E4]");
					bool flag28 = (nint)0 == 0;
					object obj35 = !flag28;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+54]");
					bool flag29 = (nint)0 <= (nint)0;
					num = 0;
					if (!flag29)
					{
						object obj36 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v43+E4]");
						bool flag30 = (nint)0 == 0;
						object obj37 = !flag30;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag31 = (object)bvh == null;
						num = 0;
						if (flag31)
						{
							break;
						}
						BVHNode[] nodes = bvh._nodes;
						bool flag32 = bvh._nodes == null;
						num = 0;
						if (flag32)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+50]");
						bool flag33 = (nint)0 < (nint)nodes.Length;
						object obj38 = !flag33;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+54]");
							bool flag34 = (nint)0 < (nint)nodes.Length;
							object obj39 = !flag34;
							if (obj39 == null)
							{
								object obj40 = bvh._nodes + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+50]");
								object obj41 = (nint)0 * (nint)120;
								ref BVHNode reference3 = ref *(BVHNode*)(obj40 + obj41);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v3 (Fusion.LagCompensation.BVHNode&)+54]");
								object obj42 = (nint)0 * (nint)120;
								ref BVHNode reference4 = ref *(BVHNode*)(obj40 + obj42);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Fusion.LagCompensation.BVHNode&)+8]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Fusion.LagCompensation.BVHNode&)+14]");
								object obj43 = num3 - 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Fusion.LagCompensation.BVHNode&)+8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Fusion.LagCompensation.BVHNode&)+14]");
								object obj44 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X3_v6 (UnityEngine.Bounds&)+8]");
								double num5 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X3_v6 (UnityEngine.Bounds&)+14]");
								double num6 = num5 - 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X3_v6 (UnityEngine.Bounds&)+8]");
								double num7 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X3_v6 (UnityEngine.Bounds&)+14]");
								double num8 = num7 + 0.0;
								object obj45 = 0 - obj43;
								double num9 = (double)obj45 * 0.5;
								double num10 = (double)obj43 + num9;
								object obj46 = obj44 - obj43;
								double num11 = num10 - num9;
								BVHNode bVHNode = reference4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15 (Fusion.LagCompensation.BVHNode&)+C]");
								object obj47 = bVHNode - 0;
								double num12 = (double)obj44 - num11;
								double num13 = num12 * 0.5;
								BVHNode bVHNode2 = reference3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Fusion.LagCompensation.BVHNode&)+C]");
								object obj48 = bVHNode2 - 0;
								double num14 = num11 + num13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15 (Fusion.LagCompensation.BVHNode&)+8]");
								nint num15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15 (Fusion.LagCompensation.BVHNode&)+14]");
								object obj49 = num15 - 0;
								double num16 = num14 - num13;
								double num17 = num13 + num14;
								object obj50 = 0 - obj49;
								object obj51 = 0 - obj47;
								double num18 = (double)obj50 * 0.5;
								object obj52 = obj51 * 63;
								if (!(num16 < num6))
								{
									num16 = num6;
								}
								double num19 = num17 - num6;
								bool flag35 = num19 < 0.0;
								bool flag36 = num19 == 0.0;
								object obj53 = num17 ^ num6;
								object obj54 = num17 ^ num19;
								object obj55 = obj53 & obj54;
								bool flag37 = (nint)obj55 < 0;
								double num20 = (double)obj49 + num18;
								object obj56 = obj47 + obj52;
								bool flag38 = flag35 == flag37;
								object obj57 = !flag36;
								object obj58 = flag38 & obj57;
								object obj59 = ~obj58;
								double num21 = ((obj59 != null) ? num6 : num17);
								BVHNode bVHNode3 = reference3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v42 (Fusion.LagCompensation.BVHNode&)+C]");
								object obj60 = bVHNode3 + 0;
								double num22 = num21 - num16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15 (Fusion.LagCompensation.BVHNode&)+8]");
								nint num23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15 (Fusion.LagCompensation.BVHNode&)+14]");
								object obj61 = num23 + 0;
								BVHNode bVHNode4 = reference4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v15 (Fusion.LagCompensation.BVHNode&)+C]");
								object obj62 = bVHNode4 + 0;
								double num24 = num20 - num18;
								object obj63 = obj56 - obj52;
								object obj64 = obj60 - obj48;
								double num25 = num22 * 0.5;
								object obj65 = obj61 - obj49;
								object obj66 = obj62 - obj63;
								double num26 = (double)obj61 - num24;
								object obj67 = obj62 - obj47;
								object obj68 = obj64 * obj69;
								object obj70 = obj46 * obj64;
								object obj71 = obj46 * obj69;
								double num27 = num16 + num25;
								object obj72 = obj66 * 63;
								double num28 = num26 * 0.5;
								object obj73 = obj67 * obj74;
								object obj75 = obj65 * obj67;
								object obj76 = obj68 + obj70;
								object obj77 = obj65 * obj74;
								double num29 = num27 - num25;
								double num30 = num25 + num27;
								object obj78 = obj63 + obj72;
								double num31 = num24 + num28;
								object obj79 = obj73 + obj75;
								object obj80 = obj71 + obj76;
								double num32 = num31 - num28;
								object obj81 = obj78 - obj72;
								object obj82 = obj72 + obj78;
								double num33 = num28 + num31;
								if (!(num29 < num8))
								{
									num29 = num8;
								}
								double num34 = num30 - num8;
								bool flag39 = num34 < 0.0;
								bool flag40 = num34 == 0.0;
								object obj83 = num30 ^ num8;
								object obj84 = num30 ^ num34;
								object obj85 = obj83 & obj84;
								bool flag41 = (nint)obj85 < 0;
								object obj86 = obj77 + obj79;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								object obj87 = obj80 + obj80;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								bool flag42 = flag39 == flag41;
								object obj88 = !flag40;
								object obj89 = flag42 & obj88;
								object obj90 = ~obj89;
								if (obj90 != null)
								{
									num30 = num8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								object obj91 = obj86 + obj86;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
								double num35 = ((!(num32 < num6)) ? num6 : num32);
								double num36 = num33 - num6;
								bool flag43 = num36 < 0.0;
								bool flag44 = num36 == 0.0;
								object obj92 = num33 ^ num6;
								object obj93 = num33 ^ num36;
								object obj94 = obj92 & obj93;
								bool flag45 = (nint)obj94 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								bool flag46 = flag43 == flag45;
								object obj95 = !flag44;
								object obj96 = flag46 & obj95;
								object obj97 = ~obj96;
								if (obj97 == null)
								{
									num6 = num33;
								}
								double num37 = num31 - (double)obj78;
								object obj98 = obj82 - obj81;
								double num38 = num6 - num35;
								double num39 = num37 * 63.0;
								object obj99 = obj98 * 63;
								double num40 = num38 * 0.5;
								double num41 = (double)obj78 + num39;
								object obj100 = obj81 + obj99;
								double num42 = num35 + num40;
								double num43 = num41 - num39;
								double num44 = num39 + num41;
								object obj101 = obj100 - obj99;
								object obj102 = obj99 + obj100;
								double num45 = num42 - num40;
								double num46 = num40 + num42;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
								if (!(num45 < num8))
								{
									num45 = num8;
								}
								double num47 = num46 - num8;
								bool flag47 = num47 < 0.0;
								bool flag48 = num47 == 0.0;
								object obj103 = num46 ^ num8;
								object obj104 = num46 ^ num47;
								object obj105 = obj103 & obj104;
								bool flag49 = (nint)obj105 < 0;
								double num48 = num44 - num43;
								bool flag50 = flag47 == flag49;
								object obj106 = !flag48;
								object obj107 = flag50 & obj106;
								object obj108 = ~obj107;
								if (obj108 != null)
								{
									num46 = num8;
								}
								object obj109 = obj102 - obj101;
								double num49 = num30 - num29;
								double num50 = num48 * 63.0;
								object obj110 = obj109 * 63;
								double num51 = num46 - num45;
								double num52 = num49 * 0.5;
								double num53 = num43 + num50;
								double num54 = num51 * 0.5;
								object obj111 = obj101 + obj110;
								double num55 = num29 + num52;
								double num56 = num50 + num53;
								double num57 = num53 - num50;
								double num58 = num45 + num54;
								object obj112 = obj110 + obj111;
								object obj113 = obj111 - obj110;
								double num59 = num52 + num55;
								double num60 = num55 - num52;
								double num61 = num56 - num57;
								double num62 = num54 + num58;
								double num63 = num58 - num54;
								object obj114 = obj112 - obj113;
								double num64 = num59 - num60;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								double num65 = num62 - num63;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								double num66 = num64 * num61;
								double num67 = num65 * (double)obj114;
								double num68 = num61 * num60;
								double num69 = (double)obj114 * num58;
								double num70 = num68 + num66;
								double num71 = num69 + num67;
								double num72 = (double)obj115 + num70;
								double num73 = (double)obj116 + num71;
								double num74 = num72 + num72;
								double num75 = num73 + num73;
								double num76 = (double)obj91 + num74;
								float num77 = (float)obj87 + (float)num75;
								if (num76 < (double)num77)
								{
									object obj117 = obj116;
									object obj118 = obj115;
									curNode = ref reference3;
								}
								else
								{
									object obj117 = obj116;
									object obj118 = obj115;
									curNode = ref reference4;
								}
								continue;
							}
						}
						goto IL_0e62;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				stringBuilder._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj119 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string value = string.Format(format, args);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				bvh.BuildNodesLog(stringBuilder);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				nint num78 = (nint)stringBuilder;
				((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				goto IL_0e62;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v36+E4]");
			bool flag51 = (nint)0 == 0;
			object obj120 = !flag51;
			if (obj120 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AddObjectPushdown(bvh, ref curNode, entry);
			return;
			IL_0e62:
			throw new IndexOutOfRangeException();
		}
		goto IL_0c6a;
		IL_0bf6:
		object obj121 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v15+E4]");
		bool flag52 = (nint)0 == 0;
		object obj122 = !flag52;
		if (obj122 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startNode @ X1 (Fusion.LagCompensation.BVHNode&)+48]");
		InitNode(ref startNode, bvh, 0, 0, 0, bvh.ReusableList);
		return;
		IL_0c6a:
		throw new NullReferenceException();
	}

	internal unsafe int NodesCount(BVH bvh)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0019: Expected Obj, but got I4
		//IL_001e: Expected VT, but got Ref
		//IL_007d: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected I4, but got Unknown
		//IL_0229: Expected I4, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected VT, but got Unknown
		//IL_0154: Expected Ref, but got VT
		//IL_01a7: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		object obj2 = 0;
		BVHNode bVHNode = (BVHNode)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		BVH bVH = default;
		while (true)
		{
			HitboxRoot root = bVHNode._root;
			if ((object)bVHNode._root != null)
			{
				object obj3 = root.Flags & (SimulationBehaviourRuntimeFlags)8;
				if (obj3 == null)
				{
					return obj2 + 1;
				}
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)bVH != null)
			{
				BVHNode[] nodes = bVH._nodes;
				if (bVH._nodes != null)
				{
					bool flag2 = bVHNode._leftIndex < nodes.Length;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = bVHNode._leftIndex * 120;
					object obj8 = (object)bVH._nodes + obj7;
					BVHNode bVHNode2 = (BVHNode)(obj8 + 32);
					int num = ((BVHNode*)bVHNode2)->NodesCount(bVH);
					BVHNode[] nodes2 = bVH._nodes;
					if (bVH._nodes != null)
					{
						bool flag3 = bVHNode._rightIndex < nodes2.Length;
						object obj9 = !flag3;
						if (obj9 != null)
						{
							break;
						}
						object obj10 = bVHNode._rightIndex * 120;
						object obj11 = (object)bVH._nodes + obj10;
						obj2 = num + obj2;
						bVHNode = (BVHNode)(obj11 + 32);
						continue;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	internal unsafe void Remove(BVH bvh, HitboxRoot entry)
	{
		//IL_0010: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected I4, but got Unknown
		//IL_0370: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Ref, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected VT, but got Unknown
		//IL_03c1: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = _root;
		bool flag3 = !flag2;
		string text = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD28]");
			object obj4 = 0;
			HitboxRoot hitboxRoot = default;
			object obj5 = (object)_root - (object)hitboxRoot;
			bool condition = obj5 == null;
			text = (string)obj4;
			Assert.Check(condition, (string)obj4);
			bool flag4 = (object)bvh == null;
			HitboxRoot hitboxRoot2 = null;
			if (!flag4)
			{
				Mapper mapper = bvh.Mapper;
				bool flag5 = bvh.Mapper == null;
				hitboxRoot2 = null;
				if (!flag5)
				{
					bool flag6 = (object)mapper._rootToNodeIndex == null;
					hitboxRoot2 = null;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD30]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
						object obj7 = 0;
						hitboxRoot2 = (HitboxRoot)obj6;
						bool flag7 = ((Dictionary<System.__Canon, int>)(object)mapper._rootToNodeIndex).Remove((System.__Canon)(object)hitboxRoot);
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v28+E4]");
						bool flag8 = (nint)0 == 0;
						object obj9 = !flag8;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (_nodeIndex == 1)
						{
							bool flag9 = bvh._nodes == null;
							text = (string)(object)hitboxRoot;
							if (!flag9)
							{
								object obj10 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v35+E4]");
								bool flag10 = (nint)0 == 0;
								object obj11 = !flag10;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								InitNode(ref *(BVHNode*)(bvh._nodes + 152), bvh, 1, 0, 0);
								return;
							}
						}
						else
						{
							object obj12 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v30+E4]");
							bool flag11 = (nint)0 == 0;
							object obj13 = !flag11;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD20]");
							object obj14 = 0;
							bool flag12 = _parentIndex < 0;
							bool flag13 = _parentIndex == 0;
							int num = _parentIndex ^ _parentIndex;
							int num2 = _parentIndex & num;
							bool flag14 = num2 < 0;
							text = (string)obj14;
							bool flag15 = flag12 == flag14;
							object obj15 = !flag13;
							bool condition2 = (byte)((flag15 & obj15) ? 1 : 0) != 0;
							Assert.Check(condition2, (string)obj14);
							BVHNode[] nodes = bvh._nodes;
							bool flag16 = bvh._nodes == null;
							hitboxRoot2 = null;
							if (!flag16)
							{
								bool flag17 = _parentIndex < nodes.Length;
								object obj16 = !flag17;
								if (obj16 == null)
								{
									object obj17 = _parentIndex * 120;
									object obj18 = (object)bvh._nodes + obj17;
									BVHNode bVHNode = (BVHNode)(obj18 + 32);
									((BVHNode*)bVHNode)->RemoveLeaf(bvh, _nodeIndex);
									return;
								}
								goto IL_041a;
							}
						}
					}
				}
			}
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Exception ex = default;
		string message = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_041a;
		IL_041a:
		throw new IndexOutOfRangeException();
	}

	private unsafe void SetDepth(BVH bvh, int newdepth)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001d: Expected VT, but got Ref
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02ff: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected VT, but got Unknown
		//IL_0165: Expected Ref, but got VT
		//IL_0262: Expected Obj, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		BVH bVH = bvh;
		BVHNode bVHNode = (BVHNode)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		int num2 = default;
		int num = num2;
		while (true)
		{
			((BVHNode*)(nint)bVHNode)->Depth = num;
			if ((object)bvh != null)
			{
				if (bvh.maxDepth < num)
				{
					bvh.maxDepth = num;
				}
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				if (bVHNode._leftIndex >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					BVHNode[] nodes = bvh._nodes;
					if (bvh._nodes == null)
					{
						goto IL_0296;
					}
					bool flag3 = bVHNode._leftIndex < nodes.Length;
					object obj5 = !flag3;
					if (obj5 != null)
					{
						break;
					}
					object obj6 = bVHNode._leftIndex * 120;
					object obj7 = (object)bvh._nodes + obj6;
					num2 = num + 1;
					BVHNode bVHNode2 = (BVHNode)(obj7 + 32);
					((BVHNode*)bVHNode2)->SetDepth(bvh, num2);
					obj2 = obj;
					bVH = bvh;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (bVHNode._rightIndex < 1)
				{
					return;
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				BVHNode[] nodes2 = bvh._nodes;
				if (bvh._nodes != null)
				{
					bool flag6 = bVHNode._rightIndex < nodes2.Length;
					object obj11 = !flag6;
					if (obj11 != null)
					{
						break;
					}
					object obj12 = bVHNode._rightIndex * 120;
					object obj13 = (object)bvh._nodes + obj12;
					num++;
					bVHNode = (BVHNode)(obj13 + 32);
					continue;
				}
			}
			goto IL_0296;
			IL_0296:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void RemoveLeaf(BVH bvh, int removeIndex)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c47: Expected Obj, but got I
		//IL_0c69: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I4
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Expected Obj, but got Unknown
		//IL_0cab: Expected VT, but got Obj
		//IL_0cbb: Expected Obj, but got I
		//IL_0cf2: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got Ref
		//IL_07eb: Expected Obj, but got I4
		//IL_0818: Expected Obj, but got I
		//IL_088a: Expected Obj, but got I4
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected I4, but got Unknown
		//IL_0393: Expected Obj, but got Ref
		//IL_03e9: Expected Obj, but got I4
		//IL_08f9: Expected Obj, but got I4
		//IL_0ec3: Expected Obj, but got I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected Obj, but got Unknown
		//IL_093b: Expected Obj, but got I4
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_0430: Expected Obj, but got I4
		//IL_09ad: Expected Obj, but got I4
		//IL_0de0: Expected Obj, but got I4
		//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Expected Obj, but got Unknown
		//IL_0790: Expected Obj, but got I4
		//IL_0588: Expected Obj, but got I4
		//IL_0d8b: Expected Obj, but got I
		//IL_0dc2: Expected Obj, but got I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_04a7: Expected Obj, but got I4
		//IL_0bca: Expected I4, but got Obj
		//IL_0a88: Expected Obj, but got I4
		//IL_05f1: Expected Obj, but got I4
		//IL_04d3: Expected Obj, but got I4
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected VT, but got Unknown
		//IL_051b: Expected Ref, but got VT
		//IL_0ab5: Expected Obj, but got I4
		//IL_0a2a: Expected Obj, but got I4
		//IL_0e48: Expected Obj, but got I4
		//IL_0a61: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I4
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected VT, but got Unknown
		//IL_0657: Expected Ref, but got VT
		//IL_0f28: Expected Obj, but got I
		//IL_0f41: Expected Obj, but got I4
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected I4, but got Unknown
		//IL_0f78: Expected native int or pointer, but got VT
		//IL_0f8e: Expected Ref, but got VT
		//IL_0f9e: Expected Obj, but got I
		//IL_101f: Expected Obj, but got I4
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Expected I4, but got Unknown
		//IL_06c9: Expected Obj, but got I
		//IL_06d1: Expected I4, but got Obj
		//IL_0b52: Expected Obj, but got I4
		//IL_0737: Expected Obj, but got I
		//IL_074f: Expected I4, but got Obj
		//IL_0757: Expected I4, but got Obj
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected Obj, but got Unknown
		//IL_0e93: Expected Obj, but got I4
		//IL_0b90: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = (string)obj3;
		bool condition = !_isLeaf;
		Assert.Check(condition, (string)obj3);
		int num2;
		int num3;
		object obj9;
		object obj10;
		if (_leftIndex == removeIndex)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v102+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = (object)bvh == null;
			int num = 0;
			if (!flag3)
			{
				BVHNode[] nodes = bvh._nodes;
				bool flag4 = bvh._nodes == null;
				num = 0;
				if (!flag4)
				{
					num2 = _leftIndex;
					bool flag5 = _leftIndex < nodes.Length;
					object obj7 = !flag5;
					num = 0;
					if (obj7 == null)
					{
						num3 = _rightIndex;
						bool flag6 = _rightIndex < nodes.Length;
						object obj8 = !flag6;
						num = 0;
						if (obj8 == null)
						{
							obj9 = bvh._nodes + 32;
							_leftIndex = 0;
							obj10 = 120;
							goto IL_0c77;
						}
					}
					goto IL_0bd9;
				}
			}
		}
		else
		{
			bool flag7 = _rightIndex != removeIndex;
			int num = 0;
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Exception ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v99+E4]");
			bool flag8 = (nint)0 == 0;
			object obj12 = !flag8;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag9 = (object)bvh == null;
			num = 0;
			if (!flag9)
			{
				BVHNode[] nodes2 = bvh._nodes;
				bool flag10 = bvh._nodes == null;
				num = 0;
				if (!flag10)
				{
					num2 = _rightIndex;
					bool flag11 = _rightIndex < nodes2.Length;
					object obj13 = !flag11;
					num = 0;
					if (obj13 == null)
					{
						num3 = _leftIndex;
						bool flag12 = _leftIndex < nodes2.Length;
						object obj14 = !flag12;
						num = 0;
						if (obj14 == null)
						{
							obj9 = bvh._nodes + 32;
							_rightIndex = 0;
							obj10 = 120;
							goto IL_0c77;
						}
					}
					goto IL_0bd9;
				}
			}
		}
		goto IL_0bcb;
		IL_0bbd:
		object obj15;
		bvh.DisposeNode((int)obj15);
		return;
		IL_0c77:
		object obj16 = num2 * obj10;
		object obj17 = obj9 + obj16;
		object obj18 = num3 * obj10;
		BVHNode bVHNode = (BVHNode)(obj9 + obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE40]");
		object error = 0;
		bvh.DisposeNode(removeIndex);
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v7+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X24_v1+70]");
		Assert.Check(condition: false, (string)error);
		obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 72));
		if ((nint)obj15 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
			object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 104));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj22 = obj;
			Depth = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B968]");
			_nodeIndex = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v51+E4]");
			bool flag14 = (nint)0 == 0;
			object obj23 = !flag14;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj;
			}
			bool flag15 = _leftIndex < 1;
			int num = 120;
			text = null;
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v51+E4]");
				bool flag16 = (nint)0 == 0;
				object obj24 = !flag16;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				BVHNode[] nodes3 = bvh._nodes;
				bool flag17 = bvh._nodes == null;
				num = 120;
				text = null;
				if (flag17)
				{
					goto IL_0bcb;
				}
				bool flag18 = _leftIndex < nodes3.Length;
				object obj25 = !flag18;
				num = 120;
				text = null;
				if (obj25 != null)
				{
					goto IL_0bd9;
				}
				object obj26 = _leftIndex * 120;
				object obj27 = (object)bvh._nodes + obj26;
				num = Depth + 1;
				BVHNode bVHNode2 = (BVHNode)(obj27 + 32);
				_ = _nodeIndex;
				((BVHNode*)bVHNode2)->SetDepth(bvh, num);
				obj22 = obj;
				text = (string)(object)bvh;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v51+E4]");
			bool flag19 = (nint)0 == 0;
			object obj28 = !flag19;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (_rightIndex >= 1)
			{
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v69+E4]");
				bool flag20 = (nint)0 == 0;
				object obj30 = !flag20;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				BVHNode[] nodes4 = bvh._nodes;
				if (bvh._nodes == null)
				{
					goto IL_0bcb;
				}
				bool flag21 = _rightIndex < nodes4.Length;
				object obj31 = !flag21;
				if (obj31 != null)
				{
					goto IL_0bd9;
				}
				object obj32 = _rightIndex * 120;
				object obj33 = (object)bvh._nodes + obj32;
				num = Depth + 1;
				BVHNode bVHNode3 = (BVHNode)(obj33 + 32);
				_ = _nodeIndex;
				((BVHNode*)bVHNode3)->SetDepth(bvh, num);
				text = (string)(object)bvh;
			}
			bool flag22 = (byte)(~(_isLeaf ? 1u : 0u)) != 0;
			System.__Canon _Canon = (System.__Canon)(object)text;
			if (flag22)
			{
				goto IL_0766;
			}
			Mapper mapper = bvh.Mapper;
			if (bvh.Mapper != null && (object)mapper._rootToNodeIndex != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD30]");
				object obj34 = 0;
				num = (int)obj34;
				bool flag23 = ((Dictionary<System.__Canon, int>)(object)mapper._rootToNodeIndex).Remove((System.__Canon)(object)_root);
				Mapper mapper2 = bvh.Mapper;
				bool flag24 = bvh.Mapper == null;
				text = (string)(object)_root;
				if (!flag24)
				{
					bool flag25 = (object)mapper2._rootToNodeIndex == null;
					text = (string)(object)_root;
					if (!flag25)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD78]");
						object obj35 = 0;
						((Dictionary<System.__Canon, int>)(object)mapper2._rootToNodeIndex).set_Item((System.__Canon)(object)_root, (int)obj15);
						num = (int)obj15;
						_Canon = (System.__Canon)(object)_root;
						goto IL_0766;
					}
				}
			}
		}
		else
		{
			object obj36 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v12+E4]");
			bool flag26 = (nint)0 == 0;
			object obj37 = !flag26;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD20]");
			object obj38 = 0;
			bool flag27 = _parentIndex < 0;
			bool flag28 = _parentIndex == 0;
			int num4 = _parentIndex ^ _parentIndex;
			int num5 = _parentIndex & num4;
			bool flag29 = num5 < 0;
			text = (string)obj38;
			bool flag30 = flag27 == flag29;
			object obj39 = !flag28;
			bool condition2 = (byte)((flag30 & obj39) ? 1 : 0) != 0;
			Assert.Check(condition2, (string)obj38);
			BVHNode[] nodes5 = bvh._nodes;
			bool flag31 = bvh._nodes == null;
			int num = 0;
			if (!flag31)
			{
				bool flag32 = _parentIndex < nodes5.Length;
				object obj40 = !flag32;
				num = 0;
				if (obj40 == null)
				{
					object obj41 = bvh._nodes + 32;
					object obj42 = obj15;
					object obj43 = _parentIndex * 120;
					object obj44 = obj41 + obj43;
					object obj45 = obj44 + 80;
					bool condition3;
					if (obj15 == obj45)
					{
						condition3 = true;
					}
					else
					{
						object obj46 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v39+E4]");
						bool flag33 = (nint)0 == 0;
						object obj47 = !flag33;
						if (obj47 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj42 = obj15;
						}
						object obj48 = _parentIndex * 120;
						object obj49 = obj41 + obj48;
						object obj50 = obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X9_v20+54]");
						object obj51 = obj50 - 0;
						bool flag34 = obj51 == null;
						condition3 = flag34;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE38]");
					object error2 = 0;
					Assert.Check(condition3, (string)error2);
					object obj52 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ X0_v16+E4]");
					bool flag35 = (nint)0 == 0;
					object obj53 = !flag35;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj54 = obj;
					int nodeIndex;
					if (obj15 == obj45)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v18+E4]");
						bool flag36 = (nint)0 == 0;
						object obj55 = !flag36;
						if (obj55 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						nodeIndex = bVHNode._nodeIndex;
						obj45 = bVHNode._nodeIndex;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v18+E4]");
						bool flag37 = (nint)0 == 0;
						object obj56 = !flag37;
						if (obj56 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj57 = _parentIndex * 120;
						object obj58 = obj41 + obj57;
						nodeIndex = bVHNode._nodeIndex;
						_ = bVHNode._nodeIndex;
					}
					object obj59 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v20+E4]");
					bool flag38 = (nint)0 == 0;
					object obj60 = !flag38;
					if (obj60 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						nodeIndex = bVHNode._nodeIndex;
					}
					bool flag39 = nodeIndex < 0;
					bool flag40 = nodeIndex == 0;
					int num6 = nodeIndex ^ nodeIndex;
					int num7 = nodeIndex & num6;
					bool flag41 = num7 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE28]");
					object error3 = 0;
					bool flag42 = flag39 == flag41;
					object obj61 = !flag40;
					bool condition4 = (byte)((flag42 & obj61) ? 1 : 0) != 0;
					Assert.Check(condition4, (string)error3);
					int newdepth = bVHNode.Depth - 1;
					((BVHNode*)(nint)bVHNode)->_parentIndex = _parentIndex;
					((BVHNode*)bVHNode)->SetDepth(bvh, newdepth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE48]");
					object obj62 = 0;
					bool flag43 = bVHNode._parentIndex < 0;
					bool flag44 = bVHNode._parentIndex == 0;
					int num8 = bVHNode._parentIndex ^ bVHNode._parentIndex;
					int num9 = bVHNode._parentIndex & num8;
					bool flag45 = num9 < 0;
					text = (string)obj62;
					bool flag46 = flag43 == flag45;
					object obj63 = !flag44;
					bool condition5 = (byte)((flag46 & obj63) ? 1 : 0) != 0;
					Assert.Check(condition5, (string)obj62);
					BVHNode[] nodes6 = bvh._nodes;
					bool flag47 = bvh._nodes == null;
					num = 0;
					if (flag47)
					{
						goto IL_0bcb;
					}
					bool flag48 = bVHNode._parentIndex < nodes6.Length;
					object obj64 = !flag48;
					num = 0;
					if (obj64 == null)
					{
						object obj65 = obj;
						object obj66 = bvh._nodes + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v26+E4]");
						bool flag49 = (nint)0 == 0;
						object obj67 = !flag49;
						if (obj67 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj68 = bVHNode._parentIndex * 120;
						object obj69 = obj66 + obj68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v28+48]");
						ChildRefit(bvh, 0, propagate: true);
						goto IL_0bbd;
					}
				}
				goto IL_0bd9;
			}
		}
		goto IL_0bcb;
		IL_0766:
		object obj70 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v55+E4]");
		bool flag50 = (nint)0 == 0;
		object obj71 = !flag50;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj15 = bVHNode + 72;
		goto IL_0bbd;
		IL_0bcb:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0bd9;
		IL_0bd9:
		throw new IndexOutOfRangeException();
	}

	internal unsafe void FindOverlappingLeaves(BVH bvh, Vector3 origin, float radius, List<BVHNode> overlapList)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0016: Expected VT, but got Ref
		//IL_0400: Expected Obj, but got I4
		//IL_0033: Expected Ref, but got VT
		//IL_004c: Expected VT, but got Ref
		//IL_004c: Expected Ref, but got VT
		//IL_00fb: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_027c: Invalid comparison between VT and I4
		//IL_02aa: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected VT, but got Unknown
		//IL_01de: Expected Ref, but got VT
		//IL_03bb: Expected VT, but got Ref
		//IL_03bb: Expected Obj, but got VT
		//IL_0338: Expected Obj, but got I
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		BVHNode bVHNode = (BVHNode)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj4 = default;
		Vector3 vector = default;
		float radius2 = default;
		object obj14 = default;
		BVH bVH = default;
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Bounds bounds = ((BVHNode*)bVHNode)->ToBounds();
			if (!((BVHNode*)bounds)->BoundsIntersectsSphere((Bounds)(&obj4), vector, radius2))
			{
				return;
			}
			HitboxRoot root = bVHNode._root;
			if ((object)bVHNode._root != null)
			{
				object obj5 = root.Flags & (SimulationBehaviourRuntimeFlags)8;
				if (obj5 == null)
				{
					if (vector != (Vector3)(object)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+10]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+1C]");
						object obj7 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+18]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v16+18]");
							bool flag2 = num < 0;
							object obj8 = !flag2;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+18]");
								object obj9 = (nint)0 * (nint)120;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+10]");
								object obj10 = 0 + obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X2_v1 (UnityEngine.Vector3)+18]");
								object obj11 = (nint)0 + (nint)1;
								object obj12 = obj10 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								object obj13 = obj10 + 136;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								((List<BVHNode>)vector).AddWithResize((BVHNode)(&obj14));
							}
							return;
						}
					}
					goto IL_03c1;
				}
			}
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)bVH != null)
			{
				BVHNode[] nodes = bVH._nodes;
				if (bVH._nodes != null)
				{
					bool flag4 = bVHNode._leftIndex < nodes.Length;
					object obj17 = !flag4;
					if (obj17 != null)
					{
						break;
					}
					object obj18 = bVHNode._leftIndex * 120;
					object obj19 = (object)bVH._nodes + obj18;
					BVHNode bVHNode2 = (BVHNode)(obj19 + 32);
					((BVHNode*)bVHNode2)->FindOverlappingLeaves(bVH, vector, radius2, overlapList);
					BVHNode[] nodes2 = bVH._nodes;
					if (bVH._nodes != null)
					{
						bool flag5 = bVHNode._rightIndex < nodes2.Length;
						object obj20 = !flag5;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = bVHNode._rightIndex * 120;
						object obj22 = (object)bVH._nodes + obj21;
						bVHNode = (BVHNode)(obj22 + 32);
						continue;
					}
				}
			}
			goto IL_03c1;
			IL_03c1:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private bool BoundsIntersectsSphere(Bounds bounds, Vector3 origin, float radius)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got VT
		//IL_004e: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got VT
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_02a9: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected I4, but got Unknown
		object obj2 = default;
		object obj = radius + obj2;
		object obj4 = default;
		object obj3 = obj4 + obj2;
		object obj5 = bounds.m_Center - bounds.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
		object obj6 = num - 0;
		object obj7 = obj - obj5;
		bool flag = (nint)obj7 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
		object obj8 = num2 - 0;
		object obj10 = default;
		object obj9 = obj10 + obj2;
		object obj11 = !flag;
		object obj12 = ~obj11;
		bool flag2;
		if (obj12 == null)
		{
			object obj13 = obj3 - obj6;
			flag2 = (nint)obj13 < 0;
		}
		else
		{
			flag2 = true;
		}
		object obj14 = !flag2;
		object obj15 = ~obj14;
		bool flag3;
		if (obj15 == null)
		{
			object obj16 = obj9 - obj8;
			flag3 = (nint)obj16 < 0;
		}
		else
		{
			flag3 = true;
		}
		if (!flag3)
		{
			object obj17 = bounds.m_Center + bounds.m_Extents;
			object obj18 = radius - obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
			object obj19 = num3 + 0;
			object obj20 = obj4 - obj2;
			object obj21 = obj18 - obj17;
			bool flag4 = (nint)obj21 < 0;
			bool flag5 = obj21 == null;
			object obj22 = obj18 ^ obj17;
			object obj23 = obj18 ^ obj21;
			object obj24 = obj22 & obj23;
			bool flag6 = (nint)obj24 < 0;
			bool flag7 = flag4 == flag6;
			object obj25 = !flag7;
			object obj26 = obj25 | flag5;
			object obj27 = ~obj26;
			bool flag8;
			bool flag9;
			bool flag10;
			if (obj27 == null)
			{
				object obj28 = obj20 - obj19;
				flag8 = (nint)obj28 < 0;
				flag9 = obj28 == null;
				object obj29 = obj20 ^ obj19;
				object obj30 = obj20 ^ obj28;
				object obj31 = obj29 & obj30;
				flag10 = (nint)obj31 < 0;
			}
			else
			{
				flag10 = false;
				flag9 = false;
				flag8 = false;
			}
			bool flag11 = flag8 == flag10;
			object obj32 = !flag11;
			object obj33 = obj32 | flag9;
			if (obj33 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+8]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
				object obj34 = num4 + 0;
				object obj35 = obj10 - obj2;
				object obj36 = obj35 - obj34;
				bool flag12 = (nint)obj36 < 0;
				bool flag13 = obj36 == null;
				object obj37 = obj35 ^ obj34;
				object obj38 = obj35 ^ obj36;
				object obj39 = obj37 & obj38;
				bool flag14 = (nint)obj39 < 0;
				bool flag15 = flag12 == flag14;
				object obj40 = !flag15;
				return (byte)((obj40 | flag13) ? 1 : 0) != 0;
			}
		}
		return false;
	}

	internal unsafe void FindOverlappingLeaves(BVH bvh, Bounds aabb, List<BVHNode> overlapList)
	{
		//IL_0010: Expected Obj, but got I
		//IL_061f: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got VT
		//IL_006b: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got VT
		//IL_0116: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0440: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I4
		//IL_031e: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected VT, but got Unknown
		//IL_0519: Expected VT, but got Ref
		//IL_0519: Expected Ref, but got VT
		//IL_0388: Expected Obj, but got I4
		//IL_05d6: Expected VT, but got Ref
		//IL_0565: Expected Obj, but got I4
		//IL_03ac: Expected Obj, but got I
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_0583: Expected Obj, but got I4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected VT, but got Unknown
		//IL_05b8: Expected VT, but got Ref
		//IL_05b8: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Bounds bounds = ToBounds();
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj7 = aabb.m_Center + aabb.m_Extents;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
		object obj8 = !flag2;
		object obj9 = obj4 - obj7;
		bool flag3 = obj9 == null;
		object obj10 = ~obj8;
		object obj11 = obj10 | flag3;
		if (obj11 == null)
		{
			return;
		}
		object obj12 = aabb.m_Center - aabb.m_Extents;
		object obj13 = obj5 + obj6;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			return;
		}
		object obj15 = default;
		object obj16 = default;
		object obj14 = obj15 - obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+4]");
		object obj17 = num + 0;
		bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
		object obj18 = !flag4;
		object obj19 = obj14 - obj17;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		object obj21 = obj18 & obj20;
		if (obj21 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+10]");
		object obj22 = num2 - 0;
		object obj23 = obj15 + obj16;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			return;
		}
		object obj25 = default;
		object obj26 = default;
		object obj24 = obj25 - obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+14]");
		object obj27 = num3 + 0;
		bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27);
		object obj28 = !flag6;
		object obj29 = obj24 - obj27;
		bool flag7 = obj29 == null;
		object obj30 = !flag7;
		object obj31 = obj28 & obj30;
		if (obj31 != null)
		{
			return;
		}
		object obj32 = obj25 + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [aabb @ X2 (UnityEngine.Bounds)+14]");
		object obj33 = num4 - 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33))
		{
			return;
		}
		HitboxRoot root = _root;
		if ((object)_root != null)
		{
			object obj34 = root.Flags & (SimulationBehaviourRuntimeFlags)8;
			bool flag8 = obj34 == null;
			object obj35 = !flag8;
			if (obj35 == null)
			{
				if (overlapList != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+10]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+1C]");
					object obj37 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v15+18]");
						bool flag9 = num5 < 0;
						object obj38 = !flag9;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+18]");
							object obj39 = (nint)0 * (nint)120;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+10]");
							object obj40 = 0 + obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [overlapList @ X3 (System.Collections.Generic.List`1<Fusion.LagCompensation.BVHNode>)+18]");
							object obj41 = (nint)0 + (nint)1;
							object obj42 = obj40 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							object obj43 = obj40 + 136;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							overlapList.AddWithResize((BVHNode)(&obj5));
						}
						return;
					}
				}
				goto IL_05e0;
			}
		}
		object obj44 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X0_v10+E4]");
		bool flag10 = (nint)0 == 0;
		object obj45 = !flag10;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				bool flag11 = _leftIndex < nodes.Length;
				object obj46 = !flag11;
				if (obj46 == null)
				{
					object obj47 = _leftIndex * 120;
					object obj48 = (object)bvh._nodes + obj47;
					BVHNode bVHNode = (BVHNode)(obj48 + 32);
					object obj49 = default;
					((BVHNode*)bVHNode)->FindOverlappingLeaves(bvh, (Bounds)(&obj49), overlapList);
					BVHNode[] nodes2 = bvh._nodes;
					if (bvh._nodes == null)
					{
						goto IL_05e0;
					}
					bool flag12 = _rightIndex < nodes2.Length;
					object obj50 = !flag12;
					if (obj50 == null)
					{
						object obj51 = _rightIndex * 120;
						object obj52 = (object)bvh._nodes + obj51;
						BVHNode bVHNode2 = (BVHNode)(obj52 + 32);
						object obj53 = default;
						((BVHNode*)bVHNode2)->FindOverlappingLeaves(bvh, (Bounds)(&obj53), overlapList);
						return;
					}
				}
				goto IL_05ee;
			}
		}
		goto IL_05e0;
		IL_05ee:
		throw new IndexOutOfRangeException();
		IL_05e0:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05ee;
	}

	internal unsafe Bounds ToBounds()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected VT, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected VT, but got Unknown
		//IL_0131: Expected native int or pointer, but got VT
		//IL_0152: Expected native int or pointer, but got VT
		//IL_015e: Expected VT, but got Ref
		Bounds box = Box;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+C]");
		object obj = box - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+14]");
		object obj2 = num - 0;
		Bounds box2 = Box;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+C]");
		object obj3 = box2 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+14]");
		object obj4 = num2 + 0;
		object obj5 = 0 - obj;
		object obj6 = 0 - obj2;
		object obj7 = obj5 * 63;
		double num3 = (double)obj6 * 0.5;
		object obj8 = obj + obj7;
		double num4 = (double)obj2 + num3;
		object obj9 = obj8 - obj7;
		double num5 = num4 - num3;
		object obj10 = obj3 - obj9;
		double num6 = (double)obj4 - num5;
		Vector3 vector = (Vector3)(obj10 * 63);
		double num7 = num6 * 0.5;
		Vector3 center = obj9 + vector;
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Extents = vector;
		double num8 = num5 + num7;
		((Bounds*)(nint)bounds)->m_Center = center;
		return (Bounds)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
	}

	internal unsafe void ChildExpanded(BVH bvh, ref BVHNode child)
	{
		//IL_0830: Expected Obj, but got VT
		//IL_0840: Expected Obj, but got I
		//IL_084a: Expected F8, but got VT
		//IL_085a: Expected F8, but got I
		//IL_086a: Expected F8, but got I
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
		//IL_08b5: Invalid comparison between F8 and I4
		//IL_08cb: Expected F8, but got I
		//IL_08d3: Invalid comparison between Obj and F8
		//IL_0a1c: Invalid comparison between Obj and F8
		//IL_08fa: Expected Obj, but got I
		//IL_090a: Expected Obj, but got I
		//IL_0936: Expected Obj, but got I
		//IL_093e: Invalid comparison between Obj and F8
		//IL_00d0: Expected VT, but got F8
		//IL_00e2: Expected Obj, but got VT
		//IL_00f2: Expected Obj, but got I
		//IL_0a5f: Invalid comparison between Obj and F8
		//IL_0198: Expected VT, but got F8
		//IL_0991: Expected Obj, but got I
		//IL_0999: Invalid comparison between Obj and F8
		//IL_0257: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0271: Expected VT, but got F8
		//IL_0384: Expected VT, but got F8
		//IL_07fb: Expected Obj, but got I4
		//IL_04ce: Expected VT, but got F8
		//IL_09c0: Expected Obj, but got I
		//IL_09ea: Expected Obj, but got I4
		//IL_0636: Expected VT, but got F8
		//IL_0666: Expected VT, but got Ref
		//IL_067f: Expected VT, but got I4
		//IL_06a7: Expected Obj, but got I4
		//IL_070d: Expected Obj, but got I4
		//IL_0793: Expected Obj, but got I4
		//IL_07b1: Expected Obj, but got I4
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected VT, but got Unknown
		//IL_07df: Expected Ref, but got VT
		object obj = child;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+C]");
		object obj2 = 0;
		double num = (double)Box;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+C]");
		double num2 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+4]");
		double num3 = 0.0;
		BVHNode bVHNode = child;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+C]");
		object obj3 = bVHNode - 0;
		double num4 = (double)Box;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+C]");
		double num5 = num4 - 0.0;
		double num6 = (double)obj3 - num5;
		bool flag = num6 < 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+10]");
		double num7 = 0.0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5))
		{
			double num8 = (double)Box;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+C]");
			double num9 = num8 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+4]");
			double num10 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+10]");
			double num11 = num10 - 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+4]");
			double num12 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.BVHNode)+10]");
			double num13 = num12 + 0.0;
			double num14 = num9 - (double)obj3;
			double num15 = num13 - num11;
			num2 = num14 * 0.5;
			num7 = num15 * 63.0;
			num = (double)obj3 + num2;
			num3 = num11 + num7;
			Box = (Bounds)num;
			obj = child;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+C]");
			obj2 = 0;
		}
		object obj4 = obj + obj2;
		double num16 = num + num2;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num16);
		bool flag3 = flag;
		if (!flag2)
		{
			double num17 = num - num2;
			double num18 = num3 + num7;
			double num19 = num3 - num7;
			double num20 = (double)obj4 - num17;
			double num21 = num18 - num19;
			num2 = num20 * 0.5;
			num7 = num21 * 63.0;
			num = num17 + num2;
			num3 = num19 + num7;
			Box = (Bounds)num;
			flag3 = true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+10]");
		object obj6 = 0;
		double num22 = num3 - num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+4]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+10]");
		object obj7 = num23 - 0;
		bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num22);
		double num25 = default;
		double num24 = num25;
		double num27 = default;
		double num26 = num27;
		if (!flag4)
		{
			double num28 = num3 + num7;
			double num29 = num - num2;
			double num30 = num + num2;
			double num31 = num28 - (double)obj7;
			double num32 = num30 - num29;
			num7 = num31 * 63.0;
			num2 = num32 * 0.5;
			num3 = (double)obj7 + num7;
			num = num29 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+4]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+10]");
			obj6 = 0;
			Box = (Bounds)num;
			num24 = num25;
			num26 = num27;
			flag3 = true;
		}
		object obj8 = obj5 + obj6;
		double num33 = num3 + num7;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num33))
		{
			double num34 = num + num2;
			double num35 = num - num2;
			double num36 = num3 - num7;
			double num37 = num24 + num26;
			double num38 = num24 - num26;
			double num39 = num34 - num35;
			double num40 = (double)obj8 - num36;
			double num41 = num37 - num38;
			num2 = num39 * 0.5;
			num7 = num40 * 0.5;
			num26 = num41 * 0.5;
			num = num35 + num2;
			num3 = num36 + num7;
			num24 = num38 + num26;
			Box = (Bounds)num;
			flag3 = true;
		}
		double num42 = num24 - num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+8]");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+14]");
		object obj9 = num43 - 0;
		double num52;
		double num54;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num42))
		{
			double num44 = num24 + num26;
			double num45 = num - num2;
			double num46 = num + num2;
			double num47 = num3 - num7;
			double num48 = num3 + num7;
			double num49 = num44 - (double)obj9;
			double num50 = num46 - num45;
			double num51 = num48 - num47;
			num26 = num49 * 0.5;
			num2 = num50 * 0.5;
			num7 = num51 * 0.5;
			num24 = (double)obj9 + num26;
			num52 = num24 + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+8]");
			double num53 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+14]");
			num54 = num53 + 0.0;
			num = num45 + num2;
			num3 = num47 + num7;
			Box = (Bounds)num;
			if (num54 > num52)
			{
				goto IL_0541;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+8]");
			double num55 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [child @ X2 (Fusion.LagCompensation.BVHNode&)+14]");
			num54 = num55 + 0.0;
			num52 = num24 + num26;
			if (num54 > num52)
			{
				goto IL_0541;
			}
			bool flag5 = !flag3;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				return;
			}
		}
		goto IL_09b0;
		IL_09b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v2+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = default;
		AABB aABB = new AABB((Bounds)(&obj14));
		object obj15 = obj11;
		_ = 0;
		_cachedBounds = (AABB)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (_parentIndex < 1)
		{
			return;
		}
		object obj17 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((object)bvh != null)
		{
			BVHNode[] nodes = bvh._nodes;
			if (bvh._nodes != null)
			{
				bool flag9 = _parentIndex < nodes.Length;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					object obj20 = _parentIndex * 120;
					object obj21 = (object)bvh._nodes + obj20;
					BVHNode bVHNode2 = (BVHNode)(obj21 + 32);
					((BVHNode*)bVHNode2)->ChildExpanded(bvh, ref this);
					return;
				}
				goto IL_081c;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_081c;
		IL_081c:
		throw new IndexOutOfRangeException();
		IL_0541:
		num52 = num + num2;
		double num56 = num - num2;
		double num57 = num3 + num7;
		double num58 = num3 - num7;
		num3 = num24 - num26;
		double num59 = num52 - num56;
		double num60 = num57 - num58;
		num54 -= num3;
		num26 = num59 * 0.5;
		double num61 = num60 * 0.5;
		num24 = num54 * 0.5;
		num2 = num56 + num26;
		num7 = num58 + num61;
		num = num3 + num24;
		Box = (Bounds)num2;
		goto IL_09b0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void UpdateBoundsCache()
	{
		//IL_000d: Expected VT, but got Ref
		//IL_001e: Expected VT, but got I4
		object obj = default;
		AABB aABB = new AABB((Bounds)(&obj));
		_ = 0;
		_cachedBounds = (AABB)0;
		_ = 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void ChildRefit(BVH bvh, bool propagate = default(bool))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ChildRefit(bvh, _nodeIndex, propagate);
	}

	internal unsafe static void ChildRefit(BVH bvh, int nodeIndex, bool propagate = default(bool))
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0192: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected VT, but got Unknown
		//IL_0223: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got Ref
		//IL_0386: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected VT, but got Unknown
		//IL_027f: Expected Obj, but got I4
		//IL_0287: Expected Obj, but got Ref
		//IL_06ba: Expected Obj, but got I4
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected VT, but got Unknown
		//IL_02d3: Expected VT, but got Obj
		//IL_02e4: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got Ref
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected VT, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_0342: Expected VT, but got Obj
		//IL_0353: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got Ref
		//IL_07c5: Invalid comparison between F8 and I4
		//IL_07d4: Invalid comparison between F8 and I4
		//IL_07e7: Expected Obj, but got F8
		//IL_07f4: Expected Obj, but got F8
		//IL_0833: Expected Obj, but got I4
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected Obj, but got Unknown
		//IL_08d3: Expected Obj, but got F8
		//IL_0938: Expected Obj, but got I4
		//IL_053b: Expected VT, but got Ref
		//IL_0549: Expected Obj, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_05c2: Expected I4, but got Obj
		//IL_0600: Expected VT, but got I4
		//IL_0608: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C28]");
		object obj2 = 0;
		bool flag = propagate;
		int num2 = default;
		int num = num2;
		object obj3 = 0;
		Bounds bounds = default;
		Vector3 point = default;
		Bounds bounds2 = default;
		object obj45 = default;
		object obj48 = default;
		while (true)
		{
			BVHNode[] nodes = bvh._nodes;
			bool flag2 = num < nodes.Length;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			BVHNode[] array = nodes;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				array = bvh._nodes;
			}
			object obj7 = nodes + 32;
			object obj8 = num * 120;
			object obj9 = obj7 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v8+50]");
			bool flag4 = (nint)0 < (nint)array.Length;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				break;
			}
			object obj11 = num * 120;
			object obj12 = obj7 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v9+54]");
			bool flag5 = (nint)0 < (nint)array.Length;
			object obj13 = !flag5;
			if (obj13 != null)
			{
				break;
			}
			object obj14 = array + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v8+50]");
			object obj15 = (nint)0 * (nint)120;
			object obj16 = obj14 + obj15;
			object obj17 = num * 120;
			object obj18 = obj7 + obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v9+54]");
			object obj19 = (nint)0 * (nint)120;
			object obj20 = obj14 + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+C]");
			Vector3 vector = (Vector3)(obj16 - 0);
			bool flag6 = bounds.Internal_Contains(ref point);
			bool flag7 = !flag6;
			AABB aABB = (AABB)vector;
			object obj21 = 0;
			object obj22 = (object)(&point);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+C]");
				Vector3 vector2 = (Vector3)(obj16 + 0);
				bool flag8 = bounds.Internal_Contains(ref point);
				bool flag9 = !flag8;
				aABB = (AABB)vector2;
				obj21 = 0;
				obj22 = (object)(&point);
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+C]");
					Vector3 vector3 = (Vector3)(obj20 - 0);
					bool flag10 = bounds2.Internal_Contains(ref point);
					bool flag11 = !flag10;
					bounds2 = (Bounds)obj18;
					aABB = (AABB)vector3;
					obj21 = 0;
					obj22 = (object)(&point);
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+C]");
						AABB aABB2 = (AABB)(obj20 + 0);
						bool flag12 = bounds2.Internal_Contains(ref point);
						bool flag13 = !flag12;
						object obj23 = !flag13;
						bounds2 = (Bounds)obj18;
						aABB = aABB2;
						obj21 = 0;
						obj22 = (object)(&point);
						if (obj23 != null)
						{
							return;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+14]");
			object obj24 = num3 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+8]");
			double num4 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+14]");
			double num5 = num4 + 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+14]");
			object obj25 = num6 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+14]");
			object obj26 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v3+C]");
			object obj27 = obj16 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
			{
				obj25 = obj24;
			}
			object obj28 = obj26 - obj24;
			bool flag14 = (nint)obj28 < 0;
			bool flag15 = obj28 == null;
			object obj29 = obj26 ^ obj24;
			object obj30 = obj26 ^ obj28;
			object obj31 = obj29 & obj30;
			bool flag16 = (nint)obj31 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
			bool flag17 = flag14 == flag16;
			object obj32 = !flag15;
			object obj33 = flag17 & obj32;
			object obj34 = ~obj33;
			if (obj34 != null)
			{
				obj26 = obj24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X29_v3+C]");
			object obj35 = obj20 + 0;
			object obj36 = obj27 - obj16;
			object obj37 = obj26 - obj25;
			object obj38 = obj36 * 63;
			double num8 = (double)obj37 * 0.5;
			float num9 = (float)obj16 + (float)obj38;
			double num10 = (double)obj25 + num8;
			float num11 = num9 - (float)obj38;
			double num12 = num10 - num8;
			double num13 = num8 + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			double num14 = ((!(num12 < num5)) ? num5 : num12);
			double num15 = num13 - num5;
			bool flag18 = num15 < 0.0;
			bool flag19 = num15 == 0.0;
			object obj39 = num13 ^ num5;
			object obj40 = num13 ^ num15;
			object obj41 = obj39 & obj40;
			bool flag20 = (nint)obj41 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			bool flag21 = flag18 == flag20;
			object obj42 = !flag19;
			object obj43 = flag21 & obj42;
			object obj44 = ~obj43;
			if (obj44 == null)
			{
				num5 = num13;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			double num16 = num5 - num14;
			double num17 = num10 - (double)num9;
			double num18 = num17 * 63.0;
			double num19 = num16 * 0.5;
			double num20 = (double)num9 + num18;
			double num21 = num14 + num19;
			obj18 = num20;
			if ((nint)obj3 < bvh.ParentsToExpand)
			{
				double num22 = num18 + num18;
				double num23 = num19 + num19;
				num9 = bvh.ExpansionFactor;
				obj3++;
				double num24 = num22 * (double)obj45;
				double num25 = num23 * (double)bvh.ExpansionFactor;
				num20 = num24 * 63.0;
				num21 = num25 * 0.5;
				num18 += num20;
				num19 += num21;
			}
			object obj46 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v13+E4]");
			bool flag22 = (nint)0 == 0;
			object obj47 = !flag22;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			aABB = new AABB((Bounds)(&obj48));
			object obj49 = num * 120;
			object obj50 = obj7 + obj49;
			_ = 0;
			_ = 0;
			_ = 0;
			if (propagate)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v16+4C]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v16+4C]");
				if ((nint)0 != 0)
				{
					flag = (byte)(int)obj2 != 0;
					HashSet<int> refitNodes = bvh.refitNodes;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v16+4C]");
					bool flag23 = refitNodes.Contains(0);
					bool flag24 = !flag23;
					obj48 = obj18;
					point = (Vector3)0;
					bounds = (Bounds)obj18;
					if (!flag24)
					{
						return;
					}
					continue;
				}
				return;
			}
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal unsafe static void InitNode(ref BVHNode node, BVH bvh, int index, int parentIndex, int curDepth, List<HitboxRoot> entries = null)
	{
		//IL_02bd: Expected Obj, but got Ref
		//IL_02c6: Expected Obj, but got I4
		//IL_0228: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_03e0: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref node, 104));
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
		_ = 1;
		if (bvh.maxDepth < curDepth)
		{
			bvh.maxDepth = curDepth;
		}
		ref BVHNode reference = ref *(BVHNode*)null;
		_ = 0;
		_ = 0;
		if ((object)entries != null && entries._size >= 1)
		{
			if (entries._size == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD70]");
				object error = 0;
				Assert.Check(condition: true, (string)error);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD68]");
				object obj2 = 0;
				System.__Canon _Canon = ((List<System.__Canon>)(object)entries).get_Item(0);
				obj = _Canon;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65C0]");
				object obj3 = 0;
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			node.SplitNode(bvh, entries);
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [node @ X0 (Fusion.LagCompensation.BVHNode&)+48]");
			ChildRefit(bvh, 0, propagate: false);
		}
	}

	public void BuildLog(StringBuilder builder)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD90]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		string value = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADB8]");
		object format2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADA8]");
		object format3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADE0]");
		object format4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADD8]");
		object format5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C72D8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADD0]");
		object format6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADC8]");
		object format7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADC0]");
		object obj3 = 0;
		StringBuilder stringBuilder = builder.Append(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg2 = default;
		string value2 = string.Format((string)format2, arg2);
		StringBuilder stringBuilder2 = builder.Append(value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg3 = default;
		string value3 = string.Format((string)format3, arg3);
		StringBuilder stringBuilder3 = builder.Append(value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg4 = default;
		string value4 = string.Format((string)format4, arg4);
		StringBuilder stringBuilder4 = builder.Append(value4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg5 = default;
		string value5 = string.Format((string)format5, arg5);
		StringBuilder stringBuilder5 = builder.Append(value5);
		UnityEngine.Object root = _root;
		string text;
		string text2;
		if ((object)_root != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v33 (UnityEngine.Object)+30]");
			object obj4 = (nint)0 & (nint)8;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				text = (string)obj3;
				string name = _root.name;
				text2 = name;
				goto IL_0338;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADB0]");
		object obj6 = 0;
		text = (string)obj3;
		text2 = (string)obj6;
		goto IL_0338;
		IL_0338:
		string value6 = text + text2 + (string)obj2;
		StringBuilder stringBuilder6 = builder.Append(value6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg6 = default;
		string value7 = string.Format((string)format6, arg6);
		StringBuilder stringBuilder7 = builder.Append(value7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg7 = default;
		string value8 = string.Format((string)format7, arg7);
		StringBuilder stringBuilder8 = builder.Append(value8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD98]");
		object format8 = 0;
		object arg8 = default;
		string value9 = string.Format((string)format8, arg8);
		StringBuilder stringBuilder9 = builder.Append(value9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DADA0]");
		object format9 = 0;
		object arg9 = default;
		string value10 = string.Format((string)format9, arg9);
		StringBuilder stringBuilder10 = builder.Append(value10);
	}

	static BVHNode()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE70]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAE78]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HitboxRoot.HitboxComparerX hitboxComparerX = default;
		hitboxComparerX._002Ector();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+A0]");
		object obj6 = 0;
		obj6 = hitboxComparerX;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HitboxRoot.HitboxComparerY hitboxComparerY = default;
		hitboxComparerY._002Ector();
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6+A0]");
		object obj9 = (nint)0 + (nint)8;
		obj9 = hitboxComparerY;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BehaviourUtils.HitboxComparerZ hitboxComparerZ = default;
		hitboxComparerZ._002Ector();
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+A0]");
		object obj11 = (nint)0 + (nint)16;
		obj11 = hitboxComparerZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
