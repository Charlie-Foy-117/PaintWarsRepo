using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    [SerializeField]
    private float spawnInterval = 3.5f;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //if collision has the player tag enemies will start spawning in
            StartCoroutine(SpawnEnemy(spawnInterval, enemyPrefab));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //when player is no longer within the trigger box spawn gate will stop spawning enemies
        StopAllCoroutines();
    }
    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        //creates a cooldown between each enemy spawn
        yield return new WaitForSeconds(interval);
        //set position for enemy to spawn
        GameObject newEnemy = Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}
