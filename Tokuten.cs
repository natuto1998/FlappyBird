using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tokuten : MonoBehaviour
{
    public Text tokutenText;
    private int tokuten;

    // Use this for initialization
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        tokutenText.text = tokuten.ToString();
    }

    private void Initialize()
    {
        tokuten = 0;
    }

    public void Addpoint(int point)
    {
        tokuten = tokuten + point;
    }

    public void Save()
    {
        Initialize();
    }

    
    //bool Dead = false;死亡フラグ
    //if(Dead){rerurn;}死亡確認
    //死亡フラグ Dead = true; 当たり判定開始

}

