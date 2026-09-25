using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text textSelo;

    private int selos = 0;
    private int totalselo= 5;

    private void OnEnable()
    {
        GameEvents.selosColetado += UpdateSealCount;
    }
    private void OnDisable()
    {
        GameEvents.selosColetado -= UpdateSealCount;
    }

    private void Start()
    {
        UpdateText();
    }
    private void UpdateSealCount()
    {
        selos++;
        UpdateText();
    }

    private void UpdateText()
    {
        

        if (selos >= totalselo)
        {
            textSelo.text = "Agora vá até o portal!";
        }
        else
        {
            textSelo.text = $"Selos: {selos}/{totalselo}";
        }
    }
}
