using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMushDia : MonoBehaviour
{
    private static bool mushroom;
    private int count;
    public Collider other;
    //Post-Recipe Dialogues
    public GameObject specialRoot;
    public GameObject startPotion;
    public GameObject morter;
    public GameObject cauldron3;



    private void Update()
    {
        mushroom = BAGOBJCheck.hasMushroom;
        if (mushroom && count < 1)
        {
            specialRoot.SetActive(true);
            startPotion.SetActive(true);
            morter.SetActive(true);
            cauldron3.SetActive(true);
            count += 1;
        }
    }
}
