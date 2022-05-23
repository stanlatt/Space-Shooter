
using UnityEngine;

public class DontDestroyCanvas : MonoBehaviour
{
	void Awake()
	{
		int objects = FindObjectsOfType<DontDestroyCanvas>().Length;

		if (objects > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}
}
