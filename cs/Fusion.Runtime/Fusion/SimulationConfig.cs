using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.Rendering;

namespace Fusion;

[Serializable]
public class SimulationConfig : _0021_00210
{
	internal class List : _0021_00210, Action<GillaCloud.Reply>
	{
		private sealed class _003Cget_Connections_003Ed__165 : Action<DebugUI.Panel>, _0021_00210, Action<DebugUI.Widget>, _0021_00210, Action<DebugUI.Widget>
		{
			private int _003C_003E1__state;

			private SimulationConnection _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Simulation _003C_003E4__this;

			private Dictionary<int, SimulationConnection>.Enumerator _003C_003Es__1;

			private SimulationConnection _003Cvalue_003E5__2;

			private SimulationConnection System_002ECollections_002EGeneric_002EIEnumerator_003CFusion_002ESimulationConnection_003E_002ECurrent => _003C_003E2__current;

			private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

			public _003Cget_Connections_003Ed__165(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				_003C_003El__initialThreadId = currentManagedThreadId;
			}

			private void System_002EIDisposable_002EDispose()
			{
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected Obj, but got Unknown
				//IL_0078: Expected VT, but got I4
				//IL_0097: Expected I4, but got I8
				//IL_002f: Expected Obj, but got I4
				//IL_0049: Expected Obj, but got I4
				if (_003C_003E1__state != 1)
				{
					object obj = _003C_003E1__state + 3;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 != null)
					{
						goto IL_0062;
					}
				}
				_003C_003Em__Finally1();
				goto IL_0062;
				IL_0062:
				object obj3 = this + 72;
				_003C_003Es__1 = (Dictionary<int, SimulationConnection>.Enumerator)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_003C_003E1__state = -2;
			}

			private unsafe bool MoveNext()
			{
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Expected Obj, but got Unknown
				//IL_03f8: Expected Obj, but got I
				//IL_0400: Expected I, but got Obj
				//IL_0409: Unknown result type (might be due to invalid IL or missing references)
				//IL_040e: Expected VT, but got Unknown
				//IL_0417: Expected Ref, but got VT
				//IL_0021: Expected Obj, but got I4
				//IL_0194: Expected VT, but got I4
				//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Expected Obj, but got Unknown
				//IL_0114: Expected Obj, but got I
				//IL_012b: Expected I, but got Obj
				//IL_0134: Unknown result type (might be due to invalid IL or missing references)
				//IL_0139: Expected Obj, but got Unknown
				//IL_0051: Expected I4, but got I8
				//IL_0398: Expected Obj, but got I
				//IL_03a0: Expected I, but got Obj
				//IL_03d1: Expected Obj, but got I4
				//IL_0092: Expected Obj, but got I
				//IL_0208: Expected Obj, but got I
				//IL_0210: Expected I, but got Obj
				//IL_0268: Unknown result type (might be due to invalid IL or missing references)
				//IL_026d: Expected Obj, but got Unknown
				//IL_028e: Expected I4, but got I8
				_003Cget_Connections_003Ed__165 obj7 = default;
				_003Cget_Connections_003Ed__165 obj10;
				nint num4 = default;
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					bool flag2 = false;
					if (obj == null)
					{
						Simulation simulation = _003C_003E4__this;
						_003C_003E1__state = -1;
						if ((object)_003C_003E4__this == null)
						{
							NullReferenceException ex = new NullReferenceException();
							goto IL_02a9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
						object obj2 = 0;
						nint num = (nint)simulation;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X9_v12 (Il2CppClass<Fusion.Simulation>)+130]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v22+130]");
						bool flag3 = num2 < 0;
						object obj4 = !flag3;
						object obj5 = ~obj4;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X9_v12 (Il2CppClass<Fusion.Simulation>)+B0]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v22+130]");
							object obj6 = num3 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X9_v15-8]");
							if (0 == (nint)obj3)
							{
								Simulation simulation2 = obj7._003C_003E4__this;
								if ((object)obj7._003C_003E4__this == null)
								{
									goto IL_02a9;
								}
								if (simulation2._connections == null)
								{
									goto IL_02b7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7C00]");
								object obj8 = 0;
								num4 = (nint)obj8;
								ValueCollection<> values = ((Dictionary<int, System.__Canon>)(object)simulation2._connections).Values;
								if (values == null)
								{
									goto IL_02c5;
								}
								Dictionary<int, System.__Canon>.Enumerator enumerator = (Dictionary<int, System.__Canon>.Enumerator)values.GetEnumerator();
								Dictionary<int, SimulationConnection>.Enumerator enumerator2 = default;
								obj7._003C_003Es__1 = enumerator2;
								object obj9 = obj7 + 48;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								obj7._003C_003E1__state = -3;
								obj10 = obj7;
								goto IL_03e8;
							}
						}
						flag2 = false;
					}
					goto IL_033a;
				}
				object obj11 = this + 72;
				_ = 0;
				_ = 4294967293L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj10 = obj7;
				goto IL_03e8;
				IL_02a9:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_02b7;
				IL_02c5:
				NullReferenceException ex3 = new NullReferenceException();
				bool flag4 = num4 != 1;
				OutOfMemoryException ex4 = (OutOfMemoryException)(object)ex3;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj12 = default;
					bool flag5 = obj12 == null;
					bool flag2 = false;
					if (flag5)
					{
						return flag2;
					}
					goto IL_033a;
				}
				goto IL_0438;
				IL_0438:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AE670");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
				IL_03e8:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7C10]");
				object obj13 = 0;
				num4 = (nint)obj13;
				Dictionary<int, System.__Canon>.Enumerator enumerator3 = (Dictionary<int, System.__Canon>.Enumerator)(obj10 + 48);
				if (((Dictionary<int, System.__Canon>.Enumerator*)enumerator3)->MoveNext())
				{
					object obj14 = obj7 + 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ stack_-18_v2 (Fusion.SimulationConfig+List+<get_Connections>d__165)+40]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					num4 = (nint)obj7._003Cvalue_003E5__2;
					object obj15 = obj7 + 24;
					obj15 = obj7._003Cvalue_003E5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj7._003C_003E1__state = 1;
					bool flag2 = true;
				}
				else
				{
					obj7._003C_003Em__Finally1();
					_ = 0;
					_ = 0;
					obj7._003C_003Es__1 = (Dictionary<int, SimulationConnection>.Enumerator)0;
					bool flag2 = false;
				}
				goto IL_033a;
				IL_02b7:
				NullReferenceException ex5 = new NullReferenceException();
				goto IL_02c5;
				IL_033a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AE970");
				OutOfMemoryException ex6 = new OutOfMemoryException();
				ex4 = ex6;
				goto IL_0438;
			}

			private unsafe void _003C_003Em__Finally1()
			{
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0011: Expected VT, but got Unknown
				//IL_0020: Expected I4, but got I8
				//IL_0029: Expected Ref, but got VT
				Dictionary<int, System.__Canon>.Enumerator enumerator = (Dictionary<int, System.__Canon>.Enumerator)(this + 48);
				_003C_003E1__state = -1;
				((Dictionary<int, System.__Canon>.Enumerator*)enumerator)->Dispose();
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

			private IEnumerator<SimulationConnection> System_002ECollections_002EGeneric_002EIEnumerable_003CFusion_002ESimulationConnection_003E_002EGetEnumerator()
			{
				//IL_00c4: Expected Obj, but got I4
				//IL_00de: Expected Obj, but got I4
				//IL_0054: Expected Obj, but got I
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected Obj, but got Unknown
				object obj = _003C_003E1__state + 2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					int currentManagedThreadId = Environment.CurrentManagedThreadId;
					if (_003C_003El__initialThreadId == currentManagedThreadId)
					{
						_003C_003E1__state = 0;
						return (IEnumerator<SimulationConnection>)(object)this;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8DE8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj4 = default;
				obj4._002Ector();
				_ = 0;
				int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
				object obj5 = obj4 + 40;
				obj5 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return (IEnumerator<SimulationConnection>)obj4;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CFusion_002ESimulationConnection_003E_002EGetEnumerator();
			}
		}

		private int _count;

		public SimulationHistoryEntry Head;

		public int Count
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				return _count;
			}
		}

		public SimulationHistoryEntry Tail
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0036: Expected Obj, but got I
				SimulationHistoryEntry head = Head;
				if (Head != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.SimulationHistoryEntry)+18]");
					return (SimulationHistoryEntry)0;
				}
				return null;
			}
		}

		public bool IsEmpty => Head == null;

		public void AddFirst(SimulationHistoryEntry item)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected Obj, but got Unknown
			//IL_0120: Expected VT, but got Obj
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_004c: Expected Obj, but got I
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			//IL_00b1: Expected Obj, but got I
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected Obj, but got Unknown
			//IL_00e1: Expected Obj, but got I
			//IL_00f1: Expected Obj, but got I
			ValidateNodeClear(item);
			object obj = this + 24;
			object obj2 = obj;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				ValidateNodeSet((SimulationHistoryEntry)0);
				object obj3 = item + 16;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = obj + 24;
				obj4 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				object obj5 = (nint)0 + (nint)16;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = item + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				SimulationHistoryEntry simulationHistoryEntry = (SimulationHistoryEntry)0;
			}
			else
			{
				object obj7 = item + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				item._node = (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)item;
				object obj6 = item + 16;
				SimulationHistoryEntry simulationHistoryEntry = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Head = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			List list = default;
			list.ValidateNodeSet(item);
			list.ValidateNodeSet(Head);
		}

		public void AddLast(SimulationHistoryEntry item)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected Obj, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_012e: Expected VT, but got Obj
			//IL_004c: Expected Obj, but got I
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			//IL_00b1: Expected Obj, but got I
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected Obj, but got Unknown
			//IL_00e1: Expected Obj, but got I
			//IL_00f1: Expected Obj, but got I
			ValidateNodeClear(item);
			object obj = this + 24;
			object obj2 = obj;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				ValidateNodeSet((SimulationHistoryEntry)0);
				object obj3 = item + 16;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = obj + 24;
				obj4 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				object obj5 = (nint)0 + (nint)16;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = item + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				SimulationHistoryEntry simulationHistoryEntry = (SimulationHistoryEntry)0;
			}
			else
			{
				object obj7 = item + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj8 = item + 16;
				item._node = (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj = item;
				object obj6 = obj;
				SimulationHistoryEntry simulationHistoryEntry = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			List list = default;
			list.ValidateNodeSet(item);
			list.ValidateNodeSet(Head);
		}

		public unsafe bool TryRemoveFirst(out SimulationHistoryEntry result)
		{
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected Obj, but got Unknown
			//IL_0015: Expected Obj, but got I
			//IL_0031: Expected Obj, but got I
			//IL_0289: Expected I4, but got Obj
			//IL_0195: Expected Obj, but got I
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected Obj, but got Unknown
			//IL_01d4: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Expected Obj, but got Unknown
			//IL_01fe: Expected Obj, but got I4
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected Obj, but got Unknown
			//IL_0220: Expected Obj, but got I4
			//IL_00e6: Expected Obj, but got I
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected Obj, but got Unknown
			//IL_0133: Expected Obj, but got I
			//IL_0143: Expected Obj, but got I
			object obj = this + 24;
			SimulationHistoryEntry simulationHistoryEntry = (SimulationHistoryEntry)obj;
			ref SimulationHistoryEntry reference;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
				SimulationHistoryEntry simulationHistoryEntry2 = (SimulationHistoryEntry)0;
				ValidateNodeSet((SimulationHistoryEntry)obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
				ValidateNodeSet((SimulationHistoryEntry)0);
				reference = ref *(SimulationHistoryEntry*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
				if (0 != (nint)obj)
				{
					if (obj != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v4+10]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
							object obj3 = (nint)0 + (nint)16;
							obj3 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (obj != null)
							{
								object obj4 = obj + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
								SimulationHistoryEntry simulationHistoryEntry3 = (SimulationHistoryEntry)0;
								goto IL_02b9;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7290]");
						object error = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.SimulationHistoryEntry)+18]");
						object obj5 = 0 - simulationHistoryEntry2._node;
						bool condition = obj5 == null;
						Assert.Check(condition, (string)error);
						obj = 0;
						SimulationHistoryEntry simulationHistoryEntry3 = null;
						object obj4 = obj;
						goto IL_02b9;
					}
				}
				goto IL_027b;
			}
			reference = ref *(SimulationHistoryEntry*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_025c;
			IL_027b:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_025c:
			bool flag = obj == null;
			return !flag;
			IL_02b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (result != null)
			{
				object obj6 = result + 24;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj7 = result + 16;
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int count = _count - 1;
				_count = count;
				List list = default;
				list.ValidateNodeClear(result);
				goto IL_025c;
			}
			goto IL_027b;
		}

		public unsafe bool TryPeekFirst(out SimulationHistoryEntry result)
		{
			ref SimulationHistoryEntry reference = ref *(SimulationHistoryEntry*)Head;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag = Head == null;
			return !flag;
		}

		public SimulationHistoryEntry RemoveFirst()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I4
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected I4, but got Unknown
			//IL_01ac: Expected Obj, but got I
			//IL_01e1: Expected Obj, but got I4
			//IL_00af: Expected Obj, but got I
			//IL_005e: Expected Obj, but got VT
			//IL_006d: Invalid comparison between VT and Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72A0]");
			object error2 = 0;
			bool flag = _count < 0;
			bool flag2 = _count == 0;
			int num = _count ^ _count;
			int num2 = _count & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool condition = (byte)((flag4 & obj) ? 1 : 0) != 0;
			Assert.Check(condition, (string)error);
			bool flag5 = Head == null;
			bool condition2 = !flag5;
			Assert.Check(condition2, (string)error2);
			bool condition3;
			if (Head != null)
			{
				SimulationHistoryEntry simulationHistoryEntry = Head;
				while (true)
				{
					bool flag6 = simulationHistoryEntry == Head;
					condition3 = flag6;
					if (flag6)
					{
						break;
					}
					if (simulationHistoryEntry != null)
					{
						simulationHistoryEntry = (SimulationHistoryEntry)simulationHistoryEntry._node;
						if (simulationHistoryEntry._node == (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)(object)Head)
						{
							condition3 = flag6;
							break;
						}
						continue;
					}
					return (SimulationHistoryEntry)(object)new NullReferenceException();
				}
			}
			else
			{
				condition3 = false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72B0]");
			object error3 = 0;
			Assert.Check(condition3, (string)error3);
			bool flag7 = TryRemoveFirst(out var result);
			bool flag8 = !flag7;
			object obj2 = !flag8;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72A8]");
				object error4 = 0;
				Assert.AlwaysFail((string)error4);
			}
			return result;
		}

		public bool Remove(SimulationHistoryEntry item)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_0110: Expected Obj, but got I
			//IL_0351: Expected I4, but got Obj
			//IL_014f: Expected Obj, but got I
			//IL_0188: Expected Obj, but got I
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected Obj, but got Unknown
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected Obj, but got Unknown
			//IL_01ce: Expected Obj, but got I
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected Obj, but got Unknown
			//IL_0205: Expected Obj, but got I4
			//IL_020e: Expected Obj, but got I4
			//IL_00bd: Expected Obj, but got I
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Expected Obj, but got Unknown
			//IL_02a8: Expected Obj, but got I
			//IL_02cc: Expected Obj, but got I4
			//IL_02f9: Expected Obj, but got I4
			//IL_030c: Expected Obj, but got I4
			//IL_02eb: Expected Obj, but got I4
			if (item != null)
			{
				object obj = this + 24;
				if (obj != null)
				{
					object obj2 = item + 24;
					if (obj2 != null)
					{
						object obj3 = obj2 - 8;
						if (obj3 != null)
						{
							object obj4 = obj;
							while (true)
							{
								if (obj4 != item)
								{
									if (obj4 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v3+10]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v3+10]");
									if (0 != (nint)obj)
									{
										continue;
									}
								}
								object obj5 = obj4 - (object)item;
								bool condition = obj5 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72C0]");
								object error = 0;
								Assert.Check(condition, (string)error);
								object obj10;
								if (_count == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72D0]");
									object error2 = 0;
									object obj6 = obj - (object)item;
									bool condition2 = obj6 == null;
									Assert.Check(condition2, (string)error2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72B8]");
									object error3 = 0;
									object obj7 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.SimulationHistoryEntry)+18]");
									object obj8 = obj7 - 0;
									bool condition3 = obj8 == null;
									Assert.Check(condition3, (string)error3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72C8]");
									object error4 = 0;
									object obj9 = obj - item._node;
									bool condition4 = obj9 == null;
									Assert.Check(condition4, (string)error4);
									obj10 = 0;
									object obj11 = 0;
								}
								else
								{
									if (obj2 == null)
									{
										break;
									}
									object obj12 = obj2 + 16;
									obj12 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (obj3 == null)
									{
										break;
									}
									object obj13 = obj3 + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.SimulationHistoryEntry)+18]");
									obj13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag = obj != item;
									object obj11 = 0;
									if (flag)
									{
										goto IL_02f0;
									}
									obj10 = obj3;
									obj11 = 0;
								}
								obj = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								goto IL_02f0;
								IL_02f0:
								obj2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int count = _count - 1;
								_count = count;
								return true;
							}
							NullReferenceException ex = new NullReferenceException();
							return (byte)(int)ex != 0;
						}
					}
					ValidateNodeClear(item);
				}
			}
			return false;
		}

		public bool IsInListSlow(SimulationHistoryEntry item)
		{
			//IL_00c4: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got VT
			//IL_0084: Invalid comparison between VT and Obj
			bool result;
			if (item != null && Head != null)
			{
				SimulationHistoryEntry simulationHistoryEntry = Head;
				while (true)
				{
					bool flag = simulationHistoryEntry == item;
					result = flag;
					if (flag)
					{
						break;
					}
					if (simulationHistoryEntry != null)
					{
						simulationHistoryEntry = (SimulationHistoryEntry)simulationHistoryEntry._node;
						if (simulationHistoryEntry._node == (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)(object)Head)
						{
							result = flag;
							break;
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		[MethodImpl((MethodImplOptions)256)]
		public SimulationHistoryEntry Next(SimulationHistoryEntry item)
		{
			//IL_002c: Invalid comparison between VT and Obj
			//IL_005a: Expected Obj, but got VT
			if (item != null)
			{
				if (item._node == (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)(object)Head)
				{
					return null;
				}
				return (SimulationHistoryEntry)item._node;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex = default;
			string paramName = default;
			ex._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			return (SimulationHistoryEntry)(object)new ArgumentNullException();
		}

		[MethodImpl((MethodImplOptions)256)]
		public SimulationHistoryEntry Prev(SimulationHistoryEntry item)
		{
			//IL_0048: Expected Obj, but got I
			if (item != null)
			{
				if (Head != item)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.SimulationHistoryEntry)+18]");
					return (SimulationHistoryEntry)0;
				}
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex = default;
			string paramName = default;
			ex._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			return (SimulationHistoryEntry)(object)new ArgumentNullException();
		}

		public SimulationHistoryEntry[] ToArray()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0236: Expected Obj, but got I
			//IL_024e: Expected Obj, but got I
			//IL_0270: Expected Obj, but got I4
			//IL_0368: Expected Obj, but got I
			//IL_038a: Expected Obj, but got I4
			//IL_0025: Expected Obj, but got I
			//IL_008f: Expected Obj, but got I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected I4, but got Unknown
			//IL_00c2: Expected Obj, but got I4
			//IL_03a8: Expected Obj, but got I
			//IL_0298: Expected Obj, but got I
			//IL_02b7: Expected Obj, but got I
			//IL_02c7: Expected Obj, but got I
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			//IL_0105: Expected Obj, but got I4
			//IL_0174: Expected Obj, but got I4
			//IL_0112: Expected I, but got Obj
			//IL_0122: Expected Obj, but got I
			//IL_014b: Expected Obj, but got I
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected Obj, but got Unknown
			//IL_01ed: Invalid comparison between VT and Obj
			//IL_020b: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA688]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			SimulationHistoryEntry simulationHistoryEntry;
			IndexOutOfRangeException ex = default;
			SimulationHistoryEntry simulationHistoryEntry3;
			if (Head != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
				object error = 0;
				bool flag = _count < 0;
				bool flag2 = _count == 0;
				int num = _count ^ _count;
				int num2 = _count & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj2 = !flag2;
				bool flag5 = (byte)((flag4 & obj2) ? 1 : 0) != 0;
				Assert.Check(flag5, (string)error);
				simulationHistoryEntry = Head;
				((List)flag5).ValidateNodeSet(Head);
				SimulationHistoryEntry[] array = default;
				if (array == null)
				{
					goto IL_02cc;
				}
				SimulationHistoryEntry simulationHistoryEntry2 = Head;
				object obj3 = array + 32;
				object obj4 = 0;
				while (true)
				{
					if (simulationHistoryEntry2 != null)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24 (Il2CppClass<Fusion.SimulationHistoryEntry[]>)+40]");
						simulationHistoryEntry = (SimulationHistoryEntry)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24 (Il2CppClass<Fusion.SimulationHistoryEntry[]>)+40]");
						simulationHistoryEntry3 = (SimulationHistoryEntry)0;
						if (flag6)
						{
							break;
						}
					}
					bool flag7 = (nint)obj4 < array.Length;
					object obj5 = !flag7;
					if (obj5 == null)
					{
						object obj6 = (object)array + obj4;
						object obj7 = obj3 + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag8 = simulationHistoryEntry2 == null;
						simulationHistoryEntry = simulationHistoryEntry2;
						if (!flag8)
						{
							obj4++;
							bool flag9 = simulationHistoryEntry2._node != (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)(object)Head;
							simulationHistoryEntry = simulationHistoryEntry2;
							simulationHistoryEntry2 = (SimulationHistoryEntry)simulationHistoryEntry2._node;
							if (!flag9)
							{
								return array;
							}
							continue;
						}
						goto IL_02cc;
					}
					goto IL_02da;
				}
				goto IL_02f0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA690]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v4+38]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v4+38]");
			bool flag10 = (nint)0 == 0;
			object obj11 = !flag10;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v4+38]");
				obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+10]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+E4]");
			bool flag11 = (nint)0 == 0;
			object obj13 = !flag11;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v4+38]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v12+10]");
				obj12 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+A0]");
			return (SimulationHistoryEntry[])0;
			IL_02da:
			ex = new IndexOutOfRangeException();
			simulationHistoryEntry3 = simulationHistoryEntry;
			goto IL_02f0;
			IL_02cc:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_02da;
			IL_02f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			return (SimulationHistoryEntry[])(object)new ArgumentNullException();
		}

		private void Fusion_002EIIntrusiveLinkedList_002ECopyTo(Array array, int index)
		{
			//IL_001a: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected I4, but got Unknown
			//IL_0102: Expected Obj, but got I4
			//IL_012e: Expected Obj, but got I
			bool flag = array == null;
			object obj = array;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ X1 (System.Array)+18]");
				int num = default;
				object obj2 = -num;
				bool flag2 = (nint)obj2 < _count;
				obj = array;
				if (flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					ArgumentException ex = default;
					ex._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					throw new ArgumentNullException();
				}
				if (Head == null)
				{
					return;
				}
				bool flag3 = _count < 0;
				bool flag4 = _count == 0;
				int num2 = _count ^ _count;
				int num3 = _count & num2;
				bool flag5 = num3 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
				object error = 0;
				bool flag6 = flag3 == flag5;
				object obj3 = !flag4;
				bool flag7 = (byte)((flag6 & obj3) ? 1 : 0) != 0;
				Assert.Check(flag7, (string)error);
				((List)flag7).ValidateNodeSet(Head);
				int num4 = num;
				object obj4 = Head;
				while (true)
				{
					array.SetValue(obj4, num4);
					bool flag8 = obj4 == null;
					obj = obj4;
					if (flag8)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v7 (System.Object)+10]");
					obj4 = 0;
					num4++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v7 (System.Object)+10]");
					if (0 == (nint)Head)
					{
						return;
					}
				}
			}
			throw new NullReferenceException();
		}

		private void ValidateNodeSet(SimulationHistoryEntry item)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0043: Invalid comparison between VT and I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7268]");
			object error = 0;
			bool flag = item == null;
			bool condition = !flag;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7280]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7288]");
			object error3 = 0;
			bool flag2 = item._node == (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)(object)0;
			bool condition2 = !flag2;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.SimulationHistoryEntry)+18]");
			bool flag3 = (nint)0 == 0;
			bool condition3 = !flag3;
			Assert.Check(condition3, (string)error3);
		}

		private void ValidateNodeClear(SimulationHistoryEntry item)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0043: Invalid comparison between VT and I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7268]");
			object error = 0;
			bool flag = item == null;
			bool condition = !flag;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7270]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7278]");
			object error3 = 0;
			bool condition2 = item._node == (Fusion.IntrusiveLinkedListNode<SimulationHistoryEntry>)(object)0;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.SimulationHistoryEntry)+18]");
			bool condition3 = (nint)0 == 0;
			Assert.Check(condition3, (string)error3);
		}
	}

	public enum InputTransferModes
	{
		// error: enumerator has no value
		Redundancy,
		// error: enumerator has no value
		RedundancyUncompressed,
		// error: enumerator has no value
		LatestState
	}

	public enum DataConsistency
	{
		// error: enumerator has no value
		Full,
		// error: enumerator has no value
		Eventual
	}

	public int InputDataWordCount;

	public NetworkProjectConfig.ReplicationFeatures ReplicationFeatures;

	public InterestManagementConfig InterestManagementConfig;

	public InputTransferModes InputTransferMode;

	[NonSerialized]
	public DataConsistency ObjectDataConsistency;

	public NetworkConfiguration.SimulationTimeMode SimulationUpdateTimeMode;

	public int PlayerCount;

	public TickRate.Selection TickRateSelection;

	[NonSerialized]
	public Topologies Topology;

	[NonSerialized]
	public bool HostMigration;

	internal bool EnableSerializers;

	public bool AreaOfInterestEnabled
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I4, but got Unknown
			object obj = (int)ReplicationFeatures >> 1;
			return (byte)(obj & 1) != 0;
		}
	}

	public int InputTotalWordCount => InputDataWordCount + 4;

	internal SimulationConfig Init(int? playerCountOverride, int? inputWordCount)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		SimulationConfig simulationConfig = Copy();
		object obj = (_003F?)playerCountOverride & 0xFF;
		if (obj != null)
		{
			int? num = default;
			int value = num.Value;
			if (simulationConfig == null)
			{
				goto IL_007d;
			}
			simulationConfig.PlayerCount = value;
		}
		object obj2 = (_003F?)inputWordCount & 0xFF;
		if (obj2 != null)
		{
			int? num2 = default;
			int value2 = num2.Value;
			if (simulationConfig == null)
			{
				goto IL_007d;
			}
			simulationConfig.InputDataWordCount = value2;
		}
		return simulationConfig;
		IL_007d:
		return (SimulationConfig)(object)new NullReferenceException();
	}

	internal SimulationConfig Copy()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		SimulationConfig simulationConfig = (SimulationConfig)MemberwiseClone();
		if (simulationConfig != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9960]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)simulationConfig;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6 (Il2CppClass<Fusion.SimulationConfig>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6 (Il2CppClass<Fusion.SimulationConfig>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X1_v3+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9-8]");
				if (0 == (nint)obj2)
				{
					goto IL_00a9;
				}
			}
			return (SimulationConfig)(object)new InvalidCastException();
		}
		goto IL_00a9;
		IL_00a9:
		return simulationConfig;
	}

	public void SanityCheck()
	{
	}

	public SimulationConfig()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA6B0]");
		object obj = 0;
		ReplicationFeatures = (NetworkProjectConfig.ReplicationFeatures)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D360]");
		_ = 0;
		object obj2 = default;
		obj2._002Ector();
		object obj3 = this + 24;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B508]");
		SimulationUpdateTimeMode = (NetworkConfiguration.SimulationTimeMode)0;
		TickRateSelection = TickRate.Zero;
		EnableSerializers = true;
		base._002Ector();
	}
}
