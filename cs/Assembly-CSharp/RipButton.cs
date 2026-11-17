using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class RipButton : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003CLeave_003Ed__180 : _0021_00210
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NetworkRunner r;

		public string what;

		private Task _003Cdone_003E5__2;

		private TaskAwaiter<Task> _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0c0c: Expected Obj, but got I
			//IL_0486: Expected VT, but got I4
			//IL_0495: Expected I4, but got I8
			//IL_0c3b: Expected Obj, but got I
			//IL_0c5b: Expected Obj, but got Ref
			//IL_04b4: Expected Obj, but got I
			//IL_04ce: Expected Obj, but got I
			//IL_004d: Expected Obj, but got Ref
			//IL_059d: Expected Obj, but got I4
			//IL_05a5: Expected Obj, but got I4
			//IL_04fa: Expected Obj, but got I
			//IL_0524: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0096: Expected Obj, but got I4
			//IL_0735: Expected Obj, but got I4
			//IL_0748: Expected Obj, but got I4
			//IL_07f8: Expected I, but got Obj
			//IL_0764: Expected I4, but got I8
			//IL_076f: Expected VT, but got Ref
			//IL_0791: Expected Obj, but got I4
			//IL_05cd: Expected Obj, but got I4
			//IL_00c7: Expected I, but got Obj
			//IL_089a: Expected Obj, but got I4
			//IL_07b7: Expected Ref, but got VT
			//IL_082e: Expected Obj, but got I
			//IL_0833: Expected I, but got Obj
			//IL_0170: Expected Obj, but got I
			//IL_0179: Expected Obj, but got I4
			//IL_060c: Expected Obj, but got I4
			//IL_0854: Expected Obj, but got I4
			//IL_00f5: Expected I, but got Obj
			//IL_0127: Expected Obj, but got I4
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_01af: Expected Obj, but got I
			//IL_01c9: Expected Obj, but got I
			//IL_01f3: Expected Obj, but got I4
			//IL_0622: Expected I, but got Obj
			//IL_0632: Expected Obj, but got I
			//IL_0232: Expected I, but got Obj
			//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e8: Expected Obj, but got Unknown
			//IL_02c6: Expected I4, but got I8
			//IL_02e2: Expected Obj, but got I4
			//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac0: Expected Obj, but got Unknown
			//IL_0a47: Expected Obj, but got I4
			//IL_0673: Expected Obj, but got I4
			//IL_0683: Expected Obj, but got I
			//IL_0693: Expected Obj, but got I
			//IL_06c6: Expected Obj, but got I
			//IL_06f0: Expected Obj, but got I4
			//IL_0248: Expected I, but got Obj
			//IL_0282: Expected Obj, but got I4
			//IL_0b8f: Expected Obj, but got I4
			//IL_0915: Expected Obj, but got Ref
			//IL_0923: Unknown result type (might be due to invalid IL or missing references)
			//IL_0928: Expected Obj, but got Unknown
			//IL_071f: Expected Obj, but got I4
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected Obj, but got Unknown
			//IL_0ae5: Expected Obj, but got Ref
			//IL_0b03: Expected I4, but got I8
			//IL_0b0e: Expected VT, but got Ref
			//IL_034b: Expected I, but got Obj
			//IL_0354: Expected Obj, but got I4
			//IL_036b: Expected I, but got Obj
			//IL_0b3f: Expected Obj, but got I4
			//IL_0957: Expected I, but got Obj
			//IL_0b69: Expected Ref, but got VT
			//IL_09c9: Expected Obj, but got I4
			//IL_03b4: Expected Obj, but got I4
			//IL_03cd: Expected Obj, but got I4
			//IL_09ff: Expected Obj, but got I
			//IL_0a08: Expected Obj, but got I4
			//IL_0a21: Expected Obj, but got I4
			//IL_0403: Expected Obj, but got Ref
			//IL_040b: Expected Obj, but got VT
			//IL_043f: Expected Obj, but got I4
			//IL_0468: Expected VT, but got Ref
			//IL_0476: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			nint num = default;
			nint num2;
			TaskAwaiter<System.__Canon> taskAwaiter;
			bool flag2 = default;
			ShutdownReason shutdownReason = default;
			object obj3;
			NullReferenceException ex = default;
			nint num4;
			ArgumentNullException ex2 = default;
			Task task2 = default;
			nint num6;
			if (_003C_003E1__state != 0)
			{
				if ((object)r != null)
				{
					Task task = r.Shutdown(destroyGameObject: true, (ShutdownReason)0, forceShutdownProcedure: false);
					task2 = (Task)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
					task2 = task;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE438]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Task[] array = default;
					bool flag = array == null;
					obj3 = 0;
					flag2 = false;
					shutdownReason = (ShutdownReason)0;
					num = 2;
					if (!flag)
					{
						num2 = (nint)task2;
						bool flag3 = task2 == null;
						num = 2;
						if (!flag3)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v72 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							flag = ex == null;
							obj3 = 0;
							flag2 = false;
							shutdownReason = (ShutdownReason)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v72 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
							num4 = 0;
							if (flag)
							{
								goto IL_0813;
							}
						}
						flag = array.Length == 0;
						task2 = (Task)num2;
						obj3 = 0;
						flag2 = false;
						shutdownReason = (ShutdownReason)0;
						if (flag)
						{
							goto IL_07d9;
						}
						object obj4 = array + 32;
						obj4 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
						object obj5 = 0;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v117+E4]");
						bool flag4 = (nint)0 == 0;
						object obj7 = !flag4;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Task task3 = Task.Delay(10000);
						bool flag5 = task3 == null;
						num = unchecked((nint)null);
						if (!flag5)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v71 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							flag = ex2 == null;
							task2 = task3;
							obj3 = 0;
							flag2 = false;
							shutdownReason = (ShutdownReason)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v71 (Il2CppClass<System.Threading.Tasks.Task[]>)+40]");
							num6 = 0;
							if (flag)
							{
								goto IL_0838;
							}
						}
						flag = (byte)(array.Length & 0xFFFFFFFEL) != 0;
						bool flag6 = !flag;
						task2 = task3;
						obj3 = 0;
						flag2 = false;
						shutdownReason = (ShutdownReason)0;
						if (flag6)
						{
							goto IL_07e7;
						}
						object obj8 = array + 40;
						obj8 = task3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Task<Task> task4 = Task.WhenAny(array);
						flag = task4 == null;
						num2 = (nint)task3;
						obj3 = 0;
						flag2 = false;
						shutdownReason = (ShutdownReason)0;
						num = unchecked((nint)null);
						if (flag)
						{
							goto IL_07fd;
						}
						TaskAwaiter<System.__Canon> awaiter = ((Task<System.__Canon>)(object)task4).GetAwaiter();
						TaskAwaiter<System.__Canon> awaiter2 = default;
						bool isCompleted = awaiter2.IsCompleted;
						bool flag7 = !isCompleted;
						object obj9 = !flag7;
						taskAwaiter = awaiter2;
						task2 = task3;
						obj3 = 0;
						flag2 = false;
						shutdownReason = (ShutdownReason)0;
						if (obj9 == null)
						{
							_003C_003E1__state = 0;
							object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 56));
							obj10 = awaiter2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj11 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v133+E4]");
							bool flag8 = (nint)0 == 0;
							object obj12 = !flag8;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
							((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted<TaskAwaiter<System.__Canon>, _003CLeave_003Ed__180>(ref awaiter2, ref this);
							return;
						}
						goto IL_0c2b;
					}
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
				}
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_07d9;
			}
			_003C_003Eu__1 = (TaskAwaiter<Task>)0;
			_003C_003E1__state = -1;
			taskAwaiter = (TaskAwaiter<System.__Canon>)_003C_003Eu__1;
			goto IL_0c2b;
			IL_074d:
			object obj13 = obj;
			_003C_003E1__state = -2;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v88+E4]");
			bool flag9 = (nint)0 == 0;
			object obj14 = !flag9;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
			return;
			IL_0c2b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE410]");
			object obj15 = 0;
			object obj16 = obj15;
			System.__Canon result = taskAwaiter.GetResult();
			object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
			string text;
			string text2;
			if (result != obj17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE590]");
				object format = 0;
				object obj19 = default;
				string message = string.Format((string)format, what, obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj20 = 0;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v23+E4]");
				bool flag10 = (nint)0 == 0;
				object obj22 = !flag10;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				text = null;
				text2 = (string)obj19;
			}
			else
			{
				if (result == null)
				{
					goto IL_0859;
				}
				bool isFaulted = ((Task)(object)result).IsFaulted;
				bool flag11 = !isFaulted;
				text = (string)flag2;
				text2 = (string)shutdownReason;
				if (!flag11)
				{
					bool flag = _003Cdone_003E5__2 == null;
					obj16 = 0;
					if (flag)
					{
						goto IL_0867;
					}
					AggregateException exception = _003Cdone_003E5__2.Exception;
					flag = exception == null;
					task2 = (Task)(object)what;
					obj16 = 0;
					if (flag)
					{
						goto IL_0875;
					}
					nint num7 = (nint)exception;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v9 (Il2CppClass<System.AggregateException>)+1B0]");
					obj16 = 0;
					string stackTrace = exception.StackTrace;
					flag = stackTrace == null;
					task2 = (Task)(object)what;
					if (flag)
					{
						goto IL_0883;
					}
					string text3 = (string)((ValueType)stackTrace).GetHashCode();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDA40]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE588]");
					object obj24 = 0;
					text2 = (string)obj24;
					string message2 = (string)obj23 + what + (string)obj24 + text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj25 = 0;
					object obj26 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v15+E4]");
					bool flag12 = (nint)0 == 0;
					object obj27 = !flag12;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message2);
					obj3 = 0;
					text = text3;
				}
			}
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj28 = 0;
			goto IL_074d;
			IL_0883:
			NullReferenceException ex5 = new NullReferenceException();
			object obj29 = 0;
			NullReferenceException ex6 = ex5;
			object obj32 = default;
			object obj34 = default;
			object obj37 = default;
			object obj40 = default;
			object obj42 = default;
			NullReferenceException ex8 = default;
			NullReferenceException ex9 = default;
			while (true)
			{
				bool flag13 = (nint)obj16 != 1;
				object obj30 = obj29;
				if (!flag13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj31 = obj32;
					obj16 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj33 = obj34 & 1;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
						object obj35 = obj32;
						obj16 = 101789696 + 1224;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
						shutdownReason = (ShutdownReason)0;
						goto IL_0baf;
					}
					task2 = (Task)obj32;
					object obj36 = (object)(&obj37);
					object obj38 = obj29 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					if (obj32 != null)
					{
						break;
					}
					NullReferenceException ex7 = new NullReferenceException();
					obj30 = obj38;
					ex6 = ex7;
				}
				if ((nint)obj16 != 1)
				{
					goto IL_0bce;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				object obj39 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
				object obj41 = obj42 & 1;
				if (obj41 != null)
				{
					object obj43 = (object)(&obj37);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					_003C_003E1__state = -2;
					AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v43+E4]");
					bool flag14 = (nint)0 == 0;
					object obj44 = !flag14;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->SetException((Exception)obj40);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
				object obj45 = obj40;
				obj16 = 101789696 + 1224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
				obj29 = obj30;
				shutdownReason = (ShutdownReason)0;
				goto IL_0baf;
				IL_0bce:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				obj29 = obj30;
				ex6 = ex8;
				continue;
				IL_0baf:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj30 = obj29;
				ex6 = ex9;
				goto IL_0bce;
			}
			nint num8 = (nint)task2;
			string encodingName = ((Encoding)obj32).EncodingName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string text4 = default;
			string text5 = default;
			string message3 = text4 + what + text5 + encodingName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X0_v76+E4]");
			bool flag15 = (nint)0 == 0;
			object obj46 = !flag15;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			obj = 0;
			obj3 = 0;
			text = encodingName;
			text2 = text5;
			obj28 = 0;
			goto IL_074d;
			IL_07e7:
			IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
			num2 = (nint)task2;
			goto IL_07fd;
			IL_0859:
			NullReferenceException ex11 = new NullReferenceException();
			goto IL_0867;
			IL_07fd:
			ex = new NullReferenceException();
			num4 = num;
			goto IL_0813;
			IL_0838:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex12 = new ArgumentNullException();
			obj16 = 0;
			goto IL_0859;
			IL_0813:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ex2 = new ArgumentNullException();
			task2 = (Task)num2;
			num6 = unchecked((nint)null);
			goto IL_0838;
			IL_07d9:
			IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
			goto IL_07e7;
			IL_0867:
			NullReferenceException ex14 = new NullReferenceException();
			goto IL_0875;
			IL_0875:
			NullReferenceException ex15 = new NullReferenceException();
			goto IL_0883;
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0067: Expected Obj, but got I4
			//IL_002f: Expected VT, but got Ref
			//IL_003c: Expected Ref, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE2F8]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}
	}

	public ScreenFont.Action action;

	public DismemberGroup group;

	public Transform[] hands;

	public float radius = 0.13f;

	private float cooldown;

	private Vector3 baseScale;

	private void Start()
	{
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		Vector3 vector = default;
		baseScale = vector;
	}

	private void Update()
	{
		//IL_0078: Invalid comparison between F8 and I4
		//IL_0087: Expected F8, but got I4
		//IL_015c: Expected VT, but got I4
		//IL_0171: Invalid comparison between F4 and I4
		//IL_0195: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I8
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I4
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_049b: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I
		float deltaTime = Time.deltaTime;
		float num = (cooldown -= deltaTime);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		if ((object)transform2 != null)
		{
			Vector3 localScale = transform2.localScale;
			float deltaTime2 = Time.deltaTime;
			float num2 = deltaTime2 * -10f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFD0");
			double num3 = 1.0 - (double)num2;
			bool flag = num3 < 0.0;
			double num4 = 0.0;
			if (!flag)
			{
				bool flag2 = !(num3 > 1.0);
				num4 = num3;
				if (!flag2)
				{
					num4 = 1.0;
				}
			}
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RipButton)+48]");
				double num6 = default;
				double num5 = 0.0 - num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RipButton)+44]");
				double num8 = default;
				double num7 = 0.0 - num8;
				float num9 = (float)baseScale - num;
				double num10 = num5 * num4;
				double num11 = num7 * num4;
				double num12 = num6 + num10;
				double num13 = num8 + num11;
				transform.localScale = (Vector3)0;
				float num14 = cooldown;
				if (cooldown > 0f)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v16+E4]");
				bool flag3 = (nint)0 == 0;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag4 = group == null;
				bool flag5 = !flag4;
				object obj4 = !flag5;
				if (obj4 != null)
				{
					return;
				}
				Transform[] array = hands;
				if (hands == null || array.Length < 1)
				{
					return;
				}
				object obj5 = array.Length & 0xFFFFFFFFL;
				object obj6 = hands + 32;
				object obj7 = 0;
				object obj8 = 0;
				UnityEngine.Object obj9 = null;
				while (true)
				{
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
					object obj10 = !flag6;
					if (obj10 != null)
					{
						break;
					}
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v21+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v5+v71 @ X23_v6*8]");
					bool flag8 = (UnityEngine.Object)0 == null;
					bool flag9 = !flag8;
					object obj13 = !flag9;
					double num15 = num12;
					double num16 = num13;
					obj9 = null;
					if (obj13 != null)
					{
						goto IL_046a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v5+v71 @ X23_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X24_v5+v71 @ X23_v6*8]");
						Vector3 position = ((Transform)0).position;
						Transform transform3 = base.transform;
						if ((object)transform3 != null)
						{
							Vector3 position2 = transform3.position;
							float num17 = num14 - num14;
							double num18 = num13 - num13;
							double num19 = num12 - num12;
							float num20 = num17 * num17;
							double num21 = num18 * num18;
							float num22 = num20 + (float)num21;
							double num23 = num19 * num19;
							num15 = radius;
							double num24 = num23 + (double)num22;
							num16 = (double)radius * (double)radius;
							bool flag10 = !(num24 > num16);
							obj9 = null;
							num14 = (float)num24;
							if (!flag10)
							{
								goto IL_046a;
							}
							Press();
							return;
						}
					}
					goto IL_04c1;
					IL_046a:
					obj5 = array.Length;
					obj7++;
					bool flag11 = (nint)obj7 < array.Length;
					obj8 = 0;
					num12 = num15;
					num13 = num16;
					if (!flag11)
					{
						return;
					}
				}
				goto IL_04cf;
			}
		}
		goto IL_04c1;
		IL_04c1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04cf;
		IL_04cf:
		throw new IndexOutOfRangeException();
	}

	public void Click()
	{
		//IL_009c: Invalid comparison between F4 and I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00b8: Invalid comparison between F4 and I4
		//IL_00c9: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		bool flag = cooldown < 0f;
		object obj = !flag;
		bool flag2 = cooldown == 0f;
		object obj2 = !flag2;
		object obj3 = obj & obj2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (group != null)
			{
				Press();
			}
		}
	}

	private void Press()
	{
		//IL_0032: Expected VT, but got I4
		//IL_008c: Expected Obj, but got I4
		cooldown = 1f;
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		transform.localScale = (Vector3)0;
		ApePart part;
		if (action != (ScreenFont.Action)2)
		{
			if (action != (ScreenFont.Action)1)
			{
				bool flag = action == 0;
				object obj = !flag;
				if (obj != null)
				{
					group.ResetAll();
					return;
				}
				part = (ApePart)1;
			}
			else
			{
				part = (ApePart)2;
			}
		}
		else
		{
			part = (ApePart)0;
		}
		group.Tear(part);
	}
}
