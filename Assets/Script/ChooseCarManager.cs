using UnityEditor.Search;
using UnityEngine;

public class ChooseCarManager : MonoBehaviour
{
    [SerializeField] private ScoreContainer scoreContainer;
    [SerializeField] private GameObject preLoadScreen;
    [SerializeField] private Sprite car1;
    [SerializeField] private Sprite car2;
    [SerializeField] private BeginGame beginGame;

    public void ChooseCar1(){
        scoreContainer.truckImage = car1;
        gameObject.SetActive(false);
        preLoadScreen.SetActive(true);
        preLoadScreen.GetComponent<BeginGame>().DisplaySelectedTruck();
        preLoadScreen.GetComponent<BeginGame>().SelectedCar("Car1");
    }

    public void ChooseCar2(){
        scoreContainer.truckImage = car2;
        gameObject.SetActive(false);
        preLoadScreen.SetActive(true);
        preLoadScreen.GetComponent<BeginGame>().DisplaySelectedTruck();
        preLoadScreen.GetComponent<BeginGame>().SelectedCar("Car2");
    }
}
