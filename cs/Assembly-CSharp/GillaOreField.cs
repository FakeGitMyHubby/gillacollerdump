using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaOreField : NetworkBehaviour
{
	public const int Most = default(int);

	private static readonly GillaNetWatch.Single<GillaOreField> fields;

	private const int MostHit = default(int);

	private const float HitReach = default(float);

	private const float OnOre = default(float);

	private byte[] _Kinds;

	private byte[] _Damage;

	private float[] _Changed;

	private NetworkBool _Filled;

	private float[] ticks;

	private bool hadAuthority;

	private static float nextTry;

	public static GillaOreField Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0083: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I
			//IL_003c: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
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
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54F0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F864");
				GillaOreField result = default;
				return result;
			}
			return (GillaOreField)(object)new NullReferenceException();
		}
	}

	private unsafe NetworkArray<byte> Kinds
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0035: Expected VT, but got I4
			//IL_0048: Expected native int or pointer, but got VT
			//IL_00a9: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				_ = 0;
				_ = 0;
				NetworkArray<byte> networkArray = (NetworkArray<byte>)0;
				IElementReaderWriter<byte> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<byte>((byte*)Ptr, 96, readerWriter));
				return networkArray;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkArray<byte>)ex2;
		}
	}

	private unsafe NetworkArray<byte> Damage
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0045: Expected VT, but got I4
			//IL_0056: Expected native int or pointer, but got VT
			//IL_00b7: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C50F0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B8B8");
				_ = 0;
				_ = 0;
				byte* array = (byte*)Ptr + 384;
				NetworkArray<byte> networkArray = (NetworkArray<byte>)0;
				IElementReaderWriter<byte> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<byte>(array, 96, readerWriter));
				return networkArray;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkArray<byte>)ex2;
		}
	}

	private unsafe NetworkArray<float> Changed
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0045: Expected VT, but got I4
			//IL_0056: Expected native int or pointer, but got VT
			//IL_00b7: Expected VT, but got Obj
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5518]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA9A44");
				_ = 0;
				_ = 0;
				byte* array = (byte*)Ptr + 768;
				NetworkArray<float> networkArray = (NetworkArray<float>)0;
				IElementReaderWriter<float> readerWriter = default;
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)networkArray, new NetworkArray<float>(array, 96, readerWriter));
				return networkArray;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkArray<float>)ex2;
		}
	}

	private unsafe NetworkBool Filled
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+480]");
				return (NetworkBool)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (NetworkBool)ex2;
		}
		set
		{
			if (Ptr != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	public bool Live
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_012b: Expected Obj, but got I4
			//IL_0101: Expected I4, but got Obj
			//IL_0163: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)((SimulationBehaviour)this)._object != (UnityEngine.Object)null)
			{
				NetworkObject networkObject = ((SimulationBehaviour)this)._object;
				if ((object)((SimulationBehaviour)this)._object != null)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!networkObject._runner)
					{
						goto IL_00ed;
					}
					if ((object)networkObject._runner != null)
					{
						ArgumentNullException ex = new ArgumentNullException();
						return (byte)(int)ex != 0;
					}
				}
				NullReferenceException ex2 = new NullReferenceException();
				return (byte)(int)ex2 != 0;
			}
			goto IL_00ed;
			IL_00ed:
			return false;
		}
	}

	public float Now
	{
		get
		{
			//IL_0041: Expected F4, but got I4
			if (Live)
			{
				return ((SimulationBehaviour)this)._runner.SimulationTime;
			}
			return 0f;
		}
	}

	private float Stamp
	{
		get
		{
			//IL_001f: Invalid comparison between F4 and I
			//IL_0046: Expected F4, but got I
			float num = ((SimulationBehaviour)this)._runner.SimulationTime;
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
			if (num2 < 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
				num = 0f;
			}
			return num;
		}
	}

	public override void Spawned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5550]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F668");
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5558]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F774");
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5560]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434F818");
	}

	public byte KindAt(int i)
	{
		//IL_007d: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		bool live = Live;
		bool flag = i < 95;
		object obj = !flag;
		object obj2 = i - 95;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		byte result = 0;
		if (obj4 == null)
		{
			bool flag3 = !live;
			result = 0;
			if (!flag3)
			{
				NetworkArray<byte> kinds = Kinds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
			}
		}
		return result;
	}

	public int DamageAt(int i)
	{
		//IL_008b: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got Unknown
		bool live = Live;
		bool flag = i < 95;
		object obj = !flag;
		object obj2 = i - 95;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		int result = 0;
		if (obj4 == null)
		{
			bool flag3 = !live;
			result = 0;
			if (!flag3)
			{
				NetworkArray<byte> damage = Damage;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
				object obj6 = default;
				result = obj6 & 0xFF;
			}
		}
		return result;
	}

	public float ChangedAt(int i)
	{
		//IL_0075: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_00b3: Expected F4, but got I4
		//IL_001d: Expected F4, but got I4
		bool live = Live;
		bool flag = i < 95;
		object obj = !flag;
		object obj2 = i - 95;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		float result = 0f;
		if (obj4 == null)
		{
			bool flag3 = !live;
			result = 0f;
			if (!flag3)
			{
				NetworkArray<float> changed = Changed;
				NetworkArray<float> networkArray = default;
				result = networkArray.get_Item(i);
			}
		}
		return result;
	}

	public unsafe void Hit(int node, int amount, Vector3 at, Vector3 normal)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected I4, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_0199: Expected VT, but got I
		//IL_0199: Expected VT, but got Ref
		//IL_010f: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		bool flag = node < 95;
		object obj = !flag;
		object obj2 = node - 95;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = amount - 255;
		bool flag3 = (nint)obj5 < 0;
		int num = amount ^ 0xFF;
		int num2 = amount ^ obj5;
		int num3 = num & num2;
		bool flag4 = num3 < 0;
		bool flag5 = flag3 == flag4;
		object obj6 = !flag5;
		object obj7 = ~obj6;
		int num4 = ((obj7 != null) ? 255 : amount);
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		int num5 = ~num4;
		int amount2 = num4 & num5;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj8 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag6 = obj8 == null;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj11 = default;
				object obj10 = obj11 & 1;
				if (obj10 != null)
				{
					Count(node, (byte)amount2);
				}
			}
		}
		object obj12 = default;
		IntPtr intPtr = default;
		RPC_Hit((byte)node, (byte)amount2, (Vector3)(&obj12), normal, (RpcInfo)(nint)intPtr);
	}

	public unsafe void RPC_Hit(byte node, byte amount, Vector3 at, Vector3 normal, RpcInfo info = default(RpcInfo))
	{
		//IL_1156: Expected VT, but got I4
		//IL_04c3: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_050d: Expected I4, but got Obj
		//IL_0539: Expected Obj, but got I4
		//IL_0597: Expected VT, but got I4
		//IL_05b4: Expected Obj, but got I4
		//IL_11af: Expected Obj, but got I4
		//IL_131b: Expected Obj, but got I
		//IL_1345: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_05e9: Expected I4, but got Obj
		//IL_0604: Expected I4, but got I8
		//IL_00af: Expected Obj, but got I4
		//IL_0636: Expected Obj, but got VT
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_065e: Expected Obj, but got I4
		//IL_0757: Expected Obj, but got I4
		//IL_00cd: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_078d: Expected Obj, but got I
		//IL_079f: Expected VT, but got I8
		//IL_07ba: Expected VT, but got I4
		//IL_014c: Expected Obj, but got I4
		//IL_07dd: Expected Obj, but got VT
		//IL_07f7: Expected Obj, but got I4
		//IL_0810: Expected VT, but got I4
		//IL_0818: Expected I4, but got VT
		//IL_0191: Expected Obj, but got I4
		//IL_08dd: Expected Obj, but got I4
		//IL_08e5: Expected VT, but got Ref
		//IL_091a: Expected Obj, but got Ref
		//IL_092b: Expected Obj, but got VT
		//IL_06ad: Expected VT, but got I4
		//IL_06b2: Expected VT, but got Obj
		//IL_06c3: Expected VT, but got I4
		//IL_0836: Expected Obj, but got I
		//IL_0848: Expected VT, but got Obj
		//IL_01c7: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		//IL_1099: Expected Ref, but got VT
		//IL_0867: Expected Obj, but got I
		//IL_0879: Expected I4, but got Obj
		//IL_0879: Expected VT, but got I4
		//IL_0881: Expected I4, but got Obj
		//IL_0893: Expected I4, but got Obj
		//IL_0893: Expected VT, but got I4
		//IL_06da: Invalid comparison between VT and I4
		//IL_10ce: Expected Obj, but got VT
		//IL_0985: Expected Obj, but got I
		//IL_09af: Expected Obj, but got I4
		//IL_06f7: Invalid comparison between VT and I4
		//IL_0709: Expected VT, but got I4
		//IL_070e: Expected VT, but got Obj
		//IL_071f: Expected VT, but got I4
		//IL_121a: Expected Obj, but got I
		//IL_122a: Expected Obj, but got I
		//IL_0967: Expected Obj, but got I4
		//IL_0adf: Expected F4, but got VT
		//IL_0ada: Expected native int or pointer, but got VT
		//IL_0aed: Expected VT, but got I4
		//IL_0af5: Expected F4, but got I4
		//IL_09e4: Expected Obj, but got I
		//IL_09ed: Expected VT, but got Obj
		//IL_0a06: Expected VT, but got Obj
		//IL_0a28: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I4
		//IL_02b4: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_0a60: Expected I4, but got I8
		//IL_0a77: Expected VT, but got I4
		//IL_0aa3: Expected VT, but got I4
		//IL_0320: Expected Obj, but got I
		//IL_0328: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I4
		//IL_0371: Expected VT, but got I4
		//IL_039a: Expected I, but got Obj
		//IL_03bc: Expected Obj, but got I4
		//IL_03e3: Expected VT, but got I4
		//IL_11fc: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I
		//IL_04ae: Expected Obj, but got I
		//IL_0caf: Expected Obj, but got I4
		//IL_0c21: Expected VT, but got I4
		//IL_0d42: Expected Obj, but got I4
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected Obj, but got Unknown
		//IL_0d67: Expected F4, but got I
		//IL_0d77: Expected Obj, but got I
		//IL_0d87: Expected VT, but got I
		//IL_0d95: Expected VT, but got I4
		//IL_0da2: Expected VT, but got I4
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected Obj, but got Unknown
		//IL_0e48: Expected Obj, but got I
		//IL_0e72: Expected Obj, but got I4
		//IL_0e7a: Expected F4, but got VT
		//IL_1272: Expected VT, but got I4
		//IL_1272: Expected VT, but got F4
		//IL_0e9a: Expected F4, but got VT
		//IL_0ea7: Expected I, but got Obj
		//IL_0ec9: Expected Obj, but got I4
		//IL_0ef4: Expected VT, but got F4
		//IL_0f2b: Expected VT, but got I4
		//IL_0f67: Expected Obj, but got I4
		//IL_0f81: Expected Obj, but got I4
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Expected Obj, but got Unknown
		bool flag = NetworkBehaviourUtils.CheckInvokeRpc((NetworkBehaviour)this);
		bool flag2 = !flag;
		Vector3 normal2 = at;
		object obj2 = default;
		object obj = obj2;
		float num2 = default;
		float num = num2;
		Fusion.RpcBuilder rpcBuilder = (Fusion.RpcBuilder)0;
		byte b = amount;
		RpcChannel rpcChannel = (RpcChannel)0;
		object obj3 = default;
		int bytePayloadSize4;
		NetworkRunner networkRunner = default;
		UnityEngine.Object obj5;
		int num5;
		UnityEngine.Object obj6;
		RpcInvokeInfo rpcInvokeInfo;
		Fusion.RpcBuilder rpcBuilder3 = default;
		Fusion.RpcDataWriter writer;
		PlayerRef playerRef;
		PlayerRef playerRef2;
		RpcInvokeInfo rpcInvokeInfo2;
		int num4;
		int num3;
		bool flag4;
		byte b2;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj3 = 0;
			int bytePayloadSize = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize2 = Fusion.RpcDataWriter.GetBytePayloadSize(1);
			int bytePayloadSize3 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			bytePayloadSize4 = Fusion.RpcDataWriter.GetBytePayloadSize(12);
			num3 = (int)obj3;
			networkRunner = ((SimulationBehaviour)this)._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v16 (System.Int32)+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef invalid = PlayerRef.Invalid;
			flag4 = (object)networkRunner == null;
			normal2 = at;
			num4 = bytePayloadSize4;
			obj = obj2;
			num = num2;
			rpcBuilder = (Fusion.RpcBuilder)0;
			b2 = amount;
			obj5 = null;
			num5 = bytePayloadSize2;
			obj6 = (UnityEngine.Object)bytePayloadSize;
			if (!flag4)
			{
				object obj7 = bytePayloadSize2 + bytePayloadSize;
				object obj8 = bytePayloadSize3 + bytePayloadSize4;
				int payloadByteCount = (int)(obj7 + obj8);
				Fusion.RpcBuilder rpcBuilder2 = networkRunner.CreateRpcBuilder(3672582437u, payloadByteCount, (NetworkBehaviour)this, invalid);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				rpcInvokeInfo = rpcBuilder3.Prepare(out writer);
				networkRunner = (NetworkRunner)(rpcInvokeInfo >> 32);
				object obj9 = networkRunner - 522;
				bool flag5 = (nint)obj9 < 2;
				object obj10 = !flag5;
				object obj11 = ~obj10;
				RpcInfo rpcInfo;
				if (obj11 == null && (nint)networkRunner != 518)
				{
					bool flag6 = (nint)networkRunner != 524;
					rpcInfo = (RpcInfo)0;
					playerRef = (PlayerRef)this;
					playerRef2 = invalid;
					rpcInvokeInfo2 = (RpcInvokeInfo)0;
					if (flag6)
					{
						goto IL_07cf;
					}
					if (rpcInvokeInfo != (RpcInvokeInfo)(object)1)
					{
						bool flag7 = rpcInvokeInfo != (RpcInvokeInfo)(object)4;
						rpcInfo = (RpcInfo)0;
						playerRef = (PlayerRef)this;
						playerRef2 = invalid;
						rpcInvokeInfo2 = (RpcInvokeInfo)0;
						if (flag7)
						{
							goto IL_07cf;
						}
					}
				}
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v73+E4]");
				bool flag8 = (nint)0 == 0;
				object obj13 = !flag8;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5590]");
				object rpc = 0;
				playerRef = (PlayerRef)((nint)(&writer) & 0xFFFFFFFFL);
				NetworkBehaviourUtils.NotifyRpcError((ILogSource)this, (string)rpc, rpcInvokeInfo, playerRef);
				rpcInfo = (RpcInfo)0;
				playerRef2 = none;
				rpcInvokeInfo2 = rpcInvokeInfo;
				goto IL_07cf;
			}
			goto IL_0fd7;
		}
		goto IL_0005;
		IL_0da7:
		object obj15 = default;
		Fusion.RpcBuilder rpcBuilder4;
		object obj14 = obj15 - rpcBuilder4;
		float num7;
		float num6 = num2 - num7;
		object obj17;
		object obj16 = obj2 - obj17;
		object obj18 = obj14 * obj14;
		float num8 = num6 * num6;
		float num9 = (float)obj18 + num8;
		object obj19 = obj16 * obj16;
		float num10 = (float)obj19 + num9;
		if ((double)num10 > 4.0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X0_v109+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		float reach = (float)rpcBuilder4;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			reach = (float)rpcBuilder4;
		}
		if (!GillaNetGuard.Near((PlayerRef)at.y, (Vector3)0, reach, num7))
		{
			return;
		}
		nint num11 = (nint)networkRunner;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X0_v113 (Il2CppClass<Fusion.NetworkRunner>)+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!NetworkApe.InBudget((PlayerRef)at.y))
		{
			return;
		}
		((GillaOreVeins)obj6).Heard(num5, (Vector3)0, normal2);
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj24 = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag11 = obj24 == null;
		object obj25 = !flag11;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj27 = default;
			object obj26 = obj27 & 1;
			if (obj26 != null)
			{
				Count(num5, amount);
			}
		}
		return;
		IL_0ff4:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		IndexOutOfRangeException ex2 = ex;
		int num12 = default;
		object obj29 = default;
		object obj30 = default;
		Fusion.RpcBuilder rpcBuilder5 = default;
		IndexOutOfRangeException ex4 = default;
		while (true)
		{
			object obj28;
			if ((nint)obj5 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				num12 = 1;
				obj28 = obj29;
				num3 = 1;
			}
			else
			{
				if ((nint)obj5 != 1)
				{
					goto IL_1293;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				obj28 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj29 = obj30;
			}
			((Fusion.RpcBuilder*)rpcBuilder5)->Dispose();
			if (obj28 == null)
			{
				break;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex2 = (IndexOutOfRangeException)(object)ex3;
			obj5 = null;
			goto IL_1293;
			IL_1293:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289D410");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
			ex2 = ex4;
			networkRunner = null;
			num5 = 0;
			obj6 = null;
		}
		obj5 = null;
		NullReferenceException ex5 = (NullReferenceException)rpcBuilder5;
		num3 = 0;
		goto IL_12b6;
		IL_07cf:
		object obj31 = rpcInvokeInfo >> 32;
		bool flag12 = obj31 == null;
		object obj32 = !flag12;
		obj = obj2;
		num = num2;
		rpcBuilder = (Fusion.RpcBuilder)0;
		int num13 = (int)rpcInvokeInfo2;
		object obj35 = default;
		float num15 = default;
		Fusion.RpcBuilder rpcBuilder6 = default;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5300]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			playerRef = (PlayerRef)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376C5C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5588]");
			object obj34 = 0;
			writer.Write((Vector3)12, (int)obj34);
			num13 = (int)obj34;
			writer.Write((Vector3)12, (int)obj34);
			int num14 = rpcBuilder3.Send();
			obj = obj35;
			num = num15;
			rpcBuilder = rpcBuilder6;
		}
		rpcBuilder3.Dispose();
		num12 = 0;
		obj29 = 0;
		rpcBuilder5 = (Fusion.RpcBuilder)(&rpcBuilder3);
		normal2 = (Vector3)playerRef;
		Vector3 vector = (Vector3)playerRef2;
		num4 = bytePayloadSize4;
		b2 = (byte)num13;
		obj5 = null;
		num5 = (int)(&writer);
		ex5 = (NullReferenceException)(&rpcBuilder3);
		num3 = 15;
		obj6 = (UnityEngine.Object)rpcInvokeInfo;
		goto IL_12b6;
		IL_0fd7:
		ex5 = new NullReferenceException();
		goto IL_0fe5;
		IL_12b6:
		if (num12 == 0)
		{
			if (num3 != 15)
			{
				bool flag13 = num3 == 0;
				object obj36 = !flag13;
				if (obj36 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X0_v6+E4]");
			bool flag14 = (nint)0 == 0;
			object obj39 = !flag14;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj38 = obj37;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X0_v6+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v5+18]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v5+18]");
			bool flag15 = (nint)0 == 0;
			MethodBase methodBase = (MethodBase)(object)networkRunner;
			if (!flag15)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5580]");
				object obj42 = 0;
				MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj42);
				object obj43 = obj3;
				RpcInvokeInfo invokeInfo = (RpcInvokeInfo)((object)obj6 | (object)networkRunner);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X8_v10+E4]");
				bool flag16 = (nint)0 == 0;
				object obj44 = !flag16;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef invalid2 = PlayerRef.Invalid;
				RpcHostMode hostMode = (RpcHostMode)(num5 & 0xFFFFFFFFL);
				NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromLocalCall((object)this, methodFromHandle, invokeInfo, hostMode, (PlayerRef)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X27_v2+18] (should have been resolved before IL gen)");
				int num16 = default;
				num12 = num16;
				RpcInfo rpcInfo = (RpcInfo)invalid2;
				vector = (Vector3)0;
				object obj45 = default;
				obj = obj45;
				methodBase = methodFromHandle;
			}
			if ((object)obj6 != null)
			{
				return;
			}
			RpcInfo rpcInfo2 = RpcInfo.FromLocal(((SimulationBehaviour)this)._runner, (RpcChannel)0, (RpcHostMode)0);
			((Vector3*)(nint)at)->x = (float)rpcBuilder5;
			normal2 = (Vector3)0;
			num = num12;
			rpcBuilder = rpcBuilder5;
			networkRunner = (NetworkRunner)(object)methodBase;
			b = 0;
			rpcChannel = (RpcChannel)0;
			goto IL_0005;
		}
		goto IL_0fe5;
		IL_0fe5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0ff4;
		IL_0005:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
		object obj46 = 0;
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v82+E4]");
		bool flag17 = (nint)0 == 0;
		object obj48 = !flag17;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj49 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v86+E4]");
		bool flag18 = (nint)0 == 0;
		object obj50 = !flag18;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj49 = obj46;
		}
		int value = ((int*)num4)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v86+A0]");
		object obj51 = 0;
		obj6 = (UnityEngine.Object)obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v36 (System.Int32)+E4]");
		bool flag19 = (nint)0 == 0;
		object obj52 = !flag19;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = obj6 == null;
		bool flag21 = !flag20;
		object obj53 = !flag21;
		if (obj53 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
		object obj54 = 0;
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v91+E4]");
		bool flag22 = (nint)0 == 0;
		object obj56 = !flag22;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaOreField current = Current;
		num3 = ((int*)num4)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v16 (System.Int32)+E4]");
		bool flag23 = (nint)0 == 0;
		object obj57 = !flag23;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag24 = (UnityEngine.Object)this != (UnityEngine.Object)current;
		bool flag25 = !flag24;
		object obj58 = !flag25;
		if (obj58 != null)
		{
			return;
		}
		num5 = node & 0xFF;
		bool flag26 = num5 < 95;
		object obj59 = !flag26;
		object obj60 = num5 - 95;
		bool flag27 = obj60 == null;
		object obj61 = !flag27;
		object obj62 = obj59 & obj61;
		if (obj62 != null)
		{
			return;
		}
		flag4 = (object)obj6 == null;
		b2 = 0;
		obj5 = current;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+20]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+20]");
			flag4 = (nint)0 == 0;
			b2 = 0;
			obj5 = current;
			if (!flag4)
			{
				int num17 = amount & 0xFF;
				bool flag28 = num17 < 8;
				object obj63 = !flag28;
				object obj64 = num17 - 8;
				bool flag29 = obj64 == null;
				object obj65 = !flag29;
				object obj66 = obj63 & obj65;
				if (obj66 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v16 (System.Int32)+18]");
				if ((nint)0 <= (nint)num5)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
				networkRunner = (NetworkRunner)0;
				nint num18 = (nint)networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X0_v96 (Il2CppClass<Fusion.NetworkRunner>)+E4]");
				bool flag30 = (nint)0 == 0;
				object obj67 = !flag30;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!NetworkApe.Sane((Vector3)0))
				{
					return;
				}
				nint num19 = (nint)networkRunner;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ X0_v100 (Il2CppClass<Fusion.NetworkRunner>)+E4]");
				bool flag31 = (nint)0 == 0;
				object obj68 = !flag31;
				if (obj68 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!NetworkApe.Sane((Vector3)0))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+38]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+38]");
				flag4 = (nint)0 == 0;
				obj = obj35;
				num = num15;
				rpcBuilder = rpcBuilder6;
				b2 = 0;
				obj5 = current;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v16 (System.Int32)+18]");
					UnityEngine.Object obj70;
					if ((nint)0 > (nint)num5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+38]");
						object obj69 = (nint)0 + (nint)(int)node;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v56+20]");
						obj70 = (UnityEngine.Object)0;
					}
					else
					{
						obj70 = null;
					}
					int value2 = ((int*)num4)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v104 (System.Int32)+E4]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v104 (System.Int32)+E4]");
					bool flag32 = (nint)0 == 0;
					object obj71 = !flag32;
					if (obj71 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (obj70 != null)
					{
						flag4 = (object)obj70 == null;
						obj = obj35;
						num = num15;
						rpcBuilder = rpcBuilder6;
						b2 = 0;
						obj5 = null;
						if (!flag4)
						{
							Transform transform = ((Component)obj70).transform;
							flag4 = (object)transform == null;
							obj = obj35;
							num = num15;
							rpcBuilder = rpcBuilder6;
							b2 = 0;
							obj5 = null;
							if (!flag4)
							{
								Vector3 position = transform.position;
								obj17 = obj35;
								num7 = num15;
								rpcBuilder4 = rpcBuilder6;
								Vector3 vector2 = (Vector3)0;
								goto IL_0da7;
							}
						}
					}
					else
					{
						Transform transform2 = ((Component)obj6).transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+20]");
						num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+20]");
						flag4 = (nint)0 == 0;
						obj = obj35;
						num = num15;
						rpcBuilder = rpcBuilder6;
						b2 = 0;
						obj5 = null;
						if (!flag4)
						{
							int num20 = num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v16 (System.Int32)+18]");
							bool flag33 = (nint)num20 < (nint)0;
							object obj72 = !flag33;
							obj = obj35;
							num = num15;
							rpcBuilder = rpcBuilder6;
							b2 = 0;
							obj5 = null;
							if (obj72 != null)
							{
								goto IL_0ff4;
							}
							flag4 = (object)transform2 == null;
							obj = obj35;
							num = num15;
							rpcBuilder = rpcBuilder6;
							b2 = 0;
							obj5 = null;
							if (!flag4)
							{
								int num21 = node & 0xFF;
								object obj73 = num21 * 28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X23_v4 (UnityEngine.Object)+20]");
								object obj74 = 0 + obj73;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X8_v55+24]");
								num7 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X8_v55+28]");
								obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X8_v55+20]");
								rpcBuilder4 = (Fusion.RpcBuilder)0;
								Vector3 vector3 = transform2.TransformPoint((Vector3)0);
								Vector3 vector2 = (Vector3)0;
								goto IL_0da7;
							}
						}
					}
				}
			}
		}
		goto IL_0fd7;
	}

	private void Count(int node, byte amount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_00c3: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01cf: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_02aa: Expected Obj, but got I
		//IL_02d4: Expected Obj, but got I4
		//IL_043d: Expected Obj, but got I4
		//IL_045b: Expected Obj, but got I
		//IL_046b: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
		object obj = 0;
		NetworkArray<byte> kinds = Kinds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
		GillaOre.Kind kind = default;
		object obj2 = kind & (GillaOre.Kind)0xFF;
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5130]");
		object obj3 = 0;
		NetworkArray<byte> damage = Damage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v9+A0]");
		object obj6 = 0;
		object obj7 = obj6;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v11+18]");
			bool flag2 = (nint)0 < (nint)(int)kind;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v11+18]");
			object obj9 = -(int)kind;
			bool flag3 = obj9 == null;
			object obj10 = ~obj8;
			object obj11 = obj10 | flag3;
			if (obj11 != null)
			{
				goto IL_0389;
			}
			object obj12 = kind & (GillaOre.Kind)0xFF;
			object obj13 = obj12 * 72;
			object obj14 = obj6 + obj13;
			object obj16 = default;
			object obj15 = obj16 & 0xFF;
			object obj17 = obj15 + amount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v14+50]");
			if ((nint)obj17 < 0)
			{
				NetworkArray<byte> damage2 = Damage;
				object obj18 = obj17 - 255;
				bool flag4 = (nint)obj18 < 0;
				object obj19 = obj17 ^ 0xFF;
				object obj20 = obj17 ^ obj18;
				object obj21 = obj19 & obj20;
				bool flag5 = (nint)obj21 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5220]");
				object obj22 = 0;
				bool flag6 = flag4 == flag5;
				object obj23 = !flag6;
				object obj24 = ~obj23;
				if (obj24 == null)
				{
					object obj25 = obj17;
				}
				else
				{
					object obj25 = 255;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E68");
				return;
			}
			NetworkArray<byte> kinds2 = Kinds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5220]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E68");
			NetworkArray<byte> damage3 = Damage;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E68");
			NetworkArray<float> changed = Changed;
			float stamp = Stamp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5578]");
			object obj27 = 0;
			NetworkArray<float> networkArray = default;
			float num = networkArray.Set(node, stamp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v28+E4]");
			bool flag7 = (nint)0 == 0;
			object obj30 = !flag7;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj31 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v32+E4]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj31 = obj28;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v32+A0]");
			object obj34 = 0;
			object obj35 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj36 = !flag9;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)obj34 != null))
			{
				return;
			}
			if (obj34 != null)
			{
				((GillaOreVeins)obj34).Drop(kind, node);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0389;
		IL_0389:
		throw new IndexOutOfRangeException();
	}

	private void Put(int node, byte kind)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5220]");
		object obj = 0;
		NetworkArray<byte> kinds = Kinds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E68");
		NetworkArray<byte> damage = Damage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90E68");
		NetworkArray<float> changed = Changed;
		float stamp = Stamp;
		NetworkArray<float> networkArray = default;
		float num = networkArray.Set(node, stamp);
	}

	public override void FixedUpdateNetwork()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_0f87: Expected Obj, but got I4
		//IL_10d4: Expected Obj, but got I
		//IL_10e4: Expected Obj, but got I
		//IL_10ec: Expected I4, but got Obj
		//IL_1104: Expected Obj, but got I
		//IL_1126: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_045a: Expected I4, but got Obj
		//IL_0463: Expected I4, but got Obj
		//IL_022b: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I4
		//IL_050d: Invalid comparison between F4 and I4
		//IL_051c: Invalid comparison between F4 and I4
		//IL_0538: Expected Obj, but got I
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I4
		//IL_0298: Invalid comparison between F4 and I4
		//IL_02cd: Expected Obj, but got I
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05bf: Expected Obj, but got I
		//IL_05d8: Expected Obj, but got I4
		//IL_0d4c: Expected Obj, but got I
		//IL_08bf: Expected I4, but got Obj
		//IL_08ca: Expected I4, but got Obj
		//IL_063e: Expected Obj, but got I4
		//IL_065e: Invalid comparison between F4 and I4
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0921: Expected Obj, but got I
		//IL_0931: Expected Obj, but got I
		//IL_0941: Expected Obj, but got I
		//IL_0951: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I4
		//IL_0993: Expected I4, but got Obj
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_06c8: Expected Obj, but got I
		//IL_0db6: Expected Obj, but got I
		//IL_0dc6: Expected Obj, but got I
		//IL_0ddc: Expected Obj, but got I
		//IL_0de5: Expected Obj, but got I4
		//IL_106f: Expected Obj, but got I4
		//IL_1087: Invalid comparison between F4 and I4
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected Obj, but got Unknown
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Expected Obj, but got Unknown
		//IL_09b9: Expected Obj, but got I4
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I4
		//IL_0762: Invalid comparison between F4 and I4
		//IL_0771: Invalid comparison between F4 and I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got I
		//IL_0e02: Expected Obj, but got I
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_0a09: Expected Obj, but got I4
		//IL_0a52: Expected Obj, but got F4
		//IL_0a5f: Expected Obj, but got F4
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Expected Obj, but got Unknown
		//IL_1010: Expected Obj, but got I4
		//IL_0e37: Expected Obj, but got I
		//IL_0e51: Expected Obj, but got I
		//IL_0e5f: Expected I, but got Obj
		//IL_0e7c: Expected I, but got Obj
		//IL_0eac: Expected Obj, but got I
		//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Expected Obj, but got Unknown
		//IL_0f1a: Expected VT, but got I
		//IL_0b50: Expected Obj, but got I4
		//IL_0b70: Invalid comparison between F4 and I4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected Obj, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected I4, but got Unknown
		//IL_0bd2: Expected Obj, but got I
		//IL_0c5e: Expected I, but got Obj
		//IL_0c7b: Expected I, but got Obj
		//IL_0cab: Expected Obj, but got I
		//IL_0cb9: Expected I4, but got Obj
		//IL_0ce2: Expected Obj, but got I
		//IL_0cff: Expected Obj, but got I
		//IL_0d0f: Expected Obj, but got I
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		float simulationTime;
		object obj16;
		float num5;
		bool flag12;
		object obj17;
		object obj18;
		object obj19;
		object obj12;
		float[] array;
		float num2;
		object obj15;
		bool flag4;
		object obj23 = default;
		float num8 = default;
		bool flag17 = default;
		object obj22 = default;
		object obj21 = default;
		object obj20 = default;
		GillaOreVeins.Rule rule;
		int num;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
				object obj4 = default;
				object obj3 = obj4 & 1;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5570]");
					object obj5 = 0;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v6+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj8 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v10+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj8 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v10+A0]");
					array = (float[])0;
					flag4 = (byte)(int)obj10 != 0;
					UnityEngine.Object obj11 = (UnityEngine.Object)(object)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+E4]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+E4]");
					bool flag5 = (nint)0 == 0;
					object obj13 = !flag5;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = (UnityEngine.Object)(object)array == null;
					bool flag7 = !flag6;
					object obj14 = !flag7;
					if (obj14 != null)
					{
						return;
					}
					bool flag8 = (object)((SimulationBehaviour)this)._runner == null;
					num = 0;
					rule = (GillaOreVeins.Rule)109891584;
					if (!flag8)
					{
						simulationTime = ((SimulationBehaviour)this)._runner.SimulationTime;
						flag4 = hadAuthority;
						if (~(hadAuthority ? 1u : 0u) == 0)
						{
							array = ticks;
							if (ticks != null)
							{
								bool flag9 = array == null;
								num2 = simulationTime;
								num = 0;
								rule = (GillaOreVeins.Rule)109891584;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
									flag4 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
									bool flag10 = (byte)(~(nuint)0u) != 0;
									num2 = simulationTime;
									num = 0;
									rule = (GillaOreVeins.Rule)109891584;
									if (!flag10)
									{
										array = (float[])array.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
										obj15 = 0;
										int num3 = array.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
										bool flag11 = (nint)num3 < (nint)0;
										obj16 = !flag11;
										float num4 = array.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
										num5 = num4 - 0f;
										flag12 = num5 < 0f;
										int num6 = array.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
										bool flag13 = (nint)num6 == 0;
										int num7 = array.Length;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
										obj17 = (nint)num7 ^ (nint)0;
										obj18 = array.Length ^ num5;
										obj19 = obj17 & obj18;
										num2 = simulationTime;
										rule = (GillaOreVeins.Rule)109891584;
										if (!flag13)
										{
											hadAuthority = true;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
											bool flag14 = false;
											goto IL_0416;
										}
										goto IL_0843;
									}
								}
								goto IL_0d14;
							}
						}
						hadAuthority = true;
						bool flag15 = array == null;
						num2 = simulationTime;
						num = 0;
						rule = (GillaOreVeins.Rule)109891584;
						flag4 = true;
						if (!flag15)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
							bool flag14 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
							bool flag16 = (byte)(~(nuint)0u) != 0;
							obj19 = obj20;
							obj18 = obj21;
							obj17 = obj22;
							flag12 = flag17;
							num5 = num8;
							obj16 = obj23;
							obj15 = obj12;
							num2 = simulationTime;
							num = 0;
							rule = (GillaOreVeins.Rule)109891584;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
							flag4 = false;
							if (!flag16)
							{
								goto IL_0416;
							}
						}
					}
					goto IL_0d14;
				}
			}
		}
		hadAuthority = false;
		return;
		IL_0416:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		array = (float[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		rule = (GillaOreVeins.Rule)(this + 136);
		object obj24 = default;
		rule = (GillaOreVeins.Rule)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		flag4 = (byte)(int)rule != 0;
		bool flag18 = (byte)(int)(~rule) != 0;
		obj20 = obj19;
		obj21 = obj18;
		obj22 = obj17;
		flag17 = flag12;
		num8 = num5;
		obj23 = obj16;
		obj12 = obj15;
		num2 = simulationTime;
		num = 0;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			array = (float[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			bool flag19 = (nint)0 < (nint)1;
			obj16 = !flag19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			num5 = 0f - 1f;
			flag12 = num5 < 0f;
			bool flag13 = num5 == 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			obj17 = (nint)0 ^ (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			obj18 = 0 ^ num5;
			obj19 = obj17 & obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			bool flag20 = (nint)0 < (nint)1;
			num2 = simulationTime;
			if (flag20)
			{
				goto IL_0843;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			object obj25 = ~(nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
			obj12 = 0 & obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
			object obj26 = 0;
			object obj28 = default;
			object obj27 = obj28;
			object obj30 = default;
			object obj29 = obj30;
			object obj31 = 0;
			bool flag21 = flag20;
			obj20 = obj19;
			obj21 = obj18;
			obj22 = obj17;
			flag17 = flag12;
			num8 = num5;
			obj23 = obj16;
			float num9 = simulationTime;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
				bool flag22 = (nint)0 == 0;
				obj28 = obj27;
				obj30 = obj29;
				object obj32 = obj31;
				flag20 = flag21;
				num2 = num9;
				num = 0;
				if (flag22)
				{
					break;
				}
				object obj33 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X11_v5+18]");
				bool flag23 = (nint)obj33 < 0;
				obj23 = !flag23;
				float num10 = (float)obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X11_v5+18]");
				num8 = num10 - 0f;
				flag17 = num8 < 0f;
				object obj34 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X11_v5+18]");
				obj22 = obj34 ^ 0;
				obj21 = obj31 ^ num8;
				obj20 = obj22 & obj21;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
					object obj35 = 0 + obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X14_v7+20]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X14_v7+20]");
					bool flag24 = (nint)0 == 0;
					obj30 = obj31;
					obj32 = obj31;
					flag20 = flag21;
					num2 = num9;
					num = 0;
					if (flag24)
					{
						break;
					}
					obj30 = flag4 + obj31;
					obj32 = obj31 + 1;
					bool flag25 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
					obj16 = !flag25;
					num5 = (float)obj12 - (float)obj32;
					flag12 = num5 < 0f;
					flag13 = num5 == 0f;
					obj17 = obj12 ^ obj32;
					obj18 = obj12 ^ num5;
					obj19 = obj17 & obj18;
					float num11 = simulationTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X14_v5+1C]");
					num2 = num11 + 0f;
					flag20 = obj12 != obj32;
					obj15 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X14_v7+20]");
					obj27 = 0;
					obj29 = obj30;
					obj31 = obj32;
					flag21 = flag20;
					obj20 = obj19;
					obj21 = obj18;
					obj22 = obj17;
					flag17 = flag12;
					num8 = num5;
					obj23 = obj16;
					num9 = num2;
					if (flag20)
					{
						continue;
					}
					goto IL_0843;
				}
				goto IL_0f2d;
			}
		}
		goto IL_0d14;
		IL_0f2d:
		throw new IndexOutOfRangeException();
		IL_0d14:
		throw new NullReferenceException();
		IL_0843:
		NetworkBool filled = Filled;
		bool flag26 = filled;
		bool flag27 = !flag26;
		obj20 = obj19;
		obj21 = obj18;
		obj22 = obj17;
		flag17 = flag12;
		num8 = num5;
		obj23 = obj16;
		num = 0;
		if (!flag27)
		{
			flag4 = (byte)(int)ticks != 0;
			bool flag28 = (byte)(int)(~ticks) != 0;
			obj20 = obj19;
			obj21 = obj18;
			obj22 = obj17;
			flag17 = flag12;
			num8 = num5;
			obj23 = obj16;
			num = 0;
			if (flag28)
			{
				goto IL_0d14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55C8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55E0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55C0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55D0]");
			object obj39 = 0;
			bool flag30 = default;
			bool flag29 = flag30;
			Action<int, byte> action2 = default;
			Action<int, byte> action = action2;
			Func<int, byte> func2 = default;
			Func<int, byte> func = func2;
			object obj40 = 0;
			int num12 = 0;
			GillaOreVeins.Rule rule2 = rule;
			GillaOreVeins.Rule rule3 = null;
			bool flag31 = (byte)(int)ticks != 0;
			Func<int, byte> func3 = default;
			Action<int, byte> action3 = default;
			while (true)
			{
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v27 (System.Boolean)+18]");
				if ((nint)obj41 >= 0)
				{
					return;
				}
				object obj42 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v27 (System.Boolean)+18]");
				bool flag32 = (nint)obj42 < 0;
				object obj43 = !flag32;
				if (obj43 != null)
				{
					break;
				}
				array = (float[])(object)(flag31 + obj40);
				num2 = array[0];
				bool flag33 = simulationTime < array[0];
				obj23 = !flag33;
				num8 = simulationTime - array[0];
				flag17 = simulationTime < array[0];
				obj22 = simulationTime ^ array[0];
				obj21 = simulationTime ^ num8;
				obj20 = obj22 & obj21;
				object obj44;
				if (!flag17)
				{
					bool flag34 = array == null;
					flag30 = flag29;
					action2 = action;
					func2 = func;
					obj44 = obj40;
					num = num12;
					rule = rule2;
					flag4 = flag31;
					if (!flag34)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
						flag4 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
						bool flag35 = (byte)(~(nuint)0u) != 0;
						flag30 = flag29;
						action2 = action;
						func2 = func;
						obj44 = obj40;
						num = num12;
						rule = rule2;
						if (!flag35)
						{
							object obj45 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
							bool flag36 = (nint)obj45 < 0;
							obj23 = !flag36;
							float num13 = (float)obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
							num8 = num13 - 0f;
							flag17 = num8 < 0f;
							object obj46 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
							obj22 = obj46 ^ 0;
							obj21 = obj40 ^ num8;
							obj20 = obj22 & obj21;
							if (obj23 != null)
							{
								break;
							}
							flag4 = (byte)(int)(flag4 + obj40) != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+20]");
							rule = (GillaOreVeins.Rule)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+20]");
							bool flag37 = (nint)0 == 0;
							flag30 = flag29;
							action2 = action;
							func2 = func;
							obj44 = obj40;
							num = num12;
							if (!flag37)
							{
								num2 = simulationTime + rule.every;
								array[0] = num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								func3._002Ector((object)this, (IntPtr)obj37);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								action3._002Ector((object)this, (IntPtr)obj39);
								float[] array2 = array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+20]");
								int num14 = ((GillaOreVeins)(object)array2).Grow((GillaOreVeins.Rule)0, rule.each, func3, action3, false);
								flag31 = (byte)(int)ticks != 0;
								flag29 = false;
								action = action3;
								func = func3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+18]");
								obj15 = 0;
								num12 = rule.each;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+20]");
								rule2 = (GillaOreVeins.Rule)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v24 (System.Boolean)+20]");
								rule3 = (GillaOreVeins.Rule)0;
								goto IL_0fec;
							}
						}
					}
					goto IL_0d14;
				}
				goto IL_0fec;
				IL_0fec:
				obj44 = obj40 + 1;
				bool flag38 = !flag31;
				object obj47 = !flag38;
				flag30 = flag29;
				action2 = action;
				func2 = func;
				num = num12;
				rule = rule2;
				flag4 = flag31;
				obj40 = obj44;
				if (obj47 != null)
				{
					continue;
				}
				goto IL_0d14;
			}
		}
		else
		{
			NetworkBool networkBool = (Filled = true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
			if ((nint)0 == 0)
			{
				goto IL_0d14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+18]");
			flag4 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+18]");
			if ((nint)0 < (nint)1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55C0]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55D0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v6 (UnityEngine.Object)+30]");
			object obj39 = (nint)0 + (nint)32;
			object obj37 = 0;
			NetworkBool networkBool3 = networkBool;
			Func<int, byte> func4 = default;
			Action<int, byte> action4 = default;
			while (true)
			{
				bool flag39 = (nint)obj37 < (flag4 ? 1 : 0);
				obj23 = !flag39;
				num8 = (float)obj37 - (float)(flag4 ? 1 : 0);
				flag17 = num8 < 0f;
				obj22 = obj37 ^ flag4;
				obj21 = obj37 ^ num8;
				obj20 = obj22 & obj21;
				if (obj23 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X28_v4+v112 @ X26_v4*8]");
				rule = (GillaOreVeins.Rule)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X28_v4+v112 @ X26_v4*8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55C8]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C55D8]");
					object obj50 = 0;
					func4._002Ector((object)this, (IntPtr)obj50);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					action4._002Ector((object)this, (IntPtr)obj38);
					float[] array3 = array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X28_v4+v112 @ X26_v4*8]");
					int num15 = ((GillaOreVeins)(object)array3).Grow((GillaOreVeins.Rule)0, rule.most, func4, action4, true);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+18]");
					flag4 = false;
					obj37++;
					object obj51 = obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v5+18]");
					bool flag20 = (nint)obj51 < 0;
					bool flag30 = true;
					Action<int, byte> action2 = action4;
					Func<int, byte> func2 = func4;
					num = rule.most;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X28_v4+v112 @ X26_v4*8]");
					networkBool3 = (NetworkBool)0;
					if (!flag20)
					{
						return;
					}
					continue;
				}
				goto IL_0d14;
			}
		}
		goto IL_0f2d;
	}

	public void SetForTest(int node, GillaOre.Kind kind)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object == null)
		{
			return;
		}
		object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
		bool flag2 = node < 95;
		object obj3 = !flag2;
		object obj4 = node - 95;
		bool flag3 = obj4 == null;
		object obj5 = !flag3;
		object obj6 = obj3 & obj5;
		if (obj6 == null)
		{
			object obj8 = default;
			object obj7 = obj8 & 1;
			if (obj7 != null)
			{
				Put(node, (byte)kind);
			}
		}
	}

	public unsafe static void Keep(NetworkObject prefab)
	{
		//IL_0010: Expected Obj, but got I
		//IL_08f2: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_0910: Expected Obj, but got I
		//IL_0920: Expected VT, but got I
		//IL_0930: Invalid comparison between F4 and I
		//IL_0156: Expected Obj, but got I4
		//IL_0194: Expected VT, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_096e: Expected Obj, but got I4
		//IL_0a2b: Expected Obj, but got I
		//IL_0a3b: Expected Obj, but got I
		//IL_0a5d: Expected Obj, but got I4
		//IL_02d0: Expected Obj, but got I
		//IL_09a6: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_0316: Expected VT, but got I4
		//IL_03a3: Expected VT, but got I4
		//IL_0341: Expected Obj, but got I
		//IL_0408: Expected VT, but got I4
		//IL_0445: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I4
		//IL_04e0: Expected Obj, but got I4
		//IL_09c4: Expected Obj, but got I
		//IL_09f7: Expected Obj, but got I
		//IL_0a04: Expected VT, but got Obj
		//IL_0515: Expected Obj, but got I
		//IL_0522: Expected VT, but got Obj
		//IL_0542: Expected VT, but got Ref
		//IL_0542: Expected VT, but got I4
		//IL_055b: Expected Obj, but got I
		//IL_064c: Expected Obj, but got I4
		//IL_0662: Expected VT, but got Ref
		//IL_066b: Expected VT, but got I4
		//IL_0590: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		//IL_05b9: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_06ba: Expected I, but got Obj
		//IL_06c2: Expected Obj, but got I
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_06f2: Expected Obj, but got I4
		//IL_0708: Expected VT, but got Ref
		//IL_0711: Expected VT, but got I4
		//IL_087f: Expected Obj, but got I4
		//IL_08a1: Expected VT, but got I4
		//IL_0740: Expected Obj, but got I4
		//IL_0750: Expected Obj, but got Ref
		//IL_0777: Expected Obj, but got I4
		//IL_078d: Expected VT, but got Ref
		//IL_0796: Expected VT, but got I4
		//IL_07bc: Expected I, but got Obj
		//IL_0828: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)prefab == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaOreField current = Current;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj12;
		NetworkObject networkObject;
		Vector3? vector;
		if ((UnityEngine.Object)current != (UnityEngine.Object)null)
		{
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v99+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaOreField current2 = Current;
			bool flag7 = (object)current2 == null;
			vector = (Vector3?)(object)0;
			obj12 = null;
			networkObject = prefab;
			if (flag7)
			{
				goto IL_0853;
			}
			bool live = current2.Live;
			bool flag8 = !live;
			object obj13 = !flag8;
			if (obj13 != null)
			{
				return;
			}
		}
		float unscaledTime = Time.unscaledTime;
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v27+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v27+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v13+8]");
		Quaternion? quaternion = (Quaternion?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v13+8]");
		if (unscaledTime < 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v28+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v32+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj17;
		}
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v32+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v6+8]");
		UnityEngine.Object obj24 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v18+E4]");
		bool flag12 = (nint)0 == 0;
		object obj25 = !flag12;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v6+8]");
		bool flag13 = (UnityEngine.Object)0 != null;
		bool flag14 = !flag13;
		UnityEngine.Object obj26 = null;
		if (!flag14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v6+8]");
			bool flag15 = (nint)0 == 0;
			vector = (Vector3?)(object)0;
			obj12 = null;
			networkObject = prefab;
			if (flag15)
			{
				goto IL_0853;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X21_v7 (UnityEngine.Object)+B0]");
			obj26 = (UnityEngine.Object)0;
		}
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v36+E4]");
		bool flag16 = (nint)0 == 0;
		object obj28 = !flag16;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = obj26 == null;
		bool flag18 = !flag17;
		object obj29 = !flag18;
		if (obj29 != null)
		{
			return;
		}
		bool flag19 = (object)obj26 == null;
		vector = (Vector3?)(object)0;
		obj12 = null;
		networkObject = prefab;
		if (!flag19)
		{
			if (!((NetworkRunner)obj26).IsRunning)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X9_v6+8]");
			bool flag20 = (nint)0 == 0;
			vector = (Vector3?)(object)0;
			obj12 = null;
			networkObject = prefab;
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X21_v7 (UnityEngine.Object)+A4]");
				bool flag21 = (nint)0 == 0;
				object obj30 = !flag21;
				if (obj30 != null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X21_v7 (UnityEngine.Object)+90]");
				bool flag22 = (nint)0 == 0;
				object obj31 = !flag22;
				if (obj31 != null || !((NetworkRunner)obj26).IsSharedModeMasterClient)
				{
					return;
				}
				float unscaledTime2 = Time.unscaledTime;
				object obj32 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v46+E4]");
				bool flag23 = (nint)0 == 0;
				object obj33 = !flag23;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj32 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v46+A0]");
				object obj34 = 0;
				float num = unscaledTime2 + 3f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B7AC");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
				object obj35 = 0;
				Vector3? vector2 = (Vector3)obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA97E8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
				object obj36 = 0;
				Quaternion? quaternion2 = (Quaternion)obj36;
				Quaternion? quaternion3 = default;
				NetworkObject networkObject2 = ((NetworkRunner)obj26).Spawn(prefab, vector2, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion3), (NetworkRunner.OnBeforeSpawned)null, (NetworkSpawnFlags)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v11 (UnityEngine.Object)+2F8]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X20_v11 (UnityEngine.Object)+2F8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5648]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5650]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v29+10]");
					string message = (string)obj38 + (string)0 + (string)obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj40 = 0;
					object obj41 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X0_v81+E4]");
					bool flag24 = (nint)0 == 0;
					object obj42 = !flag24;
					if (obj42 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.Log(message);
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				bool flag25 = (nint)prefab != 1;
				object obj43 = 2;
				NetworkSpawnFlags networkSpawnFlags = (NetworkSpawnFlags)0;
				NetworkRunner.OnBeforeSpawned onBeforeSpawned = null;
				PlayerRef? playerRef = (PlayerRef?)(object)(&quaternion3);
				Quaternion? quaternion4 = (Quaternion?)(object)0;
				quaternion = quaternion2;
				Vector3? vector3 = vector2;
				NetworkObject networkObject3 = prefab;
				NullReferenceException ex2 = ex;
				if (!flag25)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					NetworkObject networkObject4 = default;
					nint num2 = (nint)networkObject4;
					obj12 = (UnityEngine.Object)num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
					object obj45 = default;
					object obj44 = obj45 & 1;
					bool flag26 = obj44 == null;
					obj43 = 2;
					networkSpawnFlags = (NetworkSpawnFlags)0;
					onBeforeSpawned = null;
					playerRef = (PlayerRef?)(object)(&quaternion3);
					quaternion4 = (Quaternion?)(object)0;
					quaternion = quaternion2;
					vector = vector2;
					networkObject = networkObject4;
					if (!flag26)
					{
						object obj46 = 0;
						networkObject = networkObject4;
						object obj48 = default;
						object obj47 = (object)(&obj48);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						bool flag27 = (object)networkObject4 == null;
						obj43 = 2;
						networkSpawnFlags = (NetworkSpawnFlags)0;
						onBeforeSpawned = null;
						playerRef = (PlayerRef?)(object)(&quaternion3);
						quaternion4 = (Quaternion?)(object)0;
						quaternion = quaternion2;
						vector = vector2;
						if (!flag27)
						{
							nint num3 = (nint)networkObject;
							string text = ((ValueType)(object)networkObject4).ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							string text2 = default;
							string text3 = default;
							string message2 = text2 + text + text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v75+E4]");
							bool flag28 = (nint)0 == 0;
							object obj49 = !flag28;
							if (obj49 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogError(message2);
							return;
						}
						goto IL_0853;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
					object obj50 = networkObject;
					networkObject3 = (NetworkObject)(101789696 + 1224);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					vector3 = (Vector3?)(object)0;
					NullReferenceException ex3 = default;
					ex2 = ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
		}
		goto IL_0853;
		IL_0853:
		throw new NullReferenceException();
	}

	static GillaOreField()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5668]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5670]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @434FD2C");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj5 = 0;
		object obj6 = default;
		obj5 = obj6;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private byte _003CFixedUpdateNetwork_003Eb__35_0(int i)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
		object obj = 0;
		NetworkArray<byte> kinds = Kinds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
		byte result = default;
		return result;
	}

	private byte _003CFixedUpdateNetwork_003Eb__35_1(int i)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C51A8]");
		object obj = 0;
		NetworkArray<byte> kinds = Kinds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F90AE4");
		byte result = default;
		return result;
	}

	public unsafe override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0072: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5678]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5448]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5680]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5688]");
		object obj4 = 0;
		NetworkArray<byte> kinds = Kinds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6FA8");
		NetworkArray<byte> damage = Damage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D6FA8");
		NetworkArray<float> changed = Changed;
		object obj5 = default;
		NetworkBehaviourUtils.InitializeNetworkArray((NetworkArray<float>)(&obj5), _Changed, (string)obj4);
		Filled = _Filled;
	}

	public unsafe override void CopyStateToBackingFields()
	{
		//IL_0010: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Ref, but got Unknown
		//IL_0052: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5450]");
		object obj = 0;
		NetworkArray<byte> kinds = Kinds;
		object obj2 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D60C0");
		NetworkArray<byte> damage = Damage;
		object obj3 = this + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36D60C0");
		NetworkArray<float> changed = Changed;
		object obj4 = default;
		NetworkBehaviourUtils.CopyFromNetworkArray((NetworkArray<float>)(&obj4), ref *(float[]*)(this + 120));
		NetworkBool filled = Filled;
		_Filled = filled;
	}

	protected unsafe static void RPC_Hit_0040Invoker3672582437([In] ref RpcInvokeContext context)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0229: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_00ce: Expected VT, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_01bd: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C52F8]");
		object obj2 = 0;
		RpcDataReader payloadReader = context.PayloadReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376BD20");
		RpcDataReader rpcDataReader = default;
		rpcDataReader.Read(out Vector3 _, 12);
		rpcDataReader.Read(out Vector3 _, 12);
		RpcInfo rpcInfo = RpcInfo.FromRemote(ref context, (RpcHostMode)0, (RpcChannel)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v11+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+18]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5460]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5580]");
			object obj8 = 0;
			MethodBase methodFromHandle = MethodBase.GetMethodFromHandle((RuntimeMethodHandle)obj8);
			NetworkRunnerDebugRpcEvent networkRunnerDebugRpcEvent = NetworkRunnerDebugRpcEvent.FromRemoteCall(ref context, methodFromHandle, (RpcHostMode)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X21_v3+18] (should have been resolved before IL gen)");
		}
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+A0]");
		object obj10 = 0;
		obj10 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+8]");
		GillaOreField gillaOreField = (GillaOreField)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C54E8]");
		object obj11 = 0;
		object obj12 = obj11;
		nint num = (nint)gillaOreField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v14 (Il2CppClass<GillaOreField>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X1_v9+130]");
		bool flag2 = num2 < 0;
		object obj13 = !flag2;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v14 (Il2CppClass<GillaOreField>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X1_v9+130]");
			object obj15 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v17-8]");
			if (0 == (nint)obj12)
			{
				byte node = default;
				byte amount = default;
				object obj16 = default;
				Vector3 normal = default;
				RpcInfo info = default;
				gillaOreField.RPC_Hit(node, amount, (Vector3)(&obj16), normal, info);
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}
}
