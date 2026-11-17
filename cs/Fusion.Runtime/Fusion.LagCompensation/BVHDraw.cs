using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.UIElements;

namespace Fusion.LagCompensation;

public class BVHDraw : Action<_0021_00210, object>, _0021_00210
{
	private sealed class _003CGetEnumerator_003Ed__2 : Action<ShiftAuth.Outcome>, _0021_00210, Action<TextElement.GlyphsEnumerable>
	{
		private int _003C_003E1__state;

		private ColliderDrawInfo _003C_003E2__current;

		public HitboxColliderContainerDraw _003C_003E4__this;

		private int _003Ci_003E5__1;

		private ColliderDrawInfo System_002ECollections_002EGeneric_002EIEnumerator_003CFusion_002ELagCompensation_002EColliderDrawInfo_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
			//IL_000f: Expected I4, but got I8
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			//IL_00eb: Expected I4, but got I8
			//IL_003b: Expected Obj, but got I4
			//IL_02d9: Expected I4, but got Obj
			//IL_0062: Expected I4, but got I8
			//IL_01fb: Expected Obj, but got I4
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_0196: Expected Obj, but got I4
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected Obj, but got Unknown
			int num;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_021a;
				}
				HitboxColliderContainerDraw hitboxColliderContainerDraw = _003C_003E4__this;
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this == null || hitboxColliderContainerDraw._drawInfo == null)
				{
					goto IL_02cb;
				}
				object obj2 = hitboxColliderContainerDraw._drawInfo + 24;
				obj2 = hitboxColliderContainerDraw._container;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num = 1;
				goto IL_02d9;
			}
			_003C_003E1__state = -1;
			goto IL_01a4;
			IL_02d9:
			HitboxColliderContainerDraw hitboxColliderContainerDraw2 = _003C_003E4__this;
			_003Ci_003E5__1 = num;
			if ((object)_003C_003E4__this != null)
			{
				_003CPrivateImplementationDetails_003E.HitboxSnapshot container = hitboxColliderContainerDraw2._container;
				if ((object)hitboxColliderContainerDraw2._container != null)
				{
					object obj3 = container._collidersCount - 1;
					if (num > (nint)obj3)
					{
						goto IL_021a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30B706C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+68]");
					if ((nint)0 == 0)
					{
						goto IL_01a4;
					}
					HitboxColliderContainerDraw hitboxColliderContainerDraw3 = _003C_003E4__this;
					if ((object)_003C_003E4__this != null && (object)hitboxColliderContainerDraw3._container != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30B706C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+80]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							goto IL_01a4;
						}
						HitboxColliderContainerDraw hitboxColliderContainerDraw4 = _003C_003E4__this;
						if ((object)_003C_003E4__this != null)
						{
							ColliderDrawInfo drawInfo = hitboxColliderContainerDraw4._drawInfo;
							if (hitboxColliderContainerDraw4._drawInfo != null)
							{
								object obj5 = this + 24;
								obj5 = hitboxColliderContainerDraw4._drawInfo;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X19_v4+10]");
								drawInfo.Index = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								_ = 1;
								return true;
							}
						}
					}
				}
			}
			goto IL_02cb;
			IL_02cb:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_021a:
			return false;
			IL_01a4:
			num = _003Ci_003E5__1 + 1;
			goto IL_02d9;
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

	internal HitboxBuffer _buffer;

	private BVHNodeDrawInfo _drawInfo;

	private Stack<BVHNode> _reusableStack;

	internal BVHDraw(HitboxBuffer buffer)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D64A0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D64B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Stack<BVHNode> stack = default;
		stack._002Ector();
		object obj3 = this + 32;
		obj3 = stack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		object obj4 = this + 16;
		obj4 = buffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj5 = default;
		obj5._002Ector();
		object obj6 = obj5 + 16;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = this + 24;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public IEnumerator<BVHNodeDrawInfo> GetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D64F0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator<BVHNodeDrawInfo>)obj2;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return (IEnumerator)GetEnumerator();
	}
}
