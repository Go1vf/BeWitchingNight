using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAGOBJCheck : MonoBehaviour
{
    public BAG bag;
    public static bool checkKeyEnable;
    public static bool checkRecipeEnable;
    public static bool hasMushroom;
    public static bool hashCrushedMushroom;
    public float range;
    public bool mushShit;
    public Transform startPoint;
    private BagObj objKey;
    private BagObj objRecipe;
    private BagObj objMushroom;
    private BagObj objCrushedMushroom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        {
            if (Physics.Raycast(startPoint.transform.position, startPoint.transform.forward, out hit, range))
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (mushShit)
                    {
                        if (objMushroom == null)
                        {
                            return;
                        }
                        if (hit.transform.tag == "MushPlace" && objMushroom.gameObject != null)
                        {
                            hasMushroom = true;
                            Debug.Log("Mushroom Collected");
                            bag.CREATEITEM(objMushroom.data);
                            Destroy(objMushroom.gameObject);
                        }
                    }

                    if (checkRecipeEnable)
                    {
                        if(objRecipe == null)
                        {
                            return;
                        }
                        if (hit.transform.tag == "RecipePlace" && objRecipe.gameObject != null)
                        {
                            Debug.Log("Recipe Collected");
                            bag.CREATEITEM(objRecipe.data);
                            Destroy(objRecipe.gameObject);
                        }
                    }

                    if (objKey == null) {
                        Debug.Log("null pointer");
                        return; 
                    }
                    if (hit.transform.tag == "KeyPlace" && objKey.gameObject != null)
                    {
                        Debug.Log("Key Collected");
                        checkKeyEnable= true;
                        bag.CREATEITEM(objKey.data);
                        Destroy(objKey.gameObject);
                    }
                   
                    if (hashCrushedMushroom)
                    {
                        if (hit.transform.tag == "CrushedMushroomPlace" && objCrushedMushroom.gameObject != null)
                        {
                            Debug.Log("CrushedMushroom Collected");
                            bag.CREATEITEM(objCrushedMushroom.data);
                            Destroy(objCrushedMushroom.gameObject);
                        }
                    }
                }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RecipeBook")
        {
            checkRecipeEnable = true;
            objRecipe = other.gameObject.GetComponent<BagObj>();
        } else if (other.tag == "Key")
        {
            Debug.Log("Key Collides"); 
            objKey = other.gameObject.GetComponent<BagObj>();
        } else if (other.tag == "Mushroom")
        {
            Debug.Log("Mushroom Collides");
            objMushroom = other.gameObject.GetComponent<BagObj>();
            mushShit = true;
        } else if (other.tag == "CrushedMushroom")
        {
            Debug.Log("Goop collides");
            hashCrushedMushroom = true;
            objCrushedMushroom = other.gameObject.GetComponent<BagObj>();
        }
    }
}
