using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Material trapmat, goalMat;
    public Toggle colorblindMode;
    public void PlayMaze()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (colorblindMode.isOn)
        {
            trapmat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapmat.color = Color.red;
            goalMat.color = Color.green;
        }
    }

    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }


}
