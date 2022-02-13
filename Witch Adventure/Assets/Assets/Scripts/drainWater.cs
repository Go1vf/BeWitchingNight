using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drainWater : MonoBehaviour
{
    public Animator drainAnim;
    [SerializeField] GameObject teleportTrigger;
    public Collider plyr;
    private bool entered = false;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        drainAnim = GetComponent<Animator>();
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
            drainAnim.Play("drain");
            teleportTrigger.SetActive(false);

        }
        
    }
}
