
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
	void Awake()
	{
		int objects = FindObjectsOfType<DontDestroyOnLoad>().Length;

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
