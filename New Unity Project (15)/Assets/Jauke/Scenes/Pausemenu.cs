using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour { 
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public KeyCode menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Menu))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }

        }
        void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        void pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
}
