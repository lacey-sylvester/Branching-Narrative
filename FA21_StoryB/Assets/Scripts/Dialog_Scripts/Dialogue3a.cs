using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Dialogue3a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject Dialogue;
    //public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
    public GameObject ArtBG4;
    public GameObject pondwoman_peek;
    public GameObject pondwoman_grin;
    public GameObject pondwoman_bite;
    //public GameObject Choice1a;
    //public GameObject Choice1b;
    public GameObject NextScene1Button;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    public GameHandler GameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        Dialogue.SetActive(false);
        //ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        ArtBG4.SetActive(false);
        pondwoman_bite.SetActive(false);
        pondwoman_grin.SetActive(false);
        pondwoman_peek.SetActive(false);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
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
            Dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">You follow the smell and continue to drive. It’s a citrus smell, like a woman's perfume.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I recognize this smell...it smells just like...Gran?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">Why is it so strong? It feels as if you aren’t in control of your own actions.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">The stronger the smell, the more your head starts pounding, but you can’t turn around.";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">A woman dressed in all white stands at the side of the road, barely visible.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtBG1.SetActive(true);
            ArtBG2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">As you get closer to her she disappears.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">You continue driving and see her again.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtBG1.SetActive(true);
            ArtBG2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">Gone. There she is. Gone again.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Arrgh!";
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
            Char2speech.text = ">Your headache turns unbearable and you pull the car over. The comforting aroma decays to garbage and waste.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Ugh…Are these the migraines my doctor told me about? Maybe a walk in the woods will help.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtBG1.SetActive(false);
            ArtBG3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">The rotten smell gets stronger.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Your walk leads you to a pond as dark as sludge.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtBG3.SetActive(false);
            pondwoman_peek.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">A woman’s head breaks the surface.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
            pondwoman_peek.SetActive(false);
            pondwoman_grin.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">Her lizard eyes stare at you and she grins.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 17)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "WOMAN";
            Char3speech.text = "You really should listen better.";
        }
        else if (primeInt == 18)
        {
            Char1name.text = "YOU";
            Char1speech.text = "W-what?";
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
            Char2speech.text = ">Cold hands clamp onto your shoulders. The woman in white hides in the corner of your eyes.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">She grins and you feel a push. Face down in the black goo.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 21)
        {
            pondwoman_grin.SetActive(false);
            pondwoman_bite.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "H-hey! What the-";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">You thrash about helplessly. Every movement sinks you further into the muck.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 23)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">Exhaustion takes over.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 24)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "WOMAN";
            Char3speech.text = "HEHEHEHEHE!";
        }
        else if (primeInt == 25)
        {
            pondwoman_bite.SetActive(false);
            ArtBG4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">The woman drags you under the surface. The waste burns your eyes.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 26)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = ">Every breath is a mouthful of sludge. All you can hear is cackling...";
            Char3name.text = "";
            Char3speech.text = "";
        //Turn off "Next" button, turn on "Choice" buttons
        nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            //NextScene2Button.SetActive(true);
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
        SceneManager.LoadScene("LoseScreen");
    }

}