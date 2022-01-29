using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFoot : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    private int ground = 1 << 6;
    public float rayLenghtFromFeet;
    private Vector2 rightFoot;
    public RaycastHit2D rightFootRays;

    public void EmittingRay()
    {
        rightFoot = new Vector2(boxCollider2D.bounds.max.x, boxCollider2D.bounds.min.y);
        rightFootRays = Physics2D.Raycast(rightFoot, Vector2.down, rayLenghtFromFeet, ground);
    }
    public void DrawRaysFromFeet()
    {
        Debug.DrawRay(rightFoot, Vector2.down * rayLenghtFromFeet, Color.blue);
    }
    public bool IsOnGround()
    {
        return rightFootRays;
    }
}
