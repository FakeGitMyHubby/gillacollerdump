using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using PlayFab.EconomyModels;

namespace Fusion;

[Serializable]
[StructLayout((LayoutKind)2, Size = 16)]
public struct NetworkObjectGuid : Action<ReportItemResponse>, _0021_00210, Action<ReportItemReviewResponse>
{
	internal struct List : _0021_00210, Action<ReportAdActivityResult>
	{
		public delegate int PriorityLevelDelegate(NetworkObject networkObject, PlayerRef player);

		private int _count;

		public NetworkObjectConnectionData Head;

		public int Count
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				return _count;
			}
		}

		public NetworkObjectConnectionData Tail
		{
			[MethodImpl((MethodImplOptions)256)]
			get
			{
				//IL_0036: Expected Obj, but got I
				NetworkObjectConnectionData head = Head;
				if (Head != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.NetworkObjectConnectionData)+18]");
					return (NetworkObjectConnectionData)0;
				}
				return null;
			}
		}

		public bool IsEmpty => Head == null;

		public unsafe void AddFirst(NetworkObjectConnectionData item)
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				ValidateNodeSet((NetworkObjectConnectionData)0);
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
				NetworkObjectConnectionData networkObjectConnectionData = (NetworkObjectConnectionData)0;
			}
			else
			{
				object obj7 = item + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				item._node = (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)item;
				object obj6 = item + 16;
				NetworkObjectConnectionData networkObjectConnectionData = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Head = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			List list = default;
			((List*)list)->ValidateNodeSet(item);
			((List*)list)->ValidateNodeSet(Head);
		}

		public unsafe void AddLast(NetworkObjectConnectionData item)
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+18]");
				ValidateNodeSet((NetworkObjectConnectionData)0);
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
				NetworkObjectConnectionData networkObjectConnectionData = (NetworkObjectConnectionData)0;
			}
			else
			{
				object obj7 = item + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj8 = item + 16;
				item._node = (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj = item;
				object obj6 = obj;
				NetworkObjectConnectionData networkObjectConnectionData = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			List list = default;
			((List*)list)->ValidateNodeSet(item);
			((List*)list)->ValidateNodeSet(Head);
		}

		public unsafe bool TryRemoveFirst(out NetworkObjectConnectionData result)
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
			NetworkObjectConnectionData networkObjectConnectionData = (NetworkObjectConnectionData)obj;
			ref NetworkObjectConnectionData reference;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
				NetworkObjectConnectionData networkObjectConnectionData2 = (NetworkObjectConnectionData)0;
				ValidateNodeSet((NetworkObjectConnectionData)obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
				ValidateNodeSet((NetworkObjectConnectionData)0);
				reference = ref *(NetworkObjectConnectionData*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
				if (0 != (nint)obj)
				{
					if (obj != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v4+10]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
							object obj3 = (nint)0 + (nint)16;
							obj3 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (obj != null)
							{
								object obj4 = obj + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
								NetworkObjectConnectionData networkObjectConnectionData3 = (NetworkObjectConnectionData)0;
								goto IL_02b9;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7290]");
						object error = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectConnectionData)+18]");
						object obj5 = 0 - networkObjectConnectionData2._node;
						bool condition = obj5 == null;
						Assert.Check(condition, (string)error);
						obj = 0;
						NetworkObjectConnectionData networkObjectConnectionData3 = null;
						object obj4 = obj;
						goto IL_02b9;
					}
				}
				goto IL_027b;
			}
			reference = ref *(NetworkObjectConnectionData*)null;
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
				((List*)list)->ValidateNodeClear(result);
				goto IL_025c;
			}
			goto IL_027b;
		}

		public unsafe bool TryPeekFirst(out NetworkObjectConnectionData result)
		{
			ref NetworkObjectConnectionData reference = ref *(NetworkObjectConnectionData*)Head;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag = Head == null;
			return !flag;
		}

		public NetworkObjectConnectionData RemoveFirst()
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
				NetworkObjectConnectionData networkObjectConnectionData = Head;
				while (true)
				{
					bool flag6 = networkObjectConnectionData == Head;
					condition3 = flag6;
					if (flag6)
					{
						break;
					}
					if (networkObjectConnectionData != null)
					{
						networkObjectConnectionData = (NetworkObjectConnectionData)networkObjectConnectionData._node;
						if (networkObjectConnectionData._node == (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)(object)Head)
						{
							condition3 = flag6;
							break;
						}
						continue;
					}
					return (NetworkObjectConnectionData)(object)new NullReferenceException();
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

		public unsafe bool Remove(NetworkObjectConnectionData item)
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectConnectionData)+18]");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectConnectionData)+18]");
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

		public bool IsInListSlow(NetworkObjectConnectionData item)
		{
			//IL_00c4: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got VT
			//IL_0084: Invalid comparison between VT and Obj
			bool result;
			if (item != null && Head != null)
			{
				NetworkObjectConnectionData networkObjectConnectionData = Head;
				while (true)
				{
					bool flag = networkObjectConnectionData == item;
					result = flag;
					if (flag)
					{
						break;
					}
					if (networkObjectConnectionData != null)
					{
						networkObjectConnectionData = (NetworkObjectConnectionData)networkObjectConnectionData._node;
						if (networkObjectConnectionData._node == (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)(object)Head)
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
		public NetworkObjectConnectionData Next(NetworkObjectConnectionData item)
		{
			//IL_002c: Invalid comparison between VT and Obj
			//IL_005a: Expected Obj, but got VT
			if (item != null)
			{
				if (item._node == (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)(object)Head)
				{
					return null;
				}
				return (NetworkObjectConnectionData)item._node;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex = default;
			string paramName = default;
			ex._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			return (NetworkObjectConnectionData)(object)new ArgumentNullException();
		}

		[MethodImpl((MethodImplOptions)256)]
		public NetworkObjectConnectionData Prev(NetworkObjectConnectionData item)
		{
			//IL_0048: Expected Obj, but got I
			if (item != null)
			{
				if (Head != item)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectConnectionData)+18]");
					return (NetworkObjectConnectionData)0;
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
			return (NetworkObjectConnectionData)(object)new ArgumentNullException();
		}

		public unsafe NetworkObjectConnectionData[] ToArray()
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			NetworkObjectConnectionData networkObjectConnectionData;
			IndexOutOfRangeException ex = default;
			NetworkObjectConnectionData networkObjectConnectionData3;
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
				networkObjectConnectionData = Head;
				(flag5 ? ((List*)1) : ((List*)null))->ValidateNodeSet(Head);
				NetworkObjectConnectionData[] array = default;
				if (array == null)
				{
					goto IL_02cc;
				}
				NetworkObjectConnectionData networkObjectConnectionData2 = Head;
				object obj3 = array + 32;
				object obj4 = 0;
				while (true)
				{
					if (networkObjectConnectionData2 != null)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24 (Il2CppClass<Fusion.NetworkObjectConnectionData[]>)+40]");
						networkObjectConnectionData = (NetworkObjectConnectionData)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v24 (Il2CppClass<Fusion.NetworkObjectConnectionData[]>)+40]");
						networkObjectConnectionData3 = (NetworkObjectConnectionData)0;
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
						bool flag8 = networkObjectConnectionData2 == null;
						networkObjectConnectionData = networkObjectConnectionData2;
						if (!flag8)
						{
							obj4++;
							bool flag9 = networkObjectConnectionData2._node != (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)(object)Head;
							networkObjectConnectionData = networkObjectConnectionData2;
							networkObjectConnectionData2 = (NetworkObjectConnectionData)networkObjectConnectionData2._node;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D72F0]");
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
			return (NetworkObjectConnectionData[])0;
			IL_02da:
			ex = new IndexOutOfRangeException();
			networkObjectConnectionData3 = networkObjectConnectionData;
			goto IL_02f0;
			IL_02cc:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_02da;
			IL_02f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			return (NetworkObjectConnectionData[])(object)new ArgumentNullException();
		}

		private unsafe void Fusion_002EIIntrusiveLinkedList_002ECopyTo(Array array, int index)
		{
			//IL_001a: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected I4, but got Unknown
			//IL_02a2: Expected I, but got Obj
			//IL_01b8: Expected I, but got Obj
			//IL_01c8: Expected Obj, but got I
			//IL_01d8: Expected Obj, but got I
			//IL_07a0: Expected I, but got Obj
			//IL_0213: Expected Obj, but got I
			//IL_012e: Expected Obj, but got I
			//IL_02d4: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I
			//IL_0323: Expected Obj, but got I
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected Obj, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected Obj, but got Unknown
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected Obj, but got Unknown
			//IL_0413: Expected Obj, but got I4
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected Obj, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Expected Obj, but got Unknown
			//IL_04a7: Expected Obj, but got I
			//IL_0855: Expected Obj, but got I
			//IL_03ba: Expected Obj, but got I4
			//IL_090e: Expected Obj, but got I
			//IL_062f: Expected Obj, but got I8
			//IL_054f: Expected Obj, but got I
			//IL_0557: Expected I, but got Obj
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0579: Expected Obj, but got Unknown
			//IL_058d: Expected I, but got Obj
			//IL_073a: Expected Obj, but got I
			//IL_05c0: Expected Obj, but got I
			//IL_05ea: Expected Obj, but got I4
			//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a9: Expected Obj, but got Unknown
			//IL_08b1: Expected I, but got Obj
			//IL_08e2: Expected Obj, but got I4
			//IL_067f: Expected Obj, but got I8
			//IL_0988: Expected Obj, but got I
			//IL_0991: Unknown result type (might be due to invalid IL or missing references)
			//IL_0996: Expected Obj, but got Unknown
			//IL_09b0: Expected Obj, but got I4
			//IL_06b6: Expected Obj, but got I
			//IL_06d8: Expected Obj, but got I4
			//IL_06ee: Expected Obj, but got I
			//IL_0716: Unknown result type (might be due to invalid IL or missing references)
			//IL_071b: Expected Obj, but got Unknown
			//IL_0516: Expected Obj, but got I
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
					ArgumentNullException ex2 = new ArgumentNullException();
					string remoteStackTraceString = ((Exception)ex2)._remoteStackTraceString;
					if (((Exception)ex2)._remoteStackTraceString != null)
					{
						nint num2 = (nint)remoteStackTraceString;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7188]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v60 (Il2CppClass<System.String>)+12E]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v60 (Il2CppClass<System.String>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0254;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v60 (Il2CppClass<System.String>)+98]");
						object obj5 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X10_v13-8]");
							if (0 == (nint)obj3)
							{
								break;
							}
							obj4--;
							obj5 += 16;
							if ((nint)obj4 != 1)
							{
								continue;
							}
							goto IL_0254;
						}
						object obj6 = obj5 + 22;
						object obj7 = num2 + obj6;
						object obj8 = obj7 + 312;
						goto IL_0811;
					}
					NullReferenceException ex3 = new NullReferenceException();
					nint num3 = (nint)ex3;
					if (ex3 == null)
					{
						goto IL_043d;
					}
					goto IL_081b;
				}
				if (Head == null)
				{
					return;
				}
				bool flag3 = _count < 0;
				bool flag4 = _count == 0;
				int num4 = _count ^ _count;
				int num5 = _count & num4;
				bool flag5 = num5 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7298]");
				object error = 0;
				bool flag6 = flag3 == flag5;
				object obj9 = !flag4;
				bool flag7 = (byte)((flag6 & obj9) ? 1 : 0) != 0;
				Assert.Check(flag7, (string)error);
				(flag7 ? ((List*)1) : ((List*)null))->ValidateNodeSet(Head);
				int num6 = num;
				object obj10 = Head;
				while (true)
				{
					array.SetValue(obj10, num6);
					bool flag8 = obj10 == null;
					nint num7 = unchecked((nint)null);
					obj = obj10;
					num = num6;
					if (flag8)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v23 (System.Object)+10]");
					obj10 = 0;
					num6++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v23 (System.Object)+10]");
					if (0 == (nint)Head)
					{
						return;
					}
				}
			}
			throw new NullReferenceException();
			IL_0254:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0811;
			IL_081b:
			object obj11 = default;
			if (obj11 == null)
			{
				goto IL_043d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7190]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X20_v3 (Il2CppClass<System.NullReferenceException>)+24]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v9+F8]");
			object obj12 = num8 - 0;
			bool condition = obj12 == null;
			Assert.Check(condition, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X20_v3 (Il2CppClass<System.NullReferenceException>)+24]");
			object obj13 = (nint)0 << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
			if ((nint)0 != 0)
			{
				if (obj13 != null)
				{
					goto IL_0365;
				}
			}
			else
			{
				_ = 1;
				bool flag9 = obj13 == null;
				object obj14 = !flag9;
				if (obj14 != null)
				{
					goto IL_0365;
				}
			}
			bool flag10 = true;
			goto IL_0845;
			IL_0845:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			return;
			IL_0972:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X21_v10+20]");
			object obj16 = (nint)0 + (nint)309;
			object obj17 = obj16 & 1;
			bool flag11 = obj17 == null;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			return;
			IL_0365:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v9+E8]");
			if ((nint)0 != 0)
			{
				object obj19 = obj13 >> 30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X20_v3 (Il2CppClass<System.NullReferenceException>)+28]");
				bool flag12 = (nint)0 == 0;
				object obj20 = !flag12;
				object obj21 = ~obj20;
				bool flag13 = obj21 == null && obj19 == null;
				flag10 = flag13;
			}
			else
			{
				flag10 = false;
			}
			goto IL_0845;
			IL_0811:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v463 @ X0_v91] (should have been resolved before IL gen)");
			goto IL_081b;
			IL_043d:
			NullReferenceException ex4 = new NullReferenceException();
			Topologies topology = ((NetworkRunner)(object)ex4).Topology;
			if (topology == (Topologies)1)
			{
				return;
			}
			object dynamicMethods = ((Exception)ex4)._dynamicMethods;
			if (((Exception)ex4)._dynamicMethods == null)
			{
				return;
			}
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X21_v6 (System.Object)+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X21_v6 (System.Object)+60]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v33+40]");
					if ((nint)0 == 1)
					{
						object obj23 = typeof(SemaphoreSlim.TaskNode) + 464;
						nint num9 = (nint)dynamicMethods;
						object obj24 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X9_v13 (Il2CppClass<System.Object>)+130]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v45+130]");
						bool flag14 = num10 < 0;
						object obj25 = !flag14;
						object obj26 = ~obj25;
						if (obj26 != null)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X9_v13 (Il2CppClass<System.Object>)+B0]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v45+130]");
						object obj27 = num11 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X9_v15-8]");
						if (0 != (nint)obj24)
						{
							return;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD020]");
						object obj28 = 0;
						nint num12 = (nint)dynamicMethods;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v606 @ X9_v12 (Il2CppClass<System.Object>)+298] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BBB4");
						object obj30 = default;
						object obj29 = obj30 & 1;
						bool flag15 = obj29 == null;
						nint num7 = unchecked((nint)null);
						int num13 = default;
						int num = num13;
						if (flag15)
						{
							return;
						}
					}
					PlayerRef localPlayer = ((NetworkRunner)(object)ex4).LocalPlayer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj31 = 0;
					object obj32 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v38+E4]");
					bool flag16 = (nint)0 == 0;
					object obj33 = !flag16;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return;
				}
			}
			NullReferenceException ex5 = new NullReferenceException();
			IDictionary dictionary = ((Exception)ex5)._data;
			if (((Exception)ex5)._data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X21_v7 (System.Collections.IDictionary)+4]");
				object obj34 = 0 & -9223372036854775808L;
				if (obj34 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
			object obj35 = 0;
			Span<int> span = default;
			if (span.IsEmpty)
			{
				return;
			}
			IDictionary dictionary2 = ((Exception)ex5)._data;
			if (((Exception)ex5)._data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X20_v11 (System.Collections.IDictionary)+4]");
				object obj36 = 0 & -9223372036854775808L;
				if (obj36 != null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X20_v11 (System.Collections.IDictionary)+4]");
				bool flag17 = (nint)0 < (nint)19;
				object obj38 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X20_v11 (System.Collections.IDictionary)+4]");
				object obj39 = -19;
				bool flag18 = obj39 == null;
				object obj40 = obj37;
				object obj41 = ~obj38;
				object obj42 = obj41 | flag18;
				if (obj42 == null)
				{
					goto IL_0972;
				}
			}
			else
			{
				object obj43 = (nint)0 + (nint)3480;
				object obj40 = obj43;
			}
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			goto IL_0972;
		}

		private void ValidateNodeSet(NetworkObjectConnectionData item)
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
			bool flag2 = item._node == (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)(object)0;
			bool condition2 = !flag2;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectConnectionData)+18]");
			bool flag3 = (nint)0 == 0;
			bool condition3 = !flag3;
			Assert.Check(condition3, (string)error3);
		}

		private void ValidateNodeClear(NetworkObjectConnectionData item)
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
			bool condition2 = item._node == (Fusion.IntrusiveLinkedListNode<NetworkObjectConnectionData>)(object)0;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectConnectionData)+18]");
			bool condition3 = (nint)0 == 0;
			Assert.Check(condition3, (string)error3);
		}
	}

	public sealed class EqualityComparer : _0021_00210
	{
		public bool Equals(NetworkObjectGuid x, NetworkObjectGuid y)
		{
			//IL_0008: Invalid comparison between VT and I
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			IntPtr intPtr = default;
			if (x == (NetworkObjectGuid)(object)(nint)intPtr)
			{
				object obj2 = default;
				object obj = y - obj2;
				return obj == null;
			}
			return false;
		}

		public int GetHashCode(NetworkObjectGuid obj)
		{
			NetworkObjectGuid networkObjectGuid = default;
			int hashCode = networkObjectGuid.GetHashCode();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
			if (num == 0)
			{
				return hashCode;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			int result = default;
			return result;
		}
	}

	public const int ALIGNMENT = default(int);

	[FieldOffset(0)]
	public NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer RawGuidValue;

	[FieldOffset(0)]
	[NonSerialized]
	private long _data0;

	[FieldOffset(8)]
	[NonSerialized]
	private long _data1;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_RAW_GUID_VALUE = default(int);

	internal const int BYTE_COUNT_OF_RAW_GUID_VALUE = default(int);

	internal const int BYTE_OF__DATA0 = default(int);

	internal const int BYTE_COUNT_OF__DATA0 = default(int);

	internal const int BYTE_OF__DATA1 = default(int);

	internal const int BYTE_COUNT_OF__DATA1 = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public static NetworkObjectGuid Empty
	{
		get
		{
			//IL_0006: Expected VT, but got I4
			return (NetworkObjectGuid)0;
		}
	}

	public bool IsValid
	{
		get
		{
			//IL_000b: Invalid comparison between VT and I4
			if (RawGuidValue != (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)(object)0)
			{
				return true;
			}
			bool flag = _data1 == 0;
			return !flag;
		}
	}

	public unsafe NetworkObjectGuid(string guid)
	{
		//IL_002a: Expected VT, but got I4
		Guid guid2 = new Guid(guid);
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		RawGuidValue = (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		}
	}

	public NetworkObjectGuid(long data0, long data1)
	{
		//IL_000a: Expected VT, but got I8
		RawGuidValue = (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)data0;
		_data1 = data1;
	}

	public NetworkObjectGuid(byte[] guid)
	{
		//IL_001c: Expected VT, but got I8
		long num = BitConverter.ToInt64(guid, 0);
		RawGuidValue = (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)num;
		long data = BitConverter.ToInt64(guid, 8);
		_data1 = data;
	}

	public unsafe NetworkObjectGuid(byte* guid)
	{
		//IL_000a: Expected VT, but got I
		//IL_001c: Expected I8, but got I
		RawGuidValue = (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)guid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [guid @ X1 (System.Byte*)+8]");
		_data1 = 0L;
	}

	public unsafe static implicit operator NetworkObjectGuid(Guid guid)
	{
		//IL_0042: Expected VT, but got I4
		Guid guid2 = default;
		object obj = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&guid2), (byte*)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (NetworkObjectGuid)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkObjectGuid result = default;
		return result;
	}

	public unsafe static implicit operator Guid(NetworkObjectGuid guid)
	{
		//IL_0042: Expected VT, but got I4
		NetworkObjectGuid networkObjectGuid = default;
		object obj = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&networkObjectGuid), (byte*)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (Guid)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Guid result = default;
		return result;
	}

	public unsafe static bool TryParse(string str, out NetworkObjectGuid guid)
	{
		bool flag = Guid.TryParse(str, out var result);
		if (flag)
		{
			object obj = default;
			object obj2 = default;
			NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
			ref NetworkObjectGuid reference = ref *(NetworkObjectGuid*)null;
			bool flag2 = (byte)(&obj) != 0;
			byte* ptr = (byte*)(&obj2);
		}
		else
		{
			ref NetworkObjectGuid reference = ref *(NetworkObjectGuid*)null;
			_ = 0;
			bool flag2 = flag;
			byte* ptr = (byte*)(&result);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
		if (num == 0)
		{
			return flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe static NetworkObjectGuid Parse(string str)
	{
		//IL_0054: Expected VT, but got I4
		Guid guid = Guid.Parse(str);
		Guid guid2 = default;
		object obj = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&guid2), (byte*)(&obj));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return (NetworkObjectGuid)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkObjectGuid result = default;
		return result;
	}

	public static bool operator ==(NetworkObjectGuid a, NetworkObjectGuid b)
	{
		//IL_0008: Invalid comparison between VT and I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		IntPtr intPtr = default;
		if (a == (NetworkObjectGuid)(object)(nint)intPtr)
		{
			object obj2 = default;
			object obj = b - obj2;
			return obj == null;
		}
		return false;
	}

	public static bool operator !=(NetworkObjectGuid a, NetworkObjectGuid b)
	{
		//IL_0008: Invalid comparison between VT and I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		IntPtr intPtr = default;
		bool flag;
		if (a == (NetworkObjectGuid)(object)(nint)intPtr)
		{
			object obj2 = default;
			object obj = b - obj2;
			flag = obj == null;
		}
		else
		{
			flag = false;
		}
		return !flag;
	}

	public bool Equals(NetworkObjectGuid other)
	{
		//IL_0030: Expected Obj, but got I8
		if (RawGuidValue == (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)other)
		{
			IntPtr intPtr = default;
			object obj = _data1 - (nint)intPtr;
			return obj == null;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0046: Invalid comparison between VT and I
		//IL_0074: Expected Obj, but got I8
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D81E0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer rawGuidValue = RawGuidValue;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
				if (rawGuidValue == (NetworkPrefabRef._003CRawGuidValue_003Ee__FixedBuffer)(object)0)
				{
					long data = _data1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
					object obj3 = data - 0;
					return obj3 == null;
				}
			}
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		Guid guid = default;
		int hashCode = guid.GetHashCode();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return hashCode;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		int result = default;
		return result;
	}

	public unsafe override string ToString()
	{
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		Guid guid = default;
		string result = guid.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		string result2 = default;
		return result2;
	}

	public string ToUnityGuidString()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF1A8]");
		object obj = 0;
		return ToString((string)obj);
	}

	public unsafe string ToString(string format)
	{
		object obj = default;
		object obj2 = default;
		NetworkObjectGuidUtils.CopyAndMangleGuid((byte*)(&obj), (byte*)(&obj2));
		Guid guid = default;
		string result = guid.ToString(format);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		string result2 = default;
		return result2;
	}

	public int CompareTo(NetworkObjectGuid other)
	{
		//IL_000f: Expected Obj, but got VT
		//IL_0017: Invalid comparison between Obj and VT
		//IL_00aa: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I8
		object obj = RawGuidValue - other;
		if (obj == (object)other)
		{
			IntPtr intPtr = default;
			obj = _data1 - (nint)intPtr;
			if ((nint)obj == (nint)intPtr)
			{
				return 0;
			}
		}
		bool flag = (nint)obj < 0;
		object obj2 = obj ^ obj;
		object obj3 = obj & obj2;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return -1;
		}
		return 1;
	}

	public static explicit operator NetworkPrefabRef(NetworkObjectGuid t)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ SYSREG+28]");
		if (num == 0)
		{
			return (NetworkPrefabRef)t;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		NetworkPrefabRef result = default;
		return result;
	}
}
