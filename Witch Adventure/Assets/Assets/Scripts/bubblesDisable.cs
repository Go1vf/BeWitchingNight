using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblesDisable : MonoBehaviour
{
    public Renderer bubbles;

    private bool entered = false;
    public Collider plyr;
    // Start is called before the first frame update
    void Start()
    {
        bubbles = GetComponent<Renderer>();

    }
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            bubbles.enabled = false;

        }
    }
}