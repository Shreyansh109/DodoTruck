using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerWithPackage : MonoBehaviour
{
    bool order;
    [SerializeField] private float destroyDelay = 0.14f;
    private void OnTriggerEnter2D(Collider2D other) { 
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        if(other.CompareTag("IcecreamOrder") && !order){
            Destroy(other.gameObject, destroyDelay);
            GetComponent<ParticleSystem>().Play();
            order = true;
        }
        if(order && other.CompareTag("Customer")){
            Debug.Log("Package delivered!");
            GetComponent<ParticleSystem>().Stop();
            order = false;
        }
    }
}
