using UnityEngine;
using System.Collections;

public class CamScroll : MonoBehaviour {

    private UpSideDown upSideDown;
    public float fov;
    public float scroll;

	// Use this for initialization
	void Start () {
        upSideDown = GameObject.FindGameObjectWithTag("Player").GetComponent<UpSideDown>();
        fov = Camera.main.fieldOfView;
        
        upSideDown = upSideDown.GetComponent<UpSideDown>();
    }
	
	// Update is called once per frame
	void Update () {
        Camera.main.fieldOfView = fov;

	    if((Input.GetAxis("Mouse ScrollWheel") < 0) && (fov < 110) && (upSideDown.upSideDown == false))
        {
            fov += 5;
        } else if ((Input.GetAxis("Mouse ScrollWheel") > 0) && (fov > 45) && (upSideDown.upSideDown == false))
        {
            fov -= 5;
        }
	}
}
