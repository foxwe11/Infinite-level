using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    private bool whenlook;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        whenlook = GameObject.Find("Player").GetComponent<PlayerController>().whenlook;   

        /*if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);*/
    }

    public void Flip()
    {
        if (whenlook == false)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (whenlook == true)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void Respawn()
    {
        anim.SetInteger("AnimNumber", 3);
        Invoke("Lie", 0.06f);
    }

    void Lie()
    {
        anim.SetInteger("AnimNumber", 4);
    }
}
