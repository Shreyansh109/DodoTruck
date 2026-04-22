using System.Data.Common;
using UnityEngine;
using UnityEngine.InputSystem;

public class Drive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float speed;
    float stearing;
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
            speed = 20f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speed = -20f;    
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
}
