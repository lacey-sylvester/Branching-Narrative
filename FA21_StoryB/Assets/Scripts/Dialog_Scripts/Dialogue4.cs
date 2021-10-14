using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Dialogue4 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Text_Char1speech;
    public Text Char2name;
    public Text Text_Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject Button_Choice4a;
    public GameObject Button_Choice4b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject Button_Next;
    //public GameHandler GameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Button_Choice4a.SetActive(false);
        Button_Choice4b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        Button_Next.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "Jeda";
            Text_Char1speech.text = "Wakey wakey, human.";
            Char2name.text = "";
            Text_Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Text_Char1speech.text = "";
            Char2name.text = "You";
            Text_Char2speech.text = "Wuh..? What happened?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "Jeda";
            Text_Char1speech.text = "I know I did not hit you that hard.";
            Char2name.text = "";
            Text_Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Text_Char1speech.text = "";
            Char2name.text = "You";
            Text_Char2speech.text = "Hit me? Why?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "Jeda";
            Text_Char1speech.text = "I am searching for a fugitive. Ragu Fahn.";
            Char2name.text = "";
            Text_Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Text_Char1speech.text = "";
            Char2name.text = "You";
            Text_Char2speech.text = "Why do you think I know anything?";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "Jeda";
            Text_Char1speech.text = "Do not play the stupid. You will take me to him.";
            Char2name.text = "";
            Text_Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            Button_Next.SetActive(false);
            allowSpace = false;
            Button_Choice4a.SetActive(true); // function Button_Choice4aFunct()
            Button_Choice4b.SetActive(true); // function Button_Choice4bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "Jeda";
            Text_Char1speech.text = "Then you are no use to me, and must be silenced.";
            Char2name.text = "";
            Text_Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "Jeda";
            Text_Char1speech.text = "Come back here! Do not think you can hide from me!";
            Char2name.text = "";
            Text_Char2speech.text = "";
            Button_Next.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "Jeda";
            Text_Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
            Char2name.text = "";
            Text_Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Text_Char1speech.text = "";
            Char2name.text = "You";
            Text_Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
            Button_Next.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Button_Choice4aFunct()
    {
        Char1name.text = "";
        Text_Char1speech.text = "";
        Char2name.text = "You";
        Text_Char2speech.text = "I don't know what you're talking about!";
        primeInt = 99;
        Button_Choice4a.SetActive(false);
        Button_Choice4b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }
    public void Button_Choice4bFunct()
    {
        Char1name.text = "";
        Text_Char1speech.text = "";
        Char2name.text = "You";
        Text_Char2speech.text = "Sure, anything you want... just lay off the club.";
        primeInt = 199;
        Button_Choice4a.SetActive(false);
        Button_Choice4b.SetActive(false);
        Button_Next.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}