using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

namespace Fusion.LagCompensation;

internal class BVH : Action<Record<>>
{
	internal BVHNode[] _nodes;

	internal Mapper Mapper;

	internal int maxDepth;

	internal HashSet<int> refitNodes;

	internal readonly List<HitboxRoot> ReusableList;

	private int _nodesCount;

	private int _usedNodesCount;

	private int _freeNodesHead;

	private const float DEFAULT_EXPANSION_FACTOR = default(float);

	private const int DEFAULT_PARENTS_TO_EXPAND = default(int);

	internal float ExpansionFactor;

	internal int ParentsToExpand;

	internal unsafe ref BVHNode rootBVH
	{
		get
		{
			//IL_003d: Expected Obj, but got I8
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Ref, but got Unknown
			BVHNode[] nodes = _nodes;
			if (_nodes != null)
			{
				object obj = nodes.Length & 0xFFFFFFFEL;
				if (obj != null)
				{
					return ref *(BVHNode*)(_nodes + 152);
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return ref *(BVHNode*)ex2;
		}
	}

	internal int UsedNodesCount
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _usedNodesCount;
		}
	}

	public void CopyFrom(ILagCompensationBroadphase other)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6470]");
		object obj = 0;
		object obj2 = obj;
		nint num = (nint)other;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v7 (Il2CppClass<Fusion.LagCompensation.ILagCompensationBroadphase>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v7 (Il2CppClass<Fusion.LagCompensation.ILagCompensationBroadphase>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v9-8]");
			if (0 == (nint)obj2)
			{
				Array nodes = _nodes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+38]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v8 (System.Array)+18]");
				int minimumIncrease = (int)(num4 - 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+38]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v8 (System.Array)+18]");
				if (num5 > 0)
				{
					ResizeNodesArray(minimumIncrease);
					nodes = _nodes;
				}
				Array array = nodes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v8 (System.Array)+18]");
				Array.Clear(array, 0, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+10]");
				nint num6 = 0;
				BVHNode[] nodes2 = _nodes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+38]");
				Array.Copy((Array)num6, 0, nodes2, 0, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+20]");
				maxDepth = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+38]");
				_nodesCount = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ X1 (Fusion.LagCompensation.ILagCompensationBroadphase)+40]");
				_freeNodesHead = 0;
				return;
			}
		}
		throw new InvalidCastException();
	}

	internal unsafe ref BVHNode GetNextNode(out int index)
	{
		//IL_0122: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_013e: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Ref, but got Unknown
		//IL_0073: Expected Obj, but got I4
		int num;
		BVHNode[] nodes2;
		if (_freeNodesHead != 0)
		{
			ref int reference = ref *(int*)_freeNodesHead;
			BVHNode[] nodes = _nodes;
			if (_nodes != null)
			{
				bool flag = _freeNodesHead < nodes.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = _freeNodesHead * 120;
					object obj3 = (object)_nodes + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v10+84]");
					_freeNodesHead = 0;
					num = index;
					nodes2 = _nodes;
					goto IL_0107;
				}
				goto IL_01f2;
			}
		}
		else
		{
			num = _nodesCount;
			int nodesCount = _nodesCount + 1;
			_nodesCount = nodesCount;
			ref int reference = ref *(int*)_nodesCount;
			nodes2 = _nodes;
			if (_nodes != null)
			{
				goto IL_0107;
			}
		}
		goto IL_0200;
		IL_0107:
		bool flag2 = num < nodes2.Length;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			object obj5 = num * 120;
			object obj6 = (object)nodes2 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACB0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X20_v2+80]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
			_ = 0;
			ref BVHNode reference2 = ref *(BVHNode*)(obj6 + 32);
			reference2 = ref *(BVHNode*)null;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 1;
			int usedNodesCount = _usedNodesCount + 1;
			_usedNodesCount = usedNodesCount;
			return ref reference2;
		}
		goto IL_01f2;
		IL_0200:
		NullReferenceException ex = new NullReferenceException();
		return ref *(BVHNode*)ex;
		IL_01f2:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0200;
	}

	internal void DisposeNode(int index)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I4
		BVHNode[] nodes = _nodes;
		if (_nodes == null)
		{
			goto IL_017e;
		}
		bool flag = nodes.Length < index;
		object obj = !flag;
		object obj2 = nodes.Length - index;
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACB8]");
			object obj5 = 0;
			object obj6 = index * 120;
			object obj7 = (object)_nodes + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5298]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F78D0");
			BVHNode[] nodes2 = _nodes;
			if (_nodes == null)
			{
				goto IL_017e;
			}
			bool flag3 = nodes2.Length < index;
			object obj9 = !flag3;
			object obj10 = nodes2.Length - index;
			bool flag4 = obj10 == null;
			object obj11 = ~obj9;
			object obj12 = obj11 | flag4;
			if (obj12 == null)
			{
				object obj13 = index * 120;
				object obj14 = (object)_nodes + obj13;
				_ = 0;
				_ = _freeNodesHead;
				int usedNodesCount = _usedNodesCount - 1;
				_usedNodesCount = usedNodesCount;
				_freeNodesHead = index;
				return;
			}
		}
		goto IL_018c;
		IL_017e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_018c;
		IL_018c:
		throw new IndexOutOfRangeException();
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe ref BVHNode GetNode(int index)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Ref, but got Unknown
		BVHNode[] nodes = _nodes;
		if (_nodes != null)
		{
			bool flag = nodes.Length < index;
			object obj = !flag;
			object obj2 = nodes.Length - index;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = index * 120;
				object obj6 = (object)_nodes + obj5;
				return ref *(BVHNode*)(obj6 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(BVHNode*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void Update(HitboxRoot changed, int tick)
	{
		//IL_001a: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		Mapper mapper = Mapper;
		if (Mapper != null && (object)mapper._rootToNodeIndex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACC8]");
			object obj = 0;
			if (!((Dictionary<System.__Canon, int>)(object)mapper._rootToNodeIndex).TryGetValue((System.__Canon)(object)changed, out int value))
			{
				return;
			}
			BVHNode[] nodes = _nodes;
			if (_nodes != null)
			{
				bool flag = value < nodes.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = value * 120;
					object obj4 = (object)_nodes + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACC0]");
					object error = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X21_v5+88]");
					object obj5 = 0 - changed;
					bool condition = obj5 == null;
					Assert.Check(condition, (string)error);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj9 = obj4 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @315E3BC");
					return;
				}
				goto IL_0184;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0184;
		IL_0184:
		throw new IndexOutOfRangeException();
	}

	public void Traverse(IBoundsTraversalTest hitTest, HashSet<HitboxRoot> candidateRoots, int layerMask)
	{
		TraverseInternal(ref rootBVH, hitTest, candidateRoots, layerMask);
	}

	private unsafe void TraverseInternal(ref BVHNode curNode, IBoundsTraversalTest hitTest, HashSet<HitboxRoot> candidateRoots, int layermask)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I4
		//IL_0096: Expected I, but got Obj
		//IL_00a6: Expected Obj, but got I
		//IL_056a: Expected Obj, but got I
		//IL_0578: Expected Obj, but got Ref
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Ref, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I
		//IL_0301: Expected Obj, but got I4
		//IL_04c6: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Ref, but got Unknown
		//IL_0349: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACD8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACE0]");
		object obj3 = 0;
		ref BVHNode reference2 = default;
		ref BVHNode reference = ref reference2;
		IBoundsTraversalTest boundsTraversalTest = default;
		object obj12 = default;
		HashSet<HitboxRoot> hashSet = default;
		int layermask2 = default;
		while (true)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+48]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			if (boundsTraversalTest == null)
			{
				goto IL_04e9;
			}
			nint num = (nint)boundsTraversalTest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (Il2CppClass<Fusion.LagCompensation.IBoundsTraversalTest>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (Il2CppClass<Fusion.LagCompensation.IBoundsTraversalTest>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0122;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8 (Il2CppClass<Fusion.LagCompensation.IBoundsTraversalTest>)+98]");
			object obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v11-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj6--;
				obj7 += 16;
				if ((nint)obj6 != 1)
				{
					continue;
				}
				goto IL_0122;
			}
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			goto IL_055a;
			IL_0122:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_055a;
			IL_04e9:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_055a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v10+8]");
			object obj10 = 0;
			System.__Canon _Canon = (System.__Canon)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v336 @ X0_v10] (should have been resolved before IL gen)");
			object obj11 = obj12 & 1;
			if (obj11 == null)
			{
				return;
			}
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+70]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+58]");
				if ((nint)0 != 0)
				{
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v20+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+68]");
					_Canon = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+68]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v7 (System.__Canon)+30]");
						object obj17 = (nint)0 & (nint)8;
						bool flag4 = obj17 == null;
						object obj18 = !flag4;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v7 (System.__Canon)+40]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X1_v7 (System.__Canon)+40]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v22+58]");
								object obj20 = (nint)0 & (nint)2;
								bool flag5 = obj20 == null;
								object obj21 = !flag5;
								if (obj21 == null)
								{
									if (hashSet == null)
									{
										goto IL_04e9;
									}
									obj10 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+68]");
									bool flag6 = ((HashSet<System.__Canon>)(object)hashSet).Add((System.__Canon)0);
								}
							}
						}
					}
				}
			}
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)this != null)
			{
				BVHNode[] nodes = _nodes;
				if (_nodes != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+50]");
					bool flag8 = (nint)0 < (nint)nodes.Length;
					object obj24 = !flag8;
					if (obj24 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+50]");
					object obj25 = (nint)0 * (nint)120;
					object obj26 = (object)_nodes + obj25;
					TraverseInternal(ref *(BVHNode*)(obj26 + 32), boundsTraversalTest, hashSet, layermask2);
					BVHNode[] nodes2 = _nodes;
					if (_nodes != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+54]");
						bool flag9 = (nint)0 < (nint)nodes2.Length;
						object obj27 = !flag9;
						if (obj27 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X26_v2 (Fusion.LagCompensation.BVHNode&)+54]");
						object obj28 = (nint)0 * (nint)120;
						object obj29 = (object)_nodes + obj28;
						reference = ref *(BVHNode*)(obj29 + 32);
						continue;
					}
				}
			}
			goto IL_04e9;
		}
		throw new IndexOutOfRangeException();
	}

	public unsafe void PosUpdateRefit()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got I4
		//IL_03b4: Expected I, but got Obj
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Ref, but got Unknown
		//IL_03d7: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CF4C5]");
		object obj = 0;
		bool flag = refitNodes == null;
		object obj3 = default;
		object obj2 = obj3;
		Enumerator val = (Enumerator)0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65E0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65D8]");
			object obj6 = 0;
			Enumerator enumerator = refitNodes.GetEnumerator();
			obj = obj3;
			Enumerator val2 = default;
			object obj18 = default;
			while (true)
			{
				nint num = (nint)obj4;
				object obj14;
				Enumerator val3;
				Enumerator val4;
				if (val.MoveNext())
				{
					BVHNode[] nodes = _nodes;
					if (_nodes != null)
					{
						obj = nodes.Length;
						bool flag2 = (nint)obj3 < nodes.Length;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							object obj8 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v31+E4]");
							bool flag3 = (nint)0 == 0;
							object obj9 = !flag3;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj10 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v34+E4]");
							bool flag4 = (nint)0 == 0;
							object obj11 = !flag4;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj12 = _nodes + 32;
							object obj13 = obj3 * 120;
							obj = obj12 + obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v5+48]");
							BVHNode.ChildRefit(this, 0, propagate: true);
							continue;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					obj2 = 0;
					val = val2;
					obj14 = 0;
					val3 = val2;
					val4 = (Enumerator)(ref val);
					break;
				}
				obj2 = 0;
				val = val2;
				obj14 = 0;
				val3 = val2;
				val4 = (Enumerator)(ref val);
				object obj15 = 0;
				while (true)
				{
					num = (nint)obj6;
					((Enumerator*)val4)->Dispose();
					bool flag5 = obj15 == null;
					object obj16 = !flag5;
					if (obj16 == null)
					{
						bool flag6 = obj2 == null;
						object obj17 = !flag6;
						OutOfMemoryException ex3 = (OutOfMemoryException)val4;
						if (obj17 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj2 = 1;
						obj = 1;
						obj15 = obj14;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj18;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A50E0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				if (refitNodes == null)
				{
					break;
				}
				refitNodes.Clear();
				return;
			}
		}
		throw new NullReferenceException();
	}

	public void Add(HitboxRoot root)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj = 0;
		Bounds bounds = root.GetBounds();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		BVHNode[] nodes = _nodes;
		if (_nodesCount >= nodes.Length)
		{
			ResizeNodesArray(nodes.Length);
		}
		ref BVHNode startNode = ref rootBVH;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Bounds newObBox = default;
		float newObSah = default;
		BVHNode.Add(this, ref startNode, root, ref newObBox, newObSah);
	}

	internal unsafe static Bounds BoundsFromSphere(Vector3 pos, float radius)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0137: Expected VT, but got F4
		//IL_0132: Expected native int or pointer, but got VT
		//IL_0144: Expected VT, but got F4
		//IL_013f: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj4 = obj2 + obj3;
		object obj5 = default;
		float num = radius - (float)obj5;
		object obj6 = 0 - obj;
		float num2 = radius + (float)obj5;
		float num3 = 0f - num;
		double num4 = (double)obj6 * 0.5;
		float num5 = num3 * 63f;
		double num6 = (double)obj + num4;
		float num7 = num + num5;
		double num8 = num6 - num4;
		float num9 = num7 - num5;
		double num10 = (double)obj4 - num8;
		float num11 = num2 - num9;
		double num12 = num10 * 0.5;
		float num13 = num11 * 63f;
		double num14 = num8 + num12;
		float num15 = num9 + num13;
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Extents = (Vector3)num13;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)num15;
		return (Bounds)pos;
	}

	public unsafe bool Remove(HitboxRoot root)
	{
		//IL_0159: Expected I4, but got Obj
		//IL_001a: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected VT, but got Unknown
		//IL_0133: Expected Ref, but got VT
		Mapper mapper = Mapper;
		if (Mapper != null && (object)mapper._rootToNodeIndex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DACC8]");
			object obj = 0;
			bool flag = ((Dictionary<System.__Canon, int>)(object)mapper._rootToNodeIndex).TryGetValue((System.__Canon)(object)root, out int value);
			if (flag)
			{
				BVHNode[] nodes = _nodes;
				if (_nodes == null)
				{
					goto IL_013d;
				}
				bool flag2 = value < nodes.Length;
				object obj2 = !flag2;
				if (obj2 != null)
				{
					goto IL_014b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
				object obj3 = 0;
				object obj4 = obj3;
				object obj5 = value * 120;
				object obj6 = (object)_nodes + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				BVHNode bVHNode = (BVHNode)(obj6 + 32);
				((BVHNode*)bVHNode)->Remove(this, root);
			}
			return flag;
		}
		goto IL_013d;
		IL_014b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_013d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_014b;
	}

	internal BVH(Mapper mapper, int nodesCapacity, List<HitboxRoot> initialEntries = null, float expansionFactor = default(float), int parentsToExpand = default(int))
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected I4, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69C8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD48]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD50]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD58]");
		object error = 0;
		maxDepth = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		object obj5 = this + 40;
		obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector(2);
		object obj6 = this + 48;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_freeNodesHead = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B968]");
		_nodesCount = 0;
		base._002Ector();
		object obj7 = nodesCapacity - 32;
		if (~(object)(((nint)obj7 < 0 == ((nodesCapacity ^ 0x20) & (nodesCapacity ^ obj7)) < 0) & (object)(obj7 != null)) == null)
		{
			int num = nodesCapacity;
		}
		else
		{
			int num = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj8 = this + 16;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj10 = this + 24;
		obj10 = mapper;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		ExpansionFactor = expansionFactor;
		ParentsToExpand = parentsToExpand;
		ref BVHNode nextNode = ref GetNextNode(out var index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD60]");
		Assert.Check((object)(index - 1) == null, (string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v24+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		BVHNode.InitNode(ref nextNode, this, index, 0, 0, initialEntries);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v22 (Fusion.LagCompensation.BVHNode&)+48]");
		Assert.Check((object)(-1) == null, (string)error);
	}

	internal unsafe void BuildNodesLog(StringBuilder builder)
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_014a: Expected VT, but got Obj
		//IL_0157: Expected Ref, but got VT
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD80]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		string value = string.Format((string)format, arg, arg2);
		if (builder != null)
		{
			StringBuilder stringBuilder = builder.AppendLine(value);
			if (_nodesCount < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DAD88]");
			object format2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
			object obj2 = 0;
			object obj3 = 32;
			object obj4 = 0;
			object obj5 = 0;
			object arg3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				string value2 = string.Format((string)format2, arg3);
				StringBuilder stringBuilder2 = builder.Append(value2);
				BVHNode[] nodes = _nodes;
				if (_nodes == null)
				{
					break;
				}
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = (nint)obj5 < nodes.Length;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					BVHNode bVHNode = (BVHNode)((object)_nodes + obj3);
					((BVHNode*)bVHNode)->BuildLog(builder);
					StringBuilder stringBuilder3 = builder.AppendLine();
					object obj9 = obj5 + 1;
					obj3 += 120;
					bool flag3 = (nint)obj9 < _nodesCount;
					object obj10 = obj5;
					obj4 = 0;
					obj5 = obj9;
					if (!flag3)
					{
						return;
					}
					continue;
				}
				goto IL_01cb;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01cb;
		IL_01cb:
		throw new IndexOutOfRangeException();
	}

	private unsafe void ResizeNodesArray(int minimumIncrease)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Ref, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_00a6: Expected I4, but got F8
		//IL_004e: Expected Obj, but got I4
		ref BVHNode[] reference = ref *(BVHNode[]*)(this + 16);
		BVHNode[] array = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		int num = minimumIncrease / array.Length;
		double num2 = (double)num + 1.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		int num3 = Math.Max(2, (int)num2);
		int newSize = num3 * array.Length;
		Array.Resize(ref reference, newSize);
	}
}
