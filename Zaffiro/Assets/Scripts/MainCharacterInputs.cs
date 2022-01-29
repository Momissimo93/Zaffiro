using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterInputs : MonoBehaviour
{
    private MainCharacter mainCharacter;
    private Command moveLeft;
    private Command moveRight;
    private float direction;
    private float horizontalMove;

    // Start is called before the first frame update
    void Start()
    {
        moveLeft = new MoveLeft();
        moveRight = new MoveRight();
        mainCharacter = gameObject.GetComponent<MainCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mainCharacter)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            direction = horizontalMove;
        }
    }
    private void FixedUpdate()
    {
        if(mainCharacter)
        {
            direction = horizontalMove;
            if(horizontalMove > 0)
            {
                moveRight.Exectute(mainCharacter.transform, direction);
            }
            else if (horizontalMove < 0)
            {
                moveLeft.Exectute(mainCharacter.transform, direction);
            }
            else if (horizontalMove == 0)
            {
                mainCharacter.rigidbody2D.velocity = new Vector2(0, mainCharacter.rigidbody2D.velocity.y);
            }
        }
    }
}
