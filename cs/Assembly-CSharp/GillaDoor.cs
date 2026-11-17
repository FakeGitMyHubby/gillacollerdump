using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using Unity.IL2CPP.Metadata;
using UnityEngine;
using UnityEngine.Rendering;

public class GillaDoor : MonoBehaviour
{
	private sealed class _003CCorners_003Ed__198 : _0021_00210, _00210, _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private Vector3 _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Bounds b;

		public Bounds _003C_003E3__b;

		private int _003Ck_003E5__2;

		private Vector3 System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EVector3_003E_002ECurrent
		{
			get
			{
				//IL_0002: Expected VT, but got Obj
				return (Vector3)this;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			get
			{
				//IL_0010: Expected Obj, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object result = default;
				return result;
			}
		}

		public _003CCorners_003Ed__198(int _003C_003E1__state)
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
			// ILSpy could not decompile this. Please report the exception below,
			// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
			// System.InvalidCastException: Cast from String to Int64 not supported.
			//    at ICSharpCode.Decompiler.Util.CSharpPrimitiveCast.CSharpPrimitiveCastUnchecked(TypeCode targetType, Object input) in /_/ICSharpCode.Decompiler/Util/CSharpPrimitiveCast.cs:line 767
			//    at ICSharpCode.Decompiler.Util.CSharpPrimitiveCast.Cast(TypeCode targetType, Object input, Boolean checkForOverflow) in /_/ICSharpCode.Decompiler/Util/CSharpPrimitiveCast.cs:line 44
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.HandleBinaryNumeric(BinaryNumericInstruction inst, BinaryOperatorType op, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 1773
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitBinaryNumericInstruction(BinaryNumericInstruction inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 1333
			//    at ICSharpCode.Decompiler.IL.BinaryNumericInstruction.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 1070
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitConv(Conv inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 2307
			//    at ICSharpCode.Decompiler.IL.Conv.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2298
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStLoc(StLoc inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 855
			//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2590
			//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStLoc(StLoc inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 129
			//    at ICSharpCode.Decompiler.IL.StLoc.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 2586
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
			//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
			//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
			//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
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

		private IEnumerator<Vector3> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EVector3_003E_002EGetEnumerator()
		{
			//IL_009d: Expected Obj, but got I4
			//IL_00b7: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got I
			object obj = _003C_003E1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object result;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					result = this;
					goto IL_00c5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0200]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj4 = default;
			obj4._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			result = obj4;
			goto IL_00c5;
			IL_00c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor+<Corners>d__198)+4C]");
			_ = 0;
			_ = _003C_003E3__b;
			return (IEnumerator<Vector3>)result;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EVector3_003E_002EGetEnumerator();
		}
	}

	private struct Cut
	{
		public Vector3 normal;

		public float off;

		public bool torso;

		public bool head;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Renderer> _003C_003E9__218_0;

		public static Predicate<Collider> _003C_003E9__218_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0518]");
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

		internal bool _003CShowSlab_003Eb__218_0(Renderer r)
		{
			//IL_003d: Expected I4, but got Obj
			if ((object)r != null)
			{
				return r.enabled;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool _003CShowSlab_003Eb__218_1(Collider c)
		{
			//IL_003d: Expected I4, but got Obj
			if ((object)c != null)
			{
				return c.enabled;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public const int PunchesToBreak = default(int);

	private const int BasePunch = default(int);

	private static int ModeShut__BackingField;

	private static int ModeBroken__BackingField;

	private static int ModeVersion__BackingField;

	private static int ModeBy__BackingField;

	private const int RoundStep = default(int);

	private static int modeRound;

	private static int roundSeenAt;

	private static bool modeHeard;

	private static readonly float[] KnockIn;

	private static readonly float[] KnockOver;

	private const float ShakeFor = default(float);

	private Quaternion shutTurn;

	private int punches;

	private Vector3 knockWay;

	private float shakeFrom;

	private Collider slabBox;

	private int heldBy;

	private bool heldRight;

	private Vector3 heldPos;

	private Quaternion heldRot;

	private bool toldAtRest;

	private float stillSince;

	private Vector3 stillAt;

	private Quaternion stillTurned;

	private static float modeOffSince;

	public int index;

	public Transform panel;

	public bool keycardOnly;

	public float rise;

	public float seconds;

	public AudioClip[] moveSounds;

	public AudioClip[] stopSounds;

	public AudioClip[] prySounds;

	public AudioClip[] blowSounds;

	public float blownResetSeconds;

	public float prySparksPerSecond;

	public float prySparksPerSpeed;

	public bool modeMap;

	public AudioClip[] punchSounds;

	public bool madeOpen;

	private static int Mask__BackingField;

	private static int Version__BackingField;

	private static int By__BackingField;

	private const int DoorJump = default(int);

	private const int FirstDoorWordMost = default(int);

	private static readonly List<GillaDoor> doors;

	private const int PriedShift = default(int);

	private const int BlownShift = default(int);

	private static readonly float[] PryT;

	private static readonly float[] PryH;

	private Vector3 shut;

	private float open;

	private bool moving;

	private bool prying;

	private float tall;

	private float seam;

	private float top;

	private ParticleSystem prySparks;

	private bool blownShown;

	private float blownAt;

	private Vector3 blowAway;

	private GameObject flying;

	private float pryDue;

	private static Material sparkMaterial;

	private Vector3 Through__BackingField;

	private float Width__BackingField;

	private float Thickness__BackingField;

	private const float ResyncAfter = default(float);

	private const float DoorChanges = default(float);

	private const float StillMoving = default(float);

	private const float WorkReach = default(float);

	private static float masterOffSince;

	private Transform[] workers;

	private float workersAt;

	private const float CrushReach = default(float);

	private const float CrushHead = default(float);

	private const float Near = default(float);

	private const float GrazeEvery = default(float);

	private float grazedAt;

	private static readonly List<(GoreSection, Vector3, Vector3, float)> shapes;

	private static readonly List<(GoreSection, Vector3)> touching;

	private static readonly Dictionary<Mesh, Vector3[]> meshPoints;

	private Renderer[] slabRenderers;

	private Collider[] slabColliders;

	public bool Punchable
	{
		get
		{
			//IL_00ee: Expected Obj, but got I4
			//IL_003d: Expected Obj, but got I4
			//IL_006f: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I4
			//IL_00d3: Expected F8, but got I4
			//IL_0146: Invalid comparison between F8 and I4
			if (~(modeMap ? 1u : 0u) != 0)
			{
				bool flag = (byte)(~(keycardOnly ? 1u : 0u)) != 0;
				object obj = !flag;
				if (obj != null || index > 7)
				{
					goto IL_011e;
				}
			}
			bool blown = Blown;
			bool flag2 = !blown;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				bool isOpen = IsOpen;
				bool flag3 = !isOpen;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					bool isOpen2 = IsOpen;
					bool flag4 = !isOpen2;
					object obj4 = !flag4;
					object obj5 = ~obj4;
					double num = ((obj5 != null) ? 0.0 : 1.0);
					double num2 = (double)open - num;
					return num2 == 0.0;
				}
			}
			goto IL_011e;
			IL_011e:
			return false;
		}
	}

	public byte PunchCode
	{
		get
		{
			int result = index | 0x40;
			if (!modeMap)
			{
				return (byte)result;
			}
			return (byte)index;
		}
	}

	public static int ModeShut
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0079: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			return (int)obj4;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			obj4 = value;
		}
	}

	public static int ModeBroken
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+4]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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

	public static int ModeVersion
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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

	public static int ModeBy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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

	public Collider SlabBox
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_0163: Expected Obj, but got I4
			//IL_0086: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Collider collider;
			if ((UnityEngine.Object)obj3 != null)
			{
				collider = (Collider)obj3;
			}
			else
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag3 = panel != null;
				bool flag4 = !flag3;
				collider = null;
				if (!flag4)
				{
					if ((object)panel == null)
					{
						return (Collider)(object)new NullReferenceException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04A0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F01C");
					Collider collider2 = default;
					collider = collider2;
				}
				obj3 = collider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			return collider;
		}
	}

	public Transform Loose
	{
		get
		{
			//IL_003c: Expected Obj, but got I
			//IL_0066: Expected Obj, but got I4
			if (~(modeMap ? 1u : 0u) == 0 && Blown)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (flying != null)
				{
					if ((object)flying != null)
					{
						return flying.transform;
					}
					return (Transform)(object)new NullReferenceException();
				}
			}
			return null;
		}
	}

	public Collider LooseBox
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d1: Expected Obj, but got I4
			//IL_007e: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Transform loose = Loose;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (loose != null)
			{
				if ((object)flying != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7560]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
					Collider result = default;
					return result;
				}
				return (Collider)(object)new NullReferenceException();
			}
			return null;
		}
	}

	public bool HeldNow
	{
		get
		{
			int num = ~heldBy;
			return (byte)(num >> 31) != 0;
		}
	}

	public static int Mask
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+34]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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

	public static int Version
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+38]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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

	public static int By
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+3C]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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

	public static IReadOnlyList<GillaDoor> All
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+40]");
			return (IReadOnlyList<GillaDoor>)0;
		}
	}

	public static float PrySeconds
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I8
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected Obj, but got Unknown
			//IL_0068: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+48]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+48]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+18]");
				object obj6 = -4294967296L + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+48]");
				object obj7 = 0 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+20]");
				return 0f;
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
	}

	public bool IsOpen
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I4
			//IL_0037: Expected Obj, but got I4
			//IL_0153: Expected Obj, but got I4
			//IL_01ba: Expected Obj, but got I
			//IL_0116: Expected Obj, but got I4
			//IL_0171: Expected Obj, but got I
			//IL_0180: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			object obj = 0;
			object obj2 = obj;
			if (~(modeMap ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v18+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v18+A0]");
				object obj6 = 0;
				int num = obj6 >> index;
				int num2 = num & 1;
				return num2 == 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8+34]");
			int num3 = (int)((nint)0 >> index);
			return (byte)(num3 & 1) != 0;
		}
	}

	private bool Pried
	{
		get
		{
			//IL_0023: Expected Obj, but got I
			//IL_004d: Expected Obj, but got I4
			//IL_00ce: Expected Obj, but got I4
			//IL_00ec: Expected Obj, but got I
			if (~(modeMap ? 1u : 0u) == 0)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+A0]");
			object obj6 = 0;
			int num = index & 0x1F;
			int num2 = num ^ 0x10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v9+34]");
			int num3 = (int)((nint)0 >> num2);
			return (byte)(num3 & 1) != 0;
		}
	}

	public bool Blown
	{
		get
		{
			//IL_010b: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got I4
			//IL_002f: Expected Obj, but got I4
			//IL_01ab: Expected Obj, but got I4
			//IL_014e: Expected Obj, but got I4
			//IL_01f8: Expected Obj, but got I
			//IL_0208: Expected Obj, but got I
			//IL_01c9: Expected Obj, but got I
			//IL_01e3: Expected Obj, but got I
			//IL_0169: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			object obj = 0;
			int num;
			object obj7;
			if (~(modeMap ? 1u : 0u) == 0)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v21+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v21+A0]");
				object obj6 = 0;
				num = index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v19+4]");
				obj7 = 0;
			}
			else
			{
				if (index > 7)
				{
					return false;
				}
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v12+34]");
				obj7 = 0;
				num = index + 24;
			}
			int num2 = obj7 >> num;
			return (byte)(num2 & 1) != 0;
		}
	}

	public bool IsMoving
	{
		get
		{
			//IL_0024: Expected Obj, but got I4
			//IL_0056: Expected F8, but got I4
			//IL_0075: Invalid comparison between F4 and I4
			bool isOpen = IsOpen;
			bool flag = !isOpen;
			object obj = !flag;
			object obj2 = ~obj;
			double num = ((obj2 != null) ? 0.0 : 1.0);
			float num2 = open - (float)num;
			bool flag2 = num2 == 0f;
			return !flag2;
		}
	}

	public bool Busy
	{
		get
		{
			//IL_0024: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			//IL_0088: Expected F8, but got I4
			bool blown = Blown;
			bool flag = !blown;
			object obj = !flag;
			if (obj == null)
			{
				bool isOpen = IsOpen;
				bool flag2 = !isOpen;
				object obj2 = !flag2;
				object obj3 = ~obj2;
				double num = ((obj3 != null) ? 0.0 : 1.0);
				if ((double)open == num)
				{
					if (IsOpen)
					{
						return MonsterInDoorway();
					}
					return false;
				}
			}
			return true;
		}
	}

	public float Gap
	{
		get
		{
			float num = Height();
			return rise * num;
		}
	}

	public Vector3 Foot
	{
		get
		{
			//IL_0113: Expected VT, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I4
			//IL_0100: Expected VT, but got I4
			//IL_00ef: Expected VT, but got I4
			if ((object)panel != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				Transform parent = panel.parent;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = parent != null;
				if (!flag2)
				{
					return (Vector3)flag2;
				}
				if ((object)panel != null)
				{
					Transform parent2 = panel.parent;
					if ((object)parent2 != null)
					{
						return parent2.TransformPoint((Vector3)0);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (Vector3)ex;
		}
	}

	public Vector3 Through
	{
		get
		{
			//IL_0002: Expected VT, but got Obj
			return (Vector3)this;
		}
		private set
		{
			Vector3 vector = default;
			Through__BackingField = vector;
		}
	}

	public float Width
	{
		get
		{
			return Width__BackingField;
		}
		private set
		{
			Width__BackingField = value;
		}
	}

	public float Thickness
	{
		get
		{
			return Thickness__BackingField;
		}
		private set
		{
			Thickness__BackingField = value;
		}
	}

	private float LeftToGo
	{
		get
		{
			//IL_00d6: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_0094: Expected F8, but got I4
			bool isOpen = IsOpen;
			float prySeconds;
			if (~(prying ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				prySeconds = PrySeconds;
			}
			else
			{
				prySeconds = seconds;
			}
			bool flag2 = !isOpen;
			object obj4 = !flag2;
			object obj5 = ~obj4;
			double num = ((obj5 != null) ? 0.0 : 1.0);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			return (float)num * prySeconds;
		}
	}

	public byte Code
	{
		get
		{
			int num = index & 0x7F;
			return (byte)((uint)num | (modeMap ? 1u : 0u));
		}
	}

	public static GillaDoor PunchedDoor(byte code)
	{
		//IL_00e3: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		int num = code & 0x40;
		bool flag = num == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2 = code & 0xFF;
			return ModeDoor(num2);
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte code2 = (byte)(code & 0x3F);
		return Number(code2);
	}

	public unsafe static GillaDoor ModeDoor(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I
		//IL_0412: Expected Obj, but got I
		//IL_041b: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Ref
		//IL_01be: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Ref, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got I4
		//IL_02bb: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+40]");
		bool flag2 = (nint)0 == 0;
		IntPtr intPtr = default;
		UnityEngine.Object obj5 = (UnityEngine.Object)(nint)intPtr;
		object obj6 = 109895680;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Enumerator<, > val = default;
			obj4 = (object)(&val);
			bool flag5;
			object obj18 = default;
			GillaDoor result2 = default;
			object obj12;
			object obj13;
			object obj14;
			Enumerator<, > val2;
			do
			{
				if (val.MoveNext())
				{
					object obj9 = obj8;
					UnityEngine.Object obj10 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v31+E4]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)null != (UnityEngine.Object)null;
					flag5 = !flag4;
					obj12 = 0;
					continue;
				}
				obj13 = 0;
				obj14 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj15 = 0;
				while (true)
				{
					UnityEngine.Object result = null;
					obj5 = (UnityEngine.Object)obj6;
					((Enumerator<, >*)val2)->Dispose();
					bool flag6 = obj15 == null;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						bool flag7 = obj13 == null;
						object obj17 = !flag7;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj17 == null)
						{
							return (GillaDoor)result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = 1;
						obj4 = 1;
						obj15 = obj14;
						continue;
					}
					if ((nint)obj5 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj15 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
			while (flag5);
			NullReferenceException ex2 = new NullReferenceException();
			obj12 = 0;
			obj13 = 0;
			obj14 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj5 = null;
		}
		throw new NullReferenceException();
	}

	private static void ModeChanged()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v11+8]");
		object obj14 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj5;
		}
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X20_v3 (UnityEngine.Object)+6CC]");
			object obj20 = 0;
		}
		else
		{
			object obj20 = 0;
		}
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v20+A0]");
		object obj25 = 0;
	}

	public static void OfferMode(int shut, int broken, int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NewerMode(version, by))
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TakeMode(shut, broken, version, by);
		}
	}

	public static void OfferMode(NetworkApe from, int shut, int broken, int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06d6: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_070e: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_0776: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I4
		//IL_08d0: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I4
		//IL_0330: Expected I4, but got I8
		//IL_034a: Expected Obj, but got I4
		//IL_0457: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_0853: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I4
		//IL_02ca: Expected I4, but got I8
		//IL_02e4: Expected Obj, but got I4
		//IL_07bb: Expected Obj, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0416: Expected Obj, but got I4
		//IL_05e9: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I
		//IL_0823: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I
		//IL_0677: Expected Obj, but got I4
		//IL_06a7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)from == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)((SimulationBehaviour)from)._object == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)from)._object;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!networkObject._runner)
		{
			return;
		}
		ArgumentNullException ex = new ArgumentNullException();
		object obj10 = ex & 1;
		if (obj10 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = GillaNetGuard.IsMaster(((SimulationBehaviour)from)._runner, from.ownerRef);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj14 = 0;
		object obj15 = obj14;
		if (flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+A0]");
			object obj19 = 0;
			if ((nint)obj19 == shut)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+E4]");
				bool flag12 = (nint)0 == 0;
				object obj20 = !flag12;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBD18");
				obj15 = obj14;
				int num = (int)(version & 0x80000000L);
				bool flag13 = num == 0;
				object obj21 = !flag13;
				if (obj21 == null)
				{
					object obj22 = default;
					bool flag14 = (nint)obj22 != broken;
					obj17 = obj15;
					if (flag14)
					{
						goto IL_0360;
					}
				}
			}
			else
			{
				int num2 = (int)(version & 0x80000000L);
				bool flag15 = num2 == 0;
				object obj23 = !flag15;
				obj15 = obj17;
				if (obj23 == null)
				{
					goto IL_0360;
				}
			}
			goto IL_0447;
		}
		goto IL_071c;
		IL_0447:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
		object obj24 = 0;
		double num3 = -1.0;
		goto IL_0839;
		IL_0839:
		bool flag16 = obj24 == null;
		object obj25 = !flag16;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+A0]");
		object obj26 = 0;
		goto IL_071c;
		IL_07c5:
		TakeMode(shut, broken, version, by);
		return;
		IL_0360:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v27+E4]");
		bool flag17 = (nint)0 == 0;
		object obj27 = !flag17;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBC10");
		int num4 = version >> 16;
		object obj28 = default;
		bool flag18 = (nint)obj28 < 0;
		object obj29 = obj28 ^ obj28;
		object obj30 = obj28 & obj29;
		bool flag19 = (nint)obj30 < 0;
		object obj31 = obj28 + 65535;
		bool flag20 = flag18 == flag19;
		object obj32 = !flag20;
		object obj33 = ~obj32;
		object obj34 = ((obj33 != null) ? obj28 : obj31);
		obj15 = obj14;
		if (num4 >= (nint)obj34)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
			bool flag21 = (nint)0 == 0;
			object obj35 = !flag21;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+A0]");
			object obj36 = 0;
			float unscaledTime = Time.unscaledTime;
			obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v32+30]");
			bool flag22 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
			obj24 = 0;
			num3 = unscaledTime;
			if (!flag22)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
				bool flag23 = (nint)0 == 0;
				object obj37 = !flag23;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+A0]");
				object obj38 = 0;
				double num5 = unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X9_v19+30]");
				double num6 = num5 - 0.0;
				bool flag24 = num6 < 12.0;
				unscaledTime = (float)num6;
				if (flag24)
				{
					goto IL_071c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
				bool flag25 = (nint)0 == 0;
				object obj39 = !flag25;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj40 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v37+A0]");
					obj38 = 0;
				}
				_ = 3212836864L;
				goto IL_07c5;
			}
			goto IL_0839;
		}
		goto IL_0447;
		IL_071c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v34+E4]");
		bool flag26 = (nint)0 == 0;
		object obj41 = !flag26;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NewerMode(version, by))
		{
			return;
		}
		bool flag27 = !flag9;
		object obj42 = !flag27;
		int num7 = 0;
		int num8 = by;
		if (obj42 == null)
		{
			object obj43 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v33+E4]");
			bool flag28 = (nint)0 == 0;
			object obj44 = !flag28;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag29 = ModeFromThem(from, shut, broken);
			bool flag30 = !flag29;
			num7 = broken;
			num8 = shut;
			if (flag30)
			{
				return;
			}
		}
		object obj45 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v31+E4]");
		bool flag31 = (nint)0 == 0;
		object obj46 = !flag31;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		goto IL_07c5;
	}

	private static bool ModeFromThem(NetworkApe from, int shut, int broken)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0528: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I4
		//IL_062c: Expected Obj, but got I
		//IL_0635: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I4
		//IL_064a: Expected Obj, but got I
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected I4, but got Unknown
		//IL_0687: Expected Obj, but got I4
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected I4, but got Unknown
		//IL_06ad: Expected Obj, but got I4
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I
		//IL_0074: Expected I4, but got I8
		//IL_00a3: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_039f: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		//IL_060e: Expected Obj, but got I4
		//IL_06fd: Expected Obj, but got I
		//IL_072c: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_04fe: Expected I4, but got Obj
		//IL_024b: Expected Obj, but got I4
		//IL_0417: Expected Obj, but got I4
		//IL_0434: Invalid comparison between F4 and I4
		//IL_0445: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I4
		//IL_0323: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+A0]");
		object obj6 = 0;
		object obj7 = 109895680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+A0]");
		object obj9 = 0;
		int num = obj6 ^ shut;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10+4]");
		int num2 = (int)((nint)0 ^ (nint)broken);
		int num3 = num2 | num;
		object obj10 = num3 - 1;
		int num4 = num3 ^ obj10;
		bool flag4 = num4 < (nint)obj10;
		object obj11 = !flag4;
		object obj12 = num4 - obj10;
		bool flag5 = obj12 == null;
		object obj13 = ~obj11;
		object obj14 = obj13 | flag5;
		GillaDoor gillaDoor;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			int num5 = -1;
			int num6 = default;
			num5 = num6;
			int num7;
			do
			{
				num5++;
				num7 = num3 >> num5;
			}
			while ((num7 & 1) == 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			gillaDoor = ModeDoor(num5);
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v17+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(gillaDoor == null))
			{
				if (num2 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					object obj19 = 0;
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v39+E4]");
					bool flag8 = (nint)0 == 0;
					object obj21 = !flag8;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaModeRound current = GillaModeRound.Current;
					if ((num3 & broken) != 0)
					{
						int num8 = num3 & shut;
						bool flag9 = num8 == 0;
						object obj22 = !flag9;
						if (obj22 == null)
						{
							object obj23 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v43+E4]");
							bool flag10 = (nint)0 == 0;
							object obj24 = !flag10;
							if (obj24 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)current != (UnityEngine.Object)null)
							{
								if ((object)from != null && (object)current != null)
								{
									if (!current.Hunting(from.ownerRef))
									{
										goto IL_013f;
									}
									bool flag11 = (object)gillaDoor == null;
									object obj25 = !flag11;
									object obj26 = 0;
									if (obj25 != null)
									{
										goto IL_0469;
									}
								}
								goto IL_04f0;
							}
						}
					}
				}
				else
				{
					object obj27 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v27+E4]");
					bool flag12 = (nint)0 == 0;
					object obj28 = !flag12;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X24_v1+3C4]");
					bool flag13 = (nint)0 == 0;
					object obj29 = !flag13;
					if (obj29 == null)
					{
						_ = 1;
					}
					object obj30 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v31+E4]");
					bool flag14 = (nint)0 == 0;
					object obj31 = !flag14;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj30 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v31+A0]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v25+4]");
					int num9 = (int)((nint)0 & (nint)num);
					bool flag15 = num9 == 0;
					object obj33 = !flag15;
					if (obj33 == null)
					{
						if ((object)gillaDoor == null)
						{
							goto IL_04f0;
						}
						float leftToGo = gillaDoor.LeftToGo;
						bool flag16 = (double)leftToGo < 0.5;
						object obj34 = !flag16;
						float num10 = leftToGo - 0.5f;
						bool flag17 = num10 == 0f;
						object obj35 = !flag17;
						object obj36 = obj34 & obj35;
						object obj26 = 0;
						if (obj36 == null)
						{
							goto IL_0469;
						}
					}
				}
			}
		}
		goto IL_013f;
		IL_0469:
		if (gillaDoor.WorkedFrom(from))
		{
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v22+E4]");
			bool flag18 = (nint)0 == 0;
			object obj38 = !flag18;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Spent(from);
		}
		goto IL_013f;
		IL_04f0:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_013f:
		return false;
	}

	private static bool NewerMode(int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_049f: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_05f9: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_050f: Expected Obj, but got I4
		//IL_062d: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_0168: Expected I4, but got I8
		//IL_0182: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_01a0: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I4
		//IL_0547: Expected Obj, but got I4
		//IL_0664: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I4
		//IL_0475: Expected I4, but got Obj
		//IL_069b: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I4
		//IL_05b7: Expected Obj, but got I4
		//IL_06d0: Expected Obj, but got I
		//IL_06ee: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_0775: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+8]");
		if ((nint)0 <= (nint)version)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v13+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v15+8]");
			if ((nint)0 == version)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v62+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v62+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v51+C]");
				if ((nint)0 >= (nint)by)
				{
					goto IL_044b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj15 = 0;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaModeRound current = GillaModeRound.Current;
			int num = (int)(version & 0x80000000L);
			bool flag8 = num == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj19 = 0;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v19+E4]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag10 = (UnityEngine.Object)current != (UnityEngine.Object)null;
				bool flag11 = !flag10;
				UnityEngine.Object obj22 = null;
				if (!flag11)
				{
					if ((object)current == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					bool live = current.Live;
					bool flag12 = !live;
					obj22 = null;
					if (!flag12)
					{
						int round = current.Round;
						int num2 = round << 16;
						object obj23 = num2 + 131072;
						bool flag13 = (nint)obj23 <= version;
						obj22 = null;
						if (flag13)
						{
							goto IL_044b;
						}
					}
				}
				object obj24 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v24+E4]");
				bool flag14 = (nint)0 == 0;
				object obj25 = !flag14;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v28+E4]");
				bool flag15 = (nint)0 == 0;
				object obj27 = !flag15;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj26 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v28+A0]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v29+8]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v28+E4]");
					bool flag16 = (nint)0 == 0;
					object obj29 = !flag16;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj30 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v34+E4]");
					bool flag17 = (nint)0 == 0;
					object obj31 = !flag17;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj30 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v34+A0]");
					object obj32 = 0;
					int num3 = version >> 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v36+8]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v36+8]");
					object obj34 = (nint)0 + (nint)65535;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v36+8]");
					bool flag18 = (nint)0 < (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v36+8]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v36+8]");
					object obj35 = num4 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v36+8]");
					object obj36 = 0 & obj35;
					bool flag19 = (nint)obj36 < 0;
					bool flag20 = flag18 == flag19;
					object obj37 = !flag20;
					object obj38 = ~obj37;
					if (obj38 == null)
					{
						obj33 = obj34;
					}
					if (num3 == (nint)obj33)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v34+E4]");
						bool flag21 = (nint)0 == 0;
						object obj39 = !flag21;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBC10");
						object obj41 = default;
						object obj40 = version - obj41;
						object obj42 = obj40 - 1001;
						bool flag22 = (nint)obj42 < 0;
						object obj43 = obj40 ^ 0x3E9;
						object obj44 = obj40 ^ obj42;
						object obj45 = obj43 & obj44;
						bool flag23 = (nint)obj45 < 0;
						bool flag24 = flag22 == flag23;
						return !flag24;
					}
				}
				return true;
			}
		}
		goto IL_044b;
		IL_044b:
		return false;
	}

	private unsafe static void TakeMode(int shut, int broken, int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_0458: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I4
		//IL_048f: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_04a9: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got I
		//IL_03b2: Expected I4, but got Obj
		//IL_0141: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_03f4: Expected I4, but got Obj
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Ref, but got Unknown
		//IL_0417: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0223: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj6 = 0;
		obj6 = shut;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v18+18]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v32+A0]");
			obj12 = 0;
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v18+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v18+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj16 = 0;
			int num = (int)obj16;
			Enumerator<, > val = default;
			object obj17;
			object obj18;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				obj17 = 0;
				obj18 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj19 = 0;
				object obj23 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
					object obj20 = 0;
					num = (int)obj20;
					((Enumerator<, >*)val2)->Dispose();
					bool flag8 = obj19 == null;
					object obj21 = !flag8;
					if (obj21 == null)
					{
						bool flag9 = obj17 == null;
						object obj22 = !flag9;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj22 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch (num)
					{
					case 2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj17 = 1;
						obj19 = obj18;
						break;
					case 1:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj19 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj18 = obj23;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				return;
			}
			GillaDoor gillaDoor = null;
			NullReferenceException ex2 = new NullReferenceException();
			obj17 = 0;
			obj18 = 0;
			val2 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private static void NewModeRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+A0]");
		object obj6 = 0;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+A0]");
		object obj8 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+A0]");
		object obj10 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+A0]");
		object obj12 = 0;
		_ = 0;
		_ = 3212836864L;
		_ = -1;
	}

	private unsafe static void FollowRound()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04b6: Expected Obj, but got I4
		//IL_0690: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I
		//IL_04e4: Expected Obj, but got I
		//IL_0513: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		//IL_0531: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I4
		//IL_0565: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I
		//IL_071d: Expected Obj, but got I4
		//IL_05bc: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got I4
		//IL_0624: Expected Obj, but got I
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Ref, but got Unknown
		//IL_064f: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_03b8: Expected Obj, but got I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got I4
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0430: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj4 = 0;
		int frameCount = Time.frameCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+14]");
		if ((nint)0 == frameCount)
		{
			return;
		}
		int frameCount2 = Time.frameCount;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7+A0]");
		object obj8 = 0;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			return;
		}
		bool flag7 = (object)current == null;
		UnityEngine.Object obj15 = null;
		GillaModeRound gillaModeRound = current;
		if (!flag7)
		{
			if (!current.Live)
			{
				return;
			}
			int round = current.Round;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v21+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v21+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v22+10]");
			if ((nint)round == 0)
			{
				return;
			}
			int round2 = current.Round;
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj20 = !flag9;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+A0]");
			object obj21 = 0;
			gillaModeRound = (GillaModeRound)(round2 << 16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+A0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X9_v16+8]");
			bool flag11 = 0 >= (nint)gillaModeRound;
			obj15 = null;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+E4]");
				bool flag12 = (nint)0 == 0;
				object obj24 = !flag12;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBD68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBDC4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBC60");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBCBC");
				obj19 = obj;
				obj15 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+E4]");
			bool flag13 = (nint)0 == 0;
			object obj25 = !flag13;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+A0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v30+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v30+40]");
				Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
				object obj27 = 0;
				obj15 = (UnityEngine.Object)obj27;
				Enumerator<, > val = default;
				object obj28;
				object obj29;
				Enumerator<, > val2;
				if (!val.MoveNext())
				{
					obj28 = 0;
					obj29 = 0;
					val2 = (Enumerator<, >)(ref val);
					object obj30 = 0;
					object obj34 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
						object obj31 = 0;
						obj15 = (UnityEngine.Object)obj31;
						((Enumerator<, >*)val2)->Dispose();
						bool flag14 = obj30 == null;
						object obj32 = !flag14;
						if (obj32 == null)
						{
							bool flag15 = obj28 == null;
							object obj33 = !flag15;
							OutOfMemoryException ex = (OutOfMemoryException)val2;
							if (obj33 == null)
							{
								return;
							}
						}
						else
						{
							OutOfMemoryException ex = new OutOfMemoryException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						if ((nint)obj15 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj28 = 1;
							obj30 = obj29;
							continue;
						}
						if ((nint)obj15 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj30 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj29 = obj34;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				GillaDoor gillaDoor = null;
				NullReferenceException ex2 = new NullReferenceException();
				obj28 = 0;
				obj29 = 0;
				val2 = (Enumerator<, >)(ref val);
			}
		}
		throw new NullReferenceException();
	}

	private void NewRound()
	{
		//IL_0020: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_004d: Expected VT, but got Obj
		//IL_0069: Expected I4, but got I8
		punches = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v5+A0]");
		object obj3 = 0;
		shakeFrom = -1f;
		knockWay = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v6+8]");
		_ = 0;
		heldBy = -1;
		Snap();
	}

	public unsafe void Punch(Vector3 at, Vector3 way)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I4
		//IL_0521: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I4
		//IL_00ad: Expected VT, but got I4
		//IL_022d: Expected VT, but got I
		//IL_0235: Expected VT, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0130: Expected VT, but got I4
		//IL_014e: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I4
		//IL_03d5: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I
		//IL_0194: Expected VT, but got I4
		//IL_0579: Expected Obj, but got I
		//IL_0485: Expected Obj, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01d1: Expected VT, but got I4
		//IL_059e: Expected Obj, but got I
		//IL_04b5: Expected Obj, but got I4
		//IL_05b8: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected I4, but got Unknown
		//IL_04fb: Expected Obj, but got I4
		//IL_0401: Expected VT, but got I4
		//IL_0401: Expected VT, but got Ref
		//IL_0409: Expected VT, but got I4
		//IL_0411: Expected VT, but got I4
		//IL_05dd: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I4
		if (!Punchable)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v9+A0]");
		object obj8 = 0;
		int num = punches + 1;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)obj8 != null;
		bool flag5 = !flag4;
		Vector3 at2 = (Vector3)0;
		Vector3 away;
		if (!flag5)
		{
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v52+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X21_v5 (UnityEngine.Object)+40]");
			bool flag7 = (UnityEngine.Object)0 != null;
			bool flag8 = !flag7;
			at2 = (Vector3)0;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X21_v5 (UnityEngine.Object)+40]");
				object obj13 = 0;
				object obj14 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v57+E4]");
				bool flag9 = (nint)0 == 0;
				object obj15 = !flag9;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X22_v11+30]");
				bool flag10 = (UnityEngine.Object)0;
				bool flag11 = !flag10;
				at2 = (Vector3)0;
				if (!flag11)
				{
					ArgumentNullException ex = new ArgumentNullException();
					object obj16 = ex & 1;
					bool flag12 = obj16 == null;
					at2 = (Vector3)0;
					if (!flag12)
					{
						int num2 = index | 0x40;
						byte b = (byte)(modeMap ? index : num2);
						object obj17 = default;
						RpcInfo info = default;
						((NetworkApe)obj8).RPC_DoorPunch(b, (byte)num, (Vector3)(&obj17), (Vector3)0, info);
						at2 = (Vector3)num;
						away = (Vector3)b;
						goto IL_023a;
					}
				}
			}
		}
		IntPtr intPtr = default;
		Punched(num, at2, (Vector3)(nint)intPtr);
		away = (Vector3)num;
		goto IL_023a;
		IL_023a:
		if (num < 3)
		{
			return;
		}
		if (~(modeMap ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			object obj18 = 0;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v16+E4]");
			bool flag13 = (nint)0 == 0;
			object obj20 = !flag13;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj21 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+E4]");
			bool flag14 = (nint)0 == 0;
			object obj22 = !flag14;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+A0]");
			object obj23 = 0;
			int num3 = 1 << index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v15+4]");
			int num4 = (int)((nint)num3 | (nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+E4]");
			bool flag15 = (nint)0 == 0;
			object obj24 = !flag15;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+A0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+E4]");
			bool flag16 = (nint)0 == 0;
			object obj26 = !flag16;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+A0]");
			object obj27 = 0;
			int num5 = 1 << index;
			int num6 = ~num5;
			int num7 = obj27 & num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+E4]");
			bool flag17 = (nint)0 == 0;
			object obj28 = !flag17;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj18;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v26+A0]");
			object obj29 = 0;
			obj29 = num7;
			ModeChanged();
		}
		else
		{
			bool flag18 = Blow(away);
		}
	}

	public void Punched(int hit, Vector3 at, Vector3 way)
	{
		//IL_0228: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I
		//IL_0107: Expected F4, but got Obj
		//IL_025d: Expected Obj, but got I4
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected I4, but got Unknown
		//IL_02ce: Expected Obj, but got I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got I4
		//IL_033c: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I4
		//IL_018e: Expected VT, but got I4
		//IL_019d: Expected VT, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_013c: Expected F4, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_01ff: Expected VT, but got F4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_01d1: Expected VT, but got F4
		bool blown = Blown;
		bool flag = !blown;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj3 = default;
		object obj2 = obj3 * obj3;
		object obj5 = default;
		object obj4 = obj5 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj6 = 0;
		object obj7 = obj4 + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num2;
		float num3 = default;
		if ((nint)obj7 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
				object obj11 = obj3 / 0;
				num2 = 0f / num3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj12 = 0;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v22+A0]");
				object obj14 = 0;
				num2 = (float)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v23+8]");
				object obj11 = 0;
			}
		}
		else
		{
			object obj15 = this + 324;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
			object obj11 = 0;
			num2 = (float)obj15;
		}
		int num4 = punches;
		object obj16 = obj6;
		object obj17 = punches - hit;
		bool flag3 = (nint)obj17 < 0;
		bool flag4 = obj17 == null;
		int num5 = punches ^ hit;
		int num6 = punches ^ obj17;
		int num7 = num5 & num6;
		bool flag5 = num7 < 0;
		bool flag6 = flag3 == flag5;
		object obj18 = !flag4;
		object obj19 = flag6 & obj18;
		object obj20 = ~obj19;
		if (obj20 != null)
		{
			num4 = hit;
		}
		punches = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v6+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float volume = default;
		float pitchMin = default;
		Sfx.Play(punchSounds, (Vector3)0, volume, pitchMin, num3);
		HitSparks((Vector3)0, at);
		if (hit < 3)
		{
			knockWay = (Vector3)num2;
			float time = Time.time;
			shakeFrom = time;
			Place();
		}
		else
		{
			blowAway = (Vector3)num2;
		}
	}

	private Vector3 Knock()
	{
		//IL_0423: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I
		//IL_0034: Invalid comparison between F4 and I4
		//IL_0366: Expected Obj, but got I4
		//IL_000a: Expected VT, but got Obj
		//IL_04df: Expected Obj, but got I
		//IL_04ef: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0332: Expected VT, but got Obj
		//IL_013f: Expected Obj, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected I4, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I4
		//IL_0405: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_025f: Expected Obj, but got I4
		//IL_0311: Expected VT, but got I4
		//IL_0300: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v7+A0]");
		object obj3 = 0;
		object obj4 = knockWay - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v1 (GillaDoor)+3C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v8+8]");
		object obj5 = num - 0;
		object obj6 = obj4 * obj4;
		object obj7 = obj5 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj8 = obj7 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if ((nint)obj8 < 0)
		{
			return (Vector3)this;
		}
		float num2 = shakeFrom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj10 = 0;
		if (!(shakeFrom < 0f))
		{
			float time = Time.time;
			num2 = time - shakeFrom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			obj9 = 0;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			float num4 = num3 / 0f;
			if ((double)num4 < 1.0)
			{
				float num5 = num4 * 30f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
				double num6 = 1.0 - (double)num4;
				num2 = (float)num6 * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
				obj9 = 0;
			}
		}
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v6+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+20]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v14+18]");
			int num7 = (int)(-1);
			object obj15 = punches - num7;
			bool flag2 = (nint)obj15 < 0;
			int num8 = punches ^ num7;
			int num9 = punches ^ obj15;
			int num10 = num8 & num9;
			bool flag3 = num10 < 0;
			bool flag4 = flag2 == flag3;
			object obj16 = !flag4;
			object obj17 = ~obj16;
			if (obj17 == null)
			{
				num7 = punches;
			}
			bool flag5 = punches < 0;
			int num11 = punches ^ punches;
			int num12 = punches & num11;
			bool flag6 = num12 < 0;
			bool flag7 = flag5 == flag6;
			object obj18 = !flag7;
			object obj19 = ~obj18;
			int num13 = ((obj19 != null) ? num7 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v14+18]");
			bool flag8 = (nint)num13 < (nint)0;
			object obj20 = !flag8;
			if (obj20 != null)
			{
				goto IL_0324;
			}
			if ((object)panel != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v13+20]");
				object obj21 = (nint)0 + (nint)num13;
				Transform parent = panel.parent;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj22 = 0;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v20+E4]");
				bool flag9 = (nint)0 == 0;
				object obj24 = !flag9;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag10 = parent != null;
				if (!flag10)
				{
					return (Vector3)flag10;
				}
				if ((object)panel != null)
				{
					Transform parent2 = panel.parent;
					if ((object)parent2 != null)
					{
						return parent2.InverseTransformVector((Vector3)0);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0324;
		IL_0324:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector3)ex2;
	}

	private Quaternion KnockTurn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03ad: Expected VT, but got Obj
		//IL_03cf: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I
		//IL_0547: Expected Obj, but got I
		//IL_0027: Expected VT, but got Obj
		//IL_03a5: Expected VT, but got Obj
		//IL_0051: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected I4, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_03f1: Expected I4, but got I8
		//IL_040b: Expected Obj, but got I4
		//IL_0429: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_046d: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0163: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0266: Expected VT, but got I4
		//IL_0519: Expected Obj, but got I4
		//IL_057c: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_02aa: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_037b: Expected F4, but got I
		//IL_02d9: Expected VT, but got I4
		//IL_02f6: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		Quaternion result = (Quaternion)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v8 (UnityEngine.Quaternion)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			result = (Quaternion)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v8 (UnityEngine.Quaternion)+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+28]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+28]");
		int num5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v5+18]");
			int num = (int)(-1);
			object obj5 = punches - num;
			bool flag2 = (nint)obj5 < 0;
			int num2 = punches ^ num;
			int num3 = punches ^ obj5;
			int num4 = num2 & num3;
			bool flag3 = num4 < 0;
			bool flag4 = flag2 == flag3;
			object obj6 = !flag4;
			object obj7 = ~obj6;
			num5 = ((obj7 != null) ? num : punches);
			int num6 = (int)(punches & 0x80000000L);
			bool flag5 = num6 == 0;
			object obj8 = !flag5;
			if (obj8 == null && num5 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v21+A0]");
				object obj11 = 0;
				object obj12 = knockWay - obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+3C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+8]");
				object obj13 = num7 - 0;
				object obj14 = obj12 * obj12;
				object obj15 = obj13 * obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				object obj16 = obj15 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				if ((nint)obj16 >= 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD0A0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+1C]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD038]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+18]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD038]");
						object obj19 = num8 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD034]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+1C]");
						object obj20 = num9 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+1C]");
						object obj22 = default;
						object obj21 = 0 * obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD038]");
						object obj24 = default;
						object obj23 = obj24 * 0;
						object obj25 = obj21 - obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD0A0]");
						Transform parent = ((Transform)0).parent;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
						object obj26 = 0;
						object obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v26+E4]");
						bool flag6 = (nint)0 == 0;
						object obj28 = !flag6;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj29 = obj19 - obj20;
						bool flag7 = parent != null;
						bool flag8 = !flag7;
						object obj30 = obj25;
						object obj31 = obj25;
						Vector3 vector = (Vector3)0;
						if (flag8)
						{
							goto IL_04ef;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD0A0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD0A0]");
							Transform parent2 = ((Transform)0).parent;
							if ((object)parent2 != null)
							{
								Vector3 vector2 = parent2.InverseTransformDirection((Vector3)0);
								obj30 = obj25;
								obj31 = obj29;
								vector = (Vector3)0;
								object obj32 = default;
								obj18 = obj32;
								obj17 = obj25;
								goto IL_04ef;
							}
						}
					}
					goto IL_0389;
				}
			}
			goto IL_0384;
		}
		goto IL_0389;
		IL_0389:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0397;
		IL_0397:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Quaternion)ex2;
		IL_04ef:
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		object obj34 = !flag9;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v23+A0]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v28+28]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v28+28]");
		if ((nint)0 == 0)
		{
			goto IL_0389;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v29+18]");
		bool flag10 = (nint)num5 < (nint)0;
		object obj37 = !flag10;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v28+28]");
			object obj38 = (nint)0 + (nint)num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v30+20]");
			Vector3 axis = default;
			result = Quaternion.Internal_AngleAxis(0f, ref axis);
			goto IL_0384;
		}
		goto IL_0397;
		IL_0384:
		return result;
	}

	private void Shudder()
	{
		//IL_002a: Invalid comparison between F4 and I
		float time = Time.time;
		float num = time - shakeFrom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		if (num > 0f)
		{
			shakeFrom = -1f;
		}
		Place();
	}

	private unsafe void HitSparks(Vector3 at, Vector3 way)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a7: Expected Obj, but got I
		//IL_00c2: Expected VT, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_0388: Expected VT, but got I4
		//IL_03a5: Expected F4, but got I
		//IL_03a5: Expected F4, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I
		//IL_031c: Expected F4, but got I
		//IL_0354: Expected VT, but got I4
		//IL_0371: Expected F4, but got I
		//IL_0371: Expected F4, but got I
		//IL_020b: Expected F4, but got I
		//IL_020b: Expected F4, but got I
		//IL_0244: Expected VT, but got Ref
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = prySparks == null;
		bool flag3 = !flag2;
		object obj5 = default;
		object obj4 = obj5;
		double num2 = default;
		double num = num2;
		object obj7 = default;
		object obj6 = obj7;
		int num3 = 0;
		ParticleSystem particleSystem = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04A8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A898]");
			obj4 = 0;
			IntPtr intPtr = default;
			Color warm = default;
			Color cool = default;
			ParticleSystem particleSystem2 = (prySparks = MakeSparks((string)obj8, 450, (Color)(nint)intPtr, warm, cool));
			object obj9 = this + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num = 1.0;
			num3 = 450;
			particleSystem = particleSystem2;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = prySparks == null;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
			object obj14 = obj5 * 0;
			object obj15 = obj7 - obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj16 = 24;
			ParticleSystem.EmitParams emitParams = default;
			object obj20 = default;
			do
			{
				emitParams.position = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
				float num5 = UnityEngine.Random.Range(num4, 0f);
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
				object obj17 = obj15 * 0;
				object obj18 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v14+A0]");
				object obj19 = 0;
				float num6 = (float)obj5 * num5;
				float num7 = (float)obj17 - num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				float num8 = UnityEngine.Random.Range(0f, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v15+20]");
				float num9 = 0f * num8;
				float num10 = num7 + num9;
				emitParams.velocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
				float startLifetime = UnityEngine.Random.Range(num11, 0f);
				emitParams.startLifetime = startLifetime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACC4]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE74]");
				float startSize = UnityEngine.Random.Range(num12, 0f);
				emitParams.startSize = startSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				prySparks.Emit((ParticleSystem.EmitParams)(&obj20), 1);
				obj16--;
			}
			while ((nint)obj16 != 1);
		}
	}

	private void LooseAtRest(bool told)
	{
		toldAtRest = told;
		stillSince = 0f;
	}

	public unsafe void Hold(int by, bool right, Vector3 pos, Quaternion rot)
	{
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_0621: Expected Obj, but got I
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Ref, but got Unknown
		//IL_064c: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected VT, but got Unknown
		//IL_0216: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got Ref
		//IL_0267: Expected Obj, but got I4
		if (~(modeMap ? 1u : 0u) != 0 || !Blown)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (flying == null)
		{
			Rigidbody rigidbody = MakeLoose();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		bool flag2 = false;
		bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v11 (System.Boolean)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = ((bool*)(flag2 ? 1 : 0))->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v11 (System.Boolean)+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v7+40]");
		bool flag4 = (nint)0 == 0;
		Rigidbody rigidbody2 = null;
		UnityEngine.Object obj7 = default;
		UnityEngine.Object obj6 = obj7;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val3 = default;
		Enumerator<, > val2 = val3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v7+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj10 = 0;
			obj8 = 0;
			Enumerator<, > val4 = default;
			object obj19 = default;
			Quaternion quaternion = default;
			object obj23 = default;
			while (true)
			{
				object obj13;
				Enumerator<, > val5;
				if (val.MoveNext())
				{
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v41+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj7 != this;
					bool flag7 = !flag6;
					obj8 = 0;
					if (flag7)
					{
						continue;
					}
					if ((object)obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ stack_-A8 (UnityEngine.Object)+50]");
						bool flag8 = (nint)0 != by;
						obj8 = 0;
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ stack_-A8 (UnityEngine.Object)+54]");
							bool flag9 = (nint)0 != (right ? 1 : 0);
							obj8 = 0;
							if (!flag9)
							{
								_ = 4294967295L;
								obj8 = 0;
							}
						}
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					rigidbody2 = null;
					obj6 = null;
					val = val4;
					obj13 = 0;
					val2 = val4;
					val5 = (Enumerator<, >)(ref val);
					obj8 = 0;
					obj9 = this;
					flag2 = right;
					break;
				}
				rigidbody2 = null;
				obj6 = null;
				val = val4;
				obj13 = 0;
				val2 = val4;
				val5 = (Enumerator<, >)(ref val);
				object obj14 = 7;
				object obj15 = 0;
				flag2 = right;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
					object obj16 = 0;
					obj9 = (UnityEngine.Object)obj16;
					((Enumerator<, >*)val5)->Dispose();
					bool flag10 = obj15 == null;
					object obj17 = !flag10;
					if (obj17 == null)
					{
						bool flag11 = (object)obj6 == null;
						object obj18 = !flag11;
						OutOfMemoryException ex2 = (OutOfMemoryException)val5;
						if (obj18 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj9 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj6 = (UnityEngine.Object)1;
						obj15 = obj13;
					}
					else
					{
						if ((nint)obj9 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj15 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = obj19;
					}
					obj14 = 0;
				}
				if ((nint)obj14 != 7)
				{
					bool flag12 = obj14 == null;
					object obj20 = !flag12;
					if (obj20 != null)
					{
						return;
					}
				}
				heldBy = by;
				heldRight = flag2;
				heldPos = (Vector3)val3;
				heldRot = quaternion;
				toldAtRest = true;
				stillSince = 0f;
				if ((object)flying == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
				object obj21 = 0;
				obj8 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
				object obj22 = obj23 & 1;
				if (obj22 != null)
				{
					bool flag13 = (object)rigidbody2 == null;
					obj9 = (UnityEngine.Object)(&rigidbody2);
					if (flag13)
					{
						break;
					}
					rigidbody2.isKinematic = true;
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	public void LetGo(Vector3 at, Quaternion rot, Vector3 velocity, Vector3 spin)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0168: Expected I4, but got I8
		//IL_018a: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0083: Expected VT, but got I4
		//IL_0083: Expected VT, but got I4
		//IL_00ae: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00f1: Expected VT, but got I4
		//IL_0104: Expected VT, but got I4
		//IL_012a: Expected VT, but got I4
		//IL_013d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		heldBy = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = flying == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Transform transform = flying.transform;
			transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
			toldAtRest = false;
			stillSince = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
			object obj7 = default;
			object obj6 = obj7 & 1;
			if (obj6 != null)
			{
				Rigidbody rigidbody = default;
				rigidbody.position = (Vector3)0;
				rigidbody.rotation = (Quaternion)0;
				rigidbody.isKinematic = false;
				rigidbody.linearVelocity = (Vector3)0;
				rigidbody.angularVelocity = (Vector3)0;
				rigidbody.WakeUp();
			}
		}
	}

	public void Rest(Vector3 at, Quaternion rot)
	{
		//IL_01be: Expected I4, but got I8
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00cb: Expected VT, but got I4
		//IL_00cb: Expected VT, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0123: Expected VT, but got I4
		//IL_0136: Expected VT, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_0183: Expected VT, but got I4
		//IL_0196: Expected VT, but got I4
		if ((int)(heldBy & 0x80000000L) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = flying == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		toldAtRest = true;
		Transform transform = flying.transform;
		transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
		object obj7 = default;
		object obj6 = obj7 & 1;
		if (obj6 != null)
		{
			Rigidbody rigidbody = default;
			rigidbody.position = (Vector3)0;
			rigidbody.rotation = (Quaternion)0;
			bool isKinematic = rigidbody.isKinematic;
			bool flag4 = !isKinematic;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				rigidbody.linearVelocity = (Vector3)0;
				rigidbody.angularVelocity = (Vector3)0;
				rigidbody.Sleep();
			}
		}
	}

	public unsafe bool NewlyAtRest(out Vector3 at, out Quaternion rot)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006e: Expected I4, but got I8
		//IL_00a1: Expected Obj, but got I4
		//IL_0397: Expected I4, but got Obj
		//IL_00e8: Invalid comparison between F4 and I4
		//IL_00f9: Expected Obj, but got I4
		//IL_0104: Invalid comparison between F4 and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_02c0: Expected VT, but got F4
		//IL_02e6: Expected VT, but got F4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01f0: Expected F8, but got I
		//IL_0200: Invalid comparison between F4 and I
		//IL_0421: Invalid comparison between F4 and I
		//IL_0322: Expected Ref, but got F4
		//IL_034e: Expected Ref, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)null;
		ref Quaternion reference2 = ref *(Quaternion*)null;
		_ = 0;
		Transform loose = Loose;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = loose == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		Transform transform;
		float num9;
		if (obj4 == null && (int)(heldBy & 0x80000000L) != 0)
		{
			bool flag4 = (byte)(~(toldAtRest ? 1u : 0u)) != 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				if ((object)flying != null)
				{
					transform = flying.transform;
					bool flag5 = stillSince < 0f;
					object obj6 = !flag5;
					bool flag6 = stillSince == 0f;
					object obj7 = ~obj6;
					object obj8 = obj7 | flag6;
					if (obj8 == null)
					{
						if ((object)transform != null)
						{
							Vector3 position = transform.position;
							float num = stillSince - (float)stillAt;
							double num3 = default;
							double num2 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+80]");
							double num4 = num2 - 0.0;
							object obj10 = default;
							object obj9 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+84]");
							obj10 = obj9 - 0;
							float num5 = num * num;
							double num6 = num4 * num4;
							float num7 = num5 + (float)num6;
							object obj11 = obj10 * obj10;
							float num8 = num7 + (float)obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA5C]");
							num3 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA5C]");
							if (!(num8 > 0f))
							{
								Quaternion rotation = transform.rotation;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FBEC44");
								bool flag7 = !((double)num8 > 2.0);
								num3 = 2.0;
								if (flag7)
								{
									goto IL_03f7;
								}
							}
							num9 = (stillSince = Time.time);
							goto IL_02a9;
						}
					}
					else
					{
						num9 = (stillSince = Time.time);
						if ((object)transform != null)
						{
							goto IL_02a9;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		goto IL_037b;
		IL_037b:
		return false;
		IL_03f7:
		float time = Time.time;
		float num10 = time - stillSince;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		if (!(num10 < 0f))
		{
			toldAtRest = true;
			Vector3 position2 = transform.position;
			reference = ref *(Vector3*)num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			_ = 0;
			Quaternion rotation2 = transform.rotation;
			reference2 = ref *(Quaternion*)num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+84]");
			_ = 0;
			return true;
		}
		goto IL_037b;
		IL_02a9:
		Vector3 position3 = transform.position;
		stillAt = (Vector3)num9;
		Quaternion rotation3 = transform.rotation;
		stillTurned = (Quaternion)num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+84]");
		_ = 0;
		goto IL_03f7;
	}

	private void LateUpdate()
	{
		//IL_032c: Expected I4, but got I8
		//IL_0346: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_0206: Expected VT, but got I4
		//IL_0206: Expected VT, but got I4
		//IL_02a7: Expected VT, but got I4
		//IL_02a7: Expected VT, but got I4
		//IL_02bc: Expected Obj, but got I
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_036c: Expected VT, but got I4
		//IL_036c: Expected VT, but got I4
		//IL_02ff: Expected VT, but got I4
		//IL_0312: Expected VT, but got I4
		int num = (int)(heldBy & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = flying == null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = !heldRight;
		bool right = !flag6;
		Transform transform = Hand(heldBy, right);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (transform == null)
		{
			Transform transform2 = flying.transform;
			Vector3 position = transform2.position;
			Transform transform3 = flying.transform;
			Quaternion rotation = transform3.rotation;
			Vector3 velocity = default;
			Vector3 spin = default;
			LetGo((Vector3)0, (Quaternion)0, velocity, spin);
			return;
		}
		Vector3 position2 = transform.position;
		Quaternion rotation2 = transform.rotation;
		Vector3 vector = (Quaternion)0 * (Vector3)0;
		Quaternion rotation3 = transform.rotation;
		Transform transform4 = flying.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP2 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction EXT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		transform4.SetPositionAndRotation((Vector3)0, (Quaternion)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5360]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626EA4");
		object obj13 = default;
		object obj12 = obj13 & 1;
		if (obj12 != null)
		{
			Rigidbody rigidbody = default;
			rigidbody.position = (Vector3)0;
			rigidbody.rotation = (Quaternion)0;
		}
	}

	private unsafe static Transform Hand(int by, bool right)
	{
		//IL_0010: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I4
		//IL_06c5: Expected Obj, but got I
		//IL_06e7: Expected Obj, but got I4
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_08fc: Expected Obj, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0155: Expected VT, but got I4
		//IL_070f: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_079d: Expected Obj, but got I
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_0310: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected Obj, but got I4
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_094c: Expected Obj, but got I4
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got I4
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I4
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected Ref, but got Unknown
		//IL_09db: Expected Obj, but got I4
		//IL_03bf: Expected Obj, but got I4
		//IL_050a: Expected Obj, but got I4
		//IL_04cd: Expected Obj, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I4
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got I4
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got I4
		//IL_087e: Expected Obj, but got I4
		//IL_03fa: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_09f9: Expected Obj, but got I
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected Obj, but got I4
		//IL_077f: Expected Obj, but got I4
		//IL_096a: Expected Obj, but got I
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected Obj, but got I4
		//IL_060c: Expected Obj, but got I4
		//IL_061d: Expected Obj, but got I4
		//IL_0444: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got I4
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected Obj, but got I4
		//IL_084f: Expected Obj, but got I4
		//IL_0464: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		UnityEngine.Object obj7 = (UnityEngine.Object)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		UnityEngine.Object obj8 = (UnityEngine.Object)val;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v8 (UnityEngine.Object)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num;
		UnityEngine.Object obj15 = default;
		Enumerator<, > val2;
		UnityEngine.Object obj14;
		object obj16;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v88+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			PlayerRef playerRef = default;
			num = playerRef.PlayerId;
			UnityEngine.Object obj13 = null;
		}
		else
		{
			bool flag5 = (object)obj8 == null;
			obj14 = obj15;
			val2 = (Enumerator<, >)0;
			PlayerRef playerRef = (PlayerRef)0;
			obj16 = 0;
			UnityEngine.Object obj13 = null;
			if (flag5)
			{
				goto IL_05a2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X21_v4 (UnityEngine.Object)+6CC]");
			num = 0;
			playerRef = (PlayerRef)0;
			obj13 = null;
		}
		bool flag6 = num != by;
		obj16 = 0;
		Transform result;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v30+E4]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj20 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v34+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj17;
			}
			object obj22 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v34+A0]");
			val = (Enumerator<, >)0;
			obj8 = (UnityEngine.Object)val;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj23 = !flag9;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag10 = obj8 != null;
			bool flag11 = !flag10;
			obj16 = 0;
			UnityEngine.Object obj13 = null;
			if (!flag11)
			{
				object obj24 = obj17;
				if (right)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v38+E4]");
					bool flag12 = (nint)0 == 0;
					object obj25 = !flag12;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj26 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v52+E4]");
					bool flag13 = (nint)0 == 0;
					object obj27 = !flag13;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj26 = obj17;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v52+A0]");
					object obj28 = 0;
					obj7 = (UnityEngine.Object)obj28;
					bool flag14 = obj28 == null;
					obj14 = obj15;
					val2 = (Enumerator<, >)0;
					obj16 = 0;
					obj13 = null;
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v8 (UnityEngine.Object)+C8]");
						result = (Transform)0;
						goto IL_04e3;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v38+E4]");
					bool flag15 = (nint)0 == 0;
					object obj29 = !flag15;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj30 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v42+E4]");
					bool flag16 = (nint)0 == 0;
					object obj31 = !flag16;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj30 = obj17;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v42+A0]");
					object obj32 = 0;
					obj7 = (UnityEngine.Object)obj32;
					bool flag17 = obj32 == null;
					obj14 = obj15;
					val2 = (Enumerator<, >)0;
					obj16 = 0;
					obj13 = null;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v8 (UnityEngine.Object)+C0]");
						result = (Transform)0;
						goto IL_04e3;
					}
				}
				goto IL_05a2;
			}
		}
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v16+E4]");
		bool flag18 = (nint)0 == 0;
		object obj34 = !flag18;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v16+A0]");
		obj7 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v8 (UnityEngine.Object)+8]");
		bool flag19 = (nint)0 == 0;
		obj14 = obj15;
		val2 = (Enumerator<, >)0;
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v8 (UnityEngine.Object)+8]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			obj7 = obj15;
			Enumerator<, > val3 = default;
			Transform result2 = default;
			object obj43 = default;
			object obj39;
			Enumerator<, > val4;
			Enumerator<, > val5;
			UnityEngine.Object obj13;
			while (true)
			{
				object obj40;
				if (val2.MoveNext())
				{
					object obj35 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v22+E4]");
					obj7 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v22+E4]");
					bool flag20 = (nint)0 == 0;
					object obj36 = !flag20;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag21 = obj15 != null;
					bool flag22 = !flag21;
					obj16 = 0;
					if (flag22)
					{
						continue;
					}
					if ((object)obj15 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-68 (UnityEngine.Object)+6CC]");
					obj7 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-68 (UnityEngine.Object)+6CC]");
					bool flag23 = (nint)0 != by;
					obj16 = 0;
					if (flag23)
					{
						continue;
					}
					bool flag24 = !right;
					object obj37 = !flag24;
					object obj38 = ~obj37;
					if (obj38 == null)
					{
						obj7 = (UnityEngine.Object)120;
					}
					else
					{
						obj7 = (UnityEngine.Object)112;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ stack_-68 (UnityEngine.Object)+v284 @ X8_v8 (UnityEngine.Object)]");
					result = (Transform)0;
					obj14 = null;
					val2 = val3;
					obj39 = 0;
					val = (Enumerator<, >)120;
					val4 = val3;
					val5 = (Enumerator<, >)(ref val2);
					obj16 = 0;
					obj40 = 0;
					goto IL_09b0;
				}
				obj14 = null;
				val2 = val3;
				obj39 = 0;
				val = (Enumerator<, >)(ref val2);
				val4 = val3;
				val5 = (Enumerator<, >)(ref val2);
				obj40 = 0;
				goto IL_088c;
				IL_09b0:
				obj13 = (UnityEngine.Object)obj;
				((Enumerator<, >*)val5)->Dispose();
				bool flag25 = obj40 == null;
				object obj41 = !flag25;
				if (obj41 == null)
				{
					bool flag26 = (object)obj14 == null;
					object obj42 = !flag26;
					OutOfMemoryException ex = (OutOfMemoryException)val5;
					if (obj42 == null)
					{
						goto IL_04e3;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj13 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = (UnityEngine.Object)1;
					obj40 = obj39;
					obj7 = (UnityEngine.Object)1;
				}
				else
				{
					if ((nint)obj13 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D658");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj40 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj39 = obj43;
				}
				goto IL_088c;
				IL_088c:
				result = null;
				goto IL_09b0;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj14 = null;
			val2 = val3;
			obj39 = 0;
			val = (Enumerator<, >)(ref val2);
			val4 = val3;
			val5 = (Enumerator<, >)(ref val2);
			obj16 = 0;
			obj13 = null;
		}
		goto IL_05a2;
		IL_05a2:
		throw new NullReferenceException();
		IL_04e3:
		return result;
	}

	private static bool SaneDoorVersion(int version, int have)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_0030: Expected I4, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		//IL_010a: Expected Obj, but got I4
		//IL_0168: Expected I4, but got I8
		//IL_0182: Expected Obj, but got I4
		bool flag = version < 16777217;
		object obj = !flag;
		object obj2 = version - have;
		bool flag2 = (byte)(int)(~obj) != 0;
		object obj3 = obj2 - 1001;
		bool flag3 = (nint)obj3 < 0;
		object obj4 = obj2 ^ 0x3E9;
		object obj5 = obj2 ^ obj3;
		object obj6 = obj4 & obj5;
		bool flag4 = (nint)obj6 < 0;
		bool flag5 = flag3 == flag4;
		bool flag6 = !flag5;
		object obj7 = have - 1;
		bool flag7 = (nint)obj7 < 0;
		int num = have ^ 1;
		int num2 = have ^ obj7;
		int num3 = num & num2;
		bool flag8 = num3 < 0;
		bool flag9 = flag7 == flag8;
		object obj8 = !flag9;
		object obj9 = ~obj8;
		bool result = ((obj9 != null) ? flag6 : flag2);
		int num4 = (int)(version & 0x80000000L);
		bool flag10 = num4 == 0;
		object obj10 = !flag10;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			return false;
		}
		return result;
	}

	private unsafe void Awake()
	{
		//IL_0024: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I
		//IL_0837: Expected F4, but got I
		//IL_0d59: Expected VT, but got Obj
		//IL_07d4: Expected Obj, but got I
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected Obj, but got Unknown
		//IL_00da: Invalid comparison between F4 and I
		//IL_0178: Expected Obj, but got I
		//IL_0d97: Expected Obj, but got I
		//IL_0dc1: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_0153: Expected F8, but got Obj
		//IL_0163: Expected F4, but got I
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected Obj, but got Unknown
		//IL_08a9: Expected Obj, but got F8
		//IL_01fa: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_0b80: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Expected Obj, but got Unknown
		//IL_0c01: Expected VT, but got Obj
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I4
		//IL_0de8: Expected Obj, but got I4
		//IL_03e0: Expected Obj, but got I
		//IL_0751: Expected F8, but got I4
		//IL_0d0d: Invalid comparison between F8 and I4
		//IL_0415: Expected Obj, but got I
		//IL_0425: Expected Obj, but got I
		//IL_042e: Expected F8, but got I4
		//IL_044f: Expected Obj, but got I4
		//IL_0cf6: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got Ref
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0347: Expected Obj, but got I
		//IL_08c7: Invalid comparison between F8 and I4
		//IL_08d6: Invalid comparison between F8 and I4
		//IL_08e9: Expected Obj, but got F8
		//IL_08f6: Expected Obj, but got F8
		//IL_0935: Expected Obj, but got I4
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected Obj, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I
		//IL_0a29: Invalid comparison between F8 and I4
		//IL_0a38: Invalid comparison between F8 and I4
		//IL_0a4b: Expected Obj, but got F8
		//IL_0a58: Expected Obj, but got F8
		//IL_0aa1: Expected Obj, but got I4
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected Obj, but got Unknown
		//IL_0ab7: Expected I4, but got Obj
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected Obj, but got Unknown
		//IL_0540: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_06ae: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		//IL_0655: Invalid comparison between F8 and I
		//IL_06f6: Expected Obj, but got I
		object obj;
		object obj4;
		double num3;
		object obj20;
		double num8;
		double num9 = default;
		double num11 = default;
		object obj26 = default;
		object obj29 = default;
		if ((object)panel != null)
		{
			Vector3 localPosition = panel.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			obj = 0;
			float num;
			if (~(madeOpen ? 1u : 0u) == 0)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v60+A0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v61+18]");
				object obj5 = default;
				obj4 = 0 * obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v61+20]");
				num = 0f * rise;
			}
			else
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v55+A0]");
				object obj7 = 0;
				obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v56+8]");
				num = 0f;
			}
			object obj8 = default;
			float num2 = (float)obj8 - num;
			object obj9 = default;
			Vector3 vector = (shut = (Vector3)(obj9 - obj4));
			if ((object)panel != null)
			{
				Quaternion localRotation = panel.localRotation;
				shutTurn = (Quaternion)vector;
				if ((object)panel != null)
				{
					Vector3 forward = panel.forward;
					num3 = (double)vector * (double)vector;
					float num4 = num * num;
					float num5 = (float)num3 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
					if (num5 > 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj10 = 0;
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v49+E4]");
						bool flag = (nint)0 == 0;
						object obj12 = !flag;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						object obj13 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						double num7;
						if ((nint)obj13 > 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							float num6 = num / (float)obj4;
							num7 = 0.0 / num3;
						}
						else
						{
							object obj14 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v49+A0]");
							object obj15 = 0;
							num7 = (double)obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v50+8]");
							float num6 = 0f;
						}
						object obj16 = this + 324;
						obj16 = num7;
					}
					if ((object)panel != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7458]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
						object obj18 = default;
						if (obj18 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+18]");
							if ((nint)0 == 0)
							{
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+20]");
								Bounds bounds = ((Collider)0).bounds;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+18]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+18]");
								bool flag2 = (nint)0 < (nint)1;
								object obj21 = default;
								obj20 = obj21;
								num8 = num9;
								if (flag2)
								{
									goto IL_03bb;
								}
								object obj22 = obj18 + 32;
								object obj23 = 0;
								double num10 = num11;
								object obj24 = obj21;
								object obj25 = obj26;
								double num12 = num9;
								object obj39 = default;
								while (true)
								{
									bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
									object obj27 = !flag3;
									if (obj27 != null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X25_v6+v124 @ X24_v10*8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X25_v6+v124 @ X24_v10*8]");
										Bounds bounds2 = ((Collider)0).bounds;
										object obj28 = (object)(&obj29);
										double num13 = num10 - num12;
										double num14 = num12 + num10;
										obj23++;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
										double num15 = (double)obj28 - num9;
										double num16 = (double)obj28 + num9;
										object obj30 = obj25 - obj24;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+18]");
										obj19 = 0;
										object obj31 = obj26 + obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
										if (!(num13 < num15))
										{
											num13 = num15;
										}
										double num17 = num14 - num15;
										bool flag4 = num17 < 0.0;
										bool flag5 = num17 == 0.0;
										object obj32 = num14 ^ num15;
										object obj33 = num14 ^ num17;
										object obj34 = obj32 & obj33;
										bool flag6 = (nint)obj34 < 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
										bool flag7 = flag4 == flag6;
										object obj35 = !flag5;
										object obj36 = flag7 & obj35;
										object obj37 = ~obj36;
										if (obj37 == null)
										{
											num15 = num14;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
										double num18 = num15 - num13;
										object obj38 = obj39 - obj30;
										double num19 = num18 * 0.5;
										object obj40 = obj38 * 63;
										double num20 = num13 + num19;
										object obj41 = obj30 + obj40;
										num3 = num20 - num19;
										double num21 = num19 + num20;
										obj4 = obj41 - obj40;
										if (!(num3 < num16))
										{
											num3 = num16;
										}
										double num22 = num21 - num16;
										bool flag8 = num22 < 0.0;
										bool flag9 = num22 == 0.0;
										object obj42 = num21 ^ num16;
										object obj43 = num21 ^ num22;
										object obj44 = obj42 & obj43;
										bool flag10 = (nint)obj44 < 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
										bool flag11 = flag8 == flag10;
										object obj45 = !flag9;
										object obj46 = flag11 & obj45;
										if ((int)(~obj46) == 0)
										{
											num16 = num21;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIF not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
										double num23 = num16 - num3;
										object obj47 = obj31 - obj4;
										num8 = num23 * 0.5;
										obj20 = obj47 * 63;
										double num24 = num3 + num8;
										obj25 = obj4 + obj20;
										bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
										num10 = num24;
										obj24 = obj20;
										num12 = num8;
										if (flag12)
										{
											continue;
										}
										goto IL_03bb;
									}
									goto IL_0788;
								}
								goto IL_0796;
							}
						}
					}
				}
			}
		}
		goto IL_0788;
		IL_0788:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0796;
		IL_0d04:
		double num25;
		if (!(num25 < 2139095039.0))
		{
			double num26 = (double)Width__BackingField * 0.5;
			double num27 = num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE50]");
			num25 = num27 + 0.0;
		}
		seam = (float)num25;
		return;
		IL_03bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75C0]");
		object obj48 = 0;
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v18+A0]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v19+18]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		object obj51 = num28 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v19+1C]");
		double num29 = 0.0 * num3;
		Vector3 vector2 = Through__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v19+1C]");
		object obj52 = vector2 * 0;
		object obj53 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		object obj54 = obj53 * 0;
		Vector3 vector3 = (Vector3)(obj51 - obj52);
		object obj55 = obj20 + obj20;
		double num30 = num29 - (double)obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj56 = obj55 * vector3;
		double num31 = num8 + num8;
		double num32 = (double)Through__BackingField * num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		tall = (float)num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		double num33 = (double)obj56 + num32;
		double num34 = num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB24]");
		double num35 = num34 + 0.0;
		Width__BackingField = (float)num33;
		top = (float)num35;
		Vector3 foot = Foot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
		object obj57 = default;
		if (obj57 == null)
		{
			goto IL_0788;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v24+18]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v24+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04B8]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB380]");
			object obj59 = 0;
			num25 = 2139095039.0;
			double num36 = num31;
			double num37 = num33;
			double num38 = num35;
			object obj60 = 0;
			object obj63 = default;
			while (true)
			{
				bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj60) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj58);
				object obj61 = !flag13;
				if (obj61 != null)
				{
					break;
				}
				object obj62 = obj57 + obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28+20]");
					Transform transform = ((Component)0).transform;
					if ((object)transform != null)
					{
						if (!transform.IsChildOf(panel))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28+20]");
							string text = ((UnityEngine.Object)0).name;
							if (text == null)
							{
								goto IL_0788;
							}
							if (text.StartsWith((string)value))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28+20]");
								Bounds bounds3 = ((Renderer)0).bounds;
								double num39 = (double)obj29 - num33;
								double num40 = (double)obj26 - num31;
								num36 = num30 * (double)obj63;
								double num41 = num30 * num39;
								double num42 = (double)vector3 * num40;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
								double num43 = num42 + num41;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
								num38 = num42 + num36;
								num37 = num43 - num38;
								double num44 = num37;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
								if (num44 > 0.0 && !(num25 < num37))
								{
									num25 = num37;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28+20]");
								string text2 = ((UnityEngine.Object)0).name;
								if (text2 == (string)obj59)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28+20]");
									Bounds bounds4 = ((Renderer)0).bounds;
									double num45 = num11 - num9;
									num37 = num45 - num35;
									if ((double)top < num37)
									{
										num37 = top;
									}
									top = (float)num37;
									num38 = num35;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v24+18]");
						obj58 = 0;
						obj60++;
						object obj64 = obj60;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v24+18]");
						if ((nint)obj64 < 0)
						{
							continue;
						}
						goto IL_0d04;
					}
				}
				goto IL_0788;
			}
			goto IL_0796;
		}
		num25 = 2139095039.0;
		goto IL_0d04;
		IL_0796:
		throw new IndexOutOfRangeException();
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+40]");
		List<System.__Canon> list = (List<System.__Canon>)0;
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag2 = list._size < items.Length;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			object obj6 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj7 = obj6 + 32;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)this);
		}
		if (~(modeMap ? 1u : 0u) == 0)
		{
			Snap();
		}
	}

	private void OnDisable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+40]");
		bool flag2 = ((List<System.__Canon>)0).Remove((System.__Canon)(object)this);
	}

	public void Press()
	{
		//IL_0016: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I4
		//IL_0059: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_02cc: Expected Obj, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected I4, but got Unknown
		//IL_01d7: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_02f1: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		if (Busy)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		if (~(modeMap ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v41+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v41+A0]");
			object obj6 = 0;
			int num = 1 << index;
			int num2 = num ^ obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v41+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v41+A0]");
			object obj8 = 0;
			obj8 = num2;
			ModeChanged();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaDoor gillaDoor = (GillaDoor)obj;
		bool flag5 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaDoor = (GillaDoor)obj;
		}
		Transform transform = gillaDoor.panel;
		int num3 = 1 << index;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7 (UnityEngine.Transform)+34]");
		int num4 = (int)((nint)num3 ^ (nint)0);
		bool flag6 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaDoor = (GillaDoor)obj;
		}
		Transform transform2 = gillaDoor.panel;
		bool flag7 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaDoor = (GillaDoor)obj;
		}
		Transform transform3 = gillaDoor.panel;
		int num5 = index & 0x1F;
		int num6 = num5 ^ 0x10;
		int num7 = 1 << num6;
		int num8 = ~num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v4 (UnityEngine.Transform)+34]");
		int num9 = (int)((nint)0 & (nint)num8);
		bool flag8 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			gillaDoor = (GillaDoor)obj;
		}
		Transform transform4 = gillaDoor.panel;
		gillaDoor.Changed();
	}

	public bool Pry()
	{
		//IL_0164: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_00b1: Expected F8, but got I4
		//IL_00d4: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		bool flag = (byte)(~(keycardOnly ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			bool flag2 = (byte)(~(modeMap ? 1u : 0u)) != 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				bool isOpen = IsOpen;
				bool flag3 = !isOpen;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					bool isOpen2 = IsOpen;
					bool flag4 = !isOpen2;
					object obj4 = !flag4;
					object obj5 = ~obj4;
					double num = ((obj5 != null) ? 0.0 : 1.0);
					if ((double)open == num)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
						object obj6 = 0;
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+E4]");
						bool flag5 = (nint)0 == 0;
						object obj8 = !flag5;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaDoor gillaDoor = (GillaDoor)obj6;
						bool flag6 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
						object obj9 = !flag6;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							gillaDoor = (GillaDoor)obj6;
						}
						Transform transform = gillaDoor.panel;
						int num2 = index & 0x1F;
						int num3 = 1 << index;
						int num4 = num2 ^ 0x10;
						int num5 = 1 << num4;
						int num6 = num3 | num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v2 (UnityEngine.Transform)+34]");
						int num7 = (int)((nint)num6 | (nint)0);
						bool flag7 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
						object obj10 = !flag7;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							gillaDoor = (GillaDoor)obj6;
						}
						Transform transform2 = gillaDoor.panel;
						gillaDoor.Changed();
						return true;
					}
				}
			}
		}
		return false;
	}

	public bool Blow(Vector3 away)
	{
		//IL_01ff: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_0137: Expected VT, but got F8
		//IL_016b: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_0118: Expected F8, but got I4
		//IL_0331: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected I4, but got Unknown
		//IL_0295: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_0301: Expected Obj, but got I4
		bool flag = (byte)(~(keycardOnly ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj == null)
		{
			bool flag2 = (byte)(~(modeMap ? 1u : 0u)) != 0;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				bool blown = Blown;
				bool flag3 = !blown;
				object obj3 = !flag3;
				if (obj3 == null && index <= 7)
				{
					bool isOpen = IsOpen;
					bool flag4 = !isOpen;
					double num2 = default;
					double num = num2;
					double num4 = default;
					double num3 = num4;
					if (!flag4)
					{
						bool isOpen2 = IsOpen;
						bool flag5 = !isOpen2;
						object obj4 = !flag5;
						object obj5 = ~obj4;
						num3 = ((obj5 != null) ? 0.0 : 1.0);
						bool flag6 = (double)open == num3;
						num = 1.0;
						if (flag6)
						{
							goto IL_007d;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
					object obj6 = 0;
					blowAway = (Vector3)num4;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v10+E4]");
					bool flag7 = (nint)0 == 0;
					object obj8 = !flag7;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaDoor gillaDoor = (GillaDoor)obj6;
					bool flag8 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
					object obj9 = !flag8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						gillaDoor = (GillaDoor)obj6;
					}
					Transform transform = gillaDoor.panel;
					object obj10 = index + 24;
					int num5 = 1 << index;
					object obj11 = 1 << (int)obj10;
					int num6 = num5 | obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X9_v2 (UnityEngine.Transform)+34]");
					int num7 = (int)((nint)num6 | (nint)0);
					bool flag9 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
					object obj12 = !flag9;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						gillaDoor = (GillaDoor)obj6;
					}
					Transform transform2 = gillaDoor.panel;
					bool flag10 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
					object obj13 = !flag10;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						gillaDoor = (GillaDoor)obj6;
					}
					Transform transform3 = gillaDoor.panel;
					int num8 = index & 0x1F;
					int num9 = num8 ^ 0x10;
					int num10 = 1 << num9;
					int num11 = ~num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v4 (UnityEngine.Transform)+34]");
					int num12 = (int)((nint)0 & (nint)num11);
					bool flag11 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
					object obj14 = !flag11;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						gillaDoor = (GillaDoor)obj6;
					}
					Transform transform4 = gillaDoor.panel;
					gillaDoor.Changed();
					return true;
				}
			}
		}
		goto IL_007d;
		IL_007d:
		return false;
	}

	private void Changed()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		//IL_034a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+A0]");
		object obj8 = 0;
		UnityEngine.Object obj9 = (UnityEngine.Object)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+A0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v11+38]");
		object obj14 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj5;
		}
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X20_v3 (UnityEngine.Object)+6CC]");
			object obj20 = 0;
		}
		else
		{
			object obj20 = 0;
		}
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v20+A0]");
		object obj25 = 0;
	}

	private unsafe bool MonsterInDoorway()
	{
		//IL_079c: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I
		//IL_07dd: Expected Obj, but got I
		//IL_07f5: Expected Obj, but got I
		//IL_0805: Expected Obj, but got I
		//IL_0815: Expected F8, but got I
		//IL_0825: Expected F8, but got I
		//IL_0847: Expected Obj, but got I4
		//IL_0963: Expected Obj, but got I
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got I
		//IL_00c2: Expected VT, but got F8
		//IL_00d2: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got I4
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected Obj, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got I4
		//IL_08f2: Expected I, but got Obj
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Ref, but got Unknown
		//IL_0915: Expected Obj, but got I4
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_05be: Expected Obj, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_0618: Expected I, but got Obj
		//IL_0634: Expected Obj, but got I4
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I4
		//IL_06fb: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got I4
		//IL_02e1: Expected I, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I4
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Invalid comparison between Unknown and F8
		//IL_04f4: Expected Obj, but got I4
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		Vector3 foot = Foot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		object obj3 = obj;
		Vector3 vector = Through__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		object obj4 = 0;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+1C]");
		double num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+20]");
		double num2 = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v6+A0]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		bool flag2 = (object)obj9 == null;
		UnityEngine.Object obj11 = default;
		UnityEngine.Object obj10 = obj11;
		Enumerator<, > val = (Enumerator<, >)0;
		if (!flag2)
		{
			double num3 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
			double num4 = num3 * 0.0;
			double num5 = num2 * (double)obj4;
			double num6 = num2 * (double)vector;
			float num7 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
			float num8 = num7 * 0f;
			double num9 = (double)obj7 * (double)obj4;
			double num10 = num * (double)vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C50]");
			object obj12 = 0;
			double num11 = num4 - num5;
			num = num6 - (double)num8;
			vector = (Vector3)(num9 - num10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C48]");
			object obj14 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj9).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			obj7 = 0;
			Enumerator<, > val3 = default;
			Enumerator<, > val2 = val3;
			UnityEngine.Object obj15 = (UnityEngine.Object)17276928;
			UnityEngine.Object obj17 = default;
			object obj19 = default;
			object obj31 = default;
			bool result2 = default;
			object obj27;
			Enumerator<, > val7;
			double num13;
			float num14;
			double num19 = default;
			double num18 = default;
			Enumerator<, > val5 = default;
			while (true)
			{
				bool flag3 = val.MoveNext();
				bool flag4 = !flag3;
				UnityEngine.Object obj16 = obj17;
				object obj18 = obj19;
				float num12 = (float)num10;
				num13 = num9;
				num14 = num8;
				double num15 = num6;
				double num16 = num5;
				Enumerator<, > val4 = val2;
				obj9 = obj15;
				if (!flag4)
				{
					object obj20 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v35+E4]");
					obj15 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v35+E4]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = obj11 == null;
					bool flag7 = !flag6;
					object obj22 = !flag7;
					obj19 = 0;
					if (obj22 != null)
					{
						continue;
					}
					if ((object)obj11 == null)
					{
						NullReferenceException ex = new NullReferenceException();
						obj19 = 0;
						nint num17 = unchecked((nint)null);
						break;
					}
					object obj23 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ stack_-A8 (UnityEngine.Object)+118]");
					obj16 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v42+E4]");
					obj9 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v42+E4]");
					bool flag8 = (nint)0 == 0;
					object obj24 = !flag8;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag9 = obj16 == this;
					bool flag10 = !flag9;
					object obj25 = !flag10;
					obj18 = 0;
					num12 = (float)num10;
					num13 = num9;
					num14 = num8;
					num15 = num6;
					num16 = num5;
					val4 = val2;
					if (obj25 == null)
					{
						Transform transform = ((Component)obj11).transform;
						bool flag11 = (object)transform == null;
						obj17 = obj16;
						obj19 = 0;
						nint num17 = unchecked((nint)null);
						obj15 = obj9;
						if (flag11)
						{
							break;
						}
						Vector3 position = transform.position;
						num8 = (float)val2 - (float)val5;
						val2 = (Enumerator<, >)(num5 - num18);
						num5 = num6 - num19;
						float num20 = num8 * (float)Through__BackingField;
						Enumerator<, > val6 = val2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
						object obj26 = val6 * 0;
						float num21 = num20 + (float)obj26;
						double num22 = num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
						double num23 = num22 * 0.0;
						num12 = Thickness__BackingField;
						num6 = num23 + (double)num21;
						double num24 = (double)Thickness__BackingField * 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						num9 = num24 + (double)obj4;
						bool flag12 = !(num6 < num9);
						obj17 = obj16;
						obj19 = 0;
						num10 = Thickness__BackingField;
						obj15 = obj9;
						if (flag12)
						{
							continue;
						}
						double num25 = (double)vector * num5;
						double num26 = num11 * (double)num8;
						double num27 = num * (double)val2;
						double num28 = num26 + num27;
						num8 = Width__BackingField;
						num5 = num25 + num28;
						double num29 = (double)Width__BackingField * 0.5;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						num6 = num29 + (double)obj7;
						bool flag13 = !(num5 < num6);
						obj17 = obj16;
						obj19 = 0;
						num10 = Thickness__BackingField;
						obj15 = obj9;
						if (flag13)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
						bool flag14 = !((double)val2 < 2.0);
						obj18 = 0;
						num13 = num9;
						num14 = Width__BackingField;
						num15 = num6;
						num16 = 2.0;
						val4 = val2;
						obj17 = obj16;
						obj19 = 0;
						num10 = Thickness__BackingField;
						num5 = 2.0;
						obj15 = obj9;
						if (flag14)
						{
							continue;
						}
					}
				}
				obj10 = null;
				obj27 = 0;
				val = val3;
				num2 = 0.5;
				val7 = (Enumerator<, >)(ref val);
				object obj28 = 0;
				bool result = flag3;
				while (true)
				{
					nint num17 = (nint)obj14;
					((Enumerator<, >*)val7)->Dispose();
					bool flag15 = obj28 == null;
					object obj29 = !flag15;
					obj17 = obj16;
					obj19 = obj18;
					num10 = num12;
					num19 = num15;
					num18 = num16;
					val5 = val4;
					if (obj29 == null)
					{
						bool flag16 = (object)obj10 == null;
						object obj30 = !flag16;
						obj17 = obj16;
						obj19 = obj18;
						num19 = num15;
						num18 = num16;
						val5 = val4;
						OutOfMemoryException ex2 = (OutOfMemoryException)val7;
						if (obj30 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex2 = new OutOfMemoryException();
						num12 = (float)num10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch ((long)num17)
					{
					case 2L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj10 = (UnityEngine.Object)1;
						obj9 = (UnityEngine.Object)1;
						obj28 = obj27;
						break;
					case 1L:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj28 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj27 = obj31;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7E4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					obj16 = obj17;
					obj18 = obj19;
					num15 = num19;
					num16 = num18;
					val4 = val5;
					result = false;
				}
				return result;
			}
			NullReferenceException ex3 = new NullReferenceException();
			obj10 = null;
			obj27 = 0;
			val = val3;
			num2 = 0.5;
			val7 = (Enumerator<, >)(ref val);
			num13 = num9;
			num14 = num8;
			num19 = num6;
			num18 = num5;
			val5 = val2;
		}
		throw new NullReferenceException();
	}

	public static float PryCurve(float t)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+48]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+50]");
		return Spline.Eval(t, (float[])num, (float[])0);
	}

	public static void Offer(int mask, int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_00bd: Expected Obj, but got I4
		//IL_0192: Expected I4, but got I8
		//IL_01ac: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_014c: Expected I4, but got I8
		//IL_042f: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_028f: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v7+38]");
		if ((nint)0 > (nint)version)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v14+38]");
		if ((nint)0 == version)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj12 = !flag6;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+A0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v33+3C]");
			if ((nint)0 >= (nint)by)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v16+E4]");
		if ((nint)0 != 0)
		{
			if ((int)(version & 0x80000000L) != 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
			int num = (int)(version & 0x80000000L);
			bool flag8 = num == 0;
			object obj16 = !flag8;
			if (obj16 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v16+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v21+38]");
		if ((nint)0 > (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v21+38]");
			object obj18 = (nint)version - (nint)0;
			if ((nint)obj18 > 1000)
			{
				return;
			}
		}
		else
		{
			bool flag9 = version < 16777217;
			object obj19 = !flag9;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v16+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Take(mask, version, by);
	}

	private unsafe static void Take(int mask, int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I
		//IL_0320: Expected Obj, but got I4
		//IL_0460: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_047a: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got I
		//IL_038b: Expected I4, but got Obj
		//IL_0120: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I
		//IL_03cd: Expected I4, but got Obj
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Ref, but got Unknown
		//IL_03f0: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+A0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v7+38]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v30+A0]");
			obj12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v18+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v18+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj16 = 0;
			int num = (int)obj16;
			Enumerator<, > val = default;
			object obj17;
			object obj18;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				obj17 = 0;
				obj18 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj19 = 0;
				object obj23 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
					object obj20 = 0;
					num = (int)obj20;
					((Enumerator<, >*)val2)->Dispose();
					bool flag8 = obj19 == null;
					object obj21 = !flag8;
					if (obj21 == null)
					{
						bool flag9 = obj17 == null;
						object obj22 = !flag9;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj22 == null)
						{
							break;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					switch (num)
					{
					case 2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj17 = 1;
						obj19 = obj18;
						break;
					case 1:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj19 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj18 = obj23;
						break;
					default:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
				}
				return;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj17 = 0;
			obj18 = 0;
			val2 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	public static void Offer(NetworkApe from, int mask, int version, int by)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_0798: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I
		//IL_07c8: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I4
		//IL_09d7: Expected Obj, but got I
		//IL_0800: Expected Obj, but got I4
		//IL_098d: Expected Obj, but got I
		//IL_099f: Expected I4, but got I8
		//IL_09b9: Expected Obj, but got I4
		//IL_03ed: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_08e0: Expected Obj, but got I4
		//IL_0a0b: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I4
		//IL_0910: Expected Obj, but got I4
		//IL_04c6: Expected I4, but got I8
		//IL_04e0: Expected Obj, but got I4
		//IL_0448: Expected Obj, but got I4
		//IL_0562: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I
		//IL_092e: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I4
		//IL_05f8: Expected Obj, but got I4
		//IL_05a9: Expected Obj, but got I4
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_0620: Expected Obj, but got I4
		//IL_0636: Expected I4, but got VT
		//IL_05d9: Expected Obj, but got I
		//IL_0706: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)from == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)((SimulationBehaviour)from)._object == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)from)._object;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!networkObject._runner)
		{
			return;
		}
		ArgumentNullException ex = new ArgumentNullException();
		object obj10 = ex & 1;
		if (obj10 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = GillaNetGuard.IsMaster(((SimulationBehaviour)from)._runner, from.ownerRef);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj14 = 0;
		object obj15 = obj14;
		if (!flag9)
		{
			goto IL_07a6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v74+E4]");
		bool flag11 = (nint)0 == 0;
		object obj18 = !flag11;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v74+A0]");
		object obj19 = 0;
		int num = (int)(version & 0x80000000L);
		bool flag12 = num == 0;
		object obj20 = !flag12;
		double num2;
		float unscaledTime = default;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v48+34]");
			if ((nint)0 != mask)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v74+E4]");
				bool flag13 = (nint)0 == 0;
				object obj21 = !flag13;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj22 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v54+A0]");
					obj19 = 0;
				}
				unscaledTime = Time.unscaledTime;
				obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v48+60]");
				if ((nint)0 < (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+E4]");
					bool flag14 = (nint)0 == 0;
					object obj23 = !flag14;
					num2 = unscaledTime;
					if (obj23 == null)
					{
						num2 = unscaledTime;
						obj17 = obj15;
						goto IL_0389;
					}
					goto IL_0847;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+E4]");
				bool flag15 = (nint)0 == 0;
				object obj24 = !flag15;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+A0]");
				object obj25 = 0;
				double num3 = unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v51+60]");
				double num4 = num3 - 0.0;
				bool flag16 = num4 < 12.0;
				unscaledTime = (float)num4;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+E4]");
					bool flag17 = (nint)0 == 0;
					object obj26 = !flag17;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj27 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v52+A0]");
						obj25 = 0;
					}
					_ = 3212836864L;
					goto IL_0723;
				}
				goto IL_07a6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v74+E4]");
		bool flag18 = (nint)0 == 0;
		object obj28 = !flag18;
		num2 = -1.0;
		float num5 = unscaledTime;
		double num6 = -1.0;
		obj15 = obj17;
		if (obj28 == null)
		{
			goto IL_0389;
		}
		goto IL_086c;
		IL_0847:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+A0]");
		obj19 = 0;
		num5 = unscaledTime;
		num6 = num2;
		goto IL_086c;
		IL_0723:
		Take(mask, version, by);
		return;
		IL_086c:
		unscaledTime = num5;
		goto IL_07a6;
		IL_07a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v80+E4]");
		bool flag19 = (nint)0 == 0;
		object obj29 = !flag19;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj30 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v29+E4]");
		bool flag20 = (nint)0 == 0;
		object obj31 = !flag20;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v29+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v18+38]");
		if ((nint)0 > (nint)version)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v29+E4]");
		bool flag21 = (nint)0 == 0;
		object obj33 = !flag21;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj34 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v34+E4]");
		bool flag22 = (nint)0 == 0;
		object obj35 = !flag22;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v34+A0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v24+38]");
		if ((nint)0 == version)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v34+E4]");
			bool flag23 = (nint)0 == 0;
			object obj37 = !flag23;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBEC0");
			object obj38 = default;
			if ((nint)obj38 >= by)
			{
				return;
			}
			obj34 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v34+E4]");
		bool flag24 = (nint)0 == 0;
		object obj39 = !flag24;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBE70");
		int num7 = (int)(version & 0x80000000L);
		bool flag25 = num7 == 0;
		object obj40 = !flag25;
		if (obj40 != null)
		{
			return;
		}
		object obj41 = default;
		if ((nint)obj41 > 0)
		{
			object obj42 = version - obj41;
			if ((nint)obj42 > 1000)
			{
				return;
			}
		}
		else
		{
			bool flag26 = version < 16777217;
			object obj43 = !flag26;
			if (obj43 != null)
			{
				return;
			}
		}
		bool flag27 = !flag9;
		object obj44 = !flag27;
		int num8 = 0;
		int num9 = (int)from.ownerRef;
		if (obj44 == null)
		{
			object obj45 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v41+E4]");
			bool flag28 = (nint)0 == 0;
			object obj46 = !flag28;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FDBE20");
			int num10 = default;
			bool flag29 = FromThem(from, num10, mask);
			bool flag30 = !flag29;
			num8 = mask;
			num9 = num10;
			if (flag30)
			{
				return;
			}
		}
		object obj47 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v39+E4]");
		bool flag31 = (nint)0 == 0;
		object obj48 = !flag31;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		goto IL_0723;
		IL_0389:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj15 = obj14;
		goto IL_0847;
	}

	private static bool FromThem(NetworkApe from, int have, int want)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		//IL_019d: Expected I4, but got I8
		//IL_01aa: Expected I4, but got I8
		//IL_01c9: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_02b5: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_08af: Expected Obj, but got I4
		//IL_08bd: Expected Obj, but got I4
		//IL_08d7: Expected Obj, but got I4
		//IL_0945: Expected Obj, but got I
		//IL_096f: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I4
		//IL_090d: Expected I4, but got I8
		//IL_0927: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected I4, but got Unknown
		//IL_0451: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected I4, but got Unknown
		//IL_09c0: Expected Obj, but got I4
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected I4, but got Unknown
		//IL_09f4: Expected Obj, but got I4
		//IL_05c8: Expected Obj, but got I4
		//IL_0713: Expected Obj, but got I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04ab: Expected Obj, but got I4
		//IL_0358: Expected I4, but got I8
		//IL_072f: Expected Obj, but got I4
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected Obj, but got Unknown
		//IL_0764: Expected Obj, but got I4
		//IL_04fd: Expected Obj, but got I4
		//IL_062a: Expected Obj, but got I4
		//IL_07b6: Expected Obj, but got I4
		//IL_0652: Expected Obj, but got I4
		//IL_083d: Expected I4, but got Obj
		//IL_07eb: Expected Obj, but got I4
		//IL_06e6: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I4
		//IL_0570: Invalid comparison between F4 and I4
		//IL_0581: Expected Obj, but got I4
		//IL_0813: Expected Obj, but got I4
		//IL_06ae: Expected I4, but got Obj
		int num2 = default;
		int num3 = default;
		int num = num2 ^ num3;
		object obj;
		GillaDoor gillaDoor;
		object obj4;
		int num6;
		if (num != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = Owner(from);
			obj4 = obj;
			int num4 = num >> 16;
			bool flag3 = num4 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				int num5 = num & num2;
				if (num5 == num && flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v18+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					num6 = num3;
					if (obj6 == null)
					{
						goto IL_0128;
					}
					goto IL_013f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num7 = -1;
			int num8 = -16;
			while (true)
			{
				int num9 = num8 + 16;
				int num10 = num >> num9;
				if ((num10 & 1) != 0)
				{
					bool flag6 = num9 < 15;
					object obj8 = !flag6;
					object obj9 = num9 - 15;
					bool flag7 = obj9 == null;
					int num11 = num8 - 8;
					object obj10 = !flag7;
					object obj11 = obj8 & obj10;
					object obj12 = ~obj11;
					int num12 = ((obj12 != null) ? num9 : num8);
					bool flag8 = num9 < 23;
					object obj13 = !flag8;
					object obj14 = num9 - 23;
					bool flag9 = obj14 == null;
					object obj15 = !flag9;
					object obj16 = obj13 & obj15;
					object obj17 = ~obj16;
					int num13 = ((obj17 != null) ? num12 : num11);
					int num14 = (int)(num7 & 0x80000000L);
					bool flag10 = num14 == 0;
					object obj18 = !flag10;
					if (obj18 == null)
					{
						bool flag11 = num7 == num13;
						num7 = num13;
						if (!flag11)
						{
							num7 = -1;
							gillaDoor = null;
							break;
						}
					}
					else
					{
						num7 = num13;
					}
				}
				num8++;
				if (num8 != 16)
				{
					continue;
				}
				bool flag12 = num7 < 15;
				object obj19 = !flag12;
				object obj20 = num7 - 15;
				bool flag13 = obj20 == null;
				object obj21 = !flag13;
				object obj22 = obj19 & obj21;
				if (obj22 == null)
				{
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X0_v21+E4]");
					bool flag14 = (nint)0 == 0;
					object obj24 = !flag14;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaDoor gillaDoor2 = BaseDoor(num7);
					gillaDoor = gillaDoor2;
				}
				else
				{
					gillaDoor = null;
				}
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X0_v10+E4]");
			bool flag15 = (nint)0 == 0;
			object obj27 = !flag15;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(gillaDoor == null))
			{
				object obj28 = num7 + 24;
				int num15 = num7 & 0x1F;
				object obj29 = 1 << (int)obj28;
				object obj30 = num7 - 8;
				bool flag16 = (nint)obj30 < 0;
				int num16 = num7 ^ 8;
				int num17 = num7 ^ obj30;
				int num18 = num16 & num17;
				bool flag17 = num18 < 0;
				int num19 = num15 ^ 0x10;
				bool flag18 = flag16 == flag17;
				object obj31 = !flag18;
				object obj32 = ~obj31;
				object obj33 = ((obj32 != null) ? ((object)0) : obj29);
				int num20 = 1 << num19;
				int num21 = 1 << num7;
				int num22 = obj33 & num3;
				bool flag19 = num22 == 0;
				object obj34 = !flag19;
				int num23 = obj33 & num2;
				bool flag20 = num23 == 0;
				int num24 = num20 & num2;
				object obj35 = !flag20;
				if (obj35 == null)
				{
					object obj36 = obj34 & 1;
					bool flag21 = obj36 == null;
					object obj37 = !flag21;
					if (obj37 == null && (num21 & num) != 0)
					{
						bool flag22 = num24 == 0;
						object obj38 = !flag22;
						if (obj38 == null)
						{
							if ((object)gillaDoor != null)
							{
								float leftToGo = gillaDoor.LeftToGo;
								bool flag23 = (double)leftToGo < 0.5;
								object obj39 = !flag23;
								float num25 = leftToGo - 0.5f;
								bool flag24 = num25 == 0f;
								object obj40 = !flag24;
								object obj41 = obj39 & obj40;
								if (obj41 != null)
								{
									goto IL_03a6;
								}
								goto IL_0686;
							}
							goto IL_082f;
						}
					}
				}
				int num26 = num21 & num2;
				bool flag25 = num22 == 0;
				object obj42 = !flag25;
				if (obj42 == null && num23 != 0 && num26 != 0)
				{
					bool flag26 = num24 == 0;
					object obj43 = !flag26;
					if (obj43 == null)
					{
						bool flag27 = !flag2;
						object obj44 = !flag27;
						num6 = 0;
						if (obj44 != null)
						{
							goto IL_06bc;
						}
						if ((object)gillaDoor != null)
						{
							goto IL_0686;
						}
						goto IL_082f;
					}
				}
				bool flag28 = num23 == 0;
				object obj45 = !flag28;
				if (obj45 == null)
				{
					object obj46 = (flag2 ? 1 : 0) ^ 1;
					object obj47 = obj46 | obj34;
					object obj48 = obj47 & 1;
					bool flag29 = obj48 == null;
					object obj49 = !flag29;
					if (obj49 == null && num24 != 0)
					{
						int num27 = num20 & num3;
						bool flag30 = num27 == 0;
						object obj50 = !flag30;
						if (obj50 == null)
						{
							int num28 = num21 & num3;
							bool flag31 = num28 == 0;
							object obj51 = !flag31;
							if (obj51 == null)
							{
								bool flag32 = num26 == 0;
								object obj52 = !flag32;
								num6 = 0;
								if (obj52 != null)
								{
									goto IL_06bc;
								}
							}
						}
					}
				}
			}
		}
		goto IL_03a6;
		IL_06bc:
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v18+E4]");
		bool flag33 = (nint)0 == 0;
		object obj53 = !flag33;
		if (obj53 == null)
		{
			goto IL_0128;
		}
		goto IL_013f;
		IL_082f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0686:
		bool flag34 = gillaDoor.WorkedFrom(from);
		bool flag35 = !flag34;
		num6 = (int)from;
		if (flag35)
		{
			goto IL_03a6;
		}
		goto IL_06bc;
		IL_03a6:
		return false;
		IL_0128:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num6 = num6;
		goto IL_013f;
		IL_013f:
		return Spent(from);
	}

	private static bool Spent(NetworkApe from)
	{
		//IL_0098: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		if ((object)from != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return GillaNetGuard.Spend(from.ownerRef, (GillaNetGuard.Kind)6, 2f, 3f);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static int OneDoor(int bits)
	{
		//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8
		//IL_0039: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_0184: Expected I4, but got I8
		//IL_019e: Expected Obj, but got I4
		//IL_0107: Expected I4, but got I8
		int num = -16;
		int num2 = -1;
		int num7;
		bool flag6;
		do
		{
			int num3 = num + 16;
			int num4 = bits >> num3;
			if ((num4 & 1) != 0)
			{
				bool flag = num3 < 15;
				object obj = !flag;
				object obj2 = num3 - 15;
				bool flag2 = obj2 == null;
				int num5 = num - 8;
				object obj3 = !flag2;
				object obj4 = obj & obj3;
				object obj5 = ~obj4;
				int num6 = ((obj5 != null) ? num3 : num);
				bool flag3 = num3 < 23;
				object obj6 = !flag3;
				object obj7 = num3 - 23;
				bool flag4 = obj7 == null;
				object obj8 = !flag4;
				object obj9 = obj6 & obj8;
				object obj10 = ~obj9;
				num7 = ((obj10 != null) ? num6 : num5);
				int num8 = (int)(num2 & 0x80000000L);
				bool flag5 = num8 == 0;
				object obj11 = !flag5;
				if (obj11 == null && num2 != num7)
				{
					num7 = -1;
					break;
				}
			}
			else
			{
				num7 = num2;
			}
			num++;
			flag6 = num != 16;
			num2 = num7;
		}
		while (flag6);
		return num7;
	}

	private unsafe static GillaDoor BaseDoor(int index)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_0426: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Ref
		//IL_01c9: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Ref, but got Unknown
		//IL_03b3: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0202: Expected Obj, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+40]");
		bool flag2 = (nint)0 == 0;
		IntPtr intPtr = default;
		UnityEngine.Object obj5 = (UnityEngine.Object)(nint)intPtr;
		object obj6 = 109895680;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v8+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Enumerator<, > val = default;
			obj4 = (object)(&val);
			bool flag5;
			object obj18 = default;
			GillaDoor result2 = default;
			object obj12;
			object obj13;
			object obj14;
			Enumerator<, > val2;
			do
			{
				if (val.MoveNext())
				{
					object obj9 = obj8;
					UnityEngine.Object obj10 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v31+E4]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)null != (UnityEngine.Object)null;
					flag5 = !flag4;
					obj12 = 0;
					continue;
				}
				obj13 = 0;
				obj14 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj15 = 0;
				while (true)
				{
					UnityEngine.Object result = null;
					obj5 = (UnityEngine.Object)obj6;
					((Enumerator<, >*)val2)->Dispose();
					bool flag6 = obj15 == null;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						bool flag7 = obj13 == null;
						object obj17 = !flag7;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj17 == null)
						{
							return (GillaDoor)result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = 1;
						obj4 = 1;
						obj15 = obj14;
						continue;
					}
					if ((nint)obj5 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj15 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
			while (flag5);
			NullReferenceException ex2 = new NullReferenceException();
			obj12 = 0;
			obj13 = 0;
			obj14 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj5 = null;
		}
		throw new NullReferenceException();
	}

	private static bool Owner(NetworkApe a)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I4
		//IL_01a4: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_0157: Expected I4, but got Obj
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5860]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ X8_v5+18] (should have been resolved before IL gen)");
			object obj7 = default;
			object obj6 = obj7 & 0xFFFF;
			bool flag2 = (nint)obj6 < 256;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				return true;
			}
			if ((object)a != null)
			{
				if (a.AccountBound)
				{
					string accountId = a.AccountId;
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v8+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAB60]");
					object item = 0;
					return GillaOwned.HasItem(accountId, (string)item);
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool WorkedFrom(NetworkApe a)
	{
		//IL_0010: Expected Obj, but got I
		//IL_050c: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_04e2: Expected I4, but got Obj
		//IL_00a1: Expected Obj, but got I4
		//IL_057d: Expected Obj, but got I
		//IL_0595: Expected Obj, but got I
		//IL_05b2: Expected Obj, but got I
		//IL_05cf: Expected Obj, but got I
		//IL_05ec: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_0767: Invalid comparison between F8 and I4
		//IL_0225: Expected Obj, but got I8
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_0787: Invalid comparison between F8 and I4
		//IL_055f: Expected Obj, but got I4
		//IL_0498: Expected F8, but got I4
		//IL_07f3: Expected Obj, but got I4
		//IL_080b: Invalid comparison between F8 and I4
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected I4, but got Unknown
		//IL_04a6: Expected F8, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I
		//IL_0400: Expected Obj, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_043f: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I4
		//IL_03c7: Invalid comparison between F8 and I4
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)a == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		double num2;
		double num3;
		double num4;
		object obj7;
		object obj8 = default;
		object obj19 = default;
		object obj20 = default;
		if (obj4 == null)
		{
			if ((object)a != null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (a.head == null)
				{
					goto IL_00ee;
				}
				if ((object)a.head != null)
				{
					Vector3 position = a.head.position;
					float sizeNow = a.SizeNow;
					bool flag5 = (double)sizeNow < 1.0;
					double num = 1.0;
					if (!flag5)
					{
						bool flag6 = !((double)sizeNow > 2.0);
						num = sizeNow;
						if (!flag6)
						{
							num = 2.0;
						}
					}
					Transform[] array = Workers();
					if (array != null)
					{
						num2 = num * 3.0;
						num3 = num2 + 3.0;
						num4 = num3 * num3;
						bool flag7 = array.Length < 1;
						obj7 = obj8;
						UnityEngine.Object obj9 = null;
						if (flag7)
						{
							goto IL_0455;
						}
						object obj10 = array.Length & 0xFFFFFFFFL;
						object obj11 = array + 32;
						object obj12 = obj8;
						object obj13 = 0;
						double num5 = num2;
						double num6 = num3;
						object obj14 = 0;
						UnityEngine.Object obj15 = null;
						while (true)
						{
							bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
							object obj16 = !flag8;
							if (obj16 == null)
							{
								object obj17 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v30+E4]");
								bool flag9 = (nint)0 == 0;
								object obj18 = !flag9;
								if (obj18 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v5+v90 @ X23_v6*8]");
								bool flag10 = (UnityEngine.Object)0 != null;
								bool flag11 = !flag10;
								obj9 = null;
								if (!flag11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v5+v90 @ X23_v6*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v5+v90 @ X23_v6*8]");
									Vector3 position2 = ((Transform)0).position;
									double num7 = num6 - (double)obj19;
									double num8 = num5 - (double)obj20;
									obj12 -= obj8;
									double num9 = num7 * num7;
									double num10 = num8 * num8;
									double num11 = num9 + num10;
									num5 = (double)obj12 * (double)obj12;
									num6 = num5 + num11;
									bool flag12 = num6 < num4;
									object obj21 = !flag12;
									double num12 = num6 - num4;
									bool flag13 = num12 == 0.0;
									object obj22 = ~obj21;
									object obj23 = obj22 | flag13;
									obj9 = null;
									if (obj23 != null)
									{
										return true;
									}
								}
								obj10 = array.Length;
								obj13++;
								bool flag14 = (nint)obj13 < array.Length;
								obj7 = obj12;
								num2 = num5;
								num3 = num6;
								obj14 = 0;
								obj15 = obj9;
								if (flag14)
								{
									continue;
								}
								goto IL_0455;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							break;
						}
					}
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
		goto IL_00ee;
		IL_0455:
		Vector3 foot = Foot;
		double num13 = (double)obj19 - num3;
		double num14 = (double)obj20 - num2;
		object obj24 = obj8 - obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj25 = 0;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v14+A0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15+18]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		object obj28 = num15 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15+18]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		object obj29 = num16 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15+1C]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		object obj30 = num17 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15+20]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		object obj31 = num18 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15+20]");
		object obj32 = 0 * Through__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v15+1C]");
		object obj33 = 0 * Through__BackingField;
		double num19 = num13 * (double)Through__BackingField;
		double num20 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		double num21 = num20 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		object obj34 = obj24 * 0;
		object obj35 = obj30 - obj31;
		object obj36 = obj32 - obj28;
		object obj37 = obj29 - obj33;
		double num22 = num19 + num21;
		double num23 = num13 * (double)obj35;
		double num24 = num14 * (double)obj36;
		object obj38 = obj24 * obj37;
		double num25 = (double)obj34 + num22;
		double num26 = num23 + num24;
		double num27 = num25 * num25;
		double num28 = (double)obj38 + num26;
		double num29 = (double)Width__BackingField * -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num30 = num28 + num29;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num31 = num29 + -1.5;
		if (num30 < 0.0)
		{
			num30 = 0.0;
		}
		double num32 = ((!(num31 < 0.0)) ? num31 : 0.0);
		double num33 = num30 * num30;
		double num34 = num27 + num33;
		double num35 = num32 * num32;
		double num36 = num35 + num34;
		bool flag15 = num36 < num4;
		object obj39 = !flag15;
		double num37 = num36 - num4;
		bool flag16 = num37 == 0.0;
		object obj40 = ~obj39;
		return (byte)((obj40 | flag16) ? 1 : 0) != 0;
		IL_00ee:
		return false;
	}

	private Transform[] Workers()
	{
		//IL_009f: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_04c5: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		//IL_0c3f: Expected Obj, but got I4
		//IL_0531: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_0879: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_0581: Expected Obj, but got I4
		//IL_0c66: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I4
		//IL_08b8: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_08ed: Expected Obj, but got I
		//IL_08fe: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected Obj, but got Unknown
		//IL_0c8d: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got I
		//IL_0645: Expected Obj, but got I4
		//IL_02f3: Expected I4, but got Obj
		//IL_0920: Expected Obj, but got I
		//IL_07d8: Expected Obj, but got I
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected Obj, but got Unknown
		//IL_0669: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I4
		//IL_036c: Expected Obj, but got I4
		//IL_096f: Expected Obj, but got I4
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_099e: Expected Obj, but got I
		//IL_09ba: Expected Obj, but got I4
		//IL_069f: Expected I4, but got Obj
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03da: Expected Obj, but got I4
		//IL_0b4b: Expected Obj, but got I
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected Obj, but got Unknown
		//IL_09de: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I4
		//IL_078e: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I
		//IL_07ae: Expected Obj, but got I
		//IL_0a14: Expected I4, but got Obj
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_0771: Expected Obj, but got I4
		//IL_0a76: Expected Obj, but got I4
		//IL_0b01: Expected Obj, but got I
		//IL_0b11: Expected Obj, but got I
		//IL_0b21: Expected Obj, but got I
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_0ae4: Expected Obj, but got I4
		Transform[] array = workers;
		if (workers == null)
		{
			goto IL_0086;
		}
		bool flag = array.Length == 0;
		object obj = !flag;
		Transform[] result = workers;
		if (obj == null)
		{
			float unscaledTime = Time.unscaledTime;
			float num = unscaledTime - workersAt;
			if (!((double)num < 10.0))
			{
				goto IL_0086;
			}
			result = workers;
		}
		goto IL_0bdc;
		IL_0bdc:
		return result;
		IL_0bef:
		return (Transform[])(object)new IndexOutOfRangeException();
		IL_0086:
		float unscaledTime2 = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D98]");
		object obj2 = 0;
		workersAt = unscaledTime2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D90]");
		object obj3 = 0;
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04D0]");
		object obj7 = 0;
		System.__Canon _Canon = (System.__Canon)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj8 = default;
		if (obj8 == null)
		{
			goto IL_0be1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v11+18]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v11+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_049b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D80]");
		object obj10 = 0;
		object obj12 = default;
		object obj11 = obj12;
		int num3 = default;
		int num2 = num3;
		int num5 = default;
		int num4 = num5;
		object obj14 = default;
		object obj13 = obj14;
		object obj15 = 0;
		System.__Canon _Canon2 = (System.__Canon)obj7;
		while (true)
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj16 = !flag3;
			if (obj16 != null)
			{
				break;
			}
			object obj17 = obj8 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v45+20]");
			Component component = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v45+20]");
			if ((nint)0 != 0)
			{
				object obj18 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X0_v60+E4]");
				bool flag4 = (nint)0 == 0;
				object obj19 = !flag4;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X22_v13 (UnityEngine.Component)+20]");
				bool flag5 = (UnityEngine.Object)0 == this;
				bool flag6 = !flag5;
				obj14 = 0;
				_Canon = (System.__Canon)(object)this;
				if (flag6)
				{
					goto IL_0431;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v45+20]");
				Transform transform = ((Component)0).transform;
				if (list != null)
				{
					System.__Canon[] items = list._items;
					num2 = (int)obj10;
					int version = list._version + 1;
					list._version = version;
					if (list._items != null)
					{
						num4 = list._size;
						obj11 = items.Length;
						bool flag7 = list._size < items.Length;
						object obj20 = !flag7;
						if (obj20 == null)
						{
							object obj21 = list._items + list._size;
							num2 = ++list._size;
							object obj22 = obj21 + 32;
							obj22 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj14 = 0;
							_Canon = (System.__Canon)(object)transform;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X9_v16 (System.Int32)+20]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v50+A8]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v51+70]");
							obj14 = 0;
							list.AddWithResize((System.__Canon)(object)transform);
							_Canon = (System.__Canon)(object)transform;
						}
						goto IL_0431;
					}
				}
			}
			goto IL_0be1;
			IL_0431:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v11+18]");
			obj9 = 0;
			obj15++;
			object obj25 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v11+18]");
			bool flag8 = (nint)obj25 < 0;
			obj12 = obj11;
			num3 = num2;
			num5 = num4;
			obj13 = obj14;
			_Canon2 = _Canon;
			if (flag8)
			{
				continue;
			}
			goto IL_049b;
		}
		goto IL_0bef;
		IL_0822:
		object obj26 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v22+E4]");
		bool flag9 = (nint)0 == 0;
		object obj27 = !flag9;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04D8]");
		object obj28 = 0;
		System.__Canon _Canon3 = (System.__Canon)obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj29 = default;
		if (obj29 == null)
		{
			goto IL_0be1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v25+18]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v25+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0b85;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D80]");
		object obj31 = 0;
		object obj32 = obj14;
		object obj33 = 0;
		while (true)
		{
			bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
			object obj34 = !flag10;
			if (obj34 != null)
			{
				break;
			}
			object obj35 = obj29 + obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v29+20]");
			Component component2 = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v29+20]");
			if ((nint)0 != 0)
			{
				object obj36 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v32+E4]");
				bool flag11 = (nint)0 == 0;
				object obj37 = !flag11;
				if (obj37 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X22_v9 (UnityEngine.Component)+20]");
				bool flag12 = (UnityEngine.Object)0 == this;
				bool flag13 = !flag12;
				obj14 = 0;
				_Canon3 = (System.__Canon)(object)this;
				if (flag13)
				{
					goto IL_0b3b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v29+20]");
				Transform transform2 = ((Component)0).transform;
				if (list != null)
				{
					System.__Canon[] items2 = list._items;
					num3 = (int)obj31;
					int version2 = list._version + 1;
					list._version = version2;
					if (list._items != null)
					{
						bool flag14 = list._size < items2.Length;
						object obj38 = !flag14;
						if (obj38 == null)
						{
							object obj39 = list._items + list._size;
							num3 = list._size + 1;
							list._size = num3;
							object obj40 = obj39 + 32;
							obj40 = transform2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj14 = 0;
							_Canon3 = (System.__Canon)(object)transform2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X9_v8 (System.Int32)+20]");
							object obj41 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X8_v34+A8]");
							object obj42 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v35+70]");
							obj14 = 0;
							list.AddWithResize((System.__Canon)(object)transform2);
							_Canon3 = (System.__Canon)(object)transform2;
						}
						goto IL_0b3b;
					}
				}
			}
			goto IL_0be1;
			IL_0b3b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v25+18]");
			obj30 = 0;
			obj33++;
			object obj43 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v25+18]");
			bool flag15 = (nint)obj43 < 0;
			obj32 = obj14;
			if (flag15)
			{
				continue;
			}
			goto IL_0b85;
		}
		goto IL_0bef;
		IL_0be1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bef;
		IL_049b:
		object obj44 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X0_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj45 = !flag16;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04E0]");
		object obj46 = 0;
		System.__Canon _Canon4 = (System.__Canon)obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD6F0");
		object obj47 = default;
		if (obj47 == null)
		{
			goto IL_0be1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v20+18]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v20+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0822;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D80]");
		object obj49 = 0;
		int num6 = num3;
		object obj50 = obj14;
		object obj51 = 0;
		System.__Canon _Canon5 = (System.__Canon)obj46;
		while (true)
		{
			bool flag17 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48);
			object obj52 = !flag17;
			if (obj52 != null)
			{
				break;
			}
			object obj53 = obj47 + obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v37+20]");
			Component component3 = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v37+20]");
			if ((nint)0 != 0)
			{
				object obj54 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v46+E4]");
				bool flag18 = (nint)0 == 0;
				object obj55 = !flag18;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X22_v11 (UnityEngine.Component)+20]");
				bool flag19 = (UnityEngine.Object)0 == this;
				bool flag20 = !flag19;
				obj14 = 0;
				_Canon4 = (System.__Canon)(object)this;
				if (flag20)
				{
					goto IL_07c8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v37+20]");
				Transform transform3 = ((Component)0).transform;
				if (list != null)
				{
					System.__Canon[] items3 = list._items;
					num6 = (int)obj49;
					int version3 = list._version + 1;
					list._version = version3;
					if (list._items != null)
					{
						bool flag21 = list._size < items3.Length;
						object obj56 = !flag21;
						if (obj56 == null)
						{
							object obj57 = list._items + list._size;
							num6 = ++list._size;
							object obj58 = obj57 + 32;
							obj58 = transform3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj14 = 0;
							_Canon4 = (System.__Canon)(object)transform3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v12 (System.Int32)+20]");
							object obj59 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v42+A8]");
							object obj60 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v43+70]");
							obj14 = 0;
							list.AddWithResize((System.__Canon)(object)transform3);
							_Canon4 = (System.__Canon)(object)transform3;
						}
						goto IL_07c8;
					}
				}
			}
			goto IL_0be1;
			IL_07c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v20+18]");
			obj48 = 0;
			obj51++;
			object obj61 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v20+18]");
			bool flag22 = (nint)obj61 < 0;
			num3 = num6;
			obj50 = obj14;
			_Canon5 = _Canon4;
			if (flag22)
			{
				continue;
			}
			goto IL_0822;
		}
		goto IL_0bef;
		IL_0b85:
		if (list != null)
		{
			System.__Canon[] array2 = (System.__Canon[])(object)(workers = (Transform[])(object)list.ToArray());
			object obj62 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			result = (Transform[])(object)array2;
			goto IL_0bdc;
		}
		goto IL_0be1;
	}

	public unsafe static void NewRoom()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I4
		//IL_03a9: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Ref, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+A0]");
		object obj6 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+A0]");
		object obj8 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v10+A0]");
		object obj10 = 0;
		_ = 4294967295L;
		_ = 3212836864L;
		NewModeRoom();
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v14+A0]");
		bool flag5 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v18 (System.Boolean)+40]");
		bool flag6 = (nint)0 == 0;
		object obj12 = 109895680;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v18 (System.Boolean)+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Enumerator<, > val = default;
			flag5 = (byte)(&val) != 0;
			object obj14 = obj13;
			bool flag7;
			object obj15;
			Enumerator<, > val2;
			if (!val.MoveNext())
			{
				flag7 = false;
				obj15 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj16 = 0;
				object obj19 = default;
				while (true)
				{
					obj14 = obj12;
					((Enumerator<, >*)val2)->Dispose();
					bool flag8 = obj16 == null;
					object obj17 = !flag8;
					if (obj17 == null)
					{
						bool flag9 = !flag7;
						object obj18 = !flag9;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj18 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj14 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						flag7 = true;
						flag5 = true;
						obj16 = obj15;
						continue;
					}
					if ((nint)obj14 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj16 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj15 = obj19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			GillaDoor gillaDoor = null;
			NullReferenceException ex2 = new NullReferenceException();
			flag7 = false;
			obj15 = 0;
			val2 = (Enumerator<, >)(ref val);
		}
		throw new NullReferenceException();
	}

	private void Snap()
	{
		//IL_00ad: Expected Obj, but got I4
		//IL_00df: Expected F8, but got I4
		if (Blown)
		{
			blownShown = true;
			float time = Time.time;
			blownAt = time;
			ShowSlab(on: false);
		}
		else if (~(blownShown ? 1u : 0u) == 0)
		{
			BackIn();
		}
		bool isOpen = IsOpen;
		bool flag = !isOpen;
		moving = false;
		object obj = !flag;
		object obj2 = ~obj;
		double num = ((obj2 != null) ? 0.0 : 1.0);
		open = (float)num;
		Place();
	}

	private void Update()
	{
		//IL_079a: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0364: Expected Obj, but got I4
		//IL_0396: Expected F8, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_03ec: Expected VT, but got I
		//IL_0116: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I4
		//IL_03a6: Invalid comparison between F4 and I4
		//IL_07de: Expected Obj, but got I4
		//IL_0a79: Expected Obj, but got I
		//IL_0a89: Expected Obj, but got I
		//IL_0ab3: Expected Obj, but got I4
		//IL_0950: Invalid comparison between F8 and I4
		//IL_0963: Expected Obj, but got F8
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_09a1: Expected Obj, but got I4
		//IL_05a8: Expected Obj, but got I4
		//IL_04c8: Expected Obj, but got I
		//IL_04f2: Expected Obj, but got I4
		//IL_0431: Invalid comparison between F4 and I4
		//IL_01ae: Expected Obj, but got I4
		//IL_0532: Expected VT, but got I4
		//IL_0548: Expected VT, but got I4
		//IL_09ec: Expected Obj, but got I4
		//IL_0a04: Invalid comparison between F4 and I4
		//IL_0a15: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_0a52: Invalid comparison between F8 and I4
		//IL_0494: Expected VT, but got I
		//IL_0860: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_0ad1: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0687: Invalid comparison between F8 and I4
		//IL_08a9: Expected Obj, but got I4
		//IL_028a: Unsupported input type for neg.
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_06e3: Expected Obj, but got I4
		//IL_0afb: Expected Obj, but got I4
		//IL_0b19: Expected Obj, but got I4
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected I4, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_08ee: Expected Obj, but got I4
		//IL_0710: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I4
		//IL_0775: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		if (~(modeMap ? 1u : 0u) == 0)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v100+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			FollowRound();
		}
		bool blown = Blown;
		if (blownShown != blown)
		{
			if (Blown)
			{
				BlowOff();
			}
			else
			{
				BackIn();
			}
		}
		if (Blown)
		{
			bool flag2 = (byte)(~(modeMap ? 1u : 0u)) != 0;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v45+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v49+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v49+A0]");
			object obj11 = 0;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v35+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = (UnityEngine.Object)obj11 != null;
			bool flag7 = !flag6;
			object obj14 = 0;
			if (!flag7)
			{
				object obj15 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v75+E4]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v79+E4]");
				bool flag9 = (nint)0 == 0;
				object obj18 = !flag9;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj17 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X0_v79+A0]");
				object obj19 = 0;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v51+6CC]");
				object obj21 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v51+6CC]");
				object obj22 = (nint)0 & (nint)3;
				object obj23 = obj21 & 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v51+6CC]");
				if ((nint)0 >= (nint)0)
				{
					obj22 = 0 - obj23;
				}
				object obj24 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				obj14 = obj24 * 0;
			}
			float time = Time.time;
			float num = time - blownAt;
			float num2 = (float)obj14 + blownResetSeconds;
			if (!(num > num2))
			{
				return;
			}
			bool flag10 = MonsterInDoorway();
			bool flag11 = !flag10;
			object obj25 = !flag11;
			if (obj25 == null)
			{
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X0_v57+E4]");
				bool flag12 = (nint)0 == 0;
				object obj27 = !flag12;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				GillaDoor gillaDoor = (GillaDoor)obj;
				bool flag13 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
				object obj28 = !flag13;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					gillaDoor = (GillaDoor)obj;
				}
				Transform transform = gillaDoor.panel;
				object obj29 = index + 24;
				int num3 = 1 << index;
				object obj30 = 1 << (int)obj29;
				int num4 = obj30 | num3;
				int num5 = ~num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X9_v10 (UnityEngine.Transform)+34]");
				int num6 = (int)((nint)0 & (nint)num5);
				bool flag14 = (byte)(~(gillaDoor.modeMap ? 1u : 0u)) != 0;
				object obj31 = !flag14;
				if (obj31 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					gillaDoor = (GillaDoor)obj;
				}
				Transform transform2 = gillaDoor.panel;
				gillaDoor.Changed();
			}
			return;
		}
		bool isOpen = IsOpen;
		bool flag15 = !isOpen;
		object obj32 = !flag15;
		object obj33 = ~obj32;
		double num7 = ((obj33 != null) ? 0.0 : 1.0);
		if ((double)open == num7)
		{
			if (!(shakeFrom < 0f))
			{
				Shudder();
			}
			return;
		}
		bool flag16 = (byte)(~(moving ? 1u : 0u)) != 0;
		object obj34 = !flag16;
		float num8 = 1f;
		IntPtr intPtr = default;
		Vector3 vector = (Vector3)(nint)intPtr;
		if (obj34 == null)
		{
			moving = true;
			if (num7 > (double)open && open == 0f)
			{
				if (prying = Pried)
				{
					PlayPry();
					num8 = 1f;
					vector = (Vector3)(nint)intPtr;
					goto IL_054d;
				}
			}
			else
			{
				prying = false;
			}
			Vector3 position = panel.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj35 = 0;
			object obj36 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v37+E4]");
			bool flag17 = (nint)0 == 0;
			object obj37 = !flag17;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float pitchMax = default;
			Sfx.Play(moveSounds, (Vector3)0, open, 1f, pitchMax);
			num8 = 1f;
			vector = (Vector3)0;
		}
		goto IL_054d;
		IL_054d:
		float num9 = Height();
		float deltaTime = Time.deltaTime;
		float prySeconds;
		if (~(prying ? 1u : 0u) == 0)
		{
			object obj38 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v32+E4]");
			bool flag18 = (nint)0 == 0;
			object obj39 = !flag18;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			prySeconds = PrySeconds;
		}
		else
		{
			prySeconds = seconds;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num10 = num7 - (double)open;
		float num11 = deltaTime / prySeconds;
		bool flag19 = num10 < 0.0;
		object obj40 = num10 ^ num10;
		object obj41 = num10 & obj40;
		bool flag20 = (nint)obj41 < 0;
		float num12 = 0f - num11;
		bool flag21 = flag19 == flag20;
		object obj42 = !flag21;
		object obj43 = ~obj42;
		float num13 = ((obj43 != null) ? num11 : num12);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num14 = open + num13;
		bool flag22 = num12 < num11;
		object obj44 = !flag22;
		float num15 = num12 - num11;
		bool flag23 = num15 == 0f;
		object obj45 = !flag23;
		object obj46 = obj44 & obj45;
		object obj47 = ~obj46;
		double num16 = ((obj47 != null) ? num7 : ((double)num14));
		open = (float)num16;
		Place();
		if (num7 == 0.0)
		{
			CrushUnder();
		}
		float num17 = Height();
		if (~(prying ? 1u : 0u) == 0)
		{
			float num18 = num17 - num9;
			float moved = rise * num18;
			float deltaTime2 = Time.deltaTime;
			double num19 = (double)open - num7;
			bool atTop = num19 == 0.0;
			PrySparks(moved, deltaTime2, atTop);
			num14 = deltaTime2;
		}
		if ((double)open != num7)
		{
			return;
		}
		bool flag24 = (byte)(~(prying ? 1u : 0u)) != 0;
		object obj48 = !flag24;
		if (obj48 == null)
		{
			Vector3 position2 = panel.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj49 = 0;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X0_v24+E4]");
			bool flag25 = (nint)0 == 0;
			object obj51 = !flag25;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sfx.Play(stopSounds, (Vector3)0, open, num14, num12);
		}
		moving = false;
	}

	private void CrushUnder()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0cf4: Expected Obj, but got I4
		//IL_0d1a: Expected Obj, but got I
		//IL_0d3c: Expected Obj, but got I4
		//IL_0dd6: Expected Obj, but got I
		//IL_0de6: Expected Obj, but got I
		//IL_0e08: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I4
		//IL_0d92: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I4
		//IL_066e: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got I
		//IL_06cb: Expected Obj, but got I8
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected Obj, but got Unknown
		//IL_06e2: Expected Obj, but got I4
		//IL_0db0: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_06ff: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I4
		//IL_0750: Expected Obj, but got I
		//IL_076e: Expected Obj, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_07f2: Expected Obj, but got I4
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected Obj, but got Unknown
		//IL_085d: Expected Obj, but got I4
		//IL_03f2: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_046d: Expected Obj, but got I4
		//IL_08af: Expected Obj, but got I4
		//IL_0d74: Expected Obj, but got I4
		//IL_08f0: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I4
		//IL_094b: Expected Obj, but got I
		//IL_096d: Expected Obj, but got I4
		//IL_09b2: Expected Obj, but got I4
		//IL_09fa: Expected Obj, but got I
		//IL_0a1c: Expected Obj, but got I4
		//IL_0a61: Expected Obj, but got I4
		//IL_0aa2: Expected Obj, but got I
		//IL_0b83: Expected Obj, but got I4
		//IL_0bb1: Expected Obj, but got I
		//IL_0bdf: Expected Obj, but got I4
		//IL_0c8f: Expected Obj, but got I
		//IL_0ca7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v1+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X20_v3 (UnityEngine.Object)+A4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj12 = 0;
		object obj13 = obj5;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v13+A0]");
		object obj15 = 0;
		UnityEngine.Object obj16 = (UnityEngine.Object)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = (UnityEngine.Object)obj15 != null;
		bool flag7 = !flag6;
		object obj19 = default;
		object obj18 = obj19;
		double num2 = default;
		double num = num2;
		double num4 = default;
		double num3 = num4;
		Dismemberment dismemberment = null;
		GillaWounds gillaWounds = null;
		if (!flag7)
		{
			object obj20 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v61+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X20_v7 (UnityEngine.Object)+20]");
			bool flag9 = (UnityEngine.Object)0 != null;
			bool flag10 = !flag9;
			obj18 = obj19;
			num = num2;
			num3 = num4;
			dismemberment = null;
			gillaWounds = null;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X20_v7 (UnityEngine.Object)+A9]");
				bool flag11 = (nint)0 == 0;
				object obj22 = !flag11;
				obj18 = obj19;
				num = num2;
				num3 = num4;
				dismemberment = null;
				gillaWounds = null;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj23 = 0;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v65+E4]");
					bool flag12 = (nint)0 == 0;
					object obj25 = !flag12;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool isMonster = MonsterPlayer.IsMonster;
					bool flag13 = !isMonster;
					object obj26 = !flag13;
					obj18 = obj19;
					num = num2;
					num3 = num4;
					dismemberment = null;
					gillaWounds = null;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X20_v7 (UnityEngine.Object)+20]");
						Vector3 position = ((Transform)0).position;
						Vector3 foot = Foot;
						double num5 = num4 - num4;
						double num6 = num2 - num2;
						obj18 = obj19 - obj19;
						double num7 = num5 * num5;
						double num8 = num6 * num6;
						double num9 = num7 + num8;
						object obj27 = obj18 * obj18;
						num3 = (double)obj27 + num9;
						bool flag14 = !(num3 < 16.0);
						num = 16.0;
						dismemberment = null;
						gillaWounds = null;
						if (!flag14)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
							object obj28 = 0;
							object obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v74+E4]");
							bool flag15 = (nint)0 == 0;
							object obj30 = !flag15;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Dismemberment dismemberment2 = YourBody();
							object obj31 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v40+E4]");
							bool flag16 = (nint)0 == 0;
							object obj32 = !flag16;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag17 = dismemberment2 != null;
							bool flag18 = !flag17;
							UnityEngine.Object obj33 = null;
							UnityEngine.Object obj34 = null;
							if (!flag18)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
								object obj35 = 0;
								object obj36 = obj35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X0_v88+E4]");
								bool flag19 = (nint)0 == 0;
								object obj37 = !flag19;
								if (obj37 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaWounds gillaWounds2 = GillaWounds.On(dismemberment2);
								obj33 = gillaWounds2;
								obj34 = null;
							}
							object obj38 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v80+E4]");
							bool flag20 = (nint)0 == 0;
							object obj39 = !flag20;
							if (obj39 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag21 = obj33 != null;
							bool flag22 = !flag21;
							num = 16.0;
							dismemberment = null;
							gillaWounds = null;
							if (!flag22)
							{
								bool flag23 = Meets((GillaWounds)obj33);
								bool flag24 = !flag23;
								num = 16.0;
								dismemberment = null;
								gillaWounds = (GillaWounds)obj33;
								if (!flag24)
								{
									MeetYou((GillaWounds)obj33, dismemberment2, (KillCam)obj15);
									num = 16.0;
									dismemberment = dismemberment2;
									gillaWounds = (GillaWounds)obj33;
								}
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C70]");
		object obj40 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v19+E4]");
		bool flag25 = (nint)0 == 0;
		object obj42 = !flag25;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj41 = obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v19+A0]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB720]");
		object obj44 = 0;
		UnityEngine.Object obj45 = (UnityEngine.Object)obj44;
		System.__Canon[] array = ((List<System.__Canon>)obj43).ToArray();
		if (array.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj46 = 0;
		object obj47 = array.Length & 0xFFFFFFFFL;
		object obj48 = array + 32;
		object obj49 = 0;
		while (true)
		{
			bool flag26 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47);
			object obj50 = !flag26;
			if (obj50 != null)
			{
				break;
			}
			object obj51 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X26_v4+v138 @ X24_v5*8]");
			UnityEngine.Object obj52 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v24+E4]");
			bool flag27 = (nint)0 == 0;
			object obj53 = !flag27;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X26_v4+v138 @ X24_v5*8]");
			bool flag28 = (UnityEngine.Object)0 == null;
			bool flag29 = !flag28;
			object obj54 = !flag29;
			object obj55 = obj18;
			double num10 = num;
			double num11 = num3;
			dismemberment = null;
			obj45 = null;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+98]");
				bool flag30 = (nint)0 != 3;
				obj55 = obj18;
				num10 = num;
				num11 = num3;
				dismemberment = null;
				obj45 = null;
				if (flag30)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+98]");
					bool flag31 = (nint)0 == 0;
					object obj56 = !flag31;
					obj55 = obj18;
					num10 = num;
					num11 = num3;
					dismemberment = null;
					obj45 = null;
					if (obj56 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+ED]");
						bool flag32 = (nint)0 == 0;
						object obj57 = !flag32;
						obj55 = obj18;
						num10 = num;
						num11 = num3;
						dismemberment = null;
						obj45 = null;
						if (obj57 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X26_v4+v138 @ X24_v5*8]");
							bool mine = ((GillaDummy)0).Mine;
							bool flag33 = !mine;
							obj55 = obj18;
							num10 = num;
							num11 = num3;
							dismemberment = null;
							obj45 = null;
							if (!flag33)
							{
								object obj58 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+80]");
								UnityEngine.Object obj33 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X0_v31+E4]");
								bool flag34 = (nint)0 == 0;
								object obj59 = !flag34;
								if (obj59 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag35 = obj33 == null;
								bool flag36 = !flag35;
								object obj60 = !flag36;
								obj55 = obj18;
								num10 = num;
								num11 = num3;
								dismemberment = null;
								obj45 = null;
								if (obj60 == null)
								{
									object obj61 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+68]");
									obj33 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v35+E4]");
									bool flag37 = (nint)0 == 0;
									object obj62 = !flag37;
									if (obj62 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag38 = obj33 == null;
									bool flag39 = !flag38;
									object obj63 = !flag39;
									obj55 = obj18;
									num10 = num;
									num11 = num3;
									dismemberment = null;
									obj45 = null;
									if (obj63 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+68]");
										Vector3 position2 = ((Transform)0).position;
										Vector3 foot2 = Foot;
										double num12 = num3 - num3;
										double num13 = num - num;
										obj55 = obj18 - obj18;
										double num14 = num12 * num12;
										double num15 = num13 * num13;
										double num16 = num14 + num15;
										num10 = (double)obj55 * (double)obj55;
										num11 = num10 + num16;
										bool flag40 = num11 > 16.0;
										dismemberment = null;
										obj45 = null;
										if (!flag40)
										{
											object obj64 = obj46;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v43+E4]");
											bool flag41 = (nint)0 == 0;
											object obj65 = !flag41;
											if (obj65 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X21_v8 (UnityEngine.Object)+80]");
											GillaWounds gillaWounds3 = GillaWounds.On((Dismemberment)0);
											object obj66 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v31+E4]");
											bool flag42 = (nint)0 == 0;
											object obj67 = !flag42;
											if (obj67 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag43 = gillaWounds3 != null;
											bool flag44 = !flag43;
											obj33 = gillaWounds3;
											dismemberment = null;
											obj45 = null;
											if (!flag44)
											{
												bool flag45 = Meets(gillaWounds3);
												bool flag46 = !flag45;
												obj33 = gillaWounds3;
												dismemberment = null;
												obj45 = gillaWounds3;
												if (!flag46)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X26_v4+v138 @ X24_v5*8]");
													MeetDummy(gillaWounds3, (GillaDummy)0);
													obj33 = gillaWounds3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X26_v4+v138 @ X24_v5*8]");
													dismemberment = (Dismemberment)0;
													obj45 = gillaWounds3;
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
			obj47 = array.Length;
			obj49++;
			bool flag47 = (nint)obj49 < array.Length;
			obj18 = obj55;
			num = num10;
			num3 = num11;
			if (!flag47)
			{
				return;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static Dismemberment YourBody()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I
		//IL_0547: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I8
		//IL_0200: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I4
		//IL_0212: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_04ed: Expected Obj, but got I
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 == null;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		Dismemberment result = null;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_044a;
			}
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v3 (UnityEngine.Object)+68]");
			bool flag7 = (UnityEngine.Object)0 == null;
			bool flag8 = !flag7;
			object obj14 = !flag8;
			result = null;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v3 (UnityEngine.Object)+68]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X19_v3 (UnityEngine.Object)+68]");
				if ((nint)0 == 0)
				{
					goto IL_044a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11+20]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X22_v4+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X22_v4+18]");
						object obj17 = 0 & 0xFFFFFFFFL;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11+20]");
						object obj18 = (nint)0 + (nint)32;
						object obj19 = 0;
						object obj20 = 0;
						UnityEngine.Object obj21 = null;
						UnityEngine.Object obj22 = null;
						while (true)
						{
							bool flag9 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
							object obj23 = !flag9;
							if (obj23 == null)
							{
								object obj24 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v96 @ X23_v5*8]");
								UnityEngine.Object obj25 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v20+E4]");
								bool flag10 = (nint)0 == 0;
								object obj26 = !flag10;
								if (obj26 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v96 @ X23_v5*8]");
								bool flag11 = (UnityEngine.Object)0 == null;
								bool flag12 = !flag11;
								object obj27 = !flag12;
								obj20 = 0;
								obj21 = null;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v96 @ X23_v5*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v96 @ X23_v5*8]");
									bool flag13 = ((UnityEngine.Behaviour)0).isActiveAndEnabled;
									bool flag14 = !flag13;
									obj20 = 0;
									obj21 = null;
									if (!flag14)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X20_v11 (UnityEngine.Object)+28]");
										bool flag15 = (nint)0 == 0;
										object obj28 = !flag15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v96 @ X23_v5*8]");
										result = (Dismemberment)0;
										if (obj28 != null)
										{
											goto IL_04d8;
										}
										object obj29 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v27+E4]");
										bool flag16 = (nint)0 == 0;
										object obj30 = !flag16;
										if (obj30 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag17 = obj22 == null;
										bool flag18 = !flag17;
										object obj31 = !flag18;
										object obj32 = ~obj31;
										if (obj32 == null)
										{
											obj20 = 0;
											obj21 = null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v96 @ X23_v5*8]");
											obj22 = (UnityEngine.Object)0;
										}
										else
										{
											obj20 = 0;
											obj21 = null;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X22_v4+18]");
								obj17 = 0;
								obj19++;
								object obj33 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X22_v4+18]");
								if ((nint)obj33 < 0)
								{
									continue;
								}
								result = (Dismemberment)obj22;
								goto IL_04d8;
							}
							IndexOutOfRangeException ex = new IndexOutOfRangeException();
							break;
						}
						goto IL_044a;
					}
				}
				result = null;
			}
		}
		goto IL_04d8;
		IL_04d8:
		return result;
		IL_044a:
		return (Dismemberment)(object)new NullReferenceException();
	}

	private unsafe bool Meets(GillaWounds w)
	{
		//IL_0a94: Expected Obj, but got I
		//IL_0abe: Expected Obj, but got I4
		//IL_0f58: Expected Obj, but got I
		//IL_0f68: Expected Obj, but got I
		//IL_0f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected F4, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected F4, but got I4
		//IL_0093: Expected Obj, but got I
		//IL_0adc: Expected Obj, but got I
		//IL_0af4: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00f1: Expected F4, but got I
		//IL_0101: Expected F8, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got I
		//IL_02c8: Expected F4, but got I
		//IL_02d8: Expected F8, but got I
		//IL_0312: Expected I, but got Obj
		//IL_07a4: Expected F4, but got I4
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected Obj, but got I4
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got I4
		//IL_07da: Expected Obj, but got I4
		//IL_0f0f: Expected Obj, but got I
		//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected Ref, but got Unknown
		//IL_0f3a: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got Ref
		//IL_032f: Expected F4, but got I
		//IL_0357: Expected F4, but got I
		//IL_036d: Expected F8, but got I4
		//IL_1006: Invalid comparison between F8 and I4
		//IL_07e8: Invalid comparison between F4 and I4
		//IL_07f9: Expected Obj, but got I4
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Obj, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected Obj, but got Unknown
		//IL_0b50: Expected F8, but got I
		//IL_0c64: Expected VT, but got F8
		//IL_086c: Expected Obj, but got I
		//IL_0896: Expected Obj, but got I4
		//IL_0a1b: Expected F4, but got I4
		//IL_0ea7: Expected Obj, but got I
		//IL_0eb7: Expected Obj, but got I
		//IL_0846: Expected Obj, but got I4
		//IL_0fdb: Expected Obj, but got I4
		//IL_0432: Expected VT, but got F8
		//IL_0a7a: Expected Obj, but got I4
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e92: Expected I4, but got Unknown
		//IL_0906: Expected Obj, but got I
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Obj, but got Unknown
		//IL_0943: Expected Obj, but got I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected F4, but got Unknown
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected Obj, but got Unknown
		//IL_0458: Expected VT, but got F8
		//IL_0534: Invalid comparison between F8 and I4
		//IL_0545: Expected Obj, but got I4
		//IL_054e: Invalid comparison between F8 and I4
		//IL_055f: Expected Obj, but got I4
		//IL_0ce4: Expected Obj, but got I
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected Obj, but got Unknown
		//IL_0d36: Expected F8, but got Obj
		//IL_0d5d: Expected F4, but got I
		//IL_05a2: Expected Obj, but got I
		//IL_05cc: Expected Obj, but got I4
		//IL_0e1e: Expected Obj, but got I
		//IL_0e2e: Expected Obj, but got I
		//IL_0e3e: Expected Obj, but got I
		//IL_0e4f: Expected VT, but got Obj
		//IL_0e4f: Expected I4, but got F4
		//IL_0e6e: Expected I, but got Obj
		//IL_0e76: Expected Obj, but got F4
		//IL_0970: Expected F4, but got I4
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got I4
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got I
		//IL_0611: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I
		//IL_0650: Expected I, but got Obj
		//IL_0658: Expected Obj, but got VT
		//IL_0676: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I4
		//IL_073b: Expected Obj, but got I
		//IL_074b: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I
		//IL_0796: Expected I, but got Obj
		//IL_06ca: Expected Obj, but got I
		//IL_06e0: Expected Obj, but got I
		//IL_0726: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+70]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+70]");
		bool flag2 = (nint)0 == 0;
		float num2 = default;
		float num = num2;
		Enumerator<, > val = (Enumerator<, >)0;
		float num4 = default;
		float num3 = num4;
		float num5 = 0f;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v9+1C]");
			object obj6 = (nint)0 + (nint)1;
			_ = 0;
			GillaWounds gillaWounds = default;
			bool flag3 = (object)gillaWounds == null;
			num = num2;
			val = (Enumerator<, >)0;
			num3 = num4;
			num5 = 0f;
			if (!flag3)
			{
				GillaWounds gillaWounds2 = gillaWounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+68]");
				gillaWounds2.Shapes((List<(GoreSection, Vector3, Vector3, float)>)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v22+A0]");
				object obj9 = 0;
				Vector3 foot = Foot;
				double num6 = Width__BackingField;
				float num7 = rise;
				float num8 = Height();
				float num9 = rise;
				num5 = Height();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
				object obj10 = 0;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v26+A0]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v27+68]");
				bool flag4 = (nint)0 == 0;
				Vector3 vector = Through__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				float num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v23+1C]");
				double num11 = 0.0;
				num = num2;
				val = (Enumerator<, >)0;
				num3 = num4;
				nint num12 = unchecked((nint)null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+68]");
				gillaWounds = (GillaWounds)0;
				if (!flag4)
				{
					float num13 = rise * num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7180]");
					object obj13 = 0;
					num9 = rise * num8;
					object obj14 = this + 324;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v23+18]");
					float num14 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
					float num15 = num14 * 0f;
					double num16 = (double)Through__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v23+1C]");
					double num17 = num16 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v23+1C]");
					double num19 = default;
					double num18 = 0.0 * num19;
					float num20 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
					float num21 = num20 * 0f;
					float num22 = tall;
					float num23 = num15 - (float)num17;
					float num24 = num13 + tall;
					float num25 = (float)num18 - num21;
					double num26 = (double)Width__BackingField * 0.5;
					double num27 = (double)Thickness__BackingField * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0520]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v27+68]");
					Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3, Vector3, float)>)0).GetEnumerator();
					double num28 = 0.0 - num26;
					double num29 = 0.0 - num27;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					obj = 0;
					vector = Through__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
					num10 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v23+1C]");
					num11 = 0.0;
					float num31 = default;
					float num30 = num31;
					float num32 = default;
					num3 = num32;
					float num33 = num23;
					double num34 = 0.5;
					num5 = num25;
					num6 = num26;
					num12 = unchecked((nint)null);
					object obj17 = default;
					float num39 = default;
					object obj18 = default;
					double num49 = default;
					double num50 = default;
					float num59 = default;
					double num60 = default;
					object obj24 = default;
					object obj25 = default;
					Enumerator<, > val2 = default;
					bool result = default;
					object obj46 = default;
					while (true)
					{
						object obj40;
						Enumerator<, > val3;
						float num61;
						if (val.MoveNext())
						{
							object obj16 = (object)(&obj17);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v33+FF]");
							num7 = 0f;
							float num35 = num32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v33+FF]");
							float num36 = num35 - 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v33+FF]");
							float num37 = 0f;
							float num38 = num39;
							List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list = null;
							double num40 = 2139095039.0;
							bool flag13;
							do
							{
								double num41 = (double)list / 6.0;
								double num51;
								double num52;
								if (num41 < 0.0 || !(num41 > 1.0))
								{
									obj5 = this + 328;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
									num34 = 0.0;
									float num42 = num36 * (float)obj18;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									float num43 = num7 + num42;
									float num44 = num43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
									float num45 = num44 - 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
									float num46 = num25 * num45;
									num33 = num25 * (float)num17;
									float num47 = num46 + num33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
									double num48 = 0.0 * (double)num31;
									num49 = num48 + (double)num47;
									bool flag5 = num50 < num28;
									num11 = num28;
									num51 = num28;
									num52 = num50;
									if (flag5)
									{
										goto IL_0c2a;
									}
								}
								bool flag6 = !(num50 > num26);
								num11 = num50;
								num51 = num26;
								num52 = num50;
								if (!flag6)
								{
									num11 = num26;
									num51 = num26;
									num52 = num26;
								}
								goto IL_0c2a;
								IL_0c2a:
								bool flag7 = num30 < num9;
								num10 = num9;
								if (!flag7)
								{
									bool flag8 = !(num30 > num24);
									num10 = num30;
									if (!flag8)
									{
										num10 = num24;
									}
								}
								bool flag9 = num49 < num29;
								vector = (Vector3)num29;
								double num53 = num29;
								if (!flag9)
								{
									bool flag10 = !(num49 > num27);
									vector = (Vector3)num49;
									num52 = num49;
									num53 = num49;
									if (!flag10)
									{
										vector = (Vector3)num27;
										num52 = num49;
										num53 = num27;
									}
								}
								object obj19 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X0_v44+E4]");
								bool flag11 = (nint)0 == 0;
								object obj20 = !flag11;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								double num54 = num49 - (double)vector;
								float num55 = num30 - num10;
								double num56 = num54 * num54;
								float num57 = num55 * num55;
								float num58 = num59 + num57;
								num5 = num58 + (float)num56;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
								num6 = (double)num5 - num60;
								bool flag12 = !(num6 < num40);
								num3 = num59;
								num19 = num60;
								num61 = num23;
								if (!flag12)
								{
									object obj21 = obj7;
									float num62 = num23 * (float)num11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v55+A0]");
									object obj22 = 0;
									float num63 = num25 * num59;
									float num64 = num4 + num62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v56+18]");
									object obj23 = 0 * obj24;
									float num65 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v56+20]");
									float num66 = num65 * 0f;
									num34 = (double)obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
									float num67 = 0f + num63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
									num61 = 0f;
									float num68 = num64 + num66;
									float num69 = num67 + (float)obj23;
									double num70 = (double)obj14 * (double)obj25;
									float num71 = (float)vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
									num33 = num71 * 0f;
									num19 = (double)num69 + num70;
									num5 = num68 + num33;
									num37 = (float)num19;
									num38 = num5;
									num40 = num6;
									num3 = (float)num70;
								}
								list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)(list + 1);
								flag13 = (nint)list != 7;
								num30 = num59;
								num17 = num61;
							}
							while (flag13);
							bool flag14 = num40 < 0.0;
							object obj26 = !flag14;
							bool flag15 = num40 == 0.0;
							object obj27 = !flag15;
							object obj28 = obj26 & obj27;
							num30 = num59;
							num17 = num61;
							num22 = num4;
							if (obj28 != null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
							object obj29 = 0;
							object obj30 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X0_v48+E4]");
							bool flag16 = (nint)0 == 0;
							object obj31 = !flag16;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
								object obj32 = 0;
								obj30 = obj32;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X0_v48+A0]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X8_v44+70]");
							list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9BB0]");
							object obj34 = 0;
							(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3) tuple = ((Unity.IL2CPP.Metadata.__Il2CppByteEnum)(int)num2, (Vector3)obj34);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X8_v44+70]");
							bool flag17 = (nint)0 == 0;
							num12 = (nint)obj34;
							gillaWounds = (GillaWounds)num2;
							if (!flag17)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+10]");
								object obj35 = 0;
								obj5 = obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+1C]");
								obj6 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+10]");
								bool flag18 = (nint)0 == 0;
								num12 = unchecked((nint)null);
								gillaWounds = (GillaWounds)tuple;
								if (!flag18)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+18]");
									obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+18]");
									nint num72 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v48+18]");
									bool flag19 = num72 < 0;
									object obj36 = !flag19;
									if (obj36 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+10]");
										nint num73 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+18]");
										object obj37 = num73 + 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X23_v1 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+18]");
										obj5 = (nint)0 + (nint)1;
										_ = 0;
										num30 = num59;
										num3 = num38;
										num19 = num59;
										num17 = num61;
										num22 = num4;
										num5 = num37;
										num12 = unchecked((nint)null);
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v9+20]");
										object obj38 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X8_v49+A8]");
										object obj39 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X8_v44+70]");
										((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0).AddWithResize(tuple);
										num30 = num59;
										num3 = num38;
										num19 = num59;
										num17 = num61;
										num22 = num4;
										num5 = num37;
										num12 = unchecked((nint)null);
									}
									continue;
								}
							}
							NullReferenceException ex = new NullReferenceException();
							num = 0f;
							val = val2;
							obj40 = 0;
							val3 = (Enumerator<, >)(ref val);
							num3 = num38;
							num19 = num59;
							num22 = num4;
							num5 = num37;
							break;
						}
						num = 0f;
						val = val2;
						obj40 = 0;
						val3 = (Enumerator<, >)(ref val);
						num61 = (float)num17;
						object obj41 = 0;
						object obj42 = 7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7178]");
							object obj43 = 0;
							gillaWounds = (GillaWounds)obj43;
							((Enumerator<, >*)val3)->Dispose();
							bool flag20 = obj41 == null;
							object obj44 = !flag20;
							if (obj44 == null)
							{
								bool flag21 = num == 0f;
								object obj45 = !flag21;
								OutOfMemoryException ex2 = (OutOfMemoryException)val3;
								if (obj45 == null)
								{
									break;
								}
							}
							else
							{
								OutOfMemoryException ex2 = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							if ((nint)gillaWounds == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								num = 1f;
								obj41 = obj40;
							}
							else
							{
								if ((nint)gillaWounds != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DF04");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
									return result;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								obj41 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								obj40 = obj46;
							}
							obj42 = 0;
						}
						float num74;
						if ((nint)obj42 != 7)
						{
							bool flag22 = obj42 == null;
							object obj47 = !flag22;
							num74 = num;
							if (obj47 != null)
							{
								goto IL_0e84;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
						object obj48 = 0;
						object obj49 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v9+E4]");
						bool flag23 = (nint)0 == 0;
						object obj50 = !flag23;
						if (obj50 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj49 = obj48;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v9+A0]");
						object obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X8_v11+70]");
						object obj52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ X8_v11+70]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v12+18]");
						bool flag24 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v12+18]");
						bool flag25 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v12+18]");
						nint num75 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v12+18]");
						object obj53 = num75 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v12+18]");
						object obj54 = 0 & obj53;
						bool flag26 = (nint)obj54 < 0;
						bool flag27 = flag24 == flag26;
						object obj55 = !flag25;
						float num76 = (float)(flag27 & obj55);
						num74 = num76;
						goto IL_0e84;
						IL_0e84:
						return (byte)(num74 & 1) != 0;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe Cut CutOf(GillaWounds w, Dismemberment body)
	{
		//IL_0682: Expected Obj, but got I
		//IL_0819: Expected Obj, but got I
		//IL_0839: Expected Obj, but got I
		//IL_0851: Expected F8, but got I
		//IL_0873: Expected Obj, but got I4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected F8, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got I4
		//IL_07d0: Expected Obj, but got I4
		//IL_00a1: Invalid comparison between F8 and I4
		//IL_0150: Invalid comparison between F8 and I4
		//IL_0161: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got Ref
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01a4: Expected F8, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_0601: Expected F8, but got I4
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected VT, but got I4
		//IL_037a: Expected VT, but got I4
		//IL_08ab: Expected Obj, but got I
		//IL_08e4: Expected Obj, but got I4
		//IL_03f6: Invalid comparison between F8 and I
		//IL_0467: Expected Obj, but got I
		//IL_046f: Expected F4, but got Obj
		//IL_047f: Expected F4, but got I
		//IL_048f: Expected F8, but got I
		//IL_0769: Expected Obj, but got I4
		//IL_0508: Expected VT, but got I4
		//IL_0526: Expected VT, but got I4
		//IL_052a: Expected VT, but got I4
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0559: Expected VT, but got F4
		//IL_0554: Expected native int or pointer, but got VT
		//IL_0569: Expected Obj, but got I4
		//IL_0784: Expected native int or pointer, but got VT
		//IL_079b: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+A0]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+8]");
		double num = 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4+A0]");
		Enumerator<, > val = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v29 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`4<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3, UnityEngine.Vector3, System.Single>>+Enumerator<System.ValueTuple`4<Unity.IL2CPP.M…");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val3 = (Enumerator<, >)0;
		GillaWounds gillaWounds = w;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7178]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
			object bone = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67B0]");
			object part = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4900]");
			object part2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v29 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`4<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3, UnityEngine.Vector3, System.Single>>+Enumerator<System.ValueTuple`4<Unity.IL2CPP.M…");
			Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3, Vector3, float)>)0).GetEnumerator();
			Enumerator<, > val5 = default;
			Enumerator<, > val4 = val5;
			double num3 = default;
			double num2 = num3;
			Enumerator<, > val6 = default;
			val3 = val6;
			val = (Enumerator<, >)(ref val2);
			object obj9 = default;
			double num4 = default;
			object obj10 = default;
			while (val2.MoveNext())
			{
				if (num3 == 1.0)
				{
					val3 = (Enumerator<, >)(obj9 + num4);
					val4 = (Enumerator<, >)(val5 + obj10);
					num = (double)val3 * 0.5;
					obj6 = val4 * 63;
					num2 = num4;
				}
			}
			double num5 = 0.0;
			val2 = val6;
			object obj11 = 0;
			double num6 = 0.5;
			object obj12 = 63;
			Enumerator<, > val7 = (Enumerator<, >)(ref val2);
			object obj13 = 0;
			object obj16 = default;
			Cut result = default;
			while (true)
			{
				gillaWounds = (GillaWounds)obj8;
				val2.Dispose();
				bool flag3 = obj13 == null;
				object obj14 = !flag3;
				num3 = num5;
				if (obj14 == null)
				{
					bool flag4 = num5 == 0.0;
					object obj15 = !flag4;
					num3 = num5;
					OutOfMemoryException ex = (OutOfMemoryException)(&val2);
					if (obj15 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)gillaWounds == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num5 = 1.0;
					val = (Enumerator<, >)1;
					obj13 = obj11;
					continue;
				}
				if ((nint)gillaWounds == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj13 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num5 = num3;
					obj11 = obj16;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DF04");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
			}
			Vector3 foot = Foot;
			object obj17 = this + 324;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
			num6 = 0.0;
			double num7 = (double)Thickness__BackingField * 0.5;
			double num8 = 0.0 - num7;
			obj12 = obj17;
			double num9 = num - (double)val4;
			object obj18 = obj6 - val3;
			double num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
			num2 = num10 * 0.0;
			object obj19 = obj17 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			double num11 = num2 + (double)obj19;
			if (!(num11 < num8))
			{
				num2 = (double)Thickness__BackingField * 0.5;
				bool flag5 = !(num11 > num2);
				num8 = num11;
				if (!flag5)
				{
					num8 = num2;
				}
			}
			Vector3 foot2 = Foot;
			bool flag6 = (object)w == null;
			num3 = num5;
			val3 = (Enumerator<, >)num11;
			if (!flag6)
			{
				double num12 = num - (double)val4;
				double num13 = (double)obj6 - num11;
				double num14 = num13 * (double)obj17;
				double num15 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				double num16 = num15 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				double num17 = num16 + num14;
				double num18 = num17 - num8;
				object obj21 = default;
				object obj20 = obj12 * obj21;
				double num19 = num6 * num18;
				object obj22 = obj6 - obj20;
				double num20 = num - num19;
				Vector3 vector = w.OnBody((string)bone, (Vector3)0);
				object obj23 = obj17 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				double num21 = 0.0 + num20;
				Vector3 vector2 = w.OnBody((string)bone, (Vector3)0);
				object obj24 = obj23 - obj22;
				object obj26 = default;
				object obj25 = obj26 - obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj27 = 0;
				double num22 = num21 - num20;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj29 = !flag7;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj30 = obj24 * obj24;
				object obj31 = obj25 * obj25;
				object obj32 = obj30 + obj31;
				double num23 = num22 * num22;
				double num24 = num23 + (double)obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
				double num27;
				float num28;
				float num29;
				if (num24 > 0.0)
				{
					double num25 = (double)obj24 / num24;
					double num26 = (double)obj25 / num24;
					num27 = num22 / num24;
					num28 = (float)num26;
					num29 = (float)num25;
				}
				else
				{
					object obj33 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v25+A0]");
					object obj34 = 0;
					num29 = (float)obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v26+4]");
					num28 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v26+8]");
					num27 = 0.0;
				}
				object obj35 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v20+E4]");
				bool flag8 = (nint)0 == 0;
				object obj36 = !flag8;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num30 = (float)obj22 * num29;
				float num31 = (float)obj26 * num28;
				double num32 = num20 * num27;
				float num33 = num30 + num31;
				double num34 = num32 + (double)num33;
				bool flag9 = Crosses(body, (string)part, (Vector3)0, num29, num28);
				Cut cut = (Cut)Crosses(body, (string)part2, (Vector3)0, num29, num28);
				object obj37 = cut & 1;
				bool flag10 = obj37 == null;
				Cut cut2 = default;
				((Cut*)(nint)cut2)->normal = (Vector3)num29;
				object obj38 = !flag10;
				object obj39 = ~obj38;
				bool torso = ((obj39 == null) ? false : false);
				((Cut*)(nint)cut2)->off = (float)num34;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
				((Cut*)(nint)cut2)->torso = torso;
				return cut;
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static bool Crosses(Dismemberment body, string part, Vector3 n, float off, float margin)
	{
		//IL_0462: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_015e: Expected VT, but got I4
		//IL_0294: Expected Obj, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_0199: Expected VT, but got I4
		//IL_01b8: Expected Obj, but got I
		//IL_0202: Expected VT, but got I4
		//IL_0221: Expected Obj, but got I
		//IL_026d: Expected Obj, but got I4
		//IL_0276: Expected VT, but got I4
		//IL_02e5: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I4
		//IL_0355: Expected VT, but got Ref
		//IL_038a: Invalid comparison between F4 and Obj
		//IL_03c8: Invalid comparison between F4 and I4
		//IL_03d7: Invalid comparison between F4 and I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03f7: Expected Obj, but got F4
		//IL_042c: Expected Obj, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected I4, but got Unknown
		if ((object)body != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9070]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F900");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+18]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_02c6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8850]");
				object value = 0;
				object obj5 = 0;
				object obj15 = default;
				IntPtr intPtr = default;
				object obj16 = default;
				object obj17 = default;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = obj2 + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+20]");
						Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
						object obj8 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v12+E4]");
						bool flag2 = (nint)0 == 0;
						object obj9 = !flag2;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = sharedMesh == null;
						bool flag4 = !flag3;
						object obj10 = !flag4;
						Vector3 vector = (Vector3)0;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+20]");
							bool flag5 = ((Renderer)0).enabled;
							bool flag6 = !flag5;
							vector = (Vector3)0;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+20]");
								string text = ((UnityEngine.Object)0).name;
								if (text == null)
								{
									goto IL_0446;
								}
								bool flag7 = text.StartsWith((string)value);
								bool flag8 = !flag7;
								vector = (Vector3)0;
								if (!flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+20]");
									string text2 = ((UnityEngine.Object)0).name;
									if (text2 == null)
									{
										goto IL_0446;
									}
									bool flag9 = text2.EndsWith(part);
									bool flag10 = !flag9;
									object obj11 = !flag10;
									vector = (Vector3)0;
									if (obj11 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v11+20]");
										Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
										object obj12 = 0;
										object obj13 = obj12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v16+E4]");
										bool flag11 = (nint)0 == 0;
										object obj14 = !flag11;
										if (obj14 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Extent(sharedMesh2, (Vector3)(&obj15), out var lo, out *(float*)intPtr);
										float num = lo - (float)obj15;
										float num2 = num * (float)obj16;
										float num3 = (float)obj15 + num2;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
										{
											float num4 = lo - num2;
											float num5 = num4 - (float)obj17;
											bool flag12 = num5 < 0f;
											bool flag13 = num5 == 0f;
											object obj18 = num4 ^ obj17;
											object obj19 = num4 ^ num5;
											object obj20 = obj18 & obj19;
											bool flag14 = (nint)obj20 < 0;
											bool flag15 = flag12 == flag14;
											object obj21 = !flag13;
											return (byte)((flag15 & obj21) ? 1 : 0) != 0;
										}
										goto IL_02c6;
									}
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+18]");
						obj3 = 0;
						obj5++;
						object obj22 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+18]");
						if ((nint)obj22 < 0)
						{
							continue;
						}
						goto IL_02c6;
					}
					goto IL_0446;
				}
				goto IL_0454;
			}
		}
		goto IL_0446;
		IL_0446:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0454;
		IL_02c6:
		return false;
		IL_0454:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private unsafe static void Extent(Mesh mesh, Vector3 n, out float lo, out float hi)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I4
		//IL_068e: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I4
		//IL_0267: Expected native int or pointer, but got VT
		//IL_03e4: Unsupported input type for neg.
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0707: Expected Obj, but got I4
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_02a6: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_01c1: Expected Obj, but got I4
		//IL_01f6: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_05a2: Expected native int or pointer, but got VT
		//IL_05c4: Invalid comparison between F4 and I4
		//IL_05d3: Invalid comparison between F4 and I4
		//IL_05eb: Expected Obj, but got F4
		//IL_05fd: Expected Obj, but got F4
		//IL_0632: Expected Obj, but got I4
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_030b: Expected F4, but got I8
		//IL_0314: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_065e: Expected Ref, but got F4
		//IL_04e5: Expected Obj, but got I4
		//IL_0179: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_06a3: Expected Obj, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_0398: Expected native int or pointer, but got VT
		//IL_03b7: Expected Ref, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C98A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+78]");
		bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)mesh, out var _);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		System.__Canon _Canon = default;
		if (obj6 == null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v14+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0560]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v17+78]");
			int count = ((Dictionary<System.__Canon, System.__Canon>)0).Count;
			if (count >= 65)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v29+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v29+A0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0558]");
				object obj15 = 0;
				obj11 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v26+78]");
				((Dictionary<System.__Canon, System.__Canon>)0).Clear();
			}
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v19+A0]");
			object obj18 = 0;
			bool isReadable = mesh.isReadable;
			bool flag7 = !isReadable;
			_Canon = null;
			if (!flag7)
			{
				Vector3[] vertices = mesh.vertices;
				_Canon = (System.__Canon)(object)vertices;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v22+78]");
			((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)mesh, _Canon);
		}
		((Vector3*)(nint)n)->x = 3.4028235E+38f;
		ref float reference = ref *(float*)4286578687L;
		object obj24 = default;
		object obj29 = default;
		if (_Canon != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X2_v5 (System.__Canon)+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X2_v5 (System.__Canon)+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X2_v5 (System.__Canon)+18]");
				if ((nint)0 < (nint)1)
				{
					return;
				}
				object obj20 = _Canon + 40;
				float num = 4.2865787E+09f;
				object obj21 = 0;
				object obj26 = default;
				while (true)
				{
					bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
					object obj22 = !flag8;
					if (obj22 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v4-8]");
					object obj23 = obj24 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X10_v4-4]");
					object obj25 = obj26 * 0;
					object obj27 = obj23 + obj25;
					object obj28 = obj29 * obj20;
					float num2 = (float)obj28 + (float)obj27;
					if (num2 < n.x)
					{
						((Vector3*)(nint)n)->x = num2;
						num = lo;
					}
					if (num2 > num)
					{
						reference = ref *(float*)num2;
						num = num2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X2_v5 (System.__Canon)+18]");
					obj19 = 0;
					obj21++;
					obj20 += 12;
					object obj30 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X2_v5 (System.__Canon)+18]");
					if ((nint)obj30 >= 0)
					{
						return;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
		}
		Bounds bounds = mesh.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj32 = default;
		object obj31 = 0 - obj32;
		object obj33 = 0;
		float num4 = default;
		object obj40 = default;
		object obj43 = default;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			bool flag9 = (nint)obj33 < 4;
			object obj34 = !flag9;
			obj33++;
			object obj35 = ~obj34;
			object obj36 = ~obj35;
			object obj37 = ((obj36 != null) ? obj32 : obj31);
			float num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCB8]");
			object obj38 = num3 & 0;
			object obj39 = obj40 + obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			object obj41 = obj29 * obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BSL not yet implemented.\"");
			object obj42 = obj43 + obj38;
			object obj44 = obj24 * obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			num4 = (float)obj41 + (float)obj44;
			float x = n.x;
			if (!(n.x < num4))
			{
				x = num4;
			}
			((Vector3*)(nint)n)->x = x;
			float num5 = lo - num4;
			bool flag10 = num5 < 0f;
			bool flag11 = num5 == 0f;
			object obj45 = lo ^ num4;
			object obj46 = lo ^ num5;
			object obj47 = obj45 & obj46;
			bool flag12 = (nint)obj47 < 0;
			bool flag13 = flag10 == flag12;
			object obj48 = !flag11;
			object obj49 = flag13 & obj48;
			object obj50 = ~obj49;
			if (obj50 == null)
			{
				num4 = lo;
			}
			reference = ref *(float*)num4;
		}
		while ((nint)obj33 != 8);
	}

	private unsafe void MeetYou(GillaWounds w, Dismemberment you, KillCam kc)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected VT, but got I4
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected VT, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0114: Expected F4, but got I
		//IL_0133: Expected VT, but got I
		//IL_0144: Expected VT, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_01a2: Expected F4, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unsupported input type for neg.
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between Unknown and I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_0a20: Expected Obj, but got I4
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected VT, but got Unknown
		//IL_0a50: Expected Obj, but got I4
		//IL_0a94: Expected Obj, but got Ref
		//IL_0a9c: Expected Obj, but got Ref
		//IL_042b: Expected Obj, but got I4
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Expected Obj, but got Ref
		//IL_027f: Expected Obj, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got Ref
		//IL_02b4: Expected Obj, but got Ref
		//IL_0471: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected VT, but got I
		//IL_04a6: Expected Obj, but got I
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Ref
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_0c4b: Expected Obj, but got I4
		//IL_080d: Expected Obj, but got I4
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got I4
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected Obj, but got I4
		//IL_0838: Expected VT, but got Obj
		//IL_0838: Expected VT, but got I4
		//IL_0857: Expected VT, but got I4
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected F4, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected Ref, but got Unknown
		//IL_0cbd: Expected Obj, but got I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Invalid comparison between Unknown and F8
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Invalid comparison between Unknown and I4
		//IL_07cc: Expected Obj, but got I4
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_0553: Expected Obj, but got I
		//IL_055e: Expected Obj, but got I4
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I4
		//IL_0c30: Expected Obj, but got I4
		//IL_0584: Expected Obj, but got I4
		//IL_0ab8: Expected VT, but got Obj
		//IL_0ab8: Expected VT, but got I4
		//IL_0ae2: Expected Obj, but got I4
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected Obj, but got I4
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected I4, but got Obj
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected I, but got Obj
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected VT, but got I
		//IL_0658: Expected VT, but got I
		//IL_0668: Expected F4, but got I
		//IL_0682: Expected VT, but got Ref
		//IL_0682: Expected VT, but got Ref
		//IL_06a2: Expected Obj, but got Ref
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected Obj, but got I
		//IL_0b22: Expected Obj, but got I
		//IL_0b32: Expected Obj, but got I
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_0b64: Expected Obj, but got I
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0b9b: Expected Obj, but got I4
		//IL_0cfc: Expected VT, but got Obj
		//IL_0cfc: Expected VT, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got I4
		//IL_0743: Expected VT, but got I4
		//IL_0743: Expected I4, but got Obj
		//IL_0751: Expected Obj, but got Ref
		//IL_075a: Expected F4, but got I4
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CE75C]");
		Enumerator<, > val = (Enumerator<, >)0;
		bool flag = (object)kc == null;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Dismemberment dismemberment = null;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		Enumerator<, > val5 = (Enumerator<, >)0;
		Vector3 at = (Vector3)0;
		KillCam killCam = kc;
		bool torso = false;
		Dismemberment dismemberment2 = you;
		bool head = false;
		Enumerator<, > val6 = (Enumerator<, >)0;
		GillaWounds gillaWounds = w;
		Dismemberment dismemberment3 = you;
		KillCam killCam2 = kc;
		object obj = 109895680;
		if (!flag)
		{
			bool flag2 = (object)kc.head == null;
			val2 = (Enumerator<, >)0;
			dismemberment = null;
			val3 = val4;
			val5 = (Enumerator<, >)0;
			at = (Vector3)0;
			killCam = kc;
			torso = false;
			dismemberment2 = you;
			head = false;
			val6 = (Enumerator<, >)0;
			gillaWounds = w;
			dismemberment3 = you;
			killCam2 = kc;
			obj = 109895680;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				object obj2 = 0;
				Vector3 position = kc.head.position;
				Vector3 foot = Foot;
				Enumerator<, > val7 = default;
				object obj3 = val7 - val7;
				Vector3 vector = Through__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				float num = 0f;
				float num3 = default;
				float num2 = num3 - num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				Vector3 vector2 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				Vector3 vector3 = (Vector3)(-0);
				object obj4 = Through__BackingField * 0;
				float num4 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				float num5 = num4 * 0f;
				float num6 = (float)obj4 + num5;
				float num7 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				float num8 = num7 * 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				num3 = -0;
				val6 = (Enumerator<, >)(num8 + num6);
				val7 = (Enumerator<, >)(0 - Through__BackingField);
				bool flag3 = (int)val6 < 0;
				object obj5 = val6 ^ val6;
				object obj6 = val6 & obj5;
				bool flag4 = (nint)obj6 < 0;
				bool flag5 = flag3 == flag4;
				object obj7 = !flag5;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					Vector3 vector4 = (Vector3)val7;
				}
				else
				{
					Vector3 vector4 = Through__BackingField;
				}
				bool flag6 = flag3 == flag4;
				object obj9 = !flag6;
				object obj10 = ~obj9;
				if (obj10 == null)
				{
					float num9 = num3;
				}
				else
				{
					float num9 = num;
				}
				bool flag7 = flag3 == flag4;
				object obj11 = !flag7;
				object obj12 = ~obj11;
				if (obj12 == null)
				{
					Vector3 vector5 = vector3;
				}
				else
				{
					Vector3 vector5 = vector2;
				}
				bool flag8 = InHeadOrTorso(out head, out torso, out at);
				bool flag9 = !flag8;
				dismemberment2 = (Dismemberment)(&torso);
				gillaWounds = (GillaWounds)(&head);
				if (!flag9)
				{
					object obj13 = torso | head;
					object obj14 = obj13 & 0xFF;
					bool flag10 = obj14 == null;
					bool flag11 = head;
					dismemberment2 = (Dismemberment)(&torso);
					gillaWounds = (GillaWounds)(&head);
					if (!flag10)
					{
						Cut cut = CutOf(w, you);
						object obj15 = val4 & 1;
						bool flag12 = obj15 == null;
						object obj16 = !flag12;
						if (obj16 != null)
						{
							object obj17 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X0_v56+E4]");
							bool flag13 = (nint)0 == 0;
							object obj18 = !flag13;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							NetworkApe.Crushed((Vector3)0, (Vector3)w);
							int num10 = index & 0x7F;
							Vector3 normal = (Vector3)(num10 | (modeMap ? 1 : 0));
							Enumerator<, > val8 = default;
							kc.CutByDoor(normal, (float)val8, 0);
							return;
						}
						bool flag14 = !head;
						flag11 = head;
						dismemberment2 = you;
						gillaWounds = w;
						if (!flag14)
						{
							object obj19 = val4 & 0x100;
							bool flag15 = obj19 == null;
							flag11 = head;
							dismemberment2 = you;
							gillaWounds = w;
							if (!flag15)
							{
								object obj20 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X0_v61+E4]");
								bool flag16 = (nint)0 == 0;
								object obj21 = !flag16;
								Vector3 vector6 = at;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									vector6 = at;
								}
								NetworkApe.Crushed((Vector3)0, (Vector3)w);
								object obj22 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X0_v65+E4]");
								bool flag17 = (nint)0 == 0;
								object obj23 = !flag17;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Vector3 vector7 = HeadOf();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
								object obj24 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								object obj25 = obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v37+A0]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v38+18]");
								object obj28 = 0 * vector6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v38+20]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
								object obj29 = num11 * 0;
								object obj30 = obj27;
								object obj31 = at + obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v68+E4]");
								bool flag18 = (nint)0 == 0;
								object obj32 = !flag18;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								GillaBlast.HeadCrushYou((Vector3)0, (Vector3)w);
								return;
							}
						}
					}
				}
				object obj33 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v30+E4]");
				bool flag19 = (nint)0 == 0;
				object obj34 = !flag19;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj33 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v30+A0]");
				val = (Enumerator<, >)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
				bool flag20 = (nint)0 == 0;
				val2 = (Enumerator<, >)0;
				dismemberment = null;
				val3 = val4;
				val5 = (Enumerator<, >)0;
				killCam = (KillCam)(&at);
				dismemberment3 = you;
				killCam2 = kc;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0540]");
					bool flag11 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0538]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
					Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0).GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
					Vector3 vector5 = (Vector3)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					killCam2 = (KillCam)0;
					val2 = (Enumerator<, >)0;
					dismemberment = null;
					killCam = (KillCam)(&at);
					val7 = val4;
					Enumerator<, > val9 = default;
					val6 = val9;
					val = (Enumerator<, >)17276928;
					dismemberment3 = you;
					float num13 = default;
					IntPtr intPtr = default;
					float num14 = default;
					Vector3 vector8 = default;
					Vector3 vector9 = default;
					object obj46 = default;
					object obj42;
					Enumerator<, > val8;
					while (true)
					{
						gillaWounds = (GillaWounds)((bool*)(flag11 ? 1 : 0))->m_value;
						if (val5.MoveNext())
						{
							object obj35 = val4 & 0xFE;
							if ((nint)obj35 == 2)
							{
								object obj36 = obj2;
								val = (Enumerator<, >)(val4 & 3);
								object obj37 = val - 2;
								bool flag21 = obj37 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v48+E4]");
								obj35 = 0;
								object obj38 = !flag21;
								obj12 = ~obj38;
								dismemberment3 = ((obj12 != null) ? ((Dismemberment)1) : ((Dismemberment)(1 + 1)));
								bool flag22 = obj35 == null;
								object obj39 = !flag22;
								if (obj39 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								NetworkApe.TearYou((ApePart)dismemberment3);
								continue;
							}
							float time = Time.time;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD164]");
							val7 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD164]");
							val6 = (Enumerator<, >)(time - 0);
							bool flag23 = (double)val6 < 0.5;
							val = val4;
							if (flag23)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A4]");
							val = (Enumerator<, >)0;
							if ((object)w == null)
							{
								break;
							}
							nint num12 = (nint)killCam2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v20 (Il2CppClass<KillCam>)+A0]");
							val = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
							vector2 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
							vector3 = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
							num = 0f;
							bool flag24 = w.Hit((Vector3)(&dismemberment), num13, (Vector3)(&val2), out *(GoreSection*)null, out *(Vector3*)intPtr);
							bool flag25 = !flag24;
							killCam = null;
							dismemberment2 = (Dismemberment)(&val2);
							num3 = num14;
							vector = vector5;
							val7 = (Enumerator<, >)vector8;
							val6 = (Enumerator<, >)num13;
							if (!flag25)
							{
								float time2 = Time.time;
								object obj40 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X0_v42+E4]");
								val = (Enumerator<, >)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X0_v42+E4]");
								bool flag26 = (nint)0 == 0;
								object obj41 = !flag26;
								if (obj41 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								NetworkApe.WoundYou((GoreSection)(int)dismemberment, (Vector3)0);
								killCam = null;
								dismemberment2 = (Dismemberment)(&val2);
								num3 = 0f;
								vector = vector5;
								val7 = (Enumerator<, >)vector9;
								val6 = val2;
								dismemberment3 = dismemberment;
							}
							continue;
						}
						val3 = (Enumerator<, >)0;
						val5 = val9;
						obj42 = 0;
						val8 = (Enumerator<, >)(ref val5);
						object obj43 = 0;
						while (true)
						{
							gillaWounds = (GillaWounds)obj;
							((Enumerator<, >*)val8)->Dispose();
							bool flag27 = obj43 == null;
							object obj44 = !flag27;
							if (obj44 == null)
							{
								bool flag28 = (int)val3 == 0;
								object obj45 = !flag28;
								OutOfMemoryException ex = (OutOfMemoryException)val8;
								if (obj45 == null)
								{
									return;
								}
							}
							else
							{
								OutOfMemoryException ex = new OutOfMemoryException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
							if ((nint)gillaWounds == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
								val3 = (Enumerator<, >)1;
								obj43 = obj42;
								val = (Enumerator<, >)1;
								continue;
							}
							if ((nint)gillaWounds != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj43 = obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj42 = obj46;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0B08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return;
					}
					NullReferenceException ex2 = new NullReferenceException();
					val3 = (Enumerator<, >)0;
					val5 = val9;
					obj42 = 0;
					val8 = (Enumerator<, >)(ref val5);
				}
			}
		}
		throw new NullReferenceException();
	}

	private unsafe void MeetDummy(GillaWounds w, GillaDummy d)
	{
		//IL_09ea: Expected Obj, but got I
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected VT, but got Ref
		//IL_0a30: Expected Obj, but got Ref
		//IL_047a: Expected Obj, but got I4
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Ref
		//IL_0050: Expected Obj, but got Ref
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected Obj, but got I
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected VT, but got I
		//IL_04f5: Expected Obj, but got I
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected VT, but got Ref
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Ref
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected VT, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got I4
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected VT, but got Obj
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected VT, but got I4
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected Ref, but got Unknown
		//IL_0cc9: Expected Obj, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Invalid comparison between Unknown and F8
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Invalid comparison between Unknown and I4
		//IL_07f9: Expected Obj, but got I4
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got VT
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got I
		//IL_01e7: Expected F8, but got I
		//IL_01f8: Expected F8, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unsupported input type for neg.
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected VT, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_093c: Invalid comparison between VT and I4
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Invalid comparison between VT and I4
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_05ae: Expected Obj, but got I4
		//IL_0a57: Expected Obj, but got I4
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected Obj, but got I4
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected F8, but got I
		//IL_067f: Expected F8, but got I
		//IL_068f: Expected Obj, but got I
		//IL_06a9: Expected VT, but got Ref
		//IL_06a9: Expected VT, but got Ref
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Ref
		//IL_0a87: Expected Obj, but got I4
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected VT, but got Ref
		//IL_074e: Expected Obj, but got Ref
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected Obj, but got Unknown
		//IL_0ac6: Expected Obj, but got I4
		//IL_0820: Expected Obj, but got I
		//IL_084a: Expected Obj, but got I4
		//IL_076d: Expected VT, but got Ref
		//IL_077b: Expected Obj, but got I4
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Ref
		//IL_0876: Expected VT, but got I4
		//IL_0876: Expected VT, but got I4
		//IL_0895: Expected VT, but got I4
		//IL_08aa: Expected I4, but got Obj
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected VT, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected VT, but got I4
		//IL_03cb: Expected Obj, but got I
		//IL_03f5: Expected Obj, but got I4
		//IL_03fe: Expected Obj, but got I4
		//IL_0ae3: Expected VT, but got I4
		//IL_0ae3: Expected VT, but got I4
		//IL_0b0d: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_0b2b: Expected Obj, but got I
		//IL_0b4d: Expected Obj, but got I
		//IL_0b5d: Expected Obj, but got I
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected Obj, but got Unknown
		//IL_0b8f: Expected Obj, but got I
		//IL_0bb9: Expected Obj, but got I4
		//IL_0d0c: Expected VT, but got Obj
		//IL_0d0c: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		bool flag = InHeadOrTorso(out var head, out var torso, out var at);
		bool flag2 = !flag;
		Enumerator<, > val2 = default;
		Enumerator<, > val = val2;
		Enumerator<, > val3 = (Enumerator<, >)0;
		Vector3 vector = (Vector3)(&head);
		Dismemberment dismemberment = (Dismemberment)(&torso);
		Enumerator<, > val5;
		GoreSection section;
		Enumerator<, > val7 = default;
		Enumerator<, > val8;
		float num = default;
		ref GoreSection reference;
		Enumerator<, > val4;
		Enumerator<, > val6;
		Enumerator<, > val9;
		if (!flag2)
		{
			val4 = (Enumerator<, >)(torso | head);
			object obj2 = val4 & 0xFF;
			bool flag3 = obj2 == null;
			val = val2;
			val3 = (Enumerator<, >)0;
			vector = (Vector3)(&head);
			dismemberment = (Dismemberment)(&torso);
			bool flag4 = head;
			if (!flag3)
			{
				bool flag5 = (object)d == null;
				reference = ref *(GoreSection*)(&at);
				val5 = (Enumerator<, >)0;
				section = (GoreSection)0;
				val6 = val7;
				val8 = (Enumerator<, >)0;
				val3 = (Enumerator<, >)0;
				vector = (Vector3)(&head);
				val9 = (Enumerator<, >)num;
				dismemberment = (Dismemberment)(&torso);
				flag4 = head;
				if (!flag5)
				{
					dismemberment = d.tearing;
					Cut cut = CutOf(w, d.tearing);
					bool flag6 = (object)d.head == null;
					reference = ref *(GoreSection*)(&at);
					val5 = (Enumerator<, >)0;
					section = (GoreSection)0;
					val6 = val7;
					val8 = (Enumerator<, >)0;
					val3 = (Enumerator<, >)0;
					vector = (Vector3)w;
					val9 = (Enumerator<, >)num;
					flag4 = head;
					val4 = (Enumerator<, >)(ref num);
					if (!flag6)
					{
						Vector3 position = d.head.position;
						Vector3 foot = Foot;
						Vector3 vector2 = default;
						object obj3 = vector2 - vector2;
						float num2 = (float)val2 - (float)val2;
						Vector3 vector3 = Through__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
						object obj4 = 0;
						object obj6 = default;
						object obj5 = obj6 - obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
						double num3 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
						double num4 = -0;
						object obj7 = Through__BackingField * obj3;
						float num5 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
						float num6 = num5 * 0f;
						float num7 = (float)obj7 + num6;
						double num8 = (double)obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
						double num9 = num8 * 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
						obj6 = -0;
						val3 = (Enumerator<, >)(num9 + (double)num7);
						Vector3 vector4 = 0 - Through__BackingField;
						bool flag7 = (int)val3 < 0;
						object obj8 = val3 ^ val3;
						object obj9 = val3 & obj8;
						bool flag8 = (nint)obj9 < 0;
						bool flag9 = flag7 == flag8;
						object obj10 = !flag9;
						object obj11 = ~obj10;
						if (obj11 == null)
						{
							Vector3 vector5 = vector4;
						}
						else
						{
							Vector3 vector5 = Through__BackingField;
						}
						bool flag10 = flag7 == flag8;
						object obj12 = !flag10;
						object obj13 = ~obj12;
						if (obj13 == null)
						{
							object obj14 = obj6;
						}
						else
						{
							object obj14 = obj4;
						}
						bool flag11 = flag7 == flag8;
						object obj15 = !flag11;
						object obj16 = ~obj15;
						if (obj16 == null)
						{
							double num10 = num4;
						}
						else
						{
							double num10 = num3;
						}
						object obj17 = val7 & 1;
						bool flag12 = obj17 == null;
						object obj18 = !flag12;
						if (obj18 == null)
						{
							bool flag13 = !head;
							val = (Enumerator<, >)vector4;
							Vector3 vector6 = vector2;
							Enumerator<, > val10 = val7;
							vector = (Vector3)0;
							flag4 = head;
							if (!flag13)
							{
								object obj19 = val7 & 0x100;
								bool flag14 = obj19 == null;
								val = (Enumerator<, >)vector4;
								vector6 = vector2;
								val10 = val7;
								vector = (Vector3)0;
								flag4 = head;
								if (!flag14)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
									object obj20 = 0;
									object obj21 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v59+E4]");
									bool flag15 = (nint)0 == 0;
									object obj22 = !flag15;
									object obj23 = 0;
									if (obj22 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj23 = 0;
									}
									NetworkApe.Crushed((Vector3)0, (Vector3)0);
									object obj24 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X0_v63+E4]");
									bool flag16 = (nint)0 == 0;
									object obj25 = !flag16;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Vector3 vector7 = HeadOf();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									object obj27 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v41+A0]");
									object obj28 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBB70]");
									object obj29 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v42+18]");
									object obj30 = 0 * obj23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X8_v42+20]");
									nint num11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
									object obj31 = num11 * 0;
									object obj32 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v66+E4]");
									bool flag17 = (nint)0 == 0;
									object obj33 = !flag17;
									if (obj33 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									GillaBlast.HeadCrushDummy(d, (Vector3)0, (Vector3)dismemberment);
									return;
								}
							}
							goto IL_0450;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
						object obj34 = 0;
						object obj35 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X0_v54+E4]");
						bool flag18 = (nint)0 == 0;
						object obj36 = !flag18;
						if (obj36 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						NetworkApe.Crushed((Vector3)0, (Vector3)0);
						int num12 = index & 0x7F;
						Vector3 normal = (Vector3)(num12 | (modeMap ? 1 : 0));
						d.CutByDoor(normal, num, (byte)(int)dismemberment);
						return;
					}
				}
				goto IL_090b;
			}
		}
		goto IL_0450;
		IL_0450:
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v26+E4]");
		bool flag19 = (nint)0 == 0;
		object obj38 = !flag19;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj37 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v26+A0]");
		val4 = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
		bool flag20 = (nint)0 == 0;
		reference = ref *(GoreSection*)(&at);
		val5 = (Enumerator<, >)0;
		section = (GoreSection)0;
		val6 = val7;
		val8 = (Enumerator<, >)0;
		val2 = val;
		val9 = (Enumerator<, >)num;
		if (!flag20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0540]");
			Enumerator<, > val10 = (Enumerator<, >)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0538]");
			bool flag4 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
			Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0).GetEnumerator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
			Vector3 vector6 = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			obj = 0;
			reference = ref *(GoreSection*)(&at);
			val5 = (Enumerator<, >)0;
			section = (GoreSection)0;
			val2 = val7;
			Enumerator<, > val11 = default;
			val3 = val11;
			val4 = (Enumerator<, >)17276928;
			float num13 = default;
			ref Vector3 point = default;
			object obj43 = default;
			float num14 = default;
			Enumerator<, > val12 = default;
			object obj48 = default;
			object obj44;
			double num10;
			while (true)
			{
				vector = (Vector3)val10;
				if (val8.MoveNext())
				{
					object obj39 = val7 & 0xFE;
					if ((nint)obj39 == 2)
					{
						if ((object)d != null)
						{
							val4 = (Enumerator<, >)(val7 & 3);
							object obj40 = val4 - 2;
							bool flag21 = obj40 == null;
							object obj41 = !flag21;
							object obj16 = ~obj41;
							ApePart part = ((obj16 != null) ? ((ApePart)1) : ((ApePart)2));
							d.Tear(part);
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
					}
					else
					{
						float time = Time.time;
						val2 = (Enumerator<, >)grazedAt;
						val3 = (Enumerator<, >)(time - grazedAt);
						bool flag22 = (double)val3 < 0.5;
						val4 = val7;
						if (flag22)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A4]");
						val4 = (Enumerator<, >)0;
						if ((object)w != null)
						{
							object obj42 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v22+A0]");
							val4 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
							double num3 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
							double num4 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v5 (System.Collections.Generic.LowLevelDictionary`2<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>+Enumerator<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine…");
							object obj4 = 0;
							bool flag23 = w.Hit((Vector3)(&section), num13, (Vector3)(&val5), out *(GoreSection*)null, out point);
							bool flag24 = !flag23;
							reference = ref *(GoreSection*)null;
							object obj6 = obj43;
							Vector3 vector3 = vector6;
							val2 = (Enumerator<, >)num14;
							val3 = (Enumerator<, >)num13;
							dismemberment = (Dismemberment)(&val5);
							if (!flag24)
							{
								float num15 = (grazedAt = Time.time);
								bool flag25 = (object)d == null;
								reference = ref *(GoreSection*)null;
								obj6 = obj43;
								vector3 = vector6;
								val2 = (Enumerator<, >)num14;
								val3 = (Enumerator<, >)num15;
								vector = (Vector3)(&section);
								dismemberment = (Dismemberment)(&val5);
								if (flag25)
								{
									break;
								}
								d.Wound(section, (Vector3)(&val5));
								reference = ref *(GoreSection*)null;
								obj6 = 0;
								vector3 = vector6;
								val2 = val12;
								val3 = val5;
								dismemberment = (Dismemberment)(&val5);
							}
							continue;
						}
					}
					NullReferenceException ex2 = new NullReferenceException();
					break;
				}
				val6 = (Enumerator<, >)0;
				val8 = val11;
				obj44 = 0;
				num10 = 0.5;
				val9 = (Enumerator<, >)(ref val8);
				object obj45 = 0;
				while (true)
				{
					vector = (Vector3)((bool*)(flag4 ? 1 : 0))->m_value;
					((Enumerator<, >*)val9)->Dispose();
					bool flag26 = obj45 == null;
					object obj46 = !flag26;
					if (obj46 == null)
					{
						bool flag27 = (int)val6 == 0;
						object obj47 = !flag27;
						OutOfMemoryException ex3 = (OutOfMemoryException)val9;
						if (obj47 == null)
						{
							return;
						}
					}
					else
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (vector == (Vector3)(object)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						val6 = (Enumerator<, >)1;
						val4 = (Enumerator<, >)1;
						obj45 = obj44;
						continue;
					}
					if (vector != (Vector3)(object)1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj45 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj44 = obj48;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0B08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			NullReferenceException ex4 = new NullReferenceException();
			val6 = (Enumerator<, >)0;
			val8 = val11;
			obj44 = 0;
			num10 = 0.5;
			val9 = (Enumerator<, >)(ref val8);
		}
		goto IL_090b;
		IL_090b:
		throw new NullReferenceException();
	}

	private unsafe bool InHeadOrTorso(out bool head, out bool torso, out Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I4
		//IL_056f: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Ref, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Ref
		//IL_028f: Expected Obj, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_0551: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got Ref
		//IL_03d5: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I4
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected I4, but got Unknown
		//IL_0316: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		ref bool reference = ref *(bool*)null;
		ref bool reference2 = ref *(bool*)null;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+70]");
		List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+70]");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		ref bool reference3 = ref torso;
		ref bool reference4 = ref head;
		GillaDoor gillaDoor;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+18]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+70]");
				List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list2 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v27+A0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v28+70]");
					list2 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v28+70]");
					bool flag4 = (nint)0 == 0;
					val = (Enumerator<, >)0;
					reference3 = ref torso;
					reference4 = ref head;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v28+70]");
					list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
					if (flag4)
					{
						goto IL_036a;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0568]");
				object obj8 = 0;
				reference3 = ref *(bool*)obj8;
				(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3) tuple = list2.get_Item(0);
				Enumerator<, > val2 = (Enumerator<, >)(tuple >> 32);
				val = val2;
				reference4 = ref *(bool*)null;
			}
			else
			{
				Vector3 foot = Foot;
				val = (Enumerator<, >)0;
				reference3 = ref torso;
				reference4 = ref head;
			}
			ref Vector3 reference5 = ref *(Vector3*)val;
			_ = 0;
			object obj9 = obj;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v28+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v28+A0]");
			list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+70]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0538]");
				gillaDoor = (GillaDoor)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v6 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+70]");
				Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0).GetEnumerator();
				Enumerator<, > val3 = default;
				list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)(&val3);
				while (val3.MoveNext())
				{
				}
				List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list3 = null;
				object obj11 = 0;
				Enumerator<, > val4 = (Enumerator<, >)(ref val3);
				object obj12 = 0;
				object obj13 = 7;
				object obj18 = default;
				while (true)
				{
					reference4 = ref *(bool*)gillaDoor;
					val3.Dispose();
					bool flag6 = obj12 == null;
					object obj14 = !flag6;
					List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list4;
					if (obj14 == null)
					{
						bool flag7 = list3 == null;
						object obj15 = !flag7;
						OutOfMemoryException ex = (OutOfMemoryException)(&val3);
						if (obj15 == null)
						{
							if ((nint)obj13 != 7)
							{
								bool flag8 = obj13 == null;
								object obj16 = !flag8;
								list4 = list3;
								if (obj16 != null)
								{
									goto IL_04f0;
								}
							}
							object obj17 = torso | head;
							bool flag9 = obj17 == null;
							List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list5 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)(!flag9);
							list4 = list5;
							goto IL_04f0;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) == (void*)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						list3 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)1;
						list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)1;
						obj12 = obj11;
					}
					else
					{
						if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4) != (void*)1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj12 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj11 = obj18;
					}
					obj13 = 0;
					continue;
					IL_04f0:
					return (byte)(list4 & 1) != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A0B08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result = default;
				return result;
			}
		}
		goto IL_036a;
		IL_036a:
		gillaDoor = this;
		throw new NullReferenceException();
	}

	private unsafe static Vector3 HeadOf()
	{
		//IL_0010: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I4
		//IL_0592: Expected Obj, but got I
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Ref, but got Unknown
		//IL_04c9: Expected Obj, but got I4
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got I4
		//IL_03c1: Expected Obj, but got I4
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got I4
		//IL_0201: Expected VT, but got Obj
		//IL_0223: Expected Obj, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got I4
		//IL_04fc: Expected Obj, but got I
		//IL_050c: Expected Obj, but got I
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected VT, but got Unknown
		//IL_0243: Expected VT, but got Obj
		//IL_0292: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
		List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+68]");
		bool flag2 = (nint)0 == 0;
		Enumerator<, > val = (Enumerator<, >)0;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val3 = (Enumerator<, >)0;
		Vector3 result2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7178]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+68]");
			Enumerator<, > enumerator = ((List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3, Vector3, float)>)0).GetEnumerator();
			Enumerator<, > val4 = (Enumerator<, >)(ref val2);
			object obj6 = default;
			object obj7 = default;
			Enumerator<, > val6 = default;
			object obj8 = default;
			Enumerator<, > val8;
			object obj9;
			Enumerator<, > val9;
			Enumerator<, > val10 = default;
			List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list3;
			object obj10;
			Enumerator<, > val11;
			object obj11;
			List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list2 = default;
			while (true)
			{
				Enumerator<, > val5;
				Enumerator<, > val7;
				if (val2.MoveNext())
				{
					bool flag3 = list2 == null;
					object obj5 = !flag3;
					val4 = (Enumerator<, >)list2;
					if (obj5 == null)
					{
						val3 = (Enumerator<, >)(obj6 + obj7);
						val5 = (Enumerator<, >)(val6 + obj8);
						val7 = (Enumerator<, >)(val5 * 63);
						val8 = val7;
						obj9 = 4;
						val9 = (Enumerator<, >)list2;
						val2 = val10;
						list3 = null;
						obj10 = 0;
						val11 = (Enumerator<, >)(ref val2);
						list = list2;
						obj11 = 0;
						break;
					}
					continue;
				}
				val8 = (Enumerator<, >)0;
				obj9 = 5;
				val9 = (Enumerator<, >)list2;
				val2 = val10;
				list3 = null;
				obj10 = 0;
				val5 = val6;
				val7 = (Enumerator<, >)list2;
				val3 = (Enumerator<, >)0;
				val11 = (Enumerator<, >)(ref val2);
				list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)val4;
				obj11 = 0;
				break;
			}
			Vector3 result = default;
			object obj14 = default;
			while (true)
			{
				((Enumerator<, >*)val11)->Dispose();
				bool flag4 = obj11 == null;
				object obj12 = !flag4;
				val = val9;
				list2 = list3;
				if (obj12 == null)
				{
					bool flag5 = list3 == null;
					object obj13 = !flag5;
					list2 = list3;
					OutOfMemoryException ex = (OutOfMemoryException)val11;
					list = list3;
					if (obj13 == null)
					{
						break;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
					val9 = val;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				if ((nint)obj4 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list3 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)1;
					val3 = (Enumerator<, >)0;
					list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)1;
					obj11 = obj10;
				}
				else
				{
					if ((nint)obj4 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DF04");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj11 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					list3 = list2;
					obj10 = obj14;
					val3 = (Enumerator<, >)0;
				}
				val8 = val3;
				obj9 = 0;
			}
			if ((nint)obj9 != 5)
			{
				bool flag6 = obj9 == null;
				object obj15 = !flag6;
				result2 = (Vector3)val11;
				if (obj15 != null)
				{
					goto IL_04e7;
				}
			}
			result2 = (Vector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v7 (UnityEngine.Vector3)+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				result2 = (Vector3)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v7 (UnityEngine.Vector3)+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v9+70]");
			list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v9+70]");
			bool flag8 = (nint)0 == 0;
			val = val9;
			list2 = list3;
			val3 = val8;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v24 (System.Collections.Generic.List`1<System.ValueTuple`2<Unity.IL2CPP.Metadata.__Il2CppByteEnum, UnityEngine.Vector3>>)+18]");
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v7 (UnityEngine.Vector3)+E4]");
					bool flag9 = (nint)0 == 0;
					object obj18 = !flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v9+70]");
					List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list4 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj19 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v21+A0]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v22+70]");
						list4 = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v22+70]");
						bool flag10 = (nint)0 == 0;
						val = val9;
						list2 = list3;
						val3 = val8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v22+70]");
						list = (List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)>)0;
						if (flag10)
						{
							goto IL_0354;
						}
					}
					(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3) tuple = list4.get_Item(0);
					result2 = (Vector3)tuple;
				}
				goto IL_04e7;
			}
		}
		goto IL_0354;
		IL_0354:
		throw new NullReferenceException();
		IL_04e7:
		return result2;
	}

	public unsafe static GillaDoor Number(byte code)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Ref
		//IL_01ea: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Ref, but got Unknown
		//IL_03d4: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I4
		//IL_0259: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v8+40]");
		bool flag2 = (nint)0 == 0;
		IntPtr intPtr = default;
		UnityEngine.Object obj5 = (UnityEngine.Object)(nint)intPtr;
		object obj6 = 109895680;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
			obj6 = 0;
			int num = code & 0xFF;
			int num2 = num & 0x7F;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v8+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			int num3 = num >> 7;
			Enumerator<, > val = default;
			obj4 = (object)(&val);
			bool flag5;
			object obj18 = default;
			GillaDoor result2 = default;
			object obj12;
			object obj13;
			object obj14;
			Enumerator<, > val2;
			do
			{
				if (val.MoveNext())
				{
					object obj9 = obj8;
					UnityEngine.Object obj10 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v31+E4]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v31+E4]");
					bool flag3 = (nint)0 == 0;
					object obj11 = !flag3;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = (UnityEngine.Object)null != (UnityEngine.Object)null;
					flag5 = !flag4;
					obj12 = 0;
					continue;
				}
				obj13 = 0;
				obj14 = 0;
				val2 = (Enumerator<, >)(ref val);
				object obj15 = 0;
				while (true)
				{
					UnityEngine.Object result = null;
					obj5 = (UnityEngine.Object)obj6;
					((Enumerator<, >*)val2)->Dispose();
					bool flag6 = obj15 == null;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						bool flag7 = obj13 == null;
						object obj17 = !flag7;
						OutOfMemoryException ex = (OutOfMemoryException)val2;
						if (obj17 == null)
						{
							return (GillaDoor)result;
						}
					}
					else
					{
						OutOfMemoryException ex = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj5 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj13 = 1;
						obj4 = 1;
						obj15 = obj14;
						continue;
					}
					if ((nint)obj5 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj15 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj14 = obj18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
			while (flag5);
			NullReferenceException ex2 = new NullReferenceException();
			obj12 = 0;
			obj13 = 0;
			obj14 = 0;
			val2 = (Enumerator<, >)(ref val);
			obj5 = null;
		}
		throw new NullReferenceException();
	}

	public unsafe static bool OutOfSlabs(Transform thing, Bounds bounds, Rigidbody rb = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_0039: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector3 vector = default;
		Vector3 away;
		return OutOfSlabs(thing, (Bounds)(&vector), rb, out away);
	}

	public unsafe static bool OutOfSlabs(Transform thing, Bounds bounds, Rigidbody rb, out Vector3 away)
	{
		//IL_0937: Expected Obj, but got I
		//IL_0bb3: Expected Obj, but got I
		//IL_0bcb: Expected Obj, but got I
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected F8, but got I
		//IL_0bf3: Expected I, but got Obj
		//IL_0c22: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got I
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected Obj, but got VT
		//IL_0017: Expected I, but got Obj
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got I4
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_0b21: Expected Obj, but got I
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected Ref, but got Unknown
		//IL_0b4c: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_07bc: Expected Obj, but got I4
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_0803: Expected Obj, but got I4
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got I4
		//IL_09cd: Expected Obj, but got I
		//IL_09ff: Expected F4, but got I4
		//IL_08bf: Expected Obj, but got I4
		//IL_0a1d: Expected F8, but got I
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Invalid comparison between F8 and Unknown
		//IL_0a67: Expected F8, but got I
		//IL_0a77: Expected F8, but got I
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected F8, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Invalid comparison between F8 and Unknown
		//IL_01e0: Expected F8, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0216: Expected F8, but got VT
		//IL_0226: Expected F8, but got I
		//IL_0256: Expected F8, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected F8, but got I
		//IL_04f6: Invalid comparison between F8 and I4
		//IL_0509: Expected Obj, but got F8
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_053e: Expected Obj, but got I4
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Ref, but got Unknown
		//IL_0aea: Expected Obj, but got I4
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected F8, but got I
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected VT, but got I4
		//IL_0673: Expected Obj, but got I4
		//IL_0747: Expected Obj, but got I4
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected Obj, but got I4
		//IL_06f2: Expected Obj, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+A0]");
		object obj4 = 0;
		Enumerator<, > val = (Enumerator<, >)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+8]");
		double num = 0.0;
		ref Vector3 reference = ref *(Vector3*)obj4;
		nint num2 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v6+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v3 (Il2CppClass<UnityEngine.Object>)+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		nint num3 = num2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = (nint)obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v4 (Il2CppClass<UnityEngine.Object>)+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+40]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj8 = default;
		UnityEngine.Object obj7 = obj8;
		Enumerator<, > val2 = (Enumerator<, >)0;
		UnityEngine.Object obj9 = (UnityEngine.Object)bounds;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB820]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+40]");
			Enumerator<, > enumerator = ((List<System.__Canon>)0).GetEnumerator();
			Rigidbody rigidbody2 = default;
			Rigidbody rigidbody = rigidbody2;
			Enumerator<, > val3 = default;
			val = val3;
			object obj23 = default;
			object obj25 = default;
			object obj27 = default;
			double num40 = default;
			bool result2 = default;
			object obj34 = default;
			object obj24;
			Enumerator<, > val6;
			while (true)
			{
				double num34;
				double num41;
				bool result;
				object obj30;
				if (val2.MoveNext())
				{
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v36+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj8 == null;
					bool flag5 = !flag4;
					object obj14 = !flag5;
					rigidbody = null;
					if (obj14 != null)
					{
						continue;
					}
					if ((object)obj8 == null)
					{
						break;
					}
					bool blown = ((GillaDoor)obj8).Blown;
					bool flag6 = !blown;
					object obj15 = !flag6;
					rigidbody = null;
					if (obj15 != null)
					{
						continue;
					}
					Vector3 foot = ((GillaDoor)obj8).Foot;
					object obj16 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ X8_v27+A0]");
					object obj17 = 0;
					Vector3 foot2 = ((GillaDoor)obj8).Foot;
					bool isOpen = ((GillaDoor)obj8).IsOpen;
					bool flag7 = !isOpen;
					float num4 = 0f;
					if (!flag7)
					{
						float num5 = ((GillaDoor)obj8).Height();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+AC]");
						num4 = 0f * num5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
					double num6 = 0.0;
					Enumerator<, > val4 = (Enumerator<, >)(num + (double)num4);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+4]");
					double num7 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
					double num8 = num7 + 0.0;
					bool flag8 = num8 < (double)val4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+4]");
					num = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
					double num9 = 0.0;
					rigidbody = null;
					val = val4;
					if (flag8)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+108]");
					num8 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+4]");
					double num10 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
					num = num10 - 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+108]");
					Enumerator<, > val5 = (Enumerator<, >)(val4 + 0);
					bool flag9 = num > (double)val5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
					num9 = 0.0;
					rigidbody = null;
					val = val5;
					if (flag9)
					{
						continue;
					}
					object obj18 = obj8 + 324;
					double num11 = (double)bounds.m_Extents;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
					double num12 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+8]");
					double num13 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+10]");
					num8 = num13 - 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+14C]");
					num = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bounds @ X1 (UnityEngine.Bounds)+14]");
					double num14 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+14C]");
					double num15 = num14 * 0.0;
					double num16 = num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+14C]");
					double num17 = num16 * 0.0;
					num6 = (double)bounds.m_Center - (double)val5;
					val = (Enumerator<, >)obj18;
					double num18 = (double)bounds.m_Extents * (double)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					double num19 = num6 * (double)obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					double num20 = num18 + num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+154]");
					double num21 = 0.0 * 0.5;
					double num22 = num17 + num19;
					num9 = num21 + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					bool flag10 = !(num20 < num9);
					double num23 = num22;
					rigidbody = null;
					if (flag10)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+144]");
					double num24 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28+1C]");
					num17 = num24 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28+18]");
					double num25 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+148]");
					num23 = num25 * 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28+1C]");
					double num26 = 0.0 * num20;
					double num27 = num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+148]");
					double num28 = num27 * 0.0;
					double num29 = num26 - num28;
					num21 = num23 - num17;
					double num30 = (double)bounds.m_Extents * num29;
					num12 = num21 * num12;
					double num31 = num6 * num29;
					double num32 = num8 * num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+150]");
					num20 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					num11 = num30 + num12;
					num6 = num32 + num31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+150]");
					double num33 = 0.0 * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
					num8 = num11 + num33;
					bool flag11 = !(num6 < num8);
					rigidbody = null;
					if (flag11)
					{
						continue;
					}
					bool flag12 = num22 < 0.0;
					object obj19 = num22 ^ num22;
					object obj20 = num22 & obj19;
					bool flag13 = (nint)obj20 < 0;
					bool flag14 = flag12 == flag13;
					object obj21 = !flag14;
					object obj22 = ~obj21;
					num6 = ((obj22 != null) ? 1.0 : (-1.0));
					val = (Enumerator<, >)(val * obj23);
					num34 = num * num6;
					reference = ref *(Vector3*)val;
					bool flag15 = (object)thing == null;
					num8 = -1.0;
					rigidbody = null;
					obj7 = null;
					obj24 = 0;
					val2 = val3;
					val6 = (Enumerator<, >)(ref val2);
					obj9 = null;
					if (flag15)
					{
						goto IL_0859;
					}
					Vector3 position = thing.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+14C]");
					num21 = 0.0;
					double num35 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
					double num36 = num35 + 0.0;
					num12 = (double)obj18 * (double)obj25;
					object obj26 = away * obj27;
					double num37 = num36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [away @ X3 (UnityEngine.Vector3&)+8]");
					num8 = num37 * 0.0;
					double num38 = num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ stack_-B8 (UnityEngine.Object)+14C]");
					num20 = num38 * 0.0;
					num11 = (double)obj26 - num12;
					double num39 = num8 - num20;
					val = (Enumerator<, >)(val + num11);
					num6 += num39;
					thing.position = (Vector3)0;
					object obj28 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X0_v54+E4]");
					bool flag16 = (nint)0 == 0;
					object obj29 = !flag16;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (rigidbody2 != null)
					{
						Vector3 position2 = thing.position;
						bool flag17 = (object)rigidbody2 == null;
						num34 = num40;
						rigidbody = null;
						obj7 = null;
						obj24 = 0;
						val2 = val3;
						val6 = (Enumerator<, >)(ref val2);
						obj9 = null;
						if (flag17)
						{
							goto IL_0867;
						}
						rigidbody2.position = (Vector3)0;
					}
					num41 = num40;
					rigidbody = null;
					obj7 = null;
					obj24 = 0;
					val2 = val3;
					val6 = (Enumerator<, >)(ref val2);
					result = true;
					obj30 = 0;
					goto IL_0b11;
				}
				obj7 = null;
				obj24 = 0;
				val2 = val3;
				val6 = (Enumerator<, >)(ref val2);
				obj30 = 0;
				goto IL_0b6a;
				IL_0b11:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB818]");
				object obj31 = 0;
				obj9 = (UnityEngine.Object)obj31;
				((Enumerator<, >*)val6)->Dispose();
				bool flag18 = obj30 == null;
				object obj32 = !flag18;
				num = num41;
				rigidbody2 = rigidbody;
				if (obj32 == null)
				{
					bool flag19 = (object)obj7 == null;
					object obj33 = !flag19;
					num = num41;
					rigidbody2 = rigidbody;
					OutOfMemoryException ex = (OutOfMemoryException)val6;
					if (obj33 == null)
					{
						return result;
					}
				}
				else
				{
					OutOfMemoryException ex = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				num34 = num;
				rigidbody = rigidbody2;
				goto IL_0859;
				IL_0b6a:
				num41 = num;
				result = false;
				goto IL_0b11;
				IL_0859:
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0867;
				IL_0867:
				NullReferenceException ex3 = new NullReferenceException();
				if ((nint)obj9 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num = num34;
					obj7 = (UnityEngine.Object)1;
					obj30 = obj24;
				}
				else
				{
					if ((nint)obj9 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F9B8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj30 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					num = num34;
					obj24 = obj34;
				}
				goto IL_0b6a;
			}
			NullReferenceException ex4 = new NullReferenceException();
			rigidbody2 = null;
			obj7 = null;
			obj24 = 0;
			val2 = val3;
			val6 = (Enumerator<, >)(ref val2);
			obj9 = null;
		}
		throw new NullReferenceException();
	}

	public unsafe bool Under(Vector3 head, float size, out Vector3 away)
	{
		//IL_0301: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_0378: Expected F4, but got I
		//IL_038d: Unsupported input type for neg.
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected VT, but got Unknown
		//IL_03a3: Expected F4, but got I
		//IL_03ac: Invalid comparison between F4 and I4
		//IL_03bf: Expected Obj, but got F4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_042e: Expected Obj, but got I4
		//IL_0069: Expected F4, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_008b: Expected F4, but got I
		//IL_0482: Expected F4, but got VT
		//IL_047d: Expected native int or pointer, but got VT
		//IL_048a: Expected native int or pointer, but got VT
		//IL_0497: Expected native int or pointer, but got VT
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_026f: Invalid comparison between Obj and F4
		//IL_02de: Invalid comparison between F4 and I4
		Vector3 foot = Foot;
		float num = size - size;
		object obj2 = default;
		object obj = obj2 - obj2;
		object obj4 = default;
		object obj3 = obj4 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj5 = 0;
		float num2 = num * (float)Through__BackingField;
		float num3 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		float num4 = num3 * 0f;
		float num5 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		float num6 = num5 * 0f;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+A0]");
		object obj7 = 0;
		float num7 = num2 + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		float num8 = -0;
		float num9 = num6 + num7;
		Vector3 vector = 0 - Through__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		float num10 = -0;
		bool flag = num9 < 0f;
		object obj8 = num9 ^ num9;
		object obj9 = num9 & obj8;
		bool flag2 = (nint)obj9 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		bool flag3 = flag == flag2;
		object obj10 = !flag3;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			vector = Through__BackingField;
		}
		bool flag4 = flag == flag2;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		float y;
		if (obj13 == null)
		{
			y = num8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
			y = 0f;
		}
		bool flag5 = flag == flag2;
		object obj14 = !flag5;
		object obj15 = ~obj14;
		float z;
		if (obj15 == null)
		{
			z = num10;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
			z = 0f;
		}
		((Vector3*)(nint)head)->x = (float)vector;
		((Vector3*)(nint)head)->y = y;
		((Vector3*)(nint)head)->z = z;
		double num11 = (double)Thickness__BackingField * 0.5;
		double num12 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		double num13 = num12 + 0.0;
		if (!((double)num9 < num13))
		{
			goto IL_0286;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+20]");
		object obj16 = 0 * Through__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+18]");
		float num14 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		float num15 = num14 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+1C]");
		float num16 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
		float num17 = num16 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+20]");
		float num18 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		float num19 = num18 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+18]");
		float num20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
		float num21 = num20 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+1C]");
		object obj17 = 0 * Through__BackingField;
		float num22 = (float)obj16 - num15;
		float num23 = num17 - num19;
		float num24 = num21 - (float)obj17;
		float num25 = num * num23;
		float num26 = (float)obj * num22;
		float num27 = (float)obj3 * num24;
		float num28 = num25 + num26;
		float num29 = num27 + num28;
		double num30 = (double)Width__BackingField * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		bool flag6 = !((double)num29 < num30);
		bool result = false;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			bool flag7 = (nint)obj <= 0;
			result = false;
			if (!flag7)
			{
				float num31 = Height();
				float num32 = rise * num31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
				object obj19 = default;
				object obj18 = obj19 * 0;
				object obj20 = obj18 + obj;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num32))
				{
					goto IL_0286;
				}
				float num33 = Height();
				float num34 = rise * num33;
				float num35 = num34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
				float num36 = num35 + 0f;
				float num37 = (float)obj - num36;
				bool flag8 = num37 < 0f;
				result = flag8;
			}
		}
		goto IL_04e8;
		IL_04e8:
		return result;
		IL_0286:
		result = false;
		goto IL_04e8;
	}

	private float Height()
	{
		//IL_0098: Invalid comparison between F4 and I4
		//IL_00a7: Expected F8, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		if (~(prying ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float prySeconds = PrySeconds;
			float t = open * prySeconds;
			return PryCurve(t);
		}
		bool flag2 = open < 0f;
		double num = 0.0;
		if (!flag2)
		{
			bool flag3 = !((double)open > 1.0);
			num = open;
			if (!flag3)
			{
				num = 1.0;
			}
		}
		double num2 = num + num;
		double num3 = num * 3.0;
		double num4 = num * num2;
		double num5 = num * num4;
		double num6 = num * num3;
		double num7 = num6 - num5;
		double num8 = 1.0 - num7;
		double num9 = num8 * 0.0;
		return (float)num7 + (float)num9;
	}

	private void Place()
	{
		//IL_0015: Expected VT, but got I4
		//IL_0034: Expected VT, but got I4
		float num = Height();
		Vector3 vector = Knock();
		panel.localPosition = (Vector3)0;
		Quaternion quaternion = KnockTurn();
		panel.localRotation = (Quaternion)0;
	}

	private void Seam(float c, float up, float kick, float lift, ref ParticleSystem.EmitParams ep)
	{
		//IL_00b4: Expected VT, but got I4
		//IL_00d1: Expected F4, but got I
		//IL_00d1: Expected F4, but got I
		//IL_00f2: Expected F4, but got I
		//IL_00f2: Expected F4, but got I
		//IL_0104: Invalid comparison between F4 and I4
		//IL_0041: Expected F4, but got I
		//IL_0051: Expected F4, but got I
		//IL_013a: Expected VT, but got I4
		//IL_001f: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float value = UnityEngine.Random.value;
		if ((double)value < 0.5)
		{
		}
		Vector3 foot = Foot;
		ep.position = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
		float num2 = UnityEngine.Random.Range(num, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num4 = UnityEngine.Random.Range(num3, 0f);
		float minInclusive;
		float maxInclusive;
		if (lift > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
			minInclusive = 0f;
			maxInclusive = 1.5f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD04]");
			minInclusive = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			maxInclusive = 0f;
		}
		float num5 = UnityEngine.Random.Range(minInclusive, maxInclusive);
		ep.velocity = (Vector3)0;
	}

	private unsafe void PrySparks(float moved, float dt, bool atTop)
	{
		//IL_0010: Expected Obj, but got I
		//IL_056f: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected F4, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_0220: Invalid comparison between F4 and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got F4
		//IL_0276: Expected Obj, but got I4
		//IL_02a3: Expected F4, but got I4
		//IL_05e7: Invalid comparison between F4 and I4
		//IL_045f: Expected Obj, but got I4
		//IL_0850: Expected F4, but got I
		//IL_086e: Expected F4, but got I
		//IL_063a: Invalid comparison between F4 and I4
		//IL_0649: Invalid comparison between F4 and I4
		//IL_0661: Expected Obj, but got F8
		//IL_066e: Expected Obj, but got F4
		//IL_06a3: Expected Obj, but got I4
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_081b: Expected F4, but got I
		//IL_06d0: Invalid comparison between F4 and I4
		//IL_04c9: Expected F4, but got I
		//IL_04c9: Expected F4, but got I
		//IL_04fd: Expected VT, but got Ref
		//IL_0368: Expected F8, but got I4
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_052b: Expected VT, but got I4
		//IL_077f: Expected F4, but got I
		//IL_077f: Expected F4, but got I
		//IL_03bb: Expected F4, but got I
		//IL_03bb: Expected F4, but got I
		//IL_03ef: Expected VT, but got Ref
		//IL_040d: Invalid comparison between F4 and I4
		//IL_041f: Expected VT, but got I4
		//IL_0429: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = prySparks == null;
		bool flag3 = !flag2;
		float num = dt;
		double num2 = moved;
		int num3 = 0;
		ParticleSystem particleSystem = null;
		Color color = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA4C]");
			num = 0f;
			Color warm = default;
			Color cool = default;
			ParticleSystem particleSystem2 = (prySparks = MakeSparks((string)obj4, 450, color, warm, cool));
			object obj5 = this + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = 1.0;
			num3 = 450;
			particleSystem = particleSystem2;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = prySparks == null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num4 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		float num5 = num4 / 0f;
		float num6 = num5 * prySparksPerSpeed;
		float num7 = prySparksPerSecond + num6;
		float num8 = num7 * dt;
		float num9 = pryDue + num8;
		float num10 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num11 = num10 * 0f;
		float num12 = num11 + 1f;
		float num13 = num9 - 40f;
		bool flag7 = num13 < 0f;
		object obj9 = num9 ^ 0x28;
		object obj10 = num9 ^ num13;
		object obj11 = obj9 & obj10;
		bool flag8 = (nint)obj11 < 0;
		bool flag9 = flag7 == flag8;
		object obj12 = !flag9;
		object obj13 = ~obj12;
		float num14 = ((obj13 != null) ? 40f : num9);
		bool flag10 = (double)num12 < 1.0;
		float num15 = (pryDue = num9 - num9);
		float kick = 1f;
		double num16 = num15;
		double num17 = num12;
		if (!flag10)
		{
			bool flag11 = !((double)num12 > 4.5);
			kick = num12;
			num16 = 4.5;
			num17 = num12;
			if (!flag11)
			{
				kick = 4.5f;
				num16 = 4.5;
				num17 = 4.5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		ParticleSystem.EmitParams ep = default;
		if (!(num9 < 1f))
		{
			Color color2 = color;
			object obj20 = default;
			bool flag16;
			do
			{
				float num18 = Height();
				float num19 = rise * num18;
				float num20 = ((!(num19 < top)) ? top : num19);
				float value = UnityEngine.Random.value;
				float value2 = UnityEngine.Random.value;
				float num21 = value * value2;
				float num22 = num21 - 1f;
				bool flag12 = num22 < 0f;
				bool flag13 = num22 == 0f;
				object obj14 = (double)num21 ^ 1.0;
				object obj15 = num21 ^ num22;
				object obj16 = obj14 & obj15;
				bool flag14 = (nint)obj16 < 0;
				bool flag15 = flag12 == flag14;
				object obj17 = !flag15;
				object obj18 = obj17 | flag13;
				object obj19 = ~obj18;
				double num23 = ((obj19 != null) ? 1.0 : ((double)num21));
				double num24 = ((!(num21 < 0f)) ? num23 : 0.0);
				float value3 = UnityEngine.Random.value;
				float num25 = top - num20;
				float num26 = num25 * (float)num24;
				float c = ((!((double)value3 < 0.5)) ? (-1f) : 1f);
				float up = num20 + num26;
				Seam(c, up, kick, 1f, ref ep);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
				float startLifetime = UnityEngine.Random.Range(num27, 0f);
				ep.startLifetime = startLifetime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACA0]");
				nint num28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8AC]");
				float startSize = UnityEngine.Random.Range(num28, 0f);
				ep.startSize = startSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				prySparks.Emit((ParticleSystem.EmitParams)(&obj20), 1);
				num14--;
				flag16 = num14 != 1f;
				color = (Color)0;
				color2 = (Color)0;
			}
			while (flag16);
		}
		if (atTop)
		{
			object obj21 = 40;
			object obj22 = default;
			bool flag17;
			do
			{
				float value4 = UnityEngine.Random.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
				float num29 = UnityEngine.Random.Range(0f, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
				float kick2 = UnityEngine.Random.Range(1f, 0f);
				double num30 = ((!((double)value4 < 0.5)) ? (-1.0) : 1.0);
				float up2 = top - num29;
				Seam((float)num30, up2, kick2, -1f, ref ep);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				float startLifetime2 = UnityEngine.Random.Range(0.5f, 0f);
				ep.startLifetime = startLifetime2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
				nint num31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
				float startSize2 = UnityEngine.Random.Range(num31, 0f);
				ep.startSize = startSize2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				prySparks.Emit((ParticleSystem.EmitParams)(&obj22), 1);
				obj21--;
				flag17 = (nint)obj21 != 1;
				color = (Color)0;
			}
			while (flag17);
		}
	}

	private void BlowOff()
	{
		//IL_0110: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0148: Expected VT, but got Obj
		//IL_0055: Expected Obj, but got VT
		//IL_0072: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00eb: Expected VT, but got I
		//IL_00fb: Expected VT, but got I
		blownShown = true;
		float time = Time.time;
		blownAt = time;
		if ((double)open < 1.0)
		{
			object obj = blowAway * blowAway;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+12C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+12C]");
			object obj2 = num * 0;
			object obj3 = obj + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+130]");
			object obj4 = num2 * 0;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if ((nint)obj5 <= 0)
			{
				Vector3 vector = AwayFromMonster();
			}
			IntPtr intPtr = default;
			Fling((Vector3)(nint)intPtr);
			PlayBlow();
			BlastSparks((Vector3)(nint)intPtr);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v7+A0]");
		object obj8 = 0;
		toldAtRest = false;
		stillSince = 0f;
		blowAway = (Vector3)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+8]");
		_ = 0;
		ShowSlab(on: false);
		moving = false;
		open = 1f;
		Place();
	}

	private void BackIn()
	{
		//IL_00bf: Expected Obj, but got I
		//IL_00ce: Expected I4, but got I8
		//IL_00ee: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I
		//IL_0123: Expected VT, but got Obj
		//IL_0152: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		blownShown = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		heldBy = -1;
		punches = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		object obj3 = obj;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+A0]");
		object obj5 = 0;
		shakeFrom = -1f;
		knockWay = (Vector3)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (flying != null)
		{
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(flying);
		}
		ShowSlab(on: true);
	}

	private void ShowSlab(bool on)
	{
		//IL_0513: Expected Obj, but got I4
		//IL_0240: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I8
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Expected Obj, but got I4
		//IL_0539: Expected Obj, but got I
		//IL_0549: Expected Obj, but got I
		//IL_056b: Expected Obj, but got I4
		//IL_06e4: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I8
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_03ed: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_070b: Expected Obj, but got I4
		//IL_02c9: Expected Obj, but got I4
		//IL_060a: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_0589: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I
		//IL_05b4: Expected I, but got Obj
		//IL_05d2: Expected Obj, but got I
		//IL_05f5: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I
		//IL_0310: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_01eb: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_041c: Expected Obj, but got I4
		//IL_0358: Expected Obj, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I
		//IL_0463: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_0341: Expected I, but got Obj
		//IL_065a: Expected Obj, but got I
		//IL_0674: Expected Obj, but got I
		//IL_0685: Expected I, but got Obj
		//IL_06a3: Expected Obj, but got I
		//IL_06c6: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_01ce: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I
		//IL_0494: Expected I, but got Obj
		Renderer[] array = slabRenderers;
		bool flag = slabRenderers == null;
		object obj = !flag;
		bool flag2 = on;
		nint num = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA360]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0518]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v21+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v21+A0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X9_v11+8]");
			Predicate<System.__Canon> predicate = (Predicate<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X9_v11+8]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v21+E4]");
				bool flag5 = (nint)0 == 0;
				object obj8 = !flag5;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v46+A0]");
					obj6 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04F8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0508]");
				object obj11 = 0;
				Predicate<System.__Canon> predicate2 = default;
				predicate2._002Ector(obj6, (IntPtr)obj11);
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v45+A0]");
				object obj13 = (nint)0 + (nint)8;
				obj13 = predicate2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				predicate = predicate2;
				object obj14 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04F0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37AD38C");
			Renderer[] array2 = default;
			slabRenderers = array2;
			object obj16 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v28+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X9_v9+10]");
			Predicate<System.__Canon> predicate3 = (Predicate<System.__Canon>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X9_v9+10]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v28+E4]");
				bool flag8 = (nint)0 == 0;
				object obj22 = !flag8;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj23 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v38+A0]");
					obj20 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0500]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0510]");
				object obj25 = 0;
				Predicate<System.__Canon> predicate4 = default;
				predicate4._002Ector(obj20, (IntPtr)obj25);
				object obj26 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v37+A0]");
				object obj27 = (nint)0 + (nint)16;
				obj27 = predicate4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				predicate3 = predicate4;
				object obj14 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04E8]");
			object obj28 = 0;
			num = (nint)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37AD38C");
			bool flag9 = default;
			slabColliders = (Collider[])flag9;
			object obj29 = this + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			array = slabRenderers;
			flag2 = flag9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj30 = 0;
		if (array.Length < 1)
		{
			goto IL_0394;
		}
		object obj31 = array.Length & 0xFFFFFFFFL;
		object obj32 = array + 32;
		object obj33 = 0;
		IntPtr intPtr = num;
		bool flag10 = flag2;
		while (true)
		{
			bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj31);
			object obj34 = !flag11;
			if (obj34 != null)
			{
				break;
			}
			object obj35 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v18+E4]");
			bool flag12 = (nint)0 == 0;
			object obj36 = !flag12;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X25_v5+v174 @ X24_v9*8]");
			bool flag13 = (UnityEngine.Object)0 != null;
			bool flag14 = !flag13;
			num = unchecked((nint)null);
			flag2 = false;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X25_v5+v174 @ X24_v9*8]");
				((Renderer)0).enabled = on;
				num = unchecked((nint)null);
				flag2 = on;
			}
			obj31 = array.Length;
			obj33++;
			bool flag15 = (nint)obj33 < array.Length;
			intPtr = num;
			flag10 = flag2;
			if (flag15)
			{
				continue;
			}
			goto IL_0394;
		}
		goto IL_04d8;
		IL_04d8:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0394:
		Collider[] array3 = slabColliders;
		if (array3.Length < 1)
		{
			return;
		}
		object obj37 = array3.Length & 0xFFFFFFFFL;
		object obj38 = array3 + 32;
		object obj39 = 0;
		while (true)
		{
			bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37);
			object obj40 = !flag16;
			if (obj40 != null)
			{
				break;
			}
			object obj41 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v10+E4]");
			bool flag17 = (nint)0 == 0;
			object obj42 = !flag17;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X24_v7+v163 @ X23_v8*8]");
			bool flag18 = (UnityEngine.Object)0 != null;
			bool flag19 = !flag18;
			num = unchecked((nint)null);
			flag2 = false;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X24_v7+v163 @ X23_v8*8]");
				((Collider)0).enabled = on;
				num = unchecked((nint)null);
				flag2 = on;
			}
			obj37 = array3.Length;
			obj39++;
			if ((nint)obj39 >= array3.Length)
			{
				return;
			}
		}
		goto IL_04d8;
	}

	private unsafe Vector3 AwayFromMonster()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c7b: Expected Obj, but got I
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_006d: Expected VT, but got I
		//IL_007d: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected VT, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I4
		//IL_0f19: Expected I, but got Obj
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Ref, but got Unknown
		//IL_0f3c: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I4
		//IL_04f8: Expected Obj, but got I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected I, but got Obj
		//IL_059a: Expected Obj, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected I, but got Obj
		//IL_0db6: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected VT, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected VT, but got Unknown
		//IL_025b: Expected Obj, but got VT
		//IL_0275: Expected Obj, but got VT
		//IL_029c: Expected VT, but got Obj
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Invalid comparison between Unknown and F8
		//IL_02c8: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected I, but got Obj
		//IL_0baf: Expected Obj, but got I4
		//IL_0bb8: Expected Obj, but got I4
		//IL_0a11: Expected Obj, but got I4
		//IL_0a1a: Expected Obj, but got I4
		//IL_0c1f: Expected Obj, but got I4
		//IL_0e95: Expected I, but got Obj
		//IL_0eb8: Expected Obj, but got I4
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected Obj, but got I4
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Expected VT, but got I4
		//IL_0606: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I4
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0367: Expected Obj, but got VT
		//IL_0381: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0406: Expected Obj, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unsupported input type for neg.
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected VT, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Invalid comparison between Unknown and I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_046f: Expected Obj, but got I4
		//IL_066b: Expected Obj, but got I4
		//IL_0d10: Expected Obj, but got I4
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got I4
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected VT, but got I4
		//IL_0a4f: Expected Obj, but got Ref
		//IL_0d40: Expected Obj, but got I4
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected Obj, but got I4
		//IL_0d78: Expected Obj, but got I4
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d93: Expected Obj, but got I4
		//IL_0d9c: Expected Obj, but got I4
		//IL_0ac5: Expected Obj, but got I4
		//IL_0aca: Expected I, but got Obj
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Expected Obj, but got I4
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected VT, but got I4
		//IL_06bb: Expected Obj, but got I4
		//IL_06e1: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I4
		//IL_0756: Expected Obj, but got I4
		//IL_0784: Expected Obj, but got I4
		//IL_0789: Expected I, but got Obj
		//IL_07a8: Expected Obj, but got I
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_07c6: Expected Obj, but got VT
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Invalid comparison between Unknown and I4
		//IL_082f: Expected VT, but got I4
		//IL_0838: Expected Obj, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected VT, but got I4
		//IL_0877: Expected Obj, but got I4
		//IL_0885: Expected Obj, but got I4
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected I, but got Obj
		//IL_089c: Expected VT, but got I4
		//IL_08bb: Expected Obj, but got I
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_08f4: Expected Obj, but got I
		//IL_0911: Expected Obj, but got I
		//IL_0922: Expected Obj, but got I
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected Obj, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Obj, but got Unknown
		//IL_0979: Expected Obj, but got I
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Unsupported input type for neg.
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected VT, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Invalid comparison between Unknown and I4
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected Obj, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_09e2: Expected Obj, but got I4
		//IL_0e26: Expected Obj, but got I4
		//IL_0e56: Expected Obj, but got I4
		//IL_0e76: Expected Obj, but got I4
		//IL_0e7f: Expected Obj, but got I4
		//IL_0e88: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C98]");
		object obj = 0;
		Vector3 foot = Foot;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+A0]");
		UnityEngine.Object obj4 = (UnityEngine.Object)0;
		bool flag2 = (object)obj4 == null;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj6 = default;
		object obj5 = obj6;
		Vector3 vector2 = default;
		Vector3 vector = vector2;
		Enumerator<, > val2 = (Enumerator<, >)0;
		Enumerator<, > val4 = default;
		Enumerator<, > val3 = val4;
		UnityEngine.Object obj7 = (UnityEngine.Object)109895680;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C50]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C48]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
			Vector3 vector3 = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5738]");
			obj7 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5728]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5720]");
			object obj12 = 0;
			Enumerator<, > enumerator = ((List<System.__Canon>)(object)obj4).GetEnumerator();
			vector = vector2;
			Vector3 vector4 = (Vector3)0;
			Enumerator<, > val5 = default;
			val3 = val5;
			object obj13 = 0;
			object obj14 = 0;
			UnityEngine.Object obj15 = default;
			obj4 = obj15;
			Enumerator<, > val7 = default;
			Vector3 result2 = default;
			object obj61 = default;
			while (true)
			{
				UnityEngine.Object obj19;
				UnityEngine.Object obj42;
				object obj43;
				object obj44;
				nint num;
				object obj20;
				Enumerator<, > val6;
				Vector3 vector5;
				object obj26;
				object obj28;
				object obj29;
				object obj41;
				object obj18;
				if (val2.MoveNext())
				{
					object obj16 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v71+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v71+E4]");
					bool flag3 = (nint)0 == 0;
					object obj17 = !flag3;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = obj15 != null;
					bool flag5 = !flag4;
					obj18 = 0;
					if (flag5)
					{
						continue;
					}
					bool flag6 = (object)obj15 == null;
					val = (Enumerator<, >)0;
					obj5 = obj6;
					obj18 = 0;
					obj19 = null;
					obj20 = 0;
					val2 = val5;
					val6 = (Enumerator<, >)(ref val2);
					num = unchecked((nint)null);
					if (flag6)
					{
						goto IL_0b35;
					}
					Transform transform = ((Component)obj15).transform;
					bool flag7 = (object)transform == null;
					val = (Enumerator<, >)0;
					obj5 = obj6;
					obj18 = 0;
					obj19 = null;
					obj20 = 0;
					val2 = val5;
					val6 = (Enumerator<, >)(ref val2);
					num = unchecked((nint)null);
					if (flag7)
					{
						goto IL_0b43;
					}
					Vector3 position = transform.position;
					vector4 = (Vector3)(val3 - val4);
					obj13 = vector - vector2;
					obj14 = obj6 - obj6;
					object obj21 = vector4 * vector4;
					object obj22 = obj13 * obj13;
					object obj23 = obj21 + obj22;
					vector = (Vector3)(obj14 * obj14);
					val3 = (Enumerator<, >)(vector + obj23);
					bool flag8 = !((double)val3 < 16.0);
					obj18 = 0;
					if (flag8)
					{
						continue;
					}
					Transform transform2 = ((Component)obj15).transform;
					bool flag9 = (object)transform2 == null;
					val = (Enumerator<, >)0;
					obj5 = obj6;
					obj18 = 0;
					obj19 = null;
					obj20 = 0;
					val2 = val5;
					val6 = (Enumerator<, >)(ref val2);
					num = unchecked((nint)null);
					if (flag9)
					{
						goto IL_0b5f;
					}
					Vector3 position2 = transform2.position;
					object obj24 = val3 - val4;
					object obj25 = vector - vector2;
					vector5 = Through__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
					obj26 = 0;
					object obj27 = obj6 - obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
					obj29 = -0;
					object obj30 = obj24 * Through__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
					object obj31 = obj25 * 0;
					object obj32 = obj30 + obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
					object obj33 = obj27 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
					obj5 = -0;
					val3 = (Enumerator<, >)(obj33 + obj32);
					vector = 0 - Through__BackingField;
					bool flag10 = (int)val3 < 0;
					object obj34 = val3 ^ val3;
					object obj35 = val3 & obj34;
					bool flag11 = (nint)obj35 < 0;
					bool flag12 = flag10 == flag11;
					object obj36 = !flag12;
					object obj37 = ~obj36;
					if (obj37 == null)
					{
					}
					bool flag13 = flag10 == flag11;
					object obj38 = !flag13;
					object obj39 = ~obj38;
					if (obj39 == null)
					{
					}
					bool flag14 = flag10 == flag11;
					object obj40 = !flag14;
					obj41 = ~obj40;
					if (obj41 == null)
					{
					}
					val = (Enumerator<, >)0;
					obj18 = 0;
					obj42 = null;
					obj20 = 0;
					val2 = val5;
					val6 = (Enumerator<, >)(ref val2);
					obj43 = 6;
					obj44 = 0;
				}
				else
				{
					val = (Enumerator<, >)0;
					obj5 = obj6;
					obj42 = null;
					obj20 = 0;
					val2 = val5;
					val6 = (Enumerator<, >)(ref val2);
					obj43 = 7;
					obj44 = 0;
				}
				goto IL_0f11;
				IL_0b51:
				NullReferenceException ex = new NullReferenceException();
				goto IL_0b5f;
				IL_0f11:
				num = (nint)obj10;
				((Enumerator<, >*)val6)->Dispose();
				bool flag15 = obj44 == null;
				object obj45 = !flag15;
				obj15 = obj42;
				if (obj45 != null)
				{
					goto IL_0b10;
				}
				bool flag16 = (object)obj42 == null;
				object obj46 = !flag16;
				obj15 = obj42;
				OutOfMemoryException ex2 = (OutOfMemoryException)val6;
				obj4 = obj42;
				if (obj46 != null)
				{
					goto IL_0b1e;
				}
				if ((nint)obj43 != 7)
				{
					bool flag17 = obj43 == null;
					object obj47 = !flag17;
					Vector3 result = (Vector3)val6;
					if (obj47 != null)
					{
						return result;
					}
				}
				float x = vector3.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v11 (System.Single)+E4]");
				bool flag18 = (nint)0 == 0;
				object obj48 = !flag18;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					x = vector3.x;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X0_v11 (System.Single)+A0]");
				obj4 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16 (UnityEngine.Object)+8]");
				bool flag19 = (nint)0 == 0;
				obj15 = obj42;
				if (flag19)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16 (UnityEngine.Object)+8]");
				Enumerator<, > enumerator2 = ((List<System.__Canon>)0).GetEnumerator();
				val3 = val7;
				obj4 = obj42;
				while (val.MoveNext())
				{
					object obj49 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X0_v19+E4]");
					obj4 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X0_v19+E4]");
					bool flag20 = (nint)0 == 0;
					object obj50 = !flag20;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag21 = obj42 != null;
					bool flag22 = !flag21;
					obj18 = 0;
					if (flag22)
					{
						continue;
					}
					if ((object)obj42 != null)
					{
						bool isMonster = ((NetworkApe)obj42).IsMonster;
						bool flag23 = !isMonster;
						obj18 = 0;
						if (flag23)
						{
							continue;
						}
						object obj51 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ stack_-D8_v1 (UnityEngine.Object)+68]");
						obj7 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X0_v28+E4]");
						obj4 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X0_v28+E4]");
						bool flag24 = (nint)0 == 0;
						object obj52 = !flag24;
						if (obj52 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag25 = obj7 != null;
						bool flag26 = !flag25;
						obj18 = 0;
						if (flag26)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ stack_-D8_v1 (UnityEngine.Object)+68]");
						bool flag27 = (nint)0 == 0;
						obj18 = 0;
						num = unchecked((nint)null);
						if (!flag27)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ stack_-D8_v1 (UnityEngine.Object)+68]");
							Vector3 position3 = ((Transform)0).position;
							object obj53 = val3 - val4;
							object obj54 = vector - vector2;
							obj5 -= obj6;
							object obj55 = obj53 * obj53;
							object obj56 = obj54 * obj54;
							object obj57 = obj55 + obj56;
							object obj58 = obj5 * obj5;
							val3 = (Enumerator<, >)(obj58 + obj57);
							bool flag28 = (int)val3 >= 1108344832;
							vector = (Vector3)1108344832;
							obj18 = 0;
							if (flag28)
							{
								continue;
							}
							goto IL_0846;
						}
					}
					else
					{
						NullReferenceException ex3 = new NullReferenceException();
						obj18 = 0;
						num = unchecked((nint)null);
					}
					NullReferenceException ex4 = new NullReferenceException();
					val = val7;
					obj15 = null;
					obj20 = 0;
					val6 = (Enumerator<, >)(ref val);
					vector3 = (Vector3)1108344832;
					goto end_IL_0ccd;
				}
				object obj59 = 0;
				obj7 = (UnityEngine.Object)12;
				goto IL_0e8d;
				IL_0e8d:
				num = (nint)obj12;
				val.Dispose();
				bool flag29 = obj59 == null;
				object obj60 = !flag29;
				val = val7;
				obj15 = null;
				obj20 = 0;
				val6 = (Enumerator<, >)(ref val);
				vector3 = (Vector3)1108344832;
				if (obj60 != null)
				{
					goto IL_0b10;
				}
				val = val7;
				obj15 = null;
				obj20 = 0;
				val6 = (Enumerator<, >)(ref val);
				vector3 = (Vector3)1108344832;
				ex2 = (OutOfMemoryException)(&val);
				obj4 = null;
				goto IL_0b1e;
				IL_0b5f:
				NullReferenceException ex5 = new NullReferenceException();
				if (num == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj19 = (UnityEngine.Object)1;
					obj4 = (UnityEngine.Object)1;
					obj44 = obj20;
				}
				else
				{
					if (num != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D7E4");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
						return result2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					obj44 = obj61;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					obj20 = obj61;
				}
				obj42 = obj19;
				obj43 = 0;
				goto IL_0f11;
				IL_0846:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ stack_-D8_v1 (UnityEngine.Object)+68]");
				bool flag30 = (nint)0 == 0;
				val = val7;
				vector = (Vector3)1108344832;
				obj18 = 0;
				obj19 = null;
				obj20 = 0;
				val6 = (Enumerator<, >)(ref val);
				num = unchecked((nint)null);
				vector3 = (Vector3)1108344832;
				if (flag30)
				{
					goto IL_0b51;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ stack_-D8_v1 (UnityEngine.Object)+68]");
				Vector3 position4 = ((Transform)0).position;
				object obj62 = val3 - val4;
				object obj63 = 1108344832 - vector2;
				vector5 = Through__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				obj26 = 0;
				object obj64 = obj5 - obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				obj29 = -0;
				object obj65 = obj62 * Through__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				object obj66 = obj63 * 0;
				object obj67 = obj65 + obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
				object obj68 = obj64 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
				obj5 = -0;
				val3 = (Enumerator<, >)(obj68 + obj67);
				vector = 0 - Through__BackingField;
				bool flag31 = (int)val3 < 0;
				object obj69 = val3 ^ val3;
				object obj70 = val3 & obj69;
				bool flag32 = (nint)obj70 < 0;
				bool flag33 = flag31 == flag32;
				object obj71 = !flag33;
				object obj72 = ~obj71;
				if (obj72 == null)
				{
				}
				bool flag34 = flag31 == flag32;
				object obj73 = !flag34;
				object obj74 = ~obj73;
				if (obj74 == null)
				{
				}
				bool flag35 = flag31 == flag32;
				object obj75 = !flag35;
				obj41 = ~obj75;
				if (obj41 == null)
				{
				}
				obj18 = 0;
				obj59 = 0;
				obj7 = (UnityEngine.Object)6;
				goto IL_0e8d;
				IL_0b35:
				NullReferenceException ex6 = new NullReferenceException();
				goto IL_0b43;
				IL_0b43:
				NullReferenceException ex7 = new NullReferenceException();
				goto IL_0b51;
				IL_0b1e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				obj19 = obj15;
				goto IL_0b35;
				IL_0b10:
				ex2 = new OutOfMemoryException();
				goto IL_0b1e;
				continue;
				end_IL_0ccd:
				break;
			}
		}
		throw new NullReferenceException();
	}

	private void Fling(Vector3 away)
	{
		//IL_0169: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I4
		//IL_0107: Expected VT, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_01f5: Expected VT, but got I4
		Rigidbody rigidbody = MakeLoose();
		object obj2 = default;
		object obj = obj2 * obj2;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		object obj5 = obj3 + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if ((nint)obj5 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
		}
		bool flag2 = (byte)(~(modeMap ? 1u : 0u)) != 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			float num2 = UnityEngine.Random.Range(8f, 11f);
		}
		bool flag3 = (byte)(~(modeMap ? 1u : 0u)) != 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			float num3 = UnityEngine.Random.Range(3f, 4.5f);
		}
		rigidbody.linearVelocity = (Vector3)0;
		bool flag4 = (byte)(~(modeMap ? 1u : 0u)) != 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			float num4 = UnityEngine.Random.Range(4f, 7f);
			if (~(modeMap ? 1u : 0u) != 0)
			{
				Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP2 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		rigidbody.angularVelocity = (Vector3)0;
	}

	private Rigidbody MakeLoose()
	{
		//IL_0010: Expected Obj, but got I
		//IL_15f6: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_029c: Expected VT, but got I4
		//IL_02cb: Expected Obj, but got I
		//IL_0302: Expected Obj, but got I
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_033e: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I
		//IL_161d: Expected Obj, but got I4
		//IL_0455: Expected Obj, but got I8
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_046c: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_037e: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_054c: Expected Obj, but got I
		//IL_1644: Expected Obj, but got I4
		//IL_04a4: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got I4
		//IL_05b2: Expected Obj, but got I8
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_05c9: Expected Obj, but got I4
		//IL_05d2: Expected Obj, but got I4
		//IL_06a9: Expected Obj, but got I
		//IL_166b: Expected Obj, but got I4
		//IL_06e0: Expected Obj, but got I
		//IL_0601: Expected Obj, but got I4
		//IL_062f: Expected Obj, but got I
		//IL_063f: Expected Obj, but got I
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_066c: Expected Obj, but got I4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_07f7: Expected Obj, but got I
		//IL_1692: Expected Obj, but got I4
		//IL_085d: Expected Obj, but got I8
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected Obj, but got Unknown
		//IL_0874: Expected Obj, but got I4
		//IL_087d: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I
		//IL_16b9: Expected Obj, but got I4
		//IL_16d7: Expected Obj, but got I
		//IL_16ef: Expected Obj, but got I
		//IL_0796: Expected Obj, but got I
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got Unknown
		//IL_08ac: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I
		//IL_08da: Expected Obj, but got I
		//IL_08ea: Expected Obj, but got I
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		//IL_0917: Expected Obj, but got I4
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected Obj, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Obj, but got Unknown
		//IL_0aa9: Expected VT, but got I4
		//IL_0ada: Expected Obj, but got I
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got Unknown
		//IL_0b22: Expected Obj, but got I
		//IL_0b7c: Expected VT, but got I4
		//IL_0bd2: Expected VT, but got I4
		//IL_0c05: Expected Obj, but got I4
		//IL_0c50: Expected Obj, but got I
		//IL_1730: Expected Obj, but got I
		//IL_1740: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Expected Obj, but got Unknown
		//IL_1755: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Expected Obj, but got Unknown
		//IL_176a: Unknown result type (might be due to invalid IL or missing references)
		//IL_176f: Expected Obj, but got Unknown
		//IL_177d: Expected VT, but got I4
		//IL_181b: Expected VT, but got I4
		//IL_1878: Expected VT, but got I4
		//IL_0cab: Expected Obj, but got I
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected Obj, but got Unknown
		//IL_0ce5: Expected Obj, but got I8
		//IL_0d12: Expected Obj, but got I
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected Obj, but got Unknown
		//IL_0d54: Expected Obj, but got I4
		//IL_0d6a: Expected Obj, but got I
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected Obj, but got Unknown
		//IL_0dad: Expected Obj, but got I
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0de7: Expected Obj, but got I8
		//IL_0e14: Expected Obj, but got I
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected Obj, but got Unknown
		//IL_0e56: Expected Obj, but got I4
		//IL_0e6c: Expected Obj, but got I
		//IL_0e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Expected Obj, but got Unknown
		//IL_0eaf: Expected Obj, but got I
		//IL_0ebf: Expected Obj, but got I
		//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecd: Expected Obj, but got Unknown
		//IL_0f3a: Expected Obj, but got I4
		//IL_18a7: Expected Obj, but got I4
		//IL_1abf: Expected Obj, but got I
		//IL_1ae1: Expected Obj, but got I4
		//IL_0f92: Expected Obj, but got I
		//IL_190d: Expected Obj, but got I
		//IL_1a55: Expected Obj, but got I4
		//IL_1179: Expected VT, but got I4
		//IL_1179: Expected VT, but got I4
		//IL_1179: Expected VT, but got I4
		//IL_0feb: Expected Obj, but got I
		//IL_11b4: Expected VT, but got I4
		//IL_11bd: Expected VT, but got I4
		//IL_1381: Expected Obj, but got I
		//IL_13ab: Expected Obj, but got I4
		//IL_11df: Expected Obj, but got I8
		//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ed: Expected Obj, but got Unknown
		//IL_11fe: Expected Obj, but got I4
		//IL_1207: Expected VT, but got I4
		//IL_1210: Expected VT, but got I4
		//IL_1a7c: Expected Obj, but got I4
		//IL_105a: Expected Obj, but got I8
		//IL_1063: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Expected Obj, but got Unknown
		//IL_1071: Expected Obj, but got I4
		//IL_107a: Expected Obj, but got I4
		//IL_1406: Expected F4, but got I
		//IL_1423: Expected F4, but got I
		//IL_1423: Expected Obj, but got I4
		//IL_143e: Expected VT, but got I4
		//IL_18ce: Expected Obj, but got I4
		//IL_1472: Expected Obj, but got I
		//IL_14a6: Expected Obj, but got I4
		//IL_123f: Expected Obj, but got I4
		//IL_1271: Expected Obj, but got I
		//IL_128d: Expected VT, but got I4
		//IL_1295: Expected VT, but got Obj
		//IL_10a9: Expected Obj, but got I4
		//IL_1335: Expected Obj, but got I4
		//IL_133e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1343: Expected Obj, but got Unknown
		//IL_10db: Expected Obj, but got I
		//IL_10eb: Expected Obj, but got I
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected Obj, but got Unknown
		//IL_1119: Expected Obj, but got I4
		//IL_1129: Expected Obj, but got I
		//IL_12cd: Expected Obj, but got I4
		//IL_1304: Expected Obj, but got I
		//IL_1316: Expected VT, but got I4
		//IL_1326: Expected VT, but got I
		//IL_1525: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (flying != null)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v199+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(flying);
		}
		if ((object)panel != null)
		{
			GameObject gameObject = panel.gameObject;
			if ((object)panel != null)
			{
				Vector3 position = panel.position;
				if ((object)panel != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5370]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04B0]");
					object obj7 = 0;
					Quaternion rotation = panel.rotation;
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DDC9C");
					GameObject gameObject2 = default;
					flying = gameObject2;
					object obj10 = this + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					string text = name;
					string text2 = text + (string)obj7;
					if ((object)flying != null)
					{
						flying.name = text2;
						if ((object)flying != null)
						{
							Transform transform = flying.transform;
							if ((object)panel != null)
							{
								Vector3 lossyScale = panel.lossyScale;
								if ((object)transform != null)
								{
									transform.localScale = (Vector3)0;
									if ((object)flying != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49E8]");
										object obj11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
										object obj12 = default;
										if (obj12 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v31+18]");
											object obj13 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v31+18]");
											if ((nint)0 < (nint)1)
											{
												goto IL_03c0;
											}
											object obj14 = obj12 + 32;
											object obj15 = 0;
											while (true)
											{
												bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
												object obj16 = !flag4;
												if (obj16 != null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X22_v40+v464 @ X21_v24*8]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X22_v40+v464 @ X21_v24*8]");
													((Renderer)0).enabled = true;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v31+18]");
													obj13 = 0;
													obj15++;
													object obj17 = obj15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v31+18]");
													if ((nint)obj17 < 0)
													{
														continue;
													}
													goto IL_03c0;
												}
												goto IL_15be;
											}
											goto IL_15b0;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_15be;
		IL_15b0:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_15be;
		IL_1371:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X0_v112+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isPlaying = Application.isPlaying;
		bool flag6 = !isPlaying;
		double num2;
		float num = (float)num2;
		BoxCollider boxCollider = default;
		Collider[] array;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			num = 0f;
			bool flag7 = isPlaying;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			IEnumerator routine = ((GillaDoor)flag7).Unignore(boxCollider, array, 0f);
			Coroutine coroutine = StartCoroutine(routine);
			Quaternion quaternion = (Quaternion)0;
		}
		int mask;
		if ((object)flying != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0100]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v81+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj24 = default;
			bool flag9 = obj24 == null;
			bool flag10 = !flag9;
			UnityEngine.Object obj25 = obj24;
			if (!flag10)
			{
				if ((object)flying == null)
				{
					goto IL_15be;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E00]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				UnityEngine.Object obj27 = default;
				obj25 = obj27;
			}
			if ((object)obj25 != null)
			{
				((Rigidbody)obj25).isKinematic = false;
				((Rigidbody)obj25).useGravity = true;
				LayerMask excludeLayers = mask;
				((Rigidbody)obj25).excludeLayers = excludeLayers;
				((Rigidbody)obj25).mass = 150f;
				((Rigidbody)obj25).interpolation = (RigidbodyInterpolation)1;
				((Rigidbody)obj25).collisionDetectionMode = (CollisionDetectionMode)2;
				return (Rigidbody)obj25;
			}
		}
		goto IL_15be;
		IL_03c0:
		if ((object)flying != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4618]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj29 = default;
			if (obj29 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v36+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_051d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v36+18]");
				object obj30 = 0 & 0xFFFFFFFFL;
				object obj31 = obj29 + 32;
				object obj32 = 0;
				object obj33 = 1;
				while (true)
				{
					bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30);
					object obj34 = !flag11;
					if (obj34 != null)
					{
						break;
					}
					object obj35 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X0_v191+E4]");
					bool flag12 = (nint)0 == 0;
					object obj36 = !flag12;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X23_v16+v927 @ X22_v38*8]");
					UnityEngine.Object.Destroy((UnityEngine.Object)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v36+18]");
					obj30 = 0;
					obj32++;
					object obj37 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v36+18]");
					bool flag13 = (nint)obj37 < 0;
					obj33 = 0;
					if (flag13)
					{
						continue;
					}
					goto IL_051d;
				}
				goto IL_15b0;
			}
		}
		goto IL_15be;
		IL_051d:
		if ((object)flying != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4608]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj39 = default;
			if (obj39 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v39+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_067a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v39+18]");
				object obj40 = 0 & 0xFFFFFFFFL;
				object obj41 = obj39 + 32;
				object obj42 = 0;
				object obj43 = 1;
				while (true)
				{
					bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj40);
					object obj44 = !flag14;
					if (obj44 != null)
					{
						break;
					}
					object obj45 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X0_v186+E4]");
					bool flag15 = (nint)0 == 0;
					object obj46 = !flag15;
					if (obj46 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X23_v15+v928 @ X22_v35*8]");
					UnityEngine.Object.Destroy((UnityEngine.Object)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v39+18]");
					obj40 = 0;
					obj42++;
					object obj47 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v39+18]");
					bool flag16 = (nint)obj47 < 0;
					obj43 = 0;
					if (flag16)
					{
						continue;
					}
					goto IL_067a;
				}
				goto IL_15b0;
			}
		}
		goto IL_15be;
		IL_1137:
		Vector3 foot = Foot;
		object obj49;
		object obj48 = obj49;
		float num3 = top;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
		float num4 = num3 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v69+A0]");
		object obj50 = 0;
		float num5 = top;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float num6 = num5 + 0f;
		float num7 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
		float num8 = num7 + 0f;
		double num9 = (double)Thickness__BackingField * 0.5;
		float num10 = seam;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num11 = num10 + 0f;
		double num12 = (double)num6 * 0.5;
		double num13 = (double)num8 * 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v70+18]");
		double num14 = 0.0 * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v70+1C]");
		double num15 = 0.0 * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v70+20]");
		double num16 = 0.0 * num13;
		float num17;
		num2 = (double)num17 + num14;
		float num19;
		double num18 = (double)num19 + num15;
		double num20 = num9 + 0.5;
		float num22;
		double num21 = (double)num22 + num16;
		Vector3 forward = default;
		Vector3 upwards = default;
		Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward, ref upwards);
		object obj52;
		object obj51 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X0_v107+E4]");
		bool flag17 = (nint)0 == 0;
		object obj53 = !flag17;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num23 = ~mask;
		int num24 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		array = Physics.OverlapBox((Vector3)num23, (Vector3)1, (Quaternion)0, num24, queryTriggerInteraction);
		if (array != null)
		{
			bool flag18 = array.Length < 1;
			Quaternion quaternion = (Quaternion)0;
			Vector3 vector = (Vector3)1;
			if (flag18)
			{
				goto IL_1371;
			}
			object obj54 = array.Length & 0xFFFFFFFFL;
			object obj55 = array + 32;
			int num25 = num24;
			object obj56 = 0;
			Quaternion quaternion3 = (Quaternion)0;
			Vector3 vector2 = (Vector3)1;
			while (true)
			{
				bool flag19 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54);
				object obj57 = !flag19;
				if (obj57 != null)
				{
					break;
				}
				object obj58 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1500 @ X0_v141+E4]");
				bool flag20 = (nint)0 == 0;
				object obj59 = !flag20;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X26_v7+v855 @ X25_v7*8]");
				bool flag21 = (UnityEngine.Object)0 != boxCollider;
				bool flag22 = !flag21;
				quaternion = (Quaternion)0;
				vector = (Vector3)boxCollider;
				if (!flag22)
				{
					object obj60 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ X0_v146+E4]");
					bool flag23 = (nint)0 == 0;
					object obj61 = !flag23;
					if (obj61 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X26_v7+v855 @ X25_v7*8]");
					Physics.IgnoreCollision(boxCollider, (Collider)0, ignore: true);
					num25 = 0;
					quaternion = (Quaternion)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X26_v7+v855 @ X25_v7*8]");
					vector = (Vector3)0;
				}
				obj54 = array.Length;
				obj56++;
				bool flag24 = (nint)obj56 < array.Length;
				quaternion3 = quaternion;
				vector2 = vector;
				if (flag24)
				{
					continue;
				}
				goto IL_1371;
			}
			goto IL_15b0;
		}
		goto IL_15be;
		IL_0925:
		if ((object)flying != null)
		{
			Transform transform2 = flying.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			obj49 = 0;
			object obj62 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v32+A0]");
			object obj63 = 0;
			float num26 = Height();
			if ((object)flying != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
				object obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				Vector3 foot2 = Foot;
				Vector3 foot3 = Foot;
				Vector3 foot4 = Foot;
				if ((object)panel != null)
				{
					Vector3 position2 = panel.position;
					Vector3 foot5 = Foot;
					if ((object)transform2 != null)
					{
						float num27 = top - top;
						object obj66 = default;
						object obj65 = obj66 - obj66;
						object obj68 = default;
						object obj67 = obj68 - obj68;
						float num28 = num27 * (float)Through__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
						object obj69 = obj65 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
						object obj70 = obj67 * 0;
						float num29 = num28 + (float)obj69;
						float num30 = (float)obj70 + num29;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
						float num31 = 0f * num30;
						Vector3 vector3 = transform2.InverseTransformPoint((Vector3)0);
						if ((object)boxCollider != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Vector3 vector4 = Through__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v33+1C]");
							object obj72 = vector4 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v33+18]");
							nint num32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
							object obj73 = num32 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v33+1C]");
							float num33 = 0f * top;
							float num34 = num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
							float num35 = num34 * 0f;
							object obj74 = obj73 - obj72;
							float num36 = num33 - num35;
							boxCollider.center = (Vector3)0;
							float num37 = seam + seam;
							float num38 = num37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AAA0]");
							float num39 = num38 + 0f;
							object obj75 = default;
							float num40 = num36 * (float)obj75;
							float num41 = (float)obj74 * num39;
							Vector3 vector5 = transform2.InverseTransformVector((Vector3)0);
							object obj76 = obj71;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ X0_v68+E4]");
							bool flag25 = (nint)0 == 0;
							object obj77 = !flag25;
							if (obj77 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
							object obj78 = 0;
							object obj79 = obj49;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X8_v43+A0]");
							object obj80 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v44+20]");
							object obj81 = obj68 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v44+18]");
							object obj82 = obj68 * 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X8_v44+1C]");
							object obj83 = obj68 * 0;
							Vector3 vector6 = transform2.InverseTransformVector((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							object obj84 = obj66 + obj82;
							object obj86 = default;
							object obj85 = obj86 + obj83;
							float num42 = (float)Through__BackingField * Thickness__BackingField;
							float num43 = num40 + (float)obj81;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+148]");
							float num44 = 0f * Thickness__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaDoor)+14C]");
							float num45 = 0f * Thickness__BackingField;
							Vector3 vector7 = transform2.InverseTransformVector((Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
							num17 = (float)obj84 + num42;
							num19 = (float)obj85 + num44;
							num22 = num43 + num45;
							boxCollider.size = (Vector3)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							string[] array2 = default;
							if (array2 != null)
							{
								if (array2.Length != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5A8]");
									object obj87 = 0;
									object obj88 = array2 + 32;
									obj88 = obj87;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X22_v15-8]");
									object obj89 = 0 & 0xFFFFFFFEL;
									if (obj89 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F18]");
										object obj90 = 0;
										object obj91 = array2 + 40;
										obj91 = obj90;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X22_v17-10]");
										bool flag26 = (nint)0 < (nint)2;
										object obj92 = !flag26;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X22_v17-10]");
										object obj93 = -2;
										bool flag27 = obj93 == null;
										object obj94 = ~obj92;
										object obj95 = obj94 | flag27;
										if (obj95 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F20]");
											object obj96 = 0;
											object obj97 = array2 + 48;
											obj97 = obj96;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X22_v19-18]");
											object obj98 = 0 & 0xFFFFFFFCL;
											if (obj98 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5C0]");
												object obj99 = 0;
												object obj100 = array2 + 56;
												obj100 = obj99;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X22_v21-20]");
												bool flag28 = (nint)0 < (nint)4;
												object obj101 = !flag28;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X22_v21-20]");
												object obj102 = -4;
												bool flag29 = obj102 == null;
												object obj103 = ~obj101;
												object obj104 = obj103 | flag29;
												if (obj104 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC5B0]");
													object obj105 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
													object obj106 = 0;
													object obj107 = array2 + 64;
													obj107 = obj105;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													mask = LayerMask.GetMask(array2);
													LayerMask excludeLayers2 = mask;
													boxCollider.excludeLayers = excludeLayers2;
													object obj108 = obj106;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X0_v93+E4]");
													bool flag30 = (nint)0 == 0;
													object obj109 = !flag30;
													if (obj109 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													object obj110 = obj106;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X0_v97+E4]");
													bool flag31 = (nint)0 == 0;
													object obj111 = !flag31;
													if (obj111 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														obj110 = obj106;
													}
													object obj112 = obj;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X0_v97+A0]");
													object obj113 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v64+E4]");
													bool flag32 = (nint)0 == 0;
													object obj114 = !flag32;
													if (obj114 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
													obj52 = 0;
													if (!((UnityEngine.Object)obj113 != null))
													{
														goto IL_1137;
													}
													if (obj113 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
														object obj115 = 0;
														object obj116 = obj115;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
														object obj117 = default;
														if (obj117 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v156+18]");
															if ((nint)0 < (nint)1)
															{
																goto IL_1137;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v156+18]");
															object obj118 = 0 & 0xFFFFFFFFL;
															object obj119 = obj117 + 32;
															object obj120 = 0;
															Collider collider = (Collider)1;
															while (true)
															{
																bool flag33 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj120) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj118);
																object obj121 = !flag33;
																if (obj121 != null)
																{
																	break;
																}
																object obj122 = obj52;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X0_v158+E4]");
																bool flag34 = (nint)0 == 0;
																object obj123 = !flag34;
																if (obj123 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X29_v5+v854 @ X28_v6*8]");
																Physics.IgnoreCollision(boxCollider, (Collider)0);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v156+18]");
																obj118 = 0;
																obj120++;
																object obj124 = obj120;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v156+18]");
																bool flag35 = (nint)obj124 < 0;
																obj116 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X29_v5+v854 @ X28_v6*8]");
																collider = (Collider)0;
																if (flag35)
																{
																	continue;
																}
																goto IL_1137;
															}
															goto IL_15b0;
														}
													}
													goto IL_15be;
												}
											}
										}
									}
								}
								goto IL_15b0;
							}
						}
					}
				}
			}
		}
		goto IL_15be;
		IL_07c8:
		if ((object)flying != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC910]");
			object obj125 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj126 = default;
			if (obj126 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v45+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_0925;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v45+18]");
				object obj127 = 0 & 0xFFFFFFFFL;
				object obj128 = obj126 + 32;
				object obj129 = 0;
				object obj130 = 1;
				while (true)
				{
					bool flag36 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj129) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj127);
					object obj131 = !flag36;
					if (obj131 != null)
					{
						break;
					}
					object obj132 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X0_v178+E4]");
					bool flag37 = (nint)0 == 0;
					object obj133 = !flag37;
					if (obj133 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X23_v14+v929 @ X22_v31*8]");
					UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v45+18]");
					obj127 = 0;
					obj129++;
					object obj134 = obj129;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v45+18]");
					bool flag38 = (nint)obj134 < 0;
					obj130 = 0;
					if (flag38)
					{
						continue;
					}
					goto IL_0925;
				}
				goto IL_15b0;
			}
		}
		goto IL_15be;
		IL_15be:
		return (Rigidbody)(object)new NullReferenceException();
		IL_067a:
		if ((object)flying != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B28]");
			object obj135 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3626924");
			object obj136 = default;
			if (obj136 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v42+18]");
				object obj137 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v42+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_07c8;
				}
				object obj138 = obj136 + 32;
				object obj139 = 0;
				while (true)
				{
					bool flag39 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj139) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj137);
					object obj140 = !flag39;
					if (obj140 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X22_v33+v468 @ X21_v17*8]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X22_v33+v468 @ X21_v17*8]");
						GameObject gameObject3 = ((Component)0).gameObject;
						if ((object)gameObject3 != null)
						{
							gameObject3.layer = 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v42+18]");
							obj137 = 0;
							obj139++;
							object obj141 = obj139;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X0_v42+18]");
							if ((nint)obj141 < 0)
							{
								continue;
							}
							goto IL_07c8;
						}
					}
					goto IL_15be;
				}
				goto IL_15b0;
			}
		}
		goto IL_15be;
	}

	private static Vector3 Abs(Vector3 v)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		return v;
	}

	private IEnumerator Unignore(Collider box, Collider[] frame, float after)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0570]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = box;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2 + 48;
		obj4 = frame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private void PlayBlow()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0242: Expected VT, but got I4
		//IL_0252: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_02b0: Expected F4, but got I
		//IL_02b0: Expected F4, but got I
		//IL_033d: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I4
		AudioClip[] array = blowSounds;
		if (blowSounds == null || array.Length == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, array.Length);
		bool flag = num < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = blowSounds + num;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
			if ((UnityEngine.Object)0 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
				string text = ((UnityEngine.Object)0).name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAE0]");
				object obj6 = 0;
				string text2 = (string)obj6 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GameObject gameObject = default;
				gameObject._002Ector(text2);
				if ((object)gameObject != null)
				{
					Transform transform = gameObject.transform;
					Vector3 foot = Foot;
					if ((object)transform != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
						object obj8 = 0;
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v18+A0]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v19+20]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						object obj11 = num2 * 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v19+1C]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						object obj12 = num3 * 0;
						object obj14 = default;
						object obj13 = obj14 + obj11;
						transform.position = (Vector3)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						AudioSource audioSource = default;
						if ((object)audioSource != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
							audioSource.clip = (AudioClip)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD8C]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE30]");
							float pitch = UnityEngine.Random.Range(num4, 0f);
							audioSource.pitch = pitch;
							audioSource.spatialBlend = 1f;
							audioSource.minDistance = 6f;
							audioSource.maxDistance = 60f;
							audioSource.rolloffMode = (AudioRolloffMode)0;
							audioSource.dopplerLevel = 0f;
							audioSource.Play();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+20]");
							float length = ((AudioClip)0).length;
							object obj16 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v36+E4]");
							bool flag3 = (nint)0 == 0;
							object obj17 = !flag3;
							if (obj17 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num5 = length;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
							float t = num5 + 0f;
							UnityEngine.Object.Destroy(gameObject, t);
							return;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private unsafe void BlastSparks(Vector3 away)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_0350: Expected F4, but got I
		//IL_01e7: Expected VT, but got I4
		//IL_0201: Expected F4, but got I
		//IL_0234: Expected F4, but got I
		//IL_0234: Expected F4, but got I
		//IL_026d: Expected VT, but got Ref
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = prySparks == null;
		bool flag3 = !flag2;
		object obj5 = default;
		object obj4 = obj5;
		int num = 0;
		ParticleSystem particleSystem = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D04A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
			obj4 = 0;
			Color hot = default;
			Color warm = default;
			Color cool = default;
			ParticleSystem particleSystem2 = (prySparks = MakeSparks((string)obj6, 450, hot, warm, cool));
			object obj7 = this + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num = 450;
			particleSystem = particleSystem2;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = prySparks == null;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D080");
			object obj11 = 140;
			ParticleSystem.EmitParams ep = default;
			object obj12 = default;
			do
			{
				float value = UnityEngine.Random.value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
				float up = UnityEngine.Random.Range(0f, top);
				float num2 = UnityEngine.Random.Range(1.5f, 4f);
				double num3 = ((!((double)value < 0.5)) ? (-1.0) : 1.0);
				Seam((float)num3, up, num2, 1f, ref ep);
				Vector3 velocity = ep.velocity;
				float num4 = UnityEngine.Random.Range(2f, 6f);
				float num5 = (float)obj5 * num4;
				float num6 = num2 + num5;
				ep.velocity = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD84]");
				float startLifetime = UnityEngine.Random.Range(0.5f, 0f);
				ep.startLifetime = startLifetime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE60]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD8]");
				float startSize = UnityEngine.Random.Range(num7, 0f);
				ep.startSize = startSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				prySparks.Emit((ParticleSystem.EmitParams)(&obj12), 1);
				obj11--;
			}
			while ((nint)obj11 != 1);
		}
	}

	private unsafe ParticleSystem MakeSparks(string name, int max, Color hot, Color warm, Color cool)
	{
		//IL_0010: Expected Obj, but got I
		//IL_084e: Expected Obj, but got I
		//IL_0870: Expected Obj, but got I4
		//IL_0959: Expected Obj, but got I
		//IL_097b: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_08cb: Expected Obj, but got I
		//IL_08ed: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I4
		//IL_0894: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_02be: Expected VT, but got Ref
		//IL_02d4: Expected F4, but got I
		//IL_02e5: Expected VT, but got Ref
		//IL_0367: Expected Obj, but got I
		//IL_038f: Expected Obj, but got I
		//IL_03b0: Expected VT, but got I4
		//IL_03f4: Expected Obj, but got Ref
		//IL_0419: Expected VT, but got I4
		//IL_042d: Expected Obj, but got I8
		//IL_0468: Expected VT, but got I4
		//IL_0484: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04d7: Expected Obj, but got I
		//IL_0579: Expected Obj, but got I8
		//IL_05e9: Expected VT, but got Ref
		//IL_0631: Expected F4, but got I
		//IL_065d: Expected VT, but got Ref
		//IL_06b1: Expected I4, but got I8
		//IL_06d8: Expected F4, but got I
		//IL_06e9: Expected VT, but got Ref
		//IL_06ff: Expected F4, but got I
		//IL_0710: Expected VT, but got Ref
		//IL_0726: Expected F4, but got I
		//IL_0737: Expected VT, but got Ref
		//IL_074c: Expected Obj, but got I
		//IL_0796: Expected F4, but got I
		//IL_07b0: Expected F4, but got I
		//IL_07da: Expected Obj, but got I4
		//IL_090b: Expected Obj, but got I
		//IL_0920: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v1+58]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		UnityEngine.Object obj8 = null;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5C30]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v48+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v48+A0]");
			object obj13 = (nint)0 + (nint)88;
			UnityEngine.Object obj14 = default;
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj8 = obj14;
		}
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v3+58]");
		bool flag8 = (UnityEngine.Object)0 == null;
		bool flag9 = !flag8;
		object obj20 = !flag9;
		ParticleSystem result = null;
		if (obj20 != null)
		{
			goto IL_0815;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(name);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			Transform parent = base.transform;
			if ((object)transform != null)
			{
				transform.SetParent(parent, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				ParticleSystem particleSystem = default;
				if ((object)particleSystem != null)
				{
					particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)0);
					ParticleSystem.MainModule main = particleSystem.main;
					ParticleSystem.MainModule mainModule = default;
					mainModule.playOnAwake = false;
					mainModule.simulationSpace = (ParticleSystemSimulationSpace)1;
					ParticleSystem.MinMaxCurve minMaxCurve = 0f;
					object obj23 = default;
					mainModule.startSpeed = (ParticleSystem.MinMaxCurve)(&obj23);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE6C]");
					ParticleSystem.MinMaxCurve minMaxCurve2 = 0f;
					object obj24 = default;
					mainModule.gravityModifier = (ParticleSystem.MinMaxCurve)(&obj24);
					mainModule.maxParticles = max;
					ParticleSystem.EmissionModule emission = particleSystem.emission;
					ParticleSystem.EmissionModule emissionModule = default;
					emissionModule.enabled = false;
					ParticleSystem.ShapeModule shape = particleSystem.shape;
					ParticleSystem.ShapeModule shapeModule = default;
					shapeModule.enabled = false;
					ParticleSystem.ColorOverLifetimeModule colorOverLifetime = particleSystem.colorOverLifetime;
					ParticleSystem.ColorOverLifetimeModule colorOverLifetimeModule = default;
					colorOverLifetimeModule.enabled = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54A0]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Gradient gradient = default;
					gradient._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5498]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					float time = default;
					GradientColorKey gradientColorKey = new GradientColorKey((Color)0, time);
					GradientColorKey[] array = default;
					if (array != null)
					{
						if (array.Length != 0)
						{
							GradientColorKey gradientColorKey2 = default;
							object obj27 = (object)(&gradientColorKey2);
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X23_v6+30]");
							_ = 0;
							float time2 = default;
							GradientColorKey gradientColorKey3 = new GradientColorKey((Color)0, time2);
							object obj28 = array.Length & 0xFFFFFFFEL;
							if (obj28 != null)
							{
								_ = 0;
								_ = 0;
								float time3 = default;
								gradientColorKey2 = new GradientColorKey((Color)0, time3);
								bool flag10 = array.Length < 2;
								object obj29 = !flag10;
								object obj30 = array.Length - 2;
								bool flag11 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag11;
								if (obj32 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5490]");
									object obj33 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									GradientAlphaKey gradientAlphaKey = new GradientAlphaKey(1f, 0f);
									GradientAlphaKey[] array2 = default;
									if (array2 == null)
									{
										goto IL_081a;
									}
									if (array2.Length != 0)
									{
										_ = 0;
										GradientAlphaKey gradientAlphaKey2 = new GradientAlphaKey(1f, 1f);
										object obj34 = array2.Length & 0xFFFFFFFEL;
										if (obj34 != null)
										{
											_ = 0;
											if ((object)gradient != null)
											{
												gradient.SetKeys(array, array2);
												ParticleSystem.MinMaxGradient minMaxGradient = gradient;
												object obj35 = default;
												colorOverLifetimeModule.color = (ParticleSystem.MinMaxGradient)(&obj35);
												ParticleSystem.SizeOverLifetimeModule sizeOverLifetime = particleSystem.sizeOverLifetime;
												ParticleSystem.SizeOverLifetimeModule sizeOverLifetimeModule = default;
												sizeOverLifetimeModule.enabled = true;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
												AnimationCurve curve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
												ParticleSystem.MinMaxCurve minMaxCurve3 = new ParticleSystem.MinMaxCurve(1f, curve);
												object obj36 = default;
												sizeOverLifetimeModule.size = (ParticleSystem.MinMaxCurve)(&obj36);
												ParticleSystem.CollisionModule collision = particleSystem.collision;
												ParticleSystem.CollisionModule collisionModule = default;
												collisionModule.enabled = true;
												collisionModule.type = (ParticleSystemCollisionType)1;
												collisionModule.quality = (ParticleSystemCollisionQuality)2;
												LayerMask collidesWith = -5893;
												collisionModule.collidesWith = collidesWith;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
												ParticleSystem.MinMaxCurve minMaxCurve4 = 0f;
												object obj37 = default;
												collisionModule.bounce = (ParticleSystem.MinMaxCurve)(&obj37);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
												ParticleSystem.MinMaxCurve minMaxCurve5 = 0f;
												object obj38 = default;
												collisionModule.dampen = (ParticleSystem.MinMaxCurve)(&obj38);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
												ParticleSystem.MinMaxCurve minMaxCurve6 = 0f;
												object obj39 = default;
												collisionModule.lifetimeLoss = (ParticleSystem.MinMaxCurve)(&obj39);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CD8]");
												object obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625F3C");
												ParticleSystemRenderer particleSystemRenderer = default;
												if ((object)particleSystemRenderer != null)
												{
													particleSystemRenderer.renderMode = (ParticleSystemRenderMode)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
													particleSystemRenderer.velocityScale = 0f;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
													particleSystemRenderer.lengthScale = 0f;
													object obj41 = obj;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v92+E4]");
													bool flag12 = (nint)0 == 0;
													object obj42 = !flag12;
													if (obj42 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														obj41 = obj;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v92+A0]");
													object obj43 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v43+58]");
													particleSystemRenderer.sharedMaterial = (Material)0;
													particleSystemRenderer.shadowCastingMode = (ShadowCastingMode)0;
													particleSystemRenderer.receiveShadows = false;
													particleSystem.Play();
													result = particleSystem;
													goto IL_0815;
												}
											}
											goto IL_081a;
										}
									}
								}
							}
						}
						goto IL_0828;
					}
				}
			}
		}
		goto IL_081a;
		IL_081a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0828;
		IL_0815:
		return result;
		IL_0828:
		return (ParticleSystem)(object)new IndexOutOfRangeException();
	}

	private void PlayPry()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02dd: Expected Obj, but got I4
		AudioClip[] array = prySounds;
		if (prySounds == null || array.Length == 0)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, array.Length);
		bool flag = num < array.Length;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			object obj3 = prySounds + num;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+20]");
			if ((UnityEngine.Object)0 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+20]");
				string text = ((UnityEngine.Object)0).name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFAE0]");
				object obj6 = 0;
				string text2 = (string)obj6 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				GameObject gameObject = default;
				gameObject._002Ector(text2);
				if ((object)gameObject != null)
				{
					Transform transform = gameObject.transform;
					if ((object)transform != null)
					{
						transform.SetParent(panel, worldPositionStays: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						AudioSource audioSource = default;
						if ((object)audioSource != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+20]");
							audioSource.clip = (AudioClip)0;
							audioSource.spatialBlend = 1f;
							audioSource.minDistance = 4f;
							audioSource.maxDistance = 40f;
							audioSource.rolloffMode = (AudioRolloffMode)0;
							audioSource.dopplerLevel = 0f;
							audioSource.Play();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+20]");
							float length = ((AudioClip)0).length;
							object obj9 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v30+E4]");
							bool flag3 = (nint)0 == 0;
							object obj10 = !flag3;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num2 = length;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
							float t = num2 + 0f;
							UnityEngine.Object.Destroy(gameObject, t);
							return;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public GillaDoor()
	{
		//IL_0015: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_003c: Expected I4, but got I8
		//IL_0051: Expected VT, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_0073: Expected F4, but got I
		//IL_0085: Expected F4, but got I
		//IL_00a2: Expected F4, but got I
		//IL_00b7: Expected VT, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_010c: Expected F4, but got I
		//IL_011c: Expected Obj, but got I
		//IL_013b: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+A0]");
		object obj2 = 0;
		heldBy = -1;
		shakeFrom = -1f;
		shutTurn = (Quaternion)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1E0]");
		rise = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C360]");
		blownResetSeconds = 0f;
		prySparksPerSpeed = 160f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BB50]");
		tall = 0f;
		toldAtRest = true;
		heldRot = (Quaternion)obj3;
		top = 2.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj4 = 0;
		object obj5 = this + 324;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v11+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4F8]");
		Width__BackingField = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v12+48]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v12+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B0F8]");
		workersAt = 0f;
		base._002Ector();
	}

	static GillaDoor()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+A0]");
		object obj4 = 0;
		_ = -1;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
		bool flag = (nint)0 < (nint)1;
		object obj5 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
		object obj6 = -1;
		bool flag2 = obj6 == null;
		object obj7 = ~obj5;
		object obj8 = obj7 | flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+18]");
			bool flag3 = (nint)0 == 2;
			_ = 1020054733;
			if (!flag3)
			{
				object obj9 = obj;
				_ = 1031127695;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v8+A0]");
				object obj10 = (nint)0 + (nint)32;
				object obj11 = default;
				obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+18]");
				bool flag4 = (nint)0 < (nint)1;
				object obj12 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+18]");
				object obj13 = -1;
				bool flag5 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+18]");
					bool flag6 = (nint)0 == 2;
					_ = 1067030938;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB840]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0590]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0598]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C70D8]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0588]");
						object obj20 = 0;
						object obj21 = obj;
						_ = 1077936128;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v10+A0]");
						object obj22 = (nint)0 + (nint)40;
						object obj23 = default;
						obj22 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj24 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v11+A0]");
						object obj25 = 0;
						_ = 3212836864L;
						_ = 4294967295L;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						List<System.__Canon> list = default;
						list._002Ector();
						object obj26 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v13+A0]");
						object obj27 = (nint)0 + (nint)64;
						obj27 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj28 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v14+1C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v14+10]");
						_ = 0;
						object obj29 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v15+A0]");
						object obj30 = (nint)0 + (nint)72;
						object obj31 = default;
						obj30 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj32 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v16+1C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v16+10]");
						_ = 0;
						object obj33 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v17+A0]");
						object obj34 = (nint)0 + (nint)80;
						object obj35 = default;
						obj34 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj36 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v18+A0]");
						object obj37 = 0;
						_ = 3212836864L;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3, Vector3, float)> list2 = default;
						list2._002Ector();
						object obj38 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v20+A0]");
						object obj39 = (nint)0 + (nint)104;
						obj39 = list2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						List<(Unity.IL2CPP.Metadata.__Il2CppByteEnum, Vector3)> list3 = default;
						list3._002Ector();
						object obj40 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v21+A0]");
						object obj41 = (nint)0 + (nint)112;
						obj41 = list3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9F00]");
						object obj42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Dictionary<System.__Canon, System.__Canon> dictionary = default;
						dictionary._002Ector();
						object obj43 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v26+A0]");
						object obj44 = (nint)0 + (nint)120;
						obj44 = dictionary;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						return;
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
