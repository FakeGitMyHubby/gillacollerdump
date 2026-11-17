using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.LagCompensation;
using UnityEngine;

namespace Fusion;

public class HitboxRoot : NetworkBehaviour
{
	private static class RecyclableList<T> where T : class
	{
		public static List<T> List;

		static RecyclableList()
		{
			//IL_000c: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0067: Expected Obj, but got I
			//IL_007d: Expected Obj, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected Obj, but got Unknown
			//IL_00a5: Expected Obj, but got I4
			//IL_011d: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected Obj, but got Unknown
			//IL_015a: Expected Obj, but got I4
			//IL_0178: Expected Obj, but got I
			//IL_0188: Expected Obj, but got I
			//IL_0198: Expected Obj, but got I
			//IL_01b6: Expected Obj, but got I
			//IL_01d0: Expected Obj, but got I4
			//IL_01ee: Expected Obj, but got I
			//IL_01fe: Expected Obj, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v2 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1>)+A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			nint num2 = 0;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr = default;
				num2 = intPtr;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1>)+A8]");
			object obj8 = 0;
			List<System.__Canon> list = default;
			list._002Ector();
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				nint num3 = 0;
			}
			else
			{
				nint num3 = 0;
				nint num4 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1>)+A8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X9_v5+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X9_v6+A0]");
			object obj14 = 0;
			obj14 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1>)+135]");
			object obj15 = (nint)0 & (nint)1;
			bool flag4 = obj15 == null;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
				IntPtr intPtr2 = default;
				nint num3 = intPtr2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9 (Il2CppClass<Fusion.HitboxRoot+RecyclableList`1>)+A8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v10+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public enum ConfigFlags
	{
		// error: enumerator has no value
		ReinitializeHitboxesBeforeRegistration,
		// error: enumerator has no value
		IncludeInactiveHitboxes,
		// error: enumerator has no value
		Legacy,
		// error: enumerator has no value
		Default
	}

	internal class HitboxComparerX : _0021_00210
	{
		public int Compare(HitboxRoot a, HitboxRoot b)
		{
			//IL_00d1: Expected I4, but got Obj
			if ((object)a != null)
			{
				Transform transform = a.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					if ((object)b != null)
					{
						Transform transform2 = b.transform;
						if ((object)transform2 != null)
						{
							Vector3 position2 = transform2.position;
							float num = default;
							float value = default;
							return num.CompareTo(value);
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	internal class HitboxComparerY : Action<long>
	{
		public unsafe int Compare(HitboxRoot a, HitboxRoot b)
		{
			//IL_00df: Expected I4, but got Obj
			//IL_00b6: Expected F4, but got I
			//IL_00c3: Expected Ref, but got F4
			if ((object)a != null)
			{
				Transform transform = a.transform;
				if ((object)transform != null)
				{
					Vector3 position = transform.position;
					if ((object)b != null)
					{
						Transform transform2 = b.transform;
						if ((object)transform2 != null)
						{
							Vector3 position2 = transform2.position;
							object obj = default;
							float num = (nint)(&obj) | (nint)4;
							float value = default;
							return ((float*)num)->CompareTo(value);
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private const int WORD_COUNT = default(int);

	public const int MAX_HITBOXES = default(int);

	public ConfigFlags Config = (ConfigFlags)3;

	public float BroadRadius;

	public Vector3 Offset;

	public Color GizmosColor;

	public Hitbox[] Hitboxes;

	private HitboxManager Manager__BackingField;

	internal Transform CachedTransform;

	public bool HitboxRootActive
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			throw new ArgumentNullException();
		}
		set
		{
			throw new ArgumentNullException();
		}
	}

	internal bool Registered
	{
		get
		{
			//IL_003c: Expected Obj, but got I4
			HitboxManager hitboxManager = Manager__BackingField;
			if ((object)Manager__BackingField != null)
			{
				object obj = hitboxManager.Flags & (SimulationBehaviourRuntimeFlags)8;
				return obj == null;
			}
			return false;
		}
	}

	public HitboxManager Manager
	{
		get
		{
			return Manager__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public bool InInterest
	{
		get
		{
			//IL_00a7: Expected I4, but got Obj
			NetworkRunner runner = ((SimulationBehaviour)this)._runner;
			if ((object)((SimulationBehaviour)this)._runner != null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
				if ((object)((SimulationBehaviour)this)._object != null && (object)runner._simulation != null && networkObject.Meta != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C62A8");
				}
				bool? flag = default;
				return flag ?? true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		Transform transform = base.transform;
		object obj = this + 160;
		obj = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public void OnDrawGizmos()
	{
		Transform transform = base.transform;
		transform.GetPositionAndRotation(out var _, out var _);
		Vector3 pos = default;
		Quaternion q = default;
		Vector3 s = default;
		Matrix4x4 matrix4x = Matrix4x4.Internal_TRS(ref pos, ref q, ref s);
		base.Finalize();
	}

	protected unsafe virtual void DrawGizmos(Color color, ref Matrix4x4 localToWorldMatrix)
	{
		//IL_0009: Expected VT, but got Ref
		//IL_0013: Expected VT, but got I4
		//IL_0028: Expected F4, but got VT
		//IL_0028: Expected VT, but got I4
		//IL_0032: Expected VT, but got I4
		//IL_0045: Expected VT, but got Ref
		object obj = default;
		Gizmos.matrix = (Matrix4x4)(&obj);
		Gizmos.color = (Color)0;
		Gizmos.DrawWireSphere((Vector3)0, (float)Offset);
		Gizmos.color = (Color)0;
		object obj2 = default;
		Gizmos.matrix = (Matrix4x4)(&obj2);
	}

	public unsafe void InitHitboxes()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Ref, but got Unknown
		//IL_01a0: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_011a: Expected Obj, but got I
		//IL_0285: Invalid comparison between F4 and I4
		//IL_0311: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I4
		//IL_014f: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6918]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A68]");
		object obj2 = 0;
		Transform transform = base.transform;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (int)Config >> 1;
		object obj6 = obj5 & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36CE064");
		List<System.__Canon> list = default;
		if (list != null)
		{
			System.__Canon[] array = list.ToArray();
			ref System.__Canon[] reference = ref *(System.__Canon[]*)(this + 144);
			reference = ref *(System.__Canon[]*)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			System.__Canon[] array2 = reference;
			if (reference != null)
			{
				if (array2.Length >= 32)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj7 = 0;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v15+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+10]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A70]");
						object format = 0;
						object arg = default;
						string text = string.Format((string)format, arg);
						object obj12 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ X8_v26+198] (should have been resolved before IL gen)");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A58]");
					object obj13 = 0;
					obj6 = obj13;
					Array.Resize(ref reference, 31);
					array2 = reference;
					if (reference == null)
					{
						goto IL_026f;
					}
				}
				object obj14 = 0;
				object obj18;
				do
				{
					if ((nint)obj14 < array2.Length)
					{
						bool flag2 = (nint)obj14 < array2.Length;
						object obj15 = !flag2;
						if (obj15 == null)
						{
							object obj16 = (object)array2 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v11+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v11+20]");
							object obj17 = (nint)0 + (nint)72;
							obj17 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							array2 = (System.__Canon[])(object)Hitboxes;
							obj14++;
							bool flag3 = Hitboxes == null;
							obj18 = !flag3;
							continue;
						}
						throw new IndexOutOfRangeException();
					}
					if (BroadRadius == 0f)
					{
						SetMinBoundingRadius();
					}
					return;
				}
				while (obj18 != null);
			}
		}
		goto IL_026f;
		IL_026f:
		throw new NullReferenceException();
	}

	public void SetMinBoundingRadius()
	{
		//IL_05d7: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I
		//IL_0624: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I4
		//IL_068c: Expected VT, but got Obj
		//IL_06a0: Expected Obj, but got I
		//IL_06a9: Expected VT, but got Obj
		//IL_06c2: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I
		//IL_0727: Expected F4, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c1: Expected VT, but got I4
		//IL_00c1: Expected VT, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_0129: Expected VT, but got F8
		//IL_0136: Expected VT, but got F8
		//IL_0153: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I4
		//IL_0165: Expected F4, but got I4
		//IL_08bc: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_0774: Expected Obj, but got I4
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_02c6: Expected VT, but got I4
		//IL_02c6: Expected VT, but got I4
		//IL_07b0: Expected VT, but got Obj
		//IL_07d2: Expected Obj, but got I4
		//IL_0843: Expected VT, but got Obj
		//IL_0853: Expected F8, but got I
		//IL_0863: Expected Obj, but got I
		//IL_0885: Expected Obj, but got I4
		//IL_0473: Expected F8, but got I
		//IL_0493: Invalid comparison between F8 and I4
		//IL_04a2: Invalid comparison between F8 and I4
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_04ca: Expected Obj, but got F8
		//IL_04ff: Expected Obj, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_0538: Expected F8, but got I
		//IL_040a: Expected F8, but got VT
		//IL_07fb: Expected VT, but got F8
		//IL_0428: Expected F8, but got I
		//IL_05b4: Expected VT, but got F8
		Hitbox[] hitboxes = Hitboxes;
		float num3;
		if (Hitboxes != null && hitboxes.Length != 0)
		{
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				Transform transform2 = base.transform;
				if ((object)transform2 != null)
				{
					Quaternion rotation = transform2.rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.HitboxRoot)+74]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.HitboxRoot)+78]");
					object obj2 = 0;
					Vector3 vector = (Quaternion)0 * (Vector3)0;
					Hitbox[] hitboxes2 = Hitboxes;
					if (Hitboxes != null)
					{
						object obj3 = hitboxes2.Length;
						if (hitboxes2.Length < 1)
						{
							goto IL_071e;
						}
						double num = default;
						Vector3 vector2 = (Vector3)(num + num);
						double num2 = default;
						Vector3 vector3 = (Vector3)(num2 + num2);
						object obj5 = default;
						object obj4 = obj5 + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj6 = 0;
						object obj7 = 0;
						num3 = 0f;
						Vector3 vector4 = vector3;
						Vector3 vector5 = vector2;
						object obj8 = obj5;
						double num4 = num2;
						double num5 = num;
						object obj11 = default;
						double num6 = default;
						double num20 = default;
						while (true)
						{
							bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
							object obj9 = !flag;
							if (obj9 != null)
							{
								break;
							}
							object obj10 = (object)Hitboxes + obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v27+20]");
							Component component = (Component)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v27+20]");
							Vector3 vector6;
							double num14;
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+20]");
								bool flag2 = (nint)0 == 0;
								obj11 = obj11;
								num6 = num6;
								vector6 = vector4;
								if (flag2)
								{
									goto IL_076a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v27+20]");
								Transform transform3 = ((Component)0).transform;
								if ((object)transform3 != null)
								{
									Vector3 position2 = transform3.position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v27+20]");
									Transform transform4 = ((Component)0).transform;
									if ((object)transform4 != null)
									{
										Quaternion rotation2 = transform4.rotation;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+40]");
										obj = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+44]");
										obj2 = 0;
										Vector3 vector7 = (Quaternion)0 * (Vector3)0;
										vector = (Vector3)obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v27 (UnityEngine.Vector3)+E4]");
										bool flag3 = (nint)0 == 0;
										object obj12 = !flag3;
										if (obj12 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										double num7 = (double)vector4 + (double)vector4;
										double num8 = num6 + num6;
										object obj13 = obj11 + obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+20]");
										bool flag4 = (nint)0 == 1;
										double num9 = num7 - (double)vector2;
										double num10 = num8 - (double)vector3;
										obj11 = obj13 - obj4;
										double num11 = num9 * num9;
										double num12 = num10 * num10;
										double num13 = num11 + num12;
										num6 = (double)obj11 * (double)obj11;
										num14 = num6 + num13;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										if (!flag4)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+20]");
											if ((nint)0 != 3)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+20]");
												bool flag5 = (nint)0 != 2;
												obj8 = obj11;
												num4 = num6;
												num5 = (double)vector4;
												if (flag5)
												{
													goto IL_07e0;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+24]");
												num14 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
												obj8 = obj11;
												num4 = num6;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+38]");
												num14 = 0.0 * 0.5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+28]");
												num6 = 0.0;
												double num15 = num14;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+28]");
												double num16 = num15 - 0.0;
												bool flag6 = num16 < 0.0;
												bool flag7 = num16 == 0.0;
												double num17 = num14;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+28]");
												object obj14 = num17 ^ 0;
												object obj15 = num14 ^ num16;
												object obj16 = obj14 & obj15;
												bool flag8 = (nint)obj16 < 0;
												bool flag9 = flag6 == flag8;
												object obj17 = !flag7;
												object obj18 = flag9 & obj17;
												object obj19 = ~obj18;
												if (obj19 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+28]");
													num14 = 0.0;
												}
												obj8 = obj11;
												num4 = num6;
											}
										}
										else
										{
											vector = (Vector3)obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+2C]");
											num4 = 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X21_v8 (UnityEngine.Component)+30]");
											obj8 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v27 (UnityEngine.Vector3)+E4]");
											bool flag10 = (nint)0 == 0;
											object obj20 = !flag10;
											if (obj20 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											double num18 = num4 * num4;
											object obj21 = obj8 * obj8;
											double num19 = num18 + (double)obj21;
											num14 = num19 + num20;
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											num6 = num20;
										}
										num5 = (double)vector4 + num14;
										goto IL_07e0;
									}
								}
							}
							goto IL_072c;
							IL_076a:
							obj3 = hitboxes2.Length;
							obj7++;
							bool flag11 = (nint)obj7 < hitboxes2.Length;
							vector4 = vector6;
							if (flag11)
							{
								continue;
							}
							goto IL_0893;
							IL_07e0:
							bool flag12 = !(num5 > (double)num3);
							vector6 = (Vector3)num14;
							vector5 = vector3;
							if (!flag12)
							{
								num3 = (float)num5;
								vector6 = (Vector3)num14;
								vector5 = vector3;
							}
							goto IL_076a;
						}
						goto IL_073a;
					}
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v10+A0]");
			object obj24 = 0;
			object obj25 = obj24;
			if (obj24 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v13+E8]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A78]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj28);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69D8]");
			object obj30 = 0;
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)obj30);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A80]");
			object format = 0;
			string text = string.Format((string)format, typeFromHandle, typeFromHandle2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v6+10]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X20_v6+10]");
			if ((nint)0 != 0)
			{
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v213 @ X9_v4+198] (should have been resolved before IL gen)");
				goto IL_071e;
			}
		}
		goto IL_072c;
		IL_072c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_073a;
		IL_0893:
		BroadRadius = num3;
		return;
		IL_071e:
		num3 = 0f;
		goto IL_0893;
		IL_073a:
		throw new IndexOutOfRangeException();
	}

	public unsafe void SetHitboxActive(Hitbox hitbox, bool setActive)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0977: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_04db: Expected I, but got Obj
		//IL_04eb: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I8
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_0571: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_0597: Expected Obj, but got Ref
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0610: Expected Obj, but got I8
		//IL_02a2: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_05ad: Expected I, but got Obj
		//IL_05bd: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		//IL_023f: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_038f: Expected Obj, but got I8
		//IL_06b6: Expected Obj, but got I4
		//IL_0334: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_0788: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I4
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got Unknown
		//IL_071d: Expected I, but got Obj
		//IL_072d: Expected Obj, but got I
		//IL_0756: Expected Obj, but got I
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_07f9: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I
		//IL_089b: Expected Obj, but got I8
		//IL_0838: Expected I, but got Obj
		//IL_0848: Expected Obj, but got I
		//IL_0871: Expected Obj, but got I
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected Obj, but got Unknown
		//IL_08f8: Expected Obj, but got I
		Hitbox hitbox2 = default;
		bool flag = (object)hitbox2 == null;
		Hitbox hitbox3 = hitbox2;
		Hitbox hitbox4 = hitbox2;
		IndexOutOfRangeException ex2 = default;
		if (!flag)
		{
			bool flag2 = hitbox2._hitboxIndex < 31;
			object obj = !flag2;
			hitbox4 = hitbox2;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				object arg2 = default;
				string paramName = string.Format(format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ArgumentOutOfRangeException ex = default;
				ex._002Ector(paramName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6938]");
			object obj4 = 0;
			if ((object)hitbox2.Root != this)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object[] array = default;
				bool flag3 = array == null;
				hitbox3 = (Hitbox)4;
				hitbox4 = hitbox2;
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
					Hitbox hitbox5 = (Hitbox)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex2 == null;
					hitbox4 = hitbox2;
					if (!flag4)
					{
						bool flag5 = array.Length == 0;
						hitbox4 = hitbox2;
						if (!flag5)
						{
							object obj5 = array + 32;
							obj5 = hitbox2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							hitbox4 = (Hitbox)(object)hitbox2.Root;
							if ((object)hitbox2.Root != null)
							{
								nint num2 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
								hitbox2 = (Hitbox)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag6 = ex2 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
								hitbox5 = (Hitbox)0;
								if (flag6)
								{
									goto IL_092d;
								}
							}
							object obj6 = array.Length & 0xFFFFFFFEL;
							bool flag7 = obj6 == null;
							hitbox5 = hitbox2;
							if (!flag7)
							{
								object obj7 = array + 40;
								obj7 = hitbox4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag8 = (object)this == null;
								Hitbox hitbox6 = hitbox4;
								if (!flag8)
								{
									nint num3 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
									hitbox6 = (Hitbox)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag9 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
									hitbox5 = (Hitbox)0;
									if (flag9)
									{
										goto IL_092d;
									}
								}
								bool flag10 = array.Length < 2;
								object obj8 = !flag10;
								object obj9 = array.Length - 2;
								bool flag11 = obj9 == null;
								object obj10 = ~obj8;
								object obj11 = obj10 | flag11;
								hitbox5 = hitbox6;
								if (obj11 == null)
								{
									object obj12 = array + 48;
									obj12 = this;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag12 = obj4 == null;
									Hitbox hitbox7 = (Hitbox)(object)this;
									if (!flag12)
									{
										nint num4 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
										hitbox7 = (Hitbox)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag13 = ex2 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
										hitbox5 = (Hitbox)0;
										if (flag13)
										{
											goto IL_092d;
										}
									}
									object obj13 = array.Length & 0xFFFFFFFCL;
									bool flag14 = obj13 == null;
									hitbox5 = hitbox7;
									if (!flag14)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6940]");
										object format2 = 0;
										object obj14 = array + 56;
										obj14 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										string error = string.Format((string)format2, array);
										Assert.Fail(error);
										return;
									}
								}
							}
						}
						goto IL_091f;
					}
					goto IL_092d;
				}
			}
			else
			{
				Hitbox[] hitboxes = Hitboxes;
				bool flag15 = Hitboxes == null;
				hitbox3 = hitbox2;
				hitbox4 = hitbox2;
				if (!flag15)
				{
					if (hitbox2._hitboxIndex < hitboxes.Length)
					{
						object obj15 = Hitboxes + hitbox2._hitboxIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v28+20]");
						if (0 == (nint)hitbox2)
						{
							throw new ArgumentNullException();
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object[] array2 = default;
					bool flag16 = array2 == null;
					hitbox3 = (Hitbox)4;
					hitbox4 = hitbox2;
					if (!flag16)
					{
						nint num5 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
						Hitbox hitbox5 = (Hitbox)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag17 = ex2 == null;
						hitbox4 = hitbox2;
						if (!flag17)
						{
							bool flag18 = array2.Length == 0;
							hitbox4 = hitbox2;
							if (!flag18)
							{
								object obj16 = array2 + 32;
								obj16 = hitbox2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Hitbox hitbox8 = default;
								bool flag19 = (object)hitbox8 == null;
								object obj18 = default;
								Hitbox hitbox9 = (Hitbox)(&obj18);
								if (!flag19)
								{
									nint num6 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
									hitbox9 = (Hitbox)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag20 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
									hitbox5 = (Hitbox)0;
									hitbox4 = hitbox2;
									if (flag20)
									{
										goto IL_092d;
									}
								}
								object obj19 = array2.Length & 0xFFFFFFFEL;
								bool flag21 = obj19 == null;
								hitbox5 = hitbox9;
								hitbox4 = hitbox2;
								if (!flag21)
								{
									object obj20 = array2 + 40;
									obj20 = hitbox8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Hitbox[] hitboxes2 = Hitboxes;
									bool flag22 = Hitboxes == null;
									hitbox3 = hitbox8;
									hitbox4 = hitbox2;
									if (flag22)
									{
										goto IL_094a;
									}
									bool flag23 = hitbox2._hitboxIndex < hitboxes2.Length;
									object obj21 = !flag23;
									hitbox5 = hitbox8;
									hitbox4 = hitbox2;
									if (obj21 == null)
									{
										object obj22 = Hitboxes + hitbox2._hitboxIndex;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v18+20]");
										bool flag24 = (nint)0 == 0;
										Hitbox hitbox10 = hitbox8;
										if (!flag24)
										{
											nint num7 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
											hitbox10 = (Hitbox)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag25 = ex2 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
											hitbox5 = (Hitbox)0;
											hitbox4 = hitbox2;
											if (flag25)
											{
												goto IL_092d;
											}
										}
										bool flag26 = array2.Length < 2;
										object obj23 = !flag26;
										object obj24 = array2.Length - 2;
										bool flag27 = obj24 == null;
										object obj25 = ~obj23;
										object obj26 = obj25 | flag27;
										hitbox5 = hitbox10;
										hitbox4 = hitbox2;
										if (obj26 == null)
										{
											object obj27 = array2 + 48;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v18+20]");
											obj27 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag28 = obj4 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v18+20]");
											Hitbox hitbox11 = (Hitbox)0;
											if (!flag28)
											{
												nint num8 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
												hitbox11 = (Hitbox)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag29 = ex2 == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
												hitbox5 = (Hitbox)0;
												hitbox4 = hitbox2;
												if (flag29)
												{
													goto IL_092d;
												}
											}
											object obj28 = array2.Length & 0xFFFFFFFCL;
											bool flag30 = obj28 == null;
											hitbox5 = hitbox11;
											hitbox4 = hitbox2;
											if (!flag30)
											{
												object obj29 = array2 + 56;
												obj29 = obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6948]");
												object format3 = 0;
												string error2 = string.Format((string)format3, array2);
												Assert.Fail(error2);
												return;
											}
										}
									}
								}
							}
							goto IL_091f;
						}
						goto IL_092d;
					}
				}
			}
		}
		goto IL_094a;
		IL_094a:
		hitbox2 = hitbox3;
		throw new NullReferenceException();
		IL_091f:
		ex2 = new IndexOutOfRangeException();
		goto IL_092d;
		IL_092d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex3 = new ArgumentNullException();
		hitbox3 = null;
		goto IL_094a;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal void SetHitboxActiveFastUnchecked(Hitbox hitbox, bool setActive)
	{
		//IL_00cf: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_00f7: Expected I4, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I4
		//IL_006d: Expected I4, but got Obj
		//IL_008d: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		ArgumentNullException ex = new ArgumentNullException();
		object obj5;
		if (setActive)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6930]");
			object error = 0;
			bool flag = hitbox._hitboxIndex < 31;
			object obj = !flag;
			bool condition = (byte)(int)(~obj) != 0;
			Assert.Check(condition, (string)error);
			object obj2 = hitbox._hitboxIndex + 1;
			object obj3 = 1 << (int)obj2;
			object obj4 = ~obj3;
			obj5 = (object)ex & obj4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6930]");
			object error2 = 0;
			bool flag2 = hitbox._hitboxIndex < 31;
			object obj6 = !flag2;
			bool condition2 = (byte)(int)(~obj6) != 0;
			Assert.Check(condition2, (string)error2);
			object obj7 = hitbox._hitboxIndex + 1;
			object obj8 = 1 << (int)obj7;
			obj5 = obj8 | (object)ex;
		}
		ex = (ArgumentNullException)obj5;
	}

	public unsafe bool IsHitboxActive(Hitbox hitbox)
	{
		//IL_0024: Expected Obj, but got I4
		//IL_093f: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_09c4: Expected I4, but got Obj
		//IL_04b2: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected Obj, but got Unknown
		//IL_04d0: Expected I, but got Obj
		//IL_04e0: Expected Obj, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I8
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0566: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_058c: Expected Obj, but got Ref
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0605: Expected Obj, but got I8
		//IL_02a2: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_05a2: Expected I, but got Obj
		//IL_05b2: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I
		//IL_023f: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_038f: Expected Obj, but got I8
		//IL_06ab: Expected Obj, but got I4
		//IL_0334: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_06ed: Expected Obj, but got I
		//IL_0785: Expected Obj, but got I4
		//IL_0795: Expected Obj, but got I4
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected Obj, but got Unknown
		//IL_0722: Expected I, but got Obj
		//IL_0732: Expected Obj, but got I
		//IL_075b: Expected Obj, but got I
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_0878: Expected Obj, but got I8
		//IL_081d: Expected I, but got Obj
		//IL_082d: Expected Obj, but got I
		//IL_0856: Expected Obj, but got I
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08cd: Expected Obj, but got I
		Hitbox hitbox2 = default;
		bool flag = (object)hitbox2 == null;
		Hitbox hitbox3 = hitbox2;
		Hitbox hitbox4 = hitbox2;
		string format2;
		object[] args;
		IndexOutOfRangeException ex3 = default;
		if (!flag)
		{
			bool flag2 = hitbox2._hitboxIndex < 31;
			object obj = !flag2;
			hitbox4 = hitbox2;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A27A8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				string format = default;
				object arg = default;
				object arg2 = default;
				string paramName = string.Format(format, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				ArgumentOutOfRangeException ex = default;
				ex._002Ector(paramName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (byte)(int)ex2 != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6938]");
			object obj4 = 0;
			if ((object)hitbox2.Root != this)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				object[] array = default;
				bool flag3 = array == null;
				hitbox3 = (Hitbox)4;
				hitbox4 = hitbox2;
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
					Hitbox hitbox5 = (Hitbox)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex3 == null;
					hitbox4 = hitbox2;
					if (!flag4)
					{
						bool flag5 = array.Length == 0;
						hitbox4 = hitbox2;
						if (!flag5)
						{
							object obj5 = array + 32;
							obj5 = hitbox2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							hitbox4 = (Hitbox)(object)hitbox2.Root;
							if ((object)hitbox2.Root != null)
							{
								nint num2 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
								hitbox2 = (Hitbox)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag6 = ex3 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
								hitbox5 = (Hitbox)0;
								if (flag6)
								{
									goto IL_08f5;
								}
							}
							object obj6 = array.Length & 0xFFFFFFFEL;
							bool flag7 = obj6 == null;
							hitbox5 = hitbox2;
							if (!flag7)
							{
								object obj7 = array + 40;
								obj7 = hitbox4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool flag8 = (object)this == null;
								Hitbox hitbox6 = hitbox4;
								if (!flag8)
								{
									nint num3 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
									hitbox6 = (Hitbox)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag9 = ex3 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
									hitbox5 = (Hitbox)0;
									if (flag9)
									{
										goto IL_08f5;
									}
								}
								bool flag10 = array.Length < 2;
								object obj8 = !flag10;
								object obj9 = array.Length - 2;
								bool flag11 = obj9 == null;
								object obj10 = ~obj8;
								object obj11 = obj10 | flag11;
								hitbox5 = hitbox6;
								if (obj11 == null)
								{
									object obj12 = array + 48;
									obj12 = this;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag12 = obj4 == null;
									Hitbox hitbox7 = (Hitbox)(object)this;
									if (!flag12)
									{
										nint num4 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
										hitbox7 = (Hitbox)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag13 = ex3 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v52 (Il2CppClass<System.Object[]>)+40]");
										hitbox5 = (Hitbox)0;
										if (flag13)
										{
											goto IL_08f5;
										}
									}
									object obj13 = array.Length & 0xFFFFFFFCL;
									bool flag14 = obj13 == null;
									hitbox5 = hitbox7;
									if (!flag14)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6940]");
										object obj14 = 0;
										object obj15 = array + 56;
										obj15 = obj4;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										format2 = (string)obj14;
										args = array;
										goto IL_09f1;
									}
								}
							}
						}
						goto IL_08e7;
					}
					goto IL_08f5;
				}
			}
			else
			{
				Hitbox[] hitboxes = Hitboxes;
				bool flag15 = Hitboxes == null;
				hitbox3 = hitbox2;
				hitbox4 = hitbox2;
				if (!flag15)
				{
					if (hitbox2._hitboxIndex < hitboxes.Length)
					{
						object obj16 = Hitboxes + hitbox2._hitboxIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v30+20]");
						if (0 == (nint)hitbox2)
						{
							throw new ArgumentNullException();
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					object[] array2 = default;
					bool flag16 = array2 == null;
					hitbox3 = (Hitbox)4;
					hitbox4 = hitbox2;
					if (!flag16)
					{
						nint num5 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
						Hitbox hitbox5 = (Hitbox)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag17 = ex3 == null;
						hitbox4 = hitbox2;
						if (!flag17)
						{
							bool flag18 = array2.Length == 0;
							hitbox4 = hitbox2;
							if (!flag18)
							{
								object obj17 = array2 + 32;
								obj17 = hitbox2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								Hitbox hitbox8 = default;
								bool flag19 = (object)hitbox8 == null;
								object obj19 = default;
								Hitbox hitbox9 = (Hitbox)(&obj19);
								if (!flag19)
								{
									nint num6 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									hitbox9 = (Hitbox)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag20 = ex3 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									hitbox5 = (Hitbox)0;
									hitbox4 = hitbox2;
									if (flag20)
									{
										goto IL_08f5;
									}
								}
								object obj20 = array2.Length & 0xFFFFFFFEL;
								bool flag21 = obj20 == null;
								hitbox5 = hitbox9;
								hitbox4 = hitbox2;
								if (!flag21)
								{
									object obj21 = array2 + 40;
									obj21 = hitbox8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Hitbox[] hitboxes2 = Hitboxes;
									bool flag22 = Hitboxes == null;
									hitbox3 = hitbox8;
									hitbox4 = hitbox2;
									if (flag22)
									{
										goto IL_0912;
									}
									bool flag23 = hitbox2._hitboxIndex < hitboxes2.Length;
									object obj22 = !flag23;
									hitbox5 = hitbox8;
									hitbox4 = hitbox2;
									if (obj22 == null)
									{
										object obj23 = Hitboxes + hitbox2._hitboxIndex;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v20+20]");
										hitbox4 = (Hitbox)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v20+20]");
										bool flag24 = (nint)0 == 0;
										Hitbox hitbox10 = hitbox8;
										if (!flag24)
										{
											nint num7 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
											hitbox10 = (Hitbox)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag25 = ex3 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
											hitbox5 = (Hitbox)0;
											if (flag25)
											{
												goto IL_08f5;
											}
										}
										bool flag26 = array2.Length < 2;
										object obj24 = !flag26;
										object obj25 = array2.Length - 2;
										bool flag27 = obj25 == null;
										object obj26 = ~obj24;
										object obj27 = obj26 | flag27;
										hitbox5 = hitbox10;
										if (obj27 == null)
										{
											object obj28 = array2 + 48;
											obj28 = hitbox4;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool flag28 = obj4 == null;
											Hitbox hitbox11 = hitbox4;
											if (!flag28)
											{
												nint num8 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
												hitbox11 = (Hitbox)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag29 = ex3 == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
												hitbox5 = (Hitbox)0;
												if (flag29)
												{
													goto IL_08f5;
												}
											}
											object obj29 = array2.Length & 0xFFFFFFFCL;
											bool flag30 = obj29 == null;
											hitbox5 = hitbox11;
											if (!flag30)
											{
												object obj30 = array2 + 56;
												obj30 = obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6948]");
												object obj31 = 0;
												format2 = (string)obj31;
												args = array2;
												goto IL_09f1;
											}
										}
									}
								}
							}
							goto IL_08e7;
						}
						goto IL_08f5;
					}
				}
			}
		}
		goto IL_0912;
		IL_09f1:
		string error = string.Format(format2, args);
		Assert.Fail(error);
		return false;
		IL_08f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex4 = new ArgumentNullException();
		hitbox3 = null;
		goto IL_0912;
		IL_0912:
		hitbox2 = hitbox3;
		throw new NullReferenceException();
		IL_08e7:
		ex3 = new IndexOutOfRangeException();
		goto IL_08f5;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal bool IsHitboxActiveFastUnchecked(Hitbox hitbox)
	{
		throw new ArgumentNullException();
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I
		object obj = this + 152;
		object obj2 = obj;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X20_v1+30]");
			object obj3 = (nint)0 & (nint)8;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X20_v1+90]");
				bool flag2 = ((HitboxBuffer)0).Remove(this);
			}
		}
	}

	internal void RegisterColliders(IHitboxColliderContainer container, int tick)
	{
		//IL_0266: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_00a5: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I
		object obj = Config & (ConfigFlags)1;
		if (obj != null)
		{
			InitHitboxes();
		}
		Hitbox[] hitboxes = Hitboxes;
		if (Hitboxes == null)
		{
			return;
		}
		object obj2 = hitboxes.Length;
		if (hitboxes.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
		object obj3 = 0;
		object obj4 = 0;
		ref HitboxCollider c = default;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			object obj5 = !flag;
			if (obj5 != null)
			{
				break;
			}
			if (container == null)
			{
				goto IL_0241;
			}
			nint num = (nint)container;
			object obj6 = (object)Hitboxes + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v9 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v9 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0140;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v9 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
			object obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v10-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj7--;
				obj8 += 16;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_0140;
			}
			object obj9 = num + obj8;
			object obj10 = obj9 + 312;
			goto IL_02a7;
			IL_02a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ X0_v9] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v5+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v5+20]");
				GameObject gameObject = ((Component)0).gameObject;
				if ((object)gameObject != null)
				{
					bool activeSelf = gameObject.activeSelf;
					bool flag2 = !activeSelf;
					object obj11 = !flag2;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v5+20]");
						((Hitbox)0).CacheInfo();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v5+20]");
					((Hitbox)0).SetColliderData(ref c, tick);
					obj2 = hitboxes.Length;
					obj4++;
					if ((nint)obj4 >= hitboxes.Length)
					{
						return;
					}
					continue;
				}
			}
			goto IL_0241;
			IL_0241:
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0140:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_02a7;
		}
		throw new IndexOutOfRangeException();
	}

	internal void DeregisterColliders(IHitboxColliderContainer container)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I8
		//IL_0052: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		Hitbox[] hitboxes = Hitboxes;
		if (Hitboxes == null)
		{
			return;
		}
		object obj = hitboxes.Length;
		if (hitboxes.Length < 1)
		{
			return;
		}
		object obj2 = hitboxes.Length & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6480]");
		object obj3 = 0;
		object obj4 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			object obj5 = !flag;
			if (obj5 != null)
			{
				break;
			}
			object obj6 = (object)Hitboxes + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X9_v5+20]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X9_v5+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X9_v6+54]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0206;
				}
				if (container != null)
				{
					nint num = (nint)container;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v7 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v7 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0182;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v7 (Il2CppClass<Fusion.LagCompensation.IHitboxColliderContainer>)+98]");
					object obj9 = (nint)0 + (nint)8;
					object obj10;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X10_v8-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj8--;
						obj10 = obj9 + 16;
						bool flag2 = (nint)obj8 != 1;
						obj9 = obj10;
						if (flag2)
						{
							continue;
						}
						goto IL_0182;
					}
					object obj11 = obj9 + 3;
					object obj12 = num + obj11;
					object obj13 = obj12 + 312;
					obj10 = obj9;
					goto IL_0266;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0182:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0266;
			IL_0206:
			obj4++;
			obj2 = obj & 0xFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				return;
			}
			continue;
			IL_0266:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X0_v8] (should have been resolved before IL gen)");
			obj = hitboxes.Length;
			goto IL_0206;
		}
		throw new IndexOutOfRangeException();
	}

	internal unsafe Bounds GetBounds()
	{
		//IL_01ac: Expected VT, but got Obj
		//IL_0035: Expected VT, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected VT, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected VT, but got Unknown
		//IL_0187: Expected native int or pointer, but got VT
		//IL_0194: Expected native int or pointer, but got VT
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			Bounds result = (Bounds)transform.TransformPoint((Vector3)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.HitboxRoot)+78]");
			float num = 0f - BroadRadius;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.HitboxRoot)+78]");
			float num2 = 0f + BroadRadius;
			Vector3 offset = Offset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.HitboxRoot)+74]");
			object obj = offset - 0;
			float num3 = 0f - num;
			Vector3 offset2 = Offset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.HitboxRoot)+74]");
			object obj2 = offset2 + 0;
			object obj3 = 0 - obj;
			double num4 = (double)num3 * 0.5;
			object obj4 = obj3 * 63;
			double num5 = (double)num + num4;
			object obj5 = obj + obj4;
			double num6 = num5 - num4;
			object obj6 = obj5 - obj4;
			double num7 = (double)num2 - num6;
			object obj7 = obj2 - obj6;
			double num8 = num7 * 0.5;
			Vector3 vector = (Vector3)(obj7 * 63);
			double num9 = num6 + num8;
			Vector3 center = obj6 + vector;
			Bounds bounds = default;
			((Bounds*)(nint)bounds)->m_Extents = vector;
			((Bounds*)(nint)bounds)->m_Center = center;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (Bounds)ex;
	}

	public HitboxRoot()
	{
		Color gray = Color.gray;
		Color gizmosColor = default;
		GizmosColor = gizmosColor;
		base._002Ector();
	}
}
