using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // set the speed of obstacle moving
    private float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // moving the position of the obstacles
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
