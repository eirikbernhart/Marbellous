using UnityEngine;
using System.Collections.Generic;

public class CoinCollect : MonoBehaviour {
	
	
	//public List<GameObject> coins;
    public int scoreValue;

    private ScoreController scoreController;

	// Use this for initialization
	void Start () {
		//Logic fra Internett, usikker på nødvenigheten av bool-check.
		//Bruker vanligvis kun GetComponet.
        GameObject referenceObj = GameObject.Find("Player");
        if(referenceObj != null) {
            scoreController = referenceObj.GetComponent <ScoreController> ();
        }
		//coins = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Skrevet av oss
	void OnTriggerEnter(Collider other) {
		
		if (other.tag == "Coin") {
            
			Destroy(other.gameObject);
			//Inspirasjon fra UI youtube-tutorial(se link i eget doc)
            scoreController.AddScore(scoreValue);
        }
	}
	
}
