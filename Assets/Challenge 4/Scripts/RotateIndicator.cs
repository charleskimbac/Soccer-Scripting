using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIndicator : MonoBehaviour
{
    public float speed = .7f;
    void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0));
    }
}
