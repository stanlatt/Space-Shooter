
using UnityEngine;

public class Battery : MonoBehaviour
{
	public int batteryHp = 1;
	[SerializeField] ParticleSystem explosionFX;
	[SerializeField] ParticleSystem smokeFX;
	[SerializeField] GameObject innerCylinder;
	[SerializeField] GameObject Cylinder;

	bool alive;


    private void Start()
    {
		alive = true;

		innerCylinder.GetComponent<Renderer>().material.color = Color.green;
	}

    private void FixedUpdate()
    {
		if(alive)
        {
			Cylinder.transform.Rotate(0, 0, 0.1f);
		}
	}

    void OnParticleCollision(GameObject other)
	{
		batteryHp--;
		if(batteryHp <= 0)
        {
			BatteryDestroyed();
		}
	}

	void BatteryDestroyed()
    {
		alive = false;

		explosionFX.Play();
		smokeFX.Play();
		innerCylinder.GetComponent<Renderer>().material.color = Color.red;
	}


}
