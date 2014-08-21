using UnityEngine;
using System.Collections;

public class ProtoManager : MonoBehaviour {

    //public GameObject mono;
    public GameObject cycle;
    public GameObject floor;
    public GameObject mono;

    float originalRotation;

    Vector2 initalPosition =  new Vector2 ( 0 , -3f);
	
    //public GameObject monoPlayer;
	// Use this for initialization
	
	public void Start () 
    {

        //mono = (GameObject)GameObject.Instantiate( mono, new Vector2 ( 0, -2), Quaternion.identity);
        
        //cycle = (GameObject)GameObject.Instantiate(cycle, new Vector2 (0, -1), Quaternion.identity);

		//floor = (GameObject)GameObject.Instantiate(floor, new Vector2(0, -3), Quaternion.identity);

		//floor = (GameObject)GameObject.Instantiate(Resources.Load("floor"), new Vector2(0, -5), Quaternion.identity);
        mono.gameObject.transform.rotation = Quaternion.identity;
        cycle.gameObject.transform.rotation = Quaternion.identity;
        cycle.gameObject.transform.position = initalPosition;
        mono.gameObject.transform.position = initalPosition;
        floor.gameObject.transform.position = new Vector2 (0,-5);

		// reset to false to allow forces to effect rigidbody
		mono.rigidbody2D.isKinematic = false;
		cycle.rigidbody2D.isKinematic = false;

	   
	}

    public void ReStart()
    {

        Debug.Log("Reastart");
        //cycle.gameObject.transform.Translate (0, 2, 0);

    }
	
//	// Update is called once per frame
//	void Update () 
//    {
//        Debug.Log(originalRotation);
//	
//	}


}
