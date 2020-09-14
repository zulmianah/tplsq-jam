using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D bird;
    bool dead = false;


    // Start is called before the first frame update
    void Start()
    {
        bird = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && !dead)
        {
            bird.velocity = new Vector2(0, 8.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }
}
