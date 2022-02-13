using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRABOBJ : MonoBehaviour
{
    public int ID;
    public Transform target;
    public bool arrive;
    public float speed = 1;

    public bool Follow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ONGRAB(Transform tr )
    {
        SETTRAGET(tr,true);

    }
    public void RELESE()
    {
        Follow = false ;
        target = null;

    }
    public void SETTRAGET(Transform tr,bool usergravity)
    {
        Follow = true;
        target = tr;
        arrive = false;
        //GetComponent<Rigidbody>().useGravity = usergravity;
    }
    // Update is called once per frame
    void Update()
    {
        if(Follow)
        {
            if (!arrive)
            {
                transform.position = Vector3.Slerp(transform.position, target.position, Time.deltaTime * speed);
                if (Vector3.Distance(transform.position, target.position) < 1f)
                {
                    arrive = true;
                }
            }
            else
            {
                transform.position = target.position;
                transform.rotation = target.rotation;
            }
        }
      
    }
}
