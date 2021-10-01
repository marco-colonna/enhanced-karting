using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    // Holds the player input
    private float input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player input
        input = Input.GetAxis("Reset");
        
        // Check if "Reset" or "r" key is pressed
        if (input == 1)
        {
            // Hard reset by reloading the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
