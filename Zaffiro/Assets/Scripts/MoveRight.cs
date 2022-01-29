using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : Command
{
    public override void Exectute(Transform trans, float direction)
    {
        Move(trans, direction);
    }
    public override void Move(Transform trans, float direction)
    {
        if(trans.gameObject.GetComponent<MainCharacter>())
        {
            mainCharacter = trans.gameObject.GetComponent<MainCharacter>();

            if (trans.gameObject.GetComponent<Rigidbody2D>())
            {
                rb = trans.gameObject.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2 (direction * mainCharacter.speed * Time.deltaTime, trans.position.y);
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
