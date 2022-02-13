using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HutDoorOC : MonoBehaviour
{
    [SerializeField] Animator doorPivot;
    public AudioSource creakSound;
    private bool entered = false;
    private bool opened = false;

    [SerializeField] Collider other;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            entered = true;
            Debug.Log("You entered door");
        }


    }

    void OnTriggerExit(Collider other)
    {
        entered = false;
        Debug.Log("You exited door");
    }

    // Update is called once per frame
    void Update()
    {
        if (entered && other.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !opened)
        {
            doorPivot.Play("HutDoor", 0, 0.0f);
            Debug.Log("What hell");
            creakSound.Play();
            opened = true;
        } else if (entered && other.tag == "Player" && Input.GetKeyDown(KeyCode.E) && opened)
        {
            doorPivot.Play("HutDoorClose", 0, 0.0f);
            creakSound.Play();
            opened = false;
        }
    }
}
