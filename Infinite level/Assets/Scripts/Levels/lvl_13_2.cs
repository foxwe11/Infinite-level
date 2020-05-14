﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//for button player control
public class lvl_13_2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 6f);
        if (gameObject.name == "BtnLeft")
            GameObject.Find("Player").GetComponent<lvl_13_1>().go = -3f;
        else if (gameObject.name == "BtnRight")
            GameObject.Find("Player").GetComponent<lvl_13_1>().go = 3f;
        if (gameObject.name == "BtnUp")
        {
            GameObject.Find("Player").GetComponent<lvl_13_1>().jump = true;
            GameObject.Find("Player").GetComponent<lvl_13_1>().Jump();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 6f);
        if (gameObject.name != "BtnUp")
            GameObject.Find("Player").GetComponent<PlayerController>().go = 0f;
    }
}
