using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Ball : MonoBehaviour
{
    //How much health you lose
    public int Damage;
    //How fast the fire ball is moving
    public float Speed;
    //Praticle effect for when Bird colides with fire ball
    public GameObject Particle_Effect;
    private Camera_Shake shake;
    public GameObject Sound_Effect;
    // Use this for initialization
    void Start()
    {
        //getting component for camera shake
        shake = GameObject.FindGameObjectWithTag("Camera_Screen_Shake").GetComponent<Camera_Shake>();
    }

    // Update is called once per frame
    void Update()
    {
        //Fire ball move function
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }

    //Function get's called whenever fire ball collied with another object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check to see if the fire ball has collided with bird
        if (collision.CompareTag("Bird"))
        {
            //Didn't work
            //There is bug for explosion sound effect
            //When you start the game, you can hear one explosion, even tough the Bird has not collided with fir ball
            //I trited to fix it, with time delay funcation.But couldn't get it to work
            //Invoke(Instantiate(Sound_Effect, transform.position, Quaternion.identity),1);
            //sound effect
            Instantiate(Sound_Effect, transform.position, Quaternion.identity);
            //Display particel effect when fire ball collided with bird
            Instantiate(Particle_Effect, transform.position, Quaternion.identity);
            //Player loses health
            collision.GetComponent<Bird>().Health -= Damage;
            //camera shake
            shake.CameraShake();
            //Destroying bird game object
            Destroy(gameObject);

        }
    }
}

//References:
//https://answers.unity.com/questions/691547/random-obstacle-generator.html
//https://www.youtube.com/watch?v=yiXlPP8jOvs
//https://forum.unity.com/threads/c-generator-obstacles.239581/
//https://www.youtube.com/watch?v=FVCW5189evI