using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaskToggleOn : MonoBehaviour
{
    public Renderer obj;
    private int counter;
    public Collider plyr;
    //private bool entered = false;
    //private bool waitBool;
    //public AudioSource sound;
    //private bool on = true;
    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<Renderer>();
        
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
        //sound.Play();
        obj.enabled = true;
       //waitBool = true;
       //obj = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
