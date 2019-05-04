using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // setting up spwan time for the obstacle
    private float spawnTime = 1.3f;
    // timer to spawn obstacles
    private float timer = 0;
    // setting random height for to spawn
    private float height = 2;
    // prefab to respawn
    public GameObject obstacle;

    // Update is called once per frame
    void Update()
    {
        //checking the time to spwn objects
        if (timer > spawnTime)
        {
            //generating object
            GameObject newObstacle = Instantiate(obstacle);
            //setting random height to spawn
            newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            //destroy object after specified time
            Destroy(newObstacle, 10);
            timer = 0;
        }

        // increase timer by deltatime
        timer += Time.deltaTime;
    }
}
