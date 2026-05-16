using TMPro;
using UnityEngine;

public class TextUI_Manager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI customerNameText;
    [SerializeField] TextMeshProUGUI playerScore;


    public void DisplayCustomerName(string name)
    {
        customerNameText.text = "Customer: " + name;
    }
    public void DisplayPlayerScore(int score)
    {
        playerScore.text = "Package Delivered: " + score.ToString();
    }
}