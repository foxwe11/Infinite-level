using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    public Vector2 direction;
    private float speed;

    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
    }
                  
    public void OpenDoor()
    {
        speed = 0.04f;
        Invoke("DoorSound", 0.15f);
        Invoke("StopDoor", 0.2f);
    }

    public void CloseDoor()
    {
        speed = -0.04f;
        
        Invoke("StopDoor", 0.2f);
    }

    void StopDoor()
    {
        speed = 0;
    }

    void DoorSound()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().door);
    }
}
