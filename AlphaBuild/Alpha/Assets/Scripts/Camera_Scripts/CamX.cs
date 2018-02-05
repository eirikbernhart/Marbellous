using UnityEngine;
using System.Collections;

//Logic fra medelev, det å bruke transform når du roterer på musen, 
//for å kunne bevege deg etter musepekeren.
//camX og camY var originialt i samme klasse, men vi splittet det i to, slik at roteringen 
//ikke roterer "skeivt".
public class CamX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        rotateHorizontal();

    }

    void rotateHorizontal()
    {
        float vectorX = Input.GetAxis("mouseX");


        transform.Rotate(0, vectorX, 0);

    }
}

