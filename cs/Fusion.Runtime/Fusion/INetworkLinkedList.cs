using System;
using PlayFab.ClientModels;

namespace Fusion;

public interface INetworkLinkedList : Action<OpenTradeResponse>
{
	void Add(object item);
}
