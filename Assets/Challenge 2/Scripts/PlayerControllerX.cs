using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCoolDown = 2.0f;
    private float lastSpawnTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && CanSpawnDog())
        {
            DogSpawn();
        }
    }

    void DogSpawn()
    {
        // Instantiate the dog at the current object's position and rotation
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        // Update the last spawn time to the current time
        lastSpawnTime = Time.time;
    }

    bool CanSpawnDog()
    {
        return Time.time > lastSpawnTime + spawnCoolDown;
    }
}
