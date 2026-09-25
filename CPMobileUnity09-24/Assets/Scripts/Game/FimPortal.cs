using UnityEngine;

public class FimPortal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().Ganhou();
        }
    }
}
