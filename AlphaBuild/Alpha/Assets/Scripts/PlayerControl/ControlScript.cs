using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour
{
    //Movement
    public Rigidbody rb;
    public float speed = 10;
    public Camera myCamera;
    Vector3 moveHorizontal;
    Vector3 moveVertical;

    //Hide GUI on start
    public GameObject failedMenu;
    public GameObject goalMenu;
    public GameObject lastGoalMenu;

    //Jump variables
    public float jumpPower = 15;
    float time = 1.5f;
    float velocityCheck = 0;
    public bool onFloor; //Disable infinite jumping...
    bool jumpBool = false;
    

    // Use this for initialization
    void Start() {

        goalMenu.SetActive(false);
        failedMenu.SetActive(false);
        lastGoalMenu.SetActive(false);

        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        getWASD();
        jump();

    }

	
    void getWASD() //For mere info, se camX, og camY scriptet.
    {
        if (onFloor)
        {
            moveHorizontal = myCamera.transform.right * Input.GetAxisRaw("Horizontal") * speed;
            moveVertical = myCamera.transform.forward * Input.GetAxisRaw("Vertical") * speed;
        }
        else
        {
            moveHorizontal = myCamera.transform.right * Input.GetAxisRaw("Horizontal") * 2;
            moveVertical = myCamera.transform.forward * Input.GetAxisRaw("Vertical") * 2;
        }

        rb.AddForce(moveHorizontal + moveVertical);
    }

    void jump()
    {
        
        bool jump = Input.GetKeyDown(KeyCode.Space);

        if (rb.velocity == Vector3.up * 2) time -= 10000f;

        if (jump && onFloor) jumpBool = true;

        if (jumpBool && time > 0)
        {
            time -= Time.deltaTime;

            rb.AddForce(Vector3.up * jumpPower * time);
        }

        if (time <= 0)
        {
            jumpBool = false;
            time = 1.5f;
        }

    }

    void OnCollisionStay(Collision col)
    {
        onFloor = true;
    }

    void OnCollisionExit(Collision col)
    {
        onFloor = false;   
    }

	IEnumerator cheatFix1()
	{
		yield return new WaitForSeconds(.1f);
		onFloor = true;
		
	}


}