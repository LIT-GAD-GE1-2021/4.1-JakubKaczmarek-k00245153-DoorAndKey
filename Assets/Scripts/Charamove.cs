using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Charamove : MonoBehaviour
{
  

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    public int buttonPressed = 0;
    bool canJump = false;
    public int jumped = 0;


    public KeyCode right1;
    public KeyCode right2;
    public KeyCode left1;
    public KeyCode left2;

    public KeyCode up1;
    public KeyCode up2;

    public GameObject Player;
    private Rigidbody2D charaRigidbody;
    public SpriteRenderer spriteRender;


    void Start()
    {
        charaRigidbody = Player.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //These are all Booleans that indicate whether the movement buttons have been pressed.
        // 1 = Moving Right 2 = Moving Left
        //Jumping is 1 = Jumping Right Now 0 = Not Jumping

        if (Input.GetKey(right1))
        {
            buttonPressed = 1;
        }
        else if (Input.GetKey(left1))
        {
            buttonPressed = 2;
        }
        else if (Input.GetKey(right2))
        {
            buttonPressed = 1;
        }
        else if (Input.GetKey(left2))
        {
            buttonPressed = 2;
        }
        else
        {
            buttonPressed = 0;
        }



        if (Input.GetKey(up1))
        {
            jumped = 1;
        }
        else if (Input.GetKey(up2))
        {
            jumped = 1;
        }
        else
        {
            jumped = 0;
        }

    }

    void FixedUpdate()
    {
        //This is in fixed update to improve performance
        //These are the AddForce for movement whenever it detects that one of the Movement Booleans have been checked
        if(buttonPressed == 1)
        {
            charaRigidbody.AddForce(new Vector2(MovementSpeed, 0), ForceMode2D.Impulse);
            spriteRender.flipX = false;


        }
        else if (buttonPressed == 2)
        {
            charaRigidbody.AddForce(new Vector2(-MovementSpeed, 0), ForceMode2D.Impulse);
            spriteRender.flipX = true;
        }
        else if (buttonPressed == 0)
        {
            //This makes the player slow down and add a small slide before gradually stopping (Being Multiplied by 0.9 constantly until slowed to null ((works alongside the rigidbody's settings))
            Vector2 velocity = charaRigidbody.velocity;
            charaRigidbody.velocity = new Vector2(velocity.x * 0.9f, velocity.y);
        }

        if (jumped == 1 && Mathf.Abs(charaRigidbody.velocity.y) < 0.001f)
        {
            charaRigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        else if (jumped == 0)
        {
        }


    }





}
