using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour
{

    public Canvas quitMenu;
    public Canvas levelSelectMenu;
    public Button startButton;
    public Button levelSelectButton;
    public Button exitButton;
    public GameObject btnCanvas;


    // Use this for initialization
    void Start()
    {

        quitMenu.enabled = false;
        levelSelectMenu.enabled = false;

    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
        btnCanvas.SetActive(false);
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        btnCanvas.SetActive(true);
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelSelect()
    {
        levelSelectMenu.enabled = true;
        btnCanvas.SetActive(false);
    }

    public void BackButton()
    {
        levelSelectMenu.enabled = false;
        btnCanvas.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }



}
