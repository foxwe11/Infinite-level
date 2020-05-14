using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for platform
public class lvl_15_1 : MonoBehaviour
{
    public Vector2 direction;
    public float speed1;
    public float speed2;
    public float time1;
    public float time2;
    private float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) Open();
        if (Input.GetKeyDown(KeyCode.X)) Close();
    }

    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
    }

    public void Open()
    {
        speed = speed1 * 1f;
        Invoke("Close", time1);
    }

    public void Close()
    {
        speed = speed2 * 1f;
        Invoke("Stop", time2);
    }

    void Stop()
    {
        speed = 0;
    }
}
