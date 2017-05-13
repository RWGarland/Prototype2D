using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* 
 * This is the text that appears from the critic in his speech bubble, the script allows it to flow out at a constant speed.
 * In the reference page.*/

public class Typewriter : MonoBehaviour {

    public float delay = 0.1f; //the delay of each letter before the next
    public string fullText; //gets whole tect that has been typed out
    private string currentText = ""; //lets me put in the text i want 


    /* void Update()
     {
         if (Input.GetKeyDown("space"))
             StartCoroutine(ShowText()); //This is how i had it origanaly before i added the button to the game
     }*/

    public void SpaceBarBtn()
    {
        StartCoroutine(ShowText()); //allows the text to appear when the button is pushed
    }

    IEnumerator ShowText()
    {
            for (int i = 0; i < fullText.Length; i++) //Gets the length of the full text
            {
                currentText = fullText.Substring(0, i);
                this.GetComponent<Text>().text = currentText;
                yield return new WaitForSeconds(delay); //this then puts everything together to make the letters come one after the other, for what i have typed in the little box
            }
        }
    // i changed this script so it worked when pressing a button because to begin with it would start to type apon clicking play.
}