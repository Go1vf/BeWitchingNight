using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickDropScript : MonoBehaviour
{
    public float launchSpeed;

    public AudioSource magicSound;

    bool isAttracting;

    public GRABOBJ currentOBJ;
    public Transform target;

    public float weaponRange = 25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attract();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Release();
        }
    }

    private void Attract()
    {
        if (isAttracting) return;
        RaycastHit hit;

        //If we dont have a target we are hitting right now, use the raycast from our camera position forward to the weapon range variable
        //Then if we hit something with the "cangrab" tag, we set the target to the object we hit, we get the rigidbody so we can elimate gravity
        //The move the thing towards use and remove gravity to it sits in front of us
        //Could have made it a child but then got into issues with its movement not working
        if (currentOBJ == null)
        {
            if (Physics.Raycast(target.transform.position, target.transform.forward, out hit, weaponRange))
            {
                if (hit.transform.tag == "BigObject")
                {
                    currentOBJ = hit.transform.GetComponent<GRABOBJ>();
                    if(currentOBJ == null)
                    {
                        return;
                    }
                    currentOBJ.ONGRAB(target);
                    isAttracting = true;
                    magicSound.Play();
                    Debug.Log("Pumpkin Picked");
                }
            }
        }
    }
    private void Release()
    {
        if (!isAttracting)
        {
            return;
        }
        isAttracting = false;
        if (currentOBJ != null)
        {
            currentOBJ.RELESE();
            magicSound.Play();
            currentOBJ = null;
        }
    }
}




