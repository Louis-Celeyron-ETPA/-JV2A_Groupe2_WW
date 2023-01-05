using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{

    public class BalloonSpawner : MonoBehaviour
    {
        public float delay = 1f;
        public GameObject greenPrefab;
        public GameObject redPrefab;
        public GameObject goldPrefab;


        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Spawn", delay, delay);
        }

        void Spawn()
        {
            Instantiate(greenPrefab, new Vector3(Random.Range(-4, 4), -5, 0), Quaternion.identity); // Quaternion prevents rotation
            Instantiate(redPrefab, new Vector3(Random.Range(-4, 4), -7, 0), Quaternion.identity);
            Instantiate(goldPrefab, new Vector3(Random.Range(-4, 4), -10, 0), Quaternion.identity);
        }

    }

}

