using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int poolSize = 10;
    public List<GameObject> enemyObjectPool;
    public Transform[] spawnPoints;

    public float minTime = 0.5f;
    public float maxTime = 1.5f;
    float currentTime = 0;
    float createTime = 1;
    public GameObject enemyFactory;

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);

        enemyObjectPool = new List<GameObject>();
        for(int i = 0; i<poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemyObjectPool.Add(enemy);
            enemy.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime)
        {
            //for(int i = 0; i<poolSize; i++)
            //{
            //    GameObject enemy = enemyObjectPool[i];
            //    if(enemy.activeSelf == false)
            //    {
                    
            //        int index = Random.Range(0, spawnPoints.Length);
            //        enemy.transform.position = spawnPoints[index].position;
            //        enemy.SetActive(true);
            //        break;

            //    }
            //}
           if(enemyObjectPool.Count> 0)
            {
                GameObject enemy = enemyObjectPool[0];
                enemyObjectPool.Remove(enemy);
                int index = Random.Range(0, spawnPoints.Length);
                enemy.transform.position = spawnPoints[index].position;
                enemy.SetActive(true);
            }
            
            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
        }
    }

    
}
