using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BeginGame : MonoBehaviour
{
    [SerializeField] private ScoreContainer scoreContainer;
    [SerializeField] private GameObject truckContainer;
    [SerializeField] private GameObject selectedTruck;
    [SerializeField] private GameObject inGameDetails;
    [SerializeField] private GameObject carSelection;

    void Start()
    {
        DisplaySelectedTruck();
    }
    public void DisplaySelectedTruck()
    {
        selectedTruck.GetComponent<UnityEngine.UI.Image>().sprite = scoreContainer.truckImage;
    }
    public void Begin()
    {
        truckContainer.SetActive(true);
        inGameDetails.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ChooseCar()
    {
        gameObject.SetActive(false);
        carSelection.SetActive(true);
    }

    public void ResetScore()
    {
        scoreContainer.PackageDelivered = 0;
        Begin();
    }
}
