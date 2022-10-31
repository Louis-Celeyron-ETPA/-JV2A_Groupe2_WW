using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
    int balloons = 0;

    [SerializeField] Text balloonsText;
    [SerializeField] AudioSource popSound;
    
    public GameObject Balloon;

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Green"))
        {
            Destroy(gameObject);
            balloons++;
            balloonsText.text = "BALLOONS : " + balloons;
            popSound.Play();
        }

        if (gameObject.CompareTag("Gold"))
        {
            Destroy(gameObject);
            balloons++;
            balloonsText.text = "BALLOONS : " + balloons * 2;
            popSound.Play();
        }

        if (gameObject.CompareTag("Red"))
        {
            Destroy(gameObject);
            balloons++;
            balloonsText.text = "BALLOONS : " +- balloons;
            popSound.Play();
        }
    }

   
}
