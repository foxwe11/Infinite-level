using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Секретный проход
//for player
public class lvl_15 : MonoBehaviour
{
    private int level = 15;
    private int lastLevel = 15;

    private int count = 1;
    private int check = 1;

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
            if(count == 1)
            {
                GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().crystal);
                GameObject.Find("Door").GetComponent<DoorOpening>().OpenDoor();
                count--;
            }
            if (check == 1)
            {
                GameObject.Find("Platform").GetComponent<lvl_15_1>().Open();
                check--;
                Invoke("CheckControl", 3.3f);
            }
        }
        if (other.tag == "lvl15")
        {
            if (count == 0)
            {
                GameObject.Find("Door").GetComponent<DoorOpening>().CloseDoor();
                count++;
            }
        }
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(0);
        }
    }

    void CheckControl()
    {
        check = 1;
    }
}
