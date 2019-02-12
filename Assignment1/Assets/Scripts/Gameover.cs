using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    //public GameObject high_score;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //HighScore, BUG
            //HigheScore, is not working, I disabled it 
            //DontDestroyOnLoad(high_score);
            //running the game again
            Time.timeScale = 1;
        }
    }
}

//References:
//https://unity3d.com/learn/tutorials/projects/survival-shooter/game-over
