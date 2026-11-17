using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;

namespace Photon.Client;

public class NetworkSimulationSet
{
	private bool isSimulationEnabled;

	private int outgoingLag;

	private int outgoingJitter;

	private int outgoingLossPercentage;

	private int incomingLag;

	private int incomingJitter;

	private int incomingLossPercentage;

	internal PeerBase peerBase;

	private Thread netSimThread;

	private readonly object netSimLock;

	protected internal readonly AutoResetEvent NetSimWakeEvent;

	private int LostPackagesOut__BackingField;

	private int LostPackagesIn__BackingField;

	protected internal unsafe bool IsSimulationEnabled
	{
		get
		{
			return isSimulationEnabled;
		}
		set
		{
			//IL_010d: Expected Obj, but got I4
			//IL_0116: Expected Obj, but got I4
			//IL_0013: Expected Obj, but got I4
			//IL_001c: Expected Obj, but got I4
			//IL_002d: Expected Obj, but got I4
			//IL_0036: Expected Obj, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			//IL_0524: Expected Obj, but got Ref
			//IL_0144: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I4
			//IL_016b: Expected Obj, but got I
			//IL_0185: Expected Obj, but got I
			//IL_0198: Expected I, but got Obj
			//IL_0346: Expected Obj, but got I4
			//IL_054f: Expected Obj, but got I4
			//IL_0558: Expected Obj, but got I4
			//IL_01ad: Expected Obj, but got I
			//IL_00a9: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I4
			//IL_0315: Expected Obj, but got Ref
			//IL_01f8: Expected Obj, but got I4
			//IL_0201: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I4
			//IL_0212: Expected I4, but got Obj
			//IL_036e: Expected Obj, but got I4
			//IL_00e0: Expected Obj, but got I4
			//IL_024b: Expected Obj, but got I4
			//IL_0254: Expected Obj, but got I4
			//IL_025d: Expected Obj, but got I4
			//IL_0308: Expected Obj, but got I4
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected Obj, but got Unknown
			//IL_0284: Expected Obj, but got I
			//IL_02ae: Expected Obj, but got I4
			//IL_02b7: Expected Obj, but got I4
			//IL_02c0: Expected Obj, but got I4
			//IL_02c8: Expected I4, but got Obj
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Expected Obj, but got Unknown
			//IL_048e: Expected Obj, but got I4
			//IL_04dd: Expected Obj, but got I4
			//IL_04e6: Expected Obj, but got I4
			//IL_02e8: Expected Obj, but got I4
			//IL_02f1: Expected Obj, but got I4
			bool lockTaken = default;
			Monitor.Enter(netSimLock, ref lockTaken);
			OutOfMemoryException ex;
			object obj;
			bool flag;
			object obj3;
			object obj4;
			if (isSimulationEnabled == value)
			{
				ex = null;
				obj = 0;
				object obj2 = 0;
				flag = (byte)(&lockTaken) != 0;
				obj3 = 0;
				obj4 = 3;
			}
			else
			{
				isSimulationEnabled = value;
				if (value)
				{
					object obj5 = this + 56;
					if (obj5 != null)
					{
						bool flag2 = NetSimWakeEvent == null;
						ex = null;
						obj = 0;
						object obj2 = 0;
						flag = (byte)(&lockTaken) != 0;
						if (flag2)
						{
							goto IL_0414;
						}
						bool flag3 = NetSimWakeEvent.Set();
						obj2 = 0;
						flag = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4610]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161B8]");
						object obj7 = 0;
						ThreadStart threadStart = default;
						threadStart._002Ector(peerBase, (IntPtr)obj7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4618]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Thread thread = default;
						thread._002Ector(threadStart);
						obj5 = thread;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag4 = obj5 == null;
						ex = null;
						obj = 0;
						object obj9 = 0;
						object obj2 = 0;
						flag = (byte)(int)thread != 0;
						if (flag4)
						{
							goto IL_0422;
						}
						((Thread)obj5).IsBackground = true;
						bool flag5 = obj5 == null;
						ex = null;
						obj = 0;
						obj9 = 0;
						obj2 = 0;
						flag = true;
						if (flag5)
						{
							goto IL_0430;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [65161C0]");
						object obj10 = (((Thread)obj5).Name = (string)0);
						bool flag6 = obj5 == null;
						ex = null;
						obj = 0;
						obj9 = 0;
						obj2 = 0;
						flag = (byte)(int)obj10 != 0;
						if (flag6)
						{
							goto IL_043e;
						}
						((Thread)obj5).Start();
						obj9 = 0;
						obj2 = 0;
						flag = false;
					}
					obj3 = 0;
				}
				else
				{
					bool flag7 = NetSimWakeEvent == null;
					ex = null;
					obj = 0;
					object obj2 = 0;
					flag = (byte)(&lockTaken) != 0;
					if (flag7)
					{
						goto IL_0406;
					}
					bool flag8 = NetSimWakeEvent.Set();
					obj2 = 0;
					flag = false;
					obj3 = 1;
				}
				ex = null;
				obj = 0;
				obj4 = 8;
			}
			goto IL_051c;
			IL_0414:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0422;
			IL_0406:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0414;
			IL_0430:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_043e;
			IL_043e:
			NullReferenceException ex5 = new NullReferenceException();
			if ((flag ? 1 : 0) == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj = 1;
			}
			else
			{
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj11 = default;
				ex = (OutOfMemoryException)obj11;
			}
			obj3 = 0;
			obj4 = 0;
			goto IL_051c;
			IL_051c:
			object obj12 = (object)(&lockTaken);
			if (obj12 != null)
			{
				object obj14 = default;
				object obj13 = (object)(&obj14);
				Monitor.Exit(obj13);
				flag = false;
			}
			bool flag9 = ex == null;
			object obj15 = !flag9;
			if (obj15 == null)
			{
				bool flag10 = obj == null;
				object obj16 = !flag10;
				OutOfMemoryException ex6 = ex;
				if (obj16 == null)
				{
					object obj17 = obj4 | 8;
					if ((nint)obj17 == 8)
					{
						object obj18 = obj3 & 1;
						if (obj18 != null)
						{
							FlushQueuedItems();
						}
					}
					return;
				}
			}
			else
			{
				OutOfMemoryException ex6 = new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0406;
			IL_0422:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0430;
		}
	}

	public int OutgoingLag
	{
		get
		{
			return outgoingLag;
		}
		set
		{
			outgoingLag = value;
		}
	}

	public int OutgoingJitter
	{
		get
		{
			return outgoingJitter;
		}
		set
		{
			outgoingJitter = value;
		}
	}

	public int OutgoingLossPercentage
	{
		get
		{
			return outgoingLossPercentage;
		}
		set
		{
			outgoingLossPercentage = value;
		}
	}

	public int IncomingLag
	{
		get
		{
			return incomingLag;
		}
		set
		{
			incomingLag = value;
		}
	}

	public int IncomingJitter
	{
		get
		{
			return incomingJitter;
		}
		set
		{
			incomingJitter = value;
		}
	}

	public int IncomingLossPercentage
	{
		get
		{
			return incomingLossPercentage;
		}
		set
		{
			incomingLossPercentage = value;
		}
	}

	public int LostPackagesOut
	{
		get
		{
			return LostPackagesOut__BackingField;
		}
		internal set
		{
			LostPackagesOut__BackingField = value;
		}
	}

	public int LostPackagesIn
	{
		get
		{
			return LostPackagesIn__BackingField;
		}
		internal set
		{
			LostPackagesIn__BackingField = value;
		}
	}

	internal unsafe bool ShouldNetSimThreadExit()
	{
		//IL_0022: Expected Obj, but got Ref
		//IL_002b: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got Ref
		//IL_00c8: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got Ref
		//IL_00a9: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		bool lockTaken = default;
		Monitor.Enter(netSimLock, ref lockTaken);
		bool flag = (byte)(~(isSimulationEnabled ? 1u : 0u)) != 0;
		object obj = (object)(&lockTaken);
		object obj2 = 0;
		OutOfMemoryException ex = null;
		if (!flag)
		{
			goto IL_003e;
		}
		object obj3 = this + 56;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj = 0;
		obj2 = 0;
		ex = null;
		bool result = true;
		goto IL_01ba;
		IL_01ba:
		object obj4 = (object)(&lockTaken);
		if (obj4 != null)
		{
			object obj6 = default;
			object obj5 = (object)(&obj6);
			Monitor.Exit(obj5);
			obj = 0;
		}
		bool flag2 = ex == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			bool flag3 = obj2 == null;
			object obj8 = !flag3;
			OutOfMemoryException ex2 = ex;
			if (obj8 == null)
			{
				return result;
			}
		}
		else
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		if ((nint)obj == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj2 = 1;
		}
		else
		{
			if ((nint)obj != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				bool result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj9 = default;
			ex = (OutOfMemoryException)obj9;
		}
		goto IL_003e;
		IL_003e:
		result = false;
		goto IL_01ba;
	}

	private unsafe void FlushQueuedItems()
	{
		//IL_11ac: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got Ref
		//IL_009f: Expected Obj, but got Ref
		//IL_00b4: Expected Obj, but got Ref
		//IL_00c6: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got Ref
		//IL_0132: Expected Obj, but got Ref
		//IL_0147: Expected Obj, but got Ref
		//IL_0159: Expected Obj, but got I4
		//IL_1059: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got Ref
		//IL_01ce: Expected Obj, but got Ref
		//IL_01e3: Expected Obj, but got Ref
		//IL_023a: Expected Obj, but got I4
		//IL_0243: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got Ref
		//IL_0258: Expected Obj, but got Ref
		//IL_026d: Expected Obj, but got Ref
		//IL_02ee: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got Ref
		//IL_0303: Expected Obj, but got Ref
		//IL_0318: Expected Obj, but got Ref
		//IL_0373: Expected Obj, but got I4
		//IL_0380: Expected Obj, but got Ref
		//IL_0388: Expected Obj, but got Ref
		//IL_039d: Expected Obj, but got Ref
		//IL_03c4: Expected I, but got Obj
		//IL_03da: Expected Obj, but got Ref
		//IL_0432: Expected Obj, but got I4
		//IL_043f: Expected Obj, but got Ref
		//IL_0447: Expected Obj, but got Ref
		//IL_045c: Expected Obj, but got Ref
		//IL_03ff: Expected Obj, but got Ref
		//IL_040d: Expected I, but got Obj
		//IL_10fe: Expected Obj, but got I4
		//IL_114d: Expected Obj, but got I4
		//IL_12a4: Expected I, but got Obj
		//IL_0984: Expected Obj, but got I4
		//IL_0965: Expected I, but got Obj
		//IL_09ac: Expected Obj, but got I4
		//IL_09f9: Expected Obj, but got I4
		//IL_0a5f: Expected Obj, but got I8
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0a96: Expected Obj, but got I4
		//IL_12cb: Expected Obj, but got I4
		//IL_0dc1: Expected Obj, but got I8
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Expected Obj, but got Unknown
		//IL_0dd8: Expected Obj, but got I4
		//IL_1322: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I
		//IL_11c4: Expected Obj, but got I4
		//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d2: Expected Obj, but got Unknown
		//IL_0e16: Expected Obj, but got I
		//IL_1232: Expected Obj, but got I4
		//IL_123b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1240: Expected Obj, but got Unknown
		//IL_0c0b: Expected I, but got Obj
		//IL_0c13: Expected Obj, but got I4
		//IL_0c4d: Expected I, but got Obj
		//IL_0ed7: Expected I, but got Obj
		//IL_0edf: Expected Obj, but got I4
		//IL_0f0d: Expected I, but got Obj
		//IL_0f46: Expected I, but got Obj
		//IL_0d11: Expected I, but got Obj
		//IL_0d31: Expected Obj, but got I
		//IL_0d41: Expected Obj, but got I
		//IL_0d58: Expected Obj, but got I
		//IL_0d5c: Expected Obj, but got VT
		//IL_0fb3: Expected I, but got Obj
		//IL_0fd3: Expected Obj, but got I
		//IL_0fe3: Expected Obj, but got I
		PeerBase peerBase = this.peerBase;
		bool flag = this.peerBase == null;
		object obj = null;
		bool flag2 = false;
		object obj2 = null;
		bool lockTaken = false;
		System.__Canon[] array = (System.__Canon[])109924352;
		if (flag)
		{
			goto IL_0ff3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516450]");
		System.__Canon[] array2 = (System.__Canon[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516440]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516190]");
		object obj4 = 0;
		Monitor.Enter(peerBase.NetSimListIncoming, ref lockTaken);
		PeerBase peerBase2 = this.peerBase;
		bool flag3 = this.peerBase == null;
		obj = null;
		flag2 = false;
		int num = 0;
		nint num2 = (nint)(&lockTaken);
		object obj5 = 0;
		OutOfMemoryException ex = null;
		object obj6 = (object)(&obj2);
		object obj7 = (object)(&lockTaken);
		obj2 = peerBase.NetSimListIncoming;
		object obj8 = (object)(&obj2);
		lockTaken = false;
		array = (System.__Canon[])109924352;
		if (flag3)
		{
			goto IL_102c;
		}
		LinkedList<SimulationItem> netSimListIncoming = peerBase2.NetSimListIncoming;
		bool flag4 = peerBase2.NetSimListIncoming == null;
		obj = null;
		flag2 = false;
		num = 0;
		num2 = (nint)(&lockTaken);
		obj5 = 0;
		ex = null;
		obj6 = (object)(&obj2);
		obj7 = (object)(&lockTaken);
		obj2 = peerBase.NetSimListIncoming;
		obj8 = (object)(&obj2);
		lockTaken = false;
		array = (System.__Canon[])109924352;
		if (flag4)
		{
			goto IL_103a;
		}
		num2 = netSimListIncoming.count;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		PeerBase peerBase3 = this.peerBase;
		bool flag5 = this.peerBase == null;
		obj = null;
		flag2 = false;
		num = 0;
		obj5 = 0;
		ex = null;
		obj6 = (object)(&obj2);
		obj7 = (object)(&lockTaken);
		obj2 = peerBase.NetSimListIncoming;
		obj8 = (object)(&obj2);
		lockTaken = false;
		System.__Canon[] array3 = default;
		array = array3;
		if (flag5)
		{
			goto IL_1048;
		}
		bool flag6 = peerBase3.NetSimListIncoming == null;
		obj = null;
		flag2 = false;
		num = 0;
		System.__Canon[] array4 = (System.__Canon[])netSimListIncoming.count;
		obj5 = 0;
		ex = null;
		obj6 = (object)(&obj2);
		obj7 = (object)(&lockTaken);
		obj2 = peerBase.NetSimListIncoming;
		obj8 = (object)(&obj2);
		lockTaken = false;
		array = array3;
		if (flag6)
		{
			goto IL_106c;
		}
		object obj9 = obj3;
		((LinkedList<System.__Canon>)(object)peerBase3.NetSimListIncoming).CopyTo(array3, 0);
		PeerBase peerBase4 = this.peerBase;
		bool flag7 = this.peerBase == null;
		obj = null;
		flag2 = false;
		num = 0;
		array4 = array3;
		obj5 = 0;
		ex = null;
		obj6 = (object)(&obj2);
		obj7 = (object)(&lockTaken);
		obj2 = peerBase.NetSimListIncoming;
		obj8 = (object)(&obj2);
		lockTaken = false;
		array = array3;
		if (flag7)
		{
			goto IL_1088;
		}
		bool flag8 = peerBase4.NetSimListIncoming == null;
		obj = null;
		flag2 = false;
		num = 0;
		array4 = array3;
		obj5 = 0;
		ex = null;
		obj6 = (object)(&obj2);
		obj7 = (object)(&lockTaken);
		obj2 = peerBase.NetSimListIncoming;
		obj8 = (object)(&obj2);
		lockTaken = false;
		array = array3;
		if (!flag8)
		{
			num2 = (nint)obj4;
			((LinkedList<System.__Canon>)(object)peerBase4.NetSimListIncoming).Clear();
			object obj10 = (object)(&lockTaken);
			if (obj10 != null)
			{
				object obj11 = (object)(&obj2);
				Monitor.Exit(obj11);
				num2 = unchecked((nint)null);
			}
			obj = null;
			flag2 = false;
			num = 0;
			obj5 = 0;
			ex = null;
			obj6 = (object)(&obj2);
			obj7 = (object)(&lockTaken);
			obj2 = peerBase.NetSimListIncoming;
			obj8 = (object)(&obj2);
			lockTaken = false;
			array = array3;
			goto IL_100f;
		}
		goto IL_10a4;
		IL_102c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_103a;
		IL_103a:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1048;
		IL_1048:
		NullReferenceException ex4 = new NullReferenceException();
		array4 = (System.__Canon[])num2;
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_106c;
		IL_106c:
		NullReferenceException ex6 = new NullReferenceException();
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_1088;
		IL_1088:
		NullReferenceException ex8 = new NullReferenceException();
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_10a4;
		IL_10a4:
		NullReferenceException ex10 = new NullReferenceException();
		NullReferenceException ex11 = new NullReferenceException();
		NullReferenceException ex12 = new NullReferenceException();
		NullReferenceException ex13 = new NullReferenceException();
		if ((nint)array4 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj5 = 1;
		}
		else
		{
			if ((nint)array4 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj12 = default;
			ex = (OutOfMemoryException)obj12;
		}
		object obj13 = 0;
		bool flag9 = obj7 == null;
		num2 = (nint)array4;
		if (!flag9)
		{
			Monitor.Exit(obj6);
			num2 = unchecked((nint)null);
		}
		bool flag10 = ex == null;
		object obj14 = !flag10;
		if (obj14 != null)
		{
			goto IL_100f;
		}
		bool flag11 = obj5 == null;
		object obj15 = !flag11;
		OutOfMemoryException ex14 = ex;
		if (obj15 == null)
		{
			if ((nint)obj13 != 3)
			{
				bool flag12 = obj13 == null;
				object obj16 = !flag12;
				if (obj16 != null)
				{
					return;
				}
			}
			if (array == null)
			{
				goto IL_0ff3;
			}
			bool flag13 = array.Length < 1;
			OutOfMemoryException ex15 = ex;
			if (flag13)
			{
				goto IL_0d71;
			}
			object obj17 = array.Length & 0xFFFFFFFFL;
			obj3 = array + 32;
			object obj19 = default;
			object obj18 = obj19;
			object obj20 = obj9;
			int num3 = num;
			nint num4 = num2;
			object obj21 = 0;
			object obj22 = obj8;
			OutOfMemoryException ex16 = ex;
			while (true)
			{
				bool flag14 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
				object obj23 = !flag14;
				obj19 = obj18;
				obj9 = obj20;
				num = num3;
				num2 = num4;
				obj4 = obj21;
				obj8 = obj22;
				if (obj23 != null)
				{
					break;
				}
				PeerBase peerBase5 = this.peerBase;
				bool flag15 = this.peerBase == null;
				obj19 = obj18;
				obj9 = obj20;
				num = num3;
				num2 = num4;
				obj4 = obj21;
				obj8 = obj22;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X24_v5+v177 @ X23_v7*8]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					if (peerBase5.PhotonSocket == null)
					{
						goto IL_11ba;
					}
					PeerBase peerBase6 = this.peerBase;
					bool flag16 = this.peerBase == null;
					obj9 = obj20;
					num = num3;
					num2 = num4;
					obj4 = obj21;
					obj8 = obj22;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
						bool flag17 = peerBase6.PhotonSocket == null;
						obj9 = obj20;
						num = num3;
						num2 = num4;
						obj4 = obj21;
						obj8 = obj22;
						if (!flag17)
						{
							bool connected = peerBase6.PhotonSocket.Connected;
							bool flag18 = !connected;
							num4 = unchecked((nint)null);
							ex15 = (OutOfMemoryException)connected;
							if (flag18)
							{
								goto IL_11ba;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X24_v5+v177 @ X23_v7*8]");
							bool flag19 = (nint)0 == 0;
							obj9 = obj20;
							num = num3;
							num2 = unchecked((nint)null);
							obj4 = obj21;
							obj8 = obj22;
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v4+20]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v4+20]");
								bool flag20 = (nint)0 == 0;
								obj9 = obj20;
								num = num3;
								obj4 = obj21;
								obj8 = obj22;
								if (!flag20)
								{
									PeerBase peerBase7 = this.peerBase;
									bool flag21 = this.peerBase == null;
									obj9 = obj20;
									num = num3;
									obj4 = obj21;
									obj8 = obj22;
									if (!flag21)
									{
										nint num5 = (nint)peerBase7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X1_v6 (Il2CppMethodInfo)+18]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v27 (Il2CppClass<Photon.Client.PeerBase>)+238]");
										obj22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v27 (Il2CppClass<Photon.Client.PeerBase>)+240]");
										obj20 = 0;
										PeerBase peerBase8 = this.peerBase;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v4+20]");
										ex15 = (OutOfMemoryException)((Enum)(object)peerBase8).System_002EIConvertible_002EToDecimal((IFormatProvider)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X25_v4+20]");
										num4 = 0;
										goto IL_11ba;
									}
								}
							}
						}
					}
				}
				goto IL_0ff3;
				IL_11ba:
				obj17 = array.Length;
				obj4 = obj21 + 1;
				bool flag22 = (nint)obj4 < array.Length;
				obj9 = obj20;
				num = num3;
				num2 = num4;
				obj8 = obj22;
				obj18 = obj19;
				obj21 = obj4;
				ex16 = ex15;
				if (flag22)
				{
					continue;
				}
				goto IL_0d71;
			}
			goto IL_1001;
		}
		goto IL_101d;
		IL_0d71:
		if (array2 == null)
		{
			goto IL_0ff3;
		}
		if (array2.Length < 1)
		{
			return;
		}
		object obj24 = array2.Length & 0xFFFFFFFFL;
		obj4 = array2 + 32;
		object obj25 = 0;
		while (true)
		{
			bool flag23 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
			object obj26 = !flag23;
			if (obj26 != null)
			{
				break;
			}
			PeerBase peerBase9 = this.peerBase;
			if (this.peerBase != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X23_v4+v136 @ X22_v6*8]");
				obj3 = 0;
				array = (System.__Canon[])(object)peerBase9.PhotonSocket;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				if (peerBase9.PhotonSocket == null)
				{
					goto IL_1228;
				}
				PeerBase peerBase10 = this.peerBase;
				if (this.peerBase != null)
				{
					array = (System.__Canon[])(object)peerBase10.PhotonSocket;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
					if (peerBase10.PhotonSocket != null)
					{
						bool connected2 = peerBase10.PhotonSocket.Connected;
						bool flag24 = !connected2;
						num2 = unchecked((nint)null);
						OutOfMemoryException ex15 = (OutOfMemoryException)connected2;
						if (flag24)
						{
							goto IL_1228;
						}
						PeerBase peerBase11 = this.peerBase;
						bool flag25 = this.peerBase == null;
						num2 = unchecked((nint)null);
						if (!flag25)
						{
							array = (System.__Canon[])(object)peerBase11.PhotonSocket;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
							bool flag26 = obj3 == null;
							num2 = unchecked((nint)null);
							if (!flag26)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X24_v5+20]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X24_v5+20]");
								if ((nint)0 != 0 && peerBase11.PhotonSocket != null)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ X1_v6 (Il2CppMethodInfo)+18]");
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v20 (Il2CppClass<System.__Canon[]>)+198]");
									obj8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v20 (Il2CppClass<System.__Canon[]>)+1A0]");
									obj9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1021 @ X8_v20 (Il2CppClass<System.__Canon[]>)+198] (should have been resolved before IL gen)");
									goto IL_1228;
								}
							}
						}
					}
				}
			}
			goto IL_0ff3;
			IL_1228:
			obj24 = array2.Length;
			obj25++;
			if ((nint)obj25 >= array2.Length)
			{
				return;
			}
		}
		goto IL_1001;
		IL_0ff3:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_1001;
		IL_1001:
		IndexOutOfRangeException ex18 = new IndexOutOfRangeException();
		goto IL_100f;
		IL_100f:
		ex14 = new OutOfMemoryException();
		goto IL_101d;
		IL_101d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_102c;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06f9: Expected Obj, but got I
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
		//IL_049a: Expected Obj, but got Ref
		//IL_0513: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I4
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_04b0: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got Ref
		//IL_0615: Expected Obj, but got I4
		//IL_0625: Expected Obj, but got I4
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_05b2: Expected I, but got Obj
		//IL_05c2: Expected Obj, but got I
		//IL_05eb: Expected Obj, but got I
		//IL_0668: Expected Obj, but got I
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag2)
				{
					goto IL_06b9;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					if (flag4)
					{
						goto IL_06b9;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						obj6 = 0;
						if (flag6)
						{
							goto IL_06b9;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
							obj6 = 0;
							if (flag10)
							{
								goto IL_06b9;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag12 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
								obj6 = 0;
								if (flag12)
								{
									goto IL_06b9;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj30 = default;
								bool flag15 = obj30 == null;
								object obj31 = default;
								obj4 = (object)(&obj31);
								if (!flag15)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag16 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
									obj6 = 0;
									if (flag16)
									{
										goto IL_06b9;
									}
								}
								bool flag17 = array.Length < 5;
								object obj32 = !flag17;
								object obj33 = array.Length - 5;
								bool flag18 = obj33 == null;
								object obj34 = ~obj32;
								object obj35 = obj34 | flag18;
								if (obj35 == null)
								{
									object obj36 = array + 72;
									obj36 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj37 = default;
									bool flag19 = obj37 == null;
									object obj38 = default;
									obj4 = (object)(&obj38);
									if (!flag19)
									{
										nint num7 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
										obj4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag20 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
										obj6 = 0;
										if (flag20)
										{
											goto IL_06b9;
										}
									}
									bool flag21 = array.Length < 6;
									object obj39 = !flag21;
									object obj40 = array.Length - 6;
									bool flag22 = obj40 == null;
									object obj41 = ~obj39;
									object obj42 = obj41 | flag22;
									if (obj42 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6516458]");
										object format = 0;
										object obj43 = array + 80;
										obj43 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										return string.Format((string)format, array);
									}
								}
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj6 = obj4;
			goto IL_06b9;
		}
		goto IL_06d1;
		IL_06d1:
		return (string)(object)new NullReferenceException();
		IL_06b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_06d1;
	}

	public NetworkSimulationSet()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F8F40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64F9090]");
		object obj2 = 0;
		isSimulationEnabled = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E780]");
		outgoingLag = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BE88]");
		incomingJitter = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj3 = default;
		obj3._002Ector();
		object obj4 = this + 64;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		AutoResetEvent autoResetEvent = default;
		autoResetEvent._002Ector(initialState: false);
		object obj5 = this + 72;
		obj5 = autoResetEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
