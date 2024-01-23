using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchPortal : MonoBehaviour
{
    [SerializeField] private String sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.CompareTag("Player"))
         {
             SceneManager.LoadScene(sceneName);
         }
    }
}
