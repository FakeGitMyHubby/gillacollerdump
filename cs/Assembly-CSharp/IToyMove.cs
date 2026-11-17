using UnityEngine;

public interface IToyMove
{
	void Live();

	void Taken(int hand);

	bool LetGo(Vector3 velocity);
}
