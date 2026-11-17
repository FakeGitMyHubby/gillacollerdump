using System;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;
using UnityEngine.Events;

public class GillaItemNet : NetworkBehaviour, _00210, _0021_00210
{
	public GillaItem item;

	private PlayerRef _Holder;

	private PlayerRef _LastHolder;

	private NetworkBool _Gone;

	private float _GoneAt;

	private float _Stirred;

	private int _Eats;

	private byte _EatenBy;

	private PlayerRef _PaidTo;

	private byte _InHand;

	private Vector3 _InHandAt;

	private Quaternion _InHandTurn;

	private const float GoneFor = default(float);

	private int seenEats;

	private float nextClaim;

	private float knockCool;

	private Vector3 lastAt;

	private Vector3 lastVelocity;

	private unsafe PlayerRef Holder
	{
		get
		{
			//IL_002e: Expected VT, but got I
			//IL_0080: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (PlayerRef)ex2;
			}
			return (PlayerRef)ptr;
		}
		set
		{
			//IL_0027: Expected I, but got VT
			if (Ptr != null)
			{
				int* ptr = (int*)(nint)value;
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

	private unsafe PlayerRef LastHolder
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+4]");
				return (PlayerRef)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (PlayerRef)ex2;
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

	private unsafe NetworkBool Gone
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+8]");
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

	private unsafe float GoneAt
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+C]");
				return 0f;
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

	private unsafe float Stirred
	{
		get
		{
			//IL_0036: Expected F4, but got I
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+10]");
				return 0f;
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

	private unsafe int Eats
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+14]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (int)ex2;
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

	private unsafe byte EatenBy
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+18]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (byte)(int)ex2;
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

	private unsafe PlayerRef PaidTo
	{
		get
		{
			//IL_0036: Expected VT, but got I
			//IL_0088: Expected VT, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+1C]");
				return (PlayerRef)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (PlayerRef)ex2;
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

	private unsafe byte InHand
	{
		get
		{
			//IL_0088: Expected I4, but got Obj
			int* ptr = Ptr;
			if (Ptr != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Int32*)+20]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			InvalidOperationException ex = default;
			string message = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			ArgumentNullException ex2 = new ArgumentNullException();
			return (byte)(int)ex2;
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

	private unsafe Vector3 InHandAt
	{
		get
		{
			//IL_0021: Expected VT, but got Obj
			//IL_0073: Expected VT, but got Obj
			if (Ptr == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (Vector3)ex2;
			}
			return (Vector3)this;
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

	private unsafe Quaternion InHandTurn
	{
		get
		{
			//IL_0021: Expected VT, but got Obj
			//IL_0073: Expected VT, but got Obj
			if (Ptr == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				InvalidOperationException ex = default;
				string message = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				ArgumentNullException ex2 = new ArgumentNullException();
				return (Quaternion)ex2;
			}
			return (Quaternion)this;
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

	public bool HeldByOther
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I4
			//IL_015d: Expected I4, but got Obj
			//IL_00fe: Expected Obj, but got I4
			//IL_0128: Expected Obj, but got VT
			if (Live)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj = 0;
				PlayerRef holder = Holder;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef none = PlayerRef.None;
				if (holder != none)
				{
					PlayerRef holder2 = Holder;
					if ((object)((SimulationBehaviour)this)._runner != null)
					{
						PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
						object obj4 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v7+E4]");
						bool flag2 = (nint)0 == 0;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj6 = holder2 - localPlayer;
						bool flag3 = obj6 == null;
						return !flag3;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			return false;
		}
	}

	public bool PaysMe
	{
		get
		{
			//IL_000f: Expected I4, but got Obj
			//IL_001a: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			//IL_017d: Expected I4, but got Obj
			//IL_00e3: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I4
			//IL_0137: Expected Obj, but got VT
			bool result;
			if (Live)
			{
				result = (byte)(int)((SimulationBehaviour)this)._object != 0;
				if ((int)(~((SimulationBehaviour)this)._object) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (System.Boolean)+58]");
					object obj = (nint)0 & (nint)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						object obj4 = default;
						object obj3 = obj4 & 1;
						if (obj3 != null)
						{
							PlayerRef paidTo = PaidTo;
							if ((object)((SimulationBehaviour)this)._runner != null)
							{
								PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
								object obj5 = 0;
								object obj6 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+E4]");
								bool flag2 = (nint)0 == 0;
								object obj7 = !flag2;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj8 = paidTo - localPlayer;
								bool flag3 = obj8 == null;
								result = flag3;
								goto IL_01a4;
							}
							NullReferenceException ex = new NullReferenceException();
							return (byte)(int)ex != 0;
						}
					}
					result = false;
				}
			}
			else
			{
				result = true;
			}
			goto IL_01a4;
			IL_01a4:
			return result;
		}
	}

	public bool HeldLastByMe
	{
		get
		{
			//IL_000f: Expected I4, but got Obj
			//IL_001a: Expected I4, but got Obj
			//IL_003e: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			//IL_017d: Expected I4, but got Obj
			//IL_00e3: Expected Obj, but got I
			//IL_010d: Expected Obj, but got I4
			//IL_0137: Expected Obj, but got VT
			bool result;
			if (Live)
			{
				result = (byte)(int)((SimulationBehaviour)this)._object != 0;
				if ((int)(~((SimulationBehaviour)this)._object) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (System.Boolean)+58]");
					object obj = (nint)0 & (nint)2;
					bool flag = obj == null;
					object obj2 = !flag;
					if (obj2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
						object obj4 = default;
						object obj3 = obj4 & 1;
						if (obj3 != null)
						{
							PlayerRef lastHolder = LastHolder;
							if ((object)((SimulationBehaviour)this)._runner != null)
							{
								PlayerRef localPlayer = ((SimulationBehaviour)this)._runner.LocalPlayer;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
								object obj5 = 0;
								object obj6 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v8+E4]");
								bool flag2 = (nint)0 == 0;
								object obj7 = !flag2;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj8 = lastHolder - localPlayer;
								bool flag3 = obj8 == null;
								result = flag3;
								goto IL_01a4;
							}
							NullReferenceException ex = new NullReferenceException();
							return (byte)(int)ex != 0;
						}
					}
					result = false;
				}
			}
			else
			{
				result = true;
			}
			goto IL_01a4;
			IL_01a4:
			return result;
		}
	}

	public override void Spawned()
	{
		//IL_0081: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		int eats = Eats;
		seenEats = eats;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		Vector3 vector = default;
		lastAt = vector;
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
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		NetworkBool gone = Gone;
		if ((bool)gone)
		{
			item.ShowGone();
		}
	}

	public void TakeOver()
	{
		//IL_0049: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		if (!Live)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
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
				return;
			}
			networkObject = ((SimulationBehaviour)this)._object;
		}
		bool flag2 = networkObject.RequestStateAuthority();
	}

	public void Swallowed(int recycler)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		if (!Live)
		{
			return;
		}
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
		object obj4 = default;
		object obj3 = obj4 & 1;
		if (obj3 != null)
		{
			byte eatenBy = (byte)(recycler + 1);
			EatenBy = eatenBy;
			PlayerRef lastHolder = LastHolder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			PlayerRef paidTo = ((lastHolder != none) ? LastHolder : ((SimulationBehaviour)this)._runner.LocalPlayer);
			PaidTo = paidTo;
			int eats = Eats;
			int eats2 = eats + 1;
			Eats = eats2;
			int eats3 = Eats;
			seenEats = eats3;
		}
	}

	public void StateAuthorityChanged()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
		//IL_003c: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		if ((object)((SimulationBehaviour)this)._object != null)
		{
			object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			}
			else
			{
				networkObject = null;
			}
		}
		bool mine = (byte)(networkObject & 1) != 0;
		item.AuthorityChanged(mine);
	}

	public void RemoveFromRoom()
	{
		//IL_0049: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		if (!Live)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
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
				((SimulationBehaviour)this)._runner.Despawn(((SimulationBehaviour)this)._object);
				return;
			}
			networkObject = ((SimulationBehaviour)this)._object;
		}
		bool flag2 = networkObject.RequestStateAuthority();
	}

	public override void FixedUpdateNetwork()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_00aa: Expected I4, but got I8
		//IL_00c4: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_0225: Expected VT, but got I4
		//IL_0244: Expected F8, but got I
		//IL_024e: Expected VT, but got I4
		//IL_033f: Invalid comparison between F4 and I4
		//IL_0350: Expected Obj, but got I4
		//IL_0359: Invalid comparison between F4 and I4
		//IL_036a: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I4
		//IL_0679: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I4
		//IL_04a3: Expected Obj, but got I4
		//IL_04c1: Expected Obj, but got I
		//IL_04eb: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I4
		//IL_0597: Invalid comparison between F4 and I
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
		object obj4 = default;
		object obj3 = obj4 & 1;
		if (obj3 == null)
		{
			return;
		}
		PlayerRef playerRef = ((SimulationBehaviour)this)._runner.LocalPlayer;
		GillaItem gillaItem = item;
		int num = (int)(gillaItem.Hand__BackingField & 0x80000000L);
		bool flag2 = num == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Holder = playerRef;
			LastHolder = playerRef;
		}
		else
		{
			bool flag3 = (byte)(~(gillaItem.Worn__BackingField ? 1u : 0u)) != 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v68+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				playerRef = PlayerRef.None;
			}
			Holder = playerRef;
		}
		GillaItem gillaItem2 = item;
		object obj10 = gillaItem2.Hand__BackingField - 1;
		bool flag5 = obj10 == null;
		bool flag6 = gillaItem2.Hand__BackingField == 0;
		byte b = (byte)((flag5 ? 1u : 0u) << 1);
		object obj11 = !flag6;
		object obj12 = ~obj11;
		byte b2 = (InHand = (byte)((obj12 != null) ? 1 : b));
		byte inHand = InHand;
		if ((inHand & 0xFF) != 0)
		{
			InHandAt = (Vector3)b2;
			GillaItem gillaItem3 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v25 (GillaItem)+6C]");
			double num2 = 0.0;
			InHandTurn = (Quaternion)b2;
		}
		float simulationTime = ((SimulationBehaviour)this)._runner.SimulationTime;
		GillaItem gillaItem4 = item;
		if (~(gillaItem4.Gone__BackingField ? 1u : 0u) == 0)
		{
			NetworkBool gone = Gone;
			bool flag7 = gone;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			if (obj13 == null)
			{
				NetworkBool gone2 = true;
				Gone = gone2;
				GoneAt = simulationTime;
			}
		}
		float stirred;
		if (item.Still)
		{
			stirred = Stirred;
			bool flag9 = stirred < 0f;
			object obj14 = !flag9;
			bool flag10 = stirred == 0f;
			object obj15 = !flag10;
			object obj16 = obj14 & obj15;
			if (obj16 != null)
			{
				goto IL_0669;
			}
		}
		Stirred = simulationTime;
		stirred = simulationTime;
		goto IL_0669;
		IL_0669:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53B0]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v17+A0]");
		object obj19 = 0;
		UnityEngine.Object obj20 = (UnityEngine.Object)obj19;
		NetworkBool gone3 = Gone;
		if ((bool)gone3)
		{
			float goneAt = GoneAt;
			stirred = simulationTime - goneAt;
			bool flag11 = !((double)stirred < 2.5);
			double num2 = 2.5;
			if (flag11)
			{
				goto IL_045b;
			}
		}
		NetworkBool gone4 = Gone;
		bool flag12 = gone4;
		bool flag13 = !flag12;
		object obj21 = !flag13;
		if (obj21 != null || !item.Lost)
		{
			NetworkBool gone5 = Gone;
			bool flag14 = gone5;
			bool flag15 = !flag14;
			object obj22 = !flag15;
			if (obj22 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36+E4]");
			bool flag16 = (nint)0 == 0;
			object obj25 = !flag16;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!((UnityEngine.Object)obj19 != null))
			{
				return;
			}
			bool flag17 = ((GillaItemDirector)obj19).Stays(item);
			bool flag18 = !flag17;
			object obj26 = !flag18;
			if (obj26 != null)
			{
				return;
			}
			float stirred2 = Stirred;
			float num3 = simulationTime - stirred2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X20_v7 (UnityEngine.Object)+40]");
			if (!(num3 > 0f))
			{
				return;
			}
			Transform transform = base.transform;
			Vector3 position = transform.position;
			float num4 = GillaItemDirector.Nearest(position);
			if ((double)num4 < 8.0)
			{
				return;
			}
		}
		goto IL_045b;
		IL_045b:
		((SimulationBehaviour)this)._runner.Despawn(((SimulationBehaviour)this)._object);
	}

	public override void Render()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I4
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
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
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		NetworkBool gone = Gone;
		if ((bool)gone)
		{
			GillaItem gillaItem = item;
			bool flag3 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				gillaItem.ShowGone();
			}
		}
		Knock();
		int eats = Eats;
		if (eats != seenEats)
		{
			int eats2 = Eats;
			seenEats = eats2;
			item.ShowSwallowed();
			byte eatenBy = EatenBy;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6270]");
			object obj7 = 0;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num = eatenBy & 0xFF;
			int i = num - 1;
			GillaRecycler gillaRecycler = GillaRecycler.Number(i);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (gillaRecycler != null)
			{
				gillaRecycler.Watch(item);
			}
		}
	}

	private void Knock()
	{
		//IL_0479: Invalid comparison between F4 and I4
		//IL_048a: Expected Obj, but got I4
		//IL_0493: Invalid comparison between F4 and I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_04ce: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_0444: Expected VT, but got F4
		//IL_0458: Expected VT, but got F4
		//IL_018c: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01e5: Invalid comparison between F4 and I4
		//IL_01f6: Expected Obj, but got I4
		//IL_0201: Invalid comparison between F4 and I4
		//IL_0212: Expected Obj, but got I4
		//IL_0530: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got VT
		//IL_026f: Expected Obj, but got I
		//IL_029b: Expected F8, but got I
		//IL_02b5: Invalid comparison between F4 and I
		//IL_0377: Invalid comparison between VT and F8
		//IL_040c: Expected VT, but got I4
		float deltaTime = Time.deltaTime;
		bool flag = deltaTime < 0f;
		object obj = !flag;
		bool flag2 = deltaTime == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 != null)
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		object obj4 = this + 196;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X20_v6-C]");
		float num2 = num - 0f;
		double num4 = default;
		double num3 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X20_v6-8]");
		double num5 = num3 - 0.0;
		float num7 = default;
		float num6 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X20_v6-4]");
		float num8 = num6 - 0f;
		float num9 = (knockCool -= deltaTime);
		PlayerRef holder = Holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num10 = num2 / deltaTime;
		float num11 = (float)num5 / deltaTime;
		float num12 = num8 / deltaTime;
		PlayerRef none = PlayerRef.None;
		if (holder == none)
		{
			NetworkBool gone = Gone;
			bool flag5 = gone;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				GillaItem gillaItem = item;
				bool flag7 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					num9 = knockCool;
					bool flag8 = knockCool < 0f;
					object obj13 = !flag8;
					bool flag9 = knockCool == 0f;
					object obj14 = !flag9;
					object obj15 = obj13 & obj14;
					if (obj15 == null)
					{
						object obj16 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v26+E4]");
						bool flag10 = (nint)0 == 0;
						object obj17 = !flag10;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj18 = lastVelocity * lastVelocity;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaItemNet)+C8]");
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaItemNet)+C8]");
						object obj19 = num13 * 0;
						object obj20 = obj18 + obj19;
						object obj21 = default;
						num9 = (float)obj20 + (float)obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						num4 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						float num14 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						if (num14 > 0f)
						{
							float num15 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X20_v6+8]");
							num7 = num15 - 0f;
							float num16 = num10 - (float)obj4;
							float num17 = num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X20_v6+4]");
							float num18 = num17 - 0f;
							float num19 = num16 * num16;
							float num20 = num18 * num18;
							float num21 = num19 + num20;
							float num22 = num7 * num7;
							num9 = num21 + num22;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D72D54");
							bool flag11 = lastVelocity <= (object)2.0;
							num4 = 2.0;
							if (!flag11)
							{
								bool flag12 = !((double)num9 < 30.0);
								num4 = 30.0;
								if (!flag12)
								{
									knockCool = 0.15f;
									Transform transform2 = base.transform;
									Vector3 position2 = transform2.position;
									item.Knock((Vector3)0, num9);
									num4 = 30.0;
								}
							}
						}
					}
				}
			}
		}
		Transform transform3 = base.transform;
		Vector3 position3 = transform3.position;
		lastAt = (Vector3)num9;
		lastVelocity = (Vector3)num10;
	}

	private void OnEnable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0049: Expected I4, but got I8
		//IL_006b: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1778]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Fusion.SimulationBehaviourRuntimeFlags flags = (Fusion.SimulationBehaviourRuntimeFlags)((long)((SimulationBehaviour)this).Flags & 0xFFFFFFEFL);
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender += unityAction;
	}

	private void OnDisable()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1778]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj3 = 0;
		Fusion.SimulationBehaviourRuntimeFlags flags = ((SimulationBehaviour)this).Flags | (Fusion.SimulationBehaviourRuntimeFlags)0x10;
		((SimulationBehaviour)this).Flags = flags;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		UnityAction unityAction = default;
		unityAction._002Ector(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.onBeforeRender -= unityAction;
	}

	private void Glue()
	{
		//IL_00c3: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_04c0: Expected Obj, but got I4
		//IL_0356: Expected Obj, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0436: Expected VT, but got I4
		//IL_0436: Expected VT, but got I4
		//IL_046e: Expected VT, but got I4
		//IL_046e: Expected VT, but got I4
		if (!Live)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
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
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
		}
		PlayerRef holder = Holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		if (holder == none)
		{
			return;
		}
		byte inHand = InHand;
		if ((inHand & 0xFF) == 0)
		{
			return;
		}
		GillaItem gillaItem = item;
		bool flag4 = (byte)(~(gillaItem.Gone__BackingField ? 1u : 0u)) != 0;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			return;
		}
		bool flag5 = (byte)(~(gillaItem.Swallowed__BackingField ? 1u : 0u)) != 0;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			return;
		}
		PlayerRef holder2 = Holder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkApe networkApe = NetworkApe.Find(holder2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = (UnityEngine.Object)networkApe == (UnityEngine.Object)null;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		UnityEngine.Object obj18 = null;
		if (obj17 == null)
		{
			byte inHand2 = InHand;
			int num = inHand2 & 0xFF;
			object obj19 = ((num != 2) ? ((object)(networkApe + 112)) : ((object)(networkApe + 120)));
			obj18 = (UnityEngine.Object)obj19;
		}
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v25+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = obj18 == null;
		bool flag12 = !flag11;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			Quaternion inHandTurn = InHandTurn;
			object obj23 = default;
			object obj24 = default;
			object obj25 = default;
			object obj26 = default;
			if (obj23 != null || obj24 != null || obj25 != null || obj26 != null)
			{
				Transform transform = base.transform;
				Vector3 position = ((Transform)obj18).position;
				Quaternion rotation = ((Transform)obj18).rotation;
				Vector3 inHandAt = InHandAt;
				Vector3 vector = (Quaternion)0 * (Vector3)0;
				Quaternion rotation2 = ((Transform)obj18).rotation;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8B738");
				transform.SetPositionAndRotation((Vector3)0, (Quaternion)0);
			}
		}
	}

	private unsafe void Update()
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_009e: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		if (!Live)
		{
			return;
		}
		NetworkObject networkObject = ((SimulationBehaviour)this)._object;
		object obj = networkObject.RuntimeFlags & (Fusion.NetworkObjectRuntimeFlags)2;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
			object obj4 = default;
			object obj3 = obj4 & 1;
			bool flag2 = obj3 == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				return;
			}
			networkObject = ((SimulationBehaviour)this)._object;
			nint num = unchecked((nint)null);
		}
		int* ptr = networkObject.Ptr;
		PlayerRef none = default;
		if (networkObject.Ptr != null)
		{
			NetworkRunner runner = networkObject._runner;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v8 (System.Int32*)+20]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v21+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			none = PlayerRef.None;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none2 = PlayerRef.None;
		if (none == none2 && ((SimulationBehaviour)this)._runner.IsSharedModeMasterClient)
		{
			float unscaledTime = Time.unscaledTime;
			if (!(unscaledTime < nextClaim))
			{
				float unscaledTime2 = Time.unscaledTime;
				float num2 = unscaledTime2 + 1f;
				nextClaim = num2;
				bool flag5 = ((SimulationBehaviour)this)._object.RequestStateAuthority();
			}
		}
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
		//IL_008c: Expected VT, but got I4
		//IL_009d: Expected VT, but got I4
		Holder = _Holder;
		LastHolder = _LastHolder;
		Gone = _Gone;
		GoneAt = _GoneAt;
		Stirred = _Stirred;
		Eats = _Eats;
		EatenBy = _EatenBy;
		PaidTo = _PaidTo;
		InHand = _InHand;
		InHandAt = (Vector3)_InHand;
		InHandTurn = (Quaternion)_InHand;
	}

	public override void CopyStateToBackingFields()
	{
		//IL_00e1: Expected VT, but got F4
		//IL_00ff: Expected VT, but got F4
		PlayerRef holder = Holder;
		_Holder = holder;
		PlayerRef lastHolder = LastHolder;
		_LastHolder = lastHolder;
		NetworkBool gone = Gone;
		_Gone = gone;
		float goneAt = GoneAt;
		_GoneAt = goneAt;
		float num = (_Stirred = Stirred);
		int eats = Eats;
		_Eats = eats;
		byte eatenBy = EatenBy;
		_EatenBy = eatenBy;
		PlayerRef paidTo = PaidTo;
		_PaidTo = paidTo;
		byte inHand = InHand;
		_InHand = inHand;
		Vector3 inHandAt = InHandAt;
		_InHandAt = (Vector3)num;
		Quaternion inHandTurn = InHandTurn;
		_InHandTurn = (Quaternion)num;
	}
}
