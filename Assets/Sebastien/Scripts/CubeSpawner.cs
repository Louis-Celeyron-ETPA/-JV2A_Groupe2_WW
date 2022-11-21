using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public float delay = 0.2f;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    void Spawn()
    {
        Instantiate(cube, new Vector3(Random.Range(-8, 8), 10, 0), Quaternion.identity); // Quaternion prevents rotation
    }

}
