using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jackolanternSwitch : MonoBehaviour
{
    //public Renderer boringPumpkin;
    public Renderer coolPumpkin;

    private bool entered = false;
    public Collider plyr;
    // Start is called before the first frame update
    void Start()
    {
        //boringPumpkin = GetComponent<Renderer>();
        coolPumpkin = GetComponent<Renderer>();
    }
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    /*void OnTriggerExit(Collider plyr) {
        entered = false;
    }*/
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            //boringPumpkin.enabled = false;
            coolPumpkin.enabled = true;
        }
    }
}
