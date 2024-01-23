using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singelton : MonoBehaviour
{
    private static singelton instance = null;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
