using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected MainCharacter mainCharacter;
    protected Rigidbody2D rb;
    public abstract void Execute(Transform trans, float direction); 
    public virtual void Move (Transform trans, float direction) { }
    public virtual void JumpCommand(Transform trans) { }
}
