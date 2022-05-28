
using UnityEngine;

public class MapMenuRotateShipHologramm : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 1.0f, 0, Space.World);
    }
}
