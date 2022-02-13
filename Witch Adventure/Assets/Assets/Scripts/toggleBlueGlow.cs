using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleBlueGlow : MonoBehaviour
{
    public Light blueLight;

    private bool entered = false;
    public Collider plyr;
    // Start is called before the first frame update
    void Start()
    {
        blueLight = GetComponent<Light>();

    }
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            blueLight.enabled = true;

        }
    }
}
