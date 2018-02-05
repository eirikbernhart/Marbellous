using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public Canvas pauseMenu;

	//private int nextLevel = 1;

	public Button nextLevelButton;
	public Button restartLevelButton;
	public Button exitButton;
    public Button resume;
    public CamX camX;
    public CamY camY;
    private int currentScene;

    // Use this for initialization
    void Start() {

        currentScene = SceneManager.GetActiveScene().buildIndex;
        pauseMenu.enabled = false;
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.enabled = true;
            Time.timeScale = 0;
            Cursor.visible = true;
            camX.enabled = false;
            camY.enabled = false;
        }
    }
	public void MainMenu()
	{
        Time.timeScale = 1;
        Cursor.visible = true;
        SceneManager.LoadScene("scene0");
    }

	public void Restart()
	{
		Time.timeScale = 1;
        camX.enabled = true;
        camY.enabled = true;
        Cursor.visible = false;
        SceneManager.LoadScene(currentScene);
    }

	public void Resume()
	{
		pauseMenu.enabled = false;
        camX.enabled = true;
        camY.enabled = true;
        Cursor.visible = false;
		Time.timeScale = 1;

	}

	public void NextLevel()
	{
		Time.timeScale = 1;
        SceneManager.LoadScene(currentScene + 1);
    }


}
