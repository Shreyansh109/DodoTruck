using System.Data;
using System.Data.Common;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Drive : MonoBehaviour
{
    
    float speedVar=12f;
    float stearing, speed;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        speed=0;
        
        stearing=0;
        if (Keyboard.current.wKey.isPressed)
        {
            speed = speedVar*1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speed = speedVar*-1f;
        }

       if(Keyboard.current.aKey.isPressed && (Keyboard.current.wKey.isPressed || Keyboard.current.sKey.isPressed))
        {
            stearing = 300f;
            
        }
        else if (Keyboard.current.dKey.isPressed && (Keyboard.current.wKey.isPressed || Keyboard.current.sKey.isPressed))
        {
            stearing = -300f;
        }
        transform.Rotate(0, 0, stearing*Time.deltaTime*speed/20);
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Boost"))
        {
            AudioSource audio = GameObject.Find("BoostAudio").GetComponent<AudioSource>();
            audio.Play();
            speedVar=20f;
            Destroy(other.gameObject, 0.14f);
        }
        if(other.CompareTag("Key"))
        {
            AudioSource audio = gameObject.GetComponent<AudioSource>();
            audio.Play();
            KeySpawner keySpawner = FindFirstObjectByType<KeySpawner>();
            keySpawner.KeyCollected();
            Destroy(other.gameObject, 0.14f);
        }
        if(other.CompareTag("GateDetector"))
        {
            other.GetComponent<GateOpener>().SetGateLock(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bump") || collision.gameObject.CompareTag("Wall"))
        {
            speedVar=12f;
        }
    }
}
