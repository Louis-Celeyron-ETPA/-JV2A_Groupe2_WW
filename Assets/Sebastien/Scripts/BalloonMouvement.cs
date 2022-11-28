using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{

    public class BalloonMouvement : MonoBehaviour
    {
        [SerializeField] float speed = 1f;

    // Update is called once per frame
        void Update()
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
        }


    }

}
