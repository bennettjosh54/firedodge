using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public int testNumber;
    public string test;

    void Repeat(string message, int number) {
        for(int i = 0; i < number; i++) {
            print(message);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Repeat(test, testNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
