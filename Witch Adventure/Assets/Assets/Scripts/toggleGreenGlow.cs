using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleGreenGlow : MonoBehaviour
{
    public Light greenLight;

    private bool entered = false;
    public Collider plyr;
    // Start is called before the first frame update
    void Start()
    {
        greenLight = GetComponent<Light>();

    }
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            greenLight.enabled = false;

        }
    }
}
