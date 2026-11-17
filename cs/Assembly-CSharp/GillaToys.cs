using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using GorillaLocomotion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class GillaToys : MonoBehaviour
{
	private sealed class Limited : TaskScheduler
	{
		internal readonly LinkedList<Task> queue;

		private readonly int most;

		private int draining;

		internal int busy;

		internal int done;

		internal int mostWaiting;

		internal double ms;

		internal double longest;

		public override int MaximumConcurrencyLevel => most;

		public Limited(int most)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_0050: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0B8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			LinkedList<System.__Canon> linkedList = default;
			linkedList._002Ector();
			object obj3 = this + 24;
			obj3 = linkedList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			base._002Ector();
			this.most = most;
		}

		protected unsafe override void QueueTask(Task task)
		{
			//IL_0318: Expected Obj, but got I4
			//IL_0321: Expected Obj, but got Ref
			//IL_032a: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I4
			//IL_00f6: Expected Obj, but got I4
			//IL_0107: Expected Obj, but got I4
			//IL_0295: Expected Obj, but got I4
			//IL_0363: Expected Obj, but got Ref
			//IL_00d2: Expected Obj, but got I4
			//IL_00e3: Expected Obj, but got I4
			//IL_02e4: Expected Obj, but got I4
			//IL_0146: Expected Obj, but got I4
			//IL_0122: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got I4
			//IL_01d9: Expected Obj, but got I
			//IL_01e9: Expected Obj, but got I
			//IL_0201: Expected I, but got Obj
			//IL_01bb: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.Enter(queue, ref lockTaken);
			bool flag = queue == null;
			NullReferenceException ex = null;
			object obj = 0;
			System.__Canon _Canon = (System.__Canon)(&lockTaken);
			object obj2 = 0;
			if (flag)
			{
				goto IL_0228;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0C8]");
			object obj3 = 0;
			obj2 = obj3;
			LinkedListNode<System.__Canon> linkedListNode = ((LinkedList<System.__Canon>)(object)queue).AddLast((System.__Canon)(object)task);
			LinkedList<Task> linkedList = queue;
			bool flag2 = queue == null;
			ex = null;
			obj = 0;
			_Canon = (System.__Canon)(object)task;
			if (flag2)
			{
				goto IL_0245;
			}
			if (linkedList.count > mostWaiting)
			{
				mostWaiting = linkedList.count;
			}
			object obj4;
			if (draining < most)
			{
				int num = draining + 1;
				draining = num;
				ex = null;
				obj = 0;
				_Canon = (System.__Canon)(object)task;
				obj4 = 5;
			}
			else
			{
				ex = null;
				obj = 0;
				_Canon = (System.__Canon)(object)task;
				obj4 = 4;
			}
			goto IL_035b;
			IL_0228:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0236;
			IL_0236:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0245;
			IL_0245:
			NullReferenceException ex3 = new NullReferenceException();
			if ((nint)_Canon == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj = 1;
			}
			else
			{
				if ((nint)_Canon != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj5 = default;
				ex = (NullReferenceException)obj5;
			}
			obj4 = 0;
			goto IL_035b;
			IL_035b:
			object obj6 = (object)(&lockTaken);
			if (obj6 != null)
			{
				object obj7 = default;
				int num2 = (int)(&obj7);
				Monitor.Exit(((int*)num2)->m_value);
				_Canon = null;
			}
			bool flag3 = ex == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				bool flag4 = obj == null;
				object obj9 = !flag4;
				ex2 = ex;
				if (obj9 == null)
				{
					if ((nint)obj4 != 5)
					{
						bool flag5 = obj4 == null;
						object obj10 = !flag5;
						if (obj10 != null)
						{
							return;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0D0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0C0]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					WaitCallback waitCallback = default;
					waitCallback._002Ector(this, (IntPtr)obj12);
					bool flag6 = ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
					return;
				}
				goto IL_0236;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			goto IL_0228;
		}

		private unsafe void Drain()
		{
			//IL_0010: Expected Obj, but got I
			//IL_03b9: Expected Obj, but got I
			//IL_03c9: Expected Obj, but got I
			//IL_0321: Expected Obj, but got Ref
			//IL_032a: Expected Obj, but got I4
			//IL_0332: Expected Obj, but got Ref
			//IL_00b7: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got Ref
			//IL_03ee: Expected Obj, but got Ref
			//IL_00eb: Expected Obj, but got Ref
			//IL_00f4: Expected Obj, but got I4
			//IL_0348: Expected Obj, but got Ref
			//IL_0351: Expected Obj, but got I4
			//IL_0359: Expected Obj, but got Ref
			//IL_00cc: Expected Obj, but got Ref
			//IL_00de: Expected Obj, but got I4
			//IL_0082: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60D0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Stopwatch stopwatch = default;
			stopwatch._002Ector();
			Task task = null;
			bool lockTaken = default;
			Monitor.Enter(queue, ref lockTaken);
			LinkedList<System.__Canon> linkedList = (LinkedList<System.__Canon>)(object)queue;
			if (queue != null)
			{
				object obj4;
				object obj5;
				NullReferenceException ex;
				if (linkedList.count != 0)
				{
					LinkedListNode<System.__Canon> head = linkedList.head;
					object obj6;
					if (linkedList.head == null)
					{
						ex = new NullReferenceException();
						obj4 = (object)(&lockTaken);
						obj5 = 0;
						obj6 = (object)(&lockTaken);
						goto IL_0470;
					}
					obj6 = obj2;
					((LinkedList<System.__Canon>)(object)queue).RemoveFirst();
					object obj7 = 5;
					task = (Task)(object)head.item;
				}
				else
				{
					int num = draining - 1;
					draining = num;
					object obj7 = 4;
					object obj6 = (object)(&lockTaken);
				}
				object obj8 = (object)(&lockTaken);
				if (obj8 != null)
				{
					object obj10 = default;
					object obj9 = (object)(&obj10);
					Monitor.Exit(obj9);
					object obj6 = 0;
				}
				obj4 = (object)(&lockTaken);
				obj5 = 0;
				OutOfMemoryException ex2 = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				ex = new NullReferenceException();
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
				object obj4 = (object)(&lockTaken);
				object obj5 = 0;
				object obj6 = (object)(&lockTaken);
			}
			goto IL_0470;
			IL_0470:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		}

		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			if (taskWasPreviouslyQueued)
			{
				base.Finalize();
				object obj2 = default;
				object obj = obj2 & 1;
				if (obj == null)
				{
					return false;
				}
			}
			return TryExecuteTask(task);
		}

		protected unsafe override bool TryDequeue(Task task)
		{
			//IL_01bf: Expected Obj, but got I4
			//IL_01c7: Expected Obj, but got Ref
			//IL_01d0: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_003e: Expected Obj, but got I4
			//IL_0209: Expected Obj, but got Ref
			//IL_0088: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got I4
			//IL_00b0: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.Enter(queue, ref lockTaken);
			bool flag = queue == null;
			NullReferenceException ex = null;
			object obj = 0;
			System.__Canon _Canon = (System.__Canon)(&lockTaken);
			object obj2 = 0;
			if (flag)
			{
				goto IL_00d9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0F0]");
			object obj3 = 0;
			obj2 = obj3;
			bool flag2 = ((LinkedList<System.__Canon>)(object)queue).Remove((System.__Canon)(object)task);
			ex = null;
			obj = 0;
			_Canon = (System.__Canon)(object)task;
			bool result = flag2;
			goto IL_0201;
			IL_00d9:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_00e7;
			IL_0201:
			object obj4 = (object)(&lockTaken);
			if (obj4 != null)
			{
				object obj6 = default;
				object obj5 = (object)(&obj6);
				Monitor.Exit(obj5);
				_Canon = null;
			}
			bool flag3 = ex == null;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				bool flag4 = obj == null;
				object obj8 = !flag4;
				ex2 = ex;
				if (obj8 == null)
				{
					return result;
				}
				goto IL_00e7;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			goto IL_00d9;
			IL_00e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)_Canon == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj = 1;
			}
			else
			{
				if ((nint)_Canon != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					bool result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj9 = default;
				ex = (NullReferenceException)obj9;
			}
			result = false;
			goto IL_0201;
		}

		protected unsafe override IEnumerable<Task> GetScheduledTasks()
		{
			//IL_0244: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got Ref
			//IL_0255: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_002f: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I
			//IL_005a: Expected Obj, but got I4
			//IL_006a: Expected Obj, but got I
			//IL_007f: Expected Obj, but got Ref
			//IL_00e1: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got Ref
			//IL_00bd: Expected Obj, but got I
			//IL_0109: Expected Obj, but got I4
			//IL_01c7: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.TryEnter(queue, ref lockTaken);
			bool flag = !lockTaken;
			ArgumentNullException ex = null;
			object obj = 0;
			IEnumerable<System.__Canon> enumerable = (IEnumerable<System.__Canon>)(&lockTaken);
			object obj2 = 0;
			List<System.__Canon> result;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA100]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0F8]");
				object obj4 = 0;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ stack_-18_v2+18]");
				List<System.__Canon> list = default;
				list._002Ector((IEnumerable<System.__Canon>)0);
				ex = null;
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ stack_-18_v2+18]");
				enumerable = (IEnumerable<System.__Canon>)0;
				result = list;
				goto IL_0077;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex2 = default;
			ex2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex3 = new ArgumentNullException();
			IEnumerable<System.__Canon> enumerable2 = default;
			enumerable = enumerable2;
			goto IL_0176;
			IL_0176:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)enumerable == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj = 1;
			}
			else
			{
				if ((nint)enumerable != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F544");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					IEnumerable<Task> result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj5 = default;
				ex = (ArgumentNullException)obj5;
			}
			result = null;
			goto IL_0077;
			IL_0077:
			object obj6 = (object)(&lockTaken);
			if (obj6 != null)
			{
				object obj8 = default;
				object obj7 = (object)(&obj8);
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v16+18]");
				Monitor.Exit(0);
				enumerable = null;
			}
			bool flag2 = ex == null;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				bool flag3 = obj == null;
				object obj11 = !flag3;
				ex3 = ex;
				if (obj11 == null)
				{
					return (IEnumerable<Task>)result;
				}
				goto IL_0176;
			}
			throw new OutOfMemoryException();
		}

		private void _003CQueueTask_003Eb__11_0(object _)
		{
			Drain();
		}
	}

	private static GillaToys you;

	private Player gt;

	private byte shown;

	private CosmeticToy toy;

	private Transform spine;

	private Quaternion rest;

	private int hand = -1;

	private int layer;

	private bool away;

	private float home = 0f;

	private float pop;

	private float hop = 1f;

	private Vector3 fromPos;

	private Vector3 hopFrom;

	private Quaternion fromRot;

	private SkinnedMeshRenderer body;

	public static int Held
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_00f1: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I4
			//IL_00be: Expected I4, but got I8
			//IL_0077: Expected Obj, but got I
			//IL_00d1: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
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
			if ((UnityEngine.Object)obj5 != null)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v6+A0]");
				object obj8 = 0;
				object obj9 = obj8;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v8+50]");
					return 0;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return -1;
		}
	}

	public static byte NetState
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0238: Expected Obj, but got I
			//IL_025a: Expected Obj, but got I4
			//IL_005c: Expected Obj, but got I4
			//IL_0082: Expected Obj, but got I
			//IL_0218: Expected I4, but got Obj
			//IL_00d1: Expected Obj, but got I4
			//IL_0100: Expected Obj, but got I
			//IL_0147: Expected Obj, but got I
			//IL_01da: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
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
			bool flag2 = (UnityEngine.Object)obj5 == null;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7+A0]");
				object obj9 = 0;
				object obj10 = obj9;
				if (obj9 != null)
				{
					object obj11 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v11+E4]");
					bool flag4 = (nint)0 == 0;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v9+30]");
					if ((UnityEngine.Object)0 == null)
					{
						goto IL_0121;
					}
					object obj13 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+A0]");
					object obj14 = 0;
					object obj15 = obj14;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v13+58]");
						if ((nint)0 != 0)
						{
							return 3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v13+50]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v13+50]");
							object obj16 = -1;
							bool flag5 = obj16 == null;
							return (byte)((flag5 ? 1u : 0u) << 1);
						}
						return 1;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex;
			}
			goto IL_0121;
			IL_0121:
			return 0;
		}
	}

	public static CosmeticToy Toy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_00e4: Expected Obj, but got I
			//IL_0106: Expected Obj, but got I4
			//IL_007c: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
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
			bool flag2 = (UnityEngine.Object)obj5 != null;
			bool flag3 = !flag2;
			CosmeticToy result = null;
			if (!flag3)
			{
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7+A0]");
				object obj8 = 0;
				object obj9 = obj8;
				if (obj8 == null)
				{
					return (CosmeticToy)(object)new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v9+30]");
				result = (CosmeticToy)0;
			}
			return result;
		}
	}

	private static void Boot()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4380]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA118]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction = default;
		unityAction._002Ector((object)null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction<Scene, Unity.IL2CPP.Metadata.__Il2CppInt32Enum> unityAction2 = default;
		unityAction2._002Ector((object)null, (IntPtr)obj2);
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction2;
		AttachToPlayer();
	}

	private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		AttachToPlayer();
	}

	public static void AttachToPlayer()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F50]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
		UnityEngine.Object obj5 = default;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA120]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj9 = default;
			if (obj9 == null)
			{
				GameObject gameObject = ((Component)obj5).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA128]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			}
		}
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CE0]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = this;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj6 = this + 32;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 == this)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+A0]");
			object obj8 = 0;
			obj8 = 0;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_09cb: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I4
		//IL_09e9: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_01d4: Expected VT, but got I4
		//IL_02fe: Expected I4, but got I8
		//IL_0318: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_0404: Expected I4, but got I8
		//IL_041e: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I
		//IL_06b1: Expected VT, but got I4
		//IL_02ca: Expected Obj, but got I4
		//IL_02d3: Expected VT, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_0a17: Expected Obj, but got I
		//IL_0a2f: Expected Obj, but got I
		//IL_0a3f: Expected F8, but got I
		//IL_0a4f: Expected F4, but got I
		//IL_070d: Invalid comparison between F4 and I4
		//IL_071c: Invalid comparison between F4 and I4
		//IL_0734: Expected Obj, but got F8
		//IL_0741: Expected Obj, but got F4
		//IL_0776: Expected Obj, but got I4
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_04a9: Expected Obj, but got I4
		//IL_084c: Expected Obj, but got I
		//IL_0899: Invalid comparison between F4 and I4
		//IL_08a8: Invalid comparison between F4 and I4
		//IL_08c0: Expected Obj, but got F8
		//IL_08cd: Expected Obj, but got F4
		//IL_0902: Expected Obj, but got I4
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_0ae3: Expected Obj, but got I4
		//IL_0b01: Expected Obj, but got I
		//IL_0b11: Expected Obj, but got I
		//IL_0b31: Expected Obj, but got I
		//IL_0b53: Expected Obj, but got I4
		//IL_0569: Invalid comparison between F4 and I4
		//IL_0578: Invalid comparison between F4 and I4
		//IL_0590: Expected Obj, but got F8
		//IL_059d: Expected Obj, but got F4
		//IL_05d2: Expected Obj, but got I4
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_0a94: Expected Obj, but got I4
		//IL_0974: Expected VT, but got I4
		//IL_07ff: Expected VT, but got I4
		//IL_0808: Expected VT, but got I4
		//IL_0625: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I4
		//IL_099c: Expected VT, but got I4
		//IL_0689: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b;
		if (MonsterPlayer.IsMonster)
		{
			b = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4668]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v81+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			byte b2 = Cosmetics.In((CosmeticSlot)7);
			b = b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj7 = 0;
		if (shown != b)
		{
			Make(b);
		}
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = toy == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isMonster = MonsterPlayer.IsMonster;
		bool flag7 = !isMonster;
		object obj13 = !flag7;
		object obj14 = 0;
		Vector3 velocity = (Vector3)0;
		if (obj13 != null)
		{
			goto IL_02ea;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj15 = 0;
		object obj16 = obj7;
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v50+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v72+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = (UnityEngine.Object)obj18 != null;
		bool flag10 = !flag9;
		object obj20 = 0;
		if (!flag10)
		{
			object obj21 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v52+A0]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v54+A9]");
			bool flag11 = (nint)0 == 0;
			obj14 = 0;
			velocity = (Vector3)0;
			obj20 = 0;
			if (!flag11)
			{
				goto IL_02ea;
			}
		}
		goto IL_036c;
		IL_02ea:
		int num = (int)(hand & 0x80000000L);
		bool flag12 = num == 0;
		object obj24 = !flag12;
		obj20 = obj14;
		if (obj24 == null)
		{
			CosmeticToy cosmeticToy = toy;
			bool flag13 = cosmeticToy.kind == (ToyKind)2;
			obj20 = obj14;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj25 = 0;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v47+A0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v48+4]");
				double num2 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v48+8]");
				float num3 = 0f;
				Release(hand, velocity);
				obj20 = obj14;
			}
		}
		goto IL_036c;
		IL_036c:
		Transform transform = toy.transform;
		if (~(away ? 1u : 0u) == 0)
		{
			return;
		}
		CosmeticToy cosmeticToy2 = toy;
		if (cosmeticToy2.kind == (ToyKind)2 && !KeepMonkey())
		{
			return;
		}
		int num4 = (int)(hand & 0x80000000L);
		bool flag14 = num4 == 0;
		object obj28 = !flag14;
		if (obj28 == null)
		{
			Transform transform2 = HandPose(hand);
			object obj29 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v34+E4]");
			bool flag15 = (nint)0 == 0;
			object obj30 = !flag15;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag16 = transform2 != null;
			bool flag17 = !flag16;
			object obj31 = 0;
			if (!flag17)
			{
				float palmSide = ((hand != 0) ? (-1f) : 1f);
				toy.PoseIn(transform2, palmSide);
				double num2 = 1.0;
				obj31 = 0;
			}
			if ((double)hop < 1.0)
			{
				float deltaTime = Time.deltaTime;
				float num5 = deltaTime + deltaTime;
				float num6 = hop + num5;
				float num7 = num6 - 1f;
				bool flag18 = num7 < 0f;
				bool flag19 = num7 == 0f;
				object obj32 = (double)num6 ^ 1.0;
				object obj33 = num6 ^ num7;
				object obj34 = obj32 & obj33;
				bool flag20 = (nint)obj34 < 0;
				bool flag21 = flag18 == flag20;
				object obj35 = !flag19;
				object obj36 = flag21 & obj35;
				object obj37 = ~obj36;
				if (obj37 == null)
				{
					num6 = 1f;
				}
				hop = num6;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
				object obj38 = 0;
				object obj39 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v56+E4]");
				bool flag22 = (nint)0 == 0;
				object obj40 = !flag22;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num8 = CosmeticToy.Elastic(hop);
				transform.position = (Vector3)0;
			}
			return;
		}
		bool flag23 = !((double)pop < 1.0);
		Vector3 vector = (Vector3)hand;
		if (!flag23)
		{
			float deltaTime2 = Time.deltaTime;
			float num9 = deltaTime2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
			float num10 = num9 / 0f;
			float num11 = pop + num10;
			float num12 = num11 - 1f;
			bool flag24 = num12 < 0f;
			bool flag25 = num12 == 0f;
			object obj41 = (double)num11 ^ 1.0;
			object obj42 = num11 ^ num12;
			object obj43 = obj41 & obj42;
			bool flag26 = (nint)obj43 < 0;
			bool flag27 = flag24 == flag26;
			object obj44 = !flag25;
			object obj45 = flag27 & obj44;
			object obj46 = ~obj45;
			float t = (pop = ((obj46 != null) ? num11 : 1f));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
			object obj48 = 0;
			object obj49 = obj47;
			object obj50 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v31+A0]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v39+E4]");
			bool flag28 = (nint)0 == 0;
			object obj52 = !flag28;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num13 = CosmeticToy.Elastic(t);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v32+14]");
			float num3 = 0f * num13;
			transform.localScale = (Vector3)0;
			vector = (Vector3)0;
		}
		if ((double)home < 1.0)
		{
			float deltaTime3 = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4868]");
			object obj53 = 0;
			float num14 = deltaTime3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			float num15 = num14 / 0f;
			object obj54 = obj53;
			float num16 = home + num15;
			float num17 = num16 - 1f;
			bool flag29 = num17 < 0f;
			bool flag30 = num17 == 0f;
			object obj55 = (double)num16 ^ 1.0;
			object obj56 = num16 ^ num17;
			object obj57 = obj55 & obj56;
			bool flag31 = (nint)obj57 < 0;
			bool flag32 = flag29 == flag31;
			object obj58 = !flag30;
			object obj59 = flag32 & obj58;
			object obj60 = ~obj59;
			float t2 = (home = ((obj60 != null) ? num16 : 1f));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v25+E4]");
			bool flag33 = (nint)0 == 0;
			object obj61 = !flag33;
			if (obj61 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float t3 = CosmeticToy.Elastic(t2);
			transform.localPosition = (Vector3)0;
			Quaternion a = default;
			Quaternion b3 = default;
			Quaternion quaternion = Quaternion.Internal_SlerpUnclamped(ref a, ref b3, t3);
			transform.localRotation = (Quaternion)0;
		}
	}

	private bool KeepMonkey()
	{
		//IL_0010: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_01b8: Expected Obj, but got I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected I4, but got Unknown
		//IL_0070: Expected I4, but got I8
		//IL_008a: Expected Obj, but got I4
		//IL_0244: Expected I4, but got Obj
		//IL_0111: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected I4, but got Unknown
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
		bool flag2 = gt == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj7;
		if (obj4 == null)
		{
			int num = (int)(hand & 0x80000000L);
			bool flag4 = num == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				bool flag5 = _003CKeepMonkey_003Eg__Gone_007C28_0(hand);
				int num2 = hand;
				if (flag5)
				{
					int h = 1 - hand;
					bool flag6 = _003CKeepMonkey_003Eg__Gone_007C28_0(h);
					num2 = hand;
					bool flag7 = !flag6;
					object obj6 = !flag7;
					if (obj6 == null)
					{
						num2 = (hand = 1 - num2);
						hop = 1f;
					}
				}
				bool flag8 = _003CKeepMonkey_003Eg__Gone_007C28_0(num2);
				if ((object)toy != null)
				{
					GameObject gameObject = toy.gameObject;
					if ((object)gameObject != null)
					{
						bool activeSelf = gameObject.activeSelf;
						if (flag8 != activeSelf)
						{
							obj7 = (flag8 ? 1 : 0) ^ 1;
							goto IL_02a9;
						}
						if ((object)toy != null)
						{
							GameObject gameObject2 = toy.gameObject;
							if ((object)gameObject2 != null)
							{
								obj7 = (flag8 ? 1 : 0) ^ 1;
								bool active = (byte)(obj7 & 1) != 0;
								gameObject2.SetActive(active);
								goto IL_02a9;
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		obj7 = 1;
		goto IL_02a9;
		IL_02a9:
		return (byte)(obj7 & 1) != 0;
	}

	public static bool TryTake(int h, Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_09fb: Expected Obj, but got I
		//IL_0a1d: Expected Obj, but got I4
		//IL_0062: Expected VT, but got I4
		//IL_0200: Expected Obj, but got I
		//IL_0222: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I
		//IL_09db: Expected I4, but got Obj
		//IL_00d4: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_0127: Expected VT, but got I4
		//IL_02dc: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I4
		//IL_01be: Expected VT, but got I4
		//IL_03be: Expected Obj, but got I8
		//IL_01e3: Expected VT, but got I4
		//IL_03f0: Invalid comparison between I and F8
		//IL_0414: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I
		//IL_053e: Expected Obj, but got I
		//IL_0585: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0667: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		//IL_06d1: Invalid comparison between F8 and I
		//IL_06fb: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I4
		//IL_0a5b: Expected F4, but got I
		//IL_0a77: Expected Obj, but got I
		//IL_07f8: Expected Obj, but got I
		//IL_082f: Expected Obj, but got I
		//IL_0864: Expected Obj, but got I
		//IL_086d: Expected Obj, but got I4
		//IL_0b2a: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I
		//IL_08cc: Expected Obj, but got I
		//IL_0ada: Expected Obj, but got I
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected Obj, but got Unknown
		//IL_0907: Expected Obj, but got I
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected Obj, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected Obj, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected Obj, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 != null;
		object obj7 = obj;
		bool flag3 = !flag2;
		Vector3 vector = (Vector3)0;
		UnityEngine.Object obj8 = null;
		if (flag3)
		{
			goto IL_01e8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+A0]");
		object obj9 = 0;
		object obj10 = obj9;
		if (obj9 != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v60+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v53+30]");
			bool flag5 = (UnityEngine.Object)0 != null;
			obj7 = obj;
			bool flag6 = !flag5;
			vector = (Vector3)0;
			obj8 = null;
			if (flag6)
			{
				goto IL_01e8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+A0]");
			object obj13 = 0;
			GillaToys gillaToys = (GillaToys)obj13;
			if (obj13 != null)
			{
				CosmeticToy cosmeticToy = gillaToys.toy;
				if ((object)gillaToys.toy != null)
				{
					bool flag7 = cosmeticToy.kind != (ToyKind)2;
					vector = (Vector3)0;
					obj8 = null;
					if (flag7)
					{
						goto IL_01e8;
					}
					((GillaToys)obj13).HopTo(h, (Vector3)0);
					goto IL_09a3;
				}
			}
		}
		goto IL_09bf;
		IL_09bf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_09cd;
		IL_01e8:
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+A0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = (UnityEngine.Object)obj15 == null;
		bool flag10 = !flag9;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v12+A0]");
			object obj19 = 0;
			object obj20 = obj19;
			if (obj19 == null)
			{
				goto IL_09bf;
			}
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v18+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v14+30]");
			bool flag12 = (UnityEngine.Object)0 == null;
			bool flag13 = !flag12;
			object obj23 = !flag13;
			if (obj23 == null)
			{
				object obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v15+A0]");
				object obj25 = 0;
				object obj26 = obj25;
				if (obj25 == null)
				{
					goto IL_09bf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+58]");
				bool flag14 = (nint)0 == 0;
				object obj27 = !flag14;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+50]");
					object obj28 = 0 & 0x80000000L;
					if (obj28 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+5C]");
						if (!(0.0 < 0.5))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
							object obj29 = 0;
							object obj30 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v22+E4]");
							bool flag15 = (nint)0 == 0;
							object obj31 = !flag15;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool isMonster = MonsterPlayer.IsMonster;
							bool flag16 = !isMonster;
							object obj32 = !flag16;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
								object obj33 = 0;
								object obj34 = obj2;
								object obj35 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v21+A0]");
								object obj36 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v26+E4]");
								bool flag17 = (nint)0 == 0;
								object obj37 = !flag17;
								if (obj37 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if ((UnityEngine.Object)obj36 != null)
								{
									object obj38 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v48+A0]");
									object obj39 = 0;
									object obj40 = obj39;
									if (obj39 == null)
									{
										goto IL_09bf;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v50+A9]");
									bool flag18 = (nint)0 == 0;
									object obj41 = !flag18;
									if (obj41 != null)
									{
										goto IL_09a3;
									}
								}
								object obj42 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v24+A0]");
								object obj43 = 0;
								object obj44 = obj43;
								if (obj43 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v26+30]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v26+30]");
										Vector3 grabPoint = ((CosmeticToy)0).GrabPoint;
										object obj45 = default;
										double num = 0.5 - (double)obj45;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+5C]");
										object obj47 = default;
										object obj46 = 0 - obj47;
										object obj49 = default;
										object obj48 = obj49 - obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
										object obj50 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v27+A0]");
										object obj51 = 0;
										object obj52 = obj51;
										if (obj51 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v29+30]");
											Component component = (Component)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v29+30]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v34 (UnityEngine.Component)+38]");
												if (num > 0.0)
												{
													goto IL_09a3;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v29+30]");
												Transform transform = ((Component)0).transform;
												object obj53 = obj;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v30+A0]");
												object obj54 = 0;
												if (obj54 != null)
												{
													Transform parent = ((Component)obj54).transform;
													if ((object)transform != null)
													{
														transform.SetParent(parent, worldPositionStays: true);
														bool flag19 = h == 0;
														object obj55 = !flag19;
														object obj56 = ~obj55;
														XRNode node = ((obj56 != null) ? ((XRNode)4) : ((XRNode)5));
														InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
														InputDevice inputDevice = default;
														bool flag20 = inputDevice.SendHapticImpulse(0u, 0.5f, 0f);
														object obj57 = obj;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v35+A0]");
														object obj58 = 0;
														object obj59 = obj58;
														if (obj58 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v37+30]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA148]");
																object obj60 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F73C");
																object obj61 = default;
																if (obj61 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v44+18]");
																	object obj62 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v44+18]");
																	if ((nint)0 >= (nint)1)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA138]");
																		object obj63 = 0;
																		object obj64 = 0;
																		while (true)
																		{
																			bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62);
																			object obj65 = !flag21;
																			if (obj65 != null)
																			{
																				break;
																			}
																			object obj66 = obj61 + obj64;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v42+20]");
																			object obj67 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v42+20]");
																			if ((nint)0 == 0)
																			{
																				goto IL_09bf;
																			}
																			object obj68 = obj67;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v43+12E]");
																			object obj69 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v43+12E]");
																			if ((nint)0 == 0)
																			{
																				goto IL_0950;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v43+98]");
																			object obj70 = (nint)0 + (nint)8;
																			object obj71;
																			while (true)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X10_v9-8]");
																				if (0 == (nint)obj63)
																				{
																					break;
																				}
																				obj69--;
																				obj71 = obj70 + 16;
																				bool flag22 = (nint)obj69 != 1;
																				obj70 = obj71;
																				if (flag22)
																				{
																					continue;
																				}
																				goto IL_0950;
																			}
																			object obj72 = obj70 + 1;
																			object obj73 = obj68 + obj72;
																			object obj74 = obj73 + 312;
																			obj71 = obj70;
																			goto IL_0ac0;
																			IL_0ac0:
																			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v639 @ X0_v47] (should have been resolved before IL gen)");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v44+18]");
																			obj62 = 0;
																			obj64++;
																			object obj75 = obj64;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v44+18]");
																			if ((nint)obj75 >= 0)
																			{
																				return true;
																			}
																			continue;
																			IL_0950:
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
																			goto IL_0ac0;
																		}
																		goto IL_09cd;
																	}
																	return true;
																}
															}
														}
													}
												}
											}
										}
									}
								}
								goto IL_09bf;
							}
						}
					}
				}
			}
		}
		goto IL_09a3;
		IL_09a3:
		return false;
		IL_09cd:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void HopTo(int h, Vector3 at)
	{
		//IL_017e: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I4
		//IL_00b8: Expected VT, but got Obj
		//IL_00d2: Invalid comparison between VT and I
		//IL_0134: Expected Obj, but got I4
		//IL_0202: Expected F4, but got I
		if (hand != h)
		{
			Vector3 grabPoint = toy.GrabPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Component component = toy;
			object obj5 = default;
			object obj4 = obj5 - obj5;
			object obj7 = default;
			object obj6 = obj7 - obj7;
			object obj9 = default;
			object obj8 = obj9 - obj9;
			object obj10 = obj4 * obj4;
			object obj11 = obj6 * obj6;
			object obj12 = obj10 + obj11;
			object obj13 = obj8 * obj8;
			Vector3 vector = (Vector3)(obj13 + obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9 (UnityEngine.Component)+38]");
			if (vector <= (object)0)
			{
				hand = h;
				hop = 0f;
				Transform transform = component.transform;
				Vector3 position = transform.position;
				bool flag2 = h == 0;
				object obj14 = !flag2;
				object obj15 = ~obj14;
				XRNode node = ((obj15 != null) ? ((XRNode)4) : ((XRNode)5));
				hopFrom = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9 (UnityEngine.Component)+38]");
				_ = 0;
				InputDevice deviceAtXRNode = InputDevices.GetDeviceAtXRNode(node);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
				InputDevice inputDevice = default;
				bool flag3 = inputDevice.SendHapticImpulse(0u, 0.5f, 0f);
			}
		}
	}

	public static bool HeldIn(int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0208: Expected I4, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_018a: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj5 != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v7+A0]");
			object obj8 = 0;
			object obj9 = obj8;
			if (obj8 != null)
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9+30]");
				if (!((UnityEngine.Object)0 != null))
				{
					goto IL_01ec;
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v11+A0]");
				object obj13 = 0;
				object obj14 = obj13;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+50]");
					if ((nint)0 != h)
					{
						goto IL_01ec;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+30]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v14+20]");
						object obj16 = -2;
						bool flag3 = obj16 == null;
						return !flag3;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_01ec;
		IL_01ec:
		return false;
	}

	public static void Release(int h, Vector3 velocity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I4
		//IL_024d: Expected Obj, but got I4
		//IL_0256: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I4
		//IL_0278: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got I
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v6+A0]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj21;
		if (obj9 != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+30]");
			bool flag5 = (UnityEngine.Object)0 == null;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			if (obj13 != null)
			{
				return;
			}
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v11+A0]");
			object obj15 = 0;
			object obj16 = obj15;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+50]");
				if ((nint)0 != h)
				{
					return;
				}
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+30]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA148]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F73C");
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v16+18]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v16+18]");
						object obj22;
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA138]");
							object obj20 = 0;
							obj21 = 0;
							obj22 = 0;
							object obj23 = 0;
							object obj34 = default;
							while (true)
							{
								bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
								object obj24 = !flag7;
								if (obj24 != null)
								{
									break;
								}
								object obj25 = obj18 + obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v22+20]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v22+20]");
								if ((nint)0 == 0)
								{
									goto IL_045b;
								}
								object obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+12E]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0339;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v23+98]");
								object obj29 = (nint)0 + (nint)8;
								object obj30;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v9-8]");
									if (0 == (nint)obj20)
									{
										break;
									}
									obj28--;
									obj30 = obj29 + 16;
									bool flag8 = (nint)obj28 != 1;
									obj29 = obj30;
									if (flag8)
									{
										continue;
									}
									goto IL_0339;
								}
								object obj31 = obj29 + 2;
								object obj32 = obj27 + obj31;
								object obj33 = obj32 + 312;
								obj30 = obj29;
								goto IL_04e4;
								IL_04e4:
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v443 @ X0_v22] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v16+18]");
								obj19 = 0;
								obj23++;
								obj21 |= obj34;
								object obj35 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v16+18]");
								if ((nint)obj35 < 0)
								{
									continue;
								}
								goto IL_053d;
								IL_0339:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
								obj22 = 2;
								goto IL_04e4;
							}
							goto IL_0469;
						}
						obj21 = 0;
						obj22 = 0;
						goto IL_053d;
					}
				}
			}
		}
		goto IL_045b;
		IL_045b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0469;
		IL_0469:
		throw new IndexOutOfRangeException();
		IL_053d:
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v18+A0]");
		object obj37 = 0;
		GillaToys gillaToys = (GillaToys)obj37;
		object obj38 = obj21 & 1;
		if (obj38 != null)
		{
			if (obj37 != null)
			{
				gillaToys.away = true;
				if ((object)gillaToys.toy != null)
				{
					GameObject gameObject = gillaToys.toy.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: false);
						return;
					}
				}
			}
		}
		else if (obj37 != null)
		{
			((GillaToys)obj37).GoHome(false);
			return;
		}
		goto IL_045b;
	}

	public static void Back()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_012c: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA110]");
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
		bool flag2 = (UnityEngine.Object)obj5 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6+A0]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v8+30]");
		bool flag5 = (UnityEngine.Object)0 == null;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+A0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v12+58]");
			if ((nint)0 != 0)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v12+30]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: true);
				object obj17 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v13+A0]");
				object obj18 = 0;
				((GillaToys)obj18).GoHome(true);
			}
		}
	}

	private void GoHome(bool popIn)
	{
		//IL_0015: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0156: Expected VT, but got I4
		//IL_0164: Expected VT, but got I4
		//IL_0176: Expected F4, but got I
		//IL_0189: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Transform transform = toy.transform;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (spine == null)
		{
			Transform parent = base.transform;
			transform.SetParent(parent, worldPositionStays: true);
			return;
		}
		transform.SetParent(spine, worldPositionStays: true);
		if (!popIn)
		{
			Vector3 localPosition = transform.localPosition;
			Vector3 vector = default;
			fromPos = vector;
			Quaternion localRotation = transform.localRotation;
			fromRot = (Quaternion)vector;
			home = 0f;
		}
		else
		{
			transform.localPosition = (Vector3)0;
			transform.localRotation = (Quaternion)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B3F8]");
			home = 0f;
			transform.localScale = (Vector3)0;
		}
	}

	private void Make(byte id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected Obj, but got Unknown
		//IL_09f4: Expected Obj, but got I4
		//IL_00fc: Expected I4, but got I8
		//IL_0160: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I4
		//IL_04f3: Expected VT, but got I4
		//IL_0515: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I4
		//IL_05b5: Expected VT, but got I4
		//IL_05fc: Expected VT, but got I4
		//IL_060c: Expected Obj, but got I
		//IL_0650: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_068c: Expected Obj, but got I4
		//IL_0789: Expected Obj, but got I
		//IL_0a1b: Expected Obj, but got I4
		//IL_07be: Expected Obj, but got I
		//IL_07c7: Expected Obj, but got I4
		//IL_0ab2: Expected Obj, but got I4
		//IL_06c7: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_0707: Expected Obj, but got I
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_0734: Expected Obj, but got I4
		//IL_0826: Expected Obj, but got I
		//IL_08bd: Expected Obj, but got I4
		//IL_0a67: Expected Obj, but got I
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected Obj, but got Unknown
		//IL_0861: Expected Obj, but got I
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			if (obj3 == null)
			{
				goto IL_09a5;
			}
			GameObject obj5 = ((Component)obj3).gameObject;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj5);
		}
		toy = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int id2 = id & 0xFF;
		hand = -1;
		away = false;
		CosmeticCatalog.Entry entry = CosmeticCatalog.Of(id2);
		if (entry == null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = entry.prefab == null;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null || entry.slot != (CosmeticSlot)7)
		{
			return;
		}
		FindBody();
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = body == null;
		bool flag8 = !flag7;
		object obj13 = !flag8;
		if (obj13 != null)
		{
			return;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v25+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (spine == null)
		{
			return;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v29+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4640]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDA38");
		UnityEngine.Object obj20 = default;
		if ((object)entry.prefab != null)
		{
			string text = entry.prefab.name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA140]");
			object obj19 = 0;
			string text2 = text + (string)obj19;
			if ((object)obj20 != null)
			{
				obj20.name = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4938]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				object obj22 = default;
				obj3 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((UnityEngine.Object)obj3 == null)
				{
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v84+E4]");
					bool flag11 = (nint)0 == 0;
					object obj24 = !flag11;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj20);
					return;
				}
				Transform transform = ((GameObject)obj20).transform;
				if ((object)transform != null)
				{
					transform.SetParent(spine, worldPositionStays: false);
					Transform transform2 = ((GameObject)obj20).transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
					if ((object)transform2 != null)
					{
						transform2.localPosition = (Vector3)0;
						Transform transform3 = ((GameObject)obj20).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4870]");
						object obj25 = 0;
						object obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v23+E4]");
						bool flag12 = (nint)0 == 0;
						object obj27 = !flag12;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Quaternion quaternion = CosmeticWearer.OnBone(body, spine);
						Quaternion quaternion2 = default;
						rest = quaternion2;
						if ((object)transform3 != null)
						{
							transform3.localRotation = (Quaternion)0;
							Transform transform4 = ((GameObject)obj20).transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DDA8AC");
							if ((object)transform4 != null)
							{
								transform4.localScale = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B28]");
								object obj28 = 0;
								object obj29 = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
								object obj30 = default;
								if (obj30 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v62+18]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v62+18]");
									if ((nint)0 < (nint)1)
									{
										goto IL_0742;
									}
									object obj32 = obj30 + 32;
									object obj33 = 0;
									while (true)
									{
										bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
										object obj34 = !flag13;
										if (obj34 != null)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X23_v13+v187 @ X22_v18*8]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X23_v13+v187 @ X22_v18*8]");
											GameObject gameObject = ((Component)0).gameObject;
											if ((object)gameObject != null)
											{
												gameObject.layer = layer;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v62+18]");
												obj31 = 0;
												obj33++;
												object obj35 = obj33;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v62+18]");
												bool flag14 = (nint)obj35 < 0;
												obj29 = 0;
												if (flag14)
												{
													continue;
												}
												goto IL_0742;
											}
										}
										goto IL_09a5;
									}
									goto IL_09b3;
								}
							}
						}
					}
				}
			}
		}
		goto IL_09a5;
		IL_09b3:
		throw new IndexOutOfRangeException();
		IL_08ea:
		CosmeticToy cosmeticToy = toy;
		hop = 1f;
		home = 0f;
		if ((object)toy != null)
		{
			if (cosmeticToy.kind != (ToyKind)2)
			{
				return;
			}
			hand = 0;
			Transform transform5 = ((GameObject)obj20).transform;
			Transform parent = base.transform;
			if ((object)transform5 != null)
			{
				transform5.SetParent(parent, worldPositionStays: true);
				return;
			}
		}
		goto IL_09a5;
		IL_0742:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA130]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36266D0");
		object obj37 = default;
		if (obj37 == null)
		{
			goto IL_09a5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v65+18]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v65+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_08ea;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA138]");
		object obj39 = 0;
		object obj40 = 0;
		while (true)
		{
			bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38);
			object obj41 = !flag15;
			if (obj41 != null)
			{
				break;
			}
			object obj42 = obj37 + obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v35+20]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v35+20]");
			if ((nint)0 == 0)
			{
				goto IL_09a5;
			}
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v36+12E]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v36+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08aa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v36+98]");
			object obj46 = (nint)0 + (nint)8;
			object obj47;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X10_v10-8]");
				if (0 == (nint)obj39)
				{
					break;
				}
				obj45--;
				obj47 = obj46 + 16;
				bool flag16 = (nint)obj45 != 1;
				obj46 = obj47;
				if (flag16)
				{
					continue;
				}
				goto IL_08aa;
			}
			object obj48 = obj44 + obj46;
			object obj49 = obj48 + 312;
			obj47 = obj46;
			goto IL_0a4d;
			IL_0a4d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v658 @ X0_v73] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v65+18]");
			obj38 = 0;
			obj40++;
			object obj50 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v65+18]");
			if ((nint)obj50 < 0)
			{
				continue;
			}
			goto IL_08ea;
			IL_08aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			object obj29 = 0;
			goto IL_0a4d;
		}
		goto IL_09b3;
		IL_09a5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_09b3;
	}

	private void FindBody()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_082f: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_0868: Expected Obj, but got I4
		//IL_09d3: Expected Obj, but got I
		//IL_09e3: Expected Obj, but got I
		//IL_0a05: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I8
		//IL_0240: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_09ad: Expected Obj, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I4
		//IL_0886: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I
		//IL_08b8: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I
		//IL_0440: Expected Obj, but got I4
		//IL_03c8: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I
		//IL_08de: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_0909: Expected I, but got Obj
		//IL_0927: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I4
		//IL_0986: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I
		//IL_050c: Expected Obj, but got I
		//IL_06d8: Expected Obj, but got I
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected Obj, but got Unknown
		//IL_06f6: Expected Obj, but got I
		//IL_054d: Expected Obj, but got I8
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_0564: Expected Obj, but got I4
		//IL_095f: Expected Obj, but got I4
		//IL_05a0: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I4
		//IL_067c: Expected Obj, but got I4
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_06aa: Expected Obj, but got I
		//IL_060f: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I4
		//IL_065c: Expected Obj, but got I4
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected Obj, but got Unknown
		//IL_07a8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj6;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v11+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v2+8]");
		UnityEngine.Object obj13 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v2+8]");
		bool flag7 = (UnityEngine.Object)0 == null;
		bool flag8 = !flag7;
		object obj15 = !flag8;
		if (obj15 != null)
		{
			return;
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X21_v6 (UnityEngine.Object)+68]");
		UnityEngine.Object obj17 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = obj17 == null;
		bool flag11 = !flag10;
		object obj19 = !flag11;
		if (obj19 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X21_v6 (UnityEngine.Object)+68]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12+20]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12+20]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X26_v7+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X26_v7+18]");
		object obj22 = 0 & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA158]");
		object obj23 = 0;
		object obj24 = 0;
		object obj25 = 0;
		UnityEngine.Object obj26 = null;
		object obj39 = default;
		Predicate<System.__Canon> predicate2 = default;
		object obj53 = default;
		while (true)
		{
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
			object obj27 = !flag12;
			if (obj27 != null)
			{
				break;
			}
			object obj28 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12+20]");
			object obj29 = 0 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v17+20]");
			UnityEngine.Object obj30 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v24+E4]");
			bool flag13 = (nint)0 == 0;
			object obj31 = !flag13;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v17+20]");
			bool flag14 = (UnityEngine.Object)0 == null;
			bool flag15 = !flag14;
			object obj32 = !flag15;
			obj25 = 0;
			obj26 = null;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X21_v10 (UnityEngine.Object)+20]");
				obj17 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X21_v10 (UnityEngine.Object)+20]");
				bool flag16 = (nint)0 == 0;
				obj25 = 0;
				obj26 = null;
				if (!flag16)
				{
					object obj33 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v30+E4]");
					bool flag17 = (nint)0 == 0;
					object obj34 = !flag17;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj33 = obj23;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v30+A0]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v40+8]");
					Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v40+8]");
					bool flag18 = (nint)0 == 0;
					object obj36 = !flag18;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v30+E4]");
						bool flag19 = (nint)0 == 0;
						object obj37 = !flag19;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj38 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v46+A0]");
							obj35 = 0;
						}
						obj39 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DA8]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA150]");
						object obj41 = 0;
						predicate2._002Ector(obj35, (IntPtr)obj41);
						object obj42 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v45+A0]");
						object obj43 = (nint)0 + (nint)8;
						obj43 = predicate2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						predicate = predicate2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D68]");
					object obj44 = 0;
					obj25 = obj44;
					bool flag20 = Array.Exists((System.__Canon[])(object)obj17, predicate);
					bool flag21 = !flag20;
					object obj45 = !flag21;
					obj26 = (UnityEngine.Object)(object)predicate;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
						object obj46 = 0;
						obj25 = obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+18]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+18]");
						bool flag22 = (nint)0 < (nint)1;
						obj26 = (UnityEngine.Object)1;
						if (!flag22)
						{
							object obj48 = obj39;
							object obj49 = 0;
							object obj50 = obj46;
							while (true)
							{
								bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47);
								object obj51 = !flag23;
								if (obj51 != null)
								{
									break;
								}
								object obj52 = obj53 + obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v29+20]");
								obj17 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v29+20]");
								Transform[] bones = ((SkinnedMeshRenderer)0).bones;
								bool flag24 = bones.Length < 1;
								obj26 = null;
								if (!flag24)
								{
									object obj54 = bones.Length & 0xFFFFFFFFL;
									object obj55 = bones + 32;
									object obj56 = 0;
									object obj57 = obj50;
									UnityEngine.Object obj58 = null;
									while (true)
									{
										bool flag25 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54);
										object obj59 = !flag25;
										if (obj59 != null)
										{
											break;
										}
										object obj60 = obj;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v41+E4]");
										bool flag26 = (nint)0 == 0;
										object obj61 = !flag26;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X26_v11+v114 @ X29_v14*8]");
										bool flag27 = (UnityEngine.Object)0 != null;
										bool flag28 = !flag27;
										obj50 = 0;
										obj26 = null;
										if (!flag28)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X26_v11+v114 @ X29_v14*8]");
											string text = ((UnityEngine.Object)0).name;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
											object obj62 = 0;
											bool flag29 = text == (string)obj62;
											bool flag30 = !flag29;
											object obj63 = !flag30;
											obj50 = 0;
											obj26 = (UnityEngine.Object)obj62;
											if (obj63 != null)
											{
												body = (SkinnedMeshRenderer)obj17;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												object obj64 = this + 56;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X26_v11+v114 @ X29_v14*8]");
												obj64 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												GameObject gameObject = ((Component)obj17).gameObject;
												int num = gameObject.layer;
												layer = num;
												return;
											}
										}
										obj54 = bones.Length;
										obj56++;
										bool flag31 = (nint)obj56 < bones.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X26_v11+v114 @ X29_v14*8]");
										obj48 = 0;
										obj57 = obj50;
										obj58 = obj26;
										if (flag31)
										{
											continue;
										}
										goto IL_06c8;
									}
									break;
								}
								goto IL_06c8;
								IL_06c8:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+18]");
								obj47 = 0;
								object obj65 = obj49 + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA158]");
								obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v35+18]");
								bool flag32 = (nint)obj65 < 0;
								obj39 = obj48;
								obj25 = obj50;
								obj49 = obj65;
								if (flag32)
								{
									continue;
								}
								goto IL_0732;
							}
							break;
						}
					}
				}
			}
			goto IL_0732;
			IL_0732:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X26_v7+18]");
			obj22 = 0;
			obj24++;
			object obj66 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X26_v7+18]");
			if ((nint)obj66 >= 0)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private Transform HandPose(int h)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_01e4: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
		object obj10;
		Transform result;
		if ((UnityEngine.Object)0 != null)
		{
			if (h != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
				if ((nint)0 == 0)
				{
					goto IL_021d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
				obj10 = (nint)0 + (nint)64;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
				if ((nint)0 == 0)
				{
					goto IL_021d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X9_v1+8]");
				obj10 = (nint)0 + (nint)56;
			}
		}
		else
		{
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = gt != null;
			bool flag6 = !flag5;
			result = null;
			if (flag6)
			{
				goto IL_02b8;
			}
			if (h != 0)
			{
				if ((object)gt == null)
				{
					goto IL_021d;
				}
				obj10 = gt + 56;
			}
			else
			{
				if ((object)gt == null)
				{
					goto IL_021d;
				}
				obj10 = gt + 48;
			}
		}
		result = (Transform)obj10;
		goto IL_02b8;
		IL_02b8:
		return result;
		IL_021d:
		return (Transform)(object)new NullReferenceException();
	}

	public GillaToys()
	{
		//IL_000f: Expected I4, but got I8
	}

	private bool _003CKeepMonkey_003Eg__Gone_007C28_0(int h)
	{
		//IL_0062: Expected I4, but got Obj
		//IL_002d: Expected Obj, but got I4
		if ((object)gt != null)
		{
			object obj = h - 1;
			bool right = obj == null;
			return gt.HandOff(right);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
