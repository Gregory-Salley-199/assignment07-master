using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void StopGame()
    {
        SceneManager.LoadScene("Exit");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {

        UnityEditor.EditorApplication.isPlaying = false;
    }
}