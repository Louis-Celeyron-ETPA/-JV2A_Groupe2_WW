using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste {
    public class ToucheTempoBruh : MonoBehaviour
    {
        public KeyCode myKey;
        public ThiccHandler thicc;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(myKey) && thicc.transform.position.y == -12)
            {
                thicc.Twerking();
            }
            else if (!Input.GetKey(myKey) && thicc.transform.position.y != -12)
            {
                thicc.NoTwerking();
            }
        }
    }
}
