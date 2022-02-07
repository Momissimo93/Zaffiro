using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<Animator>())
        {
            animator = gameObject.GetComponent<Animator>();
        }
    }

    public void FadeInAction()
    {
        animator.SetTrigger("FadeIn");
    }
}
