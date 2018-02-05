using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	private int currentLevel;

	// Use this for initialization
	void Start () 
	{
	
	}

	public void LevelSelect(int level) 
	{
        SceneManager.LoadScene (level);
	}
}