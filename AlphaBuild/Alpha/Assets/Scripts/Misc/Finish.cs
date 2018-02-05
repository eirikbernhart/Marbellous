using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{

    public GameObject goalMenu;
    public GameObject lastGoalMenu;
    public GameObject score;
    public CamX camX;
    public CamY camY;

    void Start()
    {
        goalMenu.SetActive(false);
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            score.SetActive(false);
            goalMenu.SetActive(true);

            StartCoroutine("TweakFinish");
        }
        if (other.gameObject.tag == "LastGoal")
        {
            score.SetActive(false);
            lastGoalMenu.SetActive(true);
            StartCoroutine("TweakFinish");
        }

    }

    IEnumerator TweakFinish()
    {
        yield return new WaitForSeconds(.2f);
        Time.timeScale = 0;
        Cursor.visible = true;
        camX.enabled = false;
        camY.enabled = false;

    }
}