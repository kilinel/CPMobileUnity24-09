using UnityEngine;

public enum EnemyType
{
    Mushroom,
    Specter
}

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private GameObject cogumeloPrefab;
    [SerializeField] private GameObject specterPrefab;

    public GameObject CreateEnemy(EnemyType type, Vector3 position)
    {
        switch (type)
        {
            case EnemyType.Mushroom:
                return Instantiate(
                    cogumeloPrefab,
                    position,
                    Quaternion.identity
                );

            case EnemyType.Specter:
                return Instantiate(
                    specterPrefab,
                    position,
                    Quaternion.identity
                );
        }

        return null;
    }
}