using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    private int level;

    public void ContinueGame()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
            PlayerPrefs.SetInt("lastLevel", 1);
        }
        level = PlayerPrefs.GetInt("lastLevel");
        SceneManager.LoadScene(level + 1);
    }

    public void LoadScene(int scene)
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        Time.timeScale = 1;
        SceneManager.LoadScene(scene);
    }

    public void Exit()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        Application.Quit();
    }
}
