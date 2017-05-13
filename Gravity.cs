using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This allows the food to be dropped into the pot when it hits the trigger that is on top of the copper pot.
 * In the refernce page*/

public class Gravity : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sprite")
        {
            GameObject.FindWithTag("Sprite").GetComponent<Rigidbody>().isKinematic = false; //This will get triggered when the sprite enters the pot, the sprite will then fall
        }

        if (other.tag == "Sprite2")
        {
            GameObject.FindWithTag("Sprite2").GetComponent<Rigidbody>().isKinematic = false; //This will get triggered when the sprite enters the pot, the sprite will then fall
        }

    }
    // all I mainly had to do was add the tags to the objects in unity its self and then change the names in the code.
}
