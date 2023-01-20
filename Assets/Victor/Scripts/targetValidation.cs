using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor {
    public class TargetValidation : MonoBehaviour
    {
        public int numeroFenetre;

        public bool isGood;

        [SerializeField]
        private MeshRenderer mr;

        // Start is called before the first frame update
        void Awake()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isGood == true)
            {
                mr.material.color = new Color (0,1f,0);
            }
            if (isGood == false)
            {
                mr.material.color = new Color(0, 0, 1f);
            }
        }

    }
}
