using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmingInputs : MonoBehaviour
{
    public MainCharacter mainCharacter;
    private float horizontalMove = 0;
    private float direction;
    private Rigidbody2D rb;
    private Command moveRigth;
    private Command moveLeft;
    private Command swim;

    // Start is called before the first frame update
    void Start()
    {
        moveRigth = new MoveRight();
        moveLeft = new MoveLeft();
        swim = new Swim();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (mainCharacter)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");

            direction = horizontalMove;

            if (horizontalMove > 0f)
            {
                moveRigth.Execute(mainCharacter.transform, direction);
                mainCharacter.SetRotation("right");
                if (mainCharacter.isOnGround == true)
                {
                    //mainCharacter.animator.SetFloat("Speed", bird.speed);
                }
            }
            else if (horizontalMove < 0f)
            {
                moveLeft.Execute(mainCharacter.transform, direction);
                mainCharacter.SetRotation("left");
                if (mainCharacter.isOnGround == true)
                {
                    //mainCharacter.animator.SetFloat("Speed", birdmainCharacterspeed);
                }
            }
            else
            {
                mainCharacter.rigidbody2D.velocity = new Vector2(0f, mainCharacter.rigidbody2D.velocity.y);
                if (mainCharacter.isOnGround == true)
                {
                    //mainCharacter.animator.SetFloat("Speed", 0f);
                }
            }
        }
    }

    void Update()
    {
        mainCharacter = FindObjectOfType<MainCharacter>();

        if (Input.GetButtonDown("Jump"))
        {
            direction = horizontalMove;
            swim.Execute(mainCharacter.transform, direction);
        }
    }
}
