using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }
}
