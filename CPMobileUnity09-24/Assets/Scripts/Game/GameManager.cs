using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int totalselos = 5;
    [SerializeField] private GameObject fimPortal;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject gameplayPanel;

    [SerializeField] private GameObject ganhouPanel;

    private int collectedSeals = 0;

    private void Start()
    {
        fimPortal.SetActive(false);
    }

    private void OnEnable()
    {
        GameEvents.selosColetado += OnSeloCollected;
        GameEvents.playerMorreu += GameOver;
    }

    private void OnDisable()
    {
        GameEvents.selosColetado -= OnSeloCollected;
        GameEvents.playerMorreu -= GameOver;
    }

    private void OnSeloCollected()
    {
        collectedSeals++;

        if (collectedSeals >= totalselos)
        {
            fimPortal.SetActive(true);
        }
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameplayPanel.SetActive(false);
        Debug.Log("GAME OVER");
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
        );
    }

    public void Ganhou()
    {
        ganhouPanel.SetActive(true);
        gameplayPanel.SetActive(false);
        Debug.Log("WIN");
        Time.timeScale = 0f;
    }
}