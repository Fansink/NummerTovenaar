using UnityEngine;
using System.Collections;

public class NummerTovenaar : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;
    int nummer;

    void Start ()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min, max);

        print("==============================");
        print("Welkom bij de Nummer Tovenaar!");
        print("Neem een nummer in je gedachten, maar vertel hem niet!!");

        print("Het hoogste getal dat je mag kiezen is " + max);
        print("Het laagste getal dat je mag kiezen is " + min);

        print("Is het getal hoger of lager dan " + guess + "?");
        print("Pijltje omhoog voor hoger, Pijltje omlaag voor lager en enter als het getal gelijk is.");

        max = max + 1;
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("Jeeej ik heb gewonnen!!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Is het getal hoger of lager dan " + guess + "?");
        print("Pijltje omhoog voor hoger, Pijltje omlaag voor lager en enter als het getal gelijk is.");
    }
}
