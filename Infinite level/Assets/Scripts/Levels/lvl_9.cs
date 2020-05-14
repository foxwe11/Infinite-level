using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Нажми на паузу
//for player
public class lvl_9 : MonoBehaviour
{
    private int level = 9;
    private int lastLevel = 9;

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
            GameObject.Find("Door").GetComponent<DoorOpening>().OpenDoor();
        }
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(lastLevel + 2);
        }
    }
}
