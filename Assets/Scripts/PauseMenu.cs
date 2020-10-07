﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject PauseMenuUI;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
        if(GameIsPause)
        {
          Resume();
        }
        else
        {
          Pause();

        }
      }
    }

    public void Resume()
    {
      PauseMenuUI.SetActive(false);
      Time.timeScale = 1f;
      GameIsPause = false;
    }
    void Pause()
    {
      PauseMenuUI.SetActive(true);
      Time.timeScale = 0f;
      GameIsPause = true;
    }
    public void MainMenu()
    {
      Time.timeScale = 1f;
      SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
      Application.Quit();
    }
}