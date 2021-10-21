using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Dialogue1a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject Dialogue;
    public GameObject ArtChar1;
    public GameObject ArtBG;
    public GameObject ArtBG2;
    //public GameObject Choice1a;
    //public GameObject Choice1b;
    public GameObject ButtonSceneChange1;
	//public GameObject ButtonSceneChange2;
	//public GameObject ButtonSceneChange3;
    public GameObject ButtonNext;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        //ArtChar1.SetActive(false);
        ArtBG.SetActive(true);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        ButtonSceneChange1.SetActive(false);
		//ButtonSceneChange2.SetActive(false);
		//ButtonSceneChange3.SetActive(false);
        ButtonNext.SetActive(true);
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
            Dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Wow...I’m speechless… *slow clap*";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cicada Man";
            Char2speech.text = "Thank you little one...I haven't shared my poem with someone in a long time…";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "> You wonder if Gran ever heard this thing…";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cicada Man";
            Char2speech.text = " You have Gerty’s nose…";
		}
else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "You knew Gran?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cicada Man";
            Char2speech.text = "Yes...she was a sweetie. She listened to me sing for hours under this porch, sipping her tea and solving her crosswords.";
        }				
		else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cicada Man";
            Char2speech.text = "Poor little lady had a heart attack right here one evening, she never got to finish her last puzzle…";
        }				
		else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "> You remember the unfinished puzzle you found on the porch. Could that be Gran’s last puzzle?";
            Char2name.text = "";
            Char2speech.text = "";
        }				
		else if (primeInt == 10)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Well...it was nice to meet you, Mr. Cicada...I’ll be going now…";
            Char2name.text = "";
            Char2speech.text = "";
        }				
		else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cicada Man";
            Char2speech.text = "The name’s Charles, by the way…";
        }				
		else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Charles";
            Char2speech.text = "Stop by any time and I’ll sing for you again.";
			 //Turn off "Next" button, turn on "Choice" buttons
            ButtonNext.SetActive(false);
            allowSpace = false;
            ButtonSceneChange1.SetActive(true);
            //ButtonSceneChange2.SetActive(true);
			//ButtonSceneChange3.SetActive(true);
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
		}				
		else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }				
			
           
        }
        //    // ENCOUNTER AFTER CHOICE #1
        //    else if (primeInt == 100)
        //    {
        //        Char1name.text = "Jeda";
        //        Char1speech.text = "Then you are no use to me, and must be silenced.";
        //        Char2name.text = "";
        //        Char2speech.text = "";
        //    }
        //    else if (primeInt == 101)
        //    {
        //        Char1name.text = "Jeda";
        //        Char1speech.text = "Come back here! Do not think you can hide from me!";
        //        Char2name.text = "";
        //        Char2speech.text = "";
        //        nextButton.SetActive(false);
        //        allowSpace = false;
        //    }

        //    else if (primeInt == 200)
        //    {
        //        Char1name.text = "Jeda";
        //        Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
        //        Char2name.text = "";
        //        Char2speech.text = "";
        //    }
        //    else if (primeInt == 201)
        //    {
        //        Char1name.text = "";
        //        Char1speech.text = "";
        //        Char2name.text = "You";
        //        Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
        //        nextButton.SetActive(false);
        //        allowSpace = false;
        //    }
        //}

        //// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        //public void Choice1aFunct()
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "You";
        //    Char2speech.text = "I don't know what you're talking about!";
        //    primeInt = 99;
        //    //Choice1a.SetActive(false);
        //    //Choice1b.SetActive(false);
        //    nextButton.SetActive(true);
        //    allowSpace = true;
        //}
        //public void Choice1bFunct()
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "You";
        //    Char2speech.text = "Sure, anything you want... just lay off the club.";
        //    primeInt = 199;
        //    //Choice1a.SetActive(false);
        //    //Choice1b.SetActive(false);
        //    nextButton.SetActive(true);
        //    allowSpace = true;
        //}
    }
        public void SceneChange1()
        {
            SceneManager.LoadScene("Scene_5");
        }
    
}
