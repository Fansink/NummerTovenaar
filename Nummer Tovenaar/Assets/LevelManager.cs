using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void StartGame(string name)
    {
        Application.LoadLevel(name);
    }

    public void QuitGame(string name)
    {
        Application.Quit();
        //Debug.Log("I want to quit");
    }

}
