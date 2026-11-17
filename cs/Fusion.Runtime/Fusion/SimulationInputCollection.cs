using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Fusion;

internal class SimulationInputCollection
{
	private int _count;

	private readonly SimulationInput[] _byIndex;

	private readonly Dictionary<PlayerRef, SimulationInput> _byPlayer;

	public int Count => _count;

	public SimulationInputCollection(int playerCount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA0C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj3 = this + 24;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v8+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA830]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA828]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v12+A0]");
		object comparer = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<PlayerRef, System.__Canon> dictionary = default;
		dictionary._002Ector((IEqualityComparer<PlayerRef>)comparer);
		object obj10 = this + 32;
		obj10 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public SimulationInput GetByIndex(int index)
	{
		//IL_0012: Expected I4, but got I8
		//IL_002c: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I
		int num = (int)(index & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj == null && _count > index)
		{
			SimulationInput[] byIndex = _byIndex;
			if (_byIndex != null)
			{
				bool flag2 = byIndex.Length < index;
				object obj2 = !flag2;
				object obj3 = byIndex.Length - index;
				bool flag3 = obj3 == null;
				object obj4 = ~obj2;
				object obj5 = obj4 | flag3;
				if (obj5 == null)
				{
					object obj6 = _byIndex + index;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+20]");
					return (SimulationInput)0;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			return (SimulationInput)(object)new IndexOutOfRangeException();
		}
		return null;
	}

	public SimulationInput GetByPlayer(PlayerRef player)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0049: Expected Obj, but got I4
		if ((object)_byPlayer != null)
		{
			PlayerRef key = (PlayerRef)(player & 0xFFFFFFFFL);
			bool flag = ((Dictionary<PlayerRef, System.__Canon>)(object)_byPlayer).TryGetValue(key, out System.__Canon value);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				return (SimulationInput)(object)value;
			}
			return null;
		}
		return (SimulationInput)(object)new NullReferenceException();
	}

	public void Clear()
	{
		Array byIndex = _byIndex;
		_count = 0;
		SimulationInput[] byIndex2 = _byIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v2 (System.Array)+18]");
		Array.Clear(byIndex2, 0, 0);
		((Dictionary<PlayerRef, System.__Canon>)(object)_byPlayer).Clear();
	}

	public void AddInput(SimulationInput input)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_0099: Expected I, but got Obj
		//IL_00ca: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_010f: Expected Obj, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected I4, but got Unknown
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I4
		//IL_01c3: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0232: Expected I, but got Obj
		SimulationInput[] byIndex = _byIndex;
		int count = _count + 1;
		_count = count;
		bool flag = _byIndex == null;
		string text = (string)(object)input;
		IndexOutOfRangeException ex = default;
		if (!flag)
		{
			bool flag2 = _count < byIndex.Length;
			object obj = !flag2;
			text = (string)(object)input;
			if (obj != null)
			{
				goto IL_0263;
			}
			object obj2 = _byIndex + _count;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA860]");
			object obj3 = 0;
			text = (string)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7+20]");
			bool condition = (nint)0 == 0;
			Assert.Check(condition, (string)obj3);
			bool flag3 = input == null;
			nint num = unchecked((nint)null);
			if (!flag3)
			{
				PlayerRef player = input.Player;
				bool flag4 = (object)_byPlayer == null;
				num = unchecked((nint)null);
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA858]");
					object obj4 = 0;
					bool flag5 = ((Dictionary<PlayerRef, System.__Canon>)(object)_byPlayer).ContainsKey(player);
					text = (string)obj4;
					object obj5 = !flag5;
					bool condition2 = (byte)(1 & obj5) != 0;
					Assert.Check(condition2, (string)obj4);
					SimulationInput[] byIndex2 = _byIndex;
					bool flag6 = _byIndex == null;
					num = unchecked((nint)null);
					if (!flag6)
					{
						nint num2 = (nint)byIndex2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v12 (Il2CppClass<Fusion.SimulationInput[]>)+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag7 = ex == null;
						num = unchecked((nint)null);
						if (flag7)
						{
							goto IL_0271;
						}
						bool flag8 = _count < byIndex2.Length;
						object obj6 = !flag8;
						num = unchecked((nint)null);
						if (obj6 != null)
						{
							goto IL_0263;
						}
						object obj7 = _byIndex + _count;
						object obj8 = obj7 + 32;
						obj8 = input;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						PlayerRef player2 = input.Player;
						bool flag9 = (object)_byPlayer == null;
						text = (string)(object)input;
						num = unchecked((nint)null);
						if (!flag9)
						{
							((Dictionary<PlayerRef, System.__Canon>)(object)_byPlayer).Add(player2, (System.__Canon)(object)input);
							return;
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0263;
		IL_0271:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_0263:
		ex = new IndexOutOfRangeException();
		goto IL_0271;
	}
}
