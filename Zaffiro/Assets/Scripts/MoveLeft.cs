using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    public override void Execute(Transform trans, float direction)
    {
        Move(trans, direction);
    }
    public override void Move (Transform trans, float direction)
    {
        if(trans.gameObject.GetComponent<MainCharacter>())
        {
            mainCharacter = trans.gameObject.GetComponent<MainCharacter>();

            if (trans.gameObject.GetComponent<Rigidbody2D>())
            {
                rb = trans.gameObject.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2(direction * mainCharacter.speed * Time.deltaTime, rb.velocity.y);
            }
            else
            {
                Debug.Log("Error");
            }
        }
        else
        {
            Debug.Log("Error");
        }
    }
}
