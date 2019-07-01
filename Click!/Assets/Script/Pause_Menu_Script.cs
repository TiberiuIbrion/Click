using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_Menu_Script : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsLost = false;
    public GameObject pauseMenuUI;
    public GameObject deathMenuUI;
    // Update is called once per frame

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Go_Home()
    {
        SceneManager.LoadScene(0);
        Score_Script.scoreValue = 0;
        Time.timeScale = 1;
        GameIsPaused = false;
        GameIsLost = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        GameIsLost = false;
        Time.timeScale = 1f;
        Score_Script.scoreValue = 0;
    }
    public void Lost_Game()
    {
        if (GameIsLost == true)
        {
            deathMenuUI.SetActive(true);
        }
    }

    void Update()
    {
        Lost_Game();
    }

}
