using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenManager : MonoBehaviour
{
    public Animator gameoverBackground;
    public GameObject  GameOverScreen;
    
    void Start()
    {
        gameoverBackground = GetComponent<Animator>();
        gameObject.SetActive(false);
    }
    public void deadScreen()
    {
       Time.timeScale = 1;
        gameObject.SetActive(true);
        gameoverBackground.SetBool("dead",true);
        
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }




    
    void Update()
    {
        
    }
}
