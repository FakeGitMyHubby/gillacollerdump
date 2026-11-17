using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Fusion;

public class NetworkObjectMeta
{
	private class DebuggerProxy
	{
		public readonly NetworkObjectMeta[] Items;

		public DebuggerProxy(NetworkObjectNestingKey.MigrationList list)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			NetworkObjectNestingKey.MigrationList migrationList = default;
			NetworkObjectMeta[] array = migrationList.ToArray();
			object obj = this + 16;
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	internal struct AreaOfInterestList : Action<ReviewItemResponse>, _0021_00210
	{
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Fusion.NetworkObjectMeta)+B0]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				ValidateNodeSet((NetworkObjectMeta)0);
				object obj3 = item + 168;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = obj + 176;
				obj4 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				object obj5 = (nint)0 + (nint)168;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = item + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				NetworkObjectMeta networkObjectMeta = (NetworkObjectMeta)0;
			}
			else
			{
				object obj7 = item + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				item._nodeAreaOfInterest = (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)item;
				object obj6 = item + 168;
				NetworkObjectMeta networkObjectMeta = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Head = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			AreaOfInterestList areaOfInterestList = default;
			((AreaOfInterestList*)areaOfInterestList)->ValidateNodeSet(item);
			((AreaOfInterestList*)areaOfInterestList)->ValidateNodeSet(Head);
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				ValidateNodeSet((NetworkObjectMeta)0);
				object obj3 = item + 168;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj4 = obj + 176;
				obj4 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				object obj5 = (nint)0 + (nint)168;
				obj5 = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj6 = item + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1+B0]");
				NetworkObjectMeta networkObjectMeta = (NetworkObjectMeta)0;
			}
			else
			{
				object obj7 = item + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj8 = item + 168;
				item._nodeAreaOfInterest = (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				obj = item;
				object obj6 = obj;
				NetworkObjectMeta networkObjectMeta = item;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			int count = _count + 1;
			_count = count;
			AreaOfInterestList areaOfInterestList = default;
			((AreaOfInterestList*)areaOfInterestList)->ValidateNodeSet(item);
			((AreaOfInterestList*)areaOfInterestList)->ValidateNodeSet(Head);
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
				NetworkObjectMeta networkObjectMeta2 = (NetworkObjectMeta)0;
				ValidateNodeSet((NetworkObjectMeta)obj);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
				ValidateNodeSet((NetworkObjectMeta)0);
				reference = ref *(NetworkObjectMeta*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
				if (0 != (nint)obj)
				{
					if (obj != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v4+A8]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
							object obj3 = (nint)0 + (nint)168;
							obj3 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							if (obj != null)
							{
								object obj4 = obj + 176;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
								NetworkObjectMeta networkObjectMeta3 = (NetworkObjectMeta)0;
								goto IL_02b9;
							}
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8658]");
						object error = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (Fusion.NetworkObjectMeta)+B0]");
						object obj5 = 0 - networkObjectMeta2._nodeAreaOfInterest;
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
				object obj6 = result + 176;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj7 = result + 168;
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int count = _count - 1;
				_count = count;
				AreaOfInterestList areaOfInterestList = default;
				((AreaOfInterestList*)areaOfInterestList)->ValidateNodeClear(result);
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
						networkObjectMeta = (NetworkObjectMeta)networkObjectMeta._nodeAreaOfInterest;
						if (networkObjectMeta._nodeAreaOfInterest == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head)
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
					object obj2 = item + 176;
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v3+A8]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v3+A8]");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8668]");
									object error3 = 0;
									object obj7 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+B0]");
									object obj8 = obj7 - 0;
									bool condition3 = obj8 == null;
									Assert.Check(condition3, (string)error3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8660]");
									object error4 = 0;
									object obj9 = obj - item._nodeAreaOfInterest;
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
									object obj12 = obj2 + 168;
									obj12 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									if (obj3 == null)
									{
										break;
									}
									object obj13 = obj3 + 176;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+B0]");
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
						networkObjectMeta = (NetworkObjectMeta)networkObjectMeta._nodeAreaOfInterest;
						if (networkObjectMeta._nodeAreaOfInterest == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head)
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
				if (item._nodeAreaOfInterest == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head)
				{
					return null;
				}
				return (NetworkObjectMeta)item._nodeAreaOfInterest;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+B0]");
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
				(flag5 ? ((AreaOfInterestList*)1) : ((AreaOfInterestList*)null))->ValidateNodeSet(Head);
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
							bool flag9 = networkObjectMeta2._nodeAreaOfInterest != (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)Head;
							networkObjectMeta = networkObjectMeta2;
							networkObjectMeta2 = (NetworkObjectMeta)networkObjectMeta2._nodeAreaOfInterest;
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
				(flag7 ? ((AreaOfInterestList*)1) : ((AreaOfInterestList*)null))->ValidateNodeSet(Head);
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v7 (System.Object)+A8]");
					obj4 = 0;
					num4++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X22_v7 (System.Object)+A8]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8648]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8650]");
			object error3 = 0;
			bool flag2 = item._nodeAreaOfInterest == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)0;
			bool condition2 = !flag2;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+B0]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8640]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8638]");
			object error3 = 0;
			bool condition2 = item._nodeAreaOfInterest == (Fusion.IntrusiveLinkedListNode<NetworkObjectMeta>)(object)0;
			Assert.Check(condition2, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (Fusion.NetworkObjectMeta)+B0]");
			bool condition3 = (nint)0 == 0;
			Assert.Check(condition3, (string)error3);
		}
	}

	private Simulation _simulation;

	private unsafe ChangeTick* _changes;

	private NetworkObjectHeaderSnapshot _shadow;

	private NetworkObjectHeaderSnapshot _renderOrReceived;

	private NetworkObjectHeaderSnapshot _previous;

	private NetworkObjectHeaderSnapshot _migration;

	private NetworkObjectHeaderSnapshotList _snapshots;

	private NetworkObjectHeaderSnapshot[] _snapshotsByIndex;

	private Tick? _snapshotsByIndexLatest;

	private Timeline _timeline;

	internal InterpolationParams LocalInterpolationParams;

	internal InterpolationParams RemoteInterpolationParams;

	internal double LastGlobalRemoteTime;

	private Fusion.IntrusiveLinkedListNode<NetworkObjectMeta> _nodeAreaOfInterest;

	private Fusion.IntrusiveLinkedListNode<NetworkObjectMeta> _nodeMigration;

	internal Tick? InitialTick;

	internal Tick ScannedTick;

	internal ChangeTick ChangedTick;

	internal int AreaOfInterestCell;

	internal NetworkObjectMetaFlags LocalFlags;

	internal NetworkObjectHeaderPlayerDataFlags PlayerFlags;

	private unsafe int* _ptr;

	internal NetworkObject Instance;

	internal short WordCount;

	internal short BehaviourCount;

	internal NetworkObjectTypeDescriptor TypeDescriptor;

	internal const int PRIORITY_IDLE = default(int);

	internal const int PRIORITY_LEVEL_PLAYER = default(int);

	internal const int PRIORITY_LEVEL_HIGH = default(int);

	internal const int PRIORITY_LEVEL_MED = default(int);

	internal const int PRIORITY_LEVEL_LOW = default(int);

	internal const int PRIORITY_LEVEL_LOWEST = default(int);

	internal const int PRIORITY_LEVEL_COUNT = default(int);

	internal bool IsInAreaOfInterestList
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A360C0");
			bool result = default;
			return result;
		}
	}

	internal bool IsInMigrationList
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A360C0");
			bool result = default;
			return result;
		}
	}

	internal unsafe Timeline Timeline
	{
		get
		{
			//IL_0173: Expected Obj, but got I
			//IL_018b: Expected Obj, but got I
			//IL_01ad: Expected Obj, but got I4
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_0080: Expected Obj, but got I4
			//IL_00ae: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
			//IL_011f: Expected I4, but got VT
			//IL_01d0: Expected Obj, but got I
			if ((object)_simulation != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8568]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NetworkId runtimeConfig = NetworkId.RuntimeConfig;
				bool condition = _simulation.TryGetStruct(runtimeConfig, out var _);
				string text = (string)obj3;
				Assert.Check(condition, (string)obj3);
				object obj5 = this + 104;
				Timeline result = (Timeline)obj5;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					int* ptr = _ptr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10 (System.Int32*)+19]");
					object obj7 = (nint)0 & (nint)2;
					bool flag3 = obj7 == null;
					object obj8 = !flag3;
					int capacity;
					if (obj8 == null)
					{
						capacity = 1;
					}
					else
					{
						if ((object)_simulation == null)
						{
							goto IL_0136;
						}
						capacity = (int)_simulation.RuntimeConfigRef;
						text = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8560]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Timeline timeline = default;
					timeline._002Ector(capacity);
					obj5 = timeline;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = (Timeline)obj5;
				}
				return result;
			}
			goto IL_0136;
			IL_0136:
			return (Timeline)(object)new NullReferenceException();
		}
	}

	internal unsafe ref NetworkObjectHeader Header
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return ref *(NetworkObjectHeader*)_ptr;
		}
	}

	internal unsafe bool HasNetworkedState
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0020: Expected Obj, but got I
			//IL_003a: Expected Obj, but got I4
			//IL_0058: Expected Obj, but got I4
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected I4, but got Unknown
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected I4, but got Unknown
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
			object obj = (nint)0 & (nint)8;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = BehaviourCount + 34;
				object obj4 = obj3 - WordCount;
				bool flag2 = (nint)obj4 < 0;
				int num = obj3 ^ WordCount;
				object obj5 = obj3 ^ obj4;
				int num2 = num & obj5;
				bool flag3 = num2 < 0;
				bool flag4 = flag2 == flag3;
				return !flag4;
			}
			return true;
		}
	}

	internal unsafe bool IsValid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			bool flag = _ptr == null;
			return !flag;
		}
	}

	internal unsafe bool HasMainTRSP
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_003f: Expected Obj, but got I
			//IL_0059: Expected Obj, but got I4
			//IL_007d: Expected Obj, but got I4
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected I4, but got Unknown
			//IL_00ef: Expected Obj, but got I4
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected I4, but got Unknown
			int* ptr = _ptr;
			if (_ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
				object obj = (nint)0 & (nint)8;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					object obj3 = WordCount - 33;
					bool flag2 = (nint)obj3 < 0;
					bool flag3 = obj3 == null;
					int num = WordCount ^ 0x21;
					int num2 = WordCount ^ obj3;
					int num3 = num & num2;
					bool flag4 = num3 < 0;
					bool flag5 = flag2 == flag4;
					object obj4 = !flag3;
					return (byte)((flag5 & obj4) ? 1 : 0) != 0;
				}
			}
			return false;
		}
	}

	internal unsafe ref NetworkTRSPData MainTRSPData
	{
		get
		{
			//IL_0107: Expected Obj, but got I
			//IL_001b: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected I4, but got Unknown
			//IL_00d3: Expected Obj, but got I4
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected I4, but got Unknown
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8580]");
			object error = 0;
			bool condition;
			if (_ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1 (System.Int32*)+18]");
				object obj = (nint)0 & (nint)8;
				bool flag = obj == null;
				object obj2 = !flag;
				if (obj2 != null)
				{
					object obj3 = WordCount - 33;
					bool flag2 = (nint)obj3 < 0;
					bool flag3 = obj3 == null;
					int num = WordCount ^ 0x21;
					int num2 = WordCount ^ obj3;
					int num3 = num & num2;
					bool flag4 = num3 < 0;
					bool flag5 = flag2 == flag4;
					object obj4 = !flag3;
					bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
					condition = flag6;
					goto IL_0126;
				}
			}
			condition = false;
			goto IL_0126;
			IL_0126:
			Assert.Check(condition, (string)error);
			return ref *(NetworkTRSPData*)(_ptr + 20);
		}
	}

	internal unsafe Span<int> Raw
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_002a: Expected I4, but got I8
			//IL_0016: Expected VT, but got I
			if ((int)(WordCount & -9223372036854775808L) != 0)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return (Span<int>)_ptr;
		}
	}

	internal unsafe int* RawPtr
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return _ptr;
		}
	}

	internal unsafe Span<int> Data
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_010f: Expected Obj, but got I
			//IL_0123: Expected I4, but got I8
			//IL_013d: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00f1: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I4
			//IL_0039: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I4
			//IL_00a9: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
			object obj = 0;
			int num = (int)(WordCount & -9223372036854775808L);
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = obj;
				bool flag2 = WordCount < 19;
				object obj4 = !flag2;
				object obj5 = WordCount - 19;
				bool flag3 = obj5 == null;
				object obj6 = !flag3;
				object obj7 = obj4 & obj6;
				if (obj7 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			else
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				object obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v3+20]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag4 = obj9 == null;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			return (Span<int>)(_ptr + 20);
		}
	}

	internal unsafe Span<int> BehaviourChangedTickArray
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_00e7: Expected Obj, but got I
			//IL_00fb: Expected I4, but got I8
			//IL_00ae: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I4
			//IL_0039: Expected Obj, but got I
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected Obj, but got Unknown
			//IL_0061: Expected Obj, but got I4
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected VT, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
			object obj = 0;
			int num = (int)(WordCount & 0x80000000L);
			bool flag = num == 0;
			short wordCount = WordCount;
			if (!flag)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				wordCount = WordCount;
			}
			object obj2 = obj;
			object obj3 = wordCount - BehaviourCount;
			bool flag2 = WordCount < (nint)obj3;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v3+20]");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag3 = obj6 == null;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			return (Span<int>)(_ptr + obj3);
		}
	}

	internal bool HasSnapshots
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			bool flag = (nint)0 == 0;
			return !flag;
		}
	}

	internal NetworkObjectHeaderSnapshotRef SnapshotLatest
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_000d: Expected VT, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			return (NetworkObjectHeaderSnapshotRef)0;
		}
	}

	internal unsafe bool IsStruct
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0020: Expected Obj, but got I
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected I4, but got Unknown
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
			object obj = (nint)0 >> 5;
			return (byte)(obj & 1) != 0;
		}
	}

	internal unsafe bool IsObject
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0020: Expected Obj, but got I
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
			object obj = (nint)0 & (nint)0x20;
			return obj == null;
		}
	}

	public unsafe NetworkObjectTypeId Type
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0017: Expected VT, but got I
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+8]");
			return (NetworkObjectTypeId)0;
		}
	}

	public unsafe NetworkId Id
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_000f: Expected VT, but got I
			int* ptr = _ptr;
			return (NetworkId)ptr;
		}
	}

	public unsafe NetworkId NestingRoot
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0017: Expected VT, but got I
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+10]");
			return (NetworkId)0;
		}
	}

	public unsafe NetworkObjectNestingKey NestingKey
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0017: Expected VT, but got I
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+14]");
			return (NetworkObjectNestingKey)0;
		}
	}

	public unsafe NetworkObjectHeaderFlags Flags
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
			return (NetworkObjectHeaderFlags)0;
		}
	}

	internal unsafe PlayerRef StateAuthority
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0017: Expected VT, but got I
			int* ptr = _ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+20]");
			return (PlayerRef)0;
		}
		[MethodImpl((MethodImplOptions)256)]
		set
		{
			int* ptr = _ptr;
		}
	}

	public unsafe ref PlayerRef InputAuthority
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			return ref *(PlayerRef*)(_ptr + 7);
		}
	}

	internal NetworkObjectHeaderSnapshotRef Shadow
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_006b: Expected VT, but got Obj
			object obj = this + 32;
			NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = (NetworkObjectHeaderSnapshot)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot2 = (_shadow = GetFirstShadowSnapshot());
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				networkObjectHeaderSnapshot = networkObjectHeaderSnapshot2;
			}
			return (NetworkObjectHeaderSnapshotRef)networkObjectHeaderSnapshot;
		}
	}

	internal NetworkObjectHeaderSnapshotRef Render
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0070: Expected VT, but got Obj
			object obj = this + 40;
			NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = (NetworkObjectHeaderSnapshot)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot2 = (_renderOrReceived = GetSnapshot(copyState: false));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				networkObjectHeaderSnapshot = networkObjectHeaderSnapshot2;
			}
			return (NetworkObjectHeaderSnapshotRef)networkObjectHeaderSnapshot;
		}
	}

	internal NetworkObjectHeaderSnapshotRef Previous
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0070: Expected VT, but got Obj
			object obj = this + 48;
			NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = (NetworkObjectHeaderSnapshot)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot2 = (_previous = GetSnapshot(copyState: true));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				networkObjectHeaderSnapshot = networkObjectHeaderSnapshot2;
			}
			return (NetworkObjectHeaderSnapshotRef)networkObjectHeaderSnapshot;
		}
	}

	internal NetworkObjectHeaderSnapshotRef Migration
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0070: Expected VT, but got Obj
			object obj = this + 56;
			NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = (NetworkObjectHeaderSnapshot)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot2 = (_migration = GetSnapshot(copyState: false));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				networkObjectHeaderSnapshot = networkObjectHeaderSnapshot2;
			}
			return (NetworkObjectHeaderSnapshotRef)networkObjectHeaderSnapshot;
		}
	}

	internal unsafe ChangeTick* ChangesRaw
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_001c: Expected Obj, but got I4
			//IL_008d: Expected I, but got Obj
			bool flag = _changes == null;
			object obj = !flag;
			ChangeTick* result = _changes;
			if (obj == null)
			{
				if ((object)_simulation == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (ChangeTick*)(nint)ex;
				}
				result = (_changes = _simulation.NativeAllocObjectChanges(WordCount));
			}
			return result;
		}
	}

	internal unsafe Span<ChangeTick> Changes
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0089: Expected Obj, but got I4
			//IL_0093: Expected VT, but got I
			//IL_00b5: Expected I4, but got I8
			//IL_006d: Expected VT, but got Obj
			//IL_004b: Expected VT, but got I
			bool flag = _changes == null;
			object obj = !flag;
			Span<ChangeTick> result = (Span<ChangeTick>)_changes;
			if (obj == null)
			{
				if ((object)_simulation == null)
				{
					NullReferenceException ex = new NullReferenceException();
					return (Span<ChangeTick>)ex;
				}
				result = (Span<ChangeTick>)(_changes = _simulation.NativeAllocObjectChanges(WordCount));
			}
			if ((int)(WordCount & -9223372036854775808L) != 0)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return result;
		}
	}

	public override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8558]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		return string.Format((string)format, arg, arg2);
	}

	internal unsafe void SetChangedTick(ChangeTick tick, string member = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0445: Expected Obj, but got I
		//IL_0455: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I8
		//IL_0128: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_026f: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_020c: Expected I, but got Obj
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I8
		//IL_030e: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+A8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			int* ptr = _ptr;
			nint num = (nint)ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30D749C");
			IntPtr intPtr = default;
			object[] array = default;
			IndexOutOfRangeException ex = default;
			nint num3;
			if (intPtr != (IntPtr)0)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
				num3 = 0;
				if (flag)
				{
					goto IL_040e;
				}
			}
			if (array.Length != 0)
			{
				object obj6 = array + 32;
				obj6 = (nint)intPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag2 = member == null;
				num = intPtr;
				if (!flag2)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag3 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
					num3 = 0;
					if (flag3)
					{
						goto IL_040e;
					}
				}
				object obj7 = array.Length & 0xFFFFFFFEL;
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8570]");
					object obj8 = 0;
					object obj9 = array + 40;
					obj9 = member;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj10 = default;
					bool flag4 = obj10 == null;
					object obj11 = default;
					num = (nint)(&obj11);
					if (!flag4)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
						num3 = 0;
						if (flag5)
						{
							goto IL_040e;
						}
					}
					bool flag6 = array.Length < 2;
					object obj12 = !flag6;
					object obj13 = array.Length - 2;
					bool flag7 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag7;
					if (obj15 == null)
					{
						object obj16 = array + 48;
						obj16 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj17 = default;
						bool flag8 = obj17 == null;
						object obj18 = default;
						num = (nint)(&obj18);
						if (!flag8)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag9 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
							num3 = 0;
							if (flag9)
							{
								goto IL_040e;
							}
						}
						object obj19 = array.Length & 0xFFFFFFFCL;
						if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8578]");
							object format = 0;
							object obj20 = array + 56;
							obj20 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text = string.Format((string)format, array);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X25_v1+10]");
							object obj21 = 0;
							object obj22 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ X9_v3+188] (should have been resolved before IL gen)");
							goto IL_047a;
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			num3 = num;
			goto IL_040e;
		}
		goto IL_047a;
		IL_040e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
		IL_047a:
		ChangedTick = tick;
	}

	internal Span<int> GetBehaviourChangedTickArray(NetworkObjectHeaderSnapshotRef snapshot)
	{
		//IL_0108: Invalid comparison between VT and I4
		//IL_00ff: Expected VT, but got Obj
		//IL_012c: Expected VT, but got I
		//IL_013c: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0182: Invalid comparison between VT and Obj
		//IL_0193: Expected Obj, but got I4
		//IL_001a: Expected VT, but got I
		//IL_0034: Expected Obj, but got I8
		//IL_009a: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected VT, but got Unknown
		if (snapshot == (NetworkObjectHeaderSnapshotRef)(object)0)
		{
			NullReferenceException ex = new NullReferenceException();
			return (Span<int>)ex;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [snapshot @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+28]");
		Span<int> span = (Span<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [snapshot @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+28]");
		NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [snapshot @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+24]");
			networkObjectHeaderSnapshotRef = (NetworkObjectHeaderSnapshotRef)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [snapshot @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+24]");
			object obj2 = 0 & 0x80000000L;
			if (obj2 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
		}
		else
		{
			Span<int> empty = Span<int>.Empty;
			networkObjectHeaderSnapshotRef = snapshot;
			span = empty;
		}
		object obj3 = obj;
		object obj4 = WordCount - BehaviourCount;
		bool flag = networkObjectHeaderSnapshotRef < obj4;
		object obj5 = !flag;
		if (obj5 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X22_v3+20]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		return (Span<int>)(span + obj4);
	}

	internal unsafe Tick GetMaxBehaviourChangedTick()
	{
		//IL_01ca: Expected I4, but got I8
		//IL_0228: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_019e: Expected VT, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_01b1: Expected VT, but got Obj
		//IL_00f2: Expected Obj, but got I4
		//IL_0125: Expected I4, but got Obj
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0190: Expected VT, but got I4
		int num = (int)(WordCount & 0x80000000L);
		bool flag = num == 0;
		short wordCount = WordCount;
		if (!flag)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			wordCount = WordCount;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
		object obj = 0;
		object obj2 = wordCount - BehaviourCount;
		object obj3 = obj;
		object obj4 = WordCount - obj2;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
		object obj5 = !flag2;
		if (obj5 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X21_v1+20]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		if ((nint)obj4 >= 1)
		{
			object obj9 = _ptr + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj10 = 0;
			int num2 = 0;
			while (obj4 != null)
			{
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v12+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj13 = ~obj9;
				int val = obj9 & obj13;
				int num3 = Math.Max(num2, val);
				int num4 = ~num3;
				num2 = num3 & num4;
				obj4--;
				obj9 += 4;
				if ((nint)obj4 == 1)
				{
					return (Tick)num2;
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (Tick)ex;
		}
		return (Tick)0;
	}

	internal Tick GetMaxBehaviourChangedTick(NetworkObjectHeaderSnapshotRef snapshot)
	{
		//IL_00e9: Invalid comparison between VT and I4
		//IL_00cd: Expected VT, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got VT
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00bf: Expected VT, but got I4
		NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef = default;
		Span<int> behaviourChangedTickArray = GetBehaviourChangedTickArray(networkObjectHeaderSnapshotRef);
		if (networkObjectHeaderSnapshotRef >= (object)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			object obj2 = networkObjectHeaderSnapshotRef & 0xFFFFFFFFL;
			int num = 0;
			Span<int> span = behaviourChangedTickArray;
			do
			{
				object obj3 = obj;
				span = (Span<int>)(span + 4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj5 = ~span;
				int val = span & obj5;
				int num2 = Math.Max(num, val);
				int num3 = ~num2;
				num = num2 & num3;
				obj2--;
			}
			while ((nint)obj2 != 1);
			return (Tick)num;
		}
		return (Tick)0;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe ref T GetStructData<T>() where T : struct
	{
		return ref *(T*)(_ptr + 34);
	}

	private unsafe NetworkObjectHeaderSnapshot GetFirstShadowSnapshot()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0086: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot snapshot = GetSnapshot(copyState: false);
		if (snapshot != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84B8]");
			object error = 0;
			bool flag = snapshot._ptr == null;
			bool condition = !flag;
			Assert.Always(condition, (string)error);
			object obj2 = obj;
			int* ptr = snapshot._ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			bool flag3 = snapshot._ptr == null;
			bool condition2 = !flag3;
			Assert.Always(condition2, (string)error);
			int* ptr2 = _ptr;
			int* ptr3 = snapshot._ptr;
			ptr3 = ptr2;
			return snapshot;
		}
		return (NetworkObjectHeaderSnapshot)(object)new NullReferenceException();
	}

	internal unsafe void PoolInit(Simulation simulation, [In] ref NetworkObjectHeader header)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected I4, but got Unknown
		//IL_0118: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84E8]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8590]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8598]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85A0]");
		object error4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85A8]");
		object error5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85B0]");
		object error6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85B8]");
		object error7 = 0;
		bool condition = _ptr == null;
		Assert.Check(condition, (string)error);
		bool condition2 = (object)Instance == null;
		Assert.Check(condition2, (string)error2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.NetworkObjectHeader&)+4]");
		object obj = -19;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.NetworkObjectHeader&)+4]");
		object obj2 = (nint)0 ^ (nint)0x13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.NetworkObjectHeader&)+4]");
		object obj3 = 0 ^ obj;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		bool condition3 = (byte)((flag4 & obj5) ? 1 : 0) != 0;
		Assert.Always(condition3, (string)error3);
		bool condition4 = _shadow == null;
		Assert.Check(condition4, (string)error4);
		bool condition5 = _renderOrReceived == null;
		Assert.Check(condition5, (string)error5);
		bool condition6 = _previous == null;
		Assert.Check(condition6, (string)error6);
		bool condition7 = _migration == null;
		Assert.Check(condition7, (string)error7);
		bool condition8 = _changes == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85C0]");
		object error8 = 0;
		Assert.Check(condition8, (string)error8);
		object obj6 = this + 16;
		obj6 = simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.NetworkObjectHeader&)+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.NetworkObjectHeader&)+6]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [header @ X2 (Fusion.NetworkObjectHeader&)+4]");
		int* ptr = simulation.NativeAllocObjectData(0);
		_ptr = ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0A0");
	}

	internal unsafe void PoolReset(Simulation simulation)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Ref, but got Unknown
		//IL_0372: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I4
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected I4, but got Unknown
		//IL_03a2: Expected VT, but got I
		//IL_003e: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I4, but got Unknown
		//IL_006e: Expected VT, but got I
		//IL_0077: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_017b: Expected VT, but got I4
		//IL_0191: Expected VT, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Ref, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Ref, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Ref, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Ref, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Ref, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected VT, but got Unknown
		//IL_030b: Expected native int or pointer, but got VT
		//IL_0315: Expected native int or pointer, but got VT
		//IL_031f: Expected native int or pointer, but got VT
		//IL_02c7: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85C8]");
		object format = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85D8]");
		object format2 = 0;
		bool isInAreaOfInterestList = IsInAreaOfInterestList;
		ref int* reference = ref *(int**)(this + 232);
		int* ptr = (int*)(nint)System.Runtime.CompilerServices.Unsafe.As<int*, object>(ref reference);
		object obj2 = !isInAreaOfInterestList;
		bool condition = (byte)(1 & obj2) != 0;
		Assert.Check(condition, (string)format, (NetworkId)ptr, (Fusion.IntrusiveLinkedListNode<System.__Canon>)_nodeAreaOfInterest);
		bool isInMigrationList = IsInMigrationList;
		int* ptr2 = (int*)(nint)System.Runtime.CompilerServices.Unsafe.As<int*, object>(ref reference);
		object obj3 = !isInMigrationList;
		bool condition2 = (byte)(1 & obj3) != 0;
		Assert.Check(condition2, (string)format2, (NetworkId)ptr2, (Fusion.IntrusiveLinkedListNode<System.__Canon>)_nodeMigration);
		int* ptr3 = (int*)(nint)System.Runtime.CompilerServices.Unsafe.As<int*, object>(ref reference);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		ptr3 = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		simulation.NativeFreeObjectData(ref reference, WordCount);
		object obj5 = obj4;
		object obj6 = this + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)(UnityEngine.Object)obj6)
		{
			UnlinkInstance(Instance);
		}
		Instance = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj8 = this + 256;
		TypeDescriptor = null;
		ScannedTick = (Tick)0;
		AreaOfInterestCell = 0;
		InitialTick = (Tick?)(object)0;
		PlayerFlags = (NetworkObjectHeaderPlayerDataFlags)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_simulation.Release(ref *(NetworkObjectHeaderSnapshot*)(this + 32));
		_simulation.Release(ref *(NetworkObjectHeaderSnapshot*)(this + 40));
		_simulation.Release(ref *(NetworkObjectHeaderSnapshot*)(this + 48));
		_simulation.Release(ref *(NetworkObjectHeaderSnapshot*)(this + 56));
		simulation.NativeFreeObjectChanges(ref *(ChangeTick**)(this + 24), WordCount);
		Array snapshotsByIndex = _snapshotsByIndex;
		if (_snapshotsByIndex != null)
		{
			NetworkObjectHeaderSnapshot[] snapshotsByIndex2 = _snapshotsByIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v25 (System.Array)+18]");
			Array.Clear(snapshotsByIndex2, 0, 0);
		}
		NetworkObjectHeaderSnapshotList networkObjectHeaderSnapshotList = (NetworkObjectHeaderSnapshotList)(this + 64);
		if (networkObjectHeaderSnapshotList._count >= 1)
		{
			NetworkObjectHeaderSnapshot obj9 = default;
			do
			{
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = ((NetworkObjectHeaderSnapshotList*)networkObjectHeaderSnapshotList)->RemoveLatest();
				_simulation.Release(ref obj9);
			}
			while (networkObjectHeaderSnapshotList._count > 0);
		}
		((NetworkObjectHeaderSnapshotList*)(nint)networkObjectHeaderSnapshotList)->_count = 0;
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkObjectHeaderSnapshotList*)(nint)networkObjectHeaderSnapshotList)->_tail, null);
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkObjectHeaderSnapshotList*)(nint)networkObjectHeaderSnapshotList)->_head, null);
		if (_timeline != null)
		{
			_timeline.Clear();
		}
	}

	internal unsafe void ResetMigrationSnapshot()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		_simulation.Release(ref *(NetworkObjectHeaderSnapshot*)(this + 56));
	}

	private unsafe NetworkObjectHeaderSnapshot GetSnapshot(bool copyState)
	{
		//IL_0182: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot;
		int num;
		if ((object)_simulation != null)
		{
			networkObjectHeaderSnapshot = _simulation.AcquireNetworkObjectHeaderSnapshot(WordCount);
			if (!copyState)
			{
				goto IL_015f;
			}
			if (networkObjectHeaderSnapshot != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
				object error = 0;
				object obj = networkObjectHeaderSnapshot.WordCount - WordCount;
				bool condition = obj == null;
				Assert.Check(condition, (string)error);
				num = networkObjectHeaderSnapshot.WordCount << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
				if ((nint)0 != 0)
				{
					if (num != 0)
					{
						goto IL_0090;
					}
				}
				else
				{
					_ = 1;
					bool flag = num == 0;
					object obj2 = !flag;
					if (obj2 != null)
					{
						goto IL_0090;
					}
				}
				bool flag2 = true;
				goto IL_01f7;
			}
		}
		return (NetworkObjectHeaderSnapshot)(object)new NullReferenceException();
		IL_015f:
		return networkObjectHeaderSnapshot;
		IL_01f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		goto IL_015f;
		IL_0090:
		if (networkObjectHeaderSnapshot._ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = _ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			bool flag2 = flag4;
		}
		else
		{
			bool flag2 = false;
		}
		goto IL_01f7;
	}

	internal unsafe NetworkObjectHeaderSnapshotRef NextSnapshot(Tick tick, bool copyInitialState = default(bool))
	{
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected VT, but got Unknown
		//IL_017e: Expected VT, but got Obj
		//IL_088c: Expected Ref, but got VT
		//IL_089c: Expected Obj, but got I
		//IL_08bb: Expected VT, but got Obj
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_0769: Expected Obj, but got I
		//IL_0793: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I
		//IL_0277: Expected I, but got Obj
		//IL_0290: Expected VT, but got I4
		//IL_072c: Expected VT, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got VT
		//IL_02ae: Expected Obj, but got I
		//IL_02b6: Expected I4, but got Obj
		//IL_02cb: Expected VT, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected VT, but got Unknown
		//IL_02df: Expected VT, but got I4
		//IL_02ef: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		//IL_0529: Expected VT, but got I4
		//IL_00a0: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_07a9: Expected VT, but got Obj
		//IL_07b2: Expected Ref, but got VT
		//IL_07d2: Expected I, but got Obj
		//IL_00df: Invalid comparison between I4 and VT
		//IL_00f1: Expected VT, but got I4
		//IL_0537: Expected Ref, but got VT
		//IL_054f: Expected I, but got Obj
		//IL_0560: Expected VT, but got I4
		//IL_033b: Expected Obj, but got VT
		//IL_051b: Expected VT, but got I
		//IL_057e: Expected Obj, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_0801: Expected I, but got Obj
		//IL_0812: Expected VT, but got I4
		//IL_048d: Expected Ref, but got VT
		//IL_04a3: Expected I, but got Obj
		//IL_04ab: Expected VT, but got Obj
		//IL_03b4: Expected VT, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_0593: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I
		//IL_04e7: Expected Obj, but got I4
		//IL_06c9: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I4
		//IL_0406: Expected I, but got Obj
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_046d: Expected Obj, but got I4
		//IL_083d: Expected Obj, but got I
		//IL_085a: Expected VT, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0670: Expected Obj, but got I4
		NetworkObjectHeaderSnapshotList networkObjectHeaderSnapshotList = (NetworkObjectHeaderSnapshotList)(this + 64);
		NetworkObjectMeta meta = default;
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot;
		nint num2;
		Tick tick2;
		nint num;
		bool flag6 = default;
		if (networkObjectHeaderSnapshotList._count != 0)
		{
			bool flag = (object)_simulation == null;
			tick2 = tick;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v37+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NetworkId runtimeConfig = NetworkId.RuntimeConfig;
				bool flag3 = _simulation.TryGetStruct(runtimeConfig, out meta);
				bool flag4 = !flag3;
				tick2 = (Tick)runtimeConfig;
				if (flag4)
				{
					goto IL_00ff;
				}
				bool flag5 = (object)_simulation == null;
				num = unchecked((nint)null);
				flag6 = (byte)(&meta) != 0;
				tick2 = (Tick)runtimeConfig;
				if (!flag5)
				{
					ref SimulationRuntimeConfig runtimeConfigRef = ref _simulation.RuntimeConfigRef;
					bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)networkObjectHeaderSnapshotList._count) >= System.Runtime.CompilerServices.Unsafe.As<SimulationRuntimeConfig, UIntPtr>(ref runtimeConfigRef);
					tick2 = (Tick)0;
					if (!flag7)
					{
						goto IL_00ff;
					}
					networkObjectHeaderSnapshot = ((NetworkObjectHeaderSnapshotList*)networkObjectHeaderSnapshotList)->RemoveOldest();
					bool flag8 = networkObjectHeaderSnapshot == null;
					num = unchecked((nint)null);
					flag6 = (byte)(&meta) != 0;
					tick2 = (Tick)0;
					if (!flag8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
						bool flag9 = (nint)0 == 0;
						num = unchecked((nint)null);
						flag6 = (byte)(&meta) != 0;
						tick2 = (Tick)0;
						if (!flag9)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
							object error = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X24_v9+24]");
							object obj5 = -networkObjectHeaderSnapshot.WordCount;
							bool condition = obj5 == null;
							Assert.Check(condition, (string)error);
							num2 = networkObjectHeaderSnapshot.WordCount << 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
							if ((nint)0 != 0)
							{
								if (num2 != 0)
								{
									goto IL_061e;
								}
							}
							else
							{
								_ = 1;
								bool flag10 = num2 == 0;
								object obj6 = !flag10;
								if (obj6 != null)
								{
									goto IL_061e;
								}
							}
							bool flag11 = true;
							goto IL_082d;
						}
					}
				}
			}
			goto IL_06f3;
		}
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot2 = GetSnapshot(flag6);
		goto IL_0176;
		IL_070f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex = new ArgumentNullException();
		return (NetworkObjectHeaderSnapshotRef)ex;
		IL_06f3:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0701;
		IL_00ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		bool flag12 = (nint)0 == 0;
		num = unchecked((nint)null);
		flag6 = (byte)(&meta) != 0;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			networkObjectHeaderSnapshot2 = ((NetworkObjectHeaderSnapshot)0).Clone(_simulation);
			meta = null;
			num = unchecked((nint)null);
			flag6 = (byte)(&meta) != 0;
			goto IL_0176;
		}
		goto IL_06f3;
		IL_087f:
		NetworkObjectHeaderSnapshotList networkObjectHeaderSnapshotList2;
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot3;
		((NetworkObjectHeaderSnapshotList*)networkObjectHeaderSnapshotList2)->AddFirst(networkObjectHeaderSnapshot3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		bool flag13 = (nint)0 == 0;
		tick2 = (Tick)networkObjectHeaderSnapshot3;
		Tick? tick4;
		IndexOutOfRangeException ex3 = default;
		if (!flag13)
		{
			object obj8 = this + 88;
			Array array = (Array)obj8;
			bool flag14 = obj8 == null;
			object obj9 = !flag14;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85F0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Tick tick3 = default;
				obj8 = tick3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				array = (Array)obj8;
				bool flag15 = obj8 == null;
				tick2 = tick3;
				if (flag15)
				{
					goto IL_06f3;
				}
			}
			Array array2 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v4 (System.Array)+18]");
			Array.Clear(array2, 0, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			bool flag16 = (nint)0 == 0;
			num = unchecked((nint)null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v4 (System.Array)+18]");
			flag6 = false;
			tick2 = (Tick)0;
			if (!flag16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8108]");
				object obj12 = 0;
				flag6 = (byte)(int)obj12 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v7+20]");
				tick4 = (Tick)0;
				Tick? tick5 = (Tick?)(object)(this + 96);
				tick5 = (Tick?)(object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X22_v4 (System.Nullable`1<Fusion.Tick>)-10]");
				NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot4 = (NetworkObjectHeaderSnapshot)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X22_v4 (System.Nullable`1<Fusion.Tick>)-10]");
				if ((nint)0 == 0)
				{
					return (NetworkObjectHeaderSnapshotRef)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85F8]");
				object obj13 = 0;
				NetworkObjectHeaderSnapshot obj23 = default;
				while (true)
				{
					tick2 = (Tick)obj13;
					Tick value = ((Tick?*)tick5)->Value;
					object obj14 = obj8;
					bool flag17 = obj8 == null;
					num = unchecked((nint)null);
					if (flag17)
					{
						break;
					}
					object obj15 = value - networkObjectHeaderSnapshot4.Tick;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v5+18]");
					if ((nint)obj15 < 0)
					{
						object obj16 = obj15 & 0x80000000L;
						bool flag18 = obj16 == null;
						object obj17 = !flag18;
						if (obj17 == null)
						{
							object obj18 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v13+40]");
							tick2 = (Tick)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag19 = ex3 == null;
							num = unchecked((nint)null);
							if (flag19)
							{
								goto IL_070f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X25_v5+18]");
							bool flag20 = (nint)obj15 < 0;
							object obj19 = !flag20;
							num = unchecked((nint)null);
							if (obj19 != null)
							{
								goto IL_0701;
							}
							object obj20 = obj8 + obj15;
							object obj21 = obj20 + 32;
							obj21 = networkObjectHeaderSnapshot4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							networkObjectHeaderSnapshot4 = networkObjectHeaderSnapshot4.Next;
							bool flag21 = networkObjectHeaderSnapshot4.Next == null;
							object obj22 = !flag21;
							if (obj22 != null)
							{
								continue;
							}
						}
						else
						{
							((NetworkObjectHeaderSnapshotList*)networkObjectHeaderSnapshotList)->Remove(networkObjectHeaderSnapshot4);
							bool flag22 = (object)_simulation == null;
							num = unchecked((nint)null);
							tick2 = (Tick)networkObjectHeaderSnapshot4;
							if (flag22)
							{
								break;
							}
							_simulation.Release(ref obj23);
							bool flag23 = networkObjectHeaderSnapshot4.Next == null;
							object obj24 = !flag23;
							flag6 = false;
							networkObjectHeaderSnapshot4 = networkObjectHeaderSnapshot4.Next;
							if (obj24 != null)
							{
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
					return (NetworkObjectHeaderSnapshotRef)0;
				}
			}
		}
		goto IL_06f3;
		IL_082d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		tick4 = (Tick?)(object)0;
		num = num2;
		flag6 = (byte)num2 != 0;
		networkObjectHeaderSnapshot3 = networkObjectHeaderSnapshot;
		networkObjectHeaderSnapshotList2 = networkObjectHeaderSnapshotList;
		goto IL_087f;
		IL_061e:
		if (networkObjectHeaderSnapshot._ptr != null)
		{
			object obj26 = num2 >> 30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X24_v9+28]");
			bool flag24 = (nint)0 == 0;
			object obj27 = !flag24;
			object obj28 = ~obj27;
			bool flag25 = obj28 == null && obj26 == null;
			bool flag11 = flag25;
		}
		else
		{
			bool flag11 = false;
		}
		goto IL_082d;
		IL_0176:
		tick4 = (Tick?)(object)meta;
		networkObjectHeaderSnapshot3 = networkObjectHeaderSnapshot2;
		networkObjectHeaderSnapshotList2 = networkObjectHeaderSnapshotList;
		goto IL_087f;
		IL_0701:
		ex3 = new IndexOutOfRangeException();
		goto IL_070f;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe void AddLatestSnapshotToTimeline()
	{
		//IL_017f: Expected Obj, but got I
		//IL_0187: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		//IL_00cb: Invalid comparison between VT and I4
		//IL_0106: Expected F8, but got I4
		//IL_0227: Expected VT, but got I
		//IL_011d: Expected VT, but got I
		//IL_014d: Expected VT, but got I
		//IL_0169: Expected VT, but got I4
		Simulation simulation = _simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6BD8]");
		object obj = 0;
		nint num = (nint)simulation;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v2 (Il2CppClass<Fusion.Simulation>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X9_v2 (Il2CppClass<Fusion.Simulation>)+B0]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+130]");
		object obj5 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v5-8]");
		if (0 != (nint)obj2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkId runtimeConfig = NetworkId.RuntimeConfig;
		if (_simulation.TryGetStruct(runtimeConfig, out var meta))
		{
			ref SimulationRuntimeConfig runtimeConfigRef = ref _simulation.RuntimeConfigRef;
			double tickDeltaDouble = ((runtimeConfigRef == (SimulationRuntimeConfig)(object)0) ? 0.0 : (1.0 / (double)runtimeConfigRef));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef = (NetworkObjectHeaderSnapshotRef)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
				Tick maxBehaviourChangedTick = GetMaxBehaviourChangedTick((NetworkObjectHeaderSnapshotRef)0);
				Timeline timeline = Timeline;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X1_v5 (Fusion.NetworkObjectHeaderSnapshotRef)+20]");
				*(TimelinePoint*)(&meta) = new TimelinePoint((Tick)0, maxBehaviourChangedTick, tickDeltaDouble);
				timeline.AddPoint((TimelinePoint)0, tickDeltaDouble, allowInactiveHandling: false);
			}
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void AddLatestSnapshotToTimelineFast(double tickDelta)
	{
		//IL_0010: Expected VT, but got I
		//IL_0047: Expected VT, but got I
		//IL_0077: Expected VT, but got I
		//IL_0093: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		NetworkObjectHeaderSnapshotRef networkObjectHeaderSnapshotRef = (NetworkObjectHeaderSnapshotRef)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
			Tick maxBehaviourChangedTick = GetMaxBehaviourChangedTick((NetworkObjectHeaderSnapshotRef)0);
			Timeline timeline = Timeline;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X1_v1 (Fusion.NetworkObjectHeaderSnapshotRef)+20]");
			TimelinePoint timelinePoint = new TimelinePoint((Tick)0, maxBehaviourChangedTick, tickDelta);
			timeline.AddPoint((TimelinePoint)0, tickDelta, allowInactiveHandling: false);
		}
	}

	internal unsafe NetworkObjectHeaderSnapshot FindSnapshot(Tick tick)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected VT, but got Unknown
		//IL_01a4: Invalid comparison between VT and I4
		//IL_00d8: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0041: Expected Ref, but got VT
		//IL_0162: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got VT
		//IL_0096: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		Tick? tick2 = (Tick?)(object)(this + 96);
		NetworkObjectHeaderSnapshot result;
		if ((Tick)tick2 != (Tick)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8608]");
			object error = 0;
			ReadOnlySpan<System.__Canon> condition = (System.__Canon[])(object)_snapshotsByIndex;
			Assert.Check(condition, (string)error);
			Tick value = ((Tick?*)tick2)->Value;
			NetworkObjectHeaderSnapshot[] snapshotsByIndex = _snapshotsByIndex;
			if (_snapshotsByIndex == null)
			{
				return (NetworkObjectHeaderSnapshot)(object)new NullReferenceException();
			}
			object obj = value - tick;
			bool flag = (nint)obj < snapshotsByIndex.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = (object)_snapshotsByIndex + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+20]");
				result = (NetworkObjectHeaderSnapshot)0;
				goto IL_017d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = (NetworkObjectHeaderSnapshot)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectMeta)+50]");
		result = (NetworkObjectHeaderSnapshot)0;
		if (!flag2)
		{
			object obj4;
			do
			{
				bool flag3 = networkObjectHeaderSnapshot.Tick == tick;
				result = networkObjectHeaderSnapshot;
				if (flag3)
				{
					break;
				}
				networkObjectHeaderSnapshot = networkObjectHeaderSnapshot.Next;
				bool flag4 = networkObjectHeaderSnapshot.Next == null;
				obj4 = !flag4;
				result = networkObjectHeaderSnapshot.Next;
			}
			while (obj4 != null);
		}
		goto IL_017d;
		IL_017d:
		return result;
	}

	internal unsafe bool TryFindSnapshot(Tick tick, out NetworkObjectHeaderSnapshot snapshot)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected VT, but got Unknown
		Tick tick2 = (Tick)(tick & 0xFFFFFFFFL);
		NetworkObjectHeaderSnapshot networkObjectHeaderSnapshot = FindSnapshot(tick2);
		ref NetworkObjectHeaderSnapshot reference = ref *(NetworkObjectHeaderSnapshot*)networkObjectHeaderSnapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = networkObjectHeaderSnapshot == null;
		return !flag;
	}

	internal unsafe int* GetBehaviourPtr(NetworkBehaviour behaviour)
	{
		//IL_0010: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_0140: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool condition;
		if ((UnityEngine.Object)behaviour != (UnityEngine.Object)null)
		{
			if ((object)behaviour == null)
			{
				goto IL_0145;
			}
			object obj4 = behaviour.WordOffset - WordCount;
			bool flag2 = (nint)obj4 < 0;
			int num = behaviour.WordOffset ^ WordCount;
			int num2 = behaviour.WordOffset ^ obj4;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag2 == flag3;
			bool flag5 = !flag4;
			condition = flag5;
		}
		else
		{
			condition = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84E0]");
		object error = 0;
		Assert.Always(condition, (string)error);
		if (_ptr != null)
		{
			if ((object)behaviour != null)
			{
				return (int*)((byte*)_ptr + behaviour.WordOffset);
			}
			goto IL_0145;
		}
		return (int*)unchecked((nint)null);
		IL_0145:
		NullReferenceException ex = new NullReferenceException();
		return (int*)(nint)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static int EncodePriorityLevel(int level)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Maths.Clamp(level, 0, 4);
		return num + 1;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static int DecodePriorityLevel(int level)
	{
		return level - 1;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static bool IsIdle(int level)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = level + 1;
		bool flag = (nint)obj < 0;
		bool flag2 = !flag;
		return !flag2;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal static bool IsActive(int level)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0031: Expected I4, but got Obj
		object obj = level - 1;
		bool flag = (nint)obj < 5;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}

	internal unsafe void LinkInstance(NetworkObject instance)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8058]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8618]");
		object error2 = 0;
		bool flag = (object)instance == null;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		object obj = this + 240;
		bool condition2 = obj == null;
		Assert.Check(condition2, (string)error2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8620]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84B8]");
		object error4 = 0;
		bool condition3 = instance.Ptr == null;
		Assert.Check(condition3, (string)error3);
		bool flag2 = _ptr == null;
		bool condition4 = !flag2;
		Assert.Check(condition4, (string)error4);
		object obj2 = instance + 56;
		obj2 = this;
		instance.Ptr = _ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Instance = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal void UnlinkInstance(NetworkObject instance)
	{
		//IL_0010: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85E0]");
		object error = 0;
		object obj = this + 240;
		object obj2 = obj - (object)instance;
		bool condition = obj2 == null;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D85E8]");
		object error2 = 0;
		object obj3 = instance + 56;
		object obj4 = obj3 - (object)this;
		bool condition2 = obj4 == null;
		Assert.Check(condition2, (string)error2);
		Instance = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
