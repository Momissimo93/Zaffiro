
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MenuController : MonoBehaviour
{
    public string _newGameLevel;
    [SerializeField] private FadeIn fadeIn;

    public void Start()
    {

    }

    public void NewGame()
    {
        StartCoroutine("NewGameCoroutine");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    IEnumerator NewGameCoroutine()
    {
        fadeIn.FadeInAction();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(_newGameLevel);
    }
}