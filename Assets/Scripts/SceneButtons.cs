using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtons : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(0);
    }

    public void StopButton()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
