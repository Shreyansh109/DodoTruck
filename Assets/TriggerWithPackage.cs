using UnityEngine;

public class TriggerWithPackage : MonoBehaviour
{
    bool order;
    private void OnTriggerEnter2D(Collider2D other) { 
        if(other.CompareTag("IcecreamOrder")){
            order = true;
        }
        if(order==true && other.CompareTag("Customer")){
            Debug.Log("Package delivered!");
            order = false;
        }
    }
}
