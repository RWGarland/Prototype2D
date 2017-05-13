using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This is primarily used to make particular items disapear from the game window when a buttton is pressed how ever it is also used to make some of the progress bars appear.

public class Surve : MonoBehaviour {

    //gets the objects in the game to be used.

    public GameObject pots;
    public GameObject customer;
    public GameObject load;
    public GameObject load2;
    public Image progressBar;
    public Image progressBar2;
    public float IncreaseAmount;
 


    void Start () {
        pots.SetActive(true); // pot is still visible
        customer.SetActive(true); //customer is still visible
        load.SetActive(false); //load bar is not visible
        load2.SetActive(false); //load bar 2 not visible
	}

    public void potsBtn()
    {
        pots.SetActive(false); //turns off the pot
    }

    public void customerBtn()
    {
        customer.SetActive(false); //turns off the customer
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            load.SetActive(!load.activeSelf); //hit W to bring up load bar

        if (Input.GetKeyDown(KeyCode.R))
            load2.SetActive(!load2.activeSelf); //hit R toi bring up load bar 2

        if (Input.GetKeyDown(KeyCode.E))
        progressBar.fillAmount += IncreaseAmount * Time.deltaTime; //progress bar goes up when e is pressed, i had wanted it to move smoothly on its own but this is the only way have have thought to do it.

        if (Input.GetKeyDown(KeyCode.T))
            progressBar2.fillAmount += IncreaseAmount * Time.deltaTime; // hit T to do the same as above
    }

    public void loadBtn()
    {
        load.SetActive(false); //load img is no longer visible
        load2.SetActive(false); // load 2 no longer visible
    }

    //all of this I had used in another game so i just used that to my advantage to type this out.
}
