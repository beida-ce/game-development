using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private int spawnIntervalValue1 = 3;
    private int spawnIntervalValue2 = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        float spawnInterval = Random.Range(spawnIntervalValue1, spawnIntervalValue2);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int ballPrefabIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballPrefabIndex], spawnPos, ballPrefabs[ballPrefabIndex].transform.rotation);
    }

}
