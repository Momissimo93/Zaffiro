using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterInputs : MonoBehaviour
{
    [SerializeField] private float direction;
    [SerializeField] MainCharacter mainCharacter;

    private Command moveLeft;
    private Command moveRight;
    private Command jump;

    private float horizontalMove;

    private bool isJumping;

    protected Rigidbody2D rb;
    //[SerializeField] public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Jump();
        moveLeft = new MoveLeft();
        moveRight = new MoveRight();
        mainCharacter = GameObject.FindObjectOfType<MainCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mainCharacter)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            direction = horizontalMove;

            if (Input.GetButtonDown("Jump") && mainCharacter.isOnGround)
            {
                //human.isMoving = true;
                //isJumping = true;
                jump.Execute(mainCharacter.transform, direction);
                Debug.Log("Jump");
            }
        }
    }
    private void FixedUpdate()
    {
        if(mainCharacter)
        {
            direction = horizontalMove;
            if(horizontalMove > 0)
            {
                moveRight.Execute(mainCharacter.transform, direction);
                mainCharacter.SetRotation("right");
            }
            else if (horizontalMove < 0)
            {
                moveLeft.Execute(mainCharacter.transform, direction);
                mainCharacter.SetRotation("left");
            }
            else if (horizontalMove == 0)
            {
                if(mainCharacter.rigidbody2D)
                {
                    mainCharacter.rigidbody2D.velocity = new Vector2(0, mainCharacter.rigidbody2D.velocity.y);
                }
            }
        }
    }
}
