using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToggle : MonoBehaviour
{
    public Material night;
    public Material day;
    public AudioSource timeMagic;
    private bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = night;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t") && !on) {
            RenderSettings.skybox = day;
            DynamicGI.UpdateEnvironment();
            on = !on;
            timeMagic.Play();
        } else if (Input.GetKeyDown("t") && on) {
            RenderSettings.skybox = night;
            DynamicGI.UpdateEnvironment();
            on = !on;
            timeMagic.Play();
        }
        
    }
}
