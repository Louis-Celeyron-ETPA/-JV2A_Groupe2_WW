using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoCible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        TempoRythm monTempo = other.GetComponent<TempoRythm>();

        if (monTempo != null)
        {
            monTempo.tempoState = 1;
            Debug.Log("coucou 1");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TempoRythm monTempo = other.GetComponent<TempoRythm>();

        monTempo.tempoState = 2;
        Debug.Log("coucou 2");
    }
}
