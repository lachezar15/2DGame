using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnits : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject playerHelper;

    public void SpawnUnit1()
    { 
        int randPos = Random.Range(0, spawnPoints.Length);

        Instantiate(playerHelper, spawnPoints[randPos].position, Quaternion.identity);
    }
}
