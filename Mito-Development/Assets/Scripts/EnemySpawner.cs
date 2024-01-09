using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private int numberOfEnemiesToSpawn;

    [SerializeField] private GameObject miniBossSpawnPoint;

    int enemyCount = 0;
    MiniBossSpawner miniboss;
    //public TMP_Text numberOfEnemies;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (enemyCount < numberOfEnemiesToSpawn)
        {
            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            enemyCount++;
            //UpdateEnemyCount(enemyCount);

        }

        if (enemyCount == numberOfEnemiesToSpawn)
        {
            miniBossSpawnPoint.SetActive(true);
        }
    }    

    /*public void UpdateEnemyCount(int enemies)
    {
        numberOfEnemies.text = "Enemy Count : " + enemies;
    }*/
}

