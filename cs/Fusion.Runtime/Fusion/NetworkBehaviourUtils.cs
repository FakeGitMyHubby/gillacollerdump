using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Photon.Realtime;

namespace Fusion;

public static class NetworkBehaviourUtils
{
	public class ChangeDetector
	{
		private sealed class _003Cget_CommittedPlayerInternal_003Ed__120 : Action<IAsyncOperation>, _0021_00210, Action<IAsyncResult>, _0021_00210, Action<IAsyncResult>
		{
			private int _003C_003E1__state;

			private PlayerRef _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public CloudServices _003C_003E4__this;

			private Room _003Croom_003E5__1;

			private IEnumerator<PlayerRef> _003C_003Es__2;

			private PlayerRef _003CplayerRef_003E5__3;

			private PlayerRef System_002ECollections_002EGeneric_002EIEnumerator_003CFusion_002EPlayerRef_003E_002ECurrent => _003C_003E2__current;

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				get
				{
					//IL_0010: Expected Obj, but got I
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object result = default;
					return result;
				}
			}

			public _003Cget_CommittedPlayerInternal_003Ed__120(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				_003C_003El__initialThreadId = currentManagedThreadId;
			}

			private void System_002EIDisposable_002EDispose()
			{
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected Obj, but got Unknown
				//IL_0076: Expected Obj, but got I4
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Expected Obj, but got Unknown
				//IL_0094: Expected Obj, but got I4
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
				object obj3 = this + 40;
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = this + 48;
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_ = 4294967294L;
			}

			private bool MoveNext()
			{
				//IL_073c: Expected Obj, but got I4
				//IL_09a9: Expected Obj, but got I
				//IL_09b9: Expected Obj, but got I
				//IL_09cb: Expected I4, but got I8
				//IL_0021: Expected Obj, but got I4
				//IL_0317: Expected I, but got Obj
				//IL_0327: Expected Obj, but got I
				//IL_0047: Expected I4, but got I8
				//IL_03f2: Expected VT, but got I4
				//IL_089c: Unknown result type (might be due to invalid IL or missing references)
				//IL_08a1: Expected Obj, but got Unknown
				//IL_0362: Expected Obj, but got I
				//IL_0607: Unknown result type (might be due to invalid IL or missing references)
				//IL_060c: Expected Obj, but got Unknown
				//IL_0615: Expected Obj, but got I4
				//IL_084b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0850: Expected Obj, but got Unknown
				//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0404: Expected Obj, but got Unknown
				//IL_040d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0412: Expected Obj, but got Unknown
				//IL_00b8: Expected I, but got Obj
				//IL_0378: Unknown result type (might be due to invalid IL or missing references)
				//IL_037d: Expected Obj, but got Unknown
				//IL_0388: Unknown result type (might be due to invalid IL or missing references)
				//IL_038d: Expected Obj, but got Unknown
				//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_03af: Expected Obj, but got Unknown
				//IL_045e: Expected I, but got Obj
				//IL_046e: Expected Obj, but got I
				//IL_0539: Expected VT, but got I4
				//IL_013b: Expected I, but got Obj
				//IL_04a9: Expected Obj, but got I
				//IL_0773: Unknown result type (might be due to invalid IL or missing references)
				//IL_0778: Expected Obj, but got Unknown
				//IL_0780: Expected Obj, but got I
				//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_08d5: Expected Obj, but got Unknown
				//IL_05b1: Expected I, but got Obj
				//IL_0546: Unknown result type (might be due to invalid IL or missing references)
				//IL_054b: Expected Obj, but got Unknown
				//IL_0554: Unknown result type (might be due to invalid IL or missing references)
				//IL_0559: Expected Obj, but got Unknown
				//IL_0131: Expected I, but got Obj
				//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c4: Expected Obj, but got Unknown
				//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d4: Expected Obj, but got Unknown
				//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f6: Expected Obj, but got Unknown
				//IL_01d9: Expected I, but got Obj
				//IL_01ef: Expected I, but got Obj
				//IL_01ff: Expected Obj, but got I
				//IL_020f: Expected Obj, but got I
				//IL_02da: Expected VT, but got I4
				//IL_080c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0811: Expected Obj, but got Unknown
				//IL_0819: Expected Obj, but got I
				//IL_024a: Expected Obj, but got I
				//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_07d0: Expected Obj, but got Unknown
				//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ec: Expected Obj, but got Unknown
				//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fa: Expected Obj, but got Unknown
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_0265: Expected Obj, but got Unknown
				//IL_0270: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Expected Obj, but got Unknown
				//IL_0292: Unknown result type (might be due to invalid IL or missing references)
				//IL_0297: Expected Obj, but got Unknown
				object obj = _003C_003E1__state - 1;
				bool flag = _003C_003E1__state == 1;
				_003Cget_CommittedPlayerInternal_003Ed__120 obj2 = this;
				bool result;
				_003Cget_CommittedPlayerInternal_003Ed__120 obj4 = default;
				nint num = default;
				if (!flag)
				{
					bool flag2 = _003C_003E1__state == 0;
					object obj3 = !flag2;
					result = false;
					if (obj3 != null)
					{
						goto IL_0765;
					}
					_003C_003E1__state = -1;
					if ((object)_003C_003E4__this == null)
					{
						goto IL_065c;
					}
					if (!_003C_003E4__this.IsInRoom)
					{
						goto IL_0624;
					}
					CloudServices cloudServices = obj4._003C_003E4__this;
					bool flag3 = (object)obj4._003C_003E4__this == null;
					num = unchecked((nint)null);
					if (flag3)
					{
						goto IL_066a;
					}
					CloudCommunicator communicator = cloudServices._communicator;
					if ((object)cloudServices._communicator != null)
					{
						RealtimeClient realtimeClient = communicator.Client__BackingField;
						if (communicator.Client__BackingField != null)
						{
							num = (nint)realtimeClient.CurrentRoom__BackingField;
							goto IL_076a;
						}
					}
					num = unchecked((nint)null);
					goto IL_076a;
				}
				goto IL_0999;
				IL_0765:
				return result;
				IL_0694:
				NullReferenceException ex = new NullReferenceException();
				bool flag4 = num != 1;
				NullReferenceException ex2 = ex;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					object obj5 = default;
					if (obj5 == null)
					{
						goto IL_0624;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A4E34");
					OutOfMemoryException ex3 = new OutOfMemoryException();
					ex2 = (NullReferenceException)(object)ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3854");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result2 = default;
				return result2;
				IL_065c:
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_066a;
				IL_0624:
				result = false;
				goto IL_0765;
				IL_05c7:
				obj4._003C_003E1__state = 1;
				obj4._003C_003E2__current = obj4._003CplayerRef_003E5__3;
				result = true;
				goto IL_0765;
				IL_02c7:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				PlayerRef playerRef = (PlayerRef)0;
				goto IL_07f9;
				IL_0678:
				NullReferenceException ex5 = new NullReferenceException();
				goto IL_0686;
				IL_07f9:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v650 @ X0_v62] (should have been resolved before IL gen)");
				object obj6 = obj4 + 48;
				IntPtr intPtr = default;
				obj6 = (nint)intPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				num = intPtr;
				obj2 = obj4;
				goto IL_0999;
				IL_076a:
				object obj7 = obj4 + 40;
				obj7 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Room room = obj4._003Croom_003E5__1;
				if (obj4._003Croom_003E5__1 == null || room.players == null)
				{
					goto IL_0624;
				}
				CloudServices cloudServices2 = obj4._003C_003E4__this;
				if ((object)obj4._003C_003E4__this == null)
				{
					goto IL_0678;
				}
				if ((object)cloudServices2._runner == null)
				{
					goto IL_0686;
				}
				IEnumerable<PlayerRef> activePlayers = cloudServices2._runner.ActivePlayers;
				bool flag5 = activePlayers == null;
				num = unchecked((nint)null);
				if (flag5)
				{
					goto IL_0694;
				}
				nint num2 = (nint)activePlayers;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDF0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02c7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Fusion.PlayerRef>>)+98]");
				object obj10 = (nint)0 + (nint)8;
				bool flag7 = default;
				bool flag6 = flag7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v30-8]");
					obj = 0 - obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v30-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj9--;
					obj = obj9 - 1;
					flag = obj == null;
					obj8 = obj10 + 16;
					flag7 = (nint)obj9 != 1;
					flag6 = flag7;
					obj10 = obj8;
					if (flag7)
					{
						continue;
					}
					goto IL_02c7;
				}
				object obj11 = num2 + obj10;
				object obj12 = obj11 + 312;
				flag7 = flag6;
				obj8 = obj10;
				goto IL_07f9;
				IL_0999:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCDF8]");
				object obj14 = 0;
				obj2._003C_003E1__state = -3;
				PlayerRef playerRef2 = default;
				object obj20 = default;
				while (true)
				{
					IEnumerator<PlayerRef> enumerator = obj2._003C_003Es__2;
					if ((object)obj2._003C_003Es__2 != null)
					{
						nint num3 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+12E]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03df;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+98]");
						object obj16 = (nint)0 + (nint)8;
						bool flag8 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X10_v15-8]");
							obj = 0 - obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X10_v15-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							obj15--;
							obj = obj15 - 1;
							flag = obj == null;
							obj8 = obj16 + 16;
							flag7 = (nint)obj15 != 1;
							flag8 = flag7;
							obj16 = obj8;
							if (flag7)
							{
								continue;
							}
							goto IL_03df;
						}
						object obj17 = num3 + obj16;
						object obj18 = obj17 + 312;
						flag7 = flag8;
						obj8 = obj16;
						goto IL_0879;
					}
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_0640;
					IL_0526:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					playerRef = (PlayerRef)0;
					goto IL_08fe;
					IL_064e:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_065c;
					IL_08fe:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v16+8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v16] (should have been resolved before IL gen)");
					obj4._003CplayerRef_003E5__3 = playerRef2;
					if ((object)obj4._003C_003E4__this != null)
					{
						bool flag9 = obj4._003C_003E4__this.IsPlayerCommitted(obj4._003Croom_003E5__1, playerRef2);
						bool flag10 = !flag9;
						playerRef = playerRef2;
						num = (nint)obj4._003Croom_003E5__1;
						obj2 = obj4;
						if (flag10)
						{
							continue;
						}
						goto IL_05c7;
					}
					goto IL_064e;
					IL_0640:
					NullReferenceException ex8 = new NullReferenceException();
					goto IL_064e;
					IL_03df:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					playerRef = (PlayerRef)0;
					goto IL_0879;
					IL_0879:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v9+8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ X0_v9] (should have been resolved before IL gen)");
					object obj19 = obj20 & 1;
					if (obj19 == null)
					{
						break;
					}
					IEnumerator<PlayerRef> enumerator2 = obj4._003C_003Es__2;
					if ((object)obj4._003C_003Es__2 == null)
					{
						goto IL_0640;
					}
					nint num4 = (nint)enumerator2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+12E]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0526;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+98]");
					object obj22 = (nint)0 + (nint)8;
					bool flag11 = flag7;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X10_v10-8]");
						obj = 0 - obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X10_v10-8]");
						if (0 == (nint)obj14)
						{
							break;
						}
						obj21--;
						obj = obj21 - 1;
						flag = obj == null;
						obj8 = obj22 + 16;
						flag7 = (nint)obj21 != 1;
						flag11 = flag7;
						obj22 = obj8;
						if (flag7)
						{
							continue;
						}
						goto IL_0526;
					}
					object obj23 = num4 + obj22;
					object obj24 = obj23 + 312;
					flag7 = flag11;
					obj8 = obj22;
					goto IL_08fe;
				}
				obj4._003C_003Em__Finally1();
				object obj25 = obj4 + 48;
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				goto IL_0624;
				IL_0686:
				NullReferenceException ex9 = new NullReferenceException();
				goto IL_0694;
				IL_066a:
				NullReferenceException ex10 = new NullReferenceException();
				goto IL_0678;
			}

			private void _003C_003Em__Finally1()
			{
				//IL_00f2: Expected I4, but got I8
				//IL_000d: Expected I, but got Obj
				//IL_001d: Expected Obj, but got I
				//IL_002d: Expected Obj, but got I
				//IL_0068: Expected Obj, but got I
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Expected Obj, but got Unknown
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d4: Expected Obj, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected Obj, but got Unknown
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Expected Obj, but got Unknown
				IEnumerator<PlayerRef> enumerator = _003C_003Es__2;
				_003C_003E1__state = -1;
				if ((object)_003C_003Es__2 == null)
				{
					return;
				}
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerator`1<Fusion.PlayerRef>>)+98]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj2--;
					obj3 += 16;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00a9;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				goto IL_0135;
				IL_0135:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v152 @ X0_v2] (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
				IL_00a9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				goto IL_0135;
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

			private IEnumerator<PlayerRef> System_002ECollections_002EGeneric_002EIEnumerable_003CFusion_002EPlayerRef_003E_002EGetEnumerator()
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
						return (IEnumerator<PlayerRef>)(object)this;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D53E8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj4 = default;
				obj4._002Ector();
				_ = 0;
				int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
				object obj5 = obj4 + 32;
				obj5 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return (IEnumerator<PlayerRef>)obj4;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CFusion_002EPlayerRef_003E_002EGetEnumerator();
			}
		}

		public enum Source
		{
			// error: enumerator has no value
			SimulationState,
			// error: enumerator has no value
			SnapshotFrom,
			// error: enumerator has no value
			SnapshotTo,
			// error: enumerator has no value
			SnapshotNearest
		}

		private struct PropertyData
		{
			public MemberInfo PropertyInfo;

			public NetworkedWeavedAttribute WeavedAttribute;

			public OnChangedCallbackWrapper OnChanged;

			public OnChangedPrevCallbackWrapper OnChangedPrev;
		}

		internal delegate void OnChangedPrevCallback<T>(T b, NetworkBehaviourBuffer prev) where T : NetworkBehaviour;

		internal delegate void OnChangedPrevCallbackWrapper(NetworkBehaviour b, NetworkBehaviourBuffer prev);

		internal delegate void OnChangedCallback<T>(T b) where T : NetworkBehaviour;

		internal delegate void OnChangedCallbackWrapper(NetworkBehaviour b);

		public struct Enumerable
		{
			private string[] _changed;

			private int _count;

			internal Enumerable(string[] changed, int count)
			{
				_changed = changed;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_count = count;
			}

			public Enumerator GetEnumerator()
			{
				//IL_0011: Expected VT, but got Obj
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return (Enumerator)_changed;
			}

			public bool Changed(string name)
			{
				if (_count >= 1)
				{
					int num = Array.IndexOf((System.__Canon[])(object)_changed, (System.__Canon)(object)name, 0);
					int num2 = ~num;
					return (byte)(num2 >> 31) != 0;
				}
				return false;
			}
		}

		public struct Enumerator
		{
			private string[] _changed;

			private int _count;

			private int _current;

			public string Current
			{
				get
				{
					//IL_0046: Expected Obj, but got I4
					//IL_0060: Unknown result type (might be due to invalid IL or missing references)
					//IL_0065: Expected Obj, but got Unknown
					//IL_0072: Expected Obj, but got I
					string[] changed = _changed;
					if (_changed != null)
					{
						bool flag = _current < changed.Length;
						object obj = !flag;
						if (obj == null)
						{
							object obj2 = _changed + _current;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X8_v2+20]");
							return (string)0;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
					return (string)(object)new IndexOutOfRangeException();
				}
			}

			internal Enumerator(string[] changed, int count)
			{
				//IL_002d: Expected I4, but got I8
				_changed = changed;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_count = count;
				_current = -1;
			}

			public void Reset()
			{
				//IL_000f: Expected I4, but got I8
				_current = -1;
			}

			public bool MoveNext()
			{
				//IL_001f: Expected Obj, but got I4
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected I4, but got Unknown
				int num = _current + 1;
				object obj = num - _count;
				bool flag = (nint)obj < 0;
				int num2 = num ^ _count;
				int num3 = num ^ obj;
				int num4 = num2 & num3;
				bool flag2 = num4 < 0;
				_current = num;
				bool flag3 = flag == flag2;
				return !flag3;
			}
		}

		private sealed class _003C_003Ec__DisplayClass10_0<T> where T : NetworkBehaviour
		{
			public OnChangedCallback<T> callback;

			internal void _003CGetWrapper_003Eb__0(NetworkBehaviour behaviour)
			{
				//IL_0025: Expected Obj, but got I
				//IL_0035: Expected Obj, but got I
				//IL_004b: Expected Obj, but got I
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0073: Expected Obj, but got I4
				//IL_00de: Expected Obj, but got I4
				//IL_0110: Expected Obj, but got I
				//IL_0120: Expected Obj, but got I
				//IL_0130: Expected Obj, but got I
				//IL_00bc: Expected Obj, but got I4
				OnChangedCallback<T> onChangedCallback = callback;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X8_v1 (Il2CppClass<Fusion.NetworkBehaviourUtils+ChangeDetector+<>c__DisplayClass10_0`1>)+A8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2+10]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2+10]");
				object obj3 = (nint)0 + (nint)309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj6 = default;
					obj2 = obj6;
				}
				if ((object)behaviour != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					object obj7 = default;
					bool flag2 = obj7 == null;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj9 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X21_v1 (Fusion.NetworkBehaviourUtils+ChangeDetector+OnChangedCallback`1<T>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X21_v1 (Fusion.NetworkBehaviourUtils+ChangeDetector+OnChangedCallback`1<T>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X21_v1 (Fusion.NetworkBehaviourUtils+ChangeDetector+OnChangedCallback`1<T>)+18]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v1 (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
			}
		}

		private static Dictionary<Type, PropertyData[]> _propertyMappings;

		private static Dictionary<Type, bool> _hasChangeCallbacks;

		private int? _instance;

		private int[] _words;

		private unsafe int* _wordsPrevious;

		private Source _source;

		private Tick _sourceTick;

		private string[] _changed;

		private PropertyData[] _changedProperty;

		internal bool InvokeCallbacks;

		internal static bool HasChangeCallbacks(Type type)
		{
			//IL_01ed: Expected I4, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_0055: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I4
			//IL_021f: Expected Obj, but got I
			//IL_00b4: Expected Obj, but got I
			//IL_00df: Expected Obj, but got I4
			//IL_0170: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got I
			//IL_0117: Expected Obj, but got I4
			//IL_01af: Expected Obj, but got I
			//IL_01cd: Expected Obj, but got I4
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected I4, but got Unknown
			if ((object)type != null)
			{
				nint num = (nint)type;
				if (type.IsCOMObject)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v8+A0]");
				object obj4 = 0;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5870]");
					object obj5 = 0;
					bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)obj4).ContainsKey((System.__Canon)(object)type);
					bool flag3 = !flag2;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						object obj7 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v19+E4]");
						bool flag4 = (nint)0 == 0;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PropertyData[] propertyMappping = GetPropertyMappping(type);
					}
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v13+E4]");
					bool flag5 = (nint)0 == 0;
					object obj10 = !flag5;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v13+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v12+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v12+8]");
						bool flag6 = ((Dictionary<System.__Canon, bool>)0).TryGetValue((System.__Canon)(object)type, out var value);
						bool flag7 = !value;
						object obj12 = !flag7;
						return (byte)((flag6 & obj12) ? 1 : 0) != 0;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		private unsafe static OnChangedPrevCallbackWrapper GetWrapperPrev<T>(MethodInfo methodInfo) where T : NetworkBehaviour
		{
			//IL_01c1: Expected Obj, but got I
			//IL_01d1: Expected Obj, but got I
			//IL_01f3: Expected Obj, but got I4
			//IL_002f: Expected VT, but got I
			//IL_0073: Expected Obj, but got I
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_011c: Expected Obj, but got I4
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected Obj, but got Unknown
			//IL_0245: Expected Obj, but got I
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected Obj, but got Unknown
			//IL_026d: Expected Obj, but got I4
			//IL_00ea: Expected Obj, but got I4
			//IL_0186: Expected Obj, but got I4
			//IL_029b: Expected Obj, but got I
			//IL_015c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj = default;
			((NetworkBehaviour._003C_003Ec__DisplayClass9_0<T>)obj)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5+E8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Delegate obj5 = Delegate.CreateDelegate(typeFromHandle, null, methodInfo);
			if (obj != null)
			{
				object obj6 = (nint)0 + (nint)309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				object obj9 = 0;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj10 = default;
					obj9 = obj10;
				}
				bool flag3 = (object)obj5 == null;
				object obj11 = null;
				object obj12 = default;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = obj12 == null;
					object obj13 = !flag4;
					obj11 = obj9;
					if (obj13 == null)
					{
						obj11 = obj9;
						throw new InvalidCastException();
					}
				}
				else
				{
					obj12 = 0;
				}
				object obj14 = obj + 16;
				obj14 = obj12;
				object obj15 = (nint)0 + (nint)309;
				object obj16 = obj15 & 1;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				nint num = 0;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				if ((object)obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					object obj18 = default;
					bool flag6 = obj18 == null;
					object obj19 = !flag6;
					object obj20 = obj18;
					if (obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj20 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AB8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				OnChangedPrevCallbackWrapper onChangedPrevCallbackWrapper = default;
				onChangedPrevCallbackWrapper._002Ector(obj, (nint)__ldftn(NetworkBehaviour._003C_003Ec__DisplayClass9_0<T>._003CGetWrapperPrev_003Eb__0));
				return onChangedPrevCallbackWrapper;
			}
			return (OnChangedPrevCallbackWrapper)(object)new NullReferenceException();
		}

		private unsafe static OnChangedCallbackWrapper GetWrapper<T>(MethodInfo methodInfo) where T : NetworkBehaviour
		{
			//IL_01c1: Expected Obj, but got I
			//IL_01d1: Expected Obj, but got I
			//IL_01f3: Expected Obj, but got I4
			//IL_002f: Expected VT, but got I
			//IL_0073: Expected Obj, but got I
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_011c: Expected Obj, but got I4
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected Obj, but got Unknown
			//IL_0245: Expected Obj, but got I
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected Obj, but got Unknown
			//IL_026d: Expected Obj, but got I4
			//IL_00ea: Expected Obj, but got I4
			//IL_0186: Expected Obj, but got I4
			//IL_029b: Expected Obj, but got I
			//IL_015c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj = default;
			((_003C_003Ec__DisplayClass10_0<T>)obj)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5+E8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Delegate obj5 = Delegate.CreateDelegate(typeFromHandle, null, methodInfo);
			if (obj != null)
			{
				object obj6 = (nint)0 + (nint)309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				object obj9 = 0;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					object obj10 = default;
					obj9 = obj10;
				}
				bool flag3 = (object)obj5 == null;
				object obj11 = null;
				object obj12 = default;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = obj12 == null;
					object obj13 = !flag4;
					obj11 = obj9;
					if (obj13 == null)
					{
						obj11 = obj9;
						throw new InvalidCastException();
					}
				}
				else
				{
					obj12 = 0;
				}
				object obj14 = obj + 16;
				obj14 = obj12;
				object obj15 = (nint)0 + (nint)309;
				object obj16 = obj15 & 1;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				nint num = 0;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					IntPtr intPtr = default;
					num = intPtr;
				}
				if ((object)obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					object obj18 = default;
					bool flag6 = obj18 == null;
					object obj19 = !flag6;
					object obj20 = obj18;
					if (obj19 == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj20 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AB0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				OnChangedCallbackWrapper onChangedCallbackWrapper = default;
				onChangedCallbackWrapper._002Ector(obj, (nint)__ldftn(_003C_003Ec__DisplayClass10_0<T>._003CGetWrapper_003Eb__0));
				return onChangedCallbackWrapper;
			}
			return (OnChangedCallbackWrapper)(object)new NullReferenceException();
		}

		private unsafe static PropertyData[] GetPropertyMappping(Type type)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0562: Expected Obj, but got I4
			//IL_0687: Expected Obj, but got I
			//IL_06a1: Expected Obj, but got I4
			//IL_0592: Expected Obj, but got I4
			//IL_06bf: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I
			//IL_008e: Expected Obj, but got I4
			//IL_00da: Expected Obj, but got I
			//IL_0109: Expected Obj, but got I4
			//IL_05b0: Expected Obj, but got I
			//IL_0127: Expected Obj, but got I
			//IL_0141: Expected Obj, but got I
			//IL_0179: Expected Obj, but got I4
			//IL_01d1: Expected I, but got Obj
			//IL_01e1: Expected Obj, but got I
			//IL_01ec: Expected Obj, but got I
			//IL_0200: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I
			//IL_0220: Expected Obj, but got Ref
			//IL_05f5: Expected Obj, but got I
			//IL_0617: Expected Obj, but got I4
			//IL_0247: Expected Obj, but got I4
			//IL_04bc: Expected Obj, but got I4
			//IL_0286: Expected Obj, but got I
			//IL_02a8: Expected Obj, but got I4
			//IL_0425: Expected Obj, but got I4
			//IL_02ce: Expected VT, but got Obj
			//IL_02df: Expected Obj, but got I4
			//IL_0635: Expected Obj, but got I
			//IL_04f1: Expected Obj, but got I
			//IL_045a: Expected Obj, but got I
			//IL_047c: Expected Obj, but got I
			//IL_0340: Expected Obj, but got I4
			//IL_0373: Expected Obj, but got I4
			//IL_03b5: Expected Obj, but got I
			//IL_03c0: Expected Obj, but got I
			//IL_03c0: Expected Obj, but got I4
			//IL_03cc: Expected Obj, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v5+A0]");
			object obj4 = 0;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A70]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A60]");
				object obj7 = 0;
				Dictionary<System.__Canon, System.__Canon> dictionary = default;
				dictionary._002Ector();
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v59+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v59+A0]");
				object obj10 = 0;
				obj10 = dictionary;
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v5+A0]");
			object obj13 = 0;
			PropertyData[] array = default;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A58]");
				object obj14 = 0;
				bool flag5 = ((Dictionary<System.__Canon, System.__Canon>)obj13).TryGetValue((System.__Canon)(object)type, out System.__Canon _);
				bool flag6 = !flag5;
				object obj15 = !flag6;
				if (obj15 != null)
				{
					goto IL_0533;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A88]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A80]");
				object obj17 = 0;
				List<PropertyData> list = default;
				list._002Ector();
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v14+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AddPropertiesToMappingForType(type, list, (BindingFlags)52, out var hasChangeCallbacks);
				if ((object)type != null)
				{
					nint num = (nint)type;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v18 (Il2CppClass<System.Type>)+870]");
					object obj20 = 0;
					bool flag8 = ((object)type).Equals((object)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
					object obj22 = 0;
					bool flag9 = hasChangeCallbacks;
					object obj23 = (object)(&hasChangeCallbacks);
					BindingFlags bindingFlags = (BindingFlags)52;
					Type type2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X25_v5+E8]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v20+E4]");
						bool flag10 = (nint)0 == 0;
						object obj25 = !flag10;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = (Type)flag8 != null;
						bool flag12 = !flag11;
						bool flag13 = false;
						type2 = null;
						if (flag12)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X25_v5+E8]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v38+E4]");
						bool flag14 = (nint)0 == 0;
						object obj27 = !flag14;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj22);
						bool flag15 = (Type)flag8 != typeFromHandle;
						bool flag16 = !flag15;
						flag13 = false;
						type2 = typeFromHandle;
						if (flag16)
						{
							break;
						}
						object obj28 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v44+E4]");
						bool flag17 = (nint)0 == 0;
						object obj29 = !flag17;
						if (obj29 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AddPropertiesToMappingForType((Type)flag8, list, (BindingFlags)38, out var hasChangeCallbacks2);
						flag9 |= hasChangeCallbacks2;
						if (flag8)
						{
							nint num2 = (flag8 ? 1 : 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v34 (Il2CppClass<System.Type>)+870]");
							obj20 = 0;
							flag8 = ((object)flag8).Equals((object)0);
							obj23 = (object)(&hasChangeCallbacks2);
							bindingFlags = (BindingFlags)38;
							continue;
						}
						goto IL_05d7;
					}
					bool flag18 = !flag9;
					System.__Canon _Canon = (System.__Canon)(object)type2;
					if (!flag18)
					{
						object obj30 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v34+E4]");
						bool flag19 = (nint)0 == 0;
						object obj31 = !flag19;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj30 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v34+A0]");
						object obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v28+8]");
						if ((nint)0 == 0)
						{
							goto IL_05d7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A68]");
						object obj33 = 0;
						obj23 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v28+8]");
						((Dictionary<System.__Canon, bool>)0).set_Item((System.__Canon)(object)type, true);
						bool flag13 = true;
						_Canon = (System.__Canon)(object)type;
					}
					object obj34 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v27+E4]");
					bool flag20 = (nint)0 == 0;
					object obj35 = !flag20;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj34 = obj;
					}
					if (list != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v27+A0]");
						object obj36 = 0;
						array = list.ToArray();
						if (obj36 != null)
						{
							((Dictionary<System.__Canon, System.__Canon>)obj36).Add((System.__Canon)(object)type, (System.__Canon)(object)array);
							goto IL_0533;
						}
					}
				}
			}
			goto IL_05d7;
			IL_05d7:
			return (PropertyData[])(object)new NullReferenceException();
			IL_0533:
			return array;
		}

		private unsafe static void AddPropertiesToMappingForType(Type type, List<PropertyData> result, BindingFlags bindingFlags, out bool hasChangeCallbacks)
		{
			//IL_126f: Expected I4, but got Obj
			//IL_000d: Expected I, but got Obj
			//IL_001d: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I
			//IL_00a9: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got I
			//IL_00d3: Expected Obj, but got I8
			//IL_00f1: Expected Obj, but got I4
			//IL_134f: Expected Obj, but got I4
			//IL_011b: Expected I4, but got Obj
			//IL_11d7: Expected Obj, but got I
			//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e5: Expected Obj, but got Unknown
			//IL_015a: Expected Obj, but got I
			//IL_0171: Expected I4, but got Obj
			//IL_104f: Expected Obj, but got I
			//IL_105f: Expected Obj, but got I
			//IL_1075: Expected Obj, but got I
			//IL_10dd: Expected Obj, but got I4
			//IL_01d4: Expected Obj, but got I
			//IL_01e0: Expected I, but got Obj
			//IL_01f0: Expected Obj, but got I
			//IL_01fb: Expected Obj, but got I
			//IL_01ff: Expected Obj, but got I4
			//IL_1174: Expected Obj, but got I
			//IL_1184: Expected Obj, but got I
			//IL_11a1: Expected VT, but got Ref
			//IL_1108: Expected Obj, but got I
			//IL_111e: Expected Obj, but got I
			//IL_1127: Unknown result type (might be due to invalid IL or missing references)
			//IL_112c: Expected Obj, but got Unknown
			//IL_023f: Expected Obj, but got I
			//IL_0261: Expected Obj, but got I4
			//IL_030e: Expected Obj, but got I
			//IL_0326: Expected Obj, but got I
			//IL_0336: Expected Obj, but got I
			//IL_02a6: Expected Obj, but got I4
			//IL_07c2: Expected I, but got Obj
			//IL_07e3: Expected Obj, but got I
			//IL_03a5: Expected Obj, but got I
			//IL_082f: Expected Obj, but got I
			//IL_083f: Expected Obj, but got I
			//IL_0c69: Expected Obj, but got I4
			//IL_0c8f: Expected VT, but got Obj
			//IL_0889: Expected Obj, but got I4
			//IL_08af: Expected VT, but got Obj
			//IL_0443: Expected Obj, but got I
			//IL_044b: Expected I4, but got Obj
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Expected Obj, but got Unknown
			//IL_0485: Expected Obj, but got I8
			//IL_0ce4: Expected Obj, but got I
			//IL_0d0a: Expected Obj, but got I
			//IL_0904: Expected Obj, but got I
			//IL_092a: Expected Obj, but got I
			//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04db: Expected Obj, but got Unknown
			//IL_04eb: Expected Obj, but got I
			//IL_0517: Expected Obj, but got I4
			//IL_052d: Expected Obj, but got I
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Expected Obj, but got Unknown
			//IL_0d62: Expected I, but got Obj
			//IL_058b: Expected Obj, but got I
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Expected Obj, but got Unknown
			//IL_05b3: Expected I, but got Obj
			//IL_05ea: Expected Obj, but got I8
			//IL_0982: Expected I, but got Obj
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Expected Obj, but got Unknown
			//IL_0638: Expected Obj, but got I4
			//IL_0664: Expected Obj, but got I4
			//IL_067a: Expected Obj, but got I
			//IL_069a: Unknown result type (might be due to invalid IL or missing references)
			//IL_069f: Expected Obj, but got Unknown
			//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e02: Expected Obj, but got Unknown
			//IL_0e46: Expected I4, but got Obj
			//IL_06e0: Expected Obj, but got I
			//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ee: Expected Obj, but got Unknown
			//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a22: Expected Obj, but got Unknown
			//IL_0a66: Expected I4, but got Obj
			//IL_072a: Expected Obj, but got I
			//IL_076c: Expected I4, but got Obj
			//IL_0e5c: Expected I, but got Obj
			//IL_0e8d: Expected Obj, but got I
			//IL_0a7c: Expected I, but got Obj
			//IL_0aad: Expected Obj, but got I
			//IL_0ed7: Expected I, but got Obj
			//IL_0af7: Expected I, but got Obj
			//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f5f: Expected Obj, but got Unknown
			//IL_0f9a: Expected I4, but got Obj
			//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7f: Expected Obj, but got Unknown
			//IL_0bba: Expected I4, but got Obj
			//IL_1314: Expected Obj, but got Ref
			//IL_1329: Expected I4, but got Obj
			//IL_0fe7: Expected Obj, but got I
			//IL_1378: Expected I4, but got Obj
			//IL_12df: Expected Obj, but got Ref
			//IL_12f9: Expected I4, but got Obj
			//IL_0c07: Expected Obj, but got I
			ref bool reference = ref *(bool*)null;
			bool flag = (object)type == null;
			object obj = null;
			BindingFlags bindingFlags2 = bindingFlags;
			BindingFlags bindingFlags3 = (BindingFlags)result;
			IndexOutOfRangeException ex = default;
			if (!flag)
			{
				nint num = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7 (Il2CppClass<System.Type>)+838]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7 (Il2CppClass<System.Type>)+840]");
				bindingFlags2 = (BindingFlags)0;
				IEnumerable<Type> implementedInterfaces = ((TypeInfo)type).ImplementedInterfaces;
				bool flag2 = implementedInterfaces == null;
				obj = null;
				bindingFlags3 = bindingFlags;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v13 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
					if ((nint)0 < (nint)1)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A98]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AA0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v13 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
					object obj6 = 0 & 0xFFFFFFFFL;
					object obj7 = null;
					object obj8 = null;
					object obj9 = null;
					obj = null;
					object obj10 = 0;
					bindingFlags3 = bindingFlags;
					List<PropertyData> list = result;
					MethodBase methodBase = default;
					MethodBase methodBase2 = default;
					object obj26 = default;
					string[] array = default;
					IntPtr intPtr = default;
					string text2 = default;
					object[] array2 = default;
					string text3 = default;
					object[] array3 = default;
					while (true)
					{
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
						object obj11 = !flag3;
						if (obj11 != null)
						{
							break;
						}
						object obj12 = (object)implementedInterfaces + obj10;
						bindingFlags3 = (BindingFlags)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
						if ((object)methodBase == null)
						{
							goto IL_11c7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj13 = (nint)(&obj9) | (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bindingFlags3 = (BindingFlags)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3599854");
						bool flag4 = (object)methodBase2 == null;
						obj7 = null;
						obj8 = obj9;
						MethodBase methodBase3 = methodBase;
						MethodInfo method;
						object obj14;
						if (!flag4)
						{
							Type type2 = type;
							while (true)
							{
								bool flag5 = (object)type2 == null;
								obj14 = null;
								obj = obj9;
								if (flag5)
								{
									break;
								}
								Type type3 = type2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v24 (System.Reflection.MethodBase)+10]");
								method = type3.GetMethod((string)0, (BindingFlags)52);
								nint num2 = (nint)type2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v22 (Il2CppClass<System.Type>)+868]");
								obj2 = 0;
								Type type4 = (Type)((object)type2).Equals((object)0);
								if (method == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X29_v8+E8]");
									object obj15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X0_v111+E4]");
									bool flag6 = (nint)0 == 0;
									object obj16 = !flag6;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag7 = type4 != null;
									bool flag8 = !flag7;
									object obj17 = !flag8;
									reference = ref *(bool*)null;
									type2 = type4;
									bindingFlags2 = (BindingFlags)0;
									bindingFlags3 = (BindingFlags)0;
									if (obj17 != null)
									{
										continue;
									}
								}
								goto IL_02d3;
							}
							goto IL_120a;
						}
						goto IL_127d;
						IL_127d:
						bool flag9 = list == null;
						obj14 = null;
						obj = obj9;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+10]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AA8]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+1C]");
							object obj20 = (nint)0 + (nint)1;
							obj2 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+10]");
							bool flag10 = (nint)0 == 0;
							obj14 = null;
							obj = obj9;
							if (!flag10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+18]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v17+18]");
								bool flag11 = num3 < 0;
								object obj21 = !flag11;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+10]");
									nint num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+18]");
									object obj22 = num4 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X20_v9 (System.Collections.Generic.List`1<Fusion.NetworkBehaviourUtils+ChangeDetector+PropertyData>)+18]");
									obj2 = (nint)0 + (nint)1;
									object obj23 = obj22 + 32;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj14 = obj8;
									obj = obj7;
									bindingFlags3 = (BindingFlags)0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X9_v8+20]");
									object obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v18+A8]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v19+70]");
									bindingFlags2 = (BindingFlags)0;
									list.AddWithResize((PropertyData)(&obj26));
									obj26 = obj8;
									obj14 = obj7;
									obj = obj8;
									bindingFlags3 = (BindingFlags)(int)(&obj26);
								}
								goto IL_11c7;
							}
						}
						goto IL_120a;
						IL_11c7:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v13 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
						obj6 = 0;
						obj10++;
						object obj27 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v13 (System.Collections.Generic.IEnumerable`1<System.Type>)+18]");
						if ((nint)obj27 >= 0)
						{
							return;
						}
						continue;
						IL_123b:
						throw new InvalidCastException();
						IL_135d:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						reference = ref *(bool*)1;
						object obj28;
						bindingFlags3 = (BindingFlags)obj28;
						goto IL_127d;
						IL_02d3:
						if (method == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
							object obj29 = 0;
							object obj30 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X8_v60+A0]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v61+18]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v61+18]");
							bool flag12 = (nint)0 == 0;
							reference = ref *(bool*)null;
							obj7 = null;
							obj8 = obj9;
							obj14 = null;
							methodBase3 = methodBase2;
							obj = obj9;
							bindingFlags2 = (BindingFlags)0;
							bindingFlags3 = (BindingFlags)0;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
								object obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								bool flag13 = array == null;
								reference = ref *(bool*)null;
								obj14 = null;
								obj = obj9;
								bindingFlags2 = (BindingFlags)0;
								bindingFlags3 = (BindingFlags)5;
								if (flag13)
								{
									goto IL_120a;
								}
								bool flag14 = array.Length == 0;
								reference = ref *(bool*)null;
								obj14 = null;
								obj = obj9;
								bindingFlags2 = (BindingFlags)0;
								bindingFlags3 = (BindingFlags)5;
								if (flag14)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AC0]");
								object obj34 = 0;
								bindingFlags3 = (BindingFlags)obj34;
								object obj35 = array + 32;
								obj35 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X26_v11-8]");
								object obj36 = 0 & 0xFFFFFFFEL;
								bool flag15 = obj36 == null;
								reference = ref *(bool*)null;
								obj14 = null;
								obj = obj9;
								bindingFlags2 = (BindingFlags)0;
								if (flag15)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v24 (System.Reflection.MethodBase)+10]");
								bindingFlags3 = (BindingFlags)0;
								object obj37 = array + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v24 (System.Reflection.MethodBase)+10]");
								obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X24_v19-10]");
								bool flag16 = (nint)0 < (nint)2;
								object obj38 = !flag16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X24_v19-10]");
								object obj39 = -2;
								bool flag17 = obj39 == null;
								object obj40 = ~obj38;
								object obj41 = obj40 | flag17;
								reference = ref *(bool*)null;
								obj14 = null;
								obj = obj9;
								bindingFlags2 = (BindingFlags)0;
								if (obj41 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AC8]");
								object obj42 = 0;
								object obj43 = array + 48;
								obj43 = obj42;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								nint num5 = (nint)type;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X8_v71 (Il2CppClass<System.Type>)+1C0]");
								bindingFlags3 = (BindingFlags)0;
								BindingFlags bindingFlags4 = (((System.RuntimeType)type).IsArrayImpl() ? ((BindingFlags)1) : ((BindingFlags)0));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X24_v21-18]");
								object obj44 = 0 & 0xFFFFFFFCL;
								bool flag18 = obj44 == null;
								reference = ref *(bool*)null;
								obj14 = null;
								obj = obj9;
								bindingFlags2 = (BindingFlags)0;
								if (flag18)
								{
									break;
								}
								methodBase3 = (MethodBase)(array + 56);
								methodBase3 = (MethodBase)bindingFlags4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X24_v8 (System.Reflection.MethodBase)-20]");
								bool flag19 = (nint)0 < (nint)4;
								object obj45 = !flag19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X24_v8 (System.Reflection.MethodBase)-20]");
								object obj46 = -4;
								bool flag20 = obj46 == null;
								object obj47 = ~obj45;
								object obj48 = obj47 | flag20;
								reference = ref *(bool*)null;
								obj14 = null;
								obj = obj9;
								bindingFlags2 = (BindingFlags)0;
								bindingFlags3 = bindingFlags4;
								if (obj48 != null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AD8]");
								object obj49 = 0;
								object obj50 = array + 64;
								obj50 = obj49;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								string text = string.Concat(array);
								object obj51 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v76+198]");
								obj2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v76+1A0]");
								bindingFlags2 = (BindingFlags)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v774 @ X8_v76+198] (should have been resolved before IL gen)");
								reference = ref *(bool*)null;
								obj7 = null;
								obj8 = obj9;
								obj14 = null;
								obj = obj9;
								bindingFlags3 = (BindingFlags)text;
								list = result;
							}
							goto IL_11c7;
						}
						bool flag21 = (object)method == null;
						reference = ref *(bool*)null;
						obj14 = null;
						obj = obj9;
						bindingFlags2 = (BindingFlags)0;
						bindingFlags3 = (BindingFlags)0;
						PropertyInfo property2;
						object obj67;
						object obj61;
						if (!flag21)
						{
							nint num6 = (nint)method;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v24 (Il2CppClass<System.Reflection.MethodInfo>)+240]");
							bindingFlags3 = (BindingFlags)0;
							ConstructorInfo constructor = ((Type)(object)method).GetConstructor((BindingFlags)0, (Binder)null, (Type[])null, (ParameterModifier[])(nint)intPtr);
							bool flag22 = (object)constructor == null;
							reference = ref *(bool*)null;
							obj14 = null;
							obj = obj9;
							bindingFlags2 = (BindingFlags)0;
							if (!flag22)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X29_v8+E8]");
								object obj52 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A90]");
								object obj53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v40 (System.Reflection.ConstructorInfo)+18]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v41+E4]");
									bool flag23 = (nint)0 == 0;
									object obj54 = !flag23;
									if (obj54 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj53);
									bool flag24 = (object)typeFromHandle == null;
									reference = ref *(bool*)null;
									obj14 = null;
									obj = obj9;
									bindingFlags2 = (BindingFlags)0;
									bindingFlags3 = (BindingFlags)0;
									if (!flag24)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AE0]");
										object name = 0;
										MethodInfo method2 = typeFromHandle.GetMethod((string)name, (BindingFlags)40);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
										object obj55 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										bool flag25 = text2 == null;
										reference = ref *(bool*)null;
										obj14 = null;
										obj = obj9;
										bindingFlags2 = (BindingFlags)40;
										bindingFlags3 = (BindingFlags)1;
										if (!flag25)
										{
											nint num7 = (nint)text2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v49 (Il2CppClass<System.String>)+40]");
											bindingFlags3 = (BindingFlags)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag26 = ex == null;
											reference = ref *(bool*)null;
											obj14 = null;
											obj = obj9;
											bindingFlags2 = (BindingFlags)40;
											if (flag26)
											{
												goto IL_1226;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v73 (System.String)+18]");
											bool flag27 = (nint)0 == 0;
											reference = ref *(bool*)null;
											obj14 = null;
											obj = obj9;
											bindingFlags2 = (BindingFlags)40;
											if (flag27)
											{
												break;
											}
											object obj56 = text2 + 32;
											obj56 = type;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag28 = (object)method2 == null;
											reference = ref *(bool*)null;
											obj14 = null;
											obj = obj9;
											bindingFlags2 = (BindingFlags)40;
											bindingFlags3 = (BindingFlags)type;
											if (!flag28)
											{
												nint num8 = (nint)method2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X8_v51 (Il2CppClass<System.Reflection.MethodInfo>)+3E0]");
												bindingFlags2 = (BindingFlags)0;
												PropertyInfo property = ((Type)(object)method2).GetProperty(text2);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
												object obj57 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												bool flag29 = array2 == null;
												reference = ref *(bool*)null;
												obj14 = null;
												obj = obj9;
												bindingFlags3 = (BindingFlags)1;
												if (!flag29)
												{
													nint num9 = (nint)array2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
													bindingFlags3 = (BindingFlags)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag30 = ex == null;
													reference = ref *(bool*)null;
													obj14 = null;
													obj = obj9;
													if (flag30)
													{
														goto IL_1226;
													}
													bool flag31 = array2.Length == 0;
													reference = ref *(bool*)null;
													obj14 = null;
													obj = obj9;
													if (flag31)
													{
														break;
													}
													object obj58 = array2 + 32;
													obj58 = method;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													bool flag32 = (object)property == null;
													reference = ref *(bool*)null;
													obj14 = null;
													obj = obj9;
													bindingFlags3 = (BindingFlags)method;
													if (!flag32)
													{
														object obj59 = ((MethodBase)(object)property).Invoke((object)null, array2);
														if (obj59 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AB8]");
															object obj60 = 0;
															if (obj59 != obj60 || obj59 != obj60)
															{
																goto IL_123b;
															}
														}
														obj61 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 24));
														reference = ref *(bool*)null;
														obj7 = null;
														methodBase3 = (MethodBase)(object)property;
														bindingFlags2 = (BindingFlags)array2;
														obj28 = obj59;
														goto IL_135d;
													}
												}
											}
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v41+E4]");
									bool flag33 = (nint)0 == 0;
									object obj62 = !flag33;
									if (obj62 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj53);
									bool flag34 = (object)typeFromHandle2 == null;
									reference = ref *(bool*)null;
									obj14 = null;
									obj = obj9;
									bindingFlags2 = (BindingFlags)0;
									bindingFlags3 = (BindingFlags)0;
									if (!flag34)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AD0]");
										object name2 = 0;
										MethodInfo method3 = typeFromHandle2.GetMethod((string)name2, (BindingFlags)40);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3AB8]");
										object obj63 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										bool flag35 = text3 == null;
										reference = ref *(bool*)null;
										obj14 = null;
										obj = obj9;
										bindingFlags2 = (BindingFlags)40;
										bindingFlags3 = (BindingFlags)1;
										if (!flag35)
										{
											nint num10 = (nint)text3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v35 (Il2CppClass<System.String>)+40]");
											bindingFlags3 = (BindingFlags)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag36 = ex == null;
											reference = ref *(bool*)null;
											obj14 = null;
											obj = obj9;
											bindingFlags2 = (BindingFlags)40;
											if (flag36)
											{
												goto IL_1226;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v49 (System.String)+18]");
											bool flag37 = (nint)0 == 0;
											reference = ref *(bool*)null;
											obj14 = null;
											obj = obj9;
											bindingFlags2 = (BindingFlags)40;
											if (flag37)
											{
												break;
											}
											object obj64 = text3 + 32;
											obj64 = type;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag38 = (object)method3 == null;
											reference = ref *(bool*)null;
											obj14 = null;
											obj = obj9;
											bindingFlags2 = (BindingFlags)40;
											bindingFlags3 = (BindingFlags)type;
											if (!flag38)
											{
												nint num11 = (nint)method3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v37 (Il2CppClass<System.Reflection.MethodInfo>)+3E0]");
												bindingFlags2 = (BindingFlags)0;
												property2 = ((Type)(object)method3).GetProperty(text3);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
												object obj65 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												bool flag39 = array3 == null;
												reference = ref *(bool*)null;
												obj14 = null;
												obj = obj9;
												bindingFlags3 = (BindingFlags)1;
												if (!flag39)
												{
													nint num12 = (nint)array3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
													bindingFlags3 = (BindingFlags)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag40 = ex == null;
													reference = ref *(bool*)null;
													obj14 = null;
													obj = obj9;
													if (flag40)
													{
														goto IL_1226;
													}
													bool flag41 = array3.Length == 0;
													reference = ref *(bool*)null;
													obj14 = null;
													obj = obj9;
													if (flag41)
													{
														break;
													}
													object obj66 = array3 + 32;
													obj66 = method;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													bool flag42 = (object)property2 == null;
													reference = ref *(bool*)null;
													obj14 = null;
													obj = obj9;
													bindingFlags3 = (BindingFlags)method;
													if (!flag42)
													{
														obj67 = ((MethodBase)(object)property2).Invoke((object)null, array3);
														if (obj67 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AB0]");
															object obj68 = 0;
															if (obj67 == obj68)
															{
																bool flag43 = obj67 == obj68;
																obj7 = obj67;
																if (flag43)
																{
																	goto IL_1306;
																}
															}
															goto IL_123b;
														}
														obj7 = null;
														goto IL_1306;
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_120a;
						IL_1306:
						obj61 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 16));
						reference = ref *(bool*)null;
						methodBase3 = (MethodBase)(object)property2;
						bindingFlags2 = (BindingFlags)array3;
						obj28 = obj67;
						goto IL_135d;
					}
					goto IL_1218;
				}
			}
			goto IL_120a;
			IL_1218:
			ex = new IndexOutOfRangeException();
			goto IL_1226;
			IL_1226:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			throw new ArgumentNullException();
			IL_120a:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_1218;
		}

		unsafe ~ChangeDetector()
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Ref, but got Unknown
			//IL_00d4: Expected Obj, but got I4
			//IL_00dd: Expected Obj, but got I4
			//IL_00e6: Expected Obj, but got I4
			//IL_00f3: Expected Obj, but got Ref
			//IL_0116: Expected Obj, but got I4
			//IL_0020: Expected Obj, but got I4
			FusionUnsafe.Free(ref *(int**)(this + 32));
			object obj = 0;
			object obj2 = 0;
			object obj3 = 0;
			ChangeDetector changeDetector = default;
			object obj4 = (object)(&changeDetector);
			obj4.Finalize();
			bool flag = obj3 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				bool flag2 = obj2 == null;
				object obj6 = !flag2;
				OutOfMemoryException ex = (OutOfMemoryException)obj4;
				if (obj6 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A3AB4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		}

		public unsafe void Init(NetworkBehaviour networkBehaviour, Source source, bool copyInitial = default(bool))
		{
			//IL_011a: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_0142: Expected Obj, but got I
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			//IL_0057: Expected Obj, but got I
			//IL_0177: Expected Obj, but got I
			//IL_0084: Expected I4, but got Obj
			//IL_00af: Expected VT, but got I4
			//IL_00cc: Expected Obj, but got I
			//IL_00de: Expected Obj, but got I4
			//IL_01e7: Expected Obj, but got I
			//IL_021b: Expected Obj, but got I4
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Expected Obj, but got Unknown
			//IL_02b3: Expected Obj, but got I
			//IL_02e6: Expected Obj, but got I
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Expected Obj, but got Unknown
			//IL_0346: Expected VT, but got I4
			//IL_0351: Expected VT, but got I4
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Expected Obj, but got Unknown
			//IL_03a3: Expected Obj, but got I8
			//IL_03c8: Expected Obj, but got I
			//IL_03d3: Expected Obj, but got I4
			//IL_03ea: Expected Obj, but got I4
			//IL_04bc: Expected Obj, but got I
			//IL_044e: Expected Obj, but got I4
			int wordCount = networkBehaviour.WordCount;
			object obj = default;
			int num3;
			bool flag2;
			int num4;
			int? num;
			if (networkBehaviour.WordCount != 0)
			{
				obj = this + 24;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
				object obj3 = 0;
				bool flag = obj == null;
				Source source2 = source;
				if (!flag)
				{
					source2 = (Source)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v12+18]");
					num = 0;
					wordCount = networkBehaviour.WordCount;
					num = (int?)(object)0;
					object obj4 = default;
					obj2 = obj4;
				}
				if ((nint)obj2 < wordCount)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					int num2 = default;
					obj = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					flag2 = copyInitial;
					num3 = (int)source2;
					num4 = num2;
					goto IL_01d7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj6 = 0;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v7+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+18]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A00]");
				object obj10 = 0;
				object obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v157 @ X9_v3+198] (should have been resolved before IL gen)");
			}
			Array array = (Array)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v37 (System.Array)+18]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v37 (System.Array)+18]");
			Array.Clear(array, 0, 0);
			flag2 = false;
			num4 = 0;
			goto IL_01d7;
			IL_01d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type type = default;
			PropertyData[] propertyMappping = GetPropertyMappping(type);
			object obj15 = this + 48;
			object obj16 = obj15;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v15+18]");
				if ((nint)0 >= (nint)propertyMappping.Length)
				{
					goto IL_0312;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			string[] changed = default;
			_changed = changed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59F8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj19 = this + 56;
			object obj20 = default;
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			goto IL_0312;
			IL_0312:
			int instanceID = networkBehaviour.GetInstanceID();
			num = instanceID;
			_source = source;
			_sourceTick = (Tick)0;
			_instance = (int?)(object)0;
			if (!copyInitial)
			{
				return;
			}
			object obj21 = obj;
			object obj22 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18+18]");
			object obj23 = 0 & 0xFFFFFFFFL;
			bool flag4 = obj23 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v18+18]");
			object obj24 = (nint)0 << 2;
			object obj25 = !flag4;
			if (obj25 == null)
			{
				object obj26 = 0;
			}
			else
			{
				object obj26 = obj22;
			}
			bool flag5 = obj24 == null;
			bool flag6 = obj24 == null;
			bool flag7 = flag5;
			if (!flag6)
			{
				bool flag8 = obj23 == null;
				flag7 = flag5;
				if (!flag8)
				{
					object obj27 = obj24 >> 30;
					bool flag9 = networkBehaviour.Ptr == null;
					object obj28 = !flag9;
					object obj29 = ~obj28;
					bool flag10 = obj29 == null && obj27 == null;
					flag7 = flag10;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		}

		public Enumerable DetectChanges(NetworkBehaviour b, out NetworkBehaviourBuffer previous, out NetworkBehaviourBuffer current, bool copyChanges = default(bool))
		{
			return DetectChangesInternal(b, out previous, out current, copyChanges);
		}

		public Enumerable DetectChanges(NetworkBehaviour b, bool copyChanges = default(bool))
		{
			NetworkBehaviourBuffer previous;
			NetworkBehaviourBuffer current;
			return DetectChangesInternal(b, out previous, out current, copyChanges);
		}

		private unsafe Enumerable DetectChangesInternal(NetworkBehaviour b, out NetworkBehaviourBuffer previous, out NetworkBehaviourBuffer current, bool copyChanges = default(bool))
		{
			//IL_0230: Expected Obj, but got I
			//IL_0248: Expected Obj, but got I
			//IL_0258: Expected Obj, but got I
			//IL_0cb7: Expected VT, but got I4
			//IL_0046: Expected VT, but got I
			//IL_0060: Expected Obj, but got I
			//IL_008a: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got I
			//IL_0c7c: Invalid comparison between VT and I4
			//IL_0359: Expected VT, but got Obj
			//IL_03a8: Expected VT, but got I
			//IL_03d4: Expected Obj, but got I4
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Expected Obj, but got Unknown
			//IL_040a: Expected Obj, but got I4
			//IL_0413: Expected I4, but got Obj
			//IL_021b: Expected Obj, but got Ref
			//IL_0d4c: Expected Obj, but got I4
			//IL_0587: Expected Obj, but got I4
			//IL_0448: Expected Obj, but got I
			//IL_0458: Expected Obj, but got I
			//IL_0468: Expected I4, but got Obj
			//IL_04a9: Expected Obj, but got I4
			//IL_0d81: Expected Obj, but got I
			//IL_0d89: Expected I4, but got Obj
			//IL_0514: Expected Obj, but got I
			//IL_052e: Expected Obj, but got I4
			//IL_0537: Expected I4, but got Obj
			//IL_05bb: Expected Obj, but got I4
			//IL_0600: Expected Obj, but got I4
			//IL_0ff5: Expected Obj, but got I4
			//IL_062a: Expected Obj, but got I
			//IL_0bc2: Expected Ref, but got VT
			//IL_0be4: Expected VT, but got Obj
			//IL_066c: Expected Obj, but got I
			//IL_0de4: Expected Obj, but got I4
			//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df2: Expected Obj, but got Unknown
			//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a8: Expected Obj, but got Unknown
			//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Expected Obj, but got Unknown
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Expected Obj, but got Unknown
			//IL_0a85: Expected Obj, but got I4
			//IL_0a8e: Expected Obj, but got I4
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_0705: Expected Obj, but got Unknown
			//IL_070e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Expected Obj, but got Unknown
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0721: Expected Obj, but got Unknown
			//IL_077f: Expected F8, but got I
			//IL_079a: Expected Obj, but got I4
			//IL_0acf: Expected Obj, but got I4
			//IL_07b7: Expected Obj, but got Ref
			//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c5: Expected Obj, but got Unknown
			//IL_07cd: Expected Obj, but got Ref
			//IL_0afc: Expected Obj, but got I
			//IL_0820: Expected Obj, but got VT
			//IL_083a: Expected Obj, but got I
			//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f75: Expected Obj, but got Unknown
			//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f83: Expected Obj, but got Unknown
			//IL_0f8b: Invalid comparison between Ref and Obj
			//IL_0b3e: Expected Ref, but got VT
			//IL_0884: Expected Obj, but got I4
			//IL_08a1: Expected Obj, but got Ref
			//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bd: Expected Obj, but got Unknown
			//IL_099c: Expected Obj, but got I4
			//IL_0e92: Expected Obj, but got I
			//IL_0e9a: Expected I4, but got Obj
			//IL_09b2: Expected Obj, but got I4
			//IL_091c: Expected Obj, but got I
			//IL_0e6d: Expected Obj, but got I4
			bool flag = (object)b == null;
			bool flag2 = copyChanges;
			ref NetworkBehaviourBuffer reference = ref current;
			ref NetworkBehaviourBuffer reference2 = ref previous;
			NetworkBehaviour networkBehaviour = b;
			ref NetworkBehaviourBuffer reference3 = ref previous;
			NetworkBehaviourBuffer networkBehaviourBuffer;
			PropertyData[] propertyMappping;
			NetworkBehaviourBuffer from;
			NetworkBehaviourBuffer to;
			float alpha;
			float num;
			double num3;
			Tick tick;
			float num2 = default;
			double num4 = default;
			if (!flag)
			{
				int instanceID = b.GetInstanceID();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkBehaviourUtils+ChangeDetector)+14]");
				if ((nint)instanceID != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj = 0;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v10+A0]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11+18]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B00]");
						object obj5 = 0;
						object obj6 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v457 @ X9_v4+198] (should have been resolved before IL gen)");
					}
					goto IL_0c90;
				}
				networkBehaviourBuffer = (NetworkBehaviourBuffer)b.Ptr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type type = default;
				propertyMappping = GetPropertyMappping(type);
				if (_source != 0)
				{
					RenderTimeline.GetRenderBuffers(b, out from, out to, out alpha);
					if (_source == (Source)1)
					{
						goto IL_01a7;
					}
					bool flag4 = _source != (Source)3;
					num = num2;
					num3 = num4;
					Tick tick2 = default;
					tick = tick2;
					networkBehaviourBuffer = to;
					if (!flag4)
					{
						bool flag5 = !((double)alpha < 0.5);
						num2 = alpha;
						num4 = 0.5;
						num = alpha;
						num3 = 0.5;
						tick = tick2;
						networkBehaviourBuffer = to;
						if (!flag5)
						{
							goto IL_01a7;
						}
					}
					goto IL_0c73;
				}
				NetworkObject networkObject = ((SimulationBehaviour)b)._object;
				bool flag6 = (object)((SimulationBehaviour)b)._object == null;
				flag2 = copyChanges;
				reference = ref current;
				reference2 = ref previous;
				networkBehaviour = null;
				reference3 = ref previous;
				if (!flag6)
				{
					NetworkRunner runner = networkObject._runner;
					bool flag7 = (object)networkObject._runner == null;
					flag2 = copyChanges;
					reference = ref current;
					reference2 = ref previous;
					networkBehaviour = null;
					reference3 = ref previous;
					if (!flag7)
					{
						tick = (Tick)runner._simulation;
						bool flag8 = (object)runner._simulation == null;
						flag2 = copyChanges;
						reference = ref current;
						reference2 = ref previous;
						networkBehaviour = null;
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v19 (Fusion.Tick)+50]");
							tick = (Tick)0;
							flag2 = copyChanges;
							reference = ref current;
							reference2 = ref previous;
							networkBehaviour = null;
						}
						goto IL_0cbc;
					}
				}
			}
			goto IL_0cf7;
			IL_0d71:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
			object obj10 = 0;
			flag2 = (byte)(int)obj10 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			bool flag9 = propertyMappping == null;
			ref NetworkBehaviourBuffer reference4;
			reference = ref reference4;
			reference2 = ref reference4;
			NetworkBehaviour networkBehaviour2;
			networkBehaviour = networkBehaviour2;
			reference3 = ref previous;
			if (flag9)
			{
				goto IL_0cf7;
			}
			object obj11 = propertyMappping.Length;
			ref NetworkBehaviourBuffer reference5;
			NetworkBehaviour networkBehaviour8;
			if (propertyMappping.Length >= 1)
			{
				reference5 = ref *(NetworkBehaviourBuffer*)null;
				reference = ref reference4;
				reference2 = ref reference4;
				networkBehaviour = networkBehaviour2;
				object obj12 = 0;
				reference3 = ref previous;
				NetworkBehaviour networkBehaviour7 = default;
				while (true)
				{
					bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
					object obj13 = !flag10;
					if (obj13 != null)
					{
						break;
					}
					object obj14 = (object)propertyMappping + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v26+28]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v26+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+14]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+10]");
						object obj16 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+10]");
						if (0 >= (nint)obj16)
						{
							goto IL_0dda;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+10]");
						NetworkBehaviour networkBehaviour3 = (NetworkBehaviour)(networkBehaviour2 + 0);
						NetworkBehaviourBuffer networkBehaviourBuffer2 = networkBehaviourBuffer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+10]");
						NetworkBehaviour networkBehaviour4 = (NetworkBehaviour)(networkBehaviourBuffer2 + 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v26+20]");
						ref NetworkBehaviourBuffer reference6 = ref *(NetworkBehaviourBuffer*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+10]");
						object obj17 = obj16 - 0;
						NetworkBehaviour networkBehaviour5 = networkBehaviour3;
						NetworkBehaviour networkBehaviour6 = networkBehaviour4;
						while ((object)networkBehaviour5 == networkBehaviour6)
						{
							obj17--;
							networkBehaviour5 = (NetworkBehaviour)(networkBehaviour5 + 4);
							networkBehaviour6 = (NetworkBehaviour)(networkBehaviour6 + 4);
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_0dda;
						}
						PropertyData[] changedProperty = _changedProperty;
						if (_changedProperty != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v26+30]");
							num4 = 0.0;
							bool flag11 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5) < (nint)changedProperty.Length;
							object obj18 = !flag11;
							if (obj18 != null)
							{
								break;
							}
							object obj19 = (ref *(byte*)_changedProperty) + (ref System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviourBuffer, byte>(ref reference5));
							object obj20 = obj19 + 32;
							obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference6);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v26+28]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v26+30]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag12 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference6) == null;
							networkBehaviour = null;
							if (!flag12)
							{
								object obj21 = reference6;
								reference3 = ref *(NetworkBehaviourBuffer*)_changed;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v50+1C0]");
								networkBehaviour = (NetworkBehaviour)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X8_v50+1B8] (should have been resolved before IL gen)");
								if (_changed != null)
								{
									ref NetworkBehaviourBuffer reference7 = ref reference5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X22_v9 (Fusion.NetworkBehaviourBuffer&)+18]");
									bool flag13 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference7) < unchecked((nint)null);
									object obj22 = !flag13;
									if (obj22 != null)
									{
										break;
									}
									object obj23 = (ref *(byte*)_changed) + (ref System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviourBuffer, byte>(ref reference5));
									ref NetworkBehaviourBuffer reference8 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference5, 1);
									object obj24 = obj23 + 32;
									obj24 = networkBehaviour7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (!copyChanges)
									{
										reference4 = ref *(NetworkBehaviourBuffer*)propertyMappping;
										reference5 = ref reference8;
										networkBehaviour8 = networkBehaviour2;
										networkBehaviour = networkBehaviour7;
										reference3 = ref reference8;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v47+14]");
										reference6 = ref *(NetworkBehaviourBuffer*)((nint)0 << 2);
										if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference6) != null)
										{
											if ((object)networkBehaviour3 != null)
											{
												object obj25 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference6) >> 30;
												bool flag14 = obj25 != null || (object)networkBehaviour4 == null;
												object obj26 = !flag14;
												networkBehaviour8 = networkBehaviour3;
												object obj27 = obj26;
											}
											else
											{
												networkBehaviour8 = networkBehaviour3;
												object obj27 = 0;
											}
										}
										else
										{
											networkBehaviour8 = networkBehaviour3;
											object obj27 = 1;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
										object obj28 = 0;
										flag2 = (byte)(int)obj28 != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
										reference4 = ref *(NetworkBehaviourBuffer*)propertyMappping;
										reference5 = ref reference8;
										reference = ref reference6;
										reference2 = ref reference6;
										networkBehaviour = networkBehaviour4;
										reference3 = ref reference8;
									}
									goto IL_0dda;
								}
							}
						}
					}
					goto IL_0cf7;
					IL_0dda:
					obj11 = propertyMappping.Length;
					obj12++;
					if ((nint)obj12 < propertyMappping.Length)
					{
						continue;
					}
					goto IL_0ee3;
				}
				goto IL_0be9;
			}
			reference5 = ref *(NetworkBehaviourBuffer*)null;
			reference = ref reference4;
			reference2 = ref reference4;
			networkBehaviour = networkBehaviour2;
			reference3 = ref previous;
			goto IL_0ee3;
			IL_0cbc:
			int[] words = _words;
			_sourceTick = tick;
			bool flag15 = _words == null;
			reference3 = ref previous;
			if (flag15)
			{
				goto IL_0cf7;
			}
			networkBehaviour8 = (NetworkBehaviour)words.Length;
			int* ptr = _wordsPrevious;
			NetworkBehaviour networkBehaviour9 = (NetworkBehaviour)(_words + 32);
			bool flag16 = words.Length == 0;
			object obj29 = !flag16;
			networkBehaviour2 = (((int)(~obj29) != 0) ? null : networkBehaviour9);
			bool flag17 = ptr == null;
			object obj30 = !flag17;
			int[] words2 = _words;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AF8]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5AF0]");
				object obj32 = 0;
				reference2 = ref *(NetworkBehaviourBuffer*)obj31;
				flag2 = (byte)(int)obj32 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30AD444");
				words2 = _words;
				int* ptr2 = default;
				_wordsPrevious = ptr2;
				bool flag18 = _words == null;
				reference = ref *(NetworkBehaviourBuffer*)361;
				networkBehaviour = (NetworkBehaviour)8;
				reference3 = ref previous;
				if (flag18)
				{
					goto IL_0cf7;
				}
				ptr = ptr2;
			}
			reference4 = ref *(NetworkBehaviourBuffer*)(words2.Length << 2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
			if ((nint)0 != 0)
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) != null)
				{
					goto IL_04e9;
				}
			}
			else
			{
				_ = 1;
				bool flag19 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) == null;
				object obj33 = !flag19;
				if (obj33 != null)
				{
					goto IL_04e9;
				}
			}
			bool flag20 = true;
			goto IL_0d71;
			IL_0ee3:
			ref NetworkBehaviourBuffer reference9;
			if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5) >= (nint)1)
			{
				int[] words3 = _words;
				if (_words == null)
				{
					goto IL_0cf7;
				}
				reference9 = ref *(NetworkBehaviourBuffer*)_wordsPrevious;
				_ = words3.Length;
				_ = _sourceTick;
			}
			else
			{
				reference9 = ref *(NetworkBehaviourBuffer*)null;
				_ = 0;
			}
			if (~(InvokeCallbacks ? 1u : 0u) != 0 || _changedProperty == null || (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5) < (nint)1)
			{
				goto IL_0b91;
			}
			object obj34 = 56;
			object obj35 = 0;
			while (true)
			{
				PropertyData[] changedProperty2 = _changedProperty;
				if (_changedProperty == null)
				{
					break;
				}
				if ((nint)obj35 < changedProperty2.Length)
				{
					bool flag21 = (nint)obj35 < changedProperty2.Length;
					object obj36 = !flag21;
					if (obj36 != null)
					{
						goto IL_0be9;
					}
					object obj37 = (object)_changedProperty + obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X9_v19-8]");
					object obj38 = 0;
					object obj39 = obj37;
					if (obj37 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v38+28]");
						flag2 = false;
						reference2 = ref *(NetworkBehaviourBuffer*)previous;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [previous @ X2 (Fusion.NetworkBehaviourBuffer&)+8]");
						reference = ref *(NetworkBehaviourBuffer*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1107 @ X8_v38+18] (should have been resolved before IL gen)");
						networkBehaviour = b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X9_v19-8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X20_v9+28]");
						reference2 = ref *(NetworkBehaviourBuffer*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1071 @ X20_v9+18] (should have been resolved before IL gen)");
						networkBehaviour = b;
					}
					obj35++;
					obj34 += 32;
					if (!System.Runtime.CompilerServices.Unsafe.AreSame(ref System.Runtime.CompilerServices.Unsafe.As<NetworkBehaviourBuffer, byte>(ref reference5), ref *(byte*)obj35))
					{
						continue;
					}
				}
				goto IL_0b91;
			}
			goto IL_0cf7;
			IL_0be9:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			goto IL_0cf7;
			IL_0c73:
			if (networkBehaviourBuffer == (NetworkBehaviourBuffer)(object)0 || _sourceTick == tick)
			{
				goto IL_0c90;
			}
			num2 = num;
			num4 = num3;
			flag2 = false;
			reference = ref *(NetworkBehaviourBuffer*)(&alpha);
			reference2 = ref to;
			networkBehaviour = (NetworkBehaviour)(&from);
			goto IL_0cbc;
			IL_01a7:
			num = num2;
			num3 = num4;
			Tick tick3 = default;
			tick = tick3;
			networkBehaviourBuffer = from;
			goto IL_0c73;
			IL_0c90:
			ref NetworkBehaviourBuffer reference10 = ref *(NetworkBehaviourBuffer*)null;
			_ = 0;
			reference9 = ref *(NetworkBehaviourBuffer*)null;
			_ = 0;
			return (Enumerable)0;
			IL_0cf7:
			throw new NullReferenceException();
			IL_0b91:
			int[] words4 = _words;
			if (_words != null)
			{
				reference10 = ref *(NetworkBehaviourBuffer*)networkBehaviourBuffer;
				_ = words4.Length;
				_ = _sourceTick;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				return (Enumerable)_changed;
			}
			goto IL_0cf7;
			IL_04e9:
			if (ptr != null)
			{
				object obj40 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) >> 30;
				bool flag22 = (object)networkBehaviour8 == null;
				object obj41 = !flag22;
				bool flag23 = (int)(~obj41) == 0 && obj40 == null;
				flag20 = flag23;
			}
			else
			{
				flag20 = false;
			}
			goto IL_0d71;
		}

		static ChangeDetector()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I
			//IL_0031: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I
			//IL_006d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A70]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5860]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5B08]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, System.__Canon> dictionary = default;
			dictionary._002Ector();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
			object obj5 = 0;
			obj5 = dictionary;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<System.__Canon, bool> dictionary2 = default;
			dictionary2._002Ector();
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
			object obj8 = (nint)0 + (nint)8;
			obj8 = dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct ArrayInitializer<T>
	{
		public static implicit operator NetworkArray<T>(ArrayInitializer<T> arr)
		{
			//IL_0043: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NotImplementedException ex = default;
			string message = default;
			ex._002Ector(message);
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkArray<T>)ex2;
		}

		public static implicit operator NetworkLinkedList<T>(ArrayInitializer<T> arr)
		{
			//IL_0043: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NotImplementedException ex = default;
			string message = default;
			ex._002Ector(message);
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkLinkedList<T>)ex2;
		}
	}

	public static bool InvokeRpc;

	[MethodImpl((MethodImplOptions)256)]
	internal static bool ShouldNotifyRpcError(RpcInvokeInfo invokeInfo)
	{
		//IL_000e: Expected Obj, but got VT
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		object obj = invokeInfo >> 32;
		object obj2 = obj - 522;
		bool flag = (nint)obj2 < 2;
		object obj3 = !flag;
		object obj4 = ~obj3;
		bool result = true;
		if (obj4 == null)
		{
			bool flag2 = (nint)obj == 518;
			result = true;
			if (!flag2)
			{
				if ((nint)obj == 524)
				{
					object obj5 = invokeInfo - 1;
					bool flag3 = obj5 == null;
					object obj6 = !flag3;
					object obj7 = ~obj6;
					bool flag4;
					if (obj7 == null)
					{
						object obj8 = invokeInfo - 4;
						flag4 = obj8 == null;
					}
					else
					{
						flag4 = true;
					}
					result = flag4;
				}
				else
				{
					result = false;
				}
			}
		}
		return result;
	}

	internal static void NotifyRpcError(ILogSource context, string rpc, RpcInvokeInfo invokeInfo, PlayerRef targetPlayer)
	{
		//IL_000e: Expected Obj, but got VT
		//IL_029e: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_03f2: Expected Obj, but got I
		//IL_015c: Invalid comparison between VT and I4
		//IL_026f: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0179: Invalid comparison between VT and I4
		//IL_036d: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		object obj = invokeInfo >> 32;
		object obj12 = default;
		object format2 = default;
		object obj7;
		string text2;
		object obj8;
		if ((nint)obj <= 522)
		{
			if ((nint)obj != 518)
			{
				if ((nint)obj == 522)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v40+A0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+18]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C40]");
						object format = 0;
						object arg = default;
						string text = string.Format((string)format, rpc, arg);
						obj7 = obj5;
						text2 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v41+18]");
						obj8 = 0;
						goto IL_03aa;
					}
					return;
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v32+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v33+18]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v33+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C60]");
			format2 = 0;
		}
		else
		{
			object obj21;
			object obj22;
			if ((nint)obj != 523)
			{
				if ((nint)obj != 524)
				{
					return;
				}
				if (invokeInfo == (RpcInvokeInfo)(object)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj14 = 0;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v18+A0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+10]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C58]");
						format2 = 0;
						goto IL_03fc;
					}
					return;
				}
				if (invokeInfo != (RpcInvokeInfo)(object)4)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj18 = 0;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v26+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v27+18]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v27+18]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C50]");
				obj22 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj23 = 0;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+A0]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+18]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+18]");
				if ((nint)0 == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C48]");
				obj22 = 0;
			}
			string text3 = rpc + (string)obj22;
			object obj26 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v9+188]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v9+190]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v223 @ X4_v1 (should have been resolved before IL gen)");
		}
		goto IL_03fc;
		IL_03fc:
		object arg2 = default;
		string text4 = string.Format((string)format2, rpc, arg2);
		obj7 = obj12;
		text2 = text4;
		obj8 = obj12;
		goto IL_03aa;
		IL_03aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X8_v6+188] (should have been resolved before IL gen)");
	}

	internal static bool CheckInvokeRpc(NetworkBehaviour behaviour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0044: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
		ThrowIfBehaviourNotInitialized(behaviour);
		return (byte)(int)obj3 != 0;
	}

	internal static bool CheckInvokeRpc(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		//IL_0044: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
		ThrowIfRunnerNotSet(runner);
		return (byte)(int)obj3 != 0;
	}

	internal static void ResetStatics()
	{
		//IL_0010: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
		object obj3 = 0;
		obj3 = 0;
	}

	public unsafe static int[] GetCustomSharedModeReadOnlyOffsets(Type type, int baseOffset = default(int))
	{
		//IL_086e: Expected Obj, but got I
		//IL_0898: Expected Obj, but got I4
		//IL_06cc: Expected Obj, but got I
		//IL_06ef: Expected VT, but got I4
		//IL_06f8: Expected VT, but got I4
		//IL_0700: Expected Obj, but got I4
		//IL_0049: Expected VT, but got I4
		//IL_0509: Expected Obj, but got I
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0541: Expected Obj, but got I4
		//IL_0795: Expected Obj, but got I
		//IL_07b7: Expected Obj, but got I4
		//IL_008a: Expected VT, but got I4
		//IL_0093: Expected VT, but got I4
		//IL_08b6: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I
		//IL_0590: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_0101: Expected VT, but got I4
		//IL_010a: Expected VT, but got I4
		//IL_0146: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_071e: Expected I4, but got Obj
		//IL_03cb: Expected VT, but got I4
		//IL_03d4: Expected Obj, but got I4
		//IL_03fc: Expected VT, but got Ref
		//IL_0405: Expected Obj, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I
		//IL_0836: Expected Ref, but got VT
		//IL_0850: Expected Obj, but got I4
		//IL_0413: Invalid comparison between VT and I4
		//IL_0424: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got VT
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected I4, but got Unknown
		//IL_0762: Expected Obj, but got I4
		//IL_076a: Expected Obj, but got I4
		//IL_0772: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I
		//IL_0285: Invalid comparison between VT and I4
		//IL_064d: Expected VT, but got I4
		//IL_0656: Expected Obj, but got I4
		//IL_0471: Expected Obj, but got I4
		//IL_0479: Expected Obj, but got VT
		//IL_06ad: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I4
		//IL_05c5: Expected VT, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_05f6: Expected VT, but got Ref
		//IL_02a9: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_037c: Expected I4, but got Obj
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0310: Expected Obj, but got I
		//IL_0322: Expected I4, but got Obj
		//IL_032a: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		SimulationBehaviourMeta simulationBehaviourMeta2 = default;
		SimulationBehaviourMeta simulationBehaviourMeta = simulationBehaviourMeta2;
		Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator enumerator = (Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator)0;
		SimulationBehaviourMeta simulationBehaviourMeta3 = (SimulationBehaviourMeta)0;
		Type type2 = (Type)baseOffset;
		Type type3 = type;
		int[] result2;
		if (!flag2)
		{
			bool flag3 = ((NetworkTypesMeta)obj4).TryGetBehaviourMeta(type, out SimulationBehaviourMeta meta);
			bool flag4 = !flag3;
			simulationBehaviourMeta3 = (SimulationBehaviourMeta)0;
			type2 = type;
			nint num = (nint)(&meta);
			if (flag4)
			{
				goto IL_04f9;
			}
			Dictionary<System.__Canon, NetworkPropertyMeta> dictionary = default;
			bool flag5 = dictionary == null;
			simulationBehaviourMeta = simulationBehaviourMeta2;
			enumerator = (Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator)0;
			simulationBehaviourMeta3 = (SimulationBehaviourMeta)0;
			type2 = type;
			num = (nint)(&meta);
			type3 = type;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CA0]");
				object obj5 = 0;
				type2 = (Type)obj5;
				ValueCollection<> values = dictionary.Values;
				bool flag6 = values == null;
				simulationBehaviourMeta = simulationBehaviourMeta2;
				enumerator = (Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator)0;
				simulationBehaviourMeta3 = (SimulationBehaviourMeta)0;
				num = (nint)(&meta);
				type3 = type;
				if (!flag6)
				{
					Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator enumerator2 = (Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator)values.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CB0]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
					object obj9 = 0;
					num = (nint)(&meta);
					type3 = null;
					object obj11 = default;
					object obj12 = default;
					SimulationBehaviourMeta simulationBehaviourMeta5 = default;
					Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator enumerator3 = default;
					SimulationBehaviourMeta simulationBehaviourMeta7 = default;
					object obj21;
					SimulationBehaviourMeta simulationBehaviourMeta4;
					SimulationBehaviourMeta simulationBehaviourMeta6;
					Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator enumerator4;
					while (true)
					{
						int num2 = (int)obj6;
						bool flag7 = enumerator.MoveNext();
						if (!flag7)
						{
							break;
						}
						object obj10 = obj11 & 1;
						if (obj10 == null)
						{
							continue;
						}
						bool flag8 = (nint)obj12 < 1;
						object obj13 = obj12;
						if (flag8)
						{
							continue;
						}
						int num3 = simulationBehaviourMeta2 + baseOffset;
						obj13 = obj12;
						while (true)
						{
							bool flag9 = (object)type3 == null;
							object obj14 = !flag9;
							Type type4 = (Type)num2;
							List<int> list = (List<int>)flag7;
							Type type5;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								type4 = (Type)obj8;
								list._002Ector();
								bool flag10 = list == null;
								type3 = (Type)(object)list;
								type2 = (Type)obj8;
								type5 = (Type)(object)list;
								if (flag10)
								{
									goto IL_05b3;
								}
							}
							RuntimeTypeHandle impl = type3._impl;
							object obj15 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X20_v16 (System.Type)+1C]");
							object obj16 = (nint)0 + (nint)1;
							if (type3._impl != (RuntimeTypeHandle)(object)0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X20_v16 (System.Type)+18]");
								obj16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X20_v16 (System.Type)+18]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v40 (System.RuntimeTypeHandle)+18]");
								bool flag11 = num4 < 0;
								object obj17 = !flag11;
								if (obj17 == null)
								{
									RuntimeTypeHandle impl2 = type3._impl;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X20_v16 (System.Type)+18]");
									object obj18 = impl2 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X20_v16 (System.Type)+18]");
									obj15 = (nint)0 + (nint)1;
									num2 = (int)type4;
									flag7 = (byte)(int)list != 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X9_v12+20]");
									object obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v42+A8]");
									object obj20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v43+70]");
									num = 0;
									((List<int>)(object)type3).AddWithResize(num3);
									num2 = num3;
									flag7 = (byte)(int)type3 != 0;
								}
								obj13--;
								num3++;
								if ((nint)obj13 == 1)
								{
									break;
								}
								continue;
							}
							NullReferenceException ex = new NullReferenceException();
							type2 = type4;
							type5 = type3;
							goto IL_05b3;
							IL_05b3:
							NullReferenceException ex2 = new NullReferenceException();
							simulationBehaviourMeta = (SimulationBehaviourMeta)0;
							obj21 = 0;
							simulationBehaviourMeta4 = simulationBehaviourMeta5;
							enumerator = enumerator3;
							simulationBehaviourMeta6 = simulationBehaviourMeta2;
							simulationBehaviourMeta3 = simulationBehaviourMeta7;
							enumerator4 = (Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator)(&enumerator);
							type3 = type5;
							goto IL_0603;
						}
					}
					simulationBehaviourMeta = (SimulationBehaviourMeta)0;
					obj21 = 0;
					simulationBehaviourMeta4 = simulationBehaviourMeta5;
					enumerator = enumerator3;
					simulationBehaviourMeta6 = simulationBehaviourMeta2;
					simulationBehaviourMeta3 = simulationBehaviourMeta7;
					enumerator4 = (Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator)(&enumerator);
					object obj22 = 10;
					object obj27 = default;
					int[] result = default;
					while (true)
					{
						object obj23 = obj21;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CA8]");
							object obj24 = 0;
							type2 = (Type)obj24;
							((Dictionary<System.__Canon, NetworkPropertyMeta>.Enumerator*)enumerator4)->Dispose();
							bool flag12 = obj23 == null;
							object obj25 = !flag12;
							if (obj25 == null)
							{
								bool flag13 = simulationBehaviourMeta == (SimulationBehaviourMeta)(object)0;
								object obj26 = !flag13;
								OutOfMemoryException ex3 = (OutOfMemoryException)enumerator4;
								if (obj26 == null)
								{
									break;
								}
							}
							else
							{
								OutOfMemoryException ex3 = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							if ((nint)type2 != 2)
							{
								if ((nint)type2 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
									obj23 = obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
									obj21 = obj27;
									obj22 = 0;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A43A4");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result;
							}
							goto IL_062b;
						}
						break;
						IL_062b:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						simulationBehaviourMeta = (SimulationBehaviourMeta)1;
						obj22 = 0;
					}
					if ((nint)obj22 != 10)
					{
						bool flag14 = obj22 == null;
						object obj28 = !flag14;
						result2 = (int[])enumerator4;
						if (obj28 != null)
						{
							goto IL_0780;
						}
					}
					if ((object)type3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73C8]");
						object obj29 = 0;
						type2 = (Type)obj29;
						int[] array = ((List<int>)(object)type3).ToArray();
						bool flag15 = array == null;
						object obj30 = !flag15;
						result2 = array;
						if (obj30 != null)
						{
							goto IL_0780;
						}
					}
					goto IL_04f9;
				}
			}
		}
		goto IL_0603;
		IL_0603:
		throw new NullReferenceException();
		IL_04f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C98]");
		object obj31 = 0;
		object obj32 = obj31;
		object obj33 = obj31 + 56;
		object obj34 = obj33;
		bool flag16 = obj33 == null;
		object obj35 = !flag16;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X19_v12+38]");
			obj34 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v23+10]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v33+E4]");
		bool flag17 = (nint)0 == 0;
		object obj37 = !flag17;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj38 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v27+10]");
			obj36 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v33+A0]");
		object obj39 = 0;
		result2 = (int[])obj39;
		goto IL_0780;
		IL_0780:
		return result2;
	}

	public static int GetWordCount(NetworkBehaviour behaviour)
	{
		//IL_0159: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		if ((object)behaviour != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CE0]");
			object obj = 0;
			nint num = (nint)behaviour;
			((object)behaviour).Finalize();
			int? num2 = default;
			object obj2 = (_003F?)num2 & 0xFF;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CE8]");
				object format = 0;
				int? num3 = default;
				int value = num3.Value;
				int value2 = num3.Value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
				int num4 = ~value;
				int condition = num4 >> 31;
				DumpDeferredClass arg = default;
				Assert.Always((byte)condition != 0, (string)format, value2, arg);
				return num3.Value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
			Type type = default;
			int staticWordCount = GetStaticWordCount(type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3697584");
			int num5 = ~staticWordCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CF0]");
			object format2 = 0;
			int condition2 = num5 >> 31;
			DumpDeferredClass arg2 = default;
			Assert.Always((byte)condition2 != 0, (string)format2, staticWordCount, arg2);
			return staticWordCount;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static bool HasStaticWordCount(Type type)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I4
		//IL_002d: Expected VT, but got Obj
		//IL_0183: Expected I4, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected I4, but got Unknown
		//IL_01e3: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5848]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
		if ((object)typeFromHandle != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5D18]");
			object error = 0;
			Type elementType = ((System.RuntimeType)typeFromHandle).GetElementType();
			bool condition = (byte)(elementType & 1) != 0;
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v12+A0]");
			object obj8 = 0;
			if (obj8 != null)
			{
				if (((NetworkTypesMeta)obj8).TryGetBehaviourMeta(type, out SimulationBehaviourMeta _))
				{
					object obj10 = default;
					object obj9 = obj10 & 0xFF;
					bool flag3 = obj9 == null;
					object obj11 = !flag3;
					object obj12 = ~obj11;
					bool flag4;
					bool flag5;
					if (obj12 == null)
					{
						flag4 = (nint)obj10 < 0;
						object obj13 = obj10 ^ obj10;
						object obj14 = obj10 & obj13;
						flag5 = (nint)obj14 < 0;
					}
					else
					{
						flag5 = false;
						flag4 = true;
					}
					return flag4 == flag5;
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe static int GetStaticWordCount(Type type)
	{
		//IL_01d1: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I
		//IL_009e: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0087: Expected I4, but got Obj
		//IL_01a7: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5CC8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+A0]");
		object obj4 = 0;
		string message;
		if (((NetworkTypesMeta)obj4).TryGetBehaviourMeta(type, out SimulationBehaviourMeta _))
		{
			object obj6 = default;
			object obj5 = obj6 & 0xFF;
			if (obj5 != null)
			{
				return obj6 >> 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			string format = default;
			message = string.Format(format, type);
			object obj7 = type;
			object obj8 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			nint num = (nint)type;
			int genericParameterPosition = ((System.RuntimeType)type).GenericParameterPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			int value = ((int*)genericParameterPosition)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X8_v9 (System.Int32)+2A8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v23+10]");
			string format2 = default;
			object arg = default;
			message = string.Format(format2, type, 0, arg);
			object obj7 = type;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v23+10]");
			object obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (int)ex2;
	}

	public static void ThrowIfBehaviourNotInitialized(NetworkBehaviour behaviour)
	{
		//IL_013f: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		InvalidOperationException ex;
		if ((object)behaviour != null)
		{
			NetworkObject networkObject = ((SimulationBehaviour)behaviour)._object;
			object obj6;
			if ((object)((SimulationBehaviour)behaviour)._object != null)
			{
				object obj = networkObject.RuntimeFlags & (NetworkObjectRuntimeFlags)2;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v25+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((bool)((SimulationBehaviour)behaviour)._runner)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C78]");
					obj6 = 0;
					InvalidOperationException ex2 = default;
					ex = ex2;
					goto IL_01e0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5C68]");
			obj6 = 0;
			InvalidOperationException ex3 = default;
			ex = ex3;
			goto IL_01e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex4 = default;
		string text = default;
		ex4._002Ector(text);
		object obj7 = 0;
		string text2 = text;
		goto IL_0182;
		IL_0182:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text3 = default;
		ex._002Ector(text3);
		obj7 = 0;
		text2 = text3;
		goto IL_0182;
	}

	public static void ThrowIfRunnerNotSet(NetworkRunner runner)
	{
		if ((object)runner != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex = default;
		string paramName = default;
		ex._002Ector(paramName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
	}

	public unsafe static void NotifyNetworkWrapFailed<T>(T value)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0149: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got Ref
		//IL_018e: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00b6: Expected VT, but got Ref
		//IL_00cf: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v1 (Il2CppClass<T>)+FC]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v1 (Il2CppClass<T>)+FC]");
		object obj4 = (nint)0 + (nint)15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default;
		object obj6 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v7+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v1 (Il2CppClass<T>)+28]");
			bool flag = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v1 (Il2CppClass<T>)+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v1 (Il2CppClass<T>)+28]");
			object obj12 = num2 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v1 (Il2CppClass<T>)+28]");
			object obj13 = 0 & obj12;
			bool flag2 = (nint)obj13 < 0;
			T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
			bool flag3 = flag == flag2;
			object obj14 = !flag3;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				T val2 = value;
			}
			else
			{
				T val2 = val;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8098]");
			object format = 0;
			object arg = default;
			string text = string.Format((string)format, arg);
			object obj16 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v16+1A0]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X8_v16+198] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X29_v1-8]");
		if (num3 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public unsafe static void NotifyNetworkWrapFailed<T>(T value, Type wrapperType)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0149: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got Ref
		//IL_018e: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00b6: Expected VT, but got Ref
		//IL_00cf: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v1 (Il2CppClass<T>)+FC]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v1 (Il2CppClass<T>)+FC]");
		object obj4 = (nint)0 + (nint)15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default;
		object obj6 = (ref *(byte*)(&obj7)) - (ref *(byte*)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v1 (Il2CppClass<T>)+28]");
			bool flag = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v1 (Il2CppClass<T>)+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v1 (Il2CppClass<T>)+28]");
			object obj12 = num2 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v1 (Il2CppClass<T>)+28]");
			object obj13 = 0 & obj12;
			bool flag2 = (nint)obj13 < 0;
			T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
			bool flag3 = flag == flag2;
			object obj14 = !flag3;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
				T val2 = value;
			}
			else
			{
				T val2 = val;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F80A0]");
			object format = 0;
			object arg = default;
			Type arg2 = default;
			string text = string.Format((string)format, arg, arg2);
			object obj16 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v16+1A0]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ X8_v16+198] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ SYSREG+28]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-8]");
		if (num3 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public static void NotifyNetworkUnwrapFailed(NetworkBehaviourId id)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A28]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5A20]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			string text = string.Format((string)format, arg, arg2);
			string text2 = text + (string)obj7;
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ X8_v9+198] (should have been resolved before IL gen)");
		}
	}

	public unsafe static void InitializeNetworkArray<T>(NetworkArray<T> networkArray, T[] sourceArray, string name) where T : struct
	{
		//IL_018a: Expected Ref, but got VT
		//IL_0098: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		if (sourceArray == null)
		{
			return;
		}
		int sourceCount = sourceArray.Length;
		if (sourceArray.Length == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkArray @ X0 (Fusion.NetworkArray`1<T>)+8]");
		if ((nint)0 < (nint)sourceArray.Length)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X9_v5+A0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v6+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v6+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8088]");
				object format = 0;
				object arg = default;
				object arg2 = default;
				string text = string.Format((string)format, name, arg, arg2);
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X8_v10+198] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkArray @ X0 (Fusion.NetworkArray`1<T>)+8]");
				sourceCount = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkArray @ X0 (Fusion.NetworkArray`1<T>)+8]");
				sourceCount = 0;
			}
		}
		((NetworkArray<T>*)networkArray)->CopyFrom(sourceArray, 0, sourceCount);
	}

	public unsafe static void CopyFromNetworkArray<T>(NetworkArray<T> networkArray, ref T[] dstArray) where T : struct
	{
		//IL_0076: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_010c: Expected Ref, but got VT
		T[] array = dstArray;
		object obj2;
		if (dstArray != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
			object obj = 0;
			int? num = array.Length;
			obj2 = 0;
		}
		else
		{
			obj2 = 0;
		}
		object obj3 = obj2 & 0xFF;
		if (obj3 != null)
		{
			object obj4 = obj2 >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [networkArray @ X0 (Fusion.NetworkArray`1<T>)+8]");
			if (0 == (nint)obj4)
			{
				goto IL_00f9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj5 = default;
		ref T[] reference = ref *(T[]*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_00f9;
		IL_00f9:
		((NetworkArray<T>*)networkArray)->CopyTo(dstArray, throwIfOverflow: true);
	}

	public static T[] CloneArray<T>(T[] array)
	{
		//IL_0089: Expected Obj, but got I
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Array array2 = default;
			Array.Copy(array, array2, array.Length);
			return (T[])array2;
		}
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v42 @ X1_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public unsafe static void InitializeNetworkList<T>(NetworkLinkedList<T> networkList, T[] sourceArray, string name) where T : struct
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_03ba: Expected Obj, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got Ref
		//IL_0307: Expected Obj, but got VT
		//IL_0055: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I
		//IL_0210: Expected Obj, but got VT
		//IL_0219: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got Ref
		//IL_0138: Expected Obj, but got I
		//IL_0155: Expected Obj, but got Ref
		//IL_0165: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I4
		//IL_01d7: Expected I, but got Obj
		//IL_0226: Expected I, but got Obj
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got VT
		//IL_02aa: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got VT
		//IL_02c8: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got VT
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		bool flag = sourceArray == null;
		T[] array = sourceArray;
		IndexOutOfRangeException ex;
		if (!flag)
		{
			object obj7 = sourceArray.Length;
			bool flag2 = sourceArray.Length == 0;
			array = sourceArray;
			if (!flag2)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ X1_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				object obj8 = default;
				object obj19 = default;
				string text2 = default;
				nint num4 = default;
				if ((nint)obj8 < sourceArray.Length)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v20+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v21+18]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v21+18]");
					if ((nint)0 != 0)
					{
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ X1_v11 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
						object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 20));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj16 = 0;
						_ = sourceArray.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8088]");
						object format = 0;
						object arg = default;
						object obj17 = default;
						string text = string.Format((string)format, text2, arg, obj17);
						object obj18 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v35+1A0]");
						text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v302 @ X8_v35+198] (should have been resolved before IL gen)");
						obj19 = 0;
						num4 = (nint)obj17;
					}
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X1_v10 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					object obj20 = default;
					obj7 = obj20;
				}
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X1_v5 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				bool flag3 = (nint)obj7 < 1;
				array = (T[])0;
				if (!flag3)
				{
					object obj21 = sourceArray + 32;
					object obj22 = obj19;
					string text3 = text2;
					nint num7 = num4;
					T[] array2 = (T[])0;
					ex = (IndexOutOfRangeException)networkList;
					object obj23 = 0;
					while (true)
					{
						bool flag4 = (nint)obj23 < sourceArray.Length;
						object obj24 = !flag4;
						if (obj24 != null)
						{
							break;
						}
						nint num8 = (nint)sourceArray;
						object obj25 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v14 (Il2CppClass<T[]>)+104]");
						object obj26 = obj25 * 0;
						object obj27 = obj21 + obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
						num4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X1_v8 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
						obj23++;
						bool flag5 = obj7 != obj23;
						obj19 = obj5;
						text2 = (string)networkList;
						array = (T[])0;
						obj22 = obj5;
						text3 = (string)networkList;
						num7 = num4;
						array2 = (T[])0;
						ex = (IndexOutOfRangeException)networkList;
						if (flag5)
						{
							continue;
						}
						goto IL_02de;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					bool flag6 = num10 != 0;
					obj19 = obj22;
					text2 = text3;
					num4 = num7;
					array = array2;
					if (!flag6)
					{
						ex = new IndexOutOfRangeException();
						obj19 = obj22;
						text2 = text3;
						num4 = num7;
						array = array2;
					}
					goto IL_0393;
				}
			}
		}
		goto IL_02de;
		IL_0393:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_02de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ SYSREG+28]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag7 = num11 != 0;
		ex = (IndexOutOfRangeException)networkList;
		if (!flag7)
		{
			return;
		}
		goto IL_0393;
	}

	public unsafe static void CopyFromNetworkList<T>(NetworkLinkedList<T> networkList, ref T[] dstArray) where T : struct
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0627: Expected Obj, but got I
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_0646: Expected Obj, but got Ref
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_0041: Expected VT, but got Ref
		//IL_0051: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_0069: Expected native int or pointer, but got VT
		//IL_007e: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_017a: Expected Obj, but got Ref
		//IL_0188: Expected Obj, but got Ref
		//IL_01c5: Expected Obj, but got I8
		//IL_06d1: Expected Obj, but got I
		//IL_06e1: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got Ref
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Obj, but got Unknown
		//IL_03c1: Expected Obj, but got I4
		//IL_0744: Expected Obj, but got I
		//IL_0754: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I
		//IL_077c: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I4
		//IL_01da: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_020d: Expected Obj, but got Ref
		//IL_021b: Expected Obj, but got Ref
		//IL_03e8: Expected Obj, but got I4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got I4
		//IL_02c5: Expected I, but got Obj
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_0357: Expected I, but got Obj
		//IL_0367: Expected Obj, but got I
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0399: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got Ref
		//IL_0592: Expected Obj, but got I
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj6 = default;
		object obj5 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		nint num2 = (ref *(byte*)(&obj6)) - (ref *(byte*)obj4);
		T[] array = dstArray;
		_ = 0;
		_ = 0;
		T[] array2;
		if (dstArray != null)
		{
			int? num3 = (int?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
			object obj7 = 0;
			_ = 0;
			nint num4 = (nint)obj7;
			*(int?*)(nint)num3 = array.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-60]");
			array2 = (T[])0;
		}
		else
		{
			array2 = null;
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X1_v2 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj8 = array2 & 0xFF;
		if (obj8 != null)
		{
			object obj9 = (object)array2 >> 32;
			object obj10 = default;
			if (obj10 == obj9)
			{
				goto IL_0132;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v43+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v44+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X1_v19] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v46+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = default;
		ref T[] reference = ref *(T[]*)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_0132;
		IL_0132:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v7+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+28]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ X1_v4] (should have been resolved before IL gen)");
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
		object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-50]");
		_ = 0;
		_ = 0;
		object obj22 = 4294967295L;
		object obj28 = default;
		object obj53 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v12+38]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v13+50]");
			object obj25 = 0;
			object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X1_v6] (should have been resolved before IL gen)");
			object obj27 = obj28 & 1;
			object obj34;
			IndexOutOfRangeException ex;
			if (obj27 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v28+38]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v29+38]");
				object obj31 = 0;
				object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
				object obj33 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X1_v12+10] (should have been resolved before IL gen)");
				array2 = dstArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				bool flag = dstArray == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v1 (Il2CppClass<T>)+FC]");
				nint num4 = 0;
				obj34 = obj5;
				object obj45;
				if (!flag)
				{
					object obj35 = obj22 + 1;
					bool flag2 = (nint)obj35 < array2.Length;
					object obj36 = !flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v1 (Il2CppClass<T>)+FC]");
					num4 = 0;
					obj34 = obj5;
					if (obj36 == null)
					{
						nint num6 = (nint)array2;
						object obj37 = dstArray + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X9_v21 (Il2CppClass<T[]>)+104]");
						object obj38 = 0 * obj35;
						object obj39 = obj37 + obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
						obj22++;
						bool flag3 = (nint)obj22 < array2.Length;
						object obj40 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v1 (Il2CppClass<T>)+FC]");
						num4 = 0;
						obj34 = obj5;
						if (obj40 == null)
						{
							nint num7 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-18]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v38 (Il2CppClass<T[]>)+104]");
							object obj42 = 0 * obj35;
							object obj43 = obj37 + obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v22+38]");
							object obj44 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E0C");
							obj45 = obj5;
							num4 = num2;
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
					bool flag4 = num8 != 0;
					obj45 = obj5;
					if (flag4)
					{
						break;
					}
					ex = new IndexOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
				bool flag5 = num9 != 0;
				obj45 = obj5;
				if (flag5)
				{
					break;
				}
				NullReferenceException ex2 = new NullReferenceException();
				obj45 = obj5;
				ex = (IndexOutOfRangeException)(object)ex2;
				goto IL_04c0;
			}
			object obj46 = 0;
			goto IL_0734;
			IL_0734:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-60]");
			ex = (IndexOutOfRangeException)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-58]");
			object obj47 = 0;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v17+38]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v18+58]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B38064");
			bool flag6 = obj46 == null;
			object obj50 = !flag6;
			if (obj50 != null)
			{
				goto IL_04c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-48]");
			bool flag7 = (nint)0 == 0;
			object obj51 = !flag7;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
				if (num10 != 0)
				{
					break;
				}
				return;
			}
			goto IL_0505;
			IL_04c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			if (num11 != 0)
			{
				break;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex = (IndexOutOfRangeException)(object)ex3;
			goto IL_0505;
			IL_0505:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
			if (num12 != 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj34 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-50]");
				obj46 = 0;
			}
			else
			{
				if ((nint)obj34 != 1)
				{
					object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B9808");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ SYSREG+28]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X29_v1-8]");
					if (num13 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					}
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj46 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			}
			goto IL_0734;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	[MethodImpl((MethodImplOptions)256)]
	public static void InternalOnDestroy(SimulationBehaviour obj)
	{
		SimulationBehaviourRuntimeFlags flags = obj.Flags | (SimulationBehaviourRuntimeFlags)8;
		obj.Flags = flags;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static void InternalOnEnable(SimulationBehaviour obj)
	{
		//IL_0017: Expected I4, but got I8
		SimulationBehaviourRuntimeFlags flags = (SimulationBehaviourRuntimeFlags)((long)obj.Flags & 0xFFFFFFEFL);
		obj.Flags = flags;
	}

	[MethodImpl((MethodImplOptions)256)]
	public static void InternalOnDisable(SimulationBehaviour obj)
	{
		SimulationBehaviourRuntimeFlags flags = obj.Flags | (SimulationBehaviourRuntimeFlags)0x10;
		obj.Flags = flags;
	}

	public unsafe static void InitializeNetworkDictionary<D, K, V>(NetworkDictionary<K, V> networkDictionary, D dictionary, string name) where D : IDictionary<K, V> where K : struct where V : struct
	{
		//IL_0022: Invalid comparison between VT and I4
		//IL_0042: Expected Obj, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		//IL_07a8: Expected I, but got VT
		//IL_07b8: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_0141: Expected Ref, but got VT
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0832: Expected Ref, but got VT
		//IL_083e: Expected Obj, but got I
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_0866: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_089c: Expected I, but got VT
		//IL_08ac: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I
		//IL_0883: Expected Ref, but got VT
		//IL_0906: Expected VT, but got I
		//IL_0920: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_01d2: Expected Ref, but got VT
		//IL_01e6: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_033e: Expected Obj, but got I
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_05aa: Invalid comparison between VT and I4
		//IL_05f6: Invalid comparison between VT and I4
		//IL_095a: Expected VT, but got I
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_098f: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_0647: Expected Obj, but got Ref
		//IL_063a: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_0aab: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0684: Expected Obj, but got I
		//IL_0694: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_075e: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_0aed: Expected VT, but got I
		//IL_06cf: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0a0e: Expected VT, but got I
		//IL_0a43: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected Obj, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected VT, but got Unknown
		//IL_0576: Expected VT, but got Obj
		//IL_0576: Expected Ref, but got VT
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got Unknown
		if (dictionary == (D)(object)0)
		{
			return;
		}
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num = intPtr;
		}
		nint num2 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7 (Il2CppClass<D>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7 (Il2CppClass<D>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v7 (Il2CppClass<D>)+98]");
		object obj5 = (nint)0 + (nint)8;
		object obj6;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v37-8]");
			if (0 == num)
			{
				break;
			}
			obj4--;
			obj6 = obj5 + 16;
			bool flag2 = (nint)obj4 != 1;
			obj5 = obj6;
			if (flag2)
			{
				continue;
			}
			goto IL_00f4;
		}
		object obj7 = num2 + obj5;
		object obj8 = obj7 + 312;
		string text = name;
		obj6 = obj5;
		goto IL_0802;
		IL_0802:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v291 @ X0_v4] (should have been resolved before IL gen)");
		int num3 = default;
		if (num3 == 0)
		{
			return;
		}
		int capacity = ((NetworkDictionary<K, V>*)networkDictionary)->Capacity;
		bool flag3 = num3 <= capacity;
		int num4 = num3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj9 = 0;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v49+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v50+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v50+18]");
			if ((nint)0 != 0)
			{
				int capacity2 = ((NetworkDictionary<K, V>*)networkDictionary)->Capacity;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8090]");
				object format = 0;
				object arg = default;
				object obj14 = default;
				string text2 = string.Format((string)format, name, arg, obj14);
				object obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v58+1A0]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X8_v58+198] (should have been resolved before IL gen)");
				nint num5 = (nint)obj14;
			}
			int capacity3 = ((NetworkDictionary<K, V>*)networkDictionary)->Capacity;
			num4 = capacity3;
		}
		((NetworkDictionary<K, V>*)networkDictionary)->Clear();
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag4 = obj17 == null;
		object obj18 = !flag4;
		nint num6 = 0;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr2 = default;
			num6 = intPtr2;
		}
		nint num7 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v16 (Il2CppClass<D>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v16 (Il2CppClass<D>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v16 (Il2CppClass<D>)+98]");
		object obj20 = (nint)0 + (nint)8;
		bool flag5 = flag3;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X10_v32-8]");
			if (0 == num6)
			{
				break;
			}
			obj19--;
			obj6 = obj20 + 16;
			flag3 = (nint)obj19 != 1;
			flag5 = flag3;
			obj20 = obj6;
			if (flag3)
			{
				continue;
			}
			goto IL_02e2;
		}
		object obj21 = num7 + obj20;
		object obj22 = obj21 + 312;
		flag3 = flag5;
		obj6 = obj20;
		goto IL_08f6;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text = null;
		goto IL_08f6;
		IL_08f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v12+8]");
		K val = (K)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ X0_v12] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj23 = 0;
		object obj24 = default;
		NullReferenceException ex5 = default;
		object obj34 = default;
		IntPtr intPtr3 = default;
		object obj43 = default;
		object obj45 = default;
		object obj53 = default;
		while (true)
		{
			if (obj24 != null)
			{
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v34+12E]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v34+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v34+98]");
				object obj27 = (nint)0 + (nint)8;
				bool flag6 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X10_v27-8]");
					if (0 == (nint)obj23)
					{
						break;
					}
					obj26--;
					obj6 = obj27 + 16;
					flag3 = (nint)obj26 != 1;
					flag6 = flag3;
					obj27 = obj6;
					if (flag3)
					{
						continue;
					}
					goto IL_03d2;
				}
				object obj28 = obj25 + obj27;
				object obj29 = obj28 + 312;
				flag3 = flag6;
				obj6 = obj27;
				goto IL_094a;
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0593;
			IL_0a91:
			OutOfMemoryException ex2;
			bool flag7 = ex2 == null;
			object obj30 = !flag7;
			object obj31;
			if (obj30 == null)
			{
				bool flag8 = obj31 == null;
				object obj32 = !flag8;
				OutOfMemoryException ex3 = ex2;
				if (obj32 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			NullReferenceException ex4 = ex5;
			break;
			IL_0710:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text = null;
			goto IL_0add;
			IL_0add:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X0_v28+8]");
			val = (K)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v821 @ X0_v28] (should have been resolved before IL gen)");
			goto IL_0a91;
			IL_0501:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text = null;
			goto IL_09fe;
			IL_03d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			text = null;
			goto IL_094a;
			IL_094a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v43+8]");
			val = (K)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v604 @ X0_v43] (should have been resolved before IL gen)");
			object obj33 = obj34 & 1;
			bool flag9 = obj33 == null;
			ex2 = null;
			obj31 = 0;
			if (flag9)
			{
				goto IL_063f;
			}
			if (obj24 == null)
			{
				goto IL_0593;
			}
			object obj35 = (nint)0 + (nint)309;
			object obj36 = obj35 & 1;
			bool flag10 = obj36 == null;
			object obj37 = !flag10;
			nint num8 = 0;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				num8 = intPtr3;
			}
			object obj38 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v40+12E]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v40+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0501;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v40+98]");
			object obj40 = (nint)0 + (nint)8;
			bool flag11 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X10_v22-8]");
				if (0 == num8)
				{
					break;
				}
				obj39--;
				obj6 = obj40 + 16;
				flag3 = (nint)obj39 != 1;
				flag11 = flag3;
				obj40 = obj6;
				if (flag3)
				{
					continue;
				}
				goto IL_0501;
			}
			object obj41 = obj38 + obj40;
			object obj42 = obj41 + 312;
			flag3 = flag11;
			obj6 = obj40;
			goto IL_09fe;
			IL_09fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X0_v47+8]");
			val = (K)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v836 @ X0_v47] (should have been resolved before IL gen)");
			num4--;
			bool flag12 = num4 < 1;
			ex2 = null;
			obj31 = 0;
			if (!flag12)
			{
				text = (string)(obj43 >> 32);
				val = (K)(obj43 & 0xFFFFFFFFL);
				bool flag13 = ((NetworkDictionary<K, V>*)networkDictionary)->Add(val, (V)text);
				nint num5 = 0;
				continue;
			}
			goto IL_063f;
			IL_063f:
			object obj44 = (object)(&obj45);
			object obj46 = obj44;
			if (obj44 == null)
			{
				goto IL_0a91;
			}
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v27+12E]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v27+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0710;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v27+98]");
			object obj50 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X10_v14-8]");
				if (0 == (nint)obj48)
				{
					break;
				}
				obj49--;
				obj50 += 16;
				if ((nint)obj49 != 1)
				{
					continue;
				}
				goto IL_0710;
			}
			object obj51 = obj47 + obj50;
			object obj52 = obj51 + 312;
			goto IL_0add;
			IL_0593:
			NullReferenceException ex6 = new NullReferenceException();
			if (val == (K)(object)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex2 = null;
				obj31 = 1;
			}
			else
			{
				bool flag14 = val != (K)(object)1;
				ex4 = ex6;
				if (flag14)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex2 = (OutOfMemoryException)obj53;
				obj31 = 0;
			}
			goto IL_063f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_00f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		text = null;
		goto IL_0802;
	}

	public unsafe static void CopyFromNetworkDictionary<D, K, V>(NetworkDictionary<K, V> networkDictionary, ref D dictionary) where D : IDictionary<K, V>, new() where K : struct where V : struct
	{
		//IL_001d: Expected VT, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0508: Expected Ref, but got VT
		//IL_051f: Expected Obj, but got I4
		//IL_047a: Expected I, but got VT
		//IL_048a: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Obj, but got Unknown
		//IL_0096: Expected VT, but got Obj
		//IL_034d: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got Ref
		//IL_05f0: Expected Obj, but got I
		//IL_0600: Expected Obj, but got I
		//IL_0624: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_01dc: Expected I, but got Obj
		//IL_04c7: Expected Obj, but got I
		//IL_03a7: Expected Obj, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_03c0: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I4
		//IL_0386: Expected Obj, but got Ref
		//IL_052c: Expected Obj, but got I
		//IL_053c: Expected Obj, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0416: Expected Obj, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		D val = (D)System.Runtime.CompilerServices.Unsafe.As<D, object>(ref dictionary);
		bool flag3 = default;
		nint num3;
		if (System.Runtime.CompilerServices.Unsafe.As<D, object>(ref dictionary) != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				val = (D)System.Runtime.CompilerServices.Unsafe.As<D, object>(ref dictionary);
				IntPtr intPtr = default;
				num = intPtr;
			}
			nint num2 = (nint)val;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v31 (Il2CppClass<D>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v31 (Il2CppClass<D>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0136;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v31 (Il2CppClass<D>)+98]");
			object obj5 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			object obj7;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v13-8]");
				object obj6 = -num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v13-8]");
				if (0 == num)
				{
					break;
				}
				obj4--;
				obj6 = obj4 - 1;
				bool flag4 = obj6 == null;
				obj7 = obj5 + 16;
				flag3 = (nint)obj4 != 1;
				flag2 = flag3;
				obj5 = obj7;
				if (flag3)
				{
					continue;
				}
				goto IL_0136;
			}
			object obj8 = obj5 + 3;
			object obj9 = num2 + obj8;
			object obj10 = obj9 + 312;
			IntPtr intPtr2 = default;
			num3 = intPtr2;
			flag3 = flag2;
			obj7 = obj5;
			goto IL_04f0;
		}
		System.__Canon _Canon = Activator.CreateInstance<System.__Canon>();
		ref D reference = ref *(D*)_Canon;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_04ff;
		IL_04ff:
		NetworkDictionary<K, V>.Enumerator enumerator = ((NetworkDictionary<K, V>*)networkDictionary)->GetEnumerator();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj11 = 72;
		object obj14 = default;
		object obj21 = default;
		object obj28 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-28_v2+38]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77E18");
			object obj13 = obj14 & 1;
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-28_v2+38]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B77F00");
			nint num4 = (nint)System.Runtime.CompilerServices.Unsafe.As<D, object>(ref dictionary);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ stack_-28_v2+38]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v21+88]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v21+88]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				obj17 = obj21;
			}
			object obj22 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v24+12E]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v24+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v24+98]");
				object obj24 = (nint)0 + (nint)8;
				bool flag6 = flag3;
				object obj7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X10_v7-8]");
					object obj6 = 0 - obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X10_v7-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj23--;
					obj6 = obj23 - 1;
					bool flag4 = obj6 == null;
					obj7 = obj24 + 16;
					flag3 = (nint)obj23 != 1;
					flag6 = flag3;
					obj24 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_02f7;
				}
				object obj25 = obj24 + 5;
				object obj26 = obj22 + obj25;
				object obj27 = obj26 + 312;
				flag3 = flag6;
				obj7 = obj24;
				goto IL_05a1;
			}
			goto IL_02f7;
			IL_05a1:
			obj11 = obj28 >> 32;
			object obj29 = obj28 & 0xFFFFFFFFL;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v429 @ X0_v32] (should have been resolved before IL gen)");
			continue;
			IL_02f7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_05a1;
		}
		object obj30 = 0;
		object obj31 = 0;
		object obj32 = 0;
		object obj34 = default;
		object obj40 = default;
		object obj41 = default;
		while (true)
		{
			object obj33 = (object)(&obj34);
			object obj35 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v12+38]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v13+A0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B78028");
			bool flag7 = obj32 == null;
			object obj38 = !flag7;
			if (obj38 == null)
			{
				bool flag8 = obj30 == null;
				object obj39 = !flag8;
				OutOfMemoryException ex = (OutOfMemoryException)(&obj40);
				if (obj39 == null)
				{
					return;
				}
			}
			else
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				obj30 = 0;
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v19+48]");
				obj37 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)obj37 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj30 = 1;
				obj32 = obj31;
				continue;
			}
			if ((nint)obj37 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			obj32 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj31 = obj41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B9790");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0136:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num3 = 3;
		goto IL_04f0;
		IL_04f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ X0_v46] (should have been resolved before IL gen)");
		goto IL_04ff;
	}

	public static SerializableDictionary<K, V> MakeSerializableDictionary<K, V>(Dictionary<K, V> dictionary) where K : struct where V : struct
	{
		//IL_0022: Expected Obj, but got I
		nint num = 0;
		object obj = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v37 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
