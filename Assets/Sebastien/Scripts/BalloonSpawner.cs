using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class BalloonSpawner : MonoBehaviour
    {
        public GameObject[] balloonPrefab;

        public Transform spawnPos;

        int randomInt;
           
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnRandom();
            }
        }

        void SpawnRandom ()
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 10), 5, Random.Range(-10, 10));
            Instantiate(balloonPrefab[randomInt], spawnPos.position, Quaternion.identity);
            //Quaternion = no rotation//
            //spawnPos.rotation
            
        }
    }

}

