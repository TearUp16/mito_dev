using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossSpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 20f;

    [SerializeField] private GameObject miniBossPrefab;

    //[SerializeField] public bool canSpawn = true;
    [SerializeField] private int numberOfEnemiesToSpawn;
    int enemyCount = 0;

    //EnemyHealth enemyHealth;
    //public TMP_Text numberOfEnemies;
    //PlayerHealth playerHealth;
    //bool status;

    // Start is called before the first frame update
    public void Start()
    {
        //enemyHealth = GetComponent<EnemyHealth>();
        //playerHealth = new PlayerHealth();
        StartCoroutine(MiniSpawner());
    }

    public IEnumerator MiniSpawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (enemyCount < numberOfEnemiesToSpawn)
        {
            //status = playerHealth.isAlive;
            //Debug.Log(status);

            yield return wait;
            GameObject enemyToSpawn = miniBossPrefab;

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            enemyCount++;
        }
    }
}
