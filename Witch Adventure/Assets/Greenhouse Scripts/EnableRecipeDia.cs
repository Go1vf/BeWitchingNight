using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRecipeDia : MonoBehaviour
{
    private static bool recipe;
    private int count;
    public Collider other;
    //Post-Recipe Dialogues
    public GameObject toBrewStandCube;
    public GameObject atBrew;
    public GameObject outsidePumpkin;
    public GameObject seeFlood;
    public GameObject noFlood;



    private void Update()
    {
        recipe = BAGOBJCheck.checkRecipeEnable;
        if (recipe && count < 1)
        {
            toBrewStandCube.SetActive(true);
            atBrew.SetActive(true);
            outsidePumpkin.SetActive(true);
            seeFlood.SetActive(true);
            noFlood.SetActive(true);
            count += 1;
        }
    }
}
