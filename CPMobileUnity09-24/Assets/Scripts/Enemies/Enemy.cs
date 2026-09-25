using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float speed = 2f;

    protected Transform player;

    protected virtual void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
            player = playerObject.transform;
    }

    protected virtual void Update()
    {
        if (player == null)
            return;

        Vector3 direction = (player.position - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            GameEvents.OnPlayerDied();
        }
    }
}