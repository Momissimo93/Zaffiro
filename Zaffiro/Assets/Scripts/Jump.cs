using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Command
{
    public override void Execute(Transform trans, float direction)
    {
        JumpCommand(trans);
    }
    public override void JumpCommand(Transform trans)
    {
        if (trans.gameObject.GetComponent<Rigidbody2D>())
        {
            MainCharacter mainCharacter = trans.gameObject.GetComponent<MainCharacter>();
            rb = trans.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(rb.velocity.x, mainCharacter.jumpForce);
        }
        else
        {
            Debug.Log("I can not jump");
        }
    }
}