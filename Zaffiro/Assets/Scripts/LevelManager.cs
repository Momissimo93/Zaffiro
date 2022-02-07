using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Animator flashIn;
    [SerializeField] private Animator flashOut;
    [SerializeField] private Animator fadeIn;

    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        switch (sceneName)
        {
            case "Scene1":
                //FadeOut();
                break;
            case "Scene2":
                FlashOut();
                break;
            case "Scene3":
                FlashOut();
                break;
            case "Scene4":
                FlashOut();
                break;
            case "Scene5":
                FlashOut();
                break;
        }
    }

    public void LoadScene(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void FlashIn()
    {
        if(flashIn)
        {
            StartCoroutine(FlashInCoroutine(0.3f));
        }
    }
    public void FlashOut()
    {
        if(flashOut)
        {
            StartCoroutine(FlashOutCoroutine(0.3f));
        }
    }
    public void FadeIn()
    {
        if (fadeIn)
        {
            StartCoroutine(FadeInCoroutine(0.3f));
        }
    }

    IEnumerator FlashInCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        flashIn.SetTrigger("Flash_In");
    }
    IEnumerator FlashOutCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        flashOut.SetTrigger("Flash_Out");
    }

    IEnumerator FadeInCoroutine(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        fadeIn.SetTrigger("FadeIn");
    }
}

