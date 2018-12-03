using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //得点加算
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Tokuten>().Addpoint(1);
    }

    /*
     

     */
} 
    