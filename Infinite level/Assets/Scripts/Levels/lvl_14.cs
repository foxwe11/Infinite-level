using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Прыжок и гравитация
//for player
public class lvl_14 : MonoBehaviour
{
    private int level = 14;
    private int lastLevel = 14;

    void Start()
    {
        if (!PlayerPrefs.HasKey("level"))
            PlayerPrefs.SetInt("level", level);
        if (PlayerPrefs.GetInt("level") < level)
            PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("lastLevel", lastLevel);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Crystal")
        {
            GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().crystal);
            Destroy(other.gameObject);
            GameObject.Find("Door").GetComponent<DoorOpening>().OpenDoor();
        }
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(lastLevel + 2);
        }
    }
}
