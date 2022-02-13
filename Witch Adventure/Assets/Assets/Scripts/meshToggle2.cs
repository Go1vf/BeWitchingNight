using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshToggle2 : MonoBehaviour
{
    private bool on = true;
    private bool entered = false;
    public Collider plyr;
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            on = !on;
            this.GetComponent<Renderer> ().enabled = on;
        }
    }
}
