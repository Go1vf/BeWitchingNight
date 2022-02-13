using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booksAnim : MonoBehaviour
{
    public Animator anim;
    //public AudioSource twirlSound;
    public Collider plyr;
    private bool entered = false;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }

    void OnTriggerExit(Collider plyr) {
        entered = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 1 && entered && plyr.tag == "Player")
        {
            counter++;
            anim.Play("bookFloat");
            //twirlSound.Play();
        }
        
    }
}
