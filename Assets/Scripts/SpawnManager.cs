using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fallingObjects;
    public int spawnLimitXLeft = 0;
    public int spawnLimitXRight = 0;
    public int spawnLimitZLeft = 0;
    public int spawnLimitZRight = 0;
    private int spawnPosY = 20;
    public float startDelay = 2.0f;
    public float spawnDelay =2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom",startDelay,spawnDelay);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandom()
    {
         Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, Random.Range(spawnLimitZLeft, spawnLimitZRight));

       
        Instantiate(fallingObjects[Random.Range(0,fallingObjects.Length)], spawnPos, fallingObjects[0].transform.rotation);
    }
}
