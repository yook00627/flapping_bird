using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // getting game start canvas object
    public GameObject gameStartCanvas;
    // getting gameover canvas object
    public GameObject gameOverCanvas;
    // checking if game is running
    private bool gameRunning = true;
    // check if game started once made it static to trigger globally
    private static bool gameStartOnce = false;

    private void Start()
    {
        // setting screen size limitation
        int width = 900;
        int height = 1600;
        bool isFullScreen = false;
        int desiredFPS = 60;
        Screen.SetResolution(width, height, isFullScreen, desiredFPS);

        // start the game timer
        gameOverCanvas.SetActive(false);
        //checking if game have started once or not
        if (!gameStartOnce)
        {
            gameStartCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            gameStartCanvas.SetActive(false);
        }
    }

    private void Update()
    {
        // starting game when pressed space
        if (Input.GetKeyDown("space") && !gameStartOnce)
        {
            StartGame();
            gameStartCanvas.SetActive(false);
            gameStartOnce = true;
        }
        // reset game when space is pressed and is game over
        if (Input.GetKeyDown("space") && !gameRunning)
        {
            Restart();
        }
    }

    // start game when pressed space
    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        // game over canvas is displayed
        gameOverCanvas.SetActive(true);
        // stop the game timer
        Time.timeScale = 0;
        // set game running to false
        gameRunning = false;
    }

    // restart game by loading scene
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
