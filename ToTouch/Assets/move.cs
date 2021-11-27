using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

     private Vector3 targetPos;
     public float speed = 2.0f;
     
     void Start() {
         targetPos = transform.position;    
     }
     
     void FixedUpdate () {
             float distance = transform.position.z - Camera.main.transform.position.z;
             targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
             targetPos = Camera.main.ScreenToWorldPoint(targetPos);
 
         Vector3 followXYonly = new Vector3(targetPos.x, targetPos.y, 0);
         Quaternion target = Quaternion.Euler(0, 0, 0);
         transform.rotation = target;
         transform.position = Vector3.Lerp (followXYonly, followXYonly, speed * Time.deltaTime);

    
     }
    // private Camera cam;

    // void Start()
    // {
    //     cam = Camera.main;
    // }

    // void FixedUpdate()
    // {
    //     Vector3 point = new Vector3();
    //     Event   currentEvent = Event.current;
       


    //     point = cam.ScreenToWorldPoint(new Vector3(0, Input.mousePosition.y, Input.mousePosition.x));
    //     transform.position = point;
    // }
    
}
