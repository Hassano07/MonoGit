using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject objectToFollow;
    Transform myCamera;

	// Use this for initialization
	void Start () {

        myCamera = transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        float posX = objectToFollow.gameObject.transform.position.x;
        float posY = objectToFollow.gameObject.transform.position.y;
        myCamera.transform.position = new Vector3(posX, posY + 3, -10 );


	}

    public void MyThingy()
    {
        Debug.Log("mmmmmmm,");
    }
}
