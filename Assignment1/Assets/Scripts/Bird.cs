using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    //defining for variables
    //For Bird new position
    private Vector2 New_Position;
    public float UP_Key_Power;
    //Bird movment speed
    public float Speed;
    //For setting the size of screen
    public float Screen_Max_Hight;
    public float Screen_Min_Hight;
    //Health display and counting
    public int Health;
    public Text Health_Display;
    public GameObject gameover;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Displaying our text
        Health_Display.text = "Health: " + Health.ToString();
        if (Health <= 0)
        {
            gameover.SetActive(true);
            Destroy(gameObject);
            //stopping the game
            Time.timeScale = 0;
        }
        //Bird changing position
        // * Time.deltaTime -> The player moves with same speed in different computers(Strong or weak)
        transform.position = Vector2.MoveTowards(transform.position, New_Position, Speed * Time.deltaTime);
        //check if the player has pressed UP arrow key
        //Also check that the Bird doen't go off screen
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < Screen_Max_Hight)
        {
            //Changing only Y position of the bird
            //Position X stays the same cause we only want to move our,character up
            New_Position = new Vector2(transform.position.x, transform.position.y + UP_Key_Power);
            //transform.position = New_Position;
        }
        //check if the player has pressed DOWN arrow key
        //Also check that the Bird doen't go off screen
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > Screen_Min_Hight)
        {
            //Same funcation as UP key the only difference is that we changed to pluse to minus
            //transform.position.y - UP_Key_Power
            //Position X stays the same
            New_Position = new Vector2(transform.position.x, transform.position.y - UP_Key_Power);
            //transform.position = New_Position;
        }
    }
}

//References:
//https://www.youtube.com/watch?v=VAyWk0eIqRc
//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial/controlling-player
//https://unity3d.com/learn/tutorials/topics/2d-game-creation/player-controller-script
//https://unity3d.com/learn/tutorials/topics/2d-game-creation/2d-character-controllers
//https://www.youtube.com/watch?v=dwcT-Dch0bA
//https://www.youtube.com/watch?v=5M7vX_z6B9I
//https://www.youtube.com/watch?v=GrQalFLtQT4
