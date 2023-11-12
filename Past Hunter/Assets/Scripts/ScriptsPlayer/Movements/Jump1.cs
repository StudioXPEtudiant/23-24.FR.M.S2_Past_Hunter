using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump1 : MonoBehaviour
{
    [SerializeField] private float forceJump = 500;
    public Rigidbody rb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forceJump);
            
        } 
    }
}
