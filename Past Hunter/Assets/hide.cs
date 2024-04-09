using System;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class hide : MonoBehaviour
{
    [SerializeField] private KeyCode hiderKey = KeyCode.E;
    [SerializeField] private Image image;



    

    private void Update()
    {
        
        if (Input.GetKeyDown(hiderKey))
        {
            if(image.enabled)
            {
                image.enabled = false;
            }
            else
            {
                image.enabled = true;
            }
            
        } 
    }

    
}    