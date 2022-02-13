using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mashMushroom : MonoBehaviour
{
    [SerializeField] Animator dropShroomAnim;
    [SerializeField] Animator pestleMashAnim;
    [SerializeField] Animator goopAnim;

    public GameObject pickGoop;
    private static bool mushroom;
    public AudioSource pestleSound;

    private int counter = 0;
    public Collider plyr;
    private bool entere = false;

    /*void OnTriggerEnter(Collider plyr) {
        if (plyr.tag == "Player" && counter < 1)
        {
            counter++;
            dropShroomAnim.Play("DropMushroom");
            pestleMashAnim.Play("PestleMashing");
            StartCoroutine(wait());
            //glitterSound.Play();
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        pestleSound.Play();
        goop.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    void OnTriggerEnter(Collider plyr) {
        if (plyr.tag == "Player")
        {
            mushroom = BAGOBJCheck.hasMushroom;
            entere = true;
            Debug.Log("You entered Mushroom");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mushroom && entere && plyr.tag == "Player" && counter < 1 && Input.GetKeyDown("e"))
        {
            counter++;
            dropShroomAnim.Play("DropMushroom");
            pestleMashAnim.Play("PestleMashing");
            goopAnim.Play("goopAppears");
            
            pestleSound.PlayDelayed(2);
            //goop.enabled = true;
            //glitterSound.Play();
            pickGoop.SetActive(true);
}
    }
}
