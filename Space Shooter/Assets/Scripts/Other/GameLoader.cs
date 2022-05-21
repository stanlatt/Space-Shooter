
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{

	void Start()
	{
		Invoke("FristLevelLoad", 2f);
	}

	void FristLevelLoad()
	{
		SceneManager.LoadScene(1);
	}
}