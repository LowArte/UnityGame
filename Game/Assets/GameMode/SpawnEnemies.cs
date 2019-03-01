using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.Linq;

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
    /// <summary>
    /// Спавнит крипов
    /// </summary>
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
    /// <summary>
    /// Проверка на то есть ли живой моб или нет
    /// </summary>
    /// <returns></returns>
    public bool IsAnyoneEnemyAlive()
    {
        return CurrentEnemys.Count(x => x.GetComponent<PropertyAi>().isdead == false) == 0 ? true : false;
    }
    /// <summary>
    /// Куратина для спавна крипов 
    /// </summary>
    /// <param name="spawn">Спавн</param>
    /// <returns></returns>
    IEnumerator SpawnCreepOnSpawn(Transform spawn)
    {
        for (int i = 0; i < mobOnSpawn; i++)
        {
            SpawnEnemy(spawn);
            yield return new WaitForSeconds(1.5f);
        }
    }
    /// <summary>
    /// Спавнит крипов
    /// </summary>
    /// <param name="spawn"></param>
    public void SpawnEnemy(Transform spawn)
    {
        CurrentEnemys.Add(Instantiate(Enemys[UnityEngine.Random.Range(0, Enemys.Count)], spawn.transform.position, Quaternion.identity));
    }
}
