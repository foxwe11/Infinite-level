using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Пауза игры
public class ButtonPause : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;

    public void PauseOn()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }
}
