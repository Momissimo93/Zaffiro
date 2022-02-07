using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<MainCharacter>())
        {
            MainCharacter mainCharacter = collision.gameObject.GetComponent<MainCharacter>();
            mainCharacter.transform.localScale = new Vector3(2, 2, 2);
            Destroy(gameObject);
        }
    }
}
