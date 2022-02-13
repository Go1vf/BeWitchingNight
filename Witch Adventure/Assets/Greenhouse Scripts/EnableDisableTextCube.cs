using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableTextCube : MonoBehaviour
{
    public GameObject textCube;
    public Collider other;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textCube.SetActive(false);

        }
    }
}
