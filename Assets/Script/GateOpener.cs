using UnityEngine;

public class GateOpener : MonoBehaviour
{
    KeySpawner keySpawner;
    public GameObject gate;
    private bool gateLock = true;
    void Start()
    {
        keySpawner = FindFirstObjectByType<KeySpawner>();
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<AudioSource>().Pause();
    }

    void Update()
    {
        OpenGate();
    }

    public void OpenGate()
    {
        if (keySpawner.IsKeyCollected() && gate.transform.position.y > 57.75f && !gateLock)
        {
            gameObject.GetComponent<AudioSource>().UnPause();
            gate.transform.Translate(0, -1f*Time.deltaTime, 0);
        }else if (gate.transform.position.y <= 57.75f)
        {
            gameObject.GetComponent<AudioSource>().Stop();
            keySpawner.SetKeyCollected(false);
        }

    }

    public void SetGateLock(bool value)
    {
        gateLock = value;
    }
}
