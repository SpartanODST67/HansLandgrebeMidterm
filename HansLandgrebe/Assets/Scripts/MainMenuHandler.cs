using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("GameScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
