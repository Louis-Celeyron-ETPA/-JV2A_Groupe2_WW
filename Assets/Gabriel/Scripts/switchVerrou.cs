using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class switchVerrou : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                transform.position += Vector3.down * 1f;
            }
        }
    }
}
