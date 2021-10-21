using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Dialogue4c : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject Dialogue;
    public GameObject Cicada_Normal;
    public GameObject Cicada_Mouth;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    //public GameObject Choice1a;
    //public GameObject Choice1b;
    public GameObject ButtonSceneChange1;
    public GameObject ButtonNext;
    public GameHandler GameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        Cicada_Normal.SetActive(true);
        Cicada_Mouth.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        ButtonSceneChange1.SetActive(false);
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
            // AudioSour ce.Play();
        }
        else if (primeInt == 2)
        {
            //ArtChar1.SetActive(true);
            Dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "What kind of garbage did I just listen to?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Were you even trying to rhyme?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Stick to aerating the soil, you freak!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = ">The cicada man whimpers in disappointment.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Well, that was a waste of time, better get back to unpacking-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Cicada_Mouth.SetActive(true);
            Cicada_Normal.SetActive(false);
            Char1name.text = "";
            Char1speech.text = ">The cicada growls and hisses.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "CICADA MAN";
            Char2speech.text = "BZZZZT hoWW daRREE yoUU??";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = ">The monster becomes enraged and it’s wings vibrate furiously.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "CICADA MAN";
            Char2speech.text = "REEEEEEEEEE";
        }
        else if (primeInt == 11)
        {
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = ">The cicada grows twice in size and breaks through the porch.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = ">You try to run but it pounces and pins you down.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "YOU";
            Char1speech.text = "HOLY SH-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = ">The cicada opens its mouth wide.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "CICADA MAN";
            Char2speech.text = "It’ssSSS DInNeR tiME!! *CRUNNNNCH*";
            //Turn off "Next" button, turn on "Choice" buttons
            ButtonSceneChange1.SetActive(true);
            ButtonNext.SetActive(false);
            allowSpace = false;
            //ButtonSceneChange2.SetActive(true);
            //ButtonSceneChange3.SetActive(true);
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
        }

        public void SceneChange1()
        {
            SceneManager.LoadScene("LoseScreen");
        }
}

