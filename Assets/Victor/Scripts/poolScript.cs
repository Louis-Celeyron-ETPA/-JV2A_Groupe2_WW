using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolScript : MonoBehaviour
{

    public Transform positionPlateform;


    // Start is called before the first frame update
    void Start()
    {
        positionPlateform.position = new Vector3(Random.Range(-10, 10), positionPlateform.position.y, positionPlateform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("TSu a gagner.");
        return;


    }
}
