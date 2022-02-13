using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamToggle : MonoBehaviour
{
    public ParticleSystem steam;

    private bool entered = false;
    public Collider plyr;
    // Start is called before the first frame update
    void Start()
    {
        steam = GetComponent<ParticleSystem>();
    }
    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0)) {
            steam.Stop();

        }
    }
}
