using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossHealth : MonoBehaviour
{
    public float bossHealthLife = 100;
    
    void Update()
    {
        if (bossHealthLife == 0)
        {
            SceneManager.LoadScene("Zone1");
        }
    }
}
