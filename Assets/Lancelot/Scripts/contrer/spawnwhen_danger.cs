using UnityEngine;
using System.Collections;
// test avec Coroutine infractueux. 
public class spawnwhen_danger : MonoBehaviour
{
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(TempsdeSpawn());
    }

    IEnumerator TempsdeSpawn()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine : " + Time.time);
        gameObject.SetActive(false);
        //yield on a new YieldInstruction that waits for 15 seconds.
        yield return new WaitForSeconds(15);
        gameObject.SetActive(true);
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine : " + Time.time);
    }
}