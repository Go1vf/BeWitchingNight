using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameToggle2 : MonoBehaviour
{
    /*public GameObject light;
    private bool on = false;
    
    void OnTriggerStay(Collider plyr) {
        if (plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            on = !on;
            light.SetActive(on);
        }
    }*/

    private bool on = true;
    private bool entered = false;
    public Collider plyr;
    public AudioSource flameSound;
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            on = !on;
            this.GetComponent<Light> ().enabled = on;
            flameSound.Play();
        }
    }

}
