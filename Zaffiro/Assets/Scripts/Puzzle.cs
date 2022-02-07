using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puzzle : MonoBehaviour
{
    [SerializeField]List<string> letters = new List<string>();
    [SerializeField] LevelManager levelManager;
    [SerializeField] TextMeshProUGUI text;
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
            text.text = "C";
            return true;
        }
        else if (letters.Count == 1 && s == "O")
        {
            letters.Add("O");
            text.text = "CO";
            return true;
        }
        else if(letters.Count == 2 && s == "U")
        {
            letters.Add("U");
            text.text = "COU";
            return true;
        }
        else if (letters.Count == 3 && s == "R")
        {
            letters.Add("R");
            text.text = "COUR";
            return true;
        }
        else if (letters.Count == 4 && s == "A")
        {
            letters.Add("A");
            text.text = "COURA";
            return true;
        }
        else if (letters.Count == 5 && s == "G")
        {
            letters.Add("G");
            text.text = "COURAG";
            return true;
        }
        else if (letters.Count == 6 && s == "E")
        {
            letters.Add("E");
            text.text = "COURAGE";
            StartCoroutine("PuzzleCompleted");
            return true;
        }
        else
            return false;
    }

    IEnumerator PuzzleCompleted()
    {
        levelManager.FlashIn();
        yield return new WaitForSeconds(1f);
        levelManager.LoadScene("Scene3");
    }
}
