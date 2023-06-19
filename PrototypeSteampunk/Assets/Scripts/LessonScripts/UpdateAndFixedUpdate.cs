using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        // Called every physics step
        // FixedUpdates are consistent
        // Used for regular updates such as:
        // Adjusting physics (Ridgidbody) objects

        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }


    void Update()
    {
        // Called every frame
        // Used for regular updates such as:
        // Moving non-physics objects
        // Simple Input
        // Receiving Input
        
        // Update interval times vary
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
