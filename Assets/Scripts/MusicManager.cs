using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    //called just once as soon as scene starts; once per game
    private void Awake() 
    {

        //ensures that this GameObject(MusicManager) basically maintains itself betweeen scenes
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else {
            Destroy(gameObject);
        }
    }
}
