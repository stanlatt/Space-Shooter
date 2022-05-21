using UnityEngine.SceneManagement;
using UnityEngine;

public class Lvl_1_Music : MonoBehaviour
{
	void Awake()
	{
		int numMusic = FindObjectsOfType<Lvl_1_Music>().Length;

		if (numMusic > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}

	private void Update()
	{
		if (SceneManager.GetActiveScene().buildIndex != 2)
		{
			Destroy(gameObject);
		}
	}
}
