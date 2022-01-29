using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    [SerializeField] private string letterName;
    [SerializeField] private Puzzle puzzle;
    // Start is called before the first frame update
    void Start()
    {
        letterName = gameObject.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<MainCharacter>())
        {
            if(puzzle.AddLetterToPuzzle(letterName))
            {
                Destroy(gameObject);
            }
        }
    }
}
