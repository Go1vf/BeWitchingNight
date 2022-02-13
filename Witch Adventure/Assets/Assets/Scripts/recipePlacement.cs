using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipePlacement : MonoBehaviour
{
    public Animator anim;
    public Renderer recipe;

    public AudioSource glitterSound;

    private int counter;
    public Collider plyr;
    private bool entered = false;
    private static bool recipeBook;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        recipe = GetComponent<Renderer>();
        //flask = GetComponent<Renderer>();
        //liquid = GetComponentInChildren<Renderer>();
        counter = 0;
        
    }

    void OnTriggerEnter(Collider plyr) {
        if (plyr.tag == "Player")
        {
            recipeBook = BAGOBJCheck.checkRecipeEnable;
            entered = true;
            Debug.Log(recipeBook + "haha");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (recipeBook && entered && plyr.tag == "Player" && counter < 1 && Input.GetKeyDown("e"))
        {
            counter++;
            recipe.enabled = true;
            anim.Play("RecipePlacement");
            glitterSound.Play();
        }
    }
}
