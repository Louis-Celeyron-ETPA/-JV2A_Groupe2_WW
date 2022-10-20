using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor {
    public class targetValidation : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("dans la cible");

        }
    }
}


