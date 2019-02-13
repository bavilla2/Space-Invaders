using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    //Quit the application when user clicks button
    public void OnClickQuit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
