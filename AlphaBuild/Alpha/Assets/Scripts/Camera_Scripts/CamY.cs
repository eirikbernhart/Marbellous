using UnityEngine;
using System.Collections;

//Logic fra medelev, det å bruke transform når du roterer på musen, 
//for å kunne bevege deg etter musepekeren.
//camX og camY var originialt i en samme klasse, men vi splittet det i to, slik at roteringen 
//ikke roterer "skeivt".
public class CamY : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        rotateVertical();
        

    }

    //Move player with mouseposition
    void rotateVertical()
    {
        float vectorY = Input.GetAxis("mouseY");


        transform.Rotate(vectorY, 0, 0);

    }

}
