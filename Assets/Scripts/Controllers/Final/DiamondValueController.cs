using TMPro;
using UnityEngine;
public class DiamondValueController: MonoBehaviour
{
    [SerializeField] private DiamondValueManager  gemCollectManager;
    [SerializeField] private int gemValue;
    [SerializeField] public TextMeshPro gemValueText;

    private void Start()
    {
        gemCollectManager = GameObject.Find("DiamondValueManager").GetComponent<DiamondValueManager>();    
        UpdateGemValueText();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectGem();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ReleaseGem();
        }
    }
    private void CollectGem()
    {
        DiamondValueManager.GeneralGemValue += gemValue;
    }
    private void ReleaseGem()
    {
        DiamondValueManager.GeneralGemValue -= gemValue;
    }
    private void UpdateGemValueText()
    {
        gemValueText.text = gemValue.ToString();
    }
}