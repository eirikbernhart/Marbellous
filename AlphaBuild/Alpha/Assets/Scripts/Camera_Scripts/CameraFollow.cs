using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	
	//Kode, og logic av oss.
	void Update() {
		Vector3 pos = player.transform.position;
		//Vector3 pos = (player.transform.position.x, player.transform.position.y, player.transform.position.z);

		

		transform.position = pos;
    }

    

}





