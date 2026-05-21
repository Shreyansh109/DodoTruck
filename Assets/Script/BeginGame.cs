using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BeginGame : MonoBehaviour
{
    [SerializeField] private ScoreContainer scoreContainer;
    [SerializeField] private GameObject truckContainer;
    [SerializeField] private GameObject car1;
    [SerializeField] private GameObject car2;

    [SerializeField] private GameObject selectedTruck;
    [SerializeField] private GameObject inGameDetails;
    [SerializeField] private GameObject carSelection;
    private string carSelected;

    void Start()
    {
        carSelected = scoreContainer.selectedCarName;
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
        carSelected = scoreContainer.selectedCarName;
        if (carSelected == "Car1")
        {
            car1.SetActive(true);
            car2.SetActive(false);
            print("worked1");
        }
        else if (carSelected == "Car2")
        {
            car1.SetActive(false);
            car2.SetActive(true);
            print("worked2");
        }
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

    public void SelectedCar(string name)
    {
        scoreContainer.selectedCarName = name;
    }
}
