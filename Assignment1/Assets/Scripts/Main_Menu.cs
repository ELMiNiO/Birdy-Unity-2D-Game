using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Loading diffrent game scenes
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
