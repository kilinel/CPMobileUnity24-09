using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactory factory;

    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private float spawnRange = 10f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 position = new Vector3(
            Random.Range(-spawnRange, spawnRange),
            1.5f,
            Random.Range(-spawnRange, spawnRange)
        );

        EnemyType type = Random.value > 0.5f
            ? EnemyType.Mushroom
            : EnemyType.Specter;

        factory.CreateEnemy(type, position);
    }
}