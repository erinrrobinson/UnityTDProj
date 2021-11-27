using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityoff : MonoBehaviour
{
    void OnCollisionEnter (Collision CollisionInfo) {
        
        Debug.Log(CollisionInfo.collider.name);

        if (CollisionInfo.collider.tag == "ramp"){
            GetComponent<Rigidbody>().useGravity = false;            
        }       
    }
}
