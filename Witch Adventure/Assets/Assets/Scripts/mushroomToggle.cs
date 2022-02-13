using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomToggle : MonoBehaviour
{
    public Renderer mushrooms;
    private int counter;
    public Collider plyr;
    //private bool entered = false;
    //private bool waitBool;
    public AudioSource poofSound;
    //private bool on = true;
    // Start is called before the first frame update
    void Start()
    {
        mushrooms = GetComponent<Renderer>();
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
        poofSound.Play();
        mushrooms.enabled = true;
       //waitBool = true;
       //obj = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
