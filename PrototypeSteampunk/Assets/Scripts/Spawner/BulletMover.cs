using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public float speed;
    //Changes the speed of the bullet that spawned
    public float x;
    public float y;
    public float z;

    // Update is called once per frame
    void Update()
    {
        //transform.position += (new Vector3(spawner.x, spawner.y, spawner.z) * Time.deltaTime * speed);
        transform.position += (new Vector3(x, y, z) * Time.deltaTime * speed);
    }
}
