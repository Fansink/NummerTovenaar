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
    }

    public void WinGame(string name)
    {
        Application.LoadLevel(name);
    }

    public void LoseGame(string name)
    {
        Application.LoadLevel(name);
    }

}
