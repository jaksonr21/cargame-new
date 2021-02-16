using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D Wheel_F, Wheel_B;
    public float power;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
            {
            Wheel_F.AddTorque(-power);
            Wheel_B.AddTorque(-power);
             }
        if (Input.GetKey("s"))
        {
            Wheel_F.AddTorque(power);
            Wheel_B.AddTorque(power);
        }
    }
}
