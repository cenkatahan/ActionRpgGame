using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float interval = 1f;

    private bool isSpawning = true;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        Vector2 spawnPos = Vector2.zero;

        while (isSpawning)
        {
            yield return new WaitForSeconds(interval);
            spawnPos.x = Random.Range(-12f, 12f);
            spawnPos.y = Random.Range(-6f, 6f);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }
}
