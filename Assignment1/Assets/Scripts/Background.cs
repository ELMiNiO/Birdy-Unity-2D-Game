using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //defining for variables
    public float Speed;
    Material material;
    Vector2 offset;
    public int Velocity_X;

    private void Awake()
    {
        //getting access to the material which is attached to the Background(Quad)
        material = GetComponent<Renderer>().material;
    }

    // Use this for initialization
    void Start()
    {
        //defining the offset
        offset = new Vector2(Velocity_X * Speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //adding offset value to main texture offset
        material.mainTextureOffset += offset * Time.deltaTime;
    }

}



//References:
//https://unity3d.com/learn/tutorials/topics/2d-game-creation/scrolling-repeating-backgrounds
//https://www.youtube.com/watch?v=epRPKFsOPck
//https://www.youtube.com/watch?v=PLMnauJil3g
//https://www.youtube.com/watch?v=HrDxnMI7pCc

