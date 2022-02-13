using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{

    public UnityEvent onPickup;
    public bool triggersOnceOnly;
    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (triggersOnceOnly && !triggered)
            {
                Debug.Log("Entered collider.");
                onPickup.Invoke();
                triggered = true;
            }
            if (!triggersOnceOnly)
            {
                Debug.Log("Entered collider.");
                onPickup.Invoke();
            }
        }
    }
}
