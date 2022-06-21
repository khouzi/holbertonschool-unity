using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
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
}
