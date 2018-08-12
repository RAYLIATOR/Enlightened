using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;
    int textLevel;
    float updateRate;
    float nextTimeToUpdate;
    int levels;
    void Start ()
    {
        nextTimeToUpdate = 0f;
        updateRate = 0.2f;
        textLevel = 0;
        levels = 7;
	}
	
	void Update ()
    {
        /*if (Input.GetKeyDown(KeyCode.Return))
        {
            textLevel += 1;
        }*/
        if(Time.time>=nextTimeToUpdate && textLevel < levels)
        {
            textLevel += 1;
            nextTimeToUpdate = Time.time + 1 / updateRate;
        }
		switch(textLevel)
        {
            case 1: tutorialText.text = "Welcome Player.";
                break;
            case 2: tutorialText.text = "Use the W, A, S and D keys to move.";
                break;
            case 3: tutorialText.text = "Use the mouse to aim and look around";
                break;
            case 4: tutorialText.text = "Use the left mouse button to shoot.";
                break;
            case 5: tutorialText.text = "The red bar in the top-left of the screen displays your character's health.";
                break;
            case 6: tutorialText.text = "Press Escape to pause the game at anytime.";
                break;
            case 7: tutorialText.text = "";
                break;
            case 8: tutorialText.text = "";
                break;
            case 9: tutorialText.text = "";
                break;
            case 10: tutorialText.text = "";
                break;
            case 11: tutorialText.text = "";
                break;
        }
	}
}
