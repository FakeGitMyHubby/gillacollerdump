using System;
using PlayFab.ClientModels;

namespace Fusion;

public interface INetworkArray : Action<PayForPurchaseResult>
{
	// C# has no syntax for parameterized property 'Item'.
	object get_Item(int index);

	void set_Item(int index, object value);
}
