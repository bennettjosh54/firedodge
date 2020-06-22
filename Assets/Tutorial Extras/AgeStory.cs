using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeStory : MonoBehaviour
{

    public string myName = "Josh Bennett";
    public int birthYear = 1995;
    
    // Start is called before the first frame update
    void Start()
    {
        //Problem 1
        print("Your name is: " + myName);

        //Problem 2
        print("Your initials are: " + myName.Substring(0,1) + myName.Substring(5,1));

        //Problem 3
        print("The length of your full name is: " + myName.Length);

        //Problem 4
        int randomNumber = Random.Range(0, myName.Length);
        print("Here is a random letter from your name: " + myName[randomNumber]);

        //Problem 5
        int age = 2020 - birthYear;
        print("You were born in " + birthYear.ToString() + " which means you're " + age.ToString() + " years old.");

        //Problem 6
        int daysAlive = age * 365;
        print("You have been alive for " + daysAlive + " days.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
