using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Fusion.Statistics;
using UnityEngine;

namespace Fusion.LagCompensation;

internal class HitboxBuffer
{
	private sealed class _003CGetEnumerator_003Ed__4 : _0021_00210, Action<_0021_00210, _0021_00211>, _0021_00210
	{
		private int _003C_003E1__state;

		private BVHNodeDrawInfo _003C_003E2__current;

		public BVHDraw _003C_003E4__this;

		private BVHNode _003Cnode_003E5__1;

		private BVHNodeDrawInfo System_002ECollections_002EGeneric_002EIEnumerator_003CFusion_002ELagCompensation_002EBVHNodeDrawInfo_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_0015: Expected I4, but got I8
			//IL_0044: Expected VT, but got I4
			_ = 0;
			_003C_003E1__state = -2;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_003Cnode_003E5__1 = (BVHNode)0;
		}

		private unsafe bool MoveNext()
		{
			//IL_0878: Expected Obj, but got I
			//IL_01b8: Expected I4, but got I8
			//IL_01da: Expected Obj, but got I4
			//IL_0216: Expected VT, but got I
			//IL_0021: Expected Obj, but got I4
			//IL_043e: Expected Obj, but got I4
			//IL_0048: Expected I4, but got I8
			//IL_068e: Expected VT, but got I4
			//IL_0868: Expected I4, but got Obj
			//IL_02da: Expected Obj, but got I4
			//IL_0536: Expected Obj, but got I4
			//IL_0702: Unknown result type (might be due to invalid IL or missing references)
			//IL_0707: Expected Obj, but got Unknown
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0721: Expected Obj, but got Unknown
			//IL_0755: Expected Obj, but got I4
			//IL_0366: Expected Obj, but got I4
			//IL_05c2: Expected Obj, but got I4
			//IL_03ac: Expected Obj, but got I
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Expected Obj, but got Unknown
			//IL_03e6: Expected Obj, but got I
			//IL_019c: Expected VT, but got Ref
			//IL_0407: Expected VT, but got Ref
			//IL_040f: Expected VT, but got Ref
			//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ed: Expected Ref, but got Unknown
			//IL_0809: Unknown result type (might be due to invalid IL or missing references)
			//IL_080e: Expected Obj, but got Unknown
			//IL_0608: Expected Obj, but got I
			//IL_0623: Unknown result type (might be due to invalid IL or missing references)
			//IL_0628: Expected Obj, but got Unknown
			//IL_0654: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6478]");
			object obj = 0;
			object obj3 = default;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_083e;
				}
				BVHDraw bVHDraw = _003C_003E4__this;
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this != null && bVHDraw._reusableStack != null)
				{
					bVHDraw._reusableStack.Clear();
					BVHDraw bVHDraw2 = _003C_003E4__this;
					if ((object)_003C_003E4__this != null)
					{
						BVHNodeDrawInfo drawInfo = bVHDraw2._drawInfo;
						if (bVHDraw2._drawInfo != null && drawInfo.Buffer != null)
						{
							BVH bVH = drawInfo.Buffer.BVH;
							if ((object)bVH != null)
							{
								ref BVHNode rootBVH = ref bVH.rootBVH;
								if (bVHDraw2._reusableStack != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									bVHDraw2._reusableStack.Push((BVHNode)(&obj3));
									goto IL_089d;
								}
							}
						}
					}
				}
			}
			else
			{
				object obj4 = obj;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+78]");
				bool flag3 = (nint)0 < (nint)1;
				IntPtr intPtr = default;
				BVHNode bVHNode = (BVHNode)(nint)intPtr;
				if (flag3)
				{
					goto IL_0414;
				}
				BVHDraw bVHDraw3 = _003C_003E4__this;
				if ((object)_003C_003E4__this != null)
				{
					BVHNodeDrawInfo drawInfo2 = bVHDraw3._drawInfo;
					if (bVHDraw3._drawInfo != null && drawInfo2.Buffer != null)
					{
						BVH bVH2 = drawInfo2.Buffer.BVH;
						object obj6 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v30+E4]");
						bool flag4 = (nint)0 == 0;
						object obj7 = !flag4;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((object)bVH2 != null)
						{
							BVHNode[] nodes = bVH2._nodes;
							if (bVH2._nodes != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+78]");
								bool flag5 = (nint)0 < (nint)nodes.Length;
								object obj8 = !flag5;
								if (obj8 != null)
								{
									goto IL_085a;
								}
								if (bVHDraw3._reusableStack != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+78]");
									object obj9 = (nint)0 * (nint)120;
									object obj10 = (object)bVH2._nodes + obj9;
									object obj11 = obj10 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6508]");
									object obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									bVHDraw3._reusableStack.Push((BVHNode)(&obj3));
									bVHNode = (BVHNode)(&obj3);
									goto IL_0414;
								}
							}
						}
					}
				}
			}
			goto IL_084c;
			IL_084c:
			NullReferenceException ex = new NullReferenceException();
			goto IL_085a;
			IL_0659:
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_003Cnode_003E5__1 = (BVHNode)0;
			goto IL_089d;
			IL_083e:
			return false;
			IL_085a:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
			IL_0414:
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+7C]");
			if ((nint)0 < (nint)1)
			{
				goto IL_0659;
			}
			BVHDraw bVHDraw4 = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				BVHNodeDrawInfo drawInfo3 = bVHDraw4._drawInfo;
				if (bVHDraw4._drawInfo != null && drawInfo3.Buffer != null)
				{
					BVH bVH3 = drawInfo3.Buffer.BVH;
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v24+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((object)bVH3 != null)
					{
						BVHNode[] nodes2 = bVH3._nodes;
						if (bVH3._nodes != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+7C]");
							bool flag8 = (nint)0 < (nint)nodes2.Length;
							object obj17 = !flag8;
							if (obj17 != null)
							{
								goto IL_085a;
							}
							if (bVHDraw4._reusableStack != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+7C]");
								object obj18 = (nint)0 * (nint)120;
								object obj19 = (object)bVH3._nodes + obj18;
								object obj20 = obj19 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
								bVHDraw4._reusableStack.Push((BVHNode)(&obj3));
								goto IL_0659;
							}
						}
					}
				}
			}
			goto IL_084c;
			IL_089d:
			while (true)
			{
				BVHDraw bVHDraw5 = _003C_003E4__this;
				if ((object)_003C_003E4__this == null)
				{
					break;
				}
				Stack<BVHNode> reusableStack = bVHDraw5._reusableStack;
				if (bVHDraw5._reusableStack == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5 (System.Collections.Generic.Stack`1<Fusion.LagCompensation.BVHNode>)+18]");
				if ((nint)0 > (nint)0)
				{
					BVHNode bVHNode2 = bVHDraw5._reusableStack.Pop();
					object obj21 = this + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					object obj22 = this + 144;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v11+E4]");
					bool flag9 = (nint)0 == 0;
					object obj24 = !flag9;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.LagCompensation.HitboxBuffer+<GetEnumerator>d__4)+70]");
					if ((nint)0 >= (nint)1)
					{
						BVHDraw bVHDraw6 = _003C_003E4__this;
						if ((object)_003C_003E4__this == null || bVHDraw6._drawInfo == null)
						{
							break;
						}
						BVHNodeDrawInfo bVHNodeDrawInfo = bVHDraw6._drawInfo.FromBVHNode(ref *(BVHNode*)(this + 40));
						object obj25 = this + 24;
						obj25 = bVHDraw6._drawInfo;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						return true;
					}
					continue;
				}
				goto IL_083e;
			}
			goto IL_084c;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	internal _003CPrivateImplementationDetails_003E.HitboxSnapshot[] _buffer;

	private Mapper _mapper;

	private int _head;

	private int _advanced;

	internal int Tick;

	private bool _loggedAboutMissingSnapshots;

	private readonly HashSet<HitboxRoot> _broadphaseCandidates;

	private readonly HashSet<int> _colliderCandidates;

	internal int Length
	{
		get
		{
			//IL_003e: Expected I4, but got Obj
			_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
			if (_buffer != null)
			{
				return buffer.Length;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal BVH BVH
	{
		get
		{
			//IL_0022: Expected Obj, but got I4
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_0051: Expected Obj, but got I
			//IL_0086: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I
			//IL_00c3: Expected I, but got Obj
			//IL_00f4: Expected Obj, but got I4
			//IL_0129: Expected Obj, but got I
			//IL_0160: Expected Obj, but got I
			_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
			if (_buffer != null)
			{
				bool flag = _head < buffer.Length;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_017d;
				}
				object obj2 = _buffer + _head;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+20]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+28]");
					BVH bVH = (BVH)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6470]");
						object obj4 = 0;
						nint num = (nint)bVH;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v6 (Il2CppClass<Fusion.LagCompensation.BVH>)+130]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v8+130]");
						bool flag2 = num2 < 0;
						object obj6 = !flag2;
						if (obj6 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v6 (Il2CppClass<Fusion.LagCompensation.BVH>)+B0]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v8+130]");
							object obj7 = num3 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X10_v8-8]");
							if (0 == (nint)obj5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+28]");
								return (BVH)0;
							}
							return null;
						}
					}
					return null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_017d;
			IL_017d:
			return (BVH)(object)new IndexOutOfRangeException();
		}
	}

	internal _003CPrivateImplementationDetails_003E.HitboxSnapshot Current
	{
		get
		{
			//IL_0046: Expected Obj, but got I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_0072: Expected Obj, but got I
			_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
			if (_buffer != null)
			{
				bool flag = _head < buffer.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = _buffer + _head;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v2+20]");
					return (_003CPrivateImplementationDetails_003E.HitboxSnapshot)0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			return (_003CPrivateImplementationDetails_003E.HitboxSnapshot)(object)new IndexOutOfRangeException();
		}
	}

	internal HitboxBuffer(List<HitboxRoot> initialObjects, int bufferSize, int hitboxCapacity, float expansionFactor)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I
		//IL_05ff: Expected Obj, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected I4, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_028d: Expected I4, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_043a: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I
		//IL_04e0: Expected Obj, but got I
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0584: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6548]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6C38]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6558]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6570]");
		object obj4 = 0;
		_head = 0;
		_loggedAboutMissingSnapshots = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj5 = this + 48;
		obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<int> hashSet2 = default;
		hashSet2._002Ector();
		object obj6 = this + 56;
		obj6 = hashSet2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		int num = default;
		bool flag = num > 0;
		int num2 = hitboxCapacity;
		int num3 = num;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v25+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v26+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v26+10]");
			bool flag2 = (nint)0 == 0;
			num2 = hitboxCapacity;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6580]");
				object format = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6588]");
				object arg = default;
				string text = string.Format((string)format, 0, arg);
				object obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ X8_v33+198] (should have been resolved before IL gen)");
				num2 = 0;
			}
			num3 = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj12 = this + 16;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mapper mapper = default;
		mapper._002Ector();
		object obj14 = this + 24;
		obj14 = mapper;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj12;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6578]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6560]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4+18]");
		bool flag3 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4+18]");
		bool flag4 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4+18]");
		object obj18 = num4 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v4+18]");
		Assert.Check((byte)(((flag3 == (nint)(object)(0 & obj18) < 0) & (object)(!flag4)) ? 1 : 0) != 0, (string)obj16);
		bool flag5 = (object)initialObjects == null;
		object obj19 = 0;
		int num5 = (int)obj16;
		int num6 = hitboxCapacity;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v47+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num7 = Math.Max(hitboxCapacity, initialObjects._size);
			obj19 = 0;
			num5 = initialObjects._size;
			num6 = num7;
		}
		object obj21 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		_003CPrivateImplementationDetails_003E.HitboxSnapshot hitboxSnapshot = default;
		float expansionFactor2 = default;
		hitboxSnapshot._002Ector((Mapper)obj14, initialObjects, num6, expansionFactor2);
		bool flag6 = (object)hitboxSnapshot == null;
		Mapper mapper2 = (Mapper)obj14;
		int num8;
		List<HitboxRoot> list;
		IndexOutOfRangeException ex = default;
		Mapper mapper3;
		if (!flag6)
		{
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v18+40]");
			mapper2 = (Mapper)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag7 = ex == null;
			num8 = num6;
			list = initialObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v18+40]");
			mapper3 = (Mapper)0;
			if (flag7)
			{
				goto IL_05c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X23_v11+18]");
		bool flag8 = (nint)0 == 0;
		num8 = num6;
		list = initialObjects;
		if (flag8)
		{
			goto IL_05b3;
		}
		object obj23 = obj21 + 32;
		obj23 = hitboxSnapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj24 = obj12;
		int num9 = num6;
		List<HitboxRoot> list2 = initialObjects;
		_003CPrivateImplementationDetails_003E.HitboxSnapshot hitboxSnapshot2 = hitboxSnapshot;
		object obj25 = 40;
		object obj26 = 1;
		_003CPrivateImplementationDetails_003E.HitboxSnapshot hitboxSnapshot3 = default;
		while (true)
		{
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X25_v10+18]");
			if ((nint)obj27 >= 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			hitboxSnapshot3._002Ector((Mapper)obj14, null, num6, expansionFactor2);
			bool flag9 = (object)hitboxSnapshot3 == null;
			mapper2 = (Mapper)obj14;
			if (!flag9)
			{
				object obj28 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v17+40]");
				mapper2 = (Mapper)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag10 = ex == null;
				num8 = num6;
				list = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v17+40]");
				mapper3 = (Mapper)0;
				if (flag10)
				{
					break;
				}
			}
			object obj29 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X25_v10+18]");
			bool flag11 = (nint)obj29 < 0;
			object obj30 = !flag11;
			num8 = num6;
			list = null;
			if (obj30 == null)
			{
				object obj31 = obj24 + obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj24 = obj12;
				obj26++;
				obj25 += 8;
				bool flag12 = obj12 == null;
				object obj32 = !flag12;
				num9 = num6;
				list2 = null;
				hitboxSnapshot2 = hitboxSnapshot3;
				if (obj32 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			goto IL_05b3;
		}
		goto IL_05c9;
		IL_05b3:
		ex = new IndexOutOfRangeException();
		mapper3 = mapper2;
		goto IL_05c9;
		IL_05c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	internal void Advance(int tick, int dataTick)
	{
		//IL_00c8: Expected Obj, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00f3: Expected I4, but got Obj
		//IL_010e: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_007a: Expected I4, but got Obj
		//IL_0141: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		int num;
		_003CPrivateImplementationDetails_003E.HitboxSnapshot[] array;
		if (Tick == tick)
		{
			_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
			object obj = _head + buffer.Length;
			object obj2 = obj - 1;
			object obj3 = obj2 / buffer.Length;
			object obj4 = obj3 * buffer.Length;
			num = obj2 - obj4;
			array = buffer;
		}
		else
		{
			num = _head;
			array = _buffer;
			int advanced = _advanced + 1;
			_advanced = advanced;
		}
		object obj5 = num + 1;
		object obj6 = obj5 / array.Length;
		object obj7 = obj6 * array.Length;
		int num2 = obj5 - obj7;
		bool flag = num2 < array.Length;
		object obj8 = !flag;
		_head = num2;
		if (obj8 == null)
		{
			bool flag2 = num < array.Length;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				object obj10 = array + num2;
				object obj11 = array + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X10_v5+20]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v4+20]");
				((_003CPrivateImplementationDetails_003E.HitboxSnapshot)num3).CopyFrom(tick, dataTick, (_003CPrivateImplementationDetails_003E.HitboxSnapshot)0);
				Tick = tick;
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal void PosUpdateRefit()
	{
		BVH bVH = BVH;
		bVH.PosUpdateRefit();
	}

	internal void Add(HitboxRoot root, LagCompensationStatisticsManager lagCompStatManager)
	{
		//IL_0046: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I
		_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
		if (_buffer != null)
		{
			bool flag = _head < buffer.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_00b2;
			}
			object obj2 = _buffer + _head;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+20]");
				((_003CPrivateImplementationDetails_003E.HitboxSnapshot)0).Add(root, lagCompStatManager);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00b2;
		IL_00b2:
		throw new IndexOutOfRangeException();
	}

	internal bool Remove(HitboxRoot root)
	{
		//IL_00c4: Expected I4, but got Obj
		//IL_0046: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I
		_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
		if (_buffer != null)
		{
			bool flag = _head < buffer.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_00b6;
			}
			object obj2 = _buffer + _head;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+20]");
				return ((_003CPrivateImplementationDetails_003E.HitboxSnapshot)0).Remove(root);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00b6;
		IL_00b6:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void Update(HitboxRoot root, LagCompensationStatisticsManager lagCompStatManager)
	{
		//IL_0046: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
		if (_buffer != null)
		{
			bool flag = _head < buffer.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_009f;
			}
			object obj2 = _buffer + _head;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				throw new ArgumentNullException();
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_009f;
		IL_009f:
		throw new IndexOutOfRangeException();
	}

	internal bool PerformQuery(Query query, List<HitboxHit> hits)
	{
		//IL_01d2: Expected I4, but got Obj
		//IL_0191: Expected Obj, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected I4, but got Unknown
		//IL_009c: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		object obj;
		HashSet<int> colliderCandidates2;
		if (_colliderCandidates != null)
		{
			_colliderCandidates.Clear();
			ArgumentNullException ex = new ArgumentNullException();
			HashSet<int> colliderCandidates = _colliderCandidates;
			if (_colliderCandidates != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X2_v3 (System.Collections.Generic.HashSet`1<System.Int32>)+20]");
				if ((nint)0 < (nint)1)
				{
					obj = 0;
					goto IL_022c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30B766C");
				if (query != null)
				{
					nint num = (nint)query;
					colliderCandidates2 = _colliderCandidates;
					((object)query).Finalize();
					object obj2 = default;
					if (obj2 != null)
					{
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v9+12E]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v9+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0170;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v9+98]");
						object obj6 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v8-8]");
							if (0 == (nint)obj4)
							{
								break;
							}
							obj5--;
							obj6 += 16;
							if ((nint)obj5 != 1)
							{
								continue;
							}
							goto IL_0170;
						}
						object obj7 = obj6 + 4;
						object obj8 = obj3 + obj7;
						object obj9 = obj8 + 312;
						goto IL_0215;
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		colliderCandidates2 = (HashSet<int>)4;
		goto IL_0215;
		IL_0215:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v251 @ X0_v13] (should have been resolved before IL gen)");
		object obj10 = default;
		obj = obj10;
		goto IL_022c;
		IL_022c:
		return (byte)(obj & 1) != 0;
	}

	internal unsafe void PositionQueryInternal(ref PositionRotationQueryParams param, out Vector3 position, out Quaternion rotation)
	{
		//IL_017e: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_005c: Expected VT, but got Ref
		//IL_0065: Invalid comparison between VT and I4
		//IL_0087: Expected VT, but got Ref
		//IL_0090: Invalid comparison between VT and I4
		//IL_00ae: Expected Ref, but got VT
		//IL_00d9: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [param @ X1 (Fusion.LagCompensation.PositionRotationQueryParams&)+10]");
		GetClosestSnapshotForTick(0, out var _);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [param @ X1 (Fusion.LagCompensation.PositionRotationQueryParams&)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30B706C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
		object obj2 = param & 4;
		HitboxCollider from = default;
		if (obj2 != null)
		{
			int? num = (int?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref param, 20));
			if (num != (object)0)
			{
				float? num2 = (float?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref param, 28));
				if (num2 != (object)0)
				{
					int value = ((int?*)num)->Value;
					GetClosestSnapshotForTick(value, out var _);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30B706C");
					float value2 = ((float?*)num2)->Value;
					ref HitboxCollider to = default;
					HitboxCollider.Lerp(ref from, ref to, value2, ref from);
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj3 = default;
		ref Vector3 reference = ref *(Vector3*)obj3;
		Matrix4x4 localToWorld = from.LocalToWorld;
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		object obj4 = default;
		ref Quaternion reference2 = ref *(Quaternion*)obj4;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void InitColliderCandidatesForNarrowPhase(IHitboxColliderContainer container, HashSet<int> candidates)
	{
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Ref, but got Unknown
		//IL_03e0: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0076: Expected I, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Ref, but got VT
		//IL_00c1: Expected Obj, but got I
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Invalid comparison between Unknown and I4
		HashSet<int> hashSet = default;
		bool flag = hashSet == null;
		HashSet<int> hashSet3 = default;
		HashSet<int> hashSet2 = hashSet3;
		Enumerator val = (Enumerator)0;
		object obj = 109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65D8]");
			obj = 0;
			Enumerator enumerator = hashSet.GetEnumerator();
			Enumerator val2 = (Enumerator)(ref val);
			bool flag3 = default;
			Enumerator val3 = default;
			object obj13 = default;
			HitboxCollider hitboxCollider = default;
			object obj9;
			Enumerator val4;
			Enumerator val5;
			IHitboxColliderContainer hitboxColliderContainer = default;
			while (true)
			{
				if (val.MoveNext())
				{
					if (hitboxColliderContainer == null)
					{
						break;
					}
					nint num = (nint)hitboxColliderContainer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v14 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
					val2 = (Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v14 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v14 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
						object obj4 = (nint)0 + (nint)8;
						bool flag2 = flag3;
						object obj6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X10_v10-8]");
							object obj5 = 0 - obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X10_v10-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v14 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
							val2 = (Enumerator)(-1);
							obj5 = val2 - 1;
							bool flag4 = obj5 == null;
							obj6 = obj4 + 16;
							flag3 = (int)val2 != 1;
							flag2 = flag3;
							obj4 = obj6;
							if (flag3)
							{
								continue;
							}
							goto IL_0146;
						}
						val2 = (Enumerator)(obj4 + 2);
						object obj7 = num + val2;
						object obj8 = obj7 + 312;
						flag3 = flag2;
						obj6 = obj4;
						goto IL_0373;
					}
					goto IL_0146;
				}
				hashSet2 = null;
				val = val3;
				obj9 = 0;
				val4 = val3;
				val5 = (Enumerator)(ref val);
				object obj10 = 0;
				while (true)
				{
					hitboxColliderContainer = (IHitboxColliderContainer)obj;
					((Enumerator*)val5)->Dispose();
					bool flag5 = obj10 == null;
					object obj11 = !flag5;
					if (obj11 == null)
					{
						bool flag6 = hashSet2 == null;
						object obj12 = !flag6;
						OutOfMemoryException ex = (OutOfMemoryException)val5;
						if (obj12 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)hitboxColliderContainer == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						hashSet2 = (HashSet<int>)1;
						obj10 = obj9;
						continue;
					}
					if ((nint)hitboxColliderContainer != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj10 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj9 = obj13;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A50E0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
				IL_0146:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0373;
				IL_0373:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v354 @ X0_v28] (should have been resolved before IL gen)");
				((HitboxCollider*)hitboxCollider)->InitNarrowData();
			}
			NullReferenceException ex2 = new NullReferenceException();
			hashSet2 = null;
			val = val3;
			obj9 = 0;
			val4 = val3;
			val5 = (Enumerator)(ref val);
			hitboxColliderContainer = (IHitboxColliderContainer)obj2;
		}
		throw new NullReferenceException();
	}

	internal static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		Vector3 forward = default;
		Vector3 upwards = default;
		return Quaternion.Internal_LookRotation(ref forward, ref upwards);
	}

	private unsafe void GetClosestSnapshotForTick(int tick, out _003CPrivateImplementationDetails_003E.HitboxSnapshot snapshot)
	{
		//IL_0b69: Expected Obj, but got I
		//IL_0b78: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_062e: Expected Obj, but got I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0c21: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_0bd1: Expected Obj, but got I
		//IL_0be1: Expected Obj, but got I
		//IL_0682: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0c48: Expected Obj, but got I
		//IL_0c58: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Ref, but got Unknown
		//IL_0275: Expected Obj, but got I
		//IL_06fd: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected Obj, but got Unknown
		//IL_0781: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_02b3: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_0375: Expected I, but got Obj
		//IL_0385: Expected I4, but got Obj
		//IL_0843: Expected Obj, but got I8
		//IL_07e8: Expected I, but got Obj
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I4
		//IL_03ec: Expected I, but got Obj
		//IL_03fc: Expected I4, but got Obj
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_087e: Expected Obj, but got I4
		//IL_0435: Expected I, but got Obj
		//IL_0445: Expected I4, but got Obj
		//IL_0949: Expected Obj, but got I4
		//IL_0959: Expected Obj, but got I4
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected Obj, but got Unknown
		//IL_047d: Expected I, but got Obj
		//IL_08e6: Expected I, but got Obj
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04ef: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_0a4b: Expected Obj, but got I8
		//IL_053d: Expected I, but got Obj
		//IL_09f0: Expected I, but got Obj
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected Obj, but got Unknown
		//IL_0aa0: Expected Obj, but got I
		//IL_0ac6: Expected Obj, but got I
		//IL_0afa: Expected I4, but got Obj
		//IL_0584: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I4
		//IL_05f6: Expected I, but got Obj
		//IL_060c: Expected I, but got Obj
		//IL_0619: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		int num = default;
		object obj2 = num - Tick;
		_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = _buffer;
		int num2;
		object obj24 = default;
		object obj33 = default;
		object obj41;
		ref _003CPrivateImplementationDetails_003E.HitboxSnapshot reference;
		if ((nint)obj2 >= 1)
		{
			bool flag = _buffer == null;
			num2 = num;
			if (flag)
			{
				goto IL_0b1f;
			}
			bool flag2 = _head < buffer.Length;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				object obj4 = _buffer + _head;
				goto IL_0b9f;
			}
		}
		else
		{
			bool flag3 = _buffer == null;
			num2 = num;
			if (flag3)
			{
				goto IL_0b1f;
			}
			object obj5 = 1 - buffer.Length;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj6;
				if (_advanced < buffer.Length)
				{
					obj6 = 1;
				}
				else
				{
					object obj7 = _head + 1;
					object obj8 = obj7 / buffer.Length;
					object obj9 = obj8 * buffer.Length;
					obj6 = obj7 - obj9;
				}
				bool flag4 = (nint)obj6 < buffer.Length;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					object obj4 = (object)_buffer + obj6;
					goto IL_0b9f;
				}
			}
			else
			{
				object obj11 = obj2 + buffer.Length;
				object obj12 = obj11 + _head;
				object obj13 = obj12 / buffer.Length;
				object obj14 = obj13 * buffer.Length;
				object obj15 = obj12 - obj14;
				bool flag5 = (nint)obj15 < buffer.Length;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					object obj17 = (object)_buffer + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v35+20]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v35+20]");
					reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					_003CPrivateImplementationDetails_003E.HitboxSnapshot hitboxSnapshot = reference;
					if ((object)reference != null)
					{
						if (hitboxSnapshot.Tick == num)
						{
							return;
						}
						_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer2 = _buffer;
						if (_buffer != null)
						{
							object obj18 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X9_v9+A0]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X9_v10+18]");
							bool flag6 = (nint)0 == 0;
							ref _003CPrivateImplementationDetails_003E.HitboxSnapshot reference2 = ref reference;
							if (!flag6)
							{
								ref bool flag7 = ref *(bool*)(this + 44);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X9_v10+18]");
								LogStream logStream = ((LogStream)0).Once(ref flag7);
								bool flag8 = logStream == null;
								reference2 = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)null;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6618]");
									object provider = 0;
									nint num3 = (nint)logStream;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X9_v16 (Il2CppClass<Fusion.LogStream>)+1A0]");
									reference2 = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)null;
									byte b = ((Enum)(object)logStream).System_002EIConvertible_002EToByte((IFormatProvider)provider);
								}
							}
							object obj20 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v40+A0]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v41+D8]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v41+D8]");
							if ((nint)0 == 0)
							{
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							bool flag9 = (object)reference == null;
							reference = ref reference2;
							num2 = (int)(&obj24);
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6608]");
								object format = 0;
								object obj25 = default;
								object obj26 = default;
								string text = string.Format((string)format, obj25, obj26);
								_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer3 = _buffer;
								bool flag10 = _buffer == null;
								nint num4 = unchecked((nint)null);
								reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)obj26;
								num2 = (int)obj25;
								if (!flag10)
								{
									object obj27 = obj15 - 1;
									object obj28 = obj27 / buffer2.Length;
									object obj29 = obj28 * buffer2.Length;
									object obj30 = obj27 - obj29;
									bool flag11 = (nint)obj30 < buffer3.Length;
									object obj31 = !flag11;
									num4 = unchecked((nint)null);
									reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)obj26;
									num = (int)obj25;
									if (obj31 != null)
									{
										goto IL_0b35;
									}
									object obj32 = (object)_buffer + obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v48+20]");
									bool flag12 = (nint)0 == 0;
									num4 = unchecked((nint)null);
									reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)obj26;
									num2 = (int)obj25;
									if (!flag12)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer4 = _buffer;
										bool flag13 = _buffer == null;
										num4 = unchecked((nint)null);
										reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)obj26;
										num2 = (int)(&obj33);
										if (!flag13)
										{
											object obj34 = obj15 + 1;
											object obj35 = obj34 / buffer2.Length;
											object obj36 = obj35 * buffer2.Length;
											object obj37 = obj34 - obj36;
											bool flag14 = (nint)obj37 < buffer4.Length;
											object obj38 = !flag14;
											num4 = unchecked((nint)null);
											reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)obj26;
											num = (int)(&obj33);
											if (obj38 != null)
											{
												goto IL_0b35;
											}
											object obj39 = (object)_buffer + obj37;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v52+20]");
											bool flag15 = (nint)0 == 0;
											num4 = unchecked((nint)null);
											reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)obj26;
											num2 = (int)(&obj33);
											if (!flag15)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6600]");
												object format2 = 0;
												object arg = default;
												object arg2 = default;
												object obj40 = default;
												string text2 = string.Format((string)format2, arg, arg2, obj40);
												string text3 = text + text2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X23_v10+20]");
												obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X23_v10+20]");
												bool flag16 = (nint)0 == 0;
												object obj42 = !flag16;
												object obj43 = 0;
												nint num5 = (nint)obj40;
												if (obj42 != null)
												{
													goto IL_0b08;
												}
												num4 = (nint)obj40;
												reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)null;
												num2 = (int)text2;
											}
										}
									}
								}
							}
						}
					}
					goto IL_0b1f;
				}
			}
		}
		goto IL_0b35;
		IL_0b1f:
		NullReferenceException ex = new NullReferenceException();
		num = num2;
		goto IL_0b35;
		IL_0b9f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v6+20]");
		reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj44 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v7+A0]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v8+D8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v8+D8]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object[] array = default;
		bool flag17 = array == null;
		num2 = (int)(&obj24);
		if (flag17)
		{
			goto IL_0b1f;
		}
		int num6 = default;
		bool flag18 = num6 == 0;
		int num7 = (int)(&obj24);
		IndexOutOfRangeException ex2 = default;
		if (!flag18)
		{
			nint num8 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
			num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag19 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (flag19)
			{
				goto IL_0b43;
			}
		}
		bool flag20 = array.Length == 0;
		num = num7;
		if (!flag20)
		{
			object obj49 = array + 32;
			obj49 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag21 = (object)reference == null;
			num2 = num6;
			if (flag21)
			{
				goto IL_0b1f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			int num9 = default;
			bool flag22 = num9 == 0;
			object obj50 = default;
			int num10 = (int)(&obj50);
			if (!flag22)
			{
				nint num11 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag23 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
				num = 0;
				if (flag23)
				{
					goto IL_0b43;
				}
			}
			object obj51 = array.Length & 0xFFFFFFFEL;
			bool flag24 = obj51 == null;
			num = num10;
			if (!flag24)
			{
				object obj52 = array + 40;
				obj52 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag25 = _buffer == null;
				num2 = num9;
				if (flag25)
				{
					goto IL_0b1f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj53 = default;
				bool flag26 = obj53 == null;
				int num12 = (int)(&obj33);
				if (!flag26)
				{
					nint num13 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
					num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag27 = ex2 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag27)
					{
						goto IL_0b43;
					}
				}
				bool flag28 = array.Length < 2;
				object obj54 = !flag28;
				object obj55 = array.Length - 2;
				bool flag29 = obj55 == null;
				object obj56 = ~obj54;
				object obj57 = obj56 | flag29;
				num = num12;
				if (obj57 == null)
				{
					object obj58 = array + 48;
					obj58 = obj53;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj59 = default;
					bool flag30 = obj59 == null;
					object obj60 = default;
					int num14 = (int)(&obj60);
					if (!flag30)
					{
						nint num15 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
						num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag31 = ex2 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag31)
						{
							goto IL_0b43;
						}
					}
					object obj61 = array.Length & 0xFFFFFFFCL;
					bool flag32 = obj61 == null;
					num = num14;
					if (!flag32)
					{
						object obj62 = array + 56;
						obj62 = obj59;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6610]");
						object format3 = 0;
						string text3 = string.Format((string)format3, array);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X23_v5+18]");
						obj41 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X23_v5+18]");
						bool flag33 = (nint)0 == 0;
						object obj63 = default;
						object obj43 = obj63;
						nint num4 = default;
						nint num5 = num4;
						reference = ref *(_003CPrivateImplementationDetails_003E.HitboxSnapshot*)null;
						num2 = (int)array;
						if (!flag33)
						{
							goto IL_0b08;
						}
						goto IL_0b1f;
					}
				}
			}
		}
		goto IL_0b35;
		IL_0b35:
		ex2 = new IndexOutOfRangeException();
		goto IL_0b43;
		IL_0b43:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0b08:
		object obj64 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v481 @ X9_v7+198] (should have been resolved before IL gen)");
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void QueryBroadphase(Query query, HashSet<int> processedColliderIndices, out IHitboxColliderContainer container)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected VT, but got Unknown
		//IL_001d: Expected VT, but got I4
		//IL_0038: Expected Ref, but got VT
		//IL_007a: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected VT, but got Unknown
		//IL_00ae: Invalid comparison between VT and I4
		//IL_00d0: Invalid comparison between VT and I4
		//IL_00ed: Expected Ref, but got VT
		int closestTick = GetClosestTick(query);
		int? num = closestTick;
		int? num2 = (int?)(object)(query + 32);
		num2 = (int?)(object)0;
		((HashSet<System.__Canon>)(object)_broadphaseCandidates).Clear();
		int value = ((int?*)num2)->Value;
		GetClosestSnapshotForTick(value, out var snapshot);
		snapshot.QueryBroadphase(query, _broadphaseCandidates);
		object obj = query.Options & (HitOptions)4;
		HashSet<HitboxRoot> broadphaseCandidates;
		HashSet<int> processedColliderIndices2;
		IHitboxColliderContainer toContainer;
		IHitboxColliderContainer fromContainer;
		Query query2;
		if (obj != null)
		{
			int? num3 = (int?)(object)(query + 56);
			if (num3 != (object)0 && query.Alpha != (object)0)
			{
				int value2 = ((int?*)num3)->Value;
				GetClosestSnapshotForTick(value2, out var snapshot2);
				snapshot2.QueryBroadphase(query, _broadphaseCandidates);
				PreProcessingDelegate preProcessingDelegate = query.PreProcessingDelegate;
				if (query.PreProcessingDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v182.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				broadphaseCandidates = _broadphaseCandidates;
				processedColliderIndices2 = processedColliderIndices;
				toContainer = (IHitboxColliderContainer)snapshot2;
				fromContainer = (IHitboxColliderContainer)snapshot;
				query2 = query;
				goto IL_020e;
			}
		}
		PreProcessingDelegate preProcessingDelegate2 = query.PreProcessingDelegate;
		if (query.PreProcessingDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		broadphaseCandidates = _broadphaseCandidates;
		processedColliderIndices2 = processedColliderIndices;
		toContainer = null;
		fromContainer = (IHitboxColliderContainer)snapshot;
		query2 = query;
		goto IL_020e;
		IL_020e:
		_003CPrivateImplementationDetails_003E.HitboxSnapshot.ProcessBroadphaseRootCandidates(query2, fromContainer, broadphaseCandidates, processedColliderIndices2, toContainer);
		ref IHitboxColliderContainer reference = ref *(IHitboxColliderContainer*)snapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe int GetClosestTick(Query query)
	{
		//IL_02e3: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected VT, but got Unknown
		//IL_001d: Invalid comparison between VT and I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected VT, but got Unknown
		//IL_0236: Expected Ref, but got VT
		//IL_0044: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected VT, but got Unknown
		//IL_0083: Expected Ref, but got VT
		//IL_0090: Expected Ref, but got VT
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected VT, but got Unknown
		//IL_00b7: Expected Obj, but got I
		//IL_00c0: Expected Ref, but got VT
		//IL_00e1: Invalid comparison between F4 and I4
		//IL_00f0: Invalid comparison between F4 and I4
		//IL_0108: Expected Obj, but got F8
		//IL_0115: Expected Obj, but got F4
		//IL_014a: Expected Obj, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0309: Invalid comparison between F4 and I4
		//IL_032d: Expected Obj, but got I4
		//IL_0196: Expected F8, but got I4
		//IL_03af: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I4
		//IL_01ca: Invalid comparison between F8 and I4
		//IL_039f: Expected I4, but got F8
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0387: Expected Obj, but got I4
		double num9;
		double num10;
		if (query != null)
		{
			int? num = (int?)(object)(query + 56);
			if (num != (object)0)
			{
				object obj = query.Options & (HitOptions)4;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					int? num2 = (int?)(object)(query + 32);
					int value = ((int?*)num2)->Value;
					int value2 = ((int?*)num)->Value;
					float? num3 = (float?)(object)(query + 48);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D65F8]");
					object obj3 = 0;
					float value3 = ((float?*)num3)->Value;
					float num4 = value3 - 1f;
					bool flag2 = num4 < 0f;
					bool flag3 = num4 == 0f;
					object obj4 = (double)value3 ^ 1.0;
					object obj5 = value3 ^ num4;
					object obj6 = obj4 & obj5;
					bool flag4 = (nint)obj6 < 0;
					bool flag5 = flag2 == flag4;
					object obj7 = !flag5;
					object obj8 = obj7 | flag3;
					object obj9 = ~obj8;
					double num5 = ((obj9 != null) ? 1.0 : ((double)value3));
					double num6 = ((!(value3 < 0f)) ? num5 : 0.0);
					object obj10 = value2 - value;
					double num7 = (double)obj10 * num6;
					double num8 = num7 + (double)value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v11+E4]");
					bool flag6 = (nint)0 == 0;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					double num11 = default;
					if (num8 < 0.0)
					{
						if (num8 == -0.5)
						{
							num9 = -1.0;
							num10 = num11;
							goto IL_0350;
						}
						num10 = num8 + -0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					}
					else
					{
						if (num8 == 0.5)
						{
							num9 = 1.0;
							num10 = num11;
							goto IL_0350;
						}
						num10 = num8 + 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					}
					goto IL_039a;
				}
			}
			int? num12 = (int?)(object)(query + 32);
			return ((int?*)num12)->Value;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0350:
		double num13 = num10 + num9;
		object obj14 = num10 & 1;
		bool flag7 = obj14 == null;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			num10 = num13;
		}
		goto IL_039a;
		IL_039a:
		return (int)num10;
	}
}
