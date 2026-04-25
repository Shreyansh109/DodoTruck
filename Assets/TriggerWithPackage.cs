using UnityEngine;

public class TriggerWithPackage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("IcecreamOrder")){
            Debug.Log("Triggered with " + other.gameObject.name);
        }
    }
}
