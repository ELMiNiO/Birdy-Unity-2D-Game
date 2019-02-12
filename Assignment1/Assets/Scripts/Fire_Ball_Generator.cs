using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Ball_Generator : MonoBehaviour
{
    //Array of generation patterns for Fire ball
    public GameObject[] Fire_Ball_Patterns;
    private float Generation_Time;
    //Fire ball generation time
    public float Start_Time_Generation;
    public float Decrease_Time;
    //Minimum time for to generate
    public float Minimum_Time;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Generation_Time <= 0)
        {
            //randomizing fire ball patterns
            int random = Random.Range(0, Fire_Ball_Patterns.Length);
            //fire ball generation
            //randomizing the pattern
            Instantiate(Fire_Ball_Patterns[random], transform.position, Quaternion.identity);
            //adding delaying the auto generation 
            Generation_Time = Start_Time_Generation;
            if (Start_Time_Generation > Minimum_Time)
            {
                Start_Time_Generation -= Decrease_Time;
            }
        }
        else
        {
            Generation_Time -= Time.deltaTime;
        }
    }
}

//References:
//https://www.youtube.com/watch?v=yiXlPP8jOvs
//https://unity3d.com/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game
//https://www.youtube.com/watch?v=FVCW5189evI