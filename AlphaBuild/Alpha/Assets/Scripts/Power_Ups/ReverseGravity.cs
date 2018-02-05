using UnityEngine;
using System.Collections;

public class ReverseGravity : MonoBehaviour {

    public bool reverseGravity;
    private GameObject player;
    private Rigidbody rbPlayer;
    private ConstantForce playerForce;
    private int duration = 5;
    public float gravity;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerForce = player.GetComponent<ConstantForce>();
        rbPlayer = player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider other)
    {



        if (other.tag == "ReverseGravity")
        {
            playerForce.force = Physics.gravity * -1.098f;
            rbPlayer.useGravity = false;
            Destroy(other.gameObject);
            reverseGravity = true;
            //Runs IEnumerator waitTime() to set duration of powerup
            StartCoroutine("reverse");
        }
    }

    IEnumerator reverse()
    {
        
        yield return new WaitForSeconds(duration);
        playerForce.force = Physics.gravity * 0;
        rbPlayer.useGravity = true;
        reverseGravity = false;

    }

    private void reverseBool() {
        if (reverseGravity == true)
        {
            playerForce.force = Physics.gravity * gravity;
            rbPlayer.useGravity = false;
        } 
    }

}