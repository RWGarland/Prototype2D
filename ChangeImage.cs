using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This will change the sprites images when the button is pressed
 * In the reference page*/

public class ChangeImage : MonoBehaviour {

    //Sets  the image names
    public Image image;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;


	public void ClickToChange() //sets up the button to change the sprite
    {
        image.sprite = Resources.Load<Sprite>("BreadSpriteChop"); //By clicking this button it allows me to change the sprites of the bread sprite
    }

    public void ClickToChange2() //sets up the button to change the sprite
    {
        image2.sprite = Resources.Load<Sprite>("VedgeSpriteChop"); // when clicking this button it changes the brocolli to the other sprite.
    }

    public void ClickToChange3() //sets up the button to change the sprite
    {
        image3.sprite = Resources.Load<Sprite>("PotSpriteChange"); // changes the middle pot in scene 2
    }

   /* void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
            image5.sprite = Resources.Load<Sprite>("LoadingBar1"); //Click R to change loading bar image not full   //This is what i first had for the loading bar before it got changed as it worked better for the prototype.

    }*/
   //I only needed to see this work for one image and then i worked off of it for the rest of the sprites that i have in my scene.
}
