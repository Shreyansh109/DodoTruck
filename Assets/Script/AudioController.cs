using UnityEngine;
using UnityEngine.InputSystem;
public class AudioController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource audio1 = GameObject.Find("CarMove").GetComponent<AudioSource>();
        audio1.Play();
        audio1.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource audio1 = GameObject.Find("CarMove").GetComponent<AudioSource>();
        AudioSource audio2 = GameObject.Find("CarAtRest").GetComponent<AudioSource>();
        if(Keyboard.current.wKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            audio1.UnPause();
            audio2.Pause();
        }
        if (Keyboard.current.wKey.wasReleasedThisFrame || Keyboard.current.sKey.wasReleasedThisFrame)
        {
            audio1.Pause();
            audio2.UnPause();
        }
        // else
        // {
        //     audio1.Stop();
        //     audio2.Play();
        // }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bump"))
        {
            AudioSource audio = GameObject.Find("CarBump").GetComponent<AudioSource>();
            audio.Play();
        }
        else if(collision.gameObject.CompareTag("Wall"))
        {
            print("wall");
            AudioSource audio = GameObject.Find("WallThump").GetComponent<AudioSource>();
            audio.Play();
        }
    }
    
}
