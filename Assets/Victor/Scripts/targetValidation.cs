using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor {
    public class targetValidation : MonoBehaviour
    {
        public int numeroFenetre;

        public bool isGood;

        public generateWindow listFenetre;
        
        public MeshRenderer mr;

        // Start is called before the first frame update
        void Awake()
        {
            listFenetre = Camera.main.GetComponent<generateWindow>();
        }

        // Update is called once per frame
        void Update()
        {
            if (isGood == true)
            {
                mr.material.color = new Color (0,1f,0);
            }
        }
        private void OnTriggerEnter(Collider other)
        {

        }
    }
}
