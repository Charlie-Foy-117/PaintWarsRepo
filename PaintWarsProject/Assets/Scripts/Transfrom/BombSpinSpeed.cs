using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpinSpeed : MonoBehaviour
{
    public int rotationSpeed = 0;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed));
    }
}
