using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class HexRotater : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
        }
    }
}
