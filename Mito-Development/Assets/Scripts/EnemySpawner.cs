using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private GameObject[] enemyPrefabs;

    [SerializeField] public bool canSpawn = true;
    [SerializeField] private int numberOfEnemiesToSpawn;

    int enemyCount = 0;
    //public TMP_Text numberOfEnemies;
    PlayerHealth playerHealth;
    bool status;

    // Start is called before the first frame update
    private void Start()
    {
        playerHealth = new PlayerHealth();
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn && enemyCount < numberOfEnemiesToSpawn)
        {
            status = playerHealth.isAlive;
            Debug.Log(status);
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            enemyCount++;
            //UpdateEnemyCount(enemyCount);

        }
    }    

    /*public void UpdateEnemyCount(int enemies)
    {
        numberOfEnemies.text = "Enemy Count : " + enemies;
    }*/
}

