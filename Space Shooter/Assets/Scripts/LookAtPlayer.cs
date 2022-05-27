
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    Transform playerRig;

    // Start is called before the first frame update
    void Start()
    {
        playerRig = GameObject.Find("Player Rig").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.LookAt(playerRig);
    }
}
