using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject ControlsPanel;

    //Load main game
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //show controls UI
    public void ShowControls()
    {
        ControlsPanel.SetActive(true);
    }

    //Hide Controls UI
    public void HideControls()
    {
        ControlsPanel.SetActive(false);
    }
}
