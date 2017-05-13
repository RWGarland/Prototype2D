using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 this allows the food to be destroyed in the pot so it wont fall out the bottem of the pot
     */

public class Destroy : MonoBehaviour {

    public GameObject Sprite;

	void OnCollisionEnter(Collision Slot) //just a collider that is not set to trigger
    {
            Destroy(Sprite); //on collition this will destroy the sprite when it enters the pot
    }
    //I had done reserch for another game and then used that to type this piece of code out.
}
