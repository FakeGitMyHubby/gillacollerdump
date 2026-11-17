using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Fusion;

public static class NestedComponentUtilities
{
	public struct CollisionEnterData
	{
		public float ImpactAlignment;

		public float RelativeVelocity;
	}

	private static Queue<Transform> nodesQueue;

	private static Stack<Transform> nodeStack;

	public static T EnsureRootComponentExists<T, TStopOn>(Transform transform) where T : Component where TStopOn : Component
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object parentComponent = GetParentComponent<TStopOn>(transform);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = parentComponent;
		bool flag4 = !flag3;
		T result = null;
		if (!flag4)
		{
			if ((object)parentComponent == null)
			{
				goto IL_019c;
			}
			if (((Component)parentComponent).TryGetComponent(out T component))
			{
				result = component;
			}
			else
			{
				GameObject gameObject = ((Component)parentComponent).gameObject;
				if ((object)gameObject == null)
				{
					goto IL_019c;
				}
				result = gameObject.AddComponent<T>();
			}
		}
		return result;
		IL_019c:
		return (T)(object)new NullReferenceException();
	}

	public static T GetParentComponent<T>(Transform t) where T : Component
	{
		//IL_0081: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I4
		if ((object)t != null)
		{
			if (t.TryGetComponent<T>(out var component))
			{
				return component;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			nint num = 0;
			Transform transform = t;
			while (true)
			{
				Transform parent = transform.parent;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((bool)parent)
				{
					if ((object)parent == null)
					{
						break;
					}
					bool flag2 = parent.TryGetComponent<T>(out var component2);
					bool flag3 = !flag2;
					num = 0;
					transform = parent;
					if (!flag3)
					{
						return component2;
					}
					continue;
				}
				return null;
			}
		}
		return (T)(object)new NullReferenceException();
	}

	public unsafe static void GetNestedComponentsInParents<T>(Transform t, List<T> list) where T : Component
	{
		//IL_0058: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		int size = list._size;
		int version = list._version + 1;
		bool flag = list._size < 1;
		object obj = !flag;
		list._size = 0;
		list._version = version;
		bool flag2 = list._size < 1;
		List<T> list2 = list;
		Transform transform = t;
		if (!flag2)
		{
			Array.Clear(list._items, 0, list._size);
			list2 = null;
			transform = t;
		}
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = transform != null;
			bool flag5 = !flag4;
			object obj5 = !flag5;
			if (obj5 == null)
			{
				break;
			}
			System.__Canon component;
			bool flag6 = transform.TryGetComponent<T>(out *(T*)(&component));
			bool flag7 = !flag6;
			size = 0;
			if (!flag7)
			{
				T[] items = list._items;
				int version2 = list._version + 1;
				list._version = version2;
				bool flag8 = list._size < items.Length;
				obj = !flag8;
				if (obj == null)
				{
					object obj6 = items + list._size;
					nint num = list._size + 1;
					list._size = (int)num;
					Component component2 = (Component)(obj6 + 32);
					component2 = (Component)(object)component;
					bool flag9 = component2.TryGetComponent<T>(out *(T*)component);
					size = 0;
				}
				else
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v13 (Il2CppClass<System.Collections.Generic.List`1<T>>)+A8]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v14+70]");
					size = 0;
					((List<System.__Canon>)(object)list).AddWithResize(component);
					nint num = 0;
				}
			}
			Transform parent = transform.parent;
			list2 = null;
			transform = parent;
		}
	}

	public unsafe static T GetNestedComponentInChildren<T, TStopOn>(Transform t, bool includeInactive) where T : class where TStopOn : class
	{
		//IL_0081: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I4
		//IL_04ad: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got Ref
		//IL_035c: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I4
		//IL_03cd: Expected Obj, but got I4
		//IL_051a: Expected Obj, but got I
		if ((object)t != null)
		{
			if (t.TryGetComponent<T>(out var component))
			{
				return component;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v8+A0]");
			object obj4 = 0;
			if (obj4 != null)
			{
				((Queue<System.__Canon>)obj4).Clear();
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10+A0]");
				object obj6 = 0;
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8000]");
					object obj7 = 0;
					System.__Canon[] array = (System.__Canon[])obj7;
					((Queue<System.__Canon>)obj6).Enqueue((System.__Canon)(object)t);
					System.__Canon _Canon = (System.__Canon)(object)t;
					T component2 = null;
					object obj16 = default;
					object obj18 = default;
					while (true)
					{
						IL_04d2:
						object obj8 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v13+E4]");
						bool flag2 = (nint)0 == 0;
						object obj9 = !flag2;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj8 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v13+A0]");
						object obj10 = 0;
						Queue<System.__Canon> queue = (Queue<System.__Canon>)obj10;
						if (obj10 == null)
						{
							break;
						}
						if (queue._size > 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v13+E4]");
							bool flag3 = (nint)0 == 0;
							object obj11 = !flag3;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								object obj12 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v23+A0]");
								object obj13 = 0;
								queue = (Queue<System.__Canon>)obj13;
								if (obj13 == null)
								{
									break;
								}
							}
							System.__Canon _Canon2 = queue.Dequeue();
							if (_Canon2 == null)
							{
								break;
							}
							int childCount = ((Transform)(object)_Canon2).childCount;
							bool flag4 = childCount < 1;
							_Canon = null;
							if (flag4)
							{
								continue;
							}
							int num = 0;
							while (true)
							{
								Transform child = ((Transform)(object)_Canon2).GetChild(num);
								if (includeInactive)
								{
									bool flag5 = (object)child == null;
									object obj14 = !flag5;
									if (obj14 == null)
									{
										break;
									}
								}
								else
								{
									if ((object)child == null)
									{
										break;
									}
									GameObject gameObject = child.gameObject;
									if ((object)gameObject == null)
									{
										break;
									}
									bool activeSelf = gameObject.activeSelf;
									bool flag6 = !activeSelf;
									array = null;
									_Canon = null;
									if (flag6)
									{
										goto IL_0414;
									}
								}
								nint num2 = 0;
								array = ((Queue<System.__Canon>)num2)._array;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
								object obj15 = obj16 & 1;
								bool flag7 = obj15 == null;
								object obj17 = !flag7;
								_Canon = (System.__Canon)(&obj18);
								queue = (Queue<System.__Canon>)0;
								if (obj17 == null)
								{
									bool flag8 = child.TryGetComponent<T>(out component2);
									bool flag9 = !flag8;
									object obj19 = !flag9;
									if (obj19 != null)
									{
										return component2;
									}
									object obj20 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v30+E4]");
									bool flag10 = (nint)0 == 0;
									object obj21 = !flag10;
									if (obj21 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj20 = obj;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v30+A0]");
									queue = (Queue<System.__Canon>)0;
									if (queue == null)
									{
										break;
									}
									array = (System.__Canon[])obj7;
									queue.Enqueue((System.__Canon)(object)child);
									_Canon = (System.__Canon)(object)child;
								}
								goto IL_0414;
								IL_0414:
								num++;
								if (childCount == num)
								{
									goto IL_04d2;
								}
							}
							break;
						}
						return null;
					}
				}
			}
		}
		return (T)(object)new NullReferenceException();
	}

	public static T GetNestedComponentInParent<T, TStopOn>(Transform t) where T : class where TStopOn : class
	{
		//IL_004c: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		Transform transform = t;
		while ((object)transform != null)
		{
			bool flag = transform.TryGetComponent<T>(out var component);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				bool flag3 = transform.TryGetComponent<TStopOn>(out var _);
				bool flag4 = !flag3;
				object obj2 = !flag4;
				if (obj2 == null)
				{
					Transform parent = transform.parent;
					bool flag5 = (object)parent == null;
					object obj3 = !flag5;
					transform = parent;
					if (obj3 == null)
					{
						return (T)(object)parent;
					}
					continue;
				}
				return null;
			}
			return component;
		}
		return (T)(object)new NullReferenceException();
	}

	public static T GetNestedComponentInParents<T, TStopOn>(Transform t) where T : class where TStopOn : class
	{
		//IL_0081: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		if ((object)t != null)
		{
			if (t.TryGetComponent<T>(out var component))
			{
				return component;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			nint num = 0;
			Transform transform = t;
			while (true)
			{
				Transform parent = transform.parent;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((bool)parent)
				{
					if ((object)parent == null)
					{
						break;
					}
					bool flag2 = parent.TryGetComponent<T>(out var component2);
					bool flag3 = !flag2;
					object obj4 = !flag3;
					if (obj4 != null)
					{
						return component2;
					}
					bool flag4 = parent.TryGetComponent<TStopOn>(out var _);
					bool flag5 = !flag4;
					num = 0;
					transform = parent;
					if (flag5)
					{
						continue;
					}
				}
				return null;
			}
		}
		return (T)(object)new NullReferenceException();
	}

	public unsafe static void GetNestedComponentsInParents<T, TStop>(Transform t, List<T> list) where T : class where TStop : class
	{
		//IL_007b: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0781: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_0810: Expected Obj, but got I4
		//IL_07c1: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_01a2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got Ref
		//IL_02d3: Expected Obj, but got I4
		//IL_082e: Expected Obj, but got I
		//IL_083e: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I4
		//IL_0284: Expected I, but got Obj
		//IL_028e: Expected I, but got Obj
		//IL_0345: Expected Obj, but got I4
		//IL_0883: Expected Obj, but got I
		//IL_0893: Expected Obj, but got I
		//IL_08c2: Expected Obj, but got I4
		//IL_0903: Expected Obj, but got I
		//IL_0913: Expected Obj, but got I
		//IL_03aa: Expected Obj, but got I4
		//IL_05f0: Expected Obj, but got Ref
		//IL_060f: Expected Obj, but got Ref
		//IL_03da: Expected Obj, but got I4
		//IL_0643: Expected Obj, but got I
		//IL_0598: Expected Obj, but got Ref
		//IL_06b9: Expected Obj, but got I4
		//IL_06c1: Expected Obj, but got Ref
		//IL_040a: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I
		//IL_0695: Expected Obj, but got I
		//IL_0481: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I4
		//IL_0701: Expected Obj, but got I4
		//IL_0709: Expected Obj, but got Ref
		//IL_04d0: Expected Obj, but got I
		bool flag = (object)t == null;
		List<T> list2 = list;
		object obj2;
		nint num2;
		List<T> list3;
		nint num;
		if (!flag)
		{
			t.GetComponents(list);
			bool flag2 = t.TryGetComponent<TStop>(out var component);
			bool flag3 = !flag2;
			object obj = !flag3;
			if (obj != null)
			{
				return;
			}
			Transform parent = t.parent;
			if ((object)parent == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
			obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v21+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v11+8]");
			bool flag5 = (nint)0 == 0;
			num = 0;
			list2 = null;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8010]");
				object obj6 = 0;
				list2 = (List<T>)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v11+8]");
				((Stack<System.__Canon>)0).Clear();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8020]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj8 = 0;
				num = 0;
				Transform transform = parent;
				while (true)
				{
					object obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16+8]");
					if ((nint)0 == 0)
					{
						break;
					}
					num = (nint)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16+8]");
					((Stack<System.__Canon>)0).Push((System.__Canon)(object)transform);
					bool flag7 = (object)transform == null;
					list2 = (List<T>)(object)transform;
					if (flag7)
					{
						break;
					}
					bool flag8 = transform.TryGetComponent<TStop>(out component);
					bool flag9 = !flag8;
					object obj12 = !flag9;
					num2 = 0;
					list3 = (List<T>)(&component);
					if (obj12 == null)
					{
						Transform parent2 = transform.parent;
						object obj13 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v53+E4]");
						bool flag10 = (nint)0 == 0;
						object obj14 = !flag10;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag11 = parent2 == null;
						bool flag12 = !flag11;
						num2 = unchecked((nint)null);
						list3 = null;
						num = unchecked((nint)null);
						list2 = null;
						transform = parent2;
						if (flag12)
						{
							continue;
						}
					}
					goto IL_02a9;
				}
			}
		}
		goto IL_0738;
		IL_0738:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0746;
		IL_08d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B9734");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_02a9:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v31+E4]");
		bool flag13 = (nint)0 == 0;
		object obj16 = !flag13;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v31+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v21+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v21+8]");
		bool flag14 = (nint)0 == 0;
		num = num2;
		list2 = list3;
		if (flag14)
		{
			goto IL_0738;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v22+18]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v32 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<T>>)+E4]");
		bool flag15 = (nint)0 == 0;
		object obj19 = !flag15;
		nint num4 = 0;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v33 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<T>>)+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8018]");
		object obj21 = 0;
		OutOfMemoryException ex2;
		object obj25;
		object obj32 = default;
		object obj35 = default;
		object obj34;
		NullReferenceException ex7;
		while (true)
		{
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v36+E4]");
			bool flag16 = (nint)0 == 0;
			object obj23 = !flag16;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj22 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v36+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v32+8]");
			Stack<System.__Canon> stack = (Stack<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v32+8]");
			if ((nint)0 != 0)
			{
				bool flag17 = stack._size <= 0;
				ex2 = null;
				obj25 = 0;
				if (flag17)
				{
					goto IL_05e8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v36+E4]");
				bool flag18 = (nint)0 == 0;
				object obj26 = !flag18;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj27 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v48+A0]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v49+8]");
					stack = (Stack<System.__Canon>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v49+8]");
					if ((nint)0 == 0)
					{
						goto IL_0524;
					}
				}
				list3 = (List<T>)obj21;
				System.__Canon _Canon = stack.Pop();
				if (_Canon != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-38_v7+38]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v45+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F7D0");
					bool flag19 = list == null;
					list3 = (List<T>)obj20;
					if (!flag19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ stack_-38_v7+38]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v47+30]");
						num2 = 0;
						((List<System.__Canon>)(object)list).AddRange((IEnumerable<System.__Canon>)obj20);
						list3 = (List<T>)obj20;
						continue;
					}
					goto IL_0516;
				}
			}
			else
			{
				NullReferenceException ex3 = new NullReferenceException();
			}
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0516;
			IL_0516:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0524;
			IL_05e8:
			object obj31 = (object)(&obj32);
			object obj33 = obj31;
			bool flag20 = obj31 == null;
			obj34 = (object)(&obj32);
			num = num2;
			list2 = list3;
			if (!flag20)
			{
				goto IL_062d;
			}
			goto IL_0738;
			IL_0524:
			NullReferenceException ex6 = new NullReferenceException();
			if ((nint)list3 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex2 = null;
				obj25 = 1;
			}
			else
			{
				bool flag21 = (nint)list3 != 1;
				obj34 = (object)(&obj32);
				num = num2;
				list2 = list3;
				ex7 = ex6;
				if (flag21)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex2 = (OutOfMemoryException)obj35;
				obj25 = 0;
			}
			goto IL_05e8;
		}
		goto IL_08d0;
		IL_062d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+1C]");
		object obj36 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+10]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+18]");
			Array.Clear((Array)num5, 0, 0);
			list3 = null;
		}
		bool flag22 = ex2 == null;
		object obj37 = !flag22;
		obj34 = (object)(&obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+18]");
		num = 0;
		list2 = list3;
		if (obj37 != null)
		{
			goto IL_0746;
		}
		bool flag23 = obj25 == null;
		object obj38 = !flag23;
		obj34 = (object)(&obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+18]");
		num = 0;
		list2 = list3;
		OutOfMemoryException ex8 = ex2;
		if (obj38 == null)
		{
			return;
		}
		goto IL_0754;
		IL_0746:
		ex8 = new OutOfMemoryException();
		goto IL_0754;
		IL_0754:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex9 = default;
		ex7 = ex9;
		goto IL_08d0;
	}

	public unsafe static List<T> GetNestedComponentsInChildren<T, TStopOn>(Transform t, List<T> list, bool includeInactive = default(bool)) where T : class where TStopOn : class
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0984: Expected Obj, but got I
		//IL_09a3: Expected I4, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0090: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got I
		//IL_09d9: Expected Obj, but got I4
		//IL_0b32: Expected Obj, but got I
		//IL_0b42: Expected Obj, but got I
		//IL_0b4a: Expected I4, but got Obj
		//IL_0a8e: Expected Obj, but got I4
		//IL_0a3f: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I4
		//IL_0293: Expected Obj, but got Ref
		//IL_0807: Expected Obj, but got Ref
		//IL_0826: Expected Obj, but got Ref
		//IL_03bf: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I
		//IL_041c: Expected I4, but got Obj
		//IL_07bf: Expected Obj, but got Ref
		//IL_08c4: Expected Obj, but got I4
		//IL_08cc: Expected Obj, but got Ref
		//IL_03ef: Expected Obj, but got I
		//IL_02f9: Expected I4, but got Obj
		//IL_0304: Expected Obj, but got I
		//IL_089c: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I
		//IL_0487: Expected I4, but got Obj
		//IL_07fa: Expected Obj, but got I4
		//IL_07a0: Expected Obj, but got I4
		//IL_0904: Expected Obj, but got I4
		//IL_090c: Expected Obj, but got Ref
		//IL_04a5: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got I4
		//IL_061f: Expected Obj, but got Ref
		//IL_0657: Expected Obj, but got I4
		//IL_06d3: Expected I4, but got Obj
		//IL_0aac: Expected Obj, but got I
		//IL_0684: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+A0]");
		object obj4 = 0;
		bool flag2 = obj4 == null;
		bool flag3 = includeInactive;
		int num = (int)list;
		List<System.__Canon> list2;
		object obj7;
		System.__Canon _Canon;
		TStopOn component = default;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F7FF0]");
			object obj5 = 0;
			num = (int)obj5;
			((Queue<System.__Canon>)obj4).Clear();
			bool flag4 = list == null;
			object obj6 = !flag4;
			list2 = (List<System.__Canon>)(object)list;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				List<System.__Canon> list3 = default;
				list3._002Ector();
				num = 0;
				list2 = list3;
			}
			bool flag5 = (object)t == null;
			flag3 = includeInactive;
			if (!flag5)
			{
				t.GetComponents((List<T>)(object)list2);
				int childCount = t.childCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8000]");
				obj7 = 0;
				bool flag6 = childCount < 1;
				flag3 = false;
				_Canon = null;
				if (flag6)
				{
					goto IL_09b1;
				}
				int num2 = 0;
				while (true)
				{
					Transform child = t.GetChild(num2);
					if (includeInactive)
					{
						bool flag7 = (object)child == null;
						object obj8 = !flag7;
						if (obj8 == null)
						{
							flag3 = false;
							num = num2;
							break;
						}
					}
					else
					{
						bool flag8 = (object)child == null;
						flag3 = false;
						num = num2;
						if (flag8)
						{
							break;
						}
						GameObject gameObject = child.gameObject;
						bool flag9 = (object)gameObject == null;
						flag3 = false;
						num = 0;
						if (flag9)
						{
							break;
						}
						bool activeSelf = gameObject.activeSelf;
						bool flag10 = !activeSelf;
						flag3 = false;
						_Canon = null;
						if (flag10)
						{
							goto IL_0311;
						}
					}
					bool flag11 = child.TryGetComponent<TStopOn>(out component);
					bool flag12 = !flag11;
					object obj9 = !flag12;
					flag3 = false;
					_Canon = (System.__Canon)(&component);
					if (obj9 == null)
					{
						object obj10 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v88+E4]");
						bool flag13 = (nint)0 == 0;
						object obj11 = !flag13;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj10 = obj;
						}
						flag3 = false;
						num = (int)(&component);
						flag3 = (byte)(int)obj7 != 0;
						((Queue<System.__Canon>)0).Enqueue((System.__Canon)(object)child);
						_Canon = (System.__Canon)(object)child;
					}
					goto IL_0311;
					IL_0311:
					num2++;
					if (childCount != num2)
					{
						continue;
					}
					goto IL_09b1;
				}
			}
		}
		goto IL_0937;
		IL_0834:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+1C]");
		object obj12 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+18]");
			Array.Clear((Array)num3, 0, 0);
			num = 0;
		}
		OutOfMemoryException ex;
		bool flag14 = ex == null;
		object obj13 = !flag14;
		object obj15 = default;
		object obj14 = (object)(&obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+18]");
		flag3 = false;
		if (obj13 != null)
		{
			goto IL_0945;
		}
		object obj16;
		bool flag15 = obj16 == null;
		object obj17 = !flag15;
		obj14 = (object)(&obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v25+18]");
		flag3 = false;
		OutOfMemoryException ex2 = ex;
		if (obj17 == null)
		{
			return (List<T>)(object)list2;
		}
		goto IL_0953;
		IL_0937:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0945;
		IL_0945:
		ex2 = new OutOfMemoryException();
		goto IL_0953;
		IL_0953:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		NullReferenceException ex5 = default;
		NullReferenceException ex4 = ex5;
		goto IL_0aff;
		IL_09b1:
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v22 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<T>>)+E4]");
		bool flag16 = (nint)0 == 0;
		object obj18 = !flag16;
		nint num5 = 0;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v23 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<T>>)+A0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F7FF8]");
		object obj20 = 0;
		num = (int)_Canon;
		object obj31 = default;
		object obj35 = default;
		while (true)
		{
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v26+E4]");
			bool flag17 = (nint)0 == 0;
			object obj22 = !flag17;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v26+A0]");
			object obj23 = 0;
			Queue<System.__Canon> queue = (Queue<System.__Canon>)obj23;
			if (obj23 == null)
			{
				goto IL_0721;
			}
			bool flag18 = queue._size <= 0;
			ex = null;
			obj16 = 0;
			if (!flag18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v26+E4]");
				bool flag19 = (nint)0 == 0;
				object obj24 = !flag19;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj25 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v45+A0]");
					object obj26 = 0;
					queue = (Queue<System.__Canon>)obj26;
					if (obj26 == null)
					{
						goto IL_074b;
					}
				}
				num = (int)obj20;
				System.__Canon _Canon2 = queue.Dequeue();
				if (_Canon2 == null)
				{
					goto IL_072f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ stack_-58_v6+38]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v35+10]");
				flag3 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F7D0");
				bool flag20 = list2 == null;
				num = (int)obj19;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ stack_-58_v6+38]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v38+38]");
					flag3 = false;
					list2.AddRange((IEnumerable<System.__Canon>)obj19);
					int childCount2 = ((Transform)(object)_Canon2).childCount;
					bool flag21 = childCount2 < 1;
					num = 0;
					if (flag21)
					{
						continue;
					}
					int num6 = 0;
					System.__Canon _Canon3;
					do
					{
						Transform child2 = ((Transform)(object)_Canon2).GetChild(num6);
						if (includeInactive)
						{
							bool flag22 = (object)child2 == null;
							object obj29 = !flag22;
							if (obj29 != null)
							{
								goto IL_05c5;
							}
							num = num6;
						}
						else
						{
							if ((object)child2 != null)
							{
								GameObject gameObject2 = child2.gameObject;
								bool flag23 = (object)gameObject2 == null;
								num = 0;
								if (!flag23)
								{
									bool activeSelf2 = gameObject2.activeSelf;
									bool flag24 = !activeSelf2;
									flag3 = false;
									_Canon3 = null;
									if (!flag24)
									{
										goto IL_05c5;
									}
									goto IL_069e;
								}
							}
							else
							{
								NullReferenceException ex6 = new NullReferenceException();
								num = num6;
							}
							NullReferenceException ex7 = new NullReferenceException();
						}
						NullReferenceException ex8 = new NullReferenceException();
						flag3 = false;
						goto IL_0713;
						IL_069e:
						num6++;
						continue;
						IL_0713:
						NullReferenceException ex9 = new NullReferenceException();
						goto IL_0721;
						IL_05c5:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ stack_-58_v6+38]");
						obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v38+18]");
						flag3 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
						object obj30 = obj31 & 1;
						bool flag25 = obj30 == null;
						object obj32 = !flag25;
						_Canon3 = (System.__Canon)(&component);
						if (obj32 == null)
						{
							object obj33 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v65+E4]");
							bool flag26 = (nint)0 == 0;
							object obj34 = !flag26;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v65+A0]");
							obj28 = 0;
							bool flag27 = obj28 == null;
							num = (int)(&component);
							if (flag27)
							{
								goto IL_0713;
							}
							flag3 = (byte)(int)obj7 != 0;
							((Queue<System.__Canon>)obj28).Enqueue((System.__Canon)(object)child2);
							_Canon3 = (System.__Canon)(object)child2;
						}
						goto IL_069e;
					}
					while (childCount2 != num6);
					num = (int)_Canon3;
					continue;
				}
				goto IL_073d;
			}
			goto IL_07ff;
			IL_0721:
			NullReferenceException ex10 = new NullReferenceException();
			goto IL_072f;
			IL_074b:
			NullReferenceException ex11 = new NullReferenceException();
			if (num == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = null;
				obj16 = 1;
			}
			else
			{
				bool flag28 = num != 1;
				obj14 = (object)(&obj15);
				ex4 = ex11;
				if (flag28)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				ex = (OutOfMemoryException)obj35;
				obj16 = 0;
			}
			goto IL_07ff;
			IL_072f:
			NullReferenceException ex12 = new NullReferenceException();
			goto IL_073d;
			IL_073d:
			NullReferenceException ex13 = new NullReferenceException();
			goto IL_074b;
			IL_07ff:
			object obj36 = (object)(&obj15);
			object obj37 = obj36;
			bool flag29 = obj36 == null;
			obj14 = (object)(&obj15);
			if (!flag29)
			{
				goto IL_0834;
			}
			goto IL_0937;
		}
		goto IL_0aff;
		IL_0aff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B9734");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		List<T> result = default;
		return result;
	}

	public unsafe static List<T> GetNestedComponentsInChildren<T>(Transform t, List<T> list, [Optional][DefaultParameterValue(null)] bool includeInactive, Type[] stopOn) where T : class
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0ef4: Expected I4, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_1208: Expected Obj, but got I4
		//IL_0e01: Expected Obj, but got I
		//IL_0557: Expected Obj, but got I4
		//IL_0ffc: Expected Obj, but got I
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0e49: Expected Obj, but got I
		//IL_0e6b: Expected Obj, but got I
		//IL_11d8: Expected Obj, but got I4
		//IL_1041: Expected Obj, but got I4
		//IL_0fd6: Expected Obj, but got I4
		//IL_1226: Expected Obj, but got I
		//IL_124d: Expected I, but got Obj
		//IL_0a8e: Expected Obj, but got I
		//IL_0b17: Expected Obj, but got I4
		//IL_0acb: Expected Obj, but got I
		//IL_0aea: Expected Obj, but got I
		//IL_0a53: Expected Obj, but got I4
		//IL_0a63: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I4
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Obj, but got Unknown
		//IL_05fb: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I8
		//IL_06b9: Expected I4, but got Obj
		//IL_06c1: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I
		//IL_0f2d: Expected Obj, but got I4
		//IL_0f4f: Expected Obj, but got I4
		//IL_1152: Expected Obj, but got I
		//IL_115a: Expected Obj, but got I4
		//IL_062b: Expected Obj, but got I
		//IL_065a: Expected I, but got Obj
		//IL_0519: Expected I4, but got Obj
		//IL_06fb: Expected I4, but got Obj
		//IL_0709: Expected I4, but got Obj
		//IL_0711: Expected I, but got Obj
		//IL_0717: Expected Obj, but got I
		//IL_0cf9: Expected Obj, but got I4
		//IL_0d01: Expected Obj, but got I
		//IL_0d0a: Expected Obj, but got I4
		//IL_0d13: Expected Obj, but got I4
		//IL_0d6b: Expected Obj, but got I
		//IL_0d73: Expected Obj, but got I4
		//IL_03e1: Expected Obj, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_0763: Expected I4, but got Obj
		//IL_10b4: Expected I4, but got Obj
		//IL_10d2: Expected Obj, but got I4
		//IL_10da: Expected I4, but got Obj
		//IL_07b0: Expected I4, but got Obj
		//IL_0887: Expected Obj, but got I4
		//IL_0bdc: Expected I4, but got Obj
		//IL_0be4: Expected I, but got Obj
		//IL_0bec: Expected Obj, but got I
		//IL_08a9: Expected Obj, but got I8
		//IL_08c3: Expected Obj, but got I4
		//IL_10a2: Expected I4, but got Obj
		//IL_1074: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_09db: Expected I4, but got Obj
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected Obj, but got Unknown
		//IL_0a2d: Expected I4, but got Obj
		//IL_08f5: Expected Obj, but got I
		//IL_090e: Expected Obj, but got I
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Type[] array = stopOn;
		bool flag2 = includeInactive;
		int num = (int)list;
		Transform transform = t;
		Type[] array2 = stopOn;
		IntPtr intPtr = default;
		nint num2 = intPtr;
		((Queue<System.__Canon>)0).Clear();
		bool flag3 = (object)t == null;
		array = stopOn;
		flag2 = includeInactive;
		num = 0;
		transform = t;
		array2 = stopOn;
		num2 = intPtr;
		int num3;
		Queue<System.__Canon> queue;
		Component component;
		Transform transform3 = default;
		Transform transform4 = default;
		int num4 = default;
		int num5 = default;
		List<T> list2 = default;
		bool flag11;
		int num6;
		Type[] array3;
		nint num7;
		if (!flag3)
		{
			t.GetComponents(list);
			int childCount = t.childCount;
			bool flag4 = childCount < 1;
			array3 = stopOn;
			flag2 = false;
			num = 0;
			if (flag4)
			{
				goto IL_052f;
			}
			object obj4 = stopOn + 32;
			array = stopOn;
			Transform transform2 = transform3;
			NullReferenceException ex2 = default;
			NullReferenceException ex = ex2;
			num3 = 0;
			while (true)
			{
				Transform child = t.GetChild(num3);
				bool flag5 = !includeInactive;
				object obj5 = !flag5;
				num = num3;
				System.__Canon _Canon;
				if (obj5 == null)
				{
					bool flag6 = (object)child == null;
					transform3 = transform2;
					ex2 = ex;
					transform4 = child;
					num4 = num3;
					num5 = childCount;
					flag2 = false;
					list2 = list;
					num = num3;
					transform = t;
					array2 = stopOn;
					num2 = intPtr;
					if (flag6)
					{
						break;
					}
					GameObject gameObject = child.gameObject;
					bool flag7 = (object)gameObject == null;
					transform3 = transform2;
					ex2 = ex;
					transform4 = child;
					num4 = num3;
					num5 = childCount;
					flag2 = false;
					list2 = list;
					num = 0;
					transform = t;
					array2 = stopOn;
					num2 = intPtr;
					if (flag7)
					{
						break;
					}
					bool activeSelf = gameObject.activeSelf;
					bool flag8 = !activeSelf;
					num = 0;
					flag2 = false;
					_Canon = null;
					if (flag8)
					{
						goto IL_04ca;
					}
				}
				bool flag9 = stopOn == null;
				transform3 = transform2;
				ex2 = ex;
				transform4 = child;
				num4 = num3;
				num5 = childCount;
				flag2 = false;
				list2 = list;
				transform = t;
				array2 = stopOn;
				num2 = intPtr;
				if (flag9)
				{
					break;
				}
				bool flag10 = stopOn.Length < 1;
				flag2 = false;
				if (flag10)
				{
					goto IL_045c;
				}
				transform3 = (Transform)(stopOn.Length & 0xFFFFFFFFL);
				array3 = array;
				ex2 = null;
				flag11 = false;
				num6 = num;
				while (true)
				{
					bool flag12 = (nint)ex2 < stopOn.Length;
					object obj6 = !flag12;
					transform4 = child;
					num5 = childCount;
					num7 = intPtr;
					queue = (Queue<System.__Canon>)stopOn.Length;
					if (obj6 != null)
					{
						break;
					}
					bool flag13 = (object)child == null;
					array = array3;
					transform4 = child;
					num4 = num3;
					num5 = childCount;
					flag2 = flag11;
					list2 = list;
					num = num6;
					transform = t;
					array2 = stopOn;
					num2 = intPtr;
					if (flag13)
					{
						goto end_IL_0fab;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X19_v18+v499 @ X21_v19 (System.NullReferenceException)*8]");
					bool flag14 = child.TryGetComponent((Type)0, out component);
					ex = (NullReferenceException)(ex2 + 1);
					bool flag15 = (object)transform3 != ex;
					array = null;
					transform2 = transform3;
					flag2 = (byte)(&component) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X19_v18+v499 @ X21_v19 (System.NullReferenceException)*8]");
					num = 0;
					array3 = null;
					ex2 = ex;
					flag11 = (byte)(&component) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X19_v18+v337 @ X21_v25 (System.NullReferenceException)*8]");
					num6 = 0;
					if (flag15)
					{
						continue;
					}
					goto IL_045c;
				}
				goto IL_0bf1;
				IL_045c:
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X0_v102+E4]");
				bool flag16 = (nint)0 == 0;
				object obj8 = !flag16;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj;
				}
				transform3 = transform2;
				ex2 = ex;
				transform4 = child;
				num4 = num3;
				num5 = childCount;
				list2 = list;
				transform = t;
				array2 = stopOn;
				num2 = intPtr;
				((Queue<System.__Canon>)0).Enqueue((System.__Canon)(object)child);
				flag2 = false;
				_Canon = (System.__Canon)(object)child;
				goto IL_04ca;
				IL_04ca:
				num4 = num3 + 1;
				bool flag17 = num4 != childCount;
				array3 = array;
				transform3 = transform2;
				ex2 = ex;
				transform4 = child;
				num5 = childCount;
				num = (int)_Canon;
				num3 = num4;
				if (flag17)
				{
					continue;
				}
				goto IL_052f;
				continue;
				end_IL_0fab:
				break;
			}
		}
		goto IL_0d89;
		IL_052f:
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v50 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<T>>)+E4]");
		bool flag18 = (nint)0 == 0;
		object obj9 = !flag18;
		nint num9 = 0;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v51 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<T>>)+A0]");
		object obj10 = 0;
		object obj11 = stopOn + 32;
		transform = (Transform)obj10;
		Array array4 = default;
		IntPtr intPtr2 = default;
		int num10 = default;
		int num11;
		Queue<System.__Canon> queue2;
		while (true)
		{
			array4 = (Array)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v33 (System.Array)+E4]");
			bool flag19 = (nint)0 == 0;
			object obj12 = !flag19;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				array4 = (Array)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v33 (System.Array)+A0]");
			object obj13 = 0;
			queue = (Queue<System.__Canon>)obj13;
			bool flag20 = obj13 == null;
			intPtr2 = intPtr;
			num7 = (nint)obj10;
			if (flag20)
			{
				break;
			}
			num10 = queue._size;
			if (queue._size <= 0)
			{
				goto IL_0a32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v33 (System.Array)+E4]");
			num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v33 (System.Array)+E4]");
			bool flag21 = (nint)0 == 0;
			object obj14 = !flag21;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v54+A0]");
				object obj16 = 0;
				queue = (Queue<System.__Canon>)obj16;
				bool flag22 = obj16 == null;
				intPtr2 = intPtr;
				num11 = (flag2 ? 1 : 0);
				num7 = (nint)obj10;
				queue2 = (Queue<System.__Canon>)obj16;
				if (flag22)
				{
					goto IL_0c51;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F7FF8]");
			num10 = 0;
			num = ((int*)num10)->m_value;
			System.__Canon _Canon2 = queue.Dequeue();
			bool flag23 = _Canon2 == null;
			intPtr2 = intPtr;
			num5 = (int)_Canon2;
			num7 = (nint)obj10;
			if (flag23)
			{
				goto IL_0c25;
			}
			((Component)(object)_Canon2).GetComponents((List<T>)(object)transform);
			bool flag24 = list == null;
			intPtr2 = intPtr;
			num5 = (int)_Canon2;
			flag2 = false;
			num = (int)transform;
			num7 = (nint)obj10;
			queue = (Queue<System.__Canon>)0;
			if (!flag24)
			{
				((List<System.__Canon>)(object)list).AddRange((IEnumerable<System.__Canon>)transform);
				int childCount2 = ((Transform)(object)_Canon2).childCount;
				bool flag25 = childCount2 < 1;
				num4 = childCount2;
				num5 = (int)_Canon2;
				flag2 = false;
				num = 0;
				if (flag25)
				{
					continue;
				}
				transform4 = null;
				nint num12 = 0;
				Transform child2;
				do
				{
					child2 = ((Transform)(object)_Canon2).GetChild((int)transform4);
					bool flag26 = !includeInactive;
					object obj17 = !flag26;
					num6 = (int)transform4;
					if (obj17 == null)
					{
						bool flag27 = (object)child2 == null;
						flag11 = false;
						num6 = (int)transform4;
						if (flag27)
						{
							goto IL_0ba5;
						}
						GameObject gameObject2 = child2.gameObject;
						bool flag28 = (object)gameObject2 == null;
						flag11 = false;
						num6 = 0;
						if (flag28)
						{
							goto IL_0bb3;
						}
						bool activeSelf2 = gameObject2.activeSelf;
						bool flag29 = !activeSelf2;
						num6 = 0;
						flag2 = false;
						num = 0;
						if (flag29)
						{
							goto IL_09e8;
						}
					}
					bool flag30 = stopOn == null;
					flag11 = false;
					if (!flag30)
					{
						bool flag31 = stopOn.Length < 1;
						bool flag32 = false;
						Type type = (Type)num6;
						if (!flag31)
						{
							NullReferenceException ex2 = (NullReferenceException)(stopOn.Length & 0xFFFFFFFFL);
							Type[] array5 = array3;
							flag11 = false;
							object obj18 = 0;
							while (true)
							{
								num12 = stopOn.Length;
								bool flag33 = (nint)obj18 < stopOn.Length;
								object obj19 = !flag33;
								if (obj19 == null)
								{
									if ((object)child2 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X19_v17+v1085 @ X20_v28*8]");
										type = (Type)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X19_v17+v1085 @ X20_v28*8]");
										bool flag34 = child2.TryGetComponent((Type)0, out component);
										obj18++;
										bool flag35 = ex2 != obj18;
										array3 = null;
										flag32 = (byte)(&component) != 0;
										array5 = null;
										flag11 = (byte)(&component) != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X19_v17+v1085 @ X20_v28*8]");
										num6 = 0;
										if (!flag35)
										{
											break;
										}
										continue;
									}
									NullReferenceException ex3 = new NullReferenceException();
								}
								IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
								array3 = array5;
								goto IL_0b89;
							}
						}
						object obj20 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v77+E4]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj20 = obj;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X0_v77+A0]");
						num12 = 0;
						flag11 = flag32;
						num6 = (int)type;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8000]");
						num12 = 0;
						((Queue<System.__Canon>)0).Enqueue((System.__Canon)(object)child2);
						flag2 = false;
						num = (int)child2;
						transform = (Transform)obj10;
						goto IL_09e8;
					}
					goto IL_0b89;
					IL_09e8:
					transform4 = (Transform)(transform4 + 1);
					continue;
					IL_0b89:
					NullReferenceException ex5 = new NullReferenceException();
					NullReferenceException ex6 = new NullReferenceException();
					goto IL_0ba5;
					IL_0ba5:
					NullReferenceException ex7 = new NullReferenceException();
					goto IL_0bb3;
					IL_0bb3:
					NullReferenceException ex8 = new NullReferenceException();
					intPtr2 = intPtr;
					transform3 = child2;
					num3 = childCount2;
					num5 = (int)_Canon2;
					num7 = (nint)obj10;
					queue = (Queue<System.__Canon>)num12;
					goto IL_0bf1;
				}
				while ((nint)transform4 != childCount2);
				transform3 = child2;
				num4 = childCount2;
				num5 = (int)_Canon2;
				continue;
			}
			goto IL_0c33;
		}
		goto IL_0c17;
		IL_0c33:
		NullReferenceException ex9 = new NullReferenceException();
		num11 = (flag2 ? 1 : 0);
		queue2 = queue;
		goto IL_0c51;
		IL_0a32:
		intPtr2 = intPtr;
		array = array3;
		list2 = list;
		object obj21 = 0;
		array2 = stopOn;
		num2 = (nint)obj10;
		goto IL_1170;
		IL_1170:
		bool flag36 = (object)transform == null;
		int num13 = num10;
		IntPtr intPtr3 = intPtr2;
		array3 = array;
		Transform transform5 = transform3;
		Transform transform6 = transform4;
		int num14 = num4;
		int num15 = num5;
		List<T> list3 = list2;
		int num16 = num;
		Transform transform7 = transform;
		object obj22 = 1;
		num7 = num2;
		if (flag36)
		{
			goto IL_0d89;
		}
		NullReferenceException ex11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X20_v8 (UnityEngine.Transform)+18]");
			num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X20_v8 (UnityEngine.Transform)+1C]");
			queue2 = (Queue<System.__Canon>)((nint)0 + (nint)1);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X20_v8 (UnityEngine.Transform)+18]");
			if ((nint)0 >= (nint)1)
			{
				array4 = (Array)(nint)((UnityEngine.Object)transform7).m_CachedPtr;
				IntPtr cachedPtr = ((UnityEngine.Object)transform7).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X20_v8 (UnityEngine.Transform)+18]");
				Array.Clear((Array)(nint)cachedPtr, 0, 0);
				array3 = null;
				num16 = 0;
			}
			bool flag37 = obj21 == null;
			object obj23 = !flag37;
			if (obj23 == null)
			{
				object obj24 = obj22 & 1;
				bool flag38 = obj24 == null;
				flag2 = (byte)num11 != 0;
				OutOfMemoryException ex10 = (OutOfMemoryException)(object)array4;
				if (!flag38)
				{
					return list3;
				}
			}
			else
			{
				OutOfMemoryException ex10 = new OutOfMemoryException();
				flag2 = (byte)num11 != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			bool flag39 = num16 != 2;
			num10 = num13;
			intPtr2 = intPtr3;
			array = array3;
			transform3 = transform5;
			NullReferenceException ex2 = ex11;
			transform4 = transform6;
			num4 = num14;
			num5 = num15;
			list2 = list3;
			num = num16;
			transform = (Transform)num7;
			array2 = (Type[])num16;
			num2 = num7;
			if (flag39)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			bool flag40 = num7 == 0;
			object obj25 = !flag40;
			transform7 = (Transform)num7;
			obj22 = 0;
			obj21 = 0;
			num10 = num13;
			intPtr2 = intPtr3;
			array = array3;
			transform3 = transform5;
			ex2 = ex11;
			transform4 = transform6;
			num4 = num14;
			num5 = num15;
			list2 = list3;
			num = num16;
			transform = (Transform)num7;
			array2 = (Type[])num16;
			num2 = num7;
			if (obj25 != null)
			{
				continue;
			}
			goto IL_0d89;
		}
		goto IL_0d97;
		IL_0c17:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_0c25;
		IL_0d97:
		if ((nint)array2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			object obj26 = default;
			obj21 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			goto IL_1170;
		}
		bool flag41 = num2 == 0;
		object obj27 = !flag41;
		if (obj27 == null)
		{
			ex11 = new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X29_v2 (Il2CppMethodInfo)+1C]");
		object obj28 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X29_v2 (Il2CppMethodInfo)+18]");
		bool flag42 = (nint)0 < (nint)1;
		Array array6 = (Array)(object)ex11;
		if (!flag42)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X29_v2 (Il2CppMethodInfo)+10]");
			array6 = (Array)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X29_v2 (Il2CppMethodInfo)+10]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X29_v2 (Il2CppMethodInfo)+18]");
			Array.Clear((Array)num17, 0, 0);
			array = null;
			num = 0;
		}
		throw new OutOfMemoryException();
		IL_0d89:
		ex11 = new NullReferenceException();
		goto IL_0d97;
		IL_0c51:
		num13 = num10;
		intPtr3 = intPtr2;
		transform5 = transform3;
		transform6 = transform4;
		num14 = num4;
		num15 = num5;
		list3 = list;
		num16 = num;
		throw new NullReferenceException();
		IL_0c25:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_0c33;
		IL_0bf1:
		IndexOutOfRangeException ex14 = new IndexOutOfRangeException();
		num4 = num3;
		flag2 = flag11;
		num = num6;
		goto IL_0c17;
	}

	public unsafe static void GetNestedComponentsInChildren<T, TSearch, TStop>(Transform t, bool includeInactive, List<T> list) where T : class where TSearch : class
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_11c7: Expected Obj, but got I
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d9: Expected Obj, but got Unknown
		//IL_11e6: Expected Obj, but got Ref
		//IL_121d: Expected I4, but got Obj
		//IL_102b: Expected Obj, but got I
		//IL_1054: Expected Obj, but got I4
		//IL_107b: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_1098: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_00de: Expected I, but got Obj
		//IL_1243: Expected Obj, but got I
		//IL_1253: Expected Obj, but got I
		//IL_1282: Expected Obj, but got I4
		//IL_1497: Expected Obj, but got I
		//IL_10ed: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0251: Expected I4, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I4
		//IL_1139: Expected Obj, but got Ref
		//IL_1153: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02af: Expected I4, but got Obj
		//IL_02ca: Expected Obj, but got Ref
		//IL_02d8: Expected Obj, but got Ref
		//IL_0fbb: Expected Obj, but got I
		//IL_1350: Expected Obj, but got I4
		//IL_12a0: Expected Obj, but got I
		//IL_0bac: Expected Obj, but got I
		//IL_0331: Expected I4, but got Obj
		//IL_0e4f: Expected Obj, but got I
		//IL_0c01: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I4
		//IL_0e9a: Expected Obj, but got I
		//IL_0ec4: Expected Obj, but got I4
		//IL_03ce: Expected Obj, but got I
		//IL_0f13: Expected Obj, but got I
		//IL_0f35: Expected Obj, but got I4
		//IL_0c4f: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I
		//IL_0ef4: Expected Obj, but got I
		//IL_0ef9: Expected I, but got Obj
		//IL_0418: Expected Obj, but got I
		//IL_0428: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_0d4e: Expected Obj, but got I
		//IL_0f65: Expected Obj, but got I4
		//IL_0f9d: Expected Obj, but got I
		//IL_0cf9: Expected Obj, but got I
		//IL_0ca4: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got Ref
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1305: Expected Ref, but got Unknown
		//IL_13e9: Expected Obj, but got I
		//IL_1401: Expected Obj, but got I
		//IL_1432: Expected Obj, but got I
		//IL_1454: Expected Obj, but got I4
		//IL_1464: Expected Obj, but got I
		//IL_1474: Expected Obj, but got I
		//IL_0d9e: Expected Obj, but got Ref
		//IL_0501: Expected Obj, but got I
		//IL_0511: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I
		//IL_0537: Expected Obj, but got I
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected Obj, but got Unknown
		//IL_055f: Expected Obj, but got I4
		//IL_06df: Expected Obj, but got I
		//IL_0701: Expected Obj, but got I4
		//IL_0711: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I
		//IL_0594: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I
		//IL_05d4: Expected Obj, but got I
		//IL_09b7: Expected Obj, but got I
		//IL_0e3a: Expected I4, but got Obj
		//IL_0df4: Expected I4, but got Obj
		//IL_0623: Expected Obj, but got I4
		//IL_069d: Expected Obj, but got I
		//IL_06ad: Expected Obj, but got I
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_07ba: Expected Obj, but got I4
		//IL_0ae8: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I4
		//IL_0847: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I
		//IL_0867: Expected Obj, but got I
		//IL_0894: Expected Obj, but got I
		//IL_08a4: Expected Obj, but got I
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected Obj, but got Unknown
		//IL_08d6: Expected Obj, but got I4
		//IL_08ee: Expected I4, but got Obj
		//IL_0a82: Expected Obj, but got I
		//IL_0b4f: Expected Obj, but got I
		//IL_0926: Expected Obj, but got I4
		//IL_0a14: Expected Obj, but got I
		//IL_0a3d: Expected Obj, but got I4
		//IL_136e: Expected Obj, but got I
		//IL_1395: Expected I4, but got Obj
		//IL_0a65: Expected Obj, but got I4
		//IL_0953: Expected I4, but got Obj
		object obj2 = default;
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ SYSREG+28]");
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5 (Il2CppClass<TStop>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		object obj4 = obj3 & 0x1FFFFFFF0L;
		object obj5 = default;
		System.__Canon _Canon = (System.__Canon)((ref *(byte*)(&obj5)) - (ref *(byte*)obj4));
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = list == null;
		bool flag2 = includeInactive;
		int num2 = (int)list;
		GameObject gameObject = (GameObject)(object)t;
		System.__Canon _Canon2;
		object obj7;
		IntPtr intPtr;
		System.__Canon _Canon4;
		int num4;
		Transform transform;
		System.__Canon _Canon3 = default;
		object obj8 = default;
		nint num3 = default;
		if (!flag)
		{
			num2 = list._size;
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			bool flag3 = list._size < 1;
			flag2 = includeInactive;
			gameObject = (GameObject)(object)t;
			if (!flag3)
			{
				Array.Clear(list._items, 0, list._size);
				num3 = unchecked((nint)null);
				flag2 = false;
				gameObject = (GameObject)(object)list._items;
			}
			bool flag4 = !includeInactive;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_01d1;
			}
			if ((object)t != null)
			{
				gameObject = t.gameObject;
				bool flag5 = (object)gameObject == null;
				flag2 = false;
				if (!flag5)
				{
					bool activeSelf = gameObject.activeSelf;
					bool flag6 = !activeSelf;
					flag2 = false;
					_Canon2 = _Canon3;
					obj7 = obj8;
					intPtr = num3;
					_Canon4 = null;
					num4 = num2;
					transform = (Transform)activeSelf;
					if (!flag6)
					{
						goto IL_01d1;
					}
					goto IL_0fab;
				}
			}
		}
		goto IL_101b;
		IL_101b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v20+28]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag7 = num5 != 0;
		System.__Canon _Canon5 = (System.__Canon)flag2;
		Transform transform2 = (Transform)(object)gameObject;
		if (!flag7)
		{
			NullReferenceException ex = new NullReferenceException();
			_Canon5 = (System.__Canon)flag2;
			transform2 = (Transform)(object)ex;
			goto IL_1088;
		}
		goto IL_1191;
		IL_112b:
		object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B9734");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v11+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num6 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		}
		goto IL_1191;
		IL_1191:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_1088:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v17+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num7 == 0)
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
			transform2 = (Transform)(object)ex2;
			goto IL_10dd;
		}
		goto IL_1191;
		IL_10dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v14+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		if (num8 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_112b;
		}
		goto IL_1191;
		IL_0e74:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v44+18]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v44+1C]");
		object obj14 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v44+18]");
		bool flag8 = (nint)0 < (nint)1;
		_Canon5 = (System.__Canon)flag2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v44+10]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v44+18]");
			Array.Clear((Array)num9, 0, 0);
			num3 = unchecked((nint)null);
			_Canon5 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		transform2 = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 != null)
		{
			goto IL_1088;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-38]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		_Canon2 = _Canon3;
		obj7 = obj8;
		intPtr = num3;
		_Canon4 = _Canon5;
		num4 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-40]");
		transform = (Transform)0;
		if (obj16 == null)
		{
			goto IL_0fab;
		}
		goto IL_10dd;
		IL_01d1:
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v19 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<TSearch>>)+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		nint num11 = 0;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v20 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1<TSearch>>)+A0]");
		object obj19 = 0;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v22+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v22+A0]");
		object obj22 = 0;
		bool flag13 = obj22 == null;
		gameObject = (GameObject)obj22;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F7FF0]");
			object obj23 = 0;
			flag2 = (byte)(int)obj23 != 0;
			((Queue<System.__Canon>)obj22).Clear();
			object obj24 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v35+A0]");
			object obj25 = 0;
			bool flag14 = obj25 == null;
			gameObject = (GameObject)obj25;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8000]");
				object obj26 = 0;
				num2 = (int)obj26;
				((Queue<System.__Canon>)obj25).Enqueue((System.__Canon)(object)t);
				object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
				object obj28 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				_ = 0;
				_ = 0;
				_Canon5 = (System.__Canon)(object)t;
				object obj44 = default;
				object obj69 = default;
				while (true)
				{
					IL_1326:
					transform2 = (Transform)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v2 (UnityEngine.Transform)+E4]");
					bool flag15 = (nint)0 == 0;
					object obj29 = !flag15;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						transform2 = (Transform)obj18;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v2 (UnityEngine.Transform)+A0]");
					object obj30 = 0;
					Queue<System.__Canon> queue = (Queue<System.__Canon>)obj30;
					if (obj30 == null)
					{
						goto IL_0b9c;
					}
					bool flag16 = queue._size <= 0;
					flag2 = (byte)(int)_Canon5 != 0;
					gameObject = (GameObject)(object)transform2;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v2 (UnityEngine.Transform)+E4]");
						bool flag17 = (nint)0 == 0;
						object obj31 = !flag17;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj32 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v112+A0]");
							object obj33 = 0;
							queue = (Queue<System.__Canon>)obj33;
							if (obj33 == null)
							{
								goto IL_0d3e;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F7FF8]");
						object obj34 = 0;
						_Canon5 = (System.__Canon)obj34;
						System.__Canon _Canon6 = queue.Dequeue();
						bool flag18 = _Canon6 == null;
						transform2 = (Transform)(object)_Canon6;
						if (flag18)
						{
							goto IL_0c3f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
						_Canon5 = (System.__Canon)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v68+38]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X8_v69+28]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F7D0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
						bool flag19 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
						transform2 = (Transform)0;
						if (!flag19)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-18]");
							Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
							obj8 = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
							_ = 0;
							object obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
							_ = 0;
							while (true)
							{
								Enumerator<, > val = (Enumerator<, >)(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
								if (!((Enumerator<, >*)val)->MoveNext())
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
								object obj38 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X8_v102+38]");
								object obj39 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v103+58]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v103+58]");
								object obj41 = (nint)0 + (nint)309;
								object obj42 = obj41 & 1;
								bool flag20 = obj42 == null;
								object obj43 = !flag20;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
									obj40 = obj44;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								if ((object)transform2 == null)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
								object obj45 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ X8_v106+38]");
								object obj46 = 0;
								T[] items = list._items;
								int version2 = list._version + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X9_v43+60]");
								object obj47 = 0;
								list._version = version2;
								if (list._items != null)
								{
									bool flag21 = list._size < items.Length;
									object obj48 = !flag21;
									if (obj48 == null)
									{
										object obj49 = list._items + list._size;
										int size = list._size + 1;
										list._size = size;
										object obj50 = obj49 + 32;
										obj50 = transform2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X9_v44+20]");
										object obj51 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ X8_v110+A8]");
										object obj52 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X8_v111+70]");
										num2 = 0;
										((List<System.__Canon>)(object)list).AddWithResize((System.__Canon)(object)transform2);
									}
									continue;
								}
								goto IL_09a7;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-68]");
							object obj53 = 0;
							object obj54 = obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v79+38]");
							object obj55 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v80+70]");
							flag2 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
							((Enumerator<, >*)null)->Dispose();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
							gameObject = (GameObject)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
							bool flag22 = (nint)0 == 0;
							object obj56 = !flag22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v80+70]");
							_Canon5 = (System.__Canon)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
							transform2 = (Transform)0;
							if (obj56 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
								object obj57 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
								bool flag23 = (nint)0 == 0;
								object obj58 = !flag23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v80+70]");
								_Canon5 = (System.__Canon)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
								transform2 = (Transform)0;
								if (obj58 == null)
								{
									int childCount = ((Transform)(object)_Canon6).childCount;
									bool flag24 = childCount < 1;
									_Canon5 = null;
									if (flag24)
									{
										continue;
									}
									int num12 = 0;
									while (true)
									{
										transform2 = ((Transform)(object)_Canon6).GetChild(num12);
										Transform transform3;
										if (includeInactive)
										{
											bool flag25 = (object)transform2 == null;
											object obj59 = !flag25;
											if (obj59 != null)
											{
												goto IL_0837;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
											object obj60 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X8_v100+28]");
											nint num13 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
											bool flag26 = num13 != 0;
											_Canon5 = (System.__Canon)num12;
											num2 = 0;
											if (flag26)
											{
												break;
											}
											NullReferenceException ex3 = new NullReferenceException();
											_Canon5 = (System.__Canon)num12;
											transform3 = (Transform)(object)ex3;
										}
										else
										{
											bool flag27 = (object)transform2 == null;
											_Canon5 = (System.__Canon)num12;
											if (flag27)
											{
												goto IL_0ad8;
											}
											GameObject gameObject2 = transform2.gameObject;
											bool flag28 = (object)gameObject2 == null;
											_Canon5 = null;
											transform3 = (Transform)(object)gameObject2;
											if (!flag28)
											{
												bool activeSelf2 = gameObject2.activeSelf;
												bool flag29 = !activeSelf2;
												_Canon5 = null;
												num2 = 0;
												if (!flag29)
												{
													goto IL_0837;
												}
												goto IL_0975;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
										object obj61 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X8_v90+28]");
										nint num14 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
										bool flag30 = num14 != 0;
										num2 = 0;
										transform2 = transform3;
										if (flag30)
										{
											break;
										}
										NullReferenceException ex4 = new NullReferenceException();
										transform2 = (Transform)(object)ex4;
										goto IL_0ad8;
										IL_0ad8:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
										object obj62 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X8_v87+28]");
										nint num15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
										bool flag31 = num15 != 0;
										num2 = 0;
										if (flag31)
										{
											break;
										}
										NullReferenceException ex5 = new NullReferenceException();
										num2 = 0;
										Transform transform4 = (Transform)(object)ex5;
										goto IL_0b3f;
										IL_0975:
										num12++;
										if (childCount == num12)
										{
											goto IL_1326;
										}
										continue;
										IL_0b3f:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
										object obj63 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v84+28]");
										nint num16 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
										bool flag32 = num16 != 0;
										transform2 = transform4;
										if (flag32)
										{
											break;
										}
										goto IL_0b86;
										IL_0837:
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
										object obj64 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X8_v93+38]");
										object obj65 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v94+78]");
										object obj66 = 0;
										num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1123 @ X1_v37+10] (should have been resolved before IL gen)");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-10]");
										object obj67 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ X8_v96+38]");
										obj57 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65058");
										object obj68 = obj69 & 1;
										bool flag33 = obj68 == null;
										object obj70 = !flag33;
										_Canon3 = _Canon;
										_Canon5 = _Canon;
										num2 = (int)transform2;
										if (obj70 == null)
										{
											object obj71 = obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X0_v81+E4]");
											bool flag34 = (nint)0 == 0;
											object obj72 = !flag34;
											if (obj72 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												obj71 = obj18;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X0_v81+A0]");
											obj57 = 0;
											bool flag35 = obj57 == null;
											_Canon3 = _Canon;
											_Canon5 = _Canon;
											num2 = (int)transform2;
											transform4 = (Transform)obj57;
											if (flag35)
											{
												goto IL_0b3f;
											}
											num2 = (int)obj26;
											((Queue<System.__Canon>)obj57).Enqueue((System.__Canon)(object)transform2);
											_Canon3 = _Canon;
											_Canon5 = (System.__Canon)(object)transform2;
										}
										goto IL_0975;
									}
									break;
								}
								goto IL_0bf1;
							}
							goto IL_0c94;
						}
						goto IL_0ce9;
					}
					goto IL_0e3f;
					IL_0bf1:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj73 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X8_v62+28]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					if (num17 != 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					goto IL_0c3f;
					IL_0e3f:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-50]");
					object obj74 = 0;
					object obj75 = obj74;
					if (obj74 != null)
					{
						goto IL_0e74;
					}
					goto IL_101b;
					IL_0d90:
					object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28B825C");
					if ((nint)_Canon5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						flag2 = (byte)(int)_Canon5 != 0;
					}
					else
					{
						if ((nint)_Canon5 != 1)
						{
							goto IL_112b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						flag2 = (byte)(int)_Canon5 != 0;
					}
					goto IL_0e3f;
					IL_0c3f:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj77 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X8_v59+28]");
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					if (num18 != 0)
					{
						break;
					}
					NullReferenceException ex6 = new NullReferenceException();
					transform2 = (Transform)(object)ex6;
					goto IL_0c94;
					IL_0c94:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj78 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v56+28]");
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					if (num19 != 0)
					{
						break;
					}
					OutOfMemoryException ex7 = new OutOfMemoryException();
					transform2 = (Transform)(object)ex7;
					goto IL_0ce9;
					IL_0d3e:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v50+28]");
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					if (num20 != 0)
					{
						break;
					}
					NullReferenceException ex8 = new NullReferenceException();
					goto IL_0d90;
					IL_0b86:
					NullReferenceException ex9 = new NullReferenceException();
					transform2 = (Transform)(object)ex9;
					goto IL_0b9c;
					IL_0b9c:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ X8_v65+28]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					if (num21 != 0)
					{
						break;
					}
					NullReferenceException ex10 = new NullReferenceException();
					transform2 = (Transform)(object)ex10;
					goto IL_0bf1;
					IL_0ce9:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X8_v53+28]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					if (num22 != 0)
					{
						break;
					}
					NullReferenceException ex11 = new NullReferenceException();
					transform2 = (Transform)(object)ex11;
					goto IL_0d3e;
					IL_09a7:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
					object obj82 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ X8_v108+28]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
					bool flag36 = num23 != 0;
					_Canon5 = (System.__Canon)(object)transform2;
					if (flag36)
					{
						break;
					}
					ex8 = new NullReferenceException();
					_Canon5 = (System.__Canon)(object)transform2;
					goto IL_0d90;
				}
				goto IL_1191;
			}
		}
		goto IL_101b;
		IL_0fab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v25+28]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-8]");
		bool flag37 = num24 != 0;
		_Canon3 = _Canon2;
		obj8 = obj7;
		num3 = intPtr;
		_Canon5 = _Canon4;
		num2 = num4;
		transform2 = transform;
		if (!flag37)
		{
			return;
		}
		goto IL_1191;
	}

	public static T[] FindObjectsOfTypeInOrder<T>(Scene scene, bool includeInactive = default(bool)) where T : class
	{
		//IL_003b: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Scene scene2 = default;
		GameObject[] rootGameObjects = scene2.GetRootGameObjects();
		if (rootGameObjects == null)
		{
			goto IL_0143;
		}
		object obj = rootGameObjects.Length;
		if (rootGameObjects.Length < 1)
		{
			goto IL_0114;
		}
		object obj2 = rootGameObjects + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X24_v5+v71 @ X23_v6*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X24_v5+v71 @ X23_v6*8]");
				IEnumerable<System.__Canon> componentsInChildren = (IEnumerable<System.__Canon>)(object)((GameObject)0).GetComponentsInChildren<T>(includeInactive);
				if (list != null)
				{
					list.AddRange(componentsInChildren);
					obj = rootGameObjects.Length;
					obj3++;
					if ((nint)obj3 < rootGameObjects.Length)
					{
						continue;
					}
					goto IL_0114;
				}
			}
			goto IL_0143;
		}
		goto IL_0151;
		IL_0114:
		if (list != null)
		{
			return (T[])(object)list.ToArray();
		}
		goto IL_0143;
		IL_0151:
		return (T[])(object)new IndexOutOfRangeException();
		IL_0143:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0151;
	}

	public static void FindObjectsOfTypeInOrder<T>(Scene scene, List<T> list, bool includeInactive = default(bool)) where T : class
	{
		//IL_00d6: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		if (list != null)
		{
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
			}
			Scene scene2 = default;
			GameObject[] rootGameObjects = scene2.GetRootGameObjects();
			if (rootGameObjects != null)
			{
				object obj = rootGameObjects.Length;
				if (rootGameObjects.Length < 1)
				{
					return;
				}
				object obj2 = rootGameObjects + 32;
				object obj3 = 0;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
					object obj4 = !flag;
					if (obj4 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v5+v58 @ X23_v6*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X24_v5+v58 @ X23_v6*8]");
						IEnumerable<System.__Canon> componentsInChildren = (IEnumerable<System.__Canon>)(object)((GameObject)0).GetComponentsInChildren<T>(includeInactive);
						((List<System.__Canon>)(object)list).AddRange(componentsInChildren);
						obj = rootGameObjects.Length;
						obj3++;
						if ((nint)obj3 >= rootGameObjects.Length)
						{
							return;
						}
						continue;
					}
					goto IL_0198;
				}
				goto IL_01a6;
			}
		}
		goto IL_0198;
		IL_0198:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01a6;
		IL_01a6:
		throw new IndexOutOfRangeException();
	}

	public static TCast[] FindObjectsOfTypeInOrder<T, TCast>(Scene scene, bool includeInactive = default(bool)) where T : class where TCast : class
	{
		//IL_003b: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I8
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_039e: Expected Obj, but got I
		//IL_02af: Expected Obj, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0281: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Scene scene2 = default;
		GameObject[] rootGameObjects = scene2.GetRootGameObjects();
		if (rootGameObjects == null)
		{
			goto IL_0348;
		}
		object obj = rootGameObjects.Length;
		if (rootGameObjects.Length < 1)
		{
			goto IL_0319;
		}
		object obj2 = 0;
		nint num = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj3 = !flag;
			if (obj3 != null)
			{
				break;
			}
			object obj4 = (object)rootGameObjects + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10+20]");
				T[] componentsInChildren = ((GameObject)0).GetComponentsInChildren<T>(includeInactive);
				if (componentsInChildren != null)
				{
					if (componentsInChildren.Length >= 1)
					{
						object obj5 = componentsInChildren.Length & 0xFFFFFFFFL;
						object obj6 = componentsInChildren + 32;
						num = num;
						object obj7 = 0;
						while (true)
						{
							bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
							object obj8 = !flag2;
							if (obj8 != null)
							{
								break;
							}
							object obj9 = (nint)0 + (nint)309;
							object obj10 = obj9 & 1;
							bool flag3 = obj10 == null;
							object obj11 = !flag3;
							nint num2 = 0;
							if (obj11 == null)
							{
								T[] componentsInChildren2 = ((GameObject)0).GetComponentsInChildren<T>(includeInactive: false);
								num2 = (nint)componentsInChildren2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X27_v6+v96 @ X26_v8*8]");
							System.__Canon componentsInChildren3 = (System.__Canon)(object)((GameObject)0).GetComponentsInChildren<T>((byte)num2 != 0);
							if (componentsInChildren3 == null)
							{
								goto IL_02a5;
							}
							if (list != null)
							{
								System.__Canon[] items = list._items;
								int version = list._version + 1;
								list._version = version;
								if (list._items != null)
								{
									bool flag4 = list._size < items.Length;
									object obj12 = !flag4;
									if (obj12 == null)
									{
										object obj13 = list._items + list._size;
										num = list._size + 1;
										list._size = (int)num;
										GameObject gameObject = (GameObject)(obj13 + 32);
										gameObject = (GameObject)(object)componentsInChildren3;
										T[] componentsInChildren4 = gameObject.GetComponentsInChildren<T>((byte)(int)componentsInChildren3 != 0);
									}
									else
									{
										list.AddWithResize(componentsInChildren3);
										num = 0;
									}
									goto IL_02a5;
								}
							}
							goto IL_0348;
							IL_02a5:
							obj5 = componentsInChildren.Length;
							object obj14 = obj7 + 1;
							bool flag5 = (nint)obj14 < componentsInChildren.Length;
							obj7 = obj14;
							if (flag5)
							{
								continue;
							}
							goto IL_02e3;
						}
						break;
					}
					goto IL_02e3;
				}
			}
			goto IL_0348;
			IL_02e3:
			obj = rootGameObjects.Length;
			obj2++;
			if ((nint)obj2 < rootGameObjects.Length)
			{
				continue;
			}
			goto IL_0319;
		}
		goto IL_0356;
		IL_0356:
		return (TCast[])(object)new IndexOutOfRangeException();
		IL_0319:
		if (list != null)
		{
			return (TCast[])(object)list.ToArray();
		}
		goto IL_0348;
		IL_0348:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0356;
	}

	public static void FindObjectsOfTypeInOrder<T, TCast>(Scene scene, List<TCast> list, bool includeInactive = default(bool)) where T : class where TCast : class
	{
		//IL_00a1: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I8
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_037c: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
		Scene scene2 = default;
		GameObject[] rootGameObjects = scene2.GetRootGameObjects();
		object obj = rootGameObjects.Length;
		if (rootGameObjects.Length < 1)
		{
			return;
		}
		object obj2 = 0;
		nint num = default;
		IntPtr intPtr = default;
		System.__Canon _Canon = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj3 = !flag;
			if (obj3 != null)
			{
				break;
			}
			object obj4 = (object)rootGameObjects + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v9+20]");
			T[] componentsInChildren = ((GameObject)0).GetComponentsInChildren<T>(includeInactive);
			if (componentsInChildren.Length >= 1)
			{
				object obj5 = componentsInChildren.Length & 0xFFFFFFFFL;
				object obj6 = componentsInChildren + 32;
				num = num;
				object obj7 = 0;
				nint num2 = 0;
				while (true)
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
					object obj8 = !flag2;
					if (obj8 != null)
					{
						break;
					}
					object obj9 = (nint)0 + (nint)309;
					object obj10 = obj9 & 1;
					bool flag3 = obj10 == null;
					object obj11 = !flag3;
					nint num3 = 0;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						num3 = intPtr;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					if (_Canon != null)
					{
						TCast[] items = list._items;
						int version2 = list._version + 1;
						list._version = version2;
						bool flag4 = list._size < items.Length;
						object obj12 = !flag4;
						if (obj12 == null)
						{
							object obj13 = items + list._size;
							num = list._size + 1;
							list._size = (int)num;
							object obj14 = obj13 + 32;
							obj14 = _Canon;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v22 (Il2CppClass<System.Collections.Generic.List`1<TCast>>)+A8]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v23+70]");
							num2 = 0;
							((List<System.__Canon>)(object)list).AddWithResize(_Canon);
							num = 0;
						}
					}
					obj5 = componentsInChildren.Length;
					object obj16 = obj7 + 1;
					bool flag5 = (nint)obj16 < componentsInChildren.Length;
					obj7 = obj16;
					if (flag5)
					{
						continue;
					}
					goto IL_02f0;
				}
				break;
			}
			goto IL_02f0;
			IL_02f0:
			obj = rootGameObjects.Length;
			obj2++;
			if ((nint)obj2 >= rootGameObjects.Length)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	static NestedComponentUtilities()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6908]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6920]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Queue<System.__Canon> queue = default;
		queue._002Ector();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = queue;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Stack<System.__Canon> stack = default;
		stack._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = stack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
