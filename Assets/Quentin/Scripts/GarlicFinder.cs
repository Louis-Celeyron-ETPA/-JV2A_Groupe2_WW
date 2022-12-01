using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicFinder : MonoBehaviour

{
    // Start is called before the first frame update
    public bool finded = false;
    void Start()
    {
        
    }

    /*void OnCollisionStay(Collision collisionInfo)
    {
        // Debug-draw all contact points and normals
        foreach (ContactPoint contact in collisionInfo.contsacts)
        {
            Debug.DrawRay(contact.point, contact.normal * 10, Color.white);
        }
    }*/
    void Update()
    {
       
        if (finded == true)
        {
            Debug.Log("Games end");
        }
    }
}
