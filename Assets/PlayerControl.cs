using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigbod;

    // Start is called before the first frame update
    private void Start()
    {
        rigbod = GetComponent<Rigidbody2D>();
        rigbod.gravityScale = 0f;
    }

    
    private void FixedUpdate()
    {
        float speedMove = 3f;
        float horizontalMove = Input.GetAxis("Horizontal");
        rigbod.velocity = new Vector2(horizontalMove * speedMove, rigbod.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Rigidbody2D boxRB = collision.gameObject.GetComponent<Rigidbody2D>();
            boxRB.velocity = new Vector2(rigbod.velocity.x, boxRB.velocity.y);
        }
    }
}
 