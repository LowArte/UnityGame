using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> Enemys;
    [SerializeField]
    public List<Transform> SpawnPoints;
    [SerializeField]
    public List<GameObject> CurrentEnemys;

    public int maxWaveCount = 5;
    public int currentWawe = 0;
    public int spawnMobsOnWay = 10;
    public int Dificult = 1;

    private int mobOnSpawn;

    void Start()
    {
        mobOnSpawn = (spawnMobsOnWay / SpawnPoints.Count);
    }


    public void SpawnCreeps()
    {
        if(maxWaveCount != currentWawe)
        {
            foreach(var spawn in SpawnPoints)
            {
                StartCoroutine(SpawnCreepOnSpawn(spawn as Transform));
            }
            currentWawe++;
        }
    }

    IEnumerator SpawnCreepOnSpawn(Transform spawn)
    {
        for (int i = 0; i < mobOnSpawn; i++)
        {
            SpawnEnemy(spawn);
            yield return new WaitForSeconds(1.5f);
        }
    }

    public void SpawnEnemy(Transform spawn)
    {
        CurrentEnemys.Add(Instantiate(Enemys[UnityEngine.Random.Range(0, Enemys.Count)], spawn.transform.position, Quaternion.identity));
    }
}
