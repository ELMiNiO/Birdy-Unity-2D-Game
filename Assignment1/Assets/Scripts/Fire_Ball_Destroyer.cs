using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Ball_Destroyer : MonoBehaviour
{
    public float Destroy_Time;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Dstroyes the game object which this script is attacht to after it reaches Destroy_Time
        Destroy(gameObject, Destroy_Time);
    }
}

//References:
//https://www.youtube.com/watch?v=56pUTFSoESE
//https://answers.unity.com/questions/629355/infinite-runner-tutorial-destroyer-problem.html
//https://forum.unity.com/threads/is-destroying-a-platform-necessary-for-an-infinite-runner.240219/
//https://docs.unity3d.com/ScriptReference/Time.html
//https://forum.unity.com/threads/solved-how-to-measure-execution-time-of-a-function.42013/
//https://answers.unity.com/questions/8967/using-timetime-to-test-the-performance-of-scripts.html