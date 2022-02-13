using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lawnGrowth : MonoBehaviour
{
    public Animator lawn;
    public AudioSource growthMagic;
    private int counter;
    //public Collider plyr;
    //private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        lawn = GetComponent<Animator>();
        counter = 0;
        
    }

    /*void OnTriggerEnter(Collider plyr) {
        entered = true;
    }

    void OnTriggerExit(Collider plyr) {
        entered = false;
    }*/

    // Update is called once per frame
    void Update()
    {
        if (counter < 1 && Input.GetKeyDown("g"))
        {
            counter++;
            lawn.Play("LawnGrowth");
            growthMagic.Play();
        }
        
    }
}
