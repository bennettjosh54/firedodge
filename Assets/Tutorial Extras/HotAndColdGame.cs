using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndColdGame : MonoBehaviour
{
    int randomNumber;
    [Range(0, 100)]
    public int guess;
    int numberOfAttempts;

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 101);
        print("Welcome to the Hot and Cold guessing game. ");
        print("A random number between 0 - 100 has been chosen. Find this number in the least amount of attempts possible.");
        print("Enter in your guess and press space bar to submit. Good luck!");


    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown("space")) {
            
            numberOfAttempts += 1;

            if (guess == randomNumber) {
                print("Damn nigga, good job!");
                print("You tried bout got damn " + numberOfAttempts.ToString() + " times!");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 10) {
                print("Almost there");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 20) {
                print("You actually a lil warm bruh");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 30) {
                print("It's getting a little snug");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 40) {
                print("A lil warmer");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 50) {
                print("Lukewarmish");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 60) {
                print("Room temp");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 70) {
                print("The ice is melting");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 80) {
                print("Tap water cold");
            }
            else if (Mathf.Abs(randomNumber - guess) <= 90) {
                print("You in the fridge with this one");
            }
            else {
                print("Nah you FREEZING bruh, ain't nowhere near the number.");
            } 
        }
    }
}
