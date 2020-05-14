using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//for player control buttons
public class lvl_6 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 6f);
        if (gameObject.name == "BtnUp")   //button left
            GameObject.Find("Player").GetComponent<PlayerController>().go = -3f;
        else if (gameObject.name == "BtnLeft")     //button right
            GameObject.Find("Player").GetComponent<PlayerController>().go = 3f;
        if (gameObject.name == "BtnRight")     //button up
        {
            GameObject.Find("Player").GetComponent<PlayerController>().jump = true;
            GameObject.Find("Player").GetComponent<PlayerController>().Jump();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 6f);
        if (gameObject.name != "BtnUp")
            GameObject.Find("Player").GetComponent<PlayerController>().go = 0f;
    }
}
