using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Fusion.Statistics;
using Unity.Profiling.LowLevel.Unsafe;

namespace Fusion;

internal class SimulationBehaviourUpdater
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass21_0
	{
		public Type type;
	}

	internal class BehaviourList : _0021_00210
	{
		public Type Type;

		public int ExecutionOrder;

		public SimulationModes Modes;

		public SimulationStages Stages;

		public Topologies Topologies;

		public BehaviourCallbackFlags Overrides;

		public SimulationBehaviour Head;

		public SimulationBehaviour Tail;

		public int LockCount;

		public List<SimulationBehaviour> PendingRemovals;

		public BehaviourStatisticsManager BehaviourStats;

		public void AddAfter(SimulationBehaviour item, SimulationBehaviour after)
		{
			//IL_02d6: Expected Obj, but got I
			//IL_02e6: Expected Obj, but got I
			//IL_02f6: Expected Obj, but got I
			//IL_0306: Expected Obj, but got I
			//IL_0316: Expected Obj, but got I
			//IL_031c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Expected Obj, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_00d9: Expected Obj, but got I4
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected Obj, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected Obj, but got Unknown
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected Obj, but got Unknown
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_0212: Expected Obj, but got I4
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected Obj, but got Unknown
			//IL_0290: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62B8]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62B0]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62A8]");
			object error3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62C0]");
			object error4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62C8]");
			object error5 = 0;
			object obj = this + 48;
			object obj2 = obj;
			while (obj2 != after)
			{
				obj2 += 40;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					break;
				}
			}
			bool flag2 = obj2 == null;
			bool condition = !flag2;
			Assert.Check(condition, (string)error);
			object obj4 = obj;
			while (obj4 != item)
			{
				obj4 += 40;
				bool flag3 = obj4 == null;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					break;
				}
			}
			bool condition2 = obj4 == null;
			Assert.Check(condition2, (string)error2);
			object obj6 = item.Flags & (SimulationBehaviourRuntimeFlags)4;
			bool condition3 = obj6 == null;
			Assert.Check(condition3, (string)error3);
			if ((object)Tail != after)
			{
				object obj7 = after + 40;
				bool flag4 = obj7 == null;
				bool condition4 = !flag4;
				Assert.Check(condition4, (string)error4);
				object obj8 = item + 40;
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj9 = item + 32;
				obj9 = after;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj10 = obj7 + 32;
				obj10 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj7 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				AddLast(item);
			}
			object obj11 = obj;
			while (obj11 != after)
			{
				obj11 += 40;
				bool flag5 = obj11 == null;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					break;
				}
			}
			bool flag6 = obj11 == null;
			bool condition5 = !flag6;
			Assert.Check(condition5, (string)error);
			while (obj != item)
			{
				obj += 40;
				bool flag7 = obj == null;
				object obj13 = !flag7;
				if (obj13 == null)
				{
					break;
				}
			}
			bool flag8 = obj == null;
			bool condition6 = !flag8;
			Assert.Check(condition6, (string)error5);
		}

		public void AddFirst(SimulationBehaviour item)
		{
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected Obj, but got Unknown
			//IL_0123: Expected Obj, but got I
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0093: Expected Obj, but got I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected Obj, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62E0]");
			object error = 0;
			object obj2 = obj;
			while (obj2 != item)
			{
				obj2 += 40;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					break;
				}
			}
			bool condition = obj2 == null;
			Assert.Check(condition, (string)error);
			object obj4 = item + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = item + 32;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (obj != null)
			{
				object obj6 = obj + 32;
				obj6 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				Head = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj = this + 56;
			}
			obj = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public void AddLast(SimulationBehaviour item)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			//IL_0053: Expected Obj, but got I
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected Obj, but got Unknown
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_011b: Expected Obj, but got I4
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected Obj, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I4
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62D0]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62D8]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62B0]");
			object error3 = 0;
			object obj = item + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62A8]");
			object error4 = 0;
			bool condition = obj == null;
			Assert.Check(condition, (string)error);
			object obj2 = item + 40;
			bool condition2 = obj2 == null;
			Assert.Check(condition2, (string)error2);
			object obj3 = this + 48;
			object obj4 = obj3;
			while (obj4 != item)
			{
				obj4 += 40;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 == null)
				{
					break;
				}
			}
			bool condition3 = obj4 == null;
			Assert.Check(condition3, (string)error3);
			object obj6 = item.Flags & (SimulationBehaviourRuntimeFlags)4;
			bool condition4 = obj6 == null;
			Assert.Check(condition4, (string)error4);
			item.Next = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj7 = (item.Prev = (SimulationBehaviour)(this + 56));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj8 = obj7 + 40;
			object obj9;
			if (obj7 == null)
			{
				obj9 = obj3;
			}
			else
			{
				obj9 = obj8;
			}
			obj9 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj7 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public unsafe void RemoveAllPending()
		{
			//IL_0010: Expected Obj, but got I
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected Obj, but got I4
			//IL_006b: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I4
			//IL_028e: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I4
			//IL_0093: Expected Obj, but got I4
			//IL_009b: Expected Obj, but got Ref
			//IL_01b1: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D60F0]");
			object error = 0;
			bool condition = LockCount == 0;
			Assert.Check(condition, (string)error);
			List<System.__Canon> pendingRemovals = (List<System.__Canon>)(object)PendingRemovals;
			if ((object)PendingRemovals == null || pendingRemovals._size == 0)
			{
				return;
			}
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)PendingRemovals).GetEnumerator();
			Enumerator<, > val = default;
			while (val.MoveNext())
			{
				Remove(null);
			}
			object obj = 0;
			object obj2 = 0;
			object obj3 = 0;
			object obj7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D60F8]");
				object obj4 = 0;
				val.Dispose();
				bool flag = obj3 == null;
				object obj5 = !flag;
				if (obj5 == null)
				{
					bool flag2 = obj == null;
					object obj6 = !flag2;
					OutOfMemoryException ex = (OutOfMemoryException)(&val);
					if (obj6 == null)
					{
						List<SimulationBehaviour> pendingRemovals2 = PendingRemovals;
						if ((object)PendingRemovals != null)
						{
							int version = pendingRemovals2._version + 1;
							pendingRemovals2._size = 0;
							pendingRemovals2._version = version;
							if (pendingRemovals2._size >= 1)
							{
								Array.Clear(pendingRemovals2._items, 0, pendingRemovals2._size);
							}
							return;
						}
						goto IL_0161;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				goto IL_0161;
				IL_0161:
				NullReferenceException ex2 = new NullReferenceException();
				if ((nint)obj4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj = 1;
					obj3 = obj2;
					continue;
				}
				if ((nint)obj4 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj2 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A4DF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		}

		public void PendingRemove(SimulationBehaviour item)
		{
			//IL_0242: Expected Obj, but got I
			//IL_0252: Expected Obj, but got I
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected Obj, but got Unknown
			//IL_00cc: Expected Obj, but got I4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected I4, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected Obj, but got Unknown
			//IL_0118: Expected Obj, but got I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_01c1: Expected Obj, but got I4
			//IL_0136: Expected Obj, but got I
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected Obj, but got Unknown
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62C8]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6310]");
			object error2 = 0;
			object obj = this + 48;
			while (obj != item)
			{
				obj += 40;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					break;
				}
			}
			bool flag2 = obj == null;
			bool condition = !flag2;
			Assert.Check(condition, (string)error);
			bool flag3 = LockCount < 0;
			bool flag4 = LockCount == 0;
			int num = LockCount ^ LockCount;
			int num2 = LockCount & num;
			bool flag5 = num2 < 0;
			bool flag6 = flag3 == flag5;
			object obj3 = !flag4;
			bool condition2 = (byte)((flag6 & obj3) ? 1 : 0) != 0;
			Assert.Check(condition2, (string)error2);
			object obj4 = this + 72;
			List<System.__Canon> list = (List<System.__Canon>)obj4;
			bool flag7 = obj4 == null;
			object obj5 = !flag7;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6308]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				List<System.__Canon> list2 = default;
				list2._002Ector();
				obj4 = list2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				list = (List<System.__Canon>)obj4;
			}
			System.__Canon[] items = list._items;
			int version = list._version + 1;
			list._version = version;
			bool flag8 = list._size < items.Length;
			object obj7 = !flag8;
			if (obj7 == null)
			{
				object obj8 = items + list._size;
				int size = list._size + 1;
				list._size = size;
				object obj9 = obj8 + 32;
				obj9 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			else
			{
				list.AddWithResize((System.__Canon)(object)item);
			}
		}

		public void Remove(SimulationBehaviour item)
		{
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected Obj, but got Unknown
			//IL_01da: Expected Obj, but got I
			//IL_01f2: Expected Obj, but got I
			//IL_0202: Expected Obj, but got I
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_0244: Expected Obj, but got I
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected Obj, but got Unknown
			//IL_0263: Expected Obj, but got I
			//IL_0284: Expected Obj, but got I
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected Obj, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected Obj, but got Unknown
			//IL_01b8: Expected I4, but got I8
			object obj = this + 48;
			object obj2 = obj;
			while (obj2 != item)
			{
				obj2 += 40;
				bool flag = obj2 == null;
				object obj3 = !flag;
				if (obj3 == null)
				{
					break;
				}
			}
			if (obj2 != null)
			{
				object obj4 = item + 32;
				if (obj4 != null)
				{
					object obj5 = obj4 + 40;
					obj5 = item.Next;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				object obj6 = item + 40;
				if (obj6 != null)
				{
					object obj7 = obj6 + 32;
					obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				object obj8 = this + 56;
				if (obj8 == item)
				{
					obj8 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				if (obj == item)
				{
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				item.Prev = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				item.Next = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				SimulationBehaviourRuntimeFlags flags = (SimulationBehaviourRuntimeFlags)((long)item.Flags & 0xFFFFFFFBL);
				item.Flags = flags;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+38]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v10+38]");
				if ((nint)0 != 0)
				{
					BitSet64.NameDeferred name = BehaviourUtils.GetName(item);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6268]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6318]");
					object format = 0;
					object arg = default;
					string text = string.Format((string)format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X20_v5+18]");
					object obj14 = 0;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ X9_v5+188] (should have been resolved before IL gen)");
				}
			}
		}

		public bool IsInList(SimulationBehaviour item)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0038: Expected Obj, but got I4
			object obj = this + 48;
			while (obj != item)
			{
				obj += 40;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					break;
				}
			}
			bool flag2 = obj == null;
			return !flag2;
		}

		private void Fusion_002EILogDumpable_002EDump(StringBuilder builder)
		{
			//IL_0015: Expected Obj, but got I
			//IL_003a: Expected Obj, but got I4
			//IL_0065: Expected Obj, but got I
			//IL_0075: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_0173: Expected Obj, but got I
			//IL_0195: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6398]");
			object value = 0;
			StringBuilder stringBuilder = builder.Append((string)value);
			string value2 = (string)((System.RuntimeType)Type).IsArrayImpl();
			StringBuilder stringBuilder2 = stringBuilder.Append(value2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63A0]");
			object value3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
			object value4 = 0;
			StringBuilder stringBuilder3 = stringBuilder2.Append((string)value3);
			if ((object)Head != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63B0]");
				object value5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D63A8]");
				object value6 = 0;
				Behaviour behaviour = Head;
				object obj2;
				do
				{
					if ((object)behaviour != Head)
					{
						StringBuilder stringBuilder4 = builder.Append((string)value6);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v7 (Fusion.Behaviour)+30]");
					object obj = (nint)0 & (nint)0x1C;
					if (obj != null)
					{
						StringBuilder stringBuilder5 = builder.Append((string)value5);
					}
					BitSet64.NameDeferred name = BehaviourUtils.GetName(behaviour);
					string value7 = name;
					StringBuilder stringBuilder6 = builder.Append(value7);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v7 (Fusion.Behaviour)+28]");
					behaviour = (Behaviour)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v7 (Fusion.Behaviour)+28]");
					bool flag = (nint)0 == 0;
					obj2 = !flag;
				}
				while (obj2 != null);
			}
			StringBuilder stringBuilder7 = builder.Append((string)value4);
		}

		public BehaviourList()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6370]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			BehaviourStatisticsManager behaviourStatisticsManager = default;
			behaviourStatisticsManager._002Ector();
			object obj2 = this + 80;
			obj2 = behaviourStatisticsManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	private readonly Dictionary<Type, BehaviourList> _byTypeLookup;

	private readonly Dictionary<Type, (SimulationBehaviour[], Type[])> _byTypeHierarchy;

	private readonly List<BehaviourList> _inOrderList;

	private readonly Dictionary<Type, List<BehaviourList>> _inOrderByInterfaceList;

	private readonly NetworkProjectConfig _config;

	private static Type[] CallbackInterfacesDefualts
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_1441: Expected Obj, but got I
			//IL_1451: Expected Obj, but got I
			//IL_1473: Expected Obj, but got I4
			//IL_003d: Expected VT, but got Obj
			//IL_0076: Expected Obj, but got I4
			//IL_008c: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I
			//IL_0102: Expected Obj, but got I
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected Obj, but got Unknown
			//IL_012b: Expected VT, but got Obj
			//IL_014c: Expected Obj, but got I4
			//IL_01bd: Expected Obj, but got I8
			//IL_0162: Expected I, but got Obj
			//IL_0172: Expected Obj, but got I
			//IL_019b: Expected Obj, but got I
			//IL_01ea: Expected Obj, but got I
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_0213: Expected VT, but got Obj
			//IL_0234: Expected Obj, but got I4
			//IL_02ad: Expected Obj, but got I4
			//IL_02bd: Expected Obj, but got I4
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected Obj, but got Unknown
			//IL_024a: Expected I, but got Obj
			//IL_025a: Expected Obj, but got I
			//IL_0283: Expected Obj, but got I
			//IL_0300: Expected Obj, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected Obj, but got Unknown
			//IL_0329: Expected VT, but got Obj
			//IL_034a: Expected Obj, but got I4
			//IL_03bb: Expected Obj, but got I8
			//IL_0360: Expected I, but got Obj
			//IL_0370: Expected Obj, but got I
			//IL_0399: Expected Obj, but got I
			//IL_03e8: Expected Obj, but got I
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected Obj, but got Unknown
			//IL_0411: Expected VT, but got Obj
			//IL_0432: Expected Obj, but got I4
			//IL_04ab: Expected Obj, but got I4
			//IL_04bb: Expected Obj, but got I4
			//IL_04db: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e0: Expected Obj, but got Unknown
			//IL_0448: Expected I, but got Obj
			//IL_0458: Expected Obj, but got I
			//IL_0481: Expected Obj, but got I
			//IL_04fe: Expected Obj, but got I
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Expected Obj, but got Unknown
			//IL_0527: Expected VT, but got Obj
			//IL_0548: Expected Obj, but got I4
			//IL_05c1: Expected Obj, but got I4
			//IL_05d1: Expected Obj, but got I4
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected Obj, but got Unknown
			//IL_055e: Expected I, but got Obj
			//IL_056e: Expected Obj, but got I
			//IL_0597: Expected Obj, but got I
			//IL_0614: Expected Obj, but got I
			//IL_061d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0622: Expected Obj, but got Unknown
			//IL_063d: Expected VT, but got Obj
			//IL_065e: Expected Obj, but got I4
			//IL_06d7: Expected Obj, but got I4
			//IL_06e7: Expected Obj, but got I4
			//IL_0707: Unknown result type (might be due to invalid IL or missing references)
			//IL_070c: Expected Obj, but got Unknown
			//IL_0674: Expected I, but got Obj
			//IL_0684: Expected Obj, but got I
			//IL_06ad: Expected Obj, but got I
			//IL_072a: Expected Obj, but got I
			//IL_0733: Unknown result type (might be due to invalid IL or missing references)
			//IL_0738: Expected Obj, but got Unknown
			//IL_0753: Expected VT, but got Obj
			//IL_0774: Expected Obj, but got I4
			//IL_07e5: Expected Obj, but got I8
			//IL_078a: Expected I, but got Obj
			//IL_079a: Expected Obj, but got I
			//IL_07c3: Expected Obj, but got I
			//IL_0812: Expected Obj, but got I
			//IL_081b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Expected Obj, but got Unknown
			//IL_083b: Expected VT, but got Obj
			//IL_085c: Expected Obj, but got I4
			//IL_08d5: Expected Obj, but got I4
			//IL_08e5: Expected Obj, but got I4
			//IL_0905: Unknown result type (might be due to invalid IL or missing references)
			//IL_090a: Expected Obj, but got Unknown
			//IL_0872: Expected I, but got Obj
			//IL_0882: Expected Obj, but got I
			//IL_08ab: Expected Obj, but got I
			//IL_0928: Expected Obj, but got I
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_0936: Expected Obj, but got Unknown
			//IL_0951: Expected VT, but got Obj
			//IL_0972: Expected Obj, but got I4
			//IL_09eb: Expected Obj, but got I4
			//IL_09fb: Expected Obj, but got I4
			//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a20: Expected Obj, but got Unknown
			//IL_0988: Expected I, but got Obj
			//IL_0998: Expected Obj, but got I
			//IL_09c1: Expected Obj, but got I
			//IL_0a3e: Expected Obj, but got I
			//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4c: Expected Obj, but got Unknown
			//IL_0a67: Expected VT, but got Obj
			//IL_0a88: Expected Obj, but got I4
			//IL_0b01: Expected Obj, but got I4
			//IL_0b11: Expected Obj, but got I4
			//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b36: Expected Obj, but got Unknown
			//IL_0a9e: Expected I, but got Obj
			//IL_0aae: Expected Obj, but got I
			//IL_0ad7: Expected Obj, but got I
			//IL_0b54: Expected Obj, but got I
			//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b62: Expected Obj, but got Unknown
			//IL_0b7d: Expected VT, but got Obj
			//IL_0b9e: Expected Obj, but got I4
			//IL_0c17: Expected Obj, but got I4
			//IL_0c27: Expected Obj, but got I4
			//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4c: Expected Obj, but got Unknown
			//IL_0bb4: Expected I, but got Obj
			//IL_0bc4: Expected Obj, but got I
			//IL_0bed: Expected Obj, but got I
			//IL_0c6a: Expected Obj, but got I
			//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c78: Expected Obj, but got Unknown
			//IL_0c93: Expected VT, but got Obj
			//IL_0cb4: Expected Obj, but got I4
			//IL_0d2d: Expected Obj, but got I4
			//IL_0d3d: Expected Obj, but got I4
			//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d62: Expected Obj, but got Unknown
			//IL_0cca: Expected I, but got Obj
			//IL_0cda: Expected Obj, but got I
			//IL_0d03: Expected Obj, but got I
			//IL_0d80: Expected Obj, but got I
			//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8e: Expected Obj, but got Unknown
			//IL_0da9: Expected VT, but got Obj
			//IL_0dca: Expected Obj, but got I4
			//IL_0e43: Expected Obj, but got I4
			//IL_0e53: Expected Obj, but got I4
			//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e78: Expected Obj, but got Unknown
			//IL_0de0: Expected I, but got Obj
			//IL_0df0: Expected Obj, but got I
			//IL_0e19: Expected Obj, but got I
			//IL_0e96: Expected Obj, but got I
			//IL_0e9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea4: Expected Obj, but got Unknown
			//IL_0ebf: Expected VT, but got Obj
			//IL_0ee0: Expected Obj, but got I4
			//IL_0f59: Expected Obj, but got I4
			//IL_0f69: Expected Obj, but got I4
			//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8e: Expected Obj, but got Unknown
			//IL_0ef6: Expected I, but got Obj
			//IL_0f06: Expected Obj, but got I
			//IL_0f2f: Expected Obj, but got I
			//IL_0fac: Expected Obj, but got I
			//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fba: Expected Obj, but got Unknown
			//IL_0fd5: Expected VT, but got Obj
			//IL_0ff6: Expected Obj, but got I4
			//IL_1067: Expected Obj, but got I8
			//IL_100c: Expected I, but got Obj
			//IL_101c: Expected Obj, but got I
			//IL_1045: Expected Obj, but got I
			//IL_1094: Expected Obj, but got I
			//IL_109d: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a2: Expected Obj, but got Unknown
			//IL_10bd: Expected VT, but got Obj
			//IL_10de: Expected Obj, but got I4
			//IL_1157: Expected Obj, but got I4
			//IL_1167: Expected Obj, but got I4
			//IL_1187: Unknown result type (might be due to invalid IL or missing references)
			//IL_118c: Expected Obj, but got Unknown
			//IL_10f4: Expected I, but got Obj
			//IL_1104: Expected Obj, but got I
			//IL_112d: Expected Obj, but got I
			//IL_11aa: Expected Obj, but got I
			//IL_11b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_11b8: Expected Obj, but got Unknown
			//IL_11d3: Expected VT, but got Obj
			//IL_11f4: Expected Obj, but got I4
			//IL_126d: Expected Obj, but got I4
			//IL_127d: Expected Obj, but got I4
			//IL_129d: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a2: Expected Obj, but got Unknown
			//IL_120a: Expected I, but got Obj
			//IL_121a: Expected Obj, but got I
			//IL_1243: Expected Obj, but got I
			//IL_12c0: Expected Obj, but got I
			//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ce: Expected Obj, but got Unknown
			//IL_12e9: Expected VT, but got Obj
			//IL_130a: Expected Obj, but got I4
			//IL_1383: Expected Obj, but got I4
			//IL_1393: Expected Obj, but got I4
			//IL_13b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b8: Expected Obj, but got Unknown
			//IL_1320: Expected I, but got Obj
			//IL_1330: Expected Obj, but got I
			//IL_1359: Expected Obj, but got I
			//IL_13cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_13d4: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5998]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+E8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj2);
			Type[] array = default;
			if (array != null)
			{
				bool flag2 = (object)typeFromHandle == null;
				object obj6 = 0;
				IndexOutOfRangeException ex = default;
				object obj7;
				if (!flag2)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v65 (Il2CppClass<System.Type[]>)+40]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag3 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v65 (Il2CppClass<System.Type[]>)+40]");
					obj7 = 0;
					if (flag3)
					{
						goto IL_1401;
					}
				}
				if (array.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58F8]");
					object obj8 = 0;
					object obj9 = array + 32;
					obj9 = typeFromHandle;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj8);
					bool flag4 = (object)typeFromHandle2 == null;
					obj6 = 0;
					if (!flag4)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v64 (Il2CppClass<System.Type[]>)+40]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v64 (Il2CppClass<System.Type[]>)+40]");
						obj7 = 0;
						if (flag5)
						{
							goto IL_1401;
						}
					}
					object obj10 = array.Length & 0xFFFFFFFEL;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5908]");
						object obj11 = 0;
						object obj12 = array + 40;
						obj12 = typeFromHandle2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj11);
						bool flag6 = (object)typeFromHandle3 == null;
						obj6 = 0;
						if (!flag6)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v63 (Il2CppClass<System.Type[]>)+40]");
							obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag7 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v63 (Il2CppClass<System.Type[]>)+40]");
							obj7 = 0;
							if (flag7)
							{
								goto IL_1401;
							}
						}
						bool flag8 = array.Length < 2;
						object obj13 = !flag8;
						object obj14 = array.Length - 2;
						bool flag9 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag9;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5918]");
							object obj17 = 0;
							object obj18 = array + 48;
							obj18 = typeFromHandle3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj17);
							bool flag10 = (object)typeFromHandle4 == null;
							obj6 = 0;
							if (!flag10)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v62 (Il2CppClass<System.Type[]>)+40]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag11 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v62 (Il2CppClass<System.Type[]>)+40]");
								obj7 = 0;
								if (flag11)
								{
									goto IL_1401;
								}
							}
							object obj19 = array.Length & 0xFFFFFFFCL;
							if (obj19 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5928]");
								object obj20 = 0;
								object obj21 = array + 56;
								obj21 = typeFromHandle4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj20);
								bool flag12 = (object)typeFromHandle5 == null;
								obj6 = 0;
								if (!flag12)
								{
									nint num5 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v61 (Il2CppClass<System.Type[]>)+40]");
									obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag13 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v61 (Il2CppClass<System.Type[]>)+40]");
									obj7 = 0;
									if (flag13)
									{
										goto IL_1401;
									}
								}
								bool flag14 = array.Length < 4;
								object obj22 = !flag14;
								object obj23 = array.Length - 4;
								bool flag15 = obj23 == null;
								object obj24 = ~obj22;
								object obj25 = obj24 | flag15;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5938]");
									object obj26 = 0;
									object obj27 = array + 64;
									obj27 = typeFromHandle5;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj26);
									bool flag16 = (object)typeFromHandle6 == null;
									obj6 = 0;
									if (!flag16)
									{
										nint num6 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v60 (Il2CppClass<System.Type[]>)+40]");
										obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag17 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v60 (Il2CppClass<System.Type[]>)+40]");
										obj7 = 0;
										if (flag17)
										{
											goto IL_1401;
										}
									}
									bool flag18 = array.Length < 5;
									object obj28 = !flag18;
									object obj29 = array.Length - 5;
									bool flag19 = obj29 == null;
									object obj30 = ~obj28;
									object obj31 = obj30 | flag19;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5968]");
										object obj32 = 0;
										object obj33 = array + 72;
										obj33 = typeFromHandle6;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj32);
										bool flag20 = (object)typeFromHandle7 == null;
										obj6 = 0;
										if (!flag20)
										{
											nint num7 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v59 (Il2CppClass<System.Type[]>)+40]");
											obj6 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag21 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v59 (Il2CppClass<System.Type[]>)+40]");
											obj7 = 0;
											if (flag21)
											{
												goto IL_1401;
											}
										}
										bool flag22 = array.Length < 6;
										object obj34 = !flag22;
										object obj35 = array.Length - 6;
										bool flag23 = obj35 == null;
										object obj36 = ~obj34;
										object obj37 = obj36 | flag23;
										if (obj37 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5948]");
											object obj38 = 0;
											object obj39 = array + 80;
											obj39 = typeFromHandle7;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Type typeFromHandle8 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj38);
											bool flag24 = (object)typeFromHandle8 == null;
											obj6 = 0;
											if (!flag24)
											{
												nint num8 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v58 (Il2CppClass<System.Type[]>)+40]");
												obj6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag25 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v58 (Il2CppClass<System.Type[]>)+40]");
												obj7 = 0;
												if (flag25)
												{
													goto IL_1401;
												}
											}
											object obj40 = array.Length & 0xFFFFFFF8L;
											if (obj40 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5958]");
												object obj41 = 0;
												object obj42 = array + 88;
												obj42 = typeFromHandle8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Type typeFromHandle9 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj41);
												bool flag26 = (object)typeFromHandle9 == null;
												obj6 = 0;
												if (!flag26)
												{
													nint num9 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v57 (Il2CppClass<System.Type[]>)+40]");
													obj6 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag27 = ex == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v57 (Il2CppClass<System.Type[]>)+40]");
													obj7 = 0;
													if (flag27)
													{
														goto IL_1401;
													}
												}
												bool flag28 = array.Length < 8;
												object obj43 = !flag28;
												object obj44 = array.Length - 8;
												bool flag29 = obj44 == null;
												object obj45 = ~obj43;
												object obj46 = obj45 | flag29;
												if (obj46 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5988]");
													object obj47 = 0;
													object obj48 = array + 96;
													obj48 = typeFromHandle9;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Type typeFromHandle10 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj47);
													bool flag30 = (object)typeFromHandle10 == null;
													obj6 = 0;
													if (!flag30)
													{
														nint num10 = (nint)array;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v56 (Il2CppClass<System.Type[]>)+40]");
														obj6 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag31 = ex == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v56 (Il2CppClass<System.Type[]>)+40]");
														obj7 = 0;
														if (flag31)
														{
															goto IL_1401;
														}
													}
													bool flag32 = array.Length < 9;
													object obj49 = !flag32;
													object obj50 = array.Length - 9;
													bool flag33 = obj50 == null;
													object obj51 = ~obj49;
													object obj52 = obj51 | flag33;
													if (obj52 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5978]");
														object obj53 = 0;
														object obj54 = array + 104;
														obj54 = typeFromHandle10;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Type typeFromHandle11 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj53);
														bool flag34 = (object)typeFromHandle11 == null;
														obj6 = 0;
														if (!flag34)
														{
															nint num11 = (nint)array;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v55 (Il2CppClass<System.Type[]>)+40]");
															obj6 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag35 = ex == null;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v55 (Il2CppClass<System.Type[]>)+40]");
															obj7 = 0;
															if (flag35)
															{
																goto IL_1401;
															}
														}
														bool flag36 = array.Length < 10;
														object obj55 = !flag36;
														object obj56 = array.Length - 10;
														bool flag37 = obj56 == null;
														object obj57 = ~obj55;
														object obj58 = obj57 | flag37;
														if (obj58 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59A8]");
															object obj59 = 0;
															object obj60 = array + 112;
															obj60 = typeFromHandle11;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Type typeFromHandle12 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj59);
															bool flag38 = (object)typeFromHandle12 == null;
															obj6 = 0;
															if (!flag38)
															{
																nint num12 = (nint)array;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v54 (Il2CppClass<System.Type[]>)+40]");
																obj6 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag39 = ex == null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v54 (Il2CppClass<System.Type[]>)+40]");
																obj7 = 0;
																if (flag39)
																{
																	goto IL_1401;
																}
															}
															bool flag40 = array.Length < 11;
															object obj61 = !flag40;
															object obj62 = array.Length - 11;
															bool flag41 = obj62 == null;
															object obj63 = ~obj61;
															object obj64 = obj63 | flag41;
															if (obj64 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59B8]");
																object obj65 = 0;
																object obj66 = array + 120;
																obj66 = typeFromHandle12;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Type typeFromHandle13 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj65);
																bool flag42 = (object)typeFromHandle13 == null;
																obj6 = 0;
																if (!flag42)
																{
																	nint num13 = (nint)array;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v53 (Il2CppClass<System.Type[]>)+40]");
																	obj6 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																	bool flag43 = ex == null;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v53 (Il2CppClass<System.Type[]>)+40]");
																	obj7 = 0;
																	if (flag43)
																	{
																		goto IL_1401;
																	}
																}
																bool flag44 = array.Length < 12;
																object obj67 = !flag44;
																object obj68 = array.Length - 12;
																bool flag45 = obj68 == null;
																object obj69 = ~obj67;
																object obj70 = obj69 | flag45;
																if (obj70 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58C8]");
																	object obj71 = 0;
																	object obj72 = array + 128;
																	obj72 = typeFromHandle13;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Type typeFromHandle14 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj71);
																	bool flag46 = (object)typeFromHandle14 == null;
																	obj6 = 0;
																	if (!flag46)
																	{
																		nint num14 = (nint)array;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v52 (Il2CppClass<System.Type[]>)+40]");
																		obj6 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																		bool flag47 = ex == null;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v52 (Il2CppClass<System.Type[]>)+40]");
																		obj7 = 0;
																		if (flag47)
																		{
																			goto IL_1401;
																		}
																	}
																	bool flag48 = array.Length < 13;
																	object obj73 = !flag48;
																	object obj74 = array.Length - 13;
																	bool flag49 = obj74 == null;
																	object obj75 = ~obj73;
																	object obj76 = obj75 | flag49;
																	if (obj76 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B8]");
																		object obj77 = 0;
																		object obj78 = array + 136;
																		obj78 = typeFromHandle14;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Type typeFromHandle15 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj77);
																		bool flag50 = (object)typeFromHandle15 == null;
																		obj6 = 0;
																		if (!flag50)
																		{
																			nint num15 = (nint)array;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v51 (Il2CppClass<System.Type[]>)+40]");
																			obj6 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																			bool flag51 = ex == null;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v51 (Il2CppClass<System.Type[]>)+40]");
																			obj7 = 0;
																			if (flag51)
																			{
																				goto IL_1401;
																			}
																		}
																		bool flag52 = array.Length < 14;
																		object obj79 = !flag52;
																		object obj80 = array.Length - 14;
																		bool flag53 = obj80 == null;
																		object obj81 = ~obj79;
																		object obj82 = obj81 | flag53;
																		if (obj82 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5890]");
																			object obj83 = 0;
																			object obj84 = array + 144;
																			obj84 = typeFromHandle15;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Type typeFromHandle16 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj83);
																			bool flag54 = (object)typeFromHandle16 == null;
																			obj6 = 0;
																			if (!flag54)
																			{
																				nint num16 = (nint)array;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v50 (Il2CppClass<System.Type[]>)+40]");
																				obj6 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																				bool flag55 = ex == null;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v50 (Il2CppClass<System.Type[]>)+40]");
																				obj7 = 0;
																				if (flag55)
																				{
																					goto IL_1401;
																				}
																			}
																			object obj85 = array.Length & 0xFFFFFFF0L;
																			if (obj85 != null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58D8]");
																				object obj86 = 0;
																				object obj87 = array + 152;
																				obj87 = typeFromHandle16;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Type typeFromHandle17 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj86);
																				bool flag56 = (object)typeFromHandle17 == null;
																				obj6 = 0;
																				if (!flag56)
																				{
																					nint num17 = (nint)array;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v49 (Il2CppClass<System.Type[]>)+40]");
																					obj6 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																					bool flag57 = ex == null;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v49 (Il2CppClass<System.Type[]>)+40]");
																					obj7 = 0;
																					if (flag57)
																					{
																						goto IL_1401;
																					}
																				}
																				bool flag58 = array.Length < 16;
																				object obj88 = !flag58;
																				object obj89 = array.Length - 16;
																				bool flag59 = obj89 == null;
																				object obj90 = ~obj88;
																				object obj91 = obj90 | flag59;
																				if (obj91 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58E8]");
																					object obj92 = 0;
																					object obj93 = array + 160;
																					obj93 = typeFromHandle17;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					Type typeFromHandle18 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj92);
																					bool flag60 = (object)typeFromHandle18 == null;
																					obj6 = 0;
																					if (!flag60)
																					{
																						nint num18 = (nint)array;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v48 (Il2CppClass<System.Type[]>)+40]");
																						obj6 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																						bool flag61 = ex == null;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v48 (Il2CppClass<System.Type[]>)+40]");
																						obj7 = 0;
																						if (flag61)
																						{
																							goto IL_1401;
																						}
																					}
																					bool flag62 = array.Length < 17;
																					object obj94 = !flag62;
																					object obj95 = array.Length - 17;
																					bool flag63 = obj95 == null;
																					object obj96 = ~obj94;
																					object obj97 = obj96 | flag63;
																					if (obj97 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59C8]");
																						object obj98 = 0;
																						object obj99 = array + 168;
																						obj99 = typeFromHandle18;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Type typeFromHandle19 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj98);
																						bool flag64 = (object)typeFromHandle19 == null;
																						obj6 = 0;
																						if (!flag64)
																						{
																							nint num19 = (nint)array;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v47 (Il2CppClass<System.Type[]>)+40]");
																							obj6 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																							bool flag65 = ex == null;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v47 (Il2CppClass<System.Type[]>)+40]");
																							obj7 = 0;
																							if (flag65)
																							{
																								goto IL_1401;
																							}
																						}
																						bool flag66 = array.Length < 18;
																						object obj100 = !flag66;
																						object obj101 = array.Length - 18;
																						bool flag67 = obj101 == null;
																						object obj102 = ~obj100;
																						object obj103 = obj102 | flag67;
																						if (obj103 == null)
																						{
																							object obj104 = array + 176;
																							obj104 = typeFromHandle19;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							return array;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				obj7 = obj6;
				goto IL_1401;
			}
			goto IL_1419;
			IL_1401:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex2 = new ArgumentNullException();
			goto IL_1419;
			IL_1419:
			return (Type[])(object)new NullReferenceException();
		}
	}

	public SimulationBehaviourUpdater(NetworkProjectConfig config)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6128]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6148]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6158]");
		object obj4 = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj5 = this + 16;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, (System.__Canon, System.__Canon)> dictionary2 = default;
		dictionary2._002Ector();
		object obj6 = this + 24;
		obj6 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj7 = this + 32;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary3 = default;
		dictionary3._002Ector();
		object obj8 = this + 40;
		obj8 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = this + 48;
		obj9 = config;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private int GetExecutionOrder(Type type)
	{
		//IL_0157: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_002a: Expected VT, but got I
		//IL_0147: Expected I4, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Type type3 = default;
		Type type2 = type3;
		int? num2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X21_v3+E8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X21_v3+10]");
			RuntimeTypeHandle handle = (RuntimeTypeHandle)((nint)0 + (nint)32);
			Type typeFromHandle = Type.GetTypeFromHandle(handle);
			if (type2 != typeFromHandle)
			{
				if ((object)_config == null)
				{
					break;
				}
				int? executionOrder = _config.GetExecutionOrder(type2);
				object obj4 = (_003F?)executionOrder & 0xFF;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					if ((object)type2 == null)
					{
						break;
					}
					nint num = (nint)type2;
					Type type4 = (Type)((object)type2).Equals((object)0);
					type2 = type4;
					continue;
				}
				return num2.Value;
			}
			return 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe void BuildTypeOrder(Type[] customCallbackInterfaces)
	{
		//IL_0d20: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0e4f: Expected VT, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0d4d: Expected Obj, but got I
		//IL_0d5e: Expected Obj, but got I
		//IL_0d6e: Expected Obj, but got I
		//IL_0d90: Expected Obj, but got I4
		//IL_01b1: Expected VT, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_018d: Expected I, but got Obj
		//IL_0dae: Expected Obj, but got I
		//IL_0dc8: Expected Obj, but got I
		//IL_0dd9: Expected I, but got Obj
		//IL_0de9: Expected Obj, but got I
		//IL_0e07: Expected Obj, but got I
		//IL_0e1e: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_0e76: Expected Obj, but got I
		//IL_0ea0: Expected Obj, but got I4
		//IL_1219: Expected Obj, but got I
		//IL_1239: Expected VT, but got I4
		//IL_021e: Expected VT, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_024e: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I
		//IL_1166: Expected Obj, but got I
		//IL_1180: Expected VT, but got I4
		//IL_1189: Expected VT, but got I4
		//IL_1199: Expected VT, but got Ref
		//IL_02d2: Expected I, but got Obj
		//IL_02f1: Expected VT, but got Ref
		//IL_02ff: Expected VT, but got I4
		//IL_0b98: Expected VT, but got Obj
		//IL_0b57: Expected VT, but got I4
		//IL_0ba5: Expected Obj, but got VT
		//IL_0bae: Invalid comparison between VT and I4
		//IL_11a7: Invalid comparison between VT and I4
		//IL_11b8: Expected Obj, but got I4
		//IL_0bda: Expected Obj, but got I
		//IL_0bea: Expected Obj, but got I
		//IL_0ca7: Invalid comparison between VT and I4
		//IL_0cb8: Expected Obj, but got I4
		//IL_11fa: Expected Obj, but got I
		//IL_0c25: Expected Obj, but got I
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Expected Obj, but got Unknown
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected Obj, but got Unknown
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61F8]");
		object obj = 0;
		string text;
		if (customCallbackInterfaces != null)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v117+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v117+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v88+8]");
			Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6200]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v88+8]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v117+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v94+A0]");
					obj4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61B0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61E8]");
				object obj10 = 0;
				Func<System.__Canon, bool> func = default;
				func._002Ector(obj4, (IntPtr)obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61F8]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v93+A0]");
				object obj13 = (nint)0 + (nint)8;
				obj13 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				nint num = unchecked((nint)null);
				predicate = func;
			}
			bool condition = Enumerable.All((IEnumerable<System.__Canon>)(object)customCallbackInterfaces, predicate);
			text = (string)obj5;
			Assert.Always(condition, (string)obj5);
			Type[] array = customCallbackInterfaces;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			text = null;
			Type[] array2 = default;
			Type[] array = array2;
		}
		List<BehaviourList> inOrderList = _inOrderList;
		bool flag4 = _inOrderList == null;
		SimulationBehaviourMeta simulationBehaviourMeta = (SimulationBehaviourMeta)0;
		int num2 = 0;
		SimulationBehaviourMeta simulationBehaviourMeta3 = default;
		Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator enumerator3;
		OutOfMemoryException ex;
		if (!flag4)
		{
			num2 = inOrderList._size;
			int version = inOrderList._version + 1;
			inOrderList._size = 0;
			inOrderList._version = version;
			if (inOrderList._size >= 1)
			{
				Array.Clear(inOrderList._items, 0, inOrderList._size);
				nint num = unchecked((nint)null);
				text = null;
			}
			bool flag5 = (object)_byTypeLookup == null;
			simulationBehaviourMeta = (SimulationBehaviourMeta)0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6178]");
				object obj15 = 0;
				text = (string)obj15;
				((Dictionary<System.__Canon, System.__Canon>)(object)_byTypeLookup).Clear();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v36+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj16;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v36+A0]");
				object obj19 = 0;
				object obj20 = obj19;
				bool flag7 = obj19 == null;
				simulationBehaviourMeta = (SimulationBehaviourMeta)0;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v27+10]");
					bool flag8 = (nint)0 == 0;
					simulationBehaviourMeta = (SimulationBehaviourMeta)0;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61C8]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6148]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6150]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B0]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D61D0]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6170]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v27+10]");
						Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator enumerator = ((Dictionary<System.__Canon, SimulationBehaviourMeta>)0).GetEnumerator();
						SimulationBehaviourMeta simulationBehaviourMeta2 = simulationBehaviourMeta3;
						SimulationBehaviourMeta simulationBehaviourMeta4 = default;
						simulationBehaviourMeta = simulationBehaviourMeta4;
						Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator enumerator2 = default;
						KeyValuePair<System.__Canon, SimulationBehaviourMeta> keyValuePair = default;
						SimulationBehaviourMeta simulationBehaviourMeta5 = default;
						while (enumerator2.MoveNext())
						{
							nint num = (nint)obj21;
							keyValuePair.Deconstruct(out var key, out var value);
							AddType((Type)(object)key, (SimulationBehaviourMeta)(&simulationBehaviourMeta5));
							simulationBehaviourMeta2 = (SimulationBehaviourMeta)0;
							simulationBehaviourMeta = value;
							num2 = (int)(&simulationBehaviourMeta5);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6198]");
						object obj28 = 0;
						text = (string)obj28;
						SimulationBehaviourMeta simulationBehaviourMeta6 = default;
						((Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator*)(&simulationBehaviourMeta6))->Dispose();
						simulationBehaviourMeta3 = (SimulationBehaviourMeta)0;
						enumerator3 = (Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator)0;
						object obj30 = default;
						object obj29 = obj30;
						Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator enumerator4 = (Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator)(&simulationBehaviourMeta6);
						ex = new OutOfMemoryException();
						if ((nint)text == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							simulationBehaviourMeta3 = (SimulationBehaviourMeta)1;
						}
						else
						{
							if ((nint)text != 1)
							{
								goto IL_0cec;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							object obj31 = default;
							enumerator3 = (Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator)obj31;
						}
						object obj32 = enumerator4;
						if (enumerator4 == (Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator)(object)0)
						{
							goto IL_119e;
						}
						object obj33 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v13+12E]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v13+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0c66;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v13+98]");
						object obj36 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X10_v13-8]");
							if (0 == (nint)obj34)
							{
								break;
							}
							obj35--;
							obj36 += 16;
							if ((nint)obj35 != 1)
							{
								continue;
							}
							goto IL_0c66;
						}
						object obj37 = obj33 + obj36;
						object obj38 = obj37 + 312;
						goto IL_11ea;
					}
				}
			}
		}
		throw new NullReferenceException();
		IL_11ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X0_v17+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v938 @ X0_v17] (should have been resolved before IL gen)");
		goto IL_119e;
		IL_119e:
		bool flag9 = enumerator3 == (Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator)(object)0;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			bool flag10 = simulationBehaviourMeta3 == (SimulationBehaviourMeta)(object)0;
			object obj40 = !flag10;
			Dictionary<System.__Canon, SimulationBehaviourMeta>.Enumerator enumerator5 = enumerator3;
			if (obj40 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		}
		ex = new OutOfMemoryException();
		goto IL_0cec;
		IL_0cec:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0c66:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num2 = 0;
		goto IL_11ea;
	}

	public void InvokeRender()
	{
		//IL_0037: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0608: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_02ea: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I
		//IL_039a: Expected I, but got Obj
		//IL_03a3: Expected Obj, but got I4
		List<BehaviourList> inOrderList = _inOrderList;
		if (inOrderList._size < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
		object obj = 0;
		double num2 = default;
		double num = num2;
		object obj3 = default;
		object obj2 = obj3;
		System.__Canon _Canon2 = default;
		System.__Canon _Canon = _Canon2;
		IntPtr intPtr = default;
		nint num3 = intPtr;
		object obj5 = default;
		object obj4 = obj5;
		int num4 = 0;
		object obj20 = default;
		object obj21 = default;
		object obj27 = default;
		while (true)
		{
			if (_inOrderList != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B0]");
				object obj6 = 0;
				object obj7 = obj6;
				System.__Canon _Canon3 = ((List<System.__Canon>)(object)_inOrderList).get_Item(num4);
				if (_Canon3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+28]");
					object obj8 = (nint)0 & (nint)6;
					bool flag = obj8 == null;
					_Canon = _Canon3;
					num3 = num4;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+30]");
						object obj9 = 0;
						Timer timer = Timer.StartNew();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+30]");
						bool flag2 = (nint)0 == 0;
						int num5 = 0;
						int num6 = num4;
						int count = 0;
						nint num7 = num4;
						if (!flag2)
						{
							object obj16;
							do
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X26_v8+30]");
								object obj10 = (nint)0 & (nint)0x1C;
								bool flag3 = obj10 == null;
								object obj11 = !flag3;
								if (obj11 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+28]");
									object obj12 = (nint)0 & (nint)4;
									if (obj12 != null)
									{
										object obj13 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v33+1C0]");
										num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v392 @ X8_v33+1B8] (should have been resolved before IL gen)");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+28]");
									object obj14 = (nint)0 & (nint)2;
									if (obj14 != null)
									{
										object obj15 = obj9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v32+1D0]");
										num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X8_v32+1C8] (should have been resolved before IL gen)");
									}
									num5++;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X26_v8+28]");
								obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X26_v8+28]");
								bool flag4 = (nint)0 == 0;
								obj16 = !flag4;
								count = num5;
								num7 = num6;
							}
							while (obj16 != null);
						}
						object obj17 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v22+E4]");
						bool flag5 = (nint)0 == 0;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						long timestamp = Stopwatch.GetTimestamp();
						object obj19 = obj20 - obj21;
						object obj22 = obj19 + timestamp;
						object obj23 = ~obj22;
						object obj24 = obj22 & obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+50]");
						object obj25 = 0;
						object obj26 = (((nint)obj27 != 1) ? obj20 : obj24);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+50]");
						if ((nint)0 == 0)
						{
							throw new NullReferenceException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v20+18]");
						if ((nint)0 == 0)
						{
							throw new NullReferenceException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v20+18]");
						((BehaviourStatisticsSnapshot)0).AccumulateRenderExecutionCount(count);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+50]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15 (System.__Canon)+50]");
						if ((nint)0 == 0)
						{
							throw new NullReferenceException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v21+18]");
						_Canon = (System.__Canon)0;
						object obj29 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v32+E4]");
						bool flag6 = (nint)0 == 0;
						object obj30 = !flag6;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj29 = obj;
						}
						if (_Canon == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X0_v32+A0]");
						object obj31 = 0;
						object obj32 = obj26 / obj31;
						double num8 = (double)obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
						num = num8 * 0.0;
						((BehaviourStatisticsSnapshot)(object)_Canon).AccumulateRenderExecutionTime(num);
						obj2 = obj26;
						num3 = unchecked((nint)null);
						obj7 = 0;
					}
					num4++;
					bool flag7 = num4 != inOrderList._size;
					obj4 = obj7;
					if (!flag7)
					{
						return;
					}
					continue;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}
		throw new NullReferenceException();
	}

	public int GetCallbackCount(Type type)
	{
		//IL_0051: Expected I4, but got Obj
		if ((object)_inOrderByInterfaceList != null)
		{
			System.__Canon _Canon = ((Dictionary<System.__Canon, System.__Canon>)(object)_inOrderByInterfaceList).get_Item((System.__Canon)(object)type);
			if (_Canon != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v5 (System.__Canon)+18]");
				return 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public unsafe SimulationBehaviourListScope GetCallbackHead(Type type, int index, out SimulationBehaviour head)
	{
		//IL_00b4: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_00a6: Expected VT, but got I4
		if ((object)_inOrderByInterfaceList != null)
		{
			System.__Canon _Canon = ((Dictionary<System.__Canon, System.__Canon>)(object)_inOrderByInterfaceList).get_Item((System.__Canon)(object)type);
			if (_Canon != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B0]");
				object obj = 0;
				System.__Canon _Canon2 = ((List<System.__Canon>)_Canon).get_Item(index);
				if (_Canon2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6 (System.__Canon)+30]");
					ref SimulationBehaviour reference = ref *(SimulationBehaviour*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					SimulationBehaviourListScope simulationBehaviourListScope = new SimulationBehaviourListScope((BehaviourList)(object)_Canon2);
					return (SimulationBehaviourListScope)0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (SimulationBehaviourListScope)ex;
	}

	public void GetAllSimulationBehaviours(List<SimulationBehaviour> allSb)
	{
		//IL_0010: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_02bd: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		List<System.__Canon> inOrderList = (List<System.__Canon>)(object)_inOrderList;
		int num = 0;
		while (true)
		{
			bool flag2 = num < inOrderList._size;
			object obj5 = !flag2;
			if (num >= inOrderList._size)
			{
				break;
			}
			System.__Canon _Canon = inOrderList.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v11 (System.__Canon)+30]");
			System.__Canon _Canon2 = (System.__Canon)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v11 (System.__Canon)+30]");
			if ((nint)0 != 0)
			{
				object obj9;
				do
				{
					nint num2 = (nint)typeFromHandle;
					int hashCode = ((Enum)(object)typeFromHandle).GetHashCode();
					int num3 = hashCode & 1;
					bool flag3 = num3 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						SimulationBehaviour[] items = allSb._items;
						int version = allSb._version + 1;
						allSb._version = version;
						bool flag4 = allSb._size < items.Length;
						obj5 = !flag4;
						if (obj5 == null)
						{
							object obj7 = items + allSb._size;
							int size = allSb._size + 1;
							allSb._size = size;
							object obj8 = obj7 + 32;
							obj8 = _Canon2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							((List<System.__Canon>)(object)allSb).AddWithResize(_Canon2);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X23_v7 (System.__Canon)+28]");
					_Canon2 = (System.__Canon)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X23_v7 (System.__Canon)+28]");
					bool flag5 = (nint)0 == 0;
					obj9 = !flag5;
				}
				while (obj9 != null);
			}
			inOrderList = (List<System.__Canon>)(object)_inOrderList;
			num++;
			bool flag6 = _inOrderList == null;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	public unsafe void InvokeFixedUpdateNetwork(SimulationStages stage, SimulationModes mode, Topologies topology)
	{
		//IL_0875: Expected Obj, but got I
		//IL_088d: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I4
		//IL_071a: Expected Obj, but got Ref
		//IL_0768: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got Ref
		//IL_0740: Expected I, but got Obj
		//IL_0790: Expected Obj, but got I4
		//IL_00bc: Expected I4, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0196: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I4
		//IL_0214: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I4
		//IL_0286: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I4
		//IL_0331: Expected I4, but got Obj
		//IL_0346: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I8
		//IL_050f: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I
		//IL_03d4: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AF0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v7+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3+180]");
		SimulationStages simulationStages;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3+180]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			simulationStages = (SimulationStages)0;
		}
		else
		{
			simulationStages = stage;
		}
		List<BehaviourList> inOrderList = _inOrderList;
		bool flag = inOrderList._size < 1;
		OutOfMemoryException ex = null;
		object obj4 = 0;
		object obj10 = default;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B0]");
			object obj5 = 0;
			object obj7 = default;
			object obj6 = obj7;
			object obj8 = 0;
			object obj9 = (object)(&obj10);
			object obj12 = default;
			object obj11 = obj12;
			SimulationModes simulationModes2 = default;
			SimulationModes simulationModes = simulationModes2;
			SimulationStages simulationStages2 = simulationStages;
			int num = 0;
			SimulationModes simulationModes3;
			object obj17 = default;
			bool flag10;
			do
			{
				if (_inOrderList != null)
				{
					simulationModes3 = (SimulationModes)obj5;
					System.__Canon _Canon = ((List<System.__Canon>)(object)_inOrderList).get_Item(num);
					if (_Canon != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+28]");
						object obj13 = (nint)0 & (nint)1;
						bool flag2 = obj13 == null;
						simulationStages2 = (SimulationStages)num;
						if (!flag2)
						{
							Timer timer = Timer.StartNew();
							if (_Canon == null)
							{
								throw new NullReferenceException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+1C]");
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+1C]");
							object obj14 = ~(nint)0;
							object obj15 = simulationModes2 & obj14;
							bool flag3 = obj15 == null;
							object obj16 = !flag3;
							obj8 = 0;
							obj11 = obj17;
							simulationStages2 = (SimulationStages)num;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+20]");
								obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+20]");
								object obj18 = ~(nint)0;
								object obj19 = stage & obj18;
								bool flag4 = obj19 == null;
								object obj20 = !flag4;
								obj8 = 0;
								obj11 = obj17;
								simulationStages2 = (SimulationStages)num;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+24]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+24]");
									object obj21 = ~(nint)0;
									object obj22 = topology & obj21;
									bool flag5 = obj22 == null;
									object obj23 = !flag5;
									obj8 = 0;
									obj11 = obj17;
									simulationStages2 = (SimulationStages)num;
									if (obj23 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+30]");
										object obj24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6220]");
										object obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+40]");
										bool condition = (nint)0 == 0;
										Assert.Check(condition, (string)obj25);
										if (_Canon == null)
										{
											throw new NullReferenceException();
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v31 (System.__Canon)+40]");
										obj9 = (nint)0 + (nint)1;
										obj8 = 0;
										simulationStages2 = (SimulationStages)obj25;
										while (obj24 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+28]");
											object obj26 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+30]");
											object obj27 = (nint)0 & (nint)0x20;
											bool flag6 = obj27 == null;
											object obj28 = !flag6;
											if (obj28 == null)
											{
												if (stage == (SimulationStages)4)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+30]");
													object obj29 = (nint)0 & (nint)0x40;
													bool flag7 = obj29 == null;
													object obj30 = !flag7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+28]");
													obj24 = 0;
													if (obj30 != null)
													{
														continue;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+30]");
												object obj31 = (nint)0 & (nint)0x1C;
												bool flag8 = obj31 == null;
												object obj32 = !flag8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+28]");
												obj24 = 0;
												if (obj32 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+30]");
													object obj33 = (nint)0 & (nint)3;
													bool flag9 = obj33 == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+28]");
													obj24 = 0;
													if (!flag9)
													{
														object obj34 = obj26;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v31+1A8]");
														obj9 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v31+1B0]");
														simulationStages2 = (SimulationStages)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v564 @ X8_v31+1A8] (should have been resolved before IL gen)");
														object obj35 = obj8 + 1;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+28]");
														obj24 = 0;
														obj8 = obj35;
													}
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+30]");
												object obj36 = 0 & 0xFFFFFFDFL;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X24_v9+28]");
												obj24 = 0;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A4BD4");
										obj6 = obj24;
										obj11 = obj17;
										simulationModes3 = (SimulationModes)0;
									}
								}
							}
						}
						num++;
						flag10 = num != inOrderList._size;
						simulationModes = simulationModes3;
						continue;
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			while (flag10);
			ex = null;
			obj4 = 0;
			obj12 = obj11;
			simulationModes2 = simulationModes3;
			simulationStages = simulationStages2;
		}
		object obj37 = (object)(&obj10);
		if (obj37 != null)
		{
			ProfilerUnsafeUtility.EndSample((IntPtr)obj37);
			simulationStages = (SimulationStages)0;
		}
		bool flag11 = ex == null;
		object obj38 = !flag11;
		if (obj38 == null)
		{
			bool flag12 = obj4 == null;
			object obj39 = !flag12;
			OutOfMemoryException ex2 = ex;
			if (obj39 == null)
			{
				return;
			}
		}
		else
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		object obj41 = default;
		object obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	public unsafe void AddObject(NetworkRunner runner, NetworkObject obj, bool skipFirstCall, bool isInSimulation)
	{
		//IL_0ac7: Expected Obj, but got I
		//IL_0adf: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_091d: Expected Obj, but got I
		//IL_0930: Expected Obj, but got I4
		//IL_095c: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_0b25: Expected Obj, but got I4
		//IL_0a15: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0814: Expected Obj, but got Ref
		//IL_085e: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_083a: Expected I, but got Obj
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0700: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a5e: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I
		//IL_04a9: Expected Obj, but got I4
		//IL_04b1: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_054c: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I
		//IL_0aa8: Expected Obj, but got I
		//IL_05d3: Expected Obj, but got I
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AF0]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X24_v3+288]");
		NetworkRunner networkRunner;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X24_v3+288]");
			ProfilerUnsafeUtility.BeginSample((IntPtr)0);
			networkRunner = null;
		}
		else
		{
			networkRunner = runner;
		}
		NetworkObject networkObject = default;
		if ((object)networkObject == null)
		{
			goto IL_071b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6248]");
		object error = 0;
		bool flag = (object)networkObject._runner == null;
		object obj5 = !flag;
		object obj6 = ~obj5;
		bool condition;
		if (obj6 == null)
		{
			object obj7 = (object)networkObject._runner - (object)runner;
			condition = obj7 == null;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6230]");
		object error2 = 0;
		object obj8 = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)0x10000;
		bool condition2 = obj8 == null;
		Assert.Check(condition2, (string)error2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6228]");
		object obj9 = 0;
		if (isInSimulation)
		{
			NetworkObjectRuntimeFlags runtimeFlags = networkObject.RuntimeFlags | (NetworkObjectRuntimeFlags)0x10000;
			networkObject.RuntimeFlags = runtimeFlags;
		}
		SimulationBehaviour simulationBehaviour = (SimulationBehaviour)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj10 = default;
		bool flag2 = obj10 == null;
		bool flag3 = false;
		if (flag2)
		{
			goto IL_09b1;
		}
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v57+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v57+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v57+98]");
		object obj13 = (nint)0 + (nint)8;
		object obj14;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X10_v28-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj12--;
			obj14 = obj13 + 16;
			bool flag4 = (nint)obj12 != 1;
			obj13 = obj14;
			if (flag4)
			{
				continue;
			}
			goto IL_016a;
		}
		object obj15 = obj11 + obj13;
		object obj16 = obj15 + 312;
		obj14 = obj13;
		flag3 = false;
		goto IL_0a05;
		IL_06d3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06e1;
		IL_09b1:
		NetworkBehaviour[] networkedBehaviours = networkObject.NetworkedBehaviours;
		if (networkObject.NetworkedBehaviours == null)
		{
			goto IL_0669;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6238]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6240]");
		object obj18 = 0;
		object obj19 = 0;
		string text = (string)(object)simulationBehaviour;
		object obj35 = default;
		object obj42 = default;
		NetworkObject networkObject2;
		while (true)
		{
			bool flag5 = (nint)obj19 >= networkedBehaviours.Length;
			OutOfMemoryException ex2 = null;
			object obj20 = 0;
			if (!flag5)
			{
				bool flag6 = (nint)obj19 < networkedBehaviours.Length;
				object obj21 = !flag6;
				if (obj21 != null)
				{
					break;
				}
				object obj22 = (object)networkedBehaviours + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v38+20]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v38+20]");
				if ((nint)0 == 0)
				{
					goto IL_06a9;
				}
				text = (string)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v39+40]");
				object obj24 = 0 - networkObject;
				bool condition3 = obj24 == null;
				Assert.Check(condition3, (string)obj17);
				NetworkBehaviour[] networkedBehaviours2 = networkObject.NetworkedBehaviours;
				bool flag7 = networkObject.NetworkedBehaviours == null;
				flag3 = false;
				if (flag7)
				{
					goto IL_06c5;
				}
				bool flag8 = (nint)obj19 < networkedBehaviours2.Length;
				object obj25 = !flag8;
				flag3 = false;
				if (obj25 != null)
				{
					goto IL_06b7;
				}
				object obj26 = (object)networkObject.NetworkedBehaviours + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v42+20]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v42+20]");
				bool flag9 = (nint)0 == 0;
				flag3 = false;
				if (flag9)
				{
					goto IL_06d3;
				}
				text = (string)obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v43+38]");
				object obj28 = 0 - runner;
				bool condition4 = obj28 == null;
				Assert.Check(condition4, (string)obj18);
				NetworkBehaviour[] networkedBehaviours3 = networkObject.NetworkedBehaviours;
				bool flag10 = networkObject.NetworkedBehaviours == null;
				flag3 = false;
				if (flag10)
				{
					goto IL_068d;
				}
				bool flag11 = (nint)obj19 < networkedBehaviours3.Length;
				object obj29 = !flag11;
				flag3 = false;
				if (obj29 != null)
				{
					goto IL_069b;
				}
				object obj30 = (object)networkObject.NetworkedBehaviours + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v46+20]");
				simulationBehaviour = (SimulationBehaviour)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v46+20]");
				AddBehaviour((SimulationBehaviour)0, skipFirstCall);
				bool flag12 = !isInSimulation;
				flag3 = skipFirstCall;
				if (!flag12)
				{
					NetworkBehaviour[] networkedBehaviours4 = networkObject.NetworkedBehaviours;
					bool flag13 = networkObject.NetworkedBehaviours == null;
					flag3 = skipFirstCall;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v46+20]");
					text = (string)0;
					if (flag13)
					{
						goto IL_06e1;
					}
					bool flag14 = (nint)obj19 < networkedBehaviours4.Length;
					object obj31 = !flag14;
					networkObject2 = (NetworkObject)skipFirstCall;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v46+20]");
					networkRunner = (NetworkRunner)0;
					if (obj31 != null)
					{
						goto IL_070d;
					}
					object obj32 = (object)networkObject.NetworkedBehaviours + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v50+20]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v50+20]");
					bool flag15 = (nint)0 == 0;
					flag3 = skipFirstCall;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X8_v46+20]");
					text = (string)0;
					if (flag15)
					{
						goto IL_06ef;
					}
					simulationBehaviour = (SimulationBehaviour)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X0_v57+30]");
					object obj34 = (nint)0 | (nint)2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag16 = obj35 == null;
					flag3 = skipFirstCall;
					if (!flag16)
					{
						object obj36 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v53+12E]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v53+12E]");
						if ((nint)0 == 0)
						{
							goto IL_061c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v53+98]");
						object obj38 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X10_v22-8]");
							if (0 == (nint)obj9)
							{
								break;
							}
							obj37--;
							obj14 = obj38 + 16;
							bool flag17 = (nint)obj37 != 1;
							obj38 = obj14;
							if (flag17)
							{
								continue;
							}
							goto IL_061c;
						}
						object obj39 = obj36 + obj38;
						object obj40 = obj39 + 312;
						obj14 = obj38;
						flag3 = skipFirstCall;
						goto IL_0a98;
					}
				}
				goto IL_0a24;
			}
			object obj41 = (object)(&obj42);
			if (obj41 != null)
			{
				ProfilerUnsafeUtility.EndSample((IntPtr)obj41);
				text = null;
			}
			bool flag18 = ex2 == null;
			object obj43 = !flag18;
			if (obj43 == null)
			{
				bool flag19 = obj20 == null;
				object obj44 = !flag19;
				OutOfMemoryException ex3 = ex2;
				if (obj44 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
			IL_061c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			flag3 = false;
			goto IL_0a98;
			IL_0a98:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v59+8]");
			simulationBehaviour = (SimulationBehaviour)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v926 @ X0_v59] (should have been resolved before IL gen)");
			goto IL_0a24;
			IL_0a24:
			networkedBehaviours = networkObject.NetworkedBehaviours;
			obj19++;
			bool flag20 = networkObject.NetworkedBehaviours == null;
			object obj45 = !flag20;
			text = (string)(object)simulationBehaviour;
			if (obj45 != null)
			{
				continue;
			}
			goto IL_0669;
		}
		goto IL_067f;
		IL_0a05:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v65+8]");
		simulationBehaviour = (SimulationBehaviour)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v523 @ X0_v65] (should have been resolved before IL gen)");
		goto IL_09b1;
		IL_06c5:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_06d3;
		IL_067f:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_068d;
		IL_0669:
		NullReferenceException ex6 = new NullReferenceException();
		text = (string)(object)simulationBehaviour;
		goto IL_067f;
		IL_071b:
		throw new NullReferenceException();
		IL_068d:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_069b;
		IL_069b:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_06a9;
		IL_06a9:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_06b7;
		IL_070d:
		IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
		goto IL_071b;
		IL_06ef:
		NullReferenceException ex11 = new NullReferenceException();
		networkObject2 = (NetworkObject)flag3;
		networkRunner = (NetworkRunner)(object)text;
		goto IL_070d;
		IL_06e1:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_06ef;
		IL_06b7:
		IndexOutOfRangeException ex13 = new IndexOutOfRangeException();
		goto IL_06c5;
		IL_016a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag3 = false;
		goto IL_0a05;
	}

	public unsafe void AddBehaviour(SimulationBehaviour behaviour, bool skipFirstCall)
	{
		//IL_0034: Expected I4, but got I8
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I4
		//IL_04a5: Expected Obj, but got I8
		//IL_03ab: Expected I4, but got I8
		//IL_04d6: Expected I, but got Obj
		//IL_0429: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I8
		//IL_09c6: Expected Obj, but got I
		//IL_09f0: Expected Obj, but got I4
		//IL_0546: Expected I, but got Obj
		//IL_05c2: Expected Obj, but got I
		//IL_05ca: Expected I4, but got Obj
		//IL_062e: Expected Obj, but got I4
		//IL_0862: Expected Obj, but got I4
		//IL_0673: Expected Obj, but got I8
		//IL_06a4: Expected I, but got Obj
		//IL_06e3: Expected Obj, but got I8
		//IL_0a87: Expected Obj, but got I4
		//IL_0714: Expected I, but got Obj
		//IL_0765: Expected Obj, but got I8
		//IL_0796: Expected I, but got Obj
		//IL_07e6: Expected Obj, but got I8
		//IL_0b1e: Expected Obj, but got I4
		//IL_0b2b: Expected Obj, but got I
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected I4, but got Unknown
		//IL_0817: Expected I, but got Obj
		bool flag = default;
		SimulationBehaviourRuntimeFlags flags = ((!flag) ? ((SimulationBehaviourRuntimeFlags)((long)behaviour.Flags & 0xFFFFFFDFL)) : (behaviour.Flags | (SimulationBehaviourRuntimeFlags)0x20));
		behaviour.Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		Type type = default;
		BehaviourList behaviourList = FindList(type);
		object obj = behaviourList + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj2 = 0;
		object obj3 = obj;
		while (obj3 != behaviour)
		{
			obj3 += 40;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				break;
			}
		}
		if (obj3 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v75+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v76+38]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v76+38]");
			if ((nint)0 != 0)
			{
				BitSet64.NameDeferred name = BehaviourUtils.GetName(behaviour);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6268]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6260]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6250]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6270]");
				object format = 0;
				object arg = default;
				object arg2 = default;
				string text = string.Format((string)format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X22_v11+18]");
				object obj11 = 0;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X9_v12+188] (should have been resolved before IL gen)");
			}
			return;
		}
		SimulationBehaviour simulationBehaviour = (SimulationBehaviour)obj;
		if ((object)behaviour._object != null)
		{
			if (obj != null)
			{
				object obj14;
				Span<int> span = default;
				do
				{
					bool flag3 = (object)simulationBehaviour._object == null;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						simulationBehaviour = simulationBehaviour.Next;
						bool flag4 = (object)simulationBehaviour.Next == null;
						obj14 = !flag4;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
					object obj15 = 0;
					while ((object)simulationBehaviour.Next != null)
					{
						NetworkObject networkObject = simulationBehaviour._object;
						int* ptr = networkObject.Ptr;
						if (networkObject.Ptr != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X25_v7 (System.Int32*)+4]");
							object obj16 = 0 & -9223372036854775808L;
							if (obj16 != null)
							{
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
							}
						}
						nint num;
						if (span.IsEmpty)
						{
							num = unchecked((nint)null);
						}
						else
						{
							int* ptr2 = networkObject.Ptr;
							num = (nint)ptr2;
						}
						NetworkObject networkObject2 = behaviour._object;
						int* ptr3 = networkObject2.Ptr;
						if (networkObject2.Ptr != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X24_v8 (System.Int32*)+4]");
							object obj17 = 0 & -9223372036854775808L;
							if (obj17 != null)
							{
								System.ThrowHelper.ThrowArgumentOutOfRangeException();
							}
						}
						nint num2;
						if (span.IsEmpty)
						{
							num2 = unchecked((nint)null);
						}
						else
						{
							int* ptr4 = networkObject2.Ptr;
							num2 = (nint)ptr4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
						object obj18 = 0;
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X0_v37+E4]");
						bool flag5 = (nint)0 == 0;
						object obj20 = !flag5;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (num != num2)
						{
							if ((object)behaviourList.PendingRemovals != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6258]");
								object obj21 = 0;
								flag = (byte)(int)obj21 != 0;
								if (((List<System.__Canon>)(object)behaviourList.PendingRemovals).Contains((System.__Canon)(object)simulationBehaviour.Next))
								{
									simulationBehaviour = simulationBehaviour.Next;
									bool flag6 = (object)simulationBehaviour.Next == null;
									object obj22 = !flag6;
									if (obj22 == null)
									{
										throw new NullReferenceException();
									}
									goto IL_0836;
								}
							}
							NetworkObject networkObject3 = simulationBehaviour._object;
							int* ptr5 = networkObject3.Ptr;
							if (networkObject3.Ptr != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X24_v12 (System.Int32*)+4]");
								object obj23 = 0 & -9223372036854775808L;
								if (obj23 != null)
								{
									System.ThrowHelper.ThrowArgumentOutOfRangeException();
								}
							}
							nint num3;
							if (span.IsEmpty)
							{
								num3 = unchecked((nint)null);
							}
							else
							{
								int* ptr6 = networkObject3.Ptr;
								num3 = (nint)ptr6;
							}
							NetworkObject networkObject4 = behaviour._object;
							int* ptr7 = networkObject4.Ptr;
							if (networkObject4.Ptr != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X24_v13 (System.Int32*)+4]");
								object obj24 = 0 & -9223372036854775808L;
								if (obj24 != null)
								{
									System.ThrowHelper.ThrowArgumentOutOfRangeException();
								}
							}
							nint num4;
							if (span.IsEmpty)
							{
								num4 = unchecked((nint)null);
							}
							else
							{
								int* ptr8 = networkObject4.Ptr;
								num4 = (nint)ptr8;
							}
							bool flag7 = num3 < num4;
							object obj25 = !flag7;
							if (obj25 == null)
							{
								NetworkObject networkObject5 = behaviour._object;
								int* ptr9 = networkObject5.Ptr;
								if (networkObject5.Ptr != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X24_v14 (System.Int32*)+4]");
									object obj26 = 0 & -9223372036854775808L;
									if (obj26 != null)
									{
										System.ThrowHelper.ThrowArgumentOutOfRangeException();
									}
								}
								nint num5;
								if (span.IsEmpty)
								{
									num5 = unchecked((nint)null);
								}
								else
								{
									int* ptr10 = networkObject5.Ptr;
									num5 = (nint)ptr10;
								}
								SimulationBehaviour next = simulationBehaviour.Next;
								NetworkObject networkObject6 = next._object;
								int* ptr11 = networkObject6.Ptr;
								if (networkObject6.Ptr != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X24_v15 (System.Int32*)+4]");
									object obj27 = 0 & -9223372036854775808L;
									if (obj27 != null)
									{
										System.ThrowHelper.ThrowArgumentOutOfRangeException();
									}
								}
								nint num6;
								if (span.IsEmpty)
								{
									num6 = unchecked((nint)null);
								}
								else
								{
									int* ptr12 = networkObject6.Ptr;
									num6 = (nint)ptr12;
								}
								bool flag8 = num5 < num6;
								object obj28 = !flag8;
								object obj29 = num5 - num6;
								bool flag9 = obj29 == null;
								object obj30 = ~obj28;
								if (((obj30 | flag9) ? 1 : 0) != 0)
								{
									goto IL_0887;
								}
							}
							goto IL_0836;
						}
						goto IL_0887;
						IL_0887:
						behaviourList.AddAfter(behaviour, simulationBehaviour);
						return;
						IL_0836:
						simulationBehaviour = simulationBehaviour.Next;
						bool flag10 = (object)simulationBehaviour.Next == null;
						object obj31 = !flag10;
						if (obj31 == null)
						{
							break;
						}
					}
					break;
				}
				while (obj14 != null);
			}
			behaviourList.AddLast(behaviour);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		object obj33 = default;
		object obj32 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v6+1C0]");
		string text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v541 @ X8_v6+1B8] (should have been resolved before IL gen)");
		if (obj != null)
		{
			bool flag11 = flag;
			object obj37 = default;
			string a = default;
			string text3 = default;
			object obj39 = default;
			string text4 = default;
			while (true)
			{
				SimulationBehaviour next2 = simulationBehaviour.Next;
				bool flag12 = (object)simulationBehaviour.Next == null;
				flag = flag11;
				if (flag12)
				{
					break;
				}
				bool flag13 = (object)simulationBehaviour._object == null;
				object obj34 = !flag13;
				if (obj34 != null)
				{
					return;
				}
				bool flag14 = (object)next2._object == null;
				object obj35 = !flag14;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
					object obj36 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v630 @ X8_v12+1B8] (should have been resolved before IL gen)");
					int num7 = Fusion.FusionString.CompareOrdinal(a, text3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
					object obj38 = obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v573 @ X8_v14+1B8] (should have been resolved before IL gen)");
					int num8 = Fusion.FusionString.CompareOrdinal(text3, text4);
					if ((int)(num7 & 0x80000000L) != 0)
					{
						bool flag15 = num8 == 0;
						if (num8 <= 0)
						{
							goto IL_0875;
						}
					}
					simulationBehaviour = simulationBehaviour.Next;
					bool flag16 = (object)simulationBehaviour.Next == null;
					object obj40 = !flag16;
					flag = false;
					flag11 = false;
					text2 = text4;
					if (obj40 == null)
					{
						break;
					}
					continue;
				}
				goto IL_0875;
				IL_0875:
				behaviourList.AddAfter(behaviour, simulationBehaviour);
				return;
			}
		}
		behaviourList.AddFirst(behaviour);
	}

	public void RemoveBehaviour(SimulationBehaviour behaviour)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		//IL_025d: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62F0]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
		Type type = default;
		BehaviourList behaviourList = FindList(type);
		object obj = behaviour.Flags & (SimulationBehaviourRuntimeFlags)4;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v7+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+38]");
		object obj5 = 0;
		if (behaviourList.LockCount >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+38]");
			if ((nint)0 != 0)
			{
				BitSet64.NameDeferred name = BehaviourUtils.GetName(behaviour);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6268]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6260]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6250]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62E8]");
				object format = 0;
				object arg = default;
				object arg2 = default;
				string text = string.Format((string)format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v2+10]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X9_v7+188] (should have been resolved before IL gen)");
			}
			SimulationBehaviourRuntimeFlags flags = behaviour.Flags | (SimulationBehaviourRuntimeFlags)4;
			behaviour.Flags = flags;
			behaviourList.PendingRemove(behaviour);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+38]");
			if ((nint)0 != 0)
			{
				BitSet64.NameDeferred name2 = BehaviourUtils.GetName(behaviour);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6268]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6260]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6250]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D62F8]");
				object format2 = 0;
				object arg3 = default;
				object arg4 = default;
				string text2 = string.Format((string)format2, arg3, arg4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v2+10]");
				object obj14 = 0;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X9_v5+188] (should have been resolved before IL gen)");
			}
			behaviourList.Remove(behaviour);
		}
	}

	public unsafe SimulationBehaviour[] GetTypeHeads(Type type)
	{
		//IL_093c: Expected I4, but got Obj
		//IL_0945: Expected VT, but got I4
		//IL_094d: Expected Obj, but got I
		//IL_095e: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0066: Expected I4, but got Obj
		//IL_006e: Expected Obj, but got Ref
		//IL_0077: Expected Obj, but got I4
		//IL_0689: Invalid comparison between VT and I4
		//IL_0697: Expected Obj, but got VT
		//IL_05ba: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got VT
		//IL_00e8: Expected Obj, but got Ref
		//IL_067b: Expected Obj, but got VT
		//IL_0116: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_014f: Expected Obj, but got Ref
		//IL_098a: Expected Obj, but got I4
		//IL_0229: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_0539: Expected Obj, but got I4
		//IL_0382: Expected I, but got Obj
		//IL_038a: Expected I4, but got Obj
		//IL_0427: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I
		//IL_044e: Expected Obj, but got I
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_048c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEEBD]");
		nint num = 0;
		bool flag = (object)_byTypeHierarchy == null;
		int num2 = (int)type;
		(System.__Canon, System.__Canon) value = ((System.__Canon, System.__Canon))0;
		IntPtr intPtr = default;
		System.__Canon _Canon = (System.__Canon)(nint)intPtr;
		Type key = type;
		List<System.__Canon> list = (List<System.__Canon>)109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6328]");
			num = 0;
			int num3 = (int)num;
			bool flag2 = ((Dictionary<System.__Canon, (System.__Canon, System.__Canon)>)(object)_byTypeHierarchy).TryGetValue((System.__Canon)(object)type, out value);
			bool flag3 = !flag2;
			object obj = !flag3;
			num2 = (int)type;
			_Canon = (System.__Canon)(&value);
			list = (List<System.__Canon>)109895680;
			if (obj != null)
			{
				goto IL_0680;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6350]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6340]");
			num = 0;
			num2 = (int)num;
			List<System.__Canon> list2 = default;
			list2._002Ector();
			List<System.__Canon> inOrderList = (List<System.__Canon>)(object)_inOrderList;
			bool flag4 = _inOrderList == null;
			_Canon = (System.__Canon)(&value);
			key = type;
			list = list2;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D58B0]");
				System.__Canon _Canon2 = (System.__Canon)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6330]");
				object obj3 = 0;
				int num5 = default;
				int num4 = num5;
				int num7 = default;
				int num6 = num7;
				int num8 = 0;
				int num9 = (int)num;
				System.__Canon _Canon3 = (System.__Canon)(&value);
				while (true)
				{
					bool flag5 = num8 < inOrderList._size;
					object obj4 = !flag5;
					bool flag6 = num8 >= inOrderList._size;
					num5 = num4;
					num7 = num6;
					int num10 = num8;
					num2 = num9;
					_Canon = _Canon3;
					num = inOrderList._size;
					key = type;
					list = list2;
					if (flag6)
					{
						break;
					}
					_Canon = _Canon2;
					System.__Canon _Canon4 = inOrderList.get_Item(num8);
					bool flag7 = _Canon4 == null;
					num5 = num4;
					num7 = num6;
					num10 = num8;
					num2 = num8;
					num = inOrderList._size;
					key = type;
					list = list2;
					if (!flag7)
					{
						bool flag8 = (object)type == null;
						num5 = num4;
						num7 = num6;
						num10 = num8;
						num2 = num8;
						num = inOrderList._size;
						key = type;
						list = list2;
						if (!flag8)
						{
							num = (nint)type;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v35 (System.__Canon)+10]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17 (Il2CppClass<System.Type>)+298]");
							num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17 (Il2CppClass<System.Type>)+2A0]");
							_Canon = (System.__Canon)0;
							Type elementType = ((System.RuntimeType)type).GetElementType();
							object obj5 = elementType & 1;
							if (obj5 == null)
							{
								goto IL_0505;
							}
							bool flag9 = _inOrderList == null;
							num5 = num4;
							num10 = num8;
							key = type;
							list = list2;
							if (!flag9)
							{
								_Canon = _Canon2;
								System.__Canon _Canon5 = ((List<System.__Canon>)(object)_inOrderList).get_Item(num8);
								bool flag10 = _Canon5 == null;
								num5 = num4;
								num10 = num8;
								num2 = num8;
								key = type;
								list = list2;
								if (!flag10)
								{
									bool flag11 = list2 == null;
									num5 = num4;
									num10 = num8;
									num2 = num8;
									key = type;
									list = list2;
									if (!flag11)
									{
										num = (nint)list2._items;
										num7 = (int)obj3;
										num5 = list2._version + 1;
										list2._version = num5;
										bool flag12 = list2._items == null;
										num10 = num8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v41 (System.__Canon)+10]");
										num2 = 0;
										key = type;
										list = list2;
										if (!flag12)
										{
											num4 = list2._size;
											int size = list2._size;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17 (Il2CppClass<System.Type>)+18]");
											bool flag13 = (nint)size < (nint)0;
											obj4 = !flag13;
											if (obj4 == null)
											{
												object obj6 = num + list2._size;
												num7 = ++list2._size;
												object obj7 = obj6 + 32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v41 (System.__Canon)+10]");
												obj7 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v41 (System.__Canon)+10]");
												num2 = 0;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v3 (System.Int32)+20]");
												object obj8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v38+A8]");
												num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17 (Il2CppClass<System.Type>)+70]");
												_Canon = (System.__Canon)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v41 (System.__Canon)+10]");
												list2.AddWithResize((System.__Canon)0);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v41 (System.__Canon)+10]");
												num2 = 0;
											}
											goto IL_0505;
										}
									}
								}
							}
						}
					}
					goto IL_057f;
					IL_0505:
					inOrderList = (List<System.__Canon>)(object)_inOrderList;
					num10 = num8 + 1;
					bool flag14 = _inOrderList == null;
					object obj9 = !flag14;
					num5 = num4;
					key = type;
					list = list2;
					num6 = num7;
					num8 = num10;
					num9 = num2;
					_Canon3 = _Canon;
					if (obj9 != null)
					{
						continue;
					}
					goto IL_057f;
				}
				goto IL_058d;
			}
		}
		goto IL_057f;
		IL_058d:
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6358]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			System.__Canon[] array = list.ToArray();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6360]");
			num = 0;
			int num3 = (int)num;
			System.__Canon _Canon6 = default;
			(System.__Canon, System.__Canon) tuple = (_Canon6, (System.__Canon)(object)array);
			bool flag15 = (object)_byTypeHierarchy == null;
			System.__Canon _Canon2 = _Canon6;
			value = tuple;
			_Canon = (System.__Canon)(object)array;
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6320]");
				num = 0;
				((Dictionary<System.__Canon, (System.__Canon, System.__Canon)>)(object)_byTypeHierarchy).Add((System.__Canon)(object)key, tuple);
				_Canon2 = _Canon6;
				num3 = 0;
				value = tuple;
				_Canon = tuple;
				goto IL_0680;
			}
		}
		goto IL_057f;
		IL_057f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_058d;
		IL_0680:
		bool flag16 = value == ((System.__Canon, System.__Canon))(object)0;
		key = (Type)value;
		if (!flag16)
		{
			int num11 = 0;
			int num10 = 0;
			key = (Type)value;
		}
		goto IL_057f;
	}

	private void AddType(Type type, SimulationBehaviourMeta meta)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BehaviourList behaviourList = default;
		behaviourList._002Ector();
		object obj2 = behaviourList + 16;
		obj2 = type;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = meta.Modes;
		_ = meta.Stages;
		_ = meta.Topologies;
		int executionOrder = GetExecutionOrder(type);
		BehaviourCallbackFlags behaviourCallbackFlags = BehaviourCallbackOverrides.Compute(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6210]");
		object obj3 = 0;
		((Dictionary<System.__Canon, System.__Canon>)(object)_byTypeLookup).Add((System.__Canon)(object)type, (System.__Canon)(object)behaviourList);
		List<System.__Canon> inOrderList = (List<System.__Canon>)(object)_inOrderList;
		System.__Canon[] items = inOrderList._items;
		int version = inOrderList._version + 1;
		inOrderList._version = version;
		bool flag = inOrderList._size < items.Length;
		object obj4 = !flag;
		if (obj4 == null)
		{
			object obj5 = items + inOrderList._size;
			int size = inOrderList._size + 1;
			inOrderList._size = size;
			object obj6 = obj5 + 32;
			obj6 = behaviourList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			inOrderList.AddWithResize((System.__Canon)(object)behaviourList);
		}
	}

	private unsafe BehaviourList FindList(Type type)
	{
		//IL_0547: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I4
		//IL_00b1: Expected VT, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_02b3: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I4
		//IL_0197: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_040f: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I
		//IL_044f: Expected Obj, but got I4
		bool flag = (object)_byTypeLookup == null;
		System.__Canon _Canon = (System.__Canon)(object)type;
		Type type2 = (Type)109895680;
		System.__Canon value;
		object arg;
		nint num;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6278]");
			object obj = 0;
			object obj2 = obj;
			bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)(object)_byTypeLookup).TryGetValue((System.__Canon)(object)type, out value);
			bool flag3 = !flag2;
			object obj3 = !flag3;
			if (obj3 != null)
			{
				goto IL_0256;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5840]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj5 = 0;
			System.__Canon _Canon2 = (System.__Canon)(object)type;
			num = (nint)(&value);
			type2 = type;
			Func<KeyValuePair<System.__Canon, System.__Canon>, System.__Canon> func3 = default;
			IntPtr intPtr2 = default;
			object obj18 = default;
			string separator = default;
			string[] value2 = default;
			string format = default;
			InvalidOperationException ex = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X25_v9+E8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v75+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj4);
				bool flag5 = (object)typeFromHandle == null;
				_Canon = null;
				if (flag5)
				{
					break;
				}
				nint num2 = (nint)typeFromHandle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v16 (Il2CppClass<System.Type>)+2A0]");
				num = 0;
				Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
				object obj8 = elementType & 1;
				bool flag6 = obj8 == null;
				_Canon = (System.__Canon)(object)type2;
				arg = type2;
				if (!flag6)
				{
					bool flag7 = (object)_byTypeLookup == null;
					_Canon = (System.__Canon)(object)type2;
					if (flag7)
					{
						break;
					}
					obj2 = obj;
					bool flag8 = ((Dictionary<System.__Canon, System.__Canon>)(object)_byTypeLookup).TryGetValue((System.__Canon)(object)type2, out value);
					bool flag9 = !flag8;
					object obj9 = !flag9;
					if (obj9 == null)
					{
						bool flag10 = (object)type2 == null;
						_Canon = (System.__Canon)(object)type2;
						num = (nint)(&value);
						if (flag10)
						{
							break;
						}
						nint num3 = (nint)type2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v19 (Il2CppClass<System.Type>)+870]");
						_Canon2 = (System.__Canon)0;
						Type type3 = (Type)((object)type2).Equals((object)0);
						num = (nint)(&value);
						type2 = type3;
						continue;
					}
					goto IL_020e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v10+E4]");
				bool flag11 = (nint)0 == 0;
				object obj10 = !flag11;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v14+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v5+18]");
				Func<KeyValuePair<System.__Canon, System.__Canon>, System.__Canon> func = (Func<KeyValuePair<System.__Canon, System.__Canon>, System.__Canon>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v5+18]");
				bool flag12 = (nint)0 == 0;
				object obj12 = !flag12;
				Func<KeyValuePair<System.__Canon, System.__Canon>, System.__Canon> func2 = (Func<KeyValuePair<System.__Canon, System.__Canon>, System.__Canon>)1;
				IntPtr intPtr = num;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v49+E4]");
					bool flag13 = (nint)0 == 0;
					object obj13 = !flag13;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v52+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					func3._002Ector(obj14, intPtr2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v62+A0]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v64+A0]");
					object obj16 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					func = func3;
					obj2 = 0;
					func2 = func3;
					intPtr = intPtr2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A4DB8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X8_v7+168] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
				string arg2 = string.Join(separator, value2);
				string message = string.Format(format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				return (BehaviourList)(object)new ArgumentNullException();
			}
		}
		goto IL_025b;
		IL_0256:
		return (BehaviourList)(object)value;
		IL_025b:
		arg = type2;
		throw new NullReferenceException();
		IL_020e:
		bool flag14 = (object)_byTypeLookup == null;
		_Canon = (System.__Canon)(object)type2;
		num = (nint)(&value);
		if (!flag14)
		{
			((Dictionary<System.__Canon, System.__Canon>)(object)_byTypeLookup).Add((System.__Canon)(object)type, value);
			goto IL_0256;
		}
		goto IL_025b;
	}

	public unsafe void FinishBehaviourStatisticsPendingSnapshot()
	{
		//IL_01f9: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got I4
		//IL_0241: Expected I, but got Obj
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Ref, but got Unknown
		//IL_0264: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got I4
		bool flag = _inOrderList == null;
		object obj = 109895680;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6380]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6378]");
			obj = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)_inOrderList).GetEnumerator();
			nint num = (nint)obj2;
			Enumerator<, > val = default;
			object obj3;
			object obj4;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				obj3 = 0;
				obj4 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj5 = 0;
				object obj8 = default;
				while (true)
				{
					num = (nint)obj;
					((Enumerator<, >*)val2)->Dispose();
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						bool flag3 = obj3 == null;
						object obj7 = !flag3;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj7 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj3 = 1;
						obj5 = obj4;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj5 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj4 = obj8;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A4DBC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				return;
			}
			object obj9 = 0;
			NullReferenceException ex2 = new NullReferenceException();
			NullReferenceException ex3 = new NullReferenceException();
			obj3 = 0;
			obj4 = 0;
			val2 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	public unsafe bool TryGetBehaviourStatisticsSnapshot(Type behaviourType, out BehaviourStatisticsSnapshot behaviourStatisticsSnapshot)
	{
		//IL_00cc: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		bool flag;
		object obj2;
		if ((object)_byTypeLookup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6278]");
			object obj = 0;
			flag = ((Dictionary<System.__Canon, System.__Canon>)(object)_byTypeLookup).TryGetValue((System.__Canon)(object)behaviourType, out System.__Canon value);
			if (!flag)
			{
				obj2 = 0;
				goto IL_00eb;
			}
			if (value != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ stack_-28_v3 (System.__Canon)+50]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ stack_-28_v3 (System.__Canon)+50]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v8+10]");
					obj2 = 0;
					goto IL_00eb;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00eb:
		ref BehaviourStatisticsSnapshot reference = ref *(BehaviourStatisticsSnapshot*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return flag;
	}
}
