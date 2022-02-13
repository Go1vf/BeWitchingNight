using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quillAudio : MonoBehaviour
{
    private int counter;
    public Collider plyr;
    //private bool entered = false;
    //private bool waitBool;
    public AudioSource scribble;
    public AudioSource sparkle;
    //private bool on = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider plyr) { //check scope
        //entered = true;
        //sound.Play();
        if (plyr.tag == "Player" && counter < 1)
        {
            counter++;
            sparkle.Play();
            StartCoroutine(wait());
            //on = false;
            //obj.enabled = false;
            //sound.Play();
        }  
    }
    void OnTriggerExit(Collider plyr) {
        counter = 0;
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(2F);
        scribble.Play();
       //waitBool = true;
       //obj = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
