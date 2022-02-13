using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liquidToggle : MonoBehaviour
{
    public Renderer liquid;

    private bool entered = false;
    public Collider plyr;
    // Start is called before the first frame update
    void Start()
    {
        liquid = GetComponent<Renderer>();

    }
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            liquid.enabled = false;

        }
    }
}
