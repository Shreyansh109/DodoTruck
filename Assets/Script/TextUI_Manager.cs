using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextUI_Manager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI customerNameText;
    [SerializeField] TextMeshProUGUI playerScore;
    [SerializeField] private ScoreContainer scoreContainer;
    [SerializeField] private GameObject selectedTruck;


    void Start()
    {
        DisplayPlayerScore(scoreContainer.PackageDelivered);
    }
    public void DisplayCustomerName(string name)
    {
        customerNameText.text = "Customer: " + name;
    }
    public void DisplayPlayerScore(int score)
    {
        playerScore.text = "Package Delivered: " + score.ToString();
    }
    public void DisplaySelectedTruck()
    {
        selectedTruck.GetComponent<UnityEngine.UI.Image>().sprite = scoreContainer.truckImage;
    }
}