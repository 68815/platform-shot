using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float jumpSpeed = 8f;
    private bool canJump = false;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) canJump = true;
        if(Input.GetKeyDown(KeyCode.J)){
            var bullet = Resources.Load<GameObject>("Bullet");
            GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (canJump){
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            canJump = false;
        }
        rb2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 5, rb2d.velocity.y);
    }
}
