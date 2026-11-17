using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

namespace Fusion.LagCompensation;

public class HitboxColliderContainerDraw : _0021_00210, Action<TextElement.GlyphsEnumerable>
{
	private sealed class _003CGetEnumerator_003Ed__3 : _0021_00210, Action<Record<>>, _0021_00210
	{
		private int _003C_003E1__state;

		private HitboxColliderContainerDraw _003C_003E2__current;

		public SnapshotHistoryDraw _003C_003E4__this;

		private int _003Ci_003E5__1;

		private HitboxColliderContainerDraw System_002ECollections_002EGeneric_002EIEnumerator_003CFusion_002ELagCompensation_002EHitboxColliderContainerDraw_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CGetEnumerator_003Ed__3(int _003C_003E1__state)
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
			//IL_007f: Expected I4, but got I8
			//IL_0043: Expected Obj, but got I4
			//IL_027d: Expected I4, but got Obj
			//IL_006b: Expected I4, but got I8
			//IL_0117: Expected Obj, but got I4
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected Obj, but got Unknown
			//IL_0244: Expected Obj, but got I4
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected Obj, but got Unknown
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected Obj, but got Unknown
			//IL_019d: Expected Obj, but got I
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			int num = _003C_003E1__state;
			if (_003C_003E1__state != 1)
			{
				bool flag = num == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0253;
				}
				_003Ci_003E5__1 = 0;
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				num = ++_003Ci_003E5__1;
			}
			SnapshotHistoryDraw snapshotHistoryDraw = _003C_003E4__this;
			if ((object)_003C_003E4__this != null)
			{
				HitboxBuffer buffer = snapshotHistoryDraw._buffer;
				if (snapshotHistoryDraw._buffer != null)
				{
					_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer2 = buffer._buffer;
					if (buffer._buffer != null)
					{
						bool flag2 = num < buffer2.Length;
						object obj2 = !flag2;
						if (num < buffer2.Length)
						{
							if (obj2 != null)
							{
								goto IL_026f;
							}
							if ((object)snapshotHistoryDraw._containerDraw != null)
							{
								object obj3 = buffer._buffer + num;
								object obj4 = snapshotHistoryDraw._containerDraw + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+20]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								SnapshotHistoryDraw snapshotHistoryDraw2 = _003C_003E4__this;
								if ((object)_003C_003E4__this != null)
								{
									object obj5 = this + 24;
									obj5 = snapshotHistoryDraw2._containerDraw;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_ = 1;
									return true;
								}
							}
						}
						else if ((object)snapshotHistoryDraw._containerDraw != null)
						{
							object obj6 = snapshotHistoryDraw._containerDraw + 16;
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							goto IL_0253;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_026f;
			IL_0253:
			return false;
			IL_026f:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
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

	internal _003CPrivateImplementationDetails_003E.HitboxSnapshot _container;

	private ColliderDrawInfo _drawInfo;

	public IEnumerator<ColliderDrawInfo> GetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D64D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator<ColliderDrawInfo>)obj2;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return (IEnumerator)GetEnumerator();
	}

	public HitboxColliderContainerDraw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D64B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = this + 24;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
