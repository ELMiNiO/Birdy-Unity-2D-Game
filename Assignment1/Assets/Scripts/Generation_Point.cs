using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_Point : MonoBehaviour {
    public GameObject Fire_Ball;
	// Use this for initialization
	void Start () {
        //generation pos for fire ball
        Instantiate(Fire_Ball, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

//References:
//https://www.youtube.com/watch?v=yiXlPP8jOvs