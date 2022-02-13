using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poof : MonoBehaviour
{
    [SerializeField] ParticleSystem poofEffect;
    public AudioSource poofSound;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "crumbs") {
            poofEffect.Play();
            poofSound.Play();
        }
    }

    void Update () {

    }
}
