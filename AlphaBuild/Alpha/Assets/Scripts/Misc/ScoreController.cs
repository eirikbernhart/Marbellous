using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


//Inspirasjon fra UI youtube-tutorial(se link i eget doc), men
//etter forum-surfing vedr Unity 5, kunne vi ikke bruke GUITEXT, men TEXT.
public class ScoreController : MonoBehaviour {

    private int coinsRemaining;
    public Text intGameScore;
    public Text goalMenuScore;
    public Text lastGoalScore;
    public Text failedScore;
    private int score;

	public List<GameObject> coins;

    // Use this for initialization
    void Start () {
        score = 0;
		coinsRemaining = GameObject.FindGameObjectsWithTag ("Coin").Length * 10;
        UpdateScore();


		/*coins = new List<GameObject>();
		coins.Add (GameObject.FindWithTag ("Coin"));

		foreach(GameObject item in coins) {

		}*/


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore(int newScoreValue) {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore() {

		//int coinsRemaining = coins.Count;
		//int coinsRemaining = GameObject.FindWithTag ("Coin");
		intGameScore.text = "Score: " + score + " / " + coinsRemaining;
        goalMenuScore.text = "" + score;
        lastGoalScore.text = "" + score;
        failedScore.text = "" + score;
    }
}
