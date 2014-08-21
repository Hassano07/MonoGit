using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public GameObject floor;
	public GameObject clone;
	public GameObject cycle;
	public Vector3 newFloorPos;

//	public float spawnMin = 1f;
//	public float spawnMax = 2f;
	//public bool canSpawn = false;

	public void Start()
	{
		//StartCoroutine(Spawner());
		//floor = GameObject.FindGameObjectWithTag ("floor");

		newFloorPos = floor.transform.position;
	}

//	void Spawn()
//	{
//		Instantiate (floor, transform.position, Quaternion.identity);
//		Invoke("Spawn", Random.Range (spawnMin, spawnMax));
//	}
	 
//	IEnumerator Spawner(){
//		while(true){
//			Instantiate(obj, new Vector2 (obj.transform.position.x + 5, obj.transform.position.y - 2), Quaternion.identity);
//			//or instead of Quaternion.identity use obj.transform.rotation
//			yield return new WaitForSeconds(10f);
//		}
//
//	}

	void Update ()
	{

		// if player pos is greater then floor pos then create new floor and update newFloorPos position to reflect the new floor created positsion
		if (cycle.transform.position.x > newFloorPos.x + 6) 
		{
			newFloorPos.x = newFloorPos.x + 10;
			newFloorPos.y = newFloorPos.y - 1;
			Instantiate(clone, newFloorPos, Quaternion.identity);
		}
		else if (cycle.transform.position.x < newFloorPos.x - 6)
		{
			newFloorPos.x = newFloorPos.x - 10;
			newFloorPos.y = newFloorPos.y - 1;
			Instantiate(clone, newFloorPos, Quaternion.identity);
		}

	}

//	void OnBecameInvisible() 
//	{
//		Destroy (gameObject);
//	}
}

