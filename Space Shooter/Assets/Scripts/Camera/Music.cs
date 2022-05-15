using UnityEngine;


public class Music : MonoBehaviour
{
	AudioSource audioSource;
	[SerializeField] float volumeVariable;

	void Awake()
	{
		int numMusic = FindObjectsOfType<Music>().Length;

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

	}

    public void SetVolume(float volumeFromSlider)
	{
		volumeVariable = volumeFromSlider;
	}
}
