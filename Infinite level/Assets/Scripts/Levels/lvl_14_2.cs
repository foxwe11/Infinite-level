using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for player controller
public class lvl_14_2 : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    public float go;
    public bool whenlook;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int count = 1;

    public GameObject spawn;
    public GameObject player;
    public GameObject deadPlayer;
    public bool jump = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //проверка на наличие поверхности под ногами
    }

    void Update()
    {
        if (go == -3f)
        {
            whenlook = false;
            Flip();
            anim.SetInteger("AnimNumber", 2); //animation GO
        }
        else if (go == 3f)
        {
            whenlook = true;
            Flip();
            anim.SetInteger("AnimNumber", 2); //animation GO
        }
        else
        {
            go = 0f;
            anim.SetInteger("AnimNumber", 1); //animation Stand
        }
        rb.velocity = new Vector2(go, rb.velocity.y);
    }

    public void Jump()
    {
        if (isGrounded == true && jump == true && count != 0)
        {
            rb.AddForce(transform.up * 20f, ForceMode2D.Impulse);
            jump = false;
            count--;
        }
    }

    void Flip()
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            GameObject.Find("AudioBox").GetComponent<AudioBox>().AudioPlay(GameObject.Find("AudioBox").GetComponent<AudioBox>().damage);
            count = 1;
            GameObject.Find("Dead_player").GetComponent<lvl_14_3>().Flip();
            deadPlayer.transform.position = player.transform.position;
            GameObject.Find("Dead_player").GetComponent<lvl_14_3>().Respawn();
            player.transform.position = spawn.transform.position;
        }
    }
}
