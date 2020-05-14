using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Не верь глазам
//for player
public class lvl_8 : MonoBehaviour
{
    private int level = 8;
    private int lastLevel = 8;
   
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
        if (other.tag == "Finish")
        {
            SceneManager.LoadScene(lastLevel + 2);
        }
    }
}