using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
	
	GameObject body;
	Vector3 startPos;
	GameObject wheel_b;
	GameObject wheel_f;
	
	
    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.Find("Body");
		wheel_f = GameObject.Find("Wheel_F");
		wheel_b = GameObject.Find("Wheel_B");
		startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	private void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "Track")
		{
			body.transform.position = startPos;
			body.transform.rotation = Quaternion.identity;
			body.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			body.GetComponent<Rigidbody2D>().angularVelocity = 0;
			
			wheel_f.GetComponent<Rigidbody2D>().angularVelocity = 0;
			wheel_f.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			
			wheel_b.GetComponent<Rigidbody2D>().angularVelocity = 0;
			wheel_b.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			
		}
	}
	
	
	
	
}
