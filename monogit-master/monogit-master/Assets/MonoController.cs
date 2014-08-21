using UnityEngine;
using System.Collections;

public class MonoController : MonoBehaviour {

    ProtoManager protoManager;
	SpawnScript spawnScript;
    GameObject mono;
    GameObject cycle;
	GameObject floor;

	// array to refrence clone floor objects
	GameObject[] clone;

	// Use this for initialization
	void Start () 
    {
        try
        {
            protoManager = (ProtoManager)GameObject.Find("ProtoManagerObj").GetComponent<ProtoManager>();
			spawnScript = (SpawnScript)GameObject.Find("SpawnController").GetComponent<SpawnScript>();
            mono = (GameObject)GameObject.Find("Mono");
            cycle = (GameObject)GameObject.Find("Cycle");
            floor = (GameObject)GameObject.Find("floor");
        }
        catch
        {
            print("my little error");
	
        }
        

	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

    public void Again()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
            if (coll.gameObject.tag == "floor" || coll.gameObject.tag == "Clone")
            {
                //mono.gameObject.transform.rotation = Quaternion.identity;
                //cycle.gameObject.transform.rotation = Quaternion.identity;
                //Destroy(mono.gameObject);
                //Destroy(cycle.gameObject);
               // Debug.Log("Try again");
				
				DestroyCloneFloors();
				// set Kinematic to true to stop physics being applied to rigidbody
				mono.rigidbody2D.isKinematic = true;
				cycle.rigidbody2D.isKinematic = true;;

				protoManager.Start();
				spawnScript.Start();

            }
        
    }

	void DestroyCloneFloors()
	{
		// get objects with Clone tag and destroy them
		clone = GameObject.FindGameObjectsWithTag ("Clone");
		
		for(var i = 0 ; i < clone.Length ; i ++)
		{
			Destroy(clone[i]);
		}
	}

}
