using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Shake : MonoBehaviour
{
    public Animator Camera_Animation;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CameraShake()
    {
        //triggers cemera shake animation
        Camera_Animation.SetTrigger("Shake");
    }
}

//References:
//https://unity3d.com/learn/tutorials/topics/graphics/camera-movement-animation
//https://answers.unity.com/questions/188808/animation-of-the-camera.html
//https://www.youtube.com/watch?v=N24MhfeoUpE