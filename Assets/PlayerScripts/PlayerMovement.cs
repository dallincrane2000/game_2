using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //public Animator animator;
    private bool facingRight = true; //Depends on if your animation is by default facing right or left
    public float speed = 5;

    public Rigidbody2D Player;
    public GameObject player;

    public Transform groundCheck; //Marker to see where players feet are
    public float groundCheckRadius; //Draw circle around feet
    public LayerMask groundLayer; //Create a place to insert the ground layer
    private bool isTouchingGround;
   
    private float fallMultiplier = 2.5f;
    private float lowJumpMultiplier = 2f;
    public int doubleJumpHeight = 40;
    public float jumpVelocity = 20;
    public float destroyTime = 0.5f;

    private int jump = 0;

    void Awake()
    {
        Player = GetComponent<Rigidbody2D> ();
    }

    //////////////////////
    private void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        //animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * speed * Time.deltaTime;

        if(Input.GetButtonDown("Jump") && isTouchingGround)
        {
            Player.velocity = Vector2.up * jumpVelocity;
            jump = 1;
        }
        else if(Input.GetButtonDown("Jump") && !isTouchingGround && jump == 1)
        {
            jump = 0;
            Player.velocity = Vector2.up * jumpVelocity;
        }
        
        if(Player.velocity.y < 0)
        {
            Player.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if(Player.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            Player.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }


    ///////////////////
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if(h > 0 && !facingRight)
            Flip();
        else if(h < 0 && facingRight)
            Flip();
    }
    ///////////
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f,180f,0f);
    }
}

