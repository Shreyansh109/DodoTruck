using UnityEngine;

public class CollisionWithPackage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
    }
}
