using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score;
    public Text scoreText;
    
    void Start()
    {
        Score = 0;
    }

    
    void Update()
    {
        scoreText.text = Score.ToString(); 
    }
}
