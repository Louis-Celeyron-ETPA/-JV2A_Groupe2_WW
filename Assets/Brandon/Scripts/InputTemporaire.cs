using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Brandon;

public class InputTemporaire : MonoBehaviour
{

    public Voleur voleur;
    public Tapette tapette;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            voleur.descending = true;
            tapette.slap = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            tapette.upArrow = true;

        }

        if (Input.GetKeyUp(KeyCode.UpArrow) == true)
        {
            tapette.upArrow = false;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            tapette.downArrow = true;

        }

        if (Input.GetKeyUp(KeyCode.DownArrow) == true)
        {
            tapette.downArrow = false;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            tapette.leftArrow = true;

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) == true)
        {
            tapette.leftArrow = false;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            tapette.rightArrow = true;

        }

        if (Input.GetKeyUp(KeyCode.RightArrow) == true)
        {
            tapette.rightArrow = false;

        }
    }

    
}
