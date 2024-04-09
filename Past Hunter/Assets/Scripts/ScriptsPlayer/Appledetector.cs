using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Appledetector : MonoBehaviour
{
    public bool apple_ok = false;
    private bool ok_one_apple = false;
    public bool activate = false;
    
    private void Start()
    { 
        activate = false;
    }
    
    //[SerializeField] private int appleCount = 0;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("special"))
        {
            apple_ok = true; 
            Debug.Log("voila");
            activate = true;
        }
    }
    
}
