using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    private bool Paused;
    public Canvas PauseCanva;

    public void Pause()
    {
        Paused = true;
        Time.timeScale = 0;
        PauseCanva.enabled = true;
    }
    public void Resume()
    {
        Paused = false;
        Time.timeScale = 1;
        PauseCanva.enabled = false;

    }


    public void Restart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    public void Options()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
                Resume();
            else
                Pause();
        }
    }

}
