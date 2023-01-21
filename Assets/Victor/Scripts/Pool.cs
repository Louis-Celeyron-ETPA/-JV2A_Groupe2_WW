using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    public class Pool : MonoBehaviour
    {

        [SerializeField]
        private Transform positionPlateform;

        // Start is called before the first frame update
        void Start()
        {
            positionPlateform.position = new Vector3(Random.Range(-6, 6), positionPlateform.position.y, positionPlateform.position.z);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}