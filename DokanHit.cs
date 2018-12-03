using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DokanHit : MonoBehaviour
{
    private bool gameOver = false;
    public Text gameOverText;  
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameOver>().Addpoint(true);
        gameOverText.enabled = true;
        Debug.Log("眠い");        
    }

    
}

