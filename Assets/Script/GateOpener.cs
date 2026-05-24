using UnityEngine;

public class GateOpener : MonoBehaviour
{
    KeySpawner keySpawner;
    public GameObject gate;
    private bool gateLock = false;
    void Start()
    {
        keySpawner = FindFirstObjectByType<KeySpawner>();
    }

    void Update()
    {
        OpenGate();
    }

    public void OpenGate()
    {
        if (keySpawner.IsKeyCollected() && gate.transform.position.y > 57.75f && gateLock)
        {  
            gate.transform.Translate(0, -1f*Time.deltaTime, 0);
        }

    }

    public void SetGateLock(bool value)
    {
        gateLock = value;
    }
}
