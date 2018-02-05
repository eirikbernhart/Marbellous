using UnityEngine;
using System.Collections;

public class MiniPlayer : MonoBehaviour {

    public GameObject player;
    public float scale = 0.5f;
    public bool active;
    public GameObject Map;
    private GameObject Minimize;
    private int duration = 5;
    private Vector3 normalScale;
    

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        Minimize = GameObject.FindGameObjectWithTag("Minimize");

        if (Minimize != null)
        {
            Minimize.transform.localScale *= 0.2f;
        }
        
    }
	
	// Update is called once per frame
	void Update () {

        if (active == true) minimize();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Minimize")
        {
            Destroy(col.gameObject);
            active = true;
            StartCoroutine("scaleTime");
        }
    }

    IEnumerator scaleTime()
    {
        yield return new WaitForSeconds(duration);
        player.transform.localScale = normalScale;

    }

    private void minimize()
    {
        normalScale = player.transform.localScale;
        player.transform.localScale *= scale;
        active = false;
    }
}
