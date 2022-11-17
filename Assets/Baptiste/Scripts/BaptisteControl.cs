using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste
{

    public class BaptisteControl : MonoBehaviour
    {
        private GameObject newObject;

        public float currentTime;
        public float lastFired;
        public List<GameObject> gameObjectList;
        public GameObject MargoulinProj;
        // Start is called before the first frame update
        void Start()
        {
            lastFired = 0;
            gameObjectList = new List<GameObject>();
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            foreach (GameObject item in gameObjectList)
            {
                item.transform.position += Vector3.right * 0.2f;
            }
        }

        public void BaptisteUp()
        {
            if (transform.position.y < 5.8f)
            {
                transform.position += Vector3.up * 0.2f; ;
            }
        }

        public void BaptisteDown()
        {
            if (transform.position.y > -3.6f)
            {
                transform.position -= Vector3.up * 0.2f;
            }
        }

        public void FireMargoulin()
        {
            if (currentTime - lastFired > 0.2f)
            {
                newObject = Instantiate(MargoulinProj, new Vector3(-7.5f, transform.position.y, 0), Quaternion.identity);
                gameObjectList.Add(newObject);
                lastFired = currentTime;
            }
        }
    }
}
