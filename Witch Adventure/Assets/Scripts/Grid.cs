using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int receiveID;
    public Transform targetpos;

    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool  OnRelese(GRABOBJ obj)
    {
        int id = obj.ID;
        if (id == receiveID)
        {
            Debug.Log("Right");
            obj.SETTRAGET(targetpos,false);
            audio.Play();
            return true;
        } else {
            Debug.Log("Wrong!");
            return false;
        }
    }
}
