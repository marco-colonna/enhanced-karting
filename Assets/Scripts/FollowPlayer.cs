using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Holds the player's kart GameObject
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // LateUpdate is called after all Update functions have been called
    void LateUpdate()
    {
        // Get the position of the player's kart
        Vector3 newPosition = player.transform.position;
        // Ignore the y-coordinate of the player's kart
        newPosition.y = transform.position.y;
        // Update position using the new position
        transform.position = newPosition;

        // Match the player's kart rotation
        transform.rotation = Quaternion.Euler(90f, player.transform.eulerAngles.y, 0f);
    }
}
