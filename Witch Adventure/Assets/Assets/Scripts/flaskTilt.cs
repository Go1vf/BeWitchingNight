using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaskTilt : MonoBehaviour
{
    public Animator anim;
    //public Renderer flask;
    //private Renderer liquid;
    public AudioSource clankSound;
    private int counter;
    public Collider plyr;
    private bool entered = false;
    //private bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //flask = GetComponent<Renderer>();
        //liquid = GetComponentInChildren<Renderer>();
        counter = 0;
        
    }

    void OnTriggerEnter(Collider plyr) {
        entered = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (entered && plyr.tag == "Player" && counter < 1)
        {
            counter++;
            anim.Play("FlaskTilt");
            clankSound.Play();
            //on = !on;
            //flask.enabled = on;
        }
        
    }
}
