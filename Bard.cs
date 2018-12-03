using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bard : MonoBehaviour {

    // Use this for initialization
    public float Jump; //ジャンプするというものを作る
    public Rigidbody2D rb;
    

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //鳥をジャンプさせる    
        if (FindObjectOfType<GameOver>().GameEnd == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector2(0, Jump);
            }
        }
    }
}
