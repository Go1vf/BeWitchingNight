using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandPickUp : MonoBehaviour
{
    [SerializeField] GameObject tableWand;
    [SerializeField] GameObject handWand;
    [SerializeField] GameObject handWandActual;

    public Collider other;

    private bool entered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            entered = true;
            Debug.Log("You entered Wand");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        entered = false;
    }

    private void Update ()
    {
        if (other.CompareTag("Player") && entered && Input.GetKeyDown(KeyCode.E))
        {
            //hide that wand
            tableWand.SetActive(false);
            //Set our hand wand active
            handWand.SetActive(true);
            handWandActual.SetActive(true);
        }
    }
}
