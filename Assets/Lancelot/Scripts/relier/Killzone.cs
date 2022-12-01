using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void OnCollisionEnter(Collision other) {
            if (other.gameObject.tag == "Red")
            {
                Destroy(gameObject);
            }
            {
                if (other.gameObject.tag == "Blue")
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}