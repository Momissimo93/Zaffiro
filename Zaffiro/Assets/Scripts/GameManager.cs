using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static void SetResolution(Resolution[] sR, int i)
    {
        Debug.Log("Size: " + sR[i].width + " x " + sR[i].height);
        Resolution resolution = sR[i];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
