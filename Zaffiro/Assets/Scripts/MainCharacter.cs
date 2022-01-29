using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    protected bool facingRight;

    [SerializeField] public int jumpForce;
    [SerializeField] public int swimmingPower;
    [SerializeField] public float speed;
    [SerializeField] public float direction;
    [SerializeField] private LeftFoot leftFoot;
    [SerializeField] private RightFoot rightFoot;
    [SerializeField] private bool canMove;

    [SerializeField] public bool isOnGround;

    [HideInInspector] public Transform trans;
    [HideInInspector] public Rigidbody2D rigidbody2D;
    [HideInInspector] public Animator animator;
    [HideInInspector] public BoxCollider2D boxCollider2D;

    private void Awake()
    {
        SetAnimator();
        SetBoxCollider();
        SetTransform();
        SetRigidBody2D();
    }

    private void Start()
    {
        SetDirection();
    }
    void Update()
    {
        leftFoot.EmittingRay();
        leftFoot.DrawRaysFromFeet();

        rightFoot.EmittingRay();
        rightFoot.DrawRaysFromFeet();
    }

    private void FixedUpdate()
    {
        IsOnGround();
    }

    private void SetDirection()
    {
        float localEu = trans.localEulerAngles.y;

        if (localEu == 180.0f)
        {
            direction = -1;
            facingRight = false;
        }
        else if (localEu == 0.0f)
        {
            direction = 1;
            facingRight = true;
        }
        else
        {
            Debug.Log("....");
        }
    }
    public void SetRotation(string s)
    {
        if (s == "right")
        {
            if (!facingRight)
            {
                transform.Rotate(0, 180f, 0f);
                facingRight = true;
                direction = 1;
            }
        }
        else if (s == "left")
        {
            if (facingRight)
            {
                transform.Rotate(0f, 180f, 0f);
                facingRight = false;
                direction = -1;
            }
        }
    }
    public void IsOnGround()
    {
        /*if (canMove)
        {*/
            if (leftFoot.IsOnGround() == true || rightFoot.IsOnGround() == true)
            {
                isOnGround = true;
                //animator.SetBool("isJumping", false);

            }
            else if (leftFoot.IsOnGround() == false || rightFoot.IsOnGround() == false)
            {
                isOnGround = false;
                //animator.SetBool("isJumping", true);
            }
    }
    protected void SetAnimator()
    {
        if (GetComponent<Animator>())
        {
            animator = gameObject.GetComponent<Animator>();
        }
    }
    protected void SetBoxCollider()
    {
        if (GetComponent<BoxCollider2D>())
        {
            boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        }
    }
    protected void SetTransform()
    {
        if (GetComponent<Transform>())
        {
            trans = gameObject.GetComponent<Transform>();
        }
    }
    protected void SetRigidBody2D()
    {
        if (GetComponent<Rigidbody2D>())
        {
            rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        }
    }
    /*}

    //When we get hit we want to stop the jumping animation. Also we set the bool variable isOnGround to be false so that we can use it to tell wheter or not we are jumping on the enemey
    else if (!canMove)
    {
        isOnGround = false;
        //animator.SetBool("isJumping", false);
    }*/
}
