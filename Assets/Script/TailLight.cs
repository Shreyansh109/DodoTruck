using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal; // Required for Light2D

public class TailLight : MonoBehaviour
{
    private Light2D tailLight;

    private void Awake()
    {
        tailLight = GetComponent<Light2D>();
    }

    void Update()
    {
        if (tailLight == null) return;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            tailLight.intensity = 0.2f;
        }
        else
        {
            tailLight.intensity = 0.6f;
        }
    }
}