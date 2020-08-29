using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(direction * speed);
    }
}
