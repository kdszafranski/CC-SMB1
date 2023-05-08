using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    float yRotate = 2f; 
    [SerializeField]
    float xRotate = 0f;
    [SerializeField]
    float zRotate = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
