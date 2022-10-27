using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor {
    public class targetValidation : MonoBehaviour
    {
        public int numeroFenetre;
        public generateWindow listFenetre;

        // Start is called before the first frame update
        void Awake()
        {
            listFenetre = Camera.main.GetComponent<generateWindow>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("coucou");
            if (listFenetre.typeWindow[numeroFenetre] == 1)
            {
                Debug.Log("cla bone");
            }
        }
    }
}


