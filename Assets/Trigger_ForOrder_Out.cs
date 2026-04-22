using UnityEngine;
using UnityEngine.InputSystem;

public class Trigger_ForOrder_Out : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        GameObject dodoTruck = GameObject.Find("DodoTruckImage_0");
        dodoTruck.GetComponent<SpriteRenderer>().sortingOrder = 0;
    }
}
