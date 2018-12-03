using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    // Use this for initialization

    private CanvasGroup gameoverText_CG;
    public bool GameEnd = true;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void Addpoint(bool face)
    {
        GameEnd = false;
        transform.position = new Vector3(-0.65f, 0, 0);
        GameObject gameoverText = GameObject.Find("Canvas/GameOver");
        gameoverText_CG = gameoverText.GetComponent<CanvasGroup>();
        gameoverText_CG.alpha = 1;
        if (Input.GetMouseButtonDown(0))
        {
            Reload();
        }
    }
    void Reload()
    {
        //再読み込み
        Scene loadscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadscene.name);       
    }
}
