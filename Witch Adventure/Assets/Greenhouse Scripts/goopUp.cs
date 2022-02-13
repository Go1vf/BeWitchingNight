using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goopUp : MonoBehaviour
{
    public Collider plyr;
    private bool entere = false;
    public GameObject goop;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.tag == "Player")
        {
            entere = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (entere && plyr.tag == "Player" && counter < 1 && Input.GetKeyDown("e"))
        {
            goop.SetActive(false);
        }
    }
}
