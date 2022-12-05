using UnityEngine;
using System.Collections;

public class spawnwhen_attention : MonoBehaviour
{
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(TempsdeSpawn());
        gameObject.SetActive(false);

    }

    IEnumerator TempsdeSpawn()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine : " + Time.time);
        //yield on a new YieldInstruction that waits for 10 seconds.
        yield return new WaitForSeconds(10);
        gameObject.SetActive(true);
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine : " + Time.time);
    }
}