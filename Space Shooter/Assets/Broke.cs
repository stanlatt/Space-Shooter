
using UnityEngine;

public class Broke : MonoBehaviour
{
	[SerializeField] int health;


	void OnParticleCollision(GameObject other)
	{
		health--;
		if(health <= 0)
        {
			Rigidbody rb =  gameObject.AddComponent<Rigidbody>();

			if(rb != null)
            {
				Debug.Log("Force added");
				rb.AddForce(Vector3.back, ForceMode.Impulse);
			}
			

			Destroy(gameObject, 2);
        }
	}
}
