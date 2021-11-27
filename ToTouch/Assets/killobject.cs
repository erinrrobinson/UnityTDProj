using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killobject : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 position;
    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Instantiate(sphere, position, Quaternion.identity);

    }
    
}
