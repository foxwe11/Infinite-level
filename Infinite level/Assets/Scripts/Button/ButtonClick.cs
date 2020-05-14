using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//Нажатие и отжатие кнопок управления персонажем
public class ButtonClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 6f);
        if (gameObject.name == "BtnLeft")
            GameObject.Find("Player").GetComponent<PlayerController>().go = -3f;
        else if (gameObject.name == "BtnRight")
            GameObject.Find("Player").GetComponent<PlayerController>().go = 3f;
        if (gameObject.name == "BtnUp")
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