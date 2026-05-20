using Unity.VisualScripting;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    [SerializeField] private ScoreContainer scoreContainer;
    [SerializeField] private GameObject truckContainer;
    [SerializeField] private GameObject inGameDetails;
    public void Begin()
    {
        truckContainer.SetActive(true);
        inGameDetails.SetActive(true);
        gameObject.SetActive(false);
    }
}
