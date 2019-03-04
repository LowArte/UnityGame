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

    public PlayerProperty player;

    public bool isWaweEnd;
    public float spawnTime = 1.5f;
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
    public void StartWawe()
    {
        isWaweEnd = false;
        if (maxWaveCount != currentWawe)
        {
            foreach(var spawn in SpawnPoints)
            {
                StartCoroutine(SpawnCreepOnSpawn(spawn as Transform));
            }
        }      
    }
    /// <summary>
    /// Удаляет мобов которые убиты
    /// </summary>
    /// <returns></returns>
    IEnumerator KillingEnemy()
    {
        Debug.Log(IsAnyoneEnemyAlive());
        while (!IsAnyoneEnemyAlive())
        {
            int sdvig = 0;
            for(int i=0;i<CurrentEnemys.Count;i++)
            {
                if (CurrentEnemys[i-sdvig].GetComponent<AiControl>().pa.isdead)
                {
                    Destroy(CurrentEnemys[i - sdvig]);
                    CurrentEnemys.Remove(CurrentEnemys[i - sdvig]);
                    sdvig++;
                }
            }
            yield return null;
        }
        currentWawe++;
        isWaweEnd = true;
        Debug.Log("Все мертвы");
    }
    /// <summary>
    /// Проверка на то есть ли живой моб или нет
    /// </summary>
    /// <returns></returns>
    public bool IsAnyoneEnemyAlive()
    {
        return CurrentEnemys.Count == 0 ? true : false;
    }
    /// <summary>
    /// Спавнит крипов
    /// </summary>
    /// <param name="spawn"></param>
    public void SpawnEnemy(Transform spawn)
    {
        CurrentEnemys.Add(Instantiate(Enemys[UnityEngine.Random.Range(0, Enemys.Count)], spawn.transform.position, Quaternion.identity));
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
            yield return new WaitForSeconds(spawnTime);
        }
        yield return StartCoroutine(KillingEnemy());
    }
}
