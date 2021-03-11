using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCamController : MonoBehaviour
{
   public float redLineY;
     public float firstCameraY;
     public GameObject target;
 
     public float followAhead;
 
     private Vector3 targetPosition;
 
     public float smoothing;
 
     private Vector3 targetOffset = new Vector3(0,0,0);
 
     // Update is called once per frame
     void FixedUpdate()
     {
         //Makes camera move ahead of player
         if (target.transform.position.y > redLineY)
         {
             targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z) + targetOffset;//you can change the offset 
         }
         else
         {
             targetPosition = new Vector3(target.transform.position.x, firstCameraY, transform.position.z);
         }
 
         //transform.position = targetPosition;
 
         transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
     }
 }