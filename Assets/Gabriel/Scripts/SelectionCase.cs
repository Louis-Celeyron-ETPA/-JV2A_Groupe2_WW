using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class SelectionCase : MonoBehaviour
    {

        public int positionCurseur;
        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(-8f, 5f, -10f);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                positionCurseur -= 1;
                if (positionCurseur < 0) { positionCurseur = 3; }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                positionCurseur += 1;
                if (positionCurseur > 3) { positionCurseur = 0; }
            }

            transform.position = new Vector3(-8f + (positionCurseur)*5f, 5f, -10f);
        }
    }
}
