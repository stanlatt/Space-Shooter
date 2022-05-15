
using UnityEngine;

public class MapMenuRotateShip : MonoBehaviour
{
    bool canFreeRotate;
    float rotaionSpeed = 5f;



    private void Start()
    {
        canFreeRotate = true;
    }

    private void Update()
    {
        if(canFreeRotate)
        {
            transform.Rotate(0, 1.0f, 0, Space.World);
        } 
    }

    void OnMouseDrag()
    {
        canFreeRotate = false;

        float X_axisRotation = Input.GetAxis("Mouse X") * rotaionSpeed;
        float Y_axisRotation = Input.GetAxis("Mouse Y") * rotaionSpeed;

        transform.Rotate(Vector3.down, X_axisRotation);
        transform.Rotate(Vector3.left, Y_axisRotation);
    }



    public void ResetRotation()
    {
        transform.eulerAngles = new Vector3(30, 157, -2.5f);
        canFreeRotate = true;
    }
}
