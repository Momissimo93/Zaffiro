using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Animator flash;

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Scene1")
        {
            FadeOut();
        }
        if(SceneManager.GetActiveScene().name == "Scene2")
        {
            FlashOut();
        }
    }

    public void LoadScene(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void FadeOut()
    {
        //StartCoroutine(FadeOutCoroutine(0.3f));
    }

    public void FlashIn()
    {
        StartCoroutine(FlashInCoroutine(0.3f));
    }
    public void FlashOut()
    {
        StartCoroutine(FlashOutCoroutine(0.3f));
    }

    /*IEnumerator FadeOutCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        flash.SetTrigger("Fade_Out");
    }*/

    IEnumerator FlashInCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        flash.SetTrigger("Flash_In");
        yield return new WaitForSeconds(0.5f);
        LoadScene("Scene2");
    }
    IEnumerator FlashOutCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        flash.SetTrigger("Flash_Out");
    }
}

