using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class afficheTotem : MonoBehaviour
{
    public Appledetector accesAppledetector;
    private void Update()
    {
        if (accesAppledetector.activate == true)
        {
            gameObject.SetActive(false);
        }
        
    }

    private void Start()
    {
        gameObject.SetActive(true);
    }
}
