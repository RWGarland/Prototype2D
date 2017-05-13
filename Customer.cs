using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This is the customer panel that will slide in from the right of the screen
 * In the refernce page*/

public class Customer : MonoBehaviour {

    private Vector3 newPosition;

    void Awake()
    {
        newPosition = transform.position; // the position of the item is now where it gets moved to.
    }

    void Update()
    {
        PositionChanging(); //uses the change position
    }

    void PositionChanging()
    {
        Vector3 position = new Vector3(1690, 1075, 0); //puts in the new transform for the object to move to

        if (Input.GetKeyDown(KeyCode.Q)) //push Q to make the object start its movement 
            newPosition = position;

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime); //a lurp to smoothly move the object to its new tranform using (from, to, time)
    }
    //this was mainly from a unity tutorial that i have refurenced how ever i changed it to fit my needs by adding the get key down and changed the vector positions so it works on my game screen.
}
