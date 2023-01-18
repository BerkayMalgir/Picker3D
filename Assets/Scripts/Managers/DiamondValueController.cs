using Controllers.Player;
using TMPro;
using UnityEngine;
public class DiamondValueManager : MonoBehaviour
{
    public static int GeneralGemValue;
    [SerializeField] private TextMeshProUGUI generalGemValueText;
    [SerializeField] private PlayerMovementController playerMovementController;

    private void Start()
    {
        UpdateGeneralGemValueText();
    }

    private void Update()
    {
        CheckGameFinish();
    }

    private void CheckGameFinish()
    {
        if (playerMovementController.scoreValue <= 0.02f)
        {
            UpdateGeneralGemValueText();
        }
    }

    private void UpdateGeneralGemValueText()
    {
        generalGemValueText.text = GeneralGemValue.ToString();
    }
}
