using UnityEngine;
using System.Collections;

public class UpSideDown : MonoBehaviour {

    private CamScroll camScroll;
    private int duration = 5;
    float currentFov;
    public bool upSideDown = false;

    // Use this for initialization
    void Start () {
        camScroll = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CamScroll>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {



        if ((other.tag == "UpSideDown") || (other.tag == "ReverseGravity"))
        {
            currentFov = camScroll.fov;
            camScroll.fov = -65;
            upSideDown = true;
            Destroy(other.gameObject);

            //Runs IEnumerator waitTime() to set duration of powerup
            StartCoroutine("upSideDownPower");
        }
    }

    IEnumerator upSideDownPower()
    {
        yield return new WaitForSeconds(duration);
        camScroll.fov = currentFov;
        upSideDown = false;

    }

}
