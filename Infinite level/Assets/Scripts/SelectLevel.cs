using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//открывает доступ к новым уровням
public class SelectLevel : MonoBehaviour
{
    private int level;

    public void Start()
    {
        if (PlayerPrefs.HasKey("level"))
        {
            level = PlayerPrefs.GetInt("level");
        }
        else level = 1;
        for (int i = 0; i < transform.childCount; i++) {
            if (i < level)
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            else transform.GetChild(i).GetComponent<Button>().interactable = false;
        }
    }
}
