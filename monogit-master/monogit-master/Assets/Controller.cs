using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	


	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
			rigidbody2D.AddForce(new Vector2(-100, 0));

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody2D.AddForce(new Vector2(100, 0));

        }

		if (Input.GetButtonDown("Fire1")) 
		{
//			float mousex = (Input.mousePosition.x);
//			float mousey = (Input.mousePosition.y);
//			Vector2 mouseposition = Camera.main.ScreenToWorldPoint(new Vector3 (mousex,mousey,0));

			Vector2 mouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

			if (mouse.x < Screen.width/2)
			{
				// move left
				rigidbody2D.AddForce(new Vector2(-100, 0));
			}

			else if (mouse.x > Screen.width/2)
			{
				// move right
				rigidbody2D.AddForce(new Vector2(100, 0));
			}

			
		}
	}
}
