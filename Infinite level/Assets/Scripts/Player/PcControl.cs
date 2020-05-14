using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcControl : MonoBehaviour
{

    Animator anim;
    Rigidbody2D rb;

    private bool isGrounded;
    public Transform GroundCheck;
    public float CheckRadius;
    public LayerMask WhatIsGround;

    public GameObject spawn;
    public GameObject player;
    public GameObject deadPlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
        if (Input.GetAxis("Horizontal") == 0) {
            anim.SetInteger("AnimNumber", 1);
        } else
        {
            Flip();
            anim.SetInteger("AnimNumber", 2);
        }

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 3f, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, WhatIsGround);
    }

    void Jump()
    {
        if (isGrounded == true)
            rb.AddForce(transform.up * 20f, ForceMode2D.Impulse);
    }

    void Flip()
    {
        if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            GameObject.Find("Dead_player").GetComponent<DeadPlayer>().Flip();
            deadPlayer.transform.position = player.transform.position;
            GameObject.Find("Dead_player").GetComponent<DeadPlayer>().Respawn();
            player.transform.position = spawn.transform.position;
        }
    }
}
