using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    float timer;
    public Text txtTime;
    public Text txtTimeGoal;
    public Text txtTimeFailed;
    public Text txtTimeLast;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        txtTime.text = txtTimeGoal.text = txtTimeFailed.text = txtTimeLast.text = Math.Round(timer, 0) + "";
	
	}
}
