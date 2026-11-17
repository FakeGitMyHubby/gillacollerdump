using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Photon.Client;

public class NonAllocDictionary<K, V> : IEnumerable<KeyValuePair<int, int>>, _0021_00210, IEnumerable<KeyValuePair<object, object>>, _0021_00210
{
	public struct KeyIterator : _0021_00210, IEnumerable<KeyValuePair<K, V>>, _0021_00210
	{
		private int _index;

		private NonAllocDictionary<K, V> _dict;

		private unsafe object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_002a: Expected Obj, but got I
				//IL_003f: Expected Obj, but got I
				//IL_0062: Expected Obj, but got I4
				//IL_007e: Expected Obj, but got I
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Expected Obj, but got Unknown
				//IL_00a7: Expected Obj, but got I4
				//IL_00da: Expected Obj, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+KeyIterator<K, V>)+8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v3+28]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v5+18]");
					bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < unchecked((nint)null);
					object obj3 = !flag;
					if (obj3 == null)
					{
						object obj4 = (nint)0 + (nint)309;
						object obj5 = obj4 & 1;
						bool flag2 = obj5 == null;
						object obj6 = !flag2;
						nint num = 0;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v12 (Il2CppClass<Photon.Client.NonAllocDictionary`2+KeyIterator>)+A8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object result = default;
						return result;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex = default;
					ex._002Ector();
					ArgumentNullException ex2 = new ArgumentNullException();
				}
				return new IndexOutOfRangeException();
			}
		}

		public unsafe K Current
		{
			get
			{
				//IL_00ea: Expected VT, but got Obj
				//IL_002a: Expected Obj, but got I
				//IL_010b: Expected VT, but got Obj
				//IL_005f: Expected Obj, but got I
				//IL_00a2: Expected Obj, but got I4
				//IL_00bb: Expected Obj, but got I
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected Obj, but got Unknown
				//IL_00e0: Expected VT, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+KeyIterator<K, V>)+8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+KeyIterator<K, V>)+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X9_v2+28]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X9_v2+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X9_v5+18]");
							bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < unchecked((nint)null);
							object obj3 = !flag;
							if (obj3 == null)
							{
								object obj4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) * (nint)24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X9_v2+28]");
								object obj5 = 0 + obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+21]");
								return (K)0;
							}
							goto IL_00fd;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					goto IL_00fd;
				}
				return (K)null;
				IL_00fd:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (K)ex2;
			}
		}

		public unsafe KeyIterator(NonAllocDictionary<K, V> dictionary)
		{
			//IL_0009: Expected VT, but got I4
			//IL_0014: Expected Obj, but got Ref
			KeyIterator keyIterator = (KeyIterator)0;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public unsafe KeyIterator GetEnumerator()
		{
			//IL_0002: Expected VT, but got Ref
			return (KeyIterator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		public void Reset()
		{
			//IL_0009: Expected VT, but got I4
			KeyIterator keyIterator = (KeyIterator)0;
		}

		public unsafe bool MoveNext()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0015: Expected Obj, but got Ref
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected Obj, but got Unknown
			//IL_0118: Expected VT, but got Obj
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_013c: Expected VT, but got Obj
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected Obj, but got Unknown
			//IL_0160: Expected VT, but got Obj
			//IL_016e: Expected I4, but got Obj
			//IL_010b: Expected Obj, but got I4
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected Obj, but got Unknown
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected Obj, but got Unknown
			//IL_020b: Expected VT, but got Obj
			//IL_0051: Expected Obj, but got I
			//IL_0097: Expected Obj, but got I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+KeyIterator<K, V>)+8]");
			object obj = 0;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			object obj3;
			object obj4;
			KeyIterator keyIterator;
			while (true)
			{
				obj3 = obj2 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+KeyIterator<K, V>)+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
					if ((nint)obj3 >= 0)
					{
						obj4 = 0;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X14_v6+18]");
						bool flag = (nint)obj3 < 0;
						object obj6 = !flag;
						if (obj6 == null)
						{
							object obj7 = obj3 * 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
							object obj8 = 0 + obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X11_v4+20]");
							bool flag2 = (nint)0 == 0;
							obj2 = obj3;
							if (!flag2)
							{
								obj4 = obj3;
								break;
							}
							continue;
						}
						goto IL_014a;
					}
				}
				else
				{
					keyIterator = (KeyIterator)obj3;
					NullReferenceException ex = new NullReferenceException();
				}
				object obj9 = obj2 + 1;
				keyIterator = (KeyIterator)obj9;
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_014a;
				IL_014a:
				object obj10 = obj2 + 1;
				keyIterator = (KeyIterator)obj10;
				IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
				return (byte)(int)ex3 != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
			object obj11 = obj3 - 0;
			bool flag3 = (nint)obj11 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
			object obj12 = obj3 ^ 0;
			object obj13 = obj3 ^ obj11;
			object obj14 = obj12 & obj13;
			bool flag4 = (nint)obj14 < 0;
			keyIterator = (KeyIterator)obj4;
			bool flag5 = flag3 == flag4;
			return !flag5;
		}

		public void Dispose()
		{
		}
	}

	public struct ValueIterator : IEnumerable<KeyValuePair<K, V>>, _0021_00210, IEnumerable<KeyValuePair<K, V>>
	{
		private int _index;

		private NonAllocDictionary<K, V> _dict;

		public unsafe V Current
		{
			get
			{
				//IL_00ea: Expected VT, but got Obj
				//IL_002a: Expected Obj, but got I
				//IL_010b: Expected VT, but got Obj
				//IL_005f: Expected Obj, but got I
				//IL_00a2: Expected Obj, but got I4
				//IL_00bb: Expected Obj, but got I
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected Obj, but got Unknown
				//IL_00e0: Expected VT, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+ValueIterator<K, V>)+8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+ValueIterator<K, V>)+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X9_v2+28]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X9_v2+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X9_v5+18]");
							bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < unchecked((nint)null);
							object obj3 = !flag;
							if (obj3 == null)
							{
								object obj4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) * (nint)24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X9_v2+28]");
								object obj5 = 0 + obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+28]");
								return (V)0;
							}
							goto IL_00fd;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					goto IL_00fd;
				}
				return (V)null;
				IL_00fd:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (V)ex2;
			}
		}

		private unsafe object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_002a: Expected Obj, but got I
				//IL_003f: Expected Obj, but got I
				//IL_0062: Expected Obj, but got I4
				//IL_007b: Expected Obj, but got I
				//IL_0095: Expected Obj, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+ValueIterator<K, V>)+8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v3+28]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X9_v5+18]");
					bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < unchecked((nint)null);
					object obj3 = !flag;
					if (obj3 == null)
					{
						object obj4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) * (nint)24;
						object obj5 = obj2 + obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v2+28]");
						return 0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					InvalidOperationException ex = default;
					ex._002Ector();
					ArgumentNullException ex2 = new ArgumentNullException();
				}
				return new IndexOutOfRangeException();
			}
		}

		public unsafe ValueIterator(NonAllocDictionary<K, V> dictionary)
		{
			//IL_0009: Expected VT, but got I4
			//IL_0014: Expected Obj, but got Ref
			ValueIterator valueIterator = (ValueIterator)0;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public unsafe ValueIterator GetEnumerator()
		{
			//IL_0002: Expected VT, but got Ref
			return (ValueIterator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		}

		public void Reset()
		{
			//IL_0009: Expected VT, but got I4
			ValueIterator valueIterator = (ValueIterator)0;
		}

		public unsafe bool MoveNext()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0015: Expected Obj, but got Ref
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected Obj, but got Unknown
			//IL_0118: Expected VT, but got Obj
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_013c: Expected VT, but got Obj
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected Obj, but got Unknown
			//IL_0160: Expected VT, but got Obj
			//IL_016e: Expected I4, but got Obj
			//IL_010b: Expected Obj, but got I4
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected Obj, but got Unknown
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected Obj, but got Unknown
			//IL_020b: Expected VT, but got Obj
			//IL_0051: Expected Obj, but got I
			//IL_0097: Expected Obj, but got I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+ValueIterator<K, V>)+8]");
			object obj = 0;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			object obj3;
			object obj4;
			ValueIterator valueIterator;
			while (true)
			{
				obj3 = obj2 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+ValueIterator<K, V>)+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
					if ((nint)obj3 >= 0)
					{
						obj4 = 0;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X14_v6+18]");
						bool flag = (nint)obj3 < 0;
						object obj6 = !flag;
						if (obj6 == null)
						{
							object obj7 = obj3 * 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
							object obj8 = 0 + obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X11_v4+20]");
							bool flag2 = (nint)0 == 0;
							obj2 = obj3;
							if (!flag2)
							{
								obj4 = obj3;
								break;
							}
							continue;
						}
						goto IL_014a;
					}
				}
				else
				{
					valueIterator = (ValueIterator)obj3;
					NullReferenceException ex = new NullReferenceException();
				}
				object obj9 = obj2 + 1;
				valueIterator = (ValueIterator)obj9;
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_014a;
				IL_014a:
				object obj10 = obj2 + 1;
				valueIterator = (ValueIterator)obj10;
				IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
				return (byte)(int)ex3 != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
			object obj11 = obj3 - 0;
			bool flag3 = (nint)obj11 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
			object obj12 = obj3 ^ 0;
			object obj13 = obj3 ^ obj11;
			object obj14 = obj12 & obj13;
			bool flag4 = (nint)obj14 < 0;
			valueIterator = (ValueIterator)obj4;
			bool flag5 = flag3 == flag4;
			return !flag5;
		}

		public void Dispose()
		{
		}
	}

	public struct PairIterator : _0021_00210, IEnumerable<KeyValuePair<byte, object>>, _0021_00210
	{
		private int _index;

		private NonAllocDictionary<K, V> _dict;

		private unsafe object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_0026: Expected Obj, but got I
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected Obj, but got Unknown
				//IL_004e: Expected Obj, but got I4
				//IL_0081: Expected Obj, but got I
				//IL_00a7: Expected Obj, but got I
				//IL_00c1: Expected Obj, but got I4
				//IL_00f4: Expected Obj, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					object obj = (nint)0 + (nint)309;
					object obj2 = obj & 1;
					bool flag = obj2 == null;
					object obj3 = !flag;
					nint num = 0;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v8 (Il2CppClass<Photon.Client.NonAllocDictionary`2+PairIterator>)+A8]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F298");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v11 (Il2CppClass<Photon.Client.NonAllocDictionary`2+PairIterator>)+135]");
					object obj5 = (nint)0 & (nint)1;
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					nint num3 = 0;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12 (Il2CppClass<Photon.Client.NonAllocDictionary`2+PairIterator>)+A8]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					object result = default;
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				InvalidOperationException ex = default;
				ex._002Ector();
				return new ArgumentNullException();
			}
		}

		public unsafe KeyValuePair<K, V> Current
		{
			get
			{
				//IL_015c: Expected VT, but got I4
				//IL_002a: Expected Obj, but got I
				//IL_017d: Expected VT, but got Obj
				//IL_005f: Expected Obj, but got I
				//IL_00a2: Expected Obj, but got I4
				//IL_00c1: Expected Obj, but got I
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Expected Obj, but got Unknown
				//IL_00ec: Expected Obj, but got I
				//IL_0106: Expected Obj, but got I4
				//IL_0146: Expected Obj, but got I
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+PairIterator<K, V>)+8]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+PairIterator<K, V>)+8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2+28]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X9_v5+18]");
							bool flag = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) < unchecked((nint)null);
							object obj3 = !flag;
							if (obj3 == null)
							{
								nint num = 0;
								object obj4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) * (nint)24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2+28]");
								object obj5 = 0 + obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v6 (Il2CppClass<Photon.Client.NonAllocDictionary`2+PairIterator>)+135]");
								object obj6 = (nint)0 & (nint)1;
								bool flag2 = obj6 == null;
								object obj7 = !flag2;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v3+21]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v3+28]");
								KeyValuePair<byte, System.__Canon> result = new KeyValuePair<byte, System.__Canon>((byte)num2, (System.__Canon)0);
								return (KeyValuePair<K, V>)result;
							}
							goto IL_016f;
						}
					}
					NullReferenceException ex = new NullReferenceException();
					goto IL_016f;
				}
				return (KeyValuePair<K, V>)0;
				IL_016f:
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				return (KeyValuePair<K, V>)ex2;
			}
		}

		public unsafe PairIterator(NonAllocDictionary<K, V> dictionary)
		{
			//IL_0009: Expected VT, but got I4
			//IL_0014: Expected Obj, but got Ref
			PairIterator pairIterator = (PairIterator)0;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public void Reset()
		{
			//IL_0009: Expected VT, but got I4
			PairIterator pairIterator = (PairIterator)0;
		}

		public unsafe bool MoveNext()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0015: Expected Obj, but got Ref
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Expected Obj, but got Unknown
			//IL_0118: Expected VT, but got Obj
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_013c: Expected VT, but got Obj
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected Obj, but got Unknown
			//IL_0160: Expected VT, but got Obj
			//IL_016e: Expected I4, but got Obj
			//IL_010b: Expected Obj, but got I4
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected Obj, but got Unknown
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected Obj, but got Unknown
			//IL_020b: Expected VT, but got Obj
			//IL_0051: Expected Obj, but got I
			//IL_0097: Expected Obj, but got I4
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+PairIterator<K, V>)+8]");
			object obj = 0;
			object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			object obj3;
			object obj4;
			PairIterator pairIterator;
			while (true)
			{
				obj3 = obj2 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Photon.Client.NonAllocDictionary`2<K, V>+PairIterator<K, V>)+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
					if ((nint)obj3 >= 0)
					{
						obj4 = 0;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X14_v6+18]");
						bool flag = (nint)obj3 < 0;
						object obj6 = !flag;
						if (obj6 == null)
						{
							object obj7 = obj3 * 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+28]");
							object obj8 = 0 + obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X11_v4+20]");
							bool flag2 = (nint)0 == 0;
							obj2 = obj3;
							if (!flag2)
							{
								obj4 = obj3;
								break;
							}
							continue;
						}
						goto IL_014a;
					}
				}
				else
				{
					pairIterator = (PairIterator)obj3;
					NullReferenceException ex = new NullReferenceException();
				}
				object obj9 = obj2 + 1;
				pairIterator = (PairIterator)obj9;
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_014a;
				IL_014a:
				object obj10 = obj2 + 1;
				pairIterator = (PairIterator)obj10;
				IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
				return (byte)(int)ex3 != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
			object obj11 = obj3 - 0;
			bool flag3 = (nint)obj11 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X9_v1+18]");
			object obj12 = obj3 ^ 0;
			object obj13 = obj3 ^ obj11;
			object obj14 = obj12 & obj13;
			bool flag4 = (nint)obj14 < 0;
			pairIterator = (PairIterator)obj4;
			bool flag5 = flag3 == flag4;
			return !flag5;
		}

		public void Dispose()
		{
		}
	}

	private static uint[] _primeTableUInt;

	private int _freeHead;

	private int _freeCount;

	private int _usedCount;

	private uint _capacity;

	private int[] _buckets;

	private EnetChannel.Node<K, V>[] _nodes;

	private bool isReadOnly;

	private ICollection<K> keys;

	private ICollection<V> values;

	public KeyIterator Keys
	{
		get
		{
			//IL_0016: Expected Obj, but got I
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AB8B48");
			KeyIterator result = default;
			return result;
		}
	}

	private ICollection<V> System_002ECollections_002EGeneric_002EIDictionary_003CK_002CV_003E_002EValues => values;

	private ICollection<K> System_002ECollections_002EGeneric_002EIDictionary_003CK_002CV_003E_002EKeys => keys;

	public ValueIterator Values
	{
		get
		{
			//IL_0016: Expected Obj, but got I
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @460DC58");
			ValueIterator result = default;
			return result;
		}
	}

	public int Count
	{
		get
		{
			int num = ~_freeCount;
			return _usedCount + num;
		}
	}

	public bool IsReadOnly => isReadOnly;

	public uint Capacity => _capacity;

	// C# has no syntax for parameterized property 'Item'.
	public V get_Item(K key)
	{
		//IL_0125: Expected VT, but got Obj
		//IL_006b: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a3: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		if (obj != null)
		{
			EnetChannel.Node<K, V>[] nodes = _nodes;
			if (_nodes != null)
			{
				bool flag = (nint)obj < nodes.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = obj * 24;
					object obj4 = (object)_nodes + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+28]");
					return (V)0;
				}
				goto IL_0117;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			byte b = default;
			string text = b.ToString();
			string text2 = default;
			string message = text2 + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			ArgumentNullException ex2 = new ArgumentNullException();
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0117;
		IL_0117:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		return (V)ex4;
	}

	public unsafe void set_Item(K key, V value)
	{
		//IL_01ad: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_00b1: Expected I4, but got VT
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		if (obj != null)
		{
			EnetChannel.Node<K, V>[] nodes = _nodes;
			if (_nodes == null)
			{
				goto IL_01b8;
			}
			bool flag = (nint)obj < nodes.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = obj * 24;
				object obj4 = (object)_nodes + obj3;
				byte b = (byte)(obj4 + 33);
				bool flag2 = ((byte*)b)->Equals((byte)(int)key);
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v7 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v6+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v11 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
					obj5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5E48");
				EnetChannel.Node<K, V>[] nodes2 = _nodes;
				if (_nodes == null)
				{
					goto IL_01b8;
				}
				bool flag4 = (nint)obj < nodes2.Length;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					object obj9 = obj * 24;
					object obj10 = (object)_nodes + obj9;
					object obj11 = obj10 + 40;
					obj11 = value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
			goto IL_01c6;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB55E4");
		return;
		IL_01b8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c6;
		IL_01c6:
		throw new IndexOutOfRangeException();
	}

	public NonAllocDictionary(uint capacity = default(uint))
	{
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v17 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			obj = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5B24");
		object obj5 = default;
		object obj4 = obj5 & 1;
		bool flag2 = obj4 == null;
		object obj6 = !flag2;
		uint capacity2 = capacity;
		if (obj6 == null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v12 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v14+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v19+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v15 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
				obj7 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5C2C");
			uint num5 = default;
			capacity2 = num5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj9 = 0;
		_usedCount = 1;
		_capacity = capacity2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj10 = this + 32;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 40;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public bool ContainsKey(K key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		bool flag = obj == null;
		return !flag;
	}

	public bool Contains(KeyValuePair<K, V> item)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_015e: Expected I4, but got Obj
		//IL_00b2: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj2 = default;
		object obj = obj2 & 0x80000000L;
		bool flag = obj == null;
		object obj3 = !flag;
		if (obj3 != null)
		{
			goto IL_013c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X3+20]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v1+A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @307EE78");
		EnetChannel.Node<K, V>[] nodes = _nodes;
		if (_nodes != null)
		{
			bool flag2 = (nint)obj2 < nodes.Length;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_0150;
			}
			object obj7 = default;
			if (obj7 != null)
			{
				object obj8 = obj2 * 24;
				object obj9 = (object)_nodes + obj8;
				object obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v5+1B8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v5+1C0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v53 @ X4_v1 (should have been resolved before IL gen)");
				goto IL_013c;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0150;
		IL_013c:
		return false;
		IL_0150:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public unsafe bool TryGetValue(K key, out V val)
	{
		//IL_00df: Expected I4, but got Obj
		//IL_006b: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		ref V reference;
		if (obj != null)
		{
			EnetChannel.Node<K, V>[] nodes = _nodes;
			if (_nodes != null)
			{
				bool flag = (nint)obj < nodes.Length;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = obj * 24;
					object obj4 = (object)_nodes + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+28]");
					reference = ref *(V*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_00df;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
		reference = ref *(V*)null;
		goto IL_00df;
		IL_00df:
		bool flag2 = obj == null;
		return !flag2;
	}

	public unsafe void Set(K key, V val)
	{
		//IL_01ad: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_00b1: Expected I4, but got VT
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		if (obj != null)
		{
			EnetChannel.Node<K, V>[] nodes = _nodes;
			if (_nodes == null)
			{
				goto IL_01b8;
			}
			bool flag = (nint)obj < nodes.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = obj * 24;
				object obj4 = (object)_nodes + obj3;
				byte b = (byte)(obj4 + 33);
				bool flag2 = ((byte*)b)->Equals((byte)(int)key);
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v7 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v6+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v11 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
					obj5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5E48");
				EnetChannel.Node<K, V>[] nodes2 = _nodes;
				if (_nodes == null)
				{
					goto IL_01b8;
				}
				bool flag4 = (nint)obj < nodes2.Length;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					object obj9 = obj * 24;
					object obj10 = (object)_nodes + obj9;
					object obj11 = obj10 + 40;
					obj11 = val;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
				}
			}
			goto IL_01c6;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB55E4");
		return;
		IL_01b8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c6;
		IL_01c6:
		throw new IndexOutOfRangeException();
	}

	public void Add(K key, V val)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB55E4");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		byte b = default;
		string text = b.ToString();
		string text2 = default;
		string message = text2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex = default;
		ex._002Ector(message);
		throw new ArgumentNullException();
	}

	public void Add(KeyValuePair<K, V> item)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5508");
		object obj = default;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ X3+20]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v1+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB55E4");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		byte b = default;
		string text = b.ToString();
		string text2 = default;
		string message = text2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex = default;
		ex._002Ector(message);
		throw new ArgumentNullException();
	}

	public unsafe bool Remove(K key)
	{
		//IL_051d: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected I4, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I4
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_0455: Expected Obj, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0346: Expected Obj, but got I4
		//IL_0361: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I4
		//IL_0558: Expected Obj, but got I4
		//IL_04af: Expected Obj, but got I4
		byte obj = default;
		int hashCode = obj.GetHashCode();
		int[] buckets = _buckets;
		if (_buckets != null)
		{
			int num = hashCode / (int)_capacity;
			object obj2 = num * (int)_capacity;
			object obj3 = hashCode - obj2;
			bool flag = (nint)obj3 < buckets.Length;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0501;
			}
			object obj5 = (object)_buckets + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v4+20]");
			int num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v4+20]");
			if ((nint)0 == 0)
			{
				goto IL_0278;
			}
			EnetChannel.Node<K, V>[] nodes = _nodes;
			int num3 = 0;
			while (nodes != null)
			{
				bool flag2 = num2 < nodes.Length;
				object obj6 = !flag2;
				object obj13;
				EnetChannel.Node<K, V>[] nodes3;
				if (obj6 == null)
				{
					object obj7 = nodes + 32;
					object obj8 = num2 * 24;
					object obj9 = obj7 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v8+14]");
					if ((nint)0 == hashCode)
					{
						object obj10 = num2 * 24;
						object obj11 = obj7 + obj10;
						byte b = (byte)(obj11 + 1);
						bool flag3 = ((byte*)b)->Equals(obj);
						bool flag4 = !flag3;
						object obj12 = !flag4;
						if (obj12 != null)
						{
							if (num3 != 0)
							{
								EnetChannel.Node<K, V>[] nodes2 = _nodes;
								if (_nodes == null)
								{
									break;
								}
								obj13 = nodes2.Length;
								bool flag5 = num2 < nodes2.Length;
								object obj14 = !flag5;
								if (obj14 == null)
								{
									bool flag6 = num3 < nodes2.Length;
									object obj15 = !flag6;
									if (obj15 == null)
									{
										object obj16 = _nodes + 32;
										object obj17 = num2 * 24;
										object obj18 = obj16 + obj17;
										object obj19 = num3 * 24;
										object obj20 = obj16 + obj19;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X12_v10+10]");
										_ = 0;
										nodes3 = _nodes;
										goto IL_053f;
									}
								}
							}
							else
							{
								nodes3 = _nodes;
								if (_nodes == null)
								{
									break;
								}
								obj13 = nodes3.Length;
								bool flag7 = num2 < nodes3.Length;
								object obj21 = !flag7;
								if (obj21 == null)
								{
									int[] buckets2 = _buckets;
									if (_buckets == null)
									{
										break;
									}
									int num4 = hashCode / (int)_capacity;
									object obj22 = num4 * (int)_capacity;
									object obj23 = hashCode - obj22;
									bool flag8 = (nint)obj23 < buckets2.Length;
									object obj24 = !flag8;
									if (obj24 == null)
									{
										object obj25 = (object)_buckets + obj23;
										object obj26 = num2 * 24;
										object obj27 = (object)_nodes + obj26;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X12_v8+30]");
										_ = 0;
										goto IL_053f;
									}
								}
							}
							goto IL_0501;
						}
						nodes = _nodes;
						if (_nodes == null)
						{
							break;
						}
					}
					bool flag9 = num2 < nodes.Length;
					object obj28 = !flag9;
					if (obj28 == null)
					{
						object obj29 = num2 * 24;
						object obj30 = (object)nodes + obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X9_v12+30]");
						bool flag10 = (nint)0 == 0;
						object obj31 = !flag10;
						num3 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X9_v12+30]");
						num2 = 0;
						if (obj31 != null)
						{
							continue;
						}
						goto IL_0278;
					}
				}
				goto IL_0501;
				IL_053f:
				bool flag11 = num2 < (nint)obj13;
				object obj32 = !flag11;
				if (obj32 == null)
				{
					object obj33 = num2 * 24;
					object obj34 = (object)nodes3 + obj33;
					_ = 0;
					_ = 0;
					_ = _freeHead;
					int freeCount = _freeCount + 1;
					_freeHead = num2;
					_freeCount = freeCount;
					return true;
				}
				goto IL_0501;
			}
		}
		goto IL_050f;
		IL_050f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0278:
		return false;
		IL_0501:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_050f;
	}

	public bool Remove(KeyValuePair<K, V> item)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB4D38");
		object obj2 = default;
		object obj = obj2 & 1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB524C");
			bool result = default;
			return result;
		}
		return false;
	}

	private IEnumerator<KeyValuePair<K, V>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CK_002CV_003E_003E_002EGetEnumerator()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F1E4");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator<KeyValuePair<K, V>> result = default;
		return result;
	}

	public PairIterator GetEnumerator()
	{
		//IL_0016: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F1E4");
		PairIterator result = default;
		return result;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v1 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @406F1E4");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		IEnumerator result = default;
		return result;
	}

	private unsafe int FindNode(K key)
	{
		//IL_02b0: Expected I4, but got Obj
		//IL_0054: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected I4, but got Unknown
		//IL_01bb: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		byte obj = default;
		int hashCode = obj.GetHashCode();
		int[] buckets = _buckets;
		int result;
		if (_buckets != null)
		{
			int num = hashCode / (int)_capacity;
			object obj2 = num * (int)_capacity;
			object obj3 = hashCode - obj2;
			bool flag = (nint)obj3 < buckets.Length;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0294;
			}
			object obj5 = (object)_buckets + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v4+20]");
			result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v4+20]");
			if ((nint)0 == 0)
			{
				goto IL_028f;
			}
			EnetChannel.Node<K, V>[] nodes = _nodes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v4+20]");
			int num2 = 0;
			while (nodes != null)
			{
				bool flag2 = num2 < nodes.Length;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					object obj7 = nodes + 32;
					object obj8 = num2 * 24;
					object obj9 = obj7 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X10_v7+14]");
					if ((nint)0 == hashCode)
					{
						object obj10 = num2 * 24;
						object obj11 = obj7 + obj10;
						byte b = (byte)(obj11 + 1);
						bool flag3 = ((byte*)b)->Equals(obj);
						bool flag4 = !flag3;
						object obj12 = !flag4;
						result = num2;
						if (obj12 != null)
						{
							goto IL_028f;
						}
						nodes = _nodes;
						if (_nodes == null)
						{
							break;
						}
					}
					bool flag5 = num2 < nodes.Length;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						object obj14 = num2 * 24;
						object obj15 = (object)nodes + obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v10+30]");
						result = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v10+30]");
						bool flag6 = (nint)0 == 0;
						object obj16 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X9_v10+30]");
						num2 = 0;
						if (obj16 != null)
						{
							continue;
						}
						goto IL_028f;
					}
				}
				goto IL_0294;
			}
		}
		goto IL_02a2;
		IL_02a2:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_028f:
		return result;
		IL_0294:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_02a2;
	}

	private void Insert(K key, V val)
	{
		//IL_010e: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got VT
		//IL_02a6: Expected Obj, but got I4
		int num = _freeCount - 1;
		int num2;
		if (num >= 1)
		{
			EnetChannel.Node<K, V>[] nodes = _nodes;
			if (_nodes == null)
			{
				goto IL_02c9;
			}
			num2 = _freeHead;
			bool flag = _freeHead < nodes.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_02d7;
			}
			object obj2 = _freeHead * 24;
			object obj3 = (object)_nodes + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v10+30]");
			_freeHead = 0;
			_freeCount = num;
		}
		else
		{
			num2 = _usedCount;
			if (_usedCount == (int)_capacity)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v15 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5728");
				num2 = _usedCount;
			}
			int usedCount = num2 + 1;
			_usedCount = usedCount;
		}
		byte b = default;
		int hashCode = b.GetHashCode();
		EnetChannel.Node<K, V>[] nodes2 = _nodes;
		if (_nodes == null)
		{
			goto IL_02c9;
		}
		bool flag2 = num2 < nodes2.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = _nodes + 32;
			object obj7 = num2 * 24;
			object obj8 = obj6 + obj7;
			int[] buckets = _buckets;
			obj8 = 1;
			if (_buckets == null)
			{
				goto IL_02c9;
			}
			int num4 = hashCode / (int)_capacity;
			object obj9 = num4 * (int)_capacity;
			object obj10 = hashCode - obj9;
			bool flag3 = (nint)obj10 < buckets.Length;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				object obj12 = (object)_buckets + obj10;
				object obj13 = num2 * 24;
				object obj14 = obj6 + obj13;
				object obj15 = obj14 + 8;
				obj15 = val;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X9_v5+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				int[] buckets2 = _buckets;
				if (_buckets == null)
				{
					goto IL_02c9;
				}
				bool flag4 = (nint)obj10 < buckets2.Length;
				object obj16 = !flag4;
				if (obj16 == null)
				{
					object obj17 = (object)_buckets + obj10;
					return;
				}
			}
		}
		goto IL_02d7;
		IL_02c9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02d7;
		IL_02d7:
		throw new IndexOutOfRangeException();
	}

	private void Expand()
	{
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_04aa: Expected Obj, but got I
		//IL_04d9: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_0272: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0331: Expected Obj, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_0361: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I4
		object obj = this + 32;
		object obj2 = obj;
		if (obj != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v7+40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v29 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
				obj3 = 0;
			}
			int usedCount = _usedCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X9_v1+18]");
			object obj7 = (nint)usedCount - (nint)0;
			bool flag2 = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5E48");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v8 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5C2C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v10 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj9 = 0;
			uint num5 = default;
			bool flag3 = (int)num5 < (int)_capacity;
			object obj10 = !flag3;
			object obj11 = num5 - _capacity;
			bool flag4 = obj11 == null;
			object obj12 = !flag4;
			object obj13 = obj10 & obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5E48");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v12 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj15 = this + 40;
			Array array = (Array)obj15;
			bool flag5 = obj15 == null;
			uint num7 = num5;
			int[] array3 = default;
			int[] array2 = array3;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v15 (System.Array)+18]");
				Array array4 = default;
				Array.Copy((Array)obj15, 0, array4, 0, 0);
				object obj16 = obj15;
				bool flag6 = obj15 == null;
				object obj17 = 0;
				int num8 = 0;
				Array array5 = array4;
				Array array6 = array4;
				num7 = num5;
				array2 = array3;
				if (!flag6)
				{
					object obj18 = array4 + 32;
					object obj19 = 1;
					int num9 = 0;
					while (true)
					{
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v17+18]");
						bool flag7 = (nint)obj20 >= 0;
						obj17 = 0;
						num8 = 0;
						array5 = array4;
						array6 = array4;
						num7 = num5;
						array2 = array3;
						if (!flag7)
						{
							bool flag8 = array4 == null;
							obj17 = 0;
							num8 = 0;
							array5 = array4;
							array6 = array4;
							num7 = num5;
							array2 = array3;
							if (flag8)
							{
								break;
							}
							object obj21 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v18 (System.Array)+18]");
							bool flag9 = (nint)obj21 < 0;
							object obj22 = !flag9;
							if (obj22 == null)
							{
								nint num10 = 0;
								object obj23 = obj19 * 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v21 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
								object obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v23+40]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v23+E4]");
								bool flag10 = (nint)0 == 0;
								object obj26 = !flag10;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									nint num11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v27 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
									obj24 = 0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X26_v4+v148 @ X9_v7]");
								bool flag11 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v23+E8]");
								num9 = 0;
								object obj27 = !flag11;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FB5E48");
								object obj28 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v18 (System.Array)+18]");
								bool flag12 = (nint)obj28 < 0;
								object obj29 = !flag12;
								if (obj29 == null)
								{
									bool flag13 = array3 == null;
									obj17 = 0;
									num8 = 0;
									array5 = array4;
									array6 = array4;
									num7 = num5;
									array2 = array3;
									if (flag13)
									{
										break;
									}
									object obj30 = obj19 * 24;
									object obj31 = obj18 + obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v8+14]");
									int num12 = (int)((nint)0 / (nint)(int)num5);
									object obj32 = num12 * (int)num5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v8+14]");
									object obj33 = 0 - obj32;
									bool flag14 = (nint)obj33 < array3.Length;
									object obj34 = !flag14;
									if (obj34 == null)
									{
										object obj35 = (object)array3 + obj33;
										object obj36 = obj19 * 24;
										object obj37 = obj18 + obj36;
										obj16 = obj15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X9_v11+20]");
										_ = 0;
										obj19++;
										bool flag15 = obj15 == null;
										object obj38 = !flag15;
										obj17 = 0;
										num8 = 0;
										array5 = array4;
										array6 = array4;
										num7 = num5;
										array2 = array3;
										if (obj38 == null)
										{
											break;
										}
										continue;
									}
								}
							}
							throw new IndexOutOfRangeException();
						}
						_nodes = (EnetChannel.Node<K, V>[])array6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_buckets = array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_capacity = num7;
						return;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	public void Clear()
	{
		if (_usedCount >= 2)
		{
			Array nodes = _nodes;
			EnetChannel.Node<K, V>[] nodes2 = _nodes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X0_v2 (System.Array)+18]");
			Array.Clear(nodes2, 0, 0);
			Array buckets = _buckets;
			int[] buckets2 = _buckets;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X0_v5 (System.Array)+18]");
			Array.Clear(buckets2, 0, 0);
			_freeHead = 0;
			_usedCount = 1;
		}
	}

	private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CK_002CV_003E_003E_002ECopyTo(KeyValuePair<K, V>[] array, int index)
	{
		//IL_002f: Expected I4, but got I8
		//IL_0049: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0231: Expected VT, but got I4
		KeyValuePair<K, V>[] array2 = default;
		if (array2 != null)
		{
			int num2 = default;
			int num = (int)(num2 & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = array2.Length - num2;
				if ((nint)obj2 >= num2)
				{
					int num3 = ~_freeCount;
					object obj3 = _usedCount + num3;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
					{
						EnetChannel.Node<K, V>[] nodes = _nodes;
						object obj4 = array2 + 32;
						KeyValuePair<K, V>[] array3 = array2;
						object obj5 = 1;
						object obj6 = 0;
						int num4 = num2;
						while (true)
						{
							if ((nint)obj5 >= nodes.Length)
							{
								return;
							}
							bool flag2 = (nint)obj5 < nodes.Length;
							object obj7 = !flag2;
							if (obj7 != null)
							{
								break;
							}
							object obj8 = (object)nodes + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v11+38]");
							if ((nint)0 != 0)
							{
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v11 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
								object obj9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v11+39]");
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v11+40]");
								KeyValuePair<byte, System.__Canon> keyValuePair = new KeyValuePair<byte, System.__Canon>((byte)num6, (System.__Canon)0);
								bool flag3 = num4 < array2.Length;
								object obj10 = !flag3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v11+39]");
								array3 = (KeyValuePair<K, V>[])0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v11+40]");
								num2 = 0;
								if (obj10 != null)
								{
									break;
								}
								object obj11 = obj4 + num4;
								object obj12 = array2 + num4;
								num4++;
								object obj13 = obj11 + 8;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								nodes = _nodes;
								keyValuePair = (KeyValuePair<byte, System.__Canon>)0;
								array3 = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v11+40]");
								num2 = 0;
							}
							obj6 += 24;
							obj5++;
							bool flag4 = nodes == null;
							object obj14 = !flag4;
							if (obj14 == null)
							{
								throw new NullReferenceException();
							}
						}
						throw new IndexOutOfRangeException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					ArgumentException ex = default;
					string message = default;
					ex._002Ector(message);
					goto IL_02f8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ArgumentOutOfRangeException ex2 = default;
			ex2._002Ector();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex3 = default;
			string paramName = default;
			ex3._002Ector(paramName);
		}
		goto IL_02f8;
		IL_02f8:
		throw new ArgumentNullException();
	}

	private static bool IsPrimeFromList(uint value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_03ca: Expected Obj, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_03be: Expected I4, but got Obj
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I
		//IL_027c: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			nint num = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			nint num2 = 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8+A0]");
			object obj13 = 0;
			object obj14 = obj13;
			if (obj13 != null)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+18]");
				if ((nint)obj15 < 0)
				{
					object obj16 = (nint)0 + (nint)309;
					object obj17 = obj16 & 1;
					bool flag4 = obj17 == null;
					object obj18 = !flag4;
					nint num3 = 0;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v15 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v16+40]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v16+E4]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj22 = (nint)0 + (nint)309;
					object obj23 = obj22 & 1;
					bool flag6 = obj23 == null;
					object obj24 = !flag6;
					nint num4 = 0;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v19 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v20+40]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v21+A0]");
					object obj27 = 0;
					object obj28 = obj27;
					if (obj27 == null)
					{
						goto IL_03a2;
					}
					object obj29 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v23+18]");
					bool flag7 = (nint)obj29 < 0;
					object obj30 = !flag7;
					if (obj30 != null)
					{
						break;
					}
					object obj31 = obj27 + obj;
					obj++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v24+20]");
					if ((nint)0 != (int)value)
					{
						continue;
					}
				}
				object obj32 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+18]");
				object obj33 = obj32 - 0;
				bool flag8 = (nint)obj33 < 0;
				object obj34 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+18]");
				object obj35 = obj34 ^ 0;
				object obj36 = obj ^ obj33;
				object obj37 = obj35 & obj36;
				bool flag9 = (nint)obj37 < 0;
				bool flag10 = flag8 == flag9;
				return !flag10;
			}
			goto IL_03a2;
			IL_03a2:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static uint GetNextPrime(uint value)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0692: Expected Obj, but got I
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got Unknown
		//IL_06ba: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I
		//IL_058b: Expected Obj, but got I
		//IL_059b: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I4
		//IL_0611: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_0686: Expected I4, but got Obj
		//IL_0314: Expected Obj, but got I4
		//IL_0329: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_040a: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0433: Expected Obj, but got I
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I
		//IL_049e: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I
		//IL_04f4: Expected Obj, but got I4
		object obj = 0;
		while (true)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			nint num = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			nint num2 = 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+A0]");
			object obj13 = 0;
			object obj14 = obj13;
			IndexOutOfRangeException ex;
			if (obj13 != null)
			{
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v11+18]");
				bool flag4 = (nint)obj15 >= 0;
				ex = (IndexOutOfRangeException)0;
				if (flag4)
				{
					break;
				}
				object obj16 = (nint)0 + (nint)309;
				object obj17 = obj16 & 1;
				bool flag5 = obj17 == null;
				object obj18 = !flag5;
				IndexOutOfRangeException ex2 = (IndexOutOfRangeException)0;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v38 (System.IndexOutOfRangeException)+A8]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v24+40]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v39+E4]");
				bool flag6 = (nint)0 == 0;
				object obj21 = !flag6;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = (nint)0 + (nint)309;
				object obj23 = obj22 & 1;
				bool flag7 = obj23 == null;
				object obj24 = !flag7;
				nint num3 = 0;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v42 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v28+40]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v29+A0]");
				object obj27 = 0;
				object obj28 = obj27;
				if (obj27 != null)
				{
					object obj29 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v31+18]");
					bool flag8 = (nint)obj29 < 0;
					object obj30 = !flag8;
					if (obj30 == null)
					{
						object obj31 = obj27 + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v32+20]");
						bool flag9 = (nint)0 < (nint)(int)value;
						object obj32 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v32+20]");
						object obj33 = -(int)value;
						bool flag10 = obj33 == null;
						object obj34 = !flag10;
						object obj35 = obj32 & obj34;
						if (obj35 == null)
						{
							obj++;
							continue;
						}
						object obj36 = (nint)0 + (nint)309;
						object obj37 = obj36 & 1;
						bool flag11 = obj37 == null;
						object obj38 = !flag11;
						nint num4 = 0;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v44 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v36+40]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v45+E4]");
						bool flag12 = (nint)0 == 0;
						object obj41 = !flag12;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj42 = (nint)0 + (nint)309;
						object obj43 = obj42 & 1;
						bool flag13 = obj43 == null;
						object obj44 = !flag13;
						nint num5 = 0;
						if (obj44 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v48 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
						object obj45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v40+40]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v41+A0]");
						object obj47 = 0;
						object obj48 = obj47;
						if (obj47 == null)
						{
							goto IL_051c;
						}
						object obj49 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v43+18]");
						bool flag14 = (nint)obj49 < 0;
						object obj50 = !flag14;
						if (obj50 == null)
						{
							object obj51 = obj47 + obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v44+20]");
							return 0u;
						}
					}
					goto IL_052a;
				}
			}
			goto IL_051c;
			IL_052a:
			ex = new IndexOutOfRangeException();
			break;
			IL_051c:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_052a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B37F4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v9+A8]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A1648");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B37F4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+A8]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v3+40]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X9_v4+A0]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B37F4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v15+A8]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v15+40]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v16+A0]");
		object obj58 = 0;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X21_v3+18]");
		object obj60 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @290D8D0");
		uint num6 = default;
		string text = ((uint*)num6)->ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		string text2 = default;
		string message = text2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		InvalidOperationException ex4 = default;
		ex4._002Ector(message);
		ArgumentNullException ex5 = new ArgumentNullException();
		return (uint)(int)ex5;
	}

	private static void Assert(bool condition)
	{
		if (condition)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		InvalidOperationException ex = default;
		string message = default;
		ex._002Ector(message);
		throw new ArgumentNullException();
	}

	static NonAllocDictionary()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8BC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9AC8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = default;
		object obj3 = obj4 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			nint num = 0;
		}
		else
		{
			nint num2 = 0;
			nint num = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X9_v3+40]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v4+A0]");
		object obj10 = 0;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+135]");
		object obj11 = (nint)0 & (nint)1;
		bool flag2 = obj11 == null;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			nint num = intPtr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<Photon.Client.NonAllocDictionary`2>)+A8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+40]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
