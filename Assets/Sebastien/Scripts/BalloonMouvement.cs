using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMouvement : MonoBehaviour
{

    [SerializeField] float mouvementSpeed = 1f;
    

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * mouvementSpeed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(collision.gameObject);
        }

    }
}
