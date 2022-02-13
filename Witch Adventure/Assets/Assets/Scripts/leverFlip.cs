using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverFlip : MonoBehaviour
{
    public Animator leverAnim;
    public AudioSource drainSound;
    public AudioSource ambientWaterSound;
    public Collider plyr;
    private bool entered = false;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        leverAnim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider plyr) {
        if (plyr.tag == "Player")
        {
            entered = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 1 && entered && plyr.tag == "Player")
        {
            counter++;
            leverAnim.Play("LeverFlip");
            drainSound.Play();
            ambientWaterSound.Stop();
        }
        
    }
}
