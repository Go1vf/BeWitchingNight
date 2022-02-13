using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasKeyDialogue : MonoBehaviour
{
    public GameObject textCube;
    public Collider other;
    private static bool recipe;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && recipe)
        {
            textCube.SetActive(true);
            textCube.SetActive(false);
        }
    }

    private void Update()
    {
        recipe = BAGOBJCheck.checkRecipeEnable;
    }
}
