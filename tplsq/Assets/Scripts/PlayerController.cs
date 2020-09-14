using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed, jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true, isGrounded;

    public Transform groundCheck;

    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reward")
        {
            Reward();
        }
        if (collision.gameObject.tag == "Trap")
        {
            Start();
        }
    }

    public void Reward()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 v = transform.position;
        v.x = -3.52f;
        v.y = 2.26f;
        transform.position = v;
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight==false&&moveInput>0)
        {
            Flip();
        }else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        this.transform.localScale = Scaler;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded==true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetKeyDown(KeyCode.Space)&&extraJumps>0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0&&isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
