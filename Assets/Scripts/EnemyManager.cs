using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // creates an array
    public GameObject[] enemyPrefabs;
    public Enemy curEnemy;
    public Transform canvas; 

    // this makes a singleton
    public static EnemyManager instance;

    void Awake()
    {
        instance = this;
    }

    public void CreateNewEnemy()
    {
        // randomizes the enemy to spawn, in this case for the index to spawn it
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, canvas);

        curEnemy = obj.GetComponent<Enemy>();
    }

    public void DefeatEnemy (GameObject enemy)
    {
        Destroy(enemy);
        CreateNewEnemy();
        GameManager.instance.BackgroundCheck();
    }
}
