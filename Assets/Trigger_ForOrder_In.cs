using UnityEngine;
using UnityEngine.InputSystem;

public class Trigger_ForOrder_In : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        GameObject dodoTruck = GameObject.Find("DodoTruckImage_0");
        dodoTruck.GetComponent<SpriteRenderer>().sortingOrder = 3;
        dodoTruck.transform.position = new Vector3(dodoTruck.transform.position.x, dodoTruck.transform.position.y, 0);
    }
}
