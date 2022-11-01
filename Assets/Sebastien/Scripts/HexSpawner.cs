using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class HexSpawner : MonoBehaviour
    {
        public float spawnRate = 1f;

        public GameObject hexagonPrefab;

        private float spawnTime = 0f;


        // Update is called once per frame
        void Update()
        {
            if (Time.time >= spawnTime)
            {
                Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
                spawnTime = Time.time + 1f / spawnRate;
            }
        }
    }
}
