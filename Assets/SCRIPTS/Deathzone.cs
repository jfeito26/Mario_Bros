using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathzone : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}