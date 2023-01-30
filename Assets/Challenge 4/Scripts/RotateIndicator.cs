using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIndicator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 3, 0));
    }
}
