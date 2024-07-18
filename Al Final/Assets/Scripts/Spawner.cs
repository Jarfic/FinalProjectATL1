using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int counter;
    public GameObject[] enemies;
    public int xRange;
    public int yRange;
    public int zRange;
    public float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies",1,3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemies()
    {
        
        if(--counter == 0) CancelInvoke("SpawnEnemies");
        Instantiate(enemies[Random.Range(0,enemies.Length)], new Vector3(Random.Range(xRange-5,xRange+5),yRange,Random.Range(zRange-5,zRange+5)), Quaternion.identity);
    }
}
