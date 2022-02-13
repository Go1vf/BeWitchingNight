using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibDoorOC : MonoBehaviour
{
    [SerializeField] Animator doorPivot;
    public AudioSource creakSound;
    public AudioSource errorSound;
    private static bool key;
    private bool entered = false;
    private bool opened = false;

    public Collider other;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            entered = true;
            Debug.Log("You entered door");
        }

    }

    void OnTriggerExit(Collider other)
    {
        entered = false;
    }

    // Update is called once per frame
    void Update()
    {
        key = BAGOBJCheck.checkKeyEnable;
        if (entered && other.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !opened)
        {   
            if (key)
            {
                doorPivot.Play("LibDoorOpen", 0, 0.0f);
                creakSound.Play();
                Debug.Log("creakSound");
                opened = true;
            }
            if (!key)
            {
                errorSound.Play();
            }
        }
        else if (entered && other.tag == "Player" && Input.GetKeyDown(KeyCode.E) && opened)
        {
            if (key)
            {
                doorPivot.Play("LibDoorClose", 0, 0.0f);
                creakSound.Play();
                opened = false;
            }
            if (!key)
            {
                errorSound.Play();
            }
        }
    }
}
