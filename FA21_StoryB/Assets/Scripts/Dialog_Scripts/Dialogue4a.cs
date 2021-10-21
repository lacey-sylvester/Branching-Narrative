using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Dialogue4a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    //public GameObject ArtChar1;
    public GameObject CoverBroken;
    public GameObject Cover;
	public GameObject UnderPorch;
	public GameObject Normal_Cicada;
	public GameObject RedEyes;
    //public GameObject Choice1a;
    //public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public GameHandler GameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        Normal_Cicada.SetActive(false);
        Cover.SetActive(true);
		RedEyes.SetActive(false);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
            //ArtChar1.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">You step down the porch to investigate. The cicada screeches like a jet engine.";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
			RedEyes.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">A pair of eyes glow under the eaves of the porch.";
			Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
			RedEyes.SetActive(false);
			Normal_Cicada.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "You are staring right at a person’s face!";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Wh-who are you?!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">Attached to the face is the body of a cicada, crawling towards you with its 6 legs.";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "CICADA MAN";
            Char3speech.text = "hELLo tHeRe LitTle onE…";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "EEEEEEEEK!!!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "CICADA MAN";
            Char3speech.text = "shhHHHhhh...YoU’LL...wAke thE NeiGHbOrs…";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "YOU";
            Char1speech.text = "What are you?!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "CICADA MAN";
            Char3speech.text = "Issssn’t it ObVioUS…?";
		}
		else if (primeInt == 12)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">The creature grins at you, bearing human teeth through its thin lips.";
            Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt == 13)
		{
			Char1name.text = "YOU";
            Char1speech.text = "Wh-why are you here…?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt == 14)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "CICADA MAN";
            Char3speech.text = "BZZZT...Ssssooo maNY qUEstionS...You’RE a CurIOUS littLE oNe aREN't yOU?";
		}
		else if (primeInt == 15)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">The bug seems a bit annoyed. You can tell by the way it furrows it’s human-like eyebrows…";
            Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt == 16)
		{
			Char1name.text = "YOU";
            Char1speech.text = "I...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt == 17)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "CICADA MAN";
            Char3speech.text = "LeT mE ASk YOu sssoMeThiNg...dO you liKe Riddles?";
		}
		else if (primeInt == 18)
		{
			Char1name.text = "YOU";
            Char1speech.text = "R-riddles?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt == 19)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "CICADA MAN";
            Char3speech.text = "i'lL taKe THaT aS a YeSSSsss....";
		}
		else if (primeInt == 20)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">The monster proudly smiles.";
            Char3name.text = "";
            Char3speech.text = "";
		}
		else if (primeInt == 21)
		{
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "CICADA MAN";
            Char3speech.text = "Well… whAt do yoU thiNk CHild?";
            //Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
            //Choice1a.SetActive(true); // function Choice1aFunct()
            //Choice1b.SetActive(true); // function Choice1bFunct()
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
            SceneManager.LoadScene("Scene_4b");
        }
        public void SceneChange2()
        {
            SceneManager.LoadScene("Scene_4c");
        }
    
}                                                                         
