using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carspawner : MonoBehaviour
{
    public float spawnDelay = 0.3f;
    float nextTimeToStart = 0f;
    public GameObject car;
    public Transform[] spawnPoints; // we use Transform beause we only need position and routation!

    void Update()
    {
      if(nextTimeToStart <= Time.time)
      {
        Spawncar();
        nextTimeToStart = Time.time + spawnDelay;
      }
    }

    void Spawncar()
    {
      int randomIndex = Random.Range(0, spawnPoints.Length); // random choose spawnpoint between 4 of them! // get random number from 0 to 3
      Transform spawnPoint = spawnPoints[randomIndex]; //insert it to spawnpoint and make it working
      GameObject Car = Instantiate(car, spawnPoint.position, spawnPoint.rotation);
      Destroy(Car, 2f);
    }
  }
