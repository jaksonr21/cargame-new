using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D Wheel_F, Wheel_B, Body;
    public float power, bodyPower;

    Vector3 startPos;

    Rigidbody2D rb;

    BoxCollider2D bc;

    public float jumpDetectOffset;

    public LayerMask jumpableObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        
        bc = gameObject.GetComponent<BoxCollider2D>();
        
        if (Input.GetKey("d"))
            {
            Wheel_F.AddTorque(-power);
            Wheel_B.AddTorque(-power);
			Body.AddTorque(-bodyPower);
             }
        if (Input.GetKey("s"))
        {
            Wheel_F.AddTorque(power);
            Wheel_B.AddTorque(power);
			Body.AddTorque(bodyPower);
        }
    }
     
    private void OnCollisionEnter2D (Collision2D c)
    {
      

        if (c.gameObject.tag == "Spawn")
        {
            Body.transform.position = startPos;
			Body.transform.rotation = Quaternion.identity;
			Body.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			Body.GetComponent<Rigidbody2D>().angularVelocity = 0;
			
			Wheel_F.GetComponent<Rigidbody2D>().angularVelocity = 0;
			Wheel_F.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			
			Wheel_B.GetComponent<Rigidbody2D>().angularVelocity = 0;
			Wheel_B.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, jumpDetectOffset, jumpableObjects);
        Color rayColor = Color.red;
        Debug.DrawRay(bc.bounds.center - new Vector3(bc.bounds.extents.x, bc.bounds.extents.y + jumpDetectOffset), Vector2.right * bc.bounds.size.x, rayColor);
        return raycastHit.collider != null;
    }
}
