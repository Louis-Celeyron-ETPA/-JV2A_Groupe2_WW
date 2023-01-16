using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{

    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = ManagerManager.GlobalGameManager.MinigamesFinished.ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
