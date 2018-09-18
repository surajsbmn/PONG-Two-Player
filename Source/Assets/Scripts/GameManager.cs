using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Score to win
    public int winScore = 5;

    public GameObject endGamePanel;

    //Winner text
    public Text winText;

    //game pause status
    public static bool GameIsPaused = false;

    //Pause menu UI reference
    public GameObject PauseMenuUI;

    private void Update()
    {
        //first to score winscore wins the game
        if (Ball.playerOneScore == winScore || Ball.playerTwoScore == winScore)
        {
            Time.timeScale = 0; //pause to show UI                 

            if (Ball.playerOneScore > Ball.playerTwoScore)
            {
                winText.text = "Player One Won!!!";     //player one win
            }
            else
            {
                winText.text = "Player Two Won!!!";     //player two win
            }

            //Show win UI
            endGamePanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
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
        GameIsPaused = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
    }

    //Restart level "PLAY AGAIN"
    public void RestartLevel()
    {
        //reset scores
        Ball.playerOneScore = 0;
        Ball.playerTwoScore = 0;

        //hide win UI
        endGamePanel.SetActive(false);

        //Reset time to unpause
        Time.timeScale = 1;

        //reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        //reset scores
        Ball.playerOneScore = 0;
        Ball.playerTwoScore = 0;

        //hide win UI
        endGamePanel.SetActive(false);

        //Reset time to unpause
        Time.timeScale = 1;

        //load main menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
