using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Умри, пытаясь
//for dead_player
public class lvl_4 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Crystal")
        {
            GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().crystal);
            Destroy(other.gameObject);
            GameObject.Find("Door").GetComponent<DoorOpening>().OpenDoor();
        }
    }
}
