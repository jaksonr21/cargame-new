using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float camHeight;

    GameObject Body;



    // Start is called before the first frame update
    void Start()
    {
        Body = GameObject.Find("Body");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Body.transform.position.x, camHeight, -10);





    }
}
