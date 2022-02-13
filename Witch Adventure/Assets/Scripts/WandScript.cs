using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandScript : MonoBehaviour
{
    //Variables :)

    //The wand will send out this point to the object you want to hit
    public Transform floatPoint;
    public float launchSpeed; //The speed of the float point

    public AudioSource magicSound;

    Camera camera;

    //The Thing we want to target
    GameObject target;
    Rigidbody targetRig;

    public float weaponRange = 15f;

    //Variable to keep track of how obj is moving
    bool isAttracting;
    //bool isLaunching;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Attract input
        if (Input.GetButtonDown("Fire1"))
        {
            isAttracting = true;
        }
        //Release input
        if (isAttracting)
        {
            if(Input.GetButtonDown("Fire2"))
            {
                //isLaunching = true;
                isAttracting = false;
            }
        }
    }
    //Will make sure it updates with our fps since we have movement of an object
    private void FixedUpdate()
    {
        //If we are holding down left click keep it moving towards us
        if (isAttracting)
        {
            Attract();
        //If we let go have it move away
        } else if (!isAttracting)
        {
            Release();
        }

        /*if(isLaunching)
        {
            Throw();
        }
        */
    }

    private void Attract()
    {
        //Raycast is just simply shooting a straight laser hidden object from a point
        RaycastHit hit;

        //If we dont have a target we are hitting right now, use the raycast from our camera position forward to the weapon range variable
        //Then if we hit something with the "cangrab" tag, we set the target to the object we hit, we get the rigidbody so we can elimate gravity
        //The move the thing towards use and remove gravity to it sits in front of us
        //Could have made it a child but then got into issues with its movement not working
        if (target == null)
        {
            if (Physics.Raycast(camera.transform.position, camera.transform.forward,out hit, weaponRange))
            {
                if (hit.transform.tag == "CanGrab")
                {
                    target = hit.transform.gameObject;
                    targetRig = target.GetComponent<Rigidbody>();
                    target.transform.position = Vector3.MoveTowards(target.transform.position, floatPoint.position, 0.3f);
                    targetRig.useGravity = false;

                    magicSound.Play();
                }
            }
        }
        //If we already have an object, keep it floating in front of our camera
        else
        {
            target.transform.position = Vector3.MoveTowards(target.transform.position, floatPoint.position, 0.3f);
        }
    }
    //Release (Just makes no target and adds gravity
    private void Release()
    {
        if (target != null)
        {
            targetRig.useGravity = true;
            target = null;

            magicSound.Play();
        }
    }
    // Throw Mechanic In case we want it
    /*private void Throw()
    {
        if (targetRig != null)
        {
            targetRig.useGravity = true;
            targetRig.AddForce(floatPoint.transform.forward * launchSpeed, ForceMode.Impulse);
            target = null;
            isLaunching = false;
        }
    }*/
}
