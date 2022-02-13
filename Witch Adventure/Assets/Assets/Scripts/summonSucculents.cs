using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonSucculents : MonoBehaviour
{
    public Animator succulents;
    public AudioSource puffSound; //change
    private int counter;
    public Collider plyr;
    private bool entered = false;
    // Start is called before the first frame update
    void Start()
    {
        succulents = GetComponent<Animator>();
        counter = 0;
        
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
            succulents.Play("summonSucculents");
            puffSound.Play();
        }
        
    }
}
