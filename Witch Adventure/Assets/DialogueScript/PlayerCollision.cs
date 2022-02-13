using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    void OnTriggerEnter (Collision collisionInfo) {
        Debug.Log("we hit an obstacle");
        if (collisionInfo.collider.tag == "trunk")
        {
            Debug.Log("we hit an obstacle trunk");
           
        }
    }
}