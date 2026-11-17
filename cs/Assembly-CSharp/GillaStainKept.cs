using System;
using UnityEngine;

public class GillaStainKept : MonoBehaviour
{
	[NonSerialized]
	public GillaStains.Sheet sheet;

	private void OnDestroy()
	{
		GillaStains.Sheet sheet = this.sheet;
		if (this.sheet != null)
		{
			int users = sheet.users - 1;
			sheet.users = users;
		}
	}
}
