using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public ParticleSystem poof;
    private int counter;
    public Collider plyr;
    private bool entered = false;
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

    // Update is called once per frame
    void Update()
    {
        if (entered && counter < 1 && Input.GetMouseButtonDown(0))
        {
            counter++;
            poof.Play();
        }
    }
}
