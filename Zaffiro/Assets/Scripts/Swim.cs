using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : Command
{
    public override void Execute(Transform trans, float direction)
    {
        SwimmingCommand(trans);
    }
    public override void SwimmingCommand(Transform trans)
    {
        if (trans.gameObject.GetComponent<Rigidbody2D>())
        {
            MainCharacter mainCharacter = trans.gameObject.GetComponent<MainCharacter>();
            mainCharacter.rigidbody2D = trans.gameObject.GetComponent<Rigidbody2D>();
            mainCharacter.rigidbody2D.velocity = new Vector2(mainCharacter.rigidbody2D.velocity.x / 4, mainCharacter.swimmingPower);
        }
        else
        {
            //Debug.Log("I can not jump");
        }
    }
}
