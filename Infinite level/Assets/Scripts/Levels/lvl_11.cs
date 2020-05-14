using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//В поисках смерти
//for player
public class lvl_11 : MonoBehaviour
{
    private int level = 11;
    private int lastLevel = 11;

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
            Destroy(other.gameObject);
            GameObject.Find("Door").GetComponent<DoorOpening>().OpenDoor();
        }
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(lastLevel + 2);
        }
    }
}
