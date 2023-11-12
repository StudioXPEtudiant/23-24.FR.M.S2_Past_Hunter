using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] [Range(1,18)] private float _walkSpeed = 13f;
    [SerializeField] [Range(21,30)] private float runSpeed = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        float currentSpeed = _walkSpeed;
        if (Input.GetKey("left shift"))
        {
            currentSpeed = runSpeed;
        }
        transform.Translate(movement * currentSpeed * Time.deltaTime);

    }
}
