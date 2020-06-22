using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
        if (score > 100) {
            print("Boy you bout smart af, obviously that's too high for this grading scale");
        }
        else if (score >= 90){
            print("Issa A");
        }
        else if (score < 90 && score > 80){
            print("Issa B");
        }
        else if (score < 80 && score > 70){
            print("Issa C");
        }
        else if (score < 70 && score > 65){
            print("Issa D");
        }
        else {
            print("Issa E? Tf");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
