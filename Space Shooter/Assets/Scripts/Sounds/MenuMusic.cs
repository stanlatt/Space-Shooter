using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuMusic : MonoBehaviour
{
	AudioSource audioSource;
	[SerializeField] float volumeVariable;

	void Awake()
	{
		int numMusic = FindObjectsOfType<MenuMusic>().Length;

		if (numMusic > 1)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}

    private void Start()
    {
		audioSource = GetComponent<AudioSource>();
		volumeVariable = 0.05f;

	}

    private void Update()
    {
		audioSource.volume = volumeVariable;

		if(SceneManager.GetActiveScene().buildIndex >= 2)
        {
			Destroy(gameObject);
        }

	}

    public void SetVolume(float volumeFromSlider)
	{
		volumeVariable = volumeFromSlider;
	}
}
