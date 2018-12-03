using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dokan : MonoBehaviour
{
    GameObject GameEndboll;     

    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //土管をランダムに表示
        {
            if (FindObjectOfType<GameOver>().GameEnd == true)
            {
                transform.Translate(-0.05f, 0, 0);
                if (transform.position.x < -13f)
                {
                    transform.position = new Vector3(7.5f, UnityEngine.Random.Range(-3f, 1f), 0);
                }
            }
            
        }
    }
}
