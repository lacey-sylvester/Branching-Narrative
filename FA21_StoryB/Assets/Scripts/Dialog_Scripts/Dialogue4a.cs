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
    public GameObject ArtChar1;
	public GameObject ArtChar1Normal;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
	public GameObject ArtBGCover;
	public GameObject ArtBGCover75;
    //public GameObject Choice1a;
    //public GameObject Choice1b;
    public GameObject NextScene4bButton;
    public GameObject NextScene4cButton;
    public GameObject nextButton;
    public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar1Normal.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
		ArtBGCover.SetActive(false);
		ArtBGCover75.SetActive(false);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene4bButton.SetActive(false);
        NextScene4cButton.SetActive(false);
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

    public void talking(){         // main story function. Players hit next to progress to next int
      primeInt = primeInt + 1;
      if (primeInt == 1){
              // AudioSource.Play();
      }
	  
      else if (primeInt == 2){
              ArtChar1.SetActive(false);
			  //RedEyes.SetActive(true);
              dialogue.SetActive(true);
              Char1name.text = "";
              Char1speech.text = " You step down the porch to investigate. The cicada screams like the screech of a jet engine. A pair of eyes glow under the eaves of the porch.";
              Char2name.text = "";
              Char2speech.text = "";
      }
	  
     else if (primeInt ==3){
			ArtBGCover.SetActive(false);
			ArtBGCover75.SetActive(true);
			//RedEyes.SetActive(false);
			ArtChar1Normal.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "You are staring right at a person’s face! Attached to the face is the body of a cicada, crawling towards you with its 6 legs";
              Char2name.text = "";
              Char2speech.text = "";
              //gameHandler.AddPlayerStat(1);
      }
	  
     else if (primeInt == 4){
			  ArtChar1.SetActive(true);
              Char1name.text = "You";
              Char1speech.text = "The fu--";
              Char2name.text = "";
              Char2speech.text = "";
      }
     else if (primeInt == 5){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = " hELLo tHeRe LitTle onE…";
              //gameHandler.AddPlayerStat(1);
      }
     else if (primeInt == 6){
              Char1name.text = "You";
              Char1speech.text = "EEEEEK";
              Char2name.text = "";
              Char2speech.text = "";
			  gameHandler.AddPlayerStanity(-5);
      }
     else if (primeInt ==7){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "shhHHHhhh...YoU’LL...wAke thE NeiGHbOrs…";
			  if (gameHandler.WhatIsPlayerSanity() < 10){
				  primeInt = 39;
			  }
			  
      }
	  
     else if (primeInt == 8){
			  Char1name.text = "You";
              Char1speech.text = "What are you?";
              Char2name.text = "";
              Char2speech.text = "";
	  }
			  
	 else if (primeInt == 9){
			  Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = " Issssn’t it ObVioUS…?";
	  }
			  
     else if (primeInt == 10){
			  Char1name.text = "You";
              Char1speech.text = "Why are you here?";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	 else if (primeInt == 11){
			  Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "BZZZT...Ssssooo maNY qUEstionS...You’RE a CurIOUS littLE oNE...aren’t YoU?";
	  }
	  else if (primeInt == 12){
			 ArtChar1.SetActive(false);
			  Char1name.text = "";
              Char1speech.text = "The bug seems a bit annoyed. You can tell by the way it furrows it’s human-like eyebrows…";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	  else if (primeInt == 13){
			ArtChar1.SetActive(true);
			  Char1name.text = "You";
              Char1speech.text = "...";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	  
	  else if (primeInt == 14){
			  Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "LeT mE ASk YOu sssoMeThiNg...dO you liKe Riddles?";
	  }
	  
	  else if (primeInt == 15){
			  Char1name.text = "You ";
              Char1speech.text = "Riddles?";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	  
	  else if (primeInt == 16){
			  Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "InsertRiddlePoem here";
			  nextButton.SetActive(false);
              allowSpace = false;
              NextScene4bButton.SetActive(true);
			  NextScene4cButton.SetActive(true);
			  //NextScene3Button.SetActive(true);
              //Choice4b.SetActive(true); function Choice4bFunct();
              //Choice4c.SetActive(true); function Choice4cFunct();
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
    
        public void SceneChange4b()
        {
            SceneManager.LoadScene("Scene_4b");
        }
        public void SceneChange4c()
        {
            SceneManager.LoadScene("Scene_4c");
        }
}                                                                          
