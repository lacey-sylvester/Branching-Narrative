using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public static int playerSanity = 10;
	
	
    //public GameObject textGameObject;
    //sanity stat
    //void Start () { UpdateScore (); }

    void Update()
    {         //delete this quit functionality when a Pause Menu is added
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void AddPlayerStanity(int amount){
        playerSanity += amount;
        Debug.Log("Current Player Sanity = " + playerSanity);
        //      UpdateScore ();
    }

    public int WhatIsPlayerSanity(){
        return playerSanity;
    }


    //void UpdateScore () {
    //        Text scoreTemp = textGameObject.GetComponent<Text>();
    //        scoreTemp.text = "Score: " + score; }

    public void StartGame()
    {
        SceneManager.LoadScene("intro");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}