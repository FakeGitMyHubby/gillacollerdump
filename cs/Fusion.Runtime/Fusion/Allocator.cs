using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion.Statistics;
using PlayFab.ClientModels;
using Unity.Collections.LowLevel.Unsafe;

namespace Fusion;

public sealed class Allocator : Action<GetPlayerTagsResult>
{
	public sealed class EqualityComparer : _0021_00210
	{
		public bool Equals(Ptr x, Ptr y)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = x - y;
			return obj == null;
		}

		public int GetHashCode(Ptr obj)
		{
			//IL_0005: Expected I4, but got VT
			return (int)obj;
		}
	}

	private struct Block
	{
		public int Prev;

		public int Next;

		public int Bucket;

		public Ptr SegmentsFree;

		public int SegmentsUsed;

		public int SegmentsAllocated;

		public readonly int Index;

		public int AllocCount;

		public Block(int index)
		{
			SegmentsUsed = 0;
			Index = index;
			AllocCount = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E520]");
			Prev = 0;
		}

		public unsafe int SegmentsFreeCount([In] ref Allocator a)
		{
			//IL_0011: Expected Obj, but got I
			//IL_001c: Expected Obj, but got Ref
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			//IL_0148: Expected Obj, but got I4
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected Obj, but got Unknown
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Expected Obj, but got Unknown
			//IL_0086: Expected Obj, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00b1: Expected Obj, but got I4
			//IL_00d8: Expected Obj, but got I4
			//IL_00e5: Expected I4, but got Obj
			//IL_019a: Expected I4, but got Obj
			//IL_01c2: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3FB0]");
			object error = 0;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 12));
			int num = 0;
			while (obj != null)
			{
				Allocator allocator = a;
				bool flag = (object)a == null;
				int num2 = num;
				if (!flag)
				{
					Assert.Check(condition: true, (string)error);
					obj = allocator._root + obj;
					bool flag2 = (nint)allocator._heap < (nint)obj;
					object obj2 = !flag2;
					object obj3 = allocator._heap - obj;
					bool flag3 = obj3 == null;
					object obj4 = ~obj2;
					object obj5 = obj4 | flag3;
					bool condition;
					if (obj5 == null)
					{
						condition = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X27_v4 (Fusion.Allocator)+4C]");
						object obj6 = (nint)0 << (int)allocator._config;
						object obj7 = allocator._heap + obj6;
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj8 = !flag4;
						object obj9 = obj7 - obj;
						bool flag5 = obj9 == null;
						object obj10 = !flag5;
						bool flag6 = (byte)(obj8 & obj10) != 0;
						condition = flag6;
					}
					Assert.Check(condition, (int)obj);
					num2 = num + 1;
					bool flag7 = obj == null;
					object obj11 = !flag7;
					num = num2;
					if (obj11 != null)
					{
						continue;
					}
				}
				num = num2;
				throw new NullReferenceException();
			}
			return num;
		}

		public unsafe bool SegmentsFreeContains([In] ref Allocator a, Ptr ptr)
		{
			//IL_0010: Expected Obj, but got I
			//IL_010b: Invalid comparison between VT and I4
			//IL_0134: Expected Obj, but got Ref
			//IL_001d: Invalid comparison between Obj and VT
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected Obj, but got Unknown
			//IL_0178: Expected Obj, but got I4
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected Obj, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected Obj, but got Unknown
			//IL_006c: Expected Obj, but got I
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I4
			//IL_00be: Expected Obj, but got I4
			//IL_00cb: Expected I4, but got Obj
			//IL_01ca: Expected I4, but got Obj
			//IL_01e4: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3FB0]");
			object error = 0;
			bool flag = ptr == (Ptr)(object)0;
			bool condition = !flag;
			Assert.Check(condition, (string)error);
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 12));
			while (obj != null && obj != (object)ptr)
			{
				Allocator allocator = a;
				Assert.Check(condition: true, (string)error);
				obj = allocator._root + obj;
				bool flag2 = (nint)allocator._heap < (nint)obj;
				object obj2 = !flag2;
				object obj3 = allocator._heap - obj;
				bool flag3 = obj3 == null;
				object obj4 = ~obj2;
				object obj5 = obj4 | flag3;
				bool condition2;
				if (obj5 == null)
				{
					condition2 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X27_v4 (Fusion.Allocator)+4C]");
					object obj6 = (nint)0 << (int)allocator._config;
					object obj7 = allocator._heap + obj6;
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj8 = !flag4;
					object obj9 = obj7 - obj;
					bool flag5 = obj9 == null;
					object obj10 = !flag5;
					bool flag6 = (byte)(obj8 & obj10) != 0;
					condition2 = flag6;
				}
				Assert.Check(condition2, (int)obj);
				bool flag7 = obj == null;
				object obj11 = !flag7;
				if (obj11 == null)
				{
					throw new NullReferenceException();
				}
			}
			bool flag8 = obj == null;
			return !flag8;
		}

		public unsafe override string ToString()
		{
			//IL_0010: Expected Obj, but got I
			//IL_03f3: Expected Obj, but got I
			//IL_002c: Expected Obj, but got Ref
			//IL_0042: Expected I, but got Obj
			//IL_0052: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00ee: Expected Obj, but got Ref
			//IL_015f: Expected Obj, but got I8
			//IL_0104: Expected I, but got Obj
			//IL_0114: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected Obj, but got Unknown
			//IL_01c2: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_01d8: Expected I, but got Obj
			//IL_01e8: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected Obj, but got Unknown
			//IL_02c4: Expected Obj, but got Ref
			//IL_0335: Expected Obj, but got I8
			//IL_02da: Expected I, but got Obj
			//IL_02ea: Expected Obj, but got I
			//IL_0313: Expected Obj, but got I
			//IL_0362: Expected Obj, but got I
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			if (array != null)
			{
				object obj3 = default;
				bool flag = obj3 == null;
				object obj5 = default;
				object obj4 = (object)(&obj5);
				IndexOutOfRangeException ex = default;
				object obj6;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag2)
					{
						goto IL_03b3;
					}
				}
				if (array.Length != 0)
				{
					object obj7 = array + 32;
					obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj8 = default;
					bool flag3 = obj8 == null;
					object obj9 = default;
					obj4 = (object)(&obj9);
					if (!flag3)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag4)
						{
							goto IL_03b3;
						}
					}
					object obj10 = array.Length & 0xFFFFFFFEL;
					if (obj10 != null)
					{
						object obj11 = array + 40;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj12 = default;
						bool flag5 = obj12 == null;
						object obj13 = default;
						obj4 = (object)(&obj13);
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag6)
							{
								goto IL_03b3;
							}
						}
						bool flag7 = array.Length < 2;
						object obj14 = !flag7;
						object obj15 = array.Length - 2;
						bool flag8 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag8;
						if (obj17 == null)
						{
							object obj18 = array + 48;
							obj18 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj19 = default;
							bool flag9 = obj19 == null;
							object obj20 = default;
							obj4 = (object)(&obj20);
							if (!flag9)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								if (flag10)
								{
									goto IL_03b3;
								}
							}
							object obj21 = array.Length & 0xFFFFFFFCL;
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DD0]");
								object format = 0;
								object obj22 = array + 56;
								obj22 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return string.Format((string)format, array);
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				obj6 = obj4;
				goto IL_03b3;
			}
			goto IL_03cb;
			IL_03b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex2 = new ArgumentNullException();
			goto IL_03cb;
			IL_03cb:
			return (string)(object)new NullReferenceException();
		}
	}

	[StructLayout((LayoutKind)2, Size = 8)]
	private struct BlockList
	{
		[FieldOffset(0)]
		public int Head = -1;

		[FieldOffset(4)]
		public int Tail;

		public const int SIZE = default(int);

		public const int WORD_COUNT = default(int);

		internal const int BYTE_OF_HEAD = default(int);

		internal const int BYTE_COUNT_OF_HEAD = default(int);

		internal const int BYTE_OF_TAIL = default(int);

		internal const int BYTE_COUNT_OF_TAIL = default(int);

		private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

		public bool IsEmpty
		{
			get
			{
				//IL_0010: Expected Obj, but got I4
				object obj = Head + 1;
				return obj == null;
			}
		}

		public BlockList()
		{
		}

		public unsafe void AddFirst([In] ref Allocator a, ref Block item)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_01b9: Expected Obj, but got I
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			//IL_0040: Expected Obj, but got I4
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected I4, but got Unknown
			//IL_0083: Expected I4, but got I8
			//IL_009d: Expected Obj, but got I4
			//IL_022b: Expected Obj, but got I
			//IL_011e: Expected Obj, but got I4
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DB0]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DB8]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC0]");
			object error3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
			object obj = (nint)0 + (nint)1;
			bool condition = obj == null;
			Assert.Check(condition, (string)error);
			object obj2 = item + 1;
			bool condition2 = obj2 == null;
			Assert.Check(condition2, (string)error2);
			bool flag = Contains(ref a, ref item);
			object obj3 = !flag;
			bool condition3 = (byte)(1 & obj3) != 0;
			Assert.Check(condition3, (string)error3);
			ref Block reference = ref *(Block*)4294967295L;
			_ = Head;
			int num = (int)(Head & 0x80000000L);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Allocator allocator = a;
				if ((object)a != null)
				{
					Block[] blocks = allocator._blocks;
					if (allocator._blocks != null)
					{
						bool flag3 = Head < blocks.Length;
						object obj5 = !flag3;
						if (obj5 != null)
						{
							goto IL_019c;
						}
						object obj6 = allocator._blocks + Head;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
						Head = 0;
						goto IL_021b;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_019c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			Head = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			Tail = 0;
			goto IL_021b;
			IL_021b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC8]");
			object error4 = 0;
			bool condition4 = Contains(ref a, ref item);
			Assert.Check(condition4, (string)error4);
			DebugVerifyListIntegrity(ref a);
			return;
			IL_019c:
			throw new IndexOutOfRangeException();
		}

		public unsafe void AddLast([In] ref Allocator a, ref Block item)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_01b5: Expected Obj, but got I
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected Obj, but got Unknown
			//IL_0040: Expected Obj, but got I4
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected I4, but got Unknown
			//IL_0083: Expected I4, but got I8
			//IL_009d: Expected Obj, but got I4
			//IL_0227: Expected Obj, but got I
			//IL_011e: Expected Obj, but got I4
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DB0]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DB8]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC0]");
			object error3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
			object obj = (nint)0 + (nint)1;
			bool condition = obj == null;
			Assert.Check(condition, (string)error);
			object obj2 = item + 1;
			bool condition2 = obj2 == null;
			Assert.Check(condition2, (string)error2);
			bool flag = Contains(ref a, ref item);
			object obj3 = !flag;
			bool condition3 = (byte)(1 & obj3) != 0;
			Assert.Check(condition3, (string)error3);
			_ = 4294967295L;
			ref Block reference = ref *(Block*)Tail;
			int num = (int)(Tail & 0x80000000L);
			bool flag2 = num == 0;
			object obj4 = !flag2;
			int tail;
			if (obj4 == null)
			{
				Allocator allocator = a;
				if ((object)a != null)
				{
					Block[] blocks = allocator._blocks;
					if (allocator._blocks != null)
					{
						bool flag3 = Tail < blocks.Length;
						object obj5 = !flag3;
						if (obj5 != null)
						{
							goto IL_0198;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
						tail = 0;
						object obj6 = allocator._blocks + Tail;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
						_ = 0;
						goto IL_0217;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0198;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			Head = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			tail = 0;
			goto IL_0217;
			IL_0217:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC8]");
			object error4 = 0;
			Tail = tail;
			bool condition4 = Contains(ref a, ref item);
			Assert.Check(condition4, (string)error4);
			DebugVerifyListIntegrity(ref a);
			return;
			IL_0198:
			throw new IndexOutOfRangeException();
		}

		public void MoveFirst([In] ref Allocator a, ref Block item)
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC8]");
			object error = 0;
			bool condition = Contains(ref a, ref item);
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			if ((nint)0 != Head)
			{
				Remove(ref a, ref item);
				AddFirst(ref a, ref item);
			}
		}

		public void MoveLast([In] ref Allocator a, ref Block item)
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC8]");
			object error = 0;
			bool condition = Contains(ref a, ref item);
			Assert.Check(condition, (string)error);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			if ((nint)0 != Tail)
			{
				Remove(ref a, ref item);
				AddLast(ref a, ref item);
			}
		}

		public unsafe ref Block RemoveHead([In] ref Allocator a)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00de: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I4
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected Obj, but got Unknown
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected Ref, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Ref, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DA8]");
			object error = 0;
			object obj = Head + 1;
			bool flag = obj == null;
			bool condition = !flag;
			Assert.Check(condition, (string)error);
			Allocator allocator = a;
			if ((object)a != null)
			{
				Block[] blocks = allocator._blocks;
				if (allocator._blocks != null)
				{
					bool flag2 = Head < blocks.Length;
					object obj2 = !flag2;
					if (obj2 == null)
					{
						object obj3 = allocator._blocks + Head;
						Remove(ref a, ref *(Block*)(obj3 + 32));
						return ref *(Block*)(obj3 + 32);
					}
					goto IL_00c0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_00c0;
			IL_00c0:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return ref *(Block*)ex2;
		}

		public unsafe void Remove([In] ref Allocator a, ref Block item)
		{
			//IL_0010: Expected Obj, but got I
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Expected Obj, but got Unknown
			//IL_029c: Expected Obj, but got I4
			//IL_0119: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I8
			//IL_014d: Expected Obj, but got I4
			//IL_02ba: Expected Obj, but got I
			//IL_0343: Expected Obj, but got I
			//IL_0313: Expected Obj, but got I4
			//IL_031c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0321: Expected I4, but got Unknown
			//IL_020a: Expected I4, but got VT
			//IL_021a: Expected Obj, but got I
			//IL_007a: Invalid comparison between VT and I4
			//IL_008b: Expected Obj, but got I4
			//IL_01cc: Expected Obj, but got I4
			//IL_00a9: Expected Obj, but got I
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected Obj, but got Unknown
			//IL_00e7: Expected Obj, but got I8
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC8]");
			object error = 0;
			bool condition = Contains(ref a, ref item);
			Assert.Check(condition, (string)error);
			object obj = item & 0x80000000L;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj4;
			if (obj2 == null)
			{
				Allocator allocator = a;
				if ((object)a != null)
				{
					Block[] blocks = allocator._blocks;
					if (allocator._blocks != null)
					{
						bool flag2 = item < (object)blocks.Length;
						object obj3 = !flag2;
						if (obj3 != null)
						{
							goto IL_0245;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
						obj4 = 0;
						object obj5 = allocator._blocks + item;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
						object obj6 = 0 & 0x80000000L;
						if (obj6 == null)
						{
							goto IL_015b;
						}
						goto IL_02aa;
					}
				}
				goto IL_0237;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
			object obj7 = 0 & 0x80000000L;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				goto IL_015b;
			}
			goto IL_02aa;
			IL_015b:
			Allocator allocator2 = a;
			if ((object)a != null)
			{
				Block[] blocks2 = allocator2._blocks;
				if (allocator2._blocks != null)
				{
					bool flag4 = (nint)obj4 < blocks2.Length;
					object obj9 = !flag4;
					if (obj9 != null)
					{
						goto IL_0245;
					}
					object obj10 = (object)allocator2._blocks + obj4;
					_ = item;
					goto IL_02aa;
				}
			}
			goto IL_0237;
			IL_02aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
			if ((nint)0 == Tail)
			{
				Tail = (int)item;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
				obj11 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DC0]");
			object error2 = 0;
			if ((nint)obj11 == Head)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+4]");
				Head = 0;
			}
			ref Block reference = ref *(Block*)(-1);
			DebugVerifyListIntegrity(ref a);
			bool flag5 = Contains(ref a, ref item);
			object obj12 = !flag5;
			bool condition2 = (byte)(1 & obj12) != 0;
			Assert.Check(condition2, (string)error2);
			return;
			IL_0245:
			throw new IndexOutOfRangeException();
			IL_0237:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0245;
		}

		public bool Contains([In] ref Allocator a, ref Block item)
		{
			//IL_001e: Expected I4, but got I8
			//IL_0038: Expected Obj, but got I4
			//IL_0155: Expected I4, but got Obj
			//IL_00b7: Expected Obj, but got I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_0101: Expected I4, but got I8
			int num = Head;
			int num2 = (int)(Head & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			bool result;
			if (obj != null)
			{
				result = false;
			}
			else
			{
				while (true)
				{
					int num3 = num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X2 (Block&)+18]");
					bool flag2 = (nint)num3 == 0;
					result = flag2;
					if (flag2)
					{
						break;
					}
					Allocator allocator = a;
					if ((object)a != null)
					{
						Block[] blocks = allocator._blocks;
						if (allocator._blocks != null)
						{
							bool flag3 = num < blocks.Length;
							object obj2 = !flag3;
							if (obj2 == null)
							{
								object obj3 = allocator._blocks + num;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+24]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+24]");
								if (0 != 0)
								{
									result = flag2;
									break;
								}
								continue;
							}
							goto IL_0147;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					goto IL_0147;
					IL_0147:
					IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
					return (byte)(int)ex2 != 0;
				}
			}
			return result;
		}

		private unsafe void DebugVerifyListIntegrity([In] ref Allocator a)
		{
			//IL_02e6: Expected I4, but got I8
			//IL_0300: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0045: Expected Obj, but got I
			//IL_0052: Expected VT, but got Ref
			//IL_00a1: Expected Obj, but got I4
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Obj, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected Obj, but got Unknown
			//IL_00ea: Expected Obj, but got Ref
			//IL_00f2: Expected I4, but got VT
			//IL_01c9: Expected VT, but got I4
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Expected Obj, but got Unknown
			//IL_0295: Expected I4, but got I8
			//IL_017f: Expected Obj, but got I
			//IL_01f7: Expected VT, but got I4
			//IL_021c: Expected I4, but got Obj
			//IL_023a: Expected Obj, but got I
			//IL_0248: Expected I4, but got Obj
			//IL_0266: Expected VT, but got I4
			int num = Head;
			int num2 = (int)(Head & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			if (obj != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EC0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4ED0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EC8]");
			object error = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EB8]");
			object obj4 = 0;
			ref Allocator reference = ref a;
			BlockList blockList = (BlockList)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			while (true)
			{
				Allocator allocator = a;
				if ((object)a != null)
				{
					Block[] blocks = allocator._blocks;
					if (allocator._blocks != null)
					{
						bool flag2 = num < blocks.Length;
						object obj5 = !flag2;
						if (obj5 != null)
						{
							break;
						}
						object obj6 = allocator._blocks + 32;
						object obj7 = obj6 + num;
						bool flag3 = num != Head;
						string text = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						bool flag4 = (byte)(int)blockList != 0;
						if (!flag3)
						{
							text = (string)obj2;
							object obj8 = obj7 + 1;
							bool flag5 = obj8 == null;
							Assert.Check(flag5, (string)obj2);
							flag4 = flag5;
						}
						if (num == Tail)
						{
							text = (string)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v4+4]");
							object obj9 = (nint)0 + (nint)1;
							bool flag6 = obj9 == null;
							Assert.Check(flag6, (string)obj3);
							flag4 = flag6;
						}
						bool flag7 = num == Head;
						reference = ref *(Allocator*)text;
						blockList = (BlockList)flag4;
						if (!flag7)
						{
							bool flag8 = num == Tail;
							reference = ref *(Allocator*)text;
							blockList = (BlockList)flag4;
							if (!flag8)
							{
								object obj10 = ~obj7;
								bool condition = (byte)(obj10 >> 31) != 0;
								Assert.Check(condition, (string)error);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v4+4]");
								object obj11 = ~(nint)0;
								bool flag9 = (byte)(obj11 >> 31) != 0;
								Assert.Check(flag9, (string)obj4);
								reference = ref *(Allocator*)obj4;
								blockList = (BlockList)flag9;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v4+4]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X26_v4+4]");
						if (0 != 0)
						{
							return;
						}
						continue;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				break;
			}
			throw new IndexOutOfRangeException();
		}

		public override string ToString()
		{
			//IL_0010: Expected Obj, but got I
			//IL_002a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4ED8]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			object arg2 = default;
			return string.Format((string)format, arg, arg2);
		}
	}

	[StructLayout((LayoutKind)2, Size = 16)]
	private struct Bucket(int index, int stride, int wordCount, int capacity)
	{
		[FieldOffset(0)]
		public readonly int Index = index;

		[FieldOffset(4)]
		public readonly int SegmentStride = stride;

		[FieldOffset(8)]
		public readonly int SegmentWordCount = wordCount;

		[FieldOffset(12)]
		public readonly int SegmentCapacity = capacity;

		public const int SIZE = default(int);

		public const int WORD_COUNT = default(int);

		internal const int BYTE_OF_INDEX = default(int);

		internal const int BYTE_COUNT_OF_INDEX = default(int);

		internal const int BYTE_OF_SEGMENT_STRIDE = default(int);

		internal const int BYTE_COUNT_OF_SEGMENT_STRIDE = default(int);

		internal const int BYTE_OF_SEGMENT_WORD_COUNT = default(int);

		internal const int BYTE_COUNT_OF_SEGMENT_WORD_COUNT = default(int);

		internal const int BYTE_OF_SEGMENT_CAPACITY = default(int);

		internal const int BYTE_COUNT_OF_SEGMENT_CAPACITY = default(int);

		private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

		public static Bucket Create(int index, int wordCount, Config config)
		{
			//IL_0049: Expected VT, but got I4
			if (wordCount >= 1)
			{
				Config config2 = default;
				int blockWordCount = config2.BlockWordCount;
			}
			else
			{
				int blockWordCount = index;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ SYSREG+28]");
			if (num == 0)
			{
				return (Bucket)(index | wordCount);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
			Bucket result = default;
			return result;
		}

		public unsafe override string ToString()
		{
			//IL_0010: Expected Obj, but got I
			//IL_03f3: Expected Obj, but got I
			//IL_002c: Expected Obj, but got Ref
			//IL_0042: Expected I, but got Obj
			//IL_0052: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00ee: Expected Obj, but got Ref
			//IL_015f: Expected Obj, but got I8
			//IL_0104: Expected I, but got Obj
			//IL_0114: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected Obj, but got Unknown
			//IL_01c2: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_01d8: Expected I, but got Obj
			//IL_01e8: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected Obj, but got Unknown
			//IL_02c4: Expected Obj, but got Ref
			//IL_0335: Expected Obj, but got I8
			//IL_02da: Expected I, but got Obj
			//IL_02ea: Expected Obj, but got I
			//IL_0313: Expected Obj, but got I
			//IL_0362: Expected Obj, but got I
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			if (array != null)
			{
				object obj3 = default;
				bool flag = obj3 == null;
				object obj5 = default;
				object obj4 = (object)(&obj5);
				IndexOutOfRangeException ex = default;
				object obj6;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag2)
					{
						goto IL_03b3;
					}
				}
				if (array.Length != 0)
				{
					object obj7 = array + 32;
					obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj8 = default;
					bool flag3 = obj8 == null;
					object obj9 = default;
					obj4 = (object)(&obj9);
					if (!flag3)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag4)
						{
							goto IL_03b3;
						}
					}
					object obj10 = array.Length & 0xFFFFFFFEL;
					if (obj10 != null)
					{
						object obj11 = array + 40;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj12 = default;
						bool flag5 = obj12 == null;
						object obj13 = default;
						obj4 = (object)(&obj13);
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag6)
							{
								goto IL_03b3;
							}
						}
						bool flag7 = array.Length < 2;
						object obj14 = !flag7;
						object obj15 = array.Length - 2;
						bool flag8 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag8;
						if (obj17 == null)
						{
							object obj18 = array + 48;
							obj18 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj19 = default;
							bool flag9 = obj19 == null;
							object obj20 = default;
							obj4 = (object)(&obj20);
							if (!flag9)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								if (flag10)
								{
									goto IL_03b3;
								}
							}
							object obj21 = array.Length & 0xFFFFFFFCL;
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EE0]");
								object format = 0;
								object obj22 = array + 56;
								obj22 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return string.Format((string)format, array);
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				obj6 = obj4;
				goto IL_03b3;
			}
			goto IL_03cb;
			IL_03b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex2 = new ArgumentNullException();
			goto IL_03cb;
			IL_03cb:
			return (string)(object)new NullReferenceException();
		}
	}

	private static class AllocatorBucketSize
	{
		public static readonly int[] Sizes;

		static AllocatorBucketSize()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected Obj, but got Unknown
			//IL_0070: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EE8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E30]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj5 = default;
			object obj4 = obj5 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+A0]");
			object obj7 = 0;
			obj7 = obj5;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	[StructLayout((LayoutKind)2, Size = 12)]
	public struct Config
	{
		public const PageSizes DEFAULT_BLOCK_SHIFT = default(PageSizes);

		public const int DEFAULT_BLOCK_COUNT = default(int);

		[FieldOffset(0)]
		public int BlockShift;

		[FieldOffset(4)]
		public int BlockCount;

		[FieldOffset(8)]
		public int GlobalsSize;

		public const int SIZE = default(int);

		public const int WORD_COUNT = default(int);

		internal const int BYTE_OF_BLOCK_SHIFT = default(int);

		internal const int BYTE_COUNT_OF_BLOCK_SHIFT = default(int);

		internal const int BYTE_OF_BLOCK_COUNT = default(int);

		internal const int BYTE_COUNT_OF_BLOCK_COUNT = default(int);

		internal const int BYTE_OF_GLOBALS_SIZE = default(int);

		internal const int BYTE_COUNT_OF_GLOBALS_SIZE = default(int);

		private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

		public int BlockByteSize => 1 << BlockShift;

		public int BlockWordCount
		{
			get
			{
				//IL_0025: Expected Obj, but got I
				//IL_0033: Expected Obj, but got I4
				//IL_0078: Expected Obj, but got I4
				//IL_0086: Expected I4, but got Obj
				int num = BlockShift & 0x1F;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C30]");
				object error = 0;
				object obj = num - 31;
				bool flag = obj == null;
				bool condition = !flag;
				int num2 = 1 << BlockShift;
				Assert.Check(condition, (string)error);
				object obj2 = num2 + 7;
				return obj2 >> 3;
			}
		}

		public int HeapSizeUsable => BlockCount << BlockShift;

		public int HeapSizeAllocated
		{
			get
			{
				int num = BlockCount << BlockShift;
				return num + 8;
			}
		}

		public Config(PageSizes shift, int count, int globalsSize)
		{
			//IL_0010: Expected Obj, but got I
			//IL_007f: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj = 0;
			BlockShift = (int)shift;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int blockCount = Math.Max(1, count);
			BlockCount = blockCount;
			GlobalsSize = globalsSize;
		}

		public bool Equals(Config other)
		{
			//IL_000a: Invalid comparison between I4 and VT
			//IL_002f: Expected Obj, but got VT
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			if ((object)BlockShift == (object)other)
			{
				object obj = other >> 32;
				object obj2 = BlockCount - obj;
				return obj2 == null;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E88]");
				object obj2 = 0;
				if (obj == obj2)
				{
					int blockShift = BlockShift;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					if ((nint)blockShift == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
						object obj3 = (nint)0 >> 32;
						object obj4 = BlockCount - obj3;
						return obj4 == null;
					}
				}
			}
			return false;
		}

		public override int GetHashCode()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected I4, but got Unknown
			object obj = BlockShift * 397;
			return obj ^ BlockCount;
		}

		public unsafe override string ToString()
		{
			//IL_0010: Expected Obj, but got I
			//IL_07d7: Expected Obj, but got I
			//IL_002c: Expected Obj, but got Ref
			//IL_0042: Expected I, but got Obj
			//IL_0052: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00ee: Expected Obj, but got Ref
			//IL_015f: Expected Obj, but got I8
			//IL_0104: Expected I, but got Obj
			//IL_0114: Expected Obj, but got I
			//IL_013d: Expected Obj, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected Obj, but got Unknown
			//IL_01c2: Expected Obj, but got Ref
			//IL_023b: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_01d8: Expected I, but got Obj
			//IL_01e8: Expected Obj, but got I
			//IL_0211: Expected Obj, but got I
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected Obj, but got Unknown
			//IL_02c4: Expected Obj, but got Ref
			//IL_0335: Expected Obj, but got I8
			//IL_02da: Expected I, but got Obj
			//IL_02ea: Expected Obj, but got I
			//IL_0313: Expected Obj, but got I
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Expected Obj, but got Unknown
			//IL_0398: Expected Obj, but got Ref
			//IL_0411: Expected Obj, but got I4
			//IL_0421: Expected Obj, but got I4
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Expected Obj, but got Unknown
			//IL_03ae: Expected I, but got Obj
			//IL_03be: Expected Obj, but got I
			//IL_03e7: Expected Obj, but got I
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Expected Obj, but got Unknown
			//IL_04a4: Expected Obj, but got Ref
			//IL_051d: Expected Obj, but got I4
			//IL_052d: Expected Obj, but got I4
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Expected Obj, but got Unknown
			//IL_04ba: Expected I, but got Obj
			//IL_04ca: Expected Obj, but got I
			//IL_04f3: Expected Obj, but got I
			//IL_0569: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Expected Obj, but got Unknown
			//IL_05a6: Expected Obj, but got Ref
			//IL_061f: Expected Obj, but got I4
			//IL_062f: Expected Obj, but got I4
			//IL_064f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0654: Expected Obj, but got Unknown
			//IL_05bc: Expected I, but got Obj
			//IL_05cc: Expected Obj, but got I
			//IL_05f5: Expected Obj, but got I
			//IL_066b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Expected Obj, but got Unknown
			//IL_06a8: Expected Obj, but got Ref
			//IL_0719: Expected Obj, but got I8
			//IL_06be: Expected I, but got Obj
			//IL_06ce: Expected Obj, but got I
			//IL_06f7: Expected Obj, but got I
			//IL_0746: Expected Obj, but got I
			//IL_074f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0754: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			if (array != null)
			{
				object obj3 = default;
				bool flag = obj3 == null;
				object obj5 = default;
				object obj4 = (object)(&obj5);
				IndexOutOfRangeException ex = default;
				object obj6;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v41 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag2)
					{
						goto IL_0797;
					}
				}
				if (array.Length != 0)
				{
					object obj7 = array + 32;
					obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj8 = default;
					bool flag3 = obj8 == null;
					object obj9 = default;
					obj4 = (object)(&obj9);
					if (!flag3)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag4)
						{
							goto IL_0797;
						}
					}
					object obj10 = array.Length & 0xFFFFFFFEL;
					if (obj10 != null)
					{
						object obj11 = array + 40;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj12 = default;
						bool flag5 = obj12 == null;
						object obj13 = default;
						obj4 = (object)(&obj13);
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag6)
							{
								goto IL_0797;
							}
						}
						bool flag7 = array.Length < 2;
						object obj14 = !flag7;
						object obj15 = array.Length - 2;
						bool flag8 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag8;
						if (obj17 == null)
						{
							object obj18 = array + 48;
							obj18 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj19 = default;
							bool flag9 = obj19 == null;
							object obj20 = default;
							obj4 = (object)(&obj20);
							if (!flag9)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								if (flag10)
								{
									goto IL_0797;
								}
							}
							object obj21 = array.Length & 0xFFFFFFFCL;
							if (obj21 != null)
							{
								object obj22 = array + 56;
								obj22 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj23 = default;
								bool flag11 = obj23 == null;
								object obj24 = default;
								obj4 = (object)(&obj24);
								if (!flag11)
								{
									nint num5 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag12 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
									obj6 = 0;
									if (flag12)
									{
										goto IL_0797;
									}
								}
								bool flag13 = array.Length < 4;
								object obj25 = !flag13;
								object obj26 = array.Length - 4;
								bool flag14 = obj26 == null;
								object obj27 = ~obj25;
								object obj28 = obj27 | flag14;
								if (obj28 == null)
								{
									object obj29 = array + 64;
									obj29 = obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int blockWordCount = BlockWordCount;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj30 = default;
									bool flag15 = obj30 == null;
									int num6 = default;
									obj4 = (object)(&num6);
									if (!flag15)
									{
										nint num7 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
										obj4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag16 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
										obj6 = 0;
										if (flag16)
										{
											goto IL_0797;
										}
									}
									bool flag17 = array.Length < 5;
									object obj31 = !flag17;
									object obj32 = array.Length - 5;
									bool flag18 = obj32 == null;
									object obj33 = ~obj31;
									object obj34 = obj33 | flag18;
									if (obj34 == null)
									{
										object obj35 = array + 72;
										obj35 = obj30;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj36 = default;
										bool flag19 = obj36 == null;
										object obj37 = default;
										obj4 = (object)(&obj37);
										if (!flag19)
										{
											nint num8 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
											obj4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag20 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v35 (Il2CppClass<System.Object[]>)+40]");
											obj6 = 0;
											if (flag20)
											{
												goto IL_0797;
											}
										}
										bool flag21 = array.Length < 6;
										object obj38 = !flag21;
										object obj39 = array.Length - 6;
										bool flag22 = obj39 == null;
										object obj40 = ~obj38;
										object obj41 = obj40 | flag22;
										if (obj41 == null)
										{
											object obj42 = array + 80;
											obj42 = obj36;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj43 = default;
											bool flag23 = obj43 == null;
											object obj44 = default;
											obj4 = (object)(&obj44);
											if (!flag23)
											{
												nint num9 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
												obj4 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag24 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
												obj6 = 0;
												if (flag24)
												{
													goto IL_0797;
												}
											}
											object obj45 = array.Length & 0xFFFFFFF8L;
											if (obj45 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EF0]");
												object format = 0;
												object obj46 = array + 88;
												obj46 = obj43;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												return string.Format((string)format, array);
											}
										}
									}
								}
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				obj6 = obj4;
				goto IL_0797;
			}
			goto IL_07af;
			IL_0797:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
			ArgumentNullException ex2 = new ArgumentNullException();
			goto IL_07af;
			IL_07af:
			return (string)(object)new NullReferenceException();
		}
	}

	[StructLayout((LayoutKind)2, Size = 4)]
	private struct Ptr : Action<GetPlayerStatisticsResult>, _0021_00210
	{
		[FieldOffset(0)]
		public int Address;

		public const int SIZE = default(int);

		public const int WORD_COUNT = default(int);

		internal const int BYTE_OF_ADDRESS = default(int);

		internal const int BYTE_COUNT_OF_ADDRESS = default(int);

		private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

		public static Ptr Null
		{
			get
			{
				//IL_0006: Expected VT, but got I4
				return (Ptr)0;
			}
		}

		public bool Equals(Ptr other)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected Obj, but got Unknown
			object obj = Address - other;
			return obj == null;
		}

		public override bool Equals(object obj)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EF8]");
				object obj2 = 0;
				if (obj == obj2)
				{
					int address = Address;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
					object obj3 = (nint)address - (nint)0;
					return obj3 == null;
				}
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Address;
		}

		public override string ToString()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4F00]");
			object format = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object arg = default;
			return string.Format((string)format, arg);
		}

		public static implicit operator bool(Ptr a)
		{
			//IL_0009: Invalid comparison between VT and I4
			bool flag = a == (Ptr)(object)0;
			return !flag;
		}

		public static bool operator ==(Ptr a, Ptr b)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = a - b;
			return obj == null;
		}

		public static bool operator !=(Ptr a, Ptr b)
		{
			//IL_000d: Expected Obj, but got VT
			object obj = a - b;
			bool flag = obj == null;
			return !flag;
		}

		public static Ptr operator +(Ptr p, int v)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected VT, but got Unknown
			return p + v;
		}

		public static Ptr operator -(Ptr p, int v)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected VT, but got Unknown
			return p - v;
		}
	}

	private const int WORD_SHIFT = default(int);

	private const int WORD_BYTE_SIZE = default(int);

	internal const byte PATTERN = default(byte);

	public const int HEAP_ALIGNMENT = default(int);

	public const int REPLICATE_WORD_SHIFT = default(int);

	public const int REPLICATE_WORD_SIZE = default(int);

	public const int REPLICATE_WORD_ALIGN = default(int);

	public const int BUCKET_COUNT = default(int);

	public const byte BUCKET_INVALID = default(byte);

	private const int PTR_SIZE = default(int);

	private unsafe byte* _root;

	private unsafe byte* _heap;

	private readonly Block[] _blocks;

	private BlockList _blocksFreeList;

	private readonly Bucket[] _buckets;

	private readonly byte[] _bucketsMap;

	private readonly BlockList[] _bucketsLists;

	private readonly Config _config;

	private HashSet<IntPtr> _allocated;

	private const int SentinelLeadingSize = default(int);

	private const int SentinelTrailingSize = default(int);

	private const ulong SentinelLeadingPattern = default(ulong);

	private const ulong SentinelTrailingPattern = default(ulong);

	private const int BLOCK_INVALID = default(int);

	internal Config Configuration => _config;

	internal unsafe static bool Free<T>(Allocator allocator, ref T[] ptr) where T : struct
	{
		if (ptr != null)
		{
			ref T[] reference = ref *(T[]*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		bool flag = ptr == null;
		return !flag;
	}

	internal unsafe static bool Free<T>(Allocator allocator, ref T* ptr) where T : struct
	{
		//IL_0052: Expected I, but got Obj
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		ref T* reference = default;
		if (System.Runtime.CompilerServices.Unsafe.As<T*, object>(ref reference) != null)
		{
			reference = ref *(T**)null;
			if ((object)allocator == null)
			{
				NullReferenceException ex = new NullReferenceException();
				bool flag = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)1;
				NullReferenceException ex2 = ex;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					object obj2 = default;
					object obj = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj4 = default;
					object obj3 = obj4 & 1;
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v21+A0]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v5+20]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v5+20]");
						if ((nint)0 != 0)
						{
							object obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ X8_v6+1D8] (should have been resolved before IL gen)");
						}
						goto IL_0057;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj8 = obj2;
					reference = ref *(T**)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					NullReferenceException ex3 = default;
					ex2 = ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
			allocator.FreeInternal((void*)(nint)System.Runtime.CompilerServices.Unsafe.As<T*, object>(ref reference));
		}
		goto IL_0057;
		IL_0057:
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<T*, object>(ref reference) == null;
		return !flag2;
	}

	internal unsafe static T* AllocAndClearArray<T>(Allocator allocator, int length) where T : struct
	{
		//IL_004f: Expected I, but got Obj
		if ((object)allocator != null)
		{
			int size = length << 2;
			return (T*)allocator.AllocAndClear(size);
		}
		NullReferenceException ex = new NullReferenceException();
		return (T*)(nint)ex;
	}

	internal unsafe static void* AllocAndClear(Allocator allocator, int size)
	{
		//IL_0041: Expected I, but got Obj
		if ((object)allocator != null)
		{
			return allocator.AllocAndClear(size);
		}
		NullReferenceException ex = new NullReferenceException();
		return (void*)(nint)ex;
	}

	internal unsafe static T* AllocAndClear<T>(Allocator allocator) where T : struct
	{
		//IL_0063: Expected I, but got Obj
		if ((object)allocator != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3 (Il2CppClass<T>)+FC]");
			return (T*)allocator.AllocAndClear(0);
		}
		NullReferenceException ex = new NullReferenceException();
		return (T*)(nint)ex;
	}

	internal static void Dispose(Allocator allocator)
	{
		allocator.Dispose();
	}

	public unsafe string LogPointerInfo(void* p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected I, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C18]");
		object format = 0;
		IntPtr intPtr = (IntPtr)_heap;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj2 = (nint)0 << (int)_config;
		void* ptr = (void*)(nint)(_heap + obj2);
		IntPtr intPtr2 = (IntPtr)ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IntPtr intPtr3 = (IntPtr)p;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		return string.Format((string)format, arg, arg2, arg3);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe Ptr AsPtr(void* p)
	{
		//IL_00a3: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_011c: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C20]");
		object error = 0;
		bool flag = _heap < p;
		object obj = !flag;
		object obj2 = (object)(_heap - (nuint)p);
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		bool condition;
		if (obj4 == null)
		{
			condition = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj5 = (nint)0 << (int)_config;
			object obj6 = _heap + obj5;
			bool flag3 = (nint)obj6 < (nint)p;
			object obj7 = !flag3;
			object obj8 = obj6 - p;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			bool flag5 = (byte)(obj7 & obj9) != 0;
			condition = flag5;
		}
		Assert.Check(condition, (string)error);
		return (Ptr)((byte*)p - (nuint)_root);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe void* AsVoid(Ptr ptr)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ac: Invalid comparison between VT and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected I, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0096: Expected I4, but got Obj
		//IL_0144: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3FB0]");
		object error = 0;
		bool flag = ptr == (Ptr)(object)0;
		bool condition = !flag;
		Assert.Check(condition, (string)error);
		void* ptr2 = (void*)(nint)(_root + ptr);
		bool flag2 = _heap < ptr2;
		object obj = !flag2;
		object obj2 = (object)(_heap - (nuint)ptr2);
		bool flag3 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag3;
		bool condition2;
		if (obj4 == null)
		{
			condition2 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj5 = (nint)0 << (int)_config;
			object obj6 = _heap + obj5;
			bool flag4 = (nint)obj6 < (nint)ptr2;
			object obj7 = !flag4;
			object obj8 = obj6 - ptr2;
			bool flag5 = obj8 == null;
			object obj9 = !flag5;
			bool flag6 = (byte)(obj7 & obj9) != 0;
			condition2 = flag6;
		}
		Assert.Check(condition2, (int)ptr);
		return ptr2;
	}

	internal unsafe bool IsPointerInHeap(void* p)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00d6: Expected I4, but got Obj
		bool flag = _heap < p;
		object obj = !flag;
		object obj2 = (object)(_heap - (nuint)p);
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		if (obj4 == null)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj5 = (nint)0 << (int)_config;
		object obj6 = _heap + obj5;
		bool flag3 = (nint)obj6 < (nint)p;
		object obj7 = !flag3;
		object obj8 = obj6 - p;
		bool flag4 = obj8 == null;
		object obj9 = !flag4;
		return (byte)(obj7 & obj9) != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	private static int WordCount(int size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_00ab: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C30]");
		object error = 0;
		bool flag = size < 0;
		bool flag2 = size == 0;
		int num = size ^ size;
		int num2 = size & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		bool condition = (byte)((flag4 & obj) ? 1 : 0) != 0;
		Assert.Check(condition, (string)error);
		object obj2 = size + 7;
		return obj2 >> 3;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe ref Bucket GetBucket(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_00d3: Expected I4, but got Obj
		//IL_0030: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
		object error = 0;
		bool flag = index < 57;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		Bucket[] buckets = _buckets;
		if (_buckets != null)
		{
			bool flag2 = buckets.Length < index;
			object obj2 = !flag2;
			object obj3 = buckets.Length - index;
			bool flag3 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag3;
			if (obj5 == null)
			{
				object obj6 = _buckets + index;
				return ref *(Bucket*)(obj6 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(Bucket*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe ref Bucket GetBucketForBlock(ref Block block)
	{
		//IL_009e: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00b7: Expected I4, but got Obj
		//IL_0028: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X1 (Block&)+8]");
		bool flag = (nint)0 < (nint)57;
		object obj = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
		object error = 0;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		Bucket[] buckets = _buckets;
		if (_buckets != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X1 (Block&)+8]");
			bool flag2 = (nint)0 < (nint)buckets.Length;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				Bucket[] buckets2 = _buckets;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X1 (Block&)+8]");
				object obj3 = buckets2 + 0;
				return ref *(Bucket*)(obj3 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(Bucket*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe ref BlockList GetBucketList(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I4
		//IL_00d3: Expected I4, but got Obj
		//IL_0030: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
		object error = 0;
		bool flag = index < 57;
		object obj = !flag;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		BlockList[] bucketsLists = _bucketsLists;
		if (_bucketsLists != null)
		{
			bool flag2 = bucketsLists.Length < index;
			object obj2 = !flag2;
			object obj3 = bucketsLists.Length - index;
			bool flag3 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag3;
			if (obj5 == null)
			{
				object obj6 = _bucketsLists + index;
				return ref *(BlockList*)(obj6 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(BlockList*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe ref Block GetBlock(int index)
	{
		//IL_016a: Expected Obj, but got I
		//IL_017c: Expected I4, but got I8
		//IL_0196: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I4, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C40]");
		object error = 0;
		int num = (int)(index & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		bool condition;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj2 = -index;
			bool flag2 = (nint)obj2 < 0;
			bool flag3 = obj2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			int num2 = (int)((nint)0 ^ (nint)index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj3 = 0 ^ obj2;
			int num3 = num2 & obj3;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			condition = flag6;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		Block[] blocks = _blocks;
		if (_blocks != null)
		{
			bool flag7 = blocks.Length < index;
			object obj5 = !flag7;
			object obj6 = blocks.Length - index;
			bool flag8 = obj6 == null;
			object obj7 = ~obj5;
			object obj8 = obj7 | flag8;
			if (obj8 == null)
			{
				object obj9 = _blocks + index;
				return ref *(Block*)(obj9 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(Block*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe ref Block GetBlock(long index)
	{
		//IL_0136: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got I8
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I8, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C40]");
		object error = 0;
		long num = index & -9223372036854775808L;
		bool flag = num == 0;
		object obj = !flag;
		bool condition;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj2 = -index;
			bool flag2 = (nint)obj2 < 0;
			bool flag3 = obj2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			long num2 = 0 ^ index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj3 = 0 ^ obj2;
			long num3 = num2 & obj3;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			condition = flag6;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		Block[] blocks = _blocks;
		if (_blocks != null)
		{
			bool flag7 = index < blocks.Length;
			object obj5 = !flag7;
			if (obj5 == null)
			{
				object obj6 = _blocks + index;
				return ref *(Block*)(obj6 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(Block*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private int GetBlockBucket(long index)
	{
		//IL_0130: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got I8
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I8, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_0120: Expected I4, but got Obj
		//IL_00da: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C40]");
		object error = 0;
		long num = index & -9223372036854775808L;
		bool flag = num == 0;
		object obj = !flag;
		bool condition;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj2 = -index;
			bool flag2 = (nint)obj2 < 0;
			bool flag3 = obj2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			long num2 = 0 ^ index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj3 = 0 ^ obj2;
			long num3 = num2 & obj3;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			condition = flag6;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		Block[] blocks = _blocks;
		if (_blocks != null)
		{
			bool flag7 = index < blocks.Length;
			object obj5 = !flag7;
			if (obj5 == null)
			{
				object obj6 = _blocks + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6+28]");
				return 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (int)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe ref Block GetBlockForPointer(void* ptr)
	{
		//IL_0151: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_018c: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_01ea: Expected Obj, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected I4, but got Unknown
		//IL_0222: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C68]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C70]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C60]");
		object error3 = 0;
		bool flag = _heap < ptr;
		object obj = !flag;
		object obj2 = (object)(_heap - (nuint)ptr);
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		bool condition;
		if (obj4 == null)
		{
			condition = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj5 = (nint)0 << (int)_config;
			object obj6 = _heap + obj5;
			bool flag3 = (nint)obj6 < (nint)ptr;
			object obj7 = !flag3;
			object obj8 = obj6 - ptr;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			bool flag5 = (byte)(obj7 & obj9) != 0;
			condition = flag5;
		}
		Assert.Check(condition, (string)error);
		object obj10 = (object)((byte*)ptr - (nuint)_heap);
		object obj11 = obj10 >> 63;
		bool condition2 = (byte)(obj11 ^ 1) != 0;
		Assert.Check(condition2, (string)error2);
		object obj12 = (object)((byte*)ptr - (nuint)_heap);
		object obj13 = obj12 >> (int)_config;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj14 = obj13 - 0;
		bool flag6 = (nint)obj14 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj15 = obj13 ^ 0;
		object obj16 = obj13 ^ obj14;
		object obj17 = obj15 & obj16;
		bool flag7 = (nint)obj17 < 0;
		bool flag8 = flag6 == flag7;
		bool condition3 = !flag8;
		Assert.Check(condition3, (string)error3);
		Block[] blocks = _blocks;
		if (_blocks != null)
		{
			object obj18 = (object)((byte*)ptr - (nuint)_heap);
			object obj19 = obj18 >> (int)_config;
			bool flag9 = (nint)obj19 < blocks.Length;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				object obj21 = (object)_blocks + obj19;
				return ref *(Block*)(obj21 + 32);
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return ref *(Block*)ex2;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe int GetBlockIndexForPointer(void* ptr)
	{
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_0086: Expected I4, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected I4, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		//IL_00b1: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C68]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C70]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C60]");
		object error3 = 0;
		bool flag = _heap < ptr;
		object obj = !flag;
		object obj2 = (object)(_heap - (nuint)ptr);
		bool flag2 = obj2 == null;
		object obj3 = ~obj;
		object obj4 = obj3 | flag2;
		bool condition;
		if (obj4 == null)
		{
			condition = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj5 = (nint)0 << (int)_config;
			object obj6 = _heap + obj5;
			bool flag3 = (nint)obj6 < (nint)ptr;
			object obj7 = !flag3;
			object obj8 = obj6 - ptr;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			bool flag5 = (byte)(obj7 & obj9) != 0;
			condition = flag5;
		}
		Assert.Check(condition, (string)error);
		object obj10 = (object)((byte*)ptr - (nuint)_heap);
		object obj11 = obj10 >> 63;
		bool condition2 = (byte)(obj11 ^ 1) != 0;
		Assert.Check(condition2, (string)error2);
		object obj12 = (object)((byte*)ptr - (nuint)_heap);
		object obj13 = obj12 >> (int)_config;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj14 = obj13 - 0;
		bool flag6 = (nint)obj14 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj15 = obj13 ^ 0;
		object obj16 = obj13 ^ obj14;
		object obj17 = obj15 & obj16;
		bool flag7 = (nint)obj17 < 0;
		bool flag8 = flag6 == flag7;
		bool condition3 = !flag8;
		Assert.Check(condition3, (string)error3);
		object obj18 = (object)((byte*)ptr - (nuint)_heap);
		return obj18 >> (int)_config;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe byte* GetBlockMemory(ref Block block)
	{
		//IL_0017: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X1 (Block&)+18]");
		object obj = (nint)0 << (int)_config;
		return (byte*)(nint)(_heap + obj);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe byte* GetBlockMemory(long blockIndex)
	{
		//IL_00cf: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected I, but got Unknown
		//IL_001a: Expected Obj, but got I8
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I8, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C78]");
		object error = 0;
		long num = blockIndex & -9223372036854775808L;
		bool flag = num == 0;
		object obj = !flag;
		bool condition;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj2 = -blockIndex;
			bool flag2 = (nint)obj2 < 0;
			bool flag3 = obj2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			long num2 = 0 ^ blockIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj3 = 0 ^ obj2;
			long num3 = num2 & obj3;
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			condition = flag6;
		}
		else
		{
			condition = false;
		}
		Assert.Check(condition, (string)error);
		object obj5 = 1 << (int)_config;
		object obj6 = obj5 * blockIndex;
		return (byte*)(nint)(_heap + obj6);
	}

	internal unsafe bool TryGetSegmentRoot(void* ptr, out void* root, out long segmentIndex)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I
		//IL_0519: Expected I4, but got Obj
		//IL_0261: Expected Obj, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I4
		//IL_0574: Expected Obj, but got I
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_040e: Expected Obj, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_04a0: Expected Obj, but got I4
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		bool flag = _heap < ptr;
		object obj = !flag;
		object obj2 = (object)(_heap - (nuint)ptr);
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		object obj12;
		bool condition;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj5 = (nint)0 << (int)_config;
			object obj6 = _heap + obj5;
			bool flag3 = (nint)obj6 < (nint)ptr;
			object obj7 = !flag3;
			object obj8 = obj6 - ptr;
			bool flag4 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag4;
			if (obj10 == null)
			{
				object obj11 = (object)((byte*)ptr - (nuint)_heap);
				obj12 = obj11 >> (int)_config;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEE0E]");
				if ((nint)0 != 0)
				{
					object obj13 = obj12 & -9223372036854775808L;
					bool flag5 = obj13 == null;
					object obj14 = !flag5;
					if (obj14 == null)
					{
						goto IL_015b;
					}
				}
				else
				{
					_ = 1;
					object obj15 = obj12 & -9223372036854775808L;
					if (obj15 == null)
					{
						goto IL_015b;
					}
				}
				condition = false;
				goto IL_0519;
			}
		}
		ref void* reference = ref *(void**)null;
		ref long reference2 = ref *(long*)null;
		return false;
		IL_0519:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C40]");
		object error = 0;
		Assert.Check(condition, (string)error);
		Block[] blocks = _blocks;
		if (_blocks == null)
		{
			goto IL_04fd;
		}
		bool flag6 = (nint)obj12 < blocks.Length;
		object obj16 = !flag6;
		if (obj16 != null)
		{
			goto IL_050b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEE0F]");
		if ((nint)0 != 0)
		{
			object obj17 = obj12 & -9223372036854775808L;
			bool flag7 = obj17 == null;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				goto IL_02ce;
			}
		}
		else
		{
			_ = 1;
			object obj19 = obj12 & -9223372036854775808L;
			if (obj19 == null)
			{
				goto IL_02ce;
			}
		}
		bool condition2 = false;
		goto IL_0564;
		IL_015b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj20 = obj12 - 0;
		bool flag8 = (nint)obj20 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj21 = obj12 ^ 0;
		object obj22 = obj12 ^ obj20;
		object obj23 = obj21 & obj22;
		bool flag9 = (nint)obj23 < 0;
		bool flag10 = flag8 == flag9;
		bool flag11 = !flag10;
		condition = flag11;
		goto IL_0519;
		IL_0564:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C78]");
		object error2 = 0;
		Assert.Check(condition2, (string)error2);
		Bucket[] buckets = _buckets;
		if (_buckets == null)
		{
			goto IL_04fd;
		}
		object obj24 = _blocks + 32;
		object obj25 = obj24 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+8]");
		bool flag12 = (nint)0 < (nint)buckets.Length;
		object obj26 = !flag12;
		if (obj26 == null)
		{
			Bucket[] buckets2 = _buckets;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+8]");
			object obj27 = buckets2 + 0;
			object obj28 = 1 << (int)_config;
			object obj29 = obj12 * obj28;
			object obj30 = _heap + obj29;
			object obj31 = ptr - obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X9_v7+24]");
			object obj32 = obj31 / 0;
			reference2 = ref *(long*)obj32;
			Bucket[] buckets3 = _buckets;
			if (_buckets == null)
			{
				goto IL_04fd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+8]");
			bool flag13 = (nint)0 < (nint)buckets3.Length;
			object obj33 = !flag13;
			if (obj33 == null)
			{
				Bucket[] buckets4 = _buckets;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v15+8]");
				object obj34 = buckets4 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v17+24]");
				object obj35 = obj32 * 0;
				object obj36 = obj30 + obj35;
				reference = ref *(void**)obj36;
				return true;
			}
		}
		goto IL_050b;
		IL_04fd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_050b;
		IL_050b:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_02ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj37 = obj12 - 0;
		bool flag14 = (nint)obj37 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj38 = obj12 ^ 0;
		object obj39 = obj12 ^ obj37;
		object obj40 = obj38 & obj39;
		bool flag15 = (nint)obj40 < 0;
		bool flag16 = flag14 == flag15;
		bool flag17 = !flag16;
		condition2 = flag17;
		goto IL_0564;
	}

	internal unsafe void* GetSegmentRoot(void* ptr)
	{
		//IL_001f: Expected Obj, but got I
		//IL_002d: Expected I, but got Obj
		//IL_000a: Expected I, but got Obj
		if (TryGetSegmentRoot(ptr, out var _, out var _))
		{
			return (void*)unchecked((nint)null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C80]");
		object error = 0;
		Assert.AlwaysFail((string)error);
		return (void*)unchecked((nint)null);
	}

	internal unsafe T* AllocArray<T>(int length) where T : struct
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3 (Il2CppClass<T>)+FC]");
		int size = (int)((nint)0 * (nint)length);
		return (T*)Alloc(size);
	}

	internal unsafe T* AllocAndClearArray<T>(int length) where T : struct
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v3 (Il2CppClass<T>)+FC]");
		int size = (int)((nint)0 * (nint)length);
		return (T*)AllocAndClear(size);
	}

	internal unsafe T* Alloc<T>() where T : struct
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v3 (Il2CppClass<T>)+FC]");
		return (T*)Alloc(0);
	}

	internal unsafe T* AllocAndClear<T>() where T : struct
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v3 (Il2CppClass<T>)+FC]");
		return (T*)AllocAndClear(0);
	}

	internal unsafe void* AllocAndClear(int size)
	{
		//IL_00af: Expected I8, but got I4
		void* ptr = Alloc(size);
		if (size != 0)
		{
			bool flag = size >> 30 != 0 || ptr == null;
			bool condition = !flag;
			Assert.Always(condition, (nint)ptr, size);
			UnsafeUtility.MemClear(ptr, size);
		}
		return ptr;
	}

	internal unsafe void GetMemorySnapshot(ref FusionAllocatorMemorySnapshot snapshot)
	{
		//IL_070b: Expected Obj, but got Ref
		//IL_0725: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got Ref
		//IL_005e: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got Ref
		//IL_00c5: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0112: Expected Obj, but got Ref
		//IL_012c: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I
		//IL_0179: Expected Obj, but got Ref
		//IL_0193: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected Obj, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_07c5: Expected Obj, but got I4
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected I4, but got Unknown
		//IL_0311: Expected Obj, but got I4
		//IL_0244: Invalid comparison between VT and I4
		//IL_0255: Expected Obj, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I4
		//IL_028f: Expected VT, but got I
		//IL_02a9: Expected Obj, but got I8
		//IL_033f: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I8
		//IL_03ab: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I4
		//IL_04af: Expected Obj, but got I4
		//IL_04b8: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I4
		//IL_03e6: Expected Obj, but got I4
		//IL_04de: Expected Obj, but got I4
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected Obj, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected Obj, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_08bf: Expected Obj, but got I4
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected I4, but got Unknown
		//IL_0406: Expected Obj, but got I4
		//IL_052c: Expected Obj, but got I4
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected VT, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_08f5: Expected Ref, but got VT
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_0916: Expected Obj, but got I
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		//IL_095a: Expected Obj, but got I8
		//IL_057a: Expected Obj, but got I4
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I4
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected Obj, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected Obj, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06c7: Expected Obj, but got I
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref snapshot, 16));
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj4 = default;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref snapshot, 24));
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj8 = default;
			obj5 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref snapshot, 32));
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj12 = default;
			obj9 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj13 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref snapshot, 40));
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj16 = default;
			obj13 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref snapshot, 48));
		bool flag5 = obj17 == null;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj20 = default;
			obj17 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		ref FusionAllocatorMemorySnapshot reference = ref *(FusionAllocatorMemorySnapshot*)null;
		BlockList blockList = _blocksFreeList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C40]");
		object error = 0;
		object obj21 = _blocksFreeList & 0x80000000L;
		bool flag6 = obj21 == null;
		object obj22 = !flag6;
		object obj23 = 0;
		if (obj22 != null)
		{
			goto IL_02c6;
		}
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj24 = 0 - blockList;
			bool flag7 = (nint)obj24 < 0;
			bool flag8 = obj24 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj25 = 0 ^ blockList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj26 = 0 ^ obj24;
			object obj27 = obj25 & obj26;
			bool flag9 = (nint)obj27 < 0;
			bool flag10 = flag7 == flag9;
			object obj28 = !flag8;
			bool condition = (byte)((flag10 & obj28) ? 1 : 0) != 0;
			Assert.Check(condition, (string)error);
			Block[] blocks = _blocks;
			bool flag11 = blockList < (object)blocks.Length;
			object obj29 = !flag11;
			if (obj29 != null)
			{
				break;
			}
			object obj30 = blocks + blockList;
			obj23 = 0 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v58+24]");
			blockList = (BlockList)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v58+24]");
			object obj31 = 0 & 0x80000000L;
			if (obj31 != null)
			{
				goto IL_02c6;
			}
		}
		goto IL_06e8;
		IL_06e8:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_02c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
		object error2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		_ = 0;
		object obj32 = 0;
		Allocator a = default;
		while (true)
		{
			Assert.Check(condition: true, (string)error2);
			Bucket[] buckets = _buckets;
			bool flag12 = (nint)obj32 < buckets.Length;
			object obj33 = !flag12;
			if (obj33 != null)
			{
				break;
			}
			Assert.Check(condition: true, (string)error2);
			BlockList[] bucketsLists = _bucketsLists;
			bool flag13 = (nint)obj32 < bucketsLists.Length;
			object obj34 = !flag13;
			if (obj34 != null)
			{
				break;
			}
			object obj35 = (object)bucketsLists + obj32;
			object obj36 = (object)buckets + obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v26+20]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v26+20]");
			object obj38 = 0 & 0x80000000L;
			bool flag14 = obj38 == null;
			object obj39 = !flag14;
			object obj42;
			object obj40;
			object obj41;
			object obj43;
			object obj44;
			if (obj39 == null)
			{
				obj40 = 0;
				obj41 = 0;
				obj42 = 0;
				obj43 = 0;
				obj44 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
					object obj45 = 0 - obj37;
					bool flag15 = (nint)obj45 < 0;
					bool flag16 = obj45 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
					object obj46 = 0 ^ obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
					object obj47 = 0 ^ obj45;
					object obj48 = obj46 & obj47;
					bool flag17 = (nint)obj48 < 0;
					bool flag18 = flag15 == flag17;
					object obj28 = !flag16;
					bool condition2 = (byte)((flag18 & obj28) ? 1 : 0) != 0;
					Assert.Check(condition2, (string)error);
					Block[] blocks2 = _blocks;
					bool flag19 = (nint)obj37 < blocks2.Length;
					object obj49 = !flag19;
					if (obj49 != null)
					{
						break;
					}
					object obj50 = (object)blocks2 + obj37;
					Block block = (Block)(obj50 + 32);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X21_v14+34]");
					obj42 = 0 + obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X21_v14+30]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X22_v5+2C]");
					if (num == 0)
					{
						obj44++;
					}
					int num2 = ((Block*)block)->SegmentsFreeCount(ref a);
					obj41 = num2 + obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X21_v14+24]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X21_v14+30]");
					obj43 = 0 + obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X22_v5+2C]");
					obj40 = 0 + obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X21_v14+24]");
					object obj51 = 0 & 0x80000000L;
					if (obj51 != null)
					{
						goto IL_097c;
					}
				}
				break;
			}
			obj40 = 0;
			obj41 = 0;
			obj42 = 0;
			obj43 = 0;
			obj44 = 0;
			goto IL_097c;
			IL_097c:
			object obj52 = obj;
			object obj53 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v29+18]");
			bool flag20 = (nint)obj53 < 0;
			object obj54 = !flag20;
			if (obj54 != null)
			{
				break;
			}
			object obj55 = obj52 + obj32;
			object obj56 = obj5;
			object obj57 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v31+18]");
			bool flag21 = (nint)obj57 < 0;
			object obj58 = !flag21;
			if (obj58 != null)
			{
				break;
			}
			object obj59 = obj56 + obj32;
			object obj60 = obj9;
			object obj61 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v33+18]");
			bool flag22 = (nint)obj61 < 0;
			object obj62 = !flag22;
			if (obj62 != null)
			{
				break;
			}
			object obj63 = obj60 + obj32;
			object obj64 = obj13;
			object obj65 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v35+18]");
			bool flag23 = (nint)obj65 < 0;
			object obj66 = !flag23;
			if (obj66 != null)
			{
				break;
			}
			object obj67 = obj64 + obj32;
			object obj68 = obj17;
			object obj69 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v37+18]");
			bool flag24 = (nint)obj69 < 0;
			object obj70 = !flag24;
			if (obj70 != null)
			{
				break;
			}
			object obj71 = obj68 + obj32;
			obj32++;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X22_v5+24]");
			object obj72 = 0 * obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [snapshot @ X1 (Fusion.Statistics.FusionAllocatorMemorySnapshot&)+4]");
			object obj73 = 0 + obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X22_v5+2C]");
			object obj74 = 0 - obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X22_v5+24]");
			object obj75 = 0 * obj74;
			object obj76 = snapshot + obj75;
			reference = ref *(FusionAllocatorMemorySnapshot*)obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
			error2 = 0;
			if ((nint)obj32 == 57)
			{
				return;
			}
		}
		goto IL_06e8;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal bool CanAllocSize(int size)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected I4, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		//IL_00a7: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		if (size >= 1)
		{
			object obj = 1 << (int)_config;
			object obj2 = obj - size;
			bool flag = (nint)obj2 < 0;
			bool flag2 = obj2 == null;
			int num = obj ^ size;
			object obj3 = obj ^ obj2;
			int num2 = num & obj3;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			return (byte)((flag4 & obj4) ? 1 : 0) != 0;
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal int ValidateSentinels()
	{
		return 0;
	}

	internal unsafe bool ValidatePointer(void* ptr, out string error)
	{
		//IL_0252: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected I, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_0237: Expected I4, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		bool flag = _heap < ptr;
		object obj = !flag;
		object obj2 = (object)(_heap - (nuint)ptr);
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		ref string reference;
		object obj12;
		object obj13;
		string text;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
			object obj5 = (nint)0 << (int)_config;
			object obj6 = _heap + obj5;
			bool flag3 = (nint)obj6 < (nint)ptr;
			object obj7 = !flag3;
			object obj8 = obj6 - ptr;
			bool flag4 = obj8 == null;
			object obj9 = ~obj7;
			object obj10 = obj9 | flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3094F88");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj11 = 0;
				text = (string)obj11;
				if (obj11 != null)
				{
					if (text._stringLength >= 1)
					{
						reference = ref *(string*)obj11;
						IntPtr intPtr = default;
						obj12 = (nint)intPtr;
						obj13 = null;
						goto IL_0296;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v20+98]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v21+A0]");
					object obj16 = 0;
					reference = ref *(string*)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return true;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D20]");
		object format = 0;
		IntPtr intPtr2 = (IntPtr)ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IntPtr intPtr3 = (IntPtr)_heap;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
		object obj18 = (nint)0 << (int)_config;
		void* ptr2 = (void*)(nint)(_heap + obj18);
		IntPtr intPtr4 = (IntPtr)ptr2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		object arg = default;
		object obj19 = default;
		object obj20 = default;
		string text2 = string.Format((string)format, arg, obj19, obj20);
		reference = ref *(string*)text2;
		obj12 = obj20;
		obj13 = obj19;
		text = text2;
		goto IL_0296;
		IL_0296:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return false;
	}

	private unsafe void* Alloc(int size)
	{
		//IL_0aca: Expected Obj, but got I
		//IL_0b44: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0c38: Expected VT, but got I
		//IL_0c4b: Expected Obj, but got I4
		//IL_0c59: Expected Obj, but got I4
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Expected Obj, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected Obj, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Expected I4, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected I4, but got Unknown
		//IL_0cfa: Expected Obj, but got I4
		//IL_0d10: Expected I, but got Obj
		//IL_0d19: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_0103: Expected I4, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_04e5: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0542: Expected I, but got Obj
		//IL_0d86: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I4
		//IL_01e6: Expected I, but got Obj
		//IL_0df3: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I4
		//IL_024a: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected I4, but got Unknown
		//IL_02e1: Expected Obj, but got I
		//IL_0e11: Expected Obj, but got I
		//IL_0e81: Expected Obj, but got I
		//IL_0eac: Expected VT, but got I
		//IL_0ec6: Expected Obj, but got I8
		//IL_0ee0: Expected Obj, but got I4
		//IL_0eee: Expected I, but got Obj
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_044c: Expected Obj, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected VT, but got Unknown
		//IL_058f: Expected Ref, but got VT
		//IL_05a3: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_0f19: Expected Obj, but got I
		//IL_0f54: Expected Obj, but got I
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f69: Expected Obj, but got Unknown
		//IL_0f95: Expected Obj, but got I
		//IL_0fae: Expected Obj, but got I4
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected I4, but got Unknown
		//IL_1009: Expected I, but got Obj
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_066b: Expected Obj, but got I
		//IL_068e: Expected Obj, but got I
		//IL_06ad: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_06f4: Expected Obj, but got I
		//IL_071d: Expected VT, but got Obj
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected Ref, but got Unknown
		//IL_0746: Expected Ref, but got VT
		//IL_0329: Expected Obj, but got I4
		//IL_034f: Expected I, but got Obj
		//IL_0760: Expected I4, but got Obj
		//IL_0b72: Expected Obj, but got I
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_037c: Expected I4, but got Obj
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Ref, but got Unknown
		//IL_03cf: Expected Obj, but got I4
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07bf: Expected Obj, but got I
		//IL_092d: Expected Obj, but got I4
		//IL_093c: Expected Obj, but got I
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_0850: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I4
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected I4, but got Unknown
		//IL_08a4: Expected Obj, but got I4
		//IL_08b9: Expected Obj, but got I
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected Obj, but got Unknown
		//IL_0a38: Expected Obj, but got I
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected Obj, but got Unknown
		//IL_0a60: Expected Obj, but got I4
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0a87: Expected Obj, but got I4
		//IL_0a94: Expected I4, but got Obj
		//IL_0be0: Expected I4, but got Obj
		//IL_0bee: Expected I, but got Obj
		//IL_099a: Expected Obj, but got I
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Obj, but got Unknown
		//IL_09c8: Expected Obj, but got I4
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_09f4: Expected Obj, but got I
		//IL_09ff: Expected Obj, but got I4
		//IL_0a0c: Expected I4, but got Obj
		//IL_1048: Expected Obj, but got I
		//IL_10a0: Expected Obj, but got I
		//IL_10b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b5: Expected Obj, but got Unknown
		//IL_10d4: Expected Obj, but got I
		//IL_10ed: Expected Obj, but got I4
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected I4, but got Unknown
		//IL_08fc: Expected Obj, but got I
		ref Block reference2;
		BlockList[] array;
		int num10 = default;
		nint num6;
		string text;
		InvalidOperationException ex;
		if (size >= 1)
		{
			int num = 1 << (int)_config;
			if (num > size)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C88]");
				object error = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C30]");
				BlockList blockList = (BlockList)0;
				Assert.Check(condition: true, (string)blockList.Head);
				array = (BlockList[])(size + 7);
				object obj = array & 0xFFFFFFF8L;
				object obj2 = obj - size;
				bool flag = (nint)obj2 < 0;
				int num2 = obj ^ size;
				object obj3 = obj ^ obj2;
				int num3 = num2 & obj3;
				bool flag2 = num3 < 0;
				bool condition = flag == flag2;
				Assert.Check(condition, (string)error);
				byte[] bucketsMap = _bucketsMap;
				Assert.Check(condition: true, (string)blockList.Head);
				bool flag3 = _bucketsMap == null;
				nint num4 = unchecked((nint)null);
				object obj4 = 109895680;
				if (!flag3)
				{
					obj4 = (object)array >> 3;
					bool flag4 = (nint)obj4 < bucketsMap.Length;
					object obj5 = !flag4;
					num4 = unchecked((nint)null);
					if (obj5 != null)
					{
						goto IL_0aa1;
					}
					object obj6 = (object)_bucketsMap + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+20]");
					int num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+20]");
					bool flag5 = (nint)0 < (nint)56;
					object obj7 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+20]");
					object obj8 = -56;
					bool flag6 = obj8 == null;
					object obj9 = !flag6;
					bool flag7 = (byte)(obj7 & obj9) != 0;
					num6 = unchecked((nint)null);
					if (flag7)
					{
						goto IL_04d5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+20]");
					int num7 = (int)((nint)0 << 4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+20]");
					int num8 = (int)((nint)0 << 3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
					object error2 = 0;
					object obj10 = num7 + 40;
					object obj11 = num8 + 32;
					object obj13 = default;
					object obj12 = obj13;
					int num9 = num10;
					BlockList blockList2 = blockList;
					condition = flag7;
					Allocator a = default;
					object obj52 = default;
					while (true)
					{
						DebugVerifyBucketIntegrity(num5);
						Assert.Check(condition: true, (string)error2);
						Bucket[] buckets = _buckets;
						bool flag8 = _buckets == null;
						obj13 = obj12;
						num10 = num9;
						blockList = blockList2;
						ref Block reference = ref *(Block*)109895680;
						object obj14 = obj11;
						object obj15 = obj10;
						num4 = unchecked((nint)null);
						if (flag8)
						{
							break;
						}
						bool flag9 = num5 < buckets.Length;
						object obj16 = !flag9;
						obj13 = obj12;
						num10 = num9;
						blockList = blockList2;
						reference = ref *(Block*)109895680;
						obj14 = obj11;
						obj15 = obj10;
						num4 = unchecked((nint)null);
						object error8;
						void* result;
						bool condition5;
						if (obj16 == null)
						{
							Assert.Check(condition: true, (string)error2);
							array = _bucketsLists;
							bool flag10 = _bucketsLists == null;
							obj13 = obj12;
							num10 = num9;
							blockList = blockList2;
							reference = ref *(Block*)109895680;
							obj14 = obj11;
							obj15 = obj10;
							num4 = unchecked((nint)null);
							if (flag10)
							{
								break;
							}
							bool flag11 = num5 < array.Length;
							object obj17 = !flag11;
							obj13 = obj12;
							num10 = num9;
							blockList = blockList2;
							reference = ref *(Block*)109895680;
							obj14 = obj11;
							obj15 = obj10;
							num4 = unchecked((nint)null);
							if (obj17 == null)
							{
								object obj18 = (object)_buckets + obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X25_v13-4]");
								object obj19 = -size;
								bool flag12 = (nint)obj19 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X25_v13-4]");
								int num11 = (int)((nint)0 ^ (nint)size);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X25_v13-4]");
								object obj20 = 0 ^ obj19;
								int num12 = num11 & obj20;
								bool flag13 = num12 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CE0]");
								object error3 = 0;
								bool condition2 = flag12 == flag13;
								Assert.Check(condition2, (string)error3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C30]");
								object error4 = 0;
								Assert.Check(condition: true, (string)error4);
								object obj21 = obj18 - obj4;
								bool flag14 = (nint)obj21 < 0;
								object obj22 = obj18 ^ obj4;
								object obj23 = obj18 ^ obj21;
								object obj24 = obj22 & obj23;
								bool flag15 = (nint)obj24 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CD8]");
								object error5 = 0;
								bool condition3 = flag14 == flag15;
								Assert.Check(condition3, (string)error5);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X21_v7 (BlockList[])+v260 @ X27_v10]");
								blockList = (BlockList)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X21_v7 (BlockList[])+v260 @ X27_v10]");
								object obj25 = 0 & 0x80000000L;
								bool flag16 = obj25 == null;
								object obj26 = !flag16;
								reference = ref *(Block*)109895680;
								num6 = unchecked((nint)null);
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
									nint num13 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X21_v7 (BlockList[])+v260 @ X27_v10]");
									object obj27 = num13 - 0;
									bool flag17 = (nint)obj27 < 0;
									bool flag18 = obj27 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
									nint num14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X21_v7 (BlockList[])+v260 @ X27_v10]");
									object obj28 = num14 ^ 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
									object obj29 = 0 ^ obj27;
									object obj30 = obj28 & obj29;
									bool flag19 = (nint)obj30 < 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C40]");
									object error6 = 0;
									bool flag20 = flag17 == flag19;
									obj13 = !flag18;
									condition = (byte)((flag20 & obj13) ? 1 : 0) != 0;
									Assert.Check(condition, (string)error6);
									Block[] blocks = _blocks;
									bool flag21 = _blocks == null;
									num10 = num9;
									reference = ref *(Block*)109895680;
									obj14 = obj11;
									obj15 = obj10;
									num4 = unchecked((nint)null);
									if (flag21)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X21_v7 (BlockList[])+v260 @ X27_v10]");
									bool flag22 = (nint)0 < (nint)blocks.Length;
									object obj31 = !flag22;
									num10 = num9;
									reference = ref *(Block*)109895680;
									obj14 = obj11;
									obj15 = obj10;
									num4 = unchecked((nint)null);
									if (obj31 != null)
									{
										goto IL_0aa1;
									}
									object obj32 = _blocks + 32;
									num8 = (int)((object)_buckets + obj10);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X21_v7 (BlockList[])+v260 @ X27_v10]");
									reference = ref *(Block*)(obj32 + 0);
									void* ptr = TryAllocateSegmentFromBlock(ref *(Bucket*)(num8 - 8), ref reference, size);
									bool flag23 = ptr == null;
									object obj33 = !flag23;
									obj12 = obj13;
									num9 = size;
									num6 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									if (obj33 != null)
									{
										bool flag24 = _heap < ptr;
										object obj34 = !flag24;
										object obj35 = (object)(_heap - (nuint)ptr);
										bool flag25 = obj35 == null;
										object obj36 = ~obj34;
										object obj37 = obj36 | flag25;
										bool condition4;
										if (obj37 == null)
										{
											condition4 = false;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
											object obj38 = (nint)0 << (int)_config;
											object obj39 = _heap + obj38;
											bool flag26 = (nint)obj39 < (nint)ptr;
											object obj40 = !flag26;
											object obj41 = obj39 - ptr;
											bool flag27 = obj41 == null;
											object obj42 = !flag27;
											bool flag28 = (byte)(obj40 & obj42) != 0;
											condition4 = flag28;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CB0]");
										object error7 = 0;
										Assert.Check(condition4, (string)error7);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X26_v8 (Block&)+14]");
										bool flag29 = (nint)0 < (nint)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X26_v8 (Block&)+14]");
										bool flag30 = (nint)0 == 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X26_v8 (Block&)+14]");
										nint num15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X26_v8 (Block&)+14]");
										object obj43 = num15 ^ 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X26_v8 (Block&)+14]");
										object obj44 = 0 & obj43;
										bool flag31 = (nint)obj44 < 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CB8]");
										error8 = 0;
										bool flag32 = flag29 == flag31;
										object obj45 = !flag30;
										bool flag33 = (byte)((flag32 & obj45) ? 1 : 0) != 0;
										result = ptr;
										condition5 = flag33;
										goto IL_1026;
									}
								}
								object obj46 = _blocksFreeList + 1;
								bool flag34 = obj46 == null;
								condition = !flag34;
								obj13 = obj12;
								num10 = num9;
								obj14 = obj11;
								obj15 = obj10;
								text = (string)(object)this;
								ex = (InvalidOperationException)size;
								if (!condition)
								{
									obj15 = obj10 + 16;
									num5++;
									obj14 = obj11 + 8;
									flag7 = (nint)obj15 != 952;
									obj13 = obj12;
									num10 = num9;
									blockList2 = blockList;
									obj11 = obj14;
									obj10 = obj15;
									condition = flag7;
									if (flag7)
									{
										continue;
									}
									goto IL_04d5;
								}
								BlockList blockList3 = (BlockList)(text + 40);
								reference2 = ref ((BlockList*)blockList3)->RemoveHead(ref a);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CE8]");
								object error9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+C]");
								bool condition6 = (nint)0 == 0;
								Assert.Check(condition6, (string)error9);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+10]");
								bool condition7 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CA0]");
								object error10 = 0;
								Assert.Check(condition7, (string)error10);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+14]");
								bool condition8 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CD0]");
								object error11 = 0;
								Assert.Check(condition8, (string)error11);
								object obj47 = reference2 + 1;
								bool condition9 = obj47 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CC0]");
								object error12 = 0;
								Assert.Check(condition9, (string)error12);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+4]");
								object obj48 = (nint)0 + (nint)1;
								bool condition10 = obj48 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CA8]");
								object error13 = 0;
								Assert.Check(condition10, (string)error13);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+8]");
								object obj49 = -255;
								bool condition11 = obj49 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CC8]");
								object error14 = 0;
								Assert.Check(condition11, (string)error14);
								object obj50 = (object)_buckets + obj15;
								BlockList blockList4 = (BlockList)((object)array + obj14);
								ref Bucket reference3 = ref *(Bucket*)(obj50 + -8);
								_ = reference3;
								((BlockList*)blockList4)->AddFirst(ref a, ref reference2);
								void* ptr2 = ((Allocator)(object)text).TryAllocateSegmentFromBlock(ref reference3, ref reference2, (int)ex);
								if (ptr2 == null)
								{
									goto IL_0b62;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30950AC");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+18]");
								object obj51 = obj52 - 0;
								bool condition12 = obj51 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4CF0]");
								object error15 = 0;
								Assert.Check(condition12, (string)error15);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+14]");
								bool flag35 = (nint)0 < (nint)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+14]");
								bool flag36 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+14]");
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+14]");
								object obj53 = num16 ^ 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v19 (Block&)+14]");
								object obj54 = 0 & obj53;
								bool flag37 = (nint)obj54 < 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C98]");
								object error16 = 0;
								bool flag38 = flag35 == flag37;
								object obj55 = !flag36;
								bool condition13 = (byte)((flag38 & obj55) ? 1 : 0) != 0;
								Assert.Check(condition13, (string)error16);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X19_v6 (System.String)+18]");
								bool flag39 = unchecked((nint)null) < (nint)ptr2;
								object obj56 = !flag39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X19_v6 (System.String)+18]");
								object obj57 = (nint)0 - (nint)ptr2;
								bool flag40 = obj57 == null;
								object obj58 = ~obj56;
								object obj59 = obj58 | flag40;
								if (obj59 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C90]");
									error8 = 0;
									result = ptr2;
									condition5 = false;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X19_v6 (System.String)+4C]");
									nint num17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X19_v6 (System.String)+48]");
									object obj60 = num17 << 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X19_v6 (System.String)+18]");
									object obj61 = 0 + obj60;
									bool flag41 = (nint)obj61 < (nint)ptr2;
									object obj62 = !flag41;
									object obj63 = obj61 - ptr2;
									bool flag42 = obj63 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C90]");
									error8 = 0;
									object obj64 = !flag42;
									bool flag43 = (byte)(obj62 & obj64) != 0;
									result = ptr2;
									condition5 = flag43;
								}
								goto IL_1026;
							}
						}
						goto IL_0aa1;
						IL_1026:
						Assert.Check(condition5, (string)error8);
						return result;
					}
				}
				goto IL_0aaf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		array = (BlockList[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format = default;
		object arg = default;
		object arg2 = default;
		string text2 = string.Format(format, arg, arg2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex2 = default;
		ex2._002Ector(text2);
		int num18 = size;
		num10 = 0;
		num6 = unchecked((nint)null);
		string text3 = text2;
		text = text2;
		ex = ex2;
		goto IL_055f;
		IL_0aaf:
		throw new NullReferenceException();
		IL_0aa1:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_0aaf;
		IL_055f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		throw new ArgumentNullException();
		IL_04d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format2 = default;
		object arg3 = default;
		string text4 = string.Format(format2, arg3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		OutOfMemoryException ex4 = default;
		ex4._002Ector(text4);
		num18 = size;
		num6 = unchecked((nint)null);
		text3 = text4;
		text = text4;
		ex = (InvalidOperationException)(object)ex4;
		goto IL_055f;
		IL_0b62:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		string arg4 = reference2.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string format3 = default;
		object arg5 = default;
		string text5 = string.Format(format3, arg5, arg4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Exception ex5 = default;
		ex5._002Ector(text5);
		num18 = (int)ex;
		num10 = 0;
		num6 = unchecked((nint)null);
		text3 = text5;
		text = text5;
		ex = (InvalidOperationException)ex5;
		goto IL_055f;
	}

	private unsafe void* TryAllocateSegmentFromBlock([In] ref Bucket bucket, ref Block block, int size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f34: Expected Obj, but got Unknown
		//IL_0f63: Invalid comparison between VT and I4
		//IL_0f74: Expected Obj, but got I4
		//IL_0f84: Expected Obj, but got I
		//IL_0f8d: Expected I4, but got Obj
		//IL_0024: Invalid comparison between VT and I4
		//IL_0035: Expected Obj, but got I4
		//IL_0f1a: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00bb: Expected Ref, but got VT
		//IL_00e2: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected I4, but got Unknown
		//IL_01ad: Expected Obj, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_0ed7: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0287: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected I4, but got Unknown
		//IL_1103: Expected Obj, but got I
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected Obj, but got Unknown
		//IL_1143: Expected I4, but got VT
		//IL_0312: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_035a: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_040a: Expected I, but got Obj
		//IL_0ff7: Expected Obj, but got I
		//IL_1041: Expected Obj, but got I4
		//IL_1050: Expected Obj, but got I
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Expected Obj, but got Unknown
		//IL_045d: Expected Obj, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_0485: Expected Obj, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04ac: Expected Obj, but got I4
		//IL_04b9: Expected I4, but got Obj
		//IL_1093: Expected Obj, but got I
		//IL_10cf: Expected Obj, but got I
		//IL_1158: Expected Obj, but got I
		//IL_116e: Expected Obj, but got I
		//IL_1190: Expected Obj, but got I
		//IL_11bc: Expected Obj, but got I
		//IL_11cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d1: Expected Obj, but got Unknown
		//IL_1229: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I
		//IL_05c7: Expected Obj, but got I4
		//IL_1268: Invalid comparison between VT and I4
		//IL_1279: Expected Obj, but got I4
		//IL_128a: Expected I4, but got Obj
		//IL_12d5: Expected Obj, but got I
		//IL_12ef: Expected Obj, but got I8
		//IL_05ed: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_04ed: Invalid comparison between VT and I4
		//IL_04fe: Expected Obj, but got I4
		//IL_070f: Expected Obj, but got I4
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Expected Obj, but got Unknown
		//IL_073c: Expected Obj, but got I
		//IL_074f: Expected Obj, but got I4
		//IL_065f: Expected Obj, but got I
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected VT, but got Unknown
		//IL_0544: Expected Ref, but got VT
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_0798: Expected Obj, but got I
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		//IL_07c0: Expected Obj, but got I4
		//IL_067e: Expected Obj, but got I
		//IL_06c1: Expected I, but got Obj
		//IL_0806: Expected Obj, but got I4
		//IL_0863: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I
		//IL_089d: Expected Obj, but got I
		//IL_08ad: Expected Obj, but got I
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected Obj, but got Unknown
		//IL_0ec0: Expected Obj, but got I
		//IL_08e7: Expected Obj, but got I
		//IL_0901: Expected Obj, but got I
		//IL_0934: Expected Obj, but got Ref
		//IL_0959: Expected Obj, but got Ref
		//IL_096f: Expected I, but got Obj
		//IL_097f: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a3d: Expected Obj, but got Ref
		//IL_0abb: Expected Obj, but got I8
		//IL_0a53: Expected I, but got Obj
		//IL_0a63: Expected Obj, but got I
		//IL_0a99: Expected Obj, but got I
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected Obj, but got Unknown
		//IL_0b33: Expected Obj, but got Ref
		//IL_0bb9: Expected Obj, but got I4
		//IL_0bc9: Expected Obj, but got I4
		//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected Obj, but got Unknown
		//IL_0b49: Expected I, but got Obj
		//IL_0b59: Expected Obj, but got I
		//IL_0b8f: Expected Obj, but got I
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected Obj, but got Unknown
		//IL_0c57: Expected Obj, but got Ref
		//IL_0cd5: Expected Obj, but got I8
		//IL_0c6d: Expected I, but got Obj
		//IL_0c7d: Expected Obj, but got I
		//IL_0cb3: Expected Obj, but got I
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected Obj, but got Unknown
		//IL_0d4d: Expected Obj, but got Ref
		//IL_0dc7: Expected Obj, but got I
		//IL_0de3: Expected Obj, but got I4
		//IL_0df3: Expected Obj, but got I4
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected Obj, but got Unknown
		//IL_0d63: Expected I, but got Obj
		//IL_0d73: Expected Obj, but got I
		//IL_0da9: Expected Obj, but got I
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected Obj, but got Unknown
		//IL_0e6b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D48]");
		object error = 0;
		Bucket bucket2 = bucket;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+8]");
		object obj = bucket2 - 0;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		bool flag = bucket < (object)57;
		object obj2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
		object obj3 = 0;
		bool condition2 = (byte)(int)(~obj2) != 0;
		string text = (string)obj3;
		Assert.Check(condition2, (string)obj3);
		BlockList[] bucketsLists = _bucketsLists;
		bool flag2 = _bucketsLists == null;
		ref Block reference = ref *(Block*)null;
		object error5;
		Allocator a = default;
		void* ptr;
		void* ptr2;
		if (!flag2)
		{
			bool flag3 = bucket < (object)bucketsLists.Length;
			object obj4 = !flag3;
			reference = ref *(Block*)null;
			if (obj4 != null)
			{
				goto IL_0eef;
			}
			object obj5 = _bucketsLists + bucket;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D70]");
			object error2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D58]");
			object error3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D88]");
			object error4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DA0]");
			error5 = 0;
			BlockList blockList = (BlockList)(obj5 + 32);
			bool condition3 = ((BlockList*)blockList)->Contains(ref a, ref block);
			Assert.Check(condition3, (string)error2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
			object obj6 = ~(nint)0;
			bool condition4 = (byte)(obj6 >> 31) != 0;
			Assert.Check(condition4, (string)error3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+4]");
			int num = default;
			object obj7 = -num;
			bool flag4 = (nint)obj7 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+4]");
			int num2 = (int)((nint)0 ^ (nint)num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+4]");
			object obj8 = 0 ^ obj7;
			int num3 = num2 & obj8;
			bool flag5 = num3 < 0;
			bool condition5 = flag4 == flag5;
			Assert.Check(condition5, (string)error4);
			int num4 = block.SegmentsFreeCount(ref a);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
			object obj9 = (nint)0 + (nint)num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
			object obj10 = obj9 - 0;
			bool condition6 = obj10 == null;
			Assert.Check(condition6, (string)error5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+C]");
			if ((nint)0 < (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+C]");
				if (num5 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
					object obj11 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+18]");
					object obj12 = (nint)0 << (int)_config;
					object obj13 = _heap + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+4]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
					object obj14 = num6 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D60]");
					object error6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+C]");
					object obj15 = num7 - 0;
					bool flag6 = (nint)obj15 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+C]");
					object obj16 = num8 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
					object obj17 = 0 ^ obj15;
					object obj18 = obj16 & obj17;
					bool flag7 = (nint)obj18 < 0;
					bool flag8 = flag6 == flag7;
					bool condition7 = !flag8;
					ptr = (void*)(nint)(obj13 + obj14);
					Assert.Check(condition7, (string)error6);
					bool flag9 = ptr == null;
					ref Block reference2 = ref *(Block*)null;
					if (!flag9)
					{
						ptr2 = ptr;
						goto IL_1148;
					}
				}
				else
				{
					ref Block reference2 = ref *(Block*)null;
					ptr = (void*)unchecked((nint)null);
				}
				goto IL_10dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
			bool flag10 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
			bool flag11 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
			object obj19 = num9 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
			object obj20 = 0 & obj19;
			bool flag12 = (nint)obj20 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D78]");
			object error7 = 0;
			bool flag13 = flag10 == flag12;
			object obj21 = !flag11;
			bool condition8 = (byte)((flag13 & obj21) ? 1 : 0) != 0;
			Assert.Check(condition8, (string)error7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+C]");
			bool flag14 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3FB0]");
			object error8 = 0;
			bool condition9 = !flag14;
			Assert.Check(condition9, (string)error8);
			byte* root = _root;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+C]");
			ptr2 = root + 0;
			bool flag15 = _heap < ptr2;
			object obj22 = !flag15;
			object obj23 = (object)(_heap - (nuint)ptr2);
			bool flag16 = obj23 == null;
			object obj24 = ~obj22;
			object obj25 = obj24 | flag16;
			bool flag17;
			if (obj25 == null)
			{
				flag17 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.Allocator)+4C]");
				object obj26 = (nint)0 << (int)_config;
				object obj27 = _heap + obj26;
				bool flag18 = (nint)obj27 < (nint)ptr2;
				object obj28 = !flag18;
				object obj29 = obj27 - ptr2;
				bool flag19 = obj29 == null;
				object obj30 = !flag19;
				bool flag20 = (byte)(obj28 & obj30) != 0;
				flag17 = flag20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C28]");
			object obj31 = 0;
			reference = ref *(Block*)obj31;
			bool condition10 = flag17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+C]");
			Assert.Check(condition10, 0);
			bool flag21 = ptr2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+C]");
			text = (string)0;
			if (!flag21)
			{
				ptr2 = null;
				goto IL_1148;
			}
		}
		goto IL_0ee1;
		IL_1148:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D90]");
		object error9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+1C]");
		object obj32 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+C]");
		object obj33 = num10 - 0;
		bool flag22 = (nint)obj33 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+C]");
		object obj34 = num11 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
		object obj35 = 0 ^ obj33;
		object obj36 = obj34 & obj35;
		bool flag23 = (nint)obj36 < 0;
		bool flag24 = flag22 == flag23;
		bool condition11 = !flag24;
		Assert.Check(condition11, (string)error9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
		object obj37 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+C]");
		bool flag25 = obj37 != null;
		reference = ref *(Block*)null;
		if (!flag25)
		{
			bool flag26 = bucket < (object)57;
			object obj38 = !flag26;
			text = (string)obj3;
			bool condition12 = (byte)(int)(~obj38) != 0;
			Assert.Check(condition12, (string)obj3);
			BlockList[] bucketsLists2 = _bucketsLists;
			bool flag27 = _bucketsLists == null;
			reference = ref *(Block*)null;
			if (flag27)
			{
				goto IL_0ee1;
			}
			bool flag28 = bucket < (object)bucketsLists2.Length;
			object obj39 = !flag28;
			reference = ref *(Block*)null;
			if (obj39 != null)
			{
				goto IL_0eef;
			}
			object obj40 = _bucketsLists + bucket;
			BlockList blockList2 = (BlockList)(obj40 + 32);
			((BlockList*)blockList2)->MoveLast(ref a, ref block);
			reference = ref block;
		}
		IntPtr intPtr = (IntPtr)ptr2;
		bool flag29 = _allocated == null;
		text = null;
		IndexOutOfRangeException ex = default;
		if (!flag29)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D50]");
			object obj41 = 0;
			ref Block reference2 = ref *(Block*)obj41;
			bool flag30 = _allocated.Add(intPtr);
			bool flag31 = !flag30;
			object obj42 = !flag31;
			nint num12 = intPtr;
			IntPtr intPtr3 = default;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj43 = 0;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v65+A0]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v66+18]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X8_v66+18]");
				bool flag32 = (nint)0 == 0;
				num12 = intPtr;
				if (!flag32)
				{
					IntPtr intPtr2 = (IntPtr)ptr2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D68]");
					object format = 0;
					object arg = default;
					string text2 = string.Format((string)format, arg);
					object obj48 = obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v73+1A0]");
					reference2 = ref *(Block*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v861 @ X8_v73+198] (should have been resolved before IL gen)");
					intPtr3 = intPtr2;
					num12 = (nint)text2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+4]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bucket @ X1 (Bucket&)+4]");
			object obj50 = 0 & 0x80000000L;
			if (obj50 != null)
			{
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+C]");
			if ((nint)0 >= (nint)1)
			{
				bool flag33 = (nint)obj49 < 3;
				object obj51 = !flag33;
				object obj52 = obj49 - 3;
				bool flag34 = obj52 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3200]");
				object obj53 = 0;
				object obj54 = obj53;
				object obj55 = !flag34;
				object obj56 = obj51 & obj55;
				if (obj56 == null)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				obj49 -= 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X24_v10+20]");
				object obj57 = (nint)0 + (nint)309;
				object obj58 = obj57 & 1;
				bool flag35 = obj58 == null;
				object obj59 = !flag35;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				void* ptr3 = (byte*)ptr2 + 4;
			}
			else
			{
				void* ptr3 = ptr2;
			}
			bool flag36 = (nint)obj49 < 1;
			ptr = ptr2;
			if (flag36)
			{
				goto IL_10dd;
			}
			object obj60 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X29_v6 (System.Void*)+v175 @ X27_v8]");
				if ((nint)0 != 170)
				{
					break;
				}
				obj60++;
				if (obj49 != obj60)
				{
					continue;
				}
				goto IL_0eb0;
			}
			bool condition13 = TryGetSegmentRoot(ptr2, out var _, out var segmentIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D98]");
			object error10 = 0;
			Assert.Always(condition13, (string)error10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj61 = 0;
			object obj62 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X8_v34+A0]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v35+18]");
			object obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v35+18]");
			bool flag37 = (nint)0 == 0;
			reference2 = ref *(Block*)null;
			if (flag37)
			{
				goto IL_0eb0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array = default;
			bool flag38 = array == null;
			int num = (int)(&segmentIndex);
			reference = ref *(Block*)null;
			object obj67 = default;
			text = (string)(&obj67);
			if (!flag38)
			{
				object obj68 = default;
				bool flag39 = obj68 == null;
				string text3 = (string)(&obj67);
				if (!flag39)
				{
					nint num13 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag40 = ex == null;
					num = (int)(&segmentIndex);
					reference = ref *(Block*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					if (flag40)
					{
						goto IL_0efd;
					}
				}
				bool flag41 = array.Length == 0;
				num = (int)(&segmentIndex);
				reference = ref *(Block*)null;
				text = text3;
				if (!flag41)
				{
					object obj69 = array + 32;
					obj69 = obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj70 = default;
					bool flag42 = obj70 == null;
					object obj71 = default;
					string text4 = (string)(&obj71);
					if (!flag42)
					{
						nint num14 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
						text4 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag43 = ex == null;
						num = (int)(&segmentIndex);
						reference = ref *(Block*)null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						if (flag43)
						{
							goto IL_0efd;
						}
					}
					object obj72 = array.Length & 0xFFFFFFFEL;
					bool flag44 = obj72 == null;
					num = (int)(&segmentIndex);
					reference = ref *(Block*)null;
					text = text4;
					if (!flag44)
					{
						object obj73 = array + 40;
						obj73 = obj70;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj74 = default;
						bool flag45 = obj74 == null;
						object obj75 = default;
						string text5 = (string)(&obj75);
						if (!flag45)
						{
							nint num15 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
							text5 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag46 = ex == null;
							num = (int)(&segmentIndex);
							reference = ref *(Block*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
							text = (string)0;
							if (flag46)
							{
								goto IL_0efd;
							}
						}
						bool flag47 = array.Length < 2;
						object obj76 = !flag47;
						object obj77 = array.Length - 2;
						bool flag48 = obj77 == null;
						object obj78 = ~obj76;
						object obj79 = obj78 | flag48;
						num = (int)(&segmentIndex);
						reference = ref *(Block*)null;
						text = text5;
						if (obj79 == null)
						{
							object obj80 = array + 48;
							obj80 = obj74;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj81 = default;
							bool flag49 = obj81 == null;
							string text6 = (string)(&intPtr3);
							if (!flag49)
							{
								nint num16 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
								text6 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag50 = ex == null;
								num = (int)(&segmentIndex);
								reference = ref *(Block*)null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v55 (Il2CppClass<System.Object[]>)+40]");
								text = (string)0;
								if (flag50)
								{
									goto IL_0efd;
								}
							}
							object obj82 = array.Length & 0xFFFFFFFCL;
							bool flag51 = obj82 == null;
							num = (int)(&segmentIndex);
							reference = ref *(Block*)null;
							text = text6;
							if (!flag51)
							{
								object obj83 = array + 56;
								obj83 = obj81;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj84 = default;
								bool flag52 = obj84 == null;
								object obj85 = default;
								string text7 = (string)(&obj85);
								if (!flag52)
								{
									nint num17 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
									text7 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag53 = ex == null;
									num = (int)(&segmentIndex);
									reference = ref *(Block*)null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									if (flag53)
									{
										goto IL_0efd;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DA0]");
								error5 = 0;
								bool flag54 = array.Length < 4;
								object obj86 = !flag54;
								object obj87 = array.Length - 4;
								bool flag55 = obj87 == null;
								object obj88 = ~obj86;
								object obj89 = obj88 | flag55;
								num = (int)(&segmentIndex);
								reference = ref *(Block*)null;
								text = text7;
								if (obj89 == null)
								{
									object obj90 = array + 64;
									obj90 = obj84;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D80]");
									object format2 = 0;
									string text8 = string.Format((string)format2, array);
									object obj91 = obj64;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v53+1A0]");
									reference2 = ref *(Block*)null;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v711 @ X8_v53+198] (should have been resolved before IL gen)");
									ptr = ptr2;
									goto IL_10dd;
								}
							}
						}
					}
				}
				goto IL_0eef;
			}
		}
		goto IL_0ee1;
		IL_0eb0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DA0]");
		error5 = 0;
		ptr = ptr2;
		goto IL_10dd;
		IL_10dd:
		int num18 = block.SegmentsFreeCount(ref a);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+14]");
		object obj92 = (nint)0 + (nint)num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [block @ X2 (Block&)+10]");
		object obj93 = obj92 - 0;
		bool condition14 = obj93 == null;
		Assert.Check(condition14, (string)error5);
		DebugVerifyBucketIntegrity((int)bucket);
		return ptr;
		IL_0efd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (void*)(nint)ex2;
		IL_0ee1:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0eef;
		IL_0eef:
		ex = new IndexOutOfRangeException();
		goto IL_0efd;
	}

	private unsafe void FreeInternal(void* ptr)
	{
		//IL_0e40: Expected Obj, but got I
		//IL_0e5b: Expected Obj, but got I4
		//IL_0e6a: Expected Obj, but got I
		//IL_0e84: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_026f: Expected Obj, but got Ref
		//IL_05ca: Expected Obj, but got I
		//IL_0eba: Expected Obj, but got I4
		//IL_0ec9: Expected Obj, but got I
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected Obj, but got Unknown
		//IL_02e0: Expected Obj, but got I8
		//IL_05f7: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0643: Expected Obj, but got I4
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_066a: Expected Obj, but got I4
		//IL_0677: Expected I4, but got Obj
		//IL_0285: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_0f0c: Expected Obj, but got I
		//IL_0f28: Expected VT, but got I
		//IL_0f39: Expected Ref, but got VT
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0352: Expected Obj, but got Ref
		//IL_0a1b: Expected Obj, but got I
		//IL_0a2b: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0368: Expected I, but got Obj
		//IL_0378: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I
		//IL_0a6e: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I4
		//IL_0798: Expected I, but got VT
		//IL_07a0: Expected Obj, but got Ref
		//IL_06ee: Expected Obj, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0445: Expected Obj, but got I
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected I, but got Unknown
		//IL_071b: Expected Obj, but got I
		//IL_0487: Expected Obj, but got Ref
		//IL_0aad: Expected Obj, but got I
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Expected Obj, but got Unknown
		//IL_0ad5: Expected Obj, but got I4
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Expected Obj, but got Unknown
		//IL_0afc: Expected Obj, but got I4
		//IL_0b09: Expected I4, but got Obj
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got I8
		//IL_12bb: Expected VT, but got I
		//IL_12e5: Expected native int or pointer, but got VT
		//IL_12f2: Expected native int or pointer, but got VT
		//IL_09ba: Expected I, but got VT
		//IL_09dc: Expected Obj, but got I4
		//IL_049d: Expected I, but got Obj
		//IL_04ad: Expected Obj, but got I
		//IL_04d6: Expected Obj, but got I
		//IL_125d: Expected Obj, but got I4
		//IL_126c: Expected Obj, but got I
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Expected Obj, but got Unknown
		//IL_0810: Expected Obj, but got I
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Obj, but got Unknown
		//IL_082c: Expected Obj, but got I4
		//IL_0835: Expected Obj, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_0545: Expected Obj, but got I
		//IL_13d4: Expected Obj, but got I4
		//IL_13e4: Expected Obj, but got I
		//IL_13ed: Expected I4, but got Obj
		//IL_0b38: Expected Obj, but got I4
		//IL_1220: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Expected Obj, but got Unknown
		//IL_0b84: Expected Obj, but got I4
		//IL_0b89: Expected I, but got Obj
		//IL_1320: Expected Obj, but got I4
		//IL_132f: Expected Obj, but got I
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Expected Obj, but got Unknown
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected Obj, but got Unknown
		//IL_0c89: Expected Obj, but got I
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected Obj, but got Unknown
		//IL_0cb1: Expected Obj, but got I4
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0cd8: Expected Obj, but got I4
		//IL_0ce5: Expected I4, but got Obj
		//IL_153f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1544: Expected Obj, but got Unknown
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected Obj, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected VT, but got Unknown
		//IL_0bc8: Expected Ref, but got VT
		//IL_0bc8: Expected Ref, but got VT
		//IL_0bd8: Expected native int or pointer, but got VT
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got Unknown
		//IL_137e: Expected VT, but got I
		//IL_138f: Expected Ref, but got VT
		//IL_13a3: Expected Obj, but got I
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff4: Expected Obj, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected Obj, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected VT, but got Unknown
		//IL_0c5f: Expected Ref, but got VT
		//IL_0c5f: Expected Ref, but got VT
		//IL_159c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a1: Expected Obj, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_0c2d: Expected Obj, but got I
		//IL_0c36: Expected Obj, but got I4
		//IL_147b: Expected Obj, but got I4
		//IL_148b: Expected Obj, but got I
		//IL_1494: Expected I4, but got Obj
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_1420: Unknown result type (might be due to invalid IL or missing references)
		//IL_1425: Expected Obj, but got Unknown
		//IL_1435: Expected Obj, but got I4
		//IL_0d17: Expected Obj, but got I4
		//IL_0d1c: Expected I, but got Obj
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Expected Obj, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected Obj, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected Obj, but got Unknown
		//IL_0d4f: Expected Obj, but got I4
		//IL_1656: Unknown result type (might be due to invalid IL or missing references)
		//IL_165b: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Expected Obj, but got Unknown
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b8: Expected Obj, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_14d7: Expected Obj, but got I4
		//IL_14e8: Expected I4, but got Obj
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected Obj, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_0d9c: Expected Obj, but got I4
		//IL_0da1: Expected I, but got Obj
		//IL_1710: Unknown result type (might be due to invalid IL or missing references)
		//IL_1715: Expected Obj, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Expected Obj, but got Unknown
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected Obj, but got Unknown
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected Obj, but got Unknown
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Expected VT, but got Unknown
		//IL_0de0: Expected Ref, but got VT
		//IL_0de0: Expected Ref, but got VT
		//IL_176d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1772: Expected Obj, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_11c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c8: Expected Obj, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected Obj, but got Unknown
		//IL_179f: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a4: Expected Obj, but got Unknown
		//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b3: Expected Obj, but got Unknown
		//IL_17c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c9: Expected Obj, but got Unknown
		//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17de: Expected Obj, but got Unknown
		//IL_17ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f3: Expected Obj, but got Unknown
		//IL_1803: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected Obj, but got Unknown
		//IL_1818: Unknown result type (might be due to invalid IL or missing references)
		//IL_181d: Expected Obj, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		bool flag = _heap < ptr;
		object obj2 = !flag;
		object obj3 = (object)(_heap - (nuint)ptr);
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		object error;
		Block block = default;
		Allocator a = default;
		string text;
		bool condition2;
		object obj69;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v79 (Fusion.Allocator)+4C]");
			object obj6 = (nint)0 << (int)_config;
			object obj7 = _heap + obj6;
			bool flag3 = (nint)obj7 < (nint)ptr;
			object obj8 = !flag3;
			object obj9 = obj7 - ptr;
			bool flag4 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3094F88");
				IntPtr item = (IntPtr)ptr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DD8]");
				object obj12 = 0;
				string arg;
				object format;
				object arg2;
				if (_allocated.Remove(item))
				{
					object obj13 = 109895680;
					bool flag5 = _heap < ptr;
					object obj14 = !flag5;
					object obj15 = (object)(_heap - (nuint)ptr);
					bool flag6 = obj15 == null;
					object obj16 = ~obj14;
					object obj17 = obj16 | flag6;
					bool condition;
					if (obj17 == null)
					{
						condition = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v79 (Fusion.Allocator)+4C]");
						object obj18 = (nint)0 << (int)_config;
						object obj19 = _heap + obj18;
						bool flag7 = (nint)obj19 < (nint)ptr;
						object obj20 = !flag7;
						object obj21 = obj19 - ptr;
						bool flag8 = obj21 == null;
						object obj22 = !flag8;
						bool flag9 = (byte)(obj20 & obj22) != 0;
						condition = flag9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C20]");
					error = 0;
					Assert.Check(condition, (string)error);
					Ptr ptr2 = (Ptr)((byte*)ptr - (nuint)_root);
					if (!((Block*)block)->SegmentsFreeContains(ref a, ptr2))
					{
						if (block.SegmentsAllocated != 0)
						{
							Bucket[] buckets = _buckets;
							bool flag10 = block.Bucket < buckets.Length;
							object obj23 = !flag10;
							nint num = (nint)ptr2;
							text = (string)(&a);
							if (obj23 != null)
							{
								goto IL_0dfb;
							}
							object obj24 = buckets + block.Bucket;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v59+24]");
							if ((nint)0 >= (nint)1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v59+24]");
								object obj25 = (nint)0 + (nint)15;
								object obj26 = obj25 & 0xFFFFFFF0L;
								object obj27 = 17293312;
								object obj28 = 0;
								object obj46 = default;
								do
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj29 = obj27 & 1;
									if (obj29 != null)
									{
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj30 = obj27 & 1;
									if (obj30 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj31 = obj27 & 1;
									if (obj31 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj32 = obj27 & 1;
									if (obj32 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj33 = obj27 & 1;
									if (obj33 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj34 = obj27 & 1;
									if (obj34 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj35 = obj27 & 1;
									if (obj35 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj36 = obj27 & 1;
									if (obj36 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj37 = obj27 & 1;
									if (obj37 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj38 = obj27 & 1;
									if (obj38 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj39 = obj27 & 1;
									if (obj39 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj40 = obj27 & 1;
									if (obj40 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj41 = obj27 & 1;
									if (obj41 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj42 = obj27 & 1;
									if (obj42 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction CMHS not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj43 = obj27 & 1;
									if (obj43 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UMOV not yet implemented.\"");
									object obj44 = obj27 & 1;
									if (obj44 != null)
									{
										obj27 = ptr + obj28;
										_ = 170;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F000]");
									object obj45 = 0 + obj46;
									obj28 += 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F2E0]");
									object obj47 = 0 + obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EA70]");
									object obj48 = 0 + obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D660]");
									object obj49 = 0 + obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ED70]");
									object obj50 = 0 + obj46;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D810]");
									object obj51 = 0 + obj46;
								}
								while (obj26 != obj28);
							}
							void* ptr3 = (void*)(nint)block.SegmentsFree;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X22_v11+E16]");
							bool flag11 = (nint)0 == 0;
							object obj52 = !flag11;
							if (obj52 == null)
							{
								_ = 1;
							}
							bool flag12 = _heap < ptr;
							object obj53 = !flag12;
							object obj54 = (object)(_heap - (nuint)ptr);
							bool flag13 = obj54 == null;
							object obj55 = ~obj53;
							object obj56 = obj55 | flag13;
							if (obj56 == null)
							{
								condition2 = false;
								goto IL_129f;
							}
						}
						else
						{
							object obj57 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v52+A0]");
							object obj58 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v53+18]");
							object obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v53+18]");
							if ((nint)0 == 0)
							{
								return;
							}
							string text2 = LogPointerInfo(ptr);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DE0]");
							object obj60 = 0;
							string text3 = (string)obj60 + text2;
							object obj61 = obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v309 @ X8_v57+198] (should have been resolved before IL gen)");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v79 (Fusion.Allocator)+4C]");
						object obj62 = (nint)0 << (int)_config;
						object obj63 = _heap + obj62;
						bool flag14 = (nint)obj63 < (nint)ptr;
						object obj64 = !flag14;
						object obj65 = obj63 - ptr;
						bool flag15 = obj65 == null;
						object obj66 = !flag15;
						bool flag16 = (byte)(obj64 & obj66) != 0;
						condition2 = flag16;
						goto IL_129f;
					}
					object obj67 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v107+A0]");
					object obj68 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v108+18]");
					obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v108+18]");
					if ((nint)0 == 0)
					{
						return;
					}
					IntPtr intPtr = (IntPtr)ptr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					arg = LogPointerInfo(ptr);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DF0]");
					format = 0;
					object obj71 = default;
					arg2 = obj71;
				}
				else
				{
					object obj72 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v39+A0]");
					object obj73 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v40+18]");
					obj69 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v40+18]");
					if ((nint)0 == 0)
					{
						return;
					}
					IntPtr intPtr2 = (IntPtr)ptr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj74 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					arg = LogPointerInfo(ptr);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DF8]");
					format = 0;
					object obj75 = default;
					arg2 = obj75;
				}
				string text4 = string.Format((string)format, arg2, arg);
				goto IL_0728;
			}
		}
		object obj76 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v11+A0]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v12+18]");
		obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v12+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D3FB0]");
		object obj79 = 0;
		bool flag17 = obj79 == null;
		text = (string)4;
		object[] array = default;
		IndexOutOfRangeException ex = default;
		string text5;
		if (!flag17)
		{
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
			bool flag18 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
			text5 = (string)0;
			if (flag18)
			{
				goto IL_0e11;
			}
		}
		if (array.Length != 0)
		{
			object obj80 = array + 32;
			obj80 = obj79;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			IntPtr intPtr3 = (IntPtr)ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj81 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj82 = default;
			bool flag19 = obj82 == null;
			object obj83 = default;
			text = (string)(&obj83);
			if (!flag19)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag20 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
				text5 = (string)0;
				if (flag20)
				{
					goto IL_0e11;
				}
			}
			object obj84 = array.Length & 0xFFFFFFFEL;
			if (obj84 != null)
			{
				object obj85 = array + 40;
				obj85 = obj82;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				IntPtr intPtr4 = (IntPtr)_heap;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj86 = default;
				bool flag21 = obj86 == null;
				IntPtr intPtr5 = default;
				text = (string)(&intPtr5);
				if (!flag21)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag22 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
					text5 = (string)0;
					if (flag22)
					{
						goto IL_0e11;
					}
				}
				bool flag23 = array.Length < 2;
				object obj87 = !flag23;
				object obj88 = array.Length - 2;
				bool flag24 = obj88 == null;
				object obj89 = ~obj87;
				object obj90 = obj89 | flag24;
				if (obj90 == null)
				{
					object obj91 = array + 48;
					obj91 = obj86;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v79 (Fusion.Allocator)+4C]");
					object obj92 = (nint)0 << (int)_config;
					void* ptr4 = (void*)(nint)(_heap + obj92);
					IntPtr intPtr6 = (IntPtr)ptr4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object obj93 = default;
					bool flag25 = obj93 == null;
					IntPtr intPtr7 = default;
					text = (string)(&intPtr7);
					if (!flag25)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag26 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
						text5 = (string)0;
						if (flag26)
						{
							goto IL_0e11;
						}
					}
					object obj94 = array.Length & 0xFFFFFFFCL;
					if (obj94 != null)
					{
						object obj95 = array + 56;
						obj95 = obj93;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E00]");
						object format2 = 0;
						string text4 = string.Format((string)format2, array);
						goto IL_0728;
					}
				}
			}
		}
		goto IL_0dfb;
		IL_0e11:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		throw new NullReferenceException();
		IL_129f:
		Assert.Check(condition2, (string)error);
		Ptr segmentsFree = (Ptr)((byte*)ptr - (nuint)_root);
		int num6 = block.SegmentsAllocated - 1;
		bool flag27 = num6 == 1;
		System.Runtime.CompilerServices.Unsafe.Write(&((Block*)(nint)block)->SegmentsFree, segmentsFree);
		((Block*)(nint)block)->SegmentsAllocated = num6;
		int index;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X22_v11+E16]");
			bool flag28 = (nint)0 == 0;
			object obj96 = !flag28;
			if (obj96 == null)
			{
				_ = 1;
			}
			bool flag29 = _heap < ptr;
			object obj97 = !flag29;
			object obj98 = (object)(_heap - (nuint)ptr);
			bool flag30 = obj98 == null;
			object obj99 = ~obj97;
			object obj100 = obj99 | flag30;
			bool condition3;
			if (obj100 == null)
			{
				condition3 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v79 (Fusion.Allocator)+4C]");
				object obj101 = (nint)0 << (int)_config;
				object obj102 = _heap + obj101;
				bool flag31 = (nint)obj102 < (nint)ptr;
				object obj103 = !flag31;
				object obj104 = obj102 - ptr;
				bool flag32 = obj104 == null;
				object obj105 = !flag32;
				bool flag33 = (byte)(obj103 & obj105) != 0;
				condition3 = flag33;
			}
			Assert.Check(condition3, (string)error);
			Ptr ptr5 = (Ptr)((byte*)ptr - (nuint)_root);
			bool condition4 = ((Block*)block)->SegmentsFreeContains(ref a, ptr5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4DE8]");
			object error2 = 0;
			Assert.Check(condition4, (string)error2);
			bool flag34 = block.Bucket < 57;
			object obj106 = !flag34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
			object obj107 = 0;
			bool condition5 = (byte)(int)(~obj106) != 0;
			text = (string)obj107;
			Assert.Check(condition5, (string)obj107);
			Bucket[] buckets2 = _buckets;
			bool flag35 = block.Bucket < buckets2.Length;
			object obj108 = !flag35;
			nint num = unchecked((nint)null);
			if (obj108 != null)
			{
				goto IL_0dfb;
			}
			object obj109 = buckets2 + block.Bucket;
			object obj110 = block.SegmentsAllocated + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X21_v15+2C]");
			if (0 == (nint)obj110)
			{
				bool flag36 = block.Bucket < 57;
				object obj111 = !flag36;
				text = (string)obj107;
				bool condition6 = (byte)(int)(~obj111) != 0;
				Assert.Check(condition6, (string)obj107);
				BlockList[] bucketsLists = _bucketsLists;
				bool flag37 = block.Bucket < bucketsLists.Length;
				object obj112 = !flag37;
				num = unchecked((nint)null);
				if (obj112 != null)
				{
					goto IL_0dfb;
				}
				object obj113 = bucketsLists + block.Bucket;
				BlockList blockList = (BlockList)(obj113 + 32);
				((BlockList*)blockList)->MoveFirst(ref a, ref *(Block*)block);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X21_v15+20]");
			index = 0;
		}
		else
		{
			bool flag38 = block.Bucket < 57;
			object obj114 = !flag38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
			object obj115 = 0;
			bool condition7 = (byte)(int)(~obj114) != 0;
			text = (string)obj115;
			Assert.Check(condition7, (string)obj115);
			BlockList[] bucketsLists2 = _bucketsLists;
			bool flag39 = block.Bucket < bucketsLists2.Length;
			object obj116 = !flag39;
			nint num = unchecked((nint)null);
			if (obj116 != null)
			{
				goto IL_0dfb;
			}
			object obj117 = bucketsLists2 + block.Bucket;
			BlockList blockList2 = (BlockList)(obj117 + 32);
			((BlockList*)blockList2)->Remove(ref a, ref *(Block*)block);
			Block block2 = block;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CFF0]");
			((Block*)(nint)block2)->Bucket = 0;
			object obj118 = _config & 0x1F;
			if ((nint)obj118 != 31)
			{
				int num7 = block.Index << (int)_config;
				object obj119 = (object)(_heap + num7);
				object obj120 = 0;
				object obj121 = default;
				obj120 = obj121;
				object obj122;
				do
				{
					_ = 170;
					obj120++;
					obj122 = 1 << (int)_config;
				}
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj120) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj122));
			}
			BlockList blockList3 = (BlockList)(this + 40);
			((BlockList*)blockList3)->AddFirst(ref a, ref *(Block*)block);
			index = block.Bucket;
		}
		DebugVerifyBucketIntegrity(index);
		return;
		IL_0dfb:
		ex = new IndexOutOfRangeException();
		text5 = text;
		goto IL_0e11;
		IL_0728:
		object obj123 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X8_v9+198] (should have been resolved before IL gen)");
	}

	private unsafe void DebugVerifyBucketIntegrity(int index)
	{
		//IL_0469: Expected Obj, but got I4
		//IL_0479: Expected Obj, but got I
		//IL_0482: Expected I4, but got Obj
		//IL_0020: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_03b1: Expected Obj, but got I4
		//IL_03ba: Expected I4, but got Obj
		//IL_0082: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00fd: Expected I4, but got I8
		//IL_0117: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0145: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected VT, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_0418: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_030d: Expected Ref, but got VT
		//IL_01f9: Expected Obj, but got I4
		//IL_0357: Expected I4, but got I8
		//IL_0214: Expected Ref, but got VT
		//IL_0225: Expected Ref, but got VT
		//IL_0241: Expected Obj, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		bool flag = index < 57;
		object obj = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C38]");
		object error = 0;
		bool condition = (byte)(int)(~obj) != 0;
		Assert.Check(condition, (string)error);
		Bucket[] buckets = _buckets;
		if (_buckets != null)
		{
			bool flag2 = buckets.Length < index;
			object obj2 = !flag2;
			object obj3 = buckets.Length - index;
			bool flag3 = obj3 == null;
			object obj4 = ~obj2;
			object obj5 = obj4 | flag3;
			if (obj5 != null)
			{
				goto IL_038b;
			}
			bool flag4 = index < 57;
			object obj6 = !flag4;
			bool condition2 = (byte)(int)(~obj6) != 0;
			Assert.Check(condition2, (string)error);
			BlockList[] bucketsLists = _bucketsLists;
			if (_bucketsLists != null)
			{
				bool flag5 = bucketsLists.Length < index;
				object obj7 = !flag5;
				object obj8 = bucketsLists.Length - index;
				bool flag6 = obj8 == null;
				object obj9 = ~obj7;
				object obj10 = obj9 | flag6;
				if (obj10 != null)
				{
					goto IL_038b;
				}
				object obj11 = _bucketsLists + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v11+20]");
				int num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v11+20]");
				int num2 = 0;
				bool flag7 = num2 == 0;
				object obj12 = !flag7;
				if (obj12 != null)
				{
					return;
				}
				object obj13 = _buckets + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D30]");
				object error2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D40]");
				object error3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D38]");
				object error4 = 0;
				object obj14 = obj13 + index;
				object obj15 = 0;
				Allocator a = default;
				while (true)
				{
					Block[] blocks = _blocks;
					if (_blocks == null)
					{
						break;
					}
					bool flag8 = num < blocks.Length;
					object obj16 = !flag8;
					if (obj16 == null)
					{
						object obj17 = _blocks + 32;
						Block block = (Block)(obj17 + num);
						object obj18 = obj15;
						while (true)
						{
							object obj19 = obj18 & 1;
							bool flag9 = obj19 == null;
							object obj20 = !flag9;
							if (obj20 == null)
							{
								int segmentsAllocated = block.SegmentsAllocated;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X26_v5+C]");
								bool flag10 = (nint)segmentsAllocated == 0;
								obj18 = 1;
								if (!flag10)
								{
									int num3 = ((Block*)block)->SegmentsFreeCount(ref a);
									int num4 = ((Block*)block)->SegmentsFreeCount(ref a);
									object obj21 = block.SegmentsAllocated + num3;
									object obj22 = obj21 - block.SegmentsUsed;
									bool condition3 = obj22 == null;
									int arg = block.SegmentsAllocated + num4;
									Assert.Check(condition3, arg, block.SegmentsUsed);
									break;
								}
								continue;
							}
							int segmentsUsed = block.SegmentsUsed;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X26_v5+C]");
							object obj23 = (nint)segmentsUsed - (nint)0;
							bool condition4 = obj23 == null;
							Assert.Check(condition4, (string)error2);
							int segmentsAllocated2 = block.SegmentsAllocated;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X26_v5+C]");
							object obj24 = (nint)segmentsAllocated2 - (nint)0;
							bool condition5 = obj24 == null;
							Assert.Check(condition5, (string)error3);
							int num5 = ((Block*)block)->SegmentsFreeCount(ref a);
							bool condition6 = num5 == 0;
							Assert.Check(condition6, (string)error4);
							break;
						}
						num = block.Next;
						int num6 = (int)(block.Next & 0x80000000L);
						bool flag11 = num6 == 0;
						obj15 = obj18;
						if (!flag11)
						{
							return;
						}
						continue;
					}
					goto IL_038b;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_038b;
		IL_038b:
		throw new IndexOutOfRangeException();
	}

	public unsafe void Dispose()
	{
		//IL_0010: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0031: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4C10]");
		object obj = 0;
		object obj2 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3621544");
		_heap = (byte*)unchecked((nint)null);
	}

	private unsafe Allocator(Config config)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_003f: Expected Obj, but got VT
		//IL_004f: Expected Obj, but got I
		//IL_0b86: Expected Obj, but got I
		//IL_0b96: Expected Obj, but got I
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I4
		//IL_0beb: Expected VT, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_01d7: Expected VT, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected VT, but got Unknown
		//IL_028e: Expected native int or pointer, but got VT
		//IL_02be: Expected Obj, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_032e: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I4
		//IL_0378: Expected VT, but got I4
		//IL_0380: Expected I4, but got Obj
		//IL_0392: Expected Obj, but got I4
		//IL_0ca6: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_0c4e: Expected Obj, but got I
		//IL_0c6e: Expected Obj, but got I4
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Expected Obj, but got Unknown
		//IL_05dc: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I4
		//IL_0951: Expected I4, but got Obj
		//IL_0959: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got I4
		//IL_0611: Expected Obj, but got I4
		//IL_061a: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_0977: Expected I4, but got Obj
		//IL_097f: Expected Obj, but got I4
		//IL_0988: Expected Obj, but got I4
		//IL_0991: Expected Obj, but got I4
		//IL_0d4e: Expected Obj, but got I4
		//IL_0437: Expected Obj, but got I
		//IL_0457: Expected Obj, but got I4
		//IL_0d8b: Expected Obj, but got I
		//IL_0d94: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I8
		//IL_0511: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got VT
		//IL_0649: Expected Obj, but got I4
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_068c: Expected Obj, but got I4
		//IL_09b7: Expected Obj, but got I4
		//IL_09c7: Expected Obj, but got I
		//IL_09d0: Expected Obj, but got I4
		//IL_0550: Expected Obj, but got I4
		//IL_0559: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got VT
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_0747: Expected Obj, but got I4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_0a2d: Expected Ref, but got VT
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected Obj, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Expected Obj, but got Unknown
		//IL_0a6a: Expected Obj, but got I
		//IL_0a72: Expected VT, but got Ref
		//IL_0a82: Expected Obj, but got VT
		//IL_0a8a: Expected VT, but got Ref
		//IL_0a9a: Expected Obj, but got VT
		//IL_0cd5: Expected Obj, but got I4
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected Obj, but got Unknown
		//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Expected Obj, but got Unknown
		//IL_0d18: Expected Obj, but got I4
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected Obj, but got Unknown
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_081d: Expected Obj, but got I4
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected I4, but got Unknown
		//IL_0857: Expected Obj, but got I4
		//IL_0860: Expected VT, but got I4
		//IL_0868: Expected I4, but got Obj
		//IL_0870: Expected Obj, but got I4
		//IL_089f: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I4
		//IL_08b1: Expected VT, but got I4
		//IL_08b9: Expected I4, but got Obj
		//IL_08c1: Expected Obj, but got I4
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got Unknown
		//IL_0913: Expected VT, but got I4
		//IL_091c: Expected VT, but got I4
		//IL_0924: Expected I4, but got Obj
		//IL_092c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E18]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E20]");
		object error2 = 0;
		object obj2 = config >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E28]");
		object error3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E70]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E30]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<IntPtr> hashSet = default;
		hashSet._002Ector();
		object obj5 = this + 88;
		obj5 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
		Assert.Check(condition: true, (string)error);
		Assert.Check(condition: true, (string)error2);
		Assert.Check(condition: true, (string)error3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E58]");
		Assert.Check(condition: true, (string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E78]");
		Assert.Check(condition: true, (string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E48]");
		object obj6 = 0;
		_config = config;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 48;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Config config2 = default;
		int blockWordCount = config2.BlockWordCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 56;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 64;
		int num = default;
		obj13 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj14 = 0;
		object obj21 = default;
		object obj27 = default;
		object obj30 = default;
		IndexOutOfRangeException ex = default;
		IntPtr intPtr = default;
		Allocator a = default;
		while (true)
		{
			object obj15 = obj13;
			bool flag = obj13 == null;
			Config config3 = (Config)0;
			int num2 = num;
			object obj20;
			BlockList blockList;
			object obj36;
			if (!flag)
			{
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v4+18]");
				bool flag2 = (nint)obj16 < 0;
				object obj17 = !flag2;
				config3 = (Config)0;
				num2 = num;
				if (obj17 != null)
				{
					goto IL_0ae1;
				}
				object obj18 = obj13 + obj14;
				obj14++;
				_ = -1;
				if ((nint)obj14 != 57)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E40]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				obj20 = this + 32;
				obj20 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E68]");
				object error4 = 0;
				blockList = (BlockList)(this + 40);
				((BlockList*)(nint)blockList)->Head = -1;
				Assert.Always(condition: true, (string)error4);
				object obj22 = obj2 << (int)config;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E50]");
				object obj23 = 0;
				object obj24 = obj22 + 16;
				object obj25 = obj22 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @306DEBC");
				object obj26 = obj27 & 7;
				bool condition = obj26 == null;
				Assert.Check(condition, (string)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X26_v7 (Fusion.Allocator+BlockList)-18]");
				object obj28 = (nint)0 + (nint)8;
				if ((nint)obj25 >= 1)
				{
					object obj29 = 0;
					obj29 = obj30;
					do
					{
						byte* heap = _heap;
						_ = 170;
						obj29++;
					}
					while (obj25 != obj29);
				}
				object obj31 = 852;
				config3 = (Config)0;
				num2 = (int)obj3;
				int num3 = 0;
				object obj32 = 0;
				while (true)
				{
					ex = (IndexOutOfRangeException)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v31 (System.IndexOutOfRangeException)+E4]");
					bool flag3 = (nint)0 == 0;
					object obj33 = !flag3;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						ex = (IndexOutOfRangeException)obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v31 (System.IndexOutOfRangeException)+A0]");
					object obj34 = 0;
					object obj35 = obj34;
					bool flag4 = obj34 == null;
					obj36 = 0;
					if (flag4)
					{
						break;
					}
					int num4 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v50+18]");
					if ((nint)num4 >= (nint)0)
					{
						goto IL_05bf;
					}
					object obj37 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v31 (System.IndexOutOfRangeException)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj38 = !flag5;
					IndexOutOfRangeException ex2 = ex;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj39 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v54+A0]");
						object obj40 = 0;
						obj35 = obj40;
						bool flag6 = obj40 == null;
						obj36 = 0;
						ex = ex2;
						if (flag6)
						{
							break;
						}
					}
					int num5 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v50+18]");
					bool flag7 = (nint)num5 < (nint)0;
					object obj41 = !flag7;
					obj36 = 0;
					ex = ex2;
					if (obj41 == null)
					{
						object obj42 = obj35 + num3;
						obj31 = (nint)intPtr & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v51+20]");
						num2 = 0;
						int index = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v51+20]");
						Bucket bucket = Bucket.Create(index, 0, config);
						bool flag8 = obj7 == null;
						obj36 = 0;
						config3 = config;
						ex = (IndexOutOfRangeException)bucket;
						if (flag8)
						{
							break;
						}
						int num6 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X28_v9+18]");
						bool flag9 = (nint)num6 < (nint)0;
						object obj43 = !flag9;
						obj36 = 0;
						config3 = config;
						ex = (IndexOutOfRangeException)bucket;
						if (obj43 == null)
						{
							object obj44 = obj7 + obj32;
							num3++;
							obj32 += 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v51+20]");
							_ = 0;
							config3 = config;
							continue;
						}
					}
					goto IL_0ae1;
				}
			}
			goto IL_0b26;
			IL_0b26:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ SYSREG+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ SYSREG+28]");
			bool flag10 = num7 != 0;
			NullReferenceException ex3 = (NullReferenceException)(object)ex;
			if (!flag10)
			{
				ex3 = new NullReferenceException();
			}
			break;
			IL_0ae1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ SYSREG+28]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ SYSREG+28]");
			bool flag11 = num8 != 0;
			ex3 = (NullReferenceException)(object)ex;
			if (flag11)
			{
				break;
			}
			ex = new IndexOutOfRangeException();
			goto IL_0b26;
			IL_05bf:
			int blockWordCount2 = config2.BlockWordCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E60]");
			object obj45 = 0;
			bool flag12 = blockWordCount2 < 1;
			string text = (string)num2;
			if (flag12)
			{
				goto IL_093a;
			}
			Config config4 = config3;
			ex = (IndexOutOfRangeException)blockWordCount2;
			object obj46 = 0;
			object obj47 = 0;
			while (true)
			{
				object obj48 = obj7;
				bool flag13 = obj7 == null;
				obj36 = 0;
				config3 = config4;
				if (flag13)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v44+18]");
				bool flag14 = 0 < (nint)obj46;
				object obj49 = !flag14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v44+18]");
				object obj50 = 0 - obj46;
				bool flag15 = obj50 == null;
				object obj51 = ~obj49;
				object obj52 = obj51 | flag15;
				obj36 = 0;
				config3 = config4;
				if (obj52 == null)
				{
					object obj53 = obj7 + 32;
					object obj54 = obj53 + obj46;
					object obj55 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X10_v12+8]");
					object obj56 = obj55 - 0;
					bool flag16 = (nint)obj56 < 0;
					bool flag17 = obj56 == null;
					object obj57 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X10_v12+8]");
					object obj58 = obj57 ^ 0;
					object obj59 = obj47 ^ obj56;
					object obj60 = obj58 & obj59;
					bool flag18 = (nint)obj60 < 0;
					bool flag19 = flag16 == flag18;
					object obj61 = !flag17;
					object obj62 = flag19 & obj61;
					object obj63 = ~obj62;
					if (obj63 == null)
					{
						obj46++;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v44+18]");
					bool flag20 = 0 < (nint)obj46;
					object obj64 = !flag20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v44+18]");
					object obj65 = 0 - obj46;
					bool flag21 = obj65 == null;
					object obj66 = ~obj64;
					object obj67 = obj66 | flag21;
					obj36 = 0;
					config3 = config4;
					if (obj67 == null)
					{
						object obj68 = obj53 + obj46;
						text = (string)obj45;
						object obj69 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X8_v46+8]");
						object obj70 = obj69 - 0;
						bool flag22 = (nint)obj70 < 0;
						bool flag23 = obj70 == null;
						object obj71 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X8_v46+8]");
						object obj72 = obj71 ^ 0;
						object obj73 = obj47 ^ obj70;
						object obj74 = obj72 & obj73;
						bool flag24 = (nint)obj74 < 0;
						bool flag25 = flag22 == flag24;
						object obj75 = !flag25;
						bool flag26 = (byte)((obj75 | flag23) ? 1 : 0) != 0;
						Assert.Check(flag26, (string)obj45);
						object obj76 = obj10;
						bool flag27 = obj10 == null;
						obj36 = 0;
						config3 = (Config)0;
						num2 = (int)obj45;
						ex = (IndexOutOfRangeException)flag26;
						if (flag27)
						{
							break;
						}
						object obj77 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v48+18]");
						bool flag28 = (nint)obj77 < 0;
						object obj78 = !flag28;
						obj36 = 0;
						config3 = (Config)0;
						num2 = (int)obj45;
						ex = (IndexOutOfRangeException)flag26;
						if (obj78 == null)
						{
							object obj79 = obj10 + obj47;
							obj47++;
							blockWordCount2 = config2.BlockWordCount;
							bool flag29 = (nint)obj47 < blockWordCount2;
							config3 = (Config)0;
							config4 = (Config)0;
							num2 = (int)obj45;
							ex = (IndexOutOfRangeException)blockWordCount2;
							if (flag29)
							{
								continue;
							}
							goto IL_093a;
						}
					}
				}
				goto IL_0ae1;
			}
			goto IL_0b26;
			IL_0aa8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ SYSREG+28]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ SYSREG+28]");
			bool flag30 = num9 != 0;
			obj36 = 0;
			if (flag30)
			{
				break;
			}
			return;
			IL_093a:
			bool flag31 = (nint)obj2 < 1;
			num2 = (int)text;
			ex3 = (NullReferenceException)blockWordCount2;
			if (flag31)
			{
				goto IL_0aa8;
			}
			Config config5 = config3;
			int num10 = (int)text;
			ex = (IndexOutOfRangeException)blockWordCount2;
			object obj80 = 32;
			object obj81 = 0;
			while (true)
			{
				object obj82 = obj20;
				bool flag32 = obj20 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E520]");
				object obj83 = 0;
				obj36 = 0;
				config3 = config5;
				num2 = num10;
				if (flag32)
				{
					break;
				}
				object obj84 = obj81;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v42+18]");
				bool flag33 = (nint)obj84 < 0;
				object obj85 = !flag33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E520]");
				obj83 = 0;
				obj36 = 0;
				config3 = config5;
				num2 = num10;
				if (obj85 == null)
				{
					ref Block reference = ref *(Block*)(obj20 + obj80);
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E520]");
					reference = ref *(Block*)null;
					_ = 0;
					((BlockList*)blockList)->AddLast(ref a, ref reference);
					obj81++;
					obj80 += 32;
					bool flag34 = obj2 != obj81;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E520]");
					obj83 = 0;
					config3 = (Config)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = (int)(&a);
					ex3 = (NullReferenceException)blockList;
					config5 = (Config)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num10 = (int)(&a);
					ex = (IndexOutOfRangeException)blockList;
					if (flag34)
					{
						continue;
					}
					goto IL_0aa8;
				}
				goto IL_0ae1;
			}
			goto IL_0b26;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
	}

	public static Allocator Create(Config config)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Allocator allocator = default;
		allocator._002Ector(config);
		return allocator;
	}

	private unsafe static void InitSegmentSentinels(void* memory, int size)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_0033: Expected VT, but got I4
		//IL_0033: Expected VT, but got Ref
		//IL_0041: Expected VT, but got I4
		//IL_0041: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = default;
		BinUtils.RepeatingCopyTo((ReadOnlySpan<byte>)(&obj4), (Span<byte>)8);
		object obj5 = default;
		BinUtils.RepeatingCopyTo((ReadOnlySpan<byte>)(&obj5), (Span<byte>)8);
	}

	private unsafe void ValidateSegmentSentinels(void* memory, int size)
	{
		//IL_0c42: Expected Obj, but got I
		//IL_0c4f: Expected VT, but got I
		//IL_0c5d: Expected VT, but got I4
		//IL_0c5d: Expected VT, but got I
		//IL_0c6f: Expected VT, but got I4
		//IL_0c8d: Expected Obj, but got I4
		//IL_0c96: Expected Obj, but got I4
		//IL_0c9f: Expected VT, but got I4
		//IL_0ca7: Expected Obj, but got Ref
		//IL_0cd7: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I4
		//IL_0056: Expected VT, but got I4
		//IL_005e: Expected Obj, but got Ref
		//IL_0612: Expected Obj, but got I
		//IL_0622: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_00da: Expected VT, but got Ref
		//IL_00e2: Expected Obj, but got Ref
		//IL_0683: Expected Obj, but got I
		//IL_06a4: Expected VT, but got Ref
		//IL_0107: Expected VT, but got Ref
		//IL_06c9: Expected VT, but got Ref
		//IL_019f: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got Ref
		//IL_0125: Expected I, but got Obj
		//IL_0135: Expected VT, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0167: Expected VT, but got I
		//IL_016f: Expected Obj, but got Ref
		//IL_06e7: Expected I, but got Obj
		//IL_06f7: Expected VT, but got I
		//IL_0728: Expected VT, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_01fb: Expected VT, but got Ref
		//IL_079b: Expected VT, but got Ref
		//IL_028d: Expected Obj, but got I8
		//IL_02a5: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got Ref
		//IL_0bdd: Expected VT, but got I4
		//IL_081c: Expected Obj, but got I8
		//IL_0219: Expected I, but got Obj
		//IL_0229: Expected VT, but got I
		//IL_0253: Expected Obj, but got I4
		//IL_0263: Expected VT, but got I
		//IL_026b: Expected Obj, but got Ref
		//IL_07b9: Expected I, but got Obj
		//IL_07c9: Expected VT, but got I
		//IL_07fa: Expected VT, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02eb: Expected Obj, but got I
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0869: Expected Obj, but got I
		//IL_0311: Expected VT, but got Ref
		//IL_088f: Expected VT, but got Ref
		//IL_03ab: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03e9: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got Ref
		//IL_0918: Expected Obj, but got I4
		//IL_0928: Expected Obj, but got I4
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected Obj, but got Unknown
		//IL_032f: Expected I, but got Obj
		//IL_033f: Expected VT, but got I
		//IL_0369: Expected Obj, but got I4
		//IL_0379: Expected VT, but got I
		//IL_0381: Expected Obj, but got Ref
		//IL_08ad: Expected I, but got Obj
		//IL_08bd: Expected VT, but got I
		//IL_08ee: Expected VT, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_042f: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I4
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected Obj, but got Unknown
		//IL_098b: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I4
		//IL_0484: Expected VT, but got I
		//IL_04a0: Expected VT, but got I4
		//IL_09fc: Expected VT, but got I4
		//IL_0533: Expected Obj, but got I8
		//IL_054b: Expected Obj, but got I4
		//IL_0554: Expected Obj, but got I4
		//IL_0a8f: Expected Obj, but got I8
		//IL_0aa7: Expected Obj, but got I4
		//IL_0ab0: Expected Obj, but got I4
		//IL_04be: Expected I, but got Obj
		//IL_04ce: Expected VT, but got I
		//IL_04f8: Expected Obj, but got I4
		//IL_0508: Expected VT, but got I
		//IL_0511: Expected Obj, but got I4
		//IL_0a1a: Expected I, but got Obj
		//IL_0a2a: Expected VT, but got I
		//IL_0a54: Expected Obj, but got I4
		//IL_0a64: Expected VT, but got I
		//IL_0a6d: Expected Obj, but got I4
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_0592: Expected Obj, but got I
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected Obj, but got Unknown
		//IL_0aee: Expected Obj, but got I
		//IL_05c0: Expected Obj, but got I
		//IL_05ed: Expected Obj, but got I4
		//IL_05f5: Expected VT, but got Obj
		//IL_0b1c: Expected Obj, but got I
		//IL_0b2f: Expected Obj, but got I4
		//IL_0b37: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj = 0;
		ReadOnlySpan<byte> readOnlySpan = (ReadOnlySpan<byte>)((byte*)memory + size);
		bool flag = Fusion.SpanExtensions.RepeatingSequenceEqualTo((ReadOnlySpan<byte>)memory, (ReadOnlySpan<byte>)0);
		bool flag2 = Fusion.SpanExtensions.RepeatingSequenceEqualTo(readOnlySpan, (ReadOnlySpan<byte>)0);
		bool flag3 = !flag;
		object obj2 = !flag3;
		object obj3 = 8;
		ReadOnlySpan<byte> readOnlySpan2 = (ReadOnlySpan<byte>)0;
		object obj5 = default;
		object obj4 = (object)(&obj5);
		bool flag4 = flag2;
		IntPtr intPtr2 = default;
		ReadOnlySpan<byte> readOnlySpan3;
		NullReferenceException ex2;
		int num2 = default;
		Config config = default;
		NullReferenceException ex = default;
		IndexOutOfRangeException ex3 = default;
		if (obj2 == null)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v42+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v43+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v43+18]");
			bool flag5 = (nint)0 == 0;
			obj3 = 8;
			readOnlySpan2 = (ReadOnlySpan<byte>)0;
			obj4 = (object)(&obj5);
			flag4 = flag2;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				IntPtr intPtr = (IntPtr)memory;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array = default;
				bool flag6 = array == null;
				obj3 = 8;
				readOnlySpan2 = (ReadOnlySpan<byte>)(&intPtr2);
				obj4 = (object)(&obj5);
				if (!flag6)
				{
					bool flag7 = ex == null;
					readOnlySpan3 = (ReadOnlySpan<byte>)(&intPtr2);
					ex2 = ex;
					if (!flag7)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v65 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan3 = (ReadOnlySpan<byte>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag8 = ex2 == null;
						obj3 = 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v65 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan2 = (ReadOnlySpan<byte>)0;
						obj4 = (object)(&obj5);
						ex3 = (IndexOutOfRangeException)(object)ex2;
						if (flag8)
						{
							goto IL_0b92;
						}
					}
					bool flag9 = array.Length == 0;
					obj3 = 8;
					obj4 = (object)(&obj5);
					if (!flag9)
					{
						object obj11 = array + 32;
						obj11 = ex;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						NullReferenceException ex4 = default;
						bool flag10 = ex4 == null;
						readOnlySpan3 = (ReadOnlySpan<byte>)(&num2);
						ex2 = ex4;
						if (!flag10)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag11 = ex3 == null;
							ex2 = (NullReferenceException)(object)ex3;
							obj3 = 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v64 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan2 = (ReadOnlySpan<byte>)0;
							obj4 = (object)(&obj5);
							if (flag11)
							{
								goto IL_0b92;
							}
						}
						object obj12 = array.Length & 0xFFFFFFFEL;
						bool flag12 = obj12 == null;
						obj3 = 8;
						obj4 = (object)(&obj5);
						if (!flag12)
						{
							object obj13 = array + 40;
							obj13 = ex4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E88]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							NullReferenceException ex5 = default;
							bool flag13 = ex5 == null;
							readOnlySpan3 = (ReadOnlySpan<byte>)(&config);
							ex2 = ex5;
							if (!flag13)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag14 = ex3 == null;
								ex2 = (NullReferenceException)(object)ex3;
								obj3 = 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v63 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan2 = (ReadOnlySpan<byte>)0;
								obj4 = (object)(&obj5);
								if (flag14)
								{
									goto IL_0b92;
								}
							}
							bool flag15 = array.Length < 2;
							object obj15 = !flag15;
							object obj16 = array.Length - 2;
							bool flag16 = obj16 == null;
							object obj17 = ~obj15;
							object obj18 = obj17 | flag16;
							obj3 = 8;
							obj4 = (object)(&obj5);
							if (obj18 == null)
							{
								object obj19 = array + 48;
								obj19 = ex5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31B0]");
								object obj20 = 0;
								object obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v82+E4]");
								bool flag17 = (nint)0 == 0;
								object obj22 = !flag17;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text = BinUtils.BytesToHex((ReadOnlySpan<byte>)memory, 0);
								bool flag18 = text == null;
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								ex2 = (NullReferenceException)(object)text;
								if (!flag18)
								{
									nint num5 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
									readOnlySpan3 = (ReadOnlySpan<byte>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag19 = ex3 == null;
									ex2 = (NullReferenceException)(object)ex3;
									obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v62 (Il2CppClass<System.Object[]>)+40]");
									readOnlySpan2 = (ReadOnlySpan<byte>)0;
									obj4 = 0;
									if (flag19)
									{
										goto IL_0b92;
									}
								}
								object obj23 = array.Length & 0xFFFFFFFCL;
								bool flag20 = obj23 == null;
								obj3 = 0;
								obj4 = 0;
								if (!flag20)
								{
									object obj24 = array + 56;
									obj24 = text;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E90]");
									object format = 0;
									string text2 = string.Format((string)format, array);
									object obj25 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v61+1A0]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ X8_v61+198] (should have been resolved before IL gen)");
									config = _config;
									num2 = size;
									intPtr2 = intPtr;
									obj3 = 0;
									readOnlySpan2 = (ReadOnlySpan<byte>)text2;
									goto IL_0cbd;
								}
							}
						}
					}
					goto IL_0b3d;
				}
				goto IL_0bea;
			}
		}
		goto IL_0cbd;
		IL_0bea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num6 == 0)
		{
			ex = new NullReferenceException();
		}
		goto IL_0c27;
		IL_0b92:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		if (num7 == 0)
		{
			ArgumentNullException ex6 = new ArgumentNullException();
			readOnlySpan2 = (ReadOnlySpan<byte>)0;
			ex = (NullReferenceException)(object)ex6;
			goto IL_0bea;
		}
		goto IL_0c27;
		IL_0ce5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag21 = num8 != 0;
		ex = (NullReferenceException)flag4;
		if (!flag21)
		{
			return;
		}
		goto IL_0c27;
		IL_0b3d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ SYSREG+28]");
		bool flag22 = num9 != 0;
		readOnlySpan2 = readOnlySpan3;
		ex = ex2;
		if (!flag22)
		{
			ex3 = new IndexOutOfRangeException();
			readOnlySpan2 = readOnlySpan3;
			goto IL_0b92;
		}
		goto IL_0c27;
		IL_0c27:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_0cbd:
		bool flag23 = !flag2;
		object obj26 = !flag23;
		if (obj26 == null)
		{
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v11+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v12+18]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v12+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				IntPtr intPtr3 = (IntPtr)memory;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array2 = default;
				bool flag24 = array2 == null;
				readOnlySpan2 = (ReadOnlySpan<byte>)(&intPtr2);
				if (!flag24)
				{
					bool flag25 = ex == null;
					readOnlySpan3 = (ReadOnlySpan<byte>)(&intPtr2);
					ex2 = ex;
					if (!flag25)
					{
						nint num10 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan3 = (ReadOnlySpan<byte>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag26 = ex3 == null;
						ex2 = (NullReferenceException)(object)ex3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan2 = (ReadOnlySpan<byte>)0;
						if (flag26)
						{
							goto IL_0b92;
						}
					}
					if (array2.Length != 0)
					{
						object obj32 = array2 + 32;
						obj32 = ex;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						NullReferenceException ex7 = default;
						bool flag27 = ex7 == null;
						readOnlySpan3 = (ReadOnlySpan<byte>)(&num2);
						ex2 = ex7;
						if (!flag27)
						{
							nint num11 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag28 = ex3 == null;
							ex2 = (NullReferenceException)(object)ex3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan2 = (ReadOnlySpan<byte>)0;
							if (flag28)
							{
								goto IL_0b92;
							}
						}
						object obj33 = array2.Length & 0xFFFFFFFEL;
						if (obj33 != null)
						{
							object obj34 = array2 + 40;
							obj34 = ex7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E88]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							NullReferenceException ex8 = default;
							bool flag29 = ex8 == null;
							readOnlySpan3 = (ReadOnlySpan<byte>)(&config);
							ex2 = ex8;
							if (!flag29)
							{
								nint num12 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag30 = ex3 == null;
								ex2 = (NullReferenceException)(object)ex3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan2 = (ReadOnlySpan<byte>)0;
								if (flag30)
								{
									goto IL_0b92;
								}
							}
							bool flag31 = array2.Length < 2;
							object obj36 = !flag31;
							object obj37 = array2.Length - 2;
							bool flag32 = obj37 == null;
							object obj38 = ~obj36;
							object obj39 = obj38 | flag32;
							if (obj39 == null)
							{
								object obj40 = array2 + 48;
								obj40 = ex8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31B0]");
								object obj41 = 0;
								object obj42 = obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v30+E4]");
								bool flag33 = (nint)0 == 0;
								object obj43 = !flag33;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text3 = BinUtils.BytesToHex(readOnlySpan, 0);
								bool flag34 = text3 == null;
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								ex2 = (NullReferenceException)(object)text3;
								if (!flag34)
								{
									nint num13 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
									readOnlySpan3 = (ReadOnlySpan<byte>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag35 = ex3 == null;
									ex2 = (NullReferenceException)(object)ex3;
									obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
									readOnlySpan2 = (ReadOnlySpan<byte>)0;
									obj4 = 0;
									if (flag35)
									{
										goto IL_0b92;
									}
								}
								object obj44 = array2.Length & 0xFFFFFFFCL;
								bool flag36 = obj44 == null;
								obj3 = 0;
								obj4 = 0;
								if (!flag36)
								{
									object obj45 = array2 + 56;
									obj45 = text3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E98]");
									object format2 = 0;
									string text4 = string.Format((string)format2, array2);
									object obj46 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v30+1A0]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X8_v30+198] (should have been resolved before IL gen)");
									obj3 = 0;
									readOnlySpan2 = (ReadOnlySpan<byte>)text4;
									goto IL_0ce5;
								}
							}
						}
					}
					goto IL_0b3d;
				}
				goto IL_0bea;
			}
		}
		goto IL_0ce5;
	}

	private unsafe void ValidateSegmentSentinels(void* memory, int size, ref string error)
	{
		//IL_12b1: Expected VT, but got I
		//IL_12bf: Expected VT, but got I4
		//IL_12bf: Expected VT, but got I
		//IL_12d1: Expected VT, but got I4
		//IL_12ef: Expected Obj, but got I4
		//IL_0c4b: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I4
		//IL_0c77: Expected Obj, but got I
		//IL_0c99: Expected Obj, but got I4
		//IL_0ca1: Expected VT, but got Ref
		//IL_0ca9: Expected Obj, but got Ref
		//IL_06df: Expected Obj, but got I4
		//IL_06e8: Expected Obj, but got I4
		//IL_06f1: Expected VT, but got I4
		//IL_06f9: Expected Obj, but got Ref
		//IL_11a8: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_0cce: Expected VT, but got Ref
		//IL_0717: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0093: Expected VT, but got Ref
		//IL_009b: Expected Obj, but got Ref
		//IL_0d66: Expected Obj, but got I4
		//IL_0d6e: Expected Obj, but got Ref
		//IL_0743: Expected Obj, but got I
		//IL_0765: Expected Obj, but got I4
		//IL_076d: Expected VT, but got Ref
		//IL_0775: Expected Obj, but got Ref
		//IL_0cec: Expected I, but got Obj
		//IL_0cfc: Expected VT, but got I
		//IL_0d1e: Expected Obj, but got I4
		//IL_0d2e: Expected VT, but got I
		//IL_0d36: Expected Obj, but got Ref
		//IL_00c0: Expected VT, but got Ref
		//IL_0d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Expected Obj, but got Unknown
		//IL_079a: Expected VT, but got Ref
		//IL_0158: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got Ref
		//IL_0dca: Expected VT, but got Ref
		//IL_0832: Expected Obj, but got I4
		//IL_083a: Expected Obj, but got Ref
		//IL_00de: Expected I, but got Obj
		//IL_00ee: Expected VT, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0120: Expected VT, but got I
		//IL_0128: Expected Obj, but got Ref
		//IL_0e5c: Expected Obj, but got I8
		//IL_0e74: Expected Obj, but got I4
		//IL_0e7c: Expected Obj, but got Ref
		//IL_124f: Expected VT, but got I4
		//IL_07b8: Expected I, but got Obj
		//IL_07c8: Expected VT, but got I
		//IL_07f2: Expected Obj, but got I4
		//IL_0802: Expected VT, but got I
		//IL_080a: Expected Obj, but got Ref
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_0de8: Expected I, but got Obj
		//IL_0df8: Expected VT, but got I
		//IL_0e22: Expected Obj, but got I4
		//IL_0e32: Expected VT, but got I
		//IL_0e3a: Expected Obj, but got Ref
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_01bc: Expected VT, but got Ref
		//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e98: Expected Obj, but got Unknown
		//IL_0eba: Expected Obj, but got I
		//IL_088e: Expected VT, but got Ref
		//IL_024e: Expected Obj, but got I8
		//IL_0266: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got Ref
		//IL_0ee0: Expected VT, but got Ref
		//IL_0920: Expected Obj, but got I8
		//IL_0938: Expected Obj, but got I4
		//IL_0940: Expected Obj, but got Ref
		//IL_01da: Expected I, but got Obj
		//IL_01ea: Expected VT, but got I
		//IL_0214: Expected Obj, but got I4
		//IL_0224: Expected VT, but got I
		//IL_022c: Expected Obj, but got Ref
		//IL_0f7a: Expected Obj, but got I4
		//IL_0f8a: Expected Obj, but got I4
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Expected Obj, but got Unknown
		//IL_0fb8: Expected Obj, but got I4
		//IL_0fc0: Expected Obj, but got Ref
		//IL_08ac: Expected I, but got Obj
		//IL_08bc: Expected VT, but got I
		//IL_08e6: Expected Obj, but got I4
		//IL_08f6: Expected VT, but got I
		//IL_08fe: Expected Obj, but got Ref
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_0efe: Expected I, but got Obj
		//IL_0f0e: Expected VT, but got I
		//IL_0f38: Expected Obj, but got I4
		//IL_0f48: Expected VT, but got I
		//IL_0f50: Expected Obj, but got Ref
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected Obj, but got Unknown
		//IL_097e: Expected Obj, but got I
		//IL_02d2: Expected VT, but got Ref
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected Obj, but got Unknown
		//IL_0ffe: Expected Obj, but got I
		//IL_1028: Expected Obj, but got I4
		//IL_09a4: Expected VT, but got Ref
		//IL_036c: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got Ref
		//IL_1053: Expected VT, but got I
		//IL_106f: Expected VT, but got I4
		//IL_0a3e: Expected Obj, but got I4
		//IL_0a4e: Expected Obj, but got I4
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected Obj, but got Unknown
		//IL_0a7c: Expected Obj, but got I4
		//IL_0a84: Expected Obj, but got Ref
		//IL_02f0: Expected I, but got Obj
		//IL_0300: Expected VT, but got I
		//IL_032a: Expected Obj, but got I4
		//IL_033a: Expected VT, but got I
		//IL_0342: Expected Obj, but got Ref
		//IL_1102: Expected Obj, but got I8
		//IL_111a: Expected Obj, but got I4
		//IL_1123: Expected Obj, but got I4
		//IL_09c2: Expected I, but got Obj
		//IL_09d2: Expected VT, but got I
		//IL_09fc: Expected Obj, but got I4
		//IL_0a0c: Expected VT, but got I
		//IL_0a14: Expected Obj, but got Ref
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03f0: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I4
		//IL_108d: Expected I, but got Obj
		//IL_109d: Expected VT, but got I
		//IL_10c7: Expected Obj, but got I4
		//IL_10d7: Expected VT, but got I
		//IL_10e0: Expected Obj, but got I4
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected Obj, but got Unknown
		//IL_0ac2: Expected Obj, but got I
		//IL_0aec: Expected Obj, but got I4
		//IL_0445: Expected VT, but got I
		//IL_0461: Expected VT, but got I4
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected Obj, but got Unknown
		//IL_1161: Expected Obj, but got I
		//IL_1172: Expected Obj, but got I4
		//IL_0b33: Expected VT, but got I4
		//IL_04f4: Expected Obj, but got I8
		//IL_050c: Expected Obj, but got I4
		//IL_0515: Expected Obj, but got I4
		//IL_133d: Expected VT, but got Obj
		//IL_1346: Expected Obj, but got I4
		//IL_0bc6: Expected Obj, but got I8
		//IL_0bde: Expected Obj, but got I4
		//IL_0be7: Expected Obj, but got I4
		//IL_047f: Expected I, but got Obj
		//IL_048f: Expected VT, but got I
		//IL_04b9: Expected Obj, but got I4
		//IL_04c9: Expected VT, but got I
		//IL_04d2: Expected Obj, but got I4
		//IL_0b51: Expected I, but got Obj
		//IL_0b61: Expected VT, but got I
		//IL_0b8b: Expected Obj, but got I4
		//IL_0b9b: Expected VT, but got I
		//IL_0ba4: Expected Obj, but got I4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected Obj, but got Unknown
		//IL_0c25: Expected Obj, but got I
		//IL_0c2e: Expected Obj, but got I4
		//IL_0572: Expected VT, but got I4
		//IL_060d: Expected Obj, but got I4
		//IL_061d: Expected Obj, but got I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_064b: Expected Obj, but got I4
		//IL_0654: Expected Obj, but got I4
		//IL_0590: Expected I, but got Obj
		//IL_05a0: Expected VT, but got I
		//IL_05ca: Expected Obj, but got I4
		//IL_05da: Expected VT, but got I
		//IL_05e3: Expected Obj, but got I4
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected Obj, but got Unknown
		//IL_0692: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I4
		ReadOnlySpan<byte> readOnlySpan = (ReadOnlySpan<byte>)((byte*)memory + size);
		bool flag = Fusion.SpanExtensions.RepeatingSequenceEqualTo((ReadOnlySpan<byte>)memory, (ReadOnlySpan<byte>)0);
		bool flag2 = Fusion.SpanExtensions.RepeatingSequenceEqualTo(readOnlySpan, (ReadOnlySpan<byte>)0);
		bool flag3 = !flag;
		object obj = !flag3;
		object obj6 = default;
		object obj8 = default;
		ArgumentNullException ex = default;
		ReadOnlySpan<byte> readOnlySpan3;
		object obj10 = default;
		object obj14 = default;
		object obj30;
		object[] array2;
		object obj7;
		IndexOutOfRangeException ex3 = default;
		ReadOnlySpan<byte> readOnlySpan2;
		NullReferenceException ex4;
		if (obj == null)
		{
			bool flag4 = !flag2;
			object obj2 = !flag4;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				IntPtr intPtr = (IntPtr)memory;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array = default;
				bool flag5 = array == null;
				object obj5 = 8;
				readOnlySpan2 = (ReadOnlySpan<byte>)(&obj6);
				obj7 = (object)(&obj8);
				if (!flag5)
				{
					bool flag6 = ex == null;
					readOnlySpan3 = (ReadOnlySpan<byte>)(&obj6);
					ArgumentNullException ex2 = ex;
					if (!flag6)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v84 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan3 = (ReadOnlySpan<byte>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag7 = ex2 == null;
						obj5 = 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v84 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan2 = (ReadOnlySpan<byte>)0;
						obj7 = (object)(&obj8);
						ex3 = (IndexOutOfRangeException)(object)ex2;
						if (flag7)
						{
							goto IL_1204;
						}
					}
					bool flag8 = array.Length == 0;
					obj5 = 8;
					obj7 = (object)(&obj8);
					ex4 = (NullReferenceException)(object)ex2;
					if (!flag8)
					{
						object obj9 = array + 32;
						obj9 = ex;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						NullReferenceException ex5 = default;
						bool flag9 = ex5 == null;
						readOnlySpan3 = (ReadOnlySpan<byte>)(&obj10);
						ex4 = ex5;
						if (!flag9)
						{
							nint num2 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v83 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex3 == null;
							ex4 = (NullReferenceException)(object)ex3;
							obj5 = 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X8_v83 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan2 = (ReadOnlySpan<byte>)0;
							obj7 = (object)(&obj8);
							if (flag10)
							{
								goto IL_1204;
							}
						}
						object obj11 = array.Length & 0xFFFFFFFEL;
						bool flag11 = obj11 == null;
						obj5 = 8;
						obj7 = (object)(&obj8);
						if (!flag11)
						{
							object obj12 = array + 40;
							obj12 = ex5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E88]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							NullReferenceException ex6 = default;
							bool flag12 = ex6 == null;
							readOnlySpan3 = (ReadOnlySpan<byte>)(&obj14);
							ex4 = ex6;
							if (!flag12)
							{
								nint num3 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag13 = ex3 == null;
								ex4 = (NullReferenceException)(object)ex3;
								obj5 = 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v82 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan2 = (ReadOnlySpan<byte>)0;
								obj7 = (object)(&obj8);
								if (flag13)
								{
									goto IL_1204;
								}
							}
							bool flag14 = array.Length < 2;
							object obj15 = !flag14;
							object obj16 = array.Length - 2;
							bool flag15 = obj16 == null;
							object obj17 = ~obj15;
							object obj18 = obj17 | flag15;
							obj5 = 8;
							obj7 = (object)(&obj8);
							if (obj18 == null)
							{
								object obj19 = array + 48;
								obj19 = ex6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31B0]");
								object obj20 = 0;
								object obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v123+E4]");
								bool flag16 = (nint)0 == 0;
								object obj22 = !flag16;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text = BinUtils.BytesToHex((ReadOnlySpan<byte>)memory, 0);
								bool flag17 = text == null;
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								ex4 = (NullReferenceException)(object)text;
								if (!flag17)
								{
									nint num4 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
									readOnlySpan3 = (ReadOnlySpan<byte>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag18 = ex3 == null;
									ex4 = (NullReferenceException)(object)ex3;
									obj5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v81 (Il2CppClass<System.Object[]>)+40]");
									readOnlySpan2 = (ReadOnlySpan<byte>)0;
									obj7 = 0;
									if (flag18)
									{
										goto IL_1204;
									}
								}
								object obj23 = array.Length & 0xFFFFFFFCL;
								bool flag19 = obj23 == null;
								obj5 = 0;
								obj7 = 0;
								if (!flag19)
								{
									object obj24 = array + 56;
									obj24 = text;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									string text2 = BinUtils.BytesToHex(readOnlySpan, 0);
									bool flag20 = text2 == null;
									readOnlySpan3 = (ReadOnlySpan<byte>)0;
									ex4 = (NullReferenceException)(object)text2;
									if (!flag20)
									{
										nint num5 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
										readOnlySpan3 = (ReadOnlySpan<byte>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag21 = ex3 == null;
										ex4 = (NullReferenceException)(object)ex3;
										obj5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v80 (Il2CppClass<System.Object[]>)+40]");
										readOnlySpan2 = (ReadOnlySpan<byte>)0;
										obj7 = 0;
										if (flag21)
										{
											goto IL_1204;
										}
									}
									bool flag22 = array.Length < 4;
									object obj25 = !flag22;
									object obj26 = array.Length - 4;
									bool flag23 = obj26 == null;
									object obj27 = ~obj25;
									object obj28 = obj27 | flag23;
									obj5 = 0;
									obj7 = 0;
									if (obj28 == null)
									{
										object obj29 = array + 64;
										obj29 = text2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EA0]");
										obj30 = 0;
										obj5 = 0;
										array2 = array;
										goto IL_12fd;
									}
								}
							}
						}
					}
					goto IL_11b7;
				}
				goto IL_1254;
			}
		}
		string format;
		object[] args;
		if (flag)
		{
			bool flag24 = !flag2;
			object obj31 = !flag24;
			object obj5 = 8;
			readOnlySpan2 = (ReadOnlySpan<byte>)0;
			obj7 = (object)(&obj8);
			if (obj31 != null)
			{
				goto IL_117f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			IntPtr intPtr2 = (IntPtr)memory;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array3 = default;
			bool flag25 = array3 == null;
			obj5 = 8;
			readOnlySpan2 = (ReadOnlySpan<byte>)(&obj6);
			obj7 = (object)(&obj8);
			if (!flag25)
			{
				bool flag26 = ex == null;
				readOnlySpan3 = (ReadOnlySpan<byte>)(&obj6);
				ex4 = (NullReferenceException)(object)ex;
				if (!flag26)
				{
					nint num6 = (nint)array3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
					readOnlySpan3 = (ReadOnlySpan<byte>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag27 = ex3 == null;
					ex4 = (NullReferenceException)(object)ex3;
					obj5 = 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
					readOnlySpan2 = (ReadOnlySpan<byte>)0;
					obj7 = (object)(&obj8);
					if (flag27)
					{
						goto IL_1204;
					}
				}
				bool flag28 = array3.Length == 0;
				obj5 = 8;
				obj7 = (object)(&obj8);
				if (!flag28)
				{
					object obj34 = array3 + 32;
					obj34 = ex;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					NullReferenceException ex7 = default;
					bool flag29 = ex7 == null;
					readOnlySpan3 = (ReadOnlySpan<byte>)(&obj10);
					ex4 = ex7;
					if (!flag29)
					{
						nint num7 = (nint)array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan3 = (ReadOnlySpan<byte>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag30 = ex3 == null;
						ex4 = (NullReferenceException)(object)ex3;
						obj5 = 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan2 = (ReadOnlySpan<byte>)0;
						obj7 = (object)(&obj8);
						if (flag30)
						{
							goto IL_1204;
						}
					}
					object obj35 = array3.Length & 0xFFFFFFFEL;
					bool flag31 = obj35 == null;
					obj5 = 8;
					obj7 = (object)(&obj8);
					if (!flag31)
					{
						object obj36 = array3 + 40;
						obj36 = ex7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E88]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						NullReferenceException ex8 = default;
						bool flag32 = ex8 == null;
						readOnlySpan3 = (ReadOnlySpan<byte>)(&obj14);
						ex4 = ex8;
						if (!flag32)
						{
							nint num8 = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag33 = ex3 == null;
							ex4 = (NullReferenceException)(object)ex3;
							obj5 = 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v58 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan2 = (ReadOnlySpan<byte>)0;
							obj7 = (object)(&obj8);
							if (flag33)
							{
								goto IL_1204;
							}
						}
						bool flag34 = array3.Length < 2;
						object obj38 = !flag34;
						object obj39 = array3.Length - 2;
						bool flag35 = obj39 == null;
						object obj40 = ~obj38;
						object obj41 = obj40 | flag35;
						obj5 = 8;
						obj7 = (object)(&obj8);
						if (obj41 == null)
						{
							object obj42 = array3 + 48;
							obj42 = ex8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31B0]");
							object obj43 = 0;
							object obj44 = obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v84+E4]");
							bool flag36 = (nint)0 == 0;
							object obj45 = !flag36;
							if (obj45 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text3 = BinUtils.BytesToHex(readOnlySpan, 0);
							bool flag37 = text3 == null;
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							ex4 = (NullReferenceException)(object)text3;
							if (!flag37)
							{
								nint num9 = (nint)array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag38 = ex3 == null;
								ex4 = (NullReferenceException)(object)ex3;
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan2 = (ReadOnlySpan<byte>)0;
								obj7 = 0;
								if (flag38)
								{
									goto IL_1204;
								}
							}
							object obj46 = array3.Length & 0xFFFFFFFCL;
							bool flag39 = obj46 == null;
							obj5 = 0;
							obj7 = 0;
							if (!flag39)
							{
								object obj47 = array3 + 56;
								obj47 = text3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EB0]");
								obj30 = 0;
								obj5 = 0;
								array2 = array3;
								goto IL_12fd;
							}
						}
					}
				}
				goto IL_11b7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			IntPtr intPtr3 = (IntPtr)memory;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object[] array4 = default;
			bool flag40 = array4 == null;
			object obj5 = 8;
			readOnlySpan2 = (ReadOnlySpan<byte>)(&obj6);
			obj7 = (object)(&obj8);
			if (!flag40)
			{
				bool flag41 = ex == null;
				readOnlySpan3 = (ReadOnlySpan<byte>)(&obj6);
				ArgumentNullException ex9 = ex;
				if (!flag41)
				{
					nint num10 = (nint)array4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
					readOnlySpan3 = (ReadOnlySpan<byte>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag42 = ex9 == null;
					obj5 = 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
					readOnlySpan2 = (ReadOnlySpan<byte>)0;
					obj7 = (object)(&obj8);
					ex3 = (IndexOutOfRangeException)(object)ex9;
					if (flag42)
					{
						goto IL_1204;
					}
				}
				bool flag43 = array4.Length == 0;
				obj5 = 8;
				obj7 = (object)(&obj8);
				ex4 = (NullReferenceException)(object)ex9;
				if (!flag43)
				{
					object obj50 = array4 + 32;
					obj50 = ex;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					NullReferenceException ex10 = default;
					bool flag44 = ex10 == null;
					readOnlySpan3 = (ReadOnlySpan<byte>)(&obj10);
					ex4 = ex10;
					if (!flag44)
					{
						nint num11 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan3 = (ReadOnlySpan<byte>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag45 = ex3 == null;
						ex4 = (NullReferenceException)(object)ex3;
						obj5 = 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
						readOnlySpan2 = (ReadOnlySpan<byte>)0;
						obj7 = (object)(&obj8);
						if (flag45)
						{
							goto IL_1204;
						}
					}
					object obj51 = array4.Length & 0xFFFFFFFEL;
					bool flag46 = obj51 == null;
					obj5 = 8;
					obj7 = (object)(&obj8);
					if (!flag46)
					{
						object obj52 = array4 + 40;
						obj52 = ex10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4E88]");
						object obj53 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						NullReferenceException ex11 = default;
						bool flag47 = ex11 == null;
						readOnlySpan3 = (ReadOnlySpan<byte>)(&obj14);
						ex4 = ex11;
						if (!flag47)
						{
							nint num12 = (nint)array4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag48 = ex3 == null;
							ex4 = (NullReferenceException)(object)ex3;
							obj5 = 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
							readOnlySpan2 = (ReadOnlySpan<byte>)0;
							obj7 = (object)(&obj8);
							if (flag48)
							{
								goto IL_1204;
							}
						}
						bool flag49 = array4.Length < 2;
						object obj54 = !flag49;
						object obj55 = array4.Length - 2;
						bool flag50 = obj55 == null;
						object obj56 = ~obj54;
						object obj57 = obj56 | flag50;
						obj5 = 8;
						obj7 = (object)(&obj8);
						if (obj57 == null)
						{
							object obj58 = array4 + 48;
							obj58 = ex11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D31B0]");
							object obj59 = 0;
							object obj60 = obj59;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v44+E4]");
							bool flag51 = (nint)0 == 0;
							object obj61 = !flag51;
							if (obj61 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text4 = BinUtils.BytesToHex((ReadOnlySpan<byte>)memory, 0);
							bool flag52 = text4 == null;
							readOnlySpan3 = (ReadOnlySpan<byte>)0;
							ex4 = (NullReferenceException)(object)text4;
							if (!flag52)
							{
								nint num13 = (nint)array4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan3 = (ReadOnlySpan<byte>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag53 = ex3 == null;
								ex4 = (NullReferenceException)(object)ex3;
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v36 (Il2CppClass<System.Object[]>)+40]");
								readOnlySpan2 = (ReadOnlySpan<byte>)0;
								obj7 = 0;
								if (flag53)
								{
									goto IL_1204;
								}
							}
							object obj62 = array4.Length & 0xFFFFFFFCL;
							bool flag54 = obj62 == null;
							obj5 = 0;
							obj7 = 0;
							if (!flag54)
							{
								object obj63 = array4 + 56;
								obj63 = text4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4EA8]");
								object obj64 = 0;
								format = (string)obj64;
								obj5 = 0;
								args = array4;
								goto IL_1312;
							}
						}
					}
				}
				goto IL_11b7;
			}
		}
		goto IL_1254;
		IL_1312:
		string text5 = string.Format(format, args);
		ref string reference = ref *(string*)text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		readOnlySpan2 = (ReadOnlySpan<byte>)text5;
		obj7 = 0;
		goto IL_117f;
		IL_1204:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		if (num14 == 0)
		{
			ex = new ArgumentNullException();
			readOnlySpan2 = (ReadOnlySpan<byte>)0;
			goto IL_1254;
		}
		goto IL_1299;
		IL_1254:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		bool flag55 = num15 != 0;
		ex4 = (NullReferenceException)(object)ex;
		if (!flag55)
		{
			ex4 = new NullReferenceException();
		}
		goto IL_1299;
		IL_11b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		bool flag56 = num16 != 0;
		readOnlySpan2 = readOnlySpan3;
		if (!flag56)
		{
			ex3 = new IndexOutOfRangeException();
			readOnlySpan2 = readOnlySpan3;
			goto IL_1204;
		}
		goto IL_1299;
		IL_1299:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		return;
		IL_117f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ SYSREG+28]");
		bool flag57 = num17 != 0;
		ex4 = (NullReferenceException)flag2;
		if (!flag57)
		{
			return;
		}
		goto IL_1299;
		IL_12fd:
		format = (string)obj30;
		args = array2;
		goto IL_1312;
	}
}
