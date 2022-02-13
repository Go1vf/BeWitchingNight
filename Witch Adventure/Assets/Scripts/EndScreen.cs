using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    private static bool endGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
    if (other.tag == "flask") {
            Debug.Log("you did it");
         SceneManager.LoadScene(1);
     }
    }

    // Update is called once per frame
    void Update()
    {
        endGame = addIngredient.gameOver;
    }
}
