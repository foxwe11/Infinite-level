using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Гравитация
//for player
public class lvl_7 : MonoBehaviour
{
    private int level = 7;
    private int lastLevel = 7;

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
