using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GillaWarmUp : MonoBehaviour
{
	private class Drop<T> : _0021_00210, T
	{
		public T[] Process(T[] buf)
		{
			//IL_0016: Expected Obj, but got I
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<GillaWarmUp+Drop`1>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3627B24");
			T[] result = default;
			return result;
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Renderer, (Renderer, Mesh)> _003C_003E9__42_0;

		public static Func<(Renderer, Mesh), int> _003C_003E9__42_1;

		public static Func<Material, bool> _003C_003E9__42_2;

		public static Func<NetworkBootstrap, NetworkObject> _003C_003E9__45_0;

		public static Func<NetworkObject, bool> _003C_003E9__45_1;

		public static Func<SkinnedMeshRenderer, bool> _003C_003E9__45_2;

		public static Func<SkinnedMeshRenderer, Material[]> _003C_003E9__45_3;

		public static Func<Material[], bool> _003C_003E9__45_4;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA420]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal (Renderer, Mesh) _003CMake_003Eb__42_0(Renderer r)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_004d: Expected VT, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Mesh item = MeshOf(r);
			(System.__Canon, System.__Canon) tuple = ((System.__Canon)(object)r, (System.__Canon)(object)item);
			return ((Renderer, Mesh))0;
		}

		internal int _003CMake_003Eb__42_1((Renderer, Mesh) x)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00bc: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got I
			//IL_0092: Expected I4, but got Obj
			//IL_0075: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default;
			if ((UnityEngine.Object)(nint)intPtr != null)
			{
				if (intPtr != (IntPtr)0)
				{
					return ((Mesh)(nint)intPtr).vertexCount;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return 0;
		}

		internal bool _003CMake_003Eb__42_2(Material m)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return m != null;
		}

		internal NetworkObject _003CPractice_003Eb__45_0(NetworkBootstrap n)
		{
			if ((object)n != null)
			{
				return n.apePrefab;
			}
			return (NetworkObject)(object)new NullReferenceException();
		}

		internal bool _003CPractice_003Eb__45_1(NetworkObject p)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return (UnityEngine.Object)p != (UnityEngine.Object)null;
		}

		internal bool _003CPractice_003Eb__45_2(SkinnedMeshRenderer s)
		{
			//IL_00e0: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_004c: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got I
			if ((object)s != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				Mesh sharedMesh = s.sharedMesh;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (sharedMesh != null)
				{
					string name = s.name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4278]");
					object obj4 = 0;
					return name != (string)obj4;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Material[] _003CPractice_003Eb__45_3(SkinnedMeshRenderer s)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Dismemberment.WithCaps(s);
		}

		internal bool _003CPractice_003Eb__45_4(Material[] m)
		{
			if (m != null)
			{
				bool flag = m.Length == 0;
				return !flag;
			}
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass55_0
	{
		public List<AudioClip> clips;
	}

	private sealed class _003COthers_003Ed__60 : _0021_00210, _00210, _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private Material _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private GillaGoreAssets _003Cgore_003E5__2;

		private Material[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private GillaHands.Piece[] _003C_003E7__wrap4;

		private Material System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EMaterial_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003COthers_003Ed__60(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_04a5: Expected I4, but got I8
			//IL_03d5: Expected I4, but got I8
			//IL_043d: Expected I4, but got I8
			//IL_094b: Expected I4, but got Obj
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cf: Expected Obj, but got Unknown
			//IL_04ef: Expected Obj, but got I4
			//IL_06a7: Expected I4, but got I8
			//IL_035d: Expected Obj, but got I
			//IL_036d: Expected Obj, but got I
			//IL_037c: Expected I4, but got I8
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected Obj, but got Unknown
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected Obj, but got Unknown
			//IL_041f: Expected Obj, but got I4
			//IL_05d7: Expected I4, but got I8
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0467: Expected Obj, but got Unknown
			//IL_0487: Expected Obj, but got I4
			//IL_063f: Expected I4, but got I8
			//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d1: Expected Obj, but got Unknown
			//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bd: Expected Obj, but got Unknown
			//IL_0503: Expected I4, but got I8
			//IL_0988: Unknown result type (might be due to invalid IL or missing references)
			//IL_098d: Expected Obj, but got Unknown
			//IL_032e: Expected I4, but got I8
			//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Expected Obj, but got Unknown
			//IL_0621: Expected Obj, but got I4
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_0669: Expected Obj, but got Unknown
			//IL_0689: Expected Obj, but got I4
			//IL_0196: Expected I4, but got I8
			//IL_0267: Expected I4, but got I8
			//IL_0543: Expected Obj, but got I4
			//IL_071d: Expected Obj, but got I4
			//IL_07e8: Expected Obj, but got I
			//IL_07f8: Expected Obj, but got I
			//IL_00a6: Expected I4, but got I8
			//IL_0912: Expected Obj, but got I4
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected Obj, but got Unknown
			//IL_01e0: Expected Obj, but got I4
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected Obj, but got Unknown
			//IL_02b1: Expected Obj, but got I4
			//IL_080d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Expected Obj, but got Unknown
			//IL_0834: Expected Obj, but got I
			//IL_085e: Expected Obj, but got I4
			//IL_08a3: Expected Obj, but got I4
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected Obj, but got Unknown
			//IL_00f0: Expected Obj, but got I4
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_0585: Expected Obj, but got Unknown
			//IL_058b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Expected Obj, but got Unknown
			//IL_05a0: Expected Obj, but got I
			//IL_075a: Unknown result type (might be due to invalid IL or missing references)
			//IL_075f: Expected Obj, but got Unknown
			//IL_076f: Expected Obj, but got I
			//IL_079a: Unknown result type (might be due to invalid IL or missing references)
			//IL_079f: Expected Obj, but got Unknown
			//IL_07af: Expected Obj, but got I
			//IL_07c2: Expected Obj, but got I4
			//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e1: Expected Obj, but got Unknown
			//IL_08f1: Expected Obj, but got I
			//IL_0904: Expected Obj, but got I4
			bool result;
			if (_003C_003E1__state <= 5)
			{
				if (_003C_003E1__state <= 2)
				{
					int num;
					if (_003C_003E1__state != 0)
					{
						if (_003C_003E1__state != 1)
						{
							bool flag = _003C_003E1__state != 2;
							result = false;
							if (flag)
							{
								goto IL_096a;
							}
							GillaGoreAssets gillaGoreAssets = _003Cgore_003E5__2;
							_003C_003E1__state = -1;
							if ((object)_003Cgore_003E5__2 == null)
							{
								goto IL_092f;
							}
							object obj = this + 24;
							obj = gillaGoreAssets.bone;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj2 = 3;
							goto IL_096f;
						}
						_003C_003E1__state = -1;
						num = ++_003C_003E7__wrap3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA680]");
						object obj4 = 0;
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B6D0");
						object obj5 = this + 48;
						object obj6 = default;
						obj5 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						num = 0;
					}
					object obj7 = this + 48;
					object obj8 = obj7;
					if (obj7 != null)
					{
						int num2 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v18+18]");
						bool flag2 = (nint)num2 < (nint)0;
						object obj9 = !flag2;
						int num3 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X9_v18+18]");
						if ((nint)num3 < (nint)0)
						{
							if (obj9 != null)
							{
								goto IL_093d;
							}
							object obj10 = obj7 + num;
							object obj11 = this + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v39+20]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 1;
							result = true;
							goto IL_096a;
						}
						_003C_003E7__wrap2 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
						object obj14 = this + 40;
						object obj15 = default;
						obj14 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj16 = 0;
						object obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v42+E4]");
						bool flag3 = (nint)0 == 0;
						object obj18 = !flag3;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag4 = (UnityEngine.Object)obj14 == null;
						bool flag5 = !flag4;
						object obj19 = !flag5;
						if (obj19 != null)
						{
							goto IL_0921;
						}
						object obj20 = obj14;
						if (obj14 != null)
						{
							object obj = this + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v37+18]");
							obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj2 = 2;
							goto IL_096f;
						}
					}
					goto IL_092f;
				}
				if (_003C_003E1__state != 3)
				{
					if (_003C_003E1__state != 4)
					{
						bool flag6 = _003C_003E1__state != 5;
						result = false;
						if (flag6)
						{
							goto IL_096a;
						}
						GillaGoreAssets gillaGoreAssets2 = _003Cgore_003E5__2;
						_003C_003E1__state = -1;
						if ((object)_003Cgore_003E5__2 == null)
						{
							goto IL_092f;
						}
						object obj = this + 24;
						obj = gillaGoreAssets2.stain;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj2 = 6;
					}
					else
					{
						GillaGoreAssets gillaGoreAssets3 = _003Cgore_003E5__2;
						_003C_003E1__state = -1;
						if ((object)_003Cgore_003E5__2 == null)
						{
							goto IL_092f;
						}
						object obj = this + 24;
						obj = gillaGoreAssets3.splat;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj2 = 5;
					}
				}
				else
				{
					GillaGoreAssets gillaGoreAssets4 = _003Cgore_003E5__2;
					_003C_003E1__state = -1;
					if ((object)_003Cgore_003E5__2 == null)
					{
						goto IL_092f;
					}
					object obj = this + 24;
					obj = gillaGoreAssets4.strand;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj2 = 4;
				}
			}
			else
			{
				if (_003C_003E1__state > 8)
				{
					if (_003C_003E1__state != 9)
					{
						int num4;
						if (_003C_003E1__state != 10)
						{
							bool flag7 = _003C_003E1__state != 11;
							result = false;
							if (flag7)
							{
								goto IL_096a;
							}
							_003C_003E1__state = -1;
							num4 = ++_003C_003E7__wrap3;
						}
						else
						{
							GillaGoreAssets gillaGoreAssets5 = _003Cgore_003E5__2;
							_003C_003E1__state = -1;
							if ((object)_003Cgore_003E5__2 == null)
							{
								goto IL_092f;
							}
							object obj21 = this + 64;
							obj21 = gillaGoreAssets5.pieces;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_ = 0;
							num4 = 0;
						}
						object obj22 = this + 64;
						object obj23 = obj22;
						if (obj22 != null)
						{
							int num5 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v8+18]");
							bool flag8 = (nint)num5 < (nint)0;
							object obj24 = !flag8;
							int num6 = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X9_v8+18]");
							if ((nint)num6 >= (nint)0)
							{
								obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								goto IL_0921;
							}
							if (obj24 != null)
							{
								goto IL_093d;
							}
							object obj25 = obj22 + num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v12+20]");
							object obj26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v12+20]");
							if ((nint)0 != 0)
							{
								object obj = this + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v13+28]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj2 = 11;
								goto IL_096f;
							}
						}
					}
					else
					{
						GillaGoreAssets gillaGoreAssets6 = _003Cgore_003E5__2;
						_003C_003E1__state = -1;
						if ((object)_003Cgore_003E5__2 != null)
						{
							object obj = this + 24;
							obj = gillaGoreAssets6.spray;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj2 = 10;
							goto IL_096f;
						}
					}
					goto IL_092f;
				}
				if (_003C_003E1__state != 6)
				{
					if (_003C_003E1__state != 7)
					{
						bool flag9 = _003C_003E1__state != 8;
						result = false;
						if (flag9)
						{
							goto IL_096a;
						}
						GillaGoreAssets gillaGoreAssets7 = _003Cgore_003E5__2;
						_003C_003E1__state = -1;
						if ((object)_003Cgore_003E5__2 == null)
						{
							goto IL_092f;
						}
						object obj = this + 24;
						obj = gillaGoreAssets7.lump;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj2 = 9;
					}
					else
					{
						GillaGoreAssets gillaGoreAssets8 = _003Cgore_003E5__2;
						_003C_003E1__state = -1;
						if ((object)_003Cgore_003E5__2 == null)
						{
							goto IL_092f;
						}
						object obj = this + 24;
						obj = gillaGoreAssets8.chipMaterial;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj2 = 8;
					}
				}
				else
				{
					GillaGoreAssets gillaGoreAssets9 = _003Cgore_003E5__2;
					_003C_003E1__state = -1;
					if ((object)_003Cgore_003E5__2 == null)
					{
						goto IL_092f;
					}
					object obj = this + 24;
					obj = gillaGoreAssets9.chunkMaterial;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj2 = 7;
				}
			}
			goto IL_096f;
			IL_092f:
			NullReferenceException ex = new NullReferenceException();
			goto IL_093d;
			IL_096f:
			result = true;
			goto IL_096a;
			IL_0921:
			result = false;
			goto IL_096a;
			IL_096a:
			return result;
			IL_093d:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
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

		private IEnumerator<Material> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EMaterial_003E_002EGetEnumerator()
		{
			//IL_009d: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got I
			object obj = _003C_003E1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					return (IEnumerator<Material>)(object)this;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA458]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			obj4._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			return (IEnumerator<Material>)obj4;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EMaterial_003E_002EGetEnumerator();
		}
	}

	private const float Size = default(float);

	private const float Ahead = default(float);

	public const int FramesEach = default(int);

	private int Specks__BackingField;

	private long PracticeMs__BackingField;

	private Mesh little;

	private Mesh ripSkin;

	private Material ripMat;

	private Material fleshMat;

	private Material boneMat;

	private Material[] unhurtMats;

	private readonly List<Mesh> baked;

	public static readonly HashSet<string> Warmed;

	private Light lamp;

	private Volume dread;

	private int frame;

	private Camera[] lensCopies;

	private RenderTexture lensTarget;

	private static int LensFrames__BackingField;

	private static int LensPostFrames__BackingField;

	private static GraphicsFormat LensColour__BackingField;

	private static GraphicsFormat LensDepth__BackingField;

	private const int PracticeBody = default(int);

	private static bool KilledPractice__BackingField;

	public int Specks
	{
		get
		{
			return Specks__BackingField;
		}
		private set
		{
			Specks__BackingField = value;
		}
	}

	public long PracticeMs
	{
		get
		{
			return PracticeMs__BackingField;
		}
		private set
		{
			PracticeMs__BackingField = value;
		}
	}

	public static int LensFrames
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static int LensPostFrames
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+C]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static GraphicsFormat LensColour
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+10]");
			return (GraphicsFormat)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static GraphicsFormat LensDepth
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+14]");
			return (GraphicsFormat)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public static bool KilledPractice
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+18]");
			return false;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
		}
	}

	public unsafe static string Signature(Renderer r, Material m)
	{
		//IL_07fd: Expected Obj, but got I
		//IL_080d: Expected Obj, but got I
		//IL_081d: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0120: Expected I, but got Obj
		//IL_0015: Expected I, but got Obj
		//IL_003e: Expected Obj, but got I4
		//IL_084a: Expected Obj, but got I
		//IL_0887: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got Ref
		//IL_0376: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I4
		//IL_03a3: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got I4
		//IL_0493: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_07a9: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I
		//IL_0563: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I8
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_058e: Expected Obj, but got I4
		//IL_08e8: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got I
		//IL_06bd: Expected I4, but got Obj
		//IL_071b: Expected I4, but got Obj
		//IL_0736: Expected Obj, but got I4
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_077b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8BB8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Mesh mesh;
		UnityEngine.Object obj8;
		if ((object)r != null)
		{
			object obj4 = obj;
			nint num = (nint)r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v34 (Il2CppClass<UnityEngine.Renderer>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v13+130]");
			bool flag = num2 < 0;
			object obj5 = !flag;
			object obj6 = ~obj5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v34 (Il2CppClass<UnityEngine.Renderer>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v13+130]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v12-8]");
				if (0 == (nint)obj4)
				{
					mesh = ((SkinnedMeshRenderer)r).sharedMesh;
					obj8 = null;
					goto IL_0211;
				}
			}
			if (num == (nint)obj2)
			{
				mesh = ((ParticleSystemRenderer)r).mesh;
				obj8 = null;
				goto IL_0211;
			}
		}
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v56+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = r != null;
		bool flag4 = !flag3;
		UnityEngine.Object obj11 = null;
		nint num4 = unchecked((nint)null);
		obj8 = null;
		if (!flag4)
		{
			if ((object)r != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75D8]");
				object obj12 = 0;
				num4 = (nint)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
				object obj14 = default;
				object obj13 = obj14 & 1;
				MeshFilter meshFilter = default;
				if (obj13 == null)
				{
					obj11 = null;
					obj8 = (UnityEngine.Object)(&meshFilter);
					goto IL_083a;
				}
				if ((object)meshFilter != null)
				{
					mesh = meshFilter.sharedMesh;
					obj8 = null;
					goto IL_0211;
				}
			}
			goto IL_07d1;
		}
		goto IL_083a;
		IL_07df:
		return (string)(object)new IndexOutOfRangeException();
		IL_0895:
		StringBuilder stringBuilder = default;
		StringBuilder stringBuilder2;
		string value;
		object value2;
		if (stringBuilder != null)
		{
			stringBuilder2 = stringBuilder.Append(value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA338]");
			value2 = 0;
			if ((object)r != null)
			{
				object obj15 = obj;
				nint num5 = (nint)r;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X9_v6 (Il2CppClass<UnityEngine.Renderer>)+130]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X10_v4+130]");
				bool flag5 = num6 < 0;
				object obj16 = !flag5;
				object obj17 = ~obj16;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X9_v6 (Il2CppClass<UnityEngine.Renderer>)+B0]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X10_v4+130]");
					object obj18 = num7 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X11_v8-8]");
					if (0 == (nint)obj15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA340]");
						value2 = 0;
						bool flag6 = stringBuilder2 == null;
						object obj19 = !flag6;
						if (obj19 != null)
						{
							goto IL_0458;
						}
						goto IL_07d1;
					}
				}
				if (num5 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA348]");
					value2 = 0;
				}
			}
			if (stringBuilder2 != null)
			{
				goto IL_0458;
			}
		}
		goto IL_07d1;
		IL_0458:
		StringBuilder stringBuilder3 = stringBuilder2.Append((string)value2);
		object obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(obj11 != null))
		{
			goto IL_0789;
		}
		if ((object)obj11 != null)
		{
			VertexAttributeDescriptor[] vertexAttributes = ((Mesh)obj11).GetVertexAttributes();
			if (vertexAttributes != null)
			{
				if (vertexAttributes.Length < 1)
				{
					goto IL_0789;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA330]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA328]");
				object obj23 = 0;
				object obj24 = vertexAttributes.Length & 0xFFFFFFFFL;
				object obj25 = vertexAttributes + 40;
				object obj26 = 0;
				object value3 = default;
				object value4 = default;
				while (true)
				{
					bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
					object obj27 = !flag8;
					if (obj27 != null)
					{
						break;
					}
					StringBuilder stringBuilder4 = stringBuilder.Append('|');
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					if (stringBuilder4 != null)
					{
						StringBuilder stringBuilder5 = stringBuilder4.Append(value3);
						if (stringBuilder5 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X26_v6-8]");
							object obj28 = (nint)0 >> 32;
							StringBuilder stringBuilder6 = stringBuilder5.Append(':');
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							if (stringBuilder6 != null)
							{
								StringBuilder stringBuilder7 = stringBuilder6.Append(value4);
								if (stringBuilder7 != null)
								{
									StringBuilder stringBuilder8 = stringBuilder7.Append('x');
									if (stringBuilder8 != null)
									{
										StringBuilder stringBuilder9 = stringBuilder8.Append((int)obj25);
										if (stringBuilder9 != null)
										{
											StringBuilder stringBuilder10 = stringBuilder9.Append('@');
											if (stringBuilder10 != null)
											{
												int value5 = obj25 >> 32;
												StringBuilder stringBuilder11 = stringBuilder10.Append(value5);
												obj24 = vertexAttributes.Length;
												obj26++;
												obj25 += 16;
												bool flag9 = (nint)obj26 < vertexAttributes.Length;
												object obj29 = obj28;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X26_v6-8]");
												object obj30 = 0;
												if (flag9)
												{
													continue;
												}
												goto IL_0789;
											}
										}
									}
								}
							}
						}
					}
					goto IL_07d1;
				}
				goto IL_07df;
			}
		}
		goto IL_07d1;
		IL_07d1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_07df;
		IL_0211:
		obj11 = mesh;
		goto IL_083a;
		IL_0338:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
		object obj31 = 0;
		value = (string)obj31;
		goto IL_0895;
		IL_0789:
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		string result = default;
		return result;
		IL_083a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		stringBuilder._002Ector();
		object obj33 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v5+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(m != null))
		{
			goto IL_0338;
		}
		if ((object)m != null)
		{
			Shader shader = m.shader;
			object obj35 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v26+E4]");
			bool flag11 = (nint)0 == 0;
			object obj36 = !flag11;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(shader != null))
			{
				goto IL_0338;
			}
			Shader shader2 = m.shader;
			if ((object)shader2 != null)
			{
				string text = shader2.name;
				value = text;
				goto IL_0895;
			}
		}
		goto IL_07d1;
	}

	public static GillaWarmUp Run()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA350]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		if ((object)gameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA358]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
			GillaWarmUp gillaWarmUp = default;
			if ((object)gillaWarmUp != null)
			{
				gillaWarmUp.Make();
				return gillaWarmUp;
			}
		}
		return (GillaWarmUp)(object)new NullReferenceException();
	}

	private unsafe void Make()
	{
		//IL_0010: Expected Obj, but got I
		//IL_27a0: Expected Obj, but got I
		//IL_27b8: Expected Obj, but got I
		//IL_27c8: Expected Obj, but got I
		//IL_27ea: Expected Obj, but got I4
		//IL_0036: Expected VT, but got Obj
		//IL_0072: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_2858: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_2808: Expected Obj, but got I
		//IL_281a: Unknown result type (might be due to invalid IL or missing references)
		//IL_281f: Expected Obj, but got Unknown
		//IL_01ee: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_29cc: Expected Obj, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_28df: Expected Obj, but got I
		//IL_28f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f7: Expected Obj, but got Unknown
		//IL_2914: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_062d: Expected Obj, but got Ref
		//IL_067d: Expected Obj, but got Ref
		//IL_0695: Expected Obj, but got I
		//IL_288f: Expected Obj, but got I
		//IL_28a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a6: Expected Obj, but got Unknown
		//IL_2a0b: Expected Obj, but got I4
		//IL_2a13: Expected Obj, but got Ref
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0668: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I4
		//IL_06ca: Expected Obj, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_07b0: Expected Obj, but got I4
		//IL_07b8: Expected Obj, but got Ref
		//IL_035b: Expected Obj, but got I
		//IL_2a65: Expected Obj, but got I
		//IL_0705: Expected Obj, but got I
		//IL_07de: Expected Obj, but got I
		//IL_07ee: Expected Obj, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_2a31: Expected Obj, but got I
		//IL_29a6: Expected Obj, but got I4
		//IL_0396: Expected Obj, but got I
		//IL_0840: Expected Obj, but got I4
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_2932: Expected Obj, but got I
		//IL_2944: Unknown result type (might be due to invalid IL or missing references)
		//IL_2949: Expected Obj, but got Unknown
		//IL_2a84: Expected Obj, but got I
		//IL_2a94: Expected Obj, but got I
		//IL_2aa4: Expected Obj, but got I
		//IL_2ac6: Expected Obj, but got I4
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_0551: Expected Obj, but got I4
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_08f7: Expected Obj, but got I4
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_2b69: Expected Obj, but got I
		//IL_2b79: Expected VT, but got I
		//IL_2b89: Expected Obj, but got I
		//IL_2bab: Expected Obj, but got I4
		//IL_0887: Expected Obj, but got I4
		//IL_097b: Expected I4, but got Obj
		//IL_099c: Expected Obj, but got Ref
		//IL_2ae4: Expected Obj, but got I
		//IL_2b06: Expected Obj, but got I
		//IL_2b17: Expected I, but got Obj
		//IL_2b35: Expected Obj, but got I
		//IL_04de: Expected I4, but got Obj
		//IL_093e: Expected Obj, but got I4
		//IL_08b7: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I
		//IL_09da: Expected Obj, but got I
		//IL_2bc9: Expected Obj, but got I
		//IL_2beb: Expected Obj, but got I
		//IL_2bfc: Expected I, but got Obj
		//IL_2c1a: Expected Obj, but got I
		//IL_2c39: Expected VT, but got Obj
		//IL_051d: Expected I4, but got Obj
		//IL_096e: Expected Obj, but got I
		//IL_2c82: Expected VT, but got I
		//IL_2ca3: Expected I4, but got Obj
		//IL_0a15: Expected Obj, but got I
		//IL_2c4e: Expected Obj, but got I
		//IL_0ab6: Expected Obj, but got I
		//IL_0ac6: Expected Obj, but got I
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_2f3e: Expected Obj, but got I
		//IL_2f4e: Expected Obj, but got I
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got Unknown
		//IL_2cf5: Expected VT, but got I
		//IL_2d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d0d: Expected Obj, but got Unknown
		//IL_2d4c: Expected I4, but got Obj
		//IL_0b21: Expected Obj, but got I
		//IL_112d: Expected Obj, but got I
		//IL_2cc1: Expected Obj, but got I
		//IL_337f: Expected Obj, but got Ref
		//IL_0bd1: Expected Obj, but got Ref
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected Obj, but got Unknown
		//IL_2f7b: Expected Obj, but got Ref
		//IL_2f8b: Expected Obj, but got VT
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected Obj, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected Obj, but got Unknown
		//IL_114a: Expected Obj, but got I
		//IL_115a: Expected Obj, but got I
		//IL_0c07: Expected Obj, but got I
		//IL_0c17: Expected Obj, but got I
		//IL_2fd4: Expected VT, but got I
		//IL_1195: Expected Obj, but got I
		//IL_2db7: Expected Obj, but got Ref
		//IL_2dd7: Expected VT, but got I
		//IL_0c52: Expected Obj, but got I
		//IL_2fa0: Expected Obj, but got I
		//IL_2d72: Expected Obj, but got I
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Expected Obj, but got Unknown
		//IL_0cea: Expected I4, but got I8
		//IL_0d04: Expected Obj, but got I4
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_11ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected Obj, but got Unknown
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected Obj, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected Obj, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected Obj, but got Unknown
		//IL_2e1c: Expected Obj, but got I4
		//IL_2e3a: Expected Obj, but got I
		//IL_2e4a: Expected Obj, but got I
		//IL_2e6c: Expected Obj, but got I4
		//IL_0d44: Expected Obj, but got Ref
		//IL_0d5d: Expected VT, but got I4
		//IL_0e73: Expected Obj, but got I
		//IL_0e7b: Expected I4, but got Obj
		//IL_0e9c: Expected Obj, but got I
		//IL_0ea4: Expected VT, but got Obj
		//IL_0ecd: Expected Obj, but got Ref
		//IL_0e2e: Expected Obj, but got I4
		//IL_0d7a: Expected Obj, but got I4
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected I4, but got Unknown
		//IL_2e92: Expected Obj, but got I
		//IL_2eac: Expected Obj, but got I
		//IL_2ebd: Expected I, but got Obj
		//IL_2edb: Expected Obj, but got I
		//IL_0e5e: Expected Obj, but got I
		//IL_10ac: Expected Obj, but got I4
		//IL_10dc: Expected VT, but got Obj
		//IL_10ec: Expected Obj, but got I4
		//IL_0f26: Expected Obj, but got I8
		//IL_0f34: Expected Obj, but got I4
		//IL_2f18: Expected Obj, but got I4
		//IL_267c: Expected Obj, but got Ref
		//IL_0f67: Expected Obj, but got I
		//IL_0f8e: Expected VT, but got I
		//IL_0fbf: Expected Obj, but got I4
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected Obj, but got Unknown
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Expected Obj, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected Obj, but got Unknown
		//IL_1038: Expected Obj, but got VT
		//IL_1064: Expected Obj, but got I
		//IL_107d: Expected I4, but got Obj
		//IL_108d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3F8]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA380]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		Vector3 vector = (Vector3)obj4;
		IEnumerable<System.__Canon> source = default;
		List<System.__Canon> list = Enumerable.ToList(source);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<GameObject> enumerable = Prefabs();
		if (enumerable == null)
		{
			goto IL_2691;
		}
		nint num = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0196;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v19 (Il2CppClass<System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>>)+98]");
		object obj11 = (nint)0 + (nint)8;
		bool flag4 = default;
		bool flag3 = flag4;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X10_v119-8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X10_v119-8]");
			object obj13 = 0 - obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X10_v119-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj10--;
			obj13 = obj10 - 1;
			bool flag5 = obj13 == null;
			obj9 = obj11 + 16;
			flag4 = (nint)obj10 != 1;
			flag3 = flag4;
			obj11 = obj9;
			if (flag4)
			{
				continue;
			}
			goto IL_0196;
		}
		object obj14 = num + obj11;
		object obj15 = obj14 + 312;
		flag4 = flag3;
		obj9 = obj11;
		goto IL_2848;
		IL_26c9:
		NullReferenceException ex = new NullReferenceException();
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_26e5;
		IL_2f73:
		object obj17 = default;
		object obj16 = (object)(&obj17);
		bool flag7 = default;
		bool flag6 = flag7;
		UnityEngine.Object obj18 = (UnityEngine.Object)vector;
		goto IL_2742;
		IL_2742:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_2750;
		IL_26e5:
		NullReferenceException ex4 = new NullReferenceException();
		NullReferenceException ex5 = new NullReferenceException();
		IndexOutOfRangeException ex6 = new IndexOutOfRangeException();
		NullReferenceException ex7 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex8 = new ArgumentNullException();
		flag6 = flag7;
		obj18 = null;
		goto IL_2742;
		IL_29f1:
		OutOfMemoryException ex9;
		bool flag8 = ex9 == null;
		object obj19 = !flag8;
		object obj20 = default;
		obj16 = (object)(&obj20);
		if (obj19 != null)
		{
			goto IL_2742;
		}
		object obj21;
		bool flag9 = obj21 == null;
		object obj22 = !flag9;
		obj16 = (object)(&obj20);
		ex3 = ex9;
		if (obj22 != null)
		{
			goto IL_2750;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3C8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3C0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA420]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<(System.__Canon, bool)> hashSet = default;
		hashSet._002Ector();
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1742 @ X0_v51+E4]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1742 @ X0_v51+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1871 @ X8_v164+8]");
		Func<System.__Canon, (System.__Canon, System.__Canon)> selector = (Func<System.__Canon, (System.__Canon, System.__Canon)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA370]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1871 @ X8_v164+8]");
		bool flag11 = (nint)0 == 0;
		object obj30 = !flag11;
		object obj34 = default;
		Renderer renderer = default;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1742 @ X0_v51+E4]");
			bool flag12 = (nint)0 == 0;
			object obj31 = !flag12;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ X8_v168+A0]");
				obj28 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3A0]");
			object obj33 = 0;
			obj34 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA408]");
			object obj35 = 0;
			Func<System.__Canon, (System.__Canon, System.__Canon)> func = default;
			func._002Ector(obj28, (IntPtr)obj35);
			object obj36 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ X8_v167+A0]");
			object obj37 = (nint)0 + (nint)8;
			obj37 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			renderer = null;
			selector = func;
		}
		IEnumerable<(System.__Canon, System.__Canon)> enumerable2 = Enumerable.Select((IEnumerable<System.__Canon>)list, selector);
		object obj38 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1890 @ X8_v33+E4]");
		bool flag13 = (nint)0 == 0;
		object obj39 = !flag13;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1890 @ X8_v33+A0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1909 @ X9_v89+10]");
		Vector3 vector2 = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA368]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1909 @ X9_v89+10]");
		bool flag14 = (nint)0 == 0;
		object obj42 = !flag14;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1890 @ X8_v33+E4]");
			bool flag15 = (nint)0 == 0;
			object obj43 = !flag15;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj44 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X8_v162+A0]");
				obj40 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA398]");
			object obj45 = 0;
			obj34 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA410]");
			object obj46 = 0;
			Func<(System.__Canon, System.__Canon), int> func2 = default;
			func2._002Ector(obj40, (IntPtr)obj46);
			object obj47 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1915 @ X8_v161+A0]");
			object obj48 = (nint)0 + (nint)16;
			obj48 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			renderer = null;
			vector2 = (Vector3)func2;
		}
		flag7 = (byte)(int)obj41 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CF694");
		object obj49 = default;
		bool flag16 = obj49 == null;
		obj16 = (object)(&obj20);
		vector = vector2;
		if (flag16)
		{
			goto IL_2691;
		}
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3D8]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1938 @ X8_v35+12E]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1938 @ X8_v35+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a66;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1938 @ X8_v35+98]");
		object obj53 = (nint)0 + (nint)8;
		bool flag17 = flag4;
		object obj54;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1991 @ X10_v90-8]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1991 @ X10_v90-8]");
			if (0 == (nint)obj51)
			{
				break;
			}
			obj52--;
			obj53 += 16;
			flag4 = (nint)obj52 != 1;
			flag17 = flag4;
			if (flag4)
			{
				continue;
			}
			goto IL_0a66;
		}
		object obj55 = obj50 + obj53;
		object obj56 = obj55 + 312;
		flag4 = flag17;
		goto IL_2c72;
		IL_058d:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_059b;
		IL_2c72:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ X0_v59+8]");
		vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2022 @ X0_v59] (should have been resolved before IL gen)");
		object obj57 = default;
		bool flag18 = obj57 == null;
		bool flag19 = (byte)(int)obj34 != 0;
		if (flag18)
		{
			goto IL_1112;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA428]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3B8]");
		object obj59 = 0;
		object obj60 = obj54;
		bool flag21 = default;
		bool flag20 = flag21;
		object obj62 = default;
		object obj61 = obj62;
		Renderer renderer2 = renderer;
		System.__Canon[] array2 = default;
		System.__Canon[] array = array2;
		bool flag22 = flag7;
		bool flag23 = flag4;
		object obj63 = obj57;
		object obj71 = default;
		Renderer renderer3 = default;
		Func<System.__Canon, bool> func3 = default;
		while (true)
		{
			object obj64 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2108 @ X8_v123+12E]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2108 @ X8_v123+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0b72;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2108 @ X8_v123+98]");
			object obj67 = (nint)0 + (nint)8;
			bool flag24 = flag23;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2183 @ X10_v85-8]");
				obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2183 @ X10_v85-8]");
				if (0 == (nint)obj66)
				{
					break;
				}
				obj65--;
				obj67 += 16;
				flag23 = (nint)obj65 != 1;
				flag24 = flag23;
				if (flag23)
				{
					continue;
				}
				goto IL_0b72;
			}
			object obj68 = obj64 + obj67;
			object obj69 = obj68 + 312;
			flag7 = flag22;
			flag23 = flag24;
			goto IL_2ce5;
			IL_2ce5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2226 @ X0_v204+8]");
			vector = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2226 @ X0_v204] (should have been resolved before IL gen)");
			object obj70 = obj71 & 1;
			bool flag25 = obj70 == null;
			obj54 = obj60;
			flag21 = flag20;
			obj62 = obj61;
			renderer = renderer2;
			array2 = array;
			flag19 = (byte)(int)obj34 != 0;
			flag4 = flag23;
			if (flag25)
			{
				break;
			}
			bool flag26 = obj57 == null;
			obj16 = (object)(&obj17);
			flag21 = flag20;
			renderer = renderer2;
			if (flag26)
			{
				goto IL_26bb;
			}
			object obj72 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2288 @ X8_v126+12E]");
			object obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3E8]");
			object obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2288 @ X8_v126+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0c93;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2288 @ X8_v126+98]");
			object obj75 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2372 @ X10_v80-8]");
				obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2372 @ X10_v80-8]");
				if (0 == (nint)obj74)
				{
					break;
				}
				obj73--;
				obj75 += 16;
				if ((nint)obj73 != 1)
				{
					continue;
				}
				goto IL_0c93;
			}
			object obj76 = obj72 + obj75;
			object obj77 = obj76 + 312;
			goto IL_2d96;
			IL_2d96:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2389 @ X0_v207] (should have been resolved before IL gen)");
			bool flag27 = (object)renderer3 == null;
			obj16 = (object)(&obj17);
			flag21 = flag20;
			renderer = renderer2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2389 @ X0_v207+8]");
			vector = (Vector3)0;
			if (!flag27)
			{
				int lightmapIndex = renderer3.lightmapIndex;
				int num2 = (int)(lightmapIndex & 0x80000000L);
				bool flag28 = num2 == 0;
				object obj78 = !flag28;
				if (obj78 == null)
				{
					int lightmapIndex2 = renderer3.lightmapIndex;
					LightmapData[] lightmaps = LightmapSettings.lightmaps;
					bool flag29 = lightmaps == null;
					obj16 = (object)(&obj17);
					flag21 = flag20;
					renderer = renderer2;
					vector = (Vector3)0;
					if (flag29)
					{
						goto IL_26e5;
					}
					object obj79 = lightmapIndex2 - lightmaps.Length;
					bool flag30 = (nint)obj79 < 0;
					int num3 = lightmapIndex2 ^ lightmaps.Length;
					int num4 = lightmapIndex2 ^ obj79;
					int num5 = num3 & num4;
					bool flag31 = num5 < 0;
					bool flag32 = flag30 == flag31;
					bool flag33 = !flag32;
					flag19 = flag33;
				}
				else
				{
					flag19 = false;
				}
				Material[] sharedMaterials = renderer3.sharedMaterials;
				object obj80 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2597 @ X0_v216+E4]");
				bool flag34 = (nint)0 == 0;
				object obj81 = !flag34;
				if (obj81 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj80 = obj25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2597 @ X0_v216+A0]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2702 @ X8_v144+18]");
				Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2702 @ X8_v144+18]");
				bool flag35 = (nint)0 == 0;
				object obj83 = !flag35;
				if (obj83 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2597 @ X0_v216+E4]");
					bool flag36 = (nint)0 == 0;
					object obj84 = !flag36;
					if (obj84 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj85 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2747 @ X8_v150+A0]");
						obj82 = 0;
					}
					obj61 = obj82;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA390]");
					object obj86 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA418]");
					object obj87 = 0;
					func3._002Ector(obj82, (IntPtr)obj87);
					object obj88 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2647 @ X8_v149+A0]");
					object obj89 = (nint)0 + (nint)24;
					obj89 = func3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					renderer2 = null;
					predicate = func3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA388]");
				object obj90 = 0;
				flag7 = (byte)(int)obj90 != 0;
				IEnumerable<System.__Canon> source2 = Enumerable.Where((IEnumerable<System.__Canon>)(object)sharedMaterials, predicate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA378]");
				object obj91 = 0;
				vector = (Vector3)obj91;
				System.__Canon[] array3 = Enumerable.ToArray(source2);
				bool flag37 = array3 == null;
				obj16 = (object)(&obj17);
				flag21 = flag20;
				renderer = renderer2;
				if (!flag37)
				{
					flag4 = array3.Length < 1;
					Mesh mesh = (Mesh)obj91;
					if (!flag4)
					{
						object obj92 = array3.Length & 0xFFFFFFFFL;
						obj61 = null;
						object obj93 = 0;
						(System.__Canon, bool) tuple;
						while (true)
						{
							bool flag38 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj92);
							object obj94 = !flag38;
							if (obj94 == null)
							{
								object obj95 = (object)array3 + obj61;
								renderer2 = (Renderer)obj58;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2906 @ X8_v142+20]");
								tuple = ((System.__Canon)0, flag19);
								bool flag39 = hashSet == null;
								flag7 = flag19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2906 @ X8_v142+20]");
								vector = (Vector3)0;
								if (!flag39)
								{
									renderer2 = (Renderer)obj59;
									bool flag40 = hashSet.Add(tuple);
									obj92 = array3.Length;
									obj61++;
									obj93 |= flag40;
									flag4 = (nint)obj61 < array3.Length;
									flag7 = false;
									vector = (Vector3)tuple;
									if (!flag4)
									{
										break;
									}
									continue;
								}
							}
							else
							{
								IndexOutOfRangeException ex11 = new IndexOutOfRangeException();
							}
							NullReferenceException ex12 = new NullReferenceException();
							obj16 = (object)(&obj17);
							flag21 = flag20;
							renderer = renderer2;
							goto IL_2691;
						}
						object obj96 = obj93 & 1;
						bool flag41 = obj96 == null;
						flag7 = false;
						mesh = (Mesh)tuple;
						if (!flag41)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2389 @ X0_v207+8]");
							Speck((Mesh)0, (Material[])(object)array3, renderer3, flag19);
							flag20 = flag19;
							renderer2 = renderer3;
							flag7 = (byte)(int)array3 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2389 @ X0_v207+8]");
							mesh = (Mesh)0;
						}
					}
					bool flag42 = obj57 == null;
					object obj97 = !flag42;
					obj54 = obj60;
					flag21 = flag20;
					obj62 = obj61;
					renderer = renderer2;
					array2 = array3;
					vector = (Vector3)mesh;
					array = array3;
					obj34 = flag19;
					flag22 = flag7;
					flag23 = flag4;
					obj63 = obj57;
					if (obj97 != null)
					{
						continue;
					}
					goto IL_1112;
				}
				goto IL_26ad;
			}
			goto IL_26c9;
			IL_0c93:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			flag7 = false;
			goto IL_2d96;
			IL_0b72:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			flag7 = false;
			goto IL_2ce5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj98 = 0;
		object obj99 = (object)(&obj17);
		object obj100 = obj99;
		if (obj99 == null)
		{
			goto IL_2f73;
		}
		object obj101 = obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2194 @ X8_v117+12E]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2194 @ X8_v117+12E]");
		if ((nint)0 == 0)
		{
			goto IL_11e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2194 @ X8_v117+98]");
		object obj104 = (nint)0 + (nint)8;
		bool flag43 = flag4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X10_v67-8]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2273 @ X10_v67-8]");
			if (0 == (nint)obj103)
			{
				break;
			}
			obj102--;
			obj104 += 16;
			flag4 = (nint)obj102 != 1;
			flag43 = flag4;
			if (flag4)
			{
				continue;
			}
			goto IL_11e6;
		}
		object obj105 = obj101 + obj104;
		object obj106 = obj105 + 312;
		flag4 = flag43;
		goto IL_2fc4;
		IL_0a66:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag7 = false;
		goto IL_2c72;
		IL_059b:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_05a9;
		IL_0196:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag7 = false;
		goto IL_2848;
		IL_2848:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v42+8]");
		IEnumerable<System.__Canon> enumerable3 = (IEnumerable<System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v637 @ X0_v42] (should have been resolved before IL gen)");
		object obj107 = default;
		if (obj107 == null)
		{
			goto IL_0577;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A18]");
		object obj109 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA3F0]");
		array2 = (System.__Canon[])0;
		obj54 = obj12;
		flag6 = flag7;
		object obj110 = obj107;
		object obj117 = default;
		UnityEngine.Object obj125 = default;
		IEnumerable<System.__Canon> enumerable4 = default;
		while (true)
		{
			object obj111 = obj110;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v181+12E]");
			object obj112 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v181+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v181+98]");
			object obj113 = (nint)0 + (nint)8;
			bool flag44 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ X10_v114-8]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ X10_v114-8]");
				object obj13 = 0 - obj108;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ X10_v114-8]");
				if (0 == (nint)obj108)
				{
					break;
				}
				obj112--;
				obj13 = obj112 - 1;
				bool flag5 = obj13 == null;
				obj9 = obj113 + 16;
				flag4 = (nint)obj112 != 1;
				flag44 = flag4;
				obj113 = obj9;
				if (flag4)
				{
					continue;
				}
				goto IL_02ce;
			}
			object obj114 = obj111 + obj113;
			object obj115 = obj114 + 312;
			flag4 = flag44;
			obj9 = obj113;
			goto IL_28cf;
			IL_28cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X0_v290+8]");
			obj18 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1186 @ X0_v290] (should have been resolved before IL gen)");
			object obj116 = obj117 & 1;
			bool flag45 = obj116 == null;
			ex9 = null;
			obj21 = 0;
			if (flag45)
			{
				break;
			}
			bool flag46 = obj107 == null;
			obj12 = obj54;
			flag7 = flag6;
			if (flag46)
			{
				goto IL_058d;
			}
			object obj118 = obj107;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X8_v184+12E]");
			object obj119 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X8_v184+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0413;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X8_v184+98]");
			object obj120 = (nint)0 + (nint)8;
			bool flag47 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X10_v109-8]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X10_v109-8]");
				object obj13 = 0 - obj109;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X10_v109-8]");
				if (0 == (nint)obj109)
				{
					break;
				}
				obj119--;
				obj13 = obj119 - 1;
				bool flag5 = obj13 == null;
				obj9 = obj120 + 16;
				flag4 = (nint)obj119 != 1;
				flag47 = flag4;
				obj120 = obj9;
				if (flag4)
				{
					continue;
				}
				goto IL_0413;
			}
			object obj121 = obj118 + obj120;
			object obj122 = obj121 + 312;
			flag4 = flag47;
			obj9 = obj120;
			goto IL_2972;
			IL_2972:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1706 @ X0_v293] (should have been resolved before IL gen)");
			object obj123 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ X0_v296+E4]");
			bool flag48 = (nint)0 == 0;
			object obj124 = !flag48;
			if (obj124 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag49 = obj125 != null;
			bool flag50 = !flag49;
			flag7 = false;
			enumerable3 = null;
			if (!flag50)
			{
				bool flag51 = (object)obj125 == null;
				obj12 = obj54;
				flag7 = false;
				obj18 = null;
				if (flag51)
				{
					goto IL_059b;
				}
				flag7 = (byte)(int)obj34 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
				bool flag52 = list == null;
				obj12 = obj54;
				obj18 = (UnityEngine.Object)enumerable4;
				if (flag52)
				{
					goto IL_05a9;
				}
				flag7 = (byte)(int)array2 != 0;
				list.AddRange(enumerable4);
				enumerable3 = enumerable4;
			}
			bool flag53 = obj107 == null;
			object obj126 = !flag53;
			obj12 = obj54;
			flag6 = flag7;
			obj110 = obj107;
			if (obj126 != null)
			{
				continue;
			}
			goto IL_0577;
			IL_0413:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			flag6 = false;
			goto IL_2972;
			IL_02ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			flag6 = false;
			goto IL_28cf;
		}
		goto IL_0675;
		IL_2767:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_0577:
		NullReferenceException ex14 = new NullReferenceException();
		obj18 = (UnityEngine.Object)enumerable3;
		goto IL_058d;
		IL_11e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag7 = false;
		goto IL_2fc4;
		IL_1112:
		throw new NullReferenceException();
		IL_05a9:
		NullReferenceException ex15 = new NullReferenceException();
		flag4 = (nint)obj18 != 2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj54 = obj12;
			ex9 = null;
			obj21 = 1;
			flag6 = flag7;
		}
		else
		{
			flag4 = (nint)obj18 != 1;
			obj16 = (object)(&obj20);
			if (flag4)
			{
				goto IL_2767;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj54 = obj12;
			object obj127 = default;
			ex9 = (OutOfMemoryException)obj127;
			obj21 = 0;
			flag6 = flag7;
		}
		goto IL_0675;
		IL_2fc4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2298 @ X0_v195+8]");
		vector = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2298 @ X0_v195] (should have been resolved before IL gen)");
		goto IL_2f73;
		IL_2691:
		NullReferenceException ex16 = new NullReferenceException();
		IndexOutOfRangeException ex17 = new IndexOutOfRangeException();
		goto IL_26ad;
		IL_2a55:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1719 @ X0_v271+8]");
		obj18 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1719 @ X0_v271] (should have been resolved before IL gen)");
		goto IL_29f1;
		IL_0675:
		object obj128 = (object)(&obj20);
		object obj129 = obj128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj130 = 0;
		if (obj128 == null)
		{
			goto IL_29f1;
		}
		object obj131 = obj129;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X8_v170+12E]");
		object obj132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X8_v170+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0756;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X8_v170+98]");
		object obj133 = (nint)0 + (nint)8;
		bool flag54 = flag4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1675 @ X10_v97-8]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1675 @ X10_v97-8]");
			if (0 == (nint)obj130)
			{
				break;
			}
			obj132--;
			obj133 += 16;
			flag4 = (nint)obj132 != 1;
			flag54 = flag4;
			if (flag4)
			{
				continue;
			}
			goto IL_0756;
		}
		object obj134 = obj131 + obj133;
		object obj135 = obj134 + 312;
		flag4 = flag54;
		goto IL_2a55;
		IL_0756:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		flag6 = false;
		goto IL_2a55;
		IL_26ad:
		NullReferenceException ex18 = new NullReferenceException();
		goto IL_26bb;
		IL_26bb:
		NullReferenceException ex19 = new NullReferenceException();
		goto IL_26c9;
		IL_2750:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		flag7 = flag6;
		goto IL_2767;
	}

	private void LensCopies()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_045a: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I
		//IL_0397: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_050a: Expected Obj, but got I
		//IL_051a: Expected Obj, but got I
		//IL_052a: Expected Obj, but got I
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_055f: Expected Obj, but got I4
		//IL_0568: Expected Obj, but got I4
		//IL_0571: Expected Obj, but got I4
		//IL_0582: Expected Obj, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0428: Expected Obj, but got I
		//IL_0433: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected I4, but got Unknown
		//IL_0151: Expected F4, but got I
		//IL_0163: Expected I4, but got I8
		//IL_01ae: Expected Obj, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_0283: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+A0]");
		object obj8 = 0;
		_ = 0;
		RenderTexture renderTexture = GillaLivLens.TargetLike(1280, 720);
		object obj9 = this + 136;
		obj9 = renderTexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		if (obj9 != null)
		{
			GraphicsFormat graphicsFormat = ((RenderTexture)obj9).graphicsFormat;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v21+A0]");
			object obj12 = 0;
			if (obj9 != null)
			{
				GraphicsFormat depthStencilFormat = ((RenderTexture)obj9).depthStencilFormat;
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA570]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v26+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj13 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8558]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v26+A0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object obj19 = this + 128;
				UnityEngine.Behaviour behaviour = default;
				obj19 = behaviour;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj20 = 0;
				object obj21 = 0;
				object obj22 = 0;
				UnityEngine.Behaviour behaviour2 = behaviour;
				object obj23 = 1;
				GameObject gameObject = default;
				UnityEngine.Behaviour behaviour3 = default;
				Action<ScriptableRenderContext, System.__Canon> action = default;
				while (true)
				{
					object obj24 = obj23 & 1;
					bool flag6 = obj24 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA588]");
					object obj25 = 0;
					object obj26 = !flag6;
					object obj27 = ~obj26;
					if (obj27 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA580]");
						obj25 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					gameObject._002Ector((string)obj25);
					if ((object)gameObject == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					if ((object)behaviour3 == null)
					{
						break;
					}
					behaviour3.enabled = false;
					bool post = (byte)(obj22 & 1) != 0;
					UniversalAdditionalCameraData universalAdditionalCameraData = GillaLivLens.Configure((Camera)behaviour3, post);
					((Camera)behaviour3).targetTexture = (RenderTexture)obj9;
					((Camera)behaviour3).fieldOfView = 60f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
					((Camera)behaviour3).nearClipPlane = 0f;
					((Camera)behaviour3).cullingMask = -1;
					object obj28 = obj19;
					if (obj19 == null)
					{
						break;
					}
					object obj29 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v27+18]");
					bool flag7 = (nint)obj29 < 0;
					object obj30 = !flag7;
					if (obj30 == null)
					{
						object obj31 = obj19 + obj21;
						object obj32 = obj31 + 32;
						obj32 = behaviour3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj33 = obj23 & 1;
						bool flag8 = obj33 == null;
						object obj34 = !flag8;
						obj20 = 0;
						obj21 = 1;
						obj22 = 1;
						behaviour2 = behaviour3;
						obj23 = 0;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA568]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA578]");
							object obj36 = 0;
							action._002Ector((object)this, (IntPtr)obj36);
							RenderPipelineManager.endCameraRendering += (Action<ScriptableRenderContext, Camera>)action;
							return;
						}
						continue;
					}
					goto IL_02a0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02a0;
		IL_02a0:
		throw new IndexOutOfRangeException();
	}

	private void Drawn(ScriptableRenderContext context, Camera cam)
	{
		//IL_0034: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I8
		//IL_00c3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		//IL_0236: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I
		//IL_0357: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I
		Camera[] array = lensCopies;
		if (lensCopies == null)
		{
			return;
		}
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (cam == array[0])
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v34+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v40+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v40+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v23+8]");
				object obj10 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v40+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v40+A0]");
				object obj12 = 0;
				return;
			}
			Camera[] array2 = lensCopies;
			object obj13 = array2.Length & 0xFFFFFFFEL;
			if (obj13 != null)
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (cam == array2[1])
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v15+E4]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj19 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v21+E4]");
					bool flag7 = (nint)0 == 0;
					object obj20 = !flag7;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v21+A0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v12+C]");
					object obj22 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v21+E4]");
					bool flag8 = (nint)0 == 0;
					object obj23 = !flag8;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj19 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v21+A0]");
					object obj24 = 0;
				}
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Practice()
	{
		//IL_0010: Expected Obj, but got I
		//IL_246a: Expected Obj, but got I
		//IL_247a: Expected Obj, but got I
		//IL_249c: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_24ba: Expected Obj, but got I
		//IL_24ca: Expected Obj, but got I
		//IL_24da: Expected Obj, but got I
		//IL_24fc: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_259b: Expected Obj, but got I
		//IL_25ab: Expected Obj, but got I
		//IL_25bb: Expected Obj, but got I
		//IL_25dd: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_251a: Expected Obj, but got I
		//IL_2534: Expected Obj, but got I
		//IL_2545: Expected I, but got Obj
		//IL_2563: Expected Obj, but got I
		//IL_2586: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I
		//IL_2696: Expected Obj, but got I4
		//IL_25fb: Expected Obj, but got I
		//IL_2615: Expected Obj, but got I
		//IL_2626: Expected I, but got Obj
		//IL_2644: Expected Obj, but got I
		//IL_2667: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_0380: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I
		//IL_0498: Expected I4, but got Obj
		//IL_04ba: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_04e8: Expected I4, but got Obj
		//IL_050a: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I4
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected Obj, but got Unknown
		//IL_06df: Expected Obj, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0700: Expected Obj, but got I4
		//IL_071f: Expected Obj, but got I
		//IL_0727: Expected I4, but got Obj
		//IL_0749: Expected Obj, but got I4
		//IL_0752: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I8
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_0576: Expected I4, but got Obj
		//IL_057f: Expected Obj, but got I4
		//IL_0588: Expected Obj, but got I4
		//IL_26bd: Expected Obj, but got I4
		//IL_26ce: Expected Obj, but got I4
		//IL_0770: Expected Obj, but got I
		//IL_08a4: Expected Obj, but got I
		//IL_05b7: Expected Obj, but got I4
		//IL_08dd: Expected Obj, but got I4
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07ac: Expected Obj, but got I4
		//IL_07b5: Expected Obj, but got I4
		//IL_05e9: Expected Obj, but got I
		//IL_271c: Expected Obj, but got I
		//IL_272c: Expected Obj, but got I
		//IL_274e: Expected Obj, but got I4
		//IL_2757: Expected Obj, but got I4
		//IL_26f5: Expected Obj, but got I4
		//IL_26fe: Expected Obj, but got I4
		//IL_0684: Expected Obj, but got I
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected Obj, but got Unknown
		//IL_0969: Expected Obj, but got I
		//IL_0971: Expected I4, but got Obj
		//IL_0992: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got I4
		//IL_07da: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I
		//IL_2775: Expected Obj, but got I
		//IL_278f: Expected Obj, but got I
		//IL_27a0: Expected I, but got Obj
		//IL_27be: Expected Obj, but got I
		//IL_27e1: Expected Obj, but got I4
		//IL_0954: Expected Obj, but got I
		//IL_07f9: Expected Obj, but got I
		//IL_0815: Expected Obj, but got I4
		//IL_0b3f: Expected Obj, but got I4
		//IL_281d: Expected Obj, but got I
		//IL_282d: Expected Obj, but got I
		//IL_284f: Expected Obj, but got I4
		//IL_0a0c: Expected Obj, but got I8
		//IL_0a1c: Expected Obj, but got I
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a33: Expected Obj, but got I4
		//IL_0846: Expected Obj, but got I
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected Obj, but got Unknown
		//IL_0bcb: Expected Obj, but got I
		//IL_0bd3: Expected I4, but got Obj
		//IL_0bf4: Expected Obj, but got I
		//IL_27ff: Expected Obj, but got I4
		//IL_0c16: Expected Obj, but got I
		//IL_0c40: Expected Obj, but got I4
		//IL_0b86: Expected Obj, but got I4
		//IL_286d: Expected Obj, but got I
		//IL_2887: Expected Obj, but got I
		//IL_2898: Expected I, but got Obj
		//IL_28b6: Expected Obj, but got I
		//IL_28d9: Expected Obj, but got I4
		//IL_0a62: Expected Obj, but got I4
		//IL_0bb6: Expected Obj, but got I
		//IL_0a90: Expected Obj, but got I
		//IL_0aaa: Expected Obj, but got I
		//IL_0ab9: Expected Obj, but got I4
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0aef: Expected Obj, but got I
		//IL_0af7: Expected I4, but got Obj
		//IL_0b07: Expected Obj, but got I
		//IL_0cc4: Expected Obj, but got I
		//IL_0cd4: Expected Obj, but got I
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0cf9: Expected Obj, but got I4
		//IL_28ee: Expected Obj, but got I
		//IL_1293: Expected Obj, but got I
		//IL_1159: Expected Obj, but got I
		//IL_1171: Expected Obj, but got I
		//IL_1193: Expected Obj, but got I4
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12da: Expected Obj, but got Unknown
		//IL_12f6: Expected Obj, but got I4
		//IL_2943: Expected Obj, but got I
		//IL_2953: Expected Obj, but got I
		//IL_2975: Expected Obj, but got I4
		//IL_121f: Expected Obj, but got I
		//IL_1227: Expected I4, but got Obj
		//IL_1248: Expected Obj, but got I4
		//IL_2a75: Expected Obj, but got I4
		//IL_131e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1323: Expected Obj, but got Unknown
		//IL_1331: Expected Obj, but got I4
		//IL_11da: Expected Obj, but got I4
		//IL_2d01: Expected Obj, but got I4
		//IL_126e: Expected I4, but got Obj
		//IL_2993: Expected Obj, but got I
		//IL_29ad: Expected Obj, but got I
		//IL_29be: Expected I, but got Obj
		//IL_29dc: Expected Obj, but got I
		//IL_29ff: Expected Obj, but got I4
		//IL_0d91: Expected Obj, but got I4
		//IL_0da3: Expected Obj, but got I4
		//IL_120a: Expected Obj, but got I
		//IL_14b4: Expected Obj, but got I
		//IL_0dda: Expected Obj, but got I4
		//IL_241a: Expected Obj, but got I
		//IL_1384: Expected Obj, but got I
		//IL_139e: Expected Obj, but got I
		//IL_0df9: Expected Obj, but got I
		//IL_0e1e: Expected Obj, but got I4
		//IL_150f: Expected Obj, but got I
		//IL_1522: Unknown result type (might be due to invalid IL or missing references)
		//IL_1527: Expected Obj, but got Unknown
		//IL_13cd: Expected Obj, but got I4
		//IL_154e: Expected Obj, but got I
		//IL_0e59: Expected Obj, but got I4
		//IL_0e6b: Expected Obj, but got I4
		//IL_2aac: Expected Obj, but got I4
		//IL_2a0e: Expected Obj, but got I4
		//IL_2a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1c: Expected Obj, but got Unknown
		//IL_1433: Expected Obj, but got I
		//IL_0eaa: Expected Obj, but got I4
		//IL_1588: Expected Obj, but got I4
		//IL_0ed1: Expected Obj, but got I
		//IL_15a6: Expected Obj, but got I
		//IL_15be: Expected Obj, but got I
		//IL_15d6: Expected Obj, but got I
		//IL_0f02: Expected Obj, but got I4
		//IL_0f14: Expected Obj, but got I4
		//IL_2ace: Expected Obj, but got I8
		//IL_2af7: Expected Obj, but got I4
		//IL_0f53: Expected Obj, but got I4
		//IL_1605: Expected Obj, but got I
		//IL_1615: Expected Obj, but got I
		//IL_1625: Expected Obj, but got I
		//IL_2b21: Expected Obj, but got I4
		//IL_2b31: Expected Obj, but got I4
		//IL_2b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b56: Expected Obj, but got Unknown
		//IL_2b70: Expected Obj, but got I4
		//IL_0f7a: Expected Obj, but got I
		//IL_0fb1: Expected Obj, but got I4
		//IL_165c: Expected Obj, but got I
		//IL_166c: Expected Obj, but got I
		//IL_167c: Expected Obj, but got I
		//IL_16bf: Expected Obj, but got I4
		//IL_0fe2: Expected Obj, but got I4
		//IL_0ff4: Expected Obj, but got I4
		//IL_101f: Expected Obj, but got I
		//IL_103a: Expected Obj, but got I4
		//IL_104c: Expected Obj, but got I4
		//IL_105c: Expected Obj, but got I
		//IL_2ba7: Expected Obj, but got I4
		//IL_1080: Expected Obj, but got I
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Expected Obj, but got Unknown
		//IL_10b7: Expected Obj, but got I4
		//IL_1719: Expected Obj, but got I4
		//IL_10e6: Expected Obj, but got I4
		//IL_1743: Expected Obj, but got I8
		//IL_1762: Expected Obj, but got I
		//IL_1772: Expected Obj, but got I
		//IL_1782: Expected Obj, but got I
		//IL_17b6: Expected Obj, but got I4
		//IL_17e8: Expected Obj, but got I4
		//IL_17f8: Expected Obj, but got I4
		//IL_1817: Expected Obj, but got I
		//IL_1827: Expected Obj, but got I
		//IL_1837: Expected Obj, but got I
		//IL_1862: Unknown result type (might be due to invalid IL or missing references)
		//IL_1867: Expected Obj, but got Unknown
		//IL_1881: Expected Obj, but got I4
		//IL_18a7: Expected Obj, but got I
		//IL_18b7: Expected Obj, but got I
		//IL_18c7: Expected Obj, but got I
		//IL_190a: Expected Obj, but got I4
		//IL_1935: Expected Obj, but got I
		//IL_2bde: Expected Obj, but got I4
		//IL_1974: Expected Obj, but got I4
		//IL_1992: Expected Obj, but got I
		//IL_19aa: Expected Obj, but got I
		//IL_2c00: Expected Obj, but got I8
		//IL_2c29: Expected Obj, but got I4
		//IL_19d4: Expected Obj, but got I
		//IL_19e4: Expected Obj, but got I
		//IL_2c53: Expected Obj, but got I4
		//IL_2c63: Expected Obj, but got I4
		//IL_2c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c88: Expected Obj, but got Unknown
		//IL_2ca2: Expected Obj, but got I4
		//IL_1a0e: Expected Obj, but got I
		//IL_1a1e: Expected Obj, but got I
		//IL_1a54: Expected Obj, but got I4
		//IL_1a8b: Expected I4, but got Obj
		//IL_1a94: Expected Obj, but got I4
		//IL_1ac9: Expected Obj, but got I
		//IL_1ae8: Expected Obj, but got I
		//IL_1af0: Expected I4, but got Obj
		//IL_1b15: Expected Obj, but got I4
		//IL_1b54: Expected I4, but got Obj
		//IL_1b79: Expected Obj, but got I4
		//IL_1bb1: Expected Obj, but got I
		//IL_1bd7: Expected I4, but got Obj
		//IL_1be0: Expected Obj, but got I4
		//IL_1be9: Expected Obj, but got I4
		//IL_1c10: Expected I4, but got Obj
		//IL_1c19: Expected Obj, but got I4
		//IL_1c66: Expected I4, but got Obj
		//IL_1c6f: Expected Obj, but got I4
		//IL_1ca1: Expected Obj, but got I4
		//IL_1cb1: Expected Obj, but got I4
		//IL_1cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf4: Expected Obj, but got Unknown
		//IL_1cfc: Expected I4, but got Obj
		//IL_1d05: Expected Obj, but got I4
		//IL_1d50: Expected I4, but got Obj
		//IL_1d59: Expected Obj, but got I4
		//IL_1d8c: Expected Obj, but got I
		//IL_2cd1: Expected Obj, but got I4
		//IL_2cda: Expected Obj, but got I4
		//IL_1dc3: Expected Obj, but got I4
		//IL_1dcc: Expected Obj, but got I4
		//IL_1dea: Expected Obj, but got I
		//IL_1e02: Expected Obj, but got I
		//IL_1e12: Expected Obj, but got I
		//IL_1e22: Expected Obj, but got I
		//IL_1e77: Expected Obj, but got I4
		//IL_1e80: Expected Obj, but got I4
		//IL_1eab: Expected Obj, but got I
		//IL_1edb: Expected Obj, but got I4
		//IL_1ee4: Expected Obj, but got I4
		//IL_1f0e: Expected Obj, but got I4
		//IL_1f1e: Expected Obj, but got I4
		//IL_1f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f43: Expected Obj, but got Unknown
		//IL_1f55: Expected Obj, but got I4
		//IL_1fa1: Expected Obj, but got I4
		//IL_1feb: Expected Obj, but got I4
		//IL_2034: Expected Obj, but got I4
		//IL_2063: Expected Obj, but got I
		//IL_2082: Expected Obj, but got I
		//IL_20b0: Expected Obj, but got I4
		//IL_2106: Expected Obj, but got I4
		//IL_213b: Expected Obj, but got I
		//IL_2173: Expected Obj, but got I4
		//IL_219e: Expected Obj, but got I
		//IL_21db: Expected Obj, but got I4
		//IL_2294: Expected Obj, but got I4
		//IL_2218: Expected I, but got Obj
		//IL_2228: Expected Obj, but got I
		//IL_2253: Expected Obj, but got I4
		//IL_2263: Expected Obj, but got I
		//IL_22b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b8: Expected Obj, but got Unknown
		//IL_230b: Expected Obj, but got I
		//IL_232d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2332: Expected Obj, but got Unknown
		//IL_2365: Expected Obj, but got I4
		//IL_238b: Expected Obj, but got I
		//IL_23b8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4D0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA420]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v55+20]");
		Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA480]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v55+20]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj17;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v191+A0]");
				obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4E0]");
			object obj14 = 0;
			Func<System.__Canon, System.__Canon> func = default;
			func._002Ector(obj8, (IntPtr)obj14);
			object obj15 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v190+A0]");
			object obj16 = (nint)0 + (nint)32;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			selector = func;
			obj17 = 0;
		}
		IEnumerable<System.__Canon> source = default;
		IEnumerable<System.__Canon> enumerable = Enumerable.Select(source, selector);
		object obj18 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v53+28]");
		Func<System.__Canon, bool> func2 = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA478]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v53+28]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v183+A0]");
				obj20 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4B0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4E8]");
			object obj26 = 0;
			Func<System.__Canon, bool> func3 = default;
			func3._002Ector(obj20, (IntPtr)obj26);
			object obj27 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v182+A0]");
			object obj28 = (nint)0 + (nint)40;
			obj28 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			func2 = func3;
			obj17 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CBB88");
		object obj29 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj30 = !flag8;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj31 = default;
		bool flag9 = obj31 != null;
		bool flag10 = !flag9;
		UnityEngine.Object obj32 = null;
		UnityEngine.Object obj33 = null;
		bool flag12;
		UnityEngine.Object obj34;
		if (!flag10)
		{
			bool flag11 = (object)obj31 == null;
			flag12 = false;
			obj34 = null;
			if (flag11)
			{
				goto IL_2420;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA460]");
			object obj35 = 0;
			obj33 = (UnityEngine.Object)obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj36 = default;
			obj32 = obj36;
		}
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v18+E4]");
		bool flag13 = (nint)0 == 0;
		object obj38 = !flag13;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = obj32 == null;
		bool flag15 = !flag14;
		object obj39 = !flag15;
		if (obj39 != null)
		{
			return;
		}
		bool flag16 = (object)obj32 == null;
		flag12 = false;
		obj34 = null;
		GameObject gameObject = default;
		UnityEngine.Object obj47 = default;
		if (!flag16)
		{
			object obj40 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v23+E4]");
			bool flag17 = (nint)0 == 0;
			object obj41 = !flag17;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X27_v5 (UnityEngine.Object)+A8]");
			if ((UnityEngine.Object)0 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA508]");
			object obj43 = 0;
			gameObject._002Ector((string)obj43);
			bool flag18 = (object)gameObject == null;
			flag12 = false;
			obj34 = (UnityEngine.Object)obj43;
			if (!flag18)
			{
				gameObject.SetActive(value: false);
				Transform transform = gameObject.transform;
				Transform parent = base.transform;
				bool flag19 = (object)transform == null;
				flag12 = false;
				obj34 = null;
				if (!flag19)
				{
					transform.SetParent(parent, worldPositionStays: false);
					Transform transform2 = gameObject.transform;
					object obj44 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v19+E4]");
					bool flag20 = (nint)0 == 0;
					object obj45 = !flag20;
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4D8]");
					object obj46 = 0;
					flag12 = (byte)(int)obj46 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDB68");
					bool flag21 = (object)obj47 == null;
					obj17 = 0;
					obj34 = transform2;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA468]");
						object obj48 = 0;
						flag12 = (byte)(int)obj48 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
						object obj49 = default;
						bool flag22 = obj49 == null;
						obj17 = 0;
						obj34 = (UnityEngine.Object)1;
						if (!flag22)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v40+18]");
							if ((nint)0 < (nint)1)
							{
								goto IL_06c8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v40+18]");
							object obj50 = 0 & 0xFFFFFFFFL;
							object obj51 = obj49 + 32;
							bool flag23 = (byte)(int)obj48 != 0;
							obj34 = (UnityEngine.Object)1;
							object obj52 = 0;
							while (true)
							{
								bool flag24 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj52) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50);
								object obj53 = !flag24;
								flag12 = flag23;
								obj17 = 0;
								if (obj53 != null)
								{
									break;
								}
								object obj54 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X0_v259+E4]");
								bool flag25 = (nint)0 == 0;
								object obj55 = !flag25;
								if (obj55 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X21_v29+v922 @ X20_v38*8]");
								bool flag26 = (UnityEngine.Object)0 != obj47;
								bool flag27 = !flag26;
								obj34 = obj47;
								if (!flag27)
								{
									object obj56 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X0_v264+E4]");
									bool flag28 = (nint)0 == 0;
									object obj57 = !flag28;
									if (obj57 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X21_v29+v922 @ X20_v38*8]");
									UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
									obj34 = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v40+18]");
								obj50 = 0;
								obj52++;
								object obj58 = obj52;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v40+18]");
								bool flag29 = (nint)obj58 < 0;
								flag12 = false;
								flag23 = false;
								if (flag29)
								{
									continue;
								}
								goto IL_06c8;
							}
							goto IL_242e;
						}
					}
				}
			}
		}
		goto IL_2420;
		IL_112a:
		System.__Canon[] array;
		object obj61;
		GameObject gameObject2;
		UnityEngine.Object obj74;
		object obj71;
		bool flag33;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA420]");
			object obj59 = 0;
			object obj60 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X0_v193+E4]");
			bool flag30 = (nint)0 == 0;
			object obj62 = !flag30;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj60 = obj59;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X0_v193+A0]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1565 @ X8_v130+40]");
			Func<System.__Canon, bool> func4 = (Func<System.__Canon, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1565 @ X8_v130+40]");
			bool flag31 = (nint)0 == 0;
			object obj64 = !flag31;
			if (obj64 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X0_v193+E4]");
				bool flag32 = (nint)0 == 0;
				object obj65 = !flag32;
				if (obj65 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj66 = obj59;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1574 @ X8_v134+A0]");
					obj63 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4C8]");
				object obj67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA500]");
				object obj68 = 0;
				Func<System.__Canon, bool> func5 = default;
				func5._002Ector(obj63, (IntPtr)obj68);
				object obj69 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ X8_v133+A0]");
				object obj70 = (nint)0 + (nint)64;
				obj70 = func5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				func4 = func5;
				obj71 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA470]");
			object obj72 = 0;
			flag33 = (byte)(int)obj72 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @35CBB88");
			bool flag34 = (object)this == null;
			object obj73 = !flag34;
			gameObject2 = gameObject;
			UnityEngine.Object obj75 = default;
			obj74 = obj75;
			if (obj73 != null)
			{
				goto IL_12cf;
			}
			flag12 = (byte)(int)obj72 != 0;
			obj17 = obj71;
			obj34 = obj75;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj61 = 0;
			bool flag35 = (object)this == null;
			gameObject2 = gameObject;
			obj74 = null;
			flag12 = flag33;
			obj17 = obj71;
			obj34 = null;
			if (!flag35)
			{
				goto IL_12cf;
			}
		}
		goto IL_2420;
		IL_23bd:
		Transform under = gameObject2.transform;
		MonsterWounds.WarmUp(under);
		Transform under2 = gameObject2.transform;
		SawPractice(under2);
		Transform transform3 = gameObject2.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X27_v5 (UnityEngine.Object)+A8]");
		((GillaWarmUp)(object)transform3).KillPractice(transform3, (Dismemberment)0);
		return;
		IL_242e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_243c;
		IL_243c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_2a4b:
		object obj76 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ X0_v75+E4]");
		bool flag36 = (nint)0 == 0;
		object obj77 = !flag36;
		if (obj77 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj78;
		if (!(obj78 != null))
		{
			goto IL_23bd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		bool flag37 = (object)mesh == null;
		flag12 = false;
		obj17 = obj71;
		obj34 = null;
		if (!flag37)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA518]");
			object obj80 = 0;
			mesh.name = (string)obj80;
			object obj81 = this + 56;
			obj81 = mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
			object obj82 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Vector3[] array2 = default;
			bool flag38 = array2 == null;
			flag12 = false;
			obj17 = obj71;
			obj34 = (UnityEngine.Object)3;
			if (!flag38)
			{
				bool flag39 = array2.Length == 0;
				flag12 = false;
				obj17 = obj71;
				obj34 = (UnityEngine.Object)3;
				if (!flag39)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj83 = 0;
					object obj84 = obj83;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X9_v16+A0]");
					object obj85 = 0;
					object obj86 = obj85;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ X9_v17+8]");
					object obj87 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1700 @ X9_v17+8]");
					_ = 0;
					object obj88 = array2.Length & 0xFFFFFFFEL;
					bool flag40 = obj88 == null;
					flag12 = false;
					obj17 = obj71;
					obj34 = (UnityEngine.Object)3;
					if (!flag40)
					{
						object obj89 = obj83;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1710 @ X9_v19+A0]");
						object obj90 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X9_v20+18]");
						obj86 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X9_v20+20]");
						obj87 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X9_v20+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ X9_v20+20]");
						_ = 0;
						bool flag41 = array2.Length < 2;
						object obj91 = !flag41;
						object obj92 = array2.Length - 2;
						bool flag42 = obj92 == null;
						object obj93 = ~obj91;
						object obj94 = obj93 | flag42;
						flag12 = false;
						obj17 = obj71;
						obj34 = (UnityEngine.Object)3;
						if (obj94 == null)
						{
							object obj95 = obj83;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1720 @ X8_v68+A0]");
							object obj96 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v69+3C]");
							obj86 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v69+44]");
							obj87 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v69+3C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v69+44]");
							_ = 0;
							bool flag43 = obj81 == null;
							flag12 = false;
							obj17 = obj71;
							obj34 = (UnityEngine.Object)3;
							if (!flag43)
							{
								((Mesh)obj81).SetVertices(array2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Vector3[] array3 = default;
								bool flag44 = array3 == null;
								flag12 = false;
								obj17 = obj71;
								obj34 = (UnityEngine.Object)3;
								if (!flag44)
								{
									bool flag45 = array3.Length == 0;
									flag12 = false;
									obj17 = obj71;
									obj34 = (UnityEngine.Object)3;
									if (!flag45)
									{
										object obj97 = obj83;
										object obj98 = array3.Length & 0xFFFFFFFEL;
										bool flag46 = obj98 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ X9_v22+A0]");
										object obj99 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X9_v23+54]");
										obj86 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X9_v23+5C]");
										obj87 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X9_v23+54]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X9_v23+5C]");
										_ = 0;
										flag12 = false;
										obj17 = obj71;
										obj34 = (UnityEngine.Object)3;
										if (!flag46)
										{
											object obj100 = obj83;
											bool flag47 = array3.Length < 2;
											object obj101 = !flag47;
											object obj102 = array3.Length - 2;
											bool flag48 = obj102 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1736 @ X9_v24+A0]");
											object obj103 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X9_v25+54]");
											obj86 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X9_v25+5C]");
											obj87 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X9_v25+54]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X9_v25+5C]");
											_ = 0;
											object obj104 = ~obj101;
											object obj105 = obj104 | flag48;
											flag12 = false;
											obj17 = obj71;
											obj34 = (UnityEngine.Object)3;
											if (obj105 == null)
											{
												object obj106 = obj83;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1739 @ X8_v73+A0]");
												object obj107 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v74+54]");
												obj86 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v74+5C]");
												obj87 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v74+54]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v74+5C]");
												_ = 0;
												bool flag49 = obj81 == null;
												flag12 = false;
												obj17 = obj71;
												obj34 = (UnityEngine.Object)3;
												if (!flag49)
												{
													((Mesh)obj81).SetNormals(array3);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
													object obj108 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Vector2[] array4 = default;
													bool flag50 = array4 == null;
													flag12 = false;
													obj17 = obj71;
													obj34 = (UnityEngine.Object)3;
													if (!flag50)
													{
														bool flag51 = array4.Length == 0;
														flag12 = false;
														obj17 = obj71;
														obj34 = (UnityEngine.Object)3;
														if (!flag51)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
															object obj109 = 0;
															object obj110 = obj109;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1754 @ X9_v26+A0]");
															object obj111 = 0;
															obj86 = obj111;
															object obj112 = array4.Length & 0xFFFFFFFEL;
															bool flag52 = obj112 == null;
															flag12 = false;
															obj17 = obj71;
															obj34 = (UnityEngine.Object)3;
															if (!flag52)
															{
																object obj113 = obj109;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1764 @ X9_v30+A0]");
																object obj114 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1765 @ X9_v31+10]");
																obj86 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1765 @ X9_v31+10]");
																_ = 0;
																bool flag53 = array4.Length < 2;
																object obj115 = !flag53;
																object obj116 = array4.Length - 2;
																bool flag54 = obj116 == null;
																object obj117 = ~obj115;
																object obj118 = obj117 | flag54;
																flag12 = false;
																obj17 = obj71;
																obj34 = (UnityEngine.Object)3;
																if (obj118 == null)
																{
																	object obj119 = obj109;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X8_v82+A0]");
																	object obj120 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v83+28]");
																	obj86 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v83+28]");
																	_ = 0;
																	bool flag55 = obj81 == null;
																	flag12 = false;
																	obj17 = obj71;
																	obj34 = (UnityEngine.Object)3;
																	if (!flag55)
																	{
																		((Mesh)obj81).SetUVs(0, array4);
																		bool flag56 = obj81 == null;
																		flag12 = (byte)(int)array4 != 0;
																		obj17 = 0;
																		obj34 = null;
																		if (!flag56)
																		{
																			((Mesh)obj81).SetUVs(1, array4);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																			object obj121 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6780]");
																			object obj122 = 0;
																			flag12 = (byte)(int)obj122 != 0;
																			List<Vector3> list = default;
																			list._002Ector((IEnumerable<Vector3>)array2);
																			bool flag57 = obj81 == null;
																			obj17 = 0;
																			obj34 = (UnityEngine.Object)(object)array2;
																			if (!flag57)
																			{
																				((Mesh)obj81).SetUVs(2, list);
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																				flag12 = (byte)(int)obj122 != 0;
																				List<Vector3> list2 = default;
																				list2._002Ector((IEnumerable<Vector3>)array2);
																				bool flag58 = obj81 == null;
																				obj17 = 0;
																				obj34 = (UnityEngine.Object)(object)array2;
																				if (!flag58)
																				{
																					((Mesh)obj81).SetUVs(3, list2);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F8]");
																					object obj123 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																					BoneWeight[] array5 = default;
																					bool flag59 = array5 == null;
																					flag12 = (byte)(int)list2 != 0;
																					obj17 = 0;
																					obj34 = (UnityEngine.Object)3;
																					if (!flag59)
																					{
																						bool flag60 = array5.Length == 0;
																						flag12 = (byte)(int)list2 != 0;
																						obj17 = 0;
																						obj34 = (UnityEngine.Object)(object)array5;
																						if (!flag60)
																						{
																							bool flag61 = array5.Length == 1;
																							_ = 0;
																							_ = 1065353216;
																							_ = 0;
																							_ = 0;
																							_ = 0;
																							flag12 = (byte)(int)list2 != 0;
																							obj17 = 0;
																							obj34 = (UnityEngine.Object)(object)array5;
																							if (!flag61)
																							{
																								bool flag62 = array5.Length < 2;
																								object obj124 = !flag62;
																								object obj125 = array5.Length - 2;
																								bool flag63 = obj125 == null;
																								_ = 1065353216;
																								_ = 0;
																								_ = 0;
																								_ = 0;
																								_ = 0;
																								object obj126 = ~obj124;
																								object obj127 = obj126 | flag63;
																								flag12 = (byte)(int)list2 != 0;
																								obj17 = 0;
																								obj34 = (UnityEngine.Object)(object)array5;
																								if (obj127 == null)
																								{
																									_ = 0;
																									_ = 1065353216;
																									_ = 0;
																									_ = 0;
																									_ = 0;
																									bool flag64 = obj81 == null;
																									flag12 = (byte)(int)list2 != 0;
																									obj17 = 0;
																									obj34 = (UnityEngine.Object)(object)array5;
																									if (!flag64)
																									{
																										((Mesh)obj81).boneWeights = array5;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
																										object obj128 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																										Matrix4x4[] array6 = default;
																										bool flag65 = array6 == null;
																										flag12 = false;
																										obj17 = 0;
																										obj34 = (UnityEngine.Object)1;
																										if (!flag65)
																										{
																											bool flag66 = array6.Length == 0;
																											flag12 = false;
																											obj17 = 0;
																											obj34 = (UnityEngine.Object)1;
																											if (flag66)
																											{
																												goto IL_242e;
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
																											object obj129 = 0;
																											object obj130 = obj129;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1804 @ X8_v94+A0]");
																											object obj131 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v95+60]");
																											obj87 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v95+70]");
																											obj86 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v95+60]");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v95+70]");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v95+40]");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v95+50]");
																											_ = 0;
																											bool flag67 = obj81 == null;
																											flag12 = false;
																											obj17 = 0;
																											obj34 = (UnityEngine.Object)1;
																											if (!flag67)
																											{
																												((Mesh)obj81).bindposes = array6;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
																												object obj132 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																												int[] array7 = default;
																												bool flag68 = array7 == null;
																												flag12 = false;
																												obj17 = 0;
																												obj34 = (UnityEngine.Object)3;
																												if (!flag68)
																												{
																													bool flag69 = array7.Length < 1;
																													object obj133 = !flag69;
																													object obj134 = array7.Length - 1;
																													bool flag70 = obj134 == null;
																													object obj135 = ~obj133;
																													object obj136 = obj135 | flag70;
																													flag12 = false;
																													obj17 = 0;
																													obj34 = (UnityEngine.Object)(object)array7;
																													if (obj136 == null)
																													{
																														bool flag71 = array7.Length == 2;
																														array7[1] = 1;
																														flag12 = false;
																														obj17 = 0;
																														obj34 = (UnityEngine.Object)(object)array7;
																														if (!flag71)
																														{
																															array7[2] = 2;
																															bool flag72 = obj81 == null;
																															flag12 = false;
																															obj17 = 0;
																															obj34 = (UnityEngine.Object)(object)array7;
																															if (!flag72)
																															{
																																((Mesh)obj81).SetTriangles(array7, 0);
																																bool flag73 = obj81 == null;
																																flag12 = false;
																																obj17 = 0;
																																obj34 = (UnityEngine.Object)(object)array7;
																																if (!flag73)
																																{
																																	((Mesh)obj81).RecalculateBounds();
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
																																	object obj137 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA510]");
																																	object obj138 = 0;
																																	GameObject gameObject3 = default;
																																	gameObject3._002Ector((string)obj138);
																																	bool flag74 = (object)gameObject3 == null;
																																	flag12 = false;
																																	obj17 = 0;
																																	obj34 = (UnityEngine.Object)obj138;
																																	if (!flag74)
																																	{
																																		Transform transform4 = gameObject3.transform;
																																		Transform parent2 = gameObject2.transform;
																																		bool flag75 = (object)transform4 == null;
																																		flag12 = false;
																																		obj17 = 0;
																																		obj34 = null;
																																		if (!flag75)
																																		{
																																			transform4.SetParent(parent2, worldPositionStays: false);
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
																																			object obj139 = 0;
																																			obj34 = (UnityEngine.Object)obj139;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																																			SkinnedMeshRenderer skinnedMeshRenderer = default;
																																			bool flag76 = (object)skinnedMeshRenderer == null;
																																			flag12 = false;
																																			obj17 = 0;
																																			if (!flag76)
																																			{
																																				skinnedMeshRenderer.sharedMesh = (Mesh)obj81;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
																																				object obj140 = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																				Transform transform5 = gameObject3.transform;
																																				Transform[] array8 = default;
																																				bool flag77 = array8 == null;
																																				flag12 = false;
																																				obj17 = 0;
																																				obj34 = null;
																																				if (!flag77)
																																				{
																																					bool flag78 = (object)transform5 == null;
																																					UnityEngine.Object obj141 = null;
																																					if (!flag78)
																																					{
																																						nint num = (nint)array8;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X8_v114 (Il2CppClass<UnityEngine.Transform[]>)+40]");
																																						obj141 = (UnityEngine.Object)0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																						bool flag79 = ex == null;
																																						flag12 = false;
																																						obj17 = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X8_v114 (Il2CppClass<UnityEngine.Transform[]>)+40]");
																																						obj34 = (UnityEngine.Object)0;
																																						if (flag79)
																																						{
																																							goto IL_243c;
																																						}
																																					}
																																					bool flag80 = array8.Length == 0;
																																					flag12 = false;
																																					obj17 = 0;
																																					obj34 = obj141;
																																					if (flag80)
																																					{
																																						goto IL_242e;
																																					}
																																					object obj142 = array8 + 32;
																																					obj142 = transform5;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																					skinnedMeshRenderer.bones = array8;
																																					Transform rootBone = gameObject3.transform;
																																					skinnedMeshRenderer.rootBone = rootBone;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
																																					object obj143 = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																					Material material = default;
																																					material._002Ector((Material)obj78);
																																					object obj144 = this + 64;
																																					obj144 = material;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																					bool flag81 = obj144 == null;
																																					flag12 = false;
																																					obj17 = 0;
																																					obj34 = material;
																																					if (!flag81)
																																					{
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9F88]");
																																						object obj145 = 0;
																																						((Material)obj144).SetFloat((string)obj145, 1f);
																																						skinnedMeshRenderer.sharedMaterial = (Material)obj144;
																																						obj71 = 0;
																																						goto IL_23bd;
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																															goto IL_2420;
																														}
																													}
																													goto IL_242e;
																												}
																											}
																										}
																									}
																									goto IL_2420;
																								}
																							}
																						}
																						goto IL_242e;
																					}
																				}
																			}
																		}
																	}
																	goto IL_2420;
																}
															}
														}
														goto IL_242e;
													}
												}
												goto IL_2420;
											}
										}
									}
									goto IL_242e;
								}
							}
							goto IL_2420;
						}
					}
				}
				goto IL_242e;
			}
		}
		goto IL_2420;
		IL_0886:
		gameObject.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4250]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj147 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v33+E4]");
		bool flag82 = (nint)0 == 0;
		object obj148 = !flag82;
		if (obj148 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj147 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v33+A0]");
		object obj149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X9_v47+30]");
		Func<System.__Canon, bool> predicate = (Func<System.__Canon, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X9_v47+30]");
		bool flag83 = (nint)0 == 0;
		object obj150 = !flag83;
		obj17 = 0;
		if (obj150 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v33+E4]");
			bool flag84 = (nint)0 == 0;
			object obj151 = !flag84;
			if (obj151 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj152 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X8_v161+A0]");
				obj149 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4C0]");
			object obj153 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4F0]");
			object obj154 = 0;
			Func<System.__Canon, bool> func6 = default;
			func6._002Ector(obj149, (IntPtr)obj154);
			object obj155 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1328 @ X8_v160+A0]");
			object obj156 = (nint)0 + (nint)48;
			obj156 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			predicate = func6;
			obj17 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4A0]");
		object obj157 = 0;
		flag12 = (byte)(int)obj157 != 0;
		IEnumerable<System.__Canon> source3 = default;
		IEnumerable<System.__Canon> source2 = Enumerable.Where(source3, predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA498]");
		object obj158 = 0;
		obj34 = (UnityEngine.Object)obj158;
		System.__Canon[] array9 = Enumerable.ToArray(source2);
		if (array9 == null)
		{
			goto IL_2420;
		}
		bool flag85 = array9.Length < 1;
		Material[] array10 = (Material[])obj157;
		SkinnedMeshRenderer skinnedMeshRenderer2 = (SkinnedMeshRenderer)obj158;
		if (flag85)
		{
			goto IL_0b15;
		}
		object obj159 = array9.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D18]");
		object obj160 = 0;
		object obj161 = array9 + 32;
		object obj162 = 0;
		while (true)
		{
			bool flag86 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj162) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj159);
			object obj163 = !flag86;
			if (obj163 != null)
			{
				break;
			}
			object obj164 = obj160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X0_v239+E4]");
			bool flag87 = (nint)0 == 0;
			object obj165 = !flag87;
			if (obj165 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X25_v24+v923 @ X20_v32*8]");
			Material[] array11 = Dismemberment.WithCaps((SkinnedMeshRenderer)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X25_v24+v923 @ X20_v32*8]");
			Piece((SkinnedMeshRenderer)0, array11);
			obj159 = array9.Length;
			obj162++;
			bool flag88 = (nint)obj162 < array9.Length;
			array10 = array11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X25_v24+v923 @ X20_v32*8]");
			skinnedMeshRenderer2 = (SkinnedMeshRenderer)0;
			flag12 = (byte)(int)array11 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X25_v24+v923 @ X20_v32*8]");
			obj34 = (UnityEngine.Object)0;
			if (flag88)
			{
				continue;
			}
			goto IL_0b15;
		}
		goto IL_242e;
		IL_06c8:
		object obj166 = obj47 + 72;
		obj166 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj167 = obj47 + 88;
		obj167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj168 = 0;
		flag12 = (byte)(int)obj168 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj169 = default;
		bool flag89 = obj169 == null;
		obj17 = 0;
		obj34 = (UnityEngine.Object)1;
		if (flag89)
		{
			goto IL_2420;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v49+18]");
		object obj170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v49+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0886;
		}
		object obj171 = obj169 + 32;
		obj34 = (UnityEngine.Object)1;
		object obj172 = 0;
		while (true)
		{
			bool flag90 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj172) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj170);
			object obj173 = !flag90;
			obj17 = 0;
			if (obj173 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X21_v28+v736 @ X20_v35*8]");
			bool flag91 = (nint)0 == 0;
			obj17 = 0;
			if (!flag91)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X21_v28+v736 @ X20_v35*8]");
				GameObject gameObject4 = ((Component)0).gameObject;
				bool flag92 = (object)gameObject4 == null;
				obj17 = 0;
				obj34 = null;
				if (!flag92)
				{
					gameObject4.layer = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v49+18]");
					obj170 = 0;
					obj172++;
					object obj174 = obj172;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v49+18]");
					bool flag93 = (nint)obj174 < 0;
					flag12 = false;
					obj34 = null;
					if (flag93)
					{
						continue;
					}
					goto IL_0886;
				}
			}
			goto IL_2420;
		}
		goto IL_242e;
		IL_0b15:
		object obj175 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v61+E4]");
		bool flag94 = (nint)0 == 0;
		object obj176 = !flag94;
		if (obj176 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj175 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v61+A0]");
		object obj177 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1446 @ X8_v145+38]");
		Func<System.__Canon, System.__Canon> selector2 = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1446 @ X8_v145+38]");
		bool flag95 = (nint)0 == 0;
		object obj178 = !flag95;
		if (obj178 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v61+E4]");
			bool flag96 = (nint)0 == 0;
			object obj179 = !flag96;
			if (obj179 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj180 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X8_v149+A0]");
				obj177 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4A8]");
			object obj181 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4F8]");
			object obj182 = 0;
			Func<System.__Canon, System.__Canon> func7 = default;
			func7._002Ector(obj177, (IntPtr)obj182);
			object obj183 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1432 @ X8_v148+A0]");
			object obj184 = (nint)0 + (nint)56;
			obj184 = func7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			selector2 = func7;
			obj17 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA488]");
		object obj185 = 0;
		flag12 = (byte)(int)obj185 != 0;
		IEnumerable<System.__Canon> source4 = Enumerable.Select(array9, selector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA490]");
		object obj186 = 0;
		array = Enumerable.ToArray(source4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj187 = 0;
		object obj188 = obj187;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v50+E4]");
		bool flag97 = (nint)0 == 0;
		object obj189 = !flag97;
		if (obj189 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds gillaWounds = GillaWounds.On((Dismemberment)obj47);
		bool flag98 = (object)gillaWounds == null;
		obj34 = null;
		SkinnedMeshRenderer skinnedMeshRenderer3 = default;
		UnityEngine.Object obj202;
		if (!flag98)
		{
			gillaWounds.Practice();
			if (array9.Length >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA520]");
				object obj190 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
				object obj191 = 0;
				object obj192 = array9 + 32;
				object obj193 = array + 32;
				object obj194 = 0;
				UnityEngine.Object obj195 = null;
				GameObject gameObject5 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj196 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					gameObject5._002Ector((string)obj190);
					bool flag99 = (object)gameObject5 == null;
					flag12 = false;
					obj34 = (UnityEngine.Object)obj190;
					if (flag99)
					{
						break;
					}
					Transform transform6 = gameObject5.transform;
					Transform parent3 = gameObject.transform;
					bool flag100 = (object)transform6 == null;
					flag12 = false;
					obj34 = null;
					if (flag100)
					{
						break;
					}
					transform6.SetParent(parent3, worldPositionStays: false);
					obj34 = (UnityEngine.Object)obj191;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					bool flag101 = (nint)obj194 < array9.Length;
					object obj197 = !flag101;
					flag12 = false;
					obj17 = 0;
					if (obj197 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X28_v8+v433 @ X29_v5*8]");
						bool flag102 = (nint)0 == 0;
						flag12 = false;
						obj17 = 0;
						if (flag102)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X28_v8+v433 @ X29_v5*8]");
						Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
						bool flag103 = (object)skinnedMeshRenderer3 == null;
						flag12 = false;
						obj17 = 0;
						obj34 = null;
						if (flag103)
						{
							break;
						}
						skinnedMeshRenderer3.sharedMesh = sharedMesh;
						bool flag104 = (nint)obj194 < array9.Length;
						object obj198 = !flag104;
						flag12 = false;
						obj17 = 0;
						obj34 = sharedMesh;
						if (obj198 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X28_v8+v433 @ X29_v5*8]");
							bool flag105 = (nint)0 == 0;
							flag12 = false;
							obj17 = 0;
							obj34 = sharedMesh;
							if (flag105)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X28_v8+v433 @ X29_v5*8]");
							Transform[] array12 = (skinnedMeshRenderer3.bones = ((SkinnedMeshRenderer)0).bones);
							bool flag106 = (nint)obj194 < array9.Length;
							object obj199 = !flag106;
							flag12 = false;
							obj17 = 0;
							obj34 = (UnityEngine.Object)(object)array12;
							if (obj199 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X28_v8+v433 @ X29_v5*8]");
								bool flag107 = (nint)0 == 0;
								flag12 = false;
								obj17 = 0;
								obj34 = (UnityEngine.Object)(object)array12;
								if (flag107)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X28_v8+v433 @ X29_v5*8]");
								Transform transform7 = (skinnedMeshRenderer3.rootBone = ((SkinnedMeshRenderer)0).rootBone);
								bool flag108 = array == null;
								flag12 = false;
								obj17 = 0;
								obj34 = transform7;
								if (flag108)
								{
									break;
								}
								bool flag109 = (nint)obj194 < array.Length;
								object obj200 = !flag109;
								flag12 = false;
								obj17 = 0;
								obj34 = transform7;
								if (obj200 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X21_v25+v433 @ X29_v5*8]");
									skinnedMeshRenderer3.sharedMaterials = (Material[])0;
									bool flag110 = (nint)obj194 < array.Length;
									object obj201 = !flag110;
									flag12 = false;
									obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X21_v25+v433 @ X29_v5*8]");
									obj34 = (UnityEngine.Object)0;
									if (obj201 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X21_v25+v433 @ X29_v5*8]");
										Piece(skinnedMeshRenderer3, (Material[])0);
										obj194++;
										bool flag111 = (nint)obj194 < array9.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X21_v25+v433 @ X29_v5*8]");
										flag12 = false;
										obj17 = 0;
										obj195 = skinnedMeshRenderer3;
										if (flag111)
										{
											continue;
										}
										goto IL_10cd;
									}
								}
							}
						}
					}
					goto IL_242e;
				}
			}
			else
			{
				bool flag112 = array == null;
				flag33 = flag12;
				obj71 = obj17;
				obj202 = null;
				obj34 = null;
				if (!flag112)
				{
					goto IL_112a;
				}
			}
		}
		goto IL_2420;
		IL_10cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X21_v25+v433 @ X29_v5*8]");
		flag33 = false;
		obj71 = 0;
		obj202 = skinnedMeshRenderer3;
		goto IL_112a;
		IL_1449:
		Material material2;
		obj78 = material2;
		flag33 = false;
		goto IL_2a4b;
		IL_12cf:
		object obj203 = this + 88;
		obj203 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj204 = array9.Length;
		if (array9.Length >= 1)
		{
			object obj205 = array9 + 32;
			UnityEngine.Object obj206 = null;
			object obj207 = 0;
			while (true)
			{
				bool flag113 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj207) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj204);
				object obj208 = !flag113;
				flag12 = flag33;
				obj17 = obj71;
				obj34 = obj74;
				if (obj208 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X21_v24+v742 @ X20_v25*8]");
				bool flag114 = (nint)0 == 0;
				flag12 = flag33;
				obj17 = obj71;
				obj34 = obj74;
				if (!flag114)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X21_v24+v742 @ X20_v25*8]");
					Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X21_v24+v742 @ X20_v25*8]");
					Piece((SkinnedMeshRenderer)0, sharedMaterials);
					object obj209 = obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1652 @ X0_v184+E4]");
					bool flag115 = (nint)0 == 0;
					object obj210 = !flag115;
					if (obj210 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag116 = obj206 == null;
					bool flag117 = !flag116;
					material2 = (Material)obj206;
					obj74 = null;
					if (!flag117)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X21_v24+v742 @ X20_v25*8]");
						Material sharedMaterial = ((Renderer)0).sharedMaterial;
						material2 = sharedMaterial;
						obj74 = null;
					}
					obj204 = array9.Length;
					obj207++;
					bool flag118 = (nint)obj207 < array9.Length;
					obj206 = material2;
					flag33 = false;
					if (flag118)
					{
						continue;
					}
					goto IL_1449;
				}
				goto IL_2420;
			}
			goto IL_242e;
		}
		obj78 = null;
		goto IL_2a4b;
		IL_2420:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_242e;
	}

	private void KillPractice(Transform under, Dismemberment from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0b3c: Expected Obj, but got I4
		//IL_0b62: Expected Obj, but got I
		//IL_0b84: Expected Obj, but got I4
		//IL_0ef9: Expected Obj, but got I
		//IL_0f21: Expected Obj, but got I4
		//IL_0ba2: Expected Obj, but got I
		//IL_0bc2: Expected Obj, but got I
		//IL_0be4: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I
		//IL_011a: Expected I4, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0323: Expected Obj, but got I4
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I8
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I4
		//IL_01c3: Expected I4, but got Obj
		//IL_01cc: Expected Obj, but got I4
		//IL_0c73: Expected Obj, but got I
		//IL_0c86: Expected VT, but got I4
		//IL_0c96: Expected Obj, but got I
		//IL_0cc0: Expected Obj, but got I4
		//IL_0c0b: Expected Obj, but got I4
		//IL_0c14: Expected Obj, but got I4
		//IL_0c1d: Expected Obj, but got I4
		//IL_0c35: Expected Obj, but got I
		//IL_0c45: Expected Obj, but got I
		//IL_0cde: Expected Obj, but got I
		//IL_0cfe: Expected Obj, but got I
		//IL_0d16: Expected Obj, but got I
		//IL_0d26: Expected Obj, but got I
		//IL_0d48: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		//IL_03bf: Expected VT, but got I4
		//IL_03bf: Expected I4, but got I8
		//IL_03ed: Expected Obj, but got I4
		//IL_0402: Expected I4, but got I8
		//IL_022d: Expected Obj, but got I
		//IL_0ed3: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_0979: Expected I, but got Obj
		//IL_0981: Expected Obj, but got I
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_0d8d: Expected Obj, but got I4
		//IL_0ac9: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I4
		//IL_0dab: Expected Obj, but got I
		//IL_0a05: Expected I, but got Obj
		//IL_04c9: Expected Obj, but got I
		//IL_04d1: Expected I4, but got Obj
		//IL_04e6: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_0527: Expected I4, but got Obj
		//IL_0549: Expected Obj, but got I4
		//IL_0567: Expected Obj, but got I
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected Obj, but got Unknown
		//IL_05a3: Expected Obj, but got I4
		//IL_05ab: Expected I4, but got Obj
		//IL_05b4: Expected Obj, but got I4
		//IL_0df7: Expected Obj, but got I4
		//IL_0e21: Expected I, but got Obj
		//IL_06d1: Expected Obj, but got I
		//IL_06e1: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I
		//IL_0707: Expected VT, but got I4
		//IL_0717: Expected Obj, but got I
		//IL_071f: Expected I4, but got Obj
		//IL_05fc: Expected Obj, but got I
		//IL_060c: Expected Obj, but got I
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0653: Expected Obj, but got I4
		//IL_0742: Expected I, but got Obj
		//IL_074b: Expected Obj, but got I4
		//IL_0769: Expected Obj, but got I
		//IL_08d0: Expected Obj, but got I4
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Expected Obj, but got Unknown
		//IL_07ad: Expected I4, but got Obj
		//IL_07b6: Expected Obj, but got I4
		//IL_0e9b: Expected Obj, but got I4
		//IL_0e56: Expected Obj, but got I4
		//IL_0e5b: Expected I, but got Obj
		//IL_0f3f: Expected Obj, but got I
		//IL_0f4a: Expected I, but got Obj
		//IL_07dc: Expected I, but got Obj
		//IL_0803: Expected Obj, but got I
		//IL_081b: Expected I, but got Obj
		//IL_0854: Expected Obj, but got I
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v6+A0]");
		object obj8 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (from == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj10 = 0;
		object obj11 = obj5;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA658]");
		object obj15 = 0;
		System.__Canon _Canon = (System.__Canon)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA58]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
		Dismemberment dismemberment = default;
		bool flag5 = (object)dismemberment == null;
		object obj17 = 0;
		object obj18 = 0;
		bool flag6 = false;
		GillaCorpse gillaCorpse = (GillaCorpse)109891584;
		object obj23;
		Transform parent;
		bool flag8;
		object obj26;
		object obj27;
		object obj25;
		object obj22;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA468]");
			object obj19 = 0;
			flag6 = (byte)(int)obj19 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj20 = default;
			bool flag7 = obj20 == null;
			obj17 = 0;
			obj18 = 0;
			_Canon = (System.__Canon)1;
			gillaCorpse = (GillaCorpse)109891584;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v26+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_030c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v26+18]");
				object obj21 = 0 & 0xFFFFFFFFL;
				obj22 = obj20 + 32;
				obj23 = 0;
				flag8 = (byte)(int)obj19 != 0;
				_Canon = (System.__Canon)1;
				while (true)
				{
					bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
					object obj24 = !flag9;
					obj17 = 0;
					obj18 = 0;
					obj25 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v13+8]");
					obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v13+C]");
					obj27 = 0;
					parent = under;
					if (obj24 != null)
					{
						break;
					}
					object obj28 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v124+E4]");
					bool flag10 = (nint)0 == 0;
					object obj29 = !flag10;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X27_v4+v400 @ X26_v4*8]");
					bool flag11 = (UnityEngine.Object)0 != dismemberment;
					bool flag12 = !flag11;
					_Canon = (System.__Canon)(object)dismemberment;
					if (!flag12)
					{
						object obj30 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X0_v129+E4]");
						bool flag13 = (nint)0 == 0;
						object obj31 = !flag13;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X27_v4+v400 @ X26_v4*8]");
						UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
						_Canon = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v26+18]");
					obj21 = 0;
					obj23++;
					object obj32 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v26+18]");
					bool flag14 = (nint)obj32 < 0;
					flag6 = false;
					flag8 = false;
					if (flag14)
					{
						continue;
					}
					goto IL_030c;
				}
				goto IL_0922;
			}
		}
		goto IL_0a9d;
		IL_0ea9:
		object obj33 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v28+E4]");
		bool flag15 = (nint)0 == 0;
		object obj34 = !flag15;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = gillaCorpse != null;
		bool flag17 = !flag16;
		flag6 = false;
		if (!flag17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v40+E4]");
			bool flag18 = (nint)0 == 0;
			object obj37 = !flag18;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj36 = obj35;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v40+A0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v29+8]");
			bool flag19 = (nint)0 == 0;
			flag6 = false;
			_Canon = null;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA650]");
				object obj39 = 0;
				flag6 = (byte)(int)obj39 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v29+8]");
				bool flag20 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)gillaCorpse);
				bool flag21 = (object)gillaCorpse == null;
				_Canon = (System.__Canon)(object)gillaCorpse;
				if (!flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA648]");
					object obj40 = 0;
					flag6 = (byte)(int)obj40 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
					object obj41 = default;
					bool flag22 = obj41 == null;
					_Canon = (System.__Canon)1;
					if (!flag22)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+18]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+18]");
						if ((nint)0 < (nint)1)
						{
							goto IL_0661;
						}
						object obj43 = obj41 + 32;
						object obj44 = 0;
						flag8 = (byte)(int)obj40 != 0;
						_Canon = (System.__Canon)1;
						while (true)
						{
							bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
							object obj45 = !flag23;
							object obj46 = obj44;
							if (obj45 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X29_v7+v396 @ X28_v9*8]");
							bool flag24 = (nint)0 == 0;
							flag6 = flag8;
							if (!flag24)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X29_v7+v396 @ X28_v9*8]");
								((Rigidbody)0).isKinematic = true;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+18]");
								obj42 = 0;
								obj46 = obj44 + 1;
								object obj47 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+18]");
								bool flag25 = (nint)obj47 < 0;
								flag6 = false;
								obj44 = obj46;
								flag8 = false;
								_Canon = (System.__Canon)1;
								if (flag25)
								{
									continue;
								}
								goto IL_0661;
							}
							goto IL_0a9d;
						}
						goto IL_0922;
					}
				}
			}
			goto IL_0a9d;
		}
		goto IL_0d56;
		IL_08a6:
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X0_v55+E4]");
		bool flag26 = (nint)0 == 0;
		object obj49 = !flag26;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v59+E4]");
		bool flag27 = (nint)0 == 0;
		object obj51 = !flag27;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj50 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v59+A0]");
		object obj52 = 0;
		_ = 1;
		nint num = unchecked((nint)null);
		goto IL_0d56;
		IL_0a9d:
		throw new NullReferenceException();
		IL_0d56:
		GameObject obj53 = dismemberment.gameObject;
		object obj54 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v27+E4]");
		bool flag28 = (nint)0 == 0;
		object obj55 = !flag28;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(obj53);
		return;
		IL_0661:
		Transform transform = gillaCorpse.transform;
		bool flag29 = (object)transform == null;
		_Canon = null;
		if (!flag29)
		{
			transform.SetParent(parent, worldPositionStays: false);
			Transform transform2 = gillaCorpse.transform;
			bool flag30 = (object)transform2 == null;
			num = unchecked((nint)null);
			flag6 = false;
			_Canon = null;
			if (!flag30)
			{
				object obj56 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v38+A0]");
				object obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v39+4]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v39+8]");
				obj17 = 0;
				obj18 = obj57;
				transform2.localPosition = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
				object obj58 = 0;
				flag6 = (byte)(int)obj58 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
				Transform transform3 = default;
				bool flag31 = (object)transform3 == null;
				num = unchecked((nint)null);
				_Canon = (System.__Canon)1;
				if (!flag31)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v53 (UnityEngine.Transform)+18]");
					object obj59 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v53 (UnityEngine.Transform)+18]");
					bool flag32 = (nint)0 < (nint)1;
					int num2 = 1;
					if (flag32)
					{
						goto IL_08a6;
					}
					object obj60 = transform3 + 32;
					flag8 = (byte)(int)obj58 != 0;
					_Canon = (System.__Canon)1;
					gillaCorpse = null;
					while (true)
					{
						bool flag33 = System.Runtime.CompilerServices.Unsafe.As<GillaCorpse, UIntPtr>(ref gillaCorpse) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj59);
						object obj61 = !flag33;
						num = unchecked((nint)null);
						parent = transform3;
						if (obj61 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X22_v11+v504 @ X21_v4 (GillaCorpse)*8]");
						bool flag34 = (nint)0 == 0;
						num = unchecked((nint)null);
						flag6 = flag8;
						if (!flag34)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X22_v11+v504 @ X21_v4 (GillaCorpse)*8]");
							GameObject gameObject = ((Component)0).gameObject;
							bool flag35 = (object)gameObject == null;
							num = unchecked((nint)null);
							flag6 = flag8;
							_Canon = null;
							if (!flag35)
							{
								gameObject.layer = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v53 (UnityEngine.Transform)+18]");
								obj59 = 0;
								gillaCorpse = (GillaCorpse)(gillaCorpse + 1);
								GillaCorpse gillaCorpse2 = gillaCorpse;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v53 (UnityEngine.Transform)+18]");
								bool flag36 = (nint)gillaCorpse2 < 0;
								flag6 = false;
								num2 = 0;
								flag8 = false;
								_Canon = null;
								if (flag36)
								{
									continue;
								}
								goto IL_08a6;
							}
						}
						goto IL_0a9d;
					}
					goto IL_0922;
				}
			}
		}
		goto IL_0a9d;
		IL_0922:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		bool flag37 = (nint)_Canon != 1;
		IndexOutOfRangeException ex2 = ex;
		byte b;
		int num5;
		if (!flag37)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			GillaCorpse gillaCorpse3 = default;
			nint num3 = (nint)gillaCorpse3;
			_Canon = (System.__Canon)num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj63 = default;
			object obj62 = obj63 & 1;
			bool flag38 = obj62 == null;
			flag6 = flag8;
			gillaCorpse = gillaCorpse3;
			if (!flag38)
			{
				gillaCorpse = gillaCorpse3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				bool flag39 = (object)gillaCorpse3 == null;
				flag6 = flag8;
				if (flag39)
				{
					goto IL_0a9d;
				}
				nint num4 = (nint)gillaCorpse;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v734 @ X8_v57 (Il2CppClass<GillaCorpse>)+188] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string text = default;
				string text2 = default;
				string message = text + text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v94+E4]");
				bool flag40 = (nint)0 == 0;
				object obj64 = !flag40;
				if (obj64 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				b = 0;
				num5 = 0;
				gillaCorpse = null;
				goto IL_0ea9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj65 = gillaCorpse;
			_Canon = (System.__Canon)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			flag8 = false;
			IndexOutOfRangeException ex3 = default;
			ex2 = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_030c:
		object obj66 = dismemberment + 72;
		obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj67 = dismemberment + 88;
		obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		obj23 = 0;
		_ = 1;
		object obj68 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v62+A0]");
		object obj69 = 0;
		dismemberment.Tear((ApePart)0, (Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj70 = 0;
		object obj71 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v106+E4]");
		bool flag41 = (nint)0 == 0;
		object obj72 = !flag41;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b2 = NetworkApe.TornBit((ApePart)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj73 = 0;
		object obj74 = obj23;
		object obj75 = obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X9_v13+A0]");
		object obj76 = 0;
		obj26 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v71+4]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v71+8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v111+E4]");
		bool flag42 = (nint)0 == 0;
		object obj77 = !flag42;
		if (obj77 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCorpse gillaCorpse4 = GillaCorpse.Make(dismemberment, -77777, b2, (Vector3)1, quiet: false);
		num = 1;
		obj16 = obj27;
		obj17 = obj25;
		obj18 = obj26;
		obj22 = 109891584;
		b = b2;
		num5 = -77777;
		parent = under;
		gillaCorpse = gillaCorpse4;
		goto IL_0ea9;
	}

	private void SawPractice(Transform under)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_4a14: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_4a4c: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02a9: Expected F8, but got Obj
		//IL_02b9: Expected F8, but got I
		//IL_4a6e: Expected Obj, but got I8
		//IL_4a8b: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I
		//IL_02f8: Expected F8, but got I
		//IL_0308: Expected F8, but got I
		//IL_4ab5: Expected Obj, but got I4
		//IL_4ac5: Expected Obj, but got I4
		//IL_4ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4aea: Expected Obj, but got Unknown
		//IL_4af8: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I
		//IL_034f: Expected F8, but got I
		//IL_035f: Expected F8, but got I
		//IL_036f: Expected Obj, but got I
		//IL_4b23: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got I8
		//IL_045e: Expected Obj, but got I
		//IL_046e: Expected F8, but got I
		//IL_047e: Expected F8, but got I
		//IL_04a6: Expected Obj, but got I4
		//IL_04d8: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_0507: Expected Obj, but got I
		//IL_0517: Expected F8, but got I
		//IL_0527: Expected F8, but got I
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0565: Expected Obj, but got I4
		//IL_058b: Expected Obj, but got I
		//IL_059b: Expected F8, but got I
		//IL_05ab: Expected F8, but got I
		//IL_05e2: Expected Obj, but got I
		//IL_0601: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I
		//IL_063f: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_0667: Expected F8, but got Obj
		//IL_0677: Expected F8, but got I
		//IL_0695: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I4
		//IL_075a: Expected Obj, but got I
		//IL_076a: Expected Obj, but got I
		//IL_077f: Expected VT, but got I
		//IL_078f: Expected Obj, but got I
		//IL_0718: Expected Obj, but got I
		//IL_072e: Expected Obj, but got I
		//IL_4b6b: Expected Obj, but got I
		//IL_4b7b: Expected Obj, but got I
		//IL_4b91: Expected Obj, but got I
		//IL_4ba1: Expected F8, but got I
		//IL_4bb1: Expected F8, but got I
		//IL_07c2: Expected Obj, but got I4
		//IL_0837: Expected Obj, but got I
		//IL_0847: Expected Obj, but got I
		//IL_085c: Expected VT, but got I
		//IL_086c: Expected Obj, but got I
		//IL_07ed: Expected Obj, but got I
		//IL_0803: Expected Obj, but got I
		//IL_4c00: Expected Obj, but got I
		//IL_4c10: Expected Obj, but got I
		//IL_4c26: Expected Obj, but got I
		//IL_4c36: Expected F8, but got I
		//IL_4c46: Expected F8, but got I
		//IL_089f: Expected Obj, but got I4
		//IL_0914: Expected Obj, but got I
		//IL_0924: Expected Obj, but got I
		//IL_0939: Expected VT, but got I
		//IL_0960: Expected Obj, but got I
		//IL_08ca: Expected Obj, but got I
		//IL_08e0: Expected Obj, but got I
		//IL_097f: Expected Obj, but got I
		//IL_09ca: Expected Obj, but got I
		//IL_09e0: Expected Obj, but got I
		//IL_0a40: Expected Obj, but got I4
		//IL_0ab8: Expected Obj, but got I
		//IL_0ac8: Expected Obj, but got I
		//IL_0add: Expected VT, but got I
		//IL_0af3: Expected Obj, but got I4
		//IL_0afc: Expected F8, but got I4
		//IL_0b05: Expected F8, but got I4
		//IL_0b15: Expected Obj, but got I
		//IL_0b2a: Expected Obj, but got I
		//IL_0b40: Expected Obj, but got I
		//IL_0a6b: Expected Obj, but got I
		//IL_0a81: Expected Obj, but got I
		//IL_0a91: Expected F8, but got I
		//IL_0ba0: Expected Obj, but got I4
		//IL_0c18: Expected Obj, but got I
		//IL_0c28: Expected Obj, but got I
		//IL_0c3d: Expected VT, but got I
		//IL_0c53: Expected Obj, but got I4
		//IL_0c5c: Expected F8, but got I4
		//IL_0c65: Expected F8, but got I4
		//IL_0c75: Expected Obj, but got I
		//IL_0c8a: Expected Obj, but got I
		//IL_0ca0: Expected Obj, but got I
		//IL_0bcb: Expected Obj, but got I
		//IL_0be1: Expected Obj, but got I
		//IL_0bf1: Expected F8, but got I
		//IL_0d00: Expected Obj, but got I4
		//IL_0d78: Expected Obj, but got I
		//IL_0d88: Expected Obj, but got I
		//IL_0d9d: Expected VT, but got I
		//IL_0db3: Expected Obj, but got I4
		//IL_0dbc: Expected F8, but got I4
		//IL_0dc5: Expected F8, but got I4
		//IL_0d2b: Expected Obj, but got I
		//IL_0d41: Expected Obj, but got I
		//IL_0d51: Expected F8, but got I
		//IL_0dfb: Expected Obj, but got I
		//IL_0e46: Expected Obj, but got I
		//IL_0e5c: Expected Obj, but got I
		//IL_0ebc: Expected Obj, but got I4
		//IL_0f34: Expected Obj, but got I
		//IL_0f44: Expected Obj, but got I
		//IL_0f54: Expected F8, but got I
		//IL_0f69: Expected VT, but got I
		//IL_0f86: Expected Obj, but got I
		//IL_0f9b: Expected Obj, but got I
		//IL_0fb1: Expected Obj, but got I
		//IL_0ee7: Expected Obj, but got I
		//IL_0efd: Expected Obj, but got I
		//IL_0f0d: Expected F8, but got I
		//IL_1011: Expected Obj, but got I4
		//IL_1089: Expected Obj, but got I
		//IL_1099: Expected Obj, but got I
		//IL_10a9: Expected F8, but got I
		//IL_10be: Expected VT, but got I
		//IL_10db: Expected Obj, but got I
		//IL_10f0: Expected Obj, but got I
		//IL_1106: Expected Obj, but got I
		//IL_103c: Expected Obj, but got I
		//IL_1052: Expected Obj, but got I
		//IL_1062: Expected F8, but got I
		//IL_1166: Expected Obj, but got I4
		//IL_11de: Expected Obj, but got I
		//IL_11ee: Expected Obj, but got I
		//IL_11fe: Expected F8, but got I
		//IL_1213: Expected VT, but got I
		//IL_1247: Expected Obj, but got I
		//IL_1191: Expected Obj, but got I
		//IL_11a7: Expected Obj, but got I
		//IL_11b7: Expected F8, but got I
		//IL_128b: Expected Obj, but got I
		//IL_12b5: Expected Obj, but got I4
		//IL_12eb: Expected Obj, but got I
		//IL_131f: Expected Obj, but got I4
		//IL_13cf: Expected Obj, but got I4
		//IL_13df: Expected Obj, but got I4
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Expected Obj, but got Unknown
		//IL_1480: Expected Obj, but got I
		//IL_4c9f: Expected Obj, but got I4
		//IL_14b8: Expected Obj, but got I4
		//IL_14d6: Expected Obj, but got I
		//IL_14ee: Expected Obj, but got I
		//IL_14fe: Expected F8, but got I
		//IL_150e: Expected F8, but got I
		//IL_151e: Expected Obj, but got I
		//IL_152e: Expected F8, but got I
		//IL_157f: Expected Obj, but got I
		//IL_15b0: Expected Obj, but got I4
		//IL_15da: Expected Obj, but got I4
		//IL_15ea: Expected Obj, but got I4
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected Obj, but got Unknown
		//IL_16ee: Expected Obj, but got I
		//IL_1774: Expected Obj, but got I4
		//IL_17ff: Expected Obj, but got I
		//IL_180f: Expected Obj, but got I
		//IL_184b: Expected Obj, but got I
		//IL_1865: Expected Obj, but got I
		//IL_1794: Unknown result type (might be due to invalid IL or missing references)
		//IL_1799: Expected Obj, but got Unknown
		//IL_17c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c7: Expected Obj, but got Unknown
		//IL_1901: Expected Obj, but got I
		//IL_195c: Expected Obj, but got I
		//IL_19ce: Expected I, but got Obj
		//IL_19de: Expected Obj, but got I
		//IL_1a11: Expected Obj, but got I
		//IL_1a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5e: Expected Obj, but got Unknown
		//IL_1abe: Expected Obj, but got I
		//IL_1b12: Expected Obj, but got I
		//IL_1b4f: Expected Obj, but got I
		//IL_1b82: Expected Obj, but got I
		//IL_1bac: Expected Obj, but got I4
		//IL_1bd9: Expected Obj, but got I
		//IL_1c20: Expected Obj, but got I
		//IL_1c3d: Expected Obj, but got I
		//IL_1c69: Expected Obj, but got I
		//IL_1c95: Expected Obj, but got I
		//IL_1ccc: Expected Obj, but got I
		//IL_1d03: Expected Obj, but got I
		//IL_1d4e: Expected Obj, but got I
		//IL_1d88: Expected Obj, but got I
		//IL_1db7: Expected Obj, but got I
		//IL_1dd1: Expected Obj, but got I
		//IL_1dfc: Expected Obj, but got I
		//IL_1e14: Expected Obj, but got I
		//IL_1e24: Expected Obj, but got I
		//IL_1e34: Expected Obj, but got I
		//IL_1e44: Expected F8, but got I
		//IL_1e54: Expected F8, but got I
		//IL_1e64: Expected Obj, but got I
		//IL_1e82: Expected Obj, but got I
		//IL_1eda: Expected Obj, but got I4
		//IL_1f6a: Expected Obj, but got I
		//IL_1f7a: Expected Obj, but got I
		//IL_1f8f: Expected VT, but got I
		//IL_1f9f: Expected Obj, but got I
		//IL_4cdf: Expected Obj, but got I
		//IL_4cff: Expected Obj, but got I
		//IL_4d0f: Expected Obj, but got I
		//IL_4d1f: Expected F8, but got I
		//IL_4d2f: Expected F8, but got I
		//IL_4d3f: Expected Obj, but got I
		//IL_4d55: Expected Obj, but got I
		//IL_1efe: Expected Obj, but got I
		//IL_1f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f13: Expected Obj, but got Unknown
		//IL_1f29: Expected Obj, but got I
		//IL_1fcd: Expected Obj, but got I4
		//IL_205d: Expected Obj, but got I
		//IL_206d: Expected Obj, but got I
		//IL_2082: Expected VT, but got I
		//IL_2092: Expected Obj, but got I
		//IL_4d94: Expected Obj, but got I
		//IL_4db4: Expected Obj, but got I
		//IL_4dc4: Expected Obj, but got I
		//IL_4dd4: Expected F8, but got I
		//IL_4de4: Expected F8, but got I
		//IL_4df4: Expected Obj, but got I
		//IL_4e0a: Expected Obj, but got I
		//IL_1ff1: Expected Obj, but got I
		//IL_2001: Unknown result type (might be due to invalid IL or missing references)
		//IL_2006: Expected Obj, but got Unknown
		//IL_201c: Expected Obj, but got I
		//IL_20c0: Expected Obj, but got I4
		//IL_2150: Expected Obj, but got I
		//IL_2160: Expected Obj, but got I
		//IL_2175: Expected VT, but got I
		//IL_20e4: Expected Obj, but got I
		//IL_20f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f9: Expected Obj, but got Unknown
		//IL_210f: Expected Obj, but got I
		//IL_21a6: Expected Obj, but got I
		//IL_21cc: Expected Obj, but got I
		//IL_21ea: Expected Obj, but got I
		//IL_21fa: Expected Obj, but got I
		//IL_220a: Expected Obj, but got I
		//IL_2212: Expected F8, but got Obj
		//IL_2222: Expected F8, but got I
		//IL_2282: Expected Obj, but got I4
		//IL_22ef: Expected Obj, but got I
		//IL_22ff: Expected Obj, but got I
		//IL_2314: Expected VT, but got I
		//IL_2324: Expected Obj, but got I
		//IL_22ad: Expected Obj, but got I
		//IL_22c3: Expected Obj, but got I
		//IL_4e6b: Expected Obj, but got I
		//IL_4e89: Expected Obj, but got I
		//IL_4e99: Expected Obj, but got I
		//IL_4ea9: Expected Obj, but got I
		//IL_4eb9: Expected F8, but got I
		//IL_4ec9: Expected F8, but got I
		//IL_2357: Expected Obj, but got I4
		//IL_23cc: Expected Obj, but got I
		//IL_23dc: Expected Obj, but got I
		//IL_23f1: Expected VT, but got I
		//IL_2401: Expected Obj, but got I
		//IL_2382: Expected Obj, but got I
		//IL_2398: Expected Obj, but got I
		//IL_4f10: Expected Obj, but got I
		//IL_4f2e: Expected Obj, but got I
		//IL_4f3e: Expected Obj, but got I
		//IL_4f4e: Expected Obj, but got I
		//IL_4f5e: Expected F8, but got I
		//IL_4f6e: Expected F8, but got I
		//IL_2434: Expected Obj, but got I4
		//IL_24a9: Expected Obj, but got I
		//IL_24b9: Expected Obj, but got I
		//IL_24ce: Expected VT, but got I
		//IL_24f5: Expected Obj, but got I
		//IL_245f: Expected Obj, but got I
		//IL_2475: Expected Obj, but got I
		//IL_2514: Expected Obj, but got I
		//IL_255f: Expected Obj, but got I
		//IL_2575: Expected Obj, but got I
		//IL_25d5: Expected Obj, but got I4
		//IL_264d: Expected Obj, but got I
		//IL_265d: Expected Obj, but got I
		//IL_2672: Expected VT, but got I
		//IL_2688: Expected Obj, but got I4
		//IL_2691: Expected F8, but got I4
		//IL_269a: Expected F8, but got I4
		//IL_26aa: Expected Obj, but got I
		//IL_26bf: Expected Obj, but got I
		//IL_26d5: Expected Obj, but got I
		//IL_2600: Expected Obj, but got I
		//IL_2616: Expected Obj, but got I
		//IL_2626: Expected F8, but got I
		//IL_2735: Expected Obj, but got I4
		//IL_27ad: Expected Obj, but got I
		//IL_27bd: Expected Obj, but got I
		//IL_27d2: Expected VT, but got I
		//IL_27e8: Expected Obj, but got I4
		//IL_27f1: Expected F8, but got I4
		//IL_27fa: Expected F8, but got I4
		//IL_280a: Expected Obj, but got I
		//IL_281f: Expected Obj, but got I
		//IL_2835: Expected Obj, but got I
		//IL_2760: Expected Obj, but got I
		//IL_2776: Expected Obj, but got I
		//IL_2786: Expected F8, but got I
		//IL_2895: Expected Obj, but got I4
		//IL_290d: Expected Obj, but got I
		//IL_291d: Expected Obj, but got I
		//IL_2932: Expected VT, but got I
		//IL_2948: Expected Obj, but got I4
		//IL_2951: Expected F8, but got I4
		//IL_295a: Expected F8, but got I4
		//IL_28c0: Expected Obj, but got I
		//IL_28d6: Expected Obj, but got I
		//IL_28e6: Expected F8, but got I
		//IL_2990: Expected Obj, but got I
		//IL_29db: Expected Obj, but got I
		//IL_29f1: Expected Obj, but got I
		//IL_2a51: Expected Obj, but got I4
		//IL_2ac9: Expected Obj, but got I
		//IL_2ad9: Expected Obj, but got I
		//IL_2ae9: Expected F8, but got I
		//IL_2afe: Expected VT, but got I
		//IL_2b1b: Expected Obj, but got I
		//IL_2b30: Expected Obj, but got I
		//IL_2b46: Expected Obj, but got I
		//IL_2a7c: Expected Obj, but got I
		//IL_2a92: Expected Obj, but got I
		//IL_2aa2: Expected F8, but got I
		//IL_2ba6: Expected Obj, but got I4
		//IL_2c1e: Expected Obj, but got I
		//IL_2c2e: Expected Obj, but got I
		//IL_2c3e: Expected F8, but got I
		//IL_2c53: Expected VT, but got I
		//IL_2c70: Expected Obj, but got I
		//IL_2c85: Expected Obj, but got I
		//IL_2c9b: Expected Obj, but got I
		//IL_2bd1: Expected Obj, but got I
		//IL_2be7: Expected Obj, but got I
		//IL_2bf7: Expected F8, but got I
		//IL_2cfb: Expected Obj, but got I4
		//IL_2d73: Expected Obj, but got I
		//IL_2d83: Expected Obj, but got I
		//IL_2d93: Expected F8, but got I
		//IL_2da8: Expected VT, but got I
		//IL_2ddc: Expected Obj, but got I
		//IL_2d26: Expected Obj, but got I
		//IL_2d3c: Expected Obj, but got I
		//IL_2d4c: Expected F8, but got I
		//IL_2e29: Expected Obj, but got I
		//IL_2e5d: Expected Obj, but got I4
		//IL_2e87: Expected Obj, but got I4
		//IL_2e97: Expected Obj, but got I4
		//IL_2eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ebc: Expected Obj, but got Unknown
		//IL_2f69: Expected Obj, but got I
		//IL_2f99: Expected Obj, but got I
		//IL_4337: Expected Obj, but got I
		//IL_4361: Expected Obj, but got I4
		//IL_2fe1: Expected Obj, but got I
		//IL_3000: Expected Obj, but got I
		//IL_3029: Expected Obj, but got I
		//IL_43d5: Expected Obj, but got I4
		//IL_3047: Expected Obj, but got I
		//IL_305a: Unknown result type (might be due to invalid IL or missing references)
		//IL_305f: Expected Obj, but got Unknown
		//IL_30b0: Expected Obj, but got I
		//IL_4456: Expected Obj, but got I
		//IL_4491: Expected Obj, but got I4
		//IL_52c4: Expected Obj, but got I4
		//IL_3141: Expected Obj, but got I
		//IL_451a: Expected Obj, but got I
		//IL_4fb5: Expected Obj, but got I
		//IL_4fc5: Expected Obj, but got I
		//IL_4fd5: Expected Obj, but got I
		//IL_317e: Expected Obj, but got I
		//IL_318e: Expected Obj, but got I
		//IL_31a4: Expected Obj, but got I
		//IL_31b4: Expected F8, but got I
		//IL_31c4: Expected F8, but got I
		//IL_31d4: Expected Obj, but got I
		//IL_45c2: Expected Obj, but got I
		//IL_3234: Expected Obj, but got I4
		//IL_461b: Expected Obj, but got I
		//IL_32c4: Expected Obj, but got I
		//IL_32d4: Expected Obj, but got I
		//IL_32e9: Expected VT, but got I
		//IL_32f9: Expected Obj, but got I
		//IL_4652: Expected Obj, but got I
		//IL_5024: Expected Obj, but got I
		//IL_5034: Expected Obj, but got I
		//IL_5044: Expected F8, but got I
		//IL_5054: Expected F8, but got I
		//IL_5064: Expected Obj, but got I
		//IL_507a: Expected Obj, but got I
		//IL_3258: Expected Obj, but got I
		//IL_3268: Unknown result type (might be due to invalid IL or missing references)
		//IL_326d: Expected Obj, but got Unknown
		//IL_3283: Expected Obj, but got I
		//IL_3327: Expected Obj, but got I4
		//IL_46a4: Expected Obj, but got I
		//IL_46be: Expected Obj, but got I
		//IL_33b7: Expected Obj, but got I
		//IL_33c7: Expected Obj, but got I
		//IL_33dc: Expected VT, but got I
		//IL_33ec: Expected Obj, but got I
		//IL_50c9: Expected Obj, but got I
		//IL_50d9: Expected Obj, but got I
		//IL_50e9: Expected F8, but got I
		//IL_50f9: Expected F8, but got I
		//IL_5109: Expected Obj, but got I
		//IL_511f: Expected Obj, but got I
		//IL_334b: Expected Obj, but got I
		//IL_335b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3360: Expected Obj, but got Unknown
		//IL_3376: Expected Obj, but got I
		//IL_341a: Expected Obj, but got I4
		//IL_34aa: Expected Obj, but got I
		//IL_34ba: Expected Obj, but got I
		//IL_34cf: Expected VT, but got I
		//IL_4750: Expected Obj, but got I
		//IL_34e4: Expected Obj, but got I
		//IL_343e: Expected Obj, but got I
		//IL_344e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3453: Expected Obj, but got Unknown
		//IL_3469: Expected Obj, but got I
		//IL_3510: Expected Obj, but got I
		//IL_47ad: Expected Obj, but got I
		//IL_353e: Expected Obj, but got I
		//IL_354e: Expected Obj, but got I
		//IL_3564: Expected Obj, but got I
		//IL_356c: Expected F8, but got Obj
		//IL_357c: Expected F8, but got I
		//IL_35dc: Expected Obj, but got I4
		//IL_3649: Expected Obj, but got I
		//IL_3659: Expected Obj, but got I
		//IL_366e: Expected VT, but got I
		//IL_367e: Expected Obj, but got I
		//IL_3607: Expected Obj, but got I
		//IL_361d: Expected Obj, but got I
		//IL_5188: Expected Obj, but got I
		//IL_5198: Expected Obj, but got I
		//IL_51ae: Expected Obj, but got I
		//IL_51be: Expected F8, but got I
		//IL_51ce: Expected F8, but got I
		//IL_36b1: Expected Obj, but got I4
		//IL_3726: Expected Obj, but got I
		//IL_3736: Expected Obj, but got I
		//IL_374b: Expected VT, but got I
		//IL_375b: Expected Obj, but got I
		//IL_48ba: Expected Obj, but got I
		//IL_48ca: Expected Obj, but got I
		//IL_48de: Expected Obj, but got I8
		//IL_48e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_48ee: Expected Obj, but got Unknown
		//IL_490b: Expected Obj, but got I4
		//IL_36dc: Expected Obj, but got I
		//IL_36f2: Expected Obj, but got I
		//IL_52eb: Expected Obj, but got I4
		//IL_521d: Expected Obj, but got I
		//IL_522d: Expected Obj, but got I
		//IL_5243: Expected Obj, but got I
		//IL_5253: Expected F8, but got I
		//IL_5263: Expected F8, but got I
		//IL_492a: Expected Obj, but got I
		//IL_378e: Expected Obj, but got I4
		//IL_4957: Expected Obj, but got I
		//IL_4961: Expected Obj, but got I4
		//IL_496a: Unknown result type (might be due to invalid IL or missing references)
		//IL_496f: Expected Obj, but got Unknown
		//IL_498f: Expected Obj, but got I
		//IL_3803: Expected Obj, but got I
		//IL_3813: Expected Obj, but got I
		//IL_3828: Expected VT, but got I
		//IL_384f: Expected Obj, but got I
		//IL_37b9: Expected Obj, but got I
		//IL_37cf: Expected Obj, but got I
		//IL_386e: Expected Obj, but got I
		//IL_38b9: Expected Obj, but got I
		//IL_38cf: Expected Obj, but got I
		//IL_392f: Expected Obj, but got I4
		//IL_39a7: Expected Obj, but got I
		//IL_39b7: Expected Obj, but got I
		//IL_39cc: Expected VT, but got I
		//IL_39e2: Expected Obj, but got I4
		//IL_39eb: Expected F8, but got I4
		//IL_39f4: Expected F8, but got I4
		//IL_3a04: Expected Obj, but got I
		//IL_3a19: Expected Obj, but got I
		//IL_3a2f: Expected Obj, but got I
		//IL_395a: Expected Obj, but got I
		//IL_3970: Expected Obj, but got I
		//IL_3980: Expected F8, but got I
		//IL_3a8f: Expected Obj, but got I4
		//IL_3b07: Expected Obj, but got I
		//IL_3b17: Expected Obj, but got I
		//IL_3b2c: Expected VT, but got I
		//IL_3b42: Expected Obj, but got I4
		//IL_3b4b: Expected F8, but got I4
		//IL_3b54: Expected F8, but got I4
		//IL_3b64: Expected Obj, but got I
		//IL_3b79: Expected Obj, but got I
		//IL_3b8f: Expected Obj, but got I
		//IL_3aba: Expected Obj, but got I
		//IL_3ad0: Expected Obj, but got I
		//IL_3ae0: Expected F8, but got I
		//IL_3bef: Expected Obj, but got I4
		//IL_3c67: Expected Obj, but got I
		//IL_3c77: Expected Obj, but got I
		//IL_3c8c: Expected VT, but got I
		//IL_3ca2: Expected Obj, but got I4
		//IL_3cab: Expected F8, but got I4
		//IL_3cb4: Expected F8, but got I4
		//IL_3c1a: Expected Obj, but got I
		//IL_3c30: Expected Obj, but got I
		//IL_3c40: Expected F8, but got I
		//IL_3cea: Expected Obj, but got I
		//IL_3d35: Expected Obj, but got I
		//IL_3d4b: Expected Obj, but got I
		//IL_3dab: Expected Obj, but got I4
		//IL_3e23: Expected Obj, but got I
		//IL_3e33: Expected Obj, but got I
		//IL_3e43: Expected F8, but got I
		//IL_3e58: Expected VT, but got I
		//IL_3e75: Expected Obj, but got I
		//IL_3e8a: Expected Obj, but got I
		//IL_3ea0: Expected Obj, but got I
		//IL_3dd6: Expected Obj, but got I
		//IL_3dec: Expected Obj, but got I
		//IL_3dfc: Expected F8, but got I
		//IL_3f00: Expected Obj, but got I4
		//IL_3f78: Expected Obj, but got I
		//IL_3f88: Expected Obj, but got I
		//IL_3f98: Expected F8, but got I
		//IL_3fad: Expected VT, but got I
		//IL_3fca: Expected Obj, but got I
		//IL_3fdf: Expected Obj, but got I
		//IL_3ff5: Expected Obj, but got I
		//IL_3f2b: Expected Obj, but got I
		//IL_3f41: Expected Obj, but got I
		//IL_3f51: Expected F8, but got I
		//IL_4055: Expected Obj, but got I4
		//IL_40cd: Expected Obj, but got I
		//IL_40dd: Expected Obj, but got I
		//IL_40ed: Expected F8, but got I
		//IL_4102: Expected VT, but got I
		//IL_4136: Expected Obj, but got I
		//IL_4080: Expected Obj, but got I
		//IL_4096: Expected Obj, but got I
		//IL_40a6: Expected F8, but got I
		//IL_417a: Expected Obj, but got I
		//IL_41a9: Expected Obj, but got I4
		//IL_41d3: Expected Obj, but got I4
		//IL_41e3: Expected Obj, but got I4
		//IL_4203: Unknown result type (might be due to invalid IL or missing references)
		//IL_4208: Expected Obj, but got Unknown
		//IL_42b5: Expected Obj, but got I
		//IL_42ec: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		bool flag4 = (object)obj6 == null;
		List<Vector2> list = null;
		UnityEngine.Object obj8 = null;
		Transform transform3;
		IndexOutOfRangeException ex = default;
		if (!flag4)
		{
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (UnityEngine.Object)+48]");
			bool flag6 = (UnityEngine.Object)0 == null;
			bool flag7 = !flag6;
			object obj11 = !flag7;
			if (obj11 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (UnityEngine.Object)+48]");
			Material material = default;
			material._002Ector((Material)0);
			bool flag8 = (object)material == null;
			list = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (UnityEngine.Object)+48]");
			obj8 = (UnityEngine.Object)0;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5D0]");
				object obj13 = (material.name = (string)0);
				object obj14 = this + 72;
				obj14 = material;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool flag9 = obj14 == null;
				list = null;
				obj8 = material;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76C0]");
					object obj15 = 0;
					((Material)obj14).SetFloat((string)obj15, 1f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Vector3[] array = default;
					bool flag10 = array == null;
					double num = 1.0;
					list = null;
					obj8 = (UnityEngine.Object)3;
					if (!flag10)
					{
						bool flag11 = array.Length == 0;
						num = 1.0;
						list = null;
						obj8 = (UnityEngine.Object)3;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							object obj17 = 0;
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1491 @ X9_v6+A0]");
							object obj19 = 0;
							num = (double)obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1492 @ X9_v7+8]");
							double num2 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1492 @ X9_v7+8]");
							_ = 0;
							object obj20 = array.Length & 0xFFFFFFFEL;
							bool flag12 = obj20 == null;
							list = null;
							obj8 = (UnityEngine.Object)3;
							if (!flag12)
							{
								object obj21 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ X9_v9+A0]");
								object obj22 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X9_v10+18]");
								num = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X9_v10+20]");
								num2 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X9_v10+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1507 @ X9_v10+20]");
								_ = 0;
								bool flag13 = array.Length < 2;
								object obj23 = !flag13;
								object obj24 = array.Length - 2;
								bool flag14 = obj24 == null;
								object obj25 = ~obj23;
								object obj26 = obj25 | flag14;
								list = null;
								obj8 = (UnityEngine.Object)3;
								if (obj26 == null)
								{
									object obj27 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ X8_v18+A0]");
									object obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ X8_v19+3C]");
									num = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ X8_v19+44]");
									num2 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ X8_v19+3C]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ X8_v19+44]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									Mesh mesh = default;
									mesh._002Ector();
									bool flag15 = (object)mesh == null;
									list = null;
									obj8 = null;
									if (!flag15)
									{
										mesh.name = (string)obj13;
										mesh.SetVertices(array);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
										Vector3[] array2 = default;
										bool flag16 = array2 == null;
										list = null;
										obj8 = (UnityEngine.Object)3;
										if (!flag16)
										{
											bool flag17 = array2.Length == 0;
											list = null;
											obj8 = (UnityEngine.Object)3;
											if (!flag17)
											{
												object obj30 = obj17;
												object obj31 = array2.Length & 0xFFFFFFFEL;
												bool flag18 = obj31 == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1567 @ X9_v12+A0]");
												object obj32 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X9_v13+54]");
												num = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X9_v13+5C]");
												num2 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X9_v13+54]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X9_v13+5C]");
												_ = 0;
												list = null;
												obj8 = (UnityEngine.Object)3;
												if (!flag18)
												{
													object obj33 = obj17;
													bool flag19 = array2.Length < 2;
													object obj34 = !flag19;
													object obj35 = array2.Length - 2;
													bool flag20 = obj35 == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1571 @ X9_v14+A0]");
													object obj36 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X9_v15+54]");
													num = 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X9_v15+5C]");
													num2 = 0.0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X9_v15+54]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X9_v15+5C]");
													_ = 0;
													object obj37 = ~obj34;
													object obj38 = obj37 | flag20;
													list = null;
													obj8 = (UnityEngine.Object)3;
													if (obj38 == null)
													{
														object obj39 = obj17;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ X8_v25+A0]");
														object obj40 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1580 @ X8_v26+54]");
														num = 0.0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1580 @ X8_v26+5C]");
														num2 = 0.0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1580 @ X8_v26+54]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1580 @ X8_v26+5C]");
														_ = 0;
														mesh.SetNormals(array2);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
														object obj41 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
														object obj42 = 0;
														obj8 = (UnityEngine.Object)obj42;
														List<Vector2> list2 = default;
														list2._002Ector();
														bool flag21 = (object)list2 == null;
														list = null;
														if (!flag21)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
															object obj43 = 0;
															object obj44 = obj43;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1610 @ X8_v31+A0]");
															object obj45 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C69C0]");
															object obj46 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
															object obj47 = 0;
															num = (double)obj45;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1611 @ X9_v16+4]");
															num2 = 0.0;
															object obj48 = obj46;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
															object obj49 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
															bool flag22 = (nint)0 == 0;
															list = null;
															if (!flag22)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																nint num3 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ X8_v32+18]");
																bool flag23 = num3 < 0;
																object obj50 = !flag23;
																if (obj50 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																	nint num4 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																	object obj51 = num4 + 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																	object obj52 = (nint)0 + (nint)1;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1611 @ X9_v16+4]");
																	_ = 0;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X9_v17+20]");
																	object obj53 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ X8_v418+A8]");
																	object obj54 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X8_v419+70]");
																	list2.AddWithResize((Vector2)0);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ X8_v419+70]");
																	obj8 = (UnityEngine.Object)0;
																}
																object obj55 = obj43;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1644 @ X8_v36+A0]");
																object obj56 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																object obj57 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																object obj58 = (nint)0 + (nint)1;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X9_v19+10]");
																num = 0.0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X9_v19+14]");
																num2 = 0.0;
																object obj59 = obj46;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																bool flag24 = (nint)0 == 0;
																list = null;
																if (!flag24)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																	nint num5 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v37+18]");
																	bool flag25 = num5 < 0;
																	object obj60 = !flag25;
																	if (obj60 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																		nint num6 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																		object obj61 = num6 + 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																		object obj62 = (nint)0 + (nint)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X9_v19+10]");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ X9_v19+14]");
																		_ = 0;
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ X9_v20+20]");
																		object obj63 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1657 @ X8_v414+A8]");
																		object obj64 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1659 @ X8_v415+70]");
																		list2.AddWithResize((Vector2)0);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1659 @ X8_v415+70]");
																		obj8 = (UnityEngine.Object)0;
																	}
																	object obj65 = obj43;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1674 @ X8_v41+A0]");
																	object obj66 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																	object obj67 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																	object obj68 = (nint)0 + (nint)1;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ X9_v22+28]");
																	num = 0.0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ X9_v22+2C]");
																	num2 = 0.0;
																	object obj69 = obj46;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																	bool flag26 = (nint)0 == 0;
																	list = null;
																	if (!flag26)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																		nint num7 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X8_v42+18]");
																		bool flag27 = num7 < 0;
																		object obj70 = !flag27;
																		if (obj70 == null)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																			nint num8 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																			object obj71 = num8 + 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ X0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																			object obj72 = (nint)0 + (nint)1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ X9_v22+28]");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1676 @ X9_v22+2C]");
																			_ = 0;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X9_v23+20]");
																			object obj73 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1680 @ X8_v410+A8]");
																			object obj74 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1682 @ X8_v411+70]");
																			list2.AddWithResize((Vector2)0);
																		}
																		mesh.SetUVs(0, list2);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
																		object obj75 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CC8]");
																		object obj76 = 0;
																		obj8 = (UnityEngine.Object)obj76;
																		List<Vector4> list3 = default;
																		list3._002Ector();
																		bool flag28 = (object)list3 == null;
																		Material material2 = null;
																		list = list2;
																		if (!flag28)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																			object obj77 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																			object obj78 = (nint)0 + (nint)1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																			bool flag29 = (nint)0 == 0;
																			material2 = null;
																			list = list2;
																			if (!flag29)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																				nint num9 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v48+18]");
																				bool flag30 = num9 < 0;
																				object obj79 = !flag30;
																				if (obj79 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																					nint num10 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																					object obj80 = num10 + 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																					object obj81 = (nint)0 + (nint)1;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																					num = 0.0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																					_ = 0;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																					object obj82 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1702 @ X8_v407+A8]");
																					object obj83 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1708 @ X8_v408+70]");
																					list3.AddWithResize((Vector4)0);
																					double num11 = 1.0;
																					object obj84 = 0;
																					num2 = 0.0;
																					num = 0.0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1708 @ X8_v408+70]");
																					obj8 = (UnityEngine.Object)0;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																				object obj85 = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																				object obj86 = (nint)0 + (nint)1;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																				bool flag31 = (nint)0 == 0;
																				material2 = null;
																				list = list2;
																				if (!flag31)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																					nint num12 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ X8_v50+18]");
																					bool flag32 = num12 < 0;
																					object obj87 = !flag32;
																					if (obj87 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																						nint num13 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																						object obj88 = num13 + 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																						object obj89 = (nint)0 + (nint)1;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																						num = 0.0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																						_ = 0;
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																						object obj90 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1720 @ X8_v404+A8]");
																						object obj91 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1726 @ X8_v405+70]");
																						list3.AddWithResize((Vector4)0);
																						double num11 = 1.0;
																						object obj84 = 0;
																						num2 = 0.0;
																						num = 0.0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1726 @ X8_v405+70]");
																						obj8 = (UnityEngine.Object)0;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																					object obj92 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																					object obj93 = (nint)0 + (nint)1;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																					bool flag33 = (nint)0 == 0;
																					material2 = null;
																					list = list2;
																					if (!flag33)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																						nint num14 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ X8_v52+18]");
																						bool flag34 = num14 < 0;
																						object obj94 = !flag34;
																						if (obj94 == null)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																							nint num15 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																							object obj95 = num15 + 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ X0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																							object obj96 = (nint)0 + (nint)1;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																							num = 0.0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																							_ = 0;
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																							object obj97 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1737 @ X8_v401+A8]");
																							object obj98 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1743 @ X8_v402+70]");
																							list3.AddWithResize((Vector4)0);
																							double num11 = 1.0;
																							object obj84 = 0;
																							num2 = 0.0;
																							num = 0.0;
																						}
																						mesh.SetUVs(1, list3);
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
																						object obj99 = 0;
																						obj8 = (UnityEngine.Object)obj99;
																						List<Vector2> list4 = default;
																						list4._002Ector();
																						bool flag35 = (object)list4 == null;
																						material2 = null;
																						list = (List<Vector2>)(object)list3;
																						if (!flag35)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																							object obj100 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																							object obj101 = (nint)0 + (nint)1;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																							bool flag36 = (nint)0 == 0;
																							material2 = null;
																							list = (List<Vector2>)(object)list3;
																							if (!flag36)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																								nint num16 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v56+18]");
																								bool flag37 = num16 < 0;
																								object obj102 = !flag37;
																								if (obj102 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																									nint num17 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																									object obj103 = num17 + 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																									object obj104 = (nint)0 + (nint)1;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																									num = 0.0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																									_ = 0;
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																									object obj105 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1760 @ X8_v397+A8]");
																									object obj106 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																									num = 0.0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1763 @ X8_v398+70]");
																									list4.AddWithResize((Vector2)0);
																									num2 = 1.0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1763 @ X8_v398+70]");
																									obj8 = (UnityEngine.Object)0;
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																								object obj107 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																								object obj108 = (nint)0 + (nint)1;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																								bool flag38 = (nint)0 == 0;
																								material2 = null;
																								list = (List<Vector2>)(object)list3;
																								if (!flag38)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																									nint num18 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v58+18]");
																									bool flag39 = num18 < 0;
																									object obj109 = !flag39;
																									if (obj109 == null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																										nint num19 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																										object obj110 = num19 + 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																										object obj111 = (nint)0 + (nint)1;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																										num = 0.0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																										_ = 0;
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																										object obj112 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ X8_v393+A8]");
																										object obj113 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																										num = 0.0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1780 @ X8_v394+70]");
																										list4.AddWithResize((Vector2)0);
																										num2 = 1.0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1780 @ X8_v394+70]");
																										obj8 = (UnityEngine.Object)0;
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																									object obj114 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																									object obj115 = (nint)0 + (nint)1;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																									bool flag40 = (nint)0 == 0;
																									material2 = null;
																									list = (List<Vector2>)(object)list3;
																									if (!flag40)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																										nint num20 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X8_v60+18]");
																										bool flag41 = num20 < 0;
																										object obj116 = !flag41;
																										if (obj116 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																											nint num21 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																											object obj117 = num21 + 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v54 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																											object obj118 = (nint)0 + (nint)1;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																											num = 0.0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																											_ = 0;
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																											object obj119 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1793 @ X8_v389+A8]");
																											object obj120 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																											num = 0.0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ X8_v390+70]");
																											list4.AddWithResize((Vector2)0);
																											num2 = 1.0;
																										}
																										mesh.SetUVs(2, list4);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																										object obj121 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																										List<Vector3> list5 = default;
																										list5._002Ector((IEnumerable<Vector3>)array);
																										mesh.SetUVs(3, list5);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6768]");
																										object obj122 = 0;
																										object obj123 = obj122;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ X0_v62+E4]");
																										bool flag42 = (nint)0 == 0;
																										object obj124 = !flag42;
																										if (obj124 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																										}
																										GillaRip.FleshChannels(mesh);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F8]");
																										object obj125 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																										BoneWeight[] array3 = default;
																										bool flag43 = array3 == null;
																										material2 = null;
																										list = (List<Vector2>)(object)list5;
																										obj8 = (UnityEngine.Object)3;
																										if (!flag43)
																										{
																											bool flag44 = array3.Length == 0;
																											material2 = null;
																											list = (List<Vector2>)(object)list5;
																											obj8 = (UnityEngine.Object)(object)array3;
																											if (!flag44)
																											{
																												bool flag45 = array3.Length == 1;
																												_ = 0;
																												_ = 1065353216;
																												_ = 0;
																												_ = 0;
																												_ = 0;
																												material2 = null;
																												list = (List<Vector2>)(object)list5;
																												obj8 = (UnityEngine.Object)(object)array3;
																												if (!flag45)
																												{
																													bool flag46 = array3.Length < 2;
																													object obj126 = !flag46;
																													object obj127 = array3.Length - 2;
																													bool flag47 = obj127 == null;
																													_ = 1065353216;
																													_ = 0;
																													_ = 0;
																													_ = 0;
																													_ = 0;
																													object obj128 = ~obj126;
																													object obj129 = obj128 | flag47;
																													material2 = null;
																													list = (List<Vector2>)(object)list5;
																													obj8 = (UnityEngine.Object)(object)array3;
																													if (obj129 == null)
																													{
																														_ = 0;
																														_ = 1065353216;
																														_ = 0;
																														_ = 0;
																														_ = 0;
																														mesh.boneWeights = array3;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
																														object obj130 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																														Matrix4x4[] array4 = default;
																														bool flag48 = array4 == null;
																														material2 = null;
																														list = null;
																														obj8 = (UnityEngine.Object)1;
																														if (flag48)
																														{
																															goto IL_49ae;
																														}
																														bool flag49 = array4.Length == 0;
																														material2 = null;
																														list = null;
																														obj8 = (UnityEngine.Object)1;
																														if (!flag49)
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
																															object obj131 = 0;
																															object obj132 = obj131;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1847 @ X8_v79+A0]");
																															object obj133 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+60]");
																															num2 = 0.0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+70]");
																															num = 0.0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+40]");
																															object obj84 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+50]");
																															double num11 = 0.0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+60]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+70]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+40]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X8_v80+50]");
																															_ = 0;
																															mesh.bindposes = array4;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
																															object obj134 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																															int[] array5 = default;
																															bool flag50 = array5 == null;
																															material2 = null;
																															list = null;
																															obj8 = (UnityEngine.Object)3;
																															if (flag50)
																															{
																																goto IL_49ae;
																															}
																															bool flag51 = array5.Length < 1;
																															object obj135 = !flag51;
																															object obj136 = array5.Length - 1;
																															bool flag52 = obj136 == null;
																															object obj137 = ~obj135;
																															object obj138 = obj137 | flag52;
																															material2 = null;
																															list = null;
																															obj8 = (UnityEngine.Object)(object)array5;
																															if (obj138 == null)
																															{
																																bool flag53 = array5.Length == 2;
																																array5[1] = 1;
																																material2 = null;
																																list = null;
																																obj8 = (UnityEngine.Object)(object)array5;
																																if (!flag53)
																																{
																																	array5[2] = 2;
																																	mesh.SetTriangles(array5, 0);
																																	mesh.RecalculateBounds();
																																	List<System.__Canon> list6 = (List<System.__Canon>)(object)baked;
																																	bool flag54 = (object)baked == null;
																																	material2 = null;
																																	list = null;
																																	obj8 = null;
																																	if (!flag54)
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
																																		object obj139 = 0;
																																		System.__Canon[] items = list6._items;
																																		object obj140 = obj139;
																																		int version = list6._version + 1;
																																		list6._version = version;
																																		bool flag55 = list6._items == null;
																																		material2 = null;
																																		list = null;
																																		obj8 = null;
																																		if (!flag55)
																																		{
																																			bool flag56 = list6._size < items.Length;
																																			object obj141 = !flag56;
																																			if (obj141 == null)
																																			{
																																				object obj142 = list6._items + list6._size;
																																				int size = list6._size + 1;
																																				list6._size = size;
																																				object obj143 = obj142 + 32;
																																				obj143 = mesh;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																				int num22 = 0;
																																				System.__Canon _Canon = (System.__Canon)(object)mesh;
																																			}
																																			else
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X9_v41+20]");
																																				object obj144 = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1866 @ X8_v385+A8]");
																																				object obj145 = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1868 @ X8_v386+70]");
																																				int num22 = 0;
																																				((List<System.__Canon>)(object)baked).AddWithResize((System.__Canon)(object)mesh);
																																				System.__Canon _Canon = (System.__Canon)(object)mesh;
																																			}
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
																																			object obj146 = 0;
																																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA638]");
																																			object obj147 = 0;
																																			GameObject gameObject = default;
																																			gameObject._002Ector((string)obj147);
																																			bool flag57 = (object)gameObject == null;
																																			material2 = null;
																																			list = null;
																																			obj8 = (UnityEngine.Object)obj147;
																																			if (!flag57)
																																			{
																																				Transform transform = gameObject.transform;
																																				bool flag58 = (object)transform == null;
																																				material2 = null;
																																				list = null;
																																				obj8 = null;
																																				if (!flag58)
																																				{
																																					transform.SetParent(under, worldPositionStays: false);
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
																																					object obj148 = 0;
																																					obj8 = (UnityEngine.Object)obj148;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
																																					SkinnedMeshRenderer skinnedMeshRenderer = default;
																																					bool flag59 = (object)skinnedMeshRenderer == null;
																																					material2 = null;
																																					list = null;
																																					if (!flag59)
																																					{
																																						skinnedMeshRenderer.sharedMesh = mesh;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
																																						object obj149 = 0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																						Transform transform2 = gameObject.transform;
																																						Transform[] array6 = default;
																																						bool flag60 = array6 == null;
																																						material2 = null;
																																						list = null;
																																						obj8 = null;
																																						if (!flag60)
																																						{
																																							bool flag61 = (object)transform2 == null;
																																							UnityEngine.Object obj150 = null;
																																							if (!flag61)
																																							{
																																								nint num23 = (nint)array6;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1431 @ X8_v384 (Il2CppClass<UnityEngine.Transform[]>)+40]");
																																								obj150 = (UnityEngine.Object)0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																																								bool flag62 = ex == null;
																																								material2 = null;
																																								list = null;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1431 @ X8_v384 (Il2CppClass<UnityEngine.Transform[]>)+40]");
																																								obj8 = (UnityEngine.Object)0;
																																								if (flag62)
																																								{
																																									goto IL_49ca;
																																								}
																																							}
																																							bool flag63 = array6.Length == 0;
																																							material2 = null;
																																							list = null;
																																							obj8 = obj150;
																																							if (flag63)
																																							{
																																								goto IL_49bc;
																																							}
																																							object obj151 = array6 + 32;
																																							obj151 = transform2;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																							skinnedMeshRenderer.bones = array6;
																																							Transform rootBone = gameObject.transform;
																																							skinnedMeshRenderer.rootBone = rootBone;
																																							skinnedMeshRenderer.sharedMaterial = (Material)obj14;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
																																							object obj152 = 0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																							Mesh mesh2 = default;
																																							mesh2._002Ector();
																																							bool flag64 = (object)mesh2 == null;
																																							material2 = null;
																																							list = null;
																																							obj8 = null;
																																							if (!flag64)
																																							{
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA630]");
																																								object obj153 = 0;
																																								mesh2.name = (string)obj153;
																																								skinnedMeshRenderer.BakeMesh(mesh2, useScale: false);
																																								GillaRip.FleshChannels(mesh2);
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5B0]");
																																								object obj154 = 0;
																																								material2 = fleshMat;
																																								Plain((string)obj154, mesh2, fleshMat);
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																																								object obj155 = 0;
																																								object obj156 = obj155;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1926 @ X0_v103+E4]");
																																								bool flag65 = (nint)0 == 0;
																																								object obj157 = !flag65;
																																								if (obj157 == null)
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																																								}
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4BB8]");
																																								object obj158 = 0;
																																								obj8 = (UnityEngine.Object)obj158;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDA38");
																																								UnityEngine.Object obj159 = default;
																																								bool flag66 = (object)obj159 == null;
																																								list = (List<Vector2>)(object)mesh2;
																																								if (!flag66)
																																								{
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5D8]");
																																									object obj160 = 0;
																																									obj159.name = (string)obj160;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
																																									object obj161 = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																									Matrix4x4[] bindposes = default;
																																									((Mesh)obj159).bindposes = bindposes;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F8]");
																																									object obj162 = 0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																									BoneWeight[] boneWeights = default;
																																									((Mesh)obj159).boneWeights = boneWeights;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA600]");
																																									object obj163 = 0;
																																									Plain((string)obj163, (Mesh)obj159, fleshMat);
																																									Mesh mesh3 = Four((Mesh)obj159);
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA610]");
																																									object obj164 = 0;
																																									Plain((string)obj164, mesh3, fleshMat);
																																									Mesh mesh4 = Four(mesh2);
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA618]");
																																									object obj165 = 0;
																																									material2 = fleshMat;
																																									Plain((string)obj165, mesh4, fleshMat);
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																									Mesh mesh5 = default;
																																									mesh5._002Ector();
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
																																									object obj166 = 0;
																																									bool flag67 = (object)mesh5 == null;
																																									list = (List<Vector2>)(object)mesh4;
																																									obj8 = null;
																																									if (!flag67)
																																									{
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA620]");
																																										object obj167 = 0;
																																										mesh5.name = (string)obj167;
																																										mesh5.SetVertices(array);
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																																										object obj168 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
																																										object obj169 = 0;
																																										obj8 = (UnityEngine.Object)obj169;
																																										List<Vector3> list7 = default;
																																										list7._002Ector();
																																										bool flag68 = list7 == null;
																																										list = null;
																																										if (!flag68)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																																											object obj170 = 0;
																																											object obj171 = obj170;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2001 @ X8_v127+A0]");
																																											object obj172 = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
																																											object obj173 = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																											object obj174 = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X9_v44+54]");
																																											num = 0.0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X9_v44+58]");
																																											num2 = 0.0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X9_v44+5C]");
																																											obj84 = 0;
																																											object obj175 = obj173;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																																											object obj176 = (nint)0 + (nint)1;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																											bool flag69 = (nint)0 == 0;
																																											list = null;
																																											if (!flag69)
																																											{
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																												nint num24 = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ X8_v128+18]");
																																												bool flag70 = num24 < 0;
																																												object obj177 = !flag70;
																																												if (obj177 == null)
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																													object obj178 = (nint)0 * (nint)12;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																													object obj179 = 0 + obj178;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																													object obj180 = (nint)0 + (nint)1;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X9_v44+54]");
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X9_v44+58]");
																																													_ = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2002 @ X9_v44+5C]");
																																													_ = 0;
																																												}
																																												else
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X9_v45+20]");
																																													object obj181 = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ X8_v377+A8]");
																																													object obj182 = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2013 @ X8_v378+70]");
																																													list7.AddWithResize((Vector3)0);
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2013 @ X8_v378+70]");
																																													obj8 = (UnityEngine.Object)0;
																																												}
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																																												object obj183 = 0;
																																												object obj184 = obj173;
																																												object obj185 = obj183;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ X8_v132+A0]");
																																												object obj186 = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																												object obj187 = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ X9_v47+54]");
																																												num = 0.0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ X9_v47+58]");
																																												num2 = 0.0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ X9_v47+5C]");
																																												obj84 = 0;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																																												object obj188 = (nint)0 + (nint)1;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																												bool flag71 = (nint)0 == 0;
																																												list = null;
																																												if (!flag71)
																																												{
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																													nint num25 = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v133+18]");
																																													bool flag72 = num25 < 0;
																																													object obj189 = !flag72;
																																													if (obj189 == null)
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																														object obj190 = (nint)0 * (nint)12;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																														object obj191 = 0 + obj190;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																														object obj192 = (nint)0 + (nint)1;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ X9_v47+54]");
																																														_ = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ X9_v47+58]");
																																														_ = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ X9_v47+5C]");
																																														_ = 0;
																																													}
																																													else
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X10_v40+20]");
																																														object obj193 = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2038 @ X8_v371+A8]");
																																														object obj194 = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ X8_v372+70]");
																																														list7.AddWithResize((Vector3)0);
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2040 @ X8_v372+70]");
																																														obj8 = (UnityEngine.Object)0;
																																													}
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																																													object obj195 = 0;
																																													object obj196 = obj173;
																																													object obj197 = obj195;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ X8_v137+A0]");
																																													object obj198 = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																													object obj199 = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X9_v51+54]");
																																													num = 0.0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X9_v51+58]");
																																													num2 = 0.0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X9_v51+5C]");
																																													obj84 = 0;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																																													object obj200 = (nint)0 + (nint)1;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																													bool flag73 = (nint)0 == 0;
																																													list = null;
																																													if (!flag73)
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																														nint num26 = 0;
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v138+18]");
																																														bool flag74 = num26 < 0;
																																														object obj201 = !flag74;
																																														if (obj201 == null)
																																														{
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																															object obj202 = (nint)0 * (nint)12;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																															object obj203 = 0 + obj202;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ X0_v125 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																															object obj204 = (nint)0 + (nint)1;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X9_v51+54]");
																																															_ = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X9_v51+58]");
																																															_ = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2054 @ X9_v51+5C]");
																																															_ = 0;
																																														}
																																														else
																																														{
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X10_v42+20]");
																																															object obj205 = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2065 @ X8_v368+A8]");
																																															object obj206 = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2067 @ X8_v369+70]");
																																															list7.AddWithResize((Vector3)0);
																																														}
																																														mesh5.SetNormals(list7);
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
																																														object obj207 = 0;
																																														obj8 = (UnityEngine.Object)obj207;
																																														List<Vector2> list8 = default;
																																														list8._002Ector();
																																														bool flag75 = (object)list8 == null;
																																														list = null;
																																														if (!flag75)
																																														{
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
																																															object obj208 = 0;
																																															object obj209 = obj208;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																															object obj210 = (nint)0 + (nint)1;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2092 @ X8_v147+A0]");
																																															object obj211 = 0;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																															object obj212 = 0;
																																															num = (double)obj211;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X9_v56+4]");
																																															num2 = 0.0;
																																															object obj213 = obj46;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																															bool flag76 = (nint)0 == 0;
																																															list = null;
																																															if (!flag76)
																																															{
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																nint num27 = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1136 @ X8_v148+18]");
																																																bool flag77 = num27 < 0;
																																																object obj214 = !flag77;
																																																if (obj214 == null)
																																																{
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																	nint num28 = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																	object obj215 = num28 + 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																	object obj216 = (nint)0 + (nint)1;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X9_v56+4]");
																																																	_ = 0;
																																																}
																																																else
																																																{
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X9_v57+20]");
																																																	object obj217 = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2098 @ X8_v364+A8]");
																																																	object obj218 = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2100 @ X8_v365+70]");
																																																	list8.AddWithResize((Vector2)0);
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2100 @ X8_v365+70]");
																																																	obj8 = (UnityEngine.Object)0;
																																																}
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
																																																object obj219 = 0;
																																																object obj220 = obj219;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																object obj221 = (nint)0 + (nint)1;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2119 @ X8_v155+A0]");
																																																object obj222 = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																object obj223 = 0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2120 @ X9_v60+10]");
																																																num = 0.0;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2120 @ X9_v60+14]");
																																																num2 = 0.0;
																																																object obj224 = obj46;
																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																bool flag78 = (nint)0 == 0;
																																																list = null;
																																																if (!flag78)
																																																{
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																	nint num29 = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v156+18]");
																																																	bool flag79 = num29 < 0;
																																																	object obj225 = !flag79;
																																																	if (obj225 == null)
																																																	{
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																		nint num30 = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																		object obj226 = num30 + 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																		object obj227 = (nint)0 + (nint)1;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2120 @ X9_v60+10]");
																																																		_ = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2120 @ X9_v60+14]");
																																																		_ = 0;
																																																	}
																																																	else
																																																	{
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ X9_v61+20]");
																																																		object obj228 = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2125 @ X8_v360+A8]");
																																																		object obj229 = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X8_v361+70]");
																																																		list8.AddWithResize((Vector2)0);
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2127 @ X8_v361+70]");
																																																		obj8 = (UnityEngine.Object)0;
																																																	}
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
																																																	object obj230 = 0;
																																																	object obj231 = obj230;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																	object obj232 = (nint)0 + (nint)1;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ X8_v163+A0]");
																																																	object obj233 = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																	object obj234 = 0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2147 @ X9_v64+28]");
																																																	num = 0.0;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2147 @ X9_v64+2C]");
																																																	num2 = 0.0;
																																																	object obj235 = obj46;
																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																	bool flag80 = (nint)0 == 0;
																																																	list = null;
																																																	if (!flag80)
																																																	{
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																		nint num31 = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v164+18]");
																																																		bool flag81 = num31 < 0;
																																																		object obj236 = !flag81;
																																																		if (obj236 == null)
																																																		{
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																			nint num32 = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																			object obj237 = num32 + 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X0_v132 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																			object obj238 = (nint)0 + (nint)1;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2147 @ X9_v64+28]");
																																																			_ = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2147 @ X9_v64+2C]");
																																																			_ = 0;
																																																		}
																																																		else
																																																		{
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X9_v65+20]");
																																																			object obj239 = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2151 @ X8_v356+A8]");
																																																			object obj240 = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2153 @ X8_v357+70]");
																																																			list8.AddWithResize((Vector2)0);
																																																		}
																																																		mesh5.SetUVs(0, list8);
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
																																																		object obj241 = 0;
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CC8]");
																																																		object obj242 = 0;
																																																		obj8 = (UnityEngine.Object)obj242;
																																																		List<Vector4> list9 = default;
																																																		list9._002Ector();
																																																		bool flag82 = (object)list9 == null;
																																																		material2 = null;
																																																		list = list8;
																																																		if (!flag82)
																																																		{
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																			object obj243 = 0;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																																																			object obj244 = (nint)0 + (nint)1;
																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																			bool flag83 = (nint)0 == 0;
																																																			material2 = null;
																																																			list = list8;
																																																			if (!flag83)
																																																			{
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																				nint num33 = 0;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v170+18]");
																																																				bool flag84 = num33 < 0;
																																																				object obj245 = !flag84;
																																																				if (obj245 == null)
																																																				{
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																					nint num34 = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																					object obj246 = num34 + 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																					object obj247 = (nint)0 + (nint)1;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																					num = 0.0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																					_ = 0;
																																																				}
																																																				else
																																																				{
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																																																					object obj248 = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ X8_v353+A8]");
																																																					object obj249 = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v354+70]");
																																																					list9.AddWithResize((Vector4)0);
																																																					num11 = 1.0;
																																																					obj84 = 0;
																																																					num2 = 0.0;
																																																					num = 0.0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2180 @ X8_v354+70]");
																																																					obj8 = (UnityEngine.Object)0;
																																																				}
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																				object obj250 = 0;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																																																				object obj251 = (nint)0 + (nint)1;
																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																				bool flag85 = (nint)0 == 0;
																																																				material2 = null;
																																																				list = list8;
																																																				if (!flag85)
																																																				{
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																					nint num35 = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v172+18]");
																																																					bool flag86 = num35 < 0;
																																																					object obj252 = !flag86;
																																																					if (obj252 == null)
																																																					{
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																						nint num36 = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																						object obj253 = num36 + 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																						object obj254 = (nint)0 + (nint)1;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																						num = 0.0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																						_ = 0;
																																																					}
																																																					else
																																																					{
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																																																						object obj255 = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2194 @ X8_v350+A8]");
																																																						object obj256 = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2200 @ X8_v351+70]");
																																																						list9.AddWithResize((Vector4)0);
																																																						num11 = 1.0;
																																																						obj84 = 0;
																																																						num2 = 0.0;
																																																						num = 0.0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2200 @ X8_v351+70]");
																																																						obj8 = (UnityEngine.Object)0;
																																																					}
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																					object obj257 = 0;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																																																					object obj258 = (nint)0 + (nint)1;
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																					bool flag87 = (nint)0 == 0;
																																																					material2 = null;
																																																					list = list8;
																																																					if (!flag87)
																																																					{
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																						nint num37 = 0;
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X8_v174+18]");
																																																						bool flag88 = num37 < 0;
																																																						object obj259 = !flag88;
																																																						if (obj259 == null)
																																																						{
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																							nint num38 = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																							object obj260 = num38 + 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ X0_v141 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																							object obj261 = (nint)0 + (nint)1;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																							num = 0.0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																							_ = 0;
																																																						}
																																																						else
																																																						{
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																																																							object obj262 = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v347+A8]");
																																																							object obj263 = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ X8_v348+70]");
																																																							list9.AddWithResize((Vector4)0);
																																																							num11 = 1.0;
																																																							obj84 = 0;
																																																							num2 = 0.0;
																																																							num = 0.0;
																																																						}
																																																						mesh5.SetUVs(1, list9);
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
																																																						object obj264 = 0;
																																																						obj8 = (UnityEngine.Object)obj264;
																																																						List<Vector2> list10 = default;
																																																						list10._002Ector();
																																																						bool flag89 = (object)list10 == null;
																																																						material2 = null;
																																																						list = (List<Vector2>)(object)list9;
																																																						if (!flag89)
																																																						{
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																							object obj265 = 0;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																							object obj266 = (nint)0 + (nint)1;
																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																							bool flag90 = (nint)0 == 0;
																																																							material2 = null;
																																																							list = (List<Vector2>)(object)list9;
																																																							if (!flag90)
																																																							{
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																								nint num39 = 0;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X8_v178+18]");
																																																								bool flag91 = num39 < 0;
																																																								object obj267 = !flag91;
																																																								if (obj267 == null)
																																																								{
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																									nint num40 = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																									object obj268 = num40 + 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																									object obj269 = (nint)0 + (nint)1;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																									num = 0.0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																									_ = 0;
																																																								}
																																																								else
																																																								{
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																																																									object obj270 = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2236 @ X8_v343+A8]");
																																																									object obj271 = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																																																									num = 0.0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2239 @ X8_v344+70]");
																																																									list10.AddWithResize((Vector2)0);
																																																									num2 = 1.0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2239 @ X8_v344+70]");
																																																									obj8 = (UnityEngine.Object)0;
																																																								}
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																								object obj272 = 0;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																								object obj273 = (nint)0 + (nint)1;
																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																								bool flag92 = (nint)0 == 0;
																																																								material2 = null;
																																																								list = (List<Vector2>)(object)list9;
																																																								if (!flag92)
																																																								{
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																									nint num41 = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ X8_v180+18]");
																																																									bool flag93 = num41 < 0;
																																																									object obj274 = !flag93;
																																																									if (obj274 == null)
																																																									{
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																										nint num42 = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																										object obj275 = num42 + 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																										object obj276 = (nint)0 + (nint)1;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																										num = 0.0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																										_ = 0;
																																																									}
																																																									else
																																																									{
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																																																										object obj277 = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2253 @ X8_v339+A8]");
																																																										object obj278 = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																																																										num = 0.0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2256 @ X8_v340+70]");
																																																										list10.AddWithResize((Vector2)0);
																																																										num2 = 1.0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2256 @ X8_v340+70]");
																																																										obj8 = (UnityEngine.Object)0;
																																																									}
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																									object obj279 = 0;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																									object obj280 = (nint)0 + (nint)1;
																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																									bool flag94 = (nint)0 == 0;
																																																									material2 = null;
																																																									list = (List<Vector2>)(object)list9;
																																																									if (!flag94)
																																																									{
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																										nint num43 = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ X8_v182+18]");
																																																										bool flag95 = num43 < 0;
																																																										object obj281 = !flag95;
																																																										if (obj281 == null)
																																																										{
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																											nint num44 = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																											object obj282 = num44 + 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X0_v147 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																											object obj283 = (nint)0 + (nint)1;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																											num = 0.0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																											_ = 0;
																																																										}
																																																										else
																																																										{
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																																																											object obj284 = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2269 @ X8_v335+A8]");
																																																											object obj285 = 0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																																																											num = 0.0;
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2272 @ X8_v336+70]");
																																																											list10.AddWithResize((Vector2)0);
																																																											num2 = 1.0;
																																																										}
																																																										mesh5.SetUVs(2, list10);
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																																																										object obj286 = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																										List<Vector3> list11 = default;
																																																										list11._002Ector((IEnumerable<Vector3>)array);
																																																										mesh5.SetUVs(3, list11);
																																																										GillaRip.FleshChannels(mesh5);
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
																																																										object obj287 = 0;
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																																										int[] array7 = default;
																																																										bool flag96 = array7 == null;
																																																										material2 = null;
																																																										list = (List<Vector2>)(object)list11;
																																																										obj8 = (UnityEngine.Object)3;
																																																										if (!flag96)
																																																										{
																																																											bool flag97 = array7.Length < 1;
																																																											object obj288 = !flag97;
																																																											object obj289 = array7.Length - 1;
																																																											bool flag98 = obj289 == null;
																																																											object obj290 = ~obj288;
																																																											object obj291 = obj290 | flag98;
																																																											material2 = null;
																																																											list = (List<Vector2>)(object)list11;
																																																											obj8 = (UnityEngine.Object)(object)array7;
																																																											if (obj291 == null)
																																																											{
																																																												bool flag99 = array7.Length == 2;
																																																												array7[1] = 1;
																																																												material2 = null;
																																																												list = (List<Vector2>)(object)list11;
																																																												obj8 = (UnityEngine.Object)(object)array7;
																																																												if (!flag99)
																																																												{
																																																													array7[2] = 2;
																																																													mesh5.SetTriangles(array7, 0);
																																																													mesh5.RecalculateBounds();
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA608]");
																																																													object obj292 = 0;
																																																													material2 = fleshMat;
																																																													Plain((string)obj292, mesh5, fleshMat);
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (UnityEngine.Object)+20]");
																																																													bool flag100 = (UnityEngine.Object)0 != null;
																																																													bool flag101 = !flag100;
																																																													transform3 = under;
																																																													Mesh mesh6 = null;
																																																													string text2 = null;
																																																													if (flag101)
																																																													{
																																																														goto IL_4327;
																																																													}
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C56C8]");
																																																													object obj293 = 0;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (UnityEngine.Object)+20]");
																																																													Material material3 = default;
																																																													material3._002Ector((Material)0);
																																																													bool flag102 = (object)material3 == null;
																																																													list = null;
																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (UnityEngine.Object)+20]");
																																																													obj8 = (UnityEngine.Object)0;
																																																													if (!flag102)
																																																													{
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5C8]");
																																																														object obj294 = (material3.name = (string)0);
																																																														object obj295 = this + 80;
																																																														obj295 = material3;
																																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																																																														bool flag103 = obj295 == null;
																																																														list = null;
																																																														obj8 = material3;
																																																														if (!flag103)
																																																														{
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76C0]");
																																																															object obj296 = 0;
																																																															((Material)obj295).SetFloat((string)obj296, 1f);
																																																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																															Mesh mesh7 = default;
																																																															mesh7._002Ector();
																																																															bool flag104 = (object)mesh7 == null;
																																																															num = 1.0;
																																																															list = null;
																																																															obj8 = null;
																																																															if (!flag104)
																																																															{
																																																																mesh7.name = (string)obj294;
																																																																mesh7.SetVertices(array);
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																																																																object obj297 = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																																obj8 = (UnityEngine.Object)obj169;
																																																																List<Vector3> list12 = default;
																																																																list12._002Ector();
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6788]");
																																																																object obj298 = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
																																																																object obj299 = 0;
																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																																																																object obj300 = 0;
																																																																bool flag105 = list12 == null;
																																																																num = 1.0;
																																																																list = null;
																																																																if (!flag105)
																																																																{
																																																																	object obj301 = obj300;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2406 @ X8_v231+A0]");
																																																																	object obj302 = 0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																	object obj303 = 0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																																																																	object obj304 = (nint)0 + (nint)1;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ X9_v88+54]");
																																																																	num = 0.0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ X9_v88+58]");
																																																																	num2 = 0.0;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ X9_v88+5C]");
																																																																	obj84 = 0;
																																																																	object obj305 = obj173;
																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																	bool flag106 = (nint)0 == 0;
																																																																	list = null;
																																																																	if (!flag106)
																																																																	{
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																		nint num45 = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v232+18]");
																																																																		bool flag107 = num45 < 0;
																																																																		object obj306 = !flag107;
																																																																		if (obj306 == null)
																																																																		{
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																			object obj307 = (nint)0 * (nint)12;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																			object obj308 = 0 + obj307;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																			object obj309 = (nint)0 + (nint)1;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ X9_v88+54]");
																																																																			_ = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ X9_v88+58]");
																																																																			_ = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ X9_v88+5C]");
																																																																			_ = 0;
																																																																		}
																																																																		else
																																																																		{
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X9_v89+20]");
																																																																			object obj310 = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2417 @ X8_v328+A8]");
																																																																			object obj311 = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2419 @ X8_v329+70]");
																																																																			list12.AddWithResize((Vector3)0);
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2419 @ X8_v329+70]");
																																																																			obj8 = (UnityEngine.Object)0;
																																																																		}
																																																																		object obj312 = obj300;
																																																																		object obj313 = obj173;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2429 @ X8_v234+A0]");
																																																																		object obj314 = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																		object obj315 = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ X9_v91+54]");
																																																																		num = 0.0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ X9_v91+58]");
																																																																		num2 = 0.0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ X9_v91+5C]");
																																																																		obj84 = 0;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																																																																		object obj316 = (nint)0 + (nint)1;
																																																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																		bool flag108 = (nint)0 == 0;
																																																																		list = null;
																																																																		if (!flag108)
																																																																		{
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																			nint num46 = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v235+18]");
																																																																			bool flag109 = num46 < 0;
																																																																			object obj317 = !flag109;
																																																																			if (obj317 == null)
																																																																			{
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																				object obj318 = (nint)0 * (nint)12;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																				object obj319 = 0 + obj318;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																				object obj320 = (nint)0 + (nint)1;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ X9_v91+54]");
																																																																				_ = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ X9_v91+58]");
																																																																				_ = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ X9_v91+5C]");
																																																																				_ = 0;
																																																																			}
																																																																			else
																																																																			{
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X10_v75+20]");
																																																																				object obj321 = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2452 @ X8_v323+A8]");
																																																																				object obj322 = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2454 @ X8_v324+70]");
																																																																				list12.AddWithResize((Vector3)0);
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2454 @ X8_v324+70]");
																																																																				obj8 = (UnityEngine.Object)0;
																																																																			}
																																																																			object obj323 = obj300;
																																																																			object obj324 = obj173;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ X8_v237+A0]");
																																																																			object obj325 = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																			object obj326 = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X9_v95+54]");
																																																																			num = 0.0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X9_v95+58]");
																																																																			num2 = 0.0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X9_v95+5C]");
																																																																			obj84 = 0;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
																																																																			object obj327 = (nint)0 + (nint)1;
																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																			bool flag110 = (nint)0 == 0;
																																																																			list = null;
																																																																			if (!flag110)
																																																																			{
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																				nint num47 = 0;
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1178 @ X8_v238+18]");
																																																																				bool flag111 = num47 < 0;
																																																																				object obj328 = !flag111;
																																																																				if (obj328 == null)
																																																																				{
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																					object obj329 = (nint)0 * (nint)12;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
																																																																					object obj330 = 0 + obj329;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v232 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
																																																																					object obj331 = (nint)0 + (nint)1;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X9_v95+54]");
																																																																					_ = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X9_v95+58]");
																																																																					_ = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2469 @ X9_v95+5C]");
																																																																					_ = 0;
																																																																				}
																																																																				else
																																																																				{
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X10_v77+20]");
																																																																					object obj332 = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X8_v320+A8]");
																																																																					object obj333 = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2484 @ X8_v321+70]");
																																																																					list12.AddWithResize((Vector3)0);
																																																																				}
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
																																																																				obj152 = 0;
																																																																				mesh7.SetNormals(list12);
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
																																																																				object obj334 = 0;
																																																																				obj8 = (UnityEngine.Object)obj334;
																																																																				List<Vector2> list13 = default;
																																																																				list13._002Ector();
																																																																				bool flag112 = (object)list13 == null;
																																																																				list = null;
																																																																				if (!flag112)
																																																																				{
																																																																					object obj335 = obj299;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2510 @ X8_v244+A0]");
																																																																					object obj336 = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																					object obj337 = 0;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																																					object obj338 = (nint)0 + (nint)1;
																																																																					num = (double)obj336;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2512 @ X9_v99+4]");
																																																																					num2 = 0.0;
																																																																					object obj339 = obj46;
																																																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																					bool flag113 = (nint)0 == 0;
																																																																					list = null;
																																																																					if (!flag113)
																																																																					{
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																						nint num48 = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ X8_v245+18]");
																																																																						bool flag114 = num48 < 0;
																																																																						object obj340 = !flag114;
																																																																						if (obj340 == null)
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																							nint num49 = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																							object obj341 = num49 + 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																							object obj342 = (nint)0 + (nint)1;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2512 @ X9_v99+4]");
																																																																							_ = 0;
																																																																						}
																																																																						else
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X9_v100+20]");
																																																																							object obj343 = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2519 @ X8_v316+A8]");
																																																																							object obj344 = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2521 @ X8_v317+70]");
																																																																							list13.AddWithResize((Vector2)0);
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2521 @ X8_v317+70]");
																																																																							obj8 = (UnityEngine.Object)0;
																																																																						}
																																																																						object obj345 = obj299;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2539 @ X8_v249+A0]");
																																																																						object obj346 = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																						object obj347 = 0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																																						object obj348 = (nint)0 + (nint)1;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2541 @ X9_v102+10]");
																																																																						num = 0.0;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2541 @ X9_v102+14]");
																																																																						num2 = 0.0;
																																																																						object obj349 = obj46;
																																																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																						bool flag115 = (nint)0 == 0;
																																																																						list = null;
																																																																						if (!flag115)
																																																																						{
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																							nint num50 = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v250+18]");
																																																																							bool flag116 = num50 < 0;
																																																																							object obj350 = !flag116;
																																																																							if (obj350 == null)
																																																																							{
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																								nint num51 = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																								object obj351 = num51 + 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																								object obj352 = (nint)0 + (nint)1;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2541 @ X9_v102+10]");
																																																																								_ = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2541 @ X9_v102+14]");
																																																																								_ = 0;
																																																																							}
																																																																							else
																																																																							{
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X9_v103+20]");
																																																																								object obj353 = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2547 @ X8_v312+A8]");
																																																																								object obj354 = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v313+70]");
																																																																								list13.AddWithResize((Vector2)0);
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2549 @ X8_v313+70]");
																																																																								obj8 = (UnityEngine.Object)0;
																																																																							}
																																																																							object obj355 = obj299;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2569 @ X8_v254+A0]");
																																																																							object obj356 = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																							object obj357 = 0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																																							object obj358 = (nint)0 + (nint)1;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X9_v105+28]");
																																																																							num = 0.0;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X9_v105+2C]");
																																																																							num2 = 0.0;
																																																																							object obj359 = obj46;
																																																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																							bool flag117 = (nint)0 == 0;
																																																																							list = null;
																																																																							if (!flag117)
																																																																							{
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																								nint num52 = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X8_v255+18]");
																																																																								bool flag118 = num52 < 0;
																																																																								object obj360 = !flag118;
																																																																								if (obj360 == null)
																																																																								{
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																									nint num53 = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																									object obj361 = num53 + 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v239 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																									object obj362 = (nint)0 + (nint)1;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X9_v105+28]");
																																																																									_ = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2571 @ X9_v105+2C]");
																																																																									_ = 0;
																																																																								}
																																																																								else
																																																																								{
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ X9_v106+20]");
																																																																									object obj363 = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2581 @ X8_v308+A8]");
																																																																									object obj364 = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ X8_v309+70]");
																																																																									list13.AddWithResize((Vector2)0);
																																																																								}
																																																																								mesh7.SetUVs(0, list13);
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
																																																																								object obj365 = 0;
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6CC8]");
																																																																								object obj366 = 0;
																																																																								obj8 = (UnityEngine.Object)obj366;
																																																																								List<Vector4> list14 = default;
																																																																								list14._002Ector();
																																																																								bool flag119 = (object)list14 == null;
																																																																								material2 = null;
																																																																								list = list13;
																																																																								if (!flag119)
																																																																								{
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																									object obj367 = 0;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																																																																									object obj368 = (nint)0 + (nint)1;
																																																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																									bool flag120 = (nint)0 == 0;
																																																																									material2 = null;
																																																																									list = list13;
																																																																									if (!flag120)
																																																																									{
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																										nint num54 = 0;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v261+18]");
																																																																										bool flag121 = num54 < 0;
																																																																										object obj369 = !flag121;
																																																																										if (obj369 == null)
																																																																										{
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																											nint num55 = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																											object obj370 = num55 + 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																											object obj371 = (nint)0 + (nint)1;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																																											num = 0.0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																																											_ = 0;
																																																																										}
																																																																										else
																																																																										{
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																																																																											object obj372 = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2624 @ X8_v305+A8]");
																																																																											object obj373 = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2630 @ X8_v306+70]");
																																																																											list14.AddWithResize((Vector4)0);
																																																																											num11 = 1.0;
																																																																											obj84 = 0;
																																																																											num2 = 0.0;
																																																																											num = 0.0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2630 @ X8_v306+70]");
																																																																											obj8 = (UnityEngine.Object)0;
																																																																										}
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																										object obj374 = 0;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																																																																										object obj375 = (nint)0 + (nint)1;
																																																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																										bool flag122 = (nint)0 == 0;
																																																																										material2 = null;
																																																																										list = list13;
																																																																										if (!flag122)
																																																																										{
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																											nint num56 = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X8_v263+18]");
																																																																											bool flag123 = num56 < 0;
																																																																											object obj376 = !flag123;
																																																																											if (obj376 == null)
																																																																											{
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																												nint num57 = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																												object obj377 = num57 + 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																												object obj378 = (nint)0 + (nint)1;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																																												num = 0.0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																																												_ = 0;
																																																																											}
																																																																											else
																																																																											{
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																																																																												object obj379 = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2647 @ X8_v302+A8]");
																																																																												object obj380 = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2653 @ X8_v303+70]");
																																																																												list14.AddWithResize((Vector4)0);
																																																																												num11 = 1.0;
																																																																												obj84 = 0;
																																																																												num2 = 0.0;
																																																																												num = 0.0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2653 @ X8_v303+70]");
																																																																												obj8 = (UnityEngine.Object)0;
																																																																											}
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																											object obj381 = 0;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+1C]");
																																																																											object obj382 = (nint)0 + (nint)1;
																																																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																											bool flag124 = (nint)0 == 0;
																																																																											material2 = null;
																																																																											list = list13;
																																																																											if (!flag124)
																																																																											{
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																												nint num58 = 0;
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ X8_v265+18]");
																																																																												bool flag125 = num58 < 0;
																																																																												object obj383 = !flag125;
																																																																												if (obj383 == null)
																																																																												{
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+10]");
																																																																													nint num59 = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																													object obj384 = num59 + 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v248 (System.Collections.Generic.List`1<UnityEngine.Vector4>)+18]");
																																																																													object obj385 = (nint)0 + (nint)1;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																																													num = 0.0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D960]");
																																																																													_ = 0;
																																																																												}
																																																																												else
																																																																												{
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107D020]");
																																																																													object obj386 = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2664 @ X8_v299+A8]");
																																																																													object obj387 = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2670 @ X8_v300+70]");
																																																																													list14.AddWithResize((Vector4)0);
																																																																													num11 = 1.0;
																																																																													obj84 = 0;
																																																																													num2 = 0.0;
																																																																													num = 0.0;
																																																																												}
																																																																												mesh7.SetUVs(1, list14);
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6978]");
																																																																												object obj388 = 0;
																																																																												obj8 = (UnityEngine.Object)obj388;
																																																																												List<Vector2> list15 = default;
																																																																												list15._002Ector();
																																																																												bool flag126 = (object)list15 == null;
																																																																												material2 = null;
																																																																												list = (List<Vector2>)(object)list14;
																																																																												if (!flag126)
																																																																												{
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																													object obj389 = 0;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																																													object obj390 = (nint)0 + (nint)1;
																																																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																													bool flag127 = (nint)0 == 0;
																																																																													material2 = null;
																																																																													list = (List<Vector2>)(object)list14;
																																																																													if (!flag127)
																																																																													{
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																														nint num60 = 0;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v269+18]");
																																																																														bool flag128 = num60 < 0;
																																																																														object obj391 = !flag128;
																																																																														if (obj391 == null)
																																																																														{
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																															nint num61 = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																															object obj392 = num61 + 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																															object obj393 = (nint)0 + (nint)1;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																																															num = 0.0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																																															_ = 0;
																																																																														}
																																																																														else
																																																																														{
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																																																																															object obj394 = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2687 @ X8_v295+A8]");
																																																																															object obj395 = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																																																																															num = 0.0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ X8_v296+70]");
																																																																															list15.AddWithResize((Vector2)0);
																																																																															num2 = 1.0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ X8_v296+70]");
																																																																															obj8 = (UnityEngine.Object)0;
																																																																														}
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																														object obj396 = 0;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																																														object obj397 = (nint)0 + (nint)1;
																																																																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																														bool flag129 = (nint)0 == 0;
																																																																														material2 = null;
																																																																														list = (List<Vector2>)(object)list14;
																																																																														if (!flag129)
																																																																														{
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																															nint num62 = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v271+18]");
																																																																															bool flag130 = num62 < 0;
																																																																															object obj398 = !flag130;
																																																																															if (obj398 == null)
																																																																															{
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																																nint num63 = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																																object obj399 = num63 + 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																																object obj400 = (nint)0 + (nint)1;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																																																num = 0.0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																																																_ = 0;
																																																																															}
																																																																															else
																																																																															{
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																																																																																object obj401 = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2704 @ X8_v291+A8]");
																																																																																object obj402 = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																																																																																num = 0.0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2707 @ X8_v292+70]");
																																																																																list15.AddWithResize((Vector2)0);
																																																																																num2 = 1.0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2707 @ X8_v292+70]");
																																																																																obj8 = (UnityEngine.Object)0;
																																																																															}
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																															object obj403 = 0;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
																																																																															object obj404 = (nint)0 + (nint)1;
																																																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																															bool flag131 = (nint)0 == 0;
																																																																															material2 = null;
																																																																															list = (List<Vector2>)(object)list14;
																																																																															if (!flag131)
																																																																															{
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																																nint num64 = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X8_v273+18]");
																																																																																bool flag132 = num64 < 0;
																																																																																object obj405 = !flag132;
																																																																																if (obj405 == null)
																																																																																{
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
																																																																																	nint num65 = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																																	object obj406 = num65 + 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v254 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
																																																																																	object obj407 = (nint)0 + (nint)1;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																																																	num = 0.0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC0]");
																																																																																	_ = 0;
																																																																																}
																																																																																else
																																																																																{
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B020]");
																																																																																	object obj408 = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2720 @ X8_v287+A8]");
																																																																																	object obj409 = 0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																																																																																	num = 0.0;
																																																																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2723 @ X8_v288+70]");
																																																																																	list15.AddWithResize((Vector2)0);
																																																																																	num2 = 1.0;
																																																																																}
																																																																																mesh7.SetUVs(2, list15);
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																																																																																object obj410 = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																																																																																List<Vector3> list16 = default;
																																																																																list16._002Ector((IEnumerable<Vector3>)array);
																																																																																mesh7.SetUVs(3, list16);
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
																																																																																object obj411 = 0;
																																																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																																																																int[] array8 = default;
																																																																																bool flag133 = array8 == null;
																																																																																material2 = null;
																																																																																list = (List<Vector2>)(object)list16;
																																																																																obj8 = (UnityEngine.Object)3;
																																																																																if (!flag133)
																																																																																{
																																																																																	bool flag134 = array8.Length < 1;
																																																																																	object obj412 = !flag134;
																																																																																	object obj413 = array8.Length - 1;
																																																																																	bool flag135 = obj413 == null;
																																																																																	object obj414 = ~obj412;
																																																																																	object obj415 = obj414 | flag135;
																																																																																	material2 = null;
																																																																																	list = (List<Vector2>)(object)list16;
																																																																																	obj8 = (UnityEngine.Object)(object)array8;
																																																																																	if (obj415 == null)
																																																																																	{
																																																																																		bool flag136 = array8.Length == 2;
																																																																																		array8[1] = 1;
																																																																																		material2 = null;
																																																																																		list = (List<Vector2>)(object)list16;
																																																																																		obj8 = (UnityEngine.Object)(object)array8;
																																																																																		if (!flag136)
																																																																																		{
																																																																																			array8[2] = 2;
																																																																																			mesh7.SetTriangles(array8, 0);
																																																																																			mesh7.RecalculateBounds();
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5F0]");
																																																																																			object obj416 = 0;
																																																																																			Plain((string)obj416, mesh7, boneMat);
																																																																																			Mesh mesh8 = Four(mesh7);
																																																																																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA628]");
																																																																																			object obj417 = 0;
																																																																																			material2 = boneMat;
																																																																																			text2 = (string)obj417;
																																																																																			Plain((string)obj417, mesh8, boneMat);
																																																																																			transform3 = under;
																																																																																			mesh6 = mesh8;
																																																																																			goto IL_4327;
																																																																																		}
																																																																																	}
																																																																																	goto IL_49bc;
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
																																																													}
																																																													goto IL_49ae;
																																																												}
																																																											}
																																																											goto IL_49bc;
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
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																	goto IL_49ae;
																																}
																															}
																														}
																													}
																												}
																											}
																											goto IL_49bc;
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
														goto IL_49ae;
													}
												}
											}
											goto IL_49bc;
										}
									}
									goto IL_49ae;
								}
							}
						}
						goto IL_49bc;
					}
				}
			}
		}
		goto IL_49ae;
		IL_49ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_4327:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj418 = 0;
		object obj419 = obj418;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2331 @ X0_v164+E4]");
		bool flag137 = (nint)0 == 0;
		object obj420 = !flag137;
		if (obj420 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(ripSkin != null))
		{
			return;
		}
		object obj421 = obj418;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2341 @ X0_v168+E4]");
		bool flag138 = (nint)0 == 0;
		object obj422 = !flag138;
		if (obj422 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(ripMat != null))
		{
			return;
		}
		bool flag139 = (object)transform3 == null;
		list = null;
		obj8 = null;
		if (!flag139)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA510]");
			object n = 0;
			Transform transform4 = transform3.Find((string)n);
			object obj423 = obj418;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v199+E4]");
			bool flag140 = (nint)0 == 0;
			object obj424 = !flag140;
			if (obj424 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag141 = transform4 != null;
			bool flag142 = !flag141;
			UnityEngine.Object obj425 = null;
			UnityEngine.Object obj426 = null;
			if (!flag142)
			{
				bool flag143 = (object)transform4 == null;
				list = null;
				obj8 = null;
				if (flag143)
				{
					goto IL_49ae;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5A8]");
				object obj427 = 0;
				obj425 = (UnityEngine.Object)obj427;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				UnityEngine.Object obj428 = default;
				obj426 = obj428;
			}
			object obj429 = obj418;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2381 @ X0_v178+E4]");
			bool flag144 = (nint)0 == 0;
			object obj430 = !flag144;
			if (obj430 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(obj426 != null))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Mesh mesh9 = default;
			mesh9._002Ector();
			bool flag145 = (object)mesh9 == null;
			list = null;
			obj8 = null;
			if (!flag145)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA640]");
				object obj431 = (mesh9.name = (string)0);
				bool flag146 = (object)obj426 == null;
				list = null;
				obj8 = (UnityEngine.Object)obj431;
				if (!flag146)
				{
					((SkinnedMeshRenderer)obj426).BakeMesh(mesh9, false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5E8]");
					object obj432 = 0;
					Plain((string)obj432, mesh9, ripMat);
					Mesh mesh10 = Four(mesh9);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5B8]");
					object obj433 = 0;
					Material material2 = ripMat;
					Plain((string)obj433, mesh10, ripMat);
					if (unhurtMats == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj434 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5F8]");
					object obj435 = 0;
					GameObject gameObject2 = default;
					gameObject2._002Ector((string)obj435);
					bool flag147 = (object)gameObject2 == null;
					list = null;
					obj8 = (UnityEngine.Object)obj435;
					if (!flag147)
					{
						Transform transform5 = gameObject2.transform;
						bool flag148 = (object)transform5 == null;
						list = null;
						obj8 = null;
						if (!flag148)
						{
							transform5.SetParent(transform3, worldPositionStays: false);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
							object obj436 = 0;
							obj8 = (UnityEngine.Object)obj436;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
							SkinnedMeshRenderer skinnedMeshRenderer2 = default;
							bool flag149 = (object)skinnedMeshRenderer2 == null;
							material2 = null;
							list = null;
							if (!flag149)
							{
								skinnedMeshRenderer2.sharedMesh = ripSkin;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
								object obj437 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Transform transform6 = gameObject2.transform;
								Transform[] array9 = default;
								bool flag150 = array9 == null;
								material2 = null;
								list = null;
								obj8 = null;
								if (!flag150)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
									skinnedMeshRenderer2.bones = array9;
									Transform rootBone2 = gameObject2.transform;
									skinnedMeshRenderer2.rootBone = rootBone2;
									skinnedMeshRenderer2.sharedMaterials = unhurtMats;
									Material[] array10 = unhurtMats;
									bool flag151 = unhurtMats == null;
									material2 = null;
									list = null;
									obj8 = (UnityEngine.Object)(object)unhurtMats;
									if (!flag151)
									{
										if (array10.Length < 1)
										{
											return;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5C0]");
										object obj438 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5E0]");
										object obj439 = 0;
										object obj440 = array10.Length & 0xFFFFFFFFL;
										object obj441 = unhurtMats + 32;
										material2 = null;
										list = null;
										obj8 = (UnityEngine.Object)(object)unhurtMats;
										object obj442 = 0;
										while (true)
										{
											bool flag152 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj442) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj440);
											object obj443 = !flag152;
											if (obj443 != null)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X26_v18+v1415 @ X23_v16*8]");
											Plain((string)obj438, mesh9, (Material)0);
											Mesh mesh11 = Four(mesh9);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X26_v18+v1415 @ X23_v16*8]");
											Plain((string)obj439, mesh11, (Material)0);
											obj440 = array10.Length;
											obj442++;
											bool flag153 = (nint)obj442 < array10.Length;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X26_v18+v1415 @ X23_v16*8]");
											material2 = (Material)0;
											list = (List<Vector2>)(object)mesh11;
											obj8 = (UnityEngine.Object)obj439;
											if (!flag153)
											{
												return;
											}
										}
										goto IL_49bc;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_49ae;
		IL_49ae:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_49bc;
		IL_49bc:
		ex = new IndexOutOfRangeException();
		goto IL_49ca;
	}

	private void Plain(string name, Mesh mesh, Material mat)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I4
		//IL_01eb: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (mesh == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C94D8]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag2 = ((List<System.__Canon>)(object)baked).Contains((System.__Canon)(object)mesh);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		System.__Canon _Canon = (System.__Canon)(object)mesh;
		if (obj6 == null)
		{
			List<System.__Canon> list = (List<System.__Canon>)(object)baked;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
			object obj7 = 0;
			System.__Canon[] items = list._items;
			object obj8 = obj7;
			int version = list._version + 1;
			list._version = version;
			bool flag4 = list._size < items.Length;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				object obj10 = items + list._size;
				int size = list._size + 1;
				list._size = size;
				object obj11 = obj10 + 32;
				obj11 = mesh;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_Canon = (System.__Canon)(object)mesh;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X9_v5+20]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v15+A8]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v16+70]");
				obj5 = 0;
				list.AddWithResize((System.__Canon)(object)mesh);
				_Canon = (System.__Canon)(object)mesh;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		transform.SetParent(parent, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		MeshFilter meshFilter = default;
		meshFilter.sharedMesh = mesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Renderer renderer = default;
		renderer.sharedMaterial = mat;
	}

	private Mesh Four(Mesh from)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		if ((object)from != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA668]");
			object obj2 = 0;
			string text = from.name;
			string text2 = text + (string)obj2;
			if ((object)mesh != null)
			{
				mesh.name = text2;
				Vector3[] vertices = from.vertices;
				mesh.SetVertices(vertices);
				Vector3[] normals = from.normals;
				if (normals != null)
				{
					int vertexCount = from.vertexCount;
					if (vertexCount == normals.Length)
					{
						mesh.SetNormals(normals);
					}
				}
				Vector4[] tangents = from.tangents;
				if (tangents != null)
				{
					int vertexCount2 = from.vertexCount;
					if (vertexCount2 == tangents.Length)
					{
						mesh.SetTangents(tangents);
					}
				}
				Color[] colors = from.colors;
				if (colors != null)
				{
					int vertexCount3 = from.vertexCount;
					if (vertexCount3 == colors.Length)
					{
						mesh.SetColors(colors);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AC8]");
				object obj3 = 0;
				int num = 0;
				List<Vector4> list = default;
				do
				{
					VertexAttribute attr = (VertexAttribute)(num + 4);
					if (from.HasVertexAttribute(attr))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						list._002Ector();
						from.GetUVs(num, list);
						mesh.SetUVs(num, list);
						object obj4 = 0;
					}
					num++;
				}
				while (num != 8);
				int subMeshCount = from.subMeshCount;
				mesh.subMeshCount = subMeshCount;
				int subMeshCount2 = from.subMeshCount;
				bool flag = subMeshCount2 < 1;
				int num2 = 0;
				if (!flag)
				{
					int num3 = 0;
					bool flag2;
					do
					{
						int[] triangles = from.GetTriangles(num3);
						mesh.SetTriangles(triangles, num3);
						int num4 = num3 + 1;
						int subMeshCount3 = from.subMeshCount;
						flag2 = num4 < subMeshCount3;
						object obj4 = 0;
						num2 = num3;
						num3 = num4;
					}
					while (flag2);
				}
				mesh.RecalculateBounds();
				List<System.__Canon> list2 = (List<System.__Canon>)(object)baked;
				if ((object)baked != null)
				{
					System.__Canon[] items = list2._items;
					int version = list2._version + 1;
					list2._version = version;
					if (list2._items != null)
					{
						bool flag3 = list2._size < items.Length;
						object obj5 = !flag3;
						if (obj5 == null)
						{
							object obj6 = list2._items + list2._size;
							int size = list2._size + 1;
							list2._size = size;
							object obj7 = obj6 + 32;
							obj7 = mesh;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							((List<System.__Canon>)(object)baked).AddWithResize((System.__Canon)(object)mesh);
						}
						return mesh;
					}
				}
			}
		}
		return (Mesh)(object)new NullReferenceException();
	}

	private unsafe static void Sounds()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I
		//IL_00dc: Expected VT, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_1506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_0b4a: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_018f: Expected Obj, but got Ref
		//IL_0b8d: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_16ce: Expected Obj, but got I
		//IL_16f0: Expected Obj, but got I4
		//IL_16a8: Expected Obj, but got I4
		//IL_0d17: Expected Obj, but got I4
		//IL_0bbd: Expected Obj, but got I4
		//IL_0d4a: Expected Obj, but got I4
		//IL_0bf0: Expected Obj, but got I
		//IL_0c12: Expected Obj, but got I4
		//IL_131d: Expected Obj, but got I
		//IL_132d: Expected Obj, but got I
		//IL_1331: Unknown result type (might be due to invalid IL or missing references)
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_0382: Expected Obj, but got I4
		//IL_0d7d: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Expected Obj, but got I4
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a3: Expected Obj, but got I4
		//IL_0c8f: Expected Obj, but got I4
		//IL_1618: Expected Obj, but got I
		//IL_163a: Expected Obj, but got I4
		//IL_1730: Unknown result type (might be due to invalid IL or missing references)
		//IL_1739: Expected Ref, but got Unknown
		//IL_1753: Expected Obj, but got I4
		//IL_1369: Expected Obj, but got I4
		//IL_0da8: Expected Obj, but got I
		//IL_0dbd: Expected I4, but got Obj
		//IL_0dfa: Expected Obj, but got I4
		//IL_0e0a: Expected Obj, but got I
		//IL_0480: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I4
		//IL_13ac: Expected Obj, but got I4
		//IL_0cba: Expected Obj, but got I
		//IL_0cd5: Expected Obj, but got I4
		//IL_06fe: Expected Obj, but got I
		//IL_0720: Expected Obj, but got I4
		//IL_14c2: Expected Obj, but got I4
		//IL_14c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ca: Expected Obj, but got Unknown
		//IL_0e4e: Expected Obj, but got I4
		//IL_0763: Expected Obj, but got I4
		//IL_04bb: Expected Obj, but got I4
		//IL_13ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13df: Expected Obj, but got I4
		//IL_13df: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f8: Expected Obj, but got I4
		//IL_0ed9: Expected Obj, but got I
		//IL_0ee9: Expected Obj, but got I
		//IL_0ef9: Expected Obj, but got I
		//IL_0f0e: Expected Obj, but got I
		//IL_0aa5: Expected Obj, but got I
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected Obj, but got Unknown
		//IL_0f2b: Expected Obj, but got I
		//IL_0f3b: Expected Obj, but got I
		//IL_0f5d: Expected Obj, but got I4
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Expected Obj, but got Unknown
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Expected Obj, but got Unknown
		//IL_0eb1: Expected Obj, but got I
		//IL_0ec4: Expected Obj, but got I4
		//IL_0786: Expected Obj, but got I
		//IL_07b6: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I
		//IL_0510: Expected Obj, but got I4
		//IL_143a: Expected Obj, but got I4
		//IL_1443: Expected Obj, but got I4
		//IL_0fa0: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I4
		//IL_1579: Expected Obj, but got I4
		//IL_1582: Expected Obj, but got I4
		//IL_1198: Expected Obj, but got I
		//IL_11a8: Expected Obj, but got I
		//IL_11ca: Expected Obj, but got I4
		//IL_0805: Expected Obj, but got I4
		//IL_1467: Expected Obj, but got I4
		//IL_120d: Expected Obj, but got I4
		//IL_0fd3: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
		//IL_0838: Expected Obj, but got I4
		//IL_1230: Expected Obj, but got I
		//IL_1250: Expected Obj, but got I4
		//IL_0ff7: Expected Obj, but got I
		//IL_1013: Expected Obj, but got I4
		//IL_05fb: Expected Obj, but got I4
		//IL_0865: Expected Obj, but got I8
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_0886: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I4
		//IL_063f: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I4
		//IL_067f: Expected Obj, but got Ref
		//IL_1295: Expected Obj, but got I4
		//IL_1043: Expected I4, but got Obj
		//IL_1080: Expected Obj, but got I4
		//IL_1661: Expected Obj, but got I4
		//IL_12d2: Expected Obj, but got I4
		//IL_12e2: Expected Obj, but got Ref
		//IL_06bf: Expected Obj, but got I4
		//IL_06cf: Expected Obj, but got Ref
		//IL_10bb: Expected Obj, but got I4
		//IL_08c9: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I4
		//IL_1146: Expected Obj, but got I
		//IL_1156: Expected Obj, but got I
		//IL_1166: Expected Obj, but got I
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected Obj, but got Unknown
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Expected Obj, but got Unknown
		//IL_1129: Expected Obj, but got I4
		//IL_0a29: Expected Obj, but got I
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a56: Expected Obj, but got I4
		//IL_0a77: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I4
		//IL_09ad: Expected Obj, but got I4
		//IL_09df: Expected Obj, but got I
		//IL_09f4: Expected Obj, but got I
		//IL_0a04: Expected Obj, but got Ref
		//IL_0a14: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA528]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		UnityEngine.Object obj2 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		UnityEngine.Object obj3 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		System.__Canon[] array = (System.__Canon[])obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v6 (System.__Canon[])+E4]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v6 (System.__Canon[])+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
		object obj6 = 0;
		UnityEngine.Object obj7 = default;
		bool flag2 = obj7 != null;
		bool flag3 = !flag2;
		_003C_003Ec__DisplayClass55_0 obj8 = (_003C_003Ec__DisplayClass55_0)list;
		UnityEngine.Object obj9 = null;
		object obj12;
		List<System.__Canon> list2;
		object obj10;
		UnityEngine.Object obj11;
		if (!flag3)
		{
			bool flag4 = (object)obj7 == null;
			obj10 = 0;
			list2 = list;
			obj11 = null;
			obj12 = 109891584;
			if (flag4)
			{
				goto IL_14ef;
			}
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v145+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7 (UnityEngine.Object)+70]");
			_003CSounds_003Eg__Add_007C55_0((AudioClip[])0, ref obj8);
			obj9 = (UnityEngine.Object)(&obj8);
		}
		object obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v34+E4]");
		array = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA4D0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v34+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj11 = (UnityEngine.Object)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj18 = default;
		bool flag7 = obj18 == null;
		obj10 = 0;
		list2 = list;
		obj12 = 109891584;
		List<System.__Canon> list3;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v37+18]");
			array = (System.__Canon[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v37+18]");
			bool flag8 = (nint)0 < (nint)1;
			object obj19 = 0;
			list3 = list;
			obj12 = 109891584;
			if (flag8)
			{
				goto IL_0b07;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA460]");
			obj12 = 0;
			object obj21 = default;
			object obj20 = obj21;
			object obj23 = default;
			object obj22 = obj23;
			object obj24 = 0;
			obj10 = 0;
			list2 = list;
			UnityEngine.Object obj25 = (UnityEngine.Object)obj16;
			UnityEngine.Object obj26 = obj3;
			UnityEngine.Object obj32 = default;
			while (true)
			{
				bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<System.__Canon[], UIntPtr>(ref array);
				object obj27 = !flag9;
				object obj28;
				if (obj27 == null)
				{
					array = (System.__Canon[])(object)(obj18 + obj24);
					System.__Canon _Canon = array[0];
					bool flag10 = array[0] == null;
					obj23 = obj22;
					obj28 = obj24;
					obj11 = obj25;
					obj3 = obj26;
					if (flag10)
					{
						break;
					}
					object obj29 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X0_v102+E4]");
					array = (System.__Canon[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X0_v102+E4]");
					bool flag11 = (nint)0 == 0;
					object obj30 = !flag11;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+20]");
					bool flag12 = (UnityEngine.Object)0 != null;
					bool flag13 = !flag12;
					UnityEngine.Object obj31 = null;
					obj2 = null;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+20]");
						bool flag14 = (nint)0 == 0;
						obj23 = obj22;
						obj28 = obj24;
						obj10 = 0;
						obj11 = null;
						obj3 = obj26;
						obj2 = null;
						if (flag14)
						{
							break;
						}
						obj31 = (UnityEngine.Object)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
						obj2 = obj32;
					}
					object obj33 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X0_v107+E4]");
					array = (System.__Canon[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X0_v107+E4]");
					bool flag15 = (nint)0 == 0;
					object obj34 = !flag15;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag16 = obj2 != null;
					bool flag17 = !flag16;
					object obj35 = 0;
					UnityEngine.Object obj36 = null;
					if (!flag17)
					{
						bool flag18 = (object)obj2 == null;
						obj23 = obj22;
						obj28 = obj24;
						obj10 = 0;
						obj11 = null;
						obj3 = obj26;
						if (flag18)
						{
							break;
						}
						object obj37 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+A8]");
						obj26 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v130+E4]");
						bool flag19 = (nint)0 == 0;
						object obj38 = !flag19;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag20 = obj26 != null;
						bool flag21 = !flag20;
						obj35 = 0;
						obj36 = null;
						if (!flag21)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+A8]");
							array = (System.__Canon[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+A8]");
							bool flag22 = (nint)0 == 0;
							obj23 = obj22;
							obj28 = obj24;
							obj10 = 0;
							obj11 = null;
							obj3 = obj26;
							if (flag22)
							{
								break;
							}
							object obj39 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X0_v134+E4]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X0_v134+E4]");
							bool flag23 = (nint)0 == 0;
							object obj40 = !flag23;
							if (obj40 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							_003CSounds_003Eg__Add_007C55_0((AudioClip[])(object)array[5], ref obj8);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+A8]");
							array = (System.__Canon[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+A8]");
							bool flag24 = (nint)0 == 0;
							obj23 = obj22;
							obj28 = obj24;
							obj10 = 0;
							list2 = list;
							obj11 = (UnityEngine.Object)(&obj8);
							obj3 = (UnityEngine.Object)(object)array[5];
							if (flag24)
							{
								break;
							}
							_003CSounds_003Eg__Add_007C55_0((AudioClip[])(object)array[7], ref obj8);
							obj35 = 0;
							list2 = list;
							obj36 = (UnityEngine.Object)(&obj8);
							obj26 = (UnityEngine.Object)(object)array[5];
						}
					}
					object obj41 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+68]");
					obj2 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v112+E4]");
					bool flag25 = (nint)0 == 0;
					object obj42 = !flag25;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag26 = obj2 != null;
					bool flag27 = !flag26;
					obj19 = 0;
					obj11 = null;
					if (!flag27)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+68]");
						array = (System.__Canon[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+68]");
						bool flag28 = (nint)0 == 0;
						obj23 = obj22;
						obj28 = obj24;
						obj10 = 0;
						obj11 = null;
						obj3 = obj26;
						if (flag28)
						{
							break;
						}
						_Canon = array[0];
						bool flag29 = array[0] == null;
						obj19 = 0;
						obj11 = null;
						if (!flag29)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+18]");
							bool flag30 = (nint)0 < (nint)1;
							obj19 = 0;
							obj11 = null;
							if (!flag30)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+18]");
								array = (System.__Canon[])(0 & 0xFFFFFFFFL);
								obj20 = array[0] + 32;
								obj23 = 0;
								obj10 = 0;
								List<System.__Canon> list4 = list2;
								obj25 = null;
								obj3 = obj26;
								UnityEngine.Object obj43 = obj2;
								while (true)
								{
									bool flag31 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<System.__Canon[], UIntPtr>(ref array);
									object obj44 = !flag31;
									obj22 = obj23;
									list2 = list4;
									obj26 = obj3;
									obj2 = obj43;
									if (obj44 != null)
									{
										break;
									}
									object obj45 = obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X28_v10+v463 @ X27_v1*8]");
									obj2 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v118+E4]");
									array = (System.__Canon[])0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X0_v118+E4]");
									bool flag32 = (nint)0 == 0;
									object obj46 = !flag32;
									if (obj46 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag33 = obj2 != null;
									bool flag34 = !flag33;
									obj11 = null;
									if (!flag34)
									{
										bool flag35 = (object)obj2 == null;
										obj28 = obj24;
										obj10 = 0;
										list2 = list4;
										obj11 = null;
										if (flag35)
										{
											goto end_IL_168f;
										}
										object obj47 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v123+E4]");
										bool flag36 = (nint)0 == 0;
										object obj48 = !flag36;
										if (obj48 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+48]");
										_003CSounds_003Eg__Add_007C55_0((AudioClip[])0, ref obj8);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+58]");
										_003CSounds_003Eg__Add_007C55_0((AudioClip[])0, ref obj8);
										list4 = list;
										obj11 = (UnityEngine.Object)(&obj8);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X20_v3 (UnityEngine.Object)+48]");
										obj3 = (UnityEngine.Object)0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+18]");
									array = (System.__Canon[])0;
									obj22 = obj23 + 1;
									object obj49 = obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X26_v11 (System.__Canon)+18]");
									bool flag37 = (nint)obj49 < 0;
									obj19 = 0;
									list2 = list4;
									obj26 = obj3;
									obj23 = obj22;
									obj10 = 0;
									obj25 = obj11;
									obj43 = obj2;
									if (flag37)
									{
										continue;
									}
									goto IL_0a95;
								}
								goto IL_14d9;
							}
						}
					}
					goto IL_0a95;
				}
				goto IL_14d9;
				IL_14d9:
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				obj11 = obj25;
				break;
				IL_0a95:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v37+18]");
				array = (System.__Canon[])0;
				obj28 = obj24 + 1;
				object obj50 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v37+18]");
				bool flag38 = (nint)obj50 < 0;
				obj23 = obj22;
				list3 = list2;
				obj3 = obj26;
				obj24 = obj28;
				obj10 = obj19;
				obj25 = obj11;
				if (flag38)
				{
					continue;
				}
				goto IL_0b07;
				continue;
				end_IL_168f:
				break;
			}
		}
		goto IL_14ef;
		IL_12e7:
		bool flag39 = list3 == null;
		GillaSpawnables gillaSpawnables;
		obj2 = gillaSpawnables;
		if (flag39)
		{
			goto IL_14ef;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA540]");
		obj3 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA538]");
		obj2 = (UnityEngine.Object)0;
		Enumerator<, > enumerator = list3.GetEnumerator();
		Enumerator<, > val = default;
		System.__Canon[] array2 = default;
		Enumerator<, > val2 = default;
		object obj58 = default;
		System.__Canon[] array3;
		while (true)
		{
			object obj53;
			Enumerator<, > val3;
			Enumerator<, > val4;
			if (val.MoveNext())
			{
				object obj51 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X0_v55+E4]");
				bool flag40 = (nint)0 == 0;
				object obj52 = !flag40;
				if (obj52 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag41 = (UnityEngine.Object)(object)array2 != null;
				bool flag42 = !flag41;
				obj10 = 0;
				if (!flag42)
				{
					bool flag43 = array2 == null;
					array3 = null;
					val = val2;
					obj53 = 0;
					val3 = val2;
					val4 = (Enumerator<, >)(ref val);
					obj10 = 0;
					num = (int)(&val);
					obj11 = null;
					if (flag43)
					{
						break;
					}
					AudioDataLoadState loadState = ((AudioClip)(object)array2).loadState;
					bool flag44 = loadState == 0;
					object obj54 = !flag44;
					obj10 = 0;
					if (obj54 == null)
					{
						bool flag45 = ((AudioClip)(object)array2).LoadAudioData();
						obj10 = 0;
					}
				}
				continue;
			}
			array3 = null;
			val = val2;
			obj53 = 0;
			val3 = val2;
			val4 = (Enumerator<, >)(ref val);
			num = (int)(&val);
			object obj55 = 0;
			while (true)
			{
				obj11 = obj2;
				((Enumerator<, >*)val4)->Dispose();
				bool flag46 = obj55 == null;
				object obj56 = !flag46;
				if (obj56 == null)
				{
					bool flag47 = array3 == null;
					object obj57 = !flag47;
					OutOfMemoryException ex2 = (OutOfMemoryException)val4;
					if (obj57 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj11 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					array3 = (System.__Canon[])1;
					array = (System.__Canon[])1;
					obj55 = obj53;
					continue;
				}
				if ((nint)obj11 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj55 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj53 = obj58;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F58C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
		}
		goto IL_150f;
		IL_1180:
		object obj59 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+A8]");
		gillaSpawnables = (GillaSpawnables)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X0_v71+E4]");
		array = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X0_v71+E4]");
		bool flag48 = (nint)0 == 0;
		object obj60 = !flag48;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag49 = gillaSpawnables != null;
		bool flag50 = !flag49;
		obj10 = 0;
		obj11 = null;
		if (!flag50)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+A8]");
			array = (System.__Canon[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+A8]");
			bool flag51 = (nint)0 == 0;
			obj10 = 0;
			obj11 = null;
			obj2 = gillaSpawnables;
			if (flag51)
			{
				goto IL_14ef;
			}
			object obj61 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ X0_v75+E4]");
			bool flag52 = (nint)0 == 0;
			object obj62 = !flag52;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			_003CSounds_003Eg__Add_007C55_0((AudioClip[])(object)array[12], ref obj8);
			obj10 = 0;
			list3 = list;
			obj11 = (UnityEngine.Object)(&obj8);
		}
		goto IL_12e7;
		IL_0b07:
		GillaSpawnables gillaSpawnables2 = GillaSpawnables.Get();
		array = (System.__Canon[])obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v6 (System.__Canon[])+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v6 (System.__Canon[])+E4]");
		bool flag53 = (nint)0 == 0;
		object obj63 = !flag53;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag54 = gillaSpawnables2 != null;
		bool flag55 = !flag54;
		object obj64 = 0;
		UnityEngine.Object obj65 = null;
		UnityEngine.Object obj66 = null;
		if (!flag55)
		{
			bool flag56 = (object)gillaSpawnables2 == null;
			obj10 = 0;
			obj11 = null;
			obj2 = gillaSpawnables2;
			if (flag56)
			{
				goto IL_14ef;
			}
			object obj67 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v90+E4]");
			array = (System.__Canon[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v90+E4]");
			bool flag57 = (nint)0 == 0;
			object obj68 = !flag57;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag58 = gillaSpawnables2.dynamite != null;
			bool flag59 = !flag58;
			obj64 = 0;
			obj65 = null;
			obj66 = null;
			if (!flag59)
			{
				bool flag60 = (object)gillaSpawnables2.dynamite == null;
				obj10 = 0;
				obj11 = null;
				obj2 = gillaSpawnables2;
				if (flag60)
				{
					goto IL_14ef;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA550]");
				object obj69 = 0;
				obj65 = (UnityEngine.Object)obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
				obj64 = 0;
				UnityEngine.Object obj70 = default;
				obj66 = obj70;
			}
		}
		object obj71 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v45+E4]");
		array = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v45+E4]");
		bool flag61 = (nint)0 == 0;
		object obj72 = !flag61;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag62 = obj66 != null;
		bool flag63 = !flag62;
		obj10 = 0;
		obj11 = null;
		gillaSpawnables = gillaSpawnables2;
		if (flag63)
		{
			goto IL_12e7;
		}
		bool flag64 = (object)obj66 == null;
		obj10 = 0;
		obj11 = null;
		obj2 = gillaSpawnables2;
		if (!flag64)
		{
			bool flag65 = list3 == null;
			obj10 = 0;
			obj11 = null;
			obj2 = gillaSpawnables2;
			if (!flag65)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA558]");
				obj3 = (UnityEngine.Object)0;
				array = list3._items;
				num = (int)obj3;
				int version = list3._version + 1;
				list3._version = version;
				bool flag66 = list3._items == null;
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+A0]");
				obj11 = (UnityEngine.Object)0;
				obj2 = gillaSpawnables2;
				if (!flag66)
				{
					version = list3._size;
					bool flag67 = list3._size < array.Length;
					object obj73 = !flag67;
					if (obj73 == null)
					{
						object obj74 = list3._items + list3._size;
						num = list3._size + 1;
						list3._size = num;
						object obj75 = obj74 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+A0]");
						obj75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj76 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v13 (System.Int32)+20]");
						object obj77 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v34+A8]");
						object obj78 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v35+70]");
						object obj76 = 0;
						List<System.__Canon> list5 = list3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+A0]");
						list5.AddWithResize((System.__Canon)0);
					}
					object obj79 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+98]");
					obj2 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X0_v66+E4]");
					array = (System.__Canon[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X0_v66+E4]");
					bool flag68 = (nint)0 == 0;
					object obj80 = !flag68;
					if (obj80 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag69 = obj2 != null;
					bool flag70 = !flag69;
					object obj81 = 0;
					System.__Canon _Canon2 = null;
					if (flag70)
					{
						goto IL_1180;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+98]");
					bool flag71 = (nint)0 == 0;
					obj10 = 0;
					obj11 = null;
					if (!flag71)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X19_v19 (UnityEngine.Object)+98]");
						AudioClip clip = ((AudioSource)0).clip;
						bool flag72 = list3 == null;
						obj10 = 0;
						obj11 = null;
						obj2 = (UnityEngine.Object)(object)list3;
						if (!flag72)
						{
							array = list3._items;
							num = (int)obj3;
							version = list3._version + 1;
							list3._version = version;
							bool flag73 = list3._items == null;
							obj10 = 0;
							obj11 = null;
							obj2 = (UnityEngine.Object)(object)list3;
							if (!flag73)
							{
								bool flag74 = list3._size < array.Length;
								object obj82 = !flag74;
								if (obj82 == null)
								{
									object obj83 = list3._items + list3._size;
									num = list3._size + 1;
									list3._size = num;
									object obj84 = obj83 + 32;
									obj84 = clip;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj81 = 0;
									_Canon2 = (System.__Canon)(object)clip;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X9_v13 (System.Int32)+20]");
									object obj85 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v32+A8]");
									object obj86 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v33+70]");
									obj81 = 0;
									list3.AddWithResize((System.__Canon)(object)clip);
									_Canon2 = (System.__Canon)(object)clip;
								}
								goto IL_1180;
							}
						}
					}
				}
			}
		}
		goto IL_14ef;
		IL_150f:
		throw new NullReferenceException();
		IL_14ef:
		NullReferenceException ex3 = new NullReferenceException();
		array3 = array2;
		val = (Enumerator<, >)0;
		goto IL_150f;
	}

	private void Piece(SkinnedMeshRenderer skin, Material[] mats)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_01ea: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA590]");
		object obj2 = 0;
		mesh.name = (string)obj2;
		skin.BakeMesh(mesh, useScale: false);
		List<System.__Canon> list = (List<System.__Canon>)(object)baked;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73A8]");
		object obj3 = 0;
		System.__Canon[] items = list._items;
		object obj4 = obj3;
		int version = list._version + 1;
		list._version = version;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA5A0]");
		object obj6 = 0;
		bool flag = list._size < items.Length;
		object obj7 = !flag;
		if (obj7 == null)
		{
			object obj8 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj9 = obj8 + 32;
			obj9 = mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag2 = false;
			System.__Canon _Canon = (System.__Canon)(object)mesh;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v4+20]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v8+A8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v9+70]");
			bool flag2 = false;
			list.AddWithResize((System.__Canon)(object)mesh);
			System.__Canon _Canon = (System.__Canon)(object)mesh;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj6);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
		object obj12 = 0;
		transform.SetParent(parent, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
		object obj13 = 0;
		MeshFilter meshFilter = default;
		meshFilter.sharedMesh = mesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA598]");
		object obj14 = 0;
		Renderer renderer = default;
		renderer.sharedMaterials = mats;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject2 = default;
		gameObject2._002Ector((string)obj14);
		Transform transform2 = gameObject2.transform;
		Transform parent2 = base.transform;
		transform2.SetParent(parent2, worldPositionStays: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Mesh sharedMesh = Four(mesh);
		MeshFilter meshFilter2 = default;
		meshFilter2.sharedMesh = sharedMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Renderer renderer2 = default;
		renderer2.sharedMaterials = mats;
	}

	private void PracticeParticles()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00f4: Expected VT, but got I4
		//IL_01c4: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I
		//IL_04e5: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I
		//IL_0527: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I4
		//IL_0130: Expected F4, but got I
		//IL_0140: Expected Obj, but got I
		//IL_017c: Expected F4, but got I
		//IL_017c: Expected F4, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_017c: Expected VT, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_0195: Expected VT, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0294: Expected Obj, but got I4
		//IL_02a2: Expected VT, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I4
		//IL_0338: Expected F4, but got I
		//IL_0338: Expected F4, but got I
		//IL_0338: Expected F4, but got I
		//IL_0338: Expected F4, but got I
		//IL_0338: Expected Obj, but got I4
		//IL_0338: Expected VT, but got I
		//IL_0338: Expected VT, but got I
		//IL_034d: Expected Obj, but got I
		//IL_035d: Expected F4, but got I
		//IL_0366: Expected Obj, but got I4
		//IL_0376: Expected VT, but got I
		//IL_05b5: Expected Obj, but got I
		//IL_05c5: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I
		//IL_0607: Expected Obj, but got I4
		//IL_047d: Expected F4, but got I
		//IL_047d: Expected F4, but got I
		//IL_047d: Expected F4, but got I
		//IL_047d: Expected F4, but got I
		//IL_047d: Expected Obj, but got I4
		//IL_047d: Expected VT, but got I
		//IL_047d: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+50]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		Material material = null;
		Vector3 vector = (Vector3)0;
		if (!flag6)
		{
			Transform at = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj11 = 0;
			object obj12 = obj10;
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v34+A0]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v56+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+50]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+1C]");
			Blood.Spray(at, (Vector3)num2, (Material)2, num3, 1, 0, 0f);
			material = (Material)2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+50]");
			vector = (Vector3)0;
		}
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+30]");
		bool flag9 = (UnityEngine.Object)0 == null;
		bool flag10 = !flag9;
		object obj19 = !flag10;
		if (obj19 != null)
		{
			return;
		}
		object obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v19+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+38]");
		bool flag12 = (UnityEngine.Object)0 != null;
		bool flag13 = !flag12;
		Material material2 = (Material)1;
		Mesh mesh = null;
		Vector3 vector2 = (Vector3)0;
		if (!flag13)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj23 = 0;
			object obj24 = obj22;
			object obj25 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v25+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v44+E4]");
			bool flag14 = (nint)0 == 0;
			object obj27 = !flag14;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+30]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+38]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+18]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+1C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+20]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v26+18]");
			GillaWounds.Chunks((Vector3)num4, (Vector3)num5, (Mesh)1, null, 0, num6, num7, num8, 0f);
			material2 = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v26+1C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v26+18]");
			float num = 0f;
			mesh = (Mesh)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+38]");
			vector2 = (Vector3)0;
		}
		object obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v24+E4]");
		bool flag15 = (nint)0 == 0;
		object obj29 = !flag15;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+40]");
		if ((UnityEngine.Object)0 != null)
		{
			Transform transform2 = base.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj31 = 0;
			object obj32 = obj30;
			object obj33 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v16+A0]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v32+E4]");
			bool flag16 = (nint)0 == 0;
			object obj35 = !flag16;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+30]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (UnityEngine.Object)+40]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+18]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+1C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v35+20]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v17+18]");
			GillaWounds.Chunks((Vector3)num9, (Vector3)num10, (Mesh)1, null, 0, num11, num12, num13, 0f);
		}
	}

	private static Mesh MeshOf(Renderer r)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		if ((object)r != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A38]");
			object obj = 0;
			object obj2 = obj;
			nint num = (nint)r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7 (Il2CppClass<UnityEngine.Renderer>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X10_v3+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7 (Il2CppClass<UnityEngine.Renderer>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X10_v3+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X11_v6-8]");
				if (0 == (nint)obj2)
				{
					return ((SkinnedMeshRenderer)r).sharedMesh;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4A30]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7 (Il2CppClass<UnityEngine.Renderer>)+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v6+130]");
			bool flag2 = num4 < 0;
			object obj8 = !flag2;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7 (Il2CppClass<UnityEngine.Renderer>)+B0]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v6+130]");
				object obj10 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v9-8]");
				if (0 == (nint)obj7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75D8]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358FD54");
					object obj13 = default;
					object obj12 = obj13 & 1;
					if (obj12 != null)
					{
						MeshFilter meshFilter = default;
						if ((object)meshFilter != null)
						{
							return meshFilter.sharedMesh;
						}
						return (Mesh)(object)new NullReferenceException();
					}
				}
			}
		}
		return null;
	}

	private static IEnumerable<GameObject> Prefabs()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA448]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		return (IEnumerable<GameObject>)obj2;
	}

	private static IEnumerable<Material> Others()
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 4294967294L;
		int currentManagedThreadId = Environment.CurrentManagedThreadId;
		return (IEnumerable<Material>)obj2;
	}

	private void Speck(Mesh mesh, Material[] mats, Renderer like, bool lightmapped)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_0294: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA450]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector((string)obj2);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		transform.SetParent(parent, worldPositionStays: false);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int layer2;
		if (like != null)
		{
			GameObject gameObject2 = like.gameObject;
			int layer = gameObject2.layer;
			layer2 = layer;
		}
		else
		{
			layer2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
		object obj6 = 0;
		gameObject.layer = layer2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = mesh != null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		Mesh sharedMesh = mesh;
		if (obj9 == null)
		{
			Mesh mesh2 = Little();
			sharedMesh = mesh2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
		object obj10 = 0;
		MeshFilter meshFilter = default;
		meshFilter.sharedMesh = sharedMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Renderer renderer = default;
		renderer.sharedMaterials = mats;
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (like != null)
		{
			ShadowCastingMode shadowCastingMode = like.shadowCastingMode;
			renderer.shadowCastingMode = shadowCastingMode;
		}
		if (lightmapped)
		{
			int lightmapIndex = like.lightmapIndex;
			renderer.lightmapIndex = lightmapIndex;
			Vector4 lightmapScaleOffset = like.lightmapScaleOffset;
			renderer.lightmapScaleOffset = (Vector4)0;
		}
		int num = Specks__BackingField + 1;
		Specks__BackingField = num;
	}

	private Mesh Little()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_0121: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I
		//IL_0841: Expected Obj, but got I8
		//IL_0168: Expected Obj, but got I
		//IL_087a: Expected Obj, but got I4
		//IL_088a: Expected Obj, but got I4
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected Obj, but got Unknown
		//IL_019f: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I8
		//IL_0251: Expected Obj, but got I
		//IL_029d: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_04a0: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I4
		//IL_053c: Expected Obj, but got I4
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_090b: Expected Obj, but got I8
		//IL_0632: Expected Obj, but got I
		//IL_0944: Expected Obj, but got I4
		//IL_0954: Expected Obj, but got I4
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_065c: Expected Obj, but got I
		//IL_06a8: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I4
		//IL_0700: Expected Obj, but got I4
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_07ac;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		if ((object)mesh != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA350]");
			object obj7 = 0;
			mesh.name = (string)obj7;
			obj3 = mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Vector3[] array = default;
			if (array != null)
			{
				if (array.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X9_v4+A0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X9_v5+8]");
					_ = 0;
					object obj12 = array.Length & 0xFFFFFFFEL;
					if (obj12 != null)
					{
						object obj13 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X9_v7+A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X9_v8+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X9_v8+20]");
						_ = 0;
						bool flag4 = array.Length < 2;
						object obj15 = !flag4;
						object obj16 = array.Length - 2;
						bool flag5 = obj16 == null;
						object obj17 = ~obj15;
						object obj18 = obj17 | flag5;
						if (obj18 == null)
						{
							object obj19 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v16+A0]");
							object obj20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v17+3C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v17+44]");
							_ = 0;
							if (obj3 != null)
							{
								((Mesh)obj3).SetVertices(array);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								Vector3[] array2 = default;
								if (array2 != null)
								{
									if (array2.Length != 0)
									{
										object obj21 = obj9;
										object obj22 = array2.Length & 0xFFFFFFFEL;
										bool flag6 = obj22 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X9_v10+A0]");
										object obj23 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X9_v11+54]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X9_v11+5C]");
										_ = 0;
										if (!flag6)
										{
											object obj24 = obj9;
											bool flag7 = array2.Length < 2;
											object obj25 = !flag7;
											object obj26 = array2.Length - 2;
											bool flag8 = obj26 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X9_v12+A0]");
											object obj27 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X9_v13+54]");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X9_v13+5C]");
											_ = 0;
											object obj28 = ~obj25;
											object obj29 = obj28 | flag8;
											if (obj29 == null)
											{
												object obj30 = obj9;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v21+A0]");
												object obj31 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v22+54]");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v22+5C]");
												_ = 0;
												if (obj3 != null)
												{
													((Mesh)obj3).SetNormals(array2);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87F8]");
													object obj32 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
													Vector4[] array3 = default;
													if (array3 != null)
													{
														if (array3.Length != 0)
														{
															bool flag9 = array3.Length == 1;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
															_ = 0;
															if (!flag9)
															{
																bool flag10 = array3.Length < 2;
																object obj33 = !flag10;
																object obj34 = array3.Length - 2;
																bool flag11 = obj34 == null;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
																_ = 0;
																object obj35 = ~obj33;
																object obj36 = obj35 | flag11;
																if (obj36 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
																	_ = 0;
																	if (obj3 != null)
																	{
																		((Mesh)obj3).SetTangents(array3);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C85B8]");
																		object obj37 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																		Color[] array4 = default;
																		if (array4 != null)
																		{
																			if (array4.Length != 0)
																			{
																				bool flag12 = array4.Length == 1;
																				_ = 0;
																				if (!flag12)
																				{
																					bool flag13 = array4.Length < 2;
																					object obj38 = !flag13;
																					object obj39 = array4.Length - 2;
																					bool flag14 = obj39 == null;
																					_ = 0;
																					object obj40 = ~obj38;
																					object obj41 = obj40 | flag14;
																					if (obj41 == null)
																					{
																						_ = 0;
																						if (obj3 != null)
																						{
																							((Mesh)obj3).SetColors(array4);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
																							object obj42 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																							Vector2[] array5 = default;
																							if (array5 != null)
																							{
																								if (array5.Length != 0)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
																									object obj43 = 0;
																									object obj44 = obj43;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X9_v15+A0]");
																									object obj45 = 0;
																									object obj46 = array5.Length & 0xFFFFFFFEL;
																									if (obj46 != null)
																									{
																										object obj47 = obj43;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v19+A0]");
																										object obj48 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X9_v20+10]");
																										_ = 0;
																										bool flag15 = array5.Length < 2;
																										object obj49 = !flag15;
																										object obj50 = array5.Length - 2;
																										bool flag16 = obj50 == null;
																										object obj51 = ~obj49;
																										object obj52 = obj51 | flag16;
																										if (obj52 == null)
																										{
																											object obj53 = obj43;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v36+A0]");
																											object obj54 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v37+28]");
																											_ = 0;
																											if (obj3 != null)
																											{
																												((Mesh)obj3).SetUVs(0, array5);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
																												object obj55 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																												int[] array6 = default;
																												if (array6 != null)
																												{
																													bool flag17 = array6.Length < 1;
																													object obj56 = !flag17;
																													object obj57 = array6.Length - 1;
																													bool flag18 = obj57 == null;
																													object obj58 = ~obj56;
																													object obj59 = obj58 | flag18;
																													if (obj59 == null)
																													{
																														bool flag19 = array6.Length == 2;
																														array6[1] = 1;
																														if (!flag19)
																														{
																															array6[2] = 2;
																															if (obj3 != null)
																															{
																																((Mesh)obj3).SetTriangles(array6, 0);
																																goto IL_07ac;
																															}
																															goto IL_07bf;
																														}
																													}
																													goto IL_07b1;
																												}
																											}
																											goto IL_07bf;
																										}
																									}
																								}
																								goto IL_07b1;
																							}
																						}
																						goto IL_07bf;
																					}
																				}
																			}
																			goto IL_07b1;
																		}
																	}
																	goto IL_07bf;
																}
															}
														}
														goto IL_07b1;
													}
												}
												goto IL_07bf;
											}
										}
									}
									goto IL_07b1;
								}
							}
							goto IL_07bf;
						}
					}
				}
				goto IL_07b1;
			}
		}
		goto IL_07bf;
		IL_07b1:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_07bf;
		IL_07bf:
		return (Mesh)(object)new NullReferenceException();
		IL_07ac:
		return (Mesh)obj3;
	}

	private unsafe void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_12e9: Expected Obj, but got I
		//IL_130b: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_008f: Expected VT, but got I4
		//IL_00f3: Expected VT, but got I4
		//IL_0167: Expected VT, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01f7: Expected VT, but got I4
		//IL_01f7: Expected VT, but got I4
		//IL_0243: Expected VT, but got I4
		//IL_024c: Expected VT, but got I4
		//IL_0722: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got VT
		//IL_026c: Expected Obj, but got I4
		//IL_02c2: Expected VT, but got I4
		//IL_02cb: Expected VT, but got I4
		//IL_02ed: Expected Obj, but got I8
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I4
		//IL_0350: Expected VT, but got I4
		//IL_1178: Expected Obj, but got I4
		//IL_079a: Expected Obj, but got Ref
		//IL_1333: Expected Obj, but got I4
		//IL_1072: Expected Obj, but got I4
		//IL_10b7: Expected VT, but got I4
		//IL_07b8: Expected Obj, but got I
		//IL_07c8: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I4
		//IL_14bd: Expected I, but got Obj
		//IL_14cd: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I4
		//IL_03f2: Expected VT, but got I4
		//IL_03fb: Expected VT, but got I4
		//IL_10e7: Expected VT, but got I4
		//IL_0894: Expected VT, but got I4
		//IL_064a: Expected Obj, but got I4
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_06ee: Expected Obj, but got VT
		//IL_1410: Expected Obj, but got I
		//IL_1423: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Expected Obj, but got Unknown
		//IL_07fc: Expected Obj, but got I
		//IL_047f: Expected VT, but got I4
		//IL_1113: Expected VT, but got I4
		//IL_0dc4: Expected Obj, but got I4
		//IL_0dd1: Expected Obj, but got Ref
		//IL_0dd9: Expected Obj, but got Ref
		//IL_0de2: Expected Obj, but got I4
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected Obj, but got Unknown
		//IL_15b5: Expected Obj, but got I
		//IL_08f9: Expected Obj, but got I4
		//IL_0906: Expected Obj, but got Ref
		//IL_090e: Expected Obj, but got Ref
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected Obj, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got I
		//IL_150c: Expected Obj, but got I4
		//IL_081f: Expected Obj, but got I
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_0534: Expected VT, but got I4
		//IL_0dff: Expected Obj, but got I
		//IL_0934: Expected I, but got Obj
		//IL_0944: Expected Obj, but got I
		//IL_0eed: Expected Obj, but got I4
		//IL_0e9e: Expected VT, but got I4
		//IL_0a17: Expected VT, but got I4
		//IL_055a: Expected VT, but got I4
		//IL_055a: Expected VT, but got I4
		//IL_1556: Expected Obj, but got I
		//IL_0e3a: Expected Obj, but got I
		//IL_097f: Expected Obj, but got I
		//IL_126b: Expected Obj, but got I4
		//IL_0581: Expected Obj, but got I
		//IL_0be2: Expected Obj, but got I4
		//IL_0bef: Expected Obj, but got Ref
		//IL_0bf7: Expected Obj, but got Ref
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_1465: Expected Obj, but got Unknown
		//IL_12c2: Expected Obj, but got I4
		//IL_05a9: Expected VT, but got I4
		//IL_05a9: Expected Obj, but got I
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Expected Obj, but got Unknown
		//IL_0a6a: Expected I, but got Obj
		//IL_0a7a: Expected Obj, but got I
		//IL_0a8a: Expected Obj, but got I
		//IL_0ab3: Expected Obj, but got I4
		//IL_0ac5: Expected Obj, but got I4
		//IL_0ad2: Expected Obj, but got Ref
		//IL_0ada: Expected Obj, but got Ref
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected Obj, but got Unknown
		//IL_05da: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I4
		//IL_0632: Expected VT, but got I4
		//IL_063b: Expected VT, but got I4
		//IL_0f42: Expected Obj, but got I4
		//IL_0e55: Expected Obj, but got I
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected Obj, but got Unknown
		//IL_0c4f: Expected Obj, but got I4
		//IL_0c5c: Expected Obj, but got Ref
		//IL_0c64: Expected Obj, but got Ref
		//IL_09a2: Expected Obj, but got I
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_0b15: Expected Obj, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0b69: Expected Obj, but got I
		//IL_0b79: Expected Obj, but got I
		//IL_0b82: Expected Obj, but got I4
		//IL_0b8f: Expected Obj, but got Ref
		//IL_0b97: Expected Obj, but got Ref
		//IL_0fac: Expected Obj, but got I
		//IL_0fd6: Expected Obj, but got I4
		//IL_0cd1: Expected Obj, but got I4
		//IL_0ffd: Expected VT, but got I4
		//IL_0d82: Expected Obj, but got I4
		//IL_0d0c: Expected Obj, but got I4
		//IL_0d19: Expected Obj, but got Ref
		//IL_0d21: Expected Obj, but got Ref
		//IL_0d63: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v3+E4]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = main == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		bool flag4 = (object)main == null;
		IEnumerator enumerator = null;
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		float num2 = default;
		float num = num2;
		Quaternion quaternion = (Quaternion)0;
		UnityEngine.Object obj10 = null;
		float num5;
		Vector3 vector;
		bool flag9 = default;
		Transform transform4 = default;
		Camera[] array;
		float num7 = default;
		if (!flag4)
		{
			Transform transform = main.transform;
			Transform transform2 = base.transform;
			bool flag5 = (object)transform == null;
			enumerator = null;
			obj6 = obj7;
			obj8 = obj9;
			num = num2;
			quaternion = (Quaternion)0;
			obj10 = null;
			if (!flag5)
			{
				Vector3 position = transform.position;
				Vector3 forward = transform.forward;
				Quaternion rotation = transform.rotation;
				bool flag6 = (object)transform2 == null;
				enumerator = null;
				obj6 = obj7;
				obj8 = obj9;
				num = num2;
				quaternion = (Quaternion)0;
				obj10 = null;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					object obj11 = obj7 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					object obj12 = obj9 * 0;
					float num3 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
					float num4 = num3 * 0f;
					obj6 = obj7 + obj11;
					obj8 = obj9 + obj12;
					num = num2 + num4;
					transform2.SetPositionAndRotation((Vector3)0, (Quaternion)0);
					array = lensCopies;
					bool flag7 = lensCopies == null;
					num5 = num2;
					float num6 = num7;
					float num8 = num7;
					object obj13 = obj7;
					object obj14 = obj9;
					quaternion = (Quaternion)0;
					vector = (Vector3)0;
					if (!flag7)
					{
						object obj15 = array.Length - 1;
						bool flag8 = obj15 == null;
						flag9 = array.Length < 1;
						num5 = num2;
						num6 = num7;
						num8 = num7;
						obj13 = obj7;
						obj14 = obj9;
						quaternion = (Quaternion)0;
						vector = (Vector3)0;
						if (!flag9)
						{
							object obj16 = array.Length & 0xFFFFFFFFL;
							object obj17 = lensCopies + 32;
							Transform transform3 = transform4;
							object obj18 = 0;
							float num9 = num2;
							object obj19 = obj8;
							float num10 = num7;
							float num11 = num7;
							float num12 = num;
							object obj20 = obj7;
							object obj21 = obj9;
							Quaternion quaternion2 = (Quaternion)0;
							obj10 = null;
							while (true)
							{
								bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
								object obj22 = !flag10;
								enumerator = null;
								transform4 = transform3;
								object obj23 = obj18;
								obj6 = obj6;
								num7 = num9;
								obj8 = obj19;
								num6 = num10;
								num8 = num11;
								num = num12;
								obj13 = obj20;
								obj14 = obj21;
								quaternion = quaternion2;
								if (obj22 != null)
								{
									break;
								}
								object obj24 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X0_v114+E4]");
								bool flag11 = (nint)0 == 0;
								object obj25 = !flag11;
								if (obj25 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
								bool flag12 = (UnityEngine.Object)0 == null;
								bool flag13 = !flag12;
								object obj26 = !flag13;
								num5 = num9;
								obj8 = obj19;
								num = num12;
								quaternion = (Quaternion)0;
								vector = (Vector3)0;
								if (obj26 != null)
								{
									goto IL_0640;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
								bool flag14 = (nint)0 == 0;
								enumerator = null;
								transform4 = transform3;
								obj23 = obj18;
								obj6 = obj6;
								num7 = num9;
								obj8 = obj19;
								num6 = num10;
								num8 = num11;
								num = num12;
								obj13 = obj20;
								obj14 = obj21;
								quaternion = (Quaternion)0;
								obj10 = null;
								if (!flag14)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
									Transform transform5 = ((Component)0).transform;
									Vector3 position2 = transform.position;
									Quaternion rotation2 = transform.rotation;
									bool flag15 = (object)transform5 == null;
									enumerator = null;
									transform4 = transform5;
									obj23 = obj18;
									obj6 = obj6;
									num7 = num9;
									obj8 = obj19;
									num6 = num10;
									num8 = num11;
									num = num12;
									obj13 = obj20;
									obj14 = obj21;
									quaternion = (Quaternion)0;
									obj10 = null;
									if (!flag15)
									{
										transform5.SetPositionAndRotation((Vector3)0, (Quaternion)0);
										CameraClearFlags clearFlags = main.clearFlags;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
										((Camera)0).clearFlags = clearFlags;
										Color backgroundColor = main.backgroundColor;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
										((Camera)0).backgroundColor = (Color)0;
										num = main.farClipPlane;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
										((Camera)0).farClipPlane = num;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X27_v3+v281 @ X26_v16*8]");
										((UnityEngine.Behaviour)0).enabled = true;
										transform3 = transform5;
										num5 = num12;
										obj8 = 1112014848;
										num10 = num9;
										num11 = num9;
										obj20 = obj6;
										obj21 = obj19;
										quaternion = (Quaternion)0;
										vector = (Vector3)1;
										goto IL_0640;
									}
								}
								goto IL_11ad;
								IL_0640:
								obj16 = array.Length;
								obj23 = obj18 + 1;
								obj15 = obj23 - array.Length;
								flag8 = obj15 == null;
								flag9 = (nint)obj23 < array.Length;
								transform4 = transform3;
								obj6 = obj6;
								num6 = num10;
								num8 = num11;
								obj13 = obj20;
								obj14 = obj21;
								obj18 = obj23;
								num9 = num5;
								obj19 = obj8;
								num12 = num;
								quaternion2 = quaternion;
								obj10 = (UnityEngine.Object)vector;
								if (flag9)
								{
									continue;
								}
								goto IL_06fc;
							}
							goto IL_11c6;
						}
					}
					goto IL_06fc;
				}
			}
		}
		goto IL_11ad;
		IL_120c:
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_121a;
		IL_06fc:
		int num13 = frame;
		bool flag16 = frame == 0;
		object obj27 = !flag16;
		enumerator = null;
		obj10 = (UnityEngine.Object)vector;
		if (obj27 != null)
		{
			goto IL_139f;
		}
		Transform transform6 = base.transform;
		bool flag17 = (object)transform6 == null;
		enumerator = null;
		num7 = num5;
		obj10 = null;
		if (flag17)
		{
			goto IL_11ad;
		}
		IEnumerator enumerator2 = transform6.GetEnumerator();
		bool flag18 = enumerator2 == null;
		object obj28 = default;
		obj3 = (object)(&obj28);
		if (flag18)
		{
			goto IL_0db0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		transform4 = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4648]");
		array = (Camera[])0;
		object obj30 = default;
		object obj29 = obj30;
		IEnumerator enumerator3 = enumerator2;
		Quaternion quaternion3 = quaternion;
		Component component = default;
		object obj36 = default;
		OutOfMemoryException ex2 = default;
		object obj44 = default;
		object obj38;
		object obj37;
		while (true)
		{
			nint num14 = (nint)enumerator3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v45 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v45 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0881;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v45 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj31 = (nint)0 + (nint)8;
			bool flag19 = flag9;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X10_v35-8]");
				object obj15 = 0 - transform4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ X10_v35-8]");
				if (0 == (nint)transform4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X8_v45 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj3 = -1;
				obj15 = obj3 - 1;
				bool flag8 = obj15 == null;
				obj29 = obj31 + 16;
				flag9 = (nint)obj3 != 1;
				obj31 = obj29;
				flag19 = flag9;
				if (flag9)
				{
					continue;
				}
				goto IL_0881;
			}
			obj3 = obj31;
			object obj32 = num14 + obj31;
			object obj33 = obj32 + 312;
			obj29 = obj31;
			flag9 = flag19;
			quaternion = quaternion3;
			goto IL_1400;
			IL_148e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1474 @ X0_v96] (should have been resolved before IL gen)");
			if ((object)component == null)
			{
				goto IL_0bb5;
			}
			obj10 = (UnityEngine.Object)(object)array;
			nint num15 = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v53 (Il2CppClass<UnityEngine.Component>)+130]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X1_v18 (UnityEngine.Object)+130]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v53 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X1_v18 (UnityEngine.Object)+130]");
			bool flag20 = num16 < 0;
			object obj34 = !flag20;
			object obj35 = ~obj34;
			obj36 = 0;
			ex2 = null;
			obj37 = (object)(&obj28);
			obj38 = (object)(&enumerator);
			enumerator = enumerator2;
			num7 = num5;
			object obj40;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v53 (Il2CppClass<UnityEngine.Component>)+B0]");
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X1_v18 (UnityEngine.Object)+130]");
				object obj39 = num17 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X8_v55-8]");
				object obj15 = 0 - obj10;
				bool flag8 = obj15 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1493 @ X8_v55-8]");
				flag9 = 0 != (nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v53 (Il2CppClass<UnityEngine.Component>)+130]");
				obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X1_v18 (UnityEngine.Object)+130]");
				obj40 = 0;
				obj36 = 0;
				ex2 = null;
				obj37 = (object)(&obj28);
				obj38 = (object)(&enumerator);
				enumerator = enumerator2;
				num7 = num5;
				if (!flag9)
				{
					goto IL_0bb5;
				}
			}
			goto IL_11b8;
			IL_0bb5:
			int cullingMask = main.cullingMask;
			bool flag21 = (object)component == null;
			obj30 = obj29;
			obj36 = 0;
			ex2 = null;
			obj37 = (object)(&obj28);
			obj38 = (object)(&enumerator);
			enumerator = enumerator2;
			num7 = num5;
			obj10 = null;
			obj3 = obj40;
			if (flag21)
			{
				goto IL_11d4;
			}
			GameObject gameObject = component.gameObject;
			bool flag22 = (object)gameObject == null;
			obj30 = obj29;
			obj36 = 0;
			ex2 = null;
			obj37 = (object)(&obj28);
			obj38 = (object)(&enumerator);
			enumerator = enumerator2;
			num7 = num5;
			obj10 = null;
			obj3 = obj40;
			if (!flag22)
			{
				int layer = gameObject.layer;
				int num18 = cullingMask >> layer;
				int num19 = num18 & 1;
				bool flag23 = num19 == 0;
				object obj41 = !flag23;
				if (obj41 == null)
				{
					GameObject gameObject2 = component.gameObject;
					bool flag24 = (object)gameObject2 == null;
					obj30 = obj29;
					obj36 = 0;
					ex2 = null;
					obj37 = (object)(&obj28);
					obj38 = (object)(&enumerator);
					enumerator = enumerator2;
					num7 = num5;
					obj10 = null;
					obj3 = obj40;
					if (flag24)
					{
						goto IL_11fe;
					}
					gameObject2.layer = 0;
					quaternion = (Quaternion)0;
				}
				bool flag25 = enumerator2 == null;
				object obj42 = !flag25;
				obj30 = obj29;
				obj3 = obj40;
				enumerator3 = enumerator2;
				quaternion3 = quaternion;
				if (obj42 != null)
				{
					continue;
				}
				goto IL_0db0;
			}
			goto IL_11e2;
			IL_0a04:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			quaternion = (Quaternion)1;
			goto IL_148e;
			IL_0881:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			quaternion = (Quaternion)0;
			goto IL_1400;
			IL_1400:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X0_v93+8]");
			obj10 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1321 @ X0_v93] (should have been resolved before IL gen)");
			object obj43 = obj44 & 1;
			bool flag26 = obj43 == null;
			obj30 = obj29;
			if (flag26)
			{
				break;
			}
			bool flag27 = enumerator2 == null;
			obj30 = obj29;
			obj36 = 0;
			ex2 = null;
			obj37 = (object)(&obj28);
			obj38 = (object)(&enumerator);
			enumerator = enumerator2;
			num7 = num5;
			if (flag27)
			{
				goto IL_11f0;
			}
			nint num20 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X8_v48 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X8_v48 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a04;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X8_v48 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj45 = (nint)0 + (nint)8;
			bool flag28 = flag9;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ X10_v30-8]");
				object obj15 = 0 - transform4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ X10_v30-8]");
				if (0 == (nint)transform4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X8_v48 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj40 = -1;
				obj15 = obj40 - 1;
				bool flag8 = obj15 == null;
				obj29 = obj45 + 16;
				flag9 = (nint)obj40 != 1;
				obj45 = obj29;
				flag28 = flag9;
				if (flag9)
				{
					continue;
				}
				goto IL_0a04;
			}
			obj40 = obj45 + 1;
			object obj46 = num20 + obj40;
			object obj47 = obj46 + 312;
			obj29 = obj45;
			flag9 = flag28;
			goto IL_148e;
		}
		obj36 = 0;
		ex2 = null;
		obj37 = (object)(&obj28);
		obj38 = (object)(&enumerator);
		object obj48 = 10;
		goto IL_15a5;
		IL_11e2:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_11f0;
		IL_11ad:
		throw new NullReferenceException();
		IL_11c6:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_11d4;
		IL_121a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj10 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj36 = 1;
		}
		else
		{
			if ((nint)obj10 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CE48");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj49 = default;
			ex2 = (OutOfMemoryException)obj49;
		}
		num5 = num7;
		obj48 = 0;
		goto IL_15a5;
		IL_15a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		object obj50 = 0;
		obj10 = (UnityEngine.Object)obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
		object obj51 = default;
		obj37 = obj51;
		if (obj51 == null)
		{
			goto IL_14f2;
		}
		object obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v14+12E]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e8b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v14+98]");
		object obj53 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ X10_v8-8]");
			if (0 == (nint)obj50)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ X8_v14+12E]");
			obj3 = -1;
			obj30 = obj53 + 16;
			bool flag29 = (nint)obj3 != 1;
			obj53 = obj30;
			if (flag29)
			{
				continue;
			}
			goto IL_0e8b;
		}
		obj3 = obj53;
		object obj54 = obj52 + obj53;
		object obj55 = obj54 + 312;
		obj30 = obj53;
		goto IL_1546;
		IL_11fe:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_120c;
		IL_11d4:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_11e2;
		IL_14f2:
		bool flag30 = ex2 == null;
		object obj56 = !flag30;
		num7 = num5;
		if (obj56 != null)
		{
			goto IL_120c;
		}
		bool flag31 = obj36 == null;
		object obj57 = !flag31;
		num7 = num5;
		ex = ex2;
		if (obj57 != null)
		{
			goto IL_121a;
		}
		if ((nint)obj48 != 10)
		{
			bool flag32 = obj48 == null;
			object obj58 = !flag32;
			if (obj58 != null)
			{
				return;
			}
		}
		PracticeParticles();
		Transform transform7 = base.transform;
		bool flag33 = (object)transform7 == null;
		num7 = num5;
		obj10 = null;
		if (flag33)
		{
			goto IL_11ad;
		}
		Vector3 position3 = transform7.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj59 = 0;
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X0_v17+E4]");
		bool flag34 = (nint)0 == 0;
		object obj61 = !flag34;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Blood.WarmChain((Vector3)0);
		num13 = frame;
		obj10 = null;
		goto IL_139f;
		IL_1546:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ X0_v21+8]");
		obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1392 @ X0_v21] (should have been resolved before IL gen)");
		goto IL_14f2;
		IL_0e8b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		quaternion = (Quaternion)0;
		goto IL_1546;
		IL_0db0:
		throw new NullReferenceException();
		IL_11b8:
		InvalidCastException ex7 = new InvalidCastException();
		goto IL_11c6;
		IL_11f0:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_11fe;
		IL_139f:
		if (num13 == 2)
		{
			bool flag35 = (object)lamp == null;
			num7 = num5;
			if (flag35)
			{
				goto IL_11ad;
			}
			lamp.enabled = true;
			object obj62 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ X0_v37+E4]");
			bool flag36 = (nint)0 == 0;
			object obj63 = !flag36;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag37 = dread != null;
			bool flag38 = !flag37;
			quaternion = (Quaternion)0;
			if (!flag38)
			{
				bool flag39 = (object)dread == null;
				num7 = num5;
				quaternion = (Quaternion)0;
				obj10 = null;
				if (flag39)
				{
					goto IL_11ad;
				}
				dread.enabled = true;
				quaternion = (Quaternion)0;
			}
		}
		int num21 = frame;
		if (frame == 4)
		{
			GameObject obj64 = base.gameObject;
			object obj65 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X8_v23+E4]");
			bool flag40 = (nint)0 == 0;
			object obj66 = !flag40;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj64);
			num21 = frame;
		}
		int num22 = num21 + 1;
		frame = num22;
	}

	private unsafe void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0a68: Expected Obj, but got I
		//IL_0a7a: Expected I, but got Obj
		//IL_0a88: Expected I, but got Obj
		//IL_0267: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_03a0: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I8
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00b1: Expected I, but got Obj
		//IL_0475: Expected Obj, but got I4
		//IL_0aaf: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I4
		//IL_054a: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_04ee: Expected Obj, but got I4
		//IL_061f: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_05c3: Expected Obj, but got I4
		//IL_06e2: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I4
		//IL_0698: Expected Obj, but got I4
		//IL_01bf: Expected Obj, but got I4
		//IL_077f: Expected Obj, but got I
		//IL_07a1: Expected Obj, but got I4
		//IL_080a: Expected Obj, but got I
		//IL_081a: Expected Obj, but got I
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected Obj, but got Ref
		//IL_092b: Expected Obj, but got I4
		//IL_0934: Expected Obj, but got I4
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got I4
		//IL_0b12: Expected Obj, but got I4
		//IL_0857: Expected Obj, but got I
		//IL_0879: Expected Obj, but got I4
		//IL_0964: Expected Obj, but got I4
		//IL_096c: Expected Obj, but got Ref
		//IL_08f1: Expected Obj, but got I4
		//IL_09f3: Expected Obj, but got I4
		//IL_0a04: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA568]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA578]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		nint num = (nint)obj2;
		Action<ScriptableRenderContext, System.__Canon> action = default;
		action._002Ector((object)this, (IntPtr)obj2);
		RenderPipelineManager.endCameraRendering -= (Action<ScriptableRenderContext, Camera>)action;
		Camera[] array = lensCopies;
		bool flag = lensCopies == null;
		UnityEngine.Object obj4 = null;
		Action<ScriptableRenderContext, System.__Canon> action2;
		nint num2;
		UnityEngine.Object obj8;
		object obj5;
		if (!flag)
		{
			bool flag2 = array.Length < 1;
			obj4 = null;
			if (!flag2)
			{
				obj5 = array.Length & 0xFFFFFFFFL;
				object obj6 = lensCopies + 32;
				object obj7 = 0;
				obj8 = null;
				num2 = (nint)obj2;
				action2 = action;
				while (true)
				{
					bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
					object obj9 = !flag3;
					if (obj9 == null)
					{
						object obj10 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X24_v1+v151 @ X23_v8*8]");
						action2 = (Action<ScriptableRenderContext, System.__Canon>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v103+E4]");
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v103+E4]");
						bool flag4 = (nint)0 == 0;
						object obj11 = !flag4;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag5 = (UnityEngine.Object)(object)action2 != null;
						bool flag6 = !flag5;
						obj4 = null;
						object obj12;
						if (!flag6)
						{
							bool flag7 = action2 == null;
							obj12 = obj7;
							obj8 = null;
							num2 = 0;
							if (flag7)
							{
								break;
							}
							GameObject gameObject = ((Component)(object)action2).gameObject;
							object obj13 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v40+E4]");
							bool flag8 = (nint)0 == 0;
							object obj14 = !flag8;
							if (obj14 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object.Destroy(gameObject);
							obj4 = null;
							action2 = (Action<ScriptableRenderContext, System.__Canon>)(object)gameObject;
						}
						obj5 = array.Length;
						obj12 = obj7 + 1;
						bool flag9 = (nint)obj12 < array.Length;
						num = 0;
						obj7 = obj12;
						obj8 = obj4;
						num2 = 0;
						if (flag9)
						{
							continue;
						}
						goto IL_024f;
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
					break;
				}
				goto IL_0989;
			}
		}
		goto IL_024f;
		IL_024f:
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v26+E4]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v26+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = lensTarget != null;
		bool flag12 = !flag11;
		UnityEngine.Object obj17 = null;
		if (!flag12)
		{
			bool flag13 = (object)lensTarget == null;
			obj8 = null;
			num2 = 0;
			action2 = (Action<ScriptableRenderContext, System.__Canon>)(object)lensTarget;
			if (flag13)
			{
				goto IL_0989;
			}
			lensTarget.Release();
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v96+E4]");
			bool flag14 = (nint)0 == 0;
			object obj19 = !flag14;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(lensTarget);
			obj17 = null;
		}
		object obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v31+E4]");
		bool flag15 = (nint)0 == 0;
		object obj21 = !flag15;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = little != null;
		bool flag17 = !flag16;
		UnityEngine.Object obj22 = null;
		if (!flag17)
		{
			object obj23 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v90+E4]");
			bool flag18 = (nint)0 == 0;
			object obj24 = !flag18;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(little);
			obj22 = null;
		}
		object obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v36+E4]");
		bool flag19 = (nint)0 == 0;
		object obj26 = !flag19;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = ripSkin != null;
		bool flag21 = !flag20;
		UnityEngine.Object obj27 = null;
		if (!flag21)
		{
			object obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v85+E4]");
			bool flag22 = (nint)0 == 0;
			object obj29 = !flag22;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(ripSkin);
			obj27 = null;
		}
		object obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v41+E4]");
		bool flag23 = (nint)0 == 0;
		object obj31 = !flag23;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = ripMat != null;
		bool flag25 = !flag24;
		UnityEngine.Object obj32 = null;
		if (!flag25)
		{
			object obj33 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v80+E4]");
			bool flag26 = (nint)0 == 0;
			object obj34 = !flag26;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(ripMat);
			obj32 = null;
		}
		object obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v46+E4]");
		bool flag27 = (nint)0 == 0;
		object obj36 = !flag27;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag28 = fleshMat != null;
		bool flag29 = !flag28;
		UnityEngine.Object obj37 = null;
		if (!flag29)
		{
			object obj38 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v75+E4]");
			bool flag30 = (nint)0 == 0;
			object obj39 = !flag30;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(fleshMat);
			obj37 = null;
		}
		object obj40 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v51+E4]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v51+E4]");
		bool flag31 = (nint)0 == 0;
		object obj41 = !flag31;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag32 = boneMat != null;
		bool flag33 = !flag32;
		obj8 = null;
		action2 = (Action<ScriptableRenderContext, System.__Canon>)(object)boneMat;
		if (!flag33)
		{
			object obj42 = obj3;
			action2 = (Action<ScriptableRenderContext, System.__Canon>)(object)boneMat;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v70+E4]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v70+E4]");
			bool flag34 = (nint)0 == 0;
			object obj43 = !flag34;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy((UnityEngine.Object)(object)action2);
			obj8 = null;
		}
		bool flag35 = (object)baked == null;
		num2 = 0;
		if (!flag35)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7080]");
			array = (Camera[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7078]");
			action2 = (Action<ScriptableRenderContext, System.__Canon>)0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)baked).GetEnumerator();
			num2 = 0;
			Enumerator<, > val = default;
			obj5 = (object)(&val);
			while (val.MoveNext())
			{
				object obj44 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v61+E4]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X0_v61+E4]");
				bool flag36 = (nint)0 == 0;
				object obj45 = !flag36;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag37 = (UnityEngine.Object)null != (UnityEngine.Object)null;
				bool flag38 = !flag37;
				num2 = 0;
				if (!flag38)
				{
					object obj46 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v65+E4]");
					bool flag39 = (nint)0 == 0;
					object obj47 = !flag39;
					if (obj47 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(null);
					num2 = 0;
				}
			}
			object obj48 = 0;
			object obj49 = 0;
			Enumerator<, > val2 = (Enumerator<, >)(ref val);
			object obj50 = 0;
			object obj53 = default;
			while (true)
			{
				obj8 = (UnityEngine.Object)(object)action2;
				val.Dispose();
				bool flag40 = obj50 == null;
				object obj51 = !flag40;
				if (obj51 == null)
				{
					bool flag41 = obj48 == null;
					object obj52 = !flag41;
					OutOfMemoryException ex2 = (OutOfMemoryException)(&val);
					if (obj52 == null)
					{
						return;
					}
				}
				else
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj8 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj48 = 1;
					obj50 = obj49;
					obj5 = 1;
					continue;
				}
				if ((nint)obj8 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj50 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj49 = obj53;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DC5C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			return;
		}
		goto IL_0989;
		IL_0989:
		throw new NullReferenceException();
	}

	public GillaWarmUp()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7410]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj2 = this + 96;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaWarmUp()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A58]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		HashSet<System.__Canon> hashSet = default;
		hashSet._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = hashSet;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal static void _003CSounds_003Eg__Add_007C55_0(AudioClip[] these, ref _003C_003Ec__DisplayClass55_0 P_1)
	{
		//IL_0018: Expected Obj, but got VT
		if (these != null)
		{
			((List<System.__Canon>)P_1).AddRange((IEnumerable<System.__Canon>)(object)these);
		}
	}
}
