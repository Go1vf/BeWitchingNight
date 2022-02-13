using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionPoof : MonoBehaviour
{
    public ParticleSystem poof;
    private bool entered = false;
    public Collider plyr;
    public AudioSource poofSound;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        poof = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }
    void OnTriggerExit(Collider plyr) {
        entered = false;
    }
    void Update () {
        if (entered && plyr.tag == "Player" && Input.GetMouseButtonDown(0) && counter < 1) {
            counter++;
            poof.Play();
            poofSound.Play();
        }
    }
}
