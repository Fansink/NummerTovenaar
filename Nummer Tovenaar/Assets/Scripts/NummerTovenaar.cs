using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NummerTovenaar : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;
    int nummer;
    int maxGuessAllowed = 10;

    public Text text;

    void Start ()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();
    }

    public void RaadHoger()
    {
        min = guess;
        NextGuess();
    }

    public void RaadLager()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min,max + 1);
        text.text = guess.ToString();
        maxGuessAllowed = maxGuessAllowed - 1;
        if (maxGuessAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
