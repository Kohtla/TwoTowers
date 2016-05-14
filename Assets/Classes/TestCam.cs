using UnityEngine;
using System.Collections;

public class TestCam : MonoBehaviour {

    public GameObject camRig;
    public float speed = 10;
    Vector3 coords;

	// Use this for initialization
	void Start () 
    {
        camRig.transform.position = new Vector3(50, 50, -30);
        coords = camRig.transform.position;
                        	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (Input.GetKey(KeyCode.W))
        {
            coords.z += 10*Time.deltaTime;
            camRig.transform.position = coords;
        }
        if (Input.GetKey(KeyCode.S))
        {
            coords.z -= 10*Time.deltaTime;
            camRig.transform.position = coords;
        }
        if (Input.GetKey(KeyCode.A))
        {
            coords.x -= 10*Time.deltaTime;
            camRig.transform.position = coords;
        }
        if (Input.GetKey(KeyCode.D))
        {
            coords.x += 10*Time.deltaTime;
            camRig.transform.position = coords;
        }
	
	}
}
