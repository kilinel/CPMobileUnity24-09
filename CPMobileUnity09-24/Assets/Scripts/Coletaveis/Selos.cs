using UnityEngine;

public class Seal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameEvents.OnSeloCollected();
            Destroy(gameObject);
        }
    }
}