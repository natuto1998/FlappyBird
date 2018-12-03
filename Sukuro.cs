using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukuro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //背景の移動
        if(FindObjectOfType<GameOver>().GameEnd == true)
        {
            transform.Translate(-0.05f, 0, 0);
            if (transform.position.x < -13.8f)
            {
                transform.position = new Vector3(13.8f, 0, 0);
            }
        }        
    }
}
