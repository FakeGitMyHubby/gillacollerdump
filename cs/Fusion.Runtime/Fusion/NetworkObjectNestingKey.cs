using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.ClientModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4)]
public struct NetworkObjectNestingKey : _0021_00210, Action<SendAccountRecoveryEmailResult>
{
	internal struct MigrationList : Action<RewardAdActivityResult>, _0021_00210
	{
		private class DebuggerProxy
		{
			public readonly NetworkObjectMeta[] Items;

			public DebuggerProxy(NetworkObjectMeta.AreaOfInterestList list)
			{
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0018: Expected Obj, but got Unknown
				NetworkObjectMeta.AreaOfInterestList areaOfInterestList = default;
				NetworkObjectMeta[] array = areaOfInterestList.ToArray();
				object obj = this + 16;
				obj = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				base._002Ector();
			}
		}

		private int _count;

		public NetworkObjectMeta Head;

		public int Count
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				return _count;
			}
		}

		public NetworkObjectMeta Tail
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0036: Expected Obj, but got I
				NetworkObjectMeta head = Head;
				if (Head != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.NetworkObjectMeta)+C0]");
					return (NetworkObjectMeta)0;
				}
				return null;
			}
		}

		public bool IsEmpty => Head == null;

		public unsafe void AddFirst(NetworkObjectMeta item)
		{
			//IL_0015: Expected Obj, but got Ref
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected Obj, but got Unknown
			//IL_0120: Expected VT, but got Obj
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_0190: Expected Ref, but got VT
			//IL_004c: Expected Obj, but got I
			//IL_014a: Expected Ref, but got VT
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
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj2 = obj;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				ValidateNodeSet((NetworkObjectMeta)0);
				object obj3 = item + 184;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = obj + 192;
				obj4 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				object obj5 = (nint)0 + (nint)184;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = item + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				NetworkObjectMeta networkObjectMeta = (NetworkObjectMeta)0;
			}
			else
			{
				object obj7 = item + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				item._nodeMigration = (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)item;
				object obj6 = item + 184;
				NetworkObjectMeta networkObjectMeta = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Head = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			MigrationList migrationList = default;
			((MigrationList*)migrationList)->ValidateNodeSet(item);
			((MigrationList*)migrationList)->ValidateNodeSet(Head);
		}

		public unsafe void AddLast(NetworkObjectMeta item)
		{
			//IL_0015: Expected Obj, but got Ref
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Expected Obj, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_012e: Expected VT, but got Obj
			//IL_004c: Expected Obj, but got I
			//IL_018c: Expected Ref, but got VT
			//IL_019b: Expected Ref, but got VT
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
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj2 = obj;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				ValidateNodeSet((NetworkObjectMeta)0);
				object obj3 = item + 184;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = obj + 192;
				obj4 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				object obj5 = (nint)0 + (nint)184;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = item + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+C0]");
				NetworkObjectMeta networkObjectMeta = (NetworkObjectMeta)0;
			}
			else
			{
				object obj7 = item + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj8 = item + 184;
				item._nodeMigration = (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj = item;
				object obj6 = obj;
				NetworkObjectMeta networkObjectMeta = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			MigrationList migrationList = default;
			((MigrationList*)migrationList)->ValidateNodeSet(item);
			((MigrationList*)migrationList)->ValidateNodeSet(Head);
		}

		public unsafe bool TryRemoveFirst(out NetworkObjectMeta result)
		{
			//IL_0294: Expected Obj, but got Ref
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
			//IL_0257: Expected Ref, but got VT
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected Obj, but got Unknown
			//IL_0133: Expected Obj, but got I
			//IL_0143: Expected Obj, but got I
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			NetworkObjectMeta networkObjectMeta = (NetworkObjectMeta)obj;
			ref NetworkObjectMeta reference;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
				NetworkObjectMeta networkObjectMeta2 = (NetworkObjectMeta)0;
				ValidateNodeSet((NetworkObjectMeta)obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
				ValidateNodeSet((NetworkObjectMeta)0);
				reference = ref *(NetworkObjectMeta*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
				if (0 != (nint)obj)
				{
					if (obj != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v4+B8]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
							object obj3 = (nint)0 + (nint)184;
							obj3 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (obj != null)
							{
								object obj4 = obj + 192;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
								NetworkObjectMeta networkObjectMeta3 = (NetworkObjectMeta)0;
								goto IL_02b9;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86C8]");
						object error = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+C0]");
						object obj5 = 0 - networkObjectMeta2._nodeMigration;
						bool condition = obj5 == null;
						Assert.Check(condition, (string)error);
						obj = 0;
						NetworkObjectMeta networkObjectMeta3 = null;
						object obj4 = obj;
						goto IL_02b9;
					}
				}
				goto IL_027b;
			}
			reference = ref *(NetworkObjectMeta*)null;
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
				object obj6 = result + 192;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj7 = result + 184;
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int count = _count - 1;
				_count = count;
				MigrationList migrationList = default;
				((MigrationList*)migrationList)->ValidateNodeClear(result);
				goto IL_025c;
			}
			goto IL_027b;
		}

		public unsafe bool TryPeekFirst(out NetworkObjectMeta result)
		{
			ref NetworkObjectMeta reference = ref *(NetworkObjectMeta*)Head;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag = Head == null;
			return !flag;
		}

		public NetworkObjectMeta RemoveFirst()
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
				NetworkObjectMeta networkObjectMeta = Head;
				while (true)
				{
					bool flag6 = networkObjectMeta == Head;
					condition3 = flag6;
					if (flag6)
					{
						break;
					}
					if (networkObjectMeta != null)
					{
						networkObjectMeta = (NetworkObjectMeta)networkObjectMeta._nodeMigration;
						if (networkObjectMeta._nodeMigration == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head)
						{
							condition3 = flag6;
							break;
						}
						continue;
					}
					return (NetworkObjectMeta)(object)new NullReferenceException();
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

		public unsafe bool Remove(NetworkObjectMeta item)
		{
			//IL_0010: Expected Obj, but got Ref
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
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				if (obj != null)
				{
					object obj2 = item + 192;
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v3+B8]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v3+B8]");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86D8]");
									object error3 = 0;
									object obj7 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+C0]");
									object obj8 = obj7 - 0;
									bool condition3 = obj8 == null;
									Assert.Check(condition3, (string)error3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86D0]");
									object error4 = 0;
									object obj9 = obj - item._nodeMigration;
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
									object obj12 = obj2 + 184;
									obj12 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (obj3 == null)
									{
										break;
									}
									object obj13 = obj3 + 192;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+C0]");
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

		public bool IsInListSlow(NetworkObjectMeta item)
		{
			//IL_00c4: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got VT
			//IL_0084: Invalid comparison between VT and Obj
			bool result;
			if (item != null && Head != null)
			{
				NetworkObjectMeta networkObjectMeta = Head;
				while (true)
				{
					bool flag = networkObjectMeta == item;
					result = flag;
					if (flag)
					{
						break;
					}
					if (networkObjectMeta != null)
					{
						networkObjectMeta = (NetworkObjectMeta)networkObjectMeta._nodeMigration;
						if (networkObjectMeta._nodeMigration == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head)
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
		public NetworkObjectMeta Next(NetworkObjectMeta item)
		{
			//IL_002c: Invalid comparison between VT and Obj
			//IL_005a: Expected Obj, but got VT
			if (item != null)
			{
				if (item._nodeMigration == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head)
				{
					return null;
				}
				return (NetworkObjectMeta)item._nodeMigration;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex = default;
			string paramName = default;
			ex._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			return (NetworkObjectMeta)(object)new ArgumentNullException();
		}

		[MethodImpl((MethodImplOptions)256)]
		public NetworkObjectMeta Prev(NetworkObjectMeta item)
		{
			//IL_0048: Expected Obj, but got I
			if (item != null)
			{
				if (Head != item)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+C0]");
					return (NetworkObjectMeta)0;
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
			return (NetworkObjectMeta)(object)new ArgumentNullException();
		}

		public unsafe NetworkObjectMeta[] ToArray()
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8680]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			NetworkObjectMeta networkObjectMeta;
			IndexOutOfRangeException ex = default;
			NetworkObjectMeta networkObjectMeta3;
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
				networkObjectMeta = Head;
				(flag5 ? ((MigrationList*)1) : ((MigrationList*)null))->ValidateNodeSet(Head);
				NetworkObjectMeta[] array = default;
				if (array == null)
				{
					goto IL_02cc;
				}
				NetworkObjectMeta networkObjectMeta2 = Head;
				object obj3 = array + 32;
				object obj4 = 0;
				while (true)
				{
					if (networkObjectMeta2 != null)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24 (Il2CppClass<Fusion.NetworkObjectMeta[]>)+40]");
						networkObjectMeta = (NetworkObjectMeta)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24 (Il2CppClass<Fusion.NetworkObjectMeta[]>)+40]");
						networkObjectMeta3 = (NetworkObjectMeta)0;
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
						bool flag8 = networkObjectMeta2 == null;
						networkObjectMeta = networkObjectMeta2;
						if (!flag8)
						{
							obj4++;
							bool flag9 = networkObjectMeta2._nodeMigration != (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head;
							networkObjectMeta = networkObjectMeta2;
							networkObjectMeta2 = (NetworkObjectMeta)networkObjectMeta2._nodeMigration;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8688]");
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
			return (NetworkObjectMeta[])0;
			IL_02da:
			ex = new IndexOutOfRangeException();
			networkObjectMeta3 = networkObjectMeta;
			goto IL_02f0;
			IL_02cc:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_02da;
			IL_02f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			return (NetworkObjectMeta[])(object)new ArgumentNullException();
		}

		private unsafe void Fusion_002EIIntrusiveLinkedList_002ECopyTo(Array array, int index)
		{
			//IL_001a: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected I4, but got Unknown
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
				(flag7 ? ((MigrationList*)1) : ((MigrationList*)null))->ValidateNodeSet(Head);
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v7 (System.Object)+B8]");
					obj4 = 0;
					num4++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v7 (System.Object)+B8]");
					if (0 == (nint)Head)
					{
						return;
					}
				}
			}
			throw new NullReferenceException();
		}

		private void ValidateNodeSet(NetworkObjectMeta item)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86B8]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86C0]");
			object error3 = 0;
			bool flag2 = item._nodeMigration == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)0;
			bool condition2 = !flag2;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+C0]");
			bool flag3 = (nint)0 == 0;
			bool condition3 = !flag3;
			Assert.Check(condition3, (string)error3);
		}

		private void ValidateNodeClear(NetworkObjectMeta item)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86B0]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D86A8]");
			object error3 = 0;
			bool condition2 = item._nodeMigration == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)0;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+C0]");
			bool condition3 = (nint)0 == 0;
			Assert.Check(condition3, (string)error3);
		}
	}

	public const int ALIGNMENT = default(int);

	[FieldOffset(0)]
	public int Value;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_VALUE = default(int);

	internal const int BYTE_COUNT_OF_VALUE = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public bool IsNone => Value == 0;

	public bool IsValid
	{
		get
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected I4, but got Unknown
			bool flag = Value < 0;
			bool flag2 = Value == 0;
			int num = Value ^ Value;
			int num2 = Value & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			return (byte)((flag4 & obj) ? 1 : 0) != 0;
		}
	}

	public NetworkObjectNestingKey(int value)
	{
		Value = value;
	}

	public bool Equals(NetworkObjectNestingKey other)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected Obj, but got Unknown
		object obj = Value - other;
		return obj == null;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7F98]");
			object obj2 = 0;
			if (obj == obj2)
			{
				int value = Value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				object obj3 = (nint)value - (nint)0;
				return obj3 == null;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Value;
	}

	public override string ToString()
	{
		//IL_005a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		if (Value != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8498]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			return string.Format((string)format, arg);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84A0]");
		return (string)0;
	}
}
