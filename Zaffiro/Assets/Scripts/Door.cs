using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float transitionSeconds;
    [SerializeField] private LevelManager levelManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<MainCharacter>())
        {
            StartCoroutine(ChangeLevelCoroutine(transitionSeconds));
        }
    }
    IEnumerator ChangeLevelCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        levelManager.FlashIn();
    }
}
