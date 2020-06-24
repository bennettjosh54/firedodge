using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundGenerator : MonoBehaviour
{

    private AudioSource source;
    public AudioClip[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        int randomSound = Random.Range(0, sounds.Length);

        //set the actual played sound clip to a random index from the AudioClips array
        source.clip = sounds[randomSound];
        source.Play();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
