using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonReset : MonoBehaviour
{
    [SerializeField] private GameObject panelReset;

    public void ResetOn()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        panelReset.SetActive(true);
    }

    public void ResetOff()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);
        panelReset.SetActive(false);
    }

    public void ResetProgress()
    {
        GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().click);      
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("lastLevel", 1);
        panelReset.SetActive(false);
    }
}
