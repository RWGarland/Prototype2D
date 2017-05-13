using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
 * The count down timer that sits on top of the canvus and the top of the game winndow so it is visible to the players.
 * in the refernece page.
 */

public class CountDownTimer : MonoBehaviour {

    public GameObject starScreen; //gets starscreen
    private float timer = 45f; //sets the game for X amount of seconds i'll have it at 45 for the first scene and 7 seconds for the second scene to demonstrate the prototype for what i want to show.
    private Text timerSeconds;
    private bool timerIsActive = true; //the timer is there

	void Start ()
    {
        starScreen.SetActive(false); //Sets the star screen to not be visible
        timerSeconds = GetComponent<Text>(); //this gets the number that has been placed for the timer
	}

    void Update()
    {
        if (timerIsActive) 
        {
            timer -= Time.deltaTime;
            timerSeconds.text = timer.ToString("f0"); //this rounds it all to a rounded number such as 10 and not 10.00

            if (timer <= 0) //the the timer reaches 0
            {
                timer = 0; // the timer is 0
                timerIsActive = false; // with out this and the timer active, the menu flickerd and the timer went into minus numbers.
                starScreen.SetActive(!starScreen.activeSelf); //when the timer reaches 0 this menu will appear.
            }
        }
    }
    //I changed the time length for each scene to make it work properly for my presentation
}
