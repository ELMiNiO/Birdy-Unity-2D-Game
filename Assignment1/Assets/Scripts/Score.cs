using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    //public int highscore;
    public Text scoreDisplay;
    //public Text highscoreDisplay;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //setting the highscore
        //if (score > highscore)
        //{
            //highscore = score;
        //}
        //changing score to string and display it
        scoreDisplay.text = "Score: " + score.ToString();
        //highscoreDisplay.text = "High Score: " + highscore.ToString();
    }
    //check to see if the bird has passed the obssticel
    //I put a box at the end of screen 
    //It can detect the fireballs that are going out of screen
    //that way I calculate the score
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check to see if the fire ball has collided with bird
        if (collision.CompareTag("FireBall"))
        {
            //increase the score by 1
            score++;
        }
    }
}
