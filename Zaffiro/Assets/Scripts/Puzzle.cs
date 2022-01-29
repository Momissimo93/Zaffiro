using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    [SerializeField]List<string> letters = new List<string>();
    [SerializeField] LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AddLetterToPuzzle(string s)
    {
        if (letters.Count == 0 && s == "C")
        {
            letters.Add("C");
            return true;
        }
        else if (letters.Count == 1 && s == "O")
        {
            letters.Add("O");
            return true;
        }
        else if(letters.Count == 2 && s == "U")
        {
            letters.Add("U");
            return true;
        }
        else if (letters.Count == 3 && s == "R")
        {
            letters.Add("R");
            return true;
        }
        else if (letters.Count == 4 && s == "A")
        {
            letters.Add("A");
            return true;
        }
        else if (letters.Count == 5 && s == "G")
        {
            letters.Add("G");
            return true;
        }
        else if (letters.Count == 6 && s == "E")
        {
            letters.Add("E");
            levelManager.FlashIn();
            return true;
        }
        else
            return false;
    }
}
