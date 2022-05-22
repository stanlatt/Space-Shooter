using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 0.1f;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, rotationSpeed);
    }
}
