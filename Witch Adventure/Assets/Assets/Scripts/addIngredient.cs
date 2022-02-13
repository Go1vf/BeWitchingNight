using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addIngredient : MonoBehaviour
{
    [SerializeField] Animator dropIngredientAnim;
    [SerializeField] Animator ladleStirAnim;
    [SerializeField] ParticleSystem poofEffect;

    public AudioSource plopSound;
    public AudioSource poofSound;
    public static bool gameOver;

    private int counter = 0;
    public Collider plyr;
    private static bool entered;

    void OnTriggerEnter(Collider plyr) {
        if (plyr.tag == "Player")
        {
            entered = BAGOBJCheck.hasMushroom;
            Debug.Log("You entered Cauldron");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (entered && plyr.tag == "Player" && counter < 1 && Input.GetKeyDown("e"))
        {
            counter++;
            dropIngredientAnim.Play("dropGoop");
            ladleStirAnim.Play("LadleStir");
            
            plopSound.PlayDelayed(1);

            poofEffect.Play();
            poofSound.PlayDelayed(5);
            gameOver = true;
            //goop.enabled = true;
            //glitterSound.Play();
        }
    }
}
