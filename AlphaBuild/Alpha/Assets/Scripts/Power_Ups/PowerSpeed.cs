using UnityEngine;
using System.Collections;

public class PowerSpeed : MonoBehaviour {

    private ControlScript controlScript;
    private int duration = 5;
    public int powerSpeed;

	// Use this for initialization
	void Start () {

		//Logic fra Internett, usikker på nødvenigheten av bool-check.
		//Bruker vanligvis kun GetComponet.
        GameObject referenceObj = GameObject.Find("Player");
        if (referenceObj != null)
        {
            controlScript = referenceObj.GetComponent<ControlScript>();
        }

        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    	//Mye av metoden, bruker vår logic og kode, men coroutiner er inspirasjon fra Internett.
        void OnTriggerEnter(Collider other) {

            

            if (other.tag == "PowerSpeed")
            {

                Destroy(other.gameObject);
                controlScript.speed = powerSpeed;
                
                //Runs IEnumerator waitTime() to set duration of powerup
                StartCoroutine("PowerSpeedDuration");
            }
    }

    IEnumerator PowerSpeedDuration()
    {
        
        yield return new WaitForSeconds(duration);
        controlScript.speed = 10;

    }


}
