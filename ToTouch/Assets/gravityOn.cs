using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityOn : MonoBehaviour
{
    void OnCollisionEnter (Collision CollisionInfo) {
        
        Debug.Log(CollisionInfo.collider.name);

        if (CollisionInfo.collider.tag == "rampOn"){
            GetComponent<Rigidbody>().useGravity = true;            
        }       
    }
}
