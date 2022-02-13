using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform teleportTarget;
    [SerializeField] GameObject thePlayer;

    public AudioSource splashSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Teleport player to object
            splashSound.Play();
            thePlayer.transform.position = teleportTarget.transform.position;
        }

    }
}
