using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float forceJump = 500f;
    private bool ThenTuchPlane = true;
    public Rigidbody rb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (ThenTuchPlane == false)
            {
                rb.AddForce(Vector3.up * forceJump);
            }
            
        } 
    }
}
