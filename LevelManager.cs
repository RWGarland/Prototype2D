using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//Keeps track of level managing so all the buttons work

public class LevelManager : MonoBehaviour {

    public void startLevel()
    {
        SceneManager.LoadScene("CookingProto"); //Starts the level with Cooking proto
    }

    public void replay()
    {
        SceneManager.LoadScene("CookingProto"); //Allows the me to replay once it is finished
    }

    public void nextLevelBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel); //Laods the next scene for demonstrations
    }

    //I was able to use the code that i have from another game to get the scene management to work.
}
