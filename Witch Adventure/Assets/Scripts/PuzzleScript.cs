using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Management of Grab and release
/// </summary>
public class PuzzleScript : MonoBehaviour
{
    public Transform floatPoint;
    public float launchSpeed; //The speed of the float point
    public int countTimes = 0;
    public Transform recipeBook;
    public AudioSource dropBooks;
    public GameObject dropDialogue;
    public GameObject exitDialogue;

    public AudioSource magicSound;
    

    public float weaponRange = 15f;

    //Variable to keep track of how obj is moving
    bool isAttracting;

    public GRABOBJ currentOBJ;
    public Transform target;
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
        //Raycast is just simply shooting a straight laser hidden object from a point
        RaycastHit hit;

        //If we dont have a target we are hitting right now, use the raycast from our camera position forward to the weapon range variable
        //Then if we hit something with the "cangrab" tag, we set the target to the object we hit, we get the rigidbody so we can elimate gravity
        //The move the thing towards use and remove gravity to it sits in front of us
        //Could have made it a child but then got into issues with its movement not working
        if (currentOBJ  == null)
        {
            if (Physics.Raycast(target.transform.position, target.transform.forward, out hit, weaponRange))
            {
                if (hit.transform.tag == "CanGrab1")
                {
                    currentOBJ = hit.transform.GetComponent<GRABOBJ>();
                    currentOBJ.ONGRAB(target);
                    isAttracting = true;
                    magicSound.Play();
                }
            }
        }
      
    }
    
    //Release (Just makes no target and adds gravity
    private void Release()
    {
        if(!isAttracting)
        {
            return;
        }
        isAttracting = false;
        //target.transform.position = Vector3.MoveTowards(target.transform.position, floatPoint.position, 0.3f);
        RaycastHit hitFor;
        if (Physics.Raycast(target.transform.position, target.transform.forward, out hitFor, 100, 1 << LayerMask.NameToLayer("Target")) && currentOBJ != null)
        {
            bool right = hitFor.transform.GetComponent<Grid>().OnRelese(currentOBJ);
            if (right)
            {
                countTimes++;
                currentOBJ = null;
                if (countTimes >= 5)
                {
                    recipeBook.localPosition = new Vector3(-56.3f,-0.55f,54.3f);
                    magicSound.Play();
                    dropBooks.Play();
                    dropDialogue.SetActive(true);
                    exitDialogue.SetActive(true);
                    return;
                }
            }
        }
        if (currentOBJ !=null)
        {
            currentOBJ.RELESE();
            magicSound.Play();
            dropBooks.Play();
            currentOBJ = null;
        }
    }
}
