using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    //GameObject g;
    MainCharacter mainCharacter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (mainCharacter != null)
            {
                StartCoroutine(DisableCollision());
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MainCharacter"))
        {
            mainCharacter = collision.gameObject.GetComponent<MainCharacter>();
        }
        else
        {
            Debug.Log("Error");
        }
    }

    private IEnumerator DisableCollision()
    {
        BoxCollider2D platformCollider = GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(mainCharacter.boxCollider2D, platformCollider);
        yield return new WaitForSeconds(0.25f);
        Physics2D.IgnoreCollision(mainCharacter.boxCollider2D, platformCollider, false);
    }
}
