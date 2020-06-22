using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] hazards;
    
    private float timeBetweenSpawns;
    
    //default is 0 miliseconds
    public float startTimeBetweenSpawns;

    //sets the difficulty level of game
    public float minTimeBetweenSpawns;
    
    public float decrease;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //checks if player is dead, if so it won't spawn enemies
        if (player != null) {
            if (timeBetweenSpawns <= 0) {
            
                //spawn random hazard at random spawn point
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];

                Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);

                timeBetweenSpawns = startTimeBetweenSpawns;

                //is game still easier than max difficulty?
                if (startTimeBetweenSpawns > minTimeBetweenSpawns) {
                    //make the game harder
                    startTimeBetweenSpawns -= decrease;
                }

            }
            else {
                timeBetweenSpawns -= Time.deltaTime;
            }
        }
    }
}
