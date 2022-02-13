using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeTrigger : MonoBehaviour
{
    public ParticleSystem poof;
    private int counter;
    public Collider plyr;
    //private bool entered = false;
    //private bool waitBool;
    //private bool on = true;
    // Start is called before the first frame update
    void Start()
    {
        poof = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider plyr) { //check scope
        //entered = true;
        //sound.Play();
        if (plyr.tag == "Player" && counter < 1)
        {
            counter++;
            StartCoroutine(wait());
            //on = false;
            //obj.enabled = false;
            //sound.Play();
        }  
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.30F);
        poof.Play();
       //waitBool = true;
       //obj = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
