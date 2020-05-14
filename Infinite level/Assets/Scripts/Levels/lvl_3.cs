using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Назад
//for player
public class lvl_3 : MonoBehaviour
{
    private int level = 3;
    private int lastLevel = 3;

    void Start()
    {
        if (!PlayerPrefs.HasKey("level"))
            PlayerPrefs.SetInt("level", level);
        if (PlayerPrefs.HasKey("level") && PlayerPrefs.GetInt("level") <= level)
            PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("lastLevel", lastLevel);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {            
            SceneManager.LoadScene(lastLevel + 2);
        }
    }
}
