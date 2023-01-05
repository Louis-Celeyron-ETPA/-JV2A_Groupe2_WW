using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Quentin
{
    public class movedirection : MonoBehaviour
    {
        public Transform Mytransform;
        public Transform Followtransform;
        public float speed = 0.5f;
        public Vector3 Myvector;


        // Start is called before the first frame update
        void Start()
        {
            Myvector = new Vector3(Followtransform.position.x - Mytransform.position.x, Followtransform.position.y - Mytransform.position.y, Followtransform.position.z - Mytransform.position.z);

        }

        // Update is called once per frame
        void Update()
        {
            if (Mytransform.position.x != Followtransform.position.x)
            {
                transform.Translate(Myvector * Time.deltaTime);

            }
        }
    }
}