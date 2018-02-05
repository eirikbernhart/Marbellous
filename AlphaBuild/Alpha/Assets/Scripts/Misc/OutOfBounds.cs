using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

    public GameObject failedMenu;
    public GameObject score;
    public Button restartLevelButton;
    public Button mainMenu;
    public CamX camX;
    public CamY camY;

    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "OutOfBounds")
        {
            score.SetActive(false);
            failedMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            camX.enabled = false;
            camY.enabled = false;

    }

    }

}
