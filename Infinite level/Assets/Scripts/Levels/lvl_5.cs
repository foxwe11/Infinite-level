using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Не трогай
//for player
public class lvl_5 : MonoBehaviour
{
    private int level = 5;
    private int lastLevel = 5;

    public GameObject crystal;
    public GameObject tp1; //tp1 и tp2 координаты перемещения кристалла
    public GameObject tp2;

    private int doorMove = 0;

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
            crystal.transform.position = tp1.transform.position;
            doorMove++;
            GameObject.Find("Door").GetComponent<DoorOpening>().CloseDoor();
        }
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(lastLevel + 2);
        }
        if (other.tag == "Respawn")
        {          
            crystal.transform.position = tp2.transform.position;
            if (doorMove > 0)
            {
                GameObject.Find("Door").GetComponent<DoorOpening>().OpenDoor();
                doorMove--;
            }         
        }
    }
}