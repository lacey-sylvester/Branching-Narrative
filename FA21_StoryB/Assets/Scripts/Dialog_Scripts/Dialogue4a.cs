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
      //public Text Char3name;
      //public Text Char3speech;
      public GameObject dialogue;
	  public GameObject ImageName;
	  public GameObject ArtAssets;
	  public GameObject RedEyes;
	  public GameObject Growl;
	  public GameObject Normal;
	  public GameObject OpenMouth;
	  public GameObject NormalDark;
	  public GameObject ArtBGUnderPorch;
	  public GameObject ArtBGCoverBroken;
	  public GameObject ArtBGCover;
	  public GameObject ArtBGCover75;
      public GameObject Choice4b;
      public GameObject Choice4c;
      public GameObject NextScene1Button;
      public GameObject NextScene2Button;
	  public GameObject Choice4d;
	  public GameObject Choice4e;
      public GameObject nextButton;
	  public GameObject TextBox1;
	  public GameObject TextBox2;
	  public GameObject BackFlat;
      public GameHandler gameHandler;
     //public AudioSource audioSource;
      private bool allowSpace = true;

void Start(){         // initial visibility settings
      dialogue.SetActive(false);
	  RedEyes.SetActive(false);
	  Growl.SetActive(false);
	  Normal.SetActive(false);
	  NormalDark.SetActive(false);
	  OpenMouth.SetActive(false);
      ArtBGUnderPorch.SetActive(true);
	  ArtBGCover.SetActive(true);
	  ArtBGCover75.SetActive(false);
	  ArtBGCoverBroken.SetActive(false);
      Choice4b.SetActive(false);
      Choice4c.SetActive(false);
	  Choice4d.SetActive(false);
	  Choice4e.SetActive(false);
      NextScene1Button.SetActive(false);
      NextScene2Button.SetActive(false);
	  //NextScene3Button.SetActive(false);
	  TextBox1.SetActive(false);
	  TextBox2.SetActive(false);
      nextButton.SetActive(true);
	  BackFlat.SetActive(true);
 }

void Update(){         // use spacebar as Next button
      if (allowSpace == true){
              if (Input.GetKeyDown("space")){
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
              ImageName.SetActive(false);
			  RedEyes.SetActive(true);
              dialogue.SetActive(true);
              Char1name.text = "";
              Char1speech.text = " You step down the porch to investigate. The cicada screams like the screech of a jet engine. A pair of eyes glow under the eaves of the porch.";
              Char2name.text = "";
              Char2speech.text = "";
      }
	  
     else if (primeInt ==3){
			ArtBGCover.SetActive(false);
			ArtBGCover75.SetActive(true);
			RedEyes.SetActive(false);
			Normal.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "You are staring right at a person’s face! Attached to the face is the body of a cicada, crawling towards you with its 6 legs";
              Char2name.text = "";
              Char2speech.text = "";
              //gameHandler.AddPlayerStat(1);
      }
	  
     else if (primeInt == 4){
			  ImageName.SetActive(true);
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
			 ImageName.SetActive(false);
			  Char1name.text = "";
              Char1speech.text = "The bug seems a bit annoyed. You can tell by the way it furrows it’s human-like eyebrows…";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	  else if (primeInt == 13){
			ImageName.SetActive(true);
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
              //NextScene1Button.SetActive(true);
			  //NextScene2Button.SetActive(true);
			  //NextScene3Button.SetActive(true);
              Choice4b.SetActive(true); function Choice4bFunct();
              Choice4c.SetActive(true); function Choice4cFunct();
	  }
	  // ENCOUNTER AFTER CHOICE #1
     else if (primeInt == 100){
              Char1name.text = "You";
              Char1speech.text = "Wow... I'm speechless...";
              Char2name.text = "";
              Char2speech.text = "";
      }
	  
	  else if (primeInt == 101){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = " Thank you little one...I haven't shared my poem with someone in a long time…";
	  }
	  
	  else if (primeInt == 102){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "You Have Gerty's nose... ";
	  }
	  
	  else if (primeInt == 103){
              Char1name.text = "You";
              Char1speech.text = "You Knew Gran?";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	  
	  else if (primeInt == 104){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "Yes... She was a sweetie. She listened to me sing for hours under this porch, sipping her tea and solving her crosswords.";
	  }
	  
	  else if (primeInt == 105){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "Poor little lady had a heart attack right here one evening, she never got to finish her last puzzle…";
	  }
	  
	  else if (primeInt == 106){
              Char1name.text = "You";
              Char1speech.text = "Well...it was nice to meet you, Mr. Cicada...I’ll be going now…";
              Char2name.text = "";
              Char2speech.text = "";
	  }
	  
	  else if (primeInt == 107){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = " The name’s Charles, by the way.";
	  }
	  
	  else if (primeInt == 108){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Charles";
              Char2speech.text = "Stop by any time and I’ll sing for you again.";
			  nextButton.SetActive(false);
              allowSpace = false;
              NextScene1Button.SetActive(true);
	  }
	 
			//CHOICE 4C DIRECTION
	  
	 else if (primeInt == 200){
			Normal.SetActive(false);
			Growl.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "BZZZZT hoWW daRREE yoUU??";
      }
	  
	 else if (primeInt == 201){
			ArtBGCover75.SetActive(false);
			ArtBGCoverBroken.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "REEEEEEEEEE";
      }
	  
	 else if (primeInt == 202){
              Char1name.text = "You";
              Char1speech.text = "Holy Sh--";
              Char2name.text = "";
              Char2speech.text = "";
      }
	  
	 else if (primeInt == 203){
			Growl.SetActive(false);
			OpenMouth.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Cicada Man";
              Char2speech.text = "It’ssSSS DInNeR tiME!!";
			  nextButton.SetActive(false);
              allowSpace = false;
              Choice4d.SetActive(true);	function Choice4dFunct();
			  Choice4e.SetActive(true); function Choice4eFunct();
      }
	  
	else if (primeInt == 210){
			ArtAssets.SetActive(false);
			dialogue.SetActive(false);
			TextBox1.SetActive(true);
			NextScene2Button.SetActive(true);
	  }
              
	else if (primeInt == 220){
			ArtAssets.SetActive(false);
			dialogue.SetActive(false);
			TextBox2.SetActive(true);
			NextScene2Button.SetActive(true);		
	  }
}
	  public void Choice4bFunct(){
               Char1name.text = "You";
               Char1speech.text = "good answer*";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 99;
               Choice4b.SetActive(false);
               Choice4c.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
	  }
	  
	  public void Choice4cFunct(){
               Char1name.text = "You";
               Char1speech.text = "What kind of garbage did I just listen to? Were you even trying to rhyme?? Stick to aerating the soil, you freak!";
               Char2name.text = "";
               Char2speech.text = "";
			   primeInt = 199;
               Choice4b.SetActive(false);
               Choice4c.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = (true);
	  }
	  
	  public void Choice4dFunct(){
			  Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
			   primeInt = 209;
               Choice4d.SetActive(false);
               Choice4e.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
	   }
	   
	  public void Choice4eFunct(){
			  Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
			  primeInt = 219;
              Choice4d.SetActive(false);
              Choice4e.SetActive(false);
              nextButton.SetActive(true);
              allowSpace = (true);
	   }
	   
       public void SceneChange1(){
             SceneManager.LoadScene("Scene_5");
      }
	  
      public void SceneChange2(){
             SceneManager.LoadScene("LoseScreen");
      }
}
